// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp
// Classes: 17
// Methods: 99

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp
{
    public class BasicOcspResponse : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15BF0B0
        public void .ctor(){} // RVA: 0x7B15BF280
        public void GetTbsResponseData(){} // RVA: 0x7A80F2570
        public void get_TbsResponseData(){} // RVA: 0x7A80F2570
        public void GetSignatureAlgorithm(){} // RVA: 0x7A80DA7B0
        public void get_SignatureAlgorithm(){} // RVA: 0x7A80DA7B0
        public void GetSignature(){} // RVA: 0x7A81052C0
        public void get_Signature(){} // RVA: 0x7A81052C0
        public void GetSignatureOctets(){} // RVA: 0x7AE513D50
        public void GetCerts(){} // RVA: 0x7A8105330
        public void get_Certs(){} // RVA: 0x7A8105330
        public void ToAsn1Object(){} // RVA: 0x7B15BF5F0
    }

    public class CertID : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15BF8E0
        public void .ctor(){} // RVA: 0x7B15BFAB0
        public void get_HashAlgorithm(){} // RVA: 0x7A80F2570
        public void get_IssuerNameHash(){} // RVA: 0x7A80DA7B0
        public void get_IssuerKeyHash(){} // RVA: 0x7A81052C0
        public void get_SerialNumber(){} // RVA: 0x7A8105330
        public void ToAsn1Object(){} // RVA: 0x7B15BFD30
    }

    public class CertStatus : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B15BFF80
        public void GetInstance(){} // RVA: 0x7B15C0170
        public void get_TagNo(){} // RVA: 0x7A8124910
        public void get_Status(){} // RVA: 0x7A80DA7B0
        public void ToAsn1Object(){} // RVA: 0x7B15C0340
    }

    public class CrlID : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B15C03C0
        public void get_CrlUrl(){} // RVA: 0x7A80F2570
        public void get_CrlNum(){} // RVA: 0x7A80DA7B0
        public void get_CrlTime(){} // RVA: 0x7A81052C0
        public void ToAsn1Object(){} // RVA: 0x7B15C0750
    }

    public class OcspObjectIdentifiers : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7B15C0AC0
    }

    public class OcspRequest : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15C11D0
        public void .ctor(){} // RVA: 0x7B15C14B0
        public void get_TbsRequest(){} // RVA: 0x7A80F2570
        public void get_OptionalSignature(){} // RVA: 0x7A80DA7B0
        public void ToAsn1Object(){} // RVA: 0x7B15C1690
    }

    public class OcspResponse : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15C18F0
        public void .ctor(){} // RVA: 0x7B15C1BD0
        public void get_ResponseStatus(){} // RVA: 0x7A80F2570
        public void get_ResponseBytes(){} // RVA: 0x7A80DA7B0
        public void ToAsn1Object(){} // RVA: 0x7B15C1E80
    }

    public class OcspResponseStatus : DerEnumerated
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B15C2120
    }

    public class Request : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15C21F0
        public void .ctor(){} // RVA: 0x7B15C24D0
        public void get_ReqCert(){} // RVA: 0x7A80F2570
        public void get_SingleRequestExtensions(){} // RVA: 0x7A80DA7B0
        public void ToAsn1Object(){} // RVA: 0x7B15C26A0
    }

    public class ResponderID : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15C2F50
        public void .ctor(){} // RVA: 0x7B15C2EA0
        public void GetKeyHash(){} // RVA: 0x7B15C2FA0
        public void get_Name(){} // RVA: 0x7B15C3050
        public void ToAsn1Object(){} // RVA: 0x7B15C30F0
    }

    public class ResponseBytes : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15C32F0
        public void .ctor(){} // RVA: 0x7B15C3630
        public void get_ResponseType(){} // RVA: 0x7A80F2570
        public void get_Response(){} // RVA: 0x7A80DA7B0
        public void ToAsn1Object(){} // RVA: 0x7B15C3800
    }

    public class ResponseData : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15C3980
        public void .ctor(){} // RVA: 0x7B15C3F20
        public void get_Version(){} // RVA: 0x7A80DA7B0
        public void get_ResponderID(){} // RVA: 0x7A81052C0
        public void get_ProducedAt(){} // RVA: 0x7A8105330
        public void get_Responses(){} // RVA: 0x7A83F69F0
        public void get_ResponseExtensions(){} // RVA: 0x7A8292C30
        public void ToAsn1Object(){} // RVA: 0x7B15C4540
        public void .cctor(){} // RVA: 0x7B15C4920
    }

    public class RevokedInfo : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15C4A00
        public void .ctor(){} // RVA: 0x7B15C4CF0
        public void get_RevocationTime(){} // RVA: 0x7A80F2570
        public void get_RevocationReason(){} // RVA: 0x7A80DA7B0
        public void ToAsn1Object(){} // RVA: 0x7B15C5020
    }

    public class ServiceLocator : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15C5280
        public void .ctor(){} // RVA: 0x7B15C5800
        public void get_Issuer(){} // RVA: 0x7A80F2570
        public void get_Locator(){} // RVA: 0x7A80DA7B0
        public void ToAsn1Object(){} // RVA: 0x7B15C5990
    }

    public class Signature : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15C5BC0
        public void .ctor(){} // RVA: 0x7B15C5F70
        public void get_SignatureAlgorithm(){} // RVA: 0x7A80F2570
        public void get_SignatureValue(){} // RVA: 0x7A80DA7B0
        public void GetSignatureOctets(){} // RVA: 0x7AE561C60
        public void get_Certs(){} // RVA: 0x7A81052C0
        public void ToAsn1Object(){} // RVA: 0x7B15C6240
    }

    public class SingleResponse : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B15C64C0
        public void GetInstance(){} // RVA: 0x7B15C6A80
        public void get_CertId(){} // RVA: 0x7A80F2570
        public void get_CertStatus(){} // RVA: 0x7A80DA7B0
        public void get_ThisUpdate(){} // RVA: 0x7A81052C0
        public void get_NextUpdate(){} // RVA: 0x7A8105330
        public void get_SingleExtensions(){} // RVA: 0x7A83F69F0
        public void ToAsn1Object(){} // RVA: 0x7B15C6C50
    }

    public class TbsRequest : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15C7050
        public void .ctor(){} // RVA: 0x7B15C73F0
        public void get_Version(){} // RVA: 0x7A80F2570
        public void get_RequestorName(){} // RVA: 0x7A80DA7B0
        public void get_RequestList(){} // RVA: 0x7A81052C0
        public void get_RequestExtensions(){} // RVA: 0x7A8105330
        public void ToAsn1Object(){} // RVA: 0x7B15C79F0
        public void .cctor(){} // RVA: 0x7B15C7DC0
    }

}