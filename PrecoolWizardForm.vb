Public Class PrecoolWizardForm

    Dim MyWS As KAR_Lot_SmartClient.karservices.cactus.smartclient.kar_smartclient_webservice
    Dim MyTrailer As KAR_Lot_SmartClient.karservices.cactus.smartclient.PreCoolTrailerTO
    Dim MyMode As Int16
    Dim MyCurrentPanel As Int16 = 0
    Dim StartDate As DateTime
    Dim StartTemp As String

    Public Event StartPrecool(ByVal StartInstructions As String, ByVal pStartDate As DateTime, ByVal pStartTemp As String, ByVal pTrailer As KAR_Lot_SmartClient.karservices.cactus.smartclient.PreCoolTrailerTO, ByVal pNotifyEmail As String)


    Public Sub New(ByVal pMode As Int16, ByVal pWebService As KAR_Lot_SmartClient.karservices.cactus.smartclient.kar_smartclient_webservice, ByVal pTrailer As KAR_Lot_SmartClient.karservices.cactus.smartclient.PreCoolTrailerTO)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.MyWS = pWebService
        Me.MyTrailer = pTrailer
        Me.MyMode = pMode
    End Sub
    Private Sub PrecoolWizardForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.ClearDisplayFields()
        Me.HideAllPanels()
        Me.SetupFirstScreen()
        Me.SetFormText()
    End Sub

#Region " UI Code "
    Private Sub SetFormText()
        Select Case Me.MyMode
            Case 0
                Me.Text = "KAR Lot - Start Unit"
            Case 1
                Me.Text = "KAR Lot - Turn Unit Off"
        End Select
    End Sub
    Private Sub HideAllPanels()
        Me.StartPanel1.Visible = False
    End Sub
    Private Sub ShowNextStartPrecoolPanel()
        Select Case Me.MyCurrentPanel
            Case 0
                Me.SetDefaultStartDateTime()
                Me.CarrierNameLabel.Text = Me.MyTrailer.Carrier
                Me.TrailerIDLabel.Text = Me.MyTrailer.TrailerID
                Me.StartPanel1.Visible = True
                Me.StartSetPointTextBox.Text = ""
            Case 1
                Me.StartPanel1.Visible = False
        End Select
        Me.MyCurrentPanel += 1
    End Sub
    Private Sub SetupFirstScreen()
        Select Case Me.MyMode
            Case 0 ' Start Precool Wizard
                Me.ShowNextStartPrecoolPanel()
            Case 1 ' Stop Precool Wizard

        End Select
    End Sub
    Private Sub ClearDisplayFields()
        Me.CarrierNameLabel.Text = ""
        Me.TrailerIDLabel.Text = ""
    End Sub
    Private Sub SetDefaultStartDateTime()
        Me.StartDateTimePicker.Value = Now.Date
        Me.StartHourComboBox.Text = Now.Hour.ToString
        Me.StartMinuteComboBox.Text = Now.Minute.ToString
    End Sub
#End Region

#Region " Form Control Events "
    Private Sub Start1CancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Start1CancelButton.Click
        Me.Close()
    End Sub
    Private Sub Start1NextButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Start1NextButton.Click
        If Me.VerifyStartPrecoolFields Then
            Dim tempString As String = String.Format("{0}{1}", ToSafeString(Me.StartTemp), ToSafeString(Me.TempTypeComboBox.Text))
            RaiseEvent StartPrecool(Me.StartInstructionsTextBox.Text.Trim, Me.StartDate, tempString, Me.MyTrailer, String.Empty)
            Me.Close()
        Else
            MessageBox.Show("Make sure all fields are filled in first. If you entered an email address check to make sure you typed it correctly", "KAR Lot", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End If
    End Sub
#End Region

#Region " Helper Methods "
    Private Function VerifyStartPrecoolFields() As Boolean
        Try
            StartDate = Me.StartDateTimePicker.Value.Month.ToString & "/" & Me.StartDateTimePicker.Value.Day.ToString & "/" & Me.StartDateTimePicker.Value.Year.ToString & " " & Me.StartHourComboBox.Text.Trim & ":" & Me.StartMinuteComboBox.Text.Trim
            StartTemp = Me.StartSetPointTextBox.Text.Trim
        Catch ex As Exception
            Return False
        End Try

        Return True
    End Function
    Private Function ToSafeString(ByVal value As String) As String
        Return IIf(value Is Nothing, String.Empty, value.Trim)
    End Function
#End Region
End Class