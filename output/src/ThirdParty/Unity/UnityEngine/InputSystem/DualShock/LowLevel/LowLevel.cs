// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.DualShock.LowLevel
// Classes: 1
// Methods: 2

namespace ThirdParty.Unity.UnityEngine.InputSystem.DualShock.LowLevel
{
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
        public void get_format(){} // RVA: 0x7FFD54A92960
        public void .cctor(){} // RVA: 0x7FFD54A929C0
    }

}