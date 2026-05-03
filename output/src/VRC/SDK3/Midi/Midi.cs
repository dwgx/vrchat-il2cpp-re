// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Midi
// Classes: 9
// Methods: 51

namespace VRC.SDK3.Midi
{
    public class MidiData : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class MidiFile : ScriptableObject
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE8A45EBE0
        public void PrintRawData(){} // RVA: 0x7FFE8A45EFB0
        public void PrintProcessedData(){} // RVA: 0x7FFE8A45F490
        public void .ctor(){} // RVA: 0x7FFE81345B60
    }

    public class MidiImportSettings : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A45F8F0
    }

    public class MidiRawData : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class MidiRawDataProcessor : Object
    {
        public System.Collections.Generic.List`1<MidiBlock> allBlocks; // 0x10

        // ── Methods ──
        public void get_Bpm(){} // RVA: 0x7FFE815F1380
        public void set_Bpm(){} // RVA: 0x7FFE81C15740
        public void .ctor(){} // RVA: 0x7FFE8A4625A0
    }

    public class MidiUtilities : Object
    {
        // ── Methods ──
        public void MidiTimeToMs(){} // RVA: 0x7FFE8A463360
    }

    public class VRCMidiHandler : MonoBehaviour
    {
        public int STATUS_NOTE_OFF;
        public int STATUS_NOTE_ON;
        public int STATUS_CONTROL_CHANGE;
        public VRC.SDKBase.Midi.IVRCMidiInput _midiIn; // 0x20

        // ── Methods ──
        public void get_MidiIn(){} // RVA: 0x7FFE8A463390
        public void add_OnNoteOn(){} // RVA: 0x7FFE8A463540
        public void remove_OnNoteOn(){} // RVA: 0x7FFE8A463630
        public void add_OnNoteOff(){} // RVA: 0x7FFE8A463720
        public void remove_OnNoteOff(){} // RVA: 0x7FFE8A463810
        public void add_OnControlChange(){} // RVA: 0x7FFE8A463900
        public void remove_OnControlChange(){} // RVA: 0x7FFE8A4639F0
        public void get_Initialize(){} // RVA: 0x7FFE8A463AE0
        public void set_Initialize(){} // RVA: 0x7FFE8A463B20
        public void get_OnLog(){} // RVA: 0x7FFE8A463BC0
        public void set_OnLog(){} // RVA: 0x7FFE8A463C00
        public void get_Instance(){} // RVA: 0x7FFE8A463CA0
        public void set_Instance(){} // RVA: 0x7FFE8A463FB0
        public void OpenMidiInput(){} // RVA: 0x7FFE80E2E3D0
        public void SendMidiMessage(){} // RVA: 0x7FFE8216A280
        public void Update(){} // RVA: 0x7FFE8A464050
        public void OnDestroy(){} // RVA: 0x7FFE8A464230
        public void Log(){} // RVA: 0x7FFE8A4643F0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class VRCMidiListener : MonoBehaviour
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFE8A464450
        public void NoteOn(){} // RVA: 0x7FFE8A464850
        public void NoteOff(){} // RVA: 0x7FFE8A464BF0
        public void ControlChange(){} // RVA: 0x7FFE8A464F90
        public void OnDisable(){} // RVA: 0x7FFE8A465330
        public void .ctor(){} // RVA: 0x7FFE8A4656E0
    }

    public class VRCMidiPlayer : MonoBehaviour
    {
        public VRC.SDK3.Midi.MidiFile midiFile; // 0x20
        public UnityEngine.AudioSource audioSource; // 0x28
        public VRC.SDK3.Components.AbstractUdonBehaviour[] targetBehaviours; // 0x30
        public System.Collections.Generic.List`1<TrackProgress> activeTracks; // 0x38
        public float lastAudioSampleTime; // 0x40
        public UnityEngine.Coroutine _coroutine; // 0x48
        public System.ValueTuple`2<string,object>[] argsArray; // 0x50

        // ── Methods ──
        public void get_MidiData(){} // RVA: 0x7FFE8A45F900
        public void get_Time(){} // RVA: 0x7FFE8A45F910
        public void set_Time(){} // RVA: 0x7FFE8A45F970
        public void get_Coroutine(){} // RVA: 0x7FFE81176730
        public void get_OnBlockStarted(){} // RVA: 0x7FFE8A45F9E0
        public void get_OnBlockCompleted(){} // RVA: 0x7FFE8A45FB20
        public void get_OnPlayingStarted(){} // RVA: 0x7FFE8A45FC60
        public void get_OnPlayingStopped(){} // RVA: 0x7FFE8A45FDA0
        public void Awake(){} // RVA: 0x7FFE8A45FEE0
        public void Play(){} // RVA: 0x7FFE8A460080
        public void Stop(){} // RVA: 0x7FFE8A4603E0
        public void MidiEnumerator(){} // RVA: 0x7FFE8A4606C0
        public void OnBlockStart(){} // RVA: 0x7FFE8A4607C0
        public void OnBlockEnd(){} // RVA: 0x7FFE8A460B80
        public void .ctor(){} // RVA: 0x7FFE8A460FF0
    }

}