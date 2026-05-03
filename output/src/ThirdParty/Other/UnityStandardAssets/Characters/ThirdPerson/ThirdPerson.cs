// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.UnityStandardAssets.Characters.ThirdPerson
// Classes: 3
// Methods: 23

namespace ThirdParty.Other.UnityStandardAssets.Characters.ThirdPerson
{
    public class AICharacterControl : MonoBehaviour
    {
        public UnityEngine.AI.NavMeshAgent _agent; // 0x20
        public UnityStandardAssets.Characters.ThirdPerson.ThirdPersonCharacter _character; // 0x28

        // ── Methods ──
        public void get_agent(){} // RVA: 0x7FFE811290C0
        public void set_agent(){} // RVA: 0x7FFE811290D0
        public void get_character(){} // RVA: 0x7FFE81129130
        public void set_character(){} // RVA: 0x7FFE810FCE90
        public void Start(){} // RVA: 0x7FFE81129140
        public void Update(){} // RVA: 0x7FFE811292F0
        public void SetTarget(){} // RVA: 0x7FFE81129890
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class ThirdPersonCharacter : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFE811298F0
        public void Move(){} // RVA: 0x7FFE81129BF0
        public void ScaleCapsuleForCrouching(){} // RVA: 0x7FFE81129F00
        public void PreventStandingInLowHeadroom(){} // RVA: 0x7FFE8112A4D0
        public void UpdateAnimator(){} // RVA: 0x7FFE8112A8C0
        public void HandleAirborneMovement(){} // RVA: 0x7FFE8112ACD0
        public void HandleGroundedMovement(){} // RVA: 0x7FFE8112AF80
        public void ApplyExtraTurnRotation(){} // RVA: 0x7FFE8112B1F0
        public void OnAnimatorMove(){} // RVA: 0x7FFE8112B330
        public void CheckGroundStatus(){} // RVA: 0x7FFE8112B550
        public void .ctor(){} // RVA: 0x7FFE8112B920
    }

    public class ThirdPersonUserControl : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFE8112B9A0
        public void Update(){} // RVA: 0x7FFE8112BD90
        public void FixedUpdate(){} // RVA: 0x7FFE8112BE00
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

}