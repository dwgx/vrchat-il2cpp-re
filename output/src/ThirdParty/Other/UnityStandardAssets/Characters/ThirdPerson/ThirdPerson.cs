// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.UnityStandardAssets.Characters.ThirdPerson
// Classes: 3
// Methods: 23

namespace ThirdParty.Other.UnityStandardAssets.Characters.ThirdPerson
{
    public class AICharacterControl : MonoBehaviour
    {
        public delay.? agent; // 0x20
        public 3PropertyTag.ctionPropertyTag character; // 0x28
        public object target; // 0x30

        // ── Methods ──
        public void get_agent(){} // RVA: 0x7FFD4E36F0C0
        public void set_agent(){} // RVA: 0x7FFD4E36F0D0
        public void get_character(){} // RVA: 0x7FFD4E36F130
        public void set_character(){} // RVA: 0x7FFD4E342E90
        public void Start(){} // RVA: 0x7FFD4E36F140
        public void Update(){} // RVA: 0x7FFD4E36F2F0
        public void SetTarget(){} // RVA: 0x7FFD4E36F890
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class ThirdPersonCharacter : MonoBehaviour
    {
        public float m_MovingTurnSpeed; // 0x20
        public float m_StationaryTurnSpeed; // 0x24
        public float m_JumpPower; // 0x28
        public float m_GravityMultiplier; // 0x2C
        public float m_RunCycleLegOffset; // 0x30
        public float m_MoveSpeedMultiplier; // 0x34
        public float m_AnimSpeedMultiplier; // 0x38
        public float m_GroundCheckDistance; // 0x3C
        public Touched m_Rigidbody; // 0x40
        public stfix m_Animator; // 0x48
        public bool m_IsGrounded; // 0x50
        public float m_OrigGroundCheckDistance; // 0x54
        public float k_Half;
        public float m_TurnAmount; // 0x58
        public float m_ForwardAmount; // 0x5C
        public amut m_GroundNormal; // 0x60
        public float m_CapsuleHeight; // 0x6C
        public amut m_CapsuleCenter; // 0x70
        public ovrp_Media_DestroyCustomCameraAnchor m_Capsule; // 0x80
        public bool m_Crouching; // 0x88

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD4E36F8F0
        public void Move(){} // RVA: 0x7FFD4E36FBF0
        public void ScaleCapsuleForCrouching(){} // RVA: 0x7FFD4E36FF00
        public void PreventStandingInLowHeadroom(){} // RVA: 0x7FFD4E3704D0
        public void UpdateAnimator(){} // RVA: 0x7FFD4E3708C0
        public void HandleAirborneMovement(){} // RVA: 0x7FFD4E370CD0
        public void HandleGroundedMovement(){} // RVA: 0x7FFD4E370F80
        public void ApplyExtraTurnRotation(){} // RVA: 0x7FFD4E3711F0
        public void OnAnimatorMove(){} // RVA: 0x7FFD4E371330
        public void CheckGroundStatus(){} // RVA: 0x7FFD4E371550
        public void .ctor(){} // RVA: 0x7FFD4E371920
    }

    public class ThirdPersonUserControl : MonoBehaviour
    {
        public 3PropertyTag.ctionPropertyTag m_Character; // 0x20
        public object m_Cam; // 0x28
        public amut m_CamForward; // 0x30
        public amut m_Move; // 0x3C
        public bool m_Jump; // 0x48

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD4E3719A0
        public void Update(){} // RVA: 0x7FFD4E371D90
        public void FixedUpdate(){} // RVA: 0x7FFD4E371E00
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

}