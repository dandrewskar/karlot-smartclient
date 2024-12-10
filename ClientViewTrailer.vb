Imports KAR_Lot_SmartClient.GlobalClass

Public Class ClientViewTrailer

#Region " Declarations "
    Enum DropLocType
        Door = 0
        Lot = 1
        Wash = 2
    End Enum
    Enum ViewModeTypes
        CallOutDoor = 0
        ViewInfo = 2
    End Enum
    Private MyWebService As New KAR_Lot_SmartClient.karservices.cactus.smartclient.kar_smartclient_webservice
    Private MyTrailer As New KAR_Lot_SmartClient.karservices.cactus.smartclient.Trailer
    Dim WithEvents CallOutLocationsForm As CallOutLocations
    Dim MyGuid As New Guid
    Dim mNewClassification As String = ""
    Dim mReferUnitModeDefault = "Continuous Mode"
    Dim mReferUnitModeDryVanDefault = ""
    Private mTempCalc As New KlDispatchServices.Services.TemperatureConversionService()
#End Region

#Region " Form Con/Destruct Related Methods "
    Public Sub New(ByVal webserviceUri As Uri)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.MyWebService.Url = webserviceUri.ToString
    End Sub
    Private Sub ClientViewTrailer_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub
    Private Sub ClientViewTrailer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        AddHandler MyWebService.CallTrailerMoveOutDoorToLotCompleted, AddressOf Me.CallOutComplete
        AddHandler MyWebService.CallTrailerMoveOutDoorToDoorCompleted, AddressOf Me.DoorToDoorComplete
        Me.Height = 700
        Me.Width = 700

        ' DEFAULT VALUES
        Me.NewLoadStatus = "F"

        ' Setup form defaults for feture flags here
        Me.ApplyPalletFeatureFlags()
    End Sub
#End Region

#Region " Public Properties "
    Private m_DropLocation As String = ""
    Public Property DropLocation() As String
        Get
            Return m_DropLocation
        End Get
        Set(ByVal value As String)
            m_DropLocation = value
        End Set
    End Property
    Private m_ViewMode As ViewModeTypes
    Public Property ViewMode() As ViewModeTypes
        Get
            Return m_ViewMode
        End Get
        Set(ByVal value As ViewModeTypes)
            m_ViewMode = value
        End Set
    End Property

    Private m_NewLoadStatus As String = "F"
    Public Property NewLoadStatus() As String
        Get
            Return m_NewLoadStatus
        End Get
        Set(ByVal value As String)
            m_NewLoadStatus = value
        End Set
    End Property

    Private m_DropType As KAR_Lot_SmartClient.karservices.cactus.smartclient.DropDestType
    Public Property DropType() As KAR_Lot_SmartClient.karservices.cactus.smartclient.DropDestType
        Get
            Return m_DropType
        End Get
        Set(ByVal value As KAR_Lot_SmartClient.karservices.cactus.smartclient.DropDestType)
            m_DropType = value
        End Set
    End Property

    Private m_ThirdLocation As String = "NA"
    Public Property ThirdLocation() As String
        Get
            Return m_ThirdLocation
        End Get
        Set(ByVal value As String)
            m_ThirdLocation = value
        End Set
    End Property

    Private m_IsWaiting As Boolean = False
    Public Property IsWaiting() As Boolean
        Get
            Return m_IsWaiting
        End Get
        Set(ByVal value As Boolean)
            m_IsWaiting = value
        End Set
    End Property

#End Region

#Region " Form Methods "
    Public Sub ShowTrailer(ByVal Trailer As KarLotTrailer.karlot.Trailer)
        Dim MytTO As New KarLotTrailer.karlot.TrailerBO

        Me.MyTrailer = MainForm.Convert2WebTrailer(Trailer)
        ' SET THE DROP LOCATION PROPERTY TO THE NEXT LOCATION
        ' WE WILL PULL IT FROM THIS PROPERTY WHEN WE PARK THE TRAILER
        ' THE USER MAY CHANGE WHERE IT IS PARKED BUT WE WILL START
        ' WITH THE NEXT LOCATION AS THE DEFAULT
        Me.DropLocation = Me.MyTrailer.NextLocation
        Me.ClearFormFields()
        Me.CarrierNameLabel.Text = Trailer.Carrier.Name
        Me.CurrentLocationLabel.Text = Trailer.CurrentLocation
        Me.LoadStatusLabel.Text = Trailer.Load.LoadStatusMessage
        Me.SpecialInstructionsTextBox.Text = ""
        Me.TrailerIDLabel.Text = Trailer.TrailerID
        Me.TempLabel.Text = IIf(Trailer.Temperature.ToUpper = "NA", "", Trailer.Temperature)
        Me.PalletsOnBoardLabel.Text = Trailer.PalletsOnBoard
        Me.PalletsRequestedLabel.Text = Trailer.PalletsRequested
        Me.ClassificationLabel.Text = MytTO.GetClassificationText(Trailer.Classification)
        Me.ClassPalletsLabel.Text = Trailer.PalletsOnBoard
        Me.Seal1TextBox.Text = Trailer.Seal1
        Me.Seal2TextBox.Text = Trailer.Seal2
        Me.Seal3TextBox.Text = Trailer.Seal3
        Me.LoadNumberTextBox.Text = Trailer.LoadNumber
        Try
            Dim fTemp As String = Convert.ToInt32(Convert.ToDouble(Trailer.Temperature))
            Me.mTempCalc = New KlDispatchServices.Services.TemperatureConversionService(fTemp, Trailer.SetPointCelsius)
            Me.SetPointAssignedLabel.Text = String.Format("{0}F ({1}C)", mTempCalc.FahrenheitString, mTempCalc.CelsiusString)
        Catch ex As Exception
            Me.mTempCalc = New KlDispatchServices.Services.TemperatureConversionService()
            Me.SetPointAssignedLabel.Text = "--"
        End Try

        Me.SetClassView(Trailer)
        Try
            Me.TrailerPictureBox.Image = Me.TrailerImageList.Images.Item(Trailer.Load.dbCode)
        Catch ex As Exception
            Me.TrailerPictureBox.Image = Nothing
        End Try
        Me.DoLoadDesriptionText()
        Me.SetViewMode()
        Me.ShowDialog()
    End Sub
    Private Sub SetClassView(ByVal Trailer As KarLotTrailer.karlot.Trailer)
        Select Case Trailer.TrailerType
            Case "R", "U" ' REFRIGERATED TRAILER
                Me.TrailerTypeLabel.Text = "REFRIGERATION TRAILER"
                Select Case Trailer.Classification
                    Case "L", "D" ' NO TEMPS
                        Me.ApplyLegacyPalletFeatureFlags()
                        Me.ClassGroupBox.Visible = True
                        Me.ClassGroupBox.Location = Me.TempGroupBox.Location
                        Me.TempGroupBox.Visible = False
                    Case "E", "O", "B", "P" ' THESE WILL HAVE TEMPS
                        Me.ApplyLegacyPalletFeatureFlags()
                        Me.ClassGroupBox.Visible = False
                        Me.TempGroupBox.Visible = True
                End Select
                Me.ReferClassRadioButton.Enabled = True
                Me.ReferUnitModeComboBox.Text = mReferUnitModeDefault
                Me.ReferUnitModeComboBox.Visible = True
                Me.PPWillWatchLabel.ForeColor = Color.Red
            Case "V" ' DRY VAN
                Me.TrailerTypeLabel.Text = "DRY VAN"
                Me.ApplyLegacyPalletFeatureFlags()
                Me.ClassGroupBox.Visible = True
                Me.ClassGroupBox.Location = Me.TempGroupBox.Location
                Me.TempGroupBox.Visible = False
                Me.ReferClassRadioButton.Enabled = False
                Me.ReferUnitModeComboBox.Visible = False
                Me.ReferUnitModeComboBox.Text = mReferUnitModeDryVanDefault
                Me.PPWillWatchLabel.ForeColor = Color.Gray
        End Select
    End Sub

    Private Sub ClearFormFields()
        Me.CarrierNameLabel.Text = ""
        Me.CurrentLocationLabel.Text = ""
        Me.LoadStatusLabel.Text = ""
        Me.MoveInfoLabel.Text = ""
        Me.TrailerIDLabel.Text = ""
        Me.TempLabel.Text = ""
        Me.PalletsOnBoardLabel.Text = ""
        Me.PalletsRequestedLabel.Text = ""
        Me.SpecialInstructionsTextBox.Text = ""
        Me.Seal1TextBox.Text = ""
        Me.Seal2TextBox.Text = ""
        Me.Seal3TextBox.Text = ""
        Me.LoadNumberTextBox.Text = ""
        Me.PalletsComboBox.Text = "None"
    End Sub
    Private Sub SetViewMode()
        Select Case Me.MyTrailer.MoveStatus
            Case "In Door" ' IN DOOR. DO CALL OUT
                Me.ViewMode = ViewModeTypes.CallOutDoor
                ' DEFAULT NEXT LOCATION TO LOT AND LOAD STATUS TO COMPLETE
                Me.MoveInfoLabel.Text = "LOT"
                Me.DropLocation = "LOT"
                Me.ThirdLocationLabel.Text = "NONE"
                Me.ThirdLocation = "NA"
                Me.NewLoadStatus = KarLotTrailer.karlot.TrailerLoadClass.LoadStatusType.CompleteLoad
                Me.NewStatusPictureBox.Image = Me.TrailerImageList.Images("F")
                Me.LoadStatusGroupBox.Visible = True
                Me.CompleteLoadRadioButton.Checked = True
                Me.ActionButton.Text = "Call Out"
            Case Else
                Me.ViewMode = ViewModeTypes.ViewInfo
                Me.MoveInfoLabel.Text = Me.MyTrailer.NextLocation
                Me.LoadStatusGroupBox.Visible = False
                Me.ActionButton.Text = "OK"
        End Select
    End Sub
    Private Sub SetThirdLocation(ByVal Loc As String, ByVal NewDropType As KAR_Lot_SmartClient.karservices.cactus.smartclient.DropDestType)
        Select Case NewDropType
            Case karservices.cactus.smartclient.DropDestType.DOOR
                Me.ThirdLocation = Loc
                If Loc = "NA" Then
                    Me.ThirdLocationLabel.Text = "NONE"
                Else
                    Me.ThirdLocationLabel.Text = "DOOR: " & Loc
                End If
            Case karservices.cactus.smartclient.DropDestType.LOT
                Me.ThirdLocation = "LOT"
            Case karservices.cactus.smartclient.DropDestType.WASH
                Me.ThirdLocation = "WASH"
        End Select
    End Sub
    Public Sub SetNextLocation(ByVal Loc As String, ByVal NewDropType As KAR_Lot_SmartClient.karservices.cactus.smartclient.DropDestType)
        Me.DropType = NewDropType
        Select Case NewDropType
            Case karservices.cactus.smartclient.DropDestType.DOOR
                Me.MoveInfoLabel.Text = "DOOR: " & Loc
            Case karservices.cactus.smartclient.DropDestType.LOT
                Me.MoveInfoLabel.Text = Loc
            Case karservices.cactus.smartclient.DropDestType.WASH
                Me.MoveInfoLabel.Text = Loc
        End Select
        Me.DropLocation = Loc
    End Sub
    Private Sub CallOutComplete(ByVal sender As Object, ByVal e As KAR_Lot_SmartClient.karservices.cactus.smartclient.CallTrailerMoveOutDoorToLotCompletedEventArgs)
        If e.Error IsNot Nothing Then
            MessageBox.Show("Problem..." & vbCrLf & vbCrLf & e.Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Me.StopWait()
        End If
        If e.Result = True Then
            MainForm.RefreshDoorData()
            Me.Close()
        Else
            Me.StopWait()
            MessageBox.Show("There was a problem updating the trailer information. Check the trailer and try again...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If
    End Sub
    Private Sub DoorToDoorComplete(ByVal sender As Object, ByVal e As KAR_Lot_SmartClient.karservices.cactus.smartclient.CallTrailerMoveOutDoorToDoorCompletedEventArgs)
        If e.Error IsNot Nothing Then
            MessageBox.Show("Problem..." & vbCrLf & vbCrLf & e.Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Me.StopWait()
        End If
        If e.Result = True Then
            MainForm.RefreshDoorData()
            Me.Close()
        Else
            Me.StopWait()
            MessageBox.Show("There was a problem updating the trailer information. Check the trailer and try again...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If
    End Sub
#End Region

#Region " Event Code "
    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub
    Private Sub ActionButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActionButton.Click
        Select Case Me.ViewMode
            Case ViewModeTypes.ViewInfo
                Me.Close()
            Case ViewModeTypes.CallOutDoor
                ' SET THE PRIORITY LEVEL
                Dim pPriorityMove As Boolean = False
                If Me.PriorityMoveCheckBox.Checked = True Then pPriorityMove = True
                Me.MyTrailer.SpecialInstructions = Me.SpecialInstructionsTextBox.Text.Trim.ToUpper
                Me.MyTrailer.Load.dbCode = Me.NewLoadStatus
                ' GET USER ENTERED DATA AND ASSIGN TO TRAILER OBJECT FOR SAVING
                Me.MyTrailer.Seal1 = Me.Seal1TextBox.Text.Trim.ToUpper
                Me.MyTrailer.Seal2 = Me.Seal2TextBox.Text.Trim.ToUpper
                Me.MyTrailer.Seal3 = Me.Seal3TextBox.Text.Trim.ToUpper
                Me.MyTrailer.LoadNumber = Me.LoadNumberTextBox.Text.Trim.ToUpper
                Me.MyTrailer.CalloutUserInitials = Me.UserInitialsTextBox.Text.Trim
                Me.MyTrailer.ReferUnitMode = Me.ReferUnitModeComboBox.Text.Trim.ToUpper
                Me.MyTrailer.Pallets = Me.PalletsComboBox.Text
                ' SET THE MESSAGE FOR RE-WASH or WASH
                Dim pWashMessage = "*** RE-WASH TRAILER ***" ' DEFAULT
                If Me.MyTrailer.Classification.ToUpper() = "D" OrElse Me.MyTrailer.Classification.ToUpper() = "L" Then
                    ' Supply (D) or pallet (L) trailers are not considered re-wash since they inbound already loaded and are not washed until unloaded and called out of a door empty dirty.
                    pWashMessage = "*** WASH TRAILER ***"
                End If

                If Me.VerifyFields = False Then
                    MessageBox.Show(GlobalClass.FieldsNotValidMessage, "Check Fields", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    Exit Sub
                End If
                Me.DoWait()

                Try
                    Me.MyWebService.CancelAsync(Me.MyGuid) ' CANCEL ANY PREVIOUS ASYNC CALLS
                    ' IF THE TRAILER IS CALLED BACK TO THE SAME DOOR IT IS A REWASH.
                    If Me.MyTrailer.CurrentLocation = Me.DropLocation.Trim Then
                        Me.SpecialInstructionsTextBox.Text = pWashMessage & " BRING BACK TO DOOR - " & vbCrLf & vbCrLf & Me.SpecialInstructionsTextBox.Text.Trim
                    End If
                    Select Case Me.DropLocation
                        Case "LOT"
                            Me.SpecialInstructionsTextBox.Text = " (" & Me.WarningInitialsTextBox.Text.Trim & ") " & Me.SpecialInstructionsTextBox.Text.Trim
                            Me.MyWebService.CallTrailerMoveOutDoorToLotAsync(Me.MyTrailer, GlobalClass.MyUser.UserName, My.Settings.StationID, Me.SpecialInstructionsTextBox.Text.Trim, pPriorityMove, Me.MyGuid)
                        Case "WASH"
                            Me.SpecialInstructionsTextBox.Text = pWashMessage & vbCrLf & vbCrLf & Me.SpecialInstructionsTextBox.Text.Trim
                            Me.MyWebService.CallTrailerMoveOutDoorToLotAsync(Me.MyTrailer, GlobalClass.MyUser.UserName, My.Settings.StationID, Me.SpecialInstructionsTextBox.Text.Trim, pPriorityMove, Me.MyGuid)
                        Case Else
                            Me.MyWebService.CallTrailerMoveOutDoorToDoorAsync(Me.MyTrailer, GlobalClass.MyUser.UserName, My.Settings.StationID, Me.SpecialInstructionsTextBox.Text.Trim, pPriorityMove, Me.DropLocation, Me.MyGuid)
                    End Select
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    Me.StopWait()
                    Exit Sub
                End Try
        End Select
    End Sub
    Private Function VerifyFields() As Boolean
        ' test each requirement. return true after all required fields pass.
        If Me.MyTrailer Is Nothing Then Return False
        If Me.DropLocation = "" Then Return False
        If Me.ThirdLocation = "" Then Return False
        If Me.NewLoadStatus = "" Then Return False
        If Me.UserInitialsTextBox.Text.Trim.Length = 0 Then Return False
        If Me.NewLoadStatus.Contains("E") Or Me.NewLoadStatus.Contains("D") Then
            ' Do not require load number for empty load status
        Else
            If Me.LoadNumberTextBox.Text.Trim.Length = 0 Then Return False
            If Me.Seal1TextBox.Text.Trim.Length = 0 Then Return False
        End If
        If Me.mNewClassification = "" Then
            Return False
        Else
            Me.MyTrailer.Classification = Me.mNewClassification
        End If

        ' test the empty state.
        If Me.EmptyLoadRadioButton.Checked = True Then
            If Me.ReWashCheckBox.CheckState = CheckState.Unchecked And Me.NoWashCheckBox.CheckState = CheckState.Unchecked Then
                Me.WashSelectionRequiredFieldLabel.Visible = True
                Return False
            End If
            If Me.NoWashCheckBox.CheckState = CheckState.Checked Then
                If Me.WarningInitialsTextBox.Text.Trim.Length = 0 Then
                    Me.WarningRequiredLabel.Visible = True
                    Return False
                End If
            End If
        End If

        Return True
    End Function
    Private Sub CompleteLoadRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompleteLoadRadioButton.CheckedChanged
        If Me.CompleteLoadRadioButton.Checked = True Then
            Me.SetGroupBox(GroupBoxState.NewClassification)

            Me.NewLoadStatus = "F"
            Me.DropLocation = "LOT"
            Me.MoveInfoLabel.Text = "LOT"
            Me.SetThirdLocation("NA", karservices.cactus.smartclient.DropDestType.DOOR)
            Me.NewStatusPictureBox.Image = Me.TrailerImageList.Images("F")
            Me.DoLoadDesriptionText()
        End If
    End Sub
    Private Sub PartialLoadRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PartialLoadRadioButton.CheckedChanged
        If Me.PartialLoadRadioButton.Checked = True Then
            Me.SetGroupBox(GroupBoxState.NewClassification)

            Me.NewLoadStatus = "P"
            Me.DropLocation = "LOT"
            Me.MoveInfoLabel.Text = "LOT"
            Me.SetThirdLocation("NA", karservices.cactus.smartclient.DropDestType.DOOR)
            Me.NewStatusPictureBox.Image = Me.TrailerImageList.Images("P")
            Me.DoLoadDesriptionText()
        End If
    End Sub
    Private Sub EmptyLoadRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmptyLoadRadioButton.CheckedChanged
        If Me.EmptyLoadRadioButton.Checked = True Then
            Me.HandleTrailerClassification()
            Me.SetGroupBox(GroupBoxState.TrailerRewash)
            ' set the empty dirty defaults
            Me.SetEmptyDirtyStatus()
            Me.ShowNoWashWarning(False)
            Me.ReWashCheckBox.Checked = True
            Me.ReWashCheckBox.Enabled = True
            Me.NoWashCheckBox.Checked = False
            Me.NoWashCheckBox.Enabled = False
        Else
            Me.NewClassificationGroupBox.Enabled = True
            Me.ClassNotApplicableLabel.Visible = False
        End If
    End Sub
    Private Sub MoveInfoLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoveInfoLabel.Click
        If Me.ViewMode = ViewModeTypes.CallOutDoor Then
            CallOutLocationsForm = New CallOutLocations(Me.NewLoadStatus)
            AddHandler CallOutLocationsForm.SetNextLoc, AddressOf SetNextLocation
            AddHandler CallOutLocationsForm.SetThirdLoc, AddressOf SetThirdLocation
            CallOutLocationsForm.ShowDialog()
        End If
    End Sub
    Private Sub DoWait()
        Me.IsWaiting = True
        Me.WaitLabel.Visible = True
        Me.ActionButton.Visible = False
        Me.CloseButton.Visible = False
        Me.WaitTimer.Start()
    End Sub
    Private Sub StopWait()
        Me.IsWaiting = False
        Me.WaitLabel.Visible = False
        Me.ActionButton.Visible = True
        Me.CloseButton.Visible = True
        Me.WaitTimer.Stop()
    End Sub
    Private Sub WaitTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WaitTimer.Tick
        If Me.IsWaiting = True Then
            Me.IsWaiting = False
            Me.WaitLabel.Visible = False
            Me.ActionButton.Visible = True
            Me.CloseButton.Visible = True
            Me.WaitTimer.Stop()
        End If
    End Sub
    Private Sub PalletClassRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PalletClassRadioButton.CheckedChanged
        If Me.PalletClassRadioButton.Checked Then
            Me.mNewClassification = "L"
            If My.Settings.CanEditPalletOnDockCallout = True Then
                Me.PalletsGroupBox.Visible = True
                ' pull in trailer pallet value if set
                If String.IsNullOrEmpty(Me.MyTrailer.Pallets) = False Then
                    Me.PalletsComboBox.Text = Me.MyTrailer.Pallets
                End If
            End If
            Me.DoLoadDesriptionText()
        End If
    End Sub
    Private Sub ProductClassRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductClassRadioButton.CheckedChanged
        If Me.ProductClassRadioButton.Checked Then
            Me.mNewClassification = "D"
            Me.DoLoadDesriptionText()
        End If
    End Sub
    Private Sub ReferClassRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReferClassRadioButton.CheckedChanged
        If Me.ReferClassRadioButton.Checked Then
            Me.mNewClassification = "E"
            Me.DoLoadDesriptionText()
        End If
    End Sub
#End Region

#Region " Helper Methods "
    Private Sub DoLoadDesriptionText()
        Select Case Me.NewLoadStatus
            Case "F"
                Me.FinishLoadDescription("Full Load of ")
            Case "P"
                Me.FinishLoadDescription("Partial Load of ")
            Case Else
                Me.LoadDescriptionLabel.Text = ""
        End Select
    End Sub
    Private Sub FinishLoadDescription(ByVal pText As String)
        If Me.PalletClassRadioButton.Checked Then
            Me.LoadDescriptionLabel.Text = pText & "Pallets"
        ElseIf Me.ProductClassRadioButton.Checked Then
            Me.LoadDescriptionLabel.Text = pText & "NON-Refrigerated Product"
        ElseIf Me.ReferClassRadioButton.Checked Then
            Me.LoadDescriptionLabel.Text = pText & "Refrigerated Product"
        Else
            Me.LoadDescriptionLabel.Text = pText & "???"
        End If
    End Sub
    Private Sub HandleTrailerClassification()
        Me.mNewClassification = "E" ' DEFAULT EMPTIES TO CLASS E
        Me.ProductClassRadioButton.Checked = False
        Me.ReferClassRadioButton.Checked = False
        Me.PalletClassRadioButton.Checked = False
        Me.NewClassificationGroupBox.Enabled = False
        Me.ClassNotApplicableLabel.Visible = True
        Me.LoadDescriptionLabel.Text = ""
    End Sub
    Private Sub SetGroupBox(ByVal pState As String)
        Select Case pState
            Case GroupBoxState.NewClassification
                Me.TrailerReWashGroupBox.Visible = False
                Me.NewClassificationGroupBox.Visible = True
            Case GroupBoxState.TrailerRewash
                Me.TrailerReWashGroupBox.Visible = True
                Me.NewClassificationGroupBox.Visible = False
            Case Else
                ' do nothing
        End Select
    End Sub
    Private Sub SetEmptyDirtyStatus()
        Me.NewLoadStatus = "D"
        Me.DropLocation = "WASH"
        Me.MoveInfoLabel.Text = "WASH"
        Me.SetThirdLocation("NA", karservices.cactus.smartclient.DropDestType.DOOR)
        Me.NewStatusPictureBox.Image = Me.TrailerImageList.Images("D")
    End Sub
    Private Sub SetEmptyCleanStatus()
        Me.NewLoadStatus = "E"
        Me.DropLocation = "LOT"
        Me.MoveInfoLabel.Text = "LOT"
        Me.SetThirdLocation("NA", karservices.cactus.smartclient.DropDestType.DOOR)
        Me.NewStatusPictureBox.Image = Me.TrailerImageList.Images("E")
    End Sub
    Private Sub ShowNoWashWarning(ByVal pShow As Boolean)
        Me.WarningInitialsLablel.Visible = pShow
        Me.WarningInitialsTextBox.Visible = pShow
        Me.WarningLabel.Visible = pShow
        Me.WarningTextLabel.Visible = pShow
        If pShow = False Then Me.WarningRequiredLabel.Visible = False
        Me.WarningInitialsTextBox.Enabled = pShow
        Me.WarningInitialsTextBox.Text = String.Empty
        Me.WarningInitialsTextBox.Focus()
    End Sub
    Private Sub ApplyLegacyPalletFeatureFlags()
        ' apply legacy pallet feature flag to ui objects
        ' items inside TempGroupBox
        Me.LegacyPalletsOnBoardLabelHeader.Visible = My.Settings.ViewLegacyPalletInfoOnDockCallout
        Me.LegacyPalletsRequestedLabelHeader.Visible = My.Settings.ViewLegacyPalletInfoOnDockCallout
        Me.PalletsRequestedLabel.Visible = My.Settings.ViewLegacyPalletInfoOnDockCallout
        Me.PalletsOnBoardLabel.Visible = My.Settings.ViewLegacyPalletInfoOnDockCallout
        ' items inside ClassGroupBox
        Me.ClassPalletsOnBoardHeaderLabel.Visible = My.Settings.ViewLegacyPalletInfoOnDockCallout
        Me.ClassPalletsLabel.Visible = My.Settings.ViewLegacyPalletInfoOnDockCallout

    End Sub
    Private Sub ApplyPalletFeatureFlags()
        Me.PalletsGroupBox.Visible = My.Settings.CanEditPalletOnDockCallout
    End Sub

#End Region

#Region " REWASH GROUP BOX METHODS "
    Private Sub ReWashCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReWashCheckBox.CheckedChanged
        If Me.ReWashCheckBox.CheckState = CheckState.Unchecked Then
            Me.NoWashCheckBox.Enabled = True
        Else
            ' make sure the checkbox is not checked and disabled
            Me.NoWashCheckBox.Checked = False
            Me.NoWashCheckBox.Enabled = False
            ' update the status to empty dirty
            Me.SetEmptyDirtyStatus()
            Me.ShowNoWashWarning(False)
        End If
    End Sub
    Private Sub NoWashCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NoWashCheckBox.CheckedChanged
        If Me.NoWashCheckBox.CheckState = CheckState.Unchecked Then
            Me.ReWashCheckBox.Enabled = True
        Else
            ' make sure the checkbox is not checked and disabled
            Me.ReWashCheckBox.Checked = False
            Me.ReWashCheckBox.Enabled = False
            ' update the status to empty clean
            Me.SetEmptyCleanStatus()
            Me.ShowNoWashWarning(True)
        End If
    End Sub
#End Region

    Private Sub ReferUnitModeComboBox_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReferUnitModeComboBox.SelectedValueChanged
        Me.MyTrailer.ReferUnitMode = ReferUnitModeComboBox.Text.Trim.ToUpper
    End Sub
End Class

Public Module GroupBoxState
    ' used for goupbox state when this form is used to call out a trailer.
    Public TrailerRewash As String = "TrailerRewash"
    Public NewClassification As String = "NewClassification"
End Module