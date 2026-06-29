// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.CryptoPro
// Classes: 7
// Methods: 39

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.CryptoPro
{
    public class CryptoProObjectIdentifiers : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7B15F4F10
    }

    public class ECGost3410NamedCurves : Object
    {
        // ── Methods ──
        public void ConfigureBasepoint(){} // RVA: 0x7B15F5DC0
        public void ConfigureCurve(){} // RVA: 0x7A97F8BA0
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7B15F5E60
        public void GetByOid(){} // RVA: 0x7B15F8210
        public void get_Names(){} // RVA: 0x7B15F82F0
        public void GetByName(){} // RVA: 0x7B15F8440
        public void GetName(){} // RVA: 0x7B15F85C0
        public void GetOid(){} // RVA: 0x7B15F8680
    }

    public class ECGost3410ParamSetParameters : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15F8780
        public void .ctor(){} // RVA: 0x7B15F8F70
        public void get_P(){} // RVA: 0x7B1564AD0
        public void get_Q(){} // RVA: 0x7B1564AF0
        public void get_A(){} // RVA: 0x7B1564B10
        public void ToAsn1Object(){} // RVA: 0x7B15F92D0
    }

    public class Gost28147Parameters : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15F9510
        public void .ctor(){} // RVA: 0x7B15F96D0
        public void ToAsn1Object(){} // RVA: 0x7B15F98B0
    }

    public class Gost3410NamedParameters : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7B15F99C0
        public void GetByOid(){} // RVA: 0x7B15FA1D0
        public void get_Names(){} // RVA: 0x7B15FA2B0
        public void GetByName(){} // RVA: 0x7B15FA400
        public void GetOid(){} // RVA: 0x7B15FA580
    }

    public class Gost3410ParamSetParameters : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15FA680
        public void .ctor(){} // RVA: 0x7B15FABD0
        public void get_KeySize(){} // RVA: 0x7A8124910
        public void get_P(){} // RVA: 0x7B1564AF0
        public void get_Q(){} // RVA: 0x7B1564B10
        public void get_A(){} // RVA: 0x7B15FAE60
        public void ToAsn1Object(){} // RVA: 0x7B15FAE80
    }

    public class Gost3410PublicKeyAlgParameters : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15FB070
        public void .ctor(){} // RVA: 0x7B15FB320
        public void get_PublicKeyParamSet(){} // RVA: 0x7A80F2570
        public void get_DigestParamSet(){} // RVA: 0x7A80DA7B0
        public void get_EncryptionParamSet(){} // RVA: 0x7A81052C0
        public void ToAsn1Object(){} // RVA: 0x7B15FB680
    }

}