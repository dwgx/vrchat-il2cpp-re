// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Avatars.Components
// Classes: 16
// Methods: 79

namespace VRC.SDK3.Avatars.Components
{
    public class VRCAccessoryDescriptor : AssetPart
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A482620
    }

    public class VRCAnimatorLayerControl : VRC_AnimatorLayerControl
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A47D310
    }

    public class VRCAnimatorLocomotionControl : VRC_AnimatorLocomotionControl
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81345B60
    }

    public class VRCAnimatorPlayAudio : VRC_AnimatorPlayAudio
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A47D320
    }

    public class VRCAnimatorTemporaryPoseSpace : VRC_AnimatorTemporaryPoseSpace
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A47D370
    }

    public class VRCAnimatorTrackingControl : VRC_AnimatorTrackingControl
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81345B60
    }

    public class VRCAvatarDescriptor : VRC_AvatarDescriptor
    {
        // ── Methods ──
        public void GetExpressionParameterCount(){} // RVA: 0x7FFE8A47D380
        public void GetExpressionParameter(){} // RVA: 0x7FFE8A47D480
        public void CalcHeadCollider(){} // RVA: 0x7FFE8A47D5A0
        public void CalcTorsoCollider(){} // RVA: 0x7FFE8A47E010
        public void CalcPalmCollider(){} // RVA: 0x7FFE8A47EAE0
        public void CalcFootCollider(){} // RVA: 0x7FFE8A47F900
        public void CalcFingerCollider(){} // RVA: 0x7FFE8A4800D0
        public void MaxScale(){} // RVA: 0x7FFE8A480720
        public void .ctor(){} // RVA: 0x7FFE8A480750
        public void <CalcPalmCollider>g__AddBone|37_0(){} // RVA: 0x7FFE8A4813A0
        public void <CalcFootCollider>g__FindEndBone|38_0(){} // RVA: 0x7FFE8A481530
    }

    public class VRCAvatarParameterDriver : VRC_AvatarParameterDriver
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A481B50
    }

    public class VRCHeadChop : MonoBehaviour
    {
        // ── Methods ──
        public void OnValidate(){} // RVA: 0x7FFE8A481C20
        public void Start(){} // RVA: 0x7FFE810FB310
        public void AppendDesiredTransformScaleFactors(){} // RVA: 0x7FFE8A481E10
        public void .ctor(){} // RVA: 0x7FFE8A4824A0
    }

    public class VRCImpostorEnvironment : MonoBehaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A4825C0
    }

    public class VRCImpostorSettings : MonoBehaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81103920
    }

    public class VRCPlayableLayerControl : VRC_PlayableLayerControl
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81345B60
    }

    public class VRCRaycast : MonoBehaviour
    {
        public UnityEngine.Vector3 raycastDirection; // 0x20
        public float distance; // 0x2C
        public bool applyTransformScale; // 0x30
        public 0x666CE4B4 collisionMode; // 0x34
        public UnityEngine.LayerMask customCollisionLayers; // 0x38
        public UnityEngine.LayerMask _worldLayerMask; // 0x3C
        public UnityEngine.LayerMask _playerLayerMask; // 0x40
        public UnityEngine.Transform _cachedTransform; // 0x48
        public UnityEngine.Transform resultTransform; // 0x50
        public bool applyRotation; // 0x58
        public UnityEngine.Vector3 alignmentAxis; // 0x5C
        public 0x666CE50C behaviorOnMiss; // 0x68
        public string parameter; // 0x70

        // ── Methods ──
        public void get_RaycastDirection(){} // RVA: 0x7FFE81161EE0
        public void set_RaycastDirection(){} // RVA: 0x7FFE81161F00
        public void get_Distance(){} // RVA: 0x7FFE812846C0
        public void set_Distance(){} // RVA: 0x7FFE8A47A820
        public void get_ApplyTransformScale(){} // RVA: 0x7FFE81121450
        public void set_ApplyTransformScale(){} // RVA: 0x7FFE81121460
        public void get_RaycastCollisionMode(){} // RVA: 0x7FFE82447220
        public void set_RaycastCollisionMode(){} // RVA: 0x7FFE82443340
        public void get_CustomCollisionLayers(){} // RVA: 0x7FFE81D46090
        public void set_CustomCollisionLayers(){} // RVA: 0x7FFE81D46A00
        public void get_ResultTransform(){} // RVA: 0x7FFE8119C0E0
        public void set_ResultTransform(){} // RVA: 0x7FFE812534D0
        public void get_ApplyRotation(){} // RVA: 0x7FFE813A1140
        public void set_ApplyRotation(){} // RVA: 0x7FFE819E83C0
        public void get_AlignmentAxis(){} // RVA: 0x7FFE8130C760
        public void set_AlignmentAxis(){} // RVA: 0x7FFE8A47A830
        public void get_BehaviorOnMiss(){} // RVA: 0x7FFE82A22EF0
        public void set_BehaviorOnMiss(){} // RVA: 0x7FFE82A22F00
        public void get_Parameter(){} // RVA: 0x7FFE811C3590
        public void set_Parameter(){} // RVA: 0x7FFE811C35A0
        public void get_CommandIndex(){} // RVA: 0x7FFE8194AD00
        public void set_CommandIndex(){} // RVA: 0x7FFE8194A400
        public void get_InitExternallyBlocked(){} // RVA: 0x7FFE820BD7B0
        public void set_InitExternallyBlocked(){} // RVA: 0x7FFE81A8B340
        public void get_EffectiveDistance(){} // RVA: 0x7FFE8A47A840
        public void Awake(){} // RVA: 0x7FFE8A47A9B0
        public void Start(){} // RVA: 0x7FFE8A47AB70
        public void VRC.Dynamics.IParameterSetup.InitParameters(){} // RVA: 0x7FFE8A47ABA0
        public void TriggerInitializeParameters(){} // RVA: 0x7FFE8A47ABB0
        public void OnEnable(){} // RVA: 0x7FFE8A47AC30
        public void OnDisable(){} // RVA: 0x7FFE8A47AC60
        public void Register(){} // RVA: 0x7FFE8A47AC70
        public void Unregister(){} // RVA: 0x7FFE8A47AC60
        public void PopulateRaycastCommand(){} // RVA: 0x7FFE8A47AC90
        public void CalculateWorldSpaceDirection(){} // RVA: 0x7FFE8A47AED0
        public void HandleRaycastResult(){} // RVA: 0x7FFE8A47B0F0
        public void SetResult(){} // RVA: 0x7FFE8A47B440
        public void SetAnimatorParameterValues(){} // RVA: 0x7FFE8A47B8D0
        public void IsFiniteVector(){} // RVA: 0x7FFE8A47B9B0
        public void OnDrawGizmosSelected(){} // RVA: 0x7FFE8A47B9D0
        public void .ctor(){} // RVA: 0x7FFE8A47BC70
        public void .cctor(){} // RVA: 0x7FFE8A47BD50
    }

    public class VRCRaycastHandler : Object
    {
        public System.Collections.Generic.List`1<VRC.SDK3.Avatars.Components.VRCRaycast> _activeRaycastComponents;

        // ── Methods ──
        public void get_ProcessingRaycasts(){} // RVA: 0x7FFE8A47BDC0
        public void Initialize(){} // RVA: 0x7FFE8A47BE00
        public void Uninitialize(){} // RVA: 0x7FFE8A47C260
        public void AddRaycaster(){} // RVA: 0x7FFE8A47C5B0
        public void RemoveRaycaster(){} // RVA: 0x7FFE8A47C710
        public void AddressPendingRaycasters(){} // RVA: 0x7FFE8A47C830
        public void EnsureBuffers(){} // RVA: 0x7FFE8A47CB60
        public void UpdateRaycastHandler(){} // RVA: 0x7FFE8A47CD90
        public void SubmitRaycasts(){} // RVA: 0x7FFE8A47CDE0
        public void CompleteRaycasts(){} // RVA: 0x7FFE8A47D140
    }

    public class VRCSpatialAudioSource : VRC_SpatialAudioSource
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A4427A0
    }

    public class VRCStation : VRCStation
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A44EFA0
    }

}