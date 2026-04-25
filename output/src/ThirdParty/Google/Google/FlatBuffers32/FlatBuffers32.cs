// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Google.Google.FlatBuffers32
// Classes: 17
// Methods: 258

namespace ThirdParty.Google.Google.FlatBuffers32
{
    public class ByteArrayAllocator : ByteBufferAllocator
    {
        public byte[] Span; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9D49DE0
        public void GrowFront(){} // RVA: 0x7FFAC9D520C0
        public void get_Span(){} // RVA: 0x7FFAC9D52250
        public void get_ReadOnlySpan(){} // RVA: 0x7FFAC9D522F0
        public void get_Memory(){} // RVA: 0x7FFAC9D52390
        public void get_ReadOnlyMemory(){} // RVA: 0x7FFAC9D52480
        public void InitBuffer(){} // RVA: 0x7FFAC9D4A300
    }

    public class ByteBuffer : Object
    {
        public Google.FlatBuffers32.ByteBufferAllocator Position; // 0x10
        public int Length; // 0x18
        public System.Collections.Generic.Dictionary`2<System.Type,int> genericSizes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9D526F0 | overloaded x4
        public void get_Position(){} // RVA: 0x7FFAC3157800
        public void set_Position(){} // RVA: 0x7FFAC392CD10
        public void get_Length(){} // RVA: 0x7FFAC83D27B0
        public void Reset(){} // RVA: 0x7FFAC36970B0
        public void Duplicate(){} // RVA: 0x7FFAC9D52810
        public void GrowFront(){} // RVA: 0x7FFAC88045D0
        public void ToArray(){} // RVA: 0x7FFAC9D528C0 | overloaded x2
        public void SizeOf(){} // RVA: 0x7FFAC2C59990
        public void IsSupportedType(){} // RVA: 0x7FFAC2C59D30
        public void ArraySize(){} // RVA: 0x7FFAC2E8DC40 | overloaded x3
        public void CopyToSizedArray(){} // RVA: 0x7FFAC9D52920
        public void ToSizedArray(){} // RVA: 0x7FFAC9D52C00
        public void ToFullArray(){} // RVA: 0x7FFAC9D52C60
        public void ToReadOnlyMemory(){} // RVA: 0x7FFAC9D52CC0
        public void ToMemory(){} // RVA: 0x7FFAC9D52E20
        public void ToSpan(){} // RVA: 0x7FFAC9D52F70
        public void ReverseBytes(){} // RVA: 0x7FFAC9D4AE00 | overloaded x3
        public void WriteLittleEndian(){} // RVA: 0x7FFAC9D4AE10
        public void ReadLittleEndian(){} // RVA: 0x7FFAC9D53050
        public void AssertOffsetAndLength(){} // RVA: 0x7FFAC9D53170
        public void PutSbyte(){} // RVA: 0x7FFAC9D532A0 | overloaded x2
        public void PutByte(){} // RVA: 0x7FFAC9D53350 | overloaded x2
        public void Put(){} // RVA: 0x7FFAC2E8DC40 | overloaded x5
        public void PutStringUTF8(){} // RVA: 0x7FFAC9D534B0
        public void PutShort(){} // RVA: 0x7FFAC9D535E0
        public void PutUshort(){} // RVA: 0x7FFAC9D535F0
        public void PutInt(){} // RVA: 0x7FFAC9D53730
        public void PutUint(){} // RVA: 0x7FFAC9D53740
        public void PutLong(){} // RVA: 0x7FFAC9D53880
        public void PutUlong(){} // RVA: 0x7FFAC9D53890
        public void PutFloat(){} // RVA: 0x7FFAC9D539D0
        public void PutDouble(){} // RVA: 0x7FFAC9D53AB0
        public void GetSbyte(){} // RVA: 0x7FFAC9D53B90
        public void Get(){} // RVA: 0x7FFAC9D53B90
        public void GetStringUTF8(){} // RVA: 0x7FFAC9D53C30
        public void GetShort(){} // RVA: 0x7FFAC9D53DF0
        public void GetUshort(){} // RVA: 0x7FFAC9D53E00
        public void GetInt(){} // RVA: 0x7FFAC9D53F30
        public void GetUint(){} // RVA: 0x7FFAC9D53F40
        public void GetLong(){} // RVA: 0x7FFAC9D540B0
        public void GetUlong(){} // RVA: 0x7FFAC9D540C0
        public void GetFloat(){} // RVA: 0x7FFAC9D541F0
        public void GetDouble(){} // RVA: 0x7FFAC9D542C0
        public void .cctor(){} // RVA: 0x7FFAC9D54390
    }

    public class ByteBufferAllocator : Object
    {
        public int Span; // 0x10

        // ── Methods ──
        public void get_Span(){}
        public void get_ReadOnlySpan(){}
        public void get_Memory(){} // RVA: 0x7FFAC2C588A0
        public void get_ReadOnlyMemory(){} // RVA: 0x7FFAC2C588A0
        public void get_Length(){} // RVA: 0x7FFAC2F6E5C0
        public void set_Length(){} // RVA: 0x7FFAC2F240C0
        public void GrowFront(){} // RVA: 0x7FFAC2C70ED0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ByteBufferUtil : Object
    {
        // ── Methods ──
        public void GetSizePrefix(){} // RVA: 0x7FFAC9D54B70
        public void RemoveSizePrefix(){} // RVA: 0x7FFAC9D54B90
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class FlatBufferBuilder : Object
    {
        public int ForceDefaults; // 0x10
        public Google.FlatBuffers32.ByteBuffer Offset; // 0x18
        public int Waste; // 0x20
        public int[] DataBuffer; // 0x28
        public int _vtableSize; // 0x30
        public int _objectStart; // 0x34
        public int[] _vtables; // 0x38
        public int _numVtables; // 0x40
        public int _vectorNumElems; // 0x44
        public int _waste; // 0x48
        public System.Collections.Generic.Dictionary`2<string,Google.FlatBuffers32.StringOffset> _sharedStringMap; // 0x50
        public bool <ForceDefaults>k__BackingField; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9D54EC0 | overloaded x2
        public void Clear(){} // RVA: 0x7FFAC9D55060
        public void get_ForceDefaults(){} // RVA: 0x7FFAC313F600
        public void set_ForceDefaults(){} // RVA: 0x7FFAC3892770
        public void get_Offset(){} // RVA: 0x7FFAC9D4CD90
        public void get_Waste(){} // RVA: 0x7FFAC2FC20C0
        public void Pad(){} // RVA: 0x7FFAC9D55180
        public void GrowBuffer(){} // RVA: 0x7FFAC9D4CED0
        public void Prep(){} // RVA: 0x7FFAC9D552D0
        public void PutBool(){} // RVA: 0x7FFAC9D553A0
        public void PutSbyte(){} // RVA: 0x7FFAC9D553D0
        public void PutByte(){} // RVA: 0x7FFAC9D553D0
        public void PutShort(){} // RVA: 0x7FFAC9D55400
        public void PutUshort(){} // RVA: 0x7FFAC9D55400
        public void PutInt(){} // RVA: 0x7FFAC9D55430
        public void PutUint(){} // RVA: 0x7FFAC9D55430
        public void PutLong(){} // RVA: 0x7FFAC9D55460
        public void PutUlong(){} // RVA: 0x7FFAC9D55460
        public void PutFloat(){} // RVA: 0x7FFAC9D55490
        public void Put(){} // RVA: 0x7FFAC2E8DC40 | overloaded x4
        public void PutDouble(){} // RVA: 0x7FFAC9D554C0
        public void AddBool(){} // RVA: 0x7FFAC9D55C40 | overloaded x3
        public void AddSbyte(){} // RVA: 0x7FFAC9D55D70 | overloaded x3
        public void AddByte(){} // RVA: 0x7FFAC9D55E20 | overloaded x3
        public void AddShort(){} // RVA: 0x7FFAC9D55F50 | overloaded x3
        public void AddUshort(){} // RVA: 0x7FFAC9D56080 | overloaded x3
        public void AddInt(){} // RVA: 0x7FFAC9D561B0 | overloaded x3
        public void AddUint(){} // RVA: 0x7FFAC9D56260 | overloaded x3
        public void AddLong(){} // RVA: 0x7FFAC9D56390 | overloaded x3
        public void AddUlong(){} // RVA: 0x7FFAC9D56440 | overloaded x3
        public void AddFloat(){} // RVA: 0x7FFAC9D56570 | overloaded x3
        public void Add(){} // RVA: 0x7FFAC2E8DC40 | overloaded x4
        public void AddDouble(){} // RVA: 0x7FFAC9D566A0 | overloaded x3
        public void AddOffset(){} // RVA: 0x7FFAC9D56750 | overloaded x2
        public void StartVector(){} // RVA: 0x7FFAC9D557F0
        public void EndVector(){} // RVA: 0x7FFAC9D558A0
        public void CreateVectorOfTables(){} // RVA: 0x7FFAC2E8DC40
        public void Nested(){} // RVA: 0x7FFAC9D558F0
        public void NotNested(){} // RVA: 0x7FFAC9D55970
        public void StartTable(){} // RVA: 0x7FFAC9D559E0
        public void Slot(){} // RVA: 0x7FFAC9D55B10
        public void CreateString(){} // RVA: 0x7FFAC9D56790
        public void CreateUTF8String(){} // RVA: 0x7FFAC9D569B0
        public void CreateSharedString(){} // RVA: 0x7FFAC9D56B10
        public void AddStruct(){} // RVA: 0x7FFAC9D56DA0
        public void EndTable(){} // RVA: 0x7FFAC9D56E30
        public void Required(){} // RVA: 0x7FFAC9D573A0
        public void Finish(){} // RVA: 0x7FFAC9D578A0 | overloaded x4
        public void FinishSizePrefixed(){} // RVA: 0x7FFAC9D578C0 | overloaded x2
        public void get_DataBuffer(){} // RVA: 0x7FFAC2F247C0
        public void SizedByteArray(){} // RVA: 0x7FFAC9D57660
    }

    public class FlatBufferConstants : Object
    {
        public int FileIdentifierLength;
        public int SizePrefixLength;

        // ── Methods ──
        public void FLATBUFFERS_24_3_7(){} // RVA: 0x7FFAC2F21310
    }

    public class IFlatbufferObject
    {
        public object ByteBuffer;

        // ── Methods ──
        public void __init(){} // RVA: 0x7FFAC2C72BC0
        public void get_ByteBuffer(){} // RVA: 0x7FFAC2C58E90
    }

    public class Offset`1 : ValueType
    {
        public int Value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70ED0
    }

    public class Options : Object
    {
        public int maxDepth;
        public int maxTables;
        public int stringEndCheck; // 0x10
        public int alignmentCheck; // 0x14
        public bool string_end_check; // 0x18
        public bool alignment_check; // 0x19

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9D4F7F0 | overloaded x2
        public void get_maxDepth(){} // RVA: 0x7FFAC2F6E5C0
        public void set_maxDepth(){} // RVA: 0x7FFAC2F240C0
        public void get_maxTables(){} // RVA: 0x7FFAC33D5A20
        public void set_maxTables(){} // RVA: 0x7FFAC33D4990
        public void get_stringEndCheck(){} // RVA: 0x7FFAC2F3C4E0
        public void set_stringEndCheck(){} // RVA: 0x7FFAC2F3C4F0
        public void get_alignmentCheck(){} // RVA: 0x7FFAC3228D50
        public void set_alignmentCheck(){} // RVA: 0x7FFAC3515120
    }

    public class StringOffset : ValueType
    {
        public int Value; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC336D8B0
    }

    public class Struct : ValueType
    {
        public int bb_pos; // 0x10
        public Google.FlatBuffers32.ByteBuffer bb; // 0x18

        // ── Methods ──
        public void get_bb_pos(){} // RVA: 0x7FFAC4420210
        public void set_bb_pos(){} // RVA: 0x7FFAC336D8B0
        public void get_bb(){} // RVA: 0x7FFAC4420220
        public void set_bb(){} // RVA: 0x7FFAC4420240
        public void .ctor(){} // RVA: 0x7FFAC9D51A70
    }

    public class Table : ValueType
    {
        public int bb_pos; // 0x10
        public Google.FlatBuffers32.ByteBuffer bb; // 0x18

        // ── Methods ──
        public void get_bb_pos(){} // RVA: 0x7FFAC4420210
        public void set_bb_pos(){} // RVA: 0x7FFAC336D8B0
        public void get_bb(){} // RVA: 0x7FFAC4420220
        public void set_bb(){} // RVA: 0x7FFAC4420240
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void .ctor(){} // RVA: 0x7FFAC9D51A70
        public void __offset(){} // RVA: 0x7FFAC9D597A0 | overloaded x2
        public void __indirect(){} // RVA: 0x7FFAC9D59830 | overloaded x2
        public void __string(){} // RVA: 0x7FFAC9D59860
        public void __vector_len(){} // RVA: 0x7FFAC9D598D0
        public void __vector(){} // RVA: 0x7FFAC9D59920
        public void __vector_as_span(){} // RVA: 0x7FFAC2E8DC40
        public void __vector_as_array(){} // RVA: 0x7FFAC2C67DE0
        public void __union(){} // RVA: 0x7FFAC2E8DC40
        public void __has_identifier(){} // RVA: 0x7FFAC9D59950
        public void CompareStrings(){} // RVA: 0x7FFAC9D59BB0 | overloaded x2
    }

    public class VectorOffset : ValueType
    {
        public int Value; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC336D8B0
    }

    public class Verifier : Object
    {
        public Google.FlatBuffers32.ByteBuffer Buf; // 0x10
        public Google.FlatBuffers32.Options options; // 0x18
        public int depth; // 0x20
        public int numTables; // 0x24
        public int SIZE_BYTE;
        public int SIZE_INT;
        public int SIZE_U_OFFSET;
        public int SIZE_S_OFFSET;
        public int SIZE_V_OFFSET;
        public int SIZE_PREFIX_LENGTH;
        public int FLATBUFFERS_MAX_BUFFER_SIZE;
        public int FILE_IDENTIFIER_LENGTH;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9D57A20 | overloaded x2
        public void get_Buf(){} // RVA: 0x7FFAC2F3C380
        public void set_Buf(){} // RVA: 0x7FFAC2F22E30
        public void get_options(){} // RVA: 0x7FFAC2F247C0
        public void set_options(){} // RVA: 0x7FFAC2F87E80
        public void get_depth(){} // RVA: 0x7FFAC30DBBE0
        public void set_depth(){} // RVA: 0x7FFAC35DB7A0
        public void get_numTables(){} // RVA: 0x7FFAC3921980
        public void set_numTables(){} // RVA: 0x7FFAC41674D0
        public void SetMaxDepth(){} // RVA: 0x7FFAC9D4FCA0
        public void SetMaxTables(){} // RVA: 0x7FFAC9D4FCC0
        public void SetAlignmentCheck(){} // RVA: 0x7FFAC9D4FCE0
        public void SetStringCheck(){} // RVA: 0x7FFAC9D4FD00
        public void BufferHasIdentifier(){} // RVA: 0x7FFAC9D57B40
        public void ReadUOffsetT(){} // RVA: 0x7FFAC9D57D10
        public void ReadSOffsetT(){} // RVA: 0x7FFAC9D57DC0
        public void ReadVOffsetT(){} // RVA: 0x7FFAC9D57DF0
        public void GetVRelOffset(){} // RVA: 0x7FFAC9D57E20
        public void GetVOffset(){} // RVA: 0x7FFAC9D57F80
        public void CheckComplexity(){} // RVA: 0x7FFAC9D50290
        public void CheckAlignment(){} // RVA: 0x7FFAC9D502D0
        public void CheckElement(){} // RVA: 0x7FFAC9D580B0
        public void CheckScalar(){} // RVA: 0x7FFAC9D581F0
        public void CheckOffset(){} // RVA: 0x7FFAC9D58230
        public void CheckVectorOrString(){} // RVA: 0x7FFAC9D58270
        public void CheckString(){} // RVA: 0x7FFAC9D583B0
        public void CheckVector(){} // RVA: 0x7FFAC9D584E0
        public void CheckTable(){} // RVA: 0x7FFAC9D50740
        public void CheckStringFunc(){} // RVA: 0x7FFAC9D584F0
        public void CheckVectorOfObjects(){} // RVA: 0x7FFAC9D58520
        public void CheckIndirectOffset(){} // RVA: 0x7FFAC9D58650
        public void CheckBufferFromStart(){} // RVA: 0x7FFAC9D586E0
        public void GetIndirectOffset(){} // RVA: 0x7FFAC9D58980
        public void VerifyTableStart(){} // RVA: 0x7FFAC9D58A30
        public void VerifyTableEnd(){} // RVA: 0x7FFAC9D50EC0
        public void VerifyField(){} // RVA: 0x7FFAC9D58C40
        public void VerifyString(){} // RVA: 0x7FFAC9D58CC0
        public void VerifyVectorOfData(){} // RVA: 0x7FFAC9D58D50
        public void VerifyVectorOfStrings(){} // RVA: 0x7FFAC9D58DE0
        public void VerifyVectorOfTables(){} // RVA: 0x7FFAC9D58EC0
        public void VerifyTable(){} // RVA: 0x7FFAC9D58F50
        public void VerifyNestedBuffer(){} // RVA: 0x7FFAC9D58FF0
        public void VerifyUnionData(){} // RVA: 0x7FFAC9D591B0
        public void VerifyUnionString(){} // RVA: 0x7FFAC9D591F0
        public void VerifyUnion(){} // RVA: 0x7FFAC9D59200
        public void VerifyVectorOfUnion(){} // RVA: 0x7FFAC9D59370
        public void VerifyBuffer(){} // RVA: 0x7FFAC9D59620
    }

    public class VerifyTableAction : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC5CBBBC0
        public void Invoke(){} // RVA: 0x7FFAC307D370
        public void BeginInvoke(){} // RVA: 0x7FFAC9D578E0
        public void EndInvoke(){} // RVA: 0x7FFAC3AE3450
    }

    public class VerifyUnionAction : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9D4F8A0
        public void Invoke(){} // RVA: 0x7FFAC307D4E0
        public void BeginInvoke(){} // RVA: 0x7FFAC9D57970
        public void EndInvoke(){} // RVA: 0x7FFAC3AE3450
    }

    public class checkElementStruct : ValueType
    {
        public bool elementValid; // 0x10
        public uint elementOffset; // 0x14
    }

}