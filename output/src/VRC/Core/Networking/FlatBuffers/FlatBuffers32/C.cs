// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers32
// Classes: 13
// Methods: 122

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers32
{
    public class Color : ValueType
    {
        public Google.FlatBuffers32.Struct __p; // 0x10
        public object field_1; // 0x2B0
        public object field_2; // 0x2B1
        public object field_3; // 0x2B2
        public object field_4; // 0x2B3

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_R(){} // RVA: 0x7FFE8814BF90
        public void get_G(){} // RVA: 0x7FFE881616F0
        public void get_B(){} // RVA: 0x7FFE881618D0
        public void get_A(){} // RVA: 0x7FFE88161B30
        public void CreateColor(){} // RVA: 0x7FFE88163010
        public void UnPack(){} // RVA: 0x7FFE881630F0
        public void UnPackTo(){} // RVA: 0x7FFE88161D10
        public void Pack(){} // RVA: 0x7FFE881631C0
    }

    public class Color32 : ValueType
    {
        public Google.FlatBuffers32.Struct __p; // 0x10
        public object field_1; // 0x2B9
        public object field_2; // 0x2BA
        public object field_3; // 0x2BB
        public object field_4; // 0x2BC

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_R(){} // RVA: 0x7FFE88155130
        public void get_G(){} // RVA: 0x7FFE88163200
        public void get_B(){} // RVA: 0x7FFE88163230
        public void get_A(){} // RVA: 0x7FFE88163260
        public void CreateColor32(){} // RVA: 0x7FFE88163290
        public void UnPack(){} // RVA: 0x7FFE881633A0
        public void UnPackTo(){} // RVA: 0x7FFE88163460
        public void Pack(){} // RVA: 0x7FFE881634F0
    }

    public class Color32Array : ValueType
    {
        public Google.FlatBuffers32.Table __p; // 0x10
        public object field_1; // 0x335

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsColor32Array(){} // RVA: 0x7FFE881444A0 | overloaded x2
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void Value(){} // RVA: 0x7FFE88174AF0
        public void get_ValueLength(){} // RVA: 0x7FFE8814C740
        public void CreateColor32Array(){} // RVA: 0x7FFE88174C40
        public void StartColor32Array(){} // RVA: 0x7FFE8814C360
        public void AddValue(){} // RVA: 0x7FFE8814C380
        public void StartValueVector(){} // RVA: 0x7FFE88174CC0
        public void EndColor32Array(){} // RVA: 0x7FFE88174CF0
        public void UnPack(){} // RVA: 0x7FFE88174D40
        public void UnPackTo(){} // RVA: 0x7FFE88174DF0
        public void Pack(){} // RVA: 0x7FFE88175000
    }

    public class Color32ArrayT : Object
    {
        public System.Collections.Generic.List`1<VRC.Core.Networking.FlatBuffers.FlatBuffers32.Color32T> _value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFE81116380
        public void set_Value(){} // RVA: 0x7FFE810FCE30
        public void .ctor(){} // RVA: 0x7FFE86200400
    }

    public class Color32ArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFE8815CE20
    }

    public class Color32T : Object
    {
        public byte _r; // 0x10
        public byte _g; // 0x11
        public byte _b; // 0x12
        public byte _a; // 0x13

        // ── Methods ──
        public void get_R(){} // RVA: 0x7FFE811C55E0
        public void set_R(){} // RVA: 0x7FFE811C55F0
        public void get_G(){} // RVA: 0x7FFE81346E30
        public void set_G(){} // RVA: 0x7FFE813471A0
        public void get_B(){} // RVA: 0x7FFE826E3520
        public void set_B(){} // RVA: 0x7FFE826E34A0
        public void get_A(){} // RVA: 0x7FFE826E3500
        public void set_A(){} // RVA: 0x7FFE826E3510
        public void .ctor(){} // RVA: 0x7FFE817EE4A0
    }

    public class ColorArray : ValueType
    {
        public Google.FlatBuffers32.Table __p; // 0x10
        public object field_1; // 0x332

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsColorArray(){} // RVA: 0x7FFE881444A0 | overloaded x2
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void Value(){} // RVA: 0x7FFE88174420
        public void get_ValueLength(){} // RVA: 0x7FFE8814C740
        public void CreateColorArray(){} // RVA: 0x7FFE88174570
        public void StartColorArray(){} // RVA: 0x7FFE8814C360
        public void AddValue(){} // RVA: 0x7FFE8814C380
        public void StartValueVector(){} // RVA: 0x7FFE881737B0
        public void EndColorArray(){} // RVA: 0x7FFE881745F0
        public void UnPack(){} // RVA: 0x7FFE88174640
        public void UnPackTo(){} // RVA: 0x7FFE881746F0
        public void Pack(){} // RVA: 0x7FFE88174900
    }

    public class ColorArrayT : Object
    {
        public System.Collections.Generic.List`1<VRC.Core.Networking.FlatBuffers.FlatBuffers32.ColorT> _value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFE81116380
        public void set_Value(){} // RVA: 0x7FFE810FCE30
        public void .ctor(){} // RVA: 0x7FFE86200400
    }

    public class ColorArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFE88173CE0
    }

    public class ColorT : Object
    {
        public float _r; // 0x10
        public float _g; // 0x14
        public float _b; // 0x18
        public float _a; // 0x1C

        // ── Methods ──
        public void get_R(){} // RVA: 0x7FFE81225320
        public void set_R(){} // RVA: 0x7FFE81225330
        public void get_G(){} // RVA: 0x7FFE81225340
        public void set_G(){} // RVA: 0x7FFE81225350
        public void get_B(){} // RVA: 0x7FFE810FFCF0
        public void set_B(){} // RVA: 0x7FFE811164D0
        public void get_A(){} // RVA: 0x7FFE811C8570
        public void set_A(){} // RVA: 0x7FFE811C8580
        public void .ctor(){} // RVA: 0x7FFE8811C4F0
    }

    public class ComponentInfo : ValueType
    {
        public Google.FlatBuffers32.Table __p; // 0x10
        public object field_1; // 0x20D
        public object field_2; // 0x20E
        public object field_3; // 0x20F
        public object field_4; // 0x210
        public object field_5; // 0x211

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsComponentInfo(){} // RVA: 0x7FFE881444A0 | overloaded x2
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_TypeId(){} // RVA: 0x7FFE881501B0
        public void get_UniqueHash(){} // RVA: 0x7FFE88150200
        public void Hashes(){} // RVA: 0x7FFE88150250
        public void get_HashesLength(){} // RVA: 0x7FFE88148000
        public void GetHashesBytes(){} // RVA: 0x7FFE881502D0
        public void GetHashesArray(){} // RVA: 0x7FFE88150340
        public void get_GameObjectHash(){} // RVA: 0x7FFE88150390
        public void get_UdonInfo(){} // RVA: 0x7FFE881503E0
        public void CreateComponentInfo(){} // RVA: 0x7FFE88150510
        public void StartComponentInfo(){} // RVA: 0x7FFE881506C0
        public void AddTypeId(){} // RVA: 0x7FFE881506E0
        public void AddUniqueHash(){} // RVA: 0x7FFE88150750
        public void AddHashes(){} // RVA: 0x7FFE88148950
        public void CreateHashesVector(){} // RVA: 0x7FFE881507C0
        public void CreateHashesVectorBlock(){} // RVA: 0x7FFE88150A50 | overloaded x3
        public void StartHashesVector(){} // RVA: 0x7FFE88145240
        public void AddGameObjectHash(){} // RVA: 0x7FFE88150B10
        public void AddUdonInfo(){} // RVA: 0x7FFE88145270
        public void EndComponentInfo(){} // RVA: 0x7FFE88150B80
        public void UnPack(){} // RVA: 0x7FFE88150BD0
        public void UnPackTo(){} // RVA: 0x7FFE88150C40
        public void Pack(){} // RVA: 0x7FFE88151050
    }

    public class ComponentInfoT : Object
    {
        public int _typeId; // 0x10
        public int _uniqueHash; // 0x14
        public System.Collections.Generic.List`1<int> _hashes; // 0x18
        public int _gameObjectHash; // 0x20
        public VRC.Core.Networking.FlatBuffers.FlatBuffers32.UdonInfoT _udonInfo; // 0x28

        // ── Methods ──
        public void get_TypeId(){} // RVA: 0x7FFE811485C0
        public void set_TypeId(){} // RVA: 0x7FFE810FE0C0
        public void get_UniqueHash(){} // RVA: 0x7FFE8164B230
        public void set_UniqueHash(){} // RVA: 0x7FFE8164E0F0
        public void get_Hashes(){} // RVA: 0x7FFE810FE7C0
        public void set_Hashes(){} // RVA: 0x7FFE81161E80
        public void get_GameObjectHash(){} // RVA: 0x7FFE8151D690
        public void set_GameObjectHash(){} // RVA: 0x7FFE8170B670
        public void get_UdonInfo(){} // RVA: 0x7FFE81129130
        public void set_UdonInfo(){} // RVA: 0x7FFE810FCE90
        public void .ctor(){} // RVA: 0x7FFE881511F0
    }

    public class ComponentInfoVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFE881512B0
    }

}