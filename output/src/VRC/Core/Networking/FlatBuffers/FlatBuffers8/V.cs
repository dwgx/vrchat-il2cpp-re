// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers8
// Classes: 21
// Methods: 166

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers8
{
    public class Vector2
    {
        public Google.FlatBuffers8.Struct __p; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void get_X(){} // RVA: 0x75E0A10
        public void get_Y(){} // RVA: 0x75EB910
        public void CreateVector2(){} // RVA: 0x75EB940
        public void UnPack(){} // RVA: 0x75EBA30
        public void UnPackTo(){} // RVA: 0x75EBAC0
        public void Pack(){} // RVA: 0x75EBB20
    }

    public class Vector2Array
    {
        public Google.FlatBuffers8.Table __p; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void ValidateVersion(){} // RVA: 0x2DD310
        public void GetRootAsVector2Array(){} // RVA: 0x75E0C40 | overloaded x2
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void Value(){} // RVA: 0x7600E70
        public void get_ValueLength(){} // RVA: 0x75E1270
        public void CreateVector2Array(){} // RVA: 0x7600FD0
        public void StartVector2Array(){} // RVA: 0x75E0EB0
        public void AddValue(){} // RVA: 0x75E0ED0
        public void StartValueVector(){} // RVA: 0x7601090
        public void EndVector2Array(){} // RVA: 0x76010C0
        public void UnPack(){} // RVA: 0x7601150
        public void UnPackTo(){} // RVA: 0x7601200
        public void Pack(){} // RVA: 0x7601410
    }

    public class Vector2ArrayT
    {
        public System.Collections.Generic.List`1<VRC.Core.Networking.FlatBuffers.FlatBuffers8.Vector2T> <Value>k__BackingField; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x2F8380
        public void set_Value(){} // RVA: 0x2DEE30
        public void .ctor(){} // RVA: 0x574FB20
    }

    public class Vector2ArrayVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x75FD470
    }

    public class Vector2T
    {
        public float <X>k__BackingField; // 0x10
        public float <Y>k__BackingField; // 0x14

        // ── Methods ──
        public void ToNumerics(){} // RVA: 0x2EE22E0
        public void op_Implicit(){} // RVA: 0x75DF4B0
        public void op_Explicit(){} // RVA: 0x75DF4E0
        public void get_zero(){} // RVA: 0x75DF540
        public void .ctor(){} // RVA: 0x6243FF0 | overloaded x2
        public void CopyFrom(){} // RVA: 0x75DF5B0 | overloaded x2
        public void op_UnaryNegation(){} // RVA: 0x75DF5D0
        public void get_magnitude(){} // RVA: 0x75DF640
        public void get_sqrMagnitude(){} // RVA: 0x75DF6D0
        public void IsBad(){} // RVA: 0x75DF6F0
        public void get_X(){} // RVA: 0x407320
        public void set_X(){} // RVA: 0x407330
        public void get_Y(){} // RVA: 0x407340
        public void set_Y(){} // RVA: 0x407350
    }

    public class Vector3
    {
        public Google.FlatBuffers8.Struct __p; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void get_X(){} // RVA: 0x75E0A10
        public void get_Y(){} // RVA: 0x75EB910
        public void get_Z(){} // RVA: 0x75EBF80
        public void CreateVector3(){} // RVA: 0x75EBFB0
        public void UnPack(){} // RVA: 0x75EC0C0
        public void UnPackTo(){} // RVA: 0x75EC170
        public void Pack(){} // RVA: 0x75EC1F0
    }

    public class Vector3Array
    {
        public Google.FlatBuffers8.Table __p; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void ValidateVersion(){} // RVA: 0x2DD310
        public void GetRootAsVector3Array(){} // RVA: 0x75E0C40 | overloaded x2
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void Value(){} // RVA: 0x76015F0
        public void get_ValueLength(){} // RVA: 0x75E1270
        public void CreateVector3Array(){} // RVA: 0x7601750
        public void StartVector3Array(){} // RVA: 0x75E0EB0
        public void AddValue(){} // RVA: 0x75E0ED0
        public void StartValueVector(){} // RVA: 0x7601810
        public void EndVector3Array(){} // RVA: 0x7601840
        public void UnPack(){} // RVA: 0x76018D0
        public void UnPackTo(){} // RVA: 0x7601980
        public void Pack(){} // RVA: 0x7601B90
    }

    public class Vector3ArrayT
    {
        public System.Collections.Generic.List`1<VRC.Core.Networking.FlatBuffers.FlatBuffers8.Vector3T> <Value>k__BackingField; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x2F8380
        public void set_Value(){} // RVA: 0x2DEE30
        public void .ctor(){} // RVA: 0x574FB20
    }

    public class Vector3ArrayVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7601D80
    }

    public class Vector3Bytes
    {
        public Google.FlatBuffers8.Struct __p; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void Data(){} // RVA: 0x75E5870
        public void CreateVector3Bytes(){} // RVA: 0x75EBB40
        public void UnPack(){} // RVA: 0x75EBC50
        public void UnPackTo(){} // RVA: 0x75EBCC0
        public void Pack(){} // RVA: 0x75EBDC0
    }

    public class Vector3BytesT
    {
        public byte[] ByteBuffer; // 0x10

        // ── Methods ──
        public void get_Data(){} // RVA: 0x2F8380
        public void set_Data(){} // RVA: 0x2DEE30
        public void .ctor(){} // RVA: 0x75EBEF0
    }

    public class Vector3Half
    {
        public Google.FlatBuffers8.Struct __p; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void Data(){} // RVA: 0x75E5870
        public void CreateVector3Half(){} // RVA: 0x75ECEC0
        public void UnPack(){} // RVA: 0x75ECFD0
        public void UnPackTo(){} // RVA: 0x75ED040
        public void Pack(){} // RVA: 0x75ED140
    }

    public class Vector3HalfT
    {
        public byte[] ByteBuffer; // 0x10

        // ── Methods ──
        public void get_Data(){} // RVA: 0x2F8380
        public void set_Data(){} // RVA: 0x2DEE30
        public void .ctor(){} // RVA: 0x75ED270
    }

    public class Vector3T
    {
        public float <X>k__BackingField; // 0x10
        public float <Y>k__BackingField; // 0x14
        public float <Z>k__BackingField; // 0x18

        // ── Methods ──
        public void ToNumerics(){} // RVA: 0xFED180
        public void op_Implicit(){} // RVA: 0x75DF730
        public void op_Explicit(){} // RVA: 0x75DF770
        public void get_zero(){} // RVA: 0x75DF7C0
        public void .ctor(){} // RVA: 0x62E69C0 | overloaded x2
        public void CopyFrom(){} // RVA: 0x75DF860 | overloaded x2
        public void get_magnitude(){} // RVA: 0x75DF880
        public void get_sqrMagnitude(){} // RVA: 0x75DF920
        public void IsBad(){} // RVA: 0x75DF950
        public void ToString(){} // RVA: 0x75DF9B0
        public void get_X(){} // RVA: 0x407320
        public void set_X(){} // RVA: 0x407330
        public void get_Y(){} // RVA: 0x407340
        public void set_Y(){} // RVA: 0x407350
        public void get_Z(){} // RVA: 0x2E1CF0
        public void set_Z(){} // RVA: 0x2F84D0
    }

    public class Vector3TenBit
    {
        public Google.FlatBuffers8.Struct __p; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void Data(){} // RVA: 0x75E5870
        public void CreateVector3TenBit(){} // RVA: 0x75EC750
        public void UnPack(){} // RVA: 0x75EC860
        public void UnPackTo(){} // RVA: 0x75EC8D0
        public void Pack(){} // RVA: 0x75EC9D0
    }

    public class Vector3TenBitT
    {
        public byte[] ByteBuffer; // 0x10

        // ── Methods ──
        public void get_Data(){} // RVA: 0x2F8380
        public void set_Data(){} // RVA: 0x2DEE30
        public void .ctor(){} // RVA: 0x75EC9F0
    }

    public class Vector4
    {
        public Google.FlatBuffers8.Struct __p; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void get_X(){} // RVA: 0x75E0A10
        public void get_Y(){} // RVA: 0x75EB910
        public void get_Z(){} // RVA: 0x75EBF80
        public void get_W(){} // RVA: 0x75EC230
        public void CreateVector4(){} // RVA: 0x75EC260
        public void UnPack(){} // RVA: 0x75EC380
        public void UnPackTo(){} // RVA: 0x75EC450
        public void Pack(){} // RVA: 0x75EC4E0
    }

    public class Vector4Array
    {
        public Google.FlatBuffers8.Table __p; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void ValidateVersion(){} // RVA: 0x2DD310
        public void GetRootAsVector4Array(){} // RVA: 0x75E0C40 | overloaded x2
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void Value(){} // RVA: 0x7601DF0
        public void get_ValueLength(){} // RVA: 0x75E1270
        public void CreateVector4Array(){} // RVA: 0x7601F40
        public void StartVector4Array(){} // RVA: 0x75E0EB0
        public void AddValue(){} // RVA: 0x75E0ED0
        public void StartValueVector(){} // RVA: 0x7602000
        public void EndVector4Array(){} // RVA: 0x7602030
        public void UnPack(){} // RVA: 0x76020C0
        public void UnPackTo(){} // RVA: 0x7602170
        public void Pack(){} // RVA: 0x7602380
    }

    public class Vector4ArrayT
    {
        public System.Collections.Generic.List`1<VRC.Core.Networking.FlatBuffers.FlatBuffers8.Vector4T> <Value>k__BackingField; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x2F8380
        public void set_Value(){} // RVA: 0x2DEE30
        public void .ctor(){} // RVA: 0x574FB20
    }

    public class Vector4ArrayVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7602570
    }

    public class Vector4T
    {
        public float ByteBuffer; // 0x10
        public float X; // 0x14
        public float Y; // 0x18
        public float Z; // 0x1C

        // ── Methods ──
        public void get_X(){} // RVA: 0x407320
        public void set_X(){} // RVA: 0x407330
        public void get_Y(){} // RVA: 0x407340
        public void set_Y(){} // RVA: 0x407350
        public void get_Z(){} // RVA: 0x2E1CF0
        public void set_Z(){} // RVA: 0x2F84D0
        public void get_W(){} // RVA: 0x3AA570
        public void set_W(){} // RVA: 0x3AA580
        public void .ctor(){} // RVA: 0x75DF4A0
    }

}