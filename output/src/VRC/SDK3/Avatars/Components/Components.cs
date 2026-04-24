// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Avatars.Components
// Classes: 15
// Methods: 80

namespace VRC.SDK3.Avatars.Components
{
    public class VRCAnimatorLayerControl : VRC_AnimatorLayerControl
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD57437900
    }

    public class VRCAnimatorLocomotionControl : VRC_AnimatorLocomotionControl
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E54F5F0
    }

    public class VRCAnimatorPlayAudio : VRC_AnimatorPlayAudio
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD57437910
    }

    public class VRCAnimatorTemporaryPoseSpace : VRC_AnimatorTemporaryPoseSpace
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD57437960
    }

    public class VRCAnimatorTrackingControl : VRC_AnimatorTrackingControl
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E54F5F0
    }

    public class VRCAvatarDescriptor : VRC_AvatarDescriptor
    {
        public bool customExpressions; // 0xB8
        public VRC.SDK3.Avatars.ScriptableObjects.VRCExpressionsMenu expressionsMenu; // 0xC0
        public VRC.SDK3.Avatars.ScriptableObjects.VRCExpressionParameters expressionParameters; // 0xC8
        public bool enableEyeLook; // 0xD0
        public 0x66634098 customEyeLookSettings; // 0xD8
        public bool customizeAnimationLayers; // 0x170
        public 0x66633F38[] baseAnimationLayers; // 0x178
        public 0x66633F38[] specialAnimationLayers; // 0x180
        public UnityEngine.ScriptableObject AnimationPreset; // 0x188
        public System.Collections.Generic.List`1<Î> animationHashSet; // 0x190
        public bool autoFootsteps; // 0x198
        public bool autoLocomotion; // 0x199
        public float COLLIDER_MAX_SIZE;
        public 0x666341A0 collider_head; // 0x1A0
        public 0x666341A0 collider_torso; // 0x1D8
        public 0x666341A0 collider_footR; // 0x210
        public 0x666341A0 collider_footL; // 0x248
        public 0x666341A0 collider_handR; // 0x280
        public 0x666341A0 collider_handL; // 0x2B8
        public 0x666341A0 collider_fingerIndexL; // 0x2F0
        public 0x666341A0 collider_fingerMiddleL; // 0x328
        public 0x666341A0 collider_fingerRingL; // 0x360
        public 0x666341A0 collider_fingerLittleL; // 0x398
        public 0x666341A0 collider_fingerIndexR; // 0x3D0
        public 0x666341A0 collider_fingerMiddleR; // 0x408
        public 0x666341A0 collider_fingerRingR; // 0x440
        public 0x666341A0 collider_fingerLittleR; // 0x478

        // ── Methods ──
        public void GetExpressionParameterCount(){} // RVA: 0x7FFD57437970
        public void GetExpressionParameter(){} // RVA: 0x7FFD57437A70
        public void CalcHeadCollider(){} // RVA: 0x7FFD57437B90
        public void CalcTorsoCollider(){} // RVA: 0x7FFD574385C0
        public void CalcPalmCollider(){} // RVA: 0x7FFD57439070
        public void CalcFootCollider(){} // RVA: 0x7FFD57439E70
        public void CalcFingerCollider(){} // RVA: 0x7FFD5743A630
        public void MaxScale(){} // RVA: 0x7FFD54CC8C70
        public void .ctor(){} // RVA: 0x7FFD5743AC70
        public void <CalcPalmCollider>g__AddBone|37_0(){} // RVA: 0x7FFD5743B8C0
        public void <CalcFootCollider>g__FindEndBone|38_0(){} // RVA: 0x7FFD5743BA50
    }

    public class VRCAvatarParameterDriver : VRC_AvatarParameterDriver
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5743C070
    }

    public class VRCHeadChop : MonoBehaviour
    {
        public ÍÍÍÏÏÎÌÍÎÎÍÎÎÎÍÏÏÎÍÌÍÍÍ[] targetBones; // 0x20
        public float globalScaleFactor; // 0x28
        public int MaxBoneCount;
        public int MaxComponentCount;

        // ── Methods ──
        public void OnValidate(){} // RVA: 0x7FFD5743C140
        public void Start(){} // RVA: 0x7FFD4E341310
        public void AppendDesiredTransformScaleFactors(){} // RVA: 0x7FFD5743C330
        public void .ctor(){} // RVA: 0x7FFD5743C9C0
    }

    public class VRCImpostorEnvironment : MonoBehaviour
    {
        public UnityEngine.Color SkyColor; // 0x20
        public UnityEngine.Color EquatorColor; // 0x30
        public UnityEngine.Color GroundColor; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5743CAE0
    }

    public class VRCImpostorSettings : MonoBehaviour
    {
        public float resolutionScale; // 0x20
        public UnityEngine.Transform[] transformsToIgnore; // 0x28
        public UnityEngine.Transform[] extraChildTransforms; // 0x30
        public UnityEngine.Transform[] reparentHere; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E349920
    }

    public class VRCPlayableLayerControl : VRC_PlayableLayerControl
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E54F5F0
    }

    public class VRCRaycast : MonoBehaviour
    {
        public UnityEngine.Vector3 RaycastDirection; // 0x20
        public float Distance; // 0x2C
        public bool ApplyTransformScale; // 0x30
        public 0x66633B70 RaycastCollisionMode; // 0x34
        public UnityEngine.LayerMask CustomCollisionLayers; // 0x38
        public UnityEngine.LayerMask ResultTransform; // 0x3C
        public UnityEngine.LayerMask ApplyRotation; // 0x40
        public UnityEngine.Transform AlignmentAxis; // 0x48
        public UnityEngine.Transform DisableOnMiss; // 0x50
        public bool BehaviorOnMiss; // 0x58
        public UnityEngine.Vector3 Parameter; // 0x5C
        public bool CommandIndex; // 0x68
        public 0x66633BC8 InitExternallyBlocked; // 0x6C
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
        public void get_RaycastDirection(){} // RVA: 0x7FFD4E3A7EE0
        public void set_RaycastDirection(){} // RVA: 0x7FFD4E3A7F00
        public void get_Distance(){} // RVA: 0x7FFD4E80AB80
        public void set_Distance(){} // RVA: 0x7FFD57434F70
        public void get_ApplyTransformScale(){} // RVA: 0x7FFD4E367450
        public void set_ApplyTransformScale(){} // RVA: 0x7FFD4E367460
        public void get_RaycastCollisionMode(){} // RVA: 0x7FFD4EEFEDC0
        public void set_RaycastCollisionMode(){} // RVA: 0x7FFD4F58A6E0
        public void get_CustomCollisionLayers(){} // RVA: 0x7FFD4E9AA870
        public void set_CustomCollisionLayers(){} // RVA: 0x7FFD4E9A8350
        public void get_ResultTransform(){} // RVA: 0x7FFD4E3E20E0
        public void set_ResultTransform(){} // RVA: 0x7FFD4E4994D0
        public void get_ApplyRotation(){} // RVA: 0x7FFD4E55F600
        public void set_ApplyRotation(){} // RVA: 0x7FFD4ECB2770
        public void get_AlignmentAxis(){} // RVA: 0x7FFD4FB5BBC0
        public void set_AlignmentAxis(){} // RVA: 0x7FFD57434F80
        public void get_DisableOnMiss(){} // RVA: 0x7FFD4E409570
        public void set_DisableOnMiss(){} // RVA: 0x7FFD4E409580
        public void get_BehaviorOnMiss(){} // RVA: 0x7FFD4FBDAB70
        public void set_BehaviorOnMiss(){} // RVA: 0x7FFD4FBDAB80
        public void get_Parameter(){} // RVA: 0x7FFD4E409590
        public void set_Parameter(){} // RVA: 0x7FFD4E4095A0
        public void get_CommandIndex(){} // RVA: 0x7FFD4EC0E8C0
        public void set_CommandIndex(){} // RVA: 0x7FFD4EC19DE0
        public void get_InitExternallyBlocked(){} // RVA: 0x7FFD4F22ACA0
        public void set_InitExternallyBlocked(){} // RVA: 0x7FFD4ED6D600
        public void get_EffectiveDistance(){} // RVA: 0x7FFD57434F90
        public void Awake(){} // RVA: 0x7FFD57435100
        public void Start(){} // RVA: 0x7FFD574352C0
        public void VRC.Dynamics.IParameterSetup.InitParameters(){} // RVA: 0x7FFD574352F0
        public void TriggerInitializeParameters(){} // RVA: 0x7FFD57435300
        public void OnEnable(){} // RVA: 0x7FFD57435380
        public void OnDisable(){} // RVA: 0x7FFD574353B0
        public void Register(){} // RVA: 0x7FFD574353C0
        public void Unregister(){} // RVA: 0x7FFD574353B0
        public void PopulateRaycastCommand(){} // RVA: 0x7FFD574353E0
        public void CalculateWorldSpaceDirection(){} // RVA: 0x7FFD57435620
        public void HandleRaycastResult(){} // RVA: 0x7FFD57435840
        public void SetResult(){} // RVA: 0x7FFD57435C60
        public void SetAnimatorParameterValues(){} // RVA: 0x7FFD574360F0
        public void IsFiniteVector(){} // RVA: 0x7FFD574361D0
        public void OnDrawGizmosSelected(){} // RVA: 0x7FFD574361F0
        public void .ctor(){} // RVA: 0x7FFD57436490
        public void .cctor(){} // RVA: 0x7FFD57436570
    }

    public class VRCRaycastHandler : Object
    {
        public System.Collections.Generic.List`1<VRC.SDK3.Avatars.Components.VRCRaycast> ProcessingRaycasts;
        public System.Collections.Generic.HashSet`1<VRC.SDK3.Avatars.Components.VRCRaycast> _pendingAddSet; // 0x8
        public System.Collections.Generic.HashSet`1<VRC.SDK3.Avatars.Components.VRCRaycast> _pendingRemoveSet; // 0x10
        public Unity.Jobs.JobHandle _batchHandle; // 0x18
        public Unity.Collections.NativeArray`1<ÏÎÌÏÌÎÏÍ> _commandBuffer; // 0x28
        public Unity.Collections.NativeArray`1<UnityEngine.RaycastHit> _resultBuffer; // 0x38
        public int _currentBatchSize; // 0x48
        public int _bufferCapacity; // 0x4C
        public bool _isDisposed; // 0x50

        // ── Methods ──
        public void get_ProcessingRaycasts(){} // RVA: 0x7FFD574365E0
        public void Initialize(){} // RVA: 0x7FFD57436620
        public void Uninitialize(){} // RVA: 0x7FFD57436970
        public void AddRaycaster(){} // RVA: 0x7FFD57436BA0
        public void RemoveRaycaster(){} // RVA: 0x7FFD57436D00
        public void AddressPendingRaycasters(){} // RVA: 0x7FFD57436E20
        public void EnsureBuffers(){} // RVA: 0x7FFD57437150
        public void UpdateRaycastHandler(){} // RVA: 0x7FFD57437380
        public void SubmitRaycasts(){} // RVA: 0x7FFD574373D0
        public void CompleteRaycasts(){} // RVA: 0x7FFD57437730
    }

    public class VRCSpatialAudioSource : VRC_SpatialAudioSource
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD57401C30
    }

    public class VRCStation : VRCStation
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5740E430
    }

}