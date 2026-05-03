// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.HID
// Classes: 3
// Methods: 16

namespace ThirdParty.Unity.UnityEngine.InputSystem.HID
{
    public class HID : InputDevice
    {
        public string kHIDInterface;
        public string kHIDNamespace;
        public bool m_HaveParsedHIDDescriptor; // 0x190
        public HIDDeviceDescriptor m_HIDDescriptor; // 0x198

        // ── Methods ──
        public void get_QueryHIDReportDescriptorDeviceCommandType(){} // RVA: 0x7FFE87A05DA0
        public void get_QueryHIDReportDescriptorSizeDeviceCommandType(){} // RVA: 0x7FFE87A05DB0
        public void get_QueryHIDParsedReportDescriptorDeviceCommandType(){} // RVA: 0x7FFE87A05DC0
        public void get_hidDescriptor(){} // RVA: 0x7FFE87A05DD0
        public void OnFindLayoutForDevice(){} // RVA: 0x7FFE87A05F50
        public void ReadHIDDeviceDescriptor(){} // RVA: 0x7FFE87A06AF0
        public void UsagePageToString(){} // RVA: 0x7FFE87A072D0
        public void UsageToString(){} // RVA: 0x7FFE87A07350
        public void .ctor(){} // RVA: 0x7FFE878BEB80
        public void .cctor(){} // RVA: 0x7FFE87A07410
    }

    public class HIDParser : Object
    {
        // ── Methods ──
        public void ParseReportDescriptor(){} // RVA: 0x7FFE87A0DD20 | overloaded x2
        public void ReadData(){} // RVA: 0x7FFE87A0EC80
    }

    public class HIDSupport : Object
    {
        public HIDPageUsage[] s_SupportedHIDUsages;

        // ── Methods ──
        public void get_supportedHIDUsages(){} // RVA: 0x7FFE87A0F400
        public void set_supportedHIDUsages(){} // RVA: 0x7FFE87A0F4F0
        public void Initialize(){} // RVA: 0x7FFE87A0F880
    }

}