Imports System.Drawing.Color
Imports System.Drawing
Imports System.Windows.Forms

Public Class Carrier
    Public Name As String
    Public Scac As String
    Public Group As String
    Public OtherID As String
    Public Sub New()

    End Sub
    Public Sub New(ByVal Name As String, ByVal Scac As String)
        Me.Name = Name
        Me.Scac = Scac
    End Sub
End Class

Public Class KarLotZone
    Public Name As String
    Public TrailerStatus As String
    Public MaxTrailers As Integer
    Public CurrentCount As Integer
    Public BackColor As Drawing.Color
    Public ForeColor As Drawing.Color
    Public Location As Drawing.Point
    Public Width As Integer
    Public Height As Integer
End Class

Public Class TrailerSimple
    Public Barcode As String
    Public SystemID As Integer
    Public Carrier As Carrier
    Public TrailerID As String
    Public Temperature As String
    Public FuelLevel As Integer
    Public Location As String
    Public NextLocation As String
    Public ThirdLocation As String
    Public MoveStatus As String
    Public WhosMove As String
    Public YardChecked As Boolean
    Public TrailerLoad As TrailerLoadClass
End Class

Public Class TrailerLoadClass
    Enum LoadStatusType
        Unknown = 0
        CompleteLoad = 1
        PartialLoad = 2
        EmptyClean = 3
        EmptyDirty = 4
    End Enum
    Public LoadStatusMessage As String
    Public TypeLoadStatus As LoadStatusType
    Public DbCode As String
    Public Sub ChangeStatus(ByVal NewStatus As LoadStatusType)
        Me.TypeLoadStatus = NewStatus
        Select Case NewStatus
            Case LoadStatusType.CompleteLoad
                Me.LoadStatusMessage = "COMPLETE"
                Me.DbCode = "F"
            Case LoadStatusType.EmptyClean
                Me.LoadStatusMessage = "EMPTY CLEAN"
                Me.DbCode = "E"
                Me.TypeLoadStatus = LoadStatusType.EmptyClean
            Case LoadStatusType.EmptyDirty
                Me.LoadStatusMessage = "EMPTY DIRTY"
                Me.DbCode = "D"
            Case LoadStatusType.PartialLoad
                Me.LoadStatusMessage = "PARTIAL"
                Me.DbCode = "P"
            Case LoadStatusType.Unknown
                Me.LoadStatusMessage = "UNKNOWN"
                Me.DbCode = "U"
        End Select
    End Sub
End Class

Public Class Trailer
    Public Sub New(ByVal Scac As String, ByVal TrailerID As String, ByVal Temperature As String, _
    ByVal PalletsOnBoard As String, ByVal PalletsRequested As String, _
    ByVal Classification As String, ByVal CurrentLocation As String, ByVal NextLocation As String, _
    ByVal ThirdLocation As String, ByVal CarrierName As String, ByVal LoadStatus As String, _
    ByVal MoveStatus As String, ByVal WhosMove As String, ByVal RecordVersion As String)

        Me.m_CarrierName = CarrierName
        Me.m_Classification = Classification
        Me.m_CurrentLocation = CurrentLocation
        'Me.m_LastAction = LastAction
        Me.m_LoadStatus = LoadStatus
        Me.m_MoveStatus = MoveStatus
        Me.m_NextLocation = NextLocation
        Me.m_PalletsOnBoard = PalletsOnBoard
        Me.m_PalletsRequested = PalletsRequested
        Me.m_RecordVersion = RecordVersion
        Me.m_Scac = Scac
        Me.m_Temperature = Temperature
        Me.m_ThirdLocation = ThirdLocation
        Me.m_TrailerID = TrailerID
        Me.m_WhosMove = WhosMove

    End Sub
    Private m_Scac As String
    Public Property Scac() As String
        Get
            Return m_Scac
        End Get
        Set(ByVal value As String)
            m_Scac = value
        End Set
    End Property
    Private m_TrailerID As String
    Public Property TrailerID() As String
        Get
            Return m_TrailerID
        End Get
        Set(ByVal value As String)
            m_TrailerID = value
        End Set
    End Property
    Private m_Temperature As String
    Public Property Temperature() As String
        Get
            Return m_Temperature
        End Get
        Set(ByVal value As String)
            m_Temperature = value
        End Set
    End Property
    Private m_PalletsOnBoard As String
    Public Property PalletsOnBoard() As String
        Get
            Return m_PalletsOnBoard
        End Get
        Set(ByVal value As String)
            m_PalletsOnBoard = value
        End Set
    End Property
    Private m_PalletsRequested As String
    Public Property PalletsRequested() As String
        Get
            Return m_PalletsRequested
        End Get
        Set(ByVal value As String)
            m_PalletsRequested = value
        End Set
    End Property
    Private m_LastAction As DateTime
    Public Property LastAction() As DateTime
        Get
            Return m_LastAction
        End Get
        Set(ByVal value As DateTime)
            m_LastAction = value
        End Set
    End Property
    Private m_Classification As String
    Public Property Classification() As String
        Get
            Return m_Classification
        End Get
        Set(ByVal value As String)
            m_Classification = value
        End Set
    End Property
    Private m_CurrentLocation As String
    Public Property CurrentLocation() As String
        Get
            Return m_CurrentLocation
        End Get
        Set(ByVal value As String)
            m_CurrentLocation = value
        End Set
    End Property
    Private m_NextLocation As String
    Public Property NextLocation() As String
        Get
            Return m_NextLocation
        End Get
        Set(ByVal value As String)
            m_NextLocation = value
        End Set
    End Property
    Private m_ThirdLocation As String
    Public Property ThirdLocation() As String
        Get
            Return m_ThirdLocation
        End Get
        Set(ByVal value As String)
            m_ThirdLocation = value
        End Set
    End Property
    Private m_CarrierName As String
    Public Property CarrierName() As String
        Get
            Return m_CarrierName
        End Get
        Set(ByVal value As String)
            m_CarrierName = value
        End Set
    End Property
    Private m_LoadStatus As String
    Public Property LoadStatus() As String
        Get
            Return m_LoadStatus
        End Get
        Set(ByVal value As String)
            m_LoadStatus = value
        End Set
    End Property
    Private m_MoveStatus As String
    Public Property MoveStatus() As String
        Get
            Return m_MoveStatus
        End Get
        Set(ByVal value As String)
            m_MoveStatus = value
        End Set
    End Property
    Private m_WhosMove As String
    Public Property WhosMove() As String
        Get
            Return m_WhosMove
        End Get
        Set(ByVal value As String)
            m_WhosMove = value
        End Set
    End Property
    Private m_RecordVersion As String
    Public Property RecordVersion() As String
        Get
            Return m_RecordVersion
        End Get
        Set(ByVal value As String)
            m_RecordVersion = value
        End Set
    End Property
End Class

Public Class Door
    Enum n_DoorState
        InactiveNoTrailer = 0
        TrailerCalledToDoor = 1
        TrailerMovingToDoor = 2
        TrailerInDoor = 3
        TrailerCalledOutDoor = 4
    End Enum
    Public Sub New(ByVal DoorName As String, ByVal Building As Building, ByVal DoorState As n_DoorState)
        Me.m_DoorName = DoorName
        Me.BuildingLocation = Building
        Me.m_DoorState = DoorState
    End Sub
    Private m_DoorName As String
    Public Property DoorName() As String
        Get
            Return m_DoorName
        End Get
        Set(ByVal value As String)
            m_DoorName = value
        End Set
    End Property
    Private m_BuildingLocation As Building
    Public Property BuildingLocation() As Building
        Get
            Return m_BuildingLocation
        End Get
        Set(ByVal value As Building)
            m_BuildingLocation = value
        End Set
    End Property
    Private m_DoorState As n_DoorState
    Public Property DoorState() As n_DoorState
        Get
            Return m_DoorState
        End Get
        Set(ByVal value As n_DoorState)
            m_DoorState = value
        End Set
    End Property
End Class

Public Class Building
    Public Sub New(ByVal BuildingName As String)
        Me.m_Name = BuildingName
    End Sub
    Public Sub DrawBuilding(ByRef FormRef As System.Windows.Forms.Form,
    ByVal BackColor As Drawing.Color, ByVal Location As Drawing.Point,
    ByVal Width As Integer, ByVal Height As Integer)
        Me.Location = Location
        Me.BackColor = BackColor
        Me.Height = Height
        Me.Width = Width
        Using MyBrush As New SolidBrush(Me.BackColor),
            formGraphics As Graphics = FormRef.CreateGraphics()
            formGraphics.FillRectangle(MyBrush, New Rectangle(Me.Location.X, Me.Location.Y, Me.Width, Me.Height))
        End Using
    End Sub
    Private m_Name As String
    Public Property Name() As String
        Get
            Return m_Name
        End Get
        Set(ByVal value As String)
            m_Name = value
        End Set
    End Property
    Private m_Location As Drawing.Point
    Public Property Location() As Drawing.Point
        Get
            Return m_Location
        End Get
        Set(ByVal value As Drawing.Point)
            m_Location = value
        End Set
    End Property
    Private m_Width As Integer
    Public Property Width() As Integer
        Get
            Return m_Width
        End Get
        Set(ByVal value As Integer)
            m_Width = value
        End Set
    End Property
    Private m_Height As Integer
    Public Property Height() As Integer
        Get
            Return m_Height
        End Get
        Set(ByVal value As Integer)
            m_Height = value
        End Set
    End Property
    Private m_BackColor As Drawing.Color
    Public Property BackColor() As Drawing.Color
        Get
            Return m_BackColor
        End Get
        Set(ByVal value As Drawing.Color)
            m_BackColor = value
        End Set
    End Property
    Private m_ForeColor As Drawing.Color
    Public Property ForeColor() As Drawing.Color
        Get
            Return m_ForeColor
        End Get
        Set(ByVal value As Drawing.Color)
            m_ForeColor = value
        End Set
    End Property

End Class

