// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.UI.Elements
// Classes: 2
// Methods: 36

namespace VRC.UI.Elements
{
    public class MainMenuPlacementData : Object
    {
        public UnityEngine.Transform MenuPlacementZDepthVR; // 0x10
        public float ZDepthMovementSpeedMultiplier;
        public float ScaleContainer;
        public float LastLocalRotation;
        public float LastLocalLookRotation; // 0x18
        public UnityEngine.Quaternion MMDimensions; // 0x1C
        public System.Nullable`1<UnityEngine.Quaternion> VrPosition; // 0x2C
        public UnityEngine.Vector2 VrScale; // 0x40
        public UnityEngine.Vector3 DesktopPosition; // 0x48
        public UnityEngine.Vector3 <ÎÎÌÌÏÍÏÍÌÌÌÌÌÏÏÍÏÍÏÍÍÌÍ>k__BackingField; // 0x54

        // ── Methods ──
        public void get_MMDimensions(){} // RVA: 0x7FFAC9C12650
        public void get_VrPosition(){} // RVA: 0x7FFACB2EDD70
        public void get_MenuPlacementZDepthVR(){} // RVA: 0x7FFAC2F25CF0
        public void op_Implicit(){} // RVA: 0x7FFACB2EDD90
        public void CompareBaseObjects(){} // RVA: 0x7FFACB2EDE30
        public void get_velocity(){} // RVA: 0x7FFAC2F89480
        public void GetCachedPtr(){} // RVA: 0x7FFACB2EDE40
        public void set_LastLocalLookRotation(){} // RVA: 0x7FFACB2EDE30
        public void get_LastLocalLookRotation(){} // RVA: 0x7FFACB2EDE50
        public void set_MenuPlacementZDepthVR(){} // RVA: 0x7FFACB2EDE70
        public void get_VrScale(){} // RVA: 0x7FFAC88C6C50
        public void .ctor(){} // RVA: 0x7FFACB2EDEA0
        public void get_DesktopPosition(){} // RVA: 0x7FFAC2F89480
        public void set_LastLocalRotation(){} // RVA: 0x7FFACB2EDF80
        public void get_ScaleContainer(){} // RVA: 0x7FFAC2F3C380
        public void get_LastLocalRotation(){} // RVA: 0x7FFACB2EDF90
        public void Instantiate(){} // RVA: 0x7FFACB2EDE50
        public void set_ScaleContainer(){} // RVA: 0x7FFACB2EDFA0
        public void set_ZDepthMovementSpeedMultiplier(){} // RVA: 0x7FFACB2EE040
        public void Destroy(){} // RVA: 0x7FFACB2EE0E0
        public void Equals(){} // RVA: 0x7FFACB2EE180
        public void get_ZDepthMovementSpeedMultiplier(){} // RVA: 0x7FFACB2EE220
    }

    public class QuickMenuPlacer : Object
    {
        public UnityEngine.Transform MotionSmoothingEnabled; // 0x10
        public UnityEngine.Transform IsAttachedToHand; // 0x18
        public UnityEngine.Vector3 DesktopScale; // 0x20
        public UnityEngine.Vector3 _vrTwoHandedMenuPosL; // 0x2C
        public UnityEngine.Vector3 _vrTwoHandedMenuRotL; // 0x38
        public UnityEngine.Vector3 _vrTwoHandedMenuPosR; // 0x44
        public UnityEngine.Vector3 _vrTwoHandedMenuRotR; // 0x50
        public UnityEngine.Vector3 _vrTwoHandedMenuScale; // 0x5C
        public UnityEngine.Vector3 _vrOneHandedMenuPos; // 0x68
        public UnityEngine.Vector3 _vrOneHandedMenuRot; // 0x74
        public UnityEngine.Vector3 _vrOneHandedMenuScale; // 0x80
        public bool _menuWasPlaced; // 0x8C
        public bool _wasAttachedToHand; // 0x8D
        public bool <ÎÎÎÏÏÌÏÏÍÎÎÎÌÌÏÌÍÏÏÍÎÏÍ>k__BackingField; // 0x8E
        public float SMOOTHING_SPEED;
        public float SMOOTHING_MAX_DISTANCE;
        public float SMOOTHING_MAX_ANGLE;
        public float QM_WIDTH;
        public float QM_HEIGHT;

        // ── Methods ──
        public void get_IsDataHighConfidence(){} // RVA: 0x7FFAC3E03D30
        public void set_MotionSmoothingEnabled(){} // RVA: 0x7FFAC3E068E0
        public void get_MotionSmoothingEnabled(){} // RVA: 0x7FFAC3E03D30
        public void op_Implicit(){} // RVA: 0x7FFACB347A60
        public void .ctor(){} // RVA: 0x7FFACB347B90
        public void Initialize(){} // RVA: 0x7FFACB347D60
        public void get_DesktopScale(){} // RVA: 0x7FFACB347E20
        public void set_DesktopScale(){} // RVA: 0x7FFAC3E03D30
        public void set_IsAttachedToHand(){} // RVA: 0x7FFACB3480B0
        public void get_IsAttachedToHand(){} // RVA: 0x7FFACB348860
        public void Instantiate(){} // RVA: 0x7FFACB347D60
        public void Equals(){} // RVA: 0x7FFACB348990
        public void GetHashCode(){} // RVA: 0x7FFACB347D60
        public void ToString(){} // RVA: 0x7FFACB348C20
    }

}