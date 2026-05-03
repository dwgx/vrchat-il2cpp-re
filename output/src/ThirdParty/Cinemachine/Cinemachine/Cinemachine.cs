// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Cinemachine.Cinemachine
// Classes: 83
// Methods: 917

namespace ThirdParty.Cinemachine.Cinemachine
{
    public class AxisBase : ValueType
    {
        // ── Methods ──
        public void Validate(){} // RVA: 0x7FFE82AAC240
    }

    public class AxisState : ValueType
    {
        public float Value; // 0x10
        public 0x66623894 m_SpeedMode; // 0x14
        public float m_MaxSpeed; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82A9ECF0
        public void Validate(){} // RVA: 0x7FFE82A9EE60
        public void Reset(){} // RVA: 0x7FFE82A9EEC0
        public void SetInputAxisProvider(){} // RVA: 0x7FFE82A9EED0
        public void get_HasInputProvider(){} // RVA: 0x7FFE82A9EF30
        public void Update(){} // RVA: 0x7FFE82A9EF40
        public void ClampValue(){} // RVA: 0x7FFE82A9F440
        public void MaxSpeedUpdate(){} // RVA: 0x7FFE82A9F4B0
        public void GetMaxSpeed(){} // RVA: 0x7FFE82A9F6F0
        public void get_ValueRangeLocked(){} // RVA: 0x7FFE82A9F7A0
        public void set_ValueRangeLocked(){} // RVA: 0x7FFE82A9F7B0
        public void get_HasRecentering(){} // RVA: 0x7FFE82A9F7C0
        public void set_HasRecentering(){} // RVA: 0x7FFE82A9F7D0
    }

    public class AxisStatePropertyAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class BlendSourceVirtualCamera : Object
    {
        public Cinemachine.CinemachineBlend _blend; // 0x10
        public int _priority; // 0x18
        public UnityEngine.Transform _lookAt; // 0x20
        public UnityEngine.Transform _follow; // 0x28
        public Cinemachine.CameraState _state; // 0x30
        public object field_5; // 0x8C
        public object field_6; // 0x8D
        public object field_7; // 0x8E
        public object field_8; // 0x8F
        public object field_9; // 0x90

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void get_Blend(){} // RVA: 0x7FFE81116380
        public void set_Blend(){} // RVA: 0x7FFE810FCE30
        public void get_Name(){} // RVA: 0x7FFE82AA6EB0
        public void get_Description(){} // RVA: 0x7FFE82AA6EF0
        public void get_Priority(){} // RVA: 0x7FFE813DB630
        public void set_Priority(){} // RVA: 0x7FFE8144DF00
        public void get_LookAt(){} // RVA: 0x7FFE811290C0
        public void set_LookAt(){} // RVA: 0x7FFE811290D0
        public void get_Follow(){} // RVA: 0x7FFE81129130
        public void set_Follow(){} // RVA: 0x7FFE810FCE90
        public void get_State(){} // RVA: 0x7FFE82AA6D30
        public void set_State(){} // RVA: 0x7FFE82AA6DD0
        public void get_VirtualCameraGameObject(){} // RVA: 0x7FFE813240E0
        public void get_IsValid(){} // RVA: 0x7FFE82AA6F40
        public void get_ParentCamera(){} // RVA: 0x7FFE813240E0
        public void IsLiveChild(){} // RVA: 0x7FFE82AA6F60
        public void CalculateNewState(){} // RVA: 0x7FFE82AA6D30
        public void UpdateCameraState(){} // RVA: 0x7FFE82AA6F80
        public void InternalUpdateCameraState(){} // RVA: 0x7FFE810FB310
        public void OnTransitionFromCamera(){} // RVA: 0x7FFE810FB310
        public void OnTargetObjectWarped(){} // RVA: 0x7FFE810FB310
    }

    public class CameraState : ValueType
    {
        public Cinemachine.LensSettings Lens; // 0x10
        public UnityEngine.Vector3 ReferenceUp; // 0x44
        public UnityEngine.Vector3 ReferenceLookAt; // 0x50
        public UnityEngine.Vector3 kNoPoint;
        public UnityEngine.Vector3 RawPosition; // 0x5C
        public UnityEngine.Quaternion RawOrientation; // 0x68
        public UnityEngine.Vector3 PositionDampingBypass; // 0x78

        // ── Methods ──
        public void get_HasLookAt(){} // RVA: 0x7FFE82A9FBB0
        public void get_CorrectedPosition(){} // RVA: 0x7FFE82A9FC10
        public void get_CorrectedOrientation(){} // RVA: 0x7FFE82A9FC60
        public void get_FinalPosition(){} // RVA: 0x7FFE82A9FC10
        public void get_FinalOrientation(){} // RVA: 0x7FFE82A9FDD0
        public void get_Default(){} // RVA: 0x7FFE82AA0090
        public void get_NumCustomBlendables(){} // RVA: 0x7FFE82AA02F0
        public void set_NumCustomBlendables(){} // RVA: 0x7FFE82AA0300
        public void GetCustomBlendable(){} // RVA: 0x7FFE82AA0310
        public void FindCustomBlendable(){} // RVA: 0x7FFE82AA0480
        public void AddCustomBlendable(){} // RVA: 0x7FFE82AA0A00
        public void Lerp(){} // RVA: 0x7FFE82AA0DC0
        public void InterpolateFOV(){} // RVA: 0x7FFE82AA4E20
        public void ApplyPosBlendHint(){} // RVA: 0x7FFE82AA4F70
        public void ApplyRotBlendHint(){} // RVA: 0x7FFE82AA4FF0
        public void InterpolatePosition(){} // RVA: 0x7FFE82AA5040
        public void .cctor(){} // RVA: 0x7FFE82AA5530
    }

    public class Cinemachine3rdPersonAim : CinemachineExtension
    {
        public UnityEngine.LayerMask AimCollisionFilter; // 0x30

        // ── Methods ──
        public void get_AimTarget(){} // RVA: 0x7FFE81161FA0
        public void set_AimTarget(){} // RVA: 0x7FFE81161FC0
        public void OnValidate(){} // RVA: 0x7FFE82A56800
        public void Reset(){} // RVA: 0x7FFE82A56820
        public void OnTransitionFromCamera(){} // RVA: 0x7FFE82A56930
        public void DrawReticle(){} // RVA: 0x7FFE82A56AB0
        public void ComputeLookAtPoint(){} // RVA: 0x7FFE82A56E40
        public void ComputeAimTarget(){} // RVA: 0x7FFE82A57470
        public void PostPipelineStageCallback(){} // RVA: 0x7FFE82A576F0
        public void .ctor(){} // RVA: 0x7FFE82A57A40
    }

    public class Cinemachine3rdPersonFollow : CinemachineComponentBase
    {
        public UnityEngine.Vector3 Damping; // 0x28
        public UnityEngine.Vector3 ShoulderOffset; // 0x34

        // ── Methods ──
        public void OnValidate(){} // RVA: 0x7FFE82A88490
        public void Reset(){} // RVA: 0x7FFE82A88510
        public void OnDestroy(){} // RVA: 0x7FFE82A88580
        public void get_IsValid(){} // RVA: 0x7FFE82A885D0
        public void get_Stage(){} // RVA: 0x7FFE813240E0
        public void GetMaxDampTime(){} // RVA: 0x7FFE82A886F0
        public void MutateCameraState(){} // RVA: 0x7FFE82A88720
        public void OnTargetObjectWarped(){} // RVA: 0x7FFE82A887B0
        public void PositionCamera(){} // RVA: 0x7FFE82A88920
        public void GetRigPositions(){} // RVA: 0x7FFE82A89040
        public void GetHeading(){} // RVA: 0x7FFE82A89260
        public void GetRawRigPositions(){} // RVA: 0x7FFE82A897E0
        public void ResolveCollisions(){} // RVA: 0x7FFE82A89B60
        public void .ctor(){} // RVA: 0x7FFE82A89EB0
    }

    public class CinemachineBasicMultiChannelPerlin : CinemachineComponentBase
    {
        public Cinemachine.NoiseSettings m_NoiseProfile; // 0x28
        public UnityEngine.Vector3 m_PivotOffset; // 0x30

        // ── Methods ──
        public void get_IsValid(){} // RVA: 0x7FFE82A89F80
        public void get_Stage(){} // RVA: 0x7FFE81200CB0
        public void MutateCameraState(){} // RVA: 0x7FFE82A8A0A0
        public void ReSeed(){} // RVA: 0x7FFE82A8AB80
        public void Initialize(){} // RVA: 0x7FFE82A8ACB0
        public void .ctor(){} // RVA: 0x7FFE82A8AEC0
    }

    public class CinemachineBlend : Object
    {
        public Cinemachine.ICinemachineCamera CamA; // 0x10
        public Cinemachine.ICinemachineCamera CamB; // 0x18
        public UnityEngine.AnimationCurve BlendCurve; // 0x20
        public float TimeInBlend; // 0x28
        public float Duration; // 0x2C

        // ── Methods ──
        public void get_BlendWeight(){} // RVA: 0x7FFE82AA5580
        public void get_IsValid(){} // RVA: 0x7FFE82AA5670
        public void get_IsComplete(){} // RVA: 0x7FFE82AA56F0
        public void get_Description(){} // RVA: 0x7FFE82AA5720
        public void Uses(){} // RVA: 0x7FFE82AA5930
        public void .ctor(){} // RVA: 0x7FFE82AA5A70
        public void UpdateCameraState(){} // RVA: 0x7FFE82AA5B90
        public void get_State(){} // RVA: 0x7FFE82AA5C80
    }

    public class CinemachineBlendDefinition : ValueType
    {
        public 0x66623B54 m_Style; // 0x10
        public float m_Time; // 0x14

        // ── Methods ──
        public void get_BlendTime(){} // RVA: 0x7FFE82AA6150
        public void .ctor(){} // RVA: 0x7FFE82AA6160
        public void CreateStandardCurves(){} // RVA: 0x7FFE82AA61C0
        public void get_BlendCurve(){} // RVA: 0x7FFE82AA6A30
    }

    public class CinemachineBlendDefinitionPropertyAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class CinemachineBlendListCamera : CinemachineVirtualCameraBase
    {
        public UnityEngine.Transform m_LookAt; // 0xA8
        public UnityEngine.Transform m_Follow; // 0xB0
        public bool m_ShowDebugText; // 0xB8
        public bool m_Loop; // 0xB9
        public Cinemachine.CinemachineVirtualCameraBase[] m_ChildCameras; // 0xC0
        public Instruction[] m_Instructions; // 0xC8
        public Cinemachine.ICinemachineCamera _liveChild; // 0xD0

        // ── Methods ──
        public void get_Description(){} // RVA: 0x7FFE82A57B10
        public void Reset(){} // RVA: 0x7FFE82A57C50
        public void get_LiveChild(){} // RVA: 0x7FFE81218100
        public void set_LiveChild(){} // RVA: 0x7FFE81218110
        public void IsLiveChild(){} // RVA: 0x7FFE82A57DC0
        public void get_State(){} // RVA: 0x7FFE82A57DF0
        public void get_LookAt(){} // RVA: 0x7FFE82A57E90
        public void set_LookAt(){} // RVA: 0x7FFE81857260
        public void get_Follow(){} // RVA: 0x7FFE82A57EA0
        public void set_Follow(){} // RVA: 0x7FFE81166050
        public void OnTargetObjectWarped(){} // RVA: 0x7FFE82A57EB0
        public void ForceCameraPosition(){} // RVA: 0x7FFE82A57F90
        public void OnTransitionFromCamera(){} // RVA: 0x7FFE82A58120
        public void InternalUpdateCameraState(){} // RVA: 0x7FFE82A58350
        public void OnEnable(){} // RVA: 0x7FFE82A58D20
        public void OnDisable(){} // RVA: 0x7FFE82A59080
        public void OnTransformChildrenChanged(){} // RVA: 0x7FFE82A59200
        public void OnGuiHandler(){} // RVA: 0x7FFE82A59210
        public void get_ChildCameras(){} // RVA: 0x7FFE82A59380
        public void get_IsBlending(){} // RVA: 0x7FFE82A593A0
        public void InvalidateListOfChildren(){} // RVA: 0x7FFE82A593B0
        public void UpdateListOfChildren(){} // RVA: 0x7FFE82A59470
        public void ValidateInstructions(){} // RVA: 0x7FFE82A59800
        public void AdvanceCurrentInstruction(){} // RVA: 0x7FFE82A59C00
        public void .ctor(){} // RVA: 0x7FFE82A59E60
    }

    public class CinemachineBlenderSettings : ScriptableObject
    {
        // ── Methods ──
        public void GetBlendForVirtualCameras(){} // RVA: 0x7FFE82AA7150
        public void .ctor(){} // RVA: 0x7FFE81345B60
    }

    public class CinemachineBrain : MonoBehaviour
    {
        public bool m_ShowDebugText; // 0x20
        public bool m_ShowCameraFrustum; // 0x21
        public bool m_IgnoreTimeScale; // 0x22
        public UnityEngine.Transform m_WorldUpOverride; // 0x28
        public 0x66621CBC m_UpdateMethod; // 0x30
        public 0x66621D14 m_BlendUpdateMethod; // 0x34
        public Cinemachine.CinemachineBlendDefinition m_DefaultBlend; // 0x38
        public Cinemachine.CinemachineBlenderSettings m_CustomBlends; // 0x48

        // ── Methods ──
        public void get_OutputCamera(){} // RVA: 0x7FFE82A5A030
        public void get_ControlledObject(){} // RVA: 0x7FFE82A5A1A0
        public void set_ControlledObject(){} // RVA: 0x7FFE82A5A2C0
        public void get_SoloCamera(){} // RVA: 0x7FFE82A5A380
        public void set_SoloCamera(){} // RVA: 0x7FFE82A5A3E0
        public void GetSoloGUIColor(){} // RVA: 0x7FFE82A5A640
        public void get_DefaultWorldUp(){} // RVA: 0x7FFE82A5A660
        public void OnEnable(){} // RVA: 0x7FFE82A5A7F0
        public void OnDisable(){} // RVA: 0x7FFE82A5AD60
        public void OnSceneLoaded(){} // RVA: 0x7FFE82A5B060
        public void OnSceneUnloaded(){} // RVA: 0x7FFE82A5B100
        public void Awake(){} // RVA: 0x7FFE82A5B1A0
        public void Start(){} // RVA: 0x7FFE82A5B200
        public void OnGuiHandler(){} // RVA: 0x7FFE82A5B220
        public void AfterPhysics(){} // RVA: 0x7FFE82A5B700
        public void LateUpdate(){} // RVA: 0x7FFE82A5B7A0
        public void ManualUpdate(){} // RVA: 0x7FFE82A5B7B0
        public void GetEffectiveDeltaTime(){} // RVA: 0x7FFE82A5BAE0
        public void UpdateVirtualCameras(){} // RVA: 0x7FFE82A5BD80
        public void get_ActiveVirtualCamera(){} // RVA: 0x7FFE82A5C110
        public void DeepCamBFromBlend(){} // RVA: 0x7FFE82A5C290
        public void IsLiveInBlend(){} // RVA: 0x7FFE82A5C350
        public void get_IsBlending(){} // RVA: 0x7FFE82A5C490
        public void get_ActiveBlend(){} // RVA: 0x7FFE82A5C4B0
        public void set_ActiveBlend(){} // RVA: 0x7FFE82A5C5B0
        public void GetBrainFrame(){} // RVA: 0x7FFE82A5C6D0
        public void SetCameraOverride(){} // RVA: 0x7FFE82A5C810
        public void ReleaseCameraOverride(){} // RVA: 0x7FFE82A5CD40
        public void ProcessActiveCamera(){} // RVA: 0x7FFE82A5CE20
        public void UpdateFrame0(){} // RVA: 0x7FFE82A5D570
        public void ComputeCurrentBlend(){} // RVA: 0x7FFE82A5DDA0
        public void IsLive(){} // RVA: 0x7FFE82A5E3A0
        public void get_CurrentCameraState(){} // RVA: 0x7FFE82A5E580
        public void set_CurrentCameraState(){} // RVA: 0x7FFE82A5E620
        public void TopCameraFromPriorityQueue(){} // RVA: 0x7FFE82A5E710
        public void LookupBlend(){} // RVA: 0x7FFE82A5EA40
        public void PushStateToUnityCamera(){} // RVA: 0x7FFE82A5ECA0
        public void .ctor(){} // RVA: 0x7FFE82A5F330
        public void .cctor(){} // RVA: 0x7FFE82A5F790
    }

    public class CinemachineClearShot : CinemachineVirtualCameraBase
    {
        public UnityEngine.Transform m_LookAt; // 0xA8
        public UnityEngine.Transform m_Follow; // 0xB0
        public bool m_ShowDebugText; // 0xB8
        public Cinemachine.CinemachineVirtualCameraBase[] m_ChildCameras; // 0xC0
        public float m_ActivateAfter; // 0xC8
        public float m_MinDuration; // 0xCC
        public bool m_RandomizeChoice; // 0xD0
        public Cinemachine.CinemachineBlendDefinition m_DefaultBlend; // 0xD8

        // ── Methods ──
        public void get_Description(){} // RVA: 0x7FFE82A5FD50
        public void get_LiveChild(){} // RVA: 0x7FFE811662A0
        public void set_LiveChild(){} // RVA: 0x7FFE811662B0
        public void get_State(){} // RVA: 0x7FFE82A5FE90
        public void IsLiveChild(){} // RVA: 0x7FFE82A5FF30
        public void get_LookAt(){} // RVA: 0x7FFE82A57E90
        public void set_LookAt(){} // RVA: 0x7FFE81857260
        public void get_Follow(){} // RVA: 0x7FFE82A57EA0
        public void set_Follow(){} // RVA: 0x7FFE81166050
        public void OnTargetObjectWarped(){} // RVA: 0x7FFE82A5FF60
        public void ForceCameraPosition(){} // RVA: 0x7FFE82A60040
        public void InternalUpdateCameraState(){} // RVA: 0x7FFE82A601D0
        public void OnEnable(){} // RVA: 0x7FFE82A60910
        public void OnDisable(){} // RVA: 0x7FFE82A60C20
        public void OnTransformChildrenChanged(){} // RVA: 0x7FFE82A60DA0
        public void OnGuiHandler(){} // RVA: 0x7FFE82A60DC0
        public void get_IsBlending(){} // RVA: 0x7FFE82A60F30
        public void get_ActiveBlend(){} // RVA: 0x7FFE81B21230
        public void get_ChildCameras(){} // RVA: 0x7FFE82A60F40
        public void InvalidateListOfChildren(){} // RVA: 0x7FFE82A60F60
        public void ResetRandomization(){} // RVA: 0x7FFE82A61080
        public void UpdateListOfChildren(){} // RVA: 0x7FFE82A61100
        public void ChooseCurrentCamera(){} // RVA: 0x7FFE82A615C0
        public void Randomize(){} // RVA: 0x7FFE82A61FA0
        public void LookupBlend(){} // RVA: 0x7FFE82A624D0
        public void OnTransitionFromCamera(){} // RVA: 0x7FFE82A62740
        public void .ctor(){} // RVA: 0x7FFE82A628D0
    }

    public class CinemachineCollider : CinemachineExtension
    {
        public UnityEngine.LayerMask m_CollideAgainst; // 0x30

        // ── Methods ──
        public void IsTargetObscured(){} // RVA: 0x7FFE82A62C20
        public void CameraWasDisplaced(){} // RVA: 0x7FFE82A62C80
        public void GetCameraDisplacementDistance(){} // RVA: 0x7FFE82A62CF0
        public void OnValidate(){} // RVA: 0x7FFE82A62D60
        public void OnDestroy(){} // RVA: 0x7FFE82A62DB0
        public void get_DebugPaths(){} // RVA: 0x7FFE82A62E20
        public void GetMaxDampTime(){} // RVA: 0x7FFE82A63040
        public void OnTargetObjectWarped(){} // RVA: 0x7FFE82A63060
        public void PostPipelineStageCallback(){} // RVA: 0x7FFE82A63160
        public void PreserveLineOfSight(){} // RVA: 0x7FFE82A64430
        public void PullCameraInFrontOfNearestObstacle(){} // RVA: 0x7FFE82A64A20
        public void PushCameraBack(){} // RVA: 0x7FFE82A64F40
        public void GetWalkingDirection(){} // RVA: 0x7FFE82A659D0
        public void GetPushBackDistance(){} // RVA: 0x7FFE82A66310
        public void ClampRayToBounds(){} // RVA: 0x7FFE82A66480
        public void RespectCameraRadius(){} // RVA: 0x7FFE82A67390
        public void CheckForTargetObstructions(){} // RVA: 0x7FFE82A68060
        public void IsTargetOffscreen(){} // RVA: 0x7FFE82A684D0
        public void .ctor(){} // RVA: 0x7FFE82A68D50
        public void .cctor(){} // RVA: 0x7FFE82A68EC0
    }

    public class CinemachineCollisionImpulseSource : CinemachineImpulseSource
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFE82ABCCB0
        public void OnEnable(){} // RVA: 0x7FFE810FB310
        public void OnCollisionEnter(){} // RVA: 0x7FFE82ABCDD0
        public void OnTriggerEnter(){} // RVA: 0x7FFE82ABCE80
        public void GetMassAndVelocity(){} // RVA: 0x7FFE82ABCEF0
        public void GenerateImpactEvent(){} // RVA: 0x7FFE82ABD3F0
        public void OnCollisionEnter2D(){} // RVA: 0x7FFE82ABD760
        public void OnTriggerEnter2D(){} // RVA: 0x7FFE82ABD7C0
        public void GetMassAndVelocity2D(){} // RVA: 0x7FFE82ABD830
        public void GenerateImpactEvent2D(){} // RVA: 0x7FFE82ABDC80
        public void .ctor(){} // RVA: 0x7FFE82ABDFF0
    }

    public class CinemachineComponentBase : MonoBehaviour
    {
        public float Epsilon;
        public Cinemachine.CinemachineVirtualCameraBase m_vcamOwner; // 0x20
        public object field_2; // 0x96
        public object field_3; // 0x97
        public object field_4; // 0x98
        public object field_5; // 0x99
        public object field_6; // 0x9A
        public object field_7; // 0x9B
        public object field_8; // 0x9C
        public object field_9; // 0x9D
        public object field_10; // 0x9E
        public object field_11; // 0x9F
        public object field_12; // 0xA0
        public object field_13; // 0xA1
        public object field_14; // 0xA2
        public object field_15; // 0xA3

        // ── Methods ──
        public void get_VirtualCamera(){} // RVA: 0x7FFE82AA74B0
        public void get_FollowTarget(){} // RVA: 0x7FFE82AA78C0
        public void get_LookAtTarget(){} // RVA: 0x7FFE82AA79C0
        public void get_AbstractFollowTargetGroup(){} // RVA: 0x7FFE82AA7AC0
        public void get_FollowTargetGroup(){} // RVA: 0x7FFE82AA7BA0
        public void get_FollowTargetPosition(){} // RVA: 0x7FFE82AA7C30
        public void get_FollowTargetRotation(){} // RVA: 0x7FFE82AA7F30
        public void get_AbstractLookAtTargetGroup(){} // RVA: 0x7FFE82AA8200
        public void get_LookAtTargetGroup(){} // RVA: 0x7FFE82AA8230
        public void get_LookAtTargetPosition(){} // RVA: 0x7FFE82AA82D0
        public void get_LookAtTargetRotation(){} // RVA: 0x7FFE82AA85D0
        public void get_VcamState(){} // RVA: 0x7FFE82AA88A0
        public void get_IsValid(){} // RVA: 0x7FFE80E2F150
        public void PrePipelineMutateCameraState(){} // RVA: 0x7FFE810FB310
        public void get_Stage(){} // RVA: 0x7FFE80E2EDB0
        public void get_BodyAppliesAfterAim(){} // RVA: 0x7FFE810FB320
        public void MutateCameraState(){} // RVA: 0x7FFE80E52EB0
        public void OnTransitionFromCamera(){} // RVA: 0x7FFE810FB320
        public void OnTargetObjectWarped(){} // RVA: 0x7FFE810FB310
        public void ForceCameraPosition(){} // RVA: 0x7FFE810FB310
        public void GetMaxDampTime(){} // RVA: 0x7FFE8186F320
        public void get_RequiresUserInput(){} // RVA: 0x7FFE810FB320
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class CinemachineComposer : CinemachineComponentBase
    {
        public UnityEngine.Vector3 m_TrackedObjectOffset; // 0x28
        public float m_LookaheadTime; // 0x34
        public float m_LookaheadSmoothing; // 0x38
        public bool m_LookaheadIgnoreY; // 0x3C
        public float m_HorizontalDamping; // 0x40

        // ── Methods ──
        public void get_IsValid(){} // RVA: 0x7FFE82A8AFA0
        public void get_Stage(){} // RVA: 0x7FFE811EDAF0
        public void get_TrackedPoint(){} // RVA: 0x7FFE82A8B0C0
        public void set_TrackedPoint(){} // RVA: 0x7FFE82A8B0E0
        public void GetLookAtPointAndSetTrackedPoint(){} // RVA: 0x7FFE82A8B0F0
        public void OnTargetObjectWarped(){} // RVA: 0x7FFE82A8B5C0
        public void ForceCameraPosition(){} // RVA: 0x7FFE82A8B7C0
        public void GetMaxDampTime(){} // RVA: 0x7FFE82A8B7E0
        public void PrePipelineMutateCameraState(){} // RVA: 0x7FFE82A8B7F0
        public void MutateCameraState(){} // RVA: 0x7FFE82A8B930
        public void get_SoftGuideRect(){} // RVA: 0x7FFE82A8C6E0
        public void set_SoftGuideRect(){} // RVA: 0x7FFE82A8C730
        public void get_HardGuideRect(){} // RVA: 0x7FFE82A8C7F0
        public void set_HardGuideRect(){} // RVA: 0x7FFE82A8C870
        public void RotateToScreenBounds(){} // RVA: 0x7FFE82A8C8E0
        public void ClampVerticalBounds(){} // RVA: 0x7FFE82A8CBC0
        public void .ctor(){} // RVA: 0x7FFE82A8CEC0
    }

    public class CinemachineConfiner : CinemachineExtension
    {
        public 0x66622134 m_ConfineMode; // 0x30

        // ── Methods ──
        public void CameraWasDisplaced(){} // RVA: 0x7FFE82A69100
        public void GetCameraDisplacementDistance(){} // RVA: 0x7FFE82A69170
        public void OnValidate(){} // RVA: 0x7FFE82A691D0
        public void ConnectToVcam(){} // RVA: 0x7FFE82A691E0
        public void get_IsValid(){} // RVA: 0x7FFE82A691F0
        public void GetMaxDampTime(){} // RVA: 0x7FFE81604410
        public void PostPipelineStageCallback(){} // RVA: 0x7FFE82A69480
        public void InvalidatePathCache(){} // RVA: 0x7FFE82A69760
        public void ValidatePathCache(){} // RVA: 0x7FFE82A69810
        public void ConfinePoint(){} // RVA: 0x7FFE82A6A150
        public void ConfineScreenEdges(){} // RVA: 0x7FFE82A6A790
        public void .ctor(){} // RVA: 0x7FFE82A6AFC0
    }

    public class CinemachineConfiner2D : CinemachineExtension
    {
        // ── Methods ──
        public void InvalidateCache(){} // RVA: 0x7FFE82A6B010
        public void ValidateCache(){} // RVA: 0x7FFE82A6B020
        public void PostPipelineStageCallback(){} // RVA: 0x7FFE82A6B070
        public void CalculateHalfFrustumHeight(){} // RVA: 0x7FFE82A6B8A0
        public void OnValidate(){} // RVA: 0x7FFE82A6B950
        public void Reset(){} // RVA: 0x7FFE82A6B970
        public void .ctor(){} // RVA: 0x7FFE82A6B980
    }

    public class CinemachineCore : Object
    {
        public int kStreamingVersion;
        public Cinemachine.CinemachineCore sInstance; // 0x8
        public bool sShowHiddenObjects; // 0x10
        public AxisInputDelegate GetInputAxis; // 0x18
        public float UniformDeltaTimeOverride; // 0x20

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFE82AA8A50
        public void get_DeltaTime(){} // RVA: 0x7FFE82AA8B80
        public void get_CurrentTime(){} // RVA: 0x7FFE82AA8C40
        public void get_BrainCount(){} // RVA: 0x7FFE82AA8D00
        public void GetActiveBrain(){} // RVA: 0x7FFE82AA8D50
        public void AddActiveBrain(){} // RVA: 0x7FFE82AA8DD0
        public void RemoveActiveBrain(){} // RVA: 0x7FFE82AA8E70
        public void get_VirtualCameraCount(){} // RVA: 0x7FFE82AA8ED0
        public void GetVirtualCamera(){} // RVA: 0x7FFE82AA8F20
        public void AddActiveCamera(){} // RVA: 0x7FFE82AA90E0
        public void RemoveActiveCamera(){} // RVA: 0x7FFE82AA9150
        public void CameraDestroyed(){} // RVA: 0x7FFE82AA91D0
        public void CameraEnabled(){} // RVA: 0x7FFE82AA92C0
        public void CameraDisabled(){} // RVA: 0x7FFE82AA9520
        public void UpdateAllActiveVirtualCameras(){} // RVA: 0x7FFE82AA9750
        public void UpdateVirtualCamera(){} // RVA: 0x7FFE82AA9E60
        public void InitializeModule(){} // RVA: 0x7FFE82AAA350
        public void GetUpdateTarget(){} // RVA: 0x7FFE82AAA450
        public void GetVcamUpdateStatus(){} // RVA: 0x7FFE82AAA770
        public void IsLive(){} // RVA: 0x7FFE82AAA800
        public void IsLiveInBlend(){} // RVA: 0x7FFE82AAA960
        public void GenerateCameraActivationEvent(){} // RVA: 0x7FFE82AAAAC0
        public void GenerateCameraCutEvent(){} // RVA: 0x7FFE82AAACA0
        public void FindPotentialTargetBrain(){} // RVA: 0x7FFE82AAAEF0
        public void OnTargetObjectWarped(){} // RVA: 0x7FFE82AAB3C0
        public void .ctor(){} // RVA: 0x7FFE82AAB490
        public void .cctor(){} // RVA: 0x7FFE82AAB680
    }

    public class CinemachineDollyCart : MonoBehaviour
    {
        // ── Methods ──
        public void FixedUpdate(){} // RVA: 0x7FFE82A6CC80
        public void Update(){} // RVA: 0x7FFE82A6CD10
        public void LateUpdate(){} // RVA: 0x7FFE82A6CE20
        public void SetCartPosition(){} // RVA: 0x7FFE82A6CF40
        public void .ctor(){} // RVA: 0x7FFE82A6D150
    }

    public class CinemachineEmbeddedAssetPropertyAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE811C55F0
    }

    public class CinemachineExtension : MonoBehaviour
    {
        public float Epsilon;
        public Cinemachine.CinemachineVirtualCameraBase m_vcamOwner; // 0x20

        // ── Methods ──
        public void get_VirtualCamera(){} // RVA: 0x7FFE82AABE20
        public void Awake(){} // RVA: 0x7FFE82AABF60
        public void OnEnable(){} // RVA: 0x7FFE810FB310
        public void OnDestroy(){} // RVA: 0x7FFE82AABF80
        public void EnsureStarted(){} // RVA: 0x7FFE82AABF60
        public void ConnectToVcam(){} // RVA: 0x7FFE82AABFA0
        public void PrePipelineMutateCameraStateCallback(){} // RVA: 0x7FFE810FB310
        public void InvokePostPipelineStageCallback(){} // RVA: 0x7FFE82AAC220
        public void PostPipelineStageCallback(){}
        public void OnTargetObjectWarped(){} // RVA: 0x7FFE810FB310
        public void ForceCameraPosition(){} // RVA: 0x7FFE810FB310
        public void OnTransitionFromCamera(){} // RVA: 0x7FFE810FB320
        public void GetMaxDampTime(){} // RVA: 0x7FFE8186F320
        public void get_RequiresUserInput(){} // RVA: 0x7FFE810FB320
        public void GetExtraState(){} // RVA: 0x7FFE810A1420
        public void GetAllExtraStates(){} // RVA: 0x7FFE80E2E2E0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class CinemachineExternalCamera : CinemachineVirtualCameraBase
    {
        public UnityEngine.Transform m_LookAt; // 0xA8
        public UnityEngine.Camera m_Camera; // 0xB0
        public Cinemachine.CameraState m_State; // 0xB8

        // ── Methods ──
        public void get_State(){} // RVA: 0x7FFE82A6D1A0
        public void get_LookAt(){} // RVA: 0x7FFE817AB5E0
        public void set_LookAt(){} // RVA: 0x7FFE81857260
        public void get_Follow(){} // RVA: 0x7FFE81B32390
        public void set_Follow(){} // RVA: 0x7FFE81B21CA0
        public void InternalUpdateCameraState(){} // RVA: 0x7FFE82A6D240
        public void .ctor(){} // RVA: 0x7FFE82A6DE60
    }

    public class CinemachineFixedSignal : SignalSourceAsset
    {
        public UnityEngine.AnimationCurve m_XCurve; // 0x18

        // ── Methods ──
        public void get_SignalDuration(){} // RVA: 0x7FFE82ABE1B0
        public void AxisDuration(){} // RVA: 0x7FFE82ABE210
        public void GetSignal(){} // RVA: 0x7FFE82ABE310
        public void AxisValue(){} // RVA: 0x7FFE82ABE4F0
        public void .ctor(){} // RVA: 0x7FFE81345B60
    }

    public class CinemachineFollowZoom : CinemachineExtension
    {
        // ── Methods ──
        public void OnValidate(){} // RVA: 0x7FFE82A6E030
        public void GetMaxDampTime(){} // RVA: 0x7FFE811C5630
        public void PostPipelineStageCallback(){} // RVA: 0x7FFE82A6E090
        public void .ctor(){} // RVA: 0x7FFE82A6E480
    }

    public class CinemachineFramingTransposer : CinemachineComponentBase
    {
        public UnityEngine.Vector3 m_TrackedObjectOffset; // 0x28
        public float m_LookaheadTime; // 0x34
        public float m_LookaheadSmoothing; // 0x38
        public bool m_LookaheadIgnoreY; // 0x3C
        public float m_XDamping; // 0x40
        public float m_YDamping; // 0x44
        public float m_ZDamping; // 0x48
        public bool m_TargetMovementOnly; // 0x4C

        // ── Methods ──
        public void get_SoftGuideRect(){} // RVA: 0x7FFE82A8DD90
        public void set_SoftGuideRect(){} // RVA: 0x7FFE82A8DDE0
        public void get_HardGuideRect(){} // RVA: 0x7FFE82A8DEA0
        public void set_HardGuideRect(){} // RVA: 0x7FFE82A8DF20
        public void OnValidate(){} // RVA: 0x7FFE82A8DF90
        public void get_IsValid(){} // RVA: 0x7FFE82A8E080
        public void get_Stage(){} // RVA: 0x7FFE813240E0
        public void get_BodyAppliesAfterAim(){} // RVA: 0x7FFE811E0850
        public void get_TrackedPoint(){} // RVA: 0x7FFE82A8E1A0
        public void set_TrackedPoint(){} // RVA: 0x7FFE82A8E1C0
        public void OnTargetObjectWarped(){} // RVA: 0x7FFE82A8E1E0
        public void ForceCameraPosition(){} // RVA: 0x7FFE82A8E3A0
        public void GetMaxDampTime(){} // RVA: 0x7FFE82A8E3D0
        public void OnTransitionFromCamera(){} // RVA: 0x7FFE82A8E3F0
        public void ScreenToOrtho(){} // RVA: 0x7FFE82A8E620
        public void OrthoOffsetToScreenBounds(){} // RVA: 0x7FFE82A8E6F0
        public void get_LastBounds(){} // RVA: 0x7FFE82A8E800
        public void set_LastBounds(){} // RVA: 0x7FFE82A8E820
        public void get_LastBoundsMatrix(){} // RVA: 0x7FFE82A8E840
        public void set_LastBoundsMatrix(){} // RVA: 0x7FFE82A8E870
        public void MutateCameraState(){} // RVA: 0x7FFE82A8E8A0
        public void GetTargetHeight(){} // RVA: 0x7FFE82A90450
        public void ComputeGroupBounds(){} // RVA: 0x7FFE82A90650
        public void GetScreenSpaceGroupBoundingBox(){} // RVA: 0x7FFE82A90E80
        public void .ctor(){} // RVA: 0x7FFE82A91690
    }

    public class CinemachineFreeLook : CinemachineVirtualCameraBase
    {
        public UnityEngine.Transform m_LookAt; // 0xA8
        public UnityEngine.Transform m_Follow; // 0xB0
        public bool m_CommonLens; // 0xB8
        public Cinemachine.LensSettings m_Lens; // 0xBC
        public TransitionParams m_Transitions; // 0xF0
        public 0x66624704 m_LegacyBlendHint; // 0x100

        // ── Methods ──
        public void OnValidate(){} // RVA: 0x7FFE82A6E4E0
        public void GetRig(){} // RVA: 0x7FFE82A6E7D0
        public void get_RigsAreCreated(){} // RVA: 0x7FFE82A6E830
        public void get_RigNames(){} // RVA: 0x7FFE82A6E850
        public void OnEnable(){} // RVA: 0x7FFE82A6E910
        public void UpdateInputAxisProvider(){} // RVA: 0x7FFE82A6EB30
        public void OnDestroy(){} // RVA: 0x7FFE82A6ECF0
        public void OnTransformChildrenChanged(){} // RVA: 0x7FFE82A6EF00
        public void Reset(){} // RVA: 0x7FFE82A6EF60
        public void get_PreviousStateIsValid(){} // RVA: 0x7FFE813A1140
        public void set_PreviousStateIsValid(){} // RVA: 0x7FFE82A6EF80
        public void get_State(){} // RVA: 0x7FFE82A6F100
        public void get_LookAt(){} // RVA: 0x7FFE82A57E90
        public void set_LookAt(){} // RVA: 0x7FFE81857260
        public void get_Follow(){} // RVA: 0x7FFE82A57EA0
        public void set_Follow(){} // RVA: 0x7FFE81166050
        public void IsLiveChild(){} // RVA: 0x7FFE82A6F1A0
        public void OnTargetObjectWarped(){} // RVA: 0x7FFE82A6F2B0
        public void ForceCameraPosition(){} // RVA: 0x7FFE82A6F390
        public void InternalUpdateCameraState(){} // RVA: 0x7FFE82A6F6B0
        public void OnTransitionFromCamera(){} // RVA: 0x7FFE82A70200
        public void RequiresUserInput(){} // RVA: 0x7FFE811E0850
        public void GetYAxisClosestValue(){} // RVA: 0x7FFE82A70710
        public void SteepestDescent(){} // RVA: 0x7FFE82A70E80
        public void InvalidateRigCache(){} // RVA: 0x7FFE82A6EF00
        public void DestroyRigs(){} // RVA: 0x7FFE82A710D0
        public void CreateRigs(){} // RVA: 0x7FFE82A71820
        public void UpdateRigCache(){} // RVA: 0x7FFE82A72490
        public void LocateExistingRigs(){} // RVA: 0x7FFE82A72A20
        public void UpdateXAxisHeading(){} // RVA: 0x7FFE82A730E0
        public void PushSettingsToRigs(){} // RVA: 0x7FFE82A733A0
        public void GetYAxisValue(){} // RVA: 0x7FFE82A73B40
        public void CalculateNewState(){} // RVA: 0x7FFE82A73B70
        public void GetLocalPositionForCameraFromInput(){} // RVA: 0x7FFE82A73E20
        public void UpdateCachedSpline(){} // RVA: 0x7FFE82A740D0
        public void OnBeforeSerialize(){} // RVA: 0x7FFE82A74730
        public void .ctor(){} // RVA: 0x7FFE82A74810
        public void <SteepestDescent>g__AngleFunction|47_0(){} // RVA: 0x7FFE82A74EE0
        public void <SteepestDescent>g__SlopeOfAngleFunction|47_1(){} // RVA: 0x7FFE82A74FB0
        public void <SteepestDescent>g__InitialGuess|47_2(){} // RVA: 0x7FFE82A75020
        public void <SteepestDescent>g__ChooseBestAngle|47_3(){} // RVA: 0x7FFE82A75130
    }

    public class CinemachineGroupComposer : CinemachineComposer
    {
        public float m_GroupFramingSize; // 0x100
        public 0x6662320C m_FramingMode; // 0x104

        // ── Methods ──
        public void OnValidate(){} // RVA: 0x7FFE82A91840
        public void get_LastBounds(){} // RVA: 0x7FFE82A91910
        public void set_LastBounds(){} // RVA: 0x7FFE82A91930
        public void get_LastBoundsMatrix(){} // RVA: 0x7FFE82A91950
        public void set_LastBoundsMatrix(){} // RVA: 0x7FFE82A91980
        public void GetMaxDampTime(){} // RVA: 0x7FFE82A919B0
        public void MutateCameraState(){} // RVA: 0x7FFE82A919D0
        public void GetTargetHeight(){} // RVA: 0x7FFE82A92B40
        public void GetScreenSpaceGroupBoundingBox(){} // RVA: 0x7FFE82A92D80
        public void .ctor(){} // RVA: 0x7FFE82A93310
    }

    public class CinemachineHardLockToTarget : CinemachineComponentBase
    {
        public float m_Damping; // 0x28
        public UnityEngine.Vector3 m_PreviousTargetPosition; // 0x2C

        // ── Methods ──
        public void get_IsValid(){} // RVA: 0x7FFE82A93390
        public void get_Stage(){} // RVA: 0x7FFE813240E0
        public void GetMaxDampTime(){} // RVA: 0x7FFE811DA210
        public void MutateCameraState(){} // RVA: 0x7FFE82A934B0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class CinemachineHardLookAt : CinemachineComponentBase
    {
        // ── Methods ──
        public void get_IsValid(){} // RVA: 0x7FFE82A93680
        public void get_Stage(){} // RVA: 0x7FFE811EDAF0
        public void MutateCameraState(){} // RVA: 0x7FFE82A937A0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class CinemachineImpulseChannelPropertyAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class CinemachineImpulseDefinition : Object
    {
        public int m_ImpulseChannel; // 0x10

        // ── Methods ──
        public void OnValidate(){} // RVA: 0x7FFE82ABE570
        public void CreateStandardShapes(){} // RVA: 0x7FFE82ABE660
        public void GetStandardCurve(){} // RVA: 0x7FFE82ABF260
        public void get_ImpulseCurve(){} // RVA: 0x7FFE82ABF2E0
        public void CreateEvent(){} // RVA: 0x7FFE82ABF3F0
        public void CreateAndReturnEvent(){} // RVA: 0x7FFE82ABF430
        public void LegacyCreateAndReturnEvent(){} // RVA: 0x7FFE82ABF680
        public void .ctor(){} // RVA: 0x7FFE82ABFA70
    }

    public class CinemachineImpulseDefinitionPropertyAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class CinemachineImpulseEnvelopePropertyAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class CinemachineImpulseListener : CinemachineExtension
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFE82AC0480
        public void PostPipelineStageCallback(){} // RVA: 0x7FFE82AC0540
        public void .ctor(){} // RVA: 0x7FFE82AC0B20
    }

    public class CinemachineImpulseManager : Object
    {
        public Cinemachine.CinemachineImpulseManager sInstance;
        public float Epsilon;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_Instance(){} // RVA: 0x7FFE82AC1230
        public void InitializeModule(){} // RVA: 0x7FFE82AC12F0
        public void EvaluateDissipationScale(){} // RVA: 0x7FFE82AC1420
        public void GetImpulseAt(){} // RVA: 0x7FFE82AC1520
        public void get_CurrentTime(){} // RVA: 0x7FFE82AC1A30
        public void NewImpulseEvent(){} // RVA: 0x7FFE82AC1AD0
        public void AddImpulseEvent(){} // RVA: 0x7FFE82AC1BD0
        public void Clear(){} // RVA: 0x7FFE82AC1CD0
    }

    public class CinemachineImpulseSource : MonoBehaviour
    {
        // ── Methods ──
        public void OnValidate(){} // RVA: 0x7FFE82AC2B70
        public void Reset(){} // RVA: 0x7FFE82AC2C80
        public void GenerateImpulseAtPositionWithVelocity(){} // RVA: 0x7FFE82AC2E70
        public void GenerateImpulseWithVelocity(){} // RVA: 0x7FFE82AC2EC0
        public void GenerateImpulseWithForce(){} // RVA: 0x7FFE82AC2FE0
        public void GenerateImpulse(){} // RVA: 0x7FFE82AC2FE0 | overloaded x3
        public void GenerateImpulseAt(){} // RVA: 0x7FFE82AC2E70
        public void .ctor(){} // RVA: 0x7FFE82AC3180
    }

    public class CinemachineIndependentImpulseListener : MonoBehaviour
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFE82AC32A0
        public void OnEnable(){} // RVA: 0x7FFE82AC3350
        public void Update(){} // RVA: 0x7FFE82AC33E0
        public void LateUpdate(){} // RVA: 0x7FFE82AC3850
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class CinemachineInputAxisDriver : ValueType
    {
        // ── Methods ──
        public void Validate(){} // RVA: 0x7FFE82A9F800
        public void Update(){} // RVA: 0x7FFE82AAC5D0 | overloaded x2
        public void ClampValue(){} // RVA: 0x7FFE82AAC640
    }

    public class CinemachineInputProvider : MonoBehaviour
    {
        // ── Methods ──
        public void GetAxisValue(){} // RVA: 0x7FFE82ABA680
        public void ResolveForPlayer(){} // RVA: 0x7FFE82ABA7A0
        public void OnDisable(){} // RVA: 0x7FFE81E7B590
        public void .ctor(){} // RVA: 0x7FFE82ABAF00
        public void <ResolveForPlayer>g__GetFirstMatch|7_0(){} // RVA: 0x7FFE82ABAF50
    }

    public class CinemachineMixingCamera : CinemachineVirtualCameraBase
    {
        public int MaxCameras;
        public float m_Weight0; // 0xA8
        public float m_Weight1; // 0xAC
        public float m_Weight2; // 0xB0
        public float m_Weight3; // 0xB4

        // ── Methods ──
        public void GetWeight(){} // RVA: 0x7FFE82A75600 | overloaded x2
        public void SetWeight(){} // RVA: 0x7FFE82A75940 | overloaded x2
        public void get_LiveChild(){} // RVA: 0x7FFE81B23A60
        public void set_LiveChild(){} // RVA: 0x7FFE81B2ACE0
        public void get_State(){} // RVA: 0x7FFE82A75C10
        public void get_LookAt(){} // RVA: 0x7FFE81B164E0
        public void set_LookAt(){} // RVA: 0x7FFE81B38D70
        public void get_Follow(){} // RVA: 0x7FFE817EFE00
        public void set_Follow(){} // RVA: 0x7FFE81B0C930
        public void OnTargetObjectWarped(){} // RVA: 0x7FFE82A75CB0
        public void ForceCameraPosition(){} // RVA: 0x7FFE82A75D90
        public void OnEnable(){} // RVA: 0x7FFE82A75F20
        public void OnTransformChildrenChanged(){} // RVA: 0x7FFE82A75F40
        public void OnValidate(){} // RVA: 0x7FFE82A75F50
        public void IsLiveChild(){} // RVA: 0x7FFE82A76000
        public void get_ChildCameras(){} // RVA: 0x7FFE82A760A0
        public void InvalidateListOfChildren(){} // RVA: 0x7FFE82A760C0
        public void ValidateListOfChildren(){} // RVA: 0x7FFE82A761E0
        public void OnTransitionFromCamera(){} // RVA: 0x7FFE82A76680
        public void InternalUpdateCameraState(){} // RVA: 0x7FFE82A767E0
        public void .ctor(){} // RVA: 0x7FFE82A76EE0
    }

    public class CinemachineOrbitalTransposer : CinemachineTransposer
    {
        public Heading m_Heading; // 0xA0

        // ── Methods ──
        public void OnValidate(){} // RVA: 0x7FFE82A93B60
        public void UpdateHeading(){} // RVA: 0x7FFE82A93D90 | overloaded x2
        public void OnEnable(){} // RVA: 0x7FFE82A93F30
        public void UpdateInputAxisProvider(){} // RVA: 0x7FFE82A94150
        public void OnTargetObjectWarped(){} // RVA: 0x7FFE82A942C0
        public void ForceCameraPosition(){} // RVA: 0x7FFE82A945C0
        public void OnTransitionFromCamera(){} // RVA: 0x7FFE82A94720
        public void GetAxisClosestValue(){} // RVA: 0x7FFE82A94960
        public void MutateCameraState(){} // RVA: 0x7FFE82A950D0
        public void GetTargetCameraPosition(){} // RVA: 0x7FFE82A96070
        public void get_RequiresUserInput(){} // RVA: 0x7FFE811E0850
        public void GetTargetHeading(){} // RVA: 0x7FFE82A964C0
        public void .ctor(){} // RVA: 0x7FFE82A96E30
    }

    public class CinemachinePOV : CinemachineComponentBase
    {
        public 0x6662357C m_RecenterTarget; // 0x28
        public Cinemachine.AxisState m_VerticalAxis; // 0x30
        public Recentering m_VerticalRecentering; // 0xA0

        // ── Methods ──
        public void get_IsValid(){} // RVA: 0x7FFE81161DE0
        public void get_Stage(){} // RVA: 0x7FFE811EDAF0
        public void OnValidate(){} // RVA: 0x7FFE82A97620
        public void OnEnable(){} // RVA: 0x7FFE82A97730
        public void UpdateInputAxisProvider(){} // RVA: 0x7FFE82A97740
        public void PrePipelineMutateCameraState(){} // RVA: 0x7FFE810FB310
        public void MutateCameraState(){} // RVA: 0x7FFE82A97A10
        public void GetRecenterTarget(){} // RVA: 0x7FFE82A981D0
        public void NormalizeAngle(){} // RVA: 0x7FFE82A98680
        public void ForceCameraPosition(){} // RVA: 0x7FFE82A986B0
        public void OnTransitionFromCamera(){} // RVA: 0x7FFE82A986D0
        public void get_RequiresUserInput(){} // RVA: 0x7FFE811E0850
        public void SetAxesForRotation(){} // RVA: 0x7FFE82A98940
        public void .ctor(){} // RVA: 0x7FFE82A99430
    }

    public class CinemachinePath : CinemachinePathBase
    {
        public bool m_Looped; // 0x50
        public Waypoint[] m_Waypoints; // 0x58
        public object field_2; // 0x2E
        public object field_3; // 0x2F

        // ── Methods ──
        public void get_MinPos(){} // RVA: 0x7FFE8186F320
        public void get_MaxPos(){} // RVA: 0x7FFE82A77100
        public void get_Looped(){} // RVA: 0x7FFE811B58E0
        public void Reset(){} // RVA: 0x7FFE82A77140
        public void OnValidate(){} // RVA: 0x7FFE818572C0
        public void get_DistanceCacheSampleStepsPerSegment(){} // RVA: 0x7FFE8151D690
        public void GetBoundingIndices(){} // RVA: 0x7FFE82A77300
        public void EvaluateLocalPosition(){} // RVA: 0x7FFE82A773F0
        public void EvaluateLocalTangent(){} // RVA: 0x7FFE82A77740
        public void EvaluateLocalOrientation(){} // RVA: 0x7FFE82A779A0
        public void GetRoll(){} // RVA: 0x7FFE82A77DC0
        public void RollAroundForward(){} // RVA: 0x7FFE82A77EF0
        public void .ctor(){} // RVA: 0x7FFE82A77F40
    }

    public class CinemachinePathBase : MonoBehaviour
    {
        public int m_Resolution; // 0x20
        public Appearance m_Appearance; // 0x28
        public float[] m_DistanceToPos; // 0x30
        public float[] m_PosToDistance; // 0x38
        public int m_CachedSampleSteps; // 0x40

        // ── Methods ──
        public void get_MinPos(){} // RVA: 0x7FFE80E42E10
        public void get_MaxPos(){} // RVA: 0x7FFE80E42E10
        public void get_Looped(){} // RVA: 0x7FFE80E2F150
        public void StandardizePos(){} // RVA: 0x7FFE82AAC6B0
        public void EvaluatePosition(){} // RVA: 0x7FFE82AAC7A0
        public void EvaluateTangent(){} // RVA: 0x7FFE82AAC8C0
        public void EvaluateOrientation(){} // RVA: 0x7FFE82AAC9E0
        public void EvaluateLocalPosition(){}
        public void EvaluateLocalTangent(){}
        public void EvaluateLocalOrientation(){}
        public void FindClosestPoint(){} // RVA: 0x7FFE82AACC50
        public void MinUnit(){} // RVA: 0x7FFE82AAD0A0
        public void MaxUnit(){} // RVA: 0x7FFE82AAD0D0
        public void StandardizeUnit(){} // RVA: 0x7FFE82AAD100
        public void EvaluatePositionAtUnit(){} // RVA: 0x7FFE82AAD1B0
        public void EvaluateTangentAtUnit(){} // RVA: 0x7FFE82AAD210
        public void EvaluateOrientationAtUnit(){} // RVA: 0x7FFE82AAD270
        public void get_DistanceCacheSampleStepsPerSegment(){} // RVA: 0x7FFE80E2EDB0
        public void InvalidateDistanceCache(){} // RVA: 0x7FFE82AAD2D0
        public void DistanceCacheIsValid(){} // RVA: 0x7FFE82AAD380
        public void get_PathLength(){} // RVA: 0x7FFE82AAD420
        public void StandardizePathDistance(){} // RVA: 0x7FFE82AAD490
        public void ToNativePathUnits(){} // RVA: 0x7FFE82AAD550
        public void FromPathNativeUnits(){} // RVA: 0x7FFE82AAD6D0
        public void ResamplePath(){} // RVA: 0x7FFE82AAD7F0
        public void .ctor(){} // RVA: 0x7FFE82AADCA0
    }

    public class CinemachinePipeline : MonoBehaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class CinemachinePixelPerfect : MonoBehaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class CinemachineSameAsFollowTarget : CinemachineComponentBase
    {
        public float m_Damping; // 0x28
        public UnityEngine.Quaternion m_PreviousReferenceOrientation; // 0x2C

        // ── Methods ──
        public void get_IsValid(){} // RVA: 0x7FFE82A99790
        public void get_Stage(){} // RVA: 0x7FFE811EDAF0
        public void GetMaxDampTime(){} // RVA: 0x7FFE811DA210
        public void MutateCameraState(){} // RVA: 0x7FFE82A998B0
        public void .ctor(){} // RVA: 0x7FFE82A99BF0
    }

    public class CinemachineSmoothPath : CinemachinePathBase
    {
        public bool m_Looped; // 0x50
        public Waypoint[] m_Waypoints; // 0x58
        public Waypoint[] m_ControlPoints1; // 0x60
        public Waypoint[] m_ControlPoints2; // 0x68

        // ── Methods ──
        public void get_MinPos(){} // RVA: 0x7FFE8186F320
        public void get_MaxPos(){} // RVA: 0x7FFE82A77100
        public void get_Looped(){} // RVA: 0x7FFE811B58E0
        public void get_DistanceCacheSampleStepsPerSegment(){} // RVA: 0x7FFE8151D690
        public void OnValidate(){} // RVA: 0x7FFE818572C0
        public void Reset(){} // RVA: 0x7FFE82A780E0
        public void InvalidateDistanceCache(){} // RVA: 0x7FFE82A78290
        public void UpdateControlPoints(){} // RVA: 0x7FFE82A783E0
        public void GetBoundingIndices(){} // RVA: 0x7FFE82A78750
        public void EvaluateLocalPosition(){} // RVA: 0x7FFE82A78830
        public void EvaluateLocalTangent(){} // RVA: 0x7FFE82A78BC0
        public void EvaluateLocalOrientation(){} // RVA: 0x7FFE82A78E90
        public void RollAroundForward(){} // RVA: 0x7FFE82A77EF0
        public void .ctor(){} // RVA: 0x7FFE82A793A0
    }

    public class CinemachineStateDrivenCamera : CinemachineVirtualCameraBase
    {
        public UnityEngine.Transform m_LookAt; // 0xA8
        public UnityEngine.Transform m_Follow; // 0xB0
        public UnityEngine.Animator m_AnimatedTarget; // 0xB8
        public int m_LayerIndex; // 0xC0
        public bool m_ShowDebugText; // 0xC4
        public Cinemachine.CinemachineVirtualCameraBase[] m_ChildCameras; // 0xC8
        public Instruction[] m_Instructions; // 0xD0
        public Cinemachine.CinemachineBlendDefinition m_DefaultBlend; // 0xD8

        // ── Methods ──
        public void get_Description(){} // RVA: 0x7FFE82A794D0
        public void get_LiveChild(){} // RVA: 0x7FFE8158D5D0
        public void set_LiveChild(){} // RVA: 0x7FFE81B0E4B0
        public void IsLiveChild(){} // RVA: 0x7FFE82A79610
        public void get_State(){} // RVA: 0x7FFE82A79640
        public void get_LookAt(){} // RVA: 0x7FFE82A57E90
        public void set_LookAt(){} // RVA: 0x7FFE81857260
        public void get_Follow(){} // RVA: 0x7FFE82A57EA0
        public void set_Follow(){} // RVA: 0x7FFE81166050
        public void OnTargetObjectWarped(){} // RVA: 0x7FFE82A796E0
        public void ForceCameraPosition(){} // RVA: 0x7FFE82A797C0
        public void OnTransitionFromCamera(){} // RVA: 0x7FFE82A79950
        public void InternalUpdateCameraState(){} // RVA: 0x7FFE82A79A60
        public void OnEnable(){} // RVA: 0x7FFE82A7A350
        public void OnDisable(){} // RVA: 0x7FFE82A7A660
        public void OnTransformChildrenChanged(){} // RVA: 0x7FFE82A7A7E0
        public void OnGuiHandler(){} // RVA: 0x7FFE82A7A7F0
        public void get_ChildCameras(){} // RVA: 0x7FFE82A7A960
        public void get_IsBlending(){} // RVA: 0x7FFE82A7A980
        public void get_ActiveBlend(){} // RVA: 0x7FFE81B20B50
        public void CreateFakeHash(){} // RVA: 0x7FFE82A7A990
        public void LookupFakeHash(){} // RVA: 0x7FFE82A7AA50
        public void InvalidateListOfChildren(){} // RVA: 0x7FFE82A7AE00
        public void UpdateListOfChildren(){} // RVA: 0x7FFE82A7AEC0
        public void ValidateInstructions(){} // RVA: 0x7FFE82A7B260
        public void ChooseCurrentCamera(){} // RVA: 0x7FFE82A7B8A0
        public void GetClipHash(){} // RVA: 0x7FFE82A7C140
        public void LookupBlend(){} // RVA: 0x7FFE82A7C2D0
        public void .ctor(){} // RVA: 0x7FFE82A7C540
    }

    public class CinemachineStoryboard : CinemachineExtension
    {
        public bool s_StoryboardGlobalMute;

        // ── Methods ──
        public void PostPipelineStageCallback(){} // RVA: 0x7FFE82A7C880
        public void UpdateRenderCanvas(){} // RVA: 0x7FFE82A7CA90
        public void ConnectToVcam(){} // RVA: 0x7FFE82A7CCE0
        public void get_CanvasName(){} // RVA: 0x7FFE82A7CEB0
        public void CameraUpdatedCallback(){} // RVA: 0x7FFE82A7CFE0
        public void LocateMyCanvas(){} // RVA: 0x7FFE82A7D380
        public void CreateCanvas(){} // RVA: 0x7FFE82A7DCA0
        public void DestroyCanvas(){} // RVA: 0x7FFE82A7E7D0
        public void PlaceImage(){} // RVA: 0x7FFE82A7EB50
        public void StaticBlendingHandler(){} // RVA: 0x7FFE82A7F780
        public void InitializeModule(){} // RVA: 0x7FFE82A7FB60
        public void .ctor(){} // RVA: 0x7FFE82A7FCD0
    }

    public class CinemachineTargetGroup : MonoBehaviour
    {
        public 0x66622CE4 m_PositionMode; // 0x20
        public 0x66622D3C m_RotationMode; // 0x24
        public 0x66622D94 m_UpdateMethod; // 0x28
        public Target[] m_Targets; // 0x30
        public float m_MaxWeight; // 0x38

        // ── Methods ──
        public void OnValidate(){} // RVA: 0x7FFE82A7FEA0
        public void Reset(){} // RVA: 0x7FFE82A7FF40
        public void get_Transform(){} // RVA: 0x7FFE816315C0
        public void get_BoundingBox(){} // RVA: 0x7FFE82A7FFD0
        public void set_BoundingBox(){} // RVA: 0x7FFE82A80060
        public void get_Sphere(){} // RVA: 0x7FFE82A80080
        public void set_Sphere(){} // RVA: 0x7FFE8120BDC0
        public void get_IsEmpty(){} // RVA: 0x7FFE82A80100
        public void AddMember(){} // RVA: 0x7FFE82A801A0
        public void RemoveMember(){} // RVA: 0x7FFE82A80480
        public void FindMember(){} // RVA: 0x7FFE82A80790
        public void GetWeightedBoundsForMember(){} // RVA: 0x7FFE82A80920
        public void GetViewSpaceBoundingBox(){} // RVA: 0x7FFE82A80B00
        public void get_CachedCountIsValid(){} // RVA: 0x7FFE82A812C0
        public void IndexIsValid(){} // RVA: 0x7FFE82A81330
        public void WeightedMemberBoundsForValidMember(){} // RVA: 0x7FFE82A81350
        public void DoUpdate(){} // RVA: 0x7FFE82A81510
        public void UpdateMemberValidity(){} // RVA: 0x7FFE82A81860
        public void CalculateAveragePosition(){} // RVA: 0x7FFE82A81BF0
        public void CalculateBoundingBox(){} // RVA: 0x7FFE82A81E80
        public void CalculateBoundingSphere(){} // RVA: 0x7FFE82A823F0
        public void CalculateAverageOrientation(){} // RVA: 0x7FFE82A827F0
        public void FixedUpdate(){} // RVA: 0x7FFE82A82F90
        public void Update(){} // RVA: 0x7FFE82A82FA0
        public void LateUpdate(){} // RVA: 0x7FFE82A83040
        public void GetViewSpaceAngularBounds(){} // RVA: 0x7FFE82A83050
        public void .ctor(){} // RVA: 0x7FFE82A83D90
    }

    public class CinemachineTrackedDolly : CinemachineComponentBase
    {
        public Cinemachine.CinemachinePathBase m_Path; // 0x28
        public float m_PathPosition; // 0x30
        public 0x666241DC m_PositionUnits; // 0x34

        // ── Methods ──
        public void get_IsValid(){} // RVA: 0x7FFE82A99C70
        public void get_Stage(){} // RVA: 0x7FFE813240E0
        public void GetMaxDampTime(){} // RVA: 0x7FFE82A99D90
        public void MutateCameraState(){} // RVA: 0x7FFE82A99E40
        public void GetCameraOrientationAtPathPoint(){} // RVA: 0x7FFE82A9B0D0
        public void get_AngularDamping(){} // RVA: 0x7FFE82A9B7B0
        public void .ctor(){} // RVA: 0x7FFE82A9B860
    }

    public class CinemachineTransposer : CinemachineComponentBase
    {
        public 0x6662378C m_BindingMode; // 0x28
        public UnityEngine.Vector3 m_FollowOffset; // 0x2C
        public float m_XDamping; // 0x38
        public float m_YDamping; // 0x3C
        public float m_ZDamping; // 0x40
        public 0x666237E4 m_AngularDampingMode; // 0x44

        // ── Methods ──
        public void OnValidate(){} // RVA: 0x7FFE82A9B9C0
        public void get_HideOffsetInInspector(){} // RVA: 0x7FFE813A1140
        public void set_HideOffsetInInspector(){} // RVA: 0x7FFE819E83C0
        public void get_EffectiveOffset(){} // RVA: 0x7FFE82A9BA10
        public void get_IsValid(){} // RVA: 0x7FFE82A9BA50
        public void get_Stage(){} // RVA: 0x7FFE813240E0
        public void GetMaxDampTime(){} // RVA: 0x7FFE82A9BB70
        public void MutateCameraState(){} // RVA: 0x7FFE82A9BC00
        public void OnTargetObjectWarped(){} // RVA: 0x7FFE82A9C2E0
        public void ForceCameraPosition(){} // RVA: 0x7FFE82A9C450
        public void InitPrevFrameStateInfo(){} // RVA: 0x7FFE82A9C790
        public void TrackTarget(){} // RVA: 0x7FFE82A9C9F0
        public void GetOffsetForMinimumTargetDistance(){} // RVA: 0x7FFE82A9DB40
        public void get_Damping(){} // RVA: 0x7FFE82A9E0E0
        public void get_AngularDamping(){} // RVA: 0x7FFE82A9E120
        public void GetTargetCameraPosition(){} // RVA: 0x7FFE82A9E200
        public void GetReferenceOrientation(){} // RVA: 0x7FFE82A9E500
        public void .ctor(){} // RVA: 0x7FFE82A9EB80
    }

    public class CinemachineTriggerAction : MonoBehaviour
    {
        // ── Methods ──
        public void Filter(){} // RVA: 0x7FFE82ABB3D0
        public void InternalDoTriggerEnter(){} // RVA: 0x7FFE82ABB4F0
        public void InternalDoTriggerExit(){} // RVA: 0x7FFE82ABB680
        public void OnTriggerEnter(){} // RVA: 0x7FFE82ABB760
        public void OnTriggerExit(){} // RVA: 0x7FFE82ABB7E0
        public void OnCollisionEnter(){} // RVA: 0x7FFE82ABB860
        public void OnCollisionExit(){} // RVA: 0x7FFE82ABB8A0
        public void OnTriggerEnter2D(){} // RVA: 0x7FFE82ABB760
        public void OnTriggerExit2D(){} // RVA: 0x7FFE82ABB7E0
        public void OnCollisionEnter2D(){} // RVA: 0x7FFE82ABB8E0
        public void OnCollisionExit2D(){} // RVA: 0x7FFE82ABB920
        public void OnEnable(){} // RVA: 0x7FFE810FB310
        public void .ctor(){} // RVA: 0x7FFE82ABB960
    }

    public class CinemachineVirtualCamera : CinemachineVirtualCameraBase
    {
        public UnityEngine.Transform m_LookAt; // 0xA8
        public UnityEngine.Transform m_Follow; // 0xB0
        public Cinemachine.LensSettings m_Lens; // 0xB8

        // ── Methods ──
        public void get_State(){} // RVA: 0x7FFE82A79640
        public void get_LookAt(){} // RVA: 0x7FFE82A57E90
        public void set_LookAt(){} // RVA: 0x7FFE81857260
        public void get_Follow(){} // RVA: 0x7FFE82A57EA0
        public void set_Follow(){} // RVA: 0x7FFE81166050
        public void GetMaxDampTime(){} // RVA: 0x7FFE82A83F90
        public void InternalUpdateCameraState(){} // RVA: 0x7FFE82A84100
        public void OnEnable(){} // RVA: 0x7FFE82A845E0
        public void OnDestroy(){} // RVA: 0x7FFE82A84C60
        public void OnValidate(){} // RVA: 0x7FFE82A84FF0
        public void OnTransformChildrenChanged(){} // RVA: 0x7FFE82A850D0
        public void Reset(){} // RVA: 0x7FFE82A85130
        public void DestroyPipeline(){} // RVA: 0x7FFE82A85150
        public void CreatePipeline(){} // RVA: 0x7FFE82A85880
        public void InvalidateComponentPipeline(){} // RVA: 0x7FFE82A850D0
        public void GetComponentOwner(){} // RVA: 0x7FFE82A85BF0
        public void GetComponentPipeline(){} // RVA: 0x7FFE82A85C10
        public void GetCinemachineComponent(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void AddCinemachineComponent(){} // RVA: 0x7FFE810A1420
        public void DestroyCinemachineComponent(){} // RVA: 0x7FFE80E45FE0
        public void UpdateComponentPipeline(){} // RVA: 0x7FFE82A85CC0
        public void SetFlagsForHiddenChild(){} // RVA: 0x7FFE82A86530
        public void CalculateNewState(){} // RVA: 0x7FFE82A866E0
        public void OnTargetObjectWarped(){} // RVA: 0x7FFE82A871A0
        public void ForceCameraPosition(){} // RVA: 0x7FFE82A87530
        public void SetStateRawPosition(){} // RVA: 0x7FFE82A877B0
        public void OnTransitionFromCamera(){} // RVA: 0x7FFE82A877D0
        public void RequiresUserInput(){} // RVA: 0x7FFE82A87CE0
        public void OnBeforeSerialize(){} // RVA: 0x7FFE82A87FA0
        public void .ctor(){} // RVA: 0x7FFE82A88080
    }

    public class CinemachineVirtualCameraBase : MonoBehaviour
    {
        public string[] m_ExcludedPropertiesInInspector; // 0x20
        public 0x66623E14[] m_LockStageInInspector; // 0x28
        public int m_ValidatingStreamVersion; // 0x30
        public bool m_OnValidateCalled; // 0x34
        public int m_StreamingVersion; // 0x38
        public int m_Priority; // 0x3C
        public int m_ActivationId; // 0x40
        public float FollowTargetAttachment; // 0x44
        public float LookAtTargetAttachment; // 0x48
        public 0x666246AC m_StandbyUpdate; // 0x4C
        public System.Collections.Generic.List`1<Cinemachine.CinemachineExtension> _mExtensions; // 0x50
        public bool _previousStateIsValid; // 0x58
        public bool m_WasStarted; // 0x59
        public bool mSlaveStatusUpdated; // 0x5A
        public Cinemachine.CinemachineVirtualCameraBase m_parentVcam; // 0x60
        public int m_QueuePriority; // 0x68
        public float m_blendStartPosition; // 0x6C
        public UnityEngine.Transform m_CachedFollowTarget; // 0x70

        // ── Methods ──
        public void get_ValidatingStreamVersion(){} // RVA: 0x7FFE82AADDB0
        public void set_ValidatingStreamVersion(){} // RVA: 0x7FFE81156CE0
        public void GetMaxDampTime(){} // RVA: 0x7FFE82AADE20
        public void DetachedFollowTargetDamp(){} // RVA: 0x7FFE82AAE120 | overloaded x3
        public void DetachedLookAtTargetDamp(){} // RVA: 0x7FFE82AAE3F0 | overloaded x3
        public void AddExtension(){} // RVA: 0x7FFE82AAE4A0
        public void RemoveExtension(){} // RVA: 0x7FFE82AAE600
        public void get_mExtensions(){} // RVA: 0x7FFE8119C0E0
        public void set_mExtensions(){} // RVA: 0x7FFE812534D0
        public void InvokePostPipelineStageCallback(){} // RVA: 0x7FFE82AAE660
        public void InvokePrePipelineMutateCameraStateCallback(){} // RVA: 0x7FFE82AAE950
        public void InvokeOnTransitionInExtensions(){} // RVA: 0x7FFE82AAEC30
        public void get_Name(){} // RVA: 0x7FFE813A1D90
        public void get_Description(){} // RVA: 0x7FFE82AAEE50
        public void get_Priority(){} // RVA: 0x7FFE816311C0
        public void set_Priority(){} // RVA: 0x7FFE82A4B070
        public void ApplyPositionBlendMethod(){} // RVA: 0x7FFE82AAEE90
        public void get_VirtualCameraGameObject(){} // RVA: 0x7FFE82AAEEC0
        public void get_IsValid(){} // RVA: 0x7FFE82AAEFD0
        public void get_State(){}
        public void get_ParentCamera(){} // RVA: 0x7FFE82AAF0A0
        public void IsLiveChild(){} // RVA: 0x7FFE810FB320
        public void get_LookAt(){} // RVA: 0x7FFE80E2E2E0
        public void set_LookAt(){} // RVA: 0x7FFE80E460A0
        public void get_Follow(){} // RVA: 0x7FFE80E2E2E0
        public void set_Follow(){} // RVA: 0x7FFE80E460A0
        public void get_PreviousStateIsValid(){} // RVA: 0x7FFE813A1140
        public void set_PreviousStateIsValid(){} // RVA: 0x7FFE819E83C0
        public void UpdateCameraState(){} // RVA: 0x7FFE82AAF140
        public void InternalUpdateCameraState(){}
        public void OnTransitionFromCamera(){} // RVA: 0x7FFE82AAF1E0
        public void OnDestroy(){} // RVA: 0x7FFE82AAF2B0
        public void OnTransformParentChanged(){} // RVA: 0x7FFE82AAF3E0
        public void Start(){} // RVA: 0x7FFE812AF390
        public void RequiresUserInput(){} // RVA: 0x7FFE82AAF480
        public void EnsureStarted(){} // RVA: 0x7FFE82AAF600
        public void GetInputAxisProvider(){} // RVA: 0x7FFE82AAF6C0
        public void OnValidate(){} // RVA: 0x7FFE82AAF780
        public void OnEnable(){} // RVA: 0x7FFE82AAF7F0
        public void OnDisable(){} // RVA: 0x7FFE82AAFB60
        public void Update(){} // RVA: 0x7FFE82AAFBD0
        public void UpdateSlaveStatus(){} // RVA: 0x7FFE82AAFBE0
        public void ResolveLookAt(){} // RVA: 0x7FFE82AAFDC0
        public void ResolveFollow(){} // RVA: 0x7FFE82AAFEE0
        public void UpdateVcamPoolStatus(){} // RVA: 0x7FFE82AB0000
        public void MoveToTopOfPrioritySubqueue(){} // RVA: 0x7FFE82AB0230
        public void OnTargetObjectWarped(){} // RVA: 0x7FFE82AB0240
        public void ForceCameraPosition(){} // RVA: 0x7FFE82AB0340
        public void GetInheritPosition(){} // RVA: 0x7FFE82AB0450
        public void CreateBlend(){} // RVA: 0x7FFE82AB0560
        public void PullStateFromVirtualCamera(){} // RVA: 0x7FFE82AB09C0
        public void InvalidateCachedTargets(){} // RVA: 0x7FFE82AB0CF0
        public void get_FollowTargetChanged(){} // RVA: 0x7FFE820E9360
        public void set_FollowTargetChanged(){} // RVA: 0x7FFE818DBD80
        public void get_LookAtTargetChanged(){} // RVA: 0x7FFE82AB0F00
        public void set_LookAtTargetChanged(){} // RVA: 0x7FFE82AB0F10
        public void UpdateTargetCache(){} // RVA: 0x7FFE82AB0F20
        public void get_AbstractFollowTargetGroup(){} // RVA: 0x7FFE81280C30
        public void get_FollowTargetAsVcam(){} // RVA: 0x7FFE81463AE0
        public void get_AbstractLookAtTargetGroup(){} // RVA: 0x7FFE817AE360
        public void get_LookAtTargetAsVcam(){} // RVA: 0x7FFE8154EB60
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFE82AB1520
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFE82AB1540
        public void LegacyUpgrade(){} // RVA: 0x7FFE810FB310
        public void OnBeforeSerialize(){} // RVA: 0x7FFE810FB310
        public void CancelDamping(){} // RVA: 0x7FFE82AB15F0
        public void .ctor(){} // RVA: 0x7FFE82AB1850
    }

    public class ClipperLib : Object
    {
    }

    public class ConfinerOven : Object
    {
        public float m_MinFrustumHeightWithBones; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82AB1AF0
        public void GetBakedSolution(){} // RVA: 0x7FFE82AB1C20
        public void get_State(){} // RVA: 0x7FFE8175AC90
        public void set_State(){} // RVA: 0x7FFE8175AE70
        public void Initialize(){} // RVA: 0x7FFE82AB2080
        public void BakeConfiner(){} // RVA: 0x7FFE82AB28E0
        public void <Initialize>g__GetPolygonBoundingBox|24_0(){} // RVA: 0x7FFE82AB2F30
        public void <Initialize>g__MidPointOfIntRect|24_1(){} // RVA: 0x7FFE82AB30F0
        public void <BakeConfiner>g__ComputeSkeleton|25_0(){} // RVA: 0x7FFE82AB3120
    }

    public class Documentation : Object
    {
    }

    public class DocumentationSortingAttribute : Attribute
    {
        public dFixup.est _category; // 0x10

        // ── Methods ──
        public void get_Category(){} // RVA: 0x7FFE811485C0
        public void set_Category(){} // RVA: 0x7FFE810FE0C0
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
    }

    public class GroupWeightManipulator : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFE82ABC870
        public void OnValidate(){} // RVA: 0x7FFE82ABC900
        public void Update(){} // RVA: 0x7FFE82ABC970
        public void UpdateWeights(){} // RVA: 0x7FFE82ABCB40
        public void .ctor(){} // RVA: 0x7FFE82ABCC30
    }

    public class ICameraOverrideStack
    {
        // ── Methods ──
        public void SetCameraOverride(){}
        public void ReleaseCameraOverride(){} // RVA: 0x7FFE80E46530
        public void get_DefaultWorldUp(){} // RVA: 0x7FFE80E2DCF0
    }

    public class ICinemachineCamera
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFE80E2E2E0
        public void get_Description(){} // RVA: 0x7FFE80E2E2E0
        public void get_Priority(){} // RVA: 0x7FFE80E2EDB0
        public void set_Priority(){} // RVA: 0x7FFE80E46530
        public void get_LookAt(){} // RVA: 0x7FFE80E2E2E0
        public void set_LookAt(){} // RVA: 0x7FFE80E460A0
        public void get_Follow(){} // RVA: 0x7FFE80E2E2E0
        public void set_Follow(){} // RVA: 0x7FFE80E460A0
        public void get_State(){}
        public void get_VirtualCameraGameObject(){} // RVA: 0x7FFE80E2E2E0
        public void get_IsValid(){} // RVA: 0x7FFE80E2F150
        public void get_ParentCamera(){} // RVA: 0x7FFE80E2E2E0
        public void IsLiveChild(){}
        public void UpdateCameraState(){}
        public void InternalUpdateCameraState(){}
        public void OnTransitionFromCamera(){}
        public void OnTargetObjectWarped(){}
    }

    public class ICinemachineTargetGroup
    {
        // ── Methods ──
        public void get_Transform(){} // RVA: 0x7FFE80E2E2E0
        public void get_BoundingBox(){}
        public void get_Sphere(){}
        public void get_IsEmpty(){} // RVA: 0x7FFE80E2F150
        public void GetViewSpaceBoundingBox(){}
        public void GetViewSpaceAngularBounds(){}
    }

    public class ISignalSource6D
    {
        // ── Methods ──
        public void get_SignalDuration(){} // RVA: 0x7FFE80E42E10
        public void GetSignal(){}
    }

    public class LensSettings : ValueType
    {
        public Cinemachine.LensSettings Default;
        public float FieldOfView; // 0x10
        public float OrthographicSize; // 0x14
        public float NearClipPlane; // 0x18

        // ── Methods ──
        public void get_Orthographic(){} // RVA: 0x7FFE82AB46A0
        public void set_Orthographic(){} // RVA: 0x7FFE82AB46C0
        public void get_SensorSize(){} // RVA: 0x7FFE8267BED0
        public void set_SensorSize(){} // RVA: 0x7FFE8164D390
        public void get_Aspect(){} // RVA: 0x7FFE82AB46D0
        public void get_IsPhysicalCamera(){} // RVA: 0x7FFE82AB4760
        public void set_IsPhysicalCamera(){} // RVA: 0x7FFE82AB4780
        public void FromCamera(){} // RVA: 0x7FFE82AB4790
        public void SnapshotCameraReadOnlyProperties(){} // RVA: 0x7FFE82AB4F30 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE82AB5040
        public void Lerp(){} // RVA: 0x7FFE82AB5090
        public void Validate(){} // RVA: 0x7FFE82AB52F0
        public void .cctor(){} // RVA: 0x7FFE82AB5370
    }

    public class LensSettingsPropertyAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class NoSaveDuringPlayAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class NoiseSettings : SignalSourceAsset
    {
        public TransformNoiseParams[] PositionNoise; // 0x18

        // ── Methods ──
        public void GetCombinedFilterResults(){} // RVA: 0x7FFE82AB5400
        public void get_SignalDuration(){} // RVA: 0x7FFE8186F320
        public void GetSignal(){} // RVA: 0x7FFE82AB5580
        public void .ctor(){} // RVA: 0x7FFE82AB5730
    }

    public class NoiseSettingsPropertyAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class NotNullAttribute : Object
    {
        public string _name; // 0x10
        public int _priority; // 0x18
        public UnityEngine.Transform _lookAt; // 0x20
        public UnityEngine.Transform _follow; // 0x28
        public Cinemachine.CameraState _state; // 0x30
        public object field_5; // 0x83
        public object field_6; // 0x84
        public object field_7; // 0x85
        public object field_8; // 0x86

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82AA6B40
        public void SetState(){} // RVA: 0x7FFE82AA6C40
        public void get_Name(){} // RVA: 0x7FFE81116380
        public void set_Name(){} // RVA: 0x7FFE810FCE30
        public void get_Description(){} // RVA: 0x7FFE82AA6CF0
        public void get_Priority(){} // RVA: 0x7FFE813DB630
        public void set_Priority(){} // RVA: 0x7FFE8144DF00
        public void get_LookAt(){} // RVA: 0x7FFE811290C0
        public void set_LookAt(){} // RVA: 0x7FFE811290D0
        public void get_Follow(){} // RVA: 0x7FFE81129130
        public void set_Follow(){} // RVA: 0x7FFE810FCE90
        public void get_State(){} // RVA: 0x7FFE82AA6D30
        public void set_State(){} // RVA: 0x7FFE82AA6DD0
        public void get_VirtualCameraGameObject(){} // RVA: 0x7FFE813240E0
        public void get_IsValid(){} // RVA: 0x7FFE811E0850
        public void get_ParentCamera(){} // RVA: 0x7FFE813240E0
        public void IsLiveChild(){} // RVA: 0x7FFE810FB320
        public void UpdateCameraState(){} // RVA: 0x7FFE810FB310
        public void InternalUpdateCameraState(){} // RVA: 0x7FFE810FB310
        public void OnTransitionFromCamera(){} // RVA: 0x7FFE810FB310
        public void OnTargetObjectWarped(){} // RVA: 0x7FFE810FB310
    }

    public class OrbitalTransposerHeadingPropertyAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class RuntimeUtility : Object
    {
        // ── Methods ──
        public void DestroyObject(){} // RVA: 0x7FFE82AB5970
        public void IsPrefab(){} // RVA: 0x7FFE810FB320
        public void RaycastIgnoreTag(){} // RVA: 0x7FFE82AB5A60
        public void SphereCastIgnoreTag(){} // RVA: 0x7FFE82AB5E20
        public void GetScratchCollider(){} // RVA: 0x7FFE82AB6990
        public void DestroyScratchCollider(){} // RVA: 0x7FFE82AB6F30
        public void NormalizeCurve(){} // RVA: 0x7FFE82AB7220
        public void .cctor(){} // RVA: 0x7FFE82AB7490
    }

    public class SaveDuringPlayAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class SignalSourceAsset : ScriptableObject
    {
        // ── Methods ──
        public void get_SignalDuration(){} // RVA: 0x7FFE80E42E10
        public void GetSignal(){}
        public void .ctor(){} // RVA: 0x7FFE81345B60
    }

    public class TagFieldAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class TargetPositionCache : Object
    {
        public bool UseCache;
        public float CacheStepSize;
        public 0x66624DE4 m_CacheMode; // 0x4
        public float CurrentTime; // 0x8
        public int CurrentFrame; // 0xC
        public bool IsCameraCut; // 0x10

        // ── Methods ──
        public void get_CacheMode(){} // RVA: 0x7FFE82AB75E0
        public void set_CacheMode(){} // RVA: 0x7FFE82AB7620
        public void get_IsRecording(){} // RVA: 0x7FFE82AB7690
        public void get_CurrentPlaybackTimeValid(){} // RVA: 0x7FFE82AB76E0
        public void get_IsEmpty(){} // RVA: 0x7FFE82AB7770
        public void get_CacheTimeRange(){} // RVA: 0x7FFE82AB77C0
        public void get_HasCurrentTime(){} // RVA: 0x7FFE82AB7810
        public void ClearCache(){} // RVA: 0x7FFE82AB7870
        public void CreatePlaybackCurves(){} // RVA: 0x7FFE82AB79E0
        public void GetTargetPosition(){} // RVA: 0x7FFE82AB7C30
        public void GetTargetRotation(){} // RVA: 0x7FFE82AB80F0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class UpdateTracker : Object
    {
        // ── Methods ──
        public void InitializeModule(){} // RVA: 0x7FFE82AB9900
        public void UpdateTargets(){} // RVA: 0x7FFE82AB9980
        public void GetPreferredUpdate(){} // RVA: 0x7FFE82AB9E80
        public void OnUpdate(){} // RVA: 0x7FFE82ABA1F0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE82ABA2B0
    }

    public class VcamTargetPropertyAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

}