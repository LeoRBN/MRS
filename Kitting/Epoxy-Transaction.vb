Imports System.ComponentModel

Public Class Epoxy_Transaction
    Public UID As String = Nothing
    Sub data_loader(reqID As String)

        Dim tb() As TextBox = {e_lot, e_area, e_process, e_step, e_discription, e_supplier, e_reqBy, e_dateReq, e_remarks, e_batch, e_thawnBy, e_issuedBy, e_withBy, e_kitter, e_xdate, e_weight}
        Dim ColNames() As String = {"Phantom_Code", "Product Code", "Process", "STEP(FW2)", "Material Description", "Supplier", "Operator", "Request Date", "Remarks", "Batch_Code", "Kitter", "Released By", "Withdrawn By", "Closed By", "Closed Date", "Weight"}
        Dim lbl() As Label = {e_product, e_machine, e_matcode, e_qty, mainStatus, requestID, e_type}
        Dim lblCol() As String = {"Package", "Machine", "Material Code", "Qty", "Status", "ID", "Material"}

        Try
            EXEC_QRY("@@MethodType = 'EPOXY_REQUEST',@CollectType = 'LOAD_ID',@ID = '" + reqID + "'", Nothing)
            If ds.Tables(0).Rows.Count = 0 Then Exit Sub

            For i As Integer = 0 To tb.Length - 1
                tb(i).Text = ds.Tables(0).Rows(0)(ColNames(i)).ToString
            Next
            For i As Integer = 0 To lbl.Length - 1
                lbl(i).Text = ds.Tables(0).Rows(0)(lblCol(i)).ToString
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub Field_Ctrl(status As String)

        Select Case status
            Case "NEW MATERIAL REQUEST"
                thawPnl.Visible = True : thawPnl.Enabled = True
                issuedPnl.Visible = False : issuedPnl.Enabled = False
                closePnl.Visible = False : closePnl.Enabled = False
                'action button
                e_thw.Enabled = True : e_avail.Enabled = False
                e_with.Enabled = False : e_received.Enabled = False
                e_close.Enabled = False

                e_thw.BackColor = Color.Yellow
                e_thw.ForeColor = Color.Black

            Case "THAWING"
                thawPnl.Visible = True : thawPnl.Enabled = False
                issuedPnl.Visible = False : issuedPnl.Enabled = False
                closePnl.Visible = False : closePnl.Enabled = False
                'action button
                e_thw.Enabled = False : e_avail.Enabled = True
                e_with.Enabled = False : e_received.Enabled = False
                e_close.Enabled = False

                e_avail.BackColor = Color.Lime
                e_avail.ForeColor = Color.Black

            Case "AVAILABLE"
                thawPnl.Visible = True : thawPnl.Enabled = False
                issuedPnl.Visible = True : issuedPnl.Enabled = True
                closePnl.Visible = False : closePnl.Enabled = False
                'action button
                e_thw.Enabled = False : e_avail.Enabled = False
                e_with.Enabled = True : e_received.Enabled = False
                e_close.Enabled = False

                e_with.BackColor = Color.Orange
                e_with.ForeColor = Color.Black

            Case "FOR RETURN"
                thawPnl.Visible = True : thawPnl.Enabled = False
                issuedPnl.Visible = True : issuedPnl.Enabled = False
                closePnl.Visible = False : closePnl.Enabled = False
                'action button
                e_thw.Enabled = False : e_avail.Enabled = False
                e_with.Enabled = False : e_received.Enabled = False
                e_close.Enabled = False

            Case "UNUSED"
                thawPnl.Visible = True : thawPnl.Enabled = False
                issuedPnl.Visible = True : issuedPnl.Enabled = False
                closePnl.Visible = False : closePnl.Enabled = False
                'action button
                e_thw.Enabled = False : e_avail.Enabled = False
                e_with.Enabled = False : e_received.Enabled = False
                e_close.Enabled = False

            Case "PENDING"
                thawPnl.Visible = True : thawPnl.Enabled = False
                issuedPnl.Visible = True : issuedPnl.Enabled = False
                closePnl.Visible = False : closePnl.Enabled = False
                'action button
                e_thw.Enabled = False : e_avail.Enabled = False
                e_with.Enabled = False : e_received.Enabled = True
                e_close.Enabled = False

                e_received.BackColor = Color.Aqua
                e_received.ForeColor = Color.Black

            Case "RECEIVED"
                thawPnl.Visible = True : thawPnl.Enabled = False
                issuedPnl.Visible = True : issuedPnl.Enabled = False
                closePnl.Visible = True : closePnl.Enabled = True
                'action button
                e_thw.Enabled = False : e_avail.Enabled = False
                e_with.Enabled = False : e_received.Enabled = False
                e_close.Enabled = True
                e_kitter.Text = Nothing
                e_close.BackColor = Color.Aqua
                e_close.ForeColor = Color.Black

            Case "CLOSED"
                thawPnl.Visible = True : thawPnl.Enabled = False
                issuedPnl.Visible = True : issuedPnl.Enabled = False
                closePnl.Visible = True : closePnl.Enabled = False
                'action button
                e_thw.Enabled = False : e_avail.Enabled = False
                e_with.Enabled = False : e_received.Enabled = False
                e_close.Enabled = False

        End Select

    End Sub

    Public Sub Epoxy_Transaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load, Me.GotFocus

        Dim reqID As String = UID
        data_loader(reqID)
        Field_Ctrl(mainStatus.Text)
    End Sub

    Private Sub e_thw_Click(sender As Object, e As EventArgs) Handles e_thw.Click
        If e_batch.Text = Nothing Or e_thawnBy.Text = Nothing Then MsgBox("INcomplete fields! ") : Exit Sub
        If MsgBox("Please Confirm!" & vbNewLine & vbNewLine & "Batch No :" & vbTab & e_batch.Text & vbNewLine & "Machine :" & vbTab & e_machine.Text, MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        Try
            EXEC_QRY("@@MethodType = 'TRANSACTION', @CollectType = 'RAW_TRANSACTION',@Type = 'EPOXY',@Status = '" + mainStatus.Text + "',@ID = '" + requestID.Text + "',@BatchCode = '" + Trim(e_batch.Text) + "',@Qty = '1',@Kitter = '" + e_thawnBy.Text + "',@MatCode = '" + e_matcode.Text + "'", Nothing)
            If e_matcode.Text = "5XP70077" Then
                MsgBox("item is now AVAILABLE")
            Else
                MsgBox("item is now THAWING")
            End If

            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub e_avail_Click(sender As Object, e As EventArgs) Handles e_avail.Click
        Dim RT As Integer = CInt(Main_Kitting.dgvepoxy.SelectedRows(0).Cells("Remaining Time").Value.ToString.Replace("min", ""))
        If RT > 0 Then MsgBox("Remaining Time : " & RT & " minute(s)") : Exit Sub

        EXEC_QRY("@@MethodType = 'TRANSACTION', @CollectType = 'RAW_TRANSACTION',@Type = 'EPOXY',@Status = '" + mainStatus.Text + "',@ID = '" + requestID.Text + "'", Nothing)

        'Trigger Notification to kitting
        Get_Network_Access()
        'notification format::  <TITLE> <TYPE> <MATCODE - MACHINE>
        Trigger_Alert("EPOXY IS NOW AVAILABLE" & "-" & e_type.Text & "-" & e_matcode.Text & "   " & e_machine.Text & "-" & Format(DateTime.Now, "ddMMM HHmmss"))

        MsgBox("Item is now set to Available")
        Me.Close()
    End Sub

    Private Sub e_with_Click(sender As Object, e As EventArgs) Handles e_with.Click
        If e_issuedBy.Text = Nothing Or e_withBy.Text = Nothing Then MsgBox("Incomplete Fields!") : Exit Sub

        EXEC_QRY("@@MethodType = 'TRANSACTION', @CollectType = 'RAW_TRANSACTION',@Type = 'EPOXY',@Status = '" + mainStatus.Text + "',@ID = '" + requestID.Text + "',@issuedto = '" + e_withBy.Text + "',@Kitter = '" + e_issuedBy.Text + "'", Nothing)
        MsgBox("Item is now Withdrawn!")
        Me.Close()
    End Sub

    Private Sub e_received_Click(sender As Object, e As EventArgs) Handles e_received.Click
        If MsgBox("Please Confirm!" & vbNewLine & vbNewLine & "Batch No :" & vbTab & e_batch.Text & "/" & e_machine.Text & vbNewLine & "Request Date :" & vbTab & e_dateReq.Text, MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        EXEC_QRY("@@MethodType = 'TRANSACTION', @CollectType = 'RAW_TRANSACTION',@Type = 'EPOXY',@Status = '" + mainStatus.Text + "',@ID = '" + requestID.Text + "'", Nothing)
        MsgBox("Item is now Received!")
        Me.Close()
    End Sub

    Private Sub e_close_Click(sender As Object, e As EventArgs) Handles e_close.Click
        If e_weight.Text = Nothing Or e_kitter.Text = Nothing Then MsgBox("Incomplete Fields!") : Exit Sub
        EXEC_QRY("@@MethodType = 'TRANSACTION', @CollectType = 'RAW_TRANSACTION',@Type = 'EPOXY',@Status = '" + mainStatus.Text + "',@ID = '" + requestID.Text + "',@Kitter = '" + e_kitter.Text + "',@Weight = '" + e_weight.Text + "'", Nothing)
        MsgBox("Item is now Closed!")
        Me.Close()
    End Sub

    Private Sub Epoxy_Transaction_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Main_Kitting.raw_Dgv_loader(Main_Kitting.dgvepoxy, "EPOXY_MAIN", Nothing, mainStatus.Text.Trim)
    End Sub

    Private Sub e_batch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles e_batch.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e_thawnBy.Select()
        End If
    End Sub

    Private Sub e_issuedBy_KeyPress(sender As Object, e As KeyPressEventArgs) Handles e_issuedBy.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e_withBy.Select()
        End If
    End Sub

    Private Sub e_weight_KeyPress(sender As Object, e As KeyPressEventArgs) Handles e_weight.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e_kitter.Select()
        End If
    End Sub
End Class