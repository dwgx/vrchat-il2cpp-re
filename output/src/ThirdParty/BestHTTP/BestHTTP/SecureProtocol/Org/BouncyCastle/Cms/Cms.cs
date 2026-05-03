// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Cms
// Classes: 69
// Methods: 475

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Cms
{
    public class BaseDigestCalculator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void GetDigest(){} // RVA: 0x7FFE8A0F0A10
    }

    public class CmsAttributeTableGenerationException : CmsException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A0F0B70 | overloaded x3
    }

    public class CmsAttributeTableGenerator
    {
        // ── Methods ──
        public void GetAttributes(){} // RVA: 0x7FFE80E2E390
    }

    public class CmsAuthEnvelopedData : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A0F4A40 | overloaded x3
    }

    public class CmsAuthEnvelopedGenerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE8A0F4E20
    }

    public class CmsAuthenticatedData : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Cms.RecipientInformationStore recipientInfoStore; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.ContentInfo contentInfo; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier macAlg; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A0F0C30 | overloaded x3
        public void GetMac(){} // RVA: 0x7FFE8A0F0F90
        public void get_MacAlgorithmID(){} // RVA: 0x7FFE811290C0
        public void get_MacAlgOid(){} // RVA: 0x7FFE8A0F1040
        public void GetRecipientInfos(){} // RVA: 0x7FFE81116380
        public void get_ContentInfo(){} // RVA: 0x7FFE810FE7C0
        public void GetAuthAttrs(){} // RVA: 0x7FFE8A0F1080
        public void GetUnauthAttrs(){} // RVA: 0x7FFE8A0F10F0
        public void GetEncoded(){} // RVA: 0x7FFE8A0F1160
    }

    public class CmsAuthenticatedDataGenerator : CmsAuthenticatedGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A0F1190 | overloaded x2
        public void Generate(){} // RVA: 0x7FFE8A0F1D00 | overloaded x2
    }

    public class CmsAuthenticatedDataParser : CmsContentInfoParser
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Cms.RecipientInformationStore _recipientInfoStore; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.AuthenticatedDataParser authData; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier macAlg; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A0F1F40 | overloaded x2
        public void get_MacAlgorithmID(){} // RVA: 0x7FFE8144E200
        public void get_MacAlgOid(){} // RVA: 0x7FFE8A0F29E0
        public void get_MacAlgParams(){} // RVA: 0x7FFE8A0F2A20
        public void GetRecipientInfos(){} // RVA: 0x7FFE811290C0
        public void GetMac(){} // RVA: 0x7FFE8A0F2A70
        public void GetAuthAttrs(){} // RVA: 0x7FFE8A0F2CF0
        public void GetUnauthAttrs(){} // RVA: 0x7FFE8A0F30E0
    }

    public class CmsAuthenticatedDataStreamGenerator : CmsAuthenticatedGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A0F1190 | overloaded x2
        public void SetBufferSize(){} // RVA: 0x7FFE817E4800
        public void SetBerEncodeRecipients(){} // RVA: 0x7FFE811DA240
        public void Open(){} // RVA: 0x7FFE8A0F42F0 | overloaded x4
    }

    public class CmsAuthenticatedGenerator : CmsEnvelopedGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A0F1190 | overloaded x2
    }

    public class CmsCompressedData : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.ContentInfo contentInfo; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x3
        public void GetContent(){} // RVA: 0x7FFE8A0F55B0 | overloaded x2
        public void get_ContentInfo(){} // RVA: 0x7FFE81116380
        public void GetEncoded(){} // RVA: 0x7FFE89EBCFE0
    }

    public class CmsCompressedDataGenerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Generate(){} // RVA: 0x7FFE8A0F58C0
    }

    public class CmsCompressedDataParser : CmsContentInfoParser
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A0F5ED0 | overloaded x2
        public void GetContent(){} // RVA: 0x7FFE8A0F5EE0
    }

    public class CmsCompressedDataStreamGenerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void SetBufferSize(){} // RVA: 0x7FFE810FE0C0
        public void Open(){} // RVA: 0x7FFE8A0F6250 | overloaded x2
    }

    public class CmsContentInfoParser : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A0F6A30
        public void Close(){} // RVA: 0x7FFE8A0F6D00
    }

    public class CmsEnvelopedData : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Cms.RecipientInformationStore recipientInfoStore; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.ContentInfo contentInfo; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier encAlg; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A0F6E20 | overloaded x3
        public void get_EncryptionAlgorithmID(){} // RVA: 0x7FFE811290C0
        public void get_EncryptionAlgOid(){} // RVA: 0x7FFE8A0F1040
        public void GetRecipientInfos(){} // RVA: 0x7FFE81116380
        public void get_ContentInfo(){} // RVA: 0x7FFE810FE7C0
        public void GetUnprotectedAttributes(){} // RVA: 0x7FFE8A0F70C0
        public void GetEncoded(){} // RVA: 0x7FFE8A0F1160
    }

    public class CmsEnvelopedDataGenerator : CmsEnvelopedGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A0F71D0 | overloaded x2
        public void Generate(){} // RVA: 0x7FFE8A0F89B0 | overloaded x4
    }

    public class CmsEnvelopedDataParser : CmsContentInfoParser
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Cms.RecipientInformationStore recipientInfoStore; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.EnvelopedDataParser envelopedData; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier _encAlg; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A0F8BF0 | overloaded x2
        public void get_EncryptionAlgorithmID(){} // RVA: 0x7FFE8144E200
        public void get_EncryptionAlgOid(){} // RVA: 0x7FFE8A0F29E0
        public void get_EncryptionAlgParams(){} // RVA: 0x7FFE8A0F2A20
        public void GetRecipientInfos(){} // RVA: 0x7FFE811290C0
        public void GetUnprotectedAttributes(){} // RVA: 0x7FFE8A0F9470
    }

    public class CmsEnvelopedDataStreamGenerator : CmsEnvelopedGenerator
    {
        public object _originatorInfo; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A0F9900 | overloaded x2
        public void SetBufferSize(){} // RVA: 0x7FFE81D46A00
        public void SetBerEncodeRecipients(){} // RVA: 0x7FFE812604F0
        public void get_Version(){} // RVA: 0x7FFE8A0F9960
        public void Open(){} // RVA: 0x7FFE8A0FA950 | overloaded x4
    }

    public class CmsEnvelopedGenerator : Object
    {
        public short[] rc2Table;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A0FAD90 | overloaded x2
        public void get_UnprotectedAttributeGenerator(){} // RVA: 0x7FFE811290C0
        public void set_UnprotectedAttributeGenerator(){} // RVA: 0x7FFE811290D0
        public void AddKeyTransRecipient(){} // RVA: 0x7FFE8A0FAF70 | overloaded x2
        public void AddKekRecipient(){} // RVA: 0x7FFE8A0FB1F0 | overloaded x2
        public void AddPasswordRecipient(){} // RVA: 0x7FFE8A0FB440
        public void AddKeyAgreementRecipient(){} // RVA: 0x7FFE8A0FB6D0
        public void AddKeyAgreementRecipients(){} // RVA: 0x7FFE8A0FB870
        public void AddRecipientInfoGenerator(){} // RVA: 0x7FFE8A0FBC30
        public void GetAlgorithmIdentifier(){} // RVA: 0x7FFE8A0FBC90
        public void GenerateAsn1Parameters(){} // RVA: 0x7FFE8A0FBE80
        public void .cctor(){} // RVA: 0x7FFE8A0FC080
    }

    public class CmsEnvelopedHelper : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE8A0FCCE0
        public void GetAsymmetricEncryptionAlgName(){} // RVA: 0x7FFE8A0FD230
        public void CreateAsymmetricCipher(){} // RVA: 0x7FFE8A0FD2F0
        public void CreateWrapper(){} // RVA: 0x7FFE8A0FD3D0
        public void GetRfc3211WrapperName(){} // RVA: 0x7FFE8A0FD470
        public void GetKeySize(){} // RVA: 0x7FFE8A0FD610
        public void BuildRecipientInformationStore(){} // RVA: 0x7FFE8A0FD790
        public void ReadRecipientInfo(){} // RVA: 0x7FFE8A0FD900
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class CmsException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A0FE8F0 | overloaded x3
    }

    public class CmsPbeKey : Object
    {
        public char[] password; // 0x10
        public byte[] salt; // 0x18
        public int iterationCount; // 0x20
        public object field_3; // 0x633
        public object field_4; // 0x634

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A0FEC10 | overloaded x4
        public void Finalize(){} // RVA: 0x7FFE8A0FEF70
        public void get_Password(){} // RVA: 0x7FFE8A0FEFD0
        public void get_Salt(){} // RVA: 0x7FFE8A0FEFE0
        public void GetSalt(){} // RVA: 0x7FFE8A0FF090
        public void get_IterationCount(){} // RVA: 0x7FFE8151D690
        public void get_Algorithm(){} // RVA: 0x7FFE8A0FF0A0
        public void get_Format(){} // RVA: 0x7FFE8A0FF0E0
        public void GetEncoded(){} // RVA: 0x7FFE80E2E390 | overloaded x2
    }

    public class CmsProcessable
    {
        // ── Methods ──
        public void Write(){} // RVA: 0x7FFE80E460A0
        public void GetContent(){} // RVA: 0x7FFE80E2E2E0
    }

    public class CmsProcessableByteArray : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier type; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86A69440 | overloaded x2
        public void get_Type(){} // RVA: 0x7FFE81116380
        public void GetInputStream(){} // RVA: 0x7FFE8A0FF240
        public void Write(){} // RVA: 0x7FFE8A0FF2A0
        public void GetContent(){} // RVA: 0x7FFE8A0FF2F0
    }

    public class CmsProcessableFile : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82AF3A20 | overloaded x2
        public void GetInputStream(){} // RVA: 0x7FFE8A0FF380
        public void Write(){} // RVA: 0x7FFE8A0FF430
        public void GetContent(){} // RVA: 0x7FFE81116380
    }

    public class CmsProcessableInputStream : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void GetInputStream(){} // RVA: 0x7FFE8A0FF570
        public void Write(){} // RVA: 0x7FFE8A0FF5A0
        public void GetContent(){} // RVA: 0x7FFE82A336A0
        public void CheckSingleUsage(){} // RVA: 0x7FFE8A0FF6F0
    }

    public class CmsReadable
    {
        // ── Methods ──
        public void GetInputStream(){} // RVA: 0x7FFE80E2E2E0
    }

    public class CmsSecureReadable
    {
        // ── Methods ──
        public void get_Algorithm(){} // RVA: 0x7FFE80E2E2E0
        public void get_CryptoObject(){} // RVA: 0x7FFE80E2E2E0
        public void GetReadable(){} // RVA: 0x7FFE80E2E390
    }

    public class CmsSignedData : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Cms.CmsSignedHelper Helper;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Cms.CmsProcessable signedContent; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.SignedData signedData; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.ContentInfo contentInfo; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Cms.SignerInformationStore signerInfoStore; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A1001B0 | overloaded x9
        public void get_Version(){} // RVA: 0x7FFE8A100400
        public void GetSignerInfos(){} // RVA: 0x7FFE8A100470
        public void GetAttributeCertificates(){} // RVA: 0x7FFE8A100930
        public void GetCertificates(){} // RVA: 0x7FFE8A100A20
        public void GetCrls(){} // RVA: 0x7FFE8A100B10
        public void get_SignedContentTypeOid(){} // RVA: 0x7FFE8A100C00
        public void get_SignedContentType(){} // RVA: 0x7FFE8A100C30
        public void get_SignedContent(){} // RVA: 0x7FFE81116380
        public void get_ContentInfo(){} // RVA: 0x7FFE811290C0
        public void GetEncoded(){} // RVA: 0x7FFE8A100C60
        public void ReplaceSigners(){} // RVA: 0x7FFE8A100C80
        public void ReplaceCertificatesAndCrls(){} // RVA: 0x7FFE8A101730
        public void .cctor(){} // RVA: 0x7FFE8A101AA0
    }

    public class CmsSignedDataGenerator : CmsSignedGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A101CC0 | overloaded x2
        public void AddSigner(){} // RVA: 0x7FFE8A102C20 | overloaded x12
        public void AddSignerInfoGenerator(){} // RVA: 0x7FFE8A102CE0
        public void doAddSigner(){} // RVA: 0x7FFE8A102DD0
        public void Generate(){} // RVA: 0x7FFE8A103CA0 | overloaded x3
        public void GenerateCounterSigners(){} // RVA: 0x7FFE8A103D30
        public void .cctor(){} // RVA: 0x7FFE8A103DE0
    }

    public class CmsSignedDataParser : CmsContentInfoParser
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Cms.CmsSignedHelper Helper;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.SignedDataParser _signedData; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier _signedContentType; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A105230 | overloaded x4
        public void get_Version(){} // RVA: 0x7FFE8A105B20
        public void get_DigestOids(){} // RVA: 0x7FFE8A105B90
        public void GetSignerInfos(){} // RVA: 0x7FFE8A105BF0
        public void GetAttributeCertificates(){} // RVA: 0x7FFE8A106770
        public void GetCertificates(){} // RVA: 0x7FFE8A106860
        public void GetCrls(){} // RVA: 0x7FFE8A106950
        public void PopulateCertCrlSets(){} // RVA: 0x7FFE8A106A40
        public void get_SignedContentType(){} // RVA: 0x7FFE81129130
        public void GetSignedContent(){} // RVA: 0x7FFE8A106C90
        public void ReplaceSigners(){} // RVA: 0x7FFE8A1070D0
        public void ReplaceCertificatesAndCrls(){} // RVA: 0x7FFE8A1075A0
        public void GetAsn1Set(){} // RVA: 0x7FFE8A107870
        public void .cctor(){} // RVA: 0x7FFE8A1078D0
    }

    public class CmsSignedDataStreamGenerator : CmsSignedGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A107CA0 | overloaded x2
        public void SetBufferSize(){} // RVA: 0x7FFE829DF320
        public void AddDigests(){} // RVA: 0x7FFE8A107F90 | overloaded x2
        public void AddSigner(){} // RVA: 0x7FFE8A108A00 | overloaded x11
        public void DoAddSigner(){} // RVA: 0x7FFE8A108AA0
        public void AddSignerCallback(){} // RVA: 0x7FFE8A108C70
        public void Open(){} // RVA: 0x7FFE8A108E90 | overloaded x5
        public void RegisterDigestOid(){} // RVA: 0x7FFE8A109830
        public void ConfigureDigest(){} // RVA: 0x7FFE8A109900
        public void Generate(){} // RVA: 0x7FFE8A109AD0
        public void CalculateVersion(){} // RVA: 0x7FFE8A109BC0
        public void CheckForVersion3(){} // RVA: 0x7FFE8A10A050
        public void AttachDigestsToOutputStream(){} // RVA: 0x7FFE8A10A2B0
        public void GetSafeOutputStream(){} // RVA: 0x7FFE8A10A690
        public void GetSafeTeeOutputStream(){} // RVA: 0x7FFE8A10A710
        public void .cctor(){} // RVA: 0x7FFE8A10A870
    }

    public class CmsSignedGenerator : Object
    {
        public string Data;
        public string DigestSha1; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A113400 | overloaded x2
        public void GetBaseParameters(){} // RVA: 0x7FFE8A1136F0
        public void GetAttributeSet(){} // RVA: 0x7FFE8A113930
        public void AddCertificates(){} // RVA: 0x7FFE8A113A50
        public void AddCrls(){} // RVA: 0x7FFE8A113A80
        public void AddAttributeCertificates(){} // RVA: 0x7FFE8A113AB0
        public void AddSigners(){} // RVA: 0x7FFE8A113F00
        public void GetGeneratedDigests(){} // RVA: 0x7FFE8A114200
        public void get_UseDerForCerts(){} // RVA: 0x7FFE81121450
        public void set_UseDerForCerts(){} // RVA: 0x7FFE81121460
        public void get_UseDerForCrls(){} // RVA: 0x7FFE81121470
        public void set_UseDerForCrls(){} // RVA: 0x7FFE81121480
        public void AddSignerCallback(){} // RVA: 0x7FFE810FB310
        public void GetSignerIdentifier(){} // RVA: 0x7FFE8A1143B0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE8A1144D0
    }

    public class CmsSignedHelper : Object
    {
        // ── Methods ──
        public void AddEntries(){} // RVA: 0x7FFE8A114F90
        public void .cctor(){} // RVA: 0x7FFE8A115080
        public void GetDigestAlgName(){} // RVA: 0x7FFE8A116BE0
        public void GetEncAlgorithmIdentifier(){} // RVA: 0x7FFE8A116CA0
        public void GetDigestAliases(){} // RVA: 0x7FFE8A116DF0
        public void GetEncryptionAlgName(){} // RVA: 0x7FFE8A116F10
        public void GetDigestInstance(){} // RVA: 0x7FFE8A116FD0
        public void GetSignatureInstance(){} // RVA: 0x7FFE8A1170D0
        public void CreateAttributeStore(){} // RVA: 0x7FFE8A117120
        public void CreateCertificateStore(){} // RVA: 0x7FFE8A1175D0
        public void CreateCrlStore(){} // RVA: 0x7FFE8A117750
        public void AddCertsFromSet(){} // RVA: 0x7FFE8A1178D0
        public void AddCrlsFromSet(){} // RVA: 0x7FFE8A117BE0
        public void FixAlgID(){} // RVA: 0x7FFE8A117EA0
        public void GetEncOid(){} // RVA: 0x7FFE8A117F90
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class CmsStreamException : IOException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE869662F0 | overloaded x3
    }

    public class CmsTypedStream : Object
    {
        public int BufferSize;
        public string _oid; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A1187A0 | overloaded x3
        public void get_ContentType(){} // RVA: 0x7FFE81116380
        public void get_ContentStream(){} // RVA: 0x7FFE810FE7C0
        public void Drain(){} // RVA: 0x7FFE8A118900
    }

    public class CmsUtilities : Object
    {
        // ── Methods ──
        public void get_MaximumMemory(){} // RVA: 0x7FFE8A118AA0
        public void ReadContentInfo(){} // RVA: 0x7FFE8A118BE0 | overloaded x3
        public void StreamToByteArray(){} // RVA: 0x7FFE8A118D40 | overloaded x2
        public void GetCertificatesFromStore(){} // RVA: 0x7FFE8A118EE0
        public void GetCrlsFromStore(){} // RVA: 0x7FFE8A119350
        public void CreateBerSetFromList(){} // RVA: 0x7FFE8A1197C0
        public void CreateDerSetFromList(){} // RVA: 0x7FFE8A119B30
        public void CreateBerOctetOutputStream(){} // RVA: 0x7FFE8A119E80
        public void GetTbsCertificateStructure(){} // RVA: 0x7FFE8A11A060
        public void GetIssuerAndSerialNumber(){} // RVA: 0x7FFE8A11A0A0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class CounterSignatureDigestCalculator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81CA56D0
        public void GetDigest(){} // RVA: 0x7FFE8A11A160
    }

    public class DefaultAuthenticatedAttributeTableGenerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A11A3F0 | overloaded x2
        public void CreateStandardAttributeTable(){} // RVA: 0x7FFE8A11A590
        public void GetAttributes(){} // RVA: 0x7FFE8A11AA80
    }

    public class DefaultDigestAlgorithmIdentifierFinder : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE8A111C30
        public void find(){} // RVA: 0x7FFE8A113240 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class DefaultSignatureAlgorithmIdentifierFinder : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE8A10CE30
        public void Generate(){} // RVA: 0x7FFE8A111430
        public void CreatePssParams(){} // RVA: 0x7FFE8A111A90
        public void Find(){} // RVA: 0x7FFE8A111BE0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class DefaultSignedAttributeTableGenerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A11ABE0 | overloaded x2
        public void createStandardAttributeTable(){} // RVA: 0x7FFE8A11AD80
        public void DoCreateStandardAttributeTable(){} // RVA: 0x7FFE8A11AE20
        public void GetAttributes(){} // RVA: 0x7FFE8A11B4B0
    }

    public class EnvelopedDataHelper : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE8A11B530
        public void CreateContentCipher(){} // RVA: 0x7FFE8A11BA70
        public void GenerateEncryptionAlgID(){} // RVA: 0x7FFE8A11BAE0
        public void CreateKeyGenerator(){} // RVA: 0x7FFE8A11BB70
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class IDigestCalculator
    {
        // ── Methods ──
        public void GetDigest(){} // RVA: 0x7FFE80E2E2E0
    }

    public class ISignerInfoGenerator
    {
        // ── Methods ──
        public void Generate(){} // RVA: 0x7FFE80E403A0
    }

    public class KekRecipientInfoGenerator : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Cms.CmsEnvelopedHelper Helper;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.KeyParameter keyEncryptionKey; // 0x10
        public string keyEncryptionKeyOID; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void set_KekIdentifier(){} // RVA: 0x7FFE811290D0
        public void set_KeyEncryptionKey(){} // RVA: 0x7FFE8A11BB90
        public void set_KeyEncryptionKeyOID(){} // RVA: 0x7FFE81161E80
        public void Generate(){} // RVA: 0x7FFE8A11BCC0
        public void DetermineKeyEncAlg(){} // RVA: 0x7FFE8A11C010
        public void .cctor(){} // RVA: 0x7FFE8A11C5E0
    }

    public class KekRecipientInformation : RecipientInformation
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A11C6B0
        public void GetContentStream(){} // RVA: 0x7FFE8A11C920
    }

    public class KeyAgreeRecipientInfoGenerator : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Cms.CmsEnvelopedHelper Helper;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier keyAgreementOID; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier keyEncryptionOID; // 0x18
        public System.Collections.IList recipientCerts; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void set_KeyAgreementOID(){} // RVA: 0x7FFE810FCE30
        public void set_KeyEncryptionOID(){} // RVA: 0x7FFE81161E80
        public void set_RecipientCerts(){} // RVA: 0x7FFE8A11CBE0
        public void set_SenderKeyPair(){} // RVA: 0x7FFE810FCE90
        public void Generate(){} // RVA: 0x7FFE8A11CCD0
        public void CreateOriginatorPublicKey(){} // RVA: 0x7FFE8A11E090
        public void .cctor(){} // RVA: 0x7FFE8A11E2B0
    }

    public class KeyAgreeRecipientInformation : RecipientInformation
    {
        // ── Methods ──
        public void ReadRecipientInfo(){} // RVA: 0x7FFE8A11E380
        public void .ctor(){} // RVA: 0x7FFE8A11E7A0
        public void GetSenderPublicKey(){} // RVA: 0x7FFE8A11E900
        public void GetPublicKeyFromOriginatorPublicKey(){} // RVA: 0x7FFE8A11EA60
        public void GetPublicKeyFromOriginatorID(){} // RVA: 0x7FFE8A11EB30
        public void CalculateAgreedWrapKey(){} // RVA: 0x7FFE8A11EB80
        public void UnwrapSessionKey(){} // RVA: 0x7FFE8A11EFB0
        public void GetSessionKey(){} // RVA: 0x7FFE8A11F140
        public void GetContentStream(){} // RVA: 0x7FFE8A11F610
    }

    public class KeyTransRecipientInfoGenerator : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Cms.CmsEnvelopedHelper Helper;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.TbsCertificateStructure recipientTbsCert; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.AsymmetricKeyParameter recipientPublicKey; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString subjectKeyIdentifier; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A11F790 | overloaded x3
        public void set_RecipientCert(){} // RVA: 0x7FFE8A11F8E0
        public void set_RecipientPublicKey(){} // RVA: 0x7FFE8A11FA60
        public void set_SubjectKeyIdentifier(){} // RVA: 0x7FFE811290D0
        public void Generate(){} // RVA: 0x7FFE8A11FB80
        public void get_AlgorithmDetails(){} // RVA: 0x7FFE84D05590
        public void GenerateWrappedKey(){} // RVA: 0x7FFE8A11FEE0
        public void .cctor(){} // RVA: 0x7FFE8A120070
    }

    public class KeyTransRecipientInformation : RecipientInformation
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A120140
        public void GetExchangeEncryptionAlgorithmName(){} // RVA: 0x7FFE8A1204B0
        public void UnwrapKey(){} // RVA: 0x7FFE8A120920
        public void GetContentStream(){} // RVA: 0x7FFE8A120C50
    }

    public class OriginatorID : X509CertStoreSelector
    {
        // ── Methods ──
        public void GetHashCode(){} // RVA: 0x7FFE8A120C80
        public void Equals(){} // RVA: 0x7FFE8A120D70
        public void .ctor(){} // RVA: 0x7FFE82A55FE0
    }

    public class OriginatorInfoGenerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A121220 | overloaded x3
        public void Generate(){} // RVA: 0x7FFE8A121310
    }

    public class OriginatorInformation : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void GetCertificates(){} // RVA: 0x7FFE8A121430
        public void GetCrls(){} // RVA: 0x7FFE8A121890
        public void ToAsn1Structure(){} // RVA: 0x7FFE81116380
    }

    public class PasswordRecipientInfoGenerator : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Cms.CmsEnvelopedHelper Helper;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier keyDerivationAlgorithm; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.KeyParameter keyEncryptionKey; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void set_KeyDerivationAlgorithm(){} // RVA: 0x7FFE810FCE30
        public void set_KeyEncryptionKey(){} // RVA: 0x7FFE81161E80
        public void set_KeyEncryptionKeyOID(){} // RVA: 0x7FFE811290D0
        public void Generate(){} // RVA: 0x7FFE8A121CF0
        public void .cctor(){} // RVA: 0x7FFE8A1222F0
    }

    public class PasswordRecipientInformation : RecipientInformation
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.PasswordRecipientInfo info; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A1223C0
        public void get_KeyDerivationAlgorithm(){} // RVA: 0x7FFE817B4F10
        public void GetContentStream(){} // RVA: 0x7FFE8A1224E0
    }

    public class Pkcs5Scheme2PbeKey : CmsPbeKey
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A1229E0 | overloaded x4
        public void GetEncoded(){} // RVA: 0x7FFE8A1229F0
    }

    public class Pkcs5Scheme2Utf8PbeKey : CmsPbeKey
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A1229E0 | overloaded x4
        public void GetEncoded(){} // RVA: 0x7FFE8A122B90
    }

    public class RecipientID : X509CertStoreSelector
    {
        public byte[] keyIdentifier; // 0x88

        // ── Methods ──
        public void get_KeyIdentifier(){} // RVA: 0x7FFE8A122D90
        public void set_KeyIdentifier(){} // RVA: 0x7FFE8A122E50
        public void GetHashCode(){} // RVA: 0x7FFE8A122F60
        public void Equals(){} // RVA: 0x7FFE8A123090
        public void .ctor(){} // RVA: 0x7FFE82A55FE0
    }

    public class RecipientInfoGenerator
    {
        // ── Methods ──
        public void Generate(){} // RVA: 0x7FFE80E3FC10
    }

    public class RecipientInformation : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Cms.RecipientID rid; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier keyEncAlg; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Cms.CmsSecureReadable secureReadable; // 0x20
        public byte[] resultMac; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A1232C0
        public void GetContentAlgorithmName(){} // RVA: 0x7FFE8A123420
        public void get_RecipientID(){} // RVA: 0x7FFE81116380
        public void get_KeyEncryptionAlgorithmID(){} // RVA: 0x7FFE810FE7C0
        public void get_KeyEncryptionAlgOid(){} // RVA: 0x7FFE8A123500
        public void get_KeyEncryptionAlgParams(){} // RVA: 0x7FFE8A123540
        public void GetContentFromSessionKey(){} // RVA: 0x7FFE8A123590
        public void GetContent(){} // RVA: 0x7FFE8A1237A0
        public void GetMac(){} // RVA: 0x7FFE8A123880
        public void GetContentStream(){} // RVA: 0x7FFE80E2E390
    }

    public class RecipientInformationStore : Object
    {
        public System.Collections.IList all; // 0x10
        public System.Collections.IDictionary table; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A123A60
        public void get_Item(){} // RVA: 0x7FFE8A123FA0
        public void GetFirstRecipient(){} // RVA: 0x7FFE8A1240B0
        public void get_Count(){} // RVA: 0x7FFE8A1241C0
        public void GetRecipients(){} // RVA: 0x7FFE8A1242B0 | overloaded x2
    }

    public class SignerID : X509CertStoreSelector
    {
        // ── Methods ──
        public void GetHashCode(){} // RVA: 0x7FFE8A124430
        public void Equals(){} // RVA: 0x7FFE8A124520
        public void .ctor(){} // RVA: 0x7FFE82A55FE0
    }

    public class SignerInfoGenerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A124980 | overloaded x3
        public void setAssociatedCertificate(){} // RVA: 0x7FFE810FCE30
    }

    public class SignerInfoGeneratorBuilder : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void SetDirectSignature(){} // RVA: 0x7FFE8A124AE0
        public void WithSignedAttributeGenerator(){} // RVA: 0x7FFE829DE9A0
        public void WithUnsignedAttributeGenerator(){} // RVA: 0x7FFE89F97020
        public void Build(){} // RVA: 0x7FFE8A124D80 | overloaded x2
        public void CreateGenerator(){} // RVA: 0x7FFE8A124EC0
    }

    public class SignerInformation : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Cms.CmsSignedHelper Helper;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Cms.SignerID sid; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.SignerInfo info; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier digestAlgorithm; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier encryptionAlgorithm; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set signedAttributeSet; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set unsignedAttributeSet; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Cms.CmsProcessable content; // 0x40
        public byte[] signature; // 0x48
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier contentType; // 0x50
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Cms.IDigestCalculator digestCalculator; // 0x58
        public byte[] resultDigest; // 0x60

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A1256F0 | overloaded x2
        public void get_IsCounterSignature(){} // RVA: 0x7FFE816400C0
        public void get_ContentType(){} // RVA: 0x7FFE8119C0E0
        public void get_SignerID(){} // RVA: 0x7FFE81116380
        public void get_Version(){} // RVA: 0x7FFE8A100400
        public void get_DigestAlgorithmID(){} // RVA: 0x7FFE811290C0
        public void get_DigestAlgOid(){} // RVA: 0x7FFE8A0F1040
        public void get_DigestAlgParams(){} // RVA: 0x7FFE8A125B70
        public void GetContentDigest(){} // RVA: 0x7FFE8A125BC0
        public void get_EncryptionAlgorithmID(){} // RVA: 0x7FFE81129130
        public void get_EncryptionAlgOid(){} // RVA: 0x7FFE8A125C80
        public void get_EncryptionAlgParams(){} // RVA: 0x7FFE8A125CC0
        public void get_SignedAttributes(){} // RVA: 0x7FFE8A125D10
        public void get_UnsignedAttributes(){} // RVA: 0x7FFE8A125DE0
        public void GetSignature(){} // RVA: 0x7FFE8A125EB0
        public void GetCounterSignatures(){} // RVA: 0x7FFE8A125F30
        public void GetEncodedSignedAttributes(){} // RVA: 0x7FFE8A1265A0
        public void DoVerify(){} // RVA: 0x7FFE8A126600
        public void IsNull(){} // RVA: 0x7FFE8A1279C0
        public void DerDecode(){} // RVA: 0x7FFE8A127A30
        public void VerifyDigest(){} // RVA: 0x7FFE8A127B40
        public void Verify(){} // RVA: 0x7FFE8A128350 | overloaded x2
        public void ToSignerInfo(){} // RVA: 0x7FFE810FE7C0
        public void GetSingleValuedSignedAttribute(){} // RVA: 0x7FFE8A1283D0
        public void GetSigningTime(){} // RVA: 0x7FFE8A1286A0
        public void ReplaceUnsignedAttributes(){} // RVA: 0x7FFE8A128790
        public void AddCounterSigners(){} // RVA: 0x7FFE8A1289B0
        public void .cctor(){} // RVA: 0x7FFE8A128F90
    }

    public class SignerInformationStore : Object
    {
        public System.Collections.IList all; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A1292E0 | overloaded x2
        public void GetFirstSigner(){} // RVA: 0x7FFE8A129820
        public void get_Count(){} // RVA: 0x7FFE8A129930
        public void GetSigners(){} // RVA: 0x7FFE8A129A20 | overloaded x2
    }

    public class SimpleAttributeTableGenerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void GetAttributes(){} // RVA: 0x7FFE81116380
    }

}