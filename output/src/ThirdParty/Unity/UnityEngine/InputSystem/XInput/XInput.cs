// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.XInput
// Classes: 4
// Methods: 12

namespace ThirdParty.Unity.UnityEngine.InputSystem.XInput
{
    public class IXboxOneRumble
    {
        // ── Methods ──
        public void SetMotorSpeeds(){} // RVA: 0x8A2C00
    }

    public class XInputController : Gamepad
    {
        public object _menu;
        public object _view;
        public object m_HaveParsedCapabilities;
        public object m_SubType;
        public object m_Flags;

        // ── Methods ──
        public void get_menu(){} // RVA: 0x1640C90
        public void set_menu(){} // RVA: 0x1668690
        public void get_view(){} // RVA: 0x165F950
        public void set_view(){} // RVA: 0x164BF20
        public void get_subType(){} // RVA: 0x78EF290
        public void get_flags(){} // RVA: 0x78EF2D0
        public void FinishSetup(){} // RVA: 0x78EF310
        public void ParseCapabilities(){} // RVA: 0x78EF3F0
        public void .ctor(){} // RVA: 0x77D4F00
    }

    public class XInputControllerWindows : XInputController
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x77D4F00
    }

    public class XInputSupport : Object
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x78EF550
    }

}