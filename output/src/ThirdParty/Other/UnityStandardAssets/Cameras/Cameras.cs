// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.UnityStandardAssets.Cameras
// Classes: 8
// Methods: 34

namespace ThirdParty.Other.UnityStandardAssets.Cameras
{
    public class AbstractTargetFollower : MonoBehaviour
    {
        public UnityEngine.Transform m_Target; // 0x20

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFE81131E20
        public void FixedUpdate(){} // RVA: 0x7FFE811321E0
        public void LateUpdate(){} // RVA: 0x7FFE811323D0
        public void ManualUpdate(){} // RVA: 0x7FFE811325C0
        public void FollowTarget(){} // RVA: 0x7FFE80E53B80
        public void FindAndTargetPlayer(){} // RVA: 0x7FFE811327B0
        public void SetTarget(){} // RVA: 0x7FFE811290D0
        public void get_Target(){} // RVA: 0x7FFE811290C0
        public void .ctor(){} // RVA: 0x7FFE81132BB0
    }

    public class AutoCam : PivotBasedCameraRig
    {
        // ── Methods ──
        public void FollowTarget(){} // RVA: 0x7FFE81132D80
        public void .ctor(){} // RVA: 0x7FFE81133850
    }

    public class FreeLookCam : PivotBasedCameraRig
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFE81133920
        public void Update(){} // RVA: 0x7FFE81133BD0
        public void OnDisable(){} // RVA: 0x7FFE81133CD0
        public void FollowTarget(){} // RVA: 0x7FFE81133D60
        public void HandleRotationMovement(){} // RVA: 0x7FFE81134070
        public void .ctor(){} // RVA: 0x7FFE81134870
    }

    public class HandHeldCam : LookatTarget
    {
        // ── Methods ──
        public void FollowTarget(){} // RVA: 0x7FFE811348E0
        public void .ctor(){} // RVA: 0x7FFE81134C80
    }

    public class LookatTarget : AbstractTargetFollower
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFE81134CF0
        public void FollowTarget(){} // RVA: 0x7FFE81134DC0
        public void .ctor(){} // RVA: 0x7FFE81135830
    }

    public class PivotBasedCameraRig : AbstractTargetFollower
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFE81135880
        public void .ctor(){} // RVA: 0x7FFE81132BB0
    }

    public class ProtectCameraFromWallClip : MonoBehaviour
    {
        public float clipMoveTime; // 0x20

        // ── Methods ──
        public void get_protecting(){} // RVA: 0x7FFE81131C20
        public void set_protecting(){} // RVA: 0x7FFE81135AC0
        public void Start(){} // RVA: 0x7FFE81135AD0
        public void LateUpdate(){} // RVA: 0x7FFE81135D80
        public void .ctor(){} // RVA: 0x7FFE81136910
    }

    public class TargetFieldOfView : AbstractTargetFollower
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFE81136AF0
        public void FollowTarget(){} // RVA: 0x7FFE81136BA0
        public void SetTarget(){} // RVA: 0x7FFE81136E60
        public void MaxBoundsExtent(){} // RVA: 0x7FFE81136ED0
        public void .ctor(){} // RVA: 0x7FFE811371F0
    }

}