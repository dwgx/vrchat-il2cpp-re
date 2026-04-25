// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers32
// Classes: 74
// Methods: 667

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers32
{
    public class Udon : ValueType
    {
        public Google.FlatBuffers32.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsUdon(){} // RVA: 0x7FFAC9D9CB90 | overloaded x2
        public void VerifyUdon(){} // RVA: 0x7FFAC9DCFB40
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void DataType(){} // RVA: 0x7FFAC9DA64D0
        public void get_DataTypeLength(){} // RVA: 0x7FFAC9DA6550
        public void GetDataTypeBytes(){} // RVA: 0x7FFAC9DCFC30
        public void GetDataTypeArray(){} // RVA: 0x7FFAC9DCFCA0
        public void Data(){} // RVA: 0x7FFAC2E8DC40
        public void get_DataLength(){} // RVA: 0x7FFAC9DA72E0
        public void CreateUdon(){} // RVA: 0x7FFAC9DCFDD0
        public void StartUdon(){} // RVA: 0x7FFAC9DA7400
        public void AddDataType(){} // RVA: 0x7FFAC9DA6190
        public void CreateDataTypeVector(){} // RVA: 0x7FFAC9DA6790
        public void CreateDataTypeVectorBlock(){} // RVA: 0x7FFAC9DD0030 | overloaded x3
        public void StartDataTypeVector(){} // RVA: 0x7FFAC9DA6AE0
        public void AddData(){} // RVA: 0x7FFAC9DA7690
        public void CreateDataVector(){} // RVA: 0x7FFAC9D9D690
        public void CreateDataVectorBlock(){} // RVA: 0x7FFAC9DD0290 | overloaded x3
        public void StartDataVector(){} // RVA: 0x7FFAC9D9DA50
        public void EndUdon(){} // RVA: 0x7FFAC9DD0350
        public void FinishUdonBuffer(){} // RVA: 0x7FFAC9DA7980
        public void FinishSizePrefixedUdonBuffer(){} // RVA: 0x7FFAC9DA79E0
        public void UnPack(){} // RVA: 0x7FFAC9DD03A0
        public void UnPackTo(){} // RVA: 0x7FFAC9DD0450
        public void Pack(){} // RVA: 0x7FFAC9DD2410
    }

    public class UdonBool : ValueType
    {
        public Google.FlatBuffers32.Struct ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_Value(){} // RVA: 0x7FFAC9DA58B0
        public void MutateValue(){} // RVA: 0x7FFAC9DA58E0
        public void CreateUdonBool(){} // RVA: 0x7FFAC9DC4C30
        public void UnPack(){} // RVA: 0x7FFAC9DC4CC0
        public void UnPackTo(){} // RVA: 0x7FFAC9DA5A10
        public void Pack(){} // RVA: 0x7FFAC9DC4D30
    }

    public class UdonBoolArray : ValueType
    {
        public Google.FlatBuffers32.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsUdonBoolArray(){} // RVA: 0x7FFAC9D9CB90 | overloaded x2
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void Value(){} // RVA: 0x7FFAC9DC65B0
        public void get_ValueLength(){} // RVA: 0x7FFAC9DA6550
        public void GetValueBytes(){} // RVA: 0x7FFAC9DC6630
        public void GetValueArray(){} // RVA: 0x7FFAC9DC66A0
        public void MutateValue(){} // RVA: 0x7FFAC9DC66F0
        public void CreateUdonBoolArray(){} // RVA: 0x7FFAC9DC6780
        public void StartUdonBoolArray(){} // RVA: 0x7FFAC9DA6170
        public void AddValue(){} // RVA: 0x7FFAC9DA6190
        public void CreateValueVector(){} // RVA: 0x7FFAC9DC6800
        public void CreateValueVectorBlock(){} // RVA: 0x7FFAC9DC6B30 | overloaded x3
        public void StartValueVector(){} // RVA: 0x7FFAC9DA6AE0
        public void EndUdonBoolArray(){} // RVA: 0x7FFAC9DC6BF0
        public void UnPack(){} // RVA: 0x7FFAC9DC6C40
        public void UnPackTo(){} // RVA: 0x7FFAC9DC6CF0
        public void Pack(){} // RVA: 0x7FFAC9DC6F00
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
        public void Verify(){} // RVA: 0x7FFAC9DA6FE0
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
        public Google.FlatBuffers32.Struct ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_Value(){} // RVA: 0x7FFAC9DAF330
        public void MutateValue(){} // RVA: 0x7FFAC9DA58E0
        public void CreateUdonByte(){} // RVA: 0x7FFAC9DC4E70
        public void UnPack(){} // RVA: 0x7FFAC9DC4F00
        public void UnPackTo(){} // RVA: 0x7FFAC9DBAFF0
        public void Pack(){} // RVA: 0x7FFAC9DC4F70
    }

    public class UdonByteArray : ValueType
    {
        public Google.FlatBuffers32.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsUdonByteArray(){} // RVA: 0x7FFAC9D9CB90 | overloaded x2
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void Value(){} // RVA: 0x7FFAC9DA64D0
        public void get_ValueLength(){} // RVA: 0x7FFAC9DA6550
        public void GetValueBytes(){} // RVA: 0x7FFAC9DC7A50
        public void GetValueArray(){} // RVA: 0x7FFAC9DC7AC0
        public void MutateValue(){} // RVA: 0x7FFAC9DA6680
        public void CreateUdonByteArray(){} // RVA: 0x7FFAC9DC7B10
        public void StartUdonByteArray(){} // RVA: 0x7FFAC9DA6170
        public void AddValue(){} // RVA: 0x7FFAC9DA6190
        public void CreateValueVector(){} // RVA: 0x7FFAC9DA6790
        public void CreateValueVectorBlock(){} // RVA: 0x7FFAC9DC7D30 | overloaded x3
        public void StartValueVector(){} // RVA: 0x7FFAC9DA6AE0
        public void EndUdonByteArray(){} // RVA: 0x7FFAC9DC7DF0
        public void UnPack(){} // RVA: 0x7FFAC9DC7E40
        public void UnPackTo(){} // RVA: 0x7FFAC9DC7EF0
        public void Pack(){} // RVA: 0x7FFAC9DC8100
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
        public void Verify(){} // RVA: 0x7FFAC9DA6FE0
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
        public Google.FlatBuffers32.Struct ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_Value(){} // RVA: 0x7FFAC9DBA1D0
        public void MutateValue(){} // RVA: 0x7FFAC9DBA200
        public void CreateUdonChar(){} // RVA: 0x7FFAC9DC4D50
        public void UnPack(){} // RVA: 0x7FFAC9DC4DE0
        public void UnPackTo(){} // RVA: 0x7FFAC9DBA330
        public void Pack(){} // RVA: 0x7FFAC9DC4E50
    }

    public class UdonCharArray : ValueType
    {
        public Google.FlatBuffers32.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsUdonCharArray(){} // RVA: 0x7FFAC9D9CB90 | overloaded x2
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void Value(){} // RVA: 0x7FFAC9DC6FF0
        public void get_ValueLength(){} // RVA: 0x7FFAC9DA6550
        public void GetValueBytes(){} // RVA: 0x7FFAC9DC7070
        public void GetValueArray(){} // RVA: 0x7FFAC9DC70E0
        public void MutateValue(){} // RVA: 0x7FFAC9DC7130
        public void CreateUdonCharArray(){} // RVA: 0x7FFAC9DC71C0
        public void StartUdonCharArray(){} // RVA: 0x7FFAC9DA6170
        public void AddValue(){} // RVA: 0x7FFAC9DA6190
        public void CreateValueVector(){} // RVA: 0x7FFAC9DC7240
        public void CreateValueVectorBlock(){} // RVA: 0x7FFAC9DC74D0 | overloaded x3
        public void StartValueVector(){} // RVA: 0x7FFAC9DC7590
        public void EndUdonCharArray(){} // RVA: 0x7FFAC9DC75C0
        public void UnPack(){} // RVA: 0x7FFAC9DC7610
        public void UnPackTo(){} // RVA: 0x7FFAC9DC76C0
        public void Pack(){} // RVA: 0x7FFAC9DC78F0
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
        public void Verify(){} // RVA: 0x7FFAC9DC79E0
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
        public Google.FlatBuffers32.Struct ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_Value(){} // RVA: 0x7FFAC9DBAAE0
        public void MutateValue(){} // RVA: 0x7FFAC9DBAB10
        public void CreateUdonDouble(){} // RVA: 0x7FFAC9DC5690
        public void UnPack(){} // RVA: 0x7FFAC9DC5720
        public void UnPackTo(){} // RVA: 0x7FFAC9DBAC50
        public void Pack(){} // RVA: 0x7FFAC9DC57A0
    }

    public class UdonDoubleArray : ValueType
    {
        public Google.FlatBuffers32.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsUdonDoubleArray(){} // RVA: 0x7FFAC9D9CB90 | overloaded x2
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void Value(){} // RVA: 0x7FFAC9DCB670
        public void get_ValueLength(){} // RVA: 0x7FFAC9DA6550
        public void GetValueBytes(){} // RVA: 0x7FFAC9DCB6F0
        public void GetValueArray(){} // RVA: 0x7FFAC9DCB760
        public void MutateValue(){} // RVA: 0x7FFAC9DCB7B0
        public void CreateUdonDoubleArray(){} // RVA: 0x7FFAC9DCB840
        public void StartUdonDoubleArray(){} // RVA: 0x7FFAC9DA6170
        public void AddValue(){} // RVA: 0x7FFAC9DA6190
        public void CreateValueVector(){} // RVA: 0x7FFAC9DCB8C0
        public void CreateValueVectorBlock(){} // RVA: 0x7FFAC9DCBBF0 | overloaded x3
        public void StartValueVector(){} // RVA: 0x7FFAC9DC8FE0
        public void EndUdonDoubleArray(){} // RVA: 0x7FFAC9DCBCB0
        public void UnPack(){} // RVA: 0x7FFAC9DCBD00
        public void UnPackTo(){} // RVA: 0x7FFAC9DCBDB0
        public void Pack(){} // RVA: 0x7FFAC9DCBFC0
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
        public void Verify(){} // RVA: 0x7FFAC9DC9420
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
        public Google.FlatBuffers32.Struct ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_Value(){} // RVA: 0x7FFAC9DA5D50
        public void MutateValue(){} // RVA: 0x7FFAC9DA5D80
        public void CreateUdonFloat(){} // RVA: 0x7FFAC9DC5570
        public void UnPack(){} // RVA: 0x7FFAC9DC5600
        public void UnPackTo(){} // RVA: 0x7FFAC9DA5EB0
        public void Pack(){} // RVA: 0x7FFAC9DC5670
    }

    public class UdonFloatArray : ValueType
    {
        public Google.FlatBuffers32.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsUdonFloatArray(){} // RVA: 0x7FFAC9D9CB90 | overloaded x2
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void Value(){} // RVA: 0x7FFAC9DCAC30
        public void get_ValueLength(){} // RVA: 0x7FFAC9DA6550
        public void GetValueBytes(){} // RVA: 0x7FFAC9DCACB0
        public void GetValueArray(){} // RVA: 0x7FFAC9DCAD20
        public void MutateValue(){} // RVA: 0x7FFAC9DCAD70
        public void CreateUdonFloatArray(){} // RVA: 0x7FFAC9DCAE00
        public void StartUdonFloatArray(){} // RVA: 0x7FFAC9DA6170
        public void AddValue(){} // RVA: 0x7FFAC9DA6190
        public void CreateValueVector(){} // RVA: 0x7FFAC9DCAE80
        public void CreateValueVectorBlock(){} // RVA: 0x7FFAC9DCB1B0 | overloaded x3
        public void StartValueVector(){} // RVA: 0x7FFAC9D9DA50
        public void EndUdonFloatArray(){} // RVA: 0x7FFAC9DCB270
        public void UnPack(){} // RVA: 0x7FFAC9DCB2C0
        public void UnPackTo(){} // RVA: 0x7FFAC9DCB370
        public void Pack(){} // RVA: 0x7FFAC9DCB580
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
        public void Verify(){} // RVA: 0x7FFAC9DB7130
    }

    public class UdonFloatT : Object
    {
        public float Value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAC304B320
        public void set_Value(){} // RVA: 0x7FFAC304B330
        public void .ctor(){} // RVA: 0x7FFAC369FBB0
    }

    public class UdonInfo : ValueType
    {
        public Google.FlatBuffers32.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsUdonInfo(){} // RVA: 0x7FFAC9D9CB90 | overloaded x2
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void Names(){} // RVA: 0x7FFAC9DA9180
        public void get_NamesLength(){} // RVA: 0x7FFAC9DA6550
        public void Types(){} // RVA: 0x7FFAC9DA9250
        public void get_TypesLength(){} // RVA: 0x7FFAC9DA72E0
        public void CreateUdonInfo(){} // RVA: 0x7FFAC9DA9320
        public void StartUdonInfo(){} // RVA: 0x7FFAC9DA7400
        public void AddNames(){} // RVA: 0x7FFAC9DA6190
        public void CreateNamesVector(){} // RVA: 0x7FFAC9D9D690
        public void CreateNamesVectorBlock(){} // RVA: 0x7FFAC9DA9570 | overloaded x3
        public void StartNamesVector(){} // RVA: 0x7FFAC9D9DA50
        public void AddTypes(){} // RVA: 0x7FFAC9DA7690
        public void CreateTypesVector(){} // RVA: 0x7FFAC9D9D690
        public void CreateTypesVectorBlock(){} // RVA: 0x7FFAC9DA97D0 | overloaded x3
        public void StartTypesVector(){} // RVA: 0x7FFAC9D9DA50
        public void EndUdonInfo(){} // RVA: 0x7FFAC9DA9890
        public void UnPack(){} // RVA: 0x7FFAC9DA98E0
        public void UnPackTo(){} // RVA: 0x7FFAC9DA9950
        public void Pack(){} // RVA: 0x7FFAC9DA9C40
    }

    public class UdonInfoT : Object
    {
        public System.Collections.Generic.List`1<string> Names; // 0x10
        public System.Collections.Generic.List`1<string> Types; // 0x18

        // ── Methods ──
        public void get_Names(){} // RVA: 0x7FFAC2F3C380
        public void set_Names(){} // RVA: 0x7FFAC2F22E30
        public void get_Types(){} // RVA: 0x7FFAC2F247C0
        public void set_Types(){} // RVA: 0x7FFAC2F87E80
        public void .ctor(){} // RVA: 0x7FFAC9D84070
    }

    public class UdonInfoVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAC9DA9FC0
    }

    public class UdonInt : ValueType
    {
        public Google.FlatBuffers32.Struct ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_Value(){} // RVA: 0x7FFAC9DA5B00
        public void MutateValue(){} // RVA: 0x7FFAC9DA5B30
        public void CreateUdonInt(){} // RVA: 0x7FFAC9DC4F90
        public void UnPack(){} // RVA: 0x7FFAC9DC5020
        public void UnPackTo(){} // RVA: 0x7FFAC9DA5C60
        public void Pack(){} // RVA: 0x7FFAC9DC5090
    }

    public class UdonIntArray : ValueType
    {
        public Google.FlatBuffers32.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsUdonIntArray(){} // RVA: 0x7FFAC9D9CB90 | overloaded x2
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void Value(){} // RVA: 0x7FFAC9DB6870
        public void get_ValueLength(){} // RVA: 0x7FFAC9DA6550
        public void GetValueBytes(){} // RVA: 0x7FFAC9DC81F0
        public void GetValueArray(){} // RVA: 0x7FFAC9DC8260
        public void MutateValue(){} // RVA: 0x7FFAC9DB69B0
        public void CreateUdonIntArray(){} // RVA: 0x7FFAC9DC82B0
        public void StartUdonIntArray(){} // RVA: 0x7FFAC9DA6170
        public void AddValue(){} // RVA: 0x7FFAC9DA6190
        public void CreateValueVector(){} // RVA: 0x7FFAC9DAA810
        public void CreateValueVectorBlock(){} // RVA: 0x7FFAC9DC84D0 | overloaded x3
        public void StartValueVector(){} // RVA: 0x7FFAC9D9DA50
        public void EndUdonIntArray(){} // RVA: 0x7FFAC9DC8590
        public void UnPack(){} // RVA: 0x7FFAC9DC85E0
        public void UnPackTo(){} // RVA: 0x7FFAC9DC8690
        public void Pack(){} // RVA: 0x7FFAC9DC88B0
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
        public void Verify(){} // RVA: 0x7FFAC9DB7130
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
        public Google.FlatBuffers32.Struct ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_Value(){} // RVA: 0x7FFAC9DAEDC0
        public void MutateValue(){} // RVA: 0x7FFAC9DAEDF0
        public void CreateUdonLong(){} // RVA: 0x7FFAC9DC50B0
        public void UnPack(){} // RVA: 0x7FFAC9DC5140
        public void UnPackTo(){} // RVA: 0x7FFAC9DC51B0
        public void Pack(){} // RVA: 0x7FFAC9DC51F0
    }

    public class UdonLongArray : ValueType
    {
        public Google.FlatBuffers32.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsUdonLongArray(){} // RVA: 0x7FFAC9D9CB90 | overloaded x2
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void Value(){} // RVA: 0x7FFAC9DC89A0
        public void get_ValueLength(){} // RVA: 0x7FFAC9DA6550
        public void GetValueBytes(){} // RVA: 0x7FFAC9DC8A20
        public void GetValueArray(){} // RVA: 0x7FFAC9DC8A90
        public void MutateValue(){} // RVA: 0x7FFAC9DC8AE0
        public void CreateUdonLongArray(){} // RVA: 0x7FFAC9DC8B70
        public void StartUdonLongArray(){} // RVA: 0x7FFAC9DA6170
        public void AddValue(){} // RVA: 0x7FFAC9DA6190
        public void CreateValueVector(){} // RVA: 0x7FFAC9DC8BF0
        public void CreateValueVectorBlock(){} // RVA: 0x7FFAC9DC8F20 | overloaded x3
        public void StartValueVector(){} // RVA: 0x7FFAC9DC8FE0
        public void EndUdonLongArray(){} // RVA: 0x7FFAC9DC9010
        public void UnPack(){} // RVA: 0x7FFAC9DC9060
        public void UnPackTo(){} // RVA: 0x7FFAC9DC9110
        public void Pack(){} // RVA: 0x7FFAC9DC9330
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
        public void Verify(){} // RVA: 0x7FFAC9DC9420
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
        public Google.FlatBuffers32.Struct ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_Value(){} // RVA: 0x7FFAC9DBA1D0
        public void MutateValue(){} // RVA: 0x7FFAC9DBA200
        public void CreateUdonShort(){} // RVA: 0x7FFAC9DC57C0
        public void UnPack(){} // RVA: 0x7FFAC9DC5850
        public void UnPackTo(){} // RVA: 0x7FFAC9DBA330
        public void Pack(){} // RVA: 0x7FFAC9DC58C0
    }

    public class UdonShortArray : ValueType
    {
        public Google.FlatBuffers32.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsUdonShortArray(){} // RVA: 0x7FFAC9D9CB90 | overloaded x2
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void Value(){} // RVA: 0x7FFAC9DC6FF0
        public void get_ValueLength(){} // RVA: 0x7FFAC9DA6550
        public void GetValueBytes(){} // RVA: 0x7FFAC9DCC0B0
        public void GetValueArray(){} // RVA: 0x7FFAC9DCC120
        public void MutateValue(){} // RVA: 0x7FFAC9DC7130
        public void CreateUdonShortArray(){} // RVA: 0x7FFAC9DCC170
        public void StartUdonShortArray(){} // RVA: 0x7FFAC9DA6170
        public void AddValue(){} // RVA: 0x7FFAC9DA6190
        public void CreateValueVector(){} // RVA: 0x7FFAC9DC7240
        public void CreateValueVectorBlock(){} // RVA: 0x7FFAC9DCC430 | overloaded x3
        public void StartValueVector(){} // RVA: 0x7FFAC9DC7590
        public void EndUdonShortArray(){} // RVA: 0x7FFAC9DCC4F0
        public void UnPack(){} // RVA: 0x7FFAC9DCC540
        public void UnPackTo(){} // RVA: 0x7FFAC9DCC5F0
        public void Pack(){} // RVA: 0x7FFAC9DCC820
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
        public void Verify(){} // RVA: 0x7FFAC9DC79E0
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
        public Google.FlatBuffers32.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsUdonString(){} // RVA: 0x7FFAC9D9CB90 | overloaded x2
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_Value(){} // RVA: 0x7FFAC9DA5FA0
        public void GetValueBytes(){} // RVA: 0x7FFAC9DC5A00
        public void GetValueArray(){} // RVA: 0x7FFAC9DC5A70
        public void CreateUdonString(){} // RVA: 0x7FFAC9DC5AC0
        public void StartUdonString(){} // RVA: 0x7FFAC9DA6170
        public void AddValue(){} // RVA: 0x7FFAC9DA6190
        public void EndUdonString(){} // RVA: 0x7FFAC9DC5B40
        public void UnPack(){} // RVA: 0x7FFAC9DC5B90
        public void UnPackTo(){} // RVA: 0x7FFAC9DA6330
        public void Pack(){} // RVA: 0x7FFAC9DC5CA0
    }

    public class UdonStringArray : ValueType
    {
        public Google.FlatBuffers32.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsUdonStringArray(){} // RVA: 0x7FFAC9D9CB90 | overloaded x2
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void Value(){} // RVA: 0x7FFAC9DA9180
        public void get_ValueLength(){} // RVA: 0x7FFAC9DA6550
        public void CreateUdonStringArray(){} // RVA: 0x7FFAC9DC5D60
        public void StartUdonStringArray(){} // RVA: 0x7FFAC9DA6170
        public void AddValue(){} // RVA: 0x7FFAC9DA6190
        public void CreateValueVector(){} // RVA: 0x7FFAC9D9D690
        public void CreateValueVectorBlock(){} // RVA: 0x7FFAC9DC5F80 | overloaded x3
        public void StartValueVector(){} // RVA: 0x7FFAC9D9DA50
        public void EndUdonStringArray(){} // RVA: 0x7FFAC9DC6040
        public void UnPack(){} // RVA: 0x7FFAC9DC6090
        public void UnPackTo(){} // RVA: 0x7FFAC9DC6140
        public void Pack(){} // RVA: 0x7FFAC9DC6300
    }

    public class UdonStringArrayT : Object
    {
        public System.Collections.Generic.List`1<string> Value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAC2F3C380
        public void set_Value(){} // RVA: 0x7FFAC2F22E30
        public void .ctor(){} // RVA: 0x7FFAC7DDDC00
    }

    public class UdonStringArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAC9DC6540
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
        public void Verify(){} // RVA: 0x7FFAC9DA6460
    }

    public class UdonT : Object
    {
        public System.Collections.Generic.List`1<VRC.Core.Networking.FlatBuffers.FlatBuffers32.UdonValueUnion> Data; // 0x10

        // ── Methods ──
        public void get_Data(){} // RVA: 0x7FFAC2F3C380
        public void set_Data(){} // RVA: 0x7FFAC2F22E30
        public void .ctor(){} // RVA: 0x7FFAC7DDDC00
        public void DeserializeFromBinary(){} // RVA: 0x7FFAC9DD27C0
        public void SerializeToBinary(){} // RVA: 0x7FFAC9DD2870
    }

    public class UdonUByte : ValueType
    {
        public Google.FlatBuffers32.Struct ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_Value(){} // RVA: 0x7FFAC9DAF330
        public void MutateValue(){} // RVA: 0x7FFAC9DA58E0
        public void CreateUdonUByte(){} // RVA: 0x7FFAC9DC5210
        public void UnPack(){} // RVA: 0x7FFAC9DC52A0
        public void UnPackTo(){} // RVA: 0x7FFAC9DBAFF0
        public void Pack(){} // RVA: 0x7FFAC9DC5310
    }

    public class UdonUByteArray : ValueType
    {
        public Google.FlatBuffers32.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsUdonUByteArray(){} // RVA: 0x7FFAC9D9CB90 | overloaded x2
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void Value(){} // RVA: 0x7FFAC9DA64D0
        public void get_ValueLength(){} // RVA: 0x7FFAC9DA6550
        public void GetValueBytes(){} // RVA: 0x7FFAC9DC9490
        public void GetValueArray(){} // RVA: 0x7FFAC9DC9500
        public void MutateValue(){} // RVA: 0x7FFAC9DA6680
        public void CreateUdonUByteArray(){} // RVA: 0x7FFAC9DC9550
        public void StartUdonUByteArray(){} // RVA: 0x7FFAC9DA6170
        public void AddValue(){} // RVA: 0x7FFAC9DA6190
        public void CreateValueVector(){} // RVA: 0x7FFAC9DA6790
        public void CreateValueVectorBlock(){} // RVA: 0x7FFAC9DC9770 | overloaded x3
        public void StartValueVector(){} // RVA: 0x7FFAC9DA6AE0
        public void EndUdonUByteArray(){} // RVA: 0x7FFAC9DC9830
        public void UnPack(){} // RVA: 0x7FFAC9DC9880
        public void UnPackTo(){} // RVA: 0x7FFAC9DC9930
        public void Pack(){} // RVA: 0x7FFAC9DC9B40
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
        public void Verify(){} // RVA: 0x7FFAC9DA6FE0
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
        public Google.FlatBuffers32.Struct ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_Value(){} // RVA: 0x7FFAC9DA5B00
        public void MutateValue(){} // RVA: 0x7FFAC9DA5B30
        public void CreateUdonUInt(){} // RVA: 0x7FFAC9DC5330
        public void UnPack(){} // RVA: 0x7FFAC9DC53C0
        public void UnPackTo(){} // RVA: 0x7FFAC9DA5C60
        public void Pack(){} // RVA: 0x7FFAC9DC5430
    }

    public class UdonUIntArray : ValueType
    {
        public Google.FlatBuffers32.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsUdonUIntArray(){} // RVA: 0x7FFAC9D9CB90 | overloaded x2
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void Value(){} // RVA: 0x7FFAC9DB6870
        public void get_ValueLength(){} // RVA: 0x7FFAC9DA6550
        public void GetValueBytes(){} // RVA: 0x7FFAC9DC9C30
        public void GetValueArray(){} // RVA: 0x7FFAC9DC9CA0
        public void MutateValue(){} // RVA: 0x7FFAC9DB69B0
        public void CreateUdonUIntArray(){} // RVA: 0x7FFAC9DC9CF0
        public void StartUdonUIntArray(){} // RVA: 0x7FFAC9DA6170
        public void AddValue(){} // RVA: 0x7FFAC9DA6190
        public void CreateValueVector(){} // RVA: 0x7FFAC9DAA810
        public void CreateValueVectorBlock(){} // RVA: 0x7FFAC9DC9F10 | overloaded x3
        public void StartValueVector(){} // RVA: 0x7FFAC9D9DA50
        public void EndUdonUIntArray(){} // RVA: 0x7FFAC9DC9FD0
        public void UnPack(){} // RVA: 0x7FFAC9DCA020
        public void UnPackTo(){} // RVA: 0x7FFAC9DCA0D0
        public void Pack(){} // RVA: 0x7FFAC9DCA2F0
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
        public void Verify(){} // RVA: 0x7FFAC9DB7130
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
        public Google.FlatBuffers32.Struct ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_Value(){} // RVA: 0x7FFAC9DAEDC0
        public void MutateValue(){} // RVA: 0x7FFAC9DAEDF0
        public void CreateUdonULong(){} // RVA: 0x7FFAC9DC5450
        public void UnPack(){} // RVA: 0x7FFAC9DC54E0
        public void UnPackTo(){} // RVA: 0x7FFAC9DC51B0
        public void Pack(){} // RVA: 0x7FFAC9DC5550
    }

    public class UdonULongArray : ValueType
    {
        public Google.FlatBuffers32.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsUdonULongArray(){} // RVA: 0x7FFAC9D9CB90 | overloaded x2
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void Value(){} // RVA: 0x7FFAC9DC89A0
        public void get_ValueLength(){} // RVA: 0x7FFAC9DA6550
        public void GetValueBytes(){} // RVA: 0x7FFAC9DCA3E0
        public void GetValueArray(){} // RVA: 0x7FFAC9DCA450
        public void MutateValue(){} // RVA: 0x7FFAC9DC8AE0
        public void CreateUdonULongArray(){} // RVA: 0x7FFAC9DCA4A0
        public void StartUdonULongArray(){} // RVA: 0x7FFAC9DA6170
        public void AddValue(){} // RVA: 0x7FFAC9DA6190
        public void CreateValueVector(){} // RVA: 0x7FFAC9DC8BF0
        public void CreateValueVectorBlock(){} // RVA: 0x7FFAC9DCA760 | overloaded x3
        public void StartValueVector(){} // RVA: 0x7FFAC9DC8FE0
        public void EndUdonULongArray(){} // RVA: 0x7FFAC9DCA820
        public void UnPack(){} // RVA: 0x7FFAC9DCA870
        public void UnPackTo(){} // RVA: 0x7FFAC9DCA920
        public void Pack(){} // RVA: 0x7FFAC9DCAB40
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
        public void Verify(){} // RVA: 0x7FFAC9DC9420
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
        public Google.FlatBuffers32.Struct ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_Value(){} // RVA: 0x7FFAC9DBA1D0
        public void MutateValue(){} // RVA: 0x7FFAC9DBA200
        public void CreateUdonUShort(){} // RVA: 0x7FFAC9DC58E0
        public void UnPack(){} // RVA: 0x7FFAC9DC5970
        public void UnPackTo(){} // RVA: 0x7FFAC9DBA330
        public void Pack(){} // RVA: 0x7FFAC9DC59E0
    }

    public class UdonUShortArray : ValueType
    {
        public Google.FlatBuffers32.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsUdonUShortArray(){} // RVA: 0x7FFAC9D9CB90 | overloaded x2
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void Value(){} // RVA: 0x7FFAC9DC6FF0
        public void get_ValueLength(){} // RVA: 0x7FFAC9DA6550
        public void GetValueBytes(){} // RVA: 0x7FFAC9DCC910
        public void GetValueArray(){} // RVA: 0x7FFAC9DCC980
        public void MutateValue(){} // RVA: 0x7FFAC9DC7130
        public void CreateUdonUShortArray(){} // RVA: 0x7FFAC9DCC9D0
        public void StartUdonUShortArray(){} // RVA: 0x7FFAC9DA6170
        public void AddValue(){} // RVA: 0x7FFAC9DA6190
        public void CreateValueVector(){} // RVA: 0x7FFAC9DC7240
        public void CreateValueVectorBlock(){} // RVA: 0x7FFAC9DCCBF0 | overloaded x3
        public void StartValueVector(){} // RVA: 0x7FFAC9DC7590
        public void EndUdonUShortArray(){} // RVA: 0x7FFAC9DCCCB0
        public void UnPack(){} // RVA: 0x7FFAC9DCCD00
        public void UnPackTo(){} // RVA: 0x7FFAC9DCCDB0
        public void Pack(){} // RVA: 0x7FFAC9DCCFE0
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
        public void Verify(){} // RVA: 0x7FFAC9DC79E0
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
        public 0x6B2025F0 Type; // 0x10
        public object Value; // 0x18

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAC2FEB5E0
        public void set_Type(){} // RVA: 0x7FFAC2FEB5F0
        public void get_Value(){} // RVA: 0x7FFAC2F247C0
        public void set_Value(){} // RVA: 0x7FFAC2F87E80
        public void .ctor(){} // RVA: 0x7FFAC9D74460
        public void As(){} // RVA: 0x7FFAC2E8DC40
        public void AsUdonShort(){} // RVA: 0x7FFAC9DC05C0
        public void FromUdonShort(){} // RVA: 0x7FFAC9DC0600
        public void AsUdonUShort(){} // RVA: 0x7FFAC9DC0700
        public void FromUdonUShort(){} // RVA: 0x7FFAC9DC0740
        public void AsUdonChar(){} // RVA: 0x7FFAC9DC0840
        public void FromUdonChar(){} // RVA: 0x7FFAC9DC0880
        public void AsUdonByte(){} // RVA: 0x7FFAC9DC0980
        public void FromUdonByte(){} // RVA: 0x7FFAC9DC09C0
        public void AsUdonUByte(){} // RVA: 0x7FFAC9DC0AC0
        public void FromUdonUByte(){} // RVA: 0x7FFAC9DC0B00
        public void AsUdonLong(){} // RVA: 0x7FFAC9DC0C00
        public void FromUdonLong(){} // RVA: 0x7FFAC9DC0C40
        public void AsUdonULong(){} // RVA: 0x7FFAC9DC0D40
        public void FromUdonULong(){} // RVA: 0x7FFAC9DC0D80
        public void AsUdonDouble(){} // RVA: 0x7FFAC9DC0E80
        public void FromUdonDouble(){} // RVA: 0x7FFAC9DC0EC0
        public void AsUdonBool(){} // RVA: 0x7FFAC9DC0FC0
        public void FromUdonBool(){} // RVA: 0x7FFAC9DC1000
        public void AsUdonFloat(){} // RVA: 0x7FFAC9DC1100
        public void FromUdonFloat(){} // RVA: 0x7FFAC9DC1140
        public void AsUdonInt(){} // RVA: 0x7FFAC9DC1240
        public void FromUdonInt(){} // RVA: 0x7FFAC9DC1280
        public void AsUdonUInt(){} // RVA: 0x7FFAC9DC1380
        public void FromUdonUInt(){} // RVA: 0x7FFAC9DC13C0
        public void AsVector2(){} // RVA: 0x7FFAC9DC14C0
        public void FromVector2(){} // RVA: 0x7FFAC9DC1500
        public void AsVector3(){} // RVA: 0x7FFAC9DC1600
        public void FromVector3(){} // RVA: 0x7FFAC9DC1640
        public void AsVector4(){} // RVA: 0x7FFAC9DC1740
        public void FromVector4(){} // RVA: 0x7FFAC9DC1780
        public void AsQuaternion(){} // RVA: 0x7FFAC9DC1880
        public void FromQuaternion(){} // RVA: 0x7FFAC9DC18C0
        public void AsColor(){} // RVA: 0x7FFAC9DC19C0
        public void FromColor(){} // RVA: 0x7FFAC9DC1A00
        public void AsColor32(){} // RVA: 0x7FFAC9DC1B00
        public void FromColor32(){} // RVA: 0x7FFAC9DC1B40
        public void AsUdonShortArray(){} // RVA: 0x7FFAC9DC1C40
        public void FromUdonShortArray(){} // RVA: 0x7FFAC9DC1C80
        public void AsUdonUShortArray(){} // RVA: 0x7FFAC9DC1D80
        public void FromUdonUShortArray(){} // RVA: 0x7FFAC9DC1DC0
        public void AsUdonCharArray(){} // RVA: 0x7FFAC9DC1EC0
        public void FromUdonCharArray(){} // RVA: 0x7FFAC9DC1F00
        public void AsUdonByteArray(){} // RVA: 0x7FFAC9DC2000
        public void FromUdonByteArray(){} // RVA: 0x7FFAC9DC2040
        public void AsUdonUByteArray(){} // RVA: 0x7FFAC9DC2140
        public void FromUdonUByteArray(){} // RVA: 0x7FFAC9DC2180
        public void AsUdonLongArray(){} // RVA: 0x7FFAC9DC2280
        public void FromUdonLongArray(){} // RVA: 0x7FFAC9DC22C0
        public void AsUdonULongArray(){} // RVA: 0x7FFAC9DC23C0
        public void FromUdonULongArray(){} // RVA: 0x7FFAC9DC2400
        public void AsUdonDoubleArray(){} // RVA: 0x7FFAC9DC2500
        public void FromUdonDoubleArray(){} // RVA: 0x7FFAC9DC2540
        public void AsUdonBoolArray(){} // RVA: 0x7FFAC9DC2640
        public void FromUdonBoolArray(){} // RVA: 0x7FFAC9DC2680
        public void AsUdonFloatArray(){} // RVA: 0x7FFAC9DC2780
        public void FromUdonFloatArray(){} // RVA: 0x7FFAC9DC27C0
        public void AsUdonIntArray(){} // RVA: 0x7FFAC9DC28C0
        public void FromUdonIntArray(){} // RVA: 0x7FFAC9DC2900
        public void AsUdonUIntArray(){} // RVA: 0x7FFAC9DC2A00
        public void FromUdonUIntArray(){} // RVA: 0x7FFAC9DC2A40
        public void AsVector2Array(){} // RVA: 0x7FFAC9DC2B40
        public void FromVector2Array(){} // RVA: 0x7FFAC9DC2B80
        public void AsVector3Array(){} // RVA: 0x7FFAC9DC2C80
        public void FromVector3Array(){} // RVA: 0x7FFAC9DC2CC0
        public void AsVector4Array(){} // RVA: 0x7FFAC9DC2DC0
        public void FromVector4Array(){} // RVA: 0x7FFAC9DC2E00
        public void AsQuaternionArray(){} // RVA: 0x7FFAC9DC2F00
        public void FromQuaternionArray(){} // RVA: 0x7FFAC9DC2F40
        public void AsColorArray(){} // RVA: 0x7FFAC9DC3040
        public void FromColorArray(){} // RVA: 0x7FFAC9DC3080
        public void AsColor32Array(){} // RVA: 0x7FFAC9DC3180
        public void FromColor32Array(){} // RVA: 0x7FFAC9DC31C0
        public void AsUdonString(){} // RVA: 0x7FFAC9DC32C0
        public void FromUdonString(){} // RVA: 0x7FFAC9DC3300
        public void Pack(){} // RVA: 0x7FFAC9DC3400
    }

    public class UdonValueVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAC9DC4810
    }

    public class UdonVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAC9DA6FE0
    }

}