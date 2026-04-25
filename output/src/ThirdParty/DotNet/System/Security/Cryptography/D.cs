// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Cryptography
// Classes: 11
// Methods: 130

namespace ThirdParty.DotNet.System.Security.Cryptography
{
    public class DES : SymmetricAlgorithm
    {
        public System.Security.Cryptography.KeySizes[] Key;
        public System.Security.Cryptography.KeySizes[] s_legalKeySizes; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8410020
        public void get_Key(){} // RVA: 0x7FFAC8410150
        public void set_Key(){} // RVA: 0x7FFAC8410250
        public void Create(){} // RVA: 0x7FFAC8410550 | overloaded x2
        public void IsWeakKey(){} // RVA: 0x7FFAC8410630
        public void IsSemiWeakKey(){} // RVA: 0x7FFAC8410780
        public void IsLegalKeySize(){} // RVA: 0x7FFAC8410960
        public void QuadWordFromBigEndian(){} // RVA: 0x7FFAC8410970
        public void .cctor(){} // RVA: 0x7FFAC8410A20
    }

    public class DESCryptoServiceProvider : DES
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8410C90
        public void CreateEncryptor(){} // RVA: 0x7FFAC8410E30
        public void CreateDecryptor(){} // RVA: 0x7FFAC8410FE0
        public void GenerateKey(){} // RVA: 0x7FFAC8411190
        public void GenerateIV(){} // RVA: 0x7FFAC8411310
    }

    public class DESTransform : SymmetricTransform
    {
        public int KEY_BIT_SIZE;
        public int KEY_BYTE_SIZE; // 0x4
        public int BLOCK_BIT_SIZE; // 0x8
        public int BLOCK_BYTE_SIZE; // 0xC
        public byte[] keySchedule; // 0x58
        public byte[] byteBuff; // 0x60
        public uint[] dwordBuff; // 0x68
        public uint[] spBoxes; // 0x10
        public byte[] PC1; // 0x18
        public byte[] leftRotTotal; // 0x20
        public byte[] PC2; // 0x28
        public uint[] ipTab; // 0x30
        public uint[] fpTab; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC843C8A0
        public void CipherFunct(){} // RVA: 0x7FFAC843CD10
        public void Permutation(){} // RVA: 0x7FFAC843CFF0
        public void BSwap(){} // RVA: 0x7FFAC843D380
        public void SetKey(){} // RVA: 0x7FFAC843D410
        public void ProcessBlock(){} // RVA: 0x7FFAC843D7E0
        public void ECB(){} // RVA: 0x7FFAC843DC00
        public void GetStrongKey(){} // RVA: 0x7FFAC843DCD0
        public void .cctor(){} // RVA: 0x7FFAC843DE20
    }

    public class DSA : AsymmetricAlgorithm
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Create(){} // RVA: 0x7FFAC8413C50 | overloaded x4
        public void CreateSignature(){} // RVA: 0x7FFAC2C58F40
        public void VerifySignature(){} // RVA: 0x7FFAC8414780 | overloaded x2
        public void HashData(){} // RVA: 0x7FFAC8411560 | overloaded x2
        public void SignData(){} // RVA: 0x7FFAC84117B0 | overloaded x3
        public void VerifyData(){} // RVA: 0x7FFAC8414370 | overloaded x4
        public void FromXmlString(){} // RVA: 0x7FFAC8411C30
        public void ToXmlString(){} // RVA: 0x7FFAC8412F80
        public void ExportParameters(){}
        public void ImportParameters(){}
        public void DerivedClassMustOverride(){} // RVA: 0x7FFAC8413A80
        public void HashAlgorithmNameNullOrEmpty(){} // RVA: 0x7FFAC8413B00
        public void TryCreateSignature(){} // RVA: 0x7FFAC8413D40
        public void TryHashData(){} // RVA: 0x7FFAC8413EC0
        public void TrySignData(){} // RVA: 0x7FFAC84141B0
    }

    public class DSACryptoServiceProvider : DSA
    {
        public int KeyExchangeAlgorithm;
        public Mono.Security.Cryptography.KeyPairPersistence KeySize; // 0x20
        public bool PersistKeyInCsp; // 0x28
        public bool PublicOnly; // 0x29
        public bool SignatureAlgorithm; // 0x2A
        public bool UseMachineKeyStore; // 0x2B
        public Mono.Security.Cryptography.DSAManaged CspKeyContainerInfo; // 0x30
        public bool useMachineKeyStore;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC843E420 | overloaded x4
        public void Common(){} // RVA: 0x7FFAC843EA90 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFAC8243E40
        public void get_KeyExchangeAlgorithm(){} // RVA: 0x7FFAC34F9180
        public void get_KeySize(){} // RVA: 0x7FFAC843EBA0
        public void get_PersistKeyInCsp(){} // RVA: 0x7FFAC30F6BA0
        public void set_PersistKeyInCsp(){} // RVA: 0x7FFAC3C24F40
        public void get_PublicOnly(){} // RVA: 0x7FFAC843EBD0
        public void get_SignatureAlgorithm(){} // RVA: 0x7FFAC843EC40
        public void get_UseMachineKeyStore(){} // RVA: 0x7FFAC843EC80
        public void set_UseMachineKeyStore(){} // RVA: 0x7FFAC843ECC0
        public void ExportParameters(){} // RVA: 0x7FFAC843ED00
        public void ImportParameters(){} // RVA: 0x7FFAC843EDD0
        public void CreateSignature(){} // RVA: 0x7FFAC843EE30
        public void SignData(){} // RVA: 0x7FFAC843F070 | overloaded x3
        public void SignHash(){} // RVA: 0x7FFAC843F110
        public void VerifyData(){} // RVA: 0x7FFAC843F300
        public void VerifyHash(){} // RVA: 0x7FFAC843F460
        public void VerifySignature(){} // RVA: 0x7FFAC843F670
        public void HashData(){} // RVA: 0x7FFAC843F7F0 | overloaded x2
        public void Dispose(){} // RVA: 0x7FFAC842B5F0
        public void OnKeyGenerated(){} // RVA: 0x7FFAC843F910
        public void get_CspKeyContainerInfo(){} // RVA: 0x7FFAC34F9180
        public void ExportCspBlob(){} // RVA: 0x7FFAC843F9A0
        public void ImportCspBlob(){} // RVA: 0x7FFAC843F9C0
    }

    public class DSAParameters : ValueType
    {
        public byte[] P; // 0x10
        public byte[] Q; // 0x18
        public byte[] G; // 0x20
        public byte[] Y; // 0x28
        public byte[] J; // 0x30
        public byte[] X; // 0x38
        public byte[] Seed; // 0x40
        public int Counter; // 0x48
    }

    public class DSASignatureDeformatter : AsymmetricSignatureDeformatter
    {
        public System.Security.Cryptography.DSA _dsaKey; // 0x10
        public string _oid; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC84148D0 | overloaded x2
        public void SetKey(){} // RVA: 0x7FFAC8414A30
        public void SetHashAlgorithm(){} // RVA: 0x7FFAC8414B90
        public void VerifySignature(){} // RVA: 0x7FFAC8414C80
    }

    public class DSASignatureDescription : SignatureDescription
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8434900
    }

    public class DSASignatureFormatter : AsymmetricSignatureFormatter
    {
        public System.Security.Cryptography.DSA _dsaKey; // 0x10
        public string _oid; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8414E70 | overloaded x2
        public void SetKey(){} // RVA: 0x7FFAC8414FD0
        public void SetHashAlgorithm(){} // RVA: 0x7FFAC8415130
        public void CreateSignature(){} // RVA: 0x7FFAC8415220
    }

    public class DerSequenceReader : Object
    {
        public System.Globalization.DateTimeFormatInfo ContentLength;
        public System.Text.Encoding HasData; // 0x8
        public System.Text.Encoding s_latin1Encoding; // 0x10
        public byte[] _data; // 0x10
        public int _end; // 0x18
        public int _position; // 0x1C
        public int <ContentLength>k__BackingField; // 0x20

        // ── Methods ──
        public void set_ContentLength(){} // RVA: 0x7FFAC35DB7A0
        public void .ctor(){} // RVA: 0x7FFAC93C8350 | overloaded x3
        public void get_HasData(){} // RVA: 0x7FFAC93C84A0
        public void PeekTag(){} // RVA: 0x7FFAC93C84B0
        public void SkipValue(){} // RVA: 0x7FFAC93C8590
        public void ReadNextEncodedValue(){} // RVA: 0x7FFAC93C85E0
        public void ReadBoolean(){} // RVA: 0x7FFAC93C86A0
        public void ReadInteger(){} // RVA: 0x7FFAC93C8770
        public void ReadIntegerBytes(){} // RVA: 0x7FFAC93C8900
        public void ReadBitString(){} // RVA: 0x7FFAC93C8930
        public void ReadOctetString(){} // RVA: 0x7FFAC93C8AC0
        public void ReadOidAsString(){} // RVA: 0x7FFAC93C8AF0
        public void ReadUtf8String(){} // RVA: 0x7FFAC93C8F50
        public void ReadCollectionWithTag(){} // RVA: 0x7FFAC93C9040
        public void ReadSequence(){} // RVA: 0x7FFAC93C9120
        public void ReadSet(){} // RVA: 0x7FFAC93C9130
        public void ReadPrintableString(){} // RVA: 0x7FFAC93C9140
        public void ReadIA5String(){} // RVA: 0x7FFAC93C9230
        public void ReadT61String(){} // RVA: 0x7FFAC93C9320
        public void ReadX509Date(){} // RVA: 0x7FFAC93C9700
        public void ReadUtcTime(){} // RVA: 0x7FFAC93C97E0
        public void ReadGeneralizedTime(){} // RVA: 0x7FFAC93C9830
        public void ReadBMPString(){} // RVA: 0x7FFAC93C9880
        public void TrimTrailingNulls(){} // RVA: 0x7FFAC93C9970
        public void ReadTime(){} // RVA: 0x7FFAC93C99E0
        public void ReadContentAsBytes(){} // RVA: 0x7FFAC93C9CA0
        public void EatTag(){} // RVA: 0x7FFAC93C9D50
        public void CheckTag(){} // RVA: 0x7FFAC93C9DD0
        public void EatLength(){} // RVA: 0x7FFAC93C9F00
        public void ScanContentLength(){} // RVA: 0x7FFAC93C9F40
    }

    public class DeriveBytes : Object
    {
        // ── Methods ──
        public void GetBytes(){} // RVA: 0x7FFAC2C67DE0
        public void Reset(){} // RVA: 0x7FFAC2C70980
        public void Dispose(){} // RVA: 0x7FFAC2F21310 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

}