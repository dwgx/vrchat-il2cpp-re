// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp
// Classes: 17
// Methods: 133

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp
{
    public class BasicOcspResponse
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp.ResponseData tbsResponseData; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier signatureAlgorithm; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerBitString signature; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence certs; // 0x28

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x9784CF0 | overloaded x2
        public void .ctor(){} // RVA: 0x9784EC0 | overloaded x2
        public void GetTbsResponseData(){} // RVA: 0x2F8380
        public void get_TbsResponseData(){} // RVA: 0x2F8380
        public void GetSignatureAlgorithm(){} // RVA: 0x2E07C0
        public void get_SignatureAlgorithm(){} // RVA: 0x2E07C0
        public void GetSignature(){} // RVA: 0x30B0C0
        public void get_Signature(){} // RVA: 0x30B0C0
        public void GetSignatureOctets(){} // RVA: 0x6725860
        public void GetCerts(){} // RVA: 0x30B130
        public void get_Certs(){} // RVA: 0x30B130
        public void ToAsn1Object(){} // RVA: 0x9785230
    }

    public class CertID
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier hashAlgorithm; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString issuerNameHash; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString issuerKeyHash; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger serialNumber; // 0x28

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x9785520 | overloaded x2
        public void .ctor(){} // RVA: 0x97856F0 | overloaded x2
        public void get_HashAlgorithm(){} // RVA: 0x2F8380
        public void get_IssuerNameHash(){} // RVA: 0x2E07C0
        public void get_IssuerKeyHash(){} // RVA: 0x30B0C0
        public void get_SerialNumber(){} // RVA: 0x30B130
        public void ToAsn1Object(){} // RVA: 0x9785970
    }

    public class CertStatus
    {
        public int tagNo; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable value; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9785BC0 | overloaded x4
        public void GetInstance(){} // RVA: 0x9785DB0
        public void get_TagNo(){} // RVA: 0x32A5C0
        public void get_Status(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x9785F80
    }

    public class CrlID
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerIA5String crlUrl; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger crlNum; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerGeneralizedTime crlTime; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9786000
        public void get_CrlUrl(){} // RVA: 0x2F8380
        public void get_CrlNum(){} // RVA: 0x2E07C0
        public void get_CrlTime(){} // RVA: 0x30B0C0
        public void ToAsn1Object(){} // RVA: 0x97863A0
    }

    public class OcspObjectIdentifiers
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x9786700
    }

    public class OcspRequest
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp.TbsRequest tbsRequest; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp.Signature optionalSignature; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x9786E10 | overloaded x2
        public void .ctor(){} // RVA: 0x97870F0 | overloaded x2
        public void get_TbsRequest(){} // RVA: 0x2F8380
        public void get_OptionalSignature(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x97872D0
    }

    public class OcspResponse
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp.OcspResponseStatus responseStatus; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp.ResponseBytes responseBytes; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x9787530 | overloaded x2
        public void .ctor(){} // RVA: 0x9787810 | overloaded x2
        public void get_ResponseStatus(){} // RVA: 0x2F8380
        public void get_ResponseBytes(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x9787AC0
    }

    public class OcspResponseStatus
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9787D60 | overloaded x2
    }

    public class Request
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp.CertID reqCert; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Extensions singleRequestExtensions; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x9787E30 | overloaded x2
        public void .ctor(){} // RVA: 0x9788110 | overloaded x2
        public void get_ReqCert(){} // RVA: 0x2F8380
        public void get_SingleRequestExtensions(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x97882E0
    }

    public class ResponderID
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable id; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x9788990 | overloaded x2
        public void .ctor(){} // RVA: 0x97888E0 | overloaded x2
        public void GetKeyHash(){} // RVA: 0x97889E0
        public void get_Name(){} // RVA: 0x9788A90
        public void ToAsn1Object(){} // RVA: 0x9788B30
    }

    public class ResponseBytes
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier responseType; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString response; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x9788D20 | overloaded x2
        public void .ctor(){} // RVA: 0x9789060 | overloaded x2
        public void get_ResponseType(){} // RVA: 0x2F8380
        public void get_Response(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x9789230
    }

    public class ResponseData
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger V1;
        public bool versionPresent; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger version; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp.ResponderID responderID; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerGeneralizedTime producedAt; // 0x28

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x97893B0 | overloaded x2
        public void .ctor(){} // RVA: 0x97897E0 | overloaded x3
        public void get_Version(){} // RVA: 0x2E07C0
        public void get_ResponderID(){} // RVA: 0x30B0C0
        public void get_ProducedAt(){} // RVA: 0x30B130
        public void get_Responses(){} // RVA: 0x6374D0
        public void get_ResponseExtensions(){} // RVA: 0x4976A0
        public void ToAsn1Object(){} // RVA: 0x9789E00
        public void .cctor(){} // RVA: 0x978A1E0
    }

    public class RevokedInfo
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerGeneralizedTime revocationTime; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.CrlReason revocationReason; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x978A2C0 | overloaded x2
        public void .ctor(){} // RVA: 0x978A5B0 | overloaded x3
        public void get_RevocationTime(){} // RVA: 0x2F8380
        public void get_RevocationReason(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x978A8E0
    }

    public class ServiceLocator
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Name issuer; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Object locator; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x978AB40 | overloaded x2
        public void .ctor(){} // RVA: 0x978B0A0 | overloaded x3
        public void get_Issuer(){} // RVA: 0x2F8380
        public void get_Locator(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x978B230
    }

    public class Signature
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier signatureAlgorithm; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerBitString signatureValue; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence certs; // 0x20

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x978B450 | overloaded x2
        public void .ctor(){} // RVA: 0x978B800 | overloaded x3
        public void get_SignatureAlgorithm(){} // RVA: 0x2F8380
        public void get_SignatureValue(){} // RVA: 0x2E07C0
        public void GetSignatureOctets(){} // RVA: 0x6773CD0
        public void get_Certs(){} // RVA: 0x30B0C0
        public void ToAsn1Object(){} // RVA: 0x978BAD0
    }

    public class SingleResponse
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp.CertID certID; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp.CertStatus certStatus; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerGeneralizedTime thisUpdate; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerGeneralizedTime nextUpdate; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Extensions singleExtensions; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x978BD50 | overloaded x2
        public void GetInstance(){} // RVA: 0x978C310 | overloaded x2
        public void get_CertId(){} // RVA: 0x2F8380
        public void get_CertStatus(){} // RVA: 0x2E07C0
        public void get_ThisUpdate(){} // RVA: 0x30B0C0
        public void get_NextUpdate(){} // RVA: 0x30B130
        public void get_SingleExtensions(){} // RVA: 0x6374D0
        public void ToAsn1Object(){} // RVA: 0x978C4E0
    }

    public class TbsRequest
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger V1;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.GeneralName requestorName; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence requestList; // 0x20

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x978C8E0 | overloaded x2
        public void .ctor(){} // RVA: 0x978CC80 | overloaded x2
        public void get_Version(){} // RVA: 0x2F8380
        public void get_RequestorName(){} // RVA: 0x2E07C0
        public void get_RequestList(){} // RVA: 0x30B0C0
        public void get_RequestExtensions(){} // RVA: 0x30B130
        public void ToAsn1Object(){} // RVA: 0x978D280
        public void .cctor(){} // RVA: 0x978D640
    }

}