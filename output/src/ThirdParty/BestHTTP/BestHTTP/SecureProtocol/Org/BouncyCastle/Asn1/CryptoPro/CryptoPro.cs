// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.CryptoPro
// Classes: 7
// Methods: 39

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.CryptoPro
{
    public class CryptoProObjectIdentifiers : Object
    {
        public object GostID;
        public object GostR3411;
        public object GostR3411Hmac;
        public object GostR28147Cbc;
        public object ID_Gost28147_89_CryptoPro_A_ParamSet;
        public object GostR3410x94;
        public object GostR3410x2001;
        public object GostR3411x94WithGostR3410x94;
        public object GostR3411x94WithGostR3410x2001;
        public object GostR3411x94CryptoProParamSet;
        public object GostR3410x94CryptoProA;
        public object GostR3410x94CryptoProB;
        public object GostR3410x94CryptoProC;
        public object GostR3410x94CryptoProD;
        public object GostR3410x94CryptoProXchA;
        public object GostR3410x94CryptoProXchB;
        public object GostR3410x94CryptoProXchC;
        public object GostR3410x2001CryptoProA;
        public object GostR3410x2001CryptoProB;
        public object GostR3410x2001CryptoProC;
        public object GostR3410x2001CryptoProXchA;
        public object GostR3410x2001CryptoProXchB;
        public object GostElSgDH3410Default;
        public object GostElSgDH3410x1;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA460530
    }

    public class ECGost3410NamedCurves : Object
    {
        public object objIds;
        public object parameters;
        public object names;

        // ── Methods ──
        public void ConfigureBasepoint(){} // RVA: 0xA4613E0
        public void ConfigureCurve(){} // RVA: 0x2303260
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA461480
        public void GetByOid(){} // RVA: 0xA4637E0
        public void get_Names(){} // RVA: 0xA4638C0
        public void GetByName(){} // RVA: 0xA463A10
        public void GetName(){} // RVA: 0xA463B90
        public void GetOid(){} // RVA: 0xA463C40
    }

    public class ECGost3410ParamSetParameters : Asn1Encodable
    {
        public object p;
        public object q;
        public object a;
        public object b;
        public object x;
        public object y;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA463D40
        public void .ctor(){} // RVA: 0xA464530
        public void get_P(){} // RVA: 0xA3D0110
        public void get_Q(){} // RVA: 0xA3D0130
        public void get_A(){} // RVA: 0xA3D0150
        public void ToAsn1Object(){} // RVA: 0xA464890
    }

    public class Gost28147Parameters : Asn1Encodable
    {
        public object iv;
        public object paramSet;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA464AD0
        public void .ctor(){} // RVA: 0xA464C90
        public void ToAsn1Object(){} // RVA: 0xA464E70
    }

    public class Gost3410NamedParameters : Object
    {
        public object objIds;
        public object parameters;
        public object cryptoProA;
        public object cryptoProB;
        public object cryptoProXchA;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA464F80
        public void GetByOid(){} // RVA: 0xA465790
        public void get_Names(){} // RVA: 0xA465870
        public void GetByName(){} // RVA: 0xA4659C0
        public void GetOid(){} // RVA: 0xA465B40
    }

    public class Gost3410ParamSetParameters : Asn1Encodable
    {
        public object keySize;
        public object p;
        public object q;
        public object a;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA465C40
        public void .ctor(){} // RVA: 0xA466190
        public void get_KeySize(){} // RVA: 0xB8F8F0
        public void get_P(){} // RVA: 0xA3D0130
        public void get_Q(){} // RVA: 0xA3D0150
        public void get_A(){} // RVA: 0xA466420
        public void ToAsn1Object(){} // RVA: 0xA466440
    }

    public class Gost3410PublicKeyAlgParameters : Asn1Encodable
    {
        public object publicKeyParamSet;
        public object digestParamSet;
        public object encryptionParamSet;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA466630
        public void .ctor(){} // RVA: 0xA4668E0
        public void get_PublicKeyParamSet(){} // RVA: 0xB5DBF0
        public void get_DigestParamSet(){} // RVA: 0xB465B0
        public void get_EncryptionParamSet(){} // RVA: 0xB700F0
        public void ToAsn1Object(){} // RVA: 0xA466C40
    }

}