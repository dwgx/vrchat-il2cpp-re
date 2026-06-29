// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.XR.Haptics
// Classes: 7
// Methods: 33

namespace ThirdParty.Unity.UnityEngine.InputSystem.XR.Haptics
{
    public class BufferedRumble : ValueType
    {
        // ── Methods ──
        public void get_capabilities(){} // RVA: 0x7A7EB3D70
        public void set_capabilities(){} // RVA: 0x7A7EB3D90
        public void get_device(){} // RVA: 0x7A767FF40
        public void set_device(){} // RVA: 0x7A767FF60
        public void .ctor(){} // RVA: 0x7A7EB3DA0
        public void EnqueueRumble(){} // RVA: 0x7A7EB3F30
        public void <capabilities>k__BackingField(){} // RVA: 0x7B41E5AF8
    }

    public class GetCurrentHapticStateCommand : ValueType
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x7AEC811B0
        public void get_typeStatic(){} // RVA: 0x7A7EB4160
        public void get_currentState(){} // RVA: 0x7A7EB4170
        public void Create(){} // RVA: 0x7AEC811E0
    }

    public class GetHapticCapabilitiesCommand : ValueType
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x7AEC81250
        public void get_typeStatic(){} // RVA: 0x7A7EB42B0
        public void get_capabilities(){} // RVA: 0x7A7EB42C0
        public void Create(){} // RVA: 0x7AEC81290
    }

    public class HapticCapabilities : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7EB4220
        public void get_numChannels(){} // RVA: 0x7A765F070
        public void get_supportsImpulse(){} // RVA: 0x7A7687090
        public void get_supportsBuffer(){} // RVA: 0x7A76870F0
        public void get_frequencyHz(){} // RVA: 0x7A75FEFA0
        public void get_maxBufferSize(){} // RVA: 0x7A767FBD0
        public void get_optimalBufferSize(){} // RVA: 0x7A7677B20
    }

    public class HapticState : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7615330
        public void get_samplesQueued(){} // RVA: 0x7A765F070
        public void set_samplesQueued(){} // RVA: 0x7A76134D0
        public void get_samplesAvailable(){} // RVA: 0x7A765F0A0
        public void set_samplesAvailable(){} // RVA: 0x7A765F090
    }

    public class SendBufferedHapticCommand : ValueType
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x7AEC812C0
        public void get_typeStatic(){} // RVA: 0x7A7EB4310
        public void Create(){} // RVA: 0x7AEC812D0
    }

    public class SendHapticImpulseCommand : ValueType
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x7AEC81460
        public void get_typeStatic(){} // RVA: 0x7A7EB4320
        public void Create(){} // RVA: 0x7AEC81470
    }

}