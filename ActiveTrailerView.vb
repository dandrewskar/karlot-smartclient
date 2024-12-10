Public Class ActiveTrailerView

    Dim MyWebService As New KAR_Lot_SmartClient.karservices.cactus.smartclient.kar_smartclient_webservice
    Dim MyTrailers As New KAR_Lot_SmartClient.karservices.cactus.smartclient.ActiveTrailerDataSet
    Dim TrGuid As Guid = Guid.NewGuid
    Dim MyWSBasic As New KAR_Lot_SmartClient.karservices.cactus.webservices.Service

    Private Sub ActiveTrailerView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.WaitCursor
        Me.RecordCounterToolStripStatusLabel.Text = "Loading Trailers, Please Wait..."
        Me.MyWebService.Url = GlobalClass.KarCactusWeb.Url
        Me.MyWSBasic.Url = GlobalClass.KarCactusWebBasic.Url
        Me.MyWSBasic.Timeout = 4000
        Me.MyWebService.Timeout = 4000
        AddHandler MyWebService.GetActiveTrailersDatasetCompleted, AddressOf Me.GetActiveTrailersComplete

        Me.MyWebService.CancelAsync(TrGuid)
        Me.MyWebService.GetActiveTrailersDatasetAsync(TrGuid)
        If My.Settings.AllowTrailerCheckInOut = True Then
            Me.CheckOutTrailerToolStripButton.Visible = True
        Else
            Me.CheckOutTrailerToolStripButton.Visible = False
        End If
    End Sub

    Private Sub GetActiveTrailersComplete(ByVal sender As Object, ByVal e As KAR_Lot_SmartClient.karservices.cactus.smartclient.GetActiveTrailersDatasetCompletedEventArgs)
        Me.Cursor = Cursors.Default
        If e.Error IsNot Nothing Then
            MessageBox.Show(e.Error.Message, "Problem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Me.RecordCounterToolStripStatusLabel.Text = "Trailers could not be loaded."
            Me.Cursor = Cursors.Default
            Exit Sub
        End If

        If e.Cancelled = True Then
            Me.RecordCounterToolStripStatusLabel.Text = "Trailers could not be loaded."
            Me.Cursor = Cursors.Default
            ' nothing
        Else
            Try
                Me.MyTrailers = e.Result
                Me.ActiveTrailersBindingSource.DataSource = Me.MyTrailers
                Me.ActiveTrailersBindingSource.DataMember = "Trailers"
                Me.ActiveTrailerGridView.Refresh()
            Catch ex As Exception
                Me.RecordCounterToolStripStatusLabel.Text = "Trailers could not be loaded."
                Me.Cursor = Cursors.Default
                Me.ShowMessage("Trailer list could not be loaded. Please try again." & vbCrLf & vbCrLf & ex.Message)
                Me.Close()
            End Try
            Me.ActiveTrailerGridView.Refresh()
            Me.Cursor = Cursors.Default
            Me.RecordCounterToolStripStatusLabel.Text = "Done."
        End If
    End Sub

    Private Sub ShowMessage(ByVal pMsg As String)
        MessageBox.Show(pMsg, "Kar Lot", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
    End Sub

    Private Sub CheckOutTrailerToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckOutTrailerToolStripButton.Click
        If MessageBox.Show("Check-out trailer?" & vbCrLf & vbCrLf & Me.ActiveTrailerGridView.CurrentRow.Cells("CarrierDataGridViewTextBoxColumn").Value & " " & Me.ActiveTrailerGridView.CurrentRow.Cells("TrailerIDDataGridViewTextBoxColumn").Value & vbCrLf & vbCrLf & " Are you sure?", "Check-out Trailer", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor

        Try
            Me.MyWSBasic.CheckOutTrailer(Me.ActiveTrailerGridView.CurrentRow.Cells("SCACDataGridViewTextBoxColumn").Value.ToString, Me.ActiveTrailerGridView.CurrentRow.Cells("TrailerIDDataGridViewTextBoxColumn").Value.ToString, GlobalClass.MyUser.UserName)
            Me.ActiveTrailersBindingSource.RemoveCurrent()
            Me.ActiveTrailerGridView.Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Me.Cursor = Cursors.Arrow
            Exit Sub
        End Try

        Me.Cursor = Cursors.Arrow

    End Sub
End Class