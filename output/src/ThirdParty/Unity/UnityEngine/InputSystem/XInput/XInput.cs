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

    public class XInputController
    {
        public UnityEngine.InputSystem.Controls.ButtonControl <menu>k__BackingField; // 0x210
        public UnityEngine.InputSystem.Controls.ButtonControl <view>k__BackingField; // 0x218
        public bool m_HaveParsedCapabilities; // 0x220
        public 0x6586B368 m_SubType; // 0x224

        // ── Methods ──
        public void get_menu(){} // RVA: 0xD9F7C0
        public void set_menu(){} // RVA: 0xD9BA80
        public void get_view(){} // RVA: 0xD88BD0
        public void set_view(){} // RVA: 0xD9AC30
        public void get_subType(){} // RVA: 0x6EA2E90
        public void get_flags(){} // RVA: 0x6EA2ED0
        public void FinishSetup(){} // RVA: 0x6EA2F10
        public void ParseCapabilities(){} // RVA: 0x6EA2FF0
        public void .ctor(){} // RVA: 0x6D7DCE0
    }

    public class XInputControllerWindows
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6D7DCE0
    }

    public class XInputSupport
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x6EA3190
    }

}