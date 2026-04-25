// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Photon.Photon.Realtime
// Classes: 5
// Methods: 88

namespace ThirdParty.Photon.Photon.Realtime
{
    public class AppSettings : Object
    {
        public string IsMasterServerAddress; // 0x10
        public string IsBestRegion; // 0x18
        public string IsDefaultNameServer; // 0x20
        public string IsDefaultPort; // 0x28
        public string AppIdVoice; // 0x30
        public string AppVersion; // 0x38
        public bool UseNameServer; // 0x40
        public string FixedRegion; // 0x48
        public string BestRegionSummaryFromStorage; // 0x50
        public string Server; // 0x58
        public ushort Port; // 0x60
        public string ProxyServer; // 0x68
        public 0x665CA660 Protocol; // 0x70
        public bool EnableProtocolFallback; // 0x71
        public 0x663784A8 AuthMode; // 0x74
        public bool EnableLobbyStatistics; // 0x78
        public 0x665CA6B8 NetworkLogging; // 0x79
        public 0x665CA6B8 ClientLogging; // 0x7A

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFD4F95E180
        public void set_IsDefaultNameServer(){} // RVA: 0x7FFD4F95EB40
        public void get_IsDefaultNameServer(){} // RVA: 0x7FFD4F95EC60
        public void get_IsDefaultPort(){} // RVA: 0x7FFD4F95EC80
        public void .ctor(){} // RVA: 0x7FFD4F95F0E0 | overloaded x2
        public void get_IsMasterServerAddress(){} // RVA: 0x7FFD4F95ECC0
        public void set_IsMasterServerAddress(){} // RVA: 0x7FFD4F95ECD0
        public void set_IsBestRegion(){} // RVA: 0x7FFD4F95EDD0
        public void get_IsBestRegion(){} // RVA: 0x7FFD4F95EE40
        public void Instantiate(){} // RVA: 0x7FFD4F95EE60
        public void Equals(){} // RVA: 0x7FFD4F95EF50
        public void GetHashCode(){} // RVA: 0x7FFD4F95EF90
        public void ToString(){} // RVA: 0x7FFD4F95EFB0
        public void GetNameServerAddress(){} // RVA: 0x7FFD4F95EFF0
        public void Initialize(){} // RVA: 0x7FFD4F95F100
        public void GetBestRegionCode(){} // RVA: 0x7FFD4F95F1F0
        public void CancelInvoke(){} // RVA: 0x7FFD4F95F600
        public void get_IsMasterServerAddress_E5E5A48CB704(){} // RVA: 0x7FFD4F95ECC0
    }

    public class AsyncSetup : Object
    {
        public System.Threading.CancellationTokenSource ÏÌÏÌÏÌÏÏÏÌÏÏÍÍÍÎÎÎÍÎÏÍÌ;

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFD4F95F620
        public void Equals(){} // RVA: 0x7FFD4F95F6D0
        public void GetHashCode(){} // RVA: 0x7FFD4F95F720
        public void Startup(){} // RVA: 0x7FFD4F95F7D0
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void Initialize(){} // RVA: 0x7FFD4F95F820
        public void GetCachedPtr(){} // RVA: 0x7FFD4F95F870
        public void get_name(){} // RVA: 0x7FFD4F95F920
        public void set_name(){} // RVA: 0x7FFD4F95F9D0
        public void .cctor(){} // RVA: 0x7FFD4F95FA20
    }

    public class ConnectionHandler : MonoBehaviour
    {
        public ÏÌÌÎÍÏÏÍÎÍÌÌÏÏÏÏÎÎÌÏÌÎÌ _destroyCancellationToken; // 0x20
        public string _useGUILayout; // 0x28
        public bool f_93B; // 0x30
        public int ÍÍÍÍÏÍÌÌÏÎÏÌÌÏÍÌÍÍÏÍÏÏÎ; // 0x34
        public int <ÏÏÍÎÍÍÏÎÌÏÏÏÍÍÌÏÏÎÌÍÌÌÏ>k__BackingField; // 0x38
        public bool <ÍÎÎÎÌÍÌÎÎÌÍÎÏÏÏÎÌÌÌÏÎÍÏ>k__BackingField; // 0x3C
        public bool ÎÍÌÏÏÌÌÌÎÌÎÍÏÌÍÍÍÍÎÏÎÌÎ;
        public bool ÍÍÎÌÌÌÍÎÎÏÍÏÎÍÍÌÏÍÌÍÍÌÏ; // 0x1
        public bool ÌÏÏÍÎÏÏÎÎÍÍÍÍÏÌÌÌÏÍÌÌÍÏ; // 0x2
        public bool ÎÌÏÏÏÏÎÎÏÍÎÌÌÎÏÎÍÎÌÎÏÏÍ; // 0x3
        public bool ÏÍÍÍÍÍÏÌÎÍÌÏÌÏÏÎÍÌÎÎÎÎÌ; // 0x4
        public bool ÎÏÍÏÎÌÎÎÏÏÌÎÏÍÏÌÎÌÍÍÌÌÎ; // 0x3D
        public bool ÍÍÍÌÏÎÏÍÏÏÌÌÎÏÎÎÎÏÏÍÎÌÌ; // 0x3E
        public int ÌÌÍÌÏÌÎÏÍÎÌÍÌÏÏÎÏÎÌÍÏÏÏ; // 0x40
        public System.Diagnostics.Stopwatch ÎÎÏÏÏÎÎÍÌÏÌÌÎÎÏÎÎÌÍÎÏÏÏ; // 0x48
        public System.Threading.Timer ÍÏÍÌÌÎÍÏÏÏÍÏÌÌÏÎÌÎÍÍÏÏÌ; // 0x50
        public UnityEngine.GameObject ÏÍÏÎÌÎÍÏÏÍÍÌÏÌÍÍÍÏÏÎÏÏÎ; // 0x8

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFD4F992580
        public void RaiseCancellation(){} // RVA: 0x7FFD4F9925C0
        public void IsInvoking(){} // RVA: 0x7FFD4F992600
        public void CancelInvoke(){} // RVA: 0x7FFD4F992710
        public void OnDisable(){} // RVA: 0x7FFD4F992760
        public void InvokeRepeating(){} // RVA: 0x7FFD4F992770
        public void OnDisable_02B3D418FBBF(){} // RVA: 0x7FFD4F9927C0
        public void StaticReset(){} // RVA: 0x7FFD4F992800
        public void StartCoroutine(){} // RVA: 0x7FFD4F9928F0
        public void set_Flags(){} // RVA: 0x7FFD4E9A8350
        public void GetFileLineNumber(){} // RVA: 0x7FFD4E9AA870
        public void .ctor(){} // RVA: 0x7FFD4F9590E0
        public void Initialize(){} // RVA: 0x7FFD4E9A8350
        public void StopCoroutine(){} // RVA: 0x7FFD4F992980
        public void OnEnable(){} // RVA: 0x7FFD4F992DE0
        public void OnApplicationFocus(){} // RVA: 0x7FFD4F992DF0
        public void get_useGUILayout(){} // RVA: 0x7FFD4F992EF0
        public void set_useGUILayout(){} // RVA: 0x7FFD4F992F90
        public void print(){} // RVA: 0x7FFD4E36F0C0
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFD4F993080
        public void get_AllowTransparency(){} // RVA: 0x7FFD4E4A64E0
        public void set_AllowTransparency(){} // RVA: 0x7FFD4E4A64F0
        public void OnApplicationQuit(){} // RVA: 0x7FFD4F993130
        public void Start(){} // RVA: 0x7FFD4E341310
        public void SetCurrentSocket(){} // RVA: 0x7FFD4E36F0D0
        public void StartCoroutineManaged(){} // RVA: 0x7FFD4F993300
        public void OnApplicationPause(){} // RVA: 0x7FFD4F993340
        public void Awake(){} // RVA: 0x7FFD4F993430
        public void OnDestroy(){} // RVA: 0x7FFD4F9934D0
        public void GetScriptClassName(){} // RVA: 0x7FFD4F9936A0
        public void OnCancellationTokenCreated(){} // RVA: 0x7FFD4F9937C0
    }

    public class MatchmakingArguments : ValueType
    {
        public Photon.Realtime.AppSettings UserId; // 0x10
        public int Plugins; // 0x18
        public int CanRejoin; // 0x1C
        public string RoomName; // 0x20
        public int MaxPlayers; // 0x28
        public bool CanOnlyJoin; // 0x2C
        public ÏÌÏÍÎÎÌÏÌÌÎÍÏÏÍÏÌÏÎÍÏÎÎ AsyncConfig; // 0x30
        public ÏÌÌÎÍÏÏÍÎÍÌÌÏÏÏÏÎÎÌÏÌÎÌ NetworkClient; // 0x38
        public ÍÏÍÎÏÍÍÎÏÌÍÎÌÎÏÏÌÌÌÍÎÎÌ AuthValues; // 0x40
        public string PluginName; // 0x48
        public Photon.Realtime.MatchmakingReconnectInformation ReconnectInformation; // 0x50
        public Photon.Client.PhotonHashtable CustomProperties; // 0x58
        public string[] ExpectedUsers; // 0x60
        public ÎÌÌÍÌÎÍÍÎÏÌÌÍÌÎÎÌÎÌÌÍÎÎ Lobby; // 0x68
        public string[] CustomLobbyProperties; // 0x70
        public string SqlLobbyFilter; // 0x78
        public object Ticket; // 0x80
        public 0x66378298 RandomMatchingType; // 0x88
        public ÎÌÏÍÏÍÎÌÏÍÌÎÌÎÎÌÏÌÏÍÍÌÏ CustomRoomOptions; // 0x90
        public System.Nullable`1<bool> IsRoomVisible; // 0x98
        public System.Nullable`1<bool> IsRoomOpen; // 0x9A
        public bool EnableCrc; // 0x9C
        public bool FastReconnectDisabled; // 0x9D

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4F9AC260
        public void ToString(){} // RVA: 0x7FFD4F9AC270
        public void get_Plugins(){} // RVA: 0x7FFD4F9AC6E0
        public void set_Plugins(){} // RVA: 0x7FFD4F9AC770
        public void get_UserId(){} // RVA: 0x7FFD4F9AC260
        public void GetHashCode(){} // RVA: 0x7FFD4F9AC8B0
        public void set_CanRejoin(){} // RVA: 0x7FFD4F9AC910
        public void get_CanRejoin(){} // RVA: 0x7FFD4F9AC970
        public void Initialize(){} // RVA: 0x7FFD4F9AC980
        public void BuildMatchmakingRequest(){} // RVA: 0x7FFD4F9ACAA0
        public void get_CanRejoin_59D3E58587A7(){} // RVA: 0x7FFD4F9AC970
        public void set_UserId(){} // RVA: 0x7FFD4F9ACB00
        public void Create(){} // RVA: 0x7FFD4F9ACC20
        public void OnDestroy(){} // RVA: 0x7FFD4F9ACD60
        public void IsDone(){} // RVA: 0x7FFD4F9ACE80
    }

    public class MatchmakingReconnectInformation : Object
    {
        public string Timeout; // 0x10
        public string HasTimedOut; // 0x18
        public string AppVersion; // 0x20
        public string UserId; // 0x28
        public long TimeoutInTicks; // 0x30
        public System.TimeSpan DefaultTimeout; // 0x38

        // ── Methods ──
        public void get_Timeout(){} // RVA: 0x7FFD4F9ACF10
        public void get_HasTimedOut(){} // RVA: 0x7FFD4F9ACFA0
        public void set_HasTimedOut(){} // RVA: 0x7FFD4F9AD010
        public void IsNativeObjectAlive_2D781DD7C4C1(){} // RVA: 0x7FFD4F9AD2D0 | overloaded x2
        public void ToString(){} // RVA: 0x7FFD4F9AD090
        public void GetCachedPtr(){} // RVA: 0x7FFD4F9AD580
        public void get_name(){} // RVA: 0x7FFD4F9AD620
        public void .ctor(){} // RVA: 0x7FFD4F9AD6F0
        public void Initialize(){} // RVA: 0x7FFD4F9ACF10
        public void Instantiate(){} // RVA: 0x7FFD4F9AD790
        public void set_Timeout(){} // RVA: 0x7FFD4F9AD830
        public void Equals(){} // RVA: 0x7FFD4F9AD8D0
    }

}