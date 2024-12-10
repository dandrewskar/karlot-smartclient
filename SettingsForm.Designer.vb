<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingsForm))
        Me.MainSettingsTab = New System.Windows.Forms.TabControl
        Me.MainTab = New System.Windows.Forms.TabPage
        Me.AllowBarcodeActivationCheckBox = New System.Windows.Forms.CheckBox
        Me.AllowCheckInOutCheckBox = New System.Windows.Forms.CheckBox
        Me.EnhancedTaskingCheckBox = New System.Windows.Forms.CheckBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.WashModeComboBox = New System.Windows.Forms.ComboBox
        Me.TruckIDTextBox = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.ApplyMainSettingsButton = New System.Windows.Forms.Button
        Me.ConnectionTypeComboBox = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.DataExportPathTextbox = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.DataCachePathTextbox = New System.Windows.Forms.TextBox
        Me.NetworkTab = New System.Windows.Forms.TabPage
        Me.LayoutFilePathTextBox = New System.Windows.Forms.TextBox
        Me.LayoutFilePathLabel = New System.Windows.Forms.Label
        Me.BackgroundImageTextBox = New System.Windows.Forms.TextBox
        Me.BackgroundImagePathLabel = New System.Windows.Forms.Label
        Me.HttpsCheckboxRemote = New System.Windows.Forms.CheckBox
        Me.RemoteServerPortTextBox = New System.Windows.Forms.TextBox
        Me.LocalServerPortTextBox = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.RemoteServerTextBox = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.ApplyNetworkSettingsButton = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.LocalServerIPTextBox = New System.Windows.Forms.TextBox
        Me.RemoteWebServiceURLTextBox = New System.Windows.Forms.TextBox
        Me.LocalWebServiceURLTextBox = New System.Windows.Forms.TextBox
        Me.DataTabPage = New System.Windows.Forms.TabPage
        Me.ApplyDataSettingsButton = New System.Windows.Forms.Button
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.InboundSheetCacheFileTextBox = New System.Windows.Forms.TextBox
        Me.CarriersCacheFileNameTextBox = New System.Windows.Forms.TextBox
        Me.ActiveTrailersCacheFileTextBox = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.ApiBaseUrlTextBox = New System.Windows.Forms.TextBox
        Me.MainSettingsTab.SuspendLayout()
        Me.MainTab.SuspendLayout()
        Me.NetworkTab.SuspendLayout()
        Me.DataTabPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainSettingsTab
        '
        Me.MainSettingsTab.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.MainSettingsTab.Controls.Add(Me.MainTab)
        Me.MainSettingsTab.Controls.Add(Me.NetworkTab)
        Me.MainSettingsTab.Controls.Add(Me.DataTabPage)
        Me.MainSettingsTab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainSettingsTab.Location = New System.Drawing.Point(0, 0)
        Me.MainSettingsTab.Name = "MainSettingsTab"
        Me.MainSettingsTab.SelectedIndex = 0
        Me.MainSettingsTab.Size = New System.Drawing.Size(387, 340)
        Me.MainSettingsTab.TabIndex = 0
        '
        'MainTab
        '
        Me.MainTab.Controls.Add(Me.AllowBarcodeActivationCheckBox)
        Me.MainTab.Controls.Add(Me.AllowCheckInOutCheckBox)
        Me.MainTab.Controls.Add(Me.EnhancedTaskingCheckBox)
        Me.MainTab.Controls.Add(Me.Label17)
        Me.MainTab.Controls.Add(Me.WashModeComboBox)
        Me.MainTab.Controls.Add(Me.TruckIDTextBox)
        Me.MainTab.Controls.Add(Me.Label16)
        Me.MainTab.Controls.Add(Me.ApplyMainSettingsButton)
        Me.MainTab.Controls.Add(Me.ConnectionTypeComboBox)
        Me.MainTab.Controls.Add(Me.Label3)
        Me.MainTab.Controls.Add(Me.DataExportPathTextbox)
        Me.MainTab.Controls.Add(Me.Label2)
        Me.MainTab.Controls.Add(Me.Label1)
        Me.MainTab.Controls.Add(Me.DataCachePathTextbox)
        Me.MainTab.Location = New System.Drawing.Point(4, 25)
        Me.MainTab.Name = "MainTab"
        Me.MainTab.Padding = New System.Windows.Forms.Padding(3)
        Me.MainTab.Size = New System.Drawing.Size(379, 311)
        Me.MainTab.TabIndex = 0
        Me.MainTab.Text = "Main"
        Me.MainTab.UseVisualStyleBackColor = True
        '
        'AllowBarcodeActivationCheckBox
        '
        Me.AllowBarcodeActivationCheckBox.AutoSize = True
        Me.AllowBarcodeActivationCheckBox.Checked = Global.KAR_Lot_SmartClient.My.MySettings.Default.AllowBarcodeActivation
        Me.AllowBarcodeActivationCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.KAR_Lot_SmartClient.My.MySettings.Default, "AllowBarcodeActivation", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.AllowBarcodeActivationCheckBox.Location = New System.Drawing.Point(19, 157)
        Me.AllowBarcodeActivationCheckBox.Name = "AllowBarcodeActivationCheckBox"
        Me.AllowBarcodeActivationCheckBox.Size = New System.Drawing.Size(144, 17)
        Me.AllowBarcodeActivationCheckBox.TabIndex = 13
        Me.AllowBarcodeActivationCheckBox.Text = "Allow Barcode Activation"
        Me.AllowBarcodeActivationCheckBox.UseVisualStyleBackColor = True
        '
        'AllowCheckInOutCheckBox
        '
        Me.AllowCheckInOutCheckBox.AutoSize = True
        Me.AllowCheckInOutCheckBox.Checked = Global.KAR_Lot_SmartClient.My.MySettings.Default.AllowTrailerCheckInOut
        Me.AllowCheckInOutCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.KAR_Lot_SmartClient.My.MySettings.Default, "AllowTrailerCheckInOut", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.AllowCheckInOutCheckBox.Location = New System.Drawing.Point(19, 134)
        Me.AllowCheckInOutCheckBox.Name = "AllowCheckInOutCheckBox"
        Me.AllowCheckInOutCheckBox.Size = New System.Drawing.Size(151, 17)
        Me.AllowCheckInOutCheckBox.TabIndex = 12
        Me.AllowCheckInOutCheckBox.Text = "Allow Trailer Check-In/Out"
        Me.AllowCheckInOutCheckBox.UseVisualStyleBackColor = True
        '
        'EnhancedTaskingCheckBox
        '
        Me.EnhancedTaskingCheckBox.AutoSize = True
        Me.EnhancedTaskingCheckBox.Checked = Global.KAR_Lot_SmartClient.My.MySettings.Default.EnhancedTasking
        Me.EnhancedTaskingCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.EnhancedTaskingCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.KAR_Lot_SmartClient.My.MySettings.Default, "EnhancedTasking", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.EnhancedTaskingCheckBox.Location = New System.Drawing.Point(237, 109)
        Me.EnhancedTaskingCheckBox.Name = "EnhancedTaskingCheckBox"
        Me.EnhancedTaskingCheckBox.Size = New System.Drawing.Size(116, 17)
        Me.EnhancedTaskingCheckBox.TabIndex = 11
        Me.EnhancedTaskingCheckBox.Text = "Enhanced Tasking"
        Me.EnhancedTaskingCheckBox.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(16, 187)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(65, 13)
        Me.Label17.TabIndex = 10
        Me.Label17.Text = "Wash Mode"
        Me.Label17.Visible = False
        '
        'WashModeComboBox
        '
        Me.WashModeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.KAR_Lot_SmartClient.My.MySettings.Default, "WashMode", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.WashModeComboBox.FormattingEnabled = True
        Me.WashModeComboBox.Items.AddRange(New Object() {"WashOnly", "Normal"})
        Me.WashModeComboBox.Location = New System.Drawing.Point(19, 203)
        Me.WashModeComboBox.Name = "WashModeComboBox"
        Me.WashModeComboBox.Size = New System.Drawing.Size(162, 21)
        Me.WashModeComboBox.TabIndex = 9
        Me.WashModeComboBox.Text = Global.KAR_Lot_SmartClient.My.MySettings.Default.WashMode
        Me.WashModeComboBox.Visible = False
        '
        'TruckIDTextBox
        '
        Me.TruckIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.KAR_Lot_SmartClient.My.MySettings.Default, "StationID", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TruckIDTextBox.Location = New System.Drawing.Point(180, 107)
        Me.TruckIDTextBox.MaxLength = 3
        Me.TruckIDTextBox.Name = "TruckIDTextBox"
        Me.TruckIDTextBox.Size = New System.Drawing.Size(51, 20)
        Me.TruckIDTextBox.TabIndex = 8
        Me.TruckIDTextBox.Text = Global.KAR_Lot_SmartClient.My.MySettings.Default.StationID
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(177, 91)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(54, 13)
        Me.Label16.TabIndex = 7
        Me.Label16.Text = "Station ID"
        '
        'ApplyMainSettingsButton
        '
        Me.ApplyMainSettingsButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ApplyMainSettingsButton.Location = New System.Drawing.Point(257, 273)
        Me.ApplyMainSettingsButton.Name = "ApplyMainSettingsButton"
        Me.ApplyMainSettingsButton.Size = New System.Drawing.Size(116, 30)
        Me.ApplyMainSettingsButton.TabIndex = 6
        Me.ApplyMainSettingsButton.Text = "Apply"
        Me.ApplyMainSettingsButton.UseVisualStyleBackColor = True
        '
        'ConnectionTypeComboBox
        '
        Me.ConnectionTypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.KAR_Lot_SmartClient.My.MySettings.Default, "ConnectionType", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ConnectionTypeComboBox.FormattingEnabled = True
        Me.ConnectionTypeComboBox.Items.AddRange(New Object() {"Network", "Kar Radio"})
        Me.ConnectionTypeComboBox.Location = New System.Drawing.Point(19, 107)
        Me.ConnectionTypeComboBox.Name = "ConnectionTypeComboBox"
        Me.ConnectionTypeComboBox.Size = New System.Drawing.Size(155, 21)
        Me.ConnectionTypeComboBox.TabIndex = 5
        Me.ConnectionTypeComboBox.Text = Global.KAR_Lot_SmartClient.My.MySettings.Default.ConnectionType
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Connection Type"
        '
        'DataExportPathTextbox
        '
        Me.DataExportPathTextbox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.KAR_Lot_SmartClient.My.MySettings.Default, "DataExportPath", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DataExportPathTextbox.Location = New System.Drawing.Point(19, 68)
        Me.DataExportPathTextbox.Name = "DataExportPathTextbox"
        Me.DataExportPathTextbox.Size = New System.Drawing.Size(337, 20)
        Me.DataExportPathTextbox.TabIndex = 3
        Me.DataExportPathTextbox.Text = Global.KAR_Lot_SmartClient.My.MySettings.Default.DataExportPath
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Data Export Path"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Data Cache Directory"
        '
        'DataCachePathTextbox
        '
        Me.DataCachePathTextbox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.KAR_Lot_SmartClient.My.MySettings.Default, "DataCacheDirectory", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DataCachePathTextbox.Location = New System.Drawing.Point(19, 29)
        Me.DataCachePathTextbox.Name = "DataCachePathTextbox"
        Me.DataCachePathTextbox.Size = New System.Drawing.Size(337, 20)
        Me.DataCachePathTextbox.TabIndex = 0
        Me.DataCachePathTextbox.Text = Global.KAR_Lot_SmartClient.My.MySettings.Default.DataCacheDirectory
        '
        'NetworkTab
        '
        Me.NetworkTab.Controls.Add(Me.Label6)
        Me.NetworkTab.Controls.Add(Me.ApiBaseUrlTextBox)
        Me.NetworkTab.Controls.Add(Me.LayoutFilePathTextBox)
        Me.NetworkTab.Controls.Add(Me.LayoutFilePathLabel)
        Me.NetworkTab.Controls.Add(Me.BackgroundImageTextBox)
        Me.NetworkTab.Controls.Add(Me.BackgroundImagePathLabel)
        Me.NetworkTab.Controls.Add(Me.HttpsCheckboxRemote)
        Me.NetworkTab.Controls.Add(Me.RemoteServerPortTextBox)
        Me.NetworkTab.Controls.Add(Me.LocalServerPortTextBox)
        Me.NetworkTab.Controls.Add(Me.Label15)
        Me.NetworkTab.Controls.Add(Me.Label14)
        Me.NetworkTab.Controls.Add(Me.RemoteServerTextBox)
        Me.NetworkTab.Controls.Add(Me.Label10)
        Me.NetworkTab.Controls.Add(Me.Label9)
        Me.NetworkTab.Controls.Add(Me.ApplyNetworkSettingsButton)
        Me.NetworkTab.Controls.Add(Me.Label5)
        Me.NetworkTab.Controls.Add(Me.Label4)
        Me.NetworkTab.Controls.Add(Me.LocalServerIPTextBox)
        Me.NetworkTab.Controls.Add(Me.RemoteWebServiceURLTextBox)
        Me.NetworkTab.Controls.Add(Me.LocalWebServiceURLTextBox)
        Me.NetworkTab.Location = New System.Drawing.Point(4, 25)
        Me.NetworkTab.Name = "NetworkTab"
        Me.NetworkTab.Padding = New System.Windows.Forms.Padding(3)
        Me.NetworkTab.Size = New System.Drawing.Size(379, 311)
        Me.NetworkTab.TabIndex = 1
        Me.NetworkTab.Text = "Network"
        Me.NetworkTab.UseVisualStyleBackColor = True
        '
        'LayoutFilePathTextBox
        '
        Me.LayoutFilePathTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.KAR_Lot_SmartClient.My.MySettings.Default, "LayoutURL", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.LayoutFilePathTextBox.Location = New System.Drawing.Point(14, 183)
        Me.LayoutFilePathTextBox.Name = "LayoutFilePathTextBox"
        Me.LayoutFilePathTextBox.Size = New System.Drawing.Size(349, 20)
        Me.LayoutFilePathTextBox.TabIndex = 18
        Me.LayoutFilePathTextBox.Text = Global.KAR_Lot_SmartClient.My.MySettings.Default.LayoutURL
        '
        'LayoutFilePathLabel
        '
        Me.LayoutFilePathLabel.AutoSize = True
        Me.LayoutFilePathLabel.Location = New System.Drawing.Point(11, 167)
        Me.LayoutFilePathLabel.Name = "LayoutFilePathLabel"
        Me.LayoutFilePathLabel.Size = New System.Drawing.Size(83, 13)
        Me.LayoutFilePathLabel.TabIndex = 17
        Me.LayoutFilePathLabel.Text = "Layout File Path"
        '
        'BackgroundImageTextBox
        '
        Me.BackgroundImageTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.KAR_Lot_SmartClient.My.MySettings.Default, "BackgroundURL", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.BackgroundImageTextBox.Location = New System.Drawing.Point(14, 139)
        Me.BackgroundImageTextBox.Name = "BackgroundImageTextBox"
        Me.BackgroundImageTextBox.Size = New System.Drawing.Size(349, 20)
        Me.BackgroundImageTextBox.TabIndex = 16
        Me.BackgroundImageTextBox.Text = Global.KAR_Lot_SmartClient.My.MySettings.Default.BackgroundURL
        '
        'BackgroundImagePathLabel
        '
        Me.BackgroundImagePathLabel.AutoSize = True
        Me.BackgroundImagePathLabel.Location = New System.Drawing.Point(11, 123)
        Me.BackgroundImagePathLabel.Name = "BackgroundImagePathLabel"
        Me.BackgroundImagePathLabel.Size = New System.Drawing.Size(122, 13)
        Me.BackgroundImagePathLabel.TabIndex = 15
        Me.BackgroundImagePathLabel.Text = "Background Image Path"
        '
        'HttpsCheckboxRemote
        '
        Me.HttpsCheckboxRemote.AutoSize = True
        Me.HttpsCheckboxRemote.Checked = Global.KAR_Lot_SmartClient.My.MySettings.Default.HttpsRemote
        Me.HttpsCheckboxRemote.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.KAR_Lot_SmartClient.My.MySettings.Default, "HttpsRemote", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.HttpsCheckboxRemote.Location = New System.Drawing.Point(11, 99)
        Me.HttpsCheckboxRemote.Name = "HttpsCheckboxRemote"
        Me.HttpsCheckboxRemote.Size = New System.Drawing.Size(62, 17)
        Me.HttpsCheckboxRemote.TabIndex = 14
        Me.HttpsCheckboxRemote.Text = "HTTPS"
        Me.HttpsCheckboxRemote.UseVisualStyleBackColor = True
        '
        'RemoteServerPortTextBox
        '
        Me.RemoteServerPortTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.KAR_Lot_SmartClient.My.MySettings.Default, "RemoteServerPort", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.RemoteServerPortTextBox.Location = New System.Drawing.Point(273, 97)
        Me.RemoteServerPortTextBox.MaxLength = 6
        Me.RemoteServerPortTextBox.Name = "RemoteServerPortTextBox"
        Me.RemoteServerPortTextBox.Size = New System.Drawing.Size(76, 20)
        Me.RemoteServerPortTextBox.TabIndex = 12
        Me.RemoteServerPortTextBox.Text = Global.KAR_Lot_SmartClient.My.MySettings.Default.RemoteServerPort
        '
        'LocalServerPortTextBox
        '
        Me.LocalServerPortTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.KAR_Lot_SmartClient.My.MySettings.Default, "LocalServerPort", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.LocalServerPortTextBox.Location = New System.Drawing.Point(108, 261)
        Me.LocalServerPortTextBox.MaxLength = 6
        Me.LocalServerPortTextBox.Name = "LocalServerPortTextBox"
        Me.LocalServerPortTextBox.Size = New System.Drawing.Size(36, 20)
        Me.LocalServerPortTextBox.TabIndex = 11
        Me.LocalServerPortTextBox.Text = Global.KAR_Lot_SmartClient.My.MySettings.Default.LocalServerPort
        Me.LocalServerPortTextBox.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(270, 81)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(26, 13)
        Me.Label15.TabIndex = 10
        Me.Label15.Text = "Port"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(105, 245)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(26, 13)
        Me.Label14.TabIndex = 9
        Me.Label14.Text = "Port"
        Me.Label14.Visible = False
        '
        'RemoteServerTextBox
        '
        Me.RemoteServerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.KAR_Lot_SmartClient.My.MySettings.Default, "RemoteWebServer", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.RemoteServerTextBox.Location = New System.Drawing.Point(79, 97)
        Me.RemoteServerTextBox.Name = "RemoteServerTextBox"
        Me.RemoteServerTextBox.Size = New System.Drawing.Size(188, 20)
        Me.RemoteServerTextBox.TabIndex = 8
        Me.RemoteServerTextBox.Text = Global.KAR_Lot_SmartClient.My.MySettings.Default.RemoteWebServer
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 81)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 13)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Remote Server"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 245)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Local Server IP"
        Me.Label9.Visible = False
        '
        'ApplyNetworkSettingsButton
        '
        Me.ApplyNetworkSettingsButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ApplyNetworkSettingsButton.Location = New System.Drawing.Point(275, 274)
        Me.ApplyNetworkSettingsButton.Name = "ApplyNetworkSettingsButton"
        Me.ApplyNetworkSettingsButton.Size = New System.Drawing.Size(98, 29)
        Me.ApplyNetworkSettingsButton.TabIndex = 4
        Me.ApplyNetworkSettingsButton.Text = "Apply"
        Me.ApplyNetworkSettingsButton.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(146, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Enhanced Web Service Path"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Basic Web Service Path"
        '
        'LocalServerIPTextBox
        '
        Me.LocalServerIPTextBox.Location = New System.Drawing.Point(11, 261)
        Me.LocalServerIPTextBox.Name = "LocalServerIPTextBox"
        Me.LocalServerIPTextBox.Size = New System.Drawing.Size(91, 20)
        Me.LocalServerIPTextBox.TabIndex = 6
        Me.LocalServerIPTextBox.Text = Global.KAR_Lot_SmartClient.My.MySettings.Default.LocalKarLotServer
        Me.LocalServerIPTextBox.Visible = False
        '
        'RemoteWebServiceURLTextBox
        '
        Me.RemoteWebServiceURLTextBox.Location = New System.Drawing.Point(11, 58)
        Me.RemoteWebServiceURLTextBox.Name = "RemoteWebServiceURLTextBox"
        Me.RemoteWebServiceURLTextBox.Size = New System.Drawing.Size(352, 20)
        Me.RemoteWebServiceURLTextBox.TabIndex = 3
        Me.RemoteWebServiceURLTextBox.Text = Global.KAR_Lot_SmartClient.My.MySettings.Default.EnhancedWebServicePath
        '
        'LocalWebServiceURLTextBox
        '
        Me.LocalWebServiceURLTextBox.Location = New System.Drawing.Point(11, 19)
        Me.LocalWebServiceURLTextBox.Name = "LocalWebServiceURLTextBox"
        Me.LocalWebServiceURLTextBox.Size = New System.Drawing.Size(352, 20)
        Me.LocalWebServiceURLTextBox.TabIndex = 1
        Me.LocalWebServiceURLTextBox.Text = Global.KAR_Lot_SmartClient.My.MySettings.Default.BasicWebServicePath
        '
        'DataTabPage
        '
        Me.DataTabPage.Controls.Add(Me.ApplyDataSettingsButton)
        Me.DataTabPage.Controls.Add(Me.Label13)
        Me.DataTabPage.Controls.Add(Me.Label12)
        Me.DataTabPage.Controls.Add(Me.Label11)
        Me.DataTabPage.Controls.Add(Me.InboundSheetCacheFileTextBox)
        Me.DataTabPage.Controls.Add(Me.CarriersCacheFileNameTextBox)
        Me.DataTabPage.Controls.Add(Me.ActiveTrailersCacheFileTextBox)
        Me.DataTabPage.Location = New System.Drawing.Point(4, 25)
        Me.DataTabPage.Name = "DataTabPage"
        Me.DataTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.DataTabPage.Size = New System.Drawing.Size(379, 307)
        Me.DataTabPage.TabIndex = 3
        Me.DataTabPage.Text = "Data"
        Me.DataTabPage.UseVisualStyleBackColor = True
        '
        'ApplyDataSettingsButton
        '
        Me.ApplyDataSettingsButton.Location = New System.Drawing.Point(263, 153)
        Me.ApplyDataSettingsButton.Name = "ApplyDataSettingsButton"
        Me.ApplyDataSettingsButton.Size = New System.Drawing.Size(110, 35)
        Me.ApplyDataSettingsButton.TabIndex = 6
        Me.ApplyDataSettingsButton.Text = "Apply"
        Me.ApplyDataSettingsButton.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(8, 51)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(130, 13)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Inbound Sheet Cache File"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(8, 90)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(95, 13)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Carriers Cache File"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 12)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(127, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Active Trailers Cache File"
        '
        'InboundSheetCacheFileTextBox
        '
        Me.InboundSheetCacheFileTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.KAR_Lot_SmartClient.My.MySettings.Default, "InboundSheetCacheFile", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.InboundSheetCacheFileTextBox.Location = New System.Drawing.Point(11, 67)
        Me.InboundSheetCacheFileTextBox.Name = "InboundSheetCacheFileTextBox"
        Me.InboundSheetCacheFileTextBox.Size = New System.Drawing.Size(178, 20)
        Me.InboundSheetCacheFileTextBox.TabIndex = 5
        Me.InboundSheetCacheFileTextBox.Text = Global.KAR_Lot_SmartClient.My.MySettings.Default.InboundSheetCacheFile
        '
        'CarriersCacheFileNameTextBox
        '
        Me.CarriersCacheFileNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.KAR_Lot_SmartClient.My.MySettings.Default, "CarriersCacheFile", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CarriersCacheFileNameTextBox.Location = New System.Drawing.Point(11, 106)
        Me.CarriersCacheFileNameTextBox.Name = "CarriersCacheFileNameTextBox"
        Me.CarriersCacheFileNameTextBox.Size = New System.Drawing.Size(178, 20)
        Me.CarriersCacheFileNameTextBox.TabIndex = 3
        Me.CarriersCacheFileNameTextBox.Text = Global.KAR_Lot_SmartClient.My.MySettings.Default.CarriersCacheFile
        '
        'ActiveTrailersCacheFileTextBox
        '
        Me.ActiveTrailersCacheFileTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.KAR_Lot_SmartClient.My.MySettings.Default, "ActiveTrailersCacheFile", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ActiveTrailersCacheFileTextBox.Location = New System.Drawing.Point(11, 28)
        Me.ActiveTrailersCacheFileTextBox.Name = "ActiveTrailersCacheFileTextBox"
        Me.ActiveTrailersCacheFileTextBox.Size = New System.Drawing.Size(178, 20)
        Me.ActiveTrailersCacheFileTextBox.TabIndex = 1
        Me.ActiveTrailersCacheFileTextBox.Text = Global.KAR_Lot_SmartClient.My.MySettings.Default.ActiveTrailersCacheFile
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 206)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "API Base URL"
        '
        'ApiBaseUrlTextBox
        '
        Me.ApiBaseUrlTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ApiBaseUrlTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.KAR_Lot_SmartClient.My.MySettings.Default, "ApiBaseURL", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ApiBaseUrlTextBox.Location = New System.Drawing.Point(11, 222)
        Me.ApiBaseUrlTextBox.Name = "ApiBaseUrlTextBox"
        Me.ApiBaseUrlTextBox.Size = New System.Drawing.Size(352, 20)
        Me.ApiBaseUrlTextBox.TabIndex = 20
        Me.ApiBaseUrlTextBox.Text = Global.KAR_Lot_SmartClient.My.MySettings.Default.ApiBaseURL
        '
        'SettingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 340)
        Me.Controls.Add(Me.MainSettingsTab)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SettingsForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.MainSettingsTab.ResumeLayout(False)
        Me.MainTab.ResumeLayout(False)
        Me.MainTab.PerformLayout()
        Me.NetworkTab.ResumeLayout(False)
        Me.NetworkTab.PerformLayout()
        Me.DataTabPage.ResumeLayout(False)
        Me.DataTabPage.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MainSettingsTab As System.Windows.Forms.TabControl
    Friend WithEvents MainTab As System.Windows.Forms.TabPage
    Friend WithEvents NetworkTab As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataCachePathTextbox As System.Windows.Forms.TextBox
    Friend WithEvents ConnectionTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataExportPathTextbox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ApplyMainSettingsButton As System.Windows.Forms.Button
    Friend WithEvents RemoteWebServiceURLTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LocalWebServiceURLTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ApplyNetworkSettingsButton As System.Windows.Forms.Button
    Friend WithEvents LocalServerIPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents RemoteServerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DataTabPage As System.Windows.Forms.TabPage
    Friend WithEvents ActiveTrailersCacheFileTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ApplyDataSettingsButton As System.Windows.Forms.Button
    Friend WithEvents InboundSheetCacheFileTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents CarriersCacheFileNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents RemoteServerPortTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LocalServerPortTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TruckIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents WashModeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents EnhancedTaskingCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents HttpsCheckboxRemote As System.Windows.Forms.CheckBox
    Friend WithEvents BackgroundImageTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BackgroundImagePathLabel As System.Windows.Forms.Label
    Friend WithEvents LayoutFilePathTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LayoutFilePathLabel As System.Windows.Forms.Label
    Friend WithEvents AllowCheckInOutCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents AllowBarcodeActivationCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ApiBaseUrlTextBox As System.Windows.Forms.TextBox
End Class
