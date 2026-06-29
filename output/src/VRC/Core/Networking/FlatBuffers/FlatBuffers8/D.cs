// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers8
// Classes: 20
// Methods: 149

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers8
{
    public class DataStorage : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7A765F080
        public void ValidateVersion(){} // RVA: 0x7A80D7310
        public void GetRootAsDataStorage(){} // RVA: 0x7AF3BF190
        public void VerifyDataStorage(){} // RVA: 0x7AF3C00D0
        public void __init(){} // RVA: 0x7A7F12470
        public void __assign(){} // RVA: 0x7A7F12480
        public void EntriesType(){} // RVA: 0x7A7F12810
        public void get_EntriesTypeLength(){} // RVA: 0x7A7F12930
        public void GetEntriesTypeBytes(){} // RVA: 0x7A7F129A0
        public void GetEntriesTypeArray(){} // RVA: 0x7A7F12A10
        public void Entries(){} // RVA: 0x7A8051B10
        public void get_EntriesLength(){} // RVA: 0x7A7F12A20
        public void CreateDataStorage(){} // RVA: 0x7AF3C0450
        public void StartDataStorage(){} // RVA: 0x7AF3C0540
        public void AddEntriesType(){} // RVA: 0x7AF3BF420
        public void CreateEntriesTypeVector(){} // RVA: 0x7AF3BF9B0
        public void CreateEntriesTypeVectorBlock(){} // RVA: 0x7AF3C06C0
        public void StartEntriesTypeVector(){} // RVA: 0x7AF3BFC60
        public void AddEntries(){} // RVA: 0x7AF3C0750
        public void CreateEntriesVector(){} // RVA: 0x7AF3C0790
        public void CreateEntriesVectorBlock(){} // RVA: 0x7AF3C0980
        public void StartEntriesVector(){} // RVA: 0x7AF3BFC60
        public void EndDataStorage(){} // RVA: 0x7AF3C0A10
        public void FinishDataStorageBuffer(){} // RVA: 0x7AF3C0AA0
        public void FinishSizePrefixedDataStorageBuffer(){} // RVA: 0x7AF3C0B00
        public void UnPack(){} // RVA: 0x7A7F12A30
        public void UnPackTo(){} // RVA: 0x7A7F12A40
        public void Pack(){} // RVA: 0x7AF3C1360
    }

    public class DataStorageBool : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7A765F080
        public void __init(){} // RVA: 0x7A7F12470
        public void __assign(){} // RVA: 0x7A7F12480
        public void get_Value(){} // RVA: 0x7A7F124C0
        public void CreateDataStorageBool(){} // RVA: 0x7AF3BEBF0
        public void UnPack(){} // RVA: 0x7A7F124F0
        public void UnPackTo(){} // RVA: 0x7A7F12500
        public void Pack(){} // RVA: 0x7AF3BED70
    }

    public class DataStorageBoolT : Object
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0x7A81A2200
        public void set_Value(){} // RVA: 0x7A81A2210
        public void .ctor(){} // RVA: 0x7A847A460
    }

    public class DataStorageBytes : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7A765F080
        public void ValidateVersion(){} // RVA: 0x7A80D7310
        public void GetRootAsDataStorageBytes(){} // RVA: 0x7AF3BF190
        public void __init(){} // RVA: 0x7A7F12470
        public void __assign(){} // RVA: 0x7A7F12480
        public void Value(){} // RVA: 0x7A7F12810
        public void get_ValueLength(){} // RVA: 0x7A7F12820
        public void GetValueBytes(){} // RVA: 0x7A7F12830
        public void GetValueArray(){} // RVA: 0x7A7F128A0
        public void CreateDataStorageBytes(){} // RVA: 0x7AF3BF8F0
        public void StartDataStorageBytes(){} // RVA: 0x7AF3BF400
        public void AddValue(){} // RVA: 0x7AF3BF420
        public void CreateValueVector(){} // RVA: 0x7AF3BF9B0
        public void CreateValueVectorBlock(){} // RVA: 0x7AF3BFBD0
        public void StartValueVector(){} // RVA: 0x7AF3BFC60
        public void EndDataStorageBytes(){} // RVA: 0x7AF3BFC90
        public void UnPack(){} // RVA: 0x7A7F128F0
        public void UnPackTo(){} // RVA: 0x7A7F12900
        public void Pack(){} // RVA: 0x7AF3BFFE0
    }

    public class DataStorageBytesT : Object
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0x7A80F2570
        public void set_Value(){} // RVA: 0x7A80D8E20
        public void .ctor(){} // RVA: 0x7AD51EC30
    }

    public class DataStorageBytesVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7AF3C0060
    }

    public class DataStorageEntryUnion : Object
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x7A81A2200
        public void set_Type(){} // RVA: 0x7A81A2210
        public void get_Value(){} // RVA: 0x7A80DA7B0
        public void set_Value(){} // RVA: 0x7A813E420
        public void .ctor(){} // RVA: 0x7AF3BE020
        public void As(){} // RVA: 0x7A8051B10
        public void AsDataStorageBool(){} // RVA: 0x7AF3BE080
        public void FromDataStorageBool(){} // RVA: 0x7AF3BE0C0
        public void AsDataStorageInt(){} // RVA: 0x7AF3BE1C0
        public void FromDataStorageInt(){} // RVA: 0x7AF3BE200
        public void AsDataStorageFloat(){} // RVA: 0x7AF3BE300
        public void FromDataStorageFloat(){} // RVA: 0x7AF3BE340
        public void AsDataStorageString(){} // RVA: 0x7AF3BE440
        public void FromDataStorageString(){} // RVA: 0x7AF3BE480
        public void AsDataStorageBytes(){} // RVA: 0x7AF3BE580
        public void FromDataStorageBytes(){} // RVA: 0x7AF3BE5C0
        public void Pack(){} // RVA: 0x7AF3BE6C0
    }

    public class DataStorageEntryVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7AF3BE940
    }

    public class DataStorageFloat : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7A765F080
        public void __init(){} // RVA: 0x7A7F12470
        public void __assign(){} // RVA: 0x7A7F12480
        public void get_Value(){} // RVA: 0x7A7F12600
        public void CreateDataStorageFloat(){} // RVA: 0x7AF3BEF90
        public void UnPack(){} // RVA: 0x7A7F12630
        public void UnPackTo(){} // RVA: 0x7A7F12640
        public void Pack(){} // RVA: 0x7AF3BF110
    }

    public class DataStorageFloatT : Object
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0x7A82023C0
        public void set_Value(){} // RVA: 0x7A82023D0
        public void .ctor(){} // RVA: 0x7A881ACE0
    }

    public class DataStorageInt : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7A765F080
        public void __init(){} // RVA: 0x7A7F12470
        public void __assign(){} // RVA: 0x7A7F12480
        public void get_Value(){} // RVA: 0x7A7F12560
        public void CreateDataStorageInt(){} // RVA: 0x7AF3BEDC0
        public void UnPack(){} // RVA: 0x7A7F12590
        public void UnPackTo(){} // RVA: 0x7A7F125A0
        public void Pack(){} // RVA: 0x7AF3BEF40
    }

    public class DataStorageIntT : Object
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0x7A8124910
        public void set_Value(){} // RVA: 0x7A80DA0C0
        public void .ctor(){} // RVA: 0x7A881ACE0
    }

    public class DataStorageString : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7A765F080
        public void ValidateVersion(){} // RVA: 0x7A80D7310
        public void GetRootAsDataStorageString(){} // RVA: 0x7AF3BF190
        public void __init(){} // RVA: 0x7A7F12470
        public void __assign(){} // RVA: 0x7A7F12480
        public void get_Value(){} // RVA: 0x7A7F126A0
        public void GetValueBytes(){} // RVA: 0x7A7F126B0
        public void GetValueArray(){} // RVA: 0x7A7F12720
        public void CreateDataStorageString(){} // RVA: 0x7AF3BF340
        public void StartDataStorageString(){} // RVA: 0x7AF3BF400
        public void AddValue(){} // RVA: 0x7AF3BF420
        public void EndDataStorageString(){} // RVA: 0x7AF3BF460
        public void UnPack(){} // RVA: 0x7A7F12770
        public void UnPackTo(){} // RVA: 0x7A7F12780
        public void Pack(){} // RVA: 0x7AF3BF670
    }

    public class DataStorageStringT : Object
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0x7A80F2570
        public void set_Value(){} // RVA: 0x7A80D8E20
        public void .ctor(){} // RVA: 0x7AD51EC30
    }

    public class DataStorageStringVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7AF3BF6D0
    }

    public class DataStorageT : Object
    {
        // ── Methods ──
        public void get_Entries(){} // RVA: 0x7A80F2570
        public void set_Entries(){} // RVA: 0x7A80D8E20
        public void .ctor(){} // RVA: 0x7AD51EC30
        public void DeserializeFromBinary(){} // RVA: 0x7AF3C1710
        public void SerializeToBinary(){} // RVA: 0x7AF3C17C0
    }

    public class DataStorageVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7AF3C0060
    }

    public class DestructiblePlayer : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7A765F080
        public void ValidateVersion(){} // RVA: 0x7A80D7310
        public void GetRootAsDestructiblePlayer(){} // RVA: 0x7AF3BF190
        public void VerifyDestructiblePlayer(){} // RVA: 0x7AF3C18C0
        public void __init(){} // RVA: 0x7A7F12470
        public void __assign(){} // RVA: 0x7A7F12480
        public void get_Health(){} // RVA: 0x7A7F12A70
        public void CreateDestructiblePlayer(){} // RVA: 0x7AF3C1A00
        public void StartDestructiblePlayer(){} // RVA: 0x7AF3BF400
        public void AddHealth(){} // RVA: 0x7AF3C1AF0
        public void EndDestructiblePlayer(){} // RVA: 0x7AF3C1B60
        public void FinishDestructiblePlayerBuffer(){} // RVA: 0x7AF3C0AA0
        public void FinishSizePrefixedDestructiblePlayerBuffer(){} // RVA: 0x7AF3C0B00
        public void UnPack(){} // RVA: 0x7A7F12AC0
        public void UnPackTo(){} // RVA: 0x7A7F12AD0
        public void Pack(){} // RVA: 0x7AF3C1CF0
    }

    public class DestructiblePlayerT : Object
    {
        // ── Methods ──
        public void get_Health(){} // RVA: 0x7A82023C0
        public void set_Health(){} // RVA: 0x7A82023D0
        public void .ctor(){} // RVA: 0x7A881ACE0
        public void DeserializeFromBinary(){} // RVA: 0x7AF3C1D10
        public void SerializeToBinary(){} // RVA: 0x7AF3C1E40
    }

    public class DestructiblePlayerVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7AF3C1F40
    }

}