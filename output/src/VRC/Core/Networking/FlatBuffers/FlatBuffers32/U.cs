// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers32
// Classes: 74
// Methods: 643

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers32
{
    public class Udon : ValueType
    {
        public Google.FlatBuffers32.Table __p; // 0x10
        public object field_1; // 0x338
        public object field_2; // 0x339

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsUdon(){} // RVA: 0x7FFE881444A0 | overloaded x2
        public void VerifyUdon(){} // RVA: 0x7FFE881751F0
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void DataType(){} // RVA: 0x7FFE8814C6C0
        public void get_DataTypeLength(){} // RVA: 0x7FFE8814C740
        public void GetDataTypeBytes(){} // RVA: 0x7FFE881752E0
        public void GetDataTypeArray(){} // RVA: 0x7FFE88175350
        public void Data(){} // RVA: 0x7FFE810A1420
        public void get_DataLength(){} // RVA: 0x7FFE8814D440
        public void CreateUdon(){} // RVA: 0x7FFE88175480
        public void StartUdon(){} // RVA: 0x7FFE8814D560
        public void AddDataType(){} // RVA: 0x7FFE8814C380
        public void CreateDataTypeVector(){} // RVA: 0x7FFE8814C8F0
        public void CreateDataTypeVectorBlock(){} // RVA: 0x7FFE881756E0 | overloaded x3
        public void StartDataTypeVector(){} // RVA: 0x7FFE8814CC40
        public void AddData(){} // RVA: 0x7FFE8814D7F0
        public void CreateDataVector(){} // RVA: 0x7FFE88144E80
        public void CreateDataVectorBlock(){} // RVA: 0x7FFE88175940 | overloaded x3
        public void StartDataVector(){} // RVA: 0x7FFE88145240
        public void EndUdon(){} // RVA: 0x7FFE88175A00
        public void FinishUdonBuffer(){} // RVA: 0x7FFE8814DAE0
        public void FinishSizePrefixedUdonBuffer(){} // RVA: 0x7FFE8814DB40
        public void UnPack(){} // RVA: 0x7FFE88175A50
        public void UnPackTo(){} // RVA: 0x7FFE88175B00
        public void Pack(){} // RVA: 0x7FFE88177AC0
    }

    public class UdonBool : ValueType
    {
        public Google.FlatBuffers32.Struct __p; // 0x10
        public object field_1; // 0x2D8

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_Value(){} // RVA: 0x7FFE8814BB50
        public void CreateUdonBool(){} // RVA: 0x7FFE8816A4F0
        public void UnPack(){} // RVA: 0x7FFE8816A580
        public void UnPackTo(){} // RVA: 0x7FFE8814BC80
        public void Pack(){} // RVA: 0x7FFE8816A5F0
    }

    public class UdonBoolArray : ValueType
    {
        public Google.FlatBuffers32.Table __p; // 0x10
        public object field_1; // 0x302

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsUdonBoolArray(){} // RVA: 0x7FFE881444A0 | overloaded x2
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void Value(){} // RVA: 0x7FFE8816BF50
        public void get_ValueLength(){} // RVA: 0x7FFE8814C740
        public void GetValueBytes(){} // RVA: 0x7FFE8816BFD0
        public void GetValueArray(){} // RVA: 0x7FFE8816C040
        public void CreateUdonBoolArray(){} // RVA: 0x7FFE8816C090
        public void StartUdonBoolArray(){} // RVA: 0x7FFE8814C360
        public void AddValue(){} // RVA: 0x7FFE8814C380
        public void CreateValueVector(){} // RVA: 0x7FFE8816C110
        public void CreateValueVectorBlock(){} // RVA: 0x7FFE8816C440 | overloaded x3
        public void StartValueVector(){} // RVA: 0x7FFE8814CC40
        public void EndUdonBoolArray(){} // RVA: 0x7FFE8816C500
        public void UnPack(){} // RVA: 0x7FFE8816C550
        public void UnPackTo(){} // RVA: 0x7FFE8816C600
        public void Pack(){} // RVA: 0x7FFE8816C810
    }

    public class UdonBoolArrayT : Object
    {
        public System.Collections.Generic.List`1<bool> _value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFE81116380
        public void set_Value(){} // RVA: 0x7FFE810FCE30
        public void .ctor(){} // RVA: 0x7FFE86200400
    }

    public class UdonBoolArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFE8814D140
    }

    public class UdonBoolT : Object
    {
        public bool _value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFE811C55E0
        public void set_Value(){} // RVA: 0x7FFE811C55F0
        public void .ctor(){} // RVA: 0x7FFE81FCAC70
    }

    public class UdonByte : ValueType
    {
        public Google.FlatBuffers32.Struct __p; // 0x10
        public object field_1; // 0x2DE

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_Value(){} // RVA: 0x7FFE88155130
        public void CreateUdonByte(){} // RVA: 0x7FFE8816A730
        public void UnPack(){} // RVA: 0x7FFE8816A7C0
        public void UnPackTo(){} // RVA: 0x7FFE88160BE0
        public void Pack(){} // RVA: 0x7FFE8816A830
    }

    public class UdonByteArray : ValueType
    {
        public Google.FlatBuffers32.Table __p; // 0x10
        public object field_1; // 0x308

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsUdonByteArray(){} // RVA: 0x7FFE881444A0 | overloaded x2
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void Value(){} // RVA: 0x7FFE8814C6C0
        public void get_ValueLength(){} // RVA: 0x7FFE8814C740
        public void GetValueBytes(){} // RVA: 0x7FFE8816D2D0
        public void GetValueArray(){} // RVA: 0x7FFE8816D340
        public void CreateUdonByteArray(){} // RVA: 0x7FFE8816D390
        public void StartUdonByteArray(){} // RVA: 0x7FFE8814C360
        public void AddValue(){} // RVA: 0x7FFE8814C380
        public void CreateValueVector(){} // RVA: 0x7FFE8814C8F0
        public void CreateValueVectorBlock(){} // RVA: 0x7FFE8816D5B0 | overloaded x3
        public void StartValueVector(){} // RVA: 0x7FFE8814CC40
        public void EndUdonByteArray(){} // RVA: 0x7FFE8816D670
        public void UnPack(){} // RVA: 0x7FFE8816D6C0
        public void UnPackTo(){} // RVA: 0x7FFE8816D770
        public void Pack(){} // RVA: 0x7FFE8816D980
    }

    public class UdonByteArrayT : Object
    {
        public System.Collections.Generic.List`1<byte> _value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFE81116380
        public void set_Value(){} // RVA: 0x7FFE810FCE30
        public void .ctor(){} // RVA: 0x7FFE86200400
    }

    public class UdonByteArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFE8814D140
    }

    public class UdonByteT : Object
    {
        public byte _value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFE811C55E0
        public void set_Value(){} // RVA: 0x7FFE811C55F0
        public void .ctor(){} // RVA: 0x7FFE81FCAC70
    }

    public class UdonChar : ValueType
    {
        public Google.FlatBuffers32.Struct __p; // 0x10
        public object field_1; // 0x2DB

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_Value(){} // RVA: 0x7FFE8815FE60
        public void CreateUdonChar(){} // RVA: 0x7FFE8816A610
        public void UnPack(){} // RVA: 0x7FFE8816A6A0
        public void UnPackTo(){} // RVA: 0x7FFE8815FF90
        public void Pack(){} // RVA: 0x7FFE8816A710
    }

    public class UdonCharArray : ValueType
    {
        public Google.FlatBuffers32.Table __p; // 0x10
        public object field_1; // 0x305

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsUdonCharArray(){} // RVA: 0x7FFE881444A0 | overloaded x2
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void Value(){} // RVA: 0x7FFE8816C900
        public void get_ValueLength(){} // RVA: 0x7FFE8814C740
        public void GetValueBytes(){} // RVA: 0x7FFE8816C980
        public void GetValueArray(){} // RVA: 0x7FFE8816C9F0
        public void CreateUdonCharArray(){} // RVA: 0x7FFE8816CA40
        public void StartUdonCharArray(){} // RVA: 0x7FFE8814C360
        public void AddValue(){} // RVA: 0x7FFE8814C380
        public void CreateValueVector(){} // RVA: 0x7FFE8816CAC0
        public void CreateValueVectorBlock(){} // RVA: 0x7FFE8816CD50 | overloaded x3
        public void StartValueVector(){} // RVA: 0x7FFE8816CE10
        public void EndUdonCharArray(){} // RVA: 0x7FFE8816CE40
        public void UnPack(){} // RVA: 0x7FFE8816CE90
        public void UnPackTo(){} // RVA: 0x7FFE8816CF40
        public void Pack(){} // RVA: 0x7FFE8816D170
    }

    public class UdonCharArrayT : Object
    {
        public System.Collections.Generic.List`1<ushort> _value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFE81116380
        public void set_Value(){} // RVA: 0x7FFE810FCE30
        public void .ctor(){} // RVA: 0x7FFE86200400
    }

    public class UdonCharArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFE8816D260
    }

    public class UdonCharT : Object
    {
        public ushort _value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFE8299FB40
        public void set_Value(){} // RVA: 0x7FFE8299FB10
        public void .ctor(){} // RVA: 0x7FFE82B02750
    }

    public class UdonDouble : ValueType
    {
        public Google.FlatBuffers32.Struct __p; // 0x10
        public object field_1; // 0x2F3

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_Value(){} // RVA: 0x7FFE88160720
        public void CreateUdonDouble(){} // RVA: 0x7FFE8816AFC0
        public void UnPack(){} // RVA: 0x7FFE8816B050
        public void UnPackTo(){} // RVA: 0x7FFE88160860
        public void Pack(){} // RVA: 0x7FFE8816B0D0
    }

    public class UdonDoubleArray : ValueType
    {
        public Google.FlatBuffers32.Table __p; // 0x10
        public object field_1; // 0x31D

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsUdonDoubleArray(){} // RVA: 0x7FFE881444A0 | overloaded x2
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void Value(){} // RVA: 0x7FFE88170DC0
        public void get_ValueLength(){} // RVA: 0x7FFE8814C740
        public void GetValueBytes(){} // RVA: 0x7FFE88170E40
        public void GetValueArray(){} // RVA: 0x7FFE88170EB0
        public void CreateUdonDoubleArray(){} // RVA: 0x7FFE88170F00
        public void StartUdonDoubleArray(){} // RVA: 0x7FFE8814C360
        public void AddValue(){} // RVA: 0x7FFE8814C380
        public void CreateValueVector(){} // RVA: 0x7FFE88170F80
        public void CreateValueVectorBlock(){} // RVA: 0x7FFE881712A0 | overloaded x3
        public void StartValueVector(){} // RVA: 0x7FFE8816E7D0
        public void EndUdonDoubleArray(){} // RVA: 0x7FFE88171360
        public void UnPack(){} // RVA: 0x7FFE881713B0
        public void UnPackTo(){} // RVA: 0x7FFE88171460
        public void Pack(){} // RVA: 0x7FFE88171670
    }

    public class UdonDoubleArrayT : Object
    {
        public System.Collections.Generic.List`1<double> _value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFE81116380
        public void set_Value(){} // RVA: 0x7FFE810FCE30
        public void .ctor(){} // RVA: 0x7FFE86200400
    }

    public class UdonDoubleArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFE8816EC10
    }

    public class UdonDoubleT : Object
    {
        public double _value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFE83BB0D80
        public void set_Value(){} // RVA: 0x7FFE84D215B0
        public void .ctor(){} // RVA: 0x7FFE81DB74C0
    }

    public class UdonFloat : ValueType
    {
        public Google.FlatBuffers32.Struct __p; // 0x10
        public object field_1; // 0x2F0

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_Value(){} // RVA: 0x7FFE8814BF90
        public void CreateUdonFloat(){} // RVA: 0x7FFE8816AE30
        public void UnPack(){} // RVA: 0x7FFE8816AEC0
        public void UnPackTo(){} // RVA: 0x7FFE8814C0C0
        public void Pack(){} // RVA: 0x7FFE8816AF30
    }

    public class UdonFloatArray : ValueType
    {
        public Google.FlatBuffers32.Table __p; // 0x10
        public object field_1; // 0x31A

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsUdonFloatArray(){} // RVA: 0x7FFE881444A0 | overloaded x2
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void Value(){} // RVA: 0x7FFE88170420
        public void get_ValueLength(){} // RVA: 0x7FFE8814C740
        public void GetValueBytes(){} // RVA: 0x7FFE881704A0
        public void GetValueArray(){} // RVA: 0x7FFE88170510
        public void CreateUdonFloatArray(){} // RVA: 0x7FFE88170560
        public void StartUdonFloatArray(){} // RVA: 0x7FFE8814C360
        public void AddValue(){} // RVA: 0x7FFE8814C380
        public void CreateValueVector(){} // RVA: 0x7FFE881705E0
        public void CreateValueVectorBlock(){} // RVA: 0x7FFE88170900 | overloaded x3
        public void StartValueVector(){} // RVA: 0x7FFE88145240
        public void EndUdonFloatArray(){} // RVA: 0x7FFE881709C0
        public void UnPack(){} // RVA: 0x7FFE88170A10
        public void UnPackTo(){} // RVA: 0x7FFE88170AC0
        public void Pack(){} // RVA: 0x7FFE88170CD0
    }

    public class UdonFloatArrayT : Object
    {
        public System.Collections.Generic.List`1<float> _value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFE81116380
        public void set_Value(){} // RVA: 0x7FFE810FCE30
        public void .ctor(){} // RVA: 0x7FFE86200400
    }

    public class UdonFloatArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFE8815CE20
    }

    public class UdonFloatT : Object
    {
        public float _value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFE81225320
        public void set_Value(){} // RVA: 0x7FFE81225330
        public void .ctor(){} // RVA: 0x7FFE817EE4A0
    }

    public class UdonInfo : ValueType
    {
        public Google.FlatBuffers32.Table __p; // 0x10
        public object field_1; // 0x208
        public object field_2; // 0x209

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsUdonInfo(){} // RVA: 0x7FFE881444A0 | overloaded x2
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void Names(){} // RVA: 0x7FFE8814F2E0
        public void get_NamesLength(){} // RVA: 0x7FFE8814C740
        public void Types(){} // RVA: 0x7FFE8814F3B0
        public void get_TypesLength(){} // RVA: 0x7FFE8814D440
        public void CreateUdonInfo(){} // RVA: 0x7FFE8814F480
        public void StartUdonInfo(){} // RVA: 0x7FFE8814D560
        public void AddNames(){} // RVA: 0x7FFE8814C380
        public void CreateNamesVector(){} // RVA: 0x7FFE88144E80
        public void CreateNamesVectorBlock(){} // RVA: 0x7FFE8814F6D0 | overloaded x3
        public void StartNamesVector(){} // RVA: 0x7FFE88145240
        public void AddTypes(){} // RVA: 0x7FFE8814D7F0
        public void CreateTypesVector(){} // RVA: 0x7FFE88144E80
        public void CreateTypesVectorBlock(){} // RVA: 0x7FFE8814F930 | overloaded x3
        public void StartTypesVector(){} // RVA: 0x7FFE88145240
        public void EndUdonInfo(){} // RVA: 0x7FFE8814F9F0
        public void UnPack(){} // RVA: 0x7FFE8814FA40
        public void UnPackTo(){} // RVA: 0x7FFE8814FAB0
        public void Pack(){} // RVA: 0x7FFE8814FDA0
    }

    public class UdonInfoT : Object
    {
        public System.Collections.Generic.List`1<string> _names; // 0x10
        public System.Collections.Generic.List`1<string> _types; // 0x18

        // ── Methods ──
        public void get_Names(){} // RVA: 0x7FFE81116380
        public void set_Names(){} // RVA: 0x7FFE810FCE30
        public void get_Types(){} // RVA: 0x7FFE810FE7C0
        public void set_Types(){} // RVA: 0x7FFE81161E80
        public void .ctor(){} // RVA: 0x7FFE8812BFA0
    }

    public class UdonInfoVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFE88150120
    }

    public class UdonInt : ValueType
    {
        public Google.FlatBuffers32.Struct __p; // 0x10
        public object field_1; // 0x2E1

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_Value(){} // RVA: 0x7FFE8814BD70
        public void CreateUdonInt(){} // RVA: 0x7FFE8816A850
        public void UnPack(){} // RVA: 0x7FFE8816A8E0
        public void UnPackTo(){} // RVA: 0x7FFE8814BEA0
        public void Pack(){} // RVA: 0x7FFE8816A950
    }

    public class UdonIntArray : ValueType
    {
        public Google.FlatBuffers32.Table __p; // 0x10
        public object field_1; // 0x30B

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsUdonIntArray(){} // RVA: 0x7FFE881444A0 | overloaded x2
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void Value(){} // RVA: 0x7FFE8815C5F0
        public void get_ValueLength(){} // RVA: 0x7FFE8814C740
        public void GetValueBytes(){} // RVA: 0x7FFE8816DA70
        public void GetValueArray(){} // RVA: 0x7FFE8816DAE0
        public void CreateUdonIntArray(){} // RVA: 0x7FFE8816DB30
        public void StartUdonIntArray(){} // RVA: 0x7FFE8814C360
        public void AddValue(){} // RVA: 0x7FFE8814C380
        public void CreateValueVector(){} // RVA: 0x7FFE881507C0
        public void CreateValueVectorBlock(){} // RVA: 0x7FFE8816DD50 | overloaded x3
        public void StartValueVector(){} // RVA: 0x7FFE88145240
        public void EndUdonIntArray(){} // RVA: 0x7FFE8816DE10
        public void UnPack(){} // RVA: 0x7FFE8816DE60
        public void UnPackTo(){} // RVA: 0x7FFE8816DF10
        public void Pack(){} // RVA: 0x7FFE8816E130
    }

    public class UdonIntArrayT : Object
    {
        public System.Collections.Generic.List`1<int> _value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFE81116380
        public void set_Value(){} // RVA: 0x7FFE810FCE30
        public void .ctor(){} // RVA: 0x7FFE86200400
    }

    public class UdonIntArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFE8815CE20
    }

    public class UdonIntT : Object
    {
        public int _value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFE811485C0
        public void set_Value(){} // RVA: 0x7FFE810FE0C0
        public void .ctor(){} // RVA: 0x7FFE817EE4A0
    }

    public class UdonLong : ValueType
    {
        public Google.FlatBuffers32.Struct __p; // 0x10
        public object field_1; // 0x2E4

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_Value(){} // RVA: 0x7FFE88154C80
        public void CreateUdonLong(){} // RVA: 0x7FFE8816A970
        public void UnPack(){} // RVA: 0x7FFE8816AA00
        public void UnPackTo(){} // RVA: 0x7FFE8816AA70
        public void Pack(){} // RVA: 0x7FFE8816AAB0
    }

    public class UdonLongArray : ValueType
    {
        public Google.FlatBuffers32.Table __p; // 0x10
        public object field_1; // 0x30E

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsUdonLongArray(){} // RVA: 0x7FFE881444A0 | overloaded x2
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void Value(){} // RVA: 0x7FFE8816E220
        public void get_ValueLength(){} // RVA: 0x7FFE8814C740
        public void GetValueBytes(){} // RVA: 0x7FFE8816E2A0
        public void GetValueArray(){} // RVA: 0x7FFE8816E310
        public void CreateUdonLongArray(){} // RVA: 0x7FFE8816E360
        public void StartUdonLongArray(){} // RVA: 0x7FFE8814C360
        public void AddValue(){} // RVA: 0x7FFE8814C380
        public void CreateValueVector(){} // RVA: 0x7FFE8816E3E0
        public void CreateValueVectorBlock(){} // RVA: 0x7FFE8816E710 | overloaded x3
        public void StartValueVector(){} // RVA: 0x7FFE8816E7D0
        public void EndUdonLongArray(){} // RVA: 0x7FFE8816E800
        public void UnPack(){} // RVA: 0x7FFE8816E850
        public void UnPackTo(){} // RVA: 0x7FFE8816E900
        public void Pack(){} // RVA: 0x7FFE8816EB20
    }

    public class UdonLongArrayT : Object
    {
        public System.Collections.Generic.List`1<long> _value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFE81116380
        public void set_Value(){} // RVA: 0x7FFE810FCE30
        public void .ctor(){} // RVA: 0x7FFE86200400
    }

    public class UdonLongArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFE8816EC10
    }

    public class UdonLongT : Object
    {
        public long _value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFE81116380
        public void set_Value(){} // RVA: 0x7FFE826F2ED0
        public void .ctor(){} // RVA: 0x7FFE81DB74C0
    }

    public class UdonShort : ValueType
    {
        public Google.FlatBuffers32.Struct __p; // 0x10
        public object field_1; // 0x2F6

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_Value(){} // RVA: 0x7FFE8815FE60
        public void CreateUdonShort(){} // RVA: 0x7FFE8816B160
        public void UnPack(){} // RVA: 0x7FFE8816B1F0
        public void UnPackTo(){} // RVA: 0x7FFE8815FF90
        public void Pack(){} // RVA: 0x7FFE8816B260
    }

    public class UdonShortArray : ValueType
    {
        public Google.FlatBuffers32.Table __p; // 0x10
        public object field_1; // 0x320

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsUdonShortArray(){} // RVA: 0x7FFE881444A0 | overloaded x2
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void Value(){} // RVA: 0x7FFE8816C900
        public void get_ValueLength(){} // RVA: 0x7FFE8814C740
        public void GetValueBytes(){} // RVA: 0x7FFE88171760
        public void GetValueArray(){} // RVA: 0x7FFE881717D0
        public void CreateUdonShortArray(){} // RVA: 0x7FFE88171820
        public void StartUdonShortArray(){} // RVA: 0x7FFE8814C360
        public void AddValue(){} // RVA: 0x7FFE8814C380
        public void CreateValueVector(){} // RVA: 0x7FFE8816CAC0
        public void CreateValueVectorBlock(){} // RVA: 0x7FFE88171AE0 | overloaded x3
        public void StartValueVector(){} // RVA: 0x7FFE8816CE10
        public void EndUdonShortArray(){} // RVA: 0x7FFE88171BA0
        public void UnPack(){} // RVA: 0x7FFE88171BF0
        public void UnPackTo(){} // RVA: 0x7FFE88171CA0
        public void Pack(){} // RVA: 0x7FFE88171ED0
    }

    public class UdonShortArrayT : Object
    {
        public System.Collections.Generic.List`1<short> _value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFE81116380
        public void set_Value(){} // RVA: 0x7FFE810FCE30
        public void .ctor(){} // RVA: 0x7FFE86200400
    }

    public class UdonShortArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFE8816D260
    }

    public class UdonShortT : Object
    {
        public short _value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFE8299FB40
        public void set_Value(){} // RVA: 0x7FFE8299FB10
        public void .ctor(){} // RVA: 0x7FFE82B02750
    }

    public class UdonString : ValueType
    {
        public Google.FlatBuffers32.Table __p; // 0x10
        public object field_1; // 0x2FC

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsUdonString(){} // RVA: 0x7FFE881444A0 | overloaded x2
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_Value(){} // RVA: 0x7FFE8814C190
        public void GetValueBytes(){} // RVA: 0x7FFE8816B3A0
        public void GetValueArray(){} // RVA: 0x7FFE8816B410
        public void CreateUdonString(){} // RVA: 0x7FFE8816B460
        public void StartUdonString(){} // RVA: 0x7FFE8814C360
        public void AddValue(){} // RVA: 0x7FFE8814C380
        public void EndUdonString(){} // RVA: 0x7FFE8816B4E0
        public void UnPack(){} // RVA: 0x7FFE8816B530
        public void UnPackTo(){} // RVA: 0x7FFE8814C520
        public void Pack(){} // RVA: 0x7FFE8816B640
    }

    public class UdonStringArray : ValueType
    {
        public Google.FlatBuffers32.Table __p; // 0x10
        public object field_1; // 0x2FF

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsUdonStringArray(){} // RVA: 0x7FFE881444A0 | overloaded x2
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void Value(){} // RVA: 0x7FFE8814F2E0
        public void get_ValueLength(){} // RVA: 0x7FFE8814C740
        public void CreateUdonStringArray(){} // RVA: 0x7FFE8816B700
        public void StartUdonStringArray(){} // RVA: 0x7FFE8814C360
        public void AddValue(){} // RVA: 0x7FFE8814C380
        public void CreateValueVector(){} // RVA: 0x7FFE88144E80
        public void CreateValueVectorBlock(){} // RVA: 0x7FFE8816B920 | overloaded x3
        public void StartValueVector(){} // RVA: 0x7FFE88145240
        public void EndUdonStringArray(){} // RVA: 0x7FFE8816B9E0
        public void UnPack(){} // RVA: 0x7FFE8816BA30
        public void UnPackTo(){} // RVA: 0x7FFE8816BAE0
        public void Pack(){} // RVA: 0x7FFE8816BCA0
    }

    public class UdonStringArrayT : Object
    {
        public System.Collections.Generic.List`1<string> _value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFE81116380
        public void set_Value(){} // RVA: 0x7FFE810FCE30
        public void .ctor(){} // RVA: 0x7FFE86200400
    }

    public class UdonStringArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFE8816BEE0
    }

    public class UdonStringT : Object
    {
        public string _value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFE81116380
        public void set_Value(){} // RVA: 0x7FFE810FCE30
        public void .ctor(){} // RVA: 0x7FFE86200400
    }

    public class UdonStringVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFE8814C650
    }

    public class UdonT : Object
    {
        public System.Collections.Generic.List`1<VRC.Core.Networking.FlatBuffers.FlatBuffers32.UdonValueUnion> _data; // 0x10

        // ── Methods ──
        public void get_Data(){} // RVA: 0x7FFE81116380
        public void set_Data(){} // RVA: 0x7FFE810FCE30
        public void .ctor(){} // RVA: 0x7FFE86200400
        public void DeserializeFromBinary(){} // RVA: 0x7FFE88177E70
        public void SerializeToBinary(){} // RVA: 0x7FFE88177F20
    }

    public class UdonUByte : ValueType
    {
        public Google.FlatBuffers32.Struct __p; // 0x10
        public object field_1; // 0x2E7

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_Value(){} // RVA: 0x7FFE88155130
        public void CreateUdonUByte(){} // RVA: 0x7FFE8816AAD0
        public void UnPack(){} // RVA: 0x7FFE8816AB60
        public void UnPackTo(){} // RVA: 0x7FFE88160BE0
        public void Pack(){} // RVA: 0x7FFE8816ABD0
    }

    public class UdonUByteArray : ValueType
    {
        public Google.FlatBuffers32.Table __p; // 0x10
        public object field_1; // 0x311

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsUdonUByteArray(){} // RVA: 0x7FFE881444A0 | overloaded x2
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void Value(){} // RVA: 0x7FFE8814C6C0
        public void get_ValueLength(){} // RVA: 0x7FFE8814C740
        public void GetValueBytes(){} // RVA: 0x7FFE8816EC80
        public void GetValueArray(){} // RVA: 0x7FFE8816ECF0
        public void CreateUdonUByteArray(){} // RVA: 0x7FFE8816ED40
        public void StartUdonUByteArray(){} // RVA: 0x7FFE8814C360
        public void AddValue(){} // RVA: 0x7FFE8814C380
        public void CreateValueVector(){} // RVA: 0x7FFE8814C8F0
        public void CreateValueVectorBlock(){} // RVA: 0x7FFE8816EF60 | overloaded x3
        public void StartValueVector(){} // RVA: 0x7FFE8814CC40
        public void EndUdonUByteArray(){} // RVA: 0x7FFE8816F020
        public void UnPack(){} // RVA: 0x7FFE8816F070
        public void UnPackTo(){} // RVA: 0x7FFE8816F120
        public void Pack(){} // RVA: 0x7FFE8816F330
    }

    public class UdonUByteArrayT : Object
    {
        public System.Collections.Generic.List`1<byte> _value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFE81116380
        public void set_Value(){} // RVA: 0x7FFE810FCE30
        public void .ctor(){} // RVA: 0x7FFE86200400
    }

    public class UdonUByteArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFE8814D140
    }

    public class UdonUByteT : Object
    {
        public byte _value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFE811C55E0
        public void set_Value(){} // RVA: 0x7FFE811C55F0
        public void .ctor(){} // RVA: 0x7FFE81FCAC70
    }

    public class UdonUInt : ValueType
    {
        public Google.FlatBuffers32.Struct __p; // 0x10
        public object field_1; // 0x2EA

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_Value(){} // RVA: 0x7FFE8814BD70
        public void CreateUdonUInt(){} // RVA: 0x7FFE8816ABF0
        public void UnPack(){} // RVA: 0x7FFE8816AC80
        public void UnPackTo(){} // RVA: 0x7FFE8814BEA0
        public void Pack(){} // RVA: 0x7FFE8816ACF0
    }

    public class UdonUIntArray : ValueType
    {
        public Google.FlatBuffers32.Table __p; // 0x10
        public object field_1; // 0x314

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsUdonUIntArray(){} // RVA: 0x7FFE881444A0 | overloaded x2
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void Value(){} // RVA: 0x7FFE8815C5F0
        public void get_ValueLength(){} // RVA: 0x7FFE8814C740
        public void GetValueBytes(){} // RVA: 0x7FFE8816F420
        public void GetValueArray(){} // RVA: 0x7FFE8816F490
        public void CreateUdonUIntArray(){} // RVA: 0x7FFE8816F4E0
        public void StartUdonUIntArray(){} // RVA: 0x7FFE8814C360
        public void AddValue(){} // RVA: 0x7FFE8814C380
        public void CreateValueVector(){} // RVA: 0x7FFE881507C0
        public void CreateValueVectorBlock(){} // RVA: 0x7FFE8816F700 | overloaded x3
        public void StartValueVector(){} // RVA: 0x7FFE88145240
        public void EndUdonUIntArray(){} // RVA: 0x7FFE8816F7C0
        public void UnPack(){} // RVA: 0x7FFE8816F810
        public void UnPackTo(){} // RVA: 0x7FFE8816F8C0
        public void Pack(){} // RVA: 0x7FFE8816FAE0
    }

    public class UdonUIntArrayT : Object
    {
        public System.Collections.Generic.List`1<uint> _value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFE81116380
        public void set_Value(){} // RVA: 0x7FFE810FCE30
        public void .ctor(){} // RVA: 0x7FFE86200400
    }

    public class UdonUIntArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFE8815CE20
    }

    public class UdonUIntT : Object
    {
        public uint _value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFE811485C0
        public void set_Value(){} // RVA: 0x7FFE810FE0C0
        public void .ctor(){} // RVA: 0x7FFE817EE4A0
    }

    public class UdonULong : ValueType
    {
        public Google.FlatBuffers32.Struct __p; // 0x10
        public object field_1; // 0x2ED

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_Value(){} // RVA: 0x7FFE88154C80
        public void CreateUdonULong(){} // RVA: 0x7FFE8816AD10
        public void UnPack(){} // RVA: 0x7FFE8816ADA0
        public void UnPackTo(){} // RVA: 0x7FFE8816AA70
        public void Pack(){} // RVA: 0x7FFE8816AE10
    }

    public class UdonULongArray : ValueType
    {
        public Google.FlatBuffers32.Table __p; // 0x10
        public object field_1; // 0x317

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsUdonULongArray(){} // RVA: 0x7FFE881444A0 | overloaded x2
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void Value(){} // RVA: 0x7FFE8816E220
        public void get_ValueLength(){} // RVA: 0x7FFE8814C740
        public void GetValueBytes(){} // RVA: 0x7FFE8816FBD0
        public void GetValueArray(){} // RVA: 0x7FFE8816FC40
        public void CreateUdonULongArray(){} // RVA: 0x7FFE8816FC90
        public void StartUdonULongArray(){} // RVA: 0x7FFE8814C360
        public void AddValue(){} // RVA: 0x7FFE8814C380
        public void CreateValueVector(){} // RVA: 0x7FFE8816E3E0
        public void CreateValueVectorBlock(){} // RVA: 0x7FFE8816FF50 | overloaded x3
        public void StartValueVector(){} // RVA: 0x7FFE8816E7D0
        public void EndUdonULongArray(){} // RVA: 0x7FFE88170010
        public void UnPack(){} // RVA: 0x7FFE88170060
        public void UnPackTo(){} // RVA: 0x7FFE88170110
        public void Pack(){} // RVA: 0x7FFE88170330
    }

    public class UdonULongArrayT : Object
    {
        public System.Collections.Generic.List`1<ulong> _value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFE81116380
        public void set_Value(){} // RVA: 0x7FFE810FCE30
        public void .ctor(){} // RVA: 0x7FFE86200400
    }

    public class UdonULongArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFE8816EC10
    }

    public class UdonULongT : Object
    {
        public ulong _value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFE81116380
        public void set_Value(){} // RVA: 0x7FFE826F2ED0
        public void .ctor(){} // RVA: 0x7FFE81DB74C0
    }

    public class UdonUShort : ValueType
    {
        public Google.FlatBuffers32.Struct __p; // 0x10
        public object field_1; // 0x2F9

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_Value(){} // RVA: 0x7FFE8815FE60
        public void CreateUdonUShort(){} // RVA: 0x7FFE8816B280
        public void UnPack(){} // RVA: 0x7FFE8816B310
        public void UnPackTo(){} // RVA: 0x7FFE8815FF90
        public void Pack(){} // RVA: 0x7FFE8816B380
    }

    public class UdonUShortArray : ValueType
    {
        public Google.FlatBuffers32.Table __p; // 0x10
        public object field_1; // 0x323

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsUdonUShortArray(){} // RVA: 0x7FFE881444A0 | overloaded x2
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void Value(){} // RVA: 0x7FFE8816C900
        public void get_ValueLength(){} // RVA: 0x7FFE8814C740
        public void GetValueBytes(){} // RVA: 0x7FFE88171FC0
        public void GetValueArray(){} // RVA: 0x7FFE88172030
        public void CreateUdonUShortArray(){} // RVA: 0x7FFE88172080
        public void StartUdonUShortArray(){} // RVA: 0x7FFE8814C360
        public void AddValue(){} // RVA: 0x7FFE8814C380
        public void CreateValueVector(){} // RVA: 0x7FFE8816CAC0
        public void CreateValueVectorBlock(){} // RVA: 0x7FFE881722A0 | overloaded x3
        public void StartValueVector(){} // RVA: 0x7FFE8816CE10
        public void EndUdonUShortArray(){} // RVA: 0x7FFE88172360
        public void UnPack(){} // RVA: 0x7FFE881723B0
        public void UnPackTo(){} // RVA: 0x7FFE88172460
        public void Pack(){} // RVA: 0x7FFE88172690
    }

    public class UdonUShortArrayT : Object
    {
        public System.Collections.Generic.List`1<ushort> _value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFE81116380
        public void set_Value(){} // RVA: 0x7FFE810FCE30
        public void .ctor(){} // RVA: 0x7FFE86200400
    }

    public class UdonUShortArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFE8816D260
    }

    public class UdonUShortT : Object
    {
        public ushort _value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFE8299FB40
        public void set_Value(){} // RVA: 0x7FFE8299FB10
        public void .ctor(){} // RVA: 0x7FFE82B02750
    }

    public class UdonValueUnion : Object
    {
        public 0x665FBEB4 _type; // 0x10
        public object _value; // 0x18

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFE811C55E0
        public void set_Type(){} // RVA: 0x7FFE811C55F0
        public void get_Value(){} // RVA: 0x7FFE810FE7C0
        public void set_Value(){} // RVA: 0x7FFE81161E80
        public void .ctor(){} // RVA: 0x7FFE8811CB20
        public void As(){} // RVA: 0x7FFE810A1420
        public void AsUdonShort(){} // RVA: 0x7FFE88165E60
        public void FromUdonShort(){} // RVA: 0x7FFE88165EA0
        public void AsUdonUShort(){} // RVA: 0x7FFE88165FA0
        public void FromUdonUShort(){} // RVA: 0x7FFE88165FE0
        public void AsUdonChar(){} // RVA: 0x7FFE881660E0
        public void FromUdonChar(){} // RVA: 0x7FFE88166120
        public void AsUdonByte(){} // RVA: 0x7FFE88166220
        public void FromUdonByte(){} // RVA: 0x7FFE88166260
        public void AsUdonUByte(){} // RVA: 0x7FFE88166360
        public void FromUdonUByte(){} // RVA: 0x7FFE881663A0
        public void AsUdonLong(){} // RVA: 0x7FFE881664A0
        public void FromUdonLong(){} // RVA: 0x7FFE881664E0
        public void AsUdonULong(){} // RVA: 0x7FFE881665E0
        public void FromUdonULong(){} // RVA: 0x7FFE88166620
        public void AsUdonDouble(){} // RVA: 0x7FFE88166720
        public void FromUdonDouble(){} // RVA: 0x7FFE88166760
        public void AsUdonBool(){} // RVA: 0x7FFE88166860
        public void FromUdonBool(){} // RVA: 0x7FFE881668A0
        public void AsUdonFloat(){} // RVA: 0x7FFE881669A0
        public void FromUdonFloat(){} // RVA: 0x7FFE881669E0
        public void AsUdonInt(){} // RVA: 0x7FFE88166AE0
        public void FromUdonInt(){} // RVA: 0x7FFE88166B20
        public void AsUdonUInt(){} // RVA: 0x7FFE88166C20
        public void FromUdonUInt(){} // RVA: 0x7FFE88166C60
        public void AsVector2(){} // RVA: 0x7FFE88166D60
        public void FromVector2(){} // RVA: 0x7FFE88166DA0
        public void AsVector3(){} // RVA: 0x7FFE88166EA0
        public void FromVector3(){} // RVA: 0x7FFE88166EE0
        public void AsVector4(){} // RVA: 0x7FFE88166FE0
        public void FromVector4(){} // RVA: 0x7FFE88167020
        public void AsQuaternion(){} // RVA: 0x7FFE88167120
        public void FromQuaternion(){} // RVA: 0x7FFE88167160
        public void AsColor(){} // RVA: 0x7FFE88167260
        public void FromColor(){} // RVA: 0x7FFE881672A0
        public void AsColor32(){} // RVA: 0x7FFE881673A0
        public void FromColor32(){} // RVA: 0x7FFE881673E0
        public void AsUdonShortArray(){} // RVA: 0x7FFE881674E0
        public void FromUdonShortArray(){} // RVA: 0x7FFE88167520
        public void AsUdonUShortArray(){} // RVA: 0x7FFE88167620
        public void FromUdonUShortArray(){} // RVA: 0x7FFE88167660
        public void AsUdonCharArray(){} // RVA: 0x7FFE88167760
        public void FromUdonCharArray(){} // RVA: 0x7FFE881677A0
        public void AsUdonByteArray(){} // RVA: 0x7FFE881678A0
        public void FromUdonByteArray(){} // RVA: 0x7FFE881678E0
        public void AsUdonUByteArray(){} // RVA: 0x7FFE881679E0
        public void FromUdonUByteArray(){} // RVA: 0x7FFE88167A20
        public void AsUdonLongArray(){} // RVA: 0x7FFE88167B20
        public void FromUdonLongArray(){} // RVA: 0x7FFE88167B60
        public void AsUdonULongArray(){} // RVA: 0x7FFE88167C60
        public void FromUdonULongArray(){} // RVA: 0x7FFE88167CA0
        public void AsUdonDoubleArray(){} // RVA: 0x7FFE88167DA0
        public void FromUdonDoubleArray(){} // RVA: 0x7FFE88167DE0
        public void AsUdonBoolArray(){} // RVA: 0x7FFE88167EE0
        public void FromUdonBoolArray(){} // RVA: 0x7FFE88167F20
        public void AsUdonFloatArray(){} // RVA: 0x7FFE88168020
        public void FromUdonFloatArray(){} // RVA: 0x7FFE88168060
        public void AsUdonIntArray(){} // RVA: 0x7FFE88168160
        public void FromUdonIntArray(){} // RVA: 0x7FFE881681A0
        public void AsUdonUIntArray(){} // RVA: 0x7FFE881682A0
        public void FromUdonUIntArray(){} // RVA: 0x7FFE881682E0
        public void AsVector2Array(){} // RVA: 0x7FFE881683E0
        public void FromVector2Array(){} // RVA: 0x7FFE88168420
        public void AsVector3Array(){} // RVA: 0x7FFE88168520
        public void FromVector3Array(){} // RVA: 0x7FFE88168560
        public void AsVector4Array(){} // RVA: 0x7FFE88168660
        public void FromVector4Array(){} // RVA: 0x7FFE881686A0
        public void AsQuaternionArray(){} // RVA: 0x7FFE881687A0
        public void FromQuaternionArray(){} // RVA: 0x7FFE881687E0
        public void AsColorArray(){} // RVA: 0x7FFE881688E0
        public void FromColorArray(){} // RVA: 0x7FFE88168920
        public void AsColor32Array(){} // RVA: 0x7FFE88168A20
        public void FromColor32Array(){} // RVA: 0x7FFE88168A60
        public void AsUdonString(){} // RVA: 0x7FFE88168B60
        public void FromUdonString(){} // RVA: 0x7FFE88168BA0
        public void Pack(){} // RVA: 0x7FFE88168CA0
    }

    public class UdonValueVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFE8816A0D0
    }

    public class UdonVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFE8814D140
    }

}