Public Class TrailerRequest

#Region " Declarations "
    Dim MyWebService As New KAR_Lot_SmartClient.karservices.cactus.smartclient.kar_smartclient_webservice
    Dim TempGuid As Guid = Guid.NewGuid
    Dim Carriers() As KAR_Lot_SmartClient.karservices.cactus.smartclient.Carrier
    Dim Trailers() As KAR_Lot_SmartClient.karservices.cactus.smartclient.Trailer
    Dim IsLoading As Boolean = True
    Dim SelectedComboCarrier As String = ""
    Dim mPalletsOnBoard As String = ""
    Dim mLetUserClickAction As Boolean = True
    Private mTrailerSearchService As KlDispatchServices.TrailerSearchService
    Private mTempCalc As KlDispatchServices.Services.TemperatureConversionService = New KlDispatchServices.Services.TemperatureConversionService()
    Private mShowTempTextBoxAsCelsius As Boolean = False
#End Region

#Region " Form Methods "
    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub
    Private Sub TrailerRequest_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.ClearFields()

        Try
            Dim apiHeader As New KlDispatchServices.ViewModels.Services.KarLotApiHeader(My.Settings.ApiKey)
            Me.mTrailerSearchService = New KlDispatchServices.TrailerSearchService(My.Settings.ApiBaseURL, apiHeader)
        Catch ex As Exception
            Throw New System.Exception("User application settings could not be read. The application may need to be re-installed.")
        End Try

        Me.MyWebService.Url = GlobalClass.KarCactusWeb.Url
        AddHandler MyWebService.GetActiveCarriersCompleted, AddressOf Me.GetCarriersCompleted
        AddHandler MyWebService.GetActiveTrailersByScacCompleted, AddressOf Me.GetTrailersCompleted
        AddHandler MyWebService.CallTrailerMoveToDoorCompleted, AddressOf Me.CallTrailerComplete
        AddHandler MyWebService.GetActiveTrailersByTrailerIDCompleted, AddressOf GetTrailersByTrailerIDComplete
        Me.GetCarriers()
    End Sub
    Private Sub ClearFields()
        Me.ShowCarrierNameLabel.Text = ""
        Me.ShowTrailerIDLabel.Text = ""
        Me.LoadStatusLabel.Text = ""
        Me.CurrentLocationLabel.Text = ""
        Me.PalletsOnBoardLabel.Text = ""
        Me.CurrentTemperatureLabel.Text = ""
        Me.TempTextBox.Text = ""
        Me.NoPalletsRadioButton.Checked = False
        Me.ChepPalletsRadioButton.Checked = False
        Me.HeatTreatedPalletsRadioButton.Checked = False
        Me.WhitePalletsRadioButton.Checked = False
        Me.SelectedPallets = ""
        Me.MoveStatusLabel.Text = ""
        Me.ClassLabel.Text = ""
        Me.OOSLabel.Visible = False
        Me.OOSLabelNotes.Text = ""
        Me.PalletLoadLabel.Text = ""
        Me.SetTempPreviewC.Text = ""
        Me.SetTempPreviewF.Text = ""
        Me.TrailerTypeLabel.Text = ""
    End Sub
    Private Sub CarrierComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CarrierComboBox.SelectedIndexChanged
        If Me.IsLoading = True Then Exit Sub
        Try
            Me.Cursor = Cursors.WaitCursor
            Me.SelectedComboCarrier = Me.GetComboCarrierName(Me.CarrierComboBox.SelectedItem)
            Me.GetTrailers(Me.CarrierComboBox.SelectedValue.ToString)
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show("An error occured loading the trailers for this carrier. There was a problem connecting to the server, please try again. If you continue getting this error contact tech support.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub
    Private Sub TrailersListBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrailersListBox.SelectedIndexChanged
        If Me.TrailersListBox.SelectedItem IsNot Nothing Then Me.ShowTrailer(Me.TrailersListBox.SelectedItem)
    End Sub
    Private Sub ShowPrecoolStatus(ByVal pStatus As String)
        If pStatus = "1" Then
            Me.PreCoolingLabel.Visible = True
            Me.PrecoolStartedLabel.Visible = False ' FUTURE USE. GOING TO SHOW HOW LONG UNIT HAS BEEN RUNNING
        Else
            Me.PreCoolingLabel.Visible = False
            Me.PrecoolStartedLabel.Visible = False
        End If
    End Sub
    Private Sub ShowTrailer(ByVal Trailer As KAR_Lot_SmartClient.karservices.cactus.smartclient.Trailer)
        Try
            Me.ClearFields()
            If Trailer.Temperature = "NA" Then
                Me.mTempCalc = New KlDispatchServices.Services.TemperatureConversionService()
            Else
                Dim tempF As Int32 = Convert.ToInt32(Convert.ToDouble(Trailer.Temperature))
                Try
                    Me.mTempCalc = New KlDispatchServices.Services.TemperatureConversionService(tempF, Trailer.SetPointCelsius)
                Catch ex As Exception
                    ' Trailer has inconsitent temperature settings. Set based on legacy temp field
                    Me.mTempCalc = New KlDispatchServices.Services.TemperatureConversionService(tempF, -100)
                End Try
            End If

            Me.SetTempPreviewF.Text = String.Format("{0}F", Me.mTempCalc.FahrenheitString)
            Me.SetTempPreviewC.Text = String.Format("{0}C", Me.mTempCalc.CelsiusString)

            Me.ShowPrecoolStatus(Trailer.PreCooling)
            Me.mPalletsOnBoard = Trailer.PalletsOnBoard

            Select Case Trailer.MoveStatus
                Case "N", "Parked on Lot"
                    Me.ActionButton.Enabled = True
                    Me.mLetUserClickAction = True
                Case Else
                    Me.ActionButton.Enabled = False
                    Me.mLetUserClickAction = False
            End Select

            ' SETUP NEW SETPOINT TEXTBOX
            Select Case Trailer.TrailerType.ToUpper
                Case "V" ' DRY VANS
                    Me.TempTextBox.Visible = False
                    Me.TemperatureGroupBox.Enabled = False
                    Me.SetPointGroupBox.Enabled = False
                    Me.TrailerTypeLabel.Text = "V"
                Case Else ' ALL OTHER
                    Me.SetPointGroupBox.Enabled = True
                    Me.TrailerTypeLabel.Text = "R"
                    Select Case Trailer.Classification.ToUpper
                        Case "L", "D"
                            Me.TempTextBox.Visible = False
                            Me.TemperatureGroupBox.Enabled = False
                        Case Else
                            Me.TempTextBox.Visible = True
                            Me.TemperatureGroupBox.Enabled = True
                    End Select

            End Select

            '' DISABLE PALLET CHANGING FOR LOADED TRAILERS
            'Select Case Trailer.Load.dbCode
            '    Case "F", "P"
            '        Me.ChangePalletsCheckbox.Enabled = False
            '        Me.NewPalletsGroupBox.Enabled = False
            '    Case Else
            '        Me.ChangePalletsCheckbox.Enabled = True
            '        Me.NewPalletsGroupBox.Enabled = True
            'End Select

            ' SET THE PALLET RADIO BUTTONS ACCORDING TO THE CURRENT PALLET TYPE
            Me.LoadStatusLabel.Text = Trailer.Load.LoadStatusMessage
            Select Case Trailer.PalletsOnBoard
                Case "Chep", "CHEP"
                    Me.ChepPalletsRadioButton.Checked = True
                Case "White", "WHITE", "Plain White"
                    Me.WhitePalletsRadioButton.Checked = True
                Case "None"
                    Me.NoPalletsRadioButton.Checked = True
                Case "HeatTreated", "HEATTREATED", "White Heat Treated"
                    Me.HeatTreatedPalletsRadioButton.Checked = True
            End Select

            ' apply feature flag settings to ui
            Me.LegacyPalletGroupBox.Visible = My.Settings.ViewLegacyPalletInfoOnDockCallin

            If My.Settings.ViewPalletLoadDataOnDockCallin And Trailer.Classification.ToUpper = "L" Then
                Me.PalletLoadGroupBox.Visible = True
            Else
                Me.PalletLoadGroupBox.Visible = False
            End If

            ' set pallet value
            Me.PalletLoadLabel.Text = Trailer.Pallets

            If Me.mTempCalc.FahrenheitString = "--" Then
                Me.CurrentTemperatureLabel.Text = "NOT SET"
            Else
                If Me.mShowTempTextBoxAsCelsius = True Then
                    Me.TempTextBox.Text = mTempCalc.CelsiusString
                Else
                    Me.TempTextBox.Text = mTempCalc.FahrenheitString
                End If
                Me.CurrentTemperatureLabel.Text = String.Format("{0}F ({1}C)", mTempCalc.FahrenheitString, mTempCalc.CelsiusString)
            End If
            Me.PalletsOnBoardLabel.Text = Trailer.PalletsOnBoard
            If Trailer.CurrentLocation = "NA" Then
                Me.CurrentLocationLabel.Text = "UNKNOWN"
            Else
                Me.CurrentLocationLabel.Text = Trailer.CurrentLocation
            End If
            Me.MoveStatusLabel.Text = Trailer.MoveStatus
            If String.IsNullOrEmpty(Trailer.LoadNumber) Then
                Me.LoadNumberLabelHeader.Visible = False
                Me.LoadNumberLabel.Visible = False
                Me.LoadNumberLabel.Text = String.Empty
            Else
                Me.LoadNumberLabelHeader.Visible = True
                Me.LoadNumberLabel.Visible = True
                Me.LoadNumberLabel.Text = Trailer.LoadNumber
            End If
            Me.InstructionsTextBox.Text = "NONE"
            Me.ShowTrailerIDLabel.Text = Trailer.TrailerID
            Me.ClassLabel.Text = Me.GetClassificationText(Trailer.Classification)
            If Trailer.Carrier.Name.Trim.Length = 0 Then
                Me.ShowCarrierNameLabel.Text = Me.SelectedComboCarrier
            Else
                Me.ShowCarrierNameLabel.Text = Trailer.Carrier.Name
            End If

            If Trailer.OutOfService Then
                Me.OOSLabel.Visible = True
                Me.OOSLabelNotes.Text = Trailer.Notes
                ' Override and disable user action button for out of service trailers
                Me.ActionButton.Enabled = False
                Me.mLetUserClickAction = False
            Else
                Me.OOSLabel.Visible = False
            End If
        Catch ex As Exception
            MessageBox.Show(String.Format("Error: {0}", ex.Message), "Problem showing trailer info", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End Try
    End Sub
    Private Function GetClassificationText(ByVal pCode As String) As String
        Select Case pCode
            Case "E"
                Return "Refrigerated Trailer"

            Case "L"
                Return "Pallet Trailer"

            Case "D"
                Return "Inbound Product"

            Case "O"
                Return "Out of Service"

            Case "B"
                Return "Babysitter"

            Case "P"
                Return "Inbound Partial"

            Case Else
                Return pCode
        End Select
    End Function
    Private Function VerifyFields(ByVal pTrailerType As String, ByVal pClass As String) As Boolean
        If Me.UserInitialsTextBox.Text.Trim.Length <> 2 Then
            MessageBox.Show("Your first and last initials are required.", "Initials required", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1)
            Return False
        End If

        Select Case pTrailerType
            Case "V" ' DRY VAN
                ' no setpoint for dry van trailers. Just clear set point values
                Me.mTempCalc = New KlDispatchServices.Services.TemperatureConversionService()

            Case Else ' ALL OTHERS

                Select Case pClass.ToUpper
                    Case "L", "D"  ' Supplies or Pallets
                        ' some load classes will need a temperature set. If the temp textbox is visible user has supplied temp
                        If Me.TempTextBox.Visible = False Then
                            ' no setpoint for these load classes. Just clear set point values
                            Me.mTempCalc = New KlDispatchServices.Services.TemperatureConversionService()
                        End If
                    Case Else ' TEMP REQUIRED
                        If Me.TempTextBox.Text.Trim.Length = 0 Then
                            MessageBox.Show("You must enter a temperature first.", "Temperature Set Point", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1)
                            Return False
                        End If
                        Try
                            If Me.mTempCalc.FahrenheitString = "--" Then
                                Throw New Exception("Valid temperature set point is required.")
                            End If
                        Catch ex As Exception
                            MessageBox.Show("Check the temperature you entered.", "Temperature Set Point", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1)
                            Return False
                        End Try
                        If Me.mTempCalc.Fahrenheit < -35 Then
                            MessageBox.Show("Check the temperature you entered.", "Temperature Set Point", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1)
                            Return False
                        End If
                        If Me.mTempCalc.Fahrenheit > 80 Then
                            MessageBox.Show("Check the temperature you entered.", "Temperature Set Point", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1)
                            Return False
                        End If
                End Select
        End Select

        ' IF LEGACY PALLETS ARE NOT KNOWN SET TO NONE
        If Me.mPalletsOnBoard.ToUpper = "UNKNOWN" Then
            If Me.ChangePalletsCheckbox.Checked = False Then
                Me.SelectedPallets = "None"
            End If
        End If

        If Me.ChangePalletsCheckbox.Checked = True Then
            If Me.SelectedPallets = "" Then
                MessageBox.Show("You must select the type of pallets you want on this trailer, if any." & vbCrLf & vbCrLf & "If you do not want pallets then choose NONE. Driver will remove any pallets on the trailer.", "Choose Pallets", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1)
                Return False
            End If
        Else
            Me.SelectedPallets = Me.mPalletsOnBoard
        End If

        Return True
    End Function
    Private Sub NoPalletsRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NoPalletsRadioButton.CheckedChanged
        If Me.NoPalletsRadioButton.Checked = True Then Me.SelectedPallets = "None"
    End Sub
    Private Sub ChepPalletsRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChepPalletsRadioButton.CheckedChanged
        If Me.ChepPalletsRadioButton.Checked = True Then Me.SelectedPallets = "Chep"
    End Sub
    Private Sub WhitePalletsRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WhitePalletsRadioButton.CheckedChanged
        If Me.WhitePalletsRadioButton.Checked = True Then Me.SelectedPallets = "Plain White"
    End Sub
    Private Sub HeatTreatedPalletsRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HeatTreatedPalletsRadioButton.CheckedChanged
        If Me.HeatTreatedPalletsRadioButton.Checked = True Then Me.SelectedPallets = "White Heat Treated"
    End Sub
    Private Sub ActionButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActionButton.Click
        Me.Cursor = Cursors.WaitCursor
        Me.ActionButton.Enabled = False
        Me.CloseButton.Enabled = False

        Dim Tr As KarLotTrailer.karlot.Trailer = MainForm.Convert2Trailer(Me.TrailersListBox.SelectedItem)
        Dim pPriorityMove As Boolean = False

        If Me.VerifyFields(Tr.TrailerType, Tr.Classification) = True Then
            TempGuid = Guid.NewGuid
            If Tr.Carrier.Name.Trim.Length = 0 Then
                Tr.Carrier.Name = Me.SelectedComboCarrier
            End If
            ' set the verified set point values or default value for no temp required
            Tr.Temperature = IIf(Me.mTempCalc.FahrenheitString = "--", "-100", Me.mTempCalc.FahrenheitString)
            Tr.SetPointCelsius = IIf(Me.mTempCalc.CelsiusString = "--", -100.0R, Me.mTempCalc.Celsius)
            Try
                ' SET SPECIAL INSTRUCTIONS PROPERTY OF THE TRAILER OBJECT
                If Me.InstructionsTextBox.Text.Trim = "" Then
                    Tr.SpecialInstructions = "Initialed By: " & Me.UserInitialsTextBox.Text.Trim
                Else
                    Tr.SpecialInstructions = Me.InstructionsTextBox.Text.Trim.ToUpper & " - Initialed By: " & Me.UserInitialsTextBox.Text.Trim
                End If
                ' SET PRIORITY FLAG
                If Me.PriorityCheckBox.Checked = True Then pPriorityMove = True
                ' CALL THE WEB SERVICE
                MyWebService.CallTrailerMoveToDoorAsync(MainForm.Convert2WebTrailer(Tr), Tr.Temperature, Me.SelectedPallets, GlobalClass.MyUser.UserName, My.Settings.StationID, Me.DoorLabel.Text.Trim, "NA", Tr.SpecialInstructions, pPriorityMove, UserInitialsTextBox.Text.Trim, TempGuid)
            Catch ex As Exception
                Me.ActionButton.Enabled = Me.mLetUserClickAction
                Me.CloseButton.Enabled = True
                Me.Cursor = Cursors.Default
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End Try
        Else
            Me.Cursor = Cursors.Default
            Me.ActionButton.Enabled = Me.mLetUserClickAction
            Me.CloseButton.Enabled = True
            'MessageBox.Show(GlobalClass.FieldsNotValidMessage, "Check Fields", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End If
    End Sub
#End Region

#Region " Web Service Code "
    Private Sub GetCarriers()
        Me.Cursor = Cursors.WaitCursor
        TempGuid = New Guid
        Me.MyWebService.GetActiveCarriersAsync(TempGuid)
    End Sub
    Private Sub GetCarriersCompleted(ByVal sender As Object, ByVal e As KAR_Lot_SmartClient.karservices.cactus.smartclient.GetActiveCarriersCompletedEventArgs)
        Try
            Carriers = e.Result
            Me.CarrierComboBox.DataSource = Carriers
            Me.CarrierComboBox.DisplayMember = "Name"
            Me.CarrierComboBox.ValueMember = "Scac"
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show("An error occured loading the carriers. There may be a problem contacting the server. If you continue to get this message try restarting the program or contact tech support.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Me.Close()
        End Try
        ' LOAD THE TRAILERS FOR THE FIRST CARRIER IF THEIR IS ONE
        If Me.CarrierComboBox.Items.Count <= 0 Then
            Me.Cursor = Cursors.Default
            Exit Sub
        End If
        Try
            Me.Cursor = Cursors.WaitCursor
            Me.SelectedComboCarrier = GetComboCarrierName(Me.CarrierComboBox.SelectedItem)
            Me.GetTrailers(Me.CarrierComboBox.SelectedValue.ToString)
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show("An error occured loading the trailers. There may be a problem contacting the server. If you continue to get this message try restarting the program or contact tech support.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Me.Close()
        End Try
    End Sub
    Private Function GetComboCarrierName(ByVal pCarrier As KAR_Lot_SmartClient.karservices.cactus.smartclient.Carrier) As String
        If pCarrier IsNot Nothing Then
            Return pCarrier.Name
        Else
            Return ""
        End If
    End Function
    Private Sub GetTrailers(ByVal Scac As String)
        Me.MyWebService.CancelAsync(TempGuid)
        Me.MyWebService.GetActiveTrailersByScacAsync(Scac, TempGuid)
    End Sub
    Private Sub GetTrailersByTrailerID(ByVal pTrailerID As String)
        Me.MyWebService.CancelAsync(TempGuid)
        Me.MyWebService.GetActiveTrailersByTrailerIDAsync(pTrailerID, TempGuid)
    End Sub
    Private Sub GetTrailersCompleted(ByVal sender As Object, ByVal e As KAR_Lot_SmartClient.karservices.cactus.smartclient.GetActiveTrailersByScacCompletedEventArgs)
        Try
            Me.Trailers = e.Result
            Me.FillTrailersList()
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show("An error occured loading the trailers.  Try selecting another carrier or enter another trailer number. If you continue getting this error please contact tech support.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
        Me.IsLoading = False
    End Sub
    Private Sub GetTrailersBySearchApi(ByRef queryObject As KlDispatchServices.ViewModels.TrailerSearchViewModel)
        Me.IsLoading = True

        Try
            Dim results As KlDispatchServices.ViewModels.TrailerSearchResultViewModel
            results = Me.mTrailerSearchService.Search(queryObject, "trailers/search")
            Me.Trailers = ApiDataConverter.ConvertToWebServiceTrailer(results).ToArray()
            Me.FillTrailersList()

            If Me.Trailers.Length = 0 Then
                Dim msg As String
                msg = String.Format("No trailer with load number {0} was found.", Me.LoadNumberTextBox.Text.Trim())
                MessageBox.Show(msg, "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show("Error occured: Try closing the trailer request window and try again. If you continue getting this error please contact tech support.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try

        Me.FindByLoadNumberButton.Enabled = True
        Me.IsLoading = False
    End Sub
    Private Sub CallTrailerComplete(ByVal sender As Object, ByVal e As KAR_Lot_SmartClient.karservices.cactus.smartclient.CallTrailerMoveToDoorCompletedEventArgs)
        Me.Cursor = Cursors.Default
        Me.ActionButton.Enabled = True
        Me.CloseButton.Enabled = True
        Try
            If e.Error IsNot Nothing Then
                MessageBox.Show(e.Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            End If
            If e.Result = False Then
                MessageBox.Show("This trailer cannot be moved right now, There was a problem saving the information.", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Else
                MainForm.RefreshDoorData()
                Me.Close()
            End If
        Catch ex As Exception
            Me.Close()
        End Try
    End Sub
    Private Sub GetTrailersByTrailerIDComplete(ByVal sender As Object, ByVal e As KAR_Lot_SmartClient.karservices.cactus.smartclient.GetActiveTrailersByTrailerIDCompletedEventArgs)
        Me.FindTrailerIDButton.Enabled = True
        Try
            Me.Trailers = e.Result
            Me.FillTrailersList()
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show("An error occured loading the trailers.  Try selecting another carrier or enter another trailer number. If you continue getting this error please contact tech support.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
        Me.IsLoading = False
    End Sub
#End Region

#Region " Public Properties "
    Private m_DoorName As String
    Public Property DoorName() As String
        Get
            Return m_DoorName
        End Get
        Set(ByVal value As String)
            m_DoorName = value
            Me.DoorLabel.Text = value
        End Set
    End Property
    Private m_SelectedPallets As String = ""
    Public Property SelectedPallets() As String
        Get
            Return m_SelectedPallets
        End Get
        Set(ByVal value As String)
            m_SelectedPallets = value
        End Set
    End Property
#End Region

    Private Sub FillTrailersList()
        Me.TrailersListBox.DataSource = Me.Trailers
        Me.TrailersListBox.DisplayMember = "TrailerID"
        Me.TrailersListBox.ValueMember = "TrailerID"
        Me.Cursor = Cursors.Default
        Me.IsLoading = False
    End Sub
    Private Sub FindTrailerIDTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles FindTrailerIDTextBox.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            e.Handled = True
            Me.DoLookupByTrailerID()
        End If
    End Sub
    Private Sub DoLookupByTrailerID()
        Me.FindTrailerIDButton.Enabled = False
        If Me.FindTrailerIDTextBox.Text.Trim.Length > 0 Then
            Me.GetTrailersByTrailerID("%" & Me.FindTrailerIDTextBox.Text.Trim & "%")
        Else
            MessageBox.Show("You must enter a trailer number first.", "KAR Lot", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub FindTrailerIDButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindTrailerIDButton.Click
        Me.DoLookupByTrailerID()
    End Sub
    Private Sub FindByLoadNumberButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindByLoadNumberButton.Click
        Me.DoFindByLoadNumber()
    End Sub
    Private Sub DoFindByLoadNumber()
        Me.FindByLoadNumberButton.Enabled = False
        Dim searchObect As KlDispatchServices.ViewModels.TrailerSearchViewModel
        searchObect = New KlDispatchServices.ViewModels.TrailerSearchViewModel()
        Dim loadNums As List(Of String) = New List(Of String)
        loadNums.Add(Me.LoadNumberTextBox.Text.Trim)
        searchObect.LoadNumbers = loadNums
        Me.GetTrailersBySearchApi(searchObect)
    End Sub
    Private Sub ChangePalletsCheckbox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePalletsCheckbox.CheckedChanged
        If Me.ChangePalletsCheckbox.Checked = True Then
            Me.NewPalletsGroupBox.Enabled = True
        Else
            Me.NewPalletsGroupBox.Enabled = False
        End If
    End Sub

    Private Sub NotSetPointLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotSetPointLabel.Click
        Me.TempTextBox.Visible = True
        Me.TemperatureGroupBox.Enabled = True
        Me.TempTextBox.Focus()
    End Sub

    Private Sub LoadNumberTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles LoadNumberTextBox.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            e.Handled = True
            Me.DoFindByLoadNumber()
        End If
    End Sub

    Private Sub FahrenheitRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FahrenheitRadioButton.CheckedChanged
        If FahrenheitRadioButton.Checked = True Then
            Me.mShowTempTextBoxAsCelsius = False
            FahrenheitRadioButton.BackColor = Color.LimeGreen
            Me.TempTextBox.Text = Me.mTempCalc.FahrenheitString
        Else
            Me.mShowTempTextBoxAsCelsius = True
            FahrenheitRadioButton.BackColor = Color.Transparent
            Me.TempTextBox.Text = Me.mTempCalc.CelsiusString
        End If
    End Sub

    Private Sub CelsiusRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CelsiusRadioButton.CheckedChanged
        If CelsiusRadioButton.Checked = True Then
            Me.mShowTempTextBoxAsCelsius = True
            CelsiusRadioButton.BackColor = Color.LimeGreen
            Me.TempTextBox.Text = Me.mTempCalc.CelsiusString
        Else
            Me.mShowTempTextBoxAsCelsius = False
            CelsiusRadioButton.BackColor = Color.Transparent
            Me.TempTextBox.Text = Me.mTempCalc.FahrenheitString
        End If
    End Sub

    Private Sub TempTextBox_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TempTextBox.Leave
        Dim newTemp As Double? = Nothing

        Try
            If String.IsNullOrEmpty(Me.TempTextBox.Text) Then
                MessageBox.Show("Set point temperature is not valid.", "Set Point Problem", MessageBoxButtons.OK)
                Me.TempTextBox.Focus()
            Else
                newTemp = Convert.ToDouble(Me.TempTextBox.Text.Trim)
                If Me.mShowTempTextBoxAsCelsius = True Then
                    Me.mTempCalc.SetCelsius(newTemp)
                    Me.TempTextBox.Text = Me.mTempCalc.CelsiusString
                Else
                    Me.mTempCalc.SetFahrenheit(newTemp)
                    Me.TempTextBox.Text = Me.mTempCalc.FahrenheitString
                End If
                Me.SetTempPreviewF.Text = String.Format("{0}F", Me.mTempCalc.FahrenheitString)
                Me.SetTempPreviewC.Text = String.Format("{0}C", Me.mTempCalc.CelsiusString)
            End If
        Catch ex As Exception
            MessageBox.Show("Set point temperature is not valid.", "Set Point Problem", MessageBoxButtons.OK)
            Me.TempTextBox.Focus()
        End Try
    End Sub
End Class