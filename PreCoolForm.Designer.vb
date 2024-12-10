<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PreCoolForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PreCoolForm))
        Me.TrailerTreeView = New System.Windows.Forms.TreeView
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.MessageToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.TrailerCountLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.CancelRequestButton = New System.Windows.Forms.Button
        Me.StopPrecoolButton = New System.Windows.Forms.Button
        Me.StartPrecoolButton = New System.Windows.Forms.Button
        Me.MyCloseButton = New System.Windows.Forms.Button
        Me.TrailerDetailsGroupBox = New System.Windows.Forms.GroupBox
        Me.LoadStatusLabel = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.StopUnitLabel = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.CurrentLocationLabel = New System.Windows.Forms.Label
        Me.LOCLabel = New System.Windows.Forms.Label
        Me.CarrierNameLabel = New System.Windows.Forms.Label
        Me.TimeRunningLabel = New System.Windows.Forms.Label
        Me.TemperatureLabel = New System.Windows.Forms.Label
        Me.SPLabel = New System.Windows.Forms.Label
        Me.PalletsOnBoardLabel = New System.Windows.Forms.Label
        Me.POBLabel = New System.Windows.Forms.Label
        Me.PrecoolPictureBox = New System.Windows.Forms.PictureBox
        Me.PreCoolingLabel = New System.Windows.Forms.Label
        Me.BarcodeLabel = New System.Windows.Forms.Label
        Me.TrailerIDLabel = New System.Windows.Forms.Label
        Me.BCLabel = New System.Windows.Forms.Label
        Me.SearchPictureBox = New System.Windows.Forms.PictureBox
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.ShowPrecoolsToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.SearchStyleToolStripDropDownButton = New System.Windows.Forms.ToolStripDropDownButton
        Me.SearchTrailerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SearchCarrierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SearchToolStripTextBox = New System.Windows.Forms.ToolStripTextBox
        Me.SearchToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.SearchTypeToolStripDropDownButton = New System.Windows.Forms.ToolStripDropDownButton
        Me.ExactMatchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SimilarMatchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TrailerDetailsGroupBox.SuspendLayout()
        CType(Me.PrecoolPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TrailerTreeView
        '
        Me.TrailerTreeView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TrailerTreeView.Location = New System.Drawing.Point(0, 0)
        Me.TrailerTreeView.Name = "TrailerTreeView"
        Me.TrailerTreeView.Size = New System.Drawing.Size(306, 336)
        Me.TrailerTreeView.TabIndex = 0
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MessageToolStripStatusLabel, Me.TrailerCountLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 334)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(944, 24)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'MessageToolStripStatusLabel
        '
        Me.MessageToolStripStatusLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.MessageToolStripStatusLabel.Name = "MessageToolStripStatusLabel"
        Me.MessageToolStripStatusLabel.Size = New System.Drawing.Size(109, 19)
        Me.MessageToolStripStatusLabel.Text = "Precooling Trailers"
        '
        'TrailerCountLabel
        '
        Me.TrailerCountLabel.Name = "TrailerCountLabel"
        Me.TrailerCountLabel.Size = New System.Drawing.Size(101, 19)
        Me.TrailerCountLabel.Text = "TrailerCountLabel"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.CancelRequestButton)
        Me.Panel1.Controls.Add(Me.StopPrecoolButton)
        Me.Panel1.Controls.Add(Me.StartPrecoolButton)
        Me.Panel1.Controls.Add(Me.MyCloseButton)
        Me.Panel1.Controls.Add(Me.TrailerDetailsGroupBox)
        Me.Panel1.Controls.Add(Me.SearchPictureBox)
        Me.Panel1.Controls.Add(Me.ToolStrip1)
        Me.Panel1.Location = New System.Drawing.Point(254, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(690, 335)
        Me.Panel1.TabIndex = 2
        '
        'CancelRequestButton
        '
        Me.CancelRequestButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CancelRequestButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelRequestButton.Location = New System.Drawing.Point(280, 298)
        Me.CancelRequestButton.Name = "CancelRequestButton"
        Me.CancelRequestButton.Size = New System.Drawing.Size(131, 34)
        Me.CancelRequestButton.TabIndex = 6
        Me.CancelRequestButton.Text = "CANCEL REQUEST"
        Me.CancelRequestButton.UseVisualStyleBackColor = True
        '
        'StopPrecoolButton
        '
        Me.StopPrecoolButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.StopPrecoolButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StopPrecoolButton.Location = New System.Drawing.Point(143, 298)
        Me.StopPrecoolButton.Name = "StopPrecoolButton"
        Me.StopPrecoolButton.Size = New System.Drawing.Size(131, 34)
        Me.StopPrecoolButton.TabIndex = 5
        Me.StopPrecoolButton.Text = "STOP UNIT []"
        Me.StopPrecoolButton.UseVisualStyleBackColor = True
        '
        'StartPrecoolButton
        '
        Me.StartPrecoolButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.StartPrecoolButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartPrecoolButton.Location = New System.Drawing.Point(6, 298)
        Me.StartPrecoolButton.Name = "StartPrecoolButton"
        Me.StartPrecoolButton.Size = New System.Drawing.Size(131, 34)
        Me.StartPrecoolButton.TabIndex = 4
        Me.StartPrecoolButton.Text = "START UNIT >>"
        Me.StartPrecoolButton.UseVisualStyleBackColor = True
        '
        'MyCloseButton
        '
        Me.MyCloseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MyCloseButton.Location = New System.Drawing.Point(560, 298)
        Me.MyCloseButton.Name = "MyCloseButton"
        Me.MyCloseButton.Size = New System.Drawing.Size(118, 34)
        Me.MyCloseButton.TabIndex = 3
        Me.MyCloseButton.Text = "Close"
        Me.MyCloseButton.UseVisualStyleBackColor = True
        '
        'TrailerDetailsGroupBox
        '
        Me.TrailerDetailsGroupBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TrailerDetailsGroupBox.BackColor = System.Drawing.Color.White
        Me.TrailerDetailsGroupBox.Controls.Add(Me.LoadStatusLabel)
        Me.TrailerDetailsGroupBox.Controls.Add(Me.Label3)
        Me.TrailerDetailsGroupBox.Controls.Add(Me.StopUnitLabel)
        Me.TrailerDetailsGroupBox.Controls.Add(Me.Label1)
        Me.TrailerDetailsGroupBox.Controls.Add(Me.CurrentLocationLabel)
        Me.TrailerDetailsGroupBox.Controls.Add(Me.LOCLabel)
        Me.TrailerDetailsGroupBox.Controls.Add(Me.CarrierNameLabel)
        Me.TrailerDetailsGroupBox.Controls.Add(Me.TimeRunningLabel)
        Me.TrailerDetailsGroupBox.Controls.Add(Me.TemperatureLabel)
        Me.TrailerDetailsGroupBox.Controls.Add(Me.SPLabel)
        Me.TrailerDetailsGroupBox.Controls.Add(Me.PalletsOnBoardLabel)
        Me.TrailerDetailsGroupBox.Controls.Add(Me.POBLabel)
        Me.TrailerDetailsGroupBox.Controls.Add(Me.PrecoolPictureBox)
        Me.TrailerDetailsGroupBox.Controls.Add(Me.PreCoolingLabel)
        Me.TrailerDetailsGroupBox.Controls.Add(Me.BarcodeLabel)
        Me.TrailerDetailsGroupBox.Controls.Add(Me.TrailerIDLabel)
        Me.TrailerDetailsGroupBox.Controls.Add(Me.BCLabel)
        Me.TrailerDetailsGroupBox.Location = New System.Drawing.Point(6, 31)
        Me.TrailerDetailsGroupBox.Name = "TrailerDetailsGroupBox"
        Me.TrailerDetailsGroupBox.Size = New System.Drawing.Size(672, 259)
        Me.TrailerDetailsGroupBox.TabIndex = 2
        Me.TrailerDetailsGroupBox.TabStop = False
        Me.TrailerDetailsGroupBox.Text = "Trailer Details"
        '
        'LoadStatusLabel
        '
        Me.LoadStatusLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoadStatusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadStatusLabel.ForeColor = System.Drawing.Color.DarkBlue
        Me.LoadStatusLabel.Location = New System.Drawing.Point(55, 137)
        Me.LoadStatusLabel.Name = "LoadStatusLabel"
        Me.LoadStatusLabel.Size = New System.Drawing.Size(532, 23)
        Me.LoadStatusLabel.TabIndex = 15
        Me.LoadStatusLabel.Tag = "CLEAR"
        Me.LoadStatusLabel.Text = "LoadStatusLabel"
        Me.LoadStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(52, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(535, 23)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "LOAD STATUS:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StopUnitLabel
        '
        Me.StopUnitLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StopUnitLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StopUnitLabel.ForeColor = System.Drawing.Color.Red
        Me.StopUnitLabel.Location = New System.Drawing.Point(97, 180)
        Me.StopUnitLabel.Name = "StopUnitLabel"
        Me.StopUnitLabel.Size = New System.Drawing.Size(475, 38)
        Me.StopUnitLabel.TabIndex = 14
        Me.StopUnitLabel.Tag = ""
        Me.StopUnitLabel.Text = "STOP UNIT REQUEST IS PENDING"
        Me.StopUnitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(478, 233)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 23)
        Me.Label1.TabIndex = 13
        Me.Label1.Tag = "CLEAR"
        Me.Label1.Text = "UNIT RUNNING"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Visible = False
        '
        'CurrentLocationLabel
        '
        Me.CurrentLocationLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CurrentLocationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentLocationLabel.ForeColor = System.Drawing.Color.DarkBlue
        Me.CurrentLocationLabel.Location = New System.Drawing.Point(462, 95)
        Me.CurrentLocationLabel.Name = "CurrentLocationLabel"
        Me.CurrentLocationLabel.Size = New System.Drawing.Size(177, 23)
        Me.CurrentLocationLabel.TabIndex = 12
        Me.CurrentLocationLabel.Tag = "CLEAR"
        Me.CurrentLocationLabel.Text = "CurrentLocationLabel"
        Me.CurrentLocationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LOCLabel
        '
        Me.LOCLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LOCLabel.Location = New System.Drawing.Point(466, 76)
        Me.LOCLabel.Name = "LOCLabel"
        Me.LOCLabel.Size = New System.Drawing.Size(173, 23)
        Me.LOCLabel.TabIndex = 11
        Me.LOCLabel.Text = "CURRENT LOCATION:"
        Me.LOCLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CarrierNameLabel
        '
        Me.CarrierNameLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CarrierNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CarrierNameLabel.ForeColor = System.Drawing.Color.DarkBlue
        Me.CarrierNameLabel.Location = New System.Drawing.Point(6, 16)
        Me.CarrierNameLabel.Name = "CarrierNameLabel"
        Me.CarrierNameLabel.Size = New System.Drawing.Size(636, 32)
        Me.CarrierNameLabel.TabIndex = 0
        Me.CarrierNameLabel.Tag = "CLEAR"
        Me.CarrierNameLabel.Text = "CarrierNameLabel"
        Me.CarrierNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TimeRunningLabel
        '
        Me.TimeRunningLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TimeRunningLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeRunningLabel.ForeColor = System.Drawing.Color.Red
        Me.TimeRunningLabel.Location = New System.Drawing.Point(6, 158)
        Me.TimeRunningLabel.Name = "TimeRunningLabel"
        Me.TimeRunningLabel.Size = New System.Drawing.Size(660, 23)
        Me.TimeRunningLabel.TabIndex = 10
        Me.TimeRunningLabel.Tag = "CLEAR"
        Me.TimeRunningLabel.Text = "Unit Running for 4 days 3 hours"
        Me.TimeRunningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.TimeRunningLabel.Visible = False
        '
        'TemperatureLabel
        '
        Me.TemperatureLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TemperatureLabel.ForeColor = System.Drawing.Color.DarkBlue
        Me.TemperatureLabel.Location = New System.Drawing.Point(23, 95)
        Me.TemperatureLabel.Name = "TemperatureLabel"
        Me.TemperatureLabel.Size = New System.Drawing.Size(182, 23)
        Me.TemperatureLabel.TabIndex = 9
        Me.TemperatureLabel.Tag = "CLEAR"
        Me.TemperatureLabel.Text = "TempLabel"
        Me.TemperatureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SPLabel
        '
        Me.SPLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SPLabel.Location = New System.Drawing.Point(24, 76)
        Me.SPLabel.Name = "SPLabel"
        Me.SPLabel.Size = New System.Drawing.Size(172, 23)
        Me.SPLabel.TabIndex = 8
        Me.SPLabel.Text = "SET POINT:"
        Me.SPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PalletsOnBoardLabel
        '
        Me.PalletsOnBoardLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PalletsOnBoardLabel.ForeColor = System.Drawing.Color.DarkBlue
        Me.PalletsOnBoardLabel.Location = New System.Drawing.Point(228, 233)
        Me.PalletsOnBoardLabel.Name = "PalletsOnBoardLabel"
        Me.PalletsOnBoardLabel.Size = New System.Drawing.Size(124, 23)
        Me.PalletsOnBoardLabel.TabIndex = 4
        Me.PalletsOnBoardLabel.Tag = "CLEAR"
        Me.PalletsOnBoardLabel.Text = "PalletsOnBoardLabel"
        Me.PalletsOnBoardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.PalletsOnBoardLabel.Visible = False
        '
        'POBLabel
        '
        Me.POBLabel.Location = New System.Drawing.Point(229, 214)
        Me.POBLabel.Name = "POBLabel"
        Me.POBLabel.Size = New System.Drawing.Size(123, 23)
        Me.POBLabel.TabIndex = 7
        Me.POBLabel.Text = "PALLETS ON-BOARD:"
        Me.POBLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.POBLabel.Visible = False
        '
        'PrecoolPictureBox
        '
        Me.PrecoolPictureBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrecoolPictureBox.Image = CType(resources.GetObject("PrecoolPictureBox.Image"), System.Drawing.Image)
        Me.PrecoolPictureBox.Location = New System.Drawing.Point(578, 183)
        Me.PrecoolPictureBox.Name = "PrecoolPictureBox"
        Me.PrecoolPictureBox.Size = New System.Drawing.Size(88, 54)
        Me.PrecoolPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PrecoolPictureBox.TabIndex = 5
        Me.PrecoolPictureBox.TabStop = False
        Me.PrecoolPictureBox.Visible = False
        '
        'PreCoolingLabel
        '
        Me.PreCoolingLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PreCoolingLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PreCoolingLabel.ForeColor = System.Drawing.Color.Red
        Me.PreCoolingLabel.Location = New System.Drawing.Point(6, 233)
        Me.PreCoolingLabel.Name = "PreCoolingLabel"
        Me.PreCoolingLabel.Size = New System.Drawing.Size(566, 23)
        Me.PreCoolingLabel.TabIndex = 6
        Me.PreCoolingLabel.Tag = "CLEAR"
        Me.PreCoolingLabel.Text = "Pre-Cooling"
        Me.PreCoolingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PreCoolingLabel.Visible = False
        '
        'BarcodeLabel
        '
        Me.BarcodeLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BarcodeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarcodeLabel.ForeColor = System.Drawing.Color.DarkBlue
        Me.BarcodeLabel.Location = New System.Drawing.Point(261, 95)
        Me.BarcodeLabel.Name = "BarcodeLabel"
        Me.BarcodeLabel.Size = New System.Drawing.Size(110, 23)
        Me.BarcodeLabel.TabIndex = 2
        Me.BarcodeLabel.Tag = "CLEAR"
        Me.BarcodeLabel.Text = "BarcodeLabel"
        Me.BarcodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TrailerIDLabel
        '
        Me.TrailerIDLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TrailerIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrailerIDLabel.ForeColor = System.Drawing.Color.DarkBlue
        Me.TrailerIDLabel.Location = New System.Drawing.Point(6, 48)
        Me.TrailerIDLabel.Name = "TrailerIDLabel"
        Me.TrailerIDLabel.Size = New System.Drawing.Size(636, 29)
        Me.TrailerIDLabel.TabIndex = 1
        Me.TrailerIDLabel.Tag = "CLEAR"
        Me.TrailerIDLabel.Text = "TrailerIDLabel"
        Me.TrailerIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BCLabel
        '
        Me.BCLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BCLabel.Location = New System.Drawing.Point(261, 76)
        Me.BCLabel.Name = "BCLabel"
        Me.BCLabel.Size = New System.Drawing.Size(110, 23)
        Me.BCLabel.TabIndex = 3
        Me.BCLabel.Text = "BARCODE:"
        Me.BCLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SearchPictureBox
        '
        Me.SearchPictureBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchPictureBox.BackColor = System.Drawing.Color.Gray
        Me.SearchPictureBox.Image = CType(resources.GetObject("SearchPictureBox.Image"), System.Drawing.Image)
        Me.SearchPictureBox.Location = New System.Drawing.Point(665, 0)
        Me.SearchPictureBox.Name = "SearchPictureBox"
        Me.SearchPictureBox.Size = New System.Drawing.Size(25, 25)
        Me.SearchPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.SearchPictureBox.TabIndex = 1
        Me.SearchPictureBox.TabStop = False
        Me.SearchPictureBox.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.Gray
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ShowPrecoolsToolStripButton, Me.ToolStripSeparator1, Me.SearchStyleToolStripDropDownButton, Me.SearchToolStripTextBox, Me.SearchToolStripButton, Me.ToolStripSeparator2, Me.SearchTypeToolStripDropDownButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(690, 28)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.Gray
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(13, 25)
        Me.ToolStripLabel1.Text = "1"
        '
        'ShowPrecoolsToolStripButton
        '
        Me.ShowPrecoolsToolStripButton.BackColor = System.Drawing.Color.Black
        Me.ShowPrecoolsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ShowPrecoolsToolStripButton.ForeColor = System.Drawing.Color.White
        Me.ShowPrecoolsToolStripButton.Image = CType(resources.GetObject("ShowPrecoolsToolStripButton.Image"), System.Drawing.Image)
        Me.ShowPrecoolsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ShowPrecoolsToolStripButton.Name = "ShowPrecoolsToolStripButton"
        Me.ShowPrecoolsToolStripButton.Size = New System.Drawing.Size(112, 25)
        Me.ShowPrecoolsToolStripButton.Text = "Show All Pre-Cools"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 28)
        '
        'SearchStyleToolStripDropDownButton
        '
        Me.SearchStyleToolStripDropDownButton.BackColor = System.Drawing.Color.Black
        Me.SearchStyleToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SearchStyleToolStripDropDownButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchTrailerToolStripMenuItem, Me.SearchCarrierToolStripMenuItem})
        Me.SearchStyleToolStripDropDownButton.ForeColor = System.Drawing.Color.White
        Me.SearchStyleToolStripDropDownButton.Image = CType(resources.GetObject("SearchStyleToolStripDropDownButton.Image"), System.Drawing.Image)
        Me.SearchStyleToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SearchStyleToolStripDropDownButton.Name = "SearchStyleToolStripDropDownButton"
        Me.SearchStyleToolStripDropDownButton.Size = New System.Drawing.Size(101, 25)
        Me.SearchStyleToolStripDropDownButton.Text = "Search Trailer #"
        '
        'SearchTrailerToolStripMenuItem
        '
        Me.SearchTrailerToolStripMenuItem.Name = "SearchTrailerToolStripMenuItem"
        Me.SearchTrailerToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.SearchTrailerToolStripMenuItem.Text = "Search Trailer #"
        '
        'SearchCarrierToolStripMenuItem
        '
        Me.SearchCarrierToolStripMenuItem.Name = "SearchCarrierToolStripMenuItem"
        Me.SearchCarrierToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.SearchCarrierToolStripMenuItem.Text = "Search Carrier"
        '
        'SearchToolStripTextBox
        '
        Me.SearchToolStripTextBox.MaxLength = 15
        Me.SearchToolStripTextBox.Name = "SearchToolStripTextBox"
        Me.SearchToolStripTextBox.Size = New System.Drawing.Size(150, 28)
        '
        'SearchToolStripButton
        '
        Me.SearchToolStripButton.BackColor = System.Drawing.Color.Black
        Me.SearchToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SearchToolStripButton.ForeColor = System.Drawing.Color.White
        Me.SearchToolStripButton.Image = CType(resources.GetObject("SearchToolStripButton.Image"), System.Drawing.Image)
        Me.SearchToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SearchToolStripButton.Name = "SearchToolStripButton"
        Me.SearchToolStripButton.Size = New System.Drawing.Size(26, 25)
        Me.SearchToolStripButton.Text = "Go"
        Me.SearchToolStripButton.ToolTipText = "Enter the trailer number and click Search!"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 28)
        '
        'SearchTypeToolStripDropDownButton
        '
        Me.SearchTypeToolStripDropDownButton.BackColor = System.Drawing.Color.Black
        Me.SearchTypeToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SearchTypeToolStripDropDownButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExactMatchToolStripMenuItem, Me.SimilarMatchToolStripMenuItem})
        Me.SearchTypeToolStripDropDownButton.ForeColor = System.Drawing.Color.White
        Me.SearchTypeToolStripDropDownButton.Image = CType(resources.GetObject("SearchTypeToolStripDropDownButton.Image"), System.Drawing.Image)
        Me.SearchTypeToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SearchTypeToolStripDropDownButton.Name = "SearchTypeToolStripDropDownButton"
        Me.SearchTypeToolStripDropDownButton.Size = New System.Drawing.Size(84, 25)
        Me.SearchTypeToolStripDropDownButton.Text = "Exact Match"
        '
        'ExactMatchToolStripMenuItem
        '
        Me.ExactMatchToolStripMenuItem.Name = "ExactMatchToolStripMenuItem"
        Me.ExactMatchToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.ExactMatchToolStripMenuItem.Text = "Exact Match"
        '
        'SimilarMatchToolStripMenuItem
        '
        Me.SimilarMatchToolStripMenuItem.Name = "SimilarMatchToolStripMenuItem"
        Me.SimilarMatchToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.SimilarMatchToolStripMenuItem.Text = "Similar Match"
        '
        'PreCoolForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 358)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TrailerTreeView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PreCoolForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pre-Cool Manager"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TrailerDetailsGroupBox.ResumeLayout(False)
        Me.TrailerDetailsGroupBox.PerformLayout()
        CType(Me.PrecoolPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TrailerTreeView As System.Windows.Forms.TreeView
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents TrailerCountLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents SearchToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents SearchToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents SearchTypeToolStripDropDownButton As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ExactMatchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SimilarMatchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MessageToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ShowPrecoolsToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents SearchPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents TrailerDetailsGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents TrailerIDLabel As System.Windows.Forms.Label
    Friend WithEvents CarrierNameLabel As System.Windows.Forms.Label
    Friend WithEvents BarcodeLabel As System.Windows.Forms.Label
    Friend WithEvents BCLabel As System.Windows.Forms.Label
    Friend WithEvents PalletsOnBoardLabel As System.Windows.Forms.Label
    Friend WithEvents PrecoolPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents PreCoolingLabel As System.Windows.Forms.Label
    Friend WithEvents POBLabel As System.Windows.Forms.Label
    Friend WithEvents TemperatureLabel As System.Windows.Forms.Label
    Friend WithEvents SPLabel As System.Windows.Forms.Label
    Friend WithEvents TimeRunningLabel As System.Windows.Forms.Label
    Friend WithEvents CurrentLocationLabel As System.Windows.Forms.Label
    Friend WithEvents LOCLabel As System.Windows.Forms.Label
    Friend WithEvents MyCloseButton As System.Windows.Forms.Button
    Friend WithEvents StopPrecoolButton As System.Windows.Forms.Button
    Friend WithEvents StartPrecoolButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CancelRequestButton As System.Windows.Forms.Button
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SearchStyleToolStripDropDownButton As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents SearchTrailerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchCarrierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StopUnitLabel As System.Windows.Forms.Label
    Friend WithEvents LoadStatusLabel As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
