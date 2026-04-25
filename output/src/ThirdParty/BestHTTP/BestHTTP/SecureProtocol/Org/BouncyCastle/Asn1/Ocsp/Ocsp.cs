// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp
// Classes: 17
// Methods: 133

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp
{
    public class BasicOcspResponse : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp.ResponseData TbsResponseData; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier SignatureAlgorithm; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerBitString Signature; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence Certs; // 0x28

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD8DAD0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBD8DCA0 | overloaded x2
        public void GetTbsResponseData(){} // RVA: 0x7FFAC2F3C380
        public void get_TbsResponseData(){} // RVA: 0x7FFAC2F3C380
        public void GetSignatureAlgorithm(){} // RVA: 0x7FFAC2F247C0
        public void get_SignatureAlgorithm(){} // RVA: 0x7FFAC2F247C0
        public void GetSignature(){} // RVA: 0x7FFAC2F4F0C0
        public void get_Signature(){} // RVA: 0x7FFAC2F4F0C0
        public void GetSignatureOctets(){} // RVA: 0x7FFAC8EBC310
        public void GetCerts(){} // RVA: 0x7FFAC2F4F130
        public void get_Certs(){} // RVA: 0x7FFAC2F4F130
        public void ToAsn1Object(){} // RVA: 0x7FFACBD8E010
    }

    public class CertID : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier HashAlgorithm; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString IssuerNameHash; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString IssuerKeyHash; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger SerialNumber; // 0x28

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD8E300 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBD8E4D0 | overloaded x2
        public void get_HashAlgorithm(){} // RVA: 0x7FFAC2F3C380
        public void get_IssuerNameHash(){} // RVA: 0x7FFAC2F247C0
        public void get_IssuerKeyHash(){} // RVA: 0x7FFAC2F4F0C0
        public void get_SerialNumber(){} // RVA: 0x7FFAC2F4F130
        public void ToAsn1Object(){} // RVA: 0x7FFACBD8E750
    }

    public class CertStatus : Asn1Encodable
    {
        public int TagNo; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable Status; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBD8E9A0 | overloaded x4
        public void GetInstance(){} // RVA: 0x7FFACBD8EB90
        public void get_TagNo(){} // RVA: 0x7FFAC2F6E5C0
        public void get_Status(){} // RVA: 0x7FFAC2F247C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBD8ED60
    }

    public class CrlID : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerIA5String CrlUrl; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger CrlNum; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerGeneralizedTime CrlTime; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBD8EDE0
        public void get_CrlUrl(){} // RVA: 0x7FFAC2F3C380
        public void get_CrlNum(){} // RVA: 0x7FFAC2F247C0
        public void get_CrlTime(){} // RVA: 0x7FFAC2F4F0C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBD8F180
    }

    public class OcspObjectIdentifiers : Object
    {
        public string PkixOcspId;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier PkixOcsp;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier PkixOcspBasic; // 0x8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier PkixOcspNonce; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier PkixOcspCrl; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier PkixOcspResponse; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier PkixOcspNocheck; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier PkixOcspArchiveCutoff; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier PkixOcspServiceLocator; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBD8F4E0
    }

    public class OcspRequest : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp.TbsRequest TbsRequest; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp.Signature OptionalSignature; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD8FBF0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBD8FED0 | overloaded x2
        public void get_TbsRequest(){} // RVA: 0x7FFAC2F3C380
        public void get_OptionalSignature(){} // RVA: 0x7FFAC2F247C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBD900B0
    }

    public class OcspResponse : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp.OcspResponseStatus ResponseStatus; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp.ResponseBytes ResponseBytes; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD90310 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBD905F0 | overloaded x2
        public void get_ResponseStatus(){} // RVA: 0x7FFAC2F3C380
        public void get_ResponseBytes(){} // RVA: 0x7FFAC2F247C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBD908A0
    }

    public class OcspResponseStatus : DerEnumerated
    {
        public int Successful;
        public int MalformedRequest;
        public int InternalError;
        public int TryLater;
        public int SignatureRequired;
        public int Unauthorized;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBD90B40 | overloaded x2
    }

    public class Request : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp.CertID ReqCert; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Extensions SingleRequestExtensions; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD90C10 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBD90EF0 | overloaded x2
        public void get_ReqCert(){} // RVA: 0x7FFAC2F3C380
        public void get_SingleRequestExtensions(){} // RVA: 0x7FFAC2F247C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBD910C0
    }

    public class ResponderID : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable Name; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD91770 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBD916C0 | overloaded x2
        public void GetKeyHash(){} // RVA: 0x7FFACBD917C0
        public void get_Name(){} // RVA: 0x7FFACBD91870
        public void ToAsn1Object(){} // RVA: 0x7FFACBD91910
    }

    public class ResponseBytes : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier ResponseType; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString Response; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD91B00 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBD91E40 | overloaded x2
        public void get_ResponseType(){} // RVA: 0x7FFAC2F3C380
        public void get_Response(){} // RVA: 0x7FFAC2F247C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBD92010
    }

    public class ResponseData : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger Version;
        public bool ResponderID; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger ProducedAt; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp.ResponderID Responses; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerGeneralizedTime ResponseExtensions; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence responses; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Extensions responseExtensions; // 0x38

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD92190 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBD925C0 | overloaded x3
        public void get_Version(){} // RVA: 0x7FFAC2F247C0
        public void get_ResponderID(){} // RVA: 0x7FFAC2F4F0C0
        public void get_ProducedAt(){} // RVA: 0x7FFAC2F4F130
        public void get_Responses(){} // RVA: 0x7FFAC31D95E0
        public void get_ResponseExtensions(){} // RVA: 0x7FFAC31D0140
        public void ToAsn1Object(){} // RVA: 0x7FFACBD92BE0
        public void .cctor(){} // RVA: 0x7FFACBD92FC0
    }

    public class RevokedInfo : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerGeneralizedTime RevocationTime; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.CrlReason RevocationReason; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD930A0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBD93390 | overloaded x3
        public void get_RevocationTime(){} // RVA: 0x7FFAC2F3C380
        public void get_RevocationReason(){} // RVA: 0x7FFAC2F247C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBD936C0
    }

    public class ServiceLocator : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Name Issuer; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Object Locator; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD93920 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBD93E80 | overloaded x3
        public void get_Issuer(){} // RVA: 0x7FFAC2F3C380
        public void get_Locator(){} // RVA: 0x7FFAC2F247C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBD94010
    }

    public class Signature : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier SignatureAlgorithm; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerBitString SignatureValue; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence Certs; // 0x20

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD94230 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBD945E0 | overloaded x3
        public void get_SignatureAlgorithm(){} // RVA: 0x7FFAC2F3C380
        public void get_SignatureValue(){} // RVA: 0x7FFAC2F247C0
        public void GetSignatureOctets(){} // RVA: 0x7FFAC8F0A780
        public void get_Certs(){} // RVA: 0x7FFAC2F4F0C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBD948B0
    }

    public class SingleResponse : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp.CertID CertId; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp.CertStatus CertStatus; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerGeneralizedTime ThisUpdate; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerGeneralizedTime NextUpdate; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Extensions SingleExtensions; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBD94B30 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFACBD950F0 | overloaded x2
        public void get_CertId(){} // RVA: 0x7FFAC2F3C380
        public void get_CertStatus(){} // RVA: 0x7FFAC2F247C0
        public void get_ThisUpdate(){} // RVA: 0x7FFAC2F4F0C0
        public void get_NextUpdate(){} // RVA: 0x7FFAC2F4F130
        public void get_SingleExtensions(){} // RVA: 0x7FFAC31D95E0
        public void ToAsn1Object(){} // RVA: 0x7FFACBD952C0
    }

    public class TbsRequest : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger Version;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger RequestorName; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.GeneralName RequestList; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence RequestExtensions; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Extensions requestExtensions; // 0x28
        public bool versionSet; // 0x30

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD956C0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBD95A60 | overloaded x2
        public void get_Version(){} // RVA: 0x7FFAC2F3C380
        public void get_RequestorName(){} // RVA: 0x7FFAC2F247C0
        public void get_RequestList(){} // RVA: 0x7FFAC2F4F0C0
        public void get_RequestExtensions(){} // RVA: 0x7FFAC2F4F130
        public void ToAsn1Object(){} // RVA: 0x7FFACBD96060
        public void .cctor(){} // RVA: 0x7FFACBD96420
    }

}