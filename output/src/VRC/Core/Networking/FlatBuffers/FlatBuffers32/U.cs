// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers32
// Classes: 74
// Methods: 643

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers32
{
    public class Udon
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void ValidateVersion(){} // RVA: 0x2DD310
        public void GetRootAsUdon(){} // RVA: 0x7607450 | overloaded x2
        public void VerifyUdon(){} // RVA: 0x76381A0
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void DataType(){} // RVA: 0x760F670
        public void get_DataTypeLength(){} // RVA: 0x760F6F0
        public void GetDataTypeBytes(){} // RVA: 0x7638290
        public void GetDataTypeArray(){} // RVA: 0x7638300
        public void Data(){} // RVA: 0x283FA0
        public void get_DataLength(){} // RVA: 0x76103F0
        public void CreateUdon(){} // RVA: 0x7638430
        public void StartUdon(){} // RVA: 0x7610510
        public void AddDataType(){} // RVA: 0x760F330
        public void CreateDataTypeVector(){} // RVA: 0x760F8A0
        public void CreateDataTypeVectorBlock(){} // RVA: 0x7638690 | overloaded x3
        public void StartDataTypeVector(){} // RVA: 0x760FBF0
        public void AddData(){} // RVA: 0x76107A0
        public void CreateDataVector(){} // RVA: 0x7607E30
        public void CreateDataVectorBlock(){} // RVA: 0x76388F0 | overloaded x3
        public void StartDataVector(){} // RVA: 0x76081F0
        public void EndUdon(){} // RVA: 0x76389B0
        public void FinishUdonBuffer(){} // RVA: 0x7610A90
        public void FinishSizePrefixedUdonBuffer(){} // RVA: 0x7610AF0
        public void UnPack(){} // RVA: 0x7638A00
        public void UnPackTo(){} // RVA: 0x7638AB0
        public void Pack(){} // RVA: 0x763AA70
    }

    public class UdonBool
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void get_Value(){} // RVA: 0x760EB00
        public void CreateUdonBool(){} // RVA: 0x762D4A0
        public void UnPack(){} // RVA: 0x762D530
        public void UnPackTo(){} // RVA: 0x760EC30
        public void Pack(){} // RVA: 0x762D5A0
    }

    public class UdonBoolArray
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void ValidateVersion(){} // RVA: 0x2DD310
        public void GetRootAsUdonBoolArray(){} // RVA: 0x7607450 | overloaded x2
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void Value(){} // RVA: 0x762EF00
        public void get_ValueLength(){} // RVA: 0x760F6F0
        public void GetValueBytes(){} // RVA: 0x762EF80
        public void GetValueArray(){} // RVA: 0x762EFF0
        public void CreateUdonBoolArray(){} // RVA: 0x762F040
        public void StartUdonBoolArray(){} // RVA: 0x760F310
        public void AddValue(){} // RVA: 0x760F330
        public void CreateValueVector(){} // RVA: 0x762F0C0
        public void CreateValueVectorBlock(){} // RVA: 0x762F3F0 | overloaded x3
        public void StartValueVector(){} // RVA: 0x760FBF0
        public void EndUdonBoolArray(){} // RVA: 0x762F4B0
        public void UnPack(){} // RVA: 0x762F500
        public void UnPackTo(){} // RVA: 0x762F5B0
        public void Pack(){} // RVA: 0x762F7C0
    }

    public class UdonBoolArrayT
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0x2F8380
        public void set_Value(){} // RVA: 0x2DEE30
        public void .ctor(){} // RVA: 0x574FB20
    }

    public class UdonBoolArrayVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x76100F0
    }

    public class UdonBoolT
    {
        public object ByteBuffer;

        // ── Methods ──
        public void get_Value(){} // RVA: 0x3A75E0
        public void set_Value(){} // RVA: 0x3A75F0
        public void .ctor(){} // RVA: 0x6BDA00
    }

    public class UdonByte
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void get_Value(){} // RVA: 0x76180E0
        public void CreateUdonByte(){} // RVA: 0x762D6E0
        public void UnPack(){} // RVA: 0x762D770
        public void UnPackTo(){} // RVA: 0x7623B90
        public void Pack(){} // RVA: 0x762D7E0
    }

    public class UdonByteArray
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void ValidateVersion(){} // RVA: 0x2DD310
        public void GetRootAsUdonByteArray(){} // RVA: 0x7607450 | overloaded x2
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void Value(){} // RVA: 0x760F670
        public void get_ValueLength(){} // RVA: 0x760F6F0
        public void GetValueBytes(){} // RVA: 0x7630280
        public void GetValueArray(){} // RVA: 0x76302F0
        public void CreateUdonByteArray(){} // RVA: 0x7630340
        public void StartUdonByteArray(){} // RVA: 0x760F310
        public void AddValue(){} // RVA: 0x760F330
        public void CreateValueVector(){} // RVA: 0x760F8A0
        public void CreateValueVectorBlock(){} // RVA: 0x7630560 | overloaded x3
        public void StartValueVector(){} // RVA: 0x760FBF0
        public void EndUdonByteArray(){} // RVA: 0x7630620
        public void UnPack(){} // RVA: 0x7630670
        public void UnPackTo(){} // RVA: 0x7630720
        public void Pack(){} // RVA: 0x7630930
    }

    public class UdonByteArrayT
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0x2F8380
        public void set_Value(){} // RVA: 0x2DEE30
        public void .ctor(){} // RVA: 0x574FB20
    }

    public class UdonByteArrayVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x76100F0
    }

    public class UdonByteT
    {
        public object ByteBuffer;

        // ── Methods ──
        public void get_Value(){} // RVA: 0x3A75E0
        public void set_Value(){} // RVA: 0x3A75F0
        public void .ctor(){} // RVA: 0x6BDA00
    }

    public class UdonChar
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void get_Value(){} // RVA: 0x7622E10
        public void CreateUdonChar(){} // RVA: 0x762D5C0
        public void UnPack(){} // RVA: 0x762D650
        public void UnPackTo(){} // RVA: 0x7622F40
        public void Pack(){} // RVA: 0x762D6C0
    }

    public class UdonCharArray
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void ValidateVersion(){} // RVA: 0x2DD310
        public void GetRootAsUdonCharArray(){} // RVA: 0x7607450 | overloaded x2
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void Value(){} // RVA: 0x762F8B0
        public void get_ValueLength(){} // RVA: 0x760F6F0
        public void GetValueBytes(){} // RVA: 0x762F930
        public void GetValueArray(){} // RVA: 0x762F9A0
        public void CreateUdonCharArray(){} // RVA: 0x762F9F0
        public void StartUdonCharArray(){} // RVA: 0x760F310
        public void AddValue(){} // RVA: 0x760F330
        public void CreateValueVector(){} // RVA: 0x762FA70
        public void CreateValueVectorBlock(){} // RVA: 0x762FD00 | overloaded x3
        public void StartValueVector(){} // RVA: 0x762FDC0
        public void EndUdonCharArray(){} // RVA: 0x762FDF0
        public void UnPack(){} // RVA: 0x762FE40
        public void UnPackTo(){} // RVA: 0x762FEF0
        public void Pack(){} // RVA: 0x7630120
    }

    public class UdonCharArrayT
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0x2F8380
        public void set_Value(){} // RVA: 0x2DEE30
        public void .ctor(){} // RVA: 0x574FB20
    }

    public class UdonCharArrayVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7630210
    }

    public class UdonCharT
    {
        public object ByteBuffer;

        // ── Methods ──
        public void get_Value(){} // RVA: 0x1C0F720
        public void set_Value(){} // RVA: 0x1C0FA70
        public void .ctor(){} // RVA: 0x1D72E00
    }

    public class UdonDouble
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void get_Value(){} // RVA: 0x76236D0
        public void CreateUdonDouble(){} // RVA: 0x762DF70
        public void UnPack(){} // RVA: 0x762E000
        public void UnPackTo(){} // RVA: 0x7623810
        public void Pack(){} // RVA: 0x762E080
    }

    public class UdonDoubleArray
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void ValidateVersion(){} // RVA: 0x2DD310
        public void GetRootAsUdonDoubleArray(){} // RVA: 0x7607450 | overloaded x2
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void Value(){} // RVA: 0x7633D70
        public void get_ValueLength(){} // RVA: 0x760F6F0
        public void GetValueBytes(){} // RVA: 0x7633DF0
        public void GetValueArray(){} // RVA: 0x7633E60
        public void CreateUdonDoubleArray(){} // RVA: 0x7633EB0
        public void StartUdonDoubleArray(){} // RVA: 0x760F310
        public void AddValue(){} // RVA: 0x760F330
        public void CreateValueVector(){} // RVA: 0x7633F30
        public void CreateValueVectorBlock(){} // RVA: 0x7634250 | overloaded x3
        public void StartValueVector(){} // RVA: 0x7631780
        public void EndUdonDoubleArray(){} // RVA: 0x7634310
        public void UnPack(){} // RVA: 0x7634360
        public void UnPackTo(){} // RVA: 0x7634410
        public void Pack(){} // RVA: 0x7634620
    }

    public class UdonDoubleArrayT
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0x2F8380
        public void set_Value(){} // RVA: 0x2DEE30
        public void .ctor(){} // RVA: 0x574FB20
    }

    public class UdonDoubleArrayVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7631BC0
    }

    public class UdonDoubleT
    {
        public object ByteBuffer;

        // ── Methods ──
        public void get_Value(){} // RVA: 0x2EE1B30
        public void set_Value(){} // RVA: 0x40AB380
        public void .ctor(){} // RVA: 0x10621F0
    }

    public class UdonFloat
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void get_Value(){} // RVA: 0x760EF40
        public void CreateUdonFloat(){} // RVA: 0x762DDE0
        public void UnPack(){} // RVA: 0x762DE70
        public void UnPackTo(){} // RVA: 0x760F070
        public void Pack(){} // RVA: 0x762DEE0
    }

    public class UdonFloatArray
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void ValidateVersion(){} // RVA: 0x2DD310
        public void GetRootAsUdonFloatArray(){} // RVA: 0x7607450 | overloaded x2
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void Value(){} // RVA: 0x76333D0
        public void get_ValueLength(){} // RVA: 0x760F6F0
        public void GetValueBytes(){} // RVA: 0x7633450
        public void GetValueArray(){} // RVA: 0x76334C0
        public void CreateUdonFloatArray(){} // RVA: 0x7633510
        public void StartUdonFloatArray(){} // RVA: 0x760F310
        public void AddValue(){} // RVA: 0x760F330
        public void CreateValueVector(){} // RVA: 0x7633590
        public void CreateValueVectorBlock(){} // RVA: 0x76338B0 | overloaded x3
        public void StartValueVector(){} // RVA: 0x76081F0
        public void EndUdonFloatArray(){} // RVA: 0x7633970
        public void UnPack(){} // RVA: 0x76339C0
        public void UnPackTo(){} // RVA: 0x7633A70
        public void Pack(){} // RVA: 0x7633C80
    }

    public class UdonFloatArrayT
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0x2F8380
        public void set_Value(){} // RVA: 0x2DEE30
        public void .ctor(){} // RVA: 0x574FB20
    }

    public class UdonFloatArrayVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x761FDD0
    }

    public class UdonFloatT
    {
        public object ByteBuffer;

        // ── Methods ──
        public void get_Value(){} // RVA: 0x407320
        public void set_Value(){} // RVA: 0x407330
        public void .ctor(){} // RVA: 0xA5D070
    }

    public class UdonInfo
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void ValidateVersion(){} // RVA: 0x2DD310
        public void GetRootAsUdonInfo(){} // RVA: 0x7607450 | overloaded x2
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void Names(){} // RVA: 0x7612290
        public void get_NamesLength(){} // RVA: 0x760F6F0
        public void Types(){} // RVA: 0x7612360
        public void get_TypesLength(){} // RVA: 0x76103F0
        public void CreateUdonInfo(){} // RVA: 0x7612430
        public void StartUdonInfo(){} // RVA: 0x7610510
        public void AddNames(){} // RVA: 0x760F330
        public void CreateNamesVector(){} // RVA: 0x7607E30
        public void CreateNamesVectorBlock(){} // RVA: 0x7612680 | overloaded x3
        public void StartNamesVector(){} // RVA: 0x76081F0
        public void AddTypes(){} // RVA: 0x76107A0
        public void CreateTypesVector(){} // RVA: 0x7607E30
        public void CreateTypesVectorBlock(){} // RVA: 0x76128E0 | overloaded x3
        public void StartTypesVector(){} // RVA: 0x76081F0
        public void EndUdonInfo(){} // RVA: 0x76129A0
        public void UnPack(){} // RVA: 0x76129F0
        public void UnPackTo(){} // RVA: 0x7612A60
        public void Pack(){} // RVA: 0x7612D50
    }

    public class UdonInfoT
    {
        // ── Methods ──
        public void get_Names(){} // RVA: 0x2F8380
        public void set_Names(){} // RVA: 0x2DEE30
        public void get_Types(){} // RVA: 0x2E07C0
        public void set_Types(){} // RVA: 0x343E80
        public void .ctor(){} // RVA: 0x75EEF50
    }

    public class UdonInfoVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x76130D0
    }

    public class UdonInt
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void get_Value(){} // RVA: 0x760ED20
        public void CreateUdonInt(){} // RVA: 0x762D800
        public void UnPack(){} // RVA: 0x762D890
        public void UnPackTo(){} // RVA: 0x760EE50
        public void Pack(){} // RVA: 0x762D900
    }

    public class UdonIntArray
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void ValidateVersion(){} // RVA: 0x2DD310
        public void GetRootAsUdonIntArray(){} // RVA: 0x7607450 | overloaded x2
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void Value(){} // RVA: 0x761F5A0
        public void get_ValueLength(){} // RVA: 0x760F6F0
        public void GetValueBytes(){} // RVA: 0x7630A20
        public void GetValueArray(){} // RVA: 0x7630A90
        public void CreateUdonIntArray(){} // RVA: 0x7630AE0
        public void StartUdonIntArray(){} // RVA: 0x760F310
        public void AddValue(){} // RVA: 0x760F330
        public void CreateValueVector(){} // RVA: 0x7613770
        public void CreateValueVectorBlock(){} // RVA: 0x7630D00 | overloaded x3
        public void StartValueVector(){} // RVA: 0x76081F0
        public void EndUdonIntArray(){} // RVA: 0x7630DC0
        public void UnPack(){} // RVA: 0x7630E10
        public void UnPackTo(){} // RVA: 0x7630EC0
        public void Pack(){} // RVA: 0x76310E0
    }

    public class UdonIntArrayT
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0x2F8380
        public void set_Value(){} // RVA: 0x2DEE30
        public void .ctor(){} // RVA: 0x574FB20
    }

    public class UdonIntArrayVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x761FDD0
    }

    public class UdonIntT
    {
        public object ByteBuffer;

        // ── Methods ──
        public void get_Value(){} // RVA: 0x32A5C0
        public void set_Value(){} // RVA: 0x2E00C0
        public void .ctor(){} // RVA: 0xA5D070
    }

    public class UdonLong
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void get_Value(){} // RVA: 0x7617C30
        public void CreateUdonLong(){} // RVA: 0x762D920
        public void UnPack(){} // RVA: 0x762D9B0
        public void UnPackTo(){} // RVA: 0x762DA20
        public void Pack(){} // RVA: 0x762DA60
    }

    public class UdonLongArray
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void ValidateVersion(){} // RVA: 0x2DD310
        public void GetRootAsUdonLongArray(){} // RVA: 0x7607450 | overloaded x2
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void Value(){} // RVA: 0x76311D0
        public void get_ValueLength(){} // RVA: 0x760F6F0
        public void GetValueBytes(){} // RVA: 0x7631250
        public void GetValueArray(){} // RVA: 0x76312C0
        public void CreateUdonLongArray(){} // RVA: 0x7631310
        public void StartUdonLongArray(){} // RVA: 0x760F310
        public void AddValue(){} // RVA: 0x760F330
        public void CreateValueVector(){} // RVA: 0x7631390
        public void CreateValueVectorBlock(){} // RVA: 0x76316C0 | overloaded x3
        public void StartValueVector(){} // RVA: 0x7631780
        public void EndUdonLongArray(){} // RVA: 0x76317B0
        public void UnPack(){} // RVA: 0x7631800
        public void UnPackTo(){} // RVA: 0x76318B0
        public void Pack(){} // RVA: 0x7631AD0
    }

    public class UdonLongArrayT
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0x2F8380
        public void set_Value(){} // RVA: 0x2DEE30
        public void .ctor(){} // RVA: 0x574FB20
    }

    public class UdonLongArrayVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7631BC0
    }

    public class UdonLongT
    {
        public object ByteBuffer;

        // ── Methods ──
        public void get_Value(){} // RVA: 0x2F8380
        public void set_Value(){} // RVA: 0x1967700
        public void .ctor(){} // RVA: 0x10621F0
    }

    public class UdonShort
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void get_Value(){} // RVA: 0x7622E10
        public void CreateUdonShort(){} // RVA: 0x762E110
        public void UnPack(){} // RVA: 0x762E1A0
        public void UnPackTo(){} // RVA: 0x7622F40
        public void Pack(){} // RVA: 0x762E210
    }

    public class UdonShortArray
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void ValidateVersion(){} // RVA: 0x2DD310
        public void GetRootAsUdonShortArray(){} // RVA: 0x7607450 | overloaded x2
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void Value(){} // RVA: 0x762F8B0
        public void get_ValueLength(){} // RVA: 0x760F6F0
        public void GetValueBytes(){} // RVA: 0x7634710
        public void GetValueArray(){} // RVA: 0x7634780
        public void CreateUdonShortArray(){} // RVA: 0x76347D0
        public void StartUdonShortArray(){} // RVA: 0x760F310
        public void AddValue(){} // RVA: 0x760F330
        public void CreateValueVector(){} // RVA: 0x762FA70
        public void CreateValueVectorBlock(){} // RVA: 0x7634A90 | overloaded x3
        public void StartValueVector(){} // RVA: 0x762FDC0
        public void EndUdonShortArray(){} // RVA: 0x7634B50
        public void UnPack(){} // RVA: 0x7634BA0
        public void UnPackTo(){} // RVA: 0x7634C50
        public void Pack(){} // RVA: 0x7634E80
    }

    public class UdonShortArrayT
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0x2F8380
        public void set_Value(){} // RVA: 0x2DEE30
        public void .ctor(){} // RVA: 0x574FB20
    }

    public class UdonShortArrayVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7630210
    }

    public class UdonShortT
    {
        public object ByteBuffer;

        // ── Methods ──
        public void get_Value(){} // RVA: 0x1C0F720
        public void set_Value(){} // RVA: 0x1C0FA70
        public void .ctor(){} // RVA: 0x1D72E00
    }

    public class UdonString
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void ValidateVersion(){} // RVA: 0x2DD310
        public void GetRootAsUdonString(){} // RVA: 0x7607450 | overloaded x2
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void get_Value(){} // RVA: 0x760F140
        public void GetValueBytes(){} // RVA: 0x762E350
        public void GetValueArray(){} // RVA: 0x762E3C0
        public void CreateUdonString(){} // RVA: 0x762E410
        public void StartUdonString(){} // RVA: 0x760F310
        public void AddValue(){} // RVA: 0x760F330
        public void EndUdonString(){} // RVA: 0x762E490
        public void UnPack(){} // RVA: 0x762E4E0
        public void UnPackTo(){} // RVA: 0x760F4D0
        public void Pack(){} // RVA: 0x762E5F0
    }

    public class UdonStringArray
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void ValidateVersion(){} // RVA: 0x2DD310
        public void GetRootAsUdonStringArray(){} // RVA: 0x7607450 | overloaded x2
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void Value(){} // RVA: 0x7612290
        public void get_ValueLength(){} // RVA: 0x760F6F0
        public void CreateUdonStringArray(){} // RVA: 0x762E6B0
        public void StartUdonStringArray(){} // RVA: 0x760F310
        public void AddValue(){} // RVA: 0x760F330
        public void CreateValueVector(){} // RVA: 0x7607E30
        public void CreateValueVectorBlock(){} // RVA: 0x762E8D0 | overloaded x3
        public void StartValueVector(){} // RVA: 0x76081F0
        public void EndUdonStringArray(){} // RVA: 0x762E990
        public void UnPack(){} // RVA: 0x762E9E0
        public void UnPackTo(){} // RVA: 0x762EA90
        public void Pack(){} // RVA: 0x762EC50
    }

    public class UdonStringArrayT
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0x2F8380
        public void set_Value(){} // RVA: 0x2DEE30
        public void .ctor(){} // RVA: 0x574FB20
    }

    public class UdonStringArrayVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x762EE90
    }

    public class UdonStringT
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0x2F8380
        public void set_Value(){} // RVA: 0x2DEE30
        public void .ctor(){} // RVA: 0x574FB20
    }

    public class UdonStringVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x760F600
    }

    public class UdonT
    {
        // ── Methods ──
        public void get_Data(){} // RVA: 0x2F8380
        public void set_Data(){} // RVA: 0x2DEE30
        public void .ctor(){} // RVA: 0x574FB20
        public void DeserializeFromBinary(){} // RVA: 0x763AE20
        public void SerializeToBinary(){} // RVA: 0x763AED0
    }

    public class UdonUByte
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void get_Value(){} // RVA: 0x76180E0
        public void CreateUdonUByte(){} // RVA: 0x762DA80
        public void UnPack(){} // RVA: 0x762DB10
        public void UnPackTo(){} // RVA: 0x7623B90
        public void Pack(){} // RVA: 0x762DB80
    }

    public class UdonUByteArray
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void ValidateVersion(){} // RVA: 0x2DD310
        public void GetRootAsUdonUByteArray(){} // RVA: 0x7607450 | overloaded x2
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void Value(){} // RVA: 0x760F670
        public void get_ValueLength(){} // RVA: 0x760F6F0
        public void GetValueBytes(){} // RVA: 0x7631C30
        public void GetValueArray(){} // RVA: 0x7631CA0
        public void CreateUdonUByteArray(){} // RVA: 0x7631CF0
        public void StartUdonUByteArray(){} // RVA: 0x760F310
        public void AddValue(){} // RVA: 0x760F330
        public void CreateValueVector(){} // RVA: 0x760F8A0
        public void CreateValueVectorBlock(){} // RVA: 0x7631F10 | overloaded x3
        public void StartValueVector(){} // RVA: 0x760FBF0
        public void EndUdonUByteArray(){} // RVA: 0x7631FD0
        public void UnPack(){} // RVA: 0x7632020
        public void UnPackTo(){} // RVA: 0x76320D0
        public void Pack(){} // RVA: 0x76322E0
    }

    public class UdonUByteArrayT
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0x2F8380
        public void set_Value(){} // RVA: 0x2DEE30
        public void .ctor(){} // RVA: 0x574FB20
    }

    public class UdonUByteArrayVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x76100F0
    }

    public class UdonUByteT
    {
        public object ByteBuffer;

        // ── Methods ──
        public void get_Value(){} // RVA: 0x3A75E0
        public void set_Value(){} // RVA: 0x3A75F0
        public void .ctor(){} // RVA: 0x6BDA00
    }

    public class UdonUInt
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void get_Value(){} // RVA: 0x760ED20
        public void CreateUdonUInt(){} // RVA: 0x762DBA0
        public void UnPack(){} // RVA: 0x762DC30
        public void UnPackTo(){} // RVA: 0x760EE50
        public void Pack(){} // RVA: 0x762DCA0
    }

    public class UdonUIntArray
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void ValidateVersion(){} // RVA: 0x2DD310
        public void GetRootAsUdonUIntArray(){} // RVA: 0x7607450 | overloaded x2
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void Value(){} // RVA: 0x761F5A0
        public void get_ValueLength(){} // RVA: 0x760F6F0
        public void GetValueBytes(){} // RVA: 0x76323D0
        public void GetValueArray(){} // RVA: 0x7632440
        public void CreateUdonUIntArray(){} // RVA: 0x7632490
        public void StartUdonUIntArray(){} // RVA: 0x760F310
        public void AddValue(){} // RVA: 0x760F330
        public void CreateValueVector(){} // RVA: 0x7613770
        public void CreateValueVectorBlock(){} // RVA: 0x76326B0 | overloaded x3
        public void StartValueVector(){} // RVA: 0x76081F0
        public void EndUdonUIntArray(){} // RVA: 0x7632770
        public void UnPack(){} // RVA: 0x76327C0
        public void UnPackTo(){} // RVA: 0x7632870
        public void Pack(){} // RVA: 0x7632A90
    }

    public class UdonUIntArrayT
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0x2F8380
        public void set_Value(){} // RVA: 0x2DEE30
        public void .ctor(){} // RVA: 0x574FB20
    }

    public class UdonUIntArrayVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x761FDD0
    }

    public class UdonUIntT
    {
        public object ByteBuffer;

        // ── Methods ──
        public void get_Value(){} // RVA: 0x32A5C0
        public void set_Value(){} // RVA: 0x2E00C0
        public void .ctor(){} // RVA: 0xA5D070
    }

    public class UdonULong
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void get_Value(){} // RVA: 0x7617C30
        public void CreateUdonULong(){} // RVA: 0x762DCC0
        public void UnPack(){} // RVA: 0x762DD50
        public void UnPackTo(){} // RVA: 0x762DA20
        public void Pack(){} // RVA: 0x762DDC0
    }

    public class UdonULongArray
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void ValidateVersion(){} // RVA: 0x2DD310
        public void GetRootAsUdonULongArray(){} // RVA: 0x7607450 | overloaded x2
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void Value(){} // RVA: 0x76311D0
        public void get_ValueLength(){} // RVA: 0x760F6F0
        public void GetValueBytes(){} // RVA: 0x7632B80
        public void GetValueArray(){} // RVA: 0x7632BF0
        public void CreateUdonULongArray(){} // RVA: 0x7632C40
        public void StartUdonULongArray(){} // RVA: 0x760F310
        public void AddValue(){} // RVA: 0x760F330
        public void CreateValueVector(){} // RVA: 0x7631390
        public void CreateValueVectorBlock(){} // RVA: 0x7632F00 | overloaded x3
        public void StartValueVector(){} // RVA: 0x7631780
        public void EndUdonULongArray(){} // RVA: 0x7632FC0
        public void UnPack(){} // RVA: 0x7633010
        public void UnPackTo(){} // RVA: 0x76330C0
        public void Pack(){} // RVA: 0x76332E0
    }

    public class UdonULongArrayT
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0x2F8380
        public void set_Value(){} // RVA: 0x2DEE30
        public void .ctor(){} // RVA: 0x574FB20
    }

    public class UdonULongArrayVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7631BC0
    }

    public class UdonULongT
    {
        public object ByteBuffer;

        // ── Methods ──
        public void get_Value(){} // RVA: 0x2F8380
        public void set_Value(){} // RVA: 0x1967700
        public void .ctor(){} // RVA: 0x10621F0
    }

    public class UdonUShort
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void get_Value(){} // RVA: 0x7622E10
        public void CreateUdonUShort(){} // RVA: 0x762E230
        public void UnPack(){} // RVA: 0x762E2C0
        public void UnPackTo(){} // RVA: 0x7622F40
        public void Pack(){} // RVA: 0x762E330
    }

    public class UdonUShortArray
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void ValidateVersion(){} // RVA: 0x2DD310
        public void GetRootAsUdonUShortArray(){} // RVA: 0x7607450 | overloaded x2
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void Value(){} // RVA: 0x762F8B0
        public void get_ValueLength(){} // RVA: 0x760F6F0
        public void GetValueBytes(){} // RVA: 0x7634F70
        public void GetValueArray(){} // RVA: 0x7634FE0
        public void CreateUdonUShortArray(){} // RVA: 0x7635030
        public void StartUdonUShortArray(){} // RVA: 0x760F310
        public void AddValue(){} // RVA: 0x760F330
        public void CreateValueVector(){} // RVA: 0x762FA70
        public void CreateValueVectorBlock(){} // RVA: 0x7635250 | overloaded x3
        public void StartValueVector(){} // RVA: 0x762FDC0
        public void EndUdonUShortArray(){} // RVA: 0x7635310
        public void UnPack(){} // RVA: 0x7635360
        public void UnPackTo(){} // RVA: 0x7635410
        public void Pack(){} // RVA: 0x7635640
    }

    public class UdonUShortArrayT
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0x2F8380
        public void set_Value(){} // RVA: 0x2DEE30
        public void .ctor(){} // RVA: 0x574FB20
    }

    public class UdonUShortArrayVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7630210
    }

    public class UdonUShortT
    {
        public object ByteBuffer;

        // ── Methods ──
        public void get_Value(){} // RVA: 0x1C0F720
        public void set_Value(){} // RVA: 0x1C0FA70
        public void .ctor(){} // RVA: 0x1D72E00
    }

    public class UdonValueUnion
    {
        public object Type;
        public object Value;

        // ── Methods ──
        public void get_Type(){} // RVA: 0x3A75E0
        public void set_Type(){} // RVA: 0x3A75F0
        public void get_Value(){} // RVA: 0x2E07C0
        public void set_Value(){} // RVA: 0x343E80
        public void .ctor(){} // RVA: 0x75DFAD0
        public void As(){} // RVA: 0x283FA0
        public void AsUdonShort(){} // RVA: 0x7628E10
        public void FromUdonShort(){} // RVA: 0x7628E50
        public void AsUdonUShort(){} // RVA: 0x7628F50
        public void FromUdonUShort(){} // RVA: 0x7628F90
        public void AsUdonChar(){} // RVA: 0x7629090
        public void FromUdonChar(){} // RVA: 0x76290D0
        public void AsUdonByte(){} // RVA: 0x76291D0
        public void FromUdonByte(){} // RVA: 0x7629210
        public void AsUdonUByte(){} // RVA: 0x7629310
        public void FromUdonUByte(){} // RVA: 0x7629350
        public void AsUdonLong(){} // RVA: 0x7629450
        public void FromUdonLong(){} // RVA: 0x7629490
        public void AsUdonULong(){} // RVA: 0x7629590
        public void FromUdonULong(){} // RVA: 0x76295D0
        public void AsUdonDouble(){} // RVA: 0x76296D0
        public void FromUdonDouble(){} // RVA: 0x7629710
        public void AsUdonBool(){} // RVA: 0x7629810
        public void FromUdonBool(){} // RVA: 0x7629850
        public void AsUdonFloat(){} // RVA: 0x7629950
        public void FromUdonFloat(){} // RVA: 0x7629990
        public void AsUdonInt(){} // RVA: 0x7629A90
        public void FromUdonInt(){} // RVA: 0x7629AD0
        public void AsUdonUInt(){} // RVA: 0x7629BD0
        public void FromUdonUInt(){} // RVA: 0x7629C10
        public void AsVector2(){} // RVA: 0x7629D10
        public void FromVector2(){} // RVA: 0x7629D50
        public void AsVector3(){} // RVA: 0x7629E50
        public void FromVector3(){} // RVA: 0x7629E90
        public void AsVector4(){} // RVA: 0x7629F90
        public void FromVector4(){} // RVA: 0x7629FD0
        public void AsQuaternion(){} // RVA: 0x762A0D0
        public void FromQuaternion(){} // RVA: 0x762A110
        public void AsColor(){} // RVA: 0x762A210
        public void FromColor(){} // RVA: 0x762A250
        public void AsColor32(){} // RVA: 0x762A350
        public void FromColor32(){} // RVA: 0x762A390
        public void AsUdonShortArray(){} // RVA: 0x762A490
        public void FromUdonShortArray(){} // RVA: 0x762A4D0
        public void AsUdonUShortArray(){} // RVA: 0x762A5D0
        public void FromUdonUShortArray(){} // RVA: 0x762A610
        public void AsUdonCharArray(){} // RVA: 0x762A710
        public void FromUdonCharArray(){} // RVA: 0x762A750
        public void AsUdonByteArray(){} // RVA: 0x762A850
        public void FromUdonByteArray(){} // RVA: 0x762A890
        public void AsUdonUByteArray(){} // RVA: 0x762A990
        public void FromUdonUByteArray(){} // RVA: 0x762A9D0
        public void AsUdonLongArray(){} // RVA: 0x762AAD0
        public void FromUdonLongArray(){} // RVA: 0x762AB10
        public void AsUdonULongArray(){} // RVA: 0x762AC10
        public void FromUdonULongArray(){} // RVA: 0x762AC50
        public void AsUdonDoubleArray(){} // RVA: 0x762AD50
        public void FromUdonDoubleArray(){} // RVA: 0x762AD90
        public void AsUdonBoolArray(){} // RVA: 0x762AE90
        public void FromUdonBoolArray(){} // RVA: 0x762AED0
        public void AsUdonFloatArray(){} // RVA: 0x762AFD0
        public void FromUdonFloatArray(){} // RVA: 0x762B010
        public void AsUdonIntArray(){} // RVA: 0x762B110
        public void FromUdonIntArray(){} // RVA: 0x762B150
        public void AsUdonUIntArray(){} // RVA: 0x762B250
        public void FromUdonUIntArray(){} // RVA: 0x762B290
        public void AsVector2Array(){} // RVA: 0x762B390
        public void FromVector2Array(){} // RVA: 0x762B3D0
        public void AsVector3Array(){} // RVA: 0x762B4D0
        public void FromVector3Array(){} // RVA: 0x762B510
        public void AsVector4Array(){} // RVA: 0x762B610
        public void FromVector4Array(){} // RVA: 0x762B650
        public void AsQuaternionArray(){} // RVA: 0x762B750
        public void FromQuaternionArray(){} // RVA: 0x762B790
        public void AsColorArray(){} // RVA: 0x762B890
        public void FromColorArray(){} // RVA: 0x762B8D0
        public void AsColor32Array(){} // RVA: 0x762B9D0
        public void FromColor32Array(){} // RVA: 0x762BA10
        public void AsUdonString(){} // RVA: 0x762BB10
        public void FromUdonString(){} // RVA: 0x762BB50
        public void Pack(){} // RVA: 0x762BC50
    }

    public class UdonValueVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x762D080
    }

    public class UdonVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x76100F0
    }

}