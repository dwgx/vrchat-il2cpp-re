// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers32
// Classes: 9
// Methods: 82

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers32
{
    public class NetworkCallingEntrypoint : ValueType
    {
        public Google.FlatBuffers32.Table __p; // 0x10
        public object field_1; // 0x229
        public object field_2; // 0x22A
        public object field_3; // 0x22B

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsNetworkCallingEntrypoint(){} // RVA: 0x7FFE881444A0 | overloaded x2
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_NameHash(){} // RVA: 0x7FFE881501B0
        public void get_Ratelimit(){} // RVA: 0x7FFE88150200
        public void Parameters(){} // RVA: 0x7FFE88152E00
        public void get_ParametersLength(){} // RVA: 0x7FFE88148000
        public void CreateNetworkCallingEntrypoint(){} // RVA: 0x7FFE88152F70
        public void StartNetworkCallingEntrypoint(){} // RVA: 0x7FFE881530A0
        public void AddNameHash(){} // RVA: 0x7FFE881506E0
        public void AddRatelimit(){} // RVA: 0x7FFE88150750
        public void AddParameters(){} // RVA: 0x7FFE88148950
        public void CreateParametersVector(){} // RVA: 0x7FFE88144E80
        public void CreateParametersVectorBlock(){} // RVA: 0x7FFE88153300 | overloaded x3
        public void StartParametersVector(){} // RVA: 0x7FFE88145240
        public void EndNetworkCallingEntrypoint(){} // RVA: 0x7FFE881533C0
        public void UnPack(){} // RVA: 0x7FFE88153410
        public void UnPackTo(){} // RVA: 0x7FFE881534C0
        public void Pack(){} // RVA: 0x7FFE88153730
    }

    public class NetworkCallingEntrypointT : Object
    {
        public uint _nameHash; // 0x10
        public int _ratelimit; // 0x14
        public System.Collections.Generic.List`1<VRC.Core.Networking.FlatBuffers.FlatBuffers32.NetworkCallingParameterT> _parameters; // 0x18

        // ── Methods ──
        public void get_NameHash(){} // RVA: 0x7FFE811485C0
        public void set_NameHash(){} // RVA: 0x7FFE810FE0C0
        public void get_Ratelimit(){} // RVA: 0x7FFE8164B230
        public void set_Ratelimit(){} // RVA: 0x7FFE8164E0F0
        public void get_Parameters(){} // RVA: 0x7FFE810FE7C0
        public void set_Parameters(){} // RVA: 0x7FFE81161E80
        public void .ctor(){} // RVA: 0x7FFE88153AB0
    }

    public class NetworkCallingEntrypointVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFE88153B10
    }

    public class NetworkCallingParameter : ValueType
    {
        public Google.FlatBuffers32.Table __p; // 0x10
        public object field_1; // 0x226

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsNetworkCallingParameter(){} // RVA: 0x7FFE881444A0 | overloaded x2
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_Type(){} // RVA: 0x7FFE88152A00
        public void CreateNetworkCallingParameter(){} // RVA: 0x7FFE88152A50
        public void StartNetworkCallingParameter(){} // RVA: 0x7FFE8814C360
        public void AddType(){} // RVA: 0x7FFE88152B00
        public void EndNetworkCallingParameter(){} // RVA: 0x7FFE88152B70
        public void UnPack(){} // RVA: 0x7FFE88152BC0
        public void UnPackTo(){} // RVA: 0x7FFE88152C60
        public void Pack(){} // RVA: 0x7FFE88152CC0
    }

    public class NetworkCallingParameterT : Object
    {
        public byte _type; // 0x10

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFE811C55E0
        public void set_Type(){} // RVA: 0x7FFE811C55F0
        public void .ctor(){} // RVA: 0x7FFE81FCAC70
    }

    public class NetworkCallingParameterVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFE88152D80
    }

    public class NetworkCallingView : ValueType
    {
        public Google.FlatBuffers32.Table __p; // 0x10
        public object field_1; // 0x230
        public object field_2; // 0x231
        public object field_3; // 0x232

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsNetworkCallingView(){} // RVA: 0x7FFE881444A0 | overloaded x2
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_ViewId(){} // RVA: 0x7FFE881501B0
        public void get_ComponentIndex(){} // RVA: 0x7FFE88150200
        public void Entrypoints(){} // RVA: 0x7FFE88153C80
        public void get_EntrypointsLength(){} // RVA: 0x7FFE88148000
        public void CreateNetworkCallingView(){} // RVA: 0x7FFE88153DF0
        public void StartNetworkCallingView(){} // RVA: 0x7FFE881530A0
        public void AddViewId(){} // RVA: 0x7FFE881506E0
        public void AddComponentIndex(){} // RVA: 0x7FFE88150750
        public void AddEntrypoints(){} // RVA: 0x7FFE88148950
        public void CreateEntrypointsVector(){} // RVA: 0x7FFE88144E80
        public void CreateEntrypointsVectorBlock(){} // RVA: 0x7FFE88154160 | overloaded x3
        public void StartEntrypointsVector(){} // RVA: 0x7FFE88145240
        public void EndNetworkCallingView(){} // RVA: 0x7FFE88154220
        public void UnPack(){} // RVA: 0x7FFE88154270
        public void UnPackTo(){} // RVA: 0x7FFE88154320
        public void Pack(){} // RVA: 0x7FFE88154590
    }

    public class NetworkCallingViewT : Object
    {
        public int _viewId; // 0x10
        public int _componentIndex; // 0x14
        public System.Collections.Generic.List`1<VRC.Core.Networking.FlatBuffers.FlatBuffers32.NetworkCallingEntrypointT> _entrypoints; // 0x18

        // ── Methods ──
        public void get_ViewId(){} // RVA: 0x7FFE811485C0
        public void set_ViewId(){} // RVA: 0x7FFE810FE0C0
        public void get_ComponentIndex(){} // RVA: 0x7FFE8164B230
        public void set_ComponentIndex(){} // RVA: 0x7FFE8164E0F0
        public void get_Entrypoints(){} // RVA: 0x7FFE810FE7C0
        public void set_Entrypoints(){} // RVA: 0x7FFE81161E80
        public void .ctor(){} // RVA: 0x7FFE88153AB0
    }

    public class NetworkCallingViewVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFE88154870
    }

}