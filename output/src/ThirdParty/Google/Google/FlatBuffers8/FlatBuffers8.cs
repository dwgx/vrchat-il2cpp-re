// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Google.Google.FlatBuffers8
// Classes: 17
// Methods: 259

namespace ThirdParty.Google.Google.FlatBuffers8
{
    public class ByteArrayAllocator : ByteBufferAllocator
    {
        public byte[] _buffer; // 0x18
        public object field_1; // 0x6
        public object field_2; // 0x7
        public object field_3; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE880F3790
        public void GrowFront(){} // RVA: 0x7FFE880F3800
        public void get_Span(){} // RVA: 0x7FFE880F3990
        public void get_ReadOnlySpan(){} // RVA: 0x7FFE880F3A30
        public void get_Memory(){} // RVA: 0x7FFE880F3AD0
        public void get_ReadOnlyMemory(){} // RVA: 0x7FFE880F3BC0
        public void InitBuffer(){} // RVA: 0x7FFE880F3CB0
    }

    public class ByteBuffer : Object
    {
        public Google.FlatBuffers8.ByteBufferAllocator _buffer; // 0x10
        public int _pos; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE880F3E50 | overloaded x4
        public void get_Position(){} // RVA: 0x7FFE813DB630
        public void set_Position(){} // RVA: 0x7FFE8144DF00
        public void get_Length(){} // RVA: 0x7FFE8677C0B0
        public void Reset(){} // RVA: 0x7FFE817E01F0
        public void Duplicate(){} // RVA: 0x7FFE880F3F70
        public void GrowFront(){} // RVA: 0x7FFE86BADCF0
        public void ToArray(){} // RVA: 0x7FFE880F4020 | overloaded x2
        public void SizeOf(){} // RVA: 0x7FFE80E2EDE0
        public void IsSupportedType(){} // RVA: 0x7FFE80E2F180
        public void ArraySize(){} // RVA: 0x7FFE810A1420 | overloaded x3
        public void CopyToSizedArray(){} // RVA: 0x7FFE880F4080
        public void ToSizedArray(){} // RVA: 0x7FFE880F4360
        public void ToFullArray(){} // RVA: 0x7FFE880F43C0
        public void ToReadOnlyMemory(){} // RVA: 0x7FFE880F4420
        public void ToMemory(){} // RVA: 0x7FFE880F4580
        public void ToSpan(){} // RVA: 0x7FFE880F46D0
        public void ReverseBytes(){} // RVA: 0x7FFE880F47B0 | overloaded x3
        public void WriteLittleEndian(){} // RVA: 0x7FFE880F47C0
        public void ReadLittleEndian(){} // RVA: 0x7FFE880F4880
        public void AssertOffsetAndLength(){} // RVA: 0x7FFE880F4940
        public void PutSbyte(){} // RVA: 0x7FFE880F4BD0 | overloaded x2
        public void PutByte(){} // RVA: 0x7FFE880F4C50 | overloaded x2
        public void Put(){} // RVA: 0x7FFE810A1420 | overloaded x5
        public void PutStringUTF8(){} // RVA: 0x7FFE880F4D60
        public void PutShort(){} // RVA: 0x7FFE880F4E40
        public void PutUshort(){} // RVA: 0x7FFE880F4E50
        public void PutInt(){} // RVA: 0x7FFE880F4F50
        public void PutUint(){} // RVA: 0x7FFE880F4F60
        public void PutLong(){} // RVA: 0x7FFE880F5060
        public void PutUlong(){} // RVA: 0x7FFE880F5070
        public void PutFloat(){} // RVA: 0x7FFE880F5170
        public void PutDouble(){} // RVA: 0x7FFE880F5210
        public void GetSbyte(){} // RVA: 0x7FFE880F52B0
        public void Get(){} // RVA: 0x7FFE880F52B0
        public void GetStringUTF8(){} // RVA: 0x7FFE880F5320
        public void GetShort(){} // RVA: 0x7FFE880F54E0
        public void GetUshort(){} // RVA: 0x7FFE880F54F0
        public void GetInt(){} // RVA: 0x7FFE880F55E0
        public void GetUint(){} // RVA: 0x7FFE880F55F0
        public void GetLong(){} // RVA: 0x7FFE880F5720
        public void GetUlong(){} // RVA: 0x7FFE880F5730
        public void GetFloat(){} // RVA: 0x7FFE880F5820
        public void GetDouble(){} // RVA: 0x7FFE880F58B0
        public void .cctor(){} // RVA: 0x7FFE880F5940
    }

    public class ByteBufferAllocator : Object
    {
        public int _length; // 0x10
        public object field_1; // 0x1
        public object field_2; // 0x2
        public object field_3; // 0x3
        public object field_4; // 0x4

        // ── Methods ──
        public void get_Span(){}
        public void get_ReadOnlySpan(){}
        public void get_Memory(){} // RVA: 0x7FFE80E2DCF0
        public void get_ReadOnlyMemory(){} // RVA: 0x7FFE80E2DCF0
        public void get_Length(){} // RVA: 0x7FFE811485C0
        public void set_Length(){} // RVA: 0x7FFE810FE0C0
        public void GrowFront(){} // RVA: 0x7FFE80E46530
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ByteBufferUtil : Object
    {
        // ── Methods ──
        public void GetSizePrefix(){} // RVA: 0x7FFE880F6120
        public void RemoveSizePrefix(){} // RVA: 0x7FFE880F6150
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class FlatBufferBuilder : Object
    {
        public int _space; // 0x10
        public Google.FlatBuffers8.ByteBuffer _bb; // 0x18
        public int _minAlign; // 0x20
        public int[] _vtable; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE880F6480 | overloaded x2
        public void Clear(){} // RVA: 0x7FFE880F6620
        public void get_ForceDefaults(){} // RVA: 0x7FFE813A1140
        public void set_ForceDefaults(){} // RVA: 0x7FFE819E83C0
        public void get_Offset(){} // RVA: 0x7FFE880F6740
        public void get_Waste(){} // RVA: 0x7FFE8119C0C0
        public void Pad(){} // RVA: 0x7FFE880F6770
        public void GrowBuffer(){} // RVA: 0x7FFE880F6880
        public void Prep(){} // RVA: 0x7FFE880F68C0
        public void PutBool(){} // RVA: 0x7FFE880F6A80
        public void PutSbyte(){} // RVA: 0x7FFE880F6AB0
        public void PutByte(){} // RVA: 0x7FFE880F6AB0
        public void PutShort(){} // RVA: 0x7FFE880F6AE0
        public void PutUshort(){} // RVA: 0x7FFE880F6AE0
        public void PutInt(){} // RVA: 0x7FFE880F6B10
        public void PutUint(){} // RVA: 0x7FFE880F6B10
        public void PutLong(){} // RVA: 0x7FFE880F6B40
        public void PutUlong(){} // RVA: 0x7FFE880F6B40
        public void PutFloat(){} // RVA: 0x7FFE880F6B70
        public void Put(){} // RVA: 0x7FFE810A1420 | overloaded x4
        public void PutDouble(){} // RVA: 0x7FFE880F6C30
        public void AddBool(){} // RVA: 0x7FFE880F7660 | overloaded x3
        public void AddSbyte(){} // RVA: 0x7FFE880F7790 | overloaded x3
        public void AddByte(){} // RVA: 0x7FFE880F7840 | overloaded x4
        public void AddShort(){} // RVA: 0x7FFE880F7970 | overloaded x3
        public void AddUshort(){} // RVA: 0x7FFE880F7AA0 | overloaded x3
        public void AddInt(){} // RVA: 0x7FFE880F7BD0 | overloaded x3
        public void AddUint(){} // RVA: 0x7FFE880F7C80 | overloaded x3
        public void AddLong(){} // RVA: 0x7FFE880F7DB0 | overloaded x3
        public void AddUlong(){} // RVA: 0x7FFE880F7E60 | overloaded x3
        public void AddFloat(){} // RVA: 0x7FFE880F7F80 | overloaded x3
        public void Add(){} // RVA: 0x7FFE810A1420 | overloaded x4
        public void AddDouble(){} // RVA: 0x7FFE880F8080 | overloaded x3
        public void AddOffset(){} // RVA: 0x7FFE880F8110 | overloaded x2
        public void StartVector(){} // RVA: 0x7FFE880F7090
        public void EndVector(){} // RVA: 0x7FFE880F71E0
        public void CreateVectorOfTables(){} // RVA: 0x7FFE810A1420
        public void Nested(){} // RVA: 0x7FFE880F7310
        public void NotNested(){} // RVA: 0x7FFE880F7390
        public void StartTable(){} // RVA: 0x7FFE880F7400
        public void Slot(){} // RVA: 0x7FFE880F7530
        public void CreateString(){} // RVA: 0x7FFE880F8150
        public void CreateUTF8String(){} // RVA: 0x7FFE880F8300
        public void CreateSharedString(){} // RVA: 0x7FFE880F8430
        public void AddStruct(){} // RVA: 0x7FFE880F86C0
        public void EndTable(){} // RVA: 0x7FFE880F8750
        public void Required(){} // RVA: 0x7FFE880F8D60
        public void Finish(){} // RVA: 0x7FFE880F91E0 | overloaded x4
        public void FinishSizePrefixed(){} // RVA: 0x7FFE880F9200 | overloaded x2
        public void get_DataBuffer(){} // RVA: 0x7FFE810FE7C0
        public void SizedByteArray(){} // RVA: 0x7FFE880F8FD0
    }

    public class FlatBufferConstants : Object
    {
        // ── Methods ──
        public void FLATBUFFERS_24_3_7(){} // RVA: 0x7FFE810FB310
    }

    public class IFlatbufferObject
    {
        // ── Methods ──
        public void __init(){} // RVA: 0x7FFE80E48220
        public void get_ByteBuffer(){} // RVA: 0x7FFE80E2E2E0
    }

    public class Offset`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E46530
    }

    public class Options : Object
    {
        public int DEFAULT_MAX_DEPTH;
        public int DEFAULT_MAX_TABLES;
        public int max_depth; // 0x10
        public int max_tables; // 0x14

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE880F9240 | overloaded x2
        public void get_maxDepth(){} // RVA: 0x7FFE811485C0
        public void set_maxDepth(){} // RVA: 0x7FFE810FE0C0
        public void get_maxTables(){} // RVA: 0x7FFE8164B230
        public void set_maxTables(){} // RVA: 0x7FFE8164E0F0
        public void get_stringEndCheck(){} // RVA: 0x7FFE811164E0
        public void set_stringEndCheck(){} // RVA: 0x7FFE811164F0
        public void get_alignmentCheck(){} // RVA: 0x7FFE814B3730
        public void set_alignmentCheck(){} // RVA: 0x7FFE81CD0510
    }

    public class StringOffset : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE880FB400
    }

    public class Struct : ValueType
    {
        public int _bb_pos; // 0x10
        public Google.FlatBuffers8.ByteBuffer _bb; // 0x18

        // ── Methods ──
        public void get_bb_pos(){} // RVA: 0x7FFE826F4220
        public void set_bb_pos(){} // RVA: 0x7FFE815BF990
        public void get_bb(){} // RVA: 0x7FFE826F4210
        public void set_bb(){} // RVA: 0x7FFE826F4230
        public void .ctor(){} // RVA: 0x7FFE880FB4C0
    }

    public class Table : ValueType
    {
        public int _bb_pos; // 0x10
        public Google.FlatBuffers8.ByteBuffer _bb; // 0x18
        public object field_2; // 0x1B

        // ── Methods ──
        public void get_bb_pos(){} // RVA: 0x7FFE826F4220
        public void set_bb_pos(){} // RVA: 0x7FFE815BF990
        public void get_bb(){} // RVA: 0x7FFE826F4210
        public void set_bb(){} // RVA: 0x7FFE826F4230
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void .ctor(){} // RVA: 0x7FFE880FB4C0
        public void __offset(){} // RVA: 0x7FFE880FB5C0 | overloaded x2
        public void __indirect(){} // RVA: 0x7FFE880FB660 | overloaded x2
        public void __string(){} // RVA: 0x7FFE880FB690
        public void __vector_len(){} // RVA: 0x7FFE880FB710
        public void __vector(){} // RVA: 0x7FFE880FB760
        public void __vector_as_span(){} // RVA: 0x7FFE810A1420
        public void __vector_as_array(){} // RVA: 0x7FFE80E3D230
        public void __union(){} // RVA: 0x7FFE810A1420
        public void __has_identifier(){} // RVA: 0x7FFE880FB790
        public void CompareStrings(){} // RVA: 0x7FFE880FB9F0 | overloaded x2
    }

    public class VectorOffset : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE880FB460
    }

    public class Verifier : Object
    {
        public Google.FlatBuffers8.ByteBuffer verifier_buffer; // 0x10
        public Google.FlatBuffers8.Options verifier_options; // 0x18
        public int depth_cnt; // 0x20
        public int num_tables_cnt; // 0x24

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE880F95D0 | overloaded x2
        public void get_Buf(){} // RVA: 0x7FFE81116380
        public void set_Buf(){} // RVA: 0x7FFE810FCE30
        public void get_options(){} // RVA: 0x7FFE810FE7C0
        public void set_options(){} // RVA: 0x7FFE81161E80
        public void get_depth(){} // RVA: 0x7FFE8151D690
        public void set_depth(){} // RVA: 0x7FFE8170B670
        public void get_numTables(){} // RVA: 0x7FFE81A56130
        public void set_numTables(){} // RVA: 0x7FFE82447980
        public void SetMaxDepth(){} // RVA: 0x7FFE880F96F0
        public void SetMaxTables(){} // RVA: 0x7FFE880F9710
        public void SetAlignmentCheck(){} // RVA: 0x7FFE880F9730
        public void SetStringCheck(){} // RVA: 0x7FFE880F9750
        public void BufferHasIdentifier(){} // RVA: 0x7FFE880F9770
        public void ReadUOffsetT(){} // RVA: 0x7FFE880F9940
        public void ReadSOffsetT(){} // RVA: 0x7FFE880F99F0
        public void ReadVOffsetT(){} // RVA: 0x7FFE880F9A20
        public void GetVRelOffset(){} // RVA: 0x7FFE880F9A50
        public void GetVOffset(){} // RVA: 0x7FFE880F9BB0
        public void CheckComplexity(){} // RVA: 0x7FFE880F9CE0
        public void CheckAlignment(){} // RVA: 0x7FFE880F9D20
        public void CheckElement(){} // RVA: 0x7FFE880F9D50
        public void CheckScalar(){} // RVA: 0x7FFE880F9E90
        public void CheckOffset(){} // RVA: 0x7FFE880F9ED0
        public void CheckVectorOrString(){} // RVA: 0x7FFE880F9F10
        public void CheckString(){} // RVA: 0x7FFE880FA050
        public void CheckVector(){} // RVA: 0x7FFE880FA180
        public void CheckTable(){} // RVA: 0x7FFE880FA190
        public void CheckStringFunc(){} // RVA: 0x7FFE880FA1C0
        public void CheckVectorOfObjects(){} // RVA: 0x7FFE880FA1F0
        public void CheckIndirectOffset(){} // RVA: 0x7FFE880FA320
        public void CheckBufferFromStart(){} // RVA: 0x7FFE880FA3B0
        public void GetIndirectOffset(){} // RVA: 0x7FFE880FA650
        public void VerifyTableStart(){} // RVA: 0x7FFE880FA700
        public void VerifyTableEnd(){} // RVA: 0x7FFE880FA910
        public void VerifyField(){} // RVA: 0x7FFE880FA920
        public void VerifyString(){} // RVA: 0x7FFE880FA9A0
        public void VerifyVectorOfData(){} // RVA: 0x7FFE880FAA30
        public void VerifyVectorOfStrings(){} // RVA: 0x7FFE880FAAC0
        public void VerifyVectorOfTables(){} // RVA: 0x7FFE880FABA0
        public void VerifyTable(){} // RVA: 0x7FFE880FAC30
        public void VerifyNestedBuffer(){} // RVA: 0x7FFE880FACD0
        public void VerifyUnionData(){} // RVA: 0x7FFE880FAEC0
        public void VerifyUnionString(){} // RVA: 0x7FFE880FAF00
        public void VerifyUnion(){} // RVA: 0x7FFE880FAF10
        public void VerifyVectorOfUnion(){} // RVA: 0x7FFE880FB080
        public void VerifyBuffer(){} // RVA: 0x7FFE880FB330
    }

    public class VerifyTableAction : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8401A000
        public void Invoke(){} // RVA: 0x7FFE81257370
        public void BeginInvoke(){} // RVA: 0x7FFE880F9260
        public void EndInvoke(){} // RVA: 0x7FFE828C6E90
    }

    public class VerifyUnionAction : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE880F92F0
        public void Invoke(){} // RVA: 0x7FFE812574E0
        public void BeginInvoke(){} // RVA: 0x7FFE880F9470
        public void EndInvoke(){} // RVA: 0x7FFE828C6E90
    }

    public class checkElementStruct : ValueType
    {
    }

}