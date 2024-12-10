Imports KAR_Lot_SmartClient.GlobalClass

Public Class DataServices
    Enum TableOptions
        Carriers = 0
        Trailers = 1
    End Enum

    Public Sub New()

    End Sub
    Public Function CacheFileExists(ByVal FilePath As String) As Boolean
        Return My.Computer.FileSystem.FileExists(FilePath)
    End Function
    Public Function GetCacheString(ByVal CacheFile As String) As String
        Return My.Settings.DataCacheDirectory & "\" & CacheFile
    End Function
    Public Function GetDataFromCache(ByVal Table As TableOptions, ByVal RefreshCacheFromServer As Boolean) As karservices.cactus.smartclient.BarcodeDataSet
        Dim CacheFile As String = ""
        Dim MyBD As New karservices.cactus.smartclient.BarcodeDataSet
        ' SETUP THE CACHE FILE TO BE PROCESSED
        Select Case Table
            Case TableOptions.Carriers
                CacheFile = Me.GetCacheString(My.Settings.CarriersCacheFile)
            Case TableOptions.Trailers
                CacheFile = Me.GetCacheString(My.Settings.ActiveTrailersCacheFile)
        End Select
        ' SEE IF THE CACHE FILE EXISTS AND PROCESS ACCORDINGLY
        If Me.CacheFileExists(CacheFile) Then
            ' CACHE FILE EXISTS. UPDATE IF REQUESTED
            If RefreshCacheFromServer Then
                MyBD = Me.GetBarcodeDataSetFromServer(Table)
                If MyBD IsNot Nothing Then MyBD.WriteXml(CacheFile)
            Else
                MyBD.ReadXml(CacheFile)
            End If
        Else
            ' CACHE FILE DOES NOT EXIST. TRY AND GET FROM SERVER
            MyBD = Me.GetBarcodeDataSetFromServer(Table)
            If MyBD IsNot Nothing Then MyBD.WriteXml(CacheFile)
        End If
        Return MyBD
    End Function
    Public Function GetBarcodeDataSetFromServer(ByVal Table As TableOptions) As karservices.cactus.smartclient.BarcodeDataSet
        Dim MyBD As New karservices.cactus.smartclient.BarcodeDataSet

        If MainForm.ActiveConnection Then
            Try
                Select Case Table
                    Case TableOptions.Carriers
                        MyBD = KarCactusWeb.GetCarrierList()
                    Case TableOptions.Trailers
                        MyBD = KarCactusWeb.GetKarData
                End Select
            Catch ex As Exception
                MainForm.AlertUser(GlobalClass.WebServiceErrorMessage, MainForm.AlertMethod.ShowWithExceptionData, ex)
            End Try
        End If

        Return MyBD
    End Function

End Class
