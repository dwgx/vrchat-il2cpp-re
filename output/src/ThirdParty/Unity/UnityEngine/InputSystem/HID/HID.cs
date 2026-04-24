// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.HID
// Classes: 3
// Methods: 16

namespace ThirdParty.Unity.UnityEngine.InputSystem.HID
{
    public class HID : InputDevice
    {
        public object QueryHIDReportDescriptorDeviceCommandType;
        public object QueryHIDReportDescriptorSizeDeviceCommandType;
        public object QueryHIDParsedReportDescriptorDeviceCommandType;
        public object hidDescriptor;

        // ── Methods ──
        public void get_QueryHIDReportDescriptorDeviceCommandType(){} // RVA: 0x7FFD54A7D640
        public void get_QueryHIDReportDescriptorSizeDeviceCommandType(){} // RVA: 0x7FFD54A7D650
        public void get_QueryHIDParsedReportDescriptorDeviceCommandType(){} // RVA: 0x7FFD54A7D660
        public void get_hidDescriptor(){} // RVA: 0x7FFD54A7D670
        public void OnFindLayoutForDevice(){} // RVA: 0x7FFD54A7D7F0
        public void ReadHIDDeviceDescriptor(){} // RVA: 0x7FFD54A7E390
        public void UsagePageToString(){} // RVA: 0x7FFD54A7EB70
        public void UsageToString(){} // RVA: 0x7FFD54A7EBF0
        public void .ctor(){} // RVA: 0x7FFD54936440
        public void .cctor(){} // RVA: 0x7FFD54A7ECB0
    }

    public class HIDParser : Object
    {
        public object group; // 0x20
        public hpClassPrefix tabListBinding; // 0x28
        public BuffersImpl contentContainer; // 0x30
        public BuffersImpl tabPrefab; // 0x38
        public ÌÏÎÌÎÎÎÌÍÍÏÌÎÏÌÎÏ ÍÎÌÌÎÍÍÍÎÍÏÌÎÏÏÍÏÏÏÌÎÍÍ; // 0x40
        public ?<ÏÌÏÏÌÏÏÍÌÏÍÎÍÌÍÍÏ,ÌÍÏÏÎÎÍÌÌÎÏÏÍÌÍÎÍ> ÎÍÌÏÎÏÎÎÍÍÍÏÏÎÎÏÌÎÍÍÎÌÎ; // 0x48

        // ── Methods ──
        public void ParseReportDescriptor(){} // RVA: 0x7FFD54A855C0 | overloaded x2
        public void ReadData(){} // RVA: 0x7FFD54A86520
    }

    public class HIDSupport : Object
    {
        public object supportedHIDUsages;

        // ── Methods ──
        public void get_supportedHIDUsages(){} // RVA: 0x7FFD54A86CA0
        public void set_supportedHIDUsages(){} // RVA: 0x7FFD54A86D90
        public void Initialize(){} // RVA: 0x7FFD54A87120
    }

}