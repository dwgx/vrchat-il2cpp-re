// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Cryptography
// Classes: 10
// Methods: 107

namespace ThirdParty.DotNet.System.Security.Cryptography
{
    public class DES : SymmetricAlgorithm
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA66A70
        public void get_Key(){} // RVA: 0x7ADA66BA0
        public void set_Key(){} // RVA: 0x7ADA66CA0
        public void Create(){} // RVA: 0x7ADA66FA0
        public void IsWeakKey(){} // RVA: 0x7ADA67080
        public void IsSemiWeakKey(){} // RVA: 0x7ADA671D0
        public void IsLegalKeySize(){} // RVA: 0x7ADA673B0
        public void QuadWordFromBigEndian(){} // RVA: 0x7ADA673C0
        public void .cctor(){} // RVA: 0x7ADA67470
    }

    public class DESCryptoServiceProvider : DES
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA676E0
        public void CreateEncryptor(){} // RVA: 0x7ADA67880
        public void CreateDecryptor(){} // RVA: 0x7ADA67A30
        public void GenerateKey(){} // RVA: 0x7ADA67BE0
        public void GenerateIV(){} // RVA: 0x7ADA67D60
    }

    public class DESTransform : SymmetricTransform
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA936E0
        public void CipherFunct(){} // RVA: 0x7ADA93B50
        public void Permutation(){} // RVA: 0x7ADA93E20
        public void BSwap(){} // RVA: 0x7ADA941C0
        public void SetKey(){} // RVA: 0x7ADA94250
        public void ProcessBlock(){} // RVA: 0x7ADA94650
        public void ECB(){} // RVA: 0x7ADA94AA0
        public void GetStrongKey(){} // RVA: 0x7ADA94B70
        public void .cctor(){} // RVA: 0x7ADA94CC0
    }

    public class DSA : AsymmetricAlgorithm
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void Create(){} // RVA: 0x7ADA6A6A0
        public void CreateSignature(){} // RVA: 0x7A7E00B20
        public void VerifySignature(){} // RVA: 0x7ADA6B1E0
        public void HashData(){} // RVA: 0x7ADA67FB0
        public void SignData(){} // RVA: 0x7ADA68200
        public void VerifyData(){} // RVA: 0x7ADA6ADD0
        public void FromXmlString(){} // RVA: 0x7ADA68680
        public void ToXmlString(){} // RVA: 0x7ADA699C0
        public void ExportParameters(){} // RVA: 0x7A7E00E20
        public void ImportParameters(){} // RVA: 0x7A7E18800
        public void DerivedClassMustOverride(){} // RVA: 0x7ADA6A4D0
        public void HashAlgorithmNameNullOrEmpty(){} // RVA: 0x7ADA6A550
        public void TryCreateSignature(){} // RVA: 0x7ADA6A7A0
        public void TryHashData(){} // RVA: 0x7ADA6A920
        public void TrySignData(){} // RVA: 0x7ADA6AC10
    }

    public class DSACryptoServiceProvider : DSA
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA952C0
        public void Common(){} // RVA: 0x7ADA95940
        public void Finalize(){} // RVA: 0x7AD899E40
        public void get_KeyExchangeAlgorithm(){} // RVA: 0x7A82D1450
        public void get_KeySize(){} // RVA: 0x7ADA95A50
        public void get_PersistKeyInCsp(){} // RVA: 0x7A84A5BD0
        public void set_PersistKeyInCsp(){} // RVA: 0x7A84A5CD0
        public void get_PublicOnly(){} // RVA: 0x7ADA95A80
        public void get_SignatureAlgorithm(){} // RVA: 0x7ADA95AF0
        public void get_UseMachineKeyStore(){} // RVA: 0x7ADA95B30
        public void set_UseMachineKeyStore(){} // RVA: 0x7ADA95B70
        public void ExportParameters(){} // RVA: 0x7ADA95BB0
        public void ImportParameters(){} // RVA: 0x7ADA95C80
        public void CreateSignature(){} // RVA: 0x7ADA95CE0
        public void SignData(){} // RVA: 0x7ADA95F20
        public void SignHash(){} // RVA: 0x7ADA95FC0
        public void VerifyData(){} // RVA: 0x7ADA961B0
        public void VerifyHash(){} // RVA: 0x7ADA96310
        public void VerifySignature(){} // RVA: 0x7ADA96520
        public void HashData(){} // RVA: 0x7ADA966A0
        public void Dispose(){} // RVA: 0x7ADA82210
        public void OnKeyGenerated(){} // RVA: 0x7ADA967C0
        public void get_CspKeyContainerInfo(){} // RVA: 0x7A82D1450
        public void ExportCspBlob(){} // RVA: 0x7ADA96850
        public void ImportCspBlob(){} // RVA: 0x7ADA96870
    }

    public class DSASignatureDeformatter : AsymmetricSignatureDeformatter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA6B330
        public void SetKey(){} // RVA: 0x7ADA6B490
        public void SetHashAlgorithm(){} // RVA: 0x7ADA6B5F0
        public void VerifySignature(){} // RVA: 0x7ADA6B6E0
    }

    public class DSASignatureDescription : SignatureDescription
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA8B750
    }

    public class DSASignatureFormatter : AsymmetricSignatureFormatter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA6B8D0
        public void SetKey(){} // RVA: 0x7ADA6BA30
        public void SetHashAlgorithm(){} // RVA: 0x7ADA6BB90
        public void CreateSignature(){} // RVA: 0x7ADA6BC80
    }

    public class DerSequenceReader : Object
    {
        // ── Methods ──
        public void set_ContentLength(){} // RVA: 0x7A8738180
        public void .ctor(){} // RVA: 0x7AEA1EAC0
        public void get_HasData(){} // RVA: 0x7AEA1EC20
        public void PeekTag(){} // RVA: 0x7AEA1EC30
        public void SkipValue(){} // RVA: 0x7AEA1ED10
        public void ReadNextEncodedValue(){} // RVA: 0x7AEA1ED60
        public void ReadBoolean(){} // RVA: 0x7AEA1EE20
        public void ReadInteger(){} // RVA: 0x7AEA1EEF0
        public void ReadIntegerBytes(){} // RVA: 0x7AEA1F080
        public void ReadBitString(){} // RVA: 0x7AEA1F0B0
        public void ReadOctetString(){} // RVA: 0x7AEA1F240
        public void ReadOidAsString(){} // RVA: 0x7AEA1F270
        public void ReadUtf8String(){} // RVA: 0x7AEA1F6E0
        public void ReadCollectionWithTag(){} // RVA: 0x7AEA1F7D0
        public void ReadSequence(){} // RVA: 0x7AEA1F8B0
        public void ReadSet(){} // RVA: 0x7AEA1F8C0
        public void ReadPrintableString(){} // RVA: 0x7AEA1F8D0
        public void ReadIA5String(){} // RVA: 0x7AEA1F9C0
        public void ReadT61String(){} // RVA: 0x7AEA1FAB0
        public void ReadX509Date(){} // RVA: 0x7AEA1FE90
        public void ReadUtcTime(){} // RVA: 0x7AEA1FF70
        public void ReadGeneralizedTime(){} // RVA: 0x7AEA1FFC0
        public void ReadBMPString(){} // RVA: 0x7AEA20010
        public void TrimTrailingNulls(){} // RVA: 0x7AEA20100
        public void ReadTime(){} // RVA: 0x7AEA20170
        public void ReadContentAsBytes(){} // RVA: 0x7AEA20430
        public void EatTag(){} // RVA: 0x7AEA204E0
        public void CheckTag(){} // RVA: 0x7AEA20560
        public void EatLength(){} // RVA: 0x7AEA20690
        public void ScanContentLength(){} // RVA: 0x7AEA206D0
    }

    public class DeriveBytes : Object
    {
        // ── Methods ──
        public void GetBytes(){} // RVA: 0x7A7E00740
        public void Reset(){} // RVA: 0x7A7E18770
        public void Dispose(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7A80D7310
    }

}