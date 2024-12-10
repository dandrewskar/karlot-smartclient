Imports KAR_Lot_SmartClient.GlobalClass

Public Class YardCheckReview

    Private Sub ViewDetailsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewDetailsButton.Click
        Me.StatusLabel.Text = GlobalClass.GettingDataMessage

        Me.Refresh()
        Dim myDetails As New YardCheckDetail
        myDetails.YardCheckID = Me.YardCheckDataGridView.CurrentRow.Cells.Item(1).Value
        myDetails.ShowDialog()

        Me.StatusLabel.Text = ""
    End Sub

    Private Sub YardCheckReview_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.YardCheckBindingSource.DataSource = GlobalClass.KarCactusWeb.GetYardCheckRefData()
        Me.YardCheckBindingSource.DataMember = "YardCheck"
        Me.StatusLabel.Text = ""
    End Sub
End Class