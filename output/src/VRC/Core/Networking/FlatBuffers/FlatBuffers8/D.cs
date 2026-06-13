// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers8
// Classes: 20
// Methods: 159

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers8
{
    public class DataStorage
    {
        public Google.FlatBuffers8.Table __p; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void ValidateVersion(){} // RVA: 0x2DD310
        public void GetRootAsDataStorage(){} // RVA: 0x75E0C40 | overloaded x2
        public void VerifyDataStorage(){} // RVA: 0x75E1B70
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void EntriesType(){} // RVA: 0x75E11F0
        public void get_EntriesTypeLength(){} // RVA: 0x75E1270
        public void GetEntriesTypeBytes(){} // RVA: 0x75E1C60
        public void GetEntriesTypeArray(){} // RVA: 0x75E1CD0
        public void Entries(){} // RVA: 0x283FA0
        public void get_EntriesLength(){} // RVA: 0x75E1E80
        public void CreateDataStorage(){} // RVA: 0x75E1EF0
        public void StartDataStorage(){} // RVA: 0x75E1FE0
        public void AddEntriesType(){} // RVA: 0x75E0ED0
        public void CreateEntriesTypeVector(){} // RVA: 0x75E1460
        public void CreateEntriesTypeVectorBlock(){} // RVA: 0x75E2160 | overloaded x3
        public void StartEntriesTypeVector(){} // RVA: 0x75E1700
        public void AddEntries(){} // RVA: 0x75E21F0
        public void CreateEntriesVector(){} // RVA: 0x75E2230
        public void CreateEntriesVectorBlock(){} // RVA: 0x75E2410 | overloaded x3
        public void StartEntriesVector(){} // RVA: 0x75E1700
        public void EndDataStorage(){} // RVA: 0x75E24A0
        public void FinishDataStorageBuffer(){} // RVA: 0x75E2530
        public void FinishSizePrefixedDataStorageBuffer(){} // RVA: 0x75E2590
        public void UnPack(){} // RVA: 0x75E2610
        public void UnPackTo(){} // RVA: 0x75E26C0
        public void Pack(){} // RVA: 0x75E2DF0
    }

    public class DataStorageBool
    {
        public Google.FlatBuffers8.Struct __p; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void get_Value(){} // RVA: 0x75E0670
        public void CreateDataStorageBool(){} // RVA: 0x75E06A0
        public void UnPack(){} // RVA: 0x75E0770
        public void UnPackTo(){} // RVA: 0x75E07E0
        public void Pack(){} // RVA: 0x75E0820
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
        public Google.FlatBuffers8.Table __p; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void ValidateVersion(){} // RVA: 0x2DD310
        public void GetRootAsDataStorageBytes(){} // RVA: 0x75E0C40 | overloaded x2
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void Value(){} // RVA: 0x75E11F0
        public void get_ValueLength(){} // RVA: 0x75E1270
        public void GetValueBytes(){} // RVA: 0x75E12E0
        public void GetValueArray(){} // RVA: 0x75E1350
        public void CreateDataStorageBytes(){} // RVA: 0x75E13A0
        public void StartDataStorageBytes(){} // RVA: 0x75E0EB0
        public void AddValue(){} // RVA: 0x75E0ED0
        public void CreateValueVector(){} // RVA: 0x75E1460
        public void CreateValueVectorBlock(){} // RVA: 0x75E1670 | overloaded x3
        public void StartValueVector(){} // RVA: 0x75E1700
        public void EndDataStorageBytes(){} // RVA: 0x75E1730
        public void UnPack(){} // RVA: 0x75E17C0
        public void UnPackTo(){} // RVA: 0x75E1870
        public void Pack(){} // RVA: 0x75E1A80
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
        public void Verify(){} // RVA: 0x75E1B00
    }

    public class DataStorageEntryUnion
    {
        public 0x659177F0 Base; // 0x10
        public object Delta; // 0x18

        // ── Methods ──
        public void get_Type(){} // RVA: 0x3A75E0
        public void set_Type(){} // RVA: 0x3A75F0
        public void get_Value(){} // RVA: 0x2E07C0
        public void set_Value(){} // RVA: 0x343E80
        public void .ctor(){} // RVA: 0x75DFAD0
        public void As(){} // RVA: 0x283FA0
        public void AsDataStorageBool(){} // RVA: 0x75DFB30
        public void FromDataStorageBool(){} // RVA: 0x75DFB70
        public void AsDataStorageInt(){} // RVA: 0x75DFC70
        public void FromDataStorageInt(){} // RVA: 0x75DFCB0
        public void AsDataStorageFloat(){} // RVA: 0x75DFDB0
        public void FromDataStorageFloat(){} // RVA: 0x75DFDF0
        public void AsDataStorageString(){} // RVA: 0x75DFEF0
        public void FromDataStorageString(){} // RVA: 0x75DFF30
        public void AsDataStorageBytes(){} // RVA: 0x75E0030
        public void FromDataStorageBytes(){} // RVA: 0x75E0070
        public void Pack(){} // RVA: 0x75E0170
    }

    public class DataStorageEntryVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x75E03F0
    }

    public class DataStorageFloat
    {
        public Google.FlatBuffers8.Struct __p; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void get_Value(){} // RVA: 0x75E0A10
        public void CreateDataStorageFloat(){} // RVA: 0x75E0A40
        public void UnPack(){} // RVA: 0x75E0B10
        public void UnPackTo(){} // RVA: 0x75E0B80
        public void Pack(){} // RVA: 0x75E0BC0
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
        public Google.FlatBuffers8.Struct __p; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void get_Value(){} // RVA: 0x75E0840
        public void CreateDataStorageInt(){} // RVA: 0x75E0870
        public void UnPack(){} // RVA: 0x75E0940
        public void UnPackTo(){} // RVA: 0x75E09B0
        public void Pack(){} // RVA: 0x75E09F0
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
        public Google.FlatBuffers8.Table __p; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void ValidateVersion(){} // RVA: 0x2DD310
        public void GetRootAsDataStorageString(){} // RVA: 0x75E0C40 | overloaded x2
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void get_Value(){} // RVA: 0x75E0CA0
        public void GetValueBytes(){} // RVA: 0x75E0D30
        public void GetValueArray(){} // RVA: 0x75E0DA0
        public void CreateDataStorageString(){} // RVA: 0x75E0DF0
        public void StartDataStorageString(){} // RVA: 0x75E0EB0
        public void AddValue(){} // RVA: 0x75E0ED0
        public void EndDataStorageString(){} // RVA: 0x75E0F10
        public void UnPack(){} // RVA: 0x75E0FA0
        public void UnPackTo(){} // RVA: 0x75E10B0
        public void Pack(){} // RVA: 0x75E1120
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
        public void Verify(){} // RVA: 0x75E1180
    }

    public class DataStorageT
    {
        public System.Collections.Generic.List`1<VRC.Core.Networking.FlatBuffers.FlatBuffers8.DataStorageEntryUnion> <Entries>k__BackingField; // 0x10

        // ── Methods ──
        public void get_Entries(){} // RVA: 0x2F8380
        public void set_Entries(){} // RVA: 0x2DEE30
        public void .ctor(){} // RVA: 0x574FB20
        public void DeserializeFromBinary(){} // RVA: 0x75E3180
        public void SerializeToBinary(){} // RVA: 0x75E3230
    }

    public class DataStorageVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x75E1B00
    }

    public class DestructiblePlayer
    {
        public Google.FlatBuffers8.Table __p; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void ValidateVersion(){} // RVA: 0x2DD310
        public void GetRootAsDestructiblePlayer(){} // RVA: 0x75E0C40 | overloaded x2
        public void VerifyDestructiblePlayer(){} // RVA: 0x75E3330
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void get_Health(){} // RVA: 0x75E3420
        public void CreateDestructiblePlayer(){} // RVA: 0x75E3470
        public void StartDestructiblePlayer(){} // RVA: 0x75E0EB0
        public void AddHealth(){} // RVA: 0x75E3560
        public void EndDestructiblePlayer(){} // RVA: 0x75E35D0
        public void FinishDestructiblePlayerBuffer(){} // RVA: 0x75E2530
        public void FinishSizePrefixedDestructiblePlayerBuffer(){} // RVA: 0x75E2590
        public void UnPack(){} // RVA: 0x75E3660
        public void UnPackTo(){} // RVA: 0x75E3700
        public void Pack(){} // RVA: 0x75E3760
    }

    public class DestructiblePlayerT
    {
        public float <Health>k__BackingField; // 0x10

        // ── Methods ──
        public void get_Health(){} // RVA: 0x407320
        public void set_Health(){} // RVA: 0x407330
        public void .ctor(){} // RVA: 0xA5D070
        public void DeserializeFromBinary(){} // RVA: 0x75E3780
        public void SerializeToBinary(){} // RVA: 0x75E38B0
    }

    public class DestructiblePlayerVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x75E39B0
    }

}