Public Class Gold_Return
    Public actionType As String = Nothing
    Public prevLot As String = Nothing
    Public prevPro As String = Nothing
    Public prevMC As String = Nothing
    Public STAT As String = Nothing
    Sub Load_Data(collect As String, ID As String)
        Dim fields As Control() = {g_status, g_spool, g_package, g_machine, g_reqby, g_lotno, g_consume, g_remarks, g_reason, g_length}
        Dim col() As String = {"STATUS", "SPOOL NO", "PACKAGE", "MACHINE NO", "REQUESTED_BY", "LOT ID", "TOTAL_CONSUMPTION", "REMARKS", "REASON", "CURRENT LENGTH"}

        EXEC_QRY("@@MethodType = 'GET_AU_DATA',@CollectType = '" + collect + "',@ID = '" + ID + "'", Nothing)

        If ds.Tables(0).Rows.Count = 0 Then MsgBox("No Result Found!") : Exit Sub
        g_send.Enabled = True
        For i As Integer = 0 To fields.Length - 1
            fields(i).Text = ds.Tables(0).Rows(0)(col(i)).ToString.Trim
            If fields(i).Text <> "" Then
                fields(i).Enabled = False
            Else
                fields(i).Enabled = True
            End If
        Next
        g_length.Enabled = False
        g_status.Enabled = True
    End Sub
    Sub clearAll()
        Dim fields As Control() = {g_status, g_package, g_machine, g_reqby, g_lotno, g_consume, g_remarks, g_reason, g_length}
        For i As Integer = 0 To fields.Length - 1
            fields(i).Text = Nothing
            fields(i).Enabled = False
        Next
        g_spool.Enabled = True : g_spool.Text = Nothing
        g_spool.Select()
    End Sub

    Sub savedata()
        prevLot = g_lotno.Text.Trim
        prevPro = g_package.Text.Trim
        prevMC = g_machine.Text.Trim
    End Sub

    Private Function Check_fields() As Boolean
        Dim tb() As Control = {g_spool, g_package, g_machine, g_reqby, g_lotno, g_remarks, g_consume, g_reason}
        Dim x As Integer = 0
        For i As Integer = 0 To tb.Length - 1
            If tb(i).Text.Trim = "" Or tb(i).Text.Trim = Nothing Then
                x += 1
            End If
        Next
        If x > 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Sub ctrl()
        Select Case g_status.Text
            Case "AVAILABLE"
                g_send.Enabled = False

            Case "ON-LINE"
                With g_send
                    .Text = "RETURN"
                    .BackColor = Color.Orange
                    .ForeColor = Color.Black
                    .Enabled = True
                End With
                g_send.Enabled = True
            Case "FOR RETURN"
                g_send.Enabled = False

            Case "NEW REQUEST"
                With g_send
                    .Enabled = True
                    .BackColor = Color.Red
                    .ForeColor = Color.White
                    .Text = "FOLLOW UP"
                End With

            Case Else
                g_send.Enabled = False
        End Select
    End Sub

    Private Sub Gold_Return_Load(sender As Object, e As EventArgs) Handles Me.Load
        g_length.Text = Nothing

        If STAT <> "RETURN" Then
            With Login
                .AccessID.Text = "OPERATOR"
                .form = Me
                .ShowDialog()
            End With
        End If

        clearAll()
        If actionType = "DIRECT" Then
            Load_Data("AU_ID", UID.Text.Trim)
            'get the Remaining length
            EXEC_QRY("@@MethodType = 'GET_AU_DATA',@CollectType = 'AU_isExist',@ID = '" + g_spool.Text.Trim + "'", Nothing) : g_length.Text = ds.Tables(0).Rows(0)("CURRENT LENGTH").ToString
            changeSpool.Visible = False
        Else
            clearAll()
            changeSpool.Visible = True
        End If
        savedata()

        ctrl()

    End Sub

    Private Sub g_spool_KeyPress(sender As Object, e As KeyPressEventArgs) Handles g_spool.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Load_Data("AU_SPOOL", g_spool.Text.Trim)
            If ds.Tables(0).Rows.Count <> 0 Then
                savedata()
            Else
                g_spool.Text = Nothing
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles changeSpool.Click
        clearAll()
    End Sub

    Private Sub g_remarks_SelectedIndexChanged(sender As Object, e As EventArgs) Handles g_remarks.SelectedIndexChanged

        Dim cb As Control() = {g_machine, g_package, g_lotno}
        Dim data As String() = {prevMC, prevPro, prevLot}

        If g_remarks.Text = Nothing Then Exit Sub

        If g_remarks.Text = "TRANSFER SPOOL" Then
            COMBOBOX("@@MethodType = 'RAW_DROPDOWNS',@Type = 'GOLD_TRAN',@columnName = 'PACKAGE'", "PACKAGE", g_package) : COMBOBOX("@@MethodType = 'RAW_DROPDOWNS',@Type = 'GOLD_TRAN',@columnName = 'MACHINE NO'", "MACHINE NO", g_machine)
            For Each i As Control In cb
                i.Enabled = True
                i.Text = Nothing
            Next
            g_lotno.Text = Nothing
        Else
            For i As Integer = 0 To cb.Length - 1
                cb(i).Text = data(i)
                cb(i).Enabled = False
            Next
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub g_send_Click(sender As Object, e As EventArgs) Handles g_send.Click
        If Check_fields() = False Then MsgBox("Incomplete Fields!") : Exit Sub
        Dim msg As String = Nothing
        Try
            Select Case g_remarks.Text
                Case "CONSUMED", "SCRAP", "OFF-LINE"
                    If MsgBox("Please Confirm!" & vbNewLine & vbNewLine & "Do you want to declare this SpoolNo : " & g_spool.Text.Trim & vbNewLine & "as " & g_remarks.Text.Trim & " and set to EMPTY ?" & vbNewLine & vbNewLine & "Remaining Length : " & CSng(g_length.Text) - CSng(g_consume.Text), MsgBoxStyle.YesNo, g_remarks.Text & " SPOOL") = MsgBoxResult.No Then : Exit Sub
                        If MsgBox("Please Confirm!" & vbNewLine & "SET THIS SPOOL to RETURN?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
                    End If
                    msg = "PLEASE RETURN THE SPOOL TO KITTING"
                Case "TRANSFER SPOOL"
                    If MsgBox("Please Confirm!" & vbNewLine & "TRANSAFER This Spool to MAchine (" & g_machine.Text.Trim & ") ?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
                    msg = "Spool No (" & g_spool.Text & ") is now Transfered to (" & g_machine.Text & ")"
            End Select

            EXEC_QRY("@@MethodType = 'AU_TRANSACTION',@CollectType = 'AU TRANSACTION',@ID = '" + UID.Text.Trim + "',@Status = '" + g_status.Text.Trim + "',@SpoolNo = '" + g_spool.Text.Trim + "',@Package = '" + g_package.Text.Trim + "',@Machine = '" + g_machine.Text.Trim.ToUpper + "',@Lotno = '" + g_lotno.Text.Trim + "',@returnBy = '" + userID.Trim + "',@Remarks = '" + g_remarks.Text.Trim + "',@Consume = '" + g_consume.Text.Trim + "',@ReasonCOde = '" + g_reason.Text.Trim + "',@ComputerName = '" + DeviceName + "'", Nothing)

            MsgBox(msg)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Gold_Request.dgv_loader(g_status.Text.Trim, Gold_Request.dgvGold)
        Me.Close()
    End Sub

    Private Sub g_consume_KeyPress(sender As Object, e As KeyPressEventArgs) Handles g_consume.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If g_consume.Text = "" Then Exit Sub
            If CInt(g_consume.Text.Trim) > CInt(g_length.Text.Trim) Then
                MsgBox("Consumption should not greater than Current Length!")
                g_consume.Text = Nothing
            Else
                g_reason.Select()
            End If
        End If
    End Sub

    Private Sub g_consume_LostFocus(sender As Object, e As EventArgs) Handles g_consume.LostFocus
        If g_consume.Text = "" Then Exit Sub
        If CSng(g_consume.Text.Trim) > CSng(g_length.Text.Trim) Then
            MsgBox("Consumption should not greater than Current Length!")
            g_consume.Text = Nothing
        Else
            g_reason.Select()
        End If
    End Sub
End Class