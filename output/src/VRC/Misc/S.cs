// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Misc
// Classes: 22
// Methods: 296

namespace VRC.Misc
{
    /// <summary>Originally: ÌÎÎÌÌÍÎÌÏÌÍÍÏÎÍÍÎÍÎÎÎÎÍ</summary>
    public class SelectHandler_2312_2312 : MonoBehaviour
    {
        public string _destroyCancellationToken;
        public float _useGUILayout;
        public bool f_064; // 0x8
        public int f_AD2;
        public System.Threading.SemaphoreSlim f_732; // 0x10
        public float f_3BD; // 0x20
        public int f_B2C; // 0x24
        public string f_9F9; // 0x28
        public 0x6B0B3F20 f_4A3; // 0x30
        public int f_D4A; // 0x34
        public string f_BDC; // 0x38
        public string f_DA7; // 0x40
        public bool f_928; // 0x48
        public bool f_970; // 0x49
        public bool f_8D0; // 0x4A
        public bool f_ABC; // 0x4B
        public bool <ÌÍÍÏÍÏÎÏÌÍÏÌÏÍÏÏÏÌÎÏÏÌÎ>k__BackingField; // 0x4C
        public string <ÍÌÌÍÍÍÎÏÏÌÍÌÎÎÏÍÍÏÏÏÌÌÎ>k__BackingField; // 0x50
        public ÌÌÎÎÍÎÏÎÏÎÎÎÌÏÎÏÌÌÌÎÏÍÍ _selector; // 0x58
        public UnityEngine.GameObject clElements; // 0x60
        public UnityEngine.GameObject invalidDestinationElements; // 0x68
        public UnityEngine.GameObject proximityDestinationElements; // 0x70
        public UnityEngine.Texture2D _warningBannerTexture; // 0x78
        public UnityEngine.GameObject[] _disableOnShutdown; // 0x80
        public UnityEngine.Shader MobileOpaqueShader; // 0x88
        public ÍÍÎÌÍÏÍÏÎÏÎÍÏÏÍÎÍÎÌÍÏÍÌ cosmeticsHandler; // 0x90
        public ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ _worldText; // 0x98
        public ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ _ownerText; // 0xA0
        public ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ _accessText; // 0xA8
        public ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ _groupText; // 0xB0
        public ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ _ageGateText; // 0xB8
        public ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ _playerCountText; // 0xC0
        public ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ _timerText; // 0xC8
        public ÌÌÍÎÌÍÌÌÌÌÏÎÎÏÌÏÏÌÎÌÏÏÎ _platformIcons; // 0xD0
        public ÍÏÌÎÍÌÎÍÏÎÌÌÎÍÍÌÏÏÍÎÌÌÍ ÍÎÎÍÍÎÍÌÍÎÍÎÏÍÎÏÏÎÎÏÍÏÍ; // 0xD8
        public VRC.SDKBase.VRC_PortalMarker ÏÌÍÌÌÍÌÍÍÌÍÍÎÏÌÌÍÎÎÌÍÏÏ; // 0xE0
        public VRC.Core.ApiWorld ÍÎÍÌÍÏÏÏÎÎÌÎÌÍÌÌÏÎÍÌÍÌÏ; // 0xE8
        public VRC.Core.ApiWorld ÌÍÍÍÌÎÌÌÍÌÏÏÏÌÌÏÍÍÏÎÎÌÌ; // 0xF0
        public VRC.Core.ApiWorldInstance ÍÏÍÎÍÎÍÍÏÏÏÏÌÎÍÏÌÌÏÎÍÍÎ; // 0xF8
        public UnityEngine.Vector2 ÏÏÍÏÏÍÌÎÏÎÎÍÎÌÍÏÏÏÌÎÌÎÍ; // 0x100
        public string ÌÌÏÍÍÎÎÌÌÍÏÍÍÎÍÌÍÎÌÎÍÌÎ; // 0x108
        public int ÌÏÌÍÍÏÏÍÌÏÌÌÍÍÎÍÎÍÏÏÌÍÎ; // 0x110
        public bool ÍÌÌÌÏÍÍÍÏÎÍÎÎÌÎÏÌÌÍÌÏÎÍ; // 0x114
        public float ÍÎÎÌÎÎÍÍÍÌÏÍÎÎÍÌÏÎÏÌÎÎÎ; // 0x118
        public float ÌÌÎÍÌÏÎÍÎÌÎÏÍÍÍÍÌÎÌÎÏÌÍ; // 0x11C
        public bool ÍÏÌÎÎÌÍÏÎÏÏÏÍÎÏÌÏÌÍÌÎÌÌ; // 0x120
        public bool ÏÎÏÌÎÌÌÎÎÍÏÏÎÍÍÎÎÍÌÎÌÌÏ; // 0x121
        public bool ÏÎÎÏÏÍÍÎÍÎÌÍÏÎÏÌÌÏÍÍÍÌÏ; // 0x122
        public bool ÌÎÍÍÌÏÎÌÏÎÎÍÏÌÏÎÎÎÍÍÌÎÎ; // 0x123
        public UnityEngine.BoxCollider ÌÌÎÏÍÎÍÏÎÏÏÎÌÍÍÎÌÎÌÏÍÏÍ; // 0x128
        public bool ÍÌÌÏÎÍÏÎÍÏÏÌÏÎÎÏÌÎÌÍÎÎÍ; // 0x130
        public System.Action ÌÍÎÏÏÍÏÌÌÏÍÌÎÍÍÏÌÌÎÏÍÎÍ; // 0x138
        public string ÍÎÍÌÍÎÎÌÏÏÎÏÏÎÍÎÍÌÏÌÍÏÎ; // 0x140
        public string ÏÌÎÌÎÎÌÍÍÏÍÎÎÌÎÍÌÍÎÍÍÏÍ; // 0x148
        public UnityEngine.Renderer[] ÏÏÍÌÎÍÎÍÍÎÏÍÍÎÎÌÎÏÏÌÌÎÎ; // 0x150
        public UnityEngine.Collider[] ÌÍÏÌÍÍÏÌÌÌÍÎÎÍÌÌÎÍÍÌÏÏÍ; // 0x158
        public System.Threading.CancellationToken ÏÍÎÌÌÏÍÍÌÍÎÎÍÍÏÏÏÍÌÍÌÍÏ; // 0x160
        public string ÏÍÏÌÎÎÌÏÌÍÏÎÎÌÍÍÏÏÎÌÎÎÍ; // 0x168
        public bool ÏÎÍÎÏÍÍÎÌÏÏÎÎÎÏÏÍÌÎÍÏÌÍ; // 0x170
        public bool ÌÏÏÏÍÏÎÏÍÌÎÌÍÎÏÏÎÏÏÏÏÍÌ; // 0x171
        public ÌÌÍÎÎÌÌÌÌÍÍÏÌÍÍÎÍÏÌÏÏÌÏ ÌÍÍÏÌÎÌÏÎÏÍÌÍÏÎÏÏÌÍÍÏÍÏ; // 0x178

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFAC4163690
        public void RaiseCancellation(){} // RVA: 0x7FFAC4163F50
        public void GetNetworkCallingMetadata(){} // RVA: 0x7FFAC2FE9500
        public void SetPoseTracking(){} // RVA: 0x7FFAC4164B40
        public void Invoke_9A8BB4C9F7FF_9A8BB4C9F7FF(){} // RVA: 0x7FFAC4168DB0 | overloaded x2
        public void set_ValidatingStreamVersion(){} // RVA: 0x7FFAC2F7CCE0
        public void CancelInvoke(){} // RVA: 0x7FFAC41652A0
        public void IsInvoking(){} // RVA: 0x7FFAC41652F0
        public void StartCoroutine(){} // RVA: 0x7FFAC4165300
        public void ToString(){} // RVA: 0x7FFAC41654E0
        public void get_AllowWriteStreamBuffering(){} // RVA: 0x7FFAC41656F0
        public void StartCoroutine_Auto(){} // RVA: 0x7FFAC4165700
        public void StopCoroutine(){} // RVA: 0x7FFAC4165960
        public void StopCoroutine_B7BB10CD0DBA(){} // RVA: 0x7FFAC41659C0
        public void InitializeAndRetrieveExternalData(){} // RVA: 0x7FFAC4165B70
        public void StopAllCoroutines(){} // RVA: 0x7FFAC4165D30
        public void get_useGUILayout(){} // RVA: 0x7FFAC4165E80
        public void set_useGUILayout(){} // RVA: 0x7FFAC4166030
        public void Awake(){} // RVA: 0x7FFAC41660D0
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFAC4166B40
        public void Internal_IsInvokingAll(){} // RVA: 0x7FFAC4166CD0
        public void InvokeDelayed(){} // RVA: 0x7FFAC41670C0
        public void SetInputSource(){} // RVA: 0x7FFAC41674D0
        public void GetSessionId(){} // RVA: 0x7FFAC31D0140
        public void IsObjectMonoBehaviour(){} // RVA: 0x7FFAC41674E0
        public void .cctor(){} // RVA: 0x7FFAC41676D0
        public void StartCoroutineManaged2(){} // RVA: 0x7FFAC41677B0
        public void .ctor(){} // RVA: 0x7FFAC4167850
        public void Initialize(){} // RVA: 0x7FFAC4167940
        public void GetScriptClassName(){} // RVA: 0x7FFAC4167AB0
        public void OnCancellationTokenCreated(){} // RVA: 0x7FFAC4167C70
        public void OnCollisionStay(){} // RVA: 0x7FFAC4167E30
        public void OnCollisionExit(){} // RVA: 0x7FFAC4167EF0
        public void OnTriggerEnter(){} // RVA: 0x7FFAC4167FE0
        public void OnTriggerStay(){} // RVA: 0x7FFAC41652F0
        public void SetModelAlphaBlendShader(){} // RVA: 0x7FFAC30794D0
        public void SetSelectionState(){} // RVA: 0x7FFAC4168010
        public void get_preferredMaximumResolution(){} // RVA: 0x7FFAC3921980
        public void CancelSelection(){} // RVA: 0x7FFAC4168100
        public void EvaluatePlayerInteractivePickupUseDown(){} // RVA: 0x7FFAC4168370
        public void SetOverlay(){} // RVA: 0x7FFAC2F49200
        public void GetDataCount(){} // RVA: 0x7FFAC2F7CCD0
        public void get_AddressResolvedAsIpv6(){} // RVA: 0x7FFAC4168960
        public void get_rebuildTargetParent(){} // RVA: 0x7FFAC2F8C660
        public void get_AddressResolvedAsIpv6_42C5A90CB4BD(){} // RVA: 0x7FFAC4168970
        public void get_AddressResolvedAsIpv6_0DB9085D4A5B(){} // RVA: 0x7FFAC4168A10
        public void OnCollisionStay_60A735C6AA3E(){} // RVA: 0x7FFAC4167E30
        public void __op_Inequality__VRCSDK3DataDataTokenRef_SystemInt16Ref__SystemBoolean(){} // RVA: 0x7FFAC4168B10
        public void UpdateSelection(){} // RVA: 0x7FFAC4168C00
        public void get_gameObject(){} // RVA: 0x7FFAC4169DE0
        public void get_alreadySelecting(){} // RVA: 0x7FFAC3E0F350
        public void SelectPrevious(){} // RVA: 0x7FFAC416A190
        public void GetGameObject_3FF(){} // RVA: 0x7FFAC416A570
        public void CreateSelectionIndicator(){} // RVA: 0x7FFAC416A590
        public void set_DebounceTimeError(){} // RVA: 0x7FFAC416A6E0
        public void UpdatepositionInj(){} // RVA: 0x7FFAC2F21320
        public void set_element(){} // RVA: 0x7FFAC31D0C20
        public void set_AddressResolvedAsIpv6(){} // RVA: 0x7FFAC416A6F0
        public void ResolveGameObject(){} // RVA: 0x7FFAC416A700
        public void get_preferredPeakBitRateUnits(){} // RVA: 0x7FFAC3ADEDC0
        public void ParseStandardFormat(){} // RVA: 0x7FFAC416A8A0
        public void set_AllowAutoRedirect(){} // RVA: 0x7FFAC3E0F360
        public void Initialize_C32E8D06C79E(){} // RVA: 0x7FFAC416A940
        public void AddSubtraction(){} // RVA: 0x7FFAC2F22E90
        public void get_gameObject_1FE075D885FF(){} // RVA: 0x7FFAC416ABE0
        public void OnEnable(){} // RVA: 0x7FFAC416A6E0
        public void OnCancellationTokenCreated_80DC8D9F68CF(){} // RVA: 0x7FFAC416AFE0
        public void OnSelect(){} // RVA: 0x7FFAC416AFF0
        public void GetLanguage(){} // RVA: 0x7FFAC2F4F130
        public void LateUpdate(){} // RVA: 0x7FFAC416B1E0
        public void OnDisable(){} // RVA: 0x7FFAC416B210
        public void OnDestroy(){} // RVA: 0x7FFAC416B300
        public void Start(){} // RVA: 0x7FFAC416B4E0
        public void Update(){} // RVA: 0x7FFAC416B580
        public void OnBecameVisible(){} // RVA: 0x7FFAC416B990
        public void OnBecameInvisible(){} // RVA: 0x7FFAC416BB00
        public void GetIKSolver(){} // RVA: 0x7FFAC2FC20E0
        public void SelectNext(){} // RVA: 0x7FFAC416BB10
        public void GetBufferedTimes(){} // RVA: 0x7FFAC2F9E740
    }

    /// <summary>Originally: ÍÏÌÏÍÏÏÎÎÎÎÎÏÏÏÍÏÏÍÎÎÍÍ</summary>
    public class Select_5B7F_5B7F : Button
    {
        // ── Methods ──
        public void OnSelect(){} // RVA: 0x7FFAC42D93B0
        public void .ctor(){} // RVA: 0x7FFAC42D9430
    }

    /// <summary>Originally: ÍÏÍÎÏÍÎÌÌÌÏÍÎÍÏÏÏÎÌÏÎÏÎ</summary>
    public class SerializableVector3SiblingSiblSibling_7E89 : ValueType
    {
        public System.Nullable`1<ÎÏÌÎÍÏÌÎÎÎÌÌÍÍÌÎÍÌÎÌÏÌÏ> f_E5F; // 0x10
        public 0x6B0E5B40 f_088; // 0x58

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC2FC20C0
        public void InternalEquals(){} // RVA: 0x7FFAC2FC20D0
        public void DefaultEquals(){} // RVA: 0x7FFAC4AD7000
        public void GetHashCode(){} // RVA: 0x7FFAC4AD7000
        public void InternalGetHashCode(){} // RVA: 0x7FFAC4AD6F80
        public void ToString(){} // RVA: 0x7FFAC2FC20D0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC2FC20C0
        // ── Unresolved (hash) ──
        public void m_8D0(){} // RVA: 0x7FFAC2FC20C0
        public void m_8A2(){} // RVA: 0x7FFAC4AD6F80
    }

    /// <summary>Originally: ÏÎÏÏÏÏÍÎÏÍÌÍÍÎÍÏÌÌÏÎÌÍÎ</summary>
    public class SerializableVector3SiblingSiblSibling_D520 : ValueType
    {
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ f_FE2; // 0x10
        public 0x6B0E5B40 f_088; // 0x18

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC38DFE40
        public void InternalEquals(){} // RVA: 0x7FFAC38DFE40
        public void DefaultEquals(){} // RVA: 0x7FFAC3AD9F60
        public void GetHashCode(){} // RVA: 0x7FFAC49C7500
        public void InternalGetHashCode(){} // RVA: 0x7FFAC49C7500
        public void ToString(){} // RVA: 0x7FFAC49C7500
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC49C7500
        // ── Unresolved (hash) ──
        public void m_872(){} // RVA: 0x7FFAC3AD9F60
        public void m_6E2(){} // RVA: 0x7FFAC38DFE40
        public void m_FC7(){} // RVA: 0x7FFAC49C7510
    }

    /// <summary>Originally: ÍÍÌÎÌÏÌÍÎÍÏÍÌÍÎÏÌÍÍÍÎÌÏ</summary>
    public class SerializableVector3SiblingSibling_076E : ValueType
    {
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ f_FE2; // 0x10
        public 0x6B0E5B40 f_088; // 0x18

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC38DFE40
        public void InternalEquals(){} // RVA: 0x7FFAC49C7500
        public void DefaultEquals(){} // RVA: 0x7FFAC38DFE40
        public void GetHashCode(){} // RVA: 0x7FFAC49C7510
        public void InternalGetHashCode(){} // RVA: 0x7FFAC49C7500
        public void ToString(){} // RVA: 0x7FFAC3AD9F60
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC49C7510
        // ── Unresolved (hash) ──
        public void m_FC7(){} // RVA: 0x7FFAC49C7510
        public void m_067(){} // RVA: 0x7FFAC3AD9F60
        public void m_872(){} // RVA: 0x7FFAC3AD9F60
    }

    /// <summary>Originally: ÎÍÌÏÏÌÎÍÎÍÌÎÎÍÍÏÎÎÍÏÍÌÍ</summary>
    public class SerializableVector3Sibling_01A0_01A0 : ValueType
    {
        public int _01A0; // 0x10

        // ── Methods ──
        public void ToHashCode(){} // RVA: 0x7FFAC4420210
        public void InternalEquals(){} // RVA: 0x7FFAC4420210
        public void DefaultEquals(){} // RVA: 0x7FFAC4420210
        public void .ctor(){} // RVA: 0x7FFAC44210E0 | overloaded x2
        public void Initialize(){} // RVA: 0x7FFAC4420210
        public void Equals(){} // RVA: 0x7FFAC4420210
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC4420210
        public void GetHashCode(){} // RVA: 0x7FFAC4420210
    }

    /// <summary>Originally: ÌÌÎÏÍÌÌÌÌÌÌÏÌÍÍÎÎÌÎÏÌÏÌ</summary>
    public class SerializableVector3Sibling_041B : ValueType
    {
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ f_FE2; // 0x10
        public ÎÍÌÎÍÏÌÌÎÎÍÎÌÏÍÌÌÌÎÍÎÏÏ f_087; // 0x18

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC4A25A90
        public void InternalEquals(){} // RVA: 0x7FFAC4A25B10
        public void DefaultEquals(){} // RVA: 0x7FFAC38DFE40
        public void GetHashCode(){} // RVA: 0x7FFAC38DFE40
        public void InternalGetHashCode(){} // RVA: 0x7FFAC4A25B10
        public void ToString(){} // RVA: 0x7FFAC4A25A90
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC4A25B10
        // ── Unresolved (hash) ──
        public void m_C34(){} // RVA: 0x7FFAC3AD9F60
        public void m_EF6(){} // RVA: 0x7FFAC4A25B10
        public void m_668(){} // RVA: 0x7FFAC4A25B10
        public void m_872(){} // RVA: 0x7FFAC3AD9F60
        public void m_1C4(){} // RVA: 0x7FFAC38DFE40
    }

    /// <summary>Originally: ÎÎÎÌÎÏÏÎÍÎÍÏÎÏÏÏÍÌÏÎÏÎÏ</summary>
    public class ServerTimeManager_7D26 : Object
    {
        public object _serverTimeUtc;

        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFAC3E185A0
        public void Shutdown(){} // RVA: 0x7FFAC3E185F0
        public void Register(){} // RVA: 0x7FFAC3E18640
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Unregister(){} // RVA: 0x7FFAC3E18690
        public void get_ServerTimeUtc(){} // RVA: 0x7FFAC3E186E0
        public void set_ServerTimeUtc(){} // RVA: 0x7FFAC3E18730
    }

    /// <summary>Originally: ÍÏÍÌÏÍÏÌÌÏÍÍÍÎÎÎÌÏÌÎÏÌÍ</summary>
    public class SetActionBinding_DB55_DB55 : MonoBehaviour
    {
        public UnityEngine.GameObject ÎÍÏÎÎÏÌÍÍÌÍÏÌÏÍÌÍÍÌÎÍÌÏ; // 0x20
        public ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ ÌÏÏÍÌÏÍÌÍÎÍÍÍÏÌÎÏÍÎÍÍÎÍ; // 0x28
        public System.Action ÎÍÎÍÎÎÏÎÏÏÍÌÎÍÎÍÎÌÏÏÎÌÌ; // 0x30
        public 0x6AFFF488 ÍÏÍÌÌÏÍÏÎÌÍÎÍÏÌÎÎÍÏÏÌÎÏ; // 0x38

        // ── Methods ──
        public void GetFileLineNumber(){} // RVA: 0x7FFAC358A870
        public void RaiseCancellation(){} // RVA: 0x7FFAC358A870
        public void Interact(){} // RVA: 0x7FFAC426ACB0
        public void SetActionBinding(){} // RVA: 0x7FFAC426B100 | overloaded x2
        public void AddUnitNode(){} // RVA: 0x7FFAC2F4F890
        public void InvokeRepeating(){} // RVA: 0x7FFAC426AF30
        public void IsInvoking(){} // RVA: 0x7FFAC426B110
        public void StartCoroutine(){} // RVA: 0x7FFAC426B100
        public void AddUnitNode_38A58D617B78(){} // RVA: 0x7FFAC2F4F890
        public void StartCoroutine_A2719F5AD237(){} // RVA: 0x7FFAC426B490
        public void StartCoroutine_Auto(){} // RVA: 0x7FFAC2F4F890
        public void StopCoroutine(){} // RVA: 0x7FFAC426B5C0
        public void GetFileLineNumber_BEDCD61D624D(){} // RVA: 0x7FFAC358A870
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void Initialize(){} // RVA: 0x7FFAC426B7B0
    }

    /// <summary>Originally: ÎÏÍÍÍÍÏÎÏÏÍÍÍÍÏÌÏÍÍÌÌÎÌ</summary>
    public class SetEnableComponent_A1A6_A1A6 : MonoBehaviour
    {
        public UnityEngine.UI.Toggle ÎÍÌÏÎÍÌÍÎÎÌÌÍÎÌÏÎÏÌÎÏÌÎ; // 0x20
        public bool ÎÍÌÏÏÎÍÌÌÏÎÍÏÍÎÏÌÎÎÍÎÏÏ; // 0x28

        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFAC42E7390
        public void OnDisable(){} // RVA: 0x7FFAC42E7580
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void Initialize(){} // RVA: 0x7FFAC42E7770
        public void SetEnable(){} // RVA: 0x7FFAC42E7960
        public void InvokeRepeating(){} // RVA: 0x7FFAC42E7A20
        public void CancelInvoke(){} // RVA: 0x7FFAC42E7AE0
        public void IsInvoking(){} // RVA: 0x7FFAC42E7CD0
        public void StartCoroutine(){} // RVA: 0x7FFAC42E7D90
    }

    /// <summary>Originally: ÎÎÍÎÎÌÌÍÌÍÏÎÍÏÌÍÍÏÌÏÎÎÌ</summary>
    public class SetEnableComponent_A8E1_A8E1 : MonoBehaviour
    {
        public 0x6AFFF748 ÍÎÏÏÌÏÍÏÍÍÏÏÎÎÎÌÏÎÎÎÍÎÌ; // 0x20
        public 0x6AFFF748[] ÎÎÎÎÏÏÎÌÍÏÌÍÎÎÍÏÌÍÍÏÌÌÎ; // 0x28
        public UnityEngine.UI.Toggle ÎÍÌÏÎÍÌÍÎÎÌÌÍÎÌÏÎÏÌÎÏÌÎ; // 0x30
        public UnityEngine.GameObject ÍÍÎÌÍÏÎÏÎÌÎÏÌÍÎÌÏÏÏÌÍÍÌ; // 0x38

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFAC42E7F80
        public void RaiseCancellation(){} // RVA: 0x7FFAC42E7FF0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void OnEnable(){} // RVA: 0x7FFAC42E8060
        public void OnDisable(){} // RVA: 0x7FFAC42E8490
        public void SetEnable(){} // RVA: 0x7FFAC42E88A0
        public void CancelInvoke(){} // RVA: 0x7FFAC42E8910
        public void IsInvoking(){} // RVA: 0x7FFAC42E8D10
        public void StartCoroutine(){} // RVA: 0x7FFAC42E8D80
    }

    /// <summary>Originally: ÍÍÎÏÎÏÍÍÌÏÏÍÍÍÏÌÏÍÌÏÌÌÎ</summary>
    public class SetLayoutHorizontalSImpl_145F_145F : SetLayoutHorizontalSetLayoutVertical_645E_645E
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACB830B10
        public void Initialize(){} // RVA: 0x7FFACB830B20
    }

    /// <summary>Originally: ÏÍÎÎÌÌÍÍÎÍÎÎÎÎÍÎÍÍÏÌÎÍÎ</summary>
    public class SetLayoutHorizontalSImpl_61AF_61AF : SetLayoutHorizontalSetLayoutVertical_645E_645E
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACB830B10
        public void Initialize(){} // RVA: 0x7FFACB830B60
    }

    /// <summary>Originally: ÏÍÎÏÌÏÍÏÌÌÍÏÏÍÍÌÍÏÎÍÍÌÏ</summary>
    public class SetLayoutHorizontalSetLayoutVertical_07A6_07A6 : ContentSizeFitter
    {
        public UnityEngine.RectTransform _horizontalFit; // 0x38
        public float _verticalFit; // 0x40
        public float _rectTransform; // 0x44
        public UnityEngine.RectTransform _maxFootprint; // 0x48

        // ── Methods ──
        public void get_horizontalFit(){} // RVA: 0x7FFAC36F21E0
        public void set_horizontalFit(){} // RVA: 0x7FFAC36F2320
        public void get_defaultDeadzoneMax(){} // RVA: 0x7FFAC2F29970
        public void SetLayoutHorizontal(){} // RVA: 0x7FFAC36F2460
        public void set_leftEyeOpenAmount(){} // RVA: 0x7FFAC2F29980
        public void get_preferredPeakBitRate(){} // RVA: 0x7FFAC30E80B0
        public void OnEnable(){} // RVA: 0x7FFAC2F29980
        public void .ctor(){} // RVA: 0x7FFAC36F2660
        public void set_ElapsedTimeSinceBase(){} // RVA: 0x7FFAC30EFD80
        public void HandleSelfFittingAlongAxis(){} // RVA: 0x7FFAC30EFD80
        public void SetLayoutVertical(){} // RVA: 0x7FFAC36F26C0
        public void IsInvoking(){} // RVA: 0x7FFAC30E80B0
        public void SetDirty(){} // RVA: 0x7FFAC30EFD80
        public void SetLayoutHorizontal_40A2B688EB06(){} // RVA: 0x7FFAC36F28C0
        public void ToString(){} // RVA: 0x7FFAC30EFD80
    }

    /// <summary>Originally: ÏÏÌÍÌÍÏÍÏÎÌÏÍÏÌÎÏÎÏÎÎÍÏ</summary>
    public class SetLayoutHorizontalSetLayoutVertical_3827_3827 : UILifecycleComponentImpl_A5BA_A5BA
    {
        public UnityEngine.RectTransform parentPanel; // 0x60
        public UnityEngine.RectTransform sidePanel; // 0x68
        public UnityEngine.RectTransform mainPanel; // 0x70
        public int sidebarWidthExpanded; // 0x78
        public int sidebarWidthCollapsed; // 0x7C
        public float animationDuration; // 0x80
        public float ÍÌÍÎÎÎÏÏÎÍÏÍÍÌÎÍÌÏÎÍÎÎÎ; // 0x84

        // ── Methods ──
        public void SetLayoutHorizontal(){} // RVA: 0x7FFACB9F1910
        public void get_dynamicLightingSmoothFactor(){} // RVA: 0x7FFAC31434E0
        public void SetLayoutHorizontal_67E0D0A14CB4(){} // RVA: 0x7FFACB9F1920
        public void Initialize(){} // RVA: 0x7FFACB9F1930
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x7FFACB9F1AC0
        public void CreateOrFetchAsync(){} // RVA: 0x7FFACB9F1CA0
        public void SetConnectedBody(){} // RVA: 0x7FFAC2F21310
        public void .ctor(){} // RVA: 0x7FFACB9F1E30
        public void Initialize_BDAF80FD4C68(){} // RVA: 0x7FFACB9F1930
        public void CalculateLayoutInputVertical(){} // RVA: 0x7FFACB9F1EC0
        public void SetLayoutHorizontal_5275B6C7D8FC(){} // RVA: 0x7FFACB9F1ED0
        public void SetLayoutVertical(){} // RVA: 0x7FFAC2F21310
        public void SetLayoutVertical_DB0F6629ED71(){} // RVA: 0x7FFACB9F2060
        public void GetRealtime_348(){} // RVA: 0x7FFACB9F2570
        public void get_dynamicLightingSmoothFactor_E26382E4E227(){} // RVA: 0x7FFAC31434E0
    }

    /// <summary>Originally: ÎÍÏÏÍÍÏÌÌÌÌÎÏÎÏÌÍÍÎÎÏÌÎ</summary>
    public class SetLayoutHorizontalSetLayoutVertical_645E_645E : MonoBehaviour
    {
        public UnityEngine.RectOffset _645E; // 0x20
        public float m_Spacing; // 0x28
        public 0x6B2D8C90 m_ChildAlignment; // 0x2C
        public bool m_ChildControlWidth; // 0x30
        public bool m_ChildControlHeight; // 0x31
        public bool m_ChildScaleWidth; // 0x32
        public bool m_ChildScaleHeight; // 0x33
        public bool m_ChildForceExpandWidth; // 0x34
        public bool m_ChildForceExpandHeight; // 0x35
        public 0x6B24A000 m_HorizontalFit; // 0x38
        public 0x6B24A000 m_VerticalFit; // 0x3C
        public UnityEngine.RectTransform ÌÎÌÏÏÍÎÌÎÍÍÌÍÎÎÎÌÎÎÎÍÏÎ; // 0x40
        public int ÏÎÎÎÎÌÏÌÏÏÎÍÌÎÎÏÍÍÍÍÏÎÏ; // 0x48

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFACB82E900
        public void Enable(){} // RVA: 0x7FFAC2C71060
        public void SetLayoutHorizontal(){} // RVA: 0x7FFACB82EA40
        public void SetLayoutVertical(){} // RVA: 0x7FFACB82EA70
        public void Invoke(){} // RVA: 0x7FFACB82EAA0
        public void InvokeRepeating(){} // RVA: 0x7FFACB82EAD0
        public void CancelInvoke(){} // RVA: 0x7FFACB82F0A0
        public void IsInvoking(){} // RVA: 0x7FFACB82F0F0
        public void StartCoroutine_79B8931C008D_79B8931C008D(){} // RVA: 0x7FFACB82F7A0 | overloaded x2
        public void OnApplicationQuit(){} // RVA: 0x7FFACB82FAD0
        public void StartCoroutine_Auto(){} // RVA: 0x7FFACB82FF60
        public void GetChildSizes(){} // RVA: 0x7FFAC9C4C090
        public void .ctor(){} // RVA: 0x7FFACB8309F0
    }

    /// <summary>Originally: ÌÎÏÌÍÌÏÍÌÍÏÍÏÌÌÏÎÎÌÌÌÎÏ</summary>
    public class SetLayoutHorizontalSetLayoutVertical_680A_680A : MonoBehaviour
    {
        public float ÎÎÍÏÎÌÍÌÌÍÍÏÌÍÌÌÏÎÍÏÍÏÍ; // 0x20
        public float ÌÏÌÍÏÌÏÏÏÏÍÎÎÍÏÎÏÏÍÎÌÍÎ; // 0x24
        public float ÌÏÍÎÍÍÍÎÍÌÎÌÌÌÍÍÏÎÎÎÎÏÏ; // 0x28
        public float ÌÌÏÎÌÎÍÎÏÏÍÌÏÌÎÌÎÏÍÌÍÏÌ; // 0x2C
        public bool ÍÎÎÌÎÏÏÎÎÍÏÏÎÍÍÍÎÌÍÌÌÎÌ; // 0x30

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFACB9B7190
        public void RaiseCancellation(){} // RVA: 0x7FFACB9B71A0
        public void IsInvoking(){} // RVA: 0x7FFACB9B71B0
        public void CancelInvoke(){} // RVA: 0x7FFACB9B7B60
        public void Invoke(){} // RVA: 0x7FFAC2F21310
        public void InvokeRepeating(){} // RVA: 0x7FFACB9B84F0
        public void SetLayoutHorizontal(){} // RVA: 0x7FFAC2F21310
        public void SetupTaskParametersDisabled(){} // RVA: 0x7FFACB9B8EA0
        public void .ctor(){} // RVA: 0x7FFACB9B9850
        public void SetLayoutVertical(){} // RVA: 0x7FFACB9B98B0
        public void StartCoroutine(){} // RVA: 0x7FFACB9B98C0
        public void StartCoroutine_Auto(){} // RVA: 0x7FFACB9BA270
    }

    /// <summary>Originally: ÏÎÌÍÏÏÏÌÏÏÏÎÎÌÌÌÎÎÏÌÎÎÌ</summary>
    public class Set_CC3F_CC3F : PointerDown_E181_E181
    {
        public float ÍÍÏÌÏÌÎÌÌÎÌÏÏÎÌÎÌÎÌÎÍÍÎ; // 0x198

        // ── Methods ──
        public void Set(){} // RVA: 0x7FFACB8293B0
        public void get_listingIds(){} // RVA: 0x7FFACB8294B0
        public void SetForm(){} // RVA: 0x7FFACB8295F0
        public void set_handleRect(){} // RVA: 0x7FFACB829790
        public void get_direction(){} // RVA: 0x7FFACB829930
        public void set_normalizedValue(){} // RVA: 0x7FFACB829A70
        public void get_minValue(){} // RVA: 0x7FFACB829BB0
        public void .ctor(){} // RVA: 0x7FFACB829D60
        public void Initialize(){} // RVA: 0x7FFACB829E90
        public void set_position(){} // RVA: 0x7FFACB829FD0
    }

    /// <summary>Originally: ÎÎÎÎÍÎÎÎÏÎÏÏÍÎÍÍÍÎÍÍÎÍÌ</summary>
    public class ShouldActivateModuleIsModuleSupported_1ADF_1ADF : InputSystemUIInputModule
    {
        // ── Methods ──
        public void IsModuleSupported(){} // RVA: 0x7FFAC2F21320
        public void ShouldActivateModule(){} // RVA: 0x7FFAC42FD540
        public void .ctor(){} // RVA: 0x7FFAC42FD600
    }

    /// <summary>Originally: ÌÍÌÌÏÌÌÎÏÌÎÏÍÌÏÌÍÏÍÏÎÎÎ</summary>
    public class ShouldActivateModuleIsModuleSupported_8A61_8A61 : BaseInputModule
    {
        public bool _8A61; // 0x58
        public float ÍÏÌÍÍÏÏÍÍÎÍÍÏÍÏÍÍÏÎÎÍÌÍ; // 0x5C
        public ÌÏÌÍÎÍÏÏÌÎÏÌÌÏÎÎÎÏÍÏÎÎÍ ÍÏÌÏÏÎÏÏÌÎÍÍÌÍÌÎÎÍÎÌÍÏÍ; // 0x60
        public ÌÏÌÍÎÍÏÏÌÎÏÌÌÏÎÎÎÏÍÏÎÎÍ ÌÌÍÏÌÌÏÏÌÍÏÍÎÎÎÏÎÏÏÏÏÎÌ; // 0x68
        public ÌÏÌÍÎÍÏÏÌÎÏÌÌÏÎÎÎÏÍÏÎÎÍ ÌÎÎÏÎÌÎÍÌÍÎÍÏÏÎÌÎÏÏÏÍÏÏ; // 0x70
        public ÌÏÌÍÎÍÏÏÌÎÏÌÌÏÎÎÎÏÍÏÎÎÍ ÏÏÏÍÌÌÌÌÏÎÏÎÎÎÌÌÏÍÍÏÍÏÏ; // 0x78
        public float m_InputActionsPerSecond; // 0x80

        // ── Methods ──
        public void get_sendPointerHoverToParent(){} // RVA: 0x7FFAC42D7390
        public void set_sendPointerHoverToParent(){} // RVA: 0x7FFAC42D75B0
        public void ShouldActivateModule(){} // RVA: 0x7FFAC42D75C0
        public void Process(){} // RVA: 0x7FFAC42D7700
        public void set_inputOverride(){} // RVA: 0x7FFAC42D7DC0
        public void get_eventSystem(){} // RVA: 0x7FFAC42D7F70
        public void ActivateModule(){} // RVA: 0x7FFAC42D8100
        public void IsModuleSupported(){} // RVA: 0x7FFAC42D81A0
        public void get_ThrottleInput(){} // RVA: 0x7FFAC2F4A120
        public void Start(){} // RVA: 0x7FFAC42D8220
        public void DetermineMoveDirection(){} // RVA: 0x7FFAC42D8440
        public void DetermineMoveDirection_48CF9292E746(){} // RVA: 0x7FFAC42D85D0
        public void FindCommonRoot(){} // RVA: 0x7FFAC42D87F0
        public void HandlePointerExitAndEnter(){} // RVA: 0x7FFAC42D8990
        public void set_ThrottleInput(){} // RVA: 0x7FFAC2F4A130
        public void .ctor(){} // RVA: 0x7FFAC42D8A00
        public void Initialize(){} // RVA: 0x7FFAC42D8A20
        public void set_ThrottleInput_B730CA4A0459(){} // RVA: 0x7FFAC2F4A130
    }

    /// <summary>Originally: ÏÎÎÍÏÎÍÏÏÍÌÌÌÌÍÌÏÏÎÍÍÍÍ</summary>
    public class StyleElementSiblingSibling_A0FF : Object
    {
        public string ÎÍÍÎÎÍÎÎÍÌÎÏÌÌÎÏÍÏÎÏÏÎÍ; // 0x10
        public string ÎÎÌÏÏÎÏÌÏÏÍÏÌÎÍÍÏÌÏÎÎÎÎ; // 0x18
        public System.Collections.Generic.List`1<ÏÎÍÏÎÏÎÏÌÏÏÎÌÌÍÍÏÎÎÏÍÏÌ> ÍÌÏÌÏÍÍÏÌÍÍÌÍÌÎÎÏÎÍÌÏÏÎ; // 0x20
        public bool ÌÎÎÎÏÍÍÌÍÌÏÎÍÌÍÍÌÏÌÍÍÎÎ; // 0x28
        public System.Text.RegularExpressions.Regex ÏÏÏÍÏÌÎÍÏÏÍÍÎÏÌÍÎÍÌÌÏÌÏ;
        public System.Text.RegularExpressions.Regex ÌÏÎÎÎÌÍÌÎÏÍÍÎÍÏÍÎÏÍÍÏÏÎ; // 0x8
        public System.Text.RegularExpressions.Regex ÍÏÍÍÍÏÏÎÏÌÍÍÏÌÎÏÎÎÏÏÏÌÎ; // 0x10
        public System.Text.RegularExpressions.Regex ÎÎÏÎÍÏÎÏÎÎÏÍÏÌÌÌÎÏÍÎÏÏÍ; // 0x18
        public System.Text.RegularExpressions.Regex ÎÏÎÌÌÏÎÏÎÍÏÍÌÍÎÌÎÌÍÍÏÎÎ; // 0x20

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFACB243BE0
        public void Equals(){} // RVA: 0x7FFACB243D50
        public void GetHashCode(){} // RVA: 0x7FFACB245220
        public void op_Implicit(){} // RVA: 0x7FFACB2458E0
        public void CompareBaseObjects(){} // RVA: 0x7FFACB245A50
        public void .cctor(){} // RVA: 0x7FFACB245BC0
        public void GetCachedPtr(){} // RVA: 0x7FFACB245F40
        public void get_name(){} // RVA: 0x7FFACB247400
        public void set_name(){} // RVA: 0x7FFACB247530
        public void Instantiate(){} // RVA: 0x7FFACB247650
        public void ToString(){} // RVA: 0x7FFACB2478A0
        public void .ctor(){} // RVA: 0x7FFACB248640
        // ── Unresolved (hash) ──
        public void m_F82(){} // RVA: 0x7FFACB247970
        public void m_983(){} // RVA: 0x7FFACB247A70
        public void m_8EC(){} // RVA: 0x7FFAC30F6BA0
        public void m_18A(){} // RVA: 0x7FFACB248210
    }

    /// <summary>Originally: ÏÎÍÏÎÏÎÏÌÏÏÎÌÌÍÍÏÎÎÏÍÏÌ</summary>
    public class StyleElementSibling_FDE3 : Object
    {
        public ÏÎÍÏÎÏÎÏÌÏÏÎÌÌÍÍÏÎÎÏÍÏÌ ÌÌÏÎÏÎÌÎÎÍÌÌÌÌÌÍÎÌÌÎÎÎÎ; // 0x10
        public 0x6B2683A8 ÍÏÎÍÎÎÏÎÍÎÏÎÏÌÍÌÎÍÏÌÍÍÎ; // 0x18
        public System.Collections.Generic.List`1<ÍÌÎÌÎÏÎÍÌÏÍÏÏÏÍÍÌÌÎÌÍÎÍ> ÍÍÍÎÎÎÍÏÎÍÌÍÎÎÎÏÍÏÌÏÍÎÌ; // 0x20
        public System.Collections.Generic.HashSet`1<string> ÎÏÍÍÎÏÍÏÌÎÌÍÎÌÌÏÌÌÎÍÎÍÌ; // 0x28
        public bool ÌÎÎÎÏÍÍÌÍÌÏÎÍÌÍÍÌÏÌÍÍÎÎ; // 0x30

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFAC2F47450
        public void Equals(){} // RVA: 0x7FFACB248700
        public void GetHashCode(){} // RVA: 0x7FFACB248760
        public void op_Implicit(){} // RVA: 0x7FFACB248930
        public void .ctor(){} // RVA: 0x7FFACB248DF0
        public void Initialize(){} // RVA: 0x7FFAC2F4F130
        public void GetCachedPtr(){} // RVA: 0x7FFACB248F50
        public void get_name(){} // RVA: 0x7FFACB249720
        public void set_name(){} // RVA: 0x7FFAC2F47450
        public void Instantiate(){} // RVA: 0x7FFACB2497E0
        public void ToString(){} // RVA: 0x7FFACB2498A0
        // ── Unresolved (hash) ──
        public void m_EDF(){} // RVA: 0x7FFACB24A080
        public void m_128(){} // RVA: 0x7FFAC2F4F130
        public void m_CBB(){} // RVA: 0x7FFACB24A140
        public void m_CCD(){} // RVA: 0x7FFACB24A350
        public void m_7A1(){} // RVA: 0x7FFACB24A4E0
    }

}