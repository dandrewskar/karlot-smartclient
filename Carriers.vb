Public Class Carriers
    Dim MyCarriers As New KAR_Lot_SmartClient.karservices.cactus.smartclient.BarcodeDataSet
    Dim Myds As New KAR_Lot_SmartClient.DataServices
    Dim MyWS As New KAR_Lot_SmartClient.karservices.cactus.webservices.Service
    Dim mCarrierName As String
    Dim mTrailerID As String
    Dim mScac As String
    Dim mClass As String
    Dim mLoadStatus As String
    Dim mTrailerType As String
    Dim mBarcode As String
    Dim mUserID As String
    Dim mBuyers As Boolean

    Public Sub New(ByVal pWSurl As String, ByVal pUserID As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.MyWS.Url = pWSurl
        Me.mUserID = pUserID
    End Sub
    Private Sub Carriers_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.MessageToolStripStatusLabel.Text = ""
        MyCarriers = Myds.GetDataFromCache(DataServices.TableOptions.Carriers, True)
        Me.CarriersDataGridView.DataSource = MyCarriers
        Me.CarriersDataGridView.DataMember = "Carriers"
        Me.CarriersDataGridView.Refresh()
        Me.RecordCountToolStripStatusLabel.Text = Me.CarriersDataGridView.RowCount.ToString & " Carriers."
        Me.StatusStrip1.Renderer = MainForm.ToolStrip1.Renderer
        Me.SetupHandlers()
    End Sub

    Private Sub SetupHandlers()
        AddHandler MyWS.BarcodeLookupCompleted, AddressOf Me.LookupBarcodeDone
        AddHandler MyWS.NewInboundTrailerCompleted, AddressOf Me.SaveNewTrailerDone
    End Sub
    Private Sub TextBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ScacTextBox.GotFocus, CarriersNameTextBox.GotFocus
        Dim Box As TextBox = sender
        Box.BackColor = Color.LightYellow
        Me.HelpWindowLabel.Text = Box.Tag
    End Sub

    Private Sub TextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ScacTextBox.LostFocus, CarriersNameTextBox.LostFocus
        Dim Box As TextBox = sender
        Box.BackColor = Color.White
        Me.HelpWindowLabel.Text = Me.HelpWindowLabel.Tag
        Box.Text = Box.Text.ToUpper
    End Sub

    Private Sub SaveCarrierButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveCarrierButton.Click
        If VerifyFields() = False Then Exit Sub
        Me.MessageToolStripStatusLabel.Text = GlobalClass.SavingDataMessage
        Me.DoButtons(GlobalClass.ButtonModes.Saving)
        Me.Refresh()
        If GlobalClass.NetworkConnected Then
            Select Case GlobalClass.CurrentConnectionType
                Case GlobalClass.KarLotClientConnectionType.SerialPort
                    ' TODO: ADD CODE HERE TO ADD NEW CARRIER THROUGH A KAR RADIO CONNECTION
                Case GlobalClass.KarLotClientConnectionType.SQLServer2005
                    ' TODO: ADD CODE HERE TO ADD NEW CARRIER THROUGH A SQL SERVER 2005 CONNECTION
                Case Else
                    ' CONNECTION IS EITH THROUGH A LOCAL OR REMOTE WEB SERVICE
                    Dim TheReturn(2) As String
                    TheReturn = GlobalClass.KarCactusWebBasic.NewCarrier(Me.ScacTextBox.Text, Me.CarriersNameTextBox.Text)
                    If TheReturn(0) = "ERROR" Then
                        MainForm.AlertUser(TheReturn(2), MainForm.AlertMethod.ShowWithMessageBox)
                        Me.MessageToolStripStatusLabel.Text = TheReturn(2)
                    Else
                        Me.ScacTextBox.Text = ""
                        Me.CarriersNameTextBox.Text = ""
                        Me.MessageToolStripStatusLabel.Text = GlobalClass.DataSavedWithoutErrorMessage
                    End If
            End Select
        Else
            MessageBox.Show(GlobalClass.WorkingOfflineNoAction)
            Me.MessageToolStripStatusLabel.Text = ""
        End If
        Me.DoButtons(GlobalClass.ButtonModes.Normal)
    End Sub
    Private Function VerifyFields() As Boolean
        Dim Verify As Boolean = True
        Me.ScacTextBox.Text = Me.ScacTextBox.Text.Trim
        Me.CarriersNameTextBox.Text = Me.CarriersNameTextBox.Text.Trim
        If Me.ScacTextBox.Text.Length <> 4 Then
            Me.ScacTextBox.BackColor = Color.LightYellow
            Verify = False
        Else
            Me.ScacTextBox.Text = Me.ScacTextBox.Text.ToUpper
        End If
        If Me.CarriersNameTextBox.Text.Length = 0 Then
            Me.CarriersNameTextBox.BackColor = Color.LightYellow
            Verify = False
        Else
            Me.CarriersNameTextBox.Text = Me.CarriersNameTextBox.Text.ToUpper
        End If
        Me.MessageToolStripStatusLabel.Text = GlobalClass.FieldsNotValidMessage
        Return Verify
    End Function
    Private Sub DoButtons(ByVal State As GlobalClass.ButtonModes)
        Select Case State
            Case GlobalClass.ButtonModes.AllLocked
                Me.SaveCarrierButton.Enabled = False
            Case GlobalClass.ButtonModes.Normal
                Me.SaveCarrierButton.Enabled = True
            Case GlobalClass.ButtonModes.Editing
                Me.SaveCarrierButton.Enabled = True
            Case GlobalClass.ButtonModes.Saving
                Me.SaveCarrierButton.Enabled = False
        End Select
    End Sub

    Private Sub ClearNewCarrierFields()
        Me.ScacTextBox.Text = ""
        Me.CarriersNameTextBox.Text = ""
    End Sub

    Private Sub AddCarrierTabPage_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddCarrierTabPage.Enter
        Me.ClearNewCarrierFields()
    End Sub

#Region " WIZARD CODE "
    Private Sub AddTrailerBarcodeWizardPage_ShowFromNext(ByVal sender As Object, ByVal e As System.EventArgs) Handles AddTrailerBarcodeWizardPage.ShowFromNext
        Me.BarcodeLookopTextBox.Text = ""
        Me.BarcodeLookopTextBox.Focus()
    End Sub
    Private Sub LookupBarcodeWizardPage_ShowFromBack(ByVal sender As Object, ByVal e As System.EventArgs) Handles LookupBarcodeWizardPage.ShowFromBack
        Me.AddTrailerWizard1.BackTo(AddTrailerBarcodeWizardPage)
    End Sub
    Private Sub LookupBarcodeWizardPage_ShowFromNext(ByVal sender As Object, ByVal e As System.EventArgs) Handles LookupBarcodeWizardPage.ShowFromNext
        Me.DisableAllWizardButtons()
        Me.TrailerInfoProgressBar.Style = ProgressBarStyle.Marquee
        Me.mBarcode = Me.BarcodeLookopTextBox.Text.Trim
        Me.MyWS.BarcodeLookupAsync(Me.mBarcode)
    End Sub
    Private Sub LookupBarcodeDone(ByVal sender As Object, ByVal e As KAR_Lot_SmartClient.karservices.cactus.webservices.BarcodeLookupCompletedEventArgs)
        If e.Cancelled Then Exit Sub

        If e.Error IsNot Nothing Then
            MessageBox.Show(e.Error.Message)
            Me.EnableAllWizardButtons()
            Exit Sub
        End If

        Try
            Me.mCarrierName = e.Result(2).Trim
            Me.mTrailerID = e.Result(1).Trim
            Me.mScac = e.Result(0).Trim

            If mScac = "NO RECORD FOUND" Then Throw New Exception("Barcode is not active. Activate the barcode before you add the trailer.")
            Me.AddTrailerWizard1.NextTo(AddTRailerWizardPage3)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Me.EnableAllWizardButtons()
            Me.AddTrailerWizard1.BackTo(AddTrailerBarcodeWizardPage)
        End Try
    End Sub
    Private Sub EnableAllWizardButtons()
        Me.AddTrailerWizard1.CancelEnabled = True
        Me.AddTrailerWizard1.NextEnabled = True
        Me.AddTrailerWizard1.BackEnabled = True
    End Sub
    Private Sub DisableAllWizardButtons()
        Me.AddTrailerWizard1.CancelEnabled = False
        Me.AddTrailerWizard1.NextEnabled = False
        Me.AddTrailerWizard1.BackEnabled = False
    End Sub
    Private Sub AddTRailerWizardPage3_ShowFromNext(ByVal sender As Object, ByVal e As System.EventArgs) Handles AddTRailerWizardPage3.ShowFromNext
        Me.CarrierNameLabel.Text = mCarrierName
        Me.TrailerIDLabel.Text = mTrailerID
        Me.EnableAllWizardButtons()
        Me.SetTrailerDefaults()
    End Sub
    Private Sub SetTrailerDefaults()
        ' DEFAULTS
        Me.mLoadStatus = "D"
        Me.mClass = "E"
        Me.mTrailerType = "R"
        Me.EmptyDirtRadioButton.Checked = True
        Me.EmptyReferRadioButton.Checked = True
        Me.ReferTRailerRadioButton.Checked = True
    End Sub
    Private Sub SaveTrailerDataWizardPage_ShowFromNext(ByVal sender As Object, ByVal e As System.EventArgs) Handles SaveTrailerDataWizardPage.ShowFromNext
        Me.DisableAllWizardButtons()

        Try
            If Me.MyWS.CheckIfTrailerActive(Me.mScac, Me.mTrailerID) Then
                MessageBox.Show("This trailer is already active. Check the barcode and try again...")
                Me.AddTrailerWizard1.Back()
                Exit Sub
            Else
                Me.MyWS.NewInboundTrailerAsync(mBarcode, Me.mScac, Me.mTrailerID, Me.mLoadStatus, Me.mClass, "Parked on Lot", "NA", "P", "E", Now, Me.mUserID, Now, Me.mUserID, Me.mTrailerType, Me.mBuyers)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Me.EnableAllWizardButtons()
            Me.AddTrailerWizard1.Back()
        End Try

    End Sub
    Private Sub SaveNewTrailerDone(ByVal sender As Object, ByVal e As KAR_Lot_SmartClient.karservices.cactus.webservices.NewInboundTrailerCompletedEventArgs)
        If e.Cancelled Then
            Me.EnableAllWizardButtons()
            Me.AddTrailerWizard1.Back()
            Exit Sub
        End If

        If e.Error IsNot Nothing Then
            MessageBox.Show(e.Error.Message)
            Me.EnableAllWizardButtons()
            Me.AddTrailerWizard1.Back()
            Exit Sub
        End If

        Try
            Me.AddTrailerWizard1.BackEnabled = False
            Me.AddTrailerWizard1.CancelEnabled = False
            Me.AddTrailerWizard1.Next()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Me.EnableAllWizardButtons()
            Me.AddTrailerWizard1.Back()
            Exit Sub
        End Try
    End Sub
#End Region

#Region " WIZARD UI CODE "
    Private Sub EmptyReferRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmptyReferRadioButton.CheckedChanged
        If Me.EmptyReferRadioButton.Checked Then Me.mClass = Me.EmptyReferRadioButton.Tag
    End Sub
    Private Sub PalletTrailerRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PalletTrailerRadioButton.CheckedChanged
        If Me.PalletTrailerRadioButton.Checked Then Me.mClass = Me.PalletTrailerRadioButton.Tag
    End Sub
    Private Sub PartialInboundRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PartialInboundRadioButton.CheckedChanged
        If Me.PartialInboundRadioButton.Checked Then
            Me.mClass = Me.PartialInboundRadioButton.Tag
            Me.PartialLoadRadioButton.Checked = True
        End If
    End Sub
    Private Sub BabysitterRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BabysitterRadioButton.CheckedChanged
        If Me.BabysitterRadioButton.Checked Then
            Me.mClass = Me.BabysitterRadioButton.Tag
            Me.CompleteLoadRadioButton.Checked = True
        End If
    End Sub
    Private Sub SupplyTrailerRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupplyTrailerRadioButton.CheckedChanged
        If Me.SupplyTrailerRadioButton.Checked Then
            Me.mClass = Me.SupplyTrailerRadioButton.Tag
            Me.CompleteLoadRadioButton.Checked = True
        End If
    End Sub
    Private Sub EmptyDirtRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmptyDirtRadioButton.CheckedChanged
        If Me.EmptyDirtRadioButton.Checked Then Me.mLoadStatus = "D"
    End Sub
    Private Sub EmptyCleanRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmptyCleanRadioButton.CheckedChanged
        If Me.EmptyCleanRadioButton.Checked Then Me.mLoadStatus = "E"
    End Sub
    Private Sub PartialLoadRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PartialLoadRadioButton.CheckedChanged
        If Me.PartialLoadRadioButton.Checked Then Me.mLoadStatus = "P"
    End Sub
    Private Sub CompleteLoadRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompleteLoadRadioButton.CheckedChanged
        If Me.CompleteLoadRadioButton.Checked Then Me.mLoadStatus = "F"
    End Sub
    Private Sub ReferTRailerRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReferTRailerRadioButton.CheckedChanged
        If Me.ReferTRailerRadioButton.Checked Then Me.mTrailerType = "R"
    End Sub
    Private Sub DryVanRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DryVanRadioButton.CheckedChanged
        If Me.DryVanRadioButton.Checked Then Me.mTrailerType = "V"
    End Sub
    Private Sub BuyersCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuyersCheckBox.CheckedChanged
        Me.mBuyers = Me.BuyersCheckBox.Checked
    End Sub
#End Region

End Class