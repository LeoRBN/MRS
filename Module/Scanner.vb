Imports System.Text.RegularExpressions
Imports Microsoft.Office.Interop.Excel
Imports System.Data


Module Scanner
    Function ConvertQRCodeValue(qrCodeValue As String) As List(Of String)
        Dim result As New List(Of String)()

        Dim frameInfoRegex As New Regex("<FrameInfo FRAMEID=""(.*?)"" QTY=""(.*?)""/>")
        Dim matches As MatchCollection = frameInfoRegex.Matches(qrCodeValue)

        For Each match As Match In matches
            Dim frameId As String = match.Groups(1).Value
            Dim qty As String = match.Groups(2).Value
            result.Add($"MATCODE,P733412003,{frameId},{qty}")
        Next

        Return result
    End Function

    Sub QRtoDGV(qrCodeValue As String, dgv As DataGridView)
        Dim convertedValues As List(Of String) = ConvertQRCodeValue(qrCodeValue)

        If dgv.Columns.Count = 0 Then
            dgv.Columns.Add("Matcode", "Matcode")
            dgv.Columns.Add("ContainerId", "Container Id")
            dgv.Columns.Add("FRAMEID", "FRAMEID")
            dgv.Columns.Add("QTY", "QTY")
        End If

        ' Add each row to the DataGridView
        For Each convertedValue As String In convertedValues
            Dim values As String() = convertedValue.Split(","c)
            dgv.Rows.Add(values)
        Next
    End Sub

    Sub ExportEXCEL(dgv As DataGridView)
        Dim excelAppType As Type = Type.GetTypeFromProgID("Excel.Application")
        Dim excelApp As Object = Activator.CreateInstance(excelAppType)

        Dim workbook As Object = excelApp.Workbooks.Add()
        Dim worksheet As Object = workbook.Sheets(1)

        ' Write the headers from the DataGridView to the first row of the Excel worksheet
        'For j As Integer = 0 To dgv.Columns.Count - 1
        '    worksheet.Cells(1, j + 1) = dgv.Columns(j).HeaderText
        'Next

        ' Write the data from the DataGridView to the Excel worksheet
        For i As Integer = 0 To dgv.Rows.Count - 1
            For j As Integer = 0 To dgv.Columns.Count - 1
                worksheet.Cells(i + 2, j + 1) = dgv.Rows(i).Cells(j).Value.ToString()
            Next
        Next

        workbook.SaveAs("C:\Users\leo rabino-jr\Downloads\MRS5_DATA 4-20-2024 8_35_57 AM.xlsx")
        workbook.Close()
        excelApp.Quit()
    End Sub

End Module
