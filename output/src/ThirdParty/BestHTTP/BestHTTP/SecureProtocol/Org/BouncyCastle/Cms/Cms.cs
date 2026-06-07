// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Cms
// Classes: 69
// Methods: 475

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Cms
{
    public class BaseDigestCalculator : `
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void GetDigest(){} // RVA: 0x968E630
    }

    public class CmsAttributeTableGenerationException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x968E790 | overloaded x3
    }

    public class CmsAttributeTableGenerator
    {
        // ── Methods ──
        public void GetAttributes(){} // RVA: 0xCE10
    }

    public class CmsAuthEnvelopedData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9692660 | overloaded x3
    }

    public class CmsAuthEnvelopedGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x9692A40
    }

    public class CmsAuthenticatedData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x968E850 | overloaded x3
        public void GetMac(){} // RVA: 0x968EBB0
        public void get_MacAlgorithmID(){} // RVA: 0x30B0C0
        public void get_MacAlgOid(){} // RVA: 0x968EC60
        public void GetRecipientInfos(){} // RVA: 0x2F8380
        public void get_ContentInfo(){} // RVA: 0x2E07C0
        public void GetAuthAttrs(){} // RVA: 0x968ECA0
        public void GetUnauthAttrs(){} // RVA: 0x968ED10
        public void GetEncoded(){} // RVA: 0x968ED80
    }

    public class CmsAuthenticatedDataGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x968EDB0 | overloaded x2
        public void Generate(){} // RVA: 0x968F920 | overloaded x2
    }

    public class CmsAuthenticatedDataParser
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x968FB60 | overloaded x2
        public void get_MacAlgorithmID(){} // RVA: 0x6374D0
        public void get_MacAlgOid(){} // RVA: 0x9690600
        public void get_MacAlgParams(){} // RVA: 0x9690640
        public void GetRecipientInfos(){} // RVA: 0x30B0C0
        public void GetMac(){} // RVA: 0x9690690
        public void GetAuthAttrs(){} // RVA: 0x9690910
        public void GetUnauthAttrs(){} // RVA: 0x9690D00
    }

    public class CmsAuthenticatedDataStreamGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x968EDB0 | overloaded x2
        public void SetBufferSize(){} // RVA: 0xA53440
        public void SetBerEncodeRecipients(){} // RVA: 0x3BC240
        public void Open(){} // RVA: 0x9691F10 | overloaded x4
    }

    public class CmsAuthenticatedGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x968EDB0 | overloaded x2
    }

    public class CmsCompressedData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30 | overloaded x3
        public void GetContent(){} // RVA: 0x96931D0 | overloaded x2
        public void get_ContentInfo(){} // RVA: 0x2F8380
        public void GetEncoded(){} // RVA: 0x945AC10
    }

    public class CmsCompressedDataGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void Generate(){} // RVA: 0x96934E0
    }

    public class CmsCompressedDataParser
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9693AF0 | overloaded x2
        public void GetContent(){} // RVA: 0x9693B00
    }

    public class CmsCompressedDataStreamGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void SetBufferSize(){} // RVA: 0x2E00C0
        public void Open(){} // RVA: 0x9693E70 | overloaded x2
    }

    public class CmsContentInfoParser
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9694650
        public void Close(){} // RVA: 0x9694920
    }

    public class CmsEnvelopedData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9694A40 | overloaded x3
        public void get_EncryptionAlgorithmID(){} // RVA: 0x30B0C0
        public void get_EncryptionAlgOid(){} // RVA: 0x968EC60
        public void GetRecipientInfos(){} // RVA: 0x2F8380
        public void get_ContentInfo(){} // RVA: 0x2E07C0
        public void GetUnprotectedAttributes(){} // RVA: 0x9694CE0
        public void GetEncoded(){} // RVA: 0x968ED80
    }

    public class CmsEnvelopedDataGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9694DF0 | overloaded x2
        public void Generate(){} // RVA: 0x96965D0 | overloaded x4
    }

    public class CmsEnvelopedDataParser
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9696810 | overloaded x2
        public void get_EncryptionAlgorithmID(){} // RVA: 0x6374D0
        public void get_EncryptionAlgOid(){} // RVA: 0x9690600
        public void get_EncryptionAlgParams(){} // RVA: 0x9690640
        public void GetRecipientInfos(){} // RVA: 0x30B0C0
        public void GetUnprotectedAttributes(){} // RVA: 0x9697090
    }

    public class CmsEnvelopedDataStreamGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9697520 | overloaded x2
        public void SetBufferSize(){} // RVA: 0xFDD6E0
        public void SetBerEncodeRecipients(){} // RVA: 0x4424F0
        public void get_Version(){} // RVA: 0x9697580
        public void Open(){} // RVA: 0x9698570 | overloaded x4
    }

    public class CmsEnvelopedGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x96989B0 | overloaded x2
        public void get_UnprotectedAttributeGenerator(){} // RVA: 0x30B0C0
        public void set_UnprotectedAttributeGenerator(){} // RVA: 0x30B0D0
        public void AddKeyTransRecipient(){} // RVA: 0x9698B90 | overloaded x2
        public void AddKekRecipient(){} // RVA: 0x9698E10 | overloaded x2
        public void AddPasswordRecipient(){} // RVA: 0x9699060
        public void AddKeyAgreementRecipient(){} // RVA: 0x96992F0
        public void AddKeyAgreementRecipients(){} // RVA: 0x9699490
        public void AddRecipientInfoGenerator(){} // RVA: 0x9699850
        public void GetAlgorithmIdentifier(){} // RVA: 0x96998B0
        public void GenerateAsn1Parameters(){} // RVA: 0x9699AA0
        public void .cctor(){} // RVA: 0x9699CA0
    }

    public class CmsEnvelopedHelper
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x969A900
        public void GetAsymmetricEncryptionAlgName(){} // RVA: 0x969AE50
        public void CreateAsymmetricCipher(){} // RVA: 0x969AF10
        public void CreateWrapper(){} // RVA: 0x969AFF0
        public void GetRfc3211WrapperName(){} // RVA: 0x969B090
        public void GetKeySize(){} // RVA: 0x969B230
        public void BuildRecipientInformationStore(){} // RVA: 0x969B3B0
        public void ReadRecipientInfo(){} // RVA: 0x969B520
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class CmsException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x969C510 | overloaded x3
    }

    public class CmsPbeKey
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x969C830 | overloaded x4
        public void Finalize(){} // RVA: 0x969CB90
        public void get_Password(){} // RVA: 0x969CBF0
        public void get_Salt(){} // RVA: 0x969CC00
        public void GetSalt(){} // RVA: 0x969CCB0
        public void get_IterationCount(){} // RVA: 0x760030
        public void get_Algorithm(){} // RVA: 0x969CCC0
        public void get_Format(){} // RVA: 0x969CD00
        public void GetEncoded(){} // RVA: 0xCE10 | overloaded x2
    }

    public class CmsProcessable
    {
        // ── Methods ──
        public void Write(){} // RVA: 0x24B10
        public void GetContent(){} // RVA: 0xCD60
    }

    public class CmsProcessableByteArray
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5F28620 | overloaded x2
        public void get_Type(){} // RVA: 0x2F8380
        public void GetInputStream(){} // RVA: 0x969CE60
        public void Write(){} // RVA: 0x969CEC0
        public void GetContent(){} // RVA: 0x969CF10
    }

    public class CmsProcessableFile : .ctor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1D66A50 | overloaded x2
        public void GetInputStream(){} // RVA: 0x969CFA0
        public void Write(){} // RVA: 0x969D050
        public void GetContent(){} // RVA: 0x2F8380
    }

    public class CmsProcessableInputStream : .ctor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void GetInputStream(){} // RVA: 0x969D190
        public void Write(){} // RVA: 0x969D1C0
        public void GetContent(){} // RVA: 0x1CA1C00
        public void CheckSingleUsage(){} // RVA: 0x969D310
    }

    public class CmsReadable
    {
        // ── Methods ──
        public void GetInputStream(){} // RVA: 0xCD60
    }

    public class CmsSecureReadable
    {
        public object xh{e;

        // ── Methods ──
        public void get_Algorithm(){} // RVA: 0xCD60
        public void get_CryptoObject(){} // RVA: 0xCD60
        public void GetReadable(){} // RVA: 0xCE10
    }

    public class CmsSignedData
    {
        public object DigestAlgorithmID;
        public object SignedAttributes;
        public object UnsignedAttributes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x969DDD0 | overloaded x9
        public void get_Version(){} // RVA: 0x969E020
        public void GetSignerInfos(){} // RVA: 0x969E090
        public void GetAttributeCertificates(){} // RVA: 0x969E550
        public void GetCertificates(){} // RVA: 0x969E640
        public void GetCrls(){} // RVA: 0x969E730
        public void get_SignedContentTypeOid(){} // RVA: 0x969E820
        public void get_SignedContentType(){} // RVA: 0x969E850
        public void get_SignedContent(){} // RVA: 0x2F8380
        public void get_ContentInfo(){} // RVA: 0x30B0C0
        public void GetEncoded(){} // RVA: 0x969E880
        public void ReplaceSigners(){} // RVA: 0x969E8A0
        public void ReplaceCertificatesAndCrls(){} // RVA: 0x969F350
        public void .cctor(){} // RVA: 0x969F6C0
    }

    public class CmsSignedDataGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x969F8E0 | overloaded x2
        public void AddSigner(){} // RVA: 0x96A0840 | overloaded x12
        public void AddSignerInfoGenerator(){} // RVA: 0x96A0900
        public void doAddSigner(){} // RVA: 0x96A09F0
        public void Generate(){} // RVA: 0x96A18C0 | overloaded x3
        public void GenerateCounterSigners(){} // RVA: 0x96A1950
        public void .cctor(){} // RVA: 0x96A1A00
    }

    public class CmsSignedDataParser
    {
        public object DigestAlgorithm;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x96A2E50 | overloaded x4
        public void get_Version(){} // RVA: 0x96A3740
        public void get_DigestOids(){} // RVA: 0x96A37B0
        public void GetSignerInfos(){} // RVA: 0x96A3810
        public void GetAttributeCertificates(){} // RVA: 0x96A4390
        public void GetCertificates(){} // RVA: 0x96A4480
        public void GetCrls(){} // RVA: 0x96A4570
        public void PopulateCertCrlSets(){} // RVA: 0x96A4660
        public void get_SignedContentType(){} // RVA: 0x30B130
        public void GetSignedContent(){} // RVA: 0x96A48B0
        public void ReplaceSigners(){} // RVA: 0x96A4CF0
        public void ReplaceCertificatesAndCrls(){} // RVA: 0x96A51C0
        public void GetAsn1Set(){} // RVA: 0x96A5490
        public void .cctor(){} // RVA: 0x96A54F0
    }

    public class CmsSignedDataStreamGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x96A58C0 | overloaded x2
        public void SetBufferSize(){} // RVA: 0x1C5A610
        public void AddDigests(){} // RVA: 0x96A5BB0 | overloaded x2
        public void AddSigner(){} // RVA: 0x96A6620 | overloaded x11
        public void DoAddSigner(){} // RVA: 0x96A66C0
        public void AddSignerCallback(){} // RVA: 0x96A6890
        public void Open(){} // RVA: 0x96A6AB0 | overloaded x5
        public void RegisterDigestOid(){} // RVA: 0x96A7450
        public void ConfigureDigest(){} // RVA: 0x96A7520
        public void Generate(){} // RVA: 0x96A76F0
        public void CalculateVersion(){} // RVA: 0x96A77E0
        public void CheckForVersion3(){} // RVA: 0x96A7C70
        public void AttachDigestsToOutputStream(){} // RVA: 0x96A7ED0
        public void GetSafeOutputStream(){} // RVA: 0x96A82B0
        public void GetSafeTeeOutputStream(){} // RVA: 0x96A8330
        public void .cctor(){} // RVA: 0x96A8490
    }

    public class CmsSignedGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x96B1020 | overloaded x2
        public void GetBaseParameters(){} // RVA: 0x96B1310
        public void GetAttributeSet(){} // RVA: 0x96B1550
        public void AddCertificates(){} // RVA: 0x96B1670
        public void AddCrls(){} // RVA: 0x96B16A0
        public void AddAttributeCertificates(){} // RVA: 0x96B16D0
        public void AddSigners(){} // RVA: 0x96B1B20
        public void GetGeneratedDigests(){} // RVA: 0x96B1E20
        public void get_UseDerForCerts(){} // RVA: 0x303450
        public void set_UseDerForCerts(){} // RVA: 0x303460
        public void get_UseDerForCrls(){} // RVA: 0x303470
        public void set_UseDerForCrls(){} // RVA: 0x303480
        public void AddSignerCallback(){} // RVA: 0x2DD310
        public void GetSignerIdentifier(){} // RVA: 0x96B1FD0 | overloaded x2
        public void .cctor(){} // RVA: 0x96B20F0
    }

    public class CmsSignedHelper
    {
        // ── Methods ──
        public void AddEntries(){} // RVA: 0x96B2BB0
        public void .cctor(){} // RVA: 0x96B2CA0
        public void GetDigestAlgName(){} // RVA: 0x96B4800
        public void GetEncAlgorithmIdentifier(){} // RVA: 0x96B48C0
        public void GetDigestAliases(){} // RVA: 0x96B4A10
        public void GetEncryptionAlgName(){} // RVA: 0x96B4B30
        public void GetDigestInstance(){} // RVA: 0x96B4BF0
        public void GetSignatureInstance(){} // RVA: 0x96B4CF0
        public void CreateAttributeStore(){} // RVA: 0x96B4D40
        public void CreateCertificateStore(){} // RVA: 0x96B51F0
        public void CreateCrlStore(){} // RVA: 0x96B5370
        public void AddCertsFromSet(){} // RVA: 0x96B54F0
        public void AddCrlsFromSet(){} // RVA: 0x96B5800
        public void FixAlgID(){} // RVA: 0x96B5AC0
        public void GetEncOid(){} // RVA: 0x96B5BB0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class CmsStreamException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5E254B0 | overloaded x3
    }

    public class CmsTypedStream
    {
        public object MaximumMemory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x96B63C0 | overloaded x3
        public void get_ContentType(){} // RVA: 0x2F8380
        public void get_ContentStream(){} // RVA: 0x2E07C0
        public void Drain(){} // RVA: 0x96B6520
    }

    public class CmsUtilities
    {
        // ── Methods ──
        public void get_MaximumMemory(){} // RVA: 0x96B66C0
        public void ReadContentInfo(){} // RVA: 0x96B6800 | overloaded x3
        public void StreamToByteArray(){} // RVA: 0x96B6960 | overloaded x2
        public void GetCertificatesFromStore(){} // RVA: 0x96B6B00
        public void GetCrlsFromStore(){} // RVA: 0x96B6F70
        public void CreateBerSetFromList(){} // RVA: 0x96B73E0
        public void CreateDerSetFromList(){} // RVA: 0x96B7750
        public void CreateBerOctetOutputStream(){} // RVA: 0x96B7AA0
        public void GetTbsCertificateStructure(){} // RVA: 0x96B7C80
        public void GetIssuerAndSerialNumber(){} // RVA: 0x96B7CC0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class CounterSignatureDigestCalculator : `
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xF19AE0
        public void GetDigest(){} // RVA: 0x96B7D80
    }

    public class DefaultAuthenticatedAttributeTableGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x96B8010 | overloaded x2
        public void CreateStandardAttributeTable(){} // RVA: 0x96B81B0
        public void GetAttributes(){} // RVA: 0x96B86A0
    }

    public class DefaultDigestAlgorithmIdentifierFinder
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x96AF850
        public void find(){} // RVA: 0x96B0E60 | overloaded x2
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class DefaultSignatureAlgorithmIdentifierFinder
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x96AAA50
        public void Generate(){} // RVA: 0x96AF050
        public void CreatePssParams(){} // RVA: 0x96AF6B0
        public void Find(){} // RVA: 0x96AF800
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class DefaultSignedAttributeTableGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x96B8800 | overloaded x2
        public void createStandardAttributeTable(){} // RVA: 0x96B89A0
        public void DoCreateStandardAttributeTable(){} // RVA: 0x96B8A40
        public void GetAttributes(){} // RVA: 0x96B90D0
    }

    public class EnvelopedDataHelper
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x96B9150
        public void CreateContentCipher(){} // RVA: 0x96B9690
        public void GenerateEncryptionAlgID(){} // RVA: 0x96B9700
        public void CreateKeyGenerator(){} // RVA: 0x96B9790
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class IDigestCalculator
    {
        // ── Methods ──
        public void GetDigest(){} // RVA: 0xCD60
    }

    public class ISignerInfoGenerator
    {
        // ── Methods ──
        public void Generate(){} // RVA: 0x1EE30
    }

    public class KekRecipientInfoGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void set_KekIdentifier(){} // RVA: 0x30B0D0
        public void set_KeyEncryptionKey(){} // RVA: 0x96B97B0
        public void set_KeyEncryptionKeyOID(){} // RVA: 0x343E80
        public void Generate(){} // RVA: 0x96B98E0
        public void DetermineKeyEncAlg(){} // RVA: 0x96B9C30
        public void .cctor(){} // RVA: 0x96BA200
    }

    public class KekRecipientInformation
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x96BA2D0
        public void GetContentStream(){} // RVA: 0x96BA540
    }

    public class KeyAgreeRecipientInfoGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void set_KeyAgreementOID(){} // RVA: 0x2DEE30
        public void set_KeyEncryptionOID(){} // RVA: 0x343E80
        public void set_RecipientCerts(){} // RVA: 0x96BA800
        public void set_SenderKeyPair(){} // RVA: 0x2DEE90
        public void Generate(){} // RVA: 0x96BA8F0
        public void CreateOriginatorPublicKey(){} // RVA: 0x96BBCB0
        public void .cctor(){} // RVA: 0x96BBED0
    }

    public class KeyAgreeRecipientInformation
    {
        // ── Methods ──
        public void ReadRecipientInfo(){} // RVA: 0x96BBFA0
        public void .ctor(){} // RVA: 0x96BC3C0
        public void GetSenderPublicKey(){} // RVA: 0x96BC520
        public void GetPublicKeyFromOriginatorPublicKey(){} // RVA: 0x96BC680
        public void GetPublicKeyFromOriginatorID(){} // RVA: 0x96BC750
        public void CalculateAgreedWrapKey(){} // RVA: 0x96BC7A0
        public void UnwrapSessionKey(){} // RVA: 0x96BCBD0
        public void GetSessionKey(){} // RVA: 0x96BCD60
        public void GetContentStream(){} // RVA: 0x96BD230
    }

    public class KeyTransRecipientInfoGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x96BD3B0 | overloaded x3
        public void set_RecipientCert(){} // RVA: 0x96BD500
        public void set_RecipientPublicKey(){} // RVA: 0x96BD680
        public void set_SubjectKeyIdentifier(){} // RVA: 0x30B0D0
        public void Generate(){} // RVA: 0x96BD7A0
        public void get_AlgorithmDetails(){} // RVA: 0x408F2D0
        public void GenerateWrappedKey(){} // RVA: 0x96BDB00
        public void .cctor(){} // RVA: 0x96BDC90
    }

    public class KeyTransRecipientInformation
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x96BDD60
        public void GetExchangeEncryptionAlgorithmName(){} // RVA: 0x96BE0D0
        public void UnwrapKey(){} // RVA: 0x96BE540
        public void GetContentStream(){} // RVA: 0x96BE870
    }

    public class OriginatorID
    {
        // ── Methods ──
        public void GetHashCode(){} // RVA: 0x96BE8A0
        public void Equals(){} // RVA: 0x96BE990
        public void .ctor(){} // RVA: 0x1CC8140
    }

    public class OriginatorInfoGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x96BEE40 | overloaded x3
        public void Generate(){} // RVA: 0x96BEF30
    }

    public class OriginatorInformation
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void GetCertificates(){} // RVA: 0x96BF050
        public void GetCrls(){} // RVA: 0x96BF4B0
        public void ToAsn1Structure(){} // RVA: 0x2F8380
    }

    public class PasswordRecipientInfoGenerator : .ctor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void set_KeyDerivationAlgorithm(){} // RVA: 0x2DEE30
        public void set_KeyEncryptionKey(){} // RVA: 0x343E80
        public void set_KeyEncryptionKeyOID(){} // RVA: 0x30B0D0
        public void Generate(){} // RVA: 0x96BF910
        public void .cctor(){} // RVA: 0x96BFF10
    }

    public class PasswordRecipientInformation
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x96BFFE0
        public void get_KeyDerivationAlgorithm(){} // RVA: 0xA24B00
        public void GetContentStream(){} // RVA: 0x96C0100
    }

    public class Pkcs5Scheme2PbeKey
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x96C0600 | overloaded x4
        public void GetEncoded(){} // RVA: 0x96C0610
    }

    public class Pkcs5Scheme2Utf8PbeKey
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x96C0600 | overloaded x4
        public void GetEncoded(){} // RVA: 0x96C07B0
    }

    public class RecipientID
    {
        // ── Methods ──
        public void get_KeyIdentifier(){} // RVA: 0x96C09B0
        public void set_KeyIdentifier(){} // RVA: 0x96C0A70
        public void GetHashCode(){} // RVA: 0x96C0B80
        public void Equals(){} // RVA: 0x96C0CB0
        public void .ctor(){} // RVA: 0x1CC8140
    }

    public class RecipientInfoGenerator
    {
        // ── Methods ──
        public void Generate(){} // RVA: 0x1E6A0
    }

    public class RecipientInformation
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x96C0EE0
        public void GetContentAlgorithmName(){} // RVA: 0x96C1040
        public void get_RecipientID(){} // RVA: 0x2F8380
        public void get_KeyEncryptionAlgorithmID(){} // RVA: 0x2E07C0
        public void get_KeyEncryptionAlgOid(){} // RVA: 0x96C1120
        public void get_KeyEncryptionAlgParams(){} // RVA: 0x96C1160
        public void GetContentFromSessionKey(){} // RVA: 0x96C11B0
        public void GetContent(){} // RVA: 0x96C13C0
        public void GetMac(){} // RVA: 0x96C14A0
        public void GetContentStream(){} // RVA: 0xCE10
    }

    public class RecipientInformationStore
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x96C1680
        public void get_Item(){} // RVA: 0x96C1BC0
        public void GetFirstRecipient(){} // RVA: 0x96C1CD0
        public void get_Count(){} // RVA: 0x96C1DE0
        public void GetRecipients(){} // RVA: 0x96C1ED0 | overloaded x2
    }

    public class SignerID
    {
        // ── Methods ──
        public void GetHashCode(){} // RVA: 0x96C2050
        public void Equals(){} // RVA: 0x96C2140
        public void .ctor(){} // RVA: 0x1CC8140
    }

    public class SignerInfoGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x96C25A0 | overloaded x3
        public void setAssociatedCertificate(){} // RVA: 0x2DEE30
    }

    public class SignerInfoGeneratorBuilder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void SetDirectSignature(){} // RVA: 0x96C2700
        public void WithSignedAttributeGenerator(){} // RVA: 0x1C5A060
        public void WithUnsignedAttributeGenerator(){} // RVA: 0x9534C50
        public void Build(){} // RVA: 0x96C29A0 | overloaded x2
        public void CreateGenerator(){} // RVA: 0x96C2AE0
    }

    public class SignerInformation
    {
        public object Count;
        public object attributes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x96C3310 | overloaded x2
        public void get_IsCounterSignature(){} // RVA: 0x8A10E0
        public void get_ContentType(){} // RVA: 0x37E0E0
        public void get_SignerID(){} // RVA: 0x2F8380
        public void get_Version(){} // RVA: 0x969E020
        public void get_DigestAlgorithmID(){} // RVA: 0x30B0C0
        public void get_DigestAlgOid(){} // RVA: 0x968EC60
        public void get_DigestAlgParams(){} // RVA: 0x96C3790
        public void GetContentDigest(){} // RVA: 0x96C37E0
        public void get_EncryptionAlgorithmID(){} // RVA: 0x30B130
        public void get_EncryptionAlgOid(){} // RVA: 0x96C38A0
        public void get_EncryptionAlgParams(){} // RVA: 0x96C38E0
        public void get_SignedAttributes(){} // RVA: 0x96C3930
        public void get_UnsignedAttributes(){} // RVA: 0x96C3A00
        public void GetSignature(){} // RVA: 0x96C3AD0
        public void GetCounterSignatures(){} // RVA: 0x96C3B50
        public void GetEncodedSignedAttributes(){} // RVA: 0x96C41C0
        public void DoVerify(){} // RVA: 0x96C4220
        public void IsNull(){} // RVA: 0x96C55E0
        public void DerDecode(){} // RVA: 0x96C5650
        public void VerifyDigest(){} // RVA: 0x96C5760
        public void Verify(){} // RVA: 0x96C5F70 | overloaded x2
        public void ToSignerInfo(){} // RVA: 0x2E07C0
        public void GetSingleValuedSignedAttribute(){} // RVA: 0x96C5FF0
        public void GetSigningTime(){} // RVA: 0x96C62C0
        public void ReplaceUnsignedAttributes(){} // RVA: 0x96C63B0
        public void AddCounterSigners(){} // RVA: 0x96C65D0
        public void .cctor(){} // RVA: 0x96C6BB0
    }

    public class SignerInformationStore
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x96C6F00 | overloaded x2
        public void GetFirstSigner(){} // RVA: 0x96C7440
        public void get_Count(){} // RVA: 0x96C7550
        public void GetSigners(){} // RVA: 0x96C7640 | overloaded x2
    }

    public class SimpleAttributeTableGenerator : `
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void GetAttributes(){} // RVA: 0x2F8380
    }

}