// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Ocsp
// Classes: 18
// Methods: 103

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Ocsp
{
    public class BasicOcspResp : X509ExtensionBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B17BCE70
        public void GetTbsResponseData(){} // RVA: 0x7B17BCF50
        public void get_Version(){} // RVA: 0x7B17BCFE0
        public void get_ResponderId(){} // RVA: 0x7B17BD050
        public void get_ProducedAt(){} // RVA: 0x7B17BD0F0
        public void get_Responses(){} // RVA: 0x7B17BD120
        public void get_ResponseExtensions(){} // RVA: 0x7ADE59620
        public void GetX509Extensions(){} // RVA: 0x7ADE59620
        public void get_SignatureAlgName(){} // RVA: 0x7B17BD320
        public void get_SignatureAlgOid(){} // RVA: 0x7B12816E0
        public void GetResponseData(){} // RVA: 0x7B17BD4A0
        public void GetSignature(){} // RVA: 0x7B1281570
        public void GetCertList(){} // RVA: 0x7B17BD540
        public void GetCerts(){} // RVA: 0x7B17BD8C0
        public void GetCertificates(){} // RVA: 0x7B17BDBC0
        public void Verify(){} // RVA: 0x7B17BDCD0
        public void GetEncoded(){} // RVA: 0x7B128E860
        public void Equals(){} // RVA: 0x7B17BE040
        public void GetHashCode(){} // RVA: 0x7A8738190
    }

    public class BasicOcspRespGenerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B17BE240
        public void AddResponse(){} // RVA: 0x7B17BE6C0
        public void SetResponseExtensions(){} // RVA: 0x7A813E420
        public void GenerateResponse(){} // RVA: 0x7B17BE7A0
        public void Generate(){} // RVA: 0x7B17BF600
        public void get_SignatureAlgNames(){} // RVA: 0x7B17BF670
    }

    public class CertificateID : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B17C0120
        public void get_HashAlgOid(){} // RVA: 0x7B17C0340
        public void GetIssuerNameHash(){} // RVA: 0x7B16F26F0
        public void GetIssuerKeyHash(){} // RVA: 0x7B17C0380
        public void get_SerialNumber(){} // RVA: 0x7B152B230
        public void MatchesIssuer(){} // RVA: 0x7B17C03C0
        public void ToAsn1Object(){} // RVA: 0x7A80F2570
        public void Equals(){} // RVA: 0x7B17C0410
        public void GetHashCode(){} // RVA: 0x7B17C0510
        public void DeriveCertificateID(){} // RVA: 0x7B17C0560
        public void CreateCertID(){} // RVA: 0x7B17C07B0
    }

    public class CertificateStatus : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class OCSPRespGenerator : Object
    {
        // ── Methods ──
        public void Generate(){} // RVA: 0x7B17C38A0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class OcscpRespStatus : OcspRespStatus
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class OcspException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B17C0C20
    }

    public class OcspReq : X509ExtensionBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B17C0DE0
        public void GetTbsRequest(){} // RVA: 0x7B17C0F70
        public void get_Version(){} // RVA: 0x7B128DBE0
        public void get_RequestorName(){} // RVA: 0x7B17C1010
        public void GetRequestList(){} // RVA: 0x7B17C1040
        public void get_RequestExtensions(){} // RVA: 0x7B17C1250
        public void GetX509Extensions(){} // RVA: 0x7B17C1250
        public void get_SignatureAlgOid(){} // RVA: 0x7B17C12C0
        public void GetSignature(){} // RVA: 0x7B17C1310
        public void GetCertList(){} // RVA: 0x7B17C1360
        public void GetCerts(){} // RVA: 0x7B17C16A0
        public void GetCertificates(){} // RVA: 0x7B17C19D0
        public void get_IsSigned(){} // RVA: 0x7B17C1B00
        public void Verify(){} // RVA: 0x7B17C1B20
        public void GetEncoded(){} // RVA: 0x7B128E860
    }

    public class OcspReqGenerator : Object
    {
        // ── Methods ──
        public void AddRequest(){} // RVA: 0x7B17C1E80
        public void SetRequestorName(){} // RVA: 0x7A813E420
        public void SetRequestExtensions(){} // RVA: 0x7A81052D0
        public void GenerateRequest(){} // RVA: 0x7B17C2090
        public void Generate(){} // RVA: 0x7B17C2DB0
        public void get_SignatureAlgNames(){} // RVA: 0x7B17C3070
        public void .ctor(){} // RVA: 0x7B17C30C0
    }

    public class OcspResp : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B17C3460
        public void get_Status(){} // RVA: 0x7B17C3580
        public void GetResponseObject(){} // RVA: 0x7B17C35F0
        public void GetEncoded(){} // RVA: 0x7B128E860
        public void Equals(){} // RVA: 0x7B17C37E0
        public void GetHashCode(){} // RVA: 0x7A8738190
    }

    public class OcspRespStatus : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class OcspUtilities : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7B17C3E20
        public void GetAlgorithmOid(){} // RVA: 0x7B17C5530
        public void GetAlgorithmName(){} // RVA: 0x7B17C56C0
        public void GetSigAlgID(){} // RVA: 0x7B17C57E0
        public void get_AlgNames(){} // RVA: 0x7B17C5960
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class Req : X509ExtensionBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void GetCertID(){} // RVA: 0x7B17C5AB0
        public void get_SingleRequestExtensions(){} // RVA: 0x7A88F4330
        public void GetX509Extensions(){} // RVA: 0x7A88F4330
    }

    public class RespData : X509ExtensionBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void get_Version(){} // RVA: 0x7B15605F0
        public void GetResponderId(){} // RVA: 0x7B17C5BA0
        public void get_ProducedAt(){} // RVA: 0x7B17C5C40
        public void GetResponses(){} // RVA: 0x7B17C5C70
        public void get_ResponseExtensions(){} // RVA: 0x7A88F3B10
        public void GetX509Extensions(){} // RVA: 0x7A88F3B10
    }

    public class RespID : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B17C5FC0
        public void ToAsn1Object(){} // RVA: 0x7A80F2570
        public void Equals(){} // RVA: 0x7B17C6300
        public void GetHashCode(){} // RVA: 0x7A8738190
    }

    public class RevokedStatus : CertificateStatus
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B17C63C0
        public void get_RevocationTime(){} // RVA: 0x7B17C6520
        public void get_HasRevocationReason(){} // RVA: 0x7B17C1B00
        public void get_RevocationReason(){} // RVA: 0x7B17C6550
    }

    public class SingleResp : X509ExtensionBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void GetCertID(){} // RVA: 0x7B17C6610
        public void GetCertStatus(){} // RVA: 0x7B17C6700
        public void get_ThisUpdate(){} // RVA: 0x7B17C6800
        public void get_NextUpdate(){} // RVA: 0x7B17C6830
        public void get_SingleExtensions(){} // RVA: 0x7A88F42F0
        public void GetX509Extensions(){} // RVA: 0x7A88F42F0
    }

    public class UnknownStatus : CertificateStatus
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

}