// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Ocsp
// Classes: 18
// Methods: 125

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Ocsp
{
    public class BasicOcspResp
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC431270
        public void GetTbsResponseData(){} // RVA: 0x7FFAFC431350
        public void get_Version(){} // RVA: 0x7FFAFC4313E0
        public void get_ResponderId(){} // RVA: 0x7FFAFC431450
        public void get_ProducedAt(){} // RVA: 0x7FFAFC4314F0
        public void get_Responses(){} // RVA: 0x7FFAFC431520
        public void get_ResponseExtensions(){} // RVA: 0x7FFAF8B1D2D0
        public void GetX509Extensions(){} // RVA: 0x7FFAF8B1D2D0
        public void get_SignatureAlgName(){} // RVA: 0x7FFAFC431730
        public void get_SignatureAlgOid(){} // RVA: 0x7FFAFBEFDA40
        public void GetResponseData(){} // RVA: 0x7FFAFC4318B0
        public void GetSignature(){} // RVA: 0x7FFAFBEFD8D0
        public void GetCertList(){} // RVA: 0x7FFAFC431950
        public void GetCerts(){} // RVA: 0x7FFAFC431CD0
        public void GetCertificates(){} // RVA: 0x7FFAFC431FD0
        public void Verify(){} // RVA: 0x7FFAFC4320E0
        public void GetEncoded(){} // RVA: 0x7FFAFBF0AC10
        public void Equals(){} // RVA: 0x7FFAFC432450
        public void GetHashCode(){} // RVA: 0x7FFAF344E0E0
    }

    public class BasicOcspRespGenerator
    {
        public object HashAlgOid;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC432660 | overloaded x2
        public void AddResponse(){} // RVA: 0x7FFAFC432AE0 | overloaded x4
        public void SetResponseExtensions(){} // RVA: 0x7FFAF2DF3E80
        public void GenerateResponse(){} // RVA: 0x7FFAFC432BC0
        public void Generate(){} // RVA: 0x7FFAFC433A80 | overloaded x3
        public void get_SignatureAlgNames(){} // RVA: 0x7FFAFC433AF0
    }

    public class CertificateID
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC434430 | overloaded x2
        public void get_HashAlgOid(){} // RVA: 0x7FFAFC434650
        public void GetIssuerNameHash(){} // RVA: 0x7FFAFC3675B0
        public void GetIssuerKeyHash(){} // RVA: 0x7FFAFC434690
        public void get_SerialNumber(){} // RVA: 0x7FFAFC1A1710
        public void MatchesIssuer(){} // RVA: 0x7FFAFC4346D0
        public void ToAsn1Object(){} // RVA: 0x7FFAF2DA8380
        public void Equals(){} // RVA: 0x7FFAFC434720
        public void GetHashCode(){} // RVA: 0x7FFAFC434840
        public void DeriveCertificateID(){} // RVA: 0x7FFAFC434890
        public void CreateCertID(){} // RVA: 0x7FFAFC434AE0
    }

    public class CertificateStatus
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class OCSPRespGenerator
    {
        // ── Methods ──
        public void Generate(){} // RVA: 0x7FFAFC437A80
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class OcscpRespStatus
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class OcspException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC434F40 | overloaded x3
    }

    public class OcspReq
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC435100 | overloaded x4
        public void GetTbsRequest(){} // RVA: 0x7FFAFC435290
        public void get_Version(){} // RVA: 0x7FFAFBF09FA0
        public void get_RequestorName(){} // RVA: 0x7FFAFC435330
        public void GetRequestList(){} // RVA: 0x7FFAFC435360
        public void get_RequestExtensions(){} // RVA: 0x7FFAFC435580
        public void GetX509Extensions(){} // RVA: 0x7FFAFC435580
        public void get_SignatureAlgOid(){} // RVA: 0x7FFAFC4355F0
        public void GetSignature(){} // RVA: 0x7FFAFC435640
        public void GetCertList(){} // RVA: 0x7FFAFC435690
        public void GetCerts(){} // RVA: 0x7FFAFC4359D0
        public void GetCertificates(){} // RVA: 0x7FFAFC435CF0
        public void get_IsSigned(){} // RVA: 0x7FFAFC435E20
        public void Verify(){} // RVA: 0x7FFAFC435E40
        public void GetEncoded(){} // RVA: 0x7FFAFBF0AC10
    }

    public class OcspReqGenerator
    {
        public object Status;

        // ── Methods ──
        public void AddRequest(){} // RVA: 0x7FFAFC4361A0 | overloaded x2
        public void SetRequestorName(){} // RVA: 0x7FFAF2DF3E80 | overloaded x2
        public void SetRequestExtensions(){} // RVA: 0x7FFAF2DBB0D0
        public void GenerateRequest(){} // RVA: 0x7FFAFC4363B0
        public void Generate(){} // RVA: 0x7FFAFC436F80 | overloaded x3
        public void get_SignatureAlgNames(){} // RVA: 0x7FFAFC437240
        public void .ctor(){} // RVA: 0x7FFAFC437290
    }

    public class OcspResp
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC437630 | overloaded x4
        public void get_Status(){} // RVA: 0x7FFAFC437750
        public void GetResponseObject(){} // RVA: 0x7FFAFC4377C0
        public void GetEncoded(){} // RVA: 0x7FFAFBF0AC10
        public void Equals(){} // RVA: 0x7FFAFC4379B0
        public void GetHashCode(){} // RVA: 0x7FFAF344E0E0
    }

    public class OcspRespStatus
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class OcspUtilities
    {
        public object SingleRequestExtensions;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAFC437FA0
        public void GetAlgorithmOid(){} // RVA: 0x7FFAFC4396B0
        public void GetAlgorithmName(){} // RVA: 0x7FFAFC439840
        public void GetSigAlgID(){} // RVA: 0x7FFAFC439960
        public void get_AlgNames(){} // RVA: 0x7FFAFC439AE0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class Req
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void GetCertID(){} // RVA: 0x7FFAFC439C30
        public void get_SingleRequestExtensions(){} // RVA: 0x7FFAF35DEEA0
        public void GetX509Extensions(){} // RVA: 0x7FFAF35DEEA0
    }

    public class RespData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void get_Version(){} // RVA: 0x7FFAFC1D6AE0
        public void GetResponderId(){} // RVA: 0x7FFAFC439D20
        public void get_ProducedAt(){} // RVA: 0x7FFAFC439DC0
        public void GetResponses(){} // RVA: 0x7FFAFC439DF0
        public void get_ResponseExtensions(){} // RVA: 0x7FFAF35DE770
        public void GetX509Extensions(){} // RVA: 0x7FFAF35DE770
    }

    public class RespID
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC43A150 | overloaded x3
        public void ToAsn1Object(){} // RVA: 0x7FFAF2DA8380
        public void Equals(){} // RVA: 0x7FFAFC43A440
        public void GetHashCode(){} // RVA: 0x7FFAF344E0E0
    }

    public class RevokedStatus
    {
        public object ThisUpdate;
        public object NextUpdate;
        public object SingleExtensions;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC43A510 | overloaded x2
        public void get_RevocationTime(){} // RVA: 0x7FFAFC43A670
        public void get_HasRevocationReason(){} // RVA: 0x7FFAFC435E20
        public void get_RevocationReason(){} // RVA: 0x7FFAFC43A6A0
    }

    public class SingleResp
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void GetCertID(){} // RVA: 0x7FFAFC43A760
        public void GetCertStatus(){} // RVA: 0x7FFAFC43A850
        public void get_ThisUpdate(){} // RVA: 0x7FFAFC43A950
        public void get_NextUpdate(){} // RVA: 0x7FFAFC43A980
        public void get_SingleExtensions(){} // RVA: 0x7FFAF35DEE60
        public void GetX509Extensions(){} // RVA: 0x7FFAF35DEE60
    }

    public class UnknownStatus
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

}