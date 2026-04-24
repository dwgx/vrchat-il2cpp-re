// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Steamworks
// Classes: 72
// Methods: 379

namespace ThirdParty.Other.Steamworks
{
    public class AppId : ValueType
    {
        // ── Original Methods ──
        public void ToString(){} // RVA: 0x7ffaaa5e80b0
        public void op_Implicit(){} // RVA: 0x7ffaaa5e80c0
    }

    public class ConnectionManager : Object
    {
        public object Connected; // 0x35F486D0
        public object userData; // 0x35F48890

        // ── Original Methods ──
        public void get_Interface(){} // RVA: 0x7ffaa894d380
        public void set_ConnectionInfo(){} // RVA: 0x7ffaaa5d7710
        public void OnConnectionChanged(){} // RVA: 0x7ffaaa5d77f0
        public void OnConnecting(){} // RVA: 0x7ffaaa5d7b30
        public void OnConnected(){} // RVA: 0x7ffaaa5d7c10
        public void OnDisconnected(){} // RVA: 0x7ffaaa5d7d00
    }

    public class Dispatch : Object
    {
        public object _clientPipe; // 0x30BD3080, was: <ClientPipe>k__BackingField
        public object actionsToCall; // 0x30BD3080
        public object Value; // 0x35EC9F50
        public object ClientPipe; // 0x17000002
        public object ServerPipe; // 0x17000003

        // ── Original Methods ──
        public void SteamAPI_ManualDispatch_Init(){} // RVA: 0x7ffaaa5ccd60
        public void SteamAPI_ManualDispatch_RunFrame(){} // RVA: 0x7ffaaa5ccdd0
        public void SteamAPI_ManualDispatch_GetNextCallback(){} // RVA: 0x7ffaaa5cce50
        public void SteamAPI_ManualDispatch_FreeLastCallback(){} // RVA: 0x7ffaaa5ccee0
        public void get_ClientPipe(){} // RVA: 0x7ffaaa5ccf60
        public void set_ClientPipe(){} // RVA: 0x7ffaaa5ccfc0
        public void get_ServerPipe(){} // RVA: 0x7ffaaa5cd020
        public void Init(){} // RVA: 0x7ffaaa5cd080
        public void Frame(){} // RVA: 0x7ffaaa5cd120
        public void ProcessCallback(){} // RVA: 0x7ffaaa5cd580
        public void CallbackToString(){} // RVA: 0x7ffaaa5cdb40
        public void ProcessResult(){} // RVA: 0x7ffaaa5ce310
        public void LoopClientAsync(){} // RVA: 0x7ffaaa5ce650
        public void Install(){} // RVA: 0x7ffaa8666620
        public void ShutdownClient(){} // RVA: 0x7ffaaa5ce7a0
        public void .cctor(){} // RVA: 0x7ffaaa5cf0d0
    }

    public class Helpers : Object
    {
        // ── Original Methods ──
        public void TakeMemory(){} // RVA: 0x7ffaaa5e8ad0
        public void TakeBuffer(){} // RVA: 0x7ffaaa5e8b20
        public void MemoryToString(){} // RVA: 0x7ffaaa5e8f00
        public void .cctor(){} // RVA: 0x7ffaaa5e8fd0
    }

    public class ICallbackData
    {
        // ── Original Methods ──
        public void get_CallbackType(){} // RVA: 0x7ffaa8649ca0
    }

    public class ISteamApps : SteamInterface
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaa5d4520
        public void SteamAPI_SteamApps_v008(){} // RVA: 0x7ffaaa5d4530
        public void _GetCurrentBetaName(){} // RVA: 0x7ffaaa5d45a0
        public void _GetLaunchQueryParam(){} // RVA: 0x7ffaaa5d4900
        public void _GetLaunchCommandLine(){} // RVA: 0x7ffaaa5d4a80
        // ── Binary Analysis Named ──
        public void GetUserInterfacePointer(){} // RVA: 0x7ffaaa5d4530
        public void GetCurrentBetaName(){} // RVA: 0x7ffaaa5d4640
        public void GetLaunchQueryParam(){} // RVA: 0x7ffaaa5d49c0
        public void GetLaunchCommandLine(){} // RVA: 0x7ffaaa5d4b20
    }

    public class ISteamFriends : SteamInterface
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaa5d4520
        public void SteamAPI_SteamFriends_v017(){} // RVA: 0x7ffaaa5d4dc0
        public void _GetPersonaName(){} // RVA: 0x7ffaaa5d4e30
        public void _GetFriendPersonaName(){} // RVA: 0x7ffaaa5d4f40
        public void _SetRichPresence(){} // RVA: 0x7ffaaa5d5070
        public void _ClearRichPresence(){} // RVA: 0x7ffaaa5d5230
        public void ClearRichPresence(){} // RVA: 0x7ffaaa5d52b0
        public void _GetClanChatMessage(){} // RVA: 0x7ffaaa5d5330
        public void _GetFriendMessage(){} // RVA: 0x7ffaaa5d5490
        // ── Binary Analysis Named ──
        public void GetUserInterfacePointer(){} // RVA: 0x7ffaaa5d4dc0
        public void GetPersonaName(){} // RVA: 0x7ffaaa5d4eb0
        public void GetFriendPersonaName(){} // RVA: 0x7ffaaa5d4fd0
        public void SetRichPresence(){} // RVA: 0x7ffaaa5d5150
        public void GetClanChatMessage(){} // RVA: 0x7ffaaa5d53e0
        public void GetFriendMessage(){} // RVA: 0x7ffaaa5d5540
    }

    public class ISteamInput : SteamInterface
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaa5d4520
        public void SteamAPI_SteamInput_v006(){} // RVA: 0x7ffaaa5d55f0
        // ── Binary Analysis Named ──
        public void GetUserInterfacePointer(){} // RVA: 0x7ffaaa5d55f0
    }

    public class ISteamInventory : SteamInterface
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaa5d4520
        public void SteamAPI_SteamInventory_v003(){} // RVA: 0x7ffaaa5d5660
        public void SteamAPI_SteamGameServerInventory_v003(){} // RVA: 0x7ffaaa5d56d0
        public void _GetResultItems(){} // RVA: 0x7ffaaa5d5740
        public void _GetResultItemProperty(){} // RVA: 0x7ffaaa5d58a0
        public void _DestroyResult(){} // RVA: 0x7ffaaa5d5c90
        public void DestroyResult(){} // RVA: 0x7ffaaa5d5d20
        public void _GetItemDefinitionIDs(){} // RVA: 0x7ffaaa5d5db0
        // ── Binary Analysis Named ──
        public void GetUserInterfacePointer(){} // RVA: 0x7ffaaa5d5660
        public void GetServerInterfacePointer(){} // RVA: 0x7ffaaa5d56d0
        public void GetResultItems(){} // RVA: 0x7ffaaa5d57f0
        public void GetResultItemProperty(){} // RVA: 0x7ffaaa5d5990
        public void GetItemDefinitionIDs(){} // RVA: 0x7ffaaa5d5e60
    }

    public class ISteamMatchmaking : SteamInterface
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaa5d4520
        public void SteamAPI_SteamMatchmaking_v009(){} // RVA: 0x7ffaaa5d5f10
        public void _GetLobbyChatEntry(){} // RVA: 0x7ffaaa5d5f80
        // ── Binary Analysis Named ──
        public void GetUserInterfacePointer(){} // RVA: 0x7ffaaa5d5f10
        public void GetLobbyChatEntry(){} // RVA: 0x7ffaaa5d6030
    }

    public class ISteamMatchmakingServers : SteamInterface
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaa5d4520
        public void SteamAPI_SteamMatchmakingServers_v002(){} // RVA: 0x7ffaaa5d60e0
        // ── Binary Analysis Named ──
        public void GetUserInterfacePointer(){} // RVA: 0x7ffaaa5d60e0
    }

    public class ISteamMusic : SteamInterface
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaa5d4520
        public void SteamAPI_SteamMusic_v001(){} // RVA: 0x7ffaaa5d6150
        // ── Binary Analysis Named ──
        public void GetUserInterfacePointer(){} // RVA: 0x7ffaaa5d6150
    }

    public class ISteamNetworking : SteamInterface
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaa5d4520
        public void SteamAPI_SteamNetworking_v006(){} // RVA: 0x7ffaaa5d61c0
        public void SteamAPI_SteamGameServerNetworking_v006(){} // RVA: 0x7ffaaa5d6230
        // ── Binary Analysis Named ──
        public void GetUserInterfacePointer(){} // RVA: 0x7ffaaa5d61c0
        public void GetServerInterfacePointer(){} // RVA: 0x7ffaaa5d6230
    }

    public class ISteamNetworkingSockets : SteamInterface
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaa5d4520
        public void SteamAPI_SteamNetworkingSockets_SteamAPI_v012(){} // RVA: 0x7ffaaa5d62a0
        public void SteamAPI_SteamGameServerNetworkingSockets_SteamAPI_v012(){} // RVA: 0x7ffaaa5d6310
        public void _AcceptConnection(){} // RVA: 0x7ffaaa5d6380
        public void AcceptConnection(){} // RVA: 0x7ffaaa5d6410
        public void _CloseConnection(){} // RVA: 0x7ffaaa5d64a0
        public void CloseConnection(){} // RVA: 0x7ffaaa5d6580
        public void _SetConnectionPollGroup(){} // RVA: 0x7ffaaa5d6660
        // ── Binary Analysis Named ──
        public void GetUserInterfacePointer(){} // RVA: 0x7ffaaa5d62a0
        public void GetServerInterfacePointer(){} // RVA: 0x7ffaaa5d6310
        public void SetConnectionPollGroup(){} // RVA: 0x7ffaaa5d6700
    }

    public class ISteamNetworkingUtils : SteamInterface
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaa5d4520
        public void SteamAPI_SteamNetworkingUtils_SteamAPI_v004(){} // RVA: 0x7ffaaa5d67a0
        public void _SteamNetworkingIdentity_ToString(){} // RVA: 0x7ffaaa5d6810
        public void SteamNetworkingIdentity_ToString(){} // RVA: 0x7ffaaa5d68c0
        // ── Binary Analysis Named ──
        public void GetGlobalInterfacePointer(){} // RVA: 0x7ffaaa5d67a0
    }

    public class ISteamParentalSettings : SteamInterface
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaa5d4520
        public void SteamAPI_SteamParentalSettings_v001(){} // RVA: 0x7ffaaa5d6b50
        // ── Binary Analysis Named ──
        public void GetUserInterfacePointer(){} // RVA: 0x7ffaaa5d6b50
    }

    public class ISteamParties : SteamInterface
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaa5d4520
        public void SteamAPI_SteamParties_v002(){} // RVA: 0x7ffaaa5d6bc0
        // ── Binary Analysis Named ──
        public void GetUserInterfacePointer(){} // RVA: 0x7ffaaa5d6bc0
    }

    public class ISteamRemotePlay : SteamInterface
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaa5d4520
        public void SteamAPI_SteamRemotePlay_v001(){} // RVA: 0x7ffaaa5d6c30
        // ── Binary Analysis Named ──
        public void GetUserInterfacePointer(){} // RVA: 0x7ffaaa5d6c30
    }

    public class ISteamRemoteStorage : SteamInterface
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaa5d4520
        public void SteamAPI_SteamRemoteStorage_v016(){} // RVA: 0x7ffaaa5d6ca0
        // ── Binary Analysis Named ──
        public void GetUserInterfacePointer(){} // RVA: 0x7ffaaa5d6ca0
    }

    public class ISteamScreenshots : SteamInterface
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaa5d4520
        public void SteamAPI_SteamScreenshots_v003(){} // RVA: 0x7ffaaa5d6d10
        // ── Binary Analysis Named ──
        public void GetUserInterfacePointer(){} // RVA: 0x7ffaaa5d6d10
    }

    public class ISteamUGC : SteamInterface
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaa5d4520
        public void SteamAPI_SteamUGC_v016(){} // RVA: 0x7ffaaa5d6d80
        public void SteamAPI_SteamGameServerUGC_v016(){} // RVA: 0x7ffaaa5d6df0
        // ── Binary Analysis Named ──
        public void GetUserInterfacePointer(){} // RVA: 0x7ffaaa5d6d80
        public void GetServerInterfacePointer(){} // RVA: 0x7ffaaa5d6df0
    }

    public class ISteamUser : SteamInterface
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaa5d4520
        public void SteamAPI_SteamUser_v021(){} // RVA: 0x7ffaaa5d6e60
        public void _GetSteamID(){} // RVA: 0x7ffaaa5d6ed0
        public void _GetVoiceOptimalSampleRate(){} // RVA: 0x7ffaaa5d6fd0
        public void _GetAuthSessionTicket(){} // RVA: 0x7ffaaa5d70d0
        public void _CancelAuthTicket(){} // RVA: 0x7ffaaa5d7230
        public void CancelAuthTicket(){} // RVA: 0x7ffaaa5d72c0
        // ── Binary Analysis Named ──
        public void GetUserInterfacePointer(){} // RVA: 0x7ffaaa5d6e60
        public void GetSteamID(){} // RVA: 0x7ffaaa5d6f50
        public void GetVoiceOptimalSampleRate(){} // RVA: 0x7ffaaa5d7050
        public void GetAuthSessionTicket(){} // RVA: 0x7ffaaa5d7180
    }

    public class ISteamUserStats : SteamInterface
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaa5d4520
        public void SteamAPI_SteamUserStats_v012(){} // RVA: 0x7ffaaa5d7350
        public void _RequestCurrentStats(){} // RVA: 0x7ffaaa5d73c0
        public void RequestCurrentStats(){} // RVA: 0x7ffaaa5d7440
        // ── Binary Analysis Named ──
        public void GetUserInterfacePointer(){} // RVA: 0x7ffaaa5d7350
    }

    public class ISteamUtils : SteamInterface
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaa5d4520
        public void SteamAPI_SteamUtils_v010(){} // RVA: 0x7ffaaa5d74c0
        public void SteamAPI_SteamGameServerUtils_v010(){} // RVA: 0x7ffaaa5d7530
        public void _IsSteamRunningOnSteamDeck(){} // RVA: 0x7ffaaa5d75a0
        public void IsSteamRunningOnSteamDeck(){} // RVA: 0x7ffaaa5d7620
        // ── Binary Analysis Named ──
        public void GetUserInterfacePointer(){} // RVA: 0x7ffaaa5d74c0
        public void GetServerInterfacePointer(){} // RVA: 0x7ffaaa5d7530
    }

    public class ISteamVideo : SteamInterface
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaa5d4520
        public void SteamAPI_SteamVideo_v002(){} // RVA: 0x7ffaaa5d76a0
        // ── Binary Analysis Named ──
        public void GetUserInterfacePointer(){} // RVA: 0x7ffaaa5d76a0
    }

    public class SocketManager : Object
    {
        public object Connected; // 0x35F48370

        // ── Original Methods ──
        public void get_Interface(){} // RVA: 0x7ffaa894d380
        public void OnConnectionChanged(){} // RVA: 0x7ffaaa5d7df0
        public void OnConnecting(){} // RVA: 0x7ffaaa5d81c0
        public void OnConnected(){} // RVA: 0x7ffaaa5d82e0
        public void OnDisconnected(){} // RVA: 0x7ffaaa5d84b0
    }

    public class SteamApps : SteamSharedClass`1
    {
        // ── Original Methods ──
        public void get_Internal(){} // RVA: 0x7ffaaa5d8600
        public void InitializeInterface(){} // RVA: 0x7ffaaa5d86a0
        public void add_OnNewLaunchParameters(){} // RVA: 0x7ffaaa5d8730
        public void remove_OnNewLaunchParameters(){} // RVA: 0x7ffaaa5d8840
        public void get_CurrentBetaName(){} // RVA: 0x7ffaaa5d8950
        public void get_CommandLine(){} // RVA: 0x7ffaaa5d8a60
        public void .ctor(){} // RVA: 0x7ffaaa5d8aa0
        // ── Binary Analysis Named ──
        public void GetLaunchParam(){} // RVA: 0x7ffaaa5d8990
    }

    public class SteamClass : Object
    {
        // ── Original Methods ──
        public void InitializeInterface(){} // RVA: 0x7ffaa86613a0
        public void DestroyInterface(){} // RVA: 0x7ffaa86613a0
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class SteamClient : Object
    {
        public object _appId; // 0x318A9EF0, was: <AppId>k__BackingField

        // ── Original Methods ──
        public void Init(){} // RVA: 0x7ffaaa5d8ad0
        public void AddInterface(){} // RVA: 0x7ffaa8660cf0
        public void ShutdownInterfaces(){} // RVA: 0x7ffaaa5d91c0
        public void get_IsValid(){} // RVA: 0x7ffaaa5d93b0
        public void Shutdown(){} // RVA: 0x7ffaaa5d9410
        public void Cleanup(){} // RVA: 0x7ffaaa5d9520
        public void get_SteamId(){} // RVA: 0x7ffaaa5d95b0
        public void get_Name(){} // RVA: 0x7ffaaa5d9680
        public void set_AppId(){} // RVA: 0x7ffaaa5d9720
        public void RestartAppIfNecessary(){} // RVA: 0x7ffaaa5cf9f0
        public void .cctor(){} // RVA: 0x7ffaaa5d9780
    }

    public class SteamClientClass`1 : SteamClass
    {
        // ── Original Methods ──
        public void InitializeInterface(){} // RVA: 0x7ffaa86613a0
        public void DestroyInterface(){} // RVA: 0x7ffaa86613a0
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        // ── Binary Analysis Named ──
        public void SetInterface(){} // RVA: 0x7ffaa86618c0
    }

    public class SteamClientClass`1 : SteamClass
    {
        // ── Original Methods ──
        public void InitializeInterface(){} // RVA: 0x7ffaa8932310
        public void DestroyInterface(){} // RVA: 0x7ffaac3b2010
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void SetInterface(){} // RVA: 0x7ffaac3b1f20
    }

    public class SteamClientClass`1 : SteamClass
    {
        // ── Original Methods ──
        public void InitializeInterface(){} // RVA: 0x7ffaa8932310
        public void DestroyInterface(){} // RVA: 0x7ffaac3b2010
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void SetInterface(){} // RVA: 0x7ffaac3b1f20
    }

    public class SteamClientClass`1 : SteamClass
    {
        // ── Original Methods ──
        public void InitializeInterface(){} // RVA: 0x7ffaa8932310
        public void DestroyInterface(){} // RVA: 0x7ffaac3b2010
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void SetInterface(){} // RVA: 0x7ffaac3b1f20
    }

    public class SteamClientClass`1 : SteamClass
    {
        // ── Original Methods ──
        public void InitializeInterface(){} // RVA: 0x7ffaa8932310
        public void DestroyInterface(){} // RVA: 0x7ffaac3b2010
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void SetInterface(){} // RVA: 0x7ffaac3b1f20
    }

    public class SteamClientClass`1 : SteamClass
    {
        // ── Original Methods ──
        public void InitializeInterface(){} // RVA: 0x7ffaa8932310
        public void DestroyInterface(){} // RVA: 0x7ffaac3b2010
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void SetInterface(){} // RVA: 0x7ffaac3b1f20
    }

    public class SteamClientClass`1 : SteamClass
    {
        // ── Original Methods ──
        public void InitializeInterface(){} // RVA: 0x7ffaa8932310
        public void DestroyInterface(){} // RVA: 0x7ffaac3b2010
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void SetInterface(){} // RVA: 0x7ffaac3b1f20
    }

    public class SteamClientClass`1 : SteamClass
    {
        // ── Original Methods ──
        public void InitializeInterface(){} // RVA: 0x7ffaa8932310
        public void DestroyInterface(){} // RVA: 0x7ffaac3b2010
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void SetInterface(){} // RVA: 0x7ffaac3b1f20
    }

    public class SteamClientClass`1 : SteamClass
    {
        // ── Original Methods ──
        public void InitializeInterface(){} // RVA: 0x7ffaa8932310
        public void DestroyInterface(){} // RVA: 0x7ffaac3b2010
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void SetInterface(){} // RVA: 0x7ffaac3b1f20
    }

    public class SteamClientClass`1 : SteamClass
    {
        // ── Original Methods ──
        public void InitializeInterface(){} // RVA: 0x7ffaa8932310
        public void DestroyInterface(){} // RVA: 0x7ffaac3b2010
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void SetInterface(){} // RVA: 0x7ffaac3b1f20
    }

    public class SteamClientClass`1 : SteamClass
    {
        // ── Original Methods ──
        public void InitializeInterface(){} // RVA: 0x7ffaa8932310
        public void DestroyInterface(){} // RVA: 0x7ffaac3b2010
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void SetInterface(){} // RVA: 0x7ffaac3b1f20
    }

    public class SteamClientClass`1 : SteamClass
    {
        // ── Original Methods ──
        public void InitializeInterface(){} // RVA: 0x7ffaa8932310
        public void DestroyInterface(){} // RVA: 0x7ffaac3b2010
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void SetInterface(){} // RVA: 0x7ffaac3b1f20
    }

    public class SteamClientClass`1 : SteamClass
    {
        // ── Original Methods ──
        public void InitializeInterface(){} // RVA: 0x7ffaa8932310
        public void DestroyInterface(){} // RVA: 0x7ffaac3b2010
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void SetInterface(){} // RVA: 0x7ffaac3b1f20
    }

    public class SteamFriends : SteamClientClass`1
    {
        public object OnClanChatMessage; // 0x35ECB1B0
        public object OnGameOverlayActivated; // 0x35ECB1B0
        public object OnFriendRichPresenceUpdate; // 0x35ECB1B0

        // ── Original Methods ──
        public void get_Internal(){} // RVA: 0x7ffaaa5d9860
        public void InitializeInterface(){} // RVA: 0x7ffaaa5d9900
        public void InstallEvents(){} // RVA: 0x7ffaaa5d9a40
        public void OnFriendChatMessage(){} // RVA: 0x7ffaaa5daad0
        public void OnGameConnectedClanChatMessage(){} // RVA: 0x7ffaaa5dae50
        public void ClearRichPresence(){} // RVA: 0x7ffaaa5db390
        public void .ctor(){} // RVA: 0x7ffaaa5db480
        // ── Binary Analysis Named ──
        public void SetRichPresence(){} // RVA: 0x7ffaaa5db200
    }

    public class SteamInput : SteamClientClass`1
    {
        public object AnalogHandles; // 0x35F20800

        // ── Original Methods ──
        public void InitializeInterface(){} // RVA: 0x7ffaaa5db8d0
        public void .ctor(){} // RVA: 0x7ffaaa5db960
        public void .cctor(){} // RVA: 0x7ffaaa5db990
    }

    public class SteamInterface : Object
    {
        public object SelfServer; // 0x35ECB000

        // ── Original Methods ──
        public void set_IsServer(){} // RVA: 0x7ffaa8958460
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetUserInterfacePointer(){} // RVA: 0x7ffaa8f22da0
        public void GetServerInterfacePointer(){} // RVA: 0x7ffaa8f22da0
        public void GetGlobalInterfacePointer(){} // RVA: 0x7ffaa8f22da0
        public void SetupInterface(){} // RVA: 0x7ffaaa5e9820
    }

    public class SteamInventory : SteamSharedClass`1
    {
        public object _items; // 0x35F211E0, was: <Items>k__BackingField

        // ── Original Methods ──
        public void get_Internal(){} // RVA: 0x7ffaaa5dbdd0
        public void InitializeInterface(){} // RVA: 0x7ffaaa5dbe70
        public void InstallEvents(){} // RVA: 0x7ffaaa5dbf00
        public void InventoryUpdated(){} // RVA: 0x7ffaaa5dc350
        public void LoadDefinitions(){} // RVA: 0x7ffaaa5dc460
        public void set_Items(){} // RVA: 0x7ffaaa5dc700
        public void get_Definitions(){} // RVA: 0x7ffaaa5dc7a0
        public void set_Definitions(){} // RVA: 0x7ffaaa5dc7e0
        public void .ctor(){} // RVA: 0x7ffaaa5dcb80
        // ── Binary Analysis Named ──
        public void GetDefinitions(){} // RVA: 0x7ffaaa5dc880
    }

    public class SteamMatchmaking : SteamClientClass`1
    {
        public object OnLobbyCreated; // 0x35F219E0
        public object OnLobbyMemberDataChanged; // 0x35F219E0
        public object OnLobbyMemberDisconnected; // 0x35F219E0
        public object OnChatMessage; // 0x35F219E0
        public object get_Internal; // 0xB4176130

        // ── Original Methods ──
        public void get_Internal(){} // RVA: 0x7ffaaa5dcdb0
        public void InitializeInterface(){} // RVA: 0x7ffaaa5dce50
        public void InstallEvents(){} // RVA: 0x7ffaaa5dcee0
        public void OnLobbyChatMessageRecievedAPI(){} // RVA: 0x7ffaaa5ddc50
        public void .ctor(){} // RVA: 0x7ffaaa5de010
    }

    public class SteamMatchmakingServers : SteamClientClass`1
    {
        // ── Original Methods ──
        public void InitializeInterface(){} // RVA: 0x7ffaaa5de4b0
        public void .ctor(){} // RVA: 0x7ffaaa5de540
    }

    public class SteamMusic : SteamClientClass`1
    {
        // ── Original Methods ──
        public void InitializeInterface(){} // RVA: 0x7ffaaa5de570
        public void InstallEvents(){} // RVA: 0x7ffaaa5de600
        public void .ctor(){} // RVA: 0x7ffaaa5dea70
    }

    public class SteamNetworking : SteamSharedClass`1
    {
        // ── Original Methods ──
        public void InitializeInterface(){} // RVA: 0x7ffaaa5dec00
        public void InstallEvents(){} // RVA: 0x7ffaaa5dec90
        public void .ctor(){} // RVA: 0x7ffaaa5df0e0
    }

    public class SteamNetworkingSockets : SteamSharedClass`1
    {
        public object OnConnectionStatusChanged; // 0x35F481C0
        public object ବf; // 0x35F481C0

        // ── Original Methods ──
        public void get_Internal(){} // RVA: 0x7ffaaa5df280
        public void InitializeInterface(){} // RVA: 0x7ffaaa5df320
        public void InstallEvents(){} // RVA: 0x7ffaaa5df5b0
        public void ConnectionStatusChanged(){} // RVA: 0x7ffaaa5df840
        public void FakeIPResult(){} // RVA: 0x7ffaaa5e00c0
        public void .ctor(){} // RVA: 0x7ffaaa5e0240
        public void .cctor(){} // RVA: 0x7ffaaa5e0270
        // ── Binary Analysis Named ──
        public void GetSocketManager(){} // RVA: 0x7ffaaa5df3b0
        public void GetConnectionManager(){} // RVA: 0x7ffaaa5df4d0
    }

    public class SteamNetworkingUtils : SteamSharedClass`1
    {
        public object debugMessages; // 0x35F49D70

        // ── Original Methods ──
        public void get_Internal(){} // RVA: 0x7ffaaa5e0410
        public void InitializeInterface(){} // RVA: 0x7ffaaa5e04b0
        public void InstallCallbacks(){} // RVA: 0x7ffaaa5e0570
        public void set_Status(){} // RVA: 0x7ffaaa5e07c0
        public void OutputDebugMessages(){} // RVA: 0x7ffaaa5e0820
        public void .ctor(){} // RVA: 0x7ffaaa5e0a50
        public void .cctor(){} // RVA: 0x7ffaaa5e0a80
    }

    public class SteamParental : SteamSharedClass`1
    {
        // ── Original Methods ──
        public void InitializeInterface(){} // RVA: 0x7ffaaa5e0e40
        public void InstallEvents(){} // RVA: 0x7ffaaa5e0ed0
        public void .ctor(){} // RVA: 0x7ffaaa5e1120
    }

    public class SteamParties : SteamClientClass`1
    {
        // ── Original Methods ──
        public void InitializeInterface(){} // RVA: 0x7ffaaa5e1250
        public void InstallEvents(){} // RVA: 0x7ffaaa5e12e0
        public void .ctor(){} // RVA: 0x7ffaaa5e1730
    }

    public class SteamRemotePlay : SteamClientClass`1
    {
        // ── Original Methods ──
        public void InitializeInterface(){} // RVA: 0x7ffaaa5e18c0
        public void InstallEvents(){} // RVA: 0x7ffaaa5e1950
        public void .ctor(){} // RVA: 0x7ffaaa5e1da0
    }

    public class SteamRemoteStorage : SteamClientClass`1
    {
        // ── Original Methods ──
        public void InitializeInterface(){} // RVA: 0x7ffaaa5e1f30
        public void .ctor(){} // RVA: 0x7ffaaa5e1fc0
    }

    public class SteamScreenshots : SteamClientClass`1
    {
        public object OnScreenshotFailed; // 0x35F4BC90

        // ── Original Methods ──
        public void InitializeInterface(){} // RVA: 0x7ffaaa5e1ff0
        public void InstallEvents(){} // RVA: 0x7ffaaa5e2080
        public void .ctor(){} // RVA: 0x7ffaaa5e24f0
    }

    public class SteamSharedClass`1 : SteamClass
    {
        public object InterfaceClient; // 0x35EFA1B0

        // ── Original Methods ──
        public void get_Interface(){} // RVA: 0x7ffaa8648dd0
        public void InitializeInterface(){} // RVA: 0x7ffaa86613a0
        public void DestroyInterface(){} // RVA: 0x7ffaa86613a0
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        // ── Binary Analysis Named ──
        public void SetInterface(){} // RVA: 0x7ffaa86618c0
    }

    public class SteamSharedClass`1 : SteamClass
    {
        public object OnNewLaunchParameters; // 0x35ECACA0

        // ── Original Methods ──
        public void get_Interface(){} // RVA: 0x7ffaac3b20c0
        public void InitializeInterface(){} // RVA: 0x7ffaa8932310
        public void DestroyInterface(){} // RVA: 0x7ffaac3b22d0
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void SetInterface(){} // RVA: 0x7ffaac3b2150
    }

    public class SteamSharedClass`1 : SteamClass
    {
        public object OnInventoryUpdated; // 0x35F211E0

        // ── Original Methods ──
        public void get_Interface(){} // RVA: 0x7ffaac3b20c0
        public void InitializeInterface(){} // RVA: 0x7ffaa8932310
        public void DestroyInterface(){} // RVA: 0x7ffaac3b22d0
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void SetInterface(){} // RVA: 0x7ffaac3b2150
    }

    public class SteamSharedClass`1 : SteamClass
    {
        public object OnP2PSessionRequest; // 0x35F23810

        // ── Original Methods ──
        public void get_Interface(){} // RVA: 0x7ffaac3b20c0
        public void InitializeInterface(){} // RVA: 0x7ffaa8932310
        public void DestroyInterface(){} // RVA: 0x7ffaac3b22d0
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void SetInterface(){} // RVA: 0x7ffaac3b2150
    }

    public class SteamSharedClass`1 : SteamClass
    {
        public object SocketInterfaces; // 0x35F481C0

        // ── Original Methods ──
        public void get_Interface(){} // RVA: 0x7ffaac3b20c0
        public void InitializeInterface(){} // RVA: 0x7ffaa8932310
        public void DestroyInterface(){} // RVA: 0x7ffaac3b22d0
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void SetInterface(){} // RVA: 0x7ffaac3b2150
    }

    public class SteamSharedClass`1 : SteamClass
    {
        public object OnDebugOutput; // 0x35F49D70

        // ── Original Methods ──
        public void get_Interface(){} // RVA: 0x7ffaac3b20c0
        public void InitializeInterface(){} // RVA: 0x7ffaa8932310
        public void DestroyInterface(){} // RVA: 0x7ffaac3b22d0
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void SetInterface(){} // RVA: 0x7ffaac3b2150
    }

    public class SteamSharedClass`1 : SteamClass
    {
        public object OnSettingsChanged; // 0x35F4AAC0

        // ── Original Methods ──
        public void get_Interface(){} // RVA: 0x7ffaac3b20c0
        public void InitializeInterface(){} // RVA: 0x7ffaa8932310
        public void DestroyInterface(){} // RVA: 0x7ffaac3b22d0
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void SetInterface(){} // RVA: 0x7ffaac3b2150
    }

    public class SteamSharedClass`1 : SteamClass
    {
        public object OnDownloadItemResult; // 0x35F60500

        // ── Original Methods ──
        public void get_Interface(){} // RVA: 0x7ffaac3b20c0
        public void InitializeInterface(){} // RVA: 0x7ffaa8932310
        public void DestroyInterface(){} // RVA: 0x7ffaac3b22d0
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void SetInterface(){} // RVA: 0x7ffaac3b2150
    }

    public class SteamSharedClass`1 : SteamClass
    {
        public object OnIpCountryChanged; // 0x35F63C80

        // ── Original Methods ──
        public void get_Interface(){} // RVA: 0x7ffaac3b20c0
        public void InitializeInterface(){} // RVA: 0x7ffaa8932310
        public void DestroyInterface(){} // RVA: 0x7ffaac3b22d0
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void SetInterface(){} // RVA: 0x7ffaac3b2150
    }

    public class SteamUGC : SteamSharedClass`1
    {
        public object OnItemUnsubscribed; // 0x35F60500

        // ── Original Methods ──
        public void InitializeInterface(){} // RVA: 0x7ffaaa5e26a0
        public void InstallEvents(){} // RVA: 0x7ffaaa5e2730
        public void .ctor(){} // RVA: 0x7ffaaa5e2f80
    }

    public class SteamUser : SteamClientClass`1
    {
        public object OnSteamServerConnectFailure; // 0x35F611C0
        public object OnLicensesUpdated; // 0x35F611C0
        public object OnMicroTxnAuthorizationResponse; // 0x35F611C0
        public object readBuffer; // 0x35F611C0
        public object h	00; // 0x35F68450

        // ── Original Methods ──
        public void get_Internal(){} // RVA: 0x7ffaaa5e3210
        public void InitializeInterface(){} // RVA: 0x7ffaaa5e32b0
        public void InstallEvents(){} // RVA: 0x7ffaaa5e3620
        public void add_OnMicroTxnAuthorizationResponse(){} // RVA: 0x7ffaaa5e4a60
        public void remove_OnMicroTxnAuthorizationResponse(){} // RVA: 0x7ffaaa5e4bc0
        public void get_SampleRate(){} // RVA: 0x7ffaaa5e4d20
        public void set_SampleRate(){} // RVA: 0x7ffaaa5e4d80
        public void get_OptimalSampleRate(){} // RVA: 0x7ffaaa5e4ef0
        public void .ctor(){} // RVA: 0x7ffaaa5e5310
        public void .cctor(){} // RVA: 0x7ffaaa5e5340
        // ── Binary Analysis Named ──
        public void GetAuthSessionTicket(){} // RVA: 0x7ffaaa5e4fc0
    }

    public class SteamUserStats : SteamClientClass`1
    {
        public object OnUserStatsReceived; // 0x35F62E50
        public object OnUserStatsUnloaded; // 0x35F62E50

        // ── Original Methods ──
        public void get_Internal(){} // RVA: 0x7ffaaa5e59e0
        public void InitializeInterface(){} // RVA: 0x7ffaaa5e5a80
        public void set_StatsRecieved(){} // RVA: 0x7ffaaa5e5c10
        public void InstallEvents(){} // RVA: 0x7ffaaa5e5c50
        public void RequestCurrentStats(){} // RVA: 0x7ffaaa5e66a0
        public void .ctor(){} // RVA: 0x7ffaaa5e67c0
    }

    public class SteamUtils : SteamSharedClass`1
    {
        public object OnSteamShutdown; // 0x35F63C80
        public object overlayNotificationPosition; // 0x35F63C80

        // ── Original Methods ──
        public void get_Internal(){} // RVA: 0x7ffaaa5e6bf0
        public void InitializeInterface(){} // RVA: 0x7ffaaa5e6c90
        public void InstallEvents(){} // RVA: 0x7ffaaa5e6d50
        public void SteamClosed(){} // RVA: 0x7ffaaa5e77a0
        public void add_OnAppResumingFromSuspend(){} // RVA: 0x7ffaaa5e7840
        public void remove_OnAppResumingFromSuspend(){} // RVA: 0x7ffaaa5e7990
        public void get_IsRunningOnSteamDeck(){} // RVA: 0x7ffaaa5e7ae0
        public void .ctor(){} // RVA: 0x7ffaaa5e7c30
        public void .cctor(){} // RVA: 0x7ffaaa5e7c60
    }

    public class SteamVideo : SteamClientClass`1
    {
        // ── Original Methods ──
        public void InitializeInterface(){} // RVA: 0x7ffaaa5e7ff0
        public void InstallEvents(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaaa5e8080
    }

    public class Utility : Object
    {
        public object h	00; // 0x8514CC68

        // ── Original Methods ──
        public void ToType(){} // RVA: 0x7ffaaa5e9bd0
        public void ToType(){} // RVA: 0x7ffaaa5e9bd0
        public void Swap(){} // RVA: 0x7ffaaa5e9c40
        public void IpToInt32(){} // RVA: 0x7ffaaa5e9c50
        public void Int32ToIp(){} // RVA: 0x7ffaaa5e9cf0
        public void .cctor(){} // RVA: 0x7ffaaa5e9d70
    }

}