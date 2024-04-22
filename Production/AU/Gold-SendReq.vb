Public Class Gold_SendReq
    Sub dropdown()
        COMBOBOX("@@MethodType = 'RAW_DROPDOWNS',@columnName = 'DATA_STEP',@Type = 'GOLD_PACK'", "DATA_STEP", g_package)
        COMBOBOX("@@MethodType = 'RAW_DROPDOWNS',@Type = 'GOLD_MC',@columnName = 'DATA_STEP'", "DATA_STEP", g_machine)
    End Sub

    Sub getdata()
        EXEC_QRY("@@MethodType = 'GET_AU_DATA',@CollectType = 'AU_ID',@ID = '" + UID.Text.Trim + "'", Nothing)
        Dim cb() As Control = {g_package, g_machine, g_lotid, g_user}
        Dim col() As String = {"PACKAGE", "MACHINE NO", "LOT ID", "REQUESTED_BY"}
        For i As Integer = 0 To cb.Length - 1
            cb(i).Text = ds.Tables(0).Rows(0)(col(i)).ToString
            cb(i).Enabled = False
        Next
    End Sub

    Sub CLEAR()
        Dim cb() As Control = {g_package, g_machine, g_lotid, g_user}
        For i As Integer = 0 To cb.Length - 1
            cb(i).Enabled = True
            cb(i).Text = Nothing
        Next
        g_user.Enabled = False
    End Sub

    Private Sub Gold_SendReq_Load(sender As Object, e As EventArgs) Handles Me.Load
        If UID.Text <> Nothing Then
            Label1.Text = "PENDING REQUEST"
            With g_send
                .BackColor = Color.Red
                .ForeColor = Color.White
                .Text = "FOLLOW UP"
            End With
            getdata()
        Else
            With Login
                .AccessID.Text = "OPERATOR"
                .form = Me
                .ShowDialog()
            End With
            With g_send
                .BackColor = Color.Green
                .ForeColor = Color.White
                .Text = "SEND REQUEST"
            End With
            Label1.Text = "SEND NEW REQUEST"
            CLEAR()
            g_user.Text = userID
            dropdown()
        End If
    End Sub

    Private Sub g_send_Click(sender As Object, e As EventArgs) Handles g_send.Click
        If g_package.Text = "" Or g_machine.Text = "" Or g_lotid.Text = Nothing Then MsgBox("Incomplete fields!") : Exit Sub
        If g_user.Text = "" Then MsgBox("User ID is Empty!. try to login again") : Me.Close() : Exit Sub
        Try
            If UID.Text = Nothing Then
                'Check if the machine has still ON-LINE Spool
                If RecordCount("@@MethodType = 'GET_AU_DATA',@CollectType = 'CheckMC',@Machine = '" + g_machine.Text.Trim + "'") <> 0 Then MsgBox("Please return the Current Spool in this machine (" & g_machine.Text.Trim & ")" & vbNewLine & "to enable New Request" & vbNewLine & vbNewLine & "SPOOL NO :" & vbTab & ds.Tables(0).Rows(0)("SPOOL NO").ToString & vbNewLine & "DATE REQUEST :" & vbTab & ds.Tables(0).Rows(0)("DATE_REQUESTED").ToString & vbNewLine & "STATUS :" & vbTab & vbTab & ds.Tables(0).Rows(0)("STATUS").ToString & vbNewLine) : g_machine.Text = Nothing : Exit Sub
                'confirm
                If MsgBox("Please Confirm!" & vbNewLine & vbNewLine & "PRODUCT :" & vbTab & g_package.Text & vbNewLine & "MACHINE :" & vbTab & g_machine.Text & vbNewLine & vbNewLine & "Countinue?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
                'Proceed
                EXEC_QRY(" @@MethodType = 'AU_TRANSACTION',@CollectType = 'SEND REQUEST',@Package = '" + g_package.Text + "',@Machine = '" + g_machine.Text + "',@Lotno = '" + g_lotid.Text + "',@reqBy = '" + g_user.Text + "',@ComputerName = '" + DeviceName + "'", Nothing)

                'Trigger Notification to kitting
                Get_Network_Access()
                'notification format::  <TITLE> <TYPE> <MATCODE - MACHINE>
                Trigger_Alert("GOLDWIRE REQUEST" & "-GOLDWIRE-" & g_package.Text & "   " & g_machine.Text & "-" & Format(DateTime.Now, "ddMMM HHmmss"))

                MsgBox("Request Sent successfully!")
                Me.Close()
            Else
                'Trigger Notification to kitting
                Get_Network_Access()
                'notification format::  <TITLE> <TYPE> <MATCODE - MACHINE>
                Trigger_Alert("GOLDWIRE REQUEST" & "-GOLDWIRE-" & g_package.Text & "   " & g_machine.Text & "-" & Format(DateTime.Now, "ddMMM HHmmss"))

                MsgBox("Notification Sent!")
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class