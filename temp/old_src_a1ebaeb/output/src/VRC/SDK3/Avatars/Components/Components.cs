// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Avatars.Components
// Classes: 15
// Methods: 56

namespace VRC.SDK3.Avatars.Components
{
    public class VRCAnimatorLayerControl : VRC_AnimatorLayerControl
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffab1a332f0
    }

    public class VRCAnimatorLocomotionControl : VRC_AnimatorLocomotionControl
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8b59ae0
    }

    public class VRCAnimatorPlayAudio : VRC_AnimatorPlayAudio
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffab1a33300
    }

    public class VRCAnimatorTemporaryPoseSpace : VRC_AnimatorTemporaryPoseSpace
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffab1a33350
    }

    public class VRCAnimatorTrackingControl : VRC_AnimatorTrackingControl
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8b59ae0
    }

    public class VRCAvatarDescriptor : VRC_AvatarDescriptor
    {
        public object expressionParameters; // 0x33D07930
        public object customizeAnimationLayers; // 0x33D07930
        public object AnimationPreset; // 0x33D07930
        public object autoLocomotion; // 0x33D07930
        public object collider_torso; // 0x33D07930
        public object collider_handR; // 0x33D07930
        public object collider_fingerMiddleL; // 0x33D07930
        public object collider_fingerIndexR; // 0x33D07930
        public object collider_fingerLittleR; // 0x33D07930
        public object rightEye; // 0x81165170
        public object eyesLookingDown; // 0x81165170
        public object eyelidType; // 0x81165170
        public object lowerLeftEyelid; // 0x81165170

        // ── Original Methods ──
        public void CalcHeadCollider(){} // RVA: 0x7ffab1a33580
        public void CalcTorsoCollider(){} // RVA: 0x7ffab1a33fb0
        public void CalcPalmCollider(){} // RVA: 0x7ffab1a34a60
        public void CalcFootCollider(){} // RVA: 0x7ffab1a35860
        public void CalcFingerCollider(){} // RVA: 0x7ffab1a36020
        public void MaxScale(){} // RVA: 0x7ffaaf2cabd0
        public void .ctor(){} // RVA: 0x7ffab1a36660
        public void <CalcPalmCollider>g__AddBone|37_0(){} // RVA: 0x7ffab1a372b0
        public void <CalcFootCollider>g__FindEndBone|38_0(){} // RVA: 0x7ffab1a37440
        // ── Binary Analysis Named ──
        public void GetExpressionParameterCount(){} // RVA: 0x7ffab1a33360
        public void GetExpressionParameter(){} // RVA: 0x7ffab1a33460
    }

    public class VRCAvatarParameterDriver : VRC_AvatarParameterDriver
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffab1a37a60
    }

    public class VRCHeadChop : MonoBehaviour
    {
        public object MaxBoneCount; // 0x331E0220

        // ── Original Methods ──
        public void OnValidate(){} // RVA: 0x7ffab1a37b30
        public void Start(){} // RVA: 0x7ffaa8932310
        public void AppendDesiredTransformScaleFactors(){} // RVA: 0x7ffab1a37d20
        public void .ctor(){} // RVA: 0x7ffab1a383b0
    }

    public class VRCImpostorEnvironment : MonoBehaviour
    {
        public object GroundColor; // 0x33D06B20

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffab1a384d0
    }

    public class VRCImpostorSettings : MonoBehaviour
    {
        public object extraChildTransforms; // 0x33D206B0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa893a920
    }

    public class VRCPlayableLayerControl : VRC_PlayableLayerControl
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8b59ae0
    }

    public class VRCRaycast : MonoBehaviour
    {
        public object collisionMode; // 0x33D22980
        public object _playerLayerMask; // 0x33D22980
        public object applyRotation; // 0x33D22980
        public object positioningOnMiss; // 0x33D22980
        public object _defaultPhysicsScene; // 0x33D22980
        public object _initExternallyBlocked; // 0x33D22980, was: <InitExternallyBlocked>k__Back
        public object VRC.SDKBase.Validation.Performance.IVRCRaycast.CommandIndex; // 0x17000002
        public object InitExternallyBlocked; // 0x17000003
        public object EffectiveDistance; // 0x17000004
        public object H00; // 0x40000A3
        public object H00; // 0x3024EA20

        // ── Original Methods ──
        public void VRC.SDKBase.Validation.Performance.IVRCRaycast.get_CommandIndex(){} // RVA: 0x7ffaa9e03940
        public void VRC.SDKBase.Validation.Performance.IVRCRaycast.set_CommandIndex(){} // RVA: 0x7ffaaa2bddd0
        public void get_InitExternallyBlocked(){} // RVA: 0x7ffaa8dfe0d0
        public void set_InitExternallyBlocked(){} // RVA: 0x7ffaa8dfa560
        public void get_EffectiveDistance(){} // RVA: 0x7ffab1a30c40
        public void OnValidate(){} // RVA: 0x7ffab1a30c80
        public void Awake(){} // RVA: 0x7ffab1a30cb0
        public void Start(){} // RVA: 0x7ffab1a30e70
        public void OnEnable(){} // RVA: 0x7ffab1a30ea0
        public void OnDisable(){} // RVA: 0x7ffab1a30ec0
        public void Register(){} // RVA: 0x7ffab1a30ed0
        public void Unregister(){} // RVA: 0x7ffab1a30ec0
        public void VRC.SDKBase.Validation.Performance.IVRCRaycast.PopulateRaycastCommand(){} // RVA: 0x7ffab1a30ee0
        public void CalculateWorldSpaceDirection(){} // RVA: 0x7ffab1a31130
        public void VRC.SDKBase.Validation.Performance.IVRCRaycast.HandleRaycastResult(){} // RVA: 0x7ffab1a31350
        public void IsFiniteVector(){} // RVA: 0x7ffab1a31a50
        public void OnDrawGizmosSelected(){} // RVA: 0x7ffab1a31a70
        public void .ctor(){} // RVA: 0x7ffab1a31d30
        public void .cctor(){} // RVA: 0x7ffab1a31e10
        // ── Binary Analysis Named ──
        public void SetResult(){} // RVA: 0x7ffab1a31620
    }

    public class VRCRaycastHandler : Object
    {
        public object _pendingRemoveSet; // 0x35E935D0
        public object _resultBuffer; // 0x35E935D0
        public object _isDisposed; // 0x35E935D0

        // ── Original Methods ──
        public void get_ProcessingRaycasts(){} // RVA: 0x7ffab1a31e80
        public void Initialize(){} // RVA: 0x7ffab1a31ec0
        public void Uninitialize(){} // RVA: 0x7ffab1a32210
        public void AddRaycaster(){} // RVA: 0x7ffab1a32410
        public void RemoveRaycaster(){} // RVA: 0x7ffab1a32570
        public void AddressPendingRaycasters(){} // RVA: 0x7ffab1a32690
        public void EnsureBuffers(){} // RVA: 0x7ffab1a329c0
        public void UpdateRaycastHandler(){} // RVA: 0x7ffab1a32bf0
        public void SubmitRaycasts(){} // RVA: 0x7ffab1a32c40
        public void CompleteRaycasts(){} // RVA: 0x7ffab1a33070
    }

    public class VRCSpatialAudioSource : VRC_SpatialAudioSource
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffab19fd900
    }

    public class VRCStation : VRCStation
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffab1a0a100
    }

}