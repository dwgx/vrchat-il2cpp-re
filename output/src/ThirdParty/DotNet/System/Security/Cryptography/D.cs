// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Cryptography
// Classes: 11
// Methods: 130

namespace ThirdParty.DotNet.System.Security.Cryptography
{
    public class DES
    {
        public System.Security.Cryptography.KeySizes[] s_legalBlockSizes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C78A90
        public void get_Key(){} // RVA: 0x5C78BC0
        public void set_Key(){} // RVA: 0x5C78CC0
        public void Create(){} // RVA: 0x5C78FC0 | overloaded x2
        public void IsWeakKey(){} // RVA: 0x5C790A0
        public void IsSemiWeakKey(){} // RVA: 0x5C791F0
        public void IsLegalKeySize(){} // RVA: 0x5C793D0
        public void QuadWordFromBigEndian(){} // RVA: 0x5C793E0
        public void .cctor(){} // RVA: 0x5C79490
    }

    public class DESCryptoServiceProvider
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C79700
        public void CreateEncryptor(){} // RVA: 0x5C798A0
        public void CreateDecryptor(){} // RVA: 0x5C79A50
        public void GenerateKey(){} // RVA: 0x5C79C00
        public void GenerateIV(){} // RVA: 0x5C79D80
    }

    public class DESTransform
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5CA52B0
        public void CipherFunct(){} // RVA: 0x5CA5720
        public void Permutation(){} // RVA: 0x5CA5A00
        public void BSwap(){} // RVA: 0x5CA5D90
        public void SetKey(){} // RVA: 0x5CA5E20
        public void ProcessBlock(){} // RVA: 0x5CA61F0
        public void ECB(){} // RVA: 0x5CA6610
        public void GetStrongKey(){} // RVA: 0x5CA66E0
        public void .cctor(){} // RVA: 0x5CA6830
    }

    public class DSA
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void Create(){} // RVA: 0x5C7C6C0 | overloaded x4
        public void CreateSignature(){} // RVA: 0xCE10
        public void VerifySignature(){} // RVA: 0x5C7D1F0 | overloaded x2
        public void HashData(){} // RVA: 0x5C79FD0 | overloaded x2
        public void SignData(){} // RVA: 0x5C7A220 | overloaded x3
        public void VerifyData(){} // RVA: 0x5C7CDE0 | overloaded x4
        public void FromXmlString(){} // RVA: 0x5C7A6A0
        public void ToXmlString(){} // RVA: 0x5C7B9F0
        public void ExportParameters(){}
        public void ImportParameters(){}
        public void DerivedClassMustOverride(){} // RVA: 0x5C7C4F0
        public void HashAlgorithmNameNullOrEmpty(){} // RVA: 0x5C7C570
        public void TryCreateSignature(){} // RVA: 0x5C7C7B0
        public void TryHashData(){} // RVA: 0x5C7C930
        public void TrySignData(){} // RVA: 0x5C7CC20
    }

    public class DSACryptoServiceProvider
    {
        public int PROV_DSS_DH;
        public Mono.Security.Cryptography.KeyPairPersistence store; // 0x20
        public bool persistKey; // 0x28
        public bool persisted; // 0x29
        public bool privateKeyExportable; // 0x2A
        public bool m_disposed; // 0x2B
        public Mono.Security.Cryptography.DSAManaged dsa; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5CA6E30 | overloaded x4
        public void Common(){} // RVA: 0x5CA74A0 | overloaded x2
        public void Finalize(){} // RVA: 0x5AAC950
        public void get_KeyExchangeAlgorithm(){} // RVA: 0x519240
        public void get_KeySize(){} // RVA: 0x5CA75B0
        public void get_PersistKeyInCsp(){} // RVA: 0x6E8A80
        public void set_PersistKeyInCsp(){} // RVA: 0x6E8B80
        public void get_PublicOnly(){} // RVA: 0x5CA75E0
        public void get_SignatureAlgorithm(){} // RVA: 0x5CA7650
        public void get_UseMachineKeyStore(){} // RVA: 0x5CA7690
        public void set_UseMachineKeyStore(){} // RVA: 0x5CA76D0
        public void ExportParameters(){} // RVA: 0x5CA7710
        public void ImportParameters(){} // RVA: 0x5CA77E0
        public void CreateSignature(){} // RVA: 0x5CA7840
        public void SignData(){} // RVA: 0x5CA7A80 | overloaded x3
        public void SignHash(){} // RVA: 0x5CA7B20
        public void VerifyData(){} // RVA: 0x5CA7D10
        public void VerifyHash(){} // RVA: 0x5CA7E70
        public void VerifySignature(){} // RVA: 0x5CA8080
        public void HashData(){} // RVA: 0x5CA8200 | overloaded x2
        public void Dispose(){} // RVA: 0x5C94060
        public void OnKeyGenerated(){} // RVA: 0x5CA8320
        public void get_CspKeyContainerInfo(){} // RVA: 0x519240
        public void ExportCspBlob(){} // RVA: 0x5CA83B0
        public void ImportCspBlob(){} // RVA: 0x5CA83D0
    }

    public class DSAParameters
    {
    }

    public class DSASignatureDeformatter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C7D340 | overloaded x2
        public void SetKey(){} // RVA: 0x5C7D4A0
        public void SetHashAlgorithm(){} // RVA: 0x5C7D600
        public void VerifySignature(){} // RVA: 0x5C7D6F0
    }

    public class DSASignatureDescription
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C9D370
    }

    public class DSASignatureFormatter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C7D8E0 | overloaded x2
        public void SetKey(){} // RVA: 0x5C7DA40
        public void SetHashAlgorithm(){} // RVA: 0x5C7DBA0
        public void CreateSignature(){} // RVA: 0x5C7DC90
    }

    public class DerSequenceReader
    {
        public System.Globalization.DateTimeFormatInfo s_validityDateTimeFormatInfo;
        public System.Text.Encoding s_utf8EncodingWithExceptionFallback; // 0x8

        // ── Methods ──
        public void set_ContentLength(){} // RVA: 0x99E0D0
        public void .ctor(){} // RVA: 0x6C2FBD0 | overloaded x3
        public void get_HasData(){} // RVA: 0x6C2FD20
        public void PeekTag(){} // RVA: 0x6C2FD30
        public void SkipValue(){} // RVA: 0x6C2FE10
        public void ReadNextEncodedValue(){} // RVA: 0x6C2FE60
        public void ReadBoolean(){} // RVA: 0x6C2FF20
        public void ReadInteger(){} // RVA: 0x6C2FFF0
        public void ReadIntegerBytes(){} // RVA: 0x6C30180
        public void ReadBitString(){} // RVA: 0x6C301B0
        public void ReadOctetString(){} // RVA: 0x6C30340
        public void ReadOidAsString(){} // RVA: 0x6C30370
        public void ReadUtf8String(){} // RVA: 0x6C307D0
        public void ReadCollectionWithTag(){} // RVA: 0x6C308C0
        public void ReadSequence(){} // RVA: 0x6C309A0
        public void ReadSet(){} // RVA: 0x6C309B0
        public void ReadPrintableString(){} // RVA: 0x6C309C0
        public void ReadIA5String(){} // RVA: 0x6C30AB0
        public void ReadT61String(){} // RVA: 0x6C30BA0
        public void ReadX509Date(){} // RVA: 0x6C30F80
        public void ReadUtcTime(){} // RVA: 0x6C31060
        public void ReadGeneralizedTime(){} // RVA: 0x6C310B0
        public void ReadBMPString(){} // RVA: 0x6C31100
        public void TrimTrailingNulls(){} // RVA: 0x6C311F0
        public void ReadTime(){} // RVA: 0x6C31260
        public void ReadContentAsBytes(){} // RVA: 0x6C31520
        public void EatTag(){} // RVA: 0x6C315D0
        public void CheckTag(){} // RVA: 0x6C31650
        public void EatLength(){} // RVA: 0x6C31780
        public void ScanContentLength(){} // RVA: 0x6C317C0
    }

    public class DeriveBytes
    {
        // ── Methods ──
        public void GetBytes(){} // RVA: 0x1BCC0
        public void Reset(){} // RVA: 0x24A50
        public void Dispose(){} // RVA: 0x2DD310 | overloaded x2
        public void .ctor(){} // RVA: 0x2DD310
    }

}