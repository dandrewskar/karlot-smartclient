Public Class ApiDataConverter
    Public Shared Function ConvertToWebServiceTrailer(ByRef results As KlDispatchServices.ViewModels.TrailerSearchResultViewModel) As List(Of KAR_Lot_SmartClient.karservices.cactus.smartclient.Trailer)
        Dim trailers As New List(Of KAR_Lot_SmartClient.karservices.cactus.smartclient.Trailer)

        For Each t As KlDispatchServices.Models.Trailer In results.Trailers
            Dim wt As New KAR_Lot_SmartClient.karservices.cactus.smartclient.Trailer
            With wt
                .Active = t.Active
                .Barcode = t.Barcode
                .CalloutUserInitials = String.Empty
                .Carrier = New KAR_Lot_SmartClient.karservices.cactus.smartclient.Carrier()
                .Classification = t.Classification
                .CleanState = t.CleanState
                .CurrentLocation = t.CurrentLocation
                .ExceptionCode = t.ExceptionCode
                .ExceptionCodeDescription = t.ExceptionCodeDescription
                .HasException = t.HasException
                .LastAction = t.LastAction
                .LastUser = t.LastUser
                .Load = New KAR_Lot_SmartClient.karservices.cactus.smartclient.TrailerLoadClass()
                .LoadNumber = t.LoadNumber
                .MoveID = t.MoveID
                .MoveStatus = t.MoveStatus
                .NextLocation = t.NextLocation
                .Notes = t.Notes
                .OutOfService = t.OutOfService
                .PalletsOnBoard = t.PalletsOnBoard
                .PalletsRequested = t.PalletsRequested
                .PreCooling = t.PreCooling
                .PreCoolRequested = t.PreCoolRequested
                .ReferUnitMode = t.ReferUnitMode
                .Seal1 = t.Seal1
                .Seal2 = t.Seal2
                .Seal3 = t.Seal3
                .SealException = t.SealException
                .SpecialInstructions = t.SpecialInstructions
                .SystemID = t.SystemID
                .Temperature = t.Temperature
                .ThirdLocation = t.ThirdLocation
                .TrailerAddedBy = t.TrailerAddedBy
                .TrailerAddedTime = t.TrailerAddedTime
                .TrailerID = t.TrailerID
                .TrailerOut = t.TrailerOut
                .TrailerOutBy = t.TrailerOutBy
                .TrailerType = t.TrailerType
                .WhosMove = t.WhosMove
                .Pallets = t.Pallets
                .SetPointCelsius = t.SetPointCelsius
            End With
            wt.Carrier.Name = t.Carrier
            wt.Carrier.Scac = t.SCAC
            wt.Load.dbCode = t.LoadStatus
            wt.Load.LoadStatusMessage = KlDispatchServices.ExtensionMethods.GetLoadStatusString(t.LoadStatus)
            trailers.Add(wt)
        Next

        Return trailers
    End Function
End Class

