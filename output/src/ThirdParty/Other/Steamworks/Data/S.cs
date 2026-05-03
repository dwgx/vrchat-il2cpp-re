// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Steamworks.Data
// Classes: 45
// Methods: 94

namespace ThirdParty.Other.Steamworks.Data
{
    public class Screenshot : ValueType
    {
    }

    public class ScreenshotHandle : ValueType
    {
        // ── Methods ──
        public void op_Implicit(){} // RVA: 0x7FFE82E53610
        public void ToString(){} // RVA: 0x7FFE82E53600
        public void GetHashCode(){} // RVA: 0x7FFE826F4220
        public void Equals(){} // RVA: 0x7FFE82E64220 | overloaded x2
        public void CompareTo(){} // RVA: 0x7FFE82E64230
    }

    public class ScreenshotReady_t : ValueType
    {
        public uint Local; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E5D1E0
        public void .cctor(){} // RVA: 0x7FFE82E5D1F0
    }

    public class ScreenshotRequested_t : ValueType
    {
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E5D2F0
        public void .cctor(){} // RVA: 0x7FFE82E5D300
    }

    public class SearchForGameProgressCallback_t : ValueType
    {
        public ulong LSearchID; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E59220
        public void .cctor(){} // RVA: 0x7FFE82E59230
    }

    public class SearchForGameResultCallback_t : ValueType
    {
        public ulong LSearchID; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E59330
        public void .cctor(){} // RVA: 0x7FFE82E59340
    }

    public class SetPersonaNameResponse_t : ValueType
    {
        public bool Success; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E578B0
        public void .cctor(){} // RVA: 0x7FFE82E578C0
    }

    public class SetUserItemVoteResult_t : ValueType
    {
        public Steamworks.Data.PublishedFileId PublishedFileId; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E5F2D0
        public void .cctor(){} // RVA: 0x7FFE82E5F2E0
    }

    public class Socket : ValueType
    {
        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFE82E53600
    }

    public class StartPlaytimeTrackingResult_t : ValueType
    {
        public 0x666873EC Result; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E5F4F0
        public void .cctor(){} // RVA: 0x7FFE82E5F500
    }

    public class SteamAPICallCompleted_t : ValueType
    {
        public ulong AsyncCall; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E57F10
        public void .cctor(){} // RVA: 0x7FFE82E57F20
    }

    public class SteamAppInstalled_t : ValueType
    {
        public Steamworks.AppId AppID; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E5FF90
        public void .cctor(){} // RVA: 0x7FFE82E5FFA0
    }

    public class SteamAppUninstalled_t : ValueType
    {
        public Steamworks.AppId AppID; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E600A0
        public void .cctor(){} // RVA: 0x7FFE82E600B0
    }

    public class SteamInputConfigurationLoaded_t : ValueType
    {
        public Steamworks.AppId AppID; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E5EA50
        public void .cctor(){} // RVA: 0x7FFE82E5EA60
    }

    public class SteamInputDeviceConnected_t : ValueType
    {
        public ulong ConnectedDeviceHandle; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E5E830
        public void .cctor(){} // RVA: 0x7FFE82E5E840
    }

    public class SteamInputDeviceDisconnected_t : ValueType
    {
        public ulong DisconnectedDeviceHandle; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E5E940
        public void .cctor(){} // RVA: 0x7FFE82E5E950
    }

    public class SteamInventoryDefinitionUpdate_t : ValueType
    {
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E61C40
        public void .cctor(){} // RVA: 0x7FFE82E61C50
    }

    public class SteamInventoryEligiblePromoItemDefIDs_t : ValueType
    {
        public 0x666873EC Result; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E61D50
        public void .cctor(){} // RVA: 0x7FFE82E61D60
    }

    public class SteamInventoryFullUpdate_t : ValueType
    {
        public int Handle; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E61B30
        public void .cctor(){} // RVA: 0x7FFE82E61B40
    }

    public class SteamInventoryRequestPricesResult_t : ValueType
    {
        public 0x666873EC Result; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E61F70
        public void .cctor(){} // RVA: 0x7FFE82E61F80
    }

    public class SteamInventoryResultReady_t : ValueType
    {
        public int Handle; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E61A20
        public void .cctor(){} // RVA: 0x7FFE82E61A30
    }

    public class SteamInventoryResult_t : ValueType
    {
        // ── Methods ──
        public void op_Implicit(){} // RVA: 0x7FFE82E53610
        public void ToString(){} // RVA: 0x7FFE82E64250
        public void GetHashCode(){} // RVA: 0x7FFE826F4220
        public void Equals(){} // RVA: 0x7FFE82E64220 | overloaded x2
        public void CompareTo(){} // RVA: 0x7FFE82E642F0
    }

    public class SteamInventoryStartPurchaseResult_t : ValueType
    {
        public 0x666873EC Result; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E61E60
        public void .cctor(){} // RVA: 0x7FFE82E61E70
    }

    public class SteamItemDetails_t : ValueType
    {
    }

    public class SteamNetAuthenticationStatus_t : ValueType
    {
        public 0x66687A1C Avail; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E62900
        public void .cctor(){} // RVA: 0x7FFE82E62910
    }

    public class SteamNetConnectionStatusChangedCallback_t : ValueType
    {
        public Steamworks.Data.Connection Conn; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E627F0
        public void .cctor(){} // RVA: 0x7FFE82E62800
    }

    public class SteamNetworkingFakeIPResult_t : ValueType
    {
        public 0x666873EC Result; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E637E0
        public void .cctor(){} // RVA: 0x7FFE82E637F0
    }

    public class SteamNetworkingMessagesSessionFailed_t : ValueType
    {
        public Steamworks.Data.ConnectionInfo Nfo; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E626E0
        public void .cctor(){} // RVA: 0x7FFE82E626F0
    }

    public class SteamNetworkingMessagesSessionRequest_t : ValueType
    {
        public Steamworks.Data.NetIdentity DentityRemote; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E625D0
        public void .cctor(){} // RVA: 0x7FFE82E625E0
    }

    public class SteamNetworkingPOPID : ValueType
    {
        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFE82E53600
        public void GetHashCode(){} // RVA: 0x7FFE826F4220
        public void Equals(){} // RVA: 0x7FFE82E64220 | overloaded x2
        public void CompareTo(){} // RVA: 0x7FFE82E64230
    }

    public class SteamParentalSettingsChanged_t : ValueType
    {
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E622A0
        public void .cctor(){} // RVA: 0x7FFE82E622B0
    }

    public class SteamRelayNetworkStatus_t : ValueType
    {
        public 0x66687A1C Avail; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E62A10
        public void .cctor(){} // RVA: 0x7FFE82E62A20
    }

    public class SteamRemotePlaySessionConnected_t : ValueType
    {
        public uint SessionID; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E623B0
        public void .cctor(){} // RVA: 0x7FFE82E623C0
    }

    public class SteamRemotePlaySessionDisconnected_t : ValueType
    {
        public uint SessionID; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E624C0
        public void .cctor(){} // RVA: 0x7FFE82E624D0
    }

    public class SteamServerConnectFailure_t : ValueType
    {
        public 0x666873EC Result; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E55490
        public void .cctor(){} // RVA: 0x7FFE82E554A0
    }

    public class SteamServersConnected_t : ValueType
    {
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E55380
        public void .cctor(){} // RVA: 0x7FFE82E55390
    }

    public class SteamServersDisconnected_t : ValueType
    {
        public 0x666873EC Result; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E555A0
        public void .cctor(){} // RVA: 0x7FFE82E555B0
    }

    public class SteamShutdown_t : ValueType
    {
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E58020
        public void .cctor(){} // RVA: 0x7FFE82E58030
    }

    public class SteamUGCDetails_t : ValueType
    {
    }

    public class SteamUGCQueryCompleted_t : ValueType
    {
        public ulong Handle; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E5EB60
        public void .cctor(){} // RVA: 0x7FFE82E5EB70
    }

    public class SteamUGCRequestUGCDetailsResult_t : ValueType
    {
        public Steamworks.Data.SteamUGCDetails_t Details; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E5EC70
        public void .cctor(){} // RVA: 0x7FFE82E5EC80
    }

    public class StopPlaytimeTrackingResult_t : ValueType
    {
        public 0x666873EC Result; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E5F600
        public void .cctor(){} // RVA: 0x7FFE82E5F610
    }

    public class StoreAuthURLResponse_t : ValueType
    {
        public byte[] URL; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E56040
        public void .cctor(){} // RVA: 0x7FFE82E56050
    }

    public class SubmitItemUpdateResult_t : ValueType
    {
        public 0x666873EC Result; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E5EE90
        public void .cctor(){} // RVA: 0x7FFE82E5EEA0
    }

    public class SubmitPlayerResultResultCallback_t : ValueType
    {
        public 0x666873EC Result; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E59770
        public void .cctor(){} // RVA: 0x7FFE82E59780
    }

}