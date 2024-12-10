<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cactus
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
        Me.components = New System.ComponentModel.Container
        Dim ActionDateLabel As System.Windows.Forms.Label
        Dim CarrierNameLabel As System.Windows.Forms.Label
        Dim CabNumberLabel As System.Windows.Forms.Label
        Dim TrailerNumberLabel As System.Windows.Forms.Label
        Dim SONumberLabel As System.Windows.Forms.Label
        Dim ReferFuelLevelLabel As System.Windows.Forms.Label
        Dim OtherComponentsLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cactus))
        Me.CactusSpecificBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.CactusSpecificBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BarcodeDataSet = New KAR_Lot_SmartClient.karservices.cactus.smartclient.BarcodeDataSet
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.CactusSpecificBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.PrintToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.RefreshDataToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.ActionDateLabel1 = New System.Windows.Forms.Label
        Me.CarrierNameTextBox = New System.Windows.Forms.TextBox
        Me.CabNumberTextBox = New System.Windows.Forms.TextBox
        Me.TrailerNumberTextBox = New System.Windows.Forms.TextBox
        Me.SONumberTextBox = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ReferWillRunCheckBox = New System.Windows.Forms.CheckBox
        Me.GetDataBackgroundWorker = New System.ComponentModel.BackgroundWorker
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripProgressBar = New System.Windows.Forms.ToolStripProgressBar
        Me.OtherComponentsTextBox = New System.Windows.Forms.TextBox
        Me.ReferFuelLevelProgressBar = New System.Windows.Forms.ProgressBar
        Me.SequenceIDTextBox = New System.Windows.Forms.TextBox
        Me.DriverSigPictureBox = New System.Windows.Forms.PictureBox
        Me.SecurityPictureBox = New System.Windows.Forms.PictureBox
        ActionDateLabel = New System.Windows.Forms.Label
        CarrierNameLabel = New System.Windows.Forms.Label
        CabNumberLabel = New System.Windows.Forms.Label
        TrailerNumberLabel = New System.Windows.Forms.Label
        SONumberLabel = New System.Windows.Forms.Label
        ReferFuelLevelLabel = New System.Windows.Forms.Label
        OtherComponentsLabel = New System.Windows.Forms.Label
        CType(Me.CactusSpecificBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CactusSpecificBindingNavigator.SuspendLayout()
        CType(Me.CactusSpecificBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarcodeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.DriverSigPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SecurityPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ActionDateLabel
        '
        ActionDateLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ActionDateLabel.AutoSize = True
        ActionDateLabel.Location = New System.Drawing.Point(499, 42)
        ActionDateLabel.Name = "ActionDateLabel"
        ActionDateLabel.Size = New System.Drawing.Size(33, 13)
        ActionDateLabel.TabIndex = 0
        ActionDateLabel.Text = "Date:"
        '
        'CarrierNameLabel
        '
        CarrierNameLabel.AutoSize = True
        CarrierNameLabel.Location = New System.Drawing.Point(25, 42)
        CarrierNameLabel.Name = "CarrierNameLabel"
        CarrierNameLabel.Size = New System.Drawing.Size(71, 13)
        CarrierNameLabel.TabIndex = 2
        CarrierNameLabel.Text = "Carrier Name:"
        '
        'CabNumberLabel
        '
        CabNumberLabel.AutoSize = True
        CabNumberLabel.Location = New System.Drawing.Point(27, 68)
        CabNumberLabel.Name = "CabNumberLabel"
        CabNumberLabel.Size = New System.Drawing.Size(69, 13)
        CabNumberLabel.TabIndex = 4
        CabNumberLabel.Text = "Cab Number:"
        '
        'TrailerNumberLabel
        '
        TrailerNumberLabel.AutoSize = True
        TrailerNumberLabel.Location = New System.Drawing.Point(17, 94)
        TrailerNumberLabel.Name = "TrailerNumberLabel"
        TrailerNumberLabel.Size = New System.Drawing.Size(79, 13)
        TrailerNumberLabel.TabIndex = 6
        TrailerNumberLabel.Text = "Trailer Number:"
        '
        'SONumberLabel
        '
        SONumberLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        SONumberLabel.AutoSize = True
        SONumberLabel.Location = New System.Drawing.Point(229, 68)
        SONumberLabel.Name = "SONumberLabel"
        SONumberLabel.Size = New System.Drawing.Size(62, 13)
        SONumberLabel.TabIndex = 8
        SONumberLabel.Text = "SONumber:"
        '
        'ReferFuelLevelLabel
        '
        ReferFuelLevelLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReferFuelLevelLabel.AutoSize = True
        ReferFuelLevelLabel.Location = New System.Drawing.Point(499, 130)
        ReferFuelLevelLabel.Name = "ReferFuelLevelLabel"
        ReferFuelLevelLabel.Size = New System.Drawing.Size(88, 13)
        ReferFuelLevelLabel.TabIndex = 10
        ReferFuelLevelLabel.Text = "Refer Fuel Level:"
        '
        'OtherComponentsLabel
        '
        OtherComponentsLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        OtherComponentsLabel.AutoSize = True
        OtherComponentsLabel.Location = New System.Drawing.Point(499, 91)
        OtherComponentsLabel.Name = "OtherComponentsLabel"
        OtherComponentsLabel.Size = New System.Drawing.Size(98, 13)
        OtherComponentsLabel.TabIndex = 18
        OtherComponentsLabel.Text = "Other Components:"
        '
        'CactusSpecificBindingNavigator
        '
        Me.CactusSpecificBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CactusSpecificBindingNavigator.BindingSource = Me.CactusSpecificBindingSource
        Me.CactusSpecificBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CactusSpecificBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CactusSpecificBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CactusSpecificBindingNavigatorSaveItem, Me.ToolStripSeparator1, Me.PrintToolStripButton, Me.ToolStripSeparator2, Me.RefreshDataToolStripButton})
        Me.CactusSpecificBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CactusSpecificBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CactusSpecificBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CactusSpecificBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CactusSpecificBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CactusSpecificBindingNavigator.Name = "CactusSpecificBindingNavigator"
        Me.CactusSpecificBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CactusSpecificBindingNavigator.Size = New System.Drawing.Size(712, 25)
        Me.CactusSpecificBindingNavigator.TabIndex = 0
        Me.CactusSpecificBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'CactusSpecificBindingSource
        '
        Me.CactusSpecificBindingSource.AllowNew = False
        Me.CactusSpecificBindingSource.DataMember = "CactusSpecific"
        Me.CactusSpecificBindingSource.DataSource = Me.BarcodeDataSet
        '
        'BarcodeDataSet
        '
        Me.BarcodeDataSet.DataSetName = "BarcodeDataSet"
        Me.BarcodeDataSet.EnforceConstraints = False
        Me.BarcodeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'CactusSpecificBindingNavigatorSaveItem
        '
        Me.CactusSpecificBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CactusSpecificBindingNavigatorSaveItem.Enabled = False
        Me.CactusSpecificBindingNavigatorSaveItem.Image = CType(resources.GetObject("CactusSpecificBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CactusSpecificBindingNavigatorSaveItem.Name = "CactusSpecificBindingNavigatorSaveItem"
        Me.CactusSpecificBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CactusSpecificBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'PrintToolStripButton
        '
        Me.PrintToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PrintToolStripButton.Image = CType(resources.GetObject("PrintToolStripButton.Image"), System.Drawing.Image)
        Me.PrintToolStripButton.ImageTransparentColor = System.Drawing.Color.Silver
        Me.PrintToolStripButton.Name = "PrintToolStripButton"
        Me.PrintToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.PrintToolStripButton.Text = "Print Report"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'RefreshDataToolStripButton
        '
        Me.RefreshDataToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RefreshDataToolStripButton.Image = CType(resources.GetObject("RefreshDataToolStripButton.Image"), System.Drawing.Image)
        Me.RefreshDataToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RefreshDataToolStripButton.Name = "RefreshDataToolStripButton"
        Me.RefreshDataToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.RefreshDataToolStripButton.Text = "Syncronize Local Data"
        '
        'ActionDateLabel1
        '
        Me.ActionDateLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ActionDateLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ActionDateLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CactusSpecificBindingSource, "ActionDate", True))
        Me.ActionDateLabel1.Location = New System.Drawing.Point(538, 36)
        Me.ActionDateLabel1.Name = "ActionDateLabel1"
        Me.ActionDateLabel1.Size = New System.Drawing.Size(133, 23)
        Me.ActionDateLabel1.TabIndex = 1
        Me.ActionDateLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CarrierNameTextBox
        '
        Me.CarrierNameTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CarrierNameTextBox.BackColor = System.Drawing.Color.White
        Me.CarrierNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CactusSpecificBindingSource, "CarrierName", True))
        Me.CarrierNameTextBox.Location = New System.Drawing.Point(102, 39)
        Me.CarrierNameTextBox.Name = "CarrierNameTextBox"
        Me.CarrierNameTextBox.ReadOnly = True
        Me.CarrierNameTextBox.Size = New System.Drawing.Size(295, 20)
        Me.CarrierNameTextBox.TabIndex = 3
        '
        'CabNumberTextBox
        '
        Me.CabNumberTextBox.BackColor = System.Drawing.Color.White
        Me.CabNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CactusSpecificBindingSource, "CabNumber", True))
        Me.CabNumberTextBox.Location = New System.Drawing.Point(102, 65)
        Me.CabNumberTextBox.Name = "CabNumberTextBox"
        Me.CabNumberTextBox.ReadOnly = True
        Me.CabNumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CabNumberTextBox.TabIndex = 5
        '
        'TrailerNumberTextBox
        '
        Me.TrailerNumberTextBox.BackColor = System.Drawing.Color.White
        Me.TrailerNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CactusSpecificBindingSource, "TrailerNumber", True))
        Me.TrailerNumberTextBox.Location = New System.Drawing.Point(102, 91)
        Me.TrailerNumberTextBox.Name = "TrailerNumberTextBox"
        Me.TrailerNumberTextBox.ReadOnly = True
        Me.TrailerNumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TrailerNumberTextBox.TabIndex = 7
        '
        'SONumberTextBox
        '
        Me.SONumberTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SONumberTextBox.BackColor = System.Drawing.Color.White
        Me.SONumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CactusSpecificBindingSource, "SONumber", True))
        Me.SONumberTextBox.Location = New System.Drawing.Point(297, 65)
        Me.SONumberTextBox.Name = "SONumberTextBox"
        Me.SONumberTextBox.ReadOnly = True
        Me.SONumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SONumberTextBox.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(499, 164)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 18)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "E      1/4   1/2    3/4      F"
        '
        'ReferWillRunCheckBox
        '
        Me.ReferWillRunCheckBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReferWillRunCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CactusSpecificBindingSource, "ReferWillRun", True))
        Me.ReferWillRunCheckBox.Location = New System.Drawing.Point(569, 65)
        Me.ReferWillRunCheckBox.Name = "ReferWillRunCheckBox"
        Me.ReferWillRunCheckBox.Size = New System.Drawing.Size(102, 24)
        Me.ReferWillRunCheckBox.TabIndex = 15
        Me.ReferWillRunCheckBox.Text = "Refer Will Run"
        Me.ReferWillRunCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GetDataBackgroundWorker
        '
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripProgressBar})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 338)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(712, 22)
        Me.StatusStrip1.TabIndex = 17
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripProgressBar
        '
        Me.ToolStripProgressBar.Name = "ToolStripProgressBar"
        Me.ToolStripProgressBar.Size = New System.Drawing.Size(100, 16)
        Me.ToolStripProgressBar.Visible = False
        '
        'OtherComponentsTextBox
        '
        Me.OtherComponentsTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OtherComponentsTextBox.BackColor = System.Drawing.Color.White
        Me.OtherComponentsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CactusSpecificBindingSource, "OtherComponents", True))
        Me.OtherComponentsTextBox.Location = New System.Drawing.Point(502, 107)
        Me.OtherComponentsTextBox.Name = "OtherComponentsTextBox"
        Me.OtherComponentsTextBox.ReadOnly = True
        Me.OtherComponentsTextBox.Size = New System.Drawing.Size(169, 20)
        Me.OtherComponentsTextBox.TabIndex = 19
        '
        'ReferFuelLevelProgressBar
        '
        Me.ReferFuelLevelProgressBar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReferFuelLevelProgressBar.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CactusSpecificBindingSource, "ReferFuelLevel", True))
        Me.ReferFuelLevelProgressBar.Location = New System.Drawing.Point(502, 146)
        Me.ReferFuelLevelProgressBar.MarqueeAnimationSpeed = 0
        Me.ReferFuelLevelProgressBar.Maximum = 8
        Me.ReferFuelLevelProgressBar.Name = "ReferFuelLevelProgressBar"
        Me.ReferFuelLevelProgressBar.Size = New System.Drawing.Size(152, 15)
        Me.ReferFuelLevelProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ReferFuelLevelProgressBar.TabIndex = 21
        '
        'SequenceIDTextBox
        '
        Me.SequenceIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CactusSpecificBindingSource, "SequenceID", True))
        Me.SequenceIDTextBox.Location = New System.Drawing.Point(632, 315)
        Me.SequenceIDTextBox.Name = "SequenceIDTextBox"
        Me.SequenceIDTextBox.ReadOnly = True
        Me.SequenceIDTextBox.Size = New System.Drawing.Size(68, 20)
        Me.SequenceIDTextBox.TabIndex = 22
        '
        'DriverSigPictureBox
        '
        Me.DriverSigPictureBox.BackColor = System.Drawing.Color.White
        Me.DriverSigPictureBox.Location = New System.Drawing.Point(12, 241)
        Me.DriverSigPictureBox.Name = "DriverSigPictureBox"
        Me.DriverSigPictureBox.Size = New System.Drawing.Size(175, 94)
        Me.DriverSigPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DriverSigPictureBox.TabIndex = 23
        Me.DriverSigPictureBox.TabStop = False
        '
        'SecurityPictureBox
        '
        Me.SecurityPictureBox.BackColor = System.Drawing.Color.White
        Me.SecurityPictureBox.Location = New System.Drawing.Point(209, 241)
        Me.SecurityPictureBox.Name = "SecurityPictureBox"
        Me.SecurityPictureBox.Size = New System.Drawing.Size(175, 94)
        Me.SecurityPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SecurityPictureBox.TabIndex = 24
        Me.SecurityPictureBox.TabStop = False
        '
        'Cactus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 360)
        Me.Controls.Add(Me.SecurityPictureBox)
        Me.Controls.Add(Me.DriverSigPictureBox)
        Me.Controls.Add(Me.SequenceIDTextBox)
        Me.Controls.Add(Me.ReferFuelLevelProgressBar)
        Me.Controls.Add(OtherComponentsLabel)
        Me.Controls.Add(Me.OtherComponentsTextBox)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ReferWillRunCheckBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(ReferFuelLevelLabel)
        Me.Controls.Add(Me.CactusSpecificBindingNavigator)
        Me.Controls.Add(SONumberLabel)
        Me.Controls.Add(Me.CarrierNameTextBox)
        Me.Controls.Add(Me.SONumberTextBox)
        Me.Controls.Add(Me.ActionDateLabel1)
        Me.Controls.Add(TrailerNumberLabel)
        Me.Controls.Add(ActionDateLabel)
        Me.Controls.Add(Me.TrailerNumberTextBox)
        Me.Controls.Add(CarrierNameLabel)
        Me.Controls.Add(CabNumberLabel)
        Me.Controls.Add(Me.CabNumberTextBox)
        Me.Name = "Cactus"
        Me.Text = "Cactus"
        CType(Me.CactusSpecificBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CactusSpecificBindingNavigator.ResumeLayout(False)
        Me.CactusSpecificBindingNavigator.PerformLayout()
        CType(Me.CactusSpecificBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarcodeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.DriverSigPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SecurityPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BarcodeDataSet As KAR_Lot_SmartClient.karservices.cactus.smartclient.BarcodeDataSet
    Friend WithEvents CactusSpecificBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CactusSpecificBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CactusSpecificBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents SONumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TrailerNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CabNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CarrierNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ActionDateLabel1 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ReferWillRunCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents GetDataBackgroundWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripProgressBar As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents OtherComponentsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ReferFuelLevelProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents RefreshDataToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SequenceIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DriverSigPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents SecurityPictureBox As System.Windows.Forms.PictureBox
End Class
