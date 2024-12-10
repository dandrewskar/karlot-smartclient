Public Class TaskRequest

#Region " Declarations "
    Dim MyWebService As New KAR_Lot_SmartClient.karservices.cactus.smartclient.kar_smartclient_webservice
    Dim TempGuid As Guid
    Dim Carriers() As KAR_Lot_SmartClient.karservices.cactus.smartclient.Carrier
    Dim Trailers() As KAR_Lot_SmartClient.karservices.cactus.smartclient.Trailer
    Dim IsLoading As Boolean = True

    Dim SelectedPalletType As String = ""
    Dim SelectedCarrier As String = ""
    Dim SelectedTrailerId As String = ""
    Dim InstructionText As String = ""
    Dim SelectedTaskType As TaskType
    Dim PriorityLevel As Integer = 0

    Private Enum TaskType
        BasicTask = 0
        PreLoadPalletsTask = 1
    End Enum

#End Region

#Region " Form Methods "
    Private Sub TaskRequest_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub
    Private Sub TaskRequest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MyWebService.Url = GlobalClass.KarCactusWeb.Url
        AddHandler MyWebService.GetActiveCarriersCompleted, AddressOf Me.GetCarriersCompleted
        AddHandler MyWebService.GetActiveTrailersByScacCompleted, AddressOf Me.GetTrailersCompleted
        AddHandler MyWebService.AddPalletTaskCompleted, AddressOf Me.AddPalletTaskCompleted
        AddHandler MyWebService.AddBasicTaskCompleted, AddressOf Me.AddBasicTaskCompleted
        Me.StartWizard()
        Me.GetCarriers()
    End Sub
    Private Sub PreLoadPalletsButton_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreLoadPalletsButton.MouseEnter
        Me.TaskPictureBox.Image = Me.ImageList1.Images.Item("Pallet")
        Me.TaskDescriptionLabel.Text = "Have a driver Pre-Load pallets on a trailer." & vbCrLf & vbCrLf & "Use this task if you need a trailer PRE-Loaded with pallets ahead of being called to a door. If you need this trailer moved to a door AND pallets setup at the same time then call the trailer to the door and set the pallets you need on the trailer request screen."
    End Sub
    Private Sub BasicTaskButton_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BasicTaskButton.MouseEnter
        Me.TaskPictureBox.Image = Me.ImageList1.Images.Item("Basic")
        Me.TaskDescriptionLabel.Text = "Have a driver perform a basic task." & vbCrLf & vbCrLf & "You can type in your instructions and have the task completed by a driver"
    End Sub
    Private Sub PreLoadPalletsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreLoadPalletsButton.Click
        Me.SelectedTaskType = TaskType.PreLoadPalletsTask
        Me.StartGroupBox.Visible = False
        Me.PreLoadPalletsGroupBox.Visible = True
    End Sub
    Private Sub CancelPalletTaskButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelPalletTaskButton.Click
        Me.InstructionsTextBox.Text = ""
        Me.StartWizard()
    End Sub
    Private Sub CarrierComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CarrierComboBox.SelectedIndexChanged
        If Me.IsLoading = True Then Exit Sub
        Try
            Me.Cursor = Cursors.WaitCursor
            Me.SelectedCarrier = Me.CarrierComboBox.Text
            Me.GetTrailers(Me.CarrierComboBox.SelectedValue.ToString)
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show("An error occured loading the trailers for this carrier. There was a problem connecting to the server, please try again. If you continue getting this error contact tech support.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub
    Private Sub TrailersListBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrailersListBox.SelectedIndexChanged
        If Me.TrailersListBox.SelectedItem IsNot Nothing Then
            Dim Trailer As KAR_Lot_SmartClient.karservices.cactus.smartclient.Trailer = Me.TrailersListBox.SelectedItem
            Me.SelectedTrailerId = Trailer.TrailerID.ToString
        End If
    End Sub
    Private Sub CancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyCancelButton.Click
        Me.Close()
    End Sub
    Private Sub HeatTreatedRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HeatTreatedRadioButton.CheckedChanged
        If Me.HeatTreatedRadioButton.Checked = True Then Me.SelectedPalletType = "Heat Treated"
    End Sub
    Private Sub ChepRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChepRadioButton.CheckedChanged
        If Me.ChepRadioButton.Checked = True Then Me.SelectedPalletType = "Chep"
    End Sub
    Private Sub WhitePalletsRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WhitePalletsRadioButton.CheckedChanged
        If Me.WhitePalletsRadioButton.Checked = True Then Me.SelectedPalletType = "White"
    End Sub
    Private Sub InstructionsTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InstructionsTextBox.TextChanged
        Me.InstructionText = Me.InstructionsTextBox.Text
    End Sub
    Private Sub SavePalletTaskButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SavePalletTaskButton.Click
        Me.SelectedCarrier = Me.CarrierComboBox.Text
        If Me.VerifyPalletTaskFields = True Then
            Me.SavePalletTaskButton.Enabled = False
            Me.CancelPalletTaskButton.Enabled = False
            Me.Cursor = Cursors.WaitCursor
            Dim MyGuid As Guid
            MyGuid = Guid.NewGuid
            Try
                Me.MyWebService.AddPalletTaskAsync(GlobalClass.MyUser.UserName, Me.InstructionText.Trim, Me.SelectedCarrier.Trim, Me.SelectedTrailerId.Trim, Me.SelectedPalletType, Me.PriorityLevel, MyGuid)
            Catch ex As Exception
                Me.SavePalletTaskButton.Enabled = True
                Me.CancelPalletTaskButton.Enabled = True
                Me.Cursor = Cursors.Default
                MessageBox.Show("Error saving task.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End Try
        Else
            MessageBox.Show("Make sure all fields are filled in correctly and try again", "Check Fields", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End If
    End Sub
    Private Sub BasicTaskButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BasicTaskButton.Click
        Me.SelectedTaskType = TaskType.BasicTask
        Me.StartGroupBox.Visible = False
        Me.PalletsNeededGroupBox.Visible = False
        Me.BasicTaskGroupBox.Visible = True
    End Sub
    Private Sub HighPriorityRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HighPriorityRadioButton.CheckedChanged
        If Me.HighPriorityRadioButton.Checked = True Then Me.PriorityLevel = 1
    End Sub
    Private Sub StandardPriorityRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StandardPriorityRadioButton.CheckedChanged
        If Me.StandardPriorityRadioButton.Checked = True Then Me.PriorityLevel = 2
    End Sub
    Private Sub SaveBasicTaskButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveBasicTaskButton.Click
        If Me.VerifyBasicTaskFields = True Then
            Me.SaveBasicTaskButton.Enabled = False
            Me.CancelBasicTaskButton.Enabled = False
            Me.Cursor = Cursors.WaitCursor
            Dim MyGuid As Guid
            MyGuid = Guid.NewGuid
            Try
                Me.MyWebService.AddBasicTaskAsync(Me.InstructionText.Trim, GlobalClass.MyUser.UserName, Me.PriorityLevel, MyGuid)
            Catch ex As Exception
                Me.SaveBasicTaskButton.Enabled = True
                Me.CancelBasicTaskButton.Enabled = True
                Me.Cursor = Cursors.Default
                MessageBox.Show("Error saving task.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End Try
        Else
            MessageBox.Show("Make sure all fields are filled in correctly and try again", "Check Fields", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End If
    End Sub
    Private Sub BasicHighRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BasicHighRadioButton.CheckedChanged
        If Me.BasicHighRadioButton.Checked = True Then Me.PriorityLevel = 1
    End Sub
    Private Sub BasicStandardRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BasicStandardRadioButton.CheckedChanged
        If Me.BasicStandardRadioButton.Checked = True Then Me.PriorityLevel = 2
    End Sub
    Private Sub BasicInstructionsTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BasicInstructionsTextBox.TextChanged
        Me.InstructionText = Me.BasicInstructionsTextBox.Text
    End Sub
    Private Sub CancelBasicTaskButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBasicTaskButton.Click
        Me.BasicInstructionsTextBox.Text = ""
        Me.StartWizard()
    End Sub
#End Region

#Region " Web Service Code "
    Private Sub GetCarriers()
        Me.Cursor = Cursors.WaitCursor
        TempGuid = New Guid
        Me.MyWebService.GetActiveCarriersAsync(TempGuid)
    End Sub
    Private Sub GetCarriersCompleted(ByVal sender As Object, ByVal e As KAR_Lot_SmartClient.karservices.cactus.smartclient.GetActiveCarriersCompletedEventArgs)
        Try
            Carriers = e.Result
            Me.CarrierComboBox.DataSource = Carriers
            Me.CarrierComboBox.DisplayMember = "Name"
            Me.CarrierComboBox.ValueMember = "Scac"
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show("An error occured loading the carriers. There may be a problem contacting the server. If you continue to get this message try restarting the program or contact tech support.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Me.Close()
        End Try
        ' LOAD THE TRAILERS FOR THE FIRST CARRIER IF THEIR IS ONE
        If Me.CarrierComboBox.Items.Count <= 0 Then
            Me.Cursor = Cursors.Default
            Exit Sub
        End If
        Try
            Me.Cursor = Cursors.WaitCursor
            Me.GetTrailers(Me.CarrierComboBox.SelectedValue.ToString)
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show("An error occured loading the trailers. There may be a problem contacting the server. If you continue to get this message try restarting the program or contact tech support.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Me.Close()
        End Try
    End Sub
    Private Sub GetTrailers(ByVal Scac As String)
        TempGuid = New Guid
        Me.MyWebService.GetActiveTrailersByScacAsync(Scac, TempGuid)
    End Sub
    Private Sub GetTrailersCompleted(ByVal sender As Object, ByVal e As KAR_Lot_SmartClient.karservices.cactus.smartclient.GetActiveTrailersByScacCompletedEventArgs)
        Try
            Me.Trailers = e.Result
            Me.TrailersListBox.DataSource = Me.Trailers
            Me.TrailersListBox.DisplayMember = "TrailerID"
            Me.TrailersListBox.ValueMember = "TrailerID"
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show("An error occured loading the trailers for this carrier.  Try selecting another carrier. If you continue getting this error please contact tech support.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
        Me.Cursor = Cursors.Default
        Me.IsLoading = False
    End Sub
    Private Sub AddPalletTaskCompleted(ByVal sender As Object, ByVal e As KAR_Lot_SmartClient.karservices.cactus.smartclient.AddPalletTaskCompletedEventArgs)
        If e.Result = 0 Then
            MessageBox.Show("Task could not be saved. Check the information and try again.", "Task Not Saved", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Me.Cursor = Cursors.Default
            Me.SavePalletTaskButton.Enabled = True
            Me.CancelPalletTaskButton.Enabled = True
        Else
            Me.Close()
        End If
    End Sub
    Private Sub AddBasicTaskCompleted(ByVal sender As Object, ByVal e As KAR_Lot_SmartClient.karservices.cactus.smartclient.AddBasicTaskCompletedEventArgs)
        If e.Result = 0 Then
            MessageBox.Show("Task could not be saved. Check the information and try again.", "Task Not Saved", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Me.Cursor = Cursors.Default
            Me.SaveBasicTaskButton.Enabled = True
            Me.CancelBasicTaskButton.Enabled = True
        Else
            Me.Close()
        End If
    End Sub
#End Region

#Region " Wizard Related Code "
    Private Sub StartWizard()
        Me.ClearFieldVariables()
        Me.StartGroupBox.Visible = True
        Me.PreLoadPalletsGroupBox.Visible = False
        Me.BasicTaskGroupBox.Visible = False
    End Sub
    Private Function VerifyPalletTaskFields() As Boolean
        If Me.SelectedCarrier = "" Then Return False
        If Me.SelectedPalletType = "" Then Return False
        If Me.SelectedTaskType = Nothing Then Return False
        If Me.SelectedTrailerId = "" Then Return False
        If Me.PriorityLevel = 0 Then Return False
        Return True
    End Function
    Private Function VerifyBasicTaskFields() As Boolean
        If Me.InstructionText.Trim.Length = 0 Then Return False
        If Me.PriorityLevel = 0 Then Return False
        Return True
    End Function
    Private Sub ClearFieldVariables()
        Me.ChepRadioButton.Checked = False
        Me.HeatTreatedRadioButton.Checked = False
        Me.WhitePalletsRadioButton.Checked = False
        If Me.CarrierComboBox.Items.Count > 0 Then Me.CarrierComboBox.SelectedIndex = 0
        Me.SelectedCarrier = ""
        Me.SelectedPalletType = ""
        Me.SelectedTaskType = Nothing
        Me.SelectedTrailerId = ""
        Me.InstructionText = ""
        Me.PriorityLevel = 0
    End Sub
#End Region

End Class