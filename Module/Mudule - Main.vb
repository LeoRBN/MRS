Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Data
Imports System
Imports System.IO
Imports System.Diagnostics
Imports Microsoft.Office.Core
Imports Microsoft.Office.Interop
Imports System.Threading
Imports Tulpep.NotificationWindow
Module Mudule___Main
    Public sqlConnect As String = "Provider=SQLOLEDB;Server=calsw00158;Database=CAPAB800DB;User Id=calcapaadm;Password = calb800capa_us3r;"
    Public myConn As New OleDb.OleDbConnection
    Public mySQLConn As SqlConnection
    Public cmd As New OleDb.OleDbCommand
    Public da As New OleDb.OleDbDataAdapter
    Public ds As New DataSet
    Public dt As New DataTable
    Public application_name As String = Application.ProductName
    Public current_version As String = Application.ProductVersion
    Public update_version As String = Nothing
    Public update_path As String = Nothing
    Public uploadDS As New DataSet()
    Public Mutex As Mutex
    Public userID As String = Nothing
    Public userPass As String = Nothing
    Public userLvl As String = Nothing
    Public Xbool As Boolean = False
    Public WindowsACC As String = Environment.UserName
    Public DeviceName As String = My.Computer.Name
#Region "DECLARED VARIABLES"
    ' FORM SIZE FOR newEndorseDrm - RAW
    Public OriginalSize As New Size(421, 442)
    Public IssuanceSize As New Size(421, 500)
    Public HoldingSize As New Size(813, 351)

    Public totalQTY As Integer
    Public TRNID As String
    Public LOT As String
    Public actionType As String = Nothing
    Public UserAccess As String
    Public STATUS As String = Nothing
    Public selectedRow As DataGridViewRow
    Public xtag As String
    Public trackoutFnc As String
    Public CSVname As String
    Public notifproduct As String = Nothing

    Public SQLrowCount As String

    Public NewItem As Boolean = False
    Public ReleaseItem As Boolean = False
    Public updateItem As Boolean = False
    Public holdItem As Boolean = False
    Public Unhold As Boolean = False
    Public Upload As Boolean = False
    Public CurrentDate As String
    Public Transact As Boolean = False
    Public AU_status As String = Nothing



#End Region

#Region "SYSTEM FUNCTION"
    Sub ConnectDB()
        myConn = New OleDb.OleDbConnection
        Try
            With myConn
                If .State = ConnectionState.Open Then .Close()
                .ConnectionString = sqlConnect
                .OpenAsync()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Sub Get_Network_Access()
        '//====================================================================================
        '//using NET USE to open a connection to the remote computer
        '//with the specified credentials. if we dont do this first, File.Copy will fail
        '//====================================================================================
        Dim ProcessStartInfo As New System.Diagnostics.ProcessStartInfo
        ProcessStartInfo.FileName = "net"
        ProcessStartInfo.Arguments = "use \\cal-eeassysvroi\c$ /USER:cal_eeassysvr @ss3mbly"
        ProcessStartInfo.WindowStyle = ProcessWindowStyle.Hidden
        System.Diagnostics.Process.Start(ProcessStartInfo)

        '//============================================================================
        '//wait 2 seconds to let the above command complete or the copy will still fail
        '//============================================================================
        System.Threading.Thread.Sleep(2000)
    End Sub
    Public Sub Check_Update()
        Dim str As String = "Exec [SP_Application_Update] @_Func = 'VERSION_CHECKING',@Temp = 'CHECK', @App_name = "
        Dim tblname As String = "SP_Application_Update"
        Dim app As String = "'" & application_name & "'"

        Try
            ConnectDB()
            ds = New DataSet
            cmd.CommandText = str + app
            cmd.Connection = myConn
            da.SelectCommand = cmd
            da.Fill(ds, tblname)

            If ds.Tables(tblname).Rows.Count > 0 Then
                Dim newVersion As String = ds.Tables(0).Rows(0)("System_Version").ToString
                Dim currVersion As String = Application.ProductVersion
                Dim parentFolder As String = ds.Tables(0).Rows(0)("File_Path").ToString
                Dim UpdaterLocation As String = My.Settings.System_Updater
                Dim UpdateLog As String = ds.Tables(0).Rows(0)("Remarks").ToString
                Dim ReleaseDate As String = ds.Tables(0).Rows(0)("Update_Date").ToString
                Dim VersionPath As String = Path.GetDirectoryName(Path.GetDirectoryName(parentFolder))

                If newVersion > currVersion Then
                    If MsgBox("NEW UPDATE AVAILABLE!" & vbNewLine & vbNewLine & "Application : " & vbTab & application_name & vbNewLine & "Version :" & vbTab & vbTab & newVersion & vbNewLine & "Released Date : " & vbTab & ReleaseDate & vbNewLine & vbNewLine & "Details :" & vbNewLine & UpdateLog & vbNewLine & vbNewLine & "Do you want to restart now?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

                    Dim TargetDir As String = "C:\" & application_name
                    Dim Folderversion As String = TargetDir & "\Version"
                    Call CopyDirectory(My.Settings.System_Updater, TargetDir)
                    Call CopyDirectory(Path.Combine(VersionPath, newVersion), Folderversion)

                    Dim startAPP As New ProcessStartInfo
                    startAPP.FileName = "C:\" & application_name & "\B800_version_updater.exe"
                    startAPP.WindowStyle = ProcessWindowStyle.Normal
                    Process.Start(startAPP)
                    Process.Start(My.Settings.Manual)
                    Process.Start(My.Settings.UpdateLog)
                    loading.Close()
                    Application.Exit()
                End If
            End If
        Catch
        End Try

    End Sub

    Public Sub CopyDirectory(ByVal sourceDir As String, ByVal targetDir As String)
        If Not Directory.Exists(targetDir) Then
            Directory.CreateDirectory(targetDir)
        End If

        Dim sourceDirInfo As New DirectoryInfo(sourceDir)
        Dim targetDirInfo As New DirectoryInfo(targetDir)

        For Each file In sourceDirInfo.GetFiles()
            file.CopyTo(Path.Combine(targetDirInfo.FullName, file.Name), True)
        Next

        For Each subDir In sourceDirInfo.GetDirectories()
            CopyDirectory(subDir.FullName, Path.Combine(targetDirInfo.FullName, subDir.Name))
        Next
    End Sub

    Public Function loginAccess(qry As String, xfunction As String, tblname As String) As Boolean
        ds = New DataSet()
        ConnectDB()
        cmd.CommandText = qry
        cmd.Connection = myConn
        da.SelectCommand = cmd
        da.Fill(ds, tblname)
        Try
            If ds.Tables(tblname).Rows.Count > 0 Then
                UserAccess = Trim(ds.Tables(0).Rows(0).Item("Access_Level").ToString())
                userID = Trim(ds.Tables(0).Rows(0).Item("ID_No").ToString())

                If UserAccess = "ADMIN" Or UserAccess = "OPERATOR" Or UserAccess = "KITTER" Then
                    Return True
                End If
                Return False
            Else
                MessageBox.Show("Wrong User or Password!")
                Return False
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function
    Public Sub Starter()
        'CLEAN RESTART THE PROGRAM
        Try
            Mutex = New Mutex(True, application_name)

            If Not Mutex.WaitOne(0, False) Then
                Dim currentProcess As Process = Process.GetCurrentProcess()
                For Each process As Process In Process.GetProcessesByName(currentProcess.ProcessName)
                    If process.Id <> currentProcess.Id Then
                        process.Kill()
                    End If
                Next
            End If
        Catch ex As Exception
            Mutex = New Mutex(True, application_name)

            If Not Mutex.WaitOne(0, False) Then
                Dim currentProcess As Process = Process.GetCurrentProcess()
                For Each process As Process In Process.GetProcessesByName(currentProcess.ProcessName)
                    If process.Id <> currentProcess.Id Then
                        process.Kill()
                    End If
                Next
            End If
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Function notification_alert(title As String, type As String, msg As String, form As Form, notif As NotifyIcon) As Boolean

        If title.Contains("AVAILABLE") Then Exit Function

        Try
            Dim titletrim As String = Trim(title)
            Dim TypeID As String = Nothing

            If titletrim = "NEW MATERIAL REQUEST" Or titletrim.Contains("B800_") = True Then
                My.Computer.Audio.Play(My.Resources.Low_notif, AudioPlayMode.Background)
            ElseIf titletrim = "GOLDWIRE REQUEST" Then
                My.Computer.Audio.Play(My.Resources.AU_notif, AudioPlayMode.Background)
            Else
                My.Computer.Audio.Play(My.Resources.Low_notif, AudioPlayMode.Background)
            End If

            If type = "EPOXY" Or type = "LOCTITE" Then
                TypeID = "EPOXY"
            ElseIf type = "INDIRECT" Then
                TypeID = "IDM"
            ElseIf type = "GOLDWIRE" Then
                TypeID = "GOLDWIRE"
            Else
                TypeID = "RAW"
            End If

            If form.Visible = True Then
                form.TopMost = True

                With Main_Kitting
                    Select Case TypeID
                        Case "IDM"
                            If Not .MainTABCtrl.SelectedIndex = 0 Then
                                .MainTABCtrl.SelectedIndex = 0
                                .idmTABmain.SelectedIndex = 1
                                .idm_new.PerformClick()
                                form.Update()
                            End If
                        Case "RAW"
                            If Not .MainTABCtrl.SelectedIndex = 1 Then
                                .MainTABCtrl.SelectedIndex = 1
                                .rawmainTAB.SelectedIndex = 6
                                .rw_new.PerformClick()
                                form.Update()
                            End If
                        Case "EPOXY"
                            If Not .MainTABCtrl.SelectedIndex = 2 Then
                                .MainTABCtrl.SelectedIndex = 2
                                .e_new.PerformClick()
                                form.Update()
                            End If
                        Case "GOLDWIRE"
                            If Not .MainTABCtrl.SelectedIndex = 3 Then
                                .MainTABCtrl.SelectedIndex = 3
                                .g_new.PerformClick()
                                form.Update()
                            End If

                    End Select
                End With
                form.WindowState = FormWindowState.Maximized
                form.TopMost = False

            Else
                form.TopMost = True
                form.Show()

                If form.Name = "Main_Kitting" Then

                    With Main_Kitting
                        Select Case TypeID
                            Case "IDM"
                                .MainTABCtrl.SelectedIndex = 0
                                .idmTABmain.SelectedIndex = 1
                                .idm_new.PerformClick()
                                form.Update()
                            Case "RAW"
                                .MainTABCtrl.SelectedIndex = 1
                                .rawmainTAB.SelectedIndex = 6
                                .rw_new.PerformClick()
                                form.Update()
                            Case "EPOXY"
                                .MainTABCtrl.SelectedIndex = 2
                                .e_new.PerformClick()
                                form.Update()
                            Case "GOLDWIRE"
                                .MainTABCtrl.SelectedIndex = 3
                                .g_new.PerformClick()
                                form.Update()
                        End Select
                    End With

                End If
                form.WindowState = FormWindowState.Maximized
                form.Update()
                form.TopMost = False

            End If

            notif.BalloonTipIcon = ToolTipIcon.Info
            notif.BalloonTipText = type & vbNewLine & msg
            notif.BalloonTipTitle = title
            notif.ShowBalloonTip(5000)

            Main_Kitting.INV_RUN(1)

            Return True

        Catch ex As Exception
            MsgBox(ex.Message)
            'Return False
        End Try

    End Function
    Sub MouseRightClick(sender As Object, e As DataGridViewCellMouseEventArgs, dgv As DataGridView, menu As ContextMenuStrip)
        Try
            selectedRow = dgv.SelectedRows(0)
            If dgv.SelectedRows.Count > 0 Then
                If e.Button = MouseButtons.Right Then
                    dgv.Rows(e.RowIndex).Selected = True
                    dgv.CurrentCell = dgv.Rows(e.RowIndex).Cells(1)
                    menu.Show(dgv, e.Location)
                    menu.Show(Cursor.Position)
                End If
            End If
        Catch
        End Try
    End Sub


#End Region

#Region "LOAD DATA FROM DATABASE"
    Public Function Load_data_from_db(qry As String, dgv As DataGridView, xfunction As String, id As String, cb As ComboBox, chkl As CheckedListBox) As Boolean

        Dim tblname As String = Nothing
        Dim Str As String = Nothing

        Str = "Exec [CAPAB800DB].[dbo].[SP_B800_MRS_2.0] "
        tblname = "SP_B800_MRS_2.0"

        Try
            ConnectDB()
            ds = New DataSet
            cmd.CommandText = Str + qry
            cmd.Connection = myConn
            da.SelectCommand = cmd
            da.Fill(ds, tblname)

            Select Case xfunction
                Case "RAW"
                    dgv.DataSource = Nothing
                    dgv.DataSource = ds.Tables(tblname)
                    Dim status As String = Nothing

                    'kulaykulay
                    Dim green As Color = Color.Honeydew
                    Dim gray As Color = Color.FromArgb(224, 224, 224)
                    Dim red As Color = Color.FromArgb(255, 192, 192)

                    For x As Integer = 0 To ds.Tables(0).Rows.Count - 1
                        Dim type As String
                        Try
                            type = ds.Tables(0).Rows(x).Item("STATUS").ToString.Trim()
                        Catch
                            type = ds.Tables(0).Rows(x).Item("Status").ToString.Trim()
                        End Try

                        With ds.Tables(0).Rows(x)
                            Select Case UCase(Type)
                                Case "IN STOCK"
                                    dgv.Rows(x).DefaultCellStyle.BackColor = green
                                    dgv.Rows(x).DefaultCellStyle.ForeColor = Color.Black
                                Case "NO STOCK"
                                    dgv.Rows(x).DefaultCellStyle.BackColor = gray
                                    dgv.Rows(x).DefaultCellStyle.ForeColor = Color.Black
                                Case "HOLD"
                                    dgv.Rows(x).DefaultCellStyle.BackColor = red
                                    dgv.Rows(x).DefaultCellStyle.ForeColor = Color.Black
                                Case "SCRAPPED"
                                    dgv.Rows(x).DefaultCellStyle.BackColor = Color.Black
                                    dgv.Rows(x).DefaultCellStyle.ForeColor = Color.White
                                Case "STILL IN LINE"
                                    dgv.Rows(x).DefaultCellStyle.BackColor = Color.LemonChiffon
                                    dgv.Rows(x).DefaultCellStyle.ForeColor = Color.Black
                                Case "NEW MATERIAL REQUEST"
                                    dgv.Rows(x).DefaultCellStyle.BackColor = Color.Red
                                    dgv.Rows(x).DefaultCellStyle.ForeColor = Color.White
                                Case "NEW REQUEST"
                                    dgv.Rows(x).DefaultCellStyle.BackColor = Color.Red
                                    dgv.Rows(x).DefaultCellStyle.ForeColor = Color.White
                                Case "AVAILABLE"
                                    dgv.Rows(x).DefaultCellStyle.BackColor = Color.Green
                                    dgv.Rows(x).DefaultCellStyle.ForeColor = Color.White
                                Case "PENDING"
                                    dgv.Rows(x).DefaultCellStyle.BackColor = Color.Gray
                                    dgv.Rows(x).DefaultCellStyle.ForeColor = Color.White
                                Case "RECEIVED"
                                    dgv.Rows(x).DefaultCellStyle.BackColor = Color.Aqua
                                    dgv.Rows(x).DefaultCellStyle.ForeColor = Color.Black
                                Case "WITHDRAWN"
                                    dgv.Rows(x).DefaultCellStyle.BackColor = Color.Orange
                                    dgv.Rows(x).DefaultCellStyle.ForeColor = Color.Black
                                Case "CLOSED"
                                    dgv.Rows(x).DefaultCellStyle.BackColor = Color.Pink
                                    dgv.Rows(x).DefaultCellStyle.ForeColor = Color.Black
                            End Select
                        End With
                    Next x

                Case "EPOXY"
                    'DGV
                    dgv.DataSource = Nothing
                    dgv.DataSource = ds.Tables(tblname)

                    For x As Integer = 0 To ds.Tables(0).Rows.Count - 1
                        Dim Status As String
                        Try
                            Status = ds.Tables(0).Rows(x).Item("Status").ToString.Trim()
                        Catch
                            Status = ds.Tables(0).Rows(x).Item("STATUS").ToString.Trim()
                        End Try
                        With ds.Tables(0).Rows(x)
                            Select Case status
                                Case "NEW MATERIAL REQUEST"
                                    dgv.Rows(x).DefaultCellStyle.BackColor = Color.Red
                                    dgv.Rows(x).DefaultCellStyle.ForeColor = Color.White
                                Case "NEW REQUEST"
                                    dgv.Rows(x).DefaultCellStyle.BackColor = Color.Red
                                    dgv.Rows(x).DefaultCellStyle.ForeColor = Color.White
                                Case "THAWING"
                                    dgv.Rows(x).DefaultCellStyle.BackColor = Color.Yellow
                                    dgv.Rows(x).DefaultCellStyle.ForeColor = Color.Black
                                Case "AVAILABLE"
                                    dgv.Rows(x).DefaultCellStyle.BackColor = Color.Green
                                    dgv.Rows(x).DefaultCellStyle.ForeColor = Color.White
                                Case "FOR RETURN"
                                    dgv.Rows(x).DefaultCellStyle.BackColor = Color.Orange
                                    dgv.Rows(x).DefaultCellStyle.ForeColor = Color.Black
                                Case "PENDING"
                                    dgv.Rows(x).DefaultCellStyle.BackColor = Color.Gray
                                    dgv.Rows(x).DefaultCellStyle.ForeColor = Color.White
                                Case "RECEIVED"
                                    dgv.Rows(x).DefaultCellStyle.BackColor = Color.Aqua
                                    dgv.Rows(x).DefaultCellStyle.ForeColor = Color.Black
                                Case "CLOSED"
                                    dgv.Rows(x).DefaultCellStyle.BackColor = Color.Pink
                                    dgv.Rows(x).DefaultCellStyle.ForeColor = Color.Black
                                Case "UNUSED"
                                    dgv.Rows(x).DefaultCellStyle.BackColor = Color.Blue
                                    dgv.Rows(x).DefaultCellStyle.ForeColor = Color.White
                                Case "WITHDRAWN"
                                    dgv.Rows(x).DefaultCellStyle.BackColor = Color.Orange
                                    dgv.Rows(x).DefaultCellStyle.ForeColor = Color.Black
                            End Select
                        End With
                    Next x

                Case "GOLD"
                    'dgv.Update()
                    dgv.DataSource = Nothing
                    dgv.DataSource = ds.Tables(tblname)

                    For x As Integer = 0 To ds.Tables(0).Rows.Count - 1
                        Dim STATUS As String
                        STATUS = ds.Tables(0).Rows(x).Item("STATUS").ToString.Trim

                        With ds.Tables(0).Rows(x)
                            Select Case STATUS
                                Case "NEW REQUEST"
                                    dgv.Rows(x).DefaultCellStyle.BackColor = Color.MediumBlue
                                    dgv.Rows(x).DefaultCellStyle.ForeColor = Color.White
                                Case "NEW MATERIAL REQUEST"
                                    dgv.Rows(x).DefaultCellStyle.BackColor = Color.MediumBlue
                                    dgv.Rows(x).DefaultCellStyle.ForeColor = Color.White
                                Case "AVAILABLE"
                                    dgv.Rows(x).DefaultCellStyle.BackColor = Color.Chartreuse
                                    dgv.Rows(x).DefaultCellStyle.ForeColor = Color.Black
                                Case "RETURN"
                                    dgv.Rows(x).DefaultCellStyle.BackColor = Color.Gold
                                    dgv.Rows(x).DefaultCellStyle.ForeColor = Color.Black
                                Case "ON-LINE"
                                    dgv.Rows(x).DefaultCellStyle.BackColor = Color.Green
                                    dgv.Rows(x).DefaultCellStyle.ForeColor = Color.White
                                Case "VAULT"
                                    dgv.Rows(x).DefaultCellStyle.BackColor = Color.Pink
                                    dgv.Rows(x).DefaultCellStyle.ForeColor = Color.Black
                                Case "EMPTY"
                                    dgv.Rows(x).DefaultCellStyle.BackColor = Color.IndianRed
                                    dgv.Rows(x).DefaultCellStyle.ForeColor = Color.White
                                Case "FOR DISPO"
                                    dgv.Rows(x).DefaultCellStyle.BackColor = Color.DarkTurquoise
                                    dgv.Rows(x).DefaultCellStyle.ForeColor = Color.Black
                                Case "SCRAP"
                                    dgv.Rows(x).DefaultCellStyle.BackColor = Color.Orange
                                    dgv.Rows(x).DefaultCellStyle.ForeColor = Color.Black
                                Case "ERET"
                                    dgv.Rows(x).DefaultCellStyle.BackColor = Color.Chocolate
                                    dgv.Rows(x).DefaultCellStyle.ForeColor = Color.Black
                            End Select
                        End With
                    Next x

                Case "RETURN ALL"

            End Select

            Return True
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
            Return False
        End Try
        dgv.ClearSelection()

    End Function
#End Region
#Region "EXECUTE QUERY"
    Sub EXEC_QRY(qry As String, xfunction As String)
        Dim tblname As String = Nothing
        Dim Str As String = Nothing

        Str = "Exec [CAPAB800DB].[dbo].[SP_B800_MRS_2.0] "
        tblname = "SP_B800_MRS_2.0"

        Try
            ConnectDB()
            ds = New DataSet
            cmd.CommandText = Str + qry
            cmd.Connection = myConn
            da.SelectCommand = cmd
            da.Fill(ds, tblname)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Sub COMBOBOX(qry As String, col As String, CB As ComboBox)

        Dim tblname As String = Nothing
        Dim Str As String = Nothing

        Str = "Exec [CAPAB800DB].[dbo].[SP_B800_MRS_2.0] "
        tblname = "SP_B800_MRS_2.0"

        Try
            ConnectDB()
            ds = New DataSet
            cmd.CommandText = Str + qry
            cmd.Connection = myConn
            da.SelectCommand = cmd
            da.Fill(ds, tblname)

            CB.DataSource = Nothing
            CB.ValueMember = Nothing

            If ds.Tables(0).Rows.Count > 0 Then
                CB.DataSource = ds.Tables(tblname)
                CB.DisplayMember = col
                CB.ValueMember = col
                CB.Text = Nothing 
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Sub DGV_COMBOBOX(qry As String, col As String, CB As DataGridViewComboBoxColumn)

        Dim tblname As String = Nothing
        Dim Str As String = Nothing

        Str = "Exec [CAPAB800DB].[dbo].[SP_B800_MRS_2.0] "
        tblname = "SP_B800_MRS_2.0"

        Try
            ConnectDB()
            ds = New DataSet
            cmd.CommandText = Str + qry
            cmd.Connection = myConn
            da.SelectCommand = cmd
            da.Fill(ds, tblname)

            CB.DataSource = Nothing
            CB.ValueMember = Nothing

            If ds.Tables(0).Rows.Count > 0 Then
                CB.DataSource = ds.Tables(tblname)
                CB.DisplayMember = col
                CB.ValueMember = col
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
#End Region
#Region "DGV TO TEXTBOX"
    Public Function GetData_DGV_to_CONTROLS(dgv As DataGridView, xfunction As String) As Boolean

        Dim xrow As DataGridViewRow = dgv.SelectedRows(0)
        If dgv.SelectedRows.Count = 1 Then
            Try
                Select Case xfunction
                    Case "LOAD_RAW"
                        '    With newEndorseFrm
                        '        .BatchNo.Text = xrow.Cells("BATCH NUMBER").Value.ToString
                        '        .Matcode.Text = xrow.Cells("MATERIAL CODE").Value.ToString
                        '        .discription.Text = xrow.Cells("MATERIAL DISCRIPTION").Value.ToString
                        '        .currentqty.Text = xrow.Cells("CURRENT QTY").Value.ToString
                        '    End With

                        'Case "LOAD_TRANSACTION"
                        '    With TransactionFrm
                        '        .statusID.Text = xrow.Cells("STATUS").Value.ToString
                        '        .BatchNo.Text = xrow.Cells("BATCH NUMBER").Value.ToString
                        '        .Qty.Text = xrow.Cells("CURRENT QTY").Value.ToString
                        '    End With
                End Select

                Return True
            Catch ex As Exception
            End Try
        Else
            Return False
        End If

    End Function
#End Region

    Public Function RecordCount(qry As String) As Integer
        Dim tblname As String = Nothing
        Dim Str As String = Nothing

        Str = "Exec [CAPAB800DB].[dbo].[SP_B800_MRS_2.0] "
        tblname = "SP_B800_MRS_2.0"

        ConnectDB()
            ds = New DataSet
            cmd.CommandText = Str + qry
            cmd.Connection = myConn
            da.SelectCommand = cmd
            da.Fill(ds, tblname)

            Dim Count As Integer = CInt(ds.Tables(0).Rows.Count)

            Return Count

    End Function
End Module
