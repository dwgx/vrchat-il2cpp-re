// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Ocsp
// Classes: 18
// Methods: 125

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Ocsp
{
    public class BasicOcspResp
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9981270
        public void GetTbsResponseData(){} // RVA: 0x9981350
        public void get_Version(){} // RVA: 0x99813E0
        public void get_ResponderId(){} // RVA: 0x9981450
        public void get_ProducedAt(){} // RVA: 0x99814F0
        public void get_Responses(){} // RVA: 0x9981520
        public void get_ResponseExtensions(){} // RVA: 0x606D2D0
        public void GetX509Extensions(){} // RVA: 0x606D2D0
        public void get_SignatureAlgName(){} // RVA: 0x9981730
        public void get_SignatureAlgOid(){} // RVA: 0x944DA40
        public void GetResponseData(){} // RVA: 0x99818B0
        public void GetSignature(){} // RVA: 0x944D8D0
        public void GetCertList(){} // RVA: 0x9981950
        public void GetCerts(){} // RVA: 0x9981CD0
        public void GetCertificates(){} // RVA: 0x9981FD0
        public void Verify(){} // RVA: 0x99820E0
        public void GetEncoded(){} // RVA: 0x945AC10
        public void Equals(){} // RVA: 0x9982450
        public void GetHashCode(){} // RVA: 0x99E0E0
    }

    public class BasicOcspRespGenerator
    {
        public object HashAlgOid;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9982660 | overloaded x2
        public void AddResponse(){} // RVA: 0x9982AE0 | overloaded x4
        public void SetResponseExtensions(){} // RVA: 0x343E80
        public void GenerateResponse(){} // RVA: 0x9982BC0
        public void Generate(){} // RVA: 0x9983A80 | overloaded x3
        public void get_SignatureAlgNames(){} // RVA: 0x9983AF0
    }

    public class CertificateID
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9984430 | overloaded x2
        public void get_HashAlgOid(){} // RVA: 0x9984650
        public void GetIssuerNameHash(){} // RVA: 0x98B75B0
        public void GetIssuerKeyHash(){} // RVA: 0x9984690
        public void get_SerialNumber(){} // RVA: 0x96F1710
        public void MatchesIssuer(){} // RVA: 0x99846D0
        public void ToAsn1Object(){} // RVA: 0x2F8380
        public void Equals(){} // RVA: 0x9984720
        public void GetHashCode(){} // RVA: 0x9984840
        public void DeriveCertificateID(){} // RVA: 0x9984890
        public void CreateCertID(){} // RVA: 0x9984AE0
    }

    public class CertificateStatus
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class OCSPRespGenerator
    {
        // ── Methods ──
        public void Generate(){} // RVA: 0x9987A80
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class OcscpRespStatus
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class OcspException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9984F40 | overloaded x3
    }

    public class OcspReq
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9985100 | overloaded x4
        public void GetTbsRequest(){} // RVA: 0x9985290
        public void get_Version(){} // RVA: 0x9459FA0
        public void get_RequestorName(){} // RVA: 0x9985330
        public void GetRequestList(){} // RVA: 0x9985360
        public void get_RequestExtensions(){} // RVA: 0x9985580
        public void GetX509Extensions(){} // RVA: 0x9985580
        public void get_SignatureAlgOid(){} // RVA: 0x99855F0
        public void GetSignature(){} // RVA: 0x9985640
        public void GetCertList(){} // RVA: 0x9985690
        public void GetCerts(){} // RVA: 0x99859D0
        public void GetCertificates(){} // RVA: 0x9985CF0
        public void get_IsSigned(){} // RVA: 0x9985E20
        public void Verify(){} // RVA: 0x9985E40
        public void GetEncoded(){} // RVA: 0x945AC10
    }

    public class OcspReqGenerator
    {
        public object Status;

        // ── Methods ──
        public void AddRequest(){} // RVA: 0x99861A0 | overloaded x2
        public void SetRequestorName(){} // RVA: 0x343E80 | overloaded x2
        public void SetRequestExtensions(){} // RVA: 0x30B0D0
        public void GenerateRequest(){} // RVA: 0x99863B0
        public void Generate(){} // RVA: 0x9986F80 | overloaded x3
        public void get_SignatureAlgNames(){} // RVA: 0x9987240
        public void .ctor(){} // RVA: 0x9987290
    }

    public class OcspResp
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9987630 | overloaded x4
        public void get_Status(){} // RVA: 0x9987750
        public void GetResponseObject(){} // RVA: 0x99877C0
        public void GetEncoded(){} // RVA: 0x945AC10
        public void Equals(){} // RVA: 0x99879B0
        public void GetHashCode(){} // RVA: 0x99E0E0
    }

    public class OcspRespStatus
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class OcspUtilities
    {
        public object SingleRequestExtensions;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x9987FA0
        public void GetAlgorithmOid(){} // RVA: 0x99896B0
        public void GetAlgorithmName(){} // RVA: 0x9989840
        public void GetSigAlgID(){} // RVA: 0x9989960
        public void get_AlgNames(){} // RVA: 0x9989AE0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class Req
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void GetCertID(){} // RVA: 0x9989C30
        public void get_SingleRequestExtensions(){} // RVA: 0xB2EEA0
        public void GetX509Extensions(){} // RVA: 0xB2EEA0
    }

    public class RespData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void get_Version(){} // RVA: 0x9726AE0
        public void GetResponderId(){} // RVA: 0x9989D20
        public void get_ProducedAt(){} // RVA: 0x9989DC0
        public void GetResponses(){} // RVA: 0x9989DF0
        public void get_ResponseExtensions(){} // RVA: 0xB2E770
        public void GetX509Extensions(){} // RVA: 0xB2E770
    }

    public class RespID
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x998A150 | overloaded x3
        public void ToAsn1Object(){} // RVA: 0x2F8380
        public void Equals(){} // RVA: 0x998A440
        public void GetHashCode(){} // RVA: 0x99E0E0
    }

    public class RevokedStatus
    {
        public object ThisUpdate;
        public object NextUpdate;
        public object SingleExtensions;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x998A510 | overloaded x2
        public void get_RevocationTime(){} // RVA: 0x998A670
        public void get_HasRevocationReason(){} // RVA: 0x9985E20
        public void get_RevocationReason(){} // RVA: 0x998A6A0
    }

    public class SingleResp
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void GetCertID(){} // RVA: 0x998A760
        public void GetCertStatus(){} // RVA: 0x998A850
        public void get_ThisUpdate(){} // RVA: 0x998A950
        public void get_NextUpdate(){} // RVA: 0x998A980
        public void get_SingleExtensions(){} // RVA: 0xB2EE60
        public void GetX509Extensions(){} // RVA: 0xB2EE60
    }

    public class UnknownStatus
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

}