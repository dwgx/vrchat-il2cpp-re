// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.PlatformAbstractions
// Classes: 6
// Methods: 41

namespace ThirdParty.Sentry.Sentry.PlatformAbstractions
{
    public class FrameworkInfo : Object
    {
        public object _netFxReleaseVersionMap;

        // ── Methods ──
        public void get_NetFxReleaseVersionMap(){} // RVA: 0x6E669F0
        public void GetLatest(){} // RVA: 0xDAC980
        public void GetInstallations(){} // RVA: 0x6E66A50
        public void .cctor(){} // RVA: 0x6E66A90
    }

    public class FrameworkInstallation : Object
    {
        public object _shortName;
        public object _version;
        public object _servicePack;
        public object _profile;
        public object _release;

        // ── Methods ──
        public void get_ShortName(){} // RVA: 0xB5DBF0
        public void set_ShortName(){} // RVA: 0xB44D60
        public void get_Version(){} // RVA: 0xB465B0
        public void set_Version(){} // RVA: 0xBA9BA0
        public void get_ServicePack(){} // RVA: 0xB700F0
        public void set_ServicePack(){} // RVA: 0x13B3F80
        public void get_Profile(){} // RVA: 0xB70160
        public void set_Profile(){} // RVA: 0x116B360
        public void get_Release(){} // RVA: 0xD33E60
        public void set_Release(){} // RVA: 0x27FA7C0
        public void ToString(){} // RVA: 0x6E67100
        public void .ctor(){} // RVA: 0xB43310
    }

    public class FrameworkInstallationExtensions : Object
    {
        // ── Methods ──
        public void GetVersionNumber(){} // RVA: 0x6E672A0
    }

    public class RuntimeInfo : Object
    {
        public object RuntimeParseRegex;

        // ── Methods ──
        public void GetRuntime(){} // RVA: 0x6E67350
        public void WithAdditionalProperties(){} // RVA: 0x6E67400
        public void Parse(){} // RVA: 0x6E67620
        public void GetNetCoreVersion(){} // RVA: 0x6E67A00
        public void GetFromRuntimeInformation(){} // RVA: 0x6E67B60
        public void GetFromMonoRuntime(){} // RVA: 0x6E67BF0
        public void GetFromEnvironmentVariable(){} // RVA: 0x6E67DC0
        public void .cctor(){} // RVA: 0x6E68000
        public void <GetNetCoreVersion>g__RemovePrefixOrNull|4_0(){} // RVA: 0x6E680E0
    }

    public class SentryRuntime : Object
    {
        public object _currentRuntime;
        public object _name;
        public object _version;
        public object _raw;
        public object _identifier;

        // ── Methods ──
        public void get_Current(){} // RVA: 0x6E68210
        public void get_Name(){} // RVA: 0xB5DBF0
        public void get_Version(){} // RVA: 0xB465B0
        public void get_Raw(){} // RVA: 0xB700F0
        public void get_Identifier(){} // RVA: 0xB70160
        public void .ctor(){} // RVA: 0xB8AE10
        public void ToString(){} // RVA: 0x6E68290
        public void Equals(){} // RVA: 0x6E68460
        public void GetHashCode(){} // RVA: 0x6E68560
        public void .cctor(){} // RVA: 0x6E68640
    }

    public class SentryRuntimeExtensions : Object
    {
        // ── Methods ──
        public void IsNetFx(){} // RVA: 0x6E68780
        public void IsNetCore(){} // RVA: 0x6E687D0
        public void IsMono(){} // RVA: 0x6E68870
        public void IsBrowserWasm(){} // RVA: 0x6E688C0
        public void StartsWith(){} // RVA: 0x6E68950
    }

}