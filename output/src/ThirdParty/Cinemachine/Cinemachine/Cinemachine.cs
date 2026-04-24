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
        public void Validate(){} // RVA: 0x7FFD4FC63EA0
    }

    public class AxisState : ValueType
    {
        public float HasInputProvider; // 0x10
        public 0x66589FD0 ValueRangeLocked; // 0x14
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
        public void .ctor(){} // RVA: 0x7FFD4FC56950
        public void Validate(){} // RVA: 0x7FFD4FC56AC0
        public void Reset(){} // RVA: 0x7FFD4FC56B20
        public void SetInputAxisProvider(){} // RVA: 0x7FFD4FC56B30
        public void get_HasInputProvider(){} // RVA: 0x7FFD4FC56B90
        public void Update(){} // RVA: 0x7FFD4FC56BA0
        public void ClampValue(){} // RVA: 0x7FFD4FC570A0
        public void MaxSpeedUpdate(){} // RVA: 0x7FFD4FC57110
        public void GetMaxSpeed(){} // RVA: 0x7FFD4FC57350
        public void get_ValueRangeLocked(){} // RVA: 0x7FFD4FC57400
        public void set_ValueRangeLocked(){} // RVA: 0x7FFD4FC57410
        public void get_HasRecentering(){} // RVA: 0x7FFD4FC57420
        public void set_HasRecentering(){} // RVA: 0x7FFD4FC57430
    }

    public class AxisStatePropertyAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class BlendSourceVirtualCamera : Object
    {
        public Cinemachine.CinemachineBlend Blend; // 0x10
        public int Name; // 0x18
        public UnityEngine.Transform Description; // 0x20
        public UnityEngine.Transform Priority; // 0x28
        public Cinemachine.CameraState LookAt; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E342E30
        public void get_Blend(){} // RVA: 0x7FFD4E35C380
        public void set_Blend(){} // RVA: 0x7FFD4E342E30
        public void get_Name(){} // RVA: 0x7FFD4FC5EB10
        public void get_Description(){} // RVA: 0x7FFD4FC5EB50
        public void get_Priority(){} // RVA: 0x7FFD4E577800
        public void set_Priority(){} // RVA: 0x7FFD4ED4CD10
        public void get_LookAt(){} // RVA: 0x7FFD4E36F0C0
        public void set_LookAt(){} // RVA: 0x7FFD4E36F0D0
        public void get_Follow(){} // RVA: 0x7FFD4E36F130
        public void set_Follow(){} // RVA: 0x7FFD4E342E90
        public void get_State(){} // RVA: 0x7FFD4FC5E990
        public void set_State(){} // RVA: 0x7FFD4FC5EA30
        public void get_VirtualCameraGameObject(){} // RVA: 0x7FFD4E919180
        public void get_IsValid(){} // RVA: 0x7FFD4FC5EBA0
        public void get_ParentCamera(){} // RVA: 0x7FFD4E919180
        public void IsLiveChild(){} // RVA: 0x7FFD4FC5EBC0
        public void CalculateNewState(){} // RVA: 0x7FFD4FC5E990
        public void UpdateCameraState(){} // RVA: 0x7FFD4FC5EBE0
        public void InternalUpdateCameraState(){} // RVA: 0x7FFD4E341310
        public void OnTransitionFromCamera(){} // RVA: 0x7FFD4E341310
        public void OnTargetObjectWarped(){} // RVA: 0x7FFD4E341310
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
        public 0x6658A130 BlendHint; // 0xA4
        public CustomBlendable mCustom0; // 0xA8
        public CustomBlendable mCustom1; // 0xB8
        public CustomBlendable mCustom2; // 0xC8
        public CustomBlendable mCustom3; // 0xD8
        public System.Collections.Generic.List`1<CustomBlendable> m_CustomOverflow; // 0xE8
        public int <NumCustomBlendables>k__BackingField; // 0xF0

        // ── Methods ──
        public void get_HasLookAt(){} // RVA: 0x7FFD4FC57810
        public void get_CorrectedPosition(){} // RVA: 0x7FFD4FC57870
        public void get_CorrectedOrientation(){} // RVA: 0x7FFD4FC578C0
        public void get_FinalPosition(){} // RVA: 0x7FFD4FC57870
        public void get_FinalOrientation(){} // RVA: 0x7FFD4FC57A30
        public void get_Default(){} // RVA: 0x7FFD4FC57CF0
        public void get_NumCustomBlendables(){} // RVA: 0x7FFD4FC57F50
        public void set_NumCustomBlendables(){} // RVA: 0x7FFD4FC57F60
        public void GetCustomBlendable(){} // RVA: 0x7FFD4FC57F70
        public void FindCustomBlendable(){} // RVA: 0x7FFD4FC580E0
        public void AddCustomBlendable(){} // RVA: 0x7FFD4FC58660
        public void Lerp(){} // RVA: 0x7FFD4FC58A20
        public void InterpolateFOV(){} // RVA: 0x7FFD4FC5CA80
        public void ApplyPosBlendHint(){} // RVA: 0x7FFD4FC5CBD0
        public void ApplyRotBlendHint(){} // RVA: 0x7FFD4FC5CC50
        public void InterpolatePosition(){} // RVA: 0x7FFD4FC5CCA0
        public void .cctor(){} // RVA: 0x7FFD4FC5D190
    }

    public class Cinemachine3rdPersonAim : CinemachineExtension
    {
        public UnityEngine.LayerMask AimTarget; // 0x30
        public string IgnoreTag; // 0x38
        public float AimDistance; // 0x40
        public UnityEngine.RectTransform AimTargetReticle; // 0x48
        public UnityEngine.Vector3 <AimTarget>k__BackingField; // 0x50

        // ── Methods ──
        public void get_AimTarget(){} // RVA: 0x7FFD4E3A7FA0
        public void set_AimTarget(){} // RVA: 0x7FFD4E3A7FC0
        public void OnValidate(){} // RVA: 0x7FFD4FC0E460
        public void Reset(){} // RVA: 0x7FFD4FC0E480
        public void OnTransitionFromCamera(){} // RVA: 0x7FFD4FC0E590
        public void DrawReticle(){} // RVA: 0x7FFD4FC0E710
        public void ComputeLookAtPoint(){} // RVA: 0x7FFD4FC0EAA0
        public void ComputeAimTarget(){} // RVA: 0x7FFD4FC0F0D0
        public void PostPipelineStageCallback(){} // RVA: 0x7FFD4FC0F350
        public void .ctor(){} // RVA: 0x7FFD4FC0F6A0
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
        public void OnValidate(){} // RVA: 0x7FFD4FC400F0
        public void Reset(){} // RVA: 0x7FFD4FC40170
        public void OnDestroy(){} // RVA: 0x7FFD4FC401E0
        public void get_IsValid(){} // RVA: 0x7FFD4FC40230
        public void get_Stage(){} // RVA: 0x7FFD4E919180
        public void GetMaxDampTime(){} // RVA: 0x7FFD4FC40350
        public void MutateCameraState(){} // RVA: 0x7FFD4FC40380
        public void OnTargetObjectWarped(){} // RVA: 0x7FFD4FC40410
        public void PositionCamera(){} // RVA: 0x7FFD4FC40580
        public void GetRigPositions(){} // RVA: 0x7FFD4FC40CA0
        public void GetHeading(){} // RVA: 0x7FFD4FC40EC0
        public void GetRawRigPositions(){} // RVA: 0x7FFD4FC41440
        public void ResolveCollisions(){} // RVA: 0x7FFD4FC417C0
        public void .ctor(){} // RVA: 0x7FFD4FC41B10
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
        public void get_IsValid(){} // RVA: 0x7FFD4FC41BE0
        public void get_Stage(){} // RVA: 0x7FFD4E446CB0
        public void MutateCameraState(){} // RVA: 0x7FFD4FC41D00
        public void ReSeed(){} // RVA: 0x7FFD4FC427E0
        public void Initialize(){} // RVA: 0x7FFD4FC42910
        public void .ctor(){} // RVA: 0x7FFD4FC42B20
    }

    public class CinemachineBlend : Object
    {
        public Cinemachine.ICinemachineCamera BlendWeight; // 0x10
        public Cinemachine.ICinemachineCamera IsValid; // 0x18
        public UnityEngine.AnimationCurve IsComplete; // 0x20
        public float Description; // 0x28
        public float State; // 0x2C

        // ── Methods ──
        public void get_BlendWeight(){} // RVA: 0x7FFD4FC5D1E0
        public void get_IsValid(){} // RVA: 0x7FFD4FC5D2D0
        public void get_IsComplete(){} // RVA: 0x7FFD4FC5D350
        public void get_Description(){} // RVA: 0x7FFD4FC5D380
        public void Uses(){} // RVA: 0x7FFD4FC5D590
        public void .ctor(){} // RVA: 0x7FFD4FC5D6D0
        public void UpdateCameraState(){} // RVA: 0x7FFD4FC5D7F0
        public void get_State(){} // RVA: 0x7FFD4FC5D8E0
    }

    public class CinemachineBlendDefinition : ValueType
    {
        public 0x6658A290 BlendTime; // 0x10
        public float BlendCurve; // 0x14
        public UnityEngine.AnimationCurve m_CustomCurve; // 0x18
        public UnityEngine.AnimationCurve[] sStandardCurves;

        // ── Methods ──
        public void get_BlendTime(){} // RVA: 0x7FFD4FC5DDB0
        public void .ctor(){} // RVA: 0x7FFD4FC5DDC0
        public void CreateStandardCurves(){} // RVA: 0x7FFD4FC5DE20
        public void get_BlendCurve(){} // RVA: 0x7FFD4FC5E690
    }

    public class CinemachineBlendDefinitionPropertyAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
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
        public void get_Description(){} // RVA: 0x7FFD4FC0F770
        public void Reset(){} // RVA: 0x7FFD4FC0F8B0
        public void get_LiveChild(){} // RVA: 0x7FFD4E45E100
        public void set_LiveChild(){} // RVA: 0x7FFD4E45E110
        public void IsLiveChild(){} // RVA: 0x7FFD4FC0FA20
        public void get_State(){} // RVA: 0x7FFD4FC0FA50
        public void get_LookAt(){} // RVA: 0x7FFD4FC0FAF0
        public void set_LookAt(){} // RVA: 0x7FFD4E76B370
        public void get_Follow(){} // RVA: 0x7FFD4FC0FB00
        public void set_Follow(){} // RVA: 0x7FFD4E3AC050
        public void OnTargetObjectWarped(){} // RVA: 0x7FFD4FC0FB10
        public void ForceCameraPosition(){} // RVA: 0x7FFD4FC0FBF0
        public void OnTransitionFromCamera(){} // RVA: 0x7FFD4FC0FD80
        public void InternalUpdateCameraState(){} // RVA: 0x7FFD4FC0FFB0
        public void OnEnable(){} // RVA: 0x7FFD4FC10980
        public void OnDisable(){} // RVA: 0x7FFD4FC10CE0
        public void OnTransformChildrenChanged(){} // RVA: 0x7FFD4FC10E60
        public void OnGuiHandler(){} // RVA: 0x7FFD4FC10E70
        public void get_ChildCameras(){} // RVA: 0x7FFD4FC10FE0
        public void get_IsBlending(){} // RVA: 0x7FFD4FC11000
        public void InvalidateListOfChildren(){} // RVA: 0x7FFD4FC11010
        public void UpdateListOfChildren(){} // RVA: 0x7FFD4FC110D0
        public void ValidateInstructions(){} // RVA: 0x7FFD4FC11460
        public void AdvanceCurrentInstruction(){} // RVA: 0x7FFD4FC11860
        public void .ctor(){} // RVA: 0x7FFD4FC11AC0
    }

    public class CinemachineBlenderSettings : ScriptableObject
    {
        public CustomBlend[] m_CustomBlends; // 0x18
        public string kBlendFromAnyCameraLabel;

        // ── Methods ──
        public void GetBlendForVirtualCameras(){} // RVA: 0x7FFD4FC5EDB0
        public void .ctor(){} // RVA: 0x7FFD4E54F5F0
    }

    public class CinemachineBrain : MonoBehaviour
    {
        public bool OutputCamera; // 0x20
        public bool ControlledObject; // 0x21
        public bool SoloCamera; // 0x22
        public UnityEngine.Transform DefaultWorldUp; // 0x28
        public 0x665883F8 ActiveVirtualCamera; // 0x30
        public 0x66588450 IsBlending; // 0x34
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
        public void get_OutputCamera(){} // RVA: 0x7FFD4FC11C90
        public void get_ControlledObject(){} // RVA: 0x7FFD4FC11E00
        public void set_ControlledObject(){} // RVA: 0x7FFD4FC11F20
        public void get_SoloCamera(){} // RVA: 0x7FFD4FC11FE0
        public void set_SoloCamera(){} // RVA: 0x7FFD4FC12040
        public void GetSoloGUIColor(){} // RVA: 0x7FFD4FC122A0
        public void get_DefaultWorldUp(){} // RVA: 0x7FFD4FC122C0
        public void OnEnable(){} // RVA: 0x7FFD4FC12450
        public void OnDisable(){} // RVA: 0x7FFD4FC129C0
        public void OnSceneLoaded(){} // RVA: 0x7FFD4FC12CC0
        public void OnSceneUnloaded(){} // RVA: 0x7FFD4FC12D60
        public void Awake(){} // RVA: 0x7FFD4FC12E00
        public void Start(){} // RVA: 0x7FFD4FC12E60
        public void OnGuiHandler(){} // RVA: 0x7FFD4FC12E80
        public void AfterPhysics(){} // RVA: 0x7FFD4FC13360
        public void LateUpdate(){} // RVA: 0x7FFD4FC13400
        public void ManualUpdate(){} // RVA: 0x7FFD4FC13410
        public void GetEffectiveDeltaTime(){} // RVA: 0x7FFD4FC13740
        public void UpdateVirtualCameras(){} // RVA: 0x7FFD4FC139E0
        public void get_ActiveVirtualCamera(){} // RVA: 0x7FFD4FC13D70
        public void DeepCamBFromBlend(){} // RVA: 0x7FFD4FC13EF0
        public void IsLiveInBlend(){} // RVA: 0x7FFD4FC13FB0
        public void get_IsBlending(){} // RVA: 0x7FFD4FC140F0
        public void get_ActiveBlend(){} // RVA: 0x7FFD4FC14110
        public void set_ActiveBlend(){} // RVA: 0x7FFD4FC14210
        public void GetBrainFrame(){} // RVA: 0x7FFD4FC14330
        public void SetCameraOverride(){} // RVA: 0x7FFD4FC14470
        public void ReleaseCameraOverride(){} // RVA: 0x7FFD4FC149A0
        public void ProcessActiveCamera(){} // RVA: 0x7FFD4FC14A80
        public void UpdateFrame0(){} // RVA: 0x7FFD4FC151D0
        public void ComputeCurrentBlend(){} // RVA: 0x7FFD4FC15A00
        public void IsLive(){} // RVA: 0x7FFD4FC16000
        public void get_CurrentCameraState(){} // RVA: 0x7FFD4FC161E0
        public void set_CurrentCameraState(){} // RVA: 0x7FFD4FC16280
        public void TopCameraFromPriorityQueue(){} // RVA: 0x7FFD4FC16370
        public void LookupBlend(){} // RVA: 0x7FFD4FC166A0
        public void PushStateToUnityCamera(){} // RVA: 0x7FFD4FC16900
        public void .ctor(){} // RVA: 0x7FFD4FC16F90
        public void .cctor(){} // RVA: 0x7FFD4FC173F0
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
        public void get_Description(){} // RVA: 0x7FFD4FC179B0
        public void get_LiveChild(){} // RVA: 0x7FFD4E3AC2A0
        public void set_LiveChild(){} // RVA: 0x7FFD4E3AC2B0
        public void get_State(){} // RVA: 0x7FFD4FC17AF0
        public void IsLiveChild(){} // RVA: 0x7FFD4FC17B90
        public void get_LookAt(){} // RVA: 0x7FFD4FC0FAF0
        public void set_LookAt(){} // RVA: 0x7FFD4E76B370
        public void get_Follow(){} // RVA: 0x7FFD4FC0FB00
        public void set_Follow(){} // RVA: 0x7FFD4E3AC050
        public void OnTargetObjectWarped(){} // RVA: 0x7FFD4FC17BC0
        public void ForceCameraPosition(){} // RVA: 0x7FFD4FC17CA0
        public void InternalUpdateCameraState(){} // RVA: 0x7FFD4FC17E30
        public void OnEnable(){} // RVA: 0x7FFD4FC18570
        public void OnDisable(){} // RVA: 0x7FFD4FC18880
        public void OnTransformChildrenChanged(){} // RVA: 0x7FFD4FC18A00
        public void OnGuiHandler(){} // RVA: 0x7FFD4FC18A20
        public void get_IsBlending(){} // RVA: 0x7FFD4FC18B90
        public void get_ActiveBlend(){} // RVA: 0x7FFD4E964EF0
        public void get_ChildCameras(){} // RVA: 0x7FFD4FC18BA0
        public void InvalidateListOfChildren(){} // RVA: 0x7FFD4FC18BC0
        public void ResetRandomization(){} // RVA: 0x7FFD4FC18CE0
        public void UpdateListOfChildren(){} // RVA: 0x7FFD4FC18D60
        public void ChooseCurrentCamera(){} // RVA: 0x7FFD4FC19220
        public void Randomize(){} // RVA: 0x7FFD4FC19C00
        public void LookupBlend(){} // RVA: 0x7FFD4FC1A130
        public void OnTransitionFromCamera(){} // RVA: 0x7FFD4FC1A3A0
        public void .ctor(){} // RVA: 0x7FFD4FC1A530
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
        public 0x66588768 m_Strategy; // 0x58
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
        public void IsTargetObscured(){} // RVA: 0x7FFD4FC1A880
        public void CameraWasDisplaced(){} // RVA: 0x7FFD4FC1A8E0
        public void GetCameraDisplacementDistance(){} // RVA: 0x7FFD4FC1A950
        public void OnValidate(){} // RVA: 0x7FFD4FC1A9C0
        public void OnDestroy(){} // RVA: 0x7FFD4FC1AA10
        public void get_DebugPaths(){} // RVA: 0x7FFD4FC1AA80
        public void GetMaxDampTime(){} // RVA: 0x7FFD4FC1ACA0
        public void OnTargetObjectWarped(){} // RVA: 0x7FFD4FC1ACC0
        public void PostPipelineStageCallback(){} // RVA: 0x7FFD4FC1ADC0
        public void PreserveLineOfSight(){} // RVA: 0x7FFD4FC1C090
        public void PullCameraInFrontOfNearestObstacle(){} // RVA: 0x7FFD4FC1C680
        public void PushCameraBack(){} // RVA: 0x7FFD4FC1CBA0
        public void GetWalkingDirection(){} // RVA: 0x7FFD4FC1D630
        public void GetPushBackDistance(){} // RVA: 0x7FFD4FC1DF70
        public void ClampRayToBounds(){} // RVA: 0x7FFD4FC1E0E0
        public void RespectCameraRadius(){} // RVA: 0x7FFD4FC1EFF0
        public void CheckForTargetObstructions(){} // RVA: 0x7FFD4FC1FCC0
        public void IsTargetOffscreen(){} // RVA: 0x7FFD4FC20130
        public void .ctor(){} // RVA: 0x7FFD4FC209B0
        public void .cctor(){} // RVA: 0x7FFD4FC20B20
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
        public void Start(){} // RVA: 0x7FFD4FC74910
        public void OnEnable(){} // RVA: 0x7FFD4E341310
        public void OnCollisionEnter(){} // RVA: 0x7FFD4FC74A30
        public void OnTriggerEnter(){} // RVA: 0x7FFD4FC74AE0
        public void GetMassAndVelocity(){} // RVA: 0x7FFD4FC74B50
        public void GenerateImpactEvent(){} // RVA: 0x7FFD4FC75050
        public void OnCollisionEnter2D(){} // RVA: 0x7FFD4FC753C0
        public void OnTriggerEnter2D(){} // RVA: 0x7FFD4FC75420
        public void GetMassAndVelocity2D(){} // RVA: 0x7FFD4FC75490
        public void GenerateImpactEvent2D(){} // RVA: 0x7FFD4FC758E0
        public void .ctor(){} // RVA: 0x7FFD4FC75C50
    }

    public class CinemachineComponentBase : MonoBehaviour
    {
        public float VirtualCamera;
        public Cinemachine.CinemachineVirtualCameraBase FollowTarget; // 0x20

        // ── Methods ──
        public void get_VirtualCamera(){} // RVA: 0x7FFD4FC5F110
        public void get_FollowTarget(){} // RVA: 0x7FFD4FC5F520
        public void get_LookAtTarget(){} // RVA: 0x7FFD4FC5F620
        public void get_AbstractFollowTargetGroup(){} // RVA: 0x7FFD4FC5F720
        public void get_FollowTargetGroup(){} // RVA: 0x7FFD4FC5F800
        public void get_FollowTargetPosition(){} // RVA: 0x7FFD4FC5F890
        public void get_FollowTargetRotation(){} // RVA: 0x7FFD4FC5FB90
        public void get_AbstractLookAtTargetGroup(){} // RVA: 0x7FFD4FC5FE60
        public void get_LookAtTargetGroup(){} // RVA: 0x7FFD4FC5FE90
        public void get_LookAtTargetPosition(){} // RVA: 0x7FFD4FC5FF30
        public void get_LookAtTargetRotation(){} // RVA: 0x7FFD4FC60230
        public void get_VcamState(){} // RVA: 0x7FFD4FC60500
        public void get_IsValid(){} // RVA: 0x7FFD4E079D00
        public void PrePipelineMutateCameraState(){} // RVA: 0x7FFD4E341310
        public void get_Stage(){} // RVA: 0x7FFD4E079960
        public void get_BodyAppliesAfterAim(){} // RVA: 0x7FFD4E341320
        public void MutateCameraState(){} // RVA: 0x7FFD4E09D7B0
        public void OnTransitionFromCamera(){} // RVA: 0x7FFD4E341320
        public void OnTargetObjectWarped(){} // RVA: 0x7FFD4E341310
        public void ForceCameraPosition(){} // RVA: 0x7FFD4E341310
        public void GetMaxDampTime(){} // RVA: 0x7FFD4EB632E0
        public void get_RequiresUserInput(){} // RVA: 0x7FFD4E341320
        public void .ctor(){} // RVA: 0x7FFD4E341D50
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
        public void get_IsValid(){} // RVA: 0x7FFD4FC42C00
        public void get_Stage(){} // RVA: 0x7FFD4E433AF0
        public void get_TrackedPoint(){} // RVA: 0x7FFD4FC42D20
        public void set_TrackedPoint(){} // RVA: 0x7FFD4FC42D40
        public void GetLookAtPointAndSetTrackedPoint(){} // RVA: 0x7FFD4FC42D50
        public void OnTargetObjectWarped(){} // RVA: 0x7FFD4FC43220
        public void ForceCameraPosition(){} // RVA: 0x7FFD4FC43420
        public void GetMaxDampTime(){} // RVA: 0x7FFD4FC43440
        public void PrePipelineMutateCameraState(){} // RVA: 0x7FFD4FC43450
        public void MutateCameraState(){} // RVA: 0x7FFD4FC43590
        public void get_SoftGuideRect(){} // RVA: 0x7FFD4FC44340
        public void set_SoftGuideRect(){} // RVA: 0x7FFD4FC44390
        public void get_HardGuideRect(){} // RVA: 0x7FFD4FC44450
        public void set_HardGuideRect(){} // RVA: 0x7FFD4FC444D0
        public void RotateToScreenBounds(){} // RVA: 0x7FFD4FC44540
        public void ClampVerticalBounds(){} // RVA: 0x7FFD4FC44820
        public void .ctor(){} // RVA: 0x7FFD4FC44B20
    }

    public class CinemachineConfiner : CinemachineExtension
    {
        public 0x66588870 IsValid; // 0x30
        public UnityEngine.Collider m_BoundingVolume; // 0x38
        public UnityEngine.Collider2D m_BoundingShape2D; // 0x40
        public UnityEngine.Collider2D m_BoundingShape2DCache; // 0x48
        public bool m_ConfineScreenEdges; // 0x50
        public float m_Damping; // 0x54
        public System.Collections.Generic.List`1<System.Collections.Generic.List`1<UnityEngine.Vector2>> m_pathCache; // 0x58
        public int m_pathTotalPointCount; // 0x60

        // ── Methods ──
        public void CameraWasDisplaced(){} // RVA: 0x7FFD4FC20D60
        public void GetCameraDisplacementDistance(){} // RVA: 0x7FFD4FC20DD0
        public void OnValidate(){} // RVA: 0x7FFD4FC20E30
        public void ConnectToVcam(){} // RVA: 0x7FFD4FC20E40
        public void get_IsValid(){} // RVA: 0x7FFD4FC20E50
        public void GetMaxDampTime(){} // RVA: 0x7FFD4E7B1600
        public void PostPipelineStageCallback(){} // RVA: 0x7FFD4FC210E0
        public void InvalidatePathCache(){} // RVA: 0x7FFD4FC213C0
        public void ValidatePathCache(){} // RVA: 0x7FFD4FC21470
        public void ConfinePoint(){} // RVA: 0x7FFD4FC21DB0
        public void ConfineScreenEdges(){} // RVA: 0x7FFD4FC223F0
        public void .ctor(){} // RVA: 0x7FFD4FC22C20
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
        public void InvalidateCache(){} // RVA: 0x7FFD4FC22C70
        public void ValidateCache(){} // RVA: 0x7FFD4FC22C80
        public void PostPipelineStageCallback(){} // RVA: 0x7FFD4FC22CD0
        public void CalculateHalfFrustumHeight(){} // RVA: 0x7FFD4FC23500
        public void OnValidate(){} // RVA: 0x7FFD4FC235B0
        public void Reset(){} // RVA: 0x7FFD4FC235D0
        public void .ctor(){} // RVA: 0x7FFD4FC235E0
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
        public 0x6658A6B0 m_CurrentUpdateFilter; // 0x40

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFD4FC606B0
        public void get_DeltaTime(){} // RVA: 0x7FFD4FC607E0
        public void get_CurrentTime(){} // RVA: 0x7FFD4FC608A0
        public void get_BrainCount(){} // RVA: 0x7FFD4FC60960
        public void GetActiveBrain(){} // RVA: 0x7FFD4FC609B0
        public void AddActiveBrain(){} // RVA: 0x7FFD4FC60A30
        public void RemoveActiveBrain(){} // RVA: 0x7FFD4FC60AD0
        public void get_VirtualCameraCount(){} // RVA: 0x7FFD4FC60B30
        public void GetVirtualCamera(){} // RVA: 0x7FFD4FC60B80
        public void AddActiveCamera(){} // RVA: 0x7FFD4FC60D40
        public void RemoveActiveCamera(){} // RVA: 0x7FFD4FC60DB0
        public void CameraDestroyed(){} // RVA: 0x7FFD4FC60E30
        public void CameraEnabled(){} // RVA: 0x7FFD4FC60F20
        public void CameraDisabled(){} // RVA: 0x7FFD4FC61180
        public void UpdateAllActiveVirtualCameras(){} // RVA: 0x7FFD4FC613B0
        public void UpdateVirtualCamera(){} // RVA: 0x7FFD4FC61AC0
        public void InitializeModule(){} // RVA: 0x7FFD4FC61FB0
        public void GetUpdateTarget(){} // RVA: 0x7FFD4FC620B0
        public void GetVcamUpdateStatus(){} // RVA: 0x7FFD4FC623D0
        public void IsLive(){} // RVA: 0x7FFD4FC62460
        public void IsLiveInBlend(){} // RVA: 0x7FFD4FC625C0
        public void GenerateCameraActivationEvent(){} // RVA: 0x7FFD4FC62720
        public void GenerateCameraCutEvent(){} // RVA: 0x7FFD4FC62900
        public void FindPotentialTargetBrain(){} // RVA: 0x7FFD4FC62B50
        public void OnTargetObjectWarped(){} // RVA: 0x7FFD4FC63020
        public void .ctor(){} // RVA: 0x7FFD4FC630F0
        public void .cctor(){} // RVA: 0x7FFD4FC632E0
    }

    public class CinemachineDollyCart : MonoBehaviour
    {
        public Cinemachine.CinemachinePathBase m_Path; // 0x20
        public 0x66588A80 m_UpdateMethod; // 0x28
        public 0x6658A918 m_PositionUnits; // 0x2C
        public float m_Speed; // 0x30
        public float m_Position; // 0x34

        // ── Methods ──
        public void FixedUpdate(){} // RVA: 0x7FFD4FC248E0
        public void Update(){} // RVA: 0x7FFD4FC24970
        public void LateUpdate(){} // RVA: 0x7FFD4FC24A80
        public void SetCartPosition(){} // RVA: 0x7FFD4FC24BA0
        public void .ctor(){} // RVA: 0x7FFD4FC24DB0
    }

    public class CinemachineEmbeddedAssetPropertyAttribute : PropertyAttribute
    {
        public bool WarnIfNull; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E40B5F0
    }

    public class CinemachineExtension : MonoBehaviour
    {
        public float VirtualCamera;
        public Cinemachine.CinemachineVirtualCameraBase RequiresUserInput; // 0x20
        public System.Collections.Generic.Dictionary`2<Cinemachine.ICinemachineCamera,object> mExtraState; // 0x28

        // ── Methods ──
        public void get_VirtualCamera(){} // RVA: 0x7FFD4FC63A80
        public void Awake(){} // RVA: 0x7FFD4FC63BC0
        public void OnEnable(){} // RVA: 0x7FFD4E341310
        public void OnDestroy(){} // RVA: 0x7FFD4FC63BE0
        public void EnsureStarted(){} // RVA: 0x7FFD4FC63BC0
        public void ConnectToVcam(){} // RVA: 0x7FFD4FC63C00
        public void PrePipelineMutateCameraStateCallback(){} // RVA: 0x7FFD4E341310
        public void InvokePostPipelineStageCallback(){} // RVA: 0x7FFD4FC63E80
        public void PostPipelineStageCallback(){}
        public void OnTargetObjectWarped(){} // RVA: 0x7FFD4E341310
        public void ForceCameraPosition(){} // RVA: 0x7FFD4E341310
        public void OnTransitionFromCamera(){} // RVA: 0x7FFD4E341320
        public void GetMaxDampTime(){} // RVA: 0x7FFD4EB632E0
        public void get_RequiresUserInput(){} // RVA: 0x7FFD4E341320
        public void GetExtraState(){} // RVA: 0x7FFD4E2ADC40
        public void GetAllExtraStates(){} // RVA: 0x7FFD4E078E90
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class CinemachineExternalCamera : CinemachineVirtualCameraBase
    {
        public UnityEngine.Transform State; // 0xA8
        public UnityEngine.Camera LookAt; // 0xB0
        public Cinemachine.CameraState Follow; // 0xB8
        public UnityEngine.Transform <Follow>k__BackingField; // 0x1A0
        public 0x6658AE40 m_BlendHint; // 0x1A8

        // ── Methods ──
        public void get_State(){} // RVA: 0x7FFD4FC24E00
        public void get_LookAt(){} // RVA: 0x7FFD4E96B1A0
        public void set_LookAt(){} // RVA: 0x7FFD4E76B370
        public void get_Follow(){} // RVA: 0x7FFD4E96E2E0
        public void set_Follow(){} // RVA: 0x7FFD4EDC8AF0
        public void InternalUpdateCameraState(){} // RVA: 0x7FFD4FC24EA0
        public void .ctor(){} // RVA: 0x7FFD4FC25AC0
    }

    public class CinemachineFixedSignal : SignalSourceAsset
    {
        public UnityEngine.AnimationCurve SignalDuration; // 0x18
        public UnityEngine.AnimationCurve m_YCurve; // 0x20
        public UnityEngine.AnimationCurve m_ZCurve; // 0x28

        // ── Methods ──
        public void get_SignalDuration(){} // RVA: 0x7FFD4FC75E10
        public void AxisDuration(){} // RVA: 0x7FFD4FC75E70
        public void GetSignal(){} // RVA: 0x7FFD4FC75F70
        public void AxisValue(){} // RVA: 0x7FFD4FC76150
        public void .ctor(){} // RVA: 0x7FFD4E54F5F0
    }

    public class CinemachineFollowZoom : CinemachineExtension
    {
        public float m_Width; // 0x30
        public float m_Damping; // 0x34
        public float m_MinFOV; // 0x38
        public float m_MaxFOV; // 0x3C

        // ── Methods ──
        public void OnValidate(){} // RVA: 0x7FFD4FC25C90
        public void GetMaxDampTime(){} // RVA: 0x7FFD4E40B630
        public void PostPipelineStageCallback(){} // RVA: 0x7FFD4FC25CF0
        public void .ctor(){} // RVA: 0x7FFD4FC260E0
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
        public 0x66589840 m_GroupFramingMode; // 0x80
        public 0x66589898 m_AdjustmentMode; // 0x84
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
        public void get_SoftGuideRect(){} // RVA: 0x7FFD4FC459F0
        public void set_SoftGuideRect(){} // RVA: 0x7FFD4FC45A40
        public void get_HardGuideRect(){} // RVA: 0x7FFD4FC45B00
        public void set_HardGuideRect(){} // RVA: 0x7FFD4FC45B80
        public void OnValidate(){} // RVA: 0x7FFD4FC45BF0
        public void get_IsValid(){} // RVA: 0x7FFD4FC45CE0
        public void get_Stage(){} // RVA: 0x7FFD4E919180
        public void get_BodyAppliesAfterAim(){} // RVA: 0x7FFD4E426850
        public void get_TrackedPoint(){} // RVA: 0x7FFD4FC45E00
        public void set_TrackedPoint(){} // RVA: 0x7FFD4FC45E20
        public void OnTargetObjectWarped(){} // RVA: 0x7FFD4FC45E40
        public void ForceCameraPosition(){} // RVA: 0x7FFD4FC46000
        public void GetMaxDampTime(){} // RVA: 0x7FFD4FC46030
        public void OnTransitionFromCamera(){} // RVA: 0x7FFD4FC46050
        public void ScreenToOrtho(){} // RVA: 0x7FFD4FC46280
        public void OrthoOffsetToScreenBounds(){} // RVA: 0x7FFD4FC46350
        public void get_LastBounds(){} // RVA: 0x7FFD4FC46460
        public void set_LastBounds(){} // RVA: 0x7FFD4FC46480
        public void get_LastBoundsMatrix(){} // RVA: 0x7FFD4FC464A0
        public void set_LastBoundsMatrix(){} // RVA: 0x7FFD4FC464D0
        public void MutateCameraState(){} // RVA: 0x7FFD4FC46500
        public void GetTargetHeight(){} // RVA: 0x7FFD4FC480B0
        public void ComputeGroupBounds(){} // RVA: 0x7FFD4FC482B0
        public void GetScreenSpaceGroupBoundingBox(){} // RVA: 0x7FFD4FC48AE0
        public void .ctor(){} // RVA: 0x7FFD4FC492F0
    }

    public class CinemachineFreeLook : CinemachineVirtualCameraBase
    {
        public UnityEngine.Transform RigsAreCreated; // 0xA8
        public UnityEngine.Transform RigNames; // 0xB0
        public bool PreviousStateIsValid; // 0xB8
        public Cinemachine.LensSettings State; // 0xBC
        public TransitionParams LookAt; // 0xF0
        public 0x6658AE40 Follow; // 0x100
        public Cinemachine.AxisState m_YAxis; // 0x108
        public Recentering m_YAxisRecentering; // 0x178
        public Cinemachine.AxisState m_XAxis; // 0x198
        public Heading m_Heading; // 0x208
        public Recentering m_RecenterToTargetHeading; // 0x214
        public 0x66589EC8 m_BindingMode; // 0x234
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
        public void OnValidate(){} // RVA: 0x7FFD4FC26140
        public void GetRig(){} // RVA: 0x7FFD4FC26430
        public void get_RigsAreCreated(){} // RVA: 0x7FFD4FC26490
        public void get_RigNames(){} // RVA: 0x7FFD4FC264B0
        public void OnEnable(){} // RVA: 0x7FFD4FC26570
        public void UpdateInputAxisProvider(){} // RVA: 0x7FFD4FC26790
        public void OnDestroy(){} // RVA: 0x7FFD4FC26950
        public void OnTransformChildrenChanged(){} // RVA: 0x7FFD4FC26B60
        public void Reset(){} // RVA: 0x7FFD4FC26BC0
        public void get_PreviousStateIsValid(){} // RVA: 0x7FFD4E55F600
        public void set_PreviousStateIsValid(){} // RVA: 0x7FFD4FC26BE0
        public void get_State(){} // RVA: 0x7FFD4FC26D60
        public void get_LookAt(){} // RVA: 0x7FFD4FC0FAF0
        public void set_LookAt(){} // RVA: 0x7FFD4E76B370
        public void get_Follow(){} // RVA: 0x7FFD4FC0FB00
        public void set_Follow(){} // RVA: 0x7FFD4E3AC050
        public void IsLiveChild(){} // RVA: 0x7FFD4FC26E00
        public void OnTargetObjectWarped(){} // RVA: 0x7FFD4FC26F10
        public void ForceCameraPosition(){} // RVA: 0x7FFD4FC26FF0
        public void InternalUpdateCameraState(){} // RVA: 0x7FFD4FC27310
        public void OnTransitionFromCamera(){} // RVA: 0x7FFD4FC27E60
        public void RequiresUserInput(){} // RVA: 0x7FFD4E426850
        public void GetYAxisClosestValue(){} // RVA: 0x7FFD4FC28370
        public void SteepestDescent(){} // RVA: 0x7FFD4FC28AE0
        public void InvalidateRigCache(){} // RVA: 0x7FFD4FC26B60
        public void DestroyRigs(){} // RVA: 0x7FFD4FC28D30
        public void CreateRigs(){} // RVA: 0x7FFD4FC29480
        public void UpdateRigCache(){} // RVA: 0x7FFD4FC2A0F0
        public void LocateExistingRigs(){} // RVA: 0x7FFD4FC2A680
        public void UpdateXAxisHeading(){} // RVA: 0x7FFD4FC2AD40
        public void PushSettingsToRigs(){} // RVA: 0x7FFD4FC2B000
        public void GetYAxisValue(){} // RVA: 0x7FFD4FC2B7A0
        public void CalculateNewState(){} // RVA: 0x7FFD4FC2B7D0
        public void GetLocalPositionForCameraFromInput(){} // RVA: 0x7FFD4FC2BA80
        public void UpdateCachedSpline(){} // RVA: 0x7FFD4FC2BD30
        public void OnBeforeSerialize(){} // RVA: 0x7FFD4FC2C390
        public void .ctor(){} // RVA: 0x7FFD4FC2C470
        public void <SteepestDescent>g__AngleFunction|47_0(){} // RVA: 0x7FFD4FC2CB40
        public void <SteepestDescent>g__SlopeOfAngleFunction|47_1(){} // RVA: 0x7FFD4FC2CC10
        public void <SteepestDescent>g__InitialGuess|47_2(){} // RVA: 0x7FFD4FC2CC80
        public void <SteepestDescent>g__ChooseBestAngle|47_3(){} // RVA: 0x7FFD4FC2CD90
    }

    public class CinemachineGroupComposer : CinemachineComposer
    {
        public float LastBounds; // 0x100
        public 0x66589948 LastBoundsMatrix; // 0x104
        public float m_FrameDamping; // 0x108
        public 0x665899A0 m_AdjustmentMode; // 0x10C
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
        public void OnValidate(){} // RVA: 0x7FFD4FC494A0
        public void get_LastBounds(){} // RVA: 0x7FFD4FC49570
        public void set_LastBounds(){} // RVA: 0x7FFD4FC49590
        public void get_LastBoundsMatrix(){} // RVA: 0x7FFD4FC495B0
        public void set_LastBoundsMatrix(){} // RVA: 0x7FFD4FC495E0
        public void GetMaxDampTime(){} // RVA: 0x7FFD4FC49610
        public void MutateCameraState(){} // RVA: 0x7FFD4FC49630
        public void GetTargetHeight(){} // RVA: 0x7FFD4FC4A7A0
        public void GetScreenSpaceGroupBoundingBox(){} // RVA: 0x7FFD4FC4A9E0
        public void .ctor(){} // RVA: 0x7FFD4FC4AF70
    }

    public class CinemachineHardLockToTarget : CinemachineComponentBase
    {
        public float IsValid; // 0x28
        public UnityEngine.Vector3 Stage; // 0x2C

        // ── Methods ──
        public void get_IsValid(){} // RVA: 0x7FFD4FC4AFF0
        public void get_Stage(){} // RVA: 0x7FFD4E919180
        public void GetMaxDampTime(){} // RVA: 0x7FFD4E420210
        public void MutateCameraState(){} // RVA: 0x7FFD4FC4B110
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class CinemachineHardLookAt : CinemachineComponentBase
    {
        public object IsValid;
        public object Stage;

        // ── Methods ──
        public void get_IsValid(){} // RVA: 0x7FFD4FC4B2E0
        public void get_Stage(){} // RVA: 0x7FFD4E433AF0
        public void MutateCameraState(){} // RVA: 0x7FFD4FC4B400
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class CinemachineImpulseChannelPropertyAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class CinemachineImpulseDefinition : Object
    {
        public int ImpulseCurve; // 0x10
        public 0x6658BC58 m_ImpulseShape; // 0x14
        public UnityEngine.AnimationCurve m_CustomImpulseShape; // 0x18
        public float m_ImpulseDuration; // 0x20
        public 0x6658BCB0 m_ImpulseType; // 0x24
        public float m_DissipationRate; // 0x28
        public Cinemachine.SignalSourceAsset m_RawSignal; // 0x30
        public float m_AmplitudeGain; // 0x38
        public float m_FrequencyGain; // 0x3C
        public 0x6658BD08 m_RepeatMode; // 0x40
        public bool m_Randomize; // 0x44
        public EnvelopeDefinition m_TimeEnvelope; // 0x48
        public float m_ImpactRadius; // 0x68
        public 0x6658C020 m_DirectionMode; // 0x6C
        public 0x6658C078 m_DissipationMode; // 0x70
        public float m_DissipationDistance; // 0x74
        public float m_PropagationSpeed; // 0x78
        public UnityEngine.AnimationCurve[] sStandardShapes;

        // ── Methods ──
        public void OnValidate(){} // RVA: 0x7FFD4FC761D0
        public void CreateStandardShapes(){} // RVA: 0x7FFD4FC762C0
        public void GetStandardCurve(){} // RVA: 0x7FFD4FC76EC0
        public void get_ImpulseCurve(){} // RVA: 0x7FFD4FC76F40
        public void CreateEvent(){} // RVA: 0x7FFD4FC77050
        public void CreateAndReturnEvent(){} // RVA: 0x7FFD4FC77090
        public void LegacyCreateAndReturnEvent(){} // RVA: 0x7FFD4FC772E0
        public void .ctor(){} // RVA: 0x7FFD4FC776D0
    }

    public class CinemachineImpulseDefinitionPropertyAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class CinemachineImpulseEnvelopePropertyAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class CinemachineImpulseListener : CinemachineExtension
    {
        public 0x6658A550 m_ApplyAfter; // 0x30
        public int m_ChannelMask; // 0x34
        public float m_Gain; // 0x38
        public bool m_Use2DDistance; // 0x3C
        public bool m_UseCameraSpace; // 0x3D
        public ImpulseReaction m_ReactionSettings; // 0x40

        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFD4FC780E0
        public void PostPipelineStageCallback(){} // RVA: 0x7FFD4FC781A0
        public void .ctor(){} // RVA: 0x7FFD4FC78780
    }

    public class CinemachineImpulseManager : Object
    {
        public Cinemachine.CinemachineImpulseManager Instance;
        public float CurrentTime;
        public System.Collections.Generic.List`1<ImpulseEvent> m_ExpiredEvents; // 0x10
        public System.Collections.Generic.List`1<ImpulseEvent> m_ActiveEvents; // 0x18
        public bool IgnoreTimeScale; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void get_Instance(){} // RVA: 0x7FFD4FC78E90
        public void InitializeModule(){} // RVA: 0x7FFD4FC78F50
        public void EvaluateDissipationScale(){} // RVA: 0x7FFD4FC79080
        public void GetImpulseAt(){} // RVA: 0x7FFD4FC79180
        public void get_CurrentTime(){} // RVA: 0x7FFD4FC79690
        public void NewImpulseEvent(){} // RVA: 0x7FFD4FC79730
        public void AddImpulseEvent(){} // RVA: 0x7FFD4FC79830
        public void Clear(){} // RVA: 0x7FFD4FC79930
    }

    public class CinemachineImpulseSource : MonoBehaviour
    {
        public Cinemachine.CinemachineImpulseDefinition m_ImpulseDefinition; // 0x20
        public UnityEngine.Vector3 m_DefaultVelocity; // 0x28

        // ── Methods ──
        public void OnValidate(){} // RVA: 0x7FFD4FC7A7D0
        public void Reset(){} // RVA: 0x7FFD4FC7A8E0
        public void GenerateImpulseAtPositionWithVelocity(){} // RVA: 0x7FFD4FC7AAD0
        public void GenerateImpulseWithVelocity(){} // RVA: 0x7FFD4FC7AB20
        public void GenerateImpulseWithForce(){} // RVA: 0x7FFD4FC7AC40
        public void GenerateImpulse(){} // RVA: 0x7FFD4FC7AC40 | overloaded x3
        public void GenerateImpulseAt(){} // RVA: 0x7FFD4FC7AAD0
        public void .ctor(){} // RVA: 0x7FFD4FC7ADE0
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
        public void Reset(){} // RVA: 0x7FFD4FC7AF00
        public void OnEnable(){} // RVA: 0x7FFD4FC7AFB0
        public void Update(){} // RVA: 0x7FFD4FC7B040
        public void LateUpdate(){} // RVA: 0x7FFD4FC7B4B0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
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
        public void Validate(){} // RVA: 0x7FFD4FC57460
        public void Update(){} // RVA: 0x7FFD4FC64230 | overloaded x2
        public void ClampValue(){} // RVA: 0x7FFD4FC642A0
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
        public void GetAxisValue(){} // RVA: 0x7FFD4FC722E0
        public void ResolveForPlayer(){} // RVA: 0x7FFD4FC72400
        public void OnDisable(){} // RVA: 0x7FFD4EFD6540
        public void .ctor(){} // RVA: 0x7FFD4FC72B60
        public void <ResolveForPlayer>g__GetFirstMatch|7_0(){} // RVA: 0x7FFD4FC72BB0
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
        public void GetWeight(){} // RVA: 0x7FFD4FC2D260 | overloaded x2
        public void SetWeight(){} // RVA: 0x7FFD4FC2D5A0 | overloaded x2
        public void get_LiveChild(){} // RVA: 0x7FFD4E969F30
        public void set_LiveChild(){} // RVA: 0x7FFD4EDC7790
        public void get_State(){} // RVA: 0x7FFD4FC2D870
        public void get_LookAt(){} // RVA: 0x7FFD4E964330
        public void set_LookAt(){} // RVA: 0x7FFD4EDCC050
        public void get_Follow(){} // RVA: 0x7FFD4E9622B0
        public void set_Follow(){} // RVA: 0x7FFD4EDCD110
        public void OnTargetObjectWarped(){} // RVA: 0x7FFD4FC2D910
        public void ForceCameraPosition(){} // RVA: 0x7FFD4FC2D9F0
        public void OnEnable(){} // RVA: 0x7FFD4FC2DB80
        public void OnTransformChildrenChanged(){} // RVA: 0x7FFD4FC2DBA0
        public void OnValidate(){} // RVA: 0x7FFD4FC2DBB0
        public void IsLiveChild(){} // RVA: 0x7FFD4FC2DC60
        public void get_ChildCameras(){} // RVA: 0x7FFD4FC2DD00
        public void InvalidateListOfChildren(){} // RVA: 0x7FFD4FC2DD20
        public void ValidateListOfChildren(){} // RVA: 0x7FFD4FC2DE40
        public void OnTransitionFromCamera(){} // RVA: 0x7FFD4FC2E2E0
        public void InternalUpdateCameraState(){} // RVA: 0x7FFD4FC2E440
        public void .ctor(){} // RVA: 0x7FFD4FC2EB40
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
        public void OnValidate(){} // RVA: 0x7FFD4FC4B7C0
        public void UpdateHeading(){} // RVA: 0x7FFD4FC4B9F0 | overloaded x2
        public void OnEnable(){} // RVA: 0x7FFD4FC4BB90
        public void UpdateInputAxisProvider(){} // RVA: 0x7FFD4FC4BDB0
        public void OnTargetObjectWarped(){} // RVA: 0x7FFD4FC4BF20
        public void ForceCameraPosition(){} // RVA: 0x7FFD4FC4C220
        public void OnTransitionFromCamera(){} // RVA: 0x7FFD4FC4C380
        public void GetAxisClosestValue(){} // RVA: 0x7FFD4FC4C5C0
        public void MutateCameraState(){} // RVA: 0x7FFD4FC4CD30
        public void GetTargetCameraPosition(){} // RVA: 0x7FFD4FC4DCD0
        public void get_RequiresUserInput(){} // RVA: 0x7FFD4E426850
        public void GetTargetHeading(){} // RVA: 0x7FFD4FC4E120
        public void .ctor(){} // RVA: 0x7FFD4FC4EA90
    }

    public class CinemachinePOV : CinemachineComponentBase
    {
        public 0x66589CB8 IsValid; // 0x28
        public Cinemachine.AxisState Stage; // 0x30
        public Recentering RequiresUserInput; // 0xA0
        public Cinemachine.AxisState m_HorizontalAxis; // 0xC0
        public Recentering m_HorizontalRecentering; // 0x130
        public bool m_ApplyBeforeBody; // 0x150
        public UnityEngine.Quaternion m_PreviousCameraRotation; // 0x154

        // ── Methods ──
        public void get_IsValid(){} // RVA: 0x7FFD4E3A7DE0
        public void get_Stage(){} // RVA: 0x7FFD4E433AF0
        public void OnValidate(){} // RVA: 0x7FFD4FC4F280
        public void OnEnable(){} // RVA: 0x7FFD4FC4F390
        public void UpdateInputAxisProvider(){} // RVA: 0x7FFD4FC4F3A0
        public void PrePipelineMutateCameraState(){} // RVA: 0x7FFD4E341310
        public void MutateCameraState(){} // RVA: 0x7FFD4FC4F670
        public void GetRecenterTarget(){} // RVA: 0x7FFD4FC4FE30
        public void NormalizeAngle(){} // RVA: 0x7FFD4FC502E0
        public void ForceCameraPosition(){} // RVA: 0x7FFD4FC50310
        public void OnTransitionFromCamera(){} // RVA: 0x7FFD4FC50330
        public void get_RequiresUserInput(){} // RVA: 0x7FFD4E426850
        public void SetAxesForRotation(){} // RVA: 0x7FFD4FC505A0
        public void .ctor(){} // RVA: 0x7FFD4FC51090
    }

    public class CinemachinePath : CinemachinePathBase
    {
        public bool MinPos; // 0x50
        public Waypoint[] MaxPos; // 0x58

        // ── Methods ──
        public void get_MinPos(){} // RVA: 0x7FFD4EB632E0
        public void get_MaxPos(){} // RVA: 0x7FFD4FC2ED60
        public void get_Looped(){} // RVA: 0x7FFD4E3FB8E0
        public void Reset(){} // RVA: 0x7FFD4FC2EDA0
        public void OnValidate(){} // RVA: 0x7FFD4EB28F70
        public void get_DistanceCacheSampleStepsPerSegment(){} // RVA: 0x7FFD4E4FBBE0
        public void GetBoundingIndices(){} // RVA: 0x7FFD4FC2EF60
        public void EvaluateLocalPosition(){} // RVA: 0x7FFD4FC2F050
        public void EvaluateLocalTangent(){} // RVA: 0x7FFD4FC2F3A0
        public void EvaluateLocalOrientation(){} // RVA: 0x7FFD4FC2F600
        public void GetRoll(){} // RVA: 0x7FFD4FC2FA20
        public void RollAroundForward(){} // RVA: 0x7FFD4FC2FB50
        public void .ctor(){} // RVA: 0x7FFD4FC2FBA0
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
        public void get_MinPos(){} // RVA: 0x7FFD4E08D880
        public void get_MaxPos(){} // RVA: 0x7FFD4E08D880
        public void get_Looped(){} // RVA: 0x7FFD4E079D00
        public void StandardizePos(){} // RVA: 0x7FFD4FC64310
        public void EvaluatePosition(){} // RVA: 0x7FFD4FC64400
        public void EvaluateTangent(){} // RVA: 0x7FFD4FC64520
        public void EvaluateOrientation(){} // RVA: 0x7FFD4FC64640
        public void EvaluateLocalPosition(){}
        public void EvaluateLocalTangent(){}
        public void EvaluateLocalOrientation(){}
        public void FindClosestPoint(){} // RVA: 0x7FFD4FC648B0
        public void MinUnit(){} // RVA: 0x7FFD4FC64D00
        public void MaxUnit(){} // RVA: 0x7FFD4FC64D30
        public void StandardizeUnit(){} // RVA: 0x7FFD4FC64D60
        public void EvaluatePositionAtUnit(){} // RVA: 0x7FFD4FC64E10
        public void EvaluateTangentAtUnit(){} // RVA: 0x7FFD4FC64E70
        public void EvaluateOrientationAtUnit(){} // RVA: 0x7FFD4FC64ED0
        public void get_DistanceCacheSampleStepsPerSegment(){} // RVA: 0x7FFD4E079960
        public void InvalidateDistanceCache(){} // RVA: 0x7FFD4FC64F30
        public void DistanceCacheIsValid(){} // RVA: 0x7FFD4FC64FE0
        public void get_PathLength(){} // RVA: 0x7FFD4FC65080
        public void StandardizePathDistance(){} // RVA: 0x7FFD4FC650F0
        public void ToNativePathUnits(){} // RVA: 0x7FFD4FC651B0
        public void FromPathNativeUnits(){} // RVA: 0x7FFD4FC65330
        public void ResamplePath(){} // RVA: 0x7FFD4FC65450
        public void .ctor(){} // RVA: 0x7FFD4FC65900
    }

    public class CinemachinePipeline : MonoBehaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class CinemachinePixelPerfect : MonoBehaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class CinemachineSameAsFollowTarget : CinemachineComponentBase
    {
        public float IsValid; // 0x28
        public UnityEngine.Quaternion Stage; // 0x2C

        // ── Methods ──
        public void get_IsValid(){} // RVA: 0x7FFD4FC513F0
        public void get_Stage(){} // RVA: 0x7FFD4E433AF0
        public void GetMaxDampTime(){} // RVA: 0x7FFD4E420210
        public void MutateCameraState(){} // RVA: 0x7FFD4FC51510
        public void .ctor(){} // RVA: 0x7FFD4FC51850
    }

    public class CinemachineSmoothPath : CinemachinePathBase
    {
        public bool MinPos; // 0x50
        public Waypoint[] MaxPos; // 0x58
        public Waypoint[] Looped; // 0x60
        public Waypoint[] DistanceCacheSampleStepsPerSegment; // 0x68
        public bool m_IsLoopedCache; // 0x70

        // ── Methods ──
        public void get_MinPos(){} // RVA: 0x7FFD4EB632E0
        public void get_MaxPos(){} // RVA: 0x7FFD4FC2ED60
        public void get_Looped(){} // RVA: 0x7FFD4E3FB8E0
        public void get_DistanceCacheSampleStepsPerSegment(){} // RVA: 0x7FFD4E4FBBE0
        public void OnValidate(){} // RVA: 0x7FFD4EB28F70
        public void Reset(){} // RVA: 0x7FFD4FC2FD40
        public void InvalidateDistanceCache(){} // RVA: 0x7FFD4FC2FEF0
        public void UpdateControlPoints(){} // RVA: 0x7FFD4FC30040
        public void GetBoundingIndices(){} // RVA: 0x7FFD4FC303B0
        public void EvaluateLocalPosition(){} // RVA: 0x7FFD4FC30490
        public void EvaluateLocalTangent(){} // RVA: 0x7FFD4FC30820
        public void EvaluateLocalOrientation(){} // RVA: 0x7FFD4FC30AF0
        public void RollAroundForward(){} // RVA: 0x7FFD4FC2FB50
        public void .ctor(){} // RVA: 0x7FFD4FC31000
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
        public void get_Description(){} // RVA: 0x7FFD4FC31130
        public void get_LiveChild(){} // RVA: 0x7FFD4E751F50
        public void set_LiveChild(){} // RVA: 0x7FFD4E8C4860
        public void IsLiveChild(){} // RVA: 0x7FFD4FC31270
        public void get_State(){} // RVA: 0x7FFD4FC312A0
        public void get_LookAt(){} // RVA: 0x7FFD4FC0FAF0
        public void set_LookAt(){} // RVA: 0x7FFD4E76B370
        public void get_Follow(){} // RVA: 0x7FFD4FC0FB00
        public void set_Follow(){} // RVA: 0x7FFD4E3AC050
        public void OnTargetObjectWarped(){} // RVA: 0x7FFD4FC31340
        public void ForceCameraPosition(){} // RVA: 0x7FFD4FC31420
        public void OnTransitionFromCamera(){} // RVA: 0x7FFD4FC315B0
        public void InternalUpdateCameraState(){} // RVA: 0x7FFD4FC316C0
        public void OnEnable(){} // RVA: 0x7FFD4FC31FB0
        public void OnDisable(){} // RVA: 0x7FFD4FC322C0
        public void OnTransformChildrenChanged(){} // RVA: 0x7FFD4FC32440
        public void OnGuiHandler(){} // RVA: 0x7FFD4FC32450
        public void get_ChildCameras(){} // RVA: 0x7FFD4FC325C0
        public void get_IsBlending(){} // RVA: 0x7FFD4FC325E0
        public void get_ActiveBlend(){} // RVA: 0x7FFD4E9613D0
        public void CreateFakeHash(){} // RVA: 0x7FFD4FC325F0
        public void LookupFakeHash(){} // RVA: 0x7FFD4FC326B0
        public void InvalidateListOfChildren(){} // RVA: 0x7FFD4FC32A60
        public void UpdateListOfChildren(){} // RVA: 0x7FFD4FC32B20
        public void ValidateInstructions(){} // RVA: 0x7FFD4FC32EC0
        public void ChooseCurrentCamera(){} // RVA: 0x7FFD4FC33500
        public void GetClipHash(){} // RVA: 0x7FFD4FC33DA0
        public void LookupBlend(){} // RVA: 0x7FFD4FC33F30
        public void .ctor(){} // RVA: 0x7FFD4FC341A0
    }

    public class CinemachineStoryboard : CinemachineExtension
    {
        public bool CanvasName;
        public bool m_ShowImage; // 0x30
        public UnityEngine.Texture m_Image; // 0x38
        public 0x66589210 m_Aspect; // 0x40
        public float m_Alpha; // 0x44
        public UnityEngine.Vector2 m_Center; // 0x48
        public UnityEngine.Vector3 m_Rotation; // 0x50
        public UnityEngine.Vector2 m_Scale; // 0x5C
        public bool m_SyncScale; // 0x64
        public bool m_MuteCamera; // 0x65
        public float m_SplitView; // 0x68
        public 0x665892C0 m_RenderMode; // 0x6C
        public int m_SortingOrder; // 0x70
        public float m_PlaneDistance; // 0x74
        public System.Collections.Generic.List`1<CanvasInfo> mCanvasInfo; // 0x78

        // ── Methods ──
        public void PostPipelineStageCallback(){} // RVA: 0x7FFD4FC344E0
        public void UpdateRenderCanvas(){} // RVA: 0x7FFD4FC346F0
        public void ConnectToVcam(){} // RVA: 0x7FFD4FC34940
        public void get_CanvasName(){} // RVA: 0x7FFD4FC34B10
        public void CameraUpdatedCallback(){} // RVA: 0x7FFD4FC34C40
        public void LocateMyCanvas(){} // RVA: 0x7FFD4FC34FE0
        public void CreateCanvas(){} // RVA: 0x7FFD4FC35900
        public void DestroyCanvas(){} // RVA: 0x7FFD4FC36430
        public void PlaceImage(){} // RVA: 0x7FFD4FC367B0
        public void StaticBlendingHandler(){} // RVA: 0x7FFD4FC373E0
        public void InitializeModule(){} // RVA: 0x7FFD4FC377C0
        public void .ctor(){} // RVA: 0x7FFD4FC37930
    }

    public class CinemachineTargetGroup : MonoBehaviour
    {
        public 0x66589420 Transform; // 0x20
        public 0x66589478 BoundingBox; // 0x24
        public 0x665894D0 Sphere; // 0x28
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
        public void OnValidate(){} // RVA: 0x7FFD4FC37B00
        public void Reset(){} // RVA: 0x7FFD4FC37BA0
        public void get_Transform(){} // RVA: 0x7FFD4E7DCDF0
        public void get_BoundingBox(){} // RVA: 0x7FFD4FC37C30
        public void set_BoundingBox(){} // RVA: 0x7FFD4FC37CC0
        public void get_Sphere(){} // RVA: 0x7FFD4FC37CE0
        public void set_Sphere(){} // RVA: 0x7FFD4E451DC0
        public void get_IsEmpty(){} // RVA: 0x7FFD4FC37D60
        public void AddMember(){} // RVA: 0x7FFD4FC37E00
        public void RemoveMember(){} // RVA: 0x7FFD4FC380E0
        public void FindMember(){} // RVA: 0x7FFD4FC383F0
        public void GetWeightedBoundsForMember(){} // RVA: 0x7FFD4FC38580
        public void GetViewSpaceBoundingBox(){} // RVA: 0x7FFD4FC38760
        public void get_CachedCountIsValid(){} // RVA: 0x7FFD4FC38F20
        public void IndexIsValid(){} // RVA: 0x7FFD4FC38F90
        public void WeightedMemberBoundsForValidMember(){} // RVA: 0x7FFD4FC38FB0
        public void DoUpdate(){} // RVA: 0x7FFD4FC39170
        public void UpdateMemberValidity(){} // RVA: 0x7FFD4FC394C0
        public void CalculateAveragePosition(){} // RVA: 0x7FFD4FC39850
        public void CalculateBoundingBox(){} // RVA: 0x7FFD4FC39AE0
        public void CalculateBoundingSphere(){} // RVA: 0x7FFD4FC3A050
        public void CalculateAverageOrientation(){} // RVA: 0x7FFD4FC3A450
        public void FixedUpdate(){} // RVA: 0x7FFD4FC3ABF0
        public void Update(){} // RVA: 0x7FFD4FC3AC00
        public void LateUpdate(){} // RVA: 0x7FFD4FC3ACA0
        public void GetViewSpaceAngularBounds(){} // RVA: 0x7FFD4FC3ACB0
        public void .ctor(){} // RVA: 0x7FFD4FC3B9F0
    }

    public class CinemachineTrackedDolly : CinemachineComponentBase
    {
        public Cinemachine.CinemachinePathBase IsValid; // 0x28
        public float Stage; // 0x30
        public 0x6658A918 AngularDamping; // 0x34
        public UnityEngine.Vector3 m_PathOffset; // 0x38
        public float m_XDamping; // 0x44
        public float m_YDamping; // 0x48
        public float m_ZDamping; // 0x4C
        public 0x66589DC0 m_CameraUp; // 0x50
        public float m_PitchDamping; // 0x54
        public float m_YawDamping; // 0x58
        public float m_RollDamping; // 0x5C
        public AutoDolly m_AutoDolly; // 0x60
        public float m_PreviousPathPosition; // 0x70
        public UnityEngine.Quaternion m_PreviousOrientation; // 0x74
        public UnityEngine.Vector3 m_PreviousCameraPosition; // 0x84

        // ── Methods ──
        public void get_IsValid(){} // RVA: 0x7FFD4FC518D0
        public void get_Stage(){} // RVA: 0x7FFD4E919180
        public void GetMaxDampTime(){} // RVA: 0x7FFD4FC519F0
        public void MutateCameraState(){} // RVA: 0x7FFD4FC51AA0
        public void GetCameraOrientationAtPathPoint(){} // RVA: 0x7FFD4FC52D30
        public void get_AngularDamping(){} // RVA: 0x7FFD4FC53410
        public void .ctor(){} // RVA: 0x7FFD4FC534C0
    }

    public class CinemachineTransposer : CinemachineComponentBase
    {
        public 0x66589EC8 HideOffsetInInspector; // 0x28
        public UnityEngine.Vector3 EffectiveOffset; // 0x2C
        public float IsValid; // 0x38
        public float Stage; // 0x3C
        public float Damping; // 0x40
        public 0x66589F20 AngularDamping; // 0x44
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
        public void OnValidate(){} // RVA: 0x7FFD4FC53620
        public void get_HideOffsetInInspector(){} // RVA: 0x7FFD4E55F600
        public void set_HideOffsetInInspector(){} // RVA: 0x7FFD4ECB2770
        public void get_EffectiveOffset(){} // RVA: 0x7FFD4FC53670
        public void get_IsValid(){} // RVA: 0x7FFD4FC536B0
        public void get_Stage(){} // RVA: 0x7FFD4E919180
        public void GetMaxDampTime(){} // RVA: 0x7FFD4FC537D0
        public void MutateCameraState(){} // RVA: 0x7FFD4FC53860
        public void OnTargetObjectWarped(){} // RVA: 0x7FFD4FC53F40
        public void ForceCameraPosition(){} // RVA: 0x7FFD4FC540B0
        public void InitPrevFrameStateInfo(){} // RVA: 0x7FFD4FC543F0
        public void TrackTarget(){} // RVA: 0x7FFD4FC54650
        public void GetOffsetForMinimumTargetDistance(){} // RVA: 0x7FFD4FC557A0
        public void get_Damping(){} // RVA: 0x7FFD4FC55D40
        public void get_AngularDamping(){} // RVA: 0x7FFD4FC55D80
        public void GetTargetCameraPosition(){} // RVA: 0x7FFD4FC55E60
        public void GetReferenceOrientation(){} // RVA: 0x7FFD4FC56160
        public void .ctor(){} // RVA: 0x7FFD4FC567E0
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
        public void Filter(){} // RVA: 0x7FFD4FC73030
        public void InternalDoTriggerEnter(){} // RVA: 0x7FFD4FC73150
        public void InternalDoTriggerExit(){} // RVA: 0x7FFD4FC732E0
        public void OnTriggerEnter(){} // RVA: 0x7FFD4FC733C0
        public void OnTriggerExit(){} // RVA: 0x7FFD4FC73440
        public void OnCollisionEnter(){} // RVA: 0x7FFD4FC734C0
        public void OnCollisionExit(){} // RVA: 0x7FFD4FC73500
        public void OnTriggerEnter2D(){} // RVA: 0x7FFD4FC733C0
        public void OnTriggerExit2D(){} // RVA: 0x7FFD4FC73440
        public void OnCollisionEnter2D(){} // RVA: 0x7FFD4FC73540
        public void OnCollisionExit2D(){} // RVA: 0x7FFD4FC73580
        public void OnEnable(){} // RVA: 0x7FFD4E341310
        public void .ctor(){} // RVA: 0x7FFD4FC735C0
    }

    public class CinemachineVirtualCamera : CinemachineVirtualCameraBase
    {
        public UnityEngine.Transform State; // 0xA8
        public UnityEngine.Transform LookAt; // 0xB0
        public Cinemachine.LensSettings Follow; // 0xB8
        public TransitionParams m_Transitions; // 0xF0
        public 0x6658AE40 m_LegacyBlendHint; // 0x100
        public string PipelineName;
        public CreatePipelineDelegate CreatePipelineOverride;
        public DestroyPipelineDelegate DestroyPipelineOverride; // 0x8
        public Cinemachine.CameraState m_State; // 0x108
        public Cinemachine.CinemachineComponentBase[] m_ComponentPipeline; // 0x1F0
        public UnityEngine.Transform m_ComponentOwner; // 0x1F8
        public UnityEngine.Transform mCachedLookAtTarget; // 0x200
        public Cinemachine.CinemachineVirtualCameraBase mCachedLookAtTargetVcam; // 0x208

        // ── Methods ──
        public void get_State(){} // RVA: 0x7FFD4FC312A0
        public void get_LookAt(){} // RVA: 0x7FFD4FC0FAF0
        public void set_LookAt(){} // RVA: 0x7FFD4E76B370
        public void get_Follow(){} // RVA: 0x7FFD4FC0FB00
        public void set_Follow(){} // RVA: 0x7FFD4E3AC050
        public void GetMaxDampTime(){} // RVA: 0x7FFD4FC3BBF0
        public void InternalUpdateCameraState(){} // RVA: 0x7FFD4FC3BD60
        public void OnEnable(){} // RVA: 0x7FFD4FC3C240
        public void OnDestroy(){} // RVA: 0x7FFD4FC3C8C0
        public void OnValidate(){} // RVA: 0x7FFD4FC3CC50
        public void OnTransformChildrenChanged(){} // RVA: 0x7FFD4FC3CD30
        public void Reset(){} // RVA: 0x7FFD4FC3CD90
        public void DestroyPipeline(){} // RVA: 0x7FFD4FC3CDB0
        public void CreatePipeline(){} // RVA: 0x7FFD4FC3D4E0
        public void InvalidateComponentPipeline(){} // RVA: 0x7FFD4FC3CD30
        public void GetComponentOwner(){} // RVA: 0x7FFD4FC3D850
        public void GetComponentPipeline(){} // RVA: 0x7FFD4FC3D870
        public void GetCinemachineComponent(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void AddCinemachineComponent(){} // RVA: 0x7FFD4E2ADC40
        public void DestroyCinemachineComponent(){} // RVA: 0x7FFD4E090980
        public void UpdateComponentPipeline(){} // RVA: 0x7FFD4FC3D920
        public void SetFlagsForHiddenChild(){} // RVA: 0x7FFD4FC3E190
        public void CalculateNewState(){} // RVA: 0x7FFD4FC3E340
        public void OnTargetObjectWarped(){} // RVA: 0x7FFD4FC3EE00
        public void ForceCameraPosition(){} // RVA: 0x7FFD4FC3F190
        public void SetStateRawPosition(){} // RVA: 0x7FFD4FC3F410
        public void OnTransitionFromCamera(){} // RVA: 0x7FFD4FC3F430
        public void RequiresUserInput(){} // RVA: 0x7FFD4FC3F940
        public void OnBeforeSerialize(){} // RVA: 0x7FFD4FC3FC00
        public void .ctor(){} // RVA: 0x7FFD4FC3FCE0
    }

    public class CinemachineVirtualCameraBase : MonoBehaviour
    {
        public string[] ValidatingStreamVersion; // 0x20
        public 0x6658A550[] mExtensions; // 0x28
        public int Name; // 0x30
        public bool Description; // 0x34
        public int Priority; // 0x38
        public int VirtualCameraGameObject; // 0x3C
        public int IsValid; // 0x40
        public float State; // 0x44
        public float ParentCamera; // 0x48
        public 0x6658ADE8 LookAt; // 0x4C
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
        public void get_ValidatingStreamVersion(){} // RVA: 0x7FFD4FC65A10
        public void set_ValidatingStreamVersion(){} // RVA: 0x7FFD4E39CCE0
        public void GetMaxDampTime(){} // RVA: 0x7FFD4FC65A80
        public void DetachedFollowTargetDamp(){} // RVA: 0x7FFD4FC65D80 | overloaded x3
        public void DetachedLookAtTargetDamp(){} // RVA: 0x7FFD4FC66050 | overloaded x3
        public void AddExtension(){} // RVA: 0x7FFD4FC66100
        public void RemoveExtension(){} // RVA: 0x7FFD4FC66260
        public void get_mExtensions(){} // RVA: 0x7FFD4E3E20E0
        public void set_mExtensions(){} // RVA: 0x7FFD4E4994D0
        public void InvokePostPipelineStageCallback(){} // RVA: 0x7FFD4FC662C0
        public void InvokePrePipelineMutateCameraStateCallback(){} // RVA: 0x7FFD4FC665B0
        public void InvokeOnTransitionInExtensions(){} // RVA: 0x7FFD4FC66890
        public void get_Name(){} // RVA: 0x7FFD4E563DB0
        public void get_Description(){} // RVA: 0x7FFD4FC66AB0
        public void get_Priority(){} // RVA: 0x7FFD4E7DD4A0
        public void set_Priority(){} // RVA: 0x7FFD4FC02CD0
        public void ApplyPositionBlendMethod(){} // RVA: 0x7FFD4FC66AF0
        public void get_VirtualCameraGameObject(){} // RVA: 0x7FFD4FC66B20
        public void get_IsValid(){} // RVA: 0x7FFD4FC66C30
        public void get_State(){}
        public void get_ParentCamera(){} // RVA: 0x7FFD4FC66D00
        public void IsLiveChild(){} // RVA: 0x7FFD4E341320
        public void get_LookAt(){} // RVA: 0x7FFD4E078E90
        public void set_LookAt(){} // RVA: 0x7FFD4E090A40
        public void get_Follow(){} // RVA: 0x7FFD4E078E90
        public void set_Follow(){} // RVA: 0x7FFD4E090A40
        public void get_PreviousStateIsValid(){} // RVA: 0x7FFD4E55F600
        public void set_PreviousStateIsValid(){} // RVA: 0x7FFD4ECB2770
        public void UpdateCameraState(){} // RVA: 0x7FFD4FC66DA0
        public void InternalUpdateCameraState(){}
        public void OnTransitionFromCamera(){} // RVA: 0x7FFD4FC66E40
        public void OnDestroy(){} // RVA: 0x7FFD4FC66F10
        public void OnTransformParentChanged(){} // RVA: 0x7FFD4FC67040
        public void Start(){} // RVA: 0x7FFD4E4F2D70
        public void RequiresUserInput(){} // RVA: 0x7FFD4FC670E0
        public void EnsureStarted(){} // RVA: 0x7FFD4FC67260
        public void GetInputAxisProvider(){} // RVA: 0x7FFD4FC67320
        public void OnValidate(){} // RVA: 0x7FFD4FC673E0
        public void OnEnable(){} // RVA: 0x7FFD4FC67450
        public void OnDisable(){} // RVA: 0x7FFD4FC677C0
        public void Update(){} // RVA: 0x7FFD4FC67830
        public void UpdateSlaveStatus(){} // RVA: 0x7FFD4FC67840
        public void ResolveLookAt(){} // RVA: 0x7FFD4FC67A20
        public void ResolveFollow(){} // RVA: 0x7FFD4FC67B40
        public void UpdateVcamPoolStatus(){} // RVA: 0x7FFD4FC67C60
        public void MoveToTopOfPrioritySubqueue(){} // RVA: 0x7FFD4FC67E90
        public void OnTargetObjectWarped(){} // RVA: 0x7FFD4FC67EA0
        public void ForceCameraPosition(){} // RVA: 0x7FFD4FC67FA0
        public void GetInheritPosition(){} // RVA: 0x7FFD4FC680B0
        public void CreateBlend(){} // RVA: 0x7FFD4FC681C0
        public void PullStateFromVirtualCamera(){} // RVA: 0x7FFD4FC68620
        public void InvalidateCachedTargets(){} // RVA: 0x7FFD4FC68950
        public void get_FollowTargetChanged(){} // RVA: 0x7FFD4F9E9D50
        public void set_FollowTargetChanged(){} // RVA: 0x7FFD4EBD1910
        public void get_LookAtTargetChanged(){} // RVA: 0x7FFD4FC68B60
        public void set_LookAtTargetChanged(){} // RVA: 0x7FFD4FC68B70
        public void UpdateTargetCache(){} // RVA: 0x7FFD4FC68B80
        public void get_AbstractFollowTargetGroup(){} // RVA: 0x7FFD4E70F410
        public void get_FollowTargetAsVcam(){} // RVA: 0x7FFD4E505600
        public void get_AbstractLookAtTargetGroup(){} // RVA: 0x7FFD4E96DFB0
        public void get_LookAtTargetAsVcam(){} // RVA: 0x7FFD4E70F640
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFD4FC69180
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFD4FC691A0
        public void LegacyUpgrade(){} // RVA: 0x7FFD4E341310
        public void OnBeforeSerialize(){} // RVA: 0x7FFD4E341310
        public void CancelDamping(){} // RVA: 0x7FFD4FC69250
        public void .ctor(){} // RVA: 0x7FFD4FC694B0
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
        public 0x6658B100 <State>k__BackingField; // 0x58
        public float bakeProgress; // 0x5C
        public BakingStateCache m_Cache; // 0x60

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4FC69750
        public void GetBakedSolution(){} // RVA: 0x7FFD4FC69880
        public void get_State(){} // RVA: 0x7FFD4EA4EA40
        public void set_State(){} // RVA: 0x7FFD4EA4EA00
        public void Initialize(){} // RVA: 0x7FFD4FC69CE0
        public void BakeConfiner(){} // RVA: 0x7FFD4FC6A540
        public void <Initialize>g__GetPolygonBoundingBox|24_0(){} // RVA: 0x7FFD4FC6AB90
        public void <Initialize>g__MidPointOfIntRect|24_1(){} // RVA: 0x7FFD4FC6AD50
        public void <BakeConfiner>g__ComputeSkeleton|25_0(){} // RVA: 0x7FFD4FC6AD80
    }

    public class Documentation : Object
    {
        public string BaseURL;
    }

    public class DocumentationSortingAttribute : Attribute
    {
        public 0x6658AD38 Category; // 0x10

        // ── Methods ──
        public void get_Category(){} // RVA: 0x7FFD4E38E5C0
        public void set_Category(){} // RVA: 0x7FFD4E3440C0
        public void .ctor(){} // RVA: 0x7FFD4E3440C0
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
        public void Start(){} // RVA: 0x7FFD4FC744D0
        public void OnValidate(){} // RVA: 0x7FFD4FC74560
        public void Update(){} // RVA: 0x7FFD4FC745D0
        public void UpdateWeights(){} // RVA: 0x7FFD4FC747A0
        public void .ctor(){} // RVA: 0x7FFD4FC74890
    }

    public class ICameraOverrideStack
    {
        public object DefaultWorldUp;

        // ── Methods ──
        public void SetCameraOverride(){}
        public void ReleaseCameraOverride(){} // RVA: 0x7FFD4E090ED0
        public void get_DefaultWorldUp(){} // RVA: 0x7FFD4E0788A0
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
        public void get_Name(){} // RVA: 0x7FFD4E078E90
        public void get_Description(){} // RVA: 0x7FFD4E078E90
        public void get_Priority(){} // RVA: 0x7FFD4E079960
        public void set_Priority(){} // RVA: 0x7FFD4E090ED0
        public void get_LookAt(){} // RVA: 0x7FFD4E078E90
        public void set_LookAt(){} // RVA: 0x7FFD4E090A40
        public void get_Follow(){} // RVA: 0x7FFD4E078E90
        public void set_Follow(){} // RVA: 0x7FFD4E090A40
        public void get_State(){}
        public void get_VirtualCameraGameObject(){} // RVA: 0x7FFD4E078E90
        public void get_IsValid(){} // RVA: 0x7FFD4E079D00
        public void get_ParentCamera(){} // RVA: 0x7FFD4E078E90
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
        public void get_Transform(){} // RVA: 0x7FFD4E078E90
        public void get_BoundingBox(){}
        public void get_Sphere(){}
        public void get_IsEmpty(){} // RVA: 0x7FFD4E079D00
        public void GetViewSpaceBoundingBox(){}
        public void GetViewSpaceAngularBounds(){}
    }

    public class ISignalSource6D
    {
        public object SignalDuration;

        // ── Methods ──
        public void get_SignalDuration(){} // RVA: 0x7FFD4E08D880
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
        public 0x6658B260 ModeOverride; // 0x24
        public UnityEngine.Vector2 LensShift; // 0x28
        public 0x664D98F0 GateFit; // 0x30
        public float FocusDistance; // 0x34
        public UnityEngine.Vector2 m_SensorSize; // 0x38
        public bool m_OrthoFromCamera; // 0x40
        public bool m_PhysicalFromCamera; // 0x41

        // ── Methods ──
        public void get_Orthographic(){} // RVA: 0x7FFD4FC6C300
        public void set_Orthographic(){} // RVA: 0x7FFD4FC6C320
        public void get_SensorSize(){} // RVA: 0x7FFD4F7C2620
        public void set_SensorSize(){} // RVA: 0x7FFD4E7F3BF0
        public void get_Aspect(){} // RVA: 0x7FFD4FC6C330
        public void get_IsPhysicalCamera(){} // RVA: 0x7FFD4FC6C3C0
        public void set_IsPhysicalCamera(){} // RVA: 0x7FFD4FC6C3E0
        public void FromCamera(){} // RVA: 0x7FFD4FC6C3F0
        public void SnapshotCameraReadOnlyProperties(){} // RVA: 0x7FFD4FC6CB90 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFD4FC6CCA0
        public void Lerp(){} // RVA: 0x7FFD4FC6CCF0
        public void Validate(){} // RVA: 0x7FFD4FC6CF50
        public void .cctor(){} // RVA: 0x7FFD4FC6CFD0
    }

    public class LensSettingsPropertyAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class NoSaveDuringPlayAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class NoiseSettings : SignalSourceAsset
    {
        public TransformNoiseParams[] SignalDuration; // 0x18
        public TransformNoiseParams[] OrientationNoise; // 0x20

        // ── Methods ──
        public void GetCombinedFilterResults(){} // RVA: 0x7FFD4FC6D060
        public void get_SignalDuration(){} // RVA: 0x7FFD4EB632E0
        public void GetSignal(){} // RVA: 0x7FFD4FC6D1E0
        public void .ctor(){} // RVA: 0x7FFD4FC6D390
    }

    public class NoiseSettingsPropertyAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class OrbitalTransposerHeadingPropertyAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class RuntimeUtility : Object
    {
        public UnityEngine.RaycastHit[] s_HitBuffer;
        public int[] s_PenetrationIndexBuffer; // 0x8
        public UnityEngine.SphereCollider s_ScratchCollider; // 0x10
        public UnityEngine.GameObject s_ScratchColliderGameObject; // 0x18

        // ── Methods ──
        public void DestroyObject(){} // RVA: 0x7FFD4FC6D5D0
        public void IsPrefab(){} // RVA: 0x7FFD4E341320
        public void RaycastIgnoreTag(){} // RVA: 0x7FFD4FC6D6C0
        public void SphereCastIgnoreTag(){} // RVA: 0x7FFD4FC6DA80
        public void GetScratchCollider(){} // RVA: 0x7FFD4FC6E5F0
        public void DestroyScratchCollider(){} // RVA: 0x7FFD4FC6EB90
        public void NormalizeCurve(){} // RVA: 0x7FFD4FC6EE80
        public void .cctor(){} // RVA: 0x7FFD4FC6F0F0
    }

    public class SaveDuringPlayAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class SignalSourceAsset : ScriptableObject
    {
        public object SignalDuration;

        // ── Methods ──
        public void get_SignalDuration(){} // RVA: 0x7FFD4E08D880
        public void GetSignal(){}
        public void .ctor(){} // RVA: 0x7FFD4E54F5F0
    }

    public class StaticPointVirtualCamera : Object
    {
        public string Name; // 0x10
        public int Description; // 0x18
        public UnityEngine.Transform Priority; // 0x20
        public UnityEngine.Transform LookAt; // 0x28
        public Cinemachine.CameraState Follow; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4FC5E7A0
        public void SetState(){} // RVA: 0x7FFD4FC5E8A0
        public void get_Name(){} // RVA: 0x7FFD4E35C380
        public void set_Name(){} // RVA: 0x7FFD4E342E30
        public void get_Description(){} // RVA: 0x7FFD4FC5E950
        public void get_Priority(){} // RVA: 0x7FFD4E577800
        public void set_Priority(){} // RVA: 0x7FFD4ED4CD10
        public void get_LookAt(){} // RVA: 0x7FFD4E36F0C0
        public void set_LookAt(){} // RVA: 0x7FFD4E36F0D0
        public void get_Follow(){} // RVA: 0x7FFD4E36F130
        public void set_Follow(){} // RVA: 0x7FFD4E342E90
        public void get_State(){} // RVA: 0x7FFD4FC5E990
        public void set_State(){} // RVA: 0x7FFD4FC5EA30
        public void get_VirtualCameraGameObject(){} // RVA: 0x7FFD4E919180
        public void get_IsValid(){} // RVA: 0x7FFD4E426850
        public void get_ParentCamera(){} // RVA: 0x7FFD4E919180
        public void IsLiveChild(){} // RVA: 0x7FFD4E341320
        public void UpdateCameraState(){} // RVA: 0x7FFD4E341310
        public void InternalUpdateCameraState(){} // RVA: 0x7FFD4E341310
        public void OnTransitionFromCamera(){} // RVA: 0x7FFD4E341310
        public void OnTargetObjectWarped(){} // RVA: 0x7FFD4E341310
    }

    public class TagFieldAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class TargetPositionCache : Object
    {
        public bool CacheMode;
        public float IsRecording;
        public 0x6658B520 CurrentPlaybackTimeValid; // 0x4
        public float IsEmpty; // 0x8
        public int CacheTimeRange; // 0xC
        public bool HasCurrentTime; // 0x10
        public System.Collections.Generic.Dictionary`2<UnityEngine.Transform,CacheEntry> m_Cache; // 0x18
        public TimeRange m_CacheTimeRange; // 0x20
        public float kWraparoundSlush;

        // ── Methods ──
        public void get_CacheMode(){} // RVA: 0x7FFD4FC6F240
        public void set_CacheMode(){} // RVA: 0x7FFD4FC6F280
        public void get_IsRecording(){} // RVA: 0x7FFD4FC6F2F0
        public void get_CurrentPlaybackTimeValid(){} // RVA: 0x7FFD4FC6F340
        public void get_IsEmpty(){} // RVA: 0x7FFD4FC6F3D0
        public void get_CacheTimeRange(){} // RVA: 0x7FFD4FC6F420
        public void get_HasCurrentTime(){} // RVA: 0x7FFD4FC6F470
        public void ClearCache(){} // RVA: 0x7FFD4FC6F4D0
        public void CreatePlaybackCurves(){} // RVA: 0x7FFD4FC6F640
        public void GetTargetPosition(){} // RVA: 0x7FFD4FC6F890
        public void GetTargetRotation(){} // RVA: 0x7FFD4FC6FD50
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class UpdateTracker : Object
    {
        public System.Collections.Generic.Dictionary`2<UnityEngine.Transform,UpdateStatus> mUpdateStatus;
        public System.Collections.Generic.List`1<UnityEngine.Transform> sToDelete; // 0x8
        public float mLastUpdateTime; // 0x10

        // ── Methods ──
        public void InitializeModule(){} // RVA: 0x7FFD4FC71560
        public void UpdateTargets(){} // RVA: 0x7FFD4FC715E0
        public void GetPreferredUpdate(){} // RVA: 0x7FFD4FC71AE0
        public void OnUpdate(){} // RVA: 0x7FFD4FC71E50
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void .cctor(){} // RVA: 0x7FFD4FC71F10
    }

    public class VcamTargetPropertyAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

}