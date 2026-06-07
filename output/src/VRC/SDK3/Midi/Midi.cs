// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Midi
// Classes: 9
// Methods: 51

namespace VRC.SDK3.Midi
{
    public class MidiData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class MidiFile
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x9A031B0
        public void PrintRawData(){} // RVA: 0x9A03580
        public void PrintProcessedData(){} // RVA: 0x9A03A60
        public void .ctor(){} // RVA: 0x53BFB0
    }

    public class MidiImportSettings
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9A03EC0
    }

    public class MidiRawData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class MidiRawDataProcessor
    {
        // ── Methods ──
        public void get_Bpm(){} // RVA: 0x6E8A80
        public void set_Bpm(){} // RVA: 0x6E8B80
        public void .ctor(){} // RVA: 0x9A06B70
    }

    public class MidiUtilities
    {
        // ── Methods ──
        public void MidiTimeToMs(){} // RVA: 0x9A07930
    }

    public class VRCMidiHandler
    {
        // ── Methods ──
        public void get_MidiIn(){} // RVA: 0x9A07960
        public void add_OnNoteOn(){} // RVA: 0x9A07B10
        public void remove_OnNoteOn(){} // RVA: 0x9A07C00
        public void add_OnNoteOff(){} // RVA: 0x9A07CF0
        public void remove_OnNoteOff(){} // RVA: 0x9A07DE0
        public void add_OnControlChange(){} // RVA: 0x9A07ED0
        public void remove_OnControlChange(){} // RVA: 0x9A07FC0
        public void get_Initialize(){} // RVA: 0x9A080B0
        public void set_Initialize(){} // RVA: 0x9A080F0
        public void get_OnLog(){} // RVA: 0x9A08190
        public void set_OnLog(){} // RVA: 0x9A081D0
        public void get_Instance(){} // RVA: 0x9A08270
        public void set_Instance(){} // RVA: 0x9A08580
        public void OpenMidiInput(){} // RVA: 0xCE50
        public void SendMidiMessage(){} // RVA: 0x13FE5C0
        public void Update(){} // RVA: 0x9A08620
        public void OnDestroy(){} // RVA: 0x9A08800
        public void Log(){} // RVA: 0x9A089C0
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class VRCMidiListener
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x9A08A20
        public void NoteOn(){} // RVA: 0x9A08E20
        public void NoteOff(){} // RVA: 0x9A091C0
        public void ControlChange(){} // RVA: 0x9A09560
        public void OnDisable(){} // RVA: 0x9A09900
        public void .ctor(){} // RVA: 0x9A09CB0
    }

    public class VRCMidiPlayer
    {
        // ── Methods ──
        public void get_MidiData(){} // RVA: 0x9A03ED0
        public void get_Time(){} // RVA: 0x9A03EE0
        public void set_Time(){} // RVA: 0x9A03F40
        public void get_Coroutine(){} // RVA: 0x358730
        public void get_OnBlockStarted(){} // RVA: 0x9A03FB0
        public void get_OnBlockCompleted(){} // RVA: 0x9A040F0
        public void get_OnPlayingStarted(){} // RVA: 0x9A04230
        public void get_OnPlayingStopped(){} // RVA: 0x9A04370
        public void Awake(){} // RVA: 0x9A044B0
        public void Play(){} // RVA: 0x9A04650
        public void Stop(){} // RVA: 0x9A049B0
        public void MidiEnumerator(){} // RVA: 0x9A04C90
        public void OnBlockStart(){} // RVA: 0x9A04D90
        public void OnBlockEnd(){} // RVA: 0x9A05150
        public void .ctor(){} // RVA: 0x9A055C0
    }

}