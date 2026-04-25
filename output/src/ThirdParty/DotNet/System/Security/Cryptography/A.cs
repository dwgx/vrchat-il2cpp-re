// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Cryptography
// Classes: 12
// Methods: 131

namespace ThirdParty.DotNet.System.Security.Cryptography
{
    public class Aes : SymmetricAlgorithm
    {
        public System.Security.Cryptography.KeySizes[] s_legalBlockSizes;
        public System.Security.Cryptography.KeySizes[] s_legalKeySizes; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC840CF70
        public void Create(){} // RVA: 0x7FFAC840D240 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC840D380
    }

    public class AesCcm : Object
    {
        public object NonceByteSizes;
        public object TagByteSizes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8446C50 | overloaded x2
        public void get_NonceByteSizes(){} // RVA: 0x7FFAC8446C90
        public void get_TagByteSizes(){} // RVA: 0x7FFAC8446CD0
        public void Decrypt(){} // RVA: 0x7FFAC8446D50 | overloaded x2
        public void Dispose(){} // RVA: 0x7FFAC2F21310
        public void Encrypt(){} // RVA: 0x7FFAC8446DD0 | overloaded x2
    }

    public class AesCryptoServiceProvider : Aes
    {
        public object IV;
        public object Key;
        public object KeySize;
        public object FeedbackSize;
        public object Mode;
        public object Padding;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D36B70
        public void GenerateIV(){} // RVA: 0x7FFAC8D36BD0
        public void GenerateKey(){} // RVA: 0x7FFAC8D36C40
        public void CreateDecryptor(){} // RVA: 0x7FFAC8435880 | overloaded x2
        public void CreateEncryptor(){} // RVA: 0x7FFAC8435810 | overloaded x2
        public void get_IV(){} // RVA: 0x7FFAC8434EA0
        public void set_IV(){} // RVA: 0x7FFAC8D36ED0
        public void get_Key(){} // RVA: 0x7FFAC8435100
        public void set_Key(){} // RVA: 0x7FFAC8D36EE0
        public void get_KeySize(){} // RVA: 0x7FFAC358A870
        public void set_KeySize(){} // RVA: 0x7FFAC8D36EF0
        public void get_FeedbackSize(){} // RVA: 0x7FFAC33D5A20
        public void set_FeedbackSize(){} // RVA: 0x7FFAC8434E10
        public void get_Mode(){} // RVA: 0x7FFAC33BD4A0
        public void set_Mode(){} // RVA: 0x7FFAC8D36F00
        public void get_Padding(){} // RVA: 0x7FFAC2FC2080
        public void set_Padding(){} // RVA: 0x7FFAC84355C0
        public void Dispose(){} // RVA: 0x7FFAC8D36FD0
    }

    public class AesGcm : Object
    {
        public object NonceByteSizes;
        public object TagByteSizes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8446E50 | overloaded x2
        public void get_NonceByteSizes(){} // RVA: 0x7FFAC8446E90
        public void get_TagByteSizes(){} // RVA: 0x7FFAC8446ED0
        public void Decrypt(){} // RVA: 0x7FFAC8446F50 | overloaded x2
        public void Dispose(){} // RVA: 0x7FFAC2F21310
        public void Encrypt(){} // RVA: 0x7FFAC8446FD0 | overloaded x2
    }

    public class AesManaged : Aes
    {
        public System.Security.Cryptography.RijndaelManaged FeedbackSize; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D362D0
        public void get_FeedbackSize(){} // RVA: 0x7FFAC8D36450
        public void set_FeedbackSize(){} // RVA: 0x7FFAC8D36480
        public void get_IV(){} // RVA: 0x7FFAC8D364B0
        public void set_IV(){} // RVA: 0x7FFAC8D364E0
        public void get_Key(){} // RVA: 0x7FFAC8D36510
        public void set_Key(){} // RVA: 0x7FFAC8D36540
        public void get_KeySize(){} // RVA: 0x7FFAC8D36570
        public void set_KeySize(){} // RVA: 0x7FFAC8D365A0
        public void get_Mode(){} // RVA: 0x7FFAC8D365D0
        public void set_Mode(){} // RVA: 0x7FFAC8D36600
        public void get_Padding(){} // RVA: 0x7FFAC8D366B0
        public void set_Padding(){} // RVA: 0x7FFAC8D366E0
        public void CreateDecryptor(){} // RVA: 0x7FFAC8D36740 | overloaded x2
        public void CreateEncryptor(){} // RVA: 0x7FFAC8D36910 | overloaded x2
        public void Dispose(){} // RVA: 0x7FFAC8D36AB0
        public void GenerateIV(){} // RVA: 0x7FFAC8597360
        public void GenerateKey(){} // RVA: 0x7FFAC8597330
    }

    public class AesTransform : SymmetricTransform
    {
        public uint[] expandedKey; // 0x58
        public int Nk; // 0x60
        public int Nr; // 0x64
        public uint[] Rcon;
        public byte[] SBox; // 0x8
        public byte[] iSBox; // 0x10
        public uint[] T0; // 0x18
        public uint[] T1; // 0x20
        public uint[] T2; // 0x28
        public uint[] T3; // 0x30
        public uint[] iT0; // 0x38
        public uint[] iT1; // 0x40
        public uint[] iT2; // 0x48
        public uint[] iT3; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D36FE0
        public void ECB(){} // RVA: 0x7FFAC8D37800
        public void SubByte(){} // RVA: 0x7FFAC8D37830
        public void Encrypt128(){} // RVA: 0x7FFAC8D37920
        public void Decrypt128(){} // RVA: 0x7FFAC8D3A6F0
        public void .cctor(){} // RVA: 0x7FFAC8D3D4F0
    }

    public class AsnEncodedData : Object
    {
        public System.Security.Cryptography.Oid Oid; // 0x10
        public byte[] RawData; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93CB120 | overloaded x4
        public void get_Oid(){} // RVA: 0x7FFAC2F3C380
        public void set_Oid(){} // RVA: 0x7FFAC93CB210
        public void get_RawData(){} // RVA: 0x7FFAC2F247C0
        public void set_RawData(){} // RVA: 0x7FFAC93CB340
        public void CopyFrom(){} // RVA: 0x7FFAC93CB480
        public void Format(){} // RVA: 0x7FFAC93CB570
        public void ToString(){} // RVA: 0x7FFAC93CB610
        public void Default(){} // RVA: 0x7FFAC93CB900
        public void BasicConstraintsExtension(){} // RVA: 0x7FFAC93CBAF0
        public void EnhancedKeyUsageExtension(){} // RVA: 0x7FFAC93CBCC0
        public void KeyUsageExtension(){} // RVA: 0x7FFAC93CBE90
        public void SubjectKeyIdentifierExtension(){} // RVA: 0x7FFAC93CC060
        public void SubjectAltName(){} // RVA: 0x7FFAC93CC230
        public void NetscapeCertType(){} // RVA: 0x7FFAC93CC570
    }

    public class AsymmetricAlgorithm : Object
    {
        public int KeySize; // 0x10
        public System.Security.Cryptography.KeySizes[] LegalKeySizes; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Dispose(){} // RVA: 0x7FFAC2F21310 | overloaded x2
        public void Clear(){} // RVA: 0x7FFAC840D610
        public void get_KeySize(){} // RVA: 0x7FFAC2F6E5C0
        public void set_KeySize(){} // RVA: 0x7FFAC840D680
        public void get_LegalKeySizes(){} // RVA: 0x7FFAC840D7D0
        public void get_SignatureAlgorithm(){} // RVA: 0x7FFAC840D850
        public void get_KeyExchangeAlgorithm(){} // RVA: 0x7FFAC840D890
        public void Create(){} // RVA: 0x7FFAC840D930 | overloaded x2
        public void FromXmlString(){} // RVA: 0x7FFAC840DA10
        public void ToXmlString(){} // RVA: 0x7FFAC840DA50
        public void ExportEncryptedPkcs8PrivateKey(){} // RVA: 0x7FFAC840DAD0 | overloaded x2
        public void ExportPkcs8PrivateKey(){} // RVA: 0x7FFAC840DB10
        public void ExportSubjectPublicKeyInfo(){} // RVA: 0x7FFAC840DB50
        public void ImportEncryptedPkcs8PrivateKey(){} // RVA: 0x7FFAC840DBD0 | overloaded x2
        public void ImportPkcs8PrivateKey(){} // RVA: 0x7FFAC840DC10
        public void ImportSubjectPublicKeyInfo(){} // RVA: 0x7FFAC840DC50
        public void TryExportEncryptedPkcs8PrivateKey(){} // RVA: 0x7FFAC840DCD0 | overloaded x2
        public void TryExportPkcs8PrivateKey(){} // RVA: 0x7FFAC840DD10
        public void TryExportSubjectPublicKeyInfo(){} // RVA: 0x7FFAC840DD50
    }

    public class AsymmetricKeyExchangeDeformatter : Object
    {
        public object Parameters;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_Parameters(){} // RVA: 0x7FFAC2C58E90
        public void set_Parameters(){} // RVA: 0x7FFAC2C70A40
        public void SetKey(){} // RVA: 0x7FFAC2C70A40
        public void DecryptKeyExchange(){} // RVA: 0x7FFAC2C58F40
    }

    public class AsymmetricKeyExchangeFormatter : Object
    {
        public object Parameters;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_Parameters(){} // RVA: 0x7FFAC2C58E90
        public void SetKey(){} // RVA: 0x7FFAC2C70A40
        public void CreateKeyExchange(){} // RVA: 0x7FFAC2C6A6F0 | overloaded x2
    }

    public class AsymmetricSignatureDeformatter : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void SetKey(){} // RVA: 0x7FFAC2C70A40
        public void SetHashAlgorithm(){} // RVA: 0x7FFAC2C70A40
        public void VerifySignature(){} // RVA: 0x7FFAC2C5D200 | overloaded x2
    }

    public class AsymmetricSignatureFormatter : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void SetKey(){} // RVA: 0x7FFAC2C70A40
        public void SetHashAlgorithm(){} // RVA: 0x7FFAC2C70A40
        public void CreateSignature(){} // RVA: 0x7FFAC2C58F40 | overloaded x2
    }

}