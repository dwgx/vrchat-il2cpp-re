// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.UnityStandardAssets.Cameras
// Classes: 8
// Methods: 34

namespace ThirdParty.Other.UnityStandardAssets.Cameras
{
    public class AbstractTargetFollower : MonoBehaviour
    {
        public object m_Target;
        public object m_AutoTargetPlayer;
        public object m_AutoTargetLocalPlayer;
        public object m_UpdateType;
        public object targetRigidbody;

        // ── Methods ──
        public void Start(){} // RVA: 0xB78F40
        public void FixedUpdate(){} // RVA: 0xB79290
        public void LateUpdate(){} // RVA: 0xB79400
        public void ManualUpdate(){} // RVA: 0xB79570
        public void FollowTarget(){} // RVA: 0x8A23A0
        public void FindAndTargetPlayer(){} // RVA: 0xB796E0
        public void SetTarget(){} // RVA: 0xB70100
        public void get_Target(){} // RVA: 0xB700F0
        public void .ctor(){} // RVA: 0xB79A60
    }

    public class AutoCam : PivotBasedCameraRig
    {
        public object m_MoveSpeed;
        public object m_TurnSpeed;
        public object m_RollSpeed;
        public object m_FollowVelocity;
        public object m_FollowTilt;
        public object m_SpinTurnLimit;
        public object m_TargetVelocityLowerLimit;
        public object m_SmoothTurnTime;
        public object m_LastFlatAngle;
        public object m_CurrentTurnAmount;
        public object m_TurnSpeedVelocityChange;
        public object m_RollUp;

        // ── Methods ──
        public void FollowTarget(){} // RVA: 0xB79C20
        public void .ctor(){} // RVA: 0xB7A6F0
    }

    public class FreeLookCam : PivotBasedCameraRig
    {
        public object m_MoveSpeed;
        public object m_TurnSpeed;
        public object m_TurnSmoothing;
        public object m_TiltMax;
        public object m_TiltMin;
        public object m_LockCursor;
        public object m_VerticalAutoReturn;
        public object m_LookAngle;
        public object m_TiltAngle;
        public object k_LookDistance;
        public object m_PivotEulers;
        public object m_PivotTargetRot;
        public object m_TransformTargetRot;

        // ── Methods ──
        public void Awake(){} // RVA: 0xB7A7C0
        public void Update(){} // RVA: 0xB7AC40
        public void OnDisable(){} // RVA: 0xB7AD40
        public void FollowTarget(){} // RVA: 0xB7ADD0
        public void HandleRotationMovement(){} // RVA: 0xB7B120
        public void .ctor(){} // RVA: 0xB7B9E0
    }

    public class HandHeldCam : LookatTarget
    {
        public object m_SwaySpeed;
        public object m_BaseSwayAmount;
        public object m_TrackingSwayAmount;
        public object m_TrackingBias;

        // ── Methods ──
        public void FollowTarget(){} // RVA: 0xB7BA50
        public void .ctor(){} // RVA: 0xB7BDD0
    }

    public class LookatTarget : AbstractTargetFollower
    {
        public object m_RotationRange;
        public object m_FollowSpeed;
        public object m_FollowAngles;
        public object m_OriginalRotation;
        public object m_FollowVelocity;

        // ── Methods ──
        public void Start(){} // RVA: 0xB7BE40
        public void FollowTarget(){} // RVA: 0xB7BF10
        public void .ctor(){} // RVA: 0xB7C9D0
    }

    public class PivotBasedCameraRig : AbstractTargetFollower
    {
        public object m_Cam;
        public object m_Pivot;
        public object m_LastTargetPosition;

        // ── Methods ──
        public void Awake(){} // RVA: 0xB7CA20
        public void .ctor(){} // RVA: 0xB79A60
    }

    public class ProtectCameraFromWallClip : MonoBehaviour
    {
        public object clipMoveTime;
        public object returnTime;
        public object sphereCastRadius;
        public object visualiseInEditor;
        public object closestDistance;
        public object _protecting;
        public object dontClipTag;
        public object m_Cam;
        public object m_Pivot;
        public object m_OriginalDist;
        public object m_MoveVelocity;
        public object m_CurrentDist;
        public object m_Ray;
        public object m_Hits;
        public object m_RayHitComparer;

        // ── Methods ──
        public void get_protecting(){} // RVA: 0xB78D60
        public void set_protecting(){} // RVA: 0xB7CBE0
        public void Start(){} // RVA: 0xB7CBF0
        public void LateUpdate(){} // RVA: 0xB7CE50
        public void .ctor(){} // RVA: 0xB7DB00
    }

    public class TargetFieldOfView : AbstractTargetFollower
    {
        public object m_FovAdjustTime;
        public object m_ZoomAmountMultiplier;
        public object m_IncludeEffectsInSize;
        public object m_BoundSize;
        public object m_FovAdjustVelocity;
        public object m_Cam;
        public object m_LastTarget;

        // ── Methods ──
        public void Start(){} // RVA: 0xB7DCE0
        public void FollowTarget(){} // RVA: 0xB7DD90
        public void SetTarget(){} // RVA: 0xB7E050
        public void MaxBoundsExtent(){} // RVA: 0xB7E0C0
        public void .ctor(){} // RVA: 0xB7E580
    }

}