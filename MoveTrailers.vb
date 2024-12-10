Public Class MoveTrailers
    ' USED IN DOBUTTONS METHOD
    Public Enum ButtonModes
        Normal = 0
        Saving = 1
        Editing = 2
        AllLocked = 3
    End Enum

#Region " Main Methods "
    Private Sub MoveTrailers_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.DoRender()
        Me.SetupForm()
    End Sub
    Private Sub DoRender()
        Me.StatusStrip1.Renderer = MainForm.StatusStrip1.Renderer
        Me.MessageToolStripStatusLabel.ForeColor = Color.White
    End Sub
    ''' <summary>
    ''' This methods displays a message in the status control at the bottom of the form.
    ''' If using to update the status on a long running process use the OriginalMessage
    ''' parameter when calling first, then for each additional update the AdditionalMessage
    ''' parameter is appended to the originial message. Set Reset to True when finished
    ''' to clear the original message.
    ''' </summary>
    ''' <param name="AdditionalMessage"></param>
    ''' <param name="OriginalMessage"></param>
    ''' <param name="Reset"></param>
    ''' <remarks></remarks>
    Private Sub ShowStatusMessage(ByVal AdditionalMessage As String, Optional ByVal OriginalMessage As String = "", Optional ByVal Reset As Boolean = False)
        If Reset Then
            Me.MessageToolStripStatusLabel.Tag = ""
            Me.MessageToolStripStatusLabel.Text = AdditionalMessage
            Exit Sub
        End If
        ' SET THE ORIGINAL MESSAGE IN THE TAG PROPERTY
        If OriginalMessage > "" Then Me.MessageToolStripStatusLabel.Tag = OriginalMessage
        ' PULL THE ORIGINAL MESSAGE FROM THE TAG PROPERTY AND APPEND ADDITIONAL MESSAGE DATA
        Me.MessageToolStripStatusLabel.Text = Me.MessageToolStripStatusLabel.Tag & AdditionalMessage
    End Sub
    Private Sub DoButtons(ByVal ButtonMode As ButtonModes, ByVal ButtonGroup As String)

    End Sub
    Private Sub SetupForm()

    End Sub
    Private Sub TextBoxGotFocus()

    End Sub
    Private Sub TextBoxLostFocus()

    End Sub
    Private Sub ResetVariables()

    End Sub
    Private Sub WireUpData()

    End Sub
    Private Sub UpdateProgress()

    End Sub
    Private Sub VerifyValues()

    End Sub
#End Region

#Region " Form Control Methods "

#End Region

#Region " Helper Methods "

#End Region

End Class