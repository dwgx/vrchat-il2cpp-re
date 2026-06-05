// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.HID
// Classes: 3
// Methods: 16

namespace ThirdParty.Unity.UnityEngine.InputSystem.HID
{
    public class HID
    {
        // ── Methods ──
        public void get_QueryHIDReportDescriptorDeviceCommandType(){} // RVA: 0x7FFAF9974F10
        public void get_QueryHIDReportDescriptorSizeDeviceCommandType(){} // RVA: 0x7FFAF9974F20
        public void get_QueryHIDParsedReportDescriptorDeviceCommandType(){} // RVA: 0x7FFAF9974F30
        public void get_hidDescriptor(){} // RVA: 0x7FFAF9974F40
        public void OnFindLayoutForDevice(){} // RVA: 0x7FFAF99750C0
        public void ReadHIDDeviceDescriptor(){} // RVA: 0x7FFAF9975C60
        public void UsagePageToString(){} // RVA: 0x7FFAF9976440
        public void UsageToString(){} // RVA: 0x7FFAF99764C0
        public void .ctor(){} // RVA: 0x7FFAF982DCE0
        public void .cctor(){} // RVA: 0x7FFAF9976580
    }

    public class HIDParser
    {
        // ── Methods ──
        public void ParseReportDescriptor(){} // RVA: 0x7FFAF997CE90 | overloaded x2
        public void ReadData(){} // RVA: 0x7FFAF997DDF0
    }

    public class HIDSupport
    {
        // ── Methods ──
        public void get_supportedHIDUsages(){} // RVA: 0x7FFAF997E570
        public void set_supportedHIDUsages(){} // RVA: 0x7FFAF997E660
        public void Initialize(){} // RVA: 0x7FFAF997E9F0
    }

}