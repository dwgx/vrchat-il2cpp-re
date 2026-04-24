// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.PlatformAbstractions
// Classes: 2
// Methods: 20

namespace ThirdParty.Sentry.Sentry.PlatformAbstractions
{
    public class RuntimeInfo : Object
    {
        // ── Original Methods ──
        public void WithAdditionalProperties(){} // RVA: 0x7ffaae5af240
        public void Parse(){} // RVA: 0x7ffaae5af460
        public void .cctor(){} // RVA: 0x7ffaae5afe60
        public void <GetNetCoreVersion>g__RemovePrefixOrNull|4_0(){} // RVA: 0x7ffaae5aff40
        // ── Binary Analysis Named ──
        public void GetRuntime(){} // RVA: 0x7ffaae5af190
        public void GetNetCoreVersion(){} // RVA: 0x7ffaae5af840
        public void GetFromRuntimeInformation(){} // RVA: 0x7ffaae5af9a0
        public void GetFromMonoRuntime(){} // RVA: 0x7ffaae5afa30
        public void GetFromEnvironmentVariable(){} // RVA: 0x7ffaae5afc30
    }

    public class SentryRuntime : Object
    {
        public object _version; // 0x34DE8BB0, was: <Version>k__BackingField

        // ── Original Methods ──
        public void get_Current(){} // RVA: 0x7ffaae5b0070
        public void get_Name(){} // RVA: 0x7ffaa894d380
        public void get_Version(){} // RVA: 0x7ffaa89357c0
        public void get_Raw(){} // RVA: 0x7ffaa89600c0
        public void get_Identifier(){} // RVA: 0x7ffaa8960130
        public void .ctor(){} // RVA: 0x7ffaa897aa50
        public void ToString(){} // RVA: 0x7ffaae5b00f0
        public void Equals(){} // RVA: 0x7ffaae5b02c0
        public void Equals(){} // RVA: 0x7ffaae5b02c0
        public void .cctor(){} // RVA: 0x7ffaae5b05a0
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaae5b04c0
    }

}