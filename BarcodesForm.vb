Imports KAR_Lot_SmartClient.GlobalClass

Public Class BarcodesForm

    Dim MyBD As karservices.cactus.smartclient.BarcodeDataSet

#Region " Form Methods "

    Private Sub BarcodesForm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub
    Private Sub BarcodesForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ClearBarcodeLookupFields()
        Me.ClearNewBarcodeFields()
        Me.LoadReferenceDataBackgroundWorker.RunWorkerAsync()
    End Sub
    Private Sub LookupBarcodeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LookupBarcodeButton.Click
        If NetworkConnected Then
            Me.ToolStripProgressBar1.Enabled = True
            Me.MessageStatusLabel.Text = "Please Wait, Looking up Barcode..."
            Me.Refresh()
            Me.InvokeBarcodeLookup()
        Else
            MainForm.AlertUser("Cannot Lookup Barcodes, No Connection!", MainForm.AlertMethod.ShowWithMessageBox)
        End If
    End Sub
    Private Sub InvokeBarcodeLookup()
        Me.BarcodeDataTextBox.Text = Me.BarcodeDataTextBox.Text.ToUpper
        If Me.IsBarcodeValid(Me.BarcodeDataTextBox.Text) Then Me.Invoke(New EventHandler(AddressOf BarcodeLookup))
    End Sub
    Private Sub BarcodeLookup(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim BarcodeData(2) As String
        Try
            BarcodeData = KarCactusWebBasic.BarcodeLookup(Me.BarcodeDataTextBox.Text)
        Catch ex As Exception
            MainForm.AlertUser("A problem occured while looking up the barcode! Try to lookup the barcode again. If the error continues contact tech support...", MainForm.AlertMethod.ShowWithExceptionData, ex)
            Me.CarrierNameLabel.Text = ""
            Me.TrailerIDLabel.Text = ""
            Me.BarcodeDataTextBox.Text = ""
            Me.ToolStripProgressBar1.Enabled = False
            Me.MessageStatusLabel.Text = "A problem occured while looking up the barcode!"
            Return
        End Try
        Me.BarcodeDataLabel.Text = Me.BarcodeDataTextBox.Text.ToUpper
        If BarcodeData(0) = "NO RECORD FOUND" Then
            Me.CarrierNameLabel.Text = "No Record Found"
            Me.TrailerIDLabel.Text = "Barcode is not Assigned to a Trailer!"
            Me.MessageStatusLabel.Text = "No Record Found"
        Else
            Me.CarrierNameLabel.Text = BarcodeData(2)
            Me.TrailerIDLabel.Text = BarcodeData(1)
            Me.MessageStatusLabel.Text = "Done"
        End If
        Me.ToolStripProgressBar1.Enabled = False
    End Sub

    'Public Function IsBarcodeValid(ByVal BarcodeData As String) As Boolean
    '    If BarcodeData.ToUpper.StartsWith("KAR") Then
    '        Return True
    '    Else
    '        MessageBox.Show("Make sure barcode is a Kar Lot barcode!")
    '        Return False
    '    End If
    'End Function

    Private Function IsBarcodeValid(ByVal BarcodeData As String) As Boolean
        Dim PassFlag As Boolean = True ' ASSUME VALID. ENTIRE TEST FAILS IF ONE TEST FAILS
        Dim ToInt As Integer = 0
        Dim TempBarcode As String = ""
        Dim Prefix As String = BarcodeData.Substring(0, 3)
        'CHECK THE PREFIX
        If Prefix <> "KAR" Then PassFlag = False
        ' CHECK THE NUMERICAL PORTION. IS IT A NUMBER?
        Try
            ToInt = CInt(BarcodeData.Substring(3))
        Catch ex As Exception
            PassFlag = False
        End Try
        ' CHECK THE LENGTH OF THE STRING. IT SHOULD BE AT LEAST 8 CHARS LONG
        If BarcodeData.Trim.Length < 8 Then PassFlag = False
        ' REBUILD THE BARCODE FROM THE PIECES AND MAKE SURE IT MATCHES
        TempBarcode = "KAR" & IIf(ToInt.ToString.Length < 5, ToInt.ToString.PadLeft(5, "0"), ToInt.ToString)
        If TempBarcode <> BarcodeData Then PassFlag = False

        Return PassFlag
    End Function


    Private Sub ClearBarcodeLookupFields()
        Me.BarcodeDataTextBox.Text = ""
        Me.BarcodeDataLabel.Text = ""
        Me.CarrierNameLabel.Text = ""
        Me.TrailerIDLabel.Text = ""
        Me.MessageStatusLabel.Text = ""
    End Sub
    Private Sub BarcodesTabControl_Selecting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TabControlCancelEventArgs) Handles BarcodesTabControl.Selecting
        Select Case e.TabPage.Name
            Case "BarcodeLookupTabPage"
                Me.ClearBarcodeLookupFields()
                Me.BarcodeDataTextBox.Focus()
            Case "AssignBarcodesTabPage"

        End Select
    End Sub

    Private Sub SetupBindings()
        Me.CarrierNameComboBox.DataSource = Me.MyBD.Carriers
        Me.CarrierNameComboBox.DisplayMember = "Carrier"
        Me.CarrierNameComboBox.ValueMember = "scac"
        Me.CarrierNameComboBox.Refresh()
    End Sub
    Private Sub SaveBarcodeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveBarcodeButton.Click
        If MainForm.ActiveConnection Then
            If Me.IsNewBarcodeFieldsValid Then
                Me.MessageStatusLabel.Text = GlobalClass.GettingDataMessage
                Me.ToolStripProgressBar1.Visible = True
                Me.DoNewBarcodeButtons(ButtonModes.Saving)
                Me.Refresh()
                Me.SaveBarcodeBackgroundWorker.RunWorkerAsync()
            Else
                Me.MessageStatusLabel.Text = GlobalClass.FieldsNotValidMessage
            End If
        Else
            Me.MessageStatusLabel.Text = GlobalClass.NotConnectedAlert
            MainForm.AlertUser(GlobalClass.NotConnectedAlert, MainForm.AlertMethod.ShowWithFriendlyUI)
        End If
    End Sub
    Private Function IsNewBarcodeFieldsValid() As Boolean
        Dim Ans As Boolean = True
        Dim cmdIndex As Integer = 0
        If Me.CarrierNameComboBox.Text.Length = 0 Then
            Ans = False
        Else
            If Me.CarrierNameComboBox.FindStringExact(Me.CarrierNameComboBox.Text) = -1 Then
                Ans = False
            End If
        End If
        If Me.ScacCodeTextBox.Text.Length = 0 Then
            Ans = False
        Else
            Me.ScacCodeTextBox.Text = Me.ScacCodeTextBox.Text.Trim.ToUpper()
        End If
        If Me.TrailerNumberTextBox.Text.Length = 0 Then
            Ans = False
        Else
            Me.TrailerNumberTextBox.Text = Me.TrailerNumberTextBox.Text.Trim.ToUpper()
        End If
        If Me.NewBarcodeTextBox.Text.Length > 0 Then
            Me.NewBarcodeTextBox.Text = Me.NewBarcodeTextBox.Text.Trim.ToUpper()
            Ans = Me.IsBarcodeValid(Me.NewBarcodeTextBox.Text)
        Else
            Ans = False
        End If
        Return Ans
    End Function
    Private Sub DoNewBarcodeButtons(ByVal State As ButtonModes)
        Select Case State
            Case ButtonModes.Normal
                Me.SaveBarcodeButton.Enabled = True
                Me.CancelSaveBarcodeButton.Enabled = False
            Case ButtonModes.AllLocked
                Me.SaveBarcodeButton.Enabled = False
                Me.CancelSaveBarcodeButton.Enabled = False
            Case ButtonModes.Editing
                Me.SaveBarcodeButton.Enabled = True
                Me.CancelSaveBarcodeButton.Enabled = False
            Case ButtonModes.Saving
                Me.SaveBarcodeButton.Enabled = False
                Me.CancelSaveBarcodeButton.Enabled = True
        End Select
    End Sub
    Private Sub CancelSaveBarcodeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelSaveBarcodeButton.Click
        'Me.SaveBarcodeBackgroundWorker.CancelAsync()
    End Sub
    Private Sub CarrierNameComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CarrierNameComboBox.SelectedIndexChanged
        Me.ScacCodeTextBox.Text = Me.CarrierNameComboBox.SelectedValue.ToString
    End Sub
    Public Sub ClearNewBarcodeFields()
        Me.NewBarcodeTextBox.Text = ""
        Me.TrailerNumberTextBox.Text = ""
    End Sub
#End Region

#Region " Background Worker Methods "
    Private Sub LoadReferenceDataBackgroundWorker_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles LoadReferenceDataBackgroundWorker.DoWork
        Dim DBs As New DataServices
        Me.MyBD = DBs.GetDataFromCache(DataServices.TableOptions.Carriers, False)
    End Sub
    Private Sub LoadReferenceDataBackgroundWorker_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles LoadReferenceDataBackgroundWorker.RunWorkerCompleted
        Me.SetupBindings()
        Me.ToolStripProgressBar1.Visible = False
    End Sub

    Private Sub SaveBarcodeBackgroundWorker_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles SaveBarcodeBackgroundWorker.DoWork
        Me.SaveBarcodeBackgroundWorker.ReportProgress(25)
        Dim TheReturn(2) As String
        ' CHECK TO SEE IF THE BARCODE IS ACTIVE ALREADY
        TheReturn = KarCactusWebBasic.BarcodeLookup(Me.NewBarcodeTextBox.Text)
        If TheReturn(0) = "NO RECORD FOUND" Then
            Me.SaveBarcodeBackgroundWorker.ReportProgress(50)
            TheReturn = KarCactusWebBasic.NewBarcode(Me.NewBarcodeTextBox.Text.Trim, Me.ScacCodeTextBox.Text.Trim, Me.TrailerNumberTextBox.Text.Trim)
            Me.SaveBarcodeBackgroundWorker.ReportProgress(75)
            e.Result = TheReturn
        Else
            Me.SaveBarcodeBackgroundWorker.ReportProgress(75)
            TheReturn(0) = "ERROR"
            TheReturn(1) = ""
            TheReturn(2) = "Barcode is already assigned..."
            e.Result = TheReturn
        End If
        Me.SaveBarcodeBackgroundWorker.ReportProgress(100)
    End Sub
    Private Sub SaveBarcodeBackgroundWorker_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles SaveBarcodeBackgroundWorker.ProgressChanged
        If Me.ToolStripProgressBar1.Visible = False Then Me.ToolStripProgressBar1.Visible = True
        Me.MessageStatusLabel.Text = GlobalClass.SavingDataMessage & " (" & e.ProgressPercentage & "%)"
    End Sub
    Private Sub SaveBarcodeBackgroundWorker_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles SaveBarcodeBackgroundWorker.RunWorkerCompleted
        Dim TheReturn(2) As String
        TheReturn = e.Result
        If TheReturn(0) = "ERROR" Then
            Me.MessageStatusLabel.Text = TheReturn(2)
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
        Else
            Me.ClearNewBarcodeFields()
            Me.MessageStatusLabel.Text = "Barcode Saved... " & GlobalClass.ProcessDoneMessage
        End If
        Me.ToolStripProgressBar1.Visible = False
        Me.DoNewBarcodeButtons(ButtonModes.Normal)
    End Sub
#End Region

End Class