// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.XR.Haptics
// Classes: 7
// Methods: 33

namespace ThirdParty.Unity.UnityEngine.InputSystem.XR.Haptics
{
    public class BufferedRumble
    {
        public object _capabilities;
        public object _device;

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
        // ── Methods ──
        public void get_Type(){} // RVA: 0x6EA2B90
        public void get_typeStatic(){} // RVA: 0x6EA2B90
        public void get_currentState(){} // RVA: 0x6EA2BA0
        public void Create(){} // RVA: 0x6EA2BC0
    }

    public class GetHapticCapabilitiesCommand
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x6EA2C30
        public void get_typeStatic(){} // RVA: 0x6EA2C30
        public void get_capabilities(){} // RVA: 0x6EA2C40
        public void Create(){} // RVA: 0x6EA2C70
    }

    public class HapticCapabilities
    {
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
        public object numChannels;
        public object supportsImpulse;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8AE010
        public void get_samplesQueued(){} // RVA: 0x19689B0
        public void set_samplesQueued(){} // RVA: 0x833580
        public void get_samplesAvailable(){} // RVA: 0x19689E0
        public void set_samplesAvailable(){} // RVA: 0x19689D0
    }

    public class SendBufferedHapticCommand
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x6EA2CA0
        public void get_typeStatic(){} // RVA: 0x6EA2CA0
        public void Create(){} // RVA: 0x6EA2CB0
    }

    public class SendHapticImpulseCommand
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x6EA2E50
        public void get_typeStatic(){} // RVA: 0x6EA2E50
        public void Create(){} // RVA: 0x6EA2E60
    }

}