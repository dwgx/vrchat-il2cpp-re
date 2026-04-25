// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.RealisticEyeMovements.RealisticEyeMovements
// Classes: 8
// Methods: 211

namespace ThirdParty.RealisticEyeMovements.RealisticEyeMovements
{
    public class ControlData : Object
    {
        public 0x6B014F08 eyeControl; // 0x10
        public UnityEngine.Transform leftEye; // 0x18
        public UnityEngine.Transform rightEye; // 0x20
        public float maxEyeUpBoneAngle; // 0x28
        public float maxEyeDownBoneAngle; // 0x2C
        public float maxEyeUpEyeballAngle; // 0x30
        public float maxEyeDownEyeballAngle; // 0x34
        public bool isEyeBallDefaultSet; // 0x38
        public bool isEyeBoneDefaultSet; // 0x39
        public bool isEyeBallLookUpSet; // 0x3A
        public bool isEyeBoneLookUpSet; // 0x3B
        public bool isEyeBallLookDownSet; // 0x3C
        public bool isEyeBoneLookDownSet; // 0x3D
        public RealisticEyeMovements.EyeRotationLimiter leftBoneEyeRotationLimiter; // 0x40
        public RealisticEyeMovements.EyeRotationLimiter rightBoneEyeRotationLimiter; // 0x48
        public RealisticEyeMovements.EyeRotationLimiter leftEyeballEyeRotationLimiter; // 0x50
        public RealisticEyeMovements.EyeRotationLimiter rightEyeballEyeRotationLimiter; // 0x58
        public 0x6B014F60 eyelidControl; // 0x60
        public 0x6B014FB8 eyelidBoneMode; // 0x64
        public bool eyelidsFollowEyesVertically; // 0x68
        public UnityEngine.Transform upperEyeLidLeft; // 0x70
        public UnityEngine.Transform upperEyeLidRight; // 0x78
        public UnityEngine.Transform lowerEyeLidLeft; // 0x80
        public UnityEngine.Transform lowerEyeLidRight; // 0x88
        public bool isEyelidBonesDefaultSet; // 0x90
        public bool isEyelidBonesClosedSet; // 0x91
        public bool isEyelidBonesLookUpSet; // 0x92
        public bool isEyelidBonesLookDownSet; // 0x93
        public RealisticEyeMovements.EyelidRotationLimiter upperLeftLimiter; // 0x98
        public RealisticEyeMovements.EyelidRotationLimiter upperRightLimiter; // 0xA0
        public RealisticEyeMovements.EyelidRotationLimiter lowerLeftLimiter; // 0xA8
        public RealisticEyeMovements.EyelidRotationLimiter lowerRightLimiter; // 0xB0
        public float eyeWidenOrSquint; // 0xB8
        public EyelidPositionBlendshape[] blendshapesForBlinking; // 0xC0
        public EyelidPositionBlendshape[] blendshapesForLookingUp; // 0xC8
        public EyelidPositionBlendshape[] blendshapesForLookingDown; // 0xD0
        public BlendshapesConfig[] blendshapesConfigs; // 0xD8
        public bool isEyelidBlendshapeDefaultSet; // 0xE0
        public bool isEyelidBlendshapeClosedSet; // 0xE1
        public bool isEyelidBlendshapeLookUpSet; // 0xE2
        public bool isEyelidBlendshapeLookDownSet; // 0xE3

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFAC44FF0A0
        public void Equals(){} // RVA: 0x7FFAC44FF3D0
        public void GetHashCode(){} // RVA: 0x7FFAC44FFAE0
        public void .ctor(){} // RVA: 0x7FFAC45007A0
        public void Initialize(){} // RVA: 0x7FFAC4500CB0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFAC4500CD0
        public void GetCachedPtr(){} // RVA: 0x7FFAC4500EF0
        public void get_name(){} // RVA: 0x7FFAC4501230
        public void set_name(){} // RVA: 0x7FFAC4501510
        public void Instantiate(){} // RVA: 0x7FFAC4501790
        public void ToString(){} // RVA: 0x7FFAC4501AC0
        public void Instantiate_07E0E98FFE9A(){} // RVA: 0x7FFAC4501B10
        public void ToString_A72D306FA0CC(){} // RVA: 0x7FFAC4501C20
        public void UpdateConditionalField(){} // RVA: 0x7FFAC4501C60
        public void GetIndexedField(){} // RVA: 0x7FFAC4501F90
        public void RetrieveAndProcessInternalData(){} // RVA: 0x7FFAC4501FD0
        public void InitializeStaticContext(){} // RVA: 0x7FFAC4502F70
        public void GetInitializedValue(){} // RVA: 0x7FFAC45032A0
        public void ToString_A3675EE847AB(){} // RVA: 0x7FFAC45041C0
        public void Destroy(){} // RVA: 0x7FFAC45043E0
        public void ProcessIndexedEyeControl(){} // RVA: 0x7FFAC45050B0
        public void DestroyImmediate(){} // RVA: 0x7FFAC4505640
        public void SetIndexedBytesConditional(){} // RVA: 0x7FFAC4506070
        public void FindObjectsOfType(){} // RVA: 0x7FFAC4506630
        public void GetIndexedBooleanConditional(){} // RVA: 0x7FFAC4506910
        public void FindObjectsByType(){} // RVA: 0x7FFAC4500CB0
        public void SetIndexedByteConditional(){} // RVA: 0x7FFAC4507190
        public void DontDestroyOnLoad(){} // RVA: 0x7FFAC45072A0
    }

    public class EyeAndHeadAnimator : MonoBehaviour
    {
        public float _destroyCancellationToken;
        public float _useGUILayout;
        public float f_D5E;
        public float f_387;
        public System.Action f_8EF; // 0x20
        public float f_9AE; // 0x28
        public float f_374; // 0x2C
        public UnityEngine.Transform f_3A5; // 0x30
        public UnityEngine.Quaternion ÌÏÏÍÍÏÏÎÌÎÍÍÎÏÏÏÌÏÎÌÎÌÍ; // 0x38
        public 0x6B015328 ÎÍÏÍÌÎÌÌÏÍÍÏÍÍÎÏÍÍÏÍÏÏÎ; // 0x48
        public bool useMicroSaccades; // 0x4C
        public bool useMacroSaccades; // 0x4D
        public bool kDrawSightlinesInEditor; // 0x4E
        public RealisticEyeMovements.ControlData controlData; // 0x50
        public float kMinNextBlinkTime; // 0x58
        public float kMaxNextBlinkTime; // 0x5C
        public bool eyelidsFollowEyesVertically; // 0x60
        public float <ÏÍÎÎÍÎÌÌÏÏÌÏÌÎÌÏÍÎÎÍÎÌÍ>k__BackingField; // 0x64
        public float <ÌÍÏÎÌÏÍÎÏÌÎÍÍÌÌÍÏÎÎÏÎÏÌ>k__BackingField; // 0x68
        public float ÎÏÍÎÌÍÎÏÌÌÏÏÎÎÍÍÎÎÌÍÌÌÏ; // 0x6C
        public bool ÏÍÍÍÎÍÏÌÍÌÌÏÍÍÍÍÌÏÎÏÍÌÌ; // 0x70
        public bool ÏÏÌÎÏÏÎÏÎÌÌÏÍÏÏÏÍÍÍÌÍÌÌ; // 0x71
        public bool ÍÎÏÍÍÏÌÍÎÍÎÎÏÌÎÏÌÌÎÍÍÏÏ; // 0x72
        public float ÎÍÍÌÌÏÍÌÍÌÏÍÍÏÎÍÌÎÎÌÌÌÎ; // 0x74
        public 0x6B015380 ÍÌÎÌÌÌÎÍÎÌÍÍÏÍÏÌÌÍÏÌÌÏÏ; // 0x78
        public float ÍÏÍÏÎÍÎÍÌÍÏÍÎÎÎÍÏÌÍÍÍÌÌ; // 0x7C
        public float ÎÏÍÌÏÍÍÍÎÍÍÎÌÍÏÏÌÎÍÍÌÍÍ; // 0x80
        public bool ÏÏÍÎÌÍÏÏÍÍÎÏÎÍÍÌÏÌÍÌÌÎÎ; // 0x84
        public float ÎÏÏÎÍÎÍÏÏÎÎÏÌÌÎÏÌÎÎÏÎÏÎ;
        public float ÎÏÏÌÏÌÍÏÌÌÌÌÍÏÏÎÏÍÌÍÌÍÍ;
        public float ÌÌÍÍÏÍÍÏÏÌÏÌÍÍÍÏÏÌÏÎÍÍÏ;
        public float ÍÎÌÎÏÍÏÏÌÌÌÍÍÌÌÏÍÏÍÎÍÏÎ;
        public float ÌÏÏÏÏÌÎÌÌÏÏÏÍÍÏÏÏÌÎÎÍÍÎ;
        public float maxEyeHorizAngle; // 0x88
        public float maxEyeHorizAngleTowardsNose; // 0x8C
        public float crossEyeCorrection; // 0x90
        public float nervousness; // 0x94
        public float limitHeadAngle; // 0x98
        public float <ÎÏÍÌÎÌÍÌÎÍÏÏÌÎÍÍÏÏÏÎÏÎÍ>k__BackingField; // 0x9C
        public float <ÏÎÌÍÌÍÏÌÍÌÏÍÍÎÌÌÍÎÎÏÌÎÎ>k__BackingField; // 0xA0
        public UnityEngine.Transform ÎÍÎÏÌÏÎÏÍÏÌÍÌÌÌÎÍÌÎÌÌÌÏ; // 0xA8
        public UnityEngine.Transform ÏÍÍÏÍÍÍÏÏÏÏÍÏÎÌÏÏÏÎÏÍÍÎ; // 0xB0
        public float ÌÌÎÏÍÎÍÍÌÎÌÌÏÏÍÍÍÍÌÍÌÎÎ; // 0xB8
        public float ÌÏÎÏÎÎÍÍÌÌÌÎÎÏÎÌÎÌÏÍÌÎÏ; // 0xBC
        public float ÏÍÏÏÌÏÎÎÌÍÏÏÏÏÍÍÎÏÌÌÎÎÎ; // 0xC0
        public float ÏÎÏÏÏÏÎÎÎÍÌÏÌÎÎÎÍÏÎÎÎÏÌ; // 0xC4
        public float ÏÎÌÍÎÍÌÍÎÏÌÌÎÎÏÌÌÍÍÏÌÌÎ; // 0xC8
        public float ÎÎÌÍÍÏÌÌÍÍÎÍÎÎÍÌÏÏÎÏÏÏÌ; // 0xCC
        public float ÎÍÌÏÍÏÍÌÏÎÌÍÍÏÍÎÎÎÌÎÏÏÏ; // 0xD0
        public float ÎÏÌÌÎÎÍÌÏÎÍÌÌÎÎÍÎÍÍÎÌÏÏ; // 0xD4
        public float ÌÎÏÌÎÌÌÎÎÌÏÎÎÍÌÌÎÌÍÏÎÏÎ; // 0xD8
        public float ÌÏÌÌÏÎÎÌÌÏÎÏÎÎÌÌÌÎÏÏÎÍÌ; // 0xDC
        public float ÎÌÍÎÌÏÍÏÌÎÌÏÎÏÌÍÎÏÌÎÍÏÍ; // 0xE0
        public float ÏÌÍÏÍÍÏÍÍÌÎÌÌÍÎÏÌÍÌÍÌÌÍ; // 0xE4
        public float ÎÍÏÌÍÍÎÏÏÌÍÎÏÌÌÎÏÎÌÍÌÌÍ; // 0xE8
        public float ÌÍÍÌÏÍÍÌÌÎÌÏÌÌÎÏÏÎÍÎÌÏÌ; // 0xEC
        public float ÎÌÏÍÍÌÎÏÎÌÌÎÎÍÍÎÍÌÎÏÎÌÏ; // 0xF0
        public float ÍÍÎÏÏÌÌÏÎÏÎÎÏÎÍÎÌÌÏÏÏÎÌ; // 0xF4
        public float ÏÍÎÎÌÍÎÍÏÍÍÍÎÎÌÎÏÍÎÌÎÌÎ; // 0xF8
        public float ÌÌÏÌÎÏÍÍÏÌÌÎÏÏÍÍÎÏÌÎÍÍÎ; // 0xFC
        public float ÍÏÎÏÏÌÏÍÎÍÌÌÍÍÏÍÌÏÍÏÌÏÎ; // 0x100
        public float ÎÍÍÍÌÎÍÌÏÎÎÎÍÌÌÏÎÎÎÏÏÌÎ; // 0x104
        public float ÌÎÏÌÎÏÌÌÏÍÎÎÌÎÏÍÏÍÏÎÎÌÌ; // 0x108
        public float ÌÏÌÏÌÎÏÌÎÎÍÍÎÍÎÌÍÍÎÏÎÎÌ;
        public float ÎÎÌÍÏÎÏÏÏÏÎÌÍÏÌÎÏÎÌÌÍÍÌ;
        public ÎÌÍÌÏÌÏÌÍÎÏÎÏÎÎÌÌÍÍÏÏÎÍ ÎÌÍÏÎÌÍÎÏÍÍÍÌÌÍÎÎÌÍÏÍÎÎ; // 0x10C
        public UnityEngine.Vector3 ÌÍÌÌÍÎÌÍÎÎÏÌÎÎÏÎÍÎÍÎÍÎÍ; // 0x134
        public UnityEngine.Vector3 ÏÏÎÎÎÍÌÍÎÍÎÏÎÎÏÎÍÌÎÍÏÎÍ; // 0x140
        public float ÍÎÎÎÍÌÍÎÏÏÎÍÏÍÏÌÏÌÎÏÌÏÍ; // 0x14C
        public float ÎÏÏÌÏÍÍÏÎÏÏÏÌÍÏÌÌÌÏÍÎÎÎ; // 0x150
        public bool ÎÏÏÌÏÏÎÌÍÌÏÌÏÏÌÌÎÌÎÏÎÍÎ; // 0x154
        public float ÏÍÏÎÍÎÌÍÏÎÎÌÏÎÍÍÌÏÌÎÎÍÎ; // 0x158
        public float ÎÏÎÎÌÏÌÏÎÎÌÏÏÍÏÎÎÍÍÌÌÎÎ; // 0x15C
        public float ÏÌÍÏÎÏÌÎÎÏÎÎÌÏÏÍÍÎÌÌÎÌÌ; // 0x160
        public UnityEngine.Animator ÏÎÎÎÏÌÍÌÎÎÌÎÌÌÎÌÏÏÏÌÍÏÌ; // 0x168
        public bool useFinalIK; // 0x170
        public RootMotion.FinalIK.LookAtIK ÌÍÍÌÏÌÏÍÍÌÍÏÏÍÏÍÍÏÏÍÎÎÎ; // 0x178
        public RootMotion.FinalIK.VRIK ÎÍÏÏÍÌÍÎÌÏÌÌÍÎÎÏÎÎÍÏÌÌÍ; // 0x180
        public RootMotion.FinalIK.FullBodyBipedIK ÍÍÌÌÌÎÌÌÎÌÎÎÏÍÍÌÌÌÎÏÎÏÌ; // 0x188
        public UnityEngine.Transform ÎÎÏÏÍÏÎÌÌÌÌÍÌÍÍÎÍÏÌÌÎÏÌ; // 0x190
        public UnityEngine.Transform ÏÏÏÎÎÍÎÌÏÍÌÎÌÎÌÎÏÏÏÎÎÍÌ; // 0x198
        public UnityEngine.Transform ÏÎÌÌÌÏÎÎÎÎÏÍÏÎÌÌÏÌÌÎÌÌÎ; // 0x1A0
        public UnityEngine.Transform ÏÍÏÏÍÎÍÌÎÌÏÏÎÌÍÏÎÏÏÎÍÎÏ; // 0x1A8
        public UnityEngine.Transform ÌÏÍÌÎÌÌÌÍÌÌÎÏÏÎÌÏÏÌÎÍÎÍ; // 0x1B0
        public UnityEngine.Transform ÏÎÌÍÎÌÏÍÍÏÌÏÍÍÏÏÍÏÎÏÍÍÍ; // 0x1B8
        public UnityEngine.Transform ÌÍÎÏÎÌÏÌÎÍÌÌÍÏÏÌÎÎÏÏÎÎÍ; // 0x1C0
        public UnityEngine.Transform ÍÌÍÏÍÍÏÍÍÏÎÌÎÍÎÏÍÍÍÍÏÍÏ; // 0x1C8
        public UnityEngine.Transform[] ÎÎÎÍÎÌÎÏÏÎÌÍÍÎÏÎÌÎÎÏÏÌÍ; // 0x1D0
        public int ÌÏÎÍÎÎÏÎÎÍÏÎÍÏÏÏÎÍÌÍÏÎÏ; // 0x1D8
        public UnityEngine.Transform ÌÏÏÌÏÎÏÍÎÍÎÏÏÌÎÎÍÌÎÌÏÏÌ; // 0x1E0
        public UnityEngine.Transform <ÍÏÏÎÎÏÌÍÎÏÍÍÎÌÎÏÎÏÌÏÎÍÎ>k__BackingField; // 0x1E8
        public UnityEngine.Transform ÏÍÎÎÎÍÏÍÌÌÏÍÌÏÌÎÎÏÍÍÍÏÌ; // 0x1F0
        public bool ÍÌÌÌÏÎÍÍÌÍÍÍÏÏÎÎÏÏÎÎÍÍÌ; // 0x1F8
        public UnityEngine.Quaternion ÎÌÌÍÌÌÍÌÎÎÎÎÌÎÏÍÎÏÎÏÍÌÏ; // 0x1FC
        public UnityEngine.Quaternion ÏÏÎÏÌÎÌÏÏÎÌÌÏÏÏÌÍÎÎÌÌÌÎ; // 0x20C
        public UnityEngine.Quaternion ÍÏÎÏÏÏÏÍÍÎÎÍÏÍÍÍÏÏÎÎÎÎÍ; // 0x21C
        public UnityEngine.Quaternion ÍÏÍÍÍÏÏÌÎÏÌÎÍÎÎÌÏÌÎÍÍÌÏ; // 0x22C
        public UnityEngine.Vector3 ÎÍÍÎÍÌÏÏÌÍÌÏÍÏÌÎÎÍÎÏÍÍÏ; // 0x23C
        public UnityEngine.Vector3 ÌÎÍÍÌÎÏÎÌÏÏÍÏÎÎÎÎÏÍÎÎÌÍ; // 0x248
        public UnityEngine.Quaternion ÍÎÍÍÎÎÍÏÏÍÌÍÏÎÍÍÎÌÏÎÌÏÎ; // 0x254
        public UnityEngine.Quaternion ÌÍÏÏÏÎÏÎÏÏÌÌÎÎÌÎÌÌÌÎÍÍÎ; // 0x264
        public UnityEngine.Quaternion ÎÎÎÍÎÍÌÍÏÏÍÍÌÏÍÎÎÏÌÏÍÌÎ; // 0x274
        public UnityEngine.Quaternion ÌÍÌÌÍÏÏÍÍÎÏÍÌÍÍÏÍÍÌÌÌÎÏ; // 0x284
        public UnityEngine.Vector3 <ÍÍÏÎÎÏÏÍÍÏÏÍÍÍÌÎÎÎÎÎÎÎÏ>k__BackingField; // 0x294
        public UnityEngine.Vector3 ÍÎÍÍÏÎÎÏÎÎÍÎÎÌÌÍÎÎÍÌÌÏÏ; // 0x2A0
        public UnityEngine.Vector3 ÎÎÎÎÏÏÎÏÎÌÏÏÌÍÏÏÍÏÍÍÎÍÏ; // 0x2AC
        public float ÍÏÌÎÏÏÏÌÍÎÌÍÌÍÎÍÌÎÎÏÍÍÌ; // 0x2B8
        public float ÍÎÍÎÍÌÎÍÏÍÎÏÏÎÍÍÌÌÎÎÏÏÏ; // 0x2BC
        public float ÎÌÍÍÍÌÍÌÌÎÍÌÎÎÍÍÎÏÌÏÍÎÏ; // 0x2C0
        public float ÏÍÍÍÎÌÎÏÏÏÌÏÏÍÌÎÏÍÌÌÏÌÏ; // 0x2C4
        public bool <ÏÏÌÍÍÍÏÌÍÌÏÌÍÎÍÎÌÏÎÎÏÎÎ>k__BackingField; // 0x2C8
        public bool <ÏÍÌÍÍÏÏÏÏÏÌÎÎÌÌÏÌÌÌÌÌÎÎ>k__BackingField; // 0x2C9
        public bool ÏÌÏÍÎÍÌÎÏÎÌÍÌÏÏÏÌÏÍÎÍÍÏ; // 0x2CA
        public bool ÌÎÍÍÏÏÎÍÎÏÎÌÌÍÍÏÌÌÏÍÎÎÏ; // 0x2CB
        public 0x6B0153D8 ÎÎÍÌÌÍÌÏÍÌÍÌÍÎÍÌÍÍÌÌÎÎÏ; // 0x2CC
        public 0x6B015488 ÌÎÎÌÎÏÍÎÏÍÌÌÎÏÍÎÏÎÍÍÎÏÎ; // 0x2D0
        public 0x6B0154E0 ÌÎÌÎÌÌÎÍÏÎÌÏÎÌÎÍÌÏÏÏÍÎÌ; // 0x2D4
        public System.Collections.Generic.Dictionary`2<string,RealisticEyeMovements.EyeAndHeadAnimatorForExport> ÎÍÌÏÎÌÏÍÌÎÍÌÎÎÏÏÎÍÍÎÌÍÍ;
        public bool ÌÏÍÍÌÏÎÌÏÎÌÎÏÏÌÍÌÌÌÌÍÍÍ; // 0x2D8
        public VRC.Profiling.ProfilerMarker ÍÏÌÎÏÏÌÏÍÍÌÎÏÍÌÌÌÌÌÌÏÍÌ; // 0x8

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFAC450C8F0
        public void RaiseCancellation(){} // RVA: 0x7FFAC450CA50
        public void set_EnginePower(){} // RVA: 0x7FFAC2F4A070
        public void CancelInvoke_6E11564B52EF_6E11564B52EF(){} // RVA: 0x7FFAC4515570 | overloaded x2
        public void OnDestroy(){} // RVA: 0x7FFAC450CCF0
        public void InvokeRepeating(){} // RVA: 0x7FFAC450CEC0
        public void OnApplicationQuit(){} // RVA: 0x7FFAC450D0C0
        public void IsInvoking(){} // RVA: 0x7FFAC450D890
        public void StartCoroutine(){} // RVA: 0x7FFAC450DD40
        public void get_CurrentSteerAngle(){} // RVA: 0x7FFAC2F42500
        public void Update(){} // RVA: 0x7FFAC450E090
        public void StartCoroutine_Auto(){} // RVA: 0x7FFAC342CFA0
        public void StopCoroutine(){} // RVA: 0x7FFAC450E280
        public void OnTriggerStay(){} // RVA: 0x7FFAC2F21310
        public void OnTriggerExit(){} // RVA: 0x7FFAC450E2C0
        public void StopAllCoroutines(){} // RVA: 0x7FFAC450E3A0
        public void get_useGUILayout(){} // RVA: 0x7FFAC450F150
        public void set_onFocusSelectAll(){} // RVA: 0x7FFAC450F260
        public void .cctor(){} // RVA: 0x7FFAC450F270
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFAC450F400
        public void get_onFocusSelectAll(){} // RVA: 0x7FFAC3E74AA0
        public void InvokeDelayed(){} // RVA: 0x7FFAC450F410
        public void Computetime(){} // RVA: 0x7FFAC450F570
        public void IsInvoking_520ED276336B(){} // RVA: 0x7FFAC450F5F0
        public void OnCollisionExit_F5774FDC51D1_F5774FDC51D1(){} // RVA: 0x7FFAC4513010 | overloaded x2
        public void OnCollisionStay_217BB3527753_217BB3527753(){} // RVA: 0x7FFAC4512D90 | overloaded x2
        public void StartCoroutineManaged2(){} // RVA: 0x7FFAC2F21310
        public void StopCoroutineManaged(){} // RVA: 0x7FFAC450FD20
        public void Awake(){} // RVA: 0x7FFAC2F21310
        public void GetScriptClassName(){} // RVA: 0x7FFAC450FE00
        public void OnCancellationTokenCreated(){} // RVA: 0x7FFAC450FFD0
        public void FixedUpdate(){} // RVA: 0x7FFAC45105D0
        public void InitializeAnimatorDependencies(){} // RVA: 0x7FFAC45106B0
        public void Computeup(){} // RVA: 0x7FFAC450F400
        public void ComputeEyeHeadAnimationPosition_79A9C81D3213_79A9C81D3213(){} // RVA: 0x7FFAC4518D40 | overloaded x2
        public void Computeup_01CA61583B80(){} // RVA: 0x7FFAC4510E00
        public void OnApplicationPause(){} // RVA: 0x7FFAC45113C0
        public void GetCurrentHealth(){} // RVA: 0x7FFAC2F4A040
        public void set_bakingProgress(){} // RVA: 0x7FFAC2F4A050
        public void GetArrowVelocity(){} // RVA: 0x7FFAC3142100
        public void OnCollisionEnter(){} // RVA: 0x7FFAC4511F70
        public void get_onTouchScreenKeyboardStatusChanged(){} // RVA: 0x7FFAC39B1060
        public void OnAnimatorIK(){} // RVA: 0x7FFAC45131A0
        public void Start(){} // RVA: 0x7FFAC4513450
        public void SetEyeHeadAnimProperty(){} // RVA: 0x7FFAC4513550
        public void SetEyeHeadAnimProperty_D35F8BB82557(){} // RVA: 0x7FFAC4513560
        public void OnDrawGizmos(){} // RVA: 0x7FFAC45137E0
        public void OnDisable(){} // RVA: 0x7FFAC4514E80
        public void Computeup_A3A30D2003E1(){} // RVA: 0x7FFAC4514EE0
        public void Doop_Multiply(){} // RVA: 0x7FFAC4514FD0
        public void OnDisable_impl(){} // RVA: 0x7FFAC45150C0
        public void OnBecameVisible(){} // RVA: 0x7FFAC45150E0
        public void OnBecameInvisible(){} // RVA: 0x7FFAC45153E0
        public void OnDisableImpl(){} // RVA: 0x7FFAC4515400
        public void DoDestroyImmediate_A15(){} // RVA: 0x7FFAC4515480
        public void OnTriggerEnter(){} // RVA: 0x7FFAC4515660
        public void GetHeadLookTargetPosition(){} // RVA: 0x7FFAC4515730
        public void Getposition(){} // RVA: 0x7FFAC4515820
        public void set_touchpadClicked(){} // RVA: 0x7FFAC39AC5A0
        public void set_virtualGreenScreenDepthTolerance(){} // RVA: 0x7FFAC3139A60
        public void DoRender_7AB(){} // RVA: 0x7FFAC45159B0
        public void RenderEyeHeadDebug(){} // RVA: 0x7FFAC45159D0
        public void DoRange(){} // RVA: 0x7FFAC4515C80
        public void GetEyeHeadAnimationState_4B6FF54EF567_4B6FF54EF567(){} // RVA: 0x7FFAC4518C00 | overloaded x2
        public void GetAnimatorHeadLookState(){} // RVA: 0x7FFAC4515F30
        public void LateUpdate(){} // RVA: 0x7FFAC4515F40
        public void OnEnable(){} // RVA: 0x7FFAC2F21310
        public void Computebytes(){} // RVA: 0x7FFAC4516200
        public void UpdateTransform(){} // RVA: 0x7FFAC45162D0
        public void SetHeadLookTargetAndState(){} // RVA: 0x7FFAC450F400
        public void UpdateHeadLookTargetState(){} // RVA: 0x7FFAC4516EC0
        public void OnCollisionStay_D2E99F9F7768(){} // RVA: 0x7FFAC4517C90
        public void GetEyeHeadAnimationState_2E3FFC8A90B9(){} // RVA: 0x7FFAC45180E0
        public void ComputedeltaTime(){} // RVA: 0x7FFAC4518330
        public void GetAnimatorHeadLookState_FD6A53486A9A(){} // RVA: 0x7FFAC4518500
        public void CalculateLookRotationLimit(){} // RVA: 0x7FFAC4518780
        public void get_EnginePower(){} // RVA: 0x7FFAC2F4A060
        public void .ctor(){} // RVA: 0x7FFAC4518F40
        public void Initialize(){} // RVA: 0x7FFAC4519110
        public void GetTransformPosition(){} // RVA: 0x7FFAC4519170
        public void CalculateAndLimitRotationAngle(){} // RVA: 0x7FFAC45193C0
        public void ComputeParent(){} // RVA: 0x7FFAC451ACB0
    }

    public class EyeAndHeadAnimatorForExport : Object
    {
        public string headBonePath; // 0x10
        public float headSpeedModifier; // 0x18
        public float headWeight; // 0x1C
        public bool useMicroSaccades; // 0x20
        public bool useMacroSaccades; // 0x21
        public bool kDrawSightlinesInEditor; // 0x22
        public ControlDataForExport controlData; // 0x28
        public float kMinNextBlinkTime; // 0x30
        public float kMaxNextBlinkTime; // 0x34
        public bool eyelidsFollowEyesVertically; // 0x38
        public float maxEyeHorizAngle; // 0x3C
        public float maxEyeHorizAngleTowardsNose; // 0x40
        public float crossEyeCorrection; // 0x44
        public float nervousness; // 0x48
        public float limitHeadAngle; // 0x4C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class EyeRotationLimiter : Object
    {
        public UnityEngine.Transform transform; // 0x10
        public UnityEngine.Quaternion defaultQ; // 0x18
        public UnityEngine.Quaternion lookUpQ; // 0x28
        public UnityEngine.Quaternion lookDownQ; // 0x38
        public float maxUpAngle; // 0x48
        public float maxDownAngle; // 0x4C
        public bool isLookUpSet; // 0x50
        public bool isLookDownSet; // 0x51

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFAC44FBBC0
        public void Equals(){} // RVA: 0x7FFAC44FC170
        public void GetHashCode(){} // RVA: 0x7FFAC44FC1E0
        public void op_Implicit(){} // RVA: 0x7FFAC44FC170
        public void CompareBaseObjects(){} // RVA: 0x7FFAC44FC390
        public void IsNativeObjectAlive(){} // RVA: 0x7FFAC44FC400
        public void GetCachedPtr(){} // RVA: 0x7FFAC44FC470
        public void get_name(){} // RVA: 0x7FFAC44FC500
        public void set_name(){} // RVA: 0x7FFAC44FC570
        public void Instantiate(){} // RVA: 0x7FFAC44FC5E0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Initialize(){} // RVA: 0x7FFAC44FC7D0
        public void ToString(){} // RVA: 0x7FFAC44FC980
        public void NodeTreeFromSortedDictionary(){} // RVA: 0x7FFAC44FC9C0
        public void ToString_5260B310CAC6(){} // RVA: 0x7FFAC44FCE30
        public void GetLongFromDelegate(){} // RVA: 0x7FFAC44FC570
        public void GetBooleanFromDelegate(){} // RVA: 0x7FFAC44FCEF0
        public void GetIntegerFromDelegate(){} // RVA: 0x7FFAC44FCF80
        public void FailFast(){} // RVA: 0x7FFAC44FCFF0
        public void Destroy(){} // RVA: 0x7FFAC44FC470
    }

    public class EyelidRotationLimiter : Object
    {
        public UnityEngine.Transform transform; // 0x10
        public UnityEngine.Quaternion defaultQ; // 0x18
        public UnityEngine.Quaternion closedQ; // 0x28
        public UnityEngine.Quaternion lookUpQ; // 0x38
        public UnityEngine.Quaternion lookDownQ; // 0x48
        public float eyeMaxDownAngle; // 0x58
        public float eyeMaxUpAngle; // 0x5C
        public UnityEngine.Vector3 defaultPos; // 0x60
        public UnityEngine.Vector3 closedPos; // 0x6C
        public UnityEngine.Vector3 lookUpPos; // 0x78
        public UnityEngine.Vector3 lookDownPos; // 0x84
        public bool isLookUpSet; // 0x90
        public bool isLookDownSet; // 0x91
        public bool isDefaultPosSet; // 0x92
        public bool isClosedPosSet; // 0x93
        public bool isLookUpPosSet; // 0x94
        public bool isLookDownPosSet; // 0x95

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFAC44FD030
        public void Equals(){} // RVA: 0x7FFAC44FD140
        public void GetHashCode(){} // RVA: 0x7FFAC44FD400
        public void op_Implicit(){} // RVA: 0x7FFAC44FD510
        public void CompareBaseObjects(){} // RVA: 0x7FFAC44FDA30
        public void IsNativeObjectAlive(){} // RVA: 0x7FFAC44FDB40
        public void GetCachedPtr(){} // RVA: 0x7FFAC44FE030
        public void get_name(){} // RVA: 0x7FFAC44FE140
        public void set_name(){} // RVA: 0x7FFAC44FE260
        public void Instantiate(){} // RVA: 0x7FFAC44FE2D0
        public void ToString(){} // RVA: 0x7FFAC44FE3E0
        public void .ctor_046FF5FBC3B9(){} // RVA: 0x7FFAC44FE500
        public void GetHashCode_269C910A07D4(){} // RVA: 0x7FFAC44FEA20
        public void NodeTreeFromSortedDictionary(){} // RVA: 0x7FFAC44FD030
        public void ToString_D20A7842AE22(){} // RVA: 0x7FFAC44FEB30
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Initialize(){} // RVA: 0x7FFAC44FEC40
        public void GetIntegerFromDelegate(){} // RVA: 0x7FFAC44FED40
        public void FailFast(){} // RVA: 0x7FFAC44FEDB0
    }

    public class LookTargetController : MonoBehaviour
    {
        public UnityEngine.Transform[] pointsOfInterest; // 0x20
        public float lookAtPlayerRatio; // 0x28
        public float stareBackFactor; // 0x2C
        public float noticePlayerDistance; // 0x30
        public float personalSpaceDistance; // 0x34
        public float minLookTime; // 0x38
        public float maxLookTime; // 0x3C
        public UnityEngine.Transform playerEyeCenter; // 0x40
        public bool keepTargetEvenWhenLost; // 0x48
        public UnityEngine.Events.UnityEvent OnStartLookingAtPlayer; // 0x50
        public UnityEngine.Events.UnityEvent OnStopLookingAtPlayer; // 0x58
        public RealisticEyeMovements.EyeAndHeadAnimator ÎÌÏÍÎÍÍÌÎÎÎÎÌÎÎÌÍÎÏÌÌÌÎ; // 0x60
        public float ÌÍÌÎÏÏÍÏÎÌÎÎÌÏÍÏÏÍÏÎÌÍÍ;
        public UnityEngine.Transform ÎÌÌÍÏÎÍÏÌÌÌÌÏÎÌÎÌÍÍÎÏÍÌ; // 0x68
        public UnityEngine.Transform ÏÌÌÍÍÎÎÍÍÎÏÏÎÍÎÍÍÎÍÍÏÏÏ; // 0x70
        public UnityEngine.Transform ÍÍÌÌÏÌÍÏÏÎÎÌÏÏÎÎÎÌÏÏÎÎÎ; // 0x78
        public UnityEngine.Transform ÎÍÏÏÍÎÌÎÍÏÍÍÎÍÏÌÏÌÌÍÎÍÍ; // 0x80
        public UnityEngine.Transform ÏÏÎÌÍÌÎÎÍÏÌÌÎÍÏÎÎÎÍÏÎÌÌ; // 0x88
        public UnityEngine.GameObject ÌÎÏÍÎÍÍÌÌÌÍÍÎÎÏÎÎÍÏÍÎÍÏ; // 0x90
        public UnityEngine.GameObject ÎÎÌÌÌÎÌÎÏÍÏÎÌÏÎÌÍÎÏÏÍÍÎ; // 0x98
        public UnityEngine.GameObject ÍÍÌÎÍÍÍÌÌÎÌÎÍÎÍÌÏÎÍÎÌÏÎ; // 0xA0
        public UnityEngine.GameObject ÍÌÍÏÍÍÎÎÍÎÏÌÏÍÎÎÎÎÍÏÏÍÍ; // 0xA8
        public float ÍÍÍÍÎÍÌÍÏÎÌÍÎÌÌÍÍÏÌÏÍÍÎ; // 0xB0
        public float ÏÌÌÎÌÍÏÌÌÍÌÍÍÏÌÎÍÎÌÍÏÏÌ; // 0xB4
        public float ÌÎÌÎÎÎÏÎÏÎÏÎÍÎÏÎÌÌÏÎÎÏÎ; // 0xB8
        public float ÎÌÏÎÌÍÌÎÍÏÎÎÌÎÌÎÏÌÎÏÏÌÌ; // 0xBC
        public float ÏÌÍÏÏÍÌÏÌÌÌÍÌÍÎÌÏÎÎÍÌÎÎ; // 0xC0
        public float ÎÌÏÍÌÏÎÌÏÍÏÍÌÎÏÎÎÌÌÏÎÏÍ; // 0xC4
        public float ÏÌÌÌÎÌÌÎÎÍÍÏÏÎÏÎÌÌÏÍÌÎÌ; // 0xC8
        public float ÏÌÏÌÎÍÍÏÎÏÍÎÏÌÎÎÌÍÏÏÎÏÍ; // 0xCC
        public bool ÌÎÏÎÏÎÏÎÌÎÏÎÍÍÍÌÌÏÎÍÎÍÎ; // 0xD0
        public bool ÏÍÌÍÎÎÎÏÌÍÍÍÎÏÎÍÌÏÎÌÎÎÎ; // 0xD1
        public bool ÌÏÌÎÎÏÍÍÎÏÌÏÍÏÎÍÏÌÏÍÍÌÎ; // 0xD2
        public bool ÏÏÏÏÍÌÌÎÍÎÏÎÍÎÎÌÍÍÌÍÏÏÌ; // 0xD3
        public bool ÍÍÍÎÎÍÎÍÏÌÏÏÌÌÎÌÏÏÌÏÏÌÍ; // 0xD4
        public bool isLocal; // 0xD5
        public UnityEngine.Transform ÍÌÌÌÎÌÏÍÎÏÌÌÏÏÍÍÌÍÎÌÍÌÎ; // 0xD8
        public UnityEngine.Transform ÎÍÌÍÌÍÏÏÍÎÌÎÎÎÏÌÏÍÏÏÎÏÏ; // 0xE0
        public UnityEngine.Transform ÏÎÍÍÍÌÏÌÍÎÏÏÌÍÏÍÏÎÎÍÎÎÍ; // 0xE8
        public UnityEngine.Transform ÏÎÎÎÎÏÏÌÎÎÍÏÌÎÌÌÍÍÏÌÎÌÌ; // 0xF0
        public UnityEngine.Animator ÎÏÎÎÎÎÎÎÌÎÌÍÍÎÍÌÎÌÎÍÍÎÍ; // 0xF8
        public bool ÎÌÎÎÌÏÌÍÍÌÌÍÍÎÏÍÍÎÌÏÎÍÌ; // 0x100
        public 0x6B0155E8 ÏÎÎÏÍÎÏÏÏÎÏÌÎÏÍÎÍÌÌÏÎÏÍ; // 0x104
        public int ÎÎÌÌÎÌÌÍÍÏÎÍÎÍÎÎÏÎÎÏÏÍÌ;
        public int ÍÍÍÍÍÍÌÌÍÏÎÍÌÏÎÌÌÌÍÏÎÌÏ;
        public int ÏÎÍÍÌÌÌÎÌÌÍÎÎÏÎÌÏÍÏÎÎÏÏ; // 0x108

        // ── Methods ──
        public void set_ScaleMode(){} // RVA: 0x7FFAC451E020
        public void RaiseCancellation(){} // RVA: 0x7FFAC451E030
        public void IsInvoking(){} // RVA: 0x7FFAC451E4F0
        public void CancelInvoke(){} // RVA: 0x7FFAC451E5D0
        public void Invoke(){} // RVA: 0x7FFAC451EC60
        public void InvokeRepeating(){} // RVA: 0x7FFAC451FB10
        public void OnEnable(){} // RVA: 0x7FFAC451FBD0
        public void DoRange(){} // RVA: 0x7FFAC451FF80
        public void StartCoroutine(){} // RVA: 0x7FFAC2F21310
        public void Computevalue(){} // RVA: 0x7FFAC451FFC0
        public void Awake(){} // RVA: 0x7FFAC451FFF0
        public void Start(){} // RVA: 0x7FFAC2F21310
        public void OnDestroy(){} // RVA: 0x7FFAC4520140
        public void StopCoroutine(){} // RVA: 0x7FFAC45203D0
        public void OnApplicationQuit(){} // RVA: 0x7FFAC4520960
        public void StopAllCoroutines(){} // RVA: 0x7FFAC4520A70
        public void get_useGUILayout(){} // RVA: 0x7FFAC4520FC0
        public void set_useGUILayout(){} // RVA: 0x7FFAC45213F0
        public void print(){} // RVA: 0x7FFAC45222B0
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFAC4522350
        public void Internal_IsInvokingAll(){} // RVA: 0x7FFAC45225A0
        public void StartCoroutineManaged_51DC8F4F5828_51DC8F4F5828(){} // RVA: 0x7FFAC4523130 | overloaded x2
        public void OnCollisionEnter(){} // RVA: 0x7FFAC4522750
        public void OnCollisionStay(){} // RVA: 0x7FFAC45229E0
        public void IsObjectMonoBehaviour(){} // RVA: 0x7FFAC4523070
        public void StartCoroutineManaged2(){} // RVA: 0x7FFAC45232D0
        public void StopCoroutineManaged(){} // RVA: 0x7FFAC4523550
        public void StopCoroutineFromEnumeratorManaged(){} // RVA: 0x7FFAC45235C0
        public void GetScriptClassName(){} // RVA: 0x7FFAC451FB10
        public void LateUpdate(){} // RVA: 0x7FFAC4523740
        public void .ctor(){} // RVA: 0x7FFAC4524310
        public void Update(){} // RVA: 0x7FFAC45243B0
    }

    public class SerializableQuaternion : ValueType
    {
        public float x; // 0x10
        public float y; // 0x14
        public float z; // 0x18
        public float w; // 0x1C

        // ── Methods ──
        public void FromColorf(){} // RVA: 0x7FFAC450BA70
        public void InternalEquals_D45A011958AB_D45A011958AB(){} // RVA: 0x7FFAC450BA70 | overloaded x2
        public void DefaultEquals(){} // RVA: 0x7FFAC450BA70
        public void Equals(){} // RVA: 0x7FFAC450BA70
        public void InternalGetHashCode(){} // RVA: 0x7FFAC450BA70
        public void ToString(){} // RVA: 0x7FFAC4527180
        public void .ctor(){} // RVA: 0x7FFAC2F45570
        public void Initialize(){} // RVA: 0x7FFAC450BA70
        public void .ctor_588AE136764B(){} // RVA: 0x7FFAC450BA70
        public void HasValue(){} // RVA: 0x7FFAC450BA70
    }

    public class SerializableVector3 : ValueType
    {
        public float x; // 0x10
        public float y; // 0x14
        public float z; // 0x18

        // ── Methods ──
        public void FromVector3f(){} // RVA: 0x7FFAC45273D0
        public void InternalEquals(){} // RVA: 0x7FFAC45273D0
        public void DefaultEquals(){} // RVA: 0x7FFAC45273D0
        public void Equals(){} // RVA: 0x7FFAC45273D0
        public void InternalGetHashCode(){} // RVA: 0x7FFAC45273D0
        public void GetHashCode_D45A011958AB_D45A011958AB(){} // RVA: 0x7FFAC45273D0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC2F44D70
        public void Initialize(){} // RVA: 0x7FFAC45273D0
        public void ToString(){} // RVA: 0x7FFAC45273F0
        public void GetNetworkValueAtOffset44(){} // RVA: 0x7FFAC45273D0
        public void FromVector3f_3E9AE12326DF(){} // RVA: 0x7FFAC45273D0
    }

}