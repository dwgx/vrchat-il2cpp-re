// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.UnityStandardAssets.Cameras
// Classes: 8
// Methods: 34

namespace ThirdParty.Other.UnityStandardAssets.Cameras
{
    public class AbstractTargetFollower : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7A810DFD0
        public void FixedUpdate(){} // RVA: 0x7A810E390
        public void LateUpdate(){} // RVA: 0x7A810E580
        public void ManualUpdate(){} // RVA: 0x7A810E770
        public void FollowTarget(){} // RVA: 0x7A7E262C0
        public void FindAndTargetPlayer(){} // RVA: 0x7A810E960
        public void SetTarget(){} // RVA: 0x7A81052D0
        public void get_Target(){} // RVA: 0x7A81052C0
        public void .ctor(){} // RVA: 0x7A810ED60
    }

    public class AutoCam : PivotBasedCameraRig
    {
        // ── Methods ──
        public void FollowTarget(){} // RVA: 0x7A810EF30
        public void .ctor(){} // RVA: 0x7A810FA00
    }

    public class FreeLookCam : PivotBasedCameraRig
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7A810FAD0
        public void Update(){} // RVA: 0x7A810FD80
        public void OnDisable(){} // RVA: 0x7A810FE80
        public void FollowTarget(){} // RVA: 0x7A810FF10
        public void HandleRotationMovement(){} // RVA: 0x7A8110220
        public void .ctor(){} // RVA: 0x7A8110A20
    }

    public class HandHeldCam : LookatTarget
    {
        // ── Methods ──
        public void FollowTarget(){} // RVA: 0x7A8110A90
        public void .ctor(){} // RVA: 0x7A8110E30
    }

    public class LookatTarget : AbstractTargetFollower
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7A8110EA0
        public void FollowTarget(){} // RVA: 0x7A8110F70
        public void .ctor(){} // RVA: 0x7A81119C0
    }

    public class PivotBasedCameraRig : AbstractTargetFollower
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7A8111A10
        public void .ctor(){} // RVA: 0x7A810ED60
    }

    public class ProtectCameraFromWallClip : MonoBehaviour
    {
        // ── Methods ──
        public void get_protecting(){} // RVA: 0x7A810DDD0
        public void set_protecting(){} // RVA: 0x7A8111C50
        public void Start(){} // RVA: 0x7A8111C60
        public void LateUpdate(){} // RVA: 0x7A8111F10
        public void .ctor(){} // RVA: 0x7A8112A90
    }

    public class TargetFieldOfView : AbstractTargetFollower
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7A8112C70
        public void FollowTarget(){} // RVA: 0x7A8112D20
        public void SetTarget(){} // RVA: 0x7A8112FE0
        public void MaxBoundsExtent(){} // RVA: 0x7A8113050
        public void .ctor(){} // RVA: 0x7A81135C0
    }

}