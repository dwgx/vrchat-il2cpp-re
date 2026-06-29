// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.UnityStandardAssets.Characters.FirstPerson
// Classes: 4
// Methods: 35

namespace ThirdParty.Other.UnityStandardAssets.Characters.FirstPerson
{
    public class FirstPersonController : MonoBehaviour
    {
        public object m_IsWalking;
        public object m_WalkSpeed;
        public object m_RunSpeed;
        public object m_RunstepLenghten;
        public object m_JumpSpeed;
        public object m_StickToGroundForce;
        public object m_GravityMultiplier;
        public object m_MouseLook;
        public object m_UseFovKick;
        public object m_FovKick;
        public object m_UseHeadBob;
        public object m_HeadBob;
        public object m_JumpBob;
        public object m_StepInterval;
        public object m_FootstepSounds;
        public object m_JumpSound;
        public object m_LandSound;
        public object m_Camera;
        public object m_Jump;
        public object m_YRotation;
        public object m_Input;
        public object m_MoveDir;
        public object m_CharacterController;
        public object m_CollisionFlags;
        public object m_PreviouslyGrounded;
        public object m_OriginalCameraPosition;
        public object m_StepCycle;
        public object m_NextStep;
        public object m_Jumping;
        public object m_AudioSource;

        // ── Methods ──
        public void Start(){} // RVA: 0xB73310
        public void Update(){} // RVA: 0xB73600
        public void PlayLandingSound(){} // RVA: 0xB738B0
        public void FixedUpdate(){} // RVA: 0xB73910
        public void PlayJumpSound(){} // RVA: 0xB74220
        public void ProgressStepCycle(){} // RVA: 0xB74270
        public void PlayFootStepAudio(){} // RVA: 0xB74520
        public void UpdateCameraPosition(){} // RVA: 0xB746F0
        public void GetInput(){} // RVA: 0xB74CE0
        public void RotateView(){} // RVA: 0xB75100
        public void OnControllerColliderHit(){} // RVA: 0xB75160
        public void .ctor(){} // RVA: 0xB75400
    }

    public class HeadBob : MonoBehaviour
    {
        public object Camera;
        public object motionBob;
        public object jumpAndLandingBob;
        public object rigidbodyFirstPersonController;
        public object StrideInterval;
        public object RunningStrideLengthen;
        public object m_PreviouslyGrounded;
        public object m_OriginalCameraPosition;

        // ── Methods ──
        public void Start(){} // RVA: 0xB75630
        public void Update(){} // RVA: 0xB75730
        public void .ctor(){} // RVA: 0xB75C50
    }

    public class MouseLook : Object
    {
        public object XSensitivity;
        public object YSensitivity;
        public object clampVerticalRotation;
        public object MinimumX;
        public object MaximumX;
        public object smooth;
        public object smoothTime;
        public object lockCursor;
        public object m_CharacterTargetRot;
        public object m_CameraTargetRot;
        public object m_cursorIsLocked;

        // ── Methods ──
        public void Init(){} // RVA: 0xB75DA0
        public void LookRotation(){} // RVA: 0xB75F10
        public void SetCursorLock(){} // RVA: 0xB76960
        public void UpdateCursorLock(){} // RVA: 0xB76A00
        public void InternalLockUpdate(){} // RVA: 0xB76A10
        public void ClampRotationAroundXAxis(){} // RVA: 0xB76BD0
        public void .ctor(){} // RVA: 0xB76C90
    }

    public class RigidbodyFirstPersonController : MonoBehaviour
    {
        public object cam;
        public object movementSettings;
        public object mouseLook;
        public object advancedSettings;
        public object m_RigidBody;
        public object m_Capsule;
        public object m_YRotation;
        public object m_GroundContactNormal;
        public object m_Jump;
        public object m_PreviouslyGrounded;
        public object m_Jumping;
        public object m_IsGrounded;

        // ── Methods ──
        public void get_Velocity(){} // RVA: 0xB76CC0
        public void get_Grounded(){} // RVA: 0xB76D90
        public void get_Jumping(){} // RVA: 0xB76DA0
        public void get_Running(){} // RVA: 0xB76DB0
        public void Start(){} // RVA: 0xB76DD0
        public void Update(){} // RVA: 0xB76F30
        public void FixedUpdate(){} // RVA: 0xB76FB0
        public void SlopeMultiplier(){} // RVA: 0xB776D0
        public void StickToGroundHelper(){} // RVA: 0xB777D0
        public void GetInput(){} // RVA: 0xB77E20
        public void RotateView(){} // RVA: 0xB78040
        public void GroundCheck(){} // RVA: 0xB78390
        public void .ctor(){} // RVA: 0xB788A0
    }

}