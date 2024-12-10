Public Class ActiveMovesGridView
    Dim MyWebService As New KAR_Lot_SmartClient.karservices.cactus.smartclient.kar_smartclient_webservice
    Dim MovesList() As KAR_Lot_SmartClient.karservices.cactus.smartclient.TrailerMoveTO

    Private Sub ActiveMovesGridView_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.MyWebService.Url = GlobalClass.KarCactusWeb.Url
        AddHandler MyWebService.GetMovesCompleted, AddressOf Me.GetActiveMovesComplete
        Me.MyWebService.GetMovesAsync()
    End Sub

    Private Sub GetActiveMovesComplete(ByVal sender As Object, ByVal e As KAR_Lot_SmartClient.karservices.cactus.smartclient.GetMovesCompletedEventArgs)
        If e.Error IsNot Nothing Then
            Me.Cursor = Cursors.Default
            Me.ShowMessage(e.Error.Message)
            Exit Sub
        End If

        Try
            Me.MovesList = e.Result
            Me.MovesGridView.DataSource = Me.MovesList
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Me.ShowMessage(ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub ShowMessage(ByVal pMsg As String)
        MessageBox.Show(pMsg, "Kar Lot", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    End Sub
End Class