Imports System.Net
Imports System.IO
Imports System.Threading
Imports System.ComponentModel

Public Class KarLotFile

    Private httpReq As HttpWebRequest
    Private httpRes As HttpWebResponse
    Private mStream As System.IO.Stream
    Private TempStream As New MemoryStream
    Private WithEvents bWorker As New BackgroundWorker()
    Public Event ReportResults_MemoryStream(ByVal resultStream As MemoryStream, ByVal resultObj As Object)
    Public Event ReportResults_Binary(ByVal resultBinary As Byte(), ByVal resultObj As Object)
    Public Event AsyncProgess(ByVal percentProgress As Integer)

    Public Sub New(ByVal pFileURL As Uri)
        httpReq = WebRequest.Create(pFileURL)
        Me.InitializeComponent()
    End Sub

#Region "Public Methods"
    Public Sub Process()
        ' Run process without threading
        Dim i As Integer = 1

        While i <= 3
            Try
                Me.ProcessFile()
                ' if we make it here all is good, end the loop
                i = 4
            Catch ex As Exception
                If i >= 3 Then ' after 3 tries, give up
                    Throw
                Else
                    i += 1
                End If
            Finally
                Me.httpRes.Close()
            End Try
        End While
    End Sub
    Public Sub ProcessAsync()
        ' run process with threading. Results are dispatched through public events.
        Me.bWorker.RunWorkerAsync()
    End Sub
    Public Function GetURLDataBinary() As Byte()
        Return TempStream.ToArray()
    End Function
    Public Function GetStreamObject() As Stream
        Return TempStream
    End Function
#End Region

#Region "Private Methods"
    Private Sub InitializeComponent()
        bWorker.WorkerReportsProgress = True
        bWorker.WorkerSupportsCancellation = True
    End Sub
    Private Sub ProcessFile()
        Application.DoEvents() ' release for other events
        Me.httpRes = httpReq.GetResponse
        Me.mStream = httpRes.GetResponseStream
        Me.BuildBinaryData()
    End Sub
    Private Sub BuildBinaryData()
        'we must read data block-by-block  
        'Temporary Buffer and block size  
        Dim Buffer(4096) As Byte, BlockSize As Integer

        Do
            BlockSize = mStream.Read(Buffer, 0, 4096)
            If BlockSize > 0 Then TempStream.Write(Buffer, 0, BlockSize)
        Loop While BlockSize > 0
    End Sub
#End Region

#Region "Background Worker Methods"
    Private Sub bWorker_doWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bWorker.DoWork
        Dim i As Integer = 1
        Dim prg As Integer = 25

        Me.bWorker.ReportProgress(prg)

        While i <= 3
            Try
                Me.ProcessFile()
                ' if we make it here all is good, end the loop
                i = 4
                Me.bWorker.ReportProgress(100)
                e.Result = TempStream
            Catch ex As Exception
                If i >= 3 Then ' after 3 tries, give up
                    prg += 25
                    Me.bWorker.ReportProgress(prg)
                    e.Result = ex ' the result will be the exception
                    e.Cancel = True
                    Exit While
                Else
                    prg += 25
                    Me.bWorker.ReportProgress(prg)
                    i += 1
                End If
            Finally
                ' make sure to close the response object if it is not empty
                If Me.httpRes IsNot Nothing Then
                    Me.httpRes.Close()
                End If
            End Try
        End While
    End Sub
    Private Sub bWorker_reportProgress(ByVal sender As Object, ByVal e As ProgressChangedEventArgs) Handles bWorker.ProgressChanged
        RaiseEvent AsyncProgess(e.ProgressPercentage)
    End Sub
    Private Sub bWorker_workCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs) Handles bWorker.RunWorkerCompleted
        ' we will pass along the exception object in case an error occured
        RaiseEvent ReportResults_Binary(Me.TempStream.ToArray(), e.Error)
        RaiseEvent ReportResults_MemoryStream(Me.TempStream, e.Error)
    End Sub
#End Region

End Class
