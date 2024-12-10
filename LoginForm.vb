Imports KAR_Lot_SmartClient.GlobalClass
Imports System.Deployment.Application

Public Class LoginForm

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Dim MyKarWeb As New KAR_Lot_SmartClient.karservices.cactus.smartclient.kar_smartclient_webservice
    Private MyGuid As Guid

    Public Event UserAuth(ByVal pUser As KAR_Lot_SmartClient.karservices.cactus.smartclient.KarLotUser)

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        ' backdoor in for admin without network connection.
        If Me.UsernameTextBox.Text = "admin" And Me.PasswordTextBox.Text = "5point$" Then
            With MyUser
                .UserViewMode = "C"
                .UserAuthenticated = True
                .UserName = "admin"
                .UserLevel = "1"
                .FullName = "Administrator"
            End With
            RaiseEvent UserAuth(MyUser)
            Me.Close()
            Exit Sub
        End If

        If Me.UsernameTextBox.Text.Length > 4 And Me.PasswordTextBox.Text.Length > 3 Then
            Try
                Me.DoWait()
                Me.MyGuid = Guid.NewGuid
                Me.MyKarWeb.UseRackAsync(Me.UsernameTextBox.Text.Trim, Me.PasswordTextBox.Text.Trim, Me.MyGuid)
                'MainForm.MyUser = GlobalClass.KarCactusWeb.UseRack(Me.UsernameTextBox.Text.Trim, Me.PasswordTextBox.Text.Trim)
            Catch ex As Exception
                MessageBox.Show("There has been an error while starting Kar Lot, try starting the program again. If you continue to get this error contact tech support.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End Try
        Else
            MessageBox.Show("The username or password you entered is not correct. The program will now close and you can try again.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            End
        End If
    End Sub
    Private Sub DoWait()
        Me.OK.Enabled = False
        Me.OK.Text = "Please Wait"
        Me.Refresh()
        Me.WaitTimer.Start()
    End Sub
    Private Sub StopWait()
        Me.OK.Enabled = True
        Me.OK.Text = "I AGREE"
        Me.WaitTimer.Stop()
    End Sub
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        If Me.WaitTimer.Enabled = True Then
            Me.MyKarWeb.CancelAsync(Me.MyGuid)
            Me.StopWait()
        Else
            End
        End If
    End Sub

    Private Sub SettingsLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles SettingsLinkLabel.LinkClicked
        SettingsForm.ShowDialog()
    End Sub

    Private Sub LoginForm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub LoginForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If (ApplicationDeployment.IsNetworkDeployed) Then
            Dim AD As ApplicationDeployment = ApplicationDeployment.CurrentDeployment
            Me.VersionLabel.Text = AD.CurrentVersion.ToString
        Else
            Me.VersionLabel.Text = ""
        End If
        Me.MyKarWeb.Url = GlobalClass.KarCactusWeb.Url
        AddHandler MyKarWeb.UseRackCompleted, AddressOf Me.UseRackComplete
    End Sub

    Private Sub UseRackComplete(ByVal sender As Object, ByVal e As KAR_Lot_SmartClient.karservices.cactus.smartclient.UseRackCompletedEventArgs)
        If e.Error IsNot Nothing Then
            MessageBox.Show("An error occured loging into the web server. Check the application settings and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End
        End If
        Try
            If e.Result Is Nothing Then
                MessageBox.Show("User Nothing")
            End If
            MyUser = e.Result
            If MyUser.UserAuthenticated = True Then
                RaiseEvent UserAuth(MyUser)
                Me.WaitTimer.Stop()
                Me.Close()
            Else
                MessageBox.Show("The username or password you entered is not correct. The program will now close and you can try again.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                End
            End If
        Catch ex As Exception
            MessageBox.Show("An error has occured while trying to login." & vbCrLf & vbCrLf & ex.Message & vbCrLf & vbCrLf & "The program will now close and you can try again.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            End
        End Try
    End Sub

    Private Sub WaitTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WaitTimer.Tick
        MessageBox.Show("An problem has occured while trying to connect. The program will now close and you can try again.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End
    End Sub

    Private Sub ReadAgreementLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles ReadAgreementLinkLabel.LinkClicked
        Dim EulaForm As New EULA

        EulaForm.ShowDialog(Me)
    End Sub
End Class
