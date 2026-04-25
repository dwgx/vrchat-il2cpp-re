// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers32
// Classes: 9
// Methods: 87

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers32
{
    public class NetworkCallingEntrypoint : ValueType
    {
        public Google.FlatBuffers32.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsNetworkCallingEntrypoint(){} // RVA: 0x7FFAC9D9CB90 | overloaded x2
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_NameHash(){} // RVA: 0x7FFAC9DAA050
        public void MutateNameHash(){} // RVA: 0x7FFAC9DAA0A0
        public void get_Ratelimit(){} // RVA: 0x7FFAC9DAA100
        public void MutateRatelimit(){} // RVA: 0x7FFAC9DAA150
        public void Parameters(){} // RVA: 0x7FFAC9DACF40
        public void get_ParametersLength(){} // RVA: 0x7FFAC9DA1BD0
        public void CreateNetworkCallingEntrypoint(){} // RVA: 0x7FFAC9DAD0B0
        public void StartNetworkCallingEntrypoint(){} // RVA: 0x7FFAC9DAD1E0
        public void AddNameHash(){} // RVA: 0x7FFAC9DAA730
        public void AddRatelimit(){} // RVA: 0x7FFAC9DAA7A0
        public void AddParameters(){} // RVA: 0x7FFAC9DA26A0
        public void CreateParametersVector(){} // RVA: 0x7FFAC9D9D690
        public void CreateParametersVectorBlock(){} // RVA: 0x7FFAC9DAD440 | overloaded x3
        public void StartParametersVector(){} // RVA: 0x7FFAC9D9DA50
        public void EndNetworkCallingEntrypoint(){} // RVA: 0x7FFAC9DAD500
        public void UnPack(){} // RVA: 0x7FFAC9DAD550
        public void UnPackTo(){} // RVA: 0x7FFAC9DAD600
        public void Pack(){} // RVA: 0x7FFAC9DAD870
    }

    public class NetworkCallingEntrypointT : Object
    {
        public uint NameHash; // 0x10
        public int Ratelimit; // 0x14
        public System.Collections.Generic.List`1<VRC.Core.Networking.FlatBuffers.FlatBuffers32.NetworkCallingParameterT> Parameters; // 0x18

        // ── Methods ──
        public void get_NameHash(){} // RVA: 0x7FFAC2F6E5C0
        public void set_NameHash(){} // RVA: 0x7FFAC2F240C0
        public void get_Ratelimit(){} // RVA: 0x7FFAC33D5A20
        public void set_Ratelimit(){} // RVA: 0x7FFAC33D4990
        public void get_Parameters(){} // RVA: 0x7FFAC2F247C0
        public void set_Parameters(){} // RVA: 0x7FFAC2F87E80
        public void .ctor(){} // RVA: 0x7FFAC9DADBF0
    }

    public class NetworkCallingEntrypointVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAC9DADC50
    }

    public class NetworkCallingParameter : ValueType
    {
        public Google.FlatBuffers32.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsNetworkCallingParameter(){} // RVA: 0x7FFAC9D9CB90 | overloaded x2
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_Type(){} // RVA: 0x7FFAC9DACAE0
        public void MutateType(){} // RVA: 0x7FFAC9DACB30
        public void CreateNetworkCallingParameter(){} // RVA: 0x7FFAC9DACB90
        public void StartNetworkCallingParameter(){} // RVA: 0x7FFAC9DA6170
        public void AddType(){} // RVA: 0x7FFAC9DACC40
        public void EndNetworkCallingParameter(){} // RVA: 0x7FFAC9DACCB0
        public void UnPack(){} // RVA: 0x7FFAC9DACD00
        public void UnPackTo(){} // RVA: 0x7FFAC9DACDA0
        public void Pack(){} // RVA: 0x7FFAC9DACE00
    }

    public class NetworkCallingParameterT : Object
    {
        public byte Type; // 0x10

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAC2FEB5E0
        public void set_Type(){} // RVA: 0x7FFAC2FEB5F0
        public void .ctor(){} // RVA: 0x7FFAC322C880
    }

    public class NetworkCallingParameterVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAC9DACEC0
    }

    public class NetworkCallingView : ValueType
    {
        public Google.FlatBuffers32.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsNetworkCallingView(){} // RVA: 0x7FFAC9D9CB90 | overloaded x2
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_ViewId(){} // RVA: 0x7FFAC9DAA050
        public void MutateViewId(){} // RVA: 0x7FFAC9DAA0A0
        public void get_ComponentIndex(){} // RVA: 0x7FFAC9DAA100
        public void MutateComponentIndex(){} // RVA: 0x7FFAC9DAA150
        public void Entrypoints(){} // RVA: 0x7FFAC9DADDC0
        public void get_EntrypointsLength(){} // RVA: 0x7FFAC9DA1BD0
        public void CreateNetworkCallingView(){} // RVA: 0x7FFAC9DADF30
        public void StartNetworkCallingView(){} // RVA: 0x7FFAC9DAD1E0
        public void AddViewId(){} // RVA: 0x7FFAC9DAA730
        public void AddComponentIndex(){} // RVA: 0x7FFAC9DAA7A0
        public void AddEntrypoints(){} // RVA: 0x7FFAC9DA26A0
        public void CreateEntrypointsVector(){} // RVA: 0x7FFAC9D9D690
        public void CreateEntrypointsVectorBlock(){} // RVA: 0x7FFAC9DAE2A0 | overloaded x3
        public void StartEntrypointsVector(){} // RVA: 0x7FFAC9D9DA50
        public void EndNetworkCallingView(){} // RVA: 0x7FFAC9DAE360
        public void UnPack(){} // RVA: 0x7FFAC9DAE3B0
        public void UnPackTo(){} // RVA: 0x7FFAC9DAE460
        public void Pack(){} // RVA: 0x7FFAC9DAE6D0
    }

    public class NetworkCallingViewT : Object
    {
        public int ViewId; // 0x10
        public int ComponentIndex; // 0x14
        public System.Collections.Generic.List`1<VRC.Core.Networking.FlatBuffers.FlatBuffers32.NetworkCallingEntrypointT> Entrypoints; // 0x18

        // ── Methods ──
        public void get_ViewId(){} // RVA: 0x7FFAC2F6E5C0
        public void set_ViewId(){} // RVA: 0x7FFAC2F240C0
        public void get_ComponentIndex(){} // RVA: 0x7FFAC33D5A20
        public void set_ComponentIndex(){} // RVA: 0x7FFAC33D4990
        public void get_Entrypoints(){} // RVA: 0x7FFAC2F247C0
        public void set_Entrypoints(){} // RVA: 0x7FFAC2F87E80
        public void .ctor(){} // RVA: 0x7FFAC9DADBF0
    }

    public class NetworkCallingViewVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAC9DAE9B0
    }

}