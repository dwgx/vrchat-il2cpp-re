// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Cryptography
// Classes: 12
// Methods: 131

namespace ThirdParty.DotNet.System.Security.Cryptography
{
    public class Aes : SymmetricAlgorithm
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867B6880
        public void Create(){} // RVA: 0x7FFE867B6B50 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE867B6C90
    }

    public class AesCcm : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867F0560 | overloaded x2
        public void get_NonceByteSizes(){} // RVA: 0x7FFE867F05A0
        public void get_TagByteSizes(){} // RVA: 0x7FFE867F05E0
        public void Decrypt(){} // RVA: 0x7FFE867F0660 | overloaded x2
        public void Dispose(){} // RVA: 0x7FFE810FB310
        public void Encrypt(){} // RVA: 0x7FFE867F06E0 | overloaded x2
    }

    public class AesCryptoServiceProvider : Aes
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE870DF030
        public void GenerateIV(){} // RVA: 0x7FFE870DF090
        public void GenerateKey(){} // RVA: 0x7FFE870DF100
        public void CreateDecryptor(){} // RVA: 0x7FFE867DF190 | overloaded x2
        public void CreateEncryptor(){} // RVA: 0x7FFE867DF120 | overloaded x2
        public void get_IV(){} // RVA: 0x7FFE867DE7B0
        public void set_IV(){} // RVA: 0x7FFE870DF390
        public void get_Key(){} // RVA: 0x7FFE867DEA10
        public void set_Key(){} // RVA: 0x7FFE870DF3A0
        public void get_KeySize(){} // RVA: 0x7FFE81D46090
        public void set_KeySize(){} // RVA: 0x7FFE870DF3B0
        public void get_FeedbackSize(){} // RVA: 0x7FFE8164B230
        public void set_FeedbackSize(){} // RVA: 0x7FFE867DE720
        public void get_Mode(){} // RVA: 0x7FFE816311C0
        public void set_Mode(){} // RVA: 0x7FFE870DF3C0
        public void get_Padding(){} // RVA: 0x7FFE8119C080
        public void set_Padding(){} // RVA: 0x7FFE867DEED0
        public void Dispose(){} // RVA: 0x7FFE870DF490
    }

    public class AesGcm : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867F0760 | overloaded x2
        public void get_NonceByteSizes(){} // RVA: 0x7FFE867F07A0
        public void get_TagByteSizes(){} // RVA: 0x7FFE867F07E0
        public void Decrypt(){} // RVA: 0x7FFE867F0860 | overloaded x2
        public void Dispose(){} // RVA: 0x7FFE810FB310
        public void Encrypt(){} // RVA: 0x7FFE867F08E0 | overloaded x2
    }

    public class AesManaged : Aes
    {
        public System.Security.Cryptography.RijndaelManaged m_rijndael; // 0x48
        public object field_1; // 0x1
        public object field_2; // 0x2
        public object field_3; // 0x3
        public object field_4; // 0x4
        public object field_5; // 0x5

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE870DE7C0
        public void get_FeedbackSize(){} // RVA: 0x7FFE870DE940
        public void set_FeedbackSize(){} // RVA: 0x7FFE870DE970
        public void get_IV(){} // RVA: 0x7FFE870DE9A0
        public void set_IV(){} // RVA: 0x7FFE870DE9D0
        public void get_Key(){} // RVA: 0x7FFE870DEA00
        public void set_Key(){} // RVA: 0x7FFE870DEA30
        public void get_KeySize(){} // RVA: 0x7FFE870DEA60
        public void set_KeySize(){} // RVA: 0x7FFE870DEA90
        public void get_Mode(){} // RVA: 0x7FFE870DEAC0
        public void set_Mode(){} // RVA: 0x7FFE870DEAF0
        public void get_Padding(){} // RVA: 0x7FFE870DEBA0
        public void set_Padding(){} // RVA: 0x7FFE870DEBD0
        public void CreateDecryptor(){} // RVA: 0x7FFE870DEC30 | overloaded x2
        public void CreateEncryptor(){} // RVA: 0x7FFE870DEDD0 | overloaded x2
        public void Dispose(){} // RVA: 0x7FFE870DEF70
        public void GenerateIV(){} // RVA: 0x7FFE86940B40
        public void GenerateKey(){} // RVA: 0x7FFE86940B10
    }

    public class AesTransform : SymmetricTransform
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE870DF4A0
        public void ECB(){} // RVA: 0x7FFE870DFCC0
        public void SubByte(){} // RVA: 0x7FFE870DFCF0
        public void Encrypt128(){} // RVA: 0x7FFE870DFDE0
        public void Decrypt128(){} // RVA: 0x7FFE870E2BB0
        public void .cctor(){} // RVA: 0x7FFE870E59B0
    }

    public class AsnEncodedData : Object
    {
        public System.Security.Cryptography.Oid _oid; // 0x10
        public byte[] _raw; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87773850 | overloaded x4
        public void get_Oid(){} // RVA: 0x7FFE81116380
        public void set_Oid(){} // RVA: 0x7FFE87773940
        public void get_RawData(){} // RVA: 0x7FFE810FE7C0
        public void set_RawData(){} // RVA: 0x7FFE87773A70
        public void CopyFrom(){} // RVA: 0x7FFE87773BB0
        public void Format(){} // RVA: 0x7FFE87773CA0
        public void ToString(){} // RVA: 0x7FFE87773D40
        public void Default(){} // RVA: 0x7FFE87774030
        public void BasicConstraintsExtension(){} // RVA: 0x7FFE87774220
        public void EnhancedKeyUsageExtension(){} // RVA: 0x7FFE877743F0
        public void KeyUsageExtension(){} // RVA: 0x7FFE877745C0
        public void SubjectKeyIdentifierExtension(){} // RVA: 0x7FFE87774790
        public void SubjectAltName(){} // RVA: 0x7FFE87774960
        public void NetscapeCertType(){} // RVA: 0x7FFE87774CA0
    }

    public class AsymmetricAlgorithm : Object
    {
        public int KeySizeValue; // 0x10
        public System.Security.Cryptography.KeySizes[] LegalKeySizesValue; // 0x18
        public object field_2; // 0x2E0
        public object field_3; // 0x2E1

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Dispose(){} // RVA: 0x7FFE810FB310 | overloaded x2
        public void Clear(){} // RVA: 0x7FFE867B6F20
        public void get_KeySize(){} // RVA: 0x7FFE811485C0
        public void set_KeySize(){} // RVA: 0x7FFE867B6F90
        public void get_LegalKeySizes(){} // RVA: 0x7FFE867B70E0
        public void get_SignatureAlgorithm(){} // RVA: 0x7FFE867B7160
        public void get_KeyExchangeAlgorithm(){} // RVA: 0x7FFE867B71A0
        public void Create(){} // RVA: 0x7FFE867B7240 | overloaded x2
        public void FromXmlString(){} // RVA: 0x7FFE867B7320
        public void ToXmlString(){} // RVA: 0x7FFE867B7360
        public void ExportEncryptedPkcs8PrivateKey(){} // RVA: 0x7FFE867B73E0 | overloaded x2
        public void ExportPkcs8PrivateKey(){} // RVA: 0x7FFE867B7420
        public void ExportSubjectPublicKeyInfo(){} // RVA: 0x7FFE867B7460
        public void ImportEncryptedPkcs8PrivateKey(){} // RVA: 0x7FFE867B74E0 | overloaded x2
        public void ImportPkcs8PrivateKey(){} // RVA: 0x7FFE867B7520
        public void ImportSubjectPublicKeyInfo(){} // RVA: 0x7FFE867B7560
        public void TryExportEncryptedPkcs8PrivateKey(){} // RVA: 0x7FFE867B75E0 | overloaded x2
        public void TryExportPkcs8PrivateKey(){} // RVA: 0x7FFE867B7620
        public void TryExportSubjectPublicKeyInfo(){} // RVA: 0x7FFE867B7660
    }

    public class AsymmetricKeyExchangeDeformatter : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_Parameters(){} // RVA: 0x7FFE80E2E2E0
        public void set_Parameters(){} // RVA: 0x7FFE80E460A0
        public void SetKey(){} // RVA: 0x7FFE80E460A0
        public void DecryptKeyExchange(){} // RVA: 0x7FFE80E2E390
    }

    public class AsymmetricKeyExchangeFormatter : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_Parameters(){} // RVA: 0x7FFE80E2E2E0
        public void SetKey(){} // RVA: 0x7FFE80E460A0
        public void CreateKeyExchange(){} // RVA: 0x7FFE80E3FC10 | overloaded x2
    }

    public class AsymmetricSignatureDeformatter : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void SetKey(){} // RVA: 0x7FFE80E460A0
        public void SetHashAlgorithm(){} // RVA: 0x7FFE80E460A0
        public void VerifySignature(){} // RVA: 0x7FFE80E32650 | overloaded x2
    }

    public class AsymmetricSignatureFormatter : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void SetKey(){} // RVA: 0x7FFE80E460A0
        public void SetHashAlgorithm(){} // RVA: 0x7FFE80E460A0
        public void CreateSignature(){} // RVA: 0x7FFE80E2E390 | overloaded x2
    }

}