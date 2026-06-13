// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Oculus.Oculus.Platform
// Classes: 4
// Methods: 21

namespace ThirdParty.Oculus.Oculus.Platform
{
    public class Packet
    {
        public ulong size; // 0x10
        public UIntPtr packetHandle; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x60C2F20
        public void ReadBytes(){} // RVA: 0x60C2FF0
        public void get_SenderID(){} // RVA: 0x60C3150
        public void get_Size(){} // RVA: 0x2F8380
        public void get_Policy(){} // RVA: 0x60C3210
        public void Finalize(){} // RVA: 0x60C32D0
        public void Dispose(){} // RVA: 0x60C33F0
    }

    public class Parties
    {
        // ── Methods ──
        public void GetCurrent(){} // RVA: 0x60D9530
        public void SetPartyUpdateNotificationCallback(){} // RVA: 0x60D96E0
    }

    public class PlatformInternal
    {
        // ── Methods ──
        public void CrashApplication(){} // RVA: 0x60DB040
        public void ParseMessageHandle(){} // RVA: 0x60DB0E0
        public void InitializeStandaloneAsync(){} // RVA: 0x60DBE40
    }

    public class PlatformSettings
    {
        public string ovrAppID; // 0x18
        public string ovrMobileAppID; // 0x20
        public bool ovrUseStandalonePlatform; // 0x28
        public Oculus.Platform.PlatformSettings instance;

        // ── Methods ──
        public void get_AppID(){} // RVA: 0x60DC380
        public void set_AppID(){} // RVA: 0x60DC3A0
        public void get_MobileAppID(){} // RVA: 0x60DC410
        public void set_MobileAppID(){} // RVA: 0x60DC430
        public void get_UseStandalonePlatform(){} // RVA: 0x60DC4A0
        public void set_UseStandalonePlatform(){} // RVA: 0x60DC4C0
        public void get_Instance(){} // RVA: 0x60DC4F0
        public void set_Instance(){} // RVA: 0x60DC7C0
        public void .ctor(){} // RVA: 0x60DC860
    }

}