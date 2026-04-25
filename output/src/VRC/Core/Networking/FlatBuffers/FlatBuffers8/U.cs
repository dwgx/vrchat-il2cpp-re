// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers8
// Classes: 68
// Methods: 609

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers8
{
    public class Udon : ValueType
    {
        public Google.FlatBuffers8.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsUdon(){} // RVA: 0x7FFAC9D75670 | overloaded x2
        public void VerifyUdon(){} // RVA: 0x7FFAC9D99350
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void DataType(){} // RVA: 0x7FFAC9D75C20
        public void get_DataTypeLength(){} // RVA: 0x7FFAC9D75CA0
        public void GetDataTypeBytes(){} // RVA: 0x7FFAC9D99440
        public void GetDataTypeArray(){} // RVA: 0x7FFAC9D994B0
        public void Data(){} // RVA: 0x7FFAC2E8DC40
        public void get_DataLength(){} // RVA: 0x7FFAC9D76940
        public void CreateUdon(){} // RVA: 0x7FFAC9D99660
        public void StartUdon(){} // RVA: 0x7FFAC9D76AA0
        public void AddDataType(){} // RVA: 0x7FFAC9D75900
        public void CreateDataTypeVector(){} // RVA: 0x7FFAC9D75F20
        public void CreateDataTypeVectorBlock(){} // RVA: 0x7FFAC9D998B0 | overloaded x3
        public void StartDataTypeVector(){} // RVA: 0x7FFAC9D761C0
        public void AddData(){} // RVA: 0x7FFAC9D76CB0
        public void CreateDataVector(){} // RVA: 0x7FFAC9D76CF0
        public void CreateDataVectorBlock(){} // RVA: 0x7FFAC9D99A90 | overloaded x3
        public void StartDataVector(){} // RVA: 0x7FFAC9D761C0
        public void EndUdon(){} // RVA: 0x7FFAC9D99B20
        public void FinishUdonBuffer(){} // RVA: 0x7FFAC9D76FF0
        public void FinishSizePrefixedUdonBuffer(){} // RVA: 0x7FFAC9D77050
        public void UnPack(){} // RVA: 0x7FFAC9D99BB0
        public void UnPackTo(){} // RVA: 0x7FFAC9D99C60
        public void Pack(){} // RVA: 0x7FFAC9D9BC20
    }

    public class UdonBool : ValueType
    {
        public Google.FlatBuffers8.Struct ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_Value(){} // RVA: 0x7FFAC9D75000
        public void MutateValue(){} // RVA: 0x7FFAC9D75030
        public void CreateUdonBool(){} // RVA: 0x7FFAC9D8E650
        public void UnPack(){} // RVA: 0x7FFAC9D8E720
        public void UnPackTo(){} // RVA: 0x7FFAC9D751A0
        public void Pack(){} // RVA: 0x7FFAC9D8E790
    }

    public class UdonBoolArray : ValueType
    {
        public Google.FlatBuffers8.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsUdonBoolArray(){} // RVA: 0x7FFAC9D75670 | overloaded x2
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void Value(){} // RVA: 0x7FFAC9D8FCA0
        public void get_ValueLength(){} // RVA: 0x7FFAC9D75CA0
        public void GetValueBytes(){} // RVA: 0x7FFAC9D8FD20
        public void GetValueArray(){} // RVA: 0x7FFAC9D8FD90
        public void MutateValue(){} // RVA: 0x7FFAC9D8FDE0
        public void CreateUdonBoolArray(){} // RVA: 0x7FFAC9D8FE70
        public void StartUdonBoolArray(){} // RVA: 0x7FFAC9D758E0
        public void AddValue(){} // RVA: 0x7FFAC9D75900
        public void CreateValueVector(){} // RVA: 0x7FFAC9D8FF30
        public void CreateValueVectorBlock(){} // RVA: 0x7FFAC9D901E0 | overloaded x3
        public void StartValueVector(){} // RVA: 0x7FFAC9D761C0
        public void EndUdonBoolArray(){} // RVA: 0x7FFAC9D90270
        public void UnPack(){} // RVA: 0x7FFAC9D90300
        public void UnPackTo(){} // RVA: 0x7FFAC9D903B0
        public void Pack(){} // RVA: 0x7FFAC9D905C0
    }

    public class UdonBoolArrayT : Object
    {
        public System.Collections.Generic.List`1<bool> Value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAC2F3C380
        public void set_Value(){} // RVA: 0x7FFAC2F22E30
        public void .ctor(){} // RVA: 0x7FFAC7DDDC00
    }

    public class UdonBoolArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAC9D765C0
    }

    public class UdonBoolT : Object
    {
        public bool Value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAC2FEB5E0
        public void set_Value(){} // RVA: 0x7FFAC2FEB5F0
        public void .ctor(){} // RVA: 0x7FFAC322C880
    }

    public class UdonByte : ValueType
    {
        public Google.FlatBuffers8.Struct ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_Value(){} // RVA: 0x7FFAC9D7A9A0
        public void MutateValue(){} // RVA: 0x7FFAC9D75030
        public void CreateUdonByte(){} // RVA: 0x7FFAC9D8E9B0
        public void UnPack(){} // RVA: 0x7FFAC9D8EA80
        public void UnPackTo(){} // RVA: 0x7FFAC9D8EAF0
        public void Pack(){} // RVA: 0x7FFAC9D8EB30
    }

    public class UdonByteArray : ValueType
    {
        public Google.FlatBuffers8.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsUdonByteArray(){} // RVA: 0x7FFAC9D75670 | overloaded x2
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void Value(){} // RVA: 0x7FFAC9D75C20
        public void get_ValueLength(){} // RVA: 0x7FFAC9D75CA0
        public void GetValueBytes(){} // RVA: 0x7FFAC9D91010
        public void GetValueArray(){} // RVA: 0x7FFAC9D91080
        public void MutateValue(){} // RVA: 0x7FFAC9D75DD0
        public void CreateUdonByteArray(){} // RVA: 0x7FFAC9D910D0
        public void StartUdonByteArray(){} // RVA: 0x7FFAC9D758E0
        public void AddValue(){} // RVA: 0x7FFAC9D75900
        public void CreateValueVector(){} // RVA: 0x7FFAC9D75F20
        public void CreateValueVectorBlock(){} // RVA: 0x7FFAC9D912E0 | overloaded x3
        public void StartValueVector(){} // RVA: 0x7FFAC9D761C0
        public void EndUdonByteArray(){} // RVA: 0x7FFAC9D91370
        public void UnPack(){} // RVA: 0x7FFAC9D91400
        public void UnPackTo(){} // RVA: 0x7FFAC9D914B0
        public void Pack(){} // RVA: 0x7FFAC9D916C0
    }

    public class UdonByteArrayT : Object
    {
        public System.Collections.Generic.List`1<byte> Value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAC2F3C380
        public void set_Value(){} // RVA: 0x7FFAC2F22E30
        public void .ctor(){} // RVA: 0x7FFAC7DDDC00
    }

    public class UdonByteArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAC9D765C0
    }

    public class UdonByteT : Object
    {
        public byte Value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAC2FEB5E0
        public void set_Value(){} // RVA: 0x7FFAC2FEB5F0
        public void .ctor(){} // RVA: 0x7FFAC322C880
    }

    public class UdonChar : ValueType
    {
        public Google.FlatBuffers8.Struct ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_Value(){} // RVA: 0x7FFAC9D8E7B0
        public void MutateValue(){} // RVA: 0x7FFAC9D8E7E0
        public void CreateUdonChar(){} // RVA: 0x7FFAC9D8E810
        public void UnPack(){} // RVA: 0x7FFAC9D8E8E0
        public void UnPackTo(){} // RVA: 0x7FFAC9D8E950
        public void Pack(){} // RVA: 0x7FFAC9D8E990
    }

    public class UdonCharArray : ValueType
    {
        public Google.FlatBuffers8.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsUdonCharArray(){} // RVA: 0x7FFAC9D75670 | overloaded x2
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void Value(){} // RVA: 0x7FFAC9D90640
        public void get_ValueLength(){} // RVA: 0x7FFAC9D75CA0
        public void GetValueBytes(){} // RVA: 0x7FFAC9D906C0
        public void GetValueArray(){} // RVA: 0x7FFAC9D90730
        public void MutateValue(){} // RVA: 0x7FFAC9D90780
        public void CreateUdonCharArray(){} // RVA: 0x7FFAC9D90820
        public void StartUdonCharArray(){} // RVA: 0x7FFAC9D758E0
        public void AddValue(){} // RVA: 0x7FFAC9D75900
        public void CreateValueVector(){} // RVA: 0x7FFAC9D908E0
        public void CreateValueVectorBlock(){} // RVA: 0x7FFAC9D90AF0 | overloaded x3
        public void StartValueVector(){} // RVA: 0x7FFAC9D90B80
        public void EndUdonCharArray(){} // RVA: 0x7FFAC9D90BB0
        public void UnPack(){} // RVA: 0x7FFAC9D90C40
        public void UnPackTo(){} // RVA: 0x7FFAC9D90CF0
        public void Pack(){} // RVA: 0x7FFAC9D90F20
    }

    public class UdonCharArrayT : Object
    {
        public System.Collections.Generic.List`1<ushort> Value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAC2F3C380
        public void set_Value(){} // RVA: 0x7FFAC2F22E30
        public void .ctor(){} // RVA: 0x7FFAC7DDDC00
    }

    public class UdonCharArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAC9D90FA0
    }

    public class UdonCharT : Object
    {
        public ushort Value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAC469AEC0
        public void set_Value(){} // RVA: 0x7FFAC469BCA0
        public void .ctor(){} // RVA: 0x7FFAC489A870
    }

    public class UdonDouble : ValueType
    {
        public Google.FlatBuffers8.Struct ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_Value(){} // RVA: 0x7FFAC9D8F440
        public void MutateValue(){} // RVA: 0x7FFAC9D8F470
        public void CreateUdonDouble(){} // RVA: 0x7FFAC9D8F4A0
        public void UnPack(){} // RVA: 0x7FFAC9D8F580
        public void UnPackTo(){} // RVA: 0x7FFAC9D8F600
        public void Pack(){} // RVA: 0x7FFAC9D8F640
    }

    public class UdonDoubleArray : ValueType
    {
        public Google.FlatBuffers8.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsUdonDoubleArray(){} // RVA: 0x7FFAC9D75670 | overloaded x2
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void Value(){} // RVA: 0x7FFAC9D94CC0
        public void get_ValueLength(){} // RVA: 0x7FFAC9D75CA0
        public void GetValueBytes(){} // RVA: 0x7FFAC9D94D40
        public void GetValueArray(){} // RVA: 0x7FFAC9D94DB0
        public void MutateValue(){} // RVA: 0x7FFAC9D94E00
        public void CreateUdonDoubleArray(){} // RVA: 0x7FFAC9D94E90
        public void StartUdonDoubleArray(){} // RVA: 0x7FFAC9D758E0
        public void AddValue(){} // RVA: 0x7FFAC9D75900
        public void CreateValueVector(){} // RVA: 0x7FFAC9D94F50
        public void CreateValueVectorBlock(){} // RVA: 0x7FFAC9D95200 | overloaded x3
        public void StartValueVector(){} // RVA: 0x7FFAC9D92770
        public void EndUdonDoubleArray(){} // RVA: 0x7FFAC9D95290
        public void UnPack(){} // RVA: 0x7FFAC9D95320
        public void UnPackTo(){} // RVA: 0x7FFAC9D953D0
        public void Pack(){} // RVA: 0x7FFAC9D955F0
    }

    public class UdonDoubleArrayT : Object
    {
        public System.Collections.Generic.List`1<double> Value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAC2F3C380
        public void set_Value(){} // RVA: 0x7FFAC2F22E30
        public void .ctor(){} // RVA: 0x7FFAC7DDDC00
    }

    public class UdonDoubleArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAC9D92B90
    }

    public class UdonDoubleT : Object
    {
        public double Value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAC5873C20
        public void set_Value(){} // RVA: 0x7FFAC69C0110
        public void .ctor(){} // RVA: 0x7FFAC3B206B0
    }

    public class UdonFloat : ValueType
    {
        public Google.FlatBuffers8.Struct ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_Value(){} // RVA: 0x7FFAC9D75400
        public void MutateValue(){} // RVA: 0x7FFAC9D75430
        public void CreateUdonFloat(){} // RVA: 0x7FFAC9D8F2D0
        public void UnPack(){} // RVA: 0x7FFAC9D8F3B0
        public void UnPackTo(){} // RVA: 0x7FFAC9D755B0
        public void Pack(){} // RVA: 0x7FFAC9D8F420
    }

    public class UdonFloatArray : ValueType
    {
        public Google.FlatBuffers8.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsUdonFloatArray(){} // RVA: 0x7FFAC9D75670 | overloaded x2
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void Value(){} // RVA: 0x7FFAC9D94310
        public void get_ValueLength(){} // RVA: 0x7FFAC9D75CA0
        public void GetValueBytes(){} // RVA: 0x7FFAC9D94390
        public void GetValueArray(){} // RVA: 0x7FFAC9D94400
        public void MutateValue(){} // RVA: 0x7FFAC9D94450
        public void CreateUdonFloatArray(){} // RVA: 0x7FFAC9D944E0
        public void StartUdonFloatArray(){} // RVA: 0x7FFAC9D758E0
        public void AddValue(){} // RVA: 0x7FFAC9D75900
        public void CreateValueVector(){} // RVA: 0x7FFAC9D945A0
        public void CreateValueVectorBlock(){} // RVA: 0x7FFAC9D94850 | overloaded x3
        public void StartValueVector(){} // RVA: 0x7FFAC9D91D10
        public void EndUdonFloatArray(){} // RVA: 0x7FFAC9D948E0
        public void UnPack(){} // RVA: 0x7FFAC9D94970
        public void UnPackTo(){} // RVA: 0x7FFAC9D94A20
        public void Pack(){} // RVA: 0x7FFAC9D94C40
    }

    public class UdonFloatArrayT : Object
    {
        public System.Collections.Generic.List`1<float> Value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAC2F3C380
        public void set_Value(){} // RVA: 0x7FFAC2F22E30
        public void .ctor(){} // RVA: 0x7FFAC7DDDC00
    }

    public class UdonFloatArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAC9D92130
    }

    public class UdonFloatT : Object
    {
        public float Value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAC304B320
        public void set_Value(){} // RVA: 0x7FFAC304B330
        public void .ctor(){} // RVA: 0x7FFAC369FBB0
    }

    public class UdonInt : ValueType
    {
        public Google.FlatBuffers8.Struct ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_Value(){} // RVA: 0x7FFAC9D75200
        public void MutateValue(){} // RVA: 0x7FFAC9D75230
        public void CreateUdonInt(){} // RVA: 0x7FFAC9D8EB50
        public void UnPack(){} // RVA: 0x7FFAC9D8EC20
        public void UnPackTo(){} // RVA: 0x7FFAC9D753A0
        public void Pack(){} // RVA: 0x7FFAC9D8EC90
    }

    public class UdonIntArray : ValueType
    {
        public Google.FlatBuffers8.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsUdonIntArray(){} // RVA: 0x7FFAC9D75670 | overloaded x2
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void Value(){} // RVA: 0x7FFAC9D91740
        public void get_ValueLength(){} // RVA: 0x7FFAC9D75CA0
        public void GetValueBytes(){} // RVA: 0x7FFAC9D917C0
        public void GetValueArray(){} // RVA: 0x7FFAC9D91830
        public void MutateValue(){} // RVA: 0x7FFAC9D91880
        public void CreateUdonIntArray(){} // RVA: 0x7FFAC9D91910
        public void StartUdonIntArray(){} // RVA: 0x7FFAC9D758E0
        public void AddValue(){} // RVA: 0x7FFAC9D75900
        public void CreateValueVector(){} // RVA: 0x7FFAC9D919D0
        public void CreateValueVectorBlock(){} // RVA: 0x7FFAC9D91C80 | overloaded x3
        public void StartValueVector(){} // RVA: 0x7FFAC9D91D10
        public void EndUdonIntArray(){} // RVA: 0x7FFAC9D91D40
        public void UnPack(){} // RVA: 0x7FFAC9D91DD0
        public void UnPackTo(){} // RVA: 0x7FFAC9D91E80
        public void Pack(){} // RVA: 0x7FFAC9D920B0
    }

    public class UdonIntArrayT : Object
    {
        public System.Collections.Generic.List`1<int> Value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAC2F3C380
        public void set_Value(){} // RVA: 0x7FFAC2F22E30
        public void .ctor(){} // RVA: 0x7FFAC7DDDC00
    }

    public class UdonIntArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAC9D92130
    }

    public class UdonIntT : Object
    {
        public int Value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAC2F6E5C0
        public void set_Value(){} // RVA: 0x7FFAC2F240C0
        public void .ctor(){} // RVA: 0x7FFAC369FBB0
    }

    public class UdonLong : ValueType
    {
        public Google.FlatBuffers8.Struct ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_Value(){} // RVA: 0x7FFAC9D8ECB0
        public void MutateValue(){} // RVA: 0x7FFAC9D8ECE0
        public void CreateUdonLong(){} // RVA: 0x7FFAC9D8ED10
        public void UnPack(){} // RVA: 0x7FFAC9D8EDE0
        public void UnPackTo(){} // RVA: 0x7FFAC9D8EE50
        public void Pack(){} // RVA: 0x7FFAC9D8EE90
    }

    public class UdonLongArray : ValueType
    {
        public Google.FlatBuffers8.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsUdonLongArray(){} // RVA: 0x7FFAC9D75670 | overloaded x2
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void Value(){} // RVA: 0x7FFAC9D921A0
        public void get_ValueLength(){} // RVA: 0x7FFAC9D75CA0
        public void GetValueBytes(){} // RVA: 0x7FFAC9D92220
        public void GetValueArray(){} // RVA: 0x7FFAC9D92290
        public void MutateValue(){} // RVA: 0x7FFAC9D922E0
        public void CreateUdonLongArray(){} // RVA: 0x7FFAC9D92370
        public void StartUdonLongArray(){} // RVA: 0x7FFAC9D758E0
        public void AddValue(){} // RVA: 0x7FFAC9D75900
        public void CreateValueVector(){} // RVA: 0x7FFAC9D92430
        public void CreateValueVectorBlock(){} // RVA: 0x7FFAC9D926E0 | overloaded x3
        public void StartValueVector(){} // RVA: 0x7FFAC9D92770
        public void EndUdonLongArray(){} // RVA: 0x7FFAC9D927A0
        public void UnPack(){} // RVA: 0x7FFAC9D92830
        public void UnPackTo(){} // RVA: 0x7FFAC9D928E0
        public void Pack(){} // RVA: 0x7FFAC9D92B10
    }

    public class UdonLongArrayT : Object
    {
        public System.Collections.Generic.List`1<long> Value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAC2F3C380
        public void set_Value(){} // RVA: 0x7FFAC2F22E30
        public void .ctor(){} // RVA: 0x7FFAC7DDDC00
    }

    public class UdonLongArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAC9D92B90
    }

    public class UdonLongT : Object
    {
        public long Value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAC2F3C380
        public void set_Value(){} // RVA: 0x7FFAC441EFB0
        public void .ctor(){} // RVA: 0x7FFAC3B206B0
    }

    public class UdonShort : ValueType
    {
        public Google.FlatBuffers8.Struct ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_Value(){} // RVA: 0x7FFAC9D8E7B0
        public void MutateValue(){} // RVA: 0x7FFAC9D8E7E0
        public void CreateUdonShort(){} // RVA: 0x7FFAC9D8F660
        public void UnPack(){} // RVA: 0x7FFAC9D8F730
        public void UnPackTo(){} // RVA: 0x7FFAC9D8E950
        public void Pack(){} // RVA: 0x7FFAC9D8F7A0
    }

    public class UdonShortArray : ValueType
    {
        public Google.FlatBuffers8.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsUdonShortArray(){} // RVA: 0x7FFAC9D75670 | overloaded x2
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void Value(){} // RVA: 0x7FFAC9D90640
        public void get_ValueLength(){} // RVA: 0x7FFAC9D75CA0
        public void GetValueBytes(){} // RVA: 0x7FFAC9D95670
        public void GetValueArray(){} // RVA: 0x7FFAC9D956E0
        public void MutateValue(){} // RVA: 0x7FFAC9D90780
        public void CreateUdonShortArray(){} // RVA: 0x7FFAC9D95730
        public void StartUdonShortArray(){} // RVA: 0x7FFAC9D758E0
        public void AddValue(){} // RVA: 0x7FFAC9D75900
        public void CreateValueVector(){} // RVA: 0x7FFAC9D908E0
        public void CreateValueVectorBlock(){} // RVA: 0x7FFAC9D959E0 | overloaded x3
        public void StartValueVector(){} // RVA: 0x7FFAC9D90B80
        public void EndUdonShortArray(){} // RVA: 0x7FFAC9D95A70
        public void UnPack(){} // RVA: 0x7FFAC9D95B00
        public void UnPackTo(){} // RVA: 0x7FFAC9D95BB0
        public void Pack(){} // RVA: 0x7FFAC9D95DE0
    }

    public class UdonShortArrayT : Object
    {
        public System.Collections.Generic.List`1<short> Value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAC2F3C380
        public void set_Value(){} // RVA: 0x7FFAC2F22E30
        public void .ctor(){} // RVA: 0x7FFAC7DDDC00
    }

    public class UdonShortArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAC9D90FA0
    }

    public class UdonShortT : Object
    {
        public short Value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAC469AEC0
        public void set_Value(){} // RVA: 0x7FFAC469BCA0
        public void .ctor(){} // RVA: 0x7FFAC489A870
    }

    public class UdonString : ValueType
    {
        public Google.FlatBuffers8.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsUdonString(){} // RVA: 0x7FFAC9D75670 | overloaded x2
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_Value(){} // RVA: 0x7FFAC9D756D0
        public void GetValueBytes(){} // RVA: 0x7FFAC9D8F920
        public void GetValueArray(){} // RVA: 0x7FFAC9D8F990
        public void CreateUdonString(){} // RVA: 0x7FFAC9D8F9E0
        public void StartUdonString(){} // RVA: 0x7FFAC9D758E0
        public void AddValue(){} // RVA: 0x7FFAC9D75900
        public void EndUdonString(){} // RVA: 0x7FFAC9D8FAA0
        public void UnPack(){} // RVA: 0x7FFAC9D8FB30
        public void UnPackTo(){} // RVA: 0x7FFAC9D75AE0
        public void Pack(){} // RVA: 0x7FFAC9D8FC40
    }

    public class UdonStringT : Object
    {
        public string Value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAC2F3C380
        public void set_Value(){} // RVA: 0x7FFAC2F22E30
        public void .ctor(){} // RVA: 0x7FFAC7DDDC00
    }

    public class UdonStringVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAC9D75BB0
    }

    public class UdonT : Object
    {
        public System.Collections.Generic.List`1<VRC.Core.Networking.FlatBuffers.FlatBuffers8.UdonValueUnion> Data; // 0x10

        // ── Methods ──
        public void get_Data(){} // RVA: 0x7FFAC2F3C380
        public void set_Data(){} // RVA: 0x7FFAC2F22E30
        public void .ctor(){} // RVA: 0x7FFAC7DDDC00
        public void DeserializeFromBinary(){} // RVA: 0x7FFAC9D9BEF0
        public void SerializeToBinary(){} // RVA: 0x7FFAC9D9BFA0
    }

    public class UdonUByte : ValueType
    {
        public Google.FlatBuffers8.Struct ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_Value(){} // RVA: 0x7FFAC9D7A9A0
        public void MutateValue(){} // RVA: 0x7FFAC9D75030
        public void CreateUdonUByte(){} // RVA: 0x7FFAC9D8EEB0
        public void UnPack(){} // RVA: 0x7FFAC9D8EF80
        public void UnPackTo(){} // RVA: 0x7FFAC9D8EAF0
        public void Pack(){} // RVA: 0x7FFAC9D8EFF0
    }

    public class UdonUByteArray : ValueType
    {
        public Google.FlatBuffers8.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsUdonUByteArray(){} // RVA: 0x7FFAC9D75670 | overloaded x2
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void Value(){} // RVA: 0x7FFAC9D75C20
        public void get_ValueLength(){} // RVA: 0x7FFAC9D75CA0
        public void GetValueBytes(){} // RVA: 0x7FFAC9D92C00
        public void GetValueArray(){} // RVA: 0x7FFAC9D92C70
        public void MutateValue(){} // RVA: 0x7FFAC9D75DD0
        public void CreateUdonUByteArray(){} // RVA: 0x7FFAC9D92CC0
        public void StartUdonUByteArray(){} // RVA: 0x7FFAC9D758E0
        public void AddValue(){} // RVA: 0x7FFAC9D75900
        public void CreateValueVector(){} // RVA: 0x7FFAC9D75F20
        public void CreateValueVectorBlock(){} // RVA: 0x7FFAC9D92ED0 | overloaded x3
        public void StartValueVector(){} // RVA: 0x7FFAC9D761C0
        public void EndUdonUByteArray(){} // RVA: 0x7FFAC9D92F60
        public void UnPack(){} // RVA: 0x7FFAC9D92FF0
        public void UnPackTo(){} // RVA: 0x7FFAC9D930A0
        public void Pack(){} // RVA: 0x7FFAC9D932B0
    }

    public class UdonUByteArrayT : Object
    {
        public System.Collections.Generic.List`1<byte> Value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAC2F3C380
        public void set_Value(){} // RVA: 0x7FFAC2F22E30
        public void .ctor(){} // RVA: 0x7FFAC7DDDC00
    }

    public class UdonUByteArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAC9D765C0
    }

    public class UdonUByteT : Object
    {
        public byte Value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAC2FEB5E0
        public void set_Value(){} // RVA: 0x7FFAC2FEB5F0
        public void .ctor(){} // RVA: 0x7FFAC322C880
    }

    public class UdonUInt : ValueType
    {
        public Google.FlatBuffers8.Struct ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_Value(){} // RVA: 0x7FFAC9D75200
        public void MutateValue(){} // RVA: 0x7FFAC9D75230
        public void CreateUdonUInt(){} // RVA: 0x7FFAC9D8F010
        public void UnPack(){} // RVA: 0x7FFAC9D8F0E0
        public void UnPackTo(){} // RVA: 0x7FFAC9D753A0
        public void Pack(){} // RVA: 0x7FFAC9D8F150
    }

    public class UdonUIntArray : ValueType
    {
        public Google.FlatBuffers8.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsUdonUIntArray(){} // RVA: 0x7FFAC9D75670 | overloaded x2
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void Value(){} // RVA: 0x7FFAC9D91740
        public void get_ValueLength(){} // RVA: 0x7FFAC9D75CA0
        public void GetValueBytes(){} // RVA: 0x7FFAC9D93330
        public void GetValueArray(){} // RVA: 0x7FFAC9D933A0
        public void MutateValue(){} // RVA: 0x7FFAC9D91880
        public void CreateUdonUIntArray(){} // RVA: 0x7FFAC9D933F0
        public void StartUdonUIntArray(){} // RVA: 0x7FFAC9D758E0
        public void AddValue(){} // RVA: 0x7FFAC9D75900
        public void CreateValueVector(){} // RVA: 0x7FFAC9D919D0
        public void CreateValueVectorBlock(){} // RVA: 0x7FFAC9D936A0 | overloaded x3
        public void StartValueVector(){} // RVA: 0x7FFAC9D91D10
        public void EndUdonUIntArray(){} // RVA: 0x7FFAC9D93730
        public void UnPack(){} // RVA: 0x7FFAC9D937C0
        public void UnPackTo(){} // RVA: 0x7FFAC9D93870
        public void Pack(){} // RVA: 0x7FFAC9D93AA0
    }

    public class UdonUIntArrayT : Object
    {
        public System.Collections.Generic.List`1<uint> Value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAC2F3C380
        public void set_Value(){} // RVA: 0x7FFAC2F22E30
        public void .ctor(){} // RVA: 0x7FFAC7DDDC00
    }

    public class UdonUIntArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAC9D92130
    }

    public class UdonUIntT : Object
    {
        public uint Value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAC2F6E5C0
        public void set_Value(){} // RVA: 0x7FFAC2F240C0
        public void .ctor(){} // RVA: 0x7FFAC369FBB0
    }

    public class UdonULong : ValueType
    {
        public Google.FlatBuffers8.Struct ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_Value(){} // RVA: 0x7FFAC9D8ECB0
        public void MutateValue(){} // RVA: 0x7FFAC9D8ECE0
        public void CreateUdonULong(){} // RVA: 0x7FFAC9D8F170
        public void UnPack(){} // RVA: 0x7FFAC9D8F240
        public void UnPackTo(){} // RVA: 0x7FFAC9D8EE50
        public void Pack(){} // RVA: 0x7FFAC9D8F2B0
    }

    public class UdonULongArray : ValueType
    {
        public Google.FlatBuffers8.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsUdonULongArray(){} // RVA: 0x7FFAC9D75670 | overloaded x2
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void Value(){} // RVA: 0x7FFAC9D921A0
        public void get_ValueLength(){} // RVA: 0x7FFAC9D75CA0
        public void GetValueBytes(){} // RVA: 0x7FFAC9D93B20
        public void GetValueArray(){} // RVA: 0x7FFAC9D93B90
        public void MutateValue(){} // RVA: 0x7FFAC9D922E0
        public void CreateUdonULongArray(){} // RVA: 0x7FFAC9D93BE0
        public void StartUdonULongArray(){} // RVA: 0x7FFAC9D758E0
        public void AddValue(){} // RVA: 0x7FFAC9D75900
        public void CreateValueVector(){} // RVA: 0x7FFAC9D92430
        public void CreateValueVectorBlock(){} // RVA: 0x7FFAC9D93E90 | overloaded x3
        public void StartValueVector(){} // RVA: 0x7FFAC9D92770
        public void EndUdonULongArray(){} // RVA: 0x7FFAC9D93F20
        public void UnPack(){} // RVA: 0x7FFAC9D93FB0
        public void UnPackTo(){} // RVA: 0x7FFAC9D94060
        public void Pack(){} // RVA: 0x7FFAC9D94290
    }

    public class UdonULongArrayT : Object
    {
        public System.Collections.Generic.List`1<ulong> Value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAC2F3C380
        public void set_Value(){} // RVA: 0x7FFAC2F22E30
        public void .ctor(){} // RVA: 0x7FFAC7DDDC00
    }

    public class UdonULongArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAC9D92B90
    }

    public class UdonULongT : Object
    {
        public ulong Value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAC2F3C380
        public void set_Value(){} // RVA: 0x7FFAC441EFB0
        public void .ctor(){} // RVA: 0x7FFAC3B206B0
    }

    public class UdonUShort : ValueType
    {
        public Google.FlatBuffers8.Struct ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_Value(){} // RVA: 0x7FFAC9D8E7B0
        public void MutateValue(){} // RVA: 0x7FFAC9D8E7E0
        public void CreateUdonUShort(){} // RVA: 0x7FFAC9D8F7C0
        public void UnPack(){} // RVA: 0x7FFAC9D8F890
        public void UnPackTo(){} // RVA: 0x7FFAC9D8E950
        public void Pack(){} // RVA: 0x7FFAC9D8F900
    }

    public class UdonUShortArray : ValueType
    {
        public Google.FlatBuffers8.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsUdonUShortArray(){} // RVA: 0x7FFAC9D75670 | overloaded x2
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void Value(){} // RVA: 0x7FFAC9D90640
        public void get_ValueLength(){} // RVA: 0x7FFAC9D75CA0
        public void GetValueBytes(){} // RVA: 0x7FFAC9D95E60
        public void GetValueArray(){} // RVA: 0x7FFAC9D95ED0
        public void MutateValue(){} // RVA: 0x7FFAC9D90780
        public void CreateUdonUShortArray(){} // RVA: 0x7FFAC9D95F20
        public void StartUdonUShortArray(){} // RVA: 0x7FFAC9D758E0
        public void AddValue(){} // RVA: 0x7FFAC9D75900
        public void CreateValueVector(){} // RVA: 0x7FFAC9D908E0
        public void CreateValueVectorBlock(){} // RVA: 0x7FFAC9D96130 | overloaded x3
        public void StartValueVector(){} // RVA: 0x7FFAC9D90B80
        public void EndUdonUShortArray(){} // RVA: 0x7FFAC9D961C0
        public void UnPack(){} // RVA: 0x7FFAC9D96250
        public void UnPackTo(){} // RVA: 0x7FFAC9D96300
        public void Pack(){} // RVA: 0x7FFAC9D96530
    }

    public class UdonUShortArrayT : Object
    {
        public System.Collections.Generic.List`1<ushort> Value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAC2F3C380
        public void set_Value(){} // RVA: 0x7FFAC2F22E30
        public void .ctor(){} // RVA: 0x7FFAC7DDDC00
    }

    public class UdonUShortArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAC9D90FA0
    }

    public class UdonUShortT : Object
    {
        public ushort Value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAC469AEC0
        public void set_Value(){} // RVA: 0x7FFAC469BCA0
        public void .ctor(){} // RVA: 0x7FFAC489A870
    }

    public class UdonValueUnion : Object
    {
        public 0x6B1FD840 Type; // 0x10
        public object Value; // 0x18

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAC2FEB5E0
        public void set_Type(){} // RVA: 0x7FFAC2FEB5F0
        public void get_Value(){} // RVA: 0x7FFAC2F247C0
        public void set_Value(){} // RVA: 0x7FFAC2F87E80
        public void .ctor(){} // RVA: 0x7FFAC9D74460
        public void As(){} // RVA: 0x7FFAC2E8DC40
        public void AsUdonShort(){} // RVA: 0x7FFAC9D8A310
        public void FromUdonShort(){} // RVA: 0x7FFAC9D8A350
        public void AsUdonUShort(){} // RVA: 0x7FFAC9D8A450
        public void FromUdonUShort(){} // RVA: 0x7FFAC9D8A490
        public void AsUdonChar(){} // RVA: 0x7FFAC9D8A590
        public void FromUdonChar(){} // RVA: 0x7FFAC9D8A5D0
        public void AsUdonByte(){} // RVA: 0x7FFAC9D8A6D0
        public void FromUdonByte(){} // RVA: 0x7FFAC9D8A710
        public void AsUdonUByte(){} // RVA: 0x7FFAC9D8A810
        public void FromUdonUByte(){} // RVA: 0x7FFAC9D8A850
        public void AsUdonLong(){} // RVA: 0x7FFAC9D8A950
        public void FromUdonLong(){} // RVA: 0x7FFAC9D8A990
        public void AsUdonULong(){} // RVA: 0x7FFAC9D8AA90
        public void FromUdonULong(){} // RVA: 0x7FFAC9D8AAD0
        public void AsUdonDouble(){} // RVA: 0x7FFAC9D8ABD0
        public void FromUdonDouble(){} // RVA: 0x7FFAC9D8AC10
        public void AsUdonBool(){} // RVA: 0x7FFAC9D8AD10
        public void FromUdonBool(){} // RVA: 0x7FFAC9D8AD50
        public void AsUdonFloat(){} // RVA: 0x7FFAC9D8AE50
        public void FromUdonFloat(){} // RVA: 0x7FFAC9D8AE90
        public void AsUdonInt(){} // RVA: 0x7FFAC9D8AF90
        public void FromUdonInt(){} // RVA: 0x7FFAC9D8AFD0
        public void AsUdonUInt(){} // RVA: 0x7FFAC9D8B0D0
        public void FromUdonUInt(){} // RVA: 0x7FFAC9D8B110
        public void AsVector2(){} // RVA: 0x7FFAC9D8B210
        public void FromVector2(){} // RVA: 0x7FFAC9D8B250
        public void AsVector3(){} // RVA: 0x7FFAC9D8B350
        public void FromVector3(){} // RVA: 0x7FFAC9D8B390
        public void AsVector4(){} // RVA: 0x7FFAC9D8B490
        public void FromVector4(){} // RVA: 0x7FFAC9D8B4D0
        public void AsQuaternion(){} // RVA: 0x7FFAC9D8B5D0
        public void FromQuaternion(){} // RVA: 0x7FFAC9D8B610
        public void AsColor(){} // RVA: 0x7FFAC9D8B710
        public void FromColor(){} // RVA: 0x7FFAC9D8B750
        public void AsColor32(){} // RVA: 0x7FFAC9D8B850
        public void FromColor32(){} // RVA: 0x7FFAC9D8B890
        public void AsUdonShortArray(){} // RVA: 0x7FFAC9D8B990
        public void FromUdonShortArray(){} // RVA: 0x7FFAC9D8B9D0
        public void AsUdonUShortArray(){} // RVA: 0x7FFAC9D8BAD0
        public void FromUdonUShortArray(){} // RVA: 0x7FFAC9D8BB10
        public void AsUdonCharArray(){} // RVA: 0x7FFAC9D8BC10
        public void FromUdonCharArray(){} // RVA: 0x7FFAC9D8BC50
        public void AsUdonByteArray(){} // RVA: 0x7FFAC9D8BD50
        public void FromUdonByteArray(){} // RVA: 0x7FFAC9D8BD90
        public void AsUdonUByteArray(){} // RVA: 0x7FFAC9D8BE90
        public void FromUdonUByteArray(){} // RVA: 0x7FFAC9D8BED0
        public void AsUdonLongArray(){} // RVA: 0x7FFAC9D8BFD0
        public void FromUdonLongArray(){} // RVA: 0x7FFAC9D8C010
        public void AsUdonULongArray(){} // RVA: 0x7FFAC9D8C110
        public void FromUdonULongArray(){} // RVA: 0x7FFAC9D8C150
        public void AsUdonDoubleArray(){} // RVA: 0x7FFAC9D8C250
        public void FromUdonDoubleArray(){} // RVA: 0x7FFAC9D8C290
        public void AsUdonBoolArray(){} // RVA: 0x7FFAC9D8C390
        public void FromUdonBoolArray(){} // RVA: 0x7FFAC9D8C3D0
        public void AsUdonFloatArray(){} // RVA: 0x7FFAC9D8C4D0
        public void FromUdonFloatArray(){} // RVA: 0x7FFAC9D8C510
        public void AsUdonIntArray(){} // RVA: 0x7FFAC9D8C610
        public void FromUdonIntArray(){} // RVA: 0x7FFAC9D8C650
        public void AsUdonUIntArray(){} // RVA: 0x7FFAC9D8C750
        public void FromUdonUIntArray(){} // RVA: 0x7FFAC9D8C790
        public void AsVector2Array(){} // RVA: 0x7FFAC9D8C890
        public void FromVector2Array(){} // RVA: 0x7FFAC9D8C8D0
        public void AsVector3Array(){} // RVA: 0x7FFAC9D8C9D0
        public void FromVector3Array(){} // RVA: 0x7FFAC9D8CA10
        public void AsVector4Array(){} // RVA: 0x7FFAC9D8CB10
        public void FromVector4Array(){} // RVA: 0x7FFAC9D8CB50
        public void AsQuaternionArray(){} // RVA: 0x7FFAC9D8CC50
        public void FromQuaternionArray(){} // RVA: 0x7FFAC9D8CC90
        public void AsColorArray(){} // RVA: 0x7FFAC9D8CD90
        public void FromColorArray(){} // RVA: 0x7FFAC9D8CDD0
        public void AsColor32Array(){} // RVA: 0x7FFAC9D8CED0
        public void FromColor32Array(){} // RVA: 0x7FFAC9D8CF10
        public void AsUdonString(){} // RVA: 0x7FFAC9D8D010
        public void FromUdonString(){} // RVA: 0x7FFAC9D8D050
        public void Pack(){} // RVA: 0x7FFAC9D8D150
    }

    public class UdonValueVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAC9D8E210
    }

    public class UdonVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAC9D765C0
    }

}