// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers32
// Classes: 17
// Methods: 136

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers32
{
    public class DataStorage
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAF44189C0
        public void ValidateVersion(){} // RVA: 0x7FFAF2D8D310
        public void GetRootAsDataStorage(){} // RVA: 0x7FFAFA0B7450 | overloaded x2
        public void VerifyDataStorage(){} // RVA: 0x7FFAFA0C0160
        public void __init(){} // RVA: 0x7FFAFA090560
        public void __assign(){} // RVA: 0x7FFAFA090630
        public void EntriesType(){} // RVA: 0x7FFAFA0BF670
        public void get_EntriesTypeLength(){} // RVA: 0x7FFAFA0BF6F0
        public void GetEntriesTypeBytes(){} // RVA: 0x7FFAFA0C0250
        public void GetEntriesTypeArray(){} // RVA: 0x7FFAFA0C02C0
        public void Entries(){} // RVA: 0x7FFAF2D33FA0
        public void get_EntriesLength(){} // RVA: 0x7FFAFA0C03F0
        public void CreateDataStorage(){} // RVA: 0x7FFAFA0C0460
        public void StartDataStorage(){} // RVA: 0x7FFAFA0C0510
        public void AddEntriesType(){} // RVA: 0x7FFAFA0BF330
        public void CreateEntriesTypeVector(){} // RVA: 0x7FFAFA0BF8A0
        public void CreateEntriesTypeVectorBlock(){} // RVA: 0x7FFAFA0C06E0 | overloaded x3
        public void StartEntriesTypeVector(){} // RVA: 0x7FFAFA0BFBF0
        public void AddEntries(){} // RVA: 0x7FFAFA0C07A0
        public void CreateEntriesVector(){} // RVA: 0x7FFAFA0B7E30
        public void CreateEntriesVectorBlock(){} // RVA: 0x7FFAFA0C0980 | overloaded x3
        public void StartEntriesVector(){} // RVA: 0x7FFAFA0B81F0
        public void EndDataStorage(){} // RVA: 0x7FFAFA0C0A40
        public void FinishDataStorageBuffer(){} // RVA: 0x7FFAFA0C0A90
        public void FinishSizePrefixedDataStorageBuffer(){} // RVA: 0x7FFAFA0C0AF0
        public void UnPack(){} // RVA: 0x7FFAFA0C0B10
        public void UnPackTo(){} // RVA: 0x7FFAFA0C0BC0
        public void Pack(){} // RVA: 0x7FFAFA0C12F0
    }

    public class DataStorageBool
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAF44189C0
        public void __init(){} // RVA: 0x7FFAFA090560
        public void __assign(){} // RVA: 0x7FFAFA090630
        public void get_Value(){} // RVA: 0x7FFAFA0BEB00
        public void CreateDataStorageBool(){} // RVA: 0x7FFAFA0BEB30
        public void UnPack(){} // RVA: 0x7FFAFA0BEBC0
        public void UnPackTo(){} // RVA: 0x7FFAFA0BEC30
        public void Pack(){} // RVA: 0x7FFAFA0BEC70
    }

    public class DataStorageBoolT
    {
        public object ByteBuffer;

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAF2E575E0
        public void set_Value(){} // RVA: 0x7FFAF2E575F0
        public void .ctor(){} // RVA: 0x7FFAF316DA00
    }

    public class DataStorageBytes
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAF44189C0
        public void ValidateVersion(){} // RVA: 0x7FFAF2D8D310
        public void GetRootAsDataStorageBytes(){} // RVA: 0x7FFAFA0B7450 | overloaded x2
        public void __init(){} // RVA: 0x7FFAFA090560
        public void __assign(){} // RVA: 0x7FFAFA090630
        public void Value(){} // RVA: 0x7FFAFA0BF670
        public void get_ValueLength(){} // RVA: 0x7FFAFA0BF6F0
        public void GetValueBytes(){} // RVA: 0x7FFAFA0BF760
        public void GetValueArray(){} // RVA: 0x7FFAFA0BF7D0
        public void CreateDataStorageBytes(){} // RVA: 0x7FFAFA0BF820
        public void StartDataStorageBytes(){} // RVA: 0x7FFAFA0BF310
        public void AddValue(){} // RVA: 0x7FFAFA0BF330
        public void CreateValueVector(){} // RVA: 0x7FFAFA0BF8A0
        public void CreateValueVectorBlock(){} // RVA: 0x7FFAFA0BFB30 | overloaded x3
        public void StartValueVector(){} // RVA: 0x7FFAFA0BFBF0
        public void EndDataStorageBytes(){} // RVA: 0x7FFAFA0BFC20
        public void UnPack(){} // RVA: 0x7FFAFA0BFC70
        public void UnPackTo(){} // RVA: 0x7FFAFA0BFD20
        public void Pack(){} // RVA: 0x7FFAFA0BFF30
    }

    public class DataStorageBytesT
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAF2DA8380
        public void set_Value(){} // RVA: 0x7FFAF2D8EE30
        public void .ctor(){} // RVA: 0x7FFAF81FFB20
    }

    public class DataStorageBytesVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAFA0C00F0
    }

    public class DataStorageEntryUnion
    {
        public object Type;
        public object Value;

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAF2E575E0
        public void set_Type(){} // RVA: 0x7FFAF2E575F0
        public void get_Value(){} // RVA: 0x7FFAF2D907C0
        public void set_Value(){} // RVA: 0x7FFAF2DF3E80
        public void .ctor(){} // RVA: 0x7FFAFA08FAD0
        public void As(){} // RVA: 0x7FFAF2D33FA0
        public void AsDataStorageBool(){} // RVA: 0x7FFAFA0BDF70
        public void FromDataStorageBool(){} // RVA: 0x7FFAFA0BDFB0
        public void AsDataStorageInt(){} // RVA: 0x7FFAFA0BE0B0
        public void FromDataStorageInt(){} // RVA: 0x7FFAFA0BE0F0
        public void AsDataStorageFloat(){} // RVA: 0x7FFAFA0BE1F0
        public void FromDataStorageFloat(){} // RVA: 0x7FFAFA0BE230
        public void AsDataStorageString(){} // RVA: 0x7FFAFA0BE330
        public void FromDataStorageString(){} // RVA: 0x7FFAFA0BE370
        public void AsDataStorageBytes(){} // RVA: 0x7FFAFA0BE470
        public void FromDataStorageBytes(){} // RVA: 0x7FFAFA0BE4B0
        public void Pack(){} // RVA: 0x7FFAFA0BE5B0
    }

    public class DataStorageEntryVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAFA0BE990
    }

    public class DataStorageFloat
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAF44189C0
        public void __init(){} // RVA: 0x7FFAFA090560
        public void __assign(){} // RVA: 0x7FFAFA090630
        public void get_Value(){} // RVA: 0x7FFAFA0BEF40
        public void CreateDataStorageFloat(){} // RVA: 0x7FFAFA0BEF70
        public void UnPack(){} // RVA: 0x7FFAFA0BF000
        public void UnPackTo(){} // RVA: 0x7FFAFA0BF070
        public void Pack(){} // RVA: 0x7FFAFA0BF0B0
    }

    public class DataStorageFloatT
    {
        public object ByteBuffer;

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAF2EB7320
        public void set_Value(){} // RVA: 0x7FFAF2EB7330
        public void .ctor(){} // RVA: 0x7FFAF350D070
    }

    public class DataStorageInt
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAF44189C0
        public void __init(){} // RVA: 0x7FFAFA090560
        public void __assign(){} // RVA: 0x7FFAFA090630
        public void get_Value(){} // RVA: 0x7FFAFA0BED20
        public void CreateDataStorageInt(){} // RVA: 0x7FFAFA0BED50
        public void UnPack(){} // RVA: 0x7FFAFA0BEDE0
        public void UnPackTo(){} // RVA: 0x7FFAFA0BEE50
        public void Pack(){} // RVA: 0x7FFAFA0BEE90
    }

    public class DataStorageIntT
    {
        public object ByteBuffer;

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAF2DDA5C0
        public void set_Value(){} // RVA: 0x7FFAF2D900C0
        public void .ctor(){} // RVA: 0x7FFAF350D070
    }

    public class DataStorageString
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAF44189C0
        public void ValidateVersion(){} // RVA: 0x7FFAF2D8D310
        public void GetRootAsDataStorageString(){} // RVA: 0x7FFAFA0B7450 | overloaded x2
        public void __init(){} // RVA: 0x7FFAFA090560
        public void __assign(){} // RVA: 0x7FFAFA090630
        public void get_Value(){} // RVA: 0x7FFAFA0BF140
        public void GetValueBytes(){} // RVA: 0x7FFAFA0BF1D0
        public void GetValueArray(){} // RVA: 0x7FFAFA0BF240
        public void CreateDataStorageString(){} // RVA: 0x7FFAFA0BF290
        public void StartDataStorageString(){} // RVA: 0x7FFAFA0BF310
        public void AddValue(){} // RVA: 0x7FFAFA0BF330
        public void EndDataStorageString(){} // RVA: 0x7FFAFA0BF370
        public void UnPack(){} // RVA: 0x7FFAFA0BF3C0
        public void UnPackTo(){} // RVA: 0x7FFAFA0BF4D0
        public void Pack(){} // RVA: 0x7FFAFA0BF540
    }

    public class DataStorageStringT
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAF2DA8380
        public void set_Value(){} // RVA: 0x7FFAF2D8EE30
        public void .ctor(){} // RVA: 0x7FFAF81FFB20
    }

    public class DataStorageStringVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAFA0BF600
    }

    public class DataStorageT
    {
        // ── Methods ──
        public void get_Entries(){} // RVA: 0x7FFAF2DA8380
        public void set_Entries(){} // RVA: 0x7FFAF2D8EE30
        public void .ctor(){} // RVA: 0x7FFAF81FFB20
        public void DeserializeFromBinary(){} // RVA: 0x7FFAFA0C16A0
        public void SerializeToBinary(){} // RVA: 0x7FFAFA0C1750
    }

    public class DataStorageVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAFA0C00F0
    }

}