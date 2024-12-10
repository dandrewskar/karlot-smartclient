<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TrailerRequest
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TrailerRequest))
        Me.SelectTrailerGroupBox = New System.Windows.Forms.GroupBox
        Me.TemperatureGroupBox = New System.Windows.Forms.GroupBox
        Me.SetTempPreviewC = New System.Windows.Forms.Label
        Me.SetTempPreviewF = New System.Windows.Forms.Label
        Me.CelsiusRadioButton = New System.Windows.Forms.RadioButton
        Me.FahrenheitRadioButton = New System.Windows.Forms.RadioButton
        Me.UserInitialsTextBox = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.SearchTabControl = New System.Windows.Forms.TabControl
        Me.TrailerIDTabPage = New System.Windows.Forms.TabPage
        Me.Label9 = New System.Windows.Forms.Label
        Me.FindTrailerIDButton = New System.Windows.Forms.Button
        Me.FindTrailerIDTextBox = New System.Windows.Forms.TextBox
        Me.CarrierTabPage = New System.Windows.Forms.TabPage
        Me.CarrierComboBox = New System.Windows.Forms.ComboBox
        Me.LoadNumberTabPage = New System.Windows.Forms.TabPage
        Me.LoadNumberInfoLabel = New System.Windows.Forms.Label
        Me.FindByLoadNumberButton = New System.Windows.Forms.Button
        Me.LoadNumberTextBox = New System.Windows.Forms.TextBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.PriorityCheckBox = New System.Windows.Forms.CheckBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.InstructionsTextBox = New System.Windows.Forms.TextBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.ShowTrailerIDLabel = New System.Windows.Forms.Label
        Me.ShowCarrierNameLabel = New System.Windows.Forms.Label
        Me.LegacyPalletGroupBox = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.NewPalletsGroupBox = New System.Windows.Forms.GroupBox
        Me.NoPalletsRadioButton = New System.Windows.Forms.RadioButton
        Me.ChepPalletsRadioButton = New System.Windows.Forms.RadioButton
        Me.WhitePalletsRadioButton = New System.Windows.Forms.RadioButton
        Me.HeatTreatedPalletsRadioButton = New System.Windows.Forms.RadioButton
        Me.ChangePalletsCheckbox = New System.Windows.Forms.CheckBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.PalletsOnBoardLabel = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.LoadNumberLabel = New System.Windows.Forms.Label
        Me.LoadNumberLabelHeader = New System.Windows.Forms.Label
        Me.OOSLabelNotes = New System.Windows.Forms.Label
        Me.OOSLabel = New System.Windows.Forms.Label
        Me.PrecoolStartedLabel = New System.Windows.Forms.Label
        Me.PreCoolingLabel = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.ClassLabel = New System.Windows.Forms.Label
        Me.MoveStatusLabel = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.CurrentTemperatureLabel = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.CurrentLocationLabel = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.LoadStatusLabel = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.LocationGroupBox = New System.Windows.Forms.GroupBox
        Me.DoorLabel = New System.Windows.Forms.Label
        Me.SetPointGroupBox = New System.Windows.Forms.GroupBox
        Me.TempTextBox = New System.Windows.Forms.TextBox
        Me.NotSetPointLabel = New System.Windows.Forms.Label
        Me.TrailersListBox = New System.Windows.Forms.ListBox
        Me.PalletLoadGroupBox = New System.Windows.Forms.GroupBox
        Me.PalletLoadLabel = New System.Windows.Forms.Label
        Me.ActionButton = New System.Windows.Forms.Button
        Me.CloseButton = New System.Windows.Forms.Button
        Me.TrailerTypeLabel = New System.Windows.Forms.Label
        Me.SelectTrailerGroupBox.SuspendLayout()
        Me.TemperatureGroupBox.SuspendLayout()
        Me.SearchTabControl.SuspendLayout()
        Me.TrailerIDTabPage.SuspendLayout()
        Me.CarrierTabPage.SuspendLayout()
        Me.LoadNumberTabPage.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.LegacyPalletGroupBox.SuspendLayout()
        Me.NewPalletsGroupBox.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.LocationGroupBox.SuspendLayout()
        Me.SetPointGroupBox.SuspendLayout()
        Me.PalletLoadGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'SelectTrailerGroupBox
        '
        Me.SelectTrailerGroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SelectTrailerGroupBox.Controls.Add(Me.TemperatureGroupBox)
        Me.SelectTrailerGroupBox.Controls.Add(Me.UserInitialsTextBox)
        Me.SelectTrailerGroupBox.Controls.Add(Me.Label10)
        Me.SelectTrailerGroupBox.Controls.Add(Me.Label1)
        Me.SelectTrailerGroupBox.Controls.Add(Me.SearchTabControl)
        Me.SelectTrailerGroupBox.Controls.Add(Me.GroupBox5)
        Me.SelectTrailerGroupBox.Controls.Add(Me.Label5)
        Me.SelectTrailerGroupBox.Controls.Add(Me.InstructionsTextBox)
        Me.SelectTrailerGroupBox.Controls.Add(Me.GroupBox4)
        Me.SelectTrailerGroupBox.Controls.Add(Me.LegacyPalletGroupBox)
        Me.SelectTrailerGroupBox.Controls.Add(Me.GroupBox2)
        Me.SelectTrailerGroupBox.Controls.Add(Me.LocationGroupBox)
        Me.SelectTrailerGroupBox.Controls.Add(Me.SetPointGroupBox)
        Me.SelectTrailerGroupBox.Controls.Add(Me.TrailersListBox)
        Me.SelectTrailerGroupBox.Controls.Add(Me.PalletLoadGroupBox)
        Me.SelectTrailerGroupBox.Location = New System.Drawing.Point(4, 5)
        Me.SelectTrailerGroupBox.Name = "SelectTrailerGroupBox"
        Me.SelectTrailerGroupBox.Size = New System.Drawing.Size(847, 541)
        Me.SelectTrailerGroupBox.TabIndex = 0
        Me.SelectTrailerGroupBox.TabStop = False
        '
        'TemperatureGroupBox
        '
        Me.TemperatureGroupBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TemperatureGroupBox.Controls.Add(Me.SetTempPreviewC)
        Me.TemperatureGroupBox.Controls.Add(Me.SetTempPreviewF)
        Me.TemperatureGroupBox.Controls.Add(Me.CelsiusRadioButton)
        Me.TemperatureGroupBox.Controls.Add(Me.FahrenheitRadioButton)
        Me.TemperatureGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TemperatureGroupBox.ForeColor = System.Drawing.Color.SaddleBrown
        Me.TemperatureGroupBox.Location = New System.Drawing.Point(576, 172)
        Me.TemperatureGroupBox.Name = "TemperatureGroupBox"
        Me.TemperatureGroupBox.Size = New System.Drawing.Size(263, 61)
        Me.TemperatureGroupBox.TabIndex = 17
        Me.TemperatureGroupBox.TabStop = False
        Me.TemperatureGroupBox.Text = "Temperature Setting"
        '
        'SetTempPreviewC
        '
        Me.SetTempPreviewC.AutoSize = True
        Me.SetTempPreviewC.ForeColor = System.Drawing.Color.ForestGreen
        Me.SetTempPreviewC.Location = New System.Drawing.Point(204, 34)
        Me.SetTempPreviewC.Name = "SetTempPreviewC"
        Me.SetTempPreviewC.Size = New System.Drawing.Size(29, 18)
        Me.SetTempPreviewC.TabIndex = 3
        Me.SetTempPreviewC.Text = "0C"
        '
        'SetTempPreviewF
        '
        Me.SetTempPreviewF.AutoSize = True
        Me.SetTempPreviewF.ForeColor = System.Drawing.Color.ForestGreen
        Me.SetTempPreviewF.Location = New System.Drawing.Point(90, 34)
        Me.SetTempPreviewF.Name = "SetTempPreviewF"
        Me.SetTempPreviewF.Size = New System.Drawing.Size(36, 18)
        Me.SetTempPreviewF.TabIndex = 2
        Me.SetTempPreviewF.Text = "32F"
        '
        'CelsiusRadioButton
        '
        Me.CelsiusRadioButton.AutoSize = True
        Me.CelsiusRadioButton.BackColor = System.Drawing.Color.Transparent
        Me.CelsiusRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CelsiusRadioButton.ForeColor = System.Drawing.Color.Black
        Me.CelsiusRadioButton.Location = New System.Drawing.Point(139, 34)
        Me.CelsiusRadioButton.Name = "CelsiusRadioButton"
        Me.CelsiusRadioButton.Size = New System.Drawing.Size(58, 17)
        Me.CelsiusRadioButton.TabIndex = 1
        Me.CelsiusRadioButton.Text = "Celsius"
        Me.CelsiusRadioButton.UseVisualStyleBackColor = False
        '
        'FahrenheitRadioButton
        '
        Me.FahrenheitRadioButton.AutoSize = True
        Me.FahrenheitRadioButton.BackColor = System.Drawing.Color.LimeGreen
        Me.FahrenheitRadioButton.Checked = True
        Me.FahrenheitRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FahrenheitRadioButton.ForeColor = System.Drawing.Color.Black
        Me.FahrenheitRadioButton.Location = New System.Drawing.Point(13, 34)
        Me.FahrenheitRadioButton.Name = "FahrenheitRadioButton"
        Me.FahrenheitRadioButton.Size = New System.Drawing.Size(75, 17)
        Me.FahrenheitRadioButton.TabIndex = 0
        Me.FahrenheitRadioButton.TabStop = True
        Me.FahrenheitRadioButton.Text = "Fahrenheit"
        Me.FahrenheitRadioButton.UseVisualStyleBackColor = False
        '
        'UserInitialsTextBox
        '
        Me.UserInitialsTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserInitialsTextBox.Location = New System.Drawing.Point(413, 461)
        Me.UserInitialsTextBox.MaxLength = 2
        Me.UserInitialsTextBox.Name = "UserInitialsTextBox"
        Me.UserInitialsTextBox.Size = New System.Drawing.Size(93, 23)
        Me.UserInitialsTextBox.TabIndex = 15
        Me.UserInitialsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(410, 445)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Initials (REQUIRED)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(13, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "SEARCH RESULTS"
        '
        'SearchTabControl
        '
        Me.SearchTabControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchTabControl.Controls.Add(Me.TrailerIDTabPage)
        Me.SearchTabControl.Controls.Add(Me.CarrierTabPage)
        Me.SearchTabControl.Controls.Add(Me.LoadNumberTabPage)
        Me.SearchTabControl.Location = New System.Drawing.Point(16, 11)
        Me.SearchTabControl.Name = "SearchTabControl"
        Me.SearchTabControl.SelectedIndex = 0
        Me.SearchTabControl.Size = New System.Drawing.Size(551, 90)
        Me.SearchTabControl.TabIndex = 12
        '
        'TrailerIDTabPage
        '
        Me.TrailerIDTabPage.Controls.Add(Me.Label9)
        Me.TrailerIDTabPage.Controls.Add(Me.FindTrailerIDButton)
        Me.TrailerIDTabPage.Controls.Add(Me.FindTrailerIDTextBox)
        Me.TrailerIDTabPage.Location = New System.Drawing.Point(4, 22)
        Me.TrailerIDTabPage.Name = "TrailerIDTabPage"
        Me.TrailerIDTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.TrailerIDTabPage.Size = New System.Drawing.Size(543, 64)
        Me.TrailerIDTabPage.TabIndex = 1
        Me.TrailerIDTabPage.Text = "Find by Trailer Number"
        Me.TrailerIDTabPage.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label9.Location = New System.Drawing.Point(10, 7)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(222, 54)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Type part or all of the trailer number then click find. Matching trailers will be" & _
            " shown in the list below." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'FindTrailerIDButton
        '
        Me.FindTrailerIDButton.Location = New System.Drawing.Point(395, 20)
        Me.FindTrailerIDButton.Name = "FindTrailerIDButton"
        Me.FindTrailerIDButton.Size = New System.Drawing.Size(75, 23)
        Me.FindTrailerIDButton.TabIndex = 1
        Me.FindTrailerIDButton.Text = "Find"
        Me.FindTrailerIDButton.UseVisualStyleBackColor = True
        '
        'FindTrailerIDTextBox
        '
        Me.FindTrailerIDTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FindTrailerIDTextBox.Location = New System.Drawing.Point(247, 22)
        Me.FindTrailerIDTextBox.MaxLength = 15
        Me.FindTrailerIDTextBox.Name = "FindTrailerIDTextBox"
        Me.FindTrailerIDTextBox.Size = New System.Drawing.Size(142, 20)
        Me.FindTrailerIDTextBox.TabIndex = 0
        '
        'CarrierTabPage
        '
        Me.CarrierTabPage.Controls.Add(Me.CarrierComboBox)
        Me.CarrierTabPage.Location = New System.Drawing.Point(4, 22)
        Me.CarrierTabPage.Name = "CarrierTabPage"
        Me.CarrierTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.CarrierTabPage.Size = New System.Drawing.Size(543, 64)
        Me.CarrierTabPage.TabIndex = 0
        Me.CarrierTabPage.Text = "Find by Carrier Name"
        Me.CarrierTabPage.UseVisualStyleBackColor = True
        '
        'CarrierComboBox
        '
        Me.CarrierComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CarrierComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CarrierComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CarrierComboBox.FormattingEnabled = True
        Me.CarrierComboBox.Location = New System.Drawing.Point(6, 21)
        Me.CarrierComboBox.Name = "CarrierComboBox"
        Me.CarrierComboBox.Size = New System.Drawing.Size(517, 21)
        Me.CarrierComboBox.TabIndex = 1
        '
        'LoadNumberTabPage
        '
        Me.LoadNumberTabPage.Controls.Add(Me.LoadNumberInfoLabel)
        Me.LoadNumberTabPage.Controls.Add(Me.FindByLoadNumberButton)
        Me.LoadNumberTabPage.Controls.Add(Me.LoadNumberTextBox)
        Me.LoadNumberTabPage.Location = New System.Drawing.Point(4, 22)
        Me.LoadNumberTabPage.Name = "LoadNumberTabPage"
        Me.LoadNumberTabPage.Size = New System.Drawing.Size(543, 64)
        Me.LoadNumberTabPage.TabIndex = 2
        Me.LoadNumberTabPage.Text = "Find by Load Number"
        Me.LoadNumberTabPage.UseVisualStyleBackColor = True
        '
        'LoadNumberInfoLabel
        '
        Me.LoadNumberInfoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadNumberInfoLabel.ForeColor = System.Drawing.Color.DarkBlue
        Me.LoadNumberInfoLabel.Location = New System.Drawing.Point(11, 5)
        Me.LoadNumberInfoLabel.Name = "LoadNumberInfoLabel"
        Me.LoadNumberInfoLabel.Size = New System.Drawing.Size(222, 54)
        Me.LoadNumberInfoLabel.TabIndex = 5
        Me.LoadNumberInfoLabel.Text = "Enter the load number then click find. Matching trailers will be shown in the lis" & _
            "t below."
        '
        'FindByLoadNumberButton
        '
        Me.FindByLoadNumberButton.Location = New System.Drawing.Point(396, 18)
        Me.FindByLoadNumberButton.Name = "FindByLoadNumberButton"
        Me.FindByLoadNumberButton.Size = New System.Drawing.Size(75, 23)
        Me.FindByLoadNumberButton.TabIndex = 4
        Me.FindByLoadNumberButton.Text = "Find"
        Me.FindByLoadNumberButton.UseVisualStyleBackColor = True
        '
        'LoadNumberTextBox
        '
        Me.LoadNumberTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.LoadNumberTextBox.Location = New System.Drawing.Point(248, 20)
        Me.LoadNumberTextBox.MaxLength = 15
        Me.LoadNumberTextBox.Name = "LoadNumberTextBox"
        Me.LoadNumberTextBox.Size = New System.Drawing.Size(142, 20)
        Me.LoadNumberTextBox.TabIndex = 3
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.PriorityCheckBox)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(709, 89)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(130, 76)
        Me.GroupBox5.TabIndex = 11
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Priority Move"
        '
        'PriorityCheckBox
        '
        Me.PriorityCheckBox.AutoSize = True
        Me.PriorityCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriorityCheckBox.ForeColor = System.Drawing.Color.Red
        Me.PriorityCheckBox.Location = New System.Drawing.Point(15, 32)
        Me.PriorityCheckBox.Name = "PriorityCheckBox"
        Me.PriorityCheckBox.Size = New System.Drawing.Size(105, 20)
        Me.PriorityCheckBox.TabIndex = 0
        Me.PriorityCheckBox.Text = "Priority Move"
        Me.PriorityCheckBox.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(156, 445)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Special Instructions"
        '
        'InstructionsTextBox
        '
        Me.InstructionsTextBox.Location = New System.Drawing.Point(156, 461)
        Me.InstructionsTextBox.MaxLength = 300
        Me.InstructionsTextBox.Multiline = True
        Me.InstructionsTextBox.Name = "InstructionsTextBox"
        Me.InstructionsTextBox.Size = New System.Drawing.Size(253, 66)
        Me.InstructionsTextBox.TabIndex = 9
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ShowTrailerIDLabel)
        Me.GroupBox4.Controls.Add(Me.ShowCarrierNameLabel)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(156, 109)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(411, 62)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Selected Trailer"
        '
        'ShowTrailerIDLabel
        '
        Me.ShowTrailerIDLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ShowTrailerIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowTrailerIDLabel.ForeColor = System.Drawing.Color.Red
        Me.ShowTrailerIDLabel.Location = New System.Drawing.Point(9, 38)
        Me.ShowTrailerIDLabel.Name = "ShowTrailerIDLabel"
        Me.ShowTrailerIDLabel.Size = New System.Drawing.Size(396, 23)
        Me.ShowTrailerIDLabel.TabIndex = 1
        Me.ShowTrailerIDLabel.Text = "ShowTrailerID"
        Me.ShowTrailerIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ShowTrailerIDLabel.UseMnemonic = False
        '
        'ShowCarrierNameLabel
        '
        Me.ShowCarrierNameLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ShowCarrierNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowCarrierNameLabel.ForeColor = System.Drawing.Color.MediumBlue
        Me.ShowCarrierNameLabel.Location = New System.Drawing.Point(9, 17)
        Me.ShowCarrierNameLabel.Name = "ShowCarrierNameLabel"
        Me.ShowCarrierNameLabel.Size = New System.Drawing.Size(396, 23)
        Me.ShowCarrierNameLabel.TabIndex = 0
        Me.ShowCarrierNameLabel.Text = "ShowCarrierName"
        Me.ShowCarrierNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ShowCarrierNameLabel.UseMnemonic = False
        '
        'LegacyPalletGroupBox
        '
        Me.LegacyPalletGroupBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LegacyPalletGroupBox.Controls.Add(Me.Label4)
        Me.LegacyPalletGroupBox.Controls.Add(Me.NewPalletsGroupBox)
        Me.LegacyPalletGroupBox.Controls.Add(Me.ChangePalletsCheckbox)
        Me.LegacyPalletGroupBox.Controls.Add(Me.GroupBox6)
        Me.LegacyPalletGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LegacyPalletGroupBox.ForeColor = System.Drawing.Color.SaddleBrown
        Me.LegacyPalletGroupBox.Location = New System.Drawing.Point(573, 239)
        Me.LegacyPalletGroupBox.Name = "LegacyPalletGroupBox"
        Me.LegacyPalletGroupBox.Size = New System.Drawing.Size(266, 285)
        Me.LegacyPalletGroupBox.TabIndex = 7
        Me.LegacyPalletGroupBox.TabStop = False
        Me.LegacyPalletGroupBox.Text = "Pallets"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(8, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(246, 1)
        Me.Label4.TabIndex = 8
        '
        'NewPalletsGroupBox
        '
        Me.NewPalletsGroupBox.Controls.Add(Me.NoPalletsRadioButton)
        Me.NewPalletsGroupBox.Controls.Add(Me.ChepPalletsRadioButton)
        Me.NewPalletsGroupBox.Controls.Add(Me.WhitePalletsRadioButton)
        Me.NewPalletsGroupBox.Controls.Add(Me.HeatTreatedPalletsRadioButton)
        Me.NewPalletsGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.NewPalletsGroupBox.Enabled = False
        Me.NewPalletsGroupBox.Location = New System.Drawing.Point(3, 197)
        Me.NewPalletsGroupBox.Name = "NewPalletsGroupBox"
        Me.NewPalletsGroupBox.Size = New System.Drawing.Size(260, 85)
        Me.NewPalletsGroupBox.TabIndex = 7
        Me.NewPalletsGroupBox.TabStop = False
        Me.NewPalletsGroupBox.Text = "New Pallets"
        '
        'NoPalletsRadioButton
        '
        Me.NoPalletsRadioButton.AutoSize = True
        Me.NoPalletsRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoPalletsRadioButton.ForeColor = System.Drawing.Color.Red
        Me.NoPalletsRadioButton.Location = New System.Drawing.Point(6, 27)
        Me.NoPalletsRadioButton.Name = "NoPalletsRadioButton"
        Me.NoPalletsRadioButton.Size = New System.Drawing.Size(56, 17)
        Me.NoPalletsRadioButton.TabIndex = 0
        Me.NoPalletsRadioButton.Text = "NONE"
        Me.NoPalletsRadioButton.UseVisualStyleBackColor = True
        '
        'ChepPalletsRadioButton
        '
        Me.ChepPalletsRadioButton.AutoSize = True
        Me.ChepPalletsRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChepPalletsRadioButton.Location = New System.Drawing.Point(6, 50)
        Me.ChepPalletsRadioButton.Name = "ChepPalletsRadioButton"
        Me.ChepPalletsRadioButton.Size = New System.Drawing.Size(91, 17)
        Me.ChepPalletsRadioButton.TabIndex = 1
        Me.ChepPalletsRadioButton.TabStop = True
        Me.ChepPalletsRadioButton.Text = "CHEP (BLUE)"
        Me.ChepPalletsRadioButton.UseVisualStyleBackColor = True
        '
        'WhitePalletsRadioButton
        '
        Me.WhitePalletsRadioButton.AutoSize = True
        Me.WhitePalletsRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhitePalletsRadioButton.ForeColor = System.Drawing.Color.SaddleBrown
        Me.WhitePalletsRadioButton.Location = New System.Drawing.Point(97, 50)
        Me.WhitePalletsRadioButton.Name = "WhitePalletsRadioButton"
        Me.WhitePalletsRadioButton.Size = New System.Drawing.Size(95, 17)
        Me.WhitePalletsRadioButton.TabIndex = 2
        Me.WhitePalletsRadioButton.Text = "PLAIN WHITE"
        Me.WhitePalletsRadioButton.UseVisualStyleBackColor = True
        '
        'HeatTreatedPalletsRadioButton
        '
        Me.HeatTreatedPalletsRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HeatTreatedPalletsRadioButton.Location = New System.Drawing.Point(97, 22)
        Me.HeatTreatedPalletsRadioButton.Name = "HeatTreatedPalletsRadioButton"
        Me.HeatTreatedPalletsRadioButton.Size = New System.Drawing.Size(154, 27)
        Me.HeatTreatedPalletsRadioButton.TabIndex = 3
        Me.HeatTreatedPalletsRadioButton.TabStop = True
        Me.HeatTreatedPalletsRadioButton.Text = "WHITE HEAT TREATED"
        Me.HeatTreatedPalletsRadioButton.UseVisualStyleBackColor = True
        '
        'ChangePalletsCheckbox
        '
        Me.ChangePalletsCheckbox.AutoSize = True
        Me.ChangePalletsCheckbox.ForeColor = System.Drawing.Color.Red
        Me.ChangePalletsCheckbox.Location = New System.Drawing.Point(55, 132)
        Me.ChangePalletsCheckbox.Name = "ChangePalletsCheckbox"
        Me.ChangePalletsCheckbox.Size = New System.Drawing.Size(140, 22)
        Me.ChangePalletsCheckbox.TabIndex = 6
        Me.ChangePalletsCheckbox.Text = "Change Pallets"
        Me.ChangePalletsCheckbox.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.PalletsOnBoardLabel)
        Me.GroupBox6.Location = New System.Drawing.Point(9, 29)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(245, 66)
        Me.GroupBox6.TabIndex = 4
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Current (On Board)"
        '
        'PalletsOnBoardLabel
        '
        Me.PalletsOnBoardLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PalletsOnBoardLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PalletsOnBoardLabel.ForeColor = System.Drawing.Color.Red
        Me.PalletsOnBoardLabel.Location = New System.Drawing.Point(3, 20)
        Me.PalletsOnBoardLabel.Name = "PalletsOnBoardLabel"
        Me.PalletsOnBoardLabel.Size = New System.Drawing.Size(239, 43)
        Me.PalletsOnBoardLabel.TabIndex = 3
        Me.PalletsOnBoardLabel.Text = "CHEP"
        Me.PalletsOnBoardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.TrailerTypeLabel)
        Me.GroupBox2.Controls.Add(Me.LoadNumberLabel)
        Me.GroupBox2.Controls.Add(Me.LoadNumberLabelHeader)
        Me.GroupBox2.Controls.Add(Me.OOSLabelNotes)
        Me.GroupBox2.Controls.Add(Me.OOSLabel)
        Me.GroupBox2.Controls.Add(Me.PrecoolStartedLabel)
        Me.GroupBox2.Controls.Add(Me.PreCoolingLabel)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.ClassLabel)
        Me.GroupBox2.Controls.Add(Me.MoveStatusLabel)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.CurrentTemperatureLabel)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.CurrentLocationLabel)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.LoadStatusLabel)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(156, 177)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(411, 265)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Trailer Details"
        '
        'LoadNumberLabel
        '
        Me.LoadNumberLabel.AutoSize = True
        Me.LoadNumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadNumberLabel.ForeColor = System.Drawing.Color.ForestGreen
        Me.LoadNumberLabel.Location = New System.Drawing.Point(5, 140)
        Me.LoadNumberLabel.Name = "LoadNumberLabel"
        Me.LoadNumberLabel.Size = New System.Drawing.Size(69, 20)
        Me.LoadNumberLabel.TabIndex = 19
        Me.LoadNumberLabel.Text = "123456"
        Me.LoadNumberLabel.Visible = False
        '
        'LoadNumberLabelHeader
        '
        Me.LoadNumberLabelHeader.AutoSize = True
        Me.LoadNumberLabelHeader.Location = New System.Drawing.Point(6, 127)
        Me.LoadNumberLabelHeader.Name = "LoadNumberLabelHeader"
        Me.LoadNumberLabelHeader.Size = New System.Drawing.Size(74, 13)
        Me.LoadNumberLabelHeader.TabIndex = 18
        Me.LoadNumberLabelHeader.Text = "Load Number:"
        Me.LoadNumberLabelHeader.Visible = False
        '
        'OOSLabelNotes
        '
        Me.OOSLabelNotes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OOSLabelNotes.Location = New System.Drawing.Point(6, 214)
        Me.OOSLabelNotes.Name = "OOSLabelNotes"
        Me.OOSLabelNotes.Size = New System.Drawing.Size(399, 44)
        Me.OOSLabelNotes.TabIndex = 15
        Me.OOSLabelNotes.Text = "Notes"
        '
        'OOSLabel
        '
        Me.OOSLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.OOSLabel.AutoSize = True
        Me.OOSLabel.BackColor = System.Drawing.Color.Red
        Me.OOSLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OOSLabel.ForeColor = System.Drawing.Color.White
        Me.OOSLabel.Location = New System.Drawing.Point(8, 184)
        Me.OOSLabel.Name = "OOSLabel"
        Me.OOSLabel.Size = New System.Drawing.Size(123, 20)
        Me.OOSLabel.TabIndex = 14
        Me.OOSLabel.Text = "Out of Service"
        Me.OOSLabel.Visible = False
        '
        'PrecoolStartedLabel
        '
        Me.PrecoolStartedLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrecoolStartedLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrecoolStartedLabel.ForeColor = System.Drawing.Color.Red
        Me.PrecoolStartedLabel.Location = New System.Drawing.Point(244, 191)
        Me.PrecoolStartedLabel.Name = "PrecoolStartedLabel"
        Me.PrecoolStartedLabel.Size = New System.Drawing.Size(161, 13)
        Me.PrecoolStartedLabel.TabIndex = 13
        Me.PrecoolStartedLabel.Text = "PrecoolStarted"
        Me.PrecoolStartedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.PrecoolStartedLabel.UseMnemonic = False
        '
        'PreCoolingLabel
        '
        Me.PreCoolingLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PreCoolingLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PreCoolingLabel.ForeColor = System.Drawing.Color.Blue
        Me.PreCoolingLabel.Location = New System.Drawing.Point(240, 171)
        Me.PreCoolingLabel.Name = "PreCoolingLabel"
        Me.PreCoolingLabel.Size = New System.Drawing.Size(165, 20)
        Me.PreCoolingLabel.TabIndex = 12
        Me.PreCoolingLabel.Text = "PRE-COOLING"
        Me.PreCoolingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 91)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Trailer Classification:"
        '
        'ClassLabel
        '
        Me.ClassLabel.AutoSize = True
        Me.ClassLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClassLabel.ForeColor = System.Drawing.Color.ForestGreen
        Me.ClassLabel.Location = New System.Drawing.Point(5, 104)
        Me.ClassLabel.Name = "ClassLabel"
        Me.ClassLabel.Size = New System.Drawing.Size(155, 20)
        Me.ClassLabel.TabIndex = 10
        Me.ClassLabel.Text = "CLASSIFICATION"
        '
        'MoveStatusLabel
        '
        Me.MoveStatusLabel.AutoSize = True
        Me.MoveStatusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MoveStatusLabel.ForeColor = System.Drawing.Color.ForestGreen
        Me.MoveStatusLabel.Location = New System.Drawing.Point(114, 67)
        Me.MoveStatusLabel.Name = "MoveStatusLabel"
        Me.MoveStatusLabel.Size = New System.Drawing.Size(84, 20)
        Me.MoveStatusLabel.TabIndex = 9
        Me.MoveStatusLabel.Text = "IN DOOR"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(115, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Status:"
        '
        'CurrentTemperatureLabel
        '
        Me.CurrentTemperatureLabel.AutoSize = True
        Me.CurrentTemperatureLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentTemperatureLabel.ForeColor = System.Drawing.Color.ForestGreen
        Me.CurrentTemperatureLabel.Location = New System.Drawing.Point(193, 29)
        Me.CurrentTemperatureLabel.Name = "CurrentTemperatureLabel"
        Me.CurrentTemperatureLabel.Size = New System.Drawing.Size(29, 20)
        Me.CurrentTemperatureLabel.TabIndex = 7
        Me.CurrentTemperatureLabel.Text = "25"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(194, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(153, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Current Temperature Set Point:"
        '
        'CurrentLocationLabel
        '
        Me.CurrentLocationLabel.AutoSize = True
        Me.CurrentLocationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentLocationLabel.ForeColor = System.Drawing.Color.ForestGreen
        Me.CurrentLocationLabel.Location = New System.Drawing.Point(5, 67)
        Me.CurrentLocationLabel.Name = "CurrentLocationLabel"
        Me.CurrentLocationLabel.Size = New System.Drawing.Size(31, 20)
        Me.CurrentLocationLabel.TabIndex = 5
        Me.CurrentLocationLabel.Text = "E1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Current Location:"
        '
        'LoadStatusLabel
        '
        Me.LoadStatusLabel.AutoSize = True
        Me.LoadStatusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadStatusLabel.ForeColor = System.Drawing.Color.ForestGreen
        Me.LoadStatusLabel.Location = New System.Drawing.Point(5, 29)
        Me.LoadStatusLabel.Name = "LoadStatusLabel"
        Me.LoadStatusLabel.Size = New System.Drawing.Size(101, 20)
        Me.LoadStatusLabel.TabIndex = 1
        Me.LoadStatusLabel.Text = "Empty/Dirty"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Current Load Status:"
        '
        'LocationGroupBox
        '
        Me.LocationGroupBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LocationGroupBox.Controls.Add(Me.DoorLabel)
        Me.LocationGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LocationGroupBox.ForeColor = System.Drawing.Color.Chocolate
        Me.LocationGroupBox.Location = New System.Drawing.Point(573, 9)
        Me.LocationGroupBox.Name = "LocationGroupBox"
        Me.LocationGroupBox.Size = New System.Drawing.Size(266, 73)
        Me.LocationGroupBox.TabIndex = 5
        Me.LocationGroupBox.TabStop = False
        Me.LocationGroupBox.Text = "Location"
        '
        'DoorLabel
        '
        Me.DoorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DoorLabel.ForeColor = System.Drawing.Color.ForestGreen
        Me.DoorLabel.Location = New System.Drawing.Point(6, 24)
        Me.DoorLabel.Name = "DoorLabel"
        Me.DoorLabel.Size = New System.Drawing.Size(250, 33)
        Me.DoorLabel.TabIndex = 4
        Me.DoorLabel.Text = "DOOR:"
        Me.DoorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SetPointGroupBox
        '
        Me.SetPointGroupBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SetPointGroupBox.BackColor = System.Drawing.SystemColors.Control
        Me.SetPointGroupBox.Controls.Add(Me.TempTextBox)
        Me.SetPointGroupBox.Controls.Add(Me.NotSetPointLabel)
        Me.SetPointGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SetPointGroupBox.Location = New System.Drawing.Point(573, 91)
        Me.SetPointGroupBox.Name = "SetPointGroupBox"
        Me.SetPointGroupBox.Size = New System.Drawing.Size(130, 74)
        Me.SetPointGroupBox.TabIndex = 3
        Me.SetPointGroupBox.TabStop = False
        Me.SetPointGroupBox.Text = "NEW Temp Set Point"
        '
        'TempTextBox
        '
        Me.TempTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TempTextBox.ForeColor = System.Drawing.Color.Red
        Me.TempTextBox.Location = New System.Drawing.Point(3, 21)
        Me.TempTextBox.MaxLength = 6
        Me.TempTextBox.Name = "TempTextBox"
        Me.TempTextBox.Size = New System.Drawing.Size(124, 44)
        Me.TempTextBox.TabIndex = 0
        Me.TempTextBox.Text = "-10"
        Me.TempTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NotSetPointLabel
        '
        Me.NotSetPointLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NotSetPointLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NotSetPointLabel.ForeColor = System.Drawing.Color.Red
        Me.NotSetPointLabel.Location = New System.Drawing.Point(3, 16)
        Me.NotSetPointLabel.Name = "NotSetPointLabel"
        Me.NotSetPointLabel.Size = New System.Drawing.Size(124, 55)
        Me.NotSetPointLabel.TabIndex = 1
        Me.NotSetPointLabel.Text = "NO TEMP NEEDED." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CLICK TO SET"
        Me.NotSetPointLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TrailersListBox
        '
        Me.TrailersListBox.FormattingEnabled = True
        Me.TrailersListBox.Location = New System.Drawing.Point(16, 120)
        Me.TrailersListBox.Name = "TrailersListBox"
        Me.TrailersListBox.Size = New System.Drawing.Size(134, 407)
        Me.TrailersListBox.Sorted = True
        Me.TrailersListBox.TabIndex = 0
        '
        'PalletLoadGroupBox
        '
        Me.PalletLoadGroupBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PalletLoadGroupBox.Controls.Add(Me.PalletLoadLabel)
        Me.PalletLoadGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PalletLoadGroupBox.ForeColor = System.Drawing.Color.SaddleBrown
        Me.PalletLoadGroupBox.Location = New System.Drawing.Point(576, 239)
        Me.PalletLoadGroupBox.Name = "PalletLoadGroupBox"
        Me.PalletLoadGroupBox.Size = New System.Drawing.Size(263, 85)
        Me.PalletLoadGroupBox.TabIndex = 16
        Me.PalletLoadGroupBox.TabStop = False
        Me.PalletLoadGroupBox.Text = "Pallet Load"
        '
        'PalletLoadLabel
        '
        Me.PalletLoadLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PalletLoadLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PalletLoadLabel.ForeColor = System.Drawing.Color.Black
        Me.PalletLoadLabel.Location = New System.Drawing.Point(6, 40)
        Me.PalletLoadLabel.Name = "PalletLoadLabel"
        Me.PalletLoadLabel.Size = New System.Drawing.Size(251, 18)
        Me.PalletLoadLabel.TabIndex = 0
        Me.PalletLoadLabel.Text = "PalletLoadLabel"
        Me.PalletLoadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ActionButton
        '
        Me.ActionButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ActionButton.Location = New System.Drawing.Point(719, 552)
        Me.ActionButton.Name = "ActionButton"
        Me.ActionButton.Size = New System.Drawing.Size(124, 36)
        Me.ActionButton.TabIndex = 1
        Me.ActionButton.Text = "SAVE"
        Me.ActionButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseButton.Location = New System.Drawing.Point(610, 552)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(103, 36)
        Me.CloseButton.TabIndex = 2
        Me.CloseButton.Text = "CLOSE"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'TrailerTypeLabel
        '
        Me.TrailerTypeLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TrailerTypeLabel.AutoSize = True
        Me.TrailerTypeLabel.BackColor = System.Drawing.Color.White
        Me.TrailerTypeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrailerTypeLabel.ForeColor = System.Drawing.Color.Black
        Me.TrailerTypeLabel.Location = New System.Drawing.Point(381, 12)
        Me.TrailerTypeLabel.Name = "TrailerTypeLabel"
        Me.TrailerTypeLabel.Size = New System.Drawing.Size(24, 24)
        Me.TrailerTypeLabel.TabIndex = 20
        Me.TrailerTypeLabel.Text = "R"
        Me.TrailerTypeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TrailerRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(855, 600)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.ActionButton)
        Me.Controls.Add(Me.SelectTrailerGroupBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TrailerRequest"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Trailer Request"
        Me.SelectTrailerGroupBox.ResumeLayout(False)
        Me.SelectTrailerGroupBox.PerformLayout()
        Me.TemperatureGroupBox.ResumeLayout(False)
        Me.TemperatureGroupBox.PerformLayout()
        Me.SearchTabControl.ResumeLayout(False)
        Me.TrailerIDTabPage.ResumeLayout(False)
        Me.TrailerIDTabPage.PerformLayout()
        Me.CarrierTabPage.ResumeLayout(False)
        Me.LoadNumberTabPage.ResumeLayout(False)
        Me.LoadNumberTabPage.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.LegacyPalletGroupBox.ResumeLayout(False)
        Me.LegacyPalletGroupBox.PerformLayout()
        Me.NewPalletsGroupBox.ResumeLayout(False)
        Me.NewPalletsGroupBox.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.LocationGroupBox.ResumeLayout(False)
        Me.SetPointGroupBox.ResumeLayout(False)
        Me.SetPointGroupBox.PerformLayout()
        Me.PalletLoadGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SelectTrailerGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents TrailersListBox As System.Windows.Forms.ListBox
    Friend WithEvents ActionButton As System.Windows.Forms.Button
    Friend WithEvents CloseButton As System.Windows.Forms.Button
    Friend WithEvents CarrierComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SetPointGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents TempTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DoorLabel As System.Windows.Forms.Label
    Friend WithEvents LocationGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LegacyPalletGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents HeatTreatedPalletsRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents WhitePalletsRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents ChepPalletsRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents NoPalletsRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents PalletsOnBoardLabel As System.Windows.Forms.Label
    Friend WithEvents LoadStatusLabel As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CurrentTemperatureLabel As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CurrentLocationLabel As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents ShowTrailerIDLabel As System.Windows.Forms.Label
    Friend WithEvents ShowCarrierNameLabel As System.Windows.Forms.Label
    Friend WithEvents MoveStatusLabel As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents InstructionsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents PriorityCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SearchTabControl As System.Windows.Forms.TabControl
    Friend WithEvents CarrierTabPage As System.Windows.Forms.TabPage
    Friend WithEvents TrailerIDTabPage As System.Windows.Forms.TabPage
    Friend WithEvents FindTrailerIDButton As System.Windows.Forms.Button
    Friend WithEvents FindTrailerIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents NewPalletsGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents ChangePalletsCheckbox As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ClassLabel As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents NotSetPointLabel As System.Windows.Forms.Label
    Friend WithEvents PreCoolingLabel As System.Windows.Forms.Label
    Friend WithEvents PrecoolStartedLabel As System.Windows.Forms.Label
    Friend WithEvents OOSLabel As System.Windows.Forms.Label
    Friend WithEvents OOSLabelNotes As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents UserInitialsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LoadNumberTabPage As System.Windows.Forms.TabPage
    Friend WithEvents LoadNumberInfoLabel As System.Windows.Forms.Label
    Friend WithEvents FindByLoadNumberButton As System.Windows.Forms.Button
    Friend WithEvents LoadNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LoadNumberLabel As System.Windows.Forms.Label
    Friend WithEvents LoadNumberLabelHeader As System.Windows.Forms.Label
    Friend WithEvents PalletLoadGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents PalletLoadLabel As System.Windows.Forms.Label
    Friend WithEvents TemperatureGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents FahrenheitRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents CelsiusRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents SetTempPreviewC As System.Windows.Forms.Label
    Friend WithEvents SetTempPreviewF As System.Windows.Forms.Label
    Friend WithEvents TrailerTypeLabel As System.Windows.Forms.Label
End Class
