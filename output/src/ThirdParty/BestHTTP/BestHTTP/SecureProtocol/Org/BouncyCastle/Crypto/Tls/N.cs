// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
// Classes: 3
// Methods: 10

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
    public class NameType : Object
    {
        public object host_name;

        // ── Methods ──
        public void IsValid(){} // RVA: 0xA1D0930
        public void .ctor(){} // RVA: 0xB43310
    }

    public class NamedCurve : Object
    {
        public object sect163k1;
        public object sect163r1;
        public object sect163r2;
        public object sect193r1;
        public object sect193r2;
        public object sect233k1;
        public object sect233r1;
        public object sect239k1;
        public object sect283k1;
        public object sect283r1;
        public object sect409k1;
        public object sect409r1;
        public object sect571k1;
        public object sect571r1;
        public object secp160k1;
        public object secp160r1;
        public object secp160r2;
        public object secp192k1;
        public object secp192r1;
        public object secp224k1;
        public object secp224r1;
        public object secp256k1;
        public object secp256r1;
        public object secp384r1;
        public object secp521r1;
        public object brainpoolP256r1;
        public object brainpoolP384r1;
        public object brainpoolP512r1;
        public object arbitrary_explicit_prime_curves;
        public object arbitrary_explicit_char2_curves;

        // ── Methods ──
        public void IsValid(){} // RVA: 0xA1D0900
        public void RefersToASpecificNamedCurve(){} // RVA: 0xA1D0920
        public void .ctor(){} // RVA: 0xB43310
    }

    public class NewSessionTicket : Object
    {
        public object mTicketLifetimeHint;
        public object mTicket;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x68032D0
        public void get_TicketLifetimeHint(){} // RVA: 0xB5DBF0
        public void get_Ticket(){} // RVA: 0xB465B0
        public void Encode(){} // RVA: 0xA1D0940
        public void Parse(){} // RVA: 0xA1D0A30
    }

}