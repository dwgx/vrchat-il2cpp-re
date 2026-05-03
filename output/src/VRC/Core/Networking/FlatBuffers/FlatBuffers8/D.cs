// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers8
// Classes: 20
// Methods: 159

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers8
{
    public class DataStorage : ValueType
    {
        public Google.FlatBuffers8.Table __p; // 0x10
        public object field_1; // 0xA1
        public object field_2; // 0xA2

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsDataStorage(){} // RVA: 0x7FFE8811DC90 | overloaded x2
        public void VerifyDataStorage(){} // RVA: 0x7FFE8811EBC0
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void EntriesType(){} // RVA: 0x7FFE8811E240
        public void get_EntriesTypeLength(){} // RVA: 0x7FFE8811E2C0
        public void GetEntriesTypeBytes(){} // RVA: 0x7FFE8811ECB0
        public void GetEntriesTypeArray(){} // RVA: 0x7FFE8811ED20
        public void Entries(){} // RVA: 0x7FFE810A1420
        public void get_EntriesLength(){} // RVA: 0x7FFE8811EED0
        public void CreateDataStorage(){} // RVA: 0x7FFE8811EF40
        public void StartDataStorage(){} // RVA: 0x7FFE8811F030
        public void AddEntriesType(){} // RVA: 0x7FFE8811DF20
        public void CreateEntriesTypeVector(){} // RVA: 0x7FFE8811E4B0
        public void CreateEntriesTypeVectorBlock(){} // RVA: 0x7FFE8811F1B0 | overloaded x3
        public void StartEntriesTypeVector(){} // RVA: 0x7FFE8811E750
        public void AddEntries(){} // RVA: 0x7FFE8811F240
        public void CreateEntriesVector(){} // RVA: 0x7FFE8811F280
        public void CreateEntriesVectorBlock(){} // RVA: 0x7FFE8811F460 | overloaded x3
        public void StartEntriesVector(){} // RVA: 0x7FFE8811E750
        public void EndDataStorage(){} // RVA: 0x7FFE8811F4F0
        public void FinishDataStorageBuffer(){} // RVA: 0x7FFE8811F580
        public void FinishSizePrefixedDataStorageBuffer(){} // RVA: 0x7FFE8811F5E0
        public void UnPack(){} // RVA: 0x7FFE8811F660
        public void UnPackTo(){} // RVA: 0x7FFE8811F710
        public void Pack(){} // RVA: 0x7FFE8811FE40
    }

    public class DataStorageBool : ValueType
    {
        public Google.FlatBuffers8.Struct __p; // 0x10
        public object field_1; // 0x92

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_Value(){} // RVA: 0x7FFE8811D6C0
        public void CreateDataStorageBool(){} // RVA: 0x7FFE8811D6F0
        public void UnPack(){} // RVA: 0x7FFE8811D7C0
        public void UnPackTo(){} // RVA: 0x7FFE8811D830
        public void Pack(){} // RVA: 0x7FFE8811D870
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
        public Google.FlatBuffers8.Table __p; // 0x10
        public object field_1; // 0x9E

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsDataStorageBytes(){} // RVA: 0x7FFE8811DC90 | overloaded x2
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void Value(){} // RVA: 0x7FFE8811E240
        public void get_ValueLength(){} // RVA: 0x7FFE8811E2C0
        public void GetValueBytes(){} // RVA: 0x7FFE8811E330
        public void GetValueArray(){} // RVA: 0x7FFE8811E3A0
        public void CreateDataStorageBytes(){} // RVA: 0x7FFE8811E3F0
        public void StartDataStorageBytes(){} // RVA: 0x7FFE8811DF00
        public void AddValue(){} // RVA: 0x7FFE8811DF20
        public void CreateValueVector(){} // RVA: 0x7FFE8811E4B0
        public void CreateValueVectorBlock(){} // RVA: 0x7FFE8811E6C0 | overloaded x3
        public void StartValueVector(){} // RVA: 0x7FFE8811E750
        public void EndDataStorageBytes(){} // RVA: 0x7FFE8811E780
        public void UnPack(){} // RVA: 0x7FFE8811E810
        public void UnPackTo(){} // RVA: 0x7FFE8811E8C0
        public void Pack(){} // RVA: 0x7FFE8811EAD0
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
        public void Verify(){} // RVA: 0x7FFE8811EB50
    }

    public class DataStorageEntryUnion : Object
    {
        public 0x665F4EFC _type; // 0x10
        public object _value; // 0x18

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFE811C55E0
        public void set_Type(){} // RVA: 0x7FFE811C55F0
        public void get_Value(){} // RVA: 0x7FFE810FE7C0
        public void set_Value(){} // RVA: 0x7FFE81161E80
        public void .ctor(){} // RVA: 0x7FFE8811CB20
        public void As(){} // RVA: 0x7FFE810A1420
        public void AsDataStorageBool(){} // RVA: 0x7FFE8811CB80
        public void FromDataStorageBool(){} // RVA: 0x7FFE8811CBC0
        public void AsDataStorageInt(){} // RVA: 0x7FFE8811CCC0
        public void FromDataStorageInt(){} // RVA: 0x7FFE8811CD00
        public void AsDataStorageFloat(){} // RVA: 0x7FFE8811CE00
        public void FromDataStorageFloat(){} // RVA: 0x7FFE8811CE40
        public void AsDataStorageString(){} // RVA: 0x7FFE8811CF40
        public void FromDataStorageString(){} // RVA: 0x7FFE8811CF80
        public void AsDataStorageBytes(){} // RVA: 0x7FFE8811D080
        public void FromDataStorageBytes(){} // RVA: 0x7FFE8811D0C0
        public void Pack(){} // RVA: 0x7FFE8811D1C0
    }

    public class DataStorageEntryVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFE8811D440
    }

    public class DataStorageFloat : ValueType
    {
        public Google.FlatBuffers8.Struct __p; // 0x10
        public object field_1; // 0x98

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_Value(){} // RVA: 0x7FFE8811DA60
        public void CreateDataStorageFloat(){} // RVA: 0x7FFE8811DA90
        public void UnPack(){} // RVA: 0x7FFE8811DB60
        public void UnPackTo(){} // RVA: 0x7FFE8811DBD0
        public void Pack(){} // RVA: 0x7FFE8811DC10
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
        public Google.FlatBuffers8.Struct __p; // 0x10
        public object field_1; // 0x95

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_Value(){} // RVA: 0x7FFE8811D890
        public void CreateDataStorageInt(){} // RVA: 0x7FFE8811D8C0
        public void UnPack(){} // RVA: 0x7FFE8811D990
        public void UnPackTo(){} // RVA: 0x7FFE8811DA00
        public void Pack(){} // RVA: 0x7FFE8811DA40
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
        public Google.FlatBuffers8.Table __p; // 0x10
        public object field_1; // 0x9B

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsDataStorageString(){} // RVA: 0x7FFE8811DC90 | overloaded x2
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_Value(){} // RVA: 0x7FFE8811DCF0
        public void GetValueBytes(){} // RVA: 0x7FFE8811DD80
        public void GetValueArray(){} // RVA: 0x7FFE8811DDF0
        public void CreateDataStorageString(){} // RVA: 0x7FFE8811DE40
        public void StartDataStorageString(){} // RVA: 0x7FFE8811DF00
        public void AddValue(){} // RVA: 0x7FFE8811DF20
        public void EndDataStorageString(){} // RVA: 0x7FFE8811DF60
        public void UnPack(){} // RVA: 0x7FFE8811DFF0
        public void UnPackTo(){} // RVA: 0x7FFE8811E100
        public void Pack(){} // RVA: 0x7FFE8811E170
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
        public void Verify(){} // RVA: 0x7FFE8811E1D0
    }

    public class DataStorageT : Object
    {
        public System.Collections.Generic.List`1<VRC.Core.Networking.FlatBuffers.FlatBuffers8.DataStorageEntryUnion> _entries; // 0x10

        // ── Methods ──
        public void get_Entries(){} // RVA: 0x7FFE81116380
        public void set_Entries(){} // RVA: 0x7FFE810FCE30
        public void .ctor(){} // RVA: 0x7FFE86200400
        public void DeserializeFromBinary(){} // RVA: 0x7FFE881201D0
        public void SerializeToBinary(){} // RVA: 0x7FFE88120280
    }

    public class DataStorageVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFE8811EB50
    }

    public class DestructiblePlayer : ValueType
    {
        public Google.FlatBuffers8.Table __p; // 0x10
        public object field_1; // 0xA5

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsDestructiblePlayer(){} // RVA: 0x7FFE8811DC90 | overloaded x2
        public void VerifyDestructiblePlayer(){} // RVA: 0x7FFE88120380
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_Health(){} // RVA: 0x7FFE88120470
        public void CreateDestructiblePlayer(){} // RVA: 0x7FFE881204C0
        public void StartDestructiblePlayer(){} // RVA: 0x7FFE8811DF00
        public void AddHealth(){} // RVA: 0x7FFE881205B0
        public void EndDestructiblePlayer(){} // RVA: 0x7FFE88120620
        public void FinishDestructiblePlayerBuffer(){} // RVA: 0x7FFE8811F580
        public void FinishSizePrefixedDestructiblePlayerBuffer(){} // RVA: 0x7FFE8811F5E0
        public void UnPack(){} // RVA: 0x7FFE881206B0
        public void UnPackTo(){} // RVA: 0x7FFE88120750
        public void Pack(){} // RVA: 0x7FFE881207B0
    }

    public class DestructiblePlayerT : Object
    {
        public float _health; // 0x10

        // ── Methods ──
        public void get_Health(){} // RVA: 0x7FFE81225320
        public void set_Health(){} // RVA: 0x7FFE81225330
        public void .ctor(){} // RVA: 0x7FFE817EE4A0
        public void DeserializeFromBinary(){} // RVA: 0x7FFE881207D0
        public void SerializeToBinary(){} // RVA: 0x7FFE88120900
    }

    public class DestructiblePlayerVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFE88120A00
    }

}