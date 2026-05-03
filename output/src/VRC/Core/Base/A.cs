// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Base
// Classes: 7
// Methods: 151

namespace VRC.Core.Base
{
    /// <summary>Originally: ÌÏÌÎÍÌÎÌÎÍÎÌÍÍÌÌÌÏÏÎÏÍÌ</summary>
    public class ActivityGroupBaseImpl_86F2 : ActivityGroupBase_6FCA
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE898B07D0
        public void Initialize(){} // RVA: 0x7FFE898B07F0
        public void Start(){} // RVA: 0x7FFE898B1380
        // ── 13 unresolved (hash) ──
        public void m_F5B(){} // RVA: 0x7FFE898B0740
        public void m_2A9(){} // RVA: 0x7FFE898B0A40
        public void m_AA6(){} // RVA: 0x7FFE898B0B60
        public void m_5EF(){} // RVA: 0x7FFE898B0BF0
        public void m_435(){} // RVA: 0x7FFE898B1140
        // ... 8 more unresolved methods
    }

    /// <summary>Originally: ÌÎÏÌÎÎÌÍÎÏÍÎÎÌÏÌÌÎÏÏÌÌÎ</summary>
    public class ActivityGroupBaseImpl_D3F0 : ActivityGroupBase_6FCA
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFE8980B230
        public void OnEnable(){} // RVA: 0x7FFE8980B920
        public void OnDisable(){} // RVA: 0x7FFE8980B990
        public void .ctor(){} // RVA: 0x7FFE8980BAA0
        public void Initialize(){} // RVA: 0x7FFE8980BC40
        // ── Unresolved (hash) ──
        public void m_7C4(){} // RVA: 0x7FFE8980AF60
        public void m_471(){} // RVA: 0x7FFE8980B360
        public void m_13E(){} // RVA: 0x7FFE8980B630
        public void m_2AE(){} // RVA: 0x7FFE8980BA00
        public void m_D43(){} // RVA: 0x7FFE8980BD70
        public void m_19B(){} // RVA: 0x7FFE8980BE10
    }

    /// <summary>Originally: ÏÍÏÏÏÏÌÌÌÌÏÍÏÏÌÌÌÌÌÌÏÏÏ</summary>
    public class ActivityGroupBase_6FCA : MonoBehaviour
    {
        public bool _allowRenaming; // 0x20
        public bool _showSortingDropddown; // 0x21
        public bool _showCellSizeToggle; // 0x22
        public ÌÍÌÏÌÍÍÌÎÎÎÎÎÎÌÍÎÎÌÎÎÎÎ<int> f_949; // 0x28
        public ÌÍÌÏÌÍÍÌÎÎÎÎÎÎÌÍÎÎÌÎÎÎÎ<bool> f_3F7; // 0x30
        public ÌÍÌÏÌÍÍÌÎÎÎÎÎÎÌÍÎÎÌÎÎÎÎ<VRC.Localization.LocalizableString> f_BD0; // 0x38

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFE81129130
        public void RaiseCancellation(){} // RVA: 0x7FFE81437330
        public void IsInvoking(){} // RVA: 0x7FFE81631490
        public void .ctor(){} // RVA: 0x7FFE89CBF3E0
        public void Initialize(){} // RVA: 0x7FFE814B5BF0
        public void InvokeRepeating(){} // RVA: 0x7FFE81437330
        public void CancelInvoke(){} // RVA: 0x7FFE81129890
        public void StartCoroutine(){} // RVA: 0x7FFE811E99D0
        public void StartCoroutine_Auto(){} // RVA: 0x7FFE810FCE90
        public void StopCoroutine(){} // RVA: 0x7FFE81437330
        public void StopAllCoroutines(){} // RVA: 0x7FFE81437330
        public void get_useGUILayout(){} // RVA: 0x7FFE8144E200
        // ── Unresolved (hash) ──
        public void m_E86(){} // RVA: 0x7FFE81631490
        public void m_44D(){} // RVA: 0x7FFE8144E200
        public void m_7BE(){} // RVA: 0x7FFE8292F1A0
        public void m_338(){} // RVA: 0x7FFE810FCE90
        public void m_0C6(){} // RVA: 0x7FFE8143BA80
    }

    /// <summary>Originally: ÌÏÎÎÎÏÌÎÎÌÍÌÏÍÏÏÌÌÍÌÏÍÌ</summary>
    public class AvailableResolutionsBaseImpl_F2E6 : AvailableResolutionsBase_45ED
    {
        public UnityEngine.Video.VideoClip[] f_9EA; // 0x30
        public UnityEngine.GameObject f_9E4; // 0x38
        public UnityEngine.Video.VideoClip f_C6E; // 0x40
        public UnityEngine.Video.VideoPlayer f_F08; // 0x48
        public object field_4; // 0x74A
        public object field_5; // 0x74B

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE826FE8A0
        public void Initialize(){} // RVA: 0x7FFE826FE9D0
        // ── 21 unresolved (hash) ──
        public void m_D38(){} // RVA: 0x7FFE826FDAB0
        public void m_9BD(){} // RVA: 0x7FFE826FDBB0
        public void m_E68(){} // RVA: 0x7FFE826FDC10
        public void m_BE7(){} // RVA: 0x7FFE826FDD40
        public void m_F23(){} // RVA: 0x7FFE826FDFB0
        // ... 16 more unresolved methods
    }

    /// <summary>Originally: ÏÎÏÍÎÎÏÍÍÌÏÌÎÎÍÎÎÎÌÍÌÎÍ</summary>
    public class AvailableResolutionsBase_45ED : Object
    {
        public ResolutionStruct _m_CachedPtr; // 0x10
        public float _offsetOfInstanceIDInCPlusPlusObject; // 0x20
        public bool f_0C4; // 0x24
        public bool f_EC8; // 0x25
        public bool f_CE3; // 0x26
        public bool f_9A9; // 0x27
        public 0x6660F46C f_0B5; // 0x28
        public object field_7; // 0x72A
        public object field_8; // 0x72B
        public object field_9; // 0x72C
        public object field_10; // 0x72D
        public object field_11; // 0x72E
        public object field_12; // 0x72F
        public object field_13; // 0x730
        public object field_14; // 0x731
        public object field_15; // 0x732

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE826F6B90
        public void Equals(){} // RVA: 0x7FFE826F6BA0
        public void GetHashCode(){} // RVA: 0x7FFE826F6BB0
        public void op_Implicit(){} // RVA: 0x7FFE811485C0
        public void CompareBaseObjects(){} // RVA: 0x7FFE826F6CA0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE826F6CB0
        public void GetCachedPtr(){} // RVA: 0x7FFE81124080
        public void get_name(){} // RVA: 0x7FFE811167C0
        public void set_name(){} // RVA: 0x7FFE812EB1B0
        public void Instantiate(){} // RVA: 0x7FFE812EAC90
        public void Initialize(){} // RVA: 0x7FFE812EAC50
        public void ToString(){} // RVA: 0x7FFE826F6CC0
        public void DoAppendFormatHelper(){} // RVA: 0x7FFE80E2E2E0
        public void GetGlobalConfigurationRef(){} // RVA: 0x7FFE80E2E2E0
        public void .ctor_BE7CFA59C521(){} // RVA: 0x7FFE80E2E2E0
        public void Initialize_E68482C9BED7(){} // RVA: 0x7FFE80E2F150
        public void ResetControllerState(){} // RVA: 0x7FFE80E2F150
        public void UpdatePidBufferData(){} // RVA: 0x7FFE80E46530
        public void Destroy(){} // RVA: 0x7FFE826F6CD0
        public void Doadd_OnMessageLogged(){} // RVA: 0x7FFE80E2E2E0
        public void DestroyImmediate(){} // RVA: 0x7FFE80E2E2E0
        public void GetPIDControllerReference(){} // RVA: 0x7FFE80E45FE0
        public void FindObjectsOfType(){} // RVA: 0x7FFE80E45FE0
        public void GetGlobalConfigurationRefV2(){} // RVA: 0x7FFE80E2E2E0
        public void FindObjectsByType(){} // RVA: 0x7FFE826F6DB0
        public void .ctor(){} // RVA: 0x7FFE826F6E20
        // ── Unresolved (hash) ──
        public void m_D00(){} // RVA: 0x7FFE81549710
    }

    /// <summary>Originally: ÍÎÍÎÏÏÎÎÌÍÌÍÌÏÌÌÏÏÎÍÍÏÍ</summary>
    public class AvailableResolutionsBase_Nullable_E7D4 : AvailableResolutionsBase_45ED
    {
        public int f_CB2; // 0x30
        public string f_4FC;
        public ResolutionStruct[] f_DED; // 0x38
        public object f_80D;
        public bool f_DCB; // 0x8
        public UnityEngine.WebCamTexture f_716; // 0x40
        public System.Nullable`1<UnityEngine.WebCamDevice> f_7F3; // 0x48
        public UnityEngine.WebCamDevice[] f_9EA; // 0x70
        public object Nullable`1; // 0x3F30
        public object field_9;
        public object Nullable`1;
        public object field_11;
        public object field_12; // 0x240
        public object field_13;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE826FFFA0
        public void .ctor(){} // RVA: 0x7FFE82700EB0
        public void Initialize(){} // RVA: 0x7FFE82700F10
        // ── 31 unresolved (hash) ──
        public void m_9A9(){} // RVA: 0x7FFE826FFB00
        public void m_4B6(){} // RVA: 0x7FFE826FFBB0
        public void m_D38(){} // RVA: 0x7FFE826FFD30
        public void m_5F1(){} // RVA: 0x7FFE826FFD80
        public void m_166(){} // RVA: 0x7FFE811C35A0
        // ... 26 more unresolved methods
    }

    /// <summary>Originally: ÎÎÏÏÍÎÍÏÍÎÍÍÎÎÌÍÎÏÎÌÏÌÏ</summary>
    public class AvailableResolutionsBase_defaultAvailableResolutioavailableSource_66FE : AvailableResolutionsBase_45ED
    {
        public UnityEngine.Texture[] _availableSources; // 0x30
        public ResolutionStruct[] _defaultAvailableResolutions; // 0x38
        public UnityEngine.Texture2D f_5A9; // 0x40
        public UnityEngine.Texture f_3F1; // 0x48
        public bool f_728; // 0x50
        public object field_5; // 0x73A
        public object field_6; // 0x73B

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE826F71C0
        public void Initialize(){} // RVA: 0x7FFE826F73C0
        // ── 20 unresolved (hash) ──
        public void m_CB0(){} // RVA: 0x7FFE826F7020
        public void m_C8E(){} // RVA: 0x7FFE826F70C0
        public void m_D32(){} // RVA: 0x7FFE826F7160
        public void m_8E5(){} // RVA: 0x7FFE826F7420
        public void m_21D(){} // RVA: 0x7FFE8186F320
        // ... 15 more unresolved methods
    }

}