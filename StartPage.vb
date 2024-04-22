Public Class StartPage
    Private Sub newRequest_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles kitting.Click
        If My.Settings.User_ID = "C@ladm" Or My.Settings.User_ID = "0prt-00" Then
            Main_Kitting.Show()
        Else
            Main_Kitting.ShowDialog()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles DmRequest.Click
        If My.Settings.User_ID = "C@ladm" Or My.Settings.User_ID = "0prt-00" Then
            DM_Request.Show()
        Else
            DM_Request.ShowDialog()
        End If
    End Sub
    Private Sub AuRequest_Click(sender As Object, e As EventArgs) Handles AuRequest.Click
        If My.Settings.User_ID = "C@ladm" Or My.Settings.User_ID = "0prt-00" Then
            Gold_Request.Show()
        Else
            Gold_Request.ShowDialog()
        End If
    End Sub


    Public Sub StartPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        appName.Text = Application.ProductName
        version.Text = "v" & Application.ProductVersion
        With SoftwareUpdate
            .Interval = My.Settings.AutoUpdate * 60000 * 60
        End With
        Check_Update()

        Dim UserID As String = My.Settings.User_ID

        Select Case UserID
            Case "0prt-0" 'for DM request
                kitting.Enabled = False
                DmRequest.Enabled = True
                AuRequest.Enabled = False
            Case "0prt-1" 'for AU Request & Material request
                kitting.Enabled = False
                DmRequest.Enabled = True
                AuRequest.Enabled = True
            Case "k3tt1ng" 'Kitting Management
                kitting.Enabled = True
                DmRequest.Enabled = False
                AuRequest.Enabled = False
            Case "C@ladm" 'ALL ACCESS
                kitting.Enabled = True
                DmRequest.Enabled = True
                AuRequest.Enabled = True
            Case Else
                kitting.Enabled = False
                DmRequest.Enabled = False
                AuRequest.Enabled = False
        End Select

    End Sub

    Private Sub SwitchAccessToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SwitchAccessToolStripMenuItem.Click
        Setting.ShowDialog()
    End Sub

    Private Sub CheckForUpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckForUpdateToolStripMenuItem.Click
        Try
            Dim startAPP As New ProcessStartInfo
            startAPP.FileName = "C:\" & application_name & "\B800_version_updater.exe"
            startAPP.WindowStyle = ProcessWindowStyle.Normal
            Process.Start(startAPP)
        Catch ex As Exception
            MsgBox("Updater Not found!" & vbNewLine & vbNewLine & ex.Message)
        End Try
    End Sub

    Private Sub UserManualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserManualToolStripMenuItem.Click
        Try
            Process.Start(My.Settings.Manual)
        Catch ex As Exception
            MsgBox("Ongoing Update")
        End Try
    End Sub

    Private Sub SoftwareUpdate_Tick(sender As Object, e As EventArgs) Handles SoftwareUpdate.Tick

        Check_Update()

    End Sub

    Private Sub UpdateLogToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles UpdateLogToolStripMenuItem1.Click
        Try
            Process.Start(My.Settings.UpdateLog)
        Catch ex As Exception
            MsgBox("Ongoing Update")
        End Try
    End Sub

    Private Sub UpdateLogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateLogToolStripMenuItem.Click
        Matrix_setup.Close()
        With Matrix_setup
            .TopMost = True
            .TopMost = False
            .Show()
        End With
    End Sub
End Class