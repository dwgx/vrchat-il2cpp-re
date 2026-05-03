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
        public UnityEngine.InputSystem.Controls.ButtonControl _menu; // 0x210
        public UnityEngine.InputSystem.Controls.ButtonControl _view; // 0x218
        public bool m_HaveParsedCapabilities; // 0x220
        public 0x6654321C m_SubType; // 0x224

        // ── Methods ──
        public void get_menu(){} // RVA: 0x7FFE81B0A180
        public void set_menu(){} // RVA: 0x7FFE81B13850
        public void get_view(){} // RVA: 0x7FFE81B296E0
        public void set_view(){} // RVA: 0x7FFE81B38350
        public void get_subType(){} // RVA: 0x7FFE879E3D20
        public void get_flags(){} // RVA: 0x7FFE879E3D60
        public void FinishSetup(){} // RVA: 0x7FFE879E3DA0
        public void ParseCapabilities(){} // RVA: 0x7FFE879E3E80
        public void .ctor(){} // RVA: 0x7FFE878BEB80
    }

    public class XInputControllerWindows : XInputController
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE878BEB80
    }

    public class XInputSupport : Object
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFE879E4020
    }

}