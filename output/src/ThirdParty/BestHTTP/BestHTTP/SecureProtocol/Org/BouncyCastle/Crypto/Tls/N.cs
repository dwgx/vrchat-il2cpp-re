// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
// Classes: 3
// Methods: 10

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
    public class NameType : Object
    {
        public byte host_name;

        // ── Methods ──
        public void IsValid(){} // RVA: 0x7FFACBB37AD0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class NamedCurve : Object
    {
        public int sect163k1;
        public int sect163r1;
        public int sect163r2;
        public int sect193r1;
        public int sect193r2;
        public int sect233k1;
        public int sect233r1;
        public int sect239k1;
        public int sect283k1;
        public int sect283r1;
        public int sect409k1;
        public int sect409r1;
        public int sect571k1;
        public int sect571r1;
        public int secp160k1;
        public int secp160r1;
        public int secp160r2;
        public int secp192k1;
        public int secp192r1;
        public int secp224k1;
        public int secp224r1;
        public int secp256k1;
        public int secp256r1;
        public int secp384r1;
        public int secp521r1;
        public int brainpoolP256r1;
        public int brainpoolP384r1;
        public int brainpoolP512r1;
        public int arbitrary_explicit_prime_curves;
        public int arbitrary_explicit_char2_curves;

        // ── Methods ──
        public void IsValid(){} // RVA: 0x7FFACBB37AA0
        public void RefersToASpecificNamedCurve(){} // RVA: 0x7FFACBB37AC0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class NewSessionTicket : Object
    {
        public long TicketLifetimeHint; // 0x10
        public byte[] Ticket; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8522550
        public void get_TicketLifetimeHint(){} // RVA: 0x7FFAC2F3C380
        public void get_Ticket(){} // RVA: 0x7FFAC2F247C0
        public void Encode(){} // RVA: 0x7FFACBB37AE0
        public void Parse(){} // RVA: 0x7FFACBB37BD0
    }

}