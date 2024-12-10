<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CancelPrecoolRequestForm
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
        Dim ScheduledDateTimeLabel As System.Windows.Forms.Label
        Dim TaskDetailsLabel As System.Windows.Forms.Label
        Dim AddedByLabel As System.Windows.Forms.Label
        Me.TrailerListBox = New System.Windows.Forms.ListBox
        Me.TasksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TasksDataSet = New KAR_Lot_SmartClient.karservices.cactus.smartclient.TasksDataSet
        Me.CarrierLabel1 = New System.Windows.Forms.Label
        Me.ScheduledDateTimeLabel1 = New System.Windows.Forms.Label
        Me.TaskDetailsLabel1 = New System.Windows.Forms.Label
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.AddedByLabel1 = New System.Windows.Forms.Label
        Me.MyOKButton = New System.Windows.Forms.Button
        Me.CancelRequestVerifyCheckBox = New System.Windows.Forms.CheckBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        ScheduledDateTimeLabel = New System.Windows.Forms.Label
        TaskDetailsLabel = New System.Windows.Forms.Label
        AddedByLabel = New System.Windows.Forms.Label
        CType(Me.TasksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TasksDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ScheduledDateTimeLabel
        '
        ScheduledDateTimeLabel.AutoSize = True
        ScheduledDateTimeLabel.Location = New System.Drawing.Point(120, 55)
        ScheduledDateTimeLabel.Name = "ScheduledDateTimeLabel"
        ScheduledDateTimeLabel.Size = New System.Drawing.Size(113, 13)
        ScheduledDateTimeLabel.TabIndex = 4
        ScheduledDateTimeLabel.Text = "Scheduled Date Time:"
        '
        'TaskDetailsLabel
        '
        TaskDetailsLabel.AutoSize = True
        TaskDetailsLabel.Location = New System.Drawing.Point(120, 103)
        TaskDetailsLabel.Name = "TaskDetailsLabel"
        TaskDetailsLabel.Size = New System.Drawing.Size(69, 13)
        TaskDetailsLabel.TabIndex = 6
        TaskDetailsLabel.Text = "Task Details:"
        '
        'AddedByLabel
        '
        AddedByLabel.AutoSize = True
        AddedByLabel.Location = New System.Drawing.Point(122, 182)
        AddedByLabel.Name = "AddedByLabel"
        AddedByLabel.Size = New System.Drawing.Size(56, 13)
        AddedByLabel.TabIndex = 8
        AddedByLabel.Text = "Added By:"
        '
        'TrailerListBox
        '
        Me.TrailerListBox.DataSource = Me.TasksBindingSource
        Me.TrailerListBox.DisplayMember = "TrailerID"
        Me.TrailerListBox.Dock = System.Windows.Forms.DockStyle.Left
        Me.TrailerListBox.FormattingEnabled = True
        Me.TrailerListBox.Location = New System.Drawing.Point(0, 0)
        Me.TrailerListBox.Name = "TrailerListBox"
        Me.TrailerListBox.Size = New System.Drawing.Size(112, 264)
        Me.TrailerListBox.TabIndex = 0
        Me.TrailerListBox.ValueMember = "TaskID"
        '
        'TasksBindingSource
        '
        Me.TasksBindingSource.DataMember = "Tasks"
        Me.TasksBindingSource.DataSource = Me.TasksDataSet
        '
        'TasksDataSet
        '
        Me.TasksDataSet.DataSetName = "TasksDataSet"
        Me.TasksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CarrierLabel1
        '
        Me.CarrierLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TasksBindingSource, "Carrier", True))
        Me.CarrierLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CarrierLabel1.Location = New System.Drawing.Point(118, 9)
        Me.CarrierLabel1.Name = "CarrierLabel1"
        Me.CarrierLabel1.Size = New System.Drawing.Size(471, 37)
        Me.CarrierLabel1.TabIndex = 3
        '
        'ScheduledDateTimeLabel1
        '
        Me.ScheduledDateTimeLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ScheduledDateTimeLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TasksBindingSource, "ScheduledDateTime", True))
        Me.ScheduledDateTimeLabel1.Location = New System.Drawing.Point(122, 68)
        Me.ScheduledDateTimeLabel1.Name = "ScheduledDateTimeLabel1"
        Me.ScheduledDateTimeLabel1.Size = New System.Drawing.Size(498, 23)
        Me.ScheduledDateTimeLabel1.TabIndex = 5
        Me.ScheduledDateTimeLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TaskDetailsLabel1
        '
        Me.TaskDetailsLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TaskDetailsLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TasksBindingSource, "TaskDetails", True))
        Me.TaskDetailsLabel1.Location = New System.Drawing.Point(122, 116)
        Me.TaskDetailsLabel1.Name = "TaskDetailsLabel1"
        Me.TaskDetailsLabel1.Size = New System.Drawing.Size(498, 66)
        Me.TaskDetailsLabel1.TabIndex = 7
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(112, 243)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(522, 22)
        Me.StatusStrip1.TabIndex = 8
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'AddedByLabel1
        '
        Me.AddedByLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AddedByLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TasksBindingSource, "AddedBy", True))
        Me.AddedByLabel1.Location = New System.Drawing.Point(122, 195)
        Me.AddedByLabel1.Name = "AddedByLabel1"
        Me.AddedByLabel1.Size = New System.Drawing.Size(169, 23)
        Me.AddedByLabel1.TabIndex = 9
        Me.AddedByLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MyOKButton
        '
        Me.MyOKButton.Location = New System.Drawing.Point(495, 195)
        Me.MyOKButton.Name = "MyOKButton"
        Me.MyOKButton.Size = New System.Drawing.Size(125, 34)
        Me.MyOKButton.TabIndex = 10
        Me.MyOKButton.Text = "OK"
        Me.MyOKButton.UseVisualStyleBackColor = True
        '
        'CancelRequestVerifyCheckBox
        '
        Me.CancelRequestVerifyCheckBox.ForeColor = System.Drawing.Color.Red
        Me.CancelRequestVerifyCheckBox.Location = New System.Drawing.Point(341, 185)
        Me.CancelRequestVerifyCheckBox.Name = "CancelRequestVerifyCheckBox"
        Me.CancelRequestVerifyCheckBox.Size = New System.Drawing.Size(118, 46)
        Me.CancelRequestVerifyCheckBox.TabIndex = 11
        Me.CancelRequestVerifyCheckBox.Text = "Yes, I want to cancel this request"
        Me.CancelRequestVerifyCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CancelRequestVerifyCheckBox.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.KAR_Lot_SmartClient.My.Resources.Resources.loader
        Me.PictureBox1.Location = New System.Drawing.Point(609, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'CancelPrecoolRequestForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 265)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CancelRequestVerifyCheckBox)
        Me.Controls.Add(Me.MyOKButton)
        Me.Controls.Add(AddedByLabel)
        Me.Controls.Add(Me.AddedByLabel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(TaskDetailsLabel)
        Me.Controls.Add(Me.TaskDetailsLabel1)
        Me.Controls.Add(ScheduledDateTimeLabel)
        Me.Controls.Add(Me.ScheduledDateTimeLabel1)
        Me.Controls.Add(Me.CarrierLabel1)
        Me.Controls.Add(Me.TrailerListBox)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CancelPrecoolRequestForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CancelPrecoolRequestForm"
        CType(Me.TasksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TasksDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TrailerListBox As System.Windows.Forms.ListBox
    Friend WithEvents TasksDataSet As KAR_Lot_SmartClient.karservices.cactus.smartclient.TasksDataSet
    Friend WithEvents TasksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CarrierLabel1 As System.Windows.Forms.Label
    Friend WithEvents ScheduledDateTimeLabel1 As System.Windows.Forms.Label
    Friend WithEvents TaskDetailsLabel1 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents AddedByLabel1 As System.Windows.Forms.Label
    Friend WithEvents MyOKButton As System.Windows.Forms.Button
    Friend WithEvents CancelRequestVerifyCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
