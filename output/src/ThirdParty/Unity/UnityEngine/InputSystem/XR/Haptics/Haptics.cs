// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.XR.Haptics
// Classes: 7
// Methods: 33

namespace ThirdParty.Unity.UnityEngine.InputSystem.XR.Haptics
{
    public class BufferedRumble
    {
        public UnityEngine.InputSystem.XR.Haptics.HapticCapabilities _capabilities; // 0x10
        public UnityEngine.InputSystem.InputDevice _device; // 0x28

        // ── Methods ──
        public void get_capabilities(){} // RVA: 0x6EA27A0
        public void set_capabilities(){} // RVA: 0x6EA27B0
        public void get_device(){} // RVA: 0x2E07C0
        public void set_device(){} // RVA: 0x343E80
        public void .ctor(){} // RVA: 0x6EA27C0
        public void EnqueueRumble(){} // RVA: 0x6EA2960
    }

    public class GetCurrentHapticStateCommand
    {
        public int kSize;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand; // 0x10
        public uint samplesQueued; // 0x18

        // ── Methods ──
        public void get_Type(){} // RVA: 0x6EA2B90
        public void get_typeStatic(){} // RVA: 0x6EA2B90
        public void get_currentState(){} // RVA: 0x6EA2BA0
        public void Create(){} // RVA: 0x6EA2BC0
    }

    public class GetHapticCapabilitiesCommand
    {
        public int kSize;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand; // 0x10
        public uint numChannels; // 0x18

        // ── Methods ──
        public void get_Type(){} // RVA: 0x6EA2C30
        public void get_typeStatic(){} // RVA: 0x6EA2C30
        public void get_capabilities(){} // RVA: 0x6EA2C40
        public void Create(){} // RVA: 0x6EA2C70
    }

    public class HapticCapabilities
    {
        public uint <numChannels>k__BackingField; // 0x10
        public bool <supportsImpulse>k__BackingField; // 0x14
        public bool <supportsBuffer>k__BackingField; // 0x15
        public uint <frequencyHz>k__BackingField; // 0x18
        public uint <maxBufferSize>k__BackingField; // 0x1C
        public uint <optimalBufferSize>k__BackingField; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6EA2C10 | overloaded x2
        public void get_numChannels(){} // RVA: 0x19689B0
        public void get_supportsImpulse(){} // RVA: 0x1EED2E0
        public void get_supportsBuffer(){} // RVA: 0x1EED2F0
        public void get_frequencyHz(){} // RVA: 0x1EA9890
        public void get_maxBufferSize(){} // RVA: 0x1EA98B0
        public void get_optimalBufferSize(){} // RVA: 0x32A5C0
    }

    public class HapticState
    {
        public uint numChannels; // 0x10
        public uint supportsImpulse; // 0x14

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8AE010
        public void get_samplesQueued(){} // RVA: 0x19689B0
        public void set_samplesQueued(){} // RVA: 0x833580
        public void get_samplesAvailable(){} // RVA: 0x19689E0
        public void set_samplesAvailable(){} // RVA: 0x19689D0
    }

    public class SendBufferedHapticCommand
    {
        public int kMaxHapticBufferSize;
        public int kSize;

        // ── Methods ──
        public void get_Type(){} // RVA: 0x6EA2CA0
        public void get_typeStatic(){} // RVA: 0x6EA2CA0
        public void Create(){} // RVA: 0x6EA2CB0
    }

    public class SendHapticImpulseCommand
    {
        public int kSize;
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand; // 0x10

        // ── Methods ──
        public void get_Type(){} // RVA: 0x6EA2E50
        public void get_typeStatic(){} // RVA: 0x6EA2E50
        public void Create(){} // RVA: 0x6EA2E60
    }

}