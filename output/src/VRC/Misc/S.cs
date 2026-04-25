// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Misc
// Classes: 16
// Methods: 223

namespace VRC.Misc
{
    /// <summary>Originally: ÌÎÎÌÌÍÎÌÏÌÍÍÏÎÍÍÎÍÎÎÎÎÍ</summary>
    public class SelectHandler_2312 : MonoBehaviour
    {
        public string _destroyCancellationToken;
        public float _useGUILayout;
        public bool f_064; // 0x8
        public int f_AD2;
        public System.Threading.SemaphoreSlim f_732; // 0x10
        public float f_3BD; // 0x20
        public int f_B2C; // 0x24
        public string f_9F9; // 0x28
        public 0x66413F20 f_4A3; // 0x30
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
        public void get_destroyCancellationToken(){} // RVA: 0x7FFD4F583690
        public void RaiseCancellation(){} // RVA: 0x7FFD4F583F50
        public void GetNetworkCallingMetadata(){} // RVA: 0x7FFD4E409500
        public void SetPoseTracking(){} // RVA: 0x7FFD4F584B40
        public void Invoke_9A8BB4C9F7FF(){} // RVA: 0x7FFD4F588DB0 | overloaded x2
        public void set_ValidatingStreamVersion(){} // RVA: 0x7FFD4E39CCE0
        public void CancelInvoke(){} // RVA: 0x7FFD4F5852A0
        public void IsInvoking(){} // RVA: 0x7FFD4F5852F0
        public void StartCoroutine(){} // RVA: 0x7FFD4F585300
        public void ToString(){} // RVA: 0x7FFD4F5854E0
        public void get_AllowWriteStreamBuffering(){} // RVA: 0x7FFD4F5856F0
        public void StartCoroutine_Auto(){} // RVA: 0x7FFD4F585700
        public void StopCoroutine(){} // RVA: 0x7FFD4F585960
        public void StopCoroutine_B7BB10CD0DBA(){} // RVA: 0x7FFD4F5859C0
        public void InitializeAndRetrieveExternalData(){} // RVA: 0x7FFD4F585B70
        public void StopAllCoroutines(){} // RVA: 0x7FFD4F585D30
        public void get_useGUILayout(){} // RVA: 0x7FFD4F585E80
        public void set_useGUILayout(){} // RVA: 0x7FFD4F586030
        public void Awake(){} // RVA: 0x7FFD4F5860D0
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFD4F586B40
        public void Internal_IsInvokingAll(){} // RVA: 0x7FFD4F586CD0
        public void InvokeDelayed(){} // RVA: 0x7FFD4F5870C0
        public void SetInputSource(){} // RVA: 0x7FFD4F5874D0
        public void GetSessionId(){} // RVA: 0x7FFD4E5F0140
        public void IsObjectMonoBehaviour(){} // RVA: 0x7FFD4F5874E0
        public void .cctor(){} // RVA: 0x7FFD4F5876D0
        public void StartCoroutineManaged2(){} // RVA: 0x7FFD4F5877B0
        public void .ctor(){} // RVA: 0x7FFD4F587850
        public void Initialize(){} // RVA: 0x7FFD4F587940
        public void GetScriptClassName(){} // RVA: 0x7FFD4F587AB0
        public void OnCancellationTokenCreated(){} // RVA: 0x7FFD4F587C70
        public void OnCollisionStay(){} // RVA: 0x7FFD4F587E30
        public void OnCollisionExit(){} // RVA: 0x7FFD4F587EF0
        public void OnTriggerEnter(){} // RVA: 0x7FFD4F587FE0
        public void OnTriggerStay(){} // RVA: 0x7FFD4F5852F0
        public void SetModelAlphaBlendShader(){} // RVA: 0x7FFD4E4994D0
        public void SetSelectionState(){} // RVA: 0x7FFD4F588010
        public void get_preferredMaximumResolution(){} // RVA: 0x7FFD4ED41980
        public void CancelSelection(){} // RVA: 0x7FFD4F588100
        public void EvaluatePlayerInteractivePickupUseDown(){} // RVA: 0x7FFD4F588370
        public void SetOverlay(){} // RVA: 0x7FFD4E369200
        public void GetDataCount(){} // RVA: 0x7FFD4E39CCD0
        public void get_AddressResolvedAsIpv6(){} // RVA: 0x7FFD4F588960
        public void get_rebuildTargetParent(){} // RVA: 0x7FFD4E3AC660
        public void get_AddressResolvedAsIpv6_42C5A90CB4BD(){} // RVA: 0x7FFD4F588970
        public void get_AddressResolvedAsIpv6_0DB9085D4A5B(){} // RVA: 0x7FFD4F588A10
        public void OnCollisionStay_60A735C6AA3E(){} // RVA: 0x7FFD4F587E30
        public void __op_Inequality__VRCSDK3DataDataTokenRef_SystemInt16Ref__SystemBoolean(){} // RVA: 0x7FFD4F588B10
        public void UpdateSelection(){} // RVA: 0x7FFD4F588C00
        public void get_gameObject(){} // RVA: 0x7FFD4F589DE0
        public void get_alreadySelecting(){} // RVA: 0x7FFD4F22F350
        public void SelectPrevious(){} // RVA: 0x7FFD4F58A190
        public void GetGameObject_3FF(){} // RVA: 0x7FFD4F58A570
        public void CreateSelectionIndicator(){} // RVA: 0x7FFD4F58A590
        public void set_DebounceTimeError(){} // RVA: 0x7FFD4F58A6E0
        public void UpdatepositionInj(){} // RVA: 0x7FFD4E341320
        public void set_element(){} // RVA: 0x7FFD4E5F0C20
        public void set_AddressResolvedAsIpv6(){} // RVA: 0x7FFD4F58A6F0
        public void ResolveGameObject(){} // RVA: 0x7FFD4F58A700
        public void get_preferredPeakBitRateUnits(){} // RVA: 0x7FFD4EEFEDC0
        public void ParseStandardFormat(){} // RVA: 0x7FFD4F58A8A0
        public void set_AllowAutoRedirect(){} // RVA: 0x7FFD4F22F360
        public void Initialize_C32E8D06C79E(){} // RVA: 0x7FFD4F58A940
        public void AddSubtraction(){} // RVA: 0x7FFD4E342E90
        public void get_gameObject_1FE075D885FF(){} // RVA: 0x7FFD4F58ABE0
        public void OnEnable(){} // RVA: 0x7FFD4F58A6E0
        public void OnCancellationTokenCreated_80DC8D9F68CF(){} // RVA: 0x7FFD4F58AFE0
        public void OnSelect(){} // RVA: 0x7FFD4F58AFF0
        public void GetLanguage(){} // RVA: 0x7FFD4E36F130
        public void LateUpdate(){} // RVA: 0x7FFD4F58B1E0
        public void OnDisable(){} // RVA: 0x7FFD4F58B210
        public void OnDestroy(){} // RVA: 0x7FFD4F58B300
        public void Start(){} // RVA: 0x7FFD4F58B4E0
        public void Update(){} // RVA: 0x7FFD4F58B580
        public void OnBecameVisible(){} // RVA: 0x7FFD4F58B990
        public void OnBecameInvisible(){} // RVA: 0x7FFD4F58BB00
        public void GetIKSolver(){} // RVA: 0x7FFD4E3E20E0
        public void SelectNext(){} // RVA: 0x7FFD4F58BB10
        public void GetBufferedTimes(){} // RVA: 0x7FFD4E3BE740
    }

    /// <summary>Originally: ÍÏÌÏÍÏÏÎÎÎÎÎÏÏÏÍÏÏÍÎÎÍÍ</summary>
    public class Select_5B7F : Button
    {
        // ── Methods ──
        public void OnSelect(){} // RVA: 0x7FFD4F6F93B0
        public void .ctor(){} // RVA: 0x7FFD4F6F9430
    }

    /// <summary>Originally: ÎÍÌÏÏÌÎÍÎÍÌÎÎÍÍÏÎÎÍÏÍÌÍ</summary>
    public class SerializableVector3Sibling_01A0 : ValueType
    {
        public int _01A0; // 0x10

        // ── Methods ──
        public void ToHashCode(){} // RVA: 0x7FFD4F840210
        public void InternalEquals(){} // RVA: 0x7FFD4F840210
        public void DefaultEquals(){} // RVA: 0x7FFD4F840210
        public void .ctor(){} // RVA: 0x7FFD4F8410E0 | overloaded x2
        public void Initialize(){} // RVA: 0x7FFD4F840210
        public void Equals(){} // RVA: 0x7FFD4F840210
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4F840210
        public void GetHashCode(){} // RVA: 0x7FFD4F840210
    }

    /// <summary>Originally: ÎÎÎÌÎÏÏÎÍÎÍÏÎÏÏÏÍÌÏÎÏÎÏ</summary>
    public class ServerTimeManager : Object
    {
        public object _serverTimeUtc;

        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFD4F2385A0
        public void Shutdown(){} // RVA: 0x7FFD4F2385F0
        public void Register(){} // RVA: 0x7FFD4F238640
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void Unregister(){} // RVA: 0x7FFD4F238690
        public void get_ServerTimeUtc(){} // RVA: 0x7FFD4F2386E0
        public void set_ServerTimeUtc(){} // RVA: 0x7FFD4F238730
    }

    /// <summary>Originally: ÍÏÍÌÏÍÏÌÌÏÍÍÍÎÎÎÌÏÌÎÏÌÍ</summary>
    public class SetActionBinding_DB55 : MonoBehaviour
    {
        public UnityEngine.GameObject ÎÍÏÎÎÏÌÍÍÌÍÏÌÏÍÌÍÍÌÎÍÌÏ; // 0x20
        public ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ ÌÏÏÍÌÏÍÌÍÎÍÍÍÏÌÎÏÍÎÍÍÎÍ; // 0x28
        public System.Action ÎÍÎÍÎÎÏÎÏÏÍÌÎÍÎÍÎÌÏÏÎÌÌ; // 0x30
        public 0x6635F488 ÍÏÍÌÌÏÍÏÎÌÍÎÍÏÌÎÎÍÏÏÌÎÏ; // 0x38

        // ── Methods ──
        public void GetFileLineNumber(){} // RVA: 0x7FFD4E9AA870
        public void RaiseCancellation(){} // RVA: 0x7FFD4E9AA870
        public void Interact(){} // RVA: 0x7FFD4F68ACB0
        public void SetActionBinding(){} // RVA: 0x7FFD4F68B100 | overloaded x2
        public void AddUnitNode(){} // RVA: 0x7FFD4E36F890
        public void InvokeRepeating(){} // RVA: 0x7FFD4F68AF30
        public void IsInvoking(){} // RVA: 0x7FFD4F68B110
        public void StartCoroutine(){} // RVA: 0x7FFD4F68B100
        public void AddUnitNode_38A58D617B78(){} // RVA: 0x7FFD4E36F890
        public void StartCoroutine_A2719F5AD237(){} // RVA: 0x7FFD4F68B490
        public void StartCoroutine_Auto(){} // RVA: 0x7FFD4E36F890
        public void StopCoroutine(){} // RVA: 0x7FFD4F68B5C0
        public void GetFileLineNumber_BEDCD61D624D(){} // RVA: 0x7FFD4E9AA870
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void Initialize(){} // RVA: 0x7FFD4F68B7B0
    }

    /// <summary>Originally: ÎÏÍÍÍÍÏÎÏÏÍÍÍÍÏÌÏÍÍÌÌÎÌ</summary>
    public class SetEnableComponent_A1A6 : MonoBehaviour
    {
        public UnityEngine.UI.Toggle ÎÍÌÏÎÍÌÍÎÎÌÌÍÎÌÏÎÏÌÎÏÌÎ; // 0x20
        public bool ÎÍÌÏÏÎÍÌÌÏÎÍÏÍÎÏÌÎÎÍÎÏÏ; // 0x28

        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFD4F707390
        public void OnDisable(){} // RVA: 0x7FFD4F707580
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void Initialize(){} // RVA: 0x7FFD4F707770
        public void SetEnable(){} // RVA: 0x7FFD4F707960
        public void InvokeRepeating(){} // RVA: 0x7FFD4F707A20
        public void CancelInvoke(){} // RVA: 0x7FFD4F707AE0
        public void IsInvoking(){} // RVA: 0x7FFD4F707CD0
        public void StartCoroutine(){} // RVA: 0x7FFD4F707D90
    }

    /// <summary>Originally: ÎÎÍÎÎÌÌÍÌÍÏÎÍÏÌÍÍÏÌÏÎÎÌ</summary>
    public class SetEnableComponent_A8E1 : MonoBehaviour
    {
        public 0x6635F748 ÍÎÏÏÌÏÍÏÍÍÏÏÎÎÎÌÏÎÎÎÍÎÌ; // 0x20
        public 0x6635F748[] ÎÎÎÎÏÏÎÌÍÏÌÍÎÎÍÏÌÍÍÏÌÌÎ; // 0x28
        public UnityEngine.UI.Toggle ÎÍÌÏÎÍÌÍÎÎÌÌÍÎÌÏÎÏÌÎÏÌÎ; // 0x30
        public UnityEngine.GameObject ÍÍÎÌÍÏÎÏÎÌÎÏÌÍÎÌÏÏÏÌÍÍÌ; // 0x38

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFD4F707F80
        public void RaiseCancellation(){} // RVA: 0x7FFD4F707FF0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void OnEnable(){} // RVA: 0x7FFD4F708060
        public void OnDisable(){} // RVA: 0x7FFD4F708490
        public void SetEnable(){} // RVA: 0x7FFD4F7088A0
        public void CancelInvoke(){} // RVA: 0x7FFD4F708910
        public void IsInvoking(){} // RVA: 0x7FFD4F708D10
        public void StartCoroutine(){} // RVA: 0x7FFD4F708D80
    }

    /// <summary>Originally: ÍÍÎÏÎÏÍÍÌÏÏÍÍÍÏÌÏÍÌÏÌÌÎ</summary>
    public class SetLayoutHorizontalSImpl_145F : SetLayoutHorizontalSetLayoutVertical_645E
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD56C50B10
        public void Initialize(){} // RVA: 0x7FFD56C50B20
    }

    /// <summary>Originally: ÏÍÎÎÌÌÍÍÎÍÎÎÎÎÍÎÍÍÏÌÎÍÎ</summary>
    public class SetLayoutHorizontalSImpl_61AF : SetLayoutHorizontalSetLayoutVertical_645E
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD56C50B10
        public void Initialize(){} // RVA: 0x7FFD56C50B60
    }

    /// <summary>Originally: ÏÍÎÏÌÏÍÏÌÌÍÏÏÍÍÌÍÏÎÍÍÌÏ</summary>
    public class SetLayoutHorizontalSetLayoutVertical_07A6 : ContentSizeFitter
    {
        public UnityEngine.RectTransform _horizontalFit; // 0x38
        public float _verticalFit; // 0x40
        public float _rectTransform; // 0x44
        public UnityEngine.RectTransform _maxFootprint; // 0x48

        // ── Methods ──
        public void get_horizontalFit(){} // RVA: 0x7FFD4EB121E0
        public void set_horizontalFit(){} // RVA: 0x7FFD4EB12320
        public void get_defaultDeadzoneMax(){} // RVA: 0x7FFD4E349970
        public void SetLayoutHorizontal(){} // RVA: 0x7FFD4EB12460
        public void set_leftEyeOpenAmount(){} // RVA: 0x7FFD4E349980
        public void get_preferredPeakBitRate(){} // RVA: 0x7FFD4E5080B0
        public void OnEnable(){} // RVA: 0x7FFD4E349980
        public void .ctor(){} // RVA: 0x7FFD4EB12660
        public void set_ElapsedTimeSinceBase(){} // RVA: 0x7FFD4E50FD80
        public void HandleSelfFittingAlongAxis(){} // RVA: 0x7FFD4E50FD80
        public void SetLayoutVertical(){} // RVA: 0x7FFD4EB126C0
        public void IsInvoking(){} // RVA: 0x7FFD4E5080B0
        public void SetDirty(){} // RVA: 0x7FFD4E50FD80
        public void SetLayoutHorizontal_40A2B688EB06(){} // RVA: 0x7FFD4EB128C0
        public void ToString(){} // RVA: 0x7FFD4E50FD80
    }

    /// <summary>Originally: ÏÏÌÍÌÍÏÍÏÎÌÏÍÏÌÎÏÎÏÎÎÍÏ</summary>
    public class SetLayoutHorizontalSetLayoutVertical_3827 : UILifecycleComponentImpl_A5BA
    {
        public UnityEngine.RectTransform parentPanel; // 0x60
        public UnityEngine.RectTransform sidePanel; // 0x68
        public UnityEngine.RectTransform mainPanel; // 0x70
        public int sidebarWidthExpanded; // 0x78
        public int sidebarWidthCollapsed; // 0x7C
        public float animationDuration; // 0x80
        public float ÍÌÍÎÎÎÏÏÎÍÏÍÍÌÎÍÌÏÎÍÎÎÎ; // 0x84

        // ── Methods ──
        public void SetLayoutHorizontal(){} // RVA: 0x7FFD56E11910
        public void get_dynamicLightingSmoothFactor(){} // RVA: 0x7FFD4E5634E0
        public void SetLayoutHorizontal_67E0D0A14CB4(){} // RVA: 0x7FFD56E11920
        public void Initialize(){} // RVA: 0x7FFD56E11930
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x7FFD56E11AC0
        public void CreateOrFetchAsync(){} // RVA: 0x7FFD56E11CA0
        public void SetConnectedBody(){} // RVA: 0x7FFD4E341310
        public void .ctor(){} // RVA: 0x7FFD56E11E30
        public void Initialize_BDAF80FD4C68(){} // RVA: 0x7FFD56E11930
        public void CalculateLayoutInputVertical(){} // RVA: 0x7FFD56E11EC0
        public void SetLayoutHorizontal_5275B6C7D8FC(){} // RVA: 0x7FFD56E11ED0
        public void SetLayoutVertical(){} // RVA: 0x7FFD4E341310
        public void SetLayoutVertical_DB0F6629ED71(){} // RVA: 0x7FFD56E12060
        public void GetRealtime_348(){} // RVA: 0x7FFD56E12570
        public void get_dynamicLightingSmoothFactor_E26382E4E227(){} // RVA: 0x7FFD4E5634E0
    }

    /// <summary>Originally: ÎÍÏÏÍÍÏÌÌÌÌÎÏÎÏÌÍÍÎÎÏÌÎ</summary>
    public class SetLayoutHorizontalSetLayoutVertical_645E : MonoBehaviour
    {
        public UnityEngine.RectOffset _645E; // 0x20
        public float m_Spacing; // 0x28
        public 0x66638C90 m_ChildAlignment; // 0x2C
        public bool m_ChildControlWidth; // 0x30
        public bool m_ChildControlHeight; // 0x31
        public bool m_ChildScaleWidth; // 0x32
        public bool m_ChildScaleHeight; // 0x33
        public bool m_ChildForceExpandWidth; // 0x34
        public bool m_ChildForceExpandHeight; // 0x35
        public R m_HorizontalFit; // 0x38
        public R m_VerticalFit; // 0x3C
        public UnityEngine.RectTransform ÌÎÌÏÏÍÎÌÎÍÍÌÍÎÎÎÌÎÎÎÍÏÎ; // 0x40
        public int ÏÎÎÎÎÌÏÌÏÏÎÍÌÎÎÏÍÍÍÍÏÎÏ; // 0x48

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFD56C4E900
        public void Enable(){} // RVA: 0x7FFD4E091060
        public void SetLayoutHorizontal(){} // RVA: 0x7FFD56C4EA40
        public void SetLayoutVertical(){} // RVA: 0x7FFD56C4EA70
        public void Invoke(){} // RVA: 0x7FFD56C4EAA0
        public void InvokeRepeating(){} // RVA: 0x7FFD56C4EAD0
        public void CancelInvoke(){} // RVA: 0x7FFD56C4F0A0
        public void IsInvoking(){} // RVA: 0x7FFD56C4F0F0
        public void StartCoroutine_79B8931C008D(){} // RVA: 0x7FFD56C4F7A0 | overloaded x2
        public void OnApplicationQuit(){} // RVA: 0x7FFD56C4FAD0
        public void StartCoroutine_Auto(){} // RVA: 0x7FFD56C4FF60
        public void GetChildSizes(){} // RVA: 0x7FFD5506C090
        public void .ctor(){} // RVA: 0x7FFD56C509F0
    }

    /// <summary>Originally: ÌÎÏÌÍÌÏÍÌÍÏÍÏÌÌÏÎÎÌÌÌÎÏ</summary>
    public class SetLayoutHorizontalSetLayoutVertical_680A : MonoBehaviour
    {
        public float ÎÎÍÏÎÌÍÌÌÍÍÏÌÍÌÌÏÎÍÏÍÏÍ; // 0x20
        public float ÌÏÌÍÏÌÏÏÏÏÍÎÎÍÏÎÏÏÍÎÌÍÎ; // 0x24
        public float ÌÏÍÎÍÍÍÎÍÌÎÌÌÌÍÍÏÎÎÎÎÏÏ; // 0x28
        public float ÌÌÏÎÌÎÍÎÏÏÍÌÏÌÎÌÎÏÍÌÍÏÌ; // 0x2C
        public bool ÍÎÎÌÎÏÏÎÎÍÏÏÎÍÍÍÎÌÍÌÌÎÌ; // 0x30

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFD56DD7190
        public void RaiseCancellation(){} // RVA: 0x7FFD56DD71A0
        public void IsInvoking(){} // RVA: 0x7FFD56DD71B0
        public void CancelInvoke(){} // RVA: 0x7FFD56DD7B60
        public void Invoke(){} // RVA: 0x7FFD4E341310
        public void InvokeRepeating(){} // RVA: 0x7FFD56DD84F0
        public void SetLayoutHorizontal(){} // RVA: 0x7FFD4E341310
        public void SetupTaskParametersDisabled(){} // RVA: 0x7FFD56DD8EA0
        public void .ctor(){} // RVA: 0x7FFD56DD9850
        public void SetLayoutVertical(){} // RVA: 0x7FFD56DD98B0
        public void StartCoroutine(){} // RVA: 0x7FFD56DD98C0
        public void StartCoroutine_Auto(){} // RVA: 0x7FFD56DDA270
    }

    /// <summary>Originally: ÏÎÌÍÏÏÏÌÏÏÏÎÎÌÌÌÎÎÏÌÎÎÌ</summary>
    public class Set_CC3F : PointerDown_E181
    {
        public float ÍÍÏÌÏÌÎÌÌÎÌÏÏÎÌÎÌÎÌÎÍÍÎ; // 0x198

        // ── Methods ──
        public void Set(){} // RVA: 0x7FFD56C493B0
        public void get_listingIds(){} // RVA: 0x7FFD56C494B0
        public void SetForm(){} // RVA: 0x7FFD56C495F0
        public void set_handleRect(){} // RVA: 0x7FFD56C49790
        public void get_direction(){} // RVA: 0x7FFD56C49930
        public void set_normalizedValue(){} // RVA: 0x7FFD56C49A70
        public void get_minValue(){} // RVA: 0x7FFD56C49BB0
        public void .ctor(){} // RVA: 0x7FFD56C49D60
        public void Initialize(){} // RVA: 0x7FFD56C49E90
        public void set_position(){} // RVA: 0x7FFD56C49FD0
    }

    /// <summary>Originally: ÎÎÎÎÍÎÎÎÏÎÏÏÍÎÍÍÍÎÍÍÎÍÌ</summary>
    public class ShouldActivateModuleIsModuleSupported_1ADF : InputSystemUIInputModule
    {
        // ── Methods ──
        public void IsModuleSupported(){} // RVA: 0x7FFD4E341320
        public void ShouldActivateModule(){} // RVA: 0x7FFD4F71D540
        public void .ctor(){} // RVA: 0x7FFD4F71D600
    }

    /// <summary>Originally: ÌÍÌÌÏÌÌÎÏÌÎÏÍÌÏÌÍÏÍÏÎÎÎ</summary>
    public class ShouldActivateModuleIsModuleSupported_8A61 : BaseInputModule
    {
        public bool _8A61; // 0x58
        public float ÍÏÌÍÍÏÏÍÍÎÍÍÏÍÏÍÍÏÎÎÍÌÍ; // 0x5C
        public ÌÏÌÍÎÍÏÏÌÎÏÌÌÏÎÎÎÏÍÏÎÎÍ ÍÏÌÏÏÎÏÏÌÎÍÍÌÍÌÎÎÍÎÌÍÏÍ; // 0x60
        public ÌÏÌÍÎÍÏÏÌÎÏÌÌÏÎÎÎÏÍÏÎÎÍ ÌÌÍÏÌÌÏÏÌÍÏÍÎÎÎÏÎÏÏÏÏÎÌ; // 0x68
        public ÌÏÌÍÎÍÏÏÌÎÏÌÌÏÎÎÎÏÍÏÎÎÍ ÌÎÎÏÎÌÎÍÌÍÎÍÏÏÎÌÎÏÏÏÍÏÏ; // 0x70
        public ÌÏÌÍÎÍÏÏÌÎÏÌÌÏÎÎÎÏÍÏÎÎÍ ÏÏÏÍÌÌÌÌÏÎÏÎÎÎÌÌÏÍÍÏÍÏÏ; // 0x78
        public float m_InputActionsPerSecond; // 0x80

        // ── Methods ──
        public void get_sendPointerHoverToParent(){} // RVA: 0x7FFD4F6F7390
        public void set_sendPointerHoverToParent(){} // RVA: 0x7FFD4F6F75B0
        public void ShouldActivateModule(){} // RVA: 0x7FFD4F6F75C0
        public void Process(){} // RVA: 0x7FFD4F6F7700
        public void set_inputOverride(){} // RVA: 0x7FFD4F6F7DC0
        public void get_eventSystem(){} // RVA: 0x7FFD4F6F7F70
        public void ActivateModule(){} // RVA: 0x7FFD4F6F8100
        public void IsModuleSupported(){} // RVA: 0x7FFD4F6F81A0
        public void get_ThrottleInput(){} // RVA: 0x7FFD4E36A120
        public void Start(){} // RVA: 0x7FFD4F6F8220
        public void DetermineMoveDirection(){} // RVA: 0x7FFD4F6F8440
        public void DetermineMoveDirection_48CF9292E746(){} // RVA: 0x7FFD4F6F85D0
        public void FindCommonRoot(){} // RVA: 0x7FFD4F6F87F0
        public void HandlePointerExitAndEnter(){} // RVA: 0x7FFD4F6F8990
        public void set_ThrottleInput(){} // RVA: 0x7FFD4E36A130
        public void .ctor(){} // RVA: 0x7FFD4F6F8A00
        public void Initialize(){} // RVA: 0x7FFD4F6F8A20
        public void set_ThrottleInput_B730CA4A0459(){} // RVA: 0x7FFD4E36A130
    }

}