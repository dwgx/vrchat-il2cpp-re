// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Google.Google.FlatBuffers32
// Classes: 18
// Methods: 190

namespace ThirdParty.Google.Google.FlatBuffers32
{
    public class ByteBuffer : Object
    {
        public object genericSizes; // 0x316F7440
        public object Position; // 0x17000027

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf775120
        public void .ctor(){} // RVA: 0x7ffaaf775120
        public void .ctor(){} // RVA: 0x7ffaaf775120
        public void .ctor(){} // RVA: 0x7ffaaf775120
        public void get_Position(){} // RVA: 0x7ffaa8b945a0
        public void set_Position(){} // RVA: 0x7ffaa9357830
        public void get_Length(){} // RVA: 0x7ffaaddf3960
        public void Reset(){} // RVA: 0x7ffaa90bf2b0
        public void Duplicate(){} // RVA: 0x7ffaaf775240
        public void GrowFront(){} // RVA: 0x7ffaae2257e0
        public void ToArray(){} // RVA: 0x7ffaaf7752f0
        public void SizeOf(){} // RVA: 0x7ffaa8649cd0
        public void IsSupportedType(){} // RVA: 0x7ffaa864a070
        public void ArraySize(){} // RVA: 0x7ffaa887e5c0
        public void ArraySize(){} // RVA: 0x7ffaa887e5c0
        public void ArraySize(){} // RVA: 0x7ffaa887e5c0
        public void ToArray(){} // RVA: 0x7ffaaf7752f0
        public void CopyToSizedArray(){} // RVA: 0x7ffaaf775350
        public void ToSizedArray(){} // RVA: 0x7ffaaf775630
        public void ToFullArray(){} // RVA: 0x7ffaaf775690
        public void ToReadOnlyMemory(){} // RVA: 0x7ffaaf7756f0
        public void ToMemory(){} // RVA: 0x7ffaaf775850
        public void ToSpan(){} // RVA: 0x7ffaaf7759a0
        public void ReverseBytes(){} // RVA: 0x7ffaaf76d830
        public void ReverseBytes(){} // RVA: 0x7ffaaf76d830
        public void ReverseBytes(){} // RVA: 0x7ffaaf76d830
        public void WriteLittleEndian(){} // RVA: 0x7ffaaf76d840
        public void ReadLittleEndian(){} // RVA: 0x7ffaaf775a80
        public void AssertOffsetAndLength(){} // RVA: 0x7ffaaf775ba0
        public void PutSbyte(){} // RVA: 0x7ffaaf775cd0
        public void PutSbyte(){} // RVA: 0x7ffaaf775cd0
        public void PutByte(){} // RVA: 0x7ffaaf775d80
        public void PutByte(){} // RVA: 0x7ffaaf775d80
        public void Put(){} // RVA: 0x7ffaa887e5c0
        public void PutStringUTF8(){} // RVA: 0x7ffaaf775ee0
        public void PutShort(){} // RVA: 0x7ffaaf776010
        public void PutUshort(){} // RVA: 0x7ffaaf776020
        public void PutInt(){} // RVA: 0x7ffaaf776160
        public void PutUint(){} // RVA: 0x7ffaaf776170
        public void PutLong(){} // RVA: 0x7ffaaf7762b0
        public void PutUlong(){} // RVA: 0x7ffaaf7762c0
        public void PutFloat(){} // RVA: 0x7ffaaf776400
        public void PutDouble(){} // RVA: 0x7ffaaf7764e0
        public void Put(){} // RVA: 0x7ffaa887e5c0
        public void Put(){} // RVA: 0x7ffaa887e5c0
        public void Put(){} // RVA: 0x7ffaa887e5c0
        public void Put(){} // RVA: 0x7ffaa887e5c0
        public void .cctor(){} // RVA: 0x7ffaaf776dc0
        // ── Binary Analysis Named ──
        public void GetSbyte(){} // RVA: 0x7ffaaf7765c0
        public void Get(){} // RVA: 0x7ffaaf7765c0
        public void GetStringUTF8(){} // RVA: 0x7ffaaf776660
        public void GetShort(){} // RVA: 0x7ffaaf776820
        public void GetUshort(){} // RVA: 0x7ffaaf776830
        public void GetInt(){} // RVA: 0x7ffaaf776960
        public void GetUint(){} // RVA: 0x7ffaaf776970
        public void GetLong(){} // RVA: 0x7ffaaf776ae0
        public void GetUlong(){} // RVA: 0x7ffaaf776af0
        public void GetFloat(){} // RVA: 0x7ffaaf776c20
        public void GetDouble(){} // RVA: 0x7ffaaf776cf0
    }

    public class ByteBufferUtil : Object
    {
        // ── Original Methods ──
        public void RemoveSizePrefix(){} // RVA: 0x7ffaaf7775c0
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetSizePrefix(){} // RVA: 0x7ffaaf7775a0
    }

    public class FlatBufferBuilder : Object
    {
        public object _minAlign; // 0x31753A60
        public object _objectStart; // 0x31753A60
        public object _vectorNumElems; // 0x31753A60
        public object _forceDefaults; // 0x31753A60, was: <ForceDefaults>k__BackingField
        public object ForceDefaults; // 0x17000029
        public object Offset; // 0x1700002A
        public object Waste; // 0x1700002B
        public object DataBuffer; // 0x1700002C

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf7778f0
        public void .ctor(){} // RVA: 0x7ffaaf7778f0
        public void Clear(){} // RVA: 0x7ffaaf777a90
        public void get_ForceDefaults(){} // RVA: 0x7ffaa8b6c110
        public void set_ForceDefaults(){} // RVA: 0x7ffaa92bb760
        public void get_Offset(){} // RVA: 0x7ffaaf76f7c0
        public void get_Waste(){} // RVA: 0x7ffaa89d30c0
        public void Pad(){} // RVA: 0x7ffaaf777bb0
        public void GrowBuffer(){} // RVA: 0x7ffaaf76f900
        public void Prep(){} // RVA: 0x7ffaaf777d00
        public void PutBool(){} // RVA: 0x7ffaaf777dd0
        public void PutSbyte(){} // RVA: 0x7ffaaf777e00
        public void PutByte(){} // RVA: 0x7ffaaf777e00
        public void PutShort(){} // RVA: 0x7ffaaf777e30
        public void PutUshort(){} // RVA: 0x7ffaaf777e30
        public void PutInt(){} // RVA: 0x7ffaaf777e60
        public void PutUint(){} // RVA: 0x7ffaaf777e60
        public void PutLong(){} // RVA: 0x7ffaaf777e90
        public void PutUlong(){} // RVA: 0x7ffaaf777e90
        public void PutFloat(){} // RVA: 0x7ffaaf777ec0
        public void Put(){} // RVA: 0x7ffaa887e5c0
        public void Put(){} // RVA: 0x7ffaa887e5c0
        public void Put(){} // RVA: 0x7ffaa887e5c0
        public void Put(){} // RVA: 0x7ffaa887e5c0
        public void PutDouble(){} // RVA: 0x7ffaaf777ef0
        public void AddBool(){} // RVA: 0x7ffaaf778670
        public void AddSbyte(){} // RVA: 0x7ffaaf7787a0
        public void AddByte(){} // RVA: 0x7ffaaf778850
        public void AddShort(){} // RVA: 0x7ffaaf778980
        public void AddUshort(){} // RVA: 0x7ffaaf778ab0
        public void AddInt(){} // RVA: 0x7ffaaf778be0
        public void AddUint(){} // RVA: 0x7ffaaf778c90
        public void AddLong(){} // RVA: 0x7ffaaf778dc0
        public void AddUlong(){} // RVA: 0x7ffaaf778e70
        public void AddFloat(){} // RVA: 0x7ffaaf778fa0
        public void Add(){} // RVA: 0x7ffaa887e5c0
        public void Add(){} // RVA: 0x7ffaa887e5c0
        public void Add(){} // RVA: 0x7ffaa887e5c0
        public void Add(){} // RVA: 0x7ffaa887e5c0
        public void AddDouble(){} // RVA: 0x7ffaaf7790d0
        public void AddOffset(){} // RVA: 0x7ffaaf779180
        public void StartVector(){} // RVA: 0x7ffaaf778220
        public void EndVector(){} // RVA: 0x7ffaaf7782d0
        public void CreateVectorOfTables(){} // RVA: 0x7ffaa887e5c0
        public void Nested(){} // RVA: 0x7ffaaf778320
        public void NotNested(){} // RVA: 0x7ffaaf7783a0
        public void StartTable(){} // RVA: 0x7ffaaf778410
        public void Slot(){} // RVA: 0x7ffaaf778540
        public void AddBool(){} // RVA: 0x7ffaaf778670
        public void AddBool(){} // RVA: 0x7ffaaf778670
        public void AddSbyte(){} // RVA: 0x7ffaaf7787a0
        public void AddSbyte(){} // RVA: 0x7ffaaf7787a0
        public void AddByte(){} // RVA: 0x7ffaaf778850
        public void AddByte(){} // RVA: 0x7ffaaf778850
        public void AddShort(){} // RVA: 0x7ffaaf778980
        public void AddShort(){} // RVA: 0x7ffaaf778980
        public void AddUshort(){} // RVA: 0x7ffaaf778ab0
        public void AddUshort(){} // RVA: 0x7ffaaf778ab0
        public void AddInt(){} // RVA: 0x7ffaaf778be0
        public void AddInt(){} // RVA: 0x7ffaaf778be0
        public void AddUint(){} // RVA: 0x7ffaaf778c90
        public void AddUint(){} // RVA: 0x7ffaaf778c90
        public void AddLong(){} // RVA: 0x7ffaaf778dc0
        public void AddLong(){} // RVA: 0x7ffaaf778dc0
        public void AddUlong(){} // RVA: 0x7ffaaf778e70
        public void AddUlong(){} // RVA: 0x7ffaaf778e70
        public void AddFloat(){} // RVA: 0x7ffaaf778fa0
        public void AddFloat(){} // RVA: 0x7ffaaf778fa0
        public void AddDouble(){} // RVA: 0x7ffaaf7790d0
        public void AddDouble(){} // RVA: 0x7ffaaf7790d0
        public void AddOffset(){} // RVA: 0x7ffaaf779180
        public void CreateString(){} // RVA: 0x7ffaaf7791c0
        public void CreateUTF8String(){} // RVA: 0x7ffaaf7793e0
        public void CreateSharedString(){} // RVA: 0x7ffaaf779540
        public void AddStruct(){} // RVA: 0x7ffaaf7797d0
        public void EndTable(){} // RVA: 0x7ffaaf779860
        public void Required(){} // RVA: 0x7ffaaf779dd0
        public void Finish(){} // RVA: 0x7ffaaf77a2d0
        public void Finish(){} // RVA: 0x7ffaaf77a2d0
        public void FinishSizePrefixed(){} // RVA: 0x7ffaaf77a2f0
        public void get_DataBuffer(){} // RVA: 0x7ffaa89357c0
        public void SizedByteArray(){} // RVA: 0x7ffaaf77a090
        public void Finish(){} // RVA: 0x7ffaaf77a2d0
        public void Finish(){} // RVA: 0x7ffaaf77a2d0
        public void FinishSizePrefixed(){} // RVA: 0x7ffaaf77a2f0
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
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8d92880
    }

    public class Offset`1 : ValueType
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8d92880
    }

    public class Offset`1 : ValueType
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8d92880
    }

    public class Offset`1 : ValueType
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8d92880
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
        public object max_depth; // 0x339D6040
        public object alignment_check; // 0x339D6040
        public object maxDepth; // 0x1700002D
        public object maxTables; // 0x1700002E

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
        public void __offset(){} // RVA: 0x7ffaaf77c1d0
        public void __offset(){} // RVA: 0x7ffaaf77c1d0
        public void __indirect(){} // RVA: 0x7ffaaf77c260
        public void __indirect(){} // RVA: 0x7ffaaf77c260
        public void __string(){} // RVA: 0x7ffaaf77c290
        public void __vector_len(){} // RVA: 0x7ffaaf77c300
        public void __vector(){} // RVA: 0x7ffaaf77c350
        public void __vector_as_span(){} // RVA: 0x7ffaa887e5c0
        public void __vector_as_array(){} // RVA: 0x7ffaa8658120
        public void __union(){} // RVA: 0x7ffaa887e5c0
        public void __has_identifier(){} // RVA: 0x7ffaaf77c380
        public void CompareStrings(){} // RVA: 0x7ffaaf77c5e0
        public void CompareStrings(){} // RVA: 0x7ffaaf77c5e0
    }

    public class VectorOffset : ValueType
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8d92880
    }

}