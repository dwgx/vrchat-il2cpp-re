// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Oculus.Oculus.Platform
// Classes: 4
// Methods: 21

namespace ThirdParty.Oculus.Oculus.Platform
{
    public class Packet : Object
    {
        public object size;
        public object packetHandle;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B363A0
        public void ReadBytes(){} // RVA: 0x6B36470
        public void get_SenderID(){} // RVA: 0x6B365D0
        public void get_Size(){} // RVA: 0xB5DBF0
        public void get_Policy(){} // RVA: 0x6B36690
        public void Finalize(){} // RVA: 0x6B36750
        public void Dispose(){} // RVA: 0x6B36870
    }

    public class Parties : Object
    {
        // ── Methods ──
        public void GetCurrent(){} // RVA: 0x6B4C9E0
        public void SetPartyUpdateNotificationCallback(){} // RVA: 0x6B4CB90
    }

    public class PlatformInternal : Object
    {
        // ── Methods ──
        public void CrashApplication(){} // RVA: 0x6B4E4F0
        public void ParseMessageHandle(){} // RVA: 0x6B4E590
        public void InitializeStandaloneAsync(){} // RVA: 0x6B4F2F0
    }

    public class PlatformSettings : ScriptableObject
    {
        public object ovrAppID;
        public object ovrMobileAppID;
        public object ovrUseStandalonePlatform;
        public object instance;

        // ── Methods ──
        public void get_AppID(){} // RVA: 0x6B4F870
        public void set_AppID(){} // RVA: 0x6B4F890
        public void get_MobileAppID(){} // RVA: 0x6B4F900
        public void set_MobileAppID(){} // RVA: 0x6B4F920
        public void get_UseStandalonePlatform(){} // RVA: 0x6B4F990
        public void set_UseStandalonePlatform(){} // RVA: 0x6B4F9B0
        public void get_Instance(){} // RVA: 0x6B4F9E0
        public void set_Instance(){} // RVA: 0x6B4FCB0
        public void .ctor(){} // RVA: 0x6B4FD50
    }

}