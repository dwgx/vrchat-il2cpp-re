// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.DualShock.LowLevel
// Classes: 7
// Methods: 16

namespace ThirdParty.Unity.UnityEngine.InputSystem.DualShock.LowLevel
{
    public class DualSenseHIDBluetoothOutputReport : ValueType
    {
        public int kSize;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand; // 0x10

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFE87A00A10
        public void get_typeStatic(){} // RVA: 0x7FFE87A00A10
        public void Create(){} // RVA: 0x7FFE87A1B1B0
    }

    public class DualSenseHIDInputReport : ValueType
    {
        public UnityEngine.InputSystem.Utilities.FourCC Format;

        // ── Methods ──
        public void get_format(){} // RVA: 0x7FFE87A1B0C0
        public void .cctor(){} // RVA: 0x7FFE87A1B120
    }

    public class DualSenseHIDOutputReportPayload : ValueType
    {
    }

    public class DualSenseHIDUSBOutputReport : ValueType
    {
        public int kSize;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand; // 0x10

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFE87A00A10
        public void get_typeStatic(){} // RVA: 0x7FFE87A00A10
        public void Create(){} // RVA: 0x7FFE87A1B160
    }

    public class DualShock3HIDInputReport : ValueType
    {
        public ushort padding1; // 0x10

        // ── Methods ──
        public void get_format(){} // RVA: 0x7FFE87A00A00
    }

    public class DualShock4HIDInputReport : ValueType
    {
        public UnityEngine.InputSystem.Utilities.FourCC Format;

        // ── Methods ──
        public void get_format(){} // RVA: 0x7FFE87A1B220
        public void .cctor(){} // RVA: 0x7FFE87A1B280
    }

    public class DualShockHIDOutputReport : ValueType
    {
        public int kSize;
        public int kReportId;

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFE87A00A10
        public void get_typeStatic(){} // RVA: 0x7FFE87A00A10
        public void SetMotorSpeeds(){} // RVA: 0x7FFE87A1B2C0
        public void SetColor(){} // RVA: 0x7FFE87A1B310
        public void Create(){} // RVA: 0x7FFE87A1B390
    }

}