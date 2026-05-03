// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Cryptography
// Classes: 11
// Methods: 130

namespace ThirdParty.DotNet.System.Security.Cryptography
{
    public class DES : SymmetricAlgorithm
    {
        public System.Security.Cryptography.KeySizes[] s_legalBlockSizes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867B9930
        public void get_Key(){} // RVA: 0x7FFE867B9A60
        public void set_Key(){} // RVA: 0x7FFE867B9B60
        public void Create(){} // RVA: 0x7FFE867B9E60 | overloaded x2
        public void IsWeakKey(){} // RVA: 0x7FFE867B9F40
        public void IsSemiWeakKey(){} // RVA: 0x7FFE867BA090
        public void IsLegalKeySize(){} // RVA: 0x7FFE867BA270
        public void QuadWordFromBigEndian(){} // RVA: 0x7FFE867BA280
        public void .cctor(){} // RVA: 0x7FFE867BA330
    }

    public class DESCryptoServiceProvider : DES
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867BA5A0
        public void CreateEncryptor(){} // RVA: 0x7FFE867BA740
        public void CreateDecryptor(){} // RVA: 0x7FFE867BA8F0
        public void GenerateKey(){} // RVA: 0x7FFE867BAAA0
        public void GenerateIV(){} // RVA: 0x7FFE867BAC20
    }

    public class DESTransform : SymmetricTransform
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867E61B0
        public void CipherFunct(){} // RVA: 0x7FFE867E6620
        public void Permutation(){} // RVA: 0x7FFE867E6900
        public void BSwap(){} // RVA: 0x7FFE867E6C90
        public void SetKey(){} // RVA: 0x7FFE867E6D20
        public void ProcessBlock(){} // RVA: 0x7FFE867E70F0
        public void ECB(){} // RVA: 0x7FFE867E7510
        public void GetStrongKey(){} // RVA: 0x7FFE867E75E0
        public void .cctor(){} // RVA: 0x7FFE867E7730
    }

    public class DSA : AsymmetricAlgorithm
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Create(){} // RVA: 0x7FFE867BD560 | overloaded x4
        public void CreateSignature(){} // RVA: 0x7FFE80E2E390
        public void VerifySignature(){} // RVA: 0x7FFE867BE090 | overloaded x2
        public void HashData(){} // RVA: 0x7FFE867BAE70 | overloaded x2
        public void SignData(){} // RVA: 0x7FFE867BB0C0 | overloaded x3
        public void VerifyData(){} // RVA: 0x7FFE867BDC80 | overloaded x4
        public void FromXmlString(){} // RVA: 0x7FFE867BB540
        public void ToXmlString(){} // RVA: 0x7FFE867BC890
        public void ExportParameters(){}
        public void ImportParameters(){}
        public void DerivedClassMustOverride(){} // RVA: 0x7FFE867BD390
        public void HashAlgorithmNameNullOrEmpty(){} // RVA: 0x7FFE867BD410
        public void TryCreateSignature(){} // RVA: 0x7FFE867BD650
        public void TryHashData(){} // RVA: 0x7FFE867BD7D0
        public void TrySignData(){} // RVA: 0x7FFE867BDAC0
    }

    public class DSACryptoServiceProvider : DSA
    {
        public int PROV_DSS_DH;
        public Mono.Security.Cryptography.KeyPairPersistence store; // 0x20
        public bool persistKey; // 0x28
        public bool persisted; // 0x29
        public bool privateKeyExportable; // 0x2A
        public bool m_disposed; // 0x2B
        public Mono.Security.Cryptography.DSAManaged dsa; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867E7D30 | overloaded x4
        public void Common(){} // RVA: 0x7FFE867E83A0 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFE865ED780
        public void get_KeyExchangeAlgorithm(){} // RVA: 0x7FFE813240E0
        public void get_KeySize(){} // RVA: 0x7FFE867E84B0
        public void get_PersistKeyInCsp(){} // RVA: 0x7FFE815F1380
        public void set_PersistKeyInCsp(){} // RVA: 0x7FFE81C15740
        public void get_PublicOnly(){} // RVA: 0x7FFE867E84E0
        public void get_SignatureAlgorithm(){} // RVA: 0x7FFE867E8550
        public void get_UseMachineKeyStore(){} // RVA: 0x7FFE867E8590
        public void set_UseMachineKeyStore(){} // RVA: 0x7FFE867E85D0
        public void ExportParameters(){} // RVA: 0x7FFE867E8610
        public void ImportParameters(){} // RVA: 0x7FFE867E86E0
        public void CreateSignature(){} // RVA: 0x7FFE867E8740
        public void SignData(){} // RVA: 0x7FFE867E8980 | overloaded x3
        public void SignHash(){} // RVA: 0x7FFE867E8A20
        public void VerifyData(){} // RVA: 0x7FFE867E8C10
        public void VerifyHash(){} // RVA: 0x7FFE867E8D70
        public void VerifySignature(){} // RVA: 0x7FFE867E8F80
        public void HashData(){} // RVA: 0x7FFE867E9100 | overloaded x2
        public void Dispose(){} // RVA: 0x7FFE867D4F00
        public void OnKeyGenerated(){} // RVA: 0x7FFE867E9220
        public void get_CspKeyContainerInfo(){} // RVA: 0x7FFE813240E0
        public void ExportCspBlob(){} // RVA: 0x7FFE867E92B0
        public void ImportCspBlob(){} // RVA: 0x7FFE867E92D0
    }

    public class DSAParameters : ValueType
    {
    }

    public class DSASignatureDeformatter : AsymmetricSignatureDeformatter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867BE1E0 | overloaded x2
        public void SetKey(){} // RVA: 0x7FFE867BE340
        public void SetHashAlgorithm(){} // RVA: 0x7FFE867BE4A0
        public void VerifySignature(){} // RVA: 0x7FFE867BE590
    }

    public class DSASignatureDescription : SignatureDescription
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867DE210
    }

    public class DSASignatureFormatter : AsymmetricSignatureFormatter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867BE780 | overloaded x2
        public void SetKey(){} // RVA: 0x7FFE867BE8E0
        public void SetHashAlgorithm(){} // RVA: 0x7FFE867BEA40
        public void CreateSignature(){} // RVA: 0x7FFE867BEB30
    }

    public class DerSequenceReader : Object
    {
        public System.Globalization.DateTimeFormatInfo s_validityDateTimeFormatInfo;
        public System.Text.Encoding s_utf8EncodingWithExceptionFallback; // 0x8

        // ── Methods ──
        public void set_ContentLength(){} // RVA: 0x7FFE8170B670
        public void .ctor(){} // RVA: 0x7FFE87770A80 | overloaded x3
        public void get_HasData(){} // RVA: 0x7FFE87770BD0
        public void PeekTag(){} // RVA: 0x7FFE87770BE0
        public void SkipValue(){} // RVA: 0x7FFE87770CC0
        public void ReadNextEncodedValue(){} // RVA: 0x7FFE87770D10
        public void ReadBoolean(){} // RVA: 0x7FFE87770DD0
        public void ReadInteger(){} // RVA: 0x7FFE87770EA0
        public void ReadIntegerBytes(){} // RVA: 0x7FFE87771030
        public void ReadBitString(){} // RVA: 0x7FFE87771060
        public void ReadOctetString(){} // RVA: 0x7FFE877711F0
        public void ReadOidAsString(){} // RVA: 0x7FFE87771220
        public void ReadUtf8String(){} // RVA: 0x7FFE87771680
        public void ReadCollectionWithTag(){} // RVA: 0x7FFE87771770
        public void ReadSequence(){} // RVA: 0x7FFE87771850
        public void ReadSet(){} // RVA: 0x7FFE87771860
        public void ReadPrintableString(){} // RVA: 0x7FFE87771870
        public void ReadIA5String(){} // RVA: 0x7FFE87771960
        public void ReadT61String(){} // RVA: 0x7FFE87771A50
        public void ReadX509Date(){} // RVA: 0x7FFE87771E30
        public void ReadUtcTime(){} // RVA: 0x7FFE87771F10
        public void ReadGeneralizedTime(){} // RVA: 0x7FFE87771F60
        public void ReadBMPString(){} // RVA: 0x7FFE87771FB0
        public void TrimTrailingNulls(){} // RVA: 0x7FFE877720A0
        public void ReadTime(){} // RVA: 0x7FFE87772110
        public void ReadContentAsBytes(){} // RVA: 0x7FFE877723D0
        public void EatTag(){} // RVA: 0x7FFE87772480
        public void CheckTag(){} // RVA: 0x7FFE87772500
        public void EatLength(){} // RVA: 0x7FFE87772630
        public void ScanContentLength(){} // RVA: 0x7FFE87772670
    }

    public class DeriveBytes : Object
    {
        // ── Methods ──
        public void GetBytes(){} // RVA: 0x7FFE80E3D230
        public void Reset(){} // RVA: 0x7FFE80E45FE0
        public void Dispose(){} // RVA: 0x7FFE810FB310 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

}