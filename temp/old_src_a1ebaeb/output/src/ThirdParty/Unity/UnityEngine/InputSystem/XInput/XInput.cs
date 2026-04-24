// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.XInput
// Classes: 4
// Methods: 12

namespace ThirdParty.Unity.UnityEngine.InputSystem.XInput
{
    public class IXboxOneRumble
    {
        // ── Binary Analysis Named ──
        public void SetMotorSpeeds(){}
    }

    public class XInputController : Gamepad
    {
        public object m_HaveParsedCapabilities; // 0x333DF590

        // ── Original Methods ──
        public void get_menu(){} // RVA: 0x7ffaa8f6dbe0
        public void set_menu(){} // RVA: 0x7ffaa8f6f550
        public void get_view(){} // RVA: 0x7ffaa8f70430
        public void set_view(){} // RVA: 0x7ffaa8f7aac0
        public void get_subType(){} // RVA: 0x7ffaaf05d5c0
        public void get_flags(){} // RVA: 0x7ffaaf05d600
        public void FinishSetup(){} // RVA: 0x7ffaaf05d640
        public void ParseCapabilities(){} // RVA: 0x7ffaaf05d720
        public void .ctor(){} // RVA: 0x7ffaaef38410
    }

    public class XInputControllerWindows : XInputController
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaef38410
    }

    public class XInputSupport : Object
    {
        // ── Original Methods ──
        public void Initialize(){} // RVA: 0x7ffaaf05d8c0
    }

}