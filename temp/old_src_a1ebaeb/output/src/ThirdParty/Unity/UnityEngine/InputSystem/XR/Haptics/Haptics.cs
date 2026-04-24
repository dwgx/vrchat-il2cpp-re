// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.XR.Haptics
// Classes: 5
// Methods: 20

namespace ThirdParty.Unity.UnityEngine.InputSystem.XR.Haptics
{
    public class BufferedRumble : ValueType
    {
        public object _numChannels; // 0x83E5B060, was: <numChannels>k__BackingField

        // ── Original Methods ──
        public void get_capabilities(){} // RVA: 0x7ffaaf05ced0
        public void set_capabilities(){} // RVA: 0x7ffaaf05cee0
        public void get_device(){} // RVA: 0x7ffaa89357c0
        public void set_device(){} // RVA: 0x7ffaa8998e80
        public void .ctor(){} // RVA: 0x7ffaaf05cef0
        public void EnqueueRumble(){} // RVA: 0x7ffaaf05d090
    }

    public class GetCurrentHapticStateCommand : ValueType
    {
        public object samplesQueued; // 0x332CB090
        public object BaseCommandSize; // 0x334E95A0

        // ── Original Methods ──
        public void get_Type(){} // RVA: 0x7ffaaf05d2c0
        public void get_typeStatic(){} // RVA: 0x7ffaaf05d2c0
        public void get_currentState(){} // RVA: 0x7ffaaf05d2d0
        public void Create(){} // RVA: 0x7ffaaf05d2f0
    }

    public class GetHapticCapabilitiesCommand : ValueType
    {
        public object numChannels; // 0x3353B6C0
        public object frequencyHz; // 0x3353B6C0

        // ── Original Methods ──
        public void get_Type(){} // RVA: 0x7ffaaf05d360
        public void get_typeStatic(){} // RVA: 0x7ffaaf05d360
        public void get_capabilities(){} // RVA: 0x7ffaaf05d370
        public void Create(){} // RVA: 0x7ffaaf05d3a0
    }

    public class SendBufferedHapticCommand : ValueType
    {
        public object baseCommand; // 0x33C2EA70
        public object buffer; // 0x33C2EA70
        public object Type; // 0x17000352
        public object typeStatic; // 0x17000353

        // ── Original Methods ──
        public void get_Type(){} // RVA: 0x7ffaaf05d3d0
        public void get_typeStatic(){} // RVA: 0x7ffaaf05d3d0
        public void Create(){} // RVA: 0x7ffaaf05d3e0
    }

    public class SendHapticImpulseCommand : ValueType
    {
        public object channel; // 0x33755390

        // ── Original Methods ──
        public void get_Type(){} // RVA: 0x7ffaaf05d580
        public void get_typeStatic(){} // RVA: 0x7ffaaf05d580
        public void Create(){} // RVA: 0x7ffaaf05d590
    }

}