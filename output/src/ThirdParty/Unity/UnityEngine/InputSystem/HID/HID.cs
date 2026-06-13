// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.HID
// Classes: 3
// Methods: 16

namespace ThirdParty.Unity.UnityEngine.InputSystem.HID
{
    public class HID
    {
        public string kHIDInterface;
        public string kHIDNamespace;
        public bool m_HaveParsedHIDDescriptor; // 0x190
        public HIDDeviceDescriptor m_HIDDescriptor; // 0x198

        // ── Methods ──
        public void get_QueryHIDReportDescriptorDeviceCommandType(){} // RVA: 0x6EC4F10
        public void get_QueryHIDReportDescriptorSizeDeviceCommandType(){} // RVA: 0x6EC4F20
        public void get_QueryHIDParsedReportDescriptorDeviceCommandType(){} // RVA: 0x6EC4F30
        public void get_hidDescriptor(){} // RVA: 0x6EC4F40
        public void OnFindLayoutForDevice(){} // RVA: 0x6EC50C0
        public void ReadHIDDeviceDescriptor(){} // RVA: 0x6EC5C60
        public void UsagePageToString(){} // RVA: 0x6EC6440
        public void UsageToString(){} // RVA: 0x6EC64C0
        public void .ctor(){} // RVA: 0x6D7DCE0
        public void .cctor(){} // RVA: 0x6EC6580
    }

    public class HIDParser
    {
        // ── Methods ──
        public void ParseReportDescriptor(){} // RVA: 0x6ECCE90 | overloaded x2
        public void ReadData(){} // RVA: 0x6ECDDF0
    }

    public class HIDSupport
    {
        public HIDPageUsage[] s_SupportedHIDUsages;

        // ── Methods ──
        public void get_supportedHIDUsages(){} // RVA: 0x6ECE570
        public void set_supportedHIDUsages(){} // RVA: 0x6ECE660
        public void Initialize(){} // RVA: 0x6ECE9F0
    }

}