// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers32
// Classes: 17
// Methods: 136

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers32
{
    public class DataStorage : ValueType
    {
        public Google.FlatBuffers32.Table __p; // 0x10
        public object field_1; // 0x201
        public object field_2; // 0x202

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsDataStorage(){} // RVA: 0x7FFE881444A0 | overloaded x2
        public void VerifyDataStorage(){} // RVA: 0x7FFE8814D1B0
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void EntriesType(){} // RVA: 0x7FFE8814C6C0
        public void get_EntriesTypeLength(){} // RVA: 0x7FFE8814C740
        public void GetEntriesTypeBytes(){} // RVA: 0x7FFE8814D2A0
        public void GetEntriesTypeArray(){} // RVA: 0x7FFE8814D310
        public void Entries(){} // RVA: 0x7FFE810A1420
        public void get_EntriesLength(){} // RVA: 0x7FFE8814D440
        public void CreateDataStorage(){} // RVA: 0x7FFE8814D4B0
        public void StartDataStorage(){} // RVA: 0x7FFE8814D560
        public void AddEntriesType(){} // RVA: 0x7FFE8814C380
        public void CreateEntriesTypeVector(){} // RVA: 0x7FFE8814C8F0
        public void CreateEntriesTypeVectorBlock(){} // RVA: 0x7FFE8814D730 | overloaded x3
        public void StartEntriesTypeVector(){} // RVA: 0x7FFE8814CC40
        public void AddEntries(){} // RVA: 0x7FFE8814D7F0
        public void CreateEntriesVector(){} // RVA: 0x7FFE88144E80
        public void CreateEntriesVectorBlock(){} // RVA: 0x7FFE8814D9D0 | overloaded x3
        public void StartEntriesVector(){} // RVA: 0x7FFE88145240
        public void EndDataStorage(){} // RVA: 0x7FFE8814DA90
        public void FinishDataStorageBuffer(){} // RVA: 0x7FFE8814DAE0
        public void FinishSizePrefixedDataStorageBuffer(){} // RVA: 0x7FFE8814DB40
        public void UnPack(){} // RVA: 0x7FFE8814DB60
        public void UnPackTo(){} // RVA: 0x7FFE8814DC10
        public void Pack(){} // RVA: 0x7FFE8814E340
    }

    public class DataStorageBool : ValueType
    {
        public Google.FlatBuffers32.Struct __p; // 0x10
        public object field_1; // 0x1F2

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_Value(){} // RVA: 0x7FFE8814BB50
        public void CreateDataStorageBool(){} // RVA: 0x7FFE8814BB80
        public void UnPack(){} // RVA: 0x7FFE8814BC10
        public void UnPackTo(){} // RVA: 0x7FFE8814BC80
        public void Pack(){} // RVA: 0x7FFE8814BCC0
    }

    public class DataStorageBoolT : Object
    {
        public bool _value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFE811C55E0
        public void set_Value(){} // RVA: 0x7FFE811C55F0
        public void .ctor(){} // RVA: 0x7FFE81FCAC70
    }

    public class DataStorageBytes : ValueType
    {
        public Google.FlatBuffers32.Table __p; // 0x10
        public object field_1; // 0x1FE

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsDataStorageBytes(){} // RVA: 0x7FFE881444A0 | overloaded x2
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void Value(){} // RVA: 0x7FFE8814C6C0
        public void get_ValueLength(){} // RVA: 0x7FFE8814C740
        public void GetValueBytes(){} // RVA: 0x7FFE8814C7B0
        public void GetValueArray(){} // RVA: 0x7FFE8814C820
        public void CreateDataStorageBytes(){} // RVA: 0x7FFE8814C870
        public void StartDataStorageBytes(){} // RVA: 0x7FFE8814C360
        public void AddValue(){} // RVA: 0x7FFE8814C380
        public void CreateValueVector(){} // RVA: 0x7FFE8814C8F0
        public void CreateValueVectorBlock(){} // RVA: 0x7FFE8814CB80 | overloaded x3
        public void StartValueVector(){} // RVA: 0x7FFE8814CC40
        public void EndDataStorageBytes(){} // RVA: 0x7FFE8814CC70
        public void UnPack(){} // RVA: 0x7FFE8814CCC0
        public void UnPackTo(){} // RVA: 0x7FFE8814CD70
        public void Pack(){} // RVA: 0x7FFE8814CF80
    }

    public class DataStorageBytesT : Object
    {
        public System.Collections.Generic.List`1<byte> _value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFE81116380
        public void set_Value(){} // RVA: 0x7FFE810FCE30
        public void .ctor(){} // RVA: 0x7FFE86200400
    }

    public class DataStorageBytesVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFE8814D140
    }

    public class DataStorageEntryUnion : Object
    {
        public 0x665F9154 _type; // 0x10
        public object _value; // 0x18

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFE811C55E0
        public void set_Type(){} // RVA: 0x7FFE811C55F0
        public void get_Value(){} // RVA: 0x7FFE810FE7C0
        public void set_Value(){} // RVA: 0x7FFE81161E80
        public void .ctor(){} // RVA: 0x7FFE8811CB20
        public void As(){} // RVA: 0x7FFE810A1420
        public void AsDataStorageBool(){} // RVA: 0x7FFE8814AFC0
        public void FromDataStorageBool(){} // RVA: 0x7FFE8814B000
        public void AsDataStorageInt(){} // RVA: 0x7FFE8814B100
        public void FromDataStorageInt(){} // RVA: 0x7FFE8814B140
        public void AsDataStorageFloat(){} // RVA: 0x7FFE8814B240
        public void FromDataStorageFloat(){} // RVA: 0x7FFE8814B280
        public void AsDataStorageString(){} // RVA: 0x7FFE8814B380
        public void FromDataStorageString(){} // RVA: 0x7FFE8814B3C0
        public void AsDataStorageBytes(){} // RVA: 0x7FFE8814B4C0
        public void FromDataStorageBytes(){} // RVA: 0x7FFE8814B500
        public void Pack(){} // RVA: 0x7FFE8814B600
    }

    public class DataStorageEntryVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFE8814B9E0
    }

    public class DataStorageFloat : ValueType
    {
        public Google.FlatBuffers32.Struct __p; // 0x10
        public object field_1; // 0x1F8

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_Value(){} // RVA: 0x7FFE8814BF90
        public void CreateDataStorageFloat(){} // RVA: 0x7FFE8814BFC0
        public void UnPack(){} // RVA: 0x7FFE8814C050
        public void UnPackTo(){} // RVA: 0x7FFE8814C0C0
        public void Pack(){} // RVA: 0x7FFE8814C100
    }

    public class DataStorageFloatT : Object
    {
        public float _value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFE81225320
        public void set_Value(){} // RVA: 0x7FFE81225330
        public void .ctor(){} // RVA: 0x7FFE817EE4A0
    }

    public class DataStorageInt : ValueType
    {
        public Google.FlatBuffers32.Struct __p; // 0x10
        public object field_1; // 0x1F5

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_Value(){} // RVA: 0x7FFE8814BD70
        public void CreateDataStorageInt(){} // RVA: 0x7FFE8814BDA0
        public void UnPack(){} // RVA: 0x7FFE8814BE30
        public void UnPackTo(){} // RVA: 0x7FFE8814BEA0
        public void Pack(){} // RVA: 0x7FFE8814BEE0
    }

    public class DataStorageIntT : Object
    {
        public int _value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFE811485C0
        public void set_Value(){} // RVA: 0x7FFE810FE0C0
        public void .ctor(){} // RVA: 0x7FFE817EE4A0
    }

    public class DataStorageString : ValueType
    {
        public Google.FlatBuffers32.Table __p; // 0x10
        public object field_1; // 0x1FB

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsDataStorageString(){} // RVA: 0x7FFE881444A0 | overloaded x2
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_Value(){} // RVA: 0x7FFE8814C190
        public void GetValueBytes(){} // RVA: 0x7FFE8814C220
        public void GetValueArray(){} // RVA: 0x7FFE8814C290
        public void CreateDataStorageString(){} // RVA: 0x7FFE8814C2E0
        public void StartDataStorageString(){} // RVA: 0x7FFE8814C360
        public void AddValue(){} // RVA: 0x7FFE8814C380
        public void EndDataStorageString(){} // RVA: 0x7FFE8814C3C0
        public void UnPack(){} // RVA: 0x7FFE8814C410
        public void UnPackTo(){} // RVA: 0x7FFE8814C520
        public void Pack(){} // RVA: 0x7FFE8814C590
    }

    public class DataStorageStringT : Object
    {
        public string _value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFE81116380
        public void set_Value(){} // RVA: 0x7FFE810FCE30
        public void .ctor(){} // RVA: 0x7FFE86200400
    }

    public class DataStorageStringVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFE8814C650
    }

    public class DataStorageT : Object
    {
        public System.Collections.Generic.List`1<VRC.Core.Networking.FlatBuffers.FlatBuffers32.DataStorageEntryUnion> _entries; // 0x10

        // ── Methods ──
        public void get_Entries(){} // RVA: 0x7FFE81116380
        public void set_Entries(){} // RVA: 0x7FFE810FCE30
        public void .ctor(){} // RVA: 0x7FFE86200400
        public void DeserializeFromBinary(){} // RVA: 0x7FFE8814E6F0
        public void SerializeToBinary(){} // RVA: 0x7FFE8814E7A0
    }

    public class DataStorageVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFE8814D140
    }

}