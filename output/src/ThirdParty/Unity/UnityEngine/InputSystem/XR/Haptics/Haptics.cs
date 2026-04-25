// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.XR.Haptics
// Classes: 5
// Methods: 20

namespace ThirdParty.Unity.UnityEngine.InputSystem.XR.Haptics
{
    public class BufferedRumble : ValueType
    {
        public 0x664AA090 capabilities; // 0x10
        public UnityEngine.InputSystem.InputDevice device; // 0x28

        // ── Methods ──
        public void get_capabilities(){} // RVA: 0x7FFD54A5AEF0
        public void set_capabilities(){} // RVA: 0x7FFD54A5AF00
        public void get_device(){} // RVA: 0x7FFD4E3447C0
        public void set_device(){} // RVA: 0x7FFD4E3A7E80
        public void .ctor(){} // RVA: 0x7FFD54A5AF10
        public void EnqueueRumble(){} // RVA: 0x7FFD54A5B0B0
    }

    public class GetCurrentHapticStateCommand : ValueType
    {
        public int Type;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand typeStatic; // 0x10
        public uint currentState; // 0x18
        public uint samplesAvailable; // 0x1C

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFD54A5B2E0
        public void get_typeStatic(){} // RVA: 0x7FFD54A5B2E0
        public void get_currentState(){} // RVA: 0x7FFD54A5B2F0
        public void Create(){} // RVA: 0x7FFD54A5B310
    }

    public class GetHapticCapabilitiesCommand : ValueType
    {
        public int Type;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand typeStatic; // 0x10
        public uint capabilities; // 0x18
        public bool supportsImpulse; // 0x1C
        public bool supportsBuffer; // 0x1D
        public uint frequencyHz; // 0x20
        public uint maxBufferSize; // 0x24
        public uint optimalBufferSize; // 0x28

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFD54A5B380
        public void get_typeStatic(){} // RVA: 0x7FFD54A5B380
        public void get_capabilities(){} // RVA: 0x7FFD54A5B390
        public void Create(){} // RVA: 0x7FFD54A5B3C0
    }

    public class SendBufferedHapticCommand : ValueType
    {
        public int Type;
        public int typeStatic;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand; // 0x10
        public int channel; // 0x18
        public int bufferSize; // 0x1C
        public 0x664AA140 buffer; // 0x20

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFD54A5B3F0
        public void get_typeStatic(){} // RVA: 0x7FFD54A5B3F0
        public void Create(){} // RVA: 0x7FFD54A5B400
    }

    public class SendHapticImpulseCommand : ValueType
    {
        public int Type;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand typeStatic; // 0x10
        public int channel; // 0x18
        public float amplitude; // 0x1C
        public float duration; // 0x20

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFD54A5B5A0
        public void get_typeStatic(){} // RVA: 0x7FFD54A5B5A0
        public void Create(){} // RVA: 0x7FFD54A5B5B0
    }

}