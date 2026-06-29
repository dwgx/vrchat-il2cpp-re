// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ess
// Classes: 8
// Methods: 42

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ess
{
    public class ContentHints : Asn1Encodable
    {
        public object contentDescription;
        public object contentType;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA44AF30
        public void .ctor(){} // RVA: 0x67462E0
        public void get_ContentType(){} // RVA: 0xB465B0
        public void get_ContentDescription(){} // RVA: 0xB5DBF0
        public void ToAsn1Object(){} // RVA: 0xA44B370
    }

    public class ContentIdentifier : Asn1Encodable
    {
        public object value;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA44B520
        public void .ctor(){} // RVA: 0xA44B6F0
        public void get_Value(){} // RVA: 0xB5DBF0
        public void ToAsn1Object(){} // RVA: 0xB5DBF0
    }

    public class EssCertID : Asn1Encodable
    {
        public object certHash;
        public object issuerSerial;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA44B840
        public void .ctor(){} // RVA: 0xA44BD10
        public void GetCertHash(){} // RVA: 0x678C250
        public void get_IssuerSerial(){} // RVA: 0xB465B0
        public void ToAsn1Object(){} // RVA: 0xA44BEC0
    }

    public class EssCertIDv2 : Asn1Encodable
    {
        public object hashAlgorithm;
        public object certHash;
        public object issuerSerial;
        public object DefaultAlgID;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA44C0D0
        public void .ctor(){} // RVA: 0xA44C610
        public void get_HashAlgorithm(){} // RVA: 0xB5DBF0
        public void GetCertHash(){} // RVA: 0xA44C800
        public void get_IssuerSerial(){} // RVA: 0xB700F0
        public void ToAsn1Object(){} // RVA: 0xA44C8B0
        public void .cctor(){} // RVA: 0xA44CBD0
    }

    public class OtherCertID : Asn1Encodable
    {
        public object otherCertHash;
        public object issuerSerial;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA44CD20
        public void .ctor(){} // RVA: 0xA44D1E0
        public void get_AlgorithmHash(){} // RVA: 0xA44D310
        public void GetCertHash(){} // RVA: 0xA44D470
        public void get_IssuerSerial(){} // RVA: 0xB465B0
        public void ToAsn1Object(){} // RVA: 0xA44D5A0
    }

    public class OtherSigningCertificate : Asn1Encodable
    {
        public object certs;
        public object policies;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA44D7B0
        public void .ctor(){} // RVA: 0xA44DB30
        public void GetCerts(){} // RVA: 0xA44DBF0
        public void GetPolicies(){} // RVA: 0xA44DDA0
        public void ToAsn1Object(){} // RVA: 0xA44DF50
    }

    public class SigningCertificate : Asn1Encodable
    {
        public object certs;
        public object policies;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA44E160
        public void .ctor(){} // RVA: 0xA44E4E0
        public void GetCerts(){} // RVA: 0xA44E5A0
        public void GetPolicies(){} // RVA: 0xA44E750
        public void ToAsn1Object(){} // RVA: 0xA44E900
    }

    public class SigningCertificateV2 : Asn1Encodable
    {
        public object certs;
        public object policies;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA44EB10
        public void .ctor(){} // RVA: 0xA44F050
        public void GetCerts(){} // RVA: 0xA44F1A0
        public void GetPolicies(){} // RVA: 0xA44F3F0
        public void ToAsn1Object(){} // RVA: 0xA44F5A0
    }

}