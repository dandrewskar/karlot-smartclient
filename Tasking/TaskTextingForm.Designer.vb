Imports KarLot
Imports KarLot.Tasking

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TaskTextingForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TaskTextingForm))
        Me.Wizard1 = New Gui.Wizard.Wizard
        Me.SelectTask = New Gui.Wizard.WizardPage
        Me.TaskTextFlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel
        Me.BuildMessage = New Gui.Wizard.WizardPage
        Me.KlTaskTextView1 = New KarLot.Tasking.klTaskTextView
        Me.BuildMessageInstructionLabel = New System.Windows.Forms.Label
        Me.TaskSaved = New Gui.Wizard.WizardPage
        Me.ResultMessageFriendlyLabel = New System.Windows.Forms.Label
        Me.ResultMessageDetailsLabel = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.Wizard1.SuspendLayout()
        Me.SelectTask.SuspendLayout()
        Me.BuildMessage.SuspendLayout()
        Me.TaskSaved.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Wizard1
        '
        Me.Wizard1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Wizard1.Controls.Add(Me.TaskSaved)
        Me.Wizard1.Controls.Add(Me.BuildMessage)
        Me.Wizard1.Controls.Add(Me.SelectTask)
        Me.Wizard1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Wizard1.Location = New System.Drawing.Point(12, 12)
        Me.Wizard1.Name = "Wizard1"
        Me.Wizard1.Pages.AddRange(New Gui.Wizard.WizardPage() {Me.SelectTask, Me.BuildMessage, Me.TaskSaved})
        Me.Wizard1.Size = New System.Drawing.Size(674, 394)
        Me.Wizard1.TabIndex = 0
        '
        'SelectTask
        '
        Me.SelectTask.Controls.Add(Me.TaskTextFlowLayoutPanel)
        Me.SelectTask.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SelectTask.IsFinishPage = False
        Me.SelectTask.Location = New System.Drawing.Point(0, 0)
        Me.SelectTask.Name = "SelectTask"
        Me.SelectTask.Size = New System.Drawing.Size(674, 346)
        Me.SelectTask.TabIndex = 4
        '
        'TaskTextFlowLayoutPanel
        '
        Me.TaskTextFlowLayoutPanel.Location = New System.Drawing.Point(169, 80)
        Me.TaskTextFlowLayoutPanel.Name = "TaskTextFlowLayoutPanel"
        Me.TaskTextFlowLayoutPanel.Size = New System.Drawing.Size(287, 176)
        Me.TaskTextFlowLayoutPanel.TabIndex = 0
        '
        'BuildMessage
        '
        Me.BuildMessage.Controls.Add(Me.KlTaskTextView1)
        Me.BuildMessage.Controls.Add(Me.BuildMessageInstructionLabel)
        Me.BuildMessage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BuildMessage.IsFinishPage = False
        Me.BuildMessage.Location = New System.Drawing.Point(0, 0)
        Me.BuildMessage.Name = "BuildMessage"
        Me.BuildMessage.Size = New System.Drawing.Size(674, 346)
        Me.BuildMessage.TabIndex = 2
        '
        'KlTaskTextView1
        '
        Me.KlTaskTextView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KlTaskTextView1.Location = New System.Drawing.Point(0, 0)
        Me.KlTaskTextView1.Name = "KlTaskTextView1"
        Me.KlTaskTextView1.Size = New System.Drawing.Size(674, 250)
        Me.KlTaskTextView1.TabIndex = 2
        '
        'BuildMessageInstructionLabel
        '
        Me.BuildMessageInstructionLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BuildMessageInstructionLabel.Location = New System.Drawing.Point(34, 253)
        Me.BuildMessageInstructionLabel.Name = "BuildMessageInstructionLabel"
        Me.BuildMessageInstructionLabel.Size = New System.Drawing.Size(608, 81)
        Me.BuildMessageInstructionLabel.TabIndex = 1
        Me.BuildMessageInstructionLabel.Text = resources.GetString("BuildMessageInstructionLabel.Text")
        '
        'TaskSaved
        '
        Me.TaskSaved.Controls.Add(Me.Panel1)
        Me.TaskSaved.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TaskSaved.IsFinishPage = True
        Me.TaskSaved.Location = New System.Drawing.Point(0, 0)
        Me.TaskSaved.Name = "TaskSaved"
        Me.TaskSaved.Size = New System.Drawing.Size(674, 346)
        Me.TaskSaved.TabIndex = 3
        '
        'ResultMessageFriendlyLabel
        '
        Me.ResultMessageFriendlyLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ResultMessageFriendlyLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ResultMessageFriendlyLabel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResultMessageFriendlyLabel.Location = New System.Drawing.Point(37, 83)
        Me.ResultMessageFriendlyLabel.Name = "ResultMessageFriendlyLabel"
        Me.ResultMessageFriendlyLabel.Size = New System.Drawing.Size(594, 82)
        Me.ResultMessageFriendlyLabel.TabIndex = 1
        '
        'ResultMessageDetailsLabel
        '
        Me.ResultMessageDetailsLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ResultMessageDetailsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ResultMessageDetailsLabel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResultMessageDetailsLabel.ForeColor = System.Drawing.Color.Red
        Me.ResultMessageDetailsLabel.Location = New System.Drawing.Point(37, 178)
        Me.ResultMessageDetailsLabel.Name = "ResultMessageDetailsLabel"
        Me.ResultMessageDetailsLabel.Size = New System.Drawing.Size(594, 138)
        Me.ResultMessageDetailsLabel.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.ProgressBar1)
        Me.Panel1.Controls.Add(Me.ResultMessageFriendlyLabel)
        Me.Panel1.Controls.Add(Me.ResultMessageDetailsLabel)
        Me.Panel1.Location = New System.Drawing.Point(0, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(671, 335)
        Me.Panel1.TabIndex = 2
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(37, 37)
        Me.ProgressBar1.MarqueeAnimationSpeed = 1500
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(594, 23)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgressBar1.TabIndex = 2
        '
        'TaskTextingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 418)
        Me.Controls.Add(Me.Wizard1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TaskTextingForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kar Lot Tasks"
        Me.Wizard1.ResumeLayout(False)
        Me.SelectTask.ResumeLayout(False)
        Me.BuildMessage.ResumeLayout(False)
        Me.TaskSaved.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Wizard1 As Gui.Wizard.Wizard
    Friend WithEvents BuildMessage As Gui.Wizard.WizardPage
    Friend WithEvents TaskSaved As Gui.Wizard.WizardPage
    Friend WithEvents BuildMessageInstructionLabel As System.Windows.Forms.Label
    Friend WithEvents ResultMessageFriendlyLabel As System.Windows.Forms.Label
    Friend WithEvents ResultMessageDetailsLabel As System.Windows.Forms.Label
    Friend WithEvents SelectTask As Gui.Wizard.WizardPage
    Friend WithEvents TaskTextFlowLayoutPanel As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents KlTaskTextView1 As Tasking.klTaskTextView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
End Class
