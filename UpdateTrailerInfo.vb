Public Class UpdateTrailerInfo

    Dim MyWebService As New KAR_Lot_SmartClient.karservices.cactus.smartclient.kar_smartclient_webservice

    Private Sub UpdateTrailerInfo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Cursor = Cursors.WaitCursor
        Me.MyWebService.Url = GlobalClass.KarCactusWeb.Url
        AddHandler MyWebService.GetUpdateTrailerDSCompleted, AddressOf Me.GetUpdateTrailerDSComplete
        Me.GetTrailerDS()
    End Sub
    Private Sub GetTrailerDS()
        Dim MyGuid As Guid = Guid.NewGuid
        Me.MyWebService.GetUpdateTrailerDSAsync(MyGuid)
    End Sub
    Private Sub GetUpdateTrailerDSComplete(ByVal sender As Object, ByVal e As KAR_Lot_SmartClient.karservices.cactus.smartclient.GetUpdateTrailerDSCompletedEventArgs)
        Me.TrailerBindingSource.DataSource = e.Result
        Me.TrailersDataGridView.Refresh()

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub CarriersBindingSource1_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub
End Class