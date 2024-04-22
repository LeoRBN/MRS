Imports System.ComponentModel

Public Class RawTransaction
    Public UID As String = Nothing
    Sub DataCollect()

        Dim Id As String = UID
        dgvMatOut.DataSource = Nothing : dgvMatOut.Rows.Clear()
            'nav
            Dim data() As Label = {r_product, r_type, r_matcode, r_supplier, r_qty, r_bin, MainStatus, RequestID}
            Dim colNames() As String = {"Package", "Material", "Material Code", "Supplier", "Qty", "UM", "Status", "ID"}
            'side
            Dim rdata() As TextBox = {rdtranslot, rdtype, rd_process, rddiscription, rdsupplier, rdreason, rdremarks, rdmachine, rdreqby, rdkitter, issuedto, issuedby}
            Dim rcolNames() As String = {"Phantom_Code", "Material", "Process", "Material Description", "Supplier", "Reason_Code", "Remarks", "Machine", "Operator", "Kitter", "Withdrawn By", "Released by"}
            'get the data of the Batch in the records
            EXEC_QRY("@@MethodType = 'LOAD_RAW_DATA', @CollectType = 'RequestID_data', @ID = '" + Trim(Id) + "'", Nothing)
            If ds.Tables(0).Rows.Count = 0 Then Exit Sub

            For i As Integer = 0 To data.Length - 1
                data(i).Text = ds.Tables(0).Rows(0)(colNames(i)).ToString
            Next
            For i As Integer = 0 To rdata.Length - 1
                rdata(i).Text = ds.Tables(0).Rows(0)(rcolNames(i)).ToString
            Next

            'get batch & qty
            If MainStatus.Text <> "NEW MATERIAL REQUEST" Then
                Dim _b As String = "Batch_Code"
                Dim _q As String = Nothing
                If MainStatus.Text = "PENDING" Then
                    _q = "Qty"
                Else
                    _q = "Issued Qty"
                End If
                Dim batch As String = ds.Tables(0).Rows(0)(_b).ToString
                Dim qty As String = ds.Tables(0).Rows(0)(_q).ToString
                Call LoadBatch(batch, qty)
            End If
            dgvMatOut.ClearSelection()
    End Sub

    Sub LoadBatch(Batch As String, qty As String)
        If Batch.Contains(","c) = True Then
            Dim B_part() As String = Batch.Split(","c)
            If qty.Contains(",") Then
                Dim Q_part() As String = qty.Split(","c)
                For i As Integer = 0 To B_part.Length - 1
                    dgvMatOut.Rows.Add(B_part(i), Q_part(i))
                Next
            Else
                For i As Integer = 0 To B_part.Length - 1
                    dgvMatOut.Rows.Add(B_part(i), qty)
                Next
            End If
        Else
            dgvMatOut.Rows.Add(Batch, qty)
        End If
    End Sub

    Sub ObjectCrtl(status As String)
        Select Case status
            Case "NEW MATERIAL REQUEST"
                r_cancel.Enabled = False : r_edit.Enabled = False
                r_withdrawn.Enabled = False : r_recieved.Enabled = False
                r_available.Enabled = True : MatOutPnl.Enabled = True
                isspnl.Enabled = False : preppnl.Enabled = True

                r_available.BackColor = Color.Lime
                r_available.ForeColor = Color.Black

            Case "AVAILABLE"
                r_cancel.Enabled = True : r_edit.Enabled = True
                r_withdrawn.Enabled = True : r_recieved.Enabled = False
                r_available.Enabled = False : MatOutPnl.Enabled = False
                isspnl.Enabled = True : preppnl.Enabled = False

                r_withdrawn.BackColor = Color.Orange
                r_withdrawn.ForeColor = Color.Black

            Case "PENDING"
                r_cancel.Enabled = False : r_edit.Enabled = True
                r_withdrawn.Enabled = False : r_recieved.Enabled = True
                r_available.Enabled = False : MatOutPnl.Enabled = False
                isspnl.Enabled = False : preppnl.Enabled = False

                r_recieved.BackColor = Color.Aqua
                r_recieved.ForeColor = Color.Black

            Case "WITHDRAWN"
                r_cancel.Enabled = False : r_edit.Enabled = False
                r_withdrawn.Enabled = False : r_recieved.Enabled = False
                r_available.Enabled = False : MatOutPnl.Enabled = False
                isspnl.Enabled = False : preppnl.Enabled = False

            Case "RECEIVED"
                r_cancel.Enabled = False : r_edit.Enabled = False
                r_withdrawn.Enabled = False : r_recieved.Enabled = False
                r_available.Enabled = False : MatOutPnl.Enabled = False
                isspnl.Enabled = False : preppnl.Enabled = False

        End Select


    End Sub

    Sub get_data_MatID(id As String, type As String)

        Dim Uid As String
        Dim qty As String
        Try
            EXEC_QRY("@@MethodType = 'RAW_TRANSACTION',@CollectType = 'RAW_TRANSACT', @ID = '" + Trim(id) + "',@Cluster = '" + Trim(type) + "',@MatCode = '" + Trim(r_matcode.Text) + "'", Nothing)
            If ds.Tables(0).Rows.Count > 0 Then

                If type.Contains("WAFER_VCSEL") = True Then
                    If CInt(r_qty.Text) = 1 Then
                        dgvMatOut.Rows.Clear()
                        dgvMatOut.Rows.Add(ds.Tables(0).Rows(0)(0).ToString, ds.Tables(0).Rows(0)(1).ToString)
                    Else
                        If CInt(r_qty.Text) = dgvMatOut.Rows.Count Then matid.Text = Nothing : Exit Sub
                        dgvMatOut.Rows.Add(ds.Tables(0).Rows(0)(0).ToString, ds.Tables(0).Rows(0)(1).ToString)
                    End If

                ElseIf type.Contains("WAFER_IR") = True Then
                    dgvMatOut.Columns.Clear()
                    dgvMatOut.DataSource = ds.Tables(0)

                Else
                    dgvMatOut.Rows.Add(ds.Tables(0).Rows(0)(0).ToString, ds.Tables(0).Rows(0)(1).ToString)
                End If
                matid.Text = Nothing
            Else
                MsgBox("No Record for: " & "[" & type & "] - " & id)
                matid.Text = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message) '"Material Mismatched!"
            Exit Sub
        End Try
        dgvMatOut.ClearSelection()
    End Sub

    Sub reload_mainKitting(status As String)
        With Main_Kitting
            Select Case status
                Case "NEW MATERIAL REQUEST"
                    .rw_new.PerformClick()
                Case "AVAILABLE"
                    .rw_avail.PerformClick()
                Case "PENDING"
                    .rw_pending.PerformClick()
                Case "WITHDRAWN"
                    .rw_with.PerformClick()
                Case "RECEIVED"
                    .rw_close.PerformClick()
            End Select
        End With
    End Sub

    Private Sub RawTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvMatOut.DataSource = Nothing
        DataCollect()
        ObjectCrtl(MainStatus.Text)
        RequestID.Text = UID
        If r_type.Text = "Cap With Glass" Then
            If MainStatus.Text = "PENDING" Then
                COMBOBOX("@@MethodType = 'RAW_DROPDOWNS',@Type = 'N2',@columnName = 'STEP'", "STEP", n2Location)
                n2pnl.Visible = True : n2Location.Enabled = True
            Else
                n2pnl.Visible = False : n2Location.Enabled = False
            End If
        End If

    End Sub

    Private Sub addmatid_Click(sender As Object, e As EventArgs) Handles addmatid.Click
        Dim type As String = Nothing
        If Trim(r_type.Text) = "WAFER" Then
            type = r_type.Text & "_" & rd_process.Text
        Else
            type = r_type.Text
        End If

        get_data_MatID(Trim(matid.Text), Trim(type))

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles del.Click
        Try
            Dim xrow As DataGridViewRow = dgvMatOut.SelectedRows(0)
            dgvMatOut.Rows.Remove(xrow)
        Catch
        End Try
    End Sub

    Private Sub RawTransaction_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Main_Kitting.raw_Dgv_loader(Main_Kitting.dgvRawRequest, "RAW_REQUEST", Nothing, MainStatus.Text)
        'reload_mainKitting(MainStatus.Text)
    End Sub

    Private Sub matid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles matid.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            addmatid.PerformClick()
        End If
    End Sub

    Private Sub r_available_Click(sender As Object, e As EventArgs) Handles r_available.Click
        Dim ID As String = RequestID.Text
        Dim BATCH As String
        Dim QTY As String
        Dim STATUS As String = MainStatus.Text

        If rdkitter.Text = Nothing Or dgvMatOut.Rows.Count = 0 Then MsgBox("Incomplete fields! ") : Exit Sub

        For Each row As DataGridViewRow In dgvMatOut.Rows
            If BATCH <> Nothing And QTY <> Nothing Then
                BATCH = BATCH & "," & row.Cells(0).Value.ToString
                QTY = QTY & "," & row.Cells(1).Value.ToString
            Else
                BATCH = row.Cells(0).Value.ToString
                QTY = row.Cells(1).Value.ToString
            End If
        Next
        Try
            EXEC_QRY("@@MethodType = 'TRANSACTION',@Type = 'RAW',@CollectType = 'RAW_TRANSACTION',@Status = '" + STATUS + "',@BatchCode = '" + BATCH + "',@Qty = '" + QTY + "',@Kitter = '" + rdkitter.Text + "',@ID = '" + ID + "'", Nothing)

            'Trigger Notification to kitting
            Get_Network_Access()
            'notification format::  <TITLE> <TYPE> <MATCODE - MACHINE>
            Trigger_Alert("MATERIAL IS NOW AVAILABLE" & "-" & r_type.Text & "-" & r_matcode.Text & "   " & rdmachine.Text & "-" & Format(DateTime.Now, "ddMMM HHmmss"))

            MsgBox("ITEM SET TO AVAILABLE!")
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub r_withdrawn_Click(sender As Object, e As EventArgs) Handles r_withdrawn.Click
        If issuedto.Text = Nothing Or issuedby.Text = Nothing Then MsgBox("Incomplete fields! ") : Exit Sub

        'define refID
        Dim refID As String = Nothing
        Select Case r_type.Text
            Case "CAP"
                refID = "BARE"
            Case "Cap With Glass"
                refID = "CAP_CONSUME"
            Case "Efuse"
                refID = "SMT"
            Case "Interposer"
                refID = "SMT"
            Case "WAFER"
                If rd_process.Text.Contains("IR") Then
                    refID = "VALENCIA"
                ElseIf rd_process.Text.Contains("VCSEL") Then
                    refID = "VCSEL"
                End If
        End Select
        'Loop for each row of Material
        Try
            For Each row As DataGridViewRow In dgvMatOut.Rows
                EXEC_QRY("@@MethodType = 'TRANSACTION',@CollectType = 'RAW_TRANSACTION',@Status = '" + MainStatus.Text + "',@RefID = '" + refID + "',@ID = '" + RequestID.Text + "',@issuedto = '" + issuedto.Text + "',@issuedBy = '" + issuedby.Text + "',@Qty = '" + row.Cells(1).Value.ToString + "',@Lotno = '" + row.Cells(0).Value.ToString + "',@n2 = '" + n2Location.Text + "'", Nothing)
            Next
            MsgBox("ITEM WITHDRAWN!")
            Me.Close()
        Catch ex As Exception
            MsgBox("TRANSACTION FAILED! : " & vbNewLine & vbNewLine & ex.Message)
        End Try

    End Sub

    Private Sub r_recieved_Click(sender As Object, e As EventArgs) Handles r_recieved.Click
        Dim refID As String = Nothing
        Select Case r_type.Text
            Case "CAP"
                refID = "BARE"
            Case "Cap With Glass"
                refID = "CAP_CONSUME"
            Case "Efuse"
                refID = "SMT"
            Case "Interposer"
                refID = "SMT"
            Case "WAFER"
                If rd_process.Text.Contains("IR") Then
                    refID = "VALENCIA"
                ElseIf rd_process.Text.Contains("VCSEL") Then
                    refID = "VCSEL"
                End If
        End Select
        If r_type.Text = "Cap With Glass" And n2Location.Text = "" Then MsgBox("Please Input N2 Location!") : Exit Sub

        If MsgBox("Please Confirm!" & vbNewLine & vbNewLine & "Material Type :" & vbTab & r_type.Text & vbNewLine & "Quantity :" & vbTab & r_qty.Text, MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        Dim input As String = InputBox("Please input your ID:", "RECIEVED BY")
        If input = "" Then Exit Sub

        'Loop for each row of Material
        Try
            For Each row As DataGridViewRow In dgvMatOut.Rows
                EXEC_QRY("@@MethodType = 'TRANSACTION',@CollectType = 'RAW_TRANSACTION',@Status = '" + MainStatus.Text + "',@Type = 'RAW',@RefID = '" + refID + "',@ID = '" + RequestID.Text + "',@returnBy = '" + rdreqby.Text + "',@returnTo = '" + input + "',@Qty = '" + row.Cells(1).Value.ToString + "',@Lotno = '" + row.Cells(0).Value.ToString + "',@Package = '" + r_product.Text + "',@Machine = '" + rdmachine.Text + "',@Remarks = '" + rdremarks.Text + "'", Nothing)
            Next
            MsgBox("ITEM RECEIVED!")
            Me.Close()
        Catch ex As Exception
            MsgBox("TRANSACTION FAILED! : " & vbNewLine & vbNewLine & ex.Message)
        End Try
    End Sub

    Private Sub r_edit_Click(sender As Object, e As EventArgs) Handles r_edit.Click
        MatOutPnl.Enabled = True
    End Sub

    Private Sub issuedto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles issuedto.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            issuedby.Select()
        End If
    End Sub
End Class