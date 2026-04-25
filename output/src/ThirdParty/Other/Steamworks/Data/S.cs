// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Steamworks.Data
// Classes: 45
// Methods: 94

namespace ThirdParty.Other.Steamworks.Data
{
    public class Screenshot : ValueType
    {
        public Steamworks.Data.ScreenshotHandle Value; // 0x10
    }

    public class ScreenshotHandle : ValueType
    {
        public uint Value; // 0x10

        // ── Methods ──
        public void op_Implicit(){} // RVA: 0x7FFAC4BE6C10
        public void ToString(){} // RVA: 0x7FFAC4BE6C00
        public void GetHashCode(){} // RVA: 0x7FFAC4420210
        public void Equals(){} // RVA: 0x7FFAC4BF7820 | overloaded x2
        public void CompareTo(){} // RVA: 0x7FFAC4BF7830
    }

    public class ScreenshotReady_t : ValueType
    {
        public uint CallbackType; // 0x10
        public 0x6B28D600 Result; // 0x14
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF07E0
        public void .cctor(){} // RVA: 0x7FFAC4BF07F0
    }

    public class ScreenshotRequested_t : ValueType
    {
        public int CallbackType;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF08F0
        public void .cctor(){} // RVA: 0x7FFAC4BF0900
    }

    public class SearchForGameProgressCallback_t : ValueType
    {
        public ulong CallbackType; // 0x10
        public 0x6B28D600 Result; // 0x18
        public ulong LobbyID; // 0x1C
        public ulong SteamIDEndedSearch; // 0x24
        public int SecondsRemainingEstimate; // 0x2C
        public int CPlayersSearching; // 0x30
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BEC820
        public void .cctor(){} // RVA: 0x7FFAC4BEC830
    }

    public class SearchForGameResultCallback_t : ValueType
    {
        public ulong CallbackType; // 0x10
        public 0x6B28D600 Result; // 0x18
        public int CountPlayersInGame; // 0x1C
        public int CountAcceptedGame; // 0x20
        public ulong SteamIDHost; // 0x24
        public bool FinalCallback; // 0x2C
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BEC930
        public void .cctor(){} // RVA: 0x7FFAC4BEC940
    }

    public class SetPersonaNameResponse_t : ValueType
    {
        public bool CallbackType; // 0x10
        public bool LocalSuccess; // 0x11
        public 0x6B28D600 Result; // 0x14
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BEAEB0
        public void .cctor(){} // RVA: 0x7FFAC4BEAEC0
    }

    public class SetUserItemVoteResult_t : ValueType
    {
        public Steamworks.Data.PublishedFileId CallbackType; // 0x10
        public 0x6B28D600 Result; // 0x18
        public bool VoteUp; // 0x1C
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF28D0
        public void .cctor(){} // RVA: 0x7FFAC4BF28E0
    }

    public class Socket : ValueType
    {
        public uint Id; // 0x10

        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFAC4BE6C00
    }

    public class StartPlaytimeTrackingResult_t : ValueType
    {
        public 0x6B28D600 CallbackType; // 0x10
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF2AF0
        public void .cctor(){} // RVA: 0x7FFAC4BF2B00
    }

    public class SteamAPICallCompleted_t : ValueType
    {
        public ulong CallbackType; // 0x10
        public int Callback; // 0x18
        public uint ParamCount; // 0x1C
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BEB510
        public void .cctor(){} // RVA: 0x7FFAC4BEB520
    }

    public class SteamAppInstalled_t : ValueType
    {
        public Steamworks.AppId CallbackType; // 0x10
        public int InstallFolderIndex; // 0x14
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF3590
        public void .cctor(){} // RVA: 0x7FFAC4BF35A0
    }

    public class SteamAppUninstalled_t : ValueType
    {
        public Steamworks.AppId CallbackType; // 0x10
        public int InstallFolderIndex; // 0x14
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF36A0
        public void .cctor(){} // RVA: 0x7FFAC4BF36B0
    }

    public class SteamInputConfigurationLoaded_t : ValueType
    {
        public Steamworks.AppId CallbackType; // 0x10
        public ulong DeviceHandle; // 0x14
        public ulong MappingCreator; // 0x1C
        public uint MajorRevision; // 0x24
        public uint MinorRevision; // 0x28
        public bool UsesSteamInputAPI; // 0x2C
        public bool UsesGamepadAPI; // 0x2D
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF2050
        public void .cctor(){} // RVA: 0x7FFAC4BF2060
    }

    public class SteamInputDeviceConnected_t : ValueType
    {
        public ulong CallbackType; // 0x10
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF1E30
        public void .cctor(){} // RVA: 0x7FFAC4BF1E40
    }

    public class SteamInputDeviceDisconnected_t : ValueType
    {
        public ulong CallbackType; // 0x10
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF1F40
        public void .cctor(){} // RVA: 0x7FFAC4BF1F50
    }

    public class SteamInventoryDefinitionUpdate_t : ValueType
    {
        public int CallbackType;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF5240
        public void .cctor(){} // RVA: 0x7FFAC4BF5250
    }

    public class SteamInventoryEligiblePromoItemDefIDs_t : ValueType
    {
        public 0x6B28D600 CallbackType; // 0x10
        public ulong SteamID; // 0x14
        public int UmEligiblePromoItemDefs; // 0x1C
        public bool CachedData; // 0x20
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF5350
        public void .cctor(){} // RVA: 0x7FFAC4BF5360
    }

    public class SteamInventoryFullUpdate_t : ValueType
    {
        public int CallbackType; // 0x10
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF5130
        public void .cctor(){} // RVA: 0x7FFAC4BF5140
    }

    public class SteamInventoryRequestPricesResult_t : ValueType
    {
        public 0x6B28D600 CallbackType; // 0x10
        public byte[] Currency; // 0x18
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF5570
        public void .cctor(){} // RVA: 0x7FFAC4BF5580
    }

    public class SteamInventoryResultReady_t : ValueType
    {
        public int CallbackType; // 0x10
        public 0x6B28D600 Result; // 0x14
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF5020
        public void .cctor(){} // RVA: 0x7FFAC4BF5030
    }

    public class SteamInventoryResult_t : ValueType
    {
        public int Value; // 0x10

        // ── Methods ──
        public void op_Implicit(){} // RVA: 0x7FFAC4BE6C10
        public void ToString(){} // RVA: 0x7FFAC4BF7850
        public void GetHashCode(){} // RVA: 0x7FFAC4420210
        public void Equals(){} // RVA: 0x7FFAC4BF7820 | overloaded x2
        public void CompareTo(){} // RVA: 0x7FFAC4BF78F0
    }

    public class SteamInventoryStartPurchaseResult_t : ValueType
    {
        public 0x6B28D600 CallbackType; // 0x10
        public ulong OrderID; // 0x18
        public ulong TransID; // 0x20
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF5460
        public void .cctor(){} // RVA: 0x7FFAC4BF5470
    }

    public class SteamItemDetails_t : ValueType
    {
        public Steamworks.Data.InventoryItemId ItemId; // 0x10
        public Steamworks.Data.InventoryDefId Definition; // 0x18
        public ushort Quantity; // 0x1C
        public ushort Flags; // 0x1E
    }

    public class SteamNetAuthenticationStatus_t : ValueType
    {
        public 0x6B28DC30 CallbackType; // 0x10
        public byte[] DebugMsg; // 0x18
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF5F00
        public void .cctor(){} // RVA: 0x7FFAC4BF5F10
    }

    public class SteamNetConnectionStatusChangedCallback_t : ValueType
    {
        public Steamworks.Data.Connection CallbackType; // 0x10
        public Steamworks.Data.ConnectionInfo Nfo; // 0x18
        public 0x6B28DC88 OldState; // 0x2D0
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF5DF0
        public void .cctor(){} // RVA: 0x7FFAC4BF5E00
    }

    public class SteamNetworkingFakeIPResult_t : ValueType
    {
        public 0x6B28D600 CallbackType; // 0x10
        public Steamworks.Data.NetIdentity Dentity; // 0x14
        public uint IP; // 0x9C
        public ushort[] Ports; // 0xA0
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF6DE0
        public void .cctor(){} // RVA: 0x7FFAC4BF6DF0
    }

    public class SteamNetworkingMessagesSessionFailed_t : ValueType
    {
        public Steamworks.Data.ConnectionInfo CallbackType; // 0x10
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF5CE0
        public void .cctor(){} // RVA: 0x7FFAC4BF5CF0
    }

    public class SteamNetworkingMessagesSessionRequest_t : ValueType
    {
        public Steamworks.Data.NetIdentity CallbackType; // 0x10
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF5BD0
        public void .cctor(){} // RVA: 0x7FFAC4BF5BE0
    }

    public class SteamNetworkingPOPID : ValueType
    {
        public uint Value; // 0x10

        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFAC4BE6C00
        public void GetHashCode(){} // RVA: 0x7FFAC4420210
        public void Equals(){} // RVA: 0x7FFAC4BF7820 | overloaded x2
        public void CompareTo(){} // RVA: 0x7FFAC4BF7830
    }

    public class SteamParentalSettingsChanged_t : ValueType
    {
        public int CallbackType;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF58A0
        public void .cctor(){} // RVA: 0x7FFAC4BF58B0
    }

    public class SteamRelayNetworkStatus_t : ValueType
    {
        public 0x6B28DC30 CallbackType; // 0x10
        public int PingMeasurementInProgress; // 0x14
        public 0x6B28DC30 AvailNetworkConfig; // 0x18
        public 0x6B28DC30 AvailAnyRelay; // 0x1C
        public byte[] DebugMsg; // 0x20
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF6010
        public void .cctor(){} // RVA: 0x7FFAC4BF6020
    }

    public class SteamRemotePlaySessionConnected_t : ValueType
    {
        public uint CallbackType; // 0x10
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF59B0
        public void .cctor(){} // RVA: 0x7FFAC4BF59C0
    }

    public class SteamRemotePlaySessionDisconnected_t : ValueType
    {
        public uint CallbackType; // 0x10
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF5AC0
        public void .cctor(){} // RVA: 0x7FFAC4BF5AD0
    }

    public class SteamServerConnectFailure_t : ValueType
    {
        public 0x6B28D600 CallbackType; // 0x10
        public bool StillRetrying; // 0x14
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BE8A90
        public void .cctor(){} // RVA: 0x7FFAC4BE8AA0
    }

    public class SteamServersConnected_t : ValueType
    {
        public int CallbackType;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BE8980
        public void .cctor(){} // RVA: 0x7FFAC4BE8990
    }

    public class SteamServersDisconnected_t : ValueType
    {
        public 0x6B28D600 CallbackType; // 0x10
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BE8BA0
        public void .cctor(){} // RVA: 0x7FFAC4BE8BB0
    }

    public class SteamShutdown_t : ValueType
    {
        public int CallbackType;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BEB620
        public void .cctor(){} // RVA: 0x7FFAC4BEB630
    }

    public class SteamUGCDetails_t : ValueType
    {
        public Steamworks.Data.PublishedFileId PublishedFileId; // 0x10
        public 0x6B28D600 Result; // 0x18
        public 0x6B28D9C8 FileType; // 0x1C
        public Steamworks.AppId CreatorAppID; // 0x20
        public Steamworks.AppId ConsumerAppID; // 0x24
        public byte[] Title; // 0x28
        public byte[] Description; // 0x30
        public ulong SteamIDOwner; // 0x38
        public uint TimeCreated; // 0x40
        public uint TimeUpdated; // 0x44
        public uint TimeAddedToUserList; // 0x48
        public 0x6B28D970 Visibility; // 0x4C
        public bool Banned; // 0x50
        public bool AcceptedForUse; // 0x51
        public bool TagsTruncated; // 0x52
        public byte[] Tags; // 0x58
        public ulong File; // 0x60
        public ulong PreviewFile; // 0x68
        public byte[] PchFileName; // 0x70
        public int FileSize; // 0x78
        public int PreviewFileSize; // 0x7C
        public byte[] URL; // 0x80
        public uint VotesUp; // 0x88
        public uint VotesDown; // 0x8C
        public float Score; // 0x90
        public uint NumChildren; // 0x94
    }

    public class SteamUGCQueryCompleted_t : ValueType
    {
        public ulong CallbackType; // 0x10
        public 0x6B28D600 Result; // 0x18
        public uint NumResultsReturned; // 0x1C
        public uint TotalMatchingResults; // 0x20
        public bool CachedData; // 0x24
        public byte[] NextCursor; // 0x28
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF2160
        public void .cctor(){} // RVA: 0x7FFAC4BF2170
    }

    public class SteamUGCRequestUGCDetailsResult_t : ValueType
    {
        public Steamworks.Data.SteamUGCDetails_t CallbackType; // 0x10
        public bool CachedData; // 0x98
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF2270
        public void .cctor(){} // RVA: 0x7FFAC4BF2280
    }

    public class StopPlaytimeTrackingResult_t : ValueType
    {
        public 0x6B28D600 CallbackType; // 0x10
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF2C00
        public void .cctor(){} // RVA: 0x7FFAC4BF2C10
    }

    public class StoreAuthURLResponse_t : ValueType
    {
        public byte[] CallbackType; // 0x10
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BE9640
        public void .cctor(){} // RVA: 0x7FFAC4BE9650
    }

    public class SubmitItemUpdateResult_t : ValueType
    {
        public 0x6B28D600 CallbackType; // 0x10
        public bool UserNeedsToAcceptWorkshopLegalAgreement; // 0x14
        public Steamworks.Data.PublishedFileId PublishedFileId; // 0x18
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF2490
        public void .cctor(){} // RVA: 0x7FFAC4BF24A0
    }

    public class SubmitPlayerResultResultCallback_t : ValueType
    {
        public 0x6B28D600 CallbackType; // 0x10
        public ulong UllUniqueGameID; // 0x14
        public ulong SteamIDPlayer; // 0x1C
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BECD70
        public void .cctor(){} // RVA: 0x7FFAC4BECD80
    }

}