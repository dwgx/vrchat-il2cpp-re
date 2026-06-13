// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.DualShock.LowLevel
// Classes: 7
// Methods: 16

namespace ThirdParty.Unity.UnityEngine.InputSystem.DualShock.LowLevel
{
    public class DualSenseHIDBluetoothOutputReport
    {
        public int kSize;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand; // 0x10

        // ── Methods ──
        public void get_Type(){} // RVA: 0x6EBFB80
        public void get_typeStatic(){} // RVA: 0x6EBFB80
        public void Create(){} // RVA: 0x6EDA320
    }

    public class DualSenseHIDInputReport
    {
        public UnityEngine.InputSystem.Utilities.FourCC Format;

        // ── Methods ──
        public void get_format(){} // RVA: 0x6EDA230
        public void .cctor(){} // RVA: 0x6EDA290
    }

    public class DualSenseHIDOutputReportPayload
    {
    }

    public class DualSenseHIDUSBOutputReport
    {
        public int kSize;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand; // 0x10

        // ── Methods ──
        public void get_Type(){} // RVA: 0x6EBFB80
        public void get_typeStatic(){} // RVA: 0x6EBFB80
        public void Create(){} // RVA: 0x6EDA2D0
    }

    public class DualShock3HIDInputReport
    {
        public ushort padding1; // 0x10

        // ── Methods ──
        public void get_format(){} // RVA: 0x6EBFB70
    }

    public class DualShock4HIDInputReport
    {
        public UnityEngine.InputSystem.Utilities.FourCC Format;

        // ── Methods ──
        public void get_format(){} // RVA: 0x6EDA390
        public void .cctor(){} // RVA: 0x6EDA3F0
    }

    public class DualShockHIDOutputReport
    {
        public int kSize;
        public int kReportId;

        // ── Methods ──
        public void get_Type(){} // RVA: 0x6EBFB80
        public void get_typeStatic(){} // RVA: 0x6EBFB80
        public void SetMotorSpeeds(){} // RVA: 0x6EDA430
        public void SetColor(){} // RVA: 0x6EDA480
        public void Create(){} // RVA: 0x6EDA500
    }

}