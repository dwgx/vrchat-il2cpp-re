// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Cinemachine.Cinemachine
// Classes: 83
// Methods: 917

namespace ThirdParty.Cinemachine.Cinemachine
{
    public class AxisBase : ValueType
    {
        public object m_MaxValue; // 0x34B465F0

        // ── Original Methods ──
        public void Validate(){} // RVA: 0x7ffaaa24bdb0
    }

    public class AxisState : ValueType
    {
        public object m_MaxSpeed; // 0x3370EF90
        public object m_InputAxisName; // 0x3370EF90
        public object m_MinValue; // 0x3370EF90
        public object m_Recentering; // 0x3370EF90
        public object m_LastUpdateFrame; // 0x3370EF90
        public object m_InputAxisIndex; // 0x3370EF90
        public object m_enabled; // 0x34B449C0
        public object m_LastUpdateTime; // 0x34B449C0
        public object m_LegacyHeadingDefinition; // 0x34B449C0
        public object m_VelocityFilterStrength; // 0x34B3F490

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaa23e860
        public void Validate(){} // RVA: 0x7ffaaa23e9d0
        public void Reset(){} // RVA: 0x7ffaaa23ea30
        public void get_HasInputProvider(){} // RVA: 0x7ffaaa23eaa0
        public void Update(){} // RVA: 0x7ffaaa23eab0
        public void ClampValue(){} // RVA: 0x7ffaaa23efb0
        public void MaxSpeedUpdate(){} // RVA: 0x7ffaaa23f020
        public void get_ValueRangeLocked(){} // RVA: 0x7ffaaa23f310
        public void set_ValueRangeLocked(){} // RVA: 0x7ffaaa23f320
        public void get_HasRecentering(){} // RVA: 0x7ffaaa23f330
        public void set_HasRecentering(){} // RVA: 0x7ffaaa23f340
        // ── Binary Analysis Named ──
        public void SetInputAxisProvider(){} // RVA: 0x7ffaaa23ea40
        public void GetMaxSpeed(){} // RVA: 0x7ffaaa23f260
    }

    public class AxisStatePropertyAttribute : PropertyAttribute
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class BlendSourceVirtualCamera : Object
    {
        public object _lookAt; // 0x34B45630, was: <LookAt>k__BackingField

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8933e30
        public void get_Blend(){} // RVA: 0x7ffaa894d380
        public void set_Blend(){} // RVA: 0x7ffaa8933e30
        public void get_Name(){} // RVA: 0x7ffaaa246a20
        public void get_Description(){} // RVA: 0x7ffaaa246a60
        public void get_Priority(){} // RVA: 0x7ffaa8b945a0
        public void set_Priority(){} // RVA: 0x7ffaa9357830
        public void get_LookAt(){} // RVA: 0x7ffaa89600c0
        public void set_LookAt(){} // RVA: 0x7ffaa89600d0
        public void get_Follow(){} // RVA: 0x7ffaa8960130
        public void set_Follow(){} // RVA: 0x7ffaa8933e90
        public void get_State(){} // RVA: 0x7ffaaa2468a0
        public void set_State(){} // RVA: 0x7ffaaa246940
        public void get_VirtualCameraGameObject(){} // RVA: 0x7ffaa8f22da0
        public void get_IsValid(){} // RVA: 0x7ffaaa246ab0
        public void get_ParentCamera(){} // RVA: 0x7ffaa8f22da0
        public void IsLiveChild(){} // RVA: 0x7ffaaa246ad0
        public void CalculateNewState(){} // RVA: 0x7ffaaa2468a0
        public void UpdateCameraState(){} // RVA: 0x7ffaaa246af0
        public void InternalUpdateCameraState(){} // RVA: 0x7ffaa8932310
        public void OnTransitionFromCamera(){} // RVA: 0x7ffaa8932310
        public void OnTargetObjectWarped(){} // RVA: 0x7ffaa8932310
    }

    public class CameraState : ValueType
    {
        public object ReferenceLookAt; // 0x33467D50
        public object RawOrientation; // 0x33467D50
        public object PositionCorrection; // 0x33467D50
        public object mCustom0; // 0x33467D50
        public object mCustom3; // 0x33467D50
        public object Default; // 0x33726730
        public object NearClipPlane; // 0x33726730
        public object ModeOverride; // 0x33726730

        // ── Original Methods ──
        public void get_HasLookAt(){} // RVA: 0x7ffaaa23f720
        public void get_CorrectedPosition(){} // RVA: 0x7ffaaa23f780
        public void get_CorrectedOrientation(){} // RVA: 0x7ffaaa23f7d0
        public void get_FinalPosition(){} // RVA: 0x7ffaaa23f780
        public void get_FinalOrientation(){} // RVA: 0x7ffaaa23f940
        public void get_Default(){} // RVA: 0x7ffaaa23fc00
        public void get_NumCustomBlendables(){} // RVA: 0x7ffaaa23fe60
        public void set_NumCustomBlendables(){} // RVA: 0x7ffaaa23fe70
        public void FindCustomBlendable(){} // RVA: 0x7ffaaa23fff0
        public void AddCustomBlendable(){} // RVA: 0x7ffaaa240570
        public void Lerp(){} // RVA: 0x7ffaaa240930
        public void InterpolateFOV(){} // RVA: 0x7ffaaa244990
        public void ApplyPosBlendHint(){} // RVA: 0x7ffaaa244ae0
        public void ApplyRotBlendHint(){} // RVA: 0x7ffaaa244b60
        public void InterpolatePosition(){} // RVA: 0x7ffaaa244bb0
        public void .cctor(){} // RVA: 0x7ffaaa2450a0
        // ── Binary Analysis Named ──
        public void GetCustomBlendable(){} // RVA: 0x7ffaaa23fe80
    }

    public class Cinemachine3rdPersonAim : CinemachineExtension
    {
        public object AimDistance; // 0x33518CD0
        public object 00; // 0x400002C

        // ── Original Methods ──
        public void get_AimTarget(){} // RVA: 0x7ffaa8998fa0
        public void set_AimTarget(){} // RVA: 0x7ffaa8998fc0
        public void OnValidate(){} // RVA: 0x7ffaaa1f6350
        public void Reset(){} // RVA: 0x7ffaaa1f6370
        public void OnTransitionFromCamera(){} // RVA: 0x7ffaaa1f6480
        public void DrawReticle(){} // RVA: 0x7ffaaa1f6600
        public void ComputeLookAtPoint(){} // RVA: 0x7ffaaa1f6990
        public void ComputeAimTarget(){} // RVA: 0x7ffaaa1f6fc0
        public void PostPipelineStageCallback(){} // RVA: 0x7ffaaa1f7240
        public void .ctor(){} // RVA: 0x7ffaaa1f7590
    }

    public class Cinemachine3rdPersonFollow : CinemachineComponentBase
    {
        public object VerticalArmLength; // 0x33A8EC40
        public object CameraCollisionFilter; // 0x33A8EC40
        public object DampingIntoCollision; // 0x33A8EC40
        public object m_DampingCorrection; // 0x33A8EC40
        public object m_PivotOffset; // 0x335A0230

        // ── Original Methods ──
        public void OnValidate(){} // RVA: 0x7ffaaa228000
        public void Reset(){} // RVA: 0x7ffaaa228080
        public void OnDestroy(){} // RVA: 0x7ffaaa2280f0
        public void get_IsValid(){} // RVA: 0x7ffaaa228140
        public void get_Stage(){} // RVA: 0x7ffaa8f22da0
        public void MutateCameraState(){} // RVA: 0x7ffaaa228290
        public void OnTargetObjectWarped(){} // RVA: 0x7ffaaa228320
        public void PositionCamera(){} // RVA: 0x7ffaaa228490
        public void ResolveCollisions(){} // RVA: 0x7ffaaa2296d0
        public void .ctor(){} // RVA: 0x7ffaaa229a20
        // ── Binary Analysis Named ──
        public void GetMaxDampTime(){} // RVA: 0x7ffaaa228260
        public void GetRigPositions(){} // RVA: 0x7ffaaa228bb0
        public void GetHeading(){} // RVA: 0x7ffaaa228dd0
        public void GetRawRigPositions(){} // RVA: 0x7ffaaa229350
    }

    public class CinemachineBasicMultiChannelPerlin : CinemachineComponentBase
    {
        public object m_AmplitudeGain; // 0x335A0230
        public object mNoiseTime; // 0x335A0230

        // ── Original Methods ──
        public void get_IsValid(){} // RVA: 0x7ffaaa229af0
        public void get_Stage(){} // RVA: 0x7ffaa8a37cb0
        public void MutateCameraState(){} // RVA: 0x7ffaaa229c10
        public void ReSeed(){} // RVA: 0x7ffaaa22a6f0
        public void Initialize(){} // RVA: 0x7ffaaa22a820
        public void .ctor(){} // RVA: 0x7ffaaa22aa30
    }

    public class CinemachineBlend : Object
    {
        public object BlendCurve; // 0x33641E80

        // ── Original Methods ──
        public void get_BlendWeight(){} // RVA: 0x7ffaaa2450f0
        public void get_IsValid(){} // RVA: 0x7ffaaa2451e0
        public void get_IsComplete(){} // RVA: 0x7ffaaa245260
        public void get_Description(){} // RVA: 0x7ffaaa245290
        public void Uses(){} // RVA: 0x7ffaaa2454a0
        public void .ctor(){} // RVA: 0x7ffaaa2455e0
        public void UpdateCameraState(){} // RVA: 0x7ffaaa245700
        public void get_State(){} // RVA: 0x7ffaaa2457f0
    }

    public class CinemachineBlendDefinition : ValueType
    {
        public object m_CustomCurve; // 0x34B45220

        // ── Original Methods ──
        public void get_BlendTime(){} // RVA: 0x7ffaaa245cc0
        public void .ctor(){} // RVA: 0x7ffaaa245cd0
        public void CreateStandardCurves(){} // RVA: 0x7ffaaa245d30
        public void get_BlendCurve(){} // RVA: 0x7ffaaa2465a0
    }

    public class CinemachineBlendDefinitionPropertyAttribute : PropertyAttribute
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class CinemachineBlendListCamera : CinemachineVirtualCameraBase
    {
        public object m_ShowDebugText; // 0x336F4BD0
        public object m_Instructions; // 0x336F4BD0
        public object m_State; // 0x336F4BD0
        public object mActiveBlend; // 0x336F4BD0
        public object ReferenceLookAt; // 0x33467D50
        public object RawOrientation; // 0x33467D50

        // ── Original Methods ──
        public void get_Description(){} // RVA: 0x7ffaaa1f7660
        public void Reset(){} // RVA: 0x7ffaaa1f77a0
        public void get_LiveChild(){} // RVA: 0x7ffaa8a4f100
        public void set_LiveChild(){} // RVA: 0x7ffaa8a4f110
        public void IsLiveChild(){} // RVA: 0x7ffaaa1f7910
        public void get_State(){} // RVA: 0x7ffaaa1f7940
        public void get_LookAt(){} // RVA: 0x7ffaaa1f79e0
        public void set_LookAt(){} // RVA: 0x7ffaa8d71dc0
        public void get_Follow(){} // RVA: 0x7ffaaa1f79f0
        public void set_Follow(){} // RVA: 0x7ffaa899d050
        public void OnTargetObjectWarped(){} // RVA: 0x7ffaaa1f7a00
        public void ForceCameraPosition(){} // RVA: 0x7ffaaa1f7ae0
        public void OnTransitionFromCamera(){} // RVA: 0x7ffaaa1f7c70
        public void InternalUpdateCameraState(){} // RVA: 0x7ffaaa1f7ea0
        public void OnEnable(){} // RVA: 0x7ffaaa1f8870
        public void OnDisable(){} // RVA: 0x7ffaaa1f8bd0
        public void OnTransformChildrenChanged(){} // RVA: 0x7ffaaa1f8d50
        public void OnGuiHandler(){} // RVA: 0x7ffaaa1f8d60
        public void get_ChildCameras(){} // RVA: 0x7ffaaa1f8ed0
        public void get_IsBlending(){} // RVA: 0x7ffaaa1f8ef0
        public void InvalidateListOfChildren(){} // RVA: 0x7ffaaa1f8f00
        public void UpdateListOfChildren(){} // RVA: 0x7ffaaa1f8fc0
        public void ValidateInstructions(){} // RVA: 0x7ffaaa1f9350
        public void AdvanceCurrentInstruction(){} // RVA: 0x7ffaaa1f9750
        public void .ctor(){} // RVA: 0x7ffaaa1f99b0
    }

    public class CinemachineBlenderSettings : ScriptableObject
    {
        public object 00; // 0x4000298

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8b59ae0
        // ── Binary Analysis Named ──
        public void GetBlendForVirtualCameras(){} // RVA: 0x7ffaaa246cc0
    }

    public class CinemachineBrain : MonoBehaviour
    {
        public object m_IgnoreTimeScale; // 0x33837CD0
        public object m_BlendUpdateMethod; // 0x33837CD0
        public object m_OutputCamera; // 0x33837CD0
        public object m_CameraActivatedEvent; // 0x33837CD0
        public object m_LastFrameUpdated; // 0x33837CD0
        public object mNextFrameId; // 0x33837CD0
        public object mActiveCameraPreviousFrame; // 0x33837CD0
        public object `;
        public object `; // 0x348D7F20

        // ── Original Methods ──
        public void get_OutputCamera(){} // RVA: 0x7ffaaa1f9b80
        public void get_ControlledObject(){} // RVA: 0x7ffaaa1f9cf0
        public void set_ControlledObject(){} // RVA: 0x7ffaaa1f9e10
        public void get_SoloCamera(){} // RVA: 0x7ffaaa1f9ed0
        public void set_SoloCamera(){} // RVA: 0x7ffaaa1f9f30
        public void get_DefaultWorldUp(){} // RVA: 0x7ffaaa1fa1b0
        public void OnEnable(){} // RVA: 0x7ffaaa1fa340
        public void OnDisable(){} // RVA: 0x7ffaaa1fa8b0
        public void OnSceneLoaded(){} // RVA: 0x7ffaaa1fabb0
        public void OnSceneUnloaded(){} // RVA: 0x7ffaaa1fac50
        public void Awake(){} // RVA: 0x7ffaaa1facf0
        public void Start(){} // RVA: 0x7ffaaa1fad50
        public void OnGuiHandler(){} // RVA: 0x7ffaaa1fad70
        public void AfterPhysics(){} // RVA: 0x7ffaaa1fb250
        public void LateUpdate(){} // RVA: 0x7ffaaa1fb2f0
        public void ManualUpdate(){} // RVA: 0x7ffaaa1fb300
        public void UpdateVirtualCameras(){} // RVA: 0x7ffaaa1fb8d0
        public void get_ActiveVirtualCamera(){} // RVA: 0x7ffaaa1fbc60
        public void DeepCamBFromBlend(){} // RVA: 0x7ffaaa1fbde0
        public void IsLiveInBlend(){} // RVA: 0x7ffaaa1fbea0
        public void get_IsBlending(){} // RVA: 0x7ffaaa1fbfe0
        public void get_ActiveBlend(){} // RVA: 0x7ffaaa1fc000
        public void set_ActiveBlend(){} // RVA: 0x7ffaaa1fc100
        public void ReleaseCameraOverride(){} // RVA: 0x7ffaaa1fc890
        public void ProcessActiveCamera(){} // RVA: 0x7ffaaa1fc970
        public void UpdateFrame0(){} // RVA: 0x7ffaaa1fd0c0
        public void ComputeCurrentBlend(){} // RVA: 0x7ffaaa1fd8f0
        public void IsLive(){} // RVA: 0x7ffaaa1fdef0
        public void get_CurrentCameraState(){} // RVA: 0x7ffaaa1fe0d0
        public void set_CurrentCameraState(){} // RVA: 0x7ffaaa1fe170
        public void TopCameraFromPriorityQueue(){} // RVA: 0x7ffaaa1fe260
        public void LookupBlend(){} // RVA: 0x7ffaaa1fe590
        public void PushStateToUnityCamera(){} // RVA: 0x7ffaaa1fe7f0
        public void .ctor(){} // RVA: 0x7ffaaa1fee80
        public void .cctor(){} // RVA: 0x7ffaaa1ff2e0
        // ── Binary Analysis Named ──
        public void GetSoloGUIColor(){} // RVA: 0x7ffaaa1fa190
        public void GetEffectiveDeltaTime(){} // RVA: 0x7ffaaa1fb630
        public void GetBrainFrame(){} // RVA: 0x7ffaaa1fc220
        public void SetCameraOverride(){} // RVA: 0x7ffaaa1fc360
    }

    public class CinemachineClearShot : CinemachineVirtualCameraBase
    {
        public object m_ShowDebugText; // 0x337DEC90
        public object m_MinDuration; // 0x337DEC90
        public object m_CustomBlends; // 0x337DEC90
        public object mActivationTime; // 0x337DEC90
        public object mActiveBlend; // 0x337DEC90
        public object m_TransitioningFrom; // 0x337DEC90
        public object Description; // 0x17000016
        public object LiveChild; // 0x17000017
        public object State; // 0x17000018
        public object LookAt; // 0x17000019
        public object Follow; // 0x1700001A
        public object IsBlending; // 0x1700001B

        // ── Original Methods ──
        public void get_Description(){} // RVA: 0x7ffaaa1ff8a0
        public void get_LiveChild(){} // RVA: 0x7ffaa899d2a0
        public void set_LiveChild(){} // RVA: 0x7ffaa899d2b0
        public void get_State(){} // RVA: 0x7ffaaa1ff9e0
        public void IsLiveChild(){} // RVA: 0x7ffaaa1ffa80
        public void get_LookAt(){} // RVA: 0x7ffaaa1f79e0
        public void set_LookAt(){} // RVA: 0x7ffaa8d71dc0
        public void get_Follow(){} // RVA: 0x7ffaaa1f79f0
        public void set_Follow(){} // RVA: 0x7ffaa899d050
        public void OnTargetObjectWarped(){} // RVA: 0x7ffaaa1ffab0
        public void ForceCameraPosition(){} // RVA: 0x7ffaaa1ffb90
        public void InternalUpdateCameraState(){} // RVA: 0x7ffaaa1ffd20
        public void OnEnable(){} // RVA: 0x7ffaaa200460
        public void OnDisable(){} // RVA: 0x7ffaaa200770
        public void OnTransformChildrenChanged(){} // RVA: 0x7ffaaa2008f0
        public void OnGuiHandler(){} // RVA: 0x7ffaaa200910
        public void get_IsBlending(){} // RVA: 0x7ffaaa200a80
        public void get_ActiveBlend(){} // RVA: 0x7ffaa8f6fa20
        public void get_ChildCameras(){} // RVA: 0x7ffaaa200a90
        public void InvalidateListOfChildren(){} // RVA: 0x7ffaaa200ab0
        public void ResetRandomization(){} // RVA: 0x7ffaaa200bd0
        public void UpdateListOfChildren(){} // RVA: 0x7ffaaa200c50
        public void ChooseCurrentCamera(){} // RVA: 0x7ffaaa201110
        public void Randomize(){} // RVA: 0x7ffaaa201af0
        public void LookupBlend(){} // RVA: 0x7ffaaa202020
        public void OnTransitionFromCamera(){} // RVA: 0x7ffaaa202290
        public void .ctor(){} // RVA: 0x7ffaaa202420
    }

    public class CinemachineCollider : CinemachineExtension
    {
        public object m_TransparentLayers; // 0x33C2DD00
        public object m_DistanceLimit; // 0x33C2DD00
        public object m_Strategy; // 0x33C2DD00
        public object m_Damping; // 0x33C2DD00
        public object k_PrecisionSlush; // 0x33C2DD00
        public object s_ColliderBuffer; // 0x33C2DD00
        public object DebugPaths; // 0x1700001E
        public object Confine3D; // 0x34B07260
        public object .ctor; // 0xB3F6FFF0

        // ── Original Methods ──
        public void IsTargetObscured(){} // RVA: 0x7ffaaa202770
        public void CameraWasDisplaced(){} // RVA: 0x7ffaaa2027d0
        public void OnValidate(){} // RVA: 0x7ffaaa2028b0
        public void OnDestroy(){} // RVA: 0x7ffaaa202900
        public void get_DebugPaths(){} // RVA: 0x7ffaaa202970
        public void OnTargetObjectWarped(){} // RVA: 0x7ffaaa202bb0
        public void PostPipelineStageCallback(){} // RVA: 0x7ffaaa202cb0
        public void PreserveLineOfSight(){} // RVA: 0x7ffaaa203f80
        public void PullCameraInFrontOfNearestObstacle(){} // RVA: 0x7ffaaa204570
        public void PushCameraBack(){} // RVA: 0x7ffaaa204a90
        public void ClampRayToBounds(){} // RVA: 0x7ffaaa205fd0
        public void RespectCameraRadius(){} // RVA: 0x7ffaaa206ee0
        public void IsTargetOffscreen(){} // RVA: 0x7ffaaa208020
        public void .ctor(){} // RVA: 0x7ffaaa2088a0
        public void .cctor(){} // RVA: 0x7ffaaa208a10
        // ── Binary Analysis Named ──
        public void GetCameraDisplacementDistance(){} // RVA: 0x7ffaaa202840
        public void GetMaxDampTime(){} // RVA: 0x7ffaaa202b90
        public void GetWalkingDirection(){} // RVA: 0x7ffaaa205520
        public void GetPushBackDistance(){} // RVA: 0x7ffaaa205e60
        public void CheckForTargetObstructions(){} // RVA: 0x7ffaaa207bb0
    }

    public class CinemachineCollisionImpulseSource : CinemachineImpulseSource
    {
        public object m_UseImpactDirection; // 0x33B05DF0
        public object mRigidBody; // 0x33B05DF0
        public object 00; // 0x4
        public object m_ZCurve; // 0x339F52E0

        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffaaa25c820
        public void OnEnable(){} // RVA: 0x7ffaa8932310
        public void OnCollisionEnter(){} // RVA: 0x7ffaaa25c940
        public void OnTriggerEnter(){} // RVA: 0x7ffaaa25c9f0
        public void GenerateImpactEvent(){} // RVA: 0x7ffaaa25cf60
        public void OnCollisionEnter2D(){} // RVA: 0x7ffaaa25d2d0
        public void OnTriggerEnter2D(){} // RVA: 0x7ffaaa25d330
        public void GenerateImpactEvent2D(){} // RVA: 0x7ffaaa25d7f0
        public void .ctor(){} // RVA: 0x7ffaaa25db60
        // ── Binary Analysis Named ──
        public void GetMassAndVelocity(){} // RVA: 0x7ffaaa25ca60
        public void GetMassAndVelocity2D(){} // RVA: 0x7ffaaa25d3a0
    }

    public class CinemachineComponentBase : MonoBehaviour
    {
        // ── Original Methods ──
        public void get_VirtualCamera(){} // RVA: 0x7ffaaa247020
        public void get_FollowTarget(){} // RVA: 0x7ffaaa247430
        public void get_LookAtTarget(){} // RVA: 0x7ffaaa247530
        public void get_AbstractFollowTargetGroup(){} // RVA: 0x7ffaaa247630
        public void get_FollowTargetGroup(){} // RVA: 0x7ffaaa247710
        public void get_FollowTargetPosition(){} // RVA: 0x7ffaaa2477a0
        public void get_FollowTargetRotation(){} // RVA: 0x7ffaaa247aa0
        public void get_AbstractLookAtTargetGroup(){} // RVA: 0x7ffaaa247d70
        public void get_LookAtTargetGroup(){} // RVA: 0x7ffaaa247da0
        public void get_LookAtTargetPosition(){} // RVA: 0x7ffaaa247e40
        public void get_LookAtTargetRotation(){} // RVA: 0x7ffaaa248140
        public void get_VcamState(){} // RVA: 0x7ffaaa248410
        public void get_IsValid(){} // RVA: 0x7ffaa864a040
        public void PrePipelineMutateCameraState(){} // RVA: 0x7ffaa8932310
        public void get_Stage(){} // RVA: 0x7ffaa8649ca0
        public void get_BodyAppliesAfterAim(){} // RVA: 0x7ffaa8932320
        public void MutateCameraState(){} // RVA: 0x7ffaa866daf0
        public void OnTransitionFromCamera(){} // RVA: 0x7ffaa8932320
        public void OnTargetObjectWarped(){} // RVA: 0x7ffaa8932310
        public void ForceCameraPosition(){} // RVA: 0x7ffaa8932310
        public void get_RequiresUserInput(){} // RVA: 0x7ffaa8932320
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        // ── Binary Analysis Named ──
        public void GetMaxDampTime(){} // RVA: 0x7ffaa916f990
    }

    public class CinemachineComposer : CinemachineComponentBase
    {
        public object m_LookaheadSmoothing; // 0x33417360
        public object m_VerticalDamping; // 0x33417360
        public object m_DeadZoneWidth; // 0x33417360
        public object m_SoftZoneHeight; // 0x33417360
        public object m_CenterOnActivate; // 0x33417360
        public object m_LookAtPrevFrame; // 0x33417360
        public object m_Predictor; // 0x33417360
        public object 00; // 0x3024EA20
        public object `Ǐf; // 0x66DE1A7C

        // ── Original Methods ──
        public void get_IsValid(){} // RVA: 0x7ffaaa22ab10
        public void get_Stage(){} // RVA: 0x7ffaa8a24af0
        public void get_TrackedPoint(){} // RVA: 0x7ffaaa22ac30
        public void set_TrackedPoint(){} // RVA: 0x7ffaaa22ac50
        public void OnTargetObjectWarped(){} // RVA: 0x7ffaaa22b130
        public void ForceCameraPosition(){} // RVA: 0x7ffaaa22b330
        public void PrePipelineMutateCameraState(){} // RVA: 0x7ffaaa22b360
        public void MutateCameraState(){} // RVA: 0x7ffaaa22b4a0
        public void get_SoftGuideRect(){} // RVA: 0x7ffaaa22c250
        public void set_SoftGuideRect(){} // RVA: 0x7ffaaa22c2a0
        public void get_HardGuideRect(){} // RVA: 0x7ffaaa22c360
        public void set_HardGuideRect(){} // RVA: 0x7ffaaa22c3e0
        public void RotateToScreenBounds(){} // RVA: 0x7ffaaa22c450
        public void ClampVerticalBounds(){} // RVA: 0x7ffaaa22c730
        public void .ctor(){} // RVA: 0x7ffaaa22ca30
        // ── Binary Analysis Named ──
        public void GetLookAtPointAndSetTrackedPoint(){} // RVA: 0x7ffaaa22ac60
        public void GetMaxDampTime(){} // RVA: 0x7ffaaa22b350
    }

    public class CinemachineConfiner : CinemachineExtension
    {
        public object m_BoundingShape2D; // 0x339DC030
        public object m_Damping; // 0x339DC030
        public object 00; // 0x34B35388

        // ── Original Methods ──
        public void CameraWasDisplaced(){} // RVA: 0x7ffaaa208c50
        public void OnValidate(){} // RVA: 0x7ffaaa208d20
        public void ConnectToVcam(){} // RVA: 0x7ffaaa208d30
        public void get_IsValid(){} // RVA: 0x7ffaaa208d40
        public void PostPipelineStageCallback(){} // RVA: 0x7ffaaa208fd0
        public void InvalidatePathCache(){} // RVA: 0x7ffaaa2092b0
        public void ValidatePathCache(){} // RVA: 0x7ffaaa209360
        public void ConfinePoint(){} // RVA: 0x7ffaaa209ca0
        public void ConfineScreenEdges(){} // RVA: 0x7ffaaa20a2e0
        public void .ctor(){} // RVA: 0x7ffaaa20ab10
        // ── Binary Analysis Named ──
        public void GetCameraDisplacementDistance(){} // RVA: 0x7ffaaa208cc0
        public void GetMaxDampTime(){} // RVA: 0x7ffaa8dbada0
    }

    public class CinemachineConfiner2D : CinemachineExtension
    {
        public object m_MaxWindowSize; // 0x33CA8860
        public object k_cornerAngleTreshold; // 0x33CA8860
        public object 00; // 0x34B07810

        // ── Original Methods ──
        public void InvalidateCache(){} // RVA: 0x7ffaaa20ab60
        public void ValidateCache(){} // RVA: 0x7ffaaa20ab70
        public void PostPipelineStageCallback(){} // RVA: 0x7ffaaa20abc0
        public void CalculateHalfFrustumHeight(){} // RVA: 0x7ffaaa20b3f0
        public void OnValidate(){} // RVA: 0x7ffaaa20b4a0
        public void Reset(){} // RVA: 0x7ffaaa20b4c0
        public void .ctor(){} // RVA: 0x7ffaaa20b4d0
    }

    public class CinemachineCore : Object
    {
        public object sShowHiddenObjects; // 0x3171D1F0
        public object CurrentTimeOverride; // 0x3171D1F0
        public object CameraCutEvent; // 0x3171D1F0
        public object mActiveCameras; // 0x3171D1F0
        public object mAllCameras; // 0x3171D1F0
        public object s_FixedFrameCount; // 0x3171D1F0
        public object 00; // 0x34B46040

        // ── Original Methods ──
        public void get_Instance(){} // RVA: 0x7ffaaa2485c0
        public void get_DeltaTime(){} // RVA: 0x7ffaaa2486f0
        public void get_CurrentTime(){} // RVA: 0x7ffaaa2487b0
        public void get_BrainCount(){} // RVA: 0x7ffaaa248870
        public void AddActiveBrain(){} // RVA: 0x7ffaaa248940
        public void RemoveActiveBrain(){} // RVA: 0x7ffaaa2489e0
        public void get_VirtualCameraCount(){} // RVA: 0x7ffaaa248a40
        public void AddActiveCamera(){} // RVA: 0x7ffaaa248c50
        public void RemoveActiveCamera(){} // RVA: 0x7ffaaa248cc0
        public void CameraDestroyed(){} // RVA: 0x7ffaaa248d40
        public void CameraEnabled(){} // RVA: 0x7ffaaa248e30
        public void CameraDisabled(){} // RVA: 0x7ffaaa249090
        public void UpdateAllActiveVirtualCameras(){} // RVA: 0x7ffaaa2492c0
        public void UpdateVirtualCamera(){} // RVA: 0x7ffaaa2499d0
        public void InitializeModule(){} // RVA: 0x7ffaaa249ec0
        public void IsLive(){} // RVA: 0x7ffaaa24a370
        public void IsLiveInBlend(){} // RVA: 0x7ffaaa24a4d0
        public void GenerateCameraActivationEvent(){} // RVA: 0x7ffaaa24a630
        public void GenerateCameraCutEvent(){} // RVA: 0x7ffaaa24a810
        public void FindPotentialTargetBrain(){} // RVA: 0x7ffaaa24aa60
        public void OnTargetObjectWarped(){} // RVA: 0x7ffaaa24af30
        public void .ctor(){} // RVA: 0x7ffaaa24b000
        public void .cctor(){} // RVA: 0x7ffaaa24b1f0
        // ── Binary Analysis Named ──
        public void GetActiveBrain(){} // RVA: 0x7ffaaa2488c0
        public void GetVirtualCamera(){} // RVA: 0x7ffaaa248a90
        public void GetUpdateTarget(){} // RVA: 0x7ffaaa249fc0
        public void GetVcamUpdateStatus(){} // RVA: 0x7ffaaa24a2e0
    }

    public class CinemachineDollyCart : MonoBehaviour
    {
        public object m_PositionUnits; // 0x33995800
        public object 00; // 0x40000B8

        // ── Original Methods ──
        public void FixedUpdate(){} // RVA: 0x7ffaaa20c7d0
        public void Update(){} // RVA: 0x7ffaaa20c860
        public void LateUpdate(){} // RVA: 0x7ffaaa20c970
        public void .ctor(){} // RVA: 0x7ffaaa20cca0
        // ── Binary Analysis Named ──
        public void SetCartPosition(){} // RVA: 0x7ffaaa20ca90
    }

    public class CinemachineEmbeddedAssetPropertyAttribute : PropertyAttribute
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa89fc5f0
    }

    public class CinemachineExtension : MonoBehaviour
    {
        public object mExtraState; // 0x3171CD10
        public object VirtualCamera; // 0x170000AB

        // ── Original Methods ──
        public void get_VirtualCamera(){} // RVA: 0x7ffaaa24b990
        public void Awake(){} // RVA: 0x7ffaaa24bad0
        public void OnEnable(){} // RVA: 0x7ffaa8932310
        public void OnDestroy(){} // RVA: 0x7ffaaa24baf0
        public void EnsureStarted(){} // RVA: 0x7ffaaa24bad0
        public void ConnectToVcam(){} // RVA: 0x7ffaaa24bb10
        public void PrePipelineMutateCameraStateCallback(){} // RVA: 0x7ffaa8932310
        public void InvokePostPipelineStageCallback(){} // RVA: 0x7ffaaa24bd90
        public void PostPipelineStageCallback(){}
        public void OnTargetObjectWarped(){} // RVA: 0x7ffaa8932310
        public void ForceCameraPosition(){} // RVA: 0x7ffaa8932310
        public void OnTransitionFromCamera(){} // RVA: 0x7ffaa8932320
        public void get_RequiresUserInput(){} // RVA: 0x7ffaa8932320
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        // ── Binary Analysis Named ──
        public void GetMaxDampTime(){} // RVA: 0x7ffaa916f990
        public void GetExtraState(){} // RVA: 0x7ffaa887e5c0
        public void GetAllExtraStates(){} // RVA: 0x7ffaa86491d0
    }

    public class CinemachineExternalCamera : CinemachineVirtualCameraBase
    {
        public object m_State; // 0x337262E0

        // ── Original Methods ──
        public void get_State(){} // RVA: 0x7ffaaa20ccf0
        public void get_LookAt(){} // RVA: 0x7ffaa8f74720
        public void set_LookAt(){} // RVA: 0x7ffaa8d71dc0
        public void get_Follow(){} // RVA: 0x7ffaa8f74750
        public void set_Follow(){} // RVA: 0x7ffaa93e77a0
        public void InternalUpdateCameraState(){} // RVA: 0x7ffaaa20cd90
        public void .ctor(){} // RVA: 0x7ffaaa20d9b0
    }

    public class CinemachineFixedSignal : SignalSourceAsset
    {
        public object m_ZCurve; // 0x339F52E0
        public object SignalDuration; // 0x170000E3

        // ── Original Methods ──
        public void get_SignalDuration(){} // RVA: 0x7ffaaa25dd20
        public void AxisDuration(){} // RVA: 0x7ffaaa25dd80
        public void AxisValue(){} // RVA: 0x7ffaaa25e060
        public void .ctor(){} // RVA: 0x7ffaa8b59ae0
        // ── Binary Analysis Named ──
        public void GetSignal(){} // RVA: 0x7ffaaa25de80
    }

    public class CinemachineFollowZoom : CinemachineExtension
    {
        public object m_MinFOV; // 0x33687030
        public object 00; // 0x34B35C10

        // ── Original Methods ──
        public void OnValidate(){} // RVA: 0x7ffaaa20db80
        public void PostPipelineStageCallback(){} // RVA: 0x7ffaaa20dbe0
        public void .ctor(){} // RVA: 0x7ffaaa20dfd0
        // ── Binary Analysis Named ──
        public void GetMaxDampTime(){} // RVA: 0x7ffaa89fc630
    }

    public class CinemachineFramingTransposer : CinemachineComponentBase
    {
        public object m_LookaheadSmoothing; // 0x335A8B40
        public object m_YDamping; // 0x335A8B40
        public object m_ScreenX; // 0x335A8B40
        public object m_DeadZoneWidth; // 0x335A8B40
        public object m_UnlimitedSoftZone; // 0x335A8B40
        public object m_BiasX; // 0x335A8B40
        public object m_GroupFramingMode; // 0x335A8B40
        public object m_MaxDollyIn; // 0x335A8B40
        public object m_MaximumDistance; // 0x335A8B40
        public object m_MinimumOrthoSize; // 0x335A8B40
        public object kMinimumGroupSize; // 0x335A8B40
        public object _trackedPoint; // 0x335A8B40, was: <TrackedPoint>k__BackingField
        public object m_prevRotation; // 0x335A8B40
        public object value__; // 0x34B3EC80
        public object HorizontalAndVertical; // 0x34B3EC80

        // ── Original Methods ──
        public void get_SoftGuideRect(){} // RVA: 0x7ffaaa22d900
        public void set_SoftGuideRect(){} // RVA: 0x7ffaaa22d950
        public void get_HardGuideRect(){} // RVA: 0x7ffaaa22da10
        public void set_HardGuideRect(){} // RVA: 0x7ffaaa22da90
        public void OnValidate(){} // RVA: 0x7ffaaa22db00
        public void get_IsValid(){} // RVA: 0x7ffaaa22dbf0
        public void get_Stage(){} // RVA: 0x7ffaa8f22da0
        public void get_BodyAppliesAfterAim(){} // RVA: 0x7ffaa8a17850
        public void get_TrackedPoint(){} // RVA: 0x7ffaaa22dd10
        public void set_TrackedPoint(){} // RVA: 0x7ffaaa22dd30
        public void OnTargetObjectWarped(){} // RVA: 0x7ffaaa22dd50
        public void ForceCameraPosition(){} // RVA: 0x7ffaaa22df10
        public void OnTransitionFromCamera(){} // RVA: 0x7ffaaa22df60
        public void ScreenToOrtho(){} // RVA: 0x7ffaaa22e190
        public void OrthoOffsetToScreenBounds(){} // RVA: 0x7ffaaa22e260
        public void get_LastBounds(){} // RVA: 0x7ffaaa22e370
        public void set_LastBounds(){} // RVA: 0x7ffaaa22e390
        public void get_LastBoundsMatrix(){} // RVA: 0x7ffaaa22e3b0
        public void set_LastBoundsMatrix(){} // RVA: 0x7ffaaa22e3e0
        public void MutateCameraState(){} // RVA: 0x7ffaaa22e410
        public void ComputeGroupBounds(){} // RVA: 0x7ffaaa2301c0
        public void .ctor(){} // RVA: 0x7ffaaa231200
        // ── Binary Analysis Named ──
        public void GetMaxDampTime(){} // RVA: 0x7ffaaa22df40
        public void GetTargetHeight(){} // RVA: 0x7ffaaa22ffc0
        public void GetScreenSpaceGroupBoundingBox(){} // RVA: 0x7ffaaa2309f0
    }

    public class CinemachineFreeLook : CinemachineVirtualCameraBase
    {
        public object m_CommonLens; // 0x33467900
        public object m_LegacyBlendHint; // 0x33467900
        public object m_XAxis; // 0x33467900
        public object m_BindingMode; // 0x33467900
        public object m_LegacyHeadingBias; // 0x33467900
        public object m_State; // 0x33467900
        public object mBlendA; // 0x33467900
        public object DestroyRigOverride; // 0x33467900
        public object m_CachedOrbits; // 0x33467900
        public object m_CachedCtrl1; // 0x33467900
        public object m_InheritPosition; // 0x34B4C2E0
        public object m_SpeedMode; // 0x3370EF90
        public object m_DecelTime; // 0x3370EF90
        public object m_InvertInput; // 0x3370EF90
        public object m_Wrap; // 0x3370EF90

        // ── Original Methods ──
        public void OnValidate(){} // RVA: 0x7ffaaa20e030
        public void get_RigsAreCreated(){} // RVA: 0x7ffaaa20e380
        public void get_RigNames(){} // RVA: 0x7ffaaa20e3a0
        public void OnEnable(){} // RVA: 0x7ffaaa20e460
        public void UpdateInputAxisProvider(){} // RVA: 0x7ffaaa20e680
        public void OnDestroy(){} // RVA: 0x7ffaaa20e840
        public void OnTransformChildrenChanged(){} // RVA: 0x7ffaaa20ea50
        public void Reset(){} // RVA: 0x7ffaaa20eab0
        public void get_PreviousStateIsValid(){} // RVA: 0x7ffaa8b6c110
        public void set_PreviousStateIsValid(){} // RVA: 0x7ffaaa20ead0
        public void get_State(){} // RVA: 0x7ffaaa20ec50
        public void get_LookAt(){} // RVA: 0x7ffaaa1f79e0
        public void set_LookAt(){} // RVA: 0x7ffaa8d71dc0
        public void get_Follow(){} // RVA: 0x7ffaaa1f79f0
        public void set_Follow(){} // RVA: 0x7ffaa899d050
        public void IsLiveChild(){} // RVA: 0x7ffaaa20ecf0
        public void OnTargetObjectWarped(){} // RVA: 0x7ffaaa20ee00
        public void ForceCameraPosition(){} // RVA: 0x7ffaaa20eee0
        public void InternalUpdateCameraState(){} // RVA: 0x7ffaaa20f200
        public void OnTransitionFromCamera(){} // RVA: 0x7ffaaa20fd50
        public void RequiresUserInput(){} // RVA: 0x7ffaa8a17850
        public void SteepestDescent(){} // RVA: 0x7ffaaa2109d0
        public void InvalidateRigCache(){} // RVA: 0x7ffaaa20ea50
        public void DestroyRigs(){} // RVA: 0x7ffaaa210c20
        public void CreateRigs(){} // RVA: 0x7ffaaa211370
        public void UpdateRigCache(){} // RVA: 0x7ffaaa211fe0
        public void LocateExistingRigs(){} // RVA: 0x7ffaaa212570
        public void UpdateXAxisHeading(){} // RVA: 0x7ffaaa212c30
        public void PushSettingsToRigs(){} // RVA: 0x7ffaaa212ef0
        public void CalculateNewState(){} // RVA: 0x7ffaaa2136c0
        public void UpdateCachedSpline(){} // RVA: 0x7ffaaa213c20
        public void OnBeforeSerialize(){} // RVA: 0x7ffaaa214280
        public void .ctor(){} // RVA: 0x7ffaaa214360
        public void <SteepestDescent>g__AngleFunction|47_0(){} // RVA: 0x7ffaaa214a30
        public void <SteepestDescent>g__SlopeOfAngleFunction|47_1(){} // RVA: 0x7ffaaa214b00
        public void <SteepestDescent>g__InitialGuess|47_2(){} // RVA: 0x7ffaaa214b70
        public void <SteepestDescent>g__ChooseBestAngle|47_3(){} // RVA: 0x7ffaaa214c80
        // ── Binary Analysis Named ──
        public void GetRig(){} // RVA: 0x7ffaaa20e320
        public void GetYAxisClosestValue(){} // RVA: 0x7ffaaa210260
        public void GetYAxisValue(){} // RVA: 0x7ffaaa213690
        public void GetLocalPositionForCameraFromInput(){} // RVA: 0x7ffaaa213970
    }

    public class CinemachineGroupComposer : CinemachineComposer
    {
        public object m_FrameDamping; // 0x33417130
        public object m_MaxDollyOut; // 0x33417130
        public object m_MinimumFOV; // 0x33417130
        public object m_MaximumOrthoSize; // 0x33417130
        public object _lastBounds; // 0x33417130, was: <LastBounds>k__BackingField
        public object 00; // 0x34B3EF30

        // ── Original Methods ──
        public void OnValidate(){} // RVA: 0x7ffaaa2313b0
        public void get_LastBounds(){} // RVA: 0x7ffaaa231480
        public void set_LastBounds(){} // RVA: 0x7ffaaa2314a0
        public void get_LastBoundsMatrix(){} // RVA: 0x7ffaaa2314c0
        public void set_LastBoundsMatrix(){} // RVA: 0x7ffaaa2314f0
        public void MutateCameraState(){} // RVA: 0x7ffaaa231540
        public void .ctor(){} // RVA: 0x7ffaaa232e80
        // ── Binary Analysis Named ──
        public void GetMaxDampTime(){} // RVA: 0x7ffaaa231520
        public void GetTargetHeight(){} // RVA: 0x7ffaaa2326b0
        public void GetScreenSpaceGroupBoundingBox(){} // RVA: 0x7ffaaa2328f0
    }

    public class CinemachineHardLockToTarget : CinemachineComponentBase
    {
        // ── Original Methods ──
        public void get_IsValid(){} // RVA: 0x7ffaaa232f00
        public void get_Stage(){} // RVA: 0x7ffaa8f22da0
        public void MutateCameraState(){} // RVA: 0x7ffaaa233020
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        // ── Binary Analysis Named ──
        public void GetMaxDampTime(){} // RVA: 0x7ffaa8a11210
    }

    public class CinemachineHardLookAt : CinemachineComponentBase
    {
        // ── Original Methods ──
        public void get_IsValid(){} // RVA: 0x7ffaaa2331f0
        public void get_Stage(){} // RVA: 0x7ffaa8a24af0
        public void MutateCameraState(){} // RVA: 0x7ffaaa233310
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class CinemachineImpulseChannelPropertyAttribute : PropertyAttribute
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class CinemachineImpulseDefinition : Object
    {
        public object m_CustomImpulseShape; // 0x338B7250
        public object m_DissipationRate; // 0x338B7250
        public object m_FrequencyGain; // 0x338B7250
        public object m_TimeEnvelope; // 0x338B7250
        public object m_DissipationMode; // 0x338B7250
        public object sStandardShapes; // 0x338B7250
        public object m_AttackTime; // 0x34B541E0
        public object m_ScaleWithImpact; // 0x34B541E0
        public object 00; // 0x34B4F2A0

        // ── Original Methods ──
        public void OnValidate(){} // RVA: 0x7ffaaa25e0e0
        public void CreateStandardShapes(){} // RVA: 0x7ffaaa25e1d0
        public void get_ImpulseCurve(){} // RVA: 0x7ffaaa25ee50
        public void CreateEvent(){} // RVA: 0x7ffaaa25ef60
        public void CreateAndReturnEvent(){} // RVA: 0x7ffaaa25efa0
        public void LegacyCreateAndReturnEvent(){} // RVA: 0x7ffaaa25f1f0
        public void .ctor(){} // RVA: 0x7ffaaa25f5e0
        // ── Binary Analysis Named ──
        public void GetStandardCurve(){} // RVA: 0x7ffaaa25edd0
    }

    public class CinemachineImpulseDefinitionPropertyAttribute : PropertyAttribute
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class CinemachineImpulseEnvelopePropertyAttribute : PropertyAttribute
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class CinemachineImpulseListener : CinemachineExtension
    {
        public object m_Gain; // 0x33311D40
        public object m_ReactionSettings; // 0x33311D40

        // ── Original Methods ──
        public void Reset(){} // RVA: 0x7ffaaa25fff0
        public void PostPipelineStageCallback(){} // RVA: 0x7ffaaa2600b0
        public void .ctor(){} // RVA: 0x7ffaaa260690
    }

    public class CinemachineImpulseManager : Object
    {
        public object m_ExpiredEvents; // 0x33C4EFF0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void get_Instance(){} // RVA: 0x7ffaaa260da0
        public void InitializeModule(){} // RVA: 0x7ffaaa260e60
        public void EvaluateDissipationScale(){} // RVA: 0x7ffaaa260f90
        public void get_CurrentTime(){} // RVA: 0x7ffaaa2615a0
        public void NewImpulseEvent(){} // RVA: 0x7ffaaa261640
        public void AddImpulseEvent(){} // RVA: 0x7ffaaa261740
        public void Clear(){} // RVA: 0x7ffaaa261840
        // ── Binary Analysis Named ──
        public void GetImpulseAt(){} // RVA: 0x7ffaaa261090
    }

    public class CinemachineImpulseSource : MonoBehaviour
    {
        public object m_LayerMask; // 0x33B05DF0

        // ── Original Methods ──
        public void OnValidate(){} // RVA: 0x7ffaaa2626e0
        public void Reset(){} // RVA: 0x7ffaaa2627f0
        public void GenerateImpulseAtPositionWithVelocity(){} // RVA: 0x7ffaaa2629e0
        public void GenerateImpulseWithVelocity(){} // RVA: 0x7ffaaa262a30
        public void GenerateImpulseWithForce(){} // RVA: 0x7ffaaa262b50
        public void GenerateImpulse(){} // RVA: 0x7ffaaa262b50
        public void GenerateImpulseAt(){} // RVA: 0x7ffaaa2629e0
        public void GenerateImpulse(){} // RVA: 0x7ffaaa262b50
        public void GenerateImpulse(){} // RVA: 0x7ffaaa262b50
        public void .ctor(){} // RVA: 0x7ffaaa262cf0
    }

    public class CinemachineIndependentImpulseListener : MonoBehaviour
    {
        public object m_ChannelMask; // 0x333FC5D0
        public object m_UseLocalSpace; // 0x333FC5D0
        public object .ctor; // 0xB3F6FFF0

        // ── Original Methods ──
        public void Reset(){} // RVA: 0x7ffaaa262e10
        public void OnEnable(){} // RVA: 0x7ffaaa262ec0
        public void Update(){} // RVA: 0x7ffaaa262f50
        public void LateUpdate(){} // RVA: 0x7ffaaa2633c0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class CinemachineInputAxisDriver : ValueType
    {
        public object decelTime; // 0x33815C50
        public object mCurrentSpeed; // 0x33815C50
        public object 00; // 0x34B67220

        // ── Original Methods ──
        public void Validate(){} // RVA: 0x7ffaaa23f370
        public void Update(){} // RVA: 0x7ffaaa24c140
        public void Update(){} // RVA: 0x7ffaaa24c140
        public void ClampValue(){} // RVA: 0x7ffaaa24c1b0
    }

    public class CinemachineInputProvider : MonoBehaviour
    {
        public object XYAxis; // 0x33CECD40
        public object m_cachedActions; // 0x33CECD40
        public object 00; // 0x30B1B5D0

        // ── Original Methods ──
        public void ResolveForPlayer(){} // RVA: 0x7ffaaa25a310
        public void OnDisable(){} // RVA: 0x7ffaa95e7440
        public void .ctor(){} // RVA: 0x7ffaaa25aa70
        public void <ResolveForPlayer>g__GetFirstMatch|7_0(){} // RVA: 0x7ffaaa25aac0
        // ── Binary Analysis Named ──
        public void GetAxisValue(){} // RVA: 0x7ffaaa25a1f0
    }

    public class CinemachineMixingCamera : CinemachineVirtualCameraBase
    {
        public object m_Weight1; // 0x335AB090
        public object m_Weight4; // 0x335AB090
        public object m_Weight7; // 0x335AB090
        public object _lookAt; // 0x335AB090, was: <LookAt>k__BackingField
        public object m_indexMap; // 0x335AB090
        public object LiveChild; // 0x17000029
        public object State; // 0x1700002A
        public object LookAt; // 0x1700002B
        public object Follow; // 0x1700002C
        public object ChildCameras; // 0x1700002D

        // ── Original Methods ──
        public void get_LiveChild(){} // RVA: 0x7ffaa8f6f0f0
        public void set_LiveChild(){} // RVA: 0x7ffaa93d9af0
        public void get_State(){} // RVA: 0x7ffaaa215760
        public void get_LookAt(){} // RVA: 0x7ffaa8f78130
        public void set_LookAt(){} // RVA: 0x7ffaa93e4fb0
        public void get_Follow(){} // RVA: 0x7ffaa8f73670
        public void set_Follow(){} // RVA: 0x7ffaa93e9360
        public void OnTargetObjectWarped(){} // RVA: 0x7ffaaa215800
        public void ForceCameraPosition(){} // RVA: 0x7ffaaa2158e0
        public void OnEnable(){} // RVA: 0x7ffaaa215a70
        public void OnTransformChildrenChanged(){} // RVA: 0x7ffaaa215a90
        public void OnValidate(){} // RVA: 0x7ffaaa215aa0
        public void IsLiveChild(){} // RVA: 0x7ffaaa215b50
        public void get_ChildCameras(){} // RVA: 0x7ffaaa215bf0
        public void InvalidateListOfChildren(){} // RVA: 0x7ffaaa215c10
        public void ValidateListOfChildren(){} // RVA: 0x7ffaaa215d30
        public void OnTransitionFromCamera(){} // RVA: 0x7ffaaa2161d0
        public void InternalUpdateCameraState(){} // RVA: 0x7ffaaa216330
        public void .ctor(){} // RVA: 0x7ffaaa216a30
        // ── Binary Analysis Named ──
        public void GetWeight(){} // RVA: 0x7ffaaa215150
        public void SetWeight(){} // RVA: 0x7ffaaa215490
        public void GetWeight(){} // RVA: 0x7ffaaa215150
        public void SetWeight(){} // RVA: 0x7ffaaa215490
    }

    public class CinemachineOrbitalTransposer : CinemachineTransposer
    {
        public object m_XAxis; // 0x3395D850
        public object m_LegacyHeadingBias; // 0x3395D850
        public object m_LastTargetPosition; // 0x3395D850
        public object m_PreviousTarget; // 0x3395D850
        public object 00; // 0x3024EA20
        public object `Ǐf; // 0x66DE1A7C
        public object 00; // 0x4000202

        // ── Original Methods ──
        public void OnValidate(){} // RVA: 0x7ffaaa2336d0
        public void UpdateHeading(){} // RVA: 0x7ffaaa233900
        public void UpdateHeading(){} // RVA: 0x7ffaaa233900
        public void OnEnable(){} // RVA: 0x7ffaaa233aa0
        public void UpdateInputAxisProvider(){} // RVA: 0x7ffaaa233cc0
        public void OnTargetObjectWarped(){} // RVA: 0x7ffaaa233e30
        public void ForceCameraPosition(){} // RVA: 0x7ffaaa234130
        public void OnTransitionFromCamera(){} // RVA: 0x7ffaaa234290
        public void MutateCameraState(){} // RVA: 0x7ffaaa234c40
        public void get_RequiresUserInput(){} // RVA: 0x7ffaa8a17850
        public void .ctor(){} // RVA: 0x7ffaaa2369a0
        // ── Binary Analysis Named ──
        public void GetAxisClosestValue(){} // RVA: 0x7ffaaa2344d0
        public void GetTargetCameraPosition(){} // RVA: 0x7ffaaa235be0
        public void GetTargetHeading(){} // RVA: 0x7ffaaa236030
    }

    public class CinemachinePOV : CinemachineComponentBase
    {
        public object m_VerticalRecentering; // 0x33631D30
        public object m_ApplyBeforeBody; // 0x33631D30

        // ── Original Methods ──
        public void get_IsValid(){} // RVA: 0x7ffaa8998de0
        public void get_Stage(){} // RVA: 0x7ffaa8a24af0
        public void OnValidate(){} // RVA: 0x7ffaaa237190
        public void OnEnable(){} // RVA: 0x7ffaaa2372a0
        public void UpdateInputAxisProvider(){} // RVA: 0x7ffaaa2372b0
        public void PrePipelineMutateCameraState(){} // RVA: 0x7ffaa8932310
        public void MutateCameraState(){} // RVA: 0x7ffaaa237580
        public void NormalizeAngle(){} // RVA: 0x7ffaaa2381f0
        public void ForceCameraPosition(){} // RVA: 0x7ffaaa238220
        public void OnTransitionFromCamera(){} // RVA: 0x7ffaaa238240
        public void get_RequiresUserInput(){} // RVA: 0x7ffaa8a17850
        public void .ctor(){} // RVA: 0x7ffaaa238fa0
        // ── Binary Analysis Named ──
        public void GetRecenterTarget(){} // RVA: 0x7ffaaa237d40
        public void SetAxesForRotation(){} // RVA: 0x7ffaaa2384b0
    }

    public class CinemachinePath : CinemachinePathBase
    {
        // ── Original Methods ──
        public void get_MinPos(){} // RVA: 0x7ffaa916f990
        public void get_MaxPos(){} // RVA: 0x7ffaaa216c50
        public void get_Looped(){} // RVA: 0x7ffaa89ec8e0
        public void Reset(){} // RVA: 0x7ffaaa216c90
        public void OnValidate(){} // RVA: 0x7ffaaa216e50
        public void get_DistanceCacheSampleStepsPerSegment(){} // RVA: 0x7ffaa8aeced0
        public void EvaluateLocalPosition(){} // RVA: 0x7ffaaa216f60
        public void EvaluateLocalTangent(){} // RVA: 0x7ffaaa2172b0
        public void EvaluateLocalOrientation(){} // RVA: 0x7ffaaa217510
        public void RollAroundForward(){} // RVA: 0x7ffaaa217a60
        public void .ctor(){} // RVA: 0x7ffaaa217ab0
        // ── Binary Analysis Named ──
        public void GetBoundingIndices(){} // RVA: 0x7ffaaa216e70
        public void GetRoll(){} // RVA: 0x7ffaaa217930
    }

    public class CinemachinePathBase : MonoBehaviour
    {
        public object m_DistanceToPos; // 0x33560030
        public object m_PathLength; // 0x33560030

        // ── Original Methods ──
        public void get_MinPos(){} // RVA: 0x7ffaa865dbc0
        public void get_MaxPos(){} // RVA: 0x7ffaa865dbc0
        public void get_Looped(){} // RVA: 0x7ffaa864a040
        public void StandardizePos(){} // RVA: 0x7ffaaa24c220
        public void EvaluatePosition(){} // RVA: 0x7ffaaa24c310
        public void EvaluateTangent(){} // RVA: 0x7ffaaa24c430
        public void EvaluateOrientation(){} // RVA: 0x7ffaaa24c550
        public void EvaluateLocalPosition(){}
        public void EvaluateLocalTangent(){}
        public void EvaluateLocalOrientation(){}
        public void FindClosestPoint(){} // RVA: 0x7ffaaa24c7c0
        public void MinUnit(){} // RVA: 0x7ffaaa24cc10
        public void MaxUnit(){} // RVA: 0x7ffaaa24cc40
        public void StandardizeUnit(){} // RVA: 0x7ffaaa24cc70
        public void EvaluatePositionAtUnit(){} // RVA: 0x7ffaaa24cd20
        public void EvaluateTangentAtUnit(){} // RVA: 0x7ffaaa24cd80
        public void EvaluateOrientationAtUnit(){} // RVA: 0x7ffaaa24cde0
        public void get_DistanceCacheSampleStepsPerSegment(){} // RVA: 0x7ffaa8649ca0
        public void InvalidateDistanceCache(){} // RVA: 0x7ffaaa24ce40
        public void DistanceCacheIsValid(){} // RVA: 0x7ffaaa24cef0
        public void get_PathLength(){} // RVA: 0x7ffaaa24cf90
        public void StandardizePathDistance(){} // RVA: 0x7ffaaa24d000
        public void ToNativePathUnits(){} // RVA: 0x7ffaaa24d0c0
        public void FromPathNativeUnits(){} // RVA: 0x7ffaaa24d240
        public void ResamplePath(){} // RVA: 0x7ffaaa24d360
        public void .ctor(){} // RVA: 0x7ffaaa24d810
    }

    public class CinemachinePipeline : MonoBehaviour
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class CinemachinePixelPerfect : MonoBehaviour
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class CinemachineSameAsFollowTarget : CinemachineComponentBase
    {
        // ── Original Methods ──
        public void get_IsValid(){} // RVA: 0x7ffaaa239300
        public void get_Stage(){} // RVA: 0x7ffaa8a24af0
        public void MutateCameraState(){} // RVA: 0x7ffaaa239420
        public void .ctor(){} // RVA: 0x7ffaaa239760
        // ── Binary Analysis Named ──
        public void GetMaxDampTime(){} // RVA: 0x7ffaa8a11210
    }

    public class CinemachineSmoothPath : CinemachinePathBase
    {
        public object m_ControlPoints1; // 0x339D4970

        // ── Original Methods ──
        public void get_MinPos(){} // RVA: 0x7ffaa916f990
        public void get_MaxPos(){} // RVA: 0x7ffaaa216c50
        public void get_Looped(){} // RVA: 0x7ffaa89ec8e0
        public void get_DistanceCacheSampleStepsPerSegment(){} // RVA: 0x7ffaa8aeced0
        public void OnValidate(){} // RVA: 0x7ffaaa216e50
        public void Reset(){} // RVA: 0x7ffaaa217c50
        public void InvalidateDistanceCache(){} // RVA: 0x7ffaaa217e00
        public void UpdateControlPoints(){} // RVA: 0x7ffaaa217f50
        public void EvaluateLocalPosition(){} // RVA: 0x7ffaaa2183a0
        public void EvaluateLocalTangent(){} // RVA: 0x7ffaaa218730
        public void EvaluateLocalOrientation(){} // RVA: 0x7ffaaa218a00
        public void RollAroundForward(){} // RVA: 0x7ffaaa217a60
        public void .ctor(){} // RVA: 0x7ffaaa218f10
        // ── Binary Analysis Named ──
        public void GetBoundingIndices(){} // RVA: 0x7ffaaa2182c0
    }

    public class CinemachineStateDrivenCamera : CinemachineVirtualCameraBase
    {
        public object m_AnimatedTarget; // 0x3346F260
        public object m_ChildCameras; // 0x3346F260
        public object m_CustomBlends; // 0x3346F260
        public object m_TransitioningFrom; // 0x3346F260
        public object mActivationTime; // 0x3346F260
        public object mPendingInstruction; // 0x3346F260
        public object mStateParentLookup; // 0x3346F260

        // ── Original Methods ──
        public void get_Description(){} // RVA: 0x7ffaaa219040
        public void get_LiveChild(){} // RVA: 0x7ffaa8d57210
        public void set_LiveChild(){} // RVA: 0x7ffaa8ecd8e0
        public void IsLiveChild(){} // RVA: 0x7ffaaa219180
        public void get_State(){} // RVA: 0x7ffaaa2191b0
        public void get_LookAt(){} // RVA: 0x7ffaaa1f79e0
        public void set_LookAt(){} // RVA: 0x7ffaa8d71dc0
        public void get_Follow(){} // RVA: 0x7ffaaa1f79f0
        public void set_Follow(){} // RVA: 0x7ffaa899d050
        public void OnTargetObjectWarped(){} // RVA: 0x7ffaaa219250
        public void ForceCameraPosition(){} // RVA: 0x7ffaaa219330
        public void OnTransitionFromCamera(){} // RVA: 0x7ffaaa2194c0
        public void InternalUpdateCameraState(){} // RVA: 0x7ffaaa2195d0
        public void OnEnable(){} // RVA: 0x7ffaaa219ec0
        public void OnDisable(){} // RVA: 0x7ffaaa21a1d0
        public void OnTransformChildrenChanged(){} // RVA: 0x7ffaaa21a350
        public void OnGuiHandler(){} // RVA: 0x7ffaaa21a360
        public void get_ChildCameras(){} // RVA: 0x7ffaaa21a4d0
        public void get_IsBlending(){} // RVA: 0x7ffaaa21a4f0
        public void get_ActiveBlend(){} // RVA: 0x7ffaa8f6ff20
        public void CreateFakeHash(){} // RVA: 0x7ffaaa21a500
        public void LookupFakeHash(){} // RVA: 0x7ffaaa21a5c0
        public void InvalidateListOfChildren(){} // RVA: 0x7ffaaa21a970
        public void UpdateListOfChildren(){} // RVA: 0x7ffaaa21aa30
        public void ValidateInstructions(){} // RVA: 0x7ffaaa21add0
        public void ChooseCurrentCamera(){} // RVA: 0x7ffaaa21b410
        public void LookupBlend(){} // RVA: 0x7ffaaa21be40
        public void .ctor(){} // RVA: 0x7ffaaa21c0b0
        // ── Binary Analysis Named ──
        public void GetClipHash(){} // RVA: 0x7ffaaa21bcb0
    }

    public class CinemachineStoryboard : CinemachineExtension
    {
        public object m_Image; // 0x338CC530
        public object m_Center; // 0x338CC530
        public object m_SyncScale; // 0x338CC530
        public object m_RenderMode; // 0x338CC530
        public object mCanvasInfo; // 0x338CC530
        public object CanvasName; // 0x1700003F
        public object 2;Z;

        // ── Original Methods ──
        public void PostPipelineStageCallback(){} // RVA: 0x7ffaaa21c3f0
        public void UpdateRenderCanvas(){} // RVA: 0x7ffaaa21c600
        public void ConnectToVcam(){} // RVA: 0x7ffaaa21c850
        public void get_CanvasName(){} // RVA: 0x7ffaaa21ca20
        public void CameraUpdatedCallback(){} // RVA: 0x7ffaaa21cb50
        public void LocateMyCanvas(){} // RVA: 0x7ffaaa21cef0
        public void CreateCanvas(){} // RVA: 0x7ffaaa21d810
        public void DestroyCanvas(){} // RVA: 0x7ffaaa21e340
        public void PlaceImage(){} // RVA: 0x7ffaaa21e6c0
        public void StaticBlendingHandler(){} // RVA: 0x7ffaaa21f2f0
        public void InitializeModule(){} // RVA: 0x7ffaaa21f6d0
        public void .ctor(){} // RVA: 0x7ffaaa21f840
    }

    public class CinemachineTargetGroup : MonoBehaviour
    {
        public object m_UpdateMethod; // 0x33C2F200
        public object m_WeightSum; // 0x33C2F200
        public object m_BoundingSphere; // 0x33C2F200
        public object m_MemberValidity; // 0x33C2F200

        // ── Original Methods ──
        public void OnValidate(){} // RVA: 0x7ffaaa21fa10
        public void Reset(){} // RVA: 0x7ffaaa21fab0
        public void get_Transform(){} // RVA: 0x7ffaa8de7a30
        public void get_BoundingBox(){} // RVA: 0x7ffaaa21fb40
        public void set_BoundingBox(){} // RVA: 0x7ffaaa21fbd0
        public void get_Sphere(){} // RVA: 0x7ffaaa21fbf0
        public void set_Sphere(){} // RVA: 0x7ffaa8a42dc0
        public void get_IsEmpty(){} // RVA: 0x7ffaaa21fc70
        public void AddMember(){} // RVA: 0x7ffaaa21fd10
        public void RemoveMember(){} // RVA: 0x7ffaaa21fff0
        public void FindMember(){} // RVA: 0x7ffaaa220300
        public void get_CachedCountIsValid(){} // RVA: 0x7ffaaa220e30
        public void IndexIsValid(){} // RVA: 0x7ffaaa220ea0
        public void WeightedMemberBoundsForValidMember(){} // RVA: 0x7ffaaa220ec0
        public void UpdateMemberValidity(){} // RVA: 0x7ffaaa2213d0
        public void CalculateAveragePosition(){} // RVA: 0x7ffaaa221760
        public void CalculateBoundingBox(){} // RVA: 0x7ffaaa2219f0
        public void CalculateBoundingSphere(){} // RVA: 0x7ffaaa221f60
        public void CalculateAverageOrientation(){} // RVA: 0x7ffaaa222360
        public void FixedUpdate(){} // RVA: 0x7ffaaa222b00
        public void Update(){} // RVA: 0x7ffaaa222b10
        public void LateUpdate(){} // RVA: 0x7ffaaa222bb0
        public void .ctor(){} // RVA: 0x7ffaaa223900
        // ── Binary Analysis Named ──
        public void GetWeightedBoundsForMember(){} // RVA: 0x7ffaaa220490
        public void GetViewSpaceBoundingBox(){} // RVA: 0x7ffaaa220670
        public void DoUpdate(){} // RVA: 0x7ffaaa221080
        public void GetViewSpaceAngularBounds(){} // RVA: 0x7ffaaa222bc0
    }

    public class CinemachineTrackedDolly : CinemachineComponentBase
    {
        public object m_PositionUnits; // 0x33665270
        public object m_YDamping; // 0x33665270
        public object m_PitchDamping; // 0x33665270
        public object m_AutoDolly; // 0x33665270
        public object m_PreviousCameraPosition; // 0x33665270
        public object IsValid; // 0x17000069
        public object Stage; // 0x1700006A
        public object AngularDamping; // 0x1700006B

        // ── Original Methods ──
        public void get_IsValid(){} // RVA: 0x7ffaaa2397e0
        public void get_Stage(){} // RVA: 0x7ffaa8f22da0
        public void MutateCameraState(){} // RVA: 0x7ffaaa2399b0
        public void get_AngularDamping(){} // RVA: 0x7ffaaa23b320
        public void .ctor(){} // RVA: 0x7ffaaa23b3d0
        // ── Binary Analysis Named ──
        public void GetMaxDampTime(){} // RVA: 0x7ffaaa239900
        public void GetCameraOrientationAtPathPoint(){} // RVA: 0x7ffaaa23ac40
    }

    public class CinemachineTransposer : CinemachineComponentBase
    {
        public object m_XDamping; // 0x3395DA90
        public object m_AngularDampingMode; // 0x3395DA90
        public object m_RollDamping; // 0x3395DA90
        public object m_PreviousTargetPosition; // 0x3395DA90
        public object m_PreviousOffset; // 0x3395DA90

        // ── Original Methods ──
        public void OnValidate(){} // RVA: 0x7ffaaa23b530
        public void get_HideOffsetInInspector(){} // RVA: 0x7ffaa8b6c110
        public void set_HideOffsetInInspector(){} // RVA: 0x7ffaa92bb760
        public void get_EffectiveOffset(){} // RVA: 0x7ffaaa23b580
        public void get_IsValid(){} // RVA: 0x7ffaaa23b5c0
        public void get_Stage(){} // RVA: 0x7ffaa8f22da0
        public void MutateCameraState(){} // RVA: 0x7ffaaa23b770
        public void OnTargetObjectWarped(){} // RVA: 0x7ffaaa23be50
        public void ForceCameraPosition(){} // RVA: 0x7ffaaa23bfc0
        public void InitPrevFrameStateInfo(){} // RVA: 0x7ffaaa23c300
        public void TrackTarget(){} // RVA: 0x7ffaaa23c560
        public void get_Damping(){} // RVA: 0x7ffaaa23dc50
        public void get_AngularDamping(){} // RVA: 0x7ffaaa23dc90
        public void .ctor(){} // RVA: 0x7ffaaa23e6f0
        // ── Binary Analysis Named ──
        public void GetMaxDampTime(){} // RVA: 0x7ffaaa23b6e0
        public void GetOffsetForMinimumTargetDistance(){} // RVA: 0x7ffaaa23d6b0
        public void GetTargetCameraPosition(){} // RVA: 0x7ffaaa23dd70
        public void GetReferenceOrientation(){} // RVA: 0x7ffaaa23e070
    }

    public class CinemachineTriggerAction : MonoBehaviour
    {
        public object m_WithoutTag; // 0x33C2C3F0
        public object m_OnObjectEnter; // 0x33C2C3F0
        public object 8؏f; // 0x6734AB6C
        public object 00; // 0x400039C
        public object 8؏f; // 0x6734AB8A

        // ── Original Methods ──
        public void Filter(){} // RVA: 0x7ffaaa25af40
        public void InternalDoTriggerEnter(){} // RVA: 0x7ffaaa25b060
        public void InternalDoTriggerExit(){} // RVA: 0x7ffaaa25b1f0
        public void OnTriggerEnter(){} // RVA: 0x7ffaaa25b2d0
        public void OnTriggerExit(){} // RVA: 0x7ffaaa25b350
        public void OnCollisionEnter(){} // RVA: 0x7ffaaa25b3d0
        public void OnCollisionExit(){} // RVA: 0x7ffaaa25b410
        public void OnTriggerEnter2D(){} // RVA: 0x7ffaaa25b2d0
        public void OnTriggerExit2D(){} // RVA: 0x7ffaaa25b350
        public void OnCollisionEnter2D(){} // RVA: 0x7ffaaa25b450
        public void OnCollisionExit2D(){} // RVA: 0x7ffaaa25b490
        public void OnEnable(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaaa25b4d0
    }

    public class CinemachineVirtualCamera : CinemachineVirtualCameraBase
    {
        public object m_Lens; // 0x3171D370
        public object PipelineName; // 0x3171D370
        public object m_State; // 0x3171D370
        public object mCachedLookAtTarget; // 0x3171D370
        public object 00; // 0x34B3E1E0
        public object 00; // 0x4000297

        // ── Original Methods ──
        public void get_State(){} // RVA: 0x7ffaaa2191b0
        public void get_LookAt(){} // RVA: 0x7ffaaa1f79e0
        public void set_LookAt(){} // RVA: 0x7ffaa8d71dc0
        public void get_Follow(){} // RVA: 0x7ffaaa1f79f0
        public void set_Follow(){} // RVA: 0x7ffaa899d050
        public void InternalUpdateCameraState(){} // RVA: 0x7ffaaa223c70
        public void OnEnable(){} // RVA: 0x7ffaaa224150
        public void OnDestroy(){} // RVA: 0x7ffaaa2247d0
        public void OnValidate(){} // RVA: 0x7ffaaa224b60
        public void OnTransformChildrenChanged(){} // RVA: 0x7ffaaa224c40
        public void Reset(){} // RVA: 0x7ffaaa224ca0
        public void DestroyPipeline(){} // RVA: 0x7ffaaa224cc0
        public void CreatePipeline(){} // RVA: 0x7ffaaa2253f0
        public void InvalidateComponentPipeline(){} // RVA: 0x7ffaaa224c40
        public void AddCinemachineComponent(){} // RVA: 0x7ffaa887e5c0
        public void DestroyCinemachineComponent(){} // RVA: 0x7ffaa8660cc0
        public void UpdateComponentPipeline(){} // RVA: 0x7ffaaa225830
        public void CalculateNewState(){} // RVA: 0x7ffaaa226250
        public void OnTargetObjectWarped(){} // RVA: 0x7ffaaa226d10
        public void ForceCameraPosition(){} // RVA: 0x7ffaaa2270a0
        public void OnTransitionFromCamera(){} // RVA: 0x7ffaaa227340
        public void RequiresUserInput(){} // RVA: 0x7ffaaa227850
        public void OnBeforeSerialize(){} // RVA: 0x7ffaaa227b10
        public void .ctor(){} // RVA: 0x7ffaaa227bf0
        // ── Binary Analysis Named ──
        public void GetMaxDampTime(){} // RVA: 0x7ffaaa223b00
        public void GetComponentOwner(){} // RVA: 0x7ffaaa225760
        public void GetComponentPipeline(){} // RVA: 0x7ffaaa225780
        public void GetCinemachineComponent(){} // RVA: 0x7ffaa887e5c0
        public void GetCinemachineComponent(){} // RVA: 0x7ffaa887e5c0
        public void SetFlagsForHiddenChild(){} // RVA: 0x7ffaaa2260a0
        public void SetStateRawPosition(){} // RVA: 0x7ffaaa227320
    }

    public class CinemachineVirtualCameraBase : MonoBehaviour
    {
        public object m_ValidatingStreamVersion; // 0x3171D7C0
        public object m_Priority; // 0x3171D7C0
        public object LookAtTargetAttachment; // 0x3171D7C0
        public object _previousStateIsValid; // 0x3171D7C0, was: <PreviousStateIsValid>k__Backi
        public object m_parentVcam; // 0x3171D7C0
        public object m_CachedFollowTarget; // 0x3171D7C0
        public object m_CachedLookAtTarget; // 0x3171D7C0
        public object _followTargetChanged; // 0x3171D7C0, was: <FollowTargetChanged>k__Backin
        public object 00; // 0x34B2E140
        public object VirtualCamera; // 0x336F6360
        public object IsValid; // 0x17000001

        // ── Original Methods ──
        public void get_ValidatingStreamVersion(){} // RVA: 0x7ffaaa24d920
        public void set_ValidatingStreamVersion(){} // RVA: 0x7ffaa898dce0
        public void DetachedFollowTargetDamp(){} // RVA: 0x7ffaaa24dc90
        public void DetachedFollowTargetDamp(){} // RVA: 0x7ffaaa24dc90
        public void DetachedFollowTargetDamp(){} // RVA: 0x7ffaaa24dc90
        public void DetachedLookAtTargetDamp(){} // RVA: 0x7ffaaa24df60
        public void DetachedLookAtTargetDamp(){} // RVA: 0x7ffaaa24df60
        public void DetachedLookAtTargetDamp(){} // RVA: 0x7ffaaa24df60
        public void AddExtension(){} // RVA: 0x7ffaaa24e010
        public void RemoveExtension(){} // RVA: 0x7ffaaa24e170
        public void get_mExtensions(){} // RVA: 0x7ffaa89d30e0
        public void set_mExtensions(){} // RVA: 0x7ffaa8a8a4d0
        public void InvokePostPipelineStageCallback(){} // RVA: 0x7ffaaa24e1d0
        public void InvokePrePipelineMutateCameraStateCallback(){} // RVA: 0x7ffaaa24e4c0
        public void InvokeOnTransitionInExtensions(){} // RVA: 0x7ffaaa24e7a0
        public void get_Name(){} // RVA: 0x7ffaa8b680f0
        public void get_Description(){} // RVA: 0x7ffaaa24e9c0
        public void get_Priority(){} // RVA: 0x7ffaa8de7460
        public void set_Priority(){} // RVA: 0x7ffaaa1eabc0
        public void ApplyPositionBlendMethod(){} // RVA: 0x7ffaaa24ea00
        public void get_VirtualCameraGameObject(){} // RVA: 0x7ffaaa24ea30
        public void get_IsValid(){} // RVA: 0x7ffaaa24eb40
        public void get_State(){}
        public void get_ParentCamera(){} // RVA: 0x7ffaaa24ec10
        public void IsLiveChild(){} // RVA: 0x7ffaa8932320
        public void get_LookAt(){} // RVA: 0x7ffaa86491d0
        public void set_LookAt(){} // RVA: 0x7ffaa8660d80
        public void get_Follow(){} // RVA: 0x7ffaa86491d0
        public void set_Follow(){} // RVA: 0x7ffaa8660d80
        public void get_PreviousStateIsValid(){} // RVA: 0x7ffaa8b6c110
        public void set_PreviousStateIsValid(){} // RVA: 0x7ffaa92bb760
        public void UpdateCameraState(){} // RVA: 0x7ffaaa24ecb0
        public void InternalUpdateCameraState(){}
        public void OnTransitionFromCamera(){} // RVA: 0x7ffaaa24ed50
        public void OnDestroy(){} // RVA: 0x7ffaaa24ee20
        public void OnTransformParentChanged(){} // RVA: 0x7ffaaa24ef50
        public void Start(){} // RVA: 0x7ffaa8ae3fc0
        public void RequiresUserInput(){} // RVA: 0x7ffaaa24eff0
        public void EnsureStarted(){} // RVA: 0x7ffaaa24f170
        public void OnValidate(){} // RVA: 0x7ffaaa24f2f0
        public void OnEnable(){} // RVA: 0x7ffaaa24f360
        public void OnDisable(){} // RVA: 0x7ffaaa24f6d0
        public void Update(){} // RVA: 0x7ffaaa24f740
        public void UpdateSlaveStatus(){} // RVA: 0x7ffaaa24f750
        public void ResolveLookAt(){} // RVA: 0x7ffaaa24f930
        public void ResolveFollow(){} // RVA: 0x7ffaaa24fa50
        public void UpdateVcamPoolStatus(){} // RVA: 0x7ffaaa24fb70
        public void MoveToTopOfPrioritySubqueue(){} // RVA: 0x7ffaaa24fda0
        public void OnTargetObjectWarped(){} // RVA: 0x7ffaaa24fdb0
        public void ForceCameraPosition(){} // RVA: 0x7ffaaa24feb0
        public void CreateBlend(){} // RVA: 0x7ffaaa2500d0
        public void PullStateFromVirtualCamera(){} // RVA: 0x7ffaaa250530
        public void InvalidateCachedTargets(){} // RVA: 0x7ffaaa250860
        public void get_FollowTargetChanged(){} // RVA: 0x7ffaa9feeae0
        public void set_FollowTargetChanged(){} // RVA: 0x7ffaa91d7fd0
        public void get_LookAtTargetChanged(){} // RVA: 0x7ffaaa250a70
        public void set_LookAtTargetChanged(){} // RVA: 0x7ffaaa250a80
        public void UpdateTargetCache(){} // RVA: 0x7ffaaa250a90
        public void get_AbstractFollowTargetGroup(){} // RVA: 0x7ffaa8d1a3b0
        public void get_FollowTargetAsVcam(){} // RVA: 0x7ffaa8af68f0
        public void get_AbstractLookAtTargetGroup(){} // RVA: 0x7ffaa8f75d20
        public void get_LookAtTargetAsVcam(){} // RVA: 0x7ffaa8d1b980
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7ffaaa251090
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7ffaaa2510b0
        public void LegacyUpgrade(){} // RVA: 0x7ffaa8932310
        public void OnBeforeSerialize(){} // RVA: 0x7ffaa8932310
        public void CancelDamping(){} // RVA: 0x7ffaaa251160
        public void .ctor(){} // RVA: 0x7ffaaa2513c0
        // ── Binary Analysis Named ──
        public void GetMaxDampTime(){} // RVA: 0x7ffaaa24d990
        public void GetInputAxisProvider(){} // RVA: 0x7ffaaa24f230
        public void GetInheritPosition(){} // RVA: 0x7ffaaa24ffc0
    }

    public class ClipperLib : Object
    {
    }

    public class ConfinerOven : Object
    {
        public object m_OriginalPolygon; // 0x33CD3E00
        public object k_FloatToIntScaler; // 0x33CD3E00
        public object m_PolygonRect; // 0x33CD3E00
        public object _state; // 0x33CD3E00, was: <State>k__BackingField
        public object 00; // 0x34B4CBE0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaa251660
        public void get_State(){} // RVA: 0x7ffaa905bf10
        public void set_State(){} // RVA: 0x7ffaa905bde0
        public void Initialize(){} // RVA: 0x7ffaaa251bf0
        public void BakeConfiner(){} // RVA: 0x7ffaaa252450
        public void <Initialize>g__GetPolygonBoundingBox|24_0(){} // RVA: 0x7ffaaa252aa0
        public void <Initialize>g__MidPointOfIntRect|24_1(){} // RVA: 0x7ffaaa252c60
        public void <BakeConfiner>g__ComputeSkeleton|25_0(){} // RVA: 0x7ffaaa252c90
        // ── Binary Analysis Named ──
        public void GetBakedSolution(){} // RVA: 0x7ffaaa251790
    }

    public class Documentation : Object
    {
    }

    public class DocumentationSortingAttribute : Attribute
    {
        // ── Original Methods ──
        public void get_Category(){} // RVA: 0x7ffaa897f5c0
        public void set_Category(){} // RVA: 0x7ffaa89350c0
        public void .ctor(){} // RVA: 0x7ffaa89350c0
    }

    public class GroupWeightManipulator : MonoBehaviour
    {
        public object m_Weight2; // 0x3379F1F0
        public object m_Weight5; // 0x3379F1F0
        public object m_group; // 0x3379F1F0
        public object m_LayerMask; // 0x33B05DF0

        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffaaa25c3e0
        public void OnValidate(){} // RVA: 0x7ffaaa25c470
        public void Update(){} // RVA: 0x7ffaaa25c4e0
        public void UpdateWeights(){} // RVA: 0x7ffaaa25c6b0
        public void .ctor(){} // RVA: 0x7ffaaa25c7a0
    }

    public class ICameraOverrideStack
    {
        // ── Original Methods ──
        public void ReleaseCameraOverride(){} // RVA: 0x7ffaa8661210
        public void get_DefaultWorldUp(){} // RVA: 0x7ffaa8648be0
        // ── Binary Analysis Named ──
        public void SetCameraOverride(){}
    }

    public class ICinemachineCamera
    {
        // ── Original Methods ──
        public void get_Name(){} // RVA: 0x7ffaa86491d0
        public void get_Description(){} // RVA: 0x7ffaa86491d0
        public void get_Priority(){} // RVA: 0x7ffaa8649ca0
        public void set_Priority(){} // RVA: 0x7ffaa8661210
        public void get_LookAt(){} // RVA: 0x7ffaa86491d0
        public void set_LookAt(){} // RVA: 0x7ffaa8660d80
        public void get_Follow(){} // RVA: 0x7ffaa86491d0
        public void set_Follow(){} // RVA: 0x7ffaa8660d80
        public void get_State(){}
        public void get_VirtualCameraGameObject(){} // RVA: 0x7ffaa86491d0
        public void get_IsValid(){} // RVA: 0x7ffaa864a040
        public void get_ParentCamera(){} // RVA: 0x7ffaa86491d0
        public void IsLiveChild(){}
        public void UpdateCameraState(){}
        public void InternalUpdateCameraState(){}
        public void OnTransitionFromCamera(){}
        public void OnTargetObjectWarped(){}
    }

    public class ICinemachineTargetGroup
    {
        // ── Original Methods ──
        public void get_Transform(){} // RVA: 0x7ffaa86491d0
        public void get_BoundingBox(){}
        public void get_Sphere(){}
        public void get_IsEmpty(){} // RVA: 0x7ffaa864a040
        // ── Binary Analysis Named ──
        public void GetViewSpaceBoundingBox(){}
        public void GetViewSpaceAngularBounds(){}
    }

    public class ISignalSource6D
    {
        // ── Original Methods ──
        public void get_SignalDuration(){} // RVA: 0x7ffaa865dbc0
        // ── Binary Analysis Named ──
        public void GetSignal(){}
    }

    public class LensSettings : ValueType
    {
        public object OrthographicSize; // 0x33726730
        public object Dutch; // 0x33726730
        public object GateFit; // 0x33726730
        public object m_OrthoFromCamera; // 0x33726730
        public object m_Weight; // 0x34B44DF0
        public object Description; // 0x17000003
        public object LiveChild; // 0x17000004
        public object State; // 0x17000005

        // ── Original Methods ──
        public void get_Orthographic(){} // RVA: 0x7ffaaa254210
        public void set_Orthographic(){} // RVA: 0x7ffaaa254230
        public void get_SensorSize(){} // RVA: 0x7ffaa9dcc710
        public void set_SensorSize(){} // RVA: 0x7ffaa8e049c0
        public void get_Aspect(){} // RVA: 0x7ffaaa254240
        public void get_IsPhysicalCamera(){} // RVA: 0x7ffaaa2542d0
        public void set_IsPhysicalCamera(){} // RVA: 0x7ffaaa2542f0
        public void FromCamera(){} // RVA: 0x7ffaaa254300
        public void SnapshotCameraReadOnlyProperties(){} // RVA: 0x7ffaaa254aa0
        public void SnapshotCameraReadOnlyProperties(){} // RVA: 0x7ffaaa254aa0
        public void .ctor(){} // RVA: 0x7ffaaa254bb0
        public void Lerp(){} // RVA: 0x7ffaaa254c00
        public void Validate(){} // RVA: 0x7ffaaa254e60
        public void .cctor(){} // RVA: 0x7ffaaa254ee0
    }

    public class LensSettingsPropertyAttribute : PropertyAttribute
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class NoSaveDuringPlayAttribute : PropertyAttribute
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class NoiseSettings : SignalSourceAsset
    {
        // ── Original Methods ──
        public void get_SignalDuration(){} // RVA: 0x7ffaa916f990
        public void .ctor(){} // RVA: 0x7ffaaa2552a0
        // ── Binary Analysis Named ──
        public void GetCombinedFilterResults(){} // RVA: 0x7ffaaa254f70
        public void GetSignal(){} // RVA: 0x7ffaaa2550f0
    }

    public class NoiseSettingsPropertyAttribute : PropertyAttribute
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class OrbitalTransposerHeadingPropertyAttribute : PropertyAttribute
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class RuntimeUtility : Object
    {
        public object s_ScratchCollider; // 0x33A569A0
        public object 8؏f; // 0x34B47E80

        // ── Original Methods ──
        public void DestroyObject(){} // RVA: 0x7ffaaa2554e0
        public void IsPrefab(){} // RVA: 0x7ffaa8932320
        public void RaycastIgnoreTag(){} // RVA: 0x7ffaaa2555d0
        public void SphereCastIgnoreTag(){} // RVA: 0x7ffaaa255990
        public void DestroyScratchCollider(){} // RVA: 0x7ffaaa256aa0
        public void NormalizeCurve(){} // RVA: 0x7ffaaa256d90
        public void .cctor(){} // RVA: 0x7ffaaa257000
        // ── Binary Analysis Named ──
        public void GetScratchCollider(){} // RVA: 0x7ffaaa256500
    }

    public class SaveDuringPlayAttribute : Attribute
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class SignalSourceAsset : ScriptableObject
    {
        // ── Original Methods ──
        public void get_SignalDuration(){} // RVA: 0x7ffaa865dbc0
        public void .ctor(){} // RVA: 0x7ffaa8b59ae0
        // ── Binary Analysis Named ──
        public void GetSignal(){}
    }

    public class StaticPointVirtualCamera : Object
    {
        public object _lookAt; // 0x34B453A0, was: <LookAt>k__BackingField

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaa2466b0
        public void get_Name(){} // RVA: 0x7ffaa894d380
        public void set_Name(){} // RVA: 0x7ffaa8933e30
        public void get_Description(){} // RVA: 0x7ffaaa246860
        public void get_Priority(){} // RVA: 0x7ffaa8b945a0
        public void set_Priority(){} // RVA: 0x7ffaa9357830
        public void get_LookAt(){} // RVA: 0x7ffaa89600c0
        public void set_LookAt(){} // RVA: 0x7ffaa89600d0
        public void get_Follow(){} // RVA: 0x7ffaa8960130
        public void set_Follow(){} // RVA: 0x7ffaa8933e90
        public void get_State(){} // RVA: 0x7ffaaa2468a0
        public void set_State(){} // RVA: 0x7ffaaa246940
        public void get_VirtualCameraGameObject(){} // RVA: 0x7ffaa8f22da0
        public void get_IsValid(){} // RVA: 0x7ffaa8a17850
        public void get_ParentCamera(){} // RVA: 0x7ffaa8f22da0
        public void IsLiveChild(){} // RVA: 0x7ffaa8932320
        public void UpdateCameraState(){} // RVA: 0x7ffaa8932310
        public void InternalUpdateCameraState(){} // RVA: 0x7ffaa8932310
        public void OnTransitionFromCamera(){} // RVA: 0x7ffaa8932310
        public void OnTargetObjectWarped(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void SetState(){} // RVA: 0x7ffaaa2467b0
    }

    public class TagFieldAttribute : PropertyAttribute
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class TargetPositionCache : Object
    {
        public object m_CacheMode; // 0x33C9F380
        public object IsCameraCut; // 0x33C9F380
        public object kWraparoundSlush; // 0x33C9F380
        public object CacheMode; // 0x170000D8
        public object IsRecording; // 0x170000D9
        public object CurrentPlaybackTimeValid; // 0x170000DA

        // ── Original Methods ──
        public void get_CacheMode(){} // RVA: 0x7ffaaa257150
        public void set_CacheMode(){} // RVA: 0x7ffaaa257190
        public void get_IsRecording(){} // RVA: 0x7ffaaa257200
        public void get_CurrentPlaybackTimeValid(){} // RVA: 0x7ffaaa257250
        public void get_IsEmpty(){} // RVA: 0x7ffaaa2572e0
        public void get_CacheTimeRange(){} // RVA: 0x7ffaaa257330
        public void get_HasCurrentTime(){} // RVA: 0x7ffaaa257380
        public void ClearCache(){} // RVA: 0x7ffaaa2573e0
        public void CreatePlaybackCurves(){} // RVA: 0x7ffaaa257550
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetTargetPosition(){} // RVA: 0x7ffaaa2577a0
        public void GetTargetRotation(){} // RVA: 0x7ffaaa257c60
    }

    public class UpdateTracker : Object
    {
        public object mLastUpdateTime; // 0x33665490

        // ── Original Methods ──
        public void InitializeModule(){} // RVA: 0x7ffaaa259470
        public void UpdateTargets(){} // RVA: 0x7ffaaa2594f0
        public void OnUpdate(){} // RVA: 0x7ffaaa259d60
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void .cctor(){} // RVA: 0x7ffaaa259e20
        // ── Binary Analysis Named ──
        public void GetPreferredUpdate(){} // RVA: 0x7ffaaa2599f0
    }

    public class VcamTargetPropertyAttribute : PropertyAttribute
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

}