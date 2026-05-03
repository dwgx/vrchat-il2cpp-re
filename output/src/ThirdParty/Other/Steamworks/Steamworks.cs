// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Steamworks
// Classes: 65
// Methods: 336

namespace ThirdParty.Other.Steamworks
{
    public class AppId : ValueType
    {
        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFE82E53600
        public void op_Implicit(){} // RVA: 0x7FFE82E53610
    }

    public class AuthTicket : Object
    {
        // ── Methods ──
        public void Cancel(){} // RVA: 0x7FFE82E38160
        public void Dispose(){} // RVA: 0x7FFE82E382A0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class CallbackTypeFactory : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE82E3AFC0
    }

    public class ConnectionManager : Object
    {
        public Steamworks.IConnectionManager _interface; // 0x10
        public Steamworks.Data.ConnectionInfo _connectionInfo; // 0x18

        // ── Methods ──
        public void get_Interface(){} // RVA: 0x7FFE81116380
        public void set_ConnectionInfo(){} // RVA: 0x7FFE82E42C60
        public void OnConnectionChanged(){} // RVA: 0x7FFE82E42D40
        public void OnConnecting(){} // RVA: 0x7FFE82E43080
        public void OnConnected(){} // RVA: 0x7FFE82E43160
        public void OnDisconnected(){} // RVA: 0x7FFE82E43250
    }

    public class Dispatch : Object
    {
        public System.Action`3<0x66686C5C,string,bool> OnDebugCallback;
        public System.Action`1<System.Exception> OnException; // 0x8

        // ── Methods ──
        public void SteamAPI_ManualDispatch_Init(){} // RVA: 0x7FFE82E382B0
        public void SteamAPI_ManualDispatch_RunFrame(){} // RVA: 0x7FFE82E38320
        public void SteamAPI_ManualDispatch_GetNextCallback(){} // RVA: 0x7FFE82E383A0
        public void SteamAPI_ManualDispatch_FreeLastCallback(){} // RVA: 0x7FFE82E38430
        public void get_ClientPipe(){} // RVA: 0x7FFE82E384B0
        public void set_ClientPipe(){} // RVA: 0x7FFE82E38510
        public void get_ServerPipe(){} // RVA: 0x7FFE82E38570
        public void Init(){} // RVA: 0x7FFE82E385D0
        public void Frame(){} // RVA: 0x7FFE82E38670
        public void ProcessCallback(){} // RVA: 0x7FFE82E38AD0
        public void CallbackToString(){} // RVA: 0x7FFE82E39090
        public void ProcessResult(){} // RVA: 0x7FFE82E39860
        public void LoopClientAsync(){} // RVA: 0x7FFE82E39BA0
        public void Install(){} // RVA: 0x7FFE80E4B9E0
        public void ShutdownClient(){} // RVA: 0x7FFE82E39CF0
        public void .cctor(){} // RVA: 0x7FFE82E3A620
    }

    public class Friend : ValueType
    {
        public Steamworks.SteamId Id; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82889220
        public void ToString(){} // RVA: 0x7FFE82E53620
        public void get_Name(){} // RVA: 0x7FFE82E536B0
    }

    public class Helpers : Object
    {
        // ── Methods ──
        public void TakeMemory(){} // RVA: 0x7FFE82E54020
        public void TakeBuffer(){} // RVA: 0x7FFE82E54070
        public void MemoryToString(){} // RVA: 0x7FFE82E54450
        public void .cctor(){} // RVA: 0x7FFE82E54520
    }

    public class ICallbackData
    {
        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE80E2EDB0
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

    public class ISteamApps : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82E3FA70
        public void SteamAPI_SteamApps_v008(){} // RVA: 0x7FFE82E3FA80
        public void GetUserInterfacePointer(){} // RVA: 0x7FFE82E3FA80
        public void _GetCurrentBetaName(){} // RVA: 0x7FFE82E3FAF0
        public void GetCurrentBetaName(){} // RVA: 0x7FFE82E3FB90
        public void _GetLaunchQueryParam(){} // RVA: 0x7FFE82E3FE50
        public void GetLaunchQueryParam(){} // RVA: 0x7FFE82E3FF10
        public void _GetLaunchCommandLine(){} // RVA: 0x7FFE82E3FFD0
        public void GetLaunchCommandLine(){} // RVA: 0x7FFE82E40070
    }

    public class ISteamFriends : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82E3FA70
        public void SteamAPI_SteamFriends_v017(){} // RVA: 0x7FFE82E40310
        public void GetUserInterfacePointer(){} // RVA: 0x7FFE82E40310
        public void _GetPersonaName(){} // RVA: 0x7FFE82E40380
        public void GetPersonaName(){} // RVA: 0x7FFE82E40400
        public void _GetFriendPersonaName(){} // RVA: 0x7FFE82E40490
        public void GetFriendPersonaName(){} // RVA: 0x7FFE82E40520
        public void _SetRichPresence(){} // RVA: 0x7FFE82E405C0
        public void SetRichPresence(){} // RVA: 0x7FFE82E406A0
        public void _ClearRichPresence(){} // RVA: 0x7FFE82E40780
        public void ClearRichPresence(){} // RVA: 0x7FFE82E40800
        public void _GetClanChatMessage(){} // RVA: 0x7FFE82E40880
        public void GetClanChatMessage(){} // RVA: 0x7FFE82E40930
        public void _GetFriendMessage(){} // RVA: 0x7FFE82E409E0
        public void GetFriendMessage(){} // RVA: 0x7FFE82E40A90
    }

    public class ISteamInput : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82E3FA70
        public void SteamAPI_SteamInput_v006(){} // RVA: 0x7FFE82E40B40
        public void GetUserInterfacePointer(){} // RVA: 0x7FFE82E40B40
    }

    public class ISteamInventory : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82E3FA70
        public void SteamAPI_SteamInventory_v003(){} // RVA: 0x7FFE82E40BB0
        public void GetUserInterfacePointer(){} // RVA: 0x7FFE82E40BB0
        public void SteamAPI_SteamGameServerInventory_v003(){} // RVA: 0x7FFE82E40C20
        public void GetServerInterfacePointer(){} // RVA: 0x7FFE82E40C20
        public void _GetResultItems(){} // RVA: 0x7FFE82E40C90
        public void GetResultItems(){} // RVA: 0x7FFE82E40D40
        public void _GetResultItemProperty(){} // RVA: 0x7FFE82E40DF0
        public void GetResultItemProperty(){} // RVA: 0x7FFE82E40EE0
        public void _DestroyResult(){} // RVA: 0x7FFE82E411E0
        public void DestroyResult(){} // RVA: 0x7FFE82E41270
        public void _GetItemDefinitionIDs(){} // RVA: 0x7FFE82E41300
        public void GetItemDefinitionIDs(){} // RVA: 0x7FFE82E413B0
    }

    public class ISteamMatchmaking : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82E3FA70
        public void SteamAPI_SteamMatchmaking_v009(){} // RVA: 0x7FFE82E41460
        public void GetUserInterfacePointer(){} // RVA: 0x7FFE82E41460
        public void _GetLobbyChatEntry(){} // RVA: 0x7FFE82E414D0
        public void GetLobbyChatEntry(){} // RVA: 0x7FFE82E41580
    }

    public class ISteamMatchmakingServers : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82E3FA70
        public void SteamAPI_SteamMatchmakingServers_v002(){} // RVA: 0x7FFE82E41630
        public void GetUserInterfacePointer(){} // RVA: 0x7FFE82E41630
    }

    public class ISteamMusic : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82E3FA70
        public void SteamAPI_SteamMusic_v001(){} // RVA: 0x7FFE82E416A0
        public void GetUserInterfacePointer(){} // RVA: 0x7FFE82E416A0
    }

    public class ISteamNetworking : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82E3FA70
        public void SteamAPI_SteamNetworking_v006(){} // RVA: 0x7FFE82E41710
        public void GetUserInterfacePointer(){} // RVA: 0x7FFE82E41710
        public void SteamAPI_SteamGameServerNetworking_v006(){} // RVA: 0x7FFE82E41780
        public void GetServerInterfacePointer(){} // RVA: 0x7FFE82E41780
    }

    public class ISteamNetworkingSockets : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82E3FA70
        public void SteamAPI_SteamNetworkingSockets_SteamAPI_v012(){} // RVA: 0x7FFE82E417F0
        public void GetUserInterfacePointer(){} // RVA: 0x7FFE82E417F0
        public void SteamAPI_SteamGameServerNetworkingSockets_SteamAPI_v012(){} // RVA: 0x7FFE82E41860
        public void GetServerInterfacePointer(){} // RVA: 0x7FFE82E41860
        public void _AcceptConnection(){} // RVA: 0x7FFE82E418D0
        public void AcceptConnection(){} // RVA: 0x7FFE82E41960
        public void _CloseConnection(){} // RVA: 0x7FFE82E419F0
        public void CloseConnection(){} // RVA: 0x7FFE82E41AD0
        public void _SetConnectionPollGroup(){} // RVA: 0x7FFE82E41BB0
        public void SetConnectionPollGroup(){} // RVA: 0x7FFE82E41C50
    }

    public class ISteamNetworkingUtils : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82E3FA70
        public void SteamAPI_SteamNetworkingUtils_SteamAPI_v004(){} // RVA: 0x7FFE82E41CF0
        public void GetGlobalInterfacePointer(){} // RVA: 0x7FFE82E41CF0
        public void _SteamNetworkingIdentity_ToString(){} // RVA: 0x7FFE82E41D60
        public void SteamNetworkingIdentity_ToString(){} // RVA: 0x7FFE82E41E10
    }

    public class ISteamParentalSettings : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82E3FA70
        public void SteamAPI_SteamParentalSettings_v001(){} // RVA: 0x7FFE82E420A0
        public void GetUserInterfacePointer(){} // RVA: 0x7FFE82E420A0
    }

    public class ISteamParties : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82E3FA70
        public void SteamAPI_SteamParties_v002(){} // RVA: 0x7FFE82E42110
        public void GetUserInterfacePointer(){} // RVA: 0x7FFE82E42110
    }

    public class ISteamRemotePlay : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82E3FA70
        public void SteamAPI_SteamRemotePlay_v001(){} // RVA: 0x7FFE82E42180
        public void GetUserInterfacePointer(){} // RVA: 0x7FFE82E42180
    }

    public class ISteamRemoteStorage : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82E3FA70
        public void SteamAPI_SteamRemoteStorage_v016(){} // RVA: 0x7FFE82E421F0
        public void GetUserInterfacePointer(){} // RVA: 0x7FFE82E421F0
    }

    public class ISteamScreenshots : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82E3FA70
        public void SteamAPI_SteamScreenshots_v003(){} // RVA: 0x7FFE82E42260
        public void GetUserInterfacePointer(){} // RVA: 0x7FFE82E42260
    }

    public class ISteamUGC : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82E3FA70
        public void SteamAPI_SteamUGC_v016(){} // RVA: 0x7FFE82E422D0
        public void GetUserInterfacePointer(){} // RVA: 0x7FFE82E422D0
        public void SteamAPI_SteamGameServerUGC_v016(){} // RVA: 0x7FFE82E42340
        public void GetServerInterfacePointer(){} // RVA: 0x7FFE82E42340
    }

    public class ISteamUser : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82E3FA70
        public void SteamAPI_SteamUser_v021(){} // RVA: 0x7FFE82E423B0
        public void GetUserInterfacePointer(){} // RVA: 0x7FFE82E423B0
        public void _GetSteamID(){} // RVA: 0x7FFE82E42420
        public void GetSteamID(){} // RVA: 0x7FFE82E424A0
        public void _GetVoiceOptimalSampleRate(){} // RVA: 0x7FFE82E42520
        public void GetVoiceOptimalSampleRate(){} // RVA: 0x7FFE82E425A0
        public void _GetAuthSessionTicket(){} // RVA: 0x7FFE82E42620
        public void GetAuthSessionTicket(){} // RVA: 0x7FFE82E426D0
        public void _CancelAuthTicket(){} // RVA: 0x7FFE82E42780
        public void CancelAuthTicket(){} // RVA: 0x7FFE82E42810
    }

    public class ISteamUserStats : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82E3FA70
        public void SteamAPI_SteamUserStats_v012(){} // RVA: 0x7FFE82E428A0
        public void GetUserInterfacePointer(){} // RVA: 0x7FFE82E428A0
        public void _RequestCurrentStats(){} // RVA: 0x7FFE82E42910
        public void RequestCurrentStats(){} // RVA: 0x7FFE82E42990
    }

    public class ISteamUtils : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82E3FA70
        public void SteamAPI_SteamUtils_v010(){} // RVA: 0x7FFE82E42A10
        public void GetUserInterfacePointer(){} // RVA: 0x7FFE82E42A10
        public void SteamAPI_SteamGameServerUtils_v010(){} // RVA: 0x7FFE82E42A80
        public void GetServerInterfacePointer(){} // RVA: 0x7FFE82E42A80
        public void _IsSteamRunningOnSteamDeck(){} // RVA: 0x7FFE82E42AF0
        public void IsSteamRunningOnSteamDeck(){} // RVA: 0x7FFE82E42B70
    }

    public class ISteamVideo : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82E3FA70
        public void SteamAPI_SteamVideo_v002(){} // RVA: 0x7FFE82E42BF0
        public void GetUserInterfacePointer(){} // RVA: 0x7FFE82E42BF0
    }

    public class InventoryDef : Object
    {
        public Steamworks.Data.InventoryDefId _id; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void get_Id(){} // RVA: 0x7FFE811485C0
        public void op_Equality(){} // RVA: 0x7FFE82E53760
        public void Equals(){} // RVA: 0x7FFE82E53820 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE811485C0
    }

    public class InventoryItem : ValueType
    {
        // ── Methods ──
        public void From(){} // RVA: 0x7FFE82E53870
        public void GetProperties(){} // RVA: 0x7FFE82E538A0
        public void Equals(){} // RVA: 0x7FFE82E53BD0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE82E53BC0
    }

    public class InventoryResult : ValueType
    {
        public Steamworks.Data.SteamInventoryResult_t _id; // 0x10
        public bool _expired; // 0x14

        // ── Methods ──
        public void set_Expired(){} // RVA: 0x7FFE81E63F40
        public void .ctor(){} // RVA: 0x7FFE815BF9A0
        public void get_ItemCount(){} // RVA: 0x7FFE82E53BE0
        public void GetItems(){} // RVA: 0x7FFE82E53CA0
        public void Dispose(){} // RVA: 0x7FFE82E53F60
    }

    public class PreserveAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class SocketManager : Object
    {
        public Steamworks.ISocketManager _interface; // 0x10

        // ── Methods ──
        public void get_Interface(){} // RVA: 0x7FFE81116380
        public void OnConnectionChanged(){} // RVA: 0x7FFE82E43340
        public void OnConnecting(){} // RVA: 0x7FFE82E43710
        public void OnConnected(){} // RVA: 0x7FFE82E43830
        public void OnDisconnected(){} // RVA: 0x7FFE82E43A00
    }

    public class SteamAPI : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE82E3ADF0
        public void Shutdown(){} // RVA: 0x7FFE82E3AE60
        public void GetHSteamPipe(){} // RVA: 0x7FFE82E3AED0
        public void RestartAppIfNecessary(){} // RVA: 0x7FFE82E3AF40
    }

    public class SteamApps : SteamSharedClass`1
    {
        public System.Action OnNewLaunchParameters;
        public object field_1; // 0x2F78
        public object field_2; // 0x3130

        // ── Methods ──
        public void get_Internal(){} // RVA: 0x7FFE82E43B50
        public void InitializeInterface(){} // RVA: 0x7FFE82E43BF0
        public void add_OnNewLaunchParameters(){} // RVA: 0x7FFE82E43C80
        public void remove_OnNewLaunchParameters(){} // RVA: 0x7FFE82E43D90
        public void get_CurrentBetaName(){} // RVA: 0x7FFE82E43EA0
        public void GetLaunchParam(){} // RVA: 0x7FFE82E43EE0
        public void get_CommandLine(){} // RVA: 0x7FFE82E43FB0
        public void .ctor(){} // RVA: 0x7FFE82E43FF0
    }

    public class SteamClass : Object
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7FFE80E466C0
        public void DestroyInterface(){} // RVA: 0x7FFE80E466C0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class SteamClient : Object
    {
        public bool initialized;
        public System.Collections.Generic.List`1<Steamworks.SteamClass> openInterfaces; // 0x8
        public Steamworks.AppId _appId; // 0x10
        public uint Value; // 0x10

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE82E44020
        public void AddInterface(){} // RVA: 0x7FFE80E46010
        public void ShutdownInterfaces(){} // RVA: 0x7FFE82E44710
        public void get_IsValid(){} // RVA: 0x7FFE82E44900
        public void Shutdown(){} // RVA: 0x7FFE82E44960
        public void Cleanup(){} // RVA: 0x7FFE82E44A70
        public void get_SteamId(){} // RVA: 0x7FFE82E44B00
        public void get_Name(){} // RVA: 0x7FFE82E44BD0
        public void set_AppId(){} // RVA: 0x7FFE82E44C70
        public void RestartAppIfNecessary(){} // RVA: 0x7FFE82E3AF40
        public void .cctor(){} // RVA: 0x7FFE82E44CD0
    }

    public class SteamClientClass`1 : SteamClass
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7FFE80E466C0
        public void SetInterface(){} // RVA: 0x7FFE80E46BE0
        public void DestroyInterface(){} // RVA: 0x7FFE80E466C0
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class SteamFriends : SteamClientClass`1
    {
        public System.Collections.Generic.Dictionary`2<string,string> richPresence;

        // ── Methods ──
        public void get_Internal(){} // RVA: 0x7FFE82E44DB0
        public void InitializeInterface(){} // RVA: 0x7FFE82E44E50
        public void InstallEvents(){} // RVA: 0x7FFE82E44F90
        public void OnFriendChatMessage(){} // RVA: 0x7FFE82E46020
        public void OnGameConnectedClanChatMessage(){} // RVA: 0x7FFE82E463A0
        public void SetRichPresence(){} // RVA: 0x7FFE82E46750
        public void ClearRichPresence(){} // RVA: 0x7FFE82E468E0
        public void .ctor(){} // RVA: 0x7FFE82E469D0
    }

    public class SteamId : ValueType
    {
        // ── Methods ──
        public void op_Implicit(){} // RVA: 0x7FFE827C4A80 | overloaded x2
        public void ToString(){} // RVA: 0x7FFE82E54010
    }

    public class SteamInput : SteamClientClass`1
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7FFE82E46E20
        public void .ctor(){} // RVA: 0x7FFE82E46EB0
        public void .cctor(){} // RVA: 0x7FFE82E46EE0
    }

    public class SteamInterface : Object
    {
        public UIntPtr Self; // 0x10

        // ── Methods ──
        public void GetUserInterfacePointer(){} // RVA: 0x7FFE813240E0
        public void GetServerInterfacePointer(){} // RVA: 0x7FFE813240E0
        public void GetGlobalInterfacePointer(){} // RVA: 0x7FFE813240E0
        public void set_IsServer(){} // RVA: 0x7FFE81121460
        public void SetupInterface(){} // RVA: 0x7FFE82E54D70
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class SteamInventory : SteamSharedClass`1
    {
        public System.Action`1<Steamworks.InventoryResult> OnInventoryUpdated;
        public System.Action OnDefinitionsUpdated; // 0x8
        public Steamworks.InventoryItem[] _items; // 0x10

        // ── Methods ──
        public void get_Internal(){} // RVA: 0x7FFE82E47320
        public void InitializeInterface(){} // RVA: 0x7FFE82E473C0
        public void InstallEvents(){} // RVA: 0x7FFE82E47450
        public void InventoryUpdated(){} // RVA: 0x7FFE82E478A0
        public void LoadDefinitions(){} // RVA: 0x7FFE82E479B0
        public void set_Items(){} // RVA: 0x7FFE82E47C50
        public void get_Definitions(){} // RVA: 0x7FFE82E47CF0
        public void set_Definitions(){} // RVA: 0x7FFE82E47D30
        public void GetDefinitions(){} // RVA: 0x7FFE82E47DD0
        public void .ctor(){} // RVA: 0x7FFE82E480D0
    }

    public class SteamMatchmaking : SteamClientClass`1
    {
        public System.Action`2<Steamworks.Friend,Steamworks.Data.Lobby> OnLobbyInvite;

        // ── Methods ──
        public void get_Internal(){} // RVA: 0x7FFE82E48300
        public void InitializeInterface(){} // RVA: 0x7FFE82E483A0
        public void InstallEvents(){} // RVA: 0x7FFE82E48430
        public void OnLobbyChatMessageRecievedAPI(){} // RVA: 0x7FFE82E491A0
        public void .ctor(){} // RVA: 0x7FFE82E49560
    }

    public class SteamMatchmakingServers : SteamClientClass`1
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7FFE82E49A00
        public void .ctor(){} // RVA: 0x7FFE82E49A90
    }

    public class SteamMusic : SteamClientClass`1
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7FFE82E49AC0
        public void InstallEvents(){} // RVA: 0x7FFE82E49B50
        public void .ctor(){} // RVA: 0x7FFE82E49FC0
    }

    public class SteamNetworking : SteamSharedClass`1
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7FFE82E4A150
        public void InstallEvents(){} // RVA: 0x7FFE82E4A1E0
        public void .ctor(){} // RVA: 0x7FFE82E4A630
    }

    public class SteamNetworkingSockets : SteamSharedClass`1
    {
        public System.Collections.Generic.Dictionary`2<uint,Steamworks.SocketManager> SocketInterfaces;

        // ── Methods ──
        public void get_Internal(){} // RVA: 0x7FFE82E4A7D0
        public void InitializeInterface(){} // RVA: 0x7FFE82E4A870
        public void GetSocketManager(){} // RVA: 0x7FFE82E4A900
        public void GetConnectionManager(){} // RVA: 0x7FFE82E4AA20
        public void InstallEvents(){} // RVA: 0x7FFE82E4AB00
        public void ConnectionStatusChanged(){} // RVA: 0x7FFE82E4AD90
        public void FakeIPResult(){} // RVA: 0x7FFE82E4B610
        public void .ctor(){} // RVA: 0x7FFE82E4B790
        public void .cctor(){} // RVA: 0x7FFE82E4B7C0
    }

    public class SteamNetworkingUtils : SteamSharedClass`1
    {
        public System.Action`2<0x66687ACC,string> OnDebugOutput;
        public 0x66687A1C _status; // 0x8

        // ── Methods ──
        public void get_Internal(){} // RVA: 0x7FFE82E4B960
        public void InitializeInterface(){} // RVA: 0x7FFE82E4BA00
        public void InstallCallbacks(){} // RVA: 0x7FFE82E4BAC0
        public void set_Status(){} // RVA: 0x7FFE82E4BD10
        public void OutputDebugMessages(){} // RVA: 0x7FFE82E4BD70
        public void .ctor(){} // RVA: 0x7FFE82E4BFA0
        public void .cctor(){} // RVA: 0x7FFE82E4BFD0
    }

    public class SteamParental : SteamSharedClass`1
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7FFE82E4C390
        public void InstallEvents(){} // RVA: 0x7FFE82E4C420
        public void .ctor(){} // RVA: 0x7FFE82E4C670
    }

    public class SteamParties : SteamClientClass`1
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7FFE82E4C7A0
        public void InstallEvents(){} // RVA: 0x7FFE82E4C830
        public void .ctor(){} // RVA: 0x7FFE82E4CC80
    }

    public class SteamRemotePlay : SteamClientClass`1
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7FFE82E4CE10
        public void InstallEvents(){} // RVA: 0x7FFE82E4CEA0
        public void .ctor(){} // RVA: 0x7FFE82E4D2F0
    }

    public class SteamRemoteStorage : SteamClientClass`1
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7FFE82E4D480
        public void .ctor(){} // RVA: 0x7FFE82E4D510
    }

    public class SteamScreenshots : SteamClientClass`1
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7FFE82E4D540
        public void InstallEvents(){} // RVA: 0x7FFE82E4D5D0
        public void .ctor(){} // RVA: 0x7FFE82E4DA40
    }

    public class SteamSharedClass`1 : SteamClass
    {
        public Steamworks.SteamInterface InterfaceClient;

        // ── Methods ──
        public void get_Interface(){} // RVA: 0x7FFE80E2DEE0
        public void InitializeInterface(){} // RVA: 0x7FFE80E466C0
        public void SetInterface(){} // RVA: 0x7FFE80E46BE0
        public void DestroyInterface(){} // RVA: 0x7FFE80E466C0
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class SteamUGC : SteamSharedClass`1
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7FFE82E4DBF0
        public void InstallEvents(){} // RVA: 0x7FFE82E4DC80
        public void .ctor(){} // RVA: 0x7FFE82E4E4D0
    }

    public class SteamUser : SteamClientClass`1
    {
        public System.Collections.Generic.Dictionary`2<string,string> richPresence;
        public System.Action OnSteamServersConnected; // 0x8
        public System.Action OnSteamServerConnectFailure; // 0x10

        // ── Methods ──
        public void get_Internal(){} // RVA: 0x7FFE82E4E760
        public void InitializeInterface(){} // RVA: 0x7FFE82E4E800
        public void InstallEvents(){} // RVA: 0x7FFE82E4EB70
        public void add_OnMicroTxnAuthorizationResponse(){} // RVA: 0x7FFE82E4FFB0
        public void remove_OnMicroTxnAuthorizationResponse(){} // RVA: 0x7FFE82E50110
        public void get_SampleRate(){} // RVA: 0x7FFE82E50270
        public void set_SampleRate(){} // RVA: 0x7FFE82E502D0
        public void get_OptimalSampleRate(){} // RVA: 0x7FFE82E50440
        public void GetAuthSessionTicket(){} // RVA: 0x7FFE82E50510
        public void .ctor(){} // RVA: 0x7FFE82E50860
        public void .cctor(){} // RVA: 0x7FFE82E50890
    }

    public class SteamUserStats : SteamClientClass`1
    {
        public bool _statsRecieved;
        public System.Action`2<string,int> OnAchievementIconFetched; // 0x8

        // ── Methods ──
        public void get_Internal(){} // RVA: 0x7FFE82E50F30
        public void InitializeInterface(){} // RVA: 0x7FFE82E50FD0
        public void set_StatsRecieved(){} // RVA: 0x7FFE82E51160
        public void InstallEvents(){} // RVA: 0x7FFE82E511A0
        public void RequestCurrentStats(){} // RVA: 0x7FFE82E51BF0
        public void .ctor(){} // RVA: 0x7FFE82E51D10
    }

    public class SteamUtils : SteamSharedClass`1
    {
        public System.Action OnIpCountryChanged;
        public System.Action`1<int> OnLowBatteryPower; // 0x8

        // ── Methods ──
        public void get_Internal(){} // RVA: 0x7FFE82E52140
        public void InitializeInterface(){} // RVA: 0x7FFE82E521E0
        public void InstallEvents(){} // RVA: 0x7FFE82E522A0
        public void SteamClosed(){} // RVA: 0x7FFE82E52CF0
        public void add_OnAppResumingFromSuspend(){} // RVA: 0x7FFE82E52D90
        public void remove_OnAppResumingFromSuspend(){} // RVA: 0x7FFE82E52EE0
        public void get_IsRunningOnSteamDeck(){} // RVA: 0x7FFE82E53030
        public void .ctor(){} // RVA: 0x7FFE82E53180
        public void .cctor(){} // RVA: 0x7FFE82E531B0
    }

    public class SteamVideo : SteamClientClass`1
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7FFE82E53540
        public void InstallEvents(){} // RVA: 0x7FFE810FB310
        public void .ctor(){} // RVA: 0x7FFE82E535D0
    }

    public class Utf8StringPointer : ValueType
    {
        // ── Methods ──
        public void op_Implicit(){} // RVA: 0x7FFE82E55080
    }

    public class Utf8StringToNative : Object
    {
        // ── Methods ──
        public void MarshalManagedToNative(){} // RVA: 0x7FFE82E54E00
        public void MarshalNativeToManaged(){} // RVA: 0x7FFE82E54F70
        public void CleanUpNativeData(){} // RVA: 0x7FFE82E54FB0
        public void CleanUpManagedData(){} // RVA: 0x7FFE82E55000
        public void GetNativeDataSize(){} // RVA: 0x7FFE81517DA0
        public void GetInstance(){} // RVA: 0x7FFE82E55040
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Utility : Object
    {
        // ── Methods ──
        public void ToType(){} // RVA: 0x7FFE82E55120 | overloaded x2
        public void Swap(){} // RVA: 0x7FFE82E55190
        public void IpToInt32(){} // RVA: 0x7FFE82E551A0
        public void Int32ToIp(){} // RVA: 0x7FFE82E55240
        public void .cctor(){} // RVA: 0x7FFE82E552C0
    }

}