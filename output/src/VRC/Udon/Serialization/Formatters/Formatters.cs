// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.Formatters
// Classes: 2
// Methods: 10

namespace VRC.Udon.Serialization.Formatters
{
    public class UdonGameObjectComponentReferenceFormatter : BaseFormatter`1
    {
        public object _typeSerializer;

        // ── Methods ──
        public void GetUninitializedObject(){} // RVA: 0xDAC980
        public void DeserializeImplementation(){} // RVA: 0x8354260
        public void SerializeImplementation(){} // RVA: 0x8354440
        public void .ctor(){} // RVA: 0x83544F0
        public void .cctor(){} // RVA: 0x8354550
    }

    public class UdonProgramFormatter : BaseFormatter`1
    {
        public object _byteArrayReaderWriter;
        public object _udonHeapReaderWriter;
        public object _udonSymbolTableReaderWriter;
        public object _udonSyncMetadataTableReaderWriter;

        // ── Methods ──
        public void GetUninitializedObject(){} // RVA: 0xDAC980
        public void DeserializeImplementation(){} // RVA: 0x8354630
        public void SerializeImplementation(){} // RVA: 0x8354AD0
        public void .ctor(){} // RVA: 0x8354DE0
        public void .cctor(){} // RVA: 0x8354E40
    }

}