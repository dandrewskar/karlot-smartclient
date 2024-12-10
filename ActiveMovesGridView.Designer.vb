<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActiveMovesGridView
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
        Me.MovesGridView = New System.Windows.Forms.DataGridView
        Me.TrailerMoveTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MoveID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Carrier = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TrailerID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TimeCalledDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CalledByDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.StationCallingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.StartLocationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DestinationLocationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.StopOffLocationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TimeTakenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.WhosMoveDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TimePickedUpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PickedUpByDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TimeParkedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PriorityMoveDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.ParkedByDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MoveStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LoadStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TemperatureDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PalletsRequestedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PalletsOnBoardDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TrailerSystemIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TimeCancelledDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PreCoolingStartedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TimeProblemReportedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CancelledDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.CompletedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.PreCoolingDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.ProblemReportedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.ProblemReportedByDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LastActionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ActiveMoveDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.CancelledByDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LastUserDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TakenByDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ProblemTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MoveInstructionsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.MovesGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrailerMoveTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MovesGridView
        '
        Me.MovesGridView.AllowUserToAddRows = False
        Me.MovesGridView.AllowUserToDeleteRows = False
        Me.MovesGridView.AutoGenerateColumns = False
        Me.MovesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MovesGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MoveID, Me.Carrier, Me.TrailerID, Me.TimeCalledDataGridViewTextBoxColumn, Me.CalledByDataGridViewTextBoxColumn, Me.StationCallingDataGridViewTextBoxColumn, Me.StartLocationDataGridViewTextBoxColumn, Me.DestinationLocationDataGridViewTextBoxColumn, Me.StopOffLocationDataGridViewTextBoxColumn, Me.TimeTakenDataGridViewTextBoxColumn, Me.WhosMoveDataGridViewTextBoxColumn, Me.TimePickedUpDataGridViewTextBoxColumn, Me.PickedUpByDataGridViewTextBoxColumn, Me.TimeParkedDataGridViewTextBoxColumn, Me.PriorityMoveDataGridViewCheckBoxColumn, Me.ParkedByDataGridViewTextBoxColumn, Me.MoveStatusDataGridViewTextBoxColumn, Me.LoadStatusDataGridViewTextBoxColumn, Me.TemperatureDataGridViewTextBoxColumn, Me.PalletsRequestedDataGridViewTextBoxColumn, Me.PalletsOnBoardDataGridViewTextBoxColumn, Me.TrailerSystemIDDataGridViewTextBoxColumn, Me.TimeCancelledDataGridViewTextBoxColumn, Me.PreCoolingStartedDataGridViewTextBoxColumn, Me.TimeProblemReportedDataGridViewTextBoxColumn, Me.CancelledDataGridViewCheckBoxColumn, Me.CompletedDataGridViewCheckBoxColumn, Me.PreCoolingDataGridViewCheckBoxColumn, Me.ProblemReportedDataGridViewCheckBoxColumn, Me.ProblemReportedByDataGridViewTextBoxColumn, Me.LastActionDataGridViewTextBoxColumn, Me.ActiveMoveDataGridViewCheckBoxColumn, Me.CancelledByDataGridViewTextBoxColumn, Me.LastUserDataGridViewTextBoxColumn, Me.TakenByDataGridViewTextBoxColumn, Me.ProblemTypeDataGridViewTextBoxColumn, Me.MoveInstructionsDataGridViewTextBoxColumn})
        Me.MovesGridView.DataSource = Me.TrailerMoveTOBindingSource
        Me.MovesGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MovesGridView.Location = New System.Drawing.Point(0, 0)
        Me.MovesGridView.Name = "MovesGridView"
        Me.MovesGridView.ReadOnly = True
        Me.MovesGridView.Size = New System.Drawing.Size(684, 469)
        Me.MovesGridView.TabIndex = 0
        '
        'TrailerMoveTOBindingSource
        '
        Me.TrailerMoveTOBindingSource.DataSource = GetType(KAR_Lot_SmartClient.karservices.cactus.smartclient.TrailerMoveTO)
        '
        'MoveID
        '
        Me.MoveID.DataPropertyName = "MoveID"
        Me.MoveID.HeaderText = "Move ID"
        Me.MoveID.Name = "MoveID"
        Me.MoveID.ReadOnly = True
        '
        'Carrier
        '
        Me.Carrier.DataPropertyName = "Carrier"
        Me.Carrier.HeaderText = "Carrier"
        Me.Carrier.Name = "Carrier"
        Me.Carrier.ReadOnly = True
        '
        'TrailerID
        '
        Me.TrailerID.DataPropertyName = "TrailerID"
        Me.TrailerID.HeaderText = "Trailer ID"
        Me.TrailerID.Name = "TrailerID"
        Me.TrailerID.ReadOnly = True
        '
        'TimeCalledDataGridViewTextBoxColumn
        '
        Me.TimeCalledDataGridViewTextBoxColumn.DataPropertyName = "TimeCalled"
        Me.TimeCalledDataGridViewTextBoxColumn.HeaderText = "TimeCalled"
        Me.TimeCalledDataGridViewTextBoxColumn.Name = "TimeCalledDataGridViewTextBoxColumn"
        Me.TimeCalledDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CalledByDataGridViewTextBoxColumn
        '
        Me.CalledByDataGridViewTextBoxColumn.DataPropertyName = "CalledBy"
        Me.CalledByDataGridViewTextBoxColumn.HeaderText = "CalledBy"
        Me.CalledByDataGridViewTextBoxColumn.Name = "CalledByDataGridViewTextBoxColumn"
        Me.CalledByDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StationCallingDataGridViewTextBoxColumn
        '
        Me.StationCallingDataGridViewTextBoxColumn.DataPropertyName = "StationCalling"
        Me.StationCallingDataGridViewTextBoxColumn.HeaderText = "StationCalling"
        Me.StationCallingDataGridViewTextBoxColumn.Name = "StationCallingDataGridViewTextBoxColumn"
        Me.StationCallingDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StartLocationDataGridViewTextBoxColumn
        '
        Me.StartLocationDataGridViewTextBoxColumn.DataPropertyName = "StartLocation"
        Me.StartLocationDataGridViewTextBoxColumn.HeaderText = "StartLocation"
        Me.StartLocationDataGridViewTextBoxColumn.Name = "StartLocationDataGridViewTextBoxColumn"
        Me.StartLocationDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DestinationLocationDataGridViewTextBoxColumn
        '
        Me.DestinationLocationDataGridViewTextBoxColumn.DataPropertyName = "DestinationLocation"
        Me.DestinationLocationDataGridViewTextBoxColumn.HeaderText = "DestinationLocation"
        Me.DestinationLocationDataGridViewTextBoxColumn.Name = "DestinationLocationDataGridViewTextBoxColumn"
        Me.DestinationLocationDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StopOffLocationDataGridViewTextBoxColumn
        '
        Me.StopOffLocationDataGridViewTextBoxColumn.DataPropertyName = "StopOffLocation"
        Me.StopOffLocationDataGridViewTextBoxColumn.HeaderText = "StopOffLocation"
        Me.StopOffLocationDataGridViewTextBoxColumn.Name = "StopOffLocationDataGridViewTextBoxColumn"
        Me.StopOffLocationDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TimeTakenDataGridViewTextBoxColumn
        '
        Me.TimeTakenDataGridViewTextBoxColumn.DataPropertyName = "TimeTaken"
        Me.TimeTakenDataGridViewTextBoxColumn.HeaderText = "TimeTaken"
        Me.TimeTakenDataGridViewTextBoxColumn.Name = "TimeTakenDataGridViewTextBoxColumn"
        Me.TimeTakenDataGridViewTextBoxColumn.ReadOnly = True
        '
        'WhosMoveDataGridViewTextBoxColumn
        '
        Me.WhosMoveDataGridViewTextBoxColumn.DataPropertyName = "WhosMove"
        Me.WhosMoveDataGridViewTextBoxColumn.HeaderText = "WhosMove"
        Me.WhosMoveDataGridViewTextBoxColumn.Name = "WhosMoveDataGridViewTextBoxColumn"
        Me.WhosMoveDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TimePickedUpDataGridViewTextBoxColumn
        '
        Me.TimePickedUpDataGridViewTextBoxColumn.DataPropertyName = "TimePickedUp"
        Me.TimePickedUpDataGridViewTextBoxColumn.HeaderText = "TimePickedUp"
        Me.TimePickedUpDataGridViewTextBoxColumn.Name = "TimePickedUpDataGridViewTextBoxColumn"
        Me.TimePickedUpDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PickedUpByDataGridViewTextBoxColumn
        '
        Me.PickedUpByDataGridViewTextBoxColumn.DataPropertyName = "PickedUpBy"
        Me.PickedUpByDataGridViewTextBoxColumn.HeaderText = "PickedUpBy"
        Me.PickedUpByDataGridViewTextBoxColumn.Name = "PickedUpByDataGridViewTextBoxColumn"
        Me.PickedUpByDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TimeParkedDataGridViewTextBoxColumn
        '
        Me.TimeParkedDataGridViewTextBoxColumn.DataPropertyName = "TimeParked"
        Me.TimeParkedDataGridViewTextBoxColumn.HeaderText = "TimeParked"
        Me.TimeParkedDataGridViewTextBoxColumn.Name = "TimeParkedDataGridViewTextBoxColumn"
        Me.TimeParkedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PriorityMoveDataGridViewCheckBoxColumn
        '
        Me.PriorityMoveDataGridViewCheckBoxColumn.DataPropertyName = "PriorityMove"
        Me.PriorityMoveDataGridViewCheckBoxColumn.HeaderText = "PriorityMove"
        Me.PriorityMoveDataGridViewCheckBoxColumn.Name = "PriorityMoveDataGridViewCheckBoxColumn"
        Me.PriorityMoveDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'ParkedByDataGridViewTextBoxColumn
        '
        Me.ParkedByDataGridViewTextBoxColumn.DataPropertyName = "ParkedBy"
        Me.ParkedByDataGridViewTextBoxColumn.HeaderText = "ParkedBy"
        Me.ParkedByDataGridViewTextBoxColumn.Name = "ParkedByDataGridViewTextBoxColumn"
        Me.ParkedByDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MoveStatusDataGridViewTextBoxColumn
        '
        Me.MoveStatusDataGridViewTextBoxColumn.DataPropertyName = "MoveStatus"
        Me.MoveStatusDataGridViewTextBoxColumn.HeaderText = "MoveStatus"
        Me.MoveStatusDataGridViewTextBoxColumn.Name = "MoveStatusDataGridViewTextBoxColumn"
        Me.MoveStatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LoadStatusDataGridViewTextBoxColumn
        '
        Me.LoadStatusDataGridViewTextBoxColumn.DataPropertyName = "LoadStatus"
        Me.LoadStatusDataGridViewTextBoxColumn.HeaderText = "LoadStatus"
        Me.LoadStatusDataGridViewTextBoxColumn.Name = "LoadStatusDataGridViewTextBoxColumn"
        Me.LoadStatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TemperatureDataGridViewTextBoxColumn
        '
        Me.TemperatureDataGridViewTextBoxColumn.DataPropertyName = "Temperature"
        Me.TemperatureDataGridViewTextBoxColumn.HeaderText = "Temperature"
        Me.TemperatureDataGridViewTextBoxColumn.Name = "TemperatureDataGridViewTextBoxColumn"
        Me.TemperatureDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PalletsRequestedDataGridViewTextBoxColumn
        '
        Me.PalletsRequestedDataGridViewTextBoxColumn.DataPropertyName = "PalletsRequested"
        Me.PalletsRequestedDataGridViewTextBoxColumn.HeaderText = "PalletsRequested"
        Me.PalletsRequestedDataGridViewTextBoxColumn.Name = "PalletsRequestedDataGridViewTextBoxColumn"
        Me.PalletsRequestedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PalletsOnBoardDataGridViewTextBoxColumn
        '
        Me.PalletsOnBoardDataGridViewTextBoxColumn.DataPropertyName = "PalletsOnBoard"
        Me.PalletsOnBoardDataGridViewTextBoxColumn.HeaderText = "PalletsOnBoard"
        Me.PalletsOnBoardDataGridViewTextBoxColumn.Name = "PalletsOnBoardDataGridViewTextBoxColumn"
        Me.PalletsOnBoardDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TrailerSystemIDDataGridViewTextBoxColumn
        '
        Me.TrailerSystemIDDataGridViewTextBoxColumn.DataPropertyName = "TrailerSystemID"
        Me.TrailerSystemIDDataGridViewTextBoxColumn.HeaderText = "TrailerSystemID"
        Me.TrailerSystemIDDataGridViewTextBoxColumn.Name = "TrailerSystemIDDataGridViewTextBoxColumn"
        Me.TrailerSystemIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.TrailerSystemIDDataGridViewTextBoxColumn.Visible = False
        '
        'TimeCancelledDataGridViewTextBoxColumn
        '
        Me.TimeCancelledDataGridViewTextBoxColumn.DataPropertyName = "TimeCancelled"
        Me.TimeCancelledDataGridViewTextBoxColumn.HeaderText = "TimeCancelled"
        Me.TimeCancelledDataGridViewTextBoxColumn.Name = "TimeCancelledDataGridViewTextBoxColumn"
        Me.TimeCancelledDataGridViewTextBoxColumn.ReadOnly = True
        Me.TimeCancelledDataGridViewTextBoxColumn.Visible = False
        '
        'PreCoolingStartedDataGridViewTextBoxColumn
        '
        Me.PreCoolingStartedDataGridViewTextBoxColumn.DataPropertyName = "PreCoolingStarted"
        Me.PreCoolingStartedDataGridViewTextBoxColumn.HeaderText = "PreCoolingStarted"
        Me.PreCoolingStartedDataGridViewTextBoxColumn.Name = "PreCoolingStartedDataGridViewTextBoxColumn"
        Me.PreCoolingStartedDataGridViewTextBoxColumn.ReadOnly = True
        Me.PreCoolingStartedDataGridViewTextBoxColumn.Visible = False
        '
        'TimeProblemReportedDataGridViewTextBoxColumn
        '
        Me.TimeProblemReportedDataGridViewTextBoxColumn.DataPropertyName = "TimeProblemReported"
        Me.TimeProblemReportedDataGridViewTextBoxColumn.HeaderText = "TimeProblemReported"
        Me.TimeProblemReportedDataGridViewTextBoxColumn.Name = "TimeProblemReportedDataGridViewTextBoxColumn"
        Me.TimeProblemReportedDataGridViewTextBoxColumn.ReadOnly = True
        Me.TimeProblemReportedDataGridViewTextBoxColumn.Visible = False
        '
        'CancelledDataGridViewCheckBoxColumn
        '
        Me.CancelledDataGridViewCheckBoxColumn.DataPropertyName = "Cancelled"
        Me.CancelledDataGridViewCheckBoxColumn.HeaderText = "Cancelled"
        Me.CancelledDataGridViewCheckBoxColumn.Name = "CancelledDataGridViewCheckBoxColumn"
        Me.CancelledDataGridViewCheckBoxColumn.ReadOnly = True
        Me.CancelledDataGridViewCheckBoxColumn.Visible = False
        '
        'CompletedDataGridViewCheckBoxColumn
        '
        Me.CompletedDataGridViewCheckBoxColumn.DataPropertyName = "Completed"
        Me.CompletedDataGridViewCheckBoxColumn.HeaderText = "Completed"
        Me.CompletedDataGridViewCheckBoxColumn.Name = "CompletedDataGridViewCheckBoxColumn"
        Me.CompletedDataGridViewCheckBoxColumn.ReadOnly = True
        Me.CompletedDataGridViewCheckBoxColumn.Visible = False
        '
        'PreCoolingDataGridViewCheckBoxColumn
        '
        Me.PreCoolingDataGridViewCheckBoxColumn.DataPropertyName = "PreCooling"
        Me.PreCoolingDataGridViewCheckBoxColumn.HeaderText = "PreCooling"
        Me.PreCoolingDataGridViewCheckBoxColumn.Name = "PreCoolingDataGridViewCheckBoxColumn"
        Me.PreCoolingDataGridViewCheckBoxColumn.ReadOnly = True
        Me.PreCoolingDataGridViewCheckBoxColumn.Visible = False
        '
        'ProblemReportedDataGridViewCheckBoxColumn
        '
        Me.ProblemReportedDataGridViewCheckBoxColumn.DataPropertyName = "ProblemReported"
        Me.ProblemReportedDataGridViewCheckBoxColumn.HeaderText = "ProblemReported"
        Me.ProblemReportedDataGridViewCheckBoxColumn.Name = "ProblemReportedDataGridViewCheckBoxColumn"
        Me.ProblemReportedDataGridViewCheckBoxColumn.ReadOnly = True
        Me.ProblemReportedDataGridViewCheckBoxColumn.Visible = False
        '
        'ProblemReportedByDataGridViewTextBoxColumn
        '
        Me.ProblemReportedByDataGridViewTextBoxColumn.DataPropertyName = "ProblemReportedBy"
        Me.ProblemReportedByDataGridViewTextBoxColumn.HeaderText = "ProblemReportedBy"
        Me.ProblemReportedByDataGridViewTextBoxColumn.Name = "ProblemReportedByDataGridViewTextBoxColumn"
        Me.ProblemReportedByDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProblemReportedByDataGridViewTextBoxColumn.Visible = False
        '
        'LastActionDataGridViewTextBoxColumn
        '
        Me.LastActionDataGridViewTextBoxColumn.DataPropertyName = "LastAction"
        Me.LastActionDataGridViewTextBoxColumn.HeaderText = "LastAction"
        Me.LastActionDataGridViewTextBoxColumn.Name = "LastActionDataGridViewTextBoxColumn"
        Me.LastActionDataGridViewTextBoxColumn.ReadOnly = True
        Me.LastActionDataGridViewTextBoxColumn.Visible = False
        '
        'ActiveMoveDataGridViewCheckBoxColumn
        '
        Me.ActiveMoveDataGridViewCheckBoxColumn.DataPropertyName = "ActiveMove"
        Me.ActiveMoveDataGridViewCheckBoxColumn.HeaderText = "ActiveMove"
        Me.ActiveMoveDataGridViewCheckBoxColumn.Name = "ActiveMoveDataGridViewCheckBoxColumn"
        Me.ActiveMoveDataGridViewCheckBoxColumn.ReadOnly = True
        Me.ActiveMoveDataGridViewCheckBoxColumn.Visible = False
        '
        'CancelledByDataGridViewTextBoxColumn
        '
        Me.CancelledByDataGridViewTextBoxColumn.DataPropertyName = "CancelledBy"
        Me.CancelledByDataGridViewTextBoxColumn.HeaderText = "CancelledBy"
        Me.CancelledByDataGridViewTextBoxColumn.Name = "CancelledByDataGridViewTextBoxColumn"
        Me.CancelledByDataGridViewTextBoxColumn.ReadOnly = True
        Me.CancelledByDataGridViewTextBoxColumn.Visible = False
        '
        'LastUserDataGridViewTextBoxColumn
        '
        Me.LastUserDataGridViewTextBoxColumn.DataPropertyName = "LastUser"
        Me.LastUserDataGridViewTextBoxColumn.HeaderText = "LastUser"
        Me.LastUserDataGridViewTextBoxColumn.Name = "LastUserDataGridViewTextBoxColumn"
        Me.LastUserDataGridViewTextBoxColumn.ReadOnly = True
        Me.LastUserDataGridViewTextBoxColumn.Visible = False
        '
        'TakenByDataGridViewTextBoxColumn
        '
        Me.TakenByDataGridViewTextBoxColumn.DataPropertyName = "TakenBy"
        Me.TakenByDataGridViewTextBoxColumn.HeaderText = "TakenBy"
        Me.TakenByDataGridViewTextBoxColumn.Name = "TakenByDataGridViewTextBoxColumn"
        Me.TakenByDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProblemTypeDataGridViewTextBoxColumn
        '
        Me.ProblemTypeDataGridViewTextBoxColumn.DataPropertyName = "ProblemType"
        Me.ProblemTypeDataGridViewTextBoxColumn.HeaderText = "ProblemType"
        Me.ProblemTypeDataGridViewTextBoxColumn.Name = "ProblemTypeDataGridViewTextBoxColumn"
        Me.ProblemTypeDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProblemTypeDataGridViewTextBoxColumn.Visible = False
        '
        'MoveInstructionsDataGridViewTextBoxColumn
        '
        Me.MoveInstructionsDataGridViewTextBoxColumn.DataPropertyName = "MoveInstructions"
        Me.MoveInstructionsDataGridViewTextBoxColumn.HeaderText = "MoveInstructions"
        Me.MoveInstructionsDataGridViewTextBoxColumn.Name = "MoveInstructionsDataGridViewTextBoxColumn"
        Me.MoveInstructionsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ActiveMovesGridView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 469)
        Me.Controls.Add(Me.MovesGridView)
        Me.Name = "ActiveMovesGridView"
        Me.Text = "Active Trailer Moves"
        CType(Me.MovesGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrailerMoveTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MovesGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TrailerMoveTOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MoveID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Carrier As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TrailerID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TimeCalledDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CalledByDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StationCallingDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StartLocationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DestinationLocationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StopOffLocationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TimeTakenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WhosMoveDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TimePickedUpDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PickedUpByDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TimeParkedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriorityMoveDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ParkedByDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MoveStatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LoadStatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TemperatureDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PalletsRequestedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PalletsOnBoardDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TrailerSystemIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TimeCancelledDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PreCoolingStartedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TimeProblemReportedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CancelledDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents CompletedDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents PreCoolingDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ProblemReportedDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ProblemReportedByDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastActionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ActiveMoveDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents CancelledByDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastUserDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TakenByDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProblemTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MoveInstructionsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
