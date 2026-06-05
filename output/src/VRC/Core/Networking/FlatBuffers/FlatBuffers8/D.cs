// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers8
// Classes: 20
// Methods: 159

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers8
{
    public class DataStorage
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAF44189C0
        public void ValidateVersion(){} // RVA: 0x7FFAF2D8D310
        public void GetRootAsDataStorage(){} // RVA: 0x7FFAFA090C40 | overloaded x2
        public void VerifyDataStorage(){} // RVA: 0x7FFAFA091B70
        public void __init(){} // RVA: 0x7FFAFA090560
        public void __assign(){} // RVA: 0x7FFAFA090630
        public void EntriesType(){} // RVA: 0x7FFAFA0911F0
        public void get_EntriesTypeLength(){} // RVA: 0x7FFAFA091270
        public void GetEntriesTypeBytes(){} // RVA: 0x7FFAFA091C60
        public void GetEntriesTypeArray(){} // RVA: 0x7FFAFA091CD0
        public void Entries(){} // RVA: 0x7FFAF2D33FA0
        public void get_EntriesLength(){} // RVA: 0x7FFAFA091E80
        public void CreateDataStorage(){} // RVA: 0x7FFAFA091EF0
        public void StartDataStorage(){} // RVA: 0x7FFAFA091FE0
        public void AddEntriesType(){} // RVA: 0x7FFAFA090ED0
        public void CreateEntriesTypeVector(){} // RVA: 0x7FFAFA091460
        public void CreateEntriesTypeVectorBlock(){} // RVA: 0x7FFAFA092160 | overloaded x3
        public void StartEntriesTypeVector(){} // RVA: 0x7FFAFA091700
        public void AddEntries(){} // RVA: 0x7FFAFA0921F0
        public void CreateEntriesVector(){} // RVA: 0x7FFAFA092230
        public void CreateEntriesVectorBlock(){} // RVA: 0x7FFAFA092410 | overloaded x3
        public void StartEntriesVector(){} // RVA: 0x7FFAFA091700
        public void EndDataStorage(){} // RVA: 0x7FFAFA0924A0
        public void FinishDataStorageBuffer(){} // RVA: 0x7FFAFA092530
        public void FinishSizePrefixedDataStorageBuffer(){} // RVA: 0x7FFAFA092590
        public void UnPack(){} // RVA: 0x7FFAFA092610
        public void UnPackTo(){} // RVA: 0x7FFAFA0926C0
        public void Pack(){} // RVA: 0x7FFAFA092DF0
    }

    public class DataStorageBool
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAF44189C0
        public void __init(){} // RVA: 0x7FFAFA090560
        public void __assign(){} // RVA: 0x7FFAFA090630
        public void get_Value(){} // RVA: 0x7FFAFA090670
        public void CreateDataStorageBool(){} // RVA: 0x7FFAFA0906A0
        public void UnPack(){} // RVA: 0x7FFAFA090770
        public void UnPackTo(){} // RVA: 0x7FFAFA0907E0
        public void Pack(){} // RVA: 0x7FFAFA090820
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
        public void GetRootAsDataStorageBytes(){} // RVA: 0x7FFAFA090C40 | overloaded x2
        public void __init(){} // RVA: 0x7FFAFA090560
        public void __assign(){} // RVA: 0x7FFAFA090630
        public void Value(){} // RVA: 0x7FFAFA0911F0
        public void get_ValueLength(){} // RVA: 0x7FFAFA091270
        public void GetValueBytes(){} // RVA: 0x7FFAFA0912E0
        public void GetValueArray(){} // RVA: 0x7FFAFA091350
        public void CreateDataStorageBytes(){} // RVA: 0x7FFAFA0913A0
        public void StartDataStorageBytes(){} // RVA: 0x7FFAFA090EB0
        public void AddValue(){} // RVA: 0x7FFAFA090ED0
        public void CreateValueVector(){} // RVA: 0x7FFAFA091460
        public void CreateValueVectorBlock(){} // RVA: 0x7FFAFA091670 | overloaded x3
        public void StartValueVector(){} // RVA: 0x7FFAFA091700
        public void EndDataStorageBytes(){} // RVA: 0x7FFAFA091730
        public void UnPack(){} // RVA: 0x7FFAFA0917C0
        public void UnPackTo(){} // RVA: 0x7FFAFA091870
        public void Pack(){} // RVA: 0x7FFAFA091A80
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
        public void Verify(){} // RVA: 0x7FFAFA091B00
    }

    public class DataStorageEntryUnion
    {
        public object Base;
        public object Delta;

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAF2E575E0
        public void set_Type(){} // RVA: 0x7FFAF2E575F0
        public void get_Value(){} // RVA: 0x7FFAF2D907C0
        public void set_Value(){} // RVA: 0x7FFAF2DF3E80
        public void .ctor(){} // RVA: 0x7FFAFA08FAD0
        public void As(){} // RVA: 0x7FFAF2D33FA0
        public void AsDataStorageBool(){} // RVA: 0x7FFAFA08FB30
        public void FromDataStorageBool(){} // RVA: 0x7FFAFA08FB70
        public void AsDataStorageInt(){} // RVA: 0x7FFAFA08FC70
        public void FromDataStorageInt(){} // RVA: 0x7FFAFA08FCB0
        public void AsDataStorageFloat(){} // RVA: 0x7FFAFA08FDB0
        public void FromDataStorageFloat(){} // RVA: 0x7FFAFA08FDF0
        public void AsDataStorageString(){} // RVA: 0x7FFAFA08FEF0
        public void FromDataStorageString(){} // RVA: 0x7FFAFA08FF30
        public void AsDataStorageBytes(){} // RVA: 0x7FFAFA090030
        public void FromDataStorageBytes(){} // RVA: 0x7FFAFA090070
        public void Pack(){} // RVA: 0x7FFAFA090170
    }

    public class DataStorageEntryVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAFA0903F0
    }

    public class DataStorageFloat
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAF44189C0
        public void __init(){} // RVA: 0x7FFAFA090560
        public void __assign(){} // RVA: 0x7FFAFA090630
        public void get_Value(){} // RVA: 0x7FFAFA090A10
        public void CreateDataStorageFloat(){} // RVA: 0x7FFAFA090A40
        public void UnPack(){} // RVA: 0x7FFAFA090B10
        public void UnPackTo(){} // RVA: 0x7FFAFA090B80
        public void Pack(){} // RVA: 0x7FFAFA090BC0
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
        public void get_Value(){} // RVA: 0x7FFAFA090840
        public void CreateDataStorageInt(){} // RVA: 0x7FFAFA090870
        public void UnPack(){} // RVA: 0x7FFAFA090940
        public void UnPackTo(){} // RVA: 0x7FFAFA0909B0
        public void Pack(){} // RVA: 0x7FFAFA0909F0
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
        public void GetRootAsDataStorageString(){} // RVA: 0x7FFAFA090C40 | overloaded x2
        public void __init(){} // RVA: 0x7FFAFA090560
        public void __assign(){} // RVA: 0x7FFAFA090630
        public void get_Value(){} // RVA: 0x7FFAFA090CA0
        public void GetValueBytes(){} // RVA: 0x7FFAFA090D30
        public void GetValueArray(){} // RVA: 0x7FFAFA090DA0
        public void CreateDataStorageString(){} // RVA: 0x7FFAFA090DF0
        public void StartDataStorageString(){} // RVA: 0x7FFAFA090EB0
        public void AddValue(){} // RVA: 0x7FFAFA090ED0
        public void EndDataStorageString(){} // RVA: 0x7FFAFA090F10
        public void UnPack(){} // RVA: 0x7FFAFA090FA0
        public void UnPackTo(){} // RVA: 0x7FFAFA0910B0
        public void Pack(){} // RVA: 0x7FFAFA091120
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
        public void Verify(){} // RVA: 0x7FFAFA091180
    }

    public class DataStorageT
    {
        // ── Methods ──
        public void get_Entries(){} // RVA: 0x7FFAF2DA8380
        public void set_Entries(){} // RVA: 0x7FFAF2D8EE30
        public void .ctor(){} // RVA: 0x7FFAF81FFB20
        public void DeserializeFromBinary(){} // RVA: 0x7FFAFA093180
        public void SerializeToBinary(){} // RVA: 0x7FFAFA093230
    }

    public class DataStorageVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAFA091B00
    }

    public class DestructiblePlayer
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAF44189C0
        public void ValidateVersion(){} // RVA: 0x7FFAF2D8D310
        public void GetRootAsDestructiblePlayer(){} // RVA: 0x7FFAFA090C40 | overloaded x2
        public void VerifyDestructiblePlayer(){} // RVA: 0x7FFAFA093330
        public void __init(){} // RVA: 0x7FFAFA090560
        public void __assign(){} // RVA: 0x7FFAFA090630
        public void get_Health(){} // RVA: 0x7FFAFA093420
        public void CreateDestructiblePlayer(){} // RVA: 0x7FFAFA093470
        public void StartDestructiblePlayer(){} // RVA: 0x7FFAFA090EB0
        public void AddHealth(){} // RVA: 0x7FFAFA093560
        public void EndDestructiblePlayer(){} // RVA: 0x7FFAFA0935D0
        public void FinishDestructiblePlayerBuffer(){} // RVA: 0x7FFAFA092530
        public void FinishSizePrefixedDestructiblePlayerBuffer(){} // RVA: 0x7FFAFA092590
        public void UnPack(){} // RVA: 0x7FFAFA093660
        public void UnPackTo(){} // RVA: 0x7FFAFA093700
        public void Pack(){} // RVA: 0x7FFAFA093760
    }

    public class DestructiblePlayerT
    {
        // ── Methods ──
        public void get_Health(){} // RVA: 0x7FFAF2EB7320
        public void set_Health(){} // RVA: 0x7FFAF2EB7330
        public void .ctor(){} // RVA: 0x7FFAF350D070
        public void DeserializeFromBinary(){} // RVA: 0x7FFAFA093780
        public void SerializeToBinary(){} // RVA: 0x7FFAFA0938B0
    }

    public class DestructiblePlayerVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAFA0939B0
    }

}