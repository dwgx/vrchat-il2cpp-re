// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net.Cache
// Classes: 7
// Methods: 15

namespace ThirdParty.DotNet.System.Net.Cache
{
    public class RequestCache : Object
    {
        public object LineSplits;
        public object _IsPrivateCache;
        public object _CanWrite;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x75F81D0
    }

    public class RequestCacheBinding : Object
    {
        public object m_RequestCache;
        public object m_CacheValidator;
        public object m_Policy;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xC27FD0
        public void get_Cache(){} // RVA: 0xB5DBF0
        public void get_Validator(){} // RVA: 0xB465B0
        public void get_Policy(){} // RVA: 0xB700F0
    }

    public class RequestCacheManager : Object
    {
        public object s_CacheConfigSettings;
        public object s_BypassCacheBinding;
        public object s_DefaultGlobalBinding;
        public object s_DefaultHttpBinding;
        public object s_DefaultFtpBinding;

        // ── Methods ──
        public void GetBinding(){} // RVA: 0x75F82C0
        public void LoadConfigSettings(){} // RVA: 0x75F8530
        public void .cctor(){} // RVA: 0x75F8750
    }

    public class RequestCachePolicy : Object
    {
        public object m_Level;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x75F8980
        public void get_Level(){} // RVA: 0xB8F8F0
        public void ToString(){} // RVA: 0x75F89F0
    }

    public class RequestCacheProtocol : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x75F8A70
    }

    public class RequestCacheValidator : Object
    {
        // ── Methods ──
        public void CreateValidator(){} // RVA: 0x75F8930
        public void .ctor(){} // RVA: 0xB43310
    }

    public class RequestCachingSectionInternal : Object
    {
        public object DisableAllCaching;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xF482F0
    }

}