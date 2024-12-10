Imports KAR_Lot_SmartClient.GlobalClass
Imports KarLotBO
Imports System.Management
Imports System.Deployment.Application

Public Class MainForm

    Public Event MovesUpdated(ByVal pMoves As List(Of KAR_Lot_SmartClient.karservices.cactus.smartclient.TrailerMoveTO))

#Region " Declarations "
    Public MyBarcodeDataset As karservices.cactus.smartclient.BarcodeDataSet
    Public MyDoorTrailersList() As KAR_Lot_SmartClient.karservices.cactus.smartclient.Trailer

    Dim WithEvents MyDoor As KarDoor.KarDoor
    Dim MyTrailerDataTable As karservices.cactus.smartclient.BarcodeDataSet.ActiveTrailersDataTable
    Dim MyTrailerRow As karservices.cactus.smartclient.BarcodeDataSet.ActiveTrailersRow
    ' THIS STATE IS USED BY THE BACKGROUND WORKER TO CONTROL THE BACKGROUND
    ' WORK THAT SHOULD BE COMPLETED. IT SHOULD BE SET PRIOR TO LAUNCHING
    ' THE BACKGROUND WORKER AND THEN SET TO INACTIVE AFTER THE WORK IS COMPLETED
    Dim CurrentWSRequestState As WebserviceRequestState = WebserviceRequestState.Inactive
    Dim MyBackground As IO.File
    Dim DoorCount As Integer = 0
    Dim MyFriendlyVersion As String = "KAR Lot " 'Application.ProductVersion 'My.Application.Deployment.CurrentVersion.Major.ToString & "." & My.Application.Deployment.CurrentVersion.Minor.ToString
    Dim MyWebService As New KAR_Lot_SmartClient.karservices.cactus.smartclient.kar_smartclient_webservice
    Dim DispatchBackgroundImagePath As Uri
    Dim DispatchLayoutFilePath As Uri
    Dim KarLotFile_BackgroundImage As KarLotFile
    Dim KarLotFile_Layout As KarLotFile
    Dim TrExGuid As Guid = Guid.NewGuid()

    Public Const ClientBackground As String = "dispatch_bg.png"
    Public Const ShagBackground As String = "shag.jpg"
    Public Const WashBackground As String = "wash.jpg"

    ' SHAG VIEW RELATED
    Dim GetMovesRetryCount As Integer = 0
    Dim MovesGuid As Guid = Guid.NewGuid
    Dim MyTasksGuid As Guid = Guid.NewGuid
    Dim AllTasksGuid As Guid = Guid.NewGuid
    Dim GettingMoves As Boolean = False
    Dim GettingWashTrailers As Boolean = False
    Dim AllMoves As New List(Of KAR_Lot_SmartClient.karservices.cactus.smartclient.TrailerMoveTO)
    Dim AllWashTrailers As KAR_Lot_SmartClient.karservices.cactus.smartclient.MovesDataSet.TrailersDataTable
    Dim NetTimerCodeRunning As Boolean = False
    Dim TaskTimerTicks As Integer = 30 ' COUNTS SECOND ON THE TASK TIMER
    Dim TaskTimerCount As Integer = 0
    Dim GettingMyTasks As Boolean = False
    Dim GettingAllTasks As Boolean = False
    Dim RSSI(2) As String ' STORES CURRENT WIFI SIGNAL STRENGTH INFO
    Public WashTrailerOpen As Boolean = False
    Public ShagTrailerOpen As Boolean = False
    Dim RefreshingDoorTrailers As Boolean = False
    Dim MyWashGuid As Guid = Guid.NewGuid
    Public WashBaysUsed As New List(Of String)
    Dim myDoorGuid As Guid = Guid.NewGuid
    Dim MyUser As KAR_Lot_SmartClient.karservices.cactus.smartclient.KarLotUser
    Dim mLayoutDS As New System.Data.DataSet
    Dim sHelpURL As Uri
#End Region

#Region " Application Enum's "

    Enum WebserviceRequestState
        Inactive = 0
        GetActiveTrailerDataset = 1
        BuildScreenFromDB = 2
        LoadDoorsToScreen = 3
    End Enum
    Enum AlertMethod
        ShowWithMessageBox = 0
        ShowWithFriendlyUI = 1
        ShowWithExceptionData = 2
    End Enum
    Enum AppViewMode
        ClientView = 0
        ShagView = 1
        WashView = 2
    End Enum
#End Region

#Region " Primary App Methods "
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ToolStrip1.Visible = False
        ' TODO: Add code here to get app settings and assign them. Then launch app based on the connection type stored in the app settings.

        ' enable/disable menu items based on settings
        Dim TrailersToolstripButton As ToolStripDropDownButton = Me.ToolStrip1.Items.Item("TrailersToolStripDropDownButton")
        If My.Settings.AllowBarcodeActivation = True Then
            TrailersToolstripButton.DropDownItems.Item("BarcodesToolStripMenuItem").Visible = True
        Else
            TrailersToolstripButton.DropDownItems.Item("BarcodesToolStripMenuItem").Visible = False
        End If

        If my.Settings.AllowTrailerCheckInOut = True Then
            TrailersToolstripButton.DropDownItems.Item("CarriersToolStripMenuItem").Visible = False
        Else
            TrailersToolstripButton.DropDownItems.Item("CarriersToolStripMenuItem").Visible = False
        End If

        'SETUP THE SHARED DATASERVICES CLASS
        MyAppDataService = New DataServices
        ' SET USER SETTINGS, CHECK DIRECTORIES, AND CREATE AS NECESSARY
        Try
            My.Settings.DataCacheDirectory = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData ' & "\DataCache"
            My.Settings.DataExportPath = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\KarLot Exported Data"
        Catch ex As Exception
            ' JUST IGNORE IF AN SECURITY ERROR OCCURS. THIS IS NOT REQUIRED FOR APP TO RUN
        End Try
        'If Not My.Computer.FileSystem.DirectoryExists(My.Settings.DataCacheDirectory) Then
        '    My.Computer.FileSystem.CreateDirectory(My.Settings.DataCacheDirectory)
        'End If
        Try
            If Not My.Computer.FileSystem.DirectoryExists(My.Settings.DataExportPath) Then
                Try
                    My.Computer.FileSystem.CreateDirectory(My.Settings.DataExportPath)
                Catch ex As Exception
                    MessageBox.Show("Could not create the export data folder in the 'My Documents' folder. Program will continue to load.", "Export Data Folder", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                End Try
            End If
        Catch ex As Exception
            ' ignore
        End Try
        ' INTIALIZE CONTROLS
        Me.CloseHiddenLabel.Text = ""
        Me.MiniLabel.Text = ""
        Me.OldProgressBar1.Value = 0
        If (ApplicationDeployment.IsNetworkDeployed) Then
            Dim AD As ApplicationDeployment = ApplicationDeployment.CurrentDeployment
            MyFriendlyVersion = "KAR Lot " & AD.CurrentVersion.ToString
        End If
        Me.ToolStripStatusLabel.Text = Me.MyFriendlyVersion
        Me.ShowStatusMessage(WelcomeMessage)
        ' CHECK THE CONNECTIVITY
        ' Not using this method any longer. App pulls only from the RemoteWebService connection type
        'Me.DetectConnectionType()
        NetworkConnected = True
        CurrentConnectionType = KarLotClientConnectionType.RemoteWebService
        Me.ToolStripNetworkStatusLabel.Text = ConnectedMessage

        Select Case CurrentConnectionType
            Case KarLotClientConnectionType.SQLServer2005
                ' NOT USING
            Case KarLotClientConnectionType.SerialPort
                ' NO LONGER IN USE
            Case KarLotClientConnectionType.RemoteWebService
                ' THIS IS THE ONLY VALID CONNECTION TYPE NOW. OTHERS ARE NOT USED.
                Dim uriPrefix As String = "http://"
                If My.Settings.HttpsRemote Then
                    uriPrefix = "http://"
                End If
                Try
                    KarCactusWeb.Url = New Uri(uriPrefix & My.Settings.RemoteWebServer & ":" & My.Settings.RemoteServerPort & My.Settings.EnhancedWebServicePath).ToString
                    KarCactusWebBasic.Url = New Uri(uriPrefix & My.Settings.RemoteWebServer & ":" & My.Settings.RemoteServerPort & My.Settings.BasicWebServicePath).ToString
                    Me.sHelpURL = New Uri(uriPrefix & My.Settings.RemoteWebServer & ":" & My.Settings.RemoteServerPort & My.Settings.HelpURL)
                    ' Setup paths to file resources
                    Me.DispatchLayoutFilePath = New Uri(uriPrefix & My.Settings.RemoteWebServer & ":" & My.Settings.RemoteServerPort & My.Settings.LayoutURL)
                    Me.DispatchBackgroundImagePath = New Uri(uriPrefix & My.Settings.RemoteWebServer & ":" & My.Settings.RemoteServerPort & My.Settings.BackgroundURL)
                Catch ex As Exception
                    ' error setting URI from settings. Show the settings form and then exit
                    MessageBox.Show("The URL to the server could not be set. Check the settings and run the application again.", "Check Settings", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    SettingsForm.ShowDialog()
                    End
                End Try
            Case KarLotClientConnectionType.LocalNetworkWebService
                ' NO LONGER USING THIS FEATURE
                Try
                    KarCactusWeb.Url = "http://" & My.Settings.LocalKarLotServer & ":" & My.Settings.LocalServerPort & My.Settings.EnhancedWebServicePath
                    KarCactusWebBasic.Url = "http://" & My.Settings.LocalKarLotServer & ":" & My.Settings.LocalServerPort & My.Settings.BasicWebServicePath
                Catch ex As Exception
                    ' error setting URI from settings. Show the settings form and then exit
                    MessageBox.Show("The URL to the server could not be set. Check the settings and run the application again.", "Check Settings", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    SettingsForm.ShowDialog()
                    End
                End Try
        End Select

        ' SETUP NEW LOCAL WEB SERVICE TO HANDLE LOCAL WEB REQUESTS
        Me.MyWebService.Url = KarCactusWeb.Url
        AddHandler Me.MyWebService.GetTrailerCompleted, AddressOf Me.GetTrailerCompleted
        AddHandler MyWebService.GetDoorTrailersCompleted, AddressOf Me.GetDoorTrailersComplete
        AddHandler MyWebService.GetMovesCompleted, AddressOf Me.GetMovesComplete
        AddHandler LoginForm.UserAuth, AddressOf Me.DoSetMyUser
        AddHandler MyWebService.ClearTrailerExceptionCompleted, AddressOf Me.ClearTrailerExceptionComplete

        Me.AppStartup()

    End Sub
    Private Sub AppStartup()
        Me.SetupForm()
        Try
            LoginForm.ShowDialog()
        Catch ex As Exception
            End
        End Try
        Me.Refresh()
        If MyUser.UserAuthenticated = False Then
            MessageBox.Show("The username or password you entered is not valid. The program will now close and you can try again.", "Invalid Username or Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            End
        End If
        Me.SetViewMode()
        Me.GetUIPieces()
        Select Case Me.ViewMode
            Case AppViewMode.ClientView
                Me.ToolStrip1.Visible = True
                Me.BuildScreen()

            Case AppViewMode.ShagView
                Me.BackgroundImageLayout = ImageLayout.Zoom
                Me.HideToolStripControls()
                Me.SwitchUserLabel.Visible = True
                Me.RefreshMovesAsnyc()
                Me.Refresh()
                Me.GetMovesTimer.Enabled = True
                Me.TasksTimer.Enabled = True
                Me.UpdateTaskCounts()

            Case AppViewMode.WashView
                Me.HideToolStripControls()
                Me.WashDockTrailerTimer.Start()

        End Select
    End Sub
    Private Sub HideToolStripControls()
        Me.MiniLabel.Visible = False
        Me.CloseHiddenLabel.Visible = False
        Me.ToolStrip1.Visible = False
    End Sub
    Private Sub CallOutDoor(ByVal SystemID As Integer)
        If GlobalClass.NetworkConnected = False Then
            Me.AlertUser(GlobalClass.NotConnectedAlert, AlertMethod.ShowWithFriendlyUI)
        Else
            Try
                Me.MyWebService.GetTrailerAsync(SystemID)
            Catch ex As Exception
                Me.AlertUser(GlobalClass.WebServiceErrorMessage, AlertMethod.ShowWithMessageBox)
            End Try
        End If
    End Sub
    Private Sub CallInDoor(ByVal DoorName As String)
        Dim TrailerRequestForm As New TrailerRequest
        TrailerRequestForm.DoorName = DoorName
        TrailerRequestForm.Show(Me)
    End Sub
    Private Sub GetTrailerCompleted(ByVal sender As Object, ByVal e As KAR_Lot_SmartClient.karservices.cactus.smartclient.GetTrailerCompletedEventArgs)
        If e.Error IsNot Nothing Then
            MessageBox.Show(GlobalClass.WebServiceErrorMessage, "Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If

        Try
            Dim ViewTrailerForm As New ClientViewTrailer(New Uri(KarCactusWeb.Url))
            ViewTrailerForm.ShowTrailer(Me.Convert2Trailer(e.Result))
        Catch ex As Exception
            MessageBox.Show("There was a problem loading the trailer information.", "Processing Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub
    Private Sub BuildScreen()
        ' App gets the layout file from the server upon app load. File name should have TXT extension.
        ' File name can be changed in the application settings.
        Me.KarLotFile_Layout = New KarLotFile(Me.DispatchLayoutFilePath)
        AddHandler KarLotFile_Layout.AsyncProgess, AddressOf Me.KarLotFileLayout_AsyncProgress
        AddHandler KarLotFile_Layout.ReportResults_Binary, AddressOf Me.KarLotFileLayout_AsyncResults
        Me.KarLotFile_Layout.ProcessAsync() ' Gets the layout file from the server.
        ' Actual building of the objects is completed in AsyncResults

    End Sub

    Private Sub RefreshBarcodeDataset()
        'THIS METHOD REFRESHES THE ACTIVE TRAILER TABLE
        If GlobalClass.NetworkConnected Then
            MyBarcodeDataset = GlobalClass.MyAppDataService.GetDataFromCache(DataServices.TableOptions.Trailers, True)
        Else
            MyBarcodeDataset = GlobalClass.MyAppDataService.GetDataFromCache(DataServices.TableOptions.Trailers, False)
        End If
    End Sub
    Private Sub UpdateBackgroundImage()
        ' app gets the image from the server. The image file must be as follows
        ' NAME: dispatch_bg.png
        ' LOCATION: Root directory of the web server. (Uses the remote web server setting for root dir)
        ' Try to keep background image files as small as possible. No greater than 20k if possible
        ' otherwise load times will be long. Depends on your connection speed.

        ' try to load image from server using KarLotFile object
        Me.KarLotFile_BackgroundImage = New KarLotFile(Me.DispatchBackgroundImagePath)
        AddHandler KarLotFile_BackgroundImage.ReportResults_MemoryStream, AddressOf KarLotFileBackgroundImage_AsyncResults
        AddHandler KarLotFile_BackgroundImage.AsyncProgess, AddressOf KarLotFileBackground_AsyncProgress

        Me.KarLotFile_BackgroundImage.ProcessAsync()

    End Sub
    Private Sub SetViewMode()
        Select Case MyUser.UserViewMode
            Case "C" ' Client
                Me.ViewMode = AppViewMode.ClientView
                Me.BackgroundFileName = ClientBackground
                SetUserMenus(MyUser.UserLevel)

            Case "S" ' SHAG
                Me.ViewMode = AppViewMode.ShagView
                Me.BackgroundFileName = ShagBackground
                Me.BackgroundImageLayout = ImageLayout.Zoom
                Me.AlertToolStripStatusLabel.ForeColor = Color.Black
                Me.ToolStripNetworkStatusLabel.ForeColor = Color.Black

            Case "W" ' WASH
                Me.ViewMode = AppViewMode.WashView
                Me.BackgroundFileName = WashBackground
                Me.BackgroundImageLayout = ImageLayout.Zoom
                Me.AlertToolStripStatusLabel.ForeColor = Color.Black
                Me.ToolStripNetworkStatusLabel.ForeColor = Color.Black

            Case Else
                Throw New System.Exception("There is a problem setting up the screen layout. Contact Tech Support.")
        End Select
    End Sub
    Private Sub SetupLookAndFeel()
        ' SETUP LOOK AND FEEL
        Dim t As MyColorTable = New MyColorTable
        ToolStrip1.Renderer = New ToolStripProfessionalRenderer(t)
        Me.StatusStrip1.Renderer = New ToolStripProfessionalRenderer(t)
        ' IF THE PC IS RUNNING IN 800X600 MODE
        If My.Computer.Screen.WorkingArea.Width = 800 Then
            Me.ToolStrip1.Location = New Point(110, 24)
            Me.ToolStrip1.Width = 580
        End If
    End Sub
    Private Sub SetUserMenus(ByVal pUserLevel As String)
        If pUserLevel = Nothing Then Exit Sub

        Select Case pUserLevel
            Case "1" ' SYSTEM ADMIN
                Me.SetupLookAndFeel()
                Me.TrailersToolStripDropDownButton.Visible = True
                Me.TrucksToolStripDropDownButton.Visible = True
                Me.KarLotToolStripDropDownButton.Visible = True
                Me.ActiveTrailerListToolStripMenuItem.ForeColor = Color.White

                ' UNTIL THESE FEATURES BECOME AVAILABLE
                Me.PlantToolStripDropDownButton.Visible = True
                Me.ViewInboundChecklistsToolStripMenuItem.Visible = False
                Me.ViewOutboundChecklistsToolStripMenuItem.Visible = False

            Case "2" ' KAR AREA MANAGER
                Me.SetupLookAndFeel()
                Me.TrailersToolStripDropDownButton.Visible = True
                Me.TrucksToolStripDropDownButton.Visible = True
                Me.ActiveTrailerListToolStripMenuItem.ForeColor = Color.White
                Me.KarLotToolStripDropDownButton.Visible = True
                Me.NewTaskToolStripMenuItem.Visible = True
                Me.PlantToolStripDropDownButton.Visible = True
                Me.ViewInboundChecklistsToolStripMenuItem.Visible = False
                Me.ViewOutboundChecklistsToolStripMenuItem.Visible = False

                ' NO ACCESS
                Me.YardCheckToolStripMenuItem.Visible = False

                ' UNTIL THESE FEATURES BECOME AVAILABLE
                Me.PlantToolStripDropDownButton.Visible = False
                Me.MoveTrailerToolStripMenuItem.Visible = False
                Me.MessagingToolStripMenuItem.Visible = False
                Me.ProblemsToolStripMenuItem.Visible = False

            Case "3", "6" ' KAR PLANT MANAGER AND Users
                Me.SetupLookAndFeel()
                Me.TrailersToolStripDropDownButton.Visible = True
                Me.TrucksToolStripDropDownButton.Visible = True
                Me.ActiveTrailerListToolStripMenuItem.ForeColor = Color.White
                Me.KarLotToolStripDropDownButton.Visible = True
                Me.NewTaskToolStripMenuItem.Visible = True
                Me.PlantToolStripDropDownButton.Visible = True
                Me.ViewInboundChecklistsToolStripMenuItem.Visible = False
                Me.ViewOutboundChecklistsToolStripMenuItem.Visible = False

                ' NO ACCESS
                Me.YardCheckToolStripMenuItem.Visible = False

                ' UNTIL THESE FEATURES BECOME AVAILABLE
                Me.PlantToolStripDropDownButton.Visible = False
                Me.MoveTrailerToolStripMenuItem.Visible = False
                Me.MessagingToolStripMenuItem.Visible = False
                Me.ProblemsToolStripMenuItem.Visible = False

                'Case "6" ' KAR LOT BASIC USER. WASH, SHAGS, PP
                'Case "4" ' PLANT MANAGERS

            Case "4", "5" ' PLANT BASIC USER. EG. DISPATCH
                Me.SetupLookAndFeel()
                Me.TrailersToolStripDropDownButton.Visible = True
                Me.ActiveTrailerListToolStripMenuItem.Visible = True
                Me.ActiveTrailerListToolStripMenuItem.ForeColor = Color.White
                Me.TrucksToolStripDropDownButton.Visible = True
                Me.PlantToolStripDropDownButton.Visible = True
                Me.ViewInboundChecklistsToolStripMenuItem.Visible = False
                Me.ViewOutboundChecklistsToolStripMenuItem.Visible = False
                'Me.TrailersToolStripDropDownButton.ForeColor = Color.White
                'Me.ActiveTrailerListToolStripMenuItem.ForeColor = Color.Black
                'Me.AlertToolStripStatusLabel.ForeColor = Color.Black
                'Me.ToolStripNetworkStatusLabel.ForeColor = Color.Black

                Me.PlantToolStripDropDownButton.Visible = False
                Me.KarLotToolStripDropDownButton.Visible = False

                Me.YardCheckToolStripMenuItem.Visible = False
                Me.MoveTrailerToolStripMenuItem.Visible = False
                Me.MessagingToolStripMenuItem.Visible = False
                Me.ProblemsToolStripMenuItem.Visible = False

                Me.ViewActiveMovesToolStripMenuItem.Visible = True

                If My.Settings.AllowTrailerCheckInOut = True Then
                    Me.CarriersToolStripMenuItem.Visible = False
                Else
                    Me.CarriersToolStripMenuItem.Visible = False
                End If

                If My.Settings.AllowBarcodeActivation = True Then
                    Me.BarcodesToolStripMenuItem.Visible = True
                Else
                    Me.BarcodesToolStripMenuItem.Visible = False
                End If

                Me.ReportsToolStripMenuItem.Visible = True
                Me.NewTaskToolStripMenuItem.Visible = True


            Case Else
                MessageBox.Show("You do not have access rights to this system.")
                End
        End Select
    End Sub
    Private Sub InvokeShowTrailer()
        Me.ClearDoorData()
        Me.Invoke(New EventHandler(AddressOf Me.ShowTrailerData))
    End Sub
    Private Sub ClearDoorData()
        Dim TempKarDoor As KarDoor.KarDoor

        For Each Ctrl As Control In Me.Controls
            If TypeOf (Ctrl) Is KarDoor.KarDoor Then
                TempKarDoor = Ctrl
                TempKarDoor.CurrentTrailer = Nothing
                TempKarDoor.TrailerQue.Clear()
                TempKarDoor.HidePicture()
                TempKarDoor.HideTrailerExceptionIcon()
                TempKarDoor.DoorColor = Color.LimeGreen
            End If
        Next
    End Sub
    Private Sub ShowTrailerData(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim CarrierName As String = ""
        Dim CurrentLocation As String = ""
        Dim NextLocation As String = ""

        ''Me.LotStatusToolStripLabel.Text = Me.MyBarcodeDataset.ActiveTrailers.Rows.Count.ToString & " Trailers on the Lot"

        For Each lTrailer As KAR_Lot_SmartClient.karservices.cactus.smartclient.Trailer In Me.MyDoorTrailersList
            Dim TempKarDoor As KarDoor.KarDoor

            For Each Ctrl As Control In Me.Controls
                If TypeOf (Ctrl) Is KarDoor.KarDoor Then
                    TempKarDoor = Ctrl
                Else
                    GoTo DoNext
                End If

                If TempKarDoor.DoorProperties.DoorName = lTrailer.CurrentLocation Then
                    TempKarDoor.AddTrailer(Me.Convert2DoorTrailer(lTrailer))
                ElseIf TempKarDoor.DoorProperties.DoorName = lTrailer.NextLocation Then
                    TempKarDoor.AddTrailer(Me.Convert2DoorTrailer(lTrailer))
                End If

DoNext:
            Next
        Next
        ' THE PROCESS OF REFRESHING THE DOORS IS DONE
        Me.RefreshingDoorTrailers = False
        Me.AlertUser("Screen refresh complete...", AlertMethod.ShowWithFriendlyUI)
    End Sub
    Private Sub GetUIPieces()
        Me.UpdateBackgroundImage()
        'Me.GetLayoutData() 'NO LONGER NEEDED, NOW LOADING FROM RESOURCE FILE
    End Sub
    Private Sub GetLayoutData()
        If Not My.Computer.FileSystem.FileExists(My.Settings.DataCacheDirectory & "\layout.kar") Then
            If NetworkConnected = True Then
                Try
                    If GlobalClass.CurrentConnectionType = KarLotClientConnectionType.LocalNetworkWebService Then
                        My.Computer.Network.DownloadFile("http://" & My.Settings.LocalKarLotServer & "/layout.kar", My.Settings.DataCacheDirectory & "\layout.kar")
                    Else
                        My.Computer.Network.DownloadFile("http://" & My.Settings.RemoteWebServer & "/layout.kar", My.Settings.DataCacheDirectory & "\layout.kar")
                    End If
                Catch ex As Exception
                    Me.AlertUser("Cannot download layout file. Problem connecting to the server.", AlertMethod.ShowWithMessageBox)
                End Try
            End If
        End If
    End Sub
    Private Sub CheckNetworkTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckNetworkTimer.Tick
        ' if this code block is still executing when the timer runs again just exit the sub
        If Me.NetTimerCodeRunning = True Then Exit Sub

        Me.NetTimerCodeRunning = True
        Try
            If My.Computer.Network.IsAvailable = True Then
                ' IF NETWORK IS AVAILABLE AND NO KAR LOT CONNECTION DO A RE-DETECT
                If CurrentConnectionType = KarLotClientConnectionType.None Then
                    Me.DetectConnectionType()
                End If
                ' IF NETWORK IS AVAILABLE AND FLAG IS FALSE THE SET FLAG AND MESSAGE
                If NetworkConnected = False Then
                    NetworkConnected = True
                    Me.ToolStripNetworkStatusLabel.Text = ConnectedMessage
                End If
                ' GET WIFI SIGNAL STRENGTH INFO
                RSSI = Me.GetSignalStrength
                'Me.RSSILabel.Text = RSSI(0) & " dBm"
                'Me.WifiPictureBox.Image = Me.WifiImageList.Images.Item(RSSI(1))
            Else
                NetworkConnected = False
                CurrentConnectionType = KarLotClientConnectionType.None
                Me.ToolStripNetworkStatusLabel.Text = DisConnectedMessage
                'Me.WifiPictureBox.Image = Me.WifiImageList.Images.Item("0")
            End If
        Catch ex As Exception
            ' NO ACTION TAKEN HERE
        Finally
            Me.NetTimerCodeRunning = False
        End Try

    End Sub
    Private Sub SetupForm()
        Me.LotStatusToolStripLabel.Text = ""
    End Sub
#End Region

#Region " Helper Methods "
    Private Sub DoSetMyUser(ByVal pUser As KAR_Lot_SmartClient.karservices.cactus.smartclient.KarLotUser)
        Me.MyUser = pUser
    End Sub
    Private Sub DetectConnectionType()
        Dim GotPing As Boolean = False
        ' SEARCH FOR SERVER BASED ON APPLICATION SETTINGS
        If My.Settings.ConnectionType = "Network" Then
            ' IF PC IS CONNECTED TO A NETWORK TEST FOR SERVER AVAILABILITY
            If My.Computer.Network.IsAvailable = True Then
                NetworkConnected = True
                Me.ToolStripNetworkStatusLabel.Text = ConnectedMessage
                Try
                    GotPing = My.Computer.Network.Ping(My.Settings.LocalKarLotServer.ToString)
                    If GotPing = True Then
                        ' PING LOCAL SERVER TO TEST FOR LOCAL SERVER AVAILABILITY
                        CurrentConnectionType = KarLotClientConnectionType.LocalNetworkWebService
                    Else
                        GotPing = My.Computer.Network.Ping(My.Settings.RemoteWebServer.ToString)
                        If GotPing = True Then
                            ' PING REMOTE SERVER TO TEST FOR REMOTE SERVER AVAILABILITY
                            CurrentConnectionType = KarLotClientConnectionType.RemoteWebService
                        Else
                            ' NO PING FROM EITHER SERVER
                            NetworkConnected = False
                        End If
                    End If
                Catch ex As Net.NetworkInformation.PingException
                    'MessageBox.Show("Ping Exception")
                    'Me.ShowStatusMessage("Server could not be reached...")
                    Me.AlertUser("Server could not be reached...", AlertMethod.ShowWithFriendlyUI)
                Catch ex As Exception
                    Me.AlertUser(ex.Message, AlertMethod.ShowWithMessageBox)
                End Try
            Else
                NetworkConnected = False
                Me.ToolStripNetworkStatusLabel.Text = DisConnectedMessage
                ' PC IS NOT CONNECTED TO A NETWORK
                CurrentConnectionType = KarLotClientConnectionType.None
            End If

        ElseIf My.Settings.ConnectionType = "Kar Radio" Then
            CurrentConnectionType = KarLotClientConnectionType.None
        End If
    End Sub
    Friend Function ActiveConnection() As Boolean
        If NetworkConnected Then
            Return True
        Else
            Me.AlertUser(NotConnectedAlert, AlertMethod.ShowWithFriendlyUI)
        End If
    End Function
    Friend Sub AlertUser(ByVal Message As String, ByVal Method As AlertMethod, Optional ByVal ex As Exception = Nothing)
        Select Case Method
            Case AlertMethod.ShowWithMessageBox
                MessageBox.Show(Message, Me.MyFriendlyVersion, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case AlertMethod.ShowWithFriendlyUI
                Me.AlertToolStripStatusLabel.Text = Message
                'My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
            Case AlertMethod.ShowWithExceptionData
                Dim ExMsg As String = ""
                ExMsg = Message & vbCrLf & vbCrLf & ex.Message
                MessageBox.Show(ExMsg, "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select

    End Sub
    Friend Sub ShowStatusMessage(ByVal AdditionalMessage As String, Optional ByVal OriginalMessage As String = "", Optional ByVal Reset As Boolean = False)
        If Reset Then
            Me.AlertToolStripStatusLabel.Tag = ""
            Me.AlertToolStripStatusLabel.Text = AdditionalMessage
            Exit Sub
        End If
        ' SET THE ORIGINAL MESSAGE IN THE TAG PROPERTY
        If OriginalMessage > "" Then Me.AlertToolStripStatusLabel.Tag = OriginalMessage
        ' PULL THE ORIGINAL MESSAGE FROM THE TAG PROPERTY AND APPEND ADDITIONAL MESSAGE DATA
        Me.AlertToolStripStatusLabel.Text = Me.AlertToolStripStatusLabel.Tag & AdditionalMessage
    End Sub
#End Region

#Region " Background Worker Related Code "

    Private Sub RequestBackgroundWorker_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles RequestBackgroundWorker.DoWork

        ' TODO: Add Try/Catch here to handle exceptions
        Me.ShowStatusMessage("", GettingDataMessage)
        Me.RequestBackgroundWorker.ReportProgress(25)
        Me.RefreshBarcodeDataset()
        Me.RequestBackgroundWorker.ReportProgress(65)
        Me.InvokeShowTrailer()
        Me.RequestBackgroundWorker.ReportProgress(85)

    End Sub
    Private Sub RequestBackgroundWorker_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles RequestBackgroundWorker.ProgressChanged
        'Me.OldProgressBar1.Value = e.ProgressPercentage
        If Me.ToolStripProgressBar2.Visible = False Then Me.ToolStripProgressBar2.Visible = True
        Me.ToolStripProgressBar2.Value = e.ProgressPercentage
        Me.ShowStatusMessage(" (" & e.ProgressPercentage & "%)")
    End Sub
    Private Sub RequestBackgroundWorker_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles RequestBackgroundWorker.RunWorkerCompleted
        ' RUN POST BACKGROUND WORK TASKS

        ' TODO: Add Try/Catch here to handle exceptions
        'Me.OldProgressBar1.Value = 0
        'Me.OldProgressBar1.Visible = False
        Me.ToolStripProgressBar2.Value = 0
        Me.ToolStripProgressBar2.Visible = False
        Me.ShowStatusMessage(ProcessDoneMessage, "", True)
    End Sub

    Private Sub LoadDoors_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles LoadDoors.DoWork
        Me.ShowStatusMessage("", GettingDataMessage)
        LoadDoors.ReportProgress(75)
        Me.RefreshBarcodeDataset()
        LoadDoors.ReportProgress(85)
        Me.InvokeShowTrailer()
        LoadDoors.ReportProgress(95)
    End Sub
    Private Sub LoadDoors_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles LoadDoors.ProgressChanged
        'Me.OldProgressBar1.Value = e.ProgressPercentage
        If Me.ToolStripProgressBar2.Visible = False Then Me.ToolStripProgressBar2.Visible = True
        Me.ToolStripProgressBar2.Value = e.ProgressPercentage
        Me.ShowStatusMessage(" (" & e.ProgressPercentage & "%)")
    End Sub
    Private Sub LoadDoors_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles LoadDoors.RunWorkerCompleted
        Me.ToolStripProgressBar2.Value = 0
        Me.ToolStripProgressBar2.Visible = False
        Me.ShowStatusMessage(ProcessDoneMessage, "", True)
    End Sub

    Private Sub ReferenceDataBackgroundWorker_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles ReferenceDataBackgroundWorker.DoWork
        ' THIS BACKGROUND WORKER UPDATES REFERENCE DATA FROM THE WEB SERVICE
        Me.ShowStatusMessage("", GettingDataMessage)
        Dim DBs As New DataServices
        Dim MyBD As New karservices.cactus.smartclient.BarcodeDataSet
        Me.ReferenceDataBackgroundWorker.ReportProgress(50)
        MyBD.Carriers.Merge(DBs.GetDataFromCache(DataServices.TableOptions.Carriers, True).Carriers)
        Me.ReferenceDataBackgroundWorker.ReportProgress(75)
        MyBD.Trailers.Merge(DBs.GetDataFromCache(DataServices.TableOptions.Trailers, True).Trailers)
        Me.ReferenceDataBackgroundWorker.ReportProgress(100)
    End Sub
    Private Sub ReferenceDataBackgroundWorker_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles ReferenceDataBackgroundWorker.ProgressChanged
        If Me.ToolStripProgressBar2.Visible = False Then
            Me.ToolStripProgressBar2.Visible = True
        End If
        Me.ToolStripProgressBar2.Value = e.ProgressPercentage
        Me.ShowStatusMessage(" (" & e.ProgressPercentage & "%)")
    End Sub
    Private Sub ReferenceDataBackgroundWorker_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles ReferenceDataBackgroundWorker.RunWorkerCompleted
        Me.ToolStripProgressBar2.Visible = False
        Me.ShowStatusMessage(ProcessDoneMessage, "", True)
    End Sub

    Private Sub KarLotFileBackgroundImage_AsyncResults(ByVal resultStream As IO.MemoryStream, ByVal resultObject As Object)
        Try
            Me.BackgroundImage = Image.FromStream(resultStream)
            Me.BackgroundImageLayout = ImageLayout.None
            Me.StartingTextLabel.Visible = False
        Catch ex As Exception
            ' let admin user through without background image
            If Me.MyUser.UserName = "admin" Then
                Me.AlertUser("ADMIN: background image failed load. " + Me.DispatchBackgroundImagePath.ToString, AlertMethod.ShowWithFriendlyUI)
            Else
                ' notify any other user and close the program.
                Me.AlertUser("Cannot load background. The program will now close. Try again..." + Me.DispatchBackgroundImagePath.ToString, AlertMethod.ShowWithMessageBox)
                Application.Exit()
            End If
        Finally
            RemoveHandler KarLotFile_BackgroundImage.ReportResults_MemoryStream, AddressOf KarLotFileBackgroundImage_AsyncResults
            RemoveHandler KarLotFile_BackgroundImage.AsyncProgess, AddressOf KarLotFileBackground_AsyncProgress
            Me.KarLotFile_BackgroundImage = Nothing ' we're done with this. No need to keep it hanging around
        End Try
    End Sub
    Private Sub KarLotFileBackground_AsyncProgress(ByVal progress As Integer)
        Dim alertMsg As String = "Loading layout image"
        Me.AlertUser(alertMsg + ": " + progress.ToString + "%", AlertMethod.ShowWithFriendlyUI)
        Me.StartingTextLabel.Text = alertMsg + ", Please Wait..."
    End Sub

    Private Sub KarLotFileLayout_AsyncResults(ByVal resultBinary As Byte(), ByVal resultObject As Object)

        Dim alertMsg As String = "Building screen layout"
        Me.AlertUser(alertMsg, AlertMethod.ShowWithFriendlyUI)
        Me.StartingTextLabel.Text = alertMsg + ", Please Wait..."

        Try
            Dim Ms As New System.IO.MemoryStream(resultBinary)
            Dim sR As New System.IO.StreamReader(Ms)

            Me.mLayoutDS.Clear()
            Me.mLayoutDS.ReadXml(sR)

            ' load the doors
            For Each mRw As DataRow In Me.mLayoutDS.Tables.Item(0).Rows
                'Dim mNewDoor As New SiteToolDoor(mRw.Item("DoorID"), mRw.Item("XPos"), mRw.Item("YPos"), mRw.Item("Height"), mRw.Item("Width"), mRw.Item("FontSize"), mRw.Item("TrailerAlign"))
                Application.DoEvents() ' release for other events to work if needed
                Dim MyDoor As New KarDoor.KarDoor(New KarDoor.Door(mRw.Item("DoorID"), New KarDoor.Building("PlantBuilding"), KarDoor.Door.n_DoorState.InactiveNoTrailer))

                MyDoor.FontSize = mRw.Item("FontSize")
                MyDoor.Cursor = Cursors.Hand
                MyDoor.Location = New Point(mRw.Item("XPos"), mRw.Item("YPos"))
                MyDoor.OrigLocation = New Point(mRw.Item("XPos"), mRw.Item("YPos"))
                MyDoor.Size = New Size(mRw.Item("Width"), mRw.Item("Height"))
                MyDoor.OrigSize = New Size(mRw.Item("Width"), mRw.Item("Height"))
                MyDoor.Name = "MyKarDoor" & mRw.Item("DoorID")
                AddHandler MyDoor.CallOut, AddressOf Me.CallOutDoor
                AddHandler MyDoor.RefreshDoors, AddressOf Me.RefreshDoorData
                AddHandler MyDoor.CallIn, AddressOf Me.CallInDoor
                AddHandler MyDoor.CancelMove, AddressOf Me.ShowCancelledMoves
                AddHandler MyDoor.ClearException, AddressOf Me.ClearTrailerException

                Select Case mRw.Item("TrailerAlign")
                    Case "T"
                        MyDoor.ImageOrientation = KarDoor.KarDoor.ImageDirection.Top
                    Case "B"
                        MyDoor.ImageOrientation = KarDoor.KarDoor.ImageDirection.Bottom
                    Case "R"
                        MyDoor.ImageOrientation = KarDoor.KarDoor.ImageDirection.Right
                    Case "L"
                        MyDoor.ImageOrientation = KarDoor.KarDoor.ImageDirection.Left
                End Select

                Me.Controls.Add(MyDoor)
                Me.Controls(MyDoor.Name).BringToFront()
            Next
        Catch ex As Exception
            MessageBox.Show("Error building screen from file! " + Me.DispatchLayoutFilePath.ToString & vbCrLf & vbCrLf & ex.Message)
        Finally
            RemoveHandler KarLotFile_Layout.AsyncProgess, AddressOf Me.KarLotFileLayout_AsyncProgress
            RemoveHandler KarLotFile_Layout.ReportResults_Binary, AddressOf Me.KarLotFileLayout_AsyncResults
            Me.KarLotFile_Layout = Nothing ' we're done with this object. No need to keep it around.
        End Try

        ' Door UI is in place. Now update the data and enable the timer for future updates.
        Me.RefreshDoorData()
        Me.RefreshDoorsTimer.Enabled = True

    End Sub
    Private Sub KarLotFileLayout_AsyncProgress(ByVal percentProgress As Integer)
        Dim alertMsg As String = "Loading layout data"
        Me.AlertUser(alertMsg + ": " + percentProgress.ToString + "%", AlertMethod.ShowWithFriendlyUI)
        Me.StartingTextLabel.Text = alertMsg + ", Please Wait..."
    End Sub
#End Region

#Region " Form Control Methods "
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim x As Integer
        For x = 0 To 5
            'MyDoor(x).TimerRunning(True)
        Next
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim x As Integer
        For x = 0 To 5
            'MyDoor(x).TimerRunning(False)
        Next
    End Sub
    Private Sub MainForm_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        'MessageBox.Show("X: " & e.Location.X.ToString & " Y: " & e.Location.Y.ToString)
    End Sub
#End Region

#Region " GUI Related Methods "
    Private Sub MiniLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MiniLabel.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub CloseHiddenLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseHiddenLabel.Click
        Me.Close()
    End Sub
    Private Sub SetupContextMenu()

    End Sub
#End Region

#Region " ToolStrip Methods "
    Private Sub SettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingsToolStripMenuItem.Click
        SettingsForm.ShowDialog()
    End Sub
    Private Sub ActiveTrailersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActiveTrailersToolStripMenuItem.Click
        ActiveTrailerView.ShowDialog()
    End Sub
    Private Sub ViewInboundChecklistsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewInboundChecklistsToolStripMenuItem.Click
        Cactus.ShowDialog()
    End Sub
    Private Sub BarcodesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BarcodesToolStripMenuItem.Click
        BarcodesForm.ShowDialog()
    End Sub
    Private Sub RefreshDataToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshDataToolStripButton.Click
        Me.RefreshDoorData()
    End Sub
    Public Sub RefreshDoorData()
        ' Main function to refresh the dor data
        If Me.RefreshingDoorTrailers = True Then Exit Sub
        Me.AlertUser("Refreshing screen...", AlertMethod.ShowWithFriendlyUI)
        If Me.ActiveConnection Then
            Me.RefreshingDoorTrailers = True

            Me.MyWebService.CancelAsync(myDoorGuid)
            Me.MyWebService.GetDoorTrailersAsync(myDoorGuid)

        End If
    End Sub
    Private Sub ViewMapToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ViewMapToolStripMenuItem.Click
        Dim mPlantMapForm As New PlantMap
        mPlantMapForm.ShowDialog()

    End Sub
    Private Sub ManagePreCoolingTrailersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManagePreCoolingTrailersToolStripMenuItem.Click
        Dim MyPrecools As New PreCoolForm(Me.MyWebService, Me.MyUser)
        MyPrecools.ShowDialog()
    End Sub
    Private Sub ViewHelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewHelpToolStripMenuItem.Click
        Try
            System.Diagnostics.Process.Start(Me.sHelpURL.ToString)
        Catch ex As Exception
            MessageBox.Show("Could not open help file.")
        End Try
    End Sub
    Private Sub ExitToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripButton.Click
        If MessageBox.Show("Close the program?", "Close Kar Lot?", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
    Private Sub ViewActiveMovesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewActiveMovesToolStripMenuItem.Click
        Dim MovesForm As New ActiveMovesGridView

        MovesForm.ShowDialog(Me)
    End Sub
    Private Sub TrailerMovesLogToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrailerMovesLogToolStripMenuItem.Click
        Dim PrintPrev As New PrintPreview(GlobalClass.KarCactusWeb.Url)
        PrintPrev.RunReport(Me, "KAR_Lot_SmartClient.TrailerMoveLog.rdlc")
    End Sub
    Private Sub YardUpdateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YardUpdateToolStripMenuItem.Click
        Dim YardUpdateForm As New UpdateTrailerInfo
        YardUpdateForm.ShowDialog()
    End Sub
    Private Sub UpdateReferenceDataCacheToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateReferenceDataCacheToolStripMenuItem.Click
        If Me.ActiveConnection Then
            Me.ReferenceDataBackgroundWorker.WorkerReportsProgress = True
            Me.ReferenceDataBackgroundWorker.RunWorkerAsync()
        End If
    End Sub
    Private Sub CarriersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CarriersToolStripMenuItem.Click
        Dim CarriersForm As New Carriers(KarCactusWebBasic.Url, Me.MyUser.UserName)
        CarriersForm.ShowDialog()
    End Sub
    Private Sub MoveTrailerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoveTrailerToolStripMenuItem.Click
        Dim TrailerForm As New MoveTrailers
        TrailerForm.ShowDialog()
    End Sub
    Private Sub ActiveTrailerListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActiveTrailerListToolStripMenuItem.Click
        Dim PrintPrev As New PrintPreview(GlobalClass.KarCactusWeb.Url)
        'PrintPrev.PrintDS.ActiveTrailers.Select("", "Carrier ASC")
        'PrintPrev.ReportFile = "KAR_Lot_SmartClient.ActiveTrailerList.rdlc"
        'PrintPrev.ShowDialog()
        PrintPrev.RunReport(Me, "KAR_Lot_SmartClient.ActiveTrailerList.rdlc")
    End Sub
    Private Sub ReviewYardCheckToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReviewYardCheckToolStripMenuItem.Click
        Dim frmYardCheck As New YardCheckReview
        frmYardCheck.ShowDialog()
    End Sub
    Private Sub ProblemsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProblemsToolStripMenuItem.Click

    End Sub
    Private Sub NewTaskToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewTaskToolStripMenuItem.Click
        Select Case My.Settings.EnhancedTasking
            Case True
                Dim EnhancedTaskForm As New TaskTextingForm
                EnhancedTaskForm.ShowDialog()
            Case Else
                Dim NewTaskForm As New TaskRequest
                NewTaskForm.ShowDialog()
        End Select
    End Sub
    Private Sub MinimizeToolStripButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MinimizeToolStripButton.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
#End Region

#Region " Plant View "
    Private Sub GetDoorTrailersComplete(ByVal sender As Object, ByVal e As karservices.cactus.smartclient.GetDoorTrailersCompletedEventArgs)
        If e.Cancelled = True Then Exit Sub
        ' CHECK FOR ERROR
        If e.Error IsNot Nothing Then
            Me.AlertUser("Problem refreshing screen. I will try again.", AlertMethod.ShowWithExceptionData, e.Error)
            Me.RefreshingDoorTrailers = False
            Exit Sub
        End If
        If e.Result Is Nothing Then
            Me.AlertUser("Could Not Refresh Screen", AlertMethod.ShowWithFriendlyUI)
        End If
        Try
            Me.MyDoorTrailersList = e.Result
            Me.InvokeShowTrailer()
        Catch ex As Exception
            Me.RefreshingDoorTrailers = False
            Me.AlertUser("Screen could not be refreshed, an error has occured...", AlertMethod.ShowWithFriendlyUI)
        End Try
    End Sub
    Private Sub ShowCancelledMoves(ByVal pTrailers As List(Of KarLotTrailer.karlot.Trailer))
        Dim CancelMovesForm As New CancelMoves(pTrailers)
        CancelMovesForm.ShowDialog()
    End Sub
    Private Sub ClearTrailerException(ByVal SystemId As Integer)
        Dim response As DialogResult = MessageBox.Show("Is the problem fixed?", "Problem Fixed?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = System.Windows.Forms.DialogResult.Yes Then
            AlertUser("Please wait, clearing trailer exception...", AlertMethod.ShowWithFriendlyUI)
            Me.MyWebService.CancelAsync(TrExGuid)
            Me.MyWebService.ClearTrailerExceptionAsync(SystemId, TrExGuid)
        Else
            AlertUser("Please fix the problem and try again.", AlertMethod.ShowWithMessageBox)
        End If
    End Sub
    Public Sub ClearTrailerExceptionComplete(ByVal sender As Object, ByVal e As KAR_Lot_SmartClient.karservices.cactus.smartclient.ClearTrailerExceptionCompletedEventArgs)
        If e.Cancelled = True Then Exit Sub
        If e.Error IsNot Nothing Then
            AlertUser(e.Error.Message, AlertMethod.ShowWithExceptionData, e.Error)
            Exit Sub
        Else
            AlertUser(e.Result.Message, AlertMethod.ShowWithFriendlyUI)
            Me.RefreshDoorData()
        End If
    End Sub
#End Region

#Region " Shag View Related Code "
    Public Sub RefreshMoves()
        ' IF THIS IS CALLED AND THE BACKGROUND PROCESS IS ALREADY RUNNING EXIT THIS SUB
        If Me.GettingMoves = True Then Exit Sub
        ' IF A TRAILER IS OPEN WE WILL NOT REFRESH MOVES
        If Me.ShagTrailerOpen = True Then Exit Sub
        Me.GettingMoves = True
        If GlobalClass.NetworkConnected = True Then
            Me.ShowStatusMessage(" (0%)", "Loading Moves...")
            Me.GetMovesBackgroundWorker.WorkerReportsProgress = True
            Me.GetMovesBackgroundWorker.RunWorkerAsync()
        Else
            Me.AlertUser("Cannot refresh move list, Not Connected. I will try again...", AlertMethod.ShowWithFriendlyUI)
            Me.GettingMoves = False
        End If
    End Sub
    Public Sub RefreshMovesAsnyc()
        ' IF A TRAILER IS OPEN WE WILL NOT REFRESH MOVES
        If Me.ShagTrailerOpen = True Then Exit Sub

        If GlobalClass.NetworkConnected = True Then
            Me.GetMovesRetryCount += 1
            'Me.ShowShagDisplayMessage("Loading Moves. Attempt: " & Me.GetMovesRetryCount)
            Me.ShowStatusMessage(" (0%)", "Loading Moves... Attempt: " & Me.GetMovesRetryCount)
            Me.MyWebService.CancelAsync(MovesGuid)
            Me.MyWebService.GetMovesAsync(MovesGuid)
        Else
            'Me.ShowShagDisplayMessage("CANNOT SHOW MOVES")
            Me.AlertUser("Cannot refresh move list, Not Connected. I will try again...", AlertMethod.ShowWithFriendlyUI)
        End If
    End Sub
    Private Sub GetMovesComplete(ByVal sender As Object, ByVal e As KAR_Lot_SmartClient.karservices.cactus.smartclient.GetMovesCompletedEventArgs)
        Me.ToolStripProgressBar2.Value = 0
        Me.ToolStripProgressBar2.Visible = False
        Me.ShowStatusMessage(ProcessDoneMessage, "", True)

        If e.Error IsNot Nothing Then
            Me.AlertUser("Error while re-loading the moves list.", AlertMethod.ShowWithFriendlyUI)
            'Me.ShowShagDisplayMessage("TRYING TO LOAD MOVES")
            Exit Sub
        End If
        If e.Cancelled = True Then
            Me.AlertUser("There was a problem while re-loading the moves list.", AlertMethod.ShowWithFriendlyUI)
            'Me.ShowShagDisplayMessage("TRYING TO LOAD MOVES")
            Exit Sub
        End If
        If e.Result Is Nothing Then
            Me.AllMoves.Clear()
            RaiseEvent MovesUpdated(Me.AllMoves)
            'Me.ShowShagDisplayMessage("TRYING TO LOAD MOVES")
            Me.AlertUser("Could not show Moves...", AlertMethod.ShowWithFriendlyUI)
            Exit Sub
        End If

        Dim Moves() As KAR_Lot_SmartClient.karservices.cactus.smartclient.TrailerMoveTO
        Me.GetMovesRetryCount = 0

        Try
            Moves = e.Result
        Catch ex As Exception
            Me.AlertUser("Problem showing the moves list.", AlertMethod.ShowWithFriendlyUI)
            'Me.ShowShagDisplayMessage("TRYING TO LOAD MOVES")
            Exit Sub
        End Try


        ' CLEAR THE ALL MOVES LIST AND LOAD THE NEW MOVES IF ANY
        Me.AllMoves.Clear()

        If Moves.Length > 0 Then
            For x As Integer = 0 To Moves.Length - 1
                Me.AllMoves.Add(Moves(x))
            Next x
        End If
        ' RAISE EVENT AND REFRESH LOCAL MOVES LIST
        RaiseEvent MovesUpdated(Me.AllMoves)
        'Me.ShowMoves(Me.AllMoves)

    End Sub
    'Public Sub ShowMoves(ByVal Moves As List(Of KAR_Lot_SmartClient.karservices.cactus.smartclient.TrailerMoveTO))
    '    Dim lstTr As ListViewItem

    '    With Me.ShagListView
    '        .Items.Clear()
    '        If Moves.Count = 0 Then
    '            Me.ShowShagDisplayMessage("NO MOVES...")
    '        Else
    '            Me.ShowShagDisplayMessage(Moves.Count.ToString & " MOVES WAITING...")
    '        End If
    '        For Each tMove As KAR_Lot_SmartClient.karservices.cactus.smartclient.TrailerMoveTO In Moves
    '            lstTr = New ListViewItem
    '            Select Case tMove.MoveStatus
    '                Case "Stopoff"
    '                    ' SKIP THE MOVE IF IT IS A STOPOFF STATUS. THIS DENOTES THE TRAILER IS AT WASHDOCK
    '                Case Else
    '                    If tMove.WhosMove = My.Settings.StationID Then
    '                        lstTr.ImageKey = Me.GetImageKey(tMove)
    '                        Select Case tMove.MoveStatus
    '                            Case "FindWash"
    '                                If tMove.StopOffLocation = "NA" Then
    '                                    lstTr.Text = tMove.StartLocation & "->" & tMove.DestinationLocation
    '                                    lstTr.ToolTipText = "FROM: " & tMove.StartLocation & " TO " & tMove.DestinationLocation
    '                                Else
    '                                    lstTr.Text = tMove.StopOffLocation & "->" & tMove.DestinationLocation
    '                                    lstTr.ToolTipText = "FROM: " & tMove.StopOffLocation & " TO " & tMove.DestinationLocation
    '                                End If
    '                            Case "Finding", "Getting", "Locating"
    '                                lstTr.Text = "MY: " & tMove.StartLocation & "->" & tMove.DestinationLocation
    '                                lstTr.ToolTipText = "My Move: FROM: " & tMove.StartLocation & " TO " & tMove.DestinationLocation
    '                            Case "Picked Up"
    '                                lstTr.Text = "MY: " & My.Settings.StationID & "->" & tMove.DestinationLocation
    '                                lstTr.ToolTipText = "My Move: FROM: " & My.Settings.StationID & " TO " & tMove.DestinationLocation
    '                        End Select
    '                        lstTr.Font = New Font("Arial", 10, FontStyle.Bold)
    '                        If tMove.MoveStatus = "Picked Up" Then
    '                            lstTr.ForeColor = Color.Red
    '                        Else
    '                            lstTr.ForeColor = Color.Blue
    '                        End If
    '                        lstTr.Tag = tMove.TrailerSystemID
    '                        .Items.Add(lstTr)
    '                    Else
    '                        ' TODO: Add code here to add move info for Supervisor Drivers to see moves others are working on
    '                        Select Case tMove.MoveStatus
    '                            Case "Finding", "Picked Up", "Parking", "Locating", "Getting", "FindWash"
    '                                ' SKIP MOVE. DOES NOT NEED TO BE SHOWN
    '                            Case "StopCalled"
    '                                ' ADD IT
    '                                lstTr.ImageKey = Me.GetImageKey(tMove)
    '                                If tMove.StopOffLocation = "NA" Then
    '                                    lstTr.Text = tMove.StartLocation & "->" & tMove.DestinationLocation
    '                                    lstTr.ToolTipText = "FROM: " & tMove.StartLocation & " TO " & tMove.DestinationLocation
    '                                Else
    '                                    lstTr.Text = tMove.StopOffLocation & "->" & tMove.DestinationLocation
    '                                    lstTr.ToolTipText = "FROM: " & tMove.StopOffLocation & " TO " & tMove.DestinationLocation
    '                                End If
    '                                lstTr.Tag = tMove.TrailerSystemID
    '                                .Items.Add(lstTr)
    '                            Case Else
    '                                ' ADD IT
    '                                lstTr.ImageKey = Me.GetImageKey(tMove)
    '                                lstTr.Text = tMove.StartLocation & "->" & tMove.DestinationLocation
    '                                lstTr.ToolTipText = "FROM: " & tMove.StartLocation & " TO " & tMove.DestinationLocation
    '                                lstTr.Tag = tMove.TrailerSystemID
    '                                .Items.Add(lstTr)
    '                        End Select
    '                    End If
    '            End Select
    '        Next
    '    End With
    'End Sub
    Private Function GetImageKey(ByVal pMove As KAR_Lot_SmartClient.karservices.cactus.smartclient.TrailerMoveTO) As String
        Select Case pMove.LoadStatus
            Case "E"
                If pMove.PriorityMove Then
                    Return "EmptyCleanPriority"
                Else
                    Return "E"
                End If
            Case "D"
                If pMove.PriorityMove Then
                    Return "EmptyDirtyPriority"
                Else
                    Return "D"
                End If
            Case "P"
                If pMove.PriorityMove Then
                    Return "PartialPriority"
                Else
                    Return "P"
                End If
            Case "F"
                If pMove.PriorityMove Then
                    Return "FullPriority"
                Else
                    Return "F"
                End If
            Case Else
                Return "U"
        End Select
    End Function
    Private Sub GetMovesTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetMovesTimer.Tick
        Me.RefreshMovesAsnyc()
        'If Me.GettingMoves = False Then Me.RefreshMoves()
    End Sub
    Private Sub DisplayTrailer4ShagView(ByVal SystemID As Integer)
        Dim sMove As New KAR_Lot_SmartClient.karservices.cactus.smartclient.TrailerMoveTO
        ' clear the displayed info first
        For Each Move As KAR_Lot_SmartClient.karservices.cactus.smartclient.TrailerMoveTO In AllMoves
            If Move.TrailerSystemID = SystemID Then
                'ShagViewTrailer.ShowTrailer(Move)
                Exit Sub
            End If
        Next
    End Sub
    Public Function Convert2Trailer(ByVal Move As KAR_Lot_SmartClient.karservices.cactus.smartclient.Trailer) As KarLotTrailer.karlot.Trailer
        Dim sTrailer As New KarLotTrailer.karlot.Trailer

        With sTrailer
            .Barcode = Move.Barcode
            .Carrier = New KarLotTrailer.karlot.Carrier
            .Carrier.Scac = Move.Carrier.Scac
            .Carrier.Name = Move.Carrier.Name
            .CurrentLocation = Move.CurrentLocation
            .Load = New KarLotTrailer.karlot.TrailerLoadClass
            .Load.dbCode = Move.Load.dbCode
            .NextLocation = Move.NextLocation
            .SystemID = Move.SystemID
            .Temperature = Move.Temperature
            .SetPointCelsius = Move.SetPointCelsius
            .ThirdLocation = Move.ThirdLocation
            .TrailerID = Move.TrailerID
            .TrailerType = Move.TrailerType
            .WhosMove = Move.WhosMove
            .MoveStatus = Move.MoveStatus
            .SpecialInstructions = Move.SpecialInstructions
            .TrailerAddedTime = Move.TrailerAddedTime
            .PalletsOnBoard = Move.PalletsOnBoard
            .PalletsRequested = Move.PalletsRequested
            .Classification = Move.Classification
            .Seal1 = Move.Seal1
            .Seal2 = Move.Seal2
            .Seal3 = Move.Seal3
            .LoadNumber = Move.LoadNumber
            .CalloutUserInitials = Move.CalloutUserInitials
        End With
        Return sTrailer
    End Function
    Public Function Convert2DoorTrailer(ByVal pTrailer As KAR_Lot_SmartClient.karservices.cactus.smartclient.Trailer) As KarLotTrailer.karlot.Trailer
        Dim sTrailer As New KarLotTrailer.karlot.Trailer
        With sTrailer
            .Barcode = pTrailer.Barcode
            .Carrier = New KarLotTrailer.karlot.Carrier
            .Carrier.Scac = pTrailer.Carrier.Scac
            .Carrier.Name = pTrailer.Carrier.Name
            .CurrentLocation = pTrailer.CurrentLocation
            .PalletsOnBoard = pTrailer.PalletsOnBoard
            .PalletsRequested = pTrailer.PalletsRequested
            .Load = New KarLotTrailer.karlot.TrailerLoadClass
            .Load.dbCode = pTrailer.Load.dbCode
            .NextLocation = pTrailer.NextLocation
            .SystemID = pTrailer.SystemID
            .Temperature = pTrailer.Temperature
            .ThirdLocation = pTrailer.ThirdLocation
            .TrailerID = pTrailer.TrailerID
            .TrailerType = pTrailer.TrailerType
            .WhosMove = pTrailer.WhosMove
            .MoveStatus = pTrailer.MoveStatus
            .SpecialInstructions = pTrailer.SpecialInstructions
            .TrailerAddedTime = pTrailer.TrailerAddedTime
            .MoveID = pTrailer.MoveID
            .Seal1 = pTrailer.Seal1
            .Seal2 = pTrailer.Seal2
            .Seal3 = pTrailer.Seal3
            .LoadNumber = pTrailer.LoadNumber
            .SealException = pTrailer.SealException
            .OutOfService = pTrailer.OutOfService
            .CalloutUserInitials = pTrailer.CalloutUserInitials
            .PreCooling = pTrailer.PreCooling
            .ReferUnitMode = pTrailer.ReferUnitMode
            .HasException = pTrailer.HasException
            .ExceptionCode = pTrailer.ExceptionCode
            .ExceptionCodeDescription = pTrailer.ExceptionCodeDescription
        End With
        Return sTrailer
    End Function
    Public Function Convert2WebTrailer(ByVal Move As KarLotTrailer.karlot.Trailer) As KAR_Lot_SmartClient.karservices.cactus.smartclient.Trailer
        Dim sTrailer As New KAR_Lot_SmartClient.karservices.cactus.smartclient.Trailer

        With sTrailer
            .Barcode = Move.Barcode
            .Carrier = New KAR_Lot_SmartClient.karservices.cactus.smartclient.Carrier
            .Carrier.Scac = Move.Carrier.Scac
            .Carrier.Name = Move.Carrier.Name
            .CurrentLocation = Move.CurrentLocation
            .Load = New KAR_Lot_SmartClient.karservices.cactus.smartclient.TrailerLoadClass
            .Load.dbCode = Move.Load.dbCode
            .NextLocation = Move.NextLocation
            .SystemID = Move.SystemID
            .Temperature = Move.Temperature
            .ThirdLocation = Move.ThirdLocation
            .TrailerID = Move.TrailerID
            .TrailerType = Move.TrailerType
            .WhosMove = Move.WhosMove
            .MoveStatus = Move.MoveStatus
            .SpecialInstructions = Move.SpecialInstructions
            .TrailerAddedTime = Move.TrailerAddedTime
            .PalletsOnBoard = Move.PalletsOnBoard
            .PalletsRequested = Move.PalletsRequested
            .MoveID = Move.MoveID
            .Seal1 = Move.Seal1
            .Seal2 = Move.Seal2
            .Seal3 = Move.Seal3
            .LoadNumber = Move.LoadNumber
            .CalloutUserInitials = Move.CalloutUserInitials
            .Classification = Move.Classification
            .Pallets = Move.Pallets
            .SetPointCelsius = Move.SetPointCelsius
            .ReferUnitMode = Move.ReferUnitMode
        End With
        Return sTrailer
    End Function
    Public Function GetSignalStrength() As String()
        On Error GoTo oops

        Dim query As ManagementObjectSearcher
        Dim Qc As ManagementObjectCollection
        Dim Oq As ObjectQuery
        Dim Ms As ManagementScope
        Dim Co As ConnectionOptions
        Dim Mo As ManagementObject
        Dim outp As String
        Dim ISIPActive As Boolean
        Dim Dbm As Integer = 0
        Dim RSSI(2) As String

        Co = New ConnectionOptions
        Ms = New ManagementScope("root\wmi")
        Oq = New ObjectQuery("SELECT * FROM MSNdis_80211_ReceivedSignalStrength Where active=true")
        query = New ManagementObjectSearcher(Ms, Oq)
        Qc = query.Get
        outp = ""

        For Each Mo In query.Get
            outp = Mo("Ndis80211ReceivedSignalStrength") & " "
            ISIPActive = Mo("Active")
        Next
        ' ACTUAL DBM READING
        RSSI(0) = outp

        Dbm = CInt(outp)

        Select Case Dbm
            Case 0
                RSSI(1) = "0"
                RSSI(2) = "Error"
            Case Is < -90
                RSSI(1) = "0"
                RSSI(2) = "No Signal"
            Case Is < -80
                RSSI(1) = "1"
                RSSI(2) = "Poor Signal"
            Case Is < -70
                RSSI(1) = "2"
                RSSI(2) = "Weak Signal"
            Case Is < -60
                RSSI(1) = "3"
                RSSI(2) = "Good Signal"
            Case Is < -50
                RSSI(1) = "4"
                RSSI(2) = "Great Signal"
            Case Else
                RSSI(1) = "5"
                RSSI(2) = "DUDE!!!"
        End Select

        Return RSSI
        Exit Function
oops:
        RSSI(0) = "0"
        RSSI(1) = "0"
        RSSI(2) = "ERROR"
        Return RSSI
    End Function
    Private Sub ShagListView_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
#End Region

#Region " Public Properties "

    Private m_ViewMode As AppViewMode
    Public Property ViewMode() As AppViewMode
        Get
            Return m_ViewMode
        End Get
        Set(ByVal value As AppViewMode)
            m_ViewMode = value
        End Set
    End Property

    Private m_BackgroundFileName As String
    Public Property BackgroundFileName() As String
        Get
            Return m_BackgroundFileName
        End Get
        Set(ByVal value As String)
            m_BackgroundFileName = value
        End Set
    End Property

#End Region


    Public Sub UpdateTaskCounts()
        If GlobalClass.NetworkConnected = True Then
            ' get task counts from server
            Try
                MyWebService.CancelAsync(AllTasksGuid)
                MyWebService.CancelAsync(MyTasksGuid)
                MyWebService.GetOpenTaskCountAsync(AllTasksGuid)
                MyWebService.GetUserTaskCountAsync(GlobalClass.MyUser.UserName, MyTasksGuid)
            Catch ex As Exception
                Me.AlertUser("Cannot update task information. Error occured...", AlertMethod.ShowWithFriendlyUI)
                Me.GettingMyTasks = False
                Me.GettingAllTasks = False
                Exit Sub
            End Try
        Else
            Me.AlertUser(GlobalClass.NotConnectedAlert, AlertMethod.ShowWithFriendlyUI)
            Me.GettingMyTasks = False
            Me.GettingAllTasks = False
            Exit Sub
        End If
    End Sub

    Private Sub MyTasksLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Dim MyTasksForm As New UserTasks

        MyTasksForm.ShowDialog()
    End Sub


    Private Sub PendingTasksLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Dim OpenTasksForm As New OpenTasks

        OpenTasksForm.ShowDialog()
    End Sub


    Private Sub RefreshDoorsTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshDoorsTimer.Tick
        Me.RefreshDoorData()
    End Sub


    Private Sub SwitchUserLabel_MouseUp(ByVal sender As System.Object, ByVal e As MouseEventArgs) Handles SwitchUserLabel.MouseUp
        MyUser.UserAuthenticated = False
        Me.AppStartup()
    End Sub

End Class
