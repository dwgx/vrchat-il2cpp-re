// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
// Classes: 3
// Methods: 10

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
    public class NameType : Object
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x7FFE89F910F0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class NamedCurve : Object
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x7FFE89F910C0
        public void RefersToASpecificNamedCurve(){} // RVA: 0x7FFE89F910E0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class NewSessionTicket : Object
    {
        public long mTicketLifetimeHint; // 0x10
        public byte[] mTicket; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE868CBD50
        public void get_TicketLifetimeHint(){} // RVA: 0x7FFE81116380
        public void get_Ticket(){} // RVA: 0x7FFE810FE7C0
        public void Encode(){} // RVA: 0x7FFE89F91100
        public void Parse(){} // RVA: 0x7FFE89F911F0
    }

}