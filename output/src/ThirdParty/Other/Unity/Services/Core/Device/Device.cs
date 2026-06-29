// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Services.Core.Device
// Classes: 4
// Methods: 13

namespace ThirdParty.Other.Unity.Services.Core.Device
{
    public class IUserIdentifierProvider
    {
        // ── Methods ──
        public void get_UserId(){} // RVA: 0x87C0A0
        public void set_UserId(){} // RVA: 0x894320
    }

    public class InstallationId : Object
    {
        public object Identifier;
        public object UnityAdsIdentifierProvider;
        public object UnityAnalyticsIdentifierProvider;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x79A32B0
        public void CreateIdentifier(){} // RVA: 0x79A33D0
        public void ReadIdentifierFromFile(){} // RVA: 0x79A3710
        public void WriteIdentifierToFile(){} // RVA: 0x79A3780
        public void GenerateGuid(){} // RVA: 0x79A3800
    }

    public class UnityAdsIdentifier : Object
    {
        // ── Methods ──
        public void get_UserId(){} // RVA: 0xDAC980
        public void set_UserId(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0xB43310
    }

    public class UnityAnalyticsIdentifier : Object
    {
        // ── Methods ──
        public void get_UserId(){} // RVA: 0x79A38A0
        public void set_UserId(){} // RVA: 0x79A3910
        public void .ctor(){} // RVA: 0xB43310
    }

}