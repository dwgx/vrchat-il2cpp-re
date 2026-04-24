// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Security.Interfaces
// Classes: 4
// Methods: 9

namespace VRC.Udon.Security.Interfaces
{
    public class IUdonSecurityBlacklist
    {
        // ── Methods ──
        public void CleanBlacklist(){} // RVA: 0x7FFD4E090980
        public void IsBlacklisted(){} // RVA: 0x7FFD4E2ADC40
    }

    public class IUdonSecurityBlacklist`1
    {
        // ── Methods ──
        public void Blacklist(){} // RVA: 0x7FFD4E096500 | overloaded x2
        public void IsBlacklisted(){} // RVA: 0x7FFD4E2ADC40
    }

    public class IUdonSecurityWhitelist
    {
        // ── Methods ──
        public void CleanWhitelist(){} // RVA: 0x7FFD4E090980
    }

    public class IUdonSecurityWhitelist`1
    {
        // ── Methods ──
        public void Whitelist(){} // RVA: 0x7FFD4E090A40 | overloaded x2
        public void IsWhitelisted(){} // RVA: 0x7FFD4E2ADC40
    }

}