// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp
// Classes: 17
// Methods: 133

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp
{
    public class BasicOcspResponse
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC234CF0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAFC234EC0 | overloaded x2
        public void GetTbsResponseData(){} // RVA: 0x7FFAF2DA8380
        public void get_TbsResponseData(){} // RVA: 0x7FFAF2DA8380
        public void GetSignatureAlgorithm(){} // RVA: 0x7FFAF2D907C0
        public void get_SignatureAlgorithm(){} // RVA: 0x7FFAF2D907C0
        public void GetSignature(){} // RVA: 0x7FFAF2DBB0C0
        public void get_Signature(){} // RVA: 0x7FFAF2DBB0C0
        public void GetSignatureOctets(){} // RVA: 0x7FFAF91D5860
        public void GetCerts(){} // RVA: 0x7FFAF2DBB130
        public void get_Certs(){} // RVA: 0x7FFAF2DBB130
        public void ToAsn1Object(){} // RVA: 0x7FFAFC235230
    }

    public class CertID
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC235520 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAFC2356F0 | overloaded x2
        public void get_HashAlgorithm(){} // RVA: 0x7FFAF2DA8380
        public void get_IssuerNameHash(){} // RVA: 0x7FFAF2D907C0
        public void get_IssuerKeyHash(){} // RVA: 0x7FFAF2DBB0C0
        public void get_SerialNumber(){} // RVA: 0x7FFAF2DBB130
        public void ToAsn1Object(){} // RVA: 0x7FFAFC235970
    }

    public class CertStatus
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC235BC0 | overloaded x4
        public void GetInstance(){} // RVA: 0x7FFAFC235DB0
        public void get_TagNo(){} // RVA: 0x7FFAF2DDA5C0
        public void get_Status(){} // RVA: 0x7FFAF2D907C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC235F80
    }

    public class CrlID
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC236000
        public void get_CrlUrl(){} // RVA: 0x7FFAF2DA8380
        public void get_CrlNum(){} // RVA: 0x7FFAF2D907C0
        public void get_CrlTime(){} // RVA: 0x7FFAF2DBB0C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC2363A0
    }

    public class OcspObjectIdentifiers
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAFC236700
    }

    public class OcspRequest
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC236E10 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAFC2370F0 | overloaded x2
        public void get_TbsRequest(){} // RVA: 0x7FFAF2DA8380
        public void get_OptionalSignature(){} // RVA: 0x7FFAF2D907C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC2372D0
    }

    public class OcspResponse
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC237530 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAFC237810 | overloaded x2
        public void get_ResponseStatus(){} // RVA: 0x7FFAF2DA8380
        public void get_ResponseBytes(){} // RVA: 0x7FFAF2D907C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC237AC0
    }

    public class OcspResponseStatus
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC237D60 | overloaded x2
    }

    public class Request
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC237E30 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAFC238110 | overloaded x2
        public void get_ReqCert(){} // RVA: 0x7FFAF2DA8380
        public void get_SingleRequestExtensions(){} // RVA: 0x7FFAF2D907C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC2382E0
    }

    public class ResponderID
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC238990 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAFC2388E0 | overloaded x2
        public void GetKeyHash(){} // RVA: 0x7FFAFC2389E0
        public void get_Name(){} // RVA: 0x7FFAFC238A90
        public void ToAsn1Object(){} // RVA: 0x7FFAFC238B30
    }

    public class ResponseBytes
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC238D20 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAFC239060 | overloaded x2
        public void get_ResponseType(){} // RVA: 0x7FFAF2DA8380
        public void get_Response(){} // RVA: 0x7FFAF2D907C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC239230
    }

    public class ResponseData
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC2393B0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAFC2397E0 | overloaded x3
        public void get_Version(){} // RVA: 0x7FFAF2D907C0
        public void get_ResponderID(){} // RVA: 0x7FFAF2DBB0C0
        public void get_ProducedAt(){} // RVA: 0x7FFAF2DBB130
        public void get_Responses(){} // RVA: 0x7FFAF30E74D0
        public void get_ResponseExtensions(){} // RVA: 0x7FFAF2F476A0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC239E00
        public void .cctor(){} // RVA: 0x7FFAFC23A1E0
    }

    public class RevokedInfo
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC23A2C0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAFC23A5B0 | overloaded x3
        public void get_RevocationTime(){} // RVA: 0x7FFAF2DA8380
        public void get_RevocationReason(){} // RVA: 0x7FFAF2D907C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC23A8E0
    }

    public class ServiceLocator
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC23AB40 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAFC23B0A0 | overloaded x3
        public void get_Issuer(){} // RVA: 0x7FFAF2DA8380
        public void get_Locator(){} // RVA: 0x7FFAF2D907C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC23B230
    }

    public class Signature
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC23B450 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAFC23B800 | overloaded x3
        public void get_SignatureAlgorithm(){} // RVA: 0x7FFAF2DA8380
        public void get_SignatureValue(){} // RVA: 0x7FFAF2D907C0
        public void GetSignatureOctets(){} // RVA: 0x7FFAF9223CD0
        public void get_Certs(){} // RVA: 0x7FFAF2DBB0C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC23BAD0
    }

    public class SingleResponse
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC23BD50 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFAFC23C310 | overloaded x2
        public void get_CertId(){} // RVA: 0x7FFAF2DA8380
        public void get_CertStatus(){} // RVA: 0x7FFAF2D907C0
        public void get_ThisUpdate(){} // RVA: 0x7FFAF2DBB0C0
        public void get_NextUpdate(){} // RVA: 0x7FFAF2DBB130
        public void get_SingleExtensions(){} // RVA: 0x7FFAF30E74D0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC23C4E0
    }

    public class TbsRequest
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC23C8E0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAFC23CC80 | overloaded x2
        public void get_Version(){} // RVA: 0x7FFAF2DA8380
        public void get_RequestorName(){} // RVA: 0x7FFAF2D907C0
        public void get_RequestList(){} // RVA: 0x7FFAF2DBB0C0
        public void get_RequestExtensions(){} // RVA: 0x7FFAF2DBB130
        public void ToAsn1Object(){} // RVA: 0x7FFAFC23D280
        public void .cctor(){} // RVA: 0x7FFAFC23D640
    }

}