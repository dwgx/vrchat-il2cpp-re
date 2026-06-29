// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Cms
// Classes: 69
// Methods: 363

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Cms
{
    public class BaseDigestCalculator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void GetDigest(){} // RVA: 0x7B14C7940
    }

    public class CmsAttributeTableGenerationException : CmsException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B14C7AA0
    }

    public class CmsAttributeTableGenerator
    {
        // ── Methods ──
        public void GetAttributes(){} // RVA: 0x7A7E00B20
    }

    public class CmsAuthEnvelopedData : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B14CB960
    }

    public class CmsAuthEnvelopedGenerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7B14CBD50
    }

    public class CmsAuthenticatedData : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B14C7B60
        public void GetMac(){} // RVA: 0x7B14C7EC0
        public void get_MacAlgorithmID(){} // RVA: 0x7A81052C0
        public void get_MacAlgOid(){} // RVA: 0x7B14C7F70
        public void GetRecipientInfos(){} // RVA: 0x7A80F2570
        public void get_ContentInfo(){} // RVA: 0x7A80DA7B0
        public void GetAuthAttrs(){} // RVA: 0x7B14C7FB0
        public void GetUnauthAttrs(){} // RVA: 0x7B14C8020
        public void GetEncoded(){} // RVA: 0x7B14C8090
    }

    public class CmsAuthenticatedDataGenerator : CmsAuthenticatedGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B14C80C0
        public void Generate(){} // RVA: 0x7B14C8C20
    }

    public class CmsAuthenticatedDataParser : CmsContentInfoParser
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B14C8E60
        public void get_MacAlgorithmID(){} // RVA: 0x7A83F69F0
        public void get_MacAlgOid(){} // RVA: 0x7B14C9900
        public void get_MacAlgParams(){} // RVA: 0x7B14C9940
        public void GetRecipientInfos(){} // RVA: 0x7A81052C0
        public void GetMac(){} // RVA: 0x7B14C9990
        public void GetAuthAttrs(){} // RVA: 0x7B14C9C10
        public void GetUnauthAttrs(){} // RVA: 0x7B14CA000
    }

    public class CmsAuthenticatedDataStreamGenerator : CmsAuthenticatedGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B14C80C0
        public void SetBufferSize(){} // RVA: 0x7A8810F60
        public void SetBerEncodeRecipients(){} // RVA: 0x7A81B7090
        public void Open(){} // RVA: 0x7B14CB210
    }

    public class CmsAuthenticatedGenerator : CmsEnvelopedGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B14C80C0
    }

    public class CmsCompressedData : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void GetContent(){} // RVA: 0x7B14CC4F0
        public void get_ContentInfo(){} // RVA: 0x7A80F2570
        public void GetEncoded(){} // RVA: 0x7B128E860
    }

    public class CmsCompressedDataGenerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void Generate(){} // RVA: 0x7B14CC800
    }

    public class CmsCompressedDataParser : CmsContentInfoParser
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B14CCE10
        public void GetContent(){} // RVA: 0x7B14CCE20
    }

    public class CmsCompressedDataStreamGenerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void SetBufferSize(){} // RVA: 0x7A80DA0C0
        public void Open(){} // RVA: 0x7B14CD190
    }

    public class CmsContentInfoParser : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B14CD980
        public void Close(){} // RVA: 0x7B14CDC50
    }

    public class CmsEnvelopedData : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B14CDD70
        public void get_EncryptionAlgorithmID(){} // RVA: 0x7A81052C0
        public void get_EncryptionAlgOid(){} // RVA: 0x7B14C7F70
        public void GetRecipientInfos(){} // RVA: 0x7A80F2570
        public void get_ContentInfo(){} // RVA: 0x7A80DA7B0
        public void GetUnprotectedAttributes(){} // RVA: 0x7B14CE010
        public void GetEncoded(){} // RVA: 0x7B14C8090
    }

    public class CmsEnvelopedDataGenerator : CmsEnvelopedGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B14CE120
        public void Generate(){} // RVA: 0x7B14CF8B0
    }

    public class CmsEnvelopedDataParser : CmsContentInfoParser
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B14CFAF0
        public void get_EncryptionAlgorithmID(){} // RVA: 0x7A83F69F0
        public void get_EncryptionAlgOid(){} // RVA: 0x7B14C9900
        public void get_EncryptionAlgParams(){} // RVA: 0x7B14C9940
        public void GetRecipientInfos(){} // RVA: 0x7A81052C0
        public void GetUnprotectedAttributes(){} // RVA: 0x7B14D0370
    }

    public class CmsEnvelopedDataStreamGenerator : CmsEnvelopedGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B14D0800
        public void SetBufferSize(){} // RVA: 0x7A8D870E0
        public void SetBerEncodeRecipients(){} // RVA: 0x7A823D7A0
        public void get_Version(){} // RVA: 0x7B14D0860
        public void Open(){} // RVA: 0x7B14D1830
    }

    public class CmsEnvelopedGenerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B14D1C70
        public void get_UnprotectedAttributeGenerator(){} // RVA: 0x7A81052C0
        public void set_UnprotectedAttributeGenerator(){} // RVA: 0x7A81052D0
        public void AddKeyTransRecipient(){} // RVA: 0x7B14D1E50
        public void AddKekRecipient(){} // RVA: 0x7B14D20D0
        public void AddPasswordRecipient(){} // RVA: 0x7B14D2320
        public void AddKeyAgreementRecipient(){} // RVA: 0x7B14D25B0
        public void AddKeyAgreementRecipients(){} // RVA: 0x7B14D2750
        public void AddRecipientInfoGenerator(){} // RVA: 0x7B14D2B10
        public void GetAlgorithmIdentifier(){} // RVA: 0x7B14D2B70
        public void GenerateAsn1Parameters(){} // RVA: 0x7B14D2D60
        public void .cctor(){} // RVA: 0x7B14D2F60
    }

    public class CmsEnvelopedHelper : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7B14D3BC0
        public void GetAsymmetricEncryptionAlgName(){} // RVA: 0x7B14D4110
        public void CreateAsymmetricCipher(){} // RVA: 0x7B14D41D0
        public void CreateWrapper(){} // RVA: 0x7B14D42B0
        public void GetRfc3211WrapperName(){} // RVA: 0x7B14D4350
        public void GetKeySize(){} // RVA: 0x7B14D44F0
        public void BuildRecipientInformationStore(){} // RVA: 0x7B14D4670
        public void ReadRecipientInfo(){} // RVA: 0x7B14D47E0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class CmsException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B14D5680
    }

    public class CmsPbeKey : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B14D59B0
        public void Finalize(){} // RVA: 0x7B14D5D20
        public void get_Password(){} // RVA: 0x7B14D5D80
        public void get_Salt(){} // RVA: 0x7B14D5D90
        public void GetSalt(){} // RVA: 0x7B14D5E40
        public void get_IterationCount(){} // RVA: 0x7A851DB90
        public void get_Algorithm(){} // RVA: 0x7B14D5E50
        public void get_Format(){} // RVA: 0x7B14D5E90
        public void GetEncoded(){} // RVA: 0x7A7E00B20
    }

    public class CmsProcessable
    {
        // ── Methods ──
        public void Write(){} // RVA: 0x7A7E18800
        public void GetContent(){} // RVA: 0x7A7E00680
    }

    public class CmsProcessableByteArray : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADD17380
        public void get_Type(){} // RVA: 0x7A80F2570
        public void GetInputStream(){} // RVA: 0x7B14D5FF0
        public void Write(){} // RVA: 0x7B14D6050
        public void GetContent(){} // RVA: 0x7B14D60A0
    }

    public class CmsProcessableFile : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A9B6A000
        public void GetInputStream(){} // RVA: 0x7B14D6130
        public void Write(){} // RVA: 0x7B14D61E0
        public void GetContent(){} // RVA: 0x7A80F2570
    }

    public class CmsProcessableInputStream : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void GetInputStream(){} // RVA: 0x7B14D6320
        public void Write(){} // RVA: 0x7B14D6350
        public void GetContent(){} // RVA: 0x7A9AA40B0
        public void CheckSingleUsage(){} // RVA: 0x7B14D64A0
    }

    public class CmsReadable
    {
        // ── Methods ──
        public void GetInputStream(){} // RVA: 0x7A7E00680
    }

    public class CmsSecureReadable
    {
        // ── Methods ──
        public void get_Algorithm(){} // RVA: 0x7A7E00680
        public void get_CryptoObject(){} // RVA: 0x7A7E00680
        public void GetReadable(){} // RVA: 0x7A7E00B20
    }

    public class CmsSignedData : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B14D6F30
        public void get_Version(){} // RVA: 0x7B14D7180
        public void GetSignerInfos(){} // RVA: 0x7B14D71F0
        public void GetAttributeCertificates(){} // RVA: 0x7B14D76B0
        public void GetCertificates(){} // RVA: 0x7B14D77A0
        public void GetCrls(){} // RVA: 0x7B14D7890
        public void get_SignedContentTypeOid(){} // RVA: 0x7B14D7980
        public void get_SignedContentType(){} // RVA: 0x7B14D79B0
        public void get_SignedContent(){} // RVA: 0x7A80F2570
        public void get_ContentInfo(){} // RVA: 0x7A81052C0
        public void GetEncoded(){} // RVA: 0x7B14D79E0
        public void ReplaceSigners(){} // RVA: 0x7B14D7A00
        public void ReplaceCertificatesAndCrls(){} // RVA: 0x7B14D8430
        public void .cctor(){} // RVA: 0x7B14D87C0
    }

    public class CmsSignedDataGenerator : CmsSignedGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B14D89E0
        public void AddSigner(){} // RVA: 0x7B14D9940
        public void AddSignerInfoGenerator(){} // RVA: 0x7B14D9A00
        public void doAddSigner(){} // RVA: 0x7B14D9AF0
        public void Generate(){} // RVA: 0x7B14DA990
        public void GenerateCounterSigners(){} // RVA: 0x7B14DAA20
        public void .cctor(){} // RVA: 0x7B14DAAD0
    }

    public class CmsSignedDataParser : CmsContentInfoParser
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B14DBF30
        public void get_Version(){} // RVA: 0x7B14DC820
        public void get_DigestOids(){} // RVA: 0x7B14DC890
        public void GetSignerInfos(){} // RVA: 0x7B14DC8F0
        public void GetAttributeCertificates(){} // RVA: 0x7B14DD470
        public void GetCertificates(){} // RVA: 0x7B14DD560
        public void GetCrls(){} // RVA: 0x7B14DD650
        public void PopulateCertCrlSets(){} // RVA: 0x7B14DD740
        public void get_SignedContentType(){} // RVA: 0x7A8105330
        public void GetSignedContent(){} // RVA: 0x7B14DD990
        public void ReplaceSigners(){} // RVA: 0x7B14DDDD0
        public void ReplaceCertificatesAndCrls(){} // RVA: 0x7B14DE2A0
        public void GetAsn1Set(){} // RVA: 0x7B14DE570
        public void .cctor(){} // RVA: 0x7B14DE5D0
    }

    public class CmsSignedDataStreamGenerator : CmsSignedGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B14DE9A0
        public void SetBufferSize(){} // RVA: 0x7A9A18C70
        public void AddDigests(){} // RVA: 0x7B14DEC90
        public void AddSigner(){} // RVA: 0x7B14DF6E0
        public void DoAddSigner(){} // RVA: 0x7B14DF780
        public void AddSignerCallback(){} // RVA: 0x7B14DF950
        public void Open(){} // RVA: 0x7B14DFB70
        public void RegisterDigestOid(){} // RVA: 0x7B14E0500
        public void ConfigureDigest(){} // RVA: 0x7B14E05C0
        public void Generate(){} // RVA: 0x7B14E0790
        public void CalculateVersion(){} // RVA: 0x7B14E0880
        public void CheckForVersion3(){} // RVA: 0x7B14E0CE0
        public void AttachDigestsToOutputStream(){} // RVA: 0x7B14E0F30
        public void GetSafeOutputStream(){} // RVA: 0x7B14E1300
        public void GetSafeTeeOutputStream(){} // RVA: 0x7B14E1380
        public void .cctor(){} // RVA: 0x7B14E14E0
    }

    public class CmsSignedGenerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B14EA060
        public void GetBaseParameters(){} // RVA: 0x7B14EA350
        public void GetAttributeSet(){} // RVA: 0x7B14EA590
        public void AddCertificates(){} // RVA: 0x7B14EA6B0
        public void AddCrls(){} // RVA: 0x7B14EA6E0
        public void AddAttributeCertificates(){} // RVA: 0x7B14EA710
        public void AddSigners(){} // RVA: 0x7B14EAB60
        public void GetGeneratedDigests(){} // RVA: 0x7B14EAE50
        public void get_UseDerForCerts(){} // RVA: 0x7A80FD690
        public void set_UseDerForCerts(){} // RVA: 0x7A80FD6A0
        public void get_UseDerForCrls(){} // RVA: 0x7A80FD6B0
        public void set_UseDerForCrls(){} // RVA: 0x7A80FD6C0
        public void AddSignerCallback(){} // RVA: 0x7A80D7310
        public void GetSignerIdentifier(){} // RVA: 0x7B14EB000
        public void .cctor(){} // RVA: 0x7B14EB120
    }

    public class CmsSignedHelper : Object
    {
        // ── Methods ──
        public void AddEntries(){} // RVA: 0x7B14EBBE0
        public void .cctor(){} // RVA: 0x7B14EBCD0
        public void GetDigestAlgName(){} // RVA: 0x7B14ED830
        public void GetEncAlgorithmIdentifier(){} // RVA: 0x7B14ED8F0
        public void GetDigestAliases(){} // RVA: 0x7B14EDA40
        public void GetEncryptionAlgName(){} // RVA: 0x7B14EDB60
        public void GetDigestInstance(){} // RVA: 0x7B14EDC20
        public void GetSignatureInstance(){} // RVA: 0x7B14EDD20
        public void CreateAttributeStore(){} // RVA: 0x7B14EDD70
        public void CreateCertificateStore(){} // RVA: 0x7B14EE210
        public void CreateCrlStore(){} // RVA: 0x7B14EE390
        public void AddCertsFromSet(){} // RVA: 0x7B14EE510
        public void AddCrlsFromSet(){} // RVA: 0x7B14EE810
        public void FixAlgID(){} // RVA: 0x7B14EEAC0
        public void GetEncOid(){} // RVA: 0x7B14EEBB0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class CmsStreamException : IOException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADC13C20
    }

    public class CmsTypedStream : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B14EF3C0
        public void get_ContentType(){} // RVA: 0x7A80F2570
        public void get_ContentStream(){} // RVA: 0x7A80DA7B0
        public void Drain(){} // RVA: 0x7B14EF520
    }

    public class CmsUtilities : Object
    {
        // ── Methods ──
        public void get_MaximumMemory(){} // RVA: 0x7B14EF6C0
        public void ReadContentInfo(){} // RVA: 0x7B14EF800
        public void StreamToByteArray(){} // RVA: 0x7B14EF960
        public void GetCertificatesFromStore(){} // RVA: 0x7B14EFB00
        public void GetCrlsFromStore(){} // RVA: 0x7B14EFF50
        public void CreateBerSetFromList(){} // RVA: 0x7B14F03A0
        public void CreateDerSetFromList(){} // RVA: 0x7B14F0700
        public void CreateBerOctetOutputStream(){} // RVA: 0x7B14F0A40
        public void GetTbsCertificateStructure(){} // RVA: 0x7B14F0C30
        public void GetIssuerAndSerialNumber(){} // RVA: 0x7B14F0C70
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class CounterSignatureDigestCalculator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8CE4080
        public void GetDigest(){} // RVA: 0x7B14F0D30
    }

    public class DefaultAuthenticatedAttributeTableGenerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B14F0FC0
        public void CreateStandardAttributeTable(){} // RVA: 0x7B14F1160
        public void GetAttributes(){} // RVA: 0x7B14F1650
    }

    public class DefaultDigestAlgorithmIdentifierFinder : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7B14E8890
        public void find(){} // RVA: 0x7B14E9EA0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class DefaultSignatureAlgorithmIdentifierFinder : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7B14E3B10
        public void Generate(){} // RVA: 0x7B14E8110
        public void CreatePssParams(){} // RVA: 0x7B14E86F0
        public void Find(){} // RVA: 0x7B14E8840
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class DefaultSignedAttributeTableGenerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B14F17B0
        public void createStandardAttributeTable(){} // RVA: 0x7B14F1950
        public void DoCreateStandardAttributeTable(){} // RVA: 0x7B14F19F0
        public void GetAttributes(){} // RVA: 0x7B14F2080
    }

    public class EnvelopedDataHelper : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7B14F2100
        public void CreateContentCipher(){} // RVA: 0x7B14F2640
        public void GenerateEncryptionAlgID(){} // RVA: 0x7B14F26B0
        public void CreateKeyGenerator(){} // RVA: 0x7B14F2740
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class IDigestCalculator
    {
        // ── Methods ──
        public void GetDigest(){} // RVA: 0x7A7E00680
    }

    public class ISignerInfoGenerator
    {
        // ── Methods ──
        public void Generate(){} // RVA: 0x7A7E06710
    }

    public class KekRecipientInfoGenerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void set_KekIdentifier(){} // RVA: 0x7A81052D0
        public void set_KeyEncryptionKey(){} // RVA: 0x7B14F2760
        public void set_KeyEncryptionKeyOID(){} // RVA: 0x7A813E420
        public void Generate(){} // RVA: 0x7B14F2890
        public void DetermineKeyEncAlg(){} // RVA: 0x7B14F2E90
        public void .cctor(){} // RVA: 0x7B14F3460
    }

    public class KekRecipientInformation : RecipientInformation
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B14F3530
        public void GetContentStream(){} // RVA: 0x7B14F37A0
    }

    public class KeyAgreeRecipientInfoGenerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void set_KeyAgreementOID(){} // RVA: 0x7A80D8E20
        public void set_KeyEncryptionOID(){} // RVA: 0x7A813E420
        public void set_RecipientCerts(){} // RVA: 0x7B14F3A60
        public void set_SenderKeyPair(){} // RVA: 0x7A80D8E80
        public void Generate(){} // RVA: 0x7B14F3B50
        public void CreateOriginatorPublicKey(){} // RVA: 0x7B14F4F50
        public void .cctor(){} // RVA: 0x7B14F5170
    }

    public class KeyAgreeRecipientInformation : RecipientInformation
    {
        // ── Methods ──
        public void ReadRecipientInfo(){} // RVA: 0x7B14F5240
        public void .ctor(){} // RVA: 0x7B14F5680
        public void GetSenderPublicKey(){} // RVA: 0x7B14F57E0
        public void GetPublicKeyFromOriginatorPublicKey(){} // RVA: 0x7B14F5940
        public void GetPublicKeyFromOriginatorID(){} // RVA: 0x7B14F5A10
        public void CalculateAgreedWrapKey(){} // RVA: 0x7B14F5A60
        public void UnwrapSessionKey(){} // RVA: 0x7B14F5E90
        public void GetSessionKey(){} // RVA: 0x7B14F6020
        public void GetContentStream(){} // RVA: 0x7B14F64F0
    }

    public class KeyTransRecipientInfoGenerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B14F6670
        public void set_RecipientCert(){} // RVA: 0x7B14F67C0
        public void set_RecipientPublicKey(){} // RVA: 0x7B14F6940
        public void set_SubjectKeyIdentifier(){} // RVA: 0x7A81052D0
        public void Generate(){} // RVA: 0x7B14F6A60
        public void get_AlgorithmDetails(){} // RVA: 0x7ABE845E0
        public void GenerateWrappedKey(){} // RVA: 0x7B14F6DC0
        public void .cctor(){} // RVA: 0x7B14F7090
    }

    public class KeyTransRecipientInformation : RecipientInformation
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B14F7160
        public void GetExchangeEncryptionAlgorithmName(){} // RVA: 0x7B14F74A0
        public void UnwrapKey(){} // RVA: 0x7B14F7910
        public void GetContentStream(){} // RVA: 0x7B14F7C40
    }

    public class OriginatorID : X509CertStoreSelector
    {
        // ── Methods ──
        public void GetHashCode(){} // RVA: 0x7B14F7C70
        public void Equals(){} // RVA: 0x7B14F7D60
        public void .ctor(){} // RVA: 0x7A9ACA7B0
    }

    public class OriginatorInfoGenerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B14F8210
        public void Generate(){} // RVA: 0x7B14F8300
    }

    public class OriginatorInformation : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void GetCertificates(){} // RVA: 0x7B14F8420
        public void GetCrls(){} // RVA: 0x7B14F8870
        public void ToAsn1Structure(){} // RVA: 0x7A80F2570
    }

    public class PasswordRecipientInfoGenerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void set_KeyDerivationAlgorithm(){} // RVA: 0x7A80D8E20
        public void set_KeyEncryptionKey(){} // RVA: 0x7A813E420
        public void set_KeyEncryptionKeyOID(){} // RVA: 0x7A81052D0
        public void Generate(){} // RVA: 0x7B14F8CC0
        public void .cctor(){} // RVA: 0x7B14F9510
    }

    public class PasswordRecipientInformation : RecipientInformation
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B14F95E0
        public void get_KeyDerivationAlgorithm(){} // RVA: 0x7A87E1E40
        public void GetContentStream(){} // RVA: 0x7B14F9700
    }

    public class Pkcs5Scheme2PbeKey : CmsPbeKey
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B14F9C00
        public void GetEncoded(){} // RVA: 0x7B14F9C10
    }

    public class Pkcs5Scheme2Utf8PbeKey : CmsPbeKey
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B14F9C00
        public void GetEncoded(){} // RVA: 0x7B14F9DB0
    }

    public class RecipientID : X509CertStoreSelector
    {
        // ── Methods ──
        public void get_KeyIdentifier(){} // RVA: 0x7B14F9FB0
        public void set_KeyIdentifier(){} // RVA: 0x7B14FA070
        public void GetHashCode(){} // RVA: 0x7B14FA180
        public void Equals(){} // RVA: 0x7B14FA2C0
        public void .ctor(){} // RVA: 0x7A9ACA7B0
    }

    public class RecipientInfoGenerator
    {
        // ── Methods ──
        public void Generate(){} // RVA: 0x7A7E00BD0
    }

    public class RecipientInformation : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B14FA4E0
        public void GetContentAlgorithmName(){} // RVA: 0x7B14FA640
        public void get_RecipientID(){} // RVA: 0x7A80F2570
        public void get_KeyEncryptionAlgorithmID(){} // RVA: 0x7A80DA7B0
        public void get_KeyEncryptionAlgOid(){} // RVA: 0x7B14FA720
        public void get_KeyEncryptionAlgParams(){} // RVA: 0x7B14FA760
        public void GetContentFromSessionKey(){} // RVA: 0x7B14FA7B0
        public void GetContent(){} // RVA: 0x7B14FA9C0
        public void GetMac(){} // RVA: 0x7B14FAAA0
        public void GetContentStream(){} // RVA: 0x7A7E00B20
    }

    public class RecipientInformationStore : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B14FAC80
        public void get_Item(){} // RVA: 0x7B14FB1B0
        public void GetFirstRecipient(){} // RVA: 0x7B14FB2C0
        public void get_Count(){} // RVA: 0x7B14FB3D0
        public void GetRecipients(){} // RVA: 0x7B14FB4C0
    }

    public class SignerID : X509CertStoreSelector
    {
        // ── Methods ──
        public void GetHashCode(){} // RVA: 0x7B14FB640
        public void Equals(){} // RVA: 0x7B14FB730
        public void .ctor(){} // RVA: 0x7A9ACA7B0
    }

    public class SignerInfoGenerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B14FBBA0
        public void setAssociatedCertificate(){} // RVA: 0x7A80D8E20
    }

    public class SignerInfoGeneratorBuilder : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void SetDirectSignature(){} // RVA: 0x7B14FBD00
        public void WithSignedAttributeGenerator(){} // RVA: 0x7A9A186C0
        public void WithUnsignedAttributeGenerator(){} // RVA: 0x7B136AFB0
        public void Build(){} // RVA: 0x7B14FBFA0
        public void CreateGenerator(){} // RVA: 0x7B14FC0E0
    }

    public class SignerInformation : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B14FC930
        public void get_IsCounterSignature(){} // RVA: 0x7A865DD90
        public void get_ContentType(){} // RVA: 0x7A8178B90
        public void get_SignerID(){} // RVA: 0x7A80F2570
        public void get_Version(){} // RVA: 0x7B14D7180
        public void get_DigestAlgorithmID(){} // RVA: 0x7A81052C0
        public void get_DigestAlgOid(){} // RVA: 0x7B14C7F70
        public void get_DigestAlgParams(){} // RVA: 0x7B14FCDB0
        public void GetContentDigest(){} // RVA: 0x7B14FCE00
        public void get_EncryptionAlgorithmID(){} // RVA: 0x7A8105330
        public void get_EncryptionAlgOid(){} // RVA: 0x7B14FCEC0
        public void get_EncryptionAlgParams(){} // RVA: 0x7B14FCF00
        public void get_SignedAttributes(){} // RVA: 0x7B14FCF50
        public void get_UnsignedAttributes(){} // RVA: 0x7B14FD020
        public void GetSignature(){} // RVA: 0x7B14FD0F0
        public void GetCounterSignatures(){} // RVA: 0x7B14FD170
        public void GetEncodedSignedAttributes(){} // RVA: 0x7B14FD7D0
        public void DoVerify(){} // RVA: 0x7B14FD830
        public void IsNull(){} // RVA: 0x7B14FEBE0
        public void DerDecode(){} // RVA: 0x7B14FEC50
        public void VerifyDigest(){} // RVA: 0x7B14FED60
        public void Verify(){} // RVA: 0x7B14FF570
        public void ToSignerInfo(){} // RVA: 0x7A80DA7B0
        public void GetSingleValuedSignedAttribute(){} // RVA: 0x7B14FF5F0
        public void GetSigningTime(){} // RVA: 0x7B14FF8C0
        public void ReplaceUnsignedAttributes(){} // RVA: 0x7B14FF9B0
        public void AddCounterSigners(){} // RVA: 0x7B14FFBD0
        public void .cctor(){} // RVA: 0x7B1500190
    }

    public class SignerInformationStore : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B15004E0
        public void GetFirstSigner(){} // RVA: 0x7B1500A10
        public void get_Count(){} // RVA: 0x7B1500B20
        public void GetSigners(){} // RVA: 0x7B1500C10
    }

    public class SimpleAttributeTableGenerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void GetAttributes(){} // RVA: 0x7A80F2570
    }

}