// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Ocsp
// Classes: 18
// Methods: 125

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Ocsp
{
    public class BasicOcspResp : X509ExtensionBase
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp.BasicOcspResponse Version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp.ResponseData ResponderId; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBF7C130
        public void GetTbsResponseData(){} // RVA: 0x7FFACBF7C210
        public void get_Version(){} // RVA: 0x7FFACBF7C2A0
        public void get_ResponderId(){} // RVA: 0x7FFACBF7C310
        public void get_ProducedAt(){} // RVA: 0x7FFACBF7C3B0
        public void get_Responses(){} // RVA: 0x7FFACBF7C3E0
        public void get_ResponseExtensions(){} // RVA: 0x7FFAC8804980
        public void GetX509Extensions(){} // RVA: 0x7FFAC8804980
        public void get_SignatureAlgName(){} // RVA: 0x7FFACBF7C5F0
        public void get_SignatureAlgOid(){} // RVA: 0x7FFACBA567F0
        public void GetResponseData(){} // RVA: 0x7FFACBF7C770
        public void GetSignature(){} // RVA: 0x7FFACBA56680
        public void GetCertList(){} // RVA: 0x7FFACBF7C810
        public void GetCerts(){} // RVA: 0x7FFACBF7CB90
        public void GetCertificates(){} // RVA: 0x7FFACBF7CE90
        public void Verify(){} // RVA: 0x7FFACBF7CFA0
        public void GetEncoded(){} // RVA: 0x7FFACBA639C0
        public void Equals(){} // RVA: 0x7FFACBF7D310
        public void GetHashCode(){} // RVA: 0x7FFAC35DB750
    }

    public class BasicOcspRespGenerator : Object
    {
        public System.Collections.IList SignatureAlgNames; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Extensions responseExtensions; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Ocsp.RespID responderID; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBF7D520 | overloaded x2
        public void AddResponse(){} // RVA: 0x7FFACBF7D9A0 | overloaded x4
        public void SetResponseExtensions(){} // RVA: 0x7FFAC2F87E80
        public void GenerateResponse(){} // RVA: 0x7FFACBF7DA80
        public void Generate(){} // RVA: 0x7FFACBF7E940 | overloaded x3
        public void get_SignatureAlgNames(){} // RVA: 0x7FFACBF7E9B0
    }

    public class CertificateID : Object
    {
        public string HashAlgOid;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp.CertID SerialNumber; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBF7F2F0 | overloaded x2
        public void get_HashAlgOid(){} // RVA: 0x7FFACBF7F510
        public void GetIssuerNameHash(){} // RVA: 0x7FFACBEBB730
        public void GetIssuerKeyHash(){} // RVA: 0x7FFACBF7F550
        public void get_SerialNumber(){} // RVA: 0x7FFACBCFA4F0
        public void MatchesIssuer(){} // RVA: 0x7FFACBF7F590
        public void ToAsn1Object(){} // RVA: 0x7FFAC2F3C380
        public void Equals(){} // RVA: 0x7FFACBF7F5E0
        public void GetHashCode(){} // RVA: 0x7FFACBF7F700
        public void DeriveCertificateID(){} // RVA: 0x7FFACBF7F750
        public void CreateCertID(){} // RVA: 0x7FFACBF7F9A0
    }

    public class CertificateStatus : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Ocsp.CertificateStatus Good;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class OCSPRespGenerator : Object
    {
        public int Successful;
        public int MalformedRequest;
        public int InternalError;
        public int TryLater;
        public int SigRequired;
        public int Unauthorized;

        // ── Methods ──
        public void Generate(){} // RVA: 0x7FFACBF82940
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class OcscpRespStatus : OcspRespStatus
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class OcspException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBF7FE00 | overloaded x3
    }

    public class OcspReq : X509ExtensionBase
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp.OcspRequest Version; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBF7FFC0 | overloaded x4
        public void GetTbsRequest(){} // RVA: 0x7FFACBF80150
        public void get_Version(){} // RVA: 0x7FFACBA62D50
        public void get_RequestorName(){} // RVA: 0x7FFACBF801F0
        public void GetRequestList(){} // RVA: 0x7FFACBF80220
        public void get_RequestExtensions(){} // RVA: 0x7FFACBF80440
        public void GetX509Extensions(){} // RVA: 0x7FFACBF80440
        public void get_SignatureAlgOid(){} // RVA: 0x7FFACBF804B0
        public void GetSignature(){} // RVA: 0x7FFACBF80500
        public void GetCertList(){} // RVA: 0x7FFACBF80550
        public void GetCerts(){} // RVA: 0x7FFACBF80890
        public void GetCertificates(){} // RVA: 0x7FFACBF80BB0
        public void get_IsSigned(){} // RVA: 0x7FFACBF80CE0
        public void Verify(){} // RVA: 0x7FFACBF80D00
        public void GetEncoded(){} // RVA: 0x7FFACBA639C0
    }

    public class OcspReqGenerator : Object
    {
        public System.Collections.IList SignatureAlgNames; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.GeneralName requestorName; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Extensions requestExtensions; // 0x20

        // ── Methods ──
        public void AddRequest(){} // RVA: 0x7FFACBF81060 | overloaded x2
        public void SetRequestorName(){} // RVA: 0x7FFAC2F87E80 | overloaded x2
        public void SetRequestExtensions(){} // RVA: 0x7FFAC2F4F0D0
        public void GenerateRequest(){} // RVA: 0x7FFACBF81270
        public void Generate(){} // RVA: 0x7FFACBF81E40 | overloaded x3
        public void get_SignatureAlgNames(){} // RVA: 0x7FFACBF82100
        public void .ctor(){} // RVA: 0x7FFACBF82150
    }

    public class OcspResp : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp.OcspResponse Status; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBF824F0 | overloaded x4
        public void get_Status(){} // RVA: 0x7FFACBF82610
        public void GetResponseObject(){} // RVA: 0x7FFACBF82680
        public void GetEncoded(){} // RVA: 0x7FFACBA639C0
        public void Equals(){} // RVA: 0x7FFACBF82870
        public void GetHashCode(){} // RVA: 0x7FFAC35DB750
    }

    public class OcspRespStatus : Object
    {
        public int Successful;
        public int MalformedRequest;
        public int InternalError;
        public int TryLater;
        public int SigRequired;
        public int Unauthorized;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class OcspUtilities : Object
    {
        public System.Collections.IDictionary AlgNames;
        public System.Collections.IDictionary oids; // 0x8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Collections.ISet noParams; // 0x10

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFACBF82E60
        public void GetAlgorithmOid(){} // RVA: 0x7FFACBF84570
        public void GetAlgorithmName(){} // RVA: 0x7FFACBF84700
        public void GetSigAlgID(){} // RVA: 0x7FFACBF84820
        public void get_AlgNames(){} // RVA: 0x7FFACBF849A0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Req : X509ExtensionBase
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp.Request SingleRequestExtensions; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void GetCertID(){} // RVA: 0x7FFACBF84AF0
        public void get_SingleRequestExtensions(){} // RVA: 0x7FFAC356B610
        public void GetX509Extensions(){} // RVA: 0x7FFAC356B610
    }

    public class RespData : X509ExtensionBase
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp.ResponseData Version; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void get_Version(){} // RVA: 0x7FFACBD2F8C0
        public void GetResponderId(){} // RVA: 0x7FFACBF84BE0
        public void get_ProducedAt(){} // RVA: 0x7FFACBF84C80
        public void GetResponses(){} // RVA: 0x7FFACBF84CB0
        public void get_ResponseExtensions(){} // RVA: 0x7FFAC37735C0
        public void GetX509Extensions(){} // RVA: 0x7FFAC37735C0
    }

    public class RespID : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp.ResponderID id; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBF85010 | overloaded x3
        public void ToAsn1Object(){} // RVA: 0x7FFAC2F3C380
        public void Equals(){} // RVA: 0x7FFACBF85300
        public void GetHashCode(){} // RVA: 0x7FFAC35DB750
    }

    public class RevokedStatus : CertificateStatus
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp.RevokedInfo RevocationTime; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBF853D0 | overloaded x2
        public void get_RevocationTime(){} // RVA: 0x7FFACBF85530
        public void get_HasRevocationReason(){} // RVA: 0x7FFACBF80CE0
        public void get_RevocationReason(){} // RVA: 0x7FFACBF85560
    }

    public class SingleResp : X509ExtensionBase
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp.SingleResponse ThisUpdate; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void GetCertID(){} // RVA: 0x7FFACBF85620
        public void GetCertStatus(){} // RVA: 0x7FFACBF85710
        public void get_ThisUpdate(){} // RVA: 0x7FFACBF85810
        public void get_NextUpdate(){} // RVA: 0x7FFACBF85840
        public void get_SingleExtensions(){} // RVA: 0x7FFAC3510100
        public void GetX509Extensions(){} // RVA: 0x7FFAC3510100
    }

    public class UnknownStatus : CertificateStatus
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

}