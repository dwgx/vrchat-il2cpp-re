// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers32
// Classes: 17
// Methods: 140

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers32
{
    public class DataStorage : ValueType
    {
        public Google.FlatBuffers32.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsDataStorage(){} // RVA: 0x7FFAC9D9CB90 | overloaded x2
        public void VerifyDataStorage(){} // RVA: 0x7FFAC9DA7050
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void EntriesType(){} // RVA: 0x7FFAC9DA64D0
        public void get_EntriesTypeLength(){} // RVA: 0x7FFAC9DA6550
        public void GetEntriesTypeBytes(){} // RVA: 0x7FFAC9DA7140
        public void GetEntriesTypeArray(){} // RVA: 0x7FFAC9DA71B0
        public void Entries(){} // RVA: 0x7FFAC2E8DC40
        public void get_EntriesLength(){} // RVA: 0x7FFAC9DA72E0
        public void CreateDataStorage(){} // RVA: 0x7FFAC9DA7350
        public void StartDataStorage(){} // RVA: 0x7FFAC9DA7400
        public void AddEntriesType(){} // RVA: 0x7FFAC9DA6190
        public void CreateEntriesTypeVector(){} // RVA: 0x7FFAC9DA6790
        public void CreateEntriesTypeVectorBlock(){} // RVA: 0x7FFAC9DA75D0 | overloaded x3
        public void StartEntriesTypeVector(){} // RVA: 0x7FFAC9DA6AE0
        public void AddEntries(){} // RVA: 0x7FFAC9DA7690
        public void CreateEntriesVector(){} // RVA: 0x7FFAC9D9D690
        public void CreateEntriesVectorBlock(){} // RVA: 0x7FFAC9DA7870 | overloaded x3
        public void StartEntriesVector(){} // RVA: 0x7FFAC9D9DA50
        public void EndDataStorage(){} // RVA: 0x7FFAC9DA7930
        public void FinishDataStorageBuffer(){} // RVA: 0x7FFAC9DA7980
        public void FinishSizePrefixedDataStorageBuffer(){} // RVA: 0x7FFAC9DA79E0
        public void UnPack(){} // RVA: 0x7FFAC9DA7A00
        public void UnPackTo(){} // RVA: 0x7FFAC9DA7AB0
        public void Pack(){} // RVA: 0x7FFAC9DA81E0
    }

    public class DataStorageBool : ValueType
    {
        public Google.FlatBuffers32.Struct ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_Value(){} // RVA: 0x7FFAC9DA58B0
        public void MutateValue(){} // RVA: 0x7FFAC9DA58E0
        public void CreateDataStorageBool(){} // RVA: 0x7FFAC9DA5910
        public void UnPack(){} // RVA: 0x7FFAC9DA59A0
        public void UnPackTo(){} // RVA: 0x7FFAC9DA5A10
        public void Pack(){} // RVA: 0x7FFAC9DA5A50
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
        public Google.FlatBuffers32.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsDataStorageBytes(){} // RVA: 0x7FFAC9D9CB90 | overloaded x2
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void Value(){} // RVA: 0x7FFAC9DA64D0
        public void get_ValueLength(){} // RVA: 0x7FFAC9DA6550
        public void GetValueBytes(){} // RVA: 0x7FFAC9DA65C0
        public void GetValueArray(){} // RVA: 0x7FFAC9DA6630
        public void MutateValue(){} // RVA: 0x7FFAC9DA6680
        public void CreateDataStorageBytes(){} // RVA: 0x7FFAC9DA6710
        public void StartDataStorageBytes(){} // RVA: 0x7FFAC9DA6170
        public void AddValue(){} // RVA: 0x7FFAC9DA6190
        public void CreateValueVector(){} // RVA: 0x7FFAC9DA6790
        public void CreateValueVectorBlock(){} // RVA: 0x7FFAC9DA6A20 | overloaded x3
        public void StartValueVector(){} // RVA: 0x7FFAC9DA6AE0
        public void EndDataStorageBytes(){} // RVA: 0x7FFAC9DA6B10
        public void UnPack(){} // RVA: 0x7FFAC9DA6B60
        public void UnPackTo(){} // RVA: 0x7FFAC9DA6C10
        public void Pack(){} // RVA: 0x7FFAC9DA6E20
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
        public void Verify(){} // RVA: 0x7FFAC9DA6FE0
    }

    public class DataStorageEntryUnion : Object
    {
        public 0x6B1FF890 Type; // 0x10
        public object Value; // 0x18

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAC2FEB5E0
        public void set_Type(){} // RVA: 0x7FFAC2FEB5F0
        public void get_Value(){} // RVA: 0x7FFAC2F247C0
        public void set_Value(){} // RVA: 0x7FFAC2F87E80
        public void .ctor(){} // RVA: 0x7FFAC9D74460
        public void As(){} // RVA: 0x7FFAC2E8DC40
        public void AsDataStorageBool(){} // RVA: 0x7FFAC9DA4D10
        public void FromDataStorageBool(){} // RVA: 0x7FFAC9DA4D50
        public void AsDataStorageInt(){} // RVA: 0x7FFAC9DA4E50
        public void FromDataStorageInt(){} // RVA: 0x7FFAC9DA4E90
        public void AsDataStorageFloat(){} // RVA: 0x7FFAC9DA4F90
        public void FromDataStorageFloat(){} // RVA: 0x7FFAC9DA4FD0
        public void AsDataStorageString(){} // RVA: 0x7FFAC9DA50D0
        public void FromDataStorageString(){} // RVA: 0x7FFAC9DA5110
        public void AsDataStorageBytes(){} // RVA: 0x7FFAC9DA5210
        public void FromDataStorageBytes(){} // RVA: 0x7FFAC9DA5250
        public void Pack(){} // RVA: 0x7FFAC9DA5350
    }

    public class DataStorageEntryVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAC9DA5740
    }

    public class DataStorageFloat : ValueType
    {
        public Google.FlatBuffers32.Struct ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_Value(){} // RVA: 0x7FFAC9DA5D50
        public void MutateValue(){} // RVA: 0x7FFAC9DA5D80
        public void CreateDataStorageFloat(){} // RVA: 0x7FFAC9DA5DB0
        public void UnPack(){} // RVA: 0x7FFAC9DA5E40
        public void UnPackTo(){} // RVA: 0x7FFAC9DA5EB0
        public void Pack(){} // RVA: 0x7FFAC9DA5EF0
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
        public Google.FlatBuffers32.Struct ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_Value(){} // RVA: 0x7FFAC9DA5B00
        public void MutateValue(){} // RVA: 0x7FFAC9DA5B30
        public void CreateDataStorageInt(){} // RVA: 0x7FFAC9DA5B60
        public void UnPack(){} // RVA: 0x7FFAC9DA5BF0
        public void UnPackTo(){} // RVA: 0x7FFAC9DA5C60
        public void Pack(){} // RVA: 0x7FFAC9DA5CA0
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
        public Google.FlatBuffers32.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsDataStorageString(){} // RVA: 0x7FFAC9D9CB90 | overloaded x2
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_Value(){} // RVA: 0x7FFAC9DA5FA0
        public void GetValueBytes(){} // RVA: 0x7FFAC9DA6030
        public void GetValueArray(){} // RVA: 0x7FFAC9DA60A0
        public void CreateDataStorageString(){} // RVA: 0x7FFAC9DA60F0
        public void StartDataStorageString(){} // RVA: 0x7FFAC9DA6170
        public void AddValue(){} // RVA: 0x7FFAC9DA6190
        public void EndDataStorageString(){} // RVA: 0x7FFAC9DA61D0
        public void UnPack(){} // RVA: 0x7FFAC9DA6220
        public void UnPackTo(){} // RVA: 0x7FFAC9DA6330
        public void Pack(){} // RVA: 0x7FFAC9DA63A0
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
        public void Verify(){} // RVA: 0x7FFAC9DA6460
    }

    public class DataStorageT : Object
    {
        public System.Collections.Generic.List`1<VRC.Core.Networking.FlatBuffers.FlatBuffers32.DataStorageEntryUnion> Entries; // 0x10

        // ── Methods ──
        public void get_Entries(){} // RVA: 0x7FFAC2F3C380
        public void set_Entries(){} // RVA: 0x7FFAC2F22E30
        public void .ctor(){} // RVA: 0x7FFAC7DDDC00
        public void DeserializeFromBinary(){} // RVA: 0x7FFAC9DA8590
        public void SerializeToBinary(){} // RVA: 0x7FFAC9DA8640
    }

    public class DataStorageVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAC9DA6FE0
    }

}