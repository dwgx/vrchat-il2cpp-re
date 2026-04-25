// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.UnityStandardAssets.Characters.ThirdPerson
// Classes: 3
// Methods: 23

namespace ThirdParty.Other.UnityStandardAssets.Characters.ThirdPerson
{
    public class AICharacterControl : MonoBehaviour
    {
        public UnityEngine.AI.NavMeshAgent agent; // 0x20
        public UnityStandardAssets.Characters.ThirdPerson.ThirdPersonCharacter character; // 0x28
        public UnityEngine.Transform target; // 0x30

        // ── Methods ──
        public void get_agent(){} // RVA: 0x7FFAC2F4F0C0
        public void set_agent(){} // RVA: 0x7FFAC2F4F0D0
        public void get_character(){} // RVA: 0x7FFAC2F4F130
        public void set_character(){} // RVA: 0x7FFAC2F22E90
        public void Start(){} // RVA: 0x7FFAC2F4F140
        public void Update(){} // RVA: 0x7FFAC2F4F2F0
        public void SetTarget(){} // RVA: 0x7FFAC2F4F890
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
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
        public UnityEngine.Rigidbody m_Rigidbody; // 0x40
        public UnityEngine.Animator m_Animator; // 0x48
        public bool m_IsGrounded; // 0x50
        public float m_OrigGroundCheckDistance; // 0x54
        public float k_Half;
        public float m_TurnAmount; // 0x58
        public float m_ForwardAmount; // 0x5C
        public UnityEngine.Vector3 m_GroundNormal; // 0x60
        public float m_CapsuleHeight; // 0x6C
        public UnityEngine.Vector3 m_CapsuleCenter; // 0x70
        public UnityEngine.CapsuleCollider m_Capsule; // 0x80
        public bool m_Crouching; // 0x88

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAC2F4F8F0
        public void Move(){} // RVA: 0x7FFAC2F4FBF0
        public void ScaleCapsuleForCrouching(){} // RVA: 0x7FFAC2F4FF00
        public void PreventStandingInLowHeadroom(){} // RVA: 0x7FFAC2F504D0
        public void UpdateAnimator(){} // RVA: 0x7FFAC2F508C0
        public void HandleAirborneMovement(){} // RVA: 0x7FFAC2F50CD0
        public void HandleGroundedMovement(){} // RVA: 0x7FFAC2F50F80
        public void ApplyExtraTurnRotation(){} // RVA: 0x7FFAC2F511F0
        public void OnAnimatorMove(){} // RVA: 0x7FFAC2F51330
        public void CheckGroundStatus(){} // RVA: 0x7FFAC2F51550
        public void .ctor(){} // RVA: 0x7FFAC2F51920
    }

    public class ThirdPersonUserControl : MonoBehaviour
    {
        public UnityStandardAssets.Characters.ThirdPerson.ThirdPersonCharacter m_Character; // 0x20
        public UnityEngine.Transform m_Cam; // 0x28
        public UnityEngine.Vector3 m_CamForward; // 0x30
        public UnityEngine.Vector3 m_Move; // 0x3C
        public bool m_Jump; // 0x48

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAC2F519A0
        public void Update(){} // RVA: 0x7FFAC2F51D90
        public void FixedUpdate(){} // RVA: 0x7FFAC2F51E00
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

}