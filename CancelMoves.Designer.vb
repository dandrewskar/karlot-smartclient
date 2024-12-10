<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CancelMoves
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
        Me.TrailersListBox = New System.Windows.Forms.ListBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.CarrierNameLabel = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TrailerIDLabel = New System.Windows.Forms.Label
        Me.ActionButton = New System.Windows.Forms.Button
        Me.CancelAllButton = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.StatusLabel = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TrailersListBox
        '
        Me.TrailersListBox.Dock = System.Windows.Forms.DockStyle.Left
        Me.TrailersListBox.FormattingEnabled = True
        Me.TrailersListBox.Location = New System.Drawing.Point(0, 0)
        Me.TrailersListBox.Name = "TrailersListBox"
        Me.TrailersListBox.Size = New System.Drawing.Size(127, 212)
        Me.TrailersListBox.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.StatusLabel)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TrailerIDLabel)
        Me.GroupBox1.Controls.Add(Me.ActionButton)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.CarrierNameLabel)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(133, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(424, 152)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Trailer Information"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Carrier Name:"
        '
        'CarrierNameLabel
        '
        Me.CarrierNameLabel.AutoSize = True
        Me.CarrierNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CarrierNameLabel.ForeColor = System.Drawing.Color.Navy
        Me.CarrierNameLabel.Location = New System.Drawing.Point(6, 41)
        Me.CarrierNameLabel.Name = "CarrierNameLabel"
        Me.CarrierNameLabel.Size = New System.Drawing.Size(131, 16)
        Me.CarrierNameLabel.TabIndex = 1
        Me.CarrierNameLabel.Text = "CarrierNameField"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Trailer Number:"
        '
        'TrailerIDLabel
        '
        Me.TrailerIDLabel.AutoSize = True
        Me.TrailerIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrailerIDLabel.ForeColor = System.Drawing.Color.Navy
        Me.TrailerIDLabel.Location = New System.Drawing.Point(6, 80)
        Me.TrailerIDLabel.Name = "TrailerIDLabel"
        Me.TrailerIDLabel.Size = New System.Drawing.Size(104, 16)
        Me.TrailerIDLabel.TabIndex = 3
        Me.TrailerIDLabel.Text = "TrailerIDField"
        '
        'ActionButton
        '
        Me.ActionButton.Location = New System.Drawing.Point(315, 114)
        Me.ActionButton.Name = "ActionButton"
        Me.ActionButton.Size = New System.Drawing.Size(103, 32)
        Me.ActionButton.TabIndex = 2
        Me.ActionButton.Text = "Cancel Move"
        Me.ActionButton.UseVisualStyleBackColor = True
        '
        'CancelAllButton
        '
        Me.CancelAllButton.Location = New System.Drawing.Point(133, 170)
        Me.CancelAllButton.Name = "CancelAllButton"
        Me.CancelAllButton.Size = New System.Drawing.Size(136, 32)
        Me.CancelAllButton.TabIndex = 3
        Me.CancelAllButton.Text = "Cancel ALL Moves"
        Me.CancelAllButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(226, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Move Type:"
        '
        'StatusLabel
        '
        Me.StatusLabel.AutoSize = True
        Me.StatusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusLabel.ForeColor = System.Drawing.Color.Navy
        Me.StatusLabel.Location = New System.Drawing.Point(226, 80)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(104, 16)
        Me.StatusLabel.TabIndex = 5
        Me.StatusLabel.Text = "TrailerIDField"
        '
        'CancelMoves
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 212)
        Me.Controls.Add(Me.CancelAllButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TrailersListBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "CancelMoves"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cancel Moves"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TrailersListBox As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CarrierNameLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TrailerIDLabel As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ActionButton As System.Windows.Forms.Button
    Friend WithEvents CancelAllButton As System.Windows.Forms.Button
    Friend WithEvents StatusLabel As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
