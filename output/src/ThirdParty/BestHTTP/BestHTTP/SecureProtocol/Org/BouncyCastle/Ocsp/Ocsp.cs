// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Ocsp
// Classes: 18
// Methods: 103

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Ocsp
{
    public class BasicOcspResp : X509ExtensionBase
    {
        public object resp;
        public object data;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA628D50
        public void GetTbsResponseData(){} // RVA: 0xA628E30
        public void get_Version(){} // RVA: 0xA628EC0
        public void get_ResponderId(){} // RVA: 0xA628F30
        public void get_ProducedAt(){} // RVA: 0xA628FD0
        public void get_Responses(){} // RVA: 0xA629000
        public void get_ResponseExtensions(){} // RVA: 0x6AE0BB0
        public void GetX509Extensions(){} // RVA: 0x6AE0BB0
        public void get_SignatureAlgName(){} // RVA: 0xA629200
        public void get_SignatureAlgOid(){} // RVA: 0xA0ECF90
        public void GetResponseData(){} // RVA: 0xA629370
        public void GetSignature(){} // RVA: 0xA0ECE30
        public void GetCertList(){} // RVA: 0xA629410
        public void GetCerts(){} // RVA: 0xA629790
        public void GetCertificates(){} // RVA: 0xA629A90
        public void Verify(){} // RVA: 0xA629BA0
        public void GetEncoded(){} // RVA: 0xA0FA1B0
        public void Equals(){} // RVA: 0xA629F00
        public void GetHashCode(){} // RVA: 0x1269730
    }

    public class BasicOcspRespGenerator : Object
    {
        public object list;
        public object responseExtensions;
        public object responderID;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA62A100
        public void AddResponse(){} // RVA: 0xA62A580
        public void SetResponseExtensions(){} // RVA: 0xBA9BA0
        public void GenerateResponse(){} // RVA: 0xA62A660
        public void Generate(){} // RVA: 0xA62B4C0
        public void get_SignatureAlgNames(){} // RVA: 0xA62B530
    }

    public class CertificateID : Object
    {
        public object HashSha1;
        public object id;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA62BFE0
        public void get_HashAlgOid(){} // RVA: 0xA62C200
        public void GetIssuerNameHash(){} // RVA: 0xA55DD00
        public void GetIssuerKeyHash(){} // RVA: 0xA62C240
        public void get_SerialNumber(){} // RVA: 0xA396550
        public void MatchesIssuer(){} // RVA: 0xA62C280
        public void ToAsn1Object(){} // RVA: 0xB5DBF0
        public void Equals(){} // RVA: 0xA62C2D0
        public void GetHashCode(){} // RVA: 0xA62C3D0
        public void DeriveCertificateID(){} // RVA: 0xA62C420
        public void CreateCertID(){} // RVA: 0xA62C670
    }

    public class CertificateStatus : Object
    {
        public object Good;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class OCSPRespGenerator : Object
    {
        public object Successful;
        public object MalformedRequest;
        public object InternalError;
        public object TryLater;
        public object SigRequired;
        public object Unauthorized;

        // ── Methods ──
        public void Generate(){} // RVA: 0xA62F760
        public void .ctor(){} // RVA: 0xB43310
    }

    public class OcscpRespStatus : OcspRespStatus
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class OcspException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA62CAE0
    }

    public class OcspReq : X509ExtensionBase
    {
        public object req;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA62CCA0
        public void GetTbsRequest(){} // RVA: 0xA62CE30
        public void get_Version(){} // RVA: 0xA0F9530
        public void get_RequestorName(){} // RVA: 0xA62CED0
        public void GetRequestList(){} // RVA: 0xA62CF00
        public void get_RequestExtensions(){} // RVA: 0xA62D110
        public void GetX509Extensions(){} // RVA: 0xA62D110
        public void get_SignatureAlgOid(){} // RVA: 0xA62D180
        public void GetSignature(){} // RVA: 0xA62D1D0
        public void GetCertList(){} // RVA: 0xA62D220
        public void GetCerts(){} // RVA: 0xA62D560
        public void GetCertificates(){} // RVA: 0xA62D890
        public void get_IsSigned(){} // RVA: 0xA62D9C0
        public void Verify(){} // RVA: 0xA62D9E0
        public void GetEncoded(){} // RVA: 0xA0FA1B0
    }

    public class OcspReqGenerator : Object
    {
        public object list;
        public object requestorName;
        public object requestExtensions;

        // ── Methods ──
        public void AddRequest(){} // RVA: 0xA62DD40
        public void SetRequestorName(){} // RVA: 0xBA9BA0
        public void SetRequestExtensions(){} // RVA: 0xB70100
        public void GenerateRequest(){} // RVA: 0xA62DF50
        public void Generate(){} // RVA: 0xA62EC70
        public void get_SignatureAlgNames(){} // RVA: 0xA62EF30
        public void .ctor(){} // RVA: 0xA62EF80
    }

    public class OcspResp : Object
    {
        public object resp;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA62F320
        public void get_Status(){} // RVA: 0xA62F440
        public void GetResponseObject(){} // RVA: 0xA62F4B0
        public void GetEncoded(){} // RVA: 0xA0FA1B0
        public void Equals(){} // RVA: 0xA62F6A0
        public void GetHashCode(){} // RVA: 0x1269730
    }

    public class OcspRespStatus : Object
    {
        public object Successful;
        public object MalformedRequest;
        public object InternalError;
        public object TryLater;
        public object SigRequired;
        public object Unauthorized;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class OcspUtilities : Object
    {
        public object algorithms;
        public object oids;
        public object noParams;

        // ── Methods ──
        public void .cctor(){} // RVA: 0xA62FCE0
        public void GetAlgorithmOid(){} // RVA: 0xA6313F0
        public void GetAlgorithmName(){} // RVA: 0xA631580
        public void GetSigAlgID(){} // RVA: 0xA631690
        public void get_AlgNames(){} // RVA: 0xA631810
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Req : X509ExtensionBase
    {
        public object req;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void GetCertID(){} // RVA: 0xA631960
        public void get_SingleRequestExtensions(){} // RVA: 0x13F9400
        public void GetX509Extensions(){} // RVA: 0x13F9400
    }

    public class RespData : X509ExtensionBase
    {
        public object data;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_Version(){} // RVA: 0xA3CBB70
        public void GetResponderId(){} // RVA: 0xA631A50
        public void get_ProducedAt(){} // RVA: 0xA631AF0
        public void GetResponses(){} // RVA: 0xA631B20
        public void get_ResponseExtensions(){} // RVA: 0x13F93E0
        public void GetX509Extensions(){} // RVA: 0x13F93E0
    }

    public class RespID : Object
    {
        public object id;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA631E70
        public void ToAsn1Object(){} // RVA: 0xB5DBF0
        public void Equals(){} // RVA: 0xA6321B0
        public void GetHashCode(){} // RVA: 0x1269730
    }

    public class RevokedStatus : CertificateStatus
    {
        public object info;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA632270
        public void get_RevocationTime(){} // RVA: 0xA6323D0
        public void get_HasRevocationReason(){} // RVA: 0xA62D9C0
        public void get_RevocationReason(){} // RVA: 0xA632400
    }

    public class SingleResp : X509ExtensionBase
    {
        public object resp;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void GetCertID(){} // RVA: 0xA6324C0
        public void GetCertStatus(){} // RVA: 0xA6325B0
        public void get_ThisUpdate(){} // RVA: 0xA6326B0
        public void get_NextUpdate(){} // RVA: 0xA6326E0
        public void get_SingleExtensions(){} // RVA: 0x13F9420
        public void GetX509Extensions(){} // RVA: 0x13F9420
    }

    public class UnknownStatus : CertificateStatus
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

}