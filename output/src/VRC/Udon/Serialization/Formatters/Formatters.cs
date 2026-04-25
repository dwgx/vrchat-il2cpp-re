// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.Formatters
// Classes: 2
// Methods: 10

namespace VRC.Udon.Serialization.Formatters
{
    public class UdonGameObjectComponentReferenceFormatter : BaseFormatter`1
    {
        public VRC.Udon.Serialization.OdinSerializer.Serializer`1<System.Type> _typeSerializer;

        // ── Methods ──
        public void GetUninitializedObject(){} // RVA: 0x7FFD4E919180
        public void DeserializeImplementation(){} // RVA: 0x7FFD552BFA40
        public void SerializeImplementation(){} // RVA: 0x7FFD552BFC20
        public void .ctor(){} // RVA: 0x7FFD552BFCD0
        public void .cctor(){} // RVA: 0x7FFD552BFD30
    }

    public class UdonProgramFormatter : BaseFormatter`1
    {
        public VRC.Udon.Serialization.OdinSerializer.Serializer`1<byte[]> _byteArrayReaderWriter;
        public VRC.Udon.Serialization.OdinSerializer.Serializer`1<VRC.Udon.Common.Interfaces.IUdonHeap> _udonHeapReaderWriter; // 0x8
        public VRC.Udon.Serialization.OdinSerializer.Serializer`1<ÎÏÍÏÏÎÌÌ.ÍÎÌÌÍÏÎ> _udonSymbolTableReaderWriter; // 0x10
        public VRC.Udon.Serialization.OdinSerializer.Serializer`1<0x6662FFF8> _udonSyncMetadataTableReaderWriter; // 0x18

        // ── Methods ──
        public void GetUninitializedObject(){} // RVA: 0x7FFD4E919180
        public void DeserializeImplementation(){} // RVA: 0x7FFD552BFE10
        public void SerializeImplementation(){} // RVA: 0x7FFD552C02B0
        public void .ctor(){} // RVA: 0x7FFD552C05B0
        public void .cctor(){} // RVA: 0x7FFD552C0610
    }

}