// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Midi
// Classes: 1
// Methods: 5

namespace ThirdParty.Other.Midi
{
    public class ParsedMidiFile : Object
    {
        public int Format; // 0x10
        public int TicksPerQuarterNote; // 0x14
        public MidiRawTrack[] Tracks; // 0x18
        public int TracksCount; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBFF1050 | overloaded x3
        public void ParseMetaEvent(){} // RVA: 0x7FFACBFF13E0
        public void ParseTrack(){} // RVA: 0x7FFACBFF1600
    }

}