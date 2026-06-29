// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.UnityStandardAssets.Characters.ThirdPerson
// Classes: 3
// Methods: 23

namespace ThirdParty.Other.UnityStandardAssets.Characters.ThirdPerson
{
    public class AICharacterControl : MonoBehaviour
    {
        public object _agent;
        public object _character;
        public object target;

        // ── Methods ──
        public void get_agent(){} // RVA: 0xB700F0
        public void set_agent(){} // RVA: 0xB70100
        public void get_character(){} // RVA: 0xB70160
        public void set_character(){} // RVA: 0xB44DC0
        public void Start(){} // RVA: 0xB70170
        public void Update(){} // RVA: 0xB702B0
        public void SetTarget(){} // RVA: 0xB708C0
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class ThirdPersonCharacter : MonoBehaviour
    {
        public object m_MovingTurnSpeed;
        public object m_StationaryTurnSpeed;
        public object m_JumpPower;
        public object m_GravityMultiplier;
        public object m_RunCycleLegOffset;
        public object m_MoveSpeedMultiplier;
        public object m_AnimSpeedMultiplier;
        public object m_GroundCheckDistance;
        public object m_Rigidbody;
        public object m_Animator;
        public object m_IsGrounded;
        public object m_OrigGroundCheckDistance;
        public object k_Half;
        public object m_TurnAmount;
        public object m_ForwardAmount;
        public object m_GroundNormal;
        public object m_CapsuleHeight;
        public object m_CapsuleCenter;
        public object m_Capsule;
        public object m_Crouching;

        // ── Methods ──
        public void Start(){} // RVA: 0xB70920
        public void Move(){} // RVA: 0xB70CA0
        public void ScaleCapsuleForCrouching(){} // RVA: 0xB70FA0
        public void PreventStandingInLowHeadroom(){} // RVA: 0xB71570
        public void UpdateAnimator(){} // RVA: 0xB718D0
        public void HandleAirborneMovement(){} // RVA: 0xB71CA0
        public void HandleGroundedMovement(){} // RVA: 0xB71FD0
        public void ApplyExtraTurnRotation(){} // RVA: 0xB722C0
        public void OnAnimatorMove(){} // RVA: 0xB723E0
        public void CheckGroundStatus(){} // RVA: 0xB726B0
        public void .ctor(){} // RVA: 0xB72A10
    }

    public class ThirdPersonUserControl : MonoBehaviour
    {
        public object m_Character;
        public object m_Cam;
        public object m_CamForward;
        public object m_Move;
        public object m_Jump;

        // ── Methods ──
        public void Start(){} // RVA: 0xB72A90
        public void Update(){} // RVA: 0xB72D90
        public void FixedUpdate(){} // RVA: 0xB72E00
        public void .ctor(){} // RVA: 0xB43D60
    }

}