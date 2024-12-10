<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CallOutLocations
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.WashOnlyPanel = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.NextLocationDoorsListBox = New System.Windows.Forms.ListBox
        Me.NextLocLabel = New System.Windows.Forms.Label
        Me.ActionButton = New System.Windows.Forms.Button
        Me.MyCancelButton = New System.Windows.Forms.Button
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.WashOnlyPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.WashOnlyPanel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.NextLocationDoorsListBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.NextLocLabel)
        Me.SplitContainer1.Size = New System.Drawing.Size(379, 320)
        Me.SplitContainer1.SplitterDistance = 349
        Me.SplitContainer1.SplitterWidth = 1
        Me.SplitContainer1.TabIndex = 0
        '
        'WashOnlyPanel
        '
        Me.WashOnlyPanel.Controls.Add(Me.Label2)
        Me.WashOnlyPanel.Location = New System.Drawing.Point(17, 45)
        Me.WashOnlyPanel.Name = "WashOnlyPanel"
        Me.WashOnlyPanel.Size = New System.Drawing.Size(310, 270)
        Me.WashOnlyPanel.TabIndex = 7
        Me.WashOnlyPanel.Visible = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(270, 205)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "This trailer is set to go to the wash dock next. You may select a re-call locatio" & _
            "n if needed."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Select Location"
        '
        'NextLocationDoorsListBox
        '
        Me.NextLocationDoorsListBox.FormattingEnabled = True
        Me.NextLocationDoorsListBox.Location = New System.Drawing.Point(17, 62)
        Me.NextLocationDoorsListBox.Name = "NextLocationDoorsListBox"
        Me.NextLocationDoorsListBox.Size = New System.Drawing.Size(310, 251)
        Me.NextLocationDoorsListBox.Sorted = True
        Me.NextLocationDoorsListBox.TabIndex = 5
        '
        'NextLocLabel
        '
        Me.NextLocLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NextLocLabel.Location = New System.Drawing.Point(12, 9)
        Me.NextLocLabel.Name = "NextLocLabel"
        Me.NextLocLabel.Size = New System.Drawing.Size(315, 29)
        Me.NextLocLabel.TabIndex = 0
        Me.NextLocLabel.Text = "Next Location"
        Me.NextLocLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ActionButton
        '
        Me.ActionButton.Location = New System.Drawing.Point(183, 326)
        Me.ActionButton.Name = "ActionButton"
        Me.ActionButton.Size = New System.Drawing.Size(121, 36)
        Me.ActionButton.TabIndex = 1
        Me.ActionButton.Text = "OK"
        Me.ActionButton.UseVisualStyleBackColor = True
        '
        'MyCancelButton
        '
        Me.MyCancelButton.Location = New System.Drawing.Point(56, 326)
        Me.MyCancelButton.Name = "MyCancelButton"
        Me.MyCancelButton.Size = New System.Drawing.Size(121, 36)
        Me.MyCancelButton.TabIndex = 2
        Me.MyCancelButton.Text = "Cancel"
        Me.MyCancelButton.UseVisualStyleBackColor = True
        '
        'CallOutLocations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 366)
        Me.Controls.Add(Me.MyCancelButton)
        Me.Controls.Add(Me.ActionButton)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CallOutLocations"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Call Out Locations"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        Me.WashOnlyPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents NextLocLabel As System.Windows.Forms.Label
    Friend WithEvents ActionButton As System.Windows.Forms.Button
    Friend WithEvents MyCancelButton As System.Windows.Forms.Button
    Friend WithEvents NextLocationDoorsListBox As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents WashOnlyPanel As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
