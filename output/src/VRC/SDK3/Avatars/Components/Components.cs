// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Avatars.Components
// Classes: 16
// Methods: 79

namespace VRC.SDK3.Avatars.Components
{
    public class VRCAccessoryDescriptor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9A26E60
    }

    public class VRCAnimatorLayerControl
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9A21B50
    }

    public class VRCAnimatorLocomotionControl
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x53BFB0
    }

    public class VRCAnimatorPlayAudio
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9A21B60
    }

    public class VRCAnimatorTemporaryPoseSpace
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9A21BB0
    }

    public class VRCAnimatorTrackingControl
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x53BFB0
    }

    public class VRCAvatarDescriptor
    {
        // ── Methods ──
        public void GetExpressionParameterCount(){} // RVA: 0x9A21BC0
        public void GetExpressionParameter(){} // RVA: 0x9A21CC0
        public void CalcHeadCollider(){} // RVA: 0x9A21DE0
        public void CalcTorsoCollider(){} // RVA: 0x9A22850
        public void CalcPalmCollider(){} // RVA: 0x9A23320
        public void CalcFootCollider(){} // RVA: 0x9A24140
        public void CalcFingerCollider(){} // RVA: 0x9A24910
        public void MaxScale(){} // RVA: 0x9A24F60
        public void .ctor(){} // RVA: 0x9A24F90
        public void <CalcPalmCollider>g__AddBone|37_0(){} // RVA: 0x9A25BE0
        public void <CalcFootCollider>g__FindEndBone|38_0(){} // RVA: 0x9A25D70
    }

    public class VRCAvatarParameterDriver
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9A26390
    }

    public class VRCHeadChop
    {
        // ── Methods ──
        public void OnValidate(){} // RVA: 0x9A26460
        public void Start(){} // RVA: 0x2DD310
        public void AppendDesiredTransformScaleFactors(){} // RVA: 0x9A26650
        public void .ctor(){} // RVA: 0x9A26CE0
    }

    public class VRCImpostorEnvironment
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9A26E00
    }

    public class VRCImpostorSettings
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2E5920
    }

    public class VRCPlayableLayerControl
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x53BFB0
    }

    public class VRCRaycast
    {
        public UnityEngine.Vector3 raycastDirection; // 0x20
        public float distance; // 0x2C
        public bool applyTransformScale; // 0x30
        public 0x659F6A20 collisionMode; // 0x34
        public UnityEngine.LayerMask customCollisionLayers; // 0x38
        public UnityEngine.LayerMask _worldLayerMask; // 0x3C
        public UnityEngine.LayerMask _playerLayerMask; // 0x40
        public UnityEngine.Transform _cachedTransform; // 0x48
        public UnityEngine.Transform resultTransform; // 0x50
        public bool applyRotation; // 0x58
        public UnityEngine.Vector3 alignmentAxis; // 0x5C
        public 0x659F6A78 behaviorOnMiss; // 0x68
        public string parameter; // 0x70

        // ── Methods ──
        public void get_RaycastDirection(){} // RVA: 0x343EE0
        public void set_RaycastDirection(){} // RVA: 0x343F00
        public void get_Distance(){} // RVA: 0x4652A0
        public void set_Distance(){} // RVA: 0x9A1F060
        public void get_ApplyTransformScale(){} // RVA: 0x303450
        public void set_ApplyTransformScale(){} // RVA: 0x303460
        public void get_RaycastCollisionMode(){} // RVA: 0x4C6670
        public void set_RaycastCollisionMode(){} // RVA: 0x4C5F20
        public void get_CustomCollisionLayers(){} // RVA: 0xFDC9F0
        public void set_CustomCollisionLayers(){} // RVA: 0xFDD6E0
        public void get_ResultTransform(){} // RVA: 0x37E0E0
        public void set_ResultTransform(){} // RVA: 0x4354D0
        public void get_ApplyRotation(){} // RVA: 0x59FF30
        public void set_ApplyRotation(){} // RVA: 0xC5F680
        public void get_AlignmentAxis(){} // RVA: 0x4FA510
        public void set_AlignmentAxis(){} // RVA: 0x9A1F070
        public void get_BehaviorOnMiss(){} // RVA: 0x1C91440
        public void set_BehaviorOnMiss(){} // RVA: 0x1C91450
        public void get_Parameter(){} // RVA: 0x3A5590
        public void set_Parameter(){} // RVA: 0x3A55A0
        public void get_CommandIndex(){} // RVA: 0xBB90C0
        public void set_CommandIndex(){} // RVA: 0xBB9E60
        public void get_InitExternallyBlocked(){} // RVA: 0x1344120
        public void set_InitExternallyBlocked(){} // RVA: 0xD1F6A0
        public void get_EffectiveDistance(){} // RVA: 0x9A1F080
        public void Awake(){} // RVA: 0x9A1F1F0
        public void Start(){} // RVA: 0x9A1F3B0
        public void VRC.Dynamics.IParameterSetup.InitParameters(){} // RVA: 0x9A1F3E0
        public void TriggerInitializeParameters(){} // RVA: 0x9A1F3F0
        public void OnEnable(){} // RVA: 0x9A1F470
        public void OnDisable(){} // RVA: 0x9A1F4A0
        public void Register(){} // RVA: 0x9A1F4B0
        public void Unregister(){} // RVA: 0x9A1F4A0
        public void PopulateRaycastCommand(){} // RVA: 0x9A1F4D0
        public void CalculateWorldSpaceDirection(){} // RVA: 0x9A1F710
        public void HandleRaycastResult(){} // RVA: 0x9A1F930
        public void SetResult(){} // RVA: 0x9A1FC80
        public void SetAnimatorParameterValues(){} // RVA: 0x9A20110
        public void IsFiniteVector(){} // RVA: 0x9A201F0
        public void OnDrawGizmosSelected(){} // RVA: 0x9A20210
        public void .ctor(){} // RVA: 0x9A204B0
        public void .cctor(){} // RVA: 0x9A20590
    }

    public class VRCRaycastHandler
    {
        public System.Collections.Generic.List`1<VRC.SDK3.Avatars.Components.VRCRaycast> _activeRaycastComponents;

        // ── Methods ──
        public void get_ProcessingRaycasts(){} // RVA: 0x9A20600
        public void Initialize(){} // RVA: 0x9A20640
        public void Uninitialize(){} // RVA: 0x9A20AA0
        public void AddRaycaster(){} // RVA: 0x9A20DF0
        public void RemoveRaycaster(){} // RVA: 0x9A20F50
        public void AddressPendingRaycasters(){} // RVA: 0x9A21070
        public void EnsureBuffers(){} // RVA: 0x9A213A0
        public void UpdateRaycastHandler(){} // RVA: 0x9A215D0
        public void SubmitRaycasts(){} // RVA: 0x9A21620
        public void CompleteRaycasts(){} // RVA: 0x9A21980
    }

    public class VRCSpatialAudioSource
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x99E6D70
    }

    public class VRCStation
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x99F3570
    }

}