// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.RealisticEyeMovements.RealisticEyeMovements
// Classes: 8
// Methods: 213

namespace ThirdParty.RealisticEyeMovements.RealisticEyeMovements
{
    public class ControlData
    {
        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x1A46E50
        public void Equals(){} // RVA: 0x1A46E70
        public void GetHashCode(){} // RVA: 0x1A47B40
        public void .ctor_8342C7B12B9F(){} // RVA: 0x1A48570
        public void Initialize(){} // RVA: 0x1A487F0
        public void IsNativeObjectAlive(){} // RVA: 0x1A48A10
        public void GetCachedPtr(){} // RVA: 0x1A499B0
        public void get_name(){} // RVA: 0x1A499F0
        public void set_name(){} // RVA: 0x1A49A20
        public void Instantiate(){} // RVA: 0x1A49B30
        public void ToString(){} // RVA: 0x1A4AA80
        public void InitializeControlData(){} // RVA: 0x1A4ACA0
        public void InitializeControlDataDestroy(){} // RVA: 0x1A4AFD0
        public void UpdateConditionalField(){} // RVA: 0x1A4B6E0
        public void .ctor(){} // RVA: 0x1A4BA10
        public void InitializeStaticContext(){} // RVA: 0x1A4C4E0
        public void GetInitializedValue(){} // RVA: 0x1A4C520
        public void InitializeManagerState(){} // RVA: 0x1A4C570
        public void Destroy(){} // RVA: 0x1A4C850
        public void ProcessIndexedEyeControl(){} // RVA: 0x1A4CBC0
        public void DestroyImmediate(){} // RVA: 0x1A4CEF0
        public void SetIndexedBytesConditional(){} // RVA: 0x1A4D170
        public void FindObjectsOfType(){} // RVA: 0x1A4D9F0
        public void GetIndexedBooleanConditional(){} // RVA: 0x1A4DCD0
        public void FindObjectsByType(){} // RVA: 0x1A4DFB0
        public void SetIndexedByteConditional(){} // RVA: 0x1A4E260
        public void DontDestroyOnLoad(){} // RVA: 0x1A4E590
        // ── Unresolved (hash) ──
        public void m_1B3(){} // RVA: 0x1A4BF20
        public void m_B98(){} // RVA: 0x1A4E8D0
    }

    public class EyeAndHeadAnimator
    {
        public float ÌÎÏÏÌÏÏÌÎÎÌÎÌÏÏÍÍÎÌÎÎÏÎ;
        public float ÌÍÌÏÏÍÍÍÎÎÎÎÍÌÍÍÌÎÌÍÎÌÎ;
        public float ÍÌÌÎÏÎÎÎÎÌÎÍÍÏÏÌÎÌÎÍÏÍÌ;
        public float ÍÎÍÏÏÌÏÌÎÏÍÏÍÎÏÎÎÌÏÎÏÏÌ;
        public System.Action ÏÌÍÍÌÍÎÏÎÎÍÎÏÌÌÏÏÍÍÌÏÎÍ; // 0x20
        public float headSpeedModifier; // 0x28
        public float headWeight; // 0x2C
        public UnityEngine.Transform headBoneNonMecanimXform; // 0x30

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x1A53D30
        public void RaiseCancellation(){} // RVA: 0x1A54170
        public void set_EnginePower(){} // RVA: 0x59F940
        public void CancelInvoke(){} // RVA: 0x1A545F0
        public void OnDestroy_0B1E6BD2A72F(){} // RVA: 0x1A54600
        public void InvokeRepeating(){} // RVA: 0x1A54850
        public void OnApplicationQuit(){} // RVA: 0x306040
        public void IsInvoking(){} // RVA: 0x2FE500
        public void StartCoroutine(){} // RVA: 0x1A54920
        public void get_CurrentSteerAngle(){} // RVA: 0x1A54C70
        public void Update_000073742F2B(){} // RVA: 0x1A54E00
        public void StartCoroutine_Auto(){} // RVA: 0x1A54E20
        public void StopCoroutine(){} // RVA: 0x1A56710
        public void OnTriggerStay(){} // RVA: 0x8DD760
        public void OnTriggerExit(){} // RVA: 0x1A57530
        public void StopAllCoroutines(){} // RVA: 0x1A57550
        public void get_useGUILayout_CA51401C93C9(){} // RVA: 0x1A604D0 | overloaded x2
        public void set_onFocusSelectAll(){} // RVA: 0x1A57760
        public void .cctor_21A5D1943806(){} // RVA: 0x1A57980
        public void Internal_CancelInvokeAll(){} // RVA: 0xDB4D60
        public void get_onFocusSelectAll(){} // RVA: 0x1A57A70
        public void InvokeDelayed_8CF1835FCF42(){} // RVA: 0x1A593C0 | overloaded x2
        public void OnDestroy(){} // RVA: 0x1A57BD0
        public void InitializeEyeTracking(){} // RVA: 0x1A57DA0
        public void OnCollisionExit(){} // RVA: 0x1A583A0
        public void OnCollisionStay(){} // RVA: 0x1A58420
        public void OnDisable(){} // RVA: 0x1A58970
        public void StopCoroutineManaged(){} // RVA: 0x1A589D0
        public void Awake_E38B67940737(){} // RVA: 0x1A58C50
        public void GetScriptClassName(){} // RVA: 0x1A58D30
        public void OnCancellationTokenCreated(){} // RVA: 0x1A58E00
        public void InitializeAnimatorDependencies(){} // RVA: 0x1A59510
        public void Computeup(){} // RVA: 0x1A59610
        public void Awake(){} // RVA: 0x2DD310
        public void UpdateEyeTracking(){} // RVA: 0x1A59690
        public void OnApplicationPause(){} // RVA: 0x1351B10
        public void GetCurrentHealth(){} // RVA: 0x1A596A0
        public void set_bakingProgress(){} // RVA: 0x1A59780
        public void GetArrowVelocity(){} // RVA: 0xD85A20
        public void OnCollisionEnter(){} // RVA: 0x1A59A70
        public void OnCollisionStay_2758D9F3A4DC(){} // RVA: 0x1A59F20
        public void OnCollisionExit_C7013EB1F2E1(){} // RVA: 0x1A5A0F0
        public void get_onTouchScreenKeyboardStatusChanged_7BFFCC62A555(){} // RVA: 0x1A5D230 | overloaded x2
        public void OnAnimatorIK_4A43B30FD249(){} // RVA: 0x1A5A460
        public void OnAnimatorIK(){} // RVA: 0x1A5A6E0
        public void SetEyeHeadAnimProperty(){} // RVA: 0x306070
        public void UpdateHeadTracking_9255033C88AA(){} // RVA: 0x1A62230 | overloaded x2
        public void OnDrawGizmos_B03CC956AB45(){} // RVA: 0x1A5AB80
        public void OnDisable_840210F06363(){} // RVA: 0x1A5B010
        public void .cctor(){} // RVA: 0x1A5B170
        public void Doop_Multiply(){} // RVA: 0x1A5B300
        public void OnDisable_impl(){} // RVA: 0x1A5B360
        public void OnBecameVisible(){} // RVA: 0x1A5B4C0
        public void OnBecameInvisible_F9730E88C3A1(){} // RVA: 0x1A60250 | overloaded x2
        public void OnDisableImpl(){} // RVA: 0x306060
        public void DoDestroyImmediate_A15(){} // RVA: 0x59D580
        public void CancelInvoke_9E29C2AE1F63(){} // RVA: 0x1A5C480
        public void GetHeadLookTargetPosition(){} // RVA: 0x1A545F0
        public void Getposition(){} // RVA: 0x1A5D4B0
        public void set_touchpadClicked(){} // RVA: 0x1A5E0A0
        public void set_virtualGreenScreenDepthTolerance(){} // RVA: 0x1A5E200
        public void DoRender_7AB(){} // RVA: 0x1A5E210
        public void RenderEyeHeadDebug(){} // RVA: 0x1A59510
        public void DoRange(){} // RVA: 0x1A5E460
        public void GetEyeHeadAnimationState(){} // RVA: 0x1A5E550
        public void LateUpdate(){} // RVA: 0x1A5E630
        public void LateUpdate_E091010CD649(){} // RVA: 0x1A5E8F0
        public void OnEnable_37B6F3AF7C68(){} // RVA: 0x1A5EBA0
        public void Computebytes(){} // RVA: 0x1A5EBE0
        public void SetHeadLookTargetAndState(){} // RVA: 0x2DD310
        public void UpdateHeadLookTargetState(){} // RVA: 0x1A603E0
        public void OnEnable(){} // RVA: 0x2DD310
        public void ComputedeltaTime(){} // RVA: 0x1A606D0
        public void CleanupEyeTracking(){} // RVA: 0x1A606F0
        public void CalculateLookRotationLimit(){} // RVA: 0x1A607E0
        public void GetEyeHeadAnimationState_E26D6F92CEE8(){} // RVA: 0x1A60AE0
        public void OnDrawGizmos(){} // RVA: 0x1A60B90
        public void get_EnginePower(){} // RVA: 0x306050
        public void Initialize(){} // RVA: 0x1A62320
        public void .ctor(){} // RVA: 0x1A62520
        public void ComputeParent(){} // RVA: 0x1A62800
        public void Update(){} // RVA: 0x1A62FD0
        // ── Unresolved (hash) ──
        public void m_D94(){} // RVA: 0x1A626F0
    }

    public class EyeAndHeadAnimatorForExport
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class EyeRotationLimiter
    {
        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x1A43200
        public void Equals(){} // RVA: 0x1A43270
        public void GetHashCode(){} // RVA: 0x1A432B0
        public void op_Implicit(){} // RVA: 0x1A43460
        public void CompareBaseObjects(){} // RVA: 0x1A434C0
        public void IsNativeObjectAlive(){} // RVA: 0x1A436B0
        public void GetCachedPtr(){} // RVA: 0x1A43720
        public void get_name(){} // RVA: 0x1A438D0
        public void set_name(){} // RVA: 0x1A43910
        public void Instantiate(){} // RVA: 0x1A439A0
        public void .ctor_2BB8E712955F(){} // RVA: 0x1A43A10
        public void Initialize(){} // RVA: 0x1A43AD0
        public void ToString(){} // RVA: 0x1A43910
        public void NodeTreeFromSortedDictionary(){} // RVA: 0x1A43B40
        public void HandleEyeRotationLimiter(){} // RVA: 0x1A43CF0
        public void .ctor(){} // RVA: 0x2DD310
        public void GetAttribute(){} // RVA: 0x1A442A0
        public void GetIntegerFromDelegate(){} // RVA: 0x1A44490
        public void FailFast(){} // RVA: 0x1A44520
        public void Destroy(){} // RVA: 0x1A439A0
        public void CheckEyeRotationLimiter(){} // RVA: 0x1A44990
        public void NodeTreeFromSortedDictionary_ADC63101A23B(){} // RVA: 0x1A44B40
    }

    public class EyelidRotationLimiter
    {
        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x1A44BB0
        public void Equals(){} // RVA: 0x1A44E70
        public void GetHashCode(){} // RVA: 0x1A45130
        public void op_Implicit(){} // RVA: 0x1A45650
        public void CompareBaseObjects(){} // RVA: 0x1A456C0
        public void IsNativeObjectAlive(){} // RVA: 0x1A457C0
        public void GetCachedPtr(){} // RVA: 0x1A45AB0
        public void get_name(){} // RVA: 0x1A45BC0
        public void set_name(){} // RVA: 0x1A45CD0
        public void Instantiate(){} // RVA: 0x1A45DF0
        public void .ctor(){} // RVA: 0x2DD310
        public void Initialize(){} // RVA: 0x1A45F00
        public void InitializeNameEyelidRotationLimiter(){} // RVA: 0x1A46010
        public void NodeTreeFromSortedDictionary(){} // RVA: 0x1A46110
        public void InitializeEyelidRotationLimiter(){} // RVA: 0x1A46230
        public void .ctor_6580CF699562(){} // RVA: 0x1A46720
        public void Initialize_8FBF0E98DD2F(){} // RVA: 0x1A46830
        public void GetIntegerFromDelegate(){} // RVA: 0x1A46D50
    }

    public class LookTargetController
    {
        // ── Methods ──
        public void set_ScaleMode(){} // RVA: 0x1A654C0
        public void RaiseCancellation(){} // RVA: 0x1A65640
        public void IsInvoking(){} // RVA: 0x1A66500
        public void CancelInvoke(){} // RVA: 0x1A66510
        public void Invoke_B1D7634EF0A0(){} // RVA: 0x1A67400 | overloaded x2
        public void InvokeRepeating(){} // RVA: 0x1A66C00
        public void OnEnable(){} // RVA: 0x1A66FB0
        public void DoRange(){} // RVA: 0x1A67070
        public void StartCoroutine(){} // RVA: 0x1A67300
        public void Computevalue(){} // RVA: 0x1A67340
        public void Start_65ED8570D426(){} // RVA: 0x1A67580
        public void Update(){} // RVA: 0x1A67810
        public void StopCoroutine(){} // RVA: 0x2DD310
        public void OnApplicationQuit(){} // RVA: 0x1A67300
        public void StopAllCoroutines(){} // RVA: 0x1A67930
        public void get_useGUILayout(){} // RVA: 0x1A67AB0
        public void set_useGUILayout(){} // RVA: 0x1A67B20
        public void Awake(){} // RVA: 0x1A67F50
        public void Internal_CancelInvokeAll(){} // RVA: 0x1A680A0
        public void Internal_IsInvokingAll(){} // RVA: 0x1A68140
        public void StartCoroutineManaged(){} // RVA: 0x1A68270
        public void OnCollisionEnter(){} // RVA: 0x1A682B0
        public void Start(){} // RVA: 0x2DD310
        public void IsObjectMonoBehaviour(){} // RVA: 0x1A68770
        public void .ctor(){} // RVA: 0x1A68D10
        public void LateUpdate(){} // RVA: 0x1A68DB0
        public void StopCoroutineManaged(){} // RVA: 0x1A69980
        public void StopCoroutineFromEnumeratorManaged(){} // RVA: 0x1A6A010
        public void GetScriptClassName(){} // RVA: 0x1A6A490
        public void LateUpdate_F3384E2A925F(){} // RVA: 0x1A6A6E0
        public void OnDestroy(){} // RVA: 0x1A6A960
        public void Update_C5C97746377B(){} // RVA: 0x1A6ABF0
        public void GetLookTargetType(){} // RVA: 0x1A6AC30
        // ── Unresolved (hash) ──
        public void m_F91(){} // RVA: 0x1A6B1C0
    }

    public class SerializableQuaternion
    {
        // ── Methods ──
        public void FromColorf(){} // RVA: 0x1A53750
        public void InternalEquals(){} // RVA: 0x1A53750
        public void DefaultEquals(){} // RVA: 0x1A53750
        public void Equals_B3D4B1913246(){} // RVA: 0x1A53750 | overloaded x2
        public void InternalGetHashCode(){} // RVA: 0x1A53750
        public void ToString(){} // RVA: 0x1A6E010
        public void Initialize(){} // RVA: 0x1A53750
        public void GetHashCode(){} // RVA: 0x1A53750
        public void .ctor(){} // RVA: 0x301570
    }

    public class SerializableVector3
    {
        // ── Methods ──
        public void FromVector3f_B3D4B1913246(){} // RVA: 0x1A6E260 | overloaded x2
        public void InternalEquals(){} // RVA: 0x1A6E260
        public void DefaultEquals(){} // RVA: 0x1A6E260
        public void Equals(){} // RVA: 0x1A6E260
        public void InternalGetHashCode(){} // RVA: 0x1A6E260
        public void GetHashCode(){} // RVA: 0x1A6E260
        public void ToString(){} // RVA: 0x1A6E280
        public void ToString_C9BF71715768(){} // RVA: 0x1A6E260
        public void .ctor(){} // RVA: 0x300D70
    }

}