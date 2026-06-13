// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Google.Google.FlatBuffers32
// Classes: 29
// Methods: 262

namespace ThirdParty.Google.Google.FlatBuffers32
{
    public class ByteArrayAllocator
    {
        public byte[] _buffer; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x75B6740
        public void GrowFront(){} // RVA: 0x75BEAC0
        public void get_Span(){} // RVA: 0x75BEC50
        public void get_ReadOnlySpan(){} // RVA: 0x75BECF0
        public void get_Memory(){} // RVA: 0x75BED90
        public void get_ReadOnlyMemory(){} // RVA: 0x75BEE80
        public void InitBuffer(){} // RVA: 0x75B6C60
    }

    public class ByteBuffer
    {
        public Google.FlatBuffers32.ByteBufferAllocator Position; // 0x10
        public int Length; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x75BF0F0 | overloaded x4
        public void get_Position(){} // RVA: 0x5BED50
        public void set_Position(){} // RVA: 0x6374E0
        public void get_Length(){} // RVA: 0x5C3B260
        public void Reset(){} // RVA: 0xA52E70
        public void Duplicate(){} // RVA: 0x75BF210
        public void GrowFront(){} // RVA: 0x606CF20
        public void ToArray(){} // RVA: 0x75BF2C0 | overloaded x2
        public void SizeOf(){} // RVA: 0xD870
        public void IsSupportedType(){} // RVA: 0xDC10
        public void ArraySize(){} // RVA: 0x283FA0 | overloaded x3
        public void CopyToSizedArray(){} // RVA: 0x75BF320
        public void ToSizedArray(){} // RVA: 0x75BF600
        public void ToFullArray(){} // RVA: 0x75BF660
        public void ToReadOnlyMemory(){} // RVA: 0x75BF6C0
        public void ToMemory(){} // RVA: 0x75BF820
        public void ToSpan(){} // RVA: 0x75BF970
        public void ReverseBytes(){} // RVA: 0x75B7760 | overloaded x3
        public void WriteLittleEndian(){} // RVA: 0x75B7770
        public void ReadLittleEndian(){} // RVA: 0x75BFA50
        public void AssertOffsetAndLength(){} // RVA: 0x75BFB70
        public void PutSbyte(){} // RVA: 0x75BFCA0 | overloaded x2
        public void PutByte(){} // RVA: 0x75BFD50 | overloaded x2
        public void Put(){} // RVA: 0x283FA0 | overloaded x5
        public void PutStringUTF8(){} // RVA: 0x75BFEB0
        public void PutShort(){} // RVA: 0x75BFFE0
        public void PutUshort(){} // RVA: 0x75BFFF0
        public void PutInt(){} // RVA: 0x75C0130
        public void PutUint(){} // RVA: 0x75C0140
        public void PutLong(){} // RVA: 0x75C0280
        public void PutUlong(){} // RVA: 0x75C0290
        public void PutFloat(){} // RVA: 0x75C03D0
        public void PutDouble(){} // RVA: 0x75C04B0
        public void GetSbyte(){} // RVA: 0x75C0590
        public void Get(){} // RVA: 0x75C0590
        public void GetStringUTF8(){} // RVA: 0x75C0630
        public void GetShort(){} // RVA: 0x75C07F0
        public void GetUshort(){} // RVA: 0x75C0800
        public void GetInt(){} // RVA: 0x75C0930
        public void GetUint(){} // RVA: 0x75C0940
        public void GetLong(){} // RVA: 0x75C0AB0
        public void GetUlong(){} // RVA: 0x75C0AC0
        public void GetFloat(){} // RVA: 0x75C0BF0
        public void GetDouble(){} // RVA: 0x75C0CC0
        public void .cctor(){} // RVA: 0x75C0D90
    }

    public class ByteBufferAllocator
    {
        public int <Length>k__BackingField; // 0x10

        // ── Methods ──
        public void get_Span(){}
        public void get_ReadOnlySpan(){}
        public void get_Memory(){} // RVA: 0xC770
        public void get_ReadOnlyMemory(){} // RVA: 0xC770
        public void get_Length(){} // RVA: 0x32A5C0
        public void set_Length(){} // RVA: 0x2E00C0
        public void GrowFront(){} // RVA: 0x24FA0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ByteBufferUtil
    {
        // ── Methods ──
        public void GetSizePrefix(){} // RVA: 0x75C1570
        public void RemoveSizePrefix(){} // RVA: 0x75C1590
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class FlatBufferBuilder
    {
        public int _space; // 0x10
        public Google.FlatBuffers32.ByteBuffer _bb; // 0x18
        public int _minAlign; // 0x20
        public int[] _vtable; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x75C18C0 | overloaded x2
        public void Clear(){} // RVA: 0x75C1A60
        public void get_ForceDefaults(){} // RVA: 0x59FF30
        public void set_ForceDefaults(){} // RVA: 0xC5F680
        public void get_Offset(){} // RVA: 0x75B96F0
        public void get_Waste(){} // RVA: 0x37E0C0
        public void Pad(){} // RVA: 0x75C1B80
        public void GrowBuffer(){} // RVA: 0x75B9830
        public void Prep(){} // RVA: 0x75C1CD0
        public void PutBool(){} // RVA: 0x75C1DA0
        public void PutSbyte(){} // RVA: 0x75C1DD0
        public void PutByte(){} // RVA: 0x75C1DD0
        public void PutShort(){} // RVA: 0x75C1E00
        public void PutUshort(){} // RVA: 0x75C1E00
        public void PutInt(){} // RVA: 0x75C1E30
        public void PutUint(){} // RVA: 0x75C1E30
        public void PutLong(){} // RVA: 0x75C1E60
        public void PutUlong(){} // RVA: 0x75C1E60
        public void PutFloat(){} // RVA: 0x75C1E90
        public void Put(){} // RVA: 0x283FA0 | overloaded x4
        public void PutDouble(){} // RVA: 0x75C1F80
        public void AddBool(){} // RVA: 0x75C27A0 | overloaded x3
        public void AddSbyte(){} // RVA: 0x75C28D0 | overloaded x3
        public void AddByte(){} // RVA: 0x75C2980 | overloaded x3
        public void AddShort(){} // RVA: 0x75C2AB0 | overloaded x3
        public void AddUshort(){} // RVA: 0x75C2BE0 | overloaded x3
        public void AddInt(){} // RVA: 0x75C2D10 | overloaded x3
        public void AddUint(){} // RVA: 0x75C2DC0 | overloaded x3
        public void AddLong(){} // RVA: 0x75C2EF0 | overloaded x3
        public void AddUlong(){} // RVA: 0x75C2FA0 | overloaded x3
        public void AddFloat(){} // RVA: 0x75C30C0 | overloaded x3
        public void Add(){} // RVA: 0x283FA0 | overloaded x4
        public void AddDouble(){} // RVA: 0x75C31C0 | overloaded x3
        public void AddOffset(){} // RVA: 0x75C3250 | overloaded x2
        public void StartVector(){} // RVA: 0x75C2350
        public void EndVector(){} // RVA: 0x75C2400
        public void CreateVectorOfTables(){} // RVA: 0x283FA0
        public void Nested(){} // RVA: 0x75C2450
        public void NotNested(){} // RVA: 0x75C24D0
        public void StartTable(){} // RVA: 0x75C2540
        public void Slot(){} // RVA: 0x75C2670
        public void CreateString(){} // RVA: 0x75C3290
        public void CreateUTF8String(){} // RVA: 0x75C34B0
        public void CreateSharedString(){} // RVA: 0x75C3610
        public void AddStruct(){} // RVA: 0x75C38A0
        public void EndTable(){} // RVA: 0x75C3930
        public void Required(){} // RVA: 0x75C3EA0
        public void Finish(){} // RVA: 0x75C43A0 | overloaded x4
        public void FinishSizePrefixed(){} // RVA: 0x75C43C0 | overloaded x2
        public void get_DataBuffer(){} // RVA: 0x2E07C0
        public void SizedByteArray(){} // RVA: 0x75C4160
    }

    public class FlatBufferConstants
    {
        // ── Methods ──
        public void FLATBUFFERS_24_3_7(){} // RVA: 0x2DD310
    }

    public class IFlatbufferObject
    {
        // ── Methods ──
        public void __init(){} // RVA: 0x26C40
        public void get_ByteBuffer(){} // RVA: 0xCD60
    }

    public class Offset`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x24FA0
    }

    public class Offset`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x833580
    }

    public class Offset`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x833580
    }

    public class Offset`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x833580
    }

    public class Offset`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x833580
    }

    public class Offset`1
    {
    }

    public class Offset`1
    {
    }

    public class Offset`1
    {
    }

    public class Offset`1
    {
    }

    public class Offset`1
    {
    }

    public class Offset`1
    {
    }

    public class Offset`1
    {
    }

    public class Offset`1
    {
    }

    public class Options
    {
        public int bb_pos;
        public int bb;
        public int max_depth; // 0x10
        public int max_tables; // 0x14

        // ── Methods ──
        public void .ctor(){} // RVA: 0x75BC1F0 | overloaded x2
        public void get_maxDepth(){} // RVA: 0x32A5C0
        public void set_maxDepth(){} // RVA: 0x2E00C0
        public void get_maxTables(){} // RVA: 0x8ABED0
        public void set_maxTables(){} // RVA: 0x8AC660
        public void get_stringEndCheck(){} // RVA: 0x2F84E0
        public void set_stringEndCheck(){} // RVA: 0x2F84F0
        public void get_alignmentCheck(){} // RVA: 0x6B93D0
        public void set_alignmentCheck(){} // RVA: 0xF43D70
    }

    public class StringOffset
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x833580
    }

    public class Struct
    {
        public int _bb_pos; // 0x10
        public Google.FlatBuffers32.ByteBuffer <bb>k__BackingField; // 0x18

        // ── Methods ──
        public void get_bb_pos(){} // RVA: 0x19689B0
        public void set_bb_pos(){} // RVA: 0x833580
        public void get_bb(){} // RVA: 0x19689C0
        public void set_bb(){} // RVA: 0x1968950
        public void .ctor(){} // RVA: 0x75BE470
    }

    public class Table
    {
        public int bb_pos; // 0x10
        public Google.FlatBuffers32.ByteBuffer bb; // 0x18

        // ── Methods ──
        public void get_bb_pos(){} // RVA: 0x19689B0
        public void set_bb_pos(){} // RVA: 0x833580
        public void get_bb(){} // RVA: 0x19689C0
        public void set_bb(){} // RVA: 0x1968950
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void .ctor(){} // RVA: 0x75BE470
        public void __offset(){} // RVA: 0x75C62A0 | overloaded x2
        public void __indirect(){} // RVA: 0x75C6330 | overloaded x2
        public void __string(){} // RVA: 0x75C6360
        public void __vector_len(){} // RVA: 0x75C63D0
        public void __vector(){} // RVA: 0x75C6420
        public void __vector_as_span(){} // RVA: 0x283FA0
        public void __vector_as_array(){} // RVA: 0x1BCC0
        public void __union(){} // RVA: 0x283FA0
        public void __has_identifier(){} // RVA: 0x75C6450
        public void CompareStrings(){} // RVA: 0x75C66B0 | overloaded x2
    }

    public class VectorOffset
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x833580
    }

    public class Verifier
    {
        public Google.FlatBuffers32.ByteBuffer verifier_buffer; // 0x10
        public Google.FlatBuffers32.Options verifier_options; // 0x18
        public int depth_cnt; // 0x20
        public int num_tables_cnt; // 0x24

        // ── Methods ──
        public void .ctor(){} // RVA: 0x75C4520 | overloaded x2
        public void get_Buf(){} // RVA: 0x2F8380
        public void set_Buf(){} // RVA: 0x2DEE30
        public void get_options(){} // RVA: 0x2E07C0
        public void set_options(){} // RVA: 0x343E80
        public void get_depth(){} // RVA: 0x760030
        public void set_depth(){} // RVA: 0x99E0D0
        public void get_numTables(){} // RVA: 0xCEF5B0
        public void set_numTables(){} // RVA: 0x16E1F00
        public void SetMaxDepth(){} // RVA: 0x75BC6A0
        public void SetMaxTables(){} // RVA: 0x75BC6C0
        public void SetAlignmentCheck(){} // RVA: 0x75BC6E0
        public void SetStringCheck(){} // RVA: 0x75BC700
        public void BufferHasIdentifier(){} // RVA: 0x75C4640
        public void ReadUOffsetT(){} // RVA: 0x75C4810
        public void ReadSOffsetT(){} // RVA: 0x75C48C0
        public void ReadVOffsetT(){} // RVA: 0x75C48F0
        public void GetVRelOffset(){} // RVA: 0x75C4920
        public void GetVOffset(){} // RVA: 0x75C4A80
        public void CheckComplexity(){} // RVA: 0x75BCC90
        public void CheckAlignment(){} // RVA: 0x75BCCD0
        public void CheckElement(){} // RVA: 0x75C4BB0
        public void CheckScalar(){} // RVA: 0x75C4CF0
        public void CheckOffset(){} // RVA: 0x75C4D30
        public void CheckVectorOrString(){} // RVA: 0x75C4D70
        public void CheckString(){} // RVA: 0x75C4EB0
        public void CheckVector(){} // RVA: 0x75C4FE0
        public void CheckTable(){} // RVA: 0x75BD140
        public void CheckStringFunc(){} // RVA: 0x75C4FF0
        public void CheckVectorOfObjects(){} // RVA: 0x75C5020
        public void CheckIndirectOffset(){} // RVA: 0x75C5150
        public void CheckBufferFromStart(){} // RVA: 0x75C51E0
        public void GetIndirectOffset(){} // RVA: 0x75C5480
        public void VerifyTableStart(){} // RVA: 0x75C5530
        public void VerifyTableEnd(){} // RVA: 0x75BD8C0
        public void VerifyField(){} // RVA: 0x75C5740
        public void VerifyString(){} // RVA: 0x75C57C0
        public void VerifyVectorOfData(){} // RVA: 0x75C5850
        public void VerifyVectorOfStrings(){} // RVA: 0x75C58E0
        public void VerifyVectorOfTables(){} // RVA: 0x75C59C0
        public void VerifyTable(){} // RVA: 0x75C5A50
        public void VerifyNestedBuffer(){} // RVA: 0x75C5AF0
        public void VerifyUnionData(){} // RVA: 0x75C5CB0
        public void VerifyUnionString(){} // RVA: 0x75C5CF0
        public void VerifyUnion(){} // RVA: 0x75C5D00
        public void VerifyVectorOfUnion(){} // RVA: 0x75C5E70
        public void VerifyBuffer(){} // RVA: 0x75C6120
    }

    public class VerifyTableAction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x33AE0A0
        public void Invoke(){} // RVA: 0x439370
        public void BeginInvoke(){} // RVA: 0x75C43E0
        public void EndInvoke(){} // RVA: 0x1B3C940
    }

    public class VerifyUnionAction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x75BC2A0
        public void Invoke(){} // RVA: 0x4394E0
        public void BeginInvoke(){} // RVA: 0x75C4470
        public void EndInvoke(){} // RVA: 0x1B3C940
    }

    public class checkElementStruct
    {
    }

}