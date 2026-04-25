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
        public void get_UserId(){} // RVA: 0x7FFAC2C58E90
        public void set_UserId(){} // RVA: 0x7FFAC2C70A40
    }

    public class InstallationId : Object
    {
        public string Identifier; // 0x10
        public Unity.Services.Core.Device.IUserIdentifierProvider UnityAdsIdentifierProvider; // 0x18
        public Unity.Services.Core.Device.IUserIdentifierProvider UnityAnalyticsIdentifierProvider; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC96F1020
        public void CreateIdentifier(){} // RVA: 0x7FFAC96F1140
        public void ReadIdentifierFromFile(){} // RVA: 0x7FFAC96F1440
        public void WriteIdentifierToFile(){} // RVA: 0x7FFAC96F1480
        public void GenerateGuid(){} // RVA: 0x7FFAC96F1500
    }

    public class UnityAdsIdentifier : Object
    {
        public object UserId;

        // ── Methods ──
        public void get_UserId(){} // RVA: 0x7FFAC34F9180
        public void set_UserId(){} // RVA: 0x7FFAC2F21310
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class UnityAnalyticsIdentifier : Object
    {
        public object UserId;

        // ── Methods ──
        public void get_UserId(){} // RVA: 0x7FFAC96F1590
        public void set_UserId(){} // RVA: 0x7FFAC96F15D0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

}