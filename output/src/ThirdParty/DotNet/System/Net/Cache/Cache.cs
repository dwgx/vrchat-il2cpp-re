// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net.Cache
// Classes: 7
// Methods: 14

namespace ThirdParty.DotNet.System.Net.Cache
{
    public class RequestCache : Object
    {
        public char[] LineSplits;
        public bool _IsPrivateCache; // 0x10
        public bool _CanWrite; // 0x11

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC932D0C0
    }

    public class RequestCacheBinding : Object
    {
        public System.Net.Cache.RequestCache Cache; // 0x10
        public System.Net.Cache.RequestCacheValidator Validator; // 0x18
        public System.Net.Cache.RequestCachePolicy Policy; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC3000E00
        public void get_Cache(){} // RVA: 0x7FFAC2F3C380
        public void get_Validator(){} // RVA: 0x7FFAC2F247C0
        public void get_Policy(){} // RVA: 0x7FFAC2F4F0C0
    }

    public class RequestCacheManager : Object
    {
        public System.Net.Cache.RequestCachingSectionInternal s_CacheConfigSettings;
        public System.Net.Cache.RequestCacheBinding s_BypassCacheBinding; // 0x8
        public System.Net.Cache.RequestCacheBinding s_DefaultGlobalBinding; // 0x10
        public System.Net.Cache.RequestCacheBinding s_DefaultHttpBinding; // 0x18
        public System.Net.Cache.RequestCacheBinding s_DefaultFtpBinding; // 0x20

        // ── Methods ──
        public void GetBinding(){} // RVA: 0x7FFAC932D1B0
        public void LoadConfigSettings(){} // RVA: 0x7FFAC932D420
        public void .cctor(){} // RVA: 0x7FFAC932D680
    }

    public class RequestCachePolicy : Object
    {
        public 0x6B1400B8 Level; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC932D8A0
        public void get_Level(){} // RVA: 0x7FFAC2F6E5C0
        public void ToString(){} // RVA: 0x7FFAC932D910
    }

    public class RequestCacheProtocol : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC932D990
    }

    public class RequestCacheValidator : Object
    {
        // ── Methods ──
        public void CreateValidator(){} // RVA: 0x7FFAC932D860
    }

    public class RequestCachingSectionInternal : Object
    {
        public bool DisableAllCaching; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC322C870
    }

}