// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 2
// Methods: 8

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class KeyValuePairFormatter`2 : BaseFormatter`1
    {
        public tSupportedException_ConstructorMaxOf64Parameters<T1717696976> KeySerializer;
        public tSupportedException_ConstructorMaxOf64Parameters<T1717696992> ValueSerializer;

        // ── Methods ──
        public void SerializeImplementation(){} // RVA: 0x7FFD4E099B30
        public void DeserializeImplementation(){} // RVA: 0x7FFD4E099B30
        public void .ctor(){} // RVA: 0x7FFD4E090980
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

    public class KeyframeFormatter : MinimalBaseFormatter`1
    {
        public tSupportedException_ConstructorMaxOf64Parameters<float> FloatSerializer;
        public tSupportedException_ConstructorMaxOf64Parameters<int> IntSerializer; // 0x8
        public bool Is_In_2018_1_Or_Above; // 0x10
        public m_ItalicAngleStack<ÏÌÍÌÍÎÍÌÏÍÍÌÌÎÍÍ> Formatter; // 0x18

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD55439A90
        public void Read(){} // RVA: 0x7FFD55439EA0
        public void Write(){} // RVA: 0x7FFD5543A300
        public void .ctor(){} // RVA: 0x7FFD5543A590
    }

}