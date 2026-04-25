// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Steamworks
// Classes: 52
// Methods: 291

namespace ThirdParty.Other.Steamworks
{
    public class AppId : ValueType
    {
        public uint Value; // 0x10

        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFD50006C00
        public void op_Implicit(){} // RVA: 0x7FFD50006C10
    }

    public class ConnectionManager : Object
    {
        public orPlus Interface; // 0x10
        public Steamworks.Data.ConnectionInfo ConnectionInfo; // 0x18
        public bool Connected; // 0x2D0
        public bool Connecting; // 0x2D1

        // ── Methods ──
        public void get_Interface(){} // RVA: 0x7FFD4E35C380
        public void set_ConnectionInfo(){} // RVA: 0x7FFD4FFF6260
        public void OnConnectionChanged(){} // RVA: 0x7FFD4FFF6340
        public void OnConnecting(){} // RVA: 0x7FFD4FFF6680
        public void OnConnected(){} // RVA: 0x7FFD4FFF6760
        public void OnDisconnected(){} // RVA: 0x7FFD4FFF6850
    }

    public class Dispatch : Object
    {
        public System.Action`3<ÍÌÏÌÎÏÎÏÏÎ,string,bool> ClientPipe;
        public System.Action`1<System.Exception> ServerPipe; // 0x8
        public Steamworks.Data.HSteamPipe <ClientPipe>k__BackingField; // 0x10
        public Steamworks.Data.HSteamPipe <ServerPipe>k__BackingField; // 0x14
        public bool runningFrame; // 0x18
        public System.Collections.Generic.List`1<System.Action`1<UIntPtr>> actionsToCall; // 0x20
        public System.Collections.Generic.Dictionary`2<ulong,ResultCallback> ResultCallbacks; // 0x28
        public System.Collections.Generic.Dictionary`2<ÍÌÏÌÎÏÎÏÏÎ,System.Collections.Generic.List`1<Callback>> Callbacks; // 0x30

        // ── Methods ──
        public void SteamAPI_ManualDispatch_Init(){} // RVA: 0x7FFD4FFEB8B0
        public void SteamAPI_ManualDispatch_RunFrame(){} // RVA: 0x7FFD4FFEB920
        public void SteamAPI_ManualDispatch_GetNextCallback(){} // RVA: 0x7FFD4FFEB9A0
        public void SteamAPI_ManualDispatch_FreeLastCallback(){} // RVA: 0x7FFD4FFEBA30
        public void get_ClientPipe(){} // RVA: 0x7FFD4FFEBAB0
        public void set_ClientPipe(){} // RVA: 0x7FFD4FFEBB10
        public void get_ServerPipe(){} // RVA: 0x7FFD4FFEBB70
        public void Init(){} // RVA: 0x7FFD4FFEBBD0
        public void Frame(){} // RVA: 0x7FFD4FFEBC70
        public void ProcessCallback(){} // RVA: 0x7FFD4FFEC0D0
        public void CallbackToString(){} // RVA: 0x7FFD4FFEC690
        public void ProcessResult(){} // RVA: 0x7FFD4FFECE60
        public void LoopClientAsync(){} // RVA: 0x7FFD4FFED1A0
        public void Install(){} // RVA: 0x7FFD4E0962E0
        public void ShutdownClient(){} // RVA: 0x7FFD4FFED2F0
        public void .cctor(){} // RVA: 0x7FFD4FFEDC20
    }

    public class Helpers : Object
    {
        public byte[][] BufferPool;
        public int BufferPoolIndex; // 0x8

        // ── Methods ──
        public void TakeMemory(){} // RVA: 0x7FFD50007620
        public void TakeBuffer(){} // RVA: 0x7FFD50007670
        public void MemoryToString(){} // RVA: 0x7FFD50007A50
        public void .cctor(){} // RVA: 0x7FFD50007B20
    }

    public class ICallbackData
    {
        public object CallbackType;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFD4E079960
    }

    public class ISteamApps : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4FFF3070
        public void SteamAPI_SteamApps_v008(){} // RVA: 0x7FFD4FFF3080
        public void GetUserInterfacePointer(){} // RVA: 0x7FFD4FFF3080
        public void _GetCurrentBetaName(){} // RVA: 0x7FFD4FFF30F0
        public void GetCurrentBetaName(){} // RVA: 0x7FFD4FFF3190
        public void _GetLaunchQueryParam(){} // RVA: 0x7FFD4FFF3450
        public void GetLaunchQueryParam(){} // RVA: 0x7FFD4FFF3510
        public void _GetLaunchCommandLine(){} // RVA: 0x7FFD4FFF35D0
        public void GetLaunchCommandLine(){} // RVA: 0x7FFD4FFF3670
    }

    public class ISteamFriends : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4FFF3070
        public void SteamAPI_SteamFriends_v017(){} // RVA: 0x7FFD4FFF3910
        public void GetUserInterfacePointer(){} // RVA: 0x7FFD4FFF3910
        public void _GetPersonaName(){} // RVA: 0x7FFD4FFF3980
        public void GetPersonaName(){} // RVA: 0x7FFD4FFF3A00
        public void _GetFriendPersonaName(){} // RVA: 0x7FFD4FFF3A90
        public void GetFriendPersonaName(){} // RVA: 0x7FFD4FFF3B20
        public void _SetRichPresence(){} // RVA: 0x7FFD4FFF3BC0
        public void SetRichPresence(){} // RVA: 0x7FFD4FFF3CA0
        public void _ClearRichPresence(){} // RVA: 0x7FFD4FFF3D80
        public void ClearRichPresence(){} // RVA: 0x7FFD4FFF3E00
        public void _GetClanChatMessage(){} // RVA: 0x7FFD4FFF3E80
        public void GetClanChatMessage(){} // RVA: 0x7FFD4FFF3F30
        public void _GetFriendMessage(){} // RVA: 0x7FFD4FFF3FE0
        public void GetFriendMessage(){} // RVA: 0x7FFD4FFF4090
    }

    public class ISteamInput : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4FFF3070
        public void SteamAPI_SteamInput_v006(){} // RVA: 0x7FFD4FFF4140
        public void GetUserInterfacePointer(){} // RVA: 0x7FFD4FFF4140
    }

    public class ISteamInventory : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4FFF3070
        public void SteamAPI_SteamInventory_v003(){} // RVA: 0x7FFD4FFF41B0
        public void GetUserInterfacePointer(){} // RVA: 0x7FFD4FFF41B0
        public void SteamAPI_SteamGameServerInventory_v003(){} // RVA: 0x7FFD4FFF4220
        public void GetServerInterfacePointer(){} // RVA: 0x7FFD4FFF4220
        public void _GetResultItems(){} // RVA: 0x7FFD4FFF4290
        public void GetResultItems(){} // RVA: 0x7FFD4FFF4340
        public void _GetResultItemProperty(){} // RVA: 0x7FFD4FFF43F0
        public void GetResultItemProperty(){} // RVA: 0x7FFD4FFF44E0
        public void _DestroyResult(){} // RVA: 0x7FFD4FFF47E0
        public void DestroyResult(){} // RVA: 0x7FFD4FFF4870
        public void _GetItemDefinitionIDs(){} // RVA: 0x7FFD4FFF4900
        public void GetItemDefinitionIDs(){} // RVA: 0x7FFD4FFF49B0
    }

    public class ISteamMatchmaking : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4FFF3070
        public void SteamAPI_SteamMatchmaking_v009(){} // RVA: 0x7FFD4FFF4A60
        public void GetUserInterfacePointer(){} // RVA: 0x7FFD4FFF4A60
        public void _GetLobbyChatEntry(){} // RVA: 0x7FFD4FFF4AD0
        public void GetLobbyChatEntry(){} // RVA: 0x7FFD4FFF4B80
    }

    public class ISteamMatchmakingServers : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4FFF3070
        public void SteamAPI_SteamMatchmakingServers_v002(){} // RVA: 0x7FFD4FFF4C30
        public void GetUserInterfacePointer(){} // RVA: 0x7FFD4FFF4C30
    }

    public class ISteamMusic : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4FFF3070
        public void SteamAPI_SteamMusic_v001(){} // RVA: 0x7FFD4FFF4CA0
        public void GetUserInterfacePointer(){} // RVA: 0x7FFD4FFF4CA0
    }

    public class ISteamNetworking : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4FFF3070
        public void SteamAPI_SteamNetworking_v006(){} // RVA: 0x7FFD4FFF4D10
        public void GetUserInterfacePointer(){} // RVA: 0x7FFD4FFF4D10
        public void SteamAPI_SteamGameServerNetworking_v006(){} // RVA: 0x7FFD4FFF4D80
        public void GetServerInterfacePointer(){} // RVA: 0x7FFD4FFF4D80
    }

    public class ISteamNetworkingSockets : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4FFF3070
        public void SteamAPI_SteamNetworkingSockets_SteamAPI_v012(){} // RVA: 0x7FFD4FFF4DF0
        public void GetUserInterfacePointer(){} // RVA: 0x7FFD4FFF4DF0
        public void SteamAPI_SteamGameServerNetworkingSockets_SteamAPI_v012(){} // RVA: 0x7FFD4FFF4E60
        public void GetServerInterfacePointer(){} // RVA: 0x7FFD4FFF4E60
        public void _AcceptConnection(){} // RVA: 0x7FFD4FFF4ED0
        public void AcceptConnection(){} // RVA: 0x7FFD4FFF4F60
        public void _CloseConnection(){} // RVA: 0x7FFD4FFF4FF0
        public void CloseConnection(){} // RVA: 0x7FFD4FFF50D0
        public void _SetConnectionPollGroup(){} // RVA: 0x7FFD4FFF51B0
        public void SetConnectionPollGroup(){} // RVA: 0x7FFD4FFF5250
    }

    public class ISteamNetworkingUtils : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4FFF3070
        public void SteamAPI_SteamNetworkingUtils_SteamAPI_v004(){} // RVA: 0x7FFD4FFF52F0
        public void GetGlobalInterfacePointer(){} // RVA: 0x7FFD4FFF52F0
        public void _SteamNetworkingIdentity_ToString(){} // RVA: 0x7FFD4FFF5360
        public void SteamNetworkingIdentity_ToString(){} // RVA: 0x7FFD4FFF5410
    }

    public class ISteamParentalSettings : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4FFF3070
        public void SteamAPI_SteamParentalSettings_v001(){} // RVA: 0x7FFD4FFF56A0
        public void GetUserInterfacePointer(){} // RVA: 0x7FFD4FFF56A0
    }

    public class ISteamParties : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4FFF3070
        public void SteamAPI_SteamParties_v002(){} // RVA: 0x7FFD4FFF5710
        public void GetUserInterfacePointer(){} // RVA: 0x7FFD4FFF5710
    }

    public class ISteamRemotePlay : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4FFF3070
        public void SteamAPI_SteamRemotePlay_v001(){} // RVA: 0x7FFD4FFF5780
        public void GetUserInterfacePointer(){} // RVA: 0x7FFD4FFF5780
    }

    public class ISteamRemoteStorage : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4FFF3070
        public void SteamAPI_SteamRemoteStorage_v016(){} // RVA: 0x7FFD4FFF57F0
        public void GetUserInterfacePointer(){} // RVA: 0x7FFD4FFF57F0
    }

    public class ISteamScreenshots : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4FFF3070
        public void SteamAPI_SteamScreenshots_v003(){} // RVA: 0x7FFD4FFF5860
        public void GetUserInterfacePointer(){} // RVA: 0x7FFD4FFF5860
    }

    public class ISteamUGC : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4FFF3070
        public void SteamAPI_SteamUGC_v016(){} // RVA: 0x7FFD4FFF58D0
        public void GetUserInterfacePointer(){} // RVA: 0x7FFD4FFF58D0
        public void SteamAPI_SteamGameServerUGC_v016(){} // RVA: 0x7FFD4FFF5940
        public void GetServerInterfacePointer(){} // RVA: 0x7FFD4FFF5940
    }

    public class ISteamUser : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4FFF3070
        public void SteamAPI_SteamUser_v021(){} // RVA: 0x7FFD4FFF59B0
        public void GetUserInterfacePointer(){} // RVA: 0x7FFD4FFF59B0
        public void _GetSteamID(){} // RVA: 0x7FFD4FFF5A20
        public void GetSteamID(){} // RVA: 0x7FFD4FFF5AA0
        public void _GetVoiceOptimalSampleRate(){} // RVA: 0x7FFD4FFF5B20
        public void GetVoiceOptimalSampleRate(){} // RVA: 0x7FFD4FFF5BA0
        public void _GetAuthSessionTicket(){} // RVA: 0x7FFD4FFF5C20
        public void GetAuthSessionTicket(){} // RVA: 0x7FFD4FFF5CD0
        public void _CancelAuthTicket(){} // RVA: 0x7FFD4FFF5D80
        public void CancelAuthTicket(){} // RVA: 0x7FFD4FFF5E10
    }

    public class ISteamUserStats : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4FFF3070
        public void SteamAPI_SteamUserStats_v012(){} // RVA: 0x7FFD4FFF5EA0
        public void GetUserInterfacePointer(){} // RVA: 0x7FFD4FFF5EA0
        public void _RequestCurrentStats(){} // RVA: 0x7FFD4FFF5F10
        public void RequestCurrentStats(){} // RVA: 0x7FFD4FFF5F90
    }

    public class ISteamUtils : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4FFF3070
        public void SteamAPI_SteamUtils_v010(){} // RVA: 0x7FFD4FFF6010
        public void GetUserInterfacePointer(){} // RVA: 0x7FFD4FFF6010
        public void SteamAPI_SteamGameServerUtils_v010(){} // RVA: 0x7FFD4FFF6080
        public void GetServerInterfacePointer(){} // RVA: 0x7FFD4FFF6080
        public void _IsSteamRunningOnSteamDeck(){} // RVA: 0x7FFD4FFF60F0
        public void IsSteamRunningOnSteamDeck(){} // RVA: 0x7FFD4FFF6170
    }

    public class ISteamVideo : SteamInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4FFF3070
        public void SteamAPI_SteamVideo_v002(){} // RVA: 0x7FFD4FFF61F0
        public void GetUserInterfacePointer(){} // RVA: 0x7FFD4FFF61F0
    }

    public class SocketManager : Object
    {
        public faceMirror Interface; // 0x10
        public System.Collections.Generic.HashSet`1<Steamworks.Data.Connection> Connecting; // 0x18
        public System.Collections.Generic.HashSet`1<Steamworks.Data.Connection> Connected; // 0x20
        public Steamworks.Data.HSteamNetPollGroup pollGroup; // 0x28

        // ── Methods ──
        public void get_Interface(){} // RVA: 0x7FFD4E35C380
        public void OnConnectionChanged(){} // RVA: 0x7FFD4FFF6940
        public void OnConnecting(){} // RVA: 0x7FFD4FFF6D10
        public void OnConnected(){} // RVA: 0x7FFD4FFF6E30
        public void OnDisconnected(){} // RVA: 0x7FFD4FFF7000
    }

    public class SteamApps : SteamSharedClass`1
    {
        public System.Action Internal;

        // ── Methods ──
        public void get_Internal(){} // RVA: 0x7FFD4FFF7150
        public void InitializeInterface(){} // RVA: 0x7FFD4FFF71F0
        public void add_OnNewLaunchParameters(){} // RVA: 0x7FFD4FFF7280
        public void remove_OnNewLaunchParameters(){} // RVA: 0x7FFD4FFF7390
        public void get_CurrentBetaName(){} // RVA: 0x7FFD4FFF74A0
        public void GetLaunchParam(){} // RVA: 0x7FFD4FFF74E0
        public void get_CommandLine(){} // RVA: 0x7FFD4FFF75B0
        public void .ctor(){} // RVA: 0x7FFD4FFF75F0
    }

    public class SteamClass : Object
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7FFD4E091060
        public void DestroyInterface(){} // RVA: 0x7FFD4E091060
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class SteamClient : Object
    {
        public bool IsValid;
        public System.Collections.Generic.List`1<Steamworks.SteamClass> SteamId; // 0x8
        public Steamworks.AppId Name; // 0x10

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFD4FFF7620
        public void AddInterface(){} // RVA: 0x7FFD4E0909B0
        public void ShutdownInterfaces(){} // RVA: 0x7FFD4FFF7D10
        public void get_IsValid(){} // RVA: 0x7FFD4FFF7F00
        public void Shutdown(){} // RVA: 0x7FFD4FFF7F60
        public void Cleanup(){} // RVA: 0x7FFD4FFF8070
        public void get_SteamId(){} // RVA: 0x7FFD4FFF8100
        public void get_Name(){} // RVA: 0x7FFD4FFF81D0
        public void set_AppId(){} // RVA: 0x7FFD4FFF8270
        public void RestartAppIfNecessary(){} // RVA: 0x7FFD4FFEE540
        public void .cctor(){} // RVA: 0x7FFD4FFF82D0
    }

    public class SteamClientClass`1 : SteamClass
    {
        public Steamworks.SteamInterface Interface;

        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7FFD4E091060
        public void SetInterface(){} // RVA: 0x7FFD4E091580
        public void DestroyInterface(){} // RVA: 0x7FFD4E091060
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class SteamFriends : SteamClientClass`1
    {
        public System.Collections.Generic.Dictionary`2<string,string> Internal;
        public System.Action`3<0x665EEB50,string,string> OnChatMessage; // 0x8
        public System.Action`3<0x665EEB50,string,string> OnClanChatMessage; // 0x10
        public System.Action`1<0x665EEB50> OnPersonaStateChange; // 0x18
        public System.Action`2<0x665EEB50,string> OnGameRichPresenceJoinRequested; // 0x20
        public System.Action`1<bool> OnGameOverlayActivated; // 0x28
        public System.Action`2<string,string> OnGameServerChangeRequested; // 0x30
        public System.Action`2<0x665F4198,ÏÎÎÏÍÍ> OnGameLobbyJoinRequested; // 0x38
        public System.Action`1<0x665EEB50> OnFriendRichPresenceUpdate; // 0x40
        public System.Action`1<string> OnOverlayBrowserProtocol; // 0x48

        // ── Methods ──
        public void get_Internal(){} // RVA: 0x7FFD4FFF83B0
        public void InitializeInterface(){} // RVA: 0x7FFD4FFF8450
        public void InstallEvents(){} // RVA: 0x7FFD4FFF8590
        public void OnFriendChatMessage(){} // RVA: 0x7FFD4FFF9620
        public void OnGameConnectedClanChatMessage(){} // RVA: 0x7FFD4FFF99A0
        public void SetRichPresence(){} // RVA: 0x7FFD4FFF9D50
        public void ClearRichPresence(){} // RVA: 0x7FFD4FFF9EE0
        public void .ctor(){} // RVA: 0x7FFD4FFF9FD0
    }

    public class SteamInput : SteamClientClass`1
    {
        public Steamworks.Data.InputHandle_t[] queryArray;
        public System.Collections.Generic.Dictionary`2<string,Steamworks.Data.InputDigitalActionHandle_t> DigitalHandles; // 0x8
        public System.Collections.Generic.Dictionary`2<string,Steamworks.Data.InputAnalogActionHandle_t> AnalogHandles; // 0x10
        public System.Collections.Generic.Dictionary`2<string,Steamworks.Data.InputActionSetHandle_t> ActionSets; // 0x18

        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7FFD4FFFA420
        public void .ctor(){} // RVA: 0x7FFD4FFFA4B0
        public void .cctor(){} // RVA: 0x7FFD4FFFA4E0
    }

    public class SteamInterface : Object
    {
        public UIntPtr IsServer; // 0x10
        public UIntPtr SelfGlobal; // 0x18
        public UIntPtr SelfServer; // 0x20
        public UIntPtr SelfClient; // 0x28
        public bool <IsServer>k__BackingField; // 0x30

        // ── Methods ──
        public void GetUserInterfacePointer(){} // RVA: 0x7FFD4E919180
        public void GetServerInterfacePointer(){} // RVA: 0x7FFD4E919180
        public void GetGlobalInterfacePointer(){} // RVA: 0x7FFD4E919180
        public void set_IsServer(){} // RVA: 0x7FFD4E367460
        public void SetupInterface(){} // RVA: 0x7FFD50008370
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class SteamInventory : SteamSharedClass`1
    {
        public System.Action`1<0x665EEC58> Internal;
        public System.Action Items; // 0x8
        public 0x665EEC00[] Definitions; // 0x10
        public ÎÌÍÎÌÌÎÍÏÌÌÎÎÍÍ[] <Definitions>k__BackingField; // 0x18
        public System.Collections.Generic.Dictionary`2<int,ÎÌÍÎÌÌÎÍÏÌÌÎÎÍÍ> _defMap; // 0x20

        // ── Methods ──
        public void get_Internal(){} // RVA: 0x7FFD4FFFA920
        public void InitializeInterface(){} // RVA: 0x7FFD4FFFA9C0
        public void InstallEvents(){} // RVA: 0x7FFD4FFFAA50
        public void InventoryUpdated(){} // RVA: 0x7FFD4FFFAEA0
        public void LoadDefinitions(){} // RVA: 0x7FFD4FFFAFB0
        public void set_Items(){} // RVA: 0x7FFD4FFFB250
        public void get_Definitions(){} // RVA: 0x7FFD4FFFB2F0
        public void set_Definitions(){} // RVA: 0x7FFD4FFFB330
        public void GetDefinitions(){} // RVA: 0x7FFD4FFFB3D0
        public void .ctor(){} // RVA: 0x7FFD4FFFB6D0
    }

    public class SteamMatchmaking : SteamClientClass`1
    {
        public System.Action`2<0x665EEB50,0x665F4198> Internal;
        public System.Action`1<0x665F4198> OnLobbyEntered; // 0x8
        public System.Action`2<0x665ED600,0x665F4198> OnLobbyCreated; // 0x10
        public System.Action`4<0x665F4198,uint,ushort,ÏÎÎÏÍÍ> OnLobbyGameCreated; // 0x18
        public System.Action`1<0x665F4198> OnLobbyDataChanged; // 0x20
        public System.Action`2<0x665F4198,0x665EEB50> OnLobbyMemberDataChanged; // 0x28
        public System.Action`2<0x665F4198,0x665EEB50> OnLobbyMemberJoined; // 0x30
        public System.Action`2<0x665F4198,0x665EEB50> OnLobbyMemberLeave; // 0x38
        public System.Action`2<0x665F4198,0x665EEB50> OnLobbyMemberDisconnected; // 0x40
        public System.Action`3<0x665F4198,0x665EEB50,0x665EEB50> OnLobbyMemberKicked; // 0x48
        public System.Action`3<0x665F4198,0x665EEB50,0x665EEB50> OnLobbyMemberBanned; // 0x50
        public System.Action`3<0x665F4198,0x665EEB50,string> OnChatMessage; // 0x58

        // ── Methods ──
        public void get_Internal(){} // RVA: 0x7FFD4FFFB900
        public void InitializeInterface(){} // RVA: 0x7FFD4FFFB9A0
        public void InstallEvents(){} // RVA: 0x7FFD4FFFBA30
        public void OnLobbyChatMessageRecievedAPI(){} // RVA: 0x7FFD4FFFC7A0
        public void .ctor(){} // RVA: 0x7FFD4FFFCB60
    }

    public class SteamMatchmakingServers : SteamClientClass`1
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7FFD4FFFD000
        public void .ctor(){} // RVA: 0x7FFD4FFFD090
    }

    public class SteamMusic : SteamClientClass`1
    {
        public System.Action OnPlaybackChanged;
        public System.Action`1<float> OnVolumeChanged; // 0x8

        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7FFD4FFFD0C0
        public void InstallEvents(){} // RVA: 0x7FFD4FFFD150
        public void .ctor(){} // RVA: 0x7FFD4FFFD5C0
    }

    public class SteamNetworking : SteamSharedClass`1
    {
        public System.Action`1<ÏÎÎÏÍÍ> OnP2PSessionRequest;
        public System.Action`2<ÏÎÎÏÍÍ,ÏÏÏÍÎÏÌÍÎÍÎÍÎÎÎÎÎÍÌÌ> OnP2PConnectionFailed; // 0x8

        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7FFD4FFFD750
        public void InstallEvents(){} // RVA: 0x7FFD4FFFD7E0
        public void .ctor(){} // RVA: 0x7FFD4FFFDC30
    }

    public class SteamNetworkingSockets : SteamSharedClass`1
    {
        public System.Collections.Generic.Dictionary`2<uint,Steamworks.SocketManager> Internal;
        public System.Collections.Generic.Dictionary`2<uint,Steamworks.ConnectionManager> ConnectionInterfaces; // 0x8
        public System.Action`2<Steamworks.Data.Connection,Steamworks.Data.ConnectionInfo> OnConnectionStatusChanged; // 0x10
        public System.Action`1<Steamworks.Data.NetAddress> OnFakeIPResult; // 0x18

        // ── Methods ──
        public void get_Internal(){} // RVA: 0x7FFD4FFFDDD0
        public void InitializeInterface(){} // RVA: 0x7FFD4FFFDE70
        public void GetSocketManager(){} // RVA: 0x7FFD4FFFDF00
        public void GetConnectionManager(){} // RVA: 0x7FFD4FFFE020
        public void InstallEvents(){} // RVA: 0x7FFD4FFFE100
        public void ConnectionStatusChanged(){} // RVA: 0x7FFD4FFFE390
        public void FakeIPResult(){} // RVA: 0x7FFD4FFFEC10
        public void .ctor(){} // RVA: 0x7FFD4FFFED90
        public void .cctor(){} // RVA: 0x7FFD4FFFEDC0
    }

    public class SteamNetworkingUtils : SteamSharedClass`1
    {
        public System.Action`2<ypeToggleOn,string> Internal;
        public Left Status; // 0x8
        public System.Collections.Concurrent.ConcurrentQueue`1<DebugMessage> debugMessages; // 0x10

        // ── Methods ──
        public void get_Internal(){} // RVA: 0x7FFD4FFFEF60
        public void InitializeInterface(){} // RVA: 0x7FFD4FFFF000
        public void InstallCallbacks(){} // RVA: 0x7FFD4FFFF0C0
        public void set_Status(){} // RVA: 0x7FFD4FFFF310
        public void OutputDebugMessages(){} // RVA: 0x7FFD4FFFF370
        public void .ctor(){} // RVA: 0x7FFD4FFFF5A0
        public void .cctor(){} // RVA: 0x7FFD4FFFF5D0
    }

    public class SteamParental : SteamSharedClass`1
    {
        public System.Action OnSettingsChanged;

        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7FFD4FFFF990
        public void InstallEvents(){} // RVA: 0x7FFD4FFFFA20
        public void .ctor(){} // RVA: 0x7FFD4FFFFC70
    }

    public class SteamParties : SteamClientClass`1
    {
        public System.Action OnBeaconLocationsUpdated;
        public System.Action OnActiveBeaconsUpdated; // 0x8

        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7FFD4FFFFDA0
        public void InstallEvents(){} // RVA: 0x7FFD4FFFFE30
        public void .ctor(){} // RVA: 0x7FFD50000280
    }

    public class SteamRemotePlay : SteamClientClass`1
    {
        public System.Action`1<ÏÌÏÌÍÎÏ.ÌÌÍÍ> OnSessionConnected;
        public System.Action`1<ÏÌÏÌÍÎÏ.ÌÌÍÍ> OnSessionDisconnected; // 0x8

        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7FFD50000410
        public void InstallEvents(){} // RVA: 0x7FFD500004A0
        public void .ctor(){} // RVA: 0x7FFD500008F0
    }

    public class SteamRemoteStorage : SteamClientClass`1
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7FFD50000A80
        public void .ctor(){} // RVA: 0x7FFD50000B10
    }

    public class SteamScreenshots : SteamClientClass`1
    {
        public System.Action OnScreenshotRequested;
        public System.Action`1<0x665F4248> OnScreenshotReady; // 0x8
        public System.Action`1<0x665ED600> OnScreenshotFailed; // 0x10

        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7FFD50000B40
        public void InstallEvents(){} // RVA: 0x7FFD50000BD0
        public void .ctor(){} // RVA: 0x7FFD50001040
    }

    public class SteamSharedClass`1 : SteamClass
    {
        public Steamworks.SteamInterface Interface;
        public Steamworks.SteamInterface InterfaceServer; // 0x8

        // ── Methods ──
        public void get_Interface(){} // RVA: 0x7FFD4E078A90
        public void InitializeInterface(){} // RVA: 0x7FFD4E091060
        public void SetInterface(){} // RVA: 0x7FFD4E091580
        public void DestroyInterface(){} // RVA: 0x7FFD4E091060
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class SteamUGC : SteamSharedClass`1
    {
        public System.Action`1<0x665ED600> OnDownloadItemResult;
        public System.Action`2<Steamworks.AppId,Steamworks.Data.PublishedFileId> OnItemSubscribed; // 0x8
        public System.Action`2<Steamworks.AppId,Steamworks.Data.PublishedFileId> OnItemUnsubscribed; // 0x10
        public System.Action`2<Steamworks.AppId,Steamworks.Data.PublishedFileId> OnItemInstalled; // 0x18

        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7FFD500011F0
        public void InstallEvents(){} // RVA: 0x7FFD50001280
        public void .ctor(){} // RVA: 0x7FFD50001AD0
    }

    public class SteamUser : SteamClientClass`1
    {
        public System.Collections.Generic.Dictionary`2<string,string> Internal;
        public System.Action SampleRate; // 0x8
        public System.Action OptimalSampleRate; // 0x10
        public System.Action OnSteamServersDisconnected; // 0x18
        public System.Action OnClientGameServerDeny; // 0x20
        public System.Action OnLicensesUpdated; // 0x28
        public System.Action`3<ÏÎÎÏÍÍ,ÏÎÎÏÍÍ,ÎÌÎÏÏÎÌÌÏÎÎÍÎÎÌÏÌÏÌÏÌÌ> OnValidateAuthTicketResponse; // 0x30
        public System.Action`1<Steamworks.Data.GetAuthSessionTicketResponse_t> OnGetAuthSessionTicketResponse; // 0x38
        public System.Action`3<Steamworks.AppId,ulong,bool> OnMicroTxnAuthorizationResponse; // 0x40
        public System.Action`1<string> OnGameWebCallback; // 0x48
        public System.Action`1<0x665F40E8> OnDurationControl; // 0x50
        public byte[] readBuffer; // 0x58
        public uint sampleRate; // 0x60

        // ── Methods ──
        public void get_Internal(){} // RVA: 0x7FFD50001D60
        public void InitializeInterface(){} // RVA: 0x7FFD50001E00
        public void InstallEvents(){} // RVA: 0x7FFD50002170
        public void add_OnMicroTxnAuthorizationResponse(){} // RVA: 0x7FFD500035B0
        public void remove_OnMicroTxnAuthorizationResponse(){} // RVA: 0x7FFD50003710
        public void get_SampleRate(){} // RVA: 0x7FFD50003870
        public void set_SampleRate(){} // RVA: 0x7FFD500038D0
        public void get_OptimalSampleRate(){} // RVA: 0x7FFD50003A40
        public void GetAuthSessionTicket(){} // RVA: 0x7FFD50003B10
        public void .ctor(){} // RVA: 0x7FFD50003E60
        public void .cctor(){} // RVA: 0x7FFD50003E90
    }

    public class SteamUserStats : SteamClientClass`1
    {
        public bool Internal;
        public System.Action`2<string,int> StatsRecieved; // 0x8
        public System.Action`2<ÏÎÎÏÍÍ,0x665ED600> OnUserStatsReceived; // 0x10
        public System.Action`1<0x665ED600> OnUserStatsStored; // 0x18
        public System.Action`3<0x665F4090,int,int> OnAchievementProgress; // 0x20
        public System.Action`1<ÏÎÎÏÍÍ> OnUserStatsUnloaded; // 0x28

        // ── Methods ──
        public void get_Internal(){} // RVA: 0x7FFD50004530
        public void InitializeInterface(){} // RVA: 0x7FFD500045D0
        public void set_StatsRecieved(){} // RVA: 0x7FFD50004760
        public void InstallEvents(){} // RVA: 0x7FFD500047A0
        public void RequestCurrentStats(){} // RVA: 0x7FFD500051F0
        public void .ctor(){} // RVA: 0x7FFD50005310
    }

    public class SteamUtils : SteamSharedClass`1
    {
        public System.Action Internal;
        public System.Action`1<int> IsRunningOnSteamDeck; // 0x8
        public System.Action OnSteamShutdown; // 0x10
        public System.Action`1<bool> OnGamepadTextInputDismissed; // 0x18
        public System.Action OnAppResumingFromSuspend; // 0x20
        public ÎÎÎÍÏÌÏÏÍÍÏÍÏ overlayNotificationPosition; // 0x28

        // ── Methods ──
        public void get_Internal(){} // RVA: 0x7FFD50005740
        public void InitializeInterface(){} // RVA: 0x7FFD500057E0
        public void InstallEvents(){} // RVA: 0x7FFD500058A0
        public void SteamClosed(){} // RVA: 0x7FFD500062F0
        public void add_OnAppResumingFromSuspend(){} // RVA: 0x7FFD50006390
        public void remove_OnAppResumingFromSuspend(){} // RVA: 0x7FFD500064E0
        public void get_IsRunningOnSteamDeck(){} // RVA: 0x7FFD50006630
        public void .ctor(){} // RVA: 0x7FFD50006780
        public void .cctor(){} // RVA: 0x7FFD500067B0
    }

    public class SteamVideo : SteamClientClass`1
    {
        // ── Methods ──
        public void InitializeInterface(){} // RVA: 0x7FFD50006B40
        public void InstallEvents(){} // RVA: 0x7FFD4E341310
        public void .ctor(){} // RVA: 0x7FFD50006BD0
    }

    public class Utility : Object
    {
        public byte[] readBuffer;

        // ── Methods ──
        public void ToType(){} // RVA: 0x7FFD50008720 | overloaded x2
        public void Swap(){} // RVA: 0x7FFD50008790
        public void IpToInt32(){} // RVA: 0x7FFD500087A0
        public void Int32ToIp(){} // RVA: 0x7FFD50008840
        public void .cctor(){} // RVA: 0x7FFD500088C0
    }

}