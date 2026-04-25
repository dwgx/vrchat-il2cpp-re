// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Google.Google.FlatBuffers8
// Classes: 11
// Methods: 195

namespace ThirdParty.Google.Google.FlatBuffers8
{
    public class ByteBuffer : Object
    {
        public object Position;
        public object Length;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5516A4A0 | overloaded x4
        public void get_Position(){} // RVA: 0x7FFD4E577800
        public void set_Position(){} // RVA: 0x7FFD4ED4CD10
        public void get_Length(){} // RVA: 0x7FFD537F27B0
        public void Reset(){} // RVA: 0x7FFD4EAB70B0
        public void Duplicate(){} // RVA: 0x7FFD5516A5C0
        public void GrowFront(){} // RVA: 0x7FFD53C245D0
        public void ToArray(){} // RVA: 0x7FFD5516A670 | overloaded x2
        public void SizeOf(){} // RVA: 0x7FFD4E079990
        public void IsSupportedType(){} // RVA: 0x7FFD4E079D30
        public void ArraySize(){} // RVA: 0x7FFD4E2ADC40 | overloaded x3
        public void CopyToSizedArray(){} // RVA: 0x7FFD5516A6D0
        public void ToSizedArray(){} // RVA: 0x7FFD5516A9B0
        public void ToFullArray(){} // RVA: 0x7FFD5516AA10
        public void ToReadOnlyMemory(){} // RVA: 0x7FFD5516AA70
        public void ToMemory(){} // RVA: 0x7FFD5516ABD0
        public void ToSpan(){} // RVA: 0x7FFD5516AD20
        public void ReverseBytes(){} // RVA: 0x7FFD5516AE00 | overloaded x3
        public void WriteLittleEndian(){} // RVA: 0x7FFD5516AE10
        public void ReadLittleEndian(){} // RVA: 0x7FFD5516AED0
        public void AssertOffsetAndLength(){} // RVA: 0x7FFD5516AF90
        public void PutSbyte(){} // RVA: 0x7FFD5516B220 | overloaded x2
        public void PutByte(){} // RVA: 0x7FFD5516B2A0 | overloaded x2
        public void Put(){} // RVA: 0x7FFD4E2ADC40 | overloaded x5
        public void PutStringUTF8(){} // RVA: 0x7FFD5516B3B0
        public void PutShort(){} // RVA: 0x7FFD5516B490
        public void PutUshort(){} // RVA: 0x7FFD5516B4A0
        public void PutInt(){} // RVA: 0x7FFD5516B5A0
        public void PutUint(){} // RVA: 0x7FFD5516B5B0
        public void PutLong(){} // RVA: 0x7FFD5516B6B0
        public void PutUlong(){} // RVA: 0x7FFD5516B6C0
        public void PutFloat(){} // RVA: 0x7FFD5516B7C0
        public void PutDouble(){} // RVA: 0x7FFD5516B860
        public void GetSbyte(){} // RVA: 0x7FFD5516B900
        public void Get(){} // RVA: 0x7FFD5516B900
        public void GetStringUTF8(){} // RVA: 0x7FFD5516B970
        public void GetShort(){} // RVA: 0x7FFD5516BB30
        public void GetUshort(){} // RVA: 0x7FFD5516BB40
        public void GetInt(){} // RVA: 0x7FFD5516BC30
        public void GetUint(){} // RVA: 0x7FFD5516BC40
        public void GetLong(){} // RVA: 0x7FFD5516BD70
        public void GetUlong(){} // RVA: 0x7FFD5516BD80
        public void GetFloat(){} // RVA: 0x7FFD5516BE70
        public void GetDouble(){} // RVA: 0x7FFD5516BF00
        public void .cctor(){} // RVA: 0x7FFD5516BF90
    }

    public class ByteBufferAllocator : Object
    {
        public object Span;
        public object ReadOnlySpan;
        public object Memory;
        public object ReadOnlyMemory;
        public object Length;

        // ── Methods ──
        public void get_Span(){}
        public void get_ReadOnlySpan(){}
        public void get_Memory(){} // RVA: 0x7FFD4E0788A0
        public void get_ReadOnlyMemory(){} // RVA: 0x7FFD4E0788A0
        public void get_Length(){} // RVA: 0x7FFD4E38E5C0
        public void set_Length(){} // RVA: 0x7FFD4E3440C0
        public void GrowFront(){} // RVA: 0x7FFD4E090ED0
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class ByteBufferUtil : Object
    {
        // ── Methods ──
        public void GetSizePrefix(){} // RVA: 0x7FFD5516C770
        public void RemoveSizePrefix(){} // RVA: 0x7FFD5516C7A0
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class FlatBufferBuilder : Object
    {
        public object ForceDefaults;
        public object Offset;
        public object Waste;
        public object DataBuffer;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5516CAD0 | overloaded x2
        public void Clear(){} // RVA: 0x7FFD5516CC70
        public void get_ForceDefaults(){} // RVA: 0x7FFD4E55F600
        public void set_ForceDefaults(){} // RVA: 0x7FFD4ECB2770
        public void get_Offset(){} // RVA: 0x7FFD5516CD90
        public void get_Waste(){} // RVA: 0x7FFD4E3E20C0
        public void Pad(){} // RVA: 0x7FFD5516CDC0
        public void GrowBuffer(){} // RVA: 0x7FFD5516CED0
        public void Prep(){} // RVA: 0x7FFD5516CF10
        public void PutBool(){} // RVA: 0x7FFD5516D0D0
        public void PutSbyte(){} // RVA: 0x7FFD5516D100
        public void PutByte(){} // RVA: 0x7FFD5516D100
        public void PutShort(){} // RVA: 0x7FFD5516D130
        public void PutUshort(){} // RVA: 0x7FFD5516D130
        public void PutInt(){} // RVA: 0x7FFD5516D160
        public void PutUint(){} // RVA: 0x7FFD5516D160
        public void PutLong(){} // RVA: 0x7FFD5516D190
        public void PutUlong(){} // RVA: 0x7FFD5516D190
        public void PutFloat(){} // RVA: 0x7FFD5516D1C0
        public void Put(){} // RVA: 0x7FFD4E2ADC40 | overloaded x4
        public void PutDouble(){} // RVA: 0x7FFD5516D1F0
        public void AddBool(){} // RVA: 0x7FFD5516DBB0 | overloaded x3
        public void AddSbyte(){} // RVA: 0x7FFD5516DCE0 | overloaded x3
        public void AddByte(){} // RVA: 0x7FFD5516DD90 | overloaded x4
        public void AddShort(){} // RVA: 0x7FFD5516DEC0 | overloaded x3
        public void AddUshort(){} // RVA: 0x7FFD5516DFF0 | overloaded x3
        public void AddInt(){} // RVA: 0x7FFD5516E120 | overloaded x3
        public void AddUint(){} // RVA: 0x7FFD5516E1D0 | overloaded x3
        public void AddLong(){} // RVA: 0x7FFD5516E300 | overloaded x3
        public void AddUlong(){} // RVA: 0x7FFD5516E3B0 | overloaded x3
        public void AddFloat(){} // RVA: 0x7FFD5516E4E0 | overloaded x3
        public void Add(){} // RVA: 0x7FFD4E2ADC40 | overloaded x4
        public void AddDouble(){} // RVA: 0x7FFD5516E610 | overloaded x3
        public void AddOffset(){} // RVA: 0x7FFD5516E6C0 | overloaded x2
        public void StartVector(){} // RVA: 0x7FFD5516D5E0
        public void EndVector(){} // RVA: 0x7FFD5516D730
        public void CreateVectorOfTables(){} // RVA: 0x7FFD4E2ADC40
        public void Nested(){} // RVA: 0x7FFD5516D860
        public void NotNested(){} // RVA: 0x7FFD5516D8E0
        public void StartTable(){} // RVA: 0x7FFD5516D950
        public void Slot(){} // RVA: 0x7FFD5516DA80
        public void CreateString(){} // RVA: 0x7FFD5516E700
        public void CreateUTF8String(){} // RVA: 0x7FFD5516E8B0
        public void CreateSharedString(){} // RVA: 0x7FFD5516E9E0
        public void AddStruct(){} // RVA: 0x7FFD5516EC70
        public void EndTable(){} // RVA: 0x7FFD5516ED00
        public void Required(){} // RVA: 0x7FFD5516F310
        public void Finish(){} // RVA: 0x7FFD5516F790 | overloaded x4
        public void FinishSizePrefixed(){} // RVA: 0x7FFD5516F7B0 | overloaded x2
        public void get_DataBuffer(){} // RVA: 0x7FFD4E3447C0
        public void SizedByteArray(){} // RVA: 0x7FFD5516F580
    }

    public class FlatBufferConstants : Object
    {
        // ── Methods ──
        public void FLATBUFFERS_24_3_7(){} // RVA: 0x7FFD4E341310
    }

    public class IFlatbufferObject
    {
        public object ByteBuffer;

        // ── Methods ──
        public void __init(){} // RVA: 0x7FFD4E092BC0
        public void get_ByteBuffer(){} // RVA: 0x7FFD4E078E90
    }

    public class Offset`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090ED0
    }

    public class Options : Object
    {
        public object maxDepth;
        public object maxTables;
        public object stringEndCheck;
        public object alignmentCheck;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5516F7F0 | overloaded x2
        public void get_maxDepth(){} // RVA: 0x7FFD4E38E5C0
        public void set_maxDepth(){} // RVA: 0x7FFD4E3440C0
        public void get_maxTables(){} // RVA: 0x7FFD4E7F5A20
        public void set_maxTables(){} // RVA: 0x7FFD4E7F4990
        public void get_stringEndCheck(){} // RVA: 0x7FFD4E35C4E0
        public void set_stringEndCheck(){} // RVA: 0x7FFD4E35C4F0
        public void get_alignmentCheck(){} // RVA: 0x7FFD4E648D50
        public void set_alignmentCheck(){} // RVA: 0x7FFD4E935120
    }

    public class Struct : ValueType
    {
        public object bb_pos;
        public object bb;

        // ── Methods ──
        public void get_bb_pos(){} // RVA: 0x7FFD4F840210
        public void set_bb_pos(){} // RVA: 0x7FFD4E78D8B0
        public void get_bb(){} // RVA: 0x7FFD4F840220
        public void set_bb(){} // RVA: 0x7FFD4F840240
        public void .ctor(){} // RVA: 0x7FFD55171A70
    }

    public class Table : ValueType
    {
        public object bb_pos;
        public object bb;
        public object ByteBuffer;

        // ── Methods ──
        public void get_bb_pos(){} // RVA: 0x7FFD4F840210
        public void set_bb_pos(){} // RVA: 0x7FFD4E78D8B0
        public void get_bb(){} // RVA: 0x7FFD4F840220
        public void set_bb(){} // RVA: 0x7FFD4F840240
        public void get_ByteBuffer(){} // RVA: 0x7FFD4F840220
        public void .ctor(){} // RVA: 0x7FFD55171A70
        public void __offset(){} // RVA: 0x7FFD55171B70 | overloaded x2
        public void __indirect(){} // RVA: 0x7FFD55171C10 | overloaded x2
        public void __string(){} // RVA: 0x7FFD55171C40
        public void __vector_len(){} // RVA: 0x7FFD55171CC0
        public void __vector(){} // RVA: 0x7FFD55171D10
        public void __vector_as_span(){} // RVA: 0x7FFD4E2ADC40
        public void __vector_as_array(){} // RVA: 0x7FFD4E087DE0
        public void __union(){} // RVA: 0x7FFD4E2ADC40
        public void __has_identifier(){} // RVA: 0x7FFD55171D40
        public void CompareStrings(){} // RVA: 0x7FFD55171FA0 | overloaded x2
    }

    public class VectorOffset : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD55171A10
    }

}