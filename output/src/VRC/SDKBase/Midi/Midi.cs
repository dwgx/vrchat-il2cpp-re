// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDKBase.Midi
// Classes: 5
// Methods: 17

namespace VRC.SDKBase.Midi
{
    public class IVRCMidiInput
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x87C0A0
        public void add_OnMidiVoiceMessage(){} // RVA: 0x894320
        public void remove_OnMidiVoiceMessage(){} // RVA: 0x894320
        public void OpenDevice(){} // RVA: 0x87D350
        public void Close(){} // RVA: 0x894290
        public void Update(){} // RVA: 0x894290
        public void GetDeviceNames(){} // RVA: 0x87C0A0
    }

    public class MidiRawEventArgs : ValueType
    {
        public object status;
        public object data1;
        public object data2;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8C060
    }

    public class MidiRawMessageDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA76F870
        public void Invoke(){} // RVA: 0xA76F9E0
        public void BeginInvoke(){} // RVA: 0xA76FA10
        public void EndInvoke(){} // RVA: 0xB44BE0
    }

    public class MidiVoiceEventArgs : ValueType
    {
        public object command;
        public object channel;
        public object number;
        public object value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA79180
    }

    public class MidiVoiceMessageDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3DB99A0
        public void Invoke(){} // RVA: 0x3DB9B10
        public void BeginInvoke(){} // RVA: 0xA76FAA0
        public void EndInvoke(){} // RVA: 0xB44BE0
    }

}