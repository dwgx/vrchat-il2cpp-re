// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.Switch.LowLevel
// Classes: 1
// Methods: 6

namespace ThirdParty.Unity.UnityEngine.InputSystem.Switch.LowLevel
{
    public class SwitchProControllerHIDInputState : ValueType
    {
        public UnityEngine.InputSystem.Utilities.FourCC format;
        public byte leftStickX; // 0x10
        public byte leftStickY; // 0x11
        public byte rightStickX; // 0x12
        public byte rightStickY; // 0x13
        public ushort buttons1; // 0x14
        public byte buttons2; // 0x16

        // ── Methods ──
        public void get_format(){} // RVA: 0x7FFAC9658BF0
        public void WithButton(){} // RVA: 0x7FFAC9658C50
        public void Set(){} // RVA: 0x7FFAC9658D30
        public void Press(){} // RVA: 0x7FFAC9658DA0
        public void Release(){} // RVA: 0x7FFAC9658E30
        public void .cctor(){} // RVA: 0x7FFAC9658EC0
    }

}