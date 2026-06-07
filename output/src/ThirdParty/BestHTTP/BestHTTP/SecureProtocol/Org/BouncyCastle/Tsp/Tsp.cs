// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Tsp
// Classes: 12
// Methods: 107

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Tsp
{
    public class GenTimeAccuracy
    {
        public object Version;
        public object MessageImprintAlgOid;
        public object ReqPolicy;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void get_Seconds(){} // RVA: 0x96EADC0
        public void get_Millis(){} // RVA: 0x96EAE30
        public void get_Micros(){} // RVA: 0x96EAEA0
        public void GetTimeComponent(){} // RVA: 0x96EAF10
        public void ToString(){} // RVA: 0x96EAF70
    }

    public class TimeStampRequest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x96EB500 | overloaded x4
        public void get_Version(){} // RVA: 0x96EB860
        public void get_MessageImprintAlgOid(){} // RVA: 0x96EB8D0
        public void GetMessageImprintDigest(){} // RVA: 0x956E8D0
        public void get_ReqPolicy(){} // RVA: 0x96EB920
        public void get_Nonce(){} // RVA: 0x96EB950
        public void get_CertReq(){} // RVA: 0x96EB980
        public void Validate(){} // RVA: 0x96EB9C0
        public void GetEncoded(){} // RVA: 0x945AC10
        public void get_Extensions(){} // RVA: 0xB2E770
        public void get_HasExtensions(){} // RVA: 0x1D3B060
        public void GetExtension(){} // RVA: 0x96EBFF0
        public void GetExtensionOids(){} // RVA: 0x96EC010
        public void GetX509Extensions(){} // RVA: 0xB2E770
    }

    public class TimeStampRequestGenerator
    {
        // ── Methods ──
        public void SetReqPolicy(){} // RVA: 0x96EC1E0
        public void SetCertReq(){} // RVA: 0x96EC2A0
        public void AddExtension(){} // RVA: 0x96EC650 | overloaded x4
        public void Generate(){} // RVA: 0x96ECC50 | overloaded x4
        public void .ctor(){} // RVA: 0x96ECC80
    }

    public class TimeStampResponse
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x96ED030 | overloaded x3
        public void readTimeStampResp(){} // RVA: 0x96ED0C0
        public void get_Status(){} // RVA: 0x96ED240
        public void GetStatusString(){} // RVA: 0x96ED2B0
        public void GetFailInfo(){} // RVA: 0x96ED400
        public void get_TimeStampToken(){} // RVA: 0x2E07C0
        public void Validate(){} // RVA: 0x96ED510
        public void GetEncoded(){} // RVA: 0x945AC10
    }

    public class TimeStampResponseGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x96EDB00 | overloaded x3
        public void AddStatusString(){} // RVA: 0x96EDD10
        public void SetFailInfoField(){} // RVA: 0x96EDE10
        public void GetPkiStatusInfo(){} // RVA: 0x96EDE20
        public void Generate(){} // RVA: 0x96EE220 | overloaded x2
        public void GenerateFailResponse(){} // RVA: 0x96EE570
    }

    public class TimeStampToken
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x96EE780 | overloaded x2
        public void get_TimeStampInfo(){} // RVA: 0x30B0C0
        public void get_SignerID(){} // RVA: 0xF9DC10
        public void get_SignedAttributes(){} // RVA: 0x96EF0B0
        public void get_UnsignedAttributes(){} // RVA: 0x96EF0D0
        public void GetCertificates(){} // RVA: 0x96EF0F0
        public void GetCrls(){} // RVA: 0x96EF1E0
        public void GetAttributeCertificates(){} // RVA: 0x96EF2D0
        public void Validate(){} // RVA: 0x96EF3C0
        public void ToCmsSignedData(){} // RVA: 0x2F8380
        public void GetEncoded(){} // RVA: 0x96EFD80
    }

    public class TimeStampTokenGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x96F0200 | overloaded x2
        public void SetCertificates(){} // RVA: 0x3A5510
        public void SetCrls(){} // RVA: 0x37B380
        public void SetAccuracySeconds(){} // RVA: 0x2E00C0
        public void SetAccuracyMillis(){} // RVA: 0x8AC660
        public void SetAccuracyMicros(){} // RVA: 0x6374E0
        public void SetOrdering(){} // RVA: 0x2F83A0
        public void SetTsa(){} // RVA: 0x30B0D0
        public void Generate(){} // RVA: 0x96F0990
    }

    public class TimeStampTokenInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x96F14E0
        public void get_IsOrdered(){} // RVA: 0x96F1600
        public void get_Accuracy(){} // RVA: 0xB2E770
        public void get_GenTime(){} // RVA: 0x2E07C0
        public void get_GenTimeAccuracy(){} // RVA: 0x96F1630
        public void get_Policy(){} // RVA: 0x96F16E0
        public void get_SerialNumber(){} // RVA: 0x96F1710
        public void get_Tsa(){} // RVA: 0xF3ED00
        public void get_Nonce(){} // RVA: 0x96F1740
        public void get_HashAlgorithm(){} // RVA: 0x96F1770
        public void get_MessageImprintAlgOid(){} // RVA: 0x96F17A0
        public void GetMessageImprintDigest(){} // RVA: 0x96F17F0
        public void GetEncoded(){} // RVA: 0x945AC10
        public void get_TstInfo(){} // RVA: 0x2F8380
    }

    public class TspAlgorithms
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x96F1820
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class TspException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x96F24F0 | overloaded x3
    }

    public class TspUtil
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x96F2560
        public void GetSignatureTimestamps(){} // RVA: 0x96F37A0
        public void ValidateCertificate(){} // RVA: 0x96F3E80
        public void GetDigestAlgName(){} // RVA: 0x96F4240
        public void GetDigestLength(){} // RVA: 0x96F4300
        public void CreateDigestInstance(){} // RVA: 0x96F4450
        public void GetCriticalExtensionOids(){} // RVA: 0x96F44E0
        public void GetNonCriticalExtensionOids(){} // RVA: 0x96F45A0
        public void GetExtensionOids(){} // RVA: 0x96F4660
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class TspValidationException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x96F4870 | overloaded x2
        public void get_FailureCode(){} // RVA: 0x6AFD40
    }

}