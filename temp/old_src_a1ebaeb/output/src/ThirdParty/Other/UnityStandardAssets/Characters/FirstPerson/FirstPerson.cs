// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.UnityStandardAssets.Characters.FirstPerson
// Classes: 4
// Methods: 35

namespace ThirdParty.Other.UnityStandardAssets.Characters.FirstPerson
{
    public class FirstPersonController : MonoBehaviour
    {
        public object m_RunSpeed; // 0x333B2A80
        public object m_StickToGroundForce; // 0x333B2A80
        public object m_UseFovKick; // 0x333B2A80
        public object m_HeadBob; // 0x333B2A80
        public object m_FootstepSounds; // 0x333B2A80
        public object m_Camera; // 0x333B2A80
        public object m_Input; // 0x333B2A80
        public object m_CollisionFlags; // 0x333B2A80
        public object m_StepCycle; // 0x333B2A80
        public object m_AudioSource; // 0x333B2A80
        public object Init; // 0xB3F6FFF0

        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffaa8963330
        public void Update(){} // RVA: 0x7ffaa89636c0
        public void PlayLandingSound(){} // RVA: 0x7ffaa8963a40
        public void FixedUpdate(){} // RVA: 0x7ffaa8963b30
        public void PlayJumpSound(){} // RVA: 0x7ffaa8964440
        public void ProgressStepCycle(){} // RVA: 0x7ffaa8964510
        public void PlayFootStepAudio(){} // RVA: 0x7ffaa8964750
        public void UpdateCameraPosition(){} // RVA: 0x7ffaa89649b0
        public void RotateView(){} // RVA: 0x7ffaa89652b0
        public void OnControllerColliderHit(){} // RVA: 0x7ffaa8965380
        public void .ctor(){} // RVA: 0x7ffaa8965620
        // ── Binary Analysis Named ──
        public void GetInput(){} // RVA: 0x7ffaa8964ed0
    }

    public class HeadBob : MonoBehaviour
    {
        public object jumpAndLandingBob; // 0x338CD5F0
        public object RunningStrideLengthen; // 0x338CD5F0
        public object cam; // 0x338B5D70
        public object advancedSettings; // 0x338B5D70

        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffaa8965850
        public void Update(){} // RVA: 0x7ffaa8965950
        public void .ctor(){} // RVA: 0x7ffaa8965f20
    }

    public class MouseLook : Object
    {
        public object clampVerticalRotation; // 0x335FA0A0
        public object smooth; // 0x335FA0A0
        public object m_CharacterTargetRot; // 0x335FA0A0
        public object Sides; // 0x84440630

        // ── Original Methods ──
        public void Init(){} // RVA: 0x7ffaa8966070
        public void LookRotation(){} // RVA: 0x7ffaa8966160
        public void UpdateCursorLock(){} // RVA: 0x7ffaa8966af0
        public void InternalLockUpdate(){} // RVA: 0x7ffaa8966b00
        public void ClampRotationAroundXAxis(){} // RVA: 0x7ffaa8966cc0
        public void .ctor(){} // RVA: 0x7ffaa8966d80
        // ── Binary Analysis Named ──
        public void SetCursorLock(){} // RVA: 0x7ffaa8966a50
    }

    public class RigidbodyFirstPersonController : MonoBehaviour
    {
        public object mouseLook; // 0x338B5D70
        public object m_Capsule; // 0x338B5D70
        public object m_Jump; // 0x338B5D70
        public object m_IsGrounded; // 0x338B5D70
        public object Velocity; // 0x17000044
        public object Grounded; // 0x17000045
        public object Jumping; // 0x17000046
        public object Running; // 0x17000047

        // ── Original Methods ──
        public void get_Velocity(){} // RVA: 0x7ffaa8966db0
        public void get_Grounded(){} // RVA: 0x7ffaa8966e40
        public void get_Jumping(){} // RVA: 0x7ffaa8966e50
        public void get_Running(){} // RVA: 0x7ffaa8966e60
        public void Start(){} // RVA: 0x7ffaa8966e80
        public void Update(){} // RVA: 0x7ffaa8967050
        public void FixedUpdate(){} // RVA: 0x7ffaa89670d0
        public void SlopeMultiplier(){} // RVA: 0x7ffaa8967840
        public void StickToGroundHelper(){} // RVA: 0x7ffaa8967930
        public void RotateView(){} // RVA: 0x7ffaa8968090
        public void GroundCheck(){} // RVA: 0x7ffaa89684c0
        public void .ctor(){} // RVA: 0x7ffaa8968900
        // ── Binary Analysis Named ──
        public void GetInput(){} // RVA: 0x7ffaa8967e70
    }

}