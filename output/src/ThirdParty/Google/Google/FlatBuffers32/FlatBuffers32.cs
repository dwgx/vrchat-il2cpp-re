// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Google.Google.FlatBuffers32
// Classes: 29
// Methods: 262

namespace ThirdParty.Google.Google.FlatBuffers32
{
    public class ByteArrayAllocator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFA066740
        public void GrowFront(){} // RVA: 0x7FFAFA06EAC0
        public void get_Span(){} // RVA: 0x7FFAFA06EC50
        public void get_ReadOnlySpan(){} // RVA: 0x7FFAFA06ECF0
        public void get_Memory(){} // RVA: 0x7FFAFA06ED90
        public void get_ReadOnlyMemory(){} // RVA: 0x7FFAFA06EE80
        public void InitBuffer(){} // RVA: 0x7FFAFA066C60
    }

    public class ByteBuffer
    {
        public object Position;
        public object Length;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFA06F0F0 | overloaded x4
        public void get_Position(){} // RVA: 0x7FFAF306ED50
        public void set_Position(){} // RVA: 0x7FFAF30E74E0
        public void get_Length(){} // RVA: 0x7FFAF86EB260
        public void Reset(){} // RVA: 0x7FFAF3502E70
        public void Duplicate(){} // RVA: 0x7FFAFA06F210
        public void GrowFront(){} // RVA: 0x7FFAF8B1CF20
        public void ToArray(){} // RVA: 0x7FFAFA06F2C0 | overloaded x2
        public void SizeOf(){} // RVA: 0x7FFAF2ABD870
        public void IsSupportedType(){} // RVA: 0x7FFAF2ABDC10
        public void ArraySize(){} // RVA: 0x7FFAF2D33FA0 | overloaded x3
        public void CopyToSizedArray(){} // RVA: 0x7FFAFA06F320
        public void ToSizedArray(){} // RVA: 0x7FFAFA06F600
        public void ToFullArray(){} // RVA: 0x7FFAFA06F660
        public void ToReadOnlyMemory(){} // RVA: 0x7FFAFA06F6C0
        public void ToMemory(){} // RVA: 0x7FFAFA06F820
        public void ToSpan(){} // RVA: 0x7FFAFA06F970
        public void ReverseBytes(){} // RVA: 0x7FFAFA067760 | overloaded x3
        public void WriteLittleEndian(){} // RVA: 0x7FFAFA067770
        public void ReadLittleEndian(){} // RVA: 0x7FFAFA06FA50
        public void AssertOffsetAndLength(){} // RVA: 0x7FFAFA06FB70
        public void PutSbyte(){} // RVA: 0x7FFAFA06FCA0 | overloaded x2
        public void PutByte(){} // RVA: 0x7FFAFA06FD50 | overloaded x2
        public void Put(){} // RVA: 0x7FFAF2D33FA0 | overloaded x5
        public void PutStringUTF8(){} // RVA: 0x7FFAFA06FEB0
        public void PutShort(){} // RVA: 0x7FFAFA06FFE0
        public void PutUshort(){} // RVA: 0x7FFAFA06FFF0
        public void PutInt(){} // RVA: 0x7FFAFA070130
        public void PutUint(){} // RVA: 0x7FFAFA070140
        public void PutLong(){} // RVA: 0x7FFAFA070280
        public void PutUlong(){} // RVA: 0x7FFAFA070290
        public void PutFloat(){} // RVA: 0x7FFAFA0703D0
        public void PutDouble(){} // RVA: 0x7FFAFA0704B0
        public void GetSbyte(){} // RVA: 0x7FFAFA070590
        public void Get(){} // RVA: 0x7FFAFA070590
        public void GetStringUTF8(){} // RVA: 0x7FFAFA070630
        public void GetShort(){} // RVA: 0x7FFAFA0707F0
        public void GetUshort(){} // RVA: 0x7FFAFA070800
        public void GetInt(){} // RVA: 0x7FFAFA070930
        public void GetUint(){} // RVA: 0x7FFAFA070940
        public void GetLong(){} // RVA: 0x7FFAFA070AB0
        public void GetUlong(){} // RVA: 0x7FFAFA070AC0
        public void GetFloat(){} // RVA: 0x7FFAFA070BF0
        public void GetDouble(){} // RVA: 0x7FFAFA070CC0
        public void .cctor(){} // RVA: 0x7FFAFA070D90
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
        public void GetSizePrefix(){} // RVA: 0x7FFAFA071570
        public void RemoveSizePrefix(){} // RVA: 0x7FFAFA071590
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class FlatBufferBuilder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFA0718C0 | overloaded x2
        public void Clear(){} // RVA: 0x7FFAFA071A60
        public void get_ForceDefaults(){} // RVA: 0x7FFAF304FF30
        public void set_ForceDefaults(){} // RVA: 0x7FFAF370F680
        public void get_Offset(){} // RVA: 0x7FFAFA0696F0
        public void get_Waste(){} // RVA: 0x7FFAF2E2E0C0
        public void Pad(){} // RVA: 0x7FFAFA071B80
        public void GrowBuffer(){} // RVA: 0x7FFAFA069830
        public void Prep(){} // RVA: 0x7FFAFA071CD0
        public void PutBool(){} // RVA: 0x7FFAFA071DA0
        public void PutSbyte(){} // RVA: 0x7FFAFA071DD0
        public void PutByte(){} // RVA: 0x7FFAFA071DD0
        public void PutShort(){} // RVA: 0x7FFAFA071E00
        public void PutUshort(){} // RVA: 0x7FFAFA071E00
        public void PutInt(){} // RVA: 0x7FFAFA071E30
        public void PutUint(){} // RVA: 0x7FFAFA071E30
        public void PutLong(){} // RVA: 0x7FFAFA071E60
        public void PutUlong(){} // RVA: 0x7FFAFA071E60
        public void PutFloat(){} // RVA: 0x7FFAFA071E90
        public void Put(){} // RVA: 0x7FFAF2D33FA0 | overloaded x4
        public void PutDouble(){} // RVA: 0x7FFAFA071F80
        public void AddBool(){} // RVA: 0x7FFAFA0727A0 | overloaded x3
        public void AddSbyte(){} // RVA: 0x7FFAFA0728D0 | overloaded x3
        public void AddByte(){} // RVA: 0x7FFAFA072980 | overloaded x3
        public void AddShort(){} // RVA: 0x7FFAFA072AB0 | overloaded x3
        public void AddUshort(){} // RVA: 0x7FFAFA072BE0 | overloaded x3
        public void AddInt(){} // RVA: 0x7FFAFA072D10 | overloaded x3
        public void AddUint(){} // RVA: 0x7FFAFA072DC0 | overloaded x3
        public void AddLong(){} // RVA: 0x7FFAFA072EF0 | overloaded x3
        public void AddUlong(){} // RVA: 0x7FFAFA072FA0 | overloaded x3
        public void AddFloat(){} // RVA: 0x7FFAFA0730C0 | overloaded x3
        public void Add(){} // RVA: 0x7FFAF2D33FA0 | overloaded x4
        public void AddDouble(){} // RVA: 0x7FFAFA0731C0 | overloaded x3
        public void AddOffset(){} // RVA: 0x7FFAFA073250 | overloaded x2
        public void StartVector(){} // RVA: 0x7FFAFA072350
        public void EndVector(){} // RVA: 0x7FFAFA072400
        public void CreateVectorOfTables(){} // RVA: 0x7FFAF2D33FA0
        public void Nested(){} // RVA: 0x7FFAFA072450
        public void NotNested(){} // RVA: 0x7FFAFA0724D0
        public void StartTable(){} // RVA: 0x7FFAFA072540
        public void Slot(){} // RVA: 0x7FFAFA072670
        public void CreateString(){} // RVA: 0x7FFAFA073290
        public void CreateUTF8String(){} // RVA: 0x7FFAFA0734B0
        public void CreateSharedString(){} // RVA: 0x7FFAFA073610
        public void AddStruct(){} // RVA: 0x7FFAFA0738A0
        public void EndTable(){} // RVA: 0x7FFAFA073930
        public void Required(){} // RVA: 0x7FFAFA073EA0
        public void Finish(){} // RVA: 0x7FFAFA0743A0 | overloaded x4
        public void FinishSizePrefixed(){} // RVA: 0x7FFAFA0743C0 | overloaded x2
        public void get_DataBuffer(){} // RVA: 0x7FFAF2D907C0
        public void SizedByteArray(){} // RVA: 0x7FFAFA074160
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
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF32E3580
    }

    public class Offset`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF32E3580
    }

    public class Offset`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF32E3580
    }

    public class Offset`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF32E3580
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
        public object bb_pos;
        public object bb;

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
        public void .ctor(){} // RVA: 0x7FFAF32E3580
    }

    public class Struct
    {
        public object _bb_pos;

        // ── Methods ──
        public void get_bb_pos(){} // RVA: 0x7FFAF44189B0
        public void set_bb_pos(){} // RVA: 0x7FFAF32E3580
        public void get_bb(){} // RVA: 0x7FFAF44189C0
        public void set_bb(){} // RVA: 0x7FFAF4418950
        public void .ctor(){} // RVA: 0x7FFAFA06E470
    }

    public class Table
    {
        public object bb_pos;
        public object bb;
        public object ByteBuffer;

        // ── Methods ──
        public void get_bb_pos(){} // RVA: 0x7FFAF44189B0
        public void set_bb_pos(){} // RVA: 0x7FFAF32E3580
        public void get_bb(){} // RVA: 0x7FFAF44189C0
        public void set_bb(){} // RVA: 0x7FFAF4418950
        public void get_ByteBuffer(){} // RVA: 0x7FFAF44189C0
        public void .ctor(){} // RVA: 0x7FFAFA06E470
        public void __offset(){} // RVA: 0x7FFAFA0762A0 | overloaded x2
        public void __indirect(){} // RVA: 0x7FFAFA076330 | overloaded x2
        public void __string(){} // RVA: 0x7FFAFA076360
        public void __vector_len(){} // RVA: 0x7FFAFA0763D0
        public void __vector(){} // RVA: 0x7FFAFA076420
        public void __vector_as_span(){} // RVA: 0x7FFAF2D33FA0
        public void __vector_as_array(){} // RVA: 0x7FFAF2ACBCC0
        public void __union(){} // RVA: 0x7FFAF2D33FA0
        public void __has_identifier(){} // RVA: 0x7FFAFA076450
        public void CompareStrings(){} // RVA: 0x7FFAFA0766B0 | overloaded x2
    }

    public class VectorOffset
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF32E3580
    }

    public class Verifier
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFA074520 | overloaded x2
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
        public void BufferHasIdentifier(){} // RVA: 0x7FFAFA074640
        public void ReadUOffsetT(){} // RVA: 0x7FFAFA074810
        public void ReadSOffsetT(){} // RVA: 0x7FFAFA0748C0
        public void ReadVOffsetT(){} // RVA: 0x7FFAFA0748F0
        public void GetVRelOffset(){} // RVA: 0x7FFAFA074920
        public void GetVOffset(){} // RVA: 0x7FFAFA074A80
        public void CheckComplexity(){} // RVA: 0x7FFAFA06CC90
        public void CheckAlignment(){} // RVA: 0x7FFAFA06CCD0
        public void CheckElement(){} // RVA: 0x7FFAFA074BB0
        public void CheckScalar(){} // RVA: 0x7FFAFA074CF0
        public void CheckOffset(){} // RVA: 0x7FFAFA074D30
        public void CheckVectorOrString(){} // RVA: 0x7FFAFA074D70
        public void CheckString(){} // RVA: 0x7FFAFA074EB0
        public void CheckVector(){} // RVA: 0x7FFAFA074FE0
        public void CheckTable(){} // RVA: 0x7FFAFA06D140
        public void CheckStringFunc(){} // RVA: 0x7FFAFA074FF0
        public void CheckVectorOfObjects(){} // RVA: 0x7FFAFA075020
        public void CheckIndirectOffset(){} // RVA: 0x7FFAFA075150
        public void CheckBufferFromStart(){} // RVA: 0x7FFAFA0751E0
        public void GetIndirectOffset(){} // RVA: 0x7FFAFA075480
        public void VerifyTableStart(){} // RVA: 0x7FFAFA075530
        public void VerifyTableEnd(){} // RVA: 0x7FFAFA06D8C0
        public void VerifyField(){} // RVA: 0x7FFAFA075740
        public void VerifyString(){} // RVA: 0x7FFAFA0757C0
        public void VerifyVectorOfData(){} // RVA: 0x7FFAFA075850
        public void VerifyVectorOfStrings(){} // RVA: 0x7FFAFA0758E0
        public void VerifyVectorOfTables(){} // RVA: 0x7FFAFA0759C0
        public void VerifyTable(){} // RVA: 0x7FFAFA075A50
        public void VerifyNestedBuffer(){} // RVA: 0x7FFAFA075AF0
        public void VerifyUnionData(){} // RVA: 0x7FFAFA075CB0
        public void VerifyUnionString(){} // RVA: 0x7FFAFA075CF0
        public void VerifyUnion(){} // RVA: 0x7FFAFA075D00
        public void VerifyVectorOfUnion(){} // RVA: 0x7FFAFA075E70
        public void VerifyBuffer(){} // RVA: 0x7FFAFA076120
    }

    public class VerifyTableAction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF5E5E0A0
        public void Invoke(){} // RVA: 0x7FFAF2EE9370
        public void BeginInvoke(){} // RVA: 0x7FFAFA0743E0
        public void EndInvoke(){} // RVA: 0x7FFAF45EC940
    }

    public class VerifyUnionAction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFA06C2A0
        public void Invoke(){} // RVA: 0x7FFAF2EE94E0
        public void BeginInvoke(){} // RVA: 0x7FFAFA074470
        public void EndInvoke(){} // RVA: 0x7FFAF45EC940
    }

    public class checkElementStruct
    {
    }

}