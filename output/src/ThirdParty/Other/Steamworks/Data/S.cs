// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Steamworks.Data
// Classes: 45
// Methods: 94

namespace ThirdParty.Other.Steamworks.Data
{
    public class Screenshot
    {
    }

    public class ScreenshotHandle
    {
        // ── Methods ──
        public void op_Implicit(){} // RVA: 0x20C5210
        public void ToString(){} // RVA: 0x20C5200
        public void GetHashCode(){} // RVA: 0x19689B0
        public void Equals(){} // RVA: 0x20D5E20 | overloaded x2
        public void CompareTo(){} // RVA: 0x20D5E30
    }

    public class ScreenshotReady_t
    {
        public uint Local; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x20CEDE0
        public void .cctor(){} // RVA: 0x20CEDF0
    }

    public class ScreenshotRequested_t
    {
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x20CEEF0
        public void .cctor(){} // RVA: 0x20CEF00
    }

    public class SearchForGameProgressCallback_t
    {
        public ulong LSearchID; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x20CAE20
        public void .cctor(){} // RVA: 0x20CAE30
    }

    public class SearchForGameResultCallback_t
    {
        public ulong LSearchID; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x20CAF30
        public void .cctor(){} // RVA: 0x20CAF40
    }

    public class SetPersonaNameResponse_t
    {
        public bool Success; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x20C94B0
        public void .cctor(){} // RVA: 0x20C94C0
    }

    public class SetUserItemVoteResult_t
    {
        public Steamworks.Data.PublishedFileId PublishedFileId; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x20D0ED0
        public void .cctor(){} // RVA: 0x20D0EE0
    }

    public class Socket
    {
        // ── Methods ──
        public void ToString(){} // RVA: 0x20C5200
    }

    public class StartPlaytimeTrackingResult_t
    {
        public 0x659B1530 Result; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x20D10F0
        public void .cctor(){} // RVA: 0x20D1100
    }

    public class SteamAPICallCompleted_t
    {
        public ulong AsyncCall; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x20C9B10
        public void .cctor(){} // RVA: 0x20C9B20
    }

    public class SteamAppInstalled_t
    {
        public Steamworks.AppId AppID; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x20D1B90
        public void .cctor(){} // RVA: 0x20D1BA0
    }

    public class SteamAppUninstalled_t
    {
        public Steamworks.AppId AppID; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x20D1CA0
        public void .cctor(){} // RVA: 0x20D1CB0
    }

    public class SteamInputConfigurationLoaded_t
    {
        public Steamworks.AppId AppID; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x20D0650
        public void .cctor(){} // RVA: 0x20D0660
    }

    public class SteamInputDeviceConnected_t
    {
        public ulong ConnectedDeviceHandle; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x20D0430
        public void .cctor(){} // RVA: 0x20D0440
    }

    public class SteamInputDeviceDisconnected_t
    {
        public ulong DisconnectedDeviceHandle; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x20D0540
        public void .cctor(){} // RVA: 0x20D0550
    }

    public class SteamInventoryDefinitionUpdate_t
    {
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x20D3840
        public void .cctor(){} // RVA: 0x20D3850
    }

    public class SteamInventoryEligiblePromoItemDefIDs_t
    {
        public 0x659B1530 Result; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x20D3950
        public void .cctor(){} // RVA: 0x20D3960
    }

    public class SteamInventoryFullUpdate_t
    {
        public int Handle; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x20D3730
        public void .cctor(){} // RVA: 0x20D3740
    }

    public class SteamInventoryRequestPricesResult_t
    {
        public 0x659B1530 Result; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x20D3B70
        public void .cctor(){} // RVA: 0x20D3B80
    }

    public class SteamInventoryResultReady_t
    {
        public int Handle; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x20D3620
        public void .cctor(){} // RVA: 0x20D3630
    }

    public class SteamInventoryResult_t
    {
        // ── Methods ──
        public void op_Implicit(){} // RVA: 0x20C5210
        public void ToString(){} // RVA: 0x20D5E50
        public void GetHashCode(){} // RVA: 0x19689B0
        public void Equals(){} // RVA: 0x20D5E20 | overloaded x2
        public void CompareTo(){} // RVA: 0x20D5EF0
    }

    public class SteamInventoryStartPurchaseResult_t
    {
        public 0x659B1530 Result; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x20D3A60
        public void .cctor(){} // RVA: 0x20D3A70
    }

    public class SteamItemDetails_t
    {
    }

    public class SteamNetAuthenticationStatus_t
    {
        public 0x659B1B60 Avail; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x20D4500
        public void .cctor(){} // RVA: 0x20D4510
    }

    public class SteamNetConnectionStatusChangedCallback_t
    {
        public Steamworks.Data.Connection Conn; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x20D43F0
        public void .cctor(){} // RVA: 0x20D4400
    }

    public class SteamNetworkingFakeIPResult_t
    {
        public 0x659B1530 Result; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x20D53E0
        public void .cctor(){} // RVA: 0x20D53F0
    }

    public class SteamNetworkingMessagesSessionFailed_t
    {
        public Steamworks.Data.ConnectionInfo Nfo; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x20D42E0
        public void .cctor(){} // RVA: 0x20D42F0
    }

    public class SteamNetworkingMessagesSessionRequest_t
    {
        public Steamworks.Data.NetIdentity DentityRemote; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x20D41D0
        public void .cctor(){} // RVA: 0x20D41E0
    }

    public class SteamNetworkingPOPID
    {
        // ── Methods ──
        public void ToString(){} // RVA: 0x20C5200
        public void GetHashCode(){} // RVA: 0x19689B0
        public void Equals(){} // RVA: 0x20D5E20 | overloaded x2
        public void CompareTo(){} // RVA: 0x20D5E30
    }

    public class SteamParentalSettingsChanged_t
    {
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x20D3EA0
        public void .cctor(){} // RVA: 0x20D3EB0
    }

    public class SteamRelayNetworkStatus_t
    {
        public 0x659B1B60 Avail; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x20D4610
        public void .cctor(){} // RVA: 0x20D4620
    }

    public class SteamRemotePlaySessionConnected_t
    {
        public uint SessionID; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x20D3FB0
        public void .cctor(){} // RVA: 0x20D3FC0
    }

    public class SteamRemotePlaySessionDisconnected_t
    {
        public uint SessionID; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x20D40C0
        public void .cctor(){} // RVA: 0x20D40D0
    }

    public class SteamServerConnectFailure_t
    {
        public 0x659B1530 Result; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x20C7090
        public void .cctor(){} // RVA: 0x20C70A0
    }

    public class SteamServersConnected_t
    {
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x20C6F80
        public void .cctor(){} // RVA: 0x20C6F90
    }

    public class SteamServersDisconnected_t
    {
        public 0x659B1530 Result; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x20C71A0
        public void .cctor(){} // RVA: 0x20C71B0
    }

    public class SteamShutdown_t
    {
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x20C9C20
        public void .cctor(){} // RVA: 0x20C9C30
    }

    public class SteamUGCDetails_t
    {
    }

    public class SteamUGCQueryCompleted_t
    {
        public ulong Handle; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x20D0760
        public void .cctor(){} // RVA: 0x20D0770
    }

    public class SteamUGCRequestUGCDetailsResult_t
    {
        public Steamworks.Data.SteamUGCDetails_t Details; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x20D0870
        public void .cctor(){} // RVA: 0x20D0880
    }

    public class StopPlaytimeTrackingResult_t
    {
        public 0x659B1530 Result; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x20D1200
        public void .cctor(){} // RVA: 0x20D1210
    }

    public class StoreAuthURLResponse_t
    {
        public byte[] URL; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x20C7C40
        public void .cctor(){} // RVA: 0x20C7C50
    }

    public class SubmitItemUpdateResult_t
    {
        public 0x659B1530 Result; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x20D0A90
        public void .cctor(){} // RVA: 0x20D0AA0
    }

    public class SubmitPlayerResultResultCallback_t
    {
        public 0x659B1530 Result; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x20CB370
        public void .cctor(){} // RVA: 0x20CB380
    }

}