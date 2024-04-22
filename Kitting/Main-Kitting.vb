Public Class Main_Kitting
    Private ActiveDGV As DataGridView
    Public Sub raw_Dgv_loader(dgv As DataGridView, collect As String, type As String, status As String)

        Select Case collect
            Case "INDIRECT MATERIAL"
                If type = "Stock" Then
                    Load_data_from_db("@@MethodType = 'LOAD_IDM',@CollectType = 'IDM_RAW',@Type = '" + idm_type.Text + "',@MatDesc = '" + idm_description.Text + "',@MatCode = '" + idm_matcode.Text + "'", dgv, "EPOXY", Nothing, Nothing, Nothing)
                ElseIf type = "req" Then
                    Load_data_from_db("@@MethodType = 'LOAD_IDM',@CollectType = 'IDM_REQ',@limitrow = '" + idmlimit.Text.Trim + "',@Status = '" + status + "',@Type = '" + idmr_type.Text + "',@MatCode = '" + idmr_matcode.Text + "',@Machine = '" + idmr_mc.Text + "',@date_Filter = '" + idmr_datef.Text + "',@Dfrom = '" + fr_idmr.Text + "',@Dto = '" + to_idmr.Text + "'", dgv, "EPOXY", Nothing, Nothing, Nothing)
                End If

            Case "CAPS_GLASS"
                If type = "CAP" Then
                    Load_data_from_db("@@MethodType = 'LOAD_RAW_DATA',@CollectType = '" + collect + "',@limitrow = '" + Trim(limitRow.Text) + "',@Type = '" + type + "',@Package = '" + Trim(ccpackage.Text) + "',@bin = '" + Trim(ccbin.Text) + "',@n2 = '" + Trim(ccn2.Text) + "',@Ctape = '" + Trim(cctape.Text) + "',@caps = '" + Trim(cccap.Text) + "',@Lotno = '" + Trim(ccbatch.Text) + "',@date_Filter = '" + Trim(ccdatef.Text) + "',@Dfrom = '" + frcc.Text + "',@Dto = '" + tocc.Text + "',@Status = '" + status + "'", dgv, "RAW", Nothing, Nothing, Nothing)
                Else
                    Load_data_from_db("@@MethodType = 'LOAD_RAW_DATA',@CollectType = '" + collect + "',@limitrow = '" + Trim(limitRow.Text) + "',@Type = '" + type + "',@Package = '" + Trim(gcpackage.Text) + "',@bin = '" + Trim(gcbin.Text) + "',@n2 = '" + Trim(gcn2.Text) + "',@site = '" + Trim(gcsite.Text) + "',@Lotno = '" + Trim(gclotno.Text) + "',@date_Filter = '" + Trim(gcdatef.Text) + "',@Dfrom = '" + frgc.Text + "',@Dto = '" + togc.Text + "',@Status = '" + status + "'", dgv, "RAW", Nothing, Nothing, Nothing)
                End If

            Case "VALENCIA WAFER"
                Load_data_from_db("@@MethodType = 'LOAD_RAW_DATA',@CollectType = '" + collect + "',@limitrow = '" + Trim(limitRow.Text) + "',@Package = '" + Trim(vapackage.Text) + "',@slice = '" + Trim(vaslice.Text) + "',@Container = '" + Trim(vacontainer.Text) + "',@MatCode = '" + Trim(vamatcode.Text) + "',@date_Filter = '" + Trim(vadatef.Text) + "',@Dfrom = '" + frva.Text + "',@Dto = '" + tova.Text + "',@Status = '" + status + "'", dgvValencia, "RAW", Nothing, Nothing, Nothing)

            Case "VCSEL WAFER"
                Load_data_from_db("@@MethodType = 'LOAD_RAW_DATA',@CollectType = '" + collect + "',@limitrow = '" + Trim(limitRow.Text) + "',@Package = '" + Trim(vcpackage.Text) + "',@bin = '" + Trim(vcbin.Text) + "',@Machine = '" + Trim(vcmachine.Text) + "', @tapeID = '" + Trim(vctapeid.Text) + "',@Status = '" + status + "',@date_Filter = '" + Trim(vcdatef.Text) + "',@Dfrom = '" + frvc.Text + "',@Dto = '" + tovc.Text + "'", dgvVcsel, "RAW", Nothing, Nothing, Nothing)

            Case "REEL MATERIAL"
                If type = "SMT" Then
                    Load_data_from_db("@@MethodType = 'LOAD_RAW_DATA',@CollectType = '" + collect + "',@limitrow = '" + Trim(limitRow.Text) + "',@Package = '" + Trim(inproduct.Text) + "',@Type = '" + type + "',@MatCode = '" + Trim(inmatcode.Text) + "',@reel = '" + Trim(inreel.Text) + "',@Lotno = '" + Trim(inlotno.Text) + "',@Status = '" + status + "',@date_Filter = '" + Trim(indatef.Text) + "',@Dfrom = '" + frin.Text + "',@Dto = '" + toin.Text + "'", dgv, "RAW", Nothing, Nothing, Nothing)
                Else
                    Load_data_from_db("@@MethodType = 'LOAD_RAW_DATA',@CollectType = '" + collect + "',@limitrow = '" + Trim(limitRow.Text) + "',@Package = '" + Trim(bcpackage.Text) + "',@Type = '" + type + "',@MatCode = '" + Trim(bcmatcode.Text) + "',@Lotno = '" + Trim(bclotno.Text) + "',@Status = '" + status + "',@date_Filter = '" + Trim(bcdatef.Text) + "',@Dfrom = '" + frbc.Text + "',@Dto = '" + tobc.Text + "'", dgv, "RAW", Nothing, Nothing, Nothing)
                End If

            Case "RAW_REQUEST"
                Load_data_from_db("@@MethodType = 'LOAD_RAW_DATA',@CollectType = '" + collect + "',@limitrow = '" + Trim(limitRow.Text) + "',@Status = '" + status + "',@date_Filter = '" + Trim(rwdatef.Text) + "',@Dfrom = '" + frrw.Text + "',@Dto = '" + torw.Text + "',@Package = '" + Trim(rwpackage.Text) + "',@MatType = '" + Trim(rwtype.Text) + "',@Process = '" + Trim(rwprocess.Text) + "',@Lotno = '" + Trim(rwlotno.Text) + "',@Machine = '" + Trim(rwmachine.Text) + "'", dgv, "EPOXY", Nothing, Nothing, Nothing)

            Case "EPOXY_MAIN"
                Load_data_from_db("@@MethodType = 'EPOXY_REQUEST',@CollectType = '" + collect + "',@limitrow = '" + Trim(e_limitrow.Text) + "',@Status = '" + status + "',@date_Filter = '" + Trim(e_datetype.Text) + "',@Dfrom = '" + e_fr.Text + "',@Dto = '" + e_to.Text + "',@Package = '" + Trim(e_package.Text) + "',@MatType = '" + Trim(e_type.Text) + "',@Process = '" + Trim(e_process.Text) + "',@Lotno = '" + Trim(e_batchno.Text) + "',@Machine = '" + Trim(e_machine.Text) + "'", dgv, "EPOXY", Nothing, Nothing, Nothing)

            Case "AU_KITTING"
                Load_data_from_db("@@MethodType = 'AU_LOAD',@CollectType = '" + type + "',@limitrow = '" + goldLimit.Text.Trim + "',@Status = '" + status + "',@date_Filter = '" + g_datetype.Text.Trim + "',@Dfrom = '" + g_fr.Text.Trim + "',@Dto = '" + g_to.Text.Trim + "',@Package = '" + g_package.Text.Trim + "',@MatCode = '" + g_matcode.Text.Trim + "',@SpoolNo = '" + g_spool.Text.Trim + "',@returnSlip = '" + g_slip.Text.Trim + "',@reservNo = '" + g_reserve.Text.Trim + "'", dgv, "GOLD", Nothing, Nothing, Nothing)

        End Select
        dgv.ClearSelection()

    End Sub

    Sub raw_dropdowns()
        'ALL ARRAY IS IN ORDER. ( X-FOR COMBOBOX, Y-COLUMNNAME IN THE DATABASE )

        'sql collectType
        Dim type() As String = {"CC", "VA", "VC", "BARE", "REQ", "AU", "IDM_RAW", "IDM_REQ"}
        'Caps Consume combobox
        Dim ccy() As ComboBox = {ccpackage, cctape, cccap, ccn2}
        Dim ccx() As String = {"PRODUCT", "CARRIER_TAPE", "CAPS", "CURRENT_N2_LOCATION"}
        'Valencia combobox
        Dim vay() As ComboBox = {vapackage, vamatcode}
        Dim vax() As String = {"PRODUCT", "MATERIAL_CODE"}
        'Vcsel combobox
        Dim vcy() As ComboBox = {vcpackage, vcbin, vcmachine}
        Dim vcx() As String = {"LAST_PACKAGE_USED", "VCSEL_BIN", "LAST_MACHINE_USED"}
        'smt combobox
        Dim iny() As ComboBox = {inmatcode, inproduct}
        Dim inx() As String = {"MATERIAL_CODE", "PRODUCT"}
        'Bare Caps combobox
        Dim bcy() As ComboBox = {bcpackage, bcmatcode}
        Dim bcx() As String = {"PRODUCT", "MATERIAL_CODE"}
        'Glass Consume combobox
        Dim gcy() As ComboBox = {gcpackage, gcbin, gcsite, gcn2}
        Dim gcx() As String = {"PRODUCT", "BIN", "SITE", "CURRENT_N2_LOCATION"}
        'Raw Request
        Dim rwy() As ComboBox = {rwpackage, rwtype, rwprocess}
        Dim rwx() As String = {"Package", "Material", "Process"}
        'Epoxy Request
        Dim epoxyY() As ComboBox = {e_package, e_process, e_machine, e_type}
        Dim epoxyX() As String = {"Package", "Process", "Machine", "Material"}
        'Gold Request
        Dim auY() As ComboBox = {g_package}
        Dim auX() As String = {"PACKAGE"}
        'IDM REQUEST
        Dim idmrY() As ComboBox = {idmr_type, idmr_mc}
        Dim idmrX() As String = {"Type", "Machine"}
        'IDM RAW
        Dim idmY() As ComboBox = {idm_type}
        Dim idmX() As String = {"Type"}

        Dim i As Integer
        Dim j As Integer

        'wow magic!
        For j = 0 To type.Length - 1
            Select Case type(j)
                Case "CC"
                    For i = 0 To ccy.Length - 1
                        'Caps Consume
                        COMBOBOX("@@MethodType = 'RAW_DROPDOWNS',@Type = '" + type(j) + "',@Cluster = 'CAP',@columnName = '" + ccx(i) + "'", ccx(i), ccy(i))
                        'Glass Consume
                        COMBOBOX("@@MethodType = 'RAW_DROPDOWNS',@Type = '" + type(j) + "',@Cluster = 'CAP',@columnName = '" + gcx(i) + "'", gcx(i), gcy(i))
                    Next i

                Case "VA"
                    For i = 0 To vay.Length - 1
                        COMBOBOX("@@MethodType = 'RAW_DROPDOWNS',@Type = '" + type(j) + "',@Cluster = '',@columnName = '" + vax(i) + "'", vax(i), vay(i))
                    Next i

                Case "VC"
                    For i = 0 To vcy.Length - 1
                        COMBOBOX("@@MethodType = 'RAW_DROPDOWNS',@Type = '" + type(j) + "',@columnName = '" + vcx(i) + "'", vcx(i), vcy(i))
                    Next i

                Case "BARE"
                    For i = 0 To bcy.Length - 1
                        'Bare Caps
                        COMBOBOX("@@MethodType = 'RAW_DROPDOWNS',@Type = '" + type(j) + "',@Cluster = 'CAP',@columnName = '" + bcx(i) + "'", bcx(i), bcy(i))
                        'SMT
                        COMBOBOX("@@MethodType = 'RAW_DROPDOWNS',@Type = '" + type(j) + "',@Cluster = 'SMT',@columnName = '" + inx(i) + "'", inx(i), iny(i))
                    Next i
                Case "REQ"
                    'RAW
                    For i = 0 To rwy.Length - 1
                        COMBOBOX("@@MethodType = 'RAW_DROPDOWNS',@Type = '" + type(j) + "',@Cluster = 'REQ_RAW',@columnName = '" + rwx(i) + "'", rwx(i), rwy(i))
                    Next
                    'EPOXY
                    For i = 0 To epoxyY.Length - 1
                        COMBOBOX("@@MethodType = 'RAW_DROPDOWNS',@Type = '" + type(j) + "',@Cluster = 'REQ_EPOXY',@columnName = '" + epoxyX(i) + "'", epoxyX(i), epoxyY(i))
                    Next
                Case "AU"
                    For i = 0 To auY.Length - 1
                        COMBOBOX("@@MethodType = 'RAW_DROPDOWNS',@Type = 'GOLD_TRAN',@columnName = '" + auX(i) + "'", auX(i), auY(i))
                    Next

                Case "IDM_RAW"
                    For i = 0 To idmY.Length - 1
                        COMBOBOX("@@MethodType = 'RAW_DROPDOWNS',@Type = '" + type(j) + "',@columnName = '" + idmX(i) + "'", idmX(i), idmY(i))
                    Next

                Case "IDM_REQ"
                    For i = 0 To idmrY.Length - 1
                        COMBOBOX("@@MethodType = 'RAW_DROPDOWNS',@Type = '" + type(j) + "',@columnName = '" + idmrX(i) + "'", idmrX(i), idmrY(i))
                    Next
            End Select
        Next

    End Sub

    Sub Inventory_Counter(id As String, type As String)

        Dim collecttype() As String = {"caps_consume", "valencia", "vcsel", "reelMat", "RAWrequest", "Epoxyrequest", "IDMRequest", "Goldwire"}
        Dim index As Integer = Array.IndexOf(collecttype, id)
        Dim status() As String = {"STOCK", "ISSUED", "HOLD", "SCRAPPED"}
        Dim statusWide() As String = {"STOCK", "ISSUED", "HOLD", "ONLINE"}
        Dim RAWreqStatus() As String = {"NEW", "AVAIL", "PENDING", "WITHDRAWN", "RECEIVED"} ' X = 4
        Dim EPOXYreqStatus() As String = {"NEW", "AVAIL", "PENDING", "RECEIVED", "RETURN", "THAWING", "CLOSED", "UNUSED"} ' X = 6
        Dim GOLDreqStatusT() As String = {"NEW", "AVAIL", "ON-LINE", "RETURN", "VAULT", "DISPO", "SCRAP", "ERET", "EMPTY"} ' X = 8
        Dim IDMRequest() As String = {"NEW", "AVAIL", "WITHDRW"}
        Dim main() As Control = {idm_int, dm_int, epoxy_int, gold_int}
        Dim cc() As Button = {ccstock, ccissued, cchold, ccscrap}
        Dim vc() As Button = {vcstock, vcsissued, vchold, vcscrap}
        Dim va() As Button = {vastock, vaissued, vahold, vascrap}
        Dim int() As Button = {instock, inissued, inhold, inscrap}
        Dim bc() As Button = {bcstock, bcissued, bchold, bcscrap}
        Dim gc() As Button = {gcstock, gcissued, gchold, gcscrap}
        Dim rw() As Button = {rw_new, rw_avail, rw_pending, rw_with, rw_close}
        Dim epoxy() As Button = {e_new, e_avail, e_pending, e_received, e_return, e_thaw, e_close, e_unused}
        Dim goldT() As Button = {g_new, g_avail, g_online, g_return, g_vault, g_dispo, g_scrap, g_eret, g_empty}
        Dim idm() As Button = {idm_new, idm_avail, idm_withdrawn}

        Dim i As Integer
        Dim x As Integer
        If index = 4 Then
            x = 4
        ElseIf index = 5 Then
            x = 7
        ElseIf index = 6 Then
            x = 2
        ElseIf index = 7 Then
            x = 8
        Else
            x = 3
        End If


        For i = 0 To x
            EXEC_QRY("@@MethodType = 'INV_RAW',@CollectType = '" + id + "',@Type = '" + type + "'", Nothing)

            Select Case index
                Case 0
                    If type = "CAP" Then
                        cc(i).Text = ds.Tables(0).Rows(0)(statusWide(i)).ToString
                    Else
                        gc(i).Text = ds.Tables(0).Rows(0)(statusWide(i)).ToString
                    End If
                Case 1
                    va(i).Text = ds.Tables(0).Rows(0)(status(i)).ToString
                Case 2
                    vc(i).Text = ds.Tables(0).Rows(0)(status(i)).ToString
                Case 3
                    If type = "SMT" Then
                        int(i).Text = ds.Tables(0).Rows(0)(status(i)).ToString
                    Else
                        bc(i).Text = ds.Tables(0).Rows(0)(status(i)).ToString
                    End If
                Case 4
                    rw(i).Text = ds.Tables(0).Rows(0)(RAWreqStatus(i)).ToString
                Case 5
                    epoxy(i).Text = ds.Tables(0).Rows(0)(EPOXYreqStatus(i)).ToString
                Case 6
                    idm(i).Text = ds.Tables(0).Rows(0)(IDMRequest(i)).ToString
                Case 7
                    goldT(i).Text = ds.Tables(0).Rows(0)(GOLDreqStatusT(i)).ToString
            End Select
        Next

    End Sub

    Public Sub INV_RUN(type As Integer)

        Select Case type
            Case 0
                Inventory_Counter("caps_consume", "CAP")
                Inventory_Counter("caps_consume", "GLASS")
                Inventory_Counter("valencia", Nothing)
                Inventory_Counter("vcsel", Nothing)
                Inventory_Counter("reelMat", "SMT")
                Inventory_Counter("reelMat", "CAP")
            Case 1
                Inventory_Counter("RAWrequest", Nothing)
                Inventory_Counter("Epoxyrequest", Nothing)
                Inventory_Counter("IDMRequest", Nothing)
                Inventory_Counter("Goldwire", Nothing)
        End Select

        'Request INDICATOR
        idm_int.Text = idm_new.Text : dm_int.Text = rw_new.Text : epoxy_int.Text = e_new.Text : gold_int.Text = g_new.Text
        Dim main_int() As Control = {idm_int, dm_int, epoxy_int, gold_int}
        For i As Integer = 0 To main_int.Length - 1
            If CInt(main_int(i).Text) > 0 Then
                main_int(i).BackColor = Color.Red : main_int(i).ForeColor = Color.White
            Else
                main_int(i).BackColor = Color.Transparent : main_int(i).ForeColor = Color.White
            End If
        Next
    End Sub

    Public Sub Main_Kitting_Activated(sender As Object, e As EventArgs) Handles Me.Activated, Me.GotFocus
        INV_RUN(1) : INV_RUN(0)
    End Sub

    Public Sub Main_Kitting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'raw_Dgv_loader(dgv As DataGridView, collect As String, type As String, status As String)
        raw_Dgv_loader(dgvConsume, "CAPS_GLASS", "CAP", "IN STOCK")
        raw_Dgv_loader(dgvConsume, "VALENCIA WAFER", Nothing, "IN STOCK")
        raw_Dgv_loader(dgvConsume, "VCSEL WAFER", Nothing, "IN STOCK")
        raw_Dgv_loader(dgvbare, "REEL MATERIAL", "CAP", "IN STOCK")
        raw_Dgv_loader(dgvSmt, "REEL MATERIAL", "SMT", "IN STOCK")
        raw_Dgv_loader(dgvGlass, "CAPS_GLASS", "GLASS", "IN STOCK")
        raw_Dgv_loader(dgvRawRequest, "RAW_REQUEST", Nothing, "NEW REQUEST")
        raw_Dgv_loader(dgvepoxy, "EPOXY_MAIN", Nothing, "NEW REQUEST")
        raw_Dgv_loader(dgvIdmReq, "INDIRECT MATERIAL", "req", "NEW REQUEST")
        raw_Dgv_loader(dgvIdmStock, "INDIRECT MATERIAL", "Stock", Nothing)
        raw_Dgv_loader(dgvGold, "AU_KITTING", "AU_KITTING", "VAULT")

        raw_dropdowns()

        With AutoRefresh
            .Interval = My.Settings.AutuRefresh * 60000
            .Start()
        End With

    End Sub

    Private Sub rawmainTAB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rawmainTAB.SelectedIndexChanged
        Select Case CInt(rawmainTAB.SelectedIndex)
            Case 0
                rawmatTABname.Text = "CAPS CONSUME"
            Case 1
                rawmatTABname.Text = "VCSEL WAFER"
            Case 2
                rawmatTABname.Text = "VALENCIA WAFER"
            Case 3
                rawmatTABname.Text = "EFUSE / INTERPOSER"
            Case 4
                rawmatTABname.Text = "BARE CAPS"
            Case 5
                rawmatTABname.Text = "GLASS CONSUME"
            Case 6
                rawmatTABname.Text = "RAW MATERIAL REQUEST"
            Case Else
                rawmatTABname.Text = Nothing
        End Select
    End Sub

    Private Sub RAW_Date_Filter(sender As Object, e As EventArgs) Handles ccdatef.SelectedIndexChanged, vcdatef.SelectedIndexChanged, vadatef.SelectedIndexChanged, indatef.SelectedIndexChanged, bcdatef.SelectedIndexChanged, e_datetype.SelectedIndexChanged, g_datetype.SelectedIndexChanged, gcdatef.SelectedIndexChanged, rwdatef.SelectedIndexChanged, idmr_datef.SelectedIndexChanged
        Dim panel() As Panel = {date0pnl, date1pnl, date2pnl, date3pnl, date4pnl, date7pnl, date8pnl, date5pnl, date9pnl, date6pnl}
        Dim cmb() As ComboBox = {ccdatef, vcdatef, vadatef, indatef, bcdatef, gcdatef, rwdatef, e_datetype, idmr_datef, g_datetype}
        Dim owner As ComboBox = DirectCast(sender, ComboBox)
        Dim i As Integer = Array.IndexOf(cmb, owner)

        If owner.Text = Nothing Then
            panel(i).Enabled = False
        Else
            panel(i).Enabled = True
        End If

    End Sub

    Private Sub Clear_Search_Filter(sender As Object, e As EventArgs) Handles ccclear.Click, vaclear.Click, vcclear.Click, inclear.Click, bcclear.Click, rwclear.Click, gcclear.Click, e_clear.Click
        'Dim callerName As String = CStr(DirectCast(sender, Button).Name)
        Dim callerID() As Button = {ccclear, vcclear, vaclear, inclear, bcclear, gcclear, rwclear, e_clear}
        Dim index As Integer = Array.IndexOf(callerID, sender)

        Select Case index
            Case 0
                ccpackage.Text = Nothing : ccbin.Text = Nothing
                cctape.Text = Nothing : cccap.Text = Nothing
                ccbatch.Text = Nothing : ccdatef.Text = Nothing
                ccn2.Text = Nothing
               ' ccsearch.PerformClick()
            Case 1
                vcpackage.Text = Nothing : vcbin.Text = Nothing
                vctapeid.Text = Nothing : vcmachine.Text = Nothing
                vcdatef.Text = Nothing
                'vcsearch.PerformClick()
            Case 2
                vapackage.Text = Nothing : vaslice.Text = Nothing
                vacontainer.Text = Nothing : vamatcode.Text = Nothing
                vadatef.Text = Nothing
                'vasearch.PerformClick()
            Case 3
                inlotno.Text = Nothing : inlotno.Text = Nothing
                inreel.Text = Nothing : inproduct.Text = Nothing
                indatef.Text = Nothing : inmatcode.Text = Nothing
                'insearch.PerformClick()
            Case 4
                bcpackage.Text = Nothing : bcmatcode.Text = Nothing
                bclotno.Text = Nothing : bcdatef.Text = Nothing
                'bcsearch.PerformClick()
            Case 5
                gcpackage.Text = Nothing : gcbin.Text = Nothing
                gcsite.Text = Nothing : gcn2.Text = Nothing
                gclotno.Text = Nothing : gcdatef.Text = Nothing
                'gcsearch.PerformClick()
            Case 6
                rwpackage.Text = Nothing : rwtype.Text = Nothing
                rwprocess.Text = Nothing : rwlotno.Text = Nothing
                rwmachine.Text = Nothing : rwdatef.Text = Nothing
               ' rwsearch.PerformClick()
            Case 7
                e_package.Text = Nothing : e_process.Text = Nothing
                e_batchno.Text = Nothing : e_machine.Text = Nothing
                e_datetype.Text = Nothing
                'e_search.PerformClick()
        End Select

    End Sub

    Private Sub limitRow_KeyPress(sender As Object, e As KeyPressEventArgs) Handles limitRow.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub RAW_Search_Count(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles dgvValencia.RowStateChanged, dgvbare.RowStateChanged, dgvConsume.RowStateChanged, dgvGlass.RowStateChanged, dgvSmt.RowStateChanged, dgvVcsel.RowStateChanged, dgvRawRequest.RowStateChanged
        rowCnt.Text = "Result found : " & sender.Rows.Count
        ActiveDGV = sender
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MsgBox("Extract data from : " & ActiveDGV.Name & vbNewLine & "Do you want to process?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            ExportToCSV(ActiveDGV)
        End If

    End Sub

    Private Sub RAW_Show_Menu(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvValencia.CellMouseClick, dgvbare.CellMouseClick, dgvConsume.CellMouseClick, dgvGlass.CellMouseClick, dgvSmt.CellMouseClick, dgvVcsel.CellMouseClick
        ActiveDGV = sender
        MouseRightClick(sender, e, sender, rawDgvMENU)

    End Sub

    Private Sub EPOXY_Search_Count(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles dgvepoxy.RowStateChanged
        e_rowCnt.Text = "Result found : " & sender.Rows.Count

    End Sub

    Private Sub ccsearch_Click(sender As Object, e As EventArgs) Handles ccsearch.Click
        raw_Dgv_loader(dgvConsume, "CAPS_GLASS", "CAP", Nothing)
    End Sub

    Private Sub ccstock_Click(sender As Object, e As EventArgs) Handles ccstock.Click
        raw_Dgv_loader(dgvConsume, "CAPS_GLASS", "CAP", "IN STOCK")
    End Sub

    Private Sub ccissued_Click(sender As Object, e As EventArgs) Handles ccissued.Click
        raw_Dgv_loader(dgvConsume, "CAPS_GLASS", "CAP", "NO STOCK")
    End Sub

    Private Sub cchold_Click(sender As Object, e As EventArgs) Handles cchold.Click
        raw_Dgv_loader(dgvConsume, "CAPS_GLASS", "CAP", "HOLD")
    End Sub
    Private Sub ccscrap_Click(sender As Object, e As EventArgs) Handles ccscrap.Click
        raw_Dgv_loader(dgvConsume, "CAPS_GLASS", "CAP", "STILL IN LINE")
    End Sub

    Private Sub vastock_Click(sender As Object, e As EventArgs) Handles vastock.Click
        raw_Dgv_loader(dgvConsume, "VALENCIA WAFER", Nothing, "IN STOCK")
    End Sub

    Private Sub vaissued_Click(sender As Object, e As EventArgs) Handles vaissued.Click
        raw_Dgv_loader(dgvConsume, "VALENCIA WAFER", Nothing, "NO STOCK")
    End Sub

    Private Sub vahold_Click(sender As Object, e As EventArgs) Handles vahold.Click
        raw_Dgv_loader(dgvConsume, "VALENCIA WAFER", Nothing, "HOLD")
    End Sub

    Private Sub vascrap_Click(sender As Object, e As EventArgs) Handles vascrap.Click
        raw_Dgv_loader(dgvConsume, "VALENCIA WAFER", Nothing, "SCRAPPED")
    End Sub

    Private Sub vasearch_Click(sender As Object, e As EventArgs) Handles vasearch.Click
        raw_Dgv_loader(dgvConsume, "VALENCIA WAFER", Nothing, Nothing)
    End Sub

    Private Sub vcstock_Click(sender As Object, e As EventArgs) Handles vcstock.Click
        raw_Dgv_loader(dgvConsume, "VCSEL WAFER", Nothing, "IN STOCK")
    End Sub

    Private Sub vcsissued_Click(sender As Object, e As EventArgs) Handles vcsissued.Click
        raw_Dgv_loader(dgvConsume, "VCSEL WAFER", Nothing, "NO STOCK")
    End Sub

    Private Sub vchold_Click(sender As Object, e As EventArgs) Handles vchold.Click
        raw_Dgv_loader(dgvConsume, "VCSEL WAFER", Nothing, "HOLD")
    End Sub

    Private Sub vcscrap_Click(sender As Object, e As EventArgs) Handles vcscrap.Click
        raw_Dgv_loader(dgvConsume, "VCSEL WAFER", Nothing, "SCRAPPED")
    End Sub

    Private Sub vcsearch_Click(sender As Object, e As EventArgs) Handles vcsearch.Click
        raw_Dgv_loader(dgvConsume, "VCSEL WAFER", Nothing, Nothing)
    End Sub

    Private Sub instock_Click(sender As Object, e As EventArgs) Handles instock.Click
        raw_Dgv_loader(dgvSmt, "REEL MATERIAL", "SMT", "IN STOCK")
    End Sub

    Private Sub inissued_Click(sender As Object, e As EventArgs) Handles inissued.Click
        raw_Dgv_loader(dgvSmt, "REEL MATERIAL", "SMT", "NO STOCK")
    End Sub

    Private Sub inhold_Click(sender As Object, e As EventArgs) Handles inhold.Click
        raw_Dgv_loader(dgvSmt, "REEL MATERIAL", "SMT", "HOLD")
    End Sub

    Private Sub inscrap_Click(sender As Object, e As EventArgs) Handles inscrap.Click
        raw_Dgv_loader(dgvSmt, "REEL MATERIAL", "SMT", "SCRAPPED")
    End Sub

    Private Sub insearch_Click(sender As Object, e As EventArgs) Handles insearch.Click
        raw_Dgv_loader(dgvSmt, "REEL MATERIAL", "SMT", Nothing)
    End Sub

    Private Sub bcstock_Click(sender As Object, e As EventArgs) Handles bcstock.Click
        raw_Dgv_loader(dgvbare, "REEL MATERIAL", "CAP", "IN STOCK")
    End Sub

    Private Sub bcissued_Click(sender As Object, e As EventArgs) Handles bcissued.Click
        raw_Dgv_loader(dgvbare, "REEL MATERIAL", "CAP", "NO STOCK")
    End Sub

    Private Sub bchold_Click(sender As Object, e As EventArgs) Handles bchold.Click
        raw_Dgv_loader(dgvbare, "REEL MATERIAL", "CAP", "HOLD")
    End Sub

    Private Sub bcscrap_Click(sender As Object, e As EventArgs) Handles bcscrap.Click
        raw_Dgv_loader(dgvbare, "REEL MATERIAL", "CAP", "SCRAPPED")
    End Sub

    Private Sub bcsearch_Click(sender As Object, e As EventArgs) Handles bcsearch.Click
        raw_Dgv_loader(dgvbare, "REEL MATERIAL", "CAP", Nothing)
    End Sub

    Private Sub gcsearch_Click(sender As Object, e As EventArgs) Handles gcsearch.Click
        raw_Dgv_loader(dgvGlass, "CAPS_GLASS", "GLASS", Nothing)
    End Sub

    Private Sub gcstock_Click(sender As Object, e As EventArgs) Handles gcstock.Click
        raw_Dgv_loader(dgvGlass, "CAPS_GLASS", "GLASS", "IN STOCK")
    End Sub

    Private Sub gcissued_Click(sender As Object, e As EventArgs) Handles gcissued.Click
        raw_Dgv_loader(dgvGlass, "CAPS_GLASS", "GLASS", "NO STOCK")
    End Sub

    Private Sub gchold_Click(sender As Object, e As EventArgs) Handles gchold.Click
        raw_Dgv_loader(dgvGlass, "CAPS_GLASS", "GLASS", "HOLD")
    End Sub

    Private Sub gcscrap_Click(sender As Object, e As EventArgs) Handles gcscrap.Click
        raw_Dgv_loader(dgvGlass, "CAPS_GLASS", "GLASS", "SCRAPPED")
    End Sub

    Private Sub re_new_Click(sender As Object, e As EventArgs) Handles rw_new.Click
        raw_Dgv_loader(dgvRawRequest, "RAW_REQUEST", Nothing, "NEW MATERIAL REQUEST")
    End Sub

    Private Sub rw_avail_Click(sender As Object, e As EventArgs) Handles rw_avail.Click
        raw_Dgv_loader(dgvRawRequest, "RAW_REQUEST", Nothing, "AVAILABLE")
    End Sub

    Private Sub rw_pending_Click(sender As Object, e As EventArgs) Handles rw_pending.Click
        raw_Dgv_loader(dgvRawRequest, "RAW_REQUEST", Nothing, "PENDING")
    End Sub

    Private Sub rw_with_Click(sender As Object, e As EventArgs) Handles rw_with.Click
        raw_Dgv_loader(dgvRawRequest, "RAW_REQUEST", Nothing, "WITHDRAWN")
    End Sub

    Private Sub rw_close_Click(sender As Object, e As EventArgs) Handles rw_close.Click
        raw_Dgv_loader(dgvRawRequest, "RAW_REQUEST", Nothing, "RECEIVED")
    End Sub

    Private Sub rwsearch_Click(sender As Object, e As EventArgs) Handles rwsearch.Click
        raw_Dgv_loader(dgvRawRequest, "RAW_REQUEST", Nothing, Nothing)
    End Sub

    Private Sub e_new_Click(sender As Object, e As EventArgs) Handles e_new.Click
        raw_Dgv_loader(dgvepoxy, "EPOXY_MAIN", Nothing, "NEW MATERIAL REQUEST")
    End Sub

    Private Sub e_thaw_Click(sender As Object, e As EventArgs) Handles e_thaw.Click
        raw_Dgv_loader(dgvepoxy, "EPOXY_MAIN", Nothing, "THAWING")
    End Sub

    Private Sub e_avail_Click(sender As Object, e As EventArgs) Handles e_avail.Click
        raw_Dgv_loader(dgvepoxy, "EPOXY_MAIN", Nothing, "AVAILABLE")
    End Sub

    Private Sub e_return_Click(sender As Object, e As EventArgs) Handles e_return.Click
        raw_Dgv_loader(dgvepoxy, "EPOXY_MAIN", Nothing, "FOR RETURN")
    End Sub

    Private Sub e_pending_Click(sender As Object, e As EventArgs) Handles e_pending.Click
        raw_Dgv_loader(dgvepoxy, "EPOXY_MAIN", Nothing, "PENDING")
    End Sub

    Private Sub e_received_Click(sender As Object, e As EventArgs) Handles e_received.Click
        raw_Dgv_loader(dgvepoxy, "EPOXY_MAIN", Nothing, "RECEIVED")
    End Sub

    Private Sub e_close_Click(sender As Object, e As EventArgs) Handles e_close.Click
        raw_Dgv_loader(dgvepoxy, "EPOXY_MAIN", Nothing, "CLOSED")
    End Sub

    Private Sub e_unused_Click(sender As Object, e As EventArgs) Handles e_unused.Click
        raw_Dgv_loader(dgvepoxy, "EPOXY_MAIN", Nothing, "UNUSED")
    End Sub

    Private Sub e_search_Click(sender As Object, e As EventArgs) Handles e_search.Click
        raw_Dgv_loader(dgvepoxy, "EPOXY_MAIN", Nothing, Nothing)
    End Sub

    Private Sub dgvRawRequest_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRawRequest.CellDoubleClick
        Dim xrow As DataGridViewRow = dgvRawRequest.SelectedRows(0)
        Dim Id As String = xrow.Cells("ID").Value.ToString
        RawTransaction.Close()

        With RawTransaction
            .TopMost = True
            .TopMost = False
            .UID = Id
            .Show()
        End With
    End Sub

    Private Sub dgvepoxy_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvepoxy.CellDoubleClick
        Dim xrow As DataGridViewRow = dgvepoxy.SelectedRows(0)
        Dim reqID As String = xrow.Cells("ID").Value.ToString
        Epoxy_Transaction.Close()
        With Epoxy_Transaction
            .UID = reqID
            .TopMost = True
            .TopMost = False
            .Show()
        End With

    End Sub

    Private Sub Main_Request_Indicator(sender As Object, e As EventArgs) Handles idm_int.Click, dm_int.Click, epoxy_int.Click, gold_int.Click
        Dim ctrl() As Control = {idm_int, dm_int, epoxy_int, gold_int}
        Dim id As Integer = Array.IndexOf(ctrl, sender)

        Select Case id
            Case 0
                MainTABCtrl.SelectedIndex = 0
                idmTABmain.SelectedIndex = 1
                idm_new.PerformClick()
            Case 1
                MainTABCtrl.SelectedIndex = 1
                rawmainTAB.SelectedIndex = 6
                rw_new.PerformClick()
            Case 2
                MainTABCtrl.SelectedIndex = 2
                e_new.PerformClick()
            Case 3
                MainTABCtrl.SelectedIndex = 3
                g_new.PerformClick()
        End Select

    End Sub

    Private Sub idm_search_Click(sender As Object, e As EventArgs) Handles idm_search.Click
        raw_Dgv_loader(dgvIdmStock, "INDIRECT MATERIAL", "Stock", Nothing)
    End Sub

    Private Sub idmr_search_Click(sender As Object, e As EventArgs) Handles idmr_search.Click
        raw_Dgv_loader(dgvIdmReq, "INDIRECT MATERIAL", "req", Nothing)
    End Sub

    Private Sub idm_new_Click(sender As Object, e As EventArgs) Handles idm_new.Click
        raw_Dgv_loader(dgvIdmReq, "INDIRECT MATERIAL", "req", "NEW REQUEST")
    End Sub

    Private Sub idm_avail_Click(sender As Object, e As EventArgs) Handles idm_avail.Click
        raw_Dgv_loader(dgvIdmReq, "INDIRECT MATERIAL", "req", "AVAILABLE")
    End Sub

    Private Sub idm_withdrawn_Click(sender As Object, e As EventArgs) Handles idm_withdrawn.Click
        raw_Dgv_loader(dgvIdmReq, "INDIRECT MATERIAL", "req", "WITHDRAWN")
    End Sub

    Private Sub idm_clear_Click(sender As Object, e As EventArgs) Handles idm_clear.Click
        idm_type.Text = Nothing : idm_matcode.Text = Nothing : idm_description.Text = Nothing
        idm_search.PerformClick()
    End Sub

    Private Sub idmr_clear_Click(sender As Object, e As EventArgs) Handles idmr_clear.Click
        idmr_type.Text = Nothing : idmr_mc.Text = Nothing : idmr_matcode.Text = Nothing : idmr_datef.Text = Nothing
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Main_Kitting_Load(sender, e)
        Main_Kitting_Activated(sender, e)
        Me.Refresh()
    End Sub

    Private Sub dgvIdmReq_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvIdmReq.CellDoubleClick
        Dim row As DataGridViewRow = dgvIdmReq.SelectedRows(0)
        Dim status As String = row.Cells("Status").Value.ToString

        With IDM_Req
            Select Case status
                Case "NEW REQUEST"
                    .IDMID = "ISSUE"
                    .reqpnl.Enabled = False
                    .kitterpnl.Visible = True
                    .Show()

                Case "AVAILABLE"
                    .IDMID = "WITHDRAWN"
                    .reqpnl.Enabled = False
                    .kitterpnl.Visible = True
                    .Show()
            End Select
        End With
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        NewEndorseRaw.Close()
        NewEndorseRaw.tb.SelectedIndex = 0
        NewEndorseRaw.Show()
        NewEndorseRaw.TopMost = True : NewEndorseRaw.TopMost = False
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        RawUpload.Close()
        RawUpload.Show()
        RawUpload.TopMost = True : RawUpload.TopMost = False
    End Sub

    Private Sub LinkLabel1_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Main_Kitting_Load(sender, e)
        Main_Kitting_Activated(sender, e)
        Me.Refresh()
    End Sub

    Public xtype As String = Nothing

    Private Sub dgvepoxy_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvepoxy.CellMouseClick
        xtype = Nothing
        xtype = "EPOXY"
        MouseRightClick(sender, e, dgvepoxy, epoxyDgvMENU)
    End Sub

    Private Sub dgvdm_request(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvRawRequest.CellMouseClick
        xtype = Nothing
        xtype = "RAW"
        MouseRightClick(sender, e, dgvRawRequest, epoxyDgvMENU)
    End Sub

    Private Sub dgvIdmReq_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvIdmReq.CellMouseClick
        xtype = Nothing
        xtype = "IDM"
        Try
            If dgvIdmReq.SelectedRows(0).Cells("Status").Value.ToString = "WITHDRAWN" Then Exit Sub
            MouseRightClick(sender, e, dgvIdmReq, epoxyDgvMENU)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DELETEToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DELETEToolStripMenuItem1.Click
        Dim INPUT As String = InputBox("Please Input Passcode!", "DELETE REQUEST")
        Dim XROW As DataGridViewRow
        Dim COLLECT As String = Nothing

        Select Case xtype
            Case "EPOXY"
                XROW = dgvepoxy.SelectedRows(0)
                COLLECT = "DM_Request"
            Case "RAW"
                XROW = dgvRawRequest.SelectedRows(0)
                COLLECT = "DM_Request"
            Case "IDM"
                XROW = dgvIdmReq.SelectedRows(0)
                COLLECT = "IDM_Request"
        End Select

        Dim ID As String = XROW.Cells("ID").Value.ToString

        If INPUT = "123" Then
            EXEC_QRY("@@MethodType = 'DELETE',@CollectType = '" + COLLECT + "',@ID = '" + ID + "'", Nothing)
            MsgBox("ITEM DELETED!")

        Else
            MsgBox("Wrong Passcode!")
        End If
    End Sub

    Private Sub TRANSACTIONHISTORYToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TRANSACTIONHISTORYToolStripMenuItem.Click
        Dim column As String = Nothing
        Dim matID As String
        Dim xrow As DataGridViewRow = ActiveDGV.SelectedRows(0)
        Try
            Select Case ActiveDGV.Name
                Case "dgvValencia"
                    column = "RW_TAPE_ID"
                    matID = "RW_TAPE_ID"
                Case "dgvbare"
                    column = "LOT_ID"
                    matID = "LOT_ID"
                Case "dgvConsume"
                    column = "MATERIAL_LOT_ID"
                    matID = "MATERIAL_LOT_ID"
                Case "dgvGlass"
                    column = "MATERIAL_LOT_ID"
                    matID = "MATERIAL_LOT_ID"
                Case "dgvSmt"
                    column = "LOT_ID"
                    matID = "REEL_NUMBER"
                Case "dgvVcsel"
                    column = "TAPE_ID"
                    matID = "TAPE_ID"
            End Select

            With TransactionHistory
                .materialid.Text = xrow.Cells(matID).Value.ToString
                .HistoryID = xrow.Cells(column).Value.ToString
                .ShowDialog()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        Dim column As String = Nothing
        Dim matID As String = Nothing
        Dim type As String = Nothing
        Dim xrow As DataGridViewRow = ActiveDGV.SelectedRows(0)

        Try
            Select Case ActiveDGV.Name
                Case "dgvValencia"
                    column = "RW_TAPE_ID"
                    matID = "RW_TAPE_ID"
                    type = "VALENCIA WAFER"
                Case "dgvbare"
                    column = "LOT_ID"
                    matID = "LOT_ID"
                    type = "BARE CAPS"
                Case "dgvConsume"
                    column = "MATERIAL_LOT_ID"
                    matID = "MATERIAL_LOT_ID"
                    type = "CAP CONSUME"
                Case "dgvGlass"
                    column = "MATERIAL_LOT_ID"
                    matID = "MATERIAL_LOT_ID"
                    type = "GLASS_CONSUME"
                Case "dgvSmt"
                    type = "SMT"
                    column = "LOT_ID"
                    matID = "REEL_NUMBER"
                Case "dgvVcsel"
                    type = "VCSEL WAFER"
                    column = "TAPE_ID"
                    matID = "TAPE_ID"
            End Select

            With UpdateRAW
                .MainID = xrow.Cells(matID).Value.ToString
                .materialid.Text = xrow.Cells(column).Value.ToString
                .materialtype.Text = type
                .ShowDialog()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim column As String = Nothing
        Dim matID As String = Nothing
        Dim type As String = Nothing
        Dim xrow As DataGridViewRow = ActiveDGV.SelectedRows(0)

        Try
            Select Case ActiveDGV.Name
                Case "dgvValencia"
                    column = "RW_TAPE_ID"
                    matID = "RW_TAPE_ID"
                    type = "VALENCIA WAFER"
                Case "dgvbare"
                    column = "LOT_ID"
                    matID = "LOT_ID"
                    type = "BARE CAPS"
                Case "dgvConsume"
                    column = "MATERIAL_LOT_ID"
                    matID = "MATERIAL_LOT_ID"
                    type = "CAP CONSUME"
                Case "dgvGlass"
                    column = "MATERIAL_LOT_ID"
                    matID = "MATERIAL_LOT_ID"
                    type = "GLASS_CONSUME"
                Case "dgvSmt"
                    type = "SMT"
                    column = "LOT_ID"
                    matID = "REEL_NUMBER"
                Case "dgvVcsel"
                    type = "VCSEL WAFER"
                    column = "TAPE_ID"
                    matID = "TAPE_ID"
            End Select

            If MsgBox("Are you sure you want to delete this item?" & vbNewLine & "Lot No: " & xrow.Cells(column).Value.ToString, vbYesNo, "DELETE DATA") = MsgBoxResult.Yes Then

                Dim Input As String = InputBox("Please Enter passcode!", "Confirmation!")

                If Input = "123" Then
                    EXEC_QRY("@@MethodType = 'DELETE',@CollectType = 'RAW_DATA',@RefID = '" + type + "', @Lotno = '" + xrow.Cells(column).Value.ToString + "'", Nothing)

                    MsgBox("Item Deleted!")
                Else
                    MsgBox("Passcode Incorrect!")
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub vctapeid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles vctapeid.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            vcsearch.PerformClick()
        End If
    End Sub

    Private Sub ccbatch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ccbatch.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            ccsearch.PerformClick()
        End If
    End Sub

    Private Sub vacontainer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles vacontainer.KeyPress, vaslice.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            vasearch.PerformClick()
        End If

    End Sub

    Private Sub inlotno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles inlotno.KeyPress, inreel.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            insearch.PerformClick()
        End If
    End Sub

    Private Sub bclotno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles bclotno.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            bcsearch.PerformClick()
        End If
    End Sub

    Private Sub idmcsv_Click(sender As Object, e As EventArgs) Handles idmcsv.Click
        ExportToCSV(dgvIdmReq)
        'xportEXCEL(dgvIdmReq)
    End Sub

    Private Sub epoxycsv_Click(sender As Object, e As EventArgs) Handles epoxycsv.Click
        ExportToCSV(dgvepoxy)
        'ExportEXCEL(dgvepoxy)
    End Sub

    Private Sub g_csv_Click(sender As Object, e As EventArgs) Handles g_csv.Click
        ExportToCSV(dgvGold)
    End Sub

    Private Sub g_insert_Click(sender As Object, e As EventArgs) Handles g_insert.Click
        AU_Insert.Close()
        With AU_Insert
            .Clk = "DIRECT"
            .TopMost = True
            .TopMost = False
            .Show()
        End With
    End Sub

    Private Sub g_new_Click(sender As Object, e As EventArgs) Handles g_new.Click
        raw_Dgv_loader(dgvGold, "AU_KITTING", "AU_PRODUCTION", "NEW REQUEST")
    End Sub

    Private Sub g_avail_Click(sender As Object, e As EventArgs) Handles g_avail.Click
        raw_Dgv_loader(dgvGold, "AU_KITTING", "AU_PRODUCTION", "AVAILABLE")
    End Sub

    Private Sub g_return_Click(sender As Object, e As EventArgs) Handles g_return.Click
        raw_Dgv_loader(dgvGold, "AU_KITTING", "AU_PRODUCTION", "RETURN")
    End Sub

    Private Sub g_online_Click(sender As Object, e As EventArgs) Handles g_online.Click
        raw_Dgv_loader(dgvGold, "AU_KITTING", "AU_PRODUCTION", "ON-LINE")
    End Sub

    Private Sub g_vault_Click(sender As Object, e As EventArgs) Handles g_vault.Click
        raw_Dgv_loader(dgvGold, "AU_KITTING", "AU_KITTING", "VAULT")
    End Sub

    Private Sub g_empty_Click(sender As Object, e As EventArgs) Handles g_empty.Click
        raw_Dgv_loader(dgvGold, "AU_KITTING", "AU_KITTING", "EMPTY")
    End Sub

    Private Sub g_dispo_Click(sender As Object, e As EventArgs) Handles g_dispo.Click
        raw_Dgv_loader(dgvGold, "AU_KITTING", "AU_KITTING", "FOR DISPO")
    End Sub

    Private Sub g_scrap_Click(sender As Object, e As EventArgs) Handles g_scrap.Click
        raw_Dgv_loader(dgvGold, "AU_KITTING", "AU_KITTING", "SCRAP")
    End Sub

    Private Sub g_eret_Click(sender As Object, e As EventArgs) Handles g_eret.Click
        raw_Dgv_loader(dgvGold, "AU_KITTING", "AU_KITTING", "ERET")
    End Sub

    Private Sub g_search_Click(sender As Object, e As EventArgs) Handles g_search.Click
        raw_Dgv_loader(dgvGold, "AU_KITTING", "AU_KITTING", Nothing)
    End Sub

    Private Sub g_clear_Click(sender As Object, e As EventArgs) Handles g_clear.Click
        Dim tb() As Control = {g_package, g_matcode, g_spool, g_slip, g_reserve, g_datetype}
        For Each text As Control In tb
            text.Text = Nothing
        Next
    End Sub

    Private Sub dgvGold_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGold.CellDoubleClick
        Try
            Dim status As String = dgvGold.SelectedRows(0).Cells("STATUS").Value.ToString
            Select Case status
                Case "NEW REQUEST", "AVAILABLE", "RETURN", "ON-LINE"
                    Au_Transaction.Close()
                    With Au_Transaction
                        .TopMost = True
                        .TopMost = False
                        .Show()
                    End With

                Case Else
                    AU_Insert.Close()
                    With AU_Insert
                        .TopMost = True
                        .TopMost = False
                        .Clk = Nothing
                        .Show()
                    End With
            End Select

        Catch ex As Exception

        End Try

    End Sub

    Private Sub AutoRefresh_Tick(sender As Object, e As EventArgs) Handles AutoRefresh.Tick
        INV_RUN(1)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AU_ReturnAll.Close()
        With AU_ReturnAll
            .TopMost = True
            .TopMost = False
            .Show()
        End With
    End Sub

    Private Sub ViewTransactionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewTransactionToolStripMenuItem.Click
        Dim spool As String = Nothing
        If dgvGold.SelectedRows(0).Cells("STATUS").Value.ToString() = "NEW REQUEST" Then Exit Sub
        Try
            spool = dgvGold.SelectedRows(0).Cells("SPOOL NO").Value.ToString
        Catch
            spool = dgvGold.SelectedRows(0).Cells("SPOLL_NO.").Value.ToString
        End Try
        With Gold_Trans
            .SpoolNo.Text = spool
            .ShowDialog()
        End With
    End Sub

    Private Sub dgvGold_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvGold.CellMouseClick

        MouseRightClick(sender, e, dgvGold, goldDgvMENU)
    End Sub

    Private Sub DeleteToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem2.Click
        Dim spool As String = Nothing
        Dim col As String = Nothing
        Select Case dgvGold.SelectedRows(0).Cells("STATUS").Value.ToString()
            Case "AVAILABLE", "RETURN", "ON-LINE"
                col = "SPOOL NO"
                spool = dgvGold.SelectedRows(0).Cells(col).Value.ToString
            Case "NEW REQUEST"
                spool = Nothing
            Case Else
                col = "SPOLL_NO."
                spool = dgvGold.SelectedRows(0).Cells(col).Value.ToString
        End Select

        If MsgBox("Proceed to delete Spool : " & spool & " ?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        Dim code As String = InputBox("Please Input Access Code!", "DELETE GOLDWIRE")

        If code <> spool Then MsgBox("Invalid Code!") : Exit Sub

        Try
            Select Case dgvGold.SelectedRows(0).Cells("STATUS").Value.ToString()
                Case "NEW REQUEST", "AVAILABLE"
                    EXEC_QRY("@@MethodType = 'AU_TRANSACTION',@CollectType = 'AU DELETE',@ID = '" + dgvGold.SelectedRows(0).Cells("UID").Value.ToString.Trim + "',@RefID = 'PROD'", Nothing)
                Case "ON-LINE", "RETURN"
                    Exit Sub
                Case Else
                    EXEC_QRY("@@MethodType = 'AU_TRANSACTION',@CollectType = 'AU DELETE',@ID = '" + dgvGold.SelectedRows(0).Cells("UID").Value.ToString.Trim + "',@RefID = 'RAW'", Nothing)
            End Select
            MsgBox(spool & " is deleted Successfully!")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
End Class
