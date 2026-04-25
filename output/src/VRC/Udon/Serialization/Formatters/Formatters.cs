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
        public void GetUninitializedObject(){} // RVA: 0x7FFAC34F9180
        public void DeserializeImplementation(){} // RVA: 0x7FFAC9E9FA40
        public void SerializeImplementation(){} // RVA: 0x7FFAC9E9FC20
        public void .ctor(){} // RVA: 0x7FFAC9E9FCD0
        public void .cctor(){} // RVA: 0x7FFAC9E9FD30
    }

    public class UdonProgramFormatter : BaseFormatter`1
    {
        public VRC.Udon.Serialization.OdinSerializer.Serializer`1<byte[]> _byteArrayReaderWriter;
        public VRC.Udon.Serialization.OdinSerializer.Serializer`1<VRC.Udon.Common.Interfaces.IUdonHeap> _udonHeapReaderWriter; // 0x8
        public VRC.Udon.Serialization.OdinSerializer.Serializer`1<VRC.Udon.Common.Interfaces.IUdonSymbolTable> _udonSymbolTableReaderWriter; // 0x10
        public VRC.Udon.Serialization.OdinSerializer.Serializer`1<VRC.Udon.Common.Interfaces.IUdonSyncMetadataTable> _udonSyncMetadataTableReaderWriter; // 0x18

        // ── Methods ──
        public void GetUninitializedObject(){} // RVA: 0x7FFAC34F9180
        public void DeserializeImplementation(){} // RVA: 0x7FFAC9E9FE10
        public void SerializeImplementation(){} // RVA: 0x7FFAC9EA02B0
        public void .ctor(){} // RVA: 0x7FFAC9EA05B0
        public void .cctor(){} // RVA: 0x7FFAC9EA0610
    }

}