// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Google.Google.FlatBuffers8
// Classes: 21
// Methods: 259

namespace ThirdParty.Google.Google.FlatBuffers8
{
    public class ByteArrayAllocator
    {
        public byte[] _buffer; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x75B6740
        public void GrowFront(){} // RVA: 0x75B67B0
        public void get_Span(){} // RVA: 0x75B6940
        public void get_ReadOnlySpan(){} // RVA: 0x75B69E0
        public void get_Memory(){} // RVA: 0x75B6A80
        public void get_ReadOnlyMemory(){} // RVA: 0x75B6B70
        public void InitBuffer(){} // RVA: 0x75B6C60
    }

    public class ByteBuffer
    {
        public Google.FlatBuffers8.ByteBufferAllocator _buffer; // 0x10
        public int _pos; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x75B6E00 | overloaded x4
        public void get_Position(){} // RVA: 0x5BED50
        public void set_Position(){} // RVA: 0x6374E0
        public void get_Length(){} // RVA: 0x5C3B260
        public void Reset(){} // RVA: 0xA52E70
        public void Duplicate(){} // RVA: 0x75B6F20
        public void GrowFront(){} // RVA: 0x606CF20
        public void ToArray(){} // RVA: 0x75B6FD0 | overloaded x2
        public void SizeOf(){} // RVA: 0xD870
        public void IsSupportedType(){} // RVA: 0xDC10
        public void ArraySize(){} // RVA: 0x283FA0 | overloaded x3
        public void CopyToSizedArray(){} // RVA: 0x75B7030
        public void ToSizedArray(){} // RVA: 0x75B7310
        public void ToFullArray(){} // RVA: 0x75B7370
        public void ToReadOnlyMemory(){} // RVA: 0x75B73D0
        public void ToMemory(){} // RVA: 0x75B7530
        public void ToSpan(){} // RVA: 0x75B7680
        public void ReverseBytes(){} // RVA: 0x75B7760 | overloaded x3
        public void WriteLittleEndian(){} // RVA: 0x75B7770
        public void ReadLittleEndian(){} // RVA: 0x75B7830
        public void AssertOffsetAndLength(){} // RVA: 0x75B78F0
        public void PutSbyte(){} // RVA: 0x75B7B80 | overloaded x2
        public void PutByte(){} // RVA: 0x75B7C00 | overloaded x2
        public void Put(){} // RVA: 0x283FA0 | overloaded x5
        public void PutStringUTF8(){} // RVA: 0x75B7D10
        public void PutShort(){} // RVA: 0x75B7DF0
        public void PutUshort(){} // RVA: 0x75B7E00
        public void PutInt(){} // RVA: 0x75B7F00
        public void PutUint(){} // RVA: 0x75B7F10
        public void PutLong(){} // RVA: 0x75B8010
        public void PutUlong(){} // RVA: 0x75B8020
        public void PutFloat(){} // RVA: 0x75B8120
        public void PutDouble(){} // RVA: 0x75B81C0
        public void GetSbyte(){} // RVA: 0x75B8260
        public void Get(){} // RVA: 0x75B8260
        public void GetStringUTF8(){} // RVA: 0x75B82D0
        public void GetShort(){} // RVA: 0x75B8490
        public void GetUshort(){} // RVA: 0x75B84A0
        public void GetInt(){} // RVA: 0x75B8590
        public void GetUint(){} // RVA: 0x75B85A0
        public void GetLong(){} // RVA: 0x75B86D0
        public void GetUlong(){} // RVA: 0x75B86E0
        public void GetFloat(){} // RVA: 0x75B87D0
        public void GetDouble(){} // RVA: 0x75B8860
        public void .cctor(){} // RVA: 0x75B88F0
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
        public void GetSizePrefix(){} // RVA: 0x75B90D0
        public void RemoveSizePrefix(){} // RVA: 0x75B9100
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class FlatBufferBuilder
    {
        public int _space; // 0x10
        public Google.FlatBuffers8.ByteBuffer _bb; // 0x18
        public int _minAlign; // 0x20
        public int[] _vtable; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x75B9430 | overloaded x2
        public void Clear(){} // RVA: 0x75B95D0
        public void get_ForceDefaults(){} // RVA: 0x59FF30
        public void set_ForceDefaults(){} // RVA: 0xC5F680
        public void get_Offset(){} // RVA: 0x75B96F0
        public void get_Waste(){} // RVA: 0x37E0C0
        public void Pad(){} // RVA: 0x75B9720
        public void GrowBuffer(){} // RVA: 0x75B9830
        public void Prep(){} // RVA: 0x75B9870
        public void PutBool(){} // RVA: 0x75B9A30
        public void PutSbyte(){} // RVA: 0x75B9A60
        public void PutByte(){} // RVA: 0x75B9A60
        public void PutShort(){} // RVA: 0x75B9A90
        public void PutUshort(){} // RVA: 0x75B9A90
        public void PutInt(){} // RVA: 0x75B9AC0
        public void PutUint(){} // RVA: 0x75B9AC0
        public void PutLong(){} // RVA: 0x75B9AF0
        public void PutUlong(){} // RVA: 0x75B9AF0
        public void PutFloat(){} // RVA: 0x75B9B20
        public void Put(){} // RVA: 0x283FA0 | overloaded x4
        public void PutDouble(){} // RVA: 0x75B9BE0
        public void AddBool(){} // RVA: 0x75BA610 | overloaded x3
        public void AddSbyte(){} // RVA: 0x75BA740 | overloaded x3
        public void AddByte(){} // RVA: 0x75BA7F0 | overloaded x4
        public void AddShort(){} // RVA: 0x75BA920 | overloaded x3
        public void AddUshort(){} // RVA: 0x75BAA50 | overloaded x3
        public void AddInt(){} // RVA: 0x75BAB80 | overloaded x3
        public void AddUint(){} // RVA: 0x75BAC30 | overloaded x3
        public void AddLong(){} // RVA: 0x75BAD60 | overloaded x3
        public void AddUlong(){} // RVA: 0x75BAE10 | overloaded x3
        public void AddFloat(){} // RVA: 0x75BAF30 | overloaded x3
        public void Add(){} // RVA: 0x283FA0 | overloaded x4
        public void AddDouble(){} // RVA: 0x75BB030 | overloaded x3
        public void AddOffset(){} // RVA: 0x75BB0C0 | overloaded x2
        public void StartVector(){} // RVA: 0x75BA040
        public void EndVector(){} // RVA: 0x75BA190
        public void CreateVectorOfTables(){} // RVA: 0x283FA0
        public void Nested(){} // RVA: 0x75BA2C0
        public void NotNested(){} // RVA: 0x75BA340
        public void StartTable(){} // RVA: 0x75BA3B0
        public void Slot(){} // RVA: 0x75BA4E0
        public void CreateString(){} // RVA: 0x75BB100
        public void CreateUTF8String(){} // RVA: 0x75BB2B0
        public void CreateSharedString(){} // RVA: 0x75BB3E0
        public void AddStruct(){} // RVA: 0x75BB670
        public void EndTable(){} // RVA: 0x75BB700
        public void Required(){} // RVA: 0x75BBD10
        public void Finish(){} // RVA: 0x75BC190 | overloaded x4
        public void FinishSizePrefixed(){} // RVA: 0x75BC1B0 | overloaded x2
        public void get_DataBuffer(){} // RVA: 0x2E07C0
        public void SizedByteArray(){} // RVA: 0x75BBF80
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
        public int DEFAULT_MAX_DEPTH;
        public int DEFAULT_MAX_TABLES;
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
        public void .ctor(){} // RVA: 0x75BE3B0
    }

    public class Struct
    {
        public int <bb_pos>k__BackingField; // 0x10
        public Google.FlatBuffers8.ByteBuffer <bb>k__BackingField; // 0x18

        // ── Methods ──
        public void get_bb_pos(){} // RVA: 0x19689B0
        public void set_bb_pos(){} // RVA: 0x833580
        public void get_bb(){} // RVA: 0x19689C0
        public void set_bb(){} // RVA: 0x1968950
        public void .ctor(){} // RVA: 0x75BE470
    }

    public class Table
    {
        public int <bb_pos>k__BackingField; // 0x10
        public Google.FlatBuffers8.ByteBuffer <bb>k__BackingField; // 0x18

        // ── Methods ──
        public void get_bb_pos(){} // RVA: 0x19689B0
        public void set_bb_pos(){} // RVA: 0x833580
        public void get_bb(){} // RVA: 0x19689C0
        public void set_bb(){} // RVA: 0x1968950
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void .ctor(){} // RVA: 0x75BE470
        public void __offset(){} // RVA: 0x75BE570 | overloaded x2
        public void __indirect(){} // RVA: 0x75BE610 | overloaded x2
        public void __string(){} // RVA: 0x75BE640
        public void __vector_len(){} // RVA: 0x75BE6C0
        public void __vector(){} // RVA: 0x75BE710
        public void __vector_as_span(){} // RVA: 0x283FA0
        public void __vector_as_array(){} // RVA: 0x1BCC0
        public void __union(){} // RVA: 0x283FA0
        public void __has_identifier(){} // RVA: 0x75BE740
        public void CompareStrings(){} // RVA: 0x75BE9A0 | overloaded x2
    }

    public class VectorOffset
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x75BE410
    }

    public class Verifier
    {
        public Google.FlatBuffers8.ByteBuffer Span; // 0x10
        public Google.FlatBuffers8.Options ReadOnlySpan; // 0x18
        public int Memory; // 0x20
        public int ReadOnlyMemory; // 0x24

        // ── Methods ──
        public void .ctor(){} // RVA: 0x75BC580 | overloaded x2
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
        public void BufferHasIdentifier(){} // RVA: 0x75BC720
        public void ReadUOffsetT(){} // RVA: 0x75BC8F0
        public void ReadSOffsetT(){} // RVA: 0x75BC9A0
        public void ReadVOffsetT(){} // RVA: 0x75BC9D0
        public void GetVRelOffset(){} // RVA: 0x75BCA00
        public void GetVOffset(){} // RVA: 0x75BCB60
        public void CheckComplexity(){} // RVA: 0x75BCC90
        public void CheckAlignment(){} // RVA: 0x75BCCD0
        public void CheckElement(){} // RVA: 0x75BCD00
        public void CheckScalar(){} // RVA: 0x75BCE40
        public void CheckOffset(){} // RVA: 0x75BCE80
        public void CheckVectorOrString(){} // RVA: 0x75BCEC0
        public void CheckString(){} // RVA: 0x75BD000
        public void CheckVector(){} // RVA: 0x75BD130
        public void CheckTable(){} // RVA: 0x75BD140
        public void CheckStringFunc(){} // RVA: 0x75BD170
        public void CheckVectorOfObjects(){} // RVA: 0x75BD1A0
        public void CheckIndirectOffset(){} // RVA: 0x75BD2D0
        public void CheckBufferFromStart(){} // RVA: 0x75BD360
        public void GetIndirectOffset(){} // RVA: 0x75BD600
        public void VerifyTableStart(){} // RVA: 0x75BD6B0
        public void VerifyTableEnd(){} // RVA: 0x75BD8C0
        public void VerifyField(){} // RVA: 0x75BD8D0
        public void VerifyString(){} // RVA: 0x75BD950
        public void VerifyVectorOfData(){} // RVA: 0x75BD9E0
        public void VerifyVectorOfStrings(){} // RVA: 0x75BDA70
        public void VerifyVectorOfTables(){} // RVA: 0x75BDB50
        public void VerifyTable(){} // RVA: 0x75BDBE0
        public void VerifyNestedBuffer(){} // RVA: 0x75BDC80
        public void VerifyUnionData(){} // RVA: 0x75BDE70
        public void VerifyUnionString(){} // RVA: 0x75BDEB0
        public void VerifyUnion(){} // RVA: 0x75BDEC0
        public void VerifyVectorOfUnion(){} // RVA: 0x75BE030
        public void VerifyBuffer(){} // RVA: 0x75BE2E0
    }

    public class VerifyTableAction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x33AE0A0
        public void Invoke(){} // RVA: 0x439370
        public void BeginInvoke(){} // RVA: 0x75BC210
        public void EndInvoke(){} // RVA: 0x1B3C940
    }

    public class VerifyUnionAction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x75BC2A0
        public void Invoke(){} // RVA: 0x4394E0
        public void BeginInvoke(){} // RVA: 0x75BC420
        public void EndInvoke(){} // RVA: 0x1B3C940
    }

    public class checkElementStruct
    {
    }

}