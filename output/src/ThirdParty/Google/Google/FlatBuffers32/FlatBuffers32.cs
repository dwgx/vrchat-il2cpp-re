// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Google.Google.FlatBuffers32
// Classes: 32
// Methods: 277

namespace ThirdParty.Google.Google.FlatBuffers32
{
    public class ByteArrayAllocator : ByteBufferAllocator
    {
        public object _buffer;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x81EC640
        public void GrowFront(){} // RVA: 0x81F46B0
        public void get_Span(){} // RVA: 0x81F4840
        public void get_ReadOnlySpan(){} // RVA: 0x81F48E0
        public void get_Memory(){} // RVA: 0x81F4980
        public void get_ReadOnlyMemory(){} // RVA: 0x81F4A70
        public void InitBuffer(){} // RVA: 0x81ECB60
    }

    public class ByteBuffer : Object
    {
        public object _buffer;
        public object _pos;
        public object genericSizes;

        // ── Methods ──
        public void ToArray(){} // RVA: 0x88C530
        public void ArraySize(){} // RVA: 0xA94080
        public void .ctor(){} // RVA: 0x81F4CE0
        public void get_Position(){} // RVA: 0xE62D00
        public void set_Position(){} // RVA: 0x1033F40
        public void get_Length(){} // RVA: 0x66B3620
        public void Reset(){} // RVA: 0x1320080
        public void Duplicate(){} // RVA: 0x81F4E00
        public void GrowFront(){} // RVA: 0x6AE0800
        public void SizeOf(){} // RVA: 0x87CFE0
        public void IsSupportedType(){} // RVA: 0x87D2E0
        public void CopyToSizedArray(){} // RVA: 0x81F4F10
        public void ToSizedArray(){} // RVA: 0x81F51F0
        public void ToFullArray(){} // RVA: 0x81F5250
        public void ToReadOnlyMemory(){} // RVA: 0x81F52B0
        public void ToMemory(){} // RVA: 0x81F5420
        public void ToSpan(){} // RVA: 0x81F5580
        public void ReverseBytes(){} // RVA: 0x81ED680
        public void WriteLittleEndian(){} // RVA: 0x81ED690
        public void ReadLittleEndian(){} // RVA: 0x81F5660
        public void AssertOffsetAndLength(){} // RVA: 0x81F5780
        public void PutSbyte(){} // RVA: 0x81F58B0
        public void PutByte(){} // RVA: 0x81F5960
        public void Put(){} // RVA: 0xA94080
        public void PutStringUTF8(){} // RVA: 0x81F5AC0
        public void PutShort(){} // RVA: 0x81F5BF0
        public void PutUshort(){} // RVA: 0x81F5C00
        public void PutInt(){} // RVA: 0x81F5D40
        public void PutUint(){} // RVA: 0x81F5D50
        public void PutLong(){} // RVA: 0x81F5E90
        public void PutUlong(){} // RVA: 0x81F5EA0
        public void PutFloat(){} // RVA: 0x81F5FE0
        public void PutDouble(){} // RVA: 0x81F60C0
        public void GetSbyte(){} // RVA: 0x81F61A0
        public void Get(){} // RVA: 0x81F61A0
        public void GetStringUTF8(){} // RVA: 0x81F6240
        public void GetShort(){} // RVA: 0x81F6400
        public void GetUshort(){} // RVA: 0x81F6410
        public void GetInt(){} // RVA: 0x81F6540
        public void GetUint(){} // RVA: 0x81F6550
        public void GetLong(){} // RVA: 0x81F6680
        public void GetUlong(){} // RVA: 0x81F6690
        public void GetFloat(){} // RVA: 0x81F67C0
        public void GetDouble(){} // RVA: 0x81F6890
        public void .cctor(){} // RVA: 0x81F6960
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
        public void GetSizePrefix(){} // RVA: 0x81F6F20
        public void RemoveSizePrefix(){} // RVA: 0x81F6F40
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
        public void .ctor(){} // RVA: 0x81F7270
        public void Clear(){} // RVA: 0x81F7410
        public void get_ForceDefaults(){} // RVA: 0xE3F480
        public void set_ForceDefaults(){} // RVA: 0x1546550
        public void get_Offset(){} // RVA: 0x81EF3A0
        public void get_Waste(){} // RVA: 0xBE5890
        public void Pad(){} // RVA: 0x81F7530
        public void GrowBuffer(){} // RVA: 0x81EF4E0
        public void Prep(){} // RVA: 0x81F7680
        public void PutBool(){} // RVA: 0x81F7750
        public void PutSbyte(){} // RVA: 0x81F7780
        public void PutByte(){} // RVA: 0x81F7780
        public void PutShort(){} // RVA: 0x81F77B0
        public void PutUshort(){} // RVA: 0x81F77B0
        public void PutInt(){} // RVA: 0x81F77E0
        public void PutUint(){} // RVA: 0x81F77E0
        public void PutLong(){} // RVA: 0x81F7810
        public void PutUlong(){} // RVA: 0x81F7810
        public void PutFloat(){} // RVA: 0x81F7840
        public void Put(){} // RVA: 0xA94080
        public void PutDouble(){} // RVA: 0x81F7930
        public void AddBool(){} // RVA: 0x81F8150
        public void AddSbyte(){} // RVA: 0x81F8280
        public void AddByte(){} // RVA: 0x81F8330
        public void AddShort(){} // RVA: 0x81F8460
        public void AddUshort(){} // RVA: 0x81F8590
        public void AddInt(){} // RVA: 0x81F86C0
        public void AddUint(){} // RVA: 0x81F8770
        public void AddLong(){} // RVA: 0x81F88A0
        public void AddUlong(){} // RVA: 0x81F8950
        public void AddFloat(){} // RVA: 0x81F8A70
        public void Add(){} // RVA: 0xA94080
        public void AddDouble(){} // RVA: 0x81F8B70
        public void AddOffset(){} // RVA: 0x81F8C00
        public void StartVector(){} // RVA: 0x81F7D00
        public void EndVector(){} // RVA: 0x81F7DB0
        public void CreateVectorOfTables(){} // RVA: 0xA94080
        public void Nested(){} // RVA: 0x81F7E00
        public void NotNested(){} // RVA: 0x81F7E80
        public void StartTable(){} // RVA: 0x81F7EF0
        public void Slot(){} // RVA: 0x81F8020
        public void CreateString(){} // RVA: 0x81F8C40
        public void CreateUTF8String(){} // RVA: 0x81F8E60
        public void CreateSharedString(){} // RVA: 0x81F8FC0
        public void AddStruct(){} // RVA: 0x81F9250
        public void EndTable(){} // RVA: 0x81F92E0
        public void Required(){} // RVA: 0x81F9870
        public void Finish(){} // RVA: 0x81F9D70
        public void FinishSizePrefixed(){} // RVA: 0x81F9D90
        public void get_DataBuffer(){} // RVA: 0xB465B0
        public void SizedByteArray(){} // RVA: 0x81F9B30
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
        public object Value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x29580
    }

    public class Offset`1 : ValueType
    {
        public object Value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x29580
    }

    public class Offset`1 : ValueType
    {
        public object Value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x29580
    }

    public class Offset`1 : ValueType
    {
        public object Value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x29580
    }

    public class Offset`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x29580
    }

    public class Offset`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x29580
    }

    public class Offset`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x29580
    }

    public class Offset`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x29580
    }

    public class Offset`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x29580
    }

    public class Offset`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x29580
    }

    public class Offset`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x29580
    }

    public class Offset`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x29580
    }

    public class Offset`1 : ValueType
    {
        public object Value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8944F0
    }

    public class Offset`1[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E80ED0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7B630
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC5B20
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E368F0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7B630
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class Offset`1[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E80ED0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7B630
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC5B20
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E368F0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7B630
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class Offset`1[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E80ED0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7B630
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC5B20
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E368F0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7B630
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class Offset`1[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E80ED0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7B630
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC5B20
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E368F0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7B630
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
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
        public void .ctor(){} // RVA: 0x29580
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
        public void __offset(){} // RVA: 0x81FBB30
        public void __indirect(){} // RVA: 0x81FBBC0
        public void __string(){} // RVA: 0x9B3D60
        public void __vector_len(){} // RVA: 0x9B3D70
        public void __vector(){} // RVA: 0x9B3DC0
        public void __vector_as_span(){} // RVA: 0xA94080
        public void __vector_as_array(){} // RVA: 0x87C160
        public void __union(){} // RVA: 0xA94080
        public void __has_identifier(){} // RVA: 0x81FBCE0
        public void CompareStrings(){} // RVA: 0x81FBF30
    }

    public class VectorOffset : ValueType
    {
        public object Value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x29580
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
        public void .ctor(){} // RVA: 0x81F9DB0
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
        public void BufferHasIdentifier(){} // RVA: 0x81F9ED0
        public void ReadUOffsetT(){} // RVA: 0x81FA0A0
        public void ReadSOffsetT(){} // RVA: 0x81FA150
        public void ReadVOffsetT(){} // RVA: 0x81FA180
        public void GetVRelOffset(){} // RVA: 0x81FA1B0
        public void GetVOffset(){} // RVA: 0x81FA310
        public void CheckComplexity(){} // RVA: 0x81F2880
        public void CheckAlignment(){} // RVA: 0x81F28C0
        public void CheckElement(){} // RVA: 0x81FA440
        public void CheckScalar(){} // RVA: 0x81FA580
        public void CheckOffset(){} // RVA: 0x81FA5C0
        public void CheckVectorOrString(){} // RVA: 0x81FA600
        public void CheckString(){} // RVA: 0x81FA740
        public void CheckVector(){} // RVA: 0x81FA870
        public void CheckTable(){} // RVA: 0x81F2D30
        public void CheckStringFunc(){} // RVA: 0x81FA880
        public void CheckVectorOfObjects(){} // RVA: 0x81FA8B0
        public void CheckIndirectOffset(){} // RVA: 0x81FA9E0
        public void CheckBufferFromStart(){} // RVA: 0x81FAA70
        public void GetIndirectOffset(){} // RVA: 0x81FAD10
        public void VerifyTableStart(){} // RVA: 0x81FADC0
        public void VerifyTableEnd(){} // RVA: 0x81F34B0
        public void VerifyField(){} // RVA: 0x81FAFD0
        public void VerifyString(){} // RVA: 0x81FB050
        public void VerifyVectorOfData(){} // RVA: 0x81FB0E0
        public void VerifyVectorOfStrings(){} // RVA: 0x81FB170
        public void VerifyVectorOfTables(){} // RVA: 0x81FB250
        public void VerifyTable(){} // RVA: 0x81FB2E0
        public void VerifyNestedBuffer(){} // RVA: 0x81FB380
        public void VerifyUnionData(){} // RVA: 0x81FB540
        public void VerifyUnionString(){} // RVA: 0x81FB580
        public void VerifyUnion(){} // RVA: 0x81FB590
        public void VerifyVectorOfUnion(){} // RVA: 0x81FB700
        public void VerifyBuffer(){} // RVA: 0x81FB9B0
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