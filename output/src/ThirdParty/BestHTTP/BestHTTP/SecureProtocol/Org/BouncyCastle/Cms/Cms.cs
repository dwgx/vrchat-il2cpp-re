// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Cms
// Classes: 69
// Methods: 475

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Cms
{
    public class BaseDigestCalculator : `
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void GetDigest(){} // RVA: 0x7FFAFC13E630
    }

    public class CmsAttributeTableGenerationException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC13E790 | overloaded x3
    }

    public class CmsAttributeTableGenerator
    {
        // ── Methods ──
        public void GetAttributes(){} // RVA: 0x7FFAF2ABCE10
    }

    public class CmsAuthEnvelopedData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC142660 | overloaded x3
    }

    public class CmsAuthEnvelopedGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAFC142A40
    }

    public class CmsAuthenticatedData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC13E850 | overloaded x3
        public void GetMac(){} // RVA: 0x7FFAFC13EBB0
        public void get_MacAlgorithmID(){} // RVA: 0x7FFAF2DBB0C0
        public void get_MacAlgOid(){} // RVA: 0x7FFAFC13EC60
        public void GetRecipientInfos(){} // RVA: 0x7FFAF2DA8380
        public void get_ContentInfo(){} // RVA: 0x7FFAF2D907C0
        public void GetAuthAttrs(){} // RVA: 0x7FFAFC13ECA0
        public void GetUnauthAttrs(){} // RVA: 0x7FFAFC13ED10
        public void GetEncoded(){} // RVA: 0x7FFAFC13ED80
    }

    public class CmsAuthenticatedDataGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC13EDB0 | overloaded x2
        public void Generate(){} // RVA: 0x7FFAFC13F920 | overloaded x2
    }

    public class CmsAuthenticatedDataParser
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC13FB60 | overloaded x2
        public void get_MacAlgorithmID(){} // RVA: 0x7FFAF30E74D0
        public void get_MacAlgOid(){} // RVA: 0x7FFAFC140600
        public void get_MacAlgParams(){} // RVA: 0x7FFAFC140640
        public void GetRecipientInfos(){} // RVA: 0x7FFAF2DBB0C0
        public void GetMac(){} // RVA: 0x7FFAFC140690
        public void GetAuthAttrs(){} // RVA: 0x7FFAFC140910
        public void GetUnauthAttrs(){} // RVA: 0x7FFAFC140D00
    }

    public class CmsAuthenticatedDataStreamGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC13EDB0 | overloaded x2
        public void SetBufferSize(){} // RVA: 0x7FFAF3503440
        public void SetBerEncodeRecipients(){} // RVA: 0x7FFAF2E6C240
        public void Open(){} // RVA: 0x7FFAFC141F10 | overloaded x4
    }

    public class CmsAuthenticatedGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC13EDB0 | overloaded x2
    }

    public class CmsCompressedData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30 | overloaded x3
        public void GetContent(){} // RVA: 0x7FFAFC1431D0 | overloaded x2
        public void get_ContentInfo(){} // RVA: 0x7FFAF2DA8380
        public void GetEncoded(){} // RVA: 0x7FFAFBF0AC10
    }

    public class CmsCompressedDataGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void Generate(){} // RVA: 0x7FFAFC1434E0
    }

    public class CmsCompressedDataParser
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC143AF0 | overloaded x2
        public void GetContent(){} // RVA: 0x7FFAFC143B00
    }

    public class CmsCompressedDataStreamGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void SetBufferSize(){} // RVA: 0x7FFAF2D900C0
        public void Open(){} // RVA: 0x7FFAFC143E70 | overloaded x2
    }

    public class CmsContentInfoParser
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC144650
        public void Close(){} // RVA: 0x7FFAFC144920
    }

    public class CmsEnvelopedData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC144A40 | overloaded x3
        public void get_EncryptionAlgorithmID(){} // RVA: 0x7FFAF2DBB0C0
        public void get_EncryptionAlgOid(){} // RVA: 0x7FFAFC13EC60
        public void GetRecipientInfos(){} // RVA: 0x7FFAF2DA8380
        public void get_ContentInfo(){} // RVA: 0x7FFAF2D907C0
        public void GetUnprotectedAttributes(){} // RVA: 0x7FFAFC144CE0
        public void GetEncoded(){} // RVA: 0x7FFAFC13ED80
    }

    public class CmsEnvelopedDataGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC144DF0 | overloaded x2
        public void Generate(){} // RVA: 0x7FFAFC1465D0 | overloaded x4
    }

    public class CmsEnvelopedDataParser
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC146810 | overloaded x2
        public void get_EncryptionAlgorithmID(){} // RVA: 0x7FFAF30E74D0
        public void get_EncryptionAlgOid(){} // RVA: 0x7FFAFC140600
        public void get_EncryptionAlgParams(){} // RVA: 0x7FFAFC140640
        public void GetRecipientInfos(){} // RVA: 0x7FFAF2DBB0C0
        public void GetUnprotectedAttributes(){} // RVA: 0x7FFAFC147090
    }

    public class CmsEnvelopedDataStreamGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC147520 | overloaded x2
        public void SetBufferSize(){} // RVA: 0x7FFAF3A8D6E0
        public void SetBerEncodeRecipients(){} // RVA: 0x7FFAF2EF24F0
        public void get_Version(){} // RVA: 0x7FFAFC147580
        public void Open(){} // RVA: 0x7FFAFC148570 | overloaded x4
    }

    public class CmsEnvelopedGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC1489B0 | overloaded x2
        public void get_UnprotectedAttributeGenerator(){} // RVA: 0x7FFAF2DBB0C0
        public void set_UnprotectedAttributeGenerator(){} // RVA: 0x7FFAF2DBB0D0
        public void AddKeyTransRecipient(){} // RVA: 0x7FFAFC148B90 | overloaded x2
        public void AddKekRecipient(){} // RVA: 0x7FFAFC148E10 | overloaded x2
        public void AddPasswordRecipient(){} // RVA: 0x7FFAFC149060
        public void AddKeyAgreementRecipient(){} // RVA: 0x7FFAFC1492F0
        public void AddKeyAgreementRecipients(){} // RVA: 0x7FFAFC149490
        public void AddRecipientInfoGenerator(){} // RVA: 0x7FFAFC149850
        public void GetAlgorithmIdentifier(){} // RVA: 0x7FFAFC1498B0
        public void GenerateAsn1Parameters(){} // RVA: 0x7FFAFC149AA0
        public void .cctor(){} // RVA: 0x7FFAFC149CA0
    }

    public class CmsEnvelopedHelper
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAFC14A900
        public void GetAsymmetricEncryptionAlgName(){} // RVA: 0x7FFAFC14AE50
        public void CreateAsymmetricCipher(){} // RVA: 0x7FFAFC14AF10
        public void CreateWrapper(){} // RVA: 0x7FFAFC14AFF0
        public void GetRfc3211WrapperName(){} // RVA: 0x7FFAFC14B090
        public void GetKeySize(){} // RVA: 0x7FFAFC14B230
        public void BuildRecipientInformationStore(){} // RVA: 0x7FFAFC14B3B0
        public void ReadRecipientInfo(){} // RVA: 0x7FFAFC14B520
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class CmsException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC14C510 | overloaded x3
    }

    public class CmsPbeKey
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC14C830 | overloaded x4
        public void Finalize(){} // RVA: 0x7FFAFC14CB90
        public void get_Password(){} // RVA: 0x7FFAFC14CBF0
        public void get_Salt(){} // RVA: 0x7FFAFC14CC00
        public void GetSalt(){} // RVA: 0x7FFAFC14CCB0
        public void get_IterationCount(){} // RVA: 0x7FFAF3210030
        public void get_Algorithm(){} // RVA: 0x7FFAFC14CCC0
        public void get_Format(){} // RVA: 0x7FFAFC14CD00
        public void GetEncoded(){} // RVA: 0x7FFAF2ABCE10 | overloaded x2
    }

    public class CmsProcessable
    {
        // ── Methods ──
        public void Write(){} // RVA: 0x7FFAF2AD4B10
        public void GetContent(){} // RVA: 0x7FFAF2ABCD60
    }

    public class CmsProcessableByteArray
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF89D8620 | overloaded x2
        public void get_Type(){} // RVA: 0x7FFAF2DA8380
        public void GetInputStream(){} // RVA: 0x7FFAFC14CE60
        public void Write(){} // RVA: 0x7FFAFC14CEC0
        public void GetContent(){} // RVA: 0x7FFAFC14CF10
    }

    public class CmsProcessableFile : .ctor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF4816A50 | overloaded x2
        public void GetInputStream(){} // RVA: 0x7FFAFC14CFA0
        public void Write(){} // RVA: 0x7FFAFC14D050
        public void GetContent(){} // RVA: 0x7FFAF2DA8380
    }

    public class CmsProcessableInputStream : .ctor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void GetInputStream(){} // RVA: 0x7FFAFC14D190
        public void Write(){} // RVA: 0x7FFAFC14D1C0
        public void GetContent(){} // RVA: 0x7FFAF4751C00
        public void CheckSingleUsage(){} // RVA: 0x7FFAFC14D310
    }

    public class CmsReadable
    {
        // ── Methods ──
        public void GetInputStream(){} // RVA: 0x7FFAF2ABCD60
    }

    public class CmsSecureReadable
    {
        public object xh{e;

        // ── Methods ──
        public void get_Algorithm(){} // RVA: 0x7FFAF2ABCD60
        public void get_CryptoObject(){} // RVA: 0x7FFAF2ABCD60
        public void GetReadable(){} // RVA: 0x7FFAF2ABCE10
    }

    public class CmsSignedData
    {
        public object DigestAlgorithmID;
        public object SignedAttributes;
        public object UnsignedAttributes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC14DDD0 | overloaded x9
        public void get_Version(){} // RVA: 0x7FFAFC14E020
        public void GetSignerInfos(){} // RVA: 0x7FFAFC14E090
        public void GetAttributeCertificates(){} // RVA: 0x7FFAFC14E550
        public void GetCertificates(){} // RVA: 0x7FFAFC14E640
        public void GetCrls(){} // RVA: 0x7FFAFC14E730
        public void get_SignedContentTypeOid(){} // RVA: 0x7FFAFC14E820
        public void get_SignedContentType(){} // RVA: 0x7FFAFC14E850
        public void get_SignedContent(){} // RVA: 0x7FFAF2DA8380
        public void get_ContentInfo(){} // RVA: 0x7FFAF2DBB0C0
        public void GetEncoded(){} // RVA: 0x7FFAFC14E880
        public void ReplaceSigners(){} // RVA: 0x7FFAFC14E8A0
        public void ReplaceCertificatesAndCrls(){} // RVA: 0x7FFAFC14F350
        public void .cctor(){} // RVA: 0x7FFAFC14F6C0
    }

    public class CmsSignedDataGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC14F8E0 | overloaded x2
        public void AddSigner(){} // RVA: 0x7FFAFC150840 | overloaded x12
        public void AddSignerInfoGenerator(){} // RVA: 0x7FFAFC150900
        public void doAddSigner(){} // RVA: 0x7FFAFC1509F0
        public void Generate(){} // RVA: 0x7FFAFC1518C0 | overloaded x3
        public void GenerateCounterSigners(){} // RVA: 0x7FFAFC151950
        public void .cctor(){} // RVA: 0x7FFAFC151A00
    }

    public class CmsSignedDataParser
    {
        public object DigestAlgorithm;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC152E50 | overloaded x4
        public void get_Version(){} // RVA: 0x7FFAFC153740
        public void get_DigestOids(){} // RVA: 0x7FFAFC1537B0
        public void GetSignerInfos(){} // RVA: 0x7FFAFC153810
        public void GetAttributeCertificates(){} // RVA: 0x7FFAFC154390
        public void GetCertificates(){} // RVA: 0x7FFAFC154480
        public void GetCrls(){} // RVA: 0x7FFAFC154570
        public void PopulateCertCrlSets(){} // RVA: 0x7FFAFC154660
        public void get_SignedContentType(){} // RVA: 0x7FFAF2DBB130
        public void GetSignedContent(){} // RVA: 0x7FFAFC1548B0
        public void ReplaceSigners(){} // RVA: 0x7FFAFC154CF0
        public void ReplaceCertificatesAndCrls(){} // RVA: 0x7FFAFC1551C0
        public void GetAsn1Set(){} // RVA: 0x7FFAFC155490
        public void .cctor(){} // RVA: 0x7FFAFC1554F0
    }

    public class CmsSignedDataStreamGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC1558C0 | overloaded x2
        public void SetBufferSize(){} // RVA: 0x7FFAF470A610
        public void AddDigests(){} // RVA: 0x7FFAFC155BB0 | overloaded x2
        public void AddSigner(){} // RVA: 0x7FFAFC156620 | overloaded x11
        public void DoAddSigner(){} // RVA: 0x7FFAFC1566C0
        public void AddSignerCallback(){} // RVA: 0x7FFAFC156890
        public void Open(){} // RVA: 0x7FFAFC156AB0 | overloaded x5
        public void RegisterDigestOid(){} // RVA: 0x7FFAFC157450
        public void ConfigureDigest(){} // RVA: 0x7FFAFC157520
        public void Generate(){} // RVA: 0x7FFAFC1576F0
        public void CalculateVersion(){} // RVA: 0x7FFAFC1577E0
        public void CheckForVersion3(){} // RVA: 0x7FFAFC157C70
        public void AttachDigestsToOutputStream(){} // RVA: 0x7FFAFC157ED0
        public void GetSafeOutputStream(){} // RVA: 0x7FFAFC1582B0
        public void GetSafeTeeOutputStream(){} // RVA: 0x7FFAFC158330
        public void .cctor(){} // RVA: 0x7FFAFC158490
    }

    public class CmsSignedGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC161020 | overloaded x2
        public void GetBaseParameters(){} // RVA: 0x7FFAFC161310
        public void GetAttributeSet(){} // RVA: 0x7FFAFC161550
        public void AddCertificates(){} // RVA: 0x7FFAFC161670
        public void AddCrls(){} // RVA: 0x7FFAFC1616A0
        public void AddAttributeCertificates(){} // RVA: 0x7FFAFC1616D0
        public void AddSigners(){} // RVA: 0x7FFAFC161B20
        public void GetGeneratedDigests(){} // RVA: 0x7FFAFC161E20
        public void get_UseDerForCerts(){} // RVA: 0x7FFAF2DB3450
        public void set_UseDerForCerts(){} // RVA: 0x7FFAF2DB3460
        public void get_UseDerForCrls(){} // RVA: 0x7FFAF2DB3470
        public void set_UseDerForCrls(){} // RVA: 0x7FFAF2DB3480
        public void AddSignerCallback(){} // RVA: 0x7FFAF2D8D310
        public void GetSignerIdentifier(){} // RVA: 0x7FFAFC161FD0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAFC1620F0
    }

    public class CmsSignedHelper
    {
        // ── Methods ──
        public void AddEntries(){} // RVA: 0x7FFAFC162BB0
        public void .cctor(){} // RVA: 0x7FFAFC162CA0
        public void GetDigestAlgName(){} // RVA: 0x7FFAFC164800
        public void GetEncAlgorithmIdentifier(){} // RVA: 0x7FFAFC1648C0
        public void GetDigestAliases(){} // RVA: 0x7FFAFC164A10
        public void GetEncryptionAlgName(){} // RVA: 0x7FFAFC164B30
        public void GetDigestInstance(){} // RVA: 0x7FFAFC164BF0
        public void GetSignatureInstance(){} // RVA: 0x7FFAFC164CF0
        public void CreateAttributeStore(){} // RVA: 0x7FFAFC164D40
        public void CreateCertificateStore(){} // RVA: 0x7FFAFC1651F0
        public void CreateCrlStore(){} // RVA: 0x7FFAFC165370
        public void AddCertsFromSet(){} // RVA: 0x7FFAFC1654F0
        public void AddCrlsFromSet(){} // RVA: 0x7FFAFC165800
        public void FixAlgID(){} // RVA: 0x7FFAFC165AC0
        public void GetEncOid(){} // RVA: 0x7FFAFC165BB0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class CmsStreamException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF88D54B0 | overloaded x3
    }

    public class CmsTypedStream
    {
        public object MaximumMemory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC1663C0 | overloaded x3
        public void get_ContentType(){} // RVA: 0x7FFAF2DA8380
        public void get_ContentStream(){} // RVA: 0x7FFAF2D907C0
        public void Drain(){} // RVA: 0x7FFAFC166520
    }

    public class CmsUtilities
    {
        // ── Methods ──
        public void get_MaximumMemory(){} // RVA: 0x7FFAFC1666C0
        public void ReadContentInfo(){} // RVA: 0x7FFAFC166800 | overloaded x3
        public void StreamToByteArray(){} // RVA: 0x7FFAFC166960 | overloaded x2
        public void GetCertificatesFromStore(){} // RVA: 0x7FFAFC166B00
        public void GetCrlsFromStore(){} // RVA: 0x7FFAFC166F70
        public void CreateBerSetFromList(){} // RVA: 0x7FFAFC1673E0
        public void CreateDerSetFromList(){} // RVA: 0x7FFAFC167750
        public void CreateBerOctetOutputStream(){} // RVA: 0x7FFAFC167AA0
        public void GetTbsCertificateStructure(){} // RVA: 0x7FFAFC167C80
        public void GetIssuerAndSerialNumber(){} // RVA: 0x7FFAFC167CC0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class CounterSignatureDigestCalculator : `
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF39C9AE0
        public void GetDigest(){} // RVA: 0x7FFAFC167D80
    }

    public class DefaultAuthenticatedAttributeTableGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC168010 | overloaded x2
        public void CreateStandardAttributeTable(){} // RVA: 0x7FFAFC1681B0
        public void GetAttributes(){} // RVA: 0x7FFAFC1686A0
    }

    public class DefaultDigestAlgorithmIdentifierFinder
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAFC15F850
        public void find(){} // RVA: 0x7FFAFC160E60 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class DefaultSignatureAlgorithmIdentifierFinder
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAFC15AA50
        public void Generate(){} // RVA: 0x7FFAFC15F050
        public void CreatePssParams(){} // RVA: 0x7FFAFC15F6B0
        public void Find(){} // RVA: 0x7FFAFC15F800
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class DefaultSignedAttributeTableGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC168800 | overloaded x2
        public void createStandardAttributeTable(){} // RVA: 0x7FFAFC1689A0
        public void DoCreateStandardAttributeTable(){} // RVA: 0x7FFAFC168A40
        public void GetAttributes(){} // RVA: 0x7FFAFC1690D0
    }

    public class EnvelopedDataHelper
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAFC169150
        public void CreateContentCipher(){} // RVA: 0x7FFAFC169690
        public void GenerateEncryptionAlgID(){} // RVA: 0x7FFAFC169700
        public void CreateKeyGenerator(){} // RVA: 0x7FFAFC169790
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class IDigestCalculator
    {
        // ── Methods ──
        public void GetDigest(){} // RVA: 0x7FFAF2ABCD60
    }

    public class ISignerInfoGenerator
    {
        // ── Methods ──
        public void Generate(){} // RVA: 0x7FFAF2ACEE30
    }

    public class KekRecipientInfoGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void set_KekIdentifier(){} // RVA: 0x7FFAF2DBB0D0
        public void set_KeyEncryptionKey(){} // RVA: 0x7FFAFC1697B0
        public void set_KeyEncryptionKeyOID(){} // RVA: 0x7FFAF2DF3E80
        public void Generate(){} // RVA: 0x7FFAFC1698E0
        public void DetermineKeyEncAlg(){} // RVA: 0x7FFAFC169C30
        public void .cctor(){} // RVA: 0x7FFAFC16A200
    }

    public class KekRecipientInformation
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC16A2D0
        public void GetContentStream(){} // RVA: 0x7FFAFC16A540
    }

    public class KeyAgreeRecipientInfoGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void set_KeyAgreementOID(){} // RVA: 0x7FFAF2D8EE30
        public void set_KeyEncryptionOID(){} // RVA: 0x7FFAF2DF3E80
        public void set_RecipientCerts(){} // RVA: 0x7FFAFC16A800
        public void set_SenderKeyPair(){} // RVA: 0x7FFAF2D8EE90
        public void Generate(){} // RVA: 0x7FFAFC16A8F0
        public void CreateOriginatorPublicKey(){} // RVA: 0x7FFAFC16BCB0
        public void .cctor(){} // RVA: 0x7FFAFC16BED0
    }

    public class KeyAgreeRecipientInformation
    {
        // ── Methods ──
        public void ReadRecipientInfo(){} // RVA: 0x7FFAFC16BFA0
        public void .ctor(){} // RVA: 0x7FFAFC16C3C0
        public void GetSenderPublicKey(){} // RVA: 0x7FFAFC16C520
        public void GetPublicKeyFromOriginatorPublicKey(){} // RVA: 0x7FFAFC16C680
        public void GetPublicKeyFromOriginatorID(){} // RVA: 0x7FFAFC16C750
        public void CalculateAgreedWrapKey(){} // RVA: 0x7FFAFC16C7A0
        public void UnwrapSessionKey(){} // RVA: 0x7FFAFC16CBD0
        public void GetSessionKey(){} // RVA: 0x7FFAFC16CD60
        public void GetContentStream(){} // RVA: 0x7FFAFC16D230
    }

    public class KeyTransRecipientInfoGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC16D3B0 | overloaded x3
        public void set_RecipientCert(){} // RVA: 0x7FFAFC16D500
        public void set_RecipientPublicKey(){} // RVA: 0x7FFAFC16D680
        public void set_SubjectKeyIdentifier(){} // RVA: 0x7FFAF2DBB0D0
        public void Generate(){} // RVA: 0x7FFAFC16D7A0
        public void get_AlgorithmDetails(){} // RVA: 0x7FFAF6B3F2D0
        public void GenerateWrappedKey(){} // RVA: 0x7FFAFC16DB00
        public void .cctor(){} // RVA: 0x7FFAFC16DC90
    }

    public class KeyTransRecipientInformation
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC16DD60
        public void GetExchangeEncryptionAlgorithmName(){} // RVA: 0x7FFAFC16E0D0
        public void UnwrapKey(){} // RVA: 0x7FFAFC16E540
        public void GetContentStream(){} // RVA: 0x7FFAFC16E870
    }

    public class OriginatorID
    {
        // ── Methods ──
        public void GetHashCode(){} // RVA: 0x7FFAFC16E8A0
        public void Equals(){} // RVA: 0x7FFAFC16E990
        public void .ctor(){} // RVA: 0x7FFAF4778140
    }

    public class OriginatorInfoGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC16EE40 | overloaded x3
        public void Generate(){} // RVA: 0x7FFAFC16EF30
    }

    public class OriginatorInformation
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void GetCertificates(){} // RVA: 0x7FFAFC16F050
        public void GetCrls(){} // RVA: 0x7FFAFC16F4B0
        public void ToAsn1Structure(){} // RVA: 0x7FFAF2DA8380
    }

    public class PasswordRecipientInfoGenerator : .ctor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void set_KeyDerivationAlgorithm(){} // RVA: 0x7FFAF2D8EE30
        public void set_KeyEncryptionKey(){} // RVA: 0x7FFAF2DF3E80
        public void set_KeyEncryptionKeyOID(){} // RVA: 0x7FFAF2DBB0D0
        public void Generate(){} // RVA: 0x7FFAFC16F910
        public void .cctor(){} // RVA: 0x7FFAFC16FF10
    }

    public class PasswordRecipientInformation
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC16FFE0
        public void get_KeyDerivationAlgorithm(){} // RVA: 0x7FFAF34D4B00
        public void GetContentStream(){} // RVA: 0x7FFAFC170100
    }

    public class Pkcs5Scheme2PbeKey
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC170600 | overloaded x4
        public void GetEncoded(){} // RVA: 0x7FFAFC170610
    }

    public class Pkcs5Scheme2Utf8PbeKey
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC170600 | overloaded x4
        public void GetEncoded(){} // RVA: 0x7FFAFC1707B0
    }

    public class RecipientID
    {
        // ── Methods ──
        public void get_KeyIdentifier(){} // RVA: 0x7FFAFC1709B0
        public void set_KeyIdentifier(){} // RVA: 0x7FFAFC170A70
        public void GetHashCode(){} // RVA: 0x7FFAFC170B80
        public void Equals(){} // RVA: 0x7FFAFC170CB0
        public void .ctor(){} // RVA: 0x7FFAF4778140
    }

    public class RecipientInfoGenerator
    {
        // ── Methods ──
        public void Generate(){} // RVA: 0x7FFAF2ACE6A0
    }

    public class RecipientInformation
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC170EE0
        public void GetContentAlgorithmName(){} // RVA: 0x7FFAFC171040
        public void get_RecipientID(){} // RVA: 0x7FFAF2DA8380
        public void get_KeyEncryptionAlgorithmID(){} // RVA: 0x7FFAF2D907C0
        public void get_KeyEncryptionAlgOid(){} // RVA: 0x7FFAFC171120
        public void get_KeyEncryptionAlgParams(){} // RVA: 0x7FFAFC171160
        public void GetContentFromSessionKey(){} // RVA: 0x7FFAFC1711B0
        public void GetContent(){} // RVA: 0x7FFAFC1713C0
        public void GetMac(){} // RVA: 0x7FFAFC1714A0
        public void GetContentStream(){} // RVA: 0x7FFAF2ABCE10
    }

    public class RecipientInformationStore
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC171680
        public void get_Item(){} // RVA: 0x7FFAFC171BC0
        public void GetFirstRecipient(){} // RVA: 0x7FFAFC171CD0
        public void get_Count(){} // RVA: 0x7FFAFC171DE0
        public void GetRecipients(){} // RVA: 0x7FFAFC171ED0 | overloaded x2
    }

    public class SignerID
    {
        // ── Methods ──
        public void GetHashCode(){} // RVA: 0x7FFAFC172050
        public void Equals(){} // RVA: 0x7FFAFC172140
        public void .ctor(){} // RVA: 0x7FFAF4778140
    }

    public class SignerInfoGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC1725A0 | overloaded x3
        public void setAssociatedCertificate(){} // RVA: 0x7FFAF2D8EE30
    }

    public class SignerInfoGeneratorBuilder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void SetDirectSignature(){} // RVA: 0x7FFAFC172700
        public void WithSignedAttributeGenerator(){} // RVA: 0x7FFAF470A060
        public void WithUnsignedAttributeGenerator(){} // RVA: 0x7FFAFBFE4C50
        public void Build(){} // RVA: 0x7FFAFC1729A0 | overloaded x2
        public void CreateGenerator(){} // RVA: 0x7FFAFC172AE0
    }

    public class SignerInformation
    {
        public object Count;
        public object attributes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC173310 | overloaded x2
        public void get_IsCounterSignature(){} // RVA: 0x7FFAF33510E0
        public void get_ContentType(){} // RVA: 0x7FFAF2E2E0E0
        public void get_SignerID(){} // RVA: 0x7FFAF2DA8380
        public void get_Version(){} // RVA: 0x7FFAFC14E020
        public void get_DigestAlgorithmID(){} // RVA: 0x7FFAF2DBB0C0
        public void get_DigestAlgOid(){} // RVA: 0x7FFAFC13EC60
        public void get_DigestAlgParams(){} // RVA: 0x7FFAFC173790
        public void GetContentDigest(){} // RVA: 0x7FFAFC1737E0
        public void get_EncryptionAlgorithmID(){} // RVA: 0x7FFAF2DBB130
        public void get_EncryptionAlgOid(){} // RVA: 0x7FFAFC1738A0
        public void get_EncryptionAlgParams(){} // RVA: 0x7FFAFC1738E0
        public void get_SignedAttributes(){} // RVA: 0x7FFAFC173930
        public void get_UnsignedAttributes(){} // RVA: 0x7FFAFC173A00
        public void GetSignature(){} // RVA: 0x7FFAFC173AD0
        public void GetCounterSignatures(){} // RVA: 0x7FFAFC173B50
        public void GetEncodedSignedAttributes(){} // RVA: 0x7FFAFC1741C0
        public void DoVerify(){} // RVA: 0x7FFAFC174220
        public void IsNull(){} // RVA: 0x7FFAFC1755E0
        public void DerDecode(){} // RVA: 0x7FFAFC175650
        public void VerifyDigest(){} // RVA: 0x7FFAFC175760
        public void Verify(){} // RVA: 0x7FFAFC175F70 | overloaded x2
        public void ToSignerInfo(){} // RVA: 0x7FFAF2D907C0
        public void GetSingleValuedSignedAttribute(){} // RVA: 0x7FFAFC175FF0
        public void GetSigningTime(){} // RVA: 0x7FFAFC1762C0
        public void ReplaceUnsignedAttributes(){} // RVA: 0x7FFAFC1763B0
        public void AddCounterSigners(){} // RVA: 0x7FFAFC1765D0
        public void .cctor(){} // RVA: 0x7FFAFC176BB0
    }

    public class SignerInformationStore
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC176F00 | overloaded x2
        public void GetFirstSigner(){} // RVA: 0x7FFAFC177440
        public void get_Count(){} // RVA: 0x7FFAFC177550
        public void GetSigners(){} // RVA: 0x7FFAFC177640 | overloaded x2
    }

    public class SimpleAttributeTableGenerator : `
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void GetAttributes(){} // RVA: 0x7FFAF2DA8380
    }

}