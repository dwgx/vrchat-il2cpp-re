// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Cryptography
// Classes: 11
// Methods: 130

namespace ThirdParty.DotNet.System.Security.Cryptography
{
    public class DES
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8728A90
        public void get_Key(){} // RVA: 0x7FFAF8728BC0
        public void set_Key(){} // RVA: 0x7FFAF8728CC0
        public void Create(){} // RVA: 0x7FFAF8728FC0 | overloaded x2
        public void IsWeakKey(){} // RVA: 0x7FFAF87290A0
        public void IsSemiWeakKey(){} // RVA: 0x7FFAF87291F0
        public void IsLegalKeySize(){} // RVA: 0x7FFAF87293D0
        public void QuadWordFromBigEndian(){} // RVA: 0x7FFAF87293E0
        public void .cctor(){} // RVA: 0x7FFAF8729490
    }

    public class DESCryptoServiceProvider
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8729700
        public void CreateEncryptor(){} // RVA: 0x7FFAF87298A0
        public void CreateDecryptor(){} // RVA: 0x7FFAF8729A50
        public void GenerateKey(){} // RVA: 0x7FFAF8729C00
        public void GenerateIV(){} // RVA: 0x7FFAF8729D80
    }

    public class DESTransform
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF87552B0
        public void CipherFunct(){} // RVA: 0x7FFAF8755720
        public void Permutation(){} // RVA: 0x7FFAF8755A00
        public void BSwap(){} // RVA: 0x7FFAF8755D90
        public void SetKey(){} // RVA: 0x7FFAF8755E20
        public void ProcessBlock(){} // RVA: 0x7FFAF87561F0
        public void ECB(){} // RVA: 0x7FFAF8756610
        public void GetStrongKey(){} // RVA: 0x7FFAF87566E0
        public void .cctor(){} // RVA: 0x7FFAF8756830
    }

    public class DSA
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void Create(){} // RVA: 0x7FFAF872C6C0 | overloaded x4
        public void CreateSignature(){} // RVA: 0x7FFAF2ABCE10
        public void VerifySignature(){} // RVA: 0x7FFAF872D1F0 | overloaded x2
        public void HashData(){} // RVA: 0x7FFAF8729FD0 | overloaded x2
        public void SignData(){} // RVA: 0x7FFAF872A220 | overloaded x3
        public void VerifyData(){} // RVA: 0x7FFAF872CDE0 | overloaded x4
        public void FromXmlString(){} // RVA: 0x7FFAF872A6A0
        public void ToXmlString(){} // RVA: 0x7FFAF872B9F0
        public void ExportParameters(){}
        public void ImportParameters(){}
        public void DerivedClassMustOverride(){} // RVA: 0x7FFAF872C4F0
        public void HashAlgorithmNameNullOrEmpty(){} // RVA: 0x7FFAF872C570
        public void TryCreateSignature(){} // RVA: 0x7FFAF872C7B0
        public void TryHashData(){} // RVA: 0x7FFAF872C930
        public void TrySignData(){} // RVA: 0x7FFAF872CC20
    }

    public class DSACryptoServiceProvider
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8756E30 | overloaded x4
        public void Common(){} // RVA: 0x7FFAF87574A0 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFAF855C950
        public void get_KeyExchangeAlgorithm(){} // RVA: 0x7FFAF2FC9240
        public void get_KeySize(){} // RVA: 0x7FFAF87575B0
        public void get_PersistKeyInCsp(){} // RVA: 0x7FFAF3198A80
        public void set_PersistKeyInCsp(){} // RVA: 0x7FFAF3198B80
        public void get_PublicOnly(){} // RVA: 0x7FFAF87575E0
        public void get_SignatureAlgorithm(){} // RVA: 0x7FFAF8757650
        public void get_UseMachineKeyStore(){} // RVA: 0x7FFAF8757690
        public void set_UseMachineKeyStore(){} // RVA: 0x7FFAF87576D0
        public void ExportParameters(){} // RVA: 0x7FFAF8757710
        public void ImportParameters(){} // RVA: 0x7FFAF87577E0
        public void CreateSignature(){} // RVA: 0x7FFAF8757840
        public void SignData(){} // RVA: 0x7FFAF8757A80 | overloaded x3
        public void SignHash(){} // RVA: 0x7FFAF8757B20
        public void VerifyData(){} // RVA: 0x7FFAF8757D10
        public void VerifyHash(){} // RVA: 0x7FFAF8757E70
        public void VerifySignature(){} // RVA: 0x7FFAF8758080
        public void HashData(){} // RVA: 0x7FFAF8758200 | overloaded x2
        public void Dispose(){} // RVA: 0x7FFAF8744060
        public void OnKeyGenerated(){} // RVA: 0x7FFAF8758320
        public void get_CspKeyContainerInfo(){} // RVA: 0x7FFAF2FC9240
        public void ExportCspBlob(){} // RVA: 0x7FFAF87583B0
        public void ImportCspBlob(){} // RVA: 0x7FFAF87583D0
    }

    public class DSAParameters
    {
    }

    public class DSASignatureDeformatter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF872D340 | overloaded x2
        public void SetKey(){} // RVA: 0x7FFAF872D4A0
        public void SetHashAlgorithm(){} // RVA: 0x7FFAF872D600
        public void VerifySignature(){} // RVA: 0x7FFAF872D6F0
    }

    public class DSASignatureDescription
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF874D370
    }

    public class DSASignatureFormatter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF872D8E0 | overloaded x2
        public void SetKey(){} // RVA: 0x7FFAF872DA40
        public void SetHashAlgorithm(){} // RVA: 0x7FFAF872DBA0
        public void CreateSignature(){} // RVA: 0x7FFAF872DC90
    }

    public class DerSequenceReader
    {
        // ── Methods ──
        public void set_ContentLength(){} // RVA: 0x7FFAF344E0D0
        public void .ctor(){} // RVA: 0x7FFAF96DFBD0 | overloaded x3
        public void get_HasData(){} // RVA: 0x7FFAF96DFD20
        public void PeekTag(){} // RVA: 0x7FFAF96DFD30
        public void SkipValue(){} // RVA: 0x7FFAF96DFE10
        public void ReadNextEncodedValue(){} // RVA: 0x7FFAF96DFE60
        public void ReadBoolean(){} // RVA: 0x7FFAF96DFF20
        public void ReadInteger(){} // RVA: 0x7FFAF96DFFF0
        public void ReadIntegerBytes(){} // RVA: 0x7FFAF96E0180
        public void ReadBitString(){} // RVA: 0x7FFAF96E01B0
        public void ReadOctetString(){} // RVA: 0x7FFAF96E0340
        public void ReadOidAsString(){} // RVA: 0x7FFAF96E0370
        public void ReadUtf8String(){} // RVA: 0x7FFAF96E07D0
        public void ReadCollectionWithTag(){} // RVA: 0x7FFAF96E08C0
        public void ReadSequence(){} // RVA: 0x7FFAF96E09A0
        public void ReadSet(){} // RVA: 0x7FFAF96E09B0
        public void ReadPrintableString(){} // RVA: 0x7FFAF96E09C0
        public void ReadIA5String(){} // RVA: 0x7FFAF96E0AB0
        public void ReadT61String(){} // RVA: 0x7FFAF96E0BA0
        public void ReadX509Date(){} // RVA: 0x7FFAF96E0F80
        public void ReadUtcTime(){} // RVA: 0x7FFAF96E1060
        public void ReadGeneralizedTime(){} // RVA: 0x7FFAF96E10B0
        public void ReadBMPString(){} // RVA: 0x7FFAF96E1100
        public void TrimTrailingNulls(){} // RVA: 0x7FFAF96E11F0
        public void ReadTime(){} // RVA: 0x7FFAF96E1260
        public void ReadContentAsBytes(){} // RVA: 0x7FFAF96E1520
        public void EatTag(){} // RVA: 0x7FFAF96E15D0
        public void CheckTag(){} // RVA: 0x7FFAF96E1650
        public void EatLength(){} // RVA: 0x7FFAF96E1780
        public void ScanContentLength(){} // RVA: 0x7FFAF96E17C0
    }

    public class DeriveBytes
    {
        // ── Methods ──
        public void GetBytes(){} // RVA: 0x7FFAF2ACBCC0
        public void Reset(){} // RVA: 0x7FFAF2AD4A50
        public void Dispose(){} // RVA: 0x7FFAF2D8D310 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

}