// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers32
// Classes: 9
// Methods: 82

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers32
{
    public class NetworkCallingEntrypoint
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void ValidateVersion(){} // RVA: 0x2DD310
        public void GetRootAsNetworkCallingEntrypoint(){} // RVA: 0x7607450 | overloaded x2
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void get_NameHash(){} // RVA: 0x7613160
        public void get_Ratelimit(){} // RVA: 0x76131B0
        public void Parameters(){} // RVA: 0x7615DB0
        public void get_ParametersLength(){} // RVA: 0x760AFB0
        public void CreateNetworkCallingEntrypoint(){} // RVA: 0x7615F20
        public void StartNetworkCallingEntrypoint(){} // RVA: 0x7616050
        public void AddNameHash(){} // RVA: 0x7613690
        public void AddRatelimit(){} // RVA: 0x7613700
        public void AddParameters(){} // RVA: 0x760B900
        public void CreateParametersVector(){} // RVA: 0x7607E30
        public void CreateParametersVectorBlock(){} // RVA: 0x76162B0 | overloaded x3
        public void StartParametersVector(){} // RVA: 0x76081F0
        public void EndNetworkCallingEntrypoint(){} // RVA: 0x7616370
        public void UnPack(){} // RVA: 0x76163C0
        public void UnPackTo(){} // RVA: 0x7616470
        public void Pack(){} // RVA: 0x76166E0
    }

    public class NetworkCallingEntrypointT
    {
        // ── Methods ──
        public void get_NameHash(){} // RVA: 0x32A5C0
        public void set_NameHash(){} // RVA: 0x2E00C0
        public void get_Ratelimit(){} // RVA: 0x8ABED0
        public void set_Ratelimit(){} // RVA: 0x8AC660
        public void get_Parameters(){} // RVA: 0x2E07C0
        public void set_Parameters(){} // RVA: 0x343E80
        public void .ctor(){} // RVA: 0x7616A60
    }

    public class NetworkCallingEntrypointVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7616AC0
    }

    public class NetworkCallingParameter
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void ValidateVersion(){} // RVA: 0x2DD310
        public void GetRootAsNetworkCallingParameter(){} // RVA: 0x7607450 | overloaded x2
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void get_Type(){} // RVA: 0x76159B0
        public void CreateNetworkCallingParameter(){} // RVA: 0x7615A00
        public void StartNetworkCallingParameter(){} // RVA: 0x760F310
        public void AddType(){} // RVA: 0x7615AB0
        public void EndNetworkCallingParameter(){} // RVA: 0x7615B20
        public void UnPack(){} // RVA: 0x7615B70
        public void UnPackTo(){} // RVA: 0x7615C10
        public void Pack(){} // RVA: 0x7615C70
    }

    public class NetworkCallingParameterT
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x3A75E0
        public void set_Type(){} // RVA: 0x3A75F0
        public void .ctor(){} // RVA: 0x6BDA00
    }

    public class NetworkCallingParameterVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7615D30
    }

    public class NetworkCallingView
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void ValidateVersion(){} // RVA: 0x2DD310
        public void GetRootAsNetworkCallingView(){} // RVA: 0x7607450 | overloaded x2
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void get_ViewId(){} // RVA: 0x7613160
        public void get_ComponentIndex(){} // RVA: 0x76131B0
        public void Entrypoints(){} // RVA: 0x7616C30
        public void get_EntrypointsLength(){} // RVA: 0x760AFB0
        public void CreateNetworkCallingView(){} // RVA: 0x7616DA0
        public void StartNetworkCallingView(){} // RVA: 0x7616050
        public void AddViewId(){} // RVA: 0x7613690
        public void AddComponentIndex(){} // RVA: 0x7613700
        public void AddEntrypoints(){} // RVA: 0x760B900
        public void CreateEntrypointsVector(){} // RVA: 0x7607E30
        public void CreateEntrypointsVectorBlock(){} // RVA: 0x7617110 | overloaded x3
        public void StartEntrypointsVector(){} // RVA: 0x76081F0
        public void EndNetworkCallingView(){} // RVA: 0x76171D0
        public void UnPack(){} // RVA: 0x7617220
        public void UnPackTo(){} // RVA: 0x76172D0
        public void Pack(){} // RVA: 0x7617540
    }

    public class NetworkCallingViewT
    {
        // ── Methods ──
        public void get_ViewId(){} // RVA: 0x32A5C0
        public void set_ViewId(){} // RVA: 0x2E00C0
        public void get_ComponentIndex(){} // RVA: 0x8ABED0
        public void set_ComponentIndex(){} // RVA: 0x8AC660
        public void get_Entrypoints(){} // RVA: 0x2E07C0
        public void set_Entrypoints(){} // RVA: 0x343E80
        public void .ctor(){} // RVA: 0x7616A60
    }

    public class NetworkCallingViewVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7617820
    }

}