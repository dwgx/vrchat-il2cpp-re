// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Steamworks
// Classes: 65
// Methods: 336

namespace ThirdParty.Other.Steamworks
{
    public class AppId : ValueType
    {
        public uint Value; // 0x10

        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFAC4BE6C00
        public void op_Implicit(){} // RVA: 0x7FFAC4BE6C10
    }

    public class AuthTicket : Object
    {
        public byte[] Data; // 0x10
        public uint Handle; // 0x18

        // ── Methods ──
        public void Cancel(){} // RVA: 0x7FFAC4BCB760
        public void Dispose(){} // RVA: 0x7FFAC4BCB8A0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class CallbackTypeFactory : Object
    {
        public System.Collections.Generic.Dictionary`2<0x6B28CE70,System.Type> All;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC4BCE5C0
    }

    public class ConnectionManager : Object
    {
        public Steamworks.IConnectionManager Interface; // 0x10
        public Steamworks.Data.ConnectionInfo ConnectionInfo; // 0x18
        public bool Connected; // 0x2D0
        public bool Connecting; // 0x2D1

        // ── Methods ──
        public void get_Interface(){} // RVA: 0x7FFAC2F3C380
        public void set_ConnectionInfo(){} // RVA: 0x7FFAC4BD6260
        public void OnConnectionChanged(){} // RVA: 0x7FFAC4BD6340
        public void OnConnecting(){} // RVA: 0x7FFAC4BD6680
        public void OnConnected(){} // RVA: 0x7FFAC4BD6760
        public void OnDisconnected(){} // RVA: 0x7FFAC4BD6850
    }

    public class Dispatch : Object
    {
        public System.Action`3<0x6B28CE70,string,bool> ClientPipe;
        public System.Action`1<System.Exception> ServerPipe; // 0x8
        public Steamworks.Data.HSteamPipe <ClientPipe>k__BackingField; // 0x10
        public Steamworks.Data.HSteamPipe <ServerPipe>k__BackingField; // 0x14
        public bool runningFrame; // 0x18
        public System.Collections.Generic.List`1<System.Action`1<UIntPtr>> actionsToCall; // 0x20
        public System.Collections.Generic.Dictionary`2<ulong,ResultCallback> ResultCallbacks; // 0x28
        public System.Collections.Generic.Dictionary`2<0x6B28CE70,System.Collections.Generic.List`1<Callback>> Callbacks; // 0x30

        // ── Methods ──
        public void SteamAPI_ManualDispatch_Init(){} // RVA: 0x7FFAC4BCB8B0
        public void SteamAPI_ManualDispatch_RunFrame(){} // RVA: 0x7FFAC4BCB920
        public void SteamAPI_ManualDispatch_GetNextCallback(){} // RVA: 0x7FFAC4BCB9A0
        public void SteamAPI_ManualDispatch_FreeLastCallback(){} // RVA: 0x7FFAC4BCBA30
        public void get_ClientPipe(){} // RVA: 0x7FFAC4BCBAB0
        public void set_ClientPipe(){} // RVA: 0x7FFAC4BCBB10
        public void get_ServerPipe(){} // RVA: 0x7FFAC4BCBB70
        public void Init(){} // RVA: 0x7FFAC4BCBBD0
        public void Frame(){} // RVA: 0x7FFAC4BCBC70
        public void ProcessCallback(){} // RVA: 0x7FFAC4BCC0D0
        public void CallbackToString(){} // RVA: 0x7FFAC4BCC690
        public void ProcessResult(){} // RVA: 0x7FFAC4BCCE60
        public void LoopClientAsync(){} // RVA: 0x7FFAC4BCD1A0
        public void Install(){} // RVA: 0x7FFAC2C762E0
        public void ShutdownClient(){} // RVA: 0x7FFAC4BCD2F0
        public void .cctor(){} // RVA: 0x7FFAC4BCDC20
    }

    public class Friend : ValueType
    {
        public Steamworks.SteamId Name; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC45BB120
        public void ToString(){} // RVA: 0x7FFAC4BE6C20
        public void get_Name(){} // RVA: 0x7FFAC4BE6CB0
    }

    public class Helpers : Object
    {
        public byte[][] BufferPool;
        public int BufferPoolIndex; // 0x8

        // ── Methods ──
        public void TakeMemory(){} // RVA: 0x7FFAC4BE7620
        public void TakeBuffer(){} // RVA: 0x7FFAC4BE7670
        public void MemoryToString(){} // RVA: 0x7FFAC4BE7A50
        public void .cctor(){} // RVA: 0x7FFAC4BE7B20
    }

    public class ICallbackData
    {
        public object CallbackType;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC2C59960
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
        public void .ctor(){} // RVA: 0x7FFAC4BD3070
        public void SteamAPI_SteamApps_v008(){} // RVA: 0x7FFAC4BD3080
        public void GetUserInterfacePointer(){} // RVA: 0x7FFAC4BD3080
        public void _GetCurrentBetaName(){} // RVA: 0x7FFAC4BD30F0
        public void GetCurrentBetaName(){} // RVA: 0x7FFAC4BD3190
        public void _GetLaunchQueryParam(){} // RVA: 0x7FFAC4BD3450
        public void GetLaunchQueryParam(){} // RVA: 0x7FFAC4BD3510
        public void _GetLaunchCommandLine(){} // RVA: 0x7FFAC4BD35D0
        public void GetLaunchCommandLine(){} // RVA: 0x7FFAC4BD3670
    }

    public class ISteamFriends : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC4BD3070
        public void SteamAPI_SteamFriends_v017(){} // RVA: 0x7FFAC4BD3910
        public void GetUserInterfacePointer(){} // RVA: 0x7FFAC4BD3910
        public void _GetPersonaName(){} // RVA: 0x7FFAC4BD3980
        public void GetPersonaName(){} // RVA: 0x7FFAC4BD3A00
        public void _GetFriendPersonaName(){} // RVA: 0x7FFAC4BD3A90
        public void GetFriendPersonaName(){} // RVA: 0x7FFAC4BD3B20
        public void _SetRichPresence(){} // RVA: 0x7FFAC4BD3BC0
        public void SetRichPresence(){} // RVA: 0x7FFAC4BD3CA0
        public void _ClearRichPresence(){} // RVA: 0x7FFAC4BD3D80
        public void ClearRichPresence(){} // RVA: 0x7FFAC4BD3E00
        public void _GetClanChatMessage(){} // RVA: 0x7FFAC4BD3E80
        public void GetClanChatMessage(){} // RVA: 0x7FFAC4BD3F30
        public void _GetFriendMessage(){} // RVA: 0x7FFAC4BD3FE0
        public void GetFriendMessage(){} // RVA: 0x7FFAC4BD4090
    }

    public class ISteamInput : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC4BD3070
        public void SteamAPI_SteamInput_v006(){} // RVA: 0x7FFAC4BD4140
        public void GetUserInterfacePointer(){} // RVA: 0x7FFAC4BD4140
    }

    public class ISteamInventory : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC4BD3070
        public void SteamAPI_SteamInventory_v003(){} // RVA: 0x7FFAC4BD41B0
        public void GetUserInterfacePointer(){} // RVA: 0x7FFAC4BD41B0
        public void SteamAPI_SteamGameServerInventory_v003(){} // RVA: 0x7FFAC4BD4220
        public void GetServerInterfacePointer(){} // RVA: 0x7FFAC4BD4220
        public void _GetResultItems(){} // RVA: 0x7FFAC4BD4290
        public void GetResultItems(){} // RVA: 0x7FFAC4BD4340
        public void _GetResultItemProperty(){} // RVA: 0x7FFAC4BD43F0
        public void GetResultItemProperty(){} // RVA: 0x7FFAC4BD44E0
        public void _DestroyResult(){} // RVA: 0x7FFAC4BD47E0
        public void DestroyResult(){} // RVA: 0x7FFAC4BD4870
        public void _GetItemDefinitionIDs(){} // RVA: 0x7FFAC4BD4900
        public void GetItemDefinitionIDs(){} // RVA: 0x7FFAC4BD49B0
    }

    public class ISteamMatchmaking : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC4BD3070
        public void SteamAPI_SteamMatchmaking_v009(){} // RVA: 0x7FFAC4BD4A60
        public void GetUserInterfacePointer(){} // RVA: 0x7FFAC4BD4A60
        public void _GetLobbyChatEntry(){} // RVA: 0x7FFAC4BD4AD0
        public void GetLobbyChatEntry(){} // RVA: 0x7FFAC4BD4B80
    }

    public class ISteamMatchmakingServers : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC4BD3070
        public void SteamAPI_SteamMatchmakingServers_v002(){} // RVA: 0x7FFAC4BD4C30
        public void GetUserInterfacePointer(){} // RVA: 0x7FFAC4BD4C30
    }

    public class ISteamMusic : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC4BD3070
        public void SteamAPI_SteamMusic_v001(){} // RVA: 0x7FFAC4BD4CA0
        public void GetUserInterfacePointer(){} // RVA: 0x7FFAC4BD4CA0
    }

    public class ISteamNetworking : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC4BD3070
        public void SteamAPI_SteamNetworking_v006(){} // RVA: 0x7FFAC4BD4D10
        public void GetUserInterfacePointer(){} // RVA: 0x7FFAC4BD4D10
        public void SteamAPI_SteamGameServerNetworking_v006(){} // RVA: 0x7FFAC4BD4D80
        public void GetServerInterfacePointer(){} // RVA: 0x7FFAC4BD4D80
    }

    public class ISteamNetworkingSockets : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC4BD3070
        public void SteamAPI_SteamNetworkingSockets_SteamAPI_v012(){} // RVA: 0x7FFAC4BD4DF0
        public void GetUserInterfacePointer(){} // RVA: 0x7FFAC4BD4DF0
        public void SteamAPI_SteamGameServerNetworkingSockets_SteamAPI_v012(){} // RVA: 0x7FFAC4BD4E60
        public void GetServerInterfacePointer(){} // RVA: 0x7FFAC4BD4E60
        public void _AcceptConnection(){} // RVA: 0x7FFAC4BD4ED0
        public void AcceptConnection(){} // RVA: 0x7FFAC4BD4F60
        public void _CloseConnection(){} // RVA: 0x7FFAC4BD4FF0
        public void CloseConnection(){} // RVA: 0x7FFAC4BD50D0
        public void _SetConnectionPollGroup(){} // RVA: 0x7FFAC4BD51B0
        public void SetConnectionPollGroup(){} // RVA: 0x7FFAC4BD5250
    }

    public class ISteamNetworkingUtils : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC4BD3070
        public void SteamAPI_SteamNetworkingUtils_SteamAPI_v004(){} // RVA: 0x7FFAC4BD52F0
        public void GetGlobalInterfacePointer(){} // RVA: 0x7FFAC4BD52F0
        public void _SteamNetworkingIdentity_ToString(){} // RVA: 0x7FFAC4BD5360
        public void SteamNetworkingIdentity_ToString(){} // RVA: 0x7FFAC4BD5410
    }

    public class ISteamParentalSettings : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC4BD3070
        public void SteamAPI_SteamParentalSettings_v001(){} // RVA: 0x7FFAC4BD56A0
        public void GetUserInterfacePointer(){} // RVA: 0x7FFAC4BD56A0
    }

    public class ISteamParties : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC4BD3070
        public void SteamAPI_SteamParties_v002(){} // RVA: 0x7FFAC4BD5710
        public void GetUserInterfacePointer(){} // RVA: 0x7FFAC4BD5710
    }

    public class ISteamRemotePlay : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC4BD3070
        public void SteamAPI_SteamRemotePlay_v001(){} // RVA: 0x7FFAC4BD5780
        public void GetUserInterfacePointer(){} // RVA: 0x7FFAC4BD5780
    }

    public class ISteamRemoteStorage : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC4BD3070
        public void SteamAPI_SteamRemoteStorage_v016(){} // RVA: 0x7FFAC4BD57F0
        public void GetUserInterfacePointer(){} // RVA: 0x7FFAC4BD57F0
    }

    public class ISteamScreenshots : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC4BD3070
        public void SteamAPI_SteamScreenshots_v003(){} // RVA: 0x7FFAC4BD5860
        public void GetUserInterfacePointer(){} // RVA: 0x7FFAC4BD5860
    }

    public class ISteamUGC : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC4BD3070
        public void SteamAPI_SteamUGC_v016(){} // RVA: 0x7FFAC4BD58D0
        public void GetUserInterfacePointer(){} // RVA: 0x7FFAC4BD58D0
        public void SteamAPI_SteamGameServerUGC_v016(){} // RVA: 0x7FFAC4BD5940
        public void GetServerInterfacePointer(){} // RVA: 0x7FFAC4BD5940
    }

    public class ISteamUser : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC4BD3070
        public void SteamAPI_SteamUser_v021(){} // RVA: 0x7FFAC4BD59B0
        public void GetUserInterfacePointer(){} // RVA: 0x7FFAC4BD59B0
        public void _GetSteamID(){} // RVA: 0x7FFAC4BD5A20
        public void GetSteamID(){} // RVA: 0x7FFAC4BD5AA0
        public void _GetVoiceOptimalSampleRate(){} // RVA: 0x7FFAC4BD5B20
        public void GetVoiceOptimalSampleRate(){} // RVA: 0x7FFAC4BD5BA0
        public void _GetAuthSessionTicket(){} // RVA: 0x7FFAC4BD5C20
        public void GetAuthSessionTicket(){} // RVA: 0x7FFAC4BD5CD0
        public void _CancelAuthTicket(){} // RVA: 0x7FFAC4BD5D80
        public void CancelAuthTicket(){} // RVA: 0x7FFAC4BD5E10
    }

    public class ISteamUserStats : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC4BD3070
        public void SteamAPI_SteamUserStats_v012(){} // RVA: 0x7FFAC4BD5EA0
        public void GetUserInterfacePointer(){} // RVA: 0x7FFAC4BD5EA0
        public void _RequestCurrentStats(){} // RVA: 0x7FFAC4BD5F10
        public void RequestCurrentStats(){} // RVA: 0x7FFAC4BD5F90
    }

    public class ISteamUtils : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC4BD3070
        public void SteamAPI_SteamUtils_v010(){} // RVA: 0x7FFAC4BD6010
        public void GetUserInterfacePointer(){} // RVA: 0x7FFAC4BD6010
        public void SteamAPI_SteamGameServerUtils_v010(){} // RVA: 0x7FFAC4BD6080
        public void GetServerInterfacePointer(){} // RVA: 0x7FFAC4BD6080
        public void _IsSteamRunningOnSteamDeck(){} // RVA: 0x7FFAC4BD60F0
        public void IsSteamRunningOnSteamDeck(){} // RVA: 0x7FFAC4BD6170
    }

    public class ISteamVideo : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC4BD3070
        public void SteamAPI_SteamVideo_v002(){} // RVA: 0x7FFAC4BD61F0
        public void GetUserInterfacePointer(){} // RVA: 0x7FFAC4BD61F0
    }

    public class InventoryDef : Object
    {
        public Steamworks.Data.InventoryDefId Id; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F240C0
        public void get_Id(){} // RVA: 0x7FFAC2F6E5C0
        public void op_Equality(){} // RVA: 0x7FFAC4BE6D60
        public void Equals(){} // RVA: 0x7FFAC4BE6E20 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC2F6E5C0
    }

    public class InventoryItem : ValueType
    {
        public Steamworks.Data.InventoryItemId _id; // 0x10
        public Steamworks.Data.InventoryDefId _def; // 0x18
        public 0x6B28DBD8 _flags; // 0x1C
        public ushort _quantity; // 0x20
        public System.Collections.Generic.Dictionary`2<string,string> _properties; // 0x28

        // ── Methods ──
        public void From(){} // RVA: 0x7FFAC4BE6E70
        public void GetProperties(){} // RVA: 0x7FFAC4BE6EA0
        public void Equals(){} // RVA: 0x7FFAC4BE71D0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC4BE71C0
    }

    public class InventoryResult : ValueType
    {
        public Steamworks.Data.SteamInventoryResult_t Expired; // 0x10
        public bool ItemCount; // 0x14

        // ── Methods ──
        public void set_Expired(){} // RVA: 0x7FFAC3B9B960
        public void .ctor(){} // RVA: 0x7FFAC336D8C0
        public void get_ItemCount(){} // RVA: 0x7FFAC4BE71E0
        public void GetItems(){} // RVA: 0x7FFAC4BE72A0
        public void Dispose(){} // RVA: 0x7FFAC4BE7560
    }

    public class PreserveAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class SocketManager : Object
    {
        public Steamworks.ISocketManager Interface; // 0x10
        public System.Collections.Generic.HashSet`1<Steamworks.Data.Connection> Connecting; // 0x18
        public System.Collections.Generic.HashSet`1<Steamworks.Data.Connection> Connected; // 0x20
        public Steamworks.Data.HSteamNetPollGroup pollGroup; // 0x28

        // ── Methods ──
        public void get_Interface(){} // RVA: 0x7FFAC2F3C380
        public void OnConnectionChanged(){} // RVA: 0x7FFAC4BD6940
        public void OnConnecting(){} // RVA: 0x7FFAC4BD6D10
        public void OnConnected(){} // RVA: 0x7FFAC4BD6E30
        public void OnDisconnected(){} // RVA: 0x7FFAC4BD7000
    }

    public class SteamAPI : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAC4BCE3F0
        public void Shutdown(){} // RVA: 0x7FFAC4BCE460
        public void GetHSteamPipe(){} // RVA: 0x7FFAC4BCE4D0
        public void RestartAppIfNecessary(){} // RVA: 0x7FFAC4BCE540
    }

    public class SteamApps : SteamSharedClass`1
    {
        public System.Action Internal;

        // ── Methods ──
        public void get_Internal(){} // RVA: 0x7FFAC4BD7150
        public void InitializeInterface(){} // RVA: 0x7FFAC4BD71F0
        public void add_OnNewLaunchParameters(){} // RVA: 0x7FFAC4BD7280
        public void remove_OnNewLaunchParameters(){} // RVA: 0x7FFAC4BD7390
        public void get_CurrentBetaName(){} // RVA: 0x7FFAC4BD74A0
        public void GetLaunchParam(){} // RVA: 0x7FFAC4BD74E0
        public void get_CommandLine(){} // RVA: 0x7FFAC4BD75B0
        public void .ctor(){} // RVA: 0x7FFAC4BD75F0
    }

    public class SteamClass : Object
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7FFAC2C71060
        public void DestroyInterface(){} // RVA: 0x7FFAC2C71060
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class SteamClient : Object
    {
        public bool IsValid;
        public System.Collections.Generic.List`1<Steamworks.SteamClass> SteamId; // 0x8
        public Steamworks.AppId Name; // 0x10

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAC4BD7620
        public void AddInterface(){} // RVA: 0x7FFAC2C709B0
        public void ShutdownInterfaces(){} // RVA: 0x7FFAC4BD7D10
        public void get_IsValid(){} // RVA: 0x7FFAC4BD7F00
        public void Shutdown(){} // RVA: 0x7FFAC4BD7F60
        public void Cleanup(){} // RVA: 0x7FFAC4BD8070
        public void get_SteamId(){} // RVA: 0x7FFAC4BD8100
        public void get_Name(){} // RVA: 0x7FFAC4BD81D0
        public void set_AppId(){} // RVA: 0x7FFAC4BD8270
        public void RestartAppIfNecessary(){} // RVA: 0x7FFAC4BCE540
        public void .cctor(){} // RVA: 0x7FFAC4BD82D0
    }

    public class SteamClientClass`1 : SteamClass
    {
        public Steamworks.SteamInterface Interface;

        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7FFAC2C71060
        public void SetInterface(){} // RVA: 0x7FFAC2C71580
        public void DestroyInterface(){} // RVA: 0x7FFAC2C71060
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class SteamFriends : SteamClientClass`1
    {
        public System.Collections.Generic.Dictionary`2<string,string> Internal;
        public System.Action`3<Steamworks.Friend,string,string> OnChatMessage; // 0x8
        public System.Action`3<Steamworks.Friend,string,string> OnClanChatMessage; // 0x10
        public System.Action`1<Steamworks.Friend> OnPersonaStateChange; // 0x18
        public System.Action`2<Steamworks.Friend,string> OnGameRichPresenceJoinRequested; // 0x20
        public System.Action`1<bool> OnGameOverlayActivated; // 0x28
        public System.Action`2<string,string> OnGameServerChangeRequested; // 0x30
        public System.Action`2<Steamworks.Data.Lobby,Steamworks.SteamId> OnGameLobbyJoinRequested; // 0x38
        public System.Action`1<Steamworks.Friend> OnFriendRichPresenceUpdate; // 0x40
        public System.Action`1<string> OnOverlayBrowserProtocol; // 0x48

        // ── Methods ──
        public void get_Internal(){} // RVA: 0x7FFAC4BD83B0
        public void InitializeInterface(){} // RVA: 0x7FFAC4BD8450
        public void InstallEvents(){} // RVA: 0x7FFAC4BD8590
        public void OnFriendChatMessage(){} // RVA: 0x7FFAC4BD9620
        public void OnGameConnectedClanChatMessage(){} // RVA: 0x7FFAC4BD99A0
        public void SetRichPresence(){} // RVA: 0x7FFAC4BD9D50
        public void ClearRichPresence(){} // RVA: 0x7FFAC4BD9EE0
        public void .ctor(){} // RVA: 0x7FFAC4BD9FD0
    }

    public class SteamId : ValueType
    {
        public ulong Value; // 0x10

        // ── Methods ──
        public void op_Implicit(){} // RVA: 0x7FFAC44F81E0 | overloaded x2
        public void ToString(){} // RVA: 0x7FFAC4BE7610
    }

    public class SteamInput : SteamClientClass`1
    {
        public Steamworks.Data.InputHandle_t[] queryArray;
        public System.Collections.Generic.Dictionary`2<string,Steamworks.Data.InputDigitalActionHandle_t> DigitalHandles; // 0x8
        public System.Collections.Generic.Dictionary`2<string,Steamworks.Data.InputAnalogActionHandle_t> AnalogHandles; // 0x10
        public System.Collections.Generic.Dictionary`2<string,Steamworks.Data.InputActionSetHandle_t> ActionSets; // 0x18

        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7FFAC4BDA420
        public void .ctor(){} // RVA: 0x7FFAC4BDA4B0
        public void .cctor(){} // RVA: 0x7FFAC4BDA4E0
    }

    public class SteamInterface : Object
    {
        public UIntPtr IsServer; // 0x10
        public UIntPtr SelfGlobal; // 0x18
        public UIntPtr SelfServer; // 0x20
        public UIntPtr SelfClient; // 0x28
        public bool <IsServer>k__BackingField; // 0x30

        // ── Methods ──
        public void GetUserInterfacePointer(){} // RVA: 0x7FFAC34F9180
        public void GetServerInterfacePointer(){} // RVA: 0x7FFAC34F9180
        public void GetGlobalInterfacePointer(){} // RVA: 0x7FFAC34F9180
        public void set_IsServer(){} // RVA: 0x7FFAC2F47460
        public void SetupInterface(){} // RVA: 0x7FFAC4BE8370
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class SteamInventory : SteamSharedClass`1
    {
        public System.Action`1<Steamworks.InventoryResult> Internal;
        public System.Action Items; // 0x8
        public Steamworks.InventoryItem[] Definitions; // 0x10
        public Steamworks.InventoryDef[] <Definitions>k__BackingField; // 0x18
        public System.Collections.Generic.Dictionary`2<int,Steamworks.InventoryDef> _defMap; // 0x20

        // ── Methods ──
        public void get_Internal(){} // RVA: 0x7FFAC4BDA920
        public void InitializeInterface(){} // RVA: 0x7FFAC4BDA9C0
        public void InstallEvents(){} // RVA: 0x7FFAC4BDAA50
        public void InventoryUpdated(){} // RVA: 0x7FFAC4BDAEA0
        public void LoadDefinitions(){} // RVA: 0x7FFAC4BDAFB0
        public void set_Items(){} // RVA: 0x7FFAC4BDB250
        public void get_Definitions(){} // RVA: 0x7FFAC4BDB2F0
        public void set_Definitions(){} // RVA: 0x7FFAC4BDB330
        public void GetDefinitions(){} // RVA: 0x7FFAC4BDB3D0
        public void .ctor(){} // RVA: 0x7FFAC4BDB6D0
    }

    public class SteamMatchmaking : SteamClientClass`1
    {
        public System.Action`2<Steamworks.Friend,Steamworks.Data.Lobby> Internal;
        public System.Action`1<Steamworks.Data.Lobby> OnLobbyEntered; // 0x8
        public System.Action`2<0x6B28D600,Steamworks.Data.Lobby> OnLobbyCreated; // 0x10
        public System.Action`4<Steamworks.Data.Lobby,uint,ushort,Steamworks.SteamId> OnLobbyGameCreated; // 0x18
        public System.Action`1<Steamworks.Data.Lobby> OnLobbyDataChanged; // 0x20
        public System.Action`2<Steamworks.Data.Lobby,Steamworks.Friend> OnLobbyMemberDataChanged; // 0x28
        public System.Action`2<Steamworks.Data.Lobby,Steamworks.Friend> OnLobbyMemberJoined; // 0x30
        public System.Action`2<Steamworks.Data.Lobby,Steamworks.Friend> OnLobbyMemberLeave; // 0x38
        public System.Action`2<Steamworks.Data.Lobby,Steamworks.Friend> OnLobbyMemberDisconnected; // 0x40
        public System.Action`3<Steamworks.Data.Lobby,Steamworks.Friend,Steamworks.Friend> OnLobbyMemberKicked; // 0x48
        public System.Action`3<Steamworks.Data.Lobby,Steamworks.Friend,Steamworks.Friend> OnLobbyMemberBanned; // 0x50
        public System.Action`3<Steamworks.Data.Lobby,Steamworks.Friend,string> OnChatMessage; // 0x58

        // ── Methods ──
        public void get_Internal(){} // RVA: 0x7FFAC4BDB900
        public void InitializeInterface(){} // RVA: 0x7FFAC4BDB9A0
        public void InstallEvents(){} // RVA: 0x7FFAC4BDBA30
        public void OnLobbyChatMessageRecievedAPI(){} // RVA: 0x7FFAC4BDC7A0
        public void .ctor(){} // RVA: 0x7FFAC4BDCB60
    }

    public class SteamMatchmakingServers : SteamClientClass`1
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7FFAC4BDD000
        public void .ctor(){} // RVA: 0x7FFAC4BDD090
    }

    public class SteamMusic : SteamClientClass`1
    {
        public System.Action OnPlaybackChanged;
        public System.Action`1<float> OnVolumeChanged; // 0x8

        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7FFAC4BDD0C0
        public void InstallEvents(){} // RVA: 0x7FFAC4BDD150
        public void .ctor(){} // RVA: 0x7FFAC4BDD5C0
    }

    public class SteamNetworking : SteamSharedClass`1
    {
        public System.Action`1<Steamworks.SteamId> OnP2PSessionRequest;
        public System.Action`2<Steamworks.SteamId,0x6B28DB28> OnP2PConnectionFailed; // 0x8

        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7FFAC4BDD750
        public void InstallEvents(){} // RVA: 0x7FFAC4BDD7E0
        public void .ctor(){} // RVA: 0x7FFAC4BDDC30
    }

    public class SteamNetworkingSockets : SteamSharedClass`1
    {
        public System.Collections.Generic.Dictionary`2<uint,Steamworks.SocketManager> Internal;
        public System.Collections.Generic.Dictionary`2<uint,Steamworks.ConnectionManager> ConnectionInterfaces; // 0x8
        public System.Action`2<Steamworks.Data.Connection,Steamworks.Data.ConnectionInfo> OnConnectionStatusChanged; // 0x10
        public System.Action`1<Steamworks.Data.NetAddress> OnFakeIPResult; // 0x18

        // ── Methods ──
        public void get_Internal(){} // RVA: 0x7FFAC4BDDDD0
        public void InitializeInterface(){} // RVA: 0x7FFAC4BDDE70
        public void GetSocketManager(){} // RVA: 0x7FFAC4BDDF00
        public void GetConnectionManager(){} // RVA: 0x7FFAC4BDE020
        public void InstallEvents(){} // RVA: 0x7FFAC4BDE100
        public void ConnectionStatusChanged(){} // RVA: 0x7FFAC4BDE390
        public void FakeIPResult(){} // RVA: 0x7FFAC4BDEC10
        public void .ctor(){} // RVA: 0x7FFAC4BDED90
        public void .cctor(){} // RVA: 0x7FFAC4BDEDC0
    }

    public class SteamNetworkingUtils : SteamSharedClass`1
    {
        public System.Action`2<0x6B28DCE0,string> Internal;
        public 0x6B28DC30 Status; // 0x8
        public System.Collections.Concurrent.ConcurrentQueue`1<DebugMessage> debugMessages; // 0x10

        // ── Methods ──
        public void get_Internal(){} // RVA: 0x7FFAC4BDEF60
        public void InitializeInterface(){} // RVA: 0x7FFAC4BDF000
        public void InstallCallbacks(){} // RVA: 0x7FFAC4BDF0C0
        public void set_Status(){} // RVA: 0x7FFAC4BDF310
        public void OutputDebugMessages(){} // RVA: 0x7FFAC4BDF370
        public void .ctor(){} // RVA: 0x7FFAC4BDF5A0
        public void .cctor(){} // RVA: 0x7FFAC4BDF5D0
    }

    public class SteamParental : SteamSharedClass`1
    {
        public System.Action OnSettingsChanged;

        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7FFAC4BDF990
        public void InstallEvents(){} // RVA: 0x7FFAC4BDFA20
        public void .ctor(){} // RVA: 0x7FFAC4BDFC70
    }

    public class SteamParties : SteamClientClass`1
    {
        public System.Action OnBeaconLocationsUpdated;
        public System.Action OnActiveBeaconsUpdated; // 0x8

        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7FFAC4BDFDA0
        public void InstallEvents(){} // RVA: 0x7FFAC4BDFE30
        public void .ctor(){} // RVA: 0x7FFAC4BE0280
    }

    public class SteamRemotePlay : SteamClientClass`1
    {
        public System.Action`1<Steamworks.Data.RemotePlaySession> OnSessionConnected;
        public System.Action`1<Steamworks.Data.RemotePlaySession> OnSessionDisconnected; // 0x8

        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7FFAC4BE0410
        public void InstallEvents(){} // RVA: 0x7FFAC4BE04A0
        public void .ctor(){} // RVA: 0x7FFAC4BE08F0
    }

    public class SteamRemoteStorage : SteamClientClass`1
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7FFAC4BE0A80
        public void .ctor(){} // RVA: 0x7FFAC4BE0B10
    }

    public class SteamScreenshots : SteamClientClass`1
    {
        public System.Action OnScreenshotRequested;
        public System.Action`1<Steamworks.Data.Screenshot> OnScreenshotReady; // 0x8
        public System.Action`1<0x6B28D600> OnScreenshotFailed; // 0x10

        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7FFAC4BE0B40
        public void InstallEvents(){} // RVA: 0x7FFAC4BE0BD0
        public void .ctor(){} // RVA: 0x7FFAC4BE1040
    }

    public class SteamSharedClass`1 : SteamClass
    {
        public Steamworks.SteamInterface Interface;
        public Steamworks.SteamInterface InterfaceServer;

        // ── Methods ──
        public void get_Interface(){} // RVA: 0x7FFAC2C58A90
        public void InitializeInterface(){} // RVA: 0x7FFAC2C71060
        public void SetInterface(){} // RVA: 0x7FFAC2C71580
        public void DestroyInterface(){} // RVA: 0x7FFAC2C71060
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class SteamUGC : SteamSharedClass`1
    {
        public System.Action`1<0x6B28D600> OnDownloadItemResult;
        public System.Action`2<Steamworks.AppId,Steamworks.Data.PublishedFileId> OnItemSubscribed; // 0x8
        public System.Action`2<Steamworks.AppId,Steamworks.Data.PublishedFileId> OnItemUnsubscribed; // 0x10
        public System.Action`2<Steamworks.AppId,Steamworks.Data.PublishedFileId> OnItemInstalled; // 0x18

        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7FFAC4BE11F0
        public void InstallEvents(){} // RVA: 0x7FFAC4BE1280
        public void .ctor(){} // RVA: 0x7FFAC4BE1AD0
    }

    public class SteamUser : SteamClientClass`1
    {
        public System.Collections.Generic.Dictionary`2<string,string> Internal;
        public System.Action SampleRate; // 0x8
        public System.Action OptimalSampleRate; // 0x10
        public System.Action OnSteamServersDisconnected; // 0x18
        public System.Action OnClientGameServerDeny; // 0x20
        public System.Action OnLicensesUpdated; // 0x28
        public System.Action`3<Steamworks.SteamId,Steamworks.SteamId,0x6B28D6B0> OnValidateAuthTicketResponse; // 0x30
        public System.Action`1<Steamworks.Data.GetAuthSessionTicketResponse_t> OnGetAuthSessionTicketResponse; // 0x38
        public System.Action`3<Steamworks.AppId,ulong,bool> OnMicroTxnAuthorizationResponse; // 0x40
        public System.Action`1<string> OnGameWebCallback; // 0x48
        public System.Action`1<Steamworks.Data.DurationControl> OnDurationControl; // 0x50
        public byte[] readBuffer; // 0x58
        public uint sampleRate; // 0x60

        // ── Methods ──
        public void get_Internal(){} // RVA: 0x7FFAC4BE1D60
        public void InitializeInterface(){} // RVA: 0x7FFAC4BE1E00
        public void InstallEvents(){} // RVA: 0x7FFAC4BE2170
        public void add_OnMicroTxnAuthorizationResponse(){} // RVA: 0x7FFAC4BE35B0
        public void remove_OnMicroTxnAuthorizationResponse(){} // RVA: 0x7FFAC4BE3710
        public void get_SampleRate(){} // RVA: 0x7FFAC4BE3870
        public void set_SampleRate(){} // RVA: 0x7FFAC4BE38D0
        public void get_OptimalSampleRate(){} // RVA: 0x7FFAC4BE3A40
        public void GetAuthSessionTicket(){} // RVA: 0x7FFAC4BE3B10
        public void .ctor(){} // RVA: 0x7FFAC4BE3E60
        public void .cctor(){} // RVA: 0x7FFAC4BE3E90
    }

    public class SteamUserStats : SteamClientClass`1
    {
        public bool Internal;
        public System.Action`2<string,int> StatsRecieved; // 0x8
        public System.Action`2<Steamworks.SteamId,0x6B28D600> OnUserStatsReceived; // 0x10
        public System.Action`1<0x6B28D600> OnUserStatsStored; // 0x18
        public System.Action`3<Steamworks.Data.Achievement,int,int> OnAchievementProgress; // 0x20
        public System.Action`1<Steamworks.SteamId> OnUserStatsUnloaded; // 0x28

        // ── Methods ──
        public void get_Internal(){} // RVA: 0x7FFAC4BE4530
        public void InitializeInterface(){} // RVA: 0x7FFAC4BE45D0
        public void set_StatsRecieved(){} // RVA: 0x7FFAC4BE4760
        public void InstallEvents(){} // RVA: 0x7FFAC4BE47A0
        public void RequestCurrentStats(){} // RVA: 0x7FFAC4BE51F0
        public void .ctor(){} // RVA: 0x7FFAC4BE5310
    }

    public class SteamUtils : SteamSharedClass`1
    {
        public System.Action Internal;
        public System.Action`1<int> IsRunningOnSteamDeck; // 0x8
        public System.Action OnSteamShutdown; // 0x10
        public System.Action`1<bool> OnGamepadTextInputDismissed; // 0x18
        public System.Action OnAppResumingFromSuspend; // 0x20
        public 0x6B28D7B8 overlayNotificationPosition; // 0x28

        // ── Methods ──
        public void get_Internal(){} // RVA: 0x7FFAC4BE5740
        public void InitializeInterface(){} // RVA: 0x7FFAC4BE57E0
        public void InstallEvents(){} // RVA: 0x7FFAC4BE58A0
        public void SteamClosed(){} // RVA: 0x7FFAC4BE62F0
        public void add_OnAppResumingFromSuspend(){} // RVA: 0x7FFAC4BE6390
        public void remove_OnAppResumingFromSuspend(){} // RVA: 0x7FFAC4BE64E0
        public void get_IsRunningOnSteamDeck(){} // RVA: 0x7FFAC4BE6630
        public void .ctor(){} // RVA: 0x7FFAC4BE6780
        public void .cctor(){} // RVA: 0x7FFAC4BE67B0
    }

    public class SteamVideo : SteamClientClass`1
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7FFAC4BE6B40
        public void InstallEvents(){} // RVA: 0x7FFAC2F21310
        public void .ctor(){} // RVA: 0x7FFAC4BE6BD0
    }

    public class Utf8StringPointer : ValueType
    {
        public UIntPtr ptr; // 0x10

        // ── Methods ──
        public void op_Implicit(){} // RVA: 0x7FFAC4BE8680
    }

    public class Utf8StringToNative : Object
    {
        // ── Methods ──
        public void MarshalManagedToNative(){} // RVA: 0x7FFAC4BE8400
        public void MarshalNativeToManaged(){} // RVA: 0x7FFAC4BE8570
        public void CleanUpNativeData(){} // RVA: 0x7FFAC4BE85B0
        public void CleanUpManagedData(){} // RVA: 0x7FFAC4BE8600
        public void GetNativeDataSize(){} // RVA: 0x7FFAC32BD0E0
        public void GetInstance(){} // RVA: 0x7FFAC4BE8640
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Utility : Object
    {
        public byte[] readBuffer;

        // ── Methods ──
        public void ToType(){} // RVA: 0x7FFAC4BE8720 | overloaded x2
        public void Swap(){} // RVA: 0x7FFAC4BE8790
        public void IpToInt32(){} // RVA: 0x7FFAC4BE87A0
        public void Int32ToIp(){} // RVA: 0x7FFAC4BE8840
        public void .cctor(){} // RVA: 0x7FFAC4BE88C0
    }

}