// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Oculus.Oculus.Platform
// Classes: 4
// Methods: 21

namespace ThirdParty.Oculus.Oculus.Platform
{
    public class Packet : Object
    {
        public ulong size; // 0x10
        public UIntPtr packetHandle; // 0x18
        public object field_2; // 0x6

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86C03CF0
        public void ReadBytes(){} // RVA: 0x7FFE86C03DC0
        public void get_SenderID(){} // RVA: 0x7FFE86C03F20
        public void get_Size(){} // RVA: 0x7FFE81116380
        public void get_Policy(){} // RVA: 0x7FFE86C03FE0
        public void Finalize(){} // RVA: 0x7FFE86C040A0
        public void Dispose(){} // RVA: 0x7FFE86C041C0
    }

    public class Parties : Object
    {
        // ── Methods ──
        public void GetCurrent(){} // RVA: 0x7FFE86C1A300
        public void SetPartyUpdateNotificationCallback(){} // RVA: 0x7FFE86C1A4B0
    }

    public class PlatformInternal : Object
    {
        // ── Methods ──
        public void CrashApplication(){} // RVA: 0x7FFE86C1BE10
        public void ParseMessageHandle(){} // RVA: 0x7FFE86C1BEB0
        public void InitializeStandaloneAsync(){} // RVA: 0x7FFE86C1CC10
    }

    public class PlatformSettings : ScriptableObject
    {
        public string ovrAppID; // 0x18
        public string ovrMobileAppID; // 0x20
        public bool ovrUseStandalonePlatform; // 0x28
        public Oculus.Platform.PlatformSettings instance;

        // ── Methods ──
        public void get_AppID(){} // RVA: 0x7FFE86C1D150
        public void set_AppID(){} // RVA: 0x7FFE86C1D170
        public void get_MobileAppID(){} // RVA: 0x7FFE86C1D1E0
        public void set_MobileAppID(){} // RVA: 0x7FFE86C1D200
        public void get_UseStandalonePlatform(){} // RVA: 0x7FFE86C1D270
        public void set_UseStandalonePlatform(){} // RVA: 0x7FFE86C1D290
        public void get_Instance(){} // RVA: 0x7FFE86C1D2C0
        public void set_Instance(){} // RVA: 0x7FFE86C1D590
        public void .ctor(){} // RVA: 0x7FFE86C1D630
    }

}