// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers8
// Classes: 68
// Methods: 585

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers8
{
    public class Udon : ValueType
    {
        public Google.FlatBuffers8.Table __p; // 0x10
        public object field_1; // 0x1BA
        public object field_2; // 0x1BB

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsUdon(){} // RVA: 0x7FFE8811DC90 | overloaded x2
        public void VerifyUdon(){} // RVA: 0x7FFE88140C60
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void DataType(){} // RVA: 0x7FFE8811E240
        public void get_DataTypeLength(){} // RVA: 0x7FFE8811E2C0
        public void GetDataTypeBytes(){} // RVA: 0x7FFE88140D50
        public void GetDataTypeArray(){} // RVA: 0x7FFE88140DC0
        public void Data(){} // RVA: 0x7FFE810A1420
        public void get_DataLength(){} // RVA: 0x7FFE8811EED0
        public void CreateUdon(){} // RVA: 0x7FFE88140F70
        public void StartUdon(){} // RVA: 0x7FFE8811F030
        public void AddDataType(){} // RVA: 0x7FFE8811DF20
        public void CreateDataTypeVector(){} // RVA: 0x7FFE8811E4B0
        public void CreateDataTypeVectorBlock(){} // RVA: 0x7FFE881411C0 | overloaded x3
        public void StartDataTypeVector(){} // RVA: 0x7FFE8811E750
        public void AddData(){} // RVA: 0x7FFE8811F240
        public void CreateDataVector(){} // RVA: 0x7FFE8811F280
        public void CreateDataVectorBlock(){} // RVA: 0x7FFE881413A0 | overloaded x3
        public void StartDataVector(){} // RVA: 0x7FFE8811E750
        public void EndUdon(){} // RVA: 0x7FFE88141430
        public void FinishUdonBuffer(){} // RVA: 0x7FFE8811F580
        public void FinishSizePrefixedUdonBuffer(){} // RVA: 0x7FFE8811F5E0
        public void UnPack(){} // RVA: 0x7FFE881414C0
        public void UnPackTo(){} // RVA: 0x7FFE88141570
        public void Pack(){} // RVA: 0x7FFE88143530
    }

    public class UdonBool : ValueType
    {
        public Google.FlatBuffers8.Struct __p; // 0x10
        public object field_1; // 0x15D

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_Value(){} // RVA: 0x7FFE8811D6C0
        public void CreateUdonBool(){} // RVA: 0x7FFE88136280
        public void UnPack(){} // RVA: 0x7FFE88136350
        public void UnPackTo(){} // RVA: 0x7FFE8811D830
        public void Pack(){} // RVA: 0x7FFE881363C0
    }

    public class UdonBoolArray : ValueType
    {
        public Google.FlatBuffers8.Table __p; // 0x10
        public object field_1; // 0x184

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsUdonBoolArray(){} // RVA: 0x7FFE8811DC90 | overloaded x2
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void Value(){} // RVA: 0x7FFE88137820
        public void get_ValueLength(){} // RVA: 0x7FFE8811E2C0
        public void GetValueBytes(){} // RVA: 0x7FFE881378A0
        public void GetValueArray(){} // RVA: 0x7FFE88137910
        public void CreateUdonBoolArray(){} // RVA: 0x7FFE88137960
        public void StartUdonBoolArray(){} // RVA: 0x7FFE8811DF00
        public void AddValue(){} // RVA: 0x7FFE8811DF20
        public void CreateValueVector(){} // RVA: 0x7FFE88137A20
        public void CreateValueVectorBlock(){} // RVA: 0x7FFE88137CD0 | overloaded x3
        public void StartValueVector(){} // RVA: 0x7FFE8811E750
        public void EndUdonBoolArray(){} // RVA: 0x7FFE88137D60
        public void UnPack(){} // RVA: 0x7FFE88137DF0
        public void UnPackTo(){} // RVA: 0x7FFE88137EA0
        public void Pack(){} // RVA: 0x7FFE881380B0
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
        public void Verify(){} // RVA: 0x7FFE8811EB50
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
        public Google.FlatBuffers8.Struct __p; // 0x10
        public object field_1; // 0x163

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_Value(){} // RVA: 0x7FFE88122E10
        public void CreateUdonByte(){} // RVA: 0x7FFE881365B0
        public void UnPack(){} // RVA: 0x7FFE88136680
        public void UnPackTo(){} // RVA: 0x7FFE881366F0
        public void Pack(){} // RVA: 0x7FFE88136730
    }

    public class UdonByteArray : ValueType
    {
        public Google.FlatBuffers8.Table __p; // 0x10
        public object field_1; // 0x18A

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsUdonByteArray(){} // RVA: 0x7FFE8811DC90 | overloaded x2
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void Value(){} // RVA: 0x7FFE8811E240
        public void get_ValueLength(){} // RVA: 0x7FFE8811E2C0
        public void GetValueBytes(){} // RVA: 0x7FFE88138A60
        public void GetValueArray(){} // RVA: 0x7FFE88138AD0
        public void CreateUdonByteArray(){} // RVA: 0x7FFE88138B20
        public void StartUdonByteArray(){} // RVA: 0x7FFE8811DF00
        public void AddValue(){} // RVA: 0x7FFE8811DF20
        public void CreateValueVector(){} // RVA: 0x7FFE8811E4B0
        public void CreateValueVectorBlock(){} // RVA: 0x7FFE88138D30 | overloaded x3
        public void StartValueVector(){} // RVA: 0x7FFE8811E750
        public void EndUdonByteArray(){} // RVA: 0x7FFE88138DC0
        public void UnPack(){} // RVA: 0x7FFE88138E50
        public void UnPackTo(){} // RVA: 0x7FFE88138F00
        public void Pack(){} // RVA: 0x7FFE88139110
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
        public void Verify(){} // RVA: 0x7FFE8811EB50
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
        public Google.FlatBuffers8.Struct __p; // 0x10
        public object field_1; // 0x160

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_Value(){} // RVA: 0x7FFE881363E0
        public void CreateUdonChar(){} // RVA: 0x7FFE88136410
        public void UnPack(){} // RVA: 0x7FFE881364E0
        public void UnPackTo(){} // RVA: 0x7FFE88136550
        public void Pack(){} // RVA: 0x7FFE88136590
    }

    public class UdonCharArray : ValueType
    {
        public Google.FlatBuffers8.Table __p; // 0x10
        public object field_1; // 0x187

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsUdonCharArray(){} // RVA: 0x7FFE8811DC90 | overloaded x2
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void Value(){} // RVA: 0x7FFE88138130
        public void get_ValueLength(){} // RVA: 0x7FFE8811E2C0
        public void GetValueBytes(){} // RVA: 0x7FFE881381B0
        public void GetValueArray(){} // RVA: 0x7FFE88138220
        public void CreateUdonCharArray(){} // RVA: 0x7FFE88138270
        public void StartUdonCharArray(){} // RVA: 0x7FFE8811DF00
        public void AddValue(){} // RVA: 0x7FFE8811DF20
        public void CreateValueVector(){} // RVA: 0x7FFE88138330
        public void CreateValueVectorBlock(){} // RVA: 0x7FFE88138540 | overloaded x3
        public void StartValueVector(){} // RVA: 0x7FFE881385D0
        public void EndUdonCharArray(){} // RVA: 0x7FFE88138600
        public void UnPack(){} // RVA: 0x7FFE88138690
        public void UnPackTo(){} // RVA: 0x7FFE88138740
        public void Pack(){} // RVA: 0x7FFE88138970
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
        public void Verify(){} // RVA: 0x7FFE881389F0
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
        public Google.FlatBuffers8.Struct __p; // 0x10
        public object field_1; // 0x178

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_Value(){} // RVA: 0x7FFE88137000
        public void CreateUdonDouble(){} // RVA: 0x7FFE88137030
        public void UnPack(){} // RVA: 0x7FFE88137100
        public void UnPackTo(){} // RVA: 0x7FFE88137180
        public void Pack(){} // RVA: 0x7FFE881371C0
    }

    public class UdonDoubleArray : ValueType
    {
        public Google.FlatBuffers8.Table __p; // 0x10
        public object field_1; // 0x19F

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsUdonDoubleArray(){} // RVA: 0x7FFE8811DC90 | overloaded x2
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void Value(){} // RVA: 0x7FFE8813C5E0
        public void get_ValueLength(){} // RVA: 0x7FFE8811E2C0
        public void GetValueBytes(){} // RVA: 0x7FFE8813C660
        public void GetValueArray(){} // RVA: 0x7FFE8813C6D0
        public void CreateUdonDoubleArray(){} // RVA: 0x7FFE8813C720
        public void StartUdonDoubleArray(){} // RVA: 0x7FFE8811DF00
        public void AddValue(){} // RVA: 0x7FFE8811DF20
        public void CreateValueVector(){} // RVA: 0x7FFE8813C7E0
        public void CreateValueVectorBlock(){} // RVA: 0x7FFE8813CA80 | overloaded x3
        public void StartValueVector(){} // RVA: 0x7FFE8813A0A0
        public void EndUdonDoubleArray(){} // RVA: 0x7FFE8813CB10
        public void UnPack(){} // RVA: 0x7FFE8813CBA0
        public void UnPackTo(){} // RVA: 0x7FFE8813CC50
        public void Pack(){} // RVA: 0x7FFE8813CE70
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
        public void Verify(){} // RVA: 0x7FFE8813A4C0
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
        public Google.FlatBuffers8.Struct __p; // 0x10
        public object field_1; // 0x175

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_Value(){} // RVA: 0x7FFE8811DA60
        public void CreateUdonFloat(){} // RVA: 0x7FFE88136EA0
        public void UnPack(){} // RVA: 0x7FFE88136F70
        public void UnPackTo(){} // RVA: 0x7FFE8811DBD0
        public void Pack(){} // RVA: 0x7FFE88136FE0
    }

    public class UdonFloatArray : ValueType
    {
        public Google.FlatBuffers8.Table __p; // 0x10
        public object field_1; // 0x19C

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsUdonFloatArray(){} // RVA: 0x7FFE8811DC90 | overloaded x2
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void Value(){} // RVA: 0x7FFE8813BC40
        public void get_ValueLength(){} // RVA: 0x7FFE8811E2C0
        public void GetValueBytes(){} // RVA: 0x7FFE8813BCC0
        public void GetValueArray(){} // RVA: 0x7FFE8813BD30
        public void CreateUdonFloatArray(){} // RVA: 0x7FFE8813BD80
        public void StartUdonFloatArray(){} // RVA: 0x7FFE8811DF00
        public void AddValue(){} // RVA: 0x7FFE8811DF20
        public void CreateValueVector(){} // RVA: 0x7FFE8813BE40
        public void CreateValueVectorBlock(){} // RVA: 0x7FFE8813C0E0 | overloaded x3
        public void StartValueVector(){} // RVA: 0x7FFE881396D0
        public void EndUdonFloatArray(){} // RVA: 0x7FFE8813C170
        public void UnPack(){} // RVA: 0x7FFE8813C200
        public void UnPackTo(){} // RVA: 0x7FFE8813C2B0
        public void Pack(){} // RVA: 0x7FFE8813C4D0
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
        public void Verify(){} // RVA: 0x7FFE88139AF0
    }

    public class UdonFloatT : Object
    {
        public float _value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFE81225320
        public void set_Value(){} // RVA: 0x7FFE81225330
        public void .ctor(){} // RVA: 0x7FFE817EE4A0
    }

    public class UdonInt : ValueType
    {
        public Google.FlatBuffers8.Struct __p; // 0x10
        public object field_1; // 0x166

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_Value(){} // RVA: 0x7FFE8811D890
        public void CreateUdonInt(){} // RVA: 0x7FFE88136750
        public void UnPack(){} // RVA: 0x7FFE88136820
        public void UnPackTo(){} // RVA: 0x7FFE8811DA00
        public void Pack(){} // RVA: 0x7FFE88136890
    }

    public class UdonIntArray : ValueType
    {
        public Google.FlatBuffers8.Table __p; // 0x10
        public object field_1; // 0x18D

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsUdonIntArray(){} // RVA: 0x7FFE8811DC90 | overloaded x2
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void Value(){} // RVA: 0x7FFE88139190
        public void get_ValueLength(){} // RVA: 0x7FFE8811E2C0
        public void GetValueBytes(){} // RVA: 0x7FFE88139210
        public void GetValueArray(){} // RVA: 0x7FFE88139280
        public void CreateUdonIntArray(){} // RVA: 0x7FFE881392D0
        public void StartUdonIntArray(){} // RVA: 0x7FFE8811DF00
        public void AddValue(){} // RVA: 0x7FFE8811DF20
        public void CreateValueVector(){} // RVA: 0x7FFE88139390
        public void CreateValueVectorBlock(){} // RVA: 0x7FFE88139640 | overloaded x3
        public void StartValueVector(){} // RVA: 0x7FFE881396D0
        public void EndUdonIntArray(){} // RVA: 0x7FFE88139700
        public void UnPack(){} // RVA: 0x7FFE88139790
        public void UnPackTo(){} // RVA: 0x7FFE88139840
        public void Pack(){} // RVA: 0x7FFE88139A70
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
        public void Verify(){} // RVA: 0x7FFE88139AF0
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
        public Google.FlatBuffers8.Struct __p; // 0x10
        public object field_1; // 0x169

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_Value(){} // RVA: 0x7FFE881368B0
        public void CreateUdonLong(){} // RVA: 0x7FFE881368E0
        public void UnPack(){} // RVA: 0x7FFE881369B0
        public void UnPackTo(){} // RVA: 0x7FFE88136A20
        public void Pack(){} // RVA: 0x7FFE88136A60
    }

    public class UdonLongArray : ValueType
    {
        public Google.FlatBuffers8.Table __p; // 0x10
        public object field_1; // 0x190

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsUdonLongArray(){} // RVA: 0x7FFE8811DC90 | overloaded x2
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void Value(){} // RVA: 0x7FFE88139B60
        public void get_ValueLength(){} // RVA: 0x7FFE8811E2C0
        public void GetValueBytes(){} // RVA: 0x7FFE88139BE0
        public void GetValueArray(){} // RVA: 0x7FFE88139C50
        public void CreateUdonLongArray(){} // RVA: 0x7FFE88139CA0
        public void StartUdonLongArray(){} // RVA: 0x7FFE8811DF00
        public void AddValue(){} // RVA: 0x7FFE8811DF20
        public void CreateValueVector(){} // RVA: 0x7FFE88139D60
        public void CreateValueVectorBlock(){} // RVA: 0x7FFE8813A010 | overloaded x3
        public void StartValueVector(){} // RVA: 0x7FFE8813A0A0
        public void EndUdonLongArray(){} // RVA: 0x7FFE8813A0D0
        public void UnPack(){} // RVA: 0x7FFE8813A160
        public void UnPackTo(){} // RVA: 0x7FFE8813A210
        public void Pack(){} // RVA: 0x7FFE8813A440
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
        public void Verify(){} // RVA: 0x7FFE8813A4C0
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
        public Google.FlatBuffers8.Struct __p; // 0x10
        public object field_1; // 0x17B

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_Value(){} // RVA: 0x7FFE881363E0
        public void CreateUdonShort(){} // RVA: 0x7FFE881371E0
        public void UnPack(){} // RVA: 0x7FFE881372B0
        public void UnPackTo(){} // RVA: 0x7FFE88136550
        public void Pack(){} // RVA: 0x7FFE88137320
    }

    public class UdonShortArray : ValueType
    {
        public Google.FlatBuffers8.Table __p; // 0x10
        public object field_1; // 0x1A2

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsUdonShortArray(){} // RVA: 0x7FFE8811DC90 | overloaded x2
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void Value(){} // RVA: 0x7FFE88138130
        public void get_ValueLength(){} // RVA: 0x7FFE8811E2C0
        public void GetValueBytes(){} // RVA: 0x7FFE8813CF80
        public void GetValueArray(){} // RVA: 0x7FFE8813CFF0
        public void CreateUdonShortArray(){} // RVA: 0x7FFE8813D040
        public void StartUdonShortArray(){} // RVA: 0x7FFE8811DF00
        public void AddValue(){} // RVA: 0x7FFE8811DF20
        public void CreateValueVector(){} // RVA: 0x7FFE88138330
        public void CreateValueVectorBlock(){} // RVA: 0x7FFE8813D2F0 | overloaded x3
        public void StartValueVector(){} // RVA: 0x7FFE881385D0
        public void EndUdonShortArray(){} // RVA: 0x7FFE8813D380
        public void UnPack(){} // RVA: 0x7FFE8813D410
        public void UnPackTo(){} // RVA: 0x7FFE8813D4C0
        public void Pack(){} // RVA: 0x7FFE8813D6F0
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
        public void Verify(){} // RVA: 0x7FFE881389F0
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
        public Google.FlatBuffers8.Table __p; // 0x10
        public object field_1; // 0x181

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsUdonString(){} // RVA: 0x7FFE8811DC90 | overloaded x2
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_Value(){} // RVA: 0x7FFE8811DCF0
        public void GetValueBytes(){} // RVA: 0x7FFE881374A0
        public void GetValueArray(){} // RVA: 0x7FFE88137510
        public void CreateUdonString(){} // RVA: 0x7FFE88137560
        public void StartUdonString(){} // RVA: 0x7FFE8811DF00
        public void AddValue(){} // RVA: 0x7FFE8811DF20
        public void EndUdonString(){} // RVA: 0x7FFE88137620
        public void UnPack(){} // RVA: 0x7FFE881376B0
        public void UnPackTo(){} // RVA: 0x7FFE8811E100
        public void Pack(){} // RVA: 0x7FFE881377C0
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
        public void Verify(){} // RVA: 0x7FFE8811E1D0
    }

    public class UdonT : Object
    {
        public System.Collections.Generic.List`1<VRC.Core.Networking.FlatBuffers.FlatBuffers8.UdonValueUnion> _data; // 0x10

        // ── Methods ──
        public void get_Data(){} // RVA: 0x7FFE81116380
        public void set_Data(){} // RVA: 0x7FFE810FCE30
        public void .ctor(){} // RVA: 0x7FFE86200400
        public void DeserializeFromBinary(){} // RVA: 0x7FFE88143800
        public void SerializeToBinary(){} // RVA: 0x7FFE881438B0
    }

    public class UdonUByte : ValueType
    {
        public Google.FlatBuffers8.Struct __p; // 0x10
        public object field_1; // 0x16C

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_Value(){} // RVA: 0x7FFE88122E10
        public void CreateUdonUByte(){} // RVA: 0x7FFE88136A80
        public void UnPack(){} // RVA: 0x7FFE88136B50
        public void UnPackTo(){} // RVA: 0x7FFE881366F0
        public void Pack(){} // RVA: 0x7FFE88136BC0
    }

    public class UdonUByteArray : ValueType
    {
        public Google.FlatBuffers8.Table __p; // 0x10
        public object field_1; // 0x193

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsUdonUByteArray(){} // RVA: 0x7FFE8811DC90 | overloaded x2
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void Value(){} // RVA: 0x7FFE8811E240
        public void get_ValueLength(){} // RVA: 0x7FFE8811E2C0
        public void GetValueBytes(){} // RVA: 0x7FFE8813A530
        public void GetValueArray(){} // RVA: 0x7FFE8813A5A0
        public void CreateUdonUByteArray(){} // RVA: 0x7FFE8813A5F0
        public void StartUdonUByteArray(){} // RVA: 0x7FFE8811DF00
        public void AddValue(){} // RVA: 0x7FFE8811DF20
        public void CreateValueVector(){} // RVA: 0x7FFE8811E4B0
        public void CreateValueVectorBlock(){} // RVA: 0x7FFE8813A800 | overloaded x3
        public void StartValueVector(){} // RVA: 0x7FFE8811E750
        public void EndUdonUByteArray(){} // RVA: 0x7FFE8813A890
        public void UnPack(){} // RVA: 0x7FFE8813A920
        public void UnPackTo(){} // RVA: 0x7FFE8813A9D0
        public void Pack(){} // RVA: 0x7FFE8813ABE0
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
        public void Verify(){} // RVA: 0x7FFE8811EB50
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
        public Google.FlatBuffers8.Struct __p; // 0x10
        public object field_1; // 0x16F

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_Value(){} // RVA: 0x7FFE8811D890
        public void CreateUdonUInt(){} // RVA: 0x7FFE88136BE0
        public void UnPack(){} // RVA: 0x7FFE88136CB0
        public void UnPackTo(){} // RVA: 0x7FFE8811DA00
        public void Pack(){} // RVA: 0x7FFE88136D20
    }

    public class UdonUIntArray : ValueType
    {
        public Google.FlatBuffers8.Table __p; // 0x10
        public object field_1; // 0x196

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsUdonUIntArray(){} // RVA: 0x7FFE8811DC90 | overloaded x2
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void Value(){} // RVA: 0x7FFE88139190
        public void get_ValueLength(){} // RVA: 0x7FFE8811E2C0
        public void GetValueBytes(){} // RVA: 0x7FFE8813AC60
        public void GetValueArray(){} // RVA: 0x7FFE8813ACD0
        public void CreateUdonUIntArray(){} // RVA: 0x7FFE8813AD20
        public void StartUdonUIntArray(){} // RVA: 0x7FFE8811DF00
        public void AddValue(){} // RVA: 0x7FFE8811DF20
        public void CreateValueVector(){} // RVA: 0x7FFE88139390
        public void CreateValueVectorBlock(){} // RVA: 0x7FFE8813AFD0 | overloaded x3
        public void StartValueVector(){} // RVA: 0x7FFE881396D0
        public void EndUdonUIntArray(){} // RVA: 0x7FFE8813B060
        public void UnPack(){} // RVA: 0x7FFE8813B0F0
        public void UnPackTo(){} // RVA: 0x7FFE8813B1A0
        public void Pack(){} // RVA: 0x7FFE8813B3D0
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
        public void Verify(){} // RVA: 0x7FFE88139AF0
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
        public Google.FlatBuffers8.Struct __p; // 0x10
        public object field_1; // 0x172

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_Value(){} // RVA: 0x7FFE881368B0
        public void CreateUdonULong(){} // RVA: 0x7FFE88136D40
        public void UnPack(){} // RVA: 0x7FFE88136E10
        public void UnPackTo(){} // RVA: 0x7FFE88136A20
        public void Pack(){} // RVA: 0x7FFE88136E80
    }

    public class UdonULongArray : ValueType
    {
        public Google.FlatBuffers8.Table __p; // 0x10
        public object field_1; // 0x199

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsUdonULongArray(){} // RVA: 0x7FFE8811DC90 | overloaded x2
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void Value(){} // RVA: 0x7FFE88139B60
        public void get_ValueLength(){} // RVA: 0x7FFE8811E2C0
        public void GetValueBytes(){} // RVA: 0x7FFE8813B450
        public void GetValueArray(){} // RVA: 0x7FFE8813B4C0
        public void CreateUdonULongArray(){} // RVA: 0x7FFE8813B510
        public void StartUdonULongArray(){} // RVA: 0x7FFE8811DF00
        public void AddValue(){} // RVA: 0x7FFE8811DF20
        public void CreateValueVector(){} // RVA: 0x7FFE88139D60
        public void CreateValueVectorBlock(){} // RVA: 0x7FFE8813B7C0 | overloaded x3
        public void StartValueVector(){} // RVA: 0x7FFE8813A0A0
        public void EndUdonULongArray(){} // RVA: 0x7FFE8813B850
        public void UnPack(){} // RVA: 0x7FFE8813B8E0
        public void UnPackTo(){} // RVA: 0x7FFE8813B990
        public void Pack(){} // RVA: 0x7FFE8813BBC0
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
        public void Verify(){} // RVA: 0x7FFE8813A4C0
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
        public Google.FlatBuffers8.Struct __p; // 0x10
        public object field_1; // 0x17E

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_Value(){} // RVA: 0x7FFE881363E0
        public void CreateUdonUShort(){} // RVA: 0x7FFE88137340
        public void UnPack(){} // RVA: 0x7FFE88137410
        public void UnPackTo(){} // RVA: 0x7FFE88136550
        public void Pack(){} // RVA: 0x7FFE88137480
    }

    public class UdonUShortArray : ValueType
    {
        public Google.FlatBuffers8.Table __p; // 0x10
        public object field_1; // 0x1A5

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsUdonUShortArray(){} // RVA: 0x7FFE8811DC90 | overloaded x2
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void Value(){} // RVA: 0x7FFE88138130
        public void get_ValueLength(){} // RVA: 0x7FFE8811E2C0
        public void GetValueBytes(){} // RVA: 0x7FFE8813D770
        public void GetValueArray(){} // RVA: 0x7FFE8813D7E0
        public void CreateUdonUShortArray(){} // RVA: 0x7FFE8813D830
        public void StartUdonUShortArray(){} // RVA: 0x7FFE8811DF00
        public void AddValue(){} // RVA: 0x7FFE8811DF20
        public void CreateValueVector(){} // RVA: 0x7FFE88138330
        public void CreateValueVectorBlock(){} // RVA: 0x7FFE8813DA40 | overloaded x3
        public void StartValueVector(){} // RVA: 0x7FFE881385D0
        public void EndUdonUShortArray(){} // RVA: 0x7FFE8813DAD0
        public void UnPack(){} // RVA: 0x7FFE8813DB60
        public void UnPackTo(){} // RVA: 0x7FFE8813DC10
        public void Pack(){} // RVA: 0x7FFE8813DE40
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
        public void Verify(){} // RVA: 0x7FFE881389F0
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
        public 0x665F7104 _type; // 0x10
        public object _value; // 0x18

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFE811C55E0
        public void set_Type(){} // RVA: 0x7FFE811C55F0
        public void get_Value(){} // RVA: 0x7FFE810FE7C0
        public void set_Value(){} // RVA: 0x7FFE81161E80
        public void .ctor(){} // RVA: 0x7FFE8811CB20
        public void As(){} // RVA: 0x7FFE810A1420
        public void AsUdonShort(){} // RVA: 0x7FFE88131F00
        public void FromUdonShort(){} // RVA: 0x7FFE88131F40
        public void AsUdonUShort(){} // RVA: 0x7FFE88132040
        public void FromUdonUShort(){} // RVA: 0x7FFE88132080
        public void AsUdonChar(){} // RVA: 0x7FFE88132180
        public void FromUdonChar(){} // RVA: 0x7FFE881321C0
        public void AsUdonByte(){} // RVA: 0x7FFE881322C0
        public void FromUdonByte(){} // RVA: 0x7FFE88132300
        public void AsUdonUByte(){} // RVA: 0x7FFE88132400
        public void FromUdonUByte(){} // RVA: 0x7FFE88132440
        public void AsUdonLong(){} // RVA: 0x7FFE88132540
        public void FromUdonLong(){} // RVA: 0x7FFE88132580
        public void AsUdonULong(){} // RVA: 0x7FFE88132680
        public void FromUdonULong(){} // RVA: 0x7FFE881326C0
        public void AsUdonDouble(){} // RVA: 0x7FFE881327C0
        public void FromUdonDouble(){} // RVA: 0x7FFE88132800
        public void AsUdonBool(){} // RVA: 0x7FFE88132900
        public void FromUdonBool(){} // RVA: 0x7FFE88132940
        public void AsUdonFloat(){} // RVA: 0x7FFE88132A40
        public void FromUdonFloat(){} // RVA: 0x7FFE88132A80
        public void AsUdonInt(){} // RVA: 0x7FFE88132B80
        public void FromUdonInt(){} // RVA: 0x7FFE88132BC0
        public void AsUdonUInt(){} // RVA: 0x7FFE88132CC0
        public void FromUdonUInt(){} // RVA: 0x7FFE88132D00
        public void AsVector2(){} // RVA: 0x7FFE88132E00
        public void FromVector2(){} // RVA: 0x7FFE88132E40
        public void AsVector3(){} // RVA: 0x7FFE88132F40
        public void FromVector3(){} // RVA: 0x7FFE88132F80
        public void AsVector4(){} // RVA: 0x7FFE88133080
        public void FromVector4(){} // RVA: 0x7FFE881330C0
        public void AsQuaternion(){} // RVA: 0x7FFE881331C0
        public void FromQuaternion(){} // RVA: 0x7FFE88133200
        public void AsColor(){} // RVA: 0x7FFE88133300
        public void FromColor(){} // RVA: 0x7FFE88133340
        public void AsColor32(){} // RVA: 0x7FFE88133440
        public void FromColor32(){} // RVA: 0x7FFE88133480
        public void AsUdonShortArray(){} // RVA: 0x7FFE88133580
        public void FromUdonShortArray(){} // RVA: 0x7FFE881335C0
        public void AsUdonUShortArray(){} // RVA: 0x7FFE881336C0
        public void FromUdonUShortArray(){} // RVA: 0x7FFE88133700
        public void AsUdonCharArray(){} // RVA: 0x7FFE88133800
        public void FromUdonCharArray(){} // RVA: 0x7FFE88133840
        public void AsUdonByteArray(){} // RVA: 0x7FFE88133940
        public void FromUdonByteArray(){} // RVA: 0x7FFE88133980
        public void AsUdonUByteArray(){} // RVA: 0x7FFE88133A80
        public void FromUdonUByteArray(){} // RVA: 0x7FFE88133AC0
        public void AsUdonLongArray(){} // RVA: 0x7FFE88133BC0
        public void FromUdonLongArray(){} // RVA: 0x7FFE88133C00
        public void AsUdonULongArray(){} // RVA: 0x7FFE88133D00
        public void FromUdonULongArray(){} // RVA: 0x7FFE88133D40
        public void AsUdonDoubleArray(){} // RVA: 0x7FFE88133E40
        public void FromUdonDoubleArray(){} // RVA: 0x7FFE88133E80
        public void AsUdonBoolArray(){} // RVA: 0x7FFE88133F80
        public void FromUdonBoolArray(){} // RVA: 0x7FFE88133FC0
        public void AsUdonFloatArray(){} // RVA: 0x7FFE881340C0
        public void FromUdonFloatArray(){} // RVA: 0x7FFE88134100
        public void AsUdonIntArray(){} // RVA: 0x7FFE88134200
        public void FromUdonIntArray(){} // RVA: 0x7FFE88134240
        public void AsUdonUIntArray(){} // RVA: 0x7FFE88134340
        public void FromUdonUIntArray(){} // RVA: 0x7FFE88134380
        public void AsVector2Array(){} // RVA: 0x7FFE88134480
        public void FromVector2Array(){} // RVA: 0x7FFE881344C0
        public void AsVector3Array(){} // RVA: 0x7FFE881345C0
        public void FromVector3Array(){} // RVA: 0x7FFE88134600
        public void AsVector4Array(){} // RVA: 0x7FFE88134700
        public void FromVector4Array(){} // RVA: 0x7FFE88134740
        public void AsQuaternionArray(){} // RVA: 0x7FFE88134840
        public void FromQuaternionArray(){} // RVA: 0x7FFE88134880
        public void AsColorArray(){} // RVA: 0x7FFE88134980
        public void FromColorArray(){} // RVA: 0x7FFE881349C0
        public void AsColor32Array(){} // RVA: 0x7FFE88134AC0
        public void FromColor32Array(){} // RVA: 0x7FFE88134B00
        public void AsUdonString(){} // RVA: 0x7FFE88134C00
        public void FromUdonString(){} // RVA: 0x7FFE88134C40
        public void Pack(){} // RVA: 0x7FFE88134D40
    }

    public class UdonValueVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFE88135E40
    }

    public class UdonVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFE8811EB50
    }

}