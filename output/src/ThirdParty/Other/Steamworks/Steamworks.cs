// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Steamworks
// Classes: 86
// Methods: 435

namespace ThirdParty.Other.Steamworks
{
    public class AppId : ValueType
    {
        // ── Methods ──
        public void ToString(){} // RVA: 0x7A771EAE0
        public void op_Implicit(){} // RVA: 0x7A9ED9B50
    }

    public class AuthTicket : Object
    {
        // ── Methods ──
        public void Cancel(){} // RVA: 0x7A9EBEB40
        public void Dispose(){} // RVA: 0x7A9EBEC80
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class CallbackTypeFactory : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7A9EC1A10
    }

    public class ConnectionManager : Object
    {
        // ── Methods ──
        public void get_Interface(){} // RVA: 0x7A80F2570
        public void set_ConnectionInfo(){} // RVA: 0x7A9EC96F0
        public void OnConnectionChanged(){} // RVA: 0x7A9EC97D0
        public void OnConnecting(){} // RVA: 0x7A9EC9B10
        public void OnConnected(){} // RVA: 0x7A9EC9BF0
        public void OnDisconnected(){} // RVA: 0x7A9EC9CE0
    }

    public class Dispatch : Object
    {
        // ── Methods ──
        public void SteamAPI_ManualDispatch_Init(){} // RVA: 0x7A9EBEC90
        public void SteamAPI_ManualDispatch_RunFrame(){} // RVA: 0x7A9EBED00
        public void SteamAPI_ManualDispatch_GetNextCallback(){} // RVA: 0x7A9EBED80
        public void SteamAPI_ManualDispatch_FreeLastCallback(){} // RVA: 0x7A9EBEE10
        public void get_ClientPipe(){} // RVA: 0x7A9EBEE90
        public void set_ClientPipe(){} // RVA: 0x7A9EBEEF0
        public void get_ServerPipe(){} // RVA: 0x7A9EBEF50
        public void Init(){} // RVA: 0x7A9EBEFB0
        public void Frame(){} // RVA: 0x7A9EBF050
        public void ProcessCallback(){} // RVA: 0x7A9EBF4C0
        public void CallbackToString(){} // RVA: 0x7A9EBFAA0
        public void ProcessResult(){} // RVA: 0x7A9EC0290
        public void LoopClientAsync(){} // RVA: 0x7A9EC05D0
        public void Install(){} // RVA: 0x7AA442350
        public void ShutdownClient(){} // RVA: 0x7A9EC0730
        public void .cctor(){} // RVA: 0x7A9EC1070
    }

    public class Friend : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A767FEF0
        public void ToString(){} // RVA: 0x7A771EAF0
        public void get_Name(){} // RVA: 0x7A771EB80
    }

    public class Helpers : Object
    {
        // ── Methods ──
        public void TakeMemory(){} // RVA: 0x7A9EDA550
        public void TakeBuffer(){} // RVA: 0x7A9EDA5A0
        public void MemoryToString(){} // RVA: 0x7A9EDA930
        public void .cctor(){} // RVA: 0x7A9EDAA00
    }

    public class ICallbackData
    {
        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7A7E00710
    }

    public class IConnectionManager
    {
        // ── Methods ──
        public void OnConnecting(){} // RVA: 0x7A7E18800
        public void OnConnected(){} // RVA: 0x7A7E18800
        public void OnDisconnected(){} // RVA: 0x7A7E18800
    }

    public class ISocketManager
    {
        // ── Methods ──
        public void OnConnecting(){} // RVA: 0x7A7E19BE0
        public void OnConnected(){} // RVA: 0x7A7E19BE0
        public void OnDisconnected(){} // RVA: 0x7A7E19BE0
    }

    public class ISteamApps : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A9EC64C0
        public void SteamAPI_SteamApps_v008(){} // RVA: 0x7A9EC64D0
        public void GetUserInterfacePointer(){} // RVA: 0x7A9EC64D0
        public void _GetCurrentBetaName(){} // RVA: 0x7A9EC6540
        public void GetCurrentBetaName(){} // RVA: 0x7A9EC65E0
        public void _GetLaunchQueryParam(){} // RVA: 0x7A9EC68A0
        public void GetLaunchQueryParam(){} // RVA: 0x7A9EC6960
        public void _GetLaunchCommandLine(){} // RVA: 0x7A9EC6A20
        public void GetLaunchCommandLine(){} // RVA: 0x7A9EC6AC0
    }

    public class ISteamFriends : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A9EC64C0
        public void SteamAPI_SteamFriends_v017(){} // RVA: 0x7A9EC6D70
        public void GetUserInterfacePointer(){} // RVA: 0x7A9EC6D70
        public void _GetPersonaName(){} // RVA: 0x7A9EC6DE0
        public void GetPersonaName(){} // RVA: 0x7A9EC6E60
        public void _GetFriendPersonaName(){} // RVA: 0x7A9EC6EF0
        public void GetFriendPersonaName(){} // RVA: 0x7A9EC6F80
        public void _SetRichPresence(){} // RVA: 0x7A9EC7020
        public void SetRichPresence(){} // RVA: 0x7A9EC7100
        public void _ClearRichPresence(){} // RVA: 0x7A9EC71E0
        public void ClearRichPresence(){} // RVA: 0x7A9EC7260
        public void _GetClanChatMessage(){} // RVA: 0x7A9EC72E0
        public void GetClanChatMessage(){} // RVA: 0x7A9EC7390
        public void _GetFriendMessage(){} // RVA: 0x7A9EC7440
        public void GetFriendMessage(){} // RVA: 0x7A9EC74F0
    }

    public class ISteamInput : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A9EC64C0
        public void SteamAPI_SteamInput_v006(){} // RVA: 0x7A9EC75A0
        public void GetUserInterfacePointer(){} // RVA: 0x7A9EC75A0
    }

    public class ISteamInventory : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A9EC64C0
        public void SteamAPI_SteamInventory_v003(){} // RVA: 0x7A9EC7610
        public void GetUserInterfacePointer(){} // RVA: 0x7A9EC7610
        public void SteamAPI_SteamGameServerInventory_v003(){} // RVA: 0x7A9EC7680
        public void GetServerInterfacePointer(){} // RVA: 0x7A9EC7680
        public void _GetResultItems(){} // RVA: 0x7A9EC76F0
        public void GetResultItems(){} // RVA: 0x7A9EC77A0
        public void _GetResultItemProperty(){} // RVA: 0x7A9EC7850
        public void GetResultItemProperty(){} // RVA: 0x7A9EC7940
        public void _DestroyResult(){} // RVA: 0x7A9EC7C50
        public void DestroyResult(){} // RVA: 0x7A9EC7CE0
        public void _GetItemDefinitionIDs(){} // RVA: 0x7A9EC7D70
        public void GetItemDefinitionIDs(){} // RVA: 0x7A9EC7E20
    }

    public class ISteamMatchmaking : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A9EC64C0
        public void SteamAPI_SteamMatchmaking_v009(){} // RVA: 0x7A9EC7ED0
        public void GetUserInterfacePointer(){} // RVA: 0x7A9EC7ED0
        public void _GetLobbyChatEntry(){} // RVA: 0x7A9EC7F40
        public void GetLobbyChatEntry(){} // RVA: 0x7A9EC7FF0
    }

    public class ISteamMatchmakingServers : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A9EC64C0
        public void SteamAPI_SteamMatchmakingServers_v002(){} // RVA: 0x7A9EC80A0
        public void GetUserInterfacePointer(){} // RVA: 0x7A9EC80A0
    }

    public class ISteamMusic : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A9EC64C0
        public void SteamAPI_SteamMusic_v001(){} // RVA: 0x7A9EC8110
        public void GetUserInterfacePointer(){} // RVA: 0x7A9EC8110
    }

    public class ISteamNetworking : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A9EC64C0
        public void SteamAPI_SteamNetworking_v006(){} // RVA: 0x7A9EC8180
        public void GetUserInterfacePointer(){} // RVA: 0x7A9EC8180
        public void SteamAPI_SteamGameServerNetworking_v006(){} // RVA: 0x7A9EC81F0
        public void GetServerInterfacePointer(){} // RVA: 0x7A9EC81F0
    }

    public class ISteamNetworkingSockets : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A9EC64C0
        public void SteamAPI_SteamNetworkingSockets_SteamAPI_v012(){} // RVA: 0x7A9EC8260
        public void GetUserInterfacePointer(){} // RVA: 0x7A9EC8260
        public void SteamAPI_SteamGameServerNetworkingSockets_SteamAPI_v012(){} // RVA: 0x7A9EC82D0
        public void GetServerInterfacePointer(){} // RVA: 0x7A9EC82D0
        public void _AcceptConnection(){} // RVA: 0x7A9EC8340
        public void AcceptConnection(){} // RVA: 0x7A9EC83D0
        public void _CloseConnection(){} // RVA: 0x7A9EC8460
        public void CloseConnection(){} // RVA: 0x7A9EC8540
        public void _SetConnectionPollGroup(){} // RVA: 0x7A9EC8620
        public void SetConnectionPollGroup(){} // RVA: 0x7A9EC86C0
    }

    public class ISteamNetworkingUtils : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A9EC64C0
        public void SteamAPI_SteamNetworkingUtils_SteamAPI_v004(){} // RVA: 0x7A9EC8760
        public void GetGlobalInterfacePointer(){} // RVA: 0x7A9EC8760
        public void _SteamNetworkingIdentity_ToString(){} // RVA: 0x7A9EC87D0
        public void SteamNetworkingIdentity_ToString(){} // RVA: 0x7A9EC8880
    }

    public class ISteamParentalSettings : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A9EC64C0
        public void SteamAPI_SteamParentalSettings_v001(){} // RVA: 0x7A9EC8B30
        public void GetUserInterfacePointer(){} // RVA: 0x7A9EC8B30
    }

    public class ISteamParties : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A9EC64C0
        public void SteamAPI_SteamParties_v002(){} // RVA: 0x7A9EC8BA0
        public void GetUserInterfacePointer(){} // RVA: 0x7A9EC8BA0
    }

    public class ISteamRemotePlay : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A9EC64C0
        public void SteamAPI_SteamRemotePlay_v001(){} // RVA: 0x7A9EC8C10
        public void GetUserInterfacePointer(){} // RVA: 0x7A9EC8C10
    }

    public class ISteamRemoteStorage : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A9EC64C0
        public void SteamAPI_SteamRemoteStorage_v016(){} // RVA: 0x7A9EC8C80
        public void GetUserInterfacePointer(){} // RVA: 0x7A9EC8C80
    }

    public class ISteamScreenshots : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A9EC64C0
        public void SteamAPI_SteamScreenshots_v003(){} // RVA: 0x7A9EC8CF0
        public void GetUserInterfacePointer(){} // RVA: 0x7A9EC8CF0
    }

    public class ISteamUGC : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A9EC64C0
        public void SteamAPI_SteamUGC_v016(){} // RVA: 0x7A9EC8D60
        public void GetUserInterfacePointer(){} // RVA: 0x7A9EC8D60
        public void SteamAPI_SteamGameServerUGC_v016(){} // RVA: 0x7A9EC8DD0
        public void GetServerInterfacePointer(){} // RVA: 0x7A9EC8DD0
    }

    public class ISteamUser : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A9EC64C0
        public void SteamAPI_SteamUser_v021(){} // RVA: 0x7A9EC8E40
        public void GetUserInterfacePointer(){} // RVA: 0x7A9EC8E40
        public void _GetSteamID(){} // RVA: 0x7A9EC8EB0
        public void GetSteamID(){} // RVA: 0x7A9EC8F30
        public void _GetVoiceOptimalSampleRate(){} // RVA: 0x7A9EC8FB0
        public void GetVoiceOptimalSampleRate(){} // RVA: 0x7A9EC9030
        public void _GetAuthSessionTicket(){} // RVA: 0x7A9EC90B0
        public void GetAuthSessionTicket(){} // RVA: 0x7A9EC9160
        public void _CancelAuthTicket(){} // RVA: 0x7A9EC9210
        public void CancelAuthTicket(){} // RVA: 0x7A9EC92A0
    }

    public class ISteamUserStats : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A9EC64C0
        public void SteamAPI_SteamUserStats_v012(){} // RVA: 0x7A9EC9330
        public void GetUserInterfacePointer(){} // RVA: 0x7A9EC9330
        public void _RequestCurrentStats(){} // RVA: 0x7A9EC93A0
        public void RequestCurrentStats(){} // RVA: 0x7A9EC9420
    }

    public class ISteamUtils : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A9EC64C0
        public void SteamAPI_SteamUtils_v010(){} // RVA: 0x7A9EC94A0
        public void GetUserInterfacePointer(){} // RVA: 0x7A9EC94A0
        public void SteamAPI_SteamGameServerUtils_v010(){} // RVA: 0x7A9EC9510
        public void GetServerInterfacePointer(){} // RVA: 0x7A9EC9510
        public void _IsSteamRunningOnSteamDeck(){} // RVA: 0x7A9EC9580
        public void IsSteamRunningOnSteamDeck(){} // RVA: 0x7A9EC9600
    }

    public class ISteamVideo : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A9EC64C0
        public void SteamAPI_SteamVideo_v002(){} // RVA: 0x7A9EC9680
        public void GetUserInterfacePointer(){} // RVA: 0x7A9EC9680
    }

    public class InventoryDef : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80DA0C0
        public void get_Id(){} // RVA: 0x7A8124910
        public void op_Equality(){} // RVA: 0x7A9ED9CA0
        public void Equals(){} // RVA: 0x7A9ED9D60
        public void GetHashCode(){} // RVA: 0x7A8124910
    }

    public class InventoryItem : ValueType
    {
        // ── Methods ──
        public void From(){} // RVA: 0x7A9ED9DB0
        public void GetProperties(){} // RVA: 0x7A9ED9DE0
        public void Equals(){} // RVA: 0x7A771EC40
        public void GetHashCode(){} // RVA: 0x7A771EC30
    }

    public class InventoryResult : ValueType
    {
        // ── Methods ──
        public void set_Expired(){} // RVA: 0x7A763C9A0
        public void .ctor(){} // RVA: 0x7A7613500
        public void get_ItemCount(){} // RVA: 0x7A771EC60
        public void GetItems(){} // RVA: 0x7A771EC70
        public void Dispose(){} // RVA: 0x7A771EC80
    }

    public class PreserveAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class SocketManager : Object
    {
        // ── Methods ──
        public void get_Interface(){} // RVA: 0x7A80F2570
        public void OnConnectionChanged(){} // RVA: 0x7A9EC9DD0
        public void OnConnecting(){} // RVA: 0x7A9ECA1A0
        public void OnConnected(){} // RVA: 0x7A9ECA2C0
        public void OnDisconnected(){} // RVA: 0x7A9ECA490
    }

    public class SteamAPI : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7A9EC1840
        public void Shutdown(){} // RVA: 0x7A9EC18B0
        public void GetHSteamPipe(){} // RVA: 0x7A9EC1920
        public void RestartAppIfNecessary(){} // RVA: 0x7A9EC1990
    }

    public class SteamApps : SteamSharedClass`1
    {
        // ── Methods ──
        public void get_Internal(){} // RVA: 0x7A9ECA5E0
        public void InitializeInterface(){} // RVA: 0x7A9ECA670
        public void add_OnNewLaunchParameters(){} // RVA: 0x7A9ECA700
        public void remove_OnNewLaunchParameters(){} // RVA: 0x7A9ECA810
        public void get_CurrentBetaName(){} // RVA: 0x7A9ECA920
        public void GetLaunchParam(){} // RVA: 0x7A9ECA960
        public void get_CommandLine(){} // RVA: 0x7A9ECAA30
        public void .ctor(){} // RVA: 0x7A9ECAA70
    }

    public class SteamClass : Object
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7A7E18C30
        public void DestroyInterface(){} // RVA: 0x7A7E18C30
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class SteamClass[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class SteamClient : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7A9ECAAA0
        public void AddInterface(){} // RVA: 0x7AA59BA10
        public void ShutdownInterfaces(){} // RVA: 0x7A9ECB1A0
        public void get_IsValid(){} // RVA: 0x7A9ECB3A0
        public void Shutdown(){} // RVA: 0x7A9ECB400
        public void Cleanup(){} // RVA: 0x7A9ECB510
        public void get_SteamId(){} // RVA: 0x7A9ECB5A0
        public void get_Name(){} // RVA: 0x7A9ECB670
        public void set_AppId(){} // RVA: 0x7A9ECB710
        public void RestartAppIfNecessary(){} // RVA: 0x7A9EC1990
        public void .cctor(){} // RVA: 0x7A9ECB770
    }

    public class SteamClientClass`1 : SteamClass
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7A7E18C30
        public void SetInterface(){} // RVA: 0x7A7E19310
        public void DestroyInterface(){} // RVA: 0x7A7E18C30
        public void .ctor(){} // RVA: 0x7A7E18770
    }

    public class SteamClientClass`1 : SteamClass
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7A80D7310
        public void SetInterface(){} // RVA: 0x7ABE81F70
        public void DestroyInterface(){} // RVA: 0x7ABE82060
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class SteamClientClass`1 : SteamClass
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7A80D7310
        public void SetInterface(){} // RVA: 0x7ABE81F70
        public void DestroyInterface(){} // RVA: 0x7ABE82060
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class SteamClientClass`1 : SteamClass
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7A80D7310
        public void SetInterface(){} // RVA: 0x7ABE81F70
        public void DestroyInterface(){} // RVA: 0x7ABE82060
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class SteamClientClass`1 : SteamClass
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7A80D7310
        public void SetInterface(){} // RVA: 0x7ABE81F70
        public void DestroyInterface(){} // RVA: 0x7ABE82060
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class SteamClientClass`1 : SteamClass
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7A80D7310
        public void SetInterface(){} // RVA: 0x7ABE81F70
        public void DestroyInterface(){} // RVA: 0x7ABE82060
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class SteamClientClass`1 : SteamClass
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7A80D7310
        public void SetInterface(){} // RVA: 0x7ABE81F70
        public void DestroyInterface(){} // RVA: 0x7ABE82060
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class SteamClientClass`1 : SteamClass
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7A80D7310
        public void SetInterface(){} // RVA: 0x7ABE81F70
        public void DestroyInterface(){} // RVA: 0x7ABE82060
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class SteamClientClass`1 : SteamClass
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7A80D7310
        public void SetInterface(){} // RVA: 0x7ABE81F70
        public void DestroyInterface(){} // RVA: 0x7ABE82060
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class SteamClientClass`1 : SteamClass
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7A80D7310
        public void SetInterface(){} // RVA: 0x7ABE81F70
        public void DestroyInterface(){} // RVA: 0x7ABE82060
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class SteamClientClass`1 : SteamClass
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7A80D7310
        public void SetInterface(){} // RVA: 0x7ABE81F70
        public void DestroyInterface(){} // RVA: 0x7ABE82060
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class SteamClientClass`1 : SteamClass
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7A80D7310
        public void SetInterface(){} // RVA: 0x7ABE81F70
        public void DestroyInterface(){} // RVA: 0x7ABE82060
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class SteamClientClass`1 : SteamClass
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7A80D7310
        public void SetInterface(){} // RVA: 0x7ABE81F70
        public void DestroyInterface(){} // RVA: 0x7ABE82060
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class SteamFriends : SteamClientClass`1
    {
        // ── Methods ──
        public void get_Internal(){} // RVA: 0x7A9ECB850
        public void InitializeInterface(){} // RVA: 0x7A9ECB8E0
        public void InstallEvents(){} // RVA: 0x7A9ECBA20
        public void OnFriendChatMessage(){} // RVA: 0x7A9ECC9B0
        public void OnGameConnectedClanChatMessage(){} // RVA: 0x7A9ECCD30
        public void SetRichPresence(){} // RVA: 0x7A9ECD0F0
        public void ClearRichPresence(){} // RVA: 0x7A9ECD280
        public void .ctor(){} // RVA: 0x7A9ECD370
    }

    public class SteamId : ValueType
    {
        // ── Methods ──
        public void op_Implicit(){} // RVA: 0x7A97F8BA0
        public void ToString(){} // RVA: 0x7A771ED30
    }

    public class SteamInput : SteamClientClass`1
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7A9ECD7C0
        public void .ctor(){} // RVA: 0x7A9ECD850
        public void .cctor(){} // RVA: 0x7A9ECD880
    }

    public class SteamInterface : Object
    {
        // ── Methods ──
        public void GetUserInterfacePointer(){} // RVA: 0x7A82D1450
        public void GetServerInterfacePointer(){} // RVA: 0x7A82D1450
        public void GetGlobalInterfacePointer(){} // RVA: 0x7A82D1450
        public void set_IsServer(){} // RVA: 0x7A80FD6A0
        public void SetupInterface(){} // RVA: 0x7A9EDB210
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class SteamInventory : SteamSharedClass`1
    {
        // ── Methods ──
        public void get_Internal(){} // RVA: 0x7A9ECDCC0
        public void InitializeInterface(){} // RVA: 0x7A9ECDD50
        public void InstallEvents(){} // RVA: 0x7A9ECDDE0
        public void InventoryUpdated(){} // RVA: 0x7A9ECE230
        public void LoadDefinitions(){} // RVA: 0x7A9ECE340
        public void set_Items(){} // RVA: 0x7A9ECE5E0
        public void get_Definitions(){} // RVA: 0x7A9ECE680
        public void set_Definitions(){} // RVA: 0x7A9ECE6C0
        public void GetDefinitions(){} // RVA: 0x7A9ECE760
        public void .ctor(){} // RVA: 0x7A9ECEA60
    }

    public class SteamMatchmaking : SteamClientClass`1
    {
        // ── Methods ──
        public void get_Internal(){} // RVA: 0x7A9ECEC90
        public void InitializeInterface(){} // RVA: 0x7A9ECED20
        public void InstallEvents(){} // RVA: 0x7A9ECEDB0
        public void OnLobbyChatMessageRecievedAPI(){} // RVA: 0x7A9ECFA50
        public void .ctor(){} // RVA: 0x7A9ECFE20
    }

    public class SteamMatchmakingServers : SteamClientClass`1
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7A9ED02C0
        public void .ctor(){} // RVA: 0x7A9ED0350
    }

    public class SteamMusic : SteamClientClass`1
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7A9ED0380
        public void InstallEvents(){} // RVA: 0x7A9ED0410
        public void .ctor(){} // RVA: 0x7A9ED0830
    }

    public class SteamNetworking : SteamSharedClass`1
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7A9ED09C0
        public void InstallEvents(){} // RVA: 0x7A9ED0A50
        public void .ctor(){} // RVA: 0x7A9ED0EA0
    }

    public class SteamNetworkingSockets : SteamSharedClass`1
    {
        // ── Methods ──
        public void get_Internal(){} // RVA: 0x7A9ED1040
        public void InitializeInterface(){} // RVA: 0x7A9ED10D0
        public void GetSocketManager(){} // RVA: 0x7A9ED1160
        public void GetConnectionManager(){} // RVA: 0x7A9ED1280
        public void InstallEvents(){} // RVA: 0x7A9ED1360
        public void ConnectionStatusChanged(){} // RVA: 0x7A9ED15F0
        public void FakeIPResult(){} // RVA: 0x7A9ED1E70
        public void .ctor(){} // RVA: 0x7A9ED2000
        public void .cctor(){} // RVA: 0x7A9ED2030
    }

    public class SteamNetworkingUtils : SteamSharedClass`1
    {
        // ── Methods ──
        public void get_Internal(){} // RVA: 0x7A9ED21D0
        public void InitializeInterface(){} // RVA: 0x7A9ED2260
        public void InstallCallbacks(){} // RVA: 0x7A9ED2320
        public void set_Status(){} // RVA: 0x7A9ED2560
        public void OutputDebugMessages(){} // RVA: 0x7A9ED25C0
        public void .ctor(){} // RVA: 0x7A9ED27E0
        public void .cctor(){} // RVA: 0x7A9ED2810
    }

    public class SteamParental : SteamSharedClass`1
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7A9ED2BD0
        public void InstallEvents(){} // RVA: 0x7A9ED2C60
        public void .ctor(){} // RVA: 0x7A9ED2EA0
    }

    public class SteamParties : SteamClientClass`1
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7A9ED2FD0
        public void InstallEvents(){} // RVA: 0x7A9ED3060
        public void .ctor(){} // RVA: 0x7A9ED34B0
    }

    public class SteamRemotePlay : SteamClientClass`1
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7A9ED3640
        public void InstallEvents(){} // RVA: 0x7A9ED36D0
        public void .ctor(){} // RVA: 0x7A9ED3B20
    }

    public class SteamRemoteStorage : SteamClientClass`1
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7A9ED3CB0
        public void .ctor(){} // RVA: 0x7A9ED3D40
    }

    public class SteamScreenshots : SteamClientClass`1
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7A9ED3D70
        public void InstallEvents(){} // RVA: 0x7A9ED3E00
        public void .ctor(){} // RVA: 0x7A9ED4220
    }

    public class SteamSharedClass`1 : SteamClass
    {
        // ── Methods ──
        public void get_Interface(){} // RVA: 0x7A7E006B0
        public void InitializeInterface(){} // RVA: 0x7A7E18C30
        public void SetInterface(){} // RVA: 0x7A7E19310
        public void DestroyInterface(){} // RVA: 0x7A7E18C30
        public void .ctor(){} // RVA: 0x7A7E18770
    }

    public class SteamSharedClass`1 : SteamClass
    {
        // ── Methods ──
        public void get_Interface(){} // RVA: 0x7ABE82110
        public void InitializeInterface(){} // RVA: 0x7A80D7310
        public void SetInterface(){} // RVA: 0x7ABE821A0
        public void DestroyInterface(){} // RVA: 0x7ABE82320
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class SteamSharedClass`1 : SteamClass
    {
        // ── Methods ──
        public void get_Interface(){} // RVA: 0x7ABE82110
        public void InitializeInterface(){} // RVA: 0x7A80D7310
        public void SetInterface(){} // RVA: 0x7ABE821A0
        public void DestroyInterface(){} // RVA: 0x7ABE82320
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class SteamSharedClass`1 : SteamClass
    {
        // ── Methods ──
        public void get_Interface(){} // RVA: 0x7ABE82110
        public void InitializeInterface(){} // RVA: 0x7A80D7310
        public void SetInterface(){} // RVA: 0x7ABE821A0
        public void DestroyInterface(){} // RVA: 0x7ABE82320
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class SteamSharedClass`1 : SteamClass
    {
        // ── Methods ──
        public void get_Interface(){} // RVA: 0x7ABE82110
        public void InitializeInterface(){} // RVA: 0x7A80D7310
        public void SetInterface(){} // RVA: 0x7ABE821A0
        public void DestroyInterface(){} // RVA: 0x7ABE82320
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class SteamSharedClass`1 : SteamClass
    {
        // ── Methods ──
        public void get_Interface(){} // RVA: 0x7ABE82110
        public void InitializeInterface(){} // RVA: 0x7A80D7310
        public void SetInterface(){} // RVA: 0x7ABE821A0
        public void DestroyInterface(){} // RVA: 0x7ABE82320
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class SteamSharedClass`1 : SteamClass
    {
        // ── Methods ──
        public void get_Interface(){} // RVA: 0x7ABE82110
        public void InitializeInterface(){} // RVA: 0x7A80D7310
        public void SetInterface(){} // RVA: 0x7ABE821A0
        public void DestroyInterface(){} // RVA: 0x7ABE82320
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class SteamSharedClass`1 : SteamClass
    {
        // ── Methods ──
        public void get_Interface(){} // RVA: 0x7ABE82110
        public void InitializeInterface(){} // RVA: 0x7A80D7310
        public void SetInterface(){} // RVA: 0x7ABE821A0
        public void DestroyInterface(){} // RVA: 0x7ABE82320
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class SteamSharedClass`1 : SteamClass
    {
        // ── Methods ──
        public void get_Interface(){} // RVA: 0x7ABE82110
        public void InitializeInterface(){} // RVA: 0x7A80D7310
        public void SetInterface(){} // RVA: 0x7ABE821A0
        public void DestroyInterface(){} // RVA: 0x7ABE82320
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class SteamUGC : SteamSharedClass`1
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7A9ED43D0
        public void InstallEvents(){} // RVA: 0x7A9ED4460
        public void .ctor(){} // RVA: 0x7A9ED4C80
    }

    public class SteamUser : SteamClientClass`1
    {
        // ── Methods ──
        public void get_Internal(){} // RVA: 0x7A9ED4F10
        public void InitializeInterface(){} // RVA: 0x7A9ED4FA0
        public void InstallEvents(){} // RVA: 0x7A9ED5310
        public void add_OnMicroTxnAuthorizationResponse(){} // RVA: 0x7A9ED6610
        public void remove_OnMicroTxnAuthorizationResponse(){} // RVA: 0x7A9ED6780
        public void get_SampleRate(){} // RVA: 0x7A9ED68F0
        public void set_SampleRate(){} // RVA: 0x7A9ED6950
        public void get_OptimalSampleRate(){} // RVA: 0x7A9ED6AC0
        public void GetAuthSessionTicket(){} // RVA: 0x7A9ED6B90
        public void .ctor(){} // RVA: 0x7A9ED6ED0
        public void .cctor(){} // RVA: 0x7A9ED6F00
    }

    public class SteamUserStats : SteamClientClass`1
    {
        // ── Methods ──
        public void get_Internal(){} // RVA: 0x7A9ED75A0
        public void InitializeInterface(){} // RVA: 0x7A9ED7630
        public void set_StatsRecieved(){} // RVA: 0x7A9ED77B0
        public void InstallEvents(){} // RVA: 0x7A9ED77F0
        public void RequestCurrentStats(){} // RVA: 0x7A9ED81A0
        public void .ctor(){} // RVA: 0x7A9ED82B0
    }

    public class SteamUtils : SteamSharedClass`1
    {
        // ── Methods ──
        public void get_Internal(){} // RVA: 0x7A9ED86E0
        public void InitializeInterface(){} // RVA: 0x7A9ED8770
        public void InstallEvents(){} // RVA: 0x7A9ED8830
        public void SteamClosed(){} // RVA: 0x7A9ED9240
        public void add_OnAppResumingFromSuspend(){} // RVA: 0x7A9ED92E0
        public void remove_OnAppResumingFromSuspend(){} // RVA: 0x7A9ED9430
        public void get_IsRunningOnSteamDeck(){} // RVA: 0x7A9ED9580
        public void .ctor(){} // RVA: 0x7A9ED96C0
        public void .cctor(){} // RVA: 0x7A9ED96F0
    }

    public class SteamVideo : SteamClientClass`1
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7A9ED9A80
        public void InstallEvents(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7A9ED9B10
    }

    public class Utf8StringPointer : ValueType
    {
        // ── Methods ──
        public void op_Implicit(){} // RVA: 0x7A9EDB520
    }

    public class Utf8StringToNative : Object
    {
        // ── Methods ──
        public void MarshalManagedToNative(){} // RVA: 0x7A9EDB2A0
        public void MarshalNativeToManaged(){} // RVA: 0x7A9EDB410
        public void CleanUpNativeData(){} // RVA: 0x7A9EDB450
        public void CleanUpManagedData(){} // RVA: 0x7A9EDB4A0
        public void GetNativeDataSize(){} // RVA: 0x7A85193D0
        public void GetInstance(){} // RVA: 0x7A9EDB4E0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class Utility : Object
    {
        // ── Methods ──
        public void ToType(){} // RVA: 0x7A9F2B840
        public void Swap(){} // RVA: 0x7A9EDB630
        public void IpToInt32(){} // RVA: 0x7A9EDB640
        public void Int32ToIp(){} // RVA: 0x7A9EDB6E0
        public void .cctor(){} // RVA: 0x7A9EDB760
    }

}