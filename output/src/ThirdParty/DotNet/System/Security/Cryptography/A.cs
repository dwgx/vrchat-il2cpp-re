// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Cryptography
// Classes: 12
// Methods: 109

namespace ThirdParty.DotNet.System.Security.Cryptography
{
    public class Aes : SymmetricAlgorithm
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x66EDFB0
        public void Create(){} // RVA: 0x66EE270
        public void .cctor(){} // RVA: 0x66EE3B0
    }

    public class AesCcm : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6728000
        public void get_NonceByteSizes(){} // RVA: 0x6728040
        public void get_TagByteSizes(){} // RVA: 0x6728080
        public void Decrypt(){} // RVA: 0x6728100
        public void Dispose(){} // RVA: 0xB43310
        public void Encrypt(){} // RVA: 0x6728180
    }

    public class AesCryptoServiceProvider : Aes
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x700DD30
        public void GenerateIV(){} // RVA: 0x700DD90
        public void GenerateKey(){} // RVA: 0x700DE00
        public void CreateDecryptor(){} // RVA: 0x6716DA0
        public void CreateEncryptor(){} // RVA: 0x6716D30
        public void get_IV(){} // RVA: 0x67163C0
        public void set_IV(){} // RVA: 0x6716460
        public void get_Key(){} // RVA: 0x6716620
        public void set_Key(){} // RVA: 0x700E090
        public void get_KeySize(){} // RVA: 0x18A0130
        public void set_KeySize(){} // RVA: 0x700E0A0
        public void get_FeedbackSize(){} // RVA: 0x116A650
        public void set_FeedbackSize(){} // RVA: 0x6716330
        public void get_Mode(){} // RVA: 0x114DAD0
        public void set_Mode(){} // RVA: 0x700E0B0
        public void get_Padding(){} // RVA: 0xBE5850
        public void set_Padding(){} // RVA: 0x6716AE0
        public void Dispose(){} // RVA: 0x700E180
    }

    public class AesGcm : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6728200
        public void get_NonceByteSizes(){} // RVA: 0x6728240
        public void get_TagByteSizes(){} // RVA: 0x6728280
        public void Decrypt(){} // RVA: 0x6728300
        public void Dispose(){} // RVA: 0xB43310
        public void Encrypt(){} // RVA: 0x6728380
    }

    public class AesManaged : Aes
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x700D490
        public void get_FeedbackSize(){} // RVA: 0x700D610
        public void set_FeedbackSize(){} // RVA: 0x700D640
        public void get_IV(){} // RVA: 0x700D670
        public void set_IV(){} // RVA: 0x700D6A0
        public void get_Key(){} // RVA: 0x700D6D0
        public void set_Key(){} // RVA: 0x700D700
        public void get_KeySize(){} // RVA: 0x700D730
        public void set_KeySize(){} // RVA: 0x700D760
        public void get_Mode(){} // RVA: 0x700D790
        public void set_Mode(){} // RVA: 0x700D7C0
        public void get_Padding(){} // RVA: 0x700D870
        public void set_Padding(){} // RVA: 0x700D8A0
        public void CreateDecryptor(){} // RVA: 0x700D900
        public void CreateEncryptor(){} // RVA: 0x700DAD0
        public void Dispose(){} // RVA: 0x700DC70
        public void GenerateIV(){} // RVA: 0x6879930
        public void GenerateKey(){} // RVA: 0x6879900
    }

    public class AesTransform : SymmetricTransform
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x700E190
        public void ECB(){} // RVA: 0x700E9A0
        public void SubByte(){} // RVA: 0x700E9D0
        public void Encrypt128(){} // RVA: 0x700EAD0
        public void Decrypt128(){} // RVA: 0x70118A0
        public void .cctor(){} // RVA: 0x70146A0
    }

    public class AsnEncodedData : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7693640
        public void get_Oid(){} // RVA: 0xB5DBF0
        public void set_Oid(){} // RVA: 0x7693730
        public void get_RawData(){} // RVA: 0xB465B0
        public void set_RawData(){} // RVA: 0x7693860
        public void CopyFrom(){} // RVA: 0x76939A0
        public void Format(){} // RVA: 0x7693A90
        public void ToString(){} // RVA: 0x7693AD0
        public void Default(){} // RVA: 0x7693DC0
        public void BasicConstraintsExtension(){} // RVA: 0x7693FC0
        public void EnhancedKeyUsageExtension(){} // RVA: 0x7694190
        public void KeyUsageExtension(){} // RVA: 0x7694360
        public void SubjectKeyIdentifierExtension(){} // RVA: 0x7694530
        public void SubjectAltName(){} // RVA: 0x7694700
        public void NetscapeCertType(){} // RVA: 0x7694A30
    }

    public class AsymmetricAlgorithm : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void Dispose(){} // RVA: 0xB43310
        public void Clear(){} // RVA: 0x66EE640
        public void get_KeySize(){} // RVA: 0xB8F8F0
        public void set_KeySize(){} // RVA: 0x66EE6B0
        public void get_LegalKeySizes(){} // RVA: 0x66EE7D0
        public void get_SignatureAlgorithm(){} // RVA: 0x66EE850
        public void get_KeyExchangeAlgorithm(){} // RVA: 0x66EE890
        public void Create(){} // RVA: 0x66EE930
        public void FromXmlString(){} // RVA: 0x66EEA10
        public void ToXmlString(){} // RVA: 0x66EEA50
        public void ExportEncryptedPkcs8PrivateKey(){} // RVA: 0x66EEAD0
        public void ExportPkcs8PrivateKey(){} // RVA: 0x66EEB10
        public void ExportSubjectPublicKeyInfo(){} // RVA: 0x66EEB50
        public void ImportEncryptedPkcs8PrivateKey(){} // RVA: 0x66EEBD0
        public void ImportPkcs8PrivateKey(){} // RVA: 0x66EEC10
        public void ImportSubjectPublicKeyInfo(){} // RVA: 0x66EEC50
        public void TryExportEncryptedPkcs8PrivateKey(){} // RVA: 0x66EECD0
        public void TryExportPkcs8PrivateKey(){} // RVA: 0x66EED10
        public void TryExportSubjectPublicKeyInfo(){} // RVA: 0x66EED50
    }

    public class AsymmetricKeyExchangeDeformatter : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void get_Parameters(){} // RVA: 0x87C0A0
        public void set_Parameters(){} // RVA: 0x894320
        public void SetKey(){} // RVA: 0x894320
        public void DecryptKeyExchange(){} // RVA: 0x87C540
    }

    public class AsymmetricKeyExchangeFormatter : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void get_Parameters(){} // RVA: 0x87C0A0
        public void SetKey(){} // RVA: 0x894320
        public void CreateKeyExchange(){} // RVA: 0x87C5F0
    }

    public class AsymmetricSignatureDeformatter : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void SetKey(){} // RVA: 0x894320
        public void SetHashAlgorithm(){} // RVA: 0x894320
        public void VerifySignature(){} // RVA: 0x87D3C0
    }

    public class AsymmetricSignatureFormatter : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void SetKey(){} // RVA: 0x894320
        public void SetHashAlgorithm(){} // RVA: 0x894320
        public void CreateSignature(){} // RVA: 0x87C540
    }

}