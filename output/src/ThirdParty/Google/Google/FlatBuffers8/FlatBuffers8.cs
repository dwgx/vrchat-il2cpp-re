// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Google.Google.FlatBuffers8
// Classes: 21
// Methods: 259

namespace ThirdParty.Google.Google.FlatBuffers8
{
    public class ByteArrayAllocator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFA066740
        public void GrowFront(){} // RVA: 0x7FFAFA0667B0
        public void get_Span(){} // RVA: 0x7FFAFA066940
        public void get_ReadOnlySpan(){} // RVA: 0x7FFAFA0669E0
        public void get_Memory(){} // RVA: 0x7FFAFA066A80
        public void get_ReadOnlyMemory(){} // RVA: 0x7FFAFA066B70
        public void InitBuffer(){} // RVA: 0x7FFAFA066C60
    }

    public class ByteBuffer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFA066E00 | overloaded x4
        public void get_Position(){} // RVA: 0x7FFAF306ED50
        public void set_Position(){} // RVA: 0x7FFAF30E74E0
        public void get_Length(){} // RVA: 0x7FFAF86EB260
        public void Reset(){} // RVA: 0x7FFAF3502E70
        public void Duplicate(){} // RVA: 0x7FFAFA066F20
        public void GrowFront(){} // RVA: 0x7FFAF8B1CF20
        public void ToArray(){} // RVA: 0x7FFAFA066FD0 | overloaded x2
        public void SizeOf(){} // RVA: 0x7FFAF2ABD870
        public void IsSupportedType(){} // RVA: 0x7FFAF2ABDC10
        public void ArraySize(){} // RVA: 0x7FFAF2D33FA0 | overloaded x3
        public void CopyToSizedArray(){} // RVA: 0x7FFAFA067030
        public void ToSizedArray(){} // RVA: 0x7FFAFA067310
        public void ToFullArray(){} // RVA: 0x7FFAFA067370
        public void ToReadOnlyMemory(){} // RVA: 0x7FFAFA0673D0
        public void ToMemory(){} // RVA: 0x7FFAFA067530
        public void ToSpan(){} // RVA: 0x7FFAFA067680
        public void ReverseBytes(){} // RVA: 0x7FFAFA067760 | overloaded x3
        public void WriteLittleEndian(){} // RVA: 0x7FFAFA067770
        public void ReadLittleEndian(){} // RVA: 0x7FFAFA067830
        public void AssertOffsetAndLength(){} // RVA: 0x7FFAFA0678F0
        public void PutSbyte(){} // RVA: 0x7FFAFA067B80 | overloaded x2
        public void PutByte(){} // RVA: 0x7FFAFA067C00 | overloaded x2
        public void Put(){} // RVA: 0x7FFAF2D33FA0 | overloaded x5
        public void PutStringUTF8(){} // RVA: 0x7FFAFA067D10
        public void PutShort(){} // RVA: 0x7FFAFA067DF0
        public void PutUshort(){} // RVA: 0x7FFAFA067E00
        public void PutInt(){} // RVA: 0x7FFAFA067F00
        public void PutUint(){} // RVA: 0x7FFAFA067F10
        public void PutLong(){} // RVA: 0x7FFAFA068010
        public void PutUlong(){} // RVA: 0x7FFAFA068020
        public void PutFloat(){} // RVA: 0x7FFAFA068120
        public void PutDouble(){} // RVA: 0x7FFAFA0681C0
        public void GetSbyte(){} // RVA: 0x7FFAFA068260
        public void Get(){} // RVA: 0x7FFAFA068260
        public void GetStringUTF8(){} // RVA: 0x7FFAFA0682D0
        public void GetShort(){} // RVA: 0x7FFAFA068490
        public void GetUshort(){} // RVA: 0x7FFAFA0684A0
        public void GetInt(){} // RVA: 0x7FFAFA068590
        public void GetUint(){} // RVA: 0x7FFAFA0685A0
        public void GetLong(){} // RVA: 0x7FFAFA0686D0
        public void GetUlong(){} // RVA: 0x7FFAFA0686E0
        public void GetFloat(){} // RVA: 0x7FFAFA0687D0
        public void GetDouble(){} // RVA: 0x7FFAFA068860
        public void .cctor(){} // RVA: 0x7FFAFA0688F0
    }

    public class ByteBufferAllocator
    {
        // ── Methods ──
        public void get_Span(){}
        public void get_ReadOnlySpan(){}
        public void get_Memory(){} // RVA: 0x7FFAF2ABC770
        public void get_ReadOnlyMemory(){} // RVA: 0x7FFAF2ABC770
        public void get_Length(){} // RVA: 0x7FFAF2DDA5C0
        public void set_Length(){} // RVA: 0x7FFAF2D900C0
        public void GrowFront(){} // RVA: 0x7FFAF2AD4FA0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class ByteBufferUtil
    {
        // ── Methods ──
        public void GetSizePrefix(){} // RVA: 0x7FFAFA0690D0
        public void RemoveSizePrefix(){} // RVA: 0x7FFAFA069100
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class FlatBufferBuilder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFA069430 | overloaded x2
        public void Clear(){} // RVA: 0x7FFAFA0695D0
        public void get_ForceDefaults(){} // RVA: 0x7FFAF304FF30
        public void set_ForceDefaults(){} // RVA: 0x7FFAF370F680
        public void get_Offset(){} // RVA: 0x7FFAFA0696F0
        public void get_Waste(){} // RVA: 0x7FFAF2E2E0C0
        public void Pad(){} // RVA: 0x7FFAFA069720
        public void GrowBuffer(){} // RVA: 0x7FFAFA069830
        public void Prep(){} // RVA: 0x7FFAFA069870
        public void PutBool(){} // RVA: 0x7FFAFA069A30
        public void PutSbyte(){} // RVA: 0x7FFAFA069A60
        public void PutByte(){} // RVA: 0x7FFAFA069A60
        public void PutShort(){} // RVA: 0x7FFAFA069A90
        public void PutUshort(){} // RVA: 0x7FFAFA069A90
        public void PutInt(){} // RVA: 0x7FFAFA069AC0
        public void PutUint(){} // RVA: 0x7FFAFA069AC0
        public void PutLong(){} // RVA: 0x7FFAFA069AF0
        public void PutUlong(){} // RVA: 0x7FFAFA069AF0
        public void PutFloat(){} // RVA: 0x7FFAFA069B20
        public void Put(){} // RVA: 0x7FFAF2D33FA0 | overloaded x4
        public void PutDouble(){} // RVA: 0x7FFAFA069BE0
        public void AddBool(){} // RVA: 0x7FFAFA06A610 | overloaded x3
        public void AddSbyte(){} // RVA: 0x7FFAFA06A740 | overloaded x3
        public void AddByte(){} // RVA: 0x7FFAFA06A7F0 | overloaded x4
        public void AddShort(){} // RVA: 0x7FFAFA06A920 | overloaded x3
        public void AddUshort(){} // RVA: 0x7FFAFA06AA50 | overloaded x3
        public void AddInt(){} // RVA: 0x7FFAFA06AB80 | overloaded x3
        public void AddUint(){} // RVA: 0x7FFAFA06AC30 | overloaded x3
        public void AddLong(){} // RVA: 0x7FFAFA06AD60 | overloaded x3
        public void AddUlong(){} // RVA: 0x7FFAFA06AE10 | overloaded x3
        public void AddFloat(){} // RVA: 0x7FFAFA06AF30 | overloaded x3
        public void Add(){} // RVA: 0x7FFAF2D33FA0 | overloaded x4
        public void AddDouble(){} // RVA: 0x7FFAFA06B030 | overloaded x3
        public void AddOffset(){} // RVA: 0x7FFAFA06B0C0 | overloaded x2
        public void StartVector(){} // RVA: 0x7FFAFA06A040
        public void EndVector(){} // RVA: 0x7FFAFA06A190
        public void CreateVectorOfTables(){} // RVA: 0x7FFAF2D33FA0
        public void Nested(){} // RVA: 0x7FFAFA06A2C0
        public void NotNested(){} // RVA: 0x7FFAFA06A340
        public void StartTable(){} // RVA: 0x7FFAFA06A3B0
        public void Slot(){} // RVA: 0x7FFAFA06A4E0
        public void CreateString(){} // RVA: 0x7FFAFA06B100
        public void CreateUTF8String(){} // RVA: 0x7FFAFA06B2B0
        public void CreateSharedString(){} // RVA: 0x7FFAFA06B3E0
        public void AddStruct(){} // RVA: 0x7FFAFA06B670
        public void EndTable(){} // RVA: 0x7FFAFA06B700
        public void Required(){} // RVA: 0x7FFAFA06BD10
        public void Finish(){} // RVA: 0x7FFAFA06C190 | overloaded x4
        public void FinishSizePrefixed(){} // RVA: 0x7FFAFA06C1B0 | overloaded x2
        public void get_DataBuffer(){} // RVA: 0x7FFAF2D907C0
        public void SizedByteArray(){} // RVA: 0x7FFAFA06BF80
    }

    public class FlatBufferConstants
    {
        // ── Methods ──
        public void FLATBUFFERS_24_3_7(){} // RVA: 0x7FFAF2D8D310
    }

    public class IFlatbufferObject
    {
        // ── Methods ──
        public void __init(){} // RVA: 0x7FFAF2AD6C40
        public void get_ByteBuffer(){} // RVA: 0x7FFAF2ABCD60
    }

    public class Offset`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2AD4FA0
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
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFA06C1F0 | overloaded x2
        public void get_maxDepth(){} // RVA: 0x7FFAF2DDA5C0
        public void set_maxDepth(){} // RVA: 0x7FFAF2D900C0
        public void get_maxTables(){} // RVA: 0x7FFAF335BED0
        public void set_maxTables(){} // RVA: 0x7FFAF335C660
        public void get_stringEndCheck(){} // RVA: 0x7FFAF2DA84E0
        public void set_stringEndCheck(){} // RVA: 0x7FFAF2DA84F0
        public void get_alignmentCheck(){} // RVA: 0x7FFAF31693D0
        public void set_alignmentCheck(){} // RVA: 0x7FFAF39F3D70
    }

    public class StringOffset
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFA06E3B0
    }

    public class Struct
    {
        // ── Methods ──
        public void get_bb_pos(){} // RVA: 0x7FFAF44189B0
        public void set_bb_pos(){} // RVA: 0x7FFAF32E3580
        public void get_bb(){} // RVA: 0x7FFAF44189C0
        public void set_bb(){} // RVA: 0x7FFAF4418950
        public void .ctor(){} // RVA: 0x7FFAFA06E470
    }

    public class Table
    {
        // ── Methods ──
        public void get_bb_pos(){} // RVA: 0x7FFAF44189B0
        public void set_bb_pos(){} // RVA: 0x7FFAF32E3580
        public void get_bb(){} // RVA: 0x7FFAF44189C0
        public void set_bb(){} // RVA: 0x7FFAF4418950
        public void get_ByteBuffer(){} // RVA: 0x7FFAF44189C0
        public void .ctor(){} // RVA: 0x7FFAFA06E470
        public void __offset(){} // RVA: 0x7FFAFA06E570 | overloaded x2
        public void __indirect(){} // RVA: 0x7FFAFA06E610 | overloaded x2
        public void __string(){} // RVA: 0x7FFAFA06E640
        public void __vector_len(){} // RVA: 0x7FFAFA06E6C0
        public void __vector(){} // RVA: 0x7FFAFA06E710
        public void __vector_as_span(){} // RVA: 0x7FFAF2D33FA0
        public void __vector_as_array(){} // RVA: 0x7FFAF2ACBCC0
        public void __union(){} // RVA: 0x7FFAF2D33FA0
        public void __has_identifier(){} // RVA: 0x7FFAFA06E740
        public void CompareStrings(){} // RVA: 0x7FFAFA06E9A0 | overloaded x2
    }

    public class VectorOffset
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFA06E410
    }

    public class Verifier
    {
        public object Span;
        public object ReadOnlySpan;
        public object Memory;
        public object ReadOnlyMemory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFA06C580 | overloaded x2
        public void get_Buf(){} // RVA: 0x7FFAF2DA8380
        public void set_Buf(){} // RVA: 0x7FFAF2D8EE30
        public void get_options(){} // RVA: 0x7FFAF2D907C0
        public void set_options(){} // RVA: 0x7FFAF2DF3E80
        public void get_depth(){} // RVA: 0x7FFAF3210030
        public void set_depth(){} // RVA: 0x7FFAF344E0D0
        public void get_numTables(){} // RVA: 0x7FFAF379F5B0
        public void set_numTables(){} // RVA: 0x7FFAF4191F00
        public void SetMaxDepth(){} // RVA: 0x7FFAFA06C6A0
        public void SetMaxTables(){} // RVA: 0x7FFAFA06C6C0
        public void SetAlignmentCheck(){} // RVA: 0x7FFAFA06C6E0
        public void SetStringCheck(){} // RVA: 0x7FFAFA06C700
        public void BufferHasIdentifier(){} // RVA: 0x7FFAFA06C720
        public void ReadUOffsetT(){} // RVA: 0x7FFAFA06C8F0
        public void ReadSOffsetT(){} // RVA: 0x7FFAFA06C9A0
        public void ReadVOffsetT(){} // RVA: 0x7FFAFA06C9D0
        public void GetVRelOffset(){} // RVA: 0x7FFAFA06CA00
        public void GetVOffset(){} // RVA: 0x7FFAFA06CB60
        public void CheckComplexity(){} // RVA: 0x7FFAFA06CC90
        public void CheckAlignment(){} // RVA: 0x7FFAFA06CCD0
        public void CheckElement(){} // RVA: 0x7FFAFA06CD00
        public void CheckScalar(){} // RVA: 0x7FFAFA06CE40
        public void CheckOffset(){} // RVA: 0x7FFAFA06CE80
        public void CheckVectorOrString(){} // RVA: 0x7FFAFA06CEC0
        public void CheckString(){} // RVA: 0x7FFAFA06D000
        public void CheckVector(){} // RVA: 0x7FFAFA06D130
        public void CheckTable(){} // RVA: 0x7FFAFA06D140
        public void CheckStringFunc(){} // RVA: 0x7FFAFA06D170
        public void CheckVectorOfObjects(){} // RVA: 0x7FFAFA06D1A0
        public void CheckIndirectOffset(){} // RVA: 0x7FFAFA06D2D0
        public void CheckBufferFromStart(){} // RVA: 0x7FFAFA06D360
        public void GetIndirectOffset(){} // RVA: 0x7FFAFA06D600
        public void VerifyTableStart(){} // RVA: 0x7FFAFA06D6B0
        public void VerifyTableEnd(){} // RVA: 0x7FFAFA06D8C0
        public void VerifyField(){} // RVA: 0x7FFAFA06D8D0
        public void VerifyString(){} // RVA: 0x7FFAFA06D950
        public void VerifyVectorOfData(){} // RVA: 0x7FFAFA06D9E0
        public void VerifyVectorOfStrings(){} // RVA: 0x7FFAFA06DA70
        public void VerifyVectorOfTables(){} // RVA: 0x7FFAFA06DB50
        public void VerifyTable(){} // RVA: 0x7FFAFA06DBE0
        public void VerifyNestedBuffer(){} // RVA: 0x7FFAFA06DC80
        public void VerifyUnionData(){} // RVA: 0x7FFAFA06DE70
        public void VerifyUnionString(){} // RVA: 0x7FFAFA06DEB0
        public void VerifyUnion(){} // RVA: 0x7FFAFA06DEC0
        public void VerifyVectorOfUnion(){} // RVA: 0x7FFAFA06E030
        public void VerifyBuffer(){} // RVA: 0x7FFAFA06E2E0
    }

    public class VerifyTableAction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF5E5E0A0
        public void Invoke(){} // RVA: 0x7FFAF2EE9370
        public void BeginInvoke(){} // RVA: 0x7FFAFA06C210
        public void EndInvoke(){} // RVA: 0x7FFAF45EC940
    }

    public class VerifyUnionAction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFA06C2A0
        public void Invoke(){} // RVA: 0x7FFAF2EE94E0
        public void BeginInvoke(){} // RVA: 0x7FFAFA06C420
        public void EndInvoke(){} // RVA: 0x7FFAF45EC940
    }

    public class checkElementStruct
    {
    }

}