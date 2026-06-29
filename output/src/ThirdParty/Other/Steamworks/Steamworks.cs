// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Steamworks
// Classes: 86
// Methods: 432

namespace ThirdParty.Other.Steamworks
{
    public class AppId : ValueType
    {
        // ── Methods ──
        public void ToString(){} // RVA: 0x145060
        public void op_Implicit(){} // RVA: 0x294E720
    }

    public class AuthTicket : Object
    {
        // ── Methods ──
        public void Cancel(){} // RVA: 0x2933EA0
        public void Dispose(){} // RVA: 0x2933FE0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class CallbackTypeFactory : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x2936D90
    }

    public class ConnectionManager : Object
    {
        // ── Methods ──
        public void get_Interface(){} // RVA: 0xB5DBF0
        public void set_ConnectionInfo(){} // RVA: 0x293E830
        public void OnConnectionChanged(){} // RVA: 0x293E910
        public void OnConnecting(){} // RVA: 0x293EC50
        public void OnConnected(){} // RVA: 0x293ED30
        public void OnDisconnected(){} // RVA: 0x293EE20
    }

    public class Dispatch : Object
    {
        // ── Methods ──
        public void SteamAPI_ManualDispatch_Init(){} // RVA: 0x2933FF0
        public void SteamAPI_ManualDispatch_RunFrame(){} // RVA: 0x2934060
        public void SteamAPI_ManualDispatch_GetNextCallback(){} // RVA: 0x29340E0
        public void SteamAPI_ManualDispatch_FreeLastCallback(){} // RVA: 0x2934170
        public void get_ClientPipe(){} // RVA: 0x29341F0
        public void set_ClientPipe(){} // RVA: 0x2934250
        public void get_ServerPipe(){} // RVA: 0x29342B0
        public void Init(){} // RVA: 0x2934310
        public void Frame(){} // RVA: 0x29343B0
        public void ProcessCallback(){} // RVA: 0x2934820
        public void CallbackToString(){} // RVA: 0x2934E00
        public void ProcessResult(){} // RVA: 0x29355F0
        public void LoopClientAsync(){} // RVA: 0x2935950
        public void Install(){} // RVA: 0x306BDF0
        public void ShutdownClient(){} // RVA: 0x2935AB0
        public void .cctor(){} // RVA: 0x29363F0
    }

    public class Friend : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x93050
        public void ToString(){} // RVA: 0x145070
        public void get_Name(){} // RVA: 0x145100
    }

    public class Helpers : Object
    {
        // ── Methods ──
        public void TakeMemory(){} // RVA: 0x294F120
        public void TakeBuffer(){} // RVA: 0x294F170
        public void MemoryToString(){} // RVA: 0x294F500
        public void .cctor(){} // RVA: 0x294F5B0
    }

    public class ICallbackData
    {
        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x87C130
    }

    public class IConnectionManager
    {
        // ── Methods ──
        public void OnConnecting(){} // RVA: 0x894320
        public void OnConnected(){} // RVA: 0x894320
        public void OnDisconnected(){} // RVA: 0x894320
    }

    public class ISocketManager
    {
        // ── Methods ──
        public void OnConnecting(){} // RVA: 0x895750
        public void OnConnected(){} // RVA: 0x895750
        public void OnDisconnected(){} // RVA: 0x895750
    }

    public class ISteamApps : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x293B600
        public void SteamAPI_SteamApps_v008(){} // RVA: 0x293B610
        public void GetUserInterfacePointer(){} // RVA: 0x293B610
        public void _GetCurrentBetaName(){} // RVA: 0x293B680
        public void GetCurrentBetaName(){} // RVA: 0x293B720
        public void _GetLaunchQueryParam(){} // RVA: 0x293B9E0
        public void GetLaunchQueryParam(){} // RVA: 0x293BAA0
        public void _GetLaunchCommandLine(){} // RVA: 0x293BB60
        public void GetLaunchCommandLine(){} // RVA: 0x293BC00
    }

    public class ISteamFriends : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x293B600
        public void SteamAPI_SteamFriends_v017(){} // RVA: 0x293BEB0
        public void GetUserInterfacePointer(){} // RVA: 0x293BEB0
        public void _GetPersonaName(){} // RVA: 0x293BF20
        public void GetPersonaName(){} // RVA: 0x293BFA0
        public void _GetFriendPersonaName(){} // RVA: 0x293C030
        public void GetFriendPersonaName(){} // RVA: 0x293C0C0
        public void _SetRichPresence(){} // RVA: 0x293C160
        public void SetRichPresence(){} // RVA: 0x293C240
        public void _ClearRichPresence(){} // RVA: 0x293C320
        public void ClearRichPresence(){} // RVA: 0x293C3A0
        public void _GetClanChatMessage(){} // RVA: 0x293C420
        public void GetClanChatMessage(){} // RVA: 0x293C4D0
        public void _GetFriendMessage(){} // RVA: 0x293C580
        public void GetFriendMessage(){} // RVA: 0x293C630
    }

    public class ISteamInput : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x293B600
        public void SteamAPI_SteamInput_v006(){} // RVA: 0x293C6E0
        public void GetUserInterfacePointer(){} // RVA: 0x293C6E0
    }

    public class ISteamInventory : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x293B600
        public void SteamAPI_SteamInventory_v003(){} // RVA: 0x293C750
        public void GetUserInterfacePointer(){} // RVA: 0x293C750
        public void SteamAPI_SteamGameServerInventory_v003(){} // RVA: 0x293C7C0
        public void GetServerInterfacePointer(){} // RVA: 0x293C7C0
        public void _GetResultItems(){} // RVA: 0x293C830
        public void GetResultItems(){} // RVA: 0x293C8E0
        public void _GetResultItemProperty(){} // RVA: 0x293C990
        public void GetResultItemProperty(){} // RVA: 0x293CA80
        public void _DestroyResult(){} // RVA: 0x293CD90
        public void DestroyResult(){} // RVA: 0x293CE20
        public void _GetItemDefinitionIDs(){} // RVA: 0x293CEB0
        public void GetItemDefinitionIDs(){} // RVA: 0x293CF60
    }

    public class ISteamMatchmaking : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x293B600
        public void SteamAPI_SteamMatchmaking_v009(){} // RVA: 0x293D010
        public void GetUserInterfacePointer(){} // RVA: 0x293D010
        public void _GetLobbyChatEntry(){} // RVA: 0x293D080
        public void GetLobbyChatEntry(){} // RVA: 0x293D130
    }

    public class ISteamMatchmakingServers : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x293B600
        public void SteamAPI_SteamMatchmakingServers_v002(){} // RVA: 0x293D1E0
        public void GetUserInterfacePointer(){} // RVA: 0x293D1E0
    }

    public class ISteamMusic : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x293B600
        public void SteamAPI_SteamMusic_v001(){} // RVA: 0x293D250
        public void GetUserInterfacePointer(){} // RVA: 0x293D250
    }

    public class ISteamNetworking : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x293B600
        public void SteamAPI_SteamNetworking_v006(){} // RVA: 0x293D2C0
        public void GetUserInterfacePointer(){} // RVA: 0x293D2C0
        public void SteamAPI_SteamGameServerNetworking_v006(){} // RVA: 0x293D330
        public void GetServerInterfacePointer(){} // RVA: 0x293D330
    }

    public class ISteamNetworkingSockets : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x293B600
        public void SteamAPI_SteamNetworkingSockets_SteamAPI_v012(){} // RVA: 0x293D3A0
        public void GetUserInterfacePointer(){} // RVA: 0x293D3A0
        public void SteamAPI_SteamGameServerNetworkingSockets_SteamAPI_v012(){} // RVA: 0x293D410
        public void GetServerInterfacePointer(){} // RVA: 0x293D410
        public void _AcceptConnection(){} // RVA: 0x293D480
        public void AcceptConnection(){} // RVA: 0x293D510
        public void _CloseConnection(){} // RVA: 0x293D5A0
        public void CloseConnection(){} // RVA: 0x293D680
        public void _SetConnectionPollGroup(){} // RVA: 0x293D760
        public void SetConnectionPollGroup(){} // RVA: 0x293D800
    }

    public class ISteamNetworkingUtils : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x293B600
        public void SteamAPI_SteamNetworkingUtils_SteamAPI_v004(){} // RVA: 0x293D8A0
        public void GetGlobalInterfacePointer(){} // RVA: 0x293D8A0
        public void _SteamNetworkingIdentity_ToString(){} // RVA: 0x293D910
        public void SteamNetworkingIdentity_ToString(){} // RVA: 0x293D9C0
    }

    public class ISteamParentalSettings : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x293B600
        public void SteamAPI_SteamParentalSettings_v001(){} // RVA: 0x293DC70
        public void GetUserInterfacePointer(){} // RVA: 0x293DC70
    }

    public class ISteamParties : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x293B600
        public void SteamAPI_SteamParties_v002(){} // RVA: 0x293DCE0
        public void GetUserInterfacePointer(){} // RVA: 0x293DCE0
    }

    public class ISteamRemotePlay : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x293B600
        public void SteamAPI_SteamRemotePlay_v001(){} // RVA: 0x293DD50
        public void GetUserInterfacePointer(){} // RVA: 0x293DD50
    }

    public class ISteamRemoteStorage : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x293B600
        public void SteamAPI_SteamRemoteStorage_v016(){} // RVA: 0x293DDC0
        public void GetUserInterfacePointer(){} // RVA: 0x293DDC0
    }

    public class ISteamScreenshots : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x293B600
        public void SteamAPI_SteamScreenshots_v003(){} // RVA: 0x293DE30
        public void GetUserInterfacePointer(){} // RVA: 0x293DE30
    }

    public class ISteamUGC : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x293B600
        public void SteamAPI_SteamUGC_v016(){} // RVA: 0x293DEA0
        public void GetUserInterfacePointer(){} // RVA: 0x293DEA0
        public void SteamAPI_SteamGameServerUGC_v016(){} // RVA: 0x293DF10
        public void GetServerInterfacePointer(){} // RVA: 0x293DF10
    }

    public class ISteamUser : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x293B600
        public void SteamAPI_SteamUser_v021(){} // RVA: 0x293DF80
        public void GetUserInterfacePointer(){} // RVA: 0x293DF80
        public void _GetSteamID(){} // RVA: 0x293DFF0
        public void GetSteamID(){} // RVA: 0x293E070
        public void _GetVoiceOptimalSampleRate(){} // RVA: 0x293E0F0
        public void GetVoiceOptimalSampleRate(){} // RVA: 0x293E170
        public void _GetAuthSessionTicket(){} // RVA: 0x293E1F0
        public void GetAuthSessionTicket(){} // RVA: 0x293E2A0
        public void _CancelAuthTicket(){} // RVA: 0x293E350
        public void CancelAuthTicket(){} // RVA: 0x293E3E0
    }

    public class ISteamUserStats : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x293B600
        public void SteamAPI_SteamUserStats_v012(){} // RVA: 0x293E470
        public void GetUserInterfacePointer(){} // RVA: 0x293E470
        public void _RequestCurrentStats(){} // RVA: 0x293E4E0
        public void RequestCurrentStats(){} // RVA: 0x293E560
    }

    public class ISteamUtils : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x293B600
        public void SteamAPI_SteamUtils_v010(){} // RVA: 0x293E5E0
        public void GetUserInterfacePointer(){} // RVA: 0x293E5E0
        public void SteamAPI_SteamGameServerUtils_v010(){} // RVA: 0x293E650
        public void GetServerInterfacePointer(){} // RVA: 0x293E650
        public void _IsSteamRunningOnSteamDeck(){} // RVA: 0x293E6C0
        public void IsSteamRunningOnSteamDeck(){} // RVA: 0x293E740
    }

    public class ISteamVideo : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x293B600
        public void SteamAPI_SteamVideo_v002(){} // RVA: 0x293E7C0
        public void GetUserInterfacePointer(){} // RVA: 0x293E7C0
    }

    public class InventoryDef : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB460A0
        public void get_Id(){} // RVA: 0xB8F8F0
        public void op_Equality(){} // RVA: 0x294E870
        public void Equals(){} // RVA: 0x294E930
        public void GetHashCode(){} // RVA: 0xB8F8F0
    }

    public class InventoryItem : ValueType
    {
        // ── Methods ──
        public void From(){} // RVA: 0x294E980
        public void GetProperties(){} // RVA: 0x294E9B0
        public void Equals(){} // RVA: 0x145260
        public void GetHashCode(){} // RVA: 0x145250
    }

    public class InventoryResult : ValueType
    {
        // ── Methods ──
        public void set_Expired(){} // RVA: 0x54160
        public void .ctor(){} // RVA: 0x295B0
        public void get_ItemCount(){} // RVA: 0x145280
        public void GetItems(){} // RVA: 0x145290
        public void Dispose(){} // RVA: 0x1452A0
    }

    public class PreserveAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SocketManager : Object
    {
        // ── Methods ──
        public void get_Interface(){} // RVA: 0xB5DBF0
        public void OnConnectionChanged(){} // RVA: 0x293EF10
        public void OnConnecting(){} // RVA: 0x293F2E0
        public void OnConnected(){} // RVA: 0x293F400
        public void OnDisconnected(){} // RVA: 0x293F5D0
    }

    public class SteamAPI : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x2936BC0
        public void Shutdown(){} // RVA: 0x2936C30
        public void GetHSteamPipe(){} // RVA: 0x2936CA0
        public void RestartAppIfNecessary(){} // RVA: 0x2936D10
    }

    public class SteamApps : SteamSharedClass`1
    {
        // ── Methods ──
        public void get_Internal(){} // RVA: 0x293F720
        public void InitializeInterface(){} // RVA: 0x293F7B0
        public void get_CurrentBetaName(){} // RVA: 0x293F840
        public void GetLaunchParam(){} // RVA: 0xDC9580
        public void get_CommandLine(){} // RVA: 0xDC9180
        public void .ctor(){} // RVA: 0x293F880
    }

    public class SteamClass : Object
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x894750
        public void DestroyInterface(){} // RVA: 0x894750
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SteamClass[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class SteamClient : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x293F8B0
        public void AddInterface(){} // RVA: 0x29C72D0
        public void ShutdownInterfaces(){} // RVA: 0x293FFB0
        public void get_IsValid(){} // RVA: 0x29401B0
        public void Shutdown(){} // RVA: 0x2940210
        public void Cleanup(){} // RVA: 0x2940320
        public void get_SteamId(){} // RVA: 0x29403B0
        public void get_Name(){} // RVA: 0x2940480
        public void get_AppId(){} // RVA: 0x2940520
        public void set_AppId(){} // RVA: 0x2940580
        public void RestartAppIfNecessary(){} // RVA: 0x2936D10
        public void .cctor(){} // RVA: 0x29405E0
    }

    public class SteamClientClass`1 : SteamClass
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x894750
        public void SetInterface(){} // RVA: 0x894DF0
        public void DestroyInterface(){} // RVA: 0x894750
        public void .ctor(){} // RVA: 0x894290
    }

    public class SteamClientClass`1 : SteamClass
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0xB43310
        public void SetInterface(){} // RVA: 0x4B50AF0
        public void DestroyInterface(){} // RVA: 0x4B50BE0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SteamClientClass`1 : SteamClass
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0xB43310
        public void SetInterface(){} // RVA: 0x4B50AF0
        public void DestroyInterface(){} // RVA: 0x4B50BE0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SteamClientClass`1 : SteamClass
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0xB43310
        public void SetInterface(){} // RVA: 0x4B50AF0
        public void DestroyInterface(){} // RVA: 0x4B50BE0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SteamClientClass`1 : SteamClass
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0xB43310
        public void SetInterface(){} // RVA: 0x4B50AF0
        public void DestroyInterface(){} // RVA: 0x4B50BE0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SteamClientClass`1 : SteamClass
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0xB43310
        public void SetInterface(){} // RVA: 0x4B50AF0
        public void DestroyInterface(){} // RVA: 0x4B50BE0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SteamClientClass`1 : SteamClass
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0xB43310
        public void SetInterface(){} // RVA: 0x4B50AF0
        public void DestroyInterface(){} // RVA: 0x4B50BE0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SteamClientClass`1 : SteamClass
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0xB43310
        public void SetInterface(){} // RVA: 0x4B50AF0
        public void DestroyInterface(){} // RVA: 0x4B50BE0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SteamClientClass`1 : SteamClass
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0xB43310
        public void SetInterface(){} // RVA: 0x4B50AF0
        public void DestroyInterface(){} // RVA: 0x4B50BE0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SteamClientClass`1 : SteamClass
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0xB43310
        public void SetInterface(){} // RVA: 0x4B50AF0
        public void DestroyInterface(){} // RVA: 0x4B50BE0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SteamClientClass`1 : SteamClass
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0xB43310
        public void SetInterface(){} // RVA: 0x4B50AF0
        public void DestroyInterface(){} // RVA: 0x4B50BE0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SteamClientClass`1 : SteamClass
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0xB43310
        public void SetInterface(){} // RVA: 0x4B50AF0
        public void DestroyInterface(){} // RVA: 0x4B50BE0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SteamClientClass`1 : SteamClass
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0xB43310
        public void SetInterface(){} // RVA: 0x4B50AF0
        public void DestroyInterface(){} // RVA: 0x4B50BE0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SteamFriends : SteamClientClass`1
    {
        // ── Methods ──
        public void get_Internal(){} // RVA: 0x29406C0
        public void InitializeInterface(){} // RVA: 0x2940750
        public void InstallEvents(){} // RVA: 0x2940890
        public void OnFriendChatMessage(){} // RVA: 0x2941820
        public void OnGameConnectedClanChatMessage(){} // RVA: 0x2941BA0
        public void SetRichPresence(){} // RVA: 0x2941F60
        public void ClearRichPresence(){} // RVA: 0x29420F0
        public void .ctor(){} // RVA: 0x29421E0
    }

    public class SteamId : ValueType
    {
        // ── Methods ──
        public void op_Implicit(){} // RVA: 0x2303260
        public void ToString(){} // RVA: 0x145350
    }

    public class SteamInput : SteamClientClass`1
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x2942630
        public void .ctor(){} // RVA: 0x29426C0
        public void .cctor(){} // RVA: 0x29426F0
    }

    public class SteamInterface : Object
    {
        // ── Methods ──
        public void GetUserInterfacePointer(){} // RVA: 0xDAC980
        public void GetServerInterfacePointer(){} // RVA: 0xDAC980
        public void GetGlobalInterfacePointer(){} // RVA: 0xDAC980
        public void set_IsServer(){} // RVA: 0xB68E00
        public void SetupInterface(){} // RVA: 0x294FDC0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SteamInventory : SteamSharedClass`1
    {
        // ── Methods ──
        public void get_Internal(){} // RVA: 0x2942B30
        public void InitializeInterface(){} // RVA: 0x2942BC0
        public void InstallEvents(){} // RVA: 0x2942C50
        public void InventoryUpdated(){} // RVA: 0x29430A0
        public void LoadDefinitions(){} // RVA: 0x29431B0
        public void set_Items(){} // RVA: 0x2943450
        public void get_Definitions(){} // RVA: 0x29434F0
        public void set_Definitions(){} // RVA: 0x2943530
        public void GetDefinitions(){} // RVA: 0x29435D0
        public void .ctor(){} // RVA: 0x29438D0
    }

    public class SteamMatchmaking : SteamClientClass`1
    {
        // ── Methods ──
        public void get_Internal(){} // RVA: 0x2943B00
        public void InitializeInterface(){} // RVA: 0x2943B90
        public void InstallEvents(){} // RVA: 0x2943C20
        public void OnLobbyChatMessageRecievedAPI(){} // RVA: 0x29448C0
        public void .ctor(){} // RVA: 0x2944C90
    }

    public class SteamMatchmakingServers : SteamClientClass`1
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x2945130
        public void .ctor(){} // RVA: 0x29451C0
    }

    public class SteamMusic : SteamClientClass`1
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x29451F0
        public void InstallEvents(){} // RVA: 0x2945280
        public void .ctor(){} // RVA: 0x29456A0
    }

    public class SteamNetworking : SteamSharedClass`1
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x2945830
        public void InstallEvents(){} // RVA: 0x29458C0
        public void .ctor(){} // RVA: 0x2945D10
    }

    public class SteamNetworkingSockets : SteamSharedClass`1
    {
        // ── Methods ──
        public void get_Internal(){} // RVA: 0x2945EB0
        public void InitializeInterface(){} // RVA: 0x2945F40
        public void GetSocketManager(){} // RVA: 0x2945FD0
        public void GetConnectionManager(){} // RVA: 0x29460F0
        public void InstallEvents(){} // RVA: 0x29461D0
        public void ConnectionStatusChanged(){} // RVA: 0x2946460
        public void FakeIPResult(){} // RVA: 0x2946CE0
        public void .ctor(){} // RVA: 0x2946E70
        public void .cctor(){} // RVA: 0x2946EA0
    }

    public class SteamNetworkingUtils : SteamSharedClass`1
    {
        // ── Methods ──
        public void get_Internal(){} // RVA: 0x2947040
        public void InitializeInterface(){} // RVA: 0x29470D0
        public void InstallCallbacks(){} // RVA: 0x2947190
        public void set_Status(){} // RVA: 0x29473D0
        public void OutputDebugMessages(){} // RVA: 0x2947430
        public void .ctor(){} // RVA: 0x2947650
        public void .cctor(){} // RVA: 0x2947680
    }

    public class SteamParental : SteamSharedClass`1
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x2947A40
        public void InstallEvents(){} // RVA: 0x2947AD0
        public void .ctor(){} // RVA: 0x2947D10
    }

    public class SteamParties : SteamClientClass`1
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x2947E40
        public void InstallEvents(){} // RVA: 0x2947ED0
        public void .ctor(){} // RVA: 0x2948320
    }

    public class SteamRemotePlay : SteamClientClass`1
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x29484B0
        public void InstallEvents(){} // RVA: 0x2948540
        public void .ctor(){} // RVA: 0x2948990
    }

    public class SteamRemoteStorage : SteamClientClass`1
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x2948B20
        public void .ctor(){} // RVA: 0x2948BB0
    }

    public class SteamScreenshots : SteamClientClass`1
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x2948BE0
        public void InstallEvents(){} // RVA: 0x2948C70
        public void .ctor(){} // RVA: 0x2949090
    }

    public class SteamSharedClass`1 : SteamClass
    {
        // ── Methods ──
        public void get_Interface(){} // RVA: 0x87C0D0
        public void InitializeInterface(){} // RVA: 0x894750
        public void SetInterface(){} // RVA: 0x894DF0
        public void DestroyInterface(){} // RVA: 0x894750
        public void .ctor(){} // RVA: 0x894290
    }

    public class SteamSharedClass`1 : SteamClass
    {
        // ── Methods ──
        public void get_Interface(){} // RVA: 0x4B50C90
        public void InitializeInterface(){} // RVA: 0xB43310
        public void SetInterface(){} // RVA: 0x4B50D20
        public void DestroyInterface(){} // RVA: 0x4B50EA0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SteamSharedClass`1 : SteamClass
    {
        // ── Methods ──
        public void get_Interface(){} // RVA: 0x4B50C90
        public void InitializeInterface(){} // RVA: 0xB43310
        public void SetInterface(){} // RVA: 0x4B50D20
        public void DestroyInterface(){} // RVA: 0x4B50EA0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SteamSharedClass`1 : SteamClass
    {
        // ── Methods ──
        public void get_Interface(){} // RVA: 0x4B50C90
        public void InitializeInterface(){} // RVA: 0xB43310
        public void SetInterface(){} // RVA: 0x4B50D20
        public void DestroyInterface(){} // RVA: 0x4B50EA0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SteamSharedClass`1 : SteamClass
    {
        // ── Methods ──
        public void get_Interface(){} // RVA: 0x4B50C90
        public void InitializeInterface(){} // RVA: 0xB43310
        public void SetInterface(){} // RVA: 0x4B50D20
        public void DestroyInterface(){} // RVA: 0x4B50EA0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SteamSharedClass`1 : SteamClass
    {
        // ── Methods ──
        public void get_Interface(){} // RVA: 0x4B50C90
        public void InitializeInterface(){} // RVA: 0xB43310
        public void SetInterface(){} // RVA: 0x4B50D20
        public void DestroyInterface(){} // RVA: 0x4B50EA0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SteamSharedClass`1 : SteamClass
    {
        // ── Methods ──
        public void get_Interface(){} // RVA: 0x4B50C90
        public void InitializeInterface(){} // RVA: 0xB43310
        public void SetInterface(){} // RVA: 0x4B50D20
        public void DestroyInterface(){} // RVA: 0x4B50EA0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SteamSharedClass`1 : SteamClass
    {
        // ── Methods ──
        public void get_Interface(){} // RVA: 0x4B50C90
        public void InitializeInterface(){} // RVA: 0xB43310
        public void SetInterface(){} // RVA: 0x4B50D20
        public void DestroyInterface(){} // RVA: 0x4B50EA0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SteamSharedClass`1 : SteamClass
    {
        // ── Methods ──
        public void get_Interface(){} // RVA: 0x4B50C90
        public void InitializeInterface(){} // RVA: 0xB43310
        public void SetInterface(){} // RVA: 0x4B50D20
        public void DestroyInterface(){} // RVA: 0x4B50EA0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SteamUGC : SteamSharedClass`1
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x2949240
        public void InstallEvents(){} // RVA: 0x29492D0
        public void .ctor(){} // RVA: 0x2949AF0
    }

    public class SteamUser : SteamClientClass`1
    {
        // ── Methods ──
        public void get_Internal(){} // RVA: 0x2949D80
        public void InitializeInterface(){} // RVA: 0x2949E10
        public void InstallEvents(){} // RVA: 0x294A180
        public void add_OnMicroTxnAuthorizationResponse(){} // RVA: 0x294B480
        public void remove_OnMicroTxnAuthorizationResponse(){} // RVA: 0x294B5F0
        public void get_SampleRate(){} // RVA: 0x294B760
        public void set_SampleRate(){} // RVA: 0x294B7C0
        public void get_OptimalSampleRate(){} // RVA: 0x294B930
        public void GetAuthSessionTicket(){} // RVA: 0x294BA00
        public void .ctor(){} // RVA: 0x294BD40
        public void .cctor(){} // RVA: 0x294BD70
    }

    public class SteamUserStats : SteamClientClass`1
    {
        // ── Methods ──
        public void get_Internal(){} // RVA: 0x294C410
        public void InitializeInterface(){} // RVA: 0x294C4A0
        public void set_StatsRecieved(){} // RVA: 0x294C620
        public void InstallEvents(){} // RVA: 0x294C660
        public void RequestCurrentStats(){} // RVA: 0x294D010
        public void .ctor(){} // RVA: 0x294D120
    }

    public class SteamUtils : SteamSharedClass`1
    {
        // ── Methods ──
        public void get_Internal(){} // RVA: 0x294D550
        public void InitializeInterface(){} // RVA: 0x294D5E0
        public void InstallEvents(){} // RVA: 0x294D6A0
        public void SteamClosed(){} // RVA: 0x294E0B0
        public void get_IsRunningOnSteamDeck(){} // RVA: 0x294E150
        public void .ctor(){} // RVA: 0x294E290
        public void .cctor(){} // RVA: 0x294E2C0
    }

    public class SteamVideo : SteamClientClass`1
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x294E650
        public void InstallEvents(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0x294E6E0
    }

    public class Utf8StringPointer : ValueType
    {
        // ── Methods ──
        public void op_Implicit(){} // RVA: 0x29500C0
    }

    public class Utf8StringToNative : Object
    {
        // ── Methods ──
        public void MarshalManagedToNative(){} // RVA: 0x294FE50
        public void MarshalNativeToManaged(){} // RVA: 0x294FFB0
        public void CleanUpNativeData(){} // RVA: 0x294FFF0
        public void CleanUpManagedData(){} // RVA: 0x2950040
        public void GetNativeDataSize(){} // RVA: 0xFE6B70
        public void GetInstance(){} // RVA: 0x2950080
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Utility : Object
    {
        // ── Methods ──
        public void ToType(){} // RVA: 0x2B04BC0
        public void Swap(){} // RVA: 0x29501D0
        public void IpToInt32(){} // RVA: 0x29501E0
        public void Int32ToIp(){} // RVA: 0x2950280
        public void .cctor(){} // RVA: 0x2950300
    }

}