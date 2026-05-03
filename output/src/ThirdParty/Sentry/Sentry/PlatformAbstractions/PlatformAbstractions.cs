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
        public System.Collections.Generic.IReadOnlyDictionary`2<int,string> _netFxReleaseVersionMap;

        // ── Methods ──
        public void get_NetFxReleaseVersionMap(){} // RVA: 0x7FFE86F36CA0
        public void GetLatest(){} // RVA: 0x7FFE813240E0
        public void GetInstallations(){} // RVA: 0x7FFE86F36D00
        public void .cctor(){} // RVA: 0x7FFE86F36D40
    }

    public class FrameworkInstallation : Object
    {
        public string _shortName; // 0x10
        public System.Version _version; // 0x18
        public System.Nullable`1<int> _servicePack; // 0x20
        public System.Nullable`1<?..?> _profile; // 0x28
        public System.Nullable`1<int> _release; // 0x30

        // ── Methods ──
        public void get_ShortName(){} // RVA: 0x7FFE81116380
        public void set_ShortName(){} // RVA: 0x7FFE810FCE30
        public void get_Version(){} // RVA: 0x7FFE810FE7C0
        public void set_Version(){} // RVA: 0x7FFE81161E80
        public void get_ServicePack(){} // RVA: 0x7FFE811290C0
        public void set_ServicePack(){} // RVA: 0x7FFE81859C50
        public void get_Profile(){} // RVA: 0x7FFE81129130
        public void set_Profile(){} // RVA: 0x7FFE8164D390
        public void get_Release(){} // RVA: 0x7FFE8144E200
        public void set_Release(){} // RVA: 0x7FFE82D00170
        public void ToString(){} // RVA: 0x7FFE86F373B0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class FrameworkInstallationExtensions : Object
    {
        // ── Methods ──
        public void GetVersionNumber(){} // RVA: 0x7FFE86F37560
    }

    public class RuntimeInfo : Object
    {
        // ── Methods ──
        public void GetRuntime(){} // RVA: 0x7FFE86F37610
        public void WithAdditionalProperties(){} // RVA: 0x7FFE86F376C0
        public void Parse(){} // RVA: 0x7FFE86F378E0
        public void GetNetCoreVersion(){} // RVA: 0x7FFE86F37CC0
        public void GetFromRuntimeInformation(){} // RVA: 0x7FFE86F37E20
        public void GetFromMonoRuntime(){} // RVA: 0x7FFE86F37EB0
        public void GetFromEnvironmentVariable(){} // RVA: 0x7FFE86F380B0
        public void .cctor(){} // RVA: 0x7FFE86F382E0
        public void <GetNetCoreVersion>g__RemovePrefixOrNull|4_0(){} // RVA: 0x7FFE86F383C0
    }

    public class SentryRuntime : Object
    {
        public System.Lazy`1<Sentry.PlatformAbstractions.SentryRuntime> _currentRuntime;
        public string _name; // 0x10
        public string _version; // 0x18
        public string _raw; // 0x20
        public string _identifier; // 0x28

        // ── Methods ──
        public void get_Current(){} // RVA: 0x7FFE86F384F0
        public void get_Name(){} // RVA: 0x7FFE81116380
        public void get_Version(){} // RVA: 0x7FFE810FE7C0
        public void get_Raw(){} // RVA: 0x7FFE811290C0
        public void get_Identifier(){} // RVA: 0x7FFE81129130
        public void .ctor(){} // RVA: 0x7FFE81143A50
        public void ToString(){} // RVA: 0x7FFE86F38570
        public void Equals(){} // RVA: 0x7FFE86F38740 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE86F38940
        public void .cctor(){} // RVA: 0x7FFE86F38A20
    }

    public class SentryRuntimeExtensions : Object
    {
        // ── Methods ──
        public void IsNetFx(){} // RVA: 0x7FFE86F38B60
        public void IsNetCore(){} // RVA: 0x7FFE86F38BB0
        public void IsMono(){} // RVA: 0x7FFE86F38C50
        public void IsBrowserWasm(){} // RVA: 0x7FFE86F38CA0
        public void StartsWith(){} // RVA: 0x7FFE86F38D30
    }

}