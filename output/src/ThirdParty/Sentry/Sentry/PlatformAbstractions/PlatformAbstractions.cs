// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.PlatformAbstractions
// Classes: 6
// Methods: 41

namespace ThirdParty.Sentry.Sentry.PlatformAbstractions
{
    public class FrameworkInfo : Object
    {
        // ── Methods ──
        public void get_NetFxReleaseVersionMap(){} // RVA: 0x7AE1E3E30
        public void GetLatest(){} // RVA: 0x7A82D1450
        public void GetInstallations(){} // RVA: 0x7AE1E3E90
        public void .cctor(){} // RVA: 0x7AE1E3ED0
    }

    public class FrameworkInstallation : Object
    {
        // ── Methods ──
        public void get_ShortName(){} // RVA: 0x7A80F2570
        public void set_ShortName(){} // RVA: 0x7A80D8E20
        public void get_Version(){} // RVA: 0x7A80DA7B0
        public void set_Version(){} // RVA: 0x7A813E420
        public void get_ServicePack(){} // RVA: 0x7A81052C0
        public void set_ServicePack(){} // RVA: 0x7A8884B10
        public void get_Profile(){} // RVA: 0x7A8105330
        public void set_Profile(){} // RVA: 0x7A8669350
        public void get_Release(){} // RVA: 0x7A83F69F0
        public void set_Release(){} // RVA: 0x7A9D7F900
        public void ToString(){} // RVA: 0x7AE1E4540
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class FrameworkInstallationExtensions : Object
    {
        // ── Methods ──
        public void GetVersionNumber(){} // RVA: 0x7AE1E46F0
    }

    public class RuntimeInfo : Object
    {
        // ── Methods ──
        public void GetRuntime(){} // RVA: 0x7AE1E47A0
        public void WithAdditionalProperties(){} // RVA: 0x7AE1E4850
        public void Parse(){} // RVA: 0x7AE1E4A70
        public void GetNetCoreVersion(){} // RVA: 0x7AE1E4E60
        public void GetFromRuntimeInformation(){} // RVA: 0x7AE1E4FC0
        public void GetFromMonoRuntime(){} // RVA: 0x7AE1E5050
        public void GetFromEnvironmentVariable(){} // RVA: 0x7AE1E5250
        public void .cctor(){} // RVA: 0x7AE1E5490
        public void <GetNetCoreVersion>g__RemovePrefixOrNull|4_0(){} // RVA: 0x7AE1E5570
    }

    public class SentryRuntime : Object
    {
        // ── Methods ──
        public void get_Current(){} // RVA: 0x7AE1E56A0
        public void get_Name(){} // RVA: 0x7A80F2570
        public void get_Version(){} // RVA: 0x7A80DA7B0
        public void get_Raw(){} // RVA: 0x7A81052C0
        public void get_Identifier(){} // RVA: 0x7A8105330
        public void .ctor(){} // RVA: 0x7A811FE30
        public void ToString(){} // RVA: 0x7AE1E5720
        public void Equals(){} // RVA: 0x7AE1E58F0
        public void GetHashCode(){} // RVA: 0x7AE1E5A00
        public void .cctor(){} // RVA: 0x7AE1E5AE0
    }

    public class SentryRuntimeExtensions : Object
    {
        // ── Methods ──
        public void IsNetFx(){} // RVA: 0x7AE1E5C20
        public void IsNetCore(){} // RVA: 0x7AE1E5C70
        public void IsMono(){} // RVA: 0x7AE1E5D10
        public void IsBrowserWasm(){} // RVA: 0x7AE1E5D60
        public void StartsWith(){} // RVA: 0x7AE1E5DF0
    }

}