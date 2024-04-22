Public Class IDM_Req
    Public IDMID As String

    Sub machine_load(stp As String)

        COMBOBOX("@@MethodType = 'RAW_DROPDOWNS',@Type = 'MC1',@columnName = 'Process'", "Process", process)

    End Sub

    Private Sub IDM_Req_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim row As DataGridViewRow
        Dim id As String = Nothing
        Dim fields() As Control
        Dim col() As String

        Select Case IDMID
            Case "REQUEST"
                machine_load(Nothing)
                mainStatus.Text = "SEND REQUEST"
                row = DM_Request.dgvIDM.SelectedRows(0)
                id = row.Cells("Material Code").Value.ToString
                UID.Text = id
                EXEC_QRY("@@MethodType = 'LOAD_IDM',@CollectType = 'Raw_id',@ID = '" + id + "'", Nothing)

                fields = {matCode, discription, Supplier, Uom, TYPE}
                col = {"Material Code", "Material Description", "Supplier", "UoM", "Type"}

                For i As Integer = 0 To fields.Length - 1
                    fields(i).Text = ds.Tables(0).Rows(0)(col(i)).ToString
                Next

            Case "ISSUE"

                SendReq.Text = "AVAILABLE"

                row = Main_Kitting.dgvIdmReq.SelectedRows(0)
                id = row.Cells("ID").Value.ToString
                UID.Text = id
                fields = {matCode, discription, Uom, TYPE, subMC, reqQty, remarks, reqBy, kitter, issQty, mainStatus}
                col = {"Material Code", "Material Description", "UoM", "Type", "Machine", "Request Qty", "Remarks", "Request By", "Kitter", "Issued Qty", "Status"}

                EXEC_QRY("@@MethodType = 'LOAD_IDM',@CollectType = 'Request_id',@ID = '" + id + "'", Nothing)

                For i As Integer = 0 To fields.Length - 1
                    fields(i).Text = ds.Tables(0).Rows(0)(col(i)).ToString
                Next

            Case "WITHDRAWN"
                SendReq.Text = "WITHDRAWN" : SendReq.BackColor = Color.Orange : SendReq.ForeColor = Color.White
                kitterpnl.Enabled = False
                row = Main_Kitting.dgvIdmReq.SelectedRows(0)
                id = row.Cells("ID").Value.ToString
                UID.Text = id
                fields = {matCode, discription, Uom, TYPE, subMC, reqQty, remarks, reqBy, kitter, issQty, mainStatus}
                col = {"Material Code", "Material Description", "UoM", "Type", "Machine", "Request Qty", "Remarks", "Request By", "Kitter", "Issued Qty", "Status"}

                EXEC_QRY("@@MethodType = 'LOAD_IDM',@CollectType = 'Request_id',@ID = '" + id + "'", Nothing)

                For i As Integer = 0 To fields.Length - 1
                    fields(i).Text = ds.Tables(0).Rows(0)(col(i)).ToString
                Next

        End Select


    End Sub

    Private Sub process_SelectedIndexChanged(sender As Object, e As EventArgs) Handles process.SelectedIndexChanged
        mcList.Items.Clear()
        EXEC_QRY("@@MethodType = 'RAW_DROPDOWNS',@Type = 'MC',@columnName = 'Machine',@Process = '" + Trim(process.Text) + "'", Nothing)
        For Each row As DataRow In ds.Tables(0).Rows
            mcList.Items.Add(row("Machine"))
        Next
    End Sub

    Private Sub SendReq_Click(sender As Object, e As EventArgs) Handles SendReq.Click

        Try
            Select Case mainStatus.Text
                Case "SEND REQUEST"
                    If subMC.Text = "" Or subMC.Text = Nothing Or reqQty.Text = 0 Or reqBy.Text = Nothing Then MsgBox("Incomplete fields. please check again") : Exit Sub

                    EXEC_QRY("@@MethodType = 'SEND_REQUEST',@CollectType = 'NEW MATERIAL REQUEST',@TypeID = 'IDM',@MatCode = '" + matCode.Text + "',@Type = '" + TYPE.Text + "',@MatDesc = '" + discription.Text + "',@UoM = '" + Uom.Text + "',@reqBy = '" + reqBy.Text + "',@Machine = '" + subMC.Text + "',@Remarks = '" + remarks.Text + "',@Qty = '" + reqQty.Text + "'", Nothing)

                    'Trigger Notification to kitting
                    Get_Network_Access()
                    Trigger_Alert("NEW MATERIAL REQUEST-INDIRECT-" & matCode.Text & "   " & subMC.Text & "-" & Format(DateTime.Now, "ddMMM HHmmss"))

                    MsgBox("Request Sent Successfully!")
                    Me.Close()

                Case "NEW REQUEST"
                    If kitter.Text = Nothing Then MsgBox("Please input your ID!") : Exit Sub
                    If CInt(issQty.Text) = 0 Or issQty.Text = Nothing Then MsgBox("Please Check Quantity") : Exit Sub

                    EXEC_QRY("@@MethodType = 'TRANSACTION',@CollectType = 'IDM_TRANSACTION',@Status = '" + mainStatus.Text + "',@Kitter = '" + kitter.Text + "',@Qty = '" + issQty.Text + "',@ID = '" + UID.Text + "'", Nothing)

                    'Trigger Notification to kitting
                    Get_Network_Access()
                    'notification format::  <TITLE> <TYPE> <MATCODE - MACHINE>
                    Trigger_Alert("MATERIAL IS NOW AVAILABLE" & "-" & TYPE.Text & "-" & matCode.Text & "   " & subMC.Text & "-" & Format(DateTime.Now, "ddMMM HHmmss"))

                    MsgBox("Request is now Available ")
                    Me.Close()

                Case "AVAILABLE"
                    EXEC_QRY("@@MethodType = 'TRANSACTION',@CollectType = 'IDM_TRANSACTION',@Status = '" + mainStatus.Text + "',@ID = '" + UID.Text + "'", Nothing)
                    MsgBox("Item Issued Successfully! ")
                    Me.Close()
            End Select

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mcList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles mcList.SelectedIndexChanged
        Dim checkedItems As New List(Of String)

        For Each item As Object In mcList.CheckedItems
            checkedItems.Add(item.ToString())
        Next

        subMC.Text = String.Join(",", checkedItems)
    End Sub

    Private Sub Uom_TextChanged(sender As Object, e As EventArgs) Handles Uom.TextChanged
        Uom2.Text = Uom.Text
    End Sub
End Class