// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers32
// Classes: 17
// Methods: 136

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers32
{
    public class DataStorage
    {
        public Google.FlatBuffers32.Table __p; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void ValidateVersion(){} // RVA: 0x2DD310
        public void GetRootAsDataStorage(){} // RVA: 0x7607450 | overloaded x2
        public void VerifyDataStorage(){} // RVA: 0x7610160
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void EntriesType(){} // RVA: 0x760F670
        public void get_EntriesTypeLength(){} // RVA: 0x760F6F0
        public void GetEntriesTypeBytes(){} // RVA: 0x7610250
        public void GetEntriesTypeArray(){} // RVA: 0x76102C0
        public void Entries(){} // RVA: 0x283FA0
        public void get_EntriesLength(){} // RVA: 0x76103F0
        public void CreateDataStorage(){} // RVA: 0x7610460
        public void StartDataStorage(){} // RVA: 0x7610510
        public void AddEntriesType(){} // RVA: 0x760F330
        public void CreateEntriesTypeVector(){} // RVA: 0x760F8A0
        public void CreateEntriesTypeVectorBlock(){} // RVA: 0x76106E0 | overloaded x3
        public void StartEntriesTypeVector(){} // RVA: 0x760FBF0
        public void AddEntries(){} // RVA: 0x76107A0
        public void CreateEntriesVector(){} // RVA: 0x7607E30
        public void CreateEntriesVectorBlock(){} // RVA: 0x7610980 | overloaded x3
        public void StartEntriesVector(){} // RVA: 0x76081F0
        public void EndDataStorage(){} // RVA: 0x7610A40
        public void FinishDataStorageBuffer(){} // RVA: 0x7610A90
        public void FinishSizePrefixedDataStorageBuffer(){} // RVA: 0x7610AF0
        public void UnPack(){} // RVA: 0x7610B10
        public void UnPackTo(){} // RVA: 0x7610BC0
        public void Pack(){} // RVA: 0x76112F0
    }

    public class DataStorageBool
    {
        public Google.FlatBuffers32.Struct __p; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void get_Value(){} // RVA: 0x760EB00
        public void CreateDataStorageBool(){} // RVA: 0x760EB30
        public void UnPack(){} // RVA: 0x760EBC0
        public void UnPackTo(){} // RVA: 0x760EC30
        public void Pack(){} // RVA: 0x760EC70
    }

    public class DataStorageBoolT
    {
        public bool ByteBuffer; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x3A75E0
        public void set_Value(){} // RVA: 0x3A75F0
        public void .ctor(){} // RVA: 0x6BDA00
    }

    public class DataStorageBytes
    {
        public Google.FlatBuffers32.Table __p; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void ValidateVersion(){} // RVA: 0x2DD310
        public void GetRootAsDataStorageBytes(){} // RVA: 0x7607450 | overloaded x2
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void Value(){} // RVA: 0x760F670
        public void get_ValueLength(){} // RVA: 0x760F6F0
        public void GetValueBytes(){} // RVA: 0x760F760
        public void GetValueArray(){} // RVA: 0x760F7D0
        public void CreateDataStorageBytes(){} // RVA: 0x760F820
        public void StartDataStorageBytes(){} // RVA: 0x760F310
        public void AddValue(){} // RVA: 0x760F330
        public void CreateValueVector(){} // RVA: 0x760F8A0
        public void CreateValueVectorBlock(){} // RVA: 0x760FB30 | overloaded x3
        public void StartValueVector(){} // RVA: 0x760FBF0
        public void EndDataStorageBytes(){} // RVA: 0x760FC20
        public void UnPack(){} // RVA: 0x760FC70
        public void UnPackTo(){} // RVA: 0x760FD20
        public void Pack(){} // RVA: 0x760FF30
    }

    public class DataStorageBytesT
    {
        public System.Collections.Generic.List`1<byte> <Value>k__BackingField; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x2F8380
        public void set_Value(){} // RVA: 0x2DEE30
        public void .ctor(){} // RVA: 0x574FB20
    }

    public class DataStorageBytesVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x76100F0
    }

    public class DataStorageEntryUnion
    {
        public 0x6591BA48 Type; // 0x10
        public object Value; // 0x18

        // ── Methods ──
        public void get_Type(){} // RVA: 0x3A75E0
        public void set_Type(){} // RVA: 0x3A75F0
        public void get_Value(){} // RVA: 0x2E07C0
        public void set_Value(){} // RVA: 0x343E80
        public void .ctor(){} // RVA: 0x75DFAD0
        public void As(){} // RVA: 0x283FA0
        public void AsDataStorageBool(){} // RVA: 0x760DF70
        public void FromDataStorageBool(){} // RVA: 0x760DFB0
        public void AsDataStorageInt(){} // RVA: 0x760E0B0
        public void FromDataStorageInt(){} // RVA: 0x760E0F0
        public void AsDataStorageFloat(){} // RVA: 0x760E1F0
        public void FromDataStorageFloat(){} // RVA: 0x760E230
        public void AsDataStorageString(){} // RVA: 0x760E330
        public void FromDataStorageString(){} // RVA: 0x760E370
        public void AsDataStorageBytes(){} // RVA: 0x760E470
        public void FromDataStorageBytes(){} // RVA: 0x760E4B0
        public void Pack(){} // RVA: 0x760E5B0
    }

    public class DataStorageEntryVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x760E990
    }

    public class DataStorageFloat
    {
        public Google.FlatBuffers32.Struct __p; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void get_Value(){} // RVA: 0x760EF40
        public void CreateDataStorageFloat(){} // RVA: 0x760EF70
        public void UnPack(){} // RVA: 0x760F000
        public void UnPackTo(){} // RVA: 0x760F070
        public void Pack(){} // RVA: 0x760F0B0
    }

    public class DataStorageFloatT
    {
        public float ByteBuffer; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x407320
        public void set_Value(){} // RVA: 0x407330
        public void .ctor(){} // RVA: 0xA5D070
    }

    public class DataStorageInt
    {
        public Google.FlatBuffers32.Struct __p; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void get_Value(){} // RVA: 0x760ED20
        public void CreateDataStorageInt(){} // RVA: 0x760ED50
        public void UnPack(){} // RVA: 0x760EDE0
        public void UnPackTo(){} // RVA: 0x760EE50
        public void Pack(){} // RVA: 0x760EE90
    }

    public class DataStorageIntT
    {
        public int ByteBuffer; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x32A5C0
        public void set_Value(){} // RVA: 0x2E00C0
        public void .ctor(){} // RVA: 0xA5D070
    }

    public class DataStorageString
    {
        public Google.FlatBuffers32.Table __p; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void ValidateVersion(){} // RVA: 0x2DD310
        public void GetRootAsDataStorageString(){} // RVA: 0x7607450 | overloaded x2
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void get_Value(){} // RVA: 0x760F140
        public void GetValueBytes(){} // RVA: 0x760F1D0
        public void GetValueArray(){} // RVA: 0x760F240
        public void CreateDataStorageString(){} // RVA: 0x760F290
        public void StartDataStorageString(){} // RVA: 0x760F310
        public void AddValue(){} // RVA: 0x760F330
        public void EndDataStorageString(){} // RVA: 0x760F370
        public void UnPack(){} // RVA: 0x760F3C0
        public void UnPackTo(){} // RVA: 0x760F4D0
        public void Pack(){} // RVA: 0x760F540
    }

    public class DataStorageStringT
    {
        public string <Value>k__BackingField; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x2F8380
        public void set_Value(){} // RVA: 0x2DEE30
        public void .ctor(){} // RVA: 0x574FB20
    }

    public class DataStorageStringVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x760F600
    }

    public class DataStorageT
    {
        public System.Collections.Generic.List`1<VRC.Core.Networking.FlatBuffers.FlatBuffers32.DataStorageEntryUnion> <Entries>k__BackingField; // 0x10

        // ── Methods ──
        public void get_Entries(){} // RVA: 0x2F8380
        public void set_Entries(){} // RVA: 0x2DEE30
        public void .ctor(){} // RVA: 0x574FB20
        public void DeserializeFromBinary(){} // RVA: 0x76116A0
        public void SerializeToBinary(){} // RVA: 0x7611750
    }

    public class DataStorageVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x76100F0
    }

}