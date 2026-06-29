// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Midi
// Classes: 9
// Methods: 51

namespace VRC.SDK3.Midi
{
    public class MidiData : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class MidiFile : ScriptableObject
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7B1841DE0
        public void PrintRawData(){} // RVA: 0x7B18421C0
        public void PrintProcessedData(){} // RVA: 0x7B18426A0
        public void .ctor(){} // RVA: 0x7A82F4A40
    }

    public class MidiImportSettings : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1842B20
    }

    public class MidiRawData : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class MidiRawDataProcessor : Object
    {
        // ── Methods ──
        public void get_Bpm(){} // RVA: 0x7A84A5BD0
        public void set_Bpm(){} // RVA: 0x7A84A5CD0
        public void .ctor(){} // RVA: 0x7B18457E0
    }

    public class MidiUtilities : Object
    {
        // ── Methods ──
        public void MidiTimeToMs(){} // RVA: 0x7B18464D0
    }

    public class VRCMidiHandler : MonoBehaviour
    {
        // ── Methods ──
        public void get_MidiIn(){} // RVA: 0x7B1846500
        public void add_OnNoteOn(){} // RVA: 0x7B18466B0
        public void remove_OnNoteOn(){} // RVA: 0x7B18467A0
        public void add_OnNoteOff(){} // RVA: 0x7B1846890
        public void remove_OnNoteOff(){} // RVA: 0x7B1846980
        public void add_OnControlChange(){} // RVA: 0x7B1846A70
        public void remove_OnControlChange(){} // RVA: 0x7B1846B60
        public void get_Initialize(){} // RVA: 0x7B1846C50
        public void set_Initialize(){} // RVA: 0x7B1846C90
        public void get_OnLog(){} // RVA: 0x7B1846D30
        public void set_OnLog(){} // RVA: 0x7B1846D70
        public void get_Instance(){} // RVA: 0x7B1846E10
        public void set_Instance(){} // RVA: 0x7B1847120
        public void OpenMidiInput(){} // RVA: 0x7A7E00BA0
        public void SendMidiMessage(){} // RVA: 0x7A91B6130
        public void Update(){} // RVA: 0x7B18471C0
        public void OnDestroy(){} // RVA: 0x7B18473A0
        public void Log(){} // RVA: 0x7B1847560
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

    public class VRCMidiListener : MonoBehaviour
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7B18475C0
        public void NoteOn(){} // RVA: 0x7B18479C0
        public void NoteOff(){} // RVA: 0x7B1847D60
        public void ControlChange(){} // RVA: 0x7B1848100
        public void OnDisable(){} // RVA: 0x7B18484A0
        public void .ctor(){} // RVA: 0x7B1848850
    }

    public class VRCMidiPlayer : MonoBehaviour
    {
        // ── Methods ──
        public void get_MidiData(){} // RVA: 0x7B1842B30
        public void get_Time(){} // RVA: 0x7B1842B40
        public void set_Time(){} // RVA: 0x7B1842BA0
        public void get_Coroutine(){} // RVA: 0x7A8152D80
        public void get_OnBlockStarted(){} // RVA: 0x7B1842C10
        public void get_OnBlockCompleted(){} // RVA: 0x7B1842D50
        public void get_OnPlayingStarted(){} // RVA: 0x7B1842E90
        public void get_OnPlayingStopped(){} // RVA: 0x7B1842FD0
        public void Awake(){} // RVA: 0x7B1843110
        public void Play(){} // RVA: 0x7B18432B0
        public void Stop(){} // RVA: 0x7B1843610
        public void MidiEnumerator(){} // RVA: 0x7B18438F0
        public void OnBlockStart(){} // RVA: 0x7B18439F0
        public void OnBlockEnd(){} // RVA: 0x7B1843DB0
        public void .ctor(){} // RVA: 0x7B1844230
    }

}