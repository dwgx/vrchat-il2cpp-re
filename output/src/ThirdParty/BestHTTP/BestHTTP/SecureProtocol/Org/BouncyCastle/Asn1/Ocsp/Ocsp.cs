// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp
// Classes: 17
// Methods: 99

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp
{
    public class BasicOcspResponse : Asn1Encodable
    {
        public object tbsResponseData;
        public object signatureAlgorithm;
        public object signature;
        public object certs;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA42A660
        public void .ctor(){} // RVA: 0xA42A830
        public void GetTbsResponseData(){} // RVA: 0xB5DBF0
        public void get_TbsResponseData(){} // RVA: 0xB5DBF0
        public void GetSignatureAlgorithm(){} // RVA: 0xB465B0
        public void get_SignatureAlgorithm(){} // RVA: 0xB465B0
        public void GetSignature(){} // RVA: 0xB700F0
        public void get_Signature(){} // RVA: 0xB700F0
        public void GetSignatureOctets(){} // RVA: 0x718D460
        public void GetCerts(){} // RVA: 0xB70160
        public void get_Certs(){} // RVA: 0xB70160
        public void ToAsn1Object(){} // RVA: 0xA42ABA0
    }

    public class CertID : Asn1Encodable
    {
        public object hashAlgorithm;
        public object issuerNameHash;
        public object issuerKeyHash;
        public object serialNumber;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA42AE90
        public void .ctor(){} // RVA: 0xA42B060
        public void get_HashAlgorithm(){} // RVA: 0xB5DBF0
        public void get_IssuerNameHash(){} // RVA: 0xB465B0
        public void get_IssuerKeyHash(){} // RVA: 0xB700F0
        public void get_SerialNumber(){} // RVA: 0xB70160
        public void ToAsn1Object(){} // RVA: 0xA42B2E0
    }

    public class CertStatus : Asn1Encodable
    {
        public object tagNo;
        public object value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA42B530
        public void GetInstance(){} // RVA: 0xA42B720
        public void get_TagNo(){} // RVA: 0xB8F8F0
        public void get_Status(){} // RVA: 0xB465B0
        public void ToAsn1Object(){} // RVA: 0xA42B8F0
    }

    public class CrlID : Asn1Encodable
    {
        public object crlUrl;
        public object crlNum;
        public object crlTime;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA42B970
        public void get_CrlUrl(){} // RVA: 0xB5DBF0
        public void get_CrlNum(){} // RVA: 0xB465B0
        public void get_CrlTime(){} // RVA: 0xB700F0
        public void ToAsn1Object(){} // RVA: 0xA42BD00
    }

    public class OcspObjectIdentifiers : Object
    {
        public object PkixOcspId;
        public object PkixOcsp;
        public object PkixOcspBasic;
        public object PkixOcspNonce;
        public object PkixOcspCrl;
        public object PkixOcspResponse;
        public object PkixOcspNocheck;
        public object PkixOcspArchiveCutoff;
        public object PkixOcspServiceLocator;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA42C070
    }

    public class OcspRequest : Asn1Encodable
    {
        public object tbsRequest;
        public object optionalSignature;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA42C780
        public void .ctor(){} // RVA: 0xA42CA60
        public void get_TbsRequest(){} // RVA: 0xB5DBF0
        public void get_OptionalSignature(){} // RVA: 0xB465B0
        public void ToAsn1Object(){} // RVA: 0xA42CC40
    }

    public class OcspResponse : Asn1Encodable
    {
        public object responseStatus;
        public object responseBytes;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA42CEA0
        public void .ctor(){} // RVA: 0xA42D180
        public void get_ResponseStatus(){} // RVA: 0xB5DBF0
        public void get_ResponseBytes(){} // RVA: 0xB465B0
        public void ToAsn1Object(){} // RVA: 0xA42D430
    }

    public class OcspResponseStatus : DerEnumerated
    {
        public object Successful;
        public object MalformedRequest;
        public object InternalError;
        public object TryLater;
        public object SignatureRequired;
        public object Unauthorized;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA42D6D0
    }

    public class Request : Asn1Encodable
    {
        public object reqCert;
        public object singleRequestExtensions;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA42D7A0
        public void .ctor(){} // RVA: 0xA42DA80
        public void get_ReqCert(){} // RVA: 0xB5DBF0
        public void get_SingleRequestExtensions(){} // RVA: 0xB465B0
        public void ToAsn1Object(){} // RVA: 0xA42DC50
    }

    public class ResponderID : Asn1Encodable
    {
        public object id;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA42E500
        public void .ctor(){} // RVA: 0xA42E450
        public void GetKeyHash(){} // RVA: 0xA42E550
        public void get_Name(){} // RVA: 0xA42E600
        public void ToAsn1Object(){} // RVA: 0xA42E6A0
    }

    public class ResponseBytes : Asn1Encodable
    {
        public object responseType;
        public object response;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA42E8A0
        public void .ctor(){} // RVA: 0xA42EBE0
        public void get_ResponseType(){} // RVA: 0xB5DBF0
        public void get_Response(){} // RVA: 0xB465B0
        public void ToAsn1Object(){} // RVA: 0xA42EDB0
    }

    public class ResponseData : Asn1Encodable
    {
        public object V1;
        public object versionPresent;
        public object version;
        public object responderID;
        public object producedAt;
        public object responses;
        public object responseExtensions;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA42EF30
        public void .ctor(){} // RVA: 0xA42F4D0
        public void get_Version(){} // RVA: 0xB465B0
        public void get_ResponderID(){} // RVA: 0xB700F0
        public void get_ProducedAt(){} // RVA: 0xB70160
        public void get_Responses(){} // RVA: 0xD33E60
        public void get_ResponseExtensions(){} // RVA: 0xD05CA0
        public void ToAsn1Object(){} // RVA: 0xA42FAF0
        public void .cctor(){} // RVA: 0xA42FED0
    }

    public class RevokedInfo : Asn1Encodable
    {
        public object revocationTime;
        public object revocationReason;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA42FFB0
        public void .ctor(){} // RVA: 0xA4302A0
        public void get_RevocationTime(){} // RVA: 0xB5DBF0
        public void get_RevocationReason(){} // RVA: 0xB465B0
        public void ToAsn1Object(){} // RVA: 0xA4305D0
    }

    public class ServiceLocator : Asn1Encodable
    {
        public object issuer;
        public object locator;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA430830
        public void .ctor(){} // RVA: 0xA430DB0
        public void get_Issuer(){} // RVA: 0xB5DBF0
        public void get_Locator(){} // RVA: 0xB465B0
        public void ToAsn1Object(){} // RVA: 0xA430F40
    }

    public class Signature : Asn1Encodable
    {
        public object signatureAlgorithm;
        public object signatureValue;
        public object certs;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA431170
        public void .ctor(){} // RVA: 0xA431520
        public void get_SignatureAlgorithm(){} // RVA: 0xB5DBF0
        public void get_SignatureValue(){} // RVA: 0xB465B0
        public void GetSignatureOctets(){} // RVA: 0x71DA010
        public void get_Certs(){} // RVA: 0xB700F0
        public void ToAsn1Object(){} // RVA: 0xA4317F0
    }

    public class SingleResponse : Asn1Encodable
    {
        public object certID;
        public object certStatus;
        public object thisUpdate;
        public object nextUpdate;
        public object singleExtensions;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA431A70
        public void GetInstance(){} // RVA: 0xA432030
        public void get_CertId(){} // RVA: 0xB5DBF0
        public void get_CertStatus(){} // RVA: 0xB465B0
        public void get_ThisUpdate(){} // RVA: 0xB700F0
        public void get_NextUpdate(){} // RVA: 0xB70160
        public void get_SingleExtensions(){} // RVA: 0xD33E60
        public void ToAsn1Object(){} // RVA: 0xA432200
    }

    public class TbsRequest : Asn1Encodable
    {
        public object V1;
        public object version;
        public object requestorName;
        public object requestList;
        public object requestExtensions;
        public object versionSet;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA432600
        public void .ctor(){} // RVA: 0xA4329A0
        public void get_Version(){} // RVA: 0xB5DBF0
        public void get_RequestorName(){} // RVA: 0xB465B0
        public void get_RequestList(){} // RVA: 0xB700F0
        public void get_RequestExtensions(){} // RVA: 0xB70160
        public void ToAsn1Object(){} // RVA: 0xA432FA0
        public void .cctor(){} // RVA: 0xA433370
    }

}