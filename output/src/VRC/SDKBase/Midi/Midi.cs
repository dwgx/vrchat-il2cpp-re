// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDKBase.Midi
// Classes: 5
// Methods: 17

namespace VRC.SDKBase.Midi
{
    public class IVRCMidiInput
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0xCD60
        public void add_OnMidiVoiceMessage(){} // RVA: 0x24B10
        public void remove_OnMidiVoiceMessage(){} // RVA: 0x24B10
        public void OpenDevice(){} // RVA: 0xDE40
        public void Close(){} // RVA: 0x24A50
        public void Update(){} // RVA: 0x24A50
        public void GetDeviceNames(){} // RVA: 0xCD60
    }

    public class MidiRawEventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1D765C0
    }

    public class MidiRawMessageDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9AC0140
        public void Invoke(){} // RVA: 0x9AC02C0
        public void BeginInvoke(){} // RVA: 0x9AC02F0
        public void EndInvoke(){} // RVA: 0x2DECB0
    }

    public class MidiVoiceEventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9AC0120
    }

    public class MidiVoiceMessageDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3307BE0
        public void Invoke(){} // RVA: 0x3307D60
        public void BeginInvoke(){} // RVA: 0x9AC0380
        public void EndInvoke(){} // RVA: 0x2DECB0
    }

}