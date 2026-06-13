// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.UnityStandardAssets.Cameras
// Classes: 8
// Methods: 34

namespace ThirdParty.Other.UnityStandardAssets.Cameras
{
    public class AbstractTargetFollower
    {
        public UnityEngine.Transform m_Target; // 0x20

        // ── Methods ──
        public void Start(){} // RVA: 0x313E20
        public void FixedUpdate(){} // RVA: 0x3141E0
        public void LateUpdate(){} // RVA: 0x3143D0
        public void ManualUpdate(){} // RVA: 0x3145C0
        public void FollowTarget(){} // RVA: 0x325B0
        public void FindAndTargetPlayer(){} // RVA: 0x3147B0
        public void SetTarget(){} // RVA: 0x30B0D0
        public void get_Target(){} // RVA: 0x30B0C0
        public void .ctor(){} // RVA: 0x314BB0
    }

    public class AutoCam
    {
        // ── Methods ──
        public void FollowTarget(){} // RVA: 0x314D80
        public void .ctor(){} // RVA: 0x315850
    }

    public class FreeLookCam
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x315920
        public void Update(){} // RVA: 0x315BD0
        public void OnDisable(){} // RVA: 0x315CD0
        public void FollowTarget(){} // RVA: 0x315D60
        public void HandleRotationMovement(){} // RVA: 0x316070
        public void .ctor(){} // RVA: 0x316870
    }

    public class HandHeldCam
    {
        // ── Methods ──
        public void FollowTarget(){} // RVA: 0x3168E0
        public void .ctor(){} // RVA: 0x316C80
    }

    public class LookatTarget
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x316CF0
        public void FollowTarget(){} // RVA: 0x316DC0
        public void .ctor(){} // RVA: 0x317830
    }

    public class PivotBasedCameraRig
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x317880
        public void .ctor(){} // RVA: 0x314BB0
    }

    public class ProtectCameraFromWallClip
    {
        public float _protecting; // 0x20

        // ── Methods ──
        public void get_protecting(){} // RVA: 0x313C20
        public void set_protecting(){} // RVA: 0x317AC0
        public void Start(){} // RVA: 0x317AD0
        public void LateUpdate(){} // RVA: 0x317D80
        public void .ctor(){} // RVA: 0x318910
    }

    public class TargetFieldOfView
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x318AF0
        public void FollowTarget(){} // RVA: 0x318BA0
        public void SetTarget(){} // RVA: 0x318E60
        public void MaxBoundsExtent(){} // RVA: 0x318ED0
        public void .ctor(){} // RVA: 0x3191F0
    }

}