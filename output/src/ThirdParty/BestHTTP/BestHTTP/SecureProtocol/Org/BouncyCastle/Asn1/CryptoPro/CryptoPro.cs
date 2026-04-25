// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.CryptoPro
// Classes: 7
// Methods: 47

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.CryptoPro
{
    public class CryptoProObjectIdentifiers : Object
    {
        public string GostID;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier GostR3411;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier GostR3411Hmac; // 0x8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier GostR28147Cbc; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier ID_Gost28147_89_CryptoPro_A_ParamSet; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier GostR3410x94; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier GostR3410x2001; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier GostR3411x94WithGostR3410x94; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier GostR3411x94WithGostR3410x2001; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier GostR3411x94CryptoProParamSet; // 0x40
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier GostR3410x94CryptoProA; // 0x48
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier GostR3410x94CryptoProB; // 0x50
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier GostR3410x94CryptoProC; // 0x58
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier GostR3410x94CryptoProD; // 0x60
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier GostR3410x94CryptoProXchA; // 0x68
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier GostR3410x94CryptoProXchB; // 0x70
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier GostR3410x94CryptoProXchC; // 0x78
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier GostR3410x2001CryptoProA; // 0x80
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier GostR3410x2001CryptoProB; // 0x88
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier GostR3410x2001CryptoProC; // 0x90
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier GostR3410x2001CryptoProXchA; // 0x98
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier GostR3410x2001CryptoProXchB; // 0xA0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier GostElSgDH3410Default; // 0xA8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier GostElSgDH3410x1; // 0xB0

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBDC31A0
    }

    public class ECGost3410NamedCurves : Object
    {
        public System.Collections.IDictionary Names;
        public System.Collections.IDictionary parameters; // 0x8
        public System.Collections.IDictionary names; // 0x10

        // ── Methods ──
        public void ConfigureBasepoint(){} // RVA: 0x7FFACBDC4050
        public void ConfigureCurve(){} // RVA: 0x7FFAC44F81E0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBDC40F0
        public void GetByOid(){} // RVA: 0x7FFACBDC6490
        public void get_Names(){} // RVA: 0x7FFACBDC6570
        public void GetByName(){} // RVA: 0x7FFACBDC66C0
        public void GetName(){} // RVA: 0x7FFACBDC6840
        public void GetOid(){} // RVA: 0x7FFACBDC6900
    }

    public class ECGost3410ParamSetParameters : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger P; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger Q; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger A; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger b; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger x; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger y; // 0x38

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBDC6BB0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBDC73A0 | overloaded x2
        public void get_P(){} // RVA: 0x7FFACBD33D60
        public void get_Q(){} // RVA: 0x7FFACBD33D80
        public void get_A(){} // RVA: 0x7FFACBD33DA0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDC7700
    }

    public class Gost28147Parameters : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString iv; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier paramSet; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBDC7AF0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBDC7CB0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDC7E90
    }

    public class Gost3410NamedParameters : Object
    {
        public System.Collections.IDictionary Names;
        public System.Collections.IDictionary parameters; // 0x8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.CryptoPro.Gost3410ParamSetParameters cryptoProA; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.CryptoPro.Gost3410ParamSetParameters cryptoProB; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.CryptoPro.Gost3410ParamSetParameters cryptoProXchA; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBDC7FA0
        public void GetByOid(){} // RVA: 0x7FFACBDC8790
        public void get_Names(){} // RVA: 0x7FFACBDC8870
        public void GetByName(){} // RVA: 0x7FFACBDC89C0
        public void GetOid(){} // RVA: 0x7FFACBDC8B40
    }

    public class Gost3410ParamSetParameters : Asn1Encodable
    {
        public int KeySize; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger P; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger Q; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger A; // 0x28

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBDC8DF0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBDC9340 | overloaded x2
        public void get_KeySize(){} // RVA: 0x7FFAC2F6E5C0
        public void get_P(){} // RVA: 0x7FFACBD33D80
        public void get_Q(){} // RVA: 0x7FFACBD33DA0
        public void get_A(){} // RVA: 0x7FFACBDC95D0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDC95F0
    }

    public class Gost3410PublicKeyAlgParameters : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier PublicKeyParamSet; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier DigestParamSet; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier EncryptionParamSet; // 0x20

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBDC97E0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBDC9A90 | overloaded x3
        public void get_PublicKeyParamSet(){} // RVA: 0x7FFAC2F3C380
        public void get_DigestParamSet(){} // RVA: 0x7FFAC2F247C0
        public void get_EncryptionParamSet(){} // RVA: 0x7FFAC2F4F0C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDC9DF0
    }

}