<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TaskRequest
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TaskRequest))
        Me.StartGroupBox = New System.Windows.Forms.GroupBox
        Me.TaskDescriptionLabel = New System.Windows.Forms.Label
        Me.TaskPictureBox = New System.Windows.Forms.PictureBox
        Me.MyCancelButton = New System.Windows.Forms.Button
        Me.BasicTaskButton = New System.Windows.Forms.Button
        Me.PreLoadPalletsButton = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PreLoadPalletsGroupBox = New System.Windows.Forms.GroupBox
        Me.CancelPalletTaskButton = New System.Windows.Forms.Button
        Me.SavePalletTaskButton = New System.Windows.Forms.Button
        Me.PalletsNeededGroupBox = New System.Windows.Forms.GroupBox
        Me.WhitePalletsRadioButton = New System.Windows.Forms.RadioButton
        Me.ChepRadioButton = New System.Windows.Forms.RadioButton
        Me.HeatTreatedRadioButton = New System.Windows.Forms.RadioButton
        Me.InstructionsTextBox = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TrailersListBox = New System.Windows.Forms.ListBox
        Me.CarrierComboBox = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.StandardPriorityRadioButton = New System.Windows.Forms.RadioButton
        Me.HighPriorityRadioButton = New System.Windows.Forms.RadioButton
        Me.BasicTaskGroupBox = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.BasicStandardRadioButton = New System.Windows.Forms.RadioButton
        Me.BasicHighRadioButton = New System.Windows.Forms.RadioButton
        Me.CancelBasicTaskButton = New System.Windows.Forms.Button
        Me.SaveBasicTaskButton = New System.Windows.Forms.Button
        Me.BasicInstructionsTextBox = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.StartGroupBox.SuspendLayout()
        CType(Me.TaskPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PreLoadPalletsGroupBox.SuspendLayout()
        Me.PalletsNeededGroupBox.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.BasicTaskGroupBox.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'StartGroupBox
        '
        Me.StartGroupBox.Controls.Add(Me.TaskDescriptionLabel)
        Me.StartGroupBox.Controls.Add(Me.TaskPictureBox)
        Me.StartGroupBox.Controls.Add(Me.MyCancelButton)
        Me.StartGroupBox.Controls.Add(Me.BasicTaskButton)
        Me.StartGroupBox.Controls.Add(Me.PreLoadPalletsButton)
        Me.StartGroupBox.Location = New System.Drawing.Point(12, 12)
        Me.StartGroupBox.Name = "StartGroupBox"
        Me.StartGroupBox.Size = New System.Drawing.Size(684, 404)
        Me.StartGroupBox.TabIndex = 0
        Me.StartGroupBox.TabStop = False
        '
        'TaskDescriptionLabel
        '
        Me.TaskDescriptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TaskDescriptionLabel.Location = New System.Drawing.Point(394, 198)
        Me.TaskDescriptionLabel.Name = "TaskDescriptionLabel"
        Me.TaskDescriptionLabel.Size = New System.Drawing.Size(269, 130)
        Me.TaskDescriptionLabel.TabIndex = 4
        Me.TaskDescriptionLabel.Text = "Label1"
        '
        'TaskPictureBox
        '
        Me.TaskPictureBox.BackColor = System.Drawing.Color.White
        Me.TaskPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TaskPictureBox.Location = New System.Drawing.Point(434, 48)
        Me.TaskPictureBox.Name = "TaskPictureBox"
        Me.TaskPictureBox.Size = New System.Drawing.Size(190, 123)
        Me.TaskPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.TaskPictureBox.TabIndex = 3
        Me.TaskPictureBox.TabStop = False
        '
        'MyCancelButton
        '
        Me.MyCancelButton.Location = New System.Drawing.Point(39, 275)
        Me.MyCancelButton.Name = "MyCancelButton"
        Me.MyCancelButton.Size = New System.Drawing.Size(240, 53)
        Me.MyCancelButton.TabIndex = 2
        Me.MyCancelButton.Text = "Cancel"
        Me.MyCancelButton.UseVisualStyleBackColor = True
        '
        'BasicTaskButton
        '
        Me.BasicTaskButton.Location = New System.Drawing.Point(39, 48)
        Me.BasicTaskButton.Name = "BasicTaskButton"
        Me.BasicTaskButton.Size = New System.Drawing.Size(240, 53)
        Me.BasicTaskButton.TabIndex = 1
        Me.BasicTaskButton.Text = "General Task"
        Me.BasicTaskButton.UseVisualStyleBackColor = True
        '
        'PreLoadPalletsButton
        '
        Me.PreLoadPalletsButton.Location = New System.Drawing.Point(39, 107)
        Me.PreLoadPalletsButton.Name = "PreLoadPalletsButton"
        Me.PreLoadPalletsButton.Size = New System.Drawing.Size(240, 53)
        Me.PreLoadPalletsButton.TabIndex = 0
        Me.PreLoadPalletsButton.Text = "Pre-Load Pallets"
        Me.PreLoadPalletsButton.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Basic")
        Me.ImageList1.Images.SetKeyName(1, "Pallet")
        '
        'PreLoadPalletsGroupBox
        '
        Me.PreLoadPalletsGroupBox.Controls.Add(Me.CancelPalletTaskButton)
        Me.PreLoadPalletsGroupBox.Controls.Add(Me.SavePalletTaskButton)
        Me.PreLoadPalletsGroupBox.Controls.Add(Me.PalletsNeededGroupBox)
        Me.PreLoadPalletsGroupBox.Controls.Add(Me.InstructionsTextBox)
        Me.PreLoadPalletsGroupBox.Controls.Add(Me.Label2)
        Me.PreLoadPalletsGroupBox.Controls.Add(Me.Label1)
        Me.PreLoadPalletsGroupBox.Controls.Add(Me.TrailersListBox)
        Me.PreLoadPalletsGroupBox.Controls.Add(Me.CarrierComboBox)
        Me.PreLoadPalletsGroupBox.Controls.Add(Me.GroupBox1)
        Me.PreLoadPalletsGroupBox.Location = New System.Drawing.Point(12, 12)
        Me.PreLoadPalletsGroupBox.Name = "PreLoadPalletsGroupBox"
        Me.PreLoadPalletsGroupBox.Size = New System.Drawing.Size(684, 404)
        Me.PreLoadPalletsGroupBox.TabIndex = 1
        Me.PreLoadPalletsGroupBox.TabStop = False
        Me.PreLoadPalletsGroupBox.Text = "Pre-Load Pallets"
        '
        'CancelPalletTaskButton
        '
        Me.CancelPalletTaskButton.Location = New System.Drawing.Point(449, 356)
        Me.CancelPalletTaskButton.Name = "CancelPalletTaskButton"
        Me.CancelPalletTaskButton.Size = New System.Drawing.Size(110, 38)
        Me.CancelPalletTaskButton.TabIndex = 7
        Me.CancelPalletTaskButton.Text = "Cancel"
        Me.CancelPalletTaskButton.UseVisualStyleBackColor = True
        '
        'SavePalletTaskButton
        '
        Me.SavePalletTaskButton.Location = New System.Drawing.Point(565, 356)
        Me.SavePalletTaskButton.Name = "SavePalletTaskButton"
        Me.SavePalletTaskButton.Size = New System.Drawing.Size(113, 38)
        Me.SavePalletTaskButton.TabIndex = 6
        Me.SavePalletTaskButton.Text = "Save"
        Me.SavePalletTaskButton.UseVisualStyleBackColor = True
        '
        'PalletsNeededGroupBox
        '
        Me.PalletsNeededGroupBox.Controls.Add(Me.WhitePalletsRadioButton)
        Me.PalletsNeededGroupBox.Controls.Add(Me.ChepRadioButton)
        Me.PalletsNeededGroupBox.Controls.Add(Me.HeatTreatedRadioButton)
        Me.PalletsNeededGroupBox.Location = New System.Drawing.Point(173, 233)
        Me.PalletsNeededGroupBox.Name = "PalletsNeededGroupBox"
        Me.PalletsNeededGroupBox.Size = New System.Drawing.Size(241, 117)
        Me.PalletsNeededGroupBox.TabIndex = 5
        Me.PalletsNeededGroupBox.TabStop = False
        Me.PalletsNeededGroupBox.Text = "Pallets Needed"
        '
        'WhitePalletsRadioButton
        '
        Me.WhitePalletsRadioButton.AutoSize = True
        Me.WhitePalletsRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhitePalletsRadioButton.Location = New System.Drawing.Point(52, 79)
        Me.WhitePalletsRadioButton.Name = "WhitePalletsRadioButton"
        Me.WhitePalletsRadioButton.Size = New System.Drawing.Size(73, 24)
        Me.WhitePalletsRadioButton.TabIndex = 2
        Me.WhitePalletsRadioButton.Text = "White"
        Me.WhitePalletsRadioButton.UseVisualStyleBackColor = True
        '
        'ChepRadioButton
        '
        Me.ChepRadioButton.AutoSize = True
        Me.ChepRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChepRadioButton.Location = New System.Drawing.Point(52, 49)
        Me.ChepRadioButton.Name = "ChepRadioButton"
        Me.ChepRadioButton.Size = New System.Drawing.Size(69, 24)
        Me.ChepRadioButton.TabIndex = 1
        Me.ChepRadioButton.Text = "Chep"
        Me.ChepRadioButton.UseVisualStyleBackColor = True
        '
        'HeatTreatedRadioButton
        '
        Me.HeatTreatedRadioButton.AutoSize = True
        Me.HeatTreatedRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HeatTreatedRadioButton.Location = New System.Drawing.Point(52, 19)
        Me.HeatTreatedRadioButton.Name = "HeatTreatedRadioButton"
        Me.HeatTreatedRadioButton.Size = New System.Drawing.Size(133, 24)
        Me.HeatTreatedRadioButton.TabIndex = 0
        Me.HeatTreatedRadioButton.Text = "Heat Treated"
        Me.HeatTreatedRadioButton.UseVisualStyleBackColor = True
        '
        'InstructionsTextBox
        '
        Me.InstructionsTextBox.Location = New System.Drawing.Point(173, 81)
        Me.InstructionsTextBox.Multiline = True
        Me.InstructionsTextBox.Name = "InstructionsTextBox"
        Me.InstructionsTextBox.Size = New System.Drawing.Size(505, 136)
        Me.InstructionsTextBox.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(170, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Specific Instructions"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Select Carrier"
        '
        'TrailersListBox
        '
        Me.TrailersListBox.FormattingEnabled = True
        Me.TrailersListBox.Location = New System.Drawing.Point(6, 65)
        Me.TrailersListBox.Name = "TrailersListBox"
        Me.TrailersListBox.Size = New System.Drawing.Size(148, 329)
        Me.TrailersListBox.Sorted = True
        Me.TrailersListBox.TabIndex = 1
        '
        'CarrierComboBox
        '
        Me.CarrierComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CarrierComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CarrierComboBox.FormattingEnabled = True
        Me.CarrierComboBox.Location = New System.Drawing.Point(6, 34)
        Me.CarrierComboBox.Name = "CarrierComboBox"
        Me.CarrierComboBox.Size = New System.Drawing.Size(672, 21)
        Me.CarrierComboBox.Sorted = True
        Me.CarrierComboBox.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.StandardPriorityRadioButton)
        Me.GroupBox1.Controls.Add(Me.HighPriorityRadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(420, 233)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(258, 117)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Priority Level"
        '
        'StandardPriorityRadioButton
        '
        Me.StandardPriorityRadioButton.AutoSize = True
        Me.StandardPriorityRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StandardPriorityRadioButton.ForeColor = System.Drawing.Color.RoyalBlue
        Me.StandardPriorityRadioButton.Location = New System.Drawing.Point(63, 63)
        Me.StandardPriorityRadioButton.Name = "StandardPriorityRadioButton"
        Me.StandardPriorityRadioButton.Size = New System.Drawing.Size(161, 24)
        Me.StandardPriorityRadioButton.TabIndex = 2
        Me.StandardPriorityRadioButton.Text = "Standard Priority"
        Me.StandardPriorityRadioButton.UseVisualStyleBackColor = True
        '
        'HighPriorityRadioButton
        '
        Me.HighPriorityRadioButton.AutoSize = True
        Me.HighPriorityRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HighPriorityRadioButton.ForeColor = System.Drawing.Color.Red
        Me.HighPriorityRadioButton.Location = New System.Drawing.Point(63, 33)
        Me.HighPriorityRadioButton.Name = "HighPriorityRadioButton"
        Me.HighPriorityRadioButton.Size = New System.Drawing.Size(124, 24)
        Me.HighPriorityRadioButton.TabIndex = 1
        Me.HighPriorityRadioButton.Text = "High Priority"
        Me.HighPriorityRadioButton.UseVisualStyleBackColor = True
        '
        'BasicTaskGroupBox
        '
        Me.BasicTaskGroupBox.Controls.Add(Me.GroupBox2)
        Me.BasicTaskGroupBox.Controls.Add(Me.CancelBasicTaskButton)
        Me.BasicTaskGroupBox.Controls.Add(Me.SaveBasicTaskButton)
        Me.BasicTaskGroupBox.Controls.Add(Me.BasicInstructionsTextBox)
        Me.BasicTaskGroupBox.Controls.Add(Me.Label3)
        Me.BasicTaskGroupBox.Location = New System.Drawing.Point(12, 12)
        Me.BasicTaskGroupBox.Name = "BasicTaskGroupBox"
        Me.BasicTaskGroupBox.Size = New System.Drawing.Size(684, 404)
        Me.BasicTaskGroupBox.TabIndex = 2
        Me.BasicTaskGroupBox.TabStop = False
        Me.BasicTaskGroupBox.Text = "Basic Task"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BasicStandardRadioButton)
        Me.GroupBox2.Controls.Add(Me.BasicHighRadioButton)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 275)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(258, 117)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Priority Level"
        '
        'BasicStandardRadioButton
        '
        Me.BasicStandardRadioButton.AutoSize = True
        Me.BasicStandardRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicStandardRadioButton.ForeColor = System.Drawing.Color.RoyalBlue
        Me.BasicStandardRadioButton.Location = New System.Drawing.Point(63, 63)
        Me.BasicStandardRadioButton.Name = "BasicStandardRadioButton"
        Me.BasicStandardRadioButton.Size = New System.Drawing.Size(161, 24)
        Me.BasicStandardRadioButton.TabIndex = 2
        Me.BasicStandardRadioButton.Text = "Standard Priority"
        Me.BasicStandardRadioButton.UseVisualStyleBackColor = True
        '
        'BasicHighRadioButton
        '
        Me.BasicHighRadioButton.AutoSize = True
        Me.BasicHighRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicHighRadioButton.ForeColor = System.Drawing.Color.Red
        Me.BasicHighRadioButton.Location = New System.Drawing.Point(63, 33)
        Me.BasicHighRadioButton.Name = "BasicHighRadioButton"
        Me.BasicHighRadioButton.Size = New System.Drawing.Size(124, 24)
        Me.BasicHighRadioButton.TabIndex = 1
        Me.BasicHighRadioButton.Text = "High Priority"
        Me.BasicHighRadioButton.UseVisualStyleBackColor = True
        '
        'CancelBasicTaskButton
        '
        Me.CancelBasicTaskButton.Location = New System.Drawing.Point(418, 356)
        Me.CancelBasicTaskButton.Name = "CancelBasicTaskButton"
        Me.CancelBasicTaskButton.Size = New System.Drawing.Size(127, 42)
        Me.CancelBasicTaskButton.TabIndex = 3
        Me.CancelBasicTaskButton.Text = "Cancel"
        Me.CancelBasicTaskButton.UseVisualStyleBackColor = True
        '
        'SaveBasicTaskButton
        '
        Me.SaveBasicTaskButton.Location = New System.Drawing.Point(551, 356)
        Me.SaveBasicTaskButton.Name = "SaveBasicTaskButton"
        Me.SaveBasicTaskButton.Size = New System.Drawing.Size(127, 42)
        Me.SaveBasicTaskButton.TabIndex = 2
        Me.SaveBasicTaskButton.Text = "Save"
        Me.SaveBasicTaskButton.UseVisualStyleBackColor = True
        '
        'BasicInstructionsTextBox
        '
        Me.BasicInstructionsTextBox.Location = New System.Drawing.Point(9, 34)
        Me.BasicInstructionsTextBox.MaxLength = 300
        Me.BasicInstructionsTextBox.Multiline = True
        Me.BasicInstructionsTextBox.Name = "BasicInstructionsTextBox"
        Me.BasicInstructionsTextBox.Size = New System.Drawing.Size(669, 235)
        Me.BasicInstructionsTextBox.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Task Instructions"
        '
        'TaskRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(708, 428)
        Me.Controls.Add(Me.StartGroupBox)
        Me.Controls.Add(Me.PreLoadPalletsGroupBox)
        Me.Controls.Add(Me.BasicTaskGroupBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TaskRequest"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Task Request"
        Me.StartGroupBox.ResumeLayout(False)
        CType(Me.TaskPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PreLoadPalletsGroupBox.ResumeLayout(False)
        Me.PreLoadPalletsGroupBox.PerformLayout()
        Me.PalletsNeededGroupBox.ResumeLayout(False)
        Me.PalletsNeededGroupBox.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.BasicTaskGroupBox.ResumeLayout(False)
        Me.BasicTaskGroupBox.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents StartGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents MyCancelButton As System.Windows.Forms.Button
    Friend WithEvents BasicTaskButton As System.Windows.Forms.Button
    Friend WithEvents PreLoadPalletsButton As System.Windows.Forms.Button
    Friend WithEvents TaskDescriptionLabel As System.Windows.Forms.Label
    Friend WithEvents TaskPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents PreLoadPalletsGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents CarrierComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TrailersListBox As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PalletsNeededGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents InstructionsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents WhitePalletsRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents ChepRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents HeatTreatedRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents CancelPalletTaskButton As System.Windows.Forms.Button
    Friend WithEvents SavePalletTaskButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents StandardPriorityRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents HighPriorityRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents BasicTaskGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents SaveBasicTaskButton As System.Windows.Forms.Button
    Friend WithEvents BasicInstructionsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CancelBasicTaskButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BasicStandardRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents BasicHighRadioButton As System.Windows.Forms.RadioButton
End Class
