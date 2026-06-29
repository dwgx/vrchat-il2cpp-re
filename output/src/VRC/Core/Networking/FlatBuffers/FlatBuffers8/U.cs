// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers8
// Classes: 68
// Methods: 543

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers8
{
    public class Udon : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsUdon(){} // RVA: 0x8217320
        public void VerifyUdon(){} // RVA: 0x823BC80
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void DataType(){} // RVA: 0x9B5A40
        public void get_DataTypeLength(){} // RVA: 0x9B5C00
        public void GetDataTypeBytes(){} // RVA: 0x9BB5A0
        public void GetDataTypeArray(){} // RVA: 0x9BB610
        public void Data(){} // RVA: 0xA94080
        public void get_DataLength(){} // RVA: 0x9B5CF0
        public void CreateUdon(){} // RVA: 0x823BF90
        public void StartUdon(){} // RVA: 0x82186D0
        public void AddDataType(){} // RVA: 0x82175B0
        public void CreateDataTypeVector(){} // RVA: 0x8217B40
        public void CreateDataTypeVectorBlock(){} // RVA: 0x823C1E0
        public void StartDataTypeVector(){} // RVA: 0x8217DF0
        public void AddData(){} // RVA: 0x82188E0
        public void CreateDataVector(){} // RVA: 0x8218920
        public void CreateDataVectorBlock(){} // RVA: 0x823C3C0
        public void StartDataVector(){} // RVA: 0x8217DF0
        public void EndUdon(){} // RVA: 0x823C450
        public void FinishUdonBuffer(){} // RVA: 0x8218C30
        public void FinishSizePrefixedUdonBuffer(){} // RVA: 0x8218C90
        public void UnPack(){} // RVA: 0x9BB620
        public void UnPackTo(){} // RVA: 0x9BB630
        public void Pack(){} // RVA: 0x823E560
    }

    public class UdonBool : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_Value(){} // RVA: 0x9B5470
        public void CreateUdonBool(){} // RVA: 0x82311F0
        public void UnPack(){} // RVA: 0x9B8E80
        public void UnPackTo(){} // RVA: 0x9B54B0
        public void Pack(){} // RVA: 0x8231330
    }

    public class UdonBoolArray : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsUdonBoolArray(){} // RVA: 0x8217320
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void Value(){} // RVA: 0x9B9B60
        public void get_ValueLength(){} // RVA: 0x9B5A50
        public void GetValueBytes(){} // RVA: 0x9B9B70
        public void GetValueArray(){} // RVA: 0x9B9BE0
        public void CreateUdonBoolArray(){} // RVA: 0x82328D0
        public void StartUdonBoolArray(){} // RVA: 0x8217590
        public void AddValue(){} // RVA: 0x82175B0
        public void CreateValueVector(){} // RVA: 0x8232990
        public void CreateValueVectorBlock(){} // RVA: 0x8232C50
        public void StartValueVector(){} // RVA: 0x8217DF0
        public void EndUdonBoolArray(){} // RVA: 0x8232CE0
        public void UnPack(){} // RVA: 0x9B9C30
        public void UnPackTo(){} // RVA: 0x9B9C40
        public void Pack(){} // RVA: 0x8233030
    }

    public class UdonBoolArrayT : Object
    {
        public object _value;

        // ── Methods ──
        public void get_Value(){} // RVA: 0xB5DBF0
        public void set_Value(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0x627C9E0
    }

    public class UdonBoolArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x82181F0
    }

    public class UdonBoolT : Object
    {
        public object _value;

        // ── Methods ──
        public void get_Value(){} // RVA: 0xC120A0
        public void set_Value(){} // RVA: 0xC120B0
        public void .ctor(){} // RVA: 0xF48510
    }

    public class UdonByte : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_Value(){} // RVA: 0x9B64A0
        public void CreateUdonByte(){} // RVA: 0x8231520
        public void UnPack(){} // RVA: 0x9B9090
        public void UnPackTo(){} // RVA: 0x9B90A0
        public void Pack(){} // RVA: 0x82316A0
    }

    public class UdonByteArray : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsUdonByteArray(){} // RVA: 0x8217320
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void Value(){} // RVA: 0x9B5A40
        public void get_ValueLength(){} // RVA: 0x9B5A50
        public void GetValueBytes(){} // RVA: 0x9B9EC0
        public void GetValueArray(){} // RVA: 0x9B9F30
        public void CreateUdonByteArray(){} // RVA: 0x8233AC0
        public void StartUdonByteArray(){} // RVA: 0x8217590
        public void AddValue(){} // RVA: 0x82175B0
        public void CreateValueVector(){} // RVA: 0x8217B40
        public void CreateValueVectorBlock(){} // RVA: 0x8233CD0
        public void StartValueVector(){} // RVA: 0x8217DF0
        public void EndUdonByteArray(){} // RVA: 0x8233D60
        public void UnPack(){} // RVA: 0x9B9F80
        public void UnPackTo(){} // RVA: 0x9B9F90
        public void Pack(){} // RVA: 0x82340B0
    }

    public class UdonByteArrayT : Object
    {
        public object _value;

        // ── Methods ──
        public void get_Value(){} // RVA: 0xB5DBF0
        public void set_Value(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0x627C9E0
    }

    public class UdonByteArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x82181F0
    }

    public class UdonByteT : Object
    {
        public object _value;

        // ── Methods ──
        public void get_Value(){} // RVA: 0xC120A0
        public void set_Value(){} // RVA: 0xC120B0
        public void .ctor(){} // RVA: 0xF48510
    }

    public class UdonChar : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_Value(){} // RVA: 0x9B8F50
        public void CreateUdonChar(){} // RVA: 0x8231380
        public void UnPack(){} // RVA: 0x9B8F80
        public void UnPackTo(){} // RVA: 0x9B8F90
        public void Pack(){} // RVA: 0x8231500
    }

    public class UdonCharArray : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsUdonCharArray(){} // RVA: 0x8217320
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void Value(){} // RVA: 0x9B9D10
        public void get_ValueLength(){} // RVA: 0x9B5A50
        public void GetValueBytes(){} // RVA: 0x9B9D20
        public void GetValueArray(){} // RVA: 0x9B9D90
        public void CreateUdonCharArray(){} // RVA: 0x82331F0
        public void StartUdonCharArray(){} // RVA: 0x8217590
        public void AddValue(){} // RVA: 0x82175B0
        public void CreateValueVector(){} // RVA: 0x82332B0
        public void CreateValueVectorBlock(){} // RVA: 0x82334E0
        public void StartValueVector(){} // RVA: 0x8233570
        public void EndUdonCharArray(){} // RVA: 0x82335A0
        public void UnPack(){} // RVA: 0x9B9DE0
        public void UnPackTo(){} // RVA: 0x9B9DF0
        public void Pack(){} // RVA: 0x8233910
    }

    public class UdonCharArrayT : Object
    {
        public object _value;

        // ── Methods ──
        public void get_Value(){} // RVA: 0xB5DBF0
        public void set_Value(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0x627C9E0
    }

    public class UdonCharArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x8233990
    }

    public class UdonCharT : Object
    {
        public object _value;

        // ── Methods ──
        public void get_Value(){} // RVA: 0x24EA1D0
        public void set_Value(){} // RVA: 0x24EAB10
        public void .ctor(){} // RVA: 0x26240F0
    }

    public class UdonDouble : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_Value(){} // RVA: 0x9B96F0
        public void CreateUdonDouble(){} // RVA: 0x8231FA0
        public void UnPack(){} // RVA: 0x9B9720
        public void UnPackTo(){} // RVA: 0x9B9730
        public void Pack(){} // RVA: 0x8232130
    }

    public class UdonDoubleArray : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsUdonDoubleArray(){} // RVA: 0x8217320
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void Value(){} // RVA: 0x9BAA50
        public void get_ValueLength(){} // RVA: 0x9B5A50
        public void GetValueBytes(){} // RVA: 0x9BAA60
        public void GetValueArray(){} // RVA: 0x9BAAD0
        public void CreateUdonDoubleArray(){} // RVA: 0x8237690
        public void StartUdonDoubleArray(){} // RVA: 0x8217590
        public void AddValue(){} // RVA: 0x82175B0
        public void CreateValueVector(){} // RVA: 0x8237750
        public void CreateValueVectorBlock(){} // RVA: 0x8237A10
        public void StartValueVector(){} // RVA: 0x8235080
        public void EndUdonDoubleArray(){} // RVA: 0x8237AA0
        public void UnPack(){} // RVA: 0x9BAB20
        public void UnPackTo(){} // RVA: 0x9BAB30
        public void Pack(){} // RVA: 0x8237E00
    }

    public class UdonDoubleArrayT : Object
    {
        public object _value;

        // ── Methods ──
        public void get_Value(){} // RVA: 0xB5DBF0
        public void set_Value(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0x627C9E0
    }

    public class UdonDoubleArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x82354A0
    }

    public class UdonDoubleT : Object
    {
        public object _value;

        // ── Methods ──
        public void get_Value(){} // RVA: 0x2566C50
        public void set_Value(){} // RVA: 0x4B6F180
        public void .ctor(){} // RVA: 0x1968540
    }

    public class UdonFloat : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_Value(){} // RVA: 0x9B56F0
        public void CreateUdonFloat(){} // RVA: 0x8231E10
        public void UnPack(){} // RVA: 0x9B9620
        public void UnPackTo(){} // RVA: 0x9B5730
        public void Pack(){} // RVA: 0x8231F50
    }

    public class UdonFloatArray : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsUdonFloatArray(){} // RVA: 0x8217320
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void Value(){} // RVA: 0x9BA8A0
        public void get_ValueLength(){} // RVA: 0x9B5A50
        public void GetValueBytes(){} // RVA: 0x9BA8B0
        public void GetValueArray(){} // RVA: 0x9BA920
        public void CreateUdonFloatArray(){} // RVA: 0x8236D60
        public void StartUdonFloatArray(){} // RVA: 0x8217590
        public void AddValue(){} // RVA: 0x82175B0
        public void CreateValueVector(){} // RVA: 0x8236E20
        public void CreateValueVectorBlock(){} // RVA: 0x82370E0
        public void StartValueVector(){} // RVA: 0x8234690
        public void EndUdonFloatArray(){} // RVA: 0x8237170
        public void UnPack(){} // RVA: 0x9BA970
        public void UnPackTo(){} // RVA: 0x9BA980
        public void Pack(){} // RVA: 0x82374D0
    }

    public class UdonFloatArrayT : Object
    {
        public object _value;

        // ── Methods ──
        public void get_Value(){} // RVA: 0xB5DBF0
        public void set_Value(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0x627C9E0
    }

    public class UdonFloatArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x8234AB0
    }

    public class UdonFloatT : Object
    {
        public object _value;

        // ── Methods ──
        public void get_Value(){} // RVA: 0xC763E0
        public void set_Value(){} // RVA: 0xC763F0
        public void .ctor(){} // RVA: 0x132A2D0
    }

    public class UdonInt : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_Value(){} // RVA: 0x9B55B0
        public void CreateUdonInt(){} // RVA: 0x82316C0
        public void UnPack(){} // RVA: 0x9B91A0
        public void UnPackTo(){} // RVA: 0x9B55F0
        public void Pack(){} // RVA: 0x8231800
    }

    public class UdonIntArray : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsUdonIntArray(){} // RVA: 0x8217320
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void Value(){} // RVA: 0x9BA060
        public void get_ValueLength(){} // RVA: 0x9B5A50
        public void GetValueBytes(){} // RVA: 0x9BA070
        public void GetValueArray(){} // RVA: 0x9BA0E0
        public void CreateUdonIntArray(){} // RVA: 0x8234270
        public void StartUdonIntArray(){} // RVA: 0x8217590
        public void AddValue(){} // RVA: 0x82175B0
        public void CreateValueVector(){} // RVA: 0x8234330
        public void CreateValueVectorBlock(){} // RVA: 0x8234600
        public void StartValueVector(){} // RVA: 0x8234690
        public void EndUdonIntArray(){} // RVA: 0x82346C0
        public void UnPack(){} // RVA: 0x9BA130
        public void UnPackTo(){} // RVA: 0x9BA140
        public void Pack(){} // RVA: 0x8234A30
    }

    public class UdonIntArrayT : Object
    {
        public object _value;

        // ── Methods ──
        public void get_Value(){} // RVA: 0xB5DBF0
        public void set_Value(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0x627C9E0
    }

    public class UdonIntArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x8234AB0
    }

    public class UdonIntT : Object
    {
        public object _value;

        // ── Methods ──
        public void get_Value(){} // RVA: 0xB8F8F0
        public void set_Value(){} // RVA: 0xB460A0
        public void .ctor(){} // RVA: 0x132A2D0
    }

    public class UdonLong : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_Value(){} // RVA: 0x9B9270
        public void CreateUdonLong(){} // RVA: 0x8231850
        public void UnPack(){} // RVA: 0x9B92A0
        public void UnPackTo(){} // RVA: 0x9B92B0
        public void Pack(){} // RVA: 0x82319D0
    }

    public class UdonLongArray : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsUdonLongArray(){} // RVA: 0x8217320
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void Value(){} // RVA: 0x9BA210
        public void get_ValueLength(){} // RVA: 0x9B5A50
        public void GetValueBytes(){} // RVA: 0x9BA220
        public void GetValueArray(){} // RVA: 0x9BA290
        public void CreateUdonLongArray(){} // RVA: 0x8234C60
        public void StartUdonLongArray(){} // RVA: 0x8217590
        public void AddValue(){} // RVA: 0x82175B0
        public void CreateValueVector(){} // RVA: 0x8234D20
        public void CreateValueVectorBlock(){} // RVA: 0x8234FF0
        public void StartValueVector(){} // RVA: 0x8235080
        public void EndUdonLongArray(){} // RVA: 0x82350B0
        public void UnPack(){} // RVA: 0x9BA2E0
        public void UnPackTo(){} // RVA: 0x9BA2F0
        public void Pack(){} // RVA: 0x8235420
    }

    public class UdonLongArrayT : Object
    {
        public object _value;

        // ── Methods ──
        public void get_Value(){} // RVA: 0xB5DBF0
        public void set_Value(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0x627C9E0
    }

    public class UdonLongArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x82354A0
    }

    public class UdonLongT : Object
    {
        public object _value;

        // ── Methods ──
        public void get_Value(){} // RVA: 0xB5DBF0
        public void set_Value(){} // RVA: 0x2230E30
        public void .ctor(){} // RVA: 0x1968540
    }

    public class UdonShort : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_Value(){} // RVA: 0x9B8F50
        public void CreateUdonShort(){} // RVA: 0x8232150
        public void UnPack(){} // RVA: 0x9B9830
        public void UnPackTo(){} // RVA: 0x9B8F90
        public void Pack(){} // RVA: 0x8232290
    }

    public class UdonShortArray : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsUdonShortArray(){} // RVA: 0x8217320
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void Value(){} // RVA: 0x9B9D10
        public void get_ValueLength(){} // RVA: 0x9B5A50
        public void GetValueBytes(){} // RVA: 0x9BAC00
        public void GetValueArray(){} // RVA: 0x9BAC70
        public void CreateUdonShortArray(){} // RVA: 0x8237F40
        public void StartUdonShortArray(){} // RVA: 0x8217590
        public void AddValue(){} // RVA: 0x82175B0
        public void CreateValueVector(){} // RVA: 0x82332B0
        public void CreateValueVectorBlock(){} // RVA: 0x82381F0
        public void StartValueVector(){} // RVA: 0x8233570
        public void EndUdonShortArray(){} // RVA: 0x8238280
        public void UnPack(){} // RVA: 0x9BACC0
        public void UnPackTo(){} // RVA: 0x9BACD0
        public void Pack(){} // RVA: 0x82385F0
    }

    public class UdonShortArrayT : Object
    {
        public object _value;

        // ── Methods ──
        public void get_Value(){} // RVA: 0xB5DBF0
        public void set_Value(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0x627C9E0
    }

    public class UdonShortArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x8233990
    }

    public class UdonShortT : Object
    {
        public object _value;

        // ── Methods ──
        public void get_Value(){} // RVA: 0x24EA1D0
        public void set_Value(){} // RVA: 0x24EAB10
        public void .ctor(){} // RVA: 0x26240F0
    }

    public class UdonString : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsUdonString(){} // RVA: 0x8217320
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_Value(){} // RVA: 0x9B5830
        public void GetValueBytes(){} // RVA: 0x9B99D0
        public void GetValueArray(){} // RVA: 0x9B9A40
        public void CreateUdonString(){} // RVA: 0x82324D0
        public void StartUdonString(){} // RVA: 0x8217590
        public void AddValue(){} // RVA: 0x82175B0
        public void EndUdonString(){} // RVA: 0x8232590
        public void UnPack(){} // RVA: 0x9B9A90
        public void UnPackTo(){} // RVA: 0x9B5910
        public void Pack(){} // RVA: 0x8232730
    }

    public class UdonStringT : Object
    {
        public object _value;

        // ── Methods ──
        public void get_Value(){} // RVA: 0xB5DBF0
        public void set_Value(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0x627C9E0
    }

    public class UdonStringVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x8217860
    }

    public class UdonT : Object
    {
        public object _data;

        // ── Methods ──
        public void get_Data(){} // RVA: 0xB5DBF0
        public void set_Data(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0x627C9E0
        public void DeserializeFromBinary(){} // RVA: 0x823E850
        public void SerializeToBinary(){} // RVA: 0x823E900
    }

    public class UdonUByte : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_Value(){} // RVA: 0x9B64A0
        public void CreateUdonUByte(){} // RVA: 0x82319F0
        public void UnPack(){} // RVA: 0x9B93B0
        public void UnPackTo(){} // RVA: 0x9B90A0
        public void Pack(){} // RVA: 0x8231B30
    }

    public class UdonUByteArray : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsUdonUByteArray(){} // RVA: 0x8217320
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void Value(){} // RVA: 0x9B5A40
        public void get_ValueLength(){} // RVA: 0x9B5A50
        public void GetValueBytes(){} // RVA: 0x9BA3C0
        public void GetValueArray(){} // RVA: 0x9BA430
        public void CreateUdonUByteArray(){} // RVA: 0x82355D0
        public void StartUdonUByteArray(){} // RVA: 0x8217590
        public void AddValue(){} // RVA: 0x82175B0
        public void CreateValueVector(){} // RVA: 0x8217B40
        public void CreateValueVectorBlock(){} // RVA: 0x82357E0
        public void StartValueVector(){} // RVA: 0x8217DF0
        public void EndUdonUByteArray(){} // RVA: 0x8235870
        public void UnPack(){} // RVA: 0x9BA480
        public void UnPackTo(){} // RVA: 0x9BA490
        public void Pack(){} // RVA: 0x8235BC0
    }

    public class UdonUByteArrayT : Object
    {
        public object _value;

        // ── Methods ──
        public void get_Value(){} // RVA: 0xB5DBF0
        public void set_Value(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0x627C9E0
    }

    public class UdonUByteArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x82181F0
    }

    public class UdonUByteT : Object
    {
        public object _value;

        // ── Methods ──
        public void get_Value(){} // RVA: 0xC120A0
        public void set_Value(){} // RVA: 0xC120B0
        public void .ctor(){} // RVA: 0xF48510
    }

    public class UdonUInt : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_Value(){} // RVA: 0x9B55B0
        public void CreateUdonUInt(){} // RVA: 0x8231B50
        public void UnPack(){} // RVA: 0x9B9480
        public void UnPackTo(){} // RVA: 0x9B55F0
        public void Pack(){} // RVA: 0x8231C90
    }

    public class UdonUIntArray : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsUdonUIntArray(){} // RVA: 0x8217320
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void Value(){} // RVA: 0x9BA060
        public void get_ValueLength(){} // RVA: 0x9B5A50
        public void GetValueBytes(){} // RVA: 0x9BA560
        public void GetValueArray(){} // RVA: 0x9BA5D0
        public void CreateUdonUIntArray(){} // RVA: 0x8235D00
        public void StartUdonUIntArray(){} // RVA: 0x8217590
        public void AddValue(){} // RVA: 0x82175B0
        public void CreateValueVector(){} // RVA: 0x8234330
        public void CreateValueVectorBlock(){} // RVA: 0x8235FB0
        public void StartValueVector(){} // RVA: 0x8234690
        public void EndUdonUIntArray(){} // RVA: 0x8236040
        public void UnPack(){} // RVA: 0x9BA620
        public void UnPackTo(){} // RVA: 0x9BA630
        public void Pack(){} // RVA: 0x82363B0
    }

    public class UdonUIntArrayT : Object
    {
        public object _value;

        // ── Methods ──
        public void get_Value(){} // RVA: 0xB5DBF0
        public void set_Value(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0x627C9E0
    }

    public class UdonUIntArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x8234AB0
    }

    public class UdonUIntT : Object
    {
        public object _value;

        // ── Methods ──
        public void get_Value(){} // RVA: 0xB8F8F0
        public void set_Value(){} // RVA: 0xB460A0
        public void .ctor(){} // RVA: 0x132A2D0
    }

    public class UdonULong : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_Value(){} // RVA: 0x9B9270
        public void CreateUdonULong(){} // RVA: 0x8231CB0
        public void UnPack(){} // RVA: 0x9B9550
        public void UnPackTo(){} // RVA: 0x9B92B0
        public void Pack(){} // RVA: 0x8231DF0
    }

    public class UdonULongArray : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsUdonULongArray(){} // RVA: 0x8217320
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void Value(){} // RVA: 0x9BA210
        public void get_ValueLength(){} // RVA: 0x9B5A50
        public void GetValueBytes(){} // RVA: 0x9BA700
        public void GetValueArray(){} // RVA: 0x9BA770
        public void CreateUdonULongArray(){} // RVA: 0x82364F0
        public void StartUdonULongArray(){} // RVA: 0x8217590
        public void AddValue(){} // RVA: 0x82175B0
        public void CreateValueVector(){} // RVA: 0x8234D20
        public void CreateValueVectorBlock(){} // RVA: 0x82367A0
        public void StartValueVector(){} // RVA: 0x8235080
        public void EndUdonULongArray(){} // RVA: 0x8236830
        public void UnPack(){} // RVA: 0x9BA7C0
        public void UnPackTo(){} // RVA: 0x9BA7D0
        public void Pack(){} // RVA: 0x8236BA0
    }

    public class UdonULongArrayT : Object
    {
        public object _value;

        // ── Methods ──
        public void get_Value(){} // RVA: 0xB5DBF0
        public void set_Value(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0x627C9E0
    }

    public class UdonULongArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x82354A0
    }

    public class UdonULongT : Object
    {
        public object _value;

        // ── Methods ──
        public void get_Value(){} // RVA: 0xB5DBF0
        public void set_Value(){} // RVA: 0x2230E30
        public void .ctor(){} // RVA: 0x1968540
    }

    public class UdonUShort : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_Value(){} // RVA: 0x9B8F50
        public void CreateUdonUShort(){} // RVA: 0x82322B0
        public void UnPack(){} // RVA: 0x9B9900
        public void UnPackTo(){} // RVA: 0x9B8F90
        public void Pack(){} // RVA: 0x82323F0
    }

    public class UdonUShortArray : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsUdonUShortArray(){} // RVA: 0x8217320
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void Value(){} // RVA: 0x9B9D10
        public void get_ValueLength(){} // RVA: 0x9B5A50
        public void GetValueBytes(){} // RVA: 0x9BADA0
        public void GetValueArray(){} // RVA: 0x9BAE10
        public void CreateUdonUShortArray(){} // RVA: 0x8238730
        public void StartUdonUShortArray(){} // RVA: 0x8217590
        public void AddValue(){} // RVA: 0x82175B0
        public void CreateValueVector(){} // RVA: 0x82332B0
        public void CreateValueVectorBlock(){} // RVA: 0x8238940
        public void StartValueVector(){} // RVA: 0x8233570
        public void EndUdonUShortArray(){} // RVA: 0x82389D0
        public void UnPack(){} // RVA: 0x9BAE60
        public void UnPackTo(){} // RVA: 0x9BAE70
        public void Pack(){} // RVA: 0x8238D40
    }

    public class UdonUShortArrayT : Object
    {
        public object _value;

        // ── Methods ──
        public void get_Value(){} // RVA: 0xB5DBF0
        public void set_Value(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0x627C9E0
    }

    public class UdonUShortArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x8233990
    }

    public class UdonUShortT : Object
    {
        public object _value;

        // ── Methods ──
        public void get_Value(){} // RVA: 0x24EA1D0
        public void set_Value(){} // RVA: 0x24EAB10
        public void .ctor(){} // RVA: 0x26240F0
    }

    public class UdonValueUnion : Object
    {
        public object _type;
        public object _value;

        // ── Methods ──
        public void get_Type(){} // RVA: 0xC120A0
        public void set_Type(){} // RVA: 0xC120B0
        public void get_Value(){} // RVA: 0xB465B0
        public void set_Value(){} // RVA: 0xBA9BA0
        public void .ctor(){} // RVA: 0x8215F60
        public void As(){} // RVA: 0xA94080
        public void AsUdonShort(){} // RVA: 0x822C030
        public void FromUdonShort(){} // RVA: 0x822C0B0
        public void AsUdonUShort(){} // RVA: 0x822C1B0
        public void FromUdonUShort(){} // RVA: 0x822C230
        public void AsUdonChar(){} // RVA: 0x822C330
        public void FromUdonChar(){} // RVA: 0x822C3B0
        public void AsUdonByte(){} // RVA: 0x822C4B0
        public void FromUdonByte(){} // RVA: 0x822C530
        public void AsUdonUByte(){} // RVA: 0x822C630
        public void FromUdonUByte(){} // RVA: 0x822C6B0
        public void AsUdonLong(){} // RVA: 0x822C7B0
        public void FromUdonLong(){} // RVA: 0x822C830
        public void AsUdonULong(){} // RVA: 0x822C930
        public void FromUdonULong(){} // RVA: 0x822C9B0
        public void AsUdonDouble(){} // RVA: 0x822CAB0
        public void FromUdonDouble(){} // RVA: 0x822CB30
        public void AsUdonBool(){} // RVA: 0x822CC30
        public void FromUdonBool(){} // RVA: 0x822CCB0
        public void AsUdonFloat(){} // RVA: 0x822CDB0
        public void FromUdonFloat(){} // RVA: 0x822CE30
        public void AsUdonInt(){} // RVA: 0x822CF30
        public void FromUdonInt(){} // RVA: 0x822CFB0
        public void AsUdonUInt(){} // RVA: 0x822D0B0
        public void FromUdonUInt(){} // RVA: 0x822D130
        public void AsVector2(){} // RVA: 0x822D230
        public void FromVector2(){} // RVA: 0x822D2B0
        public void AsVector3(){} // RVA: 0x822D3B0
        public void FromVector3(){} // RVA: 0x822D430
        public void AsVector4(){} // RVA: 0x822D530
        public void FromVector4(){} // RVA: 0x822D5B0
        public void AsQuaternion(){} // RVA: 0x822D6B0
        public void FromQuaternion(){} // RVA: 0x822D730
        public void AsColor(){} // RVA: 0x822D830
        public void FromColor(){} // RVA: 0x822D8B0
        public void AsColor32(){} // RVA: 0x822D9B0
        public void FromColor32(){} // RVA: 0x822DA30
        public void AsUdonShortArray(){} // RVA: 0x822DB30
        public void FromUdonShortArray(){} // RVA: 0x822DBB0
        public void AsUdonUShortArray(){} // RVA: 0x822DCB0
        public void FromUdonUShortArray(){} // RVA: 0x822DD30
        public void AsUdonCharArray(){} // RVA: 0x822DE30
        public void FromUdonCharArray(){} // RVA: 0x822DEB0
        public void AsUdonByteArray(){} // RVA: 0x822DFB0
        public void FromUdonByteArray(){} // RVA: 0x822E030
        public void AsUdonUByteArray(){} // RVA: 0x822E130
        public void FromUdonUByteArray(){} // RVA: 0x822E1B0
        public void AsUdonLongArray(){} // RVA: 0x822E2B0
        public void FromUdonLongArray(){} // RVA: 0x822E330
        public void AsUdonULongArray(){} // RVA: 0x822E430
        public void FromUdonULongArray(){} // RVA: 0x822E4B0
        public void AsUdonDoubleArray(){} // RVA: 0x822E5B0
        public void FromUdonDoubleArray(){} // RVA: 0x822E630
        public void AsUdonBoolArray(){} // RVA: 0x822E730
        public void FromUdonBoolArray(){} // RVA: 0x822E7B0
        public void AsUdonFloatArray(){} // RVA: 0x822E8B0
        public void FromUdonFloatArray(){} // RVA: 0x822E930
        public void AsUdonIntArray(){} // RVA: 0x822EA30
        public void FromUdonIntArray(){} // RVA: 0x822EAB0
        public void AsUdonUIntArray(){} // RVA: 0x822EBB0
        public void FromUdonUIntArray(){} // RVA: 0x822EC30
        public void AsVector2Array(){} // RVA: 0x822ED30
        public void FromVector2Array(){} // RVA: 0x822EDB0
        public void AsVector3Array(){} // RVA: 0x822EEB0
        public void FromVector3Array(){} // RVA: 0x822EF30
        public void AsVector4Array(){} // RVA: 0x822F030
        public void FromVector4Array(){} // RVA: 0x822F0B0
        public void AsQuaternionArray(){} // RVA: 0x822F1B0
        public void FromQuaternionArray(){} // RVA: 0x822F230
        public void AsColorArray(){} // RVA: 0x822F330
        public void FromColorArray(){} // RVA: 0x822F3B0
        public void AsColor32Array(){} // RVA: 0x822F4B0
        public void FromColor32Array(){} // RVA: 0x822F530
        public void AsUdonString(){} // RVA: 0x822F630
        public void FromUdonString(){} // RVA: 0x822F6B0
        public void Pack(){} // RVA: 0x822F7B0
    }

    public class UdonValueVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x8230DB0
    }

    public class UdonVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x82181F0
    }

}