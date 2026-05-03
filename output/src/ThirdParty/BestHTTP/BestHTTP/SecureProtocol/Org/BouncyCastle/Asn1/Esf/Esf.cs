// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Esf
// Classes: 26
// Methods: 172

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Esf
{
    public class CertificateValues : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A20BB90
        public void .ctor(){} // RVA: 0x7FFE8A20C160 | overloaded x3
        public void GetCertificates(){} // RVA: 0x7FFE8A20C400
        public void ToAsn1Object(){} // RVA: 0x7FFE81116380
    }

    public class CommitmentTypeIdentifier : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE8A20C5A0
    }

    public class CommitmentTypeIndication : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier commitmentTypeId; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence commitmentTypeQualifier; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A20C900
        public void .ctor(){} // RVA: 0x7FFE8A20CEB0 | overloaded x3
        public void get_CommitmentTypeID(){} // RVA: 0x7FFE81116380
        public void get_CommitmentTypeQualifier(){} // RVA: 0x7FFE810FE7C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A20CFD0
    }

    public class CommitmentTypeQualifier : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier commitmentTypeIdentifier; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Object qualifier; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A20D3B0 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFE8A20D650
        public void get_CommitmentTypeIdentifier(){} // RVA: 0x7FFE81116380
        public void get_Qualifier(){} // RVA: 0x7FFE810FE7C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A20D820
    }

    public class CompleteCertificateRefs : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A20DA20
        public void .ctor(){} // RVA: 0x7FFE8A20DFF0 | overloaded x3
        public void GetOtherCertIDs(){} // RVA: 0x7FFE8A20E290
        public void ToAsn1Object(){} // RVA: 0x7FFE81116380
    }

    public class CompleteRevocationRefs : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A20E450
        public void .ctor(){} // RVA: 0x7FFE8A20EA20 | overloaded x3
        public void GetCrlOcspRefs(){} // RVA: 0x7FFE8A20ECC0
        public void ToAsn1Object(){} // RVA: 0x7FFE81116380
    }

    public class CrlIdentifier : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Name crlIssuer; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerUtcTime crlIssuedTime; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger crlNumber; // 0x20

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A20EE80
        public void .ctor(){} // RVA: 0x7FFE8A20F2A0 | overloaded x3
        public void get_CrlIssuer(){} // RVA: 0x7FFE81116380
        public void get_CrlIssuedTime(){} // RVA: 0x7FFE8A20F660
        public void get_CrlNumber(){} // RVA: 0x7FFE8A187C60
        public void ToAsn1Object(){} // RVA: 0x7FFE8A20F6C0
    }

    public class CrlListID : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A20F920
        public void .ctor(){} // RVA: 0x7FFE8A210060 | overloaded x3
        public void GetCrls(){} // RVA: 0x7FFE8A210300
        public void ToAsn1Object(){} // RVA: 0x7FFE8A2104C0
    }

    public class CrlOcspRef : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Esf.CrlListID crlids; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Esf.OcspListID ocspids; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Esf.OtherRevRefs otherRev; // 0x20

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A210520
        public void .ctor(){} // RVA: 0x7FFE811DAE00 | overloaded x2
        public void get_CrlIDs(){} // RVA: 0x7FFE81116380
        public void get_OcspIDs(){} // RVA: 0x7FFE810FE7C0
        public void get_OtherRev(){} // RVA: 0x7FFE811290C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A2109D0
    }

    public class CrlValidatedID : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Esf.OtherHash crlHash; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Esf.CrlIdentifier crlIdentifier; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A210D80
        public void .ctor(){} // RVA: 0x7FFE8A211260 | overloaded x3
        public void get_CrlHash(){} // RVA: 0x7FFE81116380
        public void get_CrlIdentifier(){} // RVA: 0x7FFE810FE7C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A211370
    }

    public class EsfAttributes : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE8A211580
    }

    public class OcspIdentifier : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp.ResponderID ocspResponderID; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerGeneralizedTime producedAt; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A211D20
        public void .ctor(){} // RVA: 0x7FFE8A2121F0 | overloaded x2
        public void get_OcspResponderID(){} // RVA: 0x7FFE81116380
        public void get_ProducedAt(){} // RVA: 0x7FFE8A212360
        public void ToAsn1Object(){} // RVA: 0x7FFE8A212380
    }

    public class OcspListID : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A212490
        public void .ctor(){} // RVA: 0x7FFE8A212BD0 | overloaded x3
        public void GetOcspResponses(){} // RVA: 0x7FFE8A212E70
        public void ToAsn1Object(){} // RVA: 0x7FFE8A213030
    }

    public class OcspResponsesID : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Esf.OcspIdentifier ocspIdentifier; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Esf.OtherHash ocspRepHash; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A213090
        public void .ctor(){} // RVA: 0x7FFE8A213570 | overloaded x3
        public void get_OcspIdentifier(){} // RVA: 0x7FFE81116380
        public void get_OcspRepHash(){} // RVA: 0x7FFE810FE7C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A213680
    }

    public class OtherCertID : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Esf.OtherHash otherCertHash; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.IssuerSerial issuerSerial; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A213890
        public void .ctor(){} // RVA: 0x7FFE8A213D70 | overloaded x3
        public void get_OtherCertHash(){} // RVA: 0x7FFE81116380
        public void get_IssuerSerial(){} // RVA: 0x7FFE810FE7C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A213E80
    }

    public class OtherHash : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString sha1Hash; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A214090
        public void .ctor(){} // RVA: 0x7FFE8A2144F0 | overloaded x3
        public void get_HashAlgorithm(){} // RVA: 0x7FFE8A2145A0
        public void GetHashValue(){} // RVA: 0x7FFE8A2146A0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A2146F0
    }

    public class OtherHashAlgAndValue : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier hashAlgorithm; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A214720
        public void .ctor(){} // RVA: 0x7FFE8A214DF0 | overloaded x3
        public void get_HashAlgorithm(){} // RVA: 0x7FFE81116380
        public void GetHashValue(){} // RVA: 0x7FFE86802D70
        public void ToAsn1Object(){} // RVA: 0x7FFE8A214F60
    }

    public class OtherRevRefs : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier otherRevRefType; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Object otherRevRefs; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A215070
        public void .ctor(){} // RVA: 0x7FFE8A215540 | overloaded x2
        public void get_OtherRevRefType(){} // RVA: 0x7FFE81116380
        public void get_OtherRevRefsObject(){} // RVA: 0x7FFE810FE7C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A2156C0
    }

    public class OtherRevVals : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier otherRevValType; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Object otherRevVals; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A2157D0
        public void .ctor(){} // RVA: 0x7FFE8A215CA0 | overloaded x2
        public void get_OtherRevValType(){} // RVA: 0x7FFE81116380
        public void get_OtherRevValsObject(){} // RVA: 0x7FFE810FE7C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A215E20
    }

    public class OtherSigningCertificate : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A215F30
        public void .ctor(){} // RVA: 0x7FFE8A2165A0 | overloaded x5
        public void GetCerts(){} // RVA: 0x7FFE8A216950
        public void GetPolicies(){} // RVA: 0x7FFE8A216B10
        public void ToAsn1Object(){} // RVA: 0x7FFE8A216CE0
    }

    public class RevocationValues : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence crlVals; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A216EE0
        public void .ctor(){} // RVA: 0x7FFE8A217870 | overloaded x3
        public void GetCrlVals(){} // RVA: 0x7FFE8A217D10
        public void GetOcspVals(){} // RVA: 0x7FFE8A217ED0
        public void get_OtherRevVals(){} // RVA: 0x7FFE811290C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A218090
    }

    public class SigPolicyQualifierInfo : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier sigPolicyQualifierId; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Object sigQualifier; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A21AB30
        public void .ctor(){} // RVA: 0x7FFE8A21B000 | overloaded x2
        public void get_SigPolicyQualifierId(){} // RVA: 0x7FFE81116380
        public void get_SigQualifier(){} // RVA: 0x7FFE810FE7C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A21B0F0
    }

    public class SignaturePolicyId : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier sigPolicyIdentifier; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Esf.OtherHashAlgAndValue sigPolicyHash; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A2183F0
        public void .ctor(){} // RVA: 0x7FFE8A218CB0 | overloaded x4
        public void get_SigPolicyIdentifier(){} // RVA: 0x7FFE81116380
        public void get_SigPolicyHash(){} // RVA: 0x7FFE810FE7C0
        public void GetSigPolicyQualifiers(){} // RVA: 0x7FFE8A218F70
        public void ToAsn1Object(){} // RVA: 0x7FFE8A219120
    }

    public class SignaturePolicyIdentifier : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Esf.SignaturePolicyId sigPolicy; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A219380
        public void .ctor(){} // RVA: 0x7FFE8A219660 | overloaded x2
        public void get_SignaturePolicyId(){} // RVA: 0x7FFE81116380
        public void ToAsn1Object(){} // RVA: 0x7FFE8A219710
    }

    public class SignerAttribute : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence claimedAttributes; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AttributeCertificate certifiedAttributes; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A2197A0
        public void .ctor(){} // RVA: 0x7FFE81161E80 | overloaded x3
        public void get_ClaimedAttributes(){} // RVA: 0x7FFE81116380
        public void get_CertifiedAttributes(){} // RVA: 0x7FFE810FE7C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A219B70
    }

    public class SignerLocation : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X500.DirectoryString countryName; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X500.DirectoryString localityName; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence postalAddress; // 0x20
        public object field_3; // 0x82F
        public object field_4; // 0x830

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A21A2E0 | overloaded x4
        public void GetInstance(){} // RVA: 0x7FFE8A21A350
        public void get_Country(){} // RVA: 0x7FFE81116380
        public void get_Locality(){} // RVA: 0x7FFE810FE7C0
        public void GetPostal(){} // RVA: 0x7FFE8A21A420
        public void get_CountryName(){} // RVA: 0x7FFE8A21A590
        public void get_LocalityName(){} // RVA: 0x7FFE8A21A6B0
        public void get_PostalAddress(){} // RVA: 0x7FFE811290C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A21A7D0
    }

}