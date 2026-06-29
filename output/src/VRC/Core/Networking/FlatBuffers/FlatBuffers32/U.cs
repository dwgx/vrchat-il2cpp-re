// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers32
// Classes: 74
// Methods: 593

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers32
{
    public class Udon : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsUdon(){} // RVA: 0x823F500
        public void VerifyUdon(){} // RVA: 0x8271DA0
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void DataType(){} // RVA: 0x9BC8B0
        public void get_DataTypeLength(){} // RVA: 0x9BCA70
        public void GetDataTypeBytes(){} // RVA: 0x9C3C50
        public void GetDataTypeArray(){} // RVA: 0x9C3CC0
        public void Data(){} // RVA: 0xA94080
        public void get_DataLength(){} // RVA: 0x9BCC80
        public void CreateUdon(){} // RVA: 0x8272030
        public void StartUdon(){} // RVA: 0x82488F0
        public void AddDataType(){} // RVA: 0x82476E0
        public void CreateDataTypeVector(){} // RVA: 0x8247C50
        public void CreateDataTypeVectorBlock(){} // RVA: 0x8272290
        public void StartDataTypeVector(){} // RVA: 0x8247FC0
        public void AddData(){} // RVA: 0x8248B80
        public void CreateDataVector(){} // RVA: 0x823FEE0
        public void CreateDataVectorBlock(){} // RVA: 0x82724F0
        public void StartDataVector(){} // RVA: 0x82402C0
        public void EndUdon(){} // RVA: 0x82725B0
        public void FinishUdonBuffer(){} // RVA: 0x8248E70
        public void FinishSizePrefixedUdonBuffer(){} // RVA: 0x8248ED0
        public void UnPack(){} // RVA: 0x9C3DF0
        public void UnPackTo(){} // RVA: 0x9C3E00
        public void Pack(){} // RVA: 0x8274670
    }

    public class UdonBool : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_Value(){} // RVA: 0x9BC2E0
        public void CreateUdonBool(){} // RVA: 0x8266ED0
        public void UnPack(){} // RVA: 0x9C1510
        public void UnPackTo(){} // RVA: 0x9BC320
        public void Pack(){} // RVA: 0x8266FD0
    }

    public class UdonBoolArray : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsUdonBoolArray(){} // RVA: 0x823F500
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void Value(){} // RVA: 0x9C2220
        public void get_ValueLength(){} // RVA: 0x9BC8C0
        public void GetValueBytes(){} // RVA: 0x9C2230
        public void GetValueArray(){} // RVA: 0x9C22A0
        public void CreateUdonBoolArray(){} // RVA: 0x8268A90
        public void StartUdonBoolArray(){} // RVA: 0x82476C0
        public void AddValue(){} // RVA: 0x82476E0
        public void CreateValueVector(){} // RVA: 0x8268B10
        public void CreateValueVectorBlock(){} // RVA: 0x8268E60
        public void StartValueVector(){} // RVA: 0x8247FC0
        public void EndUdonBoolArray(){} // RVA: 0x8268F20
        public void UnPack(){} // RVA: 0x9C22F0
        public void UnPackTo(){} // RVA: 0x9C2300
        public void Pack(){} // RVA: 0x8269230
    }

    public class UdonBoolArrayT : Object
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0xB5DBF0
        public void set_Value(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0x627C9E0
    }

    public class UdonBoolArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x82484D0
    }

    public class UdonBoolT : Object
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0xC120A0
        public void set_Value(){} // RVA: 0xC120B0
        public void .ctor(){} // RVA: 0xF48510
    }

    public class UdonByte : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_Value(){} // RVA: 0x9BDAF0
        public void CreateUdonByte(){} // RVA: 0x8267110
        public void UnPack(){} // RVA: 0x9C16B0
        public void UnPackTo(){} // RVA: 0x9BFC00
        public void Pack(){} // RVA: 0x8267210
    }

    public class UdonByteArray : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsUdonByteArray(){} // RVA: 0x823F500
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void Value(){} // RVA: 0x9BC8B0
        public void get_ValueLength(){} // RVA: 0x9BC8C0
        public void GetValueBytes(){} // RVA: 0x9C2580
        public void GetValueArray(){} // RVA: 0x9C25F0
        public void CreateUdonByteArray(){} // RVA: 0x8269DD0
        public void StartUdonByteArray(){} // RVA: 0x82476C0
        public void AddValue(){} // RVA: 0x82476E0
        public void CreateValueVector(){} // RVA: 0x8247C50
        public void CreateValueVectorBlock(){} // RVA: 0x8269FF0
        public void StartValueVector(){} // RVA: 0x8247FC0
        public void EndUdonByteArray(){} // RVA: 0x826A0B0
        public void UnPack(){} // RVA: 0x9C2640
        public void UnPackTo(){} // RVA: 0x9C2650
        public void Pack(){} // RVA: 0x826A3C0
    }

    public class UdonByteArrayT : Object
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0xB5DBF0
        public void set_Value(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0x627C9E0
    }

    public class UdonByteArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x82484D0
    }

    public class UdonByteT : Object
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0xC120A0
        public void set_Value(){} // RVA: 0xC120B0
        public void .ctor(){} // RVA: 0xF48510
    }

    public class UdonChar : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_Value(){} // RVA: 0x9BF560
        public void CreateUdonChar(){} // RVA: 0x8266FF0
        public void UnPack(){} // RVA: 0x9C15E0
        public void UnPackTo(){} // RVA: 0x9BF5A0
        public void Pack(){} // RVA: 0x82670F0
    }

    public class UdonCharArray : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsUdonCharArray(){} // RVA: 0x823F500
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void Value(){} // RVA: 0x9C23D0
        public void get_ValueLength(){} // RVA: 0x9BC8C0
        public void GetValueBytes(){} // RVA: 0x9C23E0
        public void GetValueArray(){} // RVA: 0x9C2450
        public void CreateUdonCharArray(){} // RVA: 0x8269460
        public void StartUdonCharArray(){} // RVA: 0x82476C0
        public void AddValue(){} // RVA: 0x82476E0
        public void CreateValueVector(){} // RVA: 0x82694E0
        public void CreateValueVectorBlock(){} // RVA: 0x8269790
        public void StartValueVector(){} // RVA: 0x8269850
        public void EndUdonCharArray(){} // RVA: 0x8269880
        public void UnPack(){} // RVA: 0x9C24A0
        public void UnPackTo(){} // RVA: 0x9C24B0
        public void Pack(){} // RVA: 0x8269BB0
    }

    public class UdonCharArrayT : Object
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0xB5DBF0
        public void set_Value(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0x627C9E0
    }

    public class UdonCharArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x8269CA0
    }

    public class UdonCharT : Object
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0x24EA1D0
        public void set_Value(){} // RVA: 0x24EAB10
        public void .ctor(){} // RVA: 0x26240F0
    }

    public class UdonDouble : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_Value(){} // RVA: 0x9BF9E0
        public void CreateUdonDouble(){} // RVA: 0x82679A0
        public void UnPack(){} // RVA: 0x9C1CA0
        public void UnPackTo(){} // RVA: 0x9BFA20
        public void Pack(){} // RVA: 0x8267AB0
    }

    public class UdonDoubleArray : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsUdonDoubleArray(){} // RVA: 0x823F500
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void Value(){} // RVA: 0x9C3100
        public void get_ValueLength(){} // RVA: 0x9BC8C0
        public void GetValueBytes(){} // RVA: 0x9C3110
        public void GetValueArray(){} // RVA: 0x9C3180
        public void CreateUdonDoubleArray(){} // RVA: 0x826D990
        public void StartUdonDoubleArray(){} // RVA: 0x82476C0
        public void AddValue(){} // RVA: 0x82476E0
        public void CreateValueVector(){} // RVA: 0x826DA10
        public void CreateValueVectorBlock(){} // RVA: 0x826DD60
        public void StartValueVector(){} // RVA: 0x826B230
        public void EndUdonDoubleArray(){} // RVA: 0x826DE20
        public void UnPack(){} // RVA: 0x9C31D0
        public void UnPackTo(){} // RVA: 0x9C31E0
        public void Pack(){} // RVA: 0x826E130
    }

    public class UdonDoubleArrayT : Object
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0xB5DBF0
        public void set_Value(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0x627C9E0
    }

    public class UdonDoubleArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x826B670
    }

    public class UdonDoubleT : Object
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0x2566C50
        public void set_Value(){} // RVA: 0x4B6F180
        public void .ctor(){} // RVA: 0x1968540
    }

    public class UdonFloat : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_Value(){} // RVA: 0x9BC560
        public void CreateUdonFloat(){} // RVA: 0x8267810
        public void UnPack(){} // RVA: 0x9C1BD0
        public void UnPackTo(){} // RVA: 0x9BC5A0
        public void Pack(){} // RVA: 0x8267910
    }

    public class UdonFloatArray : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsUdonFloatArray(){} // RVA: 0x823F500
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void Value(){} // RVA: 0x9C2F50
        public void get_ValueLength(){} // RVA: 0x9BC8C0
        public void GetValueBytes(){} // RVA: 0x9C2F60
        public void GetValueArray(){} // RVA: 0x9C2FD0
        public void CreateUdonFloatArray(){} // RVA: 0x826CFC0
        public void StartUdonFloatArray(){} // RVA: 0x82476C0
        public void AddValue(){} // RVA: 0x82476E0
        public void CreateValueVector(){} // RVA: 0x826D040
        public void CreateValueVectorBlock(){} // RVA: 0x826D390
        public void StartValueVector(){} // RVA: 0x82402C0
        public void EndUdonFloatArray(){} // RVA: 0x826D450
        public void UnPack(){} // RVA: 0x9C3020
        public void UnPackTo(){} // RVA: 0x9C3030
        public void Pack(){} // RVA: 0x826D760
    }

    public class UdonFloatArrayT : Object
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0xB5DBF0
        public void set_Value(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0x627C9E0
    }

    public class UdonFloatArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x82588C0
    }

    public class UdonFloatT : Object
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0xC763E0
        public void set_Value(){} // RVA: 0xC763F0
        public void .ctor(){} // RVA: 0x132A2D0
    }

    public class UdonInfo : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsUdonInfo(){} // RVA: 0x823F500
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void Names(){} // RVA: 0x9BCF10
        public void get_NamesLength(){} // RVA: 0x9BC8C0
        public void Types(){} // RVA: 0x9BCF20
        public void get_TypesLength(){} // RVA: 0x9BCC80
        public void CreateUdonInfo(){} // RVA: 0x824A860
        public void StartUdonInfo(){} // RVA: 0x82488F0
        public void AddNames(){} // RVA: 0x82476E0
        public void CreateNamesVector(){} // RVA: 0x823FEE0
        public void CreateNamesVectorBlock(){} // RVA: 0x824AAB0
        public void StartNamesVector(){} // RVA: 0x82402C0
        public void AddTypes(){} // RVA: 0x8248B80
        public void CreateTypesVector(){} // RVA: 0x823FEE0
        public void CreateTypesVectorBlock(){} // RVA: 0x824AD10
        public void StartTypesVector(){} // RVA: 0x82402C0
        public void EndUdonInfo(){} // RVA: 0x824ADD0
        public void UnPack(){} // RVA: 0x9BCF30
        public void UnPackTo(){} // RVA: 0x9BCF40
        public void Pack(){} // RVA: 0x824B180
    }

    public class UdonInfoT : Object
    {
        // ── Methods ──
        public void get_Names(){} // RVA: 0xB5DBF0
        public void set_Names(){} // RVA: 0xB44D60
        public void get_Types(){} // RVA: 0xB465B0
        public void set_Types(){} // RVA: 0xBA9BA0
        public void .ctor(){} // RVA: 0x8225A50
    }

    public class UdonInfoVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x824B560
    }

    public class UdonInt : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_Value(){} // RVA: 0x9BC420
        public void CreateUdonInt(){} // RVA: 0x8267230
        public void UnPack(){} // RVA: 0x9C1780
        public void UnPackTo(){} // RVA: 0x9BC460
        public void Pack(){} // RVA: 0x8267330
    }

    public class UdonIntArray : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsUdonIntArray(){} // RVA: 0x823F500
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void Value(){} // RVA: 0x9BED50
        public void get_ValueLength(){} // RVA: 0x9BC8C0
        public void GetValueBytes(){} // RVA: 0x9C2720
        public void GetValueArray(){} // RVA: 0x9C2790
        public void CreateUdonIntArray(){} // RVA: 0x826A570
        public void StartUdonIntArray(){} // RVA: 0x82476C0
        public void AddValue(){} // RVA: 0x82476E0
        public void CreateValueVector(){} // RVA: 0x824BC10
        public void CreateValueVectorBlock(){} // RVA: 0x826A790
        public void StartValueVector(){} // RVA: 0x82402C0
        public void EndUdonIntArray(){} // RVA: 0x826A850
        public void UnPack(){} // RVA: 0x9C27E0
        public void UnPackTo(){} // RVA: 0x9C27F0
        public void Pack(){} // RVA: 0x826AB70
    }

    public class UdonIntArrayT : Object
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0xB5DBF0
        public void set_Value(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0x627C9E0
    }

    public class UdonIntArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x82588C0
    }

    public class UdonIntT : Object
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0xB8F8F0
        public void set_Value(){} // RVA: 0xB460A0
        public void .ctor(){} // RVA: 0x132A2D0
    }

    public class UdonLong : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_Value(){} // RVA: 0x9BD940
        public void CreateUdonLong(){} // RVA: 0x8267350
        public void UnPack(){} // RVA: 0x9C1850
        public void UnPackTo(){} // RVA: 0x9C1860
        public void Pack(){} // RVA: 0x8267490
    }

    public class UdonLongArray : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsUdonLongArray(){} // RVA: 0x823F500
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void Value(){} // RVA: 0x9C28C0
        public void get_ValueLength(){} // RVA: 0x9BC8C0
        public void GetValueBytes(){} // RVA: 0x9C28D0
        public void GetValueArray(){} // RVA: 0x9C2940
        public void CreateUdonLongArray(){} // RVA: 0x826ADA0
        public void StartUdonLongArray(){} // RVA: 0x82476C0
        public void AddValue(){} // RVA: 0x82476E0
        public void CreateValueVector(){} // RVA: 0x826AE20
        public void CreateValueVectorBlock(){} // RVA: 0x826B170
        public void StartValueVector(){} // RVA: 0x826B230
        public void EndUdonLongArray(){} // RVA: 0x826B260
        public void UnPack(){} // RVA: 0x9C2990
        public void UnPackTo(){} // RVA: 0x9C29A0
        public void Pack(){} // RVA: 0x826B580
    }

    public class UdonLongArrayT : Object
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0xB5DBF0
        public void set_Value(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0x627C9E0
    }

    public class UdonLongArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x826B670
    }

    public class UdonLongT : Object
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0xB5DBF0
        public void set_Value(){} // RVA: 0x2230E30
        public void .ctor(){} // RVA: 0x1968540
    }

    public class UdonShort : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_Value(){} // RVA: 0x9BF560
        public void CreateUdonShort(){} // RVA: 0x8267B40
        public void UnPack(){} // RVA: 0x9C1D70
        public void UnPackTo(){} // RVA: 0x9BF5A0
        public void Pack(){} // RVA: 0x8267C40
    }

    public class UdonShortArray : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsUdonShortArray(){} // RVA: 0x823F500
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void Value(){} // RVA: 0x9C23D0
        public void get_ValueLength(){} // RVA: 0x9BC8C0
        public void GetValueBytes(){} // RVA: 0x9C32B0
        public void GetValueArray(){} // RVA: 0x9C3320
        public void CreateUdonShortArray(){} // RVA: 0x826E2E0
        public void StartUdonShortArray(){} // RVA: 0x82476C0
        public void AddValue(){} // RVA: 0x82476E0
        public void CreateValueVector(){} // RVA: 0x82694E0
        public void CreateValueVectorBlock(){} // RVA: 0x826E5A0
        public void StartValueVector(){} // RVA: 0x8269850
        public void EndUdonShortArray(){} // RVA: 0x826E660
        public void UnPack(){} // RVA: 0x9C3370
        public void UnPackTo(){} // RVA: 0x9C3380
        public void Pack(){} // RVA: 0x826E990
    }

    public class UdonShortArrayT : Object
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0xB5DBF0
        public void set_Value(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0x627C9E0
    }

    public class UdonShortArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x8269CA0
    }

    public class UdonShortT : Object
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0x24EA1D0
        public void set_Value(){} // RVA: 0x24EAB10
        public void .ctor(){} // RVA: 0x26240F0
    }

    public class UdonString : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsUdonString(){} // RVA: 0x823F500
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_Value(){} // RVA: 0x9BC6A0
        public void GetValueBytes(){} // RVA: 0x9C1F10
        public void GetValueArray(){} // RVA: 0x9C1F80
        public void CreateUdonString(){} // RVA: 0x8267E40
        public void StartUdonString(){} // RVA: 0x82476C0
        public void AddValue(){} // RVA: 0x82476E0
        public void EndUdonString(){} // RVA: 0x8267EC0
        public void UnPack(){} // RVA: 0x9C1FD0
        public void UnPackTo(){} // RVA: 0x9BC780
        public void Pack(){} // RVA: 0x8268020
    }

    public class UdonStringArray : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsUdonStringArray(){} // RVA: 0x823F500
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void Value(){} // RVA: 0x9BCF10
        public void get_ValueLength(){} // RVA: 0x9BC8C0
        public void CreateUdonStringArray(){} // RVA: 0x82680E0
        public void StartUdonStringArray(){} // RVA: 0x82476C0
        public void AddValue(){} // RVA: 0x82476E0
        public void CreateValueVector(){} // RVA: 0x823FEE0
        public void CreateValueVectorBlock(){} // RVA: 0x8268300
        public void StartValueVector(){} // RVA: 0x82402C0
        public void EndUdonStringArray(){} // RVA: 0x82683C0
        public void UnPack(){} // RVA: 0x9C20A0
        public void UnPackTo(){} // RVA: 0x9C2150
        public void Pack(){} // RVA: 0x8268680
    }

    public class UdonStringArrayT : Object
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0xB5DBF0
        public void set_Value(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0x627C9E0
    }

    public class UdonStringArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x82688E0
    }

    public class UdonStringT : Object
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0xB5DBF0
        public void set_Value(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0x627C9E0
    }

    public class UdonStringVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x82479B0
    }

    public class UdonT : Object
    {
        // ── Methods ──
        public void get_Data(){} // RVA: 0xB5DBF0
        public void set_Data(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0x627C9E0
        public void DeserializeFromBinary(){} // RVA: 0x8274A70
        public void SerializeToBinary(){} // RVA: 0x8274B20
    }

    public class UdonUByte : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_Value(){} // RVA: 0x9BDAF0
        public void CreateUdonUByte(){} // RVA: 0x82674B0
        public void UnPack(){} // RVA: 0x9C1960
        public void UnPackTo(){} // RVA: 0x9BFC00
        public void Pack(){} // RVA: 0x82675B0
    }

    public class UdonUByteArray : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsUdonUByteArray(){} // RVA: 0x823F500
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void Value(){} // RVA: 0x9BC8B0
        public void get_ValueLength(){} // RVA: 0x9BC8C0
        public void GetValueBytes(){} // RVA: 0x9C2A70
        public void GetValueArray(){} // RVA: 0x9C2AE0
        public void CreateUdonUByteArray(){} // RVA: 0x826B7A0
        public void StartUdonUByteArray(){} // RVA: 0x82476C0
        public void AddValue(){} // RVA: 0x82476E0
        public void CreateValueVector(){} // RVA: 0x8247C50
        public void CreateValueVectorBlock(){} // RVA: 0x826B9C0
        public void StartValueVector(){} // RVA: 0x8247FC0
        public void EndUdonUByteArray(){} // RVA: 0x826BA80
        public void UnPack(){} // RVA: 0x9C2B30
        public void UnPackTo(){} // RVA: 0x9C2B40
        public void Pack(){} // RVA: 0x826BD90
    }

    public class UdonUByteArrayT : Object
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0xB5DBF0
        public void set_Value(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0x627C9E0
    }

    public class UdonUByteArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x82484D0
    }

    public class UdonUByteT : Object
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0xC120A0
        public void set_Value(){} // RVA: 0xC120B0
        public void .ctor(){} // RVA: 0xF48510
    }

    public class UdonUInt : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_Value(){} // RVA: 0x9BC420
        public void CreateUdonUInt(){} // RVA: 0x82675D0
        public void UnPack(){} // RVA: 0x9C1A30
        public void UnPackTo(){} // RVA: 0x9BC460
        public void Pack(){} // RVA: 0x82676D0
    }

    public class UdonUIntArray : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsUdonUIntArray(){} // RVA: 0x823F500
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void Value(){} // RVA: 0x9BED50
        public void get_ValueLength(){} // RVA: 0x9BC8C0
        public void GetValueBytes(){} // RVA: 0x9C2C10
        public void GetValueArray(){} // RVA: 0x9C2C80
        public void CreateUdonUIntArray(){} // RVA: 0x826BF40
        public void StartUdonUIntArray(){} // RVA: 0x82476C0
        public void AddValue(){} // RVA: 0x82476E0
        public void CreateValueVector(){} // RVA: 0x824BC10
        public void CreateValueVectorBlock(){} // RVA: 0x826C160
        public void StartValueVector(){} // RVA: 0x82402C0
        public void EndUdonUIntArray(){} // RVA: 0x826C220
        public void UnPack(){} // RVA: 0x9C2CD0
        public void UnPackTo(){} // RVA: 0x9C2CE0
        public void Pack(){} // RVA: 0x826C540
    }

    public class UdonUIntArrayT : Object
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0xB5DBF0
        public void set_Value(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0x627C9E0
    }

    public class UdonUIntArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x82588C0
    }

    public class UdonUIntT : Object
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0xB8F8F0
        public void set_Value(){} // RVA: 0xB460A0
        public void .ctor(){} // RVA: 0x132A2D0
    }

    public class UdonULong : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_Value(){} // RVA: 0x9BD940
        public void CreateUdonULong(){} // RVA: 0x82676F0
        public void UnPack(){} // RVA: 0x9C1B00
        public void UnPackTo(){} // RVA: 0x9C1860
        public void Pack(){} // RVA: 0x82677F0
    }

    public class UdonULongArray : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsUdonULongArray(){} // RVA: 0x823F500
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void Value(){} // RVA: 0x9C28C0
        public void get_ValueLength(){} // RVA: 0x9BC8C0
        public void GetValueBytes(){} // RVA: 0x9C2DB0
        public void GetValueArray(){} // RVA: 0x9C2E20
        public void CreateUdonULongArray(){} // RVA: 0x826C6F0
        public void StartUdonULongArray(){} // RVA: 0x82476C0
        public void AddValue(){} // RVA: 0x82476E0
        public void CreateValueVector(){} // RVA: 0x826AE20
        public void CreateValueVectorBlock(){} // RVA: 0x826C9B0
        public void StartValueVector(){} // RVA: 0x826B230
        public void EndUdonULongArray(){} // RVA: 0x826CA70
        public void UnPack(){} // RVA: 0x9C2E70
        public void UnPackTo(){} // RVA: 0x9C2E80
        public void Pack(){} // RVA: 0x826CD90
    }

    public class UdonULongArrayT : Object
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0xB5DBF0
        public void set_Value(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0x627C9E0
    }

    public class UdonULongArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x826B670
    }

    public class UdonULongT : Object
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0xB5DBF0
        public void set_Value(){} // RVA: 0x2230E30
        public void .ctor(){} // RVA: 0x1968540
    }

    public class UdonUShort : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_Value(){} // RVA: 0x9BF560
        public void CreateUdonUShort(){} // RVA: 0x8267C60
        public void UnPack(){} // RVA: 0x9C1E40
        public void UnPackTo(){} // RVA: 0x9BF5A0
        public void Pack(){} // RVA: 0x8267D60
    }

    public class UdonUShortArray : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsUdonUShortArray(){} // RVA: 0x823F500
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void Value(){} // RVA: 0x9C23D0
        public void get_ValueLength(){} // RVA: 0x9BC8C0
        public void GetValueBytes(){} // RVA: 0x9C3450
        public void GetValueArray(){} // RVA: 0x9C34C0
        public void CreateUdonUShortArray(){} // RVA: 0x826EB40
        public void StartUdonUShortArray(){} // RVA: 0x82476C0
        public void AddValue(){} // RVA: 0x82476E0
        public void CreateValueVector(){} // RVA: 0x82694E0
        public void CreateValueVectorBlock(){} // RVA: 0x826ED60
        public void StartValueVector(){} // RVA: 0x8269850
        public void EndUdonUShortArray(){} // RVA: 0x826EE20
        public void UnPack(){} // RVA: 0x9C3510
        public void UnPackTo(){} // RVA: 0x9C3520
        public void Pack(){} // RVA: 0x826F150
    }

    public class UdonUShortArrayT : Object
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0xB5DBF0
        public void set_Value(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0x627C9E0
    }

    public class UdonUShortArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x8269CA0
    }

    public class UdonUShortT : Object
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0x24EA1D0
        public void set_Value(){} // RVA: 0x24EAB10
        public void .ctor(){} // RVA: 0x26240F0
    }

    public class UdonValueUnion : Object
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0xC120A0
        public void set_Type(){} // RVA: 0xC120B0
        public void get_Value(){} // RVA: 0xB465B0
        public void set_Value(){} // RVA: 0xBA9BA0
        public void .ctor(){} // RVA: 0x8215F60
        public void As(){} // RVA: 0xA94080
        public void AsUdonShort(){} // RVA: 0x8261DA0
        public void FromUdonShort(){} // RVA: 0x8261E20
        public void AsUdonUShort(){} // RVA: 0x8261F20
        public void FromUdonUShort(){} // RVA: 0x8261FA0
        public void AsUdonChar(){} // RVA: 0x82620A0
        public void FromUdonChar(){} // RVA: 0x8262120
        public void AsUdonByte(){} // RVA: 0x8262220
        public void FromUdonByte(){} // RVA: 0x82622A0
        public void AsUdonUByte(){} // RVA: 0x82623A0
        public void FromUdonUByte(){} // RVA: 0x8262420
        public void AsUdonLong(){} // RVA: 0x8262520
        public void FromUdonLong(){} // RVA: 0x82625A0
        public void AsUdonULong(){} // RVA: 0x82626A0
        public void FromUdonULong(){} // RVA: 0x8262720
        public void AsUdonDouble(){} // RVA: 0x8262820
        public void FromUdonDouble(){} // RVA: 0x82628A0
        public void AsUdonBool(){} // RVA: 0x82629A0
        public void FromUdonBool(){} // RVA: 0x8262A20
        public void AsUdonFloat(){} // RVA: 0x8262B20
        public void FromUdonFloat(){} // RVA: 0x8262BA0
        public void AsUdonInt(){} // RVA: 0x8262CA0
        public void FromUdonInt(){} // RVA: 0x8262D20
        public void AsUdonUInt(){} // RVA: 0x8262E20
        public void FromUdonUInt(){} // RVA: 0x8262EA0
        public void AsVector2(){} // RVA: 0x8262FA0
        public void FromVector2(){} // RVA: 0x8263020
        public void AsVector3(){} // RVA: 0x8263120
        public void FromVector3(){} // RVA: 0x82631A0
        public void AsVector4(){} // RVA: 0x82632A0
        public void FromVector4(){} // RVA: 0x8263320
        public void AsQuaternion(){} // RVA: 0x8263420
        public void FromQuaternion(){} // RVA: 0x82634A0
        public void AsColor(){} // RVA: 0x82635A0
        public void FromColor(){} // RVA: 0x8263620
        public void AsColor32(){} // RVA: 0x8263720
        public void FromColor32(){} // RVA: 0x82637A0
        public void AsUdonShortArray(){} // RVA: 0x82638A0
        public void FromUdonShortArray(){} // RVA: 0x8263920
        public void AsUdonUShortArray(){} // RVA: 0x8263A20
        public void FromUdonUShortArray(){} // RVA: 0x8263AA0
        public void AsUdonCharArray(){} // RVA: 0x8263BA0
        public void FromUdonCharArray(){} // RVA: 0x8263C20
        public void AsUdonByteArray(){} // RVA: 0x8263D20
        public void FromUdonByteArray(){} // RVA: 0x8263DA0
        public void AsUdonUByteArray(){} // RVA: 0x8263EA0
        public void FromUdonUByteArray(){} // RVA: 0x8263F20
        public void AsUdonLongArray(){} // RVA: 0x8264020
        public void FromUdonLongArray(){} // RVA: 0x82640A0
        public void AsUdonULongArray(){} // RVA: 0x82641A0
        public void FromUdonULongArray(){} // RVA: 0x8264220
        public void AsUdonDoubleArray(){} // RVA: 0x8264320
        public void FromUdonDoubleArray(){} // RVA: 0x82643A0
        public void AsUdonBoolArray(){} // RVA: 0x82644A0
        public void FromUdonBoolArray(){} // RVA: 0x8264520
        public void AsUdonFloatArray(){} // RVA: 0x8264620
        public void FromUdonFloatArray(){} // RVA: 0x82646A0
        public void AsUdonIntArray(){} // RVA: 0x82647A0
        public void FromUdonIntArray(){} // RVA: 0x8264820
        public void AsUdonUIntArray(){} // RVA: 0x8264920
        public void FromUdonUIntArray(){} // RVA: 0x82649A0
        public void AsVector2Array(){} // RVA: 0x8264AA0
        public void FromVector2Array(){} // RVA: 0x8264B20
        public void AsVector3Array(){} // RVA: 0x8264C20
        public void FromVector3Array(){} // RVA: 0x8264CA0
        public void AsVector4Array(){} // RVA: 0x8264DA0
        public void FromVector4Array(){} // RVA: 0x8264E20
        public void AsQuaternionArray(){} // RVA: 0x8264F20
        public void FromQuaternionArray(){} // RVA: 0x8264FA0
        public void AsColorArray(){} // RVA: 0x82650A0
        public void FromColorArray(){} // RVA: 0x8265120
        public void AsColor32Array(){} // RVA: 0x8265220
        public void FromColor32Array(){} // RVA: 0x82652A0
        public void AsUdonString(){} // RVA: 0x82653A0
        public void FromUdonString(){} // RVA: 0x8265420
        public void Pack(){} // RVA: 0x8265520
    }

    public class UdonValueVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x8266AA0
    }

    public class UdonVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x82484D0
    }

}