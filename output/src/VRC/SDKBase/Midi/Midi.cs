// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDKBase.Midi
// Classes: 5
// Methods: 17

namespace VRC.SDKBase.Midi
{
    public class IVRCMidiInput
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7A7E00680
        public void add_OnMidiVoiceMessage(){} // RVA: 0x7A7E18800
        public void remove_OnMidiVoiceMessage(){} // RVA: 0x7A7E18800
        public void OpenDevice(){} // RVA: 0x7A7E019D0
        public void Close(){} // RVA: 0x7A7E18770
        public void Update(){} // RVA: 0x7A7E18770
        public void GetDeviceNames(){} // RVA: 0x7A7E00680
    }

    public class MidiRawEventArgs : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A76773F0
    }

    public class MidiRawMessageDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1901630
        public void Invoke(){} // RVA: 0x7B19017A0
        public void BeginInvoke(){} // RVA: 0x7B19017D0
        public void EndInvoke(){} // RVA: 0x7A80D8CA0
    }

    public class MidiVoiceEventArgs : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7FCA7B0
    }

    public class MidiVoiceMessageDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AB0FF910
        public void Invoke(){} // RVA: 0x7AB0FFA80
        public void BeginInvoke(){} // RVA: 0x7B1901860
        public void EndInvoke(){} // RVA: 0x7A80D8CA0
    }

}