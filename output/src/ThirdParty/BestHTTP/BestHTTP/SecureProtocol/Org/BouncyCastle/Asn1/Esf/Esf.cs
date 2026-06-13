// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Esf
// Classes: 26
// Methods: 172

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Esf
{
    public class CertificateValues
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x97A9790
        public void .ctor(){} // RVA: 0x97A9D60 | overloaded x3
        public void GetCertificates(){} // RVA: 0x97AA000
        public void ToAsn1Object(){} // RVA: 0x2F8380
    }

    public class CommitmentTypeIdentifier
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x97AA1A0
    }

    public class CommitmentTypeIndication
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier commitmentTypeId; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence commitmentTypeQualifier; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x97AA500
        public void .ctor(){} // RVA: 0x97AAAB0 | overloaded x3
        public void get_CommitmentTypeID(){} // RVA: 0x2F8380
        public void get_CommitmentTypeQualifier(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x97AABD0
    }

    public class CommitmentTypeQualifier
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier commitmentTypeIdentifier; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Object qualifier; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x97AAFB0 | overloaded x3
        public void GetInstance(){} // RVA: 0x97AB250
        public void get_CommitmentTypeIdentifier(){} // RVA: 0x2F8380
        public void get_Qualifier(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x97AB420
    }

    public class CompleteCertificateRefs
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x97AB620
        public void .ctor(){} // RVA: 0x97ABBF0 | overloaded x3
        public void GetOtherCertIDs(){} // RVA: 0x97ABE90
        public void ToAsn1Object(){} // RVA: 0x2F8380
    }

    public class CompleteRevocationRefs
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x97AC050
        public void .ctor(){} // RVA: 0x97AC620 | overloaded x3
        public void GetCrlOcspRefs(){} // RVA: 0x97AC8C0
        public void ToAsn1Object(){} // RVA: 0x2F8380
    }

    public class CrlIdentifier
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Name crlIssuer; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerUtcTime crlIssuedTime; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger crlNumber; // 0x20

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x97ACA80
        public void .ctor(){} // RVA: 0x97ACEA0 | overloaded x3
        public void get_CrlIssuer(){} // RVA: 0x2F8380
        public void get_CrlIssuedTime(){} // RVA: 0x97AD260
        public void get_CrlNumber(){} // RVA: 0x9725860
        public void ToAsn1Object(){} // RVA: 0x97AD2C0
    }

    public class CrlListID
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x97AD520
        public void .ctor(){} // RVA: 0x97ADC60 | overloaded x3
        public void GetCrls(){} // RVA: 0x97ADF00
        public void ToAsn1Object(){} // RVA: 0x97AE0C0
    }

    public class CrlOcspRef
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Esf.CrlListID crlids; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Esf.OcspListID ocspids; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Esf.OtherRevRefs otherRev; // 0x20

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x97AE120
        public void .ctor(){} // RVA: 0x3BCE00 | overloaded x2
        public void get_CrlIDs(){} // RVA: 0x2F8380
        public void get_OcspIDs(){} // RVA: 0x2E07C0
        public void get_OtherRev(){} // RVA: 0x30B0C0
        public void ToAsn1Object(){} // RVA: 0x97AE5D0
    }

    public class CrlValidatedID
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Esf.OtherHash crlHash; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Esf.CrlIdentifier crlIdentifier; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x97AE980
        public void .ctor(){} // RVA: 0x97AEE60 | overloaded x3
        public void get_CrlHash(){} // RVA: 0x2F8380
        public void get_CrlIdentifier(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x97AEF70
    }

    public class EsfAttributes
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x97AF180
    }

    public class OcspIdentifier
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp.ResponderID ocspResponderID; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerGeneralizedTime producedAt; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x97AF920
        public void .ctor(){} // RVA: 0x97AFDF0 | overloaded x2
        public void get_OcspResponderID(){} // RVA: 0x2F8380
        public void get_ProducedAt(){} // RVA: 0x97AFF60
        public void ToAsn1Object(){} // RVA: 0x97AFF80
    }

    public class OcspListID
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x97B0090
        public void .ctor(){} // RVA: 0x97B07D0 | overloaded x3
        public void GetOcspResponses(){} // RVA: 0x97B0A70
        public void ToAsn1Object(){} // RVA: 0x97B0C30
    }

    public class OcspResponsesID
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Esf.OcspIdentifier ocspIdentifier; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Esf.OtherHash ocspRepHash; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x97B0C90
        public void .ctor(){} // RVA: 0x97B1170 | overloaded x3
        public void get_OcspIdentifier(){} // RVA: 0x2F8380
        public void get_OcspRepHash(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x97B1280
    }

    public class OtherCertID
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Esf.OtherHash otherCertHash; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.IssuerSerial issuerSerial; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x97B1490
        public void .ctor(){} // RVA: 0x97B1970 | overloaded x3
        public void get_OtherCertHash(){} // RVA: 0x2F8380
        public void get_IssuerSerial(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x97B1A80
    }

    public class OtherHash
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString sha1Hash; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x97B1C90
        public void .ctor(){} // RVA: 0x97B20F0 | overloaded x3
        public void get_HashAlgorithm(){} // RVA: 0x97B21A0
        public void GetHashValue(){} // RVA: 0x97B22A0
        public void ToAsn1Object(){} // RVA: 0x97B22F0
    }

    public class OtherHashAlgAndValue
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier hashAlgorithm; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x97B2320
        public void .ctor(){} // RVA: 0x97B29F0 | overloaded x3
        public void get_HashAlgorithm(){} // RVA: 0x2F8380
        public void GetHashValue(){} // RVA: 0x5CC1E70
        public void ToAsn1Object(){} // RVA: 0x97B2B60
    }

    public class OtherRevRefs
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier otherRevRefType; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Object otherRevRefs; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x97B2C70
        public void .ctor(){} // RVA: 0x97B3140 | overloaded x2
        public void get_OtherRevRefType(){} // RVA: 0x2F8380
        public void get_OtherRevRefsObject(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x97B32C0
    }

    public class OtherRevVals
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier otherRevValType; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Object otherRevVals; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x97B33D0
        public void .ctor(){} // RVA: 0x97B38A0 | overloaded x2
        public void get_OtherRevValType(){} // RVA: 0x2F8380
        public void get_OtherRevValsObject(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x97B3A20
    }

    public class OtherSigningCertificate
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x97B3B30
        public void .ctor(){} // RVA: 0x97B41A0 | overloaded x5
        public void GetCerts(){} // RVA: 0x97B4550
        public void GetPolicies(){} // RVA: 0x97B4710
        public void ToAsn1Object(){} // RVA: 0x97B48E0
    }

    public class RevocationValues
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence crlVals; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x97B4AE0
        public void .ctor(){} // RVA: 0x97B5470 | overloaded x3
        public void GetCrlVals(){} // RVA: 0x97B5910
        public void GetOcspVals(){} // RVA: 0x97B5AD0
        public void get_OtherRevVals(){} // RVA: 0x30B0C0
        public void ToAsn1Object(){} // RVA: 0x97B5C90
    }

    public class SigPolicyQualifierInfo
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier sigPolicyQualifierId; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Object sigQualifier; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x97B8730
        public void .ctor(){} // RVA: 0x97B8C00 | overloaded x2
        public void get_SigPolicyQualifierId(){} // RVA: 0x2F8380
        public void get_SigQualifier(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x97B8CF0
    }

    public class SignaturePolicyId
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier sigPolicyIdentifier; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Esf.OtherHashAlgAndValue sigPolicyHash; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x97B5FF0
        public void .ctor(){} // RVA: 0x97B68B0 | overloaded x4
        public void get_SigPolicyIdentifier(){} // RVA: 0x2F8380
        public void get_SigPolicyHash(){} // RVA: 0x2E07C0
        public void GetSigPolicyQualifiers(){} // RVA: 0x97B6B70
        public void ToAsn1Object(){} // RVA: 0x97B6D20
    }

    public class SignaturePolicyIdentifier : |e
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Esf.SignaturePolicyId sigPolicy; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x97B6F80
        public void .ctor(){} // RVA: 0x97B7260 | overloaded x2
        public void get_SignaturePolicyId(){} // RVA: 0x2F8380
        public void ToAsn1Object(){} // RVA: 0x97B7310
    }

    public class SignerAttribute
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence claimedAttributes; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AttributeCertificate certifiedAttributes; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x97B73A0
        public void .ctor(){} // RVA: 0x343E80 | overloaded x3
        public void get_ClaimedAttributes(){} // RVA: 0x2F8380
        public void get_CertifiedAttributes(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x97B7770
    }

    public class SignerLocation
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X500.DirectoryString countryName; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X500.DirectoryString localityName; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence postalAddress; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x97B7EE0 | overloaded x4
        public void GetInstance(){} // RVA: 0x97B7F50
        public void get_Country(){} // RVA: 0x2F8380
        public void get_Locality(){} // RVA: 0x2E07C0
        public void GetPostal(){} // RVA: 0x97B8020
        public void get_CountryName(){} // RVA: 0x97B8190
        public void get_LocalityName(){} // RVA: 0x97B82B0
        public void get_PostalAddress(){} // RVA: 0x30B0C0
        public void ToAsn1Object(){} // RVA: 0x97B83D0
    }

}