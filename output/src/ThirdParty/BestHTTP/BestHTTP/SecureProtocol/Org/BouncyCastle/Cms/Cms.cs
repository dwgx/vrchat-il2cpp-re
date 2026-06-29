// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Cms
// Classes: 69
// Methods: 363

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Cms
{
    public class BaseDigestCalculator : Object
    {
        public object digest;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void GetDigest(){} // RVA: 0xA332DC0
    }

    public class CmsAttributeTableGenerationException : CmsException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA332F20
    }

    public class CmsAttributeTableGenerator
    {
        // ── Methods ──
        public void GetAttributes(){} // RVA: 0x87C540
    }

    public class CmsAuthEnvelopedData : Object
    {
        public object recipientInfoStore;
        public object contentInfo;
        public object originator;
        public object authEncAlg;
        public object authAttrs;
        public object mac;
        public object unauthAttrs;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA336DE0
    }

    public class CmsAuthEnvelopedGenerator : Object
    {
        public object Aes128Ccm;
        public object Aes192Ccm;
        public object Aes256Ccm;
        public object Aes128Gcm;
        public object Aes192Gcm;
        public object Aes256Gcm;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA3371D0
    }

    public class CmsAuthenticatedData : Object
    {
        public object recipientInfoStore;
        public object contentInfo;
        public object macAlg;
        public object authAttrs;
        public object unauthAttrs;
        public object mac;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA332FE0
        public void GetMac(){} // RVA: 0xA333340
        public void get_MacAlgorithmID(){} // RVA: 0xB700F0
        public void get_MacAlgOid(){} // RVA: 0xA3333F0
        public void GetRecipientInfos(){} // RVA: 0xB5DBF0
        public void get_ContentInfo(){} // RVA: 0xB465B0
        public void GetAuthAttrs(){} // RVA: 0xA333430
        public void GetUnauthAttrs(){} // RVA: 0xA3334A0
        public void GetEncoded(){} // RVA: 0xA333510
    }

    public class CmsAuthenticatedDataGenerator : CmsAuthenticatedGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA333540
        public void Generate(){} // RVA: 0xA3340A0
    }

    public class CmsAuthenticatedDataParser : CmsContentInfoParser
    {
        public object _recipientInfoStore;
        public object authData;
        public object macAlg;
        public object mac;
        public object authAttrs;
        public object unauthAttrs;
        public object authAttrNotRead;
        public object unauthAttrNotRead;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA3342E0
        public void get_MacAlgorithmID(){} // RVA: 0xD33E60
        public void get_MacAlgOid(){} // RVA: 0xA334D80
        public void get_MacAlgParams(){} // RVA: 0xA334DC0
        public void GetRecipientInfos(){} // RVA: 0xB700F0
        public void GetMac(){} // RVA: 0xA334E10
        public void GetAuthAttrs(){} // RVA: 0xA335090
        public void GetUnauthAttrs(){} // RVA: 0xA335480
    }

    public class CmsAuthenticatedDataStreamGenerator : CmsAuthenticatedGenerator
    {
        public object _bufferSize;
        public object _berEncodeRecipientSet;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA333540
        public void SetBufferSize(){} // RVA: 0x13233D0
        public void SetBerEncodeRecipients(){} // RVA: 0xC27390
        public void Open(){} // RVA: 0xA336690
    }

    public class CmsAuthenticatedGenerator : CmsEnvelopedGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA333540
    }

    public class CmsCompressedData : Object
    {
        public object contentInfo;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void GetContent(){} // RVA: 0xA337970
        public void get_ContentInfo(){} // RVA: 0xB5DBF0
        public void GetEncoded(){} // RVA: 0xA0FA1B0
    }

    public class CmsCompressedDataGenerator : Object
    {
        public object ZLib;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void Generate(){} // RVA: 0xA337C80
    }

    public class CmsCompressedDataParser : CmsContentInfoParser
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA338290
        public void GetContent(){} // RVA: 0xA3382A0
    }

    public class CmsCompressedDataStreamGenerator : Object
    {
        public object ZLib;
        public object _bufferSize;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void SetBufferSize(){} // RVA: 0xB460A0
        public void Open(){} // RVA: 0xA338610
    }

    public class CmsContentInfoParser : Object
    {
        public object contentInfo;
        public object data;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA338E00
        public void Close(){} // RVA: 0xA3390D0
    }

    public class CmsEnvelopedData : Object
    {
        public object recipientInfoStore;
        public object contentInfo;
        public object encAlg;
        public object unprotectedAttributes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA3391F0
        public void get_EncryptionAlgorithmID(){} // RVA: 0xB700F0
        public void get_EncryptionAlgOid(){} // RVA: 0xA3333F0
        public void GetRecipientInfos(){} // RVA: 0xB5DBF0
        public void get_ContentInfo(){} // RVA: 0xB465B0
        public void GetUnprotectedAttributes(){} // RVA: 0xA339490
        public void GetEncoded(){} // RVA: 0xA333510
    }

    public class CmsEnvelopedDataGenerator : CmsEnvelopedGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA3395A0
        public void Generate(){} // RVA: 0xA33AD30
    }

    public class CmsEnvelopedDataParser : CmsContentInfoParser
    {
        public object recipientInfoStore;
        public object envelopedData;
        public object _encAlg;
        public object _unprotectedAttributes;
        public object _attrNotRead;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA33AF70
        public void get_EncryptionAlgorithmID(){} // RVA: 0xD33E60
        public void get_EncryptionAlgOid(){} // RVA: 0xA334D80
        public void get_EncryptionAlgParams(){} // RVA: 0xA334DC0
        public void GetRecipientInfos(){} // RVA: 0xB700F0
        public void GetUnprotectedAttributes(){} // RVA: 0xA33B7F0
    }

    public class CmsEnvelopedDataStreamGenerator : CmsEnvelopedGenerator
    {
        public object _originatorInfo;
        public object _unprotectedAttributes;
        public object _bufferSize;
        public object _berEncodeRecipientSet;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA33BC80
        public void SetBufferSize(){} // RVA: 0x189D3F0
        public void SetBerEncodeRecipients(){} // RVA: 0xCB23F0
        public void get_Version(){} // RVA: 0xA33BCE0
        public void Open(){} // RVA: 0xA33CCB0
    }

    public class CmsEnvelopedGenerator : Object
    {
        public object rc2Table;
        public object DesEde3Cbc;
        public object RC2Cbc;
        public object IdeaCbc;
        public object Cast5Cbc;
        public object Aes128Cbc;
        public object Aes192Cbc;
        public object Aes256Cbc;
        public object Camellia128Cbc;
        public object Camellia192Cbc;
        public object Camellia256Cbc;
        public object SeedCbc;
        public object DesEde3Wrap;
        public object Aes128Wrap;
        public object Aes192Wrap;
        public object Aes256Wrap;
        public object Camellia128Wrap;
        public object Camellia192Wrap;
        public object Camellia256Wrap;
        public object SeedWrap;
        public object ECDHSha1Kdf;
        public object ECMqvSha1Kdf;
        public object recipientInfoGenerators;
        public object rand;
        public object unprotectedAttributeGenerator;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA33D0F0
        public void get_UnprotectedAttributeGenerator(){} // RVA: 0xB700F0
        public void set_UnprotectedAttributeGenerator(){} // RVA: 0xB70100
        public void AddKeyTransRecipient(){} // RVA: 0xA33D2D0
        public void AddKekRecipient(){} // RVA: 0xA33D550
        public void AddPasswordRecipient(){} // RVA: 0xA33D7A0
        public void AddKeyAgreementRecipient(){} // RVA: 0xA33DA30
        public void AddKeyAgreementRecipients(){} // RVA: 0xA33DBD0
        public void AddRecipientInfoGenerator(){} // RVA: 0xA33DF90
        public void GetAlgorithmIdentifier(){} // RVA: 0xA33DFF0
        public void GenerateAsn1Parameters(){} // RVA: 0xA33E1E0
        public void .cctor(){} // RVA: 0xA33E3E0
    }

    public class CmsEnvelopedHelper : Object
    {
        public object Instance;
        public object KeySizes;
        public object BaseCipherNames;

        // ── Methods ──
        public void .cctor(){} // RVA: 0xA33F040
        public void GetAsymmetricEncryptionAlgName(){} // RVA: 0xA33F580
        public void CreateAsymmetricCipher(){} // RVA: 0xA33F640
        public void CreateWrapper(){} // RVA: 0xA33F720
        public void GetRfc3211WrapperName(){} // RVA: 0xA33F7C0
        public void GetKeySize(){} // RVA: 0xA33F950
        public void BuildRecipientInformationStore(){} // RVA: 0xA33FAC0
        public void ReadRecipientInfo(){} // RVA: 0xA33FC30
        public void .ctor(){} // RVA: 0xB43310
    }

    public class CmsException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA340AD0
    }

    public class CmsPbeKey : Object
    {
        public object password;
        public object salt;
        public object iterationCount;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA340E00
        public void Finalize(){} // RVA: 0xA341170
        public void get_Password(){} // RVA: 0xA3411D0
        public void get_Salt(){} // RVA: 0xA3411E0
        public void GetSalt(){} // RVA: 0xA341290
        public void get_IterationCount(){} // RVA: 0xFEAE90
        public void get_Algorithm(){} // RVA: 0xA3412A0
        public void get_Format(){} // RVA: 0xA3412E0
        public void GetEncoded(){} // RVA: 0x87C540
    }

    public class CmsProcessable
    {
        // ── Methods ──
        public void Write(){} // RVA: 0x894320
        public void GetContent(){} // RVA: 0x87C0A0
    }

    public class CmsProcessableByteArray : Object
    {
        public object type;
        public object bytes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x69A01B0
        public void get_Type(){} // RVA: 0xB5DBF0
        public void GetInputStream(){} // RVA: 0xA341440
        public void Write(){} // RVA: 0xA3414A0
        public void GetContent(){} // RVA: 0xA3414F0
    }

    public class CmsProcessableFile : Object
    {
        public object DefaultBufSize;
        public object _file;
        public object _bufSize;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2615F10
        public void GetInputStream(){} // RVA: 0xA341580
        public void Write(){} // RVA: 0xA341630
        public void GetContent(){} // RVA: 0xB5DBF0
    }

    public class CmsProcessableInputStream : Object
    {
        public object input;
        public object used;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void GetInputStream(){} // RVA: 0xA341770
        public void Write(){} // RVA: 0xA3417A0
        public void GetContent(){} // RVA: 0x254FA90
        public void CheckSingleUsage(){} // RVA: 0xA3418F0
    }

    public class CmsReadable
    {
        // ── Methods ──
        public void GetInputStream(){} // RVA: 0x87C0A0
    }

    public class CmsSecureReadable
    {
        // ── Methods ──
        public void get_Algorithm(){} // RVA: 0x87C0A0
        public void get_CryptoObject(){} // RVA: 0x87C0A0
        public void GetReadable(){} // RVA: 0x87C540
    }

    public class CmsSignedData : Object
    {
        public object Helper;
        public object signedContent;
        public object signedData;
        public object contentInfo;
        public object signerInfoStore;
        public object attrCertStore;
        public object certificateStore;
        public object crlStore;
        public object hashes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA342380
        public void get_Version(){} // RVA: 0xA3425D0
        public void GetSignerInfos(){} // RVA: 0xA342640
        public void GetAttributeCertificates(){} // RVA: 0xA342B00
        public void GetCertificates(){} // RVA: 0xA342BF0
        public void GetCrls(){} // RVA: 0xA342CE0
        public void get_SignedContentTypeOid(){} // RVA: 0xA342DD0
        public void get_SignedContentType(){} // RVA: 0xA342E00
        public void get_SignedContent(){} // RVA: 0xB5DBF0
        public void get_ContentInfo(){} // RVA: 0xB700F0
        public void GetEncoded(){} // RVA: 0xA342E30
        public void ReplaceSigners(){} // RVA: 0xA342E50
        public void ReplaceCertificatesAndCrls(){} // RVA: 0xA343880
        public void .cctor(){} // RVA: 0xA343C10
    }

    public class CmsSignedDataGenerator : CmsSignedGenerator
    {
        public object Helper;
        public object signerInfs;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA343E30
        public void AddSigner(){} // RVA: 0xA344D90
        public void AddSignerInfoGenerator(){} // RVA: 0xA344E50
        public void doAddSigner(){} // RVA: 0xA344F40
        public void Generate(){} // RVA: 0xA345DE0
        public void GenerateCounterSigners(){} // RVA: 0xA345E70
        public void .cctor(){} // RVA: 0xA345F20
    }

    public class CmsSignedDataParser : CmsContentInfoParser
    {
        public object Helper;
        public object _signedData;
        public object _signedContentType;
        public object _signedContent;
        public object _digests;
        public object _digestOids;
        public object _signerInfoStore;
        public object _certSet;
        public object _crlSet;
        public object _isCertCrlParsed;
        public object _attributeStore;
        public object _certificateStore;
        public object _crlStore;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA347380
        public void get_Version(){} // RVA: 0xA347C70
        public void get_DigestOids(){} // RVA: 0xA347CE0
        public void GetSignerInfos(){} // RVA: 0xA347D40
        public void GetAttributeCertificates(){} // RVA: 0xA3488C0
        public void GetCertificates(){} // RVA: 0xA3489B0
        public void GetCrls(){} // RVA: 0xA348AA0
        public void PopulateCertCrlSets(){} // RVA: 0xA348B90
        public void get_SignedContentType(){} // RVA: 0xB70160
        public void GetSignedContent(){} // RVA: 0xA348DE0
        public void ReplaceSigners(){} // RVA: 0xA349220
        public void ReplaceCertificatesAndCrls(){} // RVA: 0xA3496F0
        public void GetAsn1Set(){} // RVA: 0xA3499C0
        public void .cctor(){} // RVA: 0xA349A20
    }

    public class CmsSignedDataStreamGenerator : CmsSignedGenerator
    {
        public object Helper;
        public object _signerInfs;
        public object _messageDigestOids;
        public object _messageDigests;
        public object _messageHashes;
        public object _messageDigestsLocked;
        public object _bufferSize;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA349DF0
        public void SetBufferSize(){} // RVA: 0xD346A0
        public void AddDigests(){} // RVA: 0xA34A0E0
        public void AddSigner(){} // RVA: 0xA34AB20
        public void DoAddSigner(){} // RVA: 0xA34ABC0
        public void AddSignerCallback(){} // RVA: 0xA34AD90
        public void Open(){} // RVA: 0xA34AFB0
        public void RegisterDigestOid(){} // RVA: 0xA34B930
        public void ConfigureDigest(){} // RVA: 0xA34B9F0
        public void Generate(){} // RVA: 0xA34BBC0
        public void CalculateVersion(){} // RVA: 0xA34BCB0
        public void CheckForVersion3(){} // RVA: 0xA34C110
        public void AttachDigestsToOutputStream(){} // RVA: 0xA34C360
        public void GetSafeOutputStream(){} // RVA: 0xA34C730
        public void GetSafeTeeOutputStream(){} // RVA: 0xA34C7B0
        public void .cctor(){} // RVA: 0xA34C910
    }

    public class CmsSignedGenerator : Object
    {
        public object Data;
        public object DigestSha1;
        public object DigestSha224;
        public object DigestSha256;
        public object DigestSha384;
        public object DigestSha512;
        public object DigestMD5;
        public object DigestGost3411;
        public object DigestRipeMD128;
        public object DigestRipeMD160;
        public object DigestRipeMD256;
        public object EncryptionRsa;
        public object EncryptionDsa;
        public object EncryptionECDsa;
        public object EncryptionRsaPss;
        public object EncryptionGost3410;
        public object EncryptionECGost3410;
        public object _certs;
        public object _crls;
        public object _signers;
        public object _digests;
        public object _useDerForCerts;
        public object _useDerForCrls;
        public object rand;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA355490
        public void GetBaseParameters(){} // RVA: 0xA355780
        public void GetAttributeSet(){} // RVA: 0xA3559C0
        public void AddCertificates(){} // RVA: 0xA355AE0
        public void AddCrls(){} // RVA: 0xA355B10
        public void AddAttributeCertificates(){} // RVA: 0xA355B40
        public void AddSigners(){} // RVA: 0xA355F90
        public void GetGeneratedDigests(){} // RVA: 0xA356280
        public void get_UseDerForCerts(){} // RVA: 0xB68DF0
        public void set_UseDerForCerts(){} // RVA: 0xB68E00
        public void get_UseDerForCrls(){} // RVA: 0xB68E10
        public void set_UseDerForCrls(){} // RVA: 0xB68E20
        public void AddSignerCallback(){} // RVA: 0xB43310
        public void GetSignerIdentifier(){} // RVA: 0xA356430
        public void .cctor(){} // RVA: 0xA356550
    }

    public class CmsSignedHelper : Object
    {
        public object Instance;
        public object EncryptionECDsaWithSha1;
        public object EncryptionECDsaWithSha224;
        public object EncryptionECDsaWithSha256;
        public object EncryptionECDsaWithSha384;
        public object EncryptionECDsaWithSha512;
        public object encryptionAlgs;
        public object digestAlgs;
        public object digestAliases;
        public object noParams;
        public object ecAlgorithms;

        // ── Methods ──
        public void AddEntries(){} // RVA: 0xA357010
        public void .cctor(){} // RVA: 0xA357100
        public void GetDigestAlgName(){} // RVA: 0xA358C60
        public void GetEncAlgorithmIdentifier(){} // RVA: 0xA358D10
        public void GetDigestAliases(){} // RVA: 0xA358E60
        public void GetEncryptionAlgName(){} // RVA: 0xA358F80
        public void GetDigestInstance(){} // RVA: 0xA359030
        public void GetSignatureInstance(){} // RVA: 0xA359130
        public void CreateAttributeStore(){} // RVA: 0xA359180
        public void CreateCertificateStore(){} // RVA: 0xA359620
        public void CreateCrlStore(){} // RVA: 0xA3597A0
        public void AddCertsFromSet(){} // RVA: 0xA359920
        public void AddCrlsFromSet(){} // RVA: 0xA359C20
        public void FixAlgID(){} // RVA: 0xA359ED0
        public void GetEncOid(){} // RVA: 0xA359FC0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class CmsStreamException : IOException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x689ED90
    }

    public class CmsTypedStream : Object
    {
        public object BufferSize;
        public object _oid;
        public object _in;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA35A7C0
        public void get_ContentType(){} // RVA: 0xB5DBF0
        public void get_ContentStream(){} // RVA: 0xB465B0
        public void Drain(){} // RVA: 0xA35A920
    }

    public class CmsUtilities : Object
    {
        // ── Methods ──
        public void get_MaximumMemory(){} // RVA: 0xA35AAC0
        public void ReadContentInfo(){} // RVA: 0xA35AC00
        public void StreamToByteArray(){} // RVA: 0xA35AD60
        public void GetCertificatesFromStore(){} // RVA: 0xA35AF00
        public void GetCrlsFromStore(){} // RVA: 0xA35B350
        public void CreateBerSetFromList(){} // RVA: 0xA35B7A0
        public void CreateDerSetFromList(){} // RVA: 0xA35BB00
        public void CreateBerOctetOutputStream(){} // RVA: 0xA35BE40
        public void GetTbsCertificateStructure(){} // RVA: 0xA35C030
        public void GetIssuerAndSerialNumber(){} // RVA: 0xA35C070
        public void .ctor(){} // RVA: 0xB43310
    }

    public class CounterSignatureDigestCalculator : Object
    {
        public object alg;
        public object data;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x17C92C0
        public void GetDigest(){} // RVA: 0xA35C130
    }

    public class DefaultAuthenticatedAttributeTableGenerator : Object
    {
        public object table;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA35C3C0
        public void CreateStandardAttributeTable(){} // RVA: 0xA35C560
        public void GetAttributes(){} // RVA: 0xA35CA50
    }

    public class DefaultDigestAlgorithmIdentifierFinder : Object
    {
        public object digestOids;
        public object digestNameToOids;

        // ── Methods ──
        public void .cctor(){} // RVA: 0xA353CC0
        public void find(){} // RVA: 0xA3552D0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class DefaultSignatureAlgorithmIdentifierFinder : Object
    {
        public object algorithms;
        public object noParams;
        public object _params;
        public object pkcs15RsaEncryption;
        public object digestOids;
        public object digestBuilders;
        public object ENCRYPTION_RSA;
        public object ENCRYPTION_DSA;
        public object ENCRYPTION_ECDSA;
        public object ENCRYPTION_RSA_PSS;
        public object ENCRYPTION_GOST3410;
        public object ENCRYPTION_ECGOST3410;
        public object ENCRYPTION_ECGOST3410_2012_256;
        public object ENCRYPTION_ECGOST3410_2012_512;

        // ── Methods ──
        public void .cctor(){} // RVA: 0xA34EF40
        public void Generate(){} // RVA: 0xA353540
        public void CreatePssParams(){} // RVA: 0xA353B20
        public void Find(){} // RVA: 0xA353C70
        public void .ctor(){} // RVA: 0xB43310
    }

    public class DefaultSignedAttributeTableGenerator : Object
    {
        public object table;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA35CBB0
        public void createStandardAttributeTable(){} // RVA: 0xA35CD50
        public void DoCreateStandardAttributeTable(){} // RVA: 0xA35CDF0
        public void GetAttributes(){} // RVA: 0xA35D480
    }

    public class EnvelopedDataHelper : Object
    {
        public object BaseCipherNames;
        public object MacAlgNames;

        // ── Methods ──
        public void .cctor(){} // RVA: 0xA35D500
        public void CreateContentCipher(){} // RVA: 0xA35DA40
        public void GenerateEncryptionAlgID(){} // RVA: 0xA35DAB0
        public void CreateKeyGenerator(){} // RVA: 0xA35DB40
        public void .ctor(){} // RVA: 0xB43310
    }

    public class IDigestCalculator
    {
        // ── Methods ──
        public void GetDigest(){} // RVA: 0x87C0A0
    }

    public class ISignerInfoGenerator
    {
        // ── Methods ──
        public void Generate(){} // RVA: 0x882090
    }

    public class KekRecipientInfoGenerator : Object
    {
        public object Helper;
        public object keyEncryptionKey;
        public object keyEncryptionKeyOID;
        public object kekIdentifier;
        public object keyEncryptionAlgorithm;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void set_KekIdentifier(){} // RVA: 0xB70100
        public void set_KeyEncryptionKey(){} // RVA: 0xA35DB60
        public void set_KeyEncryptionKeyOID(){} // RVA: 0xBA9BA0
        public void Generate(){} // RVA: 0xA35DC90
        public void DetermineKeyEncAlg(){} // RVA: 0xA35E290
        public void .cctor(){} // RVA: 0xA35E860
    }

    public class KekRecipientInformation : RecipientInformation
    {
        public object info;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA35E930
        public void GetContentStream(){} // RVA: 0xA35EBA0
    }

    public class KeyAgreeRecipientInfoGenerator : Object
    {
        public object Helper;
        public object keyAgreementOID;
        public object keyEncryptionOID;
        public object recipientCerts;
        public object senderKeyPair;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void set_KeyAgreementOID(){} // RVA: 0xB44D60
        public void set_KeyEncryptionOID(){} // RVA: 0xBA9BA0
        public void set_RecipientCerts(){} // RVA: 0xA35EE60
        public void set_SenderKeyPair(){} // RVA: 0xB44DC0
        public void Generate(){} // RVA: 0xA35EF50
        public void CreateOriginatorPublicKey(){} // RVA: 0xA360350
        public void .cctor(){} // RVA: 0xA360570
    }

    public class KeyAgreeRecipientInformation : RecipientInformation
    {
        public object info;
        public object encryptedKey;

        // ── Methods ──
        public void ReadRecipientInfo(){} // RVA: 0xA360640
        public void .ctor(){} // RVA: 0xA360A80
        public void GetSenderPublicKey(){} // RVA: 0xA360BE0
        public void GetPublicKeyFromOriginatorPublicKey(){} // RVA: 0xA360D40
        public void GetPublicKeyFromOriginatorID(){} // RVA: 0xA360E10
        public void CalculateAgreedWrapKey(){} // RVA: 0xA360E60
        public void UnwrapSessionKey(){} // RVA: 0xA361290
        public void GetSessionKey(){} // RVA: 0xA361420
        public void GetContentStream(){} // RVA: 0xA3618F0
    }

    public class KeyTransRecipientInfoGenerator : Object
    {
        public object Helper;
        public object recipientTbsCert;
        public object recipientPublicKey;
        public object subjectKeyIdentifier;
        public object info;
        public object issuerAndSerialNumber;
        public object random;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA361A70
        public void set_RecipientCert(){} // RVA: 0xA361BC0
        public void set_RecipientPublicKey(){} // RVA: 0xA361D40
        public void set_SubjectKeyIdentifier(){} // RVA: 0xB70100
        public void Generate(){} // RVA: 0xA361E60
        public void get_AlgorithmDetails(){} // RVA: 0x4B531E0
        public void GenerateWrappedKey(){} // RVA: 0xA3621C0
        public void .cctor(){} // RVA: 0xA362490
    }

    public class KeyTransRecipientInformation : RecipientInformation
    {
        public object info;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA362560
        public void GetExchangeEncryptionAlgorithmName(){} // RVA: 0xA3628A0
        public void UnwrapKey(){} // RVA: 0xA362D00
        public void GetContentStream(){} // RVA: 0xA363030
    }

    public class OriginatorID : X509CertStoreSelector
    {
        // ── Methods ──
        public void GetHashCode(){} // RVA: 0xA363060
        public void Equals(){} // RVA: 0xA363150
        public void .ctor(){} // RVA: 0x2576860
    }

    public class OriginatorInfoGenerator : Object
    {
        public object origCerts;
        public object origCrls;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA363600
        public void Generate(){} // RVA: 0xA3636F0
    }

    public class OriginatorInformation : Object
    {
        public object originatorInfo;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void GetCertificates(){} // RVA: 0xA363810
        public void GetCrls(){} // RVA: 0xA363C60
        public void ToAsn1Structure(){} // RVA: 0xB5DBF0
    }

    public class PasswordRecipientInfoGenerator : Object
    {
        public object Helper;
        public object keyDerivationAlgorithm;
        public object keyEncryptionKey;
        public object keyEncryptionKeyOID;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void set_KeyDerivationAlgorithm(){} // RVA: 0xB44D60
        public void set_KeyEncryptionKey(){} // RVA: 0xBA9BA0
        public void set_KeyEncryptionKeyOID(){} // RVA: 0xB70100
        public void Generate(){} // RVA: 0xA3640B0
        public void .cctor(){} // RVA: 0xA364900
    }

    public class PasswordRecipientInformation : RecipientInformation
    {
        public object info;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA3649D0
        public void get_KeyDerivationAlgorithm(){} // RVA: 0x12EEB90
        public void GetContentStream(){} // RVA: 0xA364AF0
    }

    public class Pkcs5Scheme2PbeKey : CmsPbeKey
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA364FF0
        public void GetEncoded(){} // RVA: 0xA365000
    }

    public class Pkcs5Scheme2Utf8PbeKey : CmsPbeKey
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA364FF0
        public void GetEncoded(){} // RVA: 0xA3651A0
    }

    public class RecipientID : X509CertStoreSelector
    {
        public object keyIdentifier;

        // ── Methods ──
        public void get_KeyIdentifier(){} // RVA: 0xA3653A0
        public void set_KeyIdentifier(){} // RVA: 0xA365460
        public void GetHashCode(){} // RVA: 0xA365570
        public void Equals(){} // RVA: 0xA3656B0
        public void .ctor(){} // RVA: 0x2576860
    }

    public class RecipientInfoGenerator
    {
        // ── Methods ──
        public void Generate(){} // RVA: 0x87C5F0
    }

    public class RecipientInformation : Object
    {
        public object rid;
        public object keyEncAlg;
        public object secureReadable;
        public object resultMac;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA3658D0
        public void GetContentAlgorithmName(){} // RVA: 0xA365A30
        public void get_RecipientID(){} // RVA: 0xB5DBF0
        public void get_KeyEncryptionAlgorithmID(){} // RVA: 0xB465B0
        public void get_KeyEncryptionAlgOid(){} // RVA: 0xA365B10
        public void get_KeyEncryptionAlgParams(){} // RVA: 0xA365B50
        public void GetContentFromSessionKey(){} // RVA: 0xA365BA0
        public void GetContent(){} // RVA: 0xA365DB0
        public void GetMac(){} // RVA: 0xA365E90
        public void GetContentStream(){} // RVA: 0x87C540
    }

    public class RecipientInformationStore : Object
    {
        public object all;
        public object table;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA366070
        public void get_Item(){} // RVA: 0xA3665A0
        public void GetFirstRecipient(){} // RVA: 0xA3666B0
        public void get_Count(){} // RVA: 0xA3667C0
        public void GetRecipients(){} // RVA: 0xA3668B0
    }

    public class SignerID : X509CertStoreSelector
    {
        // ── Methods ──
        public void GetHashCode(){} // RVA: 0xA366A30
        public void Equals(){} // RVA: 0xA366B20
        public void .ctor(){} // RVA: 0x2576860
    }

    public class SignerInfoGenerator : Object
    {
        public object certificate;
        public object contentSigner;
        public object sigId;
        public object signedGen;
        public object unsignedGen;
        public object isDirectSignature;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA366F90
        public void setAssociatedCertificate(){} // RVA: 0xB44D60
    }

    public class SignerInfoGeneratorBuilder : Object
    {
        public object directSignature;
        public object signedGen;
        public object unsignedGen;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void SetDirectSignature(){} // RVA: 0xA3670F0
        public void WithSignedAttributeGenerator(){} // RVA: 0xD33F30
        public void WithUnsignedAttributeGenerator(){} // RVA: 0xA1D6890
        public void Build(){} // RVA: 0xA367390
        public void CreateGenerator(){} // RVA: 0xA3674D0
    }

    public class SignerInformation : Object
    {
        public object Helper;
        public object sid;
        public object info;
        public object digestAlgorithm;
        public object encryptionAlgorithm;
        public object signedAttributeSet;
        public object unsignedAttributeSet;
        public object content;
        public object signature;
        public object contentType;
        public object digestCalculator;
        public object resultDigest;
        public object signedAttributeTable;
        public object unsignedAttributeTable;
        public object isCounterSignature;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA367D20
        public void get_IsCounterSignature(){} // RVA: 0x1165710
        public void get_ContentType(){} // RVA: 0xBE58B0
        public void get_SignerID(){} // RVA: 0xB5DBF0
        public void get_Version(){} // RVA: 0xA3425D0
        public void get_DigestAlgorithmID(){} // RVA: 0xB700F0
        public void get_DigestAlgOid(){} // RVA: 0xA3333F0
        public void get_DigestAlgParams(){} // RVA: 0xA3681A0
        public void GetContentDigest(){} // RVA: 0xA3681F0
        public void get_EncryptionAlgorithmID(){} // RVA: 0xB70160
        public void get_EncryptionAlgOid(){} // RVA: 0xA3682B0
        public void get_EncryptionAlgParams(){} // RVA: 0xA3682F0
        public void get_SignedAttributes(){} // RVA: 0xA368340
        public void get_UnsignedAttributes(){} // RVA: 0xA368410
        public void GetSignature(){} // RVA: 0xA3684E0
        public void GetCounterSignatures(){} // RVA: 0xA368560
        public void GetEncodedSignedAttributes(){} // RVA: 0xA368BC0
        public void DoVerify(){} // RVA: 0xA368C20
        public void IsNull(){} // RVA: 0xA369FD0
        public void DerDecode(){} // RVA: 0xA36A040
        public void VerifyDigest(){} // RVA: 0xA36A150
        public void Verify(){} // RVA: 0xA36A960
        public void ToSignerInfo(){} // RVA: 0xB465B0
        public void GetSingleValuedSignedAttribute(){} // RVA: 0xA36A9E0
        public void GetSigningTime(){} // RVA: 0xA36ACB0
        public void ReplaceUnsignedAttributes(){} // RVA: 0xA36ADA0
        public void AddCounterSigners(){} // RVA: 0xA36AFC0
        public void .cctor(){} // RVA: 0xA36B580
    }

    public class SignerInformationStore : Object
    {
        public object all;
        public object table;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA36B8D0
        public void GetFirstSigner(){} // RVA: 0xA36BE00
        public void get_Count(){} // RVA: 0xA36BF10
        public void GetSigners(){} // RVA: 0xA36C000
    }

    public class SimpleAttributeTableGenerator : Object
    {
        public object attributes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void GetAttributes(){} // RVA: 0xB5DBF0
    }

}