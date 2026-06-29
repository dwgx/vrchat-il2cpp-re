// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers8
// Classes: 20
// Methods: 149

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers8
{
    public class DataStorage : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsDataStorage(){} // RVA: 0x8217320
        public void VerifyDataStorage(){} // RVA: 0x8218260
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void EntriesType(){} // RVA: 0x9B5A40
        public void get_EntriesTypeLength(){} // RVA: 0x9B5C00
        public void GetEntriesTypeBytes(){} // RVA: 0x9B5C70
        public void GetEntriesTypeArray(){} // RVA: 0x9B5CE0
        public void Entries(){} // RVA: 0xA94080
        public void get_EntriesLength(){} // RVA: 0x9B5CF0
        public void CreateDataStorage(){} // RVA: 0x82185E0
        public void StartDataStorage(){} // RVA: 0x82186D0
        public void AddEntriesType(){} // RVA: 0x82175B0
        public void CreateEntriesTypeVector(){} // RVA: 0x8217B40
        public void CreateEntriesTypeVectorBlock(){} // RVA: 0x8218850
        public void StartEntriesTypeVector(){} // RVA: 0x8217DF0
        public void AddEntries(){} // RVA: 0x82188E0
        public void CreateEntriesVector(){} // RVA: 0x8218920
        public void CreateEntriesVectorBlock(){} // RVA: 0x8218B10
        public void StartEntriesVector(){} // RVA: 0x8217DF0
        public void EndDataStorage(){} // RVA: 0x8218BA0
        public void FinishDataStorageBuffer(){} // RVA: 0x8218C30
        public void FinishSizePrefixedDataStorageBuffer(){} // RVA: 0x8218C90
        public void UnPack(){} // RVA: 0x9B5D00
        public void UnPackTo(){} // RVA: 0x9B5D10
        public void Pack(){} // RVA: 0x82194F0
    }

    public class DataStorageBool : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_Value(){} // RVA: 0x9B5470
        public void CreateDataStorageBool(){} // RVA: 0x8216D80
        public void UnPack(){} // RVA: 0x9B54A0
        public void UnPackTo(){} // RVA: 0x9B54B0
        public void Pack(){} // RVA: 0x8216F00
    }

    public class DataStorageBoolT : Object
    {
        public object _value;

        // ── Methods ──
        public void get_Value(){} // RVA: 0xC120A0
        public void set_Value(){} // RVA: 0xC120B0
        public void .ctor(){} // RVA: 0xF48510
    }

    public class DataStorageBytes : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsDataStorageBytes(){} // RVA: 0x8217320
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void Value(){} // RVA: 0x9B5A40
        public void get_ValueLength(){} // RVA: 0x9B5A50
        public void GetValueBytes(){} // RVA: 0x9B5A60
        public void GetValueArray(){} // RVA: 0x9B5AD0
        public void CreateDataStorageBytes(){} // RVA: 0x8217A80
        public void StartDataStorageBytes(){} // RVA: 0x8217590
        public void AddValue(){} // RVA: 0x82175B0
        public void CreateValueVector(){} // RVA: 0x8217B40
        public void CreateValueVectorBlock(){} // RVA: 0x8217D60
        public void StartValueVector(){} // RVA: 0x8217DF0
        public void EndDataStorageBytes(){} // RVA: 0x8217E20
        public void UnPack(){} // RVA: 0x9B5B20
        public void UnPackTo(){} // RVA: 0x9B5B30
        public void Pack(){} // RVA: 0x8218170
    }

    public class DataStorageBytesT : Object
    {
        public object _value;

        // ── Methods ──
        public void get_Value(){} // RVA: 0xB5DBF0
        public void set_Value(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0x627C9E0
    }

    public class DataStorageBytesVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x82181F0
    }

    public class DataStorageEntryUnion : Object
    {
        public object _type;
        public object _value;

        // ── Methods ──
        public void get_Type(){} // RVA: 0xC120A0
        public void set_Type(){} // RVA: 0xC120B0
        public void get_Value(){} // RVA: 0xB465B0
        public void set_Value(){} // RVA: 0xBA9BA0
        public void .ctor(){} // RVA: 0x8215F60
        public void As(){} // RVA: 0xA94080
        public void AsDataStorageBool(){} // RVA: 0x8215FC0
        public void FromDataStorageBool(){} // RVA: 0x8216040
        public void AsDataStorageInt(){} // RVA: 0x8216140
        public void FromDataStorageInt(){} // RVA: 0x82161C0
        public void AsDataStorageFloat(){} // RVA: 0x82162C0
        public void FromDataStorageFloat(){} // RVA: 0x8216340
        public void AsDataStorageString(){} // RVA: 0x8216440
        public void FromDataStorageString(){} // RVA: 0x82164C0
        public void AsDataStorageBytes(){} // RVA: 0x82165C0
        public void FromDataStorageBytes(){} // RVA: 0x8216640
        public void Pack(){} // RVA: 0x8216740
    }

    public class DataStorageEntryVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x8216AD0
    }

    public class DataStorageFloat : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_Value(){} // RVA: 0x9B56F0
        public void CreateDataStorageFloat(){} // RVA: 0x8217120
        public void UnPack(){} // RVA: 0x9B5720
        public void UnPackTo(){} // RVA: 0x9B5730
        public void Pack(){} // RVA: 0x82172A0
    }

    public class DataStorageFloatT : Object
    {
        public object _value;

        // ── Methods ──
        public void get_Value(){} // RVA: 0xC763E0
        public void set_Value(){} // RVA: 0xC763F0
        public void .ctor(){} // RVA: 0x132A2D0
    }

    public class DataStorageInt : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_Value(){} // RVA: 0x9B55B0
        public void CreateDataStorageInt(){} // RVA: 0x8216F50
        public void UnPack(){} // RVA: 0x9B55E0
        public void UnPackTo(){} // RVA: 0x9B55F0
        public void Pack(){} // RVA: 0x82170D0
    }

    public class DataStorageIntT : Object
    {
        public object _value;

        // ── Methods ──
        public void get_Value(){} // RVA: 0xB8F8F0
        public void set_Value(){} // RVA: 0xB460A0
        public void .ctor(){} // RVA: 0x132A2D0
    }

    public class DataStorageString : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsDataStorageString(){} // RVA: 0x8217320
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_Value(){} // RVA: 0x9B5830
        public void GetValueBytes(){} // RVA: 0x9B5840
        public void GetValueArray(){} // RVA: 0x9B58B0
        public void CreateDataStorageString(){} // RVA: 0x82174D0
        public void StartDataStorageString(){} // RVA: 0x8217590
        public void AddValue(){} // RVA: 0x82175B0
        public void EndDataStorageString(){} // RVA: 0x82175F0
        public void UnPack(){} // RVA: 0x9B5900
        public void UnPackTo(){} // RVA: 0x9B5910
        public void Pack(){} // RVA: 0x8217800
    }

    public class DataStorageStringT : Object
    {
        public object _value;

        // ── Methods ──
        public void get_Value(){} // RVA: 0xB5DBF0
        public void set_Value(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0x627C9E0
    }

    public class DataStorageStringVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x8217860
    }

    public class DataStorageT : Object
    {
        public object _entries;

        // ── Methods ──
        public void get_Entries(){} // RVA: 0xB5DBF0
        public void set_Entries(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0x627C9E0
        public void DeserializeFromBinary(){} // RVA: 0x82198A0
        public void SerializeToBinary(){} // RVA: 0x8219950
    }

    public class DataStorageVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x82181F0
    }

    public class DestructiblePlayer : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsDestructiblePlayer(){} // RVA: 0x8217320
        public void VerifyDestructiblePlayer(){} // RVA: 0x8219A50
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_Health(){} // RVA: 0x9B5DE0
        public void CreateDestructiblePlayer(){} // RVA: 0x8219B90
        public void StartDestructiblePlayer(){} // RVA: 0x8217590
        public void AddHealth(){} // RVA: 0x8219C80
        public void EndDestructiblePlayer(){} // RVA: 0x8219CF0
        public void FinishDestructiblePlayerBuffer(){} // RVA: 0x8218C30
        public void FinishSizePrefixedDestructiblePlayerBuffer(){} // RVA: 0x8218C90
        public void UnPack(){} // RVA: 0x9B5E30
        public void UnPackTo(){} // RVA: 0x9B5E40
        public void Pack(){} // RVA: 0x8219E80
    }

    public class DestructiblePlayerT : Object
    {
        public object _health;

        // ── Methods ──
        public void get_Health(){} // RVA: 0xC763E0
        public void set_Health(){} // RVA: 0xC763F0
        public void .ctor(){} // RVA: 0x132A2D0
        public void DeserializeFromBinary(){} // RVA: 0x8219EA0
        public void SerializeToBinary(){} // RVA: 0x8219FD0
    }

    public class DestructiblePlayerVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x821A0D0
    }

}