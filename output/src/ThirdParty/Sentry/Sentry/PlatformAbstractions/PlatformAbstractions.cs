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
        public void get_NetFxReleaseVersionMap(){} // RVA: 0x7FFAF8EA62A0
        public void GetLatest(){} // RVA: 0x7FFAF2FC9240
        public void GetInstallations(){} // RVA: 0x7FFAF8EA6300
        public void .cctor(){} // RVA: 0x7FFAF8EA6340
    }

    public class FrameworkInstallation
    {
        // ── Methods ──
        public void get_ShortName(){} // RVA: 0x7FFAF2DA8380
        public void set_ShortName(){} // RVA: 0x7FFAF2D8EE30
        public void get_Version(){} // RVA: 0x7FFAF2D907C0
        public void set_Version(){} // RVA: 0x7FFAF2DF3E80
        public void get_ServicePack(){} // RVA: 0x7FFAF2DBB0C0
        public void set_ServicePack(){} // RVA: 0x7FFAF35983A0
        public void get_Profile(){} // RVA: 0x7FFAF2DBB130
        public void set_Profile(){} // RVA: 0x7FFAF335C650
        public void get_Release(){} // RVA: 0x7FFAF30E74D0
        public void set_Release(){} // RVA: 0x7FFAF4A24DF0
        public void ToString(){} // RVA: 0x7FFAF8EA69B0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class FrameworkInstallationExtensions
    {
        // ── Methods ──
        public void GetVersionNumber(){} // RVA: 0x7FFAF8EA6B60
    }

    public class RuntimeInfo
    {
        // ── Methods ──
        public void GetRuntime(){} // RVA: 0x7FFAF8EA6C10
        public void WithAdditionalProperties(){} // RVA: 0x7FFAF8EA6CC0
        public void Parse(){} // RVA: 0x7FFAF8EA6EE0
        public void GetNetCoreVersion(){} // RVA: 0x7FFAF8EA72C0
        public void GetFromRuntimeInformation(){} // RVA: 0x7FFAF8EA7420
        public void GetFromMonoRuntime(){} // RVA: 0x7FFAF8EA74B0
        public void GetFromEnvironmentVariable(){} // RVA: 0x7FFAF8EA76B0
        public void .cctor(){} // RVA: 0x7FFAF8EA78E0
        public void <GetNetCoreVersion>g__RemovePrefixOrNull|4_0(){} // RVA: 0x7FFAF8EA79C0
    }

    public class SentryRuntime
    {
        // ── Methods ──
        public void get_Current(){} // RVA: 0x7FFAF8EA7AF0
        public void get_Name(){} // RVA: 0x7FFAF2DA8380
        public void get_Version(){} // RVA: 0x7FFAF2D907C0
        public void get_Raw(){} // RVA: 0x7FFAF2DBB0C0
        public void get_Identifier(){} // RVA: 0x7FFAF2DBB130
        public void .ctor(){} // RVA: 0x7FFAF2DD5A50
        public void ToString(){} // RVA: 0x7FFAF8EA7B70
        public void Equals(){} // RVA: 0x7FFAF8EA7D40 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF8EA7F40
        public void .cctor(){} // RVA: 0x7FFAF8EA8020
    }

    public class SentryRuntimeExtensions
    {
        // ── Methods ──
        public void IsNetFx(){} // RVA: 0x7FFAF8EA8160
        public void IsNetCore(){} // RVA: 0x7FFAF8EA81B0
        public void IsMono(){} // RVA: 0x7FFAF8EA8250
        public void IsBrowserWasm(){} // RVA: 0x7FFAF8EA82A0
        public void StartsWith(){} // RVA: 0x7FFAF8EA8330
    }

}