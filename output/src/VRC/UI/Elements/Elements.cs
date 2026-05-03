// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.UI.Elements
// Classes: 2
// Methods: 36

namespace VRC.UI.Elements
{
    public class MainMenuPlacementData : Object
    {
        public UnityEngine.Transform _scaleContainer; // 0x10
        public float Z_DEPTH_MOVEMENT_SPEED_MULTIPLIER;
        public float MIN_Z_DEPTH_VR;
        public float MAX_Z_DEPTH_VR;
        public float _menuPlacementZDepthVR; // 0x18
        public UnityEngine.Quaternion f_74F; // 0x1C
        public System.Nullable`1<UnityEngine.Quaternion> f_7D8; // 0x2C
        public UnityEngine.Vector2 f_CC7; // 0x40
        public UnityEngine.Vector3 f_92F; // 0x48

        // ── Methods ──
        public void get_VrPosition(){} // RVA: 0x7FFE896AA9A0
        public void set_MenuPlacementZDepthVR(){} // RVA: 0x7FFE896AA9C0
        public void set_MMDimensions(){} // RVA: 0x7FFE896AA9F0
        public void get_MMDimensions(){} // RVA: 0x7FFE87FBAEA0
        public void CompareBaseObjects(){} // RVA: 0x7FFE896AAA90
        public void set_LastLocalLookRotation(){} // RVA: 0x7FFE896AAAC0
        public void set_VrScale(){} // RVA: 0x7FFE896AAAD0
        public void get_VrScale(){} // RVA: 0x7FFE86C70340
        public void get_ZDepthMovementSpeedMultiplier(){} // RVA: 0x7FFE896AAB70
        public void get_ScaleContainer(){} // RVA: 0x7FFE81116380
        public void get_LastLocalLookRotation(){} // RVA: 0x7FFE896AAB80
        public void set_DesktopPosition(){} // RVA: 0x7FFE896AAB80
        public void get_DesktopPosition(){} // RVA: 0x7FFE81163480
        public void set_LastLocalRotation(){} // RVA: 0x7FFE896AABA0
        public void Instantiate(){} // RVA: 0x7FFE896AABB0
        public void Equals(){} // RVA: 0x7FFE896AABC0
        public void GetHashCode(){} // RVA: 0x7FFE896AABA0
        public void ToString(){} // RVA: 0x7FFE81116380
        public void get_LastLocalRotation(){} // RVA: 0x7FFE896AABE0
        public void get_MenuPlacementZDepthVR(){} // RVA: 0x7FFE810FFCF0
        public void .ctor(){} // RVA: 0x7FFE896AABF0
    }

    public class QuickMenuPlacer : Object
    {
        public UnityEngine.Transform _root; // 0x10
        public UnityEngine.Transform _container; // 0x18
        public UnityEngine.Vector3 _desktopMenuPos; // 0x20

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE8970A860
        public void set_IsAttachedToHand(){} // RVA: 0x7FFE8970B3F0
        public void .ctor(){} // RVA: 0x7FFE8970BBA0
        public void Initialize(){} // RVA: 0x7FFE8970BD70
        public void set_MotionSmoothingEnabled(){} // RVA: 0x7FFE820BD5D0
        public void get_IsAttachedToHand(){} // RVA: 0x7FFE8970C900
        public void GetCachedPtr(){} // RVA: 0x7FFE8970CA30
        public void get_name(){} // RVA: 0x7FFE820C48A0
        public void set_name(){} // RVA: 0x7FFE820C48A0
        public void Instantiate(){} // RVA: 0x7FFE8970D5C0
        public void set_DesktopScale(){} // RVA: 0x7FFE820BD5D0
        public void Equals(){} // RVA: 0x7FFE8970D680
        public void get_MotionSmoothingEnabled(){} // RVA: 0x7FFE820C48A0
        public void GetHashCode(){} // RVA: 0x7FFE8970D5C0
        public void get_DesktopScale(){} // RVA: 0x7FFE8970DE30
    }

}