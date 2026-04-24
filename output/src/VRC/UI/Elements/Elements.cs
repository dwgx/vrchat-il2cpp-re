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
        public UnityEngine.Vector3 <ÌÎÎÎÎÍÎÏÏÎÌÍÌÌÎÌÏÎÎÎÍÌÍ>k__BackingField; // 0x54

        // ── Methods ──
        public void get_MMDimensions(){} // RVA: 0x7FFD55032650
        public void get_VrPosition(){} // RVA: 0x7FFD5670DD70
        public void get_MenuPlacementZDepthVR(){} // RVA: 0x7FFD4E345CF0
        public void op_Implicit(){} // RVA: 0x7FFD5670DD90
        public void CompareBaseObjects(){} // RVA: 0x7FFD5670DE30
        public void get_velocity(){} // RVA: 0x7FFD4E3A9480
        public void GetCachedPtr(){} // RVA: 0x7FFD5670DE40
        public void set_LastLocalLookRotation(){} // RVA: 0x7FFD5670DE30
        public void get_LastLocalLookRotation(){} // RVA: 0x7FFD5670DE50
        public void set_MenuPlacementZDepthVR(){} // RVA: 0x7FFD5670DE70
        public void get_VrScale(){} // RVA: 0x7FFD53CE6C50
        public void .ctor(){} // RVA: 0x7FFD5670DEA0
        public void get_DesktopPosition(){} // RVA: 0x7FFD4E3A9480
        public void set_LastLocalRotation(){} // RVA: 0x7FFD5670DF80
        public void get_ScaleContainer(){} // RVA: 0x7FFD4E35C380
        public void get_LastLocalRotation(){} // RVA: 0x7FFD5670DF90
        public void Instantiate(){} // RVA: 0x7FFD5670DE50
        public void set_ScaleContainer(){} // RVA: 0x7FFD5670DFA0
        public void set_ZDepthMovementSpeedMultiplier(){} // RVA: 0x7FFD5670E040
        public void Destroy(){} // RVA: 0x7FFD5670E0E0
        public void Equals(){} // RVA: 0x7FFD5670E180
        public void get_ZDepthMovementSpeedMultiplier(){} // RVA: 0x7FFD5670E220
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
        public bool <ÍÏÍÏÏÍÏÏÎÏÍÎÍÍÎÎÎÎÎÏÍÏÌ>k__BackingField; // 0x8E
        public float SMOOTHING_SPEED;
        public float SMOOTHING_MAX_DISTANCE;
        public float SMOOTHING_MAX_ANGLE;
        public float QM_WIDTH;
        public float QM_HEIGHT;

        // ── Methods ──
        public void get_IsDataHighConfidence(){} // RVA: 0x7FFD4F223D30
        public void set_MotionSmoothingEnabled(){} // RVA: 0x7FFD4F2268E0
        public void get_MotionSmoothingEnabled(){} // RVA: 0x7FFD4F223D30
        public void op_Implicit(){} // RVA: 0x7FFD56767A60
        public void .ctor(){} // RVA: 0x7FFD56767B90
        public void Initialize(){} // RVA: 0x7FFD56767D60
        public void get_DesktopScale(){} // RVA: 0x7FFD56767E20
        public void set_DesktopScale(){} // RVA: 0x7FFD4F223D30
        public void set_IsAttachedToHand(){} // RVA: 0x7FFD567680B0
        public void get_IsAttachedToHand(){} // RVA: 0x7FFD56768860
        public void Instantiate(){} // RVA: 0x7FFD56767D60
        public void Equals(){} // RVA: 0x7FFD56768990
        public void GetHashCode(){} // RVA: 0x7FFD56767D60
        public void ToString(){} // RVA: 0x7FFD56768C20
    }

}