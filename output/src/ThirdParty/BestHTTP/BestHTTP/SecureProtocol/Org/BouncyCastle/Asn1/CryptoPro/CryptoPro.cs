// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.CryptoPro
// Classes: 7
// Methods: 47

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.CryptoPro
{
    public class CryptoProObjectIdentifiers
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x97BA3C0
    }

    public class ECGost3410NamedCurves
    {
        public System.Collections.IDictionary P;

        // ── Methods ──
        public void ConfigureBasepoint(){} // RVA: 0x97BB270
        public void ConfigureCurve(){} // RVA: 0x1A3F520
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x97BB310
        public void GetByOid(){} // RVA: 0x97BD6B0
        public void get_Names(){} // RVA: 0x97BD790
        public void GetByName(){} // RVA: 0x97BD8E0
        public void GetName(){} // RVA: 0x97BDA60
        public void GetOid(){} // RVA: 0x97BDB20
    }

    public class ECGost3410ParamSetParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger p; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger q; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger a; // 0x20

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x97BDDD0 | overloaded x2
        public void .ctor(){} // RVA: 0x97BE5C0 | overloaded x2
        public void get_P(){} // RVA: 0x972AF80
        public void get_Q(){} // RVA: 0x972AFA0
        public void get_A(){} // RVA: 0x972AFC0
        public void ToAsn1Object(){} // RVA: 0x97BE920
    }

    public class Gost28147Parameters
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x97BED10 | overloaded x2
        public void .ctor(){} // RVA: 0x97BEED0
        public void ToAsn1Object(){} // RVA: 0x97BF0B0
    }

    public class Gost3410NamedParameters
    {
        public System.Collections.IDictionary KeySize;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x97BF1C0
        public void GetByOid(){} // RVA: 0x97BF9B0
        public void get_Names(){} // RVA: 0x97BFA90
        public void GetByName(){} // RVA: 0x97BFBE0
        public void GetOid(){} // RVA: 0x97BFD60
    }

    public class Gost3410ParamSetParameters
    {
        public int keySize; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger p; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger q; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger a; // 0x28

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x97C0010 | overloaded x2
        public void .ctor(){} // RVA: 0x97C0560 | overloaded x2
        public void get_KeySize(){} // RVA: 0x32A5C0
        public void get_P(){} // RVA: 0x972AFA0
        public void get_Q(){} // RVA: 0x972AFC0
        public void get_A(){} // RVA: 0x97C07F0
        public void ToAsn1Object(){} // RVA: 0x97C0810
    }

    public class Gost3410PublicKeyAlgParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier publicKeyParamSet; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier digestParamSet; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier encryptionParamSet; // 0x20

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x97C0A00 | overloaded x2
        public void .ctor(){} // RVA: 0x97C0CB0 | overloaded x3
        public void get_PublicKeyParamSet(){} // RVA: 0x2F8380
        public void get_DigestParamSet(){} // RVA: 0x2E07C0
        public void get_EncryptionParamSet(){} // RVA: 0x30B0C0
        public void ToAsn1Object(){} // RVA: 0x97C1010
    }

}