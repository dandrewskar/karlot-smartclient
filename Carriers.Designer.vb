<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Carriers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Carriers))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.NewTrailerTabPage = New System.Windows.Forms.TabPage
        Me.AddTrailerWizard1 = New Gui.Wizard.Wizard
        Me.FinishedWizardPage = New Gui.Wizard.WizardPage
        Me.Label7 = New System.Windows.Forms.Label
        Me.SaveTrailerDataWizardPage = New Gui.Wizard.WizardPage
        Me.Label6 = New System.Windows.Forms.Label
        Me.SaveTrailerProgressBar = New System.Windows.Forms.ProgressBar
        Me.AddTRailerWizardPage3 = New Gui.Wizard.WizardPage
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.DryVanRadioButton = New System.Windows.Forms.RadioButton
        Me.ReferTRailerRadioButton = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.SupplyTrailerRadioButton = New System.Windows.Forms.RadioButton
        Me.BabysitterRadioButton = New System.Windows.Forms.RadioButton
        Me.PartialInboundRadioButton = New System.Windows.Forms.RadioButton
        Me.PalletTrailerRadioButton = New System.Windows.Forms.RadioButton
        Me.EmptyReferRadioButton = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CompleteLoadRadioButton = New System.Windows.Forms.RadioButton
        Me.PartialLoadRadioButton = New System.Windows.Forms.RadioButton
        Me.EmptyCleanRadioButton = New System.Windows.Forms.RadioButton
        Me.EmptyDirtRadioButton = New System.Windows.Forms.RadioButton
        Me.TrailerIDLabel = New System.Windows.Forms.Label
        Me.CarrierNameLabel = New System.Windows.Forms.Label
        Me.Header2 = New Gui.Wizard.Header
        Me.LookupBarcodeWizardPage = New Gui.Wizard.WizardPage
        Me.Label5 = New System.Windows.Forms.Label
        Me.TrailerInfoProgressBar = New System.Windows.Forms.ProgressBar
        Me.AddTrailerBarcodeWizardPage = New Gui.Wizard.WizardPage
        Me.BarcodeLookopTextBox = New System.Windows.Forms.TextBox
        Me.Header1 = New Gui.Wizard.Header
        Me.AddTRailerWizardPage1 = New Gui.Wizard.WizardPage
        Me.InfoContainer1 = New Gui.Wizard.InfoContainer
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.ViewCarriersTabPage = New System.Windows.Forms.TabPage
        Me.CarriersDataGridView = New System.Windows.Forms.DataGridView
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CarrierDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SCACDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AddedByDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SysCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CarriersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AddCarrierTabPage = New System.Windows.Forms.TabPage
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.HelpWindowLabel = New System.Windows.Forms.Label
        Me.SaveCarrierButton = New System.Windows.Forms.Button
        Me.CarriersNameTextBox = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ScacTextBox = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.MessageToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.RecordCountToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.BuyersCheckBox = New System.Windows.Forms.CheckBox
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.NewTrailerTabPage.SuspendLayout()
        Me.AddTrailerWizard1.SuspendLayout()
        Me.FinishedWizardPage.SuspendLayout()
        Me.SaveTrailerDataWizardPage.SuspendLayout()
        Me.AddTRailerWizardPage3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.LookupBarcodeWizardPage.SuspendLayout()
        Me.AddTrailerBarcodeWizardPage.SuspendLayout()
        Me.AddTRailerWizardPage1.SuspendLayout()
        Me.InfoContainer1.SuspendLayout()
        Me.ViewCarriersTabPage.SuspendLayout()
        CType(Me.CarriersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarriersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AddCarrierTabPage.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.73114!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.26886!))
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TabControl1, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.73737!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.26263!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 337.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(729, 457)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.PictureBox1, 2)
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(729, 73)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.SetColumnSpan(Me.TabControl1, 2)
        Me.TabControl1.Controls.Add(Me.NewTrailerTabPage)
        Me.TabControl1.Controls.Add(Me.ViewCarriersTabPage)
        Me.TabControl1.Controls.Add(Me.AddCarrierTabPage)
        Me.TabControl1.ImageList = Me.ImageList1
        Me.TabControl1.Location = New System.Drawing.Point(0, 73)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(0)
        Me.TabControl1.Name = "TabControl1"
        Me.TableLayoutPanel1.SetRowSpan(Me.TabControl1, 2)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(729, 363)
        Me.TabControl1.TabIndex = 2
        '
        'NewTrailerTabPage
        '
        Me.NewTrailerTabPage.Controls.Add(Me.AddTrailerWizard1)
        Me.NewTrailerTabPage.Location = New System.Drawing.Point(4, 43)
        Me.NewTrailerTabPage.Name = "NewTrailerTabPage"
        Me.NewTrailerTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.NewTrailerTabPage.Size = New System.Drawing.Size(721, 316)
        Me.NewTrailerTabPage.TabIndex = 1
        Me.NewTrailerTabPage.Text = "Add Trailer"
        Me.NewTrailerTabPage.UseVisualStyleBackColor = True
        '
        'AddTrailerWizard1
        '
        Me.AddTrailerWizard1.Controls.Add(Me.AddTRailerWizardPage3)
        Me.AddTrailerWizard1.Controls.Add(Me.SaveTrailerDataWizardPage)
        Me.AddTrailerWizard1.Controls.Add(Me.LookupBarcodeWizardPage)
        Me.AddTrailerWizard1.Controls.Add(Me.AddTrailerBarcodeWizardPage)
        Me.AddTrailerWizard1.Controls.Add(Me.AddTRailerWizardPage1)
        Me.AddTrailerWizard1.Controls.Add(Me.FinishedWizardPage)
        Me.AddTrailerWizard1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AddTrailerWizard1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddTrailerWizard1.Location = New System.Drawing.Point(3, 3)
        Me.AddTrailerWizard1.Name = "AddTrailerWizard1"
        Me.AddTrailerWizard1.Pages.AddRange(New Gui.Wizard.WizardPage() {Me.AddTRailerWizardPage1, Me.AddTrailerBarcodeWizardPage, Me.LookupBarcodeWizardPage, Me.AddTRailerWizardPage3, Me.SaveTrailerDataWizardPage, Me.FinishedWizardPage})
        Me.AddTrailerWizard1.Size = New System.Drawing.Size(715, 310)
        Me.AddTrailerWizard1.TabIndex = 0
        '
        'FinishedWizardPage
        '
        Me.FinishedWizardPage.BackColor = System.Drawing.Color.White
        Me.FinishedWizardPage.Controls.Add(Me.Label7)
        Me.FinishedWizardPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FinishedWizardPage.IsFinishPage = True
        Me.FinishedWizardPage.Location = New System.Drawing.Point(0, 0)
        Me.FinishedWizardPage.Name = "FinishedWizardPage"
        Me.FinishedWizardPage.Size = New System.Drawing.Size(715, 262)
        Me.FinishedWizardPage.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(187, 115)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(346, 25)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Trailer information was saved..."
        '
        'SaveTrailerDataWizardPage
        '
        Me.SaveTrailerDataWizardPage.BackColor = System.Drawing.Color.White
        Me.SaveTrailerDataWizardPage.Controls.Add(Me.Label6)
        Me.SaveTrailerDataWizardPage.Controls.Add(Me.SaveTrailerProgressBar)
        Me.SaveTrailerDataWizardPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SaveTrailerDataWizardPage.IsFinishPage = False
        Me.SaveTrailerDataWizardPage.Location = New System.Drawing.Point(0, 0)
        Me.SaveTrailerDataWizardPage.Name = "SaveTrailerDataWizardPage"
        Me.SaveTrailerDataWizardPage.Size = New System.Drawing.Size(715, 262)
        Me.SaveTrailerDataWizardPage.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(222, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(319, 19)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Please wait, Saving the trailer information..."
        '
        'SaveTrailerProgressBar
        '
        Me.SaveTrailerProgressBar.Location = New System.Drawing.Point(101, 137)
        Me.SaveTrailerProgressBar.Name = "SaveTrailerProgressBar"
        Me.SaveTrailerProgressBar.Size = New System.Drawing.Size(513, 19)
        Me.SaveTrailerProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.SaveTrailerProgressBar.TabIndex = 5
        '
        'AddTRailerWizardPage3
        '
        Me.AddTRailerWizardPage3.BackColor = System.Drawing.Color.White
        Me.AddTRailerWizardPage3.Controls.Add(Me.BuyersCheckBox)
        Me.AddTRailerWizardPage3.Controls.Add(Me.GroupBox3)
        Me.AddTRailerWizardPage3.Controls.Add(Me.GroupBox2)
        Me.AddTRailerWizardPage3.Controls.Add(Me.GroupBox1)
        Me.AddTRailerWizardPage3.Controls.Add(Me.TrailerIDLabel)
        Me.AddTRailerWizardPage3.Controls.Add(Me.CarrierNameLabel)
        Me.AddTRailerWizardPage3.Controls.Add(Me.Header2)
        Me.AddTRailerWizardPage3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AddTRailerWizardPage3.IsFinishPage = False
        Me.AddTRailerWizardPage3.Location = New System.Drawing.Point(0, 0)
        Me.AddTRailerWizardPage3.Name = "AddTRailerWizardPage3"
        Me.AddTRailerWizardPage3.Size = New System.Drawing.Size(715, 262)
        Me.AddTRailerWizardPage3.TabIndex = 3
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DryVanRadioButton)
        Me.GroupBox3.Controls.Add(Me.ReferTRailerRadioButton)
        Me.GroupBox3.Location = New System.Drawing.Point(24, 162)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(300, 44)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Trailer Type"
        '
        'DryVanRadioButton
        '
        Me.DryVanRadioButton.AutoSize = True
        Me.DryVanRadioButton.Location = New System.Drawing.Point(166, 19)
        Me.DryVanRadioButton.Name = "DryVanRadioButton"
        Me.DryVanRadioButton.Size = New System.Drawing.Size(118, 17)
        Me.DryVanRadioButton.TabIndex = 1
        Me.DryVanRadioButton.TabStop = True
        Me.DryVanRadioButton.Tag = "V"
        Me.DryVanRadioButton.Text = "Dry Van/Box Trailer"
        Me.DryVanRadioButton.UseVisualStyleBackColor = True
        '
        'ReferTRailerRadioButton
        '
        Me.ReferTRailerRadioButton.AutoSize = True
        Me.ReferTRailerRadioButton.Checked = True
        Me.ReferTRailerRadioButton.Location = New System.Drawing.Point(21, 19)
        Me.ReferTRailerRadioButton.Name = "ReferTRailerRadioButton"
        Me.ReferTRailerRadioButton.Size = New System.Drawing.Size(119, 17)
        Me.ReferTRailerRadioButton.TabIndex = 0
        Me.ReferTRailerRadioButton.TabStop = True
        Me.ReferTRailerRadioButton.Tag = "R"
        Me.ReferTRailerRadioButton.Text = "Refrigerated Trailer"
        Me.ReferTRailerRadioButton.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.SupplyTrailerRadioButton)
        Me.GroupBox2.Controls.Add(Me.BabysitterRadioButton)
        Me.GroupBox2.Controls.Add(Me.PartialInboundRadioButton)
        Me.GroupBox2.Controls.Add(Me.PalletTrailerRadioButton)
        Me.GroupBox2.Controls.Add(Me.EmptyReferRadioButton)
        Me.GroupBox2.Location = New System.Drawing.Point(520, 68)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(190, 187)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Load Type"
        '
        'SupplyTrailerRadioButton
        '
        Me.SupplyTrailerRadioButton.AutoSize = True
        Me.SupplyTrailerRadioButton.Location = New System.Drawing.Point(28, 134)
        Me.SupplyTrailerRadioButton.Name = "SupplyTrailerRadioButton"
        Me.SupplyTrailerRadioButton.Size = New System.Drawing.Size(90, 17)
        Me.SupplyTrailerRadioButton.TabIndex = 4
        Me.SupplyTrailerRadioButton.TabStop = True
        Me.SupplyTrailerRadioButton.Tag = "D"
        Me.SupplyTrailerRadioButton.Text = "Supply Trailer"
        Me.SupplyTrailerRadioButton.UseVisualStyleBackColor = True
        '
        'BabysitterRadioButton
        '
        Me.BabysitterRadioButton.AutoSize = True
        Me.BabysitterRadioButton.Location = New System.Drawing.Point(28, 110)
        Me.BabysitterRadioButton.Name = "BabysitterRadioButton"
        Me.BabysitterRadioButton.Size = New System.Drawing.Size(74, 17)
        Me.BabysitterRadioButton.TabIndex = 3
        Me.BabysitterRadioButton.TabStop = True
        Me.BabysitterRadioButton.Tag = "B"
        Me.BabysitterRadioButton.Text = "Babysitter"
        Me.BabysitterRadioButton.UseVisualStyleBackColor = True
        '
        'PartialInboundRadioButton
        '
        Me.PartialInboundRadioButton.AutoSize = True
        Me.PartialInboundRadioButton.Location = New System.Drawing.Point(28, 86)
        Me.PartialInboundRadioButton.Name = "PartialInboundRadioButton"
        Me.PartialInboundRadioButton.Size = New System.Drawing.Size(98, 17)
        Me.PartialInboundRadioButton.TabIndex = 2
        Me.PartialInboundRadioButton.TabStop = True
        Me.PartialInboundRadioButton.Tag = "P"
        Me.PartialInboundRadioButton.Text = "Partial Inbound"
        Me.PartialInboundRadioButton.UseVisualStyleBackColor = True
        '
        'PalletTrailerRadioButton
        '
        Me.PalletTrailerRadioButton.AutoSize = True
        Me.PalletTrailerRadioButton.Location = New System.Drawing.Point(28, 62)
        Me.PalletTrailerRadioButton.Name = "PalletTrailerRadioButton"
        Me.PalletTrailerRadioButton.Size = New System.Drawing.Size(84, 17)
        Me.PalletTrailerRadioButton.TabIndex = 1
        Me.PalletTrailerRadioButton.TabStop = True
        Me.PalletTrailerRadioButton.Tag = "L"
        Me.PalletTrailerRadioButton.Text = "Pallet Trailer"
        Me.PalletTrailerRadioButton.UseVisualStyleBackColor = True
        '
        'EmptyReferRadioButton
        '
        Me.EmptyReferRadioButton.AutoSize = True
        Me.EmptyReferRadioButton.Checked = True
        Me.EmptyReferRadioButton.Location = New System.Drawing.Point(27, 38)
        Me.EmptyReferRadioButton.Name = "EmptyReferRadioButton"
        Me.EmptyReferRadioButton.Size = New System.Drawing.Size(119, 17)
        Me.EmptyReferRadioButton.TabIndex = 0
        Me.EmptyReferRadioButton.TabStop = True
        Me.EmptyReferRadioButton.Tag = "E"
        Me.EmptyReferRadioButton.Text = "Empty Refrigerated"
        Me.EmptyReferRadioButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CompleteLoadRadioButton)
        Me.GroupBox1.Controls.Add(Me.PartialLoadRadioButton)
        Me.GroupBox1.Controls.Add(Me.EmptyCleanRadioButton)
        Me.GroupBox1.Controls.Add(Me.EmptyDirtRadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 212)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(488, 43)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Load Status"
        '
        'CompleteLoadRadioButton
        '
        Me.CompleteLoadRadioButton.AutoSize = True
        Me.CompleteLoadRadioButton.Location = New System.Drawing.Point(356, 17)
        Me.CompleteLoadRadioButton.Name = "CompleteLoadRadioButton"
        Me.CompleteLoadRadioButton.Size = New System.Drawing.Size(96, 17)
        Me.CompleteLoadRadioButton.TabIndex = 3
        Me.CompleteLoadRadioButton.Text = "Complete Load"
        Me.CompleteLoadRadioButton.UseVisualStyleBackColor = True
        '
        'PartialLoadRadioButton
        '
        Me.PartialLoadRadioButton.AutoSize = True
        Me.PartialLoadRadioButton.Location = New System.Drawing.Point(247, 17)
        Me.PartialLoadRadioButton.Name = "PartialLoadRadioButton"
        Me.PartialLoadRadioButton.Size = New System.Drawing.Size(81, 17)
        Me.PartialLoadRadioButton.TabIndex = 2
        Me.PartialLoadRadioButton.Text = "Partial Load"
        Me.PartialLoadRadioButton.UseVisualStyleBackColor = True
        '
        'EmptyCleanRadioButton
        '
        Me.EmptyCleanRadioButton.AutoSize = True
        Me.EmptyCleanRadioButton.Location = New System.Drawing.Point(140, 17)
        Me.EmptyCleanRadioButton.Name = "EmptyCleanRadioButton"
        Me.EmptyCleanRadioButton.Size = New System.Drawing.Size(85, 17)
        Me.EmptyCleanRadioButton.TabIndex = 1
        Me.EmptyCleanRadioButton.Text = "Empty Clean"
        Me.EmptyCleanRadioButton.UseVisualStyleBackColor = True
        '
        'EmptyDirtRadioButton
        '
        Me.EmptyDirtRadioButton.AutoSize = True
        Me.EmptyDirtRadioButton.Checked = True
        Me.EmptyDirtRadioButton.Location = New System.Drawing.Point(40, 17)
        Me.EmptyDirtRadioButton.Name = "EmptyDirtRadioButton"
        Me.EmptyDirtRadioButton.Size = New System.Drawing.Size(81, 17)
        Me.EmptyDirtRadioButton.TabIndex = 0
        Me.EmptyDirtRadioButton.TabStop = True
        Me.EmptyDirtRadioButton.Text = "Empty Dirty"
        Me.EmptyDirtRadioButton.UseVisualStyleBackColor = True
        '
        'TrailerIDLabel
        '
        Me.TrailerIDLabel.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrailerIDLabel.Location = New System.Drawing.Point(5, 90)
        Me.TrailerIDLabel.Name = "TrailerIDLabel"
        Me.TrailerIDLabel.Size = New System.Drawing.Size(509, 20)
        Me.TrailerIDLabel.TabIndex = 3
        Me.TrailerIDLabel.Text = "Label5"
        Me.TrailerIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CarrierNameLabel
        '
        Me.CarrierNameLabel.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CarrierNameLabel.Location = New System.Drawing.Point(5, 65)
        Me.CarrierNameLabel.Name = "CarrierNameLabel"
        Me.CarrierNameLabel.Size = New System.Drawing.Size(507, 25)
        Me.CarrierNameLabel.TabIndex = 2
        Me.CarrierNameLabel.Text = "CarrierNameLabel"
        Me.CarrierNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Header2
        '
        Me.Header2.BackColor = System.Drawing.SystemColors.Control
        Me.Header2.CausesValidation = False
        Me.Header2.Description = "Enter Trailer Information Below."
        Me.Header2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Header2.Image = CType(resources.GetObject("Header2.Image"), System.Drawing.Image)
        Me.Header2.Location = New System.Drawing.Point(0, 0)
        Me.Header2.Name = "Header2"
        Me.Header2.Size = New System.Drawing.Size(715, 62)
        Me.Header2.TabIndex = 1
        Me.Header2.Title = "Trailer"
        '
        'LookupBarcodeWizardPage
        '
        Me.LookupBarcodeWizardPage.BackColor = System.Drawing.Color.White
        Me.LookupBarcodeWizardPage.Controls.Add(Me.Label5)
        Me.LookupBarcodeWizardPage.Controls.Add(Me.TrailerInfoProgressBar)
        Me.LookupBarcodeWizardPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LookupBarcodeWizardPage.IsFinishPage = False
        Me.LookupBarcodeWizardPage.Location = New System.Drawing.Point(0, 0)
        Me.LookupBarcodeWizardPage.Name = "LookupBarcodeWizardPage"
        Me.LookupBarcodeWizardPage.Size = New System.Drawing.Size(715, 262)
        Me.LookupBarcodeWizardPage.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(229, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(279, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Please wait, Looking up the barcode..."
        '
        'TrailerInfoProgressBar
        '
        Me.TrailerInfoProgressBar.Location = New System.Drawing.Point(108, 125)
        Me.TrailerInfoProgressBar.Name = "TrailerInfoProgressBar"
        Me.TrailerInfoProgressBar.Size = New System.Drawing.Size(513, 19)
        Me.TrailerInfoProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.TrailerInfoProgressBar.TabIndex = 3
        '
        'AddTrailerBarcodeWizardPage
        '
        Me.AddTrailerBarcodeWizardPage.BackColor = System.Drawing.Color.White
        Me.AddTrailerBarcodeWizardPage.Controls.Add(Me.BarcodeLookopTextBox)
        Me.AddTrailerBarcodeWizardPage.Controls.Add(Me.Header1)
        Me.AddTrailerBarcodeWizardPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AddTrailerBarcodeWizardPage.IsFinishPage = False
        Me.AddTrailerBarcodeWizardPage.Location = New System.Drawing.Point(0, 0)
        Me.AddTrailerBarcodeWizardPage.Name = "AddTrailerBarcodeWizardPage"
        Me.AddTrailerBarcodeWizardPage.Size = New System.Drawing.Size(715, 262)
        Me.AddTrailerBarcodeWizardPage.TabIndex = 2
        '
        'BarcodeLookopTextBox
        '
        Me.BarcodeLookopTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BarcodeLookopTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.BarcodeLookopTextBox.Font = New System.Drawing.Font("Tahoma", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarcodeLookopTextBox.Location = New System.Drawing.Point(116, 118)
        Me.BarcodeLookopTextBox.MaxLength = 15
        Me.BarcodeLookopTextBox.Name = "BarcodeLookopTextBox"
        Me.BarcodeLookopTextBox.Size = New System.Drawing.Size(513, 52)
        Me.BarcodeLookopTextBox.TabIndex = 1
        Me.BarcodeLookopTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Header1
        '
        Me.Header1.BackColor = System.Drawing.SystemColors.Control
        Me.Header1.CausesValidation = False
        Me.Header1.Description = "Enter Barcode Information Below"
        Me.Header1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Header1.Image = CType(resources.GetObject("Header1.Image"), System.Drawing.Image)
        Me.Header1.Location = New System.Drawing.Point(0, 0)
        Me.Header1.Name = "Header1"
        Me.Header1.Size = New System.Drawing.Size(715, 64)
        Me.Header1.TabIndex = 0
        Me.Header1.Title = "Barcode"
        '
        'AddTRailerWizardPage1
        '
        Me.AddTRailerWizardPage1.Controls.Add(Me.InfoContainer1)
        Me.AddTRailerWizardPage1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AddTRailerWizardPage1.IsFinishPage = False
        Me.AddTRailerWizardPage1.Location = New System.Drawing.Point(0, 0)
        Me.AddTRailerWizardPage1.Name = "AddTRailerWizardPage1"
        Me.AddTRailerWizardPage1.Size = New System.Drawing.Size(715, 262)
        Me.AddTRailerWizardPage1.TabIndex = 1
        '
        'InfoContainer1
        '
        Me.InfoContainer1.BackColor = System.Drawing.Color.White
        Me.InfoContainer1.Controls.Add(Me.Label4)
        Me.InfoContainer1.Controls.Add(Me.Label3)
        Me.InfoContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InfoContainer1.Image = CType(resources.GetObject("InfoContainer1.Image"), System.Drawing.Image)
        Me.InfoContainer1.Location = New System.Drawing.Point(0, 0)
        Me.InfoContainer1.Name = "InfoContainer1"
        Me.InfoContainer1.PageTitle = "Add New Trailer"
        Me.InfoContainer1.Size = New System.Drawing.Size(715, 262)
        Me.InfoContainer1.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(226, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(180, 24)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Click next to continue..."
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(226, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(405, 42)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "This wizard will help you add a new trailer to the system. You will need the barc" & _
            "ode information, carrier name, and trailer number to complete this wizard."
        '
        'ViewCarriersTabPage
        '
        Me.ViewCarriersTabPage.BackColor = System.Drawing.Color.Transparent
        Me.ViewCarriersTabPage.Controls.Add(Me.CarriersDataGridView)
        Me.ViewCarriersTabPage.ImageIndex = 0
        Me.ViewCarriersTabPage.Location = New System.Drawing.Point(4, 43)
        Me.ViewCarriersTabPage.Name = "ViewCarriersTabPage"
        Me.ViewCarriersTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.ViewCarriersTabPage.Size = New System.Drawing.Size(721, 316)
        Me.ViewCarriersTabPage.TabIndex = 0
        Me.ViewCarriersTabPage.Text = "Carriers"
        Me.ViewCarriersTabPage.UseVisualStyleBackColor = True
        '
        'CarriersDataGridView
        '
        Me.CarriersDataGridView.AllowUserToAddRows = False
        Me.CarriersDataGridView.AllowUserToDeleteRows = False
        Me.CarriersDataGridView.AutoGenerateColumns = False
        Me.CarriersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CarriersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.CarrierDataGridViewTextBoxColumn, Me.SCACDataGridViewTextBoxColumn, Me.AddedByDataGridViewTextBoxColumn, Me.SysCodeDataGridViewTextBoxColumn})
        Me.CarriersDataGridView.DataSource = Me.CarriersBindingSource
        Me.CarriersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CarriersDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.CarriersDataGridView.Name = "CarriersDataGridView"
        Me.CarriersDataGridView.ReadOnly = True
        Me.CarriersDataGridView.Size = New System.Drawing.Size(715, 310)
        Me.CarriersDataGridView.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Visible = False
        '
        'CarrierDataGridViewTextBoxColumn
        '
        Me.CarrierDataGridViewTextBoxColumn.DataPropertyName = "Carrier"
        Me.CarrierDataGridViewTextBoxColumn.HeaderText = "Carrier"
        Me.CarrierDataGridViewTextBoxColumn.Name = "CarrierDataGridViewTextBoxColumn"
        Me.CarrierDataGridViewTextBoxColumn.ReadOnly = True
        Me.CarrierDataGridViewTextBoxColumn.Width = 500
        '
        'SCACDataGridViewTextBoxColumn
        '
        Me.SCACDataGridViewTextBoxColumn.DataPropertyName = "SCAC"
        Me.SCACDataGridViewTextBoxColumn.HeaderText = "SCAC"
        Me.SCACDataGridViewTextBoxColumn.Name = "SCACDataGridViewTextBoxColumn"
        Me.SCACDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AddedByDataGridViewTextBoxColumn
        '
        Me.AddedByDataGridViewTextBoxColumn.DataPropertyName = "AddedBy"
        Me.AddedByDataGridViewTextBoxColumn.HeaderText = "AddedBy"
        Me.AddedByDataGridViewTextBoxColumn.Name = "AddedByDataGridViewTextBoxColumn"
        Me.AddedByDataGridViewTextBoxColumn.ReadOnly = True
        Me.AddedByDataGridViewTextBoxColumn.Visible = False
        '
        'SysCodeDataGridViewTextBoxColumn
        '
        Me.SysCodeDataGridViewTextBoxColumn.DataPropertyName = "SysCode"
        Me.SysCodeDataGridViewTextBoxColumn.HeaderText = "SysCode"
        Me.SysCodeDataGridViewTextBoxColumn.Name = "SysCodeDataGridViewTextBoxColumn"
        Me.SysCodeDataGridViewTextBoxColumn.ReadOnly = True
        Me.SysCodeDataGridViewTextBoxColumn.Visible = False
        '
        'CarriersBindingSource
        '
        Me.CarriersBindingSource.DataMember = "Carriers"
        Me.CarriersBindingSource.DataSource = GetType(KAR_Lot_SmartClient.karservices.cactus.smartclient.BarcodeDataSet)
        '
        'AddCarrierTabPage
        '
        Me.AddCarrierTabPage.BackColor = System.Drawing.Color.Transparent
        Me.AddCarrierTabPage.Controls.Add(Me.SplitContainer1)
        Me.AddCarrierTabPage.ImageIndex = 2
        Me.AddCarrierTabPage.Location = New System.Drawing.Point(4, 43)
        Me.AddCarrierTabPage.Name = "AddCarrierTabPage"
        Me.AddCarrierTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.AddCarrierTabPage.Size = New System.Drawing.Size(721, 316)
        Me.AddCarrierTabPage.TabIndex = 2
        Me.AddCarrierTabPage.Text = "Add Carrier"
        Me.AddCarrierTabPage.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.HelpWindowLabel)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SaveCarrierButton)
        Me.SplitContainer1.Panel2.Controls.Add(Me.CarriersNameTextBox)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ScacTextBox)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Size = New System.Drawing.Size(715, 310)
        Me.SplitContainer1.SplitterDistance = 299
        Me.SplitContainer1.SplitterWidth = 1
        Me.SplitContainer1.TabIndex = 3
        '
        'HelpWindowLabel
        '
        Me.HelpWindowLabel.Location = New System.Drawing.Point(26, 28)
        Me.HelpWindowLabel.Name = "HelpWindowLabel"
        Me.HelpWindowLabel.Size = New System.Drawing.Size(239, 213)
        Me.HelpWindowLabel.TabIndex = 0
        Me.HelpWindowLabel.Tag = "Enter the new carriers information and click save. A search will be preformed to " & _
            "make sure the SCAC code is not already in use by another carrier."
        Me.HelpWindowLabel.Text = "Enter the new carriers information and click save." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "A search will be preformed " & _
            "to make sure the SCAC code is not already in use by another carrier."
        '
        'SaveCarrierButton
        '
        Me.SaveCarrierButton.Location = New System.Drawing.Point(267, 177)
        Me.SaveCarrierButton.Name = "SaveCarrierButton"
        Me.SaveCarrierButton.Size = New System.Drawing.Size(128, 34)
        Me.SaveCarrierButton.TabIndex = 5
        Me.SaveCarrierButton.Text = "Save"
        Me.SaveCarrierButton.UseVisualStyleBackColor = True
        '
        'CarriersNameTextBox
        '
        Me.CarriersNameTextBox.Location = New System.Drawing.Point(14, 134)
        Me.CarriersNameTextBox.MaxLength = 150
        Me.CarriersNameTextBox.Name = "CarriersNameTextBox"
        Me.CarriersNameTextBox.Size = New System.Drawing.Size(381, 20)
        Me.CarriersNameTextBox.TabIndex = 4
        Me.CarriersNameTextBox.Tag = "Enter the carriers name. Do not to abbreviate important portions of the name as t" & _
            "his makes searching by name difficult."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Carriers Name"
        '
        'ScacTextBox
        '
        Me.ScacTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScacTextBox.Location = New System.Drawing.Point(14, 92)
        Me.ScacTextBox.MaxLength = 4
        Me.ScacTextBox.Name = "ScacTextBox"
        Me.ScacTextBox.Size = New System.Drawing.Size(100, 23)
        Me.ScacTextBox.TabIndex = 2
        Me.ScacTextBox.Tag = "Enter the carriers 4 digit carrier code here. Each carrier has a unique carrier c" & _
            "ode. If you are not sure what the carriers SCAC is then double check with the ca" & _
            "rrier or the plant."
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "SCAC"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "carrier.jpg")
        Me.ImageList1.Images.SetKeyName(1, "search.jpg")
        Me.ImageList1.Images.SetKeyName(2, "scac.PNG")
        Me.ImageList1.Images.SetKeyName(3, "Refresh.bmp")
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MessageToolStripStatusLabel, Me.RecordCountToolStripStatusLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 433)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode
        Me.StatusStrip1.Size = New System.Drawing.Size(729, 24)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'MessageToolStripStatusLabel
        '
        Me.MessageToolStripStatusLabel.ForeColor = System.Drawing.Color.White
        Me.MessageToolStripStatusLabel.Name = "MessageToolStripStatusLabel"
        Me.MessageToolStripStatusLabel.Size = New System.Drawing.Size(525, 19)
        Me.MessageToolStripStatusLabel.Spring = True
        Me.MessageToolStripStatusLabel.Text = "MessageToolStripStatusLabel"
        Me.MessageToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RecordCountToolStripStatusLabel
        '
        Me.RecordCountToolStripStatusLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.RecordCountToolStripStatusLabel.Name = "RecordCountToolStripStatusLabel"
        Me.RecordCountToolStripStatusLabel.Size = New System.Drawing.Size(189, 19)
        Me.RecordCountToolStripStatusLabel.Text = "RecordCountToolStripStatusLabel"
        Me.RecordCountToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BuyersCheckBox
        '
        Me.BuyersCheckBox.AutoSize = True
        Me.BuyersCheckBox.Location = New System.Drawing.Point(368, 178)
        Me.BuyersCheckBox.Name = "BuyersCheckBox"
        Me.BuyersCheckBox.Size = New System.Drawing.Size(59, 17)
        Me.BuyersCheckBox.TabIndex = 7
        Me.BuyersCheckBox.Text = "Buyers"
        Me.BuyersCheckBox.UseVisualStyleBackColor = True
        '
        'Carriers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 457)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Carriers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Carriers"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.NewTrailerTabPage.ResumeLayout(False)
        Me.AddTrailerWizard1.ResumeLayout(False)
        Me.FinishedWizardPage.ResumeLayout(False)
        Me.FinishedWizardPage.PerformLayout()
        Me.SaveTrailerDataWizardPage.ResumeLayout(False)
        Me.SaveTrailerDataWizardPage.PerformLayout()
        Me.AddTRailerWizardPage3.ResumeLayout(False)
        Me.AddTRailerWizardPage3.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.LookupBarcodeWizardPage.ResumeLayout(False)
        Me.LookupBarcodeWizardPage.PerformLayout()
        Me.AddTrailerBarcodeWizardPage.ResumeLayout(False)
        Me.AddTrailerBarcodeWizardPage.PerformLayout()
        Me.AddTRailerWizardPage1.ResumeLayout(False)
        Me.InfoContainer1.ResumeLayout(False)
        Me.ViewCarriersTabPage.ResumeLayout(False)
        CType(Me.CarriersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarriersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AddCarrierTabPage.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents ViewCarriersTabPage As System.Windows.Forms.TabPage
    Friend WithEvents NewTrailerTabPage As System.Windows.Forms.TabPage
    Friend WithEvents CarriersDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents CarriersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CarrierDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SCACDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddedByDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SysCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents RecordCountToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents AddCarrierTabPage As System.Windows.Forms.TabPage
    Friend WithEvents ScacTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents HelpWindowLabel As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents CarriersNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SaveCarrierButton As System.Windows.Forms.Button
    Friend WithEvents MessageToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents AddTrailerWizard1 As Gui.Wizard.Wizard
    Friend WithEvents AddTrailerBarcodeWizardPage As Gui.Wizard.WizardPage
    Friend WithEvents AddTRailerWizardPage1 As Gui.Wizard.WizardPage
    Friend WithEvents InfoContainer1 As Gui.Wizard.InfoContainer
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BarcodeLookopTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Header1 As Gui.Wizard.Header
    Friend WithEvents AddTRailerWizardPage3 As Gui.Wizard.WizardPage
    Friend WithEvents Header2 As Gui.Wizard.Header
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CompleteLoadRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents PartialLoadRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents EmptyCleanRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents EmptyDirtRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents TrailerIDLabel As System.Windows.Forms.Label
    Friend WithEvents CarrierNameLabel As System.Windows.Forms.Label
    Friend WithEvents LookupBarcodeWizardPage As Gui.Wizard.WizardPage
    Friend WithEvents SaveTrailerDataWizardPage As Gui.Wizard.WizardPage
    Friend WithEvents FinishedWizardPage As Gui.Wizard.WizardPage
    Friend WithEvents TrailerInfoProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents SaveTrailerProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PalletTrailerRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents EmptyReferRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents PartialInboundRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents BabysitterRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents SupplyTrailerRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DryVanRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents ReferTRailerRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BuyersCheckBox As System.Windows.Forms.CheckBox
End Class
