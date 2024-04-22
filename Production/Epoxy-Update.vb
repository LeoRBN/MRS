Imports System.ComponentModel

Public Class Epoxy_Update

    Sub data_loader(id As String)
        Try
            Dim xrow As DataGridViewRow = DM_Request.dgvRecord.SelectedRows(0)
            id = xrow.Cells("ID").Value.ToString
            Dim xstatus As String = xrow.Cells("Status").Value.ToString
            requestID.Text = id

            Dim Fields() As Control = {e_package, e_machine, e_matcode, e_batch, e_type, e_process, e_dateReq, e_reqBy, e_updateBy, e_retBy, e_reasonCode, e_remarks}
            Dim colNames() As String = {"Package", "Machine", "Material Code", "Batch_Code", "Material", "STEP(FW2)", "Request Date", "Operator", "R.UpdateBy", "R.ReturnBy", "R.Code", "R.Remark"}

            EXEC_QRY("@@MethodType = 'EPOXY_REQUEST',@CollectType = 'LOAD_ID',@ID = '" + id + "', @Status = '" + xstatus + "'", Nothing)

            If ds.Tables(0).Rows.Count = 0 Then Exit Sub
            Dim Status As String = ds.Tables(0).Rows(0)("Status").ToString
            mainStatus.Text = Status

            'Populate Fields
            For i As Integer = 0 To Fields.Length - 1
                Fields(i).Text = ds.Tables(0).Rows(0)(colNames(i)).ToString
            Next

            Select Case Status
                Case "FOR RETURN"
                    COMBOBOX("@@MethodType = 'RAW_DROPDOWNS',@Type = 'REASON_CODE',@columnName = 'STEP',@val = 'REASON_CODE'", "STEP", e_reasonCode)
                    COMBOBOX("@@MethodType = 'RAW_DROPDOWNS',@Type = 'REASON_CODE',@columnName = 'STEP',@val = 'REMARKS'", "STEP", e_remarks)
                    offpnl.Enabled = True
                    retPnl.Enabled = False
                    e_save.Text = "UNUSED" : e_save.BackColor = Color.Blue

                Case "UNUSED"
                    offpnl.Enabled = False
                    retPnl.Enabled = True
                    e_save.Text = "RETURN" : e_save.BackColor = Color.Orange : e_save.ForeColor = Color.Black

                Case "NEW MATERIAL REQUEST"
                    offpnl.Visible = False : retPnl.Visible = False
                    e_save.Visible = False
                    e_close.Text = "FOLLOW UP"

                Case "THAWING"
                    offpnl.Visible = False : retPnl.Visible = False
                    e_save.Visible = False
                    e_close.Text = "CLOSE"

                Case "AVAILABLE"
                    offpnl.Visible = False : retPnl.Visible = False
                    e_save.Visible = False
                    e_close.Text = "CLOSE"

                Case Else
                    offpnl.Enabled = False
                    retPnl.Enabled = False
                    e_save.Enabled = False
            End Select

        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Epoxy_Update_Load(sender As Object, e As EventArgs) Handles MyBase.Load, Me.Activated
        data_loader(Nothing)
    End Sub

    Private Sub e_reasonCode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles e_reasonCode.SelectedIndexChanged
        If e_reasonCode.Text.Contains("R3") Then
            e_remarks.Enabled = True
        Else
            e_remarks.Enabled = False
        End If
    End Sub

    Private Sub e_close_Click(sender As Object, e As EventArgs) Handles e_close.Click
        Dim XROW As DataGridViewRow = DM_Request.dgvRecord.SelectedRows(0)

        Select Case mainStatus.Text
            Case "NEW MATERIAL REQUEST"
                'Trigger Notification to kitting
                Get_Network_Access()
                'notification format::  <TITLE> <TYPE> <MATCODE - MACHINE>
                Trigger_Alert("FOLLOW UP" & "-" & XROW.Cells("Material").Value.ToString & "-" & XROW.Cells("Material Code").Value.ToString & "   " & XROW.Cells("Machine").Value.ToString & "-" & Format(DateTime.Now, "ddMMM HHmmss"))

                MsgBox("Notification Sent to Kitting!")

        End Select
        Me.Close()
    End Sub

    Private Sub e_save_Click(sender As Object, e As EventArgs) Handles e_save.Click

        Select Case mainStatus.Text
            Case "FOR RETURN"
                If e_reasonCode.Text = Nothing Or e_reasonCode.Text = "" Or e_updateBy.Text = Nothing Or e_updateBy.Text = "" Then MsgBox("Incomplete Fields!") : Exit Sub

                EXEC_QRY("@@MethodType = 'TRANSACTION',@CollectType = 'RAW_TRANSACTION',@Type = 'EPOXY',@Status ='" + mainStatus.Text + "',@ID = '" + requestID.Text + "',@operator = '" + e_updateBy.Text + "',@ReasonCOde = '" + e_reasonCode.Text + "',@Remarks = '" + e_remarks.Text + "'", Nothing)

                MsgBox("Item set to Unused!")

            Case "UNUSED"
                If e_retBy.Text = Nothing Or e_retBy.Text = "" Then MsgBox("Incomplete Fields!") : Exit Sub

                EXEC_QRY("@@MethodType = 'TRANSACTION',@CollectType = 'RAW_TRANSACTION',@Type = 'EPOXY',@Status ='" + mainStatus.Text + "',@ID = '" + requestID.Text + "',@operator = '" + e_retBy.Text + "'", Nothing)

                MsgBox("Item set to Pending!" & vbNewLine & "please return the item to Kitting")
        End Select

        Me.Close()
    End Sub

    Private Sub Epoxy_Update_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        DM_Request.dgv_loader(DM_Request.dgvRecord, "EPOXY_MAIN", mainStatus.Text)
    End Sub

    Private Sub Epoxy_Update_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        Me.Close()
    End Sub
End Class