// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Google.Google.FlatBuffers32
// Classes: 10
// Methods: 186

namespace ThirdParty.Google.Google.FlatBuffers32
{
    public class ByteBuffer : Object
    {
        public AssignBinaryExpression.ingContinuation Position; // 0x10
        public int Length; // 0x18
        public URA.DateTime<?,int> genericSizes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD551726F0 | overloaded x4
        public void get_Position(){} // RVA: 0x7FFD4E577800
        public void set_Position(){} // RVA: 0x7FFD4ED4CD10
        public void get_Length(){} // RVA: 0x7FFD537F27B0
        public void Reset(){} // RVA: 0x7FFD4EAB70B0
        public void Duplicate(){} // RVA: 0x7FFD55172810
        public void GrowFront(){} // RVA: 0x7FFD53C245D0
        public void ToArray(){} // RVA: 0x7FFD551728C0 | overloaded x2
        public void SizeOf(){} // RVA: 0x7FFD4E079990
        public void IsSupportedType(){} // RVA: 0x7FFD4E079D30
        public void ArraySize(){} // RVA: 0x7FFD4E2ADC40 | overloaded x3
        public void CopyToSizedArray(){} // RVA: 0x7FFD55172920
        public void ToSizedArray(){} // RVA: 0x7FFD55172C00
        public void ToFullArray(){} // RVA: 0x7FFD55172C60
        public void ToReadOnlyMemory(){} // RVA: 0x7FFD55172CC0
        public void ToMemory(){} // RVA: 0x7FFD55172E20
        public void ToSpan(){} // RVA: 0x7FFD55172F70
        public void ReverseBytes(){} // RVA: 0x7FFD5516AE00 | overloaded x3
        public void WriteLittleEndian(){} // RVA: 0x7FFD5516AE10
        public void ReadLittleEndian(){} // RVA: 0x7FFD55173050
        public void AssertOffsetAndLength(){} // RVA: 0x7FFD55173170
        public void PutSbyte(){} // RVA: 0x7FFD551732A0 | overloaded x2
        public void PutByte(){} // RVA: 0x7FFD55173350 | overloaded x2
        public void Put(){} // RVA: 0x7FFD4E2ADC40 | overloaded x5
        public void PutStringUTF8(){} // RVA: 0x7FFD551734B0
        public void PutShort(){} // RVA: 0x7FFD551735E0
        public void PutUshort(){} // RVA: 0x7FFD551735F0
        public void PutInt(){} // RVA: 0x7FFD55173730
        public void PutUint(){} // RVA: 0x7FFD55173740
        public void PutLong(){} // RVA: 0x7FFD55173880
        public void PutUlong(){} // RVA: 0x7FFD55173890
        public void PutFloat(){} // RVA: 0x7FFD551739D0
        public void PutDouble(){} // RVA: 0x7FFD55173AB0
        public void GetSbyte(){} // RVA: 0x7FFD55173B90
        public void Get(){} // RVA: 0x7FFD55173B90
        public void GetStringUTF8(){} // RVA: 0x7FFD55173C30
        public void GetShort(){} // RVA: 0x7FFD55173DF0
        public void GetUshort(){} // RVA: 0x7FFD55173E00
        public void GetInt(){} // RVA: 0x7FFD55173F30
        public void GetUint(){} // RVA: 0x7FFD55173F40
        public void GetLong(){} // RVA: 0x7FFD551740B0
        public void GetUlong(){} // RVA: 0x7FFD551740C0
        public void GetFloat(){} // RVA: 0x7FFD551741F0
        public void GetDouble(){} // RVA: 0x7FFD551742C0
        public void .cctor(){} // RVA: 0x7FFD55174390
    }

    public class ByteBufferUtil : Object
    {
        // ── Methods ──
        public void GetSizePrefix(){} // RVA: 0x7FFD55174B70
        public void RemoveSizePrefix(){} // RVA: 0x7FFD55174B90
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class FlatBufferBuilder : Object
    {
        public int ForceDefaults; // 0x10
        public AssignBinaryExpression..Linq.Expressions.Interpreter.InterpretedFrameInfo>.get_Current Offset; // 0x18
        public int Waste; // 0x20
        public int[] DataBuffer; // 0x28
        public int _vtableSize; // 0x30
        public int _objectStart; // 0x34
        public int[] _vtables; // 0x38
        public int _numVtables; // 0x40
        public int _vectorNumElems; // 0x44
        public int _waste; // 0x48
        public URA.DateTime<string,AssignBinaryExpression.le> _sharedStringMap; // 0x50
        public bool <ForceDefaults>k__BackingField; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD55174EC0 | overloaded x2
        public void Clear(){} // RVA: 0x7FFD55175060
        public void get_ForceDefaults(){} // RVA: 0x7FFD4E55F600
        public void set_ForceDefaults(){} // RVA: 0x7FFD4ECB2770
        public void get_Offset(){} // RVA: 0x7FFD5516CD90
        public void get_Waste(){} // RVA: 0x7FFD4E3E20C0
        public void Pad(){} // RVA: 0x7FFD55175180
        public void GrowBuffer(){} // RVA: 0x7FFD5516CED0
        public void Prep(){} // RVA: 0x7FFD551752D0
        public void PutBool(){} // RVA: 0x7FFD551753A0
        public void PutSbyte(){} // RVA: 0x7FFD551753D0
        public void PutByte(){} // RVA: 0x7FFD551753D0
        public void PutShort(){} // RVA: 0x7FFD55175400
        public void PutUshort(){} // RVA: 0x7FFD55175400
        public void PutInt(){} // RVA: 0x7FFD55175430
        public void PutUint(){} // RVA: 0x7FFD55175430
        public void PutLong(){} // RVA: 0x7FFD55175460
        public void PutUlong(){} // RVA: 0x7FFD55175460
        public void PutFloat(){} // RVA: 0x7FFD55175490
        public void Put(){} // RVA: 0x7FFD4E2ADC40 | overloaded x4
        public void PutDouble(){} // RVA: 0x7FFD551754C0
        public void AddBool(){} // RVA: 0x7FFD55175C40 | overloaded x3
        public void AddSbyte(){} // RVA: 0x7FFD55175D70 | overloaded x3
        public void AddByte(){} // RVA: 0x7FFD55175E20 | overloaded x3
        public void AddShort(){} // RVA: 0x7FFD55175F50 | overloaded x3
        public void AddUshort(){} // RVA: 0x7FFD55176080 | overloaded x3
        public void AddInt(){} // RVA: 0x7FFD551761B0 | overloaded x3
        public void AddUint(){} // RVA: 0x7FFD55176260 | overloaded x3
        public void AddLong(){} // RVA: 0x7FFD55176390 | overloaded x3
        public void AddUlong(){} // RVA: 0x7FFD55176440 | overloaded x3
        public void AddFloat(){} // RVA: 0x7FFD55176570 | overloaded x3
        public void Add(){} // RVA: 0x7FFD4E2ADC40 | overloaded x4
        public void AddDouble(){} // RVA: 0x7FFD551766A0 | overloaded x3
        public void AddOffset(){} // RVA: 0x7FFD55176750 | overloaded x2
        public void StartVector(){} // RVA: 0x7FFD551757F0
        public void EndVector(){} // RVA: 0x7FFD551758A0
        public void CreateVectorOfTables(){} // RVA: 0x7FFD4E2ADC40
        public void Nested(){} // RVA: 0x7FFD551758F0
        public void NotNested(){} // RVA: 0x7FFD55175970
        public void StartTable(){} // RVA: 0x7FFD551759E0
        public void Slot(){} // RVA: 0x7FFD55175B10
        public void CreateString(){} // RVA: 0x7FFD55176790
        public void CreateUTF8String(){} // RVA: 0x7FFD551769B0
        public void CreateSharedString(){} // RVA: 0x7FFD55176B10
        public void AddStruct(){} // RVA: 0x7FFD55176DA0
        public void EndTable(){} // RVA: 0x7FFD55176E30
        public void Required(){} // RVA: 0x7FFD551773A0
        public void Finish(){} // RVA: 0x7FFD551778A0 | overloaded x4
        public void FinishSizePrefixed(){} // RVA: 0x7FFD551778C0 | overloaded x2
        public void get_DataBuffer(){} // RVA: 0x7FFD4E3447C0
        public void SizedByteArray(){} // RVA: 0x7FFD55177660
    }

    public class FlatBufferConstants : Object
    {
        public int FileIdentifierLength;
        public int SizePrefixLength;

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
        public int Value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090ED0
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
        public int bb_pos; // 0x10
        public AssignBinaryExpression..Linq.Expressions.Interpreter.InterpretedFrameInfo>.get_Current bb; // 0x18

        // ── Methods ──
        public void get_bb_pos(){} // RVA: 0x7FFD4F840210
        public void set_bb_pos(){} // RVA: 0x7FFD4E78D8B0
        public void get_bb(){} // RVA: 0x7FFD4F840220
        public void set_bb(){} // RVA: 0x7FFD4F840240
        public void .ctor(){} // RVA: 0x7FFD55171A70
    }

    public class Table : ValueType
    {
        public int bb_pos; // 0x10
        public AssignBinaryExpression..Linq.Expressions.Interpreter.InterpretedFrameInfo>.get_Current bb; // 0x18

        // ── Methods ──
        public void get_bb_pos(){} // RVA: 0x7FFD4F840210
        public void set_bb_pos(){} // RVA: 0x7FFD4E78D8B0
        public void get_bb(){} // RVA: 0x7FFD4F840220
        public void set_bb(){} // RVA: 0x7FFD4F840240
        public void get_ByteBuffer(){} // RVA: 0x7FFD4F840220
        public void .ctor(){} // RVA: 0x7FFD55171A70
        public void __offset(){} // RVA: 0x7FFD551797A0 | overloaded x2
        public void __indirect(){} // RVA: 0x7FFD55179830 | overloaded x2
        public void __string(){} // RVA: 0x7FFD55179860
        public void __vector_len(){} // RVA: 0x7FFD551798D0
        public void __vector(){} // RVA: 0x7FFD55179920
        public void __vector_as_span(){} // RVA: 0x7FFD4E2ADC40
        public void __vector_as_array(){} // RVA: 0x7FFD4E087DE0
        public void __union(){} // RVA: 0x7FFD4E2ADC40
        public void __has_identifier(){} // RVA: 0x7FFD55179950
        public void CompareStrings(){} // RVA: 0x7FFD55179BB0 | overloaded x2
    }

    public class VectorOffset : ValueType
    {
        public int Value; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E78D8B0
    }

}