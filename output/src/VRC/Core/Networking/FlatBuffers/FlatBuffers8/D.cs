// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers8
// Classes: 20
// Methods: 164

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers8
{
    public class DataStorage : ValueType
    {
        public Google.FlatBuffers8.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsDataStorage(){} // RVA: 0x7FFAC9D75670 | overloaded x2
        public void VerifyDataStorage(){} // RVA: 0x7FFAC9D76630
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void EntriesType(){} // RVA: 0x7FFAC9D75C20
        public void get_EntriesTypeLength(){} // RVA: 0x7FFAC9D75CA0
        public void GetEntriesTypeBytes(){} // RVA: 0x7FFAC9D76720
        public void GetEntriesTypeArray(){} // RVA: 0x7FFAC9D76790
        public void Entries(){} // RVA: 0x7FFAC2E8DC40
        public void get_EntriesLength(){} // RVA: 0x7FFAC9D76940
        public void CreateDataStorage(){} // RVA: 0x7FFAC9D769B0
        public void StartDataStorage(){} // RVA: 0x7FFAC9D76AA0
        public void AddEntriesType(){} // RVA: 0x7FFAC9D75900
        public void CreateEntriesTypeVector(){} // RVA: 0x7FFAC9D75F20
        public void CreateEntriesTypeVectorBlock(){} // RVA: 0x7FFAC9D76C20 | overloaded x3
        public void StartEntriesTypeVector(){} // RVA: 0x7FFAC9D761C0
        public void AddEntries(){} // RVA: 0x7FFAC9D76CB0
        public void CreateEntriesVector(){} // RVA: 0x7FFAC9D76CF0
        public void CreateEntriesVectorBlock(){} // RVA: 0x7FFAC9D76ED0 | overloaded x3
        public void StartEntriesVector(){} // RVA: 0x7FFAC9D761C0
        public void EndDataStorage(){} // RVA: 0x7FFAC9D76F60
        public void FinishDataStorageBuffer(){} // RVA: 0x7FFAC9D76FF0
        public void FinishSizePrefixedDataStorageBuffer(){} // RVA: 0x7FFAC9D77050
        public void UnPack(){} // RVA: 0x7FFAC9D770D0
        public void UnPackTo(){} // RVA: 0x7FFAC9D77180
        public void Pack(){} // RVA: 0x7FFAC9D778B0
    }

    public class DataStorageBool : ValueType
    {
        public Google.FlatBuffers8.Struct ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_Value(){} // RVA: 0x7FFAC9D75000
        public void MutateValue(){} // RVA: 0x7FFAC9D75030
        public void CreateDataStorageBool(){} // RVA: 0x7FFAC9D75060
        public void UnPack(){} // RVA: 0x7FFAC9D75130
        public void UnPackTo(){} // RVA: 0x7FFAC9D751A0
        public void Pack(){} // RVA: 0x7FFAC9D751E0
    }

    public class DataStorageBoolT : Object
    {
        public bool Value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAC2FEB5E0
        public void set_Value(){} // RVA: 0x7FFAC2FEB5F0
        public void .ctor(){} // RVA: 0x7FFAC322C880
    }

    public class DataStorageBytes : ValueType
    {
        public Google.FlatBuffers8.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsDataStorageBytes(){} // RVA: 0x7FFAC9D75670 | overloaded x2
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void Value(){} // RVA: 0x7FFAC9D75C20
        public void get_ValueLength(){} // RVA: 0x7FFAC9D75CA0
        public void GetValueBytes(){} // RVA: 0x7FFAC9D75D10
        public void GetValueArray(){} // RVA: 0x7FFAC9D75D80
        public void MutateValue(){} // RVA: 0x7FFAC9D75DD0
        public void CreateDataStorageBytes(){} // RVA: 0x7FFAC9D75E60
        public void StartDataStorageBytes(){} // RVA: 0x7FFAC9D758E0
        public void AddValue(){} // RVA: 0x7FFAC9D75900
        public void CreateValueVector(){} // RVA: 0x7FFAC9D75F20
        public void CreateValueVectorBlock(){} // RVA: 0x7FFAC9D76130 | overloaded x3
        public void StartValueVector(){} // RVA: 0x7FFAC9D761C0
        public void EndDataStorageBytes(){} // RVA: 0x7FFAC9D761F0
        public void UnPack(){} // RVA: 0x7FFAC9D76280
        public void UnPackTo(){} // RVA: 0x7FFAC9D76330
        public void Pack(){} // RVA: 0x7FFAC9D76540
    }

    public class DataStorageBytesT : Object
    {
        public System.Collections.Generic.List`1<byte> Value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAC2F3C380
        public void set_Value(){} // RVA: 0x7FFAC2F22E30
        public void .ctor(){} // RVA: 0x7FFAC7DDDC00
    }

    public class DataStorageBytesVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAC9D765C0
    }

    public class DataStorageEntryUnion : Object
    {
        public 0x6B1FB638 Type; // 0x10
        public object Value; // 0x18

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAC2FEB5E0
        public void set_Type(){} // RVA: 0x7FFAC2FEB5F0
        public void get_Value(){} // RVA: 0x7FFAC2F247C0
        public void set_Value(){} // RVA: 0x7FFAC2F87E80
        public void .ctor(){} // RVA: 0x7FFAC9D74460
        public void As(){} // RVA: 0x7FFAC2E8DC40
        public void AsDataStorageBool(){} // RVA: 0x7FFAC9D744C0
        public void FromDataStorageBool(){} // RVA: 0x7FFAC9D74500
        public void AsDataStorageInt(){} // RVA: 0x7FFAC9D74600
        public void FromDataStorageInt(){} // RVA: 0x7FFAC9D74640
        public void AsDataStorageFloat(){} // RVA: 0x7FFAC9D74740
        public void FromDataStorageFloat(){} // RVA: 0x7FFAC9D74780
        public void AsDataStorageString(){} // RVA: 0x7FFAC9D74880
        public void FromDataStorageString(){} // RVA: 0x7FFAC9D748C0
        public void AsDataStorageBytes(){} // RVA: 0x7FFAC9D749C0
        public void FromDataStorageBytes(){} // RVA: 0x7FFAC9D74A00
        public void Pack(){} // RVA: 0x7FFAC9D74B00
    }

    public class DataStorageEntryVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAC9D74D80
    }

    public class DataStorageFloat : ValueType
    {
        public Google.FlatBuffers8.Struct ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_Value(){} // RVA: 0x7FFAC9D75400
        public void MutateValue(){} // RVA: 0x7FFAC9D75430
        public void CreateDataStorageFloat(){} // RVA: 0x7FFAC9D75460
        public void UnPack(){} // RVA: 0x7FFAC9D75540
        public void UnPackTo(){} // RVA: 0x7FFAC9D755B0
        public void Pack(){} // RVA: 0x7FFAC9D755F0
    }

    public class DataStorageFloatT : Object
    {
        public float Value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAC304B320
        public void set_Value(){} // RVA: 0x7FFAC304B330
        public void .ctor(){} // RVA: 0x7FFAC369FBB0
    }

    public class DataStorageInt : ValueType
    {
        public Google.FlatBuffers8.Struct ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_Value(){} // RVA: 0x7FFAC9D75200
        public void MutateValue(){} // RVA: 0x7FFAC9D75230
        public void CreateDataStorageInt(){} // RVA: 0x7FFAC9D75260
        public void UnPack(){} // RVA: 0x7FFAC9D75330
        public void UnPackTo(){} // RVA: 0x7FFAC9D753A0
        public void Pack(){} // RVA: 0x7FFAC9D753E0
    }

    public class DataStorageIntT : Object
    {
        public int Value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAC2F6E5C0
        public void set_Value(){} // RVA: 0x7FFAC2F240C0
        public void .ctor(){} // RVA: 0x7FFAC369FBB0
    }

    public class DataStorageString : ValueType
    {
        public Google.FlatBuffers8.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsDataStorageString(){} // RVA: 0x7FFAC9D75670 | overloaded x2
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_Value(){} // RVA: 0x7FFAC9D756D0
        public void GetValueBytes(){} // RVA: 0x7FFAC9D75760
        public void GetValueArray(){} // RVA: 0x7FFAC9D757D0
        public void CreateDataStorageString(){} // RVA: 0x7FFAC9D75820
        public void StartDataStorageString(){} // RVA: 0x7FFAC9D758E0
        public void AddValue(){} // RVA: 0x7FFAC9D75900
        public void EndDataStorageString(){} // RVA: 0x7FFAC9D75940
        public void UnPack(){} // RVA: 0x7FFAC9D759D0
        public void UnPackTo(){} // RVA: 0x7FFAC9D75AE0
        public void Pack(){} // RVA: 0x7FFAC9D75B50
    }

    public class DataStorageStringT : Object
    {
        public string Value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAC2F3C380
        public void set_Value(){} // RVA: 0x7FFAC2F22E30
        public void .ctor(){} // RVA: 0x7FFAC7DDDC00
    }

    public class DataStorageStringVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAC9D75BB0
    }

    public class DataStorageT : Object
    {
        public System.Collections.Generic.List`1<VRC.Core.Networking.FlatBuffers.FlatBuffers8.DataStorageEntryUnion> Entries; // 0x10

        // ── Methods ──
        public void get_Entries(){} // RVA: 0x7FFAC2F3C380
        public void set_Entries(){} // RVA: 0x7FFAC2F22E30
        public void .ctor(){} // RVA: 0x7FFAC7DDDC00
        public void DeserializeFromBinary(){} // RVA: 0x7FFAC9D77C40
        public void SerializeToBinary(){} // RVA: 0x7FFAC9D77CF0
    }

    public class DataStorageVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAC9D765C0
    }

    public class DestructiblePlayer : ValueType
    {
        public Google.FlatBuffers8.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsDestructiblePlayer(){} // RVA: 0x7FFAC9D75670 | overloaded x2
        public void VerifyDestructiblePlayer(){} // RVA: 0x7FFAC9D77DF0
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_Health(){} // RVA: 0x7FFAC9D77EE0
        public void MutateHealth(){} // RVA: 0x7FFAC9D77F30
        public void CreateDestructiblePlayer(){} // RVA: 0x7FFAC9D77F90
        public void StartDestructiblePlayer(){} // RVA: 0x7FFAC9D758E0
        public void AddHealth(){} // RVA: 0x7FFAC9D78090
        public void EndDestructiblePlayer(){} // RVA: 0x7FFAC9D78110
        public void FinishDestructiblePlayerBuffer(){} // RVA: 0x7FFAC9D76FF0
        public void FinishSizePrefixedDestructiblePlayerBuffer(){} // RVA: 0x7FFAC9D77050
        public void UnPack(){} // RVA: 0x7FFAC9D781A0
        public void UnPackTo(){} // RVA: 0x7FFAC9D78240
        public void Pack(){} // RVA: 0x7FFAC9D782A0
    }

    public class DestructiblePlayerT : Object
    {
        public float Health; // 0x10

        // ── Methods ──
        public void get_Health(){} // RVA: 0x7FFAC304B320
        public void set_Health(){} // RVA: 0x7FFAC304B330
        public void .ctor(){} // RVA: 0x7FFAC369FBB0
        public void DeserializeFromBinary(){} // RVA: 0x7FFAC9D782C0
        public void SerializeToBinary(){} // RVA: 0x7FFAC9D783F0
    }

    public class DestructiblePlayerVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAC9D784F0
    }

}