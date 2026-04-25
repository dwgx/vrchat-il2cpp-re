// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Oculus.Oculus.Platform
// Classes: 4
// Methods: 21

namespace ThirdParty.Oculus.Oculus.Platform
{
    public class Packet : Object
    {
        public ulong SenderID; // 0x10
        public UIntPtr Size; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC885A600
        public void ReadBytes(){} // RVA: 0x7FFAC885A6D0
        public void get_SenderID(){} // RVA: 0x7FFAC885A830
        public void get_Size(){} // RVA: 0x7FFAC2F3C380
        public void get_Policy(){} // RVA: 0x7FFAC885A8F0
        public void Finalize(){} // RVA: 0x7FFAC885A9B0
        public void Dispose(){} // RVA: 0x7FFAC885AAD0
    }

    public class Parties : Object
    {
        // ── Methods ──
        public void GetCurrent(){} // RVA: 0x7FFAC8870C10
        public void SetPartyUpdateNotificationCallback(){} // RVA: 0x7FFAC8870DC0
    }

    public class PlatformInternal : Object
    {
        // ── Methods ──
        public void CrashApplication(){} // RVA: 0x7FFAC8872720
        public void ParseMessageHandle(){} // RVA: 0x7FFAC88727C0
        public void InitializeStandaloneAsync(){} // RVA: 0x7FFAC8873520
    }

    public class PlatformSettings : ScriptableObject
    {
        public string AppID; // 0x18
        public string MobileAppID; // 0x20
        public bool UseStandalonePlatform; // 0x28
        public Oculus.Platform.PlatformSettings Instance;

        // ── Methods ──
        public void get_AppID(){} // RVA: 0x7FFAC8873A60
        public void set_AppID(){} // RVA: 0x7FFAC8873A80
        public void get_MobileAppID(){} // RVA: 0x7FFAC8873AF0
        public void set_MobileAppID(){} // RVA: 0x7FFAC8873B10
        public void get_UseStandalonePlatform(){} // RVA: 0x7FFAC8873B80
        public void set_UseStandalonePlatform(){} // RVA: 0x7FFAC8873BA0
        public void get_Instance(){} // RVA: 0x7FFAC8873BD0
        public void set_Instance(){} // RVA: 0x7FFAC8873EA0
        public void .ctor(){} // RVA: 0x7FFAC8873F40
    }

}