// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Sec
// Classes: 3
// Methods: 21

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Sec
{
    public class ECPrivateKeyStructure : Asn1Encodable
    {
        public object seq;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA40AC50
        public void .ctor(){} // RVA: 0xA40B6C0
        public void GetKey(){} // RVA: 0xA40BC70
        public void GetPublicKey(){} // RVA: 0xA40BD70
        public void GetParameters(){} // RVA: 0xA40BDF0
        public void GetObjectInTag(){} // RVA: 0xA40BE00
        public void ToAsn1Object(){} // RVA: 0xB5DBF0
    }

    public class SecNamedCurves : Object
    {
        public object objIds;
        public object curves;
        public object names;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void ConfigureBasepoint(){} // RVA: 0xA40C080
        public void ConfigureCurve(){} // RVA: 0x2303260
        public void ConfigureCurveGlv(){} // RVA: 0xA40C170
        public void FromHex(){} // RVA: 0xA40C270
        public void DefineCurve(){} // RVA: 0xA40C320
        public void .cctor(){} // RVA: 0xA40C470
        public void GetByName(){} // RVA: 0xA40D5C0
        public void GetByOid(){} // RVA: 0xA40D640
        public void GetOid(){} // RVA: 0xA40D730
        public void GetName(){} // RVA: 0xA40D850
        public void get_Names(){} // RVA: 0xA40D900
    }

    public class SecObjectIdentifiers : Object
    {
        public object EllipticCurve;
        public object SecT163k1;
        public object SecT163r1;
        public object SecT239k1;
        public object SecT113r1;
        public object SecT113r2;
        public object SecP112r1;
        public object SecP112r2;
        public object SecP160r1;
        public object SecP160k1;
        public object SecP256k1;
        public object SecT163r2;
        public object SecT283k1;
        public object SecT283r1;
        public object SecT131r1;
        public object SecT131r2;
        public object SecT193r1;
        public object SecT193r2;
        public object SecT233k1;
        public object SecT233r1;
        public object SecP128r1;
        public object SecP128r2;
        public object SecP160r2;
        public object SecP192k1;
        public object SecP224k1;
        public object SecP224r1;
        public object SecP384r1;
        public object SecP521r1;
        public object SecT409k1;
        public object SecT409r1;
        public object SecT571k1;
        public object SecT571r1;
        public object SecP192r1;
        public object SecP256r1;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA414460
    }

}