<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BarcodesForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BarcodesForm))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.BarcodesTabControl = New System.Windows.Forms.TabControl
        Me.BarcodeLookupTabPage = New System.Windows.Forms.TabPage
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.LookupBarcodeButton = New System.Windows.Forms.Button
        Me.BarcodeDataTextBox = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TrailerIDLabel = New System.Windows.Forms.Label
        Me.CarrierNameLabel = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BarcodeDataLabel = New System.Windows.Forms.Label
        Me.AssignBarcodesTabPage = New System.Windows.Forms.TabPage
        Me.CancelSaveBarcodeButton = New System.Windows.Forms.Button
        Me.SaveBarcodeButton = New System.Windows.Forms.Button
        Me.NewBarcodeTextBox = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.ScacCodeTextBox = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TrailerNumberTextBox = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.CarrierNameComboBox = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar
        Me.MessageStatusLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.LoadReferenceDataBackgroundWorker = New System.ComponentModel.BackgroundWorker
        Me.SaveBarcodeBackgroundWorker = New System.ComponentModel.BackgroundWorker
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BarcodesTabControl.SuspendLayout()
        Me.BarcodeLookupTabPage.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.AssignBarcodesTabPage.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BarcodesTabControl, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 18)
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 307.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(700, 395)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(700, 70)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'BarcodesTabControl
        '
        Me.BarcodesTabControl.Controls.Add(Me.BarcodeLookupTabPage)
        Me.BarcodesTabControl.Controls.Add(Me.AssignBarcodesTabPage)
        Me.BarcodesTabControl.Controls.Add(Me.TabPage1)
        Me.BarcodesTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BarcodesTabControl.ImageList = Me.ImageList1
        Me.BarcodesTabControl.Location = New System.Drawing.Point(3, 73)
        Me.BarcodesTabControl.Name = "BarcodesTabControl"
        Me.BarcodesTabControl.SelectedIndex = 0
        Me.BarcodesTabControl.Size = New System.Drawing.Size(694, 301)
        Me.BarcodesTabControl.TabIndex = 1
        '
        'BarcodeLookupTabPage
        '
        Me.BarcodeLookupTabPage.Controls.Add(Me.SplitContainer1)
        Me.BarcodeLookupTabPage.ImageIndex = 0
        Me.BarcodeLookupTabPage.Location = New System.Drawing.Point(4, 43)
        Me.BarcodeLookupTabPage.Name = "BarcodeLookupTabPage"
        Me.BarcodeLookupTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.BarcodeLookupTabPage.Size = New System.Drawing.Size(686, 254)
        Me.BarcodeLookupTabPage.TabIndex = 0
        Me.BarcodeLookupTabPage.Text = "Barcode Lookup"
        Me.BarcodeLookupTabPage.UseVisualStyleBackColor = True
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LookupBarcodeButton)
        Me.SplitContainer1.Panel1.Controls.Add(Me.BarcodeDataTextBox)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Size = New System.Drawing.Size(680, 248)
        Me.SplitContainer1.SplitterDistance = 215
        Me.SplitContainer1.SplitterWidth = 1
        Me.SplitContainer1.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(35, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 67)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Enter the barcode number below and click the Lookup button..."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Barcode"
        '
        'LookupBarcodeButton
        '
        Me.LookupBarcodeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LookupBarcodeButton.Location = New System.Drawing.Point(35, 154)
        Me.LookupBarcodeButton.Name = "LookupBarcodeButton"
        Me.LookupBarcodeButton.Size = New System.Drawing.Size(135, 31)
        Me.LookupBarcodeButton.TabIndex = 2
        Me.LookupBarcodeButton.Text = "Lookup >>"
        Me.LookupBarcodeButton.UseVisualStyleBackColor = True
        '
        'BarcodeDataTextBox
        '
        Me.BarcodeDataTextBox.Location = New System.Drawing.Point(35, 128)
        Me.BarcodeDataTextBox.Name = "BarcodeDataTextBox"
        Me.BarcodeDataTextBox.Size = New System.Drawing.Size(135, 20)
        Me.BarcodeDataTextBox.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.TrailerIDLabel)
        Me.GroupBox2.Controls.Add(Me.CarrierNameLabel)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 122)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(432, 101)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CARRIER | TRAILER"
        '
        'TrailerIDLabel
        '
        Me.TrailerIDLabel.BackColor = System.Drawing.Color.Transparent
        Me.TrailerIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrailerIDLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TrailerIDLabel.Location = New System.Drawing.Point(10, 49)
        Me.TrailerIDLabel.Name = "TrailerIDLabel"
        Me.TrailerIDLabel.Size = New System.Drawing.Size(416, 29)
        Me.TrailerIDLabel.TabIndex = 2
        Me.TrailerIDLabel.Text = "TrailerIDLabel"
        Me.TrailerIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CarrierNameLabel
        '
        Me.CarrierNameLabel.BackColor = System.Drawing.Color.Transparent
        Me.CarrierNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CarrierNameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CarrierNameLabel.Location = New System.Drawing.Point(6, 25)
        Me.CarrierNameLabel.Name = "CarrierNameLabel"
        Me.CarrierNameLabel.Size = New System.Drawing.Size(420, 24)
        Me.CarrierNameLabel.TabIndex = 1
        Me.CarrierNameLabel.Text = "CarrierNameLabel"
        Me.CarrierNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BarcodeDataLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(56, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(355, 76)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "BARCODE"
        '
        'BarcodeDataLabel
        '
        Me.BarcodeDataLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarcodeDataLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BarcodeDataLabel.Location = New System.Drawing.Point(25, 16)
        Me.BarcodeDataLabel.Name = "BarcodeDataLabel"
        Me.BarcodeDataLabel.Size = New System.Drawing.Size(311, 48)
        Me.BarcodeDataLabel.TabIndex = 0
        Me.BarcodeDataLabel.Text = "BarcodeDataLabel"
        Me.BarcodeDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AssignBarcodesTabPage
        '
        Me.AssignBarcodesTabPage.Controls.Add(Me.CancelSaveBarcodeButton)
        Me.AssignBarcodesTabPage.Controls.Add(Me.SaveBarcodeButton)
        Me.AssignBarcodesTabPage.Controls.Add(Me.NewBarcodeTextBox)
        Me.AssignBarcodesTabPage.Controls.Add(Me.Label7)
        Me.AssignBarcodesTabPage.Controls.Add(Me.ScacCodeTextBox)
        Me.AssignBarcodesTabPage.Controls.Add(Me.Label6)
        Me.AssignBarcodesTabPage.Controls.Add(Me.TrailerNumberTextBox)
        Me.AssignBarcodesTabPage.Controls.Add(Me.Label5)
        Me.AssignBarcodesTabPage.Controls.Add(Me.Label4)
        Me.AssignBarcodesTabPage.Controls.Add(Me.CarrierNameComboBox)
        Me.AssignBarcodesTabPage.Controls.Add(Me.Label3)
        Me.AssignBarcodesTabPage.ImageIndex = 1
        Me.AssignBarcodesTabPage.Location = New System.Drawing.Point(4, 43)
        Me.AssignBarcodesTabPage.Name = "AssignBarcodesTabPage"
        Me.AssignBarcodesTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.AssignBarcodesTabPage.Size = New System.Drawing.Size(686, 254)
        Me.AssignBarcodesTabPage.TabIndex = 1
        Me.AssignBarcodesTabPage.Text = "Assign Barcode"
        Me.AssignBarcodesTabPage.UseVisualStyleBackColor = True
        '
        'CancelSaveBarcodeButton
        '
        Me.CancelSaveBarcodeButton.Enabled = False
        Me.CancelSaveBarcodeButton.Location = New System.Drawing.Point(433, 207)
        Me.CancelSaveBarcodeButton.Name = "CancelSaveBarcodeButton"
        Me.CancelSaveBarcodeButton.Size = New System.Drawing.Size(109, 32)
        Me.CancelSaveBarcodeButton.TabIndex = 9
        Me.CancelSaveBarcodeButton.Text = "Cancel"
        Me.CancelSaveBarcodeButton.UseVisualStyleBackColor = True
        '
        'SaveBarcodeButton
        '
        Me.SaveBarcodeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBarcodeButton.Location = New System.Drawing.Point(548, 207)
        Me.SaveBarcodeButton.Name = "SaveBarcodeButton"
        Me.SaveBarcodeButton.Size = New System.Drawing.Size(109, 32)
        Me.SaveBarcodeButton.TabIndex = 8
        Me.SaveBarcodeButton.Text = "Save Barcode"
        Me.SaveBarcodeButton.UseVisualStyleBackColor = True
        '
        'NewBarcodeTextBox
        '
        Me.NewBarcodeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewBarcodeTextBox.Location = New System.Drawing.Point(370, 45)
        Me.NewBarcodeTextBox.MaxLength = 25
        Me.NewBarcodeTextBox.Name = "NewBarcodeTextBox"
        Me.NewBarcodeTextBox.Size = New System.Drawing.Size(160, 29)
        Me.NewBarcodeTextBox.TabIndex = 7
        Me.NewBarcodeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(392, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Barcode Number"
        '
        'ScacCodeTextBox
        '
        Me.ScacCodeTextBox.BackColor = System.Drawing.Color.White
        Me.ScacCodeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScacCodeTextBox.Location = New System.Drawing.Point(557, 156)
        Me.ScacCodeTextBox.Name = "ScacCodeTextBox"
        Me.ScacCodeTextBox.ReadOnly = True
        Me.ScacCodeTextBox.Size = New System.Drawing.Size(100, 23)
        Me.ScacCodeTextBox.TabIndex = 5
        Me.ScacCodeTextBox.TabStop = False
        Me.ScacCodeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(554, 140)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "SCAC Code"
        '
        'TrailerNumberTextBox
        '
        Me.TrailerNumberTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrailerNumberTextBox.Location = New System.Drawing.Point(259, 156)
        Me.TrailerNumberTextBox.MaxLength = 8
        Me.TrailerNumberTextBox.Name = "TrailerNumberTextBox"
        Me.TrailerNumberTextBox.Size = New System.Drawing.Size(160, 23)
        Me.TrailerNumberTextBox.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(256, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Trailer Number"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(20, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(212, 198)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Assign a new barcode to a trailer by selecting the carrier from the list and fill" & _
            "ing out the trailer information. Then click the save button to save you changes." & _
            ".."
        '
        'CarrierNameComboBox
        '
        Me.CarrierNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CarrierNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CarrierNameComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CarrierNameComboBox.Location = New System.Drawing.Point(259, 116)
        Me.CarrierNameComboBox.Name = "CarrierNameComboBox"
        Me.CarrierNameComboBox.Size = New System.Drawing.Size(398, 24)
        Me.CarrierNameComboBox.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(256, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Carrier Name"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.SplitContainer2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 43)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(686, 254)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Reverse Lookup"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.IsSplitterFixed = True
        Me.SplitContainer2.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label8)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label9)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.TextBox1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.DataGridView1)
        Me.SplitContainer2.Size = New System.Drawing.Size(680, 248)
        Me.SplitContainer2.SplitterDistance = 215
        Me.SplitContainer2.SplitterWidth = 1
        Me.SplitContainer2.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(35, 45)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(135, 67)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Enter the trailer number below and click the Lookup button to see barcodes..."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(32, 112)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Trailer Number"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(35, 154)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 31)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Lookup >>"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(35, 128)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(135, 20)
        Me.TextBox1.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(462, 246)
        Me.DataGridView1.TabIndex = 0
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "search.jpg")
        Me.ImageList1.Images.SetKeyName(1, "barcode.PNG")
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripProgressBar1, Me.MessageStatusLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 373)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(700, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Enabled = False
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 16)
        Me.ToolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        '
        'MessageStatusLabel
        '
        Me.MessageStatusLabel.Name = "MessageStatusLabel"
        Me.MessageStatusLabel.Size = New System.Drawing.Size(583, 17)
        Me.MessageStatusLabel.Spring = True
        Me.MessageStatusLabel.Text = "MessageStatusLabel"
        Me.MessageStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LoadReferenceDataBackgroundWorker
        '
        '
        'SaveBarcodeBackgroundWorker
        '
        Me.SaveBarcodeBackgroundWorker.WorkerReportsProgress = True
        Me.SaveBarcodeBackgroundWorker.WorkerSupportsCancellation = True
        '
        'BarcodesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 395)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BarcodesForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Barcodes"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BarcodesTabControl.ResumeLayout(False)
        Me.BarcodeLookupTabPage.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.AssignBarcodesTabPage.ResumeLayout(False)
        Me.AssignBarcodesTabPage.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BarcodesTabControl As System.Windows.Forms.TabControl
    Friend WithEvents BarcodeLookupTabPage As System.Windows.Forms.TabPage
    Friend WithEvents AssignBarcodesTabPage As System.Windows.Forms.TabPage
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LookupBarcodeButton As System.Windows.Forms.Button
    Friend WithEvents BarcodeDataTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents TrailerIDLabel As System.Windows.Forms.Label
    Friend WithEvents CarrierNameLabel As System.Windows.Forms.Label
    Friend WithEvents BarcodeDataLabel As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents MessageStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents LoadReferenceDataBackgroundWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents CarrierNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ScacCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TrailerNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents NewBarcodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents SaveBarcodeButton As System.Windows.Forms.Button
    Friend WithEvents SaveBarcodeBackgroundWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents CancelSaveBarcodeButton As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
