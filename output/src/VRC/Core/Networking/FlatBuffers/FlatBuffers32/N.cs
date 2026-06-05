// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers32
// Classes: 9
// Methods: 82

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers32
{
    public class NetworkCallingEntrypoint
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAF44189C0
        public void ValidateVersion(){} // RVA: 0x7FFAF2D8D310
        public void GetRootAsNetworkCallingEntrypoint(){} // RVA: 0x7FFAFA0B7450 | overloaded x2
        public void __init(){} // RVA: 0x7FFAFA090560
        public void __assign(){} // RVA: 0x7FFAFA090630
        public void get_NameHash(){} // RVA: 0x7FFAFA0C3160
        public void get_Ratelimit(){} // RVA: 0x7FFAFA0C31B0
        public void Parameters(){} // RVA: 0x7FFAFA0C5DB0
        public void get_ParametersLength(){} // RVA: 0x7FFAFA0BAFB0
        public void CreateNetworkCallingEntrypoint(){} // RVA: 0x7FFAFA0C5F20
        public void StartNetworkCallingEntrypoint(){} // RVA: 0x7FFAFA0C6050
        public void AddNameHash(){} // RVA: 0x7FFAFA0C3690
        public void AddRatelimit(){} // RVA: 0x7FFAFA0C3700
        public void AddParameters(){} // RVA: 0x7FFAFA0BB900
        public void CreateParametersVector(){} // RVA: 0x7FFAFA0B7E30
        public void CreateParametersVectorBlock(){} // RVA: 0x7FFAFA0C62B0 | overloaded x3
        public void StartParametersVector(){} // RVA: 0x7FFAFA0B81F0
        public void EndNetworkCallingEntrypoint(){} // RVA: 0x7FFAFA0C6370
        public void UnPack(){} // RVA: 0x7FFAFA0C63C0
        public void UnPackTo(){} // RVA: 0x7FFAFA0C6470
        public void Pack(){} // RVA: 0x7FFAFA0C66E0
    }

    public class NetworkCallingEntrypointT
    {
        // ── Methods ──
        public void get_NameHash(){} // RVA: 0x7FFAF2DDA5C0
        public void set_NameHash(){} // RVA: 0x7FFAF2D900C0
        public void get_Ratelimit(){} // RVA: 0x7FFAF335BED0
        public void set_Ratelimit(){} // RVA: 0x7FFAF335C660
        public void get_Parameters(){} // RVA: 0x7FFAF2D907C0
        public void set_Parameters(){} // RVA: 0x7FFAF2DF3E80
        public void .ctor(){} // RVA: 0x7FFAFA0C6A60
    }

    public class NetworkCallingEntrypointVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAFA0C6AC0
    }

    public class NetworkCallingParameter
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAF44189C0
        public void ValidateVersion(){} // RVA: 0x7FFAF2D8D310
        public void GetRootAsNetworkCallingParameter(){} // RVA: 0x7FFAFA0B7450 | overloaded x2
        public void __init(){} // RVA: 0x7FFAFA090560
        public void __assign(){} // RVA: 0x7FFAFA090630
        public void get_Type(){} // RVA: 0x7FFAFA0C59B0
        public void CreateNetworkCallingParameter(){} // RVA: 0x7FFAFA0C5A00
        public void StartNetworkCallingParameter(){} // RVA: 0x7FFAFA0BF310
        public void AddType(){} // RVA: 0x7FFAFA0C5AB0
        public void EndNetworkCallingParameter(){} // RVA: 0x7FFAFA0C5B20
        public void UnPack(){} // RVA: 0x7FFAFA0C5B70
        public void UnPackTo(){} // RVA: 0x7FFAFA0C5C10
        public void Pack(){} // RVA: 0x7FFAFA0C5C70
    }

    public class NetworkCallingParameterT
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAF2E575E0
        public void set_Type(){} // RVA: 0x7FFAF2E575F0
        public void .ctor(){} // RVA: 0x7FFAF316DA00
    }

    public class NetworkCallingParameterVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAFA0C5D30
    }

    public class NetworkCallingView
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAF44189C0
        public void ValidateVersion(){} // RVA: 0x7FFAF2D8D310
        public void GetRootAsNetworkCallingView(){} // RVA: 0x7FFAFA0B7450 | overloaded x2
        public void __init(){} // RVA: 0x7FFAFA090560
        public void __assign(){} // RVA: 0x7FFAFA090630
        public void get_ViewId(){} // RVA: 0x7FFAFA0C3160
        public void get_ComponentIndex(){} // RVA: 0x7FFAFA0C31B0
        public void Entrypoints(){} // RVA: 0x7FFAFA0C6C30
        public void get_EntrypointsLength(){} // RVA: 0x7FFAFA0BAFB0
        public void CreateNetworkCallingView(){} // RVA: 0x7FFAFA0C6DA0
        public void StartNetworkCallingView(){} // RVA: 0x7FFAFA0C6050
        public void AddViewId(){} // RVA: 0x7FFAFA0C3690
        public void AddComponentIndex(){} // RVA: 0x7FFAFA0C3700
        public void AddEntrypoints(){} // RVA: 0x7FFAFA0BB900
        public void CreateEntrypointsVector(){} // RVA: 0x7FFAFA0B7E30
        public void CreateEntrypointsVectorBlock(){} // RVA: 0x7FFAFA0C7110 | overloaded x3
        public void StartEntrypointsVector(){} // RVA: 0x7FFAFA0B81F0
        public void EndNetworkCallingView(){} // RVA: 0x7FFAFA0C71D0
        public void UnPack(){} // RVA: 0x7FFAFA0C7220
        public void UnPackTo(){} // RVA: 0x7FFAFA0C72D0
        public void Pack(){} // RVA: 0x7FFAFA0C7540
    }

    public class NetworkCallingViewT
    {
        // ── Methods ──
        public void get_ViewId(){} // RVA: 0x7FFAF2DDA5C0
        public void set_ViewId(){} // RVA: 0x7FFAF2D900C0
        public void get_ComponentIndex(){} // RVA: 0x7FFAF335BED0
        public void set_ComponentIndex(){} // RVA: 0x7FFAF335C660
        public void get_Entrypoints(){} // RVA: 0x7FFAF2D907C0
        public void set_Entrypoints(){} // RVA: 0x7FFAF2DF3E80
        public void .ctor(){} // RVA: 0x7FFAFA0C6A60
    }

    public class NetworkCallingViewVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAFA0C7820
    }

}