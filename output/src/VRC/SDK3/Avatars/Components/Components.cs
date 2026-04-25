// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Avatars.Components
// Classes: 15
// Methods: 80

namespace VRC.SDK3.Avatars.Components
{
    public class VRCAnimatorLayerControl : VRC_AnimatorLayerControl
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACC017900
    }

    public class VRCAnimatorLocomotionControl : VRC_AnimatorLocomotionControl
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC312F5F0
    }

    public class VRCAnimatorPlayAudio : VRC_AnimatorPlayAudio
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACC017910
    }

    public class VRCAnimatorTemporaryPoseSpace : VRC_AnimatorTemporaryPoseSpace
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACC017960
    }

    public class VRCAnimatorTrackingControl : VRC_AnimatorTrackingControl
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC312F5F0
    }

    public class VRCAvatarDescriptor : VRC_AvatarDescriptor
    {
        public bool customExpressions; // 0xB8
        public VRC.SDK3.Avatars.ScriptableObjects.VRCExpressionsMenu expressionsMenu; // 0xC0
        public VRC.SDK3.Avatars.ScriptableObjects.VRCExpressionParameters expressionParameters; // 0xC8
        public bool enableEyeLook; // 0xD0
        public CustomEyeLookSettings customEyeLookSettings; // 0xD8
        public bool customizeAnimationLayers; // 0x170
        public CustomAnimLayer[] baseAnimationLayers; // 0x178
        public CustomAnimLayer[] specialAnimationLayers; // 0x180
        public UnityEngine.ScriptableObject AnimationPreset; // 0x188
        public System.Collections.Generic.List`1<DebugHash> animationHashSet; // 0x190
        public bool autoFootsteps; // 0x198
        public bool autoLocomotion; // 0x199
        public float COLLIDER_MAX_SIZE;
        public ColliderConfig collider_head; // 0x1A0
        public ColliderConfig collider_torso; // 0x1D8
        public ColliderConfig collider_footR; // 0x210
        public ColliderConfig collider_footL; // 0x248
        public ColliderConfig collider_handR; // 0x280
        public ColliderConfig collider_handL; // 0x2B8
        public ColliderConfig collider_fingerIndexL; // 0x2F0
        public ColliderConfig collider_fingerMiddleL; // 0x328
        public ColliderConfig collider_fingerRingL; // 0x360
        public ColliderConfig collider_fingerLittleL; // 0x398
        public ColliderConfig collider_fingerIndexR; // 0x3D0
        public ColliderConfig collider_fingerMiddleR; // 0x408
        public ColliderConfig collider_fingerRingR; // 0x440
        public ColliderConfig collider_fingerLittleR; // 0x478

        // ── Methods ──
        public void GetExpressionParameterCount(){} // RVA: 0x7FFACC017970
        public void GetExpressionParameter(){} // RVA: 0x7FFACC017A70
        public void CalcHeadCollider(){} // RVA: 0x7FFACC017B90
        public void CalcTorsoCollider(){} // RVA: 0x7FFACC0185C0
        public void CalcPalmCollider(){} // RVA: 0x7FFACC019070
        public void CalcFootCollider(){} // RVA: 0x7FFACC019E70
        public void CalcFingerCollider(){} // RVA: 0x7FFACC01A630
        public void MaxScale(){} // RVA: 0x7FFAC98A8C70
        public void .ctor(){} // RVA: 0x7FFACC01AC70
        public void <CalcPalmCollider>g__AddBone|37_0(){} // RVA: 0x7FFACC01B8C0
        public void <CalcFootCollider>g__FindEndBone|38_0(){} // RVA: 0x7FFACC01BA50
    }

    public class VRCAvatarParameterDriver : VRC_AvatarParameterDriver
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACC01C070
    }

    public class VRCHeadChop : MonoBehaviour
    {
        public HeadChopBone[] targetBones; // 0x20
        public float globalScaleFactor; // 0x28
        public int MaxBoneCount;
        public int MaxComponentCount;

        // ── Methods ──
        public void OnValidate(){} // RVA: 0x7FFACC01C140
        public void Start(){} // RVA: 0x7FFAC2F21310
        public void AppendDesiredTransformScaleFactors(){} // RVA: 0x7FFACC01C330
        public void .ctor(){} // RVA: 0x7FFACC01C9C0
    }

    public class VRCImpostorEnvironment : MonoBehaviour
    {
        public UnityEngine.Color SkyColor; // 0x20
        public UnityEngine.Color EquatorColor; // 0x30
        public UnityEngine.Color GroundColor; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACC01CAE0
    }

    public class VRCImpostorSettings : MonoBehaviour
    {
        public float resolutionScale; // 0x20
        public UnityEngine.Transform[] transformsToIgnore; // 0x28
        public UnityEngine.Transform[] extraChildTransforms; // 0x30
        public UnityEngine.Transform[] reparentHere; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F29920
    }

    public class VRCPlayableLayerControl : VRC_PlayableLayerControl
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC312F5F0
    }

    public class VRCRaycast : MonoBehaviour
    {
        public UnityEngine.Vector3 RaycastDirection; // 0x20
        public float Distance; // 0x2C
        public bool ApplyTransformScale; // 0x30
        public 0x6B2D3B70 RaycastCollisionMode; // 0x34
        public UnityEngine.LayerMask CustomCollisionLayers; // 0x38
        public UnityEngine.LayerMask ResultTransform; // 0x3C
        public UnityEngine.LayerMask ApplyRotation; // 0x40
        public UnityEngine.Transform AlignmentAxis; // 0x48
        public UnityEngine.Transform DisableOnMiss; // 0x50
        public bool BehaviorOnMiss; // 0x58
        public UnityEngine.Vector3 Parameter; // 0x5C
        public bool CommandIndex; // 0x68
        public 0x6B2D3BC8 InitExternallyBlocked; // 0x6C
        public string EffectiveDistance; // 0x70
        public bool _hasInitializedAnimatorParameters; // 0x78
        public UnityEngine.Vector3 _submittedWorldSpaceDirection; // 0x7C
        public float MaximumAllowedDistance;
        public UnityEngine.PhysicsScene _defaultPhysicsScene;
        public int <CommandIndex>k__BackingField; // 0x88
        public bool _startCompleted; // 0x8C
        public bool <InitExternallyBlocked>k__BackingField; // 0x8D
        public System.Action`1<VRC.SDK3.Avatars.Components.VRCRaycast> OnInitializeParameters; // 0x8
        public string PARAM_HIT;
        public string PARAM_RATIO;
        public string PARAM_DISTANCE;
        public bool param_HitValue; // 0x8E
        public VRC.SDKBase.IAnimParameterAccess param_Hit; // 0x90
        public float param_RatioValue; // 0x98
        public VRC.SDKBase.IAnimParameterAccess param_Ratio; // 0xA0
        public float param_DistanceValue; // 0xA8
        public VRC.SDKBase.IAnimParameterAccess param_Distance; // 0xB0

        // ── Methods ──
        public void get_RaycastDirection(){} // RVA: 0x7FFAC2F87EE0
        public void set_RaycastDirection(){} // RVA: 0x7FFAC2F87F00
        public void get_Distance(){} // RVA: 0x7FFAC33EAB80
        public void set_Distance(){} // RVA: 0x7FFACC014F70
        public void get_ApplyTransformScale(){} // RVA: 0x7FFAC2F47450
        public void set_ApplyTransformScale(){} // RVA: 0x7FFAC2F47460
        public void get_RaycastCollisionMode(){} // RVA: 0x7FFAC3ADEDC0
        public void set_RaycastCollisionMode(){} // RVA: 0x7FFAC416A6E0
        public void get_CustomCollisionLayers(){} // RVA: 0x7FFAC358A870
        public void set_CustomCollisionLayers(){} // RVA: 0x7FFAC3588350
        public void get_ResultTransform(){} // RVA: 0x7FFAC2FC20E0
        public void set_ResultTransform(){} // RVA: 0x7FFAC30794D0
        public void get_ApplyRotation(){} // RVA: 0x7FFAC313F600
        public void set_ApplyRotation(){} // RVA: 0x7FFAC3892770
        public void get_AlignmentAxis(){} // RVA: 0x7FFAC473BBC0
        public void set_AlignmentAxis(){} // RVA: 0x7FFACC014F80
        public void get_DisableOnMiss(){} // RVA: 0x7FFAC2FE9570
        public void set_DisableOnMiss(){} // RVA: 0x7FFAC2FE9580
        public void get_BehaviorOnMiss(){} // RVA: 0x7FFAC47BAB70
        public void set_BehaviorOnMiss(){} // RVA: 0x7FFAC47BAB80
        public void get_Parameter(){} // RVA: 0x7FFAC2FE9590
        public void set_Parameter(){} // RVA: 0x7FFAC2FE95A0
        public void get_CommandIndex(){} // RVA: 0x7FFAC37EE8C0
        public void set_CommandIndex(){} // RVA: 0x7FFAC37F9DE0
        public void get_InitExternallyBlocked(){} // RVA: 0x7FFAC3E0ACA0
        public void set_InitExternallyBlocked(){} // RVA: 0x7FFAC394D600
        public void get_EffectiveDistance(){} // RVA: 0x7FFACC014F90
        public void Awake(){} // RVA: 0x7FFACC015100
        public void Start(){} // RVA: 0x7FFACC0152C0
        public void VRC.Dynamics.IParameterSetup.InitParameters(){} // RVA: 0x7FFACC0152F0
        public void TriggerInitializeParameters(){} // RVA: 0x7FFACC015300
        public void OnEnable(){} // RVA: 0x7FFACC015380
        public void OnDisable(){} // RVA: 0x7FFACC0153B0
        public void Register(){} // RVA: 0x7FFACC0153C0
        public void Unregister(){} // RVA: 0x7FFACC0153B0
        public void PopulateRaycastCommand(){} // RVA: 0x7FFACC0153E0
        public void CalculateWorldSpaceDirection(){} // RVA: 0x7FFACC015620
        public void HandleRaycastResult(){} // RVA: 0x7FFACC015840
        public void SetResult(){} // RVA: 0x7FFACC015C60
        public void SetAnimatorParameterValues(){} // RVA: 0x7FFACC0160F0
        public void IsFiniteVector(){} // RVA: 0x7FFACC0161D0
        public void OnDrawGizmosSelected(){} // RVA: 0x7FFACC0161F0
        public void .ctor(){} // RVA: 0x7FFACC016490
        public void .cctor(){} // RVA: 0x7FFACC016570
    }

    public class VRCRaycastHandler : Object
    {
        public System.Collections.Generic.List`1<VRC.SDK3.Avatars.Components.VRCRaycast> ProcessingRaycasts;
        public System.Collections.Generic.HashSet`1<VRC.SDK3.Avatars.Components.VRCRaycast> _pendingAddSet; // 0x8
        public System.Collections.Generic.HashSet`1<VRC.SDK3.Avatars.Components.VRCRaycast> _pendingRemoveSet; // 0x10
        public Unity.Jobs.JobHandle _batchHandle; // 0x18
        public Unity.Collections.NativeArray`1<UnityEngine.RaycastCommand> _commandBuffer; // 0x28
        public Unity.Collections.NativeArray`1<UnityEngine.RaycastHit> _resultBuffer; // 0x38
        public int _currentBatchSize; // 0x48
        public int _bufferCapacity; // 0x4C
        public bool _isDisposed; // 0x50

        // ── Methods ──
        public void get_ProcessingRaycasts(){} // RVA: 0x7FFACC0165E0
        public void Initialize(){} // RVA: 0x7FFACC016620
        public void Uninitialize(){} // RVA: 0x7FFACC016970
        public void AddRaycaster(){} // RVA: 0x7FFACC016BA0
        public void RemoveRaycaster(){} // RVA: 0x7FFACC016D00
        public void AddressPendingRaycasters(){} // RVA: 0x7FFACC016E20
        public void EnsureBuffers(){} // RVA: 0x7FFACC017150
        public void UpdateRaycastHandler(){} // RVA: 0x7FFACC017380
        public void SubmitRaycasts(){} // RVA: 0x7FFACC0173D0
        public void CompleteRaycasts(){} // RVA: 0x7FFACC017730
    }

    public class VRCSpatialAudioSource : VRC_SpatialAudioSource
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBFE1C30
    }

    public class VRCStation : VRCStation
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBFEE430
    }

}