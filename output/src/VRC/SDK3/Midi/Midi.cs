// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Midi
// Classes: 9
// Methods: 51

namespace VRC.SDK3.Midi
{
    public class MidiData : Object
    {
        public MidiTrack[] tracks; // 0x10
        public byte bpm; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class MidiFile : ScriptableObject
    {
        public VRC.SDK3.Midi.MidiRawData rawData; // 0x18
        public VRC.SDK3.Midi.MidiData data; // 0x20
        public UnityEngine.AudioClip audioClip; // 0x28

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFACBFF93E0
        public void PrintRawData(){} // RVA: 0x7FFACBFF97B0
        public void PrintProcessedData(){} // RVA: 0x7FFACBFF9C90
        public void .ctor(){} // RVA: 0x7FFAC312F5F0
    }

    public class MidiImportSettings : Object
    {
        public UnityEngine.AudioClip AudioClip; // 0x10
        public bool OverrideBpm; // 0x18
        public byte Bpm; // 0x19

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBFFA0F0
    }

    public class MidiRawData : Object
    {
        public int Format; // 0x10
        public int TicksPerQuarterNote; // 0x14
        public MidiRawTrack[] Tracks; // 0x18
        public int TracksCount; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class MidiRawDataProcessor : Object
    {
        public System.Collections.Generic.List`1<MidiBlock> Bpm; // 0x10
        public System.Collections.Generic.List`1<MidiTrack> tracks; // 0x18
        public System.Collections.Generic.List`1<System.Collections.Generic.Dictionary`2<byte,NoteOnEvent>> _noteTimeMap; // 0x20
        public byte <Bpm>k__BackingField; // 0x28

        // ── Methods ──
        public void get_Bpm(){} // RVA: 0x7FFAC30F6BA0
        public void set_Bpm(){} // RVA: 0x7FFAC3C24F40
        public void .ctor(){} // RVA: 0x7FFACBFFCDA0
    }

    public class MidiUtilities : Object
    {
        // ── Methods ──
        public void MidiTimeToMs(){} // RVA: 0x7FFACBFFDB60
    }

    public class VRCMidiHandler : MonoBehaviour
    {
        public int MidiIn;
        public int Initialize;
        public int OnLog;
        public VRC.SDKBase.Midi.IVRCMidiInput Instance; // 0x20
        public VRC.SDKBase.Midi.MidiVoiceMessageDelegate OnNoteOn; // 0x28
        public VRC.SDKBase.Midi.MidiVoiceMessageDelegate OnNoteOff; // 0x30
        public VRC.SDKBase.Midi.MidiVoiceMessageDelegate OnControlChange; // 0x38
        public VRC.SDK3.Midi.VRCMidiHandler _instance;
        public System.Func`1<VRC.SDKBase.Midi.IVRCMidiInput> <Initialize>k__BackingField; // 0x8
        public System.Action`1<string> <OnLog>k__BackingField; // 0x10

        // ── Methods ──
        public void get_MidiIn(){} // RVA: 0x7FFACBFFDB90
        public void add_OnNoteOn(){} // RVA: 0x7FFACBFFDD40
        public void remove_OnNoteOn(){} // RVA: 0x7FFACBFFDE30
        public void add_OnNoteOff(){} // RVA: 0x7FFACBFFDF20
        public void remove_OnNoteOff(){} // RVA: 0x7FFACBFFE010
        public void add_OnControlChange(){} // RVA: 0x7FFACBFFE100
        public void remove_OnControlChange(){} // RVA: 0x7FFACBFFE1F0
        public void get_Initialize(){} // RVA: 0x7FFACBFFE2E0
        public void set_Initialize(){} // RVA: 0x7FFACBFFE320
        public void get_OnLog(){} // RVA: 0x7FFACBFFE3C0
        public void set_OnLog(){} // RVA: 0x7FFACBFFE400
        public void get_Instance(){} // RVA: 0x7FFACBFFE4A0
        public void set_Instance(){} // RVA: 0x7FFACBFFE7B0
        public void OpenMidiInput(){} // RVA: 0x7FFAC2C58F80
        public void SendMidiMessage(){} // RVA: 0x7FFAC3EAAD20
        public void Update(){} // RVA: 0x7FFACBFFE850
        public void OnDestroy(){} // RVA: 0x7FFACBFFEA30
        public void Log(){} // RVA: 0x7FFACBFFEBF0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class VRCMidiListener : MonoBehaviour
    {
        public VRC.SDK3.Midi.VRCMidiHandler _plugin; // 0x20
        public System.ValueTuple`2<string,object>[] argsArray; // 0x28
        public VRC.SDK3.Components.AbstractUdonBehaviour behaviour; // 0x30
        public 0x6B261FF8 activeEvents; // 0x38

        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFACBFFEC50
        public void NoteOn(){} // RVA: 0x7FFACBFFF050
        public void NoteOff(){} // RVA: 0x7FFACBFFF3F0
        public void ControlChange(){} // RVA: 0x7FFACBFFF790
        public void OnDisable(){} // RVA: 0x7FFACBFFFB30
        public void .ctor(){} // RVA: 0x7FFACBFFFEE0
    }

    public class VRCMidiPlayer : MonoBehaviour
    {
        public VRC.SDK3.Midi.MidiFile MidiData; // 0x20
        public UnityEngine.AudioSource Time; // 0x28
        public VRC.SDK3.Components.AbstractUdonBehaviour[] Coroutine; // 0x30
        public System.Collections.Generic.List`1<TrackProgress> OnBlockStarted; // 0x38
        public float OnBlockCompleted; // 0x40
        public UnityEngine.Coroutine OnPlayingStarted; // 0x48
        public System.ValueTuple`2<string,object>[] OnPlayingStopped; // 0x50

        // ── Methods ──
        public void get_MidiData(){} // RVA: 0x7FFACBFFA100
        public void get_Time(){} // RVA: 0x7FFACBFFA110
        public void set_Time(){} // RVA: 0x7FFACBFFA170
        public void get_Coroutine(){} // RVA: 0x7FFAC2F9C730
        public void get_OnBlockStarted(){} // RVA: 0x7FFACBFFA1E0
        public void get_OnBlockCompleted(){} // RVA: 0x7FFACBFFA320
        public void get_OnPlayingStarted(){} // RVA: 0x7FFACBFFA460
        public void get_OnPlayingStopped(){} // RVA: 0x7FFACBFFA5A0
        public void Awake(){} // RVA: 0x7FFACBFFA6E0
        public void Play(){} // RVA: 0x7FFACBFFA880
        public void Stop(){} // RVA: 0x7FFACBFFABE0
        public void MidiEnumerator(){} // RVA: 0x7FFACBFFAEC0
        public void OnBlockStart(){} // RVA: 0x7FFACBFFAFC0
        public void OnBlockEnd(){} // RVA: 0x7FFACBFFB380
        public void .ctor(){} // RVA: 0x7FFACBFFB7F0
    }

}