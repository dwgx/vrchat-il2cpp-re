// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net.Cache
// Classes: 7
// Methods: 14

namespace ThirdParty.DotNet.System.Net.Cache
{
    public class RequestCache : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE876D57F0
    }

    public class RequestCacheBinding : Object
    {
        public System.Net.Cache.RequestCache m_RequestCache; // 0x10
        public System.Net.Cache.RequestCacheValidator m_CacheValidator; // 0x18
        public System.Net.Cache.RequestCachePolicy m_Policy; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE811DAE00
        public void get_Cache(){} // RVA: 0x7FFE81116380
        public void get_Validator(){} // RVA: 0x7FFE810FE7C0
        public void get_Policy(){} // RVA: 0x7FFE811290C0
    }

    public class RequestCacheManager : Object
    {
        // ── Methods ──
        public void GetBinding(){} // RVA: 0x7FFE876D58E0
        public void LoadConfigSettings(){} // RVA: 0x7FFE876D5B50
        public void .cctor(){} // RVA: 0x7FFE876D5DB0
    }

    public class RequestCachePolicy : Object
    {
        public 0x66538FDC m_Level; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE876D5FD0
        public void get_Level(){} // RVA: 0x7FFE811485C0
        public void ToString(){} // RVA: 0x7FFE876D6040
    }

    public class RequestCacheProtocol : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE876D60C0
    }

    public class RequestCacheValidator : Object
    {
        // ── Methods ──
        public void CreateValidator(){} // RVA: 0x7FFE876D5F90
    }

    public class RequestCachingSectionInternal : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE814B8390
    }

}