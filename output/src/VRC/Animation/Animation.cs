// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Animation
// Classes: 9
// Methods: 177

namespace VRC.Animation
{
    /// <summary>Originally: ÏÌÏÎÎÏÍÌÏÎÏÎÌÏÎÏÎÍÎÏÍÎÍ</summary>
    public class AnimatedTexture : BackingFieldBase_0287
    {
        public object f_3F1;
        public object f_89B;
        public object _maskTag;
        public object _displayTexture;
        public object _isAnimated;
        public object _effectBundleID;

        // ── Methods ──
        public void set_MaskTag(){} // RVA: 0xB44DC0
        public void get_MaskTag(){} // RVA: 0x12BAA70
        public void set_DisplayTexture(){} // RVA: 0x12423E0
        public void get_DisplayTexture(){} // RVA: 0xB700F0
        public void get_IsAnimated(){} // RVA: 0x17887F0
        public void get_EffectBundleID(){} // RVA: 0x126BC50
        public void get_IsSpecialFX(){} // RVA: 0x2463A30
        public void set_IsSpecialFX(){} // RVA: 0x126BC50
        public void get_FileId(){} // RVA: 0x1242460
        public void get_FullResolutionTexture(){} // RVA: 0xB70160
        public void set_FullResolutionTexture(){} // RVA: 0x188A6F0
        public void set_FileId(){} // RVA: 0x2463A70
        public void set_IsBuiltIn(){} // RVA: 0x2463B00
        public void .ctor(){} // RVA: 0x2463CD0
        public void Initialize(){} // RVA: 0xB700F0
        public void get_IsBuiltIn(){} // RVA: 0xB43320
        public void set_Frames(){} // RVA: 0xB70100
        public void get_Frames(){} // RVA: 0x188A6F0
        public void set_FPS(){} // RVA: 0x2463E60
        public void get_FPS(){} // RVA: 0x18873B0
        public void set_LinearLoop(){} // RVA: 0x2463F10
        public void set_LoopStyle(){} // RVA: 0x12423E0
        public void get_LinearLoop(){} // RVA: 0x2464590
        public void get_LoopStyle(){} // RVA: 0x2464700
        // ── Unresolved (hash) ──
        public void m_603(){} // RVA: 0x2463F70
        public void m_C36(){} // RVA: 0x2464640
    }

    /// <summary>Originally: ÎÎÍÏÏÎÏÌÏÏÏÌÏÏÍÌÏÌÎÍÍÍÎ</summary>
    public class AnimationCurrentMoveNext_6615 : Object
    {
        public object _key;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void Initialize(){} // RVA: 0x23F04A0
        public void set_Key(){} // RVA: 0x23F0570
        public void get_Key(){} // RVA: 0x23F0680
        public void CompareBaseObjects(){} // RVA: 0x23F0750
        public void Reset(){} // RVA: 0x23F0940
        public void GetCachedPtr(){} // RVA: 0x23F0990
        public void get_name(){} // RVA: 0x23F0A60
        public void MoveNext(){} // RVA: 0x23F0B70
        public void get_Entry(){} // RVA: 0x23F0BC0
        public void get_Value(){} // RVA: 0x23F0CD0
        public void get_Current(){} // RVA: 0x23F0DA0
        public void set_Current(){} // RVA: 0x23F0F90
    }

    /// <summary>Originally: ÏÎÎÏÌÌÍÌÌÎÍÎÎÌÌÍÏÌÌÏÏÎÏ</summary>
    public class AnimationDisplayNamePrefabName_B6F4
    {
        // ── Methods ──
        public void get_Key(){} // RVA: 0x87C0A0
        public void get_DisplayName(){} // RVA: 0x87BEB0
        public void get_PrefabName(){} // RVA: 0x87C0A0
    }

    /// <summary>Originally: ÍÍÏÌÍÌÍÎÌÍÎÏÎÏÌÌÎÍÍÌÌÏÍ</summary>
    public class AnimationValidateColliderPermissioSetParameter_7461 : ContactReceiver
    {
        public object animator;
        public object droneParameterName;
        public object _useFaceProximity;
        public object _receiverType;

        // ── Methods ──
        public void OnDisable(){} // RVA: 0x23BC1D0
        public void IsReceiver(){} // RVA: 0x23BC290
        public void SetParameter(){} // RVA: 0x23BC300
        public void ValidateColliderPermissions(){} // RVA: 0xC2E4C0
        public void OnDisableInCollisionScene(){} // RVA: 0x23BC290
        public void OnReenableInCollisionScene(){} // RVA: 0x23BC290
        public void PerformShapeUpdate(){} // RVA: 0x23BC290
        public void OnShapeEnter(){} // RVA: 0x23BC290
        public void OnShapeExit(){} // RVA: 0x23BC290
        public void .ctor(){} // RVA: 0x23BC350
        public void Initialize(){} // RVA: 0x23BC290
        public void RemoveFromManagerData(){} // RVA: 0x23BC290
        public void BuildMatchingTagsArray(){} // RVA: 0x23BC290
        public void Start(){} // RVA: 0x23BC3A0
        public void OnEnable(){} // RVA: 0x23BC3D0
    }

    /// <summary>Originally: ÎÍÎÍÌÌÏÌÏÍÌÌÍÍÌÍÍÎÌÌÍÎÎ</summary>
    public class AnimationrightCoachWristTransformleftCoachWristTrComponent_4B15 : MonoBehaviour
    {
        public object handCoachAnimator;
        public object handCoachHeadTransform;
        public object stageCompleteSFX;
        public object leftCoachWristTransform;
        public object rightCoachWristTransform;
        public object leftCoachRenderer;
        public object rightCoachRenderer;
        public object hmdRenderer;
        public object f_862;
        public object f_22B;
        public object f_986;
        public object qmPinchForwardAngle;
        public object qmCircleKeyForwardAngle;
        public object qmPushButtonAngle;
        public object locomotionForwardAngle;
        public object turningForwardAngle;
        public object f_279;
        public object f_8B6;
        public object f_F9A;
        public object f_72B;
        public object f_B52;
        public object f_F4C;
        public object f_3A4;
        public object f_F1E;
        public object f_74C;
        public object f_F68;
        public object f_5CC;
        public object f_369;
        public object circleKeyRootTransform;
        public object circleSocket;
        public object gazeCursor;
        public object gazeCursorOutline;
        public object lineRenderer;
        public object f_7B5;
        public object f_779;
        public object f_095;
        public object f_12E;
        public object f_FCB;
        public object f_835;
        public object f_061;
        public object f_BD8;
        public object f_551;
        public object f_6C8;
        public object f_3CC;
        public object f_D9C;
        public object f_586;
        public object f_9D8;
        public object f_0CF;
        public object f_205;
        public object f_FA1;
        public object qmCircleKeyTweenCurve;
        public object f_4B0;
        public object f_0C6;
        public object f_A6F;
        public object f_3F9;
        public object f_0C0;
        public object f_8DE;
        public object f_03B;
        public object forwardDirectionPreview;

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x124CFB0
        public void Update(){} // RVA: 0x124D010
        public void Awake(){} // RVA: 0x124DB40
        public void .ctor(){} // RVA: 0x124DC40
        public void OnDrawGizmos(){} // RVA: 0x124DDC0
        public void InvokeRepeating(){} // RVA: 0x124E1B0
        public void StartCoroutine(){} // RVA: 0x124E460
        public void StartCoroutine_Auto(){} // RVA: 0x124E6C0
        public void StopCoroutine(){} // RVA: 0x124E750
        public void StopAllCoroutines(){} // RVA: 0x124EB40
        public void get_useGUILayout(){} // RVA: 0x124F690
        public void set_useGUILayout(){} // RVA: 0x124F7E0
        public void get_didStart(){} // RVA: 0x124F840
        public void get_didAwake(){} // RVA: 0x124F910
        public void print(){} // RVA: 0x1250C70
        public void Start(){} // RVA: 0x1250ED0
        public void Internal_IsInvokingAll(){} // RVA: 0x1252130
        public void InvokeDelayed(){} // RVA: 0x1252240
        public void IsObjectMonoBehaviour(){} // RVA: 0x12522D0
        public void StartCoroutineManaged(){} // RVA: 0x12525D0
        public void StartCoroutineManaged2(){} // RVA: 0x12528D0
        public void StopCoroutineManaged(){} // RVA: 0x1252970
        public void StopCoroutineFromEnumeratorManaged(){} // RVA: 0x1252A10
    }

    /// <summary>Originally: ÍÌÎÏÏÍÎÎÌÌÍÍÎÎÎÍÌÏÌÌÏÎÏ</summary>
    public class AnimationtriggerInteractionheightLimitAngleComponent_B483 : MonoBehaviour
    {
        public object _maximumDistance;
        public object _heightLimitAngle;
        public object _triggerInteraction;
        public object f_A58;
        public object f_496;
        public object f_EB3;
        public object f_2EE;
        public object f_9A6;
        public object _curveRenderer;
        public object _curveOffset;
        public object _curveFrequency;
        public object _hitColor;
        public object _missColor;
        public object f_DE1;
        public object f_DBE;
        public object f_4A3;

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x1CE72E0
        public void RaiseCancellation(){} // RVA: 0x1CE7310
        public void IsInvoking(){} // RVA: 0x1CE7C40
        public void CancelInvoke(){} // RVA: 0x1CE83C0
        public void Invoke(){} // RVA: 0xBA9AB0
        public void InvokeRepeating(){} // RVA: 0x1CE8470
        public void StartCoroutine(){} // RVA: 0x1CE8590
        public void StartCoroutine_Auto(){} // RVA: 0x1CE86B0
        public void StopCoroutine(){} // RVA: 0x1CE87D0
        public void StopAllCoroutines(){} // RVA: 0x1CE8960
        public void get_useGUILayout(){} // RVA: 0x1CE8AB0
        public void Awake(){} // RVA: 0x1CE8BD0
        public void .ctor(){} // RVA: 0x1CE8CB0
        public void Initialize(){} // RVA: 0x1CE8D40
        public void print(){} // RVA: 0x1CE9670
        public void Internal_CancelInvokeAll(){} // RVA: 0x1CE9920
        public void Internal_IsInvokingAll(){} // RVA: 0x1CE9AB0
        public void InvokeDelayed(){} // RVA: 0x1CE9D60
        public void IsObjectMonoBehaviour(){} // RVA: 0x1CEA090
        public void StartCoroutineManaged(){} // RVA: 0x1CEA1B0
        public void StartCoroutineManaged2(){} // RVA: 0x1CEA440
        public void StopCoroutineManaged(){} // RVA: 0x1CEA5D0
    }

    /// <summary>Originally: ÍÎÍÍÌÎÌÍÌÏÏÏÏÎÎÍÍÎÌÍÌÌÏ</summary>
    public class ProcessRootMotionProcessAnimation_36F6 : ValueType
    {
        public object f_870;
        public object f_669;
        public object f_CB1;
        public object f_61B;
        public object f_319;
        public object f_06B;
        public object f_763;
        public object f_6D5;
        public object f_BDE;
        public object f_BE2;
        public object f_80F;
        public object f_33B;
        public object f_97E;
        public object f_6E7;

        // ── Methods ──
        public void Equals(){} // RVA: 0x1A700
        public void ProcessRootMotion(){} // RVA: 0x3FC0
        public void DefaultEquals(){} // RVA: 0x3FC0
        public void GetHashCode(){} // RVA: 0x3FC0
        public void InternalGetHashCode(){} // RVA: 0x3FC0
        public void ToString(){} // RVA: 0x3FC0
        public void ProcessAnimation(){} // RVA: 0x1A740
        // ── Unresolved (hash) ──
        public void m_BDD(){} // RVA: 0x3FC0
    }

    /// <summary>Originally: ÍÍÍÏÏÍÎÍÍÍÏÌÎÍÏÌÌÌÎÌÏÏÌ</summary>
    public class ProcessRootMotionProcessAnimation_F2FD : ValueType
    {
        public object f_3E1;
        public object f_114;
        public object f_64D;

        // ── Methods ──
        public void Equals(){} // RVA: 0x55C90
        public void InternalEquals(){} // RVA: 0x55CD0
        public void ProcessRootMotion(){} // RVA: 0x55D10
        public void GetHashCode(){} // RVA: 0x3FC0
        public void InternalGetHashCode(){} // RVA: 0x55D50
        public void ToString(){} // RVA: 0x3FC0
        public void .ctor(){} // RVA: 0x55D90
        public void Initialize(){} // RVA: 0x55DD0
        public void ProcessAnimation(){} // RVA: 0x3FC0
        // ── Unresolved (hash) ──
        public void m_EB1(){} // RVA: 0x3FC0
        public void m_944(){} // RVA: 0x55E10
    }

    /// <summary>Originally: ÍÏÍÍÍÍÏÏÍÍÎÎÌÏÎÏÌÌÏÏÍÎÌ</summary>
    public class VRCMotionState : MonoBehaviour
    {
        public object _m_CancellationTokenSource;
        public object f_439;
        public object f_453;
        public object f_4A0;
        public object f_CF4;
        public object f_B43;
        public object f_D98;
        public object f_113;
        public object f_9F8;
        public object f_75A;
        public object f_787;
        public object f_4D7;
        public object f_9B1;
        public object f_B98;
        public object f_C94;
        public object f_953;
        public object f_650;
        public object f_54B;
        public object f_7B7;
        public object f_A71;
        public object f_3B0;
        public object f_87E;
        public object f_537;
        public object f_B85;
        public object f_9E5;
        public object f_EC3;
        public object f_7CD;
        public object f_874;
        public object f_412;
        public object f_9E0;
        public object f_9A6;
        public object f_25A;
        public object f_B95;
        public object f_ED4;
        public object f_8BD;
        public object f_B44;
        public object f_57B;
        public object f_C12;
        public object f_A1B;
        public object f_BDE;
        public object f_D1D;
        public object f_B34;
        public object f_11B;
        public object f_94D;
        public object f_5EA;
        public object f_E73;
        public object f_ED0;
        public object f_EAC;
        public object f_C7E;
        public object f_1E3;
        public object f_324;
        public object f_52D;
        public object f_A26;
        public object f_94B;
        public object f_CC2;
        public object f_A3B;
        public object f_560;
        public object f_0EA;
        public object f_861;
        public object f_0E7;
        public object f_3F5;
        public object f_BCE;
        public object f_D64;
        public object f_392;
        public object f_D9E;
        public object f_C59;
        public object f_6C0;
        public object f_C5C;
        public object f_2C3;
        public object f_60D;
        public object f_F2D;
        public object f_22B;
        public object f_285;
        public object f_8B5;
        public object f_0B9;
        public object f_056;
        public object f_446;
        public object f_E34;

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x1F26440
        public void RaiseCancellation(){} // RVA: 0x1F26D30
        public void .ctor(){} // RVA: 0x1F27170
        public void Initialize(){} // RVA: 0x1F274A0
        public void Invoke(){} // RVA: 0x1F27770
        public void InvokeRepeating(){} // RVA: 0x1F278C0
        public void StartCoroutine(){} // RVA: 0x1F281D0
        public void StartCoroutine_Auto(){} // RVA: 0x1F28210
        public void StopCoroutine(){} // RVA: 0x1F28580
        public void StopAllCoroutines(){} // RVA: 0x1F28680
        public void get_useGUILayout(){} // RVA: 0x1F29980
        public void set_useGUILayout(){} // RVA: 0x1F29C40
        public void get_didStart(){} // RVA: 0x1F29F90
        public void get_didAwake(){} // RVA: 0x1F2A5C0
        public void print(){} // RVA: 0x1F2ADB0
        public void GetCurrentMotion(){} // RVA: 0x1F2AE10
        public void Internal_IsInvokingAll(){} // RVA: 0x1F2B6B0
        public void InvokeDelayed(){} // RVA: 0x1F2BA90
        public void IsObjectMonoBehaviour(){} // RVA: 0x1F2C320
        public void StartCoroutineManaged(){} // RVA: 0xB70160
        public void StartCoroutineManaged2(){} // RVA: 0x1F2C420
        public void CancelInvoke(){} // RVA: 0x1F2C630
        public void StopCoroutineFromEnumeratorManaged(){} // RVA: 0x1F2C950
        public void GetScriptClassName(){} // RVA: 0x1F2CB40
        public void OnCancellationTokenCreated(){} // RVA: 0x1F281D0
        public void OnEnable(){} // RVA: 0xBBFF90
        public void StopCoroutine_Injected(){} // RVA: 0x1F2CC80
        public void FixedUpdate(){} // RVA: 0x1F2CD90
        public void get_useGUILayout_Injected(){} // RVA: 0x1F2E820
        public void set_useGUILayout_Injected(){} // RVA: 0x1F2EC70
        public void get_didStart_Injected(){} // RVA: 0x1F2ED40
        public void get_didAwake_Injected(){} // RVA: 0x1F2F000
        public void Internal_CancelInvokeAll_Injected(){} // RVA: 0x1F2F2D0
        public void Internal_IsInvokingAll_Injected(){} // RVA: 0x1F2F7D0
        public void Start(){} // RVA: 0x1F30670
        public void OnDrawGizmos(){} // RVA: 0x1F31CB0
        public void IsInvoking_Injected(){} // RVA: 0x1F31FF0
        public void IsObjectMonoBehaviour_Injected(){} // RVA: 0x1F320E0
        public void StartCoroutineManaged_Injected(){} // RVA: 0x1F32130
        public void StartCoroutineManaged2_Injected(){} // RVA: 0x1F321A0
        public void StopCoroutineManaged_Injected(){} // RVA: 0x1F323B0
        public void StopCoroutineFromEnumeratorManaged_Injected(){} // RVA: 0x1F32790
        public void Update(){} // RVA: 0x1F327B0
        public void LateUpdate(){} // RVA: 0x1F32FF0
        public void OnCollisionEnter(){} // RVA: 0x1F334E0
        public void OnCollisionStay(){} // RVA: 0x1F339A0
        public void OnCollisionExit(){} // RVA: 0x1F281D0
        public void OnTriggerEnter(){} // RVA: 0x1F33C80
        public void OnTriggerStay(){} // RVA: 0x1F33D70
        public void OnTriggerExit(){} // RVA: 0xBBFF90
        public void OnDisable(){} // RVA: 0x1F34160
        public void OnDestroy(){} // RVA: 0x1F345E0
        public void OnApplicationPause(){} // RVA: 0x1F346F0
        public void OnApplicationQuit(){} // RVA: 0x1F34BB0
        public void Awake(){} // RVA: 0x1F34D00
        // ── Unresolved (hash) ──
        public void m_1CD(){} // RVA: 0x1F34030
    }

}