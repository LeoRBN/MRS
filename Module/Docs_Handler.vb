Imports System.Data.OleDb
Imports System.IO
Imports System.Data.SqlClient
Imports System.Text
Imports System.Net.Mail
Imports System.Threading
Imports Microsoft.Office.Interop
Imports System.Windows.Forms
Imports Application = Microsoft.Office.Interop.Excel.Application

Module Docs_Handler
#Region "UPLOAD EXCEL / CSV FILE"
    Public Sub EXCEL_to_DGV(dgv As DataGridView)

        Dim openFileDialog As New OpenFileDialog()

        openFileDialog.Filter = "Excel Files|*.xlsx|CSV Files|*.csv"
        openFileDialog.Title = "Select an Excel file"
        Try
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                'ProgressBar.Show()
                Dim ExcelConn As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & openFileDialog.FileName & ";Extended Properties=""Excel 12.0 Xml;HDR=YES;"""

                da = New OleDbDataAdapter("Select * FROM [Sheet1$]", ExcelConn)
                uploadDS = New DataSet
                Dim rowC As Integer = 0
                da.Fill(uploadDS)
                ' ProgressBar.Close()
                dgv.DataSource = uploadDS.Tables(0)

            End If

        Catch ex As Exception
            Dim fpath As String = Convert_xlsx_to_CSV(openFileDialog.FileName)
            AppProcess(dgv, fpath)
        End Try
        dgv.ClearSelection()
    End Sub

    Public Function AppProcess(dgv As DataGridView, fpath As String) As Boolean 'load data from a CSV file
        Try
            Dim selectedfile As String = fpath

            Using reader As New StreamReader(selectedfile)
                dt = New DataTable()
                Dim isfirstrow As Boolean = True

                While Not reader.EndOfStream
                    Dim line As String = reader.ReadLine()
                    Dim header() As String = line.Split(",")

                    If dt.Columns.Count = 0 Then
                        For Each head As String In header
                            dt.Columns.Add(head)
                        Next
                    Else
                        dt.Rows.Add(header)
                    End If
                End While
                dgv.DataSource = dt

            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function

    Public Function Convert_xlsx_to_CSV(fpath As String) As String

        ' Create an OpenFileDialog to allow the user to select the Excel file
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*"
        openFileDialog.FilterIndex = 1
        openFileDialog.RestoreDirectory = True

        'If openFileDialog.ShowDialog() = DialogResult.OK Then

        ' Get the path to the selected Excel file
        Dim excelFilePath As String = fpath

        ' Create an Excel application object
        Dim excelApp As New Application()

        ' Open the Excel file
        Dim excelWorkbook As Excel.Workbook = excelApp.Workbooks.Open(excelFilePath)

        ' Get the first worksheet in the workbook
        Dim excelWorksheet As Microsoft.Office.Interop.Excel.Worksheet = excelWorkbook.Sheets(1)

        ' Set the path to save the CSV file
        Dim csvFilePath As String = Path.ChangeExtension(excelFilePath, ".csv")

        ' Save the worksheet as a CSV file with UTF-8 encoding
        Dim csvEncoding As Encoding = Encoding.UTF8
        Dim csvStream As New StreamWriter(csvFilePath, False, csvEncoding)

        ' Get the used range of the worksheet as an array of values
        Dim usedRange As Microsoft.Office.Interop.Excel.Range = excelWorksheet.UsedRange
        Dim values As Object(,) = usedRange.Value(Microsoft.Office.Interop.Excel.XlRangeValueDataType.xlRangeValueDefault)

        ' Loop over the rows and columns of the array to build the CSV string
        For i As Integer = 1 To values.GetLength(0)
            For j As Integer = 1 To values.GetLength(1)
                Dim value As Object = values(i, j)
                If value IsNot Nothing Then
                    Dim stringValue As String = value.ToString()
                    If stringValue.Contains(",") Then
                        stringValue = """" & stringValue & """"
                    End If
                    csvStream.Write(stringValue)
                End If
                If j < values.GetLength(1) Then
                    csvStream.Write(",")
                End If
            Next
            csvStream.WriteLine()
        Next

        csvStream.Close()

        ' Close the Excel workbook and application objects
        excelWorkbook.Close()
        excelApp.Quit()

        ' Release the COM objects to avoid memory leaks
        System.Runtime.InteropServices.Marshal.ReleaseComObject(usedRange)
        System.Runtime.InteropServices.Marshal.ReleaseComObject(excelWorksheet)
        System.Runtime.InteropServices.Marshal.ReleaseComObject(excelWorkbook)
        System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp)
        Return Path.ChangeExtension(fpath, ".csv")
    End Function
#End Region

#Region "EXPORT TO CSV / EXCEL"
    Public Sub ExportToCSV(dgv As DataGridView)
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "CSV Files (*.csv)|*.csv"
        saveFileDialog.FileName = "MRS5_DATA " & Replace(Replace(Date.Now, "/", "-"), ":", "_")
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Dim sb As New StringBuilder()

            'Export Header Names
            For i As Integer = 0 To dgv.Columns.Count - 1
                sb.Append(dgv.Columns(i).HeaderText)
                If i <> dgv.Columns.Count - 1 Then
                    sb.Append(",")
                End If
            Next
            sb.AppendLine()

            'Export Rows
            For i As Integer = 0 To dgv.Rows.Count - 1
                For j As Integer = 0 To dgv.Columns.Count - 1
                    sb.Append(dgv.Rows(i).Cells(j).Value.ToString().Replace(",", "/"))
                    If j <> dgv.Columns.Count - 1 Then
                        sb.Append(",")
                    End If
                Next
                sb.AppendLine()
            Next

            Using sw As New StreamWriter(saveFileDialog.FileName)
                sw.Write(sb.ToString())
            End Using

            MessageBox.Show("Data Exported Successfully!")
        End If
    End Sub



#End Region

#Region "NOTIFICATION TRIGGER"
    Public Sub Trigger_Alert(mCODE As String)
        Try
            Dim Name As String = Nothing
            If mCODE.Contains("/") Then
                Name = Replace(mCODE, "/", "_")
            Else
                Name = mCODE
            End If

            Dim fpath = My.Settings.System_Notifier & "\" & Name & ".txt"
            If Not File.Exists(fpath) Then
                Dim fileStream As StreamWriter = File.CreateText(fpath)
                fileStream.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub DEL_file(DirectoryPath As String, extention As String)
        Dim fileNames As String() = Directory.GetFiles(DirectoryPath, "*." & extention)
        For Each fileName As String In fileNames
            Try
                File.Delete(fileName)
            Catch ex As Exception
                ' Handle the exception here
                MsgBox("Error deleting file: " & ex.Message)
            End Try
        Next
    End Sub
#End Region
End Module
