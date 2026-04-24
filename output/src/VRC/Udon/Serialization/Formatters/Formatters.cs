// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.Formatters
// Classes: 2
// Methods: 10

namespace VRC.Udon.Serialization.Formatters
{
    public class UdonGameObjectComponentReferenceFormatter : BaseFormatter`1
    {
        public tSupportedException_ConstructorMaxOf64Parameters<?> _typeSerializer;

        // ── Methods ──
        public void GetUninitializedObject(){} // RVA: 0x7FFD4E919180
        public void DeserializeImplementation(){} // RVA: 0x7FFD552BFA40
        public void SerializeImplementation(){} // RVA: 0x7FFD552BFC20
        public void .ctor(){} // RVA: 0x7FFD552BFCD0
        public void .cctor(){} // RVA: 0x7FFD552BFD30
    }

    public class UdonProgramFormatter : BaseFormatter`1
    {
        public tSupportedException_ConstructorMaxOf64Parameters<byte[]> _byteArrayReaderWriter;
        public tSupportedException_ConstructorMaxOf64Parameters<tmapScaleOffset_Injected> _udonHeapReaderWriter; // 0x8
        public tSupportedException_ConstructorMaxOf64Parameters<sMultiplier_Injected> _udonSymbolTableReaderWriter; // 0x10
        public tSupportedException_ConstructorMaxOf64Parameters<TreeInstance_Injected> _udonSyncMetadataTableReaderWriter; // 0x18

        // ── Methods ──
        public void GetUninitializedObject(){} // RVA: 0x7FFD4E919180
        public void DeserializeImplementation(){} // RVA: 0x7FFD552BFE10
        public void SerializeImplementation(){} // RVA: 0x7FFD552C02B0
        public void .ctor(){} // RVA: 0x7FFD552C05B0
        public void .cctor(){} // RVA: 0x7FFD552C0610
    }

}