// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDKBase.Midi
// Classes: 5
// Methods: 17

namespace VRC.SDKBase.Midi
{
    public class IVRCMidiInput
    {
        public object Name;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAC2C58E90
        public void add_OnMidiVoiceMessage(){} // RVA: 0x7FFAC2C70A40
        public void remove_OnMidiVoiceMessage(){} // RVA: 0x7FFAC2C70A40
        public void OpenDevice(){} // RVA: 0x7FFAC2C59F60
        public void Close(){} // RVA: 0x7FFAC2C70980
        public void Update(){} // RVA: 0x7FFAC2C70980
        public void GetDeviceNames(){} // RVA: 0x7FFAC2C58E90
    }

    public class MidiRawEventArgs : ValueType
    {
        public byte status; // 0x10
        public byte data1; // 0x11
        public byte data2; // 0x12

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC495DE30
    }

    public class MidiRawMessageDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACC09BFE0
        public void Invoke(){} // RVA: 0x7FFACC09C160
        public void BeginInvoke(){} // RVA: 0x7FFACC09C190
        public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
    }

    public class MidiVoiceEventArgs : ValueType
    {
        public int command; // 0x10
        public int channel; // 0x14
        public int number; // 0x18
        public int value; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACC09BFC0
    }

    public class MidiVoiceMessageDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC5C4DA60
        public void Invoke(){} // RVA: 0x7FFAC5C4DBE0
        public void BeginInvoke(){} // RVA: 0x7FFACC09C220
        public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
    }

}