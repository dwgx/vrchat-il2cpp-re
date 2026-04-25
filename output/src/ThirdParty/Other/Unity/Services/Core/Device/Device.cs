// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Services.Core.Device
// Classes: 4
// Methods: 13

namespace ThirdParty.Other.Unity.Services.Core.Device
{
    public class IUserIdentifierProvider
    {
        public object UserId;

        // ── Methods ──
        public void get_UserId(){} // RVA: 0x7FFD4E078E90
        public void set_UserId(){} // RVA: 0x7FFD4E090A40
    }

    public class InstallationId : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54B11020
        public void CreateIdentifier(){} // RVA: 0x7FFD54B11140
        public void ReadIdentifierFromFile(){} // RVA: 0x7FFD54B11440
        public void WriteIdentifierToFile(){} // RVA: 0x7FFD54B11480
        public void GenerateGuid(){} // RVA: 0x7FFD54B11500
    }

    public class UnityAdsIdentifier : Object
    {
        public object UserId;

        // ── Methods ──
        public void get_UserId(){} // RVA: 0x7FFD4E919180
        public void set_UserId(){} // RVA: 0x7FFD4E341310
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class UnityAnalyticsIdentifier : Object
    {
        public object UserId;

        // ── Methods ──
        public void get_UserId(){} // RVA: 0x7FFD54B11590
        public void set_UserId(){} // RVA: 0x7FFD54B115D0
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

}