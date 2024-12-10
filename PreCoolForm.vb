Public Class PreCoolForm
    Dim MyWS As New KAR_Lot_SmartClient.karservices.cactus.smartclient.kar_smartclient_webservice
    Dim MyTrailers() As KAR_Lot_SmartClient.karservices.cactus.smartclient.PreCoolTrailerTO
    Dim TrailerCount As Integer = 0
    Dim MyGuid As New Guid
    Dim SelectedTrailer As KAR_Lot_SmartClient.karservices.cactus.smartclient.PreCoolTrailerTO
    Dim MyUser As KAR_Lot_SmartClient.karservices.cactus.smartclient.KarLotUser

    Const cPreCoolingTrailersMessage As String = "Precooling Trailers"
    Const cSearchByTrailerIDMessage As String = "Results For: "
    Const cSearchByCarrierMessage As String = "Results For: "

    Public Sub New(ByVal mWS As KAR_Lot_SmartClient.karservices.cactus.smartclient.kar_smartclient_webservice, ByVal pUser As KAR_Lot_SmartClient.karservices.cactus.smartclient.KarLotUser)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.MyWS = mWS
        Me.MyUser = pUser
        Me.BuildSelectTrailerPanel()
    End Sub
    Private Sub PreCoolForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        AddHandler MyWS.GetPreCoolingTrailersByTrailerIDCompleted, AddressOf Me.SearchByTrailerIDComplete
        AddHandler MyWS.GetPreCoolingTrailersByCarrierCompleted, AddressOf Me.SearchByCarrierComplete
        AddHandler MyWS.GetPreCoolingTrailersCompleted, AddressOf Me.DoGetAllPrecoolsComplete
        AddHandler MyWS.AddPrecoolTaskCompleted, AddressOf Me.DoStartPrecoolTaskComplete
        Me.ClearDetailFields()
        Me.ShowAllPrecools()
    End Sub

#Region " FORM CONTROL EVENTS "
    Private Sub MyCloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyCloseButton.Click
        Me.Close()
    End Sub
    Private Sub StartPrecoolButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartPrecoolButton.Click
        Dim NewPrecoolForm As New PrecoolWizardForm(0, Me.MyWS, Me.SelectedTrailer)
        AddHandler NewPrecoolForm.StartPrecool, AddressOf Me.DoStartPrecoolTask
        NewPrecoolForm.ShowDialog()
        RemoveHandler NewPrecoolForm.StartPrecool, AddressOf Me.DoStartPrecoolTask
    End Sub
#End Region

#Region " WebService Code "
    Private Sub SearchByCarrierComplete(ByVal sender As Object, ByVal e As KAR_Lot_SmartClient.karservices.cactus.smartclient.GetPreCoolingTrailersByCarrierCompletedEventArgs)
        Me.SetSearchAmination(False) ' always turn off the animation

        If e.Cancelled = True Then Exit Sub

        If e.Error IsNot Nothing Then
            MessageBox.Show(e.Error.Message, "Kar Lot", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If

        Me.MyTrailers = e.Result
        Me.BuildTreeView()
    End Sub
    Private Sub SearchByTrailerIDComplete(ByVal sender As Object, ByVal e As KAR_Lot_SmartClient.karservices.cactus.smartclient.GetPreCoolingTrailersByTrailerIDCompletedEventArgs)
        Me.SetSearchAmination(False) ' always turn off the animation

        If e.Cancelled = True Then Exit Sub

        If e.Error IsNot Nothing Then
            MessageBox.Show(e.Error.Message, "Kar Lot", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If

        Me.MyTrailers = e.Result
        Me.BuildTreeView()
    End Sub
    Private Sub DoSearchByTrailerID()
        Dim mSearchString As String = ""

        Me.SetSearchAmination(True)

        Select Case Me.SearchTypeToolStripDropDownButton.Text
            Case "Exact Match"
                mSearchString = Me.SearchToolStripTextBox.Text.Trim
            Case "Similar Match"
                mSearchString = "%" & Me.SearchToolStripTextBox.Text.Trim & "%"
        End Select
        Me.MyWS.CancelAsync(MyGuid)
        Me.MyWS.GetPreCoolingTrailersByTrailerIDAsync(mSearchString, MyGuid)
    End Sub
    Private Sub DoSearchByCarrier()
        Dim mSearchString As String = ""

        Me.SetSearchAmination(True)

        mSearchString = "%" & Me.SearchToolStripTextBox.Text.Trim & "%"
        Me.MyWS.CancelAsync(MyGuid)
        Me.MyWS.GetPreCoolingTrailersByCarrierAsync(mSearchString, MyGuid)
    End Sub
    Private Sub ShowAllPrecools()
        Me.SetSearchAmination(True)

        Me.MyWS.CancelAsync(MyGuid)
        Me.MyWS.GetPreCoolingTrailersAsync(MyGuid)
    End Sub
    Private Sub DoGetAllPrecoolsComplete(ByVal sender As Object, ByVal e As KAR_Lot_SmartClient.karservices.cactus.smartclient.GetPreCoolingTrailersCompletedEventArgs)
        Me.SetSearchAmination(False)

        If e.Cancelled Then Exit Sub

        If e.Error IsNot Nothing Then
            MessageBox.Show(e.Error.Message, "Kar Lot", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If

        Me.MyTrailers = e.Result
        Me.BuildTreeView()
    End Sub
    Private Sub DoStartPrecoolTask(ByVal pInstructions As String, ByVal pStartDate As DateTime, ByVal pStartTemp As String, ByVal pTrailer As KAR_Lot_SmartClient.karservices.cactus.smartclient.PreCoolTrailerTO, ByVal pNotifyEmail As String)
        Try
            Me.SetSearchAmination(True)
            Me.Cursor = Cursors.WaitCursor

            Me.MyWS.CancelAsync(MyGuid)
            Me.MyWS.AddPrecoolTaskAsync(pStartTemp.ToString(), pStartDate, pInstructions, Me.MyUser, pTrailer, pNotifyEmail)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub DoStartPrecoolTaskComplete(ByVal sender As Object, ByVal e As KAR_Lot_SmartClient.karservices.cactus.smartclient.AddPrecoolTaskCompletedEventArgs)
        Try
            Me.SetSearchAmination(False)
            Me.Cursor = Cursors.Arrow

            If e.Cancelled Then Exit Sub

            If e.Error IsNot Nothing Then
                MessageBox.Show(e.Error.Message, "Kar Lot", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                Exit Sub
            End If

            Me.SelectedTrailer = e.Result
            Me.UpdateTreeViewTrailer(Me.SelectedTrailer)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Unexpected Error After Starting Precool!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region " ToolStrip Code "
    Private Sub SearchToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchToolStripButton.Click
        Select Case Me.SearchStyleToolStripDropDownButton.Text
            Case "Search Trailer #"
                If Me.VerifySearchText Then
                    Me.ClearDetailFields()
                    Me.DoSearchByTrailerID()
                    Me.ShowStatusMessage(cSearchByTrailerIDMessage & Me.SearchToolStripTextBox.Text.Trim)
                    Me.ClearSearchFields()
                Else
                    MessageBox.Show("You must enter a trailer number before searching!", "Kar Lot", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1)
                End If
            Case "Search Carrier"
                If Me.VerifyCarrierSearchText Then
                    Me.ClearDetailFields()
                    Me.DoSearchByCarrier()
                    Me.ShowStatusMessage(cSearchByCarrierMessage & Me.SearchToolStripTextBox.Text.Trim)
                    Me.ClearSearchFields()
                Else
                    MessageBox.Show("You must enter a carrier name before searching!", "Kar Lot", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1)
                End If
        End Select
    End Sub
    Private Sub ExactMatchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExactMatchToolStripMenuItem.Click
        Me.SearchTypeToolStripDropDownButton.Text = "Exact Match"
    End Sub
    Private Sub SimilarMatchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimilarMatchToolStripMenuItem.Click
        Me.SearchTypeToolStripDropDownButton.Text = "Similar Match"
    End Sub
    Private Sub ShowPrecoolsToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowPrecoolsToolStripButton.Click
        Me.ShowAllPrecools()
        Me.ClearDetailFields()
        Me.ClearSearchFields()
        Me.ShowStatusMessage(cPreCoolingTrailersMessage)
    End Sub
#End Region

#Region " Helper Methods "
    Private Function VerifySearchText() As Boolean
        If Me.SearchToolStripTextBox.Text.Trim.Length = 0 Then Return False
        If Me.SearchToolStripTextBox.Text.Contains("%") Then Return False
        Return True
    End Function
    Private Function VerifyCarrierSearchText() As Boolean
        If Me.SearchToolStripTextBox.Text.Trim.Length = 0 Then Return False
        Return True
    End Function

    Private Sub ClearSearchFields()
        Me.SearchToolStripTextBox.Text = ""
    End Sub
    Private Sub ShowStatusMessage(ByVal pMessage As String)
        Me.MessageToolStripStatusLabel.Text = pMessage
    End Sub
    Private Sub SetSearchAmination(ByVal pOn As Boolean)
        Me.SearchPictureBox.Visible = pOn
        Me.SearchPictureBox.Refresh()
    End Sub
    Private Sub RefreshButtons()
        Try
            If Me.SelectedTrailer.Precooling = "1" Then
                Me.StartPrecoolButton.Enabled = False
                Me.CancelRequestButton.Visible = False
                If Me.SelectedTrailer.StopRequested Then
                    Me.StopPrecoolButton.Enabled = False
                Else
                    Me.StopPrecoolButton.Enabled = True
                End If
            Else
                If Me.SelectedTrailer.PrecoolRequested = "1" Then
                    Me.StartPrecoolButton.Enabled = False
                    Me.CancelRequestButton.Visible = True
                    Me.StopPrecoolButton.Enabled = False
                Else
                    Me.StartPrecoolButton.Enabled = True
                    Me.StopPrecoolButton.Enabled = False
                    Me.CancelRequestButton.Visible = False
                End If
            End If
        Catch ex As Exception
            ' IF AN ERROR OCCURS WHILE SETTING THE BUTTONS LOCK THEM ALL DOWN
            ' THE USER WILL HAVE TO CLICK ON ANOTHER TRAILER IN THE TREEVIEW
            Me.StartPrecoolButton.Enabled = False
            Me.StopPrecoolButton.Enabled = False
            Me.CancelRequestButton.Visible = False
        End Try

    End Sub
    Private Function GetLoadText(ByVal pCode As String) As String
        Dim sOb As New KarLotTrailer.karlot.TrailerLoadClass
        Try
            sOb.dbCode = pCode
            Return ToSafeString(sOb.LoadStatusMessage)
        Catch ex As Exception
            Return ""
        End Try
    End Function
#End Region

#Region " FORM UI CODE "
    Private Sub UpdateTreeViewTrailer(ByVal pTrailer As KAR_Lot_SmartClient.karservices.cactus.smartclient.PreCoolTrailerTO)
        'Me.TrailerTreeView.SelectedNode.Tag = pTrailer
        Me.ShowTrailerDetails()
    End Sub
    Private Sub ShowTrailerDetails()
        Try
            Me.ClearDetailFields()

            With Me.Panel1.Controls("SelectTrailerPanel")
                .Visible = False
                .SendToBack()
            End With

            Me.POBLabel.Visible = False ' Deprecated
            Me.SPLabel.Visible = True
            Me.BCLabel.Visible = True
            Me.LOCLabel.Visible = True

            Me.CarrierNameLabel.Text = ToSafeString(Me.SelectedTrailer.Carrier)
            Me.TrailerIDLabel.Text = ToSafeString(Me.SelectedTrailer.TrailerID)
            Me.BarcodeLabel.Text = ToSafeString(Me.SelectedTrailer.Barcode)
            Me.PalletsOnBoardLabel.Text = ToSafeString(Me.SelectedTrailer.PalletsOnBoard)

            Try
                Dim mTempCalc As New KlDispatchServices.Services.TemperatureConversionService(Convert.ToInt32(Convert.ToDouble(Me.SelectedTrailer.Temperature)), Me.SelectedTrailer.SetPointCelsius)
                If Me.TemperatureLabel.Text.Trim <> "NA" Then Me.TemperatureLabel.Text = String.Format("{0}F ({1}C)", mTempCalc.FahrenheitString, mTempCalc.CelsiusString)
            Catch ex As Exception
                If Me.TemperatureLabel.Text.Trim <> "NA" Then Me.TemperatureLabel.Text = Me.SelectedTrailer.Temperature
            End Try


            Me.CurrentLocationLabel.Text = ToSafeString(Me.SelectedTrailer.CurrentLocation)
            Me.LoadStatusLabel.Text = Me.GetLoadText(Me.SelectedTrailer.LoadStatus)


            If ToSafeString(Me.SelectedTrailer.Precooling) = "1" Then
                Me.PrecoolPictureBox.Visible = True
                Me.PreCoolingLabel.Visible = True
                Me.TimeRunningLabel.Visible = True
                Me.ShowTimeRunning()
                Try
                    Me.PreCoolingLabel.Text = "STARTED: " & Me.SelectedTrailer.PrecoolStarted.ToLongDateString.ToUpper & " AT " & Me.SelectedTrailer.PrecoolStarted.ToLongTimeString
                Catch ex As Exception
                    Me.PreCoolingLabel.Text = ex.Message
                End Try
                Me.StartPrecoolButton.Enabled = False
                If Me.SelectedTrailer.StopRequested Then
                    Me.StopPrecoolButton.Enabled = False
                    Me.StopUnitLabel.Visible = True
                Else
                    Me.StopPrecoolButton.Enabled = True
                End If
            Else
                If ToSafeString(Me.SelectedTrailer.PrecoolRequested) = "1" Then
                    Me.StartPrecoolButton.Enabled = False
                    Me.TimeRunningLabel.Text = "PRE-COOL HAS BEEN REQUESTED."
                    Me.TimeRunningLabel.Visible = True
                    Me.PreCoolingLabel.Visible = False
                    Me.CancelRequestButton.Visible = True
                Else
                    Me.StartPrecoolButton.Enabled = True
                    Me.PreCoolingLabel.Visible = False
                    Me.TimeRunningLabel.Visible = False
                    Me.CancelRequestButton.Visible = False
                End If
                Me.StopPrecoolButton.Enabled = False
                Me.PrecoolPictureBox.Visible = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Unexpected Error Showing Trailer Details!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End Try
    End Sub
    Private Function ToSafeString(ByVal value As String) As String
        Return IIf(value Is Nothing, String.Empty, value.Trim)
    End Function
    Private Sub ShowTimeRunning()
        Dim mString As String = "UNIT RUNNING FOR "
        Dim mDaysRunning As Integer = Now.Subtract(Me.SelectedTrailer.PrecoolStarted).Days
        Dim mHoursRunning As Integer = Now.Subtract(Me.SelectedTrailer.PrecoolStarted).Hours
        Dim mMinutesRunning As Integer = Now.Subtract(Me.SelectedTrailer.PrecoolStarted).Minutes

        If mDaysRunning > 0 Then mString += mDaysRunning.ToString & " DAYS "
        If mHoursRunning > 0 Then mString += mHoursRunning.ToString & " HOURS "
        If mMinutesRunning > 0 Then mString += mMinutesRunning.ToString & " MINUTES "

        Me.TimeRunningLabel.Text = mString
    End Sub
    Private Sub ClearDetailFields()
        Me.PreCoolingLabel.Visible = False
        Me.PrecoolPictureBox.Visible = False
        Me.POBLabel.Visible = False
        Me.SPLabel.Visible = False
        Me.BCLabel.Visible = False
        Me.LOCLabel.Visible = False
        Me.StartPrecoolButton.Enabled = False
        Me.StopPrecoolButton.Enabled = False
        Me.CancelRequestButton.Visible = False
        Me.StopUnitLabel.Visible = False

        For Each MyLabel As Control In Me.TrailerDetailsGroupBox.Controls
            If TypeOf (MyLabel) Is Label Then
                If MyLabel.Tag = "CLEAR" Then MyLabel.Text = ""
            End If
        Next
        With Me.Panel1.Controls("SelectTrailerPanel")
            .Visible = True
            .BringToFront()
        End With
    End Sub
    Private Sub BuildSelectTrailerPanel()
        Dim NewPanel As New Panel
        Dim NewLabel As New Label
        Dim NewLocation As New Point

        NewLocation = Me.TrailerDetailsGroupBox.Location
        NewLocation.X += 3
        NewLocation.Y += 20

        NewPanel.Name = "SelectTrailerPanel"
        NewPanel.Location = NewLocation
        NewPanel.Size = Me.TrailerDetailsGroupBox.Size
        NewPanel.Width -= 6
        NewPanel.Height -= 40
        NewPanel.BackColor = Color.White
        NewPanel.Visible = False

        NewLabel.Name = "SelectTrailerLabel"
        NewLabel.Text = "Select Trailer To See Details"
        NewLabel.TextAlign = ContentAlignment.MiddleCenter
        NewLabel.Font = New Font("Arial", 24, FontStyle.Bold, GraphicsUnit.Point)
        NewLabel.ForeColor = Color.DarkGray
        NewLabel.BackColor = Color.White
        NewLabel.Dock = DockStyle.Fill
        NewPanel.Controls.Add(NewLabel)
        Me.Panel1.Controls.Add(NewPanel)
    End Sub
    Private Sub SearchTrailerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchTrailerToolStripMenuItem.Click
        Me.SearchStyleToolStripDropDownButton.Text = "Search Trailer #"
        Me.SearchTypeToolStripDropDownButton.Visible = True
        Me.SearchToolStripTextBox.Focus()
    End Sub
    Private Sub SearchCarrierToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchCarrierToolStripMenuItem.Click
        Me.SearchStyleToolStripDropDownButton.Text = "Search Carrier"
        Me.SearchTypeToolStripDropDownButton.Visible = False
        Me.SearchToolStripTextBox.Focus()
    End Sub
    Private Sub SearchToolStripTextBox_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles SearchToolStripTextBox.KeyUp
        If e.KeyCode = Keys.Enter Then
            Me.SearchToolStripButton_Click(Me, New EventArgs)
        End If
    End Sub
    Private Sub CancelRequestButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelRequestButton.Click
        Dim ReqForm As New CancelPrecoolRequestForm(Me.MyUser, Me.SelectedTrailer.SystemID, Me.MyWS)
        AddHandler MyWS.CancelPrecoolTaskCompleted, AddressOf ReqForm.CancelPrecoolCompleted
        AddHandler ReqForm.PrecoolCancelled, AddressOf Me.CancelPrecoolCompleted
        ReqForm.ShowDialog()
        RemoveHandler MyWS.CancelPrecoolTaskCompleted, AddressOf ReqForm.CancelPrecoolCompleted
        RemoveHandler ReqForm.PrecoolCancelled, AddressOf Me.CancelPrecoolCompleted
    End Sub
    Private Sub StopPrecoolButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StopPrecoolButton.Click
        Try
            If MessageBox.Show("The unit will be TURNED OFF! Are you sure?", "Turn Off Unit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
                Me.SetSearchAmination(True)
                Me.StartPrecoolButton.Enabled = False
                Me.StopPrecoolButton.Enabled = False
                Me.CancelRequestButton.Enabled = False
                Me.MyWS.AddStopPrecoolTask("", Me.MyUser, Me.SelectedTrailer, "")
                Me.SelectedTrailer.StopRequested = True
                Me.ShowTrailerDetails()
                'CType(Me.TrailerTreeView.SelectedNode.Tag, KAR_Lot_SmartClient.karservices.cactus.smartclient.PreCoolTrailerTO).StopRequested = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Kar Lot", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Me.RefreshButtons()
            Me.SetSearchAmination(False)
        End Try
    End Sub
    Public Sub CancelPrecoolCompleted()
        Me.SelectedTrailer.Precooling = "0"
        Me.SelectedTrailer.PrecoolRequested = "0"
        Me.ShowTrailerDetails()
    End Sub

#Region " TreeView Code "
    Private Sub BuildTreeView()
        Dim mFoundIt As Boolean = False

        Me.TrailerTreeView.Nodes.Clear()
        Me.TrailerCount = 0

        For Each tTrailer As KAR_Lot_SmartClient.karservices.cactus.smartclient.PreCoolTrailerTO In Me.MyTrailers
            Me.TrailerCount += 1
            For Each tNode As TreeNode In Me.TrailerTreeView.Nodes
                If tTrailer.Carrier = tNode.Tag Then
                    mFoundIt = True
                    tNode.Nodes.Add(Me.GetNodeTrailer(tTrailer))
                    tNode.Text = tNode.Tag & " (" & tNode.Nodes.Count & ")"
                End If
            Next
            If mFoundIt = False Then ' Zone Node does not exist so build it here and add the first node
                Dim mZoneNode As TreeNode = Me.GetNodeZone(tTrailer.Carrier)
                mZoneNode.Text = mZoneNode.Tag & " (1)"
                mZoneNode.Nodes.Add(Me.GetNodeTrailer(tTrailer))
                Me.TrailerTreeView.Nodes.Add(mZoneNode)
            End If
            mFoundIt = False ' reset for next round
        Next

        Me.TrailerCountLabel.Text = Me.TrailerCount & " Trailer(s)"
    End Sub
    Private Function GetNodeTrailer(ByVal pTrailer As KAR_Lot_SmartClient.karservices.cactus.smartclient.PreCoolTrailerTO) As TreeNode
        Dim tNode As New TreeNode
        With tNode
            .Tag = pTrailer
            .Text = pTrailer.TrailerID
        End With

        Return tNode
    End Function
    Private Function GetNodeZone(ByVal pCarrier As String) As TreeNode
        Dim mNode As New TreeNode
        mNode.Text = pCarrier
        mNode.Tag = pCarrier
        Return mNode
    End Function
    Private Sub TrailerTreeView_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TrailerTreeView.AfterSelect
        Select Case e.Node.Level
            Case 1
                Me.SelectedTrailer = CType(e.Node.Tag, KAR_Lot_SmartClient.karservices.cactus.smartclient.PreCoolTrailerTO)
                Me.ShowTrailerDetails()
            Case Else
                Me.ClearDetailFields()
        End Select
    End Sub
#End Region

#End Region


End Class