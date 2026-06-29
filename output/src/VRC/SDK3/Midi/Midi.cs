// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Midi
// Classes: 9
// Methods: 51

namespace VRC.SDK3.Midi
{
    public class MidiData : Object
    {
        public object tracks;
        public object bpm;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class MidiFile : ScriptableObject
    {
        public object rawData;
        public object data;
        public object audioClip;

        // ── Methods ──
        public void Create(){} // RVA: 0xA6AC9A0
        public void PrintRawData(){} // RVA: 0xA6ACD80
        public void PrintProcessedData(){} // RVA: 0xA6AD240
        public void .ctor(){} // RVA: 0xDD1AC0
    }

    public class MidiImportSettings : Object
    {
        public object AudioClip;
        public object OverrideBpm;
        public object Bpm;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA6AD6A0
    }

    public class MidiRawData : Object
    {
        public object Format;
        public object TicksPerQuarterNote;
        public object Tracks;
        public object TracksCount;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class MidiRawDataProcessor : Object
    {
        public object allBlocks;
        public object tracks;
        public object _noteTimeMap;
        public object _bpm;

        // ── Methods ──
        public void get_Bpm(){} // RVA: 0xF73960
        public void set_Bpm(){} // RVA: 0xF73A60
        public void .ctor(){} // RVA: 0xA6B0290
    }

    public class MidiUtilities : Object
    {
        // ── Methods ──
        public void MidiTimeToMs(){} // RVA: 0xA6B0F80
    }

    public class VRCMidiHandler : MonoBehaviour
    {
        public object STATUS_NOTE_OFF;
        public object STATUS_NOTE_ON;
        public object STATUS_CONTROL_CHANGE;
        public object _midiIn;
        public object OnNoteOn;
        public object OnNoteOff;
        public object OnControlChange;
        public object _instance;
        public object _initialize;
        public object _onLog;

        // ── Methods ──
        public void get_MidiIn(){} // RVA: 0xA6B0FB0
        public void add_OnNoteOn(){} // RVA: 0xA6B1160
        public void remove_OnNoteOn(){} // RVA: 0xA6B1250
        public void add_OnNoteOff(){} // RVA: 0xA6B1340
        public void remove_OnNoteOff(){} // RVA: 0xA6B1430
        public void add_OnControlChange(){} // RVA: 0xA6B1520
        public void remove_OnControlChange(){} // RVA: 0xA6B1610
        public void get_Initialize(){} // RVA: 0xA6B1700
        public void set_Initialize(){} // RVA: 0xA6B1740
        public void get_OnLog(){} // RVA: 0xA6B17E0
        public void set_OnLog(){} // RVA: 0xA6B1820
        public void get_Instance(){} // RVA: 0xA6B18C0
        public void set_Instance(){} // RVA: 0xA6B1BD0
        public void OpenMidiInput(){} // RVA: 0x87C5C0
        public void SendMidiMessage(){} // RVA: 0x1CCF4F0
        public void Update(){} // RVA: 0xA6B1C70
        public void OnDestroy(){} // RVA: 0xA6B1E50
        public void Log(){} // RVA: 0xA6B2010
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class VRCMidiListener : MonoBehaviour
    {
        public object _plugin;
        public object argsArray;
        public object behaviour;
        public object activeEvents;

        // ── Methods ──
        public void OnEnable(){} // RVA: 0xA6B2070
        public void NoteOn(){} // RVA: 0xA6B2470
        public void NoteOff(){} // RVA: 0xA6B2800
        public void ControlChange(){} // RVA: 0xA6B2B90
        public void OnDisable(){} // RVA: 0xA6B2F20
        public void .ctor(){} // RVA: 0xA6B32D0
    }

    public class VRCMidiPlayer : MonoBehaviour
    {
        public object midiFile;
        public object audioSource;
        public object targetBehaviours;
        public object activeTracks;
        public object lastAudioSampleTime;
        public object _coroutine;
        public object argsArray;

        // ── Methods ──
        public void get_MidiData(){} // RVA: 0xA6AD6B0
        public void get_Time(){} // RVA: 0xA6AD6C0
        public void set_Time(){} // RVA: 0xA6AD760
        public void get_Coroutine(){} // RVA: 0xBBF8F0
        public void get_OnBlockStarted(){} // RVA: 0xA6AD780
        public void get_OnBlockCompleted(){} // RVA: 0xA6AD8C0
        public void get_OnPlayingStarted(){} // RVA: 0xA6ADA00
        public void get_OnPlayingStopped(){} // RVA: 0xA6ADB40
        public void Awake(){} // RVA: 0xA6ADC80
        public void Play(){} // RVA: 0xA6ADDC0
        public void Stop(){} // RVA: 0xA6AE0E0
        public void MidiEnumerator(){} // RVA: 0xA6AE380
        public void OnBlockStart(){} // RVA: 0xA6AE480
        public void OnBlockEnd(){} // RVA: 0xA6AE830
        public void .ctor(){} // RVA: 0xA6AECA0
    }

}