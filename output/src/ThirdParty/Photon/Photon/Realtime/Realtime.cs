// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Photon.Photon.Realtime
// Classes: 5
// Methods: 85

namespace ThirdParty.Photon.Photon.Realtime
{
    public class AppSettings
    {
        public string BodyState; // 0x10
        public string BodyJointLocation[]; // 0x18
        public string AppIdQuantum; // 0x20
        public string AppIdChat; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x1A8B7C0 | overloaded x2
        public void Initialize(){} // RVA: 0x1A8A370
        public void set_IsMasterServerAddress(){} // RVA: 0x1A8A780
        public void get_IsMasterServerAddress(){} // RVA: 0x1A8A7A0
        public void .ctor_325BD2B7D2DC(){} // RVA: 0x1A8A7B0
        public void get_IsMasterServerAddress_A5BBBE205B73(){} // RVA: 0x1A8A370
        public void set_IsMasterServerAddress_BD58DB49593C(){} // RVA: 0x1A8A8D0
        public void set_IsDefaultPort(){} // RVA: 0x1A8A9F0
        public void set_IsDefaultNameServer(){} // RVA: 0x1A8AA30
        public void Instantiate(){} // RVA: 0x1A8AAA0
        public void Equals(){} // RVA: 0x1A8AAE0
        public void get_IsDefaultPort(){} // RVA: 0x1A8B4A0
        public void get_IsDefaultNameServer(){} // RVA: 0x1A8A780
        public void set_IsBestRegion(){} // RVA: 0x1A8B4B0
        public void .ctor_FB5F1861FC47(){} // RVA: 0x1A8B6C0
        public void Initialize_745A2886A994(){} // RVA: 0x1A8B7B0
        public void get_IsBestRegion(){} // RVA: 0x1A8B7F0
    }

    public class AsyncSetup
    {
        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x1A8B810
        public void Equals(){} // RVA: 0x1A8B8C0
        public void Startup(){} // RVA: 0x1A8B970
        public void Startup_7F487F582145(){} // RVA: 0x1A8B9C0
        public void .ctor_69C1E711B8F2(){} // RVA: 0x1A8BA70
        public void Initialize(){} // RVA: 0x1A8BB20
        public void GetCachedPtr(){} // RVA: 0x1A8BB70
        public void .cctor(){} // RVA: 0x1A8BC60
        public void .ctor(){} // RVA: 0x2DD310
        public void Preserve(){} // RVA: 0x1A8BD30
        public void Preserve_FBAFD50B4AE8(){} // RVA: 0x1A8BDE0
    }

    public class ConnectionHandler
    {
        public ÎÎÌÏÎÏÏÎÍÎÏÍÎÎÎÍÎÏÏÌÎÎÍ <ÏÍÍÌÏÌÏÏÌÎÌÍÏÌÍÎÎÎÎÌÏÎÎ>k__BackingField; // 0x20
        public string ÏÌÏÌÎÌÎÌÏÏÎÏÍÍÍÍÍÏÌÍÏÏÍ; // 0x28
        public bool ÎÎÍÌÎÎÏÎÏÍÏÌÎÎÌÎÌÏÎÏÌÏÏ; // 0x30

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x1ABF230
        public void RaiseCancellation(){} // RVA: 0x1ABF2E0
        public void IsInvoking(){} // RVA: 0x1ABF230
        public void CancelInvoke(){} // RVA: 0x1ABF390
        public void OnDisable_58F1A0951E0D(){} // RVA: 0x1ABF420
        public void InvokeRepeating(){} // RVA: 0x1ABF470
        public void OnApplicationQuit(){} // RVA: 0xFDC9F0
        public void StaticReset_C7D69B7A45A1(){} // RVA: 0x30B0C0
        public void StartCoroutine(){} // RVA: 0x1ABF570
        public void set_Flags(){} // RVA: 0x1ABF5B0
        public void OnApplicationFocus(){} // RVA: 0x1ABF5C0
        public void OnApplicationPause(){} // RVA: 0x1ABF6C0
        public void Initialize(){} // RVA: 0x1ABF7B0
        public void StopCoroutine(){} // RVA: 0xFDD6E0
        public void OnEnable(){} // RVA: 0x1ABF7F0
        public void OnApplicationFocus_DBFB237D9396(){} // RVA: 0x4424E0
        public void Start(){} // RVA: 0x2DD310
        public void set_useGUILayout(){} // RVA: 0x1ABF800
        public void OnDisable(){} // RVA: 0x1ABF840
        public void Internal_CancelInvokeAll(){} // RVA: 0x30B0D0
        public void get_AllowTransparency(){} // RVA: 0x1ABF850
        public void set_AllowTransparency(){} // RVA: 0x1ABF890
        public void StaticReset(){} // RVA: 0x1ABF9B0
        public void Start_B1660ED0300C(){} // RVA: 0x1ABFAA0
        public void Awake(){} // RVA: 0x1ABFC70
        public void OnDestroy(){} // RVA: 0x1ABFD10
        public void OnApplicationPause_ACD83B3D78DA(){} // RVA: 0x4424F0
        public void Awake_572F3F2743B0(){} // RVA: 0x1ABFDB0
        public void .ctor(){} // RVA: 0x1A848F0
    }

    public class MatchmakingArguments
    {
        public Photon.Realtime.AppSettings Timeout; // 0x10
        public int HasTimedOut; // 0x18
        public int EmptyRoomTtlInSeconds; // 0x1C

        // ── Methods ──
        public void set_Plugins(){} // RVA: 0x1ADB180
        public void ToString_AFCA245079DF(){} // RVA: 0x1ADB190
        public void get_Plugins_898A05103153(){} // RVA: 0x1ADB2D0
        public void get_Plugins(){} // RVA: 0x1ADB330
        public void get_UserId_0D44984C25CC(){} // RVA: 0x1ADB3C0
        public void set_CanRejoin(){} // RVA: 0x1ADB4E0
        public void get_UserId(){} // RVA: 0x1ADB180
        public void set_UserId(){} // RVA: 0x1ADB5C0
        public void Initialize(){} // RVA: 0x1ADB6E0
        public void get_CanRejoin(){} // RVA: 0x1ADB820
        public void ToString(){} // RVA: 0x1ADB830
        public void set_UserId_4DC423E97757(){} // RVA: 0x1ADB180
        public void Create(){} // RVA: 0x1ADBCA0
    }

    public class MatchmakingReconnectInformation
    {
        public string Room; // 0x10
        public string Region; // 0x18

        // ── Methods ──
        public void get_Timeout_0D7BEB6F7E02(){} // RVA: 0x1ADBD00
        public void set_HasTimedOut(){} // RVA: 0x1ADBD90
        public void IsNativeObjectAlive(){} // RVA: 0x1ADBE40
        public void ToString_CF3C4C0F0CAD(){} // RVA: 0x1ADBE30
        public void get_HasTimedOut(){} // RVA: 0x1ADBEE0
        public void GetCachedPtr(){} // RVA: 0x1ADBF50
        public void get_name(){} // RVA: 0x1ADBE30
        public void .ctor(){} // RVA: 0x1ADBFC0
        public void get_Timeout(){} // RVA: 0x1ADBD00
        public void Instantiate(){} // RVA: 0x1ADC060
        public void ToString(){} // RVA: 0x1ADC380
        public void set_Timeout(){} // RVA: 0x1ADC5C0
        // ── Unresolved (hash) ──
        public void m_C01(){} // RVA: 0x1ADC0D0
    }

}