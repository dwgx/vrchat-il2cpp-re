// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.XInput
// Classes: 4
// Methods: 12

namespace ThirdParty.Unity.UnityEngine.InputSystem.XInput
{
    public class IXboxOneRumble
    {
        // ── Methods ──
        public void SetMotorSpeeds(){}
    }

    public class XInputController : Gamepad
    {
        public UnityEngine.InputSystem.Controls.ButtonControl menu; // 0x210
        public UnityEngine.InputSystem.Controls.ButtonControl view; // 0x218
        public bool subType; // 0x220
        public 0x664AA2F8 flags; // 0x224
        public 0x664AA350 m_Flags; // 0x228

        // ── Methods ──
        public void get_menu(){} // RVA: 0x7FFD4E96BCB0
        public void set_menu(){} // RVA: 0x7FFD4E963140
        public void get_view(){} // RVA: 0x7FFD4E961470
        public void set_view(){} // RVA: 0x7FFD4E962420
        public void get_subType(){} // RVA: 0x7FFD54A5B5E0
        public void get_flags(){} // RVA: 0x7FFD54A5B620
        public void FinishSetup(){} // RVA: 0x7FFD54A5B660
        public void ParseCapabilities(){} // RVA: 0x7FFD54A5B740
        public void .ctor(){} // RVA: 0x7FFD54936440
    }

    public class XInputControllerWindows : XInputController
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54936440
    }

    public class XInputSupport : Object
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFD54A5B8E0
    }

}