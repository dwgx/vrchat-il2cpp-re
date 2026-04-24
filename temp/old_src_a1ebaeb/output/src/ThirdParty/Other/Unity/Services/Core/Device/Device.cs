// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Services.Core.Device
// Classes: 4
// Methods: 13

namespace ThirdParty.Other.Unity.Services.Core.Device
{
    public class IUserIdentifierProvider
    {
        // ── Original Methods ──
        public void get_UserId(){} // RVA: 0x7ffaa86491d0
        public void set_UserId(){} // RVA: 0x7ffaa8660d80
    }

    public class InstallationId : Object
    {
        public object UnityAnalyticsIdentifierProvider; // 0x33AB60F0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf113000
        public void CreateIdentifier(){} // RVA: 0x7ffaaf113120
        public void ReadIdentifierFromFile(){} // RVA: 0x7ffaaf113420
        public void WriteIdentifierToFile(){} // RVA: 0x7ffaaf113460
        public void GenerateGuid(){} // RVA: 0x7ffaaf1134e0
    }

    public class UnityAdsIdentifier : Object
    {
        // ── Original Methods ──
        public void get_UserId(){} // RVA: 0x7ffaa8f22da0
        public void set_UserId(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class UnityAnalyticsIdentifier : Object
    {
        // ── Original Methods ──
        public void get_UserId(){} // RVA: 0x7ffaaf113570
        public void set_UserId(){} // RVA: 0x7ffaaf1135b0
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

}