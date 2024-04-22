Imports System.ComponentModel

Public Class NewEndorseRaw

    Sub Dgv_Builder(dgv As DataGridView, type As String)

        'NOTE : Update the Index in the < Save_Data_to_database() > When u add columns

        Dim Coltype() As String = {"VALENCIA WAFER", "INTERPOSER/EFUSE", "BARE CAPS", "GLASS CONSUME", "CAPS CONSUME", "VCSEL WAFER"}
        Dim index As Integer = Array.IndexOf(Coltype, type)
        dgv.Columns.Clear()
        dgv.Rows.Clear()

        Select Case index
            Case 0 'Valencia
                Dim va() As String = {"MATERIAL_CODE", "CONTAINER_ID", "RW_TAPE_ID", "SLICE_NO", "RECEIVED_QTY"}
                For i As Integer = 0 To va.Length - 1
                    Dim NewColumn As New DataGridViewTextBoxColumn
                    NewColumn.HeaderText = va(i)
                    NewColumn.Name = va(i)
                    dgv.Columns.Add(NewColumn)
                Next
            Case 1 'SMT
                Dim smt() As String = {"MATERIAL_CODE", "LOT_NUMBER", "REEL_NUMBER", "RECEIVED_QTY"}
                For i As Integer = 0 To smt.Length - 1
                    Dim NewColumn As New DataGridViewTextBoxColumn
                    NewColumn.HeaderText = smt(i)
                    NewColumn.Name = smt(i)
                    dgv.Columns.Add(NewColumn)
                Next
            Case 2 ' Bare Caps
                Dim bare() As String = {"MATERIAL_CODE", "LOT_NUMBER", "RECEIVED_QTY"}
                For i As Integer = 0 To bare.Length - 1
                    Dim NewColumn As New DataGridViewTextBoxColumn
                    NewColumn.HeaderText = bare(i)
                    NewColumn.Name = bare(i)
                    dgv.Columns.Add(NewColumn)
                Next
            Case 3 'Glass Consume

            Case 4 'Caps Consume
                Dim cc() As String = {"MATERIAL_LOT_ID", "CARRIER_TAPE", "QUANTITY", "CURRENT_N2_LOCATION"}
                Dim carrier() As String = {"CPAK", "ADVANTEK"}
                For i As Integer = 0 To cc.Length - 1
                    If i = 3 Then 'Dropdowns for N2 Location
                        Dim cbmCol As New DataGridViewComboBoxColumn
                        cbmCol.DataPropertyName = cc(i)
                        cbmCol.HeaderText = cc(i)
                        cbmCol.ValueMember = cc(i)
                        cbmCol.DisplayMember = cc(i)
                        dgv.Columns.Add(cbmCol)
                        DGV_COMBOBOX("@@MethodType = 'RAW_DROPDOWNS',@Type = 'N2',@columnName = 'STEP'", "STEP", cbmCol)

                    ElseIf i = 1 Then 'Dropdown for Carrier Tape
                        Dim cbmCol As New DataGridViewComboBoxColumn
                        cbmCol.HeaderText = cc(i)
                        cbmCol.DataPropertyName = cc(i)
                        cbmCol.ValueMember = cc(i)
                        cbmCol.DisplayMember = cc(i)
                        dgv.Columns.Add(cbmCol)
                        For j As Integer = 0 To carrier.Length - 1
                            cbmCol.Items.AddRange(carrier(j))
                        Next j

                    Else
                        Dim NewColumn As New DataGridViewTextBoxColumn
                        NewColumn.HeaderText = cc(i)
                        NewColumn.Name = cc(i)
                        dgv.Columns.Add(NewColumn)
                    End If
                Next

            Case 5 'Vcsel Wafer
                Dim vc() As String = {"TAPE_ID", "WL", "VCSEL_BIN", "EXPIRY_DATE", "RECEIVE_QTY"}
                Dim vcselbin() As String = {"BIN A (G3)", "BIN B (G3)", "BIN C (G3)", "BIN D (G3)", "BIN A (G4)", "BIN B (G4)", "BIN C (G4)", "BIN D (G4)"}
                For i As Integer = 0 To vc.Length - 1
                    If i = 2 Then 'Dropdown for Vcsel Binning
                        Dim cbmCol As New DataGridViewComboBoxColumn
                        cbmCol.HeaderText = vc(i)
                        cbmCol.DataPropertyName = vc(i)
                        cbmCol.ValueMember = vc(i)
                        cbmCol.DisplayMember = vc(i)
                        dgv.Columns.Add(cbmCol)
                        For j As Integer = 0 To vcselbin.Length - 1
                            cbmCol.Items.AddRange(vcselbin(j))
                        Next j
                    Else
                        Dim NewColumn As New DataGridViewTextBoxColumn
                        NewColumn.HeaderText = vc(i)
                        NewColumn.Name = vc(i)
                        dgv.Columns.Add(NewColumn)
                    End If
                Next
        End Select
        Try
            'DELETE BUTTON INSIDE DGV
            Dim colBtn As New DataGridViewButtonColumn
            colBtn.HeaderText = " "
            colBtn.Name = "DelROW"
            colBtn.Text = "X"
            colBtn.UseColumnTextForButtonValue = True
            colBtn.DefaultCellStyle.BackColor = Color.Red
            colBtn.Width = 20
            dgv.Columns.Add(colBtn)
            colBtn.FlatStyle = True
        Catch
        End Try
    End Sub

    Private Sub dgvOthers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOthers.CellContentClick
        If dgvOthers.Rows.Count = 0 Then Exit Sub
        Try
            If e.ColumnIndex = dgvOthers.Columns("DelROW").Index AndAlso e.RowIndex >= 0 Then
                ' Delete the selected row
                dgvOthers.Rows.RemoveAt(e.RowIndex)
            End If
        Catch
        End Try
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles type.SelectedIndexChanged
        Dgv_Builder(dgvOthers, type.Text)
        If type.Text = "VCSEL WAFER" Then
            Label2.Visible = True
        Else
            Label2.Visible = False
        End If
    End Sub

    Private Sub tb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tb.SelectedIndexChanged
    End Sub

    Private Sub NewEndorseRaw_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case tb.SelectedIndex
            Case 0
                label.Text = "NEW ENDORSE"
            Case 1
                label.Text = "UPDATE DATA"
        End Select
    End Sub

    Private Sub savebtn_Click(sender As Object, e As EventArgs) Handles savebtn.Click
        Save_Data_to_database(type.Text)
    End Sub

    Private Sub Save_Data_to_database(id As String)
        Dim arry() As String = {"CAPS CONSUME", "VCSEL WAFER", "VALENCIA WAFER", "INTERPOSER/EFUSE", "BARE CAPS", "GLASS CONSUME"}
        Dim x As Integer = Array.IndexOf(arry, id)

        'NOTE : This Function this Index base. got to < Dgv_Builder() > for Ref.

        Dim mainQry As String = Nothing
        Dim bare() As String = {"MATERIAL_CODE", "LOT_NUMBER", "RECEIVED_QTY"}

        If kitter.Text = Nothing Then MsgBox("Received by is empty!") : Exit Sub
        Try
            For Each row As DataGridViewRow In dgvOthers.Rows

                If row.Cells(0).Value Is Nothing OrElse String.IsNullOrWhiteSpace(row.Cells(0).Value.ToString()) Then Exit For

                Select Case x
                    Case 0 'Cap Consume
                        mainQry = "@ID = '" + Trim(row.Cells(0).Value.ToString) + "',@Qty = '" + Trim(row.Cells(2).Value.ToString) + "',@n2 = '" + Trim(row.Cells(3).Value.ToString) + "',@Kitter = '" + kitter.Text + "',@Ctape = '" + Trim(row.Cells(1).Value.ToString) + "'"

                    Case 1 'Vcsel Wafer
                        Dim xdate As String = Trim(row.Cells(3).Value.ToString)
                        If xdate.Contains(".") Then
                            xdate = xdate.Replace(".", "/")
                        End If
                        mainQry = "@tapeID = '" + Trim(row.Cells(0).Value.ToString) + "',@wl = '" + Trim(row.Cells(1).Value.ToString) + "',@bin = '" + Trim(row.Cells(2).Value.ToString) + "',@xdate = '" + xdate + "',@Qty = '" + Trim(row.Cells(4).Value.ToString) + "',@Kitter = '" + Trim(kitter.Text) + "'"

                    Case 2 'Valencia Wafer
                        mainQry = "@Container = '" + Trim(row.Cells(1).Value.ToString) + "',@slice = '" + Trim(row.Cells(3).Value.ToString) + "',@tapeID = '" + Trim(row.Cells(2).Value.ToString) + "',@Qty = '" + Trim(row.Cells(4).Value.ToString) + "',@Kitter = '" + Trim(kitter.Text) + "',@MatCode = '" + Trim(row.Cells(0).Value.ToString) + "'"

                    Case 3 'SMT Reel Mayterial
                        mainQry = "@Lotno = '" + Trim(row.Cells(1).Value.ToString) + "',@reel = '" + Trim(row.Cells(2).Value.ToString) + "',@MatCode = '" + Trim(row.Cells(0).Value.ToString) + "',@Qty = '" + Trim(row.Cells(3).Value.ToString) + "',@Kitter = '" + Trim(kitter.Text) + "'"

                    Case 4 'Bare Caps
                        mainQry = "@Lotno = '" + Trim(row.Cells(1).Value.ToString) + "',@MatCode = '" + Trim(row.Cells(0).Value.ToString) + "',@Qty = '" + Trim(row.Cells(2).Value.ToString) + "',@Kitter = '" + Trim(kitter.Text) + "'"

                    Case 5 'Glass Consume
                        MsgBox("Sorry Glass Consume is Currently Unavailable!")

                End Select
                'MsgBox("@@MethodType = 'INSERT_NEW',@CollectType = '" + Trim(type.Text) + "'," & mainQry)
                EXEC_QRY("@@MethodType = 'INSERT_NEW',@CollectType = '" + Trim(type.Text) + "'," & mainQry, Nothing)

            Next

            MsgBox(Trim(type.Text) & " Successfully Encoded")
            Me.Close()

        Catch ex As Exception
            MsgBox("TRANSACTION FAILED : " & vbNewLine & vbNewLine & ex.Message)
        End Try

    End Sub

    Private Sub NewEndorseRaw_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        dgvOthers.Columns.Clear() : dgvOthers.Rows.Clear()
        kitter.Text = Nothing
        type.Text = Nothing
    End Sub

    Private Sub label_Click(sender As Object, e As EventArgs) Handles label.Click
        tb.SelectedIndex = 0
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        tb.SelectedIndex = 1
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            QRtoDGV(TextBox1.Text, DataGridView1)
        End If
    End Sub
End Class