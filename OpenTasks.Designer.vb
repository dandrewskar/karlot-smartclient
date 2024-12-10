<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OpenTasks
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
        Dim TaskIDLabel As System.Windows.Forms.Label
        Dim TaskDetailsLabel As System.Windows.Forms.Label
        Dim AddedByLabel As System.Windows.Forms.Label
        Dim AddedTimeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OpenTasks))
        Me.ActionButton = New System.Windows.Forms.Button
        Me.CloseButton = New System.Windows.Forms.Button
        Me.TaskListView = New System.Windows.Forms.ListView
        Me.TaskType = New System.Windows.Forms.ColumnHeader
        Me.TaskImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.TaskIDTextBox = New System.Windows.Forms.TextBox
        Me.TasksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TasksDataSet = New KAR_Lot_SmartClient.karservices.cactus.smartclient.TasksDataSet
        Me.TaskDetailsTextBox = New System.Windows.Forms.TextBox
        Me.AddedByTextBox = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.PriorityLevelDisplayLabel = New System.Windows.Forms.Label
        Me.TrailerGroupBox = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.PalletTypeLabel = New System.Windows.Forms.Label
        Me.TrailerIDLabel = New System.Windows.Forms.Label
        Me.CarrierNameLabel = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        TaskIDLabel = New System.Windows.Forms.Label
        TaskDetailsLabel = New System.Windows.Forms.Label
        AddedByLabel = New System.Windows.Forms.Label
        AddedTimeLabel = New System.Windows.Forms.Label
        CType(Me.TasksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TasksDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TrailerGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'TaskIDLabel
        '
        TaskIDLabel.AutoSize = True
        TaskIDLabel.Location = New System.Drawing.Point(126, 403)
        TaskIDLabel.Name = "TaskIDLabel"
        TaskIDLabel.Size = New System.Drawing.Size(48, 13)
        TaskIDLabel.TabIndex = 4
        TaskIDLabel.Text = "Task ID:"
        '
        'TaskDetailsLabel
        '
        TaskDetailsLabel.AutoSize = True
        TaskDetailsLabel.Location = New System.Drawing.Point(129, 37)
        TaskDetailsLabel.Name = "TaskDetailsLabel"
        TaskDetailsLabel.Size = New System.Drawing.Size(69, 13)
        TaskDetailsLabel.TabIndex = 8
        TaskDetailsLabel.Text = "Task Details:"
        '
        'AddedByLabel
        '
        AddedByLabel.AutoSize = True
        AddedByLabel.Location = New System.Drawing.Point(129, 202)
        AddedByLabel.Name = "AddedByLabel"
        AddedByLabel.Size = New System.Drawing.Size(77, 13)
        AddedByLabel.TabIndex = 20
        AddedByLabel.Text = "Requested By:"
        '
        'AddedTimeLabel
        '
        AddedTimeLabel.AutoSize = True
        AddedTimeLabel.Location = New System.Drawing.Point(339, 202)
        AddedTimeLabel.Name = "AddedTimeLabel"
        AddedTimeLabel.Size = New System.Drawing.Size(62, 13)
        AddedTimeLabel.TabIndex = 22
        AddedTimeLabel.Text = "Requested:"
        '
        'ActionButton
        '
        Me.ActionButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActionButton.Location = New System.Drawing.Point(525, 395)
        Me.ActionButton.Name = "ActionButton"
        Me.ActionButton.Size = New System.Drawing.Size(211, 53)
        Me.ActionButton.TabIndex = 2
        Me.ActionButton.Text = "TAKE TASK"
        Me.ActionButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseButton.Location = New System.Drawing.Point(361, 395)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(143, 53)
        Me.CloseButton.TabIndex = 3
        Me.CloseButton.Text = "CLOSE"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'TaskListView
        '
        Me.TaskListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.TaskType})
        Me.TaskListView.Dock = System.Windows.Forms.DockStyle.Left
        Me.TaskListView.LargeImageList = Me.TaskImageList
        Me.TaskListView.Location = New System.Drawing.Point(0, 0)
        Me.TaskListView.Name = "TaskListView"
        Me.TaskListView.Size = New System.Drawing.Size(123, 460)
        Me.TaskListView.SmallImageList = Me.TaskImageList
        Me.TaskListView.TabIndex = 4
        Me.TaskListView.UseCompatibleStateImageBehavior = False
        '
        'TaskType
        '
        Me.TaskType.Text = "Type"
        '
        'TaskImageList
        '
        Me.TaskImageList.ImageStream = CType(resources.GetObject("TaskImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.TaskImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.TaskImageList.Images.SetKeyName(0, "Pallet")
        Me.TaskImageList.Images.SetKeyName(1, "Basic")
        '
        'TaskIDTextBox
        '
        Me.TaskIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TasksBindingSource, "TaskID", True))
        Me.TaskIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TaskIDTextBox.Location = New System.Drawing.Point(129, 419)
        Me.TaskIDTextBox.Name = "TaskIDTextBox"
        Me.TaskIDTextBox.ReadOnly = True
        Me.TaskIDTextBox.Size = New System.Drawing.Size(83, 29)
        Me.TaskIDTextBox.TabIndex = 5
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
        'TaskDetailsTextBox
        '
        Me.TaskDetailsTextBox.BackColor = System.Drawing.Color.White
        Me.TaskDetailsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TasksBindingSource, "TaskDetails", True))
        Me.TaskDetailsTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TaskDetailsTextBox.Location = New System.Drawing.Point(132, 53)
        Me.TaskDetailsTextBox.Multiline = True
        Me.TaskDetailsTextBox.Name = "TaskDetailsTextBox"
        Me.TaskDetailsTextBox.ReadOnly = True
        Me.TaskDetailsTextBox.Size = New System.Drawing.Size(596, 147)
        Me.TaskDetailsTextBox.TabIndex = 9
        '
        'AddedByTextBox
        '
        Me.AddedByTextBox.BackColor = System.Drawing.Color.White
        Me.AddedByTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TasksBindingSource, "AddedBy", True))
        Me.AddedByTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddedByTextBox.Location = New System.Drawing.Point(132, 217)
        Me.AddedByTextBox.Name = "AddedByTextBox"
        Me.AddedByTextBox.ReadOnly = True
        Me.AddedByTextBox.Size = New System.Drawing.Size(200, 29)
        Me.AddedByTextBox.TabIndex = 21
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TasksBindingSource, "AddedTime", True))
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(342, 217)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(386, 29)
        Me.TextBox1.TabIndex = 23
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.PriorityLevelDisplayLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(499, 249)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(229, 141)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PRIORITY"
        '
        'PriorityLevelDisplayLabel
        '
        Me.PriorityLevelDisplayLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriorityLevelDisplayLabel.ForeColor = System.Drawing.Color.Red
        Me.PriorityLevelDisplayLabel.Location = New System.Drawing.Point(6, 50)
        Me.PriorityLevelDisplayLabel.Name = "PriorityLevelDisplayLabel"
        Me.PriorityLevelDisplayLabel.Size = New System.Drawing.Size(217, 48)
        Me.PriorityLevelDisplayLabel.TabIndex = 0
        Me.PriorityLevelDisplayLabel.Text = "REGULAR"
        Me.PriorityLevelDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TrailerGroupBox
        '
        Me.TrailerGroupBox.Controls.Add(Me.Label2)
        Me.TrailerGroupBox.Controls.Add(Me.Label1)
        Me.TrailerGroupBox.Controls.Add(Me.PalletTypeLabel)
        Me.TrailerGroupBox.Controls.Add(Me.TrailerIDLabel)
        Me.TrailerGroupBox.Controls.Add(Me.CarrierNameLabel)
        Me.TrailerGroupBox.Location = New System.Drawing.Point(129, 249)
        Me.TrailerGroupBox.Name = "TrailerGroupBox"
        Me.TrailerGroupBox.Size = New System.Drawing.Size(364, 141)
        Me.TrailerGroupBox.TabIndex = 25
        Me.TrailerGroupBox.TabStop = False
        Me.TrailerGroupBox.Text = "Trailer Information"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Location = New System.Drawing.Point(5, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Pallets Needed"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(0, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(364, 1)
        Me.Label1.TabIndex = 3
        '
        'PalletTypeLabel
        '
        Me.PalletTypeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PalletTypeLabel.Location = New System.Drawing.Point(6, 108)
        Me.PalletTypeLabel.Name = "PalletTypeLabel"
        Me.PalletTypeLabel.Size = New System.Drawing.Size(352, 25)
        Me.PalletTypeLabel.TabIndex = 2
        Me.PalletTypeLabel.Text = "PalletType"
        Me.PalletTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TrailerIDLabel
        '
        Me.TrailerIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrailerIDLabel.Location = New System.Drawing.Point(6, 57)
        Me.TrailerIDLabel.Name = "TrailerIDLabel"
        Me.TrailerIDLabel.Size = New System.Drawing.Size(352, 25)
        Me.TrailerIDLabel.TabIndex = 1
        Me.TrailerIDLabel.Text = "TrailerID"
        Me.TrailerIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CarrierNameLabel
        '
        Me.CarrierNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CarrierNameLabel.Location = New System.Drawing.Point(6, 26)
        Me.CarrierNameLabel.Name = "CarrierNameLabel"
        Me.CarrierNameLabel.Size = New System.Drawing.Size(352, 23)
        Me.CarrierNameLabel.TabIndex = 0
        Me.CarrierNameLabel.Text = "CarrierName"
        Me.CarrierNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label3.Location = New System.Drawing.Point(489, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(246, 36)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "All Open Tasks"
        '
        'OpenTasks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(748, 460)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TrailerGroupBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(TaskIDLabel)
        Me.Controls.Add(Me.TaskIDTextBox)
        Me.Controls.Add(TaskDetailsLabel)
        Me.Controls.Add(Me.TaskDetailsTextBox)
        Me.Controls.Add(AddedByLabel)
        Me.Controls.Add(Me.AddedByTextBox)
        Me.Controls.Add(AddedTimeLabel)
        Me.Controls.Add(Me.TaskListView)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.ActionButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "OpenTasks"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "All Open Tasks"
        CType(Me.TasksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TasksDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.TrailerGroupBox.ResumeLayout(False)
        Me.TrailerGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TasksDataSet As KAR_Lot_SmartClient.karservices.cactus.smartclient.TasksDataSet
    Friend WithEvents TasksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ActionButton As System.Windows.Forms.Button
    Friend WithEvents CloseButton As System.Windows.Forms.Button
    Friend WithEvents TaskListView As System.Windows.Forms.ListView
    Friend WithEvents TaskType As System.Windows.Forms.ColumnHeader
    Friend WithEvents TaskImageList As System.Windows.Forms.ImageList
    Friend WithEvents TaskIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TaskDetailsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddedByTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PriorityLevelDisplayLabel As System.Windows.Forms.Label
    Friend WithEvents TrailerGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents PalletTypeLabel As System.Windows.Forms.Label
    Friend WithEvents TrailerIDLabel As System.Windows.Forms.Label
    Friend WithEvents CarrierNameLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
