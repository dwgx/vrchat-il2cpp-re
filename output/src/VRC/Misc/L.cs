// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Misc
// Classes: 16
// Methods: 251

namespace VRC.Misc
{
    /// <summary>Originally: ÌÍÏÏÍÎÎÏÎÏÍÍÌÍÌÏÏÍÏÍÍÏÎ</summary>
    public class LightManager : MonoBehaviour
    {
        public object _lightReservedLayerMask;
        public object f_868;
        public object f_66C;
        public object propInstanceContainer;
        public object propInstanceFollowerPositionRotation;
        public object propInstanceFollowerScaleFactor;
        public object hiddenPreviewMeshFilter;
        public object propSpawnAudioSource;
        public object propSpawnAudioClip;
        public object f_DE3;
        public object f_11D;
        public object f_A4E;
        public object f_F80;
        public object f_268;
        public object f_631;
        public object f_CFF;
        public object f_C31;
        public object f_7DE;
        public object f_6E3;
        public object f_A27;
        public object f_CAC;
        public object f_5F3;
        public object selector;
        public object f_DD9;
        public object f_9FB;
        public object f_7FF;
        public object f_445;
        public object f_30F;
        public object f_1D5;
        public object f_78F;
        public object f_0DC;
        public object f_7AC;
        public object f_76C;
        public object f_A37;
        public object f_4A9;
        public object f_4E4;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x10B3560
        public void RaiseCancellation(){} // RVA: 0xCD48B0
        public void IsInvoking(){} // RVA: 0x10B38A0
        public void VRC.Udon.ClientBindings.Interfaces.IUdonClientInterface.get_DebugLogging(){} // RVA: 0x10B3C80
        public void Invoke(){} // RVA: 0x10B3C90
        public void InvokeRepeating(){} // RVA: 0x10B9CC0
        public void StartCoroutine(){} // RVA: 0x10B4170
        public void VRC.Udon.Common.Interfaces.IUdonSecurityFilter.ApplyFilter(){} // RVA: 0x894320
        public void StopCoroutine(){} // RVA: 0x10B4180
        public void StopAllCoroutines(){} // RVA: 0x10B41D0
        public void VRC.Udon.Common.Interfaces.IUdonSecurityFilter<UnityEngine.Object>.ApplyFilter(){} // RVA: 0x10B48B0
        public void set_useGUILayout(){} // RVA: 0x10B4910
        public void VRC.Udon.Common.Interfaces.IUdonVMFactory.ConstructUdonVM(){} // RVA: 0x10B4960
        public void VRC.Udon.Security.Interfaces.IUdonSecurityWhitelist<UnityEngine.Object>.Whitelist(){} // RVA: 0x10B4F90
        public void VRC.Udon.Security.Interfaces.IUdonSecurityWhitelist<UnityEngine.Object>.IsWhitelisted(){} // RVA: 0x10B4A20
        public void Internal_CancelInvokeAll(){} // RVA: 0xA94080
        public void VRC.Udon.ClientBindings.Interfaces.IUdonClientInterface.set_DebugLogging(){} // RVA: 0x10B4A80
        public void InvokeDelayed(){} // RVA: 0x10B4A90
        public void ApplyLightCullingMaskFilter(){} // RVA: 0x10B4D90
        public void StartCoroutineManaged(){} // RVA: 0x10B4DF0
        public void StartCoroutineManaged2(){} // RVA: 0x10B4E60
        public void StopCoroutineManaged(){} // RVA: 0xBC1B30
        public void StopCoroutineFromEnumeratorManaged(){} // RVA: 0x10B4EB0
        public void GetScriptClassName(){} // RVA: 0x10B4EF0
        public void Awake(){} // RVA: 0x10B4F40
        public void LateUpdate(){} // RVA: 0x10B4F60
        public void StopCoroutine_Injected(){} // RVA: 0x10B4FF0
        public void StopAllCoroutines_Injected(){} // RVA: 0x10B5340
        public void get_useGUILayout_Injected(){} // RVA: 0x10B6650
        public void set_useGUILayout_Injected(){} // RVA: 0x10B67E0
        public void get_didStart_Injected(){} // RVA: 0x10B6B80
        public void get_didAwake_Injected(){} // RVA: 0x10B6F60
        public void Internal_CancelInvokeAll_Injected(){} // RVA: 0x10B72B0
        public void ApplyLightCullingMaskFilter_66F856DBE11D(){} // RVA: 0x10B7300
        public void InvokeDelayed_Injected(){} // RVA: 0x10B7740
        public void CancelInvoke_Injected(){} // RVA: 0xB70160
        public void IsInvoking_Injected(){} // RVA: 0x10B77D0
        public void IsObjectMonoBehaviour_Injected(){} // RVA: 0x10B7CD0
        public void StartCoroutineManaged_Injected(){} // RVA: 0x10B8080
        public void StartCoroutineManaged2_Injected(){} // RVA: 0x10B80A0
        public void .ctor(){} // RVA: 0x10B80B0
        public void Initialize(){} // RVA: 0x10B8390
        public void GetScriptClassName_Injected(){} // RVA: 0xBAE3B0
        public void VRC.Udon.Security.IUdonSignatureVerifier.VerifySignature(){} // RVA: 0x10B8500
        public void Equals(){} // RVA: 0x10B8750
        public void GetHashCode(){} // RVA: 0x10B8B00
        public void VRC.Udon.Security.Interfaces.IUdonSecurityWhitelist.CleanWhitelist(){} // RVA: 0x10B9A40
        public void get_LightReservedLayerMask(){} // RVA: 0x10B9A90
        public void ToString(){} // RVA: 0x10B9AF0
        public void set_LightReservedLayerMask(){} // RVA: 0x10B9C60
        public void FixedUpdate(){} // RVA: 0xB700F0
        public void Update(){} // RVA: 0x10B9CD0
        public void VRC.Udon.Common.Interfaces.IUdonWrapperFactory.GetWrapper(){} // RVA: 0x10B9D60
        public void OnDestroy(){} // RVA: 0x10B9DB0
        // ── Unresolved (hash) ──
        public void m_B14(){} // RVA: 0x10B8E90
        public void m_557(){} // RVA: 0x10B9780
        public void m_FD5(){} // RVA: 0x10B9920
        public void m_959(){} // RVA: 0x10B9D50
    }

    /// <summary>Originally: ÎÍÏÌÌÎÌÍÎÍÍÎÌÎÌÌÏÏÎÌÍÌÏ</summary>
    public class LightManagerSibling_6C29
    {
        // ── Unresolved (hash) ──
        public void m_6FC(){} // RVA: 0x87C0A0
        public void m_6FE(){} // RVA: 0x87C0A0
        public void m_338(){} // RVA: 0x87C0A0
        public void m_E32(){} // RVA: 0x87D280
        public void m_B34(){} // RVA: 0x87C0A0
        public void m_B5E(){} // RVA: 0x87C0A0
        public void m_974(){} // RVA: 0x87D350
        public void m_6A7(){} // RVA: 0x894750
        public void m_985(){} // RVA: 0x894320
        public void m_A43(){} // RVA: 0x894290
    }

    /// <summary>Originally: ÍÍÏÍÍÏÏÍÎÌÍÎÍÏÍÏÍÍÎÌÍÏÍ</summary>
    public class List1DerivedSibling_6C2A
    {
        // ── Methods ──
        public void IndexOf(){} // RVA: 0x894290
        // ── Unresolved (hash) ──
        public void m_E19(){} // RVA: 0x894290
        public void m_5CD(){} // RVA: 0x894320
        public void m_9CC(){} // RVA: 0x894320
    }

    /// <summary>Originally: ÏÍÌÍÌÎÏÌÍÏÌÏÍÍÏÏÏÎÏÍÏÌÏ</summary>
    public class List1Derived_45CE : List`1
    {
        public object _45CE;

        // ── Methods ──
        public void IndexOf(){} // RVA: 0x2383980
        public void get_Capacity(){} // RVA: 0x2383D10
        public void set_Capacity(){} // RVA: 0x23840A0
        public void get_Count(){} // RVA: 0x2384430
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x23847C0
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2384B50
        public void .ctor(){} // RVA: 0x2384EE0
        public void Initialize(){} // RVA: 0x2384FA0
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2385330
    }

    /// <summary>Originally: ÌÍÌÏÎÌÌÌÎÍÎÎÎÎÍÍÌÍÍÎÍÏÍ</summary>
    public class List1Derived_C1B1 : List`1
    {
        public object _c1B1;

        // ── Methods ──
        public void IndexOf(){} // RVA: 0x23817F0
        public void get_Capacity(){} // RVA: 0x2381A60
        public void set_Capacity(){} // RVA: 0x2381D60
        public void get_Count(){} // RVA: 0x2381FE0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x23822E0
        public void .ctor(){} // RVA: 0x2382550
        public void Initialize(){} // RVA: 0x2382610
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2382890
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2382B90
        public void get_Item(){} // RVA: 0x2382E10
        public void set_Item(){} // RVA: 0x2383080
        public void IsCompatibleObject(){} // RVA: 0x2383380
        public void System.Collections.IList.get_Item(){} // RVA: 0x2383680
    }

    /// <summary>Originally: ÍÏÌÍÎÌÎÎÍÏÍÏÏÍÌÏÌÏÍÌÎÏÏ</summary>
    public class List1Derived_FF5D : List`1
    {
        // ── Methods ──
        public void IndexOf(){} // RVA: 0x1A049B0
        public void get_Capacity(){} // RVA: 0x1A04B70
        public void set_Capacity(){} // RVA: 0x1A04D30
        public void get_Count(){} // RVA: 0x1A04F20
        public void .ctor(){} // RVA: 0x1A05110
        public void Initialize(){} // RVA: 0x1A05190
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x1A05380
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x1A05570
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x1A05760
        public void get_Item(){} // RVA: 0x1A05950
    }

    /// <summary>Originally: ÍÍÌÌÍÌÏÌÏÌÍÌÌÌÍÏÌÍÎÍÍÍÌ</summary>
    public class ListContentView1Derived_2B2B : ListContentView`1
    {
        public object _headerPrefab;
        public object _layoutContainer;

        // ── Methods ──
        public void get_CountFormat(){} // RVA: 0x894290
        public void get_MaxContentCount(){} // RVA: 0x87C5F0
        public void get_ObservableList(){} // RVA: 0x87C540
        public void Start(){} // RVA: 0x87C540
        public void OnEnable(){} // RVA: 0x8943B0
        public void .ctor(){} // RVA: 0x894290
    }

    /// <summary>Originally: ÍÍÌÌÍÌÏÌÏÌÍÌÌÌÍÏÌÍÎÍÍÍÌ</summary>
    public class ListContentView1Derived_2B2B : ListContentView`1
    {
        public object _headerPrefab;
        public object _layoutContainer;

        // ── Methods ──
        public void get_CountFormat(){} // RVA: 0x59D5D70
        public void get_MaxContentCount(){} // RVA: 0x87C5F0
        public void get_ObservableList(){} // RVA: 0xBE2C60
        public void Start(){} // RVA: 0xBBFF90
        public void OnEnable(){} // RVA: 0x8943B0
        public void .ctor(){} // RVA: 0xB43D60
    }

    /// <summary>Originally: ÍÍÌÌÍÌÏÌÏÌÍÌÌÌÍÏÌÍÎÍÍÍÌ</summary>
    public class ListContentView1Derived_2B2B : ListContentView`1
    {
        public object _headerPrefab;
        public object _layoutContainer;

        // ── Methods ──
        public void get_CountFormat(){} // RVA: 0x59D5D70
        public void get_MaxContentCount(){} // RVA: 0x87C5F0
        public void get_ObservableList(){} // RVA: 0xBE2C60
        public void Start(){} // RVA: 0xBBFF90
        public void OnEnable(){} // RVA: 0x8943B0
        public void .ctor(){} // RVA: 0xB43D60
    }

    /// <summary>Originally: ÍÍÏÍÌÌÏÎÍÍÌÎÎÌÍÎÎÌÍÍÎÎÎ</summary>
    public class LocalizationManagerSibling_A087
    {
        // ── 28 unresolved (hash) ──
        public void m_57A(){} // RVA: 0x87D280
        public void m_6EF(){} // RVA: 0x894290
        public void m_B62(){} // RVA: 0x894320
        public void m_2D7(){} // RVA: 0x87C0A0
        public void m_7FF(){} // RVA: 0x87C0A0
        // ... 23 more unresolved methods
    }

    /// <summary>Originally: ÎÌÎÎÌÏÏÌÎÌÍÏÏÎÍÏÍÌÎÎÏÏÌ</summary>
    public class LogoutExit_AC3E : MonoBehaviour
    {
        // ── Methods ──
        public void Logout(){} // RVA: 0x164E2F0
        public void RaiseCancellation(){} // RVA: 0x2143A90
        public void IsInvoking(){} // RVA: 0x164E2F0
        public void CancelInvoke(){} // RVA: 0x2143CC0
        public void Invoke(){} // RVA: 0x2143D10
        public void InvokeRepeating(){} // RVA: 0x2143F40
        public void StartCoroutine(){} // RVA: 0x2143F90
        public void Exit(){} // RVA: 0x21441E0
        public void .ctor(){} // RVA: 0xB43D60
    }

    /// <summary>Originally: ÏÌÍÍÌÍÎÏÌÌÎÌÌÎÌÎÍÏÎÏÌÏÌ</summary>
    public class landscapeScaleportraitScaleComponent_56E1 : MonoBehaviour
    {
        public object _m_CancellationTokenSource;
        public object f_4C3;
        public object landscapeScale;
        public object portraitScale;
        public object f_E3A;
        public object f_76C;

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x2060D30
        public void Awake(){} // RVA: 0x2061470
        public void OnDestroy(){} // RVA: 0x2061550
        public void CancelInvoke(){} // RVA: 0x20615F0
        public void Start(){} // RVA: 0x20616D0
        public void InvokeRepeating(){} // RVA: 0x2061770
        public void StartCoroutine(){} // RVA: 0x2061950
        public void .ctor(){} // RVA: 0xB43D60
        public void Initialize(){} // RVA: 0x2062090
        public void StopAllCoroutines(){} // RVA: 0x2062270
        public void get_useGUILayout(){} // RVA: 0x2062450
        public void set_useGUILayout(){} // RVA: 0x2062630
        public void get_didStart(){} // RVA: 0x20626D0
    }

    /// <summary>Originally: ÌÎÍÌÏÍÏÏÍÍÎÍÏÏÏÎÌÌÎÏÍÍÏ</summary>
    public class landscapeScaleportraitScaleComponent_F3F7 : MonoBehaviour
    {
        public object landscapePos;
        public object landscapeScale;
        public object portraitPos;
        public object portraitScale;
        public object f_9A4;
        public object f_470;

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x13B3F80
        public void RaiseCancellation(){} // RVA: 0x13B3F90
        public void IsInvoking(){} // RVA: 0x13B3FB0
        public void CancelInvoke(){} // RVA: 0x13B3FD0
        public void Invoke(){} // RVA: 0x13B40B0
        public void InvokeRepeating(){} // RVA: 0x13B40B0
        public void Start(){} // RVA: 0x13B4190
        public void StartCoroutine_Auto(){} // RVA: 0x13B4400
        public void Awake(){} // RVA: 0x13B4490
        public void .ctor(){} // RVA: 0xB43D60
        public void Initialize(){} // RVA: 0x13B3FB0
        public void OnDestroy(){} // RVA: 0x13B4520
        public void get_didStart(){} // RVA: 0x13B4620
        public void get_didAwake(){} // RVA: 0x13B47B0
        public void print(){} // RVA: 0x13B47B0
        public void Internal_CancelInvokeAll(){} // RVA: 0x13B47C0
    }

    /// <summary>Originally: ÌÍÏÏÏÌÏÏÌÎÌÎÎÍÏÍÏÍÍÌÌÌÍ</summary>
    public class layoutElementtypeComponent_CDF4 : MonoBehaviour
    {
        public object type;
        public object icon;
        public object layoutElement;
        public object f_832;
        public object f_D2F;

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x15DE620
        public void RaiseCancellation(){} // RVA: 0x15DE770
        public void IsInvoking(){} // RVA: 0x15DE8C0
        public void CancelInvoke(){} // RVA: 0x15DE930
        public void Invoke(){} // RVA: 0x15DE9A0
        public void OnEnable(){} // RVA: 0x15DEAF0
        public void StartCoroutine(){} // RVA: 0x15DEC40
        public void StartCoroutine_Auto(){} // RVA: 0x15DED90
        public void StopCoroutine(){} // RVA: 0x15DEEE0
        public void .ctor(){} // RVA: 0xB43D60
        public void OnDisable(){} // RVA: 0x15DF030
    }

    /// <summary>Originally: ÎÍÎÍÏÏÍÏÏÌÌÌÎÎÌÌÌÎÍÌÌÎÌ</summary>
    public class loadingBarComponent_BE9D : MonoBehaviour
    {
        public object loadingBar;
        public object f_B8C;
        public object f_87C;

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x10579E0
        public void RaiseCancellation(){} // RVA: 0x1057A10
        public void IsInvoking(){} // RVA: 0x10579E0
        public void .ctor(){} // RVA: 0xB43D60
        public void Awake(){} // RVA: 0x1057A90
        public void InvokeRepeating(){} // RVA: 0x1057B10
        public void StartCoroutine(){} // RVA: 0x1057B90
        public void OnDestroy(){} // RVA: 0x10579E0
        public void StopCoroutine(){} // RVA: 0x1057B90
        public void StopAllCoroutines(){} // RVA: 0x1057BF0
        public void get_useGUILayout(){} // RVA: 0x1057B90
        public void set_useGUILayout(){} // RVA: 0x1057B90
    }

    /// <summary>Originally: ÏÌÎÎÏÌÎÎÏÌÏÏÌÎÍÍÎÌÎÌÍÍÎ</summary>
    public class lookThumbnailPostProcessocameraReplacemeComponent_1DE1 : MonoBehaviour
    {
        public object renderCamera;
        public object previewScene;
        public object previewSceneRenderSet;
        public object avatarContainer;
        public object cameraReplacementShader;
        public object blitDepthMaterial;
        public object lookThumbnailPostProcessor;
        public object f_246;
        public object f_8D8;
        public object f_0E1;
        public object f_FA2;
        public object f_E91;
        public object f_5BA;
        public object f_E21;
        public object f_54A;
        public object f_B55;
        public object f_7E6;
        public object f_383;
        public object f_F04;
        public object f_4FC;
        public object f_A11;
        public object f_DBB;

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x1F499B0
        public void RaiseCancellation(){} // RVA: 0x1F49BD0
        public void IsInvoking(){} // RVA: 0x1F49C30
        public void CancelInvoke(){} // RVA: 0x1F49F90
        public void Invoke(){} // RVA: 0x1F4AAF0
        public void InvokeRepeating(){} // RVA: 0x1F4AE00
        public void StartCoroutine(){} // RVA: 0x1F4AFA0
        public void StartCoroutine_Auto(){} // RVA: 0x1F4B100
        public void StopCoroutine(){} // RVA: 0x1F4F0A0
        public void StopAllCoroutines(){} // RVA: 0x1F4B560
        public void OnDestroy(){} // RVA: 0x1F4B830
        public void set_useGUILayout(){} // RVA: 0x1F4B840
        public void get_didStart(){} // RVA: 0x1F4BAA0
        public void Awake(){} // RVA: 0x1F4BAB0
        public void .ctor(){} // RVA: 0x1F4BAF0
        public void Initialize(){} // RVA: 0x1F4BBF0
        public void Internal_IsInvokingAll(){} // RVA: 0x1F4C0C0
        public void InvokeDelayed(){} // RVA: 0x1F4C2B0
        public void IsObjectMonoBehaviour(){} // RVA: 0x1F4C2E0
        public void StartCoroutineManaged(){} // RVA: 0x1F4C6B0
        public void StartCoroutineManaged2(){} // RVA: 0x1F4C880
        public void StopCoroutineManaged(){} // RVA: 0x1F4CA90
        public void StopCoroutineFromEnumeratorManaged(){} // RVA: 0x1F4CAC0
        public void GetScriptClassName(){} // RVA: 0x1F4CC90
        public void OnCancellationTokenCreated(){} // RVA: 0x1F4CF60
        public void OnCollisionEnter(){} // RVA: 0x1F4CFE0
        public void StopCoroutine_Injected(){} // RVA: 0x1F4D000
        public void StopAllCoroutines_Injected(){} // RVA: 0x1F4D5D0
        public void get_useGUILayout_Injected(){} // RVA: 0x1F4D6C0
        public void set_useGUILayout_Injected(){} // RVA: 0x1F4D9F0
        public void get_didStart_Injected(){} // RVA: 0x1F4DC40
        public void get_didAwake_Injected(){} // RVA: 0x1F4DF50
        public void Internal_CancelInvokeAll_Injected(){} // RVA: 0x1F4E1A0
        public void Internal_IsInvokingAll_Injected(){} // RVA: 0x1F4E3C0
        public void InvokeDelayed_Injected(){} // RVA: 0x1F4E980
        public void CancelInvoke_Injected(){} // RVA: 0x1F4ED20
        public void IsInvoking_Injected(){} // RVA: 0x1F4EE40
        public void IsObjectMonoBehaviour_Injected(){} // RVA: 0x1F4F320
        public void StartCoroutineManaged_Injected(){} // RVA: 0x1F4C2B0
        public void StartCoroutineManaged2_Injected(){} // RVA: 0x1F4F5F0
    }

}