// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDKBase.Midi
// Classes: 5
// Methods: 17

namespace VRC.SDKBase.Midi
{
    public class IVRCMidiInput
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAF2ABCD60
        public void add_OnMidiVoiceMessage(){} // RVA: 0x7FFAF2AD4B10
        public void remove_OnMidiVoiceMessage(){} // RVA: 0x7FFAF2AD4B10
        public void OpenDevice(){} // RVA: 0x7FFAF2ABDE40
        public void Close(){} // RVA: 0x7FFAF2AD4A50
        public void Update(){} // RVA: 0x7FFAF2AD4A50
        public void GetDeviceNames(){} // RVA: 0x7FFAF2ABCD60
    }

    public class MidiRawEventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF48265C0
    }

    public class MidiRawMessageDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC570140
        public void Invoke(){} // RVA: 0x7FFAFC5702C0
        public void BeginInvoke(){} // RVA: 0x7FFAFC5702F0
        public void EndInvoke(){} // RVA: 0x7FFAF2D8ECB0
    }

    public class MidiVoiceEventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC570120
    }

    public class MidiVoiceMessageDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF5DB7BE0
        public void Invoke(){} // RVA: 0x7FFAF5DB7D60
        public void BeginInvoke(){} // RVA: 0x7FFAFC570380
        public void EndInvoke(){} // RVA: 0x7FFAF2D8ECB0
    }

}