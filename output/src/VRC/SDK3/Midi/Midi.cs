// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Midi
// Classes: 9
// Methods: 51

namespace VRC.SDK3.Midi
{
    public class MidiData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class MidiFile
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAFC4B31B0
        public void PrintRawData(){} // RVA: 0x7FFAFC4B3580
        public void PrintProcessedData(){} // RVA: 0x7FFAFC4B3A60
        public void .ctor(){} // RVA: 0x7FFAF2FEBFB0
    }

    public class MidiImportSettings
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC4B3EC0
    }

    public class MidiRawData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class MidiRawDataProcessor
    {
        // ── Methods ──
        public void get_Bpm(){} // RVA: 0x7FFAF3198A80
        public void set_Bpm(){} // RVA: 0x7FFAF3198B80
        public void .ctor(){} // RVA: 0x7FFAFC4B6B70
    }

    public class MidiUtilities
    {
        // ── Methods ──
        public void MidiTimeToMs(){} // RVA: 0x7FFAFC4B7930
    }

    public class VRCMidiHandler
    {
        // ── Methods ──
        public void get_MidiIn(){} // RVA: 0x7FFAFC4B7960
        public void add_OnNoteOn(){} // RVA: 0x7FFAFC4B7B10
        public void remove_OnNoteOn(){} // RVA: 0x7FFAFC4B7C00
        public void add_OnNoteOff(){} // RVA: 0x7FFAFC4B7CF0
        public void remove_OnNoteOff(){} // RVA: 0x7FFAFC4B7DE0
        public void add_OnControlChange(){} // RVA: 0x7FFAFC4B7ED0
        public void remove_OnControlChange(){} // RVA: 0x7FFAFC4B7FC0
        public void get_Initialize(){} // RVA: 0x7FFAFC4B80B0
        public void set_Initialize(){} // RVA: 0x7FFAFC4B80F0
        public void get_OnLog(){} // RVA: 0x7FFAFC4B8190
        public void set_OnLog(){} // RVA: 0x7FFAFC4B81D0
        public void get_Instance(){} // RVA: 0x7FFAFC4B8270
        public void set_Instance(){} // RVA: 0x7FFAFC4B8580
        public void OpenMidiInput(){} // RVA: 0x7FFAF2ABCE50
        public void SendMidiMessage(){} // RVA: 0x7FFAF3EAE5C0
        public void Update(){} // RVA: 0x7FFAFC4B8620
        public void OnDestroy(){} // RVA: 0x7FFAFC4B8800
        public void Log(){} // RVA: 0x7FFAFC4B89C0
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class VRCMidiListener
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFAFC4B8A20
        public void NoteOn(){} // RVA: 0x7FFAFC4B8E20
        public void NoteOff(){} // RVA: 0x7FFAFC4B91C0
        public void ControlChange(){} // RVA: 0x7FFAFC4B9560
        public void OnDisable(){} // RVA: 0x7FFAFC4B9900
        public void .ctor(){} // RVA: 0x7FFAFC4B9CB0
    }

    public class VRCMidiPlayer
    {
        // ── Methods ──
        public void get_MidiData(){} // RVA: 0x7FFAFC4B3ED0
        public void get_Time(){} // RVA: 0x7FFAFC4B3EE0
        public void set_Time(){} // RVA: 0x7FFAFC4B3F40
        public void get_Coroutine(){} // RVA: 0x7FFAF2E08730
        public void get_OnBlockStarted(){} // RVA: 0x7FFAFC4B3FB0
        public void get_OnBlockCompleted(){} // RVA: 0x7FFAFC4B40F0
        public void get_OnPlayingStarted(){} // RVA: 0x7FFAFC4B4230
        public void get_OnPlayingStopped(){} // RVA: 0x7FFAFC4B4370
        public void Awake(){} // RVA: 0x7FFAFC4B44B0
        public void Play(){} // RVA: 0x7FFAFC4B4650
        public void Stop(){} // RVA: 0x7FFAFC4B49B0
        public void MidiEnumerator(){} // RVA: 0x7FFAFC4B4C90
        public void OnBlockStart(){} // RVA: 0x7FFAFC4B4D90
        public void OnBlockEnd(){} // RVA: 0x7FFAFC4B5150
        public void .ctor(){} // RVA: 0x7FFAFC4B55C0
    }

}