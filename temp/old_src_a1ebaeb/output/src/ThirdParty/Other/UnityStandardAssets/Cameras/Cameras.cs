// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.UnityStandardAssets.Cameras
// Classes: 8
// Methods: 34

namespace ThirdParty.Other.UnityStandardAssets.Cameras
{
    public class AbstractTargetFollower : MonoBehaviour
    {
        public object m_AutoTargetLocalPlayer; // 0x3372DA00

        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffaa8968e20
        public void FixedUpdate(){} // RVA: 0x7ffaa89691e0
        public void LateUpdate(){} // RVA: 0x7ffaa89693d0
        public void ManualUpdate(){} // RVA: 0x7ffaa89695c0
        public void FollowTarget(){} // RVA: 0x7ffaa866e7c0
        public void FindAndTargetPlayer(){} // RVA: 0x7ffaa89697b0
        public void get_Target(){} // RVA: 0x7ffaa89600c0
        public void .ctor(){} // RVA: 0x7ffaa8969bb0
        // ── Binary Analysis Named ──
        public void SetTarget(){} // RVA: 0x7ffaa89600d0
    }

    public class AutoCam : PivotBasedCameraRig
    {
        public object m_RollSpeed; // 0x339FEA20
        public object m_SpinTurnLimit; // 0x339FEA20
        public object m_LastFlatAngle; // 0x339FEA20
        public object m_RollUp; // 0x339FEA20
        public object m_TurnSmoothing; // 0x33C27D00
        public object m_LockCursor; // 0x33C27D00

        // ── Original Methods ──
        public void FollowTarget(){} // RVA: 0x7ffaa8969d80
        public void .ctor(){} // RVA: 0x7ffaa896a850
    }

    public class FreeLookCam : PivotBasedCameraRig
    {
        public object m_TurnSmoothing; // 0x33C27D00
        public object m_LockCursor; // 0x33C27D00
        public object m_TiltAngle; // 0x33C27D00
        public object m_PivotTargetRot; // 0x33C27D00
        public object m_FollowSpeed; // 0x337E72F0
        public object m_FollowVelocity; // 0x337E72F0

        // ── Original Methods ──
        public void Awake(){} // RVA: 0x7ffaa896a920
        public void Update(){} // RVA: 0x7ffaa896abd0
        public void OnDisable(){} // RVA: 0x7ffaa896acd0
        public void FollowTarget(){} // RVA: 0x7ffaa896ad60
        public void HandleRotationMovement(){} // RVA: 0x7ffaa896b070
        public void .ctor(){} // RVA: 0x7ffaa896b870
    }

    public class HandHeldCam : LookatTarget
    {
        public object m_TrackingSwayAmount; // 0x337E7140
        public object Compare; // 0xB41F4A50

        // ── Original Methods ──
        public void FollowTarget(){} // RVA: 0x7ffaa896b8e0
        public void .ctor(){} // RVA: 0x7ffaa896bc80
    }

    public class LookatTarget : AbstractTargetFollower
    {
        public object m_FollowAngles; // 0x337E72F0
        public object m_SwaySpeed; // 0x337E7140

        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffaa896bcf0
        public void FollowTarget(){} // RVA: 0x7ffaa896bdc0
        public void .ctor(){} // RVA: 0x7ffaa896c830
    }

    public class PivotBasedCameraRig : AbstractTargetFollower
    {
        public object m_LastTargetPosition; // 0x3372D840

        // ── Original Methods ──
        public void Awake(){} // RVA: 0x7ffaa896c880
        public void .ctor(){} // RVA: 0x7ffaa8969bb0
    }

    public class ProtectCameraFromWallClip : MonoBehaviour
    {
        public object sphereCastRadius; // 0x3395F210
        public object _protecting; // 0x3395F210, was: <protecting>k__BackingField
        public object m_Pivot; // 0x3395F210
        public object m_CurrentDist; // 0x3395F210
        public object m_RayHitComparer; // 0x3395F210
        public object protecting; // 0x1700004A

        // ── Original Methods ──
        public void get_protecting(){} // RVA: 0x7ffaa8968c20
        public void set_protecting(){} // RVA: 0x7ffaa896cac0
        public void Start(){} // RVA: 0x7ffaa896cad0
        public void LateUpdate(){} // RVA: 0x7ffaa896cd80
        public void .ctor(){} // RVA: 0x7ffaa896d910
    }

    public class TargetFieldOfView : AbstractTargetFollower
    {
        public object m_IncludeEffectsInSize; // 0x339F62A0
        public object m_Cam; // 0x339F62A0
        public object damping; // 0x3374D3C0

        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffaa896daf0
        public void FollowTarget(){} // RVA: 0x7ffaa896dba0
        public void MaxBoundsExtent(){} // RVA: 0x7ffaa896ded0
        public void .ctor(){} // RVA: 0x7ffaa896e1f0
        // ── Binary Analysis Named ──
        public void SetTarget(){} // RVA: 0x7ffaa896de60
    }

}