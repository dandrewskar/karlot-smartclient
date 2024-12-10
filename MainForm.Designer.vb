<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.RequestBackgroundWorker = New System.ComponentModel.BackgroundWorker
        Me.RefreshButton = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.CloseHiddenLabel = New System.Windows.Forms.Label
        Me.LoadDoors = New System.ComponentModel.BackgroundWorker
        Me.OldProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.TrailersToolStripDropDownButton = New System.Windows.Forms.ToolStripDropDownButton
        Me.ActiveTrailersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CarriersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BarcodesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ActiveTrailerListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TrailerMovesLogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.YardCheckToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReviewYardCheckToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.YardUpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewActiveMovesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ManagePreCoolingTrailersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TrucksToolStripDropDownButton = New System.Windows.Forms.ToolStripDropDownButton
        Me.MoveTrailerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MessagingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProblemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewTaskToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PlantToolStripDropDownButton = New System.Windows.Forms.ToolStripDropDownButton
        Me.ViewInboundChecklistsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewOutboundChecklistsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewMapToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.KarLotToolStripDropDownButton = New System.Windows.Forms.ToolStripDropDownButton
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UpdateReferenceDataCacheToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.MinimizeToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.RefreshDataToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.LotStatusToolStripLabel = New System.Windows.Forms.ToolStripLabel
        Me.HelpToolStripDropDownButton = New System.Windows.Forms.ToolStripDropDownButton
        Me.ViewHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MiniLabel = New System.Windows.Forms.Label
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripNetworkStatusLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripProgressBar2 = New System.Windows.Forms.ToolStripProgressBar
        Me.AlertToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.CheckNetworkTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ReferenceDataBackgroundWorker = New System.ComponentModel.BackgroundWorker
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ShagImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.GetMovesBackgroundWorker = New System.ComponentModel.BackgroundWorker
        Me.GetMovesTimer = New System.Windows.Forms.Timer(Me.components)
        Me.WifiImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.TasksTimer = New System.Windows.Forms.Timer(Me.components)
        Me.WashDockTrailerTimer = New System.Windows.Forms.Timer(Me.components)
        Me.RefreshDoorsTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SwitchUserLabel = New System.Windows.Forms.Label
        Me.StartingTextLabel = New System.Windows.Forms.Label
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RequestBackgroundWorker
        '
        '
        'RefreshButton
        '
        Me.RefreshButton.Location = New System.Drawing.Point(917, 62)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(108, 23)
        Me.RefreshButton.TabIndex = 0
        Me.RefreshButton.Text = "Refresh"
        Me.RefreshButton.UseVisualStyleBackColor = True
        Me.RefreshButton.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(590, 53)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Blink All"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(671, 53)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Blink Off"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'CloseHiddenLabel
        '
        Me.CloseHiddenLabel.BackColor = System.Drawing.Color.Transparent
        Me.CloseHiddenLabel.Location = New System.Drawing.Point(995, 38)
        Me.CloseHiddenLabel.Name = "CloseHiddenLabel"
        Me.CloseHiddenLabel.Size = New System.Drawing.Size(30, 14)
        Me.CloseHiddenLabel.TabIndex = 3
        Me.CloseHiddenLabel.Text = "None"
        '
        'LoadDoors
        '
        '
        'OldProgressBar1
        '
        Me.OldProgressBar1.ForeColor = System.Drawing.Color.Black
        Me.OldProgressBar1.Location = New System.Drawing.Point(464, 62)
        Me.OldProgressBar1.Name = "OldProgressBar1"
        Me.OldProgressBar1.Size = New System.Drawing.Size(120, 10)
        Me.OldProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.OldProgressBar1.TabIndex = 5
        Me.OldProgressBar1.Value = 50
        Me.OldProgressBar1.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TrailersToolStripDropDownButton, Me.TrucksToolStripDropDownButton, Me.PlantToolStripDropDownButton, Me.KarLotToolStripDropDownButton, Me.ExitToolStripButton, Me.MinimizeToolStripButton, Me.RefreshDataToolStripButton, Me.LotStatusToolStripLabel, Me.HelpToolStripDropDownButton})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(0, -2)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.ShowItemToolTips = False
        Me.ToolStrip1.Size = New System.Drawing.Size(932, 29)
        Me.ToolStrip1.TabIndex = 6
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'TrailersToolStripDropDownButton
        '
        Me.TrailersToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.TrailersToolStripDropDownButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActiveTrailersToolStripMenuItem, Me.CarriersToolStripMenuItem, Me.BarcodesToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.YardCheckToolStripMenuItem, Me.YardUpdateToolStripMenuItem, Me.ViewActiveMovesToolStripMenuItem, Me.ManagePreCoolingTrailersToolStripMenuItem})
        Me.TrailersToolStripDropDownButton.ForeColor = System.Drawing.Color.White
        Me.TrailersToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.White
        Me.TrailersToolStripDropDownButton.Name = "TrailersToolStripDropDownButton"
        Me.TrailersToolStripDropDownButton.Size = New System.Drawing.Size(58, 26)
        Me.TrailersToolStripDropDownButton.Text = "Trailers"
        Me.TrailersToolStripDropDownButton.Visible = False
        '
        'ActiveTrailersToolStripMenuItem
        '
        Me.ActiveTrailersToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ActiveTrailersToolStripMenuItem.Image = CType(resources.GetObject("ActiveTrailersToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ActiveTrailersToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White
        Me.ActiveTrailersToolStripMenuItem.Name = "ActiveTrailersToolStripMenuItem"
        Me.ActiveTrailersToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.ActiveTrailersToolStripMenuItem.Text = "View Active Trailers"
        '
        'CarriersToolStripMenuItem
        '
        Me.CarriersToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.CarriersToolStripMenuItem.Image = CType(resources.GetObject("CarriersToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CarriersToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White
        Me.CarriersToolStripMenuItem.Name = "CarriersToolStripMenuItem"
        Me.CarriersToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.CarriersToolStripMenuItem.Text = "New Trailer/Carriers"
        '
        'BarcodesToolStripMenuItem
        '
        Me.BarcodesToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.BarcodesToolStripMenuItem.Image = CType(resources.GetObject("BarcodesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BarcodesToolStripMenuItem.Name = "BarcodesToolStripMenuItem"
        Me.BarcodesToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.BarcodesToolStripMenuItem.Text = "Barcodes"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActiveTrailerListToolStripMenuItem, Me.TrailerMovesLogToolStripMenuItem})
        Me.ReportsToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        Me.ReportsToolStripMenuItem.Visible = False
        '
        'ActiveTrailerListToolStripMenuItem
        '
        Me.ActiveTrailerListToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ActiveTrailerListToolStripMenuItem.Name = "ActiveTrailerListToolStripMenuItem"
        Me.ActiveTrailerListToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ActiveTrailerListToolStripMenuItem.Text = "Active Trailer List"
        '
        'TrailerMovesLogToolStripMenuItem
        '
        Me.TrailerMovesLogToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.TrailerMovesLogToolStripMenuItem.Name = "TrailerMovesLogToolStripMenuItem"
        Me.TrailerMovesLogToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.TrailerMovesLogToolStripMenuItem.Text = "Trailer Moves Log"
        '
        'YardCheckToolStripMenuItem
        '
        Me.YardCheckToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReviewYardCheckToolStripMenuItem})
        Me.YardCheckToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.YardCheckToolStripMenuItem.Name = "YardCheckToolStripMenuItem"
        Me.YardCheckToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.YardCheckToolStripMenuItem.Text = "Yard Check"
        Me.YardCheckToolStripMenuItem.Visible = False
        '
        'ReviewYardCheckToolStripMenuItem
        '
        Me.ReviewYardCheckToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ReviewYardCheckToolStripMenuItem.Name = "ReviewYardCheckToolStripMenuItem"
        Me.ReviewYardCheckToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.ReviewYardCheckToolStripMenuItem.Text = "Review Yard Check"
        '
        'YardUpdateToolStripMenuItem
        '
        Me.YardUpdateToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.YardUpdateToolStripMenuItem.Name = "YardUpdateToolStripMenuItem"
        Me.YardUpdateToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.YardUpdateToolStripMenuItem.Text = "Yard Update"
        Me.YardUpdateToolStripMenuItem.Visible = False
        '
        'ViewActiveMovesToolStripMenuItem
        '
        Me.ViewActiveMovesToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ViewActiveMovesToolStripMenuItem.Name = "ViewActiveMovesToolStripMenuItem"
        Me.ViewActiveMovesToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.ViewActiveMovesToolStripMenuItem.Text = "View Active Moves"
        Me.ViewActiveMovesToolStripMenuItem.Visible = False
        '
        'ManagePreCoolingTrailersToolStripMenuItem
        '
        Me.ManagePreCoolingTrailersToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ManagePreCoolingTrailersToolStripMenuItem.Name = "ManagePreCoolingTrailersToolStripMenuItem"
        Me.ManagePreCoolingTrailersToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.ManagePreCoolingTrailersToolStripMenuItem.Text = "Manage Pre-Cooling Trailers"
        '
        'TrucksToolStripDropDownButton
        '
        Me.TrucksToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.TrucksToolStripDropDownButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MoveTrailerToolStripMenuItem, Me.MessagingToolStripMenuItem, Me.ProblemsToolStripMenuItem, Me.NewTaskToolStripMenuItem})
        Me.TrucksToolStripDropDownButton.ForeColor = System.Drawing.Color.White
        Me.TrucksToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.White
        Me.TrucksToolStripDropDownButton.Name = "TrucksToolStripDropDownButton"
        Me.TrucksToolStripDropDownButton.Size = New System.Drawing.Size(55, 26)
        Me.TrucksToolStripDropDownButton.Text = "Trucks"
        Me.TrucksToolStripDropDownButton.Visible = False
        '
        'MoveTrailerToolStripMenuItem
        '
        Me.MoveTrailerToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.MoveTrailerToolStripMenuItem.Image = CType(resources.GetObject("MoveTrailerToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MoveTrailerToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White
        Me.MoveTrailerToolStripMenuItem.Name = "MoveTrailerToolStripMenuItem"
        Me.MoveTrailerToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.MoveTrailerToolStripMenuItem.Text = "Move Trailer"
        Me.MoveTrailerToolStripMenuItem.Visible = False
        '
        'MessagingToolStripMenuItem
        '
        Me.MessagingToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.MessagingToolStripMenuItem.Image = CType(resources.GetObject("MessagingToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MessagingToolStripMenuItem.Name = "MessagingToolStripMenuItem"
        Me.MessagingToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.MessagingToolStripMenuItem.Text = "Messaging"
        Me.MessagingToolStripMenuItem.Visible = False
        '
        'ProblemsToolStripMenuItem
        '
        Me.ProblemsToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ProblemsToolStripMenuItem.Image = CType(resources.GetObject("ProblemsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ProblemsToolStripMenuItem.Name = "ProblemsToolStripMenuItem"
        Me.ProblemsToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.ProblemsToolStripMenuItem.Text = "Problems"
        Me.ProblemsToolStripMenuItem.Visible = False
        '
        'NewTaskToolStripMenuItem
        '
        Me.NewTaskToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.NewTaskToolStripMenuItem.Image = CType(resources.GetObject("NewTaskToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NewTaskToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White
        Me.NewTaskToolStripMenuItem.Name = "NewTaskToolStripMenuItem"
        Me.NewTaskToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.NewTaskToolStripMenuItem.Text = "New Task"
        '
        'PlantToolStripDropDownButton
        '
        Me.PlantToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.PlantToolStripDropDownButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewInboundChecklistsToolStripMenuItem, Me.ViewOutboundChecklistsToolStripMenuItem, Me.ViewMapToolStripMenuItem})
        Me.PlantToolStripDropDownButton.ForeColor = System.Drawing.Color.White
        Me.PlantToolStripDropDownButton.Image = CType(resources.GetObject("PlantToolStripDropDownButton.Image"), System.Drawing.Image)
        Me.PlantToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PlantToolStripDropDownButton.Name = "PlantToolStripDropDownButton"
        Me.PlantToolStripDropDownButton.Size = New System.Drawing.Size(47, 26)
        Me.PlantToolStripDropDownButton.Text = "Plant"
        Me.PlantToolStripDropDownButton.Visible = False
        '
        'ViewInboundChecklistsToolStripMenuItem
        '
        Me.ViewInboundChecklistsToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ViewInboundChecklistsToolStripMenuItem.Image = CType(resources.GetObject("ViewInboundChecklistsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ViewInboundChecklistsToolStripMenuItem.Name = "ViewInboundChecklistsToolStripMenuItem"
        Me.ViewInboundChecklistsToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.ViewInboundChecklistsToolStripMenuItem.Text = "View Inbound Checklists"
        Me.ViewInboundChecklistsToolStripMenuItem.Visible = False
        '
        'ViewOutboundChecklistsToolStripMenuItem
        '
        Me.ViewOutboundChecklistsToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ViewOutboundChecklistsToolStripMenuItem.Image = CType(resources.GetObject("ViewOutboundChecklistsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ViewOutboundChecklistsToolStripMenuItem.Name = "ViewOutboundChecklistsToolStripMenuItem"
        Me.ViewOutboundChecklistsToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.ViewOutboundChecklistsToolStripMenuItem.Text = "View Outbound Checklists"
        Me.ViewOutboundChecklistsToolStripMenuItem.Visible = False
        '
        'ViewMapToolStripMenuItem
        '
        Me.ViewMapToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ViewMapToolStripMenuItem.Name = "ViewMapToolStripMenuItem"
        Me.ViewMapToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.ViewMapToolStripMenuItem.Text = "View Map"
        '
        'KarLotToolStripDropDownButton
        '
        Me.KarLotToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.KarLotToolStripDropDownButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdminToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.DataToolStripMenuItem})
        Me.KarLotToolStripDropDownButton.ForeColor = System.Drawing.Color.White
        Me.KarLotToolStripDropDownButton.Image = CType(resources.GetObject("KarLotToolStripDropDownButton.Image"), System.Drawing.Image)
        Me.KarLotToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.KarLotToolStripDropDownButton.Name = "KarLotToolStripDropDownButton"
        Me.KarLotToolStripDropDownButton.Size = New System.Drawing.Size(57, 26)
        Me.KarLotToolStripDropDownButton.Text = "Kar Lot"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AdminToolStripMenuItem.Image = CType(resources.GetObject("AdminToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.AdminToolStripMenuItem.Text = "Admin"
        Me.AdminToolStripMenuItem.Visible = False
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SettingsToolStripMenuItem.Image = CType(resources.GetObject("SettingsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'DataToolStripMenuItem
        '
        Me.DataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateReferenceDataCacheToolStripMenuItem})
        Me.DataToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.DataToolStripMenuItem.Image = CType(resources.GetObject("DataToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DataToolStripMenuItem.Name = "DataToolStripMenuItem"
        Me.DataToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.DataToolStripMenuItem.Text = "Data"
        Me.DataToolStripMenuItem.Visible = False
        '
        'UpdateReferenceDataCacheToolStripMenuItem
        '
        Me.UpdateReferenceDataCacheToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.UpdateReferenceDataCacheToolStripMenuItem.Image = CType(resources.GetObject("UpdateReferenceDataCacheToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UpdateReferenceDataCacheToolStripMenuItem.Name = "UpdateReferenceDataCacheToolStripMenuItem"
        Me.UpdateReferenceDataCacheToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.UpdateReferenceDataCacheToolStripMenuItem.Text = "Update Reference Data"
        '
        'ExitToolStripButton
        '
        Me.ExitToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ExitToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ExitToolStripButton.Image = CType(resources.GetObject("ExitToolStripButton.Image"), System.Drawing.Image)
        Me.ExitToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ExitToolStripButton.Name = "ExitToolStripButton"
        Me.ExitToolStripButton.Size = New System.Drawing.Size(23, 26)
        Me.ExitToolStripButton.Text = "ToolStripButton1"
        Me.ExitToolStripButton.Visible = False
        '
        'MinimizeToolStripButton
        '
        Me.MinimizeToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.MinimizeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MinimizeToolStripButton.Image = CType(resources.GetObject("MinimizeToolStripButton.Image"), System.Drawing.Image)
        Me.MinimizeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MinimizeToolStripButton.Name = "MinimizeToolStripButton"
        Me.MinimizeToolStripButton.Size = New System.Drawing.Size(23, 26)
        Me.MinimizeToolStripButton.Text = "Minimize"
        Me.MinimizeToolStripButton.ToolTipText = "Minimize Application"
        Me.MinimizeToolStripButton.Visible = False
        '
        'RefreshDataToolStripButton
        '
        Me.RefreshDataToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.RefreshDataToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RefreshDataToolStripButton.Image = CType(resources.GetObject("RefreshDataToolStripButton.Image"), System.Drawing.Image)
        Me.RefreshDataToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RefreshDataToolStripButton.Name = "RefreshDataToolStripButton"
        Me.RefreshDataToolStripButton.Size = New System.Drawing.Size(23, 26)
        Me.RefreshDataToolStripButton.Text = "Refresh Screen"
        '
        'LotStatusToolStripLabel
        '
        Me.LotStatusToolStripLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.LotStatusToolStripLabel.ForeColor = System.Drawing.Color.White
        Me.LotStatusToolStripLabel.Name = "LotStatusToolStripLabel"
        Me.LotStatusToolStripLabel.Size = New System.Drawing.Size(132, 26)
        Me.LotStatusToolStripLabel.Text = "LotStatusToolStripLabel"
        '
        'HelpToolStripDropDownButton
        '
        Me.HelpToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.HelpToolStripDropDownButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewHelpToolStripMenuItem})
        Me.HelpToolStripDropDownButton.ForeColor = System.Drawing.Color.White
        Me.HelpToolStripDropDownButton.Image = CType(resources.GetObject("HelpToolStripDropDownButton.Image"), System.Drawing.Image)
        Me.HelpToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.HelpToolStripDropDownButton.Name = "HelpToolStripDropDownButton"
        Me.HelpToolStripDropDownButton.Size = New System.Drawing.Size(45, 26)
        Me.HelpToolStripDropDownButton.Text = "Help"
        '
        'ViewHelpToolStripMenuItem
        '
        Me.ViewHelpToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ViewHelpToolStripMenuItem.Name = "ViewHelpToolStripMenuItem"
        Me.ViewHelpToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.ViewHelpToolStripMenuItem.Text = "View Help"
        '
        'MiniLabel
        '
        Me.MiniLabel.BackColor = System.Drawing.Color.Transparent
        Me.MiniLabel.Location = New System.Drawing.Point(959, 38)
        Me.MiniLabel.Name = "MiniLabel"
        Me.MiniLabel.Size = New System.Drawing.Size(30, 14)
        Me.MiniLabel.TabIndex = 7
        Me.MiniLabel.Text = "None"
        Me.MiniLabel.Visible = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripNetworkStatusLabel, Me.ToolStripProgressBar2, Me.AlertToolStripStatusLabel, Me.ToolStripStatusLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 588)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode
        Me.StatusStrip1.Size = New System.Drawing.Size(932, 24)
        Me.StatusStrip1.TabIndex = 8
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripNetworkStatusLabel
        '
        Me.ToolStripNetworkStatusLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.ToolStripNetworkStatusLabel.ForeColor = System.Drawing.Color.White
        Me.ToolStripNetworkStatusLabel.Name = "ToolStripNetworkStatusLabel"
        Me.ToolStripNetworkStatusLabel.Size = New System.Drawing.Size(164, 19)
        Me.ToolStripNetworkStatusLabel.Text = "ToolStripNetworkStatusLabel"
        '
        'ToolStripProgressBar2
        '
        Me.ToolStripProgressBar2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripProgressBar2.AutoSize = False
        Me.ToolStripProgressBar2.ForeColor = System.Drawing.Color.White
        Me.ToolStripProgressBar2.Name = "ToolStripProgressBar2"
        Me.ToolStripProgressBar2.Padding = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.ToolStripProgressBar2.Size = New System.Drawing.Size(100, 18)
        Me.ToolStripProgressBar2.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ToolStripProgressBar2.Visible = False
        '
        'AlertToolStripStatusLabel
        '
        Me.AlertToolStripStatusLabel.BorderSides = CType((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.AlertToolStripStatusLabel.ForeColor = System.Drawing.Color.White
        Me.AlertToolStripStatusLabel.Name = "AlertToolStripStatusLabel"
        Me.AlertToolStripStatusLabel.Size = New System.Drawing.Size(599, 19)
        Me.AlertToolStripStatusLabel.Spring = True
        Me.AlertToolStripStatusLabel.Text = "AlertToolStripStatusLabel"
        Me.AlertToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(154, 19)
        Me.ToolStripStatusLabel.Text = "VersionToolStripStatusLabel"
        Me.ToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CheckNetworkTimer
        '
        Me.CheckNetworkTimer.Enabled = True
        Me.CheckNetworkTimer.Interval = 1000
        '
        'ReferenceDataBackgroundWorker
        '
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "carrier.jpg")
        Me.ImageList1.Images.SetKeyName(1, "shag right.JPG")
        '
        'ShagImageList
        '
        Me.ShagImageList.ImageStream = CType(resources.GetObject("ShagImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ShagImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.ShagImageList.Images.SetKeyName(0, "E")
        Me.ShagImageList.Images.SetKeyName(1, "D")
        Me.ShagImageList.Images.SetKeyName(2, "F")
        Me.ShagImageList.Images.SetKeyName(3, "P")
        Me.ShagImageList.Images.SetKeyName(4, "PRECOOL")
        Me.ShagImageList.Images.SetKeyName(5, "OOS")
        Me.ShagImageList.Images.SetKeyName(6, "C")
        Me.ShagImageList.Images.SetKeyName(7, "EmptyCleanPriority")
        Me.ShagImageList.Images.SetKeyName(8, "PartialPriority")
        Me.ShagImageList.Images.SetKeyName(9, "FullPriority")
        Me.ShagImageList.Images.SetKeyName(10, "EmptyDirtyPriority")
        '
        'GetMovesBackgroundWorker
        '
        Me.GetMovesBackgroundWorker.WorkerSupportsCancellation = True
        '
        'GetMovesTimer
        '
        Me.GetMovesTimer.Interval = 30000
        '
        'WifiImageList
        '
        Me.WifiImageList.ImageStream = CType(resources.GetObject("WifiImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.WifiImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.WifiImageList.Images.SetKeyName(0, "0")
        Me.WifiImageList.Images.SetKeyName(1, "1")
        Me.WifiImageList.Images.SetKeyName(2, "2")
        Me.WifiImageList.Images.SetKeyName(3, "3")
        Me.WifiImageList.Images.SetKeyName(4, "4")
        Me.WifiImageList.Images.SetKeyName(5, "5")
        '
        'TasksTimer
        '
        Me.TasksTimer.Interval = 1000
        '
        'WashDockTrailerTimer
        '
        Me.WashDockTrailerTimer.Interval = 30000
        '
        'RefreshDoorsTimer
        '
        Me.RefreshDoorsTimer.Interval = 30000
        '
        'SwitchUserLabel
        '
        Me.SwitchUserLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SwitchUserLabel.BackColor = System.Drawing.Color.Transparent
        Me.SwitchUserLabel.Location = New System.Drawing.Point(788, -2)
        Me.SwitchUserLabel.Name = "SwitchUserLabel"
        Me.SwitchUserLabel.Size = New System.Drawing.Size(144, 99)
        Me.SwitchUserLabel.TabIndex = 16
        Me.SwitchUserLabel.Visible = False
        '
        'StartingTextLabel
        '
        Me.StartingTextLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StartingTextLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartingTextLabel.Location = New System.Drawing.Point(12, 333)
        Me.StartingTextLabel.Name = "StartingTextLabel"
        Me.StartingTextLabel.Size = New System.Drawing.Size(908, 23)
        Me.StartingTextLabel.TabIndex = 17
        Me.StartingTextLabel.Text = "Loading, Please Wait..."
        Me.StartingTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.KAR_Lot_SmartClient.My.Resources.Resources.dispatch_start
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(932, 612)
        Me.Controls.Add(Me.StartingTextLabel)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MiniLabel)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.OldProgressBar1)
        Me.Controls.Add(Me.CloseHiddenLabel)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RefreshButton)
        Me.Controls.Add(Me.SwitchUserLabel)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.Text = "KAR Lot SmartClient"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RequestBackgroundWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents RefreshButton As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents CloseHiddenLabel As System.Windows.Forms.Label
    Friend WithEvents LoadDoors As System.ComponentModel.BackgroundWorker
    Friend WithEvents OldProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents MiniLabel As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripProgressBar2 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TrailersToolStripDropDownButton As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ActiveTrailersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrucksToolStripDropDownButton As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents MoveTrailerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CarriersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MessagingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProblemsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PlantToolStripDropDownButton As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ViewInboundChecklistsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewOutboundChecklistsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KarLotToolStripDropDownButton As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents AdminToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarcodesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckNetworkTimer As System.Windows.Forms.Timer
    Friend WithEvents ToolStripNetworkStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ReferenceDataBackgroundWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents RefreshDataToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents AlertToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents UpdateReferenceDataCacheToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents LotStatusToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActiveTrailerListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents YardCheckToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReviewYardCheckToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShagImageList As System.Windows.Forms.ImageList
    Friend WithEvents GetMovesBackgroundWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents GetMovesTimer As System.Windows.Forms.Timer
    Friend WithEvents WifiImageList As System.Windows.Forms.ImageList
    Friend WithEvents TasksTimer As System.Windows.Forms.Timer
    Friend WithEvents NewTaskToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents YardUpdateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WashDockTrailerTimer As System.Windows.Forms.Timer
    Friend WithEvents RefreshDoorsTimer As System.Windows.Forms.Timer
    Friend WithEvents ViewActiveMovesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrailerMovesLogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SwitchUserLabel As System.Windows.Forms.Label
    Friend WithEvents ManagePreCoolingTrailersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewMapToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripDropDownButton As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ViewHelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents StartingTextLabel As System.Windows.Forms.Label
    Friend WithEvents MinimizeToolStripButton As System.Windows.Forms.ToolStripButton

End Class
