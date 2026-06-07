// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.PlatformAbstractions
// Classes: 7
// Methods: 42

namespace ThirdParty.Sentry.Sentry.PlatformAbstractions
{
    public class DeviceInfo
    {
    }

    public class FrameworkInfo
    {
        public object ShortName;

        // ── Methods ──
        public void get_NetFxReleaseVersionMap(){} // RVA: 0x63F62A0
        public void GetLatest(){} // RVA: 0x519240
        public void GetInstallations(){} // RVA: 0x63F6300
        public void .cctor(){} // RVA: 0x63F6340
    }

    public class FrameworkInstallation
    {
        // ── Methods ──
        public void get_ShortName(){} // RVA: 0x2F8380
        public void set_ShortName(){} // RVA: 0x2DEE30
        public void get_Version(){} // RVA: 0x2E07C0
        public void set_Version(){} // RVA: 0x343E80
        public void get_ServicePack(){} // RVA: 0x30B0C0
        public void set_ServicePack(){} // RVA: 0xAE83A0
        public void get_Profile(){} // RVA: 0x30B130
        public void set_Profile(){} // RVA: 0x8AC650
        public void get_Release(){} // RVA: 0x6374D0
        public void set_Release(){} // RVA: 0x1F74DF0
        public void ToString(){} // RVA: 0x63F69B0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class FrameworkInstallationExtensions
    {
        // ── Methods ──
        public void GetVersionNumber(){} // RVA: 0x63F6B60
    }

    public class RuntimeInfo
    {
        // ── Methods ──
        public void GetRuntime(){} // RVA: 0x63F6C10
        public void WithAdditionalProperties(){} // RVA: 0x63F6CC0
        public void Parse(){} // RVA: 0x63F6EE0
        public void GetNetCoreVersion(){} // RVA: 0x63F72C0
        public void GetFromRuntimeInformation(){} // RVA: 0x63F7420
        public void GetFromMonoRuntime(){} // RVA: 0x63F74B0
        public void GetFromEnvironmentVariable(){} // RVA: 0x63F76B0
        public void .cctor(){} // RVA: 0x63F78E0
        public void <GetNetCoreVersion>g__RemovePrefixOrNull|4_0(){} // RVA: 0x63F79C0
    }

    public class SentryRuntime
    {
        // ── Methods ──
        public void get_Current(){} // RVA: 0x63F7AF0
        public void get_Name(){} // RVA: 0x2F8380
        public void get_Version(){} // RVA: 0x2E07C0
        public void get_Raw(){} // RVA: 0x30B0C0
        public void get_Identifier(){} // RVA: 0x30B130
        public void .ctor(){} // RVA: 0x325A50
        public void ToString(){} // RVA: 0x63F7B70
        public void Equals(){} // RVA: 0x63F7D40 | overloaded x2
        public void GetHashCode(){} // RVA: 0x63F7F40
        public void .cctor(){} // RVA: 0x63F8020
    }

    public class SentryRuntimeExtensions
    {
        // ── Methods ──
        public void IsNetFx(){} // RVA: 0x63F8160
        public void IsNetCore(){} // RVA: 0x63F81B0
        public void IsMono(){} // RVA: 0x63F8250
        public void IsBrowserWasm(){} // RVA: 0x63F82A0
        public void StartsWith(){} // RVA: 0x63F8330
    }

}