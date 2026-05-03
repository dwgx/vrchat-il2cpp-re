// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Ocsp
// Classes: 18
// Methods: 125

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Ocsp
{
    public class BasicOcspResp : X509ExtensionBase
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp.BasicOcspResponse resp; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp.ResponseData data; // 0x18
        public object field_2; // 0x1A2
        public object field_3; // 0x1A3
        public object field_4; // 0x1A4
        public object field_5; // 0x1A5
        public object field_6; // 0x1A6

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A3DCCA0
        public void GetTbsResponseData(){} // RVA: 0x7FFE8A3DCD80
        public void get_Version(){} // RVA: 0x7FFE8A3DCE10
        public void get_ResponderId(){} // RVA: 0x7FFE8A3DCE80
        public void get_ProducedAt(){} // RVA: 0x7FFE8A3DCF20
        public void get_Responses(){} // RVA: 0x7FFE8A3DCF50
        public void get_ResponseExtensions(){} // RVA: 0x7FFE86BAE0A0
        public void GetX509Extensions(){} // RVA: 0x7FFE86BAE0A0
        public void get_SignatureAlgName(){} // RVA: 0x7FFE8A3DD160
        public void get_SignatureAlgOid(){} // RVA: 0x7FFE89EAFE10
        public void GetResponseData(){} // RVA: 0x7FFE8A3DD2E0
        public void GetSignature(){} // RVA: 0x7FFE89EAFCA0
        public void GetCertList(){} // RVA: 0x7FFE8A3DD380
        public void GetCerts(){} // RVA: 0x7FFE8A3DD700
        public void GetCertificates(){} // RVA: 0x7FFE8A3DDA00
        public void Verify(){} // RVA: 0x7FFE8A3DDB10
        public void GetEncoded(){} // RVA: 0x7FFE89EBCFE0
        public void Equals(){} // RVA: 0x7FFE8A3DDE80
        public void GetHashCode(){} // RVA: 0x7FFE8170B620
    }

    public class BasicOcspRespGenerator : Object
    {
        public System.Collections.IList list; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A3DE090 | overloaded x2
        public void AddResponse(){} // RVA: 0x7FFE8A3DE510 | overloaded x4
        public void SetResponseExtensions(){} // RVA: 0x7FFE81161E80
        public void GenerateResponse(){} // RVA: 0x7FFE8A3DE5F0
        public void Generate(){} // RVA: 0x7FFE8A3DF4B0 | overloaded x3
        public void get_SignatureAlgNames(){} // RVA: 0x7FFE8A3DF520
    }

    public class CertificateID : Object
    {
        public string HashSha1;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp.CertID id; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A3DFE60 | overloaded x2
        public void get_HashAlgOid(){} // RVA: 0x7FFE8A3E0080
        public void GetIssuerNameHash(){} // RVA: 0x7FFE8A3192D0
        public void GetIssuerKeyHash(){} // RVA: 0x7FFE8A3E00C0
        public void get_SerialNumber(){} // RVA: 0x7FFE8A153B10
        public void MatchesIssuer(){} // RVA: 0x7FFE8A3E0100
        public void ToAsn1Object(){} // RVA: 0x7FFE81116380
        public void Equals(){} // RVA: 0x7FFE8A3E0150
        public void GetHashCode(){} // RVA: 0x7FFE8A3E0270
        public void DeriveCertificateID(){} // RVA: 0x7FFE8A3E02C0
        public void CreateCertID(){} // RVA: 0x7FFE8A3E0510
    }

    public class CertificateStatus : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class OCSPRespGenerator : Object
    {
        // ── Methods ──
        public void Generate(){} // RVA: 0x7FFE8A3E34B0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class OcscpRespStatus : OcspRespStatus
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class OcspException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A3E0970 | overloaded x3
    }

    public class OcspReq : X509ExtensionBase
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp.OcspRequest req; // 0x10
        public object field_1; // 0x1AC
        public object field_2; // 0x1AD
        public object field_3; // 0x1AE
        public object field_4; // 0x1AF

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A3E0B30 | overloaded x4
        public void GetTbsRequest(){} // RVA: 0x7FFE8A3E0CC0
        public void get_Version(){} // RVA: 0x7FFE89EBC370
        public void get_RequestorName(){} // RVA: 0x7FFE8A3E0D60
        public void GetRequestList(){} // RVA: 0x7FFE8A3E0D90
        public void get_RequestExtensions(){} // RVA: 0x7FFE8A3E0FB0
        public void GetX509Extensions(){} // RVA: 0x7FFE8A3E0FB0
        public void get_SignatureAlgOid(){} // RVA: 0x7FFE8A3E1020
        public void GetSignature(){} // RVA: 0x7FFE8A3E1070
        public void GetCertList(){} // RVA: 0x7FFE8A3E10C0
        public void GetCerts(){} // RVA: 0x7FFE8A3E1400
        public void GetCertificates(){} // RVA: 0x7FFE8A3E1720
        public void get_IsSigned(){} // RVA: 0x7FFE8A3E1850
        public void Verify(){} // RVA: 0x7FFE8A3E1870
        public void GetEncoded(){} // RVA: 0x7FFE89EBCFE0
    }

    public class OcspReqGenerator : Object
    {
        public System.Collections.IList list; // 0x10

        // ── Methods ──
        public void AddRequest(){} // RVA: 0x7FFE8A3E1BD0 | overloaded x2
        public void SetRequestorName(){} // RVA: 0x7FFE81161E80 | overloaded x2
        public void SetRequestExtensions(){} // RVA: 0x7FFE811290D0
        public void GenerateRequest(){} // RVA: 0x7FFE8A3E1DE0
        public void Generate(){} // RVA: 0x7FFE8A3E29B0 | overloaded x3
        public void get_SignatureAlgNames(){} // RVA: 0x7FFE8A3E2C70
        public void .ctor(){} // RVA: 0x7FFE8A3E2CC0
    }

    public class OcspResp : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp.OcspResponse resp; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A3E3060 | overloaded x4
        public void get_Status(){} // RVA: 0x7FFE8A3E3180
        public void GetResponseObject(){} // RVA: 0x7FFE8A3E31F0
        public void GetEncoded(){} // RVA: 0x7FFE89EBCFE0
        public void Equals(){} // RVA: 0x7FFE8A3E33E0
        public void GetHashCode(){} // RVA: 0x7FFE8170B620
    }

    public class OcspRespStatus : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class OcspUtilities : Object
    {
        public System.Collections.IDictionary algorithms;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE8A3E39D0
        public void GetAlgorithmOid(){} // RVA: 0x7FFE8A3E50E0
        public void GetAlgorithmName(){} // RVA: 0x7FFE8A3E5270
        public void GetSigAlgID(){} // RVA: 0x7FFE8A3E5390
        public void get_AlgNames(){} // RVA: 0x7FFE8A3E5510
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Req : X509ExtensionBase
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp.Request req; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void GetCertID(){} // RVA: 0x7FFE8A3E5660
        public void get_SingleRequestExtensions(){} // RVA: 0x7FFE8189C080
        public void GetX509Extensions(){} // RVA: 0x7FFE8189C080
    }

    public class RespData : X509ExtensionBase
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp.ResponseData data; // 0x10
        public object field_1; // 0x1B5
        public object field_2; // 0x1B6

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void get_Version(){} // RVA: 0x7FFE8A188EE0
        public void GetResponderId(){} // RVA: 0x7FFE8A3E5750
        public void get_ProducedAt(){} // RVA: 0x7FFE8A3E57F0
        public void GetResponses(){} // RVA: 0x7FFE8A3E5820
        public void get_ResponseExtensions(){} // RVA: 0x7FFE8189C060
        public void GetX509Extensions(){} // RVA: 0x7FFE8189C060
    }

    public class RespID : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A3E5B80 | overloaded x3
        public void ToAsn1Object(){} // RVA: 0x7FFE81116380
        public void Equals(){} // RVA: 0x7FFE8A3E5E70
        public void GetHashCode(){} // RVA: 0x7FFE8170B620
    }

    public class RevokedStatus : CertificateStatus
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp.RevokedInfo info; // 0x10
        public object field_1; // 0x1B8
        public object field_2; // 0x1B9

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A3E5F40 | overloaded x2
        public void get_RevocationTime(){} // RVA: 0x7FFE8A3E60A0
        public void get_HasRevocationReason(){} // RVA: 0x7FFE8A3E1850
        public void get_RevocationReason(){} // RVA: 0x7FFE8A3E60D0
    }

    public class SingleResp : X509ExtensionBase
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp.SingleResponse resp; // 0x10
        public object field_1; // 0x1BB
        public object field_2; // 0x1BC

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void GetCertID(){} // RVA: 0x7FFE8A3E6190
        public void GetCertStatus(){} // RVA: 0x7FFE8A3E6280
        public void get_ThisUpdate(){} // RVA: 0x7FFE8A3E6380
        public void get_NextUpdate(){} // RVA: 0x7FFE8A3E63B0
        public void get_SingleExtensions(){} // RVA: 0x7FFE8189BF90
        public void GetX509Extensions(){} // RVA: 0x7FFE8189BF90
    }

    public class UnknownStatus : CertificateStatus
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

}