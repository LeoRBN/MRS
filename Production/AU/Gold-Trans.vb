Public Class Gold_Trans
    Private Sub Gold_Trans_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_data_from_db("@@MethodType = 'GET_AU_DATA',@CollectType = 'AU_SPOOL_TRANS',@ID = '" + SpoolNo.Text.Trim + "'", dgvAUtrans, "GOLD", Nothing, Nothing, Nothing)
    End Sub
End Class