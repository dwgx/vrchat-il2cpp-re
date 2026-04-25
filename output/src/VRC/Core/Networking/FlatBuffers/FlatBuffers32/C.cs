// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers32
// Classes: 13
// Methods: 134

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers32
{
    public class Color : ValueType
    {
        public Google.FlatBuffers32.Struct ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_R(){} // RVA: 0x7FFAC9DA5D50
        public void MutateR(){} // RVA: 0x7FFAC9DA5D80
        public void get_G(){} // RVA: 0x7FFAC9DBBB00
        public void MutateG(){} // RVA: 0x7FFAC9DBBB30
        public void get_B(){} // RVA: 0x7FFAC9DBBD30
        public void MutateB(){} // RVA: 0x7FFAC9DBBD60
        public void get_A(){} // RVA: 0x7FFAC9DBBFF0
        public void MutateA(){} // RVA: 0x7FFAC9DBC020
        public void CreateColor(){} // RVA: 0x7FFAC9DBD5B0
        public void UnPack(){} // RVA: 0x7FFAC9DBD6D0
        public void UnPackTo(){} // RVA: 0x7FFAC9DBC240
        public void Pack(){} // RVA: 0x7FFAC9DBD7A0
    }

    public class Color32 : ValueType
    {
        public Google.FlatBuffers32.Struct ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_R(){} // RVA: 0x7FFAC9DAF330
        public void MutateR(){} // RVA: 0x7FFAC9DA58E0
        public void get_G(){} // RVA: 0x7FFAC9DBD7E0
        public void MutateG(){} // RVA: 0x7FFAC9DBD810
        public void get_B(){} // RVA: 0x7FFAC9DBD840
        public void MutateB(){} // RVA: 0x7FFAC9DBD870
        public void get_A(){} // RVA: 0x7FFAC9DBD8A0
        public void MutateA(){} // RVA: 0x7FFAC9DBD8D0
        public void CreateColor32(){} // RVA: 0x7FFAC9DBD900
        public void UnPack(){} // RVA: 0x7FFAC9DBDA10
        public void UnPackTo(){} // RVA: 0x7FFAC9DBDAD0
        public void Pack(){} // RVA: 0x7FFAC9DBDB60
    }

    public class Color32Array : ValueType
    {
        public Google.FlatBuffers32.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsColor32Array(){} // RVA: 0x7FFAC9D9CB90 | overloaded x2
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void Value(){} // RVA: 0x7FFAC9DCF440
        public void get_ValueLength(){} // RVA: 0x7FFAC9DA6550
        public void CreateColor32Array(){} // RVA: 0x7FFAC9DCF590
        public void StartColor32Array(){} // RVA: 0x7FFAC9DA6170
        public void AddValue(){} // RVA: 0x7FFAC9DA6190
        public void StartValueVector(){} // RVA: 0x7FFAC9DCF610
        public void EndColor32Array(){} // RVA: 0x7FFAC9DCF640
        public void UnPack(){} // RVA: 0x7FFAC9DCF690
        public void UnPackTo(){} // RVA: 0x7FFAC9DCF740
        public void Pack(){} // RVA: 0x7FFAC9DCF950
    }

    public class Color32ArrayT : Object
    {
        public System.Collections.Generic.List`1<VRC.Core.Networking.FlatBuffers.FlatBuffers32.Color32T> Value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAC2F3C380
        public void set_Value(){} // RVA: 0x7FFAC2F22E30
        public void .ctor(){} // RVA: 0x7FFAC7DDDC00
    }

    public class Color32ArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAC9DB7130
    }

    public class Color32T : Object
    {
        public byte R; // 0x10
        public byte G; // 0x11
        public byte B; // 0x12
        public byte A; // 0x13

        // ── Methods ──
        public void get_R(){} // RVA: 0x7FFAC2FEB5E0
        public void set_R(){} // RVA: 0x7FFAC2FEB5F0
        public void get_G(){} // RVA: 0x7FFAC3771DA0
        public void set_G(){} // RVA: 0x7FFAC3771D90
        public void get_B(){} // RVA: 0x7FFAC3AE1A90
        public void set_B(){} // RVA: 0x7FFAC4411DE0
        public void get_A(){} // RVA: 0x7FFAC4411E00
        public void set_A(){} // RVA: 0x7FFAC4411E10
        public void .ctor(){} // RVA: 0x7FFAC369FBB0
    }

    public class ColorArray : ValueType
    {
        public Google.FlatBuffers32.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsColorArray(){} // RVA: 0x7FFAC9D9CB90 | overloaded x2
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void Value(){} // RVA: 0x7FFAC9DCED70
        public void get_ValueLength(){} // RVA: 0x7FFAC9DA6550
        public void CreateColorArray(){} // RVA: 0x7FFAC9DCEEC0
        public void StartColorArray(){} // RVA: 0x7FFAC9DA6170
        public void AddValue(){} // RVA: 0x7FFAC9DA6190
        public void StartValueVector(){} // RVA: 0x7FFAC9DCE100
        public void EndColorArray(){} // RVA: 0x7FFAC9DCEF40
        public void UnPack(){} // RVA: 0x7FFAC9DCEF90
        public void UnPackTo(){} // RVA: 0x7FFAC9DCF040
        public void Pack(){} // RVA: 0x7FFAC9DCF250
    }

    public class ColorArrayT : Object
    {
        public System.Collections.Generic.List`1<VRC.Core.Networking.FlatBuffers.FlatBuffers32.ColorT> Value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAC2F3C380
        public void set_Value(){} // RVA: 0x7FFAC2F22E30
        public void .ctor(){} // RVA: 0x7FFAC7DDDC00
    }

    public class ColorArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAC9DCE630
    }

    public class ColorT : Object
    {
        public float R; // 0x10
        public float G; // 0x14
        public float B; // 0x18
        public float A; // 0x1C

        // ── Methods ──
        public void get_R(){} // RVA: 0x7FFAC304B320
        public void set_R(){} // RVA: 0x7FFAC304B330
        public void get_G(){} // RVA: 0x7FFAC304B340
        public void set_G(){} // RVA: 0x7FFAC304B350
        public void get_B(){} // RVA: 0x7FFAC2F25CF0
        public void set_B(){} // RVA: 0x7FFAC2F3C4D0
        public void get_A(){} // RVA: 0x7FFAC2FEE570
        public void set_A(){} // RVA: 0x7FFAC2FEE580
        public void .ctor(){} // RVA: 0x7FFAC9D72C50
    }

    public class ComponentInfo : ValueType
    {
        public Google.FlatBuffers32.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsComponentInfo(){} // RVA: 0x7FFAC9D9CB90 | overloaded x2
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_TypeId(){} // RVA: 0x7FFAC9DAA050
        public void MutateTypeId(){} // RVA: 0x7FFAC9DAA0A0
        public void get_UniqueHash(){} // RVA: 0x7FFAC9DAA100
        public void MutateUniqueHash(){} // RVA: 0x7FFAC9DAA150
        public void Hashes(){} // RVA: 0x7FFAC9DAA1B0
        public void get_HashesLength(){} // RVA: 0x7FFAC9DA1BD0
        public void GetHashesBytes(){} // RVA: 0x7FFAC9DAA230
        public void GetHashesArray(){} // RVA: 0x7FFAC9DAA2A0
        public void MutateHashes(){} // RVA: 0x7FFAC9DAA2F0
        public void get_GameObjectHash(){} // RVA: 0x7FFAC9DAA380
        public void MutateGameObjectHash(){} // RVA: 0x7FFAC9DAA3D0
        public void get_UdonInfo(){} // RVA: 0x7FFAC9DAA430
        public void CreateComponentInfo(){} // RVA: 0x7FFAC9DAA560
        public void StartComponentInfo(){} // RVA: 0x7FFAC9DAA710
        public void AddTypeId(){} // RVA: 0x7FFAC9DAA730
        public void AddUniqueHash(){} // RVA: 0x7FFAC9DAA7A0
        public void AddHashes(){} // RVA: 0x7FFAC9DA26A0
        public void CreateHashesVector(){} // RVA: 0x7FFAC9DAA810
        public void CreateHashesVectorBlock(){} // RVA: 0x7FFAC9DAAAA0 | overloaded x3
        public void StartHashesVector(){} // RVA: 0x7FFAC9D9DA50
        public void AddGameObjectHash(){} // RVA: 0x7FFAC9DAAB60
        public void AddUdonInfo(){} // RVA: 0x7FFAC9D9DA80
        public void EndComponentInfo(){} // RVA: 0x7FFAC9DAABD0
        public void UnPack(){} // RVA: 0x7FFAC9DAAC20
        public void UnPackTo(){} // RVA: 0x7FFAC9DAAC90
        public void Pack(){} // RVA: 0x7FFAC9DAB0A0
    }

    public class ComponentInfoT : Object
    {
        public int TypeId; // 0x10
        public int UniqueHash; // 0x14
        public System.Collections.Generic.List`1<int> Hashes; // 0x18
        public int GameObjectHash; // 0x20
        public VRC.Core.Networking.FlatBuffers.FlatBuffers32.UdonInfoT UdonInfo; // 0x28

        // ── Methods ──
        public void get_TypeId(){} // RVA: 0x7FFAC2F6E5C0
        public void set_TypeId(){} // RVA: 0x7FFAC2F240C0
        public void get_UniqueHash(){} // RVA: 0x7FFAC33D5A20
        public void set_UniqueHash(){} // RVA: 0x7FFAC33D4990
        public void get_Hashes(){} // RVA: 0x7FFAC2F247C0
        public void set_Hashes(){} // RVA: 0x7FFAC2F87E80
        public void get_GameObjectHash(){} // RVA: 0x7FFAC30DBBE0
        public void set_GameObjectHash(){} // RVA: 0x7FFAC35DB7A0
        public void get_UdonInfo(){} // RVA: 0x7FFAC2F4F130
        public void set_UdonInfo(){} // RVA: 0x7FFAC2F22E90
        public void .ctor(){} // RVA: 0x7FFAC9DAB240
    }

    public class ComponentInfoVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAC9DAB300
    }

}