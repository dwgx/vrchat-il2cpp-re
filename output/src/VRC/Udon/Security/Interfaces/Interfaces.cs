// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Security.Interfaces
// Classes: 4
// Methods: 9

namespace VRC.Udon.Security.Interfaces
{
    public class IUdonSecurityBlacklist : p00
    {
        // ── Methods ──
        public void CleanBlacklist(){} // RVA: 0x24A50
        public void IsBlacklisted(){} // RVA: 0x283FA0
    }

    public class IUdonSecurityBlacklist`1
    {
        // ── Methods ──
        public void Blacklist(){} // RVA: 0x2A620 | overloaded x2
        public void IsBlacklisted(){} // RVA: 0x283FA0
    }

    public class IUdonSecurityWhitelist
    {
        // ── Methods ──
        public void CleanWhitelist(){} // RVA: 0x24A50
    }

    public class IUdonSecurityWhitelist`1
    {
        // ── Methods ──
        public void Whitelist(){} // RVA: 0x24B10 | overloaded x2
        public void IsWhitelisted(){} // RVA: 0x283FA0
    }

}