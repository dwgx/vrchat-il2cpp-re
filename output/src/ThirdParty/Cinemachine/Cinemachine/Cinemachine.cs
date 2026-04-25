// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Cinemachine.Cinemachine
// Classes: 83
// Methods: 917

namespace ThirdParty.Cinemachine.Cinemachine
{
    public class AxisBase : ValueType
    {
        public float m_Value; // 0x10
        public float m_MinValue; // 0x14
        public float m_MaxValue; // 0x18
        public bool m_Wrap; // 0x1C

        // ── Methods ──
        public void Validate(){} // RVA: 0x7FFAC4843EA0
    }

    public class AxisState : ValueType
    {
        public float HasInputProvider; // 0x10
        public 0x6B229FD0 ValueRangeLocked; // 0x14
        public float HasRecentering; // 0x18
        public float m_AccelTime; // 0x1C
        public float m_DecelTime; // 0x20
        public string m_InputAxisName; // 0x28
        public float m_InputAxisValue; // 0x30
        public bool m_InvertInput; // 0x34
        public float m_MinValue; // 0x38
        public float m_MaxValue; // 0x3C
        public bool m_Wrap; // 0x40
        public Recentering m_Recentering; // 0x44
        public float m_CurrentSpeed; // 0x64
        public float m_LastUpdateTime; // 0x68
        public int m_LastUpdateFrame; // 0x6C
        public float Epsilon;
        public IInputAxisProvider m_InputAxisProvider; // 0x70
        public int m_InputAxisIndex; // 0x78
        public bool <ValueRangeLocked>k__BackingField; // 0x7C
        public bool <HasRecentering>k__BackingField; // 0x7D

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC4836950
        public void Validate(){} // RVA: 0x7FFAC4836AC0
        public void Reset(){} // RVA: 0x7FFAC4836B20
        public void SetInputAxisProvider(){} // RVA: 0x7FFAC4836B30
        public void get_HasInputProvider(){} // RVA: 0x7FFAC4836B90
        public void Update(){} // RVA: 0x7FFAC4836BA0
        public void ClampValue(){} // RVA: 0x7FFAC48370A0
        public void MaxSpeedUpdate(){} // RVA: 0x7FFAC4837110
        public void GetMaxSpeed(){} // RVA: 0x7FFAC4837350
        public void get_ValueRangeLocked(){} // RVA: 0x7FFAC4837400
        public void set_ValueRangeLocked(){} // RVA: 0x7FFAC4837410
        public void get_HasRecentering(){} // RVA: 0x7FFAC4837420
        public void set_HasRecentering(){} // RVA: 0x7FFAC4837430
    }

    public class AxisStatePropertyAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class BlendSourceVirtualCamera : Object
    {
        public Cinemachine.CinemachineBlend Blend; // 0x10
        public int Name; // 0x18
        public UnityEngine.Transform Description; // 0x20
        public UnityEngine.Transform Priority; // 0x28
        public Cinemachine.CameraState LookAt; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void get_Blend(){} // RVA: 0x7FFAC2F3C380
        public void set_Blend(){} // RVA: 0x7FFAC2F22E30
        public void get_Name(){} // RVA: 0x7FFAC483EB10
        public void get_Description(){} // RVA: 0x7FFAC483EB50
        public void get_Priority(){} // RVA: 0x7FFAC3157800
        public void set_Priority(){} // RVA: 0x7FFAC392CD10
        public void get_LookAt(){} // RVA: 0x7FFAC2F4F0C0
        public void set_LookAt(){} // RVA: 0x7FFAC2F4F0D0
        public void get_Follow(){} // RVA: 0x7FFAC2F4F130
        public void set_Follow(){} // RVA: 0x7FFAC2F22E90
        public void get_State(){} // RVA: 0x7FFAC483E990
        public void set_State(){} // RVA: 0x7FFAC483EA30
        public void get_VirtualCameraGameObject(){} // RVA: 0x7FFAC34F9180
        public void get_IsValid(){} // RVA: 0x7FFAC483EBA0
        public void get_ParentCamera(){} // RVA: 0x7FFAC34F9180
        public void IsLiveChild(){} // RVA: 0x7FFAC483EBC0
        public void CalculateNewState(){} // RVA: 0x7FFAC483E990
        public void UpdateCameraState(){} // RVA: 0x7FFAC483EBE0
        public void InternalUpdateCameraState(){} // RVA: 0x7FFAC2F21310
        public void OnTransitionFromCamera(){} // RVA: 0x7FFAC2F21310
        public void OnTargetObjectWarped(){} // RVA: 0x7FFAC2F21310
    }

    public class CameraState : ValueType
    {
        public Cinemachine.LensSettings HasLookAt; // 0x10
        public UnityEngine.Vector3 CorrectedPosition; // 0x44
        public UnityEngine.Vector3 CorrectedOrientation; // 0x50
        public UnityEngine.Vector3 FinalPosition;
        public UnityEngine.Vector3 FinalOrientation; // 0x5C
        public UnityEngine.Quaternion Default; // 0x68
        public UnityEngine.Vector3 NumCustomBlendables; // 0x78
        public float ShotQuality; // 0x84
        public UnityEngine.Vector3 PositionCorrection; // 0x88
        public UnityEngine.Quaternion OrientationCorrection; // 0x94
        public 0x6B22A130 BlendHint; // 0xA4
        public CustomBlendable mCustom0; // 0xA8
        public CustomBlendable mCustom1; // 0xB8
        public CustomBlendable mCustom2; // 0xC8
        public CustomBlendable mCustom3; // 0xD8
        public System.Collections.Generic.List`1<CustomBlendable> m_CustomOverflow; // 0xE8
        public int <NumCustomBlendables>k__BackingField; // 0xF0

        // ── Methods ──
        public void get_HasLookAt(){} // RVA: 0x7FFAC4837810
        public void get_CorrectedPosition(){} // RVA: 0x7FFAC4837870
        public void get_CorrectedOrientation(){} // RVA: 0x7FFAC48378C0
        public void get_FinalPosition(){} // RVA: 0x7FFAC4837870
        public void get_FinalOrientation(){} // RVA: 0x7FFAC4837A30
        public void get_Default(){} // RVA: 0x7FFAC4837CF0
        public void get_NumCustomBlendables(){} // RVA: 0x7FFAC4837F50
        public void set_NumCustomBlendables(){} // RVA: 0x7FFAC4837F60
        public void GetCustomBlendable(){} // RVA: 0x7FFAC4837F70
        public void FindCustomBlendable(){} // RVA: 0x7FFAC48380E0
        public void AddCustomBlendable(){} // RVA: 0x7FFAC4838660
        public void Lerp(){} // RVA: 0x7FFAC4838A20
        public void InterpolateFOV(){} // RVA: 0x7FFAC483CA80
        public void ApplyPosBlendHint(){} // RVA: 0x7FFAC483CBD0
        public void ApplyRotBlendHint(){} // RVA: 0x7FFAC483CC50
        public void InterpolatePosition(){} // RVA: 0x7FFAC483CCA0
        public void .cctor(){} // RVA: 0x7FFAC483D190
    }

    public class Cinemachine3rdPersonAim : CinemachineExtension
    {
        public UnityEngine.LayerMask AimTarget; // 0x30
        public string IgnoreTag; // 0x38
        public float AimDistance; // 0x40
        public UnityEngine.RectTransform AimTargetReticle; // 0x48
        public UnityEngine.Vector3 <AimTarget>k__BackingField; // 0x50

        // ── Methods ──
        public void get_AimTarget(){} // RVA: 0x7FFAC2F87FA0
        public void set_AimTarget(){} // RVA: 0x7FFAC2F87FC0
        public void OnValidate(){} // RVA: 0x7FFAC47EE460
        public void Reset(){} // RVA: 0x7FFAC47EE480
        public void OnTransitionFromCamera(){} // RVA: 0x7FFAC47EE590
        public void DrawReticle(){} // RVA: 0x7FFAC47EE710
        public void ComputeLookAtPoint(){} // RVA: 0x7FFAC47EEAA0
        public void ComputeAimTarget(){} // RVA: 0x7FFAC47EF0D0
        public void PostPipelineStageCallback(){} // RVA: 0x7FFAC47EF350
        public void .ctor(){} // RVA: 0x7FFAC47EF6A0
    }

    public class Cinemachine3rdPersonFollow : CinemachineComponentBase
    {
        public UnityEngine.Vector3 IsValid; // 0x28
        public UnityEngine.Vector3 Stage; // 0x34
        public float VerticalArmLength; // 0x40
        public float CameraSide; // 0x44
        public float CameraDistance; // 0x48
        public UnityEngine.LayerMask CameraCollisionFilter; // 0x4C
        public string IgnoreTag; // 0x50
        public float CameraRadius; // 0x58
        public float DampingIntoCollision; // 0x5C
        public float DampingFromCollision; // 0x60
        public UnityEngine.Vector3 m_PreviousFollowTargetPosition; // 0x64
        public UnityEngine.Vector3 m_DampingCorrection; // 0x70
        public float m_CamPosCollisionCorrection; // 0x7C

        // ── Methods ──
        public void OnValidate(){} // RVA: 0x7FFAC48200F0
        public void Reset(){} // RVA: 0x7FFAC4820170
        public void OnDestroy(){} // RVA: 0x7FFAC48201E0
        public void get_IsValid(){} // RVA: 0x7FFAC4820230
        public void get_Stage(){} // RVA: 0x7FFAC34F9180
        public void GetMaxDampTime(){} // RVA: 0x7FFAC4820350
        public void MutateCameraState(){} // RVA: 0x7FFAC4820380
        public void OnTargetObjectWarped(){} // RVA: 0x7FFAC4820410
        public void PositionCamera(){} // RVA: 0x7FFAC4820580
        public void GetRigPositions(){} // RVA: 0x7FFAC4820CA0
        public void GetHeading(){} // RVA: 0x7FFAC4820EC0
        public void GetRawRigPositions(){} // RVA: 0x7FFAC4821440
        public void ResolveCollisions(){} // RVA: 0x7FFAC48217C0
        public void .ctor(){} // RVA: 0x7FFAC4821B10
    }

    public class CinemachineBasicMultiChannelPerlin : CinemachineComponentBase
    {
        public Cinemachine.NoiseSettings IsValid; // 0x28
        public UnityEngine.Vector3 Stage; // 0x30
        public float m_AmplitudeGain; // 0x3C
        public float m_FrequencyGain; // 0x40
        public bool mInitialized; // 0x44
        public float mNoiseTime; // 0x48
        public UnityEngine.Vector3 mNoiseOffsets; // 0x4C

        // ── Methods ──
        public void get_IsValid(){} // RVA: 0x7FFAC4821BE0
        public void get_Stage(){} // RVA: 0x7FFAC3026CB0
        public void MutateCameraState(){} // RVA: 0x7FFAC4821D00
        public void ReSeed(){} // RVA: 0x7FFAC48227E0
        public void Initialize(){} // RVA: 0x7FFAC4822910
        public void .ctor(){} // RVA: 0x7FFAC4822B20
    }

    public class CinemachineBlend : Object
    {
        public Cinemachine.ICinemachineCamera BlendWeight; // 0x10
        public Cinemachine.ICinemachineCamera IsValid; // 0x18
        public UnityEngine.AnimationCurve IsComplete; // 0x20
        public float Description; // 0x28
        public float State; // 0x2C

        // ── Methods ──
        public void get_BlendWeight(){} // RVA: 0x7FFAC483D1E0
        public void get_IsValid(){} // RVA: 0x7FFAC483D2D0
        public void get_IsComplete(){} // RVA: 0x7FFAC483D350
        public void get_Description(){} // RVA: 0x7FFAC483D380
        public void Uses(){} // RVA: 0x7FFAC483D590
        public void .ctor(){} // RVA: 0x7FFAC483D6D0
        public void UpdateCameraState(){} // RVA: 0x7FFAC483D7F0
        public void get_State(){} // RVA: 0x7FFAC483D8E0
    }

    public class CinemachineBlendDefinition : ValueType
    {
        public 0x6B22A290 BlendTime; // 0x10
        public float BlendCurve; // 0x14
        public UnityEngine.AnimationCurve m_CustomCurve; // 0x18
        public UnityEngine.AnimationCurve[] sStandardCurves;

        // ── Methods ──
        public void get_BlendTime(){} // RVA: 0x7FFAC483DDB0
        public void .ctor(){} // RVA: 0x7FFAC483DDC0
        public void CreateStandardCurves(){} // RVA: 0x7FFAC483DE20
        public void get_BlendCurve(){} // RVA: 0x7FFAC483E690
    }

    public class CinemachineBlendDefinitionPropertyAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class CinemachineBlendListCamera : CinemachineVirtualCameraBase
    {
        public UnityEngine.Transform Description; // 0xA8
        public UnityEngine.Transform LiveChild; // 0xB0
        public bool State; // 0xB8
        public bool LookAt; // 0xB9
        public Cinemachine.CinemachineVirtualCameraBase[] Follow; // 0xC0
        public Instruction[] ChildCameras; // 0xC8
        public Cinemachine.ICinemachineCamera IsBlending; // 0xD0
        public Cinemachine.ICinemachineCamera m_TransitioningFrom; // 0xD8
        public Cinemachine.CameraState m_State; // 0xE0
        public float mActivationTime; // 0x1C8
        public int mCurrentInstruction; // 0x1CC
        public Cinemachine.CinemachineBlend mActiveBlend; // 0x1D0

        // ── Methods ──
        public void get_Description(){} // RVA: 0x7FFAC47EF770
        public void Reset(){} // RVA: 0x7FFAC47EF8B0
        public void get_LiveChild(){} // RVA: 0x7FFAC303E100
        public void set_LiveChild(){} // RVA: 0x7FFAC303E110
        public void IsLiveChild(){} // RVA: 0x7FFAC47EFA20
        public void get_State(){} // RVA: 0x7FFAC47EFA50
        public void get_LookAt(){} // RVA: 0x7FFAC47EFAF0
        public void set_LookAt(){} // RVA: 0x7FFAC334B370
        public void get_Follow(){} // RVA: 0x7FFAC47EFB00
        public void set_Follow(){} // RVA: 0x7FFAC2F8C050
        public void OnTargetObjectWarped(){} // RVA: 0x7FFAC47EFB10
        public void ForceCameraPosition(){} // RVA: 0x7FFAC47EFBF0
        public void OnTransitionFromCamera(){} // RVA: 0x7FFAC47EFD80
        public void InternalUpdateCameraState(){} // RVA: 0x7FFAC47EFFB0
        public void OnEnable(){} // RVA: 0x7FFAC47F0980
        public void OnDisable(){} // RVA: 0x7FFAC47F0CE0
        public void OnTransformChildrenChanged(){} // RVA: 0x7FFAC47F0E60
        public void OnGuiHandler(){} // RVA: 0x7FFAC47F0E70
        public void get_ChildCameras(){} // RVA: 0x7FFAC47F0FE0
        public void get_IsBlending(){} // RVA: 0x7FFAC47F1000
        public void InvalidateListOfChildren(){} // RVA: 0x7FFAC47F1010
        public void UpdateListOfChildren(){} // RVA: 0x7FFAC47F10D0
        public void ValidateInstructions(){} // RVA: 0x7FFAC47F1460
        public void AdvanceCurrentInstruction(){} // RVA: 0x7FFAC47F1860
        public void .ctor(){} // RVA: 0x7FFAC47F1AC0
    }

    public class CinemachineBlenderSettings : ScriptableObject
    {
        public CustomBlend[] m_CustomBlends; // 0x18
        public string kBlendFromAnyCameraLabel;

        // ── Methods ──
        public void GetBlendForVirtualCameras(){} // RVA: 0x7FFAC483EDB0
        public void .ctor(){} // RVA: 0x7FFAC312F5F0
    }

    public class CinemachineBrain : MonoBehaviour
    {
        public bool OutputCamera; // 0x20
        public bool ControlledObject; // 0x21
        public bool SoloCamera; // 0x22
        public UnityEngine.Transform DefaultWorldUp; // 0x28
        public 0x6B2283F8 ActiveVirtualCamera; // 0x30
        public 0x6B228450 IsBlending; // 0x34
        public Cinemachine.CinemachineBlendDefinition ActiveBlend; // 0x38
        public Cinemachine.CinemachineBlenderSettings CurrentCameraState; // 0x48
        public UnityEngine.Camera m_OutputCamera; // 0x50
        public UnityEngine.GameObject m_TargetOverride; // 0x58
        public BrainEvent m_CameraCutEvent; // 0x60
        public VcamActivatedEvent m_CameraActivatedEvent; // 0x68
        public Cinemachine.ICinemachineCamera mSoloCamera;
        public UnityEngine.Coroutine mPhysicsCoroutine; // 0x70
        public int m_LastFrameUpdated; // 0x78
        public UnityEngine.WaitForFixedUpdate mWaitForFixedUpdate; // 0x80
        public System.Collections.Generic.List`1<BrainFrame> mFrameStack; // 0x88
        public int mNextFrameId; // 0x90
        public Cinemachine.CinemachineBlend mCurrentLiveCameras; // 0x98
        public UnityEngine.AnimationCurve mDefaultLinearAnimationCurve; // 0x8
        public Cinemachine.ICinemachineCamera mActiveCameraPreviousFrame; // 0xA0
        public UnityEngine.GameObject mActiveCameraPreviousFrameGameObject; // 0xA8
        public Cinemachine.CameraState <CurrentCameraState>k__BackingField; // 0xB0

        // ── Methods ──
        public void get_OutputCamera(){} // RVA: 0x7FFAC47F1C90
        public void get_ControlledObject(){} // RVA: 0x7FFAC47F1E00
        public void set_ControlledObject(){} // RVA: 0x7FFAC47F1F20
        public void get_SoloCamera(){} // RVA: 0x7FFAC47F1FE0
        public void set_SoloCamera(){} // RVA: 0x7FFAC47F2040
        public void GetSoloGUIColor(){} // RVA: 0x7FFAC47F22A0
        public void get_DefaultWorldUp(){} // RVA: 0x7FFAC47F22C0
        public void OnEnable(){} // RVA: 0x7FFAC47F2450
        public void OnDisable(){} // RVA: 0x7FFAC47F29C0
        public void OnSceneLoaded(){} // RVA: 0x7FFAC47F2CC0
        public void OnSceneUnloaded(){} // RVA: 0x7FFAC47F2D60
        public void Awake(){} // RVA: 0x7FFAC47F2E00
        public void Start(){} // RVA: 0x7FFAC47F2E60
        public void OnGuiHandler(){} // RVA: 0x7FFAC47F2E80
        public void AfterPhysics(){} // RVA: 0x7FFAC47F3360
        public void LateUpdate(){} // RVA: 0x7FFAC47F3400
        public void ManualUpdate(){} // RVA: 0x7FFAC47F3410
        public void GetEffectiveDeltaTime(){} // RVA: 0x7FFAC47F3740
        public void UpdateVirtualCameras(){} // RVA: 0x7FFAC47F39E0
        public void get_ActiveVirtualCamera(){} // RVA: 0x7FFAC47F3D70
        public void DeepCamBFromBlend(){} // RVA: 0x7FFAC47F3EF0
        public void IsLiveInBlend(){} // RVA: 0x7FFAC47F3FB0
        public void get_IsBlending(){} // RVA: 0x7FFAC47F40F0
        public void get_ActiveBlend(){} // RVA: 0x7FFAC47F4110
        public void set_ActiveBlend(){} // RVA: 0x7FFAC47F4210
        public void GetBrainFrame(){} // RVA: 0x7FFAC47F4330
        public void SetCameraOverride(){} // RVA: 0x7FFAC47F4470
        public void ReleaseCameraOverride(){} // RVA: 0x7FFAC47F49A0
        public void ProcessActiveCamera(){} // RVA: 0x7FFAC47F4A80
        public void UpdateFrame0(){} // RVA: 0x7FFAC47F51D0
        public void ComputeCurrentBlend(){} // RVA: 0x7FFAC47F5A00
        public void IsLive(){} // RVA: 0x7FFAC47F6000
        public void get_CurrentCameraState(){} // RVA: 0x7FFAC47F61E0
        public void set_CurrentCameraState(){} // RVA: 0x7FFAC47F6280
        public void TopCameraFromPriorityQueue(){} // RVA: 0x7FFAC47F6370
        public void LookupBlend(){} // RVA: 0x7FFAC47F66A0
        public void PushStateToUnityCamera(){} // RVA: 0x7FFAC47F6900
        public void .ctor(){} // RVA: 0x7FFAC47F6F90
        public void .cctor(){} // RVA: 0x7FFAC47F73F0
    }

    public class CinemachineClearShot : CinemachineVirtualCameraBase
    {
        public UnityEngine.Transform Description; // 0xA8
        public UnityEngine.Transform LiveChild; // 0xB0
        public bool State; // 0xB8
        public Cinemachine.CinemachineVirtualCameraBase[] LookAt; // 0xC0
        public float Follow; // 0xC8
        public float IsBlending; // 0xCC
        public bool ActiveBlend; // 0xD0
        public Cinemachine.CinemachineBlendDefinition ChildCameras; // 0xD8
        public Cinemachine.CinemachineBlenderSettings m_CustomBlends; // 0xE8
        public Cinemachine.ICinemachineCamera <LiveChild>k__BackingField; // 0xF0
        public Cinemachine.CameraState m_State; // 0xF8
        public float mActivationTime; // 0x1E0
        public float mPendingActivationTime; // 0x1E4
        public Cinemachine.ICinemachineCamera mPendingCamera; // 0x1E8
        public Cinemachine.CinemachineBlend mActiveBlend; // 0x1F0
        public bool mRandomizeNow; // 0x1F8
        public Cinemachine.CinemachineVirtualCameraBase[] m_RandomizedChilden; // 0x200
        public Cinemachine.ICinemachineCamera m_TransitioningFrom; // 0x208

        // ── Methods ──
        public void get_Description(){} // RVA: 0x7FFAC47F79B0
        public void get_LiveChild(){} // RVA: 0x7FFAC2F8C2A0
        public void set_LiveChild(){} // RVA: 0x7FFAC2F8C2B0
        public void get_State(){} // RVA: 0x7FFAC47F7AF0
        public void IsLiveChild(){} // RVA: 0x7FFAC47F7B90
        public void get_LookAt(){} // RVA: 0x7FFAC47EFAF0
        public void set_LookAt(){} // RVA: 0x7FFAC334B370
        public void get_Follow(){} // RVA: 0x7FFAC47EFB00
        public void set_Follow(){} // RVA: 0x7FFAC2F8C050
        public void OnTargetObjectWarped(){} // RVA: 0x7FFAC47F7BC0
        public void ForceCameraPosition(){} // RVA: 0x7FFAC47F7CA0
        public void InternalUpdateCameraState(){} // RVA: 0x7FFAC47F7E30
        public void OnEnable(){} // RVA: 0x7FFAC47F8570
        public void OnDisable(){} // RVA: 0x7FFAC47F8880
        public void OnTransformChildrenChanged(){} // RVA: 0x7FFAC47F8A00
        public void OnGuiHandler(){} // RVA: 0x7FFAC47F8A20
        public void get_IsBlending(){} // RVA: 0x7FFAC47F8B90
        public void get_ActiveBlend(){} // RVA: 0x7FFAC3544EF0
        public void get_ChildCameras(){} // RVA: 0x7FFAC47F8BA0
        public void InvalidateListOfChildren(){} // RVA: 0x7FFAC47F8BC0
        public void ResetRandomization(){} // RVA: 0x7FFAC47F8CE0
        public void UpdateListOfChildren(){} // RVA: 0x7FFAC47F8D60
        public void ChooseCurrentCamera(){} // RVA: 0x7FFAC47F9220
        public void Randomize(){} // RVA: 0x7FFAC47F9C00
        public void LookupBlend(){} // RVA: 0x7FFAC47FA130
        public void OnTransitionFromCamera(){} // RVA: 0x7FFAC47FA3A0
        public void .ctor(){} // RVA: 0x7FFAC47FA530
    }

    public class CinemachineCollider : CinemachineExtension
    {
        public UnityEngine.LayerMask DebugPaths; // 0x30
        public string m_IgnoreTag; // 0x38
        public UnityEngine.LayerMask m_TransparentLayers; // 0x40
        public float m_MinimumDistanceFromTarget; // 0x44
        public bool m_AvoidObstacles; // 0x48
        public float m_DistanceLimit; // 0x4C
        public float m_MinimumOcclusionTime; // 0x50
        public float m_CameraRadius; // 0x54
        public 0x6B228768 m_Strategy; // 0x58
        public int m_MaximumEffort; // 0x5C
        public float m_SmoothingTime; // 0x60
        public float m_Damping; // 0x64
        public float m_DampingWhenOccluded; // 0x68
        public float m_OptimalTargetDistance; // 0x6C
        public float k_PrecisionSlush;
        public UnityEngine.RaycastHit[] m_CornerBuffer; // 0x70
        public float k_AngleThreshold;
        public UnityEngine.Collider[] s_ColliderBuffer;

        // ── Methods ──
        public void IsTargetObscured(){} // RVA: 0x7FFAC47FA880
        public void CameraWasDisplaced(){} // RVA: 0x7FFAC47FA8E0
        public void GetCameraDisplacementDistance(){} // RVA: 0x7FFAC47FA950
        public void OnValidate(){} // RVA: 0x7FFAC47FA9C0
        public void OnDestroy(){} // RVA: 0x7FFAC47FAA10
        public void get_DebugPaths(){} // RVA: 0x7FFAC47FAA80
        public void GetMaxDampTime(){} // RVA: 0x7FFAC47FACA0
        public void OnTargetObjectWarped(){} // RVA: 0x7FFAC47FACC0
        public void PostPipelineStageCallback(){} // RVA: 0x7FFAC47FADC0
        public void PreserveLineOfSight(){} // RVA: 0x7FFAC47FC090
        public void PullCameraInFrontOfNearestObstacle(){} // RVA: 0x7FFAC47FC680
        public void PushCameraBack(){} // RVA: 0x7FFAC47FCBA0
        public void GetWalkingDirection(){} // RVA: 0x7FFAC47FD630
        public void GetPushBackDistance(){} // RVA: 0x7FFAC47FDF70
        public void ClampRayToBounds(){} // RVA: 0x7FFAC47FE0E0
        public void RespectCameraRadius(){} // RVA: 0x7FFAC47FEFF0
        public void CheckForTargetObstructions(){} // RVA: 0x7FFAC47FFCC0
        public void IsTargetOffscreen(){} // RVA: 0x7FFAC4800130
        public void .ctor(){} // RVA: 0x7FFAC48009B0
        public void .cctor(){} // RVA: 0x7FFAC4800B20
    }

    public class CinemachineCollisionImpulseSource : CinemachineImpulseSource
    {
        public UnityEngine.LayerMask m_LayerMask; // 0x38
        public string m_IgnoreTag; // 0x40
        public bool m_UseImpactDirection; // 0x48
        public bool m_ScaleImpactWithMass; // 0x49
        public bool m_ScaleImpactWithSpeed; // 0x4A
        public UnityEngine.Rigidbody mRigidBody; // 0x50
        public UnityEngine.Rigidbody2D mRigidBody2D; // 0x58

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAC4854910
        public void OnEnable(){} // RVA: 0x7FFAC2F21310
        public void OnCollisionEnter(){} // RVA: 0x7FFAC4854A30
        public void OnTriggerEnter(){} // RVA: 0x7FFAC4854AE0
        public void GetMassAndVelocity(){} // RVA: 0x7FFAC4854B50
        public void GenerateImpactEvent(){} // RVA: 0x7FFAC4855050
        public void OnCollisionEnter2D(){} // RVA: 0x7FFAC48553C0
        public void OnTriggerEnter2D(){} // RVA: 0x7FFAC4855420
        public void GetMassAndVelocity2D(){} // RVA: 0x7FFAC4855490
        public void GenerateImpactEvent2D(){} // RVA: 0x7FFAC48558E0
        public void .ctor(){} // RVA: 0x7FFAC4855C50
    }

    public class CinemachineComponentBase : MonoBehaviour
    {
        public float VirtualCamera;
        public Cinemachine.CinemachineVirtualCameraBase FollowTarget; // 0x20

        // ── Methods ──
        public void get_VirtualCamera(){} // RVA: 0x7FFAC483F110
        public void get_FollowTarget(){} // RVA: 0x7FFAC483F520
        public void get_LookAtTarget(){} // RVA: 0x7FFAC483F620
        public void get_AbstractFollowTargetGroup(){} // RVA: 0x7FFAC483F720
        public void get_FollowTargetGroup(){} // RVA: 0x7FFAC483F800
        public void get_FollowTargetPosition(){} // RVA: 0x7FFAC483F890
        public void get_FollowTargetRotation(){} // RVA: 0x7FFAC483FB90
        public void get_AbstractLookAtTargetGroup(){} // RVA: 0x7FFAC483FE60
        public void get_LookAtTargetGroup(){} // RVA: 0x7FFAC483FE90
        public void get_LookAtTargetPosition(){} // RVA: 0x7FFAC483FF30
        public void get_LookAtTargetRotation(){} // RVA: 0x7FFAC4840230
        public void get_VcamState(){} // RVA: 0x7FFAC4840500
        public void get_IsValid(){} // RVA: 0x7FFAC2C59D00
        public void PrePipelineMutateCameraState(){} // RVA: 0x7FFAC2F21310
        public void get_Stage(){} // RVA: 0x7FFAC2C59960
        public void get_BodyAppliesAfterAim(){} // RVA: 0x7FFAC2F21320
        public void MutateCameraState(){} // RVA: 0x7FFAC2C7D7B0
        public void OnTransitionFromCamera(){} // RVA: 0x7FFAC2F21320
        public void OnTargetObjectWarped(){} // RVA: 0x7FFAC2F21310
        public void ForceCameraPosition(){} // RVA: 0x7FFAC2F21310
        public void GetMaxDampTime(){} // RVA: 0x7FFAC37432E0
        public void get_RequiresUserInput(){} // RVA: 0x7FFAC2F21320
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class CinemachineComposer : CinemachineComponentBase
    {
        public UnityEngine.Vector3 IsValid; // 0x28
        public float Stage; // 0x34
        public float TrackedPoint; // 0x38
        public bool SoftGuideRect; // 0x3C
        public float HardGuideRect; // 0x40
        public float m_VerticalDamping; // 0x44
        public float m_ScreenX; // 0x48
        public float m_ScreenY; // 0x4C
        public float m_DeadZoneWidth; // 0x50
        public float m_DeadZoneHeight; // 0x54
        public float m_SoftZoneWidth; // 0x58
        public float m_SoftZoneHeight; // 0x5C
        public float m_BiasX; // 0x60
        public float m_BiasY; // 0x64
        public bool m_CenterOnActivate; // 0x68
        public UnityEngine.Vector3 <TrackedPoint>k__BackingField; // 0x6C
        public UnityEngine.Vector3 m_CameraPosPrevFrame; // 0x78
        public UnityEngine.Vector3 m_LookAtPrevFrame; // 0x84
        public UnityEngine.Vector2 m_ScreenOffsetPrevFrame; // 0x90
        public UnityEngine.Quaternion m_CameraOrientationPrevFrame; // 0x98
        public Cinemachine.Utility.PositionPredictor m_Predictor; // 0xA8
        public FovCache mCache; // 0xB0

        // ── Methods ──
        public void get_IsValid(){} // RVA: 0x7FFAC4822C00
        public void get_Stage(){} // RVA: 0x7FFAC3013AF0
        public void get_TrackedPoint(){} // RVA: 0x7FFAC4822D20
        public void set_TrackedPoint(){} // RVA: 0x7FFAC4822D40
        public void GetLookAtPointAndSetTrackedPoint(){} // RVA: 0x7FFAC4822D50
        public void OnTargetObjectWarped(){} // RVA: 0x7FFAC4823220
        public void ForceCameraPosition(){} // RVA: 0x7FFAC4823420
        public void GetMaxDampTime(){} // RVA: 0x7FFAC4823440
        public void PrePipelineMutateCameraState(){} // RVA: 0x7FFAC4823450
        public void MutateCameraState(){} // RVA: 0x7FFAC4823590
        public void get_SoftGuideRect(){} // RVA: 0x7FFAC4824340
        public void set_SoftGuideRect(){} // RVA: 0x7FFAC4824390
        public void get_HardGuideRect(){} // RVA: 0x7FFAC4824450
        public void set_HardGuideRect(){} // RVA: 0x7FFAC48244D0
        public void RotateToScreenBounds(){} // RVA: 0x7FFAC4824540
        public void ClampVerticalBounds(){} // RVA: 0x7FFAC4824820
        public void .ctor(){} // RVA: 0x7FFAC4824B20
    }

    public class CinemachineConfiner : CinemachineExtension
    {
        public 0x6B228870 IsValid; // 0x30
        public UnityEngine.Collider m_BoundingVolume; // 0x38
        public UnityEngine.Collider2D m_BoundingShape2D; // 0x40
        public UnityEngine.Collider2D m_BoundingShape2DCache; // 0x48
        public bool m_ConfineScreenEdges; // 0x50
        public float m_Damping; // 0x54
        public System.Collections.Generic.List`1<System.Collections.Generic.List`1<UnityEngine.Vector2>> m_pathCache; // 0x58
        public int m_pathTotalPointCount; // 0x60

        // ── Methods ──
        public void CameraWasDisplaced(){} // RVA: 0x7FFAC4800D60
        public void GetCameraDisplacementDistance(){} // RVA: 0x7FFAC4800DD0
        public void OnValidate(){} // RVA: 0x7FFAC4800E30
        public void ConnectToVcam(){} // RVA: 0x7FFAC4800E40
        public void get_IsValid(){} // RVA: 0x7FFAC4800E50
        public void GetMaxDampTime(){} // RVA: 0x7FFAC3391600
        public void PostPipelineStageCallback(){} // RVA: 0x7FFAC48010E0
        public void InvalidatePathCache(){} // RVA: 0x7FFAC48013C0
        public void ValidatePathCache(){} // RVA: 0x7FFAC4801470
        public void ConfinePoint(){} // RVA: 0x7FFAC4801DB0
        public void ConfineScreenEdges(){} // RVA: 0x7FFAC48023F0
        public void .ctor(){} // RVA: 0x7FFAC4802C20
    }

    public class CinemachineConfiner2D : CinemachineExtension
    {
        public UnityEngine.Collider2D m_BoundingShape2D; // 0x30
        public float m_Damping; // 0x38
        public float m_MaxWindowSize; // 0x3C
        public float m_Padding; // 0x40
        public float m_MaxComputationTimePerFrameInSeconds; // 0x44
        public float k_cornerAngleTreshold;
        public ShapeCache m_shapeCache; // 0x48

        // ── Methods ──
        public void InvalidateCache(){} // RVA: 0x7FFAC4802C70
        public void ValidateCache(){} // RVA: 0x7FFAC4802C80
        public void PostPipelineStageCallback(){} // RVA: 0x7FFAC4802CD0
        public void CalculateHalfFrustumHeight(){} // RVA: 0x7FFAC4803500
        public void OnValidate(){} // RVA: 0x7FFAC48035B0
        public void Reset(){} // RVA: 0x7FFAC48035D0
        public void .ctor(){} // RVA: 0x7FFAC48035E0
    }

    public class CinemachineCore : Object
    {
        public int Instance;
        public Cinemachine.CinemachineCore DeltaTime; // 0x8
        public bool CurrentTime; // 0x10
        public AxisInputDelegate BrainCount; // 0x18
        public float VirtualCameraCount; // 0x20
        public float CurrentTimeOverride; // 0x24
        public GetBlendOverrideDelegate GetBlendOverride; // 0x28
        public BrainEvent CameraUpdatedEvent; // 0x30
        public BrainEvent CameraCutEvent; // 0x38
        public System.Collections.Generic.List`1<Cinemachine.CinemachineBrain> mActiveBrains; // 0x10
        public bool FrameDeltaCompensationEnabled; // 0x40
        public System.Collections.Generic.List`1<Cinemachine.CinemachineVirtualCameraBase> mActiveCameras; // 0x18
        public bool m_ActiveCamerasAreSorted; // 0x20
        public int m_ActivationSequence; // 0x24
        public System.Collections.Generic.List`1<System.Collections.Generic.List`1<Cinemachine.CinemachineVirtualCameraBase>> mAllCameras; // 0x28
        public Cinemachine.CinemachineVirtualCameraBase mRoundRobinVcamLastFrame; // 0x30
        public float s_LastUpdateTime; // 0x44
        public int s_FixedFrameCount; // 0x48
        public System.Collections.Generic.Dictionary`2<Cinemachine.CinemachineVirtualCameraBase,UpdateStatus> mUpdateStatus; // 0x38
        public 0x6B22A6B0 m_CurrentUpdateFilter; // 0x40

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFAC48406B0
        public void get_DeltaTime(){} // RVA: 0x7FFAC48407E0
        public void get_CurrentTime(){} // RVA: 0x7FFAC48408A0
        public void get_BrainCount(){} // RVA: 0x7FFAC4840960
        public void GetActiveBrain(){} // RVA: 0x7FFAC48409B0
        public void AddActiveBrain(){} // RVA: 0x7FFAC4840A30
        public void RemoveActiveBrain(){} // RVA: 0x7FFAC4840AD0
        public void get_VirtualCameraCount(){} // RVA: 0x7FFAC4840B30
        public void GetVirtualCamera(){} // RVA: 0x7FFAC4840B80
        public void AddActiveCamera(){} // RVA: 0x7FFAC4840D40
        public void RemoveActiveCamera(){} // RVA: 0x7FFAC4840DB0
        public void CameraDestroyed(){} // RVA: 0x7FFAC4840E30
        public void CameraEnabled(){} // RVA: 0x7FFAC4840F20
        public void CameraDisabled(){} // RVA: 0x7FFAC4841180
        public void UpdateAllActiveVirtualCameras(){} // RVA: 0x7FFAC48413B0
        public void UpdateVirtualCamera(){} // RVA: 0x7FFAC4841AC0
        public void InitializeModule(){} // RVA: 0x7FFAC4841FB0
        public void GetUpdateTarget(){} // RVA: 0x7FFAC48420B0
        public void GetVcamUpdateStatus(){} // RVA: 0x7FFAC48423D0
        public void IsLive(){} // RVA: 0x7FFAC4842460
        public void IsLiveInBlend(){} // RVA: 0x7FFAC48425C0
        public void GenerateCameraActivationEvent(){} // RVA: 0x7FFAC4842720
        public void GenerateCameraCutEvent(){} // RVA: 0x7FFAC4842900
        public void FindPotentialTargetBrain(){} // RVA: 0x7FFAC4842B50
        public void OnTargetObjectWarped(){} // RVA: 0x7FFAC4843020
        public void .ctor(){} // RVA: 0x7FFAC48430F0
        public void .cctor(){} // RVA: 0x7FFAC48432E0
    }

    public class CinemachineDollyCart : MonoBehaviour
    {
        public Cinemachine.CinemachinePathBase m_Path; // 0x20
        public 0x6B228A80 m_UpdateMethod; // 0x28
        public 0x6B22A918 m_PositionUnits; // 0x2C
        public float m_Speed; // 0x30
        public float m_Position; // 0x34

        // ── Methods ──
        public void FixedUpdate(){} // RVA: 0x7FFAC48048E0
        public void Update(){} // RVA: 0x7FFAC4804970
        public void LateUpdate(){} // RVA: 0x7FFAC4804A80
        public void SetCartPosition(){} // RVA: 0x7FFAC4804BA0
        public void .ctor(){} // RVA: 0x7FFAC4804DB0
    }

    public class CinemachineEmbeddedAssetPropertyAttribute : PropertyAttribute
    {
        public bool WarnIfNull; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2FEB5F0
    }

    public class CinemachineExtension : MonoBehaviour
    {
        public float VirtualCamera;
        public Cinemachine.CinemachineVirtualCameraBase RequiresUserInput; // 0x20
        public System.Collections.Generic.Dictionary`2<Cinemachine.ICinemachineCamera,object> mExtraState; // 0x28

        // ── Methods ──
        public void get_VirtualCamera(){} // RVA: 0x7FFAC4843A80
        public void Awake(){} // RVA: 0x7FFAC4843BC0
        public void OnEnable(){} // RVA: 0x7FFAC2F21310
        public void OnDestroy(){} // RVA: 0x7FFAC4843BE0
        public void EnsureStarted(){} // RVA: 0x7FFAC4843BC0
        public void ConnectToVcam(){} // RVA: 0x7FFAC4843C00
        public void PrePipelineMutateCameraStateCallback(){} // RVA: 0x7FFAC2F21310
        public void InvokePostPipelineStageCallback(){} // RVA: 0x7FFAC4843E80
        public void PostPipelineStageCallback(){}
        public void OnTargetObjectWarped(){} // RVA: 0x7FFAC2F21310
        public void ForceCameraPosition(){} // RVA: 0x7FFAC2F21310
        public void OnTransitionFromCamera(){} // RVA: 0x7FFAC2F21320
        public void GetMaxDampTime(){} // RVA: 0x7FFAC37432E0
        public void get_RequiresUserInput(){} // RVA: 0x7FFAC2F21320
        public void GetExtraState(){} // RVA: 0x7FFAC2E8DC40
        public void GetAllExtraStates(){} // RVA: 0x7FFAC2C58E90
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class CinemachineExternalCamera : CinemachineVirtualCameraBase
    {
        public UnityEngine.Transform State; // 0xA8
        public UnityEngine.Camera LookAt; // 0xB0
        public Cinemachine.CameraState Follow; // 0xB8
        public UnityEngine.Transform <Follow>k__BackingField; // 0x1A0
        public 0x6B22AE40 m_BlendHint; // 0x1A8

        // ── Methods ──
        public void get_State(){} // RVA: 0x7FFAC4804E00
        public void get_LookAt(){} // RVA: 0x7FFAC354B1A0
        public void set_LookAt(){} // RVA: 0x7FFAC334B370
        public void get_Follow(){} // RVA: 0x7FFAC354E2E0
        public void set_Follow(){} // RVA: 0x7FFAC39A8AF0
        public void InternalUpdateCameraState(){} // RVA: 0x7FFAC4804EA0
        public void .ctor(){} // RVA: 0x7FFAC4805AC0
    }

    public class CinemachineFixedSignal : SignalSourceAsset
    {
        public UnityEngine.AnimationCurve SignalDuration; // 0x18
        public UnityEngine.AnimationCurve m_YCurve; // 0x20
        public UnityEngine.AnimationCurve m_ZCurve; // 0x28

        // ── Methods ──
        public void get_SignalDuration(){} // RVA: 0x7FFAC4855E10
        public void AxisDuration(){} // RVA: 0x7FFAC4855E70
        public void GetSignal(){} // RVA: 0x7FFAC4855F70
        public void AxisValue(){} // RVA: 0x7FFAC4856150
        public void .ctor(){} // RVA: 0x7FFAC312F5F0
    }

    public class CinemachineFollowZoom : CinemachineExtension
    {
        public float m_Width; // 0x30
        public float m_Damping; // 0x34
        public float m_MinFOV; // 0x38
        public float m_MaxFOV; // 0x3C

        // ── Methods ──
        public void OnValidate(){} // RVA: 0x7FFAC4805C90
        public void GetMaxDampTime(){} // RVA: 0x7FFAC2FEB630
        public void PostPipelineStageCallback(){} // RVA: 0x7FFAC4805CF0
        public void .ctor(){} // RVA: 0x7FFAC48060E0
    }

    public class CinemachineFramingTransposer : CinemachineComponentBase
    {
        public UnityEngine.Vector3 SoftGuideRect; // 0x28
        public float HardGuideRect; // 0x34
        public float IsValid; // 0x38
        public bool Stage; // 0x3C
        public float BodyAppliesAfterAim; // 0x40
        public float TrackedPoint; // 0x44
        public float LastBounds; // 0x48
        public bool LastBoundsMatrix; // 0x4C
        public float m_ScreenX; // 0x50
        public float m_ScreenY; // 0x54
        public float m_CameraDistance; // 0x58
        public float m_DeadZoneWidth; // 0x5C
        public float m_DeadZoneHeight; // 0x60
        public float m_DeadZoneDepth; // 0x64
        public bool m_UnlimitedSoftZone; // 0x68
        public float m_SoftZoneWidth; // 0x6C
        public float m_SoftZoneHeight; // 0x70
        public float m_BiasX; // 0x74
        public float m_BiasY; // 0x78
        public bool m_CenterOnActivate; // 0x7C
        public 0x6B229840 m_GroupFramingMode; // 0x80
        public 0x6B229898 m_AdjustmentMode; // 0x84
        public float m_GroupFramingSize; // 0x88
        public float m_MaxDollyIn; // 0x8C
        public float m_MaxDollyOut; // 0x90
        public float m_MinimumDistance; // 0x94
        public float m_MaximumDistance; // 0x98
        public float m_MinimumFOV; // 0x9C
        public float m_MaximumFOV; // 0xA0
        public float m_MinimumOrthoSize; // 0xA4
        public float m_MaximumOrthoSize; // 0xA8
        public float kMinimumCameraDistance;
        public float kMinimumGroupSize;
        public UnityEngine.Vector3 m_PreviousCameraPosition; // 0xAC
        public Cinemachine.Utility.PositionPredictor m_Predictor; // 0xB8
        public UnityEngine.Vector3 <TrackedPoint>k__BackingField; // 0xC0
        public bool m_InheritingPosition; // 0xCC
        public float m_prevFOV; // 0xD0
        public UnityEngine.Quaternion m_prevRotation; // 0xD4
        public UnityEngine.Bounds <LastBounds>k__BackingField; // 0xE4
        public UnityEngine.Matrix4x4 <LastBoundsMatrix>k__BackingField; // 0xFC

        // ── Methods ──
        public void get_SoftGuideRect(){} // RVA: 0x7FFAC48259F0
        public void set_SoftGuideRect(){} // RVA: 0x7FFAC4825A40
        public void get_HardGuideRect(){} // RVA: 0x7FFAC4825B00
        public void set_HardGuideRect(){} // RVA: 0x7FFAC4825B80
        public void OnValidate(){} // RVA: 0x7FFAC4825BF0
        public void get_IsValid(){} // RVA: 0x7FFAC4825CE0
        public void get_Stage(){} // RVA: 0x7FFAC34F9180
        public void get_BodyAppliesAfterAim(){} // RVA: 0x7FFAC3006850
        public void get_TrackedPoint(){} // RVA: 0x7FFAC4825E00
        public void set_TrackedPoint(){} // RVA: 0x7FFAC4825E20
        public void OnTargetObjectWarped(){} // RVA: 0x7FFAC4825E40
        public void ForceCameraPosition(){} // RVA: 0x7FFAC4826000
        public void GetMaxDampTime(){} // RVA: 0x7FFAC4826030
        public void OnTransitionFromCamera(){} // RVA: 0x7FFAC4826050
        public void ScreenToOrtho(){} // RVA: 0x7FFAC4826280
        public void OrthoOffsetToScreenBounds(){} // RVA: 0x7FFAC4826350
        public void get_LastBounds(){} // RVA: 0x7FFAC4826460
        public void set_LastBounds(){} // RVA: 0x7FFAC4826480
        public void get_LastBoundsMatrix(){} // RVA: 0x7FFAC48264A0
        public void set_LastBoundsMatrix(){} // RVA: 0x7FFAC48264D0
        public void MutateCameraState(){} // RVA: 0x7FFAC4826500
        public void GetTargetHeight(){} // RVA: 0x7FFAC48280B0
        public void ComputeGroupBounds(){} // RVA: 0x7FFAC48282B0
        public void GetScreenSpaceGroupBoundingBox(){} // RVA: 0x7FFAC4828AE0
        public void .ctor(){} // RVA: 0x7FFAC48292F0
    }

    public class CinemachineFreeLook : CinemachineVirtualCameraBase
    {
        public UnityEngine.Transform RigsAreCreated; // 0xA8
        public UnityEngine.Transform RigNames; // 0xB0
        public bool PreviousStateIsValid; // 0xB8
        public Cinemachine.LensSettings State; // 0xBC
        public TransitionParams LookAt; // 0xF0
        public 0x6B22AE40 Follow; // 0x100
        public Cinemachine.AxisState m_YAxis; // 0x108
        public Recentering m_YAxisRecentering; // 0x178
        public Cinemachine.AxisState m_XAxis; // 0x198
        public Heading m_Heading; // 0x208
        public Recentering m_RecenterToTargetHeading; // 0x214
        public 0x6B229EC8 m_BindingMode; // 0x234
        public float m_SplineCurvature; // 0x238
        public Orbit[] m_Orbits; // 0x240
        public float m_LegacyHeadingBias; // 0x248
        public bool mUseLegacyRigDefinitions; // 0x24C
        public bool mIsDestroyed; // 0x24D
        public Cinemachine.CameraState m_State; // 0x250
        public Cinemachine.CinemachineVirtualCamera[] m_Rigs; // 0x338
        public Cinemachine.CinemachineOrbitalTransposer[] mOrbitals; // 0x340
        public Cinemachine.CinemachineBlend mBlendA; // 0x348
        public Cinemachine.CinemachineBlend mBlendB; // 0x350
        public CreateRigDelegate CreateRigOverride;
        public DestroyRigDelegate DestroyRigOverride; // 0x8
        public float m_CachedXAxisHeading; // 0x358
        public float m_LastHeadingUpdateFrame; // 0x35C
        public Orbit[] m_CachedOrbits; // 0x360
        public float m_CachedTension; // 0x368
        public UnityEngine.Vector4[] m_CachedKnots; // 0x370
        public UnityEngine.Vector4[] m_CachedCtrl1; // 0x378
        public UnityEngine.Vector4[] m_CachedCtrl2; // 0x380

        // ── Methods ──
        public void OnValidate(){} // RVA: 0x7FFAC4806140
        public void GetRig(){} // RVA: 0x7FFAC4806430
        public void get_RigsAreCreated(){} // RVA: 0x7FFAC4806490
        public void get_RigNames(){} // RVA: 0x7FFAC48064B0
        public void OnEnable(){} // RVA: 0x7FFAC4806570
        public void UpdateInputAxisProvider(){} // RVA: 0x7FFAC4806790
        public void OnDestroy(){} // RVA: 0x7FFAC4806950
        public void OnTransformChildrenChanged(){} // RVA: 0x7FFAC4806B60
        public void Reset(){} // RVA: 0x7FFAC4806BC0
        public void get_PreviousStateIsValid(){} // RVA: 0x7FFAC313F600
        public void set_PreviousStateIsValid(){} // RVA: 0x7FFAC4806BE0
        public void get_State(){} // RVA: 0x7FFAC4806D60
        public void get_LookAt(){} // RVA: 0x7FFAC47EFAF0
        public void set_LookAt(){} // RVA: 0x7FFAC334B370
        public void get_Follow(){} // RVA: 0x7FFAC47EFB00
        public void set_Follow(){} // RVA: 0x7FFAC2F8C050
        public void IsLiveChild(){} // RVA: 0x7FFAC4806E00
        public void OnTargetObjectWarped(){} // RVA: 0x7FFAC4806F10
        public void ForceCameraPosition(){} // RVA: 0x7FFAC4806FF0
        public void InternalUpdateCameraState(){} // RVA: 0x7FFAC4807310
        public void OnTransitionFromCamera(){} // RVA: 0x7FFAC4807E60
        public void RequiresUserInput(){} // RVA: 0x7FFAC3006850
        public void GetYAxisClosestValue(){} // RVA: 0x7FFAC4808370
        public void SteepestDescent(){} // RVA: 0x7FFAC4808AE0
        public void InvalidateRigCache(){} // RVA: 0x7FFAC4806B60
        public void DestroyRigs(){} // RVA: 0x7FFAC4808D30
        public void CreateRigs(){} // RVA: 0x7FFAC4809480
        public void UpdateRigCache(){} // RVA: 0x7FFAC480A0F0
        public void LocateExistingRigs(){} // RVA: 0x7FFAC480A680
        public void UpdateXAxisHeading(){} // RVA: 0x7FFAC480AD40
        public void PushSettingsToRigs(){} // RVA: 0x7FFAC480B000
        public void GetYAxisValue(){} // RVA: 0x7FFAC480B7A0
        public void CalculateNewState(){} // RVA: 0x7FFAC480B7D0
        public void GetLocalPositionForCameraFromInput(){} // RVA: 0x7FFAC480BA80
        public void UpdateCachedSpline(){} // RVA: 0x7FFAC480BD30
        public void OnBeforeSerialize(){} // RVA: 0x7FFAC480C390
        public void .ctor(){} // RVA: 0x7FFAC480C470
        public void <SteepestDescent>g__AngleFunction|47_0(){} // RVA: 0x7FFAC480CB40
        public void <SteepestDescent>g__SlopeOfAngleFunction|47_1(){} // RVA: 0x7FFAC480CC10
        public void <SteepestDescent>g__InitialGuess|47_2(){} // RVA: 0x7FFAC480CC80
        public void <SteepestDescent>g__ChooseBestAngle|47_3(){} // RVA: 0x7FFAC480CD90
    }

    public class CinemachineGroupComposer : CinemachineComposer
    {
        public float LastBounds; // 0x100
        public 0x6B229948 LastBoundsMatrix; // 0x104
        public float m_FrameDamping; // 0x108
        public 0x6B2299A0 m_AdjustmentMode; // 0x10C
        public float m_MaxDollyIn; // 0x110
        public float m_MaxDollyOut; // 0x114
        public float m_MinimumDistance; // 0x118
        public float m_MaximumDistance; // 0x11C
        public float m_MinimumFOV; // 0x120
        public float m_MaximumFOV; // 0x124
        public float m_MinimumOrthoSize; // 0x128
        public float m_MaximumOrthoSize; // 0x12C
        public float m_prevFramingDistance; // 0x130
        public float m_prevFOV; // 0x134
        public UnityEngine.Bounds <LastBounds>k__BackingField; // 0x138
        public UnityEngine.Matrix4x4 <LastBoundsMatrix>k__BackingField; // 0x150

        // ── Methods ──
        public void OnValidate(){} // RVA: 0x7FFAC48294A0
        public void get_LastBounds(){} // RVA: 0x7FFAC4829570
        public void set_LastBounds(){} // RVA: 0x7FFAC4829590
        public void get_LastBoundsMatrix(){} // RVA: 0x7FFAC48295B0
        public void set_LastBoundsMatrix(){} // RVA: 0x7FFAC48295E0
        public void GetMaxDampTime(){} // RVA: 0x7FFAC4829610
        public void MutateCameraState(){} // RVA: 0x7FFAC4829630
        public void GetTargetHeight(){} // RVA: 0x7FFAC482A7A0
        public void GetScreenSpaceGroupBoundingBox(){} // RVA: 0x7FFAC482A9E0
        public void .ctor(){} // RVA: 0x7FFAC482AF70
    }

    public class CinemachineHardLockToTarget : CinemachineComponentBase
    {
        public float IsValid; // 0x28
        public UnityEngine.Vector3 Stage; // 0x2C

        // ── Methods ──
        public void get_IsValid(){} // RVA: 0x7FFAC482AFF0
        public void get_Stage(){} // RVA: 0x7FFAC34F9180
        public void GetMaxDampTime(){} // RVA: 0x7FFAC3000210
        public void MutateCameraState(){} // RVA: 0x7FFAC482B110
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class CinemachineHardLookAt : CinemachineComponentBase
    {
        public object IsValid;
        public object Stage;

        // ── Methods ──
        public void get_IsValid(){} // RVA: 0x7FFAC482B2E0
        public void get_Stage(){} // RVA: 0x7FFAC3013AF0
        public void MutateCameraState(){} // RVA: 0x7FFAC482B400
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class CinemachineImpulseChannelPropertyAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class CinemachineImpulseDefinition : Object
    {
        public int ImpulseCurve; // 0x10
        public 0x6B22BC58 m_ImpulseShape; // 0x14
        public UnityEngine.AnimationCurve m_CustomImpulseShape; // 0x18
        public float m_ImpulseDuration; // 0x20
        public 0x6B22BCB0 m_ImpulseType; // 0x24
        public float m_DissipationRate; // 0x28
        public Cinemachine.SignalSourceAsset m_RawSignal; // 0x30
        public float m_AmplitudeGain; // 0x38
        public float m_FrequencyGain; // 0x3C
        public 0x6B22BD08 m_RepeatMode; // 0x40
        public bool m_Randomize; // 0x44
        public EnvelopeDefinition m_TimeEnvelope; // 0x48
        public float m_ImpactRadius; // 0x68
        public 0x6B22C020 m_DirectionMode; // 0x6C
        public 0x6B22C078 m_DissipationMode; // 0x70
        public float m_DissipationDistance; // 0x74
        public float m_PropagationSpeed; // 0x78
        public UnityEngine.AnimationCurve[] sStandardShapes;

        // ── Methods ──
        public void OnValidate(){} // RVA: 0x7FFAC48561D0
        public void CreateStandardShapes(){} // RVA: 0x7FFAC48562C0
        public void GetStandardCurve(){} // RVA: 0x7FFAC4856EC0
        public void get_ImpulseCurve(){} // RVA: 0x7FFAC4856F40
        public void CreateEvent(){} // RVA: 0x7FFAC4857050
        public void CreateAndReturnEvent(){} // RVA: 0x7FFAC4857090
        public void LegacyCreateAndReturnEvent(){} // RVA: 0x7FFAC48572E0
        public void .ctor(){} // RVA: 0x7FFAC48576D0
    }

    public class CinemachineImpulseDefinitionPropertyAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class CinemachineImpulseEnvelopePropertyAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class CinemachineImpulseListener : CinemachineExtension
    {
        public 0x6B22A550 m_ApplyAfter; // 0x30
        public int m_ChannelMask; // 0x34
        public float m_Gain; // 0x38
        public bool m_Use2DDistance; // 0x3C
        public bool m_UseCameraSpace; // 0x3D
        public ImpulseReaction m_ReactionSettings; // 0x40

        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAC48580E0
        public void PostPipelineStageCallback(){} // RVA: 0x7FFAC48581A0
        public void .ctor(){} // RVA: 0x7FFAC4858780
    }

    public class CinemachineImpulseManager : Object
    {
        public Cinemachine.CinemachineImpulseManager Instance;
        public float CurrentTime;
        public System.Collections.Generic.List`1<ImpulseEvent> m_ExpiredEvents; // 0x10
        public System.Collections.Generic.List`1<ImpulseEvent> m_ActiveEvents; // 0x18
        public bool IgnoreTimeScale; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_Instance(){} // RVA: 0x7FFAC4858E90
        public void InitializeModule(){} // RVA: 0x7FFAC4858F50
        public void EvaluateDissipationScale(){} // RVA: 0x7FFAC4859080
        public void GetImpulseAt(){} // RVA: 0x7FFAC4859180
        public void get_CurrentTime(){} // RVA: 0x7FFAC4859690
        public void NewImpulseEvent(){} // RVA: 0x7FFAC4859730
        public void AddImpulseEvent(){} // RVA: 0x7FFAC4859830
        public void Clear(){} // RVA: 0x7FFAC4859930
    }

    public class CinemachineImpulseSource : MonoBehaviour
    {
        public Cinemachine.CinemachineImpulseDefinition m_ImpulseDefinition; // 0x20
        public UnityEngine.Vector3 m_DefaultVelocity; // 0x28

        // ── Methods ──
        public void OnValidate(){} // RVA: 0x7FFAC485A7D0
        public void Reset(){} // RVA: 0x7FFAC485A8E0
        public void GenerateImpulseAtPositionWithVelocity(){} // RVA: 0x7FFAC485AAD0
        public void GenerateImpulseWithVelocity(){} // RVA: 0x7FFAC485AB20
        public void GenerateImpulseWithForce(){} // RVA: 0x7FFAC485AC40
        public void GenerateImpulse(){} // RVA: 0x7FFAC485AC40 | overloaded x3
        public void GenerateImpulseAt(){} // RVA: 0x7FFAC485AAD0
        public void .ctor(){} // RVA: 0x7FFAC485ADE0
    }

    public class CinemachineIndependentImpulseListener : MonoBehaviour
    {
        public UnityEngine.Vector3 impulsePosLastFrame; // 0x20
        public UnityEngine.Quaternion impulseRotLastFrame; // 0x2C
        public int m_ChannelMask; // 0x3C
        public float m_Gain; // 0x40
        public bool m_Use2DDistance; // 0x44
        public bool m_UseLocalSpace; // 0x45
        public ImpulseReaction m_ReactionSettings; // 0x48

        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAC485AF00
        public void OnEnable(){} // RVA: 0x7FFAC485AFB0
        public void Update(){} // RVA: 0x7FFAC485B040
        public void LateUpdate(){} // RVA: 0x7FFAC485B4B0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class CinemachineInputAxisDriver : ValueType
    {
        public float multiplier; // 0x10
        public float accelTime; // 0x14
        public float decelTime; // 0x18
        public string name; // 0x20
        public float inputValue; // 0x28
        public float mCurrentSpeed; // 0x2C
        public float Epsilon;

        // ── Methods ──
        public void Validate(){} // RVA: 0x7FFAC4837460
        public void Update(){} // RVA: 0x7FFAC4844230 | overloaded x2
        public void ClampValue(){} // RVA: 0x7FFAC48442A0
    }

    public class CinemachineInputProvider : MonoBehaviour
    {
        public int PlayerIndex; // 0x20
        public bool AutoEnableInputs; // 0x24
        public UnityEngine.InputSystem.InputActionReference XYAxis; // 0x28
        public UnityEngine.InputSystem.InputActionReference ZAxis; // 0x30
        public int NUM_AXES;
        public UnityEngine.InputSystem.InputAction[] m_cachedActions; // 0x38

        // ── Methods ──
        public void GetAxisValue(){} // RVA: 0x7FFAC48522E0
        public void ResolveForPlayer(){} // RVA: 0x7FFAC4852400
        public void OnDisable(){} // RVA: 0x7FFAC3BB6540
        public void .ctor(){} // RVA: 0x7FFAC4852B60
        public void <ResolveForPlayer>g__GetFirstMatch|7_0(){} // RVA: 0x7FFAC4852BB0
    }

    public class CinemachineMixingCamera : CinemachineVirtualCameraBase
    {
        public int LiveChild;
        public float State; // 0xA8
        public float LookAt; // 0xAC
        public float Follow; // 0xB0
        public float ChildCameras; // 0xB4
        public float m_Weight4; // 0xB8
        public float m_Weight5; // 0xBC
        public float m_Weight6; // 0xC0
        public float m_Weight7; // 0xC4
        public Cinemachine.CameraState m_State; // 0xC8
        public Cinemachine.ICinemachineCamera <LiveChild>k__BackingField; // 0x1B0
        public UnityEngine.Transform <LookAt>k__BackingField; // 0x1B8
        public UnityEngine.Transform <Follow>k__BackingField; // 0x1C0
        public Cinemachine.CinemachineVirtualCameraBase[] m_ChildCameras; // 0x1C8
        public System.Collections.Generic.Dictionary`2<Cinemachine.CinemachineVirtualCameraBase,int> m_indexMap; // 0x1D0

        // ── Methods ──
        public void GetWeight(){} // RVA: 0x7FFAC480D260 | overloaded x2
        public void SetWeight(){} // RVA: 0x7FFAC480D5A0 | overloaded x2
        public void get_LiveChild(){} // RVA: 0x7FFAC3549F30
        public void set_LiveChild(){} // RVA: 0x7FFAC39A7790
        public void get_State(){} // RVA: 0x7FFAC480D870
        public void get_LookAt(){} // RVA: 0x7FFAC3544330
        public void set_LookAt(){} // RVA: 0x7FFAC39AC050
        public void get_Follow(){} // RVA: 0x7FFAC35422B0
        public void set_Follow(){} // RVA: 0x7FFAC39AD110
        public void OnTargetObjectWarped(){} // RVA: 0x7FFAC480D910
        public void ForceCameraPosition(){} // RVA: 0x7FFAC480D9F0
        public void OnEnable(){} // RVA: 0x7FFAC480DB80
        public void OnTransformChildrenChanged(){} // RVA: 0x7FFAC480DBA0
        public void OnValidate(){} // RVA: 0x7FFAC480DBB0
        public void IsLiveChild(){} // RVA: 0x7FFAC480DC60
        public void get_ChildCameras(){} // RVA: 0x7FFAC480DD00
        public void InvalidateListOfChildren(){} // RVA: 0x7FFAC480DD20
        public void ValidateListOfChildren(){} // RVA: 0x7FFAC480DE40
        public void OnTransitionFromCamera(){} // RVA: 0x7FFAC480E2E0
        public void InternalUpdateCameraState(){} // RVA: 0x7FFAC480E440
        public void .ctor(){} // RVA: 0x7FFAC480EB40
    }

    public class CinemachineOrbitalTransposer : CinemachineTransposer
    {
        public Heading RequiresUserInput; // 0xA0
        public Recentering m_RecenterToTargetHeading; // 0xAC
        public Cinemachine.AxisState m_XAxis; // 0xD0
        public float m_LegacyRadius; // 0x140
        public float m_LegacyHeightOffset; // 0x144
        public float m_LegacyHeadingBias; // 0x148
        public bool m_HeadingIsSlave; // 0x14C
        public UpdateHeadingDelegate HeadingUpdater; // 0x150
        public UnityEngine.Vector3 m_LastTargetPosition; // 0x158
        public Cinemachine.Utility.HeadingTracker mHeadingTracker; // 0x168
        public UnityEngine.Rigidbody m_TargetRigidBody; // 0x170
        public UnityEngine.Transform m_PreviousTarget; // 0x178
        public UnityEngine.Vector3 m_LastCameraPosition; // 0x180
        public float m_LastHeading; // 0x18C

        // ── Methods ──
        public void OnValidate(){} // RVA: 0x7FFAC482B7C0
        public void UpdateHeading(){} // RVA: 0x7FFAC482B9F0 | overloaded x2
        public void OnEnable(){} // RVA: 0x7FFAC482BB90
        public void UpdateInputAxisProvider(){} // RVA: 0x7FFAC482BDB0
        public void OnTargetObjectWarped(){} // RVA: 0x7FFAC482BF20
        public void ForceCameraPosition(){} // RVA: 0x7FFAC482C220
        public void OnTransitionFromCamera(){} // RVA: 0x7FFAC482C380
        public void GetAxisClosestValue(){} // RVA: 0x7FFAC482C5C0
        public void MutateCameraState(){} // RVA: 0x7FFAC482CD30
        public void GetTargetCameraPosition(){} // RVA: 0x7FFAC482DCD0
        public void get_RequiresUserInput(){} // RVA: 0x7FFAC3006850
        public void GetTargetHeading(){} // RVA: 0x7FFAC482E120
        public void .ctor(){} // RVA: 0x7FFAC482EA90
    }

    public class CinemachinePOV : CinemachineComponentBase
    {
        public 0x6B229CB8 IsValid; // 0x28
        public Cinemachine.AxisState Stage; // 0x30
        public Recentering RequiresUserInput; // 0xA0
        public Cinemachine.AxisState m_HorizontalAxis; // 0xC0
        public Recentering m_HorizontalRecentering; // 0x130
        public bool m_ApplyBeforeBody; // 0x150
        public UnityEngine.Quaternion m_PreviousCameraRotation; // 0x154

        // ── Methods ──
        public void get_IsValid(){} // RVA: 0x7FFAC2F87DE0
        public void get_Stage(){} // RVA: 0x7FFAC3013AF0
        public void OnValidate(){} // RVA: 0x7FFAC482F280
        public void OnEnable(){} // RVA: 0x7FFAC482F390
        public void UpdateInputAxisProvider(){} // RVA: 0x7FFAC482F3A0
        public void PrePipelineMutateCameraState(){} // RVA: 0x7FFAC2F21310
        public void MutateCameraState(){} // RVA: 0x7FFAC482F670
        public void GetRecenterTarget(){} // RVA: 0x7FFAC482FE30
        public void NormalizeAngle(){} // RVA: 0x7FFAC48302E0
        public void ForceCameraPosition(){} // RVA: 0x7FFAC4830310
        public void OnTransitionFromCamera(){} // RVA: 0x7FFAC4830330
        public void get_RequiresUserInput(){} // RVA: 0x7FFAC3006850
        public void SetAxesForRotation(){} // RVA: 0x7FFAC48305A0
        public void .ctor(){} // RVA: 0x7FFAC4831090
    }

    public class CinemachinePath : CinemachinePathBase
    {
        public bool MinPos; // 0x50
        public Waypoint[] MaxPos; // 0x58

        // ── Methods ──
        public void get_MinPos(){} // RVA: 0x7FFAC37432E0
        public void get_MaxPos(){} // RVA: 0x7FFAC480ED60
        public void get_Looped(){} // RVA: 0x7FFAC2FDB8E0
        public void Reset(){} // RVA: 0x7FFAC480EDA0
        public void OnValidate(){} // RVA: 0x7FFAC3708F70
        public void get_DistanceCacheSampleStepsPerSegment(){} // RVA: 0x7FFAC30DBBE0
        public void GetBoundingIndices(){} // RVA: 0x7FFAC480EF60
        public void EvaluateLocalPosition(){} // RVA: 0x7FFAC480F050
        public void EvaluateLocalTangent(){} // RVA: 0x7FFAC480F3A0
        public void EvaluateLocalOrientation(){} // RVA: 0x7FFAC480F600
        public void GetRoll(){} // RVA: 0x7FFAC480FA20
        public void RollAroundForward(){} // RVA: 0x7FFAC480FB50
        public void .ctor(){} // RVA: 0x7FFAC480FBA0
    }

    public class CinemachinePathBase : MonoBehaviour
    {
        public int MinPos; // 0x20
        public Appearance MaxPos; // 0x28
        public float[] Looped; // 0x30
        public float[] DistanceCacheSampleStepsPerSegment; // 0x38
        public int PathLength; // 0x40
        public float m_PathLength; // 0x44
        public float m_cachedPosStepSize; // 0x48
        public float m_cachedDistanceStepSize; // 0x4C

        // ── Methods ──
        public void get_MinPos(){} // RVA: 0x7FFAC2C6D880
        public void get_MaxPos(){} // RVA: 0x7FFAC2C6D880
        public void get_Looped(){} // RVA: 0x7FFAC2C59D00
        public void StandardizePos(){} // RVA: 0x7FFAC4844310
        public void EvaluatePosition(){} // RVA: 0x7FFAC4844400
        public void EvaluateTangent(){} // RVA: 0x7FFAC4844520
        public void EvaluateOrientation(){} // RVA: 0x7FFAC4844640
        public void EvaluateLocalPosition(){}
        public void EvaluateLocalTangent(){}
        public void EvaluateLocalOrientation(){}
        public void FindClosestPoint(){} // RVA: 0x7FFAC48448B0
        public void MinUnit(){} // RVA: 0x7FFAC4844D00
        public void MaxUnit(){} // RVA: 0x7FFAC4844D30
        public void StandardizeUnit(){} // RVA: 0x7FFAC4844D60
        public void EvaluatePositionAtUnit(){} // RVA: 0x7FFAC4844E10
        public void EvaluateTangentAtUnit(){} // RVA: 0x7FFAC4844E70
        public void EvaluateOrientationAtUnit(){} // RVA: 0x7FFAC4844ED0
        public void get_DistanceCacheSampleStepsPerSegment(){} // RVA: 0x7FFAC2C59960
        public void InvalidateDistanceCache(){} // RVA: 0x7FFAC4844F30
        public void DistanceCacheIsValid(){} // RVA: 0x7FFAC4844FE0
        public void get_PathLength(){} // RVA: 0x7FFAC4845080
        public void StandardizePathDistance(){} // RVA: 0x7FFAC48450F0
        public void ToNativePathUnits(){} // RVA: 0x7FFAC48451B0
        public void FromPathNativeUnits(){} // RVA: 0x7FFAC4845330
        public void ResamplePath(){} // RVA: 0x7FFAC4845450
        public void .ctor(){} // RVA: 0x7FFAC4845900
    }

    public class CinemachinePipeline : MonoBehaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class CinemachinePixelPerfect : MonoBehaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class CinemachineSameAsFollowTarget : CinemachineComponentBase
    {
        public float IsValid; // 0x28
        public UnityEngine.Quaternion Stage; // 0x2C

        // ── Methods ──
        public void get_IsValid(){} // RVA: 0x7FFAC48313F0
        public void get_Stage(){} // RVA: 0x7FFAC3013AF0
        public void GetMaxDampTime(){} // RVA: 0x7FFAC3000210
        public void MutateCameraState(){} // RVA: 0x7FFAC4831510
        public void .ctor(){} // RVA: 0x7FFAC4831850
    }

    public class CinemachineSmoothPath : CinemachinePathBase
    {
        public bool MinPos; // 0x50
        public Waypoint[] MaxPos; // 0x58
        public Waypoint[] Looped; // 0x60
        public Waypoint[] DistanceCacheSampleStepsPerSegment; // 0x68
        public bool m_IsLoopedCache; // 0x70

        // ── Methods ──
        public void get_MinPos(){} // RVA: 0x7FFAC37432E0
        public void get_MaxPos(){} // RVA: 0x7FFAC480ED60
        public void get_Looped(){} // RVA: 0x7FFAC2FDB8E0
        public void get_DistanceCacheSampleStepsPerSegment(){} // RVA: 0x7FFAC30DBBE0
        public void OnValidate(){} // RVA: 0x7FFAC3708F70
        public void Reset(){} // RVA: 0x7FFAC480FD40
        public void InvalidateDistanceCache(){} // RVA: 0x7FFAC480FEF0
        public void UpdateControlPoints(){} // RVA: 0x7FFAC4810040
        public void GetBoundingIndices(){} // RVA: 0x7FFAC48103B0
        public void EvaluateLocalPosition(){} // RVA: 0x7FFAC4810490
        public void EvaluateLocalTangent(){} // RVA: 0x7FFAC4810820
        public void EvaluateLocalOrientation(){} // RVA: 0x7FFAC4810AF0
        public void RollAroundForward(){} // RVA: 0x7FFAC480FB50
        public void .ctor(){} // RVA: 0x7FFAC4811000
    }

    public class CinemachineStateDrivenCamera : CinemachineVirtualCameraBase
    {
        public UnityEngine.Transform Description; // 0xA8
        public UnityEngine.Transform LiveChild; // 0xB0
        public UnityEngine.Animator State; // 0xB8
        public int LookAt; // 0xC0
        public bool Follow; // 0xC4
        public Cinemachine.CinemachineVirtualCameraBase[] ChildCameras; // 0xC8
        public Instruction[] IsBlending; // 0xD0
        public Cinemachine.CinemachineBlendDefinition ActiveBlend; // 0xD8
        public Cinemachine.CinemachineBlenderSettings m_CustomBlends; // 0xE8
        public ParentHash[] m_ParentHash; // 0xF0
        public Cinemachine.ICinemachineCamera <LiveChild>k__BackingField; // 0xF8
        public Cinemachine.ICinemachineCamera m_TransitioningFrom; // 0x100
        public Cinemachine.CameraState m_State; // 0x108
        public System.Collections.Generic.Dictionary`2<UnityEngine.AnimationClip,System.Collections.Generic.List`1<HashPair>> mHashCache; // 0x1F0
        public float mActivationTime; // 0x1F8
        public Instruction mActiveInstruction; // 0x200
        public float mPendingActivationTime; // 0x218
        public Instruction mPendingInstruction; // 0x220
        public Cinemachine.CinemachineBlend mActiveBlend; // 0x238
        public System.Collections.Generic.Dictionary`2<int,int> mInstructionDictionary; // 0x240
        public System.Collections.Generic.Dictionary`2<int,int> mStateParentLookup; // 0x248
        public System.Collections.Generic.List`1<UnityEngine.AnimatorClipInfo> m_clipInfoList; // 0x250

        // ── Methods ──
        public void get_Description(){} // RVA: 0x7FFAC4811130
        public void get_LiveChild(){} // RVA: 0x7FFAC3331F50
        public void set_LiveChild(){} // RVA: 0x7FFAC34A4860
        public void IsLiveChild(){} // RVA: 0x7FFAC4811270
        public void get_State(){} // RVA: 0x7FFAC48112A0
        public void get_LookAt(){} // RVA: 0x7FFAC47EFAF0
        public void set_LookAt(){} // RVA: 0x7FFAC334B370
        public void get_Follow(){} // RVA: 0x7FFAC47EFB00
        public void set_Follow(){} // RVA: 0x7FFAC2F8C050
        public void OnTargetObjectWarped(){} // RVA: 0x7FFAC4811340
        public void ForceCameraPosition(){} // RVA: 0x7FFAC4811420
        public void OnTransitionFromCamera(){} // RVA: 0x7FFAC48115B0
        public void InternalUpdateCameraState(){} // RVA: 0x7FFAC48116C0
        public void OnEnable(){} // RVA: 0x7FFAC4811FB0
        public void OnDisable(){} // RVA: 0x7FFAC48122C0
        public void OnTransformChildrenChanged(){} // RVA: 0x7FFAC4812440
        public void OnGuiHandler(){} // RVA: 0x7FFAC4812450
        public void get_ChildCameras(){} // RVA: 0x7FFAC48125C0
        public void get_IsBlending(){} // RVA: 0x7FFAC48125E0
        public void get_ActiveBlend(){} // RVA: 0x7FFAC35413D0
        public void CreateFakeHash(){} // RVA: 0x7FFAC48125F0
        public void LookupFakeHash(){} // RVA: 0x7FFAC48126B0
        public void InvalidateListOfChildren(){} // RVA: 0x7FFAC4812A60
        public void UpdateListOfChildren(){} // RVA: 0x7FFAC4812B20
        public void ValidateInstructions(){} // RVA: 0x7FFAC4812EC0
        public void ChooseCurrentCamera(){} // RVA: 0x7FFAC4813500
        public void GetClipHash(){} // RVA: 0x7FFAC4813DA0
        public void LookupBlend(){} // RVA: 0x7FFAC4813F30
        public void .ctor(){} // RVA: 0x7FFAC48141A0
    }

    public class CinemachineStoryboard : CinemachineExtension
    {
        public bool CanvasName;
        public bool m_ShowImage; // 0x30
        public UnityEngine.Texture m_Image; // 0x38
        public 0x6B229210 m_Aspect; // 0x40
        public float m_Alpha; // 0x44
        public UnityEngine.Vector2 m_Center; // 0x48
        public UnityEngine.Vector3 m_Rotation; // 0x50
        public UnityEngine.Vector2 m_Scale; // 0x5C
        public bool m_SyncScale; // 0x64
        public bool m_MuteCamera; // 0x65
        public float m_SplitView; // 0x68
        public 0x6B2292C0 m_RenderMode; // 0x6C
        public int m_SortingOrder; // 0x70
        public float m_PlaneDistance; // 0x74
        public System.Collections.Generic.List`1<CanvasInfo> mCanvasInfo; // 0x78

        // ── Methods ──
        public void PostPipelineStageCallback(){} // RVA: 0x7FFAC48144E0
        public void UpdateRenderCanvas(){} // RVA: 0x7FFAC48146F0
        public void ConnectToVcam(){} // RVA: 0x7FFAC4814940
        public void get_CanvasName(){} // RVA: 0x7FFAC4814B10
        public void CameraUpdatedCallback(){} // RVA: 0x7FFAC4814C40
        public void LocateMyCanvas(){} // RVA: 0x7FFAC4814FE0
        public void CreateCanvas(){} // RVA: 0x7FFAC4815900
        public void DestroyCanvas(){} // RVA: 0x7FFAC4816430
        public void PlaceImage(){} // RVA: 0x7FFAC48167B0
        public void StaticBlendingHandler(){} // RVA: 0x7FFAC48173E0
        public void InitializeModule(){} // RVA: 0x7FFAC48177C0
        public void .ctor(){} // RVA: 0x7FFAC4817930
    }

    public class CinemachineTargetGroup : MonoBehaviour
    {
        public 0x6B229420 Transform; // 0x20
        public 0x6B229478 BoundingBox; // 0x24
        public 0x6B2294D0 Sphere; // 0x28
        public Target[] IsEmpty; // 0x30
        public float CachedCountIsValid; // 0x38
        public float m_WeightSum; // 0x3C
        public UnityEngine.Vector3 m_AveragePos; // 0x40
        public UnityEngine.Bounds m_BoundingBox; // 0x4C
        public UnityEngine.BoundingSphere m_BoundingSphere; // 0x64
        public int m_LastUpdateFrame; // 0x74
        public System.Collections.Generic.List`1<int> m_ValidMembers; // 0x78
        public System.Collections.Generic.List`1<bool> m_MemberValidity; // 0x80

        // ── Methods ──
        public void OnValidate(){} // RVA: 0x7FFAC4817B00
        public void Reset(){} // RVA: 0x7FFAC4817BA0
        public void get_Transform(){} // RVA: 0x7FFAC33BCDF0
        public void get_BoundingBox(){} // RVA: 0x7FFAC4817C30
        public void set_BoundingBox(){} // RVA: 0x7FFAC4817CC0
        public void get_Sphere(){} // RVA: 0x7FFAC4817CE0
        public void set_Sphere(){} // RVA: 0x7FFAC3031DC0
        public void get_IsEmpty(){} // RVA: 0x7FFAC4817D60
        public void AddMember(){} // RVA: 0x7FFAC4817E00
        public void RemoveMember(){} // RVA: 0x7FFAC48180E0
        public void FindMember(){} // RVA: 0x7FFAC48183F0
        public void GetWeightedBoundsForMember(){} // RVA: 0x7FFAC4818580
        public void GetViewSpaceBoundingBox(){} // RVA: 0x7FFAC4818760
        public void get_CachedCountIsValid(){} // RVA: 0x7FFAC4818F20
        public void IndexIsValid(){} // RVA: 0x7FFAC4818F90
        public void WeightedMemberBoundsForValidMember(){} // RVA: 0x7FFAC4818FB0
        public void DoUpdate(){} // RVA: 0x7FFAC4819170
        public void UpdateMemberValidity(){} // RVA: 0x7FFAC48194C0
        public void CalculateAveragePosition(){} // RVA: 0x7FFAC4819850
        public void CalculateBoundingBox(){} // RVA: 0x7FFAC4819AE0
        public void CalculateBoundingSphere(){} // RVA: 0x7FFAC481A050
        public void CalculateAverageOrientation(){} // RVA: 0x7FFAC481A450
        public void FixedUpdate(){} // RVA: 0x7FFAC481ABF0
        public void Update(){} // RVA: 0x7FFAC481AC00
        public void LateUpdate(){} // RVA: 0x7FFAC481ACA0
        public void GetViewSpaceAngularBounds(){} // RVA: 0x7FFAC481ACB0
        public void .ctor(){} // RVA: 0x7FFAC481B9F0
    }

    public class CinemachineTrackedDolly : CinemachineComponentBase
    {
        public Cinemachine.CinemachinePathBase IsValid; // 0x28
        public float Stage; // 0x30
        public 0x6B22A918 AngularDamping; // 0x34
        public UnityEngine.Vector3 m_PathOffset; // 0x38
        public float m_XDamping; // 0x44
        public float m_YDamping; // 0x48
        public float m_ZDamping; // 0x4C
        public 0x6B229DC0 m_CameraUp; // 0x50
        public float m_PitchDamping; // 0x54
        public float m_YawDamping; // 0x58
        public float m_RollDamping; // 0x5C
        public AutoDolly m_AutoDolly; // 0x60
        public float m_PreviousPathPosition; // 0x70
        public UnityEngine.Quaternion m_PreviousOrientation; // 0x74
        public UnityEngine.Vector3 m_PreviousCameraPosition; // 0x84

        // ── Methods ──
        public void get_IsValid(){} // RVA: 0x7FFAC48318D0
        public void get_Stage(){} // RVA: 0x7FFAC34F9180
        public void GetMaxDampTime(){} // RVA: 0x7FFAC48319F0
        public void MutateCameraState(){} // RVA: 0x7FFAC4831AA0
        public void GetCameraOrientationAtPathPoint(){} // RVA: 0x7FFAC4832D30
        public void get_AngularDamping(){} // RVA: 0x7FFAC4833410
        public void .ctor(){} // RVA: 0x7FFAC48334C0
    }

    public class CinemachineTransposer : CinemachineComponentBase
    {
        public 0x6B229EC8 HideOffsetInInspector; // 0x28
        public UnityEngine.Vector3 EffectiveOffset; // 0x2C
        public float IsValid; // 0x38
        public float Stage; // 0x3C
        public float Damping; // 0x40
        public 0x6B229F20 AngularDamping; // 0x44
        public float m_PitchDamping; // 0x48
        public float m_YawDamping; // 0x4C
        public float m_RollDamping; // 0x50
        public float m_AngularDamping; // 0x54
        public bool <HideOffsetInInspector>k__BackingField; // 0x58
        public UnityEngine.Vector3 m_PreviousTargetPosition; // 0x5C
        public UnityEngine.Quaternion m_PreviousReferenceOrientation; // 0x68
        public UnityEngine.Quaternion m_targetOrientationOnAssign; // 0x78
        public UnityEngine.Vector3 m_PreviousOffset; // 0x88
        public UnityEngine.Transform m_previousTarget; // 0x98

        // ── Methods ──
        public void OnValidate(){} // RVA: 0x7FFAC4833620
        public void get_HideOffsetInInspector(){} // RVA: 0x7FFAC313F600
        public void set_HideOffsetInInspector(){} // RVA: 0x7FFAC3892770
        public void get_EffectiveOffset(){} // RVA: 0x7FFAC4833670
        public void get_IsValid(){} // RVA: 0x7FFAC48336B0
        public void get_Stage(){} // RVA: 0x7FFAC34F9180
        public void GetMaxDampTime(){} // RVA: 0x7FFAC48337D0
        public void MutateCameraState(){} // RVA: 0x7FFAC4833860
        public void OnTargetObjectWarped(){} // RVA: 0x7FFAC4833F40
        public void ForceCameraPosition(){} // RVA: 0x7FFAC48340B0
        public void InitPrevFrameStateInfo(){} // RVA: 0x7FFAC48343F0
        public void TrackTarget(){} // RVA: 0x7FFAC4834650
        public void GetOffsetForMinimumTargetDistance(){} // RVA: 0x7FFAC48357A0
        public void get_Damping(){} // RVA: 0x7FFAC4835D40
        public void get_AngularDamping(){} // RVA: 0x7FFAC4835D80
        public void GetTargetCameraPosition(){} // RVA: 0x7FFAC4835E60
        public void GetReferenceOrientation(){} // RVA: 0x7FFAC4836160
        public void .ctor(){} // RVA: 0x7FFAC48367E0
    }

    public class CinemachineTriggerAction : MonoBehaviour
    {
        public UnityEngine.LayerMask m_LayerMask; // 0x20
        public string m_WithTag; // 0x28
        public string m_WithoutTag; // 0x30
        public int m_SkipFirst; // 0x38
        public bool m_Repeating; // 0x3C
        public ActionSettings m_OnObjectEnter; // 0x40
        public ActionSettings m_OnObjectExit; // 0x68
        public System.Collections.Generic.HashSet`1<UnityEngine.GameObject> m_ActiveTriggerObjects; // 0x90

        // ── Methods ──
        public void Filter(){} // RVA: 0x7FFAC4853030
        public void InternalDoTriggerEnter(){} // RVA: 0x7FFAC4853150
        public void InternalDoTriggerExit(){} // RVA: 0x7FFAC48532E0
        public void OnTriggerEnter(){} // RVA: 0x7FFAC48533C0
        public void OnTriggerExit(){} // RVA: 0x7FFAC4853440
        public void OnCollisionEnter(){} // RVA: 0x7FFAC48534C0
        public void OnCollisionExit(){} // RVA: 0x7FFAC4853500
        public void OnTriggerEnter2D(){} // RVA: 0x7FFAC48533C0
        public void OnTriggerExit2D(){} // RVA: 0x7FFAC4853440
        public void OnCollisionEnter2D(){} // RVA: 0x7FFAC4853540
        public void OnCollisionExit2D(){} // RVA: 0x7FFAC4853580
        public void OnEnable(){} // RVA: 0x7FFAC2F21310
        public void .ctor(){} // RVA: 0x7FFAC48535C0
    }

    public class CinemachineVirtualCamera : CinemachineVirtualCameraBase
    {
        public UnityEngine.Transform State; // 0xA8
        public UnityEngine.Transform LookAt; // 0xB0
        public Cinemachine.LensSettings Follow; // 0xB8
        public TransitionParams m_Transitions; // 0xF0
        public 0x6B22AE40 m_LegacyBlendHint; // 0x100
        public string PipelineName;
        public CreatePipelineDelegate CreatePipelineOverride;
        public DestroyPipelineDelegate DestroyPipelineOverride; // 0x8
        public Cinemachine.CameraState m_State; // 0x108
        public Cinemachine.CinemachineComponentBase[] m_ComponentPipeline; // 0x1F0
        public UnityEngine.Transform m_ComponentOwner; // 0x1F8
        public UnityEngine.Transform mCachedLookAtTarget; // 0x200
        public Cinemachine.CinemachineVirtualCameraBase mCachedLookAtTargetVcam; // 0x208

        // ── Methods ──
        public void get_State(){} // RVA: 0x7FFAC48112A0
        public void get_LookAt(){} // RVA: 0x7FFAC47EFAF0
        public void set_LookAt(){} // RVA: 0x7FFAC334B370
        public void get_Follow(){} // RVA: 0x7FFAC47EFB00
        public void set_Follow(){} // RVA: 0x7FFAC2F8C050
        public void GetMaxDampTime(){} // RVA: 0x7FFAC481BBF0
        public void InternalUpdateCameraState(){} // RVA: 0x7FFAC481BD60
        public void OnEnable(){} // RVA: 0x7FFAC481C240
        public void OnDestroy(){} // RVA: 0x7FFAC481C8C0
        public void OnValidate(){} // RVA: 0x7FFAC481CC50
        public void OnTransformChildrenChanged(){} // RVA: 0x7FFAC481CD30
        public void Reset(){} // RVA: 0x7FFAC481CD90
        public void DestroyPipeline(){} // RVA: 0x7FFAC481CDB0
        public void CreatePipeline(){} // RVA: 0x7FFAC481D4E0
        public void InvalidateComponentPipeline(){} // RVA: 0x7FFAC481CD30
        public void GetComponentOwner(){} // RVA: 0x7FFAC481D850
        public void GetComponentPipeline(){} // RVA: 0x7FFAC481D870
        public void GetCinemachineComponent(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void AddCinemachineComponent(){} // RVA: 0x7FFAC2E8DC40
        public void DestroyCinemachineComponent(){} // RVA: 0x7FFAC2C70980
        public void UpdateComponentPipeline(){} // RVA: 0x7FFAC481D920
        public void SetFlagsForHiddenChild(){} // RVA: 0x7FFAC481E190
        public void CalculateNewState(){} // RVA: 0x7FFAC481E340
        public void OnTargetObjectWarped(){} // RVA: 0x7FFAC481EE00
        public void ForceCameraPosition(){} // RVA: 0x7FFAC481F190
        public void SetStateRawPosition(){} // RVA: 0x7FFAC481F410
        public void OnTransitionFromCamera(){} // RVA: 0x7FFAC481F430
        public void RequiresUserInput(){} // RVA: 0x7FFAC481F940
        public void OnBeforeSerialize(){} // RVA: 0x7FFAC481FC00
        public void .ctor(){} // RVA: 0x7FFAC481FCE0
    }

    public class CinemachineVirtualCameraBase : MonoBehaviour
    {
        public string[] ValidatingStreamVersion; // 0x20
        public 0x6B22A550[] mExtensions; // 0x28
        public int Name; // 0x30
        public bool Description; // 0x34
        public int Priority; // 0x38
        public int VirtualCameraGameObject; // 0x3C
        public int IsValid; // 0x40
        public float State; // 0x44
        public float ParentCamera; // 0x48
        public 0x6B22ADE8 LookAt; // 0x4C
        public System.Collections.Generic.List`1<Cinemachine.CinemachineExtension> Follow; // 0x50
        public bool PreviousStateIsValid; // 0x58
        public bool FollowTargetChanged; // 0x59
        public bool LookAtTargetChanged; // 0x5A
        public Cinemachine.CinemachineVirtualCameraBase AbstractFollowTargetGroup; // 0x60
        public int FollowTargetAsVcam; // 0x68
        public float AbstractLookAtTargetGroup; // 0x6C
        public UnityEngine.Transform LookAtTargetAsVcam; // 0x70
        public Cinemachine.CinemachineVirtualCameraBase m_CachedFollowTargetVcam; // 0x78
        public Cinemachine.ICinemachineTargetGroup m_CachedFollowTargetGroup; // 0x80
        public UnityEngine.Transform m_CachedLookAtTarget; // 0x88
        public Cinemachine.CinemachineVirtualCameraBase m_CachedLookAtTargetVcam; // 0x90
        public Cinemachine.ICinemachineTargetGroup m_CachedLookAtTargetGroup; // 0x98
        public bool <FollowTargetChanged>k__BackingField; // 0xA0
        public bool <LookAtTargetChanged>k__BackingField; // 0xA1

        // ── Methods ──
        public void get_ValidatingStreamVersion(){} // RVA: 0x7FFAC4845A10
        public void set_ValidatingStreamVersion(){} // RVA: 0x7FFAC2F7CCE0
        public void GetMaxDampTime(){} // RVA: 0x7FFAC4845A80
        public void DetachedFollowTargetDamp(){} // RVA: 0x7FFAC4845D80 | overloaded x3
        public void DetachedLookAtTargetDamp(){} // RVA: 0x7FFAC4846050 | overloaded x3
        public void AddExtension(){} // RVA: 0x7FFAC4846100
        public void RemoveExtension(){} // RVA: 0x7FFAC4846260
        public void get_mExtensions(){} // RVA: 0x7FFAC2FC20E0
        public void set_mExtensions(){} // RVA: 0x7FFAC30794D0
        public void InvokePostPipelineStageCallback(){} // RVA: 0x7FFAC48462C0
        public void InvokePrePipelineMutateCameraStateCallback(){} // RVA: 0x7FFAC48465B0
        public void InvokeOnTransitionInExtensions(){} // RVA: 0x7FFAC4846890
        public void get_Name(){} // RVA: 0x7FFAC3143DB0
        public void get_Description(){} // RVA: 0x7FFAC4846AB0
        public void get_Priority(){} // RVA: 0x7FFAC33BD4A0
        public void set_Priority(){} // RVA: 0x7FFAC47E2CD0
        public void ApplyPositionBlendMethod(){} // RVA: 0x7FFAC4846AF0
        public void get_VirtualCameraGameObject(){} // RVA: 0x7FFAC4846B20
        public void get_IsValid(){} // RVA: 0x7FFAC4846C30
        public void get_State(){}
        public void get_ParentCamera(){} // RVA: 0x7FFAC4846D00
        public void IsLiveChild(){} // RVA: 0x7FFAC2F21320
        public void get_LookAt(){} // RVA: 0x7FFAC2C58E90
        public void set_LookAt(){} // RVA: 0x7FFAC2C70A40
        public void get_Follow(){} // RVA: 0x7FFAC2C58E90
        public void set_Follow(){} // RVA: 0x7FFAC2C70A40
        public void get_PreviousStateIsValid(){} // RVA: 0x7FFAC313F600
        public void set_PreviousStateIsValid(){} // RVA: 0x7FFAC3892770
        public void UpdateCameraState(){} // RVA: 0x7FFAC4846DA0
        public void InternalUpdateCameraState(){}
        public void OnTransitionFromCamera(){} // RVA: 0x7FFAC4846E40
        public void OnDestroy(){} // RVA: 0x7FFAC4846F10
        public void OnTransformParentChanged(){} // RVA: 0x7FFAC4847040
        public void Start(){} // RVA: 0x7FFAC30D2D70
        public void RequiresUserInput(){} // RVA: 0x7FFAC48470E0
        public void EnsureStarted(){} // RVA: 0x7FFAC4847260
        public void GetInputAxisProvider(){} // RVA: 0x7FFAC4847320
        public void OnValidate(){} // RVA: 0x7FFAC48473E0
        public void OnEnable(){} // RVA: 0x7FFAC4847450
        public void OnDisable(){} // RVA: 0x7FFAC48477C0
        public void Update(){} // RVA: 0x7FFAC4847830
        public void UpdateSlaveStatus(){} // RVA: 0x7FFAC4847840
        public void ResolveLookAt(){} // RVA: 0x7FFAC4847A20
        public void ResolveFollow(){} // RVA: 0x7FFAC4847B40
        public void UpdateVcamPoolStatus(){} // RVA: 0x7FFAC4847C60
        public void MoveToTopOfPrioritySubqueue(){} // RVA: 0x7FFAC4847E90
        public void OnTargetObjectWarped(){} // RVA: 0x7FFAC4847EA0
        public void ForceCameraPosition(){} // RVA: 0x7FFAC4847FA0
        public void GetInheritPosition(){} // RVA: 0x7FFAC48480B0
        public void CreateBlend(){} // RVA: 0x7FFAC48481C0
        public void PullStateFromVirtualCamera(){} // RVA: 0x7FFAC4848620
        public void InvalidateCachedTargets(){} // RVA: 0x7FFAC4848950
        public void get_FollowTargetChanged(){} // RVA: 0x7FFAC45C9D50
        public void set_FollowTargetChanged(){} // RVA: 0x7FFAC37B1910
        public void get_LookAtTargetChanged(){} // RVA: 0x7FFAC4848B60
        public void set_LookAtTargetChanged(){} // RVA: 0x7FFAC4848B70
        public void UpdateTargetCache(){} // RVA: 0x7FFAC4848B80
        public void get_AbstractFollowTargetGroup(){} // RVA: 0x7FFAC32EF410
        public void get_FollowTargetAsVcam(){} // RVA: 0x7FFAC30E5600
        public void get_AbstractLookAtTargetGroup(){} // RVA: 0x7FFAC354DFB0
        public void get_LookAtTargetAsVcam(){} // RVA: 0x7FFAC32EF640
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFAC4849180
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFAC48491A0
        public void LegacyUpgrade(){} // RVA: 0x7FFAC2F21310
        public void OnBeforeSerialize(){} // RVA: 0x7FFAC2F21310
        public void CancelDamping(){} // RVA: 0x7FFAC4849250
        public void .ctor(){} // RVA: 0x7FFAC48494B0
    }

    public class ClipperLib : Object
    {
    }

    public class ConfinerOven : Object
    {
        public float State; // 0x10
        public float m_SkeletonPadding; // 0x14
        public System.Collections.Generic.List`1<System.Collections.Generic.List`1<IntPoint>> m_OriginalPolygon; // 0x18
        public IntPoint m_MidPoint; // 0x20
        public System.Collections.Generic.List`1<System.Collections.Generic.List`1<IntPoint>> m_Skeleton; // 0x30
        public long k_FloatToIntScaler;
        public float k_IntToFloatScaler;
        public float k_MinStepSize;
        public UnityEngine.Rect m_PolygonRect; // 0x38
        public AspectStretcher m_AspectStretcher; // 0x48
        public float m_MaxComputationTimeForFullSkeletonBakeInSeconds; // 0x54
        public 0x6B22B100 <State>k__BackingField; // 0x58
        public float bakeProgress; // 0x5C
        public BakingStateCache m_Cache; // 0x60

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC4849750
        public void GetBakedSolution(){} // RVA: 0x7FFAC4849880
        public void get_State(){} // RVA: 0x7FFAC362EA40
        public void set_State(){} // RVA: 0x7FFAC362EA00
        public void Initialize(){} // RVA: 0x7FFAC4849CE0
        public void BakeConfiner(){} // RVA: 0x7FFAC484A540
        public void <Initialize>g__GetPolygonBoundingBox|24_0(){} // RVA: 0x7FFAC484AB90
        public void <Initialize>g__MidPointOfIntRect|24_1(){} // RVA: 0x7FFAC484AD50
        public void <BakeConfiner>g__ComputeSkeleton|25_0(){} // RVA: 0x7FFAC484AD80
    }

    public class Documentation : Object
    {
        public string BaseURL;
    }

    public class DocumentationSortingAttribute : Attribute
    {
        public 0x6B22AD38 Category; // 0x10

        // ── Methods ──
        public void get_Category(){} // RVA: 0x7FFAC2F6E5C0
        public void set_Category(){} // RVA: 0x7FFAC2F240C0
        public void .ctor(){} // RVA: 0x7FFAC2F240C0
    }

    public class GroupWeightManipulator : MonoBehaviour
    {
        public float m_Weight0; // 0x20
        public float m_Weight1; // 0x24
        public float m_Weight2; // 0x28
        public float m_Weight3; // 0x2C
        public float m_Weight4; // 0x30
        public float m_Weight5; // 0x34
        public float m_Weight6; // 0x38
        public float m_Weight7; // 0x3C
        public Cinemachine.CinemachineTargetGroup m_group; // 0x40

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAC48544D0
        public void OnValidate(){} // RVA: 0x7FFAC4854560
        public void Update(){} // RVA: 0x7FFAC48545D0
        public void UpdateWeights(){} // RVA: 0x7FFAC48547A0
        public void .ctor(){} // RVA: 0x7FFAC4854890
    }

    public class ICameraOverrideStack
    {
        public object DefaultWorldUp;

        // ── Methods ──
        public void SetCameraOverride(){}
        public void ReleaseCameraOverride(){} // RVA: 0x7FFAC2C70ED0
        public void get_DefaultWorldUp(){} // RVA: 0x7FFAC2C588A0
    }

    public class ICinemachineCamera
    {
        public object Name;
        public object Description;
        public object Priority;
        public object LookAt;
        public object Follow;
        public object State;
        public object VirtualCameraGameObject;
        public object IsValid;
        public object ParentCamera;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAC2C58E90
        public void get_Description(){} // RVA: 0x7FFAC2C58E90
        public void get_Priority(){} // RVA: 0x7FFAC2C59960
        public void set_Priority(){} // RVA: 0x7FFAC2C70ED0
        public void get_LookAt(){} // RVA: 0x7FFAC2C58E90
        public void set_LookAt(){} // RVA: 0x7FFAC2C70A40
        public void get_Follow(){} // RVA: 0x7FFAC2C58E90
        public void set_Follow(){} // RVA: 0x7FFAC2C70A40
        public void get_State(){}
        public void get_VirtualCameraGameObject(){} // RVA: 0x7FFAC2C58E90
        public void get_IsValid(){} // RVA: 0x7FFAC2C59D00
        public void get_ParentCamera(){} // RVA: 0x7FFAC2C58E90
        public void IsLiveChild(){}
        public void UpdateCameraState(){}
        public void InternalUpdateCameraState(){}
        public void OnTransitionFromCamera(){}
        public void OnTargetObjectWarped(){}
    }

    public class ICinemachineTargetGroup
    {
        public object Transform;
        public object BoundingBox;
        public object Sphere;
        public object IsEmpty;

        // ── Methods ──
        public void get_Transform(){} // RVA: 0x7FFAC2C58E90
        public void get_BoundingBox(){}
        public void get_Sphere(){}
        public void get_IsEmpty(){} // RVA: 0x7FFAC2C59D00
        public void GetViewSpaceBoundingBox(){}
        public void GetViewSpaceAngularBounds(){}
    }

    public class ISignalSource6D
    {
        public object SignalDuration;

        // ── Methods ──
        public void get_SignalDuration(){} // RVA: 0x7FFAC2C6D880
        public void GetSignal(){}
    }

    public class LensSettings : ValueType
    {
        public Cinemachine.LensSettings Orthographic;
        public float SensorSize; // 0x10
        public float Aspect; // 0x14
        public float IsPhysicalCamera; // 0x18
        public float FarClipPlane; // 0x1C
        public float Dutch; // 0x20
        public 0x6B22B260 ModeOverride; // 0x24
        public UnityEngine.Vector2 LensShift; // 0x28
        public 0x6B1798F0 GateFit; // 0x30
        public float FocusDistance; // 0x34
        public UnityEngine.Vector2 m_SensorSize; // 0x38
        public bool m_OrthoFromCamera; // 0x40
        public bool m_PhysicalFromCamera; // 0x41

        // ── Methods ──
        public void get_Orthographic(){} // RVA: 0x7FFAC484C300
        public void set_Orthographic(){} // RVA: 0x7FFAC484C320
        public void get_SensorSize(){} // RVA: 0x7FFAC43A2620
        public void set_SensorSize(){} // RVA: 0x7FFAC33D3BF0
        public void get_Aspect(){} // RVA: 0x7FFAC484C330
        public void get_IsPhysicalCamera(){} // RVA: 0x7FFAC484C3C0
        public void set_IsPhysicalCamera(){} // RVA: 0x7FFAC484C3E0
        public void FromCamera(){} // RVA: 0x7FFAC484C3F0
        public void SnapshotCameraReadOnlyProperties(){} // RVA: 0x7FFAC484CB90 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC484CCA0
        public void Lerp(){} // RVA: 0x7FFAC484CCF0
        public void Validate(){} // RVA: 0x7FFAC484CF50
        public void .cctor(){} // RVA: 0x7FFAC484CFD0
    }

    public class LensSettingsPropertyAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class NoSaveDuringPlayAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class NoiseSettings : SignalSourceAsset
    {
        public TransformNoiseParams[] SignalDuration; // 0x18
        public TransformNoiseParams[] OrientationNoise; // 0x20

        // ── Methods ──
        public void GetCombinedFilterResults(){} // RVA: 0x7FFAC484D060
        public void get_SignalDuration(){} // RVA: 0x7FFAC37432E0
        public void GetSignal(){} // RVA: 0x7FFAC484D1E0
        public void .ctor(){} // RVA: 0x7FFAC484D390
    }

    public class NoiseSettingsPropertyAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class OrbitalTransposerHeadingPropertyAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class RuntimeUtility : Object
    {
        public UnityEngine.RaycastHit[] s_HitBuffer;
        public int[] s_PenetrationIndexBuffer; // 0x8
        public UnityEngine.SphereCollider s_ScratchCollider; // 0x10
        public UnityEngine.GameObject s_ScratchColliderGameObject; // 0x18

        // ── Methods ──
        public void DestroyObject(){} // RVA: 0x7FFAC484D5D0
        public void IsPrefab(){} // RVA: 0x7FFAC2F21320
        public void RaycastIgnoreTag(){} // RVA: 0x7FFAC484D6C0
        public void SphereCastIgnoreTag(){} // RVA: 0x7FFAC484DA80
        public void GetScratchCollider(){} // RVA: 0x7FFAC484E5F0
        public void DestroyScratchCollider(){} // RVA: 0x7FFAC484EB90
        public void NormalizeCurve(){} // RVA: 0x7FFAC484EE80
        public void .cctor(){} // RVA: 0x7FFAC484F0F0
    }

    public class SaveDuringPlayAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class SignalSourceAsset : ScriptableObject
    {
        public object SignalDuration;

        // ── Methods ──
        public void get_SignalDuration(){} // RVA: 0x7FFAC2C6D880
        public void GetSignal(){}
        public void .ctor(){} // RVA: 0x7FFAC312F5F0
    }

    public class StaticPointVirtualCamera : Object
    {
        public string Name; // 0x10
        public int Description; // 0x18
        public UnityEngine.Transform Priority; // 0x20
        public UnityEngine.Transform LookAt; // 0x28
        public Cinemachine.CameraState Follow; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC483E7A0
        public void SetState(){} // RVA: 0x7FFAC483E8A0
        public void get_Name(){} // RVA: 0x7FFAC2F3C380
        public void set_Name(){} // RVA: 0x7FFAC2F22E30
        public void get_Description(){} // RVA: 0x7FFAC483E950
        public void get_Priority(){} // RVA: 0x7FFAC3157800
        public void set_Priority(){} // RVA: 0x7FFAC392CD10
        public void get_LookAt(){} // RVA: 0x7FFAC2F4F0C0
        public void set_LookAt(){} // RVA: 0x7FFAC2F4F0D0
        public void get_Follow(){} // RVA: 0x7FFAC2F4F130
        public void set_Follow(){} // RVA: 0x7FFAC2F22E90
        public void get_State(){} // RVA: 0x7FFAC483E990
        public void set_State(){} // RVA: 0x7FFAC483EA30
        public void get_VirtualCameraGameObject(){} // RVA: 0x7FFAC34F9180
        public void get_IsValid(){} // RVA: 0x7FFAC3006850
        public void get_ParentCamera(){} // RVA: 0x7FFAC34F9180
        public void IsLiveChild(){} // RVA: 0x7FFAC2F21320
        public void UpdateCameraState(){} // RVA: 0x7FFAC2F21310
        public void InternalUpdateCameraState(){} // RVA: 0x7FFAC2F21310
        public void OnTransitionFromCamera(){} // RVA: 0x7FFAC2F21310
        public void OnTargetObjectWarped(){} // RVA: 0x7FFAC2F21310
    }

    public class TagFieldAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class TargetPositionCache : Object
    {
        public bool CacheMode;
        public float IsRecording;
        public 0x6B22B520 CurrentPlaybackTimeValid; // 0x4
        public float IsEmpty; // 0x8
        public int CacheTimeRange; // 0xC
        public bool HasCurrentTime; // 0x10
        public System.Collections.Generic.Dictionary`2<UnityEngine.Transform,CacheEntry> m_Cache; // 0x18
        public TimeRange m_CacheTimeRange; // 0x20
        public float kWraparoundSlush;

        // ── Methods ──
        public void get_CacheMode(){} // RVA: 0x7FFAC484F240
        public void set_CacheMode(){} // RVA: 0x7FFAC484F280
        public void get_IsRecording(){} // RVA: 0x7FFAC484F2F0
        public void get_CurrentPlaybackTimeValid(){} // RVA: 0x7FFAC484F340
        public void get_IsEmpty(){} // RVA: 0x7FFAC484F3D0
        public void get_CacheTimeRange(){} // RVA: 0x7FFAC484F420
        public void get_HasCurrentTime(){} // RVA: 0x7FFAC484F470
        public void ClearCache(){} // RVA: 0x7FFAC484F4D0
        public void CreatePlaybackCurves(){} // RVA: 0x7FFAC484F640
        public void GetTargetPosition(){} // RVA: 0x7FFAC484F890
        public void GetTargetRotation(){} // RVA: 0x7FFAC484FD50
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class UpdateTracker : Object
    {
        public System.Collections.Generic.Dictionary`2<UnityEngine.Transform,UpdateStatus> mUpdateStatus;
        public System.Collections.Generic.List`1<UnityEngine.Transform> sToDelete; // 0x8
        public float mLastUpdateTime; // 0x10

        // ── Methods ──
        public void InitializeModule(){} // RVA: 0x7FFAC4851560
        public void UpdateTargets(){} // RVA: 0x7FFAC48515E0
        public void GetPreferredUpdate(){} // RVA: 0x7FFAC4851AE0
        public void OnUpdate(){} // RVA: 0x7FFAC4851E50
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC4851F10
    }

    public class VcamTargetPropertyAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

}