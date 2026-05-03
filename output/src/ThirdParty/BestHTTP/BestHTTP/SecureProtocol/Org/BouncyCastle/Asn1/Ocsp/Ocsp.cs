// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp
// Classes: 17
// Methods: 133

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp
{
    public class BasicOcspResponse : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp.ResponseData tbsResponseData; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier signatureAlgorithm; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerBitString signature; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence certs; // 0x28

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A1E70F0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A1E72C0 | overloaded x2
        public void GetTbsResponseData(){} // RVA: 0x7FFE81116380
        public void get_TbsResponseData(){} // RVA: 0x7FFE81116380
        public void GetSignatureAlgorithm(){} // RVA: 0x7FFE810FE7C0
        public void get_SignatureAlgorithm(){} // RVA: 0x7FFE810FE7C0
        public void GetSignature(){} // RVA: 0x7FFE811290C0
        public void get_Signature(){} // RVA: 0x7FFE811290C0
        public void GetSignatureOctets(){} // RVA: 0x7FFE87264760
        public void GetCerts(){} // RVA: 0x7FFE81129130
        public void get_Certs(){} // RVA: 0x7FFE81129130
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1E7630
    }

    public class CertID : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier hashAlgorithm; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString issuerNameHash; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString issuerKeyHash; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger serialNumber; // 0x28

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A1E7920 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A1E7AF0 | overloaded x2
        public void get_HashAlgorithm(){} // RVA: 0x7FFE81116380
        public void get_IssuerNameHash(){} // RVA: 0x7FFE810FE7C0
        public void get_IssuerKeyHash(){} // RVA: 0x7FFE811290C0
        public void get_SerialNumber(){} // RVA: 0x7FFE81129130
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1E7D70
    }

    public class CertStatus : Asn1Encodable
    {
        public int tagNo; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable value; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A1E7FC0 | overloaded x4
        public void GetInstance(){} // RVA: 0x7FFE8A1E81B0
        public void get_TagNo(){} // RVA: 0x7FFE811485C0
        public void get_Status(){} // RVA: 0x7FFE810FE7C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1E8380
    }

    public class CrlID : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerIA5String crlUrl; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger crlNum; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerGeneralizedTime crlTime; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A1E8400
        public void get_CrlUrl(){} // RVA: 0x7FFE81116380
        public void get_CrlNum(){} // RVA: 0x7FFE810FE7C0
        public void get_CrlTime(){} // RVA: 0x7FFE811290C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1E87A0
    }

    public class OcspObjectIdentifiers : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE8A1E8B00
    }

    public class OcspRequest : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp.TbsRequest tbsRequest; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp.Signature optionalSignature; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A1E9210 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A1E94F0 | overloaded x2
        public void get_TbsRequest(){} // RVA: 0x7FFE81116380
        public void get_OptionalSignature(){} // RVA: 0x7FFE810FE7C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1E96D0
    }

    public class OcspResponse : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp.OcspResponseStatus responseStatus; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp.ResponseBytes responseBytes; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A1E9930 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A1E9C10 | overloaded x2
        public void get_ResponseStatus(){} // RVA: 0x7FFE81116380
        public void get_ResponseBytes(){} // RVA: 0x7FFE810FE7C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1E9EC0
    }

    public class OcspResponseStatus : DerEnumerated
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A1EA160 | overloaded x2
    }

    public class Request : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp.CertID reqCert; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Extensions singleRequestExtensions; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A1EA230 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A1EA510 | overloaded x2
        public void get_ReqCert(){} // RVA: 0x7FFE81116380
        public void get_SingleRequestExtensions(){} // RVA: 0x7FFE810FE7C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1EA6E0
    }

    public class ResponderID : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable id; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A1EAD90 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A1EACE0 | overloaded x2
        public void GetKeyHash(){} // RVA: 0x7FFE8A1EADE0
        public void get_Name(){} // RVA: 0x7FFE8A1EAE90
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1EAF30
    }

    public class ResponseBytes : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier responseType; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString response; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A1EB120 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A1EB460 | overloaded x2
        public void get_ResponseType(){} // RVA: 0x7FFE81116380
        public void get_Response(){} // RVA: 0x7FFE810FE7C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1EB630
    }

    public class ResponseData : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger V1;
        public bool versionPresent; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger version; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp.ResponderID responderID; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerGeneralizedTime producedAt; // 0x28

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A1EB7B0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A1EBBE0 | overloaded x3
        public void get_Version(){} // RVA: 0x7FFE810FE7C0
        public void get_ResponderID(){} // RVA: 0x7FFE811290C0
        public void get_ProducedAt(){} // RVA: 0x7FFE81129130
        public void get_Responses(){} // RVA: 0x7FFE8144E200
        public void get_ResponseExtensions(){} // RVA: 0x7FFE8143BA80
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1EC200
        public void .cctor(){} // RVA: 0x7FFE8A1EC5E0
    }

    public class RevokedInfo : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerGeneralizedTime revocationTime; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.CrlReason revocationReason; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A1EC6C0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A1EC9B0 | overloaded x3
        public void get_RevocationTime(){} // RVA: 0x7FFE81116380
        public void get_RevocationReason(){} // RVA: 0x7FFE810FE7C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1ECCE0
    }

    public class ServiceLocator : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Name issuer; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Object locator; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A1ECF40 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A1ED4A0 | overloaded x3
        public void get_Issuer(){} // RVA: 0x7FFE81116380
        public void get_Locator(){} // RVA: 0x7FFE810FE7C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1ED630
    }

    public class Signature : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier signatureAlgorithm; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerBitString signatureValue; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence certs; // 0x20

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A1ED850 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A1EDC00 | overloaded x3
        public void get_SignatureAlgorithm(){} // RVA: 0x7FFE81116380
        public void get_SignatureValue(){} // RVA: 0x7FFE810FE7C0
        public void GetSignatureOctets(){} // RVA: 0x7FFE872B2BD0
        public void get_Certs(){} // RVA: 0x7FFE811290C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1EDED0
    }

    public class SingleResponse : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp.CertID certID; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp.CertStatus certStatus; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerGeneralizedTime thisUpdate; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerGeneralizedTime nextUpdate; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Extensions singleExtensions; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A1EE150 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFE8A1EE710 | overloaded x2
        public void get_CertId(){} // RVA: 0x7FFE81116380
        public void get_CertStatus(){} // RVA: 0x7FFE810FE7C0
        public void get_ThisUpdate(){} // RVA: 0x7FFE811290C0
        public void get_NextUpdate(){} // RVA: 0x7FFE81129130
        public void get_SingleExtensions(){} // RVA: 0x7FFE8144E200
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1EE8E0
    }

    public class TbsRequest : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger V1;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.GeneralName requestorName; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence requestList; // 0x20

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A1EECE0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A1EF080 | overloaded x2
        public void get_Version(){} // RVA: 0x7FFE81116380
        public void get_RequestorName(){} // RVA: 0x7FFE810FE7C0
        public void get_RequestList(){} // RVA: 0x7FFE811290C0
        public void get_RequestExtensions(){} // RVA: 0x7FFE81129130
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1EF680
        public void .cctor(){} // RVA: 0x7FFE8A1EFA40
    }

}