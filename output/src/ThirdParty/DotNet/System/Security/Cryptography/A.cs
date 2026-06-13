// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Cryptography
// Classes: 12
// Methods: 131

namespace ThirdParty.DotNet.System.Security.Cryptography
{
    public class Aes
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C759E0
        public void Create(){} // RVA: 0x5C75CB0 | overloaded x2
        public void .cctor(){} // RVA: 0x5C75DF0
    }

    public class AesCcm
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5CAF660 | overloaded x2
        public void get_NonceByteSizes(){} // RVA: 0x5CAF6A0
        public void get_TagByteSizes(){} // RVA: 0x5CAF6E0
        public void Decrypt(){} // RVA: 0x5CAF760 | overloaded x2
        public void Dispose(){} // RVA: 0x2DD310
        public void Encrypt(){} // RVA: 0x5CAF7E0 | overloaded x2
    }

    public class AesCryptoServiceProvider
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x659FFD0
        public void GenerateIV(){} // RVA: 0x65A0030
        public void GenerateKey(){} // RVA: 0x65A00A0
        public void CreateDecryptor(){} // RVA: 0x5C9E2F0 | overloaded x2
        public void CreateEncryptor(){} // RVA: 0x5C9E280 | overloaded x2
        public void get_IV(){} // RVA: 0x5C9D910
        public void set_IV(){} // RVA: 0x65A0330
        public void get_Key(){} // RVA: 0x5C9DB70
        public void set_Key(){} // RVA: 0x65A0340
        public void get_KeySize(){} // RVA: 0xFDC9F0
        public void set_KeySize(){} // RVA: 0x65A0350
        public void get_FeedbackSize(){} // RVA: 0x8ABED0
        public void set_FeedbackSize(){} // RVA: 0x5C9D880
        public void get_Mode(){} // RVA: 0x891AF0
        public void set_Mode(){} // RVA: 0x65A0360
        public void get_Padding(){} // RVA: 0x37E080
        public void set_Padding(){} // RVA: 0x5C9E030
        public void Dispose(){} // RVA: 0x65A0430
    }

    public class AesGcm
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5CAF860 | overloaded x2
        public void get_NonceByteSizes(){} // RVA: 0x5CAF8A0
        public void get_TagByteSizes(){} // RVA: 0x5CAF8E0
        public void Decrypt(){} // RVA: 0x5CAF960 | overloaded x2
        public void Dispose(){} // RVA: 0x2DD310
        public void Encrypt(){} // RVA: 0x5CAF9E0 | overloaded x2
    }

    public class AesManaged
    {
        public System.Security.Cryptography.RijndaelManaged m_rijndael; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x659F730
        public void get_FeedbackSize(){} // RVA: 0x659F8B0
        public void set_FeedbackSize(){} // RVA: 0x659F8E0
        public void get_IV(){} // RVA: 0x659F910
        public void set_IV(){} // RVA: 0x659F940
        public void get_Key(){} // RVA: 0x659F970
        public void set_Key(){} // RVA: 0x659F9A0
        public void get_KeySize(){} // RVA: 0x659F9D0
        public void set_KeySize(){} // RVA: 0x659FA00
        public void get_Mode(){} // RVA: 0x659FA30
        public void set_Mode(){} // RVA: 0x659FA60
        public void get_Padding(){} // RVA: 0x659FB10
        public void set_Padding(){} // RVA: 0x659FB40
        public void CreateDecryptor(){} // RVA: 0x659FBA0 | overloaded x2
        public void CreateEncryptor(){} // RVA: 0x659FD70 | overloaded x2
        public void Dispose(){} // RVA: 0x659FF10
        public void GenerateIV(){} // RVA: 0x5DFFD00
        public void GenerateKey(){} // RVA: 0x5DFFCD0
    }

    public class AesTransform
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x65A0440
        public void ECB(){} // RVA: 0x65A0C60
        public void SubByte(){} // RVA: 0x65A0C90
        public void Encrypt128(){} // RVA: 0x65A0D80
        public void Decrypt128(){} // RVA: 0x65A3B50
        public void .cctor(){} // RVA: 0x65A6950
    }

    public class AsnEncodedData
    {
        public System.Security.Cryptography.Oid _oid; // 0x10
        public byte[] _raw; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C329A0 | overloaded x4
        public void get_Oid(){} // RVA: 0x2F8380
        public void set_Oid(){} // RVA: 0x6C32A90
        public void get_RawData(){} // RVA: 0x2E07C0
        public void set_RawData(){} // RVA: 0x6C32BC0
        public void CopyFrom(){} // RVA: 0x6C32D00
        public void Format(){} // RVA: 0x6C32DF0
        public void ToString(){} // RVA: 0x6C32E90
        public void Default(){} // RVA: 0x6C33180
        public void BasicConstraintsExtension(){} // RVA: 0x6C33370
        public void EnhancedKeyUsageExtension(){} // RVA: 0x6C33540
        public void KeyUsageExtension(){} // RVA: 0x6C33710
        public void SubjectKeyIdentifierExtension(){} // RVA: 0x6C338E0
        public void SubjectAltName(){} // RVA: 0x6C33AB0
        public void NetscapeCertType(){} // RVA: 0x6C33DF0
    }

    public class AsymmetricAlgorithm
    {
        public int KeySizeValue; // 0x10
        public System.Security.Cryptography.KeySizes[] LegalKeySizesValue; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void Dispose(){} // RVA: 0x2DD310 | overloaded x2
        public void Clear(){} // RVA: 0x5C76080
        public void get_KeySize(){} // RVA: 0x32A5C0
        public void set_KeySize(){} // RVA: 0x5C760F0
        public void get_LegalKeySizes(){} // RVA: 0x5C76240
        public void get_SignatureAlgorithm(){} // RVA: 0x5C762C0
        public void get_KeyExchangeAlgorithm(){} // RVA: 0x5C76300
        public void Create(){} // RVA: 0x5C763A0 | overloaded x2
        public void FromXmlString(){} // RVA: 0x5C76480
        public void ToXmlString(){} // RVA: 0x5C764C0
        public void ExportEncryptedPkcs8PrivateKey(){} // RVA: 0x5C76540 | overloaded x2
        public void ExportPkcs8PrivateKey(){} // RVA: 0x5C76580
        public void ExportSubjectPublicKeyInfo(){} // RVA: 0x5C765C0
        public void ImportEncryptedPkcs8PrivateKey(){} // RVA: 0x5C76640 | overloaded x2
        public void ImportPkcs8PrivateKey(){} // RVA: 0x5C76680
        public void ImportSubjectPublicKeyInfo(){} // RVA: 0x5C766C0
        public void TryExportEncryptedPkcs8PrivateKey(){} // RVA: 0x5C76740 | overloaded x2
        public void TryExportPkcs8PrivateKey(){} // RVA: 0x5C76780
        public void TryExportSubjectPublicKeyInfo(){} // RVA: 0x5C767C0
    }

    public class AsymmetricKeyExchangeDeformatter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void get_Parameters(){} // RVA: 0xCD60
        public void set_Parameters(){} // RVA: 0x24B10
        public void SetKey(){} // RVA: 0x24B10
        public void DecryptKeyExchange(){} // RVA: 0xCE10
    }

    public class AsymmetricKeyExchangeFormatter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void get_Parameters(){} // RVA: 0xCD60
        public void SetKey(){} // RVA: 0x24B10
        public void CreateKeyExchange(){} // RVA: 0x1E6A0 | overloaded x2
    }

    public class AsymmetricSignatureDeformatter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void SetKey(){} // RVA: 0x24B10
        public void SetHashAlgorithm(){} // RVA: 0x24B10
        public void VerifySignature(){} // RVA: 0x11120 | overloaded x2
    }

    public class AsymmetricSignatureFormatter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void SetKey(){} // RVA: 0x24B10
        public void SetHashAlgorithm(){} // RVA: 0x24B10
        public void CreateSignature(){} // RVA: 0xCE10 | overloaded x2
    }

}