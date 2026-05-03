// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDKBase.Midi
// Classes: 5
// Methods: 17

namespace VRC.SDKBase.Midi
{
    public class IVRCMidiInput
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFE80E2E2E0
        public void add_OnMidiVoiceMessage(){} // RVA: 0x7FFE80E460A0
        public void remove_OnMidiVoiceMessage(){} // RVA: 0x7FFE80E460A0
        public void OpenDevice(){} // RVA: 0x7FFE80E2F3B0
        public void Close(){} // RVA: 0x7FFE80E45FE0
        public void Update(){} // RVA: 0x7FFE80E45FE0
        public void GetDeviceNames(){} // RVA: 0x7FFE80E2E2E0
    }

    public class MidiRawEventArgs : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82BC9960
    }

    public class MidiRawMessageDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A501FB0
        public void Invoke(){} // RVA: 0x7FFE8A502130
        public void BeginInvoke(){} // RVA: 0x7FFE8A502160
        public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
    }

    public class MidiVoiceEventArgs : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A501F90
    }

    public class MidiVoiceMessageDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE83F85160
        public void Invoke(){} // RVA: 0x7FFE83F852E0
        public void BeginInvoke(){} // RVA: 0x7FFE8A5021F0
        public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
    }

}