// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.HID
// Classes: 3
// Methods: 15

namespace ThirdParty.Unity.UnityEngine.InputSystem.HID
{
    public class HID : InputDevice
    {
        public object kHIDInterface;
        public object kHIDNamespace;
        public object m_HaveParsedHIDDescriptor;
        public object m_HIDDescriptor;
        public object k_HIDParseDescriptorFallback;

        // ── Methods ──
        public void get_QueryHIDReportDescriptorDeviceCommandType(){} // RVA: 0x7911480
        public void get_QueryHIDReportDescriptorSizeDeviceCommandType(){} // RVA: 0x7911490
        public void get_QueryHIDParsedReportDescriptorDeviceCommandType(){} // RVA: 0x79114A0
        public void get_hidDescriptor(){} // RVA: 0x79114B0
        public void OnFindLayoutForDevice(){} // RVA: 0x7911630
        public void ReadHIDDeviceDescriptor(){} // RVA: 0x79121C0
        public void UsagePageToString(){} // RVA: 0x79129A0
        public void UsageToString(){} // RVA: 0x7912A20
        public void .ctor(){} // RVA: 0x77D4F00
        public void .cctor(){} // RVA: 0x7912AE0
    }

    public class HIDParser : Object
    {
        // ── Methods ──
        public void ParseReportDescriptor(){} // RVA: 0x7919510
        public void ReadData(){} // RVA: 0x791A460
    }

    public class HIDSupport : Object
    {
        public object s_SupportedHIDUsages;

        // ── Methods ──
        public void get_supportedHIDUsages(){} // RVA: 0x791ABD0
        public void set_supportedHIDUsages(){} // RVA: 0x791ACC0
        public void Initialize(){} // RVA: 0x791B040
    }

}