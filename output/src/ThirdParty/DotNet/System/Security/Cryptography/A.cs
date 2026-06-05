// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Cryptography
// Classes: 12
// Methods: 131

namespace ThirdParty.DotNet.System.Security.Cryptography
{
    public class Aes
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF87259E0
        public void Create(){} // RVA: 0x7FFAF8725CB0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAF8725DF0
    }

    public class AesCcm
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF875F660 | overloaded x2
        public void get_NonceByteSizes(){} // RVA: 0x7FFAF875F6A0
        public void get_TagByteSizes(){} // RVA: 0x7FFAF875F6E0
        public void Decrypt(){} // RVA: 0x7FFAF875F760 | overloaded x2
        public void Dispose(){} // RVA: 0x7FFAF2D8D310
        public void Encrypt(){} // RVA: 0x7FFAF875F7E0 | overloaded x2
    }

    public class AesCryptoServiceProvider
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF904FFD0
        public void GenerateIV(){} // RVA: 0x7FFAF9050030
        public void GenerateKey(){} // RVA: 0x7FFAF90500A0
        public void CreateDecryptor(){} // RVA: 0x7FFAF874E2F0 | overloaded x2
        public void CreateEncryptor(){} // RVA: 0x7FFAF874E280 | overloaded x2
        public void get_IV(){} // RVA: 0x7FFAF874D910
        public void set_IV(){} // RVA: 0x7FFAF9050330
        public void get_Key(){} // RVA: 0x7FFAF874DB70
        public void set_Key(){} // RVA: 0x7FFAF9050340
        public void get_KeySize(){} // RVA: 0x7FFAF3A8C9F0
        public void set_KeySize(){} // RVA: 0x7FFAF9050350
        public void get_FeedbackSize(){} // RVA: 0x7FFAF335BED0
        public void set_FeedbackSize(){} // RVA: 0x7FFAF874D880
        public void get_Mode(){} // RVA: 0x7FFAF3341AF0
        public void set_Mode(){} // RVA: 0x7FFAF9050360
        public void get_Padding(){} // RVA: 0x7FFAF2E2E080
        public void set_Padding(){} // RVA: 0x7FFAF874E030
        public void Dispose(){} // RVA: 0x7FFAF9050430
    }

    public class AesGcm
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF875F860 | overloaded x2
        public void get_NonceByteSizes(){} // RVA: 0x7FFAF875F8A0
        public void get_TagByteSizes(){} // RVA: 0x7FFAF875F8E0
        public void Decrypt(){} // RVA: 0x7FFAF875F960 | overloaded x2
        public void Dispose(){} // RVA: 0x7FFAF2D8D310
        public void Encrypt(){} // RVA: 0x7FFAF875F9E0 | overloaded x2
    }

    public class AesManaged
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF904F730
        public void get_FeedbackSize(){} // RVA: 0x7FFAF904F8B0
        public void set_FeedbackSize(){} // RVA: 0x7FFAF904F8E0
        public void get_IV(){} // RVA: 0x7FFAF904F910
        public void set_IV(){} // RVA: 0x7FFAF904F940
        public void get_Key(){} // RVA: 0x7FFAF904F970
        public void set_Key(){} // RVA: 0x7FFAF904F9A0
        public void get_KeySize(){} // RVA: 0x7FFAF904F9D0
        public void set_KeySize(){} // RVA: 0x7FFAF904FA00
        public void get_Mode(){} // RVA: 0x7FFAF904FA30
        public void set_Mode(){} // RVA: 0x7FFAF904FA60
        public void get_Padding(){} // RVA: 0x7FFAF904FB10
        public void set_Padding(){} // RVA: 0x7FFAF904FB40
        public void CreateDecryptor(){} // RVA: 0x7FFAF904FBA0 | overloaded x2
        public void CreateEncryptor(){} // RVA: 0x7FFAF904FD70 | overloaded x2
        public void Dispose(){} // RVA: 0x7FFAF904FF10
        public void GenerateIV(){} // RVA: 0x7FFAF88AFD00
        public void GenerateKey(){} // RVA: 0x7FFAF88AFCD0
    }

    public class AesTransform
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9050440
        public void ECB(){} // RVA: 0x7FFAF9050C60
        public void SubByte(){} // RVA: 0x7FFAF9050C90
        public void Encrypt128(){} // RVA: 0x7FFAF9050D80
        public void Decrypt128(){} // RVA: 0x7FFAF9053B50
        public void .cctor(){} // RVA: 0x7FFAF9056950
    }

    public class AsnEncodedData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF96E29A0 | overloaded x4
        public void get_Oid(){} // RVA: 0x7FFAF2DA8380
        public void set_Oid(){} // RVA: 0x7FFAF96E2A90
        public void get_RawData(){} // RVA: 0x7FFAF2D907C0
        public void set_RawData(){} // RVA: 0x7FFAF96E2BC0
        public void CopyFrom(){} // RVA: 0x7FFAF96E2D00
        public void Format(){} // RVA: 0x7FFAF96E2DF0
        public void ToString(){} // RVA: 0x7FFAF96E2E90
        public void Default(){} // RVA: 0x7FFAF96E3180
        public void BasicConstraintsExtension(){} // RVA: 0x7FFAF96E3370
        public void EnhancedKeyUsageExtension(){} // RVA: 0x7FFAF96E3540
        public void KeyUsageExtension(){} // RVA: 0x7FFAF96E3710
        public void SubjectKeyIdentifierExtension(){} // RVA: 0x7FFAF96E38E0
        public void SubjectAltName(){} // RVA: 0x7FFAF96E3AB0
        public void NetscapeCertType(){} // RVA: 0x7FFAF96E3DF0
    }

    public class AsymmetricAlgorithm
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void Dispose(){} // RVA: 0x7FFAF2D8D310 | overloaded x2
        public void Clear(){} // RVA: 0x7FFAF8726080
        public void get_KeySize(){} // RVA: 0x7FFAF2DDA5C0
        public void set_KeySize(){} // RVA: 0x7FFAF87260F0
        public void get_LegalKeySizes(){} // RVA: 0x7FFAF8726240
        public void get_SignatureAlgorithm(){} // RVA: 0x7FFAF87262C0
        public void get_KeyExchangeAlgorithm(){} // RVA: 0x7FFAF8726300
        public void Create(){} // RVA: 0x7FFAF87263A0 | overloaded x2
        public void FromXmlString(){} // RVA: 0x7FFAF8726480
        public void ToXmlString(){} // RVA: 0x7FFAF87264C0
        public void ExportEncryptedPkcs8PrivateKey(){} // RVA: 0x7FFAF8726540 | overloaded x2
        public void ExportPkcs8PrivateKey(){} // RVA: 0x7FFAF8726580
        public void ExportSubjectPublicKeyInfo(){} // RVA: 0x7FFAF87265C0
        public void ImportEncryptedPkcs8PrivateKey(){} // RVA: 0x7FFAF8726640 | overloaded x2
        public void ImportPkcs8PrivateKey(){} // RVA: 0x7FFAF8726680
        public void ImportSubjectPublicKeyInfo(){} // RVA: 0x7FFAF87266C0
        public void TryExportEncryptedPkcs8PrivateKey(){} // RVA: 0x7FFAF8726740 | overloaded x2
        public void TryExportPkcs8PrivateKey(){} // RVA: 0x7FFAF8726780
        public void TryExportSubjectPublicKeyInfo(){} // RVA: 0x7FFAF87267C0
    }

    public class AsymmetricKeyExchangeDeformatter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void get_Parameters(){} // RVA: 0x7FFAF2ABCD60
        public void set_Parameters(){} // RVA: 0x7FFAF2AD4B10
        public void SetKey(){} // RVA: 0x7FFAF2AD4B10
        public void DecryptKeyExchange(){} // RVA: 0x7FFAF2ABCE10
    }

    public class AsymmetricKeyExchangeFormatter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void get_Parameters(){} // RVA: 0x7FFAF2ABCD60
        public void SetKey(){} // RVA: 0x7FFAF2AD4B10
        public void CreateKeyExchange(){} // RVA: 0x7FFAF2ACE6A0 | overloaded x2
    }

    public class AsymmetricSignatureDeformatter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void SetKey(){} // RVA: 0x7FFAF2AD4B10
        public void SetHashAlgorithm(){} // RVA: 0x7FFAF2AD4B10
        public void VerifySignature(){} // RVA: 0x7FFAF2AC1120 | overloaded x2
    }

    public class AsymmetricSignatureFormatter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void SetKey(){} // RVA: 0x7FFAF2AD4B10
        public void SetHashAlgorithm(){} // RVA: 0x7FFAF2AD4B10
        public void CreateSignature(){} // RVA: 0x7FFAF2ABCE10 | overloaded x2
    }

}