// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Steamworks
// Classes: 65
// Methods: 336

namespace ThirdParty.Other.Steamworks
{
    public class AppId
    {
        // ── Methods ──
        public void ToString(){} // RVA: 0x20C5200
        public void op_Implicit(){} // RVA: 0x20C5210
    }

    public class AuthTicket
    {
        // ── Methods ──
        public void Cancel(){} // RVA: 0x20A9D70
        public void Dispose(){} // RVA: 0x20A9EB0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class CallbackTypeFactory
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x20ACBC0
    }

    public class ConnectionManager
    {
        // ── Methods ──
        public void get_Interface(){} // RVA: 0x2F8380
        public void set_ConnectionInfo(){} // RVA: 0x20B4860
        public void OnConnectionChanged(){} // RVA: 0x20B4940
        public void OnConnecting(){} // RVA: 0x20B4C80
        public void OnConnected(){} // RVA: 0x20B4D60
        public void OnDisconnected(){} // RVA: 0x20B4E50
    }

    public class Dispatch
    {
        // ── Methods ──
        public void SteamAPI_ManualDispatch_Init(){} // RVA: 0x20A9EC0
        public void SteamAPI_ManualDispatch_RunFrame(){} // RVA: 0x20A9F30
        public void SteamAPI_ManualDispatch_GetNextCallback(){} // RVA: 0x20A9FB0
        public void SteamAPI_ManualDispatch_FreeLastCallback(){} // RVA: 0x20AA040
        public void get_ClientPipe(){} // RVA: 0x20AA0C0
        public void set_ClientPipe(){} // RVA: 0x20AA120
        public void get_ServerPipe(){} // RVA: 0x20AA180
        public void Init(){} // RVA: 0x20AA1E0
        public void Frame(){} // RVA: 0x20AA280
        public void ProcessCallback(){} // RVA: 0x20AA6E0
        public void CallbackToString(){} // RVA: 0x20AACA0
        public void ProcessResult(){} // RVA: 0x20AB460
        public void LoopClientAsync(){} // RVA: 0x20AB7A0
        public void Install(){} // RVA: 0x2A400
        public void ShutdownClient(){} // RVA: 0x20AB8F0
        public void .cctor(){} // RVA: 0x20AC220
    }

    public class Friend
    {
        public object Id;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x1B12320
        public void ToString(){} // RVA: 0x20C5220
        public void get_Name(){} // RVA: 0x20C52B0
    }

    public class Helpers
    {
        // ── Methods ──
        public void TakeMemory(){} // RVA: 0x20C5C20
        public void TakeBuffer(){} // RVA: 0x20C5C70
        public void MemoryToString(){} // RVA: 0x20C6050
        public void .cctor(){} // RVA: 0x20C6120
    }

    public class ICallbackData
    {
        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0xD840
    }

    public class IConnectionManager
    {
        // ── Methods ──
        public void OnConnecting(){}
        public void OnConnected(){}
        public void OnDisconnected(){}
    }

    public class ISocketManager
    {
        // ── Methods ──
        public void OnConnecting(){}
        public void OnConnected(){}
        public void OnDisconnected(){}
    }

    public class ISteamApps
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x20B1670
        public void SteamAPI_SteamApps_v008(){} // RVA: 0x20B1680
        public void GetUserInterfacePointer(){} // RVA: 0x20B1680
        public void _GetCurrentBetaName(){} // RVA: 0x20B16F0
        public void GetCurrentBetaName(){} // RVA: 0x20B1790
        public void _GetLaunchQueryParam(){} // RVA: 0x20B1A50
        public void GetLaunchQueryParam(){} // RVA: 0x20B1B10
        public void _GetLaunchCommandLine(){} // RVA: 0x20B1BD0
        public void GetLaunchCommandLine(){} // RVA: 0x20B1C70
    }

    public class ISteamFriends
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x20B1670
        public void SteamAPI_SteamFriends_v017(){} // RVA: 0x20B1F10
        public void GetUserInterfacePointer(){} // RVA: 0x20B1F10
        public void _GetPersonaName(){} // RVA: 0x20B1F80
        public void GetPersonaName(){} // RVA: 0x20B2000
        public void _GetFriendPersonaName(){} // RVA: 0x20B2090
        public void GetFriendPersonaName(){} // RVA: 0x20B2120
        public void _SetRichPresence(){} // RVA: 0x20B21C0
        public void SetRichPresence(){} // RVA: 0x20B22A0
        public void _ClearRichPresence(){} // RVA: 0x20B2380
        public void ClearRichPresence(){} // RVA: 0x20B2400
        public void _GetClanChatMessage(){} // RVA: 0x20B2480
        public void GetClanChatMessage(){} // RVA: 0x20B2530
        public void _GetFriendMessage(){} // RVA: 0x20B25E0
        public void GetFriendMessage(){} // RVA: 0x20B2690
    }

    public class ISteamInput
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x20B1670
        public void SteamAPI_SteamInput_v006(){} // RVA: 0x20B2740
        public void GetUserInterfacePointer(){} // RVA: 0x20B2740
    }

    public class ISteamInventory
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x20B1670
        public void SteamAPI_SteamInventory_v003(){} // RVA: 0x20B27B0
        public void GetUserInterfacePointer(){} // RVA: 0x20B27B0
        public void SteamAPI_SteamGameServerInventory_v003(){} // RVA: 0x20B2820
        public void GetServerInterfacePointer(){} // RVA: 0x20B2820
        public void _GetResultItems(){} // RVA: 0x20B2890
        public void GetResultItems(){} // RVA: 0x20B2940
        public void _GetResultItemProperty(){} // RVA: 0x20B29F0
        public void GetResultItemProperty(){} // RVA: 0x20B2AE0
        public void _DestroyResult(){} // RVA: 0x20B2DE0
        public void DestroyResult(){} // RVA: 0x20B2E70
        public void _GetItemDefinitionIDs(){} // RVA: 0x20B2F00
        public void GetItemDefinitionIDs(){} // RVA: 0x20B2FB0
    }

    public class ISteamMatchmaking
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x20B1670
        public void SteamAPI_SteamMatchmaking_v009(){} // RVA: 0x20B3060
        public void GetUserInterfacePointer(){} // RVA: 0x20B3060
        public void _GetLobbyChatEntry(){} // RVA: 0x20B30D0
        public void GetLobbyChatEntry(){} // RVA: 0x20B3180
    }

    public class ISteamMatchmakingServers
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x20B1670
        public void SteamAPI_SteamMatchmakingServers_v002(){} // RVA: 0x20B3230
        public void GetUserInterfacePointer(){} // RVA: 0x20B3230
    }

    public class ISteamMusic
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x20B1670
        public void SteamAPI_SteamMusic_v001(){} // RVA: 0x20B32A0
        public void GetUserInterfacePointer(){} // RVA: 0x20B32A0
    }

    public class ISteamNetworking
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x20B1670
        public void SteamAPI_SteamNetworking_v006(){} // RVA: 0x20B3310
        public void GetUserInterfacePointer(){} // RVA: 0x20B3310
        public void SteamAPI_SteamGameServerNetworking_v006(){} // RVA: 0x20B3380
        public void GetServerInterfacePointer(){} // RVA: 0x20B3380
    }

    public class ISteamNetworkingSockets
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x20B1670
        public void SteamAPI_SteamNetworkingSockets_SteamAPI_v012(){} // RVA: 0x20B33F0
        public void GetUserInterfacePointer(){} // RVA: 0x20B33F0
        public void SteamAPI_SteamGameServerNetworkingSockets_SteamAPI_v012(){} // RVA: 0x20B3460
        public void GetServerInterfacePointer(){} // RVA: 0x20B3460
        public void _AcceptConnection(){} // RVA: 0x20B34D0
        public void AcceptConnection(){} // RVA: 0x20B3560
        public void _CloseConnection(){} // RVA: 0x20B35F0
        public void CloseConnection(){} // RVA: 0x20B36D0
        public void _SetConnectionPollGroup(){} // RVA: 0x20B37B0
        public void SetConnectionPollGroup(){} // RVA: 0x20B3850
    }

    public class ISteamNetworkingUtils
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x20B1670
        public void SteamAPI_SteamNetworkingUtils_SteamAPI_v004(){} // RVA: 0x20B38F0
        public void GetGlobalInterfacePointer(){} // RVA: 0x20B38F0
        public void _SteamNetworkingIdentity_ToString(){} // RVA: 0x20B3960
        public void SteamNetworkingIdentity_ToString(){} // RVA: 0x20B3A10
    }

    public class ISteamParentalSettings
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x20B1670
        public void SteamAPI_SteamParentalSettings_v001(){} // RVA: 0x20B3CA0
        public void GetUserInterfacePointer(){} // RVA: 0x20B3CA0
    }

    public class ISteamParties
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x20B1670
        public void SteamAPI_SteamParties_v002(){} // RVA: 0x20B3D10
        public void GetUserInterfacePointer(){} // RVA: 0x20B3D10
    }

    public class ISteamRemotePlay
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x20B1670
        public void SteamAPI_SteamRemotePlay_v001(){} // RVA: 0x20B3D80
        public void GetUserInterfacePointer(){} // RVA: 0x20B3D80
    }

    public class ISteamRemoteStorage
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x20B1670
        public void SteamAPI_SteamRemoteStorage_v016(){} // RVA: 0x20B3DF0
        public void GetUserInterfacePointer(){} // RVA: 0x20B3DF0
    }

    public class ISteamScreenshots
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x20B1670
        public void SteamAPI_SteamScreenshots_v003(){} // RVA: 0x20B3E60
        public void GetUserInterfacePointer(){} // RVA: 0x20B3E60
    }

    public class ISteamUGC
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x20B1670
        public void SteamAPI_SteamUGC_v016(){} // RVA: 0x20B3ED0
        public void GetUserInterfacePointer(){} // RVA: 0x20B3ED0
        public void SteamAPI_SteamGameServerUGC_v016(){} // RVA: 0x20B3F40
        public void GetServerInterfacePointer(){} // RVA: 0x20B3F40
    }

    public class ISteamUser
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x20B1670
        public void SteamAPI_SteamUser_v021(){} // RVA: 0x20B3FB0
        public void GetUserInterfacePointer(){} // RVA: 0x20B3FB0
        public void _GetSteamID(){} // RVA: 0x20B4020
        public void GetSteamID(){} // RVA: 0x20B40A0
        public void _GetVoiceOptimalSampleRate(){} // RVA: 0x20B4120
        public void GetVoiceOptimalSampleRate(){} // RVA: 0x20B41A0
        public void _GetAuthSessionTicket(){} // RVA: 0x20B4220
        public void GetAuthSessionTicket(){} // RVA: 0x20B42D0
        public void _CancelAuthTicket(){} // RVA: 0x20B4380
        public void CancelAuthTicket(){} // RVA: 0x20B4410
    }

    public class ISteamUserStats
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x20B1670
        public void SteamAPI_SteamUserStats_v012(){} // RVA: 0x20B44A0
        public void GetUserInterfacePointer(){} // RVA: 0x20B44A0
        public void _RequestCurrentStats(){} // RVA: 0x20B4510
        public void RequestCurrentStats(){} // RVA: 0x20B4590
    }

    public class ISteamUtils
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x20B1670
        public void SteamAPI_SteamUtils_v010(){} // RVA: 0x20B4610
        public void GetUserInterfacePointer(){} // RVA: 0x20B4610
        public void SteamAPI_SteamGameServerUtils_v010(){} // RVA: 0x20B4680
        public void GetServerInterfacePointer(){} // RVA: 0x20B4680
        public void _IsSteamRunningOnSteamDeck(){} // RVA: 0x20B46F0
        public void IsSteamRunningOnSteamDeck(){} // RVA: 0x20B4770
    }

    public class ISteamVideo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x20B1670
        public void SteamAPI_SteamVideo_v002(){} // RVA: 0x20B47F0
        public void GetUserInterfacePointer(){} // RVA: 0x20B47F0
    }

    public class InventoryDef
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2E00C0
        public void get_Id(){} // RVA: 0x32A5C0
        public void op_Equality(){} // RVA: 0x20C5360
        public void Equals(){} // RVA: 0x20C5420 | overloaded x2
        public void GetHashCode(){} // RVA: 0x32A5C0
    }

    public class InventoryItem
    {
        // ── Methods ──
        public void From(){} // RVA: 0x20C5470
        public void GetProperties(){} // RVA: 0x20C54A0
        public void Equals(){} // RVA: 0x20C57D0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x20C57C0
    }

    public class InventoryResult
    {
        // ── Methods ──
        public void set_Expired(){} // RVA: 0x10EEB40
        public void .ctor(){} // RVA: 0x833590
        public void get_ItemCount(){} // RVA: 0x20C57E0
        public void GetItems(){} // RVA: 0x20C58A0
        public void Dispose(){} // RVA: 0x20C5B60
    }

    public class PreserveAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class SocketManager
    {
        // ── Methods ──
        public void get_Interface(){} // RVA: 0x2F8380
        public void OnConnectionChanged(){} // RVA: 0x20B4F40
        public void OnConnecting(){} // RVA: 0x20B5310
        public void OnConnected(){} // RVA: 0x20B5430
        public void OnDisconnected(){} // RVA: 0x20B5600
    }

    public class SteamAPI
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x20AC9F0
        public void Shutdown(){} // RVA: 0x20ACA60
        public void GetHSteamPipe(){} // RVA: 0x20ACAD0
        public void RestartAppIfNecessary(){} // RVA: 0x20ACB40
    }

    public class SteamApps
    {
        // ── Methods ──
        public void get_Internal(){} // RVA: 0x20B5750
        public void InitializeInterface(){} // RVA: 0x20B57F0
        public void add_OnNewLaunchParameters(){} // RVA: 0x20B5880
        public void remove_OnNewLaunchParameters(){} // RVA: 0x20B5990
        public void get_CurrentBetaName(){} // RVA: 0x20B5AA0
        public void GetLaunchParam(){} // RVA: 0x20B5AE0
        public void get_CommandLine(){} // RVA: 0x20B5BB0
        public void .ctor(){} // RVA: 0x20B5BF0
    }

    public class SteamClass
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x25130
        public void DestroyInterface(){} // RVA: 0x25130
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class SteamClient
    {
        public object isStartupFrame;
        public object `;

        // ── Methods ──
        public void Init(){} // RVA: 0x20B5C20
        public void AddInterface(){} // RVA: 0x24A80
        public void ShutdownInterfaces(){} // RVA: 0x20B6310
        public void get_IsValid(){} // RVA: 0x20B6500
        public void Shutdown(){} // RVA: 0x20B6560
        public void Cleanup(){} // RVA: 0x20B6670
        public void get_SteamId(){} // RVA: 0x20B6700
        public void get_Name(){} // RVA: 0x20B67D0
        public void set_AppId(){} // RVA: 0x20B6870
        public void RestartAppIfNecessary(){} // RVA: 0x20ACB40
        public void .cctor(){} // RVA: 0x20B68D0
    }

    public class SteamClientClass`1
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x25130
        public void SetInterface(){} // RVA: 0x25600
        public void DestroyInterface(){} // RVA: 0x25130
        public void .ctor(){} // RVA: 0x24A50
    }

    public class SteamFriends
    {
        // ── Methods ──
        public void get_Internal(){} // RVA: 0x20B69B0
        public void InitializeInterface(){} // RVA: 0x20B6A50
        public void InstallEvents(){} // RVA: 0x20B6B90
        public void OnFriendChatMessage(){} // RVA: 0x20B7C20
        public void OnGameConnectedClanChatMessage(){} // RVA: 0x20B7FA0
        public void SetRichPresence(){} // RVA: 0x20B8350
        public void ClearRichPresence(){} // RVA: 0x20B84E0
        public void .ctor(){} // RVA: 0x20B85D0
    }

    public class SteamId
    {
        // ── Methods ──
        public void op_Implicit(){} // RVA: 0x1A3F520 | overloaded x2
        public void ToString(){} // RVA: 0x20C5C10
    }

    public class SteamInput
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x20B8A20
        public void .ctor(){} // RVA: 0x20B8AB0
        public void .cctor(){} // RVA: 0x20B8AE0
    }

    public class SteamInterface
    {
        // ── Methods ──
        public void GetUserInterfacePointer(){} // RVA: 0x519240
        public void GetServerInterfacePointer(){} // RVA: 0x519240
        public void GetGlobalInterfacePointer(){} // RVA: 0x519240
        public void set_IsServer(){} // RVA: 0x303460
        public void SetupInterface(){} // RVA: 0x20C6970
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class SteamInventory
    {
        // ── Methods ──
        public void get_Internal(){} // RVA: 0x20B8F20
        public void InitializeInterface(){} // RVA: 0x20B8FC0
        public void InstallEvents(){} // RVA: 0x20B9050
        public void InventoryUpdated(){} // RVA: 0x20B94A0
        public void LoadDefinitions(){} // RVA: 0x20B95B0
        public void set_Items(){} // RVA: 0x20B9850
        public void get_Definitions(){} // RVA: 0x20B98F0
        public void set_Definitions(){} // RVA: 0x20B9930
        public void GetDefinitions(){} // RVA: 0x20B99D0
        public void .ctor(){} // RVA: 0x20B9CD0
    }

    public class SteamMatchmaking
    {
        // ── Methods ──
        public void get_Internal(){} // RVA: 0x20B9F00
        public void InitializeInterface(){} // RVA: 0x20B9FA0
        public void InstallEvents(){} // RVA: 0x20BA030
        public void OnLobbyChatMessageRecievedAPI(){} // RVA: 0x20BADA0
        public void .ctor(){} // RVA: 0x20BB160
    }

    public class SteamMatchmakingServers
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x20BB600
        public void .ctor(){} // RVA: 0x20BB690
    }

    public class SteamMusic
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x20BB6C0
        public void InstallEvents(){} // RVA: 0x20BB750
        public void .ctor(){} // RVA: 0x20BBBC0
    }

    public class SteamNetworking
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x20BBD50
        public void InstallEvents(){} // RVA: 0x20BBDE0
        public void .ctor(){} // RVA: 0x20BC230
    }

    public class SteamNetworkingSockets
    {
        // ── Methods ──
        public void get_Internal(){} // RVA: 0x20BC3D0
        public void InitializeInterface(){} // RVA: 0x20BC470
        public void GetSocketManager(){} // RVA: 0x20BC500
        public void GetConnectionManager(){} // RVA: 0x20BC620
        public void InstallEvents(){} // RVA: 0x20BC700
        public void ConnectionStatusChanged(){} // RVA: 0x20BC990
        public void FakeIPResult(){} // RVA: 0x20BD210
        public void .ctor(){} // RVA: 0x20BD390
        public void .cctor(){} // RVA: 0x20BD3C0
    }

    public class SteamNetworkingUtils
    {
        // ── Methods ──
        public void get_Internal(){} // RVA: 0x20BD560
        public void InitializeInterface(){} // RVA: 0x20BD600
        public void InstallCallbacks(){} // RVA: 0x20BD6C0
        public void set_Status(){} // RVA: 0x20BD910
        public void OutputDebugMessages(){} // RVA: 0x20BD970
        public void .ctor(){} // RVA: 0x20BDBA0
        public void .cctor(){} // RVA: 0x20BDBD0
    }

    public class SteamParental
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x20BDF90
        public void InstallEvents(){} // RVA: 0x20BE020
        public void .ctor(){} // RVA: 0x20BE270
    }

    public class SteamParties
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x20BE3A0
        public void InstallEvents(){} // RVA: 0x20BE430
        public void .ctor(){} // RVA: 0x20BE880
    }

    public class SteamRemotePlay
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x20BEA10
        public void InstallEvents(){} // RVA: 0x20BEAA0
        public void .ctor(){} // RVA: 0x20BEEF0
    }

    public class SteamRemoteStorage
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x20BF080
        public void .ctor(){} // RVA: 0x20BF110
    }

    public class SteamScreenshots
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x20BF140
        public void InstallEvents(){} // RVA: 0x20BF1D0
        public void .ctor(){} // RVA: 0x20BF640
    }

    public class SteamSharedClass`1
    {
        // ── Methods ──
        public void get_Interface(){} // RVA: 0xC960
        public void InitializeInterface(){} // RVA: 0x25130
        public void SetInterface(){} // RVA: 0x25600
        public void DestroyInterface(){} // RVA: 0x25130
        public void .ctor(){} // RVA: 0x24A50
    }

    public class SteamUGC
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x20BF7F0
        public void InstallEvents(){} // RVA: 0x20BF880
        public void .ctor(){} // RVA: 0x20C00D0
    }

    public class SteamUser
    {
        // ── Methods ──
        public void get_Internal(){} // RVA: 0x20C0360
        public void InitializeInterface(){} // RVA: 0x20C0400
        public void InstallEvents(){} // RVA: 0x20C0770
        public void add_OnMicroTxnAuthorizationResponse(){} // RVA: 0x20C1BB0
        public void remove_OnMicroTxnAuthorizationResponse(){} // RVA: 0x20C1D10
        public void get_SampleRate(){} // RVA: 0x20C1E70
        public void set_SampleRate(){} // RVA: 0x20C1ED0
        public void get_OptimalSampleRate(){} // RVA: 0x20C2040
        public void GetAuthSessionTicket(){} // RVA: 0x20C2110
        public void .ctor(){} // RVA: 0x20C2460
        public void .cctor(){} // RVA: 0x20C2490
    }

    public class SteamUserStats
    {
        // ── Methods ──
        public void get_Internal(){} // RVA: 0x20C2B30
        public void InitializeInterface(){} // RVA: 0x20C2BD0
        public void set_StatsRecieved(){} // RVA: 0x20C2D60
        public void InstallEvents(){} // RVA: 0x20C2DA0
        public void RequestCurrentStats(){} // RVA: 0x20C37F0
        public void .ctor(){} // RVA: 0x20C3910
    }

    public class SteamUtils
    {
        // ── Methods ──
        public void get_Internal(){} // RVA: 0x20C3D40
        public void InitializeInterface(){} // RVA: 0x20C3DE0
        public void InstallEvents(){} // RVA: 0x20C3EA0
        public void SteamClosed(){} // RVA: 0x20C48F0
        public void add_OnAppResumingFromSuspend(){} // RVA: 0x20C4990
        public void remove_OnAppResumingFromSuspend(){} // RVA: 0x20C4AE0
        public void get_IsRunningOnSteamDeck(){} // RVA: 0x20C4C30
        public void .ctor(){} // RVA: 0x20C4D80
        public void .cctor(){} // RVA: 0x20C4DB0
    }

    public class SteamVideo
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x20C5140
        public void InstallEvents(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x20C51D0
    }

    public class Utf8StringPointer
    {
        // ── Methods ──
        public void op_Implicit(){} // RVA: 0x20C6C80
    }

    public class Utf8StringToNative
    {
        // ── Methods ──
        public void MarshalManagedToNative(){} // RVA: 0x20C6A00
        public void MarshalNativeToManaged(){} // RVA: 0x20C6B70
        public void CleanUpNativeData(){} // RVA: 0x20C6BB0
        public void CleanUpManagedData(){} // RVA: 0x20C6C00
        public void GetNativeDataSize(){} // RVA: 0x75BB20
        public void GetInstance(){} // RVA: 0x20C6C40
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class Utility
    {
        // ── Methods ──
        public void ToType(){} // RVA: 0x20C6D20 | overloaded x2
        public void Swap(){} // RVA: 0x20C6D90
        public void IpToInt32(){} // RVA: 0x20C6DA0
        public void Int32ToIp(){} // RVA: 0x20C6E40
        public void .cctor(){} // RVA: 0x20C6EC0
    }

}