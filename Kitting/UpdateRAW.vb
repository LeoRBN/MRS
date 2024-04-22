Public Class UpdateRAW
    Public MainID As String = Nothing
    Private Sub UpdateRAW_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Login
            .form = Me
            .AccessID.Text = "KITTER"
            .ShowDialog()
        End With
        Kitter.Text = userID

        Load_data_from_db("@@MethodType = 'LOAD_RAW_UPDATE',@RefID = '" + materialtype.Text + "',@ID = '" + MainID + "'", dgvRawUpdate, "RAW", Nothing, Nothing, Nothing)
    End Sub

    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        Dim QRY As String = Nothing
        Try
            Select Case materialtype.Text
                Case "CAP CONSUME"
                    QRY = "@caps = '" + dgvRawUpdate.Rows(0).Cells(0).Value.ToString + "',@bin = '" + dgvRawUpdate.Rows(0).Cells(1).Value.ToString + "',@site = '" + dgvRawUpdate.Rows(0).Cells(2).Value.ToString + "',@n2 = '" + dgvRawUpdate.Rows(0).Cells(3).Value.ToString + "',@Kitter = '" + Kitter.Text + "'"
                Case "VCSEL WAFER"
                    Dim xdate As String = dgvRawUpdate.Rows(0).Cells(2).Value.ToString
                    If xdate.Contains(".") Then
                        xdate = xdate.Replace(".", "/")
                    End If
                    QRY = "@ID = '" + dgvRawUpdate.Rows(0).Cells(0).Value.ToString + "',@wl = '" + dgvRawUpdate.Rows(0).Cells(1).Value.ToString + "',@xdate = '" + xdate + "',@Rqty = '" + dgvRawUpdate.Rows(0).Cells(3).Value.ToString + "',@bin = '" + dgvRawUpdate.Rows(0).Cells(4).Value.ToString + "',@Kitter = '" + Kitter.Text + "'"
                Case "VALENCIA WAFER"
                    QRY = "@ID = '" + dgvRawUpdate.Rows(0).Cells(1).Value.ToString + "',@slice = '" + dgvRawUpdate.Rows(0).Cells(2).Value.ToString + "',@MatCode = '" + dgvRawUpdate.Rows(0).Cells(3).Value.ToString + "',@Rqty = '" + dgvRawUpdate.Rows(0).Cells(4).Value.ToString + "',@Cqty = '" + dgvRawUpdate.Rows(0).Cells(5).Value.ToString + "',@Kitter = '" + Kitter.Text + "'"
                Case "BARE CAPS"
                    QRY = "@MatCode = '" + dgvRawUpdate.Rows(0).Cells(1).Value.ToString + "',@Rqty = '" + dgvRawUpdate.Rows(0).Cells(2).Value.ToString + "',@Cqty = '" + dgvRawUpdate.Rows(0).Cells(3).Value.ToString + "'"
                Case "SMT"
                    QRY = "@ID = '" + dgvRawUpdate.Rows(0).Cells(1).Value.ToString + "',@MatCode = '" + dgvRawUpdate.Rows(0).Cells(2).Value.ToString + "',@Rqty = '" + dgvRawUpdate.Rows(0).Cells(3).Value.ToString + "',@Cqty = '" + dgvRawUpdate.Rows(0).Cells(4).Value.ToString + "'"
            End Select

            EXEC_QRY("@@MethodType = 'RAW_UPDATE',@RefID = '" + materialtype.Text + "',@Lotno = '" + materialid.Text + "'," & QRY, Nothing)

            MsgBox("Updated Successfully!")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.Close()

    End Sub
End Class