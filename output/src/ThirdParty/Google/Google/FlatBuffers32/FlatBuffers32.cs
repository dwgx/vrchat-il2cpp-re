// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Google.Google.FlatBuffers32
// Classes: 17
// Methods: 258

namespace ThirdParty.Google.Google.FlatBuffers32
{
    public class ByteArrayAllocator : ByteBufferAllocator
    {
        public byte[] _buffer; // 0x18
        public object field_1; // 0x23
        public object field_2; // 0x24
        public object field_3; // 0x25

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE880F3790
        public void GrowFront(){} // RVA: 0x7FFE880FBB10
        public void get_Span(){} // RVA: 0x7FFE880FBCA0
        public void get_ReadOnlySpan(){} // RVA: 0x7FFE880FBD40
        public void get_Memory(){} // RVA: 0x7FFE880FBDE0
        public void get_ReadOnlyMemory(){} // RVA: 0x7FFE880FBED0
        public void InitBuffer(){} // RVA: 0x7FFE880F3CB0
    }

    public class ByteBuffer : Object
    {
        public Google.FlatBuffers32.ByteBufferAllocator _buffer; // 0x10
        public int _pos; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE880FC140 | overloaded x4
        public void get_Position(){} // RVA: 0x7FFE813DB630
        public void set_Position(){} // RVA: 0x7FFE8144DF00
        public void get_Length(){} // RVA: 0x7FFE8677C0B0
        public void Reset(){} // RVA: 0x7FFE817E01F0
        public void Duplicate(){} // RVA: 0x7FFE880FC260
        public void GrowFront(){} // RVA: 0x7FFE86BADCF0
        public void ToArray(){} // RVA: 0x7FFE880FC310 | overloaded x2
        public void SizeOf(){} // RVA: 0x7FFE80E2EDE0
        public void IsSupportedType(){} // RVA: 0x7FFE80E2F180
        public void ArraySize(){} // RVA: 0x7FFE810A1420 | overloaded x3
        public void CopyToSizedArray(){} // RVA: 0x7FFE880FC370
        public void ToSizedArray(){} // RVA: 0x7FFE880FC650
        public void ToFullArray(){} // RVA: 0x7FFE880FC6B0
        public void ToReadOnlyMemory(){} // RVA: 0x7FFE880FC710
        public void ToMemory(){} // RVA: 0x7FFE880FC870
        public void ToSpan(){} // RVA: 0x7FFE880FC9C0
        public void ReverseBytes(){} // RVA: 0x7FFE880F47B0 | overloaded x3
        public void WriteLittleEndian(){} // RVA: 0x7FFE880F47C0
        public void ReadLittleEndian(){} // RVA: 0x7FFE880FCAA0
        public void AssertOffsetAndLength(){} // RVA: 0x7FFE880FCBC0
        public void PutSbyte(){} // RVA: 0x7FFE880FCCF0 | overloaded x2
        public void PutByte(){} // RVA: 0x7FFE880FCDA0 | overloaded x2
        public void Put(){} // RVA: 0x7FFE810A1420 | overloaded x5
        public void PutStringUTF8(){} // RVA: 0x7FFE880FCF00
        public void PutShort(){} // RVA: 0x7FFE880FD030
        public void PutUshort(){} // RVA: 0x7FFE880FD040
        public void PutInt(){} // RVA: 0x7FFE880FD180
        public void PutUint(){} // RVA: 0x7FFE880FD190
        public void PutLong(){} // RVA: 0x7FFE880FD2D0
        public void PutUlong(){} // RVA: 0x7FFE880FD2E0
        public void PutFloat(){} // RVA: 0x7FFE880FD420
        public void PutDouble(){} // RVA: 0x7FFE880FD500
        public void GetSbyte(){} // RVA: 0x7FFE880FD5E0
        public void Get(){} // RVA: 0x7FFE880FD5E0
        public void GetStringUTF8(){} // RVA: 0x7FFE880FD680
        public void GetShort(){} // RVA: 0x7FFE880FD840
        public void GetUshort(){} // RVA: 0x7FFE880FD850
        public void GetInt(){} // RVA: 0x7FFE880FD980
        public void GetUint(){} // RVA: 0x7FFE880FD990
        public void GetLong(){} // RVA: 0x7FFE880FDB00
        public void GetUlong(){} // RVA: 0x7FFE880FDB10
        public void GetFloat(){} // RVA: 0x7FFE880FDC40
        public void GetDouble(){} // RVA: 0x7FFE880FDD10
        public void .cctor(){} // RVA: 0x7FFE880FDDE0
    }

    public class ByteBufferAllocator : Object
    {
        public int _length; // 0x10
        public object field_1; // 0x1E
        public object field_2; // 0x1F
        public object field_3; // 0x20
        public object field_4; // 0x21

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
        public void GetSizePrefix(){} // RVA: 0x7FFE880FE5C0
        public void RemoveSizePrefix(){} // RVA: 0x7FFE880FE5E0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class FlatBufferBuilder : Object
    {
        public int _space; // 0x10
        public Google.FlatBuffers32.ByteBuffer _bb; // 0x18
        public int _minAlign; // 0x20
        public int[] _vtable; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE880FE910 | overloaded x2
        public void Clear(){} // RVA: 0x7FFE880FEAB0
        public void get_ForceDefaults(){} // RVA: 0x7FFE813A1140
        public void set_ForceDefaults(){} // RVA: 0x7FFE819E83C0
        public void get_Offset(){} // RVA: 0x7FFE880F6740
        public void get_Waste(){} // RVA: 0x7FFE8119C0C0
        public void Pad(){} // RVA: 0x7FFE880FEBD0
        public void GrowBuffer(){} // RVA: 0x7FFE880F6880
        public void Prep(){} // RVA: 0x7FFE880FED20
        public void PutBool(){} // RVA: 0x7FFE880FEDF0
        public void PutSbyte(){} // RVA: 0x7FFE880FEE20
        public void PutByte(){} // RVA: 0x7FFE880FEE20
        public void PutShort(){} // RVA: 0x7FFE880FEE50
        public void PutUshort(){} // RVA: 0x7FFE880FEE50
        public void PutInt(){} // RVA: 0x7FFE880FEE80
        public void PutUint(){} // RVA: 0x7FFE880FEE80
        public void PutLong(){} // RVA: 0x7FFE880FEEB0
        public void PutUlong(){} // RVA: 0x7FFE880FEEB0
        public void PutFloat(){} // RVA: 0x7FFE880FEEE0
        public void Put(){} // RVA: 0x7FFE810A1420 | overloaded x4
        public void PutDouble(){} // RVA: 0x7FFE880FEFD0
        public void AddBool(){} // RVA: 0x7FFE880FF7F0 | overloaded x3
        public void AddSbyte(){} // RVA: 0x7FFE880FF920 | overloaded x3
        public void AddByte(){} // RVA: 0x7FFE880FF9D0 | overloaded x3
        public void AddShort(){} // RVA: 0x7FFE880FFB00 | overloaded x3
        public void AddUshort(){} // RVA: 0x7FFE880FFC30 | overloaded x3
        public void AddInt(){} // RVA: 0x7FFE880FFD60 | overloaded x3
        public void AddUint(){} // RVA: 0x7FFE880FFE10 | overloaded x3
        public void AddLong(){} // RVA: 0x7FFE880FFF40 | overloaded x3
        public void AddUlong(){} // RVA: 0x7FFE880FFFF0 | overloaded x3
        public void AddFloat(){} // RVA: 0x7FFE88100110 | overloaded x3
        public void Add(){} // RVA: 0x7FFE810A1420 | overloaded x4
        public void AddDouble(){} // RVA: 0x7FFE88100210 | overloaded x3
        public void AddOffset(){} // RVA: 0x7FFE881002A0 | overloaded x2
        public void StartVector(){} // RVA: 0x7FFE880FF3A0
        public void EndVector(){} // RVA: 0x7FFE880FF450
        public void CreateVectorOfTables(){} // RVA: 0x7FFE810A1420
        public void Nested(){} // RVA: 0x7FFE880FF4A0
        public void NotNested(){} // RVA: 0x7FFE880FF520
        public void StartTable(){} // RVA: 0x7FFE880FF590
        public void Slot(){} // RVA: 0x7FFE880FF6C0
        public void CreateString(){} // RVA: 0x7FFE881002E0
        public void CreateUTF8String(){} // RVA: 0x7FFE88100500
        public void CreateSharedString(){} // RVA: 0x7FFE88100660
        public void AddStruct(){} // RVA: 0x7FFE881008F0
        public void EndTable(){} // RVA: 0x7FFE88100980
        public void Required(){} // RVA: 0x7FFE88100EF0
        public void Finish(){} // RVA: 0x7FFE881013F0 | overloaded x4
        public void FinishSizePrefixed(){} // RVA: 0x7FFE88101410 | overloaded x2
        public void get_DataBuffer(){} // RVA: 0x7FFE810FE7C0
        public void SizedByteArray(){} // RVA: 0x7FFE881011B0
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
        public void .ctor(){} // RVA: 0x7FFE815BF990
    }

    public class Struct : ValueType
    {
        public int _bb_pos; // 0x10
        public Google.FlatBuffers32.ByteBuffer _bb; // 0x18

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
        public Google.FlatBuffers32.ByteBuffer _bb; // 0x18
        public object field_2; // 0x10

        // ── Methods ──
        public void get_bb_pos(){} // RVA: 0x7FFE826F4220
        public void set_bb_pos(){} // RVA: 0x7FFE815BF990
        public void get_bb(){} // RVA: 0x7FFE826F4210
        public void set_bb(){} // RVA: 0x7FFE826F4230
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void .ctor(){} // RVA: 0x7FFE880FB4C0
        public void __offset(){} // RVA: 0x7FFE881032F0 | overloaded x2
        public void __indirect(){} // RVA: 0x7FFE88103380 | overloaded x2
        public void __string(){} // RVA: 0x7FFE881033B0
        public void __vector_len(){} // RVA: 0x7FFE88103420
        public void __vector(){} // RVA: 0x7FFE88103470
        public void __vector_as_span(){} // RVA: 0x7FFE810A1420
        public void __vector_as_array(){} // RVA: 0x7FFE80E3D230
        public void __union(){} // RVA: 0x7FFE810A1420
        public void __has_identifier(){} // RVA: 0x7FFE881034A0
        public void CompareStrings(){} // RVA: 0x7FFE88103700 | overloaded x2
    }

    public class VectorOffset : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE815BF990
    }

    public class Verifier : Object
    {
        public Google.FlatBuffers32.ByteBuffer verifier_buffer; // 0x10
        public Google.FlatBuffers32.Options verifier_options; // 0x18
        public int depth_cnt; // 0x20
        public int num_tables_cnt; // 0x24

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE88101570 | overloaded x2
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
        public void BufferHasIdentifier(){} // RVA: 0x7FFE88101690
        public void ReadUOffsetT(){} // RVA: 0x7FFE88101860
        public void ReadSOffsetT(){} // RVA: 0x7FFE88101910
        public void ReadVOffsetT(){} // RVA: 0x7FFE88101940
        public void GetVRelOffset(){} // RVA: 0x7FFE88101970
        public void GetVOffset(){} // RVA: 0x7FFE88101AD0
        public void CheckComplexity(){} // RVA: 0x7FFE880F9CE0
        public void CheckAlignment(){} // RVA: 0x7FFE880F9D20
        public void CheckElement(){} // RVA: 0x7FFE88101C00
        public void CheckScalar(){} // RVA: 0x7FFE88101D40
        public void CheckOffset(){} // RVA: 0x7FFE88101D80
        public void CheckVectorOrString(){} // RVA: 0x7FFE88101DC0
        public void CheckString(){} // RVA: 0x7FFE88101F00
        public void CheckVector(){} // RVA: 0x7FFE88102030
        public void CheckTable(){} // RVA: 0x7FFE880FA190
        public void CheckStringFunc(){} // RVA: 0x7FFE88102040
        public void CheckVectorOfObjects(){} // RVA: 0x7FFE88102070
        public void CheckIndirectOffset(){} // RVA: 0x7FFE881021A0
        public void CheckBufferFromStart(){} // RVA: 0x7FFE88102230
        public void GetIndirectOffset(){} // RVA: 0x7FFE881024D0
        public void VerifyTableStart(){} // RVA: 0x7FFE88102580
        public void VerifyTableEnd(){} // RVA: 0x7FFE880FA910
        public void VerifyField(){} // RVA: 0x7FFE88102790
        public void VerifyString(){} // RVA: 0x7FFE88102810
        public void VerifyVectorOfData(){} // RVA: 0x7FFE881028A0
        public void VerifyVectorOfStrings(){} // RVA: 0x7FFE88102930
        public void VerifyVectorOfTables(){} // RVA: 0x7FFE88102A10
        public void VerifyTable(){} // RVA: 0x7FFE88102AA0
        public void VerifyNestedBuffer(){} // RVA: 0x7FFE88102B40
        public void VerifyUnionData(){} // RVA: 0x7FFE88102D00
        public void VerifyUnionString(){} // RVA: 0x7FFE88102D40
        public void VerifyUnion(){} // RVA: 0x7FFE88102D50
        public void VerifyVectorOfUnion(){} // RVA: 0x7FFE88102EC0
        public void VerifyBuffer(){} // RVA: 0x7FFE88103170
    }

    public class VerifyTableAction : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8401A000
        public void Invoke(){} // RVA: 0x7FFE81257370
        public void BeginInvoke(){} // RVA: 0x7FFE88101430
        public void EndInvoke(){} // RVA: 0x7FFE828C6E90
    }

    public class VerifyUnionAction : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE880F92F0
        public void Invoke(){} // RVA: 0x7FFE812574E0
        public void BeginInvoke(){} // RVA: 0x7FFE881014C0
        public void EndInvoke(){} // RVA: 0x7FFE828C6E90
    }

    public class checkElementStruct : ValueType
    {
    }

}