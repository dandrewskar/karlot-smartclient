Imports KAR_Lot_SmartClient.GlobalClass

Public Class YardCheckDetail

    Dim ydt As New KAR_Lot_SmartClient.karservices.cactus.smartclient.kar_smartclient_webservice

    Private Sub YardCheckDetail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.StatusLabel.Text = ""
    End Sub

    Private m_YardCheckID As Integer
    Public Property YardCheckID() As Integer
        Get
            Return m_YardCheckID
        End Get
        Set(ByVal value As Integer)
            m_YardCheckID = value
            Me.StatusLabel.Text = GlobalClass.GettingDataMessage
            Me.Refresh()
            Me.YardCheckDetailsBindingSource.DataSource = GlobalClass.KarCactusWeb.GetYardCheckReview(Me.m_YardCheckID)
            Me.YardCheckDetailsBindingSource.DataMember = "YardCheckDetails"
        End Set
    End Property

End Class