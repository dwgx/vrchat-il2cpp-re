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
        public terfaces.IUdonVariable.Value.VariableType expressionsMenu; // 0xC0
        public terfaces.IUdonVariable.Value.lName expressionParameters; // 0xC8
        public bool enableEyeLook; // 0xD0
        public eLoggers customEyeLookSettings; // 0xD8
        public bool customizeAnimationLayers; // 0x170
        public Loggers[] baseAnimationLayers; // 0x178
        public Loggers[] specialAnimationLayers; // 0x180
        public ge AnimationPreset; // 0x188
        public URA.woDigitYearMax<ion> animationHashSet; // 0x190
        public bool autoFootsteps; // 0x198
        public bool autoLocomotion; // 0x199
        public float COLLIDER_MAX_SIZE;
        public Loggers collider_head; // 0x1A0
        public Loggers collider_torso; // 0x1D8
        public Loggers collider_footR; // 0x210
        public Loggers collider_footL; // 0x248
        public Loggers collider_handR; // 0x280
        public Loggers collider_handL; // 0x2B8
        public Loggers collider_fingerIndexL; // 0x2F0
        public Loggers collider_fingerMiddleL; // 0x328
        public Loggers collider_fingerRingL; // 0x360
        public Loggers collider_fingerLittleL; // 0x398
        public Loggers collider_fingerIndexR; // 0x3D0
        public Loggers collider_fingerMiddleR; // 0x408
        public Loggers collider_fingerRingR; // 0x440
        public Loggers collider_fingerLittleR; // 0x478

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
        public ?[] targetBones; // 0x20
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
        public object SkyColor; // 0x20
        public object EquatorColor; // 0x30
        public object GroundColor; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5743CAE0
    }

    public class VRCImpostorSettings : MonoBehaviour
    {
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
        public object RaycastDirection;
        public object Distance;
        public object ApplyTransformScale;
        public object RaycastCollisionMode;
        public object CustomCollisionLayers;
        public object ResultTransform;
        public object ApplyRotation;
        public object AlignmentAxis;
        public object DisableOnMiss;
        public object BehaviorOnMiss;
        public object Parameter;
        public object CommandIndex;
        public object InitExternallyBlocked;
        public object EffectiveDistance;

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
        public object ProcessingRaycasts;

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