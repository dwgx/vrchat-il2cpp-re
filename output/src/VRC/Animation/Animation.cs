// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Animation
// Classes: 6
// Methods: 112

namespace VRC.Animation
{
    /// <summary>Originally: ÌÎÏÌÏÎÎÏÏÎÌÎÌÍÍÌÎÍÎÍÌÏÏ</summary>
    public class AnimatedTexture : BackingFieldBase_C330
    {
        public ÏÌÌÍÏÍÍÏÎÍÍÎÏÎÍÏÍÎÌÍÌÌÌ<UnityEngine.Texture2D> f_EF1; // 0x20
        public ÏÌÌÍÏÍÍÏÎÍÍÎÏÎÍÏÍÎÌÍÌÌÌ<UnityEngine.Texture2D> f_7C8; // 0x28
        public ÍÏÌÌÍÏÍÍÌÍÌÍÍÍÌÌÎÍÍÏÍÎÌ _displayTexture; // 0x30
        public int _isAnimated;
        public VRC.Profiling.ProfilerMarker _linearLoop; // 0x38
        public VRC.Profiling.ProfilerMarker _loopStyle; // 0x48
        public object field_6; // 0x9FD
        public object field_7; // 0x9FE
        public object field_8; // 0x9FF
        public object field_9; // 0xA00
        public object field_10; // 0xA01
        public object field_11; // 0xA02
        public object field_12; // 0xA03

        // ── Methods ──
        public void set_IsAnimated(){} // RVA: 0x7FFE817590E0
        public void set_DisplayTexture(){} // RVA: 0x7FFE810FCE90
        public void set_LinearLoop(){} // RVA: 0x7FFE810FCE90
        public void get_DisplayTexture(){} // RVA: 0x7FFE811290C0
        public void get_IsAnimated(){} // RVA: 0x7FFE81C3B5D0
        public void get_LinearLoop(){} // RVA: 0x7FFE82923250
        public void set_LoopStyle(){} // RVA: 0x7FFE82923300
        public void set_MaskTag(){} // RVA: 0x7FFE810FCE90
        public void .ctor(){} // RVA: 0x7FFE829234C0
        public void get_LoopStyle(){} // RVA: 0x7FFE82923650
        public void set_Frames(){} // RVA: 0x7FFE811290D0
        public void get_MaskTag(){} // RVA: 0x7FFE81758DC0
        public void get_Frames(){} // RVA: 0x7FFE81D32810
        public void get_IsBuiltIn(){} // RVA: 0x7FFE810FB320
        public void set_IsBuiltIn(){} // RVA: 0x7FFE829236B0
        public void set_FullResolutionTexture(){} // RVA: 0x7FFE811E0850
        public void set_FileId(){} // RVA: 0x7FFE82923B10
        public void get_FileId(){} // RVA: 0x7FFE81C3B5F0
        public void get_FullResolutionTexture(){} // RVA: 0x7FFE81129130
        public void set_IsSpecialFX(){} // RVA: 0x7FFE81D2ECA0
        public void get_IsSpecialFX(){} // RVA: 0x7FFE82923BC0
        public void set_EffectBundleID(){} // RVA: 0x7FFE82923C00
        public void get_EffectBundleID(){} // RVA: 0x7FFE8170CA80
        public void set_FPS(){} // RVA: 0x7FFE82923C50
        public void get_FPS(){} // RVA: 0x7FFE81D2ECA0
    }

    /// <summary>Originally: ÏÌÍÍÏÏÏÌÎÍÍÏÍÎÏÏÍÎÎÏÏÏÎ</summary>
    public class AnimationCurrentMoveNext_4982 : Object
    {
        public System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<string,ÎÎÎÎÏÌÏÏÏÌÌÍÎÏÎÌÍÌÏÍÏÏÍ>> _key; // 0x10
        public object field_1; // 0x92C
        public object field_2; // 0x92D
        public object field_3; // 0x92E

        // ── Methods ──
        public void get_Key(){} // RVA: 0x7FFE828B2250
        public void get_Current(){} // RVA: 0x7FFE828B2320
        public void get_Entry(){} // RVA: 0x7FFE828B2510
        public void set_Entry(){} // RVA: 0x7FFE828B2620
        public void CompareBaseObjects(){} // RVA: 0x7FFE828B2730
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE828B2800
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void MoveNext(){} // RVA: 0x7FFE828B2850
        public void set_name(){} // RVA: 0x7FFE828B28A0
        public void Reset(){} // RVA: 0x7FFE828B29B0
        public void get_Value(){} // RVA: 0x7FFE828B2A00
        public void set_Value(){} // RVA: 0x7FFE828B2AD0
    }

    /// <summary>Originally: ÌÎÏÏÌÍÍÏÌÍÍÏÍÏÍÏÎÍÌÏÍÎÎ</summary>
    public class AnimationDisplayNamePrefabName_A751
    {
        // ── Methods ──
        public void get_Key(){} // RVA: 0x7FFE80E2E2E0
        public void get_DisplayName(){} // RVA: 0x7FFE80E2DCF0
        public void get_PrefabName(){} // RVA: 0x7FFE80E2E2E0
    }

    /// <summary>Originally: ÌÎÎÏÌÎÏÎÏÍÌÍÎÏÏÏÎÎÏÎÍÏÌ</summary>
    public class ProcessRootMotionProcessAnimation_24B5 : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE81467DA0
        public void InternalEquals(){} // RVA: 0x7FFE814681E0
        public void ProcessAnimation(){} // RVA: 0x7FFE81468620
        public void GetHashCode(){} // RVA: 0x7FFE810FB310
        public void ProcessRootMotion(){} // RVA: 0x7FFE810FB310
        public void ToString(){} // RVA: 0x7FFE81468A60
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFE810FB310
        // ── Unresolved (hash) ──
        public void m_3EC(){} // RVA: 0x7FFE810FB310
    }

    /// <summary>Originally: ÎÍÍÏÌÏÍÎÏÏÍÍÍÍÍÎÌÏÍÏÎÌÌ</summary>
    public class ProcessRootMotionProcessAnimation_309A : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE81E97670
        public void InternalEquals(){} // RVA: 0x7FFE810FB310
        public void ProcessRootMotion(){} // RVA: 0x7FFE81E97950
        public void GetHashCode(){} // RVA: 0x7FFE81E97C30
        public void ProcessAnimation(){} // RVA: 0x7FFE810FB310
        public void .ctor(){} // RVA: 0x7FFE81E97DA0
        public void Initialize(){} // RVA: 0x7FFE810FB310
        public void ToString(){} // RVA: 0x7FFE81E97670
        // ── Unresolved (hash) ──
        public void m_5B0(){} // RVA: 0x7FFE81E97670
    }

    /// <summary>Originally: ÍÌÍÎÍÌÏÌÎÎÌÌÎÌÌÌÌÍÍÌÏÎÌ</summary>
    public class VRCMotionState : MonoBehaviour
    {
        public RootMotion.FinalIK.AimIK _m_CancellationTokenSource; // 0x20
        public VRC.SDKBase.VRC_Pickup f_835; // 0x28
        public UnityEngine.Rigidbody f_574; // 0x30
        public System.Collections.Generic.List`1<VRC.SDKBase.VRC_Interactable> f_A8D; // 0x38

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFE823C8310
        public void RaiseCancellation(){} // RVA: 0x7FFE823C83F0
        public void IsInvoking(){} // RVA: 0x7FFE823C9620
        public void CancelInvoke(){} // RVA: 0x7FFE823C9B20
        public void OnDestroy(){} // RVA: 0x7FFE823CA330
        public void InvokeRepeating(){} // RVA: 0x7FFE823CA440
        public void OnApplicationQuit(){} // RVA: 0x7FFE823CAD50
        public void OnBecameVisible(){} // RVA: 0x7FFE823CAFB0
        public void StartCoroutine(){} // RVA: 0x7FFE823CB3C0
        public void OnCollisionEnter(){} // RVA: 0x7FFE823CB8C0
        public void Awake(){} // RVA: 0x7FFE823CB9B0
        public void StartCoroutine_Auto(){} // RVA: 0x7FFE823CBA80
        public void StopCoroutine(){} // RVA: 0x7FFE823CC310
        public void OnTriggerStay(){} // RVA: 0x7FFE823CC570
        public void OnTriggerExit(){} // RVA: 0x7FFE823CC5B0
        public void StopAllCoroutines(){} // RVA: 0x7FFE823CCA10
        public void get_useGUILayout(){} // RVA: 0x7FFE823CCD10
        public void set_useGUILayout(){} // RVA: 0x7FFE823CCEF0
        public void print(){} // RVA: 0x7FFE823CD210
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFE823CD610
        public void Internal_IsInvokingAll(){} // RVA: 0x7FFE823CD760
        public void InvokeDelayed(){} // RVA: 0x7FFE81129130
        public void OnCollisionExit(){} // RVA: 0x7FFE823CD7D0
        public void OnCollisionStay(){} // RVA: 0x7FFE823CEAD0
        public void IsObjectMonoBehaviour(){} // RVA: 0x7FFE81176D50
        public void StartCoroutineManaged(){} // RVA: 0x7FFE823CF2F0
        public void StartCoroutineManaged2(){} // RVA: 0x7FFE823CF720
        public void Update(){} // RVA: 0x7FFE823CF860
        public void StopCoroutineFromEnumeratorManaged(){} // RVA: 0x7FFE823CFFB0
        public void GetScriptClassName(){} // RVA: 0x7FFE823D0280
        public void OnCancellationTokenCreated(){} // RVA: 0x7FFE823D0540
        public void OnApplicationPause(){} // RVA: 0x7FFE823D0E40
        public void Awake_7818059BC266(){} // RVA: 0x7FFE823D0E80
        public void OnDestroy_FCA649D9E69F(){} // RVA: 0x7FFE823D11D0
        public void OnBecameInvisible(){} // RVA: 0x7FFE823D0E40
        public void Start_DF10CB0BFC5B(){} // RVA: 0x7FFE823D15E0
        public void Update_48BE052C4114(){} // RVA: 0x7FFE823CC570
        public void OnEnable(){} // RVA: 0x7FFE823D1A60
        public void Start(){} // RVA: 0x7FFE823D1B30
        public void OnDrawGizmos(){} // RVA: 0x7FFE823D3400
        public void .ctor(){} // RVA: 0x7FFE823D3790
        public void Initialize(){} // RVA: 0x7FFE823D3AC0
        public void OnDisable(){} // RVA: 0x7FFE823D3B10
        public void OnBecameInvisible_476F739A1B31(){} // RVA: 0x7FFE823D3C00
        public void OnCollisionEnter_B6631BB1443D(){} // RVA: 0x7FFE823D3E10
        public void UpdateMotionState(){} // RVA: 0x7FFE823D3F00
        public void GetDomainList(){} // RVA: 0x7FFE823D41C0
        public void GetCurrentMotion(){} // RVA: 0x7FFE823D4540
        public void .ctor_074153D25E3F(){} // RVA: 0x7FFE823D45A0
        public void FixedUpdate(){} // RVA: 0x7FFE823D46F0
        public void ApplyMotionTransition(){} // RVA: 0x7FFE823D6250
        public void LateUpdate(){} // RVA: 0x7FFE823D6370
        public void ResetMotionState(){} // RVA: 0x7FFE823D68F0
        public void GetMotionDuration(){} // RVA: 0x7FFE823D6A20
        public void InvokeMotionStateChanged(){} // RVA: 0x7FFE823D7050
    }

}