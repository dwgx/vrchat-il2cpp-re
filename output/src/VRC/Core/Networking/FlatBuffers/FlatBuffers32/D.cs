// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers32
// Classes: 17
// Methods: 127

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers32
{
    public class DataStorage : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsDataStorage(){} // RVA: 0x823F500
        public void VerifyDataStorage(){} // RVA: 0x8248540
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void EntriesType(){} // RVA: 0x9BC8B0
        public void get_EntriesTypeLength(){} // RVA: 0x9BCA70
        public void GetEntriesTypeBytes(){} // RVA: 0x9BCAE0
        public void GetEntriesTypeArray(){} // RVA: 0x9BCB50
        public void Entries(){} // RVA: 0xA94080
        public void get_EntriesLength(){} // RVA: 0x9BCC80
        public void CreateDataStorage(){} // RVA: 0x8248840
        public void StartDataStorage(){} // RVA: 0x82488F0
        public void AddEntriesType(){} // RVA: 0x82476E0
        public void CreateEntriesTypeVector(){} // RVA: 0x8247C50
        public void CreateEntriesTypeVectorBlock(){} // RVA: 0x8248AC0
        public void StartEntriesTypeVector(){} // RVA: 0x8247FC0
        public void AddEntries(){} // RVA: 0x8248B80
        public void CreateEntriesVector(){} // RVA: 0x823FEE0
        public void CreateEntriesVectorBlock(){} // RVA: 0x8248D60
        public void StartEntriesVector(){} // RVA: 0x82402C0
        public void EndDataStorage(){} // RVA: 0x8248E20
        public void FinishDataStorageBuffer(){} // RVA: 0x8248E70
        public void FinishSizePrefixedDataStorageBuffer(){} // RVA: 0x8248ED0
        public void UnPack(){} // RVA: 0x9BCC90
        public void UnPackTo(){} // RVA: 0x9BCCA0
        public void Pack(){} // RVA: 0x82496D0
    }

    public class DataStorageBool : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_Value(){} // RVA: 0x9BC2E0
        public void CreateDataStorageBool(){} // RVA: 0x8246EE0
        public void UnPack(){} // RVA: 0x9BC310
        public void UnPackTo(){} // RVA: 0x9BC320
        public void Pack(){} // RVA: 0x8247020
    }

    public class DataStorageBoolT : Object
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0xC120A0
        public void set_Value(){} // RVA: 0xC120B0
        public void .ctor(){} // RVA: 0xF48510
    }

    public class DataStorageBytes : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsDataStorageBytes(){} // RVA: 0x823F500
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void Value(){} // RVA: 0x9BC8B0
        public void get_ValueLength(){} // RVA: 0x9BC8C0
        public void GetValueBytes(){} // RVA: 0x9BC8D0
        public void GetValueArray(){} // RVA: 0x9BC940
        public void CreateDataStorageBytes(){} // RVA: 0x8247BD0
        public void StartDataStorageBytes(){} // RVA: 0x82476C0
        public void AddValue(){} // RVA: 0x82476E0
        public void CreateValueVector(){} // RVA: 0x8247C50
        public void CreateValueVectorBlock(){} // RVA: 0x8247F00
        public void StartValueVector(){} // RVA: 0x8247FC0
        public void EndDataStorageBytes(){} // RVA: 0x8247FF0
        public void UnPack(){} // RVA: 0x9BC990
        public void UnPackTo(){} // RVA: 0x9BC9A0
        public void Pack(){} // RVA: 0x8248300
    }

    public class DataStorageBytesT : Object
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0xB5DBF0
        public void set_Value(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0x627C9E0
    }

    public class DataStorageBytesVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x82484D0
    }

    public class DataStorageEntryUnion : Object
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0xC120A0
        public void set_Type(){} // RVA: 0xC120B0
        public void get_Value(){} // RVA: 0xB465B0
        public void set_Value(){} // RVA: 0xBA9BA0
        public void .ctor(){} // RVA: 0x8215F60
        public void As(){} // RVA: 0xA94080
        public void AsDataStorageBool(){} // RVA: 0x8246130
        public void FromDataStorageBool(){} // RVA: 0x82461B0
        public void AsDataStorageInt(){} // RVA: 0x82462B0
        public void FromDataStorageInt(){} // RVA: 0x8246330
        public void AsDataStorageFloat(){} // RVA: 0x8246430
        public void FromDataStorageFloat(){} // RVA: 0x82464B0
        public void AsDataStorageString(){} // RVA: 0x82465B0
        public void FromDataStorageString(){} // RVA: 0x8246630
        public void AsDataStorageBytes(){} // RVA: 0x8246730
        public void FromDataStorageBytes(){} // RVA: 0x82467B0
        public void Pack(){} // RVA: 0x82468B0
    }

    public class DataStorageEntryVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x8246D40
    }

    public class DataStorageFloat : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_Value(){} // RVA: 0x9BC560
        public void CreateDataStorageFloat(){} // RVA: 0x8247320
        public void UnPack(){} // RVA: 0x9BC590
        public void UnPackTo(){} // RVA: 0x9BC5A0
        public void Pack(){} // RVA: 0x8247460
    }

    public class DataStorageFloatT : Object
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0xC763E0
        public void set_Value(){} // RVA: 0xC763F0
        public void .ctor(){} // RVA: 0x132A2D0
    }

    public class DataStorageInt : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_Value(){} // RVA: 0x9BC420
        public void CreateDataStorageInt(){} // RVA: 0x8247100
        public void UnPack(){} // RVA: 0x9BC450
        public void UnPackTo(){} // RVA: 0x9BC460
        public void Pack(){} // RVA: 0x8247240
    }

    public class DataStorageIntT : Object
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0xB8F8F0
        public void set_Value(){} // RVA: 0xB460A0
        public void .ctor(){} // RVA: 0x132A2D0
    }

    public class DataStorageString : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsDataStorageString(){} // RVA: 0x823F500
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_Value(){} // RVA: 0x9BC6A0
        public void GetValueBytes(){} // RVA: 0x9BC6B0
        public void GetValueArray(){} // RVA: 0x9BC720
        public void CreateDataStorageString(){} // RVA: 0x8247640
        public void StartDataStorageString(){} // RVA: 0x82476C0
        public void AddValue(){} // RVA: 0x82476E0
        public void EndDataStorageString(){} // RVA: 0x8247720
        public void UnPack(){} // RVA: 0x9BC770
        public void UnPackTo(){} // RVA: 0x9BC780
        public void Pack(){} // RVA: 0x82478F0
    }

    public class DataStorageStringT : Object
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0xB5DBF0
        public void set_Value(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0x627C9E0
    }

    public class DataStorageStringVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x82479B0
    }

    public class DataStorageT : Object
    {
        // ── Methods ──
        public void get_Entries(){} // RVA: 0xB5DBF0
        public void set_Entries(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0x627C9E0
        public void DeserializeFromBinary(){} // RVA: 0x8249AD0
        public void SerializeToBinary(){} // RVA: 0x8249B80
    }

    public class DataStorageVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x82484D0
    }

}