// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.XR.Haptics
// Classes: 7
// Methods: 32

namespace ThirdParty.Unity.UnityEngine.InputSystem.XR.Haptics
{
    public class BufferedRumble : ValueType
    {
        public object _capabilities;
        public object _device;

        // ── Methods ──
        public void get_capabilities(){} // RVA: 0x935840
        public void set_capabilities(){} // RVA: 0x935860
        public void get_device(){} // RVA: 0x931A0
        public void set_device(){} // RVA: 0x93120
        public void .ctor(){} // RVA: 0x935870
        public void EnqueueRumble(){} // RVA: 0x935A00
    }

    public class GetCurrentHapticStateCommand : ValueType
    {
        public object kSize;
        public object baseCommand;
        public object samplesQueued;
        public object samplesAvailable;

        // ── Methods ──
        public void get_Type(){} // RVA: 0x78EEFA0
        public void get_typeStatic(){} // RVA: 0x935C30
        public void get_currentState(){} // RVA: 0x935C40
        public void Create(){} // RVA: 0x78EEFD0
    }

    public class GetHapticCapabilitiesCommand : ValueType
    {
        public object kSize;
        public object baseCommand;
        public object numChannels;
        public object supportsImpulse;
        public object supportsBuffer;
        public object frequencyHz;
        public object maxBufferSize;
        public object optimalBufferSize;

        // ── Methods ──
        public void get_Type(){} // RVA: 0x78EF040
        public void get_typeStatic(){} // RVA: 0x935D80
        public void get_capabilities(){} // RVA: 0x935D90
        public void Create(){} // RVA: 0x78EF080
    }

    public class HapticCapabilities : ValueType
    {
        public object _numChannels;
        public object _supportsImpulse;
        public object _supportsBuffer;
        public object _frequencyHz;
        public object _maxBufferSize;
        public object _optimalBufferSize;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x935CF0
        public void get_numChannels(){} // RVA: 0x77E60
        public void get_supportsImpulse(){} // RVA: 0x9B0B0
        public void get_supportsBuffer(){} // RVA: 0x9B0F0
        public void get_frequencyHz(){} // RVA: 0x14790
        public void get_maxBufferSize(){} // RVA: 0x92DE0
        public void get_optimalBufferSize(){} // RVA: 0x8C7E0
    }

    public class HapticState : ValueType
    {
        public object _samplesQueued;
        public object _samplesAvailable;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2B100
        public void get_samplesQueued(){} // RVA: 0x77E60
        public void set_samplesQueued(){} // RVA: 0x29580
        public void get_samplesAvailable(){} // RVA: 0x77E50
        public void set_samplesAvailable(){} // RVA: 0x77EE0
    }

    public class SendBufferedHapticCommand : ValueType
    {
        public object kMaxHapticBufferSize;
        public object kSize;
        public object baseCommand;
        public object channel;
        public object bufferSize;
        public object buffer;

        // ── Methods ──
        public void get_Type(){} // RVA: 0x78EF0B0
        public void get_typeStatic(){} // RVA: 0x935DE0
        public void Create(){} // RVA: 0x78EF0C0
    }

    public class SendHapticImpulseCommand : ValueType
    {
        public object kSize;
        public object baseCommand;
        public object channel;
        public object amplitude;
        public object duration;

        // ── Methods ──
        public void get_Type(){} // RVA: 0x78EF250
        public void get_typeStatic(){} // RVA: 0x935DF0
        public void Create(){} // RVA: 0x78EF260
    }

}