// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Sec
// Classes: 3
// Methods: 27

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Sec
{
    public class ECPrivateKeyStructure : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence seq; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD6E550
        public void .ctor(){} // RVA: 0x7FFACBD6EFC0 | overloaded x7
        public void GetKey(){} // RVA: 0x7FFACBD6F570
        public void GetPublicKey(){} // RVA: 0x7FFACBD6F680
        public void GetParameters(){} // RVA: 0x7FFACBD6F700
        public void GetObjectInTag(){} // RVA: 0x7FFACBD6F710
        public void ToAsn1Object(){} // RVA: 0x7FFAC2F3C380
    }

    public class SecNamedCurves : Object
    {
        public System.Collections.IDictionary Names;
        public System.Collections.IDictionary curves; // 0x8
        public System.Collections.IDictionary names; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void ConfigureBasepoint(){} // RVA: 0x7FFACBD6F9B0
        public void ConfigureCurve(){} // RVA: 0x7FFAC44F81E0
        public void ConfigureCurveGlv(){} // RVA: 0x7FFACBD6FAA0
        public void FromHex(){} // RVA: 0x7FFACBD6FBA0
        public void DefineCurve(){} // RVA: 0x7FFACBD6FC50
        public void .cctor(){} // RVA: 0x7FFACBD6FDA0
        public void GetByName(){} // RVA: 0x7FFACBD70EF0
        public void GetByOid(){} // RVA: 0x7FFACBD70F70
        public void GetOid(){} // RVA: 0x7FFACBD71060
        public void GetName(){} // RVA: 0x7FFACBD71180
        public void get_Names(){} // RVA: 0x7FFACBD71240
    }

    public class SecObjectIdentifiers : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier EllipticCurve;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier SecT163k1; // 0x8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier SecT163r1; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier SecT239k1; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier SecT113r1; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier SecT113r2; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier SecP112r1; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier SecP112r2; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier SecP160r1; // 0x40
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier SecP160k1; // 0x48
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier SecP256k1; // 0x50
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier SecT163r2; // 0x58
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier SecT283k1; // 0x60
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier SecT283r1; // 0x68
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier SecT131r1; // 0x70
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier SecT131r2; // 0x78
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier SecT193r1; // 0x80
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier SecT193r2; // 0x88
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier SecT233k1; // 0x90
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier SecT233r1; // 0x98
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier SecP128r1; // 0xA0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier SecP128r2; // 0xA8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier SecP160r2; // 0xB0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier SecP192k1; // 0xB8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier SecP224k1; // 0xC0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier SecP224r1; // 0xC8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier SecP384r1; // 0xD0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier SecP521r1; // 0xD8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier SecT409k1; // 0xE0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier SecT409r1; // 0xE8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier SecT571k1; // 0xF0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier SecT571r1; // 0xF8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier SecP192r1; // 0x100
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier SecP256r1; // 0x108

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBD77DA0
    }

}