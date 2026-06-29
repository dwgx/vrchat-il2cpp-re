// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Steamworks.Data
// Classes: 42
// Methods: 91

namespace ThirdParty.Other.Steamworks.Data
{
    public class ScreenshotHandle : ValueType
    {
        public object Value;

        // ── Methods ──
        public void op_Implicit(){} // RVA: 0x294E720
        public void ToString(){} // RVA: 0x145060
        public void GetHashCode(){} // RVA: 0x77E60
        public void Equals(){} // RVA: 0x14F640
        public void CompareTo(){} // RVA: 0x14F650
    }

    public class ScreenshotReady_t : ValueType
    {
        public object Local;
        public object Result;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14C390
        public void .cctor(){} // RVA: 0x2956D20
    }

    public class ScreenshotRequested_t : ValueType
    {
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14C3A0
        public void .cctor(){} // RVA: 0x2956E00
    }

    public class SearchForGameProgressCallback_t : ValueType
    {
        public object LSearchID;
        public object Result;
        public object LobbyID;
        public object SteamIDEndedSearch;
        public object SecondsRemainingEstimate;
        public object CPlayersSearching;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x147110
        public void .cctor(){} // RVA: 0x2953840
    }

    public class SearchForGameResultCallback_t : ValueType
    {
        public object LSearchID;
        public object Result;
        public object CountPlayersInGame;
        public object CountAcceptedGame;
        public object SteamIDHost;
        public object FinalCallback;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x147120
        public void .cctor(){} // RVA: 0x2953920
    }

    public class SetPersonaNameResponse_t : ValueType
    {
        public object Success;
        public object LocalSuccess;
        public object Result;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x146E00
        public void .cctor(){} // RVA: 0x2952320
    }

    public class SetUserItemVoteResult_t : ValueType
    {
        public object PublishedFileId;
        public object Result;
        public object VoteUp;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14C890
        public void .cctor(){} // RVA: 0x2958840
    }

    public class Socket : ValueType
    {
        public object Id;

        // ── Methods ──
        public void ToString(){} // RVA: 0x145060
    }

    public class StartPlaytimeTrackingResult_t : ValueType
    {
        public object Result;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14C8B0
        public void .cctor(){} // RVA: 0x2958A00
    }

    public class SteamAPICallCompleted_t : ValueType
    {
        public object AsyncCall;
        public object Callback;
        public object ParamCount;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x146FF0
        public void .cctor(){} // RVA: 0x2952890
    }

    public class SteamAppInstalled_t : ValueType
    {
        public object AppID;
        public object InstallFolderIndex;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14CD50
        public void .cctor(){} // RVA: 0x29592C0
    }

    public class SteamAppUninstalled_t : ValueType
    {
        public object AppID;
        public object InstallFolderIndex;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14CD60
        public void .cctor(){} // RVA: 0x29593A0
    }

    public class SteamInputConfigurationLoaded_t : ValueType
    {
        public object AppID;
        public object DeviceHandle;
        public object MappingCreator;
        public object MajorRevision;
        public object MinorRevision;
        public object UsesSteamInputAPI;
        public object UsesGamepadAPI;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14C500
        public void .cctor(){} // RVA: 0x2958140
    }

    public class SteamInputDeviceConnected_t : ValueType
    {
        public object ConnectedDeviceHandle;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14C4E0
        public void .cctor(){} // RVA: 0x2957F80
    }

    public class SteamInputDeviceDisconnected_t : ValueType
    {
        public object DisconnectedDeviceHandle;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14C4F0
        public void .cctor(){} // RVA: 0x2958060
    }

    public class SteamInventoryDefinitionUpdate_t : ValueType
    {
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14D810
        public void .cctor(){} // RVA: 0x295AA60
    }

    public class SteamInventoryEligiblePromoItemDefIDs_t : ValueType
    {
        public object Result;
        public object SteamID;
        public object UmEligiblePromoItemDefs;
        public object CachedData;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14D820
        public void .cctor(){} // RVA: 0x295AB40
    }

    public class SteamInventoryFullUpdate_t : ValueType
    {
        public object Handle;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14D800
        public void .cctor(){} // RVA: 0x295A980
    }

    public class SteamInventoryRequestPricesResult_t : ValueType
    {
        public object Result;
        public object Currency;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14D990
        public void .cctor(){} // RVA: 0x295AD00
    }

    public class SteamInventoryResultReady_t : ValueType
    {
        public object Handle;
        public object Result;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14D7F0
        public void .cctor(){} // RVA: 0x295A8A0
    }

    public class SteamInventoryResult_t : ValueType
    {
        public object Value;

        // ── Methods ──
        public void op_Implicit(){} // RVA: 0x294E720
        public void ToString(){} // RVA: 0x14F670
        public void GetHashCode(){} // RVA: 0x77E60
        public void Equals(){} // RVA: 0x14F640
        public void CompareTo(){} // RVA: 0x14F6F0
    }

    public class SteamInventoryStartPurchaseResult_t : ValueType
    {
        public object Result;
        public object OrderID;
        public object TransID;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14D830
        public void .cctor(){} // RVA: 0x295AC20
    }

    public class SteamNetAuthenticationStatus_t : ValueType
    {
        public object Avail;
        public object DebugMsg;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14DFF0
        public void .cctor(){} // RVA: 0x295B4E0
    }

    public class SteamNetConnectionStatusChangedCallback_t : ValueType
    {
        public object Conn;
        public object Nfo;
        public object OldState;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14DE50
        public void .cctor(){} // RVA: 0x295B400
    }

    public class SteamNetworkingFakeIPResult_t : ValueType
    {
        public object Result;
        public object Dentity;
        public object IP;
        public object Ports;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14EB70
        public void .cctor(){} // RVA: 0x295C120
    }

    public class SteamNetworkingMessagesSessionFailed_t : ValueType
    {
        public object Nfo;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14DCD0
        public void .cctor(){} // RVA: 0x295B320
    }

    public class SteamNetworkingMessagesSessionRequest_t : ValueType
    {
        public object DentityRemote;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14DB90
        public void .cctor(){} // RVA: 0x295B240
    }

    public class SteamNetworkingPOPID : ValueType
    {
        public object Value;

        // ── Methods ──
        public void ToString(){} // RVA: 0x145060
        public void GetHashCode(){} // RVA: 0x77E60
        public void Equals(){} // RVA: 0x14F640
        public void CompareTo(){} // RVA: 0x14F650
    }

    public class SteamParentalSettingsChanged_t : ValueType
    {
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14DB60
        public void .cctor(){} // RVA: 0x295AFA0
    }

    public class SteamRelayNetworkStatus_t : ValueType
    {
        public object Avail;
        public object PingMeasurementInProgress;
        public object AvailNetworkConfig;
        public object AvailAnyRelay;
        public object DebugMsg;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14E1B0
        public void .cctor(){} // RVA: 0x295B5C0
    }

    public class SteamRemotePlaySessionConnected_t : ValueType
    {
        public object SessionID;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14DB70
        public void .cctor(){} // RVA: 0x295B080
    }

    public class SteamRemotePlaySessionDisconnected_t : ValueType
    {
        public object SessionID;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14DB80
        public void .cctor(){} // RVA: 0x295B160
    }

    public class SteamServerConnectFailure_t : ValueType
    {
        public object Result;
        public object StillRetrying;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x145380
        public void .cctor(){} // RVA: 0x29504B0
    }

    public class SteamServersConnected_t : ValueType
    {
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x145370
        public void .cctor(){} // RVA: 0x29503D0
    }

    public class SteamServersDisconnected_t : ValueType
    {
        public object Result;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x145390
        public void .cctor(){} // RVA: 0x2950590
    }

    public class SteamShutdown_t : ValueType
    {
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x147000
        public void .cctor(){} // RVA: 0x2952970
    }

    public class SteamUGCQueryCompleted_t : ValueType
    {
        public object Handle;
        public object Result;
        public object NumResultsReturned;
        public object TotalMatchingResults;
        public object CachedData;
        public object NextCursor;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14C6D0
        public void .cctor(){} // RVA: 0x2958220
    }

    public class SteamUGCRequestUGCDetailsResult_t : ValueType
    {
        public object Details;
        public object CachedData;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14C830
        public void .cctor(){} // RVA: 0x2958300
    }

    public class StopPlaytimeTrackingResult_t : ValueType
    {
        public object Result;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14C8C0
        public void .cctor(){} // RVA: 0x2958AE0
    }

    public class StoreAuthURLResponse_t : ValueType
    {
        public object URL;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x145750
        public void .cctor(){} // RVA: 0x2950E70
    }

    public class SubmitItemUpdateResult_t : ValueType
    {
        public object Result;
        public object UserNeedsToAcceptWorkshopLegalAgreement;
        public object PublishedFileId;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14C850
        public void .cctor(){} // RVA: 0x29584C0
    }

    public class SubmitPlayerResultResultCallback_t : ValueType
    {
        public object Result;
        public object UllUniqueGameID;
        public object SteamIDPlayer;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x147160
        public void .cctor(){} // RVA: 0x2953CA0
    }

}