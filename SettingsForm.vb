Public Class SettingsForm

    Private Sub ApplyMainSettingsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApplyMainSettingsButton.Click
        Try
            My.Settings.DataExportPath = Me.DataExportPathTextbox.Text
            My.Settings.DataCacheDirectory = Me.DataCachePathTextbox.Text
            My.Settings.ConnectionType = Me.ConnectionTypeComboBox.Text
            My.Settings.StationID = Me.TruckIDTextBox.Text.Trim
            My.Settings.WashMode = Me.WashModeComboBox.Text
            My.Settings.EnhancedTasking = Me.EnhancedTaskingCheckBox.Checked
            My.Settings.AllowTrailerCheckInOut = Me.AllowCheckInOutCheckBox.Checked
            My.Settings.AllowBarcodeActivation = Me.AllowBarcodeActivationCheckBox.Checked
            My.Settings.Save()
        Catch ex As Exception
            MessageBox.Show("Could not save settings.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Private Sub ApplyNetworkSettingsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApplyNetworkSettingsButton.Click
        Try
            My.Settings.BasicWebServicePath = Me.LocalWebServiceURLTextBox.Text
            My.Settings.EnhancedWebServicePath = Me.RemoteWebServiceURLTextBox.Text
            My.Settings.RemoteWebServer = Me.RemoteServerTextBox.Text
            My.Settings.RemoteServerPort = Me.RemoteServerPortTextBox.Text
            My.Settings.LocalKarLotServer = Me.LocalServerIPTextBox.Text
            My.Settings.LocalServerPort = Me.LocalServerPortTextBox.Text
            My.Settings.HttpsRemote = Me.HttpsCheckboxRemote.Checked
            My.Settings.BackgroundURL = Me.BackgroundImageTextBox.Text
            My.Settings.LayoutURL = Me.LayoutFilePathTextBox.Text
            My.Settings.ApiBaseURL = Me.ApiBaseUrlTextBox.Text
            My.Settings.Save()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Could not save settings.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Private Sub ApplyDataSettingsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApplyDataSettingsButton.Click
        Try
            My.Settings.CarriersCacheFile = Me.CarriersCacheFileNameTextBox.Text
            My.Settings.InboundSheetCacheFile = Me.InboundSheetCacheFileTextBox.Text
            My.Settings.ActiveTrailersCacheFile = Me.ActiveTrailersCacheFileTextBox.Text
            My.Settings.Save()
        Catch ex As Exception
            MessageBox.Show("Could not save settings.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

End Class