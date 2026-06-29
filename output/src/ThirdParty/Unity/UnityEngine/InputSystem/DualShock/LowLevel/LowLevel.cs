// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.DualShock.LowLevel
// Classes: 6
// Methods: 16

namespace ThirdParty.Unity.UnityEngine.InputSystem.DualShock.LowLevel
{
    public class DualSenseHIDBluetoothOutputReport : ValueType
    {
        public object kSize;
        public object baseCommand;
        public object reportId;
        public object tag1;
        public object tag2;
        public object payload;
        public object crc32;
        public object rawData;

        // ── Methods ──
        public void get_Type(){} // RVA: 0x790C350
        public void get_typeStatic(){} // RVA: 0x937D60
        public void Create(){} // RVA: 0x79267C0
    }

    public class DualSenseHIDInputReport : ValueType
    {
        public object Format;
        public object leftStickX;
        public object leftStickY;
        public object rightStickX;
        public object rightStickY;
        public object leftTrigger;
        public object rightTrigger;
        public object buttons0;
        public object buttons1;
        public object buttons2;

        // ── Methods ──
        public void get_format(){} // RVA: 0x939F50
        public void .cctor(){} // RVA: 0x7926730
    }

    public class DualSenseHIDUSBOutputReport : ValueType
    {
        public object kSize;
        public object baseCommand;
        public object reportId;
        public object payload;

        // ── Methods ──
        public void get_Type(){} // RVA: 0x790C350
        public void get_typeStatic(){} // RVA: 0x937D60
        public void Create(){} // RVA: 0x7926770
    }

    public class DualShock3HIDInputReport : ValueType
    {
        public object padding1;
        public object buttons1;
        public object buttons2;
        public object buttons3;
        public object padding2;
        public object leftStickX;
        public object leftStickY;
        public object rightStickX;
        public object rightStickY;
        public object padding3;
        public object leftTrigger;
        public object rightTrigger;

        // ── Methods ──
        public void get_format(){} // RVA: 0x93A010
    }

    public class DualShock4HIDInputReport : ValueType
    {
        public object Format;
        public object leftStickX;
        public object leftStickY;
        public object rightStickX;
        public object rightStickY;
        public object buttons1;
        public object buttons2;
        public object buttons3;
        public object leftTrigger;
        public object rightTrigger;

        // ── Methods ──
        public void get_format(){} // RVA: 0x939FB0
        public void .cctor(){} // RVA: 0x7926890
    }

    public class DualShockHIDOutputReport : ValueType
    {
        public object kSize;
        public object kReportId;
        public object baseCommand;
        public object reportId;
        public object flags;
        public object unknown1;
        public object highFrequencyMotorSpeed;
        public object lowFrequencyMotorSpeed;
        public object redColor;
        public object greenColor;
        public object blueColor;
        public object unknown2;

        // ── Methods ──
        public void get_Type(){} // RVA: 0x790C350
        public void get_typeStatic(){} // RVA: 0x937D60
        public void SetMotorSpeeds(){} // RVA: 0x93A020
        public void SetColor(){} // RVA: 0x93A070
        public void Create(){} // RVA: 0x79269A0
    }

}