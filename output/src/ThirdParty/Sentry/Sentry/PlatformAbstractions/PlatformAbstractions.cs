// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.PlatformAbstractions
// Classes: 2
// Methods: 20

namespace ThirdParty.Sentry.Sentry.PlatformAbstractions
{
    public class RuntimeInfo : Object
    {
        public tor.neStore RuntimeParseRegex;

        // ── Methods ──
        public void GetRuntime(){} // RVA: 0x7FFD53FADF90
        public void WithAdditionalProperties(){} // RVA: 0x7FFD53FAE040
        public void Parse(){} // RVA: 0x7FFD53FAE260
        public void GetNetCoreVersion(){} // RVA: 0x7FFD53FAE640
        public void GetFromRuntimeInformation(){} // RVA: 0x7FFD53FAE7A0
        public void GetFromMonoRuntime(){} // RVA: 0x7FFD53FAE830
        public void GetFromEnvironmentVariable(){} // RVA: 0x7FFD53FAEA30
        public void .cctor(){} // RVA: 0x7FFD53FAEC60
        public void <GetNetCoreVersion>g__RemovePrefixOrNull|4_0(){} // RVA: 0x7FFD53FAED40
    }

    public class SentryRuntime : Object
    {
        public dle<s.ureClient> Current;
        public string Name; // 0x10
        public string Version; // 0x18
        public string Raw; // 0x20
        public string Identifier; // 0x28

        // ── Methods ──
        public void get_Current(){} // RVA: 0x7FFD53FAEE70
        public void get_Name(){} // RVA: 0x7FFD4E35C380
        public void get_Version(){} // RVA: 0x7FFD4E3447C0
        public void get_Raw(){} // RVA: 0x7FFD4E36F0C0
        public void get_Identifier(){} // RVA: 0x7FFD4E36F130
        public void .ctor(){} // RVA: 0x7FFD4E389A50
        public void ToString(){} // RVA: 0x7FFD53FAEEF0
        public void Equals(){} // RVA: 0x7FFD53FAF0C0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD53FAF2C0
        public void .cctor(){} // RVA: 0x7FFD53FAF3A0
    }

}