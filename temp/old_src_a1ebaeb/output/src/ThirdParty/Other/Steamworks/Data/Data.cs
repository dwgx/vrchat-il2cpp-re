// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Steamworks.Data
// Classes: 70
// Methods: 178

namespace ThirdParty.Other.Steamworks.Data
{
    public class ActiveBeaconsUpdated_t : ValueType
    {
        // ── Original Methods ──
        public void get_CallbackType(){} // RVA: 0x7ffaaa5ee990
        public void .cctor(){} // RVA: 0x7ffaaa5ee9a0
    }

    public class AppResumingFromSuspend_t : ValueType
    {
        // ── Original Methods ──
        public void get_CallbackType(){} // RVA: 0x7ffaaa5ece00
        public void .cctor(){} // RVA: 0x7ffaaa5ece10
    }

    public class AvailableBeaconLocationsUpdated_t : ValueType
    {
        // ── Original Methods ──
        public void get_CallbackType(){} // RVA: 0x7ffaaa5ee880
        public void .cctor(){} // RVA: 0x7ffaaa5ee890
    }

    public class ClientGameServerDeny_t : ValueType
    {
        public object GameServerPort; // 0x35F61B50
        public object _datasize; // 0x35F61B50
        public object CallbackType; // 0x17000027

        // ── Original Methods ──
        public void get_CallbackType(){} // RVA: 0x7ffaaa5ea160
        public void .cctor(){} // RVA: 0x7ffaaa5ea170
    }

    public class Connection : ValueType
    {
        // ── Original Methods ──
        public void get_Id(){} // RVA: 0x7ffaa9e47550
        public void Equals(){} // RVA: 0x7ffaaa5f9350
        public void Equals(){} // RVA: 0x7ffaaa5f9350
        public void ToString(){} // RVA: 0x7ffaaa5f93e0
        public void Accept(){} // RVA: 0x7ffaaa5f9480
        public void Close(){} // RVA: 0x7ffaaa5f9560
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaa9e47550
    }

    public class ConnectionInfo : ValueType
    {
        public object listenSocket; // 0x35F48890
        public object popRemote; // 0x35F48890
        public object endReason; // 0x35F48890
        public object type; // 0x35F48A10
        public object netaddress; // 0x35F48A10

        // ── Original Methods ──
        public void get_State(){} // RVA: 0x7ffaaa5f96a0
    }

    public class DownloadItemResult_t : ValueType
    {
        public object Result; // 0x35F609E0

        // ── Original Methods ──
        public void get_CallbackType(){} // RVA: 0x7ffaaa5f3b60
        public void .cctor(){} // RVA: 0x7ffaaa5f3b70
    }

    public class DurationControl_t : ValueType
    {
        public object Applicable; // 0x35F62760
        public object Otification; // 0x35F62760
        public object _datasize; // 0x35F62760
        public object CallbackType; // 0x17000031

        // ── Original Methods ──
        public void get_CallbackType(){} // RVA: 0x7ffaaa5ead10
        public void .cctor(){} // RVA: 0x7ffaaa5ead20
    }

    public class FriendRichPresenceUpdate_t : ValueType
    {
        public object _datasize; // 0x35F204E0
        public object CallbackType; // 0x17000038

        // ── Original Methods ──
        public void get_CallbackType(){} // RVA: 0x7ffaaa5eb6a0
        public void .cctor(){} // RVA: 0x7ffaaa5eb6b0
    }

    public class GameConnectedClanChatMsg_t : ValueType
    {
        public object MessageID; // 0x35ECBCF0
        public object h	00; // 0x35F17D18

        // ── Original Methods ──
        public void get_CallbackType(){} // RVA: 0x7ffaaa5eb9d0
        public void .cctor(){} // RVA: 0x7ffaaa5eb9e0
    }

    public class GameConnectedFriendChatMsg_t : ValueType
    {
        public object _datasize; // 0x35ECBB60
        public object CallbackType; // 0x1700003F

        // ── Original Methods ──
        public void get_CallbackType(){} // RVA: 0x7ffaaa5ebf20
        public void .cctor(){} // RVA: 0x7ffaaa5ebf30
    }

    public class GameId : ValueType
    {
    }

    public class GameLobbyJoinRequested_t : ValueType
    {
        public object _datasize; // 0x35F20350
        public object CallbackType; // 0x17000035

        // ── Original Methods ──
        public void get_CallbackType(){} // RVA: 0x7ffaaa5eb370
        public void .cctor(){} // RVA: 0x7ffaaa5eb380
    }

    public class GameOverlayActivated_t : ValueType
    {
        // ── Original Methods ──
        public void get_CallbackType(){} // RVA: 0x7ffaaa5eaf30
        public void .cctor(){} // RVA: 0x7ffaaa5eaf40
    }

    public class GameRichPresenceJoinRequested_t : ValueType
    {
        public object _datasize; // 0x35ECB9D0
        public object CallbackType; // 0x17000039

        // ── Original Methods ──
        public void ConnectUTF8(){} // RVA: 0x7ffaaa5eb7b0
        public void get_CallbackType(){} // RVA: 0x7ffaaa5eb8c0
        public void .cctor(){} // RVA: 0x7ffaaa5eb8d0
    }

    public class GameServerChangeRequested_t : ValueType
    {
        public object _datasize; // 0x35F201C0
        public object CallbackType; // 0x17000034

        // ── Original Methods ──
        public void ServerUTF8(){} // RVA: 0x7ffaaa5eb040
        public void PasswordUTF8(){} // RVA: 0x7ffaaa5eb150
        public void get_CallbackType(){} // RVA: 0x7ffaaa5eb260
        public void .cctor(){} // RVA: 0x7ffaaa5eb270
    }

    public class GameWebCallback_t : ValueType
    {
        // ── Original Methods ──
        public void URLUTF8(){} // RVA: 0x7ffaaa5ea8d0
        public void get_CallbackType(){} // RVA: 0x7ffaaa5ea9e0
        public void .cctor(){} // RVA: 0x7ffaaa5ea9f0
    }

    public class GamepadTextInputDismissed_t : ValueType
    {
        public object _datasize; // 0x35F78990
        public object CallbackType; // 0x1700004B

        // ── Original Methods ──
        public void get_CallbackType(){} // RVA: 0x7ffaaa5eccf0
        public void .cctor(){} // RVA: 0x7ffaaa5ecd00
    }

    public class GetAuthSessionTicketResponse_t : ValueType
    {
        public object _datasize; // 0x35F625D0
        public object CallbackType; // 0x1700002D

        // ── Original Methods ──
        public void get_CallbackType(){} // RVA: 0x7ffaaa5ea7c0
        public void .cctor(){} // RVA: 0x7ffaaa5ea7d0
    }

    public class HSteamNetPollGroup : ValueType
    {
        // ── Original Methods ──
        public void ToString(){} // RVA: 0x7ffaaa5e80b0
        public void Equals(){} // RVA: 0x7ffaaa5f8cd0
        public void Equals(){} // RVA: 0x7ffaaa5f8cd0
        public void CompareTo(){} // RVA: 0x7ffaaa5f8ce0
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaa9e47550
    }

    public class HSteamPipe : ValueType
    {
        // ── Original Methods ──
        public void op_Implicit(){} // RVA: 0x7ffaaa5e80c0
        public void ToString(){} // RVA: 0x7ffaaa5f8d00
        public void Equals(){} // RVA: 0x7ffaaa5f8cd0
        public void Equals(){} // RVA: 0x7ffaaa5f8cd0
        public void op_Equality(){} // RVA: 0x7ffaaa5f8d80
        public void op_Inequality(){} // RVA: 0x7ffaaa5f8d90
        public void CompareTo(){} // RVA: 0x7ffaaa5f8da0
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaa9e47550
    }

    public class IPCountry_t : ValueType
    {
        // ── Original Methods ──
        public void get_CallbackType(){} // RVA: 0x7ffaaa5ec7a0
        public void .cctor(){} // RVA: 0x7ffaaa5ec7b0
    }

    public class InputActionSetHandle_t : ValueType
    {
        // ── Original Methods ──
        public void ToString(){} // RVA: 0x7ffaaa5e8ac0
        public void Equals(){} // RVA: 0x7ffaaa5f8ea0
        public void Equals(){} // RVA: 0x7ffaaa5f8ea0
        public void CompareTo(){} // RVA: 0x7ffaaa5f8eb0
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaaa5e8670
    }

    public class InputAnalogActionHandle_t : ValueType
    {
        // ── Original Methods ──
        public void ToString(){} // RVA: 0x7ffaaa5e8ac0
        public void Equals(){} // RVA: 0x7ffaaa5f8ea0
        public void Equals(){} // RVA: 0x7ffaaa5f8ea0
        public void CompareTo(){} // RVA: 0x7ffaaa5f8eb0
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaaa5e8670
    }

    public class InputDigitalActionHandle_t : ValueType
    {
        // ── Original Methods ──
        public void ToString(){} // RVA: 0x7ffaaa5e8ac0
        public void Equals(){} // RVA: 0x7ffaaa5f8ea0
        public void Equals(){} // RVA: 0x7ffaaa5f8ea0
        public void CompareTo(){} // RVA: 0x7ffaaa5f8eb0
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaaa5e8670
    }

    public class InputHandle_t : ValueType
    {
        // ── Original Methods ──
        public void ToString(){} // RVA: 0x7ffaaa5e8ac0
        public void Equals(){} // RVA: 0x7ffaaa5f8ea0
        public void Equals(){} // RVA: 0x7ffaaa5f8ea0
        public void CompareTo(){} // RVA: 0x7ffaaa5f8eb0
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaaa5e8670
    }

    public class ItemInstalled_t : ValueType
    {
        public object _datasize; // 0x35F61030
        public object CallbackType; // 0x170000B0

        // ── Original Methods ──
        public void get_CallbackType(){} // RVA: 0x7ffaaa5f3a50
        public void .cctor(){} // RVA: 0x7ffaaa5f3a60
    }

    public class LicensesUpdated_t : ValueType
    {
        // ── Original Methods ──
        public void get_CallbackType(){} // RVA: 0x7ffaaa5ea380
        public void .cctor(){} // RVA: 0x7ffaaa5ea390
    }

    public class LobbyChatMsg_t : ValueType
    {
        public object ChatEntryType; // 0x35F22B20

        // ── Original Methods ──
        public void get_CallbackType(){} // RVA: 0x7ffaaa5ed570
        public void .cctor(){} // RVA: 0x7ffaaa5ed580
    }

    public class LobbyChatUpdate_t : ValueType
    {
        public object SteamIDMakingChange; // 0x35F22990

        // ── Original Methods ──
        public void get_CallbackType(){} // RVA: 0x7ffaaa5ed460
        public void .cctor(){} // RVA: 0x7ffaaa5ed470
    }

    public class LobbyCreated_t : ValueType
    {
        public object _datasize; // 0x35F22230
        public object CallbackType; // 0x17000057

        // ── Original Methods ──
        public void get_CallbackType(){} // RVA: 0x7ffaaa5ed9a0
        public void .cctor(){} // RVA: 0x7ffaaa5ed9b0
    }

    public class LobbyDataUpdate_t : ValueType
    {
        public object Success; // 0x35F22800
        public object h	00; // 0x35F38770

        // ── Original Methods ──
        public void get_CallbackType(){} // RVA: 0x7ffaaa5ed350
        public void .cctor(){} // RVA: 0x7ffaaa5ed360
    }

    public class LobbyEnter_t : ValueType
    {
        public object Locked; // 0x35F220A0

        // ── Original Methods ──
        public void get_CallbackType(){} // RVA: 0x7ffaaa5ed240
        public void .cctor(){} // RVA: 0x7ffaaa5ed250
    }

    public class LobbyGameCreated_t : ValueType
    {
        public object IP; // 0x35F22670

        // ── Original Methods ──
        public void get_CallbackType(){} // RVA: 0x7ffaaa5ed680
        public void .cctor(){} // RVA: 0x7ffaaa5ed690
    }

    public class LobbyInvite_t : ValueType
    {
        public object GameID; // 0x35F21F10
        public object h	00; // 0x35F372F0

        // ── Original Methods ──
        public void get_CallbackType(){} // RVA: 0x7ffaaa5ed130
        public void .cctor(){} // RVA: 0x7ffaaa5ed140
    }

    public class LowBatteryPower_t : ValueType
    {
        // ── Original Methods ──
        public void get_CallbackType(){} // RVA: 0x7ffaaa5ec8b0
        public void .cctor(){} // RVA: 0x7ffaaa5ec8c0
    }

    public class MicroTxnAuthorizationResponse_t : ValueType
    {
        public object Authorized; // 0x35F622B0
        public object h	00; // 0x35F6E1F0

        // ── Original Methods ──
        public void get_CallbackType(){} // RVA: 0x7ffaaa5ea5a0
        public void .cctor(){} // RVA: 0x7ffaaa5ea5b0
    }

    public class NetAddress : ValueType
    {
        public object m_8zeros; // 0x35F48FC0

        // ── Original Methods ──
        public void InternalClear(){} // RVA: 0x7ffaaa5f8510
        public void InternalSetIPv4(){} // RVA: 0x7ffaaa5f8590
        public void InternalToString(){} // RVA: 0x7ffaaa5f8630
        public void From(){} // RVA: 0x7ffaaa5f86e0
        public void get_Cleared(){} // RVA: 0x7ffaaa5f8950
        public void ToString(){} // RVA: 0x7ffaaa5f89e0
    }

    public class NetIdentity : ValueType
    {
        public object steamid; // 0x35F48A10
        public object port; // 0x35F48E40

        // ── Original Methods ──
        public void ToString(){} // RVA: 0x7ffaaa5f83a0
    }

    public class OverlayBrowserProtocolNavigation_t : ValueType
    {
        // ── Original Methods ──
        public void RgchURIUTF8(){} // RVA: 0x7ffaaa5ec580
        public void get_CallbackType(){} // RVA: 0x7ffaaa5ec690
        public void .cctor(){} // RVA: 0x7ffaaa5ec6a0
    }

    public class P2PSessionConnectFail_t : ValueType
    {
        public object _datasize; // 0x35F48030
        public object CallbackType; // 0x17000093

        // ── Original Methods ──
        public void get_CallbackType(){} // RVA: 0x7ffaaa5f1b80
        public void .cctor(){} // RVA: 0x7ffaaa5f1b90
    }

    public class P2PSessionRequest_t : ValueType
    {
        // ── Original Methods ──
        public void get_CallbackType(){} // RVA: 0x7ffaaa5f1a70
        public void .cctor(){} // RVA: 0x7ffaaa5f1a80
    }

    public class PersonaStateChange_t : ValueType
    {
        public object _datasize; // 0x35ECB700
        public object CallbackType; // 0x17000032

        // ── Original Methods ──
        public void get_CallbackType(){} // RVA: 0x7ffaaa5eae20
        public void .cctor(){} // RVA: 0x7ffaaa5eae30
    }

    public class PlaybackStatusHasChanged_t : ValueType
    {
        // ── Original Methods ──
        public void get_CallbackType(){} // RVA: 0x7ffaaa5f1eb0
        public void .cctor(){} // RVA: 0x7ffaaa5f1ec0
    }

    public class PublishedFileId : ValueType
    {
        // ── Original Methods ──
        public void ToString(){} // RVA: 0x7ffaaa5e8ac0
        public void Equals(){} // RVA: 0x7ffaaa5f8ea0
        public void Equals(){} // RVA: 0x7ffaaa5f8ea0
        public void CompareTo(){} // RVA: 0x7ffaaa5f8eb0
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaaa5e8670
    }

    public class RemoteStoragePublishedFileSubscribed_t : ValueType
    {
        public object _datasize; // 0x35F60D10
        public object CallbackType; // 0x17000073

        // ── Original Methods ──
        public void get_CallbackType(){} // RVA: 0x7ffaaa5ef760
        public void .cctor(){} // RVA: 0x7ffaaa5ef770
    }

    public class RemoteStoragePublishedFileUnsubscribed_t : ValueType
    {
        public object _datasize; // 0x35F60EA0
        public object CallbackType; // 0x17000074

        // ── Original Methods ──
        public void get_CallbackType(){} // RVA: 0x7ffaaa5ef870
        public void .cctor(){} // RVA: 0x7ffaaa5ef880
    }

    public class ScreenshotReady_t : ValueType
    {
        public object _datasize; // 0x35F60370
        public object CallbackType; // 0x17000094

        // ── Original Methods ──
        public void get_CallbackType(){} // RVA: 0x7ffaaa5f1c90
        public void .cctor(){} // RVA: 0x7ffaaa5f1ca0
    }

    public class ScreenshotRequested_t : ValueType
    {
        // ── Original Methods ──
        public void get_CallbackType(){} // RVA: 0x7ffaaa5f1da0
        public void .cctor(){} // RVA: 0x7ffaaa5f1db0
    }

    public class Socket : ValueType
    {
        // ── Original Methods ──
        public void ToString(){} // RVA: 0x7ffaaa5e80b0
    }

    public class SteamInventoryDefinitionUpdate_t : ValueType
    {
        // ── Original Methods ──
        public void get_CallbackType(){} // RVA: 0x7ffaaa5f66f0
        public void .cctor(){} // RVA: 0x7ffaaa5f6700
    }

    public class SteamInventoryFullUpdate_t : ValueType
    {
        // ── Original Methods ──
        public void get_CallbackType(){} // RVA: 0x7ffaaa5f65e0
        public void .cctor(){} // RVA: 0x7ffaaa5f65f0
    }

    public class SteamNetConnectionStatusChangedCallback_t : ValueType
    {
        public object OldState; // 0x35F498C0

        // ── Original Methods ──
        public void get_CallbackType(){} // RVA: 0x7ffaaa5f72a0
        public void .cctor(){} // RVA: 0x7ffaaa5f72b0
    }

    public class SteamNetworkingFakeIPResult_t : ValueType
    {
        public object IP; // 0x35F49BE0

        // ── Original Methods ──
        public void get_CallbackType(){} // RVA: 0x7ffaaa5f8290
        public void .cctor(){} // RVA: 0x7ffaaa5f82a0
    }

    public class SteamNetworkingPOPID : ValueType
    {
        // ── Original Methods ──
        public void ToString(){} // RVA: 0x7ffaaa5e80b0
        public void Equals(){} // RVA: 0x7ffaaa5f8cd0
        public void Equals(){} // RVA: 0x7ffaaa5f8cd0
        public void CompareTo(){} // RVA: 0x7ffaaa5f8ce0
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaa9e47550
    }

    public class SteamParentalSettingsChanged_t : ValueType
    {
        // ── Original Methods ──
        public void get_CallbackType(){} // RVA: 0x7ffaaa5f6d50
        public void .cctor(){} // RVA: 0x7ffaaa5f6d60
    }

    public class SteamRelayNetworkStatus_t : ValueType
    {
        public object AvailNetworkConfig; // 0x35F4A930
        public object _datasize; // 0x35F4A930
        public object CallbackType; // 0x170000E7

        // ── Original Methods ──
        public void get_CallbackType(){} // RVA: 0x7ffaaa5f74c0
        public void .cctor(){} // RVA: 0x7ffaaa5f74d0
    }

    public class SteamRemotePlaySessionConnected_t : ValueType
    {
        // ── Original Methods ──
        public void get_CallbackType(){} // RVA: 0x7ffaaa5f6e60
        public void .cctor(){} // RVA: 0x7ffaaa5f6e70
    }

    public class SteamRemotePlaySessionDisconnected_t : ValueType
    {
        // ── Original Methods ──
        public void get_CallbackType(){} // RVA: 0x7ffaaa5f6f70
        public void .cctor(){} // RVA: 0x7ffaaa5f6f80
    }

    public class SteamServerConnectFailure_t : ValueType
    {
        public object _datasize; // 0x35F61830
        public object CallbackType; // 0x17000025

        // ── Original Methods ──
        public void get_CallbackType(){} // RVA: 0x7ffaaa5e9f40
        public void .cctor(){} // RVA: 0x7ffaaa5e9f50
    }

    public class SteamServersConnected_t : ValueType
    {
        // ── Original Methods ──
        public void get_CallbackType(){} // RVA: 0x7ffaaa5e9e30
        public void .cctor(){} // RVA: 0x7ffaaa5e9e40
    }

    public class SteamServersDisconnected_t : ValueType
    {
        // ── Original Methods ──
        public void get_CallbackType(){} // RVA: 0x7ffaaa5ea050
        public void .cctor(){} // RVA: 0x7ffaaa5ea060
    }

    public class SteamShutdown_t : ValueType
    {
        // ── Original Methods ──
        public void get_CallbackType(){} // RVA: 0x7ffaaa5ecad0
        public void .cctor(){} // RVA: 0x7ffaaa5ecae0
    }

    public class UserAchievementIconFetched_t : ValueType
    {
        public object Achieved; // 0x35F63970
        public object Value; // 0x35F63B00
        public object CallbackType; // 0x17000088

        // ── Original Methods ──
        public void AchievementNameUTF8(){} // RVA: 0x7ffaaa5f0ec0
        public void get_CallbackType(){} // RVA: 0x7ffaaa5f0fd0
        public void .cctor(){} // RVA: 0x7ffaaa5f0fe0
    }

    public class UserAchievementStored_t : ValueType
    {
        public object AchievementName; // 0x35F63650
        public object _datasize; // 0x35F63650
        public object CallbackType; // 0x17000082

        // ── Original Methods ──
        public void AchievementNameUTF8(){} // RVA: 0x7ffaaa5f0750
        public void get_CallbackType(){} // RVA: 0x7ffaaa5f0860
        public void .cctor(){} // RVA: 0x7ffaaa5f0870
    }

    public class UserStatsReceived_t : ValueType
    {
        public object SteamIDUser; // 0x35F63330
        public object h	00; // 0x35F71B98

        // ── Original Methods ──
        public void get_CallbackType(){} // RVA: 0x7ffaaa5f0530
        public void .cctor(){} // RVA: 0x7ffaaa5f0540
    }

    public class UserStatsStored_t : ValueType
    {
        public object _datasize; // 0x35F634C0
        public object CallbackType; // 0x17000081

        // ── Original Methods ──
        public void get_CallbackType(){} // RVA: 0x7ffaaa5f0640
        public void .cctor(){} // RVA: 0x7ffaaa5f0650
    }

    public class UserStatsUnloaded_t : ValueType
    {
        // ── Original Methods ──
        public void get_CallbackType(){} // RVA: 0x7ffaaa5f0db0
        public void .cctor(){} // RVA: 0x7ffaaa5f0dc0
    }

    public class ValidateAuthTicketResponse_t : ValueType
    {
        public object OwnerSteamID; // 0x35F61E70
        public object h	00; // 0x35F6DCD8

        // ── Original Methods ──
        public void get_CallbackType(){} // RVA: 0x7ffaaa5ea490
        public void .cctor(){} // RVA: 0x7ffaaa5ea4a0
    }

    public class VolumeHasChanged_t : ValueType
    {
        // ── Original Methods ──
        public void get_CallbackType(){} // RVA: 0x7ffaaa5f1fc0
        public void .cctor(){} // RVA: 0x7ffaaa5f1fd0
    }

}