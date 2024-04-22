Public Class TransactionHistory
    Public HistoryID As String = Nothing
    Private Sub TransactionHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Load_data_from_db("@@MethodType = 'RAW_HISTORY',@CollectType = 'RAW',@ID = '" + HistoryID + "'", dgvHistory, "RAW", Nothing, Nothing, Nothing)

            Dim Data() As String = {"DATE_IN", "DATE_OUT", "ISSUED_TO", "ISSUED_BY", "QTY_IN", "QTY_OUT"}
            Dim ctr() As Control = {datein, dateout, issuedto, issuedby, qtyin, qtyout}

            For i As Integer = 0 To Data.Length - 1
                ctr(i).Text = ds.Tables(0).Rows(0)(Data(i)).ToString
            Next
        Catch ex As Exception

        End Try
    End Sub

End Class