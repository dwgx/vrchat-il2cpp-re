// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 2
// Methods: 8

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class KeyValuePairFormatter`2 : BaseFormatter`1
    {
        public object KeySerializer;
        public object ValueSerializer;

        // ── Methods ──
        public void SerializeImplementation(){} // RVA: 0x8943B0
        public void DeserializeImplementation(){} // RVA: 0x8943B0
        public void .ctor(){} // RVA: 0x894290
        public void .cctor(){} // RVA: 0x8942F0
    }

    public class KeyframeFormatter : MinimalBaseFormatter`1
    {
        public object FloatSerializer;
        public object IntSerializer;
        public object Is_In_2018_1_Or_Above;
        public object Formatter;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x84CAB20
        public void Read(){} // RVA: 0x84CAF00
        public void Write(){} // RVA: 0x84CB360
        public void .ctor(){} // RVA: 0x84CB600
    }

}