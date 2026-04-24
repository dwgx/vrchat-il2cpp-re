// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Google.Google.FlatBuffers8
// Classes: 15
// Methods: 195

namespace ThirdParty.Google.Google.FlatBuffers8
{
    public class ByteBuffer : Object
    {
        public object genericSizes; // 0x316F75C0
        public object Position; // 0x1700000A

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf76ced0
        public void .ctor(){} // RVA: 0x7ffaaf76ced0
        public void .ctor(){} // RVA: 0x7ffaaf76ced0
        public void .ctor(){} // RVA: 0x7ffaaf76ced0
        public void get_Position(){} // RVA: 0x7ffaa8b945a0
        public void set_Position(){} // RVA: 0x7ffaa9357830
        public void get_Length(){} // RVA: 0x7ffaaddf3960
        public void Reset(){} // RVA: 0x7ffaa90bf2b0
        public void Duplicate(){} // RVA: 0x7ffaaf76cff0
        public void GrowFront(){} // RVA: 0x7ffaae2257e0
        public void ToArray(){} // RVA: 0x7ffaaf76d0a0
        public void SizeOf(){} // RVA: 0x7ffaa8649cd0
        public void IsSupportedType(){} // RVA: 0x7ffaa864a070
        public void ArraySize(){} // RVA: 0x7ffaa887e5c0
        public void ArraySize(){} // RVA: 0x7ffaa887e5c0
        public void ArraySize(){} // RVA: 0x7ffaa887e5c0
        public void ToArray(){} // RVA: 0x7ffaaf76d0a0
        public void CopyToSizedArray(){} // RVA: 0x7ffaaf76d100
        public void ToSizedArray(){} // RVA: 0x7ffaaf76d3e0
        public void ToFullArray(){} // RVA: 0x7ffaaf76d440
        public void ToReadOnlyMemory(){} // RVA: 0x7ffaaf76d4a0
        public void ToMemory(){} // RVA: 0x7ffaaf76d600
        public void ToSpan(){} // RVA: 0x7ffaaf76d750
        public void ReverseBytes(){} // RVA: 0x7ffaaf76d830
        public void ReverseBytes(){} // RVA: 0x7ffaaf76d830
        public void ReverseBytes(){} // RVA: 0x7ffaaf76d830
        public void WriteLittleEndian(){} // RVA: 0x7ffaaf76d840
        public void ReadLittleEndian(){} // RVA: 0x7ffaaf76d900
        public void AssertOffsetAndLength(){} // RVA: 0x7ffaaf76d9c0
        public void PutSbyte(){} // RVA: 0x7ffaaf76dc50
        public void PutSbyte(){} // RVA: 0x7ffaaf76dc50
        public void PutByte(){} // RVA: 0x7ffaaf76dcd0
        public void PutByte(){} // RVA: 0x7ffaaf76dcd0
        public void Put(){} // RVA: 0x7ffaa887e5c0
        public void PutStringUTF8(){} // RVA: 0x7ffaaf76dde0
        public void PutShort(){} // RVA: 0x7ffaaf76dec0
        public void PutUshort(){} // RVA: 0x7ffaaf76ded0
        public void PutInt(){} // RVA: 0x7ffaaf76dfd0
        public void PutUint(){} // RVA: 0x7ffaaf76dfe0
        public void PutLong(){} // RVA: 0x7ffaaf76e0e0
        public void PutUlong(){} // RVA: 0x7ffaaf76e0f0
        public void PutFloat(){} // RVA: 0x7ffaaf76e1f0
        public void PutDouble(){} // RVA: 0x7ffaaf76e290
        public void Put(){} // RVA: 0x7ffaa887e5c0
        public void Put(){} // RVA: 0x7ffaa887e5c0
        public void Put(){} // RVA: 0x7ffaa887e5c0
        public void Put(){} // RVA: 0x7ffaa887e5c0
        public void .cctor(){} // RVA: 0x7ffaaf76e9c0
        // ── Binary Analysis Named ──
        public void GetSbyte(){} // RVA: 0x7ffaaf76e330
        public void Get(){} // RVA: 0x7ffaaf76e330
        public void GetStringUTF8(){} // RVA: 0x7ffaaf76e3a0
        public void GetShort(){} // RVA: 0x7ffaaf76e560
        public void GetUshort(){} // RVA: 0x7ffaaf76e570
        public void GetInt(){} // RVA: 0x7ffaaf76e660
        public void GetUint(){} // RVA: 0x7ffaaf76e670
        public void GetLong(){} // RVA: 0x7ffaaf76e7a0
        public void GetUlong(){} // RVA: 0x7ffaaf76e7b0
        public void GetFloat(){} // RVA: 0x7ffaaf76e8a0
        public void GetDouble(){} // RVA: 0x7ffaaf76e930
    }

    public class ByteBufferAllocator : Object
    {
        // ── Original Methods ──
        public void get_Span(){}
        public void get_ReadOnlySpan(){}
        public void get_Memory(){} // RVA: 0x7ffaa8648be0
        public void get_ReadOnlyMemory(){} // RVA: 0x7ffaa8648be0
        public void get_Length(){} // RVA: 0x7ffaa897f5c0
        public void set_Length(){} // RVA: 0x7ffaa89350c0
        public void GrowFront(){} // RVA: 0x7ffaa8661210
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class ByteBufferUtil : Object
    {
        // ── Original Methods ──
        public void RemoveSizePrefix(){} // RVA: 0x7ffaaf76f1d0
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetSizePrefix(){} // RVA: 0x7ffaaf76f1a0
    }

    public class FlatBufferBuilder : Object
    {
        public object _minAlign; // 0x31753D60
        public object _objectStart; // 0x31753D60
        public object _vectorNumElems; // 0x31753D60
        public object _forceDefaults; // 0x31753D60, was: <ForceDefaults>k__BackingField
        public object ForceDefaults; // 0x1700000C
        public object Offset; // 0x1700000D
        public object Waste; // 0x1700000E
        public object DataBuffer; // 0x1700000F

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf76f500
        public void .ctor(){} // RVA: 0x7ffaaf76f500
        public void Clear(){} // RVA: 0x7ffaaf76f6a0
        public void get_ForceDefaults(){} // RVA: 0x7ffaa8b6c110
        public void set_ForceDefaults(){} // RVA: 0x7ffaa92bb760
        public void get_Offset(){} // RVA: 0x7ffaaf76f7c0
        public void get_Waste(){} // RVA: 0x7ffaa89d30c0
        public void Pad(){} // RVA: 0x7ffaaf76f7f0
        public void GrowBuffer(){} // RVA: 0x7ffaaf76f900
        public void Prep(){} // RVA: 0x7ffaaf76f940
        public void PutBool(){} // RVA: 0x7ffaaf76fb00
        public void PutSbyte(){} // RVA: 0x7ffaaf76fb30
        public void PutByte(){} // RVA: 0x7ffaaf76fb30
        public void PutShort(){} // RVA: 0x7ffaaf76fb60
        public void PutUshort(){} // RVA: 0x7ffaaf76fb60
        public void PutInt(){} // RVA: 0x7ffaaf76fb90
        public void PutUint(){} // RVA: 0x7ffaaf76fb90
        public void PutLong(){} // RVA: 0x7ffaaf76fbc0
        public void PutUlong(){} // RVA: 0x7ffaaf76fbc0
        public void PutFloat(){} // RVA: 0x7ffaaf76fbf0
        public void Put(){} // RVA: 0x7ffaa887e5c0
        public void Put(){} // RVA: 0x7ffaa887e5c0
        public void Put(){} // RVA: 0x7ffaa887e5c0
        public void Put(){} // RVA: 0x7ffaa887e5c0
        public void PutDouble(){} // RVA: 0x7ffaaf76fc20
        public void AddBool(){} // RVA: 0x7ffaaf7705e0
        public void AddSbyte(){} // RVA: 0x7ffaaf770710
        public void AddByte(){} // RVA: 0x7ffaaf7707c0
        public void AddByte(){} // RVA: 0x7ffaaf7707c0
        public void AddShort(){} // RVA: 0x7ffaaf7708f0
        public void AddUshort(){} // RVA: 0x7ffaaf770a20
        public void AddInt(){} // RVA: 0x7ffaaf770b50
        public void AddUint(){} // RVA: 0x7ffaaf770c00
        public void AddLong(){} // RVA: 0x7ffaaf770d30
        public void AddUlong(){} // RVA: 0x7ffaaf770de0
        public void AddFloat(){} // RVA: 0x7ffaaf770f10
        public void Add(){} // RVA: 0x7ffaa887e5c0
        public void Add(){} // RVA: 0x7ffaa887e5c0
        public void Add(){} // RVA: 0x7ffaa887e5c0
        public void Add(){} // RVA: 0x7ffaa887e5c0
        public void AddDouble(){} // RVA: 0x7ffaaf771040
        public void AddOffset(){} // RVA: 0x7ffaaf7710f0
        public void StartVector(){} // RVA: 0x7ffaaf770010
        public void EndVector(){} // RVA: 0x7ffaaf770160
        public void CreateVectorOfTables(){} // RVA: 0x7ffaa887e5c0
        public void Nested(){} // RVA: 0x7ffaaf770290
        public void NotNested(){} // RVA: 0x7ffaaf770310
        public void StartTable(){} // RVA: 0x7ffaaf770380
        public void Slot(){} // RVA: 0x7ffaaf7704b0
        public void AddBool(){} // RVA: 0x7ffaaf7705e0
        public void AddBool(){} // RVA: 0x7ffaaf7705e0
        public void AddSbyte(){} // RVA: 0x7ffaaf770710
        public void AddSbyte(){} // RVA: 0x7ffaaf770710
        public void AddByte(){} // RVA: 0x7ffaaf7707c0
        public void AddByte(){} // RVA: 0x7ffaaf7707c0
        public void AddShort(){} // RVA: 0x7ffaaf7708f0
        public void AddShort(){} // RVA: 0x7ffaaf7708f0
        public void AddUshort(){} // RVA: 0x7ffaaf770a20
        public void AddUshort(){} // RVA: 0x7ffaaf770a20
        public void AddInt(){} // RVA: 0x7ffaaf770b50
        public void AddInt(){} // RVA: 0x7ffaaf770b50
        public void AddUint(){} // RVA: 0x7ffaaf770c00
        public void AddUint(){} // RVA: 0x7ffaaf770c00
        public void AddLong(){} // RVA: 0x7ffaaf770d30
        public void AddLong(){} // RVA: 0x7ffaaf770d30
        public void AddUlong(){} // RVA: 0x7ffaaf770de0
        public void AddUlong(){} // RVA: 0x7ffaaf770de0
        public void AddFloat(){} // RVA: 0x7ffaaf770f10
        public void AddFloat(){} // RVA: 0x7ffaaf770f10
        public void AddDouble(){} // RVA: 0x7ffaaf771040
        public void AddDouble(){} // RVA: 0x7ffaaf771040
        public void AddOffset(){} // RVA: 0x7ffaaf7710f0
        public void CreateString(){} // RVA: 0x7ffaaf771130
        public void CreateUTF8String(){} // RVA: 0x7ffaaf7712e0
        public void CreateSharedString(){} // RVA: 0x7ffaaf771410
        public void AddStruct(){} // RVA: 0x7ffaaf7716a0
        public void EndTable(){} // RVA: 0x7ffaaf771730
        public void Required(){} // RVA: 0x7ffaaf771d40
        public void Finish(){} // RVA: 0x7ffaaf7721c0
        public void Finish(){} // RVA: 0x7ffaaf7721c0
        public void FinishSizePrefixed(){} // RVA: 0x7ffaaf7721e0
        public void get_DataBuffer(){} // RVA: 0x7ffaa89357c0
        public void SizedByteArray(){} // RVA: 0x7ffaaf771fb0
        public void Finish(){} // RVA: 0x7ffaaf7721c0
        public void Finish(){} // RVA: 0x7ffaaf7721c0
        public void FinishSizePrefixed(){} // RVA: 0x7ffaaf7721e0
    }

    public class FlatBufferConstants : Object
    {
        // ── Original Methods ──
        public void FLATBUFFERS_24_3_7(){} // RVA: 0x7ffaa8932310
    }

    public class IFlatbufferObject
    {
        // ── Original Methods ──
        public void __init(){} // RVA: 0x7ffaa8662f00
        public void get_ByteBuffer(){} // RVA: 0x7ffaa86491d0
    }

    public class Offset`1 : ValueType
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8661210
    }

    public class Offset`1 : ValueType
    {
    }

    public class Offset`1 : ValueType
    {
    }

    public class Offset`1 : ValueType
    {
    }

    public class Offset`1 : ValueType
    {
    }

    public class Options : Object
    {
        public object max_depth; // 0x336115D0
        public object alignment_check; // 0x336115D0
        public object maxDepth; // 0x17000010
        public object maxTables; // 0x17000011

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf772220
        public void .ctor(){} // RVA: 0x7ffaaf772220
        public void get_maxDepth(){} // RVA: 0x7ffaa897f5c0
        public void set_maxDepth(){} // RVA: 0x7ffaa89350c0
        public void get_maxTables(){} // RVA: 0x7ffaa8e046c0
        public void set_maxTables(){} // RVA: 0x7ffaa8e03640
        public void get_stringEndCheck(){} // RVA: 0x7ffaa894d4e0
        public void set_stringEndCheck(){} // RVA: 0x7ffaa894d4f0
        public void get_alignmentCheck(){} // RVA: 0x7ffaa8c53420
        public void set_alignmentCheck(){} // RVA: 0x7ffaa8f41f20
    }

    public class Struct : ValueType
    {
        // ── Original Methods ──
        public void get_bb_pos(){} // RVA: 0x7ffaa9e47550
        public void set_bb_pos(){} // RVA: 0x7ffaa8d92880
        public void get_bb(){} // RVA: 0x7ffaa9e47540
        public void set_bb(){} // RVA: 0x7ffaa9e47560
        public void .ctor(){} // RVA: 0x7ffaaf7744a0
    }

    public class Table : ValueType
    {
        // ── Original Methods ──
        public void get_bb_pos(){} // RVA: 0x7ffaa9e47550
        public void set_bb_pos(){} // RVA: 0x7ffaa8d92880
        public void get_bb(){} // RVA: 0x7ffaa9e47540
        public void set_bb(){} // RVA: 0x7ffaa9e47560
        public void get_ByteBuffer(){} // RVA: 0x7ffaa9e47540
        public void .ctor(){} // RVA: 0x7ffaaf7744a0
        public void __offset(){} // RVA: 0x7ffaaf7745a0
        public void __offset(){} // RVA: 0x7ffaaf7745a0
        public void __indirect(){} // RVA: 0x7ffaaf774640
        public void __indirect(){} // RVA: 0x7ffaaf774640
        public void __string(){} // RVA: 0x7ffaaf774670
        public void __vector_len(){} // RVA: 0x7ffaaf7746f0
        public void __vector(){} // RVA: 0x7ffaaf774740
        public void __vector_as_span(){} // RVA: 0x7ffaa887e5c0
        public void __vector_as_array(){} // RVA: 0x7ffaa8658120
        public void __union(){} // RVA: 0x7ffaa887e5c0
        public void __has_identifier(){} // RVA: 0x7ffaaf774770
        public void CompareStrings(){} // RVA: 0x7ffaaf7749d0
        public void CompareStrings(){} // RVA: 0x7ffaaf7749d0
    }

    public class VectorOffset : ValueType
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf774440
    }

}