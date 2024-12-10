<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintPreview
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.CactusSpecificBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.WaitPictureBox = New System.Windows.Forms.PictureBox
        CType(Me.CactusSpecificBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WaitPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CactusSpecificBindingSource
        '
        Me.CactusSpecificBindingSource.DataMember = "CactusSpecific"
        Me.CactusSpecificBindingSource.DataSource = GetType(KAR_Lot_SmartClient.karservices.cactus.smartclient.BarcodeDataSet)
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "BarcodeDataSet_CactusSpecific"
        ReportDataSource1.Value = Me.CactusSpecificBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "KAR_Lot_SmartClient.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(629, 375)
        Me.ReportViewer1.TabIndex = 0
        Me.ReportViewer1.Visible = False
        '
        'WaitPictureBox
        '
        Me.WaitPictureBox.BackColor = System.Drawing.Color.White
        Me.WaitPictureBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WaitPictureBox.Image = Global.KAR_Lot_SmartClient.My.Resources.Resources.loader_green_slider__1_
        Me.WaitPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.WaitPictureBox.Name = "WaitPictureBox"
        Me.WaitPictureBox.Size = New System.Drawing.Size(629, 375)
        Me.WaitPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.WaitPictureBox.TabIndex = 1
        Me.WaitPictureBox.TabStop = False
        '
        'PrintPreview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 375)
        Me.Controls.Add(Me.WaitPictureBox)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "PrintPreview"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report Preview"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.CactusSpecificBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WaitPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents CactusSpecificBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WaitPictureBox As System.Windows.Forms.PictureBox
End Class
