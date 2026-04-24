// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.RealisticEyeMovements.RealisticEyeMovements
// Classes: 8
// Methods: 214

namespace ThirdParty.RealisticEyeMovements.RealisticEyeMovements
{
    public class ControlData : Object
    {
        public object rightEye; // 0x338EE1A0
        public object maxEyeUpEyeballAngle; // 0x338EE1A0
        public object isEyeBoneDefaultSet; // 0x338EE1A0
        public object isEyeBallLookDownSet; // 0x338EE1A0
        public object rightBoneEyeRotationLimiter; // 0x338EE1A0
        public object eyelidControl; // 0x338EE1A0
        public object upperEyeLidLeft; // 0x338EE1A0
        public object lowerEyeLidRight; // 0x338EE1A0
        public object isEyelidBonesLookUpSet; // 0x338EE1A0
        public object upperRightLimiter; // 0x338EE1A0
        public object eyeWidenOrSquint; // 0x338EE1A0
        public object blendshapesForLookingDown; // 0x338EE1A0
        public object isEyelidBlendshapeClosedSet; // 0x338EE1A0
        public object f_5C7; // 0xB41CE740, was: ÏÍÏÍÏÏÏÏÏÏÍÏÌÏÏÌÏÍÎÏÍÌÌ

        // ── Original Methods ──
        public void Computesh(){} // RVA: 0x7ffaa9f21590
        public void Equals(){} // RVA: 0x7ffaa9f22260
        public void op_Implicit(){} // RVA: 0x7ffaa9f222b0
        public void IsNativeObjectAlive(){} // RVA: 0x7ffaa9f22a90
        public void get_name(){} // RVA: 0x7ffaa9f22b10
        public void set_name(){} // RVA: 0x7ffaa9f238a0
        public void UpdateBle(){} // RVA: 0x7ffaa9f23b80
        public void Instantiate(){} // RVA: 0x7ffaa9f23eb0
        public void ToString(){} // RVA: 0x7ffaa9f24410
        public void .ctor(){} // RVA: 0x7ffaa9f24960
        public void Initialize(){} // RVA: 0x7ffaa9f24e70
        public void ProcessEyeBoneData(){} // RVA: 0x7ffaa9f256f0
        public void Destroy(){} // RVA: 0x7ffaa9f25d60
        public void ProcessIndexedEyeControl(){} // RVA: 0x7ffaa9f26040
        public void DestroyImmediate(){} // RVA: 0x7ffaa9f26150
        public void FindObjectsOfType(){} // RVA: 0x7ffaa9f261c0
        public void UpdateBlendShapeWeights(){} // RVA: 0x7ffaa9f26830
        public void FindObjectsByType(){} // RVA: 0x7ffaa9f26b60
        public void UpdatelocalPositio(){} // RVA: 0x7ffaa9f27270
        // ── Binary Analysis Named ──
        public void DoFindRelativeTran(){} // RVA: 0x7ffaa9f205f0
        public void DoSetBlendShapeWeight(){} // RVA: 0x7ffaa9f22870
        public void GetCachedPtr(){} // RVA: 0x7ffaa9f22ad0
        public void GetHashCode(){} // RVA: 0x7ffaa9f24190
        public void SetBlendShapeWeight(){} // RVA: 0x7ffaa9f25a70
        // ── Obfuscated Methods ──
        public void m_152(){} // RVA: 0x7ffaa9f24740
        public void m_240(){} // RVA: 0x7ffaa9f25a30
        public void m_768(){} // RVA: 0x7ffaa9f26170
    }

    public class EyeAndHeadAnimator : MonoBehaviour
    {
        public object f_343; // 0x33391AE0, was: ÌÎÎÍÍÏÎÌÏÌÍÏÍÏÌÌÍÏÌÍÎÌÍ
        public object headSpeedModifier; // 0x33391AE0
        public object f_0F2; // 0x33391AE0, was: ÏÍÍÍÏÌÍÎÌÏÏÏÏÍÎÎÌÍÏÍÏÎÏ
        public object useMacroSaccades; // 0x33391AE0
        public object kMinNextBlinkTime; // 0x33391AE0
        public object f_198; // 0x33391AE0, was: <ÍÍÍÎÍÍÌÎÌÏÌÌÌÌÍÌÎÎÌÍÎÎÎ>k__Ba
        public object f_C13; // 0x33391AE0, was: ÎÏÌÏÌÏÍÎÏÍÎÏÌÍÎÏÏÍÎÌÎÏÏ
        public object f_3DB; // 0x33391AE0, was: ÍÍÍÎÏÌÍÏÎÎÌÍÌÏÌÏÌÍÌÍÏÏÌ
        public object f_C70; // 0x33391AE0, was: ÍÎÎÎÌÍÎÏÍÏÏÎÎÍÍÏÏÌÏÏÌÎÏ
        public object f_C84; // 0x33391AE0, was: ÍÏÏÍÍÍÍÌÍÍÎÌÍÌÎÎÏÌÍÌÎÍÏ
        public object f_D9B; // 0x33391AE0, was: ÍÌÍÏÍÌÌÌÎÏÌÌÎÎÎÌÎÌÎÎÏÏÎ
        public object crossEyeCorrection; // 0x33391AE0
        public object f_4E0; // 0x33391AE0, was: <ÎÏÏÍÎÏÍÏÎÏÍÏÍÏÏÎÎÎÎÏÍÌÏ>k__Ba
        public object f_432; // 0x33391AE0, was: ÍÏÎÏÎÎÌÏÎÌÌÎÎÍÌÎÏÌÏÌÍÌÍ
        public object f_D81; // 0x33391AE0, was: ÎÎÍÎÏÎÌÍÍÍÎÍÌÍÌÌÍÌÌÌÎÏÎ
        public object f_C5C; // 0x33391AE0, was: ÌÌÏÏÏÌÎÏÏÎÍÎÍÌÎÎÌÎÍÏÏÌÎ
        public object f_32E; // 0x33391AE0, was: ÍÏÏÍÏÌÎÍÍÍÎÎÎÎÍÎÎÍÏÏÎÌÎ
        public object f_A5C; // 0x33391AE0, was: ÎÏÎÎÏÎÌÍÌÏÎÏÌÍÎÌÌÏÍÎÌÏÏ
        public object f_4AE; // 0x33391AE0, was: ÏÏÎÌÎÌÍÍÏÎÏÏÏÌÎÏÍÌÎÏÏÍÏ
        public object f_7E2; // 0x33391AE0, was: ÏÍÍÍÎÍÎÏÍÌÎÏÎÎÏÏÏÏÌÌÌÌÍ
        public object f_F19; // 0x33391AE0, was: ÏÌÍÍÎÏÎÏÍÏÎÎÏÍÌÎÌÏÏÏÎÏÎ
        public object f_D82; // 0x33391AE0, was: ÏÎÍÍÏÌÏÎÎÎÌÏÌÍÎÎÍÎÎÍÎÎÍ
        public object f_5DE; // 0x33391AE0, was: ÍÎÍÍÌÍÌÏÏÎÏÌÌÏÍÎÍÎÏÌÍÍÌ
        public object f_0B2; // 0x33391AE0, was: ÎÌÏÌÌÎÎÍÍÌÌÎÍÍÌÏÌÍÏÏÎÌÎ
        public object f_D70; // 0x33391AE0, was: ÏÌÎÎÏÎÌÍÌÌÏÎÍÏÌÌÍÏÏÎÎÏÌ
        public object f_8FF; // 0x33391AE0, was: ÎÎÎÍÍÍÌÎÎÏÏÍÌÎÏÍÏÏÌÍÍÍÌ
        public object f_6A5; // 0x33391AE0, was: ÌÏÍÏÎÎÍÏÍÎÎÏÏÎÌÏÌÎÍÎÌÌÏ
        public object f_6B4; // 0x33391AE0, was: ÌÎÎÎÍÏÎÌÎÍÌÍÍÏÌÏÎÏÏÍÎÍÌ
        public object f_4CA; // 0x33391AE0, was: ÌÌÍÍÏÌÌÏÏÍÏÏÏÎÍÎÏÌÌÍÎÎÏ
        public object f_28D; // 0x33391AE0, was: ÏÏÌÏÍÌÌÏÌÏÍÎÍÎÏÌÍÎÌÏÌÍÍ
        public object f_305; // 0x33391AE0, was: ÎÍÎÌÍÍÏÍÌÌÏÎÌÌÎÎÏÏÌÎÎÏÍ
        public object f_C9B; // 0x33391AE0, was: ÍÌÏÎÌÍÌÍÌÍÌÌÍÍÍÌÎÍÏÌÏÏÍ
        public object f_591; // 0x33391AE0, was: ÌÏÍÎÍÎÏÎÍÌÎÍÌÎÍÌÎÍÌÌÌÎÎ
        public object f_6CA; // 0x33391AE0, was: ÏÎÌÏÏÎÏÎÎÌÎÌÏÏÏÎÍÍÎÎÏÎÍ
        public object f_966; // 0x33391AE0, was: ÍÎÏÎÏÌÎÎÌÌÍÍÍÏÏÏÏÌÍÎÌÌÎ
        public object f_E84; // 0x33391AE0, was: ÏÌÏÏÌÏÌÏÏÌÌÌÌÍÏÏÍÎÌÍÍÏÏ
        public object f_F77; // 0x33391AE0, was: <ÍÍÎÏÏÍÎÏÌÎÌÎÍÎÏÎÏÏÍÎÍÎÏ>k__Ba
        public object f_4FE; // 0x33391AE0, was: ÍÎÍÍÏÍÌÍÌÍÏÎÏÏÌÏÌÏÏÌÏÎÎ
        public object f_67D; // 0x33391AE0, was: ÏÍÍÍÏÏÏÏÌÏÎÌÎÏÌÏÍÎÏÌÌÏÏ
        public object f_FB8; // 0x33391AE0, was: ÍÍÌÍÎÍÍÏÌÎÏÌÍÍÌÎÎÎÍÍÏÏÎ
        public object LookingAroundIdly; // 0x33F9F450
        public object System.Collections.IEnumerator.get_Current; // 0xB41EDF50
        public object f_616; // 0xB41EDF50, was: ÍÌÎÍÍÌÍÌÌÍÌÍÏÏÎÏÍÍÍÎÍÎÏ

        // ── Original Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7ffaa9f2c320
        public void FixedUpdate(){} // RVA: 0x7ffaa9f32e50
        public void CancelInvoke(){} // RVA: 0x7ffaa9f2ca90
        public void InvokeRepeating(){} // RVA: 0x7ffaa8932310
        public void IsAnimatorStateFour(){} // RVA: 0x7ffaa9f2e3a0
        public void IsInvoking(){} // RVA: 0x7ffaa9f2e3b0
        public void StartCoroutine(){} // RVA: 0x7ffaa9f2e5d0
        public void Computeposition_Inj(){} // RVA: 0x7ffaa9f2e610
        public void get_EnginePower(){} // RVA: 0x7ffaa895b060
        public void OnApplicationQuit(){} // RVA: 0x7ffaa9f34300
        public void StopCoroutine(){} // RVA: 0x7ffaa9f2e800
        public void get_useGUILayout(){} // RVA: 0x7ffaa9f2f5d0
        public void LateUpdate(){} // RVA: 0x7ffaa9f2f6b0
        public void Internal_CancelInvokeAll(){} // RVA: 0x7ffaa9f2fd30
        public void Computetime(){} // RVA: 0x7ffaa9f30190
        public void OnBecameInvisible(){} // RVA: 0x7ffaa9f30210
        public void IsObjectMonoBehaviour(){} // RVA: 0x7ffaa9f303e0
        public void set_leftStick(){} // RVA: 0x7ffaa93d3cc0
        public void StopCoroutineManaged(){} // RVA: 0x7ffaa9f30770
        public void StopCoroutineFromEnumeratorManaged(){} // RVA: 0x7ffaa9f30820
        public void OnCancellationTokenCreated(){} // RVA: 0x7ffaa9f30cd0
        public void set_onFocusSelectAll(){} // RVA: 0x7ffaa9f30ce0
        public void InitializeAnimatorDependencies(){} // RVA: 0x7ffaa9f30cf0
        public void Computeup(){} // RVA: 0x7ffaa9f312f0
        public void set_bakingProgress(){} // RVA: 0x7ffaa895b050
        public void UpdateObjectPointer(){} // RVA: 0x7ffaa93d3cc0
        public void .ctor(){} // RVA: 0x7ffaa9f31cc0
        public void Initialize(){} // RVA: 0x7ffaa9f31e90
        public void Awake(){} // RVA: 0x7ffaa8932310
        public void Start(){} // RVA: 0x7ffaa9f32d00
        public void ProcessAndAnimateHeadState(){} // RVA: 0x7ffaa9f32df0
        public void FixedUpdate(){} // RVA: 0x7ffaa9f32e50
        public void OnCollisionExit(){} // RVA: 0x7ffaa9f34760
        public void OnDisable(){} // RVA: 0x7ffaa9f332b0
        public void set_EnginePower(){} // RVA: 0x7ffaa895b070
        public void Computeenabled(){} // RVA: 0x7ffaa9f33310
        public void OnBecameVisible(){} // RVA: 0x7ffaa9f333f0
        public void OnDisable_impl(){} // RVA: 0x7ffaa9f33a30
        public void get_onTouchScreenKeyboardStatusChanged(){} // RVA: 0x7ffaa93d15b0
        public void get_CurrentSteerAngle(){} // RVA: 0x7ffaa8953500
        public void .cctor(){} // RVA: 0x7ffaa9f33fa0
        public void OnDestroy(){} // RVA: 0x7ffaa9f34130
        public void OnTriggerExit(){} // RVA: 0x7ffaa9f332a0
        public void OnApplicationQuit(){} // RVA: 0x7ffaa9f34300
        public void OnEnable(){} // RVA: 0x7ffaa8932310
        public void OnCollisionExit(){} // RVA: 0x7ffaa9f34760
        public void OnDrawGizmos(){} // RVA: 0x7ffaa9f34c50
        public void Update(){} // RVA: 0x7ffaa9f36300
        public void OnApplicationPause(){} // RVA: 0x7ffaa9f364f0
        public void Computebytes(){} // RVA: 0x7ffaa9f372e0
        public void UpdateTransform(){} // RVA: 0x7ffaa9f37530
        public void OnCollisionEnter(){} // RVA: 0x7ffaa9f37aa0
        public void OnCollisionStay(){} // RVA: 0x7ffaa9f37f20
        public void ComputedeltaTime(){} // RVA: 0x7ffaa9f38090
        public void OnTriggerStay(){} // RVA: 0x7ffaa9f38260
        public void get_onFocusSelectAll(){} // RVA: 0x7ffaa9887ce0
        public void OnAnimatorIK(){} // RVA: 0x7ffaa9f38350
        public void ComputeEyeHeadAnimationPosition(){} // RVA: 0x7ffaa9f38600
        public void VerifyAndProcessAnimator(){} // RVA: 0x7ffaa9f38880
        public void CalculateAndLimitRotationAngle(){} // RVA: 0x7ffaa9f38b70
        public void ComputeParent(){} // RVA: 0x7ffaa9f38c50
        public void NormalizeAndCalculateHeadRotation(){} // RVA: 0x7ffaa9f39a70
        // ── Binary Analysis Named ──
        public void DoDestroyImmediate_A15(){} // RVA: 0x7ffaa9f2c4d0
        public void DoInternal_FromEu(){} // RVA: 0x7ffaa9f2cab0
        public void DoLookRotation_Injected(){} // RVA: 0x7ffaa9f30630
        public void GetCurrentHealth(){} // RVA: 0x7ffaa895b040
        public void DoInverse_Injecte(){} // RVA: 0x7ffaa9f2e820
        public void DoFindRelativeTran(){} // RVA: 0x7ffaa9f2f970
        public void DoInverseTransform(){} // RVA: 0x7ffaa9f2fe90
        public void GetArrowVelocity(){} // RVA: 0x7ffaa8b6ec30
        public void DoLookRotation_Injected(){} // RVA: 0x7ffaa9f30630
        public void GetScriptClassName(){} // RVA: 0x7ffaa9f30a20
        public void DoDeltaAngle(){} // RVA: 0x7ffaa9f32110
        public void SetEyeHeadAnimProperty(){} // RVA: 0x7ffaa8e5eda0
        public void SetAnimatorHeadLookState(){} // RVA: 0x7ffaa9f332a0
        public void Doop_Multiply(){} // RVA: 0x7ffaa9f33580
        public void DoTransformPoint_I(){} // RVA: 0x7ffaa9f33b00
        public void Getposition(){} // RVA: 0x7ffaa9f344f0
        public void Gettime(){} // RVA: 0x7ffaa9f34600
        public void DoRender_7AB(){} // RVA: 0x7ffaa8b6a4c0
        public void DoRange(){} // RVA: 0x7ffaa9f34900
        public void GetAnimatorHeadLookState(){} // RVA: 0x7ffaa9f362f0
        public void SetHeadLookTargetAndState(){} // RVA: 0x7ffaa9f37a80
        public void GetEyeHeadAnimationState(){} // RVA: 0x7ffaa9f38010
        public void GetTransformPosition(){} // RVA: 0x7ffaa9f2e610
        // ── Obfuscated Methods ──
        public void m_CF7(){} // RVA: 0x7ffaa9f38970
        public void m_CF7(){} // RVA: 0x7ffaa9f38970
        public void m_73C(){} // RVA: 0x7ffaa8932310
        public void m_232(){} // RVA: 0x7ffaa8e5eda0
    }

    public class EyeAndHeadAnimatorForExport : Object
    {
        public object headWeight; // 0x33F9E060
        public object kDrawSightlinesInEditor; // 0x33F9E060
        public object kMaxNextBlinkTime; // 0x33F9E060
        public object maxEyeHorizAngleTowardsNose; // 0x33F9E060
        public object limitHeadAngle; // 0x33F9E060
        public object None; // 0x33F9E1E0
        public object Transform; // 0x33F9E1E0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class EyeRotationLimiter : Object
    {
        public object lookUpQ; // 0x33F9C950
        public object maxDownAngle; // 0x33F9C950

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void Initialize(){} // RVA: 0x7ffaa9f1c4c0
        public void ComputelocalRotatio(){} // RVA: 0x7ffaa9f1c500
        public void AccesslocalRotation_Injected(){} // RVA: 0x7ffaa9f1c590
        public void IsNativeObjectAlive(){} // RVA: 0x7ffaa9f1c620
        public void get_name(){} // RVA: 0x7ffaa9f1c840
        public void set_name(){} // RVA: 0x7ffaa9f1c8b0
        public void Instantiate(){} // RVA: 0x7ffaa9f1c970
        public void UpdatelocalRotatio(){} // RVA: 0x7ffaa9f1ca30
        public void Equals(){} // RVA: 0x7ffaa9f1caa0
        public void ToString(){} // RVA: 0x7ffaa9f1cb80
        public void ProcessEyeRotationLimit(){} // RVA: 0x7ffaa9f1d220
        public void Destroy(){} // RVA: 0x7ffaa9f1cb10
        // ── Binary Analysis Named ──
        public void GetInstanceID(){} // RVA: 0x7ffaa9f1c460
        public void GetCachedPtr(){} // RVA: 0x7ffaa9f1c7d0
        public void GetHashCode(){} // RVA: 0x7ffaa9f1cb10
        public void DoFindRelativeTran(){} // RVA: 0x7ffaa9f1cbc0
        public void DoInternal_FromEu(){} // RVA: 0x7ffaa9f1cdb0
        public void GetlocalRotation(){} // RVA: 0x7ffaa9f1d290
        public void SetlocalRotation(){} // RVA: 0x7ffaa9f1d320
        public void DoInternal_FromEulerRad_Injected(){} // RVA: 0x7ffaa9f1d390
        public void DoInverse_Injecte(){} // RVA: 0x7ffaa9f1d800
    }

    public class EyelidRotationLimiter : Object
    {
        public object closedQ; // 0x33F9CC50
        public object eyeMaxDownAngle; // 0x33F9CC50
        public object closedPos; // 0x33F9CC50
        public object isLookUpSet; // 0x33F9CC50
        public object isClosedPosSet; // 0x33F9CC50
        public object 8؏f; // 0x66F28077

        // ── Original Methods ──
        public void ComputelocalPositio(){} // RVA: 0x7ffaa9f1ddb0
        public void Equals(){} // RVA: 0x7ffaa9f1dec0
        public void op_Implicit(){} // RVA: 0x7ffaa9f1e470
        public void CompareBaseObjects(){} // RVA: 0x7ffaa9f1e4e0
        public void IsNativeObjectAlive(){} // RVA: 0x7ffaa9f1e7a0
        public void AccesslocalPosition_Injected(){} // RVA: 0x7ffaa9f1ea60
        public void get_name(){} // RVA: 0x7ffaa9f1eb70
        public void UpdatelocalPositio(){} // RVA: 0x7ffaa9f1ec80
        public void AccesslocalRotation_Injected(){} // RVA: 0x7ffaa9f1f2c0
        public void Instantiate(){} // RVA: 0x7ffaa9f1f3d0
        public void ToString(){} // RVA: 0x7ffaa9f1fb00
        public void ComputeEyelidRotation(){} // RVA: 0x7ffaa9f20330
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void DoFindRelativeTran(){} // RVA: 0x7ffaa9f1e180
        public void DoInternal_FromEu(){} // RVA: 0x7ffaa9f1eda0
        public void GetHashCode(){} // RVA: 0x7ffaa9f1f4e0
        public void DoInternal_FromEulerRad_Injected(){} // RVA: 0x7ffaa9f1f5e0
        public void SetlocalRotation(){} // RVA: 0x7ffaa9f1fc20
        public void GetlocalRotation(){} // RVA: 0x7ffaa9f1fd30
        public void DoSlerp_Injected(){} // RVA: 0x7ffaa9f1fe40
    }

    public class LookTargetController : MonoBehaviour
    {
        public object stareBackFactor; // 0x3374D100
        public object minLookTime; // 0x3374D100
        public object keepTargetEvenWhenLost; // 0x3374D100
        public object f_021; // 0x3374D100, was: ÍÏÍÌÎÍÎÏÎÍÏÎÌÌÍÌÎÏÎÏÍÍÏ
        public object f_6DE; // 0x3374D100, was: ÌÌÎÌÏÎÌÎÌÎÎÎÌÌÏÌÎÎÏÏÌÏÏ
        public object f_5F8; // 0x3374D100, was: ÏÌÎÎÌÍÌÏÌÏÍÌÎÍÍÎÎÏÏÎÎÎÍ
        public object f_84A; // 0x3374D100, was: ÏÍÎÏÎÌÏÍÏÎÍÏÎÏÏÎÌÏÌÏÌÏÌ
        public object f_354; // 0x3374D100, was: ÎÌÎÎÌÎÏÍÌÏÏÏÌÎÎÏÌÍÌÌÌÏÏ
        public object f_239; // 0x3374D100, was: ÍÌÎÌÌÎÏÌÍÌÏÏÏÌÍÍÎÌÏÎÏÏÏ
        public object f_F92; // 0x3374D100, was: ÏÍÌÎÍÌÏÍÍÍÌÍÏÏÌÌÌÏÎÎÍÍÎ
        public object f_090; // 0x3374D100, was: ÎÍÌÍÎÎÏÌÎÍÎÍÍÎÍÏÎÍÎÎÏÌÏ
        public object isLocal; // 0x3374D100
        public object f_E4A; // 0x3374D100, was: ÏÍÌÎÎÌÏÍÌÍÎÌÌÎÍÌÎÍÍÏÍÍÌ
        public object f_F62; // 0x3374D100, was: ÎÌÌÌÎÎÏÏÎÍÌÍÏÎÏÎÏÎÏÏÏÍÎ
        public object f_933; // 0x3374D100, was: ÌÌÏÍÌÏÌÌÎÌÌÌÎÎÎÍÏÍÎÍÎÍÏ

        // ── Original Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7ffaa9f3bf10
        public void Update(){} // RVA: 0x7ffaa9f3bfb0
        public void IsInvoking(){} // RVA: 0x7ffaa9f3c280
        public void set_acceptedPrivacyVersion(){} // RVA: 0x7ffaa9f3c2c0
        public void StartCoroutine(){} // RVA: 0x7ffaa9f3d830
        public void InvokeRepeating(){} // RVA: 0x7ffaa9f3c470
        public void Computeposition_Inj(){} // RVA: 0x7ffaa9f3c4b0
        public void UpdatelocalRotatio(){} // RVA: 0x7ffaa9f3d220
        public void Computevalue(){} // RVA: 0x7ffaa9f3d770
        public void StartCoroutine(){} // RVA: 0x7ffaa9f3d830
        public void .ctor(){} // RVA: 0x7ffaa9f3d9b0
        public void LateUpdate(){} // RVA: 0x7ffaa9f3da50
        public void StopCoroutine(){} // RVA: 0x7ffaa8932310
        public void OnTriggerExit(){} // RVA: 0x7ffaa9f3e560
        public void get_useGUILayout(){} // RVA: 0x7ffaa9f3eba0
        public void AccesslocalRotation_Injected(){} // RVA: 0x7ffaa9f3ec40
        public void Internal_CancelInvokeAll(){} // RVA: 0x7ffaa9f3f5c0
        public void Internal_IsInvokingAll(){} // RVA: 0x7ffaa9f3f810
        public void Start(){} // RVA: 0x7ffaa8932310
        public void CancelInvoke(){} // RVA: 0x7ffaa9f3fa90
        public void Computetransform(){} // RVA: 0x7ffaa9f40dd0
        public void ComputegameObject(){} // RVA: 0x7ffaa9f41460
        public void StartCoroutineManaged2(){} // RVA: 0x7ffaa9f41810
        public void StopCoroutineManaged(){} // RVA: 0x7ffaa9f418f0
        public void StopCoroutineFromEnumeratorManaged(){} // RVA: 0x7ffaa9f41960
        public void Awake(){} // RVA: 0x7ffaa9f41ae0
        public void OnCancellationTokenCreated(){} // RVA: 0x7ffaa9f41c30
        public void OnCollisionEnter(){} // RVA: 0x7ffaa9f41cf0
        public void OnDisable(){} // RVA: 0x7ffaa9f42280
        public void OnDestroy(){} // RVA: 0x7ffaa9f42400
        public void OnTriggerEnter(){} // RVA: 0x7ffaa9f42690
        // ── Binary Analysis Named ──
        public void DoRange(){} // RVA: 0x7ffaa9f3cf90
        public void DoRandomRangeInt(){} // RVA: 0x7ffaa9f3e6e0
        public void DoInternal_FromEu(){} // RVA: 0x7ffaa9f3f190
        public void DoSlerp_Injected(){} // RVA: 0x7ffaa9f3ff10
    }

    public class SerializableQuaternion : ValueType
    {
        public object z; // 0x335004B0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8956570
        public void FromColorf(){} // RVA: 0x7ffaa9f2b290
        public void DefaultEquals(){} // RVA: 0x7ffaa9f2b290
        public void Equals(){} // RVA: 0x7ffaa9f2b290
        public void InternalGetHashCode(){} // RVA: 0x7ffaa9f2b290
        public void ToString(){} // RVA: 0x7ffaa9f44f20
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaa9f2b290
        public void GetHashCodeOfPtr(){} // RVA: 0x7ffaa9f2b290
        public void GetHashCodeOfPtr(){} // RVA: 0x7ffaa9f2b290
    }

    public class SerializableVector3 : ValueType
    {
        public object z; // 0x333D1310

        // ── Original Methods ──
        public void FromVector3f(){} // RVA: 0x7ffaa9f45170
        public void InternalEquals(){} // RVA: 0x7ffaa9f45170
        public void DefaultEquals(){} // RVA: 0x7ffaa9f45170
        public void Initialize(){} // RVA: 0x7ffaa9f45170
        public void ToString(){} // RVA: 0x7ffaa9f45190
        public void Equals(){} // RVA: 0x7ffaa9f45170
        public void .ctor(){} // RVA: 0x7ffaa8955d70
        public void Initialize(){} // RVA: 0x7ffaa9f45170
        public void AssignVector3(){} // RVA: 0x7ffaa9f45170
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaa9f45170
        public void GetHashCodeOfPtr(){} // RVA: 0x7ffaa9f45170
    }

}