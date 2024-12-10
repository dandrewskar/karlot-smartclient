Public Class CancelPrecoolRequestForm

    Dim mTasks As New KAR_Lot_SmartClient.karservices.cactus.smartclient.TasksDataSet
    Dim MyWS As KAR_Lot_SmartClient.karservices.cactus.smartclient.kar_smartclient_webservice
    Dim mSystemID As Integer
    Dim mUser As KAR_Lot_SmartClient.karservices.cactus.smartclient.KarLotUser
    Dim mMyGuid As New Guid
    Public Event PrecoolCancelled()

    Public Sub New(ByVal pUser As KAR_Lot_SmartClient.karservices.cactus.smartclient.KarLotUser, ByVal pSystemID As Integer, ByVal pWS As KAR_Lot_SmartClient.karservices.cactus.smartclient.kar_smartclient_webservice)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.MyWS = pWS
        Me.mSystemID = pSystemID
        Me.mUser = pUser

    End Sub

    Private Sub CancelPrecoolRequestForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Me.TasksDataSet = Me.MyWS.GetPrecoolingTasksByTrailerSystemID(Me.mSystemID)
            Me.TasksBindingSource.DataSource = Me.TasksDataSet
            Me.TasksBindingSource.CurrencyManager.Refresh()
        Catch ex As Exception
            MessageBox.Show("There was a problem looking up this trailer. Please try again.", "Kar Lot", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Me.Close()
        End Try
        'Me.TrailerListBox.DataSource = mTasks.Tasks
        'Me.TrailerListBox.DisplayMember = "TrailerID"
    End Sub

    Public Sub CancelPrecoolCompleted(ByVal sender As Object, ByVal e As KAR_Lot_SmartClient.karservices.cactus.smartclient.CancelPrecoolTaskCompletedEventArgs)
        Me.EnableButtons()

        If e.Cancelled Then Exit Sub

        If e.Error IsNot Nothing Then
            MessageBox.Show(e.Error.Message)
            Exit Sub
        End If

        If e.Result = True Then
            RaiseEvent PrecoolCancelled()
            Me.Close()
        End If
    End Sub
    Private Sub MyOKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyOKButton.Click
        If Me.CancelRequestVerifyCheckBox.Checked = False Then Exit Sub

        Try
            Me.DisableButtons()
            Dim mTaskID As Integer = CType(Me.TasksBindingSource.Current, System.Data.DataRowView).Row.Item("TaskID")
            Me.MyWS.CancelPrecoolTaskAsync(Me.mUser, mTaskID, mMyGuid)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Me.EnableButtons()
        End Try
    End Sub
    Private Sub EnableButtons()
        Me.MyOKButton.Enabled = True
    End Sub
    Private Sub DisableButtons()
        Me.MyOKButton.Enabled = False
    End Sub
End Class