// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Google.Google.FlatBuffers8
// Classes: 20
// Methods: 212

namespace ThirdParty.Google.Google.FlatBuffers8
{
    public class ByteArrayAllocator : ByteBufferAllocator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF394C50
        public void GrowFront(){} // RVA: 0x7AF394CC0
        public void get_Span(){} // RVA: 0x7AF394E50
        public void get_ReadOnlySpan(){} // RVA: 0x7AF394EF0
        public void get_Memory(){} // RVA: 0x7AF394F90
        public void get_ReadOnlyMemory(){} // RVA: 0x7AF395080
        public void InitBuffer(){} // RVA: 0x7AF395170
    }

    public class ByteBuffer : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF395310
        public void get_Position(){} // RVA: 0x7A83782A0
        public void set_Position(){} // RVA: 0x7A84385B0
        public void get_Length(){} // RVA: 0x7ADA292A0
        public void Reset(){} // RVA: 0x7A8810990
        public void Duplicate(){} // RVA: 0x7AF395430
        public void GrowFront(){} // RVA: 0x7ADE59270
        public void ToArray(){} // RVA: 0x7A7E10B10
        public void SizeOf(){} // RVA: 0x7A7E015C0
        public void IsSupportedType(){} // RVA: 0x7A7E01960
        public void ArraySize(){} // RVA: 0x7A8051B10
        public void CopyToSizedArray(){} // RVA: 0x7AF395540
        public void ToSizedArray(){} // RVA: 0x7AF395820
        public void ToFullArray(){} // RVA: 0x7AF395880
        public void ToReadOnlyMemory(){} // RVA: 0x7AF3958E0
        public void ToMemory(){} // RVA: 0x7AF395A50
        public void ToSpan(){} // RVA: 0x7AF395BB0
        public void ReverseBytes(){} // RVA: 0x7AF395C90
        public void WriteLittleEndian(){} // RVA: 0x7AF395CA0
        public void ReadLittleEndian(){} // RVA: 0x7AF395D60
        public void AssertOffsetAndLength(){} // RVA: 0x7AF395E20
        public void PutSbyte(){} // RVA: 0x7AF3960B0
        public void PutByte(){} // RVA: 0x7AF396130
        public void Put(){} // RVA: 0x7A8051B10
        public void PutStringUTF8(){} // RVA: 0x7AF396240
        public void PutShort(){} // RVA: 0x7AF396330
        public void PutUshort(){} // RVA: 0x7AF396340
        public void PutInt(){} // RVA: 0x7AF396440
        public void PutUint(){} // RVA: 0x7AF396450
        public void PutLong(){} // RVA: 0x7AF396550
        public void PutUlong(){} // RVA: 0x7AF396560
        public void PutFloat(){} // RVA: 0x7AF396660
        public void PutDouble(){} // RVA: 0x7AF396700
        public void GetSbyte(){} // RVA: 0x7AF3967A0
        public void Get(){} // RVA: 0x7AF3967A0
        public void GetStringUTF8(){} // RVA: 0x7AF396810
        public void GetShort(){} // RVA: 0x7AF3969D0
        public void GetUshort(){} // RVA: 0x7AF3969E0
        public void GetInt(){} // RVA: 0x7AF396AD0
        public void GetUint(){} // RVA: 0x7AF396AE0
        public void GetLong(){} // RVA: 0x7AF396BD0
        public void GetUlong(){} // RVA: 0x7AF396BE0
        public void GetFloat(){} // RVA: 0x7AF396CD0
        public void GetDouble(){} // RVA: 0x7AF396D60
        public void .cctor(){} // RVA: 0x7AF396DF0
    }

    public class ByteBufferAllocator : Object
    {
        // ── Methods ──
        public void get_Span(){} // RVA: 0x7A7E00490
        public void get_ReadOnlySpan(){} // RVA: 0x7A7E00490
        public void get_Memory(){} // RVA: 0x7A7E00490
        public void get_ReadOnlyMemory(){} // RVA: 0x7A7E00490
        public void get_Length(){} // RVA: 0x7A8124910
        public void set_Length(){} // RVA: 0x7A80DA0C0
        public void GrowFront(){} // RVA: 0x7A7E189D0
        public void .ctor(){} // RVA: 0x7A80D7310
        public void <Length>k__BackingField(){} // RVA: 0x7B3FB4328
    }

    public class ByteBufferUtil : Object
    {
        // ── Methods ──
        public void GetSizePrefix(){} // RVA: 0x7AF3975D0
        public void RemoveSizePrefix(){} // RVA: 0x7AF397600
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class FlatBufferBuilder : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF397940
        public void Clear(){} // RVA: 0x7AF397AE0
        public void get_ForceDefaults(){} // RVA: 0x7A8359360
        public void set_ForceDefaults(){} // RVA: 0x7A8A21900
        public void get_Offset(){} // RVA: 0x7AF397C00
        public void get_Waste(){} // RVA: 0x7A8178B70
        public void Pad(){} // RVA: 0x7AF397C30
        public void GrowBuffer(){} // RVA: 0x7AF397D40
        public void Prep(){} // RVA: 0x7AF397D80
        public void PutBool(){} // RVA: 0x7AF397F40
        public void PutSbyte(){} // RVA: 0x7AF397F70
        public void PutByte(){} // RVA: 0x7AF397F70
        public void PutShort(){} // RVA: 0x7AF397FA0
        public void PutUshort(){} // RVA: 0x7AF397FA0
        public void PutInt(){} // RVA: 0x7AF397FD0
        public void PutUint(){} // RVA: 0x7AF397FD0
        public void PutLong(){} // RVA: 0x7AF398000
        public void PutUlong(){} // RVA: 0x7AF398000
        public void PutFloat(){} // RVA: 0x7AF398030
        public void Put(){} // RVA: 0x7A8051B10
        public void PutDouble(){} // RVA: 0x7AF3980F0
        public void AddBool(){} // RVA: 0x7AF398B20
        public void AddSbyte(){} // RVA: 0x7AF398C50
        public void AddByte(){} // RVA: 0x7AF398D00
        public void AddShort(){} // RVA: 0x7AF398E30
        public void AddUshort(){} // RVA: 0x7AF398F60
        public void AddInt(){} // RVA: 0x7AF399090
        public void AddUint(){} // RVA: 0x7AF399140
        public void AddLong(){} // RVA: 0x7AF399270
        public void AddUlong(){} // RVA: 0x7AF399320
        public void AddFloat(){} // RVA: 0x7AF399440
        public void Add(){} // RVA: 0x7A8051B10
        public void AddDouble(){} // RVA: 0x7AF399540
        public void AddOffset(){} // RVA: 0x7AF3995D0
        public void StartVector(){} // RVA: 0x7AF398550
        public void EndVector(){} // RVA: 0x7AF3986A0
        public void CreateVectorOfTables(){} // RVA: 0x7A8051B10
        public void Nested(){} // RVA: 0x7AF3987D0
        public void NotNested(){} // RVA: 0x7AF398850
        public void StartTable(){} // RVA: 0x7AF3988C0
        public void Slot(){} // RVA: 0x7AF3989F0
        public void CreateString(){} // RVA: 0x7AF399610
        public void CreateUTF8String(){} // RVA: 0x7AF3997C0
        public void CreateSharedString(){} // RVA: 0x7AF3998F0
        public void AddStruct(){} // RVA: 0x7AF399B80
        public void EndTable(){} // RVA: 0x7AF399C10
        public void Required(){} // RVA: 0x7AF39A230
        public void Finish(){} // RVA: 0x7AF39A6C0
        public void FinishSizePrefixed(){} // RVA: 0x7AF39A6E0
        public void get_DataBuffer(){} // RVA: 0x7A80DA7B0
        public void SizedByteArray(){} // RVA: 0x7AF39A4A0
    }

    public class FlatBufferConstants : Object
    {
        // ── Methods ──
        public void FLATBUFFERS_24_3_7(){} // RVA: 0x7A80D7310
    }

    public class IFlatbufferObject
    {
        // ── Methods ──
        public void __init(){} // RVA: 0x7A7E19BE0
        public void get_ByteBuffer(){} // RVA: 0x7A7E00680
    }

    public class Offset`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E189D0
    }

    public class Offset`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7A0C9C0
    }

    public class Offset`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7A0C9C0
    }

    public class Offset`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7A0C9C0
    }

    public class Offset`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7A0C9C0
    }

    public class Options : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF39A720
        public void get_maxDepth(){} // RVA: 0x7A8124910
        public void set_maxDepth(){} // RVA: 0x7A80DA0C0
        public void get_maxTables(){} // RVA: 0x7A8668BC0
        public void set_maxTables(){} // RVA: 0x7A8669360
        public void get_stringEndCheck(){} // RVA: 0x7A80F26D0
        public void set_stringEndCheck(){} // RVA: 0x7A80F26E0
        public void get_alignmentCheck(){} // RVA: 0x7A8475E20
        public void set_alignmentCheck(){} // RVA: 0x7A8D0E640
        public void DEFAULT_MAX_DEPTH(){} // RVA: 0x7B3FAD508
    }

    public class StringOffset : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7F10C20
    }

    public class Struct : ValueType
    {
        // ── Methods ──
        public void get_bb_pos(){} // RVA: 0x7A765F070
        public void set_bb_pos(){} // RVA: 0x7A76134D0
        public void get_bb(){} // RVA: 0x7A765F080
        public void set_bb(){} // RVA: 0x7A765F010
        public void .ctor(){} // RVA: 0x7A7F10D00
        public void <bb_pos>k__BackingField(){} // RVA: 0x7B3FB4328
    }

    public class Table : ValueType
    {
        // ── Methods ──
        public void get_bb_pos(){} // RVA: 0x7A765F070
        public void set_bb_pos(){} // RVA: 0x7A76134D0
        public void get_bb(){} // RVA: 0x7A765F080
        public void set_bb(){} // RVA: 0x7A765F010
        public void get_ByteBuffer(){} // RVA: 0x7A765F080
        public void .ctor(){} // RVA: 0x7A7F10D00
        public void __offset(){} // RVA: 0x7AF39CA90
        public void __indirect(){} // RVA: 0x7AF39CB30
        public void __string(){} // RVA: 0x7A7F10D70
        public void __vector_len(){} // RVA: 0x7A7F10D80
        public void __vector(){} // RVA: 0x7A7F10DD0
        public void __vector_as_span(){} // RVA: 0x7A8051B10
        public void __vector_as_array(){} // RVA: 0x7A7E00740
        public void __union(){} // RVA: 0x7A8051B10
        public void __has_identifier(){} // RVA: 0x7AF39CC60
        public void CompareStrings(){} // RVA: 0x7AF39CEC0
    }

    public class VectorOffset : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7F10C80
    }

    public class Verifier : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF39AAA0
        public void get_Buf(){} // RVA: 0x7A80F2570
        public void set_Buf(){} // RVA: 0x7A80D8E20
        public void get_options(){} // RVA: 0x7A80DA7B0
        public void set_options(){} // RVA: 0x7A813E420
        public void get_depth(){} // RVA: 0x7A851DB90
        public void set_depth(){} // RVA: 0x7A8738180
        public void get_numTables(){} // RVA: 0x7A8AB15F0
        public void set_numTables(){} // RVA: 0x7A94794D0
        public void SetMaxDepth(){} // RVA: 0x7AF39ABC0
        public void SetMaxTables(){} // RVA: 0x7AF39ABE0
        public void SetAlignmentCheck(){} // RVA: 0x7AF39AC00
        public void SetStringCheck(){} // RVA: 0x7AF39AC20
        public void BufferHasIdentifier(){} // RVA: 0x7AF39AC40
        public void ReadUOffsetT(){} // RVA: 0x7AF39AE10
        public void ReadSOffsetT(){} // RVA: 0x7AF39AEC0
        public void ReadVOffsetT(){} // RVA: 0x7AF39AEF0
        public void GetVRelOffset(){} // RVA: 0x7AF39AF20
        public void GetVOffset(){} // RVA: 0x7AF39B080
        public void CheckComplexity(){} // RVA: 0x7AF39B1B0
        public void CheckAlignment(){} // RVA: 0x7AF39B1F0
        public void CheckElement(){} // RVA: 0x7AF39B220
        public void CheckScalar(){} // RVA: 0x7AF39B360
        public void CheckOffset(){} // RVA: 0x7AF39B3A0
        public void CheckVectorOrString(){} // RVA: 0x7AF39B3E0
        public void CheckString(){} // RVA: 0x7AF39B520
        public void CheckVector(){} // RVA: 0x7AF39B650
        public void CheckTable(){} // RVA: 0x7AF39B660
        public void CheckStringFunc(){} // RVA: 0x7AF39B690
        public void CheckVectorOfObjects(){} // RVA: 0x7AF39B6C0
        public void CheckIndirectOffset(){} // RVA: 0x7AF39B7F0
        public void CheckBufferFromStart(){} // RVA: 0x7AF39B880
        public void GetIndirectOffset(){} // RVA: 0x7AF39BB20
        public void VerifyTableStart(){} // RVA: 0x7AF39BBD0
        public void VerifyTableEnd(){} // RVA: 0x7AF39BDE0
        public void VerifyField(){} // RVA: 0x7AF39BDF0
        public void VerifyString(){} // RVA: 0x7AF39BE70
        public void VerifyVectorOfData(){} // RVA: 0x7AF39BF00
        public void VerifyVectorOfStrings(){} // RVA: 0x7AF39BF90
        public void VerifyVectorOfTables(){} // RVA: 0x7AF39C070
        public void VerifyTable(){} // RVA: 0x7AF39C100
        public void VerifyNestedBuffer(){} // RVA: 0x7AF39C1A0
        public void VerifyUnionData(){} // RVA: 0x7AF39C390
        public void VerifyUnionString(){} // RVA: 0x7AF39C3D0
        public void VerifyUnion(){} // RVA: 0x7AF39C3E0
        public void VerifyVectorOfUnion(){} // RVA: 0x7AF39C550
        public void VerifyBuffer(){} // RVA: 0x7AF39C800
    }

    public class VerifyTableAction : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AB1A3C80
        public void Invoke(){} // RVA: 0x7A82344F0
        public void BeginInvoke(){} // RVA: 0x7AF39A740
        public void EndInvoke(){} // RVA: 0x7A98D5590
    }

    public class VerifyUnionAction : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF39A7D0
        public void Invoke(){} // RVA: 0x7A8234660
        public void BeginInvoke(){} // RVA: 0x7AF39A940
        public void EndInvoke(){} // RVA: 0x7A98D5590
    }

}