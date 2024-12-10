Imports KarLot.Tasking
Imports KarLot.UserAlerting

Public Class TaskTextingForm

    Private argsArray() As karservices.cactus.smartclient.TaskTextArgTO
    Private argsList As New List(Of IklTaskTextArgument)
    Private taskItems As New karservices.cactus.smartclient.TaskTextDataSet.TaskTextDataTable
    Private mTask As klTaskText
    Private mTaskTextController As klTaskController
    Private myGuid As Guid = Guid.NewGuid
    Private myWS As New karservices.cactus.smartclient.kar_smartclient_webservice
    Private mCompletedTaskText As String = String.Empty
    Private DEFAULT_TASK_PRIORITY_LEVEL As Integer = 2

#Region "Form Event Code"
    Private Sub TaskTextingForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        ' remove the event handlers
        For Each ctr As Control In Me.TaskTextFlowLayoutPanel.Controls
            If TypeOf (ctr) Is Button Then
                Dim bttn As Button = CType(ctr, Button)
                RemoveHandler bttn.Click, AddressOf Me.TaskTextButton_Click
            End If
        Next

        If Me.mTask IsNot Nothing Then RemoveHandler mTask.CompletedText, AddressOf Me.TaskText

    End Sub
    Private Sub TaskTextingForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.myWS.Url = GlobalClass.KarCactusWeb.Url
        Me.GetLists()
        Me.LoadButtons()
        Me.SetupUI()
        Me.WireUp()
    End Sub
    Private Sub TaskTextButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' get reference to the object from the buttons tag property
        mTask = CType(CType(sender, Button).Tag, klTaskText)
        ' since this object may have been used before we need to clear the args
        mTask.ClearArgs()
        ' if the controller has been used before we must call close to unhook previous event listners
        If Me.mTaskTextController IsNot Nothing Then Me.mTaskTextController.Close()
        ' setup a new controller for use with the objects
        mTaskTextController = New klTaskController(mTask, Me.KlTaskTextView1, Me.argsList)
        Me.Wizard1.Next()
        Me.SetWizardNextEnabled(False)
    End Sub
#End Region

#Region "Helper Methods"
    Private Sub SetupArgsList()
        For Each item As karservices.cactus.smartclient.TaskTextArgTO In argsArray
            Me.argsList.Add(New klTaskTextArgument(item.TaskTextType, item.ArgValue))
        Next
    End Sub
    Private Sub SetupUI()
        Me.TaskTextFlowLayoutPanel.Dock = DockStyle.Fill
        Me.SetWizardNextEnabled(False)
    End Sub
    Private Sub LoadButtons()
        Me.Cursor = Cursors.WaitCursor

        For Each row As karservices.cactus.smartclient.TaskTextDataSet.TaskTextRow In taskItems
            Dim bttn As New Button
            Dim t As klTaskText
            bttn.Name = row.Title
            bttn.Text = row.Title
            bttn.Width = 215
            bttn.Height = 25
            bttn.Tag = Me.TaskTextRowToObject(row)
            t = CType(bttn.Tag, klTaskText)
            AddHandler t.CompletedText, AddressOf Me.TaskText
            Me.TaskTextFlowLayoutPanel.Controls.Add(bttn)
            AddHandler bttn.Click, AddressOf Me.TaskTextButton_Click
        Next

        Me.Cursor = Cursors.Default
    End Sub
    Private Sub WireUp()
        AddHandler myWS.AddBasicTaskCompleted, AddressOf AddBasicTaskCompleted
    End Sub
    Private Function TaskTextRowToObject(ByVal row As karservices.cactus.smartclient.TaskTextDataSet.TaskTextRow) As klTaskText
        Dim TaskTextObject As New klTaskText(row.Title, row.FormatString, row.AlertMessage)
        Return TaskTextObject
    End Function
    Private Sub SetWizardNextEnabled(ByVal pSet As Boolean)
        Me.Wizard1.NextEnabled = pSet
    End Sub
    Private Sub TaskText(ByVal pText As String)
        ' event tied to this method fires as the task test is being built
        ' as long as an empty string is passed then the task text is not
        ' completed.
        If pText = String.Empty Then
            Me.SetWizardNextEnabled(False)
        Else
            Me.SetWizardNextEnabled(True)
        End If
        ' assign the local variable
        Me.mCompletedTaskText = pText
    End Sub
    Private Sub UserRespondedToLoadException(ByVal ex As IklMessage)
        ' no matter the response we close and the user has to start over.
        Me.Close()
    End Sub
#End Region

#Region "Web Service Methods"
    Private Sub GetLists()
        Me.UseWaitCursor = True

        Try
            Me.argsArray = myWS.GetTaskArgsList()
            Me.taskItems = myWS.GetTaskTextItems()
            Me.SetupArgsList()
        Catch ex As Exception
            Dim msg As New klExceptionMessage("There was a problem while downloading some data.", ex, GlobalClass.MyUser.UserName)
            Dim msgForm As New klMessageForm()
            Dim ctr As New klMessageController(msg, msgForm)
            AddHandler ctr.ReportUserResponse, AddressOf UserRespondedToLoadException
            msgForm.ShowDialog(Me)
        Finally
            Me.UseWaitCursor = False
        End Try
    End Sub
    Private Sub AddBasicTaskCompleted(ByVal sender As Object, ByVal e As KAR_Lot_SmartClient.karservices.cactus.smartclient.AddBasicTaskCompletedEventArgs)
        Me.Cursor = Cursors.Default
        Me.ProgressBar1.Style = ProgressBarStyle.Continuous
        Me.ProgressBar1.Value = 100

        If e.Result = 0 Then
            Me.ResultMessageDetailsLabel.Text = "ERROR OCCURED, CHECK YOUR INFORMATION AND TRY AGAIN..."
            Me.ResultMessageFriendlyLabel.Text = "Task could not be saved."
        Else
            Me.ResultMessageDetailsLabel.Text = "Your task message has been sent."
            Me.ResultMessageFriendlyLabel.Text = Me.mCompletedTaskText
            Me.Wizard1.BackEnabled = False
        End If
    End Sub

#End Region

    Private Sub TaskSaved_ShowFromNext(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TaskSaved.ShowFromNext
        Me.Cursor = Cursors.WaitCursor
        Me.ProgressBar1.Style = ProgressBarStyle.Marquee
        Me.Wizard1.BackEnabled = False
        Me.ResultMessageFriendlyLabel.Text = "Saving Task, Please Wait..."
        Me.ResultMessageDetailsLabel.Text = String.Empty
        myWS.AddBasicTaskAsync(Me.mCompletedTaskText, GlobalClass.MyUser.UserName, Me.DEFAULT_TASK_PRIORITY_LEVEL, Me.myGuid)
    End Sub
End Class