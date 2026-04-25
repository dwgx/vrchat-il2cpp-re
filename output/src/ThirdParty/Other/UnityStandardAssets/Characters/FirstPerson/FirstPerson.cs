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
        public UnityStandardAssets.Characters.FirstPerson.MouseLook m_MouseLook; // 0x40
        public bool m_UseFovKick; // 0x48
        public UnityStandardAssets.Utility.FOVKick m_FovKick; // 0x50
        public bool m_UseHeadBob; // 0x58
        public UnityStandardAssets.Utility.CurveControlledBob m_HeadBob; // 0x60
        public UnityStandardAssets.Utility.LerpControlledBob m_JumpBob; // 0x68
        public float m_StepInterval; // 0x70
        public UnityEngine.AudioClip[] m_FootstepSounds; // 0x78
        public UnityEngine.AudioClip m_JumpSound; // 0x80
        public UnityEngine.AudioClip m_LandSound; // 0x88
        public UnityEngine.Camera m_Camera; // 0x90
        public bool m_Jump; // 0x98
        public float m_YRotation; // 0x9C
        public UnityEngine.Vector2 m_Input; // 0xA0
        public UnityEngine.Vector3 m_MoveDir; // 0xA8
        public UnityEngine.CharacterController m_CharacterController; // 0xB8
        public 0x6B2A01C0 m_CollisionFlags; // 0xC0
        public bool m_PreviouslyGrounded; // 0xC4
        public UnityEngine.Vector3 m_OriginalCameraPosition; // 0xC8
        public float m_StepCycle; // 0xD4
        public float m_NextStep; // 0xD8
        public bool m_Jumping; // 0xDC
        public UnityEngine.AudioSource m_AudioSource; // 0xE0

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAC2F52330
        public void Update(){} // RVA: 0x7FFAC2F526C0
        public void PlayLandingSound(){} // RVA: 0x7FFAC2F52A40
        public void FixedUpdate(){} // RVA: 0x7FFAC2F52B30
        public void PlayJumpSound(){} // RVA: 0x7FFAC2F53440
        public void ProgressStepCycle(){} // RVA: 0x7FFAC2F53510
        public void PlayFootStepAudio(){} // RVA: 0x7FFAC2F53750
        public void UpdateCameraPosition(){} // RVA: 0x7FFAC2F539B0
        public void GetInput(){} // RVA: 0x7FFAC2F53ED0
        public void RotateView(){} // RVA: 0x7FFAC2F542B0
        public void OnControllerColliderHit(){} // RVA: 0x7FFAC2F54380
        public void .ctor(){} // RVA: 0x7FFAC2F54620
    }

    public class HeadBob : MonoBehaviour
    {
        public UnityEngine.Camera Camera; // 0x20
        public UnityStandardAssets.Utility.CurveControlledBob motionBob; // 0x28
        public UnityStandardAssets.Utility.LerpControlledBob jumpAndLandingBob; // 0x30
        public UnityStandardAssets.Characters.FirstPerson.RigidbodyFirstPersonController rigidbodyFirstPersonController; // 0x38
        public float StrideInterval; // 0x40
        public float RunningStrideLengthen; // 0x44
        public bool m_PreviouslyGrounded; // 0x48
        public UnityEngine.Vector3 m_OriginalCameraPosition; // 0x4C

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAC2F54850
        public void Update(){} // RVA: 0x7FFAC2F54950
        public void .ctor(){} // RVA: 0x7FFAC2F54F20
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
        public UnityEngine.Quaternion m_CharacterTargetRot; // 0x30
        public UnityEngine.Quaternion m_CameraTargetRot; // 0x40
        public bool m_cursorIsLocked; // 0x50

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAC2F55070
        public void LookRotation(){} // RVA: 0x7FFAC2F55160
        public void SetCursorLock(){} // RVA: 0x7FFAC2F55A50
        public void UpdateCursorLock(){} // RVA: 0x7FFAC2F55AF0
        public void InternalLockUpdate(){} // RVA: 0x7FFAC2F55B00
        public void ClampRotationAroundXAxis(){} // RVA: 0x7FFAC2F55CC0
        public void .ctor(){} // RVA: 0x7FFAC2F55D80
    }

    public class RigidbodyFirstPersonController : MonoBehaviour
    {
        public UnityEngine.Camera Velocity; // 0x20
        public MovementSettings Grounded; // 0x28
        public UnityStandardAssets.Characters.FirstPerson.MouseLook Jumping; // 0x30
        public AdvancedSettings Running; // 0x38
        public UnityEngine.Rigidbody m_RigidBody; // 0x40
        public UnityEngine.CapsuleCollider m_Capsule; // 0x48
        public float m_YRotation; // 0x50
        public UnityEngine.Vector3 m_GroundContactNormal; // 0x54
        public bool m_Jump; // 0x60
        public bool m_PreviouslyGrounded; // 0x61
        public bool m_Jumping; // 0x62
        public bool m_IsGrounded; // 0x63

        // ── Methods ──
        public void get_Velocity(){} // RVA: 0x7FFAC2F55DB0
        public void get_Grounded(){} // RVA: 0x7FFAC2F55E40
        public void get_Jumping(){} // RVA: 0x7FFAC2F55E50
        public void get_Running(){} // RVA: 0x7FFAC2F55E60
        public void Start(){} // RVA: 0x7FFAC2F55E80
        public void Update(){} // RVA: 0x7FFAC2F56050
        public void FixedUpdate(){} // RVA: 0x7FFAC2F560D0
        public void SlopeMultiplier(){} // RVA: 0x7FFAC2F56840
        public void StickToGroundHelper(){} // RVA: 0x7FFAC2F56930
        public void GetInput(){} // RVA: 0x7FFAC2F56E70
        public void RotateView(){} // RVA: 0x7FFAC2F57090
        public void GroundCheck(){} // RVA: 0x7FFAC2F574C0
        public void .ctor(){} // RVA: 0x7FFAC2F57900
    }

}