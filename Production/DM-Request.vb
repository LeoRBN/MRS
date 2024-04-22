Imports System.IO

Public Class DM_Request
    Private Matcode As String
    Sub Request_dropdown(columnName As String, cb As ComboBox, xfunc As Integer)

        ComboBox_regulator(cb, xfunc)
        cb.DataSource = Nothing
        Select Case xfunc
            Case 1
                COMBOBOX("@@MethodType = 'MATRIX_DROPDOWN',@CollectType = 'REQUEST',@columnName = '" + columnName + "',@Type = '" + Trim(r_type.Text) + "',@Package = '" + Trim(r_productCode.Text) + "',@Supplier = '" + Trim(r_supplier.Text) + "',@Material = '" + Trim(r_matType.Text) + "',@Process = '" + Trim(r_process.Text) + "',@Station = '" + Trim(r_station.Text) + "',@Area = '" + Trim(r_area.Text) + "'", columnName, cb)
                Select Case columnName
                    Case "MatCode"
                        Matcode = ds.Tables(0).Rows(0)(columnName).ToString
                        r_matcode.Text = ds.Tables(0).Rows(0)(columnName).ToString
                    Case "Material Description"
                        r_matdis.Text = ds.Tables(0).Rows(0)(columnName).ToString
                    Case "UoM"
                        r_oum.Text = ds.Tables(0).Rows(0)(columnName).ToString
                End Select

            Case 2

            Case 3
                COMBOBOX("@@MethodType = 'RAW_DROPDOWNS',@Type = 'IDM_RAW',@columnName = 'Type'", columnName, cb)
            Case 4
                COMBOBOX("@@MethodType = 'MATRIX_DROPDOWN',@CollectType = 'REQUEST',@columnName = '" + columnName + "',@Type = '" + Trim(eng_type.Text) + "',@Package = '" + Trim(eng_package.Text) + "',@Supplier = '" + Trim(eng_supplier.Text) + "',@Material = '" + Trim(eng_mattype.Text) + "',@Process = '" + Trim(eng_step.Text) + "',@Station = '" + Trim(eng_station.Text) + "',@Area = '" + Trim(eng_area.Text) + "'", columnName, cb)
                Select Case columnName
                    Case "MatCode"
                        Matcode = ds.Tables(0).Rows(0)(columnName).ToString
                        eng_matcode.Text = ds.Tables(0).Rows(0)(columnName).ToString
                    Case "Material Description"
                        eng_dis.Text = ds.Tables(0).Rows(0)(columnName).ToString
                    Case "UoM"
                        eng_UoM.Text = ds.Tables(0).Rows(0)(columnName).ToString
                End Select
        End Select
    End Sub

    Sub ComboBox_regulator(cb As ComboBox, id As Integer)
        Dim cmbx() As ComboBox = {r_type, r_area, r_station, r_process, r_productCode, r_matType, r_supplier}
        Dim engbx() As ComboBox = {eng_type, eng_area, eng_station, eng_step, eng_package, eng_mattype, eng_supplier}
        Dim i As Integer = Array.IndexOf(cmbx, cb) + 1

        Select Case id
            Case 1
                If i = 0 Then Exit Sub
                For i = i To cmbx.Length - 1
                    cmbx(i).Text = Nothing
                    cmbx(i).DataSource = Nothing
                Next
            Case 4
                If i = 0 Then Exit Sub
                For i = i To engbx.Length - 1
                    engbx(i).Text = Nothing
                    engbx(i).DataSource = Nothing
                Next

        End Select

    End Sub

    Public Sub dgv_loader(dgv As DataGridView, collect As String, Status As String)

        Select Case collect
            Case "EPOXY_MAIN"
                'loader for DM material
                Load_data_from_db("@@MethodType = 'EPOXY_REQUEST',@CollectType = '" + collect + "',@limitrow = '" + Trim(e_limitrow.Text) + "',@Status = '" + Status + "',@Cluster = 'PROD',@Package = '" + Trim(e_package.Text) + "',@Process = '" + Trim(e_process.Text) + "',@Machine = '" + Trim(e_machine.Text) + "',@reqBy = '" + Trim(e_empID.Text) + "'", dgv, "EPOXY", Nothing, Nothing, Nothing)

            Case "IDM_RAW"
                'loader for IDM RAW
                Load_data_from_db("@@MethodType = 'LOAD_IDM',@CollectType = '" + collect + "',@Type = '" + idm_type.Text + "',@MatCode = '" + idm_matcode.Text + "',@MatDesc = '" + idm_discription.Text + "'", dgv, "RAW", Nothing, Nothing, Nothing)

            Case "IDM_REQ"
                'loader for IDM RAW
                Load_data_from_db("@@MethodType = 'LOAD_IDM',@CollectType = '" + collect + "',@Status = '" + Status + "',@limitrow = '" + e_limitrow.Text.Trim + "'", dgv, "EPOXY", Nothing, Nothing, Nothing)
        End Select
        dgv.ClearSelection()
    End Sub

    Sub dropdowns()
        Dim cb() As ComboBox = {e_package, e_process, e_machine, e_type}
        Dim col() As String = {"Package", "Process", "MaChine", "Material"}

        For i As Integer = 0 To col.Length - 1
            COMBOBOX("@@MethodType = 'RAW_DROPDOWNS',@Type = 'REQ',@columnName = '" + col(i) + "'", col(i), cb(i))
        Next

    End Sub

    Private Sub Inventory_Counter()

        Dim EPOXYreqStatus() As String = {"NEW", "THAWING", "AVAIL", "RETURN", "UNUSED", "PENDING", "ALL"}
        Dim epoxy() As Button = {e_new, e_thaw, e_avail, e_forRet, e_aging, e_pending, e_all}

        Dim IDMStatus() As String = {"NEW", "AVAIL", "WITHDRW"}
        Dim IDM() As Button = {idm_new, idm_avail, idm_Withdrawn}

        EXEC_QRY("@@MethodType = 'INV_RAW',@CollectType = 'Epoxyrequest1'", Nothing)
        If ds.Tables(0).Rows.Count = 0 Then Exit Sub

        For i = 0 To epoxy.Length - 1
            epoxy(i).Text = ds.Tables(0).Rows(0)(EPOXYreqStatus(i)).ToString
        Next
        EXEC_QRY("@@MethodType = 'INV_RAW',@CollectType = 'RAWrequest'", Nothing)
        e_wthdrw.Text = ds.Tables(0).Rows(0)("WITHDRAWN").ToString

        EXEC_QRY("@@MethodType = 'INV_RAW',@CollectType = 'IDMRequest'", Nothing)
        If ds.Tables(0).Rows.Count = 0 Then Exit Sub

        For i = 0 To IDM.Length - 1
            IDM(i).Text = ds.Tables(0).Rows(0)(IDMStatus(i)).ToString
        Next

    End Sub

    Sub Dgv_Builder(dgv As DataGridView, type As String)
        Dim Coltype() As String = {"VALENCIA WAFER", "INTERPOSER/EFUSE", "BARE CAPS", "CAPS CONSUME", "VCSEL WAFER"}
        Dim valencia() As String = {"CONTAINER_ID", "SLICE_NO", "CURRENT_STOCK"}
        Dim vcsel() As String = {"TAPE_ID", "CURRENT_STOCK"}
        Dim common() As String = {"MATERIAL_LOT_ID", "QUANTITY"}
        Dim index As Integer = Array.IndexOf(Coltype, type)
        dgv.Columns.Clear()
        dgv.Rows.Clear()

        If index = 0 Then
            For i As Integer = 0 To valencia.Length - 1
                Dim NewColumn As New DataGridViewTextBoxColumn
                NewColumn.HeaderText = valencia(i)
                NewColumn.Name = valencia(i)
                dgv.Columns.Add(NewColumn)
            Next
        ElseIf index = 4 Then
            For i As Integer = 0 To vcsel.Length - 1
                Dim NewColumn As New DataGridViewTextBoxColumn
                NewColumn.HeaderText = vcsel(i)
                NewColumn.Name = vcsel(i)
                dgv.Columns.Add(NewColumn)
            Next
        Else
            For i As Integer = 0 To common.Length - 1
                Dim NewColumn As New DataGridViewTextBoxColumn
                NewColumn.HeaderText = common(i)
                NewColumn.Name = common(i)
                dgv.Columns.Add(NewColumn)
            Next
        End If

    End Sub

    Private Function field_ctrl(id As String) As Boolean
        Dim dm() As Control = {r_type, r_area, r_station, r_process, r_subMC, r_productCode, r_matType, r_supplier, r_matdis, r_matcode, r_oum, r_qty, r_translot, r_optr}
        Dim eng() As Control = {eng_supplier, eng_qty, eng_lot, eng_optr}

        Dim x As Integer = 0
        Select Case id
            Case "DM"
                For i As Integer = 0 To dm.Length - 1
                    If dm(i).Text = Nothing Then
                        x += 1
                    End If
                Next
                If binPnl.Visible = True Then
                    If r_bin.Text = "" Then
                        x += 1
                    End If
                End If

            Case "ENG"
                    For i As Integer = 0 To eng.Length - 1
                    If eng(i).Text = Nothing Then
                        x += 1
                    End If
                Next
        End Select

        If x <> 0 Then
            MsgBox("Incomplete fields!")
            Return False
        Else
            Return True
        End If

    End Function

    Private Sub MainTab_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MainTab.SelectedIndexChanged
        Select Case CInt(MainTab.SelectedIndex)
            Case 1
                tabname.Text = "SEND NEW REQUEST (DM)"
                tabname.ForeColor = Color.Yellow
            Case 0
                tabname.Text = "RECORD OVERVIEW"
            Case 3
                tabname.Text = "RETURN PARTIAL"
            Case 2
                tabname.Text = "SEND NEW REQUEST (IDM)"
                tabname.ForeColor = Color.Aqua
            Case 4
                tabname.Text = "ENGINEERING REQUEST"
        End Select
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MainTab.SelectedIndex = 2
    End Sub

    Private Sub newREQ_Click(sender As Object, e As EventArgs) Handles newREQ.Click
        MainTab.SelectedIndex = 1
    End Sub

    Private Sub viewREC_Click(sender As Object, e As EventArgs) Handles viewREC.Click
        MainTab.SelectedIndex = 0
    End Sub

    Private Sub returnBTN_Click(sender As Object, e As EventArgs)
        MainTab.SelectedIndex = 1

    End Sub

    Private Sub retPartial_Click(sender As Object, e As EventArgs) Handles retPartial.Click
        MainTab.SelectedIndex = 3
    End Sub

    Private Sub DM_Request_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 1 = Records Overview
        ' 3 = IDM
        ' 4 = Engineering
        Request_dropdown("Type", r_type, 1)
        Request_dropdown("Type", idm_type, 3)
        Request_dropdown("Type", eng_type, 4)

        dgv_loader(dgvRecord, "EPOXY_MAIN", "NEW MATERIAL REQUEST")
        dgv_loader(dgvIDM, "IDM_RAW", Nothing)
        dgv_loader(dgvIDMreq, "IDM_REQ", "NEW REQUEST")

        dropdowns() '==> dropdown for search filter
        notify.Path = My.Settings.System_Notifier

        With AutoRefresh
            .Interval = My.Settings.AutuRefresh * 60000
            .Start()
        End With
    End Sub

    Private Sub r_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles r_type.SelectionChangeCommitted
        Request_dropdown("Area", r_area, 1)
    End Sub

    Private Sub r_area_SelectedIndexChanged(sender As Object, e As EventArgs) Handles r_area.SelectionChangeCommitted
        Request_dropdown("Station", r_station, 1)
    End Sub

    Private Sub r_station_SelectedIndexChanged(sender As Object, e As EventArgs) Handles r_station.SelectionChangeCommitted
        Request_dropdown("Process", r_process, 1)
    End Sub

    Private Sub r_process_SelectedIndexChanged(sender As Object, e As EventArgs) Handles r_process.SelectionChangeCommitted
        Request_dropdown("Product Code", r_productCode, 1)
        mcList.Items.Clear()
        EXEC_QRY(" @@MethodType = 'RAW_DROPDOWNS',@Type = 'MC',@columnName = 'Machine',@Process = '" + Trim(r_process.Text) + "'", Nothing)
        r_subMC.Text = Nothing
        For Each row As DataRow In ds.Tables(0).Rows
            mcList.Items.Add(row("Machine"))
        Next

    End Sub

    Private Sub r_productCode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles r_productCode.SelectionChangeCommitted
        Request_dropdown("Material Type", r_matType, 1)
    End Sub

    Private Sub r_matType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles r_matType.SelectionChangeCommitted
        Request_dropdown("Supplier", r_supplier, 1)
    End Sub

    Private Sub r_supplier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles r_supplier.SelectionChangeCommitted
        Dim cb2 As New ComboBox
        Request_dropdown("MatCode", cb2, 1)
        Request_dropdown("Material Description", cb2, 1)
        Request_dropdown("UoM", cb2, 1)
    End Sub
    Private Sub r_supplier_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles r_supplier.SelectedIndexChanged
        If r_supplier.Text = Nothing Then
            r_matcode.Text = Nothing : r_matdis.Text = Nothing : r_oum.Text = Nothing
        End If
    End Sub

    Private Sub e_search_Click(sender As Object, e As EventArgs) Handles e_search.Click
        Dim status As String = Nothing
        If CkReturn.CheckState = CheckState.Checked Then
            status = "ret"
        Else
            status = Nothing
        End If
        dgv_loader(dgvRecord, "EPOXY_MAIN", status)
    End Sub

    Private Sub e_clear_Click(sender As Object, e As EventArgs) Handles e_clear.Click
        e_package.Text = Nothing : e_process.Text = Nothing : e_machine.Text = Nothing : e_empID.Text = Nothing : e_type.Text = Nothing
        'e_search.PerformClick()
    End Sub

    Private Sub e_new_Click(sender As Object, e As EventArgs) Handles e_new.Click
        dgv_loader(dgvRecord, "EPOXY_MAIN", "NEW MATERIAL REQUEST")
    End Sub

    Private Sub e_thaw_Click(sender As Object, e As EventArgs) Handles e_thaw.Click
        dgv_loader(dgvRecord, "EPOXY_MAIN", "THAWING")
    End Sub

    Private Sub e_avail_Click(sender As Object, e As EventArgs) Handles e_avail.Click
        dgv_loader(dgvRecord, "EPOXY_MAIN", "AVAILABLE")
    End Sub

    Private Sub e_forRet_Click(sender As Object, e As EventArgs) Handles e_forRet.Click
        dgv_loader(dgvRecord, "EPOXY_MAIN", "FOR RETURN")
    End Sub

    Private Sub e_aging_Click(sender As Object, e As EventArgs) Handles e_aging.Click
        dgv_loader(dgvRecord, "EPOXY_MAIN", "UNUSED")
    End Sub

    Private Sub e_pending_Click(sender As Object, e As EventArgs) Handles e_pending.Click
        dgv_loader(dgvRecord, "EPOXY_MAIN", "PENDING")
    End Sub

    Private Sub e_wthdrw_Click(sender As Object, e As EventArgs) Handles e_wthdrw.Click
        dgv_loader(dgvRecord, "EPOXY_MAIN", "WITHDRAWN")
    End Sub

    Private Sub e_all_Click(sender As Object, e As EventArgs) Handles e_all.Click
        dgv_loader(dgvRecord, "EPOXY_MAIN", Nothing)
    End Sub

    Private Sub DM_Request_Activated(sender As Object, e As EventArgs) Handles Me.Activated, Me.GotFocus, Me.Load, Me.LostFocus
        Inventory_Counter()
    End Sub

    Private Sub dgvRecord_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles dgvRecord.RowStateChanged
        e_row.Text = dgvRecord.Rows.Count
    End Sub

    Private Sub dgvRecord_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRecord.CellDoubleClick
        With Epoxy_Update
            .TopMost = True
            .TopMost = False
            .Show()
        End With
    End Sub

    Private Sub dm_Clear_click(sender As Object, e As EventArgs) Handles dm_clear.Click
        Dim cmbx() As Control = {r_type, r_area, r_station, r_process, r_productCode, r_matType, r_supplier, r_subMC, r_qty, r_translot, r_optr, r_remarks}
        For i As Integer = 0 To cmbx.Length - 1
            cmbx(i).Text = Nothing
        Next
    End Sub

    Private Sub r_process_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles r_process.SelectedIndexChanged
        If r_process.Text = Nothing Then
            mcList.Items.Clear()
        End If
    End Sub

    Private Sub r_matType_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles r_matType.SelectedIndexChanged
        Dim Vcsel() As String = {"A(G3)", "B(G3)", "C(G3)", "D(G3)", "", "A(G4)", "B(G4)", "C(G4)", "D(G4)"}
        Dim Consume() As String = {"A(COT)", "B(COT)", "C(COT)", "D(COT)"}
        Dim ConsumeR() As String = {"A(SZ)", "B(SZ)", "C(SZ)", "D(SZ)", "", "A(SR)", "B(SR)", "C(SR)", "D(SR)"}
        Dim lens() As String = {"RX", "TX"}

        r_bin.Items.Clear()

        If r_matType.Text.Contains("WAFER") = True And r_station.Text.Contains("VCSEL") = True Then
            binLbl.Text = "VCSEL BIN :"
            binPnl.Visible = True

            For i As Integer = 0 To Vcsel.Length - 1
                r_bin.Items.Add(Vcsel(i))
            Next

        ElseIf r_matType.Text.Contains("Cap With Glass") = True And r_station.Text.Contains("Cap Attach") = True Then
            binLbl.Text = "SELECT BIN :"
            binPnl.Visible = True
            If r_productCode.Text.Contains("ROSALINE") = True Then
                For i As Integer = 0 To ConsumeR.Length - 1
                    r_bin.Items.Add(ConsumeR(i))
                Next
            Else
                For i As Integer = 0 To Consume.Length - 1
                    r_bin.Items.Add(Consume(i))
                Next
            End If

        ElseIf r_matType.Text.Contains("LENS") Then

        Else
            binPnl.Visible = False
            r_bin.Text = Nothing
        End If
    End Sub

    Private Sub r_bin_SelectedIndexChanged(sender As Object, e As EventArgs) Handles r_bin.SelectedIndexChanged
        r_matcode.Text = Matcode & "-" & r_bin.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles dm_send.Click

        'Check if MAchine reach the Syringe limit
        If r_matType.Text = "EPOXY" Then
            EXEC_QRY("@@MethodType = 'MACHINE_LIMIT',@Machine = '" + r_subMC.Text + "'", Nothing)

            If CInt(ds.Tables(0).Rows.Count) >= 6 Then
                MsgBox("REQUEST FAILED!" & vbNewLine & vbNewLine & "Machine " & r_subMC.Text & " is already reach the maximum Buffer count (6)" & vbNewLine & "Please Return the UNUSED Syringe to enable New Request" & vbNewLine & vbNewLine & "Batch No : " & vbTab & ds.Tables(0).Rows(0)("Batch_Code").ToString & "/" & ds.Tables(0).Rows(0)("Machine").ToString & vbNewLine & "Status : " & vbTab & vbTab & ds.Tables(0).Rows(0)("Status").ToString & vbNewLine & "Date Request : " & vbTab & ds.Tables(0).Rows(0)("Request Date").ToString & vbNewLine & "Request By : " & vbTab & ds.Tables(0).Rows(0)("Operator").ToString)
                Exit Sub
            End If
        End If

        'Check for Blank Text
        If field_ctrl("DM") = False Then Exit Sub

        'COnfirm and Proceed
        If MsgBox("REQUEST DETAILS :" & vbNewLine & vbNewLine & "Product : " & vbTab & r_productCode.Text & vbNewLine & "Material Type : " & vbTab & r_matType.Text & " : " & r_matcode.Text & vbNewLine & "Machine : " & vbTab & r_subMC.Text & vbNewLine & "Quantity : " & vbTab & r_qty.Text & vbNewLine & vbNewLine & "Do you wnat to Proceed ?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        Dim r_reasonCode As String = lstRemarks.SelectedItem.ToString()

        Try
            'this code runs perfectly donot edit
            EXEC_QRY("@@MethodType = 'SEND_REQUEST',@TypeID = 'DM',@CollectType = 'NEW MATERIAL REQUEST',@Cluster = 'DM',@Type = '" + Trim(r_type.Text) + "',@Package = '" + Trim(r_productCode.Text) + "',@Product_Code = '" + Trim(r_area.Text) + "',@Process = '" + Trim(r_station.Text) + "',@Step = '" + Trim(r_process.Text) + "',@Material = '" + Trim(r_matType.Text) + "',@Supplier = '" + Trim(r_supplier.Text) + "',@MatCode = '" + Trim(r_matcode.Text) + "',@MatDesc = '" + Trim(r_matdis.Text) + "',@Phantom_Code = '" + Trim(r_translot.Text) + "',@reqBy = '" + Trim(r_optr.Text) + "',@Qty = '" + Trim(r_qty.Text) + "',@UoM = '" + Trim(r_oum.Text) + "',@Machine = '" + Trim(r_subMC.Text) + "',@Remarks = '" + Trim(r_remarks.Text) + "',@ReasonCOde = '" + Trim(r_reasonCode) + "'", Nothing)

            'Trigger Notification to kitting
            Get_Network_Access()
            'notification format::  <TITLE> <TYPE> <MATCODE - MACHINE>
            Trigger_Alert("NEW MATERIAL REQUEST" & "-" & r_matType.Text & "-" & r_matcode.Text & "   " & r_subMC.Text & "-" & Format(DateTime.Now, "ddMMM HHmmss"))

            'confirm
            MsgBox("Request Successfully Send! ")
            If MsgBox("Do you want to request again using your previous data ?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                dm_clear.PerformClick() : viewREC.PerformClick() : e_new.PerformClick()
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgvIDM_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvIDM.CellDoubleClick
        With IDM_Req
            .IDMID = "REQUEST"
            .Show()
        End With
    End Sub

    Private Sub Refresh_Ui(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles _refresh.LinkClicked
        DM_Request_Load(sender, e)
        Inventory_Counter()
        Me.Refresh()
    End Sub

    Private Sub idm_clear_Click(sender As Object, e As EventArgs) Handles idm_clear.Click
        idm_type.Text = Nothing : idm_discription.Text = Nothing : idm_matcode.Text = Nothing
        idm_search.PerformClick()
    End Sub

    Private Sub idm_search_Click(sender As Object, e As EventArgs) Handles idm_search.Click
        IDMTAB.SelectedIndex = 0
        dgv_loader(dgvIDM, "IDM_RAW", Nothing)
    End Sub

    Private Sub idm_new_Click(sender As Object, e As EventArgs) Handles idm_new.Click
        IDMTAB.SelectedIndex = 1
        dgv_loader(dgvIDMreq, "IDM_REQ", "NEW REQUEST")
    End Sub

    Private Sub idm_avail_Click(sender As Object, e As EventArgs) Handles idm_avail.Click
        IDMTAB.SelectedIndex = 1
        dgv_loader(dgvIDMreq, "IDM_REQ", "AVAILABLE")
    End Sub

    Private Sub idm_Withdrawn_Click(sender As Object, e As EventArgs) Handles idm_Withdrawn.Click
        IDMTAB.SelectedIndex = 1
        dgv_loader(dgvIDMreq, "IDM_REQ", "WITHDRAWN")
    End Sub

    Private Sub idm_matcode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles idm_matcode.KeyPress, idm_discription.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            idm_search.PerformClick()
        End If
    End Sub

    Private Sub idm_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles idm_type.SelectedIndexChanged
        idm_search.PerformClick()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles p_load.Click
        If ScanID.Text = Nothing Then Exit Sub

        Dim ctrl() As Control = {p_product, p_process, p_machine, p_reqby, p_reqDate, p_type, reqID, p_matcode, p_mainLot}
        Dim col() As String = {"Package", "Process", "Machine", "Operator", "Request Date", "Material", "ID", "Material Code", "Phantom_Code"}

        EXEC_QRY("@@MethodType = 'SCAN_ID',@CollectType = 'RawData',@Lotno = '" + Trim(ScanID.Text) + "'", Nothing)

        If ds.Tables(0).Rows.Count > 0 Then

            Dim type As String = ds.Tables(0).Rows(0)("Material").ToString
            Dim process As String = ds.Tables(0).Rows(0)("Process").ToString

            If type = "EPOXY" Or type = "LOCTITE" Then MsgBox("To return Empty/Expired Epoxy : " & vbNewLine & "1. Click VIEW RECORDS" & vbNewLine & "2. Search the MACHINE NO." & vbNewLine & "3. Double click the ROW , Update the Data." & vbNewLine & "4. SAVE") : Exit Sub

            If p_type.Text = Nothing And p_process.Text = Nothing Then

                For i As Integer = 0 To ctrl.Length - 1
                    ctrl(i).Text = ds.Tables(0).Rows(0)(col(i)).ToString
                Next
            ElseIf p_type.Text <> Nothing And p_process.Text <> Nothing Then
                If p_type.Text <> type Or p_process.Text <> process Then MsgBox("Sorry this Batch: " & ScanID.Text & " is diffirent from the list below" & vbNewLine & "Make sure that the Material Type & Process is same with the list below") : Exit Sub
            End If
            dgvpartial.Rows.Add("X", ScanID.Text)
            dgvpartial.Columns(0).DefaultCellStyle.BackColor = Color.Red
            dgvpartial.Columns(0).DefaultCellStyle.ForeColor = Color.Black
            dgvpartial.Columns(1).DefaultCellStyle.BackColor = Color.Orange
            dgvpartial.Columns(1).DefaultCellStyle.ForeColor = Color.Black
        Else
            MsgBox("Batch : " & ScanID.Text & " has no transaction data." & vbNewLine & "Please input a Valid Batch/Slice No")
        End If
    End Sub

    Private Sub dgvpartial_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvpartial.CellContentClick
        If dgvpartial.Rows.Count = 0 Then Exit Sub
        Try
            If e.ColumnIndex = dgvpartial.Columns(0).Index AndAlso e.RowIndex >= 0 Then
                dgvpartial.Rows.RemoveAt(e.RowIndex)
            End If
        Catch
        End Try
    End Sub

    Private Sub ScanID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ScanID.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            p_load.PerformClick() : ScanID.Text = Nothing : ScanID.Select()
        End If
    End Sub

    Private Sub dgvpartial_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles dgvpartial.RowStateChanged
        If dgvpartial.Rows.Count = 0 Then
            Dim ctrl() As Control = {p_product, p_process, p_machine, p_reqby, p_reqDate, p_type, reqID}

            For i As Integer = 0 To ctrl.Length - 1
                ctrl(i).Text = Nothing
            Next
        End If
    End Sub

    Private Sub p_clear_Click(sender As Object, e As EventArgs) Handles p_clear.Click
        Dim ctrl() As Control = {p_product, p_process, p_machine, p_reqby, p_reqDate, p_type, reqID, p_retBy, p_reason}

        For i As Integer = 0 To ctrl.Length - 1
            ctrl(i).Text = Nothing
        Next
        dgvpartial.Rows.Clear()
    End Sub

    Private Sub p_send_Click(sender As Object, e As EventArgs) Handles p_send.Click
        Dim qty As String = Nothing
        Dim batch As String = Nothing

        If dgvpartial.Rows.Count = 0 Or p_retBy.Text = Nothing Then MsgBox("Incomplete fields! try again...") : Exit Sub

        For Each row As DataGridViewRow In dgvpartial.Rows
            If row.Cells(2).Value.ToString <> "" Then
                If qty <> Nothing And batch <> Nothing Then
                    qty = qty & "," & row.Cells(2).Value.ToString
                    batch = batch & "," & row.Cells(1).Value.ToString
                ElseIf qty = Nothing And batch = Nothing Then
                    qty = row.Cells(2).Value.ToString
                    batch = row.Cells(1).Value.ToString
                End If
            Else
                MsgBox("Missing Quantity!, try again")
                Exit Sub
            End If
        Next

        If qty = Nothing Or batch = Nothing Then Exit Sub
        Try
            EXEC_QRY("@@MethodType = 'SEND_REQUEST',@CollectType = 'NEW MATERIAL REQUEST',@TypeID = 'PARTIAL',@Package = '" + p_product.Text + "',@Process = '" + p_process.Text + "',@BatchCode = '" + batch + "',@MatCode = '" + p_matcode.Text + "',@Material = '" + p_type.Text + "',@reqBy = '" + p_retBy.Text + "',@Qty = '" + qty + "',@Machine = '" + p_machine.Text + "',@Remarks = '" + p_reason.Text + "',@Phantom_Code = '" + p_mainLot.Text + "',@ID = '" + reqID.Text + "'", Nothing)

            MsgBox("Return Request Sent! " & vbNewLine & vbNewLine & "Please Return the items to Kitting")
            p_clear.PerformClick()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub notify_Created(sender As Object, e As FileSystemEventArgs) Handles notify.Created
        Dim IDS As String = Path.GetFileNameWithoutExtension(e.FullPath)

        If Not IDS.Contains("AVAILABLE") And Not IDS.Contains("GOLDWIRE") Then Exit Sub

        Dim part() As String = IDS.Split("-")
        Dim title As String = part(0)
        Dim type As String = part(1)
        Dim msg As String = part(2)

        Inventory_Counter()

        My.Computer.Audio.Play(My.Resources.combo_low, AudioPlayMode.Background)
        optrNotifier.BalloonTipIcon = ToolTipIcon.Info
        optrNotifier.BalloonTipText = Type & vbNewLine & msg
        optrNotifier.BalloonTipTitle = title
        optrNotifier.ShowBalloonTip(5000)

        Me.TopMost = True : Me.TopMost = False
        Xfile.Start()

    End Sub

    Private Sub Xfile_Tick(sender As Object, e As EventArgs) Handles Xfile.Tick
        Xfile.Stop()
        Get_Network_Access()
        DEL_file(My.Settings.System_Notifier, "txt")
    End Sub

    Private Sub Button2_Click_2(sender As Object, e As EventArgs) Handles Button2.Click
        MainTab.SelectedIndex = 4
    End Sub

    Private Sub eng_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles eng_type.SelectionChangeCommitted
        Request_dropdown("Area", eng_area, 4)
    End Sub

    Private Sub eng_area_SelectedIndexChanged(sender As Object, e As EventArgs) Handles eng_area.SelectionChangeCommitted
        Request_dropdown("Station", eng_station, 4)
    End Sub

    Private Sub eng_station_SelectedIndexChanged(sender As Object, e As EventArgs) Handles eng_station.SelectionChangeCommitted
        Request_dropdown("Process", eng_step, 4)
    End Sub

    Private Sub eng_step_SelectedIndexChanged(sender As Object, e As EventArgs) Handles eng_step.SelectionChangeCommitted
        Request_dropdown("Product Code", eng_package, 4)
    End Sub

    Private Sub eng_package_SelectedIndexChanged(sender As Object, e As EventArgs) Handles eng_package.SelectionChangeCommitted
        Request_dropdown("Material Type", eng_mattype, 4)
    End Sub

    Private Sub eng_mattype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles eng_mattype.SelectionChangeCommitted
        Request_dropdown("Supplier", eng_supplier, 4)
    End Sub

    Private Sub eng_supplier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles eng_supplier.SelectionChangeCommitted
        Dim cb2 As New ComboBox
        Request_dropdown("MatCode", cb2, 4)
        Request_dropdown("Material Description", cb2, 4)
        Request_dropdown("UoM", cb2, 4)
    End Sub

    Private Sub eng_mattype_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles eng_mattype.SelectedIndexChanged
        Dim Vcsel() As String = {"A(G3)", "B(G3)", "C(G3)", "D(G3)", "", "A(G4)", "B(G4)", "C(G4)", "D(G4)"}
        Dim Consume() As String = {"A(COT)", "B(COT)", "C(COT)", "D(COT)"}
        Dim ConsumeR() As String = {"A(SZ)", "B(SZ)", "C(SZ)", "D(SZ)", "", "A(SR)", "B(SR)", "C(SR)", "D(SR)"}
        eng_bin.Items.Clear()

        If eng_mattype.Text.Contains("WAFER") = True And eng_station.Text.Contains("VCSEL") = True Then
            eng_lbl.Text = "VCSEL BIN :"
            eng_binpnl.Visible = True

            For i As Integer = 0 To Vcsel.Length - 1
                eng_bin.Items.Add(Vcsel(i))
            Next

        ElseIf eng_mattype.Text.Contains("Cap With Glass") = True And eng_station.Text.Contains("Cap Attach") = True Then
            eng_lbl.Text = "SELECT BIN :"
            eng_binpnl.Visible = True
            If eng_package.Text.Contains("ROSALINE") = True Then
                For i As Integer = 0 To ConsumeR.Length - 1
                    eng_bin.Items.Add(ConsumeR(i))
                Next
            Else
                For i As Integer = 0 To Consume.Length - 1
                    eng_bin.Items.Add(Consume(i))
                Next
            End If

        Else
            eng_binpnl.Visible = False
            eng_bin.Text = Nothing
        End If
    End Sub

    Private Sub eng_step_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles eng_step.SelectedIndexChanged
        COMBOBOX(" @@MethodType = 'RAW_DROPDOWNS',@Type = 'MC',@columnName = 'Machine',@Process = '" + Trim(eng_step.Text) + "'", "Machine", eng_machine)
        r_subMC.Text = Nothing
    End Sub

    Private Sub eng_package_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles eng_package.SelectedIndexChanged

    End Sub

    Private Sub r_productCode_SelectedIndexChanged_2(sender As Object, e As EventArgs) Handles r_productCode.SelectedIndexChanged

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If eng_subMC.Text = eng_machine.Text Or eng_subMC.Text.Contains(eng_machine.Text) Then
            MsgBox(eng_machine.Text & " is Already Exist!")
            eng_machine.Text = Nothing
            Exit Sub
        End If

        If eng_subMC.Text = Nothing Then
            eng_subMC.Text = eng_machine.Text
        Else
            eng_subMC.Text = eng_subMC.Text & "," & eng_machine.Text
        End If
        eng_machine.Text = Nothing
    End Sub

    Private Sub eng_clear_Click(sender As Object, e As EventArgs) Handles eng_clear.Click
        Dim cmbx() As Control = {eng_type, eng_area, eng_station, eng_step, eng_package, eng_mattype, eng_supplier, eng_dis, eng_matcode, eng_qty, eng_UoM, eng_lot, eng_optr, eng_remarks, eng_subMC}
        For i As Integer = 0 To cmbx.Length - 1
            cmbx(i).Text = Nothing
        Next
    End Sub

    Private Sub eng_send_Click(sender As Object, e As EventArgs) Handles eng_send.Click
        If field_ctrl("ENG") = False Then Exit Sub
        If MsgBox("REQUEST DETAILS :" & vbNewLine & vbNewLine & "Product : " & vbTab & eng_package.Text & vbNewLine & "Material Type : " & vbTab & eng_mattype.Text & " : " & eng_matcode.Text & vbNewLine & "Machine : " & vbTab & eng_subMC.Text & vbNewLine & "Quantity : " & vbTab & eng_qty.Text & vbNewLine & vbNewLine & "Do you wnat to Proceed ?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        Dim r_reasonCode As String = eng_reason.SelectedItem.ToString()

        Try
            'this code runs perfectly donot edit
            EXEC_QRY("@@MethodType = 'SEND_REQUEST',@TypeID = 'DM',@CollectType = 'NEW MATERIAL REQUEST',@Cluster = 'DM',@Type = '" + Trim(eng_type.Text) + "',@Package = '" + Trim(eng_package.Text) + "',@Product_Code = '" + Trim(eng_area.Text) + "',@Process = '" + Trim(eng_station.Text) + "',@Step = '" + Trim(eng_step.Text) + "',@Material = '" + Trim(eng_mattype.Text) + "',@Supplier = '" + Trim(eng_supplier.Text) + "',@MatCode = '" + Trim(eng_matcode.Text) + "',@MatDesc = '" + Trim(eng_dis.Text) + "',@Phantom_Code = '" + Trim(eng_lot.Text) + "',@reqBy = '" + Trim(eng_optr.Text) + "',@Qty = '" + Trim(eng_qty.Text) + "',@UoM = '" + Trim(eng_UoM.Text) + "',@Machine = '" + Trim(eng_subMC.Text) + "',@Remarks = '" + Trim(eng_remarks.Text) + "',@ReasonCOde = '" + Trim(r_reasonCode) + "'", Nothing)

            'Trigger Notification to kitting
            Get_Network_Access()
            'notification format::  <TITLE> <TYPE> <MATCODE - MACHINE>
            Trigger_Alert("NEW MATERIAL REQUEST" & "-ENGINEERING-" & eng_mattype.Text & "   " & eng_machine.Text & "-" & Format(DateTime.Now, "ddMMM HHmmss"))

            'confirm
            MsgBox("Request Successfully Send! ")
            If MsgBox("Do you want to request again using your previous data ?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                dm_clear.PerformClick() : viewREC.PerformClick() : e_new.PerformClick()
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub r_oum_TextChanged(sender As Object, e As EventArgs) Handles r_oum.TextChanged
        If r_oum.Text = "Syringe" Or r_oum.Text = "Canister" Or r_oum.Text = "Cartridge" Then
            r_qty.Text = "1" : r_qty.Enabled = False
        Else
            r_qty.Enabled = True : r_qty.Text = Nothing
        End If
    End Sub

    Private Sub mcList_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles mcList.SelectedIndexChanged
        Dim checkedItems As New List(Of String)

        For Each item As Object In mcList.CheckedItems
            checkedItems.Add(item.ToString())
        Next

        r_subMC.Text = String.Join(",", checkedItems)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        For i As Integer = 0 To mcList.Items.Count - 1
            mcList.SetItemCheckState(i, False)
        Next
        r_subMC.Text = Nothing
    End Sub

    Private Sub e_package_SelectedIndexChanged(sender As Object, e As EventArgs) Handles e_package.SelectionChangeCommitted, e_process.SelectionChangeCommitted, e_type.SelectionChangeCommitted, CkReturn.CheckStateChanged, e_machine.SelectionChangeCommitted
        e_search.PerformClick()
    End Sub

    Private Sub e_empID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles e_empID.KeyPress, e_machine.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e_search.PerformClick()
        End If
    End Sub

    Private Sub epoxycsv_Click(sender As Object, e As EventArgs) Handles ManualPDF.Click
        Try
            Process.Start(My.Settings.Manual)
        Catch ex As Exception
            MsgBox("Ongoing Update")
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles retEPOXY.Click
        Dim mc As String = InputBox("PLEASE ENTER MACHINE NO# :", "RETURN EPOXY")
        If mc = "" Then Exit Sub
        MainTab.SelectedIndex = 0
        e_clear.PerformClick()
        e_machine.Text = mc
        e_search.PerformClick()
    End Sub

    Private Sub dgvIDM_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvIDM.CellMouseClick
        MouseRightClick(sender, e, dgvIDM, idmMENU)
    End Sub

    Private Sub idmreq_Click(sender As Object, e As EventArgs) Handles idmreq.Click
        With IDM_Req
            .IDMID = "REQUEST"
            .Show()
        End With
    End Sub

    Private Sub dgvRecord_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvRecord.CellMouseClick
        Try
            Dim stat As String = dgvRecord.SelectedRows(0).Cells("Status").Value.ToString
            If stat = "NEW MATERIAL REQUEST" Then
                dmMenuFollowUp.Enabled = True : dmMenuFollowUp.Visible = True
                dmMenuUsed.Enabled = False : dmMenuUsed.Visible = False
                dmMenuReturn.Enabled = False : dmMenuReturn.Visible = False
            ElseIf stat = "FOR RETURN" Then
                dmMenuFollowUp.Enabled = False : dmMenuFollowUp.Visible = False
                dmMenuUsed.Enabled = True : dmMenuUsed.Visible = True
                dmMenuReturn.Enabled = False : dmMenuReturn.Visible = False
            ElseIf stat = "UNUSED" Then
                dmMenuFollowUp.Enabled = False : dmMenuFollowUp.Visible = False
                dmMenuUsed.Enabled = False : dmMenuUsed.Visible = False
                dmMenuReturn.Enabled = True : dmMenuReturn.Visible = True
            Else
                Exit Sub
            End If
            MouseRightClick(sender, e, dgvRecord, dmMENU)
        Catch
        End Try
    End Sub

    Private Sub dmMenuUsed_Click(sender As Object, e As EventArgs) Handles dmMenuUsed.Click, dmMenuReturn.Click
        With Epoxy_Update
            .TopMost = True
            .TopMost = False
            .Show()
        End With
    End Sub

    Private Sub dmMenuFollowUp_Click(sender As Object, e As EventArgs) Handles dmMenuFollowUp.Click
        Dim XROW As DataGridViewRow = dgvRecord.SelectedRows(0)
        Get_Network_Access()
        'notification format::  <TITLE> <TYPE> <MATCODE - MACHINE>
        Trigger_Alert("FOLLOW UP" & "-" & XROW.Cells("Material").Value.ToString & "-" & XROW.Cells("Material Code").Value.ToString & "   " & XROW.Cells("Machine").Value.ToString & "-" & Format(DateTime.Now, "ddMMM HHmmss"))

        MsgBox("Notification Sent to Kitting!")
    End Sub

    Private Sub AutoRefresh_Tick(sender As Object, e As EventArgs) Handles AutoRefresh.Tick
        Inventory_Counter()
    End Sub
End Class