// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.UnityStandardAssets.Characters.FirstPerson
// Classes: 4
// Methods: 35

namespace ThirdParty.Other.UnityStandardAssets.Characters.FirstPerson
{
    public class FirstPersonController : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFE8112C330
        public void Update(){} // RVA: 0x7FFE8112C6C0
        public void PlayLandingSound(){} // RVA: 0x7FFE8112CA40
        public void FixedUpdate(){} // RVA: 0x7FFE8112CB30
        public void PlayJumpSound(){} // RVA: 0x7FFE8112D440
        public void ProgressStepCycle(){} // RVA: 0x7FFE8112D510
        public void PlayFootStepAudio(){} // RVA: 0x7FFE8112D750
        public void UpdateCameraPosition(){} // RVA: 0x7FFE8112D9B0
        public void GetInput(){} // RVA: 0x7FFE8112DED0
        public void RotateView(){} // RVA: 0x7FFE8112E2B0
        public void OnControllerColliderHit(){} // RVA: 0x7FFE8112E380
        public void .ctor(){} // RVA: 0x7FFE8112E620
    }

    public class HeadBob : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFE8112E850
        public void Update(){} // RVA: 0x7FFE8112E950
        public void .ctor(){} // RVA: 0x7FFE8112EF20
    }

    public class MouseLook : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE8112F070
        public void LookRotation(){} // RVA: 0x7FFE8112F160
        public void SetCursorLock(){} // RVA: 0x7FFE8112FA50
        public void UpdateCursorLock(){} // RVA: 0x7FFE8112FAF0
        public void InternalLockUpdate(){} // RVA: 0x7FFE8112FB00
        public void ClampRotationAroundXAxis(){} // RVA: 0x7FFE8112FCC0
        public void .ctor(){} // RVA: 0x7FFE8112FD80
    }

    public class RigidbodyFirstPersonController : MonoBehaviour
    {
        public UnityEngine.Camera cam; // 0x20
        public MovementSettings movementSettings; // 0x28
        public UnityStandardAssets.Characters.FirstPerson.MouseLook mouseLook; // 0x30
        public AdvancedSettings advancedSettings; // 0x38

        // ── Methods ──
        public void get_Velocity(){} // RVA: 0x7FFE8112FDB0
        public void get_Grounded(){} // RVA: 0x7FFE8112FE40
        public void get_Jumping(){} // RVA: 0x7FFE8112FE50
        public void get_Running(){} // RVA: 0x7FFE8112FE60
        public void Start(){} // RVA: 0x7FFE8112FE80
        public void Update(){} // RVA: 0x7FFE81130050
        public void FixedUpdate(){} // RVA: 0x7FFE811300D0
        public void SlopeMultiplier(){} // RVA: 0x7FFE81130840
        public void StickToGroundHelper(){} // RVA: 0x7FFE81130930
        public void GetInput(){} // RVA: 0x7FFE81130E70
        public void RotateView(){} // RVA: 0x7FFE81131090
        public void GroundCheck(){} // RVA: 0x7FFE811314C0
        public void .ctor(){} // RVA: 0x7FFE81131900
    }

}