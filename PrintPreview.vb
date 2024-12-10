Public Class PrintPreview
    Dim MyWebService As New KAR_Lot_SmartClient.karservices.cactus.smartclient.kar_smartclient_webservice
    Dim MyActiveTrailers As New KAR_Lot_SmartClient.karservices.cactus.smartclient.ActiveTrailerDataSet
    Dim MyCompleteMovesDS As KAR_Lot_SmartClient.karservices.cactus.smartclient.MovesDataSet
    Dim MyGuid As Guid = Guid.NewGuid

    Public Sub New(ByVal pWebUrl As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.MyWebService.Url = pWebUrl
    End Sub
    Private Sub PrintPreview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        AddHandler Me.MyWebService.GetActiveTrailersDatasetCompleted, AddressOf Me.GetActiveTrailersComplete
        AddHandler MyWebService.GetCompletedMovesByDateCompleted, AddressOf Me.GetCompletedMovesDataComplete
        'If Me.m_PrintDS Is Nothing Then Throw New System.Exception("No data source was provided!")
        ''Me.ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("BarcodeDataSet_CactusSpecific", Me.m_PrintDS.CactusSpecific))
        'Me.ReportViewer1.LocalReport.ReportEmbeddedResource = Me.m_ReportFile
        'Select Case Me.m_ReportFile
        '    Case "KAR_Lot_SmartClient.ActiveTrailerList.rdlc"
        '        Me.ReportViewer1.LocalReport.EnableExternalImages = False
        '        Me.ReportViewer1.LocalReport.DataSources.Clear()
        '        Me.ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("BarcodeDataSet_ActiveTrailers", Me.m_PrintDS.ActiveTrailers))
        '    Case "KAR_Lot_SmartClient.Report1.rdlc"
        '        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        '        Me.ReportViewer1.LocalReport.DataSources.Clear()
        '        Me.ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("BarcodeDataSet_CactusSpecific", Me.m_PrintDS.CactusSpecific))
        'End Select
        ''Me.ReportViewer1.LocalReport.DataSources.Item(0).Value = Me.m_PrintDS.CactusSpecific
        'Me.ReportViewer1.RefreshReport()
    End Sub

#Region " Public Properties "
    Private m_ReportFile As String
    Public Property ReportFile() As String
        Get
            Return m_ReportFile
        End Get
        Set(ByVal value As String)
            m_ReportFile = value
        End Set
    End Property

    Private m_ReportStartDate As DateTime
    Public Property ReportStartDate() As DateTime
        Get
            Return m_ReportStartDate
        End Get
        Set(ByVal value As DateTime)
            m_ReportStartDate = value
        End Set
    End Property

    Private m_ReportEndDate As DateTime
    Public Property ReportEndDate() As DateTime
        Get
            Return m_ReportEndDate
        End Get
        Set(ByVal value As DateTime)
            m_ReportEndDate = value
        End Set
    End Property

#End Region

    Private Sub SetReportDates(ByVal pStartDate As DateTime, ByVal pEndDate As DateTime)
        Me.ReportStartDate = pStartDate
        Me.ReportEndDate = pEndDate
    End Sub

    Public Sub RunReport(ByVal sender As Object, ByVal pReportName As String)
        Me.Show(sender)
        Me.ReportFile = pReportName
        Try
            Me.ReportViewer1.LocalReport.ReportEmbeddedResource = Me.ReportFile
        Catch ex As Exception
            MessageBox.Show("Report file is not valid. Check the report and try again...", "KAR Lot", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Me.Close()
        End Try
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)

        Select Case pReportName
            Case "KAR_Lot_SmartClient.ActiveTrailerList.rdlc"
                Me.MyWebService.GetActiveTrailersDatasetAsync()
            Case "KAR_Lot_SmartClient.TrailerMoveLog.rdlc"
                Dim GetDatesForm As New DateRangeDialog
                AddHandler GetDatesForm.SetDates, AddressOf Me.SetReportDates
                GetDatesForm.HeaderText = "Trailer Moves Log Report"
                GetDatesForm.ShowDialog(Me)
                If GetDatesForm.DialogResult = System.Windows.Forms.DialogResult.OK Then
                    Me.MyWebService.GetCompletedMovesByDateAsync(Me.ReportStartDate, Me.ReportEndDate, MyGuid)
                Else
                    Me.Close()
                End If
            Case Else
                Throw New Exception("A report must be specified...")
        End Select
    End Sub

    Private Sub GetActiveTrailersComplete(ByVal sender As Object, ByVal e As KAR_Lot_SmartClient.karservices.cactus.smartclient.GetActiveTrailersDatasetCompletedEventArgs)
        If e.Error IsNot Nothing Then
            MessageBox.Show(e.Error.Message, "Problem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Me.Cursor = Cursors.Default
            Exit Sub
        End If

        If e.Cancelled = True Then
            Me.Cursor = Cursors.Default
            Exit Sub
        End If


        Select Case Me.ReportFile
            Case "KAR_Lot_SmartClient.ActiveTrailerList.rdlc"
                Try
                    Me.MyActiveTrailers = e.Result
                Catch ex As Exception
                    Me.Cursor = Cursors.Default
                    Me.Close()
                End Try

                Me.ShowActiveTrailerReport()

            Case Else
                Throw New Exception("A report must be specified...")

        End Select

    End Sub
    Private Sub ShowActiveTrailerReport()

        Me.ReportViewer1.LocalReport.EnableExternalImages = False
        Me.ReportViewer1.LocalReport.DataSources.Clear()
        Me.ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("ActiveTrailerDataSet_Trailers", Me.MyActiveTrailers.Trailers))
        Me.ReportViewer1.RefreshReport()

        Me.ReportViewer1.Visible = True
        Me.WaitPictureBox.Visible = False
        Me.Refresh()
    End Sub

    Private Sub GetCompletedMovesDataComplete(ByVal sender As Object, ByVal e As KAR_Lot_SmartClient.karservices.cactus.smartclient.GetCompletedMovesByDateCompletedEventArgs)
        If e.Error IsNot Nothing Then
            MessageBox.Show(e.Error.Message, "Problem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Me.Cursor = Cursors.Default
            Exit Sub
        End If

        If e.Cancelled = True Then
            Me.Cursor = Cursors.Default
            Exit Sub
        End If

        Select Case Me.ReportFile
            Case "KAR_Lot_SmartClient.TrailerMoveLog.rdlc"
                Try
                    Me.MyCompleteMovesDS = e.Result
                Catch ex As Exception
                    Me.Cursor = Cursors.Default
                    Me.Close()
                End Try

                Me.ShowCompletedMovesReport()

            Case Else
                Throw New Exception("A report must be specified...")

        End Select

    End Sub
    Private Sub ShowCompletedMovesReport()
        Me.ReportViewer1.LocalReport.EnableExternalImages = False
        Me.ReportViewer1.LocalReport.DataSources.Clear()
        Me.ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("MovesDataSet_TrailerMoves", Me.MyCompleteMovesDS.TrailerMoves))
        Me.ReportViewer1.RefreshReport()

        Me.ReportViewer1.Visible = True
        Me.WaitPictureBox.Visible = False
        Me.Refresh()

    End Sub
End Class


