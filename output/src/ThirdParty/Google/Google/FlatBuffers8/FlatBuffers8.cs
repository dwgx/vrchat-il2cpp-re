// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Google.Google.FlatBuffers8
// Classes: 17
// Methods: 259

namespace ThirdParty.Google.Google.FlatBuffers8
{
    public class ByteArrayAllocator : ByteBufferAllocator
    {
        public byte[] Span; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9D49DE0
        public void GrowFront(){} // RVA: 0x7FFAC9D49E50
        public void get_Span(){} // RVA: 0x7FFAC9D49FE0
        public void get_ReadOnlySpan(){} // RVA: 0x7FFAC9D4A080
        public void get_Memory(){} // RVA: 0x7FFAC9D4A120
        public void get_ReadOnlyMemory(){} // RVA: 0x7FFAC9D4A210
        public void InitBuffer(){} // RVA: 0x7FFAC9D4A300
    }

    public class ByteBuffer : Object
    {
        public Google.FlatBuffers8.ByteBufferAllocator Position; // 0x10
        public int Length; // 0x18
        public System.Collections.Generic.Dictionary`2<System.Type,int> genericSizes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9D4A4A0 | overloaded x4
        public void get_Position(){} // RVA: 0x7FFAC3157800
        public void set_Position(){} // RVA: 0x7FFAC392CD10
        public void get_Length(){} // RVA: 0x7FFAC83D27B0
        public void Reset(){} // RVA: 0x7FFAC36970B0
        public void Duplicate(){} // RVA: 0x7FFAC9D4A5C0
        public void GrowFront(){} // RVA: 0x7FFAC88045D0
        public void ToArray(){} // RVA: 0x7FFAC9D4A670 | overloaded x2
        public void SizeOf(){} // RVA: 0x7FFAC2C59990
        public void IsSupportedType(){} // RVA: 0x7FFAC2C59D30
        public void ArraySize(){} // RVA: 0x7FFAC2E8DC40 | overloaded x3
        public void CopyToSizedArray(){} // RVA: 0x7FFAC9D4A6D0
        public void ToSizedArray(){} // RVA: 0x7FFAC9D4A9B0
        public void ToFullArray(){} // RVA: 0x7FFAC9D4AA10
        public void ToReadOnlyMemory(){} // RVA: 0x7FFAC9D4AA70
        public void ToMemory(){} // RVA: 0x7FFAC9D4ABD0
        public void ToSpan(){} // RVA: 0x7FFAC9D4AD20
        public void ReverseBytes(){} // RVA: 0x7FFAC9D4AE00 | overloaded x3
        public void WriteLittleEndian(){} // RVA: 0x7FFAC9D4AE10
        public void ReadLittleEndian(){} // RVA: 0x7FFAC9D4AED0
        public void AssertOffsetAndLength(){} // RVA: 0x7FFAC9D4AF90
        public void PutSbyte(){} // RVA: 0x7FFAC9D4B220 | overloaded x2
        public void PutByte(){} // RVA: 0x7FFAC9D4B2A0 | overloaded x2
        public void Put(){} // RVA: 0x7FFAC2E8DC40 | overloaded x5
        public void PutStringUTF8(){} // RVA: 0x7FFAC9D4B3B0
        public void PutShort(){} // RVA: 0x7FFAC9D4B490
        public void PutUshort(){} // RVA: 0x7FFAC9D4B4A0
        public void PutInt(){} // RVA: 0x7FFAC9D4B5A0
        public void PutUint(){} // RVA: 0x7FFAC9D4B5B0
        public void PutLong(){} // RVA: 0x7FFAC9D4B6B0
        public void PutUlong(){} // RVA: 0x7FFAC9D4B6C0
        public void PutFloat(){} // RVA: 0x7FFAC9D4B7C0
        public void PutDouble(){} // RVA: 0x7FFAC9D4B860
        public void GetSbyte(){} // RVA: 0x7FFAC9D4B900
        public void Get(){} // RVA: 0x7FFAC9D4B900
        public void GetStringUTF8(){} // RVA: 0x7FFAC9D4B970
        public void GetShort(){} // RVA: 0x7FFAC9D4BB30
        public void GetUshort(){} // RVA: 0x7FFAC9D4BB40
        public void GetInt(){} // RVA: 0x7FFAC9D4BC30
        public void GetUint(){} // RVA: 0x7FFAC9D4BC40
        public void GetLong(){} // RVA: 0x7FFAC9D4BD70
        public void GetUlong(){} // RVA: 0x7FFAC9D4BD80
        public void GetFloat(){} // RVA: 0x7FFAC9D4BE70
        public void GetDouble(){} // RVA: 0x7FFAC9D4BF00
        public void .cctor(){} // RVA: 0x7FFAC9D4BF90
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
        public void GetSizePrefix(){} // RVA: 0x7FFAC9D4C770
        public void RemoveSizePrefix(){} // RVA: 0x7FFAC9D4C7A0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class FlatBufferBuilder : Object
    {
        public int ForceDefaults; // 0x10
        public Google.FlatBuffers8.ByteBuffer Offset; // 0x18
        public int Waste; // 0x20
        public int[] DataBuffer; // 0x28
        public int _vtableSize; // 0x30
        public int _objectStart; // 0x34
        public int[] _vtables; // 0x38
        public int _numVtables; // 0x40
        public int _vectorNumElems; // 0x44
        public int _waste; // 0x48
        public System.Collections.Generic.Dictionary`2<string,Google.FlatBuffers8.StringOffset> _sharedStringMap; // 0x50
        public bool <ForceDefaults>k__BackingField; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9D4CAD0 | overloaded x2
        public void Clear(){} // RVA: 0x7FFAC9D4CC70
        public void get_ForceDefaults(){} // RVA: 0x7FFAC313F600
        public void set_ForceDefaults(){} // RVA: 0x7FFAC3892770
        public void get_Offset(){} // RVA: 0x7FFAC9D4CD90
        public void get_Waste(){} // RVA: 0x7FFAC2FC20C0
        public void Pad(){} // RVA: 0x7FFAC9D4CDC0
        public void GrowBuffer(){} // RVA: 0x7FFAC9D4CED0
        public void Prep(){} // RVA: 0x7FFAC9D4CF10
        public void PutBool(){} // RVA: 0x7FFAC9D4D0D0
        public void PutSbyte(){} // RVA: 0x7FFAC9D4D100
        public void PutByte(){} // RVA: 0x7FFAC9D4D100
        public void PutShort(){} // RVA: 0x7FFAC9D4D130
        public void PutUshort(){} // RVA: 0x7FFAC9D4D130
        public void PutInt(){} // RVA: 0x7FFAC9D4D160
        public void PutUint(){} // RVA: 0x7FFAC9D4D160
        public void PutLong(){} // RVA: 0x7FFAC9D4D190
        public void PutUlong(){} // RVA: 0x7FFAC9D4D190
        public void PutFloat(){} // RVA: 0x7FFAC9D4D1C0
        public void Put(){} // RVA: 0x7FFAC2E8DC40 | overloaded x4
        public void PutDouble(){} // RVA: 0x7FFAC9D4D1F0
        public void AddBool(){} // RVA: 0x7FFAC9D4DBB0 | overloaded x3
        public void AddSbyte(){} // RVA: 0x7FFAC9D4DCE0 | overloaded x3
        public void AddByte(){} // RVA: 0x7FFAC9D4DD90 | overloaded x4
        public void AddShort(){} // RVA: 0x7FFAC9D4DEC0 | overloaded x3
        public void AddUshort(){} // RVA: 0x7FFAC9D4DFF0 | overloaded x3
        public void AddInt(){} // RVA: 0x7FFAC9D4E120 | overloaded x3
        public void AddUint(){} // RVA: 0x7FFAC9D4E1D0 | overloaded x3
        public void AddLong(){} // RVA: 0x7FFAC9D4E300 | overloaded x3
        public void AddUlong(){} // RVA: 0x7FFAC9D4E3B0 | overloaded x3
        public void AddFloat(){} // RVA: 0x7FFAC9D4E4E0 | overloaded x3
        public void Add(){} // RVA: 0x7FFAC2E8DC40 | overloaded x4
        public void AddDouble(){} // RVA: 0x7FFAC9D4E610 | overloaded x3
        public void AddOffset(){} // RVA: 0x7FFAC9D4E6C0 | overloaded x2
        public void StartVector(){} // RVA: 0x7FFAC9D4D5E0
        public void EndVector(){} // RVA: 0x7FFAC9D4D730
        public void CreateVectorOfTables(){} // RVA: 0x7FFAC2E8DC40
        public void Nested(){} // RVA: 0x7FFAC9D4D860
        public void NotNested(){} // RVA: 0x7FFAC9D4D8E0
        public void StartTable(){} // RVA: 0x7FFAC9D4D950
        public void Slot(){} // RVA: 0x7FFAC9D4DA80
        public void CreateString(){} // RVA: 0x7FFAC9D4E700
        public void CreateUTF8String(){} // RVA: 0x7FFAC9D4E8B0
        public void CreateSharedString(){} // RVA: 0x7FFAC9D4E9E0
        public void AddStruct(){} // RVA: 0x7FFAC9D4EC70
        public void EndTable(){} // RVA: 0x7FFAC9D4ED00
        public void Required(){} // RVA: 0x7FFAC9D4F310
        public void Finish(){} // RVA: 0x7FFAC9D4F790 | overloaded x4
        public void FinishSizePrefixed(){} // RVA: 0x7FFAC9D4F7B0 | overloaded x2
        public void get_DataBuffer(){} // RVA: 0x7FFAC2F247C0
        public void SizedByteArray(){} // RVA: 0x7FFAC9D4F580
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
        public byte Value;

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
        public byte Value; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9D519B0
    }

    public class Struct : ValueType
    {
        public int bb_pos; // 0x10
        public Google.FlatBuffers8.ByteBuffer bb; // 0x18

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
        public Google.FlatBuffers8.ByteBuffer bb; // 0x18

        // ── Methods ──
        public void get_bb_pos(){} // RVA: 0x7FFAC4420210
        public void set_bb_pos(){} // RVA: 0x7FFAC336D8B0
        public void get_bb(){} // RVA: 0x7FFAC4420220
        public void set_bb(){} // RVA: 0x7FFAC4420240
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void .ctor(){} // RVA: 0x7FFAC9D51A70
        public void __offset(){} // RVA: 0x7FFAC9D51B70 | overloaded x2
        public void __indirect(){} // RVA: 0x7FFAC9D51C10 | overloaded x2
        public void __string(){} // RVA: 0x7FFAC9D51C40
        public void __vector_len(){} // RVA: 0x7FFAC9D51CC0
        public void __vector(){} // RVA: 0x7FFAC9D51D10
        public void __vector_as_span(){} // RVA: 0x7FFAC2E8DC40
        public void __vector_as_array(){} // RVA: 0x7FFAC2C67DE0
        public void __union(){} // RVA: 0x7FFAC2E8DC40
        public void __has_identifier(){} // RVA: 0x7FFAC9D51D40
        public void CompareStrings(){} // RVA: 0x7FFAC9D51FA0 | overloaded x2
    }

    public class VectorOffset : ValueType
    {
        public byte Value; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9D51A10
    }

    public class Verifier : Object
    {
        public Google.FlatBuffers8.ByteBuffer Buf; // 0x10
        public Google.FlatBuffers8.Options options; // 0x18
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
        public void .ctor(){} // RVA: 0x7FFAC9D4FB80 | overloaded x2
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
        public void BufferHasIdentifier(){} // RVA: 0x7FFAC9D4FD20
        public void ReadUOffsetT(){} // RVA: 0x7FFAC9D4FEF0
        public void ReadSOffsetT(){} // RVA: 0x7FFAC9D4FFA0
        public void ReadVOffsetT(){} // RVA: 0x7FFAC9D4FFD0
        public void GetVRelOffset(){} // RVA: 0x7FFAC9D50000
        public void GetVOffset(){} // RVA: 0x7FFAC9D50160
        public void CheckComplexity(){} // RVA: 0x7FFAC9D50290
        public void CheckAlignment(){} // RVA: 0x7FFAC9D502D0
        public void CheckElement(){} // RVA: 0x7FFAC9D50300
        public void CheckScalar(){} // RVA: 0x7FFAC9D50440
        public void CheckOffset(){} // RVA: 0x7FFAC9D50480
        public void CheckVectorOrString(){} // RVA: 0x7FFAC9D504C0
        public void CheckString(){} // RVA: 0x7FFAC9D50600
        public void CheckVector(){} // RVA: 0x7FFAC9D50730
        public void CheckTable(){} // RVA: 0x7FFAC9D50740
        public void CheckStringFunc(){} // RVA: 0x7FFAC9D50770
        public void CheckVectorOfObjects(){} // RVA: 0x7FFAC9D507A0
        public void CheckIndirectOffset(){} // RVA: 0x7FFAC9D508D0
        public void CheckBufferFromStart(){} // RVA: 0x7FFAC9D50960
        public void GetIndirectOffset(){} // RVA: 0x7FFAC9D50C00
        public void VerifyTableStart(){} // RVA: 0x7FFAC9D50CB0
        public void VerifyTableEnd(){} // RVA: 0x7FFAC9D50EC0
        public void VerifyField(){} // RVA: 0x7FFAC9D50ED0
        public void VerifyString(){} // RVA: 0x7FFAC9D50F50
        public void VerifyVectorOfData(){} // RVA: 0x7FFAC9D50FE0
        public void VerifyVectorOfStrings(){} // RVA: 0x7FFAC9D51070
        public void VerifyVectorOfTables(){} // RVA: 0x7FFAC9D51150
        public void VerifyTable(){} // RVA: 0x7FFAC9D511E0
        public void VerifyNestedBuffer(){} // RVA: 0x7FFAC9D51280
        public void VerifyUnionData(){} // RVA: 0x7FFAC9D51470
        public void VerifyUnionString(){} // RVA: 0x7FFAC9D514B0
        public void VerifyUnion(){} // RVA: 0x7FFAC9D514C0
        public void VerifyVectorOfUnion(){} // RVA: 0x7FFAC9D51630
        public void VerifyBuffer(){} // RVA: 0x7FFAC9D518E0
    }

    public class VerifyTableAction : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC5CBBBC0
        public void Invoke(){} // RVA: 0x7FFAC307D370
        public void BeginInvoke(){} // RVA: 0x7FFAC9D4F810
        public void EndInvoke(){} // RVA: 0x7FFAC3AE3450
    }

    public class VerifyUnionAction : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9D4F8A0
        public void Invoke(){} // RVA: 0x7FFAC307D4E0
        public void BeginInvoke(){} // RVA: 0x7FFAC9D4FA20
        public void EndInvoke(){} // RVA: 0x7FFAC3AE3450
    }

    public class checkElementStruct : ValueType
    {
        public bool elementValid; // 0x10
        public uint elementOffset; // 0x14
    }

}