Public Class Matrix_setup
    Private Sub Matrix_setup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Login
            .form = Me
            .AccessID.Text = "ADMIN"
            .ShowDialog()
        End With
    End Sub

    Private Sub AcctionBtn(sender As Object, e As EventArgs) Handles matrixbtn.Click, machinebtn.Click, userbtn.Click, otherbtn.Click
        Select Case sender.text
            Case "MATRIX"
                maintTab.SelectedIndex = 0
            Case "MACHINE"
                maintTab.SelectedIndex = 1
            Case "USER ACCESS"
                maintTab.SelectedIndex = 2
            Case "OTHERS"
                maintTab.SelectedIndex = 3
        End Select
    End Sub
End Class