// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Cryptography
// Classes: 10
// Methods: 107

namespace ThirdParty.DotNet.System.Security.Cryptography
{
    public class DES : SymmetricAlgorithm
    {
        public object s_legalBlockSizes;
        public object s_legalKeySizes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x66F10B0
        public void get_Key(){} // RVA: 0x66F11E0
        public void set_Key(){} // RVA: 0x66F12E0
        public void Create(){} // RVA: 0x66F15E0
        public void IsWeakKey(){} // RVA: 0x66F16C0
        public void IsSemiWeakKey(){} // RVA: 0x66F1810
        public void IsLegalKeySize(){} // RVA: 0x66F19F0
        public void QuadWordFromBigEndian(){} // RVA: 0x66F1A00
        public void .cctor(){} // RVA: 0x66F1AB0
    }

    public class DESCryptoServiceProvider : DES
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x66F1D20
        public void CreateEncryptor(){} // RVA: 0x66F1EC0
        public void CreateDecryptor(){} // RVA: 0x66F2070
        public void GenerateKey(){} // RVA: 0x66F2220
        public void GenerateIV(){} // RVA: 0x66F23A0
    }

    public class DESTransform : SymmetricTransform
    {
        public object KEY_BIT_SIZE;
        public object KEY_BYTE_SIZE;
        public object BLOCK_BIT_SIZE;
        public object BLOCK_BYTE_SIZE;
        public object keySchedule;
        public object byteBuff;
        public object dwordBuff;
        public object spBoxes;
        public object PC1;
        public object leftRotTotal;
        public object PC2;
        public object ipTab;
        public object fpTab;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x671DEC0
        public void CipherFunct(){} // RVA: 0x671E330
        public void Permutation(){} // RVA: 0x671E600
        public void BSwap(){} // RVA: 0x671E9A0
        public void SetKey(){} // RVA: 0x671EA30
        public void ProcessBlock(){} // RVA: 0x671EE30
        public void ECB(){} // RVA: 0x671F280
        public void GetStrongKey(){} // RVA: 0x671F350
        public void .cctor(){} // RVA: 0x671F4A0
    }

    public class DSA : AsymmetricAlgorithm
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void Create(){} // RVA: 0x66F4CE0
        public void CreateSignature(){} // RVA: 0x87C540
        public void VerifySignature(){} // RVA: 0x66F5820
        public void HashData(){} // RVA: 0x66F25F0
        public void SignData(){} // RVA: 0x66F2840
        public void VerifyData(){} // RVA: 0x66F5410
        public void FromXmlString(){} // RVA: 0x66F2CC0
        public void ToXmlString(){} // RVA: 0x66F4000
        public void ExportParameters(){} // RVA: 0x87C840
        public void ImportParameters(){} // RVA: 0x894320
        public void DerivedClassMustOverride(){} // RVA: 0x66F4B10
        public void HashAlgorithmNameNullOrEmpty(){} // RVA: 0x66F4B90
        public void TryCreateSignature(){} // RVA: 0x66F4DE0
        public void TryHashData(){} // RVA: 0x66F4F60
        public void TrySignData(){} // RVA: 0x66F5250
    }

    public class DSACryptoServiceProvider : DSA
    {
        public object PROV_DSS_DH;
        public object store;
        public object persistKey;
        public object persisted;
        public object privateKeyExportable;
        public object m_disposed;
        public object dsa;
        public object useMachineKeyStore;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x671FAA0
        public void Common(){} // RVA: 0x6720120
        public void Finalize(){} // RVA: 0x6527310
        public void get_KeyExchangeAlgorithm(){} // RVA: 0xDAC980
        public void get_KeySize(){} // RVA: 0x6720230
        public void get_PersistKeyInCsp(){} // RVA: 0xF73960
        public void set_PersistKeyInCsp(){} // RVA: 0xF73A60
        public void get_PublicOnly(){} // RVA: 0x6720260
        public void get_SignatureAlgorithm(){} // RVA: 0x67202D0
        public void get_UseMachineKeyStore(){} // RVA: 0x6720310
        public void set_UseMachineKeyStore(){} // RVA: 0x6720350
        public void ExportParameters(){} // RVA: 0x6720390
        public void ImportParameters(){} // RVA: 0x6720460
        public void CreateSignature(){} // RVA: 0x67204C0
        public void SignData(){} // RVA: 0x6720700
        public void SignHash(){} // RVA: 0x67207A0
        public void VerifyData(){} // RVA: 0x6720990
        public void VerifyHash(){} // RVA: 0x6720AF0
        public void VerifySignature(){} // RVA: 0x6720D00
        public void HashData(){} // RVA: 0x6720E80
        public void Dispose(){} // RVA: 0x670C800
        public void OnKeyGenerated(){} // RVA: 0x6720FA0
        public void get_CspKeyContainerInfo(){} // RVA: 0xDAC980
        public void ExportCspBlob(){} // RVA: 0x6721030
        public void ImportCspBlob(){} // RVA: 0x6721050
    }

    public class DSASignatureDeformatter : AsymmetricSignatureDeformatter
    {
        public object _dsaKey;
        public object _oid;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x66F5970
        public void SetKey(){} // RVA: 0x66F5AD0
        public void SetHashAlgorithm(){} // RVA: 0x66F5C30
        public void VerifySignature(){} // RVA: 0x66F5D20
    }

    public class DSASignatureDescription : SignatureDescription
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6715E30
    }

    public class DSASignatureFormatter : AsymmetricSignatureFormatter
    {
        public object _dsaKey;
        public object _oid;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x66F5F10
        public void SetKey(){} // RVA: 0x66F6070
        public void SetHashAlgorithm(){} // RVA: 0x66F61D0
        public void CreateSignature(){} // RVA: 0x66F62C0
    }

    public class DerSequenceReader : Object
    {
        public object s_validityDateTimeFormatInfo;
        public object s_utf8EncodingWithExceptionFallback;
        public object s_latin1Encoding;
        public object _data;
        public object _end;
        public object _position;
        public object _contentLength;

        // ── Methods ──
        public void set_ContentLength(){} // RVA: 0x1269760
        public void .ctor(){} // RVA: 0x7690830
        public void get_HasData(){} // RVA: 0x7690990
        public void PeekTag(){} // RVA: 0x76909A0
        public void SkipValue(){} // RVA: 0x7690A80
        public void ReadNextEncodedValue(){} // RVA: 0x7690AD0
        public void ReadBoolean(){} // RVA: 0x7690B90
        public void ReadInteger(){} // RVA: 0x7690C60
        public void ReadIntegerBytes(){} // RVA: 0x7690DF0
        public void ReadBitString(){} // RVA: 0x7690E20
        public void ReadOctetString(){} // RVA: 0x7690FB0
        public void ReadOidAsString(){} // RVA: 0x7690FE0
        public void ReadUtf8String(){} // RVA: 0x7691450
        public void ReadCollectionWithTag(){} // RVA: 0x7691540
        public void ReadSequence(){} // RVA: 0x7691620
        public void ReadSet(){} // RVA: 0x7691630
        public void ReadPrintableString(){} // RVA: 0x7691640
        public void ReadIA5String(){} // RVA: 0x7691730
        public void ReadT61String(){} // RVA: 0x7691820
        public void ReadX509Date(){} // RVA: 0x7691C00
        public void ReadUtcTime(){} // RVA: 0x7691CE0
        public void ReadGeneralizedTime(){} // RVA: 0x7691D30
        public void ReadBMPString(){} // RVA: 0x7691D80
        public void TrimTrailingNulls(){} // RVA: 0x7691E70
        public void ReadTime(){} // RVA: 0x7691EE0
        public void ReadContentAsBytes(){} // RVA: 0x76921A0
        public void EatTag(){} // RVA: 0x7692250
        public void CheckTag(){} // RVA: 0x76922D0
        public void EatLength(){} // RVA: 0x7692400
        public void ScanContentLength(){} // RVA: 0x7692440
    }

    public class DeriveBytes : Object
    {
        // ── Methods ──
        public void GetBytes(){} // RVA: 0x87C160
        public void Reset(){} // RVA: 0x894290
        public void Dispose(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0xB43310
    }

}