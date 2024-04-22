Imports System.IO

Public Class Gold_Request

    Sub dgv_loader(Status As String, dgv As DataGridView)
        Try
            Load_data_from_db("@@MethodType = 'AU_LOAD',@CollectType = 'AU_PRODUCTION',@limitrow = '" + g_limitrow.Text.Trim + "',@Status = '" + Status + "',@Package = '" + g_package.Text + "',@Machine = '" + g_machine.Text + "',@SpoolNo = '" + g_spool.Text + "',@date_Filter = '" + g_dateF.Text + "',@Dfrom = '" + fr_g.Text + "',@Dto = '" + to_g.Text + "'", dgv, "GOLD", Nothing, Nothing, Nothing)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        dgv.ClearSelection()
    End Sub

    Sub inventory_count()
        EXEC_QRY("@@MethodType = 'INV_RAW',@CollectType = 'GOLDWIRE'", Nothing)
        Dim Btn() As Control = {g_online, g_new, g_avail, g_return}
        Dim col() As String = {"ON-LINE", "NEW", "AVAIL", "RETURN"}
        For i As Integer = 0 To col.Length - 1
            Btn(i).Text = ds.Tables(0).Rows(0)(col(i)).ToString
        Next
    End Sub

    Sub dropdown()
        Dim cb() As ComboBox = {g_package, g_machine}
        Dim col() As String = {"PACKAGE", "MACHINE NO"}

        For i As Integer = 0 To cb.Length - 1
            COMBOBOX("@@MethodType = 'RAW_DROPDOWNS',@Type = 'GOLD_TRAN',@columnName = '" + col(i) + "'", col(i), cb(i))
        Next
    End Sub

    Private Sub Gold_Request_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv_loader("ON-LINE", dgvGold)
        dropdown()
        AuNotifier.Path = My.Settings.System_Notifier
        With AutoRefresh
            .Interval = My.Settings.AutuRefresh * 60000
            .Start()
        End With
    End Sub

    Private Sub g_online_Click(sender As Object, e As EventArgs) Handles g_online.Click
        dgv_loader("ON-LINE", dgvGold)
    End Sub

    Private Sub g_new_Click(sender As Object, e As EventArgs) Handles g_new.Click
        dgv_loader("NEW REQUEST", dgvGold)
    End Sub

    Private Sub g_avail_Click(sender As Object, e As EventArgs) Handles g_avail.Click
        dgv_loader("AVAILABLE", dgvGold)
    End Sub

    Private Sub g_return_Click(sender As Object, e As EventArgs) Handles g_return.Click
        dgv_loader("RETURN", dgvGold)
    End Sub

    Private Sub g_dateF_SelectedIndexChanged(sender As Object, e As EventArgs) Handles g_dateF.SelectedIndexChanged
        If g_dateF.Text = Nothing Then
            date0pnl.Enabled = False
        Else
            date0pnl.Enabled = True
        End If
    End Sub

    Private Sub g_clear_Click(sender As Object, e As EventArgs) Handles g_clear.Click
        g_package.Text = Nothing : g_machine.Text = Nothing : g_spool.Text = Nothing : g_dateF.Text = Nothing

    End Sub

    Private Sub g_search_Click(sender As Object, e As EventArgs) Handles g_search.Click
        Dim status As String = Nothing
        If RET.Checked = True Then
            status = "on"
        End If
        dgv_loader(status, dgvGold)
    End Sub

    Private Sub Gold_Request_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        inventory_count()
    End Sub

    Private Sub g_package_SelectedIndexChanged(sender As Object, e As EventArgs) Handles g_package.SelectionChangeCommitted, g_machine.SelectionChangeCommitted
        g_search.PerformClick()
    End Sub

    Private Sub g_spool_KeyPress(sender As Object, e As KeyPressEventArgs) Handles g_spool.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            g_search.PerformClick()
        End If
    End Sub

    Private Sub newREQ_Click(sender As Object, e As EventArgs) Handles newREQ.Click
        With Gold_SendReq
            .UID.Text = Nothing
            .ShowDialog()
        End With
    End Sub

    Private Sub returnBtn_Click(sender As Object, e As EventArgs) Handles returnBtn.Click
        With Gold_Return
            .actionType = Nothing
            .UID.Text = Nothing
            .g_spool.Text = Nothing
            .ShowDialog()
        End With
    End Sub

    Private Sub dgvGold_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGold.CellDoubleClick
        Dim Status As String = dgvGold.SelectedRows(0).Cells("STATUS").Value.ToString
        Dim Id As String = dgvGold.SelectedRows(0).Cells("UID").Value.ToString

        If Status = "AVAILABLE" Then Exit Sub

        If Status <> "NEW REQUEST" Then
            Dim Spool As String = dgvGold.SelectedRows(0).Cells("SPOOL NO").Value.ToString
            With Gold_Return
                .actionType = "DIRECT"
                .UID.Text = Id
                .STAT = Status
                .g_spool.Text = Spool
                .ShowDialog()
            End With
        Else
            With Gold_SendReq
                .UID.Text = dgvGold.SelectedRows(0).Cells("UID").Value.ToString
                .ShowDialog()
            End With
        End If

    End Sub

    Private Sub dgvGold_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvGold.CellMouseClick
        Try
            Dim Status As String = dgvGold.SelectedRows(0).Cells("STATUS").Value.ToString
            If Status = "NEW REQUEST" Then Exit Sub
            MouseRightClick(sender, e, dgvGold, auMENU)
        Catch
        End Try
    End Sub

    Private Sub ViewTransactionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewTransactionToolStripMenuItem.Click
        With Gold_Trans
            .SpoolNo.Text = dgvGold.SelectedRows(0).Cells("SPOOL NO").Value.ToString
            .ShowDialog()
        End With
    End Sub

    Private Sub RETURNToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RETURNToolStripMenuItem.Click
        Dim Id As String = dgvGold.SelectedRows(0).Cells("UID").Value.ToString
        Dim Spool As String = dgvGold.SelectedRows(0).Cells("SPOOL NO").Value.ToString
        Dim Status As String = dgvGold.SelectedRows(0).Cells("STATUS").Value.ToString

        If Status <> "NEW REQUEST" Then
            With Gold_Return
                .actionType = "DIRECT"
                .UID.Text = Id
                .g_spool.Text = Spool
                .ShowDialog()
            End With
        Else
            With Gold_SendReq
                .UID.Text = dgvGold.SelectedRows(0).Cells("UID").Value.ToString
                .ShowDialog()
            End With
        End If
    End Sub

    Private Sub _refresh_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles _refresh.LinkClicked
        dgv_loader("ON-LINE", dgvGold)
        inventory_count()
    End Sub

    Private Sub dgvGold_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles dgvGold.RowStateChanged
        ROWcount.Text = dgvGold.Rows.Count
    End Sub

    Private Sub ManualPDF_Click_1(sender As Object, e As EventArgs) Handles ManualPDF.Click
        Process.Start(My.Settings.Manual)
    End Sub

    Private Sub AuNotifier_Created(sender As Object, e As FileSystemEventArgs) Handles AuNotifier.Created
        Dim IDS As String = Path.GetFileNameWithoutExtension(e.FullPath)

        If IDS.Contains("GOLDWIRE") And IDS.Contains("AVAIALBLE") Then
            Dim part() As String = IDS.Split("-")
            Dim title As String = part(0)
            Dim type As String = part(1)
            Dim msg As String = part(2)

            inventory_count()

            My.Computer.Audio.Play(My.Resources.combo_low, AudioPlayMode.Background)
            AuAlert.BalloonTipIcon = ToolTipIcon.Info
            AuAlert.BalloonTipText = type & vbNewLine & msg
            AuAlert.BalloonTipTitle = title
            AuAlert.ShowBalloonTip(5000)

            Me.TopMost = True : Me.TopMost = False
            Xfile.Start()

        End If
    End Sub

    Private Sub Xfile_Tick(sender As Object, e As EventArgs) Handles Xfile.Tick
        Xfile.Stop()
        Get_Network_Access()
        DEL_file(My.Settings.System_Notifier, "txt")
    End Sub

    Private Sub AutoRefresh_Tick(sender As Object, e As EventArgs) Handles AutoRefresh.Tick
        inventory_count()
    End Sub
End Class