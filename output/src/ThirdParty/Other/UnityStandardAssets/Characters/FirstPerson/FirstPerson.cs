// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.UnityStandardAssets.Characters.FirstPerson
// Classes: 4
// Methods: 35

namespace ThirdParty.Other.UnityStandardAssets.Characters.FirstPerson
{
    public class FirstPersonController : MonoBehaviour
    {
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
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD4E374850
        public void Update(){} // RVA: 0x7FFD4E374950
        public void .ctor(){} // RVA: 0x7FFD4E374F20
    }

    public class MouseLook : Object
    {
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
        public object Velocity;
        public object Grounded;
        public object Jumping;
        public object Running;

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