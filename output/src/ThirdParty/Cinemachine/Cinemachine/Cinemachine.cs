// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Cinemachine.Cinemachine
// Classes: 83
// Methods: 917

namespace ThirdParty.Cinemachine.Cinemachine
{
    public class AxisBase
    {
        // ── Methods ──
        public void Validate(){} // RVA: 0x7FFAF47CE3C0
    }

    public class AxisState
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF47C0E70
        public void Validate(){} // RVA: 0x7FFAF47C0FE0
        public void Reset(){} // RVA: 0x7FFAF47C1040
        public void SetInputAxisProvider(){} // RVA: 0x7FFAF47C1050
        public void get_HasInputProvider(){} // RVA: 0x7FFAF47C10B0
        public void Update(){} // RVA: 0x7FFAF47C10C0
        public void ClampValue(){} // RVA: 0x7FFAF47C15C0
        public void MaxSpeedUpdate(){} // RVA: 0x7FFAF47C1630
        public void GetMaxSpeed(){} // RVA: 0x7FFAF47C1870
        public void get_ValueRangeLocked(){} // RVA: 0x7FFAF47C1920
        public void set_ValueRangeLocked(){} // RVA: 0x7FFAF47C1930
        public void get_HasRecentering(){} // RVA: 0x7FFAF47C1940
        public void set_HasRecentering(){} // RVA: 0x7FFAF47C1950
    }

    public class AxisStatePropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class BlendSourceVirtualCamera
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void get_Blend(){} // RVA: 0x7FFAF2DA8380
        public void set_Blend(){} // RVA: 0x7FFAF2D8EE30
        public void get_Name(){} // RVA: 0x7FFAF47C9030
        public void get_Description(){} // RVA: 0x7FFAF47C9070
        public void get_Priority(){} // RVA: 0x7FFAF306ED50
        public void set_Priority(){} // RVA: 0x7FFAF30E74E0
        public void get_LookAt(){} // RVA: 0x7FFAF2DBB0C0
        public void set_LookAt(){} // RVA: 0x7FFAF2DBB0D0
        public void get_Follow(){} // RVA: 0x7FFAF2DBB130
        public void set_Follow(){} // RVA: 0x7FFAF2D8EE90
        public void get_State(){} // RVA: 0x7FFAF47C8EB0
        public void set_State(){} // RVA: 0x7FFAF47C8F50
        public void get_VirtualCameraGameObject(){} // RVA: 0x7FFAF2FC9240
        public void get_IsValid(){} // RVA: 0x7FFAF47C90C0
        public void get_ParentCamera(){} // RVA: 0x7FFAF2FC9240
        public void IsLiveChild(){} // RVA: 0x7FFAF47C90E0
        public void CalculateNewState(){} // RVA: 0x7FFAF47C8EB0
        public void UpdateCameraState(){} // RVA: 0x7FFAF47C9100
        public void InternalUpdateCameraState(){} // RVA: 0x7FFAF2D8D310
        public void OnTransitionFromCamera(){} // RVA: 0x7FFAF2D8D310
        public void OnTargetObjectWarped(){} // RVA: 0x7FFAF2D8D310
    }

    public class CameraState
    {
        public object rectTransform;
        public object showMaskGraphic;
        public object graphic;

        // ── Methods ──
        public void get_HasLookAt(){} // RVA: 0x7FFAF47C1D30
        public void get_CorrectedPosition(){} // RVA: 0x7FFAF47C1D90
        public void get_CorrectedOrientation(){} // RVA: 0x7FFAF47C1DE0
        public void get_FinalPosition(){} // RVA: 0x7FFAF47C1D90
        public void get_FinalOrientation(){} // RVA: 0x7FFAF47C1F50
        public void get_Default(){} // RVA: 0x7FFAF47C2210
        public void get_NumCustomBlendables(){} // RVA: 0x7FFAF47C2470
        public void set_NumCustomBlendables(){} // RVA: 0x7FFAF47C2480
        public void GetCustomBlendable(){} // RVA: 0x7FFAF47C2490
        public void FindCustomBlendable(){} // RVA: 0x7FFAF47C2600
        public void AddCustomBlendable(){} // RVA: 0x7FFAF47C2B80
        public void Lerp(){} // RVA: 0x7FFAF47C2F40
        public void InterpolateFOV(){} // RVA: 0x7FFAF47C6FA0
        public void ApplyPosBlendHint(){} // RVA: 0x7FFAF47C70F0
        public void ApplyRotBlendHint(){} // RVA: 0x7FFAF47C7170
        public void InterpolatePosition(){} // RVA: 0x7FFAF47C71C0
        public void .cctor(){} // RVA: 0x7FFAF47C76B0
    }

    public class Cinemachine3rdPersonAim
    {
        // ── Methods ──
        public void get_AimTarget(){} // RVA: 0x7FFAF2DF3FA0
        public void set_AimTarget(){} // RVA: 0x7FFAF2DF3FC0
        public void OnValidate(){} // RVA: 0x7FFAF4778960
        public void Reset(){} // RVA: 0x7FFAF4778980
        public void OnTransitionFromCamera(){} // RVA: 0x7FFAF4778A90
        public void DrawReticle(){} // RVA: 0x7FFAF4778C10
        public void ComputeLookAtPoint(){} // RVA: 0x7FFAF4778FA0
        public void ComputeAimTarget(){} // RVA: 0x7FFAF47795D0
        public void PostPipelineStageCallback(){} // RVA: 0x7FFAF4779850
        public void .ctor(){} // RVA: 0x7FFAF4779BA0
    }

    public class Cinemachine3rdPersonFollow
    {
        // ── Methods ──
        public void OnValidate(){} // RVA: 0x7FFAF47AA610
        public void Reset(){} // RVA: 0x7FFAF47AA690
        public void OnDestroy(){} // RVA: 0x7FFAF47AA700
        public void get_IsValid(){} // RVA: 0x7FFAF47AA750
        public void get_Stage(){} // RVA: 0x7FFAF2FC9240
        public void GetMaxDampTime(){} // RVA: 0x7FFAF47AA870
        public void MutateCameraState(){} // RVA: 0x7FFAF47AA8A0
        public void OnTargetObjectWarped(){} // RVA: 0x7FFAF47AA930
        public void PositionCamera(){} // RVA: 0x7FFAF47AAAA0
        public void GetRigPositions(){} // RVA: 0x7FFAF47AB1C0
        public void GetHeading(){} // RVA: 0x7FFAF47AB3E0
        public void GetRawRigPositions(){} // RVA: 0x7FFAF47AB960
        public void ResolveCollisions(){} // RVA: 0x7FFAF47ABCE0
        public void .ctor(){} // RVA: 0x7FFAF47AC030
    }

    public class CinemachineBasicMultiChannelPerlin
    {
        // ── Methods ──
        public void get_IsValid(){} // RVA: 0x7FFAF47AC100
        public void get_Stage(){} // RVA: 0x7FFAF2E92CB0
        public void MutateCameraState(){} // RVA: 0x7FFAF47AC220
        public void ReSeed(){} // RVA: 0x7FFAF47ACD00
        public void Initialize(){} // RVA: 0x7FFAF47ACE30
        public void .ctor(){} // RVA: 0x7FFAF47AD040
    }

    public class CinemachineBlend
    {
        // ── Methods ──
        public void get_BlendWeight(){} // RVA: 0x7FFAF47C7700
        public void get_IsValid(){} // RVA: 0x7FFAF47C77F0
        public void get_IsComplete(){} // RVA: 0x7FFAF47C7870
        public void get_Description(){} // RVA: 0x7FFAF47C78A0
        public void Uses(){} // RVA: 0x7FFAF47C7AB0
        public void .ctor(){} // RVA: 0x7FFAF47C7BF0
        public void UpdateCameraState(){} // RVA: 0x7FFAF47C7D10
        public void get_State(){} // RVA: 0x7FFAF47C7E00
    }

    public class CinemachineBlendDefinition
    {
        public object Name;
        public object Description;

        // ── Methods ──
        public void get_BlendTime(){} // RVA: 0x7FFAF47C82D0
        public void .ctor(){} // RVA: 0x7FFAF47C82E0
        public void CreateStandardCurves(){} // RVA: 0x7FFAF47C8340
        public void get_BlendCurve(){} // RVA: 0x7FFAF47C8BB0
    }

    public class CinemachineBlendDefinitionPropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class CinemachineBlendListCamera
    {
        // ── Methods ──
        public void get_Description(){} // RVA: 0x7FFAF4779C70
        public void Reset(){} // RVA: 0x7FFAF4779DB0
        public void get_LiveChild(){} // RVA: 0x7FFAF2EAA100
        public void set_LiveChild(){} // RVA: 0x7FFAF2EAA110
        public void IsLiveChild(){} // RVA: 0x7FFAF4779F20
        public void get_State(){} // RVA: 0x7FFAF4779F50
        public void get_LookAt(){} // RVA: 0x7FFAF4779FF0
        public void set_LookAt(){} // RVA: 0x7FFAF3595030
        public void get_Follow(){} // RVA: 0x7FFAF477A000
        public void set_Follow(){} // RVA: 0x7FFAF2DF8050
        public void OnTargetObjectWarped(){} // RVA: 0x7FFAF477A010
        public void ForceCameraPosition(){} // RVA: 0x7FFAF477A0F0
        public void OnTransitionFromCamera(){} // RVA: 0x7FFAF477A280
        public void InternalUpdateCameraState(){} // RVA: 0x7FFAF477A4B0
        public void OnEnable(){} // RVA: 0x7FFAF477AE80
        public void OnDisable(){} // RVA: 0x7FFAF477B1E0
        public void OnTransformChildrenChanged(){} // RVA: 0x7FFAF477B360
        public void OnGuiHandler(){} // RVA: 0x7FFAF477B370
        public void get_ChildCameras(){} // RVA: 0x7FFAF477B4E0
        public void get_IsBlending(){} // RVA: 0x7FFAF477B500
        public void InvalidateListOfChildren(){} // RVA: 0x7FFAF477B510
        public void UpdateListOfChildren(){} // RVA: 0x7FFAF477B5D0
        public void ValidateInstructions(){} // RVA: 0x7FFAF477B960
        public void AdvanceCurrentInstruction(){} // RVA: 0x7FFAF477BD60
        public void .ctor(){} // RVA: 0x7FFAF477BFC0
    }

    public class CinemachineBlenderSettings
    {
        // ── Methods ──
        public void GetBlendForVirtualCameras(){} // RVA: 0x7FFAF47C92D0
        public void .ctor(){} // RVA: 0x7FFAF2FEBFB0
    }

    public class CinemachineBrain
    {
        // ── Methods ──
        public void get_OutputCamera(){} // RVA: 0x7FFAF477C190
        public void get_ControlledObject(){} // RVA: 0x7FFAF477C300
        public void set_ControlledObject(){} // RVA: 0x7FFAF477C420
        public void get_SoloCamera(){} // RVA: 0x7FFAF477C4E0
        public void set_SoloCamera(){} // RVA: 0x7FFAF477C540
        public void GetSoloGUIColor(){} // RVA: 0x7FFAF477C7A0
        public void get_DefaultWorldUp(){} // RVA: 0x7FFAF477C7C0
        public void OnEnable(){} // RVA: 0x7FFAF477C950
        public void OnDisable(){} // RVA: 0x7FFAF477CEC0
        public void OnSceneLoaded(){} // RVA: 0x7FFAF477D1C0
        public void OnSceneUnloaded(){} // RVA: 0x7FFAF477D260
        public void Awake(){} // RVA: 0x7FFAF477D300
        public void Start(){} // RVA: 0x7FFAF477D360
        public void OnGuiHandler(){} // RVA: 0x7FFAF477D380
        public void AfterPhysics(){} // RVA: 0x7FFAF477D860
        public void LateUpdate(){} // RVA: 0x7FFAF477D900
        public void ManualUpdate(){} // RVA: 0x7FFAF477D910
        public void GetEffectiveDeltaTime(){} // RVA: 0x7FFAF477DC40
        public void UpdateVirtualCameras(){} // RVA: 0x7FFAF477DEE0
        public void get_ActiveVirtualCamera(){} // RVA: 0x7FFAF477E270
        public void DeepCamBFromBlend(){} // RVA: 0x7FFAF477E3F0
        public void IsLiveInBlend(){} // RVA: 0x7FFAF477E4B0
        public void get_IsBlending(){} // RVA: 0x7FFAF477E5F0
        public void get_ActiveBlend(){} // RVA: 0x7FFAF477E610
        public void set_ActiveBlend(){} // RVA: 0x7FFAF477E710
        public void GetBrainFrame(){} // RVA: 0x7FFAF477E830
        public void SetCameraOverride(){} // RVA: 0x7FFAF477E970
        public void ReleaseCameraOverride(){} // RVA: 0x7FFAF477EEA0
        public void ProcessActiveCamera(){} // RVA: 0x7FFAF477EF80
        public void UpdateFrame0(){} // RVA: 0x7FFAF477F6D0
        public void ComputeCurrentBlend(){} // RVA: 0x7FFAF477FF00
        public void IsLive(){} // RVA: 0x7FFAF4780500
        public void get_CurrentCameraState(){} // RVA: 0x7FFAF47806E0
        public void set_CurrentCameraState(){} // RVA: 0x7FFAF4780780
        public void TopCameraFromPriorityQueue(){} // RVA: 0x7FFAF4780870
        public void LookupBlend(){} // RVA: 0x7FFAF4780BA0
        public void PushStateToUnityCamera(){} // RVA: 0x7FFAF4780E00
        public void .ctor(){} // RVA: 0x7FFAF4781490
        public void .cctor(){} // RVA: 0x7FFAF47818F0
    }

    public class CinemachineClearShot
    {
        // ── Methods ──
        public void get_Description(){} // RVA: 0x7FFAF4781EB0
        public void get_LiveChild(){} // RVA: 0x7FFAF2DF82A0
        public void set_LiveChild(){} // RVA: 0x7FFAF2DF82B0
        public void get_State(){} // RVA: 0x7FFAF4781FF0
        public void IsLiveChild(){} // RVA: 0x7FFAF4782090
        public void get_LookAt(){} // RVA: 0x7FFAF4779FF0
        public void set_LookAt(){} // RVA: 0x7FFAF3595030
        public void get_Follow(){} // RVA: 0x7FFAF477A000
        public void set_Follow(){} // RVA: 0x7FFAF2DF8050
        public void OnTargetObjectWarped(){} // RVA: 0x7FFAF47820C0
        public void ForceCameraPosition(){} // RVA: 0x7FFAF47821A0
        public void InternalUpdateCameraState(){} // RVA: 0x7FFAF4782330
        public void OnEnable(){} // RVA: 0x7FFAF4782A70
        public void OnDisable(){} // RVA: 0x7FFAF4782D80
        public void OnTransformChildrenChanged(){} // RVA: 0x7FFAF4782F00
        public void OnGuiHandler(){} // RVA: 0x7FFAF4782F20
        public void get_IsBlending(){} // RVA: 0x7FFAF4783090
        public void get_ActiveBlend(){} // RVA: 0x7FFAF3842860
        public void get_ChildCameras(){} // RVA: 0x7FFAF47830A0
        public void InvalidateListOfChildren(){} // RVA: 0x7FFAF47830C0
        public void ResetRandomization(){} // RVA: 0x7FFAF47831E0
        public void UpdateListOfChildren(){} // RVA: 0x7FFAF4783260
        public void ChooseCurrentCamera(){} // RVA: 0x7FFAF4783720
        public void Randomize(){} // RVA: 0x7FFAF4784100
        public void LookupBlend(){} // RVA: 0x7FFAF4784630
        public void OnTransitionFromCamera(){} // RVA: 0x7FFAF47848A0
        public void .ctor(){} // RVA: 0x7FFAF4784A30
    }

    public class CinemachineCollider
    {
        // ── Methods ──
        public void IsTargetObscured(){} // RVA: 0x7FFAF4784D80
        public void CameraWasDisplaced(){} // RVA: 0x7FFAF4784DE0
        public void GetCameraDisplacementDistance(){} // RVA: 0x7FFAF4784E50
        public void OnValidate(){} // RVA: 0x7FFAF4784EC0
        public void OnDestroy(){} // RVA: 0x7FFAF4784F10
        public void get_DebugPaths(){} // RVA: 0x7FFAF4784F80
        public void GetMaxDampTime(){} // RVA: 0x7FFAF47851A0
        public void OnTargetObjectWarped(){} // RVA: 0x7FFAF47851C0
        public void PostPipelineStageCallback(){} // RVA: 0x7FFAF47852C0
        public void PreserveLineOfSight(){} // RVA: 0x7FFAF4786590
        public void PullCameraInFrontOfNearestObstacle(){} // RVA: 0x7FFAF4786B80
        public void PushCameraBack(){} // RVA: 0x7FFAF47870A0
        public void GetWalkingDirection(){} // RVA: 0x7FFAF4787B30
        public void GetPushBackDistance(){} // RVA: 0x7FFAF4788470
        public void ClampRayToBounds(){} // RVA: 0x7FFAF47885E0
        public void RespectCameraRadius(){} // RVA: 0x7FFAF47894F0
        public void CheckForTargetObstructions(){} // RVA: 0x7FFAF478A1C0
        public void IsTargetOffscreen(){} // RVA: 0x7FFAF478A630
        public void .ctor(){} // RVA: 0x7FFAF478AEB0
        public void .cctor(){} // RVA: 0x7FFAF478B020
    }

    public class CinemachineCollisionImpulseSource
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAF47DEE30
        public void OnEnable(){} // RVA: 0x7FFAF2D8D310
        public void OnCollisionEnter(){} // RVA: 0x7FFAF47DEF50
        public void OnTriggerEnter(){} // RVA: 0x7FFAF47DF000
        public void GetMassAndVelocity(){} // RVA: 0x7FFAF47DF070
        public void GenerateImpactEvent(){} // RVA: 0x7FFAF47DF570
        public void OnCollisionEnter2D(){} // RVA: 0x7FFAF47DF8E0
        public void OnTriggerEnter2D(){} // RVA: 0x7FFAF47DF940
        public void GetMassAndVelocity2D(){} // RVA: 0x7FFAF47DF9B0
        public void GenerateImpactEvent2D(){} // RVA: 0x7FFAF47DFE00
        public void .ctor(){} // RVA: 0x7FFAF47E0170
    }

    public class CinemachineComponentBase
    {
        // ── Methods ──
        public void get_VirtualCamera(){} // RVA: 0x7FFAF47C9630
        public void get_FollowTarget(){} // RVA: 0x7FFAF47C9A40
        public void get_LookAtTarget(){} // RVA: 0x7FFAF47C9B40
        public void get_AbstractFollowTargetGroup(){} // RVA: 0x7FFAF47C9C40
        public void get_FollowTargetGroup(){} // RVA: 0x7FFAF47C9D20
        public void get_FollowTargetPosition(){} // RVA: 0x7FFAF47C9DB0
        public void get_FollowTargetRotation(){} // RVA: 0x7FFAF47CA0B0
        public void get_AbstractLookAtTargetGroup(){} // RVA: 0x7FFAF47CA380
        public void get_LookAtTargetGroup(){} // RVA: 0x7FFAF47CA3B0
        public void get_LookAtTargetPosition(){} // RVA: 0x7FFAF47CA450
        public void get_LookAtTargetRotation(){} // RVA: 0x7FFAF47CA750
        public void get_VcamState(){} // RVA: 0x7FFAF47CAA20
        public void get_IsValid(){} // RVA: 0x7FFAF2ABDBE0
        public void PrePipelineMutateCameraState(){} // RVA: 0x7FFAF2D8D310
        public void get_Stage(){} // RVA: 0x7FFAF2ABD840
        public void get_BodyAppliesAfterAim(){} // RVA: 0x7FFAF2D8D320
        public void MutateCameraState(){} // RVA: 0x7FFAF2AE18E0
        public void OnTransitionFromCamera(){} // RVA: 0x7FFAF2D8D320
        public void OnTargetObjectWarped(){} // RVA: 0x7FFAF2D8D310
        public void ForceCameraPosition(){} // RVA: 0x7FFAF2D8D310
        public void GetMaxDampTime(){} // RVA: 0x7FFAF35AF380
        public void get_RequiresUserInput(){} // RVA: 0x7FFAF2D8D320
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class CinemachineComposer
    {
        // ── Methods ──
        public void get_IsValid(){} // RVA: 0x7FFAF47AD120
        public void get_Stage(){} // RVA: 0x7FFAF2E7FAF0
        public void get_TrackedPoint(){} // RVA: 0x7FFAF47AD240
        public void set_TrackedPoint(){} // RVA: 0x7FFAF47AD260
        public void GetLookAtPointAndSetTrackedPoint(){} // RVA: 0x7FFAF47AD270
        public void OnTargetObjectWarped(){} // RVA: 0x7FFAF47AD740
        public void ForceCameraPosition(){} // RVA: 0x7FFAF47AD940
        public void GetMaxDampTime(){} // RVA: 0x7FFAF47AD960
        public void PrePipelineMutateCameraState(){} // RVA: 0x7FFAF47AD970
        public void MutateCameraState(){} // RVA: 0x7FFAF47ADAB0
        public void get_SoftGuideRect(){} // RVA: 0x7FFAF47AE860
        public void set_SoftGuideRect(){} // RVA: 0x7FFAF47AE8B0
        public void get_HardGuideRect(){} // RVA: 0x7FFAF47AE970
        public void set_HardGuideRect(){} // RVA: 0x7FFAF47AE9F0
        public void RotateToScreenBounds(){} // RVA: 0x7FFAF47AEA60
        public void ClampVerticalBounds(){} // RVA: 0x7FFAF47AED40
        public void .ctor(){} // RVA: 0x7FFAF47AF040
    }

    public class CinemachineConfiner
    {
        // ── Methods ──
        public void CameraWasDisplaced(){} // RVA: 0x7FFAF478B260
        public void GetCameraDisplacementDistance(){} // RVA: 0x7FFAF478B2D0
        public void OnValidate(){} // RVA: 0x7FFAF478B330
        public void ConnectToVcam(){} // RVA: 0x7FFAF478B340
        public void get_IsValid(){} // RVA: 0x7FFAF478B350
        public void GetMaxDampTime(){} // RVA: 0x7FFAF3312910
        public void PostPipelineStageCallback(){} // RVA: 0x7FFAF478B5E0
        public void InvalidatePathCache(){} // RVA: 0x7FFAF478B8C0
        public void ValidatePathCache(){} // RVA: 0x7FFAF478B970
        public void ConfinePoint(){} // RVA: 0x7FFAF478C2B0
        public void ConfineScreenEdges(){} // RVA: 0x7FFAF478C8F0
        public void .ctor(){} // RVA: 0x7FFAF478D120
    }

    public class CinemachineConfiner2D
    {
        // ── Methods ──
        public void InvalidateCache(){} // RVA: 0x7FFAF478D170
        public void ValidateCache(){} // RVA: 0x7FFAF478D180
        public void PostPipelineStageCallback(){} // RVA: 0x7FFAF478D1D0
        public void CalculateHalfFrustumHeight(){} // RVA: 0x7FFAF478DA00
        public void OnValidate(){} // RVA: 0x7FFAF478DAB0
        public void Reset(){} // RVA: 0x7FFAF478DAD0
        public void .ctor(){} // RVA: 0x7FFAF478DAE0
    }

    public class CinemachineCore
    {
        public object State;
        public object LookAt;
        public object Follow;
        public object m_vcamOwner;

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFAF47CABD0
        public void get_DeltaTime(){} // RVA: 0x7FFAF47CAD00
        public void get_CurrentTime(){} // RVA: 0x7FFAF47CADC0
        public void get_BrainCount(){} // RVA: 0x7FFAF47CAE80
        public void GetActiveBrain(){} // RVA: 0x7FFAF47CAED0
        public void AddActiveBrain(){} // RVA: 0x7FFAF47CAF50
        public void RemoveActiveBrain(){} // RVA: 0x7FFAF47CAFF0
        public void get_VirtualCameraCount(){} // RVA: 0x7FFAF47CB050
        public void GetVirtualCamera(){} // RVA: 0x7FFAF47CB0A0
        public void AddActiveCamera(){} // RVA: 0x7FFAF47CB260
        public void RemoveActiveCamera(){} // RVA: 0x7FFAF47CB2D0
        public void CameraDestroyed(){} // RVA: 0x7FFAF47CB350
        public void CameraEnabled(){} // RVA: 0x7FFAF47CB440
        public void CameraDisabled(){} // RVA: 0x7FFAF47CB6A0
        public void UpdateAllActiveVirtualCameras(){} // RVA: 0x7FFAF47CB8D0
        public void UpdateVirtualCamera(){} // RVA: 0x7FFAF47CBFE0
        public void InitializeModule(){} // RVA: 0x7FFAF47CC4D0
        public void GetUpdateTarget(){} // RVA: 0x7FFAF47CC5D0
        public void GetVcamUpdateStatus(){} // RVA: 0x7FFAF47CC8F0
        public void IsLive(){} // RVA: 0x7FFAF47CC980
        public void IsLiveInBlend(){} // RVA: 0x7FFAF47CCAE0
        public void GenerateCameraActivationEvent(){} // RVA: 0x7FFAF47CCC40
        public void GenerateCameraCutEvent(){} // RVA: 0x7FFAF47CCE20
        public void FindPotentialTargetBrain(){} // RVA: 0x7FFAF47CD070
        public void OnTargetObjectWarped(){} // RVA: 0x7FFAF47CD540
        public void .ctor(){} // RVA: 0x7FFAF47CD610
        public void .cctor(){} // RVA: 0x7FFAF47CD800
    }

    public class CinemachineDollyCart
    {
        // ── Methods ──
        public void FixedUpdate(){} // RVA: 0x7FFAF478EDE0
        public void Update(){} // RVA: 0x7FFAF478EE70
        public void LateUpdate(){} // RVA: 0x7FFAF478EF80
        public void SetCartPosition(){} // RVA: 0x7FFAF478F0A0
        public void .ctor(){} // RVA: 0x7FFAF478F2B0
    }

    public class CinemachineEmbeddedAssetPropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2E575F0
    }

    public class CinemachineExtension
    {
        // ── Methods ──
        public void get_VirtualCamera(){} // RVA: 0x7FFAF47CDFA0
        public void Awake(){} // RVA: 0x7FFAF47CE0E0
        public void OnEnable(){} // RVA: 0x7FFAF2D8D310
        public void OnDestroy(){} // RVA: 0x7FFAF47CE100
        public void EnsureStarted(){} // RVA: 0x7FFAF47CE0E0
        public void ConnectToVcam(){} // RVA: 0x7FFAF47CE120
        public void PrePipelineMutateCameraStateCallback(){} // RVA: 0x7FFAF2D8D310
        public void InvokePostPipelineStageCallback(){} // RVA: 0x7FFAF47CE3A0
        public void PostPipelineStageCallback(){}
        public void OnTargetObjectWarped(){} // RVA: 0x7FFAF2D8D310
        public void ForceCameraPosition(){} // RVA: 0x7FFAF2D8D310
        public void OnTransitionFromCamera(){} // RVA: 0x7FFAF2D8D320
        public void GetMaxDampTime(){} // RVA: 0x7FFAF35AF380
        public void get_RequiresUserInput(){} // RVA: 0x7FFAF2D8D320
        public void GetExtraState(){} // RVA: 0x7FFAF2D33FA0
        public void GetAllExtraStates(){} // RVA: 0x7FFAF2ABCD60
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class CinemachineExternalCamera
    {
        // ── Methods ──
        public void get_State(){} // RVA: 0x7FFAF478F300
        public void get_LookAt(){} // RVA: 0x7FFAF34CC130
        public void set_LookAt(){} // RVA: 0x7FFAF3595030
        public void get_Follow(){} // RVA: 0x7FFAF3861150
        public void set_Follow(){} // RVA: 0x7FFAF3845560
        public void InternalUpdateCameraState(){} // RVA: 0x7FFAF478F3A0
        public void .ctor(){} // RVA: 0x7FFAF478FFC0
    }

    public class CinemachineFixedSignal
    {
        // ── Methods ──
        public void get_SignalDuration(){} // RVA: 0x7FFAF47E0330
        public void AxisDuration(){} // RVA: 0x7FFAF47E0390
        public void GetSignal(){} // RVA: 0x7FFAF47E0490
        public void AxisValue(){} // RVA: 0x7FFAF47E0670
        public void .ctor(){} // RVA: 0x7FFAF2FEBFB0
    }

    public class CinemachineFollowZoom
    {
        // ── Methods ──
        public void OnValidate(){} // RVA: 0x7FFAF4790190
        public void GetMaxDampTime(){} // RVA: 0x7FFAF2E57630
        public void PostPipelineStageCallback(){} // RVA: 0x7FFAF47901F0
        public void .ctor(){} // RVA: 0x7FFAF47905E0
    }

    public class CinemachineFramingTransposer
    {
        // ── Methods ──
        public void get_SoftGuideRect(){} // RVA: 0x7FFAF47AFF10
        public void set_SoftGuideRect(){} // RVA: 0x7FFAF47AFF60
        public void get_HardGuideRect(){} // RVA: 0x7FFAF47B0020
        public void set_HardGuideRect(){} // RVA: 0x7FFAF47B00A0
        public void OnValidate(){} // RVA: 0x7FFAF47B0110
        public void get_IsValid(){} // RVA: 0x7FFAF47B0200
        public void get_Stage(){} // RVA: 0x7FFAF2FC9240
        public void get_BodyAppliesAfterAim(){} // RVA: 0x7FFAF2E72850
        public void get_TrackedPoint(){} // RVA: 0x7FFAF47B0320
        public void set_TrackedPoint(){} // RVA: 0x7FFAF47B0340
        public void OnTargetObjectWarped(){} // RVA: 0x7FFAF47B0360
        public void ForceCameraPosition(){} // RVA: 0x7FFAF47B0520
        public void GetMaxDampTime(){} // RVA: 0x7FFAF47B0550
        public void OnTransitionFromCamera(){} // RVA: 0x7FFAF47B0570
        public void ScreenToOrtho(){} // RVA: 0x7FFAF47B07A0
        public void OrthoOffsetToScreenBounds(){} // RVA: 0x7FFAF47B0870
        public void get_LastBounds(){} // RVA: 0x7FFAF47B0980
        public void set_LastBounds(){} // RVA: 0x7FFAF47B09A0
        public void get_LastBoundsMatrix(){} // RVA: 0x7FFAF47B09C0
        public void set_LastBoundsMatrix(){} // RVA: 0x7FFAF47B09F0
        public void MutateCameraState(){} // RVA: 0x7FFAF47B0A20
        public void GetTargetHeight(){} // RVA: 0x7FFAF47B25D0
        public void ComputeGroupBounds(){} // RVA: 0x7FFAF47B27D0
        public void GetScreenSpaceGroupBoundingBox(){} // RVA: 0x7FFAF47B3000
        public void .ctor(){} // RVA: 0x7FFAF47B3810
    }

    public class CinemachineFreeLook
    {
        // ── Methods ──
        public void OnValidate(){} // RVA: 0x7FFAF4790640
        public void GetRig(){} // RVA: 0x7FFAF4790930
        public void get_RigsAreCreated(){} // RVA: 0x7FFAF4790990
        public void get_RigNames(){} // RVA: 0x7FFAF47909B0
        public void OnEnable(){} // RVA: 0x7FFAF4790A70
        public void UpdateInputAxisProvider(){} // RVA: 0x7FFAF4790C90
        public void OnDestroy(){} // RVA: 0x7FFAF4790E50
        public void OnTransformChildrenChanged(){} // RVA: 0x7FFAF4791060
        public void Reset(){} // RVA: 0x7FFAF47910C0
        public void get_PreviousStateIsValid(){} // RVA: 0x7FFAF304FF30
        public void set_PreviousStateIsValid(){} // RVA: 0x7FFAF47910E0
        public void get_State(){} // RVA: 0x7FFAF4791260
        public void get_LookAt(){} // RVA: 0x7FFAF4779FF0
        public void set_LookAt(){} // RVA: 0x7FFAF3595030
        public void get_Follow(){} // RVA: 0x7FFAF477A000
        public void set_Follow(){} // RVA: 0x7FFAF2DF8050
        public void IsLiveChild(){} // RVA: 0x7FFAF4791300
        public void OnTargetObjectWarped(){} // RVA: 0x7FFAF4791410
        public void ForceCameraPosition(){} // RVA: 0x7FFAF47914F0
        public void InternalUpdateCameraState(){} // RVA: 0x7FFAF4791810
        public void OnTransitionFromCamera(){} // RVA: 0x7FFAF4792360
        public void RequiresUserInput(){} // RVA: 0x7FFAF2E72850
        public void GetYAxisClosestValue(){} // RVA: 0x7FFAF4792870
        public void SteepestDescent(){} // RVA: 0x7FFAF4792FE0
        public void InvalidateRigCache(){} // RVA: 0x7FFAF4791060
        public void DestroyRigs(){} // RVA: 0x7FFAF4793230
        public void CreateRigs(){} // RVA: 0x7FFAF4793980
        public void UpdateRigCache(){} // RVA: 0x7FFAF47945F0
        public void LocateExistingRigs(){} // RVA: 0x7FFAF4794B80
        public void UpdateXAxisHeading(){} // RVA: 0x7FFAF4795240
        public void PushSettingsToRigs(){} // RVA: 0x7FFAF4795500
        public void GetYAxisValue(){} // RVA: 0x7FFAF4795CA0
        public void CalculateNewState(){} // RVA: 0x7FFAF4795CD0
        public void GetLocalPositionForCameraFromInput(){} // RVA: 0x7FFAF4795F80
        public void UpdateCachedSpline(){} // RVA: 0x7FFAF4796230
        public void OnBeforeSerialize(){} // RVA: 0x7FFAF4796890
        public void .ctor(){} // RVA: 0x7FFAF4796970
        public void <SteepestDescent>g__AngleFunction|47_0(){} // RVA: 0x7FFAF4797040
        public void <SteepestDescent>g__SlopeOfAngleFunction|47_1(){} // RVA: 0x7FFAF4797110
        public void <SteepestDescent>g__InitialGuess|47_2(){} // RVA: 0x7FFAF4797180
        public void <SteepestDescent>g__ChooseBestAngle|47_3(){} // RVA: 0x7FFAF4797290
    }

    public class CinemachineGroupComposer
    {
        // ── Methods ──
        public void OnValidate(){} // RVA: 0x7FFAF47B39C0
        public void get_LastBounds(){} // RVA: 0x7FFAF47B3A90
        public void set_LastBounds(){} // RVA: 0x7FFAF47B3AB0
        public void get_LastBoundsMatrix(){} // RVA: 0x7FFAF47B3AD0
        public void set_LastBoundsMatrix(){} // RVA: 0x7FFAF47B3B00
        public void GetMaxDampTime(){} // RVA: 0x7FFAF47B3B30
        public void MutateCameraState(){} // RVA: 0x7FFAF47B3B50
        public void GetTargetHeight(){} // RVA: 0x7FFAF47B4CC0
        public void GetScreenSpaceGroupBoundingBox(){} // RVA: 0x7FFAF47B4F00
        public void .ctor(){} // RVA: 0x7FFAF47B5490
    }

    public class CinemachineHardLockToTarget
    {
        // ── Methods ──
        public void get_IsValid(){} // RVA: 0x7FFAF47B5510
        public void get_Stage(){} // RVA: 0x7FFAF2FC9240
        public void GetMaxDampTime(){} // RVA: 0x7FFAF2E6C210
        public void MutateCameraState(){} // RVA: 0x7FFAF47B5630
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class CinemachineHardLookAt
    {
        // ── Methods ──
        public void get_IsValid(){} // RVA: 0x7FFAF47B5800
        public void get_Stage(){} // RVA: 0x7FFAF2E7FAF0
        public void MutateCameraState(){} // RVA: 0x7FFAF47B5920
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class CinemachineImpulseChannelPropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class CinemachineImpulseDefinition
    {
        public object Descriptor;

        // ── Methods ──
        public void OnValidate(){} // RVA: 0x7FFAF47E06F0
        public void CreateStandardShapes(){} // RVA: 0x7FFAF47E07E0
        public void GetStandardCurve(){} // RVA: 0x7FFAF47E13E0
        public void get_ImpulseCurve(){} // RVA: 0x7FFAF47E1460
        public void CreateEvent(){} // RVA: 0x7FFAF47E1570
        public void CreateAndReturnEvent(){} // RVA: 0x7FFAF47E15B0
        public void LegacyCreateAndReturnEvent(){} // RVA: 0x7FFAF47E1800
        public void .ctor(){} // RVA: 0x7FFAF47E1BF0
    }

    public class CinemachineImpulseDefinitionPropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class CinemachineImpulseEnvelopePropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class CinemachineImpulseListener
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAF47E2600
        public void PostPipelineStageCallback(){} // RVA: 0x7FFAF47E26C0
        public void .ctor(){} // RVA: 0x7FFAF47E2CA0
    }

    public class CinemachineImpulseManager
    {
        public object _instance;
        public object _currentTime;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void get_Instance(){} // RVA: 0x7FFAF47E33B0
        public void InitializeModule(){} // RVA: 0x7FFAF47E3470
        public void EvaluateDissipationScale(){} // RVA: 0x7FFAF47E35A0
        public void GetImpulseAt(){} // RVA: 0x7FFAF47E36A0
        public void get_CurrentTime(){} // RVA: 0x7FFAF47E3BB0
        public void NewImpulseEvent(){} // RVA: 0x7FFAF47E3C50
        public void AddImpulseEvent(){} // RVA: 0x7FFAF47E3D50
        public void Clear(){} // RVA: 0x7FFAF47E3E50
    }

    public class CinemachineImpulseSource
    {
        // ── Methods ──
        public void OnValidate(){} // RVA: 0x7FFAF47E4CF0
        public void Reset(){} // RVA: 0x7FFAF47E4E00
        public void GenerateImpulseAtPositionWithVelocity(){} // RVA: 0x7FFAF47E4FF0
        public void GenerateImpulseWithVelocity(){} // RVA: 0x7FFAF47E5040
        public void GenerateImpulseWithForce(){} // RVA: 0x7FFAF47E5160
        public void GenerateImpulse(){} // RVA: 0x7FFAF47E5160 | overloaded x3
        public void GenerateImpulseAt(){} // RVA: 0x7FFAF47E4FF0
        public void .ctor(){} // RVA: 0x7FFAF47E5300
    }

    public class CinemachineIndependentImpulseListener
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAF47E5420
        public void OnEnable(){} // RVA: 0x7FFAF47E54D0
        public void Update(){} // RVA: 0x7FFAF47E5560
        public void LateUpdate(){} // RVA: 0x7FFAF47E59D0
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class CinemachineInputAxisDriver
    {
        // ── Methods ──
        public void Validate(){} // RVA: 0x7FFAF47C1980
        public void Update(){} // RVA: 0x7FFAF47CE750 | overloaded x2
        public void ClampValue(){} // RVA: 0x7FFAF47CE7C0
    }

    public class CinemachineInputProvider
    {
        // ── Methods ──
        public void GetAxisValue(){} // RVA: 0x7FFAF47DC800
        public void ResolveForPlayer(){} // RVA: 0x7FFAF47DC920
        public void OnDisable(){} // RVA: 0x7FFAF3BB74B0
        public void .ctor(){} // RVA: 0x7FFAF47DD080
        public void <ResolveForPlayer>g__GetFirstMatch|7_0(){} // RVA: 0x7FFAF47DD0D0
    }

    public class CinemachineMixingCamera
    {
        // ── Methods ──
        public void GetWeight(){} // RVA: 0x7FFAF4797760 | overloaded x2
        public void SetWeight(){} // RVA: 0x7FFAF4797AA0 | overloaded x2
        public void get_LiveChild(){} // RVA: 0x7FFAF3855040
        public void set_LiveChild(){} // RVA: 0x7FFAF383AAB0
        public void get_State(){} // RVA: 0x7FFAF4797D70
        public void get_LookAt(){} // RVA: 0x7FFAF3862150
        public void set_LookAt(){} // RVA: 0x7FFAF3844B20
        public void get_Follow(){} // RVA: 0x7FFAF3507F60
        public void set_Follow(){} // RVA: 0x7FFAF3844790
        public void OnTargetObjectWarped(){} // RVA: 0x7FFAF4797E10
        public void ForceCameraPosition(){} // RVA: 0x7FFAF4797EF0
        public void OnEnable(){} // RVA: 0x7FFAF4798080
        public void OnTransformChildrenChanged(){} // RVA: 0x7FFAF47980A0
        public void OnValidate(){} // RVA: 0x7FFAF47980B0
        public void IsLiveChild(){} // RVA: 0x7FFAF4798160
        public void get_ChildCameras(){} // RVA: 0x7FFAF4798200
        public void InvalidateListOfChildren(){} // RVA: 0x7FFAF4798220
        public void ValidateListOfChildren(){} // RVA: 0x7FFAF4798340
        public void OnTransitionFromCamera(){} // RVA: 0x7FFAF47987E0
        public void InternalUpdateCameraState(){} // RVA: 0x7FFAF4798940
        public void .ctor(){} // RVA: 0x7FFAF4799040
    }

    public class CinemachineOrbitalTransposer
    {
        // ── Methods ──
        public void OnValidate(){} // RVA: 0x7FFAF47B5CE0
        public void UpdateHeading(){} // RVA: 0x7FFAF47B5F10 | overloaded x2
        public void OnEnable(){} // RVA: 0x7FFAF47B60B0
        public void UpdateInputAxisProvider(){} // RVA: 0x7FFAF47B62D0
        public void OnTargetObjectWarped(){} // RVA: 0x7FFAF47B6440
        public void ForceCameraPosition(){} // RVA: 0x7FFAF47B6740
        public void OnTransitionFromCamera(){} // RVA: 0x7FFAF47B68A0
        public void GetAxisClosestValue(){} // RVA: 0x7FFAF47B6AE0
        public void MutateCameraState(){} // RVA: 0x7FFAF47B7250
        public void GetTargetCameraPosition(){} // RVA: 0x7FFAF47B81F0
        public void get_RequiresUserInput(){} // RVA: 0x7FFAF2E72850
        public void GetTargetHeading(){} // RVA: 0x7FFAF47B8640
        public void .ctor(){} // RVA: 0x7FFAF47B8FB0
    }

    public class CinemachinePOV
    {
        // ── Methods ──
        public void get_IsValid(){} // RVA: 0x7FFAF2DF3DE0
        public void get_Stage(){} // RVA: 0x7FFAF2E7FAF0
        public void OnValidate(){} // RVA: 0x7FFAF47B97A0
        public void OnEnable(){} // RVA: 0x7FFAF47B98B0
        public void UpdateInputAxisProvider(){} // RVA: 0x7FFAF47B98C0
        public void PrePipelineMutateCameraState(){} // RVA: 0x7FFAF2D8D310
        public void MutateCameraState(){} // RVA: 0x7FFAF47B9B90
        public void GetRecenterTarget(){} // RVA: 0x7FFAF47BA350
        public void NormalizeAngle(){} // RVA: 0x7FFAF47BA800
        public void ForceCameraPosition(){} // RVA: 0x7FFAF47BA830
        public void OnTransitionFromCamera(){} // RVA: 0x7FFAF47BA850
        public void get_RequiresUserInput(){} // RVA: 0x7FFAF2E72850
        public void SetAxesForRotation(){} // RVA: 0x7FFAF47BAAC0
        public void .ctor(){} // RVA: 0x7FFAF47BB5B0
    }

    public class CinemachinePath
    {
        // ── Methods ──
        public void get_MinPos(){} // RVA: 0x7FFAF35AF380
        public void get_MaxPos(){} // RVA: 0x7FFAF4799260
        public void get_Looped(){} // RVA: 0x7FFAF2E478E0
        public void Reset(){} // RVA: 0x7FFAF47992A0
        public void OnValidate(){} // RVA: 0x7FFAF4799460
        public void get_DistanceCacheSampleStepsPerSegment(){} // RVA: 0x7FFAF3210030
        public void GetBoundingIndices(){} // RVA: 0x7FFAF4799480
        public void EvaluateLocalPosition(){} // RVA: 0x7FFAF4799570
        public void EvaluateLocalTangent(){} // RVA: 0x7FFAF47998C0
        public void EvaluateLocalOrientation(){} // RVA: 0x7FFAF4799B20
        public void GetRoll(){} // RVA: 0x7FFAF4799F40
        public void RollAroundForward(){} // RVA: 0x7FFAF479A070
        public void .ctor(){} // RVA: 0x7FFAF479A0C0
    }

    public class CinemachinePathBase
    {
        // ── Methods ──
        public void get_MinPos(){} // RVA: 0x7FFAF2AD1890
        public void get_MaxPos(){} // RVA: 0x7FFAF2AD1890
        public void get_Looped(){} // RVA: 0x7FFAF2ABDBE0
        public void StandardizePos(){} // RVA: 0x7FFAF47CE830
        public void EvaluatePosition(){} // RVA: 0x7FFAF47CE920
        public void EvaluateTangent(){} // RVA: 0x7FFAF47CEA40
        public void EvaluateOrientation(){} // RVA: 0x7FFAF47CEB60
        public void EvaluateLocalPosition(){}
        public void EvaluateLocalTangent(){}
        public void EvaluateLocalOrientation(){}
        public void FindClosestPoint(){} // RVA: 0x7FFAF47CEDD0
        public void MinUnit(){} // RVA: 0x7FFAF47CF220
        public void MaxUnit(){} // RVA: 0x7FFAF47CF250
        public void StandardizeUnit(){} // RVA: 0x7FFAF47CF280
        public void EvaluatePositionAtUnit(){} // RVA: 0x7FFAF47CF330
        public void EvaluateTangentAtUnit(){} // RVA: 0x7FFAF47CF390
        public void EvaluateOrientationAtUnit(){} // RVA: 0x7FFAF47CF3F0
        public void get_DistanceCacheSampleStepsPerSegment(){} // RVA: 0x7FFAF2ABD840
        public void InvalidateDistanceCache(){} // RVA: 0x7FFAF47CF450
        public void DistanceCacheIsValid(){} // RVA: 0x7FFAF47CF500
        public void get_PathLength(){} // RVA: 0x7FFAF47CF5A0
        public void StandardizePathDistance(){} // RVA: 0x7FFAF47CF610
        public void ToNativePathUnits(){} // RVA: 0x7FFAF47CF6D0
        public void FromPathNativeUnits(){} // RVA: 0x7FFAF47CF850
        public void ResamplePath(){} // RVA: 0x7FFAF47CF970
        public void .ctor(){} // RVA: 0x7FFAF47CFE20
    }

    public class CinemachinePipeline
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class CinemachinePixelPerfect
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class CinemachineSameAsFollowTarget
    {
        // ── Methods ──
        public void get_IsValid(){} // RVA: 0x7FFAF47BB910
        public void get_Stage(){} // RVA: 0x7FFAF2E7FAF0
        public void GetMaxDampTime(){} // RVA: 0x7FFAF2E6C210
        public void MutateCameraState(){} // RVA: 0x7FFAF47BBA30
        public void .ctor(){} // RVA: 0x7FFAF47BBD70
    }

    public class CinemachineSmoothPath
    {
        // ── Methods ──
        public void get_MinPos(){} // RVA: 0x7FFAF35AF380
        public void get_MaxPos(){} // RVA: 0x7FFAF4799260
        public void get_Looped(){} // RVA: 0x7FFAF2E478E0
        public void get_DistanceCacheSampleStepsPerSegment(){} // RVA: 0x7FFAF3210030
        public void OnValidate(){} // RVA: 0x7FFAF4799460
        public void Reset(){} // RVA: 0x7FFAF479A260
        public void InvalidateDistanceCache(){} // RVA: 0x7FFAF479A410
        public void UpdateControlPoints(){} // RVA: 0x7FFAF479A560
        public void GetBoundingIndices(){} // RVA: 0x7FFAF479A8D0
        public void EvaluateLocalPosition(){} // RVA: 0x7FFAF479A9B0
        public void EvaluateLocalTangent(){} // RVA: 0x7FFAF479AD40
        public void EvaluateLocalOrientation(){} // RVA: 0x7FFAF479B010
        public void RollAroundForward(){} // RVA: 0x7FFAF479A070
        public void .ctor(){} // RVA: 0x7FFAF479B520
    }

    public class CinemachineStateDrivenCamera
    {
        // ── Methods ──
        public void get_Description(){} // RVA: 0x7FFAF479B650
        public void get_LiveChild(){} // RVA: 0x7FFAF32A7DB0
        public void set_LiveChild(){} // RVA: 0x7FFAF30ED280
        public void IsLiveChild(){} // RVA: 0x7FFAF479B790
        public void get_State(){} // RVA: 0x7FFAF479B7C0
        public void get_LookAt(){} // RVA: 0x7FFAF4779FF0
        public void set_LookAt(){} // RVA: 0x7FFAF3595030
        public void get_Follow(){} // RVA: 0x7FFAF477A000
        public void set_Follow(){} // RVA: 0x7FFAF2DF8050
        public void OnTargetObjectWarped(){} // RVA: 0x7FFAF479B860
        public void ForceCameraPosition(){} // RVA: 0x7FFAF479B940
        public void OnTransitionFromCamera(){} // RVA: 0x7FFAF479BAD0
        public void InternalUpdateCameraState(){} // RVA: 0x7FFAF479BBE0
        public void OnEnable(){} // RVA: 0x7FFAF479C4D0
        public void OnDisable(){} // RVA: 0x7FFAF479C7E0
        public void OnTransformChildrenChanged(){} // RVA: 0x7FFAF479C960
        public void OnGuiHandler(){} // RVA: 0x7FFAF479C970
        public void get_ChildCameras(){} // RVA: 0x7FFAF479CAE0
        public void get_IsBlending(){} // RVA: 0x7FFAF479CB00
        public void get_ActiveBlend(){} // RVA: 0x7FFAF3840BA0
        public void CreateFakeHash(){} // RVA: 0x7FFAF479CB10
        public void LookupFakeHash(){} // RVA: 0x7FFAF479CBD0
        public void InvalidateListOfChildren(){} // RVA: 0x7FFAF479CF80
        public void UpdateListOfChildren(){} // RVA: 0x7FFAF479D040
        public void ValidateInstructions(){} // RVA: 0x7FFAF479D3E0
        public void ChooseCurrentCamera(){} // RVA: 0x7FFAF479DA20
        public void GetClipHash(){} // RVA: 0x7FFAF479E2C0
        public void LookupBlend(){} // RVA: 0x7FFAF479E450
        public void .ctor(){} // RVA: 0x7FFAF479E6C0
    }

    public class CinemachineStoryboard
    {
        // ── Methods ──
        public void PostPipelineStageCallback(){} // RVA: 0x7FFAF479EA00
        public void UpdateRenderCanvas(){} // RVA: 0x7FFAF479EC10
        public void ConnectToVcam(){} // RVA: 0x7FFAF479EE60
        public void get_CanvasName(){} // RVA: 0x7FFAF479F030
        public void CameraUpdatedCallback(){} // RVA: 0x7FFAF479F160
        public void LocateMyCanvas(){} // RVA: 0x7FFAF479F500
        public void CreateCanvas(){} // RVA: 0x7FFAF479FE20
        public void DestroyCanvas(){} // RVA: 0x7FFAF47A0950
        public void PlaceImage(){} // RVA: 0x7FFAF47A0CD0
        public void StaticBlendingHandler(){} // RVA: 0x7FFAF47A1900
        public void InitializeModule(){} // RVA: 0x7FFAF47A1CE0
        public void .ctor(){} // RVA: 0x7FFAF47A1E50
    }

    public class CinemachineTargetGroup
    {
        // ── Methods ──
        public void OnValidate(){} // RVA: 0x7FFAF47A2020
        public void Reset(){} // RVA: 0x7FFAF47A20C0
        public void get_Transform(){} // RVA: 0x7FFAF3341B00
        public void get_BoundingBox(){} // RVA: 0x7FFAF47A2150
        public void set_BoundingBox(){} // RVA: 0x7FFAF47A21E0
        public void get_Sphere(){} // RVA: 0x7FFAF47A2200
        public void set_Sphere(){} // RVA: 0x7FFAF2E9DDC0
        public void get_IsEmpty(){} // RVA: 0x7FFAF47A2280
        public void AddMember(){} // RVA: 0x7FFAF47A2320
        public void RemoveMember(){} // RVA: 0x7FFAF47A2600
        public void FindMember(){} // RVA: 0x7FFAF47A2910
        public void GetWeightedBoundsForMember(){} // RVA: 0x7FFAF47A2AA0
        public void GetViewSpaceBoundingBox(){} // RVA: 0x7FFAF47A2C80
        public void get_CachedCountIsValid(){} // RVA: 0x7FFAF47A3440
        public void IndexIsValid(){} // RVA: 0x7FFAF47A34B0
        public void WeightedMemberBoundsForValidMember(){} // RVA: 0x7FFAF47A34D0
        public void DoUpdate(){} // RVA: 0x7FFAF47A3690
        public void UpdateMemberValidity(){} // RVA: 0x7FFAF47A39E0
        public void CalculateAveragePosition(){} // RVA: 0x7FFAF47A3D70
        public void CalculateBoundingBox(){} // RVA: 0x7FFAF47A4000
        public void CalculateBoundingSphere(){} // RVA: 0x7FFAF47A4570
        public void CalculateAverageOrientation(){} // RVA: 0x7FFAF47A4970
        public void FixedUpdate(){} // RVA: 0x7FFAF47A5110
        public void Update(){} // RVA: 0x7FFAF47A5120
        public void LateUpdate(){} // RVA: 0x7FFAF47A51C0
        public void GetViewSpaceAngularBounds(){} // RVA: 0x7FFAF47A51D0
        public void .ctor(){} // RVA: 0x7FFAF47A5F10
    }

    public class CinemachineTrackedDolly
    {
        // ── Methods ──
        public void get_IsValid(){} // RVA: 0x7FFAF47BBDF0
        public void get_Stage(){} // RVA: 0x7FFAF2FC9240
        public void GetMaxDampTime(){} // RVA: 0x7FFAF47BBF10
        public void MutateCameraState(){} // RVA: 0x7FFAF47BBFC0
        public void GetCameraOrientationAtPathPoint(){} // RVA: 0x7FFAF47BD250
        public void get_AngularDamping(){} // RVA: 0x7FFAF47BD930
        public void .ctor(){} // RVA: 0x7FFAF47BD9E0
    }

    public class CinemachineTransposer
    {
        // ── Methods ──
        public void OnValidate(){} // RVA: 0x7FFAF47BDB40
        public void get_HideOffsetInInspector(){} // RVA: 0x7FFAF304FF30
        public void set_HideOffsetInInspector(){} // RVA: 0x7FFAF370F680
        public void get_EffectiveOffset(){} // RVA: 0x7FFAF47BDB90
        public void get_IsValid(){} // RVA: 0x7FFAF47BDBD0
        public void get_Stage(){} // RVA: 0x7FFAF2FC9240
        public void GetMaxDampTime(){} // RVA: 0x7FFAF47BDCF0
        public void MutateCameraState(){} // RVA: 0x7FFAF47BDD80
        public void OnTargetObjectWarped(){} // RVA: 0x7FFAF47BE460
        public void ForceCameraPosition(){} // RVA: 0x7FFAF47BE5D0
        public void InitPrevFrameStateInfo(){} // RVA: 0x7FFAF47BE910
        public void TrackTarget(){} // RVA: 0x7FFAF47BEB70
        public void GetOffsetForMinimumTargetDistance(){} // RVA: 0x7FFAF47BFCC0
        public void get_Damping(){} // RVA: 0x7FFAF47C0260
        public void get_AngularDamping(){} // RVA: 0x7FFAF47C02A0
        public void GetTargetCameraPosition(){} // RVA: 0x7FFAF47C0380
        public void GetReferenceOrientation(){} // RVA: 0x7FFAF47C0680
        public void .ctor(){} // RVA: 0x7FFAF47C0D00
    }

    public class CinemachineTriggerAction
    {
        // ── Methods ──
        public void Filter(){} // RVA: 0x7FFAF47DD550
        public void InternalDoTriggerEnter(){} // RVA: 0x7FFAF47DD670
        public void InternalDoTriggerExit(){} // RVA: 0x7FFAF47DD800
        public void OnTriggerEnter(){} // RVA: 0x7FFAF47DD8E0
        public void OnTriggerExit(){} // RVA: 0x7FFAF47DD960
        public void OnCollisionEnter(){} // RVA: 0x7FFAF47DD9E0
        public void OnCollisionExit(){} // RVA: 0x7FFAF47DDA20
        public void OnTriggerEnter2D(){} // RVA: 0x7FFAF47DD8E0
        public void OnTriggerExit2D(){} // RVA: 0x7FFAF47DD960
        public void OnCollisionEnter2D(){} // RVA: 0x7FFAF47DDA60
        public void OnCollisionExit2D(){} // RVA: 0x7FFAF47DDAA0
        public void OnEnable(){} // RVA: 0x7FFAF2D8D310
        public void .ctor(){} // RVA: 0x7FFAF47DDAE0
    }

    public class CinemachineVirtualCamera
    {
        // ── Methods ──
        public void get_State(){} // RVA: 0x7FFAF479B7C0
        public void get_LookAt(){} // RVA: 0x7FFAF4779FF0
        public void set_LookAt(){} // RVA: 0x7FFAF3595030
        public void get_Follow(){} // RVA: 0x7FFAF477A000
        public void set_Follow(){} // RVA: 0x7FFAF2DF8050
        public void GetMaxDampTime(){} // RVA: 0x7FFAF47A6110
        public void InternalUpdateCameraState(){} // RVA: 0x7FFAF47A6280
        public void OnEnable(){} // RVA: 0x7FFAF47A6760
        public void OnDestroy(){} // RVA: 0x7FFAF47A6DE0
        public void OnValidate(){} // RVA: 0x7FFAF47A7170
        public void OnTransformChildrenChanged(){} // RVA: 0x7FFAF47A7250
        public void Reset(){} // RVA: 0x7FFAF47A72B0
        public void DestroyPipeline(){} // RVA: 0x7FFAF47A72D0
        public void CreatePipeline(){} // RVA: 0x7FFAF47A7A00
        public void InvalidateComponentPipeline(){} // RVA: 0x7FFAF47A7250
        public void GetComponentOwner(){} // RVA: 0x7FFAF47A7D70
        public void GetComponentPipeline(){} // RVA: 0x7FFAF47A7D90
        public void GetCinemachineComponent(){} // RVA: 0x7FFAF2D33FA0 | overloaded x2
        public void AddCinemachineComponent(){} // RVA: 0x7FFAF2D33FA0
        public void DestroyCinemachineComponent(){} // RVA: 0x7FFAF2AD4A50
        public void UpdateComponentPipeline(){} // RVA: 0x7FFAF47A7E40
        public void SetFlagsForHiddenChild(){} // RVA: 0x7FFAF47A86B0
        public void CalculateNewState(){} // RVA: 0x7FFAF47A8860
        public void OnTargetObjectWarped(){} // RVA: 0x7FFAF47A9320
        public void ForceCameraPosition(){} // RVA: 0x7FFAF47A96B0
        public void SetStateRawPosition(){} // RVA: 0x7FFAF47A9930
        public void OnTransitionFromCamera(){} // RVA: 0x7FFAF47A9950
        public void RequiresUserInput(){} // RVA: 0x7FFAF47A9E60
        public void OnBeforeSerialize(){} // RVA: 0x7FFAF47AA120
        public void .ctor(){} // RVA: 0x7FFAF47AA200
    }

    public class CinemachineVirtualCameraBase
    {
        // ── Methods ──
        public void get_ValidatingStreamVersion(){} // RVA: 0x7FFAF47CFF30
        public void set_ValidatingStreamVersion(){} // RVA: 0x7FFAF2DE8CE0
        public void GetMaxDampTime(){} // RVA: 0x7FFAF47CFFA0
        public void DetachedFollowTargetDamp(){} // RVA: 0x7FFAF47D02A0 | overloaded x3
        public void DetachedLookAtTargetDamp(){} // RVA: 0x7FFAF47D0570 | overloaded x3
        public void AddExtension(){} // RVA: 0x7FFAF47D0620
        public void RemoveExtension(){} // RVA: 0x7FFAF47D0780
        public void get_mExtensions(){} // RVA: 0x7FFAF2E2E0E0
        public void set_mExtensions(){} // RVA: 0x7FFAF2EE54D0
        public void InvokePostPipelineStageCallback(){} // RVA: 0x7FFAF47D07E0
        public void InvokePrePipelineMutateCameraStateCallback(){} // RVA: 0x7FFAF47D0AD0
        public void InvokeOnTransitionInExtensions(){} // RVA: 0x7FFAF47D0DB0
        public void get_Name(){} // RVA: 0x7FFAF304E520
        public void get_Description(){} // RVA: 0x7FFAF47D0FD0
        public void get_Priority(){} // RVA: 0x7FFAF3341AF0
        public void set_Priority(){} // RVA: 0x7FFAF47695F0
        public void ApplyPositionBlendMethod(){} // RVA: 0x7FFAF47D1010
        public void get_VirtualCameraGameObject(){} // RVA: 0x7FFAF47D1040
        public void get_IsValid(){} // RVA: 0x7FFAF47D1150
        public void get_State(){}
        public void get_ParentCamera(){} // RVA: 0x7FFAF47D1220
        public void IsLiveChild(){} // RVA: 0x7FFAF2D8D320
        public void get_LookAt(){} // RVA: 0x7FFAF2ABCD60
        public void set_LookAt(){} // RVA: 0x7FFAF2AD4B10
        public void get_Follow(){} // RVA: 0x7FFAF2ABCD60
        public void set_Follow(){} // RVA: 0x7FFAF2AD4B10
        public void get_PreviousStateIsValid(){} // RVA: 0x7FFAF304FF30
        public void set_PreviousStateIsValid(){} // RVA: 0x7FFAF370F680
        public void UpdateCameraState(){} // RVA: 0x7FFAF47D12C0
        public void InternalUpdateCameraState(){}
        public void OnTransitionFromCamera(){} // RVA: 0x7FFAF47D1360
        public void OnDestroy(){} // RVA: 0x7FFAF47D1430
        public void OnTransformParentChanged(){} // RVA: 0x7FFAF47D1560
        public void Start(){} // RVA: 0x7FFAF2F40630
        public void RequiresUserInput(){} // RVA: 0x7FFAF47D1600
        public void EnsureStarted(){} // RVA: 0x7FFAF47D1780
        public void GetInputAxisProvider(){} // RVA: 0x7FFAF47D1840
        public void OnValidate(){} // RVA: 0x7FFAF47D1900
        public void OnEnable(){} // RVA: 0x7FFAF47D1970
        public void OnDisable(){} // RVA: 0x7FFAF47D1CE0
        public void Update(){} // RVA: 0x7FFAF47D1D50
        public void UpdateSlaveStatus(){} // RVA: 0x7FFAF47D1D60
        public void ResolveLookAt(){} // RVA: 0x7FFAF47D1F40
        public void ResolveFollow(){} // RVA: 0x7FFAF47D2060
        public void UpdateVcamPoolStatus(){} // RVA: 0x7FFAF47D2180
        public void MoveToTopOfPrioritySubqueue(){} // RVA: 0x7FFAF47D23B0
        public void OnTargetObjectWarped(){} // RVA: 0x7FFAF47D23C0
        public void ForceCameraPosition(){} // RVA: 0x7FFAF47D24C0
        public void GetInheritPosition(){} // RVA: 0x7FFAF47D25D0
        public void CreateBlend(){} // RVA: 0x7FFAF47D26E0
        public void PullStateFromVirtualCamera(){} // RVA: 0x7FFAF47D2B40
        public void InvalidateCachedTargets(){} // RVA: 0x7FFAF47D2E70
        public void get_FollowTargetChanged(){} // RVA: 0x7FFAF461CD50
        public void set_FollowTargetChanged(){} // RVA: 0x7FFAF3620090
        public void get_LookAtTargetChanged(){} // RVA: 0x7FFAF47D3080
        public void set_LookAtTargetChanged(){} // RVA: 0x7FFAF47D3090
        public void UpdateTargetCache(){} // RVA: 0x7FFAF47D30A0
        public void get_AbstractFollowTargetGroup(){} // RVA: 0x7FFAF2F12D00
        public void get_FollowTargetAsVcam(){} // RVA: 0x7FFAF2F77C50
        public void get_AbstractLookAtTargetGroup(){} // RVA: 0x7FFAF34CC8C0
        public void get_LookAtTargetAsVcam(){} // RVA: 0x7FFAF3246DE0
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFAF47D36A0
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFAF47D36C0
        public void LegacyUpgrade(){} // RVA: 0x7FFAF2D8D310
        public void OnBeforeSerialize(){} // RVA: 0x7FFAF2D8D310
        public void CancelDamping(){} // RVA: 0x7FFAF47D3770
        public void .ctor(){} // RVA: 0x7FFAF47D39D0
    }

    public class ClipperLib
    {
    }

    public class ConfinerOven
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF47D3C70
        public void GetBakedSolution(){} // RVA: 0x7FFAF47D3DA0
        public void get_State(){} // RVA: 0x7FFAF349AB90
        public void set_State(){} // RVA: 0x7FFAF349AAE0
        public void Initialize(){} // RVA: 0x7FFAF47D4200
        public void BakeConfiner(){} // RVA: 0x7FFAF47D4A60
        public void <Initialize>g__GetPolygonBoundingBox|24_0(){} // RVA: 0x7FFAF47D50B0
        public void <Initialize>g__MidPointOfIntRect|24_1(){} // RVA: 0x7FFAF47D5270
        public void <BakeConfiner>g__ComputeSkeleton|25_0(){} // RVA: 0x7FFAF47D52A0
    }

    public class Documentation
    {
    }

    public class DocumentationSortingAttribute
    {
        // ── Methods ──
        public void get_Category(){} // RVA: 0x7FFAF2DDA5C0
        public void set_Category(){} // RVA: 0x7FFAF2D900C0
        public void .ctor(){} // RVA: 0x7FFAF2D900C0
    }

    public class GroupWeightManipulator
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAF47DE9F0
        public void OnValidate(){} // RVA: 0x7FFAF47DEA80
        public void Update(){} // RVA: 0x7FFAF47DEAF0
        public void UpdateWeights(){} // RVA: 0x7FFAF47DECC0
        public void .ctor(){} // RVA: 0x7FFAF47DEDB0
    }

    public class ICameraOverrideStack
    {
        // ── Methods ──
        public void SetCameraOverride(){}
        public void ReleaseCameraOverride(){} // RVA: 0x7FFAF2AD4FA0
        public void get_DefaultWorldUp(){} // RVA: 0x7FFAF2ABC770
    }

    public class ICinemachineCamera
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAF2ABCD60
        public void get_Description(){} // RVA: 0x7FFAF2ABCD60
        public void get_Priority(){} // RVA: 0x7FFAF2ABD840
        public void set_Priority(){} // RVA: 0x7FFAF2AD4FA0
        public void get_LookAt(){} // RVA: 0x7FFAF2ABCD60
        public void set_LookAt(){} // RVA: 0x7FFAF2AD4B10
        public void get_Follow(){} // RVA: 0x7FFAF2ABCD60
        public void set_Follow(){} // RVA: 0x7FFAF2AD4B10
        public void get_State(){}
        public void get_VirtualCameraGameObject(){} // RVA: 0x7FFAF2ABCD60
        public void get_IsValid(){} // RVA: 0x7FFAF2ABDBE0
        public void get_ParentCamera(){} // RVA: 0x7FFAF2ABCD60
        public void IsLiveChild(){}
        public void UpdateCameraState(){}
        public void InternalUpdateCameraState(){}
        public void OnTransitionFromCamera(){}
        public void OnTargetObjectWarped(){}
    }

    public class ICinemachineTargetGroup
    {
        // ── Methods ──
        public void get_Transform(){} // RVA: 0x7FFAF2ABCD60
        public void get_BoundingBox(){}
        public void get_Sphere(){}
        public void get_IsEmpty(){} // RVA: 0x7FFAF2ABDBE0
        public void GetViewSpaceBoundingBox(){}
        public void GetViewSpaceAngularBounds(){}
    }

    public class ISignalSource6D
    {
        // ── Methods ──
        public void get_SignalDuration(){} // RVA: 0x7FFAF2AD1890
        public void GetSignal(){}
    }

    public class LensSettings
    {
        // ── Methods ──
        public void get_Orthographic(){} // RVA: 0x7FFAF47D6820
        public void set_Orthographic(){} // RVA: 0x7FFAF47D6840
        public void get_SensorSize(){} // RVA: 0x7FFAF43A7880
        public void set_SensorSize(){} // RVA: 0x7FFAF335C650
        public void get_Aspect(){} // RVA: 0x7FFAF47D6850
        public void get_IsPhysicalCamera(){} // RVA: 0x7FFAF47D68E0
        public void set_IsPhysicalCamera(){} // RVA: 0x7FFAF47D6900
        public void FromCamera(){} // RVA: 0x7FFAF47D6910
        public void SnapshotCameraReadOnlyProperties(){} // RVA: 0x7FFAF47D70B0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAF47D71C0
        public void Lerp(){} // RVA: 0x7FFAF47D7210
        public void Validate(){} // RVA: 0x7FFAF47D7470
        public void .cctor(){} // RVA: 0x7FFAF47D74F0
    }

    public class LensSettingsPropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class NoSaveDuringPlayAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class NoiseSettings
    {
        // ── Methods ──
        public void GetCombinedFilterResults(){} // RVA: 0x7FFAF47D7580
        public void get_SignalDuration(){} // RVA: 0x7FFAF35AF380
        public void GetSignal(){} // RVA: 0x7FFAF47D7700
        public void .ctor(){} // RVA: 0x7FFAF47D78B0
    }

    public class NoiseSettingsPropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class NotNullAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF47C8CC0
        public void SetState(){} // RVA: 0x7FFAF47C8DC0
        public void get_Name(){} // RVA: 0x7FFAF2DA8380
        public void set_Name(){} // RVA: 0x7FFAF2D8EE30
        public void get_Description(){} // RVA: 0x7FFAF47C8E70
        public void get_Priority(){} // RVA: 0x7FFAF306ED50
        public void set_Priority(){} // RVA: 0x7FFAF30E74E0
        public void get_LookAt(){} // RVA: 0x7FFAF2DBB0C0
        public void set_LookAt(){} // RVA: 0x7FFAF2DBB0D0
        public void get_Follow(){} // RVA: 0x7FFAF2DBB130
        public void set_Follow(){} // RVA: 0x7FFAF2D8EE90
        public void get_State(){} // RVA: 0x7FFAF47C8EB0
        public void set_State(){} // RVA: 0x7FFAF47C8F50
        public void get_VirtualCameraGameObject(){} // RVA: 0x7FFAF2FC9240
        public void get_IsValid(){} // RVA: 0x7FFAF2E72850
        public void get_ParentCamera(){} // RVA: 0x7FFAF2FC9240
        public void IsLiveChild(){} // RVA: 0x7FFAF2D8D320
        public void UpdateCameraState(){} // RVA: 0x7FFAF2D8D310
        public void InternalUpdateCameraState(){} // RVA: 0x7FFAF2D8D310
        public void OnTransitionFromCamera(){} // RVA: 0x7FFAF2D8D310
        public void OnTargetObjectWarped(){} // RVA: 0x7FFAF2D8D310
    }

    public class OrbitalTransposerHeadingPropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class RuntimeUtility
    {
        // ── Methods ──
        public void DestroyObject(){} // RVA: 0x7FFAF47D7AF0
        public void IsPrefab(){} // RVA: 0x7FFAF2D8D320
        public void RaycastIgnoreTag(){} // RVA: 0x7FFAF47D7BE0
        public void SphereCastIgnoreTag(){} // RVA: 0x7FFAF47D7FA0
        public void GetScratchCollider(){} // RVA: 0x7FFAF47D8B10
        public void DestroyScratchCollider(){} // RVA: 0x7FFAF47D90B0
        public void NormalizeCurve(){} // RVA: 0x7FFAF47D93A0
        public void .cctor(){} // RVA: 0x7FFAF47D9610
    }

    public class SaveDuringPlayAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class SignalSourceAsset
    {
        // ── Methods ──
        public void get_SignalDuration(){} // RVA: 0x7FFAF2AD1890
        public void GetSignal(){}
        public void .ctor(){} // RVA: 0x7FFAF2FEBFB0
    }

    public class TagFieldAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class TargetPositionCache
    {
        // ── Methods ──
        public void get_CacheMode(){} // RVA: 0x7FFAF47D9760
        public void set_CacheMode(){} // RVA: 0x7FFAF47D97A0
        public void get_IsRecording(){} // RVA: 0x7FFAF47D9810
        public void get_CurrentPlaybackTimeValid(){} // RVA: 0x7FFAF47D9860
        public void get_IsEmpty(){} // RVA: 0x7FFAF47D98F0
        public void get_CacheTimeRange(){} // RVA: 0x7FFAF47D9940
        public void get_HasCurrentTime(){} // RVA: 0x7FFAF47D9990
        public void ClearCache(){} // RVA: 0x7FFAF47D99F0
        public void CreatePlaybackCurves(){} // RVA: 0x7FFAF47D9B60
        public void GetTargetPosition(){} // RVA: 0x7FFAF47D9DB0
        public void GetTargetRotation(){} // RVA: 0x7FFAF47DA270
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class UpdateTracker
    {
        // ── Methods ──
        public void InitializeModule(){} // RVA: 0x7FFAF47DBA80
        public void UpdateTargets(){} // RVA: 0x7FFAF47DBB00
        public void GetPreferredUpdate(){} // RVA: 0x7FFAF47DC000
        public void OnUpdate(){} // RVA: 0x7FFAF47DC370
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAF47DC430
    }

    public class VcamTargetPropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

}