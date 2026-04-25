// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.PlatformAbstractions
// Classes: 7
// Methods: 42

namespace ThirdParty.Sentry.Sentry.PlatformAbstractions
{
    public class DeviceInfo : Object
    {
    }

    public class FrameworkInfo : Object
    {
        public System.Collections.Generic.IReadOnlyDictionary`2<int,string> NetFxReleaseVersionMap;

        // ── Methods ──
        public void get_NetFxReleaseVersionMap(){} // RVA: 0x7FFAC8B8D620
        public void GetLatest(){} // RVA: 0x7FFAC34F9180
        public void GetInstallations(){} // RVA: 0x7FFAC8B8D680
        public void .cctor(){} // RVA: 0x7FFAC8B8D6C0
    }

    public class FrameworkInstallation : Object
    {
        public string ShortName; // 0x10
        public System.Version Version; // 0x18
        public System.Nullable`1<int> ServicePack; // 0x20
        public System.Nullable`1<0x6B19BD38> Profile; // 0x28
        public System.Nullable`1<int> Release; // 0x30

        // ── Methods ──
        public void get_ShortName(){} // RVA: 0x7FFAC2F3C380
        public void set_ShortName(){} // RVA: 0x7FFAC2F22E30
        public void get_Version(){} // RVA: 0x7FFAC2F247C0
        public void set_Version(){} // RVA: 0x7FFAC2F87E80
        public void get_ServicePack(){} // RVA: 0x7FFAC2F4F0C0
        public void set_ServicePack(){} // RVA: 0x7FFAC370BEE0
        public void get_Profile(){} // RVA: 0x7FFAC2F4F130
        public void set_Profile(){} // RVA: 0x7FFAC33D3BF0
        public void get_Release(){} // RVA: 0x7FFAC31D95E0
        public void set_Release(){} // RVA: 0x7FFAC4A98000
        public void ToString(){} // RVA: 0x7FFAC8B8DD30
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class FrameworkInstallationExtensions : Object
    {
        // ── Methods ──
        public void GetVersionNumber(){} // RVA: 0x7FFAC8B8DEE0
    }

    public class RuntimeInfo : Object
    {
        public System.Text.RegularExpressions.Regex RuntimeParseRegex;

        // ── Methods ──
        public void GetRuntime(){} // RVA: 0x7FFAC8B8DF90
        public void WithAdditionalProperties(){} // RVA: 0x7FFAC8B8E040
        public void Parse(){} // RVA: 0x7FFAC8B8E260
        public void GetNetCoreVersion(){} // RVA: 0x7FFAC8B8E640
        public void GetFromRuntimeInformation(){} // RVA: 0x7FFAC8B8E7A0
        public void GetFromMonoRuntime(){} // RVA: 0x7FFAC8B8E830
        public void GetFromEnvironmentVariable(){} // RVA: 0x7FFAC8B8EA30
        public void .cctor(){} // RVA: 0x7FFAC8B8EC60
        public void <GetNetCoreVersion>g__RemovePrefixOrNull|4_0(){} // RVA: 0x7FFAC8B8ED40
    }

    public class SentryRuntime : Object
    {
        public System.Lazy`1<Sentry.PlatformAbstractions.SentryRuntime> Current;
        public string Name; // 0x10
        public string Version; // 0x18
        public string Raw; // 0x20
        public string Identifier; // 0x28

        // ── Methods ──
        public void get_Current(){} // RVA: 0x7FFAC8B8EE70
        public void get_Name(){} // RVA: 0x7FFAC2F3C380
        public void get_Version(){} // RVA: 0x7FFAC2F247C0
        public void get_Raw(){} // RVA: 0x7FFAC2F4F0C0
        public void get_Identifier(){} // RVA: 0x7FFAC2F4F130
        public void .ctor(){} // RVA: 0x7FFAC2F69A50
        public void ToString(){} // RVA: 0x7FFAC8B8EEF0
        public void Equals(){} // RVA: 0x7FFAC8B8F0C0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC8B8F2C0
        public void .cctor(){} // RVA: 0x7FFAC8B8F3A0
    }

    public class SentryRuntimeExtensions : Object
    {
        // ── Methods ──
        public void IsNetFx(){} // RVA: 0x7FFAC8B8F4E0
        public void IsNetCore(){} // RVA: 0x7FFAC8B8F530
        public void IsMono(){} // RVA: 0x7FFAC8B8F5D0
        public void IsBrowserWasm(){} // RVA: 0x7FFAC8B8F620
        public void StartsWith(){} // RVA: 0x7FFAC8B8F6B0
    }

}