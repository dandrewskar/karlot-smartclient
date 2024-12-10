Imports KAR_Lot_SmartClient.GlobalClass

Public Class Cactus

    Public MyCactusDataSet As karservices.cactus.smartclient.BarcodeDataSet

    Private Sub Cctus_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Dim t As MyColorTable = New MyColorTable
        'Me.CactusSpecificBindingNavigator.Renderer = New ToolStripProfessionalRenderer(t)
        'Me.StatusStrip1.Renderer = New ToolStripProfessionalRenderer(t)

        If My.Computer.FileSystem.FileExists("c:\inbound.xml") Then
            Me.MyCactusDataSet = New karservices.cactus.smartclient.BarcodeDataSet
            Me.MyCactusDataSet.ReadXml("c:\inbound.xml")
            Me.CactusSpecificBindingSource.DataSource = MyCactusDataSet
            Me.CactusSpecificBindingSource.Sort = "SequenceID ASC"
        Else
            Me.GetDataBackgroundWorker.WorkerReportsProgress = True
            Me.GetDataBackgroundWorker.RunWorkerAsync()
        End If
    End Sub

    Private Sub GetDataBackgroundWorker_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles GetDataBackgroundWorker.DoWork
        Me.GetDataBackgroundWorker.ReportProgress(25)
        MyCactusDataSet = KarCactusWeb.GetInboundSheet
        Me.GetDataBackgroundWorker.ReportProgress(75)
        MyCactusDataSet.WriteXml("c:\inbound.xml")
        Me.GetDataBackgroundWorker.ReportProgress(100)
    End Sub

    Private Sub GetDataBackgroundWorker_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles GetDataBackgroundWorker.ProgressChanged
        If Me.ToolStripProgressBar.Visible = False Then Me.ToolStripProgressBar.Visible = True
        Me.ToolStripProgressBar.Value = e.ProgressPercentage
    End Sub

    Private Sub GetDataBackgroundWorker_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles GetDataBackgroundWorker.RunWorkerCompleted
        Me.CactusSpecificBindingSource.DataSource = MyCactusDataSet
        Me.CactusSpecificBindingSource.ResetBindings(False)
        Me.ToolStripProgressBar.Value = 0
        Me.ToolStripProgressBar.Visible = False
    End Sub

    Private Sub PrintToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripButton.Click
        Dim MyFilteredDS As New karservices.cactus.smartclient.BarcodeDataSet
        'Dim MyRow As karservices.cactus.smartclient.BarcodeDataSet.CactusSpecificRow
        ' TODO: Fix Inbound Form loading data
        'MyRow = MyCactusDataSet.CactusSpecific.FindBySequenceId(CInt(Me.SequenceIDTextBox.Text))
        'If MyRow Is Nothing Then
        '    MessageBox.Show("Error finding Row!")
        '    Exit Sub
        'End If
        'MyFilteredDS.CactusSpecific.Rows.Add(MyRow.ItemArray)

        ''MyFilteredDS.CactusSpecific.Select("SequenceID = '" & Me.SequenceIDTextBox.Text & "'")
        ''PrintPreview.PrintDS = MyFilteredDS
        ''PrintPreview.ShowDialog()
    End Sub

    Private Sub RefreshDataToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshDataToolStripButton.Click
        ' GET THE DATA FROM THE SERVER
        Me.GetDataBackgroundWorker.WorkerReportsProgress = True
        Me.GetDataBackgroundWorker.RunWorkerAsync()
    End Sub

    Private Sub BuildSigs(ByVal DriverSig As String, ByVal SecuritySig As String)
        Dim DefaultImage As New Bitmap(352, 188)
        'DefaultImage = LoadImage("nosig.bmp")
        Dim BlankSig As New Bitmap(352, 188)
        'BlankSig = LoadImage("blanksig.bmp")
        Dim MySig As SignatureData
        Dim gSig As Graphics

        If DriverSig.Length = 0 Then
            DefaultImage.Save("c:\drsig.bmp")
        Else
            Me.DriverSigPictureBox.Image = BlankSig
            MySig = New SignatureData(DriverSig)
            gSig = Graphics.FromImage(Me.DriverSigPictureBox.Image)
            'gSig = Graphics.FromImage(LoadImage("blanksig.bmp"))
            gSig = MySig.DrawSignature(gSig, Me.DriverSigPictureBox)
            Me.DriverSigPictureBox.Refresh()
            Me.DriverSigPictureBox.Image.Save("c:\drsig.bmp")
        End If

        If SecuritySig.Length = 0 Then
            DefaultImage.Save("c:\scsig.bmp")
        Else
            Me.SecurityPictureBox.Image = BlankSig
            MySig = New SignatureData(SecuritySig)
            gSig = Graphics.FromImage(Me.SecurityPictureBox.Image)
            'gSig = Graphics.FromImage(LoadImage("blanksig.bmp"))
            gSig = MySig.DrawSignature(gSig, Me.SecurityPictureBox)
            Me.SecurityPictureBox.Refresh()
            Me.SecurityPictureBox.Image.Save("c:\scsig.bmp")
        End If
    End Sub

    ' Return embedded bitmap resource.
    Public Shared Function LoadImage(ByVal imageName As String) As Bitmap
        Try
            Return New Bitmap(System.Reflection.Assembly.GetExecutingAssembly(). _
             GetManifestResourceStream("KAR_Lot_SmartClient." + imageName))
        Catch ex As Exception
            Throw New System.IO.FileNotFoundException("The Image file cannot be found!")
        End Try
    End Function

    Private Sub CactusSpecificBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CactusSpecificBindingSource.PositionChanged
        Dim MyRow As DataRowView
        MyRow = Me.CactusSpecificBindingSource.Current
        Me.BuildSigs(MyRow.Item("DriverSig").ToString, MyRow.Item("SecuritySig").ToString)
    End Sub

    Private Sub SecurityPictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SecurityPictureBox.Click

    End Sub
End Class


'
'
' THIS CLASS HOLDS THE DATA FOR A SIGNATURE
' IT PARSES THE DATA FROM A STRING
Public Class SignatureData
    Public Const SignatureId As String = "Signature details" & ControlChars.Lf
    Public Const SegmentID As String = "Number of Segments : "
    Dim CharIndex As Int16 = 0
    Dim SegmentCount As Int16 = 0
    Dim CurrentSegment As Int16 = 0
    Private SigData As String = ""
    Public SigX As Int16 = 0
    Public SigY As Int16 = 0
    Public Sub New(ByVal Data As String)
        Dim x As Int16 = 0
        ' set the sigdata property. It is used in other methods
        SigData = Data
        If Me.IsDataValid() = False Then Throw New Exception("Signature Data is Not Valid!")
        Me.GetSegmentCount()
        For x = 1 To SegmentCount
            Me.GetNextSegmentPoints()
            Me.Parse2Points()
        Next
        ' PAD THE EDGES A LITTLE
        SigX += 10
        SigY += 10
    End Sub
    Private Sub Parse2Points()
        Dim StringPoints() As String
        Dim TempData As String
        Dim TempPoint(1) As String
        Dim x As Int16 = 0
        CharIndex = SigData.IndexOf(ControlChars.Lf)
        If CharIndex = -1 Then
            TempData = SigData.Trim
        Else
            TempData = SigData.Substring(0, CharIndex - 1)
        End If
        StringPoints = TempData.Split(" ")
        SigData = SigData.Remove(0, CharIndex + 1)
        Dim Points(StringPoints.Length - 1) As Point
        For Each sPoint As String In StringPoints
            TempData = sPoint.Substring(1, sPoint.Length - 2)
            TempPoint = TempData.Split(",")
            Points(x).X = CInt(TempPoint(0))
            If Points(x).X > Me.SigX Then SigX = Points(x).X
            Points(x).Y = CInt(TempPoint(1))
            If Points(x).Y > Me.SigY Then SigY = Points(x).Y
            x += 1
        Next
        Me.m_LineSegments.Add(Points)
    End Sub

    Private m_LinePointCount As New ArrayList
    Public Property LinePointCount() As ArrayList
        Get
            Return m_LinePointCount
        End Get
        Set(ByVal value As ArrayList)
            m_LinePointCount = value
        End Set
    End Property
    Private m_LineSegments As New ArrayList
    Public Property Lines() As ArrayList
        Get
            Return m_LineSegments
        End Get
        Set(ByVal value As ArrayList)
            m_LineSegments = value
        End Set
    End Property
    Private Sub GetNextSegmentPoints()
        If SigData.IndexOf(SegmentID, 0) = 0 Then
            Dim PointCount(1) As Int16
            SigData = SigData.Remove(0, SegmentID.Length)
            CharIndex = SigData.IndexOf(" ", 0)
            PointCount(0) = CInt(SigData.Substring(0, CharIndex).Trim)
            SigData = SigData.Remove(0, CharIndex + 2)
            CharIndex = SigData.IndexOf(" ", 0)
            PointCount(1) = CInt(SigData.Substring(0, CharIndex).Trim)
            SigData = SigData.Remove(0, CharIndex + 9)
            Me.m_LinePointCount.Add(PointCount)
        End If
    End Sub
    Private Sub GetSegmentCount()
        If SigData.IndexOf(SegmentID, 0) = 0 Then
            SigData = SigData.Remove(0, SegmentID.Length)
            CharIndex = SigData.IndexOf(ControlChars.Lf, 0)
            SegmentCount = CInt(SigData.Substring(0, CharIndex).Trim)
            SigData = SigData.Remove(0, CharIndex + 1)
        End If
    End Sub
    Private Function IsDataValid() As Boolean
        If Not SigData.StartsWith(SignatureId) Then
            Return False
        Else
            ' remove the SigID
            SigData = SigData.Remove(0, SignatureId.Length)
            Return True
        End If
    End Function

    Public Function DrawSignature(ByVal g As Graphics, ByVal PictSignature As PictureBox) As Graphics
        ' background
        g.Clear(Color.White)

        ' border
        g.DrawRectangle(Pens.Gray, 0, 0, 351, 187)

        ' '' return if don't have a signature
        ''If _signature Is Nothing Then
        ''    Return
        ''End If

        If Me.SigX = 0 Or Me.SigY = 0 Then
            Return Nothing
        End If

        ' setup drawing surface
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        '' scale the signature
        Dim matrix As New Drawing2D.Matrix
        matrix.Scale( _
         CSng(351) / CSng(Me.SigX), _
         CSng(187) / CSng(Me.SigY))
        g.Transform = matrix

        ' draw each line segment
        Dim line As Point()
        For Each line In Me.Lines
            If Not line Is Nothing Then
                If line.Length > 0 Then
                    ' draw curves
                    g.DrawCurve(Pens.Black, line, 0.5F)
                End If
            End If
        Next line
        Return g
    End Function

End Class
