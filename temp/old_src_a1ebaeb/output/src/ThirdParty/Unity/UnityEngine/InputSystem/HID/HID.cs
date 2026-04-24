// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.HID
// Classes: 3
// Methods: 16

namespace ThirdParty.Unity.UnityEngine.InputSystem.HID
{
    public class HID : InputDevice
    {
        public object m_HaveParsedHIDDescriptor; // 0x338EF7B0

        // ── Original Methods ──
        public void get_QueryHIDReportDescriptorDeviceCommandType(){} // RVA: 0x7ffaaf07f620
        public void get_QueryHIDReportDescriptorSizeDeviceCommandType(){} // RVA: 0x7ffaaf07f630
        public void get_QueryHIDParsedReportDescriptorDeviceCommandType(){} // RVA: 0x7ffaaf07f640
        public void get_hidDescriptor(){} // RVA: 0x7ffaaf07f650
        public void OnFindLayoutForDevice(){} // RVA: 0x7ffaaf07f7d0
        public void ReadHIDDeviceDescriptor(){} // RVA: 0x7ffaaf080370
        public void UsagePageToString(){} // RVA: 0x7ffaaf080b50
        public void UsageToString(){} // RVA: 0x7ffaaf080bd0
        public void .ctor(){} // RVA: 0x7ffaaef38410
        public void .cctor(){} // RVA: 0x7ffaaf080c90
    }

    public class HIDParser : Object
    {
        // ── Original Methods ──
        public void ParseReportDescriptor(){} // RVA: 0x7ffaaf0875a0
        public void ParseReportDescriptor(){} // RVA: 0x7ffaaf0875a0
        public void ReadData(){} // RVA: 0x7ffaaf088500
    }

    public class HIDSupport : Object
    {
        // ── Original Methods ──
        public void get_supportedHIDUsages(){} // RVA: 0x7ffaaf088c80
        public void set_supportedHIDUsages(){} // RVA: 0x7ffaaf088d70
        public void Initialize(){} // RVA: 0x7ffaaf089100
    }

}