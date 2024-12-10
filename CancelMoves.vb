Public Class CancelMoves

    Dim SelectedTrailer As KarLotTrailer.karlot.Trailer
    Dim MyWebService As New KAR_Lot_SmartClient.karservices.cactus.smartclient.kar_smartclient_webservice

    Private Sub CancelMoves_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.TrailersListBox.DataSource = Me.DoorTrailers
        Me.TrailersListBox.DisplayMember = "TrailerID"
        Me.TrailersListBox.ValueMember = "MoveID"
        Me.MyWebService.Url = GlobalClass.KarCactusWeb.Url
        Me.CanAllBeCancelled()

        AddHandler MyWebService.CancelTrailerMovesCompleted, AddressOf MovesCancelledComplete
    End Sub

    Public Sub New(ByVal pTrailers As List(Of KarLotTrailer.karlot.Trailer))

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.DoorTrailers = pTrailers

    End Sub


    Private m_DoorTrailers As List(Of KarLotTrailer.karlot.Trailer)
    Public Property DoorTrailers() As List(Of KarLotTrailer.karlot.Trailer)
        Get
            Return m_DoorTrailers
        End Get
        Set(ByVal value As List(Of KarLotTrailer.karlot.Trailer))
            m_DoorTrailers = value
        End Set
    End Property

    Private Sub TrailersListBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrailersListBox.SelectedIndexChanged
        If Me.TrailersListBox.SelectedItems.Count <> 1 Then Exit Sub
        Me.SelectedTrailer = Me.TrailersListBox.SelectedItem
        Me.ShowTrailerInfo()
    End Sub

    Private Sub ShowTrailerInfo()
        With Me.SelectedTrailer
            Me.CarrierNameLabel.Text = .Carrier.Name
            Me.TrailerIDLabel.Text = .TrailerID
            Me.StatusLabel.Text = .MoveStatus
        End With
    End Sub

    Private Sub ActionButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActionButton.Click
        If Me.CanICancelMove(Me.SelectedTrailer) Then
            Dim MyGuid As Guid = Guid.NewGuid
            Dim pTrailer(0) As KAR_Lot_SmartClient.karservices.cactus.smartclient.Trailer

            pTrailer(0) = MainForm.Convert2WebTrailer(Me.SelectedTrailer)

            Try
                Me.MyWebService.CancelTrailerMovesAsync(pTrailer, GlobalClass.MyUser.UserName)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            MessageBox.Show("You must cancel the other move first.", "Kar Lot", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub MovesCancelledComplete(ByVal sender As Object, ByVal e As KAR_Lot_SmartClient.karservices.cactus.smartclient.CancelTrailerMovesCompletedEventArgs)
        If e.Cancelled Then Exit Sub

        If e.Error IsNot Nothing Then
            MessageBox.Show(e.Error.Message)
            Exit Sub
        End If

        If e.Result = False Then
            MessageBox.Show("The Move(s) could not be cancelled.")
            Exit Sub
        Else
            MainForm.RefreshDoorData()
            Me.Close()
        End If
    End Sub
    Private Sub CanAllBeCancelled()
        Dim tCount As Integer = Me.TrailersListBox.Items.Count - 1
        Dim Result As Boolean = True

        Dim pTrailer(tCount) As KAR_Lot_SmartClient.karservices.cactus.smartclient.Trailer

        For x As Integer = 0 To tCount
            pTrailer(x) = MainForm.Convert2WebTrailer(Me.TrailersListBox.Items.Item(x))
            Select Case pTrailer(x).MoveStatus
                Case "Called in Door", "Called out Door"
                    ' IF ANY MOVE STATUS IS DIFFERENT THAN THESE IT CANNOT BE MOVED
                Case Else
                    Result = False
            End Select
        Next
        If Result = False Then
            Me.CancelAllButton.Enabled = False
        Else
            Me.CancelAllButton.Enabled = True
        End If
    End Sub
    Private Sub CancelAllButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelAllButton.Click
        Dim MyGuid As Guid = Guid.NewGuid
        Dim tCount As Integer = Me.TrailersListBox.Items.Count - 1

        Dim pTrailer(tCount) As KAR_Lot_SmartClient.karservices.cactus.smartclient.Trailer

        For x As Integer = 0 To tCount
            pTrailer(x) = MainForm.Convert2WebTrailer(Me.TrailersListBox.Items.Item(x))
        Next

        Try
            Me.MyWebService.CancelTrailerMovesAsync(pTrailer, GlobalClass.MyUser.UserName)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Function CanICancelMove(ByVal pTrailer As KarLotTrailer.karlot.Trailer) As Boolean
        If pTrailer.MoveStatus.ToUpper = "CALLED OUT DOOR" Then
            Dim mCanCancelFlag As Boolean = True

            For Each mTr As KarLotTrailer.karlot.Trailer In Me.DoorTrailers
                Select Case mTr.MoveStatus.ToUpper
                    Case "CALLED IN DOOR", "MOVING TO DOOR"
                        mCanCancelFlag = False
                End Select
            Next
            Return mCanCancelFlag
        Else
            Return True
        End If
    End Function
End Class