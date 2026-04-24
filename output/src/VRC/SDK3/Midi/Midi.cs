// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Midi
// Classes: 4
// Methods: 44

namespace VRC.SDK3.Midi
{
    public class MidiFile : ScriptableObject
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFD574193E0
        public void PrintRawData(){} // RVA: 0x7FFD574197B0
        public void PrintProcessedData(){} // RVA: 0x7FFD57419C90
        public void .ctor(){} // RVA: 0x7FFD4E54F5F0
    }

    public class VRCMidiHandler : MonoBehaviour
    {
        public object MidiIn;
        public object Initialize;
        public object OnLog;
        public object Instance;

        // ── Methods ──
        public void get_MidiIn(){} // RVA: 0x7FFD5741DB90
        public void add_OnNoteOn(){} // RVA: 0x7FFD5741DD40
        public void remove_OnNoteOn(){} // RVA: 0x7FFD5741DE30
        public void add_OnNoteOff(){} // RVA: 0x7FFD5741DF20
        public void remove_OnNoteOff(){} // RVA: 0x7FFD5741E010
        public void add_OnControlChange(){} // RVA: 0x7FFD5741E100
        public void remove_OnControlChange(){} // RVA: 0x7FFD5741E1F0
        public void get_Initialize(){} // RVA: 0x7FFD5741E2E0
        public void set_Initialize(){} // RVA: 0x7FFD5741E320
        public void get_OnLog(){} // RVA: 0x7FFD5741E3C0
        public void set_OnLog(){} // RVA: 0x7FFD5741E400
        public void get_Instance(){} // RVA: 0x7FFD5741E4A0
        public void set_Instance(){} // RVA: 0x7FFD5741E7B0
        public void OpenMidiInput(){} // RVA: 0x7FFD4E078F80
        public void SendMidiMessage(){} // RVA: 0x7FFD4F2CAD20
        public void Update(){} // RVA: 0x7FFD5741E850
        public void OnDestroy(){} // RVA: 0x7FFD5741EA30
        public void Log(){} // RVA: 0x7FFD5741EBF0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class VRCMidiListener : MonoBehaviour
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFD5741EC50
        public void NoteOn(){} // RVA: 0x7FFD5741F050
        public void NoteOff(){} // RVA: 0x7FFD5741F3F0
        public void ControlChange(){} // RVA: 0x7FFD5741F790
        public void OnDisable(){} // RVA: 0x7FFD5741FB30
        public void .ctor(){} // RVA: 0x7FFD5741FEE0
    }

    public class VRCMidiPlayer : MonoBehaviour
    {
        public object MidiData;
        public object Time;
        public object Coroutine;
        public object OnBlockStarted;
        public object OnBlockCompleted;
        public object OnPlayingStarted;
        public object OnPlayingStopped;

        // ── Methods ──
        public void get_MidiData(){} // RVA: 0x7FFD5741A100
        public void get_Time(){} // RVA: 0x7FFD5741A110
        public void set_Time(){} // RVA: 0x7FFD5741A170
        public void get_Coroutine(){} // RVA: 0x7FFD4E3BC730
        public void get_OnBlockStarted(){} // RVA: 0x7FFD5741A1E0
        public void get_OnBlockCompleted(){} // RVA: 0x7FFD5741A320
        public void get_OnPlayingStarted(){} // RVA: 0x7FFD5741A460
        public void get_OnPlayingStopped(){} // RVA: 0x7FFD5741A5A0
        public void Awake(){} // RVA: 0x7FFD5741A6E0
        public void Play(){} // RVA: 0x7FFD5741A880
        public void Stop(){} // RVA: 0x7FFD5741ABE0
        public void MidiEnumerator(){} // RVA: 0x7FFD5741AEC0
        public void OnBlockStart(){} // RVA: 0x7FFD5741AFC0
        public void OnBlockEnd(){} // RVA: 0x7FFD5741B380
        public void .ctor(){} // RVA: 0x7FFD5741B7F0
    }

}