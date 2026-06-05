// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Steamworks
// Classes: 85
// Methods: 424

namespace ThirdParty.Other.Steamworks
{
    public class AppId
    {
        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFAF4B75200
        public void op_Implicit(){} // RVA: 0x7FFAF4B75210
    }

    public class AuthTicket
    {
        // ── Methods ──
        public void Cancel(){} // RVA: 0x7FFAF4B59D70
        public void Dispose(){} // RVA: 0x7FFAF4B59EB0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class CallbackTypeFactory
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF4B5CBC0
    }

    public class ConnectionManager
    {
        // ── Methods ──
        public void get_Interface(){} // RVA: 0x7FFAF2DA8380
        public void set_ConnectionInfo(){} // RVA: 0x7FFAF4B64860
        public void OnConnectionChanged(){} // RVA: 0x7FFAF4B64940
        public void OnConnecting(){} // RVA: 0x7FFAF4B64C80
        public void OnConnected(){} // RVA: 0x7FFAF4B64D60
        public void OnDisconnected(){} // RVA: 0x7FFAF4B64E50
    }

    public class Dispatch
    {
        // ── Methods ──
        public void SteamAPI_ManualDispatch_Init(){} // RVA: 0x7FFAF4B59EC0
        public void SteamAPI_ManualDispatch_RunFrame(){} // RVA: 0x7FFAF4B59F30
        public void SteamAPI_ManualDispatch_GetNextCallback(){} // RVA: 0x7FFAF4B59FB0
        public void SteamAPI_ManualDispatch_FreeLastCallback(){} // RVA: 0x7FFAF4B5A040
        public void get_ClientPipe(){} // RVA: 0x7FFAF4B5A0C0
        public void set_ClientPipe(){} // RVA: 0x7FFAF4B5A120
        public void get_ServerPipe(){} // RVA: 0x7FFAF4B5A180
        public void Init(){} // RVA: 0x7FFAF4B5A1E0
        public void Frame(){} // RVA: 0x7FFAF4B5A280
        public void ProcessCallback(){} // RVA: 0x7FFAF4B5A6E0
        public void CallbackToString(){} // RVA: 0x7FFAF4B5ACA0
        public void ProcessResult(){} // RVA: 0x7FFAF4B5B460
        public void LoopClientAsync(){} // RVA: 0x7FFAF4B5B7A0
        public void Install(){} // RVA: 0x7FFAF2ADA400
        public void ShutdownClient(){} // RVA: 0x7FFAF4B5B8F0
        public void .cctor(){} // RVA: 0x7FFAF4B5C220
    }

    public class Friend
    {
        public object Id;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF45C2320
        public void ToString(){} // RVA: 0x7FFAF4B75220
        public void get_Name(){} // RVA: 0x7FFAF4B752B0
    }

    public class Helpers
    {
        // ── Methods ──
        public void TakeMemory(){} // RVA: 0x7FFAF4B75C20
        public void TakeBuffer(){} // RVA: 0x7FFAF4B75C70
        public void MemoryToString(){} // RVA: 0x7FFAF4B76050
        public void .cctor(){} // RVA: 0x7FFAF4B76120
    }

    public class ICallbackData
    {
        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAF2ABD840
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
        public void .ctor(){} // RVA: 0x7FFAF4B61670
        public void SteamAPI_SteamApps_v008(){} // RVA: 0x7FFAF4B61680
        public void GetUserInterfacePointer(){} // RVA: 0x7FFAF4B61680
        public void _GetCurrentBetaName(){} // RVA: 0x7FFAF4B616F0
        public void GetCurrentBetaName(){} // RVA: 0x7FFAF4B61790
        public void _GetLaunchQueryParam(){} // RVA: 0x7FFAF4B61A50
        public void GetLaunchQueryParam(){} // RVA: 0x7FFAF4B61B10
        public void _GetLaunchCommandLine(){} // RVA: 0x7FFAF4B61BD0
        public void GetLaunchCommandLine(){} // RVA: 0x7FFAF4B61C70
    }

    public class ISteamFriends
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF4B61670
        public void SteamAPI_SteamFriends_v017(){} // RVA: 0x7FFAF4B61F10
        public void GetUserInterfacePointer(){} // RVA: 0x7FFAF4B61F10
        public void _GetPersonaName(){} // RVA: 0x7FFAF4B61F80
        public void GetPersonaName(){} // RVA: 0x7FFAF4B62000
        public void _GetFriendPersonaName(){} // RVA: 0x7FFAF4B62090
        public void GetFriendPersonaName(){} // RVA: 0x7FFAF4B62120
        public void _SetRichPresence(){} // RVA: 0x7FFAF4B621C0
        public void SetRichPresence(){} // RVA: 0x7FFAF4B622A0
        public void _ClearRichPresence(){} // RVA: 0x7FFAF4B62380
        public void ClearRichPresence(){} // RVA: 0x7FFAF4B62400
        public void _GetClanChatMessage(){} // RVA: 0x7FFAF4B62480
        public void GetClanChatMessage(){} // RVA: 0x7FFAF4B62530
        public void _GetFriendMessage(){} // RVA: 0x7FFAF4B625E0
        public void GetFriendMessage(){} // RVA: 0x7FFAF4B62690
    }

    public class ISteamInput
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF4B61670
        public void SteamAPI_SteamInput_v006(){} // RVA: 0x7FFAF4B62740
        public void GetUserInterfacePointer(){} // RVA: 0x7FFAF4B62740
    }

    public class ISteamInventory
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF4B61670
        public void SteamAPI_SteamInventory_v003(){} // RVA: 0x7FFAF4B627B0
        public void GetUserInterfacePointer(){} // RVA: 0x7FFAF4B627B0
        public void SteamAPI_SteamGameServerInventory_v003(){} // RVA: 0x7FFAF4B62820
        public void GetServerInterfacePointer(){} // RVA: 0x7FFAF4B62820
        public void _GetResultItems(){} // RVA: 0x7FFAF4B62890
        public void GetResultItems(){} // RVA: 0x7FFAF4B62940
        public void _GetResultItemProperty(){} // RVA: 0x7FFAF4B629F0
        public void GetResultItemProperty(){} // RVA: 0x7FFAF4B62AE0
        public void _DestroyResult(){} // RVA: 0x7FFAF4B62DE0
        public void DestroyResult(){} // RVA: 0x7FFAF4B62E70
        public void _GetItemDefinitionIDs(){} // RVA: 0x7FFAF4B62F00
        public void GetItemDefinitionIDs(){} // RVA: 0x7FFAF4B62FB0
    }

    public class ISteamMatchmaking
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF4B61670
        public void SteamAPI_SteamMatchmaking_v009(){} // RVA: 0x7FFAF4B63060
        public void GetUserInterfacePointer(){} // RVA: 0x7FFAF4B63060
        public void _GetLobbyChatEntry(){} // RVA: 0x7FFAF4B630D0
        public void GetLobbyChatEntry(){} // RVA: 0x7FFAF4B63180
    }

    public class ISteamMatchmakingServers
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF4B61670
        public void SteamAPI_SteamMatchmakingServers_v002(){} // RVA: 0x7FFAF4B63230
        public void GetUserInterfacePointer(){} // RVA: 0x7FFAF4B63230
    }

    public class ISteamMusic
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF4B61670
        public void SteamAPI_SteamMusic_v001(){} // RVA: 0x7FFAF4B632A0
        public void GetUserInterfacePointer(){} // RVA: 0x7FFAF4B632A0
    }

    public class ISteamNetworking
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF4B61670
        public void SteamAPI_SteamNetworking_v006(){} // RVA: 0x7FFAF4B63310
        public void GetUserInterfacePointer(){} // RVA: 0x7FFAF4B63310
        public void SteamAPI_SteamGameServerNetworking_v006(){} // RVA: 0x7FFAF4B63380
        public void GetServerInterfacePointer(){} // RVA: 0x7FFAF4B63380
    }

    public class ISteamNetworkingSockets
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF4B61670
        public void SteamAPI_SteamNetworkingSockets_SteamAPI_v012(){} // RVA: 0x7FFAF4B633F0
        public void GetUserInterfacePointer(){} // RVA: 0x7FFAF4B633F0
        public void SteamAPI_SteamGameServerNetworkingSockets_SteamAPI_v012(){} // RVA: 0x7FFAF4B63460
        public void GetServerInterfacePointer(){} // RVA: 0x7FFAF4B63460
        public void _AcceptConnection(){} // RVA: 0x7FFAF4B634D0
        public void AcceptConnection(){} // RVA: 0x7FFAF4B63560
        public void _CloseConnection(){} // RVA: 0x7FFAF4B635F0
        public void CloseConnection(){} // RVA: 0x7FFAF4B636D0
        public void _SetConnectionPollGroup(){} // RVA: 0x7FFAF4B637B0
        public void SetConnectionPollGroup(){} // RVA: 0x7FFAF4B63850
    }

    public class ISteamNetworkingUtils
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF4B61670
        public void SteamAPI_SteamNetworkingUtils_SteamAPI_v004(){} // RVA: 0x7FFAF4B638F0
        public void GetGlobalInterfacePointer(){} // RVA: 0x7FFAF4B638F0
        public void _SteamNetworkingIdentity_ToString(){} // RVA: 0x7FFAF4B63960
        public void SteamNetworkingIdentity_ToString(){} // RVA: 0x7FFAF4B63A10
    }

    public class ISteamParentalSettings
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF4B61670
        public void SteamAPI_SteamParentalSettings_v001(){} // RVA: 0x7FFAF4B63CA0
        public void GetUserInterfacePointer(){} // RVA: 0x7FFAF4B63CA0
    }

    public class ISteamParties
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF4B61670
        public void SteamAPI_SteamParties_v002(){} // RVA: 0x7FFAF4B63D10
        public void GetUserInterfacePointer(){} // RVA: 0x7FFAF4B63D10
    }

    public class ISteamRemotePlay
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF4B61670
        public void SteamAPI_SteamRemotePlay_v001(){} // RVA: 0x7FFAF4B63D80
        public void GetUserInterfacePointer(){} // RVA: 0x7FFAF4B63D80
    }

    public class ISteamRemoteStorage
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF4B61670
        public void SteamAPI_SteamRemoteStorage_v016(){} // RVA: 0x7FFAF4B63DF0
        public void GetUserInterfacePointer(){} // RVA: 0x7FFAF4B63DF0
    }

    public class ISteamScreenshots
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF4B61670
        public void SteamAPI_SteamScreenshots_v003(){} // RVA: 0x7FFAF4B63E60
        public void GetUserInterfacePointer(){} // RVA: 0x7FFAF4B63E60
    }

    public class ISteamUGC
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF4B61670
        public void SteamAPI_SteamUGC_v016(){} // RVA: 0x7FFAF4B63ED0
        public void GetUserInterfacePointer(){} // RVA: 0x7FFAF4B63ED0
        public void SteamAPI_SteamGameServerUGC_v016(){} // RVA: 0x7FFAF4B63F40
        public void GetServerInterfacePointer(){} // RVA: 0x7FFAF4B63F40
    }

    public class ISteamUser
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF4B61670
        public void SteamAPI_SteamUser_v021(){} // RVA: 0x7FFAF4B63FB0
        public void GetUserInterfacePointer(){} // RVA: 0x7FFAF4B63FB0
        public void _GetSteamID(){} // RVA: 0x7FFAF4B64020
        public void GetSteamID(){} // RVA: 0x7FFAF4B640A0
        public void _GetVoiceOptimalSampleRate(){} // RVA: 0x7FFAF4B64120
        public void GetVoiceOptimalSampleRate(){} // RVA: 0x7FFAF4B641A0
        public void _GetAuthSessionTicket(){} // RVA: 0x7FFAF4B64220
        public void GetAuthSessionTicket(){} // RVA: 0x7FFAF4B642D0
        public void _CancelAuthTicket(){} // RVA: 0x7FFAF4B64380
        public void CancelAuthTicket(){} // RVA: 0x7FFAF4B64410
    }

    public class ISteamUserStats
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF4B61670
        public void SteamAPI_SteamUserStats_v012(){} // RVA: 0x7FFAF4B644A0
        public void GetUserInterfacePointer(){} // RVA: 0x7FFAF4B644A0
        public void _RequestCurrentStats(){} // RVA: 0x7FFAF4B64510
        public void RequestCurrentStats(){} // RVA: 0x7FFAF4B64590
    }

    public class ISteamUtils
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF4B61670
        public void SteamAPI_SteamUtils_v010(){} // RVA: 0x7FFAF4B64610
        public void GetUserInterfacePointer(){} // RVA: 0x7FFAF4B64610
        public void SteamAPI_SteamGameServerUtils_v010(){} // RVA: 0x7FFAF4B64680
        public void GetServerInterfacePointer(){} // RVA: 0x7FFAF4B64680
        public void _IsSteamRunningOnSteamDeck(){} // RVA: 0x7FFAF4B646F0
        public void IsSteamRunningOnSteamDeck(){} // RVA: 0x7FFAF4B64770
    }

    public class ISteamVideo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF4B61670
        public void SteamAPI_SteamVideo_v002(){} // RVA: 0x7FFAF4B647F0
        public void GetUserInterfacePointer(){} // RVA: 0x7FFAF4B647F0
    }

    public class InventoryDef
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D900C0
        public void get_Id(){} // RVA: 0x7FFAF2DDA5C0
        public void op_Equality(){} // RVA: 0x7FFAF4B75360
        public void Equals(){} // RVA: 0x7FFAF4B75420 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF2DDA5C0
    }

    public class InventoryItem
    {
        // ── Methods ──
        public void From(){} // RVA: 0x7FFAF4B75470
        public void GetProperties(){} // RVA: 0x7FFAF4B754A0
        public void Equals(){} // RVA: 0x7FFAF4B757D0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF4B757C0
    }

    public class InventoryResult
    {
        // ── Methods ──
        public void set_Expired(){} // RVA: 0x7FFAF3B9EB40
        public void .ctor(){} // RVA: 0x7FFAF32E3590
        public void get_ItemCount(){} // RVA: 0x7FFAF4B757E0
        public void GetItems(){} // RVA: 0x7FFAF4B758A0
        public void Dispose(){} // RVA: 0x7FFAF4B75B60
    }

    public class PreserveAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class SocketManager
    {
        // ── Methods ──
        public void get_Interface(){} // RVA: 0x7FFAF2DA8380
        public void OnConnectionChanged(){} // RVA: 0x7FFAF4B64F40
        public void OnConnecting(){} // RVA: 0x7FFAF4B65310
        public void OnConnected(){} // RVA: 0x7FFAF4B65430
        public void OnDisconnected(){} // RVA: 0x7FFAF4B65600
    }

    public class SteamAPI
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAF4B5C9F0
        public void Shutdown(){} // RVA: 0x7FFAF4B5CA60
        public void GetHSteamPipe(){} // RVA: 0x7FFAF4B5CAD0
        public void RestartAppIfNecessary(){} // RVA: 0x7FFAF4B5CB40
    }

    public class SteamApps
    {
        // ── Methods ──
        public void get_Internal(){} // RVA: 0x7FFAF4B65750
        public void InitializeInterface(){} // RVA: 0x7FFAF4B657F0
        public void add_OnNewLaunchParameters(){} // RVA: 0x7FFAF4B65880
        public void remove_OnNewLaunchParameters(){} // RVA: 0x7FFAF4B65990
        public void get_CurrentBetaName(){} // RVA: 0x7FFAF4B65AA0
        public void GetLaunchParam(){} // RVA: 0x7FFAF4B65AE0
        public void get_CommandLine(){} // RVA: 0x7FFAF4B65BB0
        public void .ctor(){} // RVA: 0x7FFAF4B65BF0
    }

    public class SteamClass
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7FFAF2AD5130
        public void DestroyInterface(){} // RVA: 0x7FFAF2AD5130
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class SteamClient
    {
        public object isStartupFrame;
        public object `;

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAF4B65C20
        public void AddInterface(){} // RVA: 0x7FFAF2AD4A80
        public void ShutdownInterfaces(){} // RVA: 0x7FFAF4B66310
        public void get_IsValid(){} // RVA: 0x7FFAF4B66500
        public void Shutdown(){} // RVA: 0x7FFAF4B66560
        public void Cleanup(){} // RVA: 0x7FFAF4B66670
        public void get_SteamId(){} // RVA: 0x7FFAF4B66700
        public void get_Name(){} // RVA: 0x7FFAF4B667D0
        public void set_AppId(){} // RVA: 0x7FFAF4B66870
        public void RestartAppIfNecessary(){} // RVA: 0x7FFAF4B5CB40
        public void .cctor(){} // RVA: 0x7FFAF4B668D0
    }

    public class SteamClientClass`1
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7FFAF2AD5130
        public void SetInterface(){} // RVA: 0x7FFAF2AD5600
        public void DestroyInterface(){} // RVA: 0x7FFAF2AD5130
        public void .ctor(){} // RVA: 0x7FFAF2AD4A50
    }

    public class SteamClientClass`1
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7FFAF2D8D310
        public void SetInterface(){} // RVA: 0x7FFAF6B3CCB0
        public void DestroyInterface(){} // RVA: 0x7FFAF6B3CDA0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class SteamClientClass`1
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7FFAF2D8D310
        public void SetInterface(){} // RVA: 0x7FFAF6B3CCB0
        public void DestroyInterface(){} // RVA: 0x7FFAF6B3CDA0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class SteamClientClass`1
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7FFAF2D8D310
        public void SetInterface(){} // RVA: 0x7FFAF6B3CCB0
        public void DestroyInterface(){} // RVA: 0x7FFAF6B3CDA0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class SteamClientClass`1
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7FFAF2D8D310
        public void SetInterface(){} // RVA: 0x7FFAF6B3CCB0
        public void DestroyInterface(){} // RVA: 0x7FFAF6B3CDA0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class SteamClientClass`1
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7FFAF2D8D310
        public void SetInterface(){} // RVA: 0x7FFAF6B3CCB0
        public void DestroyInterface(){} // RVA: 0x7FFAF6B3CDA0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class SteamClientClass`1
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7FFAF2D8D310
        public void SetInterface(){} // RVA: 0x7FFAF6B3CCB0
        public void DestroyInterface(){} // RVA: 0x7FFAF6B3CDA0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class SteamClientClass`1
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7FFAF2D8D310
        public void SetInterface(){} // RVA: 0x7FFAF6B3CCB0
        public void DestroyInterface(){} // RVA: 0x7FFAF6B3CDA0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class SteamClientClass`1
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7FFAF2D8D310
        public void SetInterface(){} // RVA: 0x7FFAF6B3CCB0
        public void DestroyInterface(){} // RVA: 0x7FFAF6B3CDA0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class SteamClientClass`1
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7FFAF2D8D310
        public void SetInterface(){} // RVA: 0x7FFAF6B3CCB0
        public void DestroyInterface(){} // RVA: 0x7FFAF6B3CDA0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class SteamClientClass`1
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7FFAF2D8D310
        public void SetInterface(){} // RVA: 0x7FFAF6B3CCB0
        public void DestroyInterface(){} // RVA: 0x7FFAF6B3CDA0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class SteamClientClass`1
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7FFAF2D8D310
        public void SetInterface(){} // RVA: 0x7FFAF6B3CCB0
        public void DestroyInterface(){} // RVA: 0x7FFAF6B3CDA0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class SteamClientClass`1
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7FFAF2D8D310
        public void SetInterface(){} // RVA: 0x7FFAF6B3CCB0
        public void DestroyInterface(){} // RVA: 0x7FFAF6B3CDA0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class SteamFriends
    {
        // ── Methods ──
        public void get_Internal(){} // RVA: 0x7FFAF4B669B0
        public void InitializeInterface(){} // RVA: 0x7FFAF4B66A50
        public void InstallEvents(){} // RVA: 0x7FFAF4B66B90
        public void OnFriendChatMessage(){} // RVA: 0x7FFAF4B67C20
        public void OnGameConnectedClanChatMessage(){} // RVA: 0x7FFAF4B67FA0
        public void SetRichPresence(){} // RVA: 0x7FFAF4B68350
        public void ClearRichPresence(){} // RVA: 0x7FFAF4B684E0
        public void .ctor(){} // RVA: 0x7FFAF4B685D0
    }

    public class SteamId
    {
        // ── Methods ──
        public void op_Implicit(){} // RVA: 0x7FFAF44EF520 | overloaded x2
        public void ToString(){} // RVA: 0x7FFAF4B75C10
    }

    public class SteamInput
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7FFAF4B68A20
        public void .ctor(){} // RVA: 0x7FFAF4B68AB0
        public void .cctor(){} // RVA: 0x7FFAF4B68AE0
    }

    public class SteamInterface
    {
        // ── Methods ──
        public void GetUserInterfacePointer(){} // RVA: 0x7FFAF2FC9240
        public void GetServerInterfacePointer(){} // RVA: 0x7FFAF2FC9240
        public void GetGlobalInterfacePointer(){} // RVA: 0x7FFAF2FC9240
        public void set_IsServer(){} // RVA: 0x7FFAF2DB3460
        public void SetupInterface(){} // RVA: 0x7FFAF4B76970
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class SteamInventory
    {
        // ── Methods ──
        public void get_Internal(){} // RVA: 0x7FFAF4B68F20
        public void InitializeInterface(){} // RVA: 0x7FFAF4B68FC0
        public void InstallEvents(){} // RVA: 0x7FFAF4B69050
        public void InventoryUpdated(){} // RVA: 0x7FFAF4B694A0
        public void LoadDefinitions(){} // RVA: 0x7FFAF4B695B0
        public void set_Items(){} // RVA: 0x7FFAF4B69850
        public void get_Definitions(){} // RVA: 0x7FFAF4B698F0
        public void set_Definitions(){} // RVA: 0x7FFAF4B69930
        public void GetDefinitions(){} // RVA: 0x7FFAF4B699D0
        public void .ctor(){} // RVA: 0x7FFAF4B69CD0
    }

    public class SteamMatchmaking
    {
        // ── Methods ──
        public void get_Internal(){} // RVA: 0x7FFAF4B69F00
        public void InitializeInterface(){} // RVA: 0x7FFAF4B69FA0
        public void InstallEvents(){} // RVA: 0x7FFAF4B6A030
        public void OnLobbyChatMessageRecievedAPI(){} // RVA: 0x7FFAF4B6ADA0
        public void .ctor(){} // RVA: 0x7FFAF4B6B160
    }

    public class SteamMatchmakingServers
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7FFAF4B6B600
        public void .ctor(){} // RVA: 0x7FFAF4B6B690
    }

    public class SteamMusic
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7FFAF4B6B6C0
        public void InstallEvents(){} // RVA: 0x7FFAF4B6B750
        public void .ctor(){} // RVA: 0x7FFAF4B6BBC0
    }

    public class SteamNetworking
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7FFAF4B6BD50
        public void InstallEvents(){} // RVA: 0x7FFAF4B6BDE0
        public void .ctor(){} // RVA: 0x7FFAF4B6C230
    }

    public class SteamNetworkingSockets
    {
        // ── Methods ──
        public void get_Internal(){} // RVA: 0x7FFAF4B6C3D0
        public void InitializeInterface(){} // RVA: 0x7FFAF4B6C470
        public void GetSocketManager(){} // RVA: 0x7FFAF4B6C500
        public void GetConnectionManager(){} // RVA: 0x7FFAF4B6C620
        public void InstallEvents(){} // RVA: 0x7FFAF4B6C700
        public void ConnectionStatusChanged(){} // RVA: 0x7FFAF4B6C990
        public void FakeIPResult(){} // RVA: 0x7FFAF4B6D210
        public void .ctor(){} // RVA: 0x7FFAF4B6D390
        public void .cctor(){} // RVA: 0x7FFAF4B6D3C0
    }

    public class SteamNetworkingUtils
    {
        // ── Methods ──
        public void get_Internal(){} // RVA: 0x7FFAF4B6D560
        public void InitializeInterface(){} // RVA: 0x7FFAF4B6D600
        public void InstallCallbacks(){} // RVA: 0x7FFAF4B6D6C0
        public void set_Status(){} // RVA: 0x7FFAF4B6D910
        public void OutputDebugMessages(){} // RVA: 0x7FFAF4B6D970
        public void .ctor(){} // RVA: 0x7FFAF4B6DBA0
        public void .cctor(){} // RVA: 0x7FFAF4B6DBD0
    }

    public class SteamParental
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7FFAF4B6DF90
        public void InstallEvents(){} // RVA: 0x7FFAF4B6E020
        public void .ctor(){} // RVA: 0x7FFAF4B6E270
    }

    public class SteamParties
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7FFAF4B6E3A0
        public void InstallEvents(){} // RVA: 0x7FFAF4B6E430
        public void .ctor(){} // RVA: 0x7FFAF4B6E880
    }

    public class SteamRemotePlay
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7FFAF4B6EA10
        public void InstallEvents(){} // RVA: 0x7FFAF4B6EAA0
        public void .ctor(){} // RVA: 0x7FFAF4B6EEF0
    }

    public class SteamRemoteStorage
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7FFAF4B6F080
        public void .ctor(){} // RVA: 0x7FFAF4B6F110
    }

    public class SteamScreenshots
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7FFAF4B6F140
        public void InstallEvents(){} // RVA: 0x7FFAF4B6F1D0
        public void .ctor(){} // RVA: 0x7FFAF4B6F640
    }

    public class SteamSharedClass`1
    {
        // ── Methods ──
        public void get_Interface(){} // RVA: 0x7FFAF2ABC960
        public void InitializeInterface(){} // RVA: 0x7FFAF2AD5130
        public void SetInterface(){} // RVA: 0x7FFAF2AD5600
        public void DestroyInterface(){} // RVA: 0x7FFAF2AD5130
        public void .ctor(){} // RVA: 0x7FFAF2AD4A50
    }

    public class SteamSharedClass`1
    {
        // ── Methods ──
        public void get_Interface(){} // RVA: 0x7FFAF6B3CE50
        public void InitializeInterface(){} // RVA: 0x7FFAF2D8D310
        public void SetInterface(){} // RVA: 0x7FFAF6B3CEE0
        public void DestroyInterface(){} // RVA: 0x7FFAF6B3D060
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class SteamSharedClass`1
    {
        // ── Methods ──
        public void get_Interface(){} // RVA: 0x7FFAF6B3CE50
        public void InitializeInterface(){} // RVA: 0x7FFAF2D8D310
        public void SetInterface(){} // RVA: 0x7FFAF6B3CEE0
        public void DestroyInterface(){} // RVA: 0x7FFAF6B3D060
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class SteamSharedClass`1
    {
        // ── Methods ──
        public void get_Interface(){} // RVA: 0x7FFAF6B3CE50
        public void InitializeInterface(){} // RVA: 0x7FFAF2D8D310
        public void SetInterface(){} // RVA: 0x7FFAF6B3CEE0
        public void DestroyInterface(){} // RVA: 0x7FFAF6B3D060
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class SteamSharedClass`1
    {
        // ── Methods ──
        public void get_Interface(){} // RVA: 0x7FFAF6B3CE50
        public void InitializeInterface(){} // RVA: 0x7FFAF2D8D310
        public void SetInterface(){} // RVA: 0x7FFAF6B3CEE0
        public void DestroyInterface(){} // RVA: 0x7FFAF6B3D060
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class SteamSharedClass`1
    {
        // ── Methods ──
        public void get_Interface(){} // RVA: 0x7FFAF6B3CE50
        public void InitializeInterface(){} // RVA: 0x7FFAF2D8D310
        public void SetInterface(){} // RVA: 0x7FFAF6B3CEE0
        public void DestroyInterface(){} // RVA: 0x7FFAF6B3D060
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class SteamSharedClass`1
    {
        // ── Methods ──
        public void get_Interface(){} // RVA: 0x7FFAF6B3CE50
        public void InitializeInterface(){} // RVA: 0x7FFAF2D8D310
        public void SetInterface(){} // RVA: 0x7FFAF6B3CEE0
        public void DestroyInterface(){} // RVA: 0x7FFAF6B3D060
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class SteamSharedClass`1
    {
        // ── Methods ──
        public void get_Interface(){} // RVA: 0x7FFAF6B3CE50
        public void InitializeInterface(){} // RVA: 0x7FFAF2D8D310
        public void SetInterface(){} // RVA: 0x7FFAF6B3CEE0
        public void DestroyInterface(){} // RVA: 0x7FFAF6B3D060
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class SteamSharedClass`1
    {
        // ── Methods ──
        public void get_Interface(){} // RVA: 0x7FFAF6B3CE50
        public void InitializeInterface(){} // RVA: 0x7FFAF2D8D310
        public void SetInterface(){} // RVA: 0x7FFAF6B3CEE0
        public void DestroyInterface(){} // RVA: 0x7FFAF6B3D060
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class SteamUGC
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7FFAF4B6F7F0
        public void InstallEvents(){} // RVA: 0x7FFAF4B6F880
        public void .ctor(){} // RVA: 0x7FFAF4B700D0
    }

    public class SteamUser
    {
        // ── Methods ──
        public void get_Internal(){} // RVA: 0x7FFAF4B70360
        public void InitializeInterface(){} // RVA: 0x7FFAF4B70400
        public void InstallEvents(){} // RVA: 0x7FFAF4B70770
        public void add_OnMicroTxnAuthorizationResponse(){} // RVA: 0x7FFAF4B71BB0
        public void remove_OnMicroTxnAuthorizationResponse(){} // RVA: 0x7FFAF4B71D10
        public void get_SampleRate(){} // RVA: 0x7FFAF4B71E70
        public void set_SampleRate(){} // RVA: 0x7FFAF4B71ED0
        public void get_OptimalSampleRate(){} // RVA: 0x7FFAF4B72040
        public void GetAuthSessionTicket(){} // RVA: 0x7FFAF4B72110
        public void .ctor(){} // RVA: 0x7FFAF4B72460
        public void .cctor(){} // RVA: 0x7FFAF4B72490
    }

    public class SteamUserStats
    {
        // ── Methods ──
        public void get_Internal(){} // RVA: 0x7FFAF4B72B30
        public void InitializeInterface(){} // RVA: 0x7FFAF4B72BD0
        public void set_StatsRecieved(){} // RVA: 0x7FFAF4B72D60
        public void InstallEvents(){} // RVA: 0x7FFAF4B72DA0
        public void RequestCurrentStats(){} // RVA: 0x7FFAF4B737F0
        public void .ctor(){} // RVA: 0x7FFAF4B73910
    }

    public class SteamUtils
    {
        // ── Methods ──
        public void get_Internal(){} // RVA: 0x7FFAF4B73D40
        public void InitializeInterface(){} // RVA: 0x7FFAF4B73DE0
        public void InstallEvents(){} // RVA: 0x7FFAF4B73EA0
        public void SteamClosed(){} // RVA: 0x7FFAF4B748F0
        public void add_OnAppResumingFromSuspend(){} // RVA: 0x7FFAF4B74990
        public void remove_OnAppResumingFromSuspend(){} // RVA: 0x7FFAF4B74AE0
        public void get_IsRunningOnSteamDeck(){} // RVA: 0x7FFAF4B74C30
        public void .ctor(){} // RVA: 0x7FFAF4B74D80
        public void .cctor(){} // RVA: 0x7FFAF4B74DB0
    }

    public class SteamVideo
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7FFAF4B75140
        public void InstallEvents(){} // RVA: 0x7FFAF2D8D310
        public void .ctor(){} // RVA: 0x7FFAF4B751D0
    }

    public class Utf8StringPointer
    {
        // ── Methods ──
        public void op_Implicit(){} // RVA: 0x7FFAF4B76C80
    }

    public class Utf8StringToNative
    {
        // ── Methods ──
        public void MarshalManagedToNative(){} // RVA: 0x7FFAF4B76A00
        public void MarshalNativeToManaged(){} // RVA: 0x7FFAF4B76B70
        public void CleanUpNativeData(){} // RVA: 0x7FFAF4B76BB0
        public void CleanUpManagedData(){} // RVA: 0x7FFAF4B76C00
        public void GetNativeDataSize(){} // RVA: 0x7FFAF320BB20
        public void GetInstance(){} // RVA: 0x7FFAF4B76C40
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class Utility
    {
        // ── Methods ──
        public void ToType(){} // RVA: 0x7FFAF4B76D20 | overloaded x2
        public void Swap(){} // RVA: 0x7FFAF4B76D90
        public void IpToInt32(){} // RVA: 0x7FFAF4B76DA0
        public void Int32ToIp(){} // RVA: 0x7FFAF4B76E40
        public void .cctor(){} // RVA: 0x7FFAF4B76EC0
    }

}