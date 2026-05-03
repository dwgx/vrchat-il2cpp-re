// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.XR.Haptics
// Classes: 7
// Methods: 33

namespace ThirdParty.Unity.UnityEngine.InputSystem.XR.Haptics
{
    public class BufferedRumble : ValueType
    {
        public UnityEngine.InputSystem.XR.Haptics.HapticCapabilities _capabilities; // 0x10
        public UnityEngine.InputSystem.InputDevice _device; // 0x28

        // ── Methods ──
        public void get_capabilities(){} // RVA: 0x7FFE879E3630
        public void set_capabilities(){} // RVA: 0x7FFE879E3640
        public void get_device(){} // RVA: 0x7FFE810FE7C0
        public void set_device(){} // RVA: 0x7FFE81161E80
        public void .ctor(){} // RVA: 0x7FFE879E3650
        public void EnqueueRumble(){} // RVA: 0x7FFE879E37F0
    }

    public class GetCurrentHapticStateCommand : ValueType
    {
        public int kSize;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand; // 0x10
        public uint samplesQueued; // 0x18

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFE879E3A20
        public void get_typeStatic(){} // RVA: 0x7FFE879E3A20
        public void get_currentState(){} // RVA: 0x7FFE879E3A30
        public void Create(){} // RVA: 0x7FFE879E3A50
    }

    public class GetHapticCapabilitiesCommand : ValueType
    {
        public int kSize;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand; // 0x10
        public uint numChannels; // 0x18

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFE879E3AC0
        public void get_typeStatic(){} // RVA: 0x7FFE879E3AC0
        public void get_capabilities(){} // RVA: 0x7FFE879E3AD0
        public void Create(){} // RVA: 0x7FFE879E3B00
    }

    public class HapticCapabilities : ValueType
    {
        public uint _numChannels; // 0x10
        public bool _supportsImpulse; // 0x14
        public bool _supportsBuffer; // 0x15
        public uint _frequencyHz; // 0x18
        public uint _maxBufferSize; // 0x1C
        public uint _optimalBufferSize; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE879E3AA0 | overloaded x2
        public void get_numChannels(){} // RVA: 0x7FFE826F4220
        public void get_supportsImpulse(){} // RVA: 0x7FFE82C770F0
        public void get_supportsBuffer(){} // RVA: 0x7FFE82C77100
        public void get_frequencyHz(){} // RVA: 0x7FFE82C33000
        public void get_maxBufferSize(){} // RVA: 0x7FFE82C33020
        public void get_optimalBufferSize(){} // RVA: 0x7FFE811485C0
    }

    public class HapticState : ValueType
    {
        public uint _samplesQueued; // 0x10
        public uint _samplesAvailable; // 0x14

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8164E250
        public void get_samplesQueued(){} // RVA: 0x7FFE826F4220
        public void set_samplesQueued(){} // RVA: 0x7FFE815BF990
        public void get_samplesAvailable(){} // RVA: 0x7FFE826F42A0
        public void set_samplesAvailable(){} // RVA: 0x7FFE826F4290
    }

    public class SendBufferedHapticCommand : ValueType
    {
        public int kMaxHapticBufferSize;
        public int kSize;

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFE879E3B30
        public void get_typeStatic(){} // RVA: 0x7FFE879E3B30
        public void Create(){} // RVA: 0x7FFE879E3B40
    }

    public class SendHapticImpulseCommand : ValueType
    {
        public int kSize;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand; // 0x10

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFE879E3CE0
        public void get_typeStatic(){} // RVA: 0x7FFE879E3CE0
        public void Create(){} // RVA: 0x7FFE879E3CF0
    }

}