// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Security.Interfaces
// Classes: 4
// Methods: 9

namespace VRC.Udon.Security.Interfaces
{
    public class IUdonSecurityBlacklist
    {
        // ── Methods ──
        public void CleanBlacklist(){} // RVA: 0x7FFE80E45FE0
        public void IsBlacklisted(){} // RVA: 0x7FFE810A1420
    }

    public class IUdonSecurityBlacklist`1
    {
        // ── Methods ──
        public void Blacklist(){} // RVA: 0x7FFE80E4BC00 | overloaded x2
        public void IsBlacklisted(){} // RVA: 0x7FFE810A1420
    }

    public class IUdonSecurityWhitelist
    {
        // ── Methods ──
        public void CleanWhitelist(){} // RVA: 0x7FFE80E45FE0
    }

    public class IUdonSecurityWhitelist`1
    {
        // ── Methods ──
        public void Whitelist(){} // RVA: 0x7FFE80E460A0 | overloaded x2
        public void IsWhitelisted(){} // RVA: 0x7FFE810A1420
    }

}