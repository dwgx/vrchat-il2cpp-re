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
        public 0x6B14A2F8 flags; // 0x224
        public 0x6B14A350 m_Flags; // 0x228

        // ── Methods ──
        public void get_menu(){} // RVA: 0x7FFAC354BCB0
        public void set_menu(){} // RVA: 0x7FFAC3543140
        public void get_view(){} // RVA: 0x7FFAC3541470
        public void set_view(){} // RVA: 0x7FFAC3542420
        public void get_subType(){} // RVA: 0x7FFAC963B5E0
        public void get_flags(){} // RVA: 0x7FFAC963B620
        public void FinishSetup(){} // RVA: 0x7FFAC963B660
        public void ParseCapabilities(){} // RVA: 0x7FFAC963B740
        public void .ctor(){} // RVA: 0x7FFAC9516440
    }

    public class XInputControllerWindows : XInputController
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9516440
    }

    public class XInputSupport : Object
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFAC963B8E0
    }

}