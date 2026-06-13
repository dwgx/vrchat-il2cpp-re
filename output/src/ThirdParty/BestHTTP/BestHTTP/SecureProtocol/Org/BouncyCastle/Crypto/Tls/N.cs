// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
// Classes: 3
// Methods: 10

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
    public class NameType
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x952ED20
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class NamedCurve
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x952ECF0
        public void RefersToASpecificNamedCurve(){} // RVA: 0x952ED10
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class NewSessionTicket
    {
        public long mTicketLifetimeHint; // 0x10
        public byte[] mTicket; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5D8AEC0
        public void get_TicketLifetimeHint(){} // RVA: 0x2F8380
        public void get_Ticket(){} // RVA: 0x2E07C0
        public void Encode(){} // RVA: 0x952ED30
        public void Parse(){} // RVA: 0x952EE20
    }

}