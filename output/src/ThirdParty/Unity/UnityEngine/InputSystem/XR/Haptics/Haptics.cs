// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.XR.Haptics
// Classes: 7
// Methods: 33

namespace ThirdParty.Unity.UnityEngine.InputSystem.XR.Haptics
{
    public class BufferedRumble : ValueType
    {
        public UnityEngine.InputSystem.XR.Haptics.HapticCapabilities capabilities; // 0x10
        public UnityEngine.InputSystem.InputDevice device; // 0x28

        // ── Methods ──
        public void get_capabilities(){} // RVA: 0x7FFAC963AEF0
        public void set_capabilities(){} // RVA: 0x7FFAC963AF00
        public void get_device(){} // RVA: 0x7FFAC2F247C0
        public void set_device(){} // RVA: 0x7FFAC2F87E80
        public void .ctor(){} // RVA: 0x7FFAC963AF10
        public void EnqueueRumble(){} // RVA: 0x7FFAC963B0B0
    }

    public class GetCurrentHapticStateCommand : ValueType
    {
        public int Type;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand typeStatic; // 0x10
        public uint currentState; // 0x18
        public uint samplesAvailable; // 0x1C

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAC963B2E0
        public void get_typeStatic(){} // RVA: 0x7FFAC963B2E0
        public void get_currentState(){} // RVA: 0x7FFAC963B2F0
        public void Create(){} // RVA: 0x7FFAC963B310
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
        public void get_Type(){} // RVA: 0x7FFAC963B380
        public void get_typeStatic(){} // RVA: 0x7FFAC963B380
        public void get_capabilities(){} // RVA: 0x7FFAC963B390
        public void Create(){} // RVA: 0x7FFAC963B3C0
    }

    public class HapticCapabilities : ValueType
    {
        public uint numChannels; // 0x10
        public bool supportsImpulse; // 0x14
        public bool supportsBuffer; // 0x15
        public uint frequencyHz; // 0x18
        public uint maxBufferSize; // 0x1C
        public uint optimalBufferSize; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC963B360 | overloaded x2
        public void get_numChannels(){} // RVA: 0x7FFAC4420210
        public void get_supportsImpulse(){} // RVA: 0x7FFAC4A0B160
        public void get_supportsBuffer(){} // RVA: 0x7FFAC4A0B150
        public void get_frequencyHz(){} // RVA: 0x7FFAC49C7500
        public void get_maxBufferSize(){} // RVA: 0x7FFAC49C7520
        public void get_optimalBufferSize(){} // RVA: 0x7FFAC2F6E5C0
    }

    public class HapticState : ValueType
    {
        public uint samplesQueued; // 0x10
        public uint samplesAvailable; // 0x14

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC33D6D50
        public void get_samplesQueued(){} // RVA: 0x7FFAC4420210
        public void set_samplesQueued(){} // RVA: 0x7FFAC336D8B0
        public void get_samplesAvailable(){} // RVA: 0x7FFAC44202A0
        public void set_samplesAvailable(){} // RVA: 0x7FFAC4420230
    }

    public class SendBufferedHapticCommand : ValueType
    {
        public int Type;
        public int typeStatic;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand; // 0x10
        public int channel; // 0x18
        public int bufferSize; // 0x1C
        public <buffer>e__FixedBuffer buffer; // 0x20

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAC963B3F0
        public void get_typeStatic(){} // RVA: 0x7FFAC963B3F0
        public void Create(){} // RVA: 0x7FFAC963B400
    }

    public class SendHapticImpulseCommand : ValueType
    {
        public int Type;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand typeStatic; // 0x10
        public int channel; // 0x18
        public float amplitude; // 0x1C
        public float duration; // 0x20

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAC963B5A0
        public void get_typeStatic(){} // RVA: 0x7FFAC963B5A0
        public void Create(){} // RVA: 0x7FFAC963B5B0
    }

}