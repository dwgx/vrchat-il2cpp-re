// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.UnityStandardAssets.Characters.ThirdPerson
// Classes: 3
// Methods: 23

namespace ThirdParty.Other.UnityStandardAssets.Characters.ThirdPerson
{
    public class AICharacterControl : MonoBehaviour
    {
        public object target; // 0x33914B90
        public object agent; // 0x17000042

        // ── Original Methods ──
        public void get_agent(){} // RVA: 0x7ffaa89600c0
        public void set_agent(){} // RVA: 0x7ffaa89600d0
        public void get_character(){} // RVA: 0x7ffaa8960130
        public void set_character(){} // RVA: 0x7ffaa8933e90
        public void Start(){} // RVA: 0x7ffaa8960140
        public void Update(){} // RVA: 0x7ffaa89602f0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        // ── Binary Analysis Named ──
        public void SetTarget(){} // RVA: 0x7ffaa8960890
    }

    public class ThirdPersonCharacter : MonoBehaviour
    {
        public object m_JumpPower; // 0x337A4A30
        public object m_MoveSpeedMultiplier; // 0x337A4A30
        public object m_Rigidbody; // 0x337A4A30
        public object m_OrigGroundCheckDistance; // 0x337A4A30
        public object m_ForwardAmount; // 0x337A4A30
        public object m_CapsuleCenter; // 0x337A4A30
        public object m_Character; // 0x336EF610
        public object m_Move; // 0x336EF610
        public object m_WalkSpeed; // 0x333B2A80
        public object m_JumpSpeed; // 0x333B2A80

        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffaa89608f0
        public void Move(){} // RVA: 0x7ffaa8960bf0
        public void ScaleCapsuleForCrouching(){} // RVA: 0x7ffaa8960f00
        public void PreventStandingInLowHeadroom(){} // RVA: 0x7ffaa89614d0
        public void UpdateAnimator(){} // RVA: 0x7ffaa89618c0
        public void HandleAirborneMovement(){} // RVA: 0x7ffaa8961cd0
        public void HandleGroundedMovement(){} // RVA: 0x7ffaa8961f80
        public void ApplyExtraTurnRotation(){} // RVA: 0x7ffaa89621f0
        public void OnAnimatorMove(){} // RVA: 0x7ffaa8962330
        public void .ctor(){} // RVA: 0x7ffaa8962920
        // ── Binary Analysis Named ──
        public void CheckGroundStatus(){} // RVA: 0x7ffaa8962550
    }

    public class ThirdPersonUserControl : MonoBehaviour
    {
        public object m_CamForward; // 0x336EF610
        public object m_IsWalking; // 0x333B2A80

        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffaa89629a0
        public void Update(){} // RVA: 0x7ffaa8962d90
        public void FixedUpdate(){} // RVA: 0x7ffaa8962e00
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

}