Public Class CallOutLocations
    Dim MyWebService As New KAR_Lot_SmartClient.karservices.cactus.smartclient.kar_smartclient_webservice
    Public Event SetNextLoc(ByVal Loc As String, ByVal DropType As KAR_Lot_SmartClient.karservices.cactus.smartclient.DropDestType)
    Public Event SetThirdLoc(ByVal Loc As String, ByVal DropType As KAR_Lot_SmartClient.karservices.cactus.smartclient.DropDestType)

#Region " FORM METHODS "
    Public Sub New(ByVal NewStatus As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        ' ADD WASH AS A POSSIBLE LOCATION IF NEW STATUS IS DIRTY. WE WANT TO ALLOW THE TRAILER TO BE CALLED TO THE WASHDOCK AND THEN BACK TO A DOOR.
        'If NewStatus = "D" Then
        '    Me.NextLoc = "WASH"
        '    Me.NextLocLabel.Text = "Next Location: WASH"
        '    Me.WashOnlyPanel.Visible = True
        '    Me.NextLocationDoorsListBox.Enabled = False
        'End If

    End Sub
    Private Sub CallOutLocations_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.MyWebService.Url = GlobalClass.KarCactusWeb.Url
        AddHandler MyWebService.GetBuildingsByDroptypeCompleted, AddressOf Me.GetBuildingsCompleted
        AddHandler MyWebService.GetDoorsCompleted, AddressOf Me.GetDoorsCompleted

        Try
            Me.MyWebService.GetBuildingsByDroptypeAsync("DOOR")
        Catch ex As Exception
            MessageBox.Show(GlobalClass.WebServiceErrorMessage)
            Me.Close()
        End Try

    End Sub
    Private Sub CallOutLocations_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub
    Private Sub CancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyCancelButton.Click
        Me.Close()
    End Sub
    Private Sub NextLocationDoorsListBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextLocationDoorsListBox.SelectedIndexChanged
        Dim SelectedDoor As KAR_Lot_SmartClient.karservices.cactus.smartclient.Door = Me.NextLocationDoorsListBox.SelectedItem
        Me.NextLoc = SelectedDoor.DoorID.Trim
        Me.NextLocLabel.Text = "Next Location: " & SelectedDoor.DoorID.Trim
    End Sub
#End Region

#Region " WebService Related Code "
    Private Sub GetBuildingsCompleted(ByVal sender As Object, ByVal e As KAR_Lot_SmartClient.karservices.cactus.smartclient.GetBuildingsByDroptypeCompletedEventArgs)
        Dim Buildings() As KAR_Lot_SmartClient.karservices.cactus.smartclient.Building = e.Result

        Try
            For Each Building As KAR_Lot_SmartClient.karservices.cactus.smartclient.Building In Buildings
                Me.MyWebService.GetDoorsAsync(Building.BuildingID, Guid.NewGuid)
            Next
        Catch ex As Exception
            MessageBox.Show(GlobalClass.WebServiceErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub
    Private Sub GetDoorsCompleted(ByVal sender As Object, ByVal e As KAR_Lot_SmartClient.karservices.cactus.smartclient.GetDoorsCompletedEventArgs)
        Dim Doors() As KAR_Lot_SmartClient.karservices.cactus.smartclient.Door = e.Result

        Me.NextLocationDoorsListBox.DisplayMember = "DoorID"
        Me.NextLocationDoorsListBox.ValueMember = "DoorID"

        For Each Door As KAR_Lot_SmartClient.karservices.cactus.smartclient.Door In Doors
            ' EACH NUMBER HAS TO BE SAME LENGTH TO SORT CORRECTLY. SPACES ARE TRIMMED LATER
            Door.DoorID = Door.DoorID.PadLeft(10)
            Me.NextLocationDoorsListBox.Items.Add(Door)
        Next
    End Sub
#End Region

#Region " Public Properties "

    Private m_RecallRequired As Boolean = False
    Public Property RecallRequired() As Boolean
        Get
            Return m_RecallRequired
        End Get
        Set(ByVal value As Boolean)
            m_RecallRequired = value
        End Set
    End Property

    Private m_NextLoc As String = ""
    Public Property NextLoc() As String
        Get
            Return m_NextLoc
        End Get
        Set(ByVal value As String)
            m_NextLoc = value
        End Set
    End Property

    Private m_ThirdLoc As String = ""
    Public Property ThirdLoc() As String
        Get
            Return m_ThirdLoc
        End Get
        Set(ByVal value As String)
            m_ThirdLoc = value
        End Set
    End Property

#End Region

    Private Sub ActionButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActionButton.Click
        If Me.VerifyFields = False Then
            MessageBox.Show(GlobalClass.FieldsNotValidMessage, "Check Locations!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If

        Select Case Me.NextLoc
            Case "WASH"
                RaiseEvent SetNextLoc(Me.NextLoc, karservices.cactus.smartclient.DropDestType.WASH)
            Case Else
                RaiseEvent SetNextLoc(Me.NextLoc, karservices.cactus.smartclient.DropDestType.DOOR)
        End Select

        If Me.RecallRequired = True Then
            Select Case Me.ThirdLoc
                Case "WASH"
                    RaiseEvent SetThirdLoc(Me.ThirdLoc, karservices.cactus.smartclient.DropDestType.WASH)
                Case Else
                    RaiseEvent SetThirdLoc(Me.ThirdLoc, karservices.cactus.smartclient.DropDestType.DOOR)
            End Select
        Else
            RaiseEvent SetThirdLoc("NA", karservices.cactus.smartclient.DropDestType.DOOR)
        End If
        Me.Close()
    End Sub

    Private Function VerifyFields() As Boolean
        Dim Ans As Boolean = True
        If Me.RecallRequired = True Then
            If Me.ThirdLoc = "" Then Ans = False
        Else
            Me.ThirdLoc = "NA"
        End If

        If Me.NextLoc = "" Then Ans = False
        Return Ans
    End Function
End Class