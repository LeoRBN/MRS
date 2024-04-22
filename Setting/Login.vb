Imports System.ComponentModel

Public Class Login
    Public form As Form

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        User.Text = Nothing
        password.Text = Nothing
        AccessID.Text = "- - -"

        form.Close()
        Me.Close()
    End Sub

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click

        If loginAccess("Exec [CAPAB800DB].[dbo].[SP_B800_MRS_2.0] @@MethodType = 'LOGIN',@CollectType = 'OPERATOR ACCESS',@Username = '" + User.Text + "',@Password = '" + password.Text + "'", Nothing, "SP_B800_MRS_2.0") = True Then
            If AccessID.Text = UserAccess Or UserAccess = "ADMIN" Then
                Me.Close()
            Else
                MsgBox("ACCESS DENIED!" & vbNewLine & vbNewLine & "This login requires " & AccessID.Text & " account", MsgBoxStyle.Exclamation)
            End If
        Else
            User.Select()
        End If
        User.Text = Nothing
        password.Text = Nothing
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        User.Select()
        userID = Nothing
        UserAccess = Nothing
        userPass = Nothing
    End Sub

    Private Sub User_KeyPress(sender As Object, e As KeyPressEventArgs) Handles User.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            password.Select()
        End If
    End Sub

    Private Sub password_KeyPress(sender As Object, e As KeyPressEventArgs) Handles password.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            loginBtn.PerformClick()
        End If
    End Sub

    Private Sub Login_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If User.Text = "" Or password.Text = "" Then
            form.Close()
        End If
    End Sub
End Class