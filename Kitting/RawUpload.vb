Imports System.ComponentModel
Imports System.IO

Public Class RawUpload
    Private Sub ccpackage_SelectedIndexChanged(sender As Object, e As EventArgs) Handles uploadType.SelectedIndexChanged, Button1.Click
        dgvUpload.DataSource = Nothing
        Label2.Text = Format(dgvUpload.Rows.Count, "000")
        If uploadType.Text IsNot Nothing Then
            BrowseFile.Enabled = True
        Else
            BrowseFile.Enabled = False
        End If
    End Sub

    Private Sub dgvUpload_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles dgvUpload.RowStateChanged
        Label2.Text = Format(dgvUpload.Rows.Count, "000")
        If dgvUpload.Rows.Count > 0 Then
            uploadBTN.Enabled = True
            Button1.Enabled = True
        Else
            uploadBTN.Enabled = False
            Button1.Enabled = False
        End If
    End Sub

    Private Sub BrowseFile_Click(sender As Object, e As EventArgs) Handles BrowseFile.Click
        uploadlog.Text = Nothing
        EXCEL_to_DGV(dgvUpload)
        Label2.Text = Format(dgvUpload.Rows.Count, "000")
    End Sub

    Private Sub uploadBTN_Click(sender As Object, e As EventArgs) Handles uploadBTN.Click
        Dim UploadBy As String = InputBox("Please input your Id number :", "UPLOAD BY:")
        Dim count As Integer = 0
        rlbl.Visible = True : rount.Visible = True
        Dim capC() As String = {"MATERIAL_LOT_ID", "BIN", "CAPS", "SITE", "RELEASE_DATE"}
        Dim vcsel() As String = {"TAPE_ID", "WL", "EXPIRY_DATE", "RECEIVE_QTY", "VCSEL_BIN"}
        Dim valencia() As String = {"MATERIAL_CODE", "CONTAINER_ID", "SLICE_NO", "RW_TAPE_ID", "RECEIVED_QTY"}
        Dim reel() As String = {"MATERIAL_CODE", "LOT_NUMBER", "REEL_NUMBER", "RECEIVED_QTY"}
        Dim idm() As String = {"Material Code", "Type", "Material Description", "Supplier", "UoM"}
        Dim consumeLot() As String = {"MATERIAL_LOT_ID", "RELEASE_DATE", "CAPS", "BIN", "Site"}

        Dim QRY As String = Nothing

        Try
            Select Case uploadType.Text
                Case "INDIRECT MATERIAL"
                    For Each row As DataGridViewRow In dgvUpload.Rows
                        If Trim(row.Cells(0).Value.ToString) <> Nothing Then
                            EXEC_QRY("@@MethodType = 'INSERT_NEW', @CollectType = '" + Trim(uploadType.Text) + "',@MatCode = '" + row.Cells(idm(0)).Value.ToString + "',@Type = '" + row.Cells(idm(1)).Value.ToString + "',@MatDesc = '" + row.Cells(idm(2)).Value.ToString + "',@Supplier = '" + row.Cells(idm(3)).Value.ToString + "',@UoM = '" + row.Cells(idm(4)).Value.ToString + "'", Nothing)
                            count += 1
                            rount.Text = count
                        End If
                    Next

                Case "BARE CAPS / SMT MATERIAL"
                    For Each row As DataGridViewRow In dgvUpload.Rows
                        If Trim(row.Cells(0).Value.ToString) <> Nothing Then
                            EXEC_QRY("@@MethodType = 'INSERT_NEW', @CollectType = '" + Trim(uploadType.Text) + "',@Lotno = '" + Trim(row.Cells(reel(1)).Value.ToString) + "',@reel = '" + Trim(row.Cells(reel(2)).Value.ToString) + "',@MatCode = '" + Trim(row.Cells(reel(0)).Value.ToString) + "',@Qty = '" + Trim(row.Cells(reel(3)).Value.ToString) + "',@Kitter = '" + Trim(UploadBy) + "'", Nothing)
                            count += 1
                            rount.Text = count
                        End If
                    Next

                Case "CONSUME LOTS"
                    For Each row As DataGridViewRow In dgvUpload.Rows
                        If RecordCount("@@MethodType = 'INSERT_NEW', @CollectType = 'CHECK_CONSUME',@Lotno = '" + Trim(row.Cells(consumeLot(0)).Value.ToString) + "'") = 0 Then
                            If Trim(row.Cells(0).Value.ToString) <> Nothing Then
                                EXEC_QRY("@@MethodType = 'INSERT_NEW', @CollectType = '" + Trim(uploadType.Text) + "', @Lotno = '" + Trim(row.Cells(consumeLot(0)).Value.ToString) + "',@releasedate = '" + Trim(row.Cells(consumeLot(1)).Value.ToString) + "',@caps = '" + Trim(row.Cells(consumeLot(2)).Value.ToString) + "',@bin = '" + Trim(row.Cells(consumeLot(3)).Value.ToString) + "',@site = '" + Trim(row.Cells(consumeLot(4)).Value.ToString) + "',@Kitter = '" + UploadBy + "'", Nothing)
                                count += 1
                                rount.Text = count
                            End If
                        End If
                    Next

                Case "VALENCIA WAFER"
                    For Each row As DataGridViewRow In dgvUpload.Rows
                        If Trim(row.Cells(0).Value.ToString) <> Nothing Then
                            EXEC_QRY("@@MethodType = 'INSERT_NEW', @CollectType = '" + Trim(uploadType.Text) + "',@Container = '" + Trim(row.Cells(valencia(1)).Value.ToString) + "',@slice = '" + Trim(row.Cells(valencia(2)).Value.ToString) + "',@tapeID = '" + Trim(row.Cells(valencia(3)).Value.ToString) + "',@Kitter = '" + Trim(UploadBy) + "',@MatCode = '" + Trim(row.Cells(valencia(0)).Value.ToString) + "',@Qty = '" + Trim(row.Cells(valencia(4)).Value.ToString) + "'", Nothing)
                            count += 1
                            rount.Text = count
                        End If
                    Next

                Case "VCSEL WAFER"
                    For Each row As DataGridViewRow In dgvUpload.Rows
                        If Trim(row.Cells(0).Value.ToString) <> Nothing Then
                            EXEC_QRY("@@MethodType = 'INSERT_NEW', @CollectType = '" + Trim(uploadType.Text) + "', @tapeID = '" + Trim(row.Cells(vcsel(0)).Value.ToString) + "',@wl = '" + Trim(row.Cells(vcsel(1)).Value.ToString) + "',@bin = '" + Trim(row.Cells(vcsel(4)).Value.ToString) + "',@xdate = '" + Trim(row.Cells(vcsel(2)).Value.ToString) + "',@Qty = '" + Trim(row.Cells(vcsel(3)).Value.ToString) + "',@Kitter = '" + Trim(UploadBy) + "'", Nothing)
                            count += 1
                            rount.Text = count
                        End If
                    Next
            End Select

            MsgBox("File Uploaded!" & vbNewLine & "Total rows : " & count)

        Catch EX As Exception
            MsgBox("Upload failed!" & vbNewLine & "Make sure that the selected file is for " & uploadType.Text & vbNewLine & vbNewLine & "Error :" & vbNewLine & EX.Message)
        End Try
        dgvUpload.DataSource = Nothing
        rlbl.Visible = False : rount.Visible = False
    End Sub

    Private Sub LotConsumeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LotConsumeToolStripMenuItem.Click
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.FileName = "LOT_CONSUME_RAW.xlsx"
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            File.Copy(My.Settings.TemplatePath & "\LOT CONSUME.xlsx", saveFileDialog.FileName)
        End If
        MsgBox("Template Saved!")
    End Sub

    Private Sub ValenciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ValenciaToolStripMenuItem.Click
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.FileName = "VALENCIA_RAW.xlsx"
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            File.Copy(My.Settings.TemplatePath & "\VALENCIA_RAW.xlsx", saveFileDialog.FileName)
        End If
        MsgBox("Template Saved!")
    End Sub

    Private Sub VcselToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VcselToolStripMenuItem.Click
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.FileName = "VCSEL_RAW.xlsx"
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            File.Copy(My.Settings.TemplatePath & "\VCSEL_RAW.xlsx", saveFileDialog.FileName)
        End If
        MsgBox("Template Saved!")
    End Sub

    Private Sub ReelMaterialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReelMaterialToolStripMenuItem.Click
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.FileName = "REELMAT_RAW.xlsx"
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            File.Copy(My.Settings.TemplatePath & "\REELMAT_RAW.xlsx", saveFileDialog.FileName)
        End If
        MsgBox("Template Saved!")
    End Sub

End Class