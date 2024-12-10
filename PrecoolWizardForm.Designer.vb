<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrecoolWizardForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrecoolWizardForm))
        Me.StartPanel1 = New System.Windows.Forms.Panel
        Me.TempTypeComboBox = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.StartInstructionsTextBox = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.StartMinuteComboBox = New System.Windows.Forms.ComboBox
        Me.StartHourComboBox = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.StartDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.StartSetPointTextBox = New System.Windows.Forms.TextBox
        Me.Start1CancelButton = New System.Windows.Forms.Button
        Me.Start1NextButton = New System.Windows.Forms.Button
        Me.CarrierNameLabel = New System.Windows.Forms.Label
        Me.TrailerIDLabel = New System.Windows.Forms.Label
        Me.StartPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StartPanel1
        '
        Me.StartPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StartPanel1.BackColor = System.Drawing.Color.White
        Me.StartPanel1.Controls.Add(Me.TempTypeComboBox)
        Me.StartPanel1.Controls.Add(Me.Label5)
        Me.StartPanel1.Controls.Add(Me.StartInstructionsTextBox)
        Me.StartPanel1.Controls.Add(Me.PictureBox1)
        Me.StartPanel1.Controls.Add(Me.Label4)
        Me.StartPanel1.Controls.Add(Me.StartMinuteComboBox)
        Me.StartPanel1.Controls.Add(Me.StartHourComboBox)
        Me.StartPanel1.Controls.Add(Me.Label3)
        Me.StartPanel1.Controls.Add(Me.StartDateTimePicker)
        Me.StartPanel1.Controls.Add(Me.Label2)
        Me.StartPanel1.Controls.Add(Me.Label1)
        Me.StartPanel1.Controls.Add(Me.StartSetPointTextBox)
        Me.StartPanel1.Controls.Add(Me.Start1CancelButton)
        Me.StartPanel1.Controls.Add(Me.Start1NextButton)
        Me.StartPanel1.Controls.Add(Me.CarrierNameLabel)
        Me.StartPanel1.Controls.Add(Me.TrailerIDLabel)
        Me.StartPanel1.Location = New System.Drawing.Point(12, 12)
        Me.StartPanel1.Name = "StartPanel1"
        Me.StartPanel1.Size = New System.Drawing.Size(470, 219)
        Me.StartPanel1.TabIndex = 0
        '
        'TempTypeComboBox
        '
        Me.TempTypeComboBox.FormattingEnabled = True
        Me.TempTypeComboBox.Items.AddRange(New Object() {"F", "C"})
        Me.TempTypeComboBox.Location = New System.Drawing.Point(326, 78)
        Me.TempTypeComboBox.Name = "TempTypeComboBox"
        Me.TempTypeComboBox.Size = New System.Drawing.Size(60, 21)
        Me.TempTypeComboBox.TabIndex = 17
        Me.TempTypeComboBox.Text = "F"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Other Instructions:"
        '
        'StartInstructionsTextBox
        '
        Me.StartInstructionsTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StartInstructionsTextBox.Location = New System.Drawing.Point(16, 117)
        Me.StartInstructionsTextBox.MaxLength = 200
        Me.StartInstructionsTextBox.Multiline = True
        Me.StartInstructionsTextBox.Name = "StartInstructionsTextBox"
        Me.StartInstructionsTextBox.Size = New System.Drawing.Size(440, 70)
        Me.StartInstructionsTextBox.TabIndex = 13
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(392, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 95)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(3, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(385, 1)
        Me.Label4.TabIndex = 11
        '
        'StartMinuteComboBox
        '
        Me.StartMinuteComboBox.FormattingEnabled = True
        Me.StartMinuteComboBox.Items.AddRange(New Object() {"00", "15", "30", "45"})
        Me.StartMinuteComboBox.Location = New System.Drawing.Point(194, 77)
        Me.StartMinuteComboBox.Name = "StartMinuteComboBox"
        Me.StartMinuteComboBox.Size = New System.Drawing.Size(56, 21)
        Me.StartMinuteComboBox.TabIndex = 10
        '
        'StartHourComboBox
        '
        Me.StartHourComboBox.FormattingEnabled = True
        Me.StartHourComboBox.Items.AddRange(New Object() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23"})
        Me.StartHourComboBox.Location = New System.Drawing.Point(137, 77)
        Me.StartHourComboBox.Name = "StartHourComboBox"
        Me.StartHourComboBox.Size = New System.Drawing.Size(55, 21)
        Me.StartHourComboBox.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(134, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Start Time:"
        '
        'StartDateTimePicker
        '
        Me.StartDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.StartDateTimePicker.Location = New System.Drawing.Point(18, 78)
        Me.StartDateTimePicker.Name = "StartDateTimePicker"
        Me.StartDateTimePicker.Size = New System.Drawing.Size(106, 20)
        Me.StartDateTimePicker.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Start Date:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(263, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Set Point:"
        '
        'StartSetPointTextBox
        '
        Me.StartSetPointTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartSetPointTextBox.ForeColor = System.Drawing.Color.Red
        Me.StartSetPointTextBox.Location = New System.Drawing.Point(266, 78)
        Me.StartSetPointTextBox.MaxLength = 5
        Me.StartSetPointTextBox.Name = "StartSetPointTextBox"
        Me.StartSetPointTextBox.Size = New System.Drawing.Size(53, 20)
        Me.StartSetPointTextBox.TabIndex = 4
        '
        'Start1CancelButton
        '
        Me.Start1CancelButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Start1CancelButton.Location = New System.Drawing.Point(313, 193)
        Me.Start1CancelButton.Name = "Start1CancelButton"
        Me.Start1CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.Start1CancelButton.TabIndex = 2
        Me.Start1CancelButton.Text = "Cancel"
        Me.Start1CancelButton.UseVisualStyleBackColor = True
        '
        'Start1NextButton
        '
        Me.Start1NextButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Start1NextButton.Location = New System.Drawing.Point(392, 193)
        Me.Start1NextButton.Name = "Start1NextButton"
        Me.Start1NextButton.Size = New System.Drawing.Size(75, 23)
        Me.Start1NextButton.TabIndex = 1
        Me.Start1NextButton.Text = "Save"
        Me.Start1NextButton.UseVisualStyleBackColor = True
        '
        'CarrierNameLabel
        '
        Me.CarrierNameLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CarrierNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CarrierNameLabel.Location = New System.Drawing.Point(3, 1)
        Me.CarrierNameLabel.Name = "CarrierNameLabel"
        Me.CarrierNameLabel.Size = New System.Drawing.Size(385, 24)
        Me.CarrierNameLabel.TabIndex = 0
        Me.CarrierNameLabel.Text = "CarrierNameLabel"
        Me.CarrierNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TrailerIDLabel
        '
        Me.TrailerIDLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TrailerIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrailerIDLabel.Location = New System.Drawing.Point(3, 19)
        Me.TrailerIDLabel.Name = "TrailerIDLabel"
        Me.TrailerIDLabel.Size = New System.Drawing.Size(385, 24)
        Me.TrailerIDLabel.TabIndex = 3
        Me.TrailerIDLabel.Text = "CarrierNameLabel"
        Me.TrailerIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PrecoolWizardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(494, 243)
        Me.Controls.Add(Me.StartPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PrecoolWizardForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KAR Lot"
        Me.StartPanel1.ResumeLayout(False)
        Me.StartPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents StartPanel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents StartSetPointTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TrailerIDLabel As System.Windows.Forms.Label
    Friend WithEvents Start1CancelButton As System.Windows.Forms.Button
    Friend WithEvents Start1NextButton As System.Windows.Forms.Button
    Friend WithEvents CarrierNameLabel As System.Windows.Forms.Label
    Friend WithEvents StartMinuteComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents StartHourComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents StartDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents StartInstructionsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TempTypeComboBox As System.Windows.Forms.ComboBox
End Class
