// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.UnityStandardAssets.Cameras
// Classes: 8
// Methods: 34

namespace ThirdParty.Other.UnityStandardAssets.Cameras
{
    public class AbstractTargetFollower : MonoBehaviour
    {
        public object Target; // 0x20
        public bool m_AutoTargetPlayer; // 0x28
        public bool m_AutoTargetLocalPlayer; // 0x29
        public object m_UpdateType; // 0x2C
        public Touched targetRigidbody; // 0x30

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
        public float m_MoveSpeed; // 0x58
        public float m_TurnSpeed; // 0x5C
        public float m_RollSpeed; // 0x60
        public bool m_FollowVelocity; // 0x64
        public bool m_FollowTilt; // 0x65
        public float m_SpinTurnLimit; // 0x68
        public float m_TargetVelocityLowerLimit; // 0x6C
        public float m_SmoothTurnTime; // 0x70
        public float m_LastFlatAngle; // 0x74
        public float m_CurrentTurnAmount; // 0x78
        public float m_TurnSpeedVelocityChange; // 0x7C
        public amut m_RollUp; // 0x80

        // ── Methods ──
        public void FollowTarget(){} // RVA: 0x7FFD4E378D80
        public void .ctor(){} // RVA: 0x7FFD4E379850
    }

    public class FreeLookCam : PivotBasedCameraRig
    {
        public float m_MoveSpeed; // 0x58
        public float m_TurnSpeed; // 0x5C
        public float m_TurnSmoothing; // 0x60
        public float m_TiltMax; // 0x64
        public float m_TiltMin; // 0x68
        public bool m_LockCursor; // 0x6C
        public bool m_VerticalAutoReturn; // 0x6D
        public float m_LookAngle; // 0x70
        public float m_TiltAngle; // 0x74
        public float k_LookDistance;
        public amut m_PivotEulers; // 0x78
        public R_12x12 m_PivotTargetRot; // 0x84
        public R_12x12 m_TransformTargetRot; // 0x94

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
        public float m_SwaySpeed; // 0x70
        public float m_BaseSwayAmount; // 0x74
        public float m_TrackingSwayAmount; // 0x78
        public float m_TrackingBias; // 0x7C

        // ── Methods ──
        public void FollowTarget(){} // RVA: 0x7FFD4E37A8E0
        public void .ctor(){} // RVA: 0x7FFD4E37AC80
    }

    public class LookatTarget : AbstractTargetFollower
    {
        public tionX m_RotationRange; // 0x38
        public float m_FollowSpeed; // 0x40
        public amut m_FollowAngles; // 0x44
        public R_12x12 m_OriginalRotation; // 0x50
        public amut m_FollowVelocity; // 0x60

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD4E37ACF0
        public void FollowTarget(){} // RVA: 0x7FFD4E37ADC0
        public void .ctor(){} // RVA: 0x7FFD4E37B830
    }

    public class PivotBasedCameraRig : AbstractTargetFollower
    {
        public object m_Cam; // 0x38
        public object m_Pivot; // 0x40
        public amut m_LastTargetPosition; // 0x48

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD4E37B880
        public void .ctor(){} // RVA: 0x7FFD4E378BB0
    }

    public class ProtectCameraFromWallClip : MonoBehaviour
    {
        public float protecting; // 0x20
        public float returnTime; // 0x24
        public float sphereCastRadius; // 0x28
        public bool visualiseInEditor; // 0x2C
        public float closestDistance; // 0x30
        public bool <protecting>k__BackingField; // 0x34
        public string dontClipTag; // 0x38
        public object m_Cam; // 0x40
        public object m_Pivot; // 0x48
        public float m_OriginalDist; // 0x50
        public float m_MoveVelocity; // 0x54
        public float m_CurrentDist; // 0x58
        public ed m_Ray; // 0x5C
        public ColorScaleAndOffset[] m_Hits; // 0x78
        public Bool m_RayHitComparer; // 0x80

        // ── Methods ──
        public void get_protecting(){} // RVA: 0x7FFD4E377C20
        public void set_protecting(){} // RVA: 0x7FFD4E37BAC0
        public void Start(){} // RVA: 0x7FFD4E37BAD0
        public void LateUpdate(){} // RVA: 0x7FFD4E37BD80
        public void .ctor(){} // RVA: 0x7FFD4E37C910
    }

    public class TargetFieldOfView : AbstractTargetFollower
    {
        public float m_FovAdjustTime; // 0x38
        public float m_ZoomAmountMultiplier; // 0x3C
        public bool m_IncludeEffectsInSize; // 0x40
        public float m_BoundSize; // 0x44
        public float m_FovAdjustVelocity; // 0x48
        public ÌÎÌÏÍÏÌÏÌÌÌÌÏÌÌÌÌÎÎÎÍ m_Cam; // 0x50
        public object m_LastTarget; // 0x58

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD4E37CAF0
        public void FollowTarget(){} // RVA: 0x7FFD4E37CBA0
        public void SetTarget(){} // RVA: 0x7FFD4E37CE60
        public void MaxBoundsExtent(){} // RVA: 0x7FFD4E37CED0
        public void .ctor(){} // RVA: 0x7FFD4E37D1F0
    }

}