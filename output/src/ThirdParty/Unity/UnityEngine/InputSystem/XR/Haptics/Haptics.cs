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
        public void get_capabilities(){} // RVA: 0x7FFAF99527A0
        public void set_capabilities(){} // RVA: 0x7FFAF99527B0
        public void get_device(){} // RVA: 0x7FFAF2D907C0
        public void set_device(){} // RVA: 0x7FFAF2DF3E80
        public void .ctor(){} // RVA: 0x7FFAF99527C0
        public void EnqueueRumble(){} // RVA: 0x7FFAF9952960
    }

    public class GetCurrentHapticStateCommand
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAF9952B90
        public void get_typeStatic(){} // RVA: 0x7FFAF9952B90
        public void get_currentState(){} // RVA: 0x7FFAF9952BA0
        public void Create(){} // RVA: 0x7FFAF9952BC0
    }

    public class GetHapticCapabilitiesCommand
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAF9952C30
        public void get_typeStatic(){} // RVA: 0x7FFAF9952C30
        public void get_capabilities(){} // RVA: 0x7FFAF9952C40
        public void Create(){} // RVA: 0x7FFAF9952C70
    }

    public class HapticCapabilities
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9952C10 | overloaded x2
        public void get_numChannels(){} // RVA: 0x7FFAF44189B0
        public void get_supportsImpulse(){} // RVA: 0x7FFAF499D2E0
        public void get_supportsBuffer(){} // RVA: 0x7FFAF499D2F0
        public void get_frequencyHz(){} // RVA: 0x7FFAF4959890
        public void get_maxBufferSize(){} // RVA: 0x7FFAF49598B0
        public void get_optimalBufferSize(){} // RVA: 0x7FFAF2DDA5C0
    }

    public class HapticState
    {
        public object numChannels;
        public object supportsImpulse;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF335E010
        public void get_samplesQueued(){} // RVA: 0x7FFAF44189B0
        public void set_samplesQueued(){} // RVA: 0x7FFAF32E3580
        public void get_samplesAvailable(){} // RVA: 0x7FFAF44189E0
        public void set_samplesAvailable(){} // RVA: 0x7FFAF44189D0
    }

    public class SendBufferedHapticCommand
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAF9952CA0
        public void get_typeStatic(){} // RVA: 0x7FFAF9952CA0
        public void Create(){} // RVA: 0x7FFAF9952CB0
    }

    public class SendHapticImpulseCommand
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAF9952E50
        public void get_typeStatic(){} // RVA: 0x7FFAF9952E50
        public void Create(){} // RVA: 0x7FFAF9952E60
    }

}