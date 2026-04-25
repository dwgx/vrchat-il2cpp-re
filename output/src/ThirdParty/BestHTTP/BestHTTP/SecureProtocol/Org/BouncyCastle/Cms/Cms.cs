// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Cms
// Classes: 69
// Methods: 475

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Cms
{
    public class BaseDigestCalculator : Object
    {
        public byte[] digest; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void GetDigest(){} // RVA: 0x7FFACBC973F0
    }

    public class CmsAttributeTableGenerationException : CmsException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBC97550 | overloaded x3
    }

    public class CmsAttributeTableGenerator
    {
        // ── Methods ──
        public void GetAttributes(){} // RVA: 0x7FFAC2C58F40
    }

    public class CmsAuthEnvelopedData : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Cms.RecipientInformationStore recipientInfoStore; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.ContentInfo contentInfo; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.OriginatorInfo originator; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier authEncAlg; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set authAttrs; // 0x30
        public byte[] mac; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set unauthAttrs; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBC9B420 | overloaded x3
    }

    public class CmsAuthEnvelopedGenerator : Object
    {
        public string Aes128Ccm;
        public string Aes192Ccm; // 0x8
        public string Aes256Ccm; // 0x10
        public string Aes128Gcm; // 0x18
        public string Aes192Gcm; // 0x20
        public string Aes256Gcm; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBC9B800
    }

    public class CmsAuthenticatedData : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Cms.RecipientInformationStore MacAlgorithmID; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.ContentInfo MacAlgOid; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier ContentInfo; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set authAttrs; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set unauthAttrs; // 0x30
        public byte[] mac; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBC97610 | overloaded x3
        public void GetMac(){} // RVA: 0x7FFACBC97970
        public void get_MacAlgorithmID(){} // RVA: 0x7FFAC2F4F0C0
        public void get_MacAlgOid(){} // RVA: 0x7FFACBC97A20
        public void GetRecipientInfos(){} // RVA: 0x7FFAC2F3C380
        public void get_ContentInfo(){} // RVA: 0x7FFAC2F247C0
        public void GetAuthAttrs(){} // RVA: 0x7FFACBC97A60
        public void GetUnauthAttrs(){} // RVA: 0x7FFACBC97AD0
        public void GetEncoded(){} // RVA: 0x7FFACBC97B40
    }

    public class CmsAuthenticatedDataGenerator : CmsAuthenticatedGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBC97B70 | overloaded x2
        public void Generate(){} // RVA: 0x7FFACBC986E0 | overloaded x2
    }

    public class CmsAuthenticatedDataParser : CmsContentInfoParser
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Cms.RecipientInformationStore MacAlgorithmID; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.AuthenticatedDataParser MacAlgOid; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier MacAlgParams; // 0x30
        public byte[] mac; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.AttributeTable authAttrs; // 0x40
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.AttributeTable unauthAttrs; // 0x48
        public bool authAttrNotRead; // 0x50
        public bool unauthAttrNotRead; // 0x51

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBC98920 | overloaded x2
        public void get_MacAlgorithmID(){} // RVA: 0x7FFAC31D95E0
        public void get_MacAlgOid(){} // RVA: 0x7FFACBC993C0
        public void get_MacAlgParams(){} // RVA: 0x7FFACBC99400
        public void GetRecipientInfos(){} // RVA: 0x7FFAC2F4F0C0
        public void GetMac(){} // RVA: 0x7FFACBC99450
        public void GetAuthAttrs(){} // RVA: 0x7FFACBC996D0
        public void GetUnauthAttrs(){} // RVA: 0x7FFACBC99AC0
    }

    public class CmsAuthenticatedDataStreamGenerator : CmsAuthenticatedGenerator
    {
        public int _bufferSize; // 0x28
        public bool _berEncodeRecipientSet; // 0x2C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBC97B70 | overloaded x2
        public void SetBufferSize(){} // RVA: 0x7FFAC369A6E0
        public void SetBerEncodeRecipients(){} // RVA: 0x7FFAC3000240
        public void Open(){} // RVA: 0x7FFACBC9ACD0 | overloaded x4
    }

    public class CmsAuthenticatedGenerator : CmsEnvelopedGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBC97B70 | overloaded x2
    }

    public class CmsCompressedData : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.ContentInfo ContentInfo; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x3
        public void GetContent(){} // RVA: 0x7FFACBC9BF90 | overloaded x2
        public void get_ContentInfo(){} // RVA: 0x7FFAC2F3C380
        public void GetEncoded(){} // RVA: 0x7FFACBA639C0
    }

    public class CmsCompressedDataGenerator : Object
    {
        public string ZLib;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Generate(){} // RVA: 0x7FFACBC9C2A0
    }

    public class CmsCompressedDataParser : CmsContentInfoParser
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBC9C8B0 | overloaded x2
        public void GetContent(){} // RVA: 0x7FFACBC9C8C0
    }

    public class CmsCompressedDataStreamGenerator : Object
    {
        public string ZLib;
        public int _bufferSize; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void SetBufferSize(){} // RVA: 0x7FFAC2F240C0
        public void Open(){} // RVA: 0x7FFACBC9CC30 | overloaded x2
    }

    public class CmsContentInfoParser : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.ContentInfoParser contentInfo; // 0x10
        public System.IO.Stream data; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBC9D410
        public void Close(){} // RVA: 0x7FFACBC9D6E0
    }

    public class CmsEnvelopedData : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Cms.RecipientInformationStore EncryptionAlgorithmID; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.ContentInfo EncryptionAlgOid; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier ContentInfo; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set unprotectedAttributes; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBC9D800 | overloaded x3
        public void get_EncryptionAlgorithmID(){} // RVA: 0x7FFAC2F4F0C0
        public void get_EncryptionAlgOid(){} // RVA: 0x7FFACBC97A20
        public void GetRecipientInfos(){} // RVA: 0x7FFAC2F3C380
        public void get_ContentInfo(){} // RVA: 0x7FFAC2F247C0
        public void GetUnprotectedAttributes(){} // RVA: 0x7FFACBC9DAA0
        public void GetEncoded(){} // RVA: 0x7FFACBC97B40
    }

    public class CmsEnvelopedDataGenerator : CmsEnvelopedGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBC9DBB0 | overloaded x2
        public void Generate(){} // RVA: 0x7FFACBC9F390 | overloaded x4
    }

    public class CmsEnvelopedDataParser : CmsContentInfoParser
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Cms.RecipientInformationStore EncryptionAlgorithmID; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.EnvelopedDataParser EncryptionAlgOid; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier EncryptionAlgParams; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.AttributeTable _unprotectedAttributes; // 0x38
        public bool _attrNotRead; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBC9F5D0 | overloaded x2
        public void get_EncryptionAlgorithmID(){} // RVA: 0x7FFAC31D95E0
        public void get_EncryptionAlgOid(){} // RVA: 0x7FFACBC993C0
        public void get_EncryptionAlgParams(){} // RVA: 0x7FFACBC99400
        public void GetRecipientInfos(){} // RVA: 0x7FFAC2F4F0C0
        public void GetUnprotectedAttributes(){} // RVA: 0x7FFACBC9FE50
    }

    public class CmsEnvelopedDataStreamGenerator : CmsEnvelopedGenerator
    {
        public object Version; // 0x28
        public object _unprotectedAttributes; // 0x30
        public int _bufferSize; // 0x38
        public bool _berEncodeRecipientSet; // 0x3C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBCA02E0 | overloaded x2
        public void SetBufferSize(){} // RVA: 0x7FFAC3588350
        public void SetBerEncodeRecipients(){} // RVA: 0x7FFAC30864F0
        public void get_Version(){} // RVA: 0x7FFACBCA0340
        public void Open(){} // RVA: 0x7FFACBCA1330 | overloaded x4
    }

    public class CmsEnvelopedGenerator : Object
    {
        public short[] UnprotectedAttributeGenerator;
        public string DesEde3Cbc; // 0x8
        public string RC2Cbc; // 0x10
        public string IdeaCbc;
        public string Cast5Cbc;
        public string Aes128Cbc; // 0x18
        public string Aes192Cbc; // 0x20
        public string Aes256Cbc; // 0x28
        public string Camellia128Cbc; // 0x30
        public string Camellia192Cbc; // 0x38
        public string Camellia256Cbc; // 0x40
        public string SeedCbc; // 0x48
        public string DesEde3Wrap; // 0x50
        public string Aes128Wrap; // 0x58
        public string Aes192Wrap; // 0x60
        public string Aes256Wrap; // 0x68
        public string Camellia128Wrap; // 0x70
        public string Camellia192Wrap; // 0x78
        public string Camellia256Wrap; // 0x80
        public string SeedWrap; // 0x88
        public string ECDHSha1Kdf; // 0x90
        public string ECMqvSha1Kdf; // 0x98
        public System.Collections.IList recipientInfoGenerators; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Security.SecureRandom rand; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Cms.CmsAttributeTableGenerator unprotectedAttributeGenerator; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBCA1770 | overloaded x2
        public void get_UnprotectedAttributeGenerator(){} // RVA: 0x7FFAC2F4F0C0
        public void set_UnprotectedAttributeGenerator(){} // RVA: 0x7FFAC2F4F0D0
        public void AddKeyTransRecipient(){} // RVA: 0x7FFACBCA1950 | overloaded x2
        public void AddKekRecipient(){} // RVA: 0x7FFACBCA1BD0 | overloaded x2
        public void AddPasswordRecipient(){} // RVA: 0x7FFACBCA1E20
        public void AddKeyAgreementRecipient(){} // RVA: 0x7FFACBCA20B0
        public void AddKeyAgreementRecipients(){} // RVA: 0x7FFACBCA2250
        public void AddRecipientInfoGenerator(){} // RVA: 0x7FFACBCA2610
        public void GetAlgorithmIdentifier(){} // RVA: 0x7FFACBCA2670
        public void GenerateAsn1Parameters(){} // RVA: 0x7FFACBCA2860
        public void .cctor(){} // RVA: 0x7FFACBCA2A60
    }

    public class CmsEnvelopedHelper : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Cms.CmsEnvelopedHelper Instance;
        public System.Collections.IDictionary KeySizes; // 0x8
        public System.Collections.IDictionary BaseCipherNames; // 0x10

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFACBCA36C0
        public void GetAsymmetricEncryptionAlgName(){} // RVA: 0x7FFACBCA3C10
        public void CreateAsymmetricCipher(){} // RVA: 0x7FFACBCA3CD0
        public void CreateWrapper(){} // RVA: 0x7FFACBCA3DB0
        public void GetRfc3211WrapperName(){} // RVA: 0x7FFACBCA3E50
        public void GetKeySize(){} // RVA: 0x7FFACBCA3FF0
        public void BuildRecipientInformationStore(){} // RVA: 0x7FFACBCA4170
        public void ReadRecipientInfo(){} // RVA: 0x7FFACBCA42E0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class CmsException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBCA52D0 | overloaded x3
    }

    public class CmsPbeKey : Object
    {
        public char[] Password; // 0x10
        public byte[] Salt; // 0x18
        public int IterationCount; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBCA55F0 | overloaded x4
        public void Finalize(){} // RVA: 0x7FFACBCA5950
        public void get_Password(){} // RVA: 0x7FFACBCA59B0
        public void get_Salt(){} // RVA: 0x7FFACBCA59C0
        public void GetSalt(){} // RVA: 0x7FFACBCA5A70
        public void get_IterationCount(){} // RVA: 0x7FFAC30DBBE0
        public void get_Algorithm(){} // RVA: 0x7FFACBCA5A80
        public void get_Format(){} // RVA: 0x7FFACBCA5AC0
        public void GetEncoded(){} // RVA: 0x7FFAC2C58F40 | overloaded x2
    }

    public class CmsProcessable
    {
        // ── Methods ──
        public void Write(){} // RVA: 0x7FFAC2C70A40
        public void GetContent(){} // RVA: 0x7FFAC2C58E90
    }

    public class CmsProcessableByteArray : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Type; // 0x10
        public byte[] bytes; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC86BFC90 | overloaded x2
        public void get_Type(){} // RVA: 0x7FFAC2F3C380
        public void GetInputStream(){} // RVA: 0x7FFACBCA5C20
        public void Write(){} // RVA: 0x7FFACBCA5C80
        public void GetContent(){} // RVA: 0x7FFACBCA5CD0
    }

    public class CmsProcessableFile : Object
    {
        public int DefaultBufSize;
        public System.IO.FileInfo _file; // 0x10
        public int _bufSize; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC488C310 | overloaded x2
        public void GetInputStream(){} // RVA: 0x7FFACBCA5D60
        public void Write(){} // RVA: 0x7FFACBCA5E10
        public void GetContent(){} // RVA: 0x7FFAC2F3C380
    }

    public class CmsProcessableInputStream : Object
    {
        public System.IO.Stream input; // 0x10
        public bool used; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void GetInputStream(){} // RVA: 0x7FFACBCA5F50
        public void Write(){} // RVA: 0x7FFACBCA5F80
        public void GetContent(){} // RVA: 0x7FFAC47CB300
        public void CheckSingleUsage(){} // RVA: 0x7FFACBCA60D0
    }

    public class CmsReadable
    {
        // ── Methods ──
        public void GetInputStream(){} // RVA: 0x7FFAC2C58E90
    }

    public class CmsSecureReadable
    {
        public object Algorithm;
        public object CryptoObject;

        // ── Methods ──
        public void get_Algorithm(){} // RVA: 0x7FFAC2C58E90
        public void get_CryptoObject(){} // RVA: 0x7FFAC2C58E90
        public void GetReadable(){} // RVA: 0x7FFAC2C58F40
    }

    public class CmsSignedData : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Cms.CmsSignedHelper Version;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Cms.CmsProcessable SignedContentTypeOid; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.SignedData SignedContentType; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.ContentInfo SignedContent; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Cms.SignerInformationStore ContentInfo; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.X509.Store.IX509Store attrCertStore; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.X509.Store.IX509Store certificateStore; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.X509.Store.IX509Store crlStore; // 0x40
        public System.Collections.IDictionary hashes; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBCA6B90 | overloaded x9
        public void get_Version(){} // RVA: 0x7FFACBCA6DE0
        public void GetSignerInfos(){} // RVA: 0x7FFACBCA6E50
        public void GetAttributeCertificates(){} // RVA: 0x7FFACBCA7310
        public void GetCertificates(){} // RVA: 0x7FFACBCA7400
        public void GetCrls(){} // RVA: 0x7FFACBCA74F0
        public void get_SignedContentTypeOid(){} // RVA: 0x7FFACBCA75E0
        public void get_SignedContentType(){} // RVA: 0x7FFACBCA7610
        public void get_SignedContent(){} // RVA: 0x7FFAC2F3C380
        public void get_ContentInfo(){} // RVA: 0x7FFAC2F4F0C0
        public void GetEncoded(){} // RVA: 0x7FFACBCA7640
        public void ReplaceSigners(){} // RVA: 0x7FFACBCA7660
        public void ReplaceCertificatesAndCrls(){} // RVA: 0x7FFACBCA8110
        public void .cctor(){} // RVA: 0x7FFACBCA8480
    }

    public class CmsSignedDataGenerator : CmsSignedGenerator
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Cms.CmsSignedHelper Helper;
        public System.Collections.IList signerInfs; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBCA86A0 | overloaded x2
        public void AddSigner(){} // RVA: 0x7FFACBCA9600 | overloaded x12
        public void AddSignerInfoGenerator(){} // RVA: 0x7FFACBCA96C0
        public void doAddSigner(){} // RVA: 0x7FFACBCA97B0
        public void Generate(){} // RVA: 0x7FFACBCAA680 | overloaded x3
        public void GenerateCounterSigners(){} // RVA: 0x7FFACBCAA710
        public void .cctor(){} // RVA: 0x7FFACBCAA7C0
    }

    public class CmsSignedDataParser : CmsContentInfoParser
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Cms.CmsSignedHelper Version;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.SignedDataParser DigestOids; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier SignedContentType; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Cms.CmsTypedStream _signedContent; // 0x30
        public System.Collections.IDictionary _digests; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Collections.ISet _digestOids; // 0x40
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Cms.SignerInformationStore _signerInfoStore; // 0x48
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set _certSet; // 0x50
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set _crlSet; // 0x58
        public bool _isCertCrlParsed; // 0x60
        public BestHTTP.SecureProtocol.Org.BouncyCastle.X509.Store.IX509Store _attributeStore; // 0x68
        public BestHTTP.SecureProtocol.Org.BouncyCastle.X509.Store.IX509Store _certificateStore; // 0x70
        public BestHTTP.SecureProtocol.Org.BouncyCastle.X509.Store.IX509Store _crlStore; // 0x78

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBCABC10 | overloaded x4
        public void get_Version(){} // RVA: 0x7FFACBCAC500
        public void get_DigestOids(){} // RVA: 0x7FFACBCAC570
        public void GetSignerInfos(){} // RVA: 0x7FFACBCAC5D0
        public void GetAttributeCertificates(){} // RVA: 0x7FFACBCAD150
        public void GetCertificates(){} // RVA: 0x7FFACBCAD240
        public void GetCrls(){} // RVA: 0x7FFACBCAD330
        public void PopulateCertCrlSets(){} // RVA: 0x7FFACBCAD420
        public void get_SignedContentType(){} // RVA: 0x7FFAC2F4F130
        public void GetSignedContent(){} // RVA: 0x7FFACBCAD670
        public void ReplaceSigners(){} // RVA: 0x7FFACBCADAB0
        public void ReplaceCertificatesAndCrls(){} // RVA: 0x7FFACBCADF80
        public void GetAsn1Set(){} // RVA: 0x7FFACBCAE250
        public void .cctor(){} // RVA: 0x7FFACBCAE2B0
    }

    public class CmsSignedDataStreamGenerator : CmsSignedGenerator
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Cms.CmsSignedHelper Helper;
        public System.Collections.IList _signerInfs; // 0x40
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Collections.ISet _messageDigestOids; // 0x48
        public System.Collections.IDictionary _messageDigests; // 0x50
        public System.Collections.IDictionary _messageHashes; // 0x58
        public bool _messageDigestsLocked; // 0x60
        public int _bufferSize; // 0x64

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBCAE680 | overloaded x2
        public void SetBufferSize(){} // RVA: 0x7FFAC46D5120
        public void AddDigests(){} // RVA: 0x7FFACBCAE970 | overloaded x2
        public void AddSigner(){} // RVA: 0x7FFACBCAF3E0 | overloaded x11
        public void DoAddSigner(){} // RVA: 0x7FFACBCAF480
        public void AddSignerCallback(){} // RVA: 0x7FFACBCAF650
        public void Open(){} // RVA: 0x7FFACBCAF870 | overloaded x5
        public void RegisterDigestOid(){} // RVA: 0x7FFACBCB0210
        public void ConfigureDigest(){} // RVA: 0x7FFACBCB02E0
        public void Generate(){} // RVA: 0x7FFACBCB04B0
        public void CalculateVersion(){} // RVA: 0x7FFACBCB05A0
        public void CheckForVersion3(){} // RVA: 0x7FFACBCB0A30
        public void AttachDigestsToOutputStream(){} // RVA: 0x7FFACBCB0C90
        public void GetSafeOutputStream(){} // RVA: 0x7FFACBCB1070
        public void GetSafeTeeOutputStream(){} // RVA: 0x7FFACBCB10F0
        public void .cctor(){} // RVA: 0x7FFACBCB1250
    }

    public class CmsSignedGenerator : Object
    {
        public string UseDerForCerts;
        public string UseDerForCrls; // 0x8
        public string DigestSha224; // 0x10
        public string DigestSha256; // 0x18
        public string DigestSha384; // 0x20
        public string DigestSha512; // 0x28
        public string DigestMD5; // 0x30
        public string DigestGost3411; // 0x38
        public string DigestRipeMD128; // 0x40
        public string DigestRipeMD160; // 0x48
        public string DigestRipeMD256; // 0x50
        public string EncryptionRsa; // 0x58
        public string EncryptionDsa; // 0x60
        public string EncryptionECDsa; // 0x68
        public string EncryptionRsaPss; // 0x70
        public string EncryptionGost3410; // 0x78
        public string EncryptionECGost3410; // 0x80
        public System.Collections.IList _certs; // 0x10
        public System.Collections.IList _crls; // 0x18
        public System.Collections.IList _signers; // 0x20
        public System.Collections.IDictionary _digests; // 0x28
        public bool _useDerForCerts; // 0x30
        public bool _useDerForCrls; // 0x31
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Security.SecureRandom rand; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBCB9DE0 | overloaded x2
        public void GetBaseParameters(){} // RVA: 0x7FFACBCBA0D0
        public void GetAttributeSet(){} // RVA: 0x7FFACBCBA310
        public void AddCertificates(){} // RVA: 0x7FFACBCBA430
        public void AddCrls(){} // RVA: 0x7FFACBCBA460
        public void AddAttributeCertificates(){} // RVA: 0x7FFACBCBA490
        public void AddSigners(){} // RVA: 0x7FFACBCBA8E0
        public void GetGeneratedDigests(){} // RVA: 0x7FFACBCBABE0
        public void get_UseDerForCerts(){} // RVA: 0x7FFAC2F47450
        public void set_UseDerForCerts(){} // RVA: 0x7FFAC2F47460
        public void get_UseDerForCrls(){} // RVA: 0x7FFAC2F47470
        public void set_UseDerForCrls(){} // RVA: 0x7FFAC2F47480
        public void AddSignerCallback(){} // RVA: 0x7FFAC2F21310
        public void GetSignerIdentifier(){} // RVA: 0x7FFACBCBAD90 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFACBCBAEB0
    }

    public class CmsSignedHelper : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Cms.CmsSignedHelper Instance;
        public string EncryptionECDsaWithSha1; // 0x8
        public string EncryptionECDsaWithSha224; // 0x10
        public string EncryptionECDsaWithSha256; // 0x18
        public string EncryptionECDsaWithSha384; // 0x20
        public string EncryptionECDsaWithSha512; // 0x28
        public System.Collections.IDictionary encryptionAlgs; // 0x30
        public System.Collections.IDictionary digestAlgs; // 0x38
        public System.Collections.IDictionary digestAliases; // 0x40
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Collections.ISet noParams; // 0x48
        public System.Collections.IDictionary ecAlgorithms; // 0x50

        // ── Methods ──
        public void AddEntries(){} // RVA: 0x7FFACBCBB970
        public void .cctor(){} // RVA: 0x7FFACBCBBA60
        public void GetDigestAlgName(){} // RVA: 0x7FFACBCBD5C0
        public void GetEncAlgorithmIdentifier(){} // RVA: 0x7FFACBCBD680
        public void GetDigestAliases(){} // RVA: 0x7FFACBCBD7D0
        public void GetEncryptionAlgName(){} // RVA: 0x7FFACBCBD8F0
        public void GetDigestInstance(){} // RVA: 0x7FFACBCBD9B0
        public void GetSignatureInstance(){} // RVA: 0x7FFACBCBDAB0
        public void CreateAttributeStore(){} // RVA: 0x7FFACBCBDB00
        public void CreateCertificateStore(){} // RVA: 0x7FFACBCBDFB0
        public void CreateCrlStore(){} // RVA: 0x7FFACBCBE130
        public void AddCertsFromSet(){} // RVA: 0x7FFACBCBE2B0
        public void AddCrlsFromSet(){} // RVA: 0x7FFACBCBE5C0
        public void FixAlgID(){} // RVA: 0x7FFACBCBE880
        public void GetEncOid(){} // RVA: 0x7FFACBCBE970
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class CmsStreamException : IOException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC85BCB20 | overloaded x3
    }

    public class CmsTypedStream : Object
    {
        public int ContentType;
        public string ContentStream; // 0x10
        public System.IO.Stream _in; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBCBF180 | overloaded x3
        public void get_ContentType(){} // RVA: 0x7FFAC2F3C380
        public void get_ContentStream(){} // RVA: 0x7FFAC2F247C0
        public void Drain(){} // RVA: 0x7FFACBCBF2E0
    }

    public class CmsUtilities : Object
    {
        public object MaximumMemory;

        // ── Methods ──
        public void get_MaximumMemory(){} // RVA: 0x7FFACBCBF480
        public void ReadContentInfo(){} // RVA: 0x7FFACBCBF5C0 | overloaded x3
        public void StreamToByteArray(){} // RVA: 0x7FFACBCBF720 | overloaded x2
        public void GetCertificatesFromStore(){} // RVA: 0x7FFACBCBF8C0
        public void GetCrlsFromStore(){} // RVA: 0x7FFACBCBFD30
        public void CreateBerSetFromList(){} // RVA: 0x7FFACBCC01A0
        public void CreateDerSetFromList(){} // RVA: 0x7FFACBCC0510
        public void CreateBerOctetOutputStream(){} // RVA: 0x7FFACBCC0860
        public void GetTbsCertificateStructure(){} // RVA: 0x7FFACBCC0A40
        public void GetIssuerAndSerialNumber(){} // RVA: 0x7FFACBCC0A80
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class CounterSignatureDigestCalculator : Object
    {
        public string alg; // 0x10
        public byte[] data; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC34EC240
        public void GetDigest(){} // RVA: 0x7FFACBCC0B40
    }

    public class DefaultAuthenticatedAttributeTableGenerator : Object
    {
        public System.Collections.IDictionary table; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBCC0DD0 | overloaded x2
        public void CreateStandardAttributeTable(){} // RVA: 0x7FFACBCC0F70
        public void GetAttributes(){} // RVA: 0x7FFACBCC1460
    }

    public class DefaultDigestAlgorithmIdentifierFinder : Object
    {
        public System.Collections.IDictionary digestOids;
        public System.Collections.IDictionary digestNameToOids; // 0x8

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFACBCB8610
        public void find(){} // RVA: 0x7FFACBCB9C20 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class DefaultSignatureAlgorithmIdentifierFinder : Object
    {
        public System.Collections.IDictionary algorithms;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Collections.ISet noParams; // 0x8
        public System.Collections.IDictionary _params; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Collections.ISet pkcs15RsaEncryption; // 0x18
        public System.Collections.IDictionary digestOids; // 0x20
        public System.Collections.IDictionary digestBuilders; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier ENCRYPTION_RSA; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier ENCRYPTION_DSA; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier ENCRYPTION_ECDSA; // 0x40
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier ENCRYPTION_RSA_PSS; // 0x48
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier ENCRYPTION_GOST3410; // 0x50
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier ENCRYPTION_ECGOST3410; // 0x58
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier ENCRYPTION_ECGOST3410_2012_256; // 0x60
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier ENCRYPTION_ECGOST3410_2012_512; // 0x68

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFACBCB3810
        public void Generate(){} // RVA: 0x7FFACBCB7E10
        public void CreatePssParams(){} // RVA: 0x7FFACBCB8470
        public void Find(){} // RVA: 0x7FFACBCB85C0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class DefaultSignedAttributeTableGenerator : Object
    {
        public System.Collections.IDictionary table; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBCC15C0 | overloaded x2
        public void createStandardAttributeTable(){} // RVA: 0x7FFACBCC1760
        public void DoCreateStandardAttributeTable(){} // RVA: 0x7FFACBCC1800
        public void GetAttributes(){} // RVA: 0x7FFACBCC1E90
    }

    public class EnvelopedDataHelper : Object
    {
        public System.Collections.IDictionary BaseCipherNames;
        public System.Collections.IDictionary MacAlgNames; // 0x8

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFACBCC1F10
        public void CreateContentCipher(){} // RVA: 0x7FFACBCC2450
        public void GenerateEncryptionAlgID(){} // RVA: 0x7FFACBCC24C0
        public void CreateKeyGenerator(){} // RVA: 0x7FFACBCC2550
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class IDigestCalculator
    {
        // ── Methods ──
        public void GetDigest(){} // RVA: 0x7FFAC2C58E90
    }

    public class ISignerInfoGenerator
    {
        // ── Methods ──
        public void Generate(){} // RVA: 0x7FFAC2C6AE80
    }

    public class KekRecipientInfoGenerator : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Cms.CmsEnvelopedHelper KekIdentifier;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.KeyParameter KeyEncryptionKey; // 0x10
        public string KeyEncryptionKeyOID; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.KekIdentifier kekIdentifier; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier keyEncryptionAlgorithm; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void set_KekIdentifier(){} // RVA: 0x7FFAC2F4F0D0
        public void set_KeyEncryptionKey(){} // RVA: 0x7FFACBCC2570
        public void set_KeyEncryptionKeyOID(){} // RVA: 0x7FFAC2F87E80
        public void Generate(){} // RVA: 0x7FFACBCC26A0
        public void DetermineKeyEncAlg(){} // RVA: 0x7FFACBCC29F0
        public void .cctor(){} // RVA: 0x7FFACBCC2FC0
    }

    public class KekRecipientInformation : RecipientInformation
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.KekRecipientInfo info; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBCC3090
        public void GetContentStream(){} // RVA: 0x7FFACBCC3300
    }

    public class KeyAgreeRecipientInfoGenerator : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Cms.CmsEnvelopedHelper KeyAgreementOID;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier KeyEncryptionOID; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier RecipientCerts; // 0x18
        public System.Collections.IList SenderKeyPair; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair senderKeyPair; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void set_KeyAgreementOID(){} // RVA: 0x7FFAC2F22E30
        public void set_KeyEncryptionOID(){} // RVA: 0x7FFAC2F87E80
        public void set_RecipientCerts(){} // RVA: 0x7FFACBCC35C0
        public void set_SenderKeyPair(){} // RVA: 0x7FFAC2F22E90
        public void Generate(){} // RVA: 0x7FFACBCC36B0
        public void CreateOriginatorPublicKey(){} // RVA: 0x7FFACBCC4A70
        public void .cctor(){} // RVA: 0x7FFACBCC4C90
    }

    public class KeyAgreeRecipientInformation : RecipientInformation
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.KeyAgreeRecipientInfo info; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString encryptedKey; // 0x38

        // ── Methods ──
        public void ReadRecipientInfo(){} // RVA: 0x7FFACBCC4D60
        public void .ctor(){} // RVA: 0x7FFACBCC5180
        public void GetSenderPublicKey(){} // RVA: 0x7FFACBCC52E0
        public void GetPublicKeyFromOriginatorPublicKey(){} // RVA: 0x7FFACBCC5440
        public void GetPublicKeyFromOriginatorID(){} // RVA: 0x7FFACBCC5510
        public void CalculateAgreedWrapKey(){} // RVA: 0x7FFACBCC5560
        public void UnwrapSessionKey(){} // RVA: 0x7FFACBCC5990
        public void GetSessionKey(){} // RVA: 0x7FFACBCC5B20
        public void GetContentStream(){} // RVA: 0x7FFACBCC5FF0
    }

    public class KeyTransRecipientInfoGenerator : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Cms.CmsEnvelopedHelper RecipientCert;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.TbsCertificateStructure RecipientPublicKey; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.AsymmetricKeyParameter SubjectKeyIdentifier; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString AlgorithmDetails; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo info; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.IssuerAndSerialNumber issuerAndSerialNumber; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Security.SecureRandom random; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBCC6170 | overloaded x3
        public void set_RecipientCert(){} // RVA: 0x7FFACBCC62C0
        public void set_RecipientPublicKey(){} // RVA: 0x7FFACBCC6440
        public void set_SubjectKeyIdentifier(){} // RVA: 0x7FFAC2F4F0D0
        public void Generate(){} // RVA: 0x7FFACBCC6560
        public void get_AlgorithmDetails(){} // RVA: 0x7FFAC69A4060
        public void GenerateWrappedKey(){} // RVA: 0x7FFACBCC68C0
        public void .cctor(){} // RVA: 0x7FFACBCC6A50
    }

    public class KeyTransRecipientInformation : RecipientInformation
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.KeyTransRecipientInfo info; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBCC6B20
        public void GetExchangeEncryptionAlgorithmName(){} // RVA: 0x7FFACBCC6E90
        public void UnwrapKey(){} // RVA: 0x7FFACBCC7300
        public void GetContentStream(){} // RVA: 0x7FFACBCC7630
    }

    public class OriginatorID : X509CertStoreSelector
    {
        // ── Methods ──
        public void GetHashCode(){} // RVA: 0x7FFACBCC7660
        public void Equals(){} // RVA: 0x7FFACBCC7750
        public void .ctor(){} // RVA: 0x7FFAC47EDC40
    }

    public class OriginatorInfoGenerator : Object
    {
        public System.Collections.IList origCerts; // 0x10
        public System.Collections.IList origCrls; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBCC7C00 | overloaded x3
        public void Generate(){} // RVA: 0x7FFACBCC7CF0
    }

    public class OriginatorInformation : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.OriginatorInfo originatorInfo; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void GetCertificates(){} // RVA: 0x7FFACBCC7E10
        public void GetCrls(){} // RVA: 0x7FFACBCC8270
        public void ToAsn1Structure(){} // RVA: 0x7FFAC2F3C380
    }

    public class PasswordRecipientInfoGenerator : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Cms.CmsEnvelopedHelper KeyDerivationAlgorithm;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier KeyEncryptionKey; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.KeyParameter KeyEncryptionKeyOID; // 0x18
        public string keyEncryptionKeyOID; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void set_KeyDerivationAlgorithm(){} // RVA: 0x7FFAC2F22E30
        public void set_KeyEncryptionKey(){} // RVA: 0x7FFAC2F87E80
        public void set_KeyEncryptionKeyOID(){} // RVA: 0x7FFAC2F4F0D0
        public void Generate(){} // RVA: 0x7FFACBCC86D0
        public void .cctor(){} // RVA: 0x7FFACBCC8CD0
    }

    public class PasswordRecipientInformation : RecipientInformation
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.PasswordRecipientInfo KeyDerivationAlgorithm; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBCC8DA0
        public void get_KeyDerivationAlgorithm(){} // RVA: 0x7FFAC3664E80
        public void GetContentStream(){} // RVA: 0x7FFACBCC8EC0
    }

    public class Pkcs5Scheme2PbeKey : CmsPbeKey
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBCC93C0 | overloaded x4
        public void GetEncoded(){} // RVA: 0x7FFACBCC93D0
    }

    public class Pkcs5Scheme2Utf8PbeKey : CmsPbeKey
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBCC93C0 | overloaded x4
        public void GetEncoded(){} // RVA: 0x7FFACBCC9570
    }

    public class RecipientID : X509CertStoreSelector
    {
        public byte[] KeyIdentifier; // 0x88

        // ── Methods ──
        public void get_KeyIdentifier(){} // RVA: 0x7FFACBCC9770
        public void set_KeyIdentifier(){} // RVA: 0x7FFACBCC9830
        public void GetHashCode(){} // RVA: 0x7FFACBCC9940
        public void Equals(){} // RVA: 0x7FFACBCC9A70
        public void .ctor(){} // RVA: 0x7FFAC47EDC40
    }

    public class RecipientInfoGenerator
    {
        // ── Methods ──
        public void Generate(){} // RVA: 0x7FFAC2C6A6F0
    }

    public class RecipientInformation : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Cms.RecipientID RecipientID; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier KeyEncryptionAlgorithmID; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Cms.CmsSecureReadable KeyEncryptionAlgOid; // 0x20
        public byte[] KeyEncryptionAlgParams; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBCC9CA0
        public void GetContentAlgorithmName(){} // RVA: 0x7FFACBCC9E00
        public void get_RecipientID(){} // RVA: 0x7FFAC2F3C380
        public void get_KeyEncryptionAlgorithmID(){} // RVA: 0x7FFAC2F247C0
        public void get_KeyEncryptionAlgOid(){} // RVA: 0x7FFACBCC9EE0
        public void get_KeyEncryptionAlgParams(){} // RVA: 0x7FFACBCC9F20
        public void GetContentFromSessionKey(){} // RVA: 0x7FFACBCC9F70
        public void GetContent(){} // RVA: 0x7FFACBCCA180
        public void GetMac(){} // RVA: 0x7FFACBCCA260
        public void GetContentStream(){} // RVA: 0x7FFAC2C58F40
    }

    public class RecipientInformationStore : Object
    {
        public System.Collections.IList Item; // 0x10
        public System.Collections.IDictionary Count; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBCCA440
        public void get_Item(){} // RVA: 0x7FFACBCCA980
        public void GetFirstRecipient(){} // RVA: 0x7FFACBCCAA90
        public void get_Count(){} // RVA: 0x7FFACBCCABA0
        public void GetRecipients(){} // RVA: 0x7FFACBCCAC90 | overloaded x2
    }

    public class SignerID : X509CertStoreSelector
    {
        // ── Methods ──
        public void GetHashCode(){} // RVA: 0x7FFACBCCAE10
        public void Equals(){} // RVA: 0x7FFACBCCAF00
        public void .ctor(){} // RVA: 0x7FFAC47EDC40
    }

    public class SignerInfoGenerator : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.X509.X509Certificate certificate; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.ISignatureFactory contentSigner; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.SignerIdentifier sigId; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Cms.CmsAttributeTableGenerator signedGen; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Cms.CmsAttributeTableGenerator unsignedGen; // 0x30
        public bool isDirectSignature; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBCCB360 | overloaded x3
        public void setAssociatedCertificate(){} // RVA: 0x7FFAC2F22E30
    }

    public class SignerInfoGeneratorBuilder : Object
    {
        public bool directSignature; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Cms.CmsAttributeTableGenerator signedGen; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Cms.CmsAttributeTableGenerator unsignedGen; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void SetDirectSignature(){} // RVA: 0x7FFACBCCB4C0
        public void WithSignedAttributeGenerator(){} // RVA: 0x7FFAC46D4B40
        public void WithUnsignedAttributeGenerator(){} // RVA: 0x7FFACBB3DA00
        public void Build(){} // RVA: 0x7FFACBCCB760 | overloaded x2
        public void CreateGenerator(){} // RVA: 0x7FFACBCCB8A0
    }

    public class SignerInformation : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Cms.CmsSignedHelper IsCounterSignature;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Cms.SignerID ContentType; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.SignerInfo SignerID; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier Version; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier DigestAlgorithmID; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set DigestAlgOid; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set DigestAlgParams; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Cms.CmsProcessable EncryptionAlgorithmID; // 0x40
        public byte[] EncryptionAlgOid; // 0x48
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier EncryptionAlgParams; // 0x50
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Cms.IDigestCalculator SignedAttributes; // 0x58
        public byte[] UnsignedAttributes; // 0x60
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.AttributeTable signedAttributeTable; // 0x68
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.AttributeTable unsignedAttributeTable; // 0x70
        public bool isCounterSignature; // 0x78

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBCCC0D0 | overloaded x2
        public void get_IsCounterSignature(){} // RVA: 0x7FFAC33CE5C0
        public void get_ContentType(){} // RVA: 0x7FFAC2FC20E0
        public void get_SignerID(){} // RVA: 0x7FFAC2F3C380
        public void get_Version(){} // RVA: 0x7FFACBCA6DE0
        public void get_DigestAlgorithmID(){} // RVA: 0x7FFAC2F4F0C0
        public void get_DigestAlgOid(){} // RVA: 0x7FFACBC97A20
        public void get_DigestAlgParams(){} // RVA: 0x7FFACBCCC550
        public void GetContentDigest(){} // RVA: 0x7FFACBCCC5A0
        public void get_EncryptionAlgorithmID(){} // RVA: 0x7FFAC2F4F130
        public void get_EncryptionAlgOid(){} // RVA: 0x7FFACBCCC660
        public void get_EncryptionAlgParams(){} // RVA: 0x7FFACBCCC6A0
        public void get_SignedAttributes(){} // RVA: 0x7FFACBCCC6F0
        public void get_UnsignedAttributes(){} // RVA: 0x7FFACBCCC7C0
        public void GetSignature(){} // RVA: 0x7FFACBCCC890
        public void GetCounterSignatures(){} // RVA: 0x7FFACBCCC910
        public void GetEncodedSignedAttributes(){} // RVA: 0x7FFACBCCCF80
        public void DoVerify(){} // RVA: 0x7FFACBCCCFE0
        public void IsNull(){} // RVA: 0x7FFACBCCE3A0
        public void DerDecode(){} // RVA: 0x7FFACBCCE410
        public void VerifyDigest(){} // RVA: 0x7FFACBCCE520
        public void Verify(){} // RVA: 0x7FFACBCCED30 | overloaded x2
        public void ToSignerInfo(){} // RVA: 0x7FFAC2F247C0
        public void GetSingleValuedSignedAttribute(){} // RVA: 0x7FFACBCCEDB0
        public void GetSigningTime(){} // RVA: 0x7FFACBCCF080
        public void ReplaceUnsignedAttributes(){} // RVA: 0x7FFACBCCF170
        public void AddCounterSigners(){} // RVA: 0x7FFACBCCF390
        public void .cctor(){} // RVA: 0x7FFACBCCF970
    }

    public class SignerInformationStore : Object
    {
        public System.Collections.IList Count; // 0x10
        public System.Collections.IDictionary table; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBCCFCC0 | overloaded x2
        public void GetFirstSigner(){} // RVA: 0x7FFACBCD0200
        public void get_Count(){} // RVA: 0x7FFACBCD0310
        public void GetSigners(){} // RVA: 0x7FFACBCD0400 | overloaded x2
    }

    public class SimpleAttributeTableGenerator : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.AttributeTable attributes; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void GetAttributes(){} // RVA: 0x7FFAC2F3C380
    }

}