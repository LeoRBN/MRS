Public Class AU_Insert

    Public Clk As String = Nothing

    Private Function check_fields() As Boolean
        Dim tb() As Control = {spoolno, package, matcode, supplier, length, reservation, kitter}
        Dim x As Integer = 0
        For i As Integer = 0 To tb.Length - 1
            If tb(i).Text.Trim = "" Then
                x += 1
            End If
        Next
        If x > 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Sub getdata()
        Dim ID As String = Main_Kitting.dgvGold.SelectedRows(0).Cells("UID").Value.ToString
        Dim TB As Control() = {spoolno, package, matcode, supplier, length, currLength, reservation, kitter, StatusMain}
        Dim col As String() = {"SPOLL_NO.", "PACKAGE_RESERVATION", "MATERIAL_CODE", "SUPPLIER", "LENGTH", "REMAINING", "RESERVATION_NUMBER", "RECEIVED BY", "STATUS"}
        Try
            EXEC_QRY("@@MethodType = 'AU_LOAD',@CollectType = 'MAIN_RAW',@ID = '" + ID + "'", Nothing)
            If ds.Tables(0).Rows.Count = 0 Then Exit Sub
            For i = 0 To TB.Length - 1
                TB(i).Text = ds.Tables(0).Rows(0)(col(i)).ToString
                TB(i).Enabled = False
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AU_Insert_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case Clk
            Case "DIRECT"
                With Login
                    .AccessID.Text = "KITTER"
                    .form = Me
                    .ShowDialog()
                End With
                kitter.Text = userID
                COMBOBOX("@@MethodType = 'RAW_DROPDOWNS',@Type = 'GOLD_TRAN',@columnName = 'PACKAGE'", "PACKAGE", package)
            Case Else
                getdata()
        End Select

    End Sub

    Private Sub g_save_Click(sender As Object, e As EventArgs) Handles g_save.Click
        If check_fields() = False Then MsgBox("Incomplete Fields!") : Exit Sub
        If MsgBox("Please Confirm!" & vbNewLine & vbNewLine & "Spool No :" & vbTab & spoolno.Text & vbNewLine & "Length :" & vbTab & vbTab & length.Text & vbNewLine & "Package :" & vbTab & package.Text & vbNewLine & vbNewLine & "Save this Spool ?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        Try
            EXEC_QRY("@@MethodType = 'AU_TRANSACTION',@CollectType = 'AU_INSERT',@SpoolNo = '" + spoolno.Text.Trim + "',@Package = '" + package.Text.Trim + "',@MatCode = '" + matcode.Text.Trim + "',@Supplier = '" + supplier.Text.Trim + "',@length = '" + length.Text.Trim + "',@reservNo = '" + reservation.Text.Trim + "',@Kitter = '" + kitter.Text.Trim + "'", Nothing)

            MsgBox("Spool Successfully Saved!")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub spoolno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles spoolno.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            EXEC_QRY("@@MethodType = 'GET_AU_DATA',@CollectType = 'AU_isExist',@ID = '" + spoolno.Text.Trim + "'", Nothing)
            If ds.Tables(0).Rows.Count > 0 Then
                MsgBox("Spool Already Exist!", MsgBoxStyle.Exclamation)
                spoolno.Text = Nothing
            Else
                package.Select()
            End If
        End If
    End Sub

    Private Sub length_KeyPress(sender As Object, e As KeyPressEventArgs) Handles length.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            currLength.Text = length.Text
        End If
    End Sub

    Private Sub length_LostFocus(sender As Object, e As EventArgs) Handles length.LostFocus
        currLength.Text = length.Text
    End Sub
End Class