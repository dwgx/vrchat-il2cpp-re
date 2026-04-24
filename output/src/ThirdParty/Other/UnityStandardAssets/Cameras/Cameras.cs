// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.UnityStandardAssets.Cameras
// Classes: 8
// Methods: 34

namespace ThirdParty.Other.UnityStandardAssets.Cameras
{
    public class AbstractTargetFollower : MonoBehaviour
    {
        public object Target;

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD4E377E20
        public void FixedUpdate(){} // RVA: 0x7FFD4E3781E0
        public void LateUpdate(){} // RVA: 0x7FFD4E3783D0
        public void ManualUpdate(){} // RVA: 0x7FFD4E3785C0
        public void FollowTarget(){} // RVA: 0x7FFD4E09E480
        public void FindAndTargetPlayer(){} // RVA: 0x7FFD4E3787B0
        public void SetTarget(){} // RVA: 0x7FFD4E36F0D0
        public void get_Target(){} // RVA: 0x7FFD4E36F0C0
        public void .ctor(){} // RVA: 0x7FFD4E378BB0
    }

    public class AutoCam : PivotBasedCameraRig
    {
        // ── Methods ──
        public void FollowTarget(){} // RVA: 0x7FFD4E378D80
        public void .ctor(){} // RVA: 0x7FFD4E379850
    }

    public class FreeLookCam : PivotBasedCameraRig
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD4E379920
        public void Update(){} // RVA: 0x7FFD4E379BD0
        public void OnDisable(){} // RVA: 0x7FFD4E379CD0
        public void FollowTarget(){} // RVA: 0x7FFD4E379D60
        public void HandleRotationMovement(){} // RVA: 0x7FFD4E37A070
        public void .ctor(){} // RVA: 0x7FFD4E37A870
    }

    public class HandHeldCam : LookatTarget
    {
        // ── Methods ──
        public void FollowTarget(){} // RVA: 0x7FFD4E37A8E0
        public void .ctor(){} // RVA: 0x7FFD4E37AC80
    }

    public class LookatTarget : AbstractTargetFollower
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD4E37ACF0
        public void FollowTarget(){} // RVA: 0x7FFD4E37ADC0
        public void .ctor(){} // RVA: 0x7FFD4E37B830
    }

    public class PivotBasedCameraRig : AbstractTargetFollower
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD4E37B880
        public void .ctor(){} // RVA: 0x7FFD4E378BB0
    }

    public class ProtectCameraFromWallClip : MonoBehaviour
    {
        public object protecting;

        // ── Methods ──
        public void get_protecting(){} // RVA: 0x7FFD4E377C20
        public void set_protecting(){} // RVA: 0x7FFD4E37BAC0
        public void Start(){} // RVA: 0x7FFD4E37BAD0
        public void LateUpdate(){} // RVA: 0x7FFD4E37BD80
        public void .ctor(){} // RVA: 0x7FFD4E37C910
    }

    public class TargetFieldOfView : AbstractTargetFollower
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD4E37CAF0
        public void FollowTarget(){} // RVA: 0x7FFD4E37CBA0
        public void SetTarget(){} // RVA: 0x7FFD4E37CE60
        public void MaxBoundsExtent(){} // RVA: 0x7FFD4E37CED0
        public void .ctor(){} // RVA: 0x7FFD4E37D1F0
    }

}