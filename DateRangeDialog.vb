Imports System.Windows.Forms

Public Class DateRangeDialog

    Public Event SetDates(ByVal pStartDate As DateTime, ByVal pEndDate As DateTime)

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        RaiseEvent SetDates(Me.StartDateTimePicker.Value, Me.EndDateTimePicker.Value)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Public Property HeaderText() As String
        Get
            Return Me.HeaderLabel.Text
        End Get
        Set(ByVal value As String)
            Me.HeaderLabel.Text = value
        End Set
    End Property

End Class
