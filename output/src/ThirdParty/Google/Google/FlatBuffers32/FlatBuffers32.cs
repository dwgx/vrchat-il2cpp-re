// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Google.Google.FlatBuffers32
// Classes: 32
// Methods: 279

namespace ThirdParty.Google.Google.FlatBuffers32
{
    public class ByteArrayAllocator : ByteBufferAllocator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF394C50
        public void GrowFront(){} // RVA: 0x7AF39CFE0
        public void get_Span(){} // RVA: 0x7AF39D170
        public void get_ReadOnlySpan(){} // RVA: 0x7AF39D210
        public void get_Memory(){} // RVA: 0x7AF39D2B0
        public void get_ReadOnlyMemory(){} // RVA: 0x7AF39D3A0
        public void InitBuffer(){} // RVA: 0x7AF395170
    }

    public class ByteBuffer : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF39D610
        public void get_Position(){} // RVA: 0x7A83782A0
        public void set_Position(){} // RVA: 0x7A84385B0
        public void get_Length(){} // RVA: 0x7ADA292A0
        public void Reset(){} // RVA: 0x7A8810990
        public void Duplicate(){} // RVA: 0x7AF39D730
        public void GrowFront(){} // RVA: 0x7ADE59270
        public void ToArray(){} // RVA: 0x7AA400530
        public void SizeOf(){} // RVA: 0x7AA400410
        public void IsSupportedType(){} // RVA: 0x7A7E01960
        public void ArraySize(){} // RVA: 0x7AA3FC0D0
        public void CopyToSizedArray(){} // RVA: 0x7AF39D840
        public void ToSizedArray(){} // RVA: 0x7AF39DB20
        public void ToFullArray(){} // RVA: 0x7AF39DB80
        public void ToReadOnlyMemory(){} // RVA: 0x7AF39DBE0
        public void ToMemory(){} // RVA: 0x7AF39DD50
        public void ToSpan(){} // RVA: 0x7AF39DEB0
        public void ReverseBytes(){} // RVA: 0x7AF395C90
        public void WriteLittleEndian(){} // RVA: 0x7AF395CA0
        public void ReadLittleEndian(){} // RVA: 0x7AF39DF90
        public void AssertOffsetAndLength(){} // RVA: 0x7AF39E0B0
        public void PutSbyte(){} // RVA: 0x7AF39E1E0
        public void PutByte(){} // RVA: 0x7AF39E290
        public void Put(){} // RVA: 0x7A8051B10
        public void PutStringUTF8(){} // RVA: 0x7AF39E3F0
        public void PutShort(){} // RVA: 0x7AF39E520
        public void PutUshort(){} // RVA: 0x7AF39E530
        public void PutInt(){} // RVA: 0x7AF39E670
        public void PutUint(){} // RVA: 0x7AF39E680
        public void PutLong(){} // RVA: 0x7AF39E7C0
        public void PutUlong(){} // RVA: 0x7AF39E7D0
        public void PutFloat(){} // RVA: 0x7AF39E910
        public void PutDouble(){} // RVA: 0x7AF39E9F0
        public void GetSbyte(){} // RVA: 0x7AF39EAD0
        public void Get(){} // RVA: 0x7AF39EAD0
        public void GetStringUTF8(){} // RVA: 0x7AF39EB70
        public void GetShort(){} // RVA: 0x7AF39ED30
        public void GetUshort(){} // RVA: 0x7AF39ED40
        public void GetInt(){} // RVA: 0x7AF39EE70
        public void GetUint(){} // RVA: 0x7AF39EE80
        public void GetLong(){} // RVA: 0x7AF39EFB0
        public void GetUlong(){} // RVA: 0x7AF39EFC0
        public void GetFloat(){} // RVA: 0x7AF39F0F0
        public void GetDouble(){} // RVA: 0x7AF39F1C0
        public void .cctor(){} // RVA: 0x7AF39F290
    }

    public class ByteBufferAllocator : Object
    {
        // ── Methods ──
        public void get_Span(){} // RVA: 0x7A7E00490
        public void get_ReadOnlySpan(){} // RVA: 0x7A7E00490
        public void get_Memory(){} // RVA: 0x7A7E00490
        public void get_ReadOnlyMemory(){} // RVA: 0x7A7E00490
        public void get_Length(){} // RVA: 0x7A8124910
        public void set_Length(){} // RVA: 0x7A80DA0C0
        public void GrowFront(){} // RVA: 0x7A7E189D0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class ByteBufferUtil : Object
    {
        // ── Methods ──
        public void GetSizePrefix(){} // RVA: 0x7AF39FA70
        public void RemoveSizePrefix(){} // RVA: 0x7AF39FA90
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class FlatBufferBuilder : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF39FDD0
        public void Clear(){} // RVA: 0x7AF39FF70
        public void get_ForceDefaults(){} // RVA: 0x7A8359360
        public void set_ForceDefaults(){} // RVA: 0x7A8A21900
        public void get_Offset(){} // RVA: 0x7AF397C00
        public void get_Waste(){} // RVA: 0x7A8178B70
        public void Pad(){} // RVA: 0x7AF3A0090
        public void GrowBuffer(){} // RVA: 0x7AF397D40
        public void Prep(){} // RVA: 0x7AF3A01E0
        public void PutBool(){} // RVA: 0x7AF3A02B0
        public void PutSbyte(){} // RVA: 0x7AF3A02E0
        public void PutByte(){} // RVA: 0x7AF3A02E0
        public void PutShort(){} // RVA: 0x7AF3A0310
        public void PutUshort(){} // RVA: 0x7AF3A0310
        public void PutInt(){} // RVA: 0x7AF3A0340
        public void PutUint(){} // RVA: 0x7AF3A0340
        public void PutLong(){} // RVA: 0x7AF3A0370
        public void PutUlong(){} // RVA: 0x7AF3A0370
        public void PutFloat(){} // RVA: 0x7AF3A03A0
        public void Put(){} // RVA: 0x7A8051B10
        public void PutDouble(){} // RVA: 0x7AF3A0490
        public void AddBool(){} // RVA: 0x7AF3A0CB0
        public void AddSbyte(){} // RVA: 0x7AF3A0DE0
        public void AddByte(){} // RVA: 0x7AF3A0E90
        public void AddShort(){} // RVA: 0x7AF3A0FC0
        public void AddUshort(){} // RVA: 0x7AF3A10F0
        public void AddInt(){} // RVA: 0x7AF3A1220
        public void AddUint(){} // RVA: 0x7AF3A12D0
        public void AddLong(){} // RVA: 0x7AF3A1400
        public void AddUlong(){} // RVA: 0x7AF3A14B0
        public void AddFloat(){} // RVA: 0x7AF3A15D0
        public void Add(){} // RVA: 0x7A8051B10
        public void AddDouble(){} // RVA: 0x7AF3A16D0
        public void AddOffset(){} // RVA: 0x7AF3A1760
        public void StartVector(){} // RVA: 0x7AF3A0860
        public void EndVector(){} // RVA: 0x7AF3A0910
        public void CreateVectorOfTables(){} // RVA: 0x7A8051B10
        public void Nested(){} // RVA: 0x7AF3A0960
        public void NotNested(){} // RVA: 0x7AF3A09E0
        public void StartTable(){} // RVA: 0x7AF3A0A50
        public void Slot(){} // RVA: 0x7AF3A0B80
        public void CreateString(){} // RVA: 0x7AF3A17A0
        public void CreateUTF8String(){} // RVA: 0x7AF3A19C0
        public void CreateSharedString(){} // RVA: 0x7AF3A1B20
        public void AddStruct(){} // RVA: 0x7AF3A1DB0
        public void EndTable(){} // RVA: 0x7AF3A1E40
        public void Required(){} // RVA: 0x7AF3A23D0
        public void Finish(){} // RVA: 0x7AF3A28D0
        public void FinishSizePrefixed(){} // RVA: 0x7AF3A28F0
        public void get_DataBuffer(){} // RVA: 0x7A80DA7B0
        public void SizedByteArray(){} // RVA: 0x7AF3A2690
    }

    public class FlatBufferConstants : Object
    {
        // ── Methods ──
        public void FLATBUFFERS_24_3_7(){} // RVA: 0x7A80D7310
    }

    public class IFlatbufferObject
    {
        // ── Methods ──
        public void __init(){} // RVA: 0x7A7E19BE0
        public void get_ByteBuffer(){} // RVA: 0x7A7E00680
    }

    public class Offset`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E189D0
    }

    public class Offset`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A76134D0
    }

    public class Offset`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A76134D0
    }

    public class Offset`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A76134D0
    }

    public class Offset`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A76134D0
    }

    public class Offset`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A76134D0
    }

    public class Offset`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A76134D0
    }

    public class Offset`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A76134D0
    }

    public class Offset`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A76134D0
    }

    public class Offset`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A76134D0
    }

    public class Offset`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A76134D0
    }

    public class Offset`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A76134D0
    }

    public class Offset`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A76134D0
    }

    public class Offset`1[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2A3CC0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29EBF0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E4410
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA25D800
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29EBF0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class Offset`1[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2A3CC0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29EBF0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E4410
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA25D800
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29EBF0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class Offset`1[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2A3CC0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29EBF0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E4410
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA25D800
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29EBF0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class Offset`1[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2A3CC0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29EBF0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E4410
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA25D800
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29EBF0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class Options : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF39A720
        public void get_maxDepth(){} // RVA: 0x7A8124910
        public void set_maxDepth(){} // RVA: 0x7A80DA0C0
        public void get_maxTables(){} // RVA: 0x7A8668BC0
        public void set_maxTables(){} // RVA: 0x7A8669360
        public void get_stringEndCheck(){} // RVA: 0x7A80F26D0
        public void set_stringEndCheck(){} // RVA: 0x7A80F26E0
        public void get_alignmentCheck(){} // RVA: 0x7A8475E20
        public void set_alignmentCheck(){} // RVA: 0x7A8D0E640
        public void DEFAULT_MAX_DEPTH(){} // RVA: 0x7B3FAD508
    }

    public class StringOffset : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A76134D0
    }

    public class Struct : ValueType
    {
        // ── Methods ──
        public void get_bb_pos(){} // RVA: 0x7A765F070
        public void set_bb_pos(){} // RVA: 0x7A76134D0
        public void get_bb(){} // RVA: 0x7A765F080
        public void set_bb(){} // RVA: 0x7A765F010
        public void .ctor(){} // RVA: 0x7A7F10D00
        public void <bb_pos>k__BackingField(){} // RVA: 0x7B3FB4328
    }

    public class Table : ValueType
    {
        // ── Methods ──
        public void get_bb_pos(){} // RVA: 0x7A765F070
        public void set_bb_pos(){} // RVA: 0x7A76134D0
        public void get_bb(){} // RVA: 0x7A765F080
        public void set_bb(){} // RVA: 0x7A765F010
        public void get_ByteBuffer(){} // RVA: 0x7A765F080
        public void .ctor(){} // RVA: 0x7A7F10D00
        public void __offset(){} // RVA: 0x7AF3A47D0
        public void __indirect(){} // RVA: 0x7AF3A4860
        public void __string(){} // RVA: 0x7A7F10E50
        public void __vector_len(){} // RVA: 0x7A7F10E60
        public void __vector(){} // RVA: 0x7A7F10EB0
        public void __vector_as_span(){} // RVA: 0x7A8051B10
        public void __vector_as_array(){} // RVA: 0x7A7E00740
        public void __union(){} // RVA: 0x7A8051B10
        public void __has_identifier(){} // RVA: 0x7AF3A4980
        public void CompareStrings(){} // RVA: 0x7AF3A4BD0
    }

    public class VectorOffset : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A76134D0
    }

    public class Verifier : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF3A2A50
        public void get_Buf(){} // RVA: 0x7A80F2570
        public void set_Buf(){} // RVA: 0x7A80D8E20
        public void get_options(){} // RVA: 0x7A80DA7B0
        public void set_options(){} // RVA: 0x7A813E420
        public void get_depth(){} // RVA: 0x7A851DB90
        public void set_depth(){} // RVA: 0x7A8738180
        public void get_numTables(){} // RVA: 0x7A8AB15F0
        public void set_numTables(){} // RVA: 0x7A94794D0
        public void SetMaxDepth(){} // RVA: 0x7AF39ABC0
        public void SetMaxTables(){} // RVA: 0x7AF39ABE0
        public void SetAlignmentCheck(){} // RVA: 0x7AF39AC00
        public void SetStringCheck(){} // RVA: 0x7AF39AC20
        public void BufferHasIdentifier(){} // RVA: 0x7AF3A2B70
        public void ReadUOffsetT(){} // RVA: 0x7AF3A2D40
        public void ReadSOffsetT(){} // RVA: 0x7AF3A2DF0
        public void ReadVOffsetT(){} // RVA: 0x7AF3A2E20
        public void GetVRelOffset(){} // RVA: 0x7AF3A2E50
        public void GetVOffset(){} // RVA: 0x7AF3A2FB0
        public void CheckComplexity(){} // RVA: 0x7AF39B1B0
        public void CheckAlignment(){} // RVA: 0x7AF39B1F0
        public void CheckElement(){} // RVA: 0x7AF3A30E0
        public void CheckScalar(){} // RVA: 0x7AF3A3220
        public void CheckOffset(){} // RVA: 0x7AF3A3260
        public void CheckVectorOrString(){} // RVA: 0x7AF3A32A0
        public void CheckString(){} // RVA: 0x7AF3A33E0
        public void CheckVector(){} // RVA: 0x7AF3A3510
        public void CheckTable(){} // RVA: 0x7AF39B660
        public void CheckStringFunc(){} // RVA: 0x7AF3A3520
        public void CheckVectorOfObjects(){} // RVA: 0x7AF3A3550
        public void CheckIndirectOffset(){} // RVA: 0x7AF3A3680
        public void CheckBufferFromStart(){} // RVA: 0x7AF3A3710
        public void GetIndirectOffset(){} // RVA: 0x7AF3A39B0
        public void VerifyTableStart(){} // RVA: 0x7AF3A3A60
        public void VerifyTableEnd(){} // RVA: 0x7AF39BDE0
        public void VerifyField(){} // RVA: 0x7AF3A3C70
        public void VerifyString(){} // RVA: 0x7AF3A3CF0
        public void VerifyVectorOfData(){} // RVA: 0x7AF3A3D80
        public void VerifyVectorOfStrings(){} // RVA: 0x7AF3A3E10
        public void VerifyVectorOfTables(){} // RVA: 0x7AF3A3EF0
        public void VerifyTable(){} // RVA: 0x7AF3A3F80
        public void VerifyNestedBuffer(){} // RVA: 0x7AF3A4020
        public void VerifyUnionData(){} // RVA: 0x7AF3A41E0
        public void VerifyUnionString(){} // RVA: 0x7AF3A4220
        public void VerifyUnion(){} // RVA: 0x7AF3A4230
        public void VerifyVectorOfUnion(){} // RVA: 0x7AF3A43A0
        public void VerifyBuffer(){} // RVA: 0x7AF3A4650
    }

    public class VerifyTableAction : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AB1A3C80
        public void Invoke(){} // RVA: 0x7A82344F0
        public void BeginInvoke(){} // RVA: 0x7AF3A2910
        public void EndInvoke(){} // RVA: 0x7A98D5590
    }

    public class VerifyUnionAction : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF39A7D0
        public void Invoke(){} // RVA: 0x7A8234660
        public void BeginInvoke(){} // RVA: 0x7AF3A29A0
        public void EndInvoke(){} // RVA: 0x7A98D5590
    }

}