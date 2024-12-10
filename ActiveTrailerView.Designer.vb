<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActiveTrailerView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ActiveTrailerView))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.ActiveTrailerGridView = New System.Windows.Forms.DataGridView
        Me.SystemIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SCACDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CarrierDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TrailerIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CurrentLocationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NextLocationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ThirdLocationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClassificationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MoveStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TemperatureDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BarcodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PalletTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CleanStateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.WhosMoveDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LoadStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ActiveTrailersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.CheckOutTrailerToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.RecordCounterToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.ActiveTrailerGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActiveTrailersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ActiveTrailerGridView, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ToolStrip1, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(730, 453)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'ActiveTrailerGridView
        '
        Me.ActiveTrailerGridView.AllowUserToAddRows = False
        Me.ActiveTrailerGridView.AllowUserToDeleteRows = False
        Me.ActiveTrailerGridView.AutoGenerateColumns = False
        Me.ActiveTrailerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ActiveTrailerGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SystemIDDataGridViewTextBoxColumn, Me.SCACDataGridViewTextBoxColumn, Me.CarrierDataGridViewTextBoxColumn, Me.TrailerIDDataGridViewTextBoxColumn, Me.CurrentLocationDataGridViewTextBoxColumn, Me.NextLocationDataGridViewTextBoxColumn, Me.ThirdLocationDataGridViewTextBoxColumn, Me.ClassificationDataGridViewTextBoxColumn, Me.MoveStatusDataGridViewTextBoxColumn, Me.TemperatureDataGridViewTextBoxColumn, Me.BarcodeDataGridViewTextBoxColumn, Me.PalletTypeDataGridViewTextBoxColumn, Me.CleanStateDataGridViewTextBoxColumn, Me.WhosMoveDataGridViewTextBoxColumn, Me.LoadStatusDataGridViewTextBoxColumn})
        Me.ActiveTrailerGridView.DataSource = Me.ActiveTrailersBindingSource
        Me.ActiveTrailerGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ActiveTrailerGridView.Location = New System.Drawing.Point(3, 25)
        Me.ActiveTrailerGridView.Name = "ActiveTrailerGridView"
        Me.ActiveTrailerGridView.ReadOnly = True
        Me.ActiveTrailerGridView.Size = New System.Drawing.Size(724, 425)
        Me.ActiveTrailerGridView.TabIndex = 2
        '
        'SystemIDDataGridViewTextBoxColumn
        '
        Me.SystemIDDataGridViewTextBoxColumn.DataPropertyName = "SystemID"
        Me.SystemIDDataGridViewTextBoxColumn.HeaderText = "SystemID"
        Me.SystemIDDataGridViewTextBoxColumn.Name = "SystemIDDataGridViewTextBoxColumn"
        Me.SystemIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.SystemIDDataGridViewTextBoxColumn.Visible = False
        '
        'SCACDataGridViewTextBoxColumn
        '
        Me.SCACDataGridViewTextBoxColumn.DataPropertyName = "SCAC"
        Me.SCACDataGridViewTextBoxColumn.HeaderText = "SCAC"
        Me.SCACDataGridViewTextBoxColumn.Name = "SCACDataGridViewTextBoxColumn"
        Me.SCACDataGridViewTextBoxColumn.ReadOnly = True
        Me.SCACDataGridViewTextBoxColumn.Width = 50
        '
        'CarrierDataGridViewTextBoxColumn
        '
        Me.CarrierDataGridViewTextBoxColumn.DataPropertyName = "Carrier"
        Me.CarrierDataGridViewTextBoxColumn.HeaderText = "Carrier"
        Me.CarrierDataGridViewTextBoxColumn.Name = "CarrierDataGridViewTextBoxColumn"
        Me.CarrierDataGridViewTextBoxColumn.ReadOnly = True
        Me.CarrierDataGridViewTextBoxColumn.Width = 250
        '
        'TrailerIDDataGridViewTextBoxColumn
        '
        Me.TrailerIDDataGridViewTextBoxColumn.DataPropertyName = "TrailerID"
        Me.TrailerIDDataGridViewTextBoxColumn.HeaderText = "Trailer Number"
        Me.TrailerIDDataGridViewTextBoxColumn.Name = "TrailerIDDataGridViewTextBoxColumn"
        Me.TrailerIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.TrailerIDDataGridViewTextBoxColumn.Width = 75
        '
        'CurrentLocationDataGridViewTextBoxColumn
        '
        Me.CurrentLocationDataGridViewTextBoxColumn.DataPropertyName = "CurrentLocation"
        Me.CurrentLocationDataGridViewTextBoxColumn.HeaderText = "Current Location"
        Me.CurrentLocationDataGridViewTextBoxColumn.Name = "CurrentLocationDataGridViewTextBoxColumn"
        Me.CurrentLocationDataGridViewTextBoxColumn.ReadOnly = True
        Me.CurrentLocationDataGridViewTextBoxColumn.Width = 60
        '
        'NextLocationDataGridViewTextBoxColumn
        '
        Me.NextLocationDataGridViewTextBoxColumn.DataPropertyName = "NextLocation"
        Me.NextLocationDataGridViewTextBoxColumn.HeaderText = "NextLocation"
        Me.NextLocationDataGridViewTextBoxColumn.Name = "NextLocationDataGridViewTextBoxColumn"
        Me.NextLocationDataGridViewTextBoxColumn.ReadOnly = True
        Me.NextLocationDataGridViewTextBoxColumn.Visible = False
        '
        'ThirdLocationDataGridViewTextBoxColumn
        '
        Me.ThirdLocationDataGridViewTextBoxColumn.DataPropertyName = "ThirdLocation"
        Me.ThirdLocationDataGridViewTextBoxColumn.HeaderText = "ThirdLocation"
        Me.ThirdLocationDataGridViewTextBoxColumn.Name = "ThirdLocationDataGridViewTextBoxColumn"
        Me.ThirdLocationDataGridViewTextBoxColumn.ReadOnly = True
        Me.ThirdLocationDataGridViewTextBoxColumn.Visible = False
        '
        'ClassificationDataGridViewTextBoxColumn
        '
        Me.ClassificationDataGridViewTextBoxColumn.DataPropertyName = "Classification"
        Me.ClassificationDataGridViewTextBoxColumn.HeaderText = "Classification"
        Me.ClassificationDataGridViewTextBoxColumn.Name = "ClassificationDataGridViewTextBoxColumn"
        Me.ClassificationDataGridViewTextBoxColumn.ReadOnly = True
        Me.ClassificationDataGridViewTextBoxColumn.Visible = False
        '
        'MoveStatusDataGridViewTextBoxColumn
        '
        Me.MoveStatusDataGridViewTextBoxColumn.DataPropertyName = "MoveStatus"
        Me.MoveStatusDataGridViewTextBoxColumn.HeaderText = "MoveStatus"
        Me.MoveStatusDataGridViewTextBoxColumn.Name = "MoveStatusDataGridViewTextBoxColumn"
        Me.MoveStatusDataGridViewTextBoxColumn.ReadOnly = True
        Me.MoveStatusDataGridViewTextBoxColumn.Visible = False
        '
        'TemperatureDataGridViewTextBoxColumn
        '
        Me.TemperatureDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.TemperatureDataGridViewTextBoxColumn.DataPropertyName = "Temperature"
        Me.TemperatureDataGridViewTextBoxColumn.HeaderText = "Temperature"
        Me.TemperatureDataGridViewTextBoxColumn.Name = "TemperatureDataGridViewTextBoxColumn"
        Me.TemperatureDataGridViewTextBoxColumn.ReadOnly = True
        Me.TemperatureDataGridViewTextBoxColumn.Width = 92
        '
        'BarcodeDataGridViewTextBoxColumn
        '
        Me.BarcodeDataGridViewTextBoxColumn.DataPropertyName = "Barcode"
        Me.BarcodeDataGridViewTextBoxColumn.HeaderText = "Barcode"
        Me.BarcodeDataGridViewTextBoxColumn.Name = "BarcodeDataGridViewTextBoxColumn"
        Me.BarcodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PalletTypeDataGridViewTextBoxColumn
        '
        Me.PalletTypeDataGridViewTextBoxColumn.DataPropertyName = "PalletType"
        Me.PalletTypeDataGridViewTextBoxColumn.HeaderText = "PalletType"
        Me.PalletTypeDataGridViewTextBoxColumn.Name = "PalletTypeDataGridViewTextBoxColumn"
        Me.PalletTypeDataGridViewTextBoxColumn.ReadOnly = True
        Me.PalletTypeDataGridViewTextBoxColumn.Visible = False
        '
        'CleanStateDataGridViewTextBoxColumn
        '
        Me.CleanStateDataGridViewTextBoxColumn.DataPropertyName = "CleanState"
        Me.CleanStateDataGridViewTextBoxColumn.HeaderText = "CleanState"
        Me.CleanStateDataGridViewTextBoxColumn.Name = "CleanStateDataGridViewTextBoxColumn"
        Me.CleanStateDataGridViewTextBoxColumn.ReadOnly = True
        Me.CleanStateDataGridViewTextBoxColumn.Visible = False
        '
        'WhosMoveDataGridViewTextBoxColumn
        '
        Me.WhosMoveDataGridViewTextBoxColumn.DataPropertyName = "WhosMove"
        Me.WhosMoveDataGridViewTextBoxColumn.HeaderText = "WhosMove"
        Me.WhosMoveDataGridViewTextBoxColumn.Name = "WhosMoveDataGridViewTextBoxColumn"
        Me.WhosMoveDataGridViewTextBoxColumn.ReadOnly = True
        Me.WhosMoveDataGridViewTextBoxColumn.Visible = False
        '
        'LoadStatusDataGridViewTextBoxColumn
        '
        Me.LoadStatusDataGridViewTextBoxColumn.DataPropertyName = "LoadStatus"
        Me.LoadStatusDataGridViewTextBoxColumn.HeaderText = "Load Status"
        Me.LoadStatusDataGridViewTextBoxColumn.Name = "LoadStatusDataGridViewTextBoxColumn"
        Me.LoadStatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ActiveTrailersBindingSource
        '
        Me.ActiveTrailersBindingSource.DataMember = "ActiveTrailers"
        Me.ActiveTrailersBindingSource.DataSource = GetType(KAR_Lot_SmartClient.karservices.cactus.smartclient.BarcodeDataSet)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CheckOutTrailerToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(730, 22)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'CheckOutTrailerToolStripButton
        '
        Me.CheckOutTrailerToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.CheckOutTrailerToolStripButton.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckOutTrailerToolStripButton.Image = CType(resources.GetObject("CheckOutTrailerToolStripButton.Image"), System.Drawing.Image)
        Me.CheckOutTrailerToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CheckOutTrailerToolStripButton.Name = "CheckOutTrailerToolStripButton"
        Me.CheckOutTrailerToolStripButton.Size = New System.Drawing.Size(68, 19)
        Me.CheckOutTrailerToolStripButton.Text = "Check Out"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RecordCounterToolStripStatusLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 454)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(730, 24)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'RecordCounterToolStripStatusLabel
        '
        Me.RecordCounterToolStripStatusLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.RecordCounterToolStripStatusLabel.Name = "RecordCounterToolStripStatusLabel"
        Me.RecordCounterToolStripStatusLabel.Size = New System.Drawing.Size(715, 19)
        Me.RecordCounterToolStripStatusLabel.Spring = True
        Me.RecordCounterToolStripStatusLabel.Text = "RecordCounterToolStripStatusLabel"
        Me.RecordCounterToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ActiveTrailerView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 478)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "ActiveTrailerView"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Active Trailers"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.ActiveTrailerGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActiveTrailersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ActiveTrailersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents RecordCounterToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ActiveTrailerGridView As System.Windows.Forms.DataGridView
    Friend WithEvents SystemIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SCACDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CarrierDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TrailerIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurrentLocationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NextLocationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ThirdLocationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClassificationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MoveStatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TemperatureDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BarcodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PalletTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CleanStateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WhosMoveDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LoadStatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents CheckOutTrailerToolStripButton As System.Windows.Forms.ToolStripButton
End Class
