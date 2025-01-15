<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UpdateTrailerInfo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateTrailerInfo))
        Me.TrailersDataGridView = New System.Windows.Forms.DataGridView
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SCACDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CarrierDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AddedByDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SysCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TrailersCarriersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TrailerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UpdateTrailerDataSet = New KAR_Lot_SmartClient.karservices.cactus.smartclient.UpdateTrailerDataSet
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        CType(Me.TrailersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrailersCarriersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrailerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UpdateTrailerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TrailersDataGridView
        '
        Me.TrailersDataGridView.AutoGenerateColumns = False
        Me.TrailersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TrailersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.SCACDataGridViewTextBoxColumn, Me.CarrierDataGridViewTextBoxColumn, Me.AddedByDataGridViewTextBoxColumn, Me.SysCodeDataGridViewTextBoxColumn})
        Me.TrailersDataGridView.DataSource = Me.TrailersCarriersBindingSource
        Me.TrailersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TrailersDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.TrailersDataGridView.Name = "TrailersDataGridView"
        Me.TrailersDataGridView.Size = New System.Drawing.Size(504, 440)
        Me.TrailersDataGridView.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SCACDataGridViewTextBoxColumn
        '
        Me.SCACDataGridViewTextBoxColumn.DataPropertyName = "SCAC"
        Me.SCACDataGridViewTextBoxColumn.HeaderText = "SCAC"
        Me.SCACDataGridViewTextBoxColumn.Name = "SCACDataGridViewTextBoxColumn"
        '
        'CarrierDataGridViewTextBoxColumn
        '
        Me.CarrierDataGridViewTextBoxColumn.DataPropertyName = "Carrier"
        Me.CarrierDataGridViewTextBoxColumn.HeaderText = "Carrier"
        Me.CarrierDataGridViewTextBoxColumn.Name = "CarrierDataGridViewTextBoxColumn"
        '
        'AddedByDataGridViewTextBoxColumn
        '
        Me.AddedByDataGridViewTextBoxColumn.DataPropertyName = "AddedBy"
        Me.AddedByDataGridViewTextBoxColumn.HeaderText = "AddedBy"
        Me.AddedByDataGridViewTextBoxColumn.Name = "AddedByDataGridViewTextBoxColumn"
        '
        'SysCodeDataGridViewTextBoxColumn
        '
        Me.SysCodeDataGridViewTextBoxColumn.DataPropertyName = "SysCode"
        Me.SysCodeDataGridViewTextBoxColumn.HeaderText = "SysCode"
        Me.SysCodeDataGridViewTextBoxColumn.Name = "SysCodeDataGridViewTextBoxColumn"
        '
        'TrailersCarriersBindingSource
        '
        Me.TrailersCarriersBindingSource.DataMember = "Trailers_Carriers"
        Me.TrailersCarriersBindingSource.DataSource = Me.TrailerBindingSource
        '
        'TrailerBindingSource
        '
        Me.TrailerBindingSource.DataMember = "Trailers"
        Me.TrailerBindingSource.DataSource = Me.UpdateTrailerDataSet
        '
        'UpdateTrailerDataSet
        '
        Me.UpdateTrailerDataSet.DataSetName = "UpdateTrailerDataSet"
        Me.UpdateTrailerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ListBox1
        '
        Me.ListBox1.DisplayMember = "SCAC"
        Me.ListBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(0, 0)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(199, 433)
        Me.ListBox1.TabIndex = 0
        Me.ListBox1.ValueMember = "SCAC"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ListBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TrailersDataGridView)
        Me.SplitContainer1.Size = New System.Drawing.Size(707, 440)
        Me.SplitContainer1.SplitterDistance = 199
        Me.SplitContainer1.TabIndex = 1
        '
        'UpdateTrailerInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(707, 440)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "UpdateTrailerInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Trailer Information"
        CType(Me.TrailersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrailersCarriersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrailerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UpdateTrailerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TrailersDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents UpdateTrailerDataSet As KAR_Lot_SmartClient.karservices.cactus.smartclient.UpdateTrailerDataSet
    Friend WithEvents TrailerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SCACDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CarrierDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddedByDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SysCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TrailersCarriersBindingSource As System.Windows.Forms.BindingSource
End Class
