// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Cinemachine.Cinemachine
// Classes: 87
// Methods: 995

namespace ThirdParty.Cinemachine.Cinemachine
{
    public class AxisBase : ValueType
    {
        public object m_Value;
        public object m_MinValue;
        public object m_MaxValue;
        public object m_Wrap;

        // ── Methods ──
        public void Validate(){} // RVA: 0x88A30
    }

    public class AxisState : ValueType
    {
        public object Value;
        public object m_SpeedMode;
        public object m_MaxSpeed;
        public object m_AccelTime;
        public object m_DecelTime;
        public object m_InputAxisName;
        public object m_InputAxisValue;
        public object m_InvertInput;
        public object m_MinValue;
        public object m_MaxValue;
        public object m_Wrap;
        public object m_Recentering;
        public object m_CurrentSpeed;
        public object m_LastUpdateTime;
        public object m_LastUpdateFrame;
        public object Epsilon;
        public object m_InputAxisProvider;
        public object m_InputAxisIndex;
        public object _valueRangeLocked;
        public object _hasRecentering;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x87870
        public void Validate(){} // RVA: 0x87890
        public void Reset(){} // RVA: 0x878F0
        public void SetInputAxisProvider(){} // RVA: 0x87900
        public void get_HasInputProvider(){} // RVA: 0x87960
        public void Update(){} // RVA: 0x87970
        public void ClampValue(){} // RVA: 0x87980
        public void MaxSpeedUpdate(){} // RVA: 0x87990
        public void GetMaxSpeed(){} // RVA: 0x879A0
        public void get_ValueRangeLocked(){} // RVA: 0x879B0
        public void set_ValueRangeLocked(){} // RVA: 0x879C0
        public void get_HasRecentering(){} // RVA: 0x879D0
        public void set_HasRecentering(){} // RVA: 0x879E0
    }

    public class AxisStatePropertyAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xF48510
    }

    public class BlendSourceVirtualCamera : Object
    {
        public object _blend;
        public object _priority;
        public object _lookAt;
        public object _follow;
        public object _state;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_Blend(){} // RVA: 0xB5DBF0
        public void set_Blend(){} // RVA: 0xB44D60
        public void get_Name(){} // RVA: 0x25C7760
        public void get_Description(){} // RVA: 0x25C77A0
        public void get_Priority(){} // RVA: 0xE62D00
        public void set_Priority(){} // RVA: 0x1033F40
        public void get_LookAt(){} // RVA: 0xB700F0
        public void set_LookAt(){} // RVA: 0xB70100
        public void get_Follow(){} // RVA: 0xB70160
        public void set_Follow(){} // RVA: 0xB44DC0
        public void get_State(){} // RVA: 0x25C75E0
        public void set_State(){} // RVA: 0x25C7680
        public void get_VirtualCameraGameObject(){} // RVA: 0xDAC980
        public void get_IsValid(){} // RVA: 0x25C77F0
        public void get_ParentCamera(){} // RVA: 0xDAC980
        public void IsLiveChild(){} // RVA: 0x25C7810
        public void CalculateNewState(){} // RVA: 0x25C75E0
        public void UpdateCameraState(){} // RVA: 0x25C7830
        public void InternalUpdateCameraState(){} // RVA: 0xB43310
        public void OnTransitionFromCamera(){} // RVA: 0xB43310
        public void OnTargetObjectWarped(){} // RVA: 0xB43310
    }

    public class CameraState : ValueType
    {
        public object Lens;
        public object ReferenceUp;
        public object ReferenceLookAt;
        public object kNoPoint;
        public object RawPosition;
        public object RawOrientation;
        public object PositionDampingBypass;
        public object ShotQuality;
        public object PositionCorrection;
        public object OrientationCorrection;
        public object BlendHint;
        public object mCustom0;
        public object mCustom1;
        public object mCustom2;
        public object mCustom3;
        public object m_CustomOverflow;
        public object _numCustomBlendables;

        // ── Methods ──
        public void get_HasLookAt(){} // RVA: 0x87C30
        public void get_CorrectedPosition(){} // RVA: 0x87C90
        public void get_CorrectedOrientation(){} // RVA: 0x87CE0
        public void get_FinalPosition(){} // RVA: 0x87C90
        public void get_FinalOrientation(){} // RVA: 0x87D10
        public void get_Default(){} // RVA: 0x25C0A70
        public void get_NumCustomBlendables(){} // RVA: 0x87D40
        public void set_NumCustomBlendables(){} // RVA: 0x87D50
        public void GetCustomBlendable(){} // RVA: 0x87D60
        public void FindCustomBlendable(){} // RVA: 0x87D90
        public void AddCustomBlendable(){} // RVA: 0x87DA0
        public void Lerp(){} // RVA: 0x25C17A0
        public void InterpolateFOV(){} // RVA: 0x25C5910
        public void ApplyPosBlendHint(){} // RVA: 0x25C5A50
        public void ApplyRotBlendHint(){} // RVA: 0x25C5AD0
        public void InterpolatePosition(){} // RVA: 0x87DC0
        public void .cctor(){} // RVA: 0x25C6000
    }

    public class Cinemachine3rdPersonAim : CinemachineExtension
    {
        public object AimCollisionFilter;
        public object IgnoreTag;
        public object AimDistance;
        public object AimTargetReticle;
        public object _aimTarget;

        // ── Methods ──
        public void get_AimTarget(){} // RVA: 0xBA9CC0
        public void set_AimTarget(){} // RVA: 0xBA9CE0
        public void OnValidate(){} // RVA: 0x2577190
        public void Reset(){} // RVA: 0x25771B0
        public void OnTransitionFromCamera(){} // RVA: 0x2577290
        public void DrawReticle(){} // RVA: 0x2577410
        public void ComputeLookAtPoint(){} // RVA: 0x2577810
        public void ComputeAimTarget(){} // RVA: 0x2577EA0
        public void PostPipelineStageCallback(){} // RVA: 0x2578150
        public void .ctor(){} // RVA: 0x25784A0
    }

    public class Cinemachine3rdPersonFollow : CinemachineComponentBase
    {
        public object Damping;
        public object ShoulderOffset;
        public object VerticalArmLength;
        public object CameraSide;
        public object CameraDistance;
        public object CameraCollisionFilter;
        public object IgnoreTag;
        public object CameraRadius;
        public object DampingIntoCollision;
        public object DampingFromCollision;
        public object m_PreviousFollowTargetPosition;
        public object m_DampingCorrection;
        public object m_CamPosCollisionCorrection;

        // ── Methods ──
        public void OnValidate(){} // RVA: 0x25A8DB0
        public void Reset(){} // RVA: 0x25A8E30
        public void OnDestroy(){} // RVA: 0x25A8EA0
        public void get_IsValid(){} // RVA: 0x25A8EF0
        public void get_Stage(){} // RVA: 0xDAC980
        public void GetMaxDampTime(){} // RVA: 0x25A9070
        public void MutateCameraState(){} // RVA: 0x25A90A0
        public void OnTargetObjectWarped(){} // RVA: 0x25A9130
        public void PositionCamera(){} // RVA: 0x25A92A0
        public void GetRigPositions(){} // RVA: 0x25A99C0
        public void GetHeading(){} // RVA: 0x25A9BE0
        public void GetRawRigPositions(){} // RVA: 0x25AA140
        public void ResolveCollisions(){} // RVA: 0x25AA4B0
        public void .ctor(){} // RVA: 0x25AA7F0
    }

    public class CinemachineBasicMultiChannelPerlin : CinemachineComponentBase
    {
        public object m_NoiseProfile;
        public object m_PivotOffset;
        public object m_AmplitudeGain;
        public object m_FrequencyGain;
        public object mInitialized;
        public object mNoiseTime;
        public object mNoiseOffsets;

        // ── Methods ──
        public void get_IsValid(){} // RVA: 0x25AA890
        public void get_Stage(){} // RVA: 0xC50A80
        public void MutateCameraState(){} // RVA: 0x25AAA10
        public void ReSeed(){} // RVA: 0x25AB4F0
        public void Initialize(){} // RVA: 0x25AB620
        public void .ctor(){} // RVA: 0x25AB830
    }

    public class CinemachineBlend : Object
    {
        public object CamA;
        public object CamB;
        public object BlendCurve;
        public object TimeInBlend;
        public object Duration;

        // ── Methods ──
        public void get_BlendWeight(){} // RVA: 0x25C6050
        public void get_IsValid(){} // RVA: 0x25C6150
        public void get_IsComplete(){} // RVA: 0x25C61D0
        public void get_Description(){} // RVA: 0x25C6200
        public void Uses(){} // RVA: 0x25C6410
        public void .ctor(){} // RVA: 0x25C6510
        public void UpdateCameraState(){} // RVA: 0x25C6630
        public void get_State(){} // RVA: 0x25C6720
    }

    public class CinemachineBlendDefinition : ValueType
    {
        public object m_Style;
        public object m_Time;
        public object m_CustomCurve;
        public object sStandardCurves;

        // ── Methods ──
        public void get_BlendTime(){} // RVA: 0x88050
        public void .ctor(){} // RVA: 0x88060
        public void CreateStandardCurves(){} // RVA: 0x880C0
        public void get_BlendCurve(){} // RVA: 0x880D0
    }

    public class CinemachineBlendDefinitionPropertyAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xF48510
    }

    public class CinemachineBlendListCamera : CinemachineVirtualCameraBase
    {
        public object m_LookAt;
        public object m_Follow;
        public object m_ShowDebugText;
        public object m_Loop;
        public object m_ChildCameras;
        public object m_Instructions;
        public object _liveChild;
        public object m_TransitioningFrom;
        public object m_State;
        public object mActivationTime;
        public object mCurrentInstruction;
        public object mActiveBlend;

        // ── Methods ──
        public void get_Description(){} // RVA: 0x2578540
        public void Reset(){} // RVA: 0x2578680
        public void get_LiveChild(){} // RVA: 0xC68EB0
        public void set_LiveChild(){} // RVA: 0xC68EC0
        public void IsLiveChild(){} // RVA: 0x25787F0
        public void get_State(){} // RVA: 0x2578820
        public void get_LookAt(){} // RVA: 0x25788C0
        public void set_LookAt(){} // RVA: 0x13B1040
        public void get_Follow(){} // RVA: 0x25788D0
        public void set_Follow(){} // RVA: 0xBAE350
        public void OnTargetObjectWarped(){} // RVA: 0x25788E0
        public void ForceCameraPosition(){} // RVA: 0x25789C0
        public void OnTransitionFromCamera(){} // RVA: 0x2578AC0
        public void InternalUpdateCameraState(){} // RVA: 0x2578CF0
        public void OnEnable(){} // RVA: 0x2579610
        public void OnDisable(){} // RVA: 0x2579980
        public void OnTransformChildrenChanged(){} // RVA: 0x2579B00
        public void OnGuiHandler(){} // RVA: 0x2579B10
        public void get_ChildCameras(){} // RVA: 0x2579C80
        public void get_IsBlending(){} // RVA: 0x2579CA0
        public void InvalidateListOfChildren(){} // RVA: 0x2579CB0
        public void UpdateListOfChildren(){} // RVA: 0x2579D70
        public void ValidateInstructions(){} // RVA: 0x257A240
        public void AdvanceCurrentInstruction(){} // RVA: 0x257A650
        public void .ctor(){} // RVA: 0x257A890
    }

    public class CinemachineBlenderSettings : ScriptableObject
    {
        public object m_CustomBlends;
        public object kBlendFromAnyCameraLabel;

        // ── Methods ──
        public void GetBlendForVirtualCameras(){} // RVA: 0x25C7A00
        public void .ctor(){} // RVA: 0xDD1AC0
    }

    public class CinemachineBrain : MonoBehaviour
    {
        public object m_ShowDebugText;
        public object m_ShowCameraFrustum;
        public object m_IgnoreTimeScale;
        public object m_WorldUpOverride;
        public object m_UpdateMethod;
        public object m_BlendUpdateMethod;
        public object m_DefaultBlend;
        public object m_CustomBlends;
        public object m_OutputCamera;
        public object m_TargetOverride;
        public object m_CameraCutEvent;
        public object m_CameraActivatedEvent;
        public object mSoloCamera;
        public object mPhysicsCoroutine;
        public object m_LastFrameUpdated;
        public object mWaitForFixedUpdate;
        public object mFrameStack;
        public object mNextFrameId;
        public object mCurrentLiveCameras;
        public object mDefaultLinearAnimationCurve;
        public object mActiveCameraPreviousFrame;
        public object mActiveCameraPreviousFrameGameObject;
        public object _currentCameraState;

        // ── Methods ──
        public void get_OutputCamera(){} // RVA: 0x257AA60
        public void get_ControlledObject(){} // RVA: 0x257ABD0
        public void set_ControlledObject(){} // RVA: 0x257ACC0
        public void get_SoloCamera(){} // RVA: 0x257AD80
        public void set_SoloCamera(){} // RVA: 0x257ADE0
        public void GetSoloGUIColor(){} // RVA: 0x257B040
        public void get_DefaultWorldUp(){} // RVA: 0x257B060
        public void OnEnable(){} // RVA: 0x257B1B0
        public void OnDisable(){} // RVA: 0x257B720
        public void OnSceneLoaded(){} // RVA: 0x257BA20
        public void OnSceneUnloaded(){} // RVA: 0x257BAC0
        public void Awake(){} // RVA: 0x257BB60
        public void Start(){} // RVA: 0x257BBC0
        public void OnGuiHandler(){} // RVA: 0x257BBE0
        public void AfterPhysics(){} // RVA: 0x257C080
        public void LateUpdate(){} // RVA: 0x257C120
        public void ManualUpdate(){} // RVA: 0x257C130
        public void GetEffectiveDeltaTime(){} // RVA: 0x257C460
        public void UpdateVirtualCameras(){} // RVA: 0x257C720
        public void get_ActiveVirtualCamera(){} // RVA: 0x257CA80
        public void DeepCamBFromBlend(){} // RVA: 0x257CC00
        public void IsLiveInBlend(){} // RVA: 0x257CCC0
        public void get_IsBlending(){} // RVA: 0x257CDF0
        public void get_ActiveBlend(){} // RVA: 0x257CE10
        public void set_ActiveBlend(){} // RVA: 0x257CF10
        public void GetBrainFrame(){} // RVA: 0x257D030
        public void SetCameraOverride(){} // RVA: 0x257D180
        public void ReleaseCameraOverride(){} // RVA: 0x257D6C0
        public void ProcessActiveCamera(){} // RVA: 0x257D7B0
        public void UpdateFrame0(){} // RVA: 0x257DF50
        public void ComputeCurrentBlend(){} // RVA: 0x257E770
        public void IsLive(){} // RVA: 0x257ED80
        public void get_CurrentCameraState(){} // RVA: 0x257EF60
        public void set_CurrentCameraState(){} // RVA: 0x257F000
        public void TopCameraFromPriorityQueue(){} // RVA: 0x257F0F0
        public void LookupBlend(){} // RVA: 0x257F3E0
        public void PushStateToUnityCamera(){} // RVA: 0x257F630
        public void .ctor(){} // RVA: 0x257FD10
        public void .cctor(){} // RVA: 0x2580170
    }

    public class CinemachineBrain[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class CinemachineClearShot : CinemachineVirtualCameraBase
    {
        public object m_LookAt;
        public object m_Follow;
        public object m_ShowDebugText;
        public object m_ChildCameras;
        public object m_ActivateAfter;
        public object m_MinDuration;
        public object m_RandomizeChoice;
        public object m_DefaultBlend;
        public object m_CustomBlends;
        public object _liveChild;
        public object m_State;
        public object mActivationTime;
        public object mPendingActivationTime;
        public object mPendingCamera;
        public object mActiveBlend;
        public object mRandomizeNow;
        public object m_RandomizedChilden;
        public object m_TransitioningFrom;

        // ── Methods ──
        public void get_Description(){} // RVA: 0x2580730
        public void get_LiveChild(){} // RVA: 0xBAE5A0
        public void set_LiveChild(){} // RVA: 0xBAE5B0
        public void get_State(){} // RVA: 0x2580870
        public void IsLiveChild(){} // RVA: 0x2580910
        public void get_LookAt(){} // RVA: 0x25788C0
        public void set_LookAt(){} // RVA: 0x13B1040
        public void get_Follow(){} // RVA: 0x25788D0
        public void set_Follow(){} // RVA: 0xBAE350
        public void OnTargetObjectWarped(){} // RVA: 0x2580940
        public void ForceCameraPosition(){} // RVA: 0x2580A20
        public void InternalUpdateCameraState(){} // RVA: 0x2580B20
        public void OnEnable(){} // RVA: 0x2581260
        public void OnDisable(){} // RVA: 0x2581580
        public void OnTransformChildrenChanged(){} // RVA: 0x2581700
        public void OnGuiHandler(){} // RVA: 0x2581720
        public void get_IsBlending(){} // RVA: 0x2581890
        public void get_ActiveBlend(){} // RVA: 0x1659260
        public void get_ChildCameras(){} // RVA: 0x25818A0
        public void InvalidateListOfChildren(){} // RVA: 0x25818C0
        public void ResetRandomization(){} // RVA: 0x25819E0
        public void UpdateListOfChildren(){} // RVA: 0x2581A60
        public void ChooseCurrentCamera(){} // RVA: 0x2582050
        public void Randomize(){} // RVA: 0x2582A40
        public void LookupBlend(){} // RVA: 0x2582F80
        public void OnTransitionFromCamera(){} // RVA: 0x25831E0
        public void .ctor(){} // RVA: 0x2583370
    }

    public class CinemachineCollider : CinemachineExtension
    {
        public object m_CollideAgainst;
        public object m_IgnoreTag;
        public object m_TransparentLayers;
        public object m_MinimumDistanceFromTarget;
        public object m_AvoidObstacles;
        public object m_DistanceLimit;
        public object m_MinimumOcclusionTime;
        public object m_CameraRadius;
        public object m_Strategy;
        public object m_MaximumEffort;
        public object m_SmoothingTime;
        public object m_Damping;
        public object m_DampingWhenOccluded;
        public object m_OptimalTargetDistance;
        public object k_PrecisionSlush;
        public object m_CornerBuffer;
        public object k_AngleThreshold;
        public object s_ColliderBuffer;

        // ── Methods ──
        public void IsTargetObscured(){} // RVA: 0x25836C0
        public void CameraWasDisplaced(){} // RVA: 0x2583720
        public void GetCameraDisplacementDistance(){} // RVA: 0x2583790
        public void OnValidate(){} // RVA: 0x2583800
        public void OnDestroy(){} // RVA: 0x2583850
        public void get_DebugPaths(){} // RVA: 0x25838C0
        public void GetMaxDampTime(){} // RVA: 0x2583AF0
        public void OnTargetObjectWarped(){} // RVA: 0x2583B10
        public void PostPipelineStageCallback(){} // RVA: 0x2583C10
        public void PreserveLineOfSight(){} // RVA: 0x2584F00
        public void PullCameraInFrontOfNearestObstacle(){} // RVA: 0x25854D0
        public void PushCameraBack(){} // RVA: 0x25859F0
        public void GetWalkingDirection(){} // RVA: 0x2586480
        public void GetPushBackDistance(){} // RVA: 0x2586E00
        public void ClampRayToBounds(){} // RVA: 0x2586F70
        public void RespectCameraRadius(){} // RVA: 0x2587F40
        public void CheckForTargetObstructions(){} // RVA: 0x2588C50
        public void IsTargetOffscreen(){} // RVA: 0x25890C0
        public void .ctor(){} // RVA: 0x2589940
        public void .cctor(){} // RVA: 0x2589AA0
    }

    public class CinemachineCollisionImpulseSource : CinemachineImpulseSource
    {
        public object m_LayerMask;
        public object m_IgnoreTag;
        public object m_UseImpactDirection;
        public object m_ScaleImpactWithMass;
        public object m_ScaleImpactWithSpeed;
        public object mRigidBody;
        public object mRigidBody2D;

        // ── Methods ──
        public void Start(){} // RVA: 0x25DD400
        public void OnEnable(){} // RVA: 0xB43310
        public void OnCollisionEnter(){} // RVA: 0x25DD520
        public void OnTriggerEnter(){} // RVA: 0x25DD5B0
        public void GetMassAndVelocity(){} // RVA: 0x25DD620
        public void GenerateImpactEvent(){} // RVA: 0x25DDAE0
        public void OnCollisionEnter2D(){} // RVA: 0x25DDE00
        public void OnTriggerEnter2D(){} // RVA: 0x25DDE60
        public void GetMassAndVelocity2D(){} // RVA: 0x25DDED0
        public void GenerateImpactEvent2D(){} // RVA: 0x25DE260
        public void .ctor(){} // RVA: 0x25DE580
    }

    public class CinemachineComponentBase : MonoBehaviour
    {
        public object Epsilon;
        public object m_vcamOwner;

        // ── Methods ──
        public void get_VirtualCamera(){} // RVA: 0x25C7D50
        public void get_FollowTarget(){} // RVA: 0x25C8070
        public void get_LookAtTarget(){} // RVA: 0x25C8170
        public void get_AbstractFollowTargetGroup(){} // RVA: 0x25C8270
        public void get_FollowTargetGroup(){} // RVA: 0x25C8350
        public void get_FollowTargetPosition(){} // RVA: 0x25C83D0
        public void get_FollowTargetRotation(){} // RVA: 0x25C86D0
        public void get_AbstractLookAtTargetGroup(){} // RVA: 0x25C89A0
        public void get_LookAtTargetGroup(){} // RVA: 0x25C89D0
        public void get_LookAtTargetPosition(){} // RVA: 0x25C8A60
        public void get_LookAtTargetRotation(){} // RVA: 0x25C8D60
        public void get_VcamState(){} // RVA: 0x25C9030
        public void get_IsValid(){} // RVA: 0x87D280
        public void PrePipelineMutateCameraState(){} // RVA: 0xB43310
        public void get_Stage(){} // RVA: 0x87C130
        public void get_BodyAppliesAfterAim(){} // RVA: 0xB43320
        public void MutateCameraState(){} // RVA: 0x899A40
        public void OnTransitionFromCamera(){} // RVA: 0xB43320
        public void OnTargetObjectWarped(){} // RVA: 0xB43310
        public void ForceCameraPosition(){} // RVA: 0xB43310
        public void GetMaxDampTime(){} // RVA: 0x13CD2E0
        public void get_RequiresUserInput(){} // RVA: 0xB43320
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class CinemachineComponentBase[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class CinemachineComposer : CinemachineComponentBase
    {
        public object m_TrackedObjectOffset;
        public object m_LookaheadTime;
        public object m_LookaheadSmoothing;
        public object m_LookaheadIgnoreY;
        public object m_HorizontalDamping;
        public object m_VerticalDamping;
        public object m_ScreenX;
        public object m_ScreenY;
        public object m_DeadZoneWidth;
        public object m_DeadZoneHeight;
        public object m_SoftZoneWidth;
        public object m_SoftZoneHeight;
        public object m_BiasX;
        public object m_BiasY;
        public object m_CenterOnActivate;
        public object _trackedPoint;
        public object m_CameraPosPrevFrame;
        public object m_LookAtPrevFrame;
        public object m_ScreenOffsetPrevFrame;
        public object m_CameraOrientationPrevFrame;
        public object m_Predictor;
        public object mCache;

        // ── Methods ──
        public void get_IsValid(){} // RVA: 0x25AB910
        public void get_Stage(){} // RVA: 0xC3CCE0
        public void get_TrackedPoint(){} // RVA: 0x25ABA90
        public void set_TrackedPoint(){} // RVA: 0x25ABAB0
        public void GetLookAtPointAndSetTrackedPoint(){} // RVA: 0x25ABAC0
        public void OnTargetObjectWarped(){} // RVA: 0x25ABF90
        public void ForceCameraPosition(){} // RVA: 0x25AC190
        public void GetMaxDampTime(){} // RVA: 0x25AC1B0
        public void PrePipelineMutateCameraState(){} // RVA: 0x25AC1C0
        public void MutateCameraState(){} // RVA: 0x25AC300
        public void get_SoftGuideRect(){} // RVA: 0x25AD0A0
        public void set_SoftGuideRect(){} // RVA: 0x25AD0F0
        public void get_HardGuideRect(){} // RVA: 0x25AD1B0
        public void set_HardGuideRect(){} // RVA: 0x25AD230
        public void RotateToScreenBounds(){} // RVA: 0x25AD2A0
        public void ClampVerticalBounds(){} // RVA: 0x25AD580
        public void .ctor(){} // RVA: 0x25AD880
    }

    public class CinemachineConfiner : CinemachineExtension
    {
        public object m_ConfineMode;
        public object m_BoundingVolume;
        public object m_BoundingShape2D;
        public object m_BoundingShape2DCache;
        public object m_ConfineScreenEdges;
        public object m_Damping;
        public object m_pathCache;
        public object m_pathTotalPointCount;

        // ── Methods ──
        public void CameraWasDisplaced(){} // RVA: 0x2589CE0
        public void GetCameraDisplacementDistance(){} // RVA: 0x2589D50
        public void OnValidate(){} // RVA: 0x2589DB0
        public void ConnectToVcam(){} // RVA: 0x2589DC0
        public void get_IsValid(){} // RVA: 0x2589DD0
        public void GetMaxDampTime(){} // RVA: 0x1122A70
        public void PostPipelineStageCallback(){} // RVA: 0x2589FE0
        public void InvalidatePathCache(){} // RVA: 0x258A2C0
        public void ValidatePathCache(){} // RVA: 0x258A370
        public void ConfinePoint(){} // RVA: 0x258AC90
        public void ConfineScreenEdges(){} // RVA: 0x258B360
        public void .ctor(){} // RVA: 0x258BB90
    }

    public class CinemachineConfiner2D : CinemachineExtension
    {
        public object m_BoundingShape2D;
        public object m_Damping;
        public object m_MaxWindowSize;
        public object m_Padding;
        public object m_MaxComputationTimePerFrameInSeconds;
        public object k_cornerAngleTreshold;
        public object m_shapeCache;

        // ── Methods ──
        public void InvalidateCache(){} // RVA: 0x258BBE0
        public void ValidateCache(){} // RVA: 0x258BBF0
        public void PostPipelineStageCallback(){} // RVA: 0x258BC40
        public void CalculateHalfFrustumHeight(){} // RVA: 0x258C470
        public void OnValidate(){} // RVA: 0x258C520
        public void Reset(){} // RVA: 0x258C540
        public void .ctor(){} // RVA: 0x258C550
    }

    public class CinemachineCore : Object
    {
        public object kStreamingVersion;
        public object sInstance;
        public object sShowHiddenObjects;
        public object GetInputAxis;
        public object UniformDeltaTimeOverride;
        public object CurrentTimeOverride;
        public object GetBlendOverride;
        public object CameraUpdatedEvent;
        public object CameraCutEvent;
        public object mActiveBrains;
        public object FrameDeltaCompensationEnabled;
        public object mActiveCameras;
        public object m_ActiveCamerasAreSorted;
        public object m_ActivationSequence;
        public object mAllCameras;
        public object mRoundRobinVcamLastFrame;
        public object s_LastUpdateTime;
        public object s_FixedFrameCount;
        public object mUpdateStatus;
        public object m_CurrentUpdateFilter;

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x25C91E0
        public void get_DeltaTime(){} // RVA: 0x25C9310
        public void get_CurrentTime(){} // RVA: 0x25C93D0
        public void get_BrainCount(){} // RVA: 0x25C9490
        public void GetActiveBrain(){} // RVA: 0x25C94E0
        public void AddActiveBrain(){} // RVA: 0x25C9560
        public void RemoveActiveBrain(){} // RVA: 0x25C9600
        public void get_VirtualCameraCount(){} // RVA: 0x25C9660
        public void GetVirtualCamera(){} // RVA: 0x25C96B0
        public void AddActiveCamera(){} // RVA: 0x25C9870
        public void RemoveActiveCamera(){} // RVA: 0x25C98E0
        public void CameraDestroyed(){} // RVA: 0x25C9960
        public void CameraEnabled(){} // RVA: 0x25C9A50
        public void CameraDisabled(){} // RVA: 0x25C9CB0
        public void UpdateAllActiveVirtualCameras(){} // RVA: 0x25C9EF0
        public void UpdateVirtualCamera(){} // RVA: 0x25CA650
        public void InitializeModule(){} // RVA: 0x25CAB40
        public void GetUpdateTarget(){} // RVA: 0x25CAC40
        public void GetVcamUpdateStatus(){} // RVA: 0x25CAF30
        public void IsLive(){} // RVA: 0x25CAFC0
        public void IsLiveInBlend(){} // RVA: 0x25CB120
        public void GenerateCameraActivationEvent(){} // RVA: 0x25CB280
        public void GenerateCameraCutEvent(){} // RVA: 0x25CB470
        public void FindPotentialTargetBrain(){} // RVA: 0x25CB6D0
        public void OnTargetObjectWarped(){} // RVA: 0x25CBB20
        public void .ctor(){} // RVA: 0x25CBBF0
        public void .cctor(){} // RVA: 0x25CBDE0
    }

    public class CinemachineDollyCart : MonoBehaviour
    {
        public object m_Path;
        public object m_UpdateMethod;
        public object m_PositionUnits;
        public object m_Speed;
        public object m_Position;

        // ── Methods ──
        public void FixedUpdate(){} // RVA: 0x258D930
        public void Update(){} // RVA: 0x258D9C0
        public void LateUpdate(){} // RVA: 0x258DAD0
        public void SetCartPosition(){} // RVA: 0x258DBF0
        public void .ctor(){} // RVA: 0x258DDD0
    }

    public class CinemachineEmbeddedAssetPropertyAttribute : PropertyAttribute
    {
        public object WarnIfNull;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x25CE550
    }

    public class CinemachineExtension : MonoBehaviour
    {
        public object Epsilon;
        public object m_vcamOwner;
        public object mExtraState;

        // ── Methods ──
        public void get_VirtualCamera(){} // RVA: 0x25CC580
        public void Awake(){} // RVA: 0x25CC6C0
        public void OnEnable(){} // RVA: 0xB43310
        public void OnDestroy(){} // RVA: 0x25CC6E0
        public void EnsureStarted(){} // RVA: 0x25CC6C0
        public void ConnectToVcam(){} // RVA: 0x25CC700
        public void PrePipelineMutateCameraStateCallback(){} // RVA: 0xB43310
        public void InvokePostPipelineStageCallback(){} // RVA: 0x25CC980
        public void PostPipelineStageCallback(){} // RVA: 0x89C370
        public void OnTargetObjectWarped(){} // RVA: 0xB43310
        public void ForceCameraPosition(){} // RVA: 0xB43310
        public void OnTransitionFromCamera(){} // RVA: 0xB43320
        public void GetMaxDampTime(){} // RVA: 0x13CD2E0
        public void get_RequiresUserInput(){} // RVA: 0xB43320
        public void GetExtraState(){} // RVA: 0xA94080
        public void GetAllExtraStates(){} // RVA: 0x87C0A0
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class CinemachineExtension[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class CinemachineExternalCamera : CinemachineVirtualCameraBase
    {
        public object m_LookAt;
        public object m_Camera;
        public object m_State;
        public object _follow;
        public object m_BlendHint;

        // ── Methods ──
        public void get_State(){} // RVA: 0x258DE20
        public void get_LookAt(){} // RVA: 0x12EB090
        public void set_LookAt(){} // RVA: 0x13B1040
        public void get_Follow(){} // RVA: 0x1664460
        public void set_Follow(){} // RVA: 0x16679E0
        public void InternalUpdateCameraState(){} // RVA: 0x258DEC0
        public void .ctor(){} // RVA: 0x258EAE0
    }

    public class CinemachineFixedSignal : SignalSourceAsset
    {
        public object m_XCurve;
        public object m_YCurve;
        public object m_ZCurve;

        // ── Methods ──
        public void get_SignalDuration(){} // RVA: 0x25DE720
        public void AxisDuration(){} // RVA: 0x25DE780
        public void GetSignal(){} // RVA: 0x25DE970
        public void AxisValue(){} // RVA: 0x25DEA40
        public void .ctor(){} // RVA: 0xDD1AC0
    }

    public class CinemachineFollowZoom : CinemachineExtension
    {
        public object m_Width;
        public object m_Damping;
        public object m_MinFOV;
        public object m_MaxFOV;

        // ── Methods ──
        public void OnValidate(){} // RVA: 0x258ECB0
        public void GetMaxDampTime(){} // RVA: 0xC120F0
        public void PostPipelineStageCallback(){} // RVA: 0x258ED10
        public void .ctor(){} // RVA: 0x258F100
    }

    public class CinemachineFramingTransposer : CinemachineComponentBase
    {
        public object m_TrackedObjectOffset;
        public object m_LookaheadTime;
        public object m_LookaheadSmoothing;
        public object m_LookaheadIgnoreY;
        public object m_XDamping;
        public object m_YDamping;
        public object m_ZDamping;
        public object m_TargetMovementOnly;
        public object m_ScreenX;
        public object m_ScreenY;
        public object m_CameraDistance;
        public object m_DeadZoneWidth;
        public object m_DeadZoneHeight;
        public object m_DeadZoneDepth;
        public object m_UnlimitedSoftZone;
        public object m_SoftZoneWidth;
        public object m_SoftZoneHeight;
        public object m_BiasX;
        public object m_BiasY;
        public object m_CenterOnActivate;
        public object m_GroupFramingMode;
        public object m_AdjustmentMode;
        public object m_GroupFramingSize;
        public object m_MaxDollyIn;
        public object m_MaxDollyOut;
        public object m_MinimumDistance;
        public object m_MaximumDistance;
        public object m_MinimumFOV;
        public object m_MaximumFOV;
        public object m_MinimumOrthoSize;
        public object m_MaximumOrthoSize;
        public object kMinimumCameraDistance;
        public object kMinimumGroupSize;
        public object m_PreviousCameraPosition;
        public object m_Predictor;
        public object _trackedPoint;
        public object m_InheritingPosition;
        public object m_prevFOV;
        public object m_prevRotation;
        public object _lastBounds;
        public object _lastBoundsMatrix;

        // ── Methods ──
        public void get_SoftGuideRect(){} // RVA: 0x25AE750
        public void set_SoftGuideRect(){} // RVA: 0x25AE7A0
        public void get_HardGuideRect(){} // RVA: 0x25AE860
        public void set_HardGuideRect(){} // RVA: 0x25AE8E0
        public void OnValidate(){} // RVA: 0x25AE950
        public void get_IsValid(){} // RVA: 0x25AEA40
        public void get_Stage(){} // RVA: 0xDAC980
        public void get_BodyAppliesAfterAim(){} // RVA: 0xC2E4C0
        public void get_TrackedPoint(){} // RVA: 0x25AEBC0
        public void set_TrackedPoint(){} // RVA: 0x25AEBE0
        public void OnTargetObjectWarped(){} // RVA: 0x25AEC00
        public void ForceCameraPosition(){} // RVA: 0x25AEDC0
        public void GetMaxDampTime(){} // RVA: 0x25AEDF0
        public void OnTransitionFromCamera(){} // RVA: 0x25AEE10
        public void ScreenToOrtho(){} // RVA: 0x25AF040
        public void OrthoOffsetToScreenBounds(){} // RVA: 0x25AF110
        public void get_LastBounds(){} // RVA: 0x25AF220
        public void set_LastBounds(){} // RVA: 0x25AF240
        public void get_LastBoundsMatrix(){} // RVA: 0x25AF260
        public void set_LastBoundsMatrix(){} // RVA: 0x25AF290
        public void MutateCameraState(){} // RVA: 0x25AF2C0
        public void GetTargetHeight(){} // RVA: 0x25B0E40
        public void ComputeGroupBounds(){} // RVA: 0x25B1040
        public void GetScreenSpaceGroupBoundingBox(){} // RVA: 0x25B1840
        public void .ctor(){} // RVA: 0x25B2050
    }

    public class CinemachineFreeLook : CinemachineVirtualCameraBase
    {
        public object m_LookAt;
        public object m_Follow;
        public object m_CommonLens;
        public object m_Lens;
        public object m_Transitions;
        public object m_LegacyBlendHint;
        public object m_YAxis;
        public object m_YAxisRecentering;
        public object m_XAxis;
        public object m_Heading;
        public object m_RecenterToTargetHeading;
        public object m_BindingMode;
        public object m_SplineCurvature;
        public object m_Orbits;
        public object m_LegacyHeadingBias;
        public object mUseLegacyRigDefinitions;
        public object mIsDestroyed;
        public object m_State;
        public object m_Rigs;
        public object mOrbitals;
        public object mBlendA;
        public object mBlendB;
        public object CreateRigOverride;
        public object DestroyRigOverride;
        public object m_CachedXAxisHeading;
        public object m_LastHeadingUpdateFrame;
        public object m_CachedOrbits;
        public object m_CachedTension;
        public object m_CachedKnots;
        public object m_CachedCtrl1;
        public object m_CachedCtrl2;

        // ── Methods ──
        public void OnValidate(){} // RVA: 0x258F160
        public void GetRig(){} // RVA: 0x258F440
        public void get_RigsAreCreated(){} // RVA: 0x258F4A0
        public void get_RigNames(){} // RVA: 0x258F4C0
        public void OnEnable(){} // RVA: 0x258F580
        public void UpdateInputAxisProvider(){} // RVA: 0x258F7A0
        public void OnDestroy(){} // RVA: 0x258F960
        public void OnTransformChildrenChanged(){} // RVA: 0x258FB80
        public void Reset(){} // RVA: 0x258FBE0
        public void get_PreviousStateIsValid(){} // RVA: 0xE3F480
        public void set_PreviousStateIsValid(){} // RVA: 0x258FC00
        public void get_State(){} // RVA: 0x258FD80
        public void get_LookAt(){} // RVA: 0x25788C0
        public void set_LookAt(){} // RVA: 0x13B1040
        public void get_Follow(){} // RVA: 0x25788D0
        public void set_Follow(){} // RVA: 0xBAE350
        public void IsLiveChild(){} // RVA: 0x258FE20
        public void OnTargetObjectWarped(){} // RVA: 0x258FF30
        public void ForceCameraPosition(){} // RVA: 0x2590020
        public void InternalUpdateCameraState(){} // RVA: 0x2590260
        public void OnTransitionFromCamera(){} // RVA: 0x2590E60
        public void RequiresUserInput(){} // RVA: 0xC2E4C0
        public void GetYAxisClosestValue(){} // RVA: 0x2591380
        public void SteepestDescent(){} // RVA: 0x2591B80
        public void InvalidateRigCache(){} // RVA: 0x258FB80
        public void DestroyRigs(){} // RVA: 0x2591DD0
        public void CreateRigs(){} // RVA: 0x25924F0
        public void UpdateRigCache(){} // RVA: 0x2593100
        public void LocateExistingRigs(){} // RVA: 0x25936B0
        public void UpdateXAxisHeading(){} // RVA: 0x2593D40
        public void PushSettingsToRigs(){} // RVA: 0x2593FD0
        public void GetYAxisValue(){} // RVA: 0x25946D0
        public void CalculateNewState(){} // RVA: 0x2594700
        public void GetLocalPositionForCameraFromInput(){} // RVA: 0x25949B0
        public void UpdateCachedSpline(){} // RVA: 0x2594CA0
        public void OnBeforeSerialize(){} // RVA: 0x2595330
        public void .ctor(){} // RVA: 0x2595410
        public void <SteepestDescent>g__AngleFunction|47_0(){} // RVA: 0x2595AE0
        public void <SteepestDescent>g__SlopeOfAngleFunction|47_1(){} // RVA: 0x2595BB0
        public void <SteepestDescent>g__InitialGuess|47_2(){} // RVA: 0x2595C20
        public void <SteepestDescent>g__ChooseBestAngle|47_3(){} // RVA: 0x2595D30
    }

    public class CinemachineGroupComposer : CinemachineComposer
    {
        public object m_GroupFramingSize;
        public object m_FramingMode;
        public object m_FrameDamping;
        public object m_AdjustmentMode;
        public object m_MaxDollyIn;
        public object m_MaxDollyOut;
        public object m_MinimumDistance;
        public object m_MaximumDistance;
        public object m_MinimumFOV;
        public object m_MaximumFOV;
        public object m_MinimumOrthoSize;
        public object m_MaximumOrthoSize;
        public object m_prevFramingDistance;
        public object m_prevFOV;
        public object _lastBounds;
        public object _lastBoundsMatrix;

        // ── Methods ──
        public void OnValidate(){} // RVA: 0x25B2200
        public void get_LastBounds(){} // RVA: 0x25B22D0
        public void set_LastBounds(){} // RVA: 0x25B22F0
        public void get_LastBoundsMatrix(){} // RVA: 0x25B2310
        public void set_LastBoundsMatrix(){} // RVA: 0x25B2340
        public void GetMaxDampTime(){} // RVA: 0x25B2370
        public void MutateCameraState(){} // RVA: 0x25B2390
        public void GetTargetHeight(){} // RVA: 0x25B34F0
        public void GetScreenSpaceGroupBoundingBox(){} // RVA: 0x25B3730
        public void .ctor(){} // RVA: 0x25B3CB0
    }

    public class CinemachineHardLockToTarget : CinemachineComponentBase
    {
        public object m_Damping;
        public object m_PreviousTargetPosition;

        // ── Methods ──
        public void get_IsValid(){} // RVA: 0x25B3D30
        public void get_Stage(){} // RVA: 0xDAC980
        public void GetMaxDampTime(){} // RVA: 0xC27360
        public void MutateCameraState(){} // RVA: 0x25B3EB0
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class CinemachineHardLookAt : CinemachineComponentBase
    {
        // ── Methods ──
        public void get_IsValid(){} // RVA: 0x25B4080
        public void get_Stage(){} // RVA: 0xC3CCE0
        public void MutateCameraState(){} // RVA: 0x25B4200
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class CinemachineImpulseChannelPropertyAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xF48510
    }

    public class CinemachineImpulseDefinition : Object
    {
        public object m_ImpulseChannel;
        public object m_ImpulseShape;
        public object m_CustomImpulseShape;
        public object m_ImpulseDuration;
        public object m_ImpulseType;
        public object m_DissipationRate;
        public object m_RawSignal;
        public object m_AmplitudeGain;
        public object m_FrequencyGain;
        public object m_RepeatMode;
        public object m_Randomize;
        public object m_TimeEnvelope;
        public object m_ImpactRadius;
        public object m_DirectionMode;
        public object m_DissipationMode;
        public object m_DissipationDistance;
        public object m_PropagationSpeed;
        public object sStandardShapes;

        // ── Methods ──
        public void OnValidate(){} // RVA: 0x25DEB30
        public void CreateStandardShapes(){} // RVA: 0x25DEC20
        public void GetStandardCurve(){} // RVA: 0x25DF6B0
        public void get_ImpulseCurve(){} // RVA: 0x25DF730
        public void CreateEvent(){} // RVA: 0x25DF840
        public void CreateAndReturnEvent(){} // RVA: 0x25DF880
        public void LegacyCreateAndReturnEvent(){} // RVA: 0x25DFAE0
        public void .ctor(){} // RVA: 0x25DFED0
    }

    public class CinemachineImpulseDefinitionPropertyAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xF48510
    }

    public class CinemachineImpulseEnvelopePropertyAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xF48510
    }

    public class CinemachineImpulseListener : CinemachineExtension
    {
        public object m_ApplyAfter;
        public object m_ChannelMask;
        public object m_Gain;
        public object m_Use2DDistance;
        public object m_UseCameraSpace;
        public object m_ReactionSettings;

        // ── Methods ──
        public void Reset(){} // RVA: 0x25E08C0
        public void PostPipelineStageCallback(){} // RVA: 0x25E0980
        public void .ctor(){} // RVA: 0x25E0F60
    }

    public class CinemachineImpulseManager : Object
    {
        public object sInstance;
        public object Epsilon;
        public object m_ExpiredEvents;
        public object m_ActiveEvents;
        public object IgnoreTimeScale;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void get_Instance(){} // RVA: 0x25E1670
        public void InitializeModule(){} // RVA: 0x25E1730
        public void EvaluateDissipationScale(){} // RVA: 0x25E1880
        public void GetImpulseAt(){} // RVA: 0x25E1980
        public void get_CurrentTime(){} // RVA: 0x25E1EA0
        public void NewImpulseEvent(){} // RVA: 0x25E1F40
        public void AddImpulseEvent(){} // RVA: 0x25E2040
        public void Clear(){} // RVA: 0x25E2140
    }

    public class CinemachineImpulseSource : MonoBehaviour
    {
        public object m_ImpulseDefinition;
        public object m_DefaultVelocity;

        // ── Methods ──
        public void OnValidate(){} // RVA: 0x25E2FE0
        public void Reset(){} // RVA: 0x25E30F0
        public void GenerateImpulseAtPositionWithVelocity(){} // RVA: 0x25E32A0
        public void GenerateImpulseWithVelocity(){} // RVA: 0x25E32F0
        public void GenerateImpulseWithForce(){} // RVA: 0x25E3410
        public void GenerateImpulse(){} // RVA: 0x25E3410
        public void GenerateImpulseAt(){} // RVA: 0x25E32A0
        public void .ctor(){} // RVA: 0x25E35B0
    }

    public class CinemachineIndependentImpulseListener : MonoBehaviour
    {
        public object impulsePosLastFrame;
        public object impulseRotLastFrame;
        public object m_ChannelMask;
        public object m_Gain;
        public object m_Use2DDistance;
        public object m_UseLocalSpace;
        public object m_ReactionSettings;

        // ── Methods ──
        public void Reset(){} // RVA: 0x25E36D0
        public void OnEnable(){} // RVA: 0x25E3780
        public void Update(){} // RVA: 0x25E3810
        public void LateUpdate(){} // RVA: 0x25E3CB0
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class CinemachineInputAxisDriver : ValueType
    {
        public object multiplier;
        public object accelTime;
        public object decelTime;
        public object name;
        public object inputValue;
        public object mCurrentSpeed;
        public object Epsilon;

        // ── Methods ──
        public void Validate(){} // RVA: 0x87A80
        public void Update(){} // RVA: 0x88BC0
        public void ClampValue(){} // RVA: 0x88C40
    }

    public class CinemachineInputProvider : MonoBehaviour
    {
        public object PlayerIndex;
        public object AutoEnableInputs;
        public object XYAxis;
        public object ZAxis;
        public object NUM_AXES;
        public object m_cachedActions;

        // ── Methods ──
        public void GetAxisValue(){} // RVA: 0x25DACA0
        public void ResolveForPlayer(){} // RVA: 0x25DAE30
        public void OnDisable(){} // RVA: 0x19E2480
        public void .ctor(){} // RVA: 0x25DB730
        public void <ResolveForPlayer>g__GetFirstMatch|7_0(){} // RVA: 0x25DB780
    }

    public class CinemachineMixingCamera : CinemachineVirtualCameraBase
    {
        public object MaxCameras;
        public object m_Weight0;
        public object m_Weight1;
        public object m_Weight2;
        public object m_Weight3;
        public object m_Weight4;
        public object m_Weight5;
        public object m_Weight6;
        public object m_Weight7;
        public object m_State;
        public object _liveChild;
        public object _lookAt;
        public object _follow;
        public object m_ChildCameras;
        public object m_indexMap;

        // ── Methods ──
        public void GetWeight(){} // RVA: 0x25961F0
        public void SetWeight(){} // RVA: 0x2596530
        public void get_LiveChild(){} // RVA: 0x165E8F0
        public void set_LiveChild(){} // RVA: 0x165C4D0
        public void get_State(){} // RVA: 0x2596800
        public void get_LookAt(){} // RVA: 0x1659CB0
        public void set_LookAt(){} // RVA: 0x163A980
        public void get_Follow(){} // RVA: 0x1344890
        public void set_Follow(){} // RVA: 0x1662780
        public void OnTargetObjectWarped(){} // RVA: 0x25968A0
        public void ForceCameraPosition(){} // RVA: 0x2596980
        public void OnEnable(){} // RVA: 0x2596A80
        public void OnTransformChildrenChanged(){} // RVA: 0x2596AA0
        public void OnValidate(){} // RVA: 0x2596AB0
        public void IsLiveChild(){} // RVA: 0x2596B60
        public void get_ChildCameras(){} // RVA: 0x2596C20
        public void InvalidateListOfChildren(){} // RVA: 0x2596C40
        public void ValidateListOfChildren(){} // RVA: 0x2596D60
        public void OnTransitionFromCamera(){} // RVA: 0x2597330
        public void InternalUpdateCameraState(){} // RVA: 0x2597490
        public void .ctor(){} // RVA: 0x2597BD0
    }

    public class CinemachineOrbitalTransposer : CinemachineTransposer
    {
        public object m_Heading;
        public object m_RecenterToTargetHeading;
        public object m_XAxis;
        public object m_LegacyRadius;
        public object m_LegacyHeightOffset;
        public object m_LegacyHeadingBias;
        public object m_HeadingIsSlave;
        public object HeadingUpdater;
        public object m_LastTargetPosition;
        public object mHeadingTracker;
        public object m_TargetRigidBody;
        public object m_PreviousTarget;
        public object m_LastCameraPosition;
        public object m_LastHeading;

        // ── Methods ──
        public void OnValidate(){} // RVA: 0x25B45C0
        public void UpdateHeading(){} // RVA: 0x25B47F0
        public void OnEnable(){} // RVA: 0x25B4990
        public void UpdateInputAxisProvider(){} // RVA: 0x25B4BB0
        public void OnTargetObjectWarped(){} // RVA: 0x25B4D20
        public void ForceCameraPosition(){} // RVA: 0x25B5020
        public void OnTransitionFromCamera(){} // RVA: 0x25B5180
        public void GetAxisClosestValue(){} // RVA: 0x25B53C0
        public void MutateCameraState(){} // RVA: 0x25B5B20
        public void GetTargetCameraPosition(){} // RVA: 0x25B6AD0
        public void get_RequiresUserInput(){} // RVA: 0xC2E4C0
        public void GetTargetHeading(){} // RVA: 0x25B6F30
        public void .ctor(){} // RVA: 0x25B7830
    }

    public class CinemachineOrbitalTransposer[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class CinemachinePOV : CinemachineComponentBase
    {
        public object m_RecenterTarget;
        public object m_VerticalAxis;
        public object m_VerticalRecentering;
        public object m_HorizontalAxis;
        public object m_HorizontalRecentering;
        public object m_ApplyBeforeBody;
        public object m_PreviousCameraRotation;

        // ── Methods ──
        public void get_IsValid(){} // RVA: 0xBA9AB0
        public void get_Stage(){} // RVA: 0xC3CCE0
        public void OnValidate(){} // RVA: 0x25B8020
        public void OnEnable(){} // RVA: 0x25B8130
        public void UpdateInputAxisProvider(){} // RVA: 0x25B8140
        public void PrePipelineMutateCameraState(){} // RVA: 0xB43310
        public void MutateCameraState(){} // RVA: 0x25B8410
        public void GetRecenterTarget(){} // RVA: 0x25B8B80
        public void NormalizeAngle(){} // RVA: 0x25B8FF0
        public void ForceCameraPosition(){} // RVA: 0x25B9020
        public void OnTransitionFromCamera(){} // RVA: 0x25B9040
        public void get_RequiresUserInput(){} // RVA: 0xC2E4C0
        public void SetAxesForRotation(){} // RVA: 0x25B92B0
        public void .ctor(){} // RVA: 0x25B9D50
    }

    public class CinemachinePath : CinemachinePathBase
    {
        public object m_Looped;
        public object m_Waypoints;

        // ── Methods ──
        public void get_MinPos(){} // RVA: 0x13CD2E0
        public void get_MaxPos(){} // RVA: 0x2597DF0
        public void get_Looped(){} // RVA: 0xC00EC0
        public void Reset(){} // RVA: 0x2597E30
        public void OnValidate(){} // RVA: 0x2597FF0
        public void get_DistanceCacheSampleStepsPerSegment(){} // RVA: 0xFEAE90
        public void GetBoundingIndices(){} // RVA: 0x2598010
        public void EvaluateLocalPosition(){} // RVA: 0x2598100
        public void EvaluateLocalTangent(){} // RVA: 0x2598420
        public void EvaluateLocalOrientation(){} // RVA: 0x2598680
        public void GetRoll(){} // RVA: 0x2598A90
        public void RollAroundForward(){} // RVA: 0x2598BC0
        public void .ctor(){} // RVA: 0x2598C10
    }

    public class CinemachinePathBase : MonoBehaviour
    {
        public object m_Resolution;
        public object m_Appearance;
        public object m_DistanceToPos;
        public object m_PosToDistance;
        public object m_CachedSampleSteps;
        public object m_PathLength;
        public object m_cachedPosStepSize;
        public object m_cachedDistanceStepSize;

        // ── Methods ──
        public void get_MinPos(){} // RVA: 0x890F90
        public void get_MaxPos(){} // RVA: 0x890F90
        public void get_Looped(){} // RVA: 0x87D280
        public void StandardizePos(){} // RVA: 0x25CCE10
        public void EvaluatePosition(){} // RVA: 0x25CCF00
        public void EvaluateTangent(){} // RVA: 0x25CD020
        public void EvaluateOrientation(){} // RVA: 0x25CD140
        public void EvaluateLocalPosition(){} // RVA: 0x87C300
        public void EvaluateLocalTangent(){} // RVA: 0x87C300
        public void EvaluateLocalOrientation(){} // RVA: 0x87C300
        public void FindClosestPoint(){} // RVA: 0x25CD3B0
        public void MinUnit(){} // RVA: 0x25CD800
        public void MaxUnit(){} // RVA: 0x25CD830
        public void StandardizeUnit(){} // RVA: 0x25CD860
        public void EvaluatePositionAtUnit(){} // RVA: 0x25CD910
        public void EvaluateTangentAtUnit(){} // RVA: 0x25CD970
        public void EvaluateOrientationAtUnit(){} // RVA: 0x25CD9D0
        public void get_DistanceCacheSampleStepsPerSegment(){} // RVA: 0x87C130
        public void InvalidateDistanceCache(){} // RVA: 0x25CDA30
        public void DistanceCacheIsValid(){} // RVA: 0x25CDAE0
        public void get_PathLength(){} // RVA: 0x25CDB80
        public void StandardizePathDistance(){} // RVA: 0x25CDBF0
        public void ToNativePathUnits(){} // RVA: 0x25CDCB0
        public void FromPathNativeUnits(){} // RVA: 0x25CDE30
        public void ResamplePath(){} // RVA: 0x25CDF50
        public void .ctor(){} // RVA: 0x25CE440
    }

    public class CinemachinePipeline : MonoBehaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class CinemachinePixelPerfect : MonoBehaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class CinemachineSameAsFollowTarget : CinemachineComponentBase
    {
        public object m_Damping;
        public object m_PreviousReferenceOrientation;

        // ── Methods ──
        public void get_IsValid(){} // RVA: 0x25BA0B0
        public void get_Stage(){} // RVA: 0xC3CCE0
        public void GetMaxDampTime(){} // RVA: 0xC27360
        public void MutateCameraState(){} // RVA: 0x25BA230
        public void .ctor(){} // RVA: 0x25BA560
    }

    public class CinemachineSmoothPath : CinemachinePathBase
    {
        public object m_Looped;
        public object m_Waypoints;
        public object m_ControlPoints1;
        public object m_ControlPoints2;
        public object m_IsLoopedCache;

        // ── Methods ──
        public void get_MinPos(){} // RVA: 0x13CD2E0
        public void get_MaxPos(){} // RVA: 0x2597DF0
        public void get_Looped(){} // RVA: 0xC00EC0
        public void get_DistanceCacheSampleStepsPerSegment(){} // RVA: 0xFEAE90
        public void OnValidate(){} // RVA: 0x2597FF0
        public void Reset(){} // RVA: 0x2598DB0
        public void InvalidateDistanceCache(){} // RVA: 0x2598F60
        public void UpdateControlPoints(){} // RVA: 0x25990B0
        public void GetBoundingIndices(){} // RVA: 0x2599440
        public void EvaluateLocalPosition(){} // RVA: 0x2599520
        public void EvaluateLocalTangent(){} // RVA: 0x25998A0
        public void EvaluateLocalOrientation(){} // RVA: 0x2599B70
        public void RollAroundForward(){} // RVA: 0x2598BC0
        public void .ctor(){} // RVA: 0x259A060
    }

    public class CinemachineStateDrivenCamera : CinemachineVirtualCameraBase
    {
        public object m_LookAt;
        public object m_Follow;
        public object m_AnimatedTarget;
        public object m_LayerIndex;
        public object m_ShowDebugText;
        public object m_ChildCameras;
        public object m_Instructions;
        public object m_DefaultBlend;
        public object m_CustomBlends;
        public object m_ParentHash;
        public object _liveChild;
        public object m_TransitioningFrom;
        public object m_State;
        public object mHashCache;
        public object mActivationTime;
        public object mActiveInstruction;
        public object mPendingActivationTime;
        public object mPendingInstruction;
        public object mActiveBlend;
        public object mInstructionDictionary;
        public object mStateParentLookup;
        public object m_clipInfoList;

        // ── Methods ──
        public void get_Description(){} // RVA: 0x259A190
        public void get_LiveChild(){} // RVA: 0x135A7B0
        public void set_LiveChild(){} // RVA: 0xEC0BB0
        public void IsLiveChild(){} // RVA: 0x259A2D0
        public void get_State(){} // RVA: 0x259A300
        public void get_LookAt(){} // RVA: 0x25788C0
        public void set_LookAt(){} // RVA: 0x13B1040
        public void get_Follow(){} // RVA: 0x25788D0
        public void set_Follow(){} // RVA: 0xBAE350
        public void OnTargetObjectWarped(){} // RVA: 0x259A3A0
        public void ForceCameraPosition(){} // RVA: 0x259A480
        public void OnTransitionFromCamera(){} // RVA: 0x259A580
        public void InternalUpdateCameraState(){} // RVA: 0x259A690
        public void OnEnable(){} // RVA: 0x259AED0
        public void OnDisable(){} // RVA: 0x259B1F0
        public void OnTransformChildrenChanged(){} // RVA: 0x259B370
        public void OnGuiHandler(){} // RVA: 0x259B380
        public void get_ChildCameras(){} // RVA: 0x259B4F0
        public void get_IsBlending(){} // RVA: 0x259B510
        public void get_ActiveBlend(){} // RVA: 0x163F650
        public void CreateFakeHash(){} // RVA: 0x259B520
        public void LookupFakeHash(){} // RVA: 0x259B5A0
        public void InvalidateListOfChildren(){} // RVA: 0x259B910
        public void UpdateListOfChildren(){} // RVA: 0x259B9D0
        public void ValidateInstructions(){} // RVA: 0x259BEB0
        public void ChooseCurrentCamera(){} // RVA: 0x259C500
        public void GetClipHash(){} // RVA: 0x259CD90
        public void LookupBlend(){} // RVA: 0x259CF60
        public void .ctor(){} // RVA: 0x259D1C0
    }

    public class CinemachineStoryboard : CinemachineExtension
    {
        public object s_StoryboardGlobalMute;
        public object m_ShowImage;
        public object m_Image;
        public object m_Aspect;
        public object m_Alpha;
        public object m_Center;
        public object m_Rotation;
        public object m_Scale;
        public object m_SyncScale;
        public object m_MuteCamera;
        public object m_SplitView;
        public object m_RenderMode;
        public object m_SortingOrder;
        public object m_PlaneDistance;
        public object mCanvasInfo;

        // ── Methods ──
        public void PostPipelineStageCallback(){} // RVA: 0x259D500
        public void UpdateRenderCanvas(){} // RVA: 0x259D720
        public void ConnectToVcam(){} // RVA: 0x259D980
        public void get_CanvasName(){} // RVA: 0x259DB50
        public void CameraUpdatedCallback(){} // RVA: 0x259DC40
        public void LocateMyCanvas(){} // RVA: 0x259DFF0
        public void CreateCanvas(){} // RVA: 0x259EA50
        public void DestroyCanvas(){} // RVA: 0x259F150
        public void PlaceImage(){} // RVA: 0x259F4D0
        public void StaticBlendingHandler(){} // RVA: 0x25A0230
        public void InitializeModule(){} // RVA: 0x25A0620
        public void .ctor(){} // RVA: 0x25A0790
    }

    public class CinemachineTargetGroup : MonoBehaviour
    {
        public object m_PositionMode;
        public object m_RotationMode;
        public object m_UpdateMethod;
        public object m_Targets;
        public object m_MaxWeight;
        public object m_WeightSum;
        public object m_AveragePos;
        public object m_BoundingBox;
        public object m_BoundingSphere;
        public object m_LastUpdateFrame;
        public object m_ValidMembers;
        public object m_MemberValidity;

        // ── Methods ──
        public void OnValidate(){} // RVA: 0x25A0960
        public void Reset(){} // RVA: 0x25A09F0
        public void get_Transform(){} // RVA: 0x114DE50
        public void get_BoundingBox(){} // RVA: 0x25A0A80
        public void set_BoundingBox(){} // RVA: 0x25A0B10
        public void get_Sphere(){} // RVA: 0x25A0B30
        public void set_Sphere(){} // RVA: 0xC5C450
        public void get_IsEmpty(){} // RVA: 0x25A0BB0
        public void AddMember(){} // RVA: 0x25A0C50
        public void RemoveMember(){} // RVA: 0x25A0F40
        public void FindMember(){} // RVA: 0x25A1110
        public void GetWeightedBoundsForMember(){} // RVA: 0x25A12B0
        public void GetViewSpaceBoundingBox(){} // RVA: 0x25A1490
        public void get_CachedCountIsValid(){} // RVA: 0x25A1C60
        public void IndexIsValid(){} // RVA: 0x25A1CD0
        public void WeightedMemberBoundsForValidMember(){} // RVA: 0x25A1CF0
        public void DoUpdate(){} // RVA: 0x25A1EB0
        public void UpdateMemberValidity(){} // RVA: 0x25A2200
        public void CalculateAveragePosition(){} // RVA: 0x25A2580
        public void CalculateBoundingBox(){} // RVA: 0x25A2840
        public void CalculateBoundingSphere(){} // RVA: 0x25A2DE0
        public void CalculateAverageOrientation(){} // RVA: 0x25A3210
        public void FixedUpdate(){} // RVA: 0x25A3AA0
        public void Update(){} // RVA: 0x25A3AB0
        public void LateUpdate(){} // RVA: 0x25A3B50
        public void GetViewSpaceAngularBounds(){} // RVA: 0x25A3B60
        public void .ctor(){} // RVA: 0x25A48F0
    }

    public class CinemachineTrackedDolly : CinemachineComponentBase
    {
        public object m_Path;
        public object m_PathPosition;
        public object m_PositionUnits;
        public object m_PathOffset;
        public object m_XDamping;
        public object m_YDamping;
        public object m_ZDamping;
        public object m_CameraUp;
        public object m_PitchDamping;
        public object m_YawDamping;
        public object m_RollDamping;
        public object m_AutoDolly;
        public object m_PreviousPathPosition;
        public object m_PreviousOrientation;
        public object m_PreviousCameraPosition;

        // ── Methods ──
        public void get_IsValid(){} // RVA: 0x25BA5E0
        public void get_Stage(){} // RVA: 0xDAC980
        public void GetMaxDampTime(){} // RVA: 0x25BA760
        public void MutateCameraState(){} // RVA: 0x25BA810
        public void GetCameraOrientationAtPathPoint(){} // RVA: 0x25BBA60
        public void get_AngularDamping(){} // RVA: 0x25BC140
        public void .ctor(){} // RVA: 0x25BC1F0
    }

    public class CinemachineTransposer : CinemachineComponentBase
    {
        public object m_BindingMode;
        public object m_FollowOffset;
        public object m_XDamping;
        public object m_YDamping;
        public object m_ZDamping;
        public object m_AngularDampingMode;
        public object m_PitchDamping;
        public object m_YawDamping;
        public object m_RollDamping;
        public object m_AngularDamping;
        public object _hideOffsetInInspector;
        public object m_PreviousTargetPosition;
        public object m_PreviousReferenceOrientation;
        public object m_targetOrientationOnAssign;
        public object m_PreviousOffset;
        public object m_previousTarget;

        // ── Methods ──
        public void OnValidate(){} // RVA: 0x25BC350
        public void get_HideOffsetInInspector(){} // RVA: 0xE3F480
        public void set_HideOffsetInInspector(){} // RVA: 0x1546550
        public void get_EffectiveOffset(){} // RVA: 0x25BC3A0
        public void get_IsValid(){} // RVA: 0x25BC3E0
        public void get_Stage(){} // RVA: 0xDAC980
        public void GetMaxDampTime(){} // RVA: 0x25BC560
        public void MutateCameraState(){} // RVA: 0x25BC5F0
        public void OnTargetObjectWarped(){} // RVA: 0x25BCCB0
        public void ForceCameraPosition(){} // RVA: 0x25BCE20
        public void InitPrevFrameStateInfo(){} // RVA: 0x25BD170
        public void TrackTarget(){} // RVA: 0x25BD3D0
        public void GetOffsetForMinimumTargetDistance(){} // RVA: 0x25BE4F0
        public void get_Damping(){} // RVA: 0x25BEA90
        public void get_AngularDamping(){} // RVA: 0x25BEAD0
        public void GetTargetCameraPosition(){} // RVA: 0x25BEBB0
        public void GetReferenceOrientation(){} // RVA: 0x25BEEB0
        public void .ctor(){} // RVA: 0x25BF570
    }

    public class CinemachineTriggerAction : MonoBehaviour
    {
        public object m_LayerMask;
        public object m_WithTag;
        public object m_WithoutTag;
        public object m_SkipFirst;
        public object m_Repeating;
        public object m_OnObjectEnter;
        public object m_OnObjectExit;
        public object m_ActiveTriggerObjects;

        // ── Methods ──
        public void Filter(){} // RVA: 0x25DBC00
        public void InternalDoTriggerEnter(){} // RVA: 0x25DBD30
        public void InternalDoTriggerExit(){} // RVA: 0x25DBED0
        public void OnTriggerEnter(){} // RVA: 0x25DBF80
        public void OnTriggerExit(){} // RVA: 0x25DBFC0
        public void OnCollisionEnter(){} // RVA: 0x25DC000
        public void OnCollisionExit(){} // RVA: 0x25DC040
        public void OnTriggerEnter2D(){} // RVA: 0x25DBF80
        public void OnTriggerExit2D(){} // RVA: 0x25DBFC0
        public void OnCollisionEnter2D(){} // RVA: 0x25DC080
        public void OnCollisionExit2D(){} // RVA: 0x25DC0C0
        public void OnEnable(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0x25DC100
    }

    public class CinemachineVirtualCamera : CinemachineVirtualCameraBase
    {
        public object m_LookAt;
        public object m_Follow;
        public object m_Lens;
        public object m_Transitions;
        public object m_LegacyBlendHint;
        public object PipelineName;
        public object CreatePipelineOverride;
        public object DestroyPipelineOverride;
        public object m_State;
        public object m_ComponentPipeline;
        public object m_ComponentOwner;
        public object mCachedLookAtTarget;
        public object mCachedLookAtTargetVcam;

        // ── Methods ──
        public void get_State(){} // RVA: 0x259A300
        public void get_LookAt(){} // RVA: 0x25788C0
        public void set_LookAt(){} // RVA: 0x13B1040
        public void get_Follow(){} // RVA: 0x25788D0
        public void set_Follow(){} // RVA: 0xBAE350
        public void GetMaxDampTime(){} // RVA: 0x25A4AF0
        public void InternalUpdateCameraState(){} // RVA: 0x25A4C80
        public void OnEnable(){} // RVA: 0x25A5130
        public void OnDestroy(){} // RVA: 0x25A57D0
        public void OnValidate(){} // RVA: 0x25A5B10
        public void OnTransformChildrenChanged(){} // RVA: 0x25A5BE0
        public void Reset(){} // RVA: 0x25A5C40
        public void DestroyPipeline(){} // RVA: 0x25A5C60
        public void CreatePipeline(){} // RVA: 0x25A6340
        public void InvalidateComponentPipeline(){} // RVA: 0x25A5BE0
        public void GetComponentOwner(){} // RVA: 0x25A65C0
        public void GetComponentPipeline(){} // RVA: 0x25A65E0
        public void GetCinemachineComponent(){} // RVA: 0xA94080
        public void AddCinemachineComponent(){} // RVA: 0xA94080
        public void DestroyCinemachineComponent(){} // RVA: 0x894290
        public void UpdateComponentPipeline(){} // RVA: 0x25A66B0
        public void SetFlagsForHiddenChild(){} // RVA: 0x25A6F50
        public void CalculateNewState(){} // RVA: 0x25A7090
        public void OnTargetObjectWarped(){} // RVA: 0x25A7B60
        public void ForceCameraPosition(){} // RVA: 0x25A7F30
        public void SetStateRawPosition(){} // RVA: 0x25A80C0
        public void OnTransitionFromCamera(){} // RVA: 0x25A80E0
        public void RequiresUserInput(){} // RVA: 0x25A8600
        public void OnBeforeSerialize(){} // RVA: 0x25A88C0
        public void .ctor(){} // RVA: 0x25A89A0
    }

    public class CinemachineVirtualCameraBase : MonoBehaviour
    {
        public object m_ExcludedPropertiesInInspector;
        public object m_LockStageInInspector;
        public object m_ValidatingStreamVersion;
        public object m_OnValidateCalled;
        public object m_StreamingVersion;
        public object m_Priority;
        public object m_ActivationId;
        public object FollowTargetAttachment;
        public object LookAtTargetAttachment;
        public object m_StandbyUpdate;
        public object _mExtensions;
        public object _previousStateIsValid;
        public object m_WasStarted;
        public object mSlaveStatusUpdated;
        public object m_parentVcam;
        public object m_QueuePriority;
        public object m_blendStartPosition;
        public object m_CachedFollowTarget;
        public object m_CachedFollowTargetVcam;
        public object m_CachedFollowTargetGroup;
        public object m_CachedLookAtTarget;
        public object m_CachedLookAtTargetVcam;
        public object m_CachedLookAtTargetGroup;
        public object _followTargetChanged;
        public object _lookAtTargetChanged;

        // ── Methods ──
        public void get_ValidatingStreamVersion(){} // RVA: 0x25CE560
        public void set_ValidatingStreamVersion(){} // RVA: 0xB9E090
        public void GetMaxDampTime(){} // RVA: 0x25CE5D0
        public void DetachedFollowTargetDamp(){} // RVA: 0x25CE8E0
        public void DetachedLookAtTargetDamp(){} // RVA: 0x25CEBB0
        public void AddExtension(){} // RVA: 0x25CEC60
        public void RemoveExtension(){} // RVA: 0x25CEDC0
        public void get_mExtensions(){} // RVA: 0xBE58B0
        public void set_mExtensions(){} // RVA: 0xCA4DF0
        public void InvokePostPipelineStageCallback(){} // RVA: 0x25CEE20
        public void InvokePrePipelineMutateCameraStateCallback(){} // RVA: 0x25CF130
        public void InvokeOnTransitionInExtensions(){} // RVA: 0x25CF430
        public void get_Name(){} // RVA: 0xE3CFB0
        public void get_Description(){} // RVA: 0x25CF660
        public void get_Priority(){} // RVA: 0x114DAD0
        public void set_Priority(){} // RVA: 0x25671C0
        public void ApplyPositionBlendMethod(){} // RVA: 0x25CF6A0
        public void get_VirtualCameraGameObject(){} // RVA: 0x25CF6D0
        public void get_IsValid(){} // RVA: 0x25CF7A0
        public void get_State(){} // RVA: 0x87BEB0
        public void get_ParentCamera(){} // RVA: 0x25CF870
        public void IsLiveChild(){} // RVA: 0xB43320
        public void get_LookAt(){} // RVA: 0x87C0A0
        public void set_LookAt(){} // RVA: 0x894320
        public void get_Follow(){} // RVA: 0x87C0A0
        public void set_Follow(){} // RVA: 0x894320
        public void get_PreviousStateIsValid(){} // RVA: 0xE3F480
        public void set_PreviousStateIsValid(){} // RVA: 0x1546550
        public void UpdateCameraState(){} // RVA: 0x25CF910
        public void InternalUpdateCameraState(){} // RVA: 0x899A40
        public void OnTransitionFromCamera(){} // RVA: 0x25CF9B0
        public void OnDestroy(){} // RVA: 0x25CFA80
        public void OnTransformParentChanged(){} // RVA: 0x25CFBB0
        public void Start(){} // RVA: 0xCFF3F0
        public void RequiresUserInput(){} // RVA: 0x25CFC50
        public void EnsureStarted(){} // RVA: 0x25CFDD0
        public void GetInputAxisProvider(){} // RVA: 0x25CFE80
        public void OnValidate(){} // RVA: 0x25CFF30
        public void OnEnable(){} // RVA: 0x25CFFA0
        public void OnDisable(){} // RVA: 0x25D0390
        public void Update(){} // RVA: 0x25D0400
        public void UpdateSlaveStatus(){} // RVA: 0x25D0410
        public void ResolveLookAt(){} // RVA: 0x25D0580
        public void ResolveFollow(){} // RVA: 0x25D06A0
        public void UpdateVcamPoolStatus(){} // RVA: 0x25D07C0
        public void MoveToTopOfPrioritySubqueue(){} // RVA: 0x25D09B0
        public void OnTargetObjectWarped(){} // RVA: 0x25D09C0
        public void ForceCameraPosition(){} // RVA: 0x25D0AD0
        public void GetInheritPosition(){} // RVA: 0x25D0BF0
        public void CreateBlend(){} // RVA: 0x25D0D30
        public void PullStateFromVirtualCamera(){} // RVA: 0x25D11B0
        public void InvalidateCachedTargets(){} // RVA: 0x25D1470
        public void get_FollowTargetChanged(){} // RVA: 0x2443C20
        public void set_FollowTargetChanged(){} // RVA: 0x143D170
        public void get_LookAtTargetChanged(){} // RVA: 0x25D1680
        public void set_LookAtTargetChanged(){} // RVA: 0x25D1690
        public void UpdateTargetCache(){} // RVA: 0x25D16A0
        public void get_AbstractFollowTargetGroup(){} // RVA: 0xCD48B0
        public void get_FollowTargetAsVcam(){} // RVA: 0xCD3320
        public void get_AbstractLookAtTargetGroup(){} // RVA: 0x106A7D0
        public void get_LookAtTargetAsVcam(){} // RVA: 0x1069350
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x25D1CF0
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x25D1D10
        public void LegacyUpgrade(){} // RVA: 0xB43310
        public void OnBeforeSerialize(){} // RVA: 0xB43310
        public void CancelDamping(){} // RVA: 0x25D1DC0
        public void .ctor(){} // RVA: 0x25D2020
    }

    public class CinemachineVirtualCameraBase[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class CinemachineVirtualCamera[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class ConfinerOven : Object
    {
        public object m_MinFrustumHeightWithBones;
        public object m_SkeletonPadding;
        public object m_OriginalPolygon;
        public object m_MidPoint;
        public object m_Skeleton;
        public object k_FloatToIntScaler;
        public object k_IntToFloatScaler;
        public object k_MinStepSize;
        public object m_PolygonRect;
        public object m_AspectStretcher;
        public object m_MaxComputationTimeForFullSkeletonBakeInSeconds;
        public object _state;
        public object bakeProgress;
        public object m_Cache;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x25D22C0
        public void GetBakedSolution(){} // RVA: 0x25D23F0
        public void get_State(){} // RVA: 0x12BB630
        public void set_State(){} // RVA: 0x12BB640
        public void Initialize(){} // RVA: 0x25D2850
        public void BakeConfiner(){} // RVA: 0x25D30A0
        public void <Initialize>g__GetPolygonBoundingBox|24_0(){} // RVA: 0x25D36F0
        public void <Initialize>g__MidPointOfIntRect|24_1(){} // RVA: 0x25D38B0
        public void <BakeConfiner>g__ComputeSkeleton|25_0(){} // RVA: 0x25D38E0
    }

    public class DocumentationSortingAttribute : Attribute
    {
        public object _category;

        // ── Methods ──
        public void get_Category(){} // RVA: 0xB8F8F0
        public void set_Category(){} // RVA: 0xB460A0
        public void .ctor(){} // RVA: 0xB460A0
    }

    public class GroupWeightManipulator : MonoBehaviour
    {
        public object m_Weight0;
        public object m_Weight1;
        public object m_Weight2;
        public object m_Weight3;
        public object m_Weight4;
        public object m_Weight5;
        public object m_Weight6;
        public object m_Weight7;
        public object m_group;

        // ── Methods ──
        public void Start(){} // RVA: 0x25DCFC0
        public void OnValidate(){} // RVA: 0x25DD050
        public void Update(){} // RVA: 0x25DD0C0
        public void UpdateWeights(){} // RVA: 0x25DD290
        public void .ctor(){} // RVA: 0x25DD380
    }

    public class ICameraOverrideStack
    {
        // ── Methods ──
        public void SetCameraOverride(){} // RVA: 0x8840F0
        public void ReleaseCameraOverride(){} // RVA: 0x8944F0
        public void get_DefaultWorldUp(){} // RVA: 0x87BEB0
    }

    public class ICinemachineCamera
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x87C0A0
        public void get_Description(){} // RVA: 0x87C0A0
        public void get_Priority(){} // RVA: 0x87C130
        public void set_Priority(){} // RVA: 0x8944F0
        public void get_LookAt(){} // RVA: 0x87C0A0
        public void set_LookAt(){} // RVA: 0x894320
        public void get_Follow(){} // RVA: 0x87C0A0
        public void set_Follow(){} // RVA: 0x894320
        public void get_State(){} // RVA: 0x87BEB0
        public void get_VirtualCameraGameObject(){} // RVA: 0x87C0A0
        public void get_IsValid(){} // RVA: 0x87D280
        public void get_ParentCamera(){} // RVA: 0x87C0A0
        public void IsLiveChild(){} // RVA: 0x87F360
        public void UpdateCameraState(){} // RVA: 0x899A40
        public void InternalUpdateCameraState(){} // RVA: 0x899A40
        public void OnTransitionFromCamera(){} // RVA: 0x895520
        public void OnTargetObjectWarped(){} // RVA: 0x8943B0
    }

    public class ICinemachineTargetGroup
    {
        // ── Methods ──
        public void get_Transform(){} // RVA: 0x87C0A0
        public void get_BoundingBox(){} // RVA: 0x87BEB0
        public void get_Sphere(){} // RVA: 0x87BEB0
        public void get_IsEmpty(){} // RVA: 0x87D280
        public void GetViewSpaceBoundingBox(){} // RVA: 0x87BF80
        public void GetViewSpaceAngularBounds(){} // RVA: 0x899870
    }

    public class ISignalSource6D
    {
        // ── Methods ──
        public void get_SignalDuration(){} // RVA: 0x890F90
        public void GetSignal(){} // RVA: 0x8A2770
    }

    public class LensSettings : ValueType
    {
        public object Default;
        public object FieldOfView;
        public object OrthographicSize;
        public object NearClipPlane;
        public object FarClipPlane;
        public object Dutch;
        public object ModeOverride;
        public object LensShift;
        public object GateFit;
        public object FocusDistance;
        public object m_SensorSize;
        public object m_OrthoFromCamera;
        public object m_PhysicalFromCamera;

        // ── Methods ──
        public void get_Orthographic(){} // RVA: 0x89010
        public void set_Orthographic(){} // RVA: 0x89030
        public void get_SensorSize(){} // RVA: 0x89040
        public void set_SensorSize(){} // RVA: 0x89060
        public void get_Aspect(){} // RVA: 0x89070
        public void get_IsPhysicalCamera(){} // RVA: 0x89080
        public void set_IsPhysicalCamera(){} // RVA: 0x890A0
        public void FromCamera(){} // RVA: 0x25D4F90
        public void SnapshotCameraReadOnlyProperties(){} // RVA: 0x890C0
        public void .ctor(){} // RVA: 0x891D0
        public void Lerp(){} // RVA: 0x25D5640
        public void Validate(){} // RVA: 0x89220
        public void .cctor(){} // RVA: 0x25D5920
    }

    public class LensSettingsPropertyAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xF48510
    }

    public class NoSaveDuringPlayAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xF48510
    }

    public class NoiseSettings : SignalSourceAsset
    {
        public object PositionNoise;
        public object OrientationNoise;

        // ── Methods ──
        public void GetCombinedFilterResults(){} // RVA: 0x25D59B0
        public void get_SignalDuration(){} // RVA: 0x13CD2E0
        public void GetSignal(){} // RVA: 0x25D5B30
        public void .ctor(){} // RVA: 0x25D5CE0
    }

    public class NoiseSettingsPropertyAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xF48510
    }

    public class OrbitalTransposerHeadingPropertyAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xF48510
    }

    public class RuntimeUtility : Object
    {
        public object s_HitBuffer;
        public object s_PenetrationIndexBuffer;
        public object s_ScratchCollider;
        public object s_ScratchColliderGameObject;

        // ── Methods ──
        public void DestroyObject(){} // RVA: 0x25D5F20
        public void IsPrefab(){} // RVA: 0xB43320
        public void RaycastIgnoreTag(){} // RVA: 0x25D6040
        public void SphereCastIgnoreTag(){} // RVA: 0x25D6440
        public void GetScratchCollider(){} // RVA: 0x25D7000
        public void DestroyScratchCollider(){} // RVA: 0x25D74B0
        public void NormalizeCurve(){} // RVA: 0x25D7760
        public void .cctor(){} // RVA: 0x25D79D0
    }

    public class SaveDuringPlayAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SignalSourceAsset : ScriptableObject
    {
        // ── Methods ──
        public void get_SignalDuration(){} // RVA: 0x890F90
        public void GetSignal(){} // RVA: 0x8A2770
        public void .ctor(){} // RVA: 0xDD1AC0
    }

    public class StaticPointVirtualCamera : Object
    {
        public object _name;
        public object _priority;
        public object _lookAt;
        public object _follow;
        public object _state;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x25C73F0
        public void SetState(){} // RVA: 0x25C74F0
        public void get_Name(){} // RVA: 0xB5DBF0
        public void set_Name(){} // RVA: 0xB44D60
        public void get_Description(){} // RVA: 0x25C75A0
        public void get_Priority(){} // RVA: 0xE62D00
        public void set_Priority(){} // RVA: 0x1033F40
        public void get_LookAt(){} // RVA: 0xB700F0
        public void set_LookAt(){} // RVA: 0xB70100
        public void get_Follow(){} // RVA: 0xB70160
        public void set_Follow(){} // RVA: 0xB44DC0
        public void get_State(){} // RVA: 0x25C75E0
        public void set_State(){} // RVA: 0x25C7680
        public void get_VirtualCameraGameObject(){} // RVA: 0xDAC980
        public void get_IsValid(){} // RVA: 0xC2E4C0
        public void get_ParentCamera(){} // RVA: 0xDAC980
        public void IsLiveChild(){} // RVA: 0xB43320
        public void UpdateCameraState(){} // RVA: 0xB43310
        public void InternalUpdateCameraState(){} // RVA: 0xB43310
        public void OnTransitionFromCamera(){} // RVA: 0xB43310
        public void OnTargetObjectWarped(){} // RVA: 0xB43310
    }

    public class TagFieldAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xF48510
    }

    public class TargetPositionCache : Object
    {
        public object UseCache;
        public object CacheStepSize;
        public object m_CacheMode;
        public object CurrentTime;
        public object CurrentFrame;
        public object IsCameraCut;
        public object m_Cache;
        public object m_CacheTimeRange;
        public object kWraparoundSlush;

        // ── Methods ──
        public void get_CacheMode(){} // RVA: 0x25D7B20
        public void set_CacheMode(){} // RVA: 0x25D7B60
        public void get_IsRecording(){} // RVA: 0x25D7BD0
        public void get_CurrentPlaybackTimeValid(){} // RVA: 0x25D7C20
        public void get_IsEmpty(){} // RVA: 0x25D7CB0
        public void get_CacheTimeRange(){} // RVA: 0x25D7D00
        public void get_HasCurrentTime(){} // RVA: 0x25D7D50
        public void ClearCache(){} // RVA: 0x25D7DB0
        public void CreatePlaybackCurves(){} // RVA: 0x25D7F20
        public void GetTargetPosition(){} // RVA: 0x25D8180
        public void GetTargetRotation(){} // RVA: 0x25D8550
        public void .ctor(){} // RVA: 0xB43310
    }

    public class UpdateTracker : Object
    {
        public object mUpdateStatus;
        public object sToDelete;
        public object mLastUpdateTime;

        // ── Methods ──
        public void InitializeModule(){} // RVA: 0x25D9F60
        public void UpdateTargets(){} // RVA: 0x25D9FE0
        public void GetPreferredUpdate(){} // RVA: 0x25DA4C0
        public void OnUpdate(){} // RVA: 0x25DA810
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x25DA8D0
    }

    public class VcamTargetPropertyAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xF48510
    }

}