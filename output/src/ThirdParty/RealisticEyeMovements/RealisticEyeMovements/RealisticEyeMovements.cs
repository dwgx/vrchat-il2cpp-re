// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.RealisticEyeMovements.RealisticEyeMovements
// Classes: 8
// Methods: 209

namespace ThirdParty.RealisticEyeMovements.RealisticEyeMovements
{
    public class ControlData : Object
    {
        public object eyeControl;
        public object leftEye;
        public object rightEye;
        public object maxEyeUpBoneAngle;
        public object maxEyeDownBoneAngle;
        public object maxEyeUpEyeballAngle;
        public object maxEyeDownEyeballAngle;
        public object isEyeBallDefaultSet;
        public object isEyeBoneDefaultSet;
        public object isEyeBallLookUpSet;
        public object isEyeBoneLookUpSet;
        public object isEyeBallLookDownSet;
        public object isEyeBoneLookDownSet;
        public object leftBoneEyeRotationLimiter;
        public object rightBoneEyeRotationLimiter;
        public object leftEyeballEyeRotationLimiter;
        public object rightEyeballEyeRotationLimiter;
        public object eyelidControl;
        public object eyelidBoneMode;
        public object eyelidsFollowEyesVertically;
        public object upperEyeLidLeft;
        public object upperEyeLidRight;
        public object lowerEyeLidLeft;
        public object lowerEyeLidRight;
        public object isEyelidBonesDefaultSet;
        public object isEyelidBonesClosedSet;
        public object isEyelidBonesLookUpSet;
        public object isEyelidBonesLookDownSet;
        public object upperLeftLimiter;
        public object upperRightLimiter;
        public object lowerLeftLimiter;
        public object lowerRightLimiter;
        public object eyeWidenOrSquint;
        public object blendshapesForBlinking;
        public object blendshapesForLookingUp;
        public object blendshapesForLookingDown;
        public object blendshapesConfigs;
        public object isEyelidBlendshapeDefaultSet;
        public object isEyelidBlendshapeClosedSet;
        public object isEyelidBlendshapeLookUpSet;
        public object isEyelidBlendshapeLookDownSet;

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x230B910
        public void Equals(){} // RVA: 0x230C890
        public void GetHashCode(){} // RVA: 0x230D760
        public void op_Implicit(){} // RVA: 0x230DA50
        public void CompareBaseObjects(){} // RVA: 0x230DD10
        public void IsNativeObjectAlive(){} // RVA: 0x230E2C0
        public void GetCachedPtr(){} // RVA: 0x230E650
        public void get_name(){} // RVA: 0x230F280
        public void set_name(){} // RVA: 0x230FAF0
        public void Instantiate(){} // RVA: 0x230FD10
        public void Destroy(){} // RVA: 0x230FD60
        public void DestroyImmediate(){} // RVA: 0x230FDA0
        public void FindObjectsOfType(){} // RVA: 0x230FFD0
        public void FindObjectsByType(){} // RVA: 0x2310330
        public void DontDestroyOnLoad(){} // RVA: 0x2310900
        public void get_hideFlags(){} // RVA: 0x2310920
        public void set_hideFlags(){} // RVA: 0x2311030
        public void FindObjectOfType(){} // RVA: 0x23114D0
        public void FindFirstObjectByType(){} // RVA: 0x2311860
        public void .ctor(){} // RVA: 0x23118A0
        public void Initialize(){} // RVA: 0x2311DB0
        public void op_Equality(){} // RVA: 0x23120A0
        public void op_Inequality(){} // RVA: 0x23120E0
        public void GetOffsetOfInstanceIDInCPlusPlusObject(){} // RVA: 0x23122F0
        public void Internal_CloneSingle(){} // RVA: 0x2312680
        public void FindObjectsOfType_24A646E86A6E(){} // RVA: 0x2313380
        public void Internal_InstantiateSingle(){} // RVA: 0x23134A0
    }

    public class EyeAndHeadAnimator : MonoBehaviour
    {
        public object _m_CancellationTokenSource;
        public object f_04F;
        public object f_A58;
        public object f_626;
        public object f_D56;
        public object headSpeedModifier;
        public object headWeight;
        public object headBoneNonMecanimXform;
        public object f_984;
        public object f_1C1;
        public object useMicroSaccades;
        public object useMacroSaccades;
        public object kDrawSightlinesInEditor;
        public object controlData;
        public object kMinNextBlinkTime;
        public object kMaxNextBlinkTime;
        public object eyelidsFollowEyesVertically;
        public object f_35A;
        public object f_3FB;
        public object f_2C3;
        public object f_711;
        public object f_717;
        public object f_774;
        public object f_E01;
        public object f_ED5;
        public object f_F51;
        public object f_B18;
        public object f_752;
        public object f_D53;
        public object f_05E;
        public object f_BA2;
        public object f_147;
        public object f_BA8;
        public object maxEyeHorizAngle;
        public object maxEyeHorizAngleTowardsNose;
        public object crossEyeCorrection;
        public object nervousness;
        public object limitHeadAngle;
        public object f_C68;
        public object f_5EC;
        public object f_FBA;
        public object f_3F1;
        public object f_8BF;
        public object f_571;
        public object f_BEE;
        public object f_60B;
        public object f_C85;
        public object f_F12;
        public object f_7A4;
        public object f_419;
        public object f_C76;
        public object f_773;
        public object f_4F9;
        public object f_94B;
        public object f_1B1;
        public object f_121;
        public object f_D07;
        public object f_29B;
        public object f_27C;
        public object f_EE6;
        public object f_4F0;
        public object f_F1E;
        public object f_E5A;
        public object f_94F;
        public object f_A5E;
        public object f_B27;
        public object f_A5A;
        public object f_B35;
        public object f_0BC;
        public object f_93F;
        public object f_4FC;
        public object f_FB0;
        public object f_0C5;
        public object f_C7E;
        public object f_0E7;
        public object useFinalIK;
        public object f_0E7;
        public object f_201;
        public object f_BD1;
        public object f_2C8;
        public object f_286;
        public object f_506;
        public object f_5AA;
        public object f_8B1;
        public object f_149;
        public object f_4B5;
        public object f_75E;
        public object f_BBF;
        public object f_257;
        public object f_95F;
        public object f_A1F;
        public object f_FDD;
        public object f_532;
        public object f_449;
        public object f_B51;
        public object f_E29;
        public object f_EE0;
        public object f_B69;
        public object f_38E;
        public object f_1CD;
        public object f_918;
        public object f_515;
        public object f_A81;
        public object f_55C;
        public object f_33B;
        public object f_A17;
        public object f_A28;
        public object f_B4E;
        public object f_CD1;
        public object f_698;
        public object f_181;
        public object f_67B;
        public object f_5EC;
        public object f_8F5;
        public object f_978;
        public object f_876;
        public object f_275;
        public object f_A6D;
        public object f_9D2;
        public object f_EEB;

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x2317100
        public void RaiseCancellation(){} // RVA: 0xB6B1E0
        public void LateUpdate(){} // RVA: 0x2317FE0
        public void OnDrawGizmos(){} // RVA: 0x23182F0
        public void Invoke(){} // RVA: 0x23196C0
        public void .ctor(){} // RVA: 0x2319B70
        public void Initialize(){} // RVA: 0xE35F50
        public void StartCoroutine_Auto(){} // RVA: 0x231DF50
        public void StopCoroutine(){} // RVA: 0x2319F10
        public void StopAllCoroutines(){} // RVA: 0xB6B1F0
        public void get_useGUILayout(){} // RVA: 0x2320160
        public void set_useGUILayout(){} // RVA: 0x2322290
        public void OnEnable(){} // RVA: 0xB43310
        public void get_didAwake(){} // RVA: 0x231A3A0
        public void print(){} // RVA: 0x231A400
        public void Internal_CancelInvokeAll(){} // RVA: 0xB639B0
        public void Internal_IsInvokingAll(){} // RVA: 0x231A750
        public void InvokeDelayed(){} // RVA: 0x231A840
        public void IsObjectMonoBehaviour(){} // RVA: 0x231A850
        public void StartCoroutineManaged(){} // RVA: 0x231A940
        public void StartCoroutineManaged2(){} // RVA: 0x231A960
        public void StopCoroutineManaged(){} // RVA: 0x2322790
        public void StopCoroutineFromEnumeratorManaged(){} // RVA: 0xB639B0
        public void GetScriptClassName(){} // RVA: 0x231B0E0
        public void OnCancellationTokenCreated(){} // RVA: 0x231B6E0
        public void OnCollisionExit(){} // RVA: 0x16529A0
        public void StopCoroutine_Injected(){} // RVA: 0x231B800
        public void StopAllCoroutines_Injected(){} // RVA: 0x231B9F0
        public void get_useGUILayout_Injected(){} // RVA: 0x231BA00
        public void set_useGUILayout_Injected(){} // RVA: 0x231BD30
        public void get_didStart_Injected(){} // RVA: 0x231BE00
        public void get_didAwake_Injected(){} // RVA: 0x231C330
        public void Internal_CancelInvokeAll_Injected(){} // RVA: 0x231CAA0
        public void Internal_IsInvokingAll_Injected(){} // RVA: 0xB6B1D0
        public void InvokeDelayed_Injected(){} // RVA: 0x231CB20
        public void Computebytes(){} // RVA: 0x231CE30
        public void GetEyeTransform(){} // RVA: 0x164FF50
        public void IsObjectMonoBehaviour_Injected(){} // RVA: 0x2324C40
        public void StartCoroutineManaged_Injected(){} // RVA: 0x231D050
        public void StartCoroutineManaged2_Injected(){} // RVA: 0x231DF40
        public void StopCoroutineManaged_Injected(){} // RVA: 0x231DF40
        public void StopCoroutineFromEnumeratorManaged_Injected(){} // RVA: 0xB6B1C0
        public void GetScriptClassName_Injected(){} // RVA: 0x231E010
        public void OnCancellationTokenCreated_Injected(){} // RVA: 0x231E340
        public void OnDestroy(){} // RVA: 0x231E5E0
        public void OnApplicationPause(){} // RVA: 0x231E7D0
        public void OnApplicationQuit(){} // RVA: 0x1F7F310
        public void OnAnimatorIK(){} // RVA: 0x231E920
        public void OnBecameInvisible(){} // RVA: 0x231EC10
        public void OnCollisionEnter(){} // RVA: 0x231EE60
        public void OnCollisionStay(){} // RVA: 0x231EFC0
        public void OnTriggerEnter(){} // RVA: 0x2320140
        public void OnTriggerStay(){} // RVA: 0x23202B0
        public void OnTriggerExit(){} // RVA: 0x231B6E0
        public void Awake(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x2322E30
        public void Start(){} // RVA: 0x2322FC0
        public void FixedUpdate(){} // RVA: 0x2323270
        public void OnBecameVisible(){} // RVA: 0x2324910
        public void OnDisable(){} // RVA: 0x2324A90
        public void Update(){} // RVA: 0x23254C0
        // ── 24 unresolved (hash) ──
        public void m_635(){} // RVA: 0x231E510
        public void m_04C(){} // RVA: 0x231F190
        public void m_6EF(){} // RVA: 0x2320370
        public void m_282(){} // RVA: 0x2320440
        public void m_006(){} // RVA: 0x2320610
        // ... 19 more unresolved methods
    }

    public class EyeAndHeadAnimatorForExport : Object
    {
        public object headBonePath;
        public object headSpeedModifier;
        public object headWeight;
        public object useMicroSaccades;
        public object useMacroSaccades;
        public object kDrawSightlinesInEditor;
        public object controlData;
        public object kMinNextBlinkTime;
        public object kMaxNextBlinkTime;
        public object eyelidsFollowEyesVertically;
        public object maxEyeHorizAngle;
        public object maxEyeHorizAngleTowardsNose;
        public object crossEyeCorrection;
        public object nervousness;
        public object limitHeadAngle;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class EyeRotationLimiter : Object
    {
        public object transform;
        public object defaultQ;
        public object lookUpQ;
        public object lookDownQ;
        public object maxUpAngle;
        public object maxDownAngle;
        public object isLookUpSet;
        public object isLookDownSet;

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x2306FA0
        public void Equals(){} // RVA: 0x2307150
        public void GetHashCode(){} // RVA: 0x2307300
        public void op_Implicit(){} // RVA: 0x23073C0
        public void CompareBaseObjects(){} // RVA: 0x2307470
        public void IsNativeObjectAlive(){} // RVA: 0x2307A20
        public void GetCachedPtr(){} // RVA: 0x2307AE0
        public void get_name(){} // RVA: 0x2307FA0
        public void set_name(){} // RVA: 0x2308450
        public void Instantiate(){} // RVA: 0x23073C0
        public void Destroy(){} // RVA: 0x2308520
        public void DestroyImmediate(){} // RVA: 0x2308560
        public void FindObjectsOfType(){} // RVA: 0x2308B40
        public void FindObjectsByType(){} // RVA: 0x2308C00
        public void DontDestroyOnLoad(){} // RVA: 0x2308CB0
        public void .ctor(){} // RVA: 0xB43310
        public void Initialize(){} // RVA: 0x2308C00
        public void FindObjectOfType(){} // RVA: 0x2308D80
        public void FindFirstObjectByType(){} // RVA: 0x2308DE0
        public void CheckNullArgument(){} // RVA: 0x2308C00
        public void ToString(){} // RVA: 0x2308E20
        public void op_Equality(){} // RVA: 0x2308E90
    }

    public class EyelidRotationLimiter : Object
    {
        public object transform;
        public object defaultQ;
        public object closedQ;
        public object lookUpQ;
        public object lookDownQ;
        public object eyeMaxDownAngle;
        public object eyeMaxUpAngle;
        public object defaultPos;
        public object closedPos;
        public object lookUpPos;
        public object lookDownPos;
        public object isLookUpSet;
        public object isLookDownSet;
        public object isDefaultPosSet;
        public object isClosedPosSet;
        public object isLookUpPosSet;
        public object isLookDownPosSet;

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x2308F40
        public void Equals(){} // RVA: 0x23090D0
        public void GetHashCode(){} // RVA: 0x2309260
        public void op_Implicit(){} // RVA: 0x2309750
        public void CompareBaseObjects(){} // RVA: 0x23098E0
        public void IsNativeObjectAlive(){} // RVA: 0x2309BA0
        public void GetCachedPtr(){} // RVA: 0x230A0C0
        public void get_name(){} // RVA: 0x230A250
        public void set_name(){} // RVA: 0x230A3E0
        public void Instantiate(){} // RVA: 0x230A570
        public void Destroy(){} // RVA: 0x230AB10
        public void DestroyImmediate(){} // RVA: 0x230ADD0
        public void .ctor(){} // RVA: 0xB43310
        public void Initialize(){} // RVA: 0x230AF60
        public void DontDestroyOnLoad(){} // RVA: 0x230B0F0
        public void get_hideFlags(){} // RVA: 0x230B280
        public void set_hideFlags(){} // RVA: 0x230B400
        public void FindObjectOfType(){} // RVA: 0x230B590
        public void FindFirstObjectByType(){} // RVA: 0x230B600
        public void CheckNullArgument(){} // RVA: 0x230B790
    }

    public class LookTargetController : MonoBehaviour
    {
        public object pointsOfInterest;
        public object lookAtPlayerRatio;
        public object stareBackFactor;
        public object noticePlayerDistance;
        public object personalSpaceDistance;
        public object minLookTime;
        public object maxLookTime;
        public object playerEyeCenter;
        public object keepTargetEvenWhenLost;
        public object OnStartLookingAtPlayer;
        public object OnStopLookingAtPlayer;
        public object f_1A5;
        public object f_EAA;
        public object f_A6E;
        public object f_79D;
        public object f_B43;
        public object f_FD3;
        public object f_E97;
        public object f_2E6;
        public object f_EED;
        public object f_5F5;
        public object f_D01;
        public object f_BFE;
        public object f_E54;
        public object f_ED7;
        public object f_5BF;
        public object f_76A;
        public object f_A0F;
        public object f_BAA;
        public object f_2C8;
        public object f_9D6;
        public object f_956;
        public object f_5FF;
        public object f_6A4;
        public object f_564;
        public object isLocal;
        public object f_585;
        public object f_571;
        public object f_D2C;
        public object f_F68;
        public object f_1CB;
        public object f_E4F;
        public object f_CC6;
        public object f_844;
        public object f_339;
        public object f_E58;

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x2327A80
        public void OnDestroy(){} // RVA: 0x2327DD0
        public void IsInvoking(){} // RVA: 0x23280A0
        public void CancelInvoke(){} // RVA: 0x23282F0
        public void Awake(){} // RVA: 0x2328950
        public void InvokeRepeating(){} // RVA: 0x2328AA0
        public void StartCoroutine(){} // RVA: 0x2328AE0
        public void StartCoroutine_Auto(){} // RVA: 0x2328D60
        public void StopCoroutine(){} // RVA: 0x2328E20
        public void LateUpdate(){} // RVA: 0x2329170
        public void get_useGUILayout(){} // RVA: 0x2329E00
        public void set_useGUILayout(){} // RVA: 0x232A090
        public void get_didStart(){} // RVA: 0x2328AA0
        public void get_didAwake(){} // RVA: 0x232C510
        public void print(){} // RVA: 0x232A4C0
        public void Internal_CancelInvokeAll(){} // RVA: 0x232A610
        public void Internal_IsInvokingAll(){} // RVA: 0x232A730
        public void InvokeDelayed(){} // RVA: 0x232A730
        public void IsObjectMonoBehaviour(){} // RVA: 0x232A770
        public void StartCoroutineManaged(){} // RVA: 0x232BB60
        public void StartCoroutineManaged2(){} // RVA: 0x232BDB0
        public void StopCoroutineManaged(){} // RVA: 0x232BE50
        public void .ctor(){} // RVA: 0x232C2B0
        public void Initialize(){} // RVA: 0x232C350
        public void OnCancellationTokenCreated(){} // RVA: 0x232C690
        public void Update(){} // RVA: 0x232C6A0
        public void StopCoroutine_Injected(){} // RVA: 0xB43310
        public void Start(){} // RVA: 0xB43310
        public void get_useGUILayout_Injected(){} // RVA: 0x232C7C0
        public void set_useGUILayout_Injected(){} // RVA: 0x232CE30
        public void get_didStart_Injected(){} // RVA: 0x232CEA0
        public void get_didAwake_Injected(){} // RVA: 0x232D2D0
        public void Internal_CancelInvokeAll_Injected(){} // RVA: 0x232D410
        public void Internal_IsInvokingAll_Injected(){} // RVA: 0x232C690
        public void InvokeDelayed_Injected(){} // RVA: 0x232D4D0
    }

    public class SerializableQuaternion : ValueType
    {
        public object x;
        public object y;
        public object z;
        public object w;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4FE0
        public void Initialize(){} // RVA: 0x2315EC0
        public void DefaultEquals(){} // RVA: 0x2315EC0
        public void ToString(){} // RVA: 0x7BFB0
        public void InternalGetHashCode(){} // RVA: 0x2315EC0
        public void Equals(){} // RVA: 0x2315EC0
        public void GetHashCodeOfPtr(){} // RVA: 0x2315EC0
        public void GetHashCode(){} // RVA: 0x2315EC0
        public void x(){} // RVA: 0x2315EC0
        // ── Unresolved (hash) ──
        public void m_809(){} // RVA: 0x2315EC0
        public void m_660(){} // RVA: 0x2315EC0
    }

    public class SerializableVector3 : ValueType
    {
        public object x;
        public object y;
        public object z;

        // ── Methods ──
        public void Equals(){} // RVA: 0x2331CF0
        public void InternalEquals(){} // RVA: 0x2331CF0
        public void DefaultEquals(){} // RVA: 0x2331CF0
        public void .ctor(){} // RVA: 0x7BFC0
        public void Initialize(){} // RVA: 0x2331CF0
        public void GetHashCode(){} // RVA: 0x2331CF0
        public void GetHashCodeOfPtr(){} // RVA: 0x2331CF0
        public void ToString(){} // RVA: 0x7BFD0
    }

}