Public Class AU_ReturnAll

    Sub getAllEmpty()
        EXEC_QRY("@@MethodType = 'AU_LOAD',@CollectType = 'RETURN ALL'", Nothing)

        If ds.Tables(0).Rows.Count > 0 Then
            With returnList
                .DataSource = Nothing
                .ValueMember = Nothing
                .DataSource = ds.Tables(0)
                .ValueMember = "SPOOL"
                .Text = ds.Tables(0).Rows.Count
                '.itemCheckList.Text = Nothing
            End With
        Else
            MessageBox.Show("no data fount")
        End If
    End Sub

    Private Sub AU_ReturnAll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Login
            .AccessID.Text = "KITTER"
            .form = Me
            .ShowDialog()
        End With
        kitter.Text = userID
        getAllEmpty()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles selectall.CheckedChanged
        If selectall.Checked = True Then
            For i = 0 To returnList.Items.Count - 1
                returnList.SetItemChecked(i, True)
            Next i
        Else
            For i = 0 To returnList.Items.Count - 1
                returnList.SetItemChecked(i, False)
            Next i
        End If
    End Sub

    Private Sub g_send_Click(sender As Object, e As EventArgs) Handles g_send.Click
        If slip.Text = "" Then MsgBox("RETURN SLIP IS EMPTY") : Exit Sub
        Dim x As Integer = 0
        Try
            For i = 0 To returnList.Items.Count - 1
                If returnList.GetItemChecked(i) = True Then
                    Dim DRV As DataRowView = CType(returnList.Items(i), DataRowView)
                    Dim dr As DataRow = DRV.Row
                    Dim selectedItem As String = (dr(returnList.DisplayMember).ToString())
                    Dim item() As String = selectedItem.Split(vbTab)
                    Dim Spool As String = item(0).Trim

                    EXEC_QRY("@@MethodType = 'AU_TRANSACTION',@CollectType = 'AU TRANSACTION',@Status = 'RETURN ALL',@returnSlip = '" + slip.Text.Trim + "',@SpoolNo = '" + Spool + "'", Nothing)

                    x += 1
                End If
            Next
            MsgBox(x & " Items is now ERET!")
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Main_Kitting.raw_Dgv_loader(Main_Kitting.dgvGold, "AU_KITTING", "AU_KITTING", "EMPTY")
    End Sub
End Class