// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Midi
// Classes: 4
// Methods: 44

namespace VRC.SDK3.Midi
{
    public class MidiFile : ScriptableObject
    {
        public object audioClip; // 0x331E1D80
        public object .ctor; // 0xB3F6FFF0

        // ── Original Methods ──
        public void Create(){} // RVA: 0x7ffab1a150b0
        public void PrintRawData(){} // RVA: 0x7ffab1a15480
        public void PrintProcessedData(){} // RVA: 0x7ffab1a15960
        public void .ctor(){} // RVA: 0x7ffaa8b59ae0
    }

    public class VRCMidiHandler : MonoBehaviour
    {
        public object STATUS_CONTROL_CHANGE; // 0x3194A530
        public object OnNoteOff; // 0x3194A530
        public object _initialize; // 0x3194A530, was: <Initialize>k__BackingField
        public object OnNoteOff; // 0x3196D9D8

        // ── Original Methods ──
        public void get_MidiIn(){} // RVA: 0x7ffab1a19860
        public void add_OnNoteOn(){} // RVA: 0x7ffab1a19a10
        public void remove_OnNoteOn(){} // RVA: 0x7ffab1a19b00
        public void add_OnNoteOff(){} // RVA: 0x7ffab1a19bf0
        public void remove_OnNoteOff(){} // RVA: 0x7ffab1a19ce0
        public void add_OnControlChange(){} // RVA: 0x7ffab1a19dd0
        public void remove_OnControlChange(){} // RVA: 0x7ffab1a19ec0
        public void get_Initialize(){} // RVA: 0x7ffab1a19fb0
        public void set_Initialize(){} // RVA: 0x7ffab1a19ff0
        public void get_OnLog(){} // RVA: 0x7ffab1a1a090
        public void set_OnLog(){} // RVA: 0x7ffab1a1a0d0
        public void get_Instance(){} // RVA: 0x7ffab1a1a170
        public void set_Instance(){} // RVA: 0x7ffab1a1a480
        public void OpenMidiInput(){} // RVA: 0x7ffaa86492c0
        public void SendMidiMessage(){} // RVA: 0x7ffaa98d9630
        public void Update(){} // RVA: 0x7ffab1a1a520
        public void OnDestroy(){} // RVA: 0x7ffab1a1a700
        public void Log(){} // RVA: 0x7ffab1a1a8c0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class VRCMidiListener : MonoBehaviour
    {
        public object behaviour; // 0x331E81B0

        // ── Original Methods ──
        public void OnEnable(){} // RVA: 0x7ffab1a1a920
        public void NoteOn(){} // RVA: 0x7ffab1a1ad20
        public void NoteOff(){} // RVA: 0x7ffab1a1b0c0
        public void ControlChange(){} // RVA: 0x7ffab1a1b460
        public void OnDisable(){} // RVA: 0x7ffab1a1b800
        public void .ctor(){} // RVA: 0x7ffab1a1bbb0
    }

    public class VRCMidiPlayer : MonoBehaviour
    {
        public object targetBehaviours; // 0x331E8030
        public object _coroutine; // 0x331E8030

        // ── Original Methods ──
        public void get_MidiData(){} // RVA: 0x7ffab1a15dd0
        public void get_Time(){} // RVA: 0x7ffab1a15de0
        public void set_Time(){} // RVA: 0x7ffab1a15e40
        public void get_Coroutine(){} // RVA: 0x7ffaa89ad730
        public void get_OnBlockStarted(){} // RVA: 0x7ffab1a15eb0
        public void get_OnBlockCompleted(){} // RVA: 0x7ffab1a15ff0
        public void get_OnPlayingStarted(){} // RVA: 0x7ffab1a16130
        public void get_OnPlayingStopped(){} // RVA: 0x7ffab1a16270
        public void Awake(){} // RVA: 0x7ffab1a163b0
        public void Play(){} // RVA: 0x7ffab1a16550
        public void Stop(){} // RVA: 0x7ffab1a168b0
        public void MidiEnumerator(){} // RVA: 0x7ffab1a16b90
        public void OnBlockStart(){} // RVA: 0x7ffab1a16c90
        public void OnBlockEnd(){} // RVA: 0x7ffab1a17050
        public void .ctor(){} // RVA: 0x7ffab1a174c0
    }

}