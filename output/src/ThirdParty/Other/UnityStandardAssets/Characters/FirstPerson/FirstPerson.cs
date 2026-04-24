// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.UnityStandardAssets.Characters.FirstPerson
// Classes: 4
// Methods: 35

namespace ThirdParty.Other.UnityStandardAssets.Characters.FirstPerson
{
    public class FirstPersonController : MonoBehaviour
    {
        public bool m_IsWalking; // 0x20
        public float m_WalkSpeed; // 0x24
        public float m_RunSpeed; // 0x28
        public float m_RunstepLenghten; // 0x2C
        public float m_JumpSpeed; // 0x30
        public float m_StickToGroundForce; // 0x34
        public float m_GravityMultiplier; // 0x38
        public tions_Version.mVR_ForcedDriverKey_String m_MouseLook; // 0x40
        public bool m_UseFovKick; // 0x48
        public ntimePerformsPostPresentHandoff.eLine m_FovKick; // 0x50
        public bool m_UseHeadBob; // 0x58
        public ntimePerformsPostPresentHandoff.shboardTab m_HeadBob; // 0x60
        public ntimePerformsPostPresentHandoff.orted m_JumpBob; // 0x68
        public float m_StepInterval; // 0x70
        public ies[] m_FootstepSounds; // 0x78
        public ies m_JumpSound; // 0x80
        public ies m_LandSound; // 0x88
        public ÌÎÌÏÍÏÌÏÌÌÌÌÏÌÌÌÌÎÎÎÍ m_Camera; // 0x90
        public bool m_Jump; // 0x98
        public float m_YRotation; // 0x9C
        public tionX m_Input; // 0xA0
        public amut m_MoveDir; // 0xA8
        public ProcessAnimationJobStruct`1 m_CharacterController; // 0xB8
        public ght m_CollisionFlags; // 0xC0
        public bool m_PreviouslyGrounded; // 0xC4
        public amut m_OriginalCameraPosition; // 0xC8
        public float m_StepCycle; // 0xD4
        public float m_NextStep; // 0xD8
        public bool m_Jumping; // 0xDC
        public t m_AudioSource; // 0xE0

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD4E372330
        public void Update(){} // RVA: 0x7FFD4E3726C0
        public void PlayLandingSound(){} // RVA: 0x7FFD4E372A40
        public void FixedUpdate(){} // RVA: 0x7FFD4E372B30
        public void PlayJumpSound(){} // RVA: 0x7FFD4E373440
        public void ProgressStepCycle(){} // RVA: 0x7FFD4E373510
        public void PlayFootStepAudio(){} // RVA: 0x7FFD4E373750
        public void UpdateCameraPosition(){} // RVA: 0x7FFD4E3739B0
        public void GetInput(){} // RVA: 0x7FFD4E373ED0
        public void RotateView(){} // RVA: 0x7FFD4E3742B0
        public void OnControllerColliderHit(){} // RVA: 0x7FFD4E374380
        public void .ctor(){} // RVA: 0x7FFD4E374620
    }

    public class HeadBob : MonoBehaviour
    {
        public ÌÎÌÏÍÏÌÏÌÌÌÌÏÌÌÌÌÎÎÎÍ Camera; // 0x20
        public ntimePerformsPostPresentHandoff.shboardTab motionBob; // 0x28
        public ntimePerformsPostPresentHandoff.orted jumpAndLandingBob; // 0x30
        public tions_Version.ttonToAllApps_Bool rigidbodyFirstPersonController; // 0x38
        public float StrideInterval; // 0x40
        public float RunningStrideLengthen; // 0x44
        public bool m_PreviouslyGrounded; // 0x48
        public amut m_OriginalCameraPosition; // 0x4C

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD4E374850
        public void Update(){} // RVA: 0x7FFD4E374950
        public void .ctor(){} // RVA: 0x7FFD4E374F20
    }

    public class MouseLook : Object
    {
        public float XSensitivity; // 0x10
        public float YSensitivity; // 0x14
        public bool clampVerticalRotation; // 0x18
        public float MinimumX; // 0x1C
        public float MaximumX; // 0x20
        public bool smooth; // 0x24
        public float smoothTime; // 0x28
        public bool lockCursor; // 0x2C
        public R_12x12 m_CharacterTargetRot; // 0x30
        public R_12x12 m_CameraTargetRot; // 0x40
        public bool m_cursorIsLocked; // 0x50

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFD4E375070
        public void LookRotation(){} // RVA: 0x7FFD4E375160
        public void SetCursorLock(){} // RVA: 0x7FFD4E375A50
        public void UpdateCursorLock(){} // RVA: 0x7FFD4E375AF0
        public void InternalLockUpdate(){} // RVA: 0x7FFD4E375B00
        public void ClampRotationAroundXAxis(){} // RVA: 0x7FFD4E375CC0
        public void .ctor(){} // RVA: 0x7FFD4E375D80
    }

    public class RigidbodyFirstPersonController : MonoBehaviour
    {
        public ÌÎÌÏÍÏÌÏÌÌÌÌÏÌÌÌÌÎÎÎÍ Velocity; // 0x20
        public dius_Float Grounded; // 0x28
        public tions_Version.mVR_ForcedDriverKey_String Jumping; // 0x30
        public ateMultipleDrivers_Bool Running; // 0x38
        public Touched m_RigidBody; // 0x40
        public ovrp_Media_DestroyCustomCameraAnchor m_Capsule; // 0x48
        public float m_YRotation; // 0x50
        public amut m_GroundContactNormal; // 0x54
        public bool m_Jump; // 0x60
        public bool m_PreviouslyGrounded; // 0x61
        public bool m_Jumping; // 0x62
        public bool m_IsGrounded; // 0x63

        // ── Methods ──
        public void get_Velocity(){} // RVA: 0x7FFD4E375DB0
        public void get_Grounded(){} // RVA: 0x7FFD4E375E40
        public void get_Jumping(){} // RVA: 0x7FFD4E375E50
        public void get_Running(){} // RVA: 0x7FFD4E375E60
        public void Start(){} // RVA: 0x7FFD4E375E80
        public void Update(){} // RVA: 0x7FFD4E376050
        public void FixedUpdate(){} // RVA: 0x7FFD4E3760D0
        public void SlopeMultiplier(){} // RVA: 0x7FFD4E376840
        public void StickToGroundHelper(){} // RVA: 0x7FFD4E376930
        public void GetInput(){} // RVA: 0x7FFD4E376E70
        public void RotateView(){} // RVA: 0x7FFD4E377090
        public void GroundCheck(){} // RVA: 0x7FFD4E3774C0
        public void .ctor(){} // RVA: 0x7FFD4E377900
    }

}