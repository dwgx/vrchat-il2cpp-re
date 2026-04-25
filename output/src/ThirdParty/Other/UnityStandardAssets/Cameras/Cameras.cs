// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.UnityStandardAssets.Cameras
// Classes: 8
// Methods: 34

namespace ThirdParty.Other.UnityStandardAssets.Cameras
{
    public class AbstractTargetFollower : MonoBehaviour
    {
        public UnityEngine.Transform Target; // 0x20
        public bool m_AutoTargetPlayer; // 0x28
        public bool m_AutoTargetLocalPlayer; // 0x29
        public 0x6B1BC130 m_UpdateType; // 0x2C
        public UnityEngine.Rigidbody targetRigidbody; // 0x30

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAC2F57E20
        public void FixedUpdate(){} // RVA: 0x7FFAC2F581E0
        public void LateUpdate(){} // RVA: 0x7FFAC2F583D0
        public void ManualUpdate(){} // RVA: 0x7FFAC2F585C0
        public void FollowTarget(){} // RVA: 0x7FFAC2C7E480
        public void FindAndTargetPlayer(){} // RVA: 0x7FFAC2F587B0
        public void SetTarget(){} // RVA: 0x7FFAC2F4F0D0
        public void get_Target(){} // RVA: 0x7FFAC2F4F0C0
        public void .ctor(){} // RVA: 0x7FFAC2F58BB0
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
        public UnityEngine.Vector3 m_RollUp; // 0x80

        // ── Methods ──
        public void FollowTarget(){} // RVA: 0x7FFAC2F58D80
        public void .ctor(){} // RVA: 0x7FFAC2F59850
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
        public UnityEngine.Vector3 m_PivotEulers; // 0x78
        public UnityEngine.Quaternion m_PivotTargetRot; // 0x84
        public UnityEngine.Quaternion m_TransformTargetRot; // 0x94

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAC2F59920
        public void Update(){} // RVA: 0x7FFAC2F59BD0
        public void OnDisable(){} // RVA: 0x7FFAC2F59CD0
        public void FollowTarget(){} // RVA: 0x7FFAC2F59D60
        public void HandleRotationMovement(){} // RVA: 0x7FFAC2F5A070
        public void .ctor(){} // RVA: 0x7FFAC2F5A870
    }

    public class HandHeldCam : LookatTarget
    {
        public float m_SwaySpeed; // 0x70
        public float m_BaseSwayAmount; // 0x74
        public float m_TrackingSwayAmount; // 0x78
        public float m_TrackingBias; // 0x7C

        // ── Methods ──
        public void FollowTarget(){} // RVA: 0x7FFAC2F5A8E0
        public void .ctor(){} // RVA: 0x7FFAC2F5AC80
    }

    public class LookatTarget : AbstractTargetFollower
    {
        public UnityEngine.Vector2 m_RotationRange; // 0x38
        public float m_FollowSpeed; // 0x40
        public UnityEngine.Vector3 m_FollowAngles; // 0x44
        public UnityEngine.Quaternion m_OriginalRotation; // 0x50
        public UnityEngine.Vector3 m_FollowVelocity; // 0x60

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAC2F5ACF0
        public void FollowTarget(){} // RVA: 0x7FFAC2F5ADC0
        public void .ctor(){} // RVA: 0x7FFAC2F5B830
    }

    public class PivotBasedCameraRig : AbstractTargetFollower
    {
        public UnityEngine.Transform m_Cam; // 0x38
        public UnityEngine.Transform m_Pivot; // 0x40
        public UnityEngine.Vector3 m_LastTargetPosition; // 0x48

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAC2F5B880
        public void .ctor(){} // RVA: 0x7FFAC2F58BB0
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
        public UnityEngine.Transform m_Cam; // 0x40
        public UnityEngine.Transform m_Pivot; // 0x48
        public float m_OriginalDist; // 0x50
        public float m_MoveVelocity; // 0x54
        public float m_CurrentDist; // 0x58
        public UnityEngine.Ray m_Ray; // 0x5C
        public UnityEngine.RaycastHit[] m_Hits; // 0x78
        public RayHitComparer m_RayHitComparer; // 0x80

        // ── Methods ──
        public void get_protecting(){} // RVA: 0x7FFAC2F57C20
        public void set_protecting(){} // RVA: 0x7FFAC2F5BAC0
        public void Start(){} // RVA: 0x7FFAC2F5BAD0
        public void LateUpdate(){} // RVA: 0x7FFAC2F5BD80
        public void .ctor(){} // RVA: 0x7FFAC2F5C910
    }

    public class TargetFieldOfView : AbstractTargetFollower
    {
        public float m_FovAdjustTime; // 0x38
        public float m_ZoomAmountMultiplier; // 0x3C
        public bool m_IncludeEffectsInSize; // 0x40
        public float m_BoundSize; // 0x44
        public float m_FovAdjustVelocity; // 0x48
        public UnityEngine.Camera m_Cam; // 0x50
        public UnityEngine.Transform m_LastTarget; // 0x58

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAC2F5CAF0
        public void FollowTarget(){} // RVA: 0x7FFAC2F5CBA0
        public void SetTarget(){} // RVA: 0x7FFAC2F5CE60
        public void MaxBoundsExtent(){} // RVA: 0x7FFAC2F5CED0
        public void .ctor(){} // RVA: 0x7FFAC2F5D1F0
    }

}