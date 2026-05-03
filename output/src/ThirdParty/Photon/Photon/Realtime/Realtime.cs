// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Photon.Photon.Realtime
// Classes: 5
// Methods: 83

namespace ThirdParty.Photon.Photon.Realtime
{
    public class AppSettings : Object
    {
        public string AppIdRealtime; // 0x10
        public string AppIdFusion; // 0x18
        public string AppIdQuantum; // 0x20
        public string AppIdChat; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8280DC60 | overloaded x2
        public void get_IsDefaultNameServer(){} // RVA: 0x7FFE8280DC40
        public void get_IsMasterServerAddress(){} // RVA: 0x7FFE8280DC80
        public void set_IsMasterServerAddress(){} // RVA: 0x7FFE8280DC90
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE8280E0A0
        public void GetCachedPtr(){} // RVA: 0x7FFE8280E2B0
        public void get_name(){} // RVA: 0x7FFE8280E3A0
        public void set_IsBestRegion(){} // RVA: 0x7FFE8280E3E0
        public void get_IsBestRegion(){} // RVA: 0x7FFE8280E4D0
        public void Instantiate(){} // RVA: 0x7FFE8280E4F0
        public void set_IsDefaultPort(){} // RVA: 0x7FFE8280E610
        public void get_IsDefaultPort(){} // RVA: 0x7FFE8280E820
        public void Equals(){} // RVA: 0x7FFE8280E830
        public void GetHashCode(){} // RVA: 0x7FFE8280E4D0
        public void ToString(){} // RVA: 0x7FFE8280F1F0
        // ── Unresolved (hash) ──
        public void m_8C6(){} // RVA: 0x7FFE8280DC90
    }

    public class AsyncSetup : Object
    {
        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE8280F260
        public void Equals(){} // RVA: 0x7FFE8280F2B0
        public void GetHashCode(){} // RVA: 0x7FFE8280F360
        public void op_Implicit(){} // RVA: 0x7FFE8280F3B0
        public void CompareBaseObjects(){} // RVA: 0x7FFE8280F460
        public void Startup(){} // RVA: 0x7FFE8280F4B0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Initialize(){} // RVA: 0x7FFE8280F500
        public void .cctor(){} // RVA: 0x7FFE8280F5B0
    }

    public class ConnectionHandler : MonoBehaviour
    {
        public ÏÍÍÏÌÍÎÎÎÏÌÏÌÎÏÏÍÌÌÏÌÍÍ _m_CancellationTokenSource; // 0x20
        public string f_392; // 0x28
        public bool f_3EB; // 0x30

        // ── Methods ──
        public void OnApplicationFocus(){} // RVA: 0x7FFE82841BD0
        public void RaiseCancellation(){} // RVA: 0x7FFE82841CD0
        public void IsInvoking(){} // RVA: 0x7FFE82841D60
        public void CancelInvoke(){} // RVA: 0x7FFE828421C0
        public void OnApplicationPause(){} // RVA: 0x7FFE828422E0
        public void InvokeRepeating(){} // RVA: 0x7FFE811290C0
        public void OnBecameVisible(){} // RVA: 0x7FFE828423D0
        public void OnDisable(){} // RVA: 0x7FFE82842410
        public void .ctor(){} // RVA: 0x7FFE828084B0
        public void Initialize(){} // RVA: 0x7FFE82842420
        public void StartCoroutine(){} // RVA: 0x7FFE812604F0
        public void StartCoroutine_Auto(){} // RVA: 0x7FFE828425F0
        public void Awake(){} // RVA: 0x7FFE828426A0
        public void OnDestroy(){} // RVA: 0x7FFE82842740
        public void StopCoroutine(){} // RVA: 0x7FFE811290D0
        public void StopAllCoroutines(){} // RVA: 0x7FFE81D46090
        public void get_useGUILayout(){} // RVA: 0x7FFE812604E0
        public void set_useGUILayout(){} // RVA: 0x7FFE82842750
        public void print(){} // RVA: 0x7FFE82842870
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFE828428C0
        public void Internal_IsInvokingAll(){} // RVA: 0x7FFE812604E0
        public void OnEnable(){} // RVA: 0x7FFE82842900
        public void OnApplicationQuit(){} // RVA: 0x7FFE811290C0
        public void StaticReset(){} // RVA: 0x7FFE82842910
        public void IsObjectMonoBehaviour(){} // RVA: 0x7FFE82842A00
        public void StartCoroutineManaged(){} // RVA: 0x7FFE81D46A00
        public void StartCoroutineManaged2(){} // RVA: 0x7FFE82842E60
        public void StopCoroutineManaged(){} // RVA: 0x7FFE82842EA0
        public void Start(){} // RVA: 0x7FFE810FB310
    }

    public class MatchmakingArguments : ValueType
    {
        public Photon.Realtime.AppSettings PhotonSettings; // 0x10
        public int PlayerTtlInSeconds; // 0x18
        public int EmptyRoomTtlInSeconds; // 0x1C

        // ── Methods ──
        public void get_UserId(){} // RVA: 0x7FFE82859A50
        public void InternalEquals(){} // RVA: 0x7FFE82859A60
        public void set_UserId(){} // RVA: 0x7FFE82859AC0
        public void Equals(){} // RVA: 0x7FFE82859BE0
        public void set_CanRejoin(){} // RVA: 0x7FFE82859C40
        public void get_CanRejoin(){} // RVA: 0x7FFE82859CD0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFE82859CE0
        public void ToString(){} // RVA: 0x7FFE82859D40
        public void GetHashCode(){} // RVA: 0x7FFE82859A50
        public void set_Plugins(){} // RVA: 0x7FFE82859CD0
        public void get_Plugins(){} // RVA: 0x7FFE8285A1B0
        public void set_UserId_AECCE05CDCE8(){} // RVA: 0x7FFE8285A240
        public void Create(){} // RVA: 0x7FFE82859A50
        public void OnDestroy(){} // RVA: 0x7FFE8285A2A0
    }

    public class MatchmakingReconnectInformation : Object
    {
        public string Room; // 0x10
        public string Region; // 0x18

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE8285A3E0
        public void op_Implicit(){} // RVA: 0x7FFE8285A6A0 | overloaded x2
        public void ToString(){} // RVA: 0x7FFE8285A460
        public void CompareBaseObjects(){} // RVA: 0x7FFE8285A8E0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE8285A970
        public void GetCachedPtr(){} // RVA: 0x7FFE8285ABB0
        public void get_Timeout(){} // RVA: 0x7FFE8285A8E0
        public void set_Timeout(){} // RVA: 0x7FFE8285AC50
        public void Instantiate(){} // RVA: 0x7FFE8285A8E0
        public void set_HasTimedOut(){} // RVA: 0x7FFE8285ACF0
        public void get_HasTimedOut(){} // RVA: 0x7FFE8285AD00
        public void .ctor(){} // RVA: 0x7FFE8285AD70
        public void Initialize(){} // RVA: 0x7FFE8285AE10
    }

}