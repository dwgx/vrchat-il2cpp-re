// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.DualShock.LowLevel
// Classes: 7
// Methods: 16

namespace ThirdParty.Unity.UnityEngine.InputSystem.DualShock.LowLevel
{
    public class DualSenseHIDBluetoothOutputReport : ValueType
    {
        public int Type;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand typeStatic; // 0x10
        public byte reportId; // 0x18
        public byte tag1; // 0x19
        public byte tag2; // 0x1A
        public UnityEngine.InputSystem.DualShock.LowLevel.DualSenseHIDOutputReportPayload payload; // 0x1B
        public uint crc32; // 0x62
        public <rawData>e__FixedBuffer rawData; // 0x18

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAC96582B0
        public void get_typeStatic(){} // RVA: 0x7FFAC96582B0
        public void Create(){} // RVA: 0x7FFAC9672A50
    }

    public class DualSenseHIDInputReport : ValueType
    {
        public UnityEngine.InputSystem.Utilities.FourCC format;
        public byte leftStickX; // 0x10
        public byte leftStickY; // 0x11
        public byte rightStickX; // 0x12
        public byte rightStickY; // 0x13
        public byte leftTrigger; // 0x14
        public byte rightTrigger; // 0x15
        public byte buttons0; // 0x16
        public byte buttons1; // 0x17
        public byte buttons2; // 0x18

        // ── Methods ──
        public void get_format(){} // RVA: 0x7FFAC9672960
        public void .cctor(){} // RVA: 0x7FFAC96729C0
    }

    public class DualSenseHIDOutputReportPayload : ValueType
    {
        public byte enableFlags1; // 0x10
        public byte enableFlags2; // 0x11
        public byte highFrequencyMotorSpeed; // 0x12
        public byte lowFrequencyMotorSpeed; // 0x13
        public byte redColor; // 0x3C
        public byte greenColor; // 0x3D
        public byte blueColor; // 0x3E
    }

    public class DualSenseHIDUSBOutputReport : ValueType
    {
        public int Type;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand typeStatic; // 0x10
        public byte reportId; // 0x18
        public UnityEngine.InputSystem.DualShock.LowLevel.DualSenseHIDOutputReportPayload payload; // 0x19

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAC96582B0
        public void get_typeStatic(){} // RVA: 0x7FFAC96582B0
        public void Create(){} // RVA: 0x7FFAC9672A00
    }

    public class DualShock3HIDInputReport : ValueType
    {
        public ushort format; // 0x10
        public byte buttons1; // 0x12
        public byte buttons2; // 0x13
        public byte buttons3; // 0x14
        public byte padding2; // 0x15
        public byte leftStickX; // 0x16
        public byte leftStickY; // 0x17
        public byte rightStickX; // 0x18
        public byte rightStickY; // 0x19
        public <padding3>e__FixedBuffer padding3; // 0x1A
        public byte leftTrigger; // 0x22
        public byte rightTrigger; // 0x23

        // ── Methods ──
        public void get_format(){} // RVA: 0x7FFAC96582A0
    }

    public class DualShock4HIDInputReport : ValueType
    {
        public UnityEngine.InputSystem.Utilities.FourCC format;
        public byte leftStickX; // 0x10
        public byte leftStickY; // 0x11
        public byte rightStickX; // 0x12
        public byte rightStickY; // 0x13
        public byte buttons1; // 0x14
        public byte buttons2; // 0x15
        public byte buttons3; // 0x16
        public byte leftTrigger; // 0x17
        public byte rightTrigger; // 0x18

        // ── Methods ──
        public void get_format(){} // RVA: 0x7FFAC9672AC0
        public void .cctor(){} // RVA: 0x7FFAC9672B20
    }

    public class DualShockHIDOutputReport : ValueType
    {
        public int Type;
        public int typeStatic;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand; // 0x10
        public byte reportId; // 0x18
        public byte flags; // 0x19
        public <unknown1>e__FixedBuffer unknown1; // 0x1A
        public byte highFrequencyMotorSpeed; // 0x1C
        public byte lowFrequencyMotorSpeed; // 0x1D
        public byte redColor; // 0x1E
        public byte greenColor; // 0x1F
        public byte blueColor; // 0x20
        public <unknown2>e__FixedBuffer unknown2; // 0x21

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAC96582B0
        public void get_typeStatic(){} // RVA: 0x7FFAC96582B0
        public void SetMotorSpeeds(){} // RVA: 0x7FFAC9672B60
        public void SetColor(){} // RVA: 0x7FFAC9672BB0
        public void Create(){} // RVA: 0x7FFAC9672C30
    }

}