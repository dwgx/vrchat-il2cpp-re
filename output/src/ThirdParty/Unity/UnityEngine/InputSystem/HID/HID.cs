// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.HID
// Classes: 3
// Methods: 15

namespace ThirdParty.Unity.UnityEngine.InputSystem.HID
{
    public class HID : InputDevice
    {
        // ── Methods ──
        public void get_QueryHIDReportDescriptorDeviceCommandType(){} // RVA: 0x7AECA3600
        public void get_QueryHIDReportDescriptorSizeDeviceCommandType(){} // RVA: 0x7AECA3610
        public void get_QueryHIDParsedReportDescriptorDeviceCommandType(){} // RVA: 0x7AECA3620
        public void get_hidDescriptor(){} // RVA: 0x7AECA3630
        public void OnFindLayoutForDevice(){} // RVA: 0x7AECA37B0
        public void ReadHIDDeviceDescriptor(){} // RVA: 0x7AECA4360
        public void UsagePageToString(){} // RVA: 0x7AECA4B40
        public void UsageToString(){} // RVA: 0x7AECA4BC0
        public void .ctor(){} // RVA: 0x7AEB6BB90
        public void .cctor(){} // RVA: 0x7AECA4C80
    }

    public class HIDParser : Object
    {
        // ── Methods ──
        public void ParseReportDescriptor(){} // RVA: 0x7AECAB720
        public void ReadData(){} // RVA: 0x7AECAC670
    }

    public class HIDSupport : Object
    {
        // ── Methods ──
        public void get_supportedHIDUsages(){} // RVA: 0x7AECACDE0
        public void set_supportedHIDUsages(){} // RVA: 0x7AECACED0
        public void Initialize(){} // RVA: 0x7AECAD240
    }

}