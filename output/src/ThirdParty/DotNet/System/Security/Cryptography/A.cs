// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Cryptography
// Classes: 12
// Methods: 109

namespace ThirdParty.DotNet.System.Security.Cryptography
{
    public class Aes : SymmetricAlgorithm
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA639D0
        public void Create(){} // RVA: 0x7ADA63C90
        public void .cctor(){} // RVA: 0x7ADA63DD0
    }

    public class AesCcm : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA9D6E0
        public void get_NonceByteSizes(){} // RVA: 0x7ADA9D720
        public void get_TagByteSizes(){} // RVA: 0x7ADA9D760
        public void Decrypt(){} // RVA: 0x7ADA9D7E0
        public void Dispose(){} // RVA: 0x7A80D7310
        public void Encrypt(){} // RVA: 0x7ADA9D860
    }

    public class AesCryptoServiceProvider : Aes
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE38E4D0
        public void GenerateIV(){} // RVA: 0x7AE38E530
        public void GenerateKey(){} // RVA: 0x7AE38E5A0
        public void CreateDecryptor(){} // RVA: 0x7ADA8C6C0
        public void CreateEncryptor(){} // RVA: 0x7ADA8C650
        public void get_IV(){} // RVA: 0x7ADA8BCE0
        public void set_IV(){} // RVA: 0x7ADA8BD80
        public void get_Key(){} // RVA: 0x7ADA8BF40
        public void set_Key(){} // RVA: 0x7AE38E830
        public void get_KeySize(){} // RVA: 0x7A8D863F0
        public void set_KeySize(){} // RVA: 0x7AE38E840
        public void get_FeedbackSize(){} // RVA: 0x7A8668BC0
        public void set_FeedbackSize(){} // RVA: 0x7ADA8BC50
        public void get_Mode(){} // RVA: 0x7A864E8D0
        public void set_Mode(){} // RVA: 0x7AE38E850
        public void get_Padding(){} // RVA: 0x7A8178B30
        public void set_Padding(){} // RVA: 0x7ADA8C400
        public void Dispose(){} // RVA: 0x7AE38E920
    }

    public class AesGcm : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA9D8E0
        public void get_NonceByteSizes(){} // RVA: 0x7ADA9D920
        public void get_TagByteSizes(){} // RVA: 0x7ADA9D960
        public void Decrypt(){} // RVA: 0x7ADA9D9E0
        public void Dispose(){} // RVA: 0x7A80D7310
        public void Encrypt(){} // RVA: 0x7ADA9DA60
    }

    public class AesManaged : Aes
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE38DC30
        public void get_FeedbackSize(){} // RVA: 0x7AE38DDB0
        public void set_FeedbackSize(){} // RVA: 0x7AE38DDE0
        public void get_IV(){} // RVA: 0x7AE38DE10
        public void set_IV(){} // RVA: 0x7AE38DE40
        public void get_Key(){} // RVA: 0x7AE38DE70
        public void set_Key(){} // RVA: 0x7AE38DEA0
        public void get_KeySize(){} // RVA: 0x7AE38DED0
        public void set_KeySize(){} // RVA: 0x7AE38DF00
        public void get_Mode(){} // RVA: 0x7AE38DF30
        public void set_Mode(){} // RVA: 0x7AE38DF60
        public void get_Padding(){} // RVA: 0x7AE38E010
        public void set_Padding(){} // RVA: 0x7AE38E040
        public void CreateDecryptor(){} // RVA: 0x7AE38E0A0
        public void CreateEncryptor(){} // RVA: 0x7AE38E270
        public void Dispose(){} // RVA: 0x7AE38E410
        public void GenerateIV(){} // RVA: 0x7ADBEE850
        public void GenerateKey(){} // RVA: 0x7ADBEE820
    }

    public class AesTransform : SymmetricTransform
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE38E930
        public void ECB(){} // RVA: 0x7AE38F170
        public void SubByte(){} // RVA: 0x7AE38F1A0
        public void Encrypt128(){} // RVA: 0x7AE38F2A0
        public void Decrypt128(){} // RVA: 0x7AE392070
        public void .cctor(){} // RVA: 0x7AE394E70
    }

    public class AsnEncodedData : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEA218D0
        public void get_Oid(){} // RVA: 0x7A80F2570
        public void set_Oid(){} // RVA: 0x7AEA219C0
        public void get_RawData(){} // RVA: 0x7A80DA7B0
        public void set_RawData(){} // RVA: 0x7AEA21AF0
        public void CopyFrom(){} // RVA: 0x7AEA21C30
        public void Format(){} // RVA: 0x7AEA21D20
        public void ToString(){} // RVA: 0x7AEA21DC0
        public void Default(){} // RVA: 0x7AEA220B0
        public void BasicConstraintsExtension(){} // RVA: 0x7AEA222B0
        public void EnhancedKeyUsageExtension(){} // RVA: 0x7AEA22480
        public void KeyUsageExtension(){} // RVA: 0x7AEA22650
        public void SubjectKeyIdentifierExtension(){} // RVA: 0x7AEA22820
        public void SubjectAltName(){} // RVA: 0x7AEA229F0
        public void NetscapeCertType(){} // RVA: 0x7AEA22D30
    }

    public class AsymmetricAlgorithm : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void Dispose(){} // RVA: 0x7A80D7310
        public void Clear(){} // RVA: 0x7ADA64060
        public void get_KeySize(){} // RVA: 0x7A8124910
        public void set_KeySize(){} // RVA: 0x7ADA640D0
        public void get_LegalKeySizes(){} // RVA: 0x7ADA641F0
        public void get_SignatureAlgorithm(){} // RVA: 0x7ADA64270
        public void get_KeyExchangeAlgorithm(){} // RVA: 0x7ADA642B0
        public void Create(){} // RVA: 0x7ADA64350
        public void FromXmlString(){} // RVA: 0x7ADA64430
        public void ToXmlString(){} // RVA: 0x7ADA64470
        public void ExportEncryptedPkcs8PrivateKey(){} // RVA: 0x7ADA644F0
        public void ExportPkcs8PrivateKey(){} // RVA: 0x7ADA64530
        public void ExportSubjectPublicKeyInfo(){} // RVA: 0x7ADA64570
        public void ImportEncryptedPkcs8PrivateKey(){} // RVA: 0x7ADA645F0
        public void ImportPkcs8PrivateKey(){} // RVA: 0x7ADA64630
        public void ImportSubjectPublicKeyInfo(){} // RVA: 0x7ADA64670
        public void TryExportEncryptedPkcs8PrivateKey(){} // RVA: 0x7ADA646F0
        public void TryExportPkcs8PrivateKey(){} // RVA: 0x7ADA64730
        public void TryExportSubjectPublicKeyInfo(){} // RVA: 0x7ADA64770
    }

    public class AsymmetricKeyExchangeDeformatter : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void get_Parameters(){} // RVA: 0x7A7E00680
        public void set_Parameters(){} // RVA: 0x7A7E18800
        public void SetKey(){} // RVA: 0x7A7E18800
        public void DecryptKeyExchange(){} // RVA: 0x7A7E00B20
    }

    public class AsymmetricKeyExchangeFormatter : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void get_Parameters(){} // RVA: 0x7A7E00680
        public void SetKey(){} // RVA: 0x7A7E18800
        public void CreateKeyExchange(){} // RVA: 0x7A7E00BD0
    }

    public class AsymmetricSignatureDeformatter : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void SetKey(){} // RVA: 0x7A7E18800
        public void SetHashAlgorithm(){} // RVA: 0x7A7E18800
        public void VerifySignature(){} // RVA: 0x7A7E01A40
    }

    public class AsymmetricSignatureFormatter : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void SetKey(){} // RVA: 0x7A7E18800
        public void SetHashAlgorithm(){} // RVA: 0x7A7E18800
        public void CreateSignature(){} // RVA: 0x7A7E00B20
    }

}