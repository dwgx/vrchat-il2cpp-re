// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Steamworks.Data
// Classes: 70
// Methods: 178

namespace ThirdParty.Other.Steamworks.Data
{
    public class ActiveBeaconsUpdated_t : ValueType
    {
        public int CallbackType;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFD5000D4E0
        public void .cctor(){} // RVA: 0x7FFD5000D4F0
    }

    public class AppResumingFromSuspend_t : ValueType
    {
        public int CallbackType;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFD5000B950
        public void .cctor(){} // RVA: 0x7FFD5000B960
    }

    public class AvailableBeaconLocationsUpdated_t : ValueType
    {
        public int CallbackType;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFD5000D3D0
        public void .cctor(){} // RVA: 0x7FFD5000D3E0
    }

    public class ClientGameServerDeny_t : ValueType
    {
        public uint CallbackType; // 0x10
        public uint GameServerIP; // 0x14
        public ushort GameServerPort; // 0x18
        public ushort Secure; // 0x1A
        public uint Reason; // 0x1C
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFD50008CB0
        public void .cctor(){} // RVA: 0x7FFD50008CC0
    }

    public class Connection : ValueType
    {
        public uint Id; // 0x10

        // ── Methods ──
        public void get_Id(){} // RVA: 0x7FFD4F840210
        public void Equals(){} // RVA: 0x7FFD50017EA0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD4F840210
        public void ToString(){} // RVA: 0x7FFD50017F30
        public void Accept(){} // RVA: 0x7FFD50017FD0
        public void Close(){} // RVA: 0x7FFD500180B0
    }

    public class ConnectionInfo : ValueType
    {
        public Steamworks.Data.NetIdentity State; // 0x10
        public long userData; // 0x98
        public Steamworks.Data.Socket listenSocket; // 0xA0
        public Steamworks.Data.NetAddress address; // 0xA4
        public ushort pad; // 0xB6
        public Steamworks.Data.SteamNetworkingPOPID popRemote; // 0xB8
        public Steamworks.Data.SteamNetworkingPOPID popRelay; // 0xBC
        public 0x665EDC88 state; // 0xC0
        public int endReason; // 0xC4
        public string endDebug; // 0xC8
        public string connectionDescription; // 0xD0

        // ── Methods ──
        public void get_State(){} // RVA: 0x7FFD500181F0
    }

    public class DownloadItemResult_t : ValueType
    {
        public Steamworks.AppId CallbackType; // 0x10
        public Steamworks.Data.PublishedFileId PublishedFileId; // 0x18
        public 0x665ED600 Result; // 0x20
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFD500126B0
        public void .cctor(){} // RVA: 0x7FFD500126C0
    }

    public class DurationControl_t : ValueType
    {
        public 0x665ED600 CallbackType; // 0x10
        public Steamworks.AppId Appid; // 0x14
        public bool Applicable; // 0x18
        public int CsecsLast5h; // 0x1C
        public ÍÏÍÎÌÏÌÌÏÌÍÏÍÎÍÌÎÏÎÏ Progress; // 0x20
        public 0x665ED8C0 Otification; // 0x24
        public int CsecsToday; // 0x28
        public int CsecsRemaining; // 0x2C
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFD50009860
        public void .cctor(){} // RVA: 0x7FFD50009870
    }

    public class FriendRichPresenceUpdate_t : ValueType
    {
        public ulong CallbackType; // 0x10
        public Steamworks.AppId AppID; // 0x18
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFD5000A1F0
        public void .cctor(){} // RVA: 0x7FFD5000A200
    }

    public class GameConnectedClanChatMsg_t : ValueType
    {
        public ulong CallbackType; // 0x10
        public ulong SteamIDUser; // 0x18
        public int MessageID; // 0x20
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFD5000A520
        public void .cctor(){} // RVA: 0x7FFD5000A530
    }

    public class GameConnectedFriendChatMsg_t : ValueType
    {
        public ulong CallbackType; // 0x10
        public int MessageID; // 0x18
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFD5000AA70
        public void .cctor(){} // RVA: 0x7FFD5000AA80
    }

    public class GameId : ValueType
    {
        public ulong Value; // 0x10
    }

    public class GameLobbyJoinRequested_t : ValueType
    {
        public ulong CallbackType; // 0x10
        public ulong SteamIDFriend; // 0x18
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFD50009EC0
        public void .cctor(){} // RVA: 0x7FFD50009ED0
    }

    public class GameOverlayActivated_t : ValueType
    {
        public byte CallbackType; // 0x10
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFD50009A80
        public void .cctor(){} // RVA: 0x7FFD50009A90
    }

    public class GameRichPresenceJoinRequested_t : ValueType
    {
        public ulong CallbackType; // 0x10
        public byte[] Connect; // 0x18
        public int _datasize;

        // ── Methods ──
        public void ConnectUTF8(){} // RVA: 0x7FFD5000A300
        public void get_CallbackType(){} // RVA: 0x7FFD5000A410
        public void .cctor(){} // RVA: 0x7FFD5000A420
    }

    public class GameServerChangeRequested_t : ValueType
    {
        public byte[] CallbackType; // 0x10
        public byte[] Password; // 0x18
        public int _datasize;

        // ── Methods ──
        public void ServerUTF8(){} // RVA: 0x7FFD50009B90
        public void PasswordUTF8(){} // RVA: 0x7FFD50009CA0
        public void get_CallbackType(){} // RVA: 0x7FFD50009DB0
        public void .cctor(){} // RVA: 0x7FFD50009DC0
    }

    public class GameWebCallback_t : ValueType
    {
        public byte[] CallbackType; // 0x10
        public int _datasize;

        // ── Methods ──
        public void URLUTF8(){} // RVA: 0x7FFD50009420
        public void get_CallbackType(){} // RVA: 0x7FFD50009530
        public void .cctor(){} // RVA: 0x7FFD50009540
    }

    public class GamepadTextInputDismissed_t : ValueType
    {
        public bool CallbackType; // 0x10
        public uint SubmittedText; // 0x14
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFD5000B840
        public void .cctor(){} // RVA: 0x7FFD5000B850
    }

    public class GetAuthSessionTicketResponse_t : ValueType
    {
        public uint CallbackType; // 0x10
        public 0x665ED600 Result; // 0x14
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFD50009310
        public void .cctor(){} // RVA: 0x7FFD50009320
    }

    public class HSteamNetPollGroup : ValueType
    {
        public uint Value; // 0x10

        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFD50006C00
        public void GetHashCode(){} // RVA: 0x7FFD4F840210
        public void Equals(){} // RVA: 0x7FFD50017820 | overloaded x2
        public void CompareTo(){} // RVA: 0x7FFD50017830
    }

    public class HSteamPipe : ValueType
    {
        public int Value; // 0x10

        // ── Methods ──
        public void op_Implicit(){} // RVA: 0x7FFD50006C10
        public void ToString(){} // RVA: 0x7FFD50017850
        public void GetHashCode(){} // RVA: 0x7FFD4F840210
        public void Equals(){} // RVA: 0x7FFD50017820 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFD500178D0
        public void op_Inequality(){} // RVA: 0x7FFD500178E0
        public void CompareTo(){} // RVA: 0x7FFD500178F0
    }

    public class IPCountry_t : ValueType
    {
        public int CallbackType;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFD5000B2F0
        public void .cctor(){} // RVA: 0x7FFD5000B300
    }

    public class InputActionSetHandle_t : ValueType
    {
        public ulong Value; // 0x10

        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFD50007610
        public void GetHashCode(){} // RVA: 0x7FFD500071C0
        public void Equals(){} // RVA: 0x7FFD500179F0 | overloaded x2
        public void CompareTo(){} // RVA: 0x7FFD50017A00
    }

    public class InputAnalogActionHandle_t : ValueType
    {
        public ulong Value; // 0x10

        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFD50007610
        public void GetHashCode(){} // RVA: 0x7FFD500071C0
        public void Equals(){} // RVA: 0x7FFD500179F0 | overloaded x2
        public void CompareTo(){} // RVA: 0x7FFD50017A00
    }

    public class InputDigitalActionHandle_t : ValueType
    {
        public ulong Value; // 0x10

        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFD50007610
        public void GetHashCode(){} // RVA: 0x7FFD500071C0
        public void Equals(){} // RVA: 0x7FFD500179F0 | overloaded x2
        public void CompareTo(){} // RVA: 0x7FFD50017A00
    }

    public class InputHandle_t : ValueType
    {
        public ulong Value; // 0x10

        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFD50007610
        public void GetHashCode(){} // RVA: 0x7FFD500071C0
        public void Equals(){} // RVA: 0x7FFD500179F0 | overloaded x2
        public void CompareTo(){} // RVA: 0x7FFD50017A00
    }

    public class ItemInstalled_t : ValueType
    {
        public Steamworks.AppId CallbackType; // 0x10
        public Steamworks.Data.PublishedFileId PublishedFileId; // 0x18
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFD500125A0
        public void .cctor(){} // RVA: 0x7FFD500125B0
    }

    public class LicensesUpdated_t : ValueType
    {
        public int CallbackType;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFD50008ED0
        public void .cctor(){} // RVA: 0x7FFD50008EE0
    }

    public class LobbyChatMsg_t : ValueType
    {
        public ulong CallbackType; // 0x10
        public ulong SteamIDUser; // 0x18
        public byte ChatEntryType; // 0x20
        public uint ChatID; // 0x24
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFD5000C0C0
        public void .cctor(){} // RVA: 0x7FFD5000C0D0
    }

    public class LobbyChatUpdate_t : ValueType
    {
        public ulong CallbackType; // 0x10
        public ulong SteamIDUserChanged; // 0x18
        public ulong SteamIDMakingChange; // 0x20
        public uint GfChatMemberStateChange; // 0x28
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFD5000BFB0
        public void .cctor(){} // RVA: 0x7FFD5000BFC0
    }

    public class LobbyCreated_t : ValueType
    {
        public 0x665ED600 CallbackType; // 0x10
        public ulong SteamIDLobby; // 0x18
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFD5000C4F0
        public void .cctor(){} // RVA: 0x7FFD5000C500
    }

    public class LobbyDataUpdate_t : ValueType
    {
        public ulong CallbackType; // 0x10
        public ulong SteamIDMember; // 0x18
        public byte Success; // 0x20
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFD5000BEA0
        public void .cctor(){} // RVA: 0x7FFD5000BEB0
    }

    public class LobbyEnter_t : ValueType
    {
        public ulong CallbackType; // 0x10
        public uint GfChatPermissions; // 0x18
        public bool Locked; // 0x1C
        public uint EChatRoomEnterResponse; // 0x20
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFD5000BD90
        public void .cctor(){} // RVA: 0x7FFD5000BDA0
    }

    public class LobbyGameCreated_t : ValueType
    {
        public ulong CallbackType; // 0x10
        public ulong SteamIDGameServer; // 0x18
        public uint IP; // 0x20
        public ushort Port; // 0x24
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFD5000C1D0
        public void .cctor(){} // RVA: 0x7FFD5000C1E0
    }

    public class LobbyInvite_t : ValueType
    {
        public ulong CallbackType; // 0x10
        public ulong SteamIDLobby; // 0x18
        public ulong GameID; // 0x20
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFD5000BC80
        public void .cctor(){} // RVA: 0x7FFD5000BC90
    }

    public class LowBatteryPower_t : ValueType
    {
        public byte CallbackType; // 0x10
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFD5000B400
        public void .cctor(){} // RVA: 0x7FFD5000B410
    }

    public class MicroTxnAuthorizationResponse_t : ValueType
    {
        public uint CallbackType; // 0x10
        public ulong OrderID; // 0x18
        public byte Authorized; // 0x20
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFD500090F0
        public void .cctor(){} // RVA: 0x7FFD50009100
    }

    public class NetAddress : ValueType
    {
        public IPV4 Cleared; // 0x10
        public ushort port; // 0x20

        // ── Methods ──
        public void InternalClear(){} // RVA: 0x7FFD50017060
        public void InternalSetIPv4(){} // RVA: 0x7FFD500170E0
        public void InternalToString(){} // RVA: 0x7FFD50017180
        public void From(){} // RVA: 0x7FFD50017230
        public void get_Cleared(){} // RVA: 0x7FFD500174A0
        public void ToString(){} // RVA: 0x7FFD50017530
    }

    public class NetIdentity : ValueType
    {
        public ÏÍÍÌÏÏÏÌÍÍÏÌÍÌÍÏÍÌÍÍÌÏÌ type; // 0x10
        public int size; // 0x14
        public ulong steamid; // 0x18
        public Steamworks.Data.NetAddress netaddress; // 0x18

        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFD50016EF0
    }

    public class OverlayBrowserProtocolNavigation_t : ValueType
    {
        public byte[] CallbackType; // 0x10
        public int _datasize;

        // ── Methods ──
        public void RgchURIUTF8(){} // RVA: 0x7FFD5000B0D0
        public void get_CallbackType(){} // RVA: 0x7FFD5000B1E0
        public void .cctor(){} // RVA: 0x7FFD5000B1F0
    }

    public class P2PSessionConnectFail_t : ValueType
    {
        public ulong CallbackType; // 0x10
        public byte P2PSessionError; // 0x18
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFD500106D0
        public void .cctor(){} // RVA: 0x7FFD500106E0
    }

    public class P2PSessionRequest_t : ValueType
    {
        public ulong CallbackType; // 0x10
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFD500105C0
        public void .cctor(){} // RVA: 0x7FFD500105D0
    }

    public class PersonaStateChange_t : ValueType
    {
        public ulong CallbackType; // 0x10
        public int ChangeFlags; // 0x18
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFD50009970
        public void .cctor(){} // RVA: 0x7FFD50009980
    }

    public class PlaybackStatusHasChanged_t : ValueType
    {
        public int CallbackType;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFD50010A00
        public void .cctor(){} // RVA: 0x7FFD50010A10
    }

    public class PublishedFileId : ValueType
    {
        public ulong Value; // 0x10

        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFD50007610
        public void GetHashCode(){} // RVA: 0x7FFD500071C0
        public void Equals(){} // RVA: 0x7FFD500179F0 | overloaded x2
        public void CompareTo(){} // RVA: 0x7FFD50017A00
    }

    public class RemoteStoragePublishedFileSubscribed_t : ValueType
    {
        public Steamworks.Data.PublishedFileId CallbackType; // 0x10
        public Steamworks.AppId AppID; // 0x18
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFD5000E2B0
        public void .cctor(){} // RVA: 0x7FFD5000E2C0
    }

    public class RemoteStoragePublishedFileUnsubscribed_t : ValueType
    {
        public Steamworks.Data.PublishedFileId CallbackType; // 0x10
        public Steamworks.AppId AppID; // 0x18
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFD5000E3C0
        public void .cctor(){} // RVA: 0x7FFD5000E3D0
    }

    public class ScreenshotReady_t : ValueType
    {
        public uint CallbackType; // 0x10
        public 0x665ED600 Result; // 0x14
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFD500107E0
        public void .cctor(){} // RVA: 0x7FFD500107F0
    }

    public class ScreenshotRequested_t : ValueType
    {
        public int CallbackType;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFD500108F0
        public void .cctor(){} // RVA: 0x7FFD50010900
    }

    public class Socket : ValueType
    {
        public uint Id; // 0x10

        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFD50006C00
    }

    public class SteamInventoryDefinitionUpdate_t : ValueType
    {
        public int CallbackType;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFD50015240
        public void .cctor(){} // RVA: 0x7FFD50015250
    }

    public class SteamInventoryFullUpdate_t : ValueType
    {
        public int CallbackType; // 0x10
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFD50015130
        public void .cctor(){} // RVA: 0x7FFD50015140
    }

    public class SteamNetConnectionStatusChangedCallback_t : ValueType
    {
        public Steamworks.Data.Connection CallbackType; // 0x10
        public Steamworks.Data.ConnectionInfo Nfo; // 0x18
        public 0x665EDC88 OldState; // 0x2D0
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFD50015DF0
        public void .cctor(){} // RVA: 0x7FFD50015E00
    }

    public class SteamNetworkingFakeIPResult_t : ValueType
    {
        public 0x665ED600 CallbackType; // 0x10
        public Steamworks.Data.NetIdentity Dentity; // 0x14
        public uint IP; // 0x9C
        public ushort[] Ports; // 0xA0
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFD50016DE0
        public void .cctor(){} // RVA: 0x7FFD50016DF0
    }

    public class SteamNetworkingPOPID : ValueType
    {
        public uint Value; // 0x10

        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFD50006C00
        public void GetHashCode(){} // RVA: 0x7FFD4F840210
        public void Equals(){} // RVA: 0x7FFD50017820 | overloaded x2
        public void CompareTo(){} // RVA: 0x7FFD50017830
    }

    public class SteamParentalSettingsChanged_t : ValueType
    {
        public int CallbackType;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFD500158A0
        public void .cctor(){} // RVA: 0x7FFD500158B0
    }

    public class SteamRelayNetworkStatus_t : ValueType
    {
        public Left CallbackType; // 0x10
        public int PingMeasurementInProgress; // 0x14
        public Left AvailNetworkConfig; // 0x18
        public Left AvailAnyRelay; // 0x1C
        public byte[] DebugMsg; // 0x20
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFD50016010
        public void .cctor(){} // RVA: 0x7FFD50016020
    }

    public class SteamRemotePlaySessionConnected_t : ValueType
    {
        public uint CallbackType; // 0x10
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFD500159B0
        public void .cctor(){} // RVA: 0x7FFD500159C0
    }

    public class SteamRemotePlaySessionDisconnected_t : ValueType
    {
        public uint CallbackType; // 0x10
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFD50015AC0
        public void .cctor(){} // RVA: 0x7FFD50015AD0
    }

    public class SteamServerConnectFailure_t : ValueType
    {
        public 0x665ED600 CallbackType; // 0x10
        public bool StillRetrying; // 0x14
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFD50008A90
        public void .cctor(){} // RVA: 0x7FFD50008AA0
    }

    public class SteamServersConnected_t : ValueType
    {
        public int CallbackType;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFD50008980
        public void .cctor(){} // RVA: 0x7FFD50008990
    }

    public class SteamServersDisconnected_t : ValueType
    {
        public 0x665ED600 CallbackType; // 0x10
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFD50008BA0
        public void .cctor(){} // RVA: 0x7FFD50008BB0
    }

    public class SteamShutdown_t : ValueType
    {
        public int CallbackType;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFD5000B620
        public void .cctor(){} // RVA: 0x7FFD5000B630
    }

    public class UserAchievementIconFetched_t : ValueType
    {
        public Steamworks.Data.GameId CallbackType; // 0x10
        public byte[] AchievementName; // 0x18
        public bool Achieved; // 0x20
        public int IconHandle; // 0x24
        public int _datasize;

        // ── Methods ──
        public void AchievementNameUTF8(){} // RVA: 0x7FFD5000FA10
        public void get_CallbackType(){} // RVA: 0x7FFD5000FB20
        public void .cctor(){} // RVA: 0x7FFD5000FB30
    }

    public class UserAchievementStored_t : ValueType
    {
        public ulong CallbackType; // 0x10
        public bool GroupAchievement; // 0x18
        public byte[] AchievementName; // 0x20
        public uint CurProgress; // 0x28
        public uint MaxProgress; // 0x2C
        public int _datasize;

        // ── Methods ──
        public void AchievementNameUTF8(){} // RVA: 0x7FFD5000F2A0
        public void get_CallbackType(){} // RVA: 0x7FFD5000F3B0
        public void .cctor(){} // RVA: 0x7FFD5000F3C0
    }

    public class UserStatsReceived_t : ValueType
    {
        public ulong CallbackType; // 0x10
        public 0x665ED600 Result; // 0x18
        public ulong SteamIDUser; // 0x1C
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFD5000F080
        public void .cctor(){} // RVA: 0x7FFD5000F090
    }

    public class UserStatsStored_t : ValueType
    {
        public ulong CallbackType; // 0x10
        public 0x665ED600 Result; // 0x18
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFD5000F190
        public void .cctor(){} // RVA: 0x7FFD5000F1A0
    }

    public class UserStatsUnloaded_t : ValueType
    {
        public ulong CallbackType; // 0x10
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFD5000F900
        public void .cctor(){} // RVA: 0x7FFD5000F910
    }

    public class ValidateAuthTicketResponse_t : ValueType
    {
        public ulong CallbackType; // 0x10
        public ÎÌÎÏÏÎÌÌÏÎÎÍÎÎÌÏÌÏÌÏÌÌ AuthSessionResponse; // 0x18
        public ulong OwnerSteamID; // 0x1C
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFD50008FE0
        public void .cctor(){} // RVA: 0x7FFD50008FF0
    }

    public class VolumeHasChanged_t : ValueType
    {
        public float CallbackType; // 0x10
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFD50010B10
        public void .cctor(){} // RVA: 0x7FFD50010B20
    }

}