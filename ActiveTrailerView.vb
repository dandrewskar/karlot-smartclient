Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices
Imports KAR_Lot_SmartClient.karservices.cactus.smartclient
Imports KAR_Lot_SmartClient.MainForm
Imports Microsoft.SqlServer

Public Class ActiveTrailerView

    Dim MyWebService As New KAR_Lot_SmartClient.karservices.cactus.smartclient.kar_smartclient_webservice
    Dim MyTrailers As New KAR_Lot_SmartClient.karservices.cactus.smartclient.ActiveTrailerDataSet
    Dim TrGuid As Guid = Guid.NewGuid
    Dim MyWSBasic As New KAR_Lot_SmartClient.karservices.cactus.webservices.Service
    Dim contextMenuForColumn1 As ContextMenu = New ContextMenu()

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



    'Private Sub ActiveTrailerGridView_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ActiveTrailerGridView.CellMouseUp
    '    If e.Button = MouseButtons.Right Then
    '        Dim confMsg = MessageBox.Show("Do you want to Delete Active Trailer?", "Delete Active Trailer", MessageBoxButtons.YesNo)

    '        If confMsg = DialogResult.Yes Then
    '            Dim selectedrow As DataGridViewRow
    '            selectedrow = ActiveTrailerGridView.Rows(e.RowIndex)
    '            Dim id As Integer = selectedrow.Cells(3).Value

    '            Try

    '                Dim result As KAR_Lot_SmartClient.karservices.cactus.smartclient.Trailer() = MyWebService.GetActiveTrailersByTrailerID(id)


    '                Dim systemId = result(0).SystemID

    '                DeleteRecordFromDatabase(systemId)

    '                'ActiveTrailerGridView.Rows.Remove(selectedrow)
    '            Catch ex As Exception
    '                ' Handle any exceptions
    '                Console.WriteLine("Error calling WCF service: " & ex.Message)

    '            Finally
    '                ' Always close the client to release resources
    '                'If MyWebService.State = ServiceModel.CommunicationState.Faulted Then
    '                '    MyWebService.Abort()
    '                'Else
    '                '    MyWebService.Close()
    '                'End If
    '            End Try

    '            'MessageBox.Show("Deleting")
    '        End If




    '    End If
    'End Sub

    Private Sub DeleteRecordFromDatabase(systemId As String)
        Dim connectionString As String = "Server=tcp:prodkarlot.database.windows.net,1433;Initial Catalog=guymon_karlot;Persist Security Info=False;User ID=saadmin;Password=Yhaw9012Phaw9012;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30"
        ' SQL query to update the record
        Dim query As String = "UPDATE Trailers SET Active = 0 WHERE SystemId = @SystemId"

        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Using command As New SqlCommand(query, connection)
                    ' Add the ID parameter to the query
                    command.Parameters.AddWithValue("@SystemId", systemId)

                    ' Execute the DELETE query
                    'Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    'If rowsAffected > 0 Then
                    '    MessageBox.Show("Record deleted successfully.")
                    'Else
                    '    MessageBox.Show("No record found to delete.")
                    'End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                If connection.State = ConnectionState.Open Then
                    connection.Close()
                End If
            End Try
        End Using
    End Sub

End Class