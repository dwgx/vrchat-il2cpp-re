// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Tsp
// Classes: 12
// Methods: 107

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Tsp
{
    public class GenTimeAccuracy : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Tsp.Accuracy accuracy; // 0x10
        public object field_1; // 0x14D
        public object field_2; // 0x14E

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void get_Seconds(){} // RVA: 0x7FFE8A14D1C0
        public void get_Millis(){} // RVA: 0x7FFE8A14D230
        public void get_Micros(){} // RVA: 0x7FFE8A14D2A0
        public void GetTimeComponent(){} // RVA: 0x7FFE8A14D310
        public void ToString(){} // RVA: 0x7FFE8A14D370
    }

    public class TimeStampRequest : X509ExtensionBase
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Tsp.TimeStampReq req; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Extensions extensions; // 0x18
        public object field_2; // 0x150
        public object field_3; // 0x151
        public object field_4; // 0x152
        public object field_5; // 0x153
        public object field_6; // 0x154

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A14D900 | overloaded x4
        public void get_Version(){} // RVA: 0x7FFE8A14DC60
        public void get_MessageImprintAlgOid(){} // RVA: 0x7FFE8A14DCD0
        public void GetMessageImprintDigest(){} // RVA: 0x7FFE89FD0CA0
        public void get_ReqPolicy(){} // RVA: 0x7FFE8A14DD20
        public void get_Nonce(){} // RVA: 0x7FFE8A14DD50
        public void get_CertReq(){} // RVA: 0x7FFE8A14DD80
        public void Validate(){} // RVA: 0x7FFE8A14DDC0
        public void GetEncoded(){} // RVA: 0x7FFE89EBCFE0
        public void get_Extensions(){} // RVA: 0x7FFE8189C060
        public void get_HasExtensions(){} // RVA: 0x7FFE82AC8EE0
        public void GetExtension(){} // RVA: 0x7FFE8A14E3F0
        public void GetExtensionOids(){} // RVA: 0x7FFE8A14E410
        public void GetX509Extensions(){} // RVA: 0x7FFE8189C060
    }

    public class TimeStampRequestGenerator : Object
    {
        // ── Methods ──
        public void SetReqPolicy(){} // RVA: 0x7FFE8A14E5E0
        public void SetCertReq(){} // RVA: 0x7FFE8A14E6A0
        public void AddExtension(){} // RVA: 0x7FFE8A14EA50 | overloaded x4
        public void Generate(){} // RVA: 0x7FFE8A14F050 | overloaded x4
        public void .ctor(){} // RVA: 0x7FFE8A14F080
    }

    public class TimeStampResponse : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Tsp.TimeStampResp resp; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Tsp.TimeStampToken timeStampToken; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A14F430 | overloaded x3
        public void readTimeStampResp(){} // RVA: 0x7FFE8A14F4C0
        public void get_Status(){} // RVA: 0x7FFE8A14F640
        public void GetStatusString(){} // RVA: 0x7FFE8A14F6B0
        public void GetFailInfo(){} // RVA: 0x7FFE8A14F800
        public void get_TimeStampToken(){} // RVA: 0x7FFE810FE7C0
        public void Validate(){} // RVA: 0x7FFE8A14F910
        public void GetEncoded(){} // RVA: 0x7FFE89EBCFE0
    }

    public class TimeStampResponseGenerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A14FF00 | overloaded x3
        public void AddStatusString(){} // RVA: 0x7FFE8A150110
        public void SetFailInfoField(){} // RVA: 0x7FFE8A150210
        public void GetPkiStatusInfo(){} // RVA: 0x7FFE8A150220
        public void Generate(){} // RVA: 0x7FFE8A150620 | overloaded x2
        public void GenerateFailResponse(){} // RVA: 0x7FFE8A150970
    }

    public class TimeStampToken : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Cms.CmsSignedData tsToken; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Cms.SignerInformation tsaSignerInfo; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Tsp.TimeStampTokenInfo tstInfo; // 0x20
        public CertID certID; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A150B80 | overloaded x2
        public void get_TimeStampInfo(){} // RVA: 0x7FFE811290C0
        public void get_SignerID(){} // RVA: 0x7FFE81D29350
        public void get_SignedAttributes(){} // RVA: 0x7FFE8A1514B0
        public void get_UnsignedAttributes(){} // RVA: 0x7FFE8A1514D0
        public void GetCertificates(){} // RVA: 0x7FFE8A1514F0
        public void GetCrls(){} // RVA: 0x7FFE8A1515E0
        public void GetAttributeCertificates(){} // RVA: 0x7FFE8A1516D0
        public void Validate(){} // RVA: 0x7FFE8A1517C0
        public void ToCmsSignedData(){} // RVA: 0x7FFE81116380
        public void GetEncoded(){} // RVA: 0x7FFE8A152180
    }

    public class TimeStampTokenGenerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A152600 | overloaded x2
        public void SetCertificates(){} // RVA: 0x7FFE811C3510
        public void SetCrls(){} // RVA: 0x7FFE81199380
        public void SetAccuracySeconds(){} // RVA: 0x7FFE810FE0C0
        public void SetAccuracyMillis(){} // RVA: 0x7FFE8164E0F0
        public void SetAccuracyMicros(){} // RVA: 0x7FFE8144DF00
        public void SetOrdering(){} // RVA: 0x7FFE811163A0
        public void SetTsa(){} // RVA: 0x7FFE811290D0
        public void Generate(){} // RVA: 0x7FFE8A152D90
    }

    public class TimeStampTokenInfo : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Tsp.TstInfo tstInfo; // 0x10
        public System.DateTime genTime; // 0x18
        public object field_2; // 0x15E
        public object field_3; // 0x15F
        public object field_4; // 0x160
        public object field_5; // 0x161
        public object field_6; // 0x162
        public object field_7; // 0x163
        public object field_8; // 0x164
        public object field_9; // 0x165
        public object field_10; // 0x166

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A1538E0
        public void get_IsOrdered(){} // RVA: 0x7FFE8A153A00
        public void get_Accuracy(){} // RVA: 0x7FFE8189C060
        public void get_GenTime(){} // RVA: 0x7FFE810FE7C0
        public void get_GenTimeAccuracy(){} // RVA: 0x7FFE8A153A30
        public void get_Policy(){} // RVA: 0x7FFE8A153AE0
        public void get_SerialNumber(){} // RVA: 0x7FFE8A153B10
        public void get_Tsa(){} // RVA: 0x7FFE87163660
        public void get_Nonce(){} // RVA: 0x7FFE8A153B40
        public void get_HashAlgorithm(){} // RVA: 0x7FFE8A153B70
        public void get_MessageImprintAlgOid(){} // RVA: 0x7FFE8A153BA0
        public void GetMessageImprintDigest(){} // RVA: 0x7FFE8A153BF0
        public void GetEncoded(){} // RVA: 0x7FFE89EBCFE0
        public void get_TstInfo(){} // RVA: 0x7FFE81116380
    }

    public class TspAlgorithms : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE8A153C20
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class TspException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A1548F0 | overloaded x3
    }

    public class TspUtil : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE8A154960
        public void GetSignatureTimestamps(){} // RVA: 0x7FFE8A155BA0
        public void ValidateCertificate(){} // RVA: 0x7FFE8A156280
        public void GetDigestAlgName(){} // RVA: 0x7FFE8A156640
        public void GetDigestLength(){} // RVA: 0x7FFE8A156700
        public void CreateDigestInstance(){} // RVA: 0x7FFE8A156850
        public void GetCriticalExtensionOids(){} // RVA: 0x7FFE8A1568E0
        public void GetNonCriticalExtensionOids(){} // RVA: 0x7FFE8A1569A0
        public void GetExtensionOids(){} // RVA: 0x7FFE8A156A60
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class TspValidationException : TspException
    {
        public int failureCode; // 0x90

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A156C70 | overloaded x2
        public void get_FailureCode(){} // RVA: 0x7FFE814AA220
    }

}