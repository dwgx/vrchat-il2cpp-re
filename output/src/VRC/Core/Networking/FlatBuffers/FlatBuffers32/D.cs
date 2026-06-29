// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers32
// Classes: 17
// Methods: 127

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers32
{
    public class DataStorage : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7A765F080
        public void ValidateVersion(){} // RVA: 0x7A80D7310
        public void GetRootAsDataStorage(){} // RVA: 0x7AF3E5C00
        public void VerifyDataStorage(){} // RVA: 0x7AF3EEA70
        public void __init(){} // RVA: 0x7A7F12470
        public void __assign(){} // RVA: 0x7A7F12480
        public void EntriesType(){} // RVA: 0x7A7F166E0
        public void get_EntriesTypeLength(){} // RVA: 0x7A7F167E0
        public void GetEntriesTypeBytes(){} // RVA: 0x7A7F16850
        public void GetEntriesTypeArray(){} // RVA: 0x7A7F168C0
        public void Entries(){} // RVA: 0x7A8051B10
        public void get_EntriesLength(){} // RVA: 0x7A7F169F0
        public void CreateDataStorage(){} // RVA: 0x7AF3EED70
        public void StartDataStorage(){} // RVA: 0x7AF3EEE20
        public void AddEntriesType(){} // RVA: 0x7AF3EDC10
        public void CreateEntriesTypeVector(){} // RVA: 0x7AF3EE180
        public void CreateEntriesTypeVectorBlock(){} // RVA: 0x7AF3EEFF0
        public void StartEntriesTypeVector(){} // RVA: 0x7AF3EE4F0
        public void AddEntries(){} // RVA: 0x7AF3EF0B0
        public void CreateEntriesVector(){} // RVA: 0x7AF3E65E0
        public void CreateEntriesVectorBlock(){} // RVA: 0x7AF3EF290
        public void StartEntriesVector(){} // RVA: 0x7AF3E69C0
        public void EndDataStorage(){} // RVA: 0x7AF3EF350
        public void FinishDataStorageBuffer(){} // RVA: 0x7AF3EF3A0
        public void FinishSizePrefixedDataStorageBuffer(){} // RVA: 0x7AF3EF400
        public void UnPack(){} // RVA: 0x7A7F16A00
        public void UnPackTo(){} // RVA: 0x7A7F16A10
        public void Pack(){} // RVA: 0x7AF3EFC00
    }

    public class DataStorageBool : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7A765F080
        public void __init(){} // RVA: 0x7A7F12470
        public void __assign(){} // RVA: 0x7A7F12480
        public void get_Value(){} // RVA: 0x7A7F16410
        public void CreateDataStorageBool(){} // RVA: 0x7AF3ED410
        public void UnPack(){} // RVA: 0x7A7F16440
        public void UnPackTo(){} // RVA: 0x7A7F16450
        public void Pack(){} // RVA: 0x7AF3ED550
    }

    public class DataStorageBoolT : Object
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0x7A81A2200
        public void set_Value(){} // RVA: 0x7A81A2210
        public void .ctor(){} // RVA: 0x7A847A460
    }

    public class DataStorageBytes : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7A765F080
        public void ValidateVersion(){} // RVA: 0x7A80D7310
        public void GetRootAsDataStorageBytes(){} // RVA: 0x7AF3E5C00
        public void __init(){} // RVA: 0x7A7F12470
        public void __assign(){} // RVA: 0x7A7F12480
        public void Value(){} // RVA: 0x7A7F166E0
        public void get_ValueLength(){} // RVA: 0x7A7F166F0
        public void GetValueBytes(){} // RVA: 0x7A7F16700
        public void GetValueArray(){} // RVA: 0x7A7F16770
        public void CreateDataStorageBytes(){} // RVA: 0x7AF3EE100
        public void StartDataStorageBytes(){} // RVA: 0x7AF3EDBF0
        public void AddValue(){} // RVA: 0x7AF3EDC10
        public void CreateValueVector(){} // RVA: 0x7AF3EE180
        public void CreateValueVectorBlock(){} // RVA: 0x7AF3EE430
        public void StartValueVector(){} // RVA: 0x7AF3EE4F0
        public void EndDataStorageBytes(){} // RVA: 0x7AF3EE520
        public void UnPack(){} // RVA: 0x7A7F167C0
        public void UnPackTo(){} // RVA: 0x7A7F167D0
        public void Pack(){} // RVA: 0x7AF3EE830
    }

    public class DataStorageBytesT : Object
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0x7A80F2570
        public void set_Value(){} // RVA: 0x7A80D8E20
        public void .ctor(){} // RVA: 0x7AD51EC30
    }

    public class DataStorageBytesVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7AF3EEA00
    }

    public class DataStorageEntryUnion : Object
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x7A81A2200
        public void set_Type(){} // RVA: 0x7A81A2210
        public void get_Value(){} // RVA: 0x7A80DA7B0
        public void set_Value(){} // RVA: 0x7A813E420
        public void .ctor(){} // RVA: 0x7AF3BE020
        public void As(){} // RVA: 0x7A8051B10
        public void AsDataStorageBool(){} // RVA: 0x7AF3EC850
        public void FromDataStorageBool(){} // RVA: 0x7AF3EC890
        public void AsDataStorageInt(){} // RVA: 0x7AF3EC990
        public void FromDataStorageInt(){} // RVA: 0x7AF3EC9D0
        public void AsDataStorageFloat(){} // RVA: 0x7AF3ECAD0
        public void FromDataStorageFloat(){} // RVA: 0x7AF3ECB10
        public void AsDataStorageString(){} // RVA: 0x7AF3ECC10
        public void FromDataStorageString(){} // RVA: 0x7AF3ECC50
        public void AsDataStorageBytes(){} // RVA: 0x7AF3ECD50
        public void FromDataStorageBytes(){} // RVA: 0x7AF3ECD90
        public void Pack(){} // RVA: 0x7AF3ECE90
    }

    public class DataStorageEntryVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7AF3ED270
    }

    public class DataStorageFloat : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7A765F080
        public void __init(){} // RVA: 0x7A7F12470
        public void __assign(){} // RVA: 0x7A7F12480
        public void get_Value(){} // RVA: 0x7A7F16510
        public void CreateDataStorageFloat(){} // RVA: 0x7AF3ED850
        public void UnPack(){} // RVA: 0x7A7F16540
        public void UnPackTo(){} // RVA: 0x7A7F16550
        public void Pack(){} // RVA: 0x7AF3ED990
    }

    public class DataStorageFloatT : Object
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0x7A82023C0
        public void set_Value(){} // RVA: 0x7A82023D0
        public void .ctor(){} // RVA: 0x7A881ACE0
    }

    public class DataStorageInt : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7A765F080
        public void __init(){} // RVA: 0x7A7F12470
        public void __assign(){} // RVA: 0x7A7F12480
        public void get_Value(){} // RVA: 0x7A7F16490
        public void CreateDataStorageInt(){} // RVA: 0x7AF3ED630
        public void UnPack(){} // RVA: 0x7A7F164C0
        public void UnPackTo(){} // RVA: 0x7A7F164D0
        public void Pack(){} // RVA: 0x7AF3ED770
    }

    public class DataStorageIntT : Object
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0x7A8124910
        public void set_Value(){} // RVA: 0x7A80DA0C0
        public void .ctor(){} // RVA: 0x7A881ACE0
    }

    public class DataStorageString : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7A765F080
        public void ValidateVersion(){} // RVA: 0x7A80D7310
        public void GetRootAsDataStorageString(){} // RVA: 0x7AF3E5C00
        public void __init(){} // RVA: 0x7A7F12470
        public void __assign(){} // RVA: 0x7A7F12480
        public void get_Value(){} // RVA: 0x7A7F16590
        public void GetValueBytes(){} // RVA: 0x7A7F165A0
        public void GetValueArray(){} // RVA: 0x7A7F16610
        public void CreateDataStorageString(){} // RVA: 0x7AF3EDB70
        public void StartDataStorageString(){} // RVA: 0x7AF3EDBF0
        public void AddValue(){} // RVA: 0x7AF3EDC10
        public void EndDataStorageString(){} // RVA: 0x7AF3EDC50
        public void UnPack(){} // RVA: 0x7A7F16660
        public void UnPackTo(){} // RVA: 0x7A7F16670
        public void Pack(){} // RVA: 0x7AF3EDE20
    }

    public class DataStorageStringT : Object
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0x7A80F2570
        public void set_Value(){} // RVA: 0x7A80D8E20
        public void .ctor(){} // RVA: 0x7AD51EC30
    }

    public class DataStorageStringVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7AF3EDEE0
    }

    public class DataStorageT : Object
    {
        // ── Methods ──
        public void get_Entries(){} // RVA: 0x7A80F2570
        public void set_Entries(){} // RVA: 0x7A80D8E20
        public void .ctor(){} // RVA: 0x7AD51EC30
        public void DeserializeFromBinary(){} // RVA: 0x7AF3F0000
        public void SerializeToBinary(){} // RVA: 0x7AF3F00B0
    }

    public class DataStorageVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7AF3EEA00
    }

}