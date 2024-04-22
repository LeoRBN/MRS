Public Class Setting
    Private Sub Setting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        accessCode.Text = My.Settings.User_ID
        refreshData.Text = My.Settings.AutuRefresh
        softUpdate.Text = My.Settings.AutoUpdate
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            My.Settings.User_ID = accessCode.Text.Trim
            My.Settings.AutuRefresh = refreshData.Text.Trim
            My.Settings.AutoUpdate = softUpdate.Text.Trim
            My.Settings.Save()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.Close()
        StartPage.StartPage_Load(sender, e)
    End Sub
End Class