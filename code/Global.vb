Public Class GlobalClass
    ' APP MESSAGE CONSTANTS
    Public Const ConnectedMessage As String = "Online"
    Public Const DisConnectedMessage As String = "Offline"
    Public Const NotConnectedAlert As String = "The request could not be completed because the application is not connected to a network..."
    Public Const GettingDataMessage As String = "Data is Being Loaded..."
    Public Const ProcessDoneMessage As String = "Done!"
    Public Const WelcomeMessage As String = "Welcome to Kar Lot..."
    Public Const SavingDataMessage As String = "Your Information is Being Saved..."
    Public Const FieldsNotValidMessage As String = "Make sure each field is complete and all required selections are made. Please try again..."
    Public Const WebServiceErrorMessage As String = "An error occurred while communicating with the server. Check your network connection and try again..."
    Public Const DataSavedWithoutErrorMessage As String = "Information Saved..."
    Public Const WorkingOfflineNoAction As String = "You are currently working offline and cannot perform this function."
    ' APP STATE CONSTANTS
    Public Enum ButtonModes
        Normal = 0
        Saving = 1
        Editing = 2
        AllLocked = 3
    End Enum
    ' CONNECTION TYPES
    Public Enum KarLotClientConnectionType
        RemoteWebService = 1
        SerialPort = 2
        SQLServer2005 = 3
        LocalNetworkWebService = 4
        None = 5
    End Enum
    ' APP GLOBAL DECLARATIONS
    Friend Shared NetworkConnected As Boolean = False
    Friend Shared MyAppDataService As DataServices
    Friend Shared CurrentConnectionType As KarLotClientConnectionType
    Friend Shared KarCactusWeb As New karservices.cactus.smartclient.kar_smartclient_webservice
    Friend Shared KarCactusWebBasic As New karservices.cactus.webservices.Service
    Friend Shared MyUser As New KAR_Lot_SmartClient.karservices.cactus.smartclient.KarLotUser

End Class
