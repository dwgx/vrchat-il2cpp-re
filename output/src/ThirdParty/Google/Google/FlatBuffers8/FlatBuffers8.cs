// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Google.Google.FlatBuffers8
// Classes: 20
// Methods: 209

namespace ThirdParty.Google.Google.FlatBuffers8
{
    public class ByteArrayAllocator : ByteBufferAllocator
    {
        public object _buffer;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x81EC640
        public void GrowFront(){} // RVA: 0x81EC6B0
        public void get_Span(){} // RVA: 0x81EC840
        public void get_ReadOnlySpan(){} // RVA: 0x81EC8E0
        public void get_Memory(){} // RVA: 0x81EC980
        public void get_ReadOnlyMemory(){} // RVA: 0x81ECA70
        public void InitBuffer(){} // RVA: 0x81ECB60
    }

    public class ByteBuffer : Object
    {
        public object _buffer;
        public object _pos;
        public object genericSizes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x81ECD00
        public void get_Position(){} // RVA: 0xE62D00
        public void set_Position(){} // RVA: 0x1033F40
        public void get_Length(){} // RVA: 0x66B3620
        public void Reset(){} // RVA: 0x1320080
        public void Duplicate(){} // RVA: 0x81ECE20
        public void GrowFront(){} // RVA: 0x6AE0800
        public void ToArray(){} // RVA: 0x88C530
        public void SizeOf(){} // RVA: 0x87CFE0
        public void IsSupportedType(){} // RVA: 0x87D2E0
        public void ArraySize(){} // RVA: 0xA94080
        public void CopyToSizedArray(){} // RVA: 0x81ECF30
        public void ToSizedArray(){} // RVA: 0x81ED210
        public void ToFullArray(){} // RVA: 0x81ED270
        public void ToReadOnlyMemory(){} // RVA: 0x81ED2D0
        public void ToMemory(){} // RVA: 0x81ED440
        public void ToSpan(){} // RVA: 0x81ED5A0
        public void ReverseBytes(){} // RVA: 0x81ED680
        public void WriteLittleEndian(){} // RVA: 0x81ED690
        public void ReadLittleEndian(){} // RVA: 0x81ED750
        public void AssertOffsetAndLength(){} // RVA: 0x81ED810
        public void PutSbyte(){} // RVA: 0x81EDA80
        public void PutByte(){} // RVA: 0x81EDB00
        public void Put(){} // RVA: 0xA94080
        public void PutStringUTF8(){} // RVA: 0x81EDC10
        public void PutShort(){} // RVA: 0x81EDD00
        public void PutUshort(){} // RVA: 0x81EDD10
        public void PutInt(){} // RVA: 0x81EDE10
        public void PutUint(){} // RVA: 0x81EDE20
        public void PutLong(){} // RVA: 0x81EDF20
        public void PutUlong(){} // RVA: 0x81EDF30
        public void PutFloat(){} // RVA: 0x81EE030
        public void PutDouble(){} // RVA: 0x81EE0D0
        public void GetSbyte(){} // RVA: 0x81EE170
        public void Get(){} // RVA: 0x81EE170
        public void GetStringUTF8(){} // RVA: 0x81EE1E0
        public void GetShort(){} // RVA: 0x81EE3A0
        public void GetUshort(){} // RVA: 0x81EE3B0
        public void GetInt(){} // RVA: 0x81EE4A0
        public void GetUint(){} // RVA: 0x81EE4B0
        public void GetLong(){} // RVA: 0x81EE5A0
        public void GetUlong(){} // RVA: 0x81EE5B0
        public void GetFloat(){} // RVA: 0x81EE6A0
        public void GetDouble(){} // RVA: 0x81EE730
        public void .cctor(){} // RVA: 0x81EE7C0
    }

    public class ByteBufferAllocator : Object
    {
        public object _length;

        // ── Methods ──
        public void get_Span(){} // RVA: 0x87BEB0
        public void get_ReadOnlySpan(){} // RVA: 0x87BEB0
        public void get_Memory(){} // RVA: 0x87BEB0
        public void get_ReadOnlyMemory(){} // RVA: 0x87BEB0
        public void get_Length(){} // RVA: 0xB8F8F0
        public void set_Length(){} // RVA: 0xB460A0
        public void GrowFront(){} // RVA: 0x8944F0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ByteBufferUtil : Object
    {
        // ── Methods ──
        public void GetSizePrefix(){} // RVA: 0x81EED80
        public void RemoveSizePrefix(){} // RVA: 0x81EEDB0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class FlatBufferBuilder : Object
    {
        public object _space;
        public object _bb;
        public object _minAlign;
        public object _vtable;
        public object _vtableSize;
        public object _objectStart;
        public object _vtables;
        public object _numVtables;
        public object _vectorNumElems;
        public object _waste;
        public object _sharedStringMap;
        public object _forceDefaults;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x81EF0E0
        public void Clear(){} // RVA: 0x81EF280
        public void get_ForceDefaults(){} // RVA: 0xE3F480
        public void set_ForceDefaults(){} // RVA: 0x1546550
        public void get_Offset(){} // RVA: 0x81EF3A0
        public void get_Waste(){} // RVA: 0xBE5890
        public void Pad(){} // RVA: 0x81EF3D0
        public void GrowBuffer(){} // RVA: 0x81EF4E0
        public void Prep(){} // RVA: 0x81EF520
        public void PutBool(){} // RVA: 0x81EF6E0
        public void PutSbyte(){} // RVA: 0x81EF710
        public void PutByte(){} // RVA: 0x81EF710
        public void PutShort(){} // RVA: 0x81EF740
        public void PutUshort(){} // RVA: 0x81EF740
        public void PutInt(){} // RVA: 0x81EF770
        public void PutUint(){} // RVA: 0x81EF770
        public void PutLong(){} // RVA: 0x81EF7A0
        public void PutUlong(){} // RVA: 0x81EF7A0
        public void PutFloat(){} // RVA: 0x81EF7D0
        public void Put(){} // RVA: 0xA94080
        public void PutDouble(){} // RVA: 0x81EF890
        public void AddBool(){} // RVA: 0x81F02C0
        public void AddSbyte(){} // RVA: 0x81F03F0
        public void AddByte(){} // RVA: 0x81F04A0
        public void AddShort(){} // RVA: 0x81F05D0
        public void AddUshort(){} // RVA: 0x81F0700
        public void AddInt(){} // RVA: 0x81F0830
        public void AddUint(){} // RVA: 0x81F08E0
        public void AddLong(){} // RVA: 0x81F0A10
        public void AddUlong(){} // RVA: 0x81F0AC0
        public void AddFloat(){} // RVA: 0x81F0BE0
        public void Add(){} // RVA: 0xA94080
        public void AddDouble(){} // RVA: 0x81F0CE0
        public void AddOffset(){} // RVA: 0x81F0D70
        public void StartVector(){} // RVA: 0x81EFCF0
        public void EndVector(){} // RVA: 0x81EFE40
        public void CreateVectorOfTables(){} // RVA: 0xA94080
        public void Nested(){} // RVA: 0x81EFF70
        public void NotNested(){} // RVA: 0x81EFFF0
        public void StartTable(){} // RVA: 0x81F0060
        public void Slot(){} // RVA: 0x81F0190
        public void CreateString(){} // RVA: 0x81F0DB0
        public void CreateUTF8String(){} // RVA: 0x81F0F60
        public void CreateSharedString(){} // RVA: 0x81F1090
        public void AddStruct(){} // RVA: 0x81F1320
        public void EndTable(){} // RVA: 0x81F13B0
        public void Required(){} // RVA: 0x81F19D0
        public void Finish(){} // RVA: 0x81F1E60
        public void FinishSizePrefixed(){} // RVA: 0x81F1E80
        public void get_DataBuffer(){} // RVA: 0xB465B0
        public void SizedByteArray(){} // RVA: 0x81F1C40
    }

    public class FlatBufferConstants : Object
    {
        public object FileIdentifierLength;
        public object SizePrefixLength;

        // ── Methods ──
        public void FLATBUFFERS_24_3_7(){} // RVA: 0xB43310
    }

    public class IFlatbufferObject
    {
        // ── Methods ──
        public void __init(){} // RVA: 0x895750
        public void get_ByteBuffer(){} // RVA: 0x87C0A0
    }

    public class Offset`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x475840
    }

    public class Offset`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x475840
    }

    public class Offset`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x475840
    }

    public class Offset`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x475840
    }

    public class Offset`1 : ValueType
    {
        public object Value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8944F0
    }

    public class Options : Object
    {
        public object DEFAULT_MAX_DEPTH;
        public object DEFAULT_MAX_TABLES;
        public object max_depth;
        public object max_tables;
        public object string_end_check;
        public object alignment_check;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x81F1EC0
        public void get_maxDepth(){} // RVA: 0xB8F8F0
        public void set_maxDepth(){} // RVA: 0xB460A0
        public void get_maxTables(){} // RVA: 0x116A650
        public void set_maxTables(){} // RVA: 0x116BB10
        public void get_stringEndCheck(){} // RVA: 0xB5DD50
        public void set_stringEndCheck(){} // RVA: 0xB5DD60
        public void get_alignmentCheck(){} // RVA: 0xF43F30
        public void set_alignmentCheck(){} // RVA: 0x17F4D80
    }

    public class StringOffset : ValueType
    {
        public object Value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9B3870
    }

    public class Struct : ValueType
    {
        public object _bb_pos;
        public object _bb;

        // ── Methods ──
        public void get_bb_pos(){} // RVA: 0x77E60
        public void set_bb_pos(){} // RVA: 0x29580
        public void get_bb(){} // RVA: 0x77ED0
        public void set_bb(){} // RVA: 0x77E70
        public void .ctor(){} // RVA: 0x9B39F0
    }

    public class Table : ValueType
    {
        public object _bb_pos;
        public object _bb;

        // ── Methods ──
        public void get_bb_pos(){} // RVA: 0x77E60
        public void set_bb_pos(){} // RVA: 0x29580
        public void get_bb(){} // RVA: 0x77ED0
        public void set_bb(){} // RVA: 0x77E70
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void .ctor(){} // RVA: 0x9B39F0
        public void __offset(){} // RVA: 0x81F4160
        public void __indirect(){} // RVA: 0x81F4200
        public void __string(){} // RVA: 0x9B3B00
        public void __vector_len(){} // RVA: 0x9B3B10
        public void __vector(){} // RVA: 0x9B3B60
        public void __vector_as_span(){} // RVA: 0xA94080
        public void __vector_as_array(){} // RVA: 0x87C160
        public void __union(){} // RVA: 0xA94080
        public void __has_identifier(){} // RVA: 0x81F4330
        public void CompareStrings(){} // RVA: 0x81F4590
    }

    public class VectorOffset : ValueType
    {
        public object Value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9B38D0
    }

    public class Verifier : Object
    {
        public object verifier_buffer;
        public object verifier_options;
        public object depth_cnt;
        public object num_tables_cnt;
        public object SIZE_BYTE;
        public object SIZE_INT;
        public object SIZE_U_OFFSET;
        public object SIZE_S_OFFSET;
        public object SIZE_V_OFFSET;
        public object SIZE_PREFIX_LENGTH;
        public object FLATBUFFERS_MAX_BUFFER_SIZE;
        public object FILE_IDENTIFIER_LENGTH;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x81F2170
        public void get_Buf(){} // RVA: 0xB5DBF0
        public void set_Buf(){} // RVA: 0xB44D60
        public void get_options(){} // RVA: 0xB465B0
        public void set_options(){} // RVA: 0xBA9BA0
        public void get_depth(){} // RVA: 0xFEAE90
        public void set_depth(){} // RVA: 0x1269760
        public void get_numTables(){} // RVA: 0x15AF000
        public void set_numTables(){} // RVA: 0x1FAA840
        public void SetMaxDepth(){} // RVA: 0x81F2290
        public void SetMaxTables(){} // RVA: 0x81F22B0
        public void SetAlignmentCheck(){} // RVA: 0x81F22D0
        public void SetStringCheck(){} // RVA: 0x81F22F0
        public void BufferHasIdentifier(){} // RVA: 0x81F2310
        public void ReadUOffsetT(){} // RVA: 0x81F24E0
        public void ReadSOffsetT(){} // RVA: 0x81F2590
        public void ReadVOffsetT(){} // RVA: 0x81F25C0
        public void GetVRelOffset(){} // RVA: 0x81F25F0
        public void GetVOffset(){} // RVA: 0x81F2750
        public void CheckComplexity(){} // RVA: 0x81F2880
        public void CheckAlignment(){} // RVA: 0x81F28C0
        public void CheckElement(){} // RVA: 0x81F28F0
        public void CheckScalar(){} // RVA: 0x81F2A30
        public void CheckOffset(){} // RVA: 0x81F2A70
        public void CheckVectorOrString(){} // RVA: 0x81F2AB0
        public void CheckString(){} // RVA: 0x81F2BF0
        public void CheckVector(){} // RVA: 0x81F2D20
        public void CheckTable(){} // RVA: 0x81F2D30
        public void CheckStringFunc(){} // RVA: 0x81F2D60
        public void CheckVectorOfObjects(){} // RVA: 0x81F2D90
        public void CheckIndirectOffset(){} // RVA: 0x81F2EC0
        public void CheckBufferFromStart(){} // RVA: 0x81F2F50
        public void GetIndirectOffset(){} // RVA: 0x81F31F0
        public void VerifyTableStart(){} // RVA: 0x81F32A0
        public void VerifyTableEnd(){} // RVA: 0x81F34B0
        public void VerifyField(){} // RVA: 0x81F34C0
        public void VerifyString(){} // RVA: 0x81F3540
        public void VerifyVectorOfData(){} // RVA: 0x81F35D0
        public void VerifyVectorOfStrings(){} // RVA: 0x81F3660
        public void VerifyVectorOfTables(){} // RVA: 0x81F3740
        public void VerifyTable(){} // RVA: 0x81F37D0
        public void VerifyNestedBuffer(){} // RVA: 0x81F3870
        public void VerifyUnionData(){} // RVA: 0x81F3A60
        public void VerifyUnionString(){} // RVA: 0x81F3AA0
        public void VerifyUnion(){} // RVA: 0x81F3AB0
        public void VerifyVectorOfUnion(){} // RVA: 0x81F3C20
        public void VerifyBuffer(){} // RVA: 0x81F3ED0
    }

    public class VerifyTableAction : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3E394E0
        public void Invoke(){} // RVA: 0xCA8BF0
        public void BeginInvoke(){} // RVA: 0x6C4E590
        public void EndInvoke(){} // RVA: 0x2404860
    }

    public class VerifyUnionAction : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x81F1EE0
        public void Invoke(){} // RVA: 0xCA8D60
        public void BeginInvoke(){} // RVA: 0x81F2050
        public void EndInvoke(){} // RVA: 0x2404860
    }

}