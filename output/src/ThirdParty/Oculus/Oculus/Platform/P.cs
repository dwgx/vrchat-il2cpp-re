// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Oculus.Oculus.Platform
// Classes: 4
// Methods: 21

namespace ThirdParty.Oculus.Oculus.Platform
{
    public class Packet : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEAF1E0
        public void ReadBytes(){} // RVA: 0x7ADEAF2B0
        public void get_SenderID(){} // RVA: 0x7ADEAF410
        public void get_Size(){} // RVA: 0x7A80F2570
        public void get_Policy(){} // RVA: 0x7ADEAF4D0
        public void Finalize(){} // RVA: 0x7ADEAF590
        public void Dispose(){} // RVA: 0x7ADEAF6B0
    }

    public class Parties : Object
    {
        // ── Methods ──
        public void GetCurrent(){} // RVA: 0x7ADEC5820
        public void SetPartyUpdateNotificationCallback(){} // RVA: 0x7ADEC59D0
    }

    public class PlatformInternal : Object
    {
        // ── Methods ──
        public void CrashApplication(){} // RVA: 0x7ADEC7330
        public void ParseMessageHandle(){} // RVA: 0x7ADEC73D0
        public void InitializeStandaloneAsync(){} // RVA: 0x7ADEC8130
    }

    public class PlatformSettings : ScriptableObject
    {
        // ── Methods ──
        public void get_AppID(){} // RVA: 0x7ADEC8670
        public void set_AppID(){} // RVA: 0x7ADEC8690
        public void get_MobileAppID(){} // RVA: 0x7ADEC8700
        public void set_MobileAppID(){} // RVA: 0x7ADEC8720
        public void get_UseStandalonePlatform(){} // RVA: 0x7ADEC8790
        public void set_UseStandalonePlatform(){} // RVA: 0x7ADEC87B0
        public void get_Instance(){} // RVA: 0x7ADEC87E0
        public void set_Instance(){} // RVA: 0x7ADEC8AB0
        public void .ctor(){} // RVA: 0x7ADEC8B50
    }

}