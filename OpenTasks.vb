Public Class OpenTasks

    Dim MyWebService As New KAR_Lot_SmartClient.karservices.cactus.smartclient.kar_smartclient_webservice
    Dim SelectedTaskID As Integer = 0

#Region " Form Methods "
    Private Sub ClearFields()
        Me.PriorityLevelDisplayLabel.Text = ""
        Me.CarrierNameLabel.Text = ""
        Me.TrailerIDLabel.Text = ""
        Me.PalletTypeLabel.Text = ""
    End Sub
    Private Sub UserTasks_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub
    Private Sub UserTasks_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.ClearFields()
        Me.MyWebService.Url = GlobalClass.KarCactusWeb.Url
        AddHandler MyWebService.GetAllOpenTasksCompleted, AddressOf Me.GetTasksComplete
        AddHandler MyWebService.AssignTaskToUserCompleted, AddressOf Me.TakeTaskCompleted
        Me.MyWebService.GetAllOpenTasksAsync(Guid.NewGuid)
    End Sub
    Private Sub FillListView(ByVal TaskDS As KAR_Lot_SmartClient.karservices.cactus.smartclient.TasksDataSet)
        Dim TaskItem As ListViewItem

        For Each MyTask As KAR_Lot_SmartClient.karservices.cactus.smartclient.TasksDataSet.TasksRow In TaskDS.Tasks
            TaskItem = New ListViewItem
            With TaskItem
                .ImageKey = MyTask.Type
                .Text = ""
                .Tag = MyTask.TaskID
                Me.TaskListView.Items.Add(TaskItem)
            End With
        Next
        Me.TaskListView.Refresh()
    End Sub
    Private Sub ShowTask(ByVal TaskID As Integer)
        Dim MyRow As Data.DataRowView
        Me.ClearFields()
        Me.TasksBindingSource.Filter = "TaskID = " & TaskID
        MyRow = Me.TasksBindingSource.Item(0)
        If MyRow("trailerrelated") = True Then
            Me.TrailerGroupBox.Enabled = True
            Me.CarrierNameLabel.Text = MyRow("Carrier")
            Me.TrailerIDLabel.Text = MyRow("TrailerID")
            Me.PalletTypeLabel.Text = MyRow("PalletType")
        Else
            Me.TrailerGroupBox.Enabled = False
            Me.CarrierNameLabel.Text = "NONE"
        End If

        Select Case MyRow.Item("PriorityLevel")
            Case "1"
                Me.PriorityLevelDisplayLabel.Text = "HIGH"
            Case "2"
                Me.PriorityLevelDisplayLabel.Text = "STANDARD"
        End Select
    End Sub
#End Region

#Region " Form Events "
    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub
    Private Sub TaskListView_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TaskListView.SelectedIndexChanged
        If Me.TaskListView.SelectedItems.Count > 0 Then
            Me.SelectedTaskID = Me.TaskListView.SelectedItems(0).Tag
            Me.ShowTask(Me.TaskListView.SelectedItems(0).Tag)
        End If
    End Sub
    Private Sub ActionButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActionButton.Click
        If Me.SelectedTaskID > 0 Then
            Dim MyGuid As Guid
            MyGuid = Guid.NewGuid
            Me.ActionButton.Enabled = False
            Me.CloseButton.Enabled = False
            Me.Cursor = Cursors.WaitCursor
            Try
                Me.MyWebService.AssignTaskToUserAsync(Me.SelectedTaskID, GlobalClass.MyUser.UserName, MyGuid)
            Catch ex As Exception
                Me.ActionButton.Enabled = True
                Me.CloseButton.Enabled = True
                Me.Cursor = Cursors.Default
                MessageBox.Show("Error updating task. Please try again...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End Try
        Else
            MessageBox.Show("Task not selected. Select a task first...", "Task Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End If
    End Sub
#End Region

#Region " Web Service Methods "
    Private Sub GetTasksComplete(ByVal sender As Object, ByVal e As KAR_Lot_SmartClient.karservices.cactus.smartclient.GetAllOpenTasksCompletedEventArgs)
        Dim MyTasksDS As KAR_Lot_SmartClient.karservices.cactus.smartclient.TasksDataSet
        MyTasksDS = e.Result
        Me.TasksBindingSource.DataSource = MyTasksDS
        Me.FillListView(MyTasksDS)
    End Sub
    Private Sub TakeTaskCompleted(ByVal sender As Object, ByVal e As KAR_Lot_SmartClient.karservices.cactus.smartclient.AssignTaskToUserCompletedEventArgs)
        If e.Result > 0 Then
            MainForm.UpdateTaskCounts()
            Me.Close()
        Else
            Me.Cursor = Cursors.Default
            Me.ActionButton.Enabled = True
            Me.CloseButton.Enabled = True
            MessageBox.Show("Task was not updated. Please try again...", "Task Not Updated", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End If
    End Sub
#End Region

End Class