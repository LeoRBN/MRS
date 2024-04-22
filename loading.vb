Imports System.IO
Imports System.Threading

Public NotInheritable Class loading
    Private Sub loading_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Starter()
        Get_Network_Access()
        LoadingMsg.Text = Nothing

        Timer1.Start()
        AppName.Text = application_name
        CopyRight.Text = My.Application.Info.Copyright
        Version.Text = Application.ProductVersion

        LoadingMsg.Text = "Checking Resources....."
        'Check Resources
        Dim TargetDir As String = "C:\" & application_name
        Call CopyDirectory(My.Settings.System_Updater, TargetDir)

        LoadingMsg.Text = "Checking for update....."

        notifier.Path = My.Settings.System_Notifier
        notifier.EnableRaisingEvents = True

        EXEC_QRY("@@MethodType = 'AU_DEVICES',@ID = '" + DeviceName + "'", Nothing)
        If ds.Tables(0).Rows.Count <> 0 Then
            My.Settings.User_ID = "0prt-1"
            My.Settings.Save()
        End If

        If WindowsACC.Contains("kitter") = True Then
            My.Settings.User_ID = "k3tt1ng"
            My.Settings.Save()
        ElseIf WindowsACC.Contains("rabino") = True Then
            My.Settings.User_ID = "C@ladm"
            My.Settings.Save()
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()

        Check_Update()

        Thread.Sleep(1000)
        StartPage.Show()
        'Me.Hide()
        If WindowsACC.Contains("kitter") = True Then
            Me.Hide()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub notifier_Created(sender As Object, e As FileSystemEventArgs) Handles notifier.Created
        Try
            Dim notif As NotifyIcon = Main_Kitting.pop_notification
            Dim IDS As String = Path.GetFileNameWithoutExtension(e.FullPath)
            Dim split As String() = IDS.Split("-")
            Dim Title As String = split(0)
            Dim Type As String = split(1)
            Dim Msg As String = split(2)

            'notification format::  <TITLE> <TYPE> <MATCODE - MACHINE>

            If WindowsACC.Contains("kitter") = True Then

                If Title.Trim = "NEW MATERIAL REQUEST" Or Title = "FOLLOW UP" Or Title.Contains("B800_") Or Title.Trim = "GOLDWIRE REQUEST" Then
                    If notification_alert(Title, Type, Msg, Main_Kitting, notif) = True Then
                        Get_Network_Access()
                        DEL_file(My.Settings.System_Notifier, "txt")

                    End If
                Else

                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
