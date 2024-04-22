Public Class Au_Transaction

    Sub data_loader()
        EXEC_QRY("@@MethodType = 'GET_AU_DATA',@CollectType = 'AU_ID',@ID = '" + UID.Text.Trim + "'", Nothing)
        If ds.Tables(0).Rows.Count <> 0 Then
            MainStatus.Text = ds.Tables(0).Rows(0)("STATUS").ToString
            Dim tb() As Control = {package, machine, lotid, spool, currentLength, kitter, IssuedTo, consumed, retby, retto, g_remarks}
            Dim col() As String = {"PACKAGE", "MACHINE NO", "LOT ID", "SPOOL NO", "CURRENT LENGTH", "ISSUED_BY", "ISSUED_TO", "TOTAL_CONSUMPTION", "RETURNED_BY", "RETURNED_TO", "REMARKS"}
            For i As Integer = 0 To tb.Length - 1
                tb(i).Text = ds.Tables(0).Rows(0)(col(i)).ToString
                If tb(i).Text.Trim <> "" Then
                    tb(i).Enabled = False
                Else
                    tb(i).Enabled = True
                End If
            Next
        End If
    End Sub

    Sub panel_ctrl()
        Select Case MainStatus.Text.Trim
            Case "NEW REQUEST"
                newPnl.Enabled = False : PrepPnl.Enabled = True
                IssuePnl.Enabled = False : IssuePnl.Visible = False
                retPnl.Enabled = False : retPnl.Visible = False
            Case "AVAILABLE"
                newPnl.Enabled = False : PrepPnl.Enabled = False
                IssuePnl.Enabled = True : IssuePnl.Visible = True
                retPnl.Enabled = False : retPnl.Visible = False
            Case "RETURN"
                newPnl.Enabled = False : PrepPnl.Enabled = False
                IssuePnl.Enabled = False : IssuePnl.Visible = True
                retPnl.Enabled = True : retPnl.Visible = True
            Case "ON-LINE"
                newPnl.Enabled = False : PrepPnl.Enabled = False
                IssuePnl.Enabled = False : IssuePnl.Visible = False
                retPnl.Enabled = False : retPnl.Visible = False
                g_send.Enabled = False
        End Select
    End Sub

    Private Sub Au_Transaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UID.Text = Main_Kitting.dgvGold.SelectedRows(0).Cells("UID").Value.ToString
        data_loader()
        panel_ctrl()
    End Sub

    Private Sub spool_KeyPress(sender As Object, e As KeyPressEventArgs) Handles spool.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            EXEC_QRY("@@MethodType = 'GET_AU_DATA',@CollectType = 'AU_isExist',@ID = '" + spool.Text.Trim + "'", Nothing)
            If ds.Tables(0).Rows.Count <> 0 Then
                currentLength.Text = ds.Tables(0).Rows(0)("CURRENT LENGTH").ToString
                kitter.Select()
            Else
                MsgBox("SPOOL NOT FOUND!") : spool.Text = Nothing
                currentLength.Text = Nothing
            End If
        End If
    End Sub

    Private Sub g_send_Click(sender As Object, e As EventArgs) Handles g_send.Click
        Try
            Select Case MainStatus.Text.Trim
                Case "NEW REQUEST"
                    If currentLength.Text = "" Or kitter.Text = "" Then MsgBox("Incomplete Fields!") : Exit Sub
                    If MsgBox("Please Confirm!" & vbNewLine & vbNewLine & "Spool No:" & vbTab & spool.Text.Trim & vbNewLine & "Product:" & vbTab & vbTab & package.Text & vbNewLine & "Machine:" & vbTab & vbTab & machine.Text, MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

                    EXEC_QRY("@@MethodType = 'AU_TRANSACTION',@CollectType = 'AU TRANSACTION',@Status = '" + MainStatus.Text.Trim + "',@ID = '" + UID.Text.Trim + "',@SpoolNo = '" + spool.Text.Trim + "',@length = '" + currentLength.Text.Trim + "',@issuedBy = '" + kitter.Text.Trim + "',@ComputerName = '" + DeviceName + "'", Nothing)

                    'Trigger Notification to kitting
                    Get_Network_Access()
                    'notification format::  <TITLE> <TYPE> <MATCODE - MACHINE>
                    Trigger_Alert("GOLDWIRE IS NOW AVAILABLE" & "-GOLDWIRE-" & package.Text & "   " & machine.Text & "-" & Format(DateTime.Now, "ddMMM HHmmss"))

                    MsgBox("Spool is now AVAILABLE")

                Case "AVAILABLE"
                    If IssuedTo.Text = "" Then MsgBox("Incomplete Fields!") : Exit Sub
                    If RecordCount("@@MethodType = 'GET_AU_DATA',@CollectType = 'CheckMC1',@Machine = '" + machine.Text.Trim + "'") <> 0 Then MsgBox("Received the RETURN spool first to Proceed!" & vbNewLine & vbNewLine & "SPOOL NO :" & vbTab & ds.Tables(0).Rows(0)("SPOOL NO").ToString & vbNewLine & "DATE RETURN :" & vbTab & ds.Tables(0).Rows(0)("DATE_RETURNED").ToString & vbNewLine & "STATUS :" & vbTab & vbTab & ds.Tables(0).Rows(0)("STATUS").ToString) : Me.Close() : Main_Kitting.g_return.PerformClick() : Exit Sub

                    If MsgBox("Proceed to Issued this Spool?" & vbNewLine & spool.Text, MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

                    EXEC_QRY("@@MethodType = 'AU_TRANSACTION',@CollectType = 'AU TRANSACTION',@Status = '" + MainStatus.Text.Trim + "',@ID = '" + UID.Text.Trim + "',@issuedto = '" + IssuedTo.Text.Trim + "',@SpoolNo = '" + spool.Text.Trim + "'", Nothing)

                    MsgBox("Spool is now ON-LINE")

                Case "RETURN"
                    If retto.Text = "" Then MsgBox("Incomplete Fields!") : Exit Sub
                    If MsgBox("Proceed to Received this Spool?" & vbNewLine & spool.Text, MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

                    EXEC_QRY("@@MethodType = 'AU_TRANSACTION',@CollectType = 'AU TRANSACTION',@Status = '" + MainStatus.Text.Trim + "',@ID = '" + UID.Text.Trim + "',@SpoolNo = '" + spool.Text.Trim + "',@Kitter = '" + retto.Text.Trim + "',@Remarks = '" + g_remarks.Text.Trim + "'", Nothing)

                    MsgBox("Spool RECEIVED!")

            End Select

            Main_Kitting.raw_Dgv_loader(Main_Kitting.dgvGold, "AU_KITTING", "AU_PRODUCTION", MainStatus.Text.Trim)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class