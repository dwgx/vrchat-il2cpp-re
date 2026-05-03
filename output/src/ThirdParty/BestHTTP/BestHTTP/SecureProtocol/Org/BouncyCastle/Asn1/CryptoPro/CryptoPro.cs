// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.CryptoPro
// Classes: 7
// Methods: 47

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.CryptoPro
{
    public class CryptoProObjectIdentifiers : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE8A21C7C0
    }

    public class ECGost3410NamedCurves : Object
    {
        public System.Collections.IDictionary objIds;

        // ── Methods ──
        public void ConfigureBasepoint(){} // RVA: 0x7FFE8A21D670
        public void ConfigureCurve(){} // RVA: 0x7FFE827C4A80
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE8A21D710
        public void GetByOid(){} // RVA: 0x7FFE8A21FAB0
        public void get_Names(){} // RVA: 0x7FFE8A21FB90
        public void GetByName(){} // RVA: 0x7FFE8A21FCE0
        public void GetName(){} // RVA: 0x7FFE8A21FE60
        public void GetOid(){} // RVA: 0x7FFE8A21FF20
    }

    public class ECGost3410ParamSetParameters : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger p; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger q; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger a; // 0x20

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A2201D0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A2209C0 | overloaded x2
        public void get_P(){} // RVA: 0x7FFE8A18D380
        public void get_Q(){} // RVA: 0x7FFE8A18D3A0
        public void get_A(){} // RVA: 0x7FFE8A18D3C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A220D20
    }

    public class Gost28147Parameters : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A221110 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A2212D0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A2214B0
    }

    public class Gost3410NamedParameters : Object
    {
        public System.Collections.IDictionary objIds;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE8A2215C0
        public void GetByOid(){} // RVA: 0x7FFE8A221DB0
        public void get_Names(){} // RVA: 0x7FFE8A221E90
        public void GetByName(){} // RVA: 0x7FFE8A221FE0
        public void GetOid(){} // RVA: 0x7FFE8A222160
    }

    public class Gost3410ParamSetParameters : Asn1Encodable
    {
        public int keySize; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger p; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger q; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger a; // 0x28

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A222410 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A222960 | overloaded x2
        public void get_KeySize(){} // RVA: 0x7FFE811485C0
        public void get_P(){} // RVA: 0x7FFE8A18D3A0
        public void get_Q(){} // RVA: 0x7FFE8A18D3C0
        public void get_A(){} // RVA: 0x7FFE8A222BF0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A222C10
    }

    public class Gost3410PublicKeyAlgParameters : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier publicKeyParamSet; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier digestParamSet; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier encryptionParamSet; // 0x20

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A222E00 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A2230B0 | overloaded x3
        public void get_PublicKeyParamSet(){} // RVA: 0x7FFE81116380
        public void get_DigestParamSet(){} // RVA: 0x7FFE810FE7C0
        public void get_EncryptionParamSet(){} // RVA: 0x7FFE811290C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A223410
    }

}