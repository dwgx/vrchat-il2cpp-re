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
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void get_Seconds(){} // RVA: 0x7FFAFC19ADC0
        public void get_Millis(){} // RVA: 0x7FFAFC19AE30
        public void get_Micros(){} // RVA: 0x7FFAFC19AEA0
        public void GetTimeComponent(){} // RVA: 0x7FFAFC19AF10
        public void ToString(){} // RVA: 0x7FFAFC19AF70
    }

    public class TimeStampRequest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC19B500 | overloaded x4
        public void get_Version(){} // RVA: 0x7FFAFC19B860
        public void get_MessageImprintAlgOid(){} // RVA: 0x7FFAFC19B8D0
        public void GetMessageImprintDigest(){} // RVA: 0x7FFAFC01E8D0
        public void get_ReqPolicy(){} // RVA: 0x7FFAFC19B920
        public void get_Nonce(){} // RVA: 0x7FFAFC19B950
        public void get_CertReq(){} // RVA: 0x7FFAFC19B980
        public void Validate(){} // RVA: 0x7FFAFC19B9C0
        public void GetEncoded(){} // RVA: 0x7FFAFBF0AC10
        public void get_Extensions(){} // RVA: 0x7FFAF35DE770
        public void get_HasExtensions(){} // RVA: 0x7FFAF47EB060
        public void GetExtension(){} // RVA: 0x7FFAFC19BFF0
        public void GetExtensionOids(){} // RVA: 0x7FFAFC19C010
        public void GetX509Extensions(){} // RVA: 0x7FFAF35DE770
    }

    public class TimeStampRequestGenerator
    {
        // ── Methods ──
        public void SetReqPolicy(){} // RVA: 0x7FFAFC19C1E0
        public void SetCertReq(){} // RVA: 0x7FFAFC19C2A0
        public void AddExtension(){} // RVA: 0x7FFAFC19C650 | overloaded x4
        public void Generate(){} // RVA: 0x7FFAFC19CC50 | overloaded x4
        public void .ctor(){} // RVA: 0x7FFAFC19CC80
    }

    public class TimeStampResponse
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC19D030 | overloaded x3
        public void readTimeStampResp(){} // RVA: 0x7FFAFC19D0C0
        public void get_Status(){} // RVA: 0x7FFAFC19D240
        public void GetStatusString(){} // RVA: 0x7FFAFC19D2B0
        public void GetFailInfo(){} // RVA: 0x7FFAFC19D400
        public void get_TimeStampToken(){} // RVA: 0x7FFAF2D907C0
        public void Validate(){} // RVA: 0x7FFAFC19D510
        public void GetEncoded(){} // RVA: 0x7FFAFBF0AC10
    }

    public class TimeStampResponseGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC19DB00 | overloaded x3
        public void AddStatusString(){} // RVA: 0x7FFAFC19DD10
        public void SetFailInfoField(){} // RVA: 0x7FFAFC19DE10
        public void GetPkiStatusInfo(){} // RVA: 0x7FFAFC19DE20
        public void Generate(){} // RVA: 0x7FFAFC19E220 | overloaded x2
        public void GenerateFailResponse(){} // RVA: 0x7FFAFC19E570
    }

    public class TimeStampToken
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC19E780 | overloaded x2
        public void get_TimeStampInfo(){} // RVA: 0x7FFAF2DBB0C0
        public void get_SignerID(){} // RVA: 0x7FFAF3A4DC10
        public void get_SignedAttributes(){} // RVA: 0x7FFAFC19F0B0
        public void get_UnsignedAttributes(){} // RVA: 0x7FFAFC19F0D0
        public void GetCertificates(){} // RVA: 0x7FFAFC19F0F0
        public void GetCrls(){} // RVA: 0x7FFAFC19F1E0
        public void GetAttributeCertificates(){} // RVA: 0x7FFAFC19F2D0
        public void Validate(){} // RVA: 0x7FFAFC19F3C0
        public void ToCmsSignedData(){} // RVA: 0x7FFAF2DA8380
        public void GetEncoded(){} // RVA: 0x7FFAFC19FD80
    }

    public class TimeStampTokenGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC1A0200 | overloaded x2
        public void SetCertificates(){} // RVA: 0x7FFAF2E55510
        public void SetCrls(){} // RVA: 0x7FFAF2E2B380
        public void SetAccuracySeconds(){} // RVA: 0x7FFAF2D900C0
        public void SetAccuracyMillis(){} // RVA: 0x7FFAF335C660
        public void SetAccuracyMicros(){} // RVA: 0x7FFAF30E74E0
        public void SetOrdering(){} // RVA: 0x7FFAF2DA83A0
        public void SetTsa(){} // RVA: 0x7FFAF2DBB0D0
        public void Generate(){} // RVA: 0x7FFAFC1A0990
    }

    public class TimeStampTokenInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC1A14E0
        public void get_IsOrdered(){} // RVA: 0x7FFAFC1A1600
        public void get_Accuracy(){} // RVA: 0x7FFAF35DE770
        public void get_GenTime(){} // RVA: 0x7FFAF2D907C0
        public void get_GenTimeAccuracy(){} // RVA: 0x7FFAFC1A1630
        public void get_Policy(){} // RVA: 0x7FFAFC1A16E0
        public void get_SerialNumber(){} // RVA: 0x7FFAFC1A1710
        public void get_Tsa(){} // RVA: 0x7FFAF39EED00
        public void get_Nonce(){} // RVA: 0x7FFAFC1A1740
        public void get_HashAlgorithm(){} // RVA: 0x7FFAFC1A1770
        public void get_MessageImprintAlgOid(){} // RVA: 0x7FFAFC1A17A0
        public void GetMessageImprintDigest(){} // RVA: 0x7FFAFC1A17F0
        public void GetEncoded(){} // RVA: 0x7FFAFBF0AC10
        public void get_TstInfo(){} // RVA: 0x7FFAF2DA8380
    }

    public class TspAlgorithms
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAFC1A1820
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class TspException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC1A24F0 | overloaded x3
    }

    public class TspUtil
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAFC1A2560
        public void GetSignatureTimestamps(){} // RVA: 0x7FFAFC1A37A0
        public void ValidateCertificate(){} // RVA: 0x7FFAFC1A3E80
        public void GetDigestAlgName(){} // RVA: 0x7FFAFC1A4240
        public void GetDigestLength(){} // RVA: 0x7FFAFC1A4300
        public void CreateDigestInstance(){} // RVA: 0x7FFAFC1A4450
        public void GetCriticalExtensionOids(){} // RVA: 0x7FFAFC1A44E0
        public void GetNonCriticalExtensionOids(){} // RVA: 0x7FFAFC1A45A0
        public void GetExtensionOids(){} // RVA: 0x7FFAFC1A4660
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class TspValidationException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC1A4870 | overloaded x2
        public void get_FailureCode(){} // RVA: 0x7FFAF315FD40
    }

}