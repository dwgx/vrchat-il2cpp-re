// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Cinemachine.Cinemachine
// Classes: 83
// Methods: 917

namespace ThirdParty.Cinemachine.Cinemachine
{
    public class AxisBase
    {
        // ── Methods ──
        public void Validate(){} // RVA: 0x1D1E3C0
    }

    public class AxisState
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1D10E70
        public void Validate(){} // RVA: 0x1D10FE0
        public void Reset(){} // RVA: 0x1D11040
        public void SetInputAxisProvider(){} // RVA: 0x1D11050
        public void get_HasInputProvider(){} // RVA: 0x1D110B0
        public void Update(){} // RVA: 0x1D110C0
        public void ClampValue(){} // RVA: 0x1D115C0
        public void MaxSpeedUpdate(){} // RVA: 0x1D11630
        public void GetMaxSpeed(){} // RVA: 0x1D11870
        public void get_ValueRangeLocked(){} // RVA: 0x1D11920
        public void set_ValueRangeLocked(){} // RVA: 0x1D11930
        public void get_HasRecentering(){} // RVA: 0x1D11940
        public void set_HasRecentering(){} // RVA: 0x1D11950
    }

    public class AxisStatePropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class BlendSourceVirtualCamera
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void get_Blend(){} // RVA: 0x2F8380
        public void set_Blend(){} // RVA: 0x2DEE30
        public void get_Name(){} // RVA: 0x1D19030
        public void get_Description(){} // RVA: 0x1D19070
        public void get_Priority(){} // RVA: 0x5BED50
        public void set_Priority(){} // RVA: 0x6374E0
        public void get_LookAt(){} // RVA: 0x30B0C0
        public void set_LookAt(){} // RVA: 0x30B0D0
        public void get_Follow(){} // RVA: 0x30B130
        public void set_Follow(){} // RVA: 0x2DEE90
        public void get_State(){} // RVA: 0x1D18EB0
        public void set_State(){} // RVA: 0x1D18F50
        public void get_VirtualCameraGameObject(){} // RVA: 0x519240
        public void get_IsValid(){} // RVA: 0x1D190C0
        public void get_ParentCamera(){} // RVA: 0x519240
        public void IsLiveChild(){} // RVA: 0x1D190E0
        public void CalculateNewState(){} // RVA: 0x1D18EB0
        public void UpdateCameraState(){} // RVA: 0x1D19100
        public void InternalUpdateCameraState(){} // RVA: 0x2DD310
        public void OnTransitionFromCamera(){} // RVA: 0x2DD310
        public void OnTargetObjectWarped(){} // RVA: 0x2DD310
    }

    public class CameraState
    {
        public object rectTransform;
        public object showMaskGraphic;
        public object graphic;

        // ── Methods ──
        public void get_HasLookAt(){} // RVA: 0x1D11D30
        public void get_CorrectedPosition(){} // RVA: 0x1D11D90
        public void get_CorrectedOrientation(){} // RVA: 0x1D11DE0
        public void get_FinalPosition(){} // RVA: 0x1D11D90
        public void get_FinalOrientation(){} // RVA: 0x1D11F50
        public void get_Default(){} // RVA: 0x1D12210
        public void get_NumCustomBlendables(){} // RVA: 0x1D12470
        public void set_NumCustomBlendables(){} // RVA: 0x1D12480
        public void GetCustomBlendable(){} // RVA: 0x1D12490
        public void FindCustomBlendable(){} // RVA: 0x1D12600
        public void AddCustomBlendable(){} // RVA: 0x1D12B80
        public void Lerp(){} // RVA: 0x1D12F40
        public void InterpolateFOV(){} // RVA: 0x1D16FA0
        public void ApplyPosBlendHint(){} // RVA: 0x1D170F0
        public void ApplyRotBlendHint(){} // RVA: 0x1D17170
        public void InterpolatePosition(){} // RVA: 0x1D171C0
        public void .cctor(){} // RVA: 0x1D176B0
    }

    public class Cinemachine3rdPersonAim
    {
        // ── Methods ──
        public void get_AimTarget(){} // RVA: 0x343FA0
        public void set_AimTarget(){} // RVA: 0x343FC0
        public void OnValidate(){} // RVA: 0x1CC8960
        public void Reset(){} // RVA: 0x1CC8980
        public void OnTransitionFromCamera(){} // RVA: 0x1CC8A90
        public void DrawReticle(){} // RVA: 0x1CC8C10
        public void ComputeLookAtPoint(){} // RVA: 0x1CC8FA0
        public void ComputeAimTarget(){} // RVA: 0x1CC95D0
        public void PostPipelineStageCallback(){} // RVA: 0x1CC9850
        public void .ctor(){} // RVA: 0x1CC9BA0
    }

    public class Cinemachine3rdPersonFollow
    {
        // ── Methods ──
        public void OnValidate(){} // RVA: 0x1CFA610
        public void Reset(){} // RVA: 0x1CFA690
        public void OnDestroy(){} // RVA: 0x1CFA700
        public void get_IsValid(){} // RVA: 0x1CFA750
        public void get_Stage(){} // RVA: 0x519240
        public void GetMaxDampTime(){} // RVA: 0x1CFA870
        public void MutateCameraState(){} // RVA: 0x1CFA8A0
        public void OnTargetObjectWarped(){} // RVA: 0x1CFA930
        public void PositionCamera(){} // RVA: 0x1CFAAA0
        public void GetRigPositions(){} // RVA: 0x1CFB1C0
        public void GetHeading(){} // RVA: 0x1CFB3E0
        public void GetRawRigPositions(){} // RVA: 0x1CFB960
        public void ResolveCollisions(){} // RVA: 0x1CFBCE0
        public void .ctor(){} // RVA: 0x1CFC030
    }

    public class CinemachineBasicMultiChannelPerlin
    {
        // ── Methods ──
        public void get_IsValid(){} // RVA: 0x1CFC100
        public void get_Stage(){} // RVA: 0x3E2CB0
        public void MutateCameraState(){} // RVA: 0x1CFC220
        public void ReSeed(){} // RVA: 0x1CFCD00
        public void Initialize(){} // RVA: 0x1CFCE30
        public void .ctor(){} // RVA: 0x1CFD040
    }

    public class CinemachineBlend
    {
        // ── Methods ──
        public void get_BlendWeight(){} // RVA: 0x1D17700
        public void get_IsValid(){} // RVA: 0x1D177F0
        public void get_IsComplete(){} // RVA: 0x1D17870
        public void get_Description(){} // RVA: 0x1D178A0
        public void Uses(){} // RVA: 0x1D17AB0
        public void .ctor(){} // RVA: 0x1D17BF0
        public void UpdateCameraState(){} // RVA: 0x1D17D10
        public void get_State(){} // RVA: 0x1D17E00
    }

    public class CinemachineBlendDefinition
    {
        public object Name;
        public object Description;

        // ── Methods ──
        public void get_BlendTime(){} // RVA: 0x1D182D0
        public void .ctor(){} // RVA: 0x1D182E0
        public void CreateStandardCurves(){} // RVA: 0x1D18340
        public void get_BlendCurve(){} // RVA: 0x1D18BB0
    }

    public class CinemachineBlendDefinitionPropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class CinemachineBlendListCamera
    {
        // ── Methods ──
        public void get_Description(){} // RVA: 0x1CC9C70
        public void Reset(){} // RVA: 0x1CC9DB0
        public void get_LiveChild(){} // RVA: 0x3FA100
        public void set_LiveChild(){} // RVA: 0x3FA110
        public void IsLiveChild(){} // RVA: 0x1CC9F20
        public void get_State(){} // RVA: 0x1CC9F50
        public void get_LookAt(){} // RVA: 0x1CC9FF0
        public void set_LookAt(){} // RVA: 0xAE5030
        public void get_Follow(){} // RVA: 0x1CCA000
        public void set_Follow(){} // RVA: 0x348050
        public void OnTargetObjectWarped(){} // RVA: 0x1CCA010
        public void ForceCameraPosition(){} // RVA: 0x1CCA0F0
        public void OnTransitionFromCamera(){} // RVA: 0x1CCA280
        public void InternalUpdateCameraState(){} // RVA: 0x1CCA4B0
        public void OnEnable(){} // RVA: 0x1CCAE80
        public void OnDisable(){} // RVA: 0x1CCB1E0
        public void OnTransformChildrenChanged(){} // RVA: 0x1CCB360
        public void OnGuiHandler(){} // RVA: 0x1CCB370
        public void get_ChildCameras(){} // RVA: 0x1CCB4E0
        public void get_IsBlending(){} // RVA: 0x1CCB500
        public void InvalidateListOfChildren(){} // RVA: 0x1CCB510
        public void UpdateListOfChildren(){} // RVA: 0x1CCB5D0
        public void ValidateInstructions(){} // RVA: 0x1CCB960
        public void AdvanceCurrentInstruction(){} // RVA: 0x1CCBD60
        public void .ctor(){} // RVA: 0x1CCBFC0
    }

    public class CinemachineBlenderSettings
    {
        // ── Methods ──
        public void GetBlendForVirtualCameras(){} // RVA: 0x1D192D0
        public void .ctor(){} // RVA: 0x53BFB0
    }

    public class CinemachineBrain
    {
        // ── Methods ──
        public void get_OutputCamera(){} // RVA: 0x1CCC190
        public void get_ControlledObject(){} // RVA: 0x1CCC300
        public void set_ControlledObject(){} // RVA: 0x1CCC420
        public void get_SoloCamera(){} // RVA: 0x1CCC4E0
        public void set_SoloCamera(){} // RVA: 0x1CCC540
        public void GetSoloGUIColor(){} // RVA: 0x1CCC7A0
        public void get_DefaultWorldUp(){} // RVA: 0x1CCC7C0
        public void OnEnable(){} // RVA: 0x1CCC950
        public void OnDisable(){} // RVA: 0x1CCCEC0
        public void OnSceneLoaded(){} // RVA: 0x1CCD1C0
        public void OnSceneUnloaded(){} // RVA: 0x1CCD260
        public void Awake(){} // RVA: 0x1CCD300
        public void Start(){} // RVA: 0x1CCD360
        public void OnGuiHandler(){} // RVA: 0x1CCD380
        public void AfterPhysics(){} // RVA: 0x1CCD860
        public void LateUpdate(){} // RVA: 0x1CCD900
        public void ManualUpdate(){} // RVA: 0x1CCD910
        public void GetEffectiveDeltaTime(){} // RVA: 0x1CCDC40
        public void UpdateVirtualCameras(){} // RVA: 0x1CCDEE0
        public void get_ActiveVirtualCamera(){} // RVA: 0x1CCE270
        public void DeepCamBFromBlend(){} // RVA: 0x1CCE3F0
        public void IsLiveInBlend(){} // RVA: 0x1CCE4B0
        public void get_IsBlending(){} // RVA: 0x1CCE5F0
        public void get_ActiveBlend(){} // RVA: 0x1CCE610
        public void set_ActiveBlend(){} // RVA: 0x1CCE710
        public void GetBrainFrame(){} // RVA: 0x1CCE830
        public void SetCameraOverride(){} // RVA: 0x1CCE970
        public void ReleaseCameraOverride(){} // RVA: 0x1CCEEA0
        public void ProcessActiveCamera(){} // RVA: 0x1CCEF80
        public void UpdateFrame0(){} // RVA: 0x1CCF6D0
        public void ComputeCurrentBlend(){} // RVA: 0x1CCFF00
        public void IsLive(){} // RVA: 0x1CD0500
        public void get_CurrentCameraState(){} // RVA: 0x1CD06E0
        public void set_CurrentCameraState(){} // RVA: 0x1CD0780
        public void TopCameraFromPriorityQueue(){} // RVA: 0x1CD0870
        public void LookupBlend(){} // RVA: 0x1CD0BA0
        public void PushStateToUnityCamera(){} // RVA: 0x1CD0E00
        public void .ctor(){} // RVA: 0x1CD1490
        public void .cctor(){} // RVA: 0x1CD18F0
    }

    public class CinemachineClearShot
    {
        // ── Methods ──
        public void get_Description(){} // RVA: 0x1CD1EB0
        public void get_LiveChild(){} // RVA: 0x3482A0
        public void set_LiveChild(){} // RVA: 0x3482B0
        public void get_State(){} // RVA: 0x1CD1FF0
        public void IsLiveChild(){} // RVA: 0x1CD2090
        public void get_LookAt(){} // RVA: 0x1CC9FF0
        public void set_LookAt(){} // RVA: 0xAE5030
        public void get_Follow(){} // RVA: 0x1CCA000
        public void set_Follow(){} // RVA: 0x348050
        public void OnTargetObjectWarped(){} // RVA: 0x1CD20C0
        public void ForceCameraPosition(){} // RVA: 0x1CD21A0
        public void InternalUpdateCameraState(){} // RVA: 0x1CD2330
        public void OnEnable(){} // RVA: 0x1CD2A70
        public void OnDisable(){} // RVA: 0x1CD2D80
        public void OnTransformChildrenChanged(){} // RVA: 0x1CD2F00
        public void OnGuiHandler(){} // RVA: 0x1CD2F20
        public void get_IsBlending(){} // RVA: 0x1CD3090
        public void get_ActiveBlend(){} // RVA: 0xD92860
        public void get_ChildCameras(){} // RVA: 0x1CD30A0
        public void InvalidateListOfChildren(){} // RVA: 0x1CD30C0
        public void ResetRandomization(){} // RVA: 0x1CD31E0
        public void UpdateListOfChildren(){} // RVA: 0x1CD3260
        public void ChooseCurrentCamera(){} // RVA: 0x1CD3720
        public void Randomize(){} // RVA: 0x1CD4100
        public void LookupBlend(){} // RVA: 0x1CD4630
        public void OnTransitionFromCamera(){} // RVA: 0x1CD48A0
        public void .ctor(){} // RVA: 0x1CD4A30
    }

    public class CinemachineCollider
    {
        // ── Methods ──
        public void IsTargetObscured(){} // RVA: 0x1CD4D80
        public void CameraWasDisplaced(){} // RVA: 0x1CD4DE0
        public void GetCameraDisplacementDistance(){} // RVA: 0x1CD4E50
        public void OnValidate(){} // RVA: 0x1CD4EC0
        public void OnDestroy(){} // RVA: 0x1CD4F10
        public void get_DebugPaths(){} // RVA: 0x1CD4F80
        public void GetMaxDampTime(){} // RVA: 0x1CD51A0
        public void OnTargetObjectWarped(){} // RVA: 0x1CD51C0
        public void PostPipelineStageCallback(){} // RVA: 0x1CD52C0
        public void PreserveLineOfSight(){} // RVA: 0x1CD6590
        public void PullCameraInFrontOfNearestObstacle(){} // RVA: 0x1CD6B80
        public void PushCameraBack(){} // RVA: 0x1CD70A0
        public void GetWalkingDirection(){} // RVA: 0x1CD7B30
        public void GetPushBackDistance(){} // RVA: 0x1CD8470
        public void ClampRayToBounds(){} // RVA: 0x1CD85E0
        public void RespectCameraRadius(){} // RVA: 0x1CD94F0
        public void CheckForTargetObstructions(){} // RVA: 0x1CDA1C0
        public void IsTargetOffscreen(){} // RVA: 0x1CDA630
        public void .ctor(){} // RVA: 0x1CDAEB0
        public void .cctor(){} // RVA: 0x1CDB020
    }

    public class CinemachineCollisionImpulseSource
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x1D2EE30
        public void OnEnable(){} // RVA: 0x2DD310
        public void OnCollisionEnter(){} // RVA: 0x1D2EF50
        public void OnTriggerEnter(){} // RVA: 0x1D2F000
        public void GetMassAndVelocity(){} // RVA: 0x1D2F070
        public void GenerateImpactEvent(){} // RVA: 0x1D2F570
        public void OnCollisionEnter2D(){} // RVA: 0x1D2F8E0
        public void OnTriggerEnter2D(){} // RVA: 0x1D2F940
        public void GetMassAndVelocity2D(){} // RVA: 0x1D2F9B0
        public void GenerateImpactEvent2D(){} // RVA: 0x1D2FE00
        public void .ctor(){} // RVA: 0x1D30170
    }

    public class CinemachineComponentBase
    {
        // ── Methods ──
        public void get_VirtualCamera(){} // RVA: 0x1D19630
        public void get_FollowTarget(){} // RVA: 0x1D19A40
        public void get_LookAtTarget(){} // RVA: 0x1D19B40
        public void get_AbstractFollowTargetGroup(){} // RVA: 0x1D19C40
        public void get_FollowTargetGroup(){} // RVA: 0x1D19D20
        public void get_FollowTargetPosition(){} // RVA: 0x1D19DB0
        public void get_FollowTargetRotation(){} // RVA: 0x1D1A0B0
        public void get_AbstractLookAtTargetGroup(){} // RVA: 0x1D1A380
        public void get_LookAtTargetGroup(){} // RVA: 0x1D1A3B0
        public void get_LookAtTargetPosition(){} // RVA: 0x1D1A450
        public void get_LookAtTargetRotation(){} // RVA: 0x1D1A750
        public void get_VcamState(){} // RVA: 0x1D1AA20
        public void get_IsValid(){} // RVA: 0xDBE0
        public void PrePipelineMutateCameraState(){} // RVA: 0x2DD310
        public void get_Stage(){} // RVA: 0xD840
        public void get_BodyAppliesAfterAim(){} // RVA: 0x2DD320
        public void MutateCameraState(){} // RVA: 0x318E0
        public void OnTransitionFromCamera(){} // RVA: 0x2DD320
        public void OnTargetObjectWarped(){} // RVA: 0x2DD310
        public void ForceCameraPosition(){} // RVA: 0x2DD310
        public void GetMaxDampTime(){} // RVA: 0xAFF380
        public void get_RequiresUserInput(){} // RVA: 0x2DD320
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class CinemachineComposer
    {
        // ── Methods ──
        public void get_IsValid(){} // RVA: 0x1CFD120
        public void get_Stage(){} // RVA: 0x3CFAF0
        public void get_TrackedPoint(){} // RVA: 0x1CFD240
        public void set_TrackedPoint(){} // RVA: 0x1CFD260
        public void GetLookAtPointAndSetTrackedPoint(){} // RVA: 0x1CFD270
        public void OnTargetObjectWarped(){} // RVA: 0x1CFD740
        public void ForceCameraPosition(){} // RVA: 0x1CFD940
        public void GetMaxDampTime(){} // RVA: 0x1CFD960
        public void PrePipelineMutateCameraState(){} // RVA: 0x1CFD970
        public void MutateCameraState(){} // RVA: 0x1CFDAB0
        public void get_SoftGuideRect(){} // RVA: 0x1CFE860
        public void set_SoftGuideRect(){} // RVA: 0x1CFE8B0
        public void get_HardGuideRect(){} // RVA: 0x1CFE970
        public void set_HardGuideRect(){} // RVA: 0x1CFE9F0
        public void RotateToScreenBounds(){} // RVA: 0x1CFEA60
        public void ClampVerticalBounds(){} // RVA: 0x1CFED40
        public void .ctor(){} // RVA: 0x1CFF040
    }

    public class CinemachineConfiner
    {
        // ── Methods ──
        public void CameraWasDisplaced(){} // RVA: 0x1CDB260
        public void GetCameraDisplacementDistance(){} // RVA: 0x1CDB2D0
        public void OnValidate(){} // RVA: 0x1CDB330
        public void ConnectToVcam(){} // RVA: 0x1CDB340
        public void get_IsValid(){} // RVA: 0x1CDB350
        public void GetMaxDampTime(){} // RVA: 0x862910
        public void PostPipelineStageCallback(){} // RVA: 0x1CDB5E0
        public void InvalidatePathCache(){} // RVA: 0x1CDB8C0
        public void ValidatePathCache(){} // RVA: 0x1CDB970
        public void ConfinePoint(){} // RVA: 0x1CDC2B0
        public void ConfineScreenEdges(){} // RVA: 0x1CDC8F0
        public void .ctor(){} // RVA: 0x1CDD120
    }

    public class CinemachineConfiner2D
    {
        // ── Methods ──
        public void InvalidateCache(){} // RVA: 0x1CDD170
        public void ValidateCache(){} // RVA: 0x1CDD180
        public void PostPipelineStageCallback(){} // RVA: 0x1CDD1D0
        public void CalculateHalfFrustumHeight(){} // RVA: 0x1CDDA00
        public void OnValidate(){} // RVA: 0x1CDDAB0
        public void Reset(){} // RVA: 0x1CDDAD0
        public void .ctor(){} // RVA: 0x1CDDAE0
    }

    public class CinemachineCore
    {
        public object State;
        public object LookAt;
        public object Follow;
        public object m_vcamOwner;

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x1D1ABD0
        public void get_DeltaTime(){} // RVA: 0x1D1AD00
        public void get_CurrentTime(){} // RVA: 0x1D1ADC0
        public void get_BrainCount(){} // RVA: 0x1D1AE80
        public void GetActiveBrain(){} // RVA: 0x1D1AED0
        public void AddActiveBrain(){} // RVA: 0x1D1AF50
        public void RemoveActiveBrain(){} // RVA: 0x1D1AFF0
        public void get_VirtualCameraCount(){} // RVA: 0x1D1B050
        public void GetVirtualCamera(){} // RVA: 0x1D1B0A0
        public void AddActiveCamera(){} // RVA: 0x1D1B260
        public void RemoveActiveCamera(){} // RVA: 0x1D1B2D0
        public void CameraDestroyed(){} // RVA: 0x1D1B350
        public void CameraEnabled(){} // RVA: 0x1D1B440
        public void CameraDisabled(){} // RVA: 0x1D1B6A0
        public void UpdateAllActiveVirtualCameras(){} // RVA: 0x1D1B8D0
        public void UpdateVirtualCamera(){} // RVA: 0x1D1BFE0
        public void InitializeModule(){} // RVA: 0x1D1C4D0
        public void GetUpdateTarget(){} // RVA: 0x1D1C5D0
        public void GetVcamUpdateStatus(){} // RVA: 0x1D1C8F0
        public void IsLive(){} // RVA: 0x1D1C980
        public void IsLiveInBlend(){} // RVA: 0x1D1CAE0
        public void GenerateCameraActivationEvent(){} // RVA: 0x1D1CC40
        public void GenerateCameraCutEvent(){} // RVA: 0x1D1CE20
        public void FindPotentialTargetBrain(){} // RVA: 0x1D1D070
        public void OnTargetObjectWarped(){} // RVA: 0x1D1D540
        public void .ctor(){} // RVA: 0x1D1D610
        public void .cctor(){} // RVA: 0x1D1D800
    }

    public class CinemachineDollyCart
    {
        // ── Methods ──
        public void FixedUpdate(){} // RVA: 0x1CDEDE0
        public void Update(){} // RVA: 0x1CDEE70
        public void LateUpdate(){} // RVA: 0x1CDEF80
        public void SetCartPosition(){} // RVA: 0x1CDF0A0
        public void .ctor(){} // RVA: 0x1CDF2B0
    }

    public class CinemachineEmbeddedAssetPropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A75F0
    }

    public class CinemachineExtension
    {
        // ── Methods ──
        public void get_VirtualCamera(){} // RVA: 0x1D1DFA0
        public void Awake(){} // RVA: 0x1D1E0E0
        public void OnEnable(){} // RVA: 0x2DD310
        public void OnDestroy(){} // RVA: 0x1D1E100
        public void EnsureStarted(){} // RVA: 0x1D1E0E0
        public void ConnectToVcam(){} // RVA: 0x1D1E120
        public void PrePipelineMutateCameraStateCallback(){} // RVA: 0x2DD310
        public void InvokePostPipelineStageCallback(){} // RVA: 0x1D1E3A0
        public void PostPipelineStageCallback(){}
        public void OnTargetObjectWarped(){} // RVA: 0x2DD310
        public void ForceCameraPosition(){} // RVA: 0x2DD310
        public void OnTransitionFromCamera(){} // RVA: 0x2DD320
        public void GetMaxDampTime(){} // RVA: 0xAFF380
        public void get_RequiresUserInput(){} // RVA: 0x2DD320
        public void GetExtraState(){} // RVA: 0x283FA0
        public void GetAllExtraStates(){} // RVA: 0xCD60
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class CinemachineExternalCamera
    {
        // ── Methods ──
        public void get_State(){} // RVA: 0x1CDF300
        public void get_LookAt(){} // RVA: 0xA1C130
        public void set_LookAt(){} // RVA: 0xAE5030
        public void get_Follow(){} // RVA: 0xDB1150
        public void set_Follow(){} // RVA: 0xD95560
        public void InternalUpdateCameraState(){} // RVA: 0x1CDF3A0
        public void .ctor(){} // RVA: 0x1CDFFC0
    }

    public class CinemachineFixedSignal
    {
        // ── Methods ──
        public void get_SignalDuration(){} // RVA: 0x1D30330
        public void AxisDuration(){} // RVA: 0x1D30390
        public void GetSignal(){} // RVA: 0x1D30490
        public void AxisValue(){} // RVA: 0x1D30670
        public void .ctor(){} // RVA: 0x53BFB0
    }

    public class CinemachineFollowZoom
    {
        // ── Methods ──
        public void OnValidate(){} // RVA: 0x1CE0190
        public void GetMaxDampTime(){} // RVA: 0x3A7630
        public void PostPipelineStageCallback(){} // RVA: 0x1CE01F0
        public void .ctor(){} // RVA: 0x1CE05E0
    }

    public class CinemachineFramingTransposer
    {
        // ── Methods ──
        public void get_SoftGuideRect(){} // RVA: 0x1CFFF10
        public void set_SoftGuideRect(){} // RVA: 0x1CFFF60
        public void get_HardGuideRect(){} // RVA: 0x1D00020
        public void set_HardGuideRect(){} // RVA: 0x1D000A0
        public void OnValidate(){} // RVA: 0x1D00110
        public void get_IsValid(){} // RVA: 0x1D00200
        public void get_Stage(){} // RVA: 0x519240
        public void get_BodyAppliesAfterAim(){} // RVA: 0x3C2850
        public void get_TrackedPoint(){} // RVA: 0x1D00320
        public void set_TrackedPoint(){} // RVA: 0x1D00340
        public void OnTargetObjectWarped(){} // RVA: 0x1D00360
        public void ForceCameraPosition(){} // RVA: 0x1D00520
        public void GetMaxDampTime(){} // RVA: 0x1D00550
        public void OnTransitionFromCamera(){} // RVA: 0x1D00570
        public void ScreenToOrtho(){} // RVA: 0x1D007A0
        public void OrthoOffsetToScreenBounds(){} // RVA: 0x1D00870
        public void get_LastBounds(){} // RVA: 0x1D00980
        public void set_LastBounds(){} // RVA: 0x1D009A0
        public void get_LastBoundsMatrix(){} // RVA: 0x1D009C0
        public void set_LastBoundsMatrix(){} // RVA: 0x1D009F0
        public void MutateCameraState(){} // RVA: 0x1D00A20
        public void GetTargetHeight(){} // RVA: 0x1D025D0
        public void ComputeGroupBounds(){} // RVA: 0x1D027D0
        public void GetScreenSpaceGroupBoundingBox(){} // RVA: 0x1D03000
        public void .ctor(){} // RVA: 0x1D03810
    }

    public class CinemachineFreeLook
    {
        // ── Methods ──
        public void OnValidate(){} // RVA: 0x1CE0640
        public void GetRig(){} // RVA: 0x1CE0930
        public void get_RigsAreCreated(){} // RVA: 0x1CE0990
        public void get_RigNames(){} // RVA: 0x1CE09B0
        public void OnEnable(){} // RVA: 0x1CE0A70
        public void UpdateInputAxisProvider(){} // RVA: 0x1CE0C90
        public void OnDestroy(){} // RVA: 0x1CE0E50
        public void OnTransformChildrenChanged(){} // RVA: 0x1CE1060
        public void Reset(){} // RVA: 0x1CE10C0
        public void get_PreviousStateIsValid(){} // RVA: 0x59FF30
        public void set_PreviousStateIsValid(){} // RVA: 0x1CE10E0
        public void get_State(){} // RVA: 0x1CE1260
        public void get_LookAt(){} // RVA: 0x1CC9FF0
        public void set_LookAt(){} // RVA: 0xAE5030
        public void get_Follow(){} // RVA: 0x1CCA000
        public void set_Follow(){} // RVA: 0x348050
        public void IsLiveChild(){} // RVA: 0x1CE1300
        public void OnTargetObjectWarped(){} // RVA: 0x1CE1410
        public void ForceCameraPosition(){} // RVA: 0x1CE14F0
        public void InternalUpdateCameraState(){} // RVA: 0x1CE1810
        public void OnTransitionFromCamera(){} // RVA: 0x1CE2360
        public void RequiresUserInput(){} // RVA: 0x3C2850
        public void GetYAxisClosestValue(){} // RVA: 0x1CE2870
        public void SteepestDescent(){} // RVA: 0x1CE2FE0
        public void InvalidateRigCache(){} // RVA: 0x1CE1060
        public void DestroyRigs(){} // RVA: 0x1CE3230
        public void CreateRigs(){} // RVA: 0x1CE3980
        public void UpdateRigCache(){} // RVA: 0x1CE45F0
        public void LocateExistingRigs(){} // RVA: 0x1CE4B80
        public void UpdateXAxisHeading(){} // RVA: 0x1CE5240
        public void PushSettingsToRigs(){} // RVA: 0x1CE5500
        public void GetYAxisValue(){} // RVA: 0x1CE5CA0
        public void CalculateNewState(){} // RVA: 0x1CE5CD0
        public void GetLocalPositionForCameraFromInput(){} // RVA: 0x1CE5F80
        public void UpdateCachedSpline(){} // RVA: 0x1CE6230
        public void OnBeforeSerialize(){} // RVA: 0x1CE6890
        public void .ctor(){} // RVA: 0x1CE6970
        public void <SteepestDescent>g__AngleFunction|47_0(){} // RVA: 0x1CE7040
        public void <SteepestDescent>g__SlopeOfAngleFunction|47_1(){} // RVA: 0x1CE7110
        public void <SteepestDescent>g__InitialGuess|47_2(){} // RVA: 0x1CE7180
        public void <SteepestDescent>g__ChooseBestAngle|47_3(){} // RVA: 0x1CE7290
    }

    public class CinemachineGroupComposer
    {
        // ── Methods ──
        public void OnValidate(){} // RVA: 0x1D039C0
        public void get_LastBounds(){} // RVA: 0x1D03A90
        public void set_LastBounds(){} // RVA: 0x1D03AB0
        public void get_LastBoundsMatrix(){} // RVA: 0x1D03AD0
        public void set_LastBoundsMatrix(){} // RVA: 0x1D03B00
        public void GetMaxDampTime(){} // RVA: 0x1D03B30
        public void MutateCameraState(){} // RVA: 0x1D03B50
        public void GetTargetHeight(){} // RVA: 0x1D04CC0
        public void GetScreenSpaceGroupBoundingBox(){} // RVA: 0x1D04F00
        public void .ctor(){} // RVA: 0x1D05490
    }

    public class CinemachineHardLockToTarget
    {
        // ── Methods ──
        public void get_IsValid(){} // RVA: 0x1D05510
        public void get_Stage(){} // RVA: 0x519240
        public void GetMaxDampTime(){} // RVA: 0x3BC210
        public void MutateCameraState(){} // RVA: 0x1D05630
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class CinemachineHardLookAt
    {
        // ── Methods ──
        public void get_IsValid(){} // RVA: 0x1D05800
        public void get_Stage(){} // RVA: 0x3CFAF0
        public void MutateCameraState(){} // RVA: 0x1D05920
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class CinemachineImpulseChannelPropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class CinemachineImpulseDefinition
    {
        public object Descriptor;

        // ── Methods ──
        public void OnValidate(){} // RVA: 0x1D306F0
        public void CreateStandardShapes(){} // RVA: 0x1D307E0
        public void GetStandardCurve(){} // RVA: 0x1D313E0
        public void get_ImpulseCurve(){} // RVA: 0x1D31460
        public void CreateEvent(){} // RVA: 0x1D31570
        public void CreateAndReturnEvent(){} // RVA: 0x1D315B0
        public void LegacyCreateAndReturnEvent(){} // RVA: 0x1D31800
        public void .ctor(){} // RVA: 0x1D31BF0
    }

    public class CinemachineImpulseDefinitionPropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class CinemachineImpulseEnvelopePropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class CinemachineImpulseListener
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x1D32600
        public void PostPipelineStageCallback(){} // RVA: 0x1D326C0
        public void .ctor(){} // RVA: 0x1D32CA0
    }

    public class CinemachineImpulseManager
    {
        public object _instance;
        public object _currentTime;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void get_Instance(){} // RVA: 0x1D333B0
        public void InitializeModule(){} // RVA: 0x1D33470
        public void EvaluateDissipationScale(){} // RVA: 0x1D335A0
        public void GetImpulseAt(){} // RVA: 0x1D336A0
        public void get_CurrentTime(){} // RVA: 0x1D33BB0
        public void NewImpulseEvent(){} // RVA: 0x1D33C50
        public void AddImpulseEvent(){} // RVA: 0x1D33D50
        public void Clear(){} // RVA: 0x1D33E50
    }

    public class CinemachineImpulseSource
    {
        // ── Methods ──
        public void OnValidate(){} // RVA: 0x1D34CF0
        public void Reset(){} // RVA: 0x1D34E00
        public void GenerateImpulseAtPositionWithVelocity(){} // RVA: 0x1D34FF0
        public void GenerateImpulseWithVelocity(){} // RVA: 0x1D35040
        public void GenerateImpulseWithForce(){} // RVA: 0x1D35160
        public void GenerateImpulse(){} // RVA: 0x1D35160 | overloaded x3
        public void GenerateImpulseAt(){} // RVA: 0x1D34FF0
        public void .ctor(){} // RVA: 0x1D35300
    }

    public class CinemachineIndependentImpulseListener
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x1D35420
        public void OnEnable(){} // RVA: 0x1D354D0
        public void Update(){} // RVA: 0x1D35560
        public void LateUpdate(){} // RVA: 0x1D359D0
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class CinemachineInputAxisDriver
    {
        // ── Methods ──
        public void Validate(){} // RVA: 0x1D11980
        public void Update(){} // RVA: 0x1D1E750 | overloaded x2
        public void ClampValue(){} // RVA: 0x1D1E7C0
    }

    public class CinemachineInputProvider
    {
        // ── Methods ──
        public void GetAxisValue(){} // RVA: 0x1D2C800
        public void ResolveForPlayer(){} // RVA: 0x1D2C920
        public void OnDisable(){} // RVA: 0x11074B0
        public void .ctor(){} // RVA: 0x1D2D080
        public void <ResolveForPlayer>g__GetFirstMatch|7_0(){} // RVA: 0x1D2D0D0
    }

    public class CinemachineMixingCamera
    {
        // ── Methods ──
        public void GetWeight(){} // RVA: 0x1CE7760 | overloaded x2
        public void SetWeight(){} // RVA: 0x1CE7AA0 | overloaded x2
        public void get_LiveChild(){} // RVA: 0xDA5040
        public void set_LiveChild(){} // RVA: 0xD8AAB0
        public void get_State(){} // RVA: 0x1CE7D70
        public void get_LookAt(){} // RVA: 0xDB2150
        public void set_LookAt(){} // RVA: 0xD94B20
        public void get_Follow(){} // RVA: 0xA57F60
        public void set_Follow(){} // RVA: 0xD94790
        public void OnTargetObjectWarped(){} // RVA: 0x1CE7E10
        public void ForceCameraPosition(){} // RVA: 0x1CE7EF0
        public void OnEnable(){} // RVA: 0x1CE8080
        public void OnTransformChildrenChanged(){} // RVA: 0x1CE80A0
        public void OnValidate(){} // RVA: 0x1CE80B0
        public void IsLiveChild(){} // RVA: 0x1CE8160
        public void get_ChildCameras(){} // RVA: 0x1CE8200
        public void InvalidateListOfChildren(){} // RVA: 0x1CE8220
        public void ValidateListOfChildren(){} // RVA: 0x1CE8340
        public void OnTransitionFromCamera(){} // RVA: 0x1CE87E0
        public void InternalUpdateCameraState(){} // RVA: 0x1CE8940
        public void .ctor(){} // RVA: 0x1CE9040
    }

    public class CinemachineOrbitalTransposer
    {
        // ── Methods ──
        public void OnValidate(){} // RVA: 0x1D05CE0
        public void UpdateHeading(){} // RVA: 0x1D05F10 | overloaded x2
        public void OnEnable(){} // RVA: 0x1D060B0
        public void UpdateInputAxisProvider(){} // RVA: 0x1D062D0
        public void OnTargetObjectWarped(){} // RVA: 0x1D06440
        public void ForceCameraPosition(){} // RVA: 0x1D06740
        public void OnTransitionFromCamera(){} // RVA: 0x1D068A0
        public void GetAxisClosestValue(){} // RVA: 0x1D06AE0
        public void MutateCameraState(){} // RVA: 0x1D07250
        public void GetTargetCameraPosition(){} // RVA: 0x1D081F0
        public void get_RequiresUserInput(){} // RVA: 0x3C2850
        public void GetTargetHeading(){} // RVA: 0x1D08640
        public void .ctor(){} // RVA: 0x1D08FB0
    }

    public class CinemachinePOV
    {
        // ── Methods ──
        public void get_IsValid(){} // RVA: 0x343DE0
        public void get_Stage(){} // RVA: 0x3CFAF0
        public void OnValidate(){} // RVA: 0x1D097A0
        public void OnEnable(){} // RVA: 0x1D098B0
        public void UpdateInputAxisProvider(){} // RVA: 0x1D098C0
        public void PrePipelineMutateCameraState(){} // RVA: 0x2DD310
        public void MutateCameraState(){} // RVA: 0x1D09B90
        public void GetRecenterTarget(){} // RVA: 0x1D0A350
        public void NormalizeAngle(){} // RVA: 0x1D0A800
        public void ForceCameraPosition(){} // RVA: 0x1D0A830
        public void OnTransitionFromCamera(){} // RVA: 0x1D0A850
        public void get_RequiresUserInput(){} // RVA: 0x3C2850
        public void SetAxesForRotation(){} // RVA: 0x1D0AAC0
        public void .ctor(){} // RVA: 0x1D0B5B0
    }

    public class CinemachinePath
    {
        // ── Methods ──
        public void get_MinPos(){} // RVA: 0xAFF380
        public void get_MaxPos(){} // RVA: 0x1CE9260
        public void get_Looped(){} // RVA: 0x3978E0
        public void Reset(){} // RVA: 0x1CE92A0
        public void OnValidate(){} // RVA: 0x1CE9460
        public void get_DistanceCacheSampleStepsPerSegment(){} // RVA: 0x760030
        public void GetBoundingIndices(){} // RVA: 0x1CE9480
        public void EvaluateLocalPosition(){} // RVA: 0x1CE9570
        public void EvaluateLocalTangent(){} // RVA: 0x1CE98C0
        public void EvaluateLocalOrientation(){} // RVA: 0x1CE9B20
        public void GetRoll(){} // RVA: 0x1CE9F40
        public void RollAroundForward(){} // RVA: 0x1CEA070
        public void .ctor(){} // RVA: 0x1CEA0C0
    }

    public class CinemachinePathBase
    {
        // ── Methods ──
        public void get_MinPos(){} // RVA: 0x21890
        public void get_MaxPos(){} // RVA: 0x21890
        public void get_Looped(){} // RVA: 0xDBE0
        public void StandardizePos(){} // RVA: 0x1D1E830
        public void EvaluatePosition(){} // RVA: 0x1D1E920
        public void EvaluateTangent(){} // RVA: 0x1D1EA40
        public void EvaluateOrientation(){} // RVA: 0x1D1EB60
        public void EvaluateLocalPosition(){}
        public void EvaluateLocalTangent(){}
        public void EvaluateLocalOrientation(){}
        public void FindClosestPoint(){} // RVA: 0x1D1EDD0
        public void MinUnit(){} // RVA: 0x1D1F220
        public void MaxUnit(){} // RVA: 0x1D1F250
        public void StandardizeUnit(){} // RVA: 0x1D1F280
        public void EvaluatePositionAtUnit(){} // RVA: 0x1D1F330
        public void EvaluateTangentAtUnit(){} // RVA: 0x1D1F390
        public void EvaluateOrientationAtUnit(){} // RVA: 0x1D1F3F0
        public void get_DistanceCacheSampleStepsPerSegment(){} // RVA: 0xD840
        public void InvalidateDistanceCache(){} // RVA: 0x1D1F450
        public void DistanceCacheIsValid(){} // RVA: 0x1D1F500
        public void get_PathLength(){} // RVA: 0x1D1F5A0
        public void StandardizePathDistance(){} // RVA: 0x1D1F610
        public void ToNativePathUnits(){} // RVA: 0x1D1F6D0
        public void FromPathNativeUnits(){} // RVA: 0x1D1F850
        public void ResamplePath(){} // RVA: 0x1D1F970
        public void .ctor(){} // RVA: 0x1D1FE20
    }

    public class CinemachinePipeline
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class CinemachinePixelPerfect
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class CinemachineSameAsFollowTarget
    {
        // ── Methods ──
        public void get_IsValid(){} // RVA: 0x1D0B910
        public void get_Stage(){} // RVA: 0x3CFAF0
        public void GetMaxDampTime(){} // RVA: 0x3BC210
        public void MutateCameraState(){} // RVA: 0x1D0BA30
        public void .ctor(){} // RVA: 0x1D0BD70
    }

    public class CinemachineSmoothPath
    {
        // ── Methods ──
        public void get_MinPos(){} // RVA: 0xAFF380
        public void get_MaxPos(){} // RVA: 0x1CE9260
        public void get_Looped(){} // RVA: 0x3978E0
        public void get_DistanceCacheSampleStepsPerSegment(){} // RVA: 0x760030
        public void OnValidate(){} // RVA: 0x1CE9460
        public void Reset(){} // RVA: 0x1CEA260
        public void InvalidateDistanceCache(){} // RVA: 0x1CEA410
        public void UpdateControlPoints(){} // RVA: 0x1CEA560
        public void GetBoundingIndices(){} // RVA: 0x1CEA8D0
        public void EvaluateLocalPosition(){} // RVA: 0x1CEA9B0
        public void EvaluateLocalTangent(){} // RVA: 0x1CEAD40
        public void EvaluateLocalOrientation(){} // RVA: 0x1CEB010
        public void RollAroundForward(){} // RVA: 0x1CEA070
        public void .ctor(){} // RVA: 0x1CEB520
    }

    public class CinemachineStateDrivenCamera
    {
        // ── Methods ──
        public void get_Description(){} // RVA: 0x1CEB650
        public void get_LiveChild(){} // RVA: 0x7F7DB0
        public void set_LiveChild(){} // RVA: 0x63D280
        public void IsLiveChild(){} // RVA: 0x1CEB790
        public void get_State(){} // RVA: 0x1CEB7C0
        public void get_LookAt(){} // RVA: 0x1CC9FF0
        public void set_LookAt(){} // RVA: 0xAE5030
        public void get_Follow(){} // RVA: 0x1CCA000
        public void set_Follow(){} // RVA: 0x348050
        public void OnTargetObjectWarped(){} // RVA: 0x1CEB860
        public void ForceCameraPosition(){} // RVA: 0x1CEB940
        public void OnTransitionFromCamera(){} // RVA: 0x1CEBAD0
        public void InternalUpdateCameraState(){} // RVA: 0x1CEBBE0
        public void OnEnable(){} // RVA: 0x1CEC4D0
        public void OnDisable(){} // RVA: 0x1CEC7E0
        public void OnTransformChildrenChanged(){} // RVA: 0x1CEC960
        public void OnGuiHandler(){} // RVA: 0x1CEC970
        public void get_ChildCameras(){} // RVA: 0x1CECAE0
        public void get_IsBlending(){} // RVA: 0x1CECB00
        public void get_ActiveBlend(){} // RVA: 0xD90BA0
        public void CreateFakeHash(){} // RVA: 0x1CECB10
        public void LookupFakeHash(){} // RVA: 0x1CECBD0
        public void InvalidateListOfChildren(){} // RVA: 0x1CECF80
        public void UpdateListOfChildren(){} // RVA: 0x1CED040
        public void ValidateInstructions(){} // RVA: 0x1CED3E0
        public void ChooseCurrentCamera(){} // RVA: 0x1CEDA20
        public void GetClipHash(){} // RVA: 0x1CEE2C0
        public void LookupBlend(){} // RVA: 0x1CEE450
        public void .ctor(){} // RVA: 0x1CEE6C0
    }

    public class CinemachineStoryboard
    {
        // ── Methods ──
        public void PostPipelineStageCallback(){} // RVA: 0x1CEEA00
        public void UpdateRenderCanvas(){} // RVA: 0x1CEEC10
        public void ConnectToVcam(){} // RVA: 0x1CEEE60
        public void get_CanvasName(){} // RVA: 0x1CEF030
        public void CameraUpdatedCallback(){} // RVA: 0x1CEF160
        public void LocateMyCanvas(){} // RVA: 0x1CEF500
        public void CreateCanvas(){} // RVA: 0x1CEFE20
        public void DestroyCanvas(){} // RVA: 0x1CF0950
        public void PlaceImage(){} // RVA: 0x1CF0CD0
        public void StaticBlendingHandler(){} // RVA: 0x1CF1900
        public void InitializeModule(){} // RVA: 0x1CF1CE0
        public void .ctor(){} // RVA: 0x1CF1E50
    }

    public class CinemachineTargetGroup
    {
        // ── Methods ──
        public void OnValidate(){} // RVA: 0x1CF2020
        public void Reset(){} // RVA: 0x1CF20C0
        public void get_Transform(){} // RVA: 0x891B00
        public void get_BoundingBox(){} // RVA: 0x1CF2150
        public void set_BoundingBox(){} // RVA: 0x1CF21E0
        public void get_Sphere(){} // RVA: 0x1CF2200
        public void set_Sphere(){} // RVA: 0x3EDDC0
        public void get_IsEmpty(){} // RVA: 0x1CF2280
        public void AddMember(){} // RVA: 0x1CF2320
        public void RemoveMember(){} // RVA: 0x1CF2600
        public void FindMember(){} // RVA: 0x1CF2910
        public void GetWeightedBoundsForMember(){} // RVA: 0x1CF2AA0
        public void GetViewSpaceBoundingBox(){} // RVA: 0x1CF2C80
        public void get_CachedCountIsValid(){} // RVA: 0x1CF3440
        public void IndexIsValid(){} // RVA: 0x1CF34B0
        public void WeightedMemberBoundsForValidMember(){} // RVA: 0x1CF34D0
        public void DoUpdate(){} // RVA: 0x1CF3690
        public void UpdateMemberValidity(){} // RVA: 0x1CF39E0
        public void CalculateAveragePosition(){} // RVA: 0x1CF3D70
        public void CalculateBoundingBox(){} // RVA: 0x1CF4000
        public void CalculateBoundingSphere(){} // RVA: 0x1CF4570
        public void CalculateAverageOrientation(){} // RVA: 0x1CF4970
        public void FixedUpdate(){} // RVA: 0x1CF5110
        public void Update(){} // RVA: 0x1CF5120
        public void LateUpdate(){} // RVA: 0x1CF51C0
        public void GetViewSpaceAngularBounds(){} // RVA: 0x1CF51D0
        public void .ctor(){} // RVA: 0x1CF5F10
    }

    public class CinemachineTrackedDolly
    {
        // ── Methods ──
        public void get_IsValid(){} // RVA: 0x1D0BDF0
        public void get_Stage(){} // RVA: 0x519240
        public void GetMaxDampTime(){} // RVA: 0x1D0BF10
        public void MutateCameraState(){} // RVA: 0x1D0BFC0
        public void GetCameraOrientationAtPathPoint(){} // RVA: 0x1D0D250
        public void get_AngularDamping(){} // RVA: 0x1D0D930
        public void .ctor(){} // RVA: 0x1D0D9E0
    }

    public class CinemachineTransposer
    {
        // ── Methods ──
        public void OnValidate(){} // RVA: 0x1D0DB40
        public void get_HideOffsetInInspector(){} // RVA: 0x59FF30
        public void set_HideOffsetInInspector(){} // RVA: 0xC5F680
        public void get_EffectiveOffset(){} // RVA: 0x1D0DB90
        public void get_IsValid(){} // RVA: 0x1D0DBD0
        public void get_Stage(){} // RVA: 0x519240
        public void GetMaxDampTime(){} // RVA: 0x1D0DCF0
        public void MutateCameraState(){} // RVA: 0x1D0DD80
        public void OnTargetObjectWarped(){} // RVA: 0x1D0E460
        public void ForceCameraPosition(){} // RVA: 0x1D0E5D0
        public void InitPrevFrameStateInfo(){} // RVA: 0x1D0E910
        public void TrackTarget(){} // RVA: 0x1D0EB70
        public void GetOffsetForMinimumTargetDistance(){} // RVA: 0x1D0FCC0
        public void get_Damping(){} // RVA: 0x1D10260
        public void get_AngularDamping(){} // RVA: 0x1D102A0
        public void GetTargetCameraPosition(){} // RVA: 0x1D10380
        public void GetReferenceOrientation(){} // RVA: 0x1D10680
        public void .ctor(){} // RVA: 0x1D10D00
    }

    public class CinemachineTriggerAction
    {
        // ── Methods ──
        public void Filter(){} // RVA: 0x1D2D550
        public void InternalDoTriggerEnter(){} // RVA: 0x1D2D670
        public void InternalDoTriggerExit(){} // RVA: 0x1D2D800
        public void OnTriggerEnter(){} // RVA: 0x1D2D8E0
        public void OnTriggerExit(){} // RVA: 0x1D2D960
        public void OnCollisionEnter(){} // RVA: 0x1D2D9E0
        public void OnCollisionExit(){} // RVA: 0x1D2DA20
        public void OnTriggerEnter2D(){} // RVA: 0x1D2D8E0
        public void OnTriggerExit2D(){} // RVA: 0x1D2D960
        public void OnCollisionEnter2D(){} // RVA: 0x1D2DA60
        public void OnCollisionExit2D(){} // RVA: 0x1D2DAA0
        public void OnEnable(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x1D2DAE0
    }

    public class CinemachineVirtualCamera
    {
        // ── Methods ──
        public void get_State(){} // RVA: 0x1CEB7C0
        public void get_LookAt(){} // RVA: 0x1CC9FF0
        public void set_LookAt(){} // RVA: 0xAE5030
        public void get_Follow(){} // RVA: 0x1CCA000
        public void set_Follow(){} // RVA: 0x348050
        public void GetMaxDampTime(){} // RVA: 0x1CF6110
        public void InternalUpdateCameraState(){} // RVA: 0x1CF6280
        public void OnEnable(){} // RVA: 0x1CF6760
        public void OnDestroy(){} // RVA: 0x1CF6DE0
        public void OnValidate(){} // RVA: 0x1CF7170
        public void OnTransformChildrenChanged(){} // RVA: 0x1CF7250
        public void Reset(){} // RVA: 0x1CF72B0
        public void DestroyPipeline(){} // RVA: 0x1CF72D0
        public void CreatePipeline(){} // RVA: 0x1CF7A00
        public void InvalidateComponentPipeline(){} // RVA: 0x1CF7250
        public void GetComponentOwner(){} // RVA: 0x1CF7D70
        public void GetComponentPipeline(){} // RVA: 0x1CF7D90
        public void GetCinemachineComponent(){} // RVA: 0x283FA0 | overloaded x2
        public void AddCinemachineComponent(){} // RVA: 0x283FA0
        public void DestroyCinemachineComponent(){} // RVA: 0x24A50
        public void UpdateComponentPipeline(){} // RVA: 0x1CF7E40
        public void SetFlagsForHiddenChild(){} // RVA: 0x1CF86B0
        public void CalculateNewState(){} // RVA: 0x1CF8860
        public void OnTargetObjectWarped(){} // RVA: 0x1CF9320
        public void ForceCameraPosition(){} // RVA: 0x1CF96B0
        public void SetStateRawPosition(){} // RVA: 0x1CF9930
        public void OnTransitionFromCamera(){} // RVA: 0x1CF9950
        public void RequiresUserInput(){} // RVA: 0x1CF9E60
        public void OnBeforeSerialize(){} // RVA: 0x1CFA120
        public void .ctor(){} // RVA: 0x1CFA200
    }

    public class CinemachineVirtualCameraBase
    {
        // ── Methods ──
        public void get_ValidatingStreamVersion(){} // RVA: 0x1D1FF30
        public void set_ValidatingStreamVersion(){} // RVA: 0x338CE0
        public void GetMaxDampTime(){} // RVA: 0x1D1FFA0
        public void DetachedFollowTargetDamp(){} // RVA: 0x1D202A0 | overloaded x3
        public void DetachedLookAtTargetDamp(){} // RVA: 0x1D20570 | overloaded x3
        public void AddExtension(){} // RVA: 0x1D20620
        public void RemoveExtension(){} // RVA: 0x1D20780
        public void get_mExtensions(){} // RVA: 0x37E0E0
        public void set_mExtensions(){} // RVA: 0x4354D0
        public void InvokePostPipelineStageCallback(){} // RVA: 0x1D207E0
        public void InvokePrePipelineMutateCameraStateCallback(){} // RVA: 0x1D20AD0
        public void InvokeOnTransitionInExtensions(){} // RVA: 0x1D20DB0
        public void get_Name(){} // RVA: 0x59E520
        public void get_Description(){} // RVA: 0x1D20FD0
        public void get_Priority(){} // RVA: 0x891AF0
        public void set_Priority(){} // RVA: 0x1CB95F0
        public void ApplyPositionBlendMethod(){} // RVA: 0x1D21010
        public void get_VirtualCameraGameObject(){} // RVA: 0x1D21040
        public void get_IsValid(){} // RVA: 0x1D21150
        public void get_State(){}
        public void get_ParentCamera(){} // RVA: 0x1D21220
        public void IsLiveChild(){} // RVA: 0x2DD320
        public void get_LookAt(){} // RVA: 0xCD60
        public void set_LookAt(){} // RVA: 0x24B10
        public void get_Follow(){} // RVA: 0xCD60
        public void set_Follow(){} // RVA: 0x24B10
        public void get_PreviousStateIsValid(){} // RVA: 0x59FF30
        public void set_PreviousStateIsValid(){} // RVA: 0xC5F680
        public void UpdateCameraState(){} // RVA: 0x1D212C0
        public void InternalUpdateCameraState(){}
        public void OnTransitionFromCamera(){} // RVA: 0x1D21360
        public void OnDestroy(){} // RVA: 0x1D21430
        public void OnTransformParentChanged(){} // RVA: 0x1D21560
        public void Start(){} // RVA: 0x490630
        public void RequiresUserInput(){} // RVA: 0x1D21600
        public void EnsureStarted(){} // RVA: 0x1D21780
        public void GetInputAxisProvider(){} // RVA: 0x1D21840
        public void OnValidate(){} // RVA: 0x1D21900
        public void OnEnable(){} // RVA: 0x1D21970
        public void OnDisable(){} // RVA: 0x1D21CE0
        public void Update(){} // RVA: 0x1D21D50
        public void UpdateSlaveStatus(){} // RVA: 0x1D21D60
        public void ResolveLookAt(){} // RVA: 0x1D21F40
        public void ResolveFollow(){} // RVA: 0x1D22060
        public void UpdateVcamPoolStatus(){} // RVA: 0x1D22180
        public void MoveToTopOfPrioritySubqueue(){} // RVA: 0x1D223B0
        public void OnTargetObjectWarped(){} // RVA: 0x1D223C0
        public void ForceCameraPosition(){} // RVA: 0x1D224C0
        public void GetInheritPosition(){} // RVA: 0x1D225D0
        public void CreateBlend(){} // RVA: 0x1D226E0
        public void PullStateFromVirtualCamera(){} // RVA: 0x1D22B40
        public void InvalidateCachedTargets(){} // RVA: 0x1D22E70
        public void get_FollowTargetChanged(){} // RVA: 0x1B6CD50
        public void set_FollowTargetChanged(){} // RVA: 0xB70090
        public void get_LookAtTargetChanged(){} // RVA: 0x1D23080
        public void set_LookAtTargetChanged(){} // RVA: 0x1D23090
        public void UpdateTargetCache(){} // RVA: 0x1D230A0
        public void get_AbstractFollowTargetGroup(){} // RVA: 0x462D00
        public void get_FollowTargetAsVcam(){} // RVA: 0x4C7C50
        public void get_AbstractLookAtTargetGroup(){} // RVA: 0xA1C8C0
        public void get_LookAtTargetAsVcam(){} // RVA: 0x796DE0
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x1D236A0
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x1D236C0
        public void LegacyUpgrade(){} // RVA: 0x2DD310
        public void OnBeforeSerialize(){} // RVA: 0x2DD310
        public void CancelDamping(){} // RVA: 0x1D23770
        public void .ctor(){} // RVA: 0x1D239D0
    }

    public class ClipperLib
    {
    }

    public class ConfinerOven
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1D23C70
        public void GetBakedSolution(){} // RVA: 0x1D23DA0
        public void get_State(){} // RVA: 0x9EAB90
        public void set_State(){} // RVA: 0x9EAAE0
        public void Initialize(){} // RVA: 0x1D24200
        public void BakeConfiner(){} // RVA: 0x1D24A60
        public void <Initialize>g__GetPolygonBoundingBox|24_0(){} // RVA: 0x1D250B0
        public void <Initialize>g__MidPointOfIntRect|24_1(){} // RVA: 0x1D25270
        public void <BakeConfiner>g__ComputeSkeleton|25_0(){} // RVA: 0x1D252A0
    }

    public class Documentation
    {
    }

    public class DocumentationSortingAttribute
    {
        // ── Methods ──
        public void get_Category(){} // RVA: 0x32A5C0
        public void set_Category(){} // RVA: 0x2E00C0
        public void .ctor(){} // RVA: 0x2E00C0
    }

    public class GroupWeightManipulator
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x1D2E9F0
        public void OnValidate(){} // RVA: 0x1D2EA80
        public void Update(){} // RVA: 0x1D2EAF0
        public void UpdateWeights(){} // RVA: 0x1D2ECC0
        public void .ctor(){} // RVA: 0x1D2EDB0
    }

    public class ICameraOverrideStack
    {
        // ── Methods ──
        public void SetCameraOverride(){}
        public void ReleaseCameraOverride(){} // RVA: 0x24FA0
        public void get_DefaultWorldUp(){} // RVA: 0xC770
    }

    public class ICinemachineCamera
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0xCD60
        public void get_Description(){} // RVA: 0xCD60
        public void get_Priority(){} // RVA: 0xD840
        public void set_Priority(){} // RVA: 0x24FA0
        public void get_LookAt(){} // RVA: 0xCD60
        public void set_LookAt(){} // RVA: 0x24B10
        public void get_Follow(){} // RVA: 0xCD60
        public void set_Follow(){} // RVA: 0x24B10
        public void get_State(){}
        public void get_VirtualCameraGameObject(){} // RVA: 0xCD60
        public void get_IsValid(){} // RVA: 0xDBE0
        public void get_ParentCamera(){} // RVA: 0xCD60
        public void IsLiveChild(){}
        public void UpdateCameraState(){}
        public void InternalUpdateCameraState(){}
        public void OnTransitionFromCamera(){}
        public void OnTargetObjectWarped(){}
    }

    public class ICinemachineTargetGroup
    {
        // ── Methods ──
        public void get_Transform(){} // RVA: 0xCD60
        public void get_BoundingBox(){}
        public void get_Sphere(){}
        public void get_IsEmpty(){} // RVA: 0xDBE0
        public void GetViewSpaceBoundingBox(){}
        public void GetViewSpaceAngularBounds(){}
    }

    public class ISignalSource6D
    {
        // ── Methods ──
        public void get_SignalDuration(){} // RVA: 0x21890
        public void GetSignal(){}
    }

    public class LensSettings
    {
        // ── Methods ──
        public void get_Orthographic(){} // RVA: 0x1D26820
        public void set_Orthographic(){} // RVA: 0x1D26840
        public void get_SensorSize(){} // RVA: 0x18F7880
        public void set_SensorSize(){} // RVA: 0x8AC650
        public void get_Aspect(){} // RVA: 0x1D26850
        public void get_IsPhysicalCamera(){} // RVA: 0x1D268E0
        public void set_IsPhysicalCamera(){} // RVA: 0x1D26900
        public void FromCamera(){} // RVA: 0x1D26910
        public void SnapshotCameraReadOnlyProperties(){} // RVA: 0x1D270B0 | overloaded x2
        public void .ctor(){} // RVA: 0x1D271C0
        public void Lerp(){} // RVA: 0x1D27210
        public void Validate(){} // RVA: 0x1D27470
        public void .cctor(){} // RVA: 0x1D274F0
    }

    public class LensSettingsPropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class NoSaveDuringPlayAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class NoiseSettings
    {
        // ── Methods ──
        public void GetCombinedFilterResults(){} // RVA: 0x1D27580
        public void get_SignalDuration(){} // RVA: 0xAFF380
        public void GetSignal(){} // RVA: 0x1D27700
        public void .ctor(){} // RVA: 0x1D278B0
    }

    public class NoiseSettingsPropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class NotNullAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1D18CC0
        public void SetState(){} // RVA: 0x1D18DC0
        public void get_Name(){} // RVA: 0x2F8380
        public void set_Name(){} // RVA: 0x2DEE30
        public void get_Description(){} // RVA: 0x1D18E70
        public void get_Priority(){} // RVA: 0x5BED50
        public void set_Priority(){} // RVA: 0x6374E0
        public void get_LookAt(){} // RVA: 0x30B0C0
        public void set_LookAt(){} // RVA: 0x30B0D0
        public void get_Follow(){} // RVA: 0x30B130
        public void set_Follow(){} // RVA: 0x2DEE90
        public void get_State(){} // RVA: 0x1D18EB0
        public void set_State(){} // RVA: 0x1D18F50
        public void get_VirtualCameraGameObject(){} // RVA: 0x519240
        public void get_IsValid(){} // RVA: 0x3C2850
        public void get_ParentCamera(){} // RVA: 0x519240
        public void IsLiveChild(){} // RVA: 0x2DD320
        public void UpdateCameraState(){} // RVA: 0x2DD310
        public void InternalUpdateCameraState(){} // RVA: 0x2DD310
        public void OnTransitionFromCamera(){} // RVA: 0x2DD310
        public void OnTargetObjectWarped(){} // RVA: 0x2DD310
    }

    public class OrbitalTransposerHeadingPropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class RuntimeUtility
    {
        // ── Methods ──
        public void DestroyObject(){} // RVA: 0x1D27AF0
        public void IsPrefab(){} // RVA: 0x2DD320
        public void RaycastIgnoreTag(){} // RVA: 0x1D27BE0
        public void SphereCastIgnoreTag(){} // RVA: 0x1D27FA0
        public void GetScratchCollider(){} // RVA: 0x1D28B10
        public void DestroyScratchCollider(){} // RVA: 0x1D290B0
        public void NormalizeCurve(){} // RVA: 0x1D293A0
        public void .cctor(){} // RVA: 0x1D29610
    }

    public class SaveDuringPlayAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class SignalSourceAsset
    {
        // ── Methods ──
        public void get_SignalDuration(){} // RVA: 0x21890
        public void GetSignal(){}
        public void .ctor(){} // RVA: 0x53BFB0
    }

    public class TagFieldAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class TargetPositionCache
    {
        // ── Methods ──
        public void get_CacheMode(){} // RVA: 0x1D29760
        public void set_CacheMode(){} // RVA: 0x1D297A0
        public void get_IsRecording(){} // RVA: 0x1D29810
        public void get_CurrentPlaybackTimeValid(){} // RVA: 0x1D29860
        public void get_IsEmpty(){} // RVA: 0x1D298F0
        public void get_CacheTimeRange(){} // RVA: 0x1D29940
        public void get_HasCurrentTime(){} // RVA: 0x1D29990
        public void ClearCache(){} // RVA: 0x1D299F0
        public void CreatePlaybackCurves(){} // RVA: 0x1D29B60
        public void GetTargetPosition(){} // RVA: 0x1D29DB0
        public void GetTargetRotation(){} // RVA: 0x1D2A270
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class UpdateTracker
    {
        // ── Methods ──
        public void InitializeModule(){} // RVA: 0x1D2BA80
        public void UpdateTargets(){} // RVA: 0x1D2BB00
        public void GetPreferredUpdate(){} // RVA: 0x1D2C000
        public void OnUpdate(){} // RVA: 0x1D2C370
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x1D2C430
    }

    public class VcamTargetPropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

}