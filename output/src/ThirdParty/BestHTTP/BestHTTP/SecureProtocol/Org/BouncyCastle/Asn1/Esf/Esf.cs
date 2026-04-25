// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Esf
// Classes: 26
// Methods: 172

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Esf
{
    public class CertificateValues : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence certificates; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBDB2570
        public void .ctor(){} // RVA: 0x7FFACBDB2B40 | overloaded x3
        public void GetCertificates(){} // RVA: 0x7FFACBDB2DE0
        public void ToAsn1Object(){} // RVA: 0x7FFAC2F3C380
    }

    public class CommitmentTypeIdentifier : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier ProofOfOrigin;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier ProofOfReceipt; // 0x8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier ProofOfDelivery; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier ProofOfSender; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier ProofOfApproval; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier ProofOfCreation; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBDB2F80
    }

    public class CommitmentTypeIndication : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier CommitmentTypeID; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence CommitmentTypeQualifier; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBDB32E0
        public void .ctor(){} // RVA: 0x7FFACBDB3890 | overloaded x3
        public void get_CommitmentTypeID(){} // RVA: 0x7FFAC2F3C380
        public void get_CommitmentTypeQualifier(){} // RVA: 0x7FFAC2F247C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDB39B0
    }

    public class CommitmentTypeQualifier : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier CommitmentTypeIdentifier; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Object Qualifier; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBDB3D90 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFACBDB4030
        public void get_CommitmentTypeIdentifier(){} // RVA: 0x7FFAC2F3C380
        public void get_Qualifier(){} // RVA: 0x7FFAC2F247C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDB4200
    }

    public class CompleteCertificateRefs : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence otherCertIDs; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBDB4400
        public void .ctor(){} // RVA: 0x7FFACBDB49D0 | overloaded x3
        public void GetOtherCertIDs(){} // RVA: 0x7FFACBDB4C70
        public void ToAsn1Object(){} // RVA: 0x7FFAC2F3C380
    }

    public class CompleteRevocationRefs : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence crlOcspRefs; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBDB4E30
        public void .ctor(){} // RVA: 0x7FFACBDB5400 | overloaded x3
        public void GetCrlOcspRefs(){} // RVA: 0x7FFACBDB56A0
        public void ToAsn1Object(){} // RVA: 0x7FFAC2F3C380
    }

    public class CrlIdentifier : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Name CrlIssuer; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerUtcTime CrlIssuedTime; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger CrlNumber; // 0x20

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBDB5860
        public void .ctor(){} // RVA: 0x7FFACBDB5C80 | overloaded x3
        public void get_CrlIssuer(){} // RVA: 0x7FFAC2F3C380
        public void get_CrlIssuedTime(){} // RVA: 0x7FFACBDB6040
        public void get_CrlNumber(){} // RVA: 0x7FFACBD2E640
        public void ToAsn1Object(){} // RVA: 0x7FFACBDB60A0
    }

    public class CrlListID : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence crls; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBDB6300
        public void .ctor(){} // RVA: 0x7FFACBDB6A40 | overloaded x3
        public void GetCrls(){} // RVA: 0x7FFACBDB6CE0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDB6EA0
    }

    public class CrlOcspRef : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Esf.CrlListID CrlIDs; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Esf.OcspListID OcspIDs; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Esf.OtherRevRefs OtherRev; // 0x20

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBDB6F00
        public void .ctor(){} // RVA: 0x7FFAC3000E00 | overloaded x2
        public void get_CrlIDs(){} // RVA: 0x7FFAC2F3C380
        public void get_OcspIDs(){} // RVA: 0x7FFAC2F247C0
        public void get_OtherRev(){} // RVA: 0x7FFAC2F4F0C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDB73B0
    }

    public class CrlValidatedID : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Esf.OtherHash CrlHash; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Esf.CrlIdentifier CrlIdentifier; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBDB7760
        public void .ctor(){} // RVA: 0x7FFACBDB7C40 | overloaded x3
        public void get_CrlHash(){} // RVA: 0x7FFAC2F3C380
        public void get_CrlIdentifier(){} // RVA: 0x7FFAC2F247C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDB7D50
    }

    public class EsfAttributes : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier SigPolicyId;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier CommitmentType; // 0x8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier SignerLocation; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier SignerAttr; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier OtherSigCert; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier ContentTimestamp; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier CertificateRefs; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier RevocationRefs; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier CertValues; // 0x40
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier RevocationValues; // 0x48
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier EscTimeStamp; // 0x50
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier CertCrlTimestamp; // 0x58
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier ArchiveTimestamp; // 0x60
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier ArchiveTimestampV2; // 0x68

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBDB7F60
    }

    public class OcspIdentifier : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp.ResponderID OcspResponderID; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerGeneralizedTime ProducedAt; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBDB8700
        public void .ctor(){} // RVA: 0x7FFACBDB8BD0 | overloaded x2
        public void get_OcspResponderID(){} // RVA: 0x7FFAC2F3C380
        public void get_ProducedAt(){} // RVA: 0x7FFACBDB8D40
        public void ToAsn1Object(){} // RVA: 0x7FFACBDB8D60
    }

    public class OcspListID : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence ocspResponses; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBDB8E70
        public void .ctor(){} // RVA: 0x7FFACBDB95B0 | overloaded x3
        public void GetOcspResponses(){} // RVA: 0x7FFACBDB9850
        public void ToAsn1Object(){} // RVA: 0x7FFACBDB9A10
    }

    public class OcspResponsesID : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Esf.OcspIdentifier OcspIdentifier; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Esf.OtherHash OcspRepHash; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBDB9A70
        public void .ctor(){} // RVA: 0x7FFACBDB9F50 | overloaded x3
        public void get_OcspIdentifier(){} // RVA: 0x7FFAC2F3C380
        public void get_OcspRepHash(){} // RVA: 0x7FFAC2F247C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDBA060
    }

    public class OtherCertID : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Esf.OtherHash OtherCertHash; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.IssuerSerial IssuerSerial; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBDBA270
        public void .ctor(){} // RVA: 0x7FFACBDBA750 | overloaded x3
        public void get_OtherCertHash(){} // RVA: 0x7FFAC2F3C380
        public void get_IssuerSerial(){} // RVA: 0x7FFAC2F247C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDBA860
    }

    public class OtherHash : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString HashAlgorithm; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Esf.OtherHashAlgAndValue otherHash; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBDBAA70
        public void .ctor(){} // RVA: 0x7FFACBDBAED0 | overloaded x3
        public void get_HashAlgorithm(){} // RVA: 0x7FFACBDBAF80
        public void GetHashValue(){} // RVA: 0x7FFACBDBB080
        public void ToAsn1Object(){} // RVA: 0x7FFACBDBB0D0
    }

    public class OtherHashAlgAndValue : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier HashAlgorithm; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString hashValue; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBDBB100
        public void .ctor(){} // RVA: 0x7FFACBDBB7D0 | overloaded x3
        public void get_HashAlgorithm(){} // RVA: 0x7FFAC2F3C380
        public void GetHashValue(){} // RVA: 0x7FFAC8459460
        public void ToAsn1Object(){} // RVA: 0x7FFACBDBB940
    }

    public class OtherRevRefs : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier OtherRevRefType; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Object OtherRevRefsObject; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBDBBA50
        public void .ctor(){} // RVA: 0x7FFACBDBBF20 | overloaded x2
        public void get_OtherRevRefType(){} // RVA: 0x7FFAC2F3C380
        public void get_OtherRevRefsObject(){} // RVA: 0x7FFAC2F247C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDBC0A0
    }

    public class OtherRevVals : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier OtherRevValType; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Object OtherRevValsObject; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBDBC1B0
        public void .ctor(){} // RVA: 0x7FFACBDBC680 | overloaded x2
        public void get_OtherRevValType(){} // RVA: 0x7FFAC2F3C380
        public void get_OtherRevValsObject(){} // RVA: 0x7FFAC2F247C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDBC800
    }

    public class OtherSigningCertificate : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence certs; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence policies; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBDBC910
        public void .ctor(){} // RVA: 0x7FFACBDBCF80 | overloaded x5
        public void GetCerts(){} // RVA: 0x7FFACBDBD330
        public void GetPolicies(){} // RVA: 0x7FFACBDBD4F0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDBD6C0
    }

    public class RevocationValues : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence OtherRevVals; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence ocspVals; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Esf.OtherRevVals otherRevVals; // 0x20

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBDBD8C0
        public void .ctor(){} // RVA: 0x7FFACBDBE250 | overloaded x3
        public void GetCrlVals(){} // RVA: 0x7FFACBDBE6F0
        public void GetOcspVals(){} // RVA: 0x7FFACBDBE8B0
        public void get_OtherRevVals(){} // RVA: 0x7FFAC2F4F0C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDBEA70
    }

    public class SigPolicyQualifierInfo : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier SigPolicyQualifierId; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Object SigQualifier; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBDC1510
        public void .ctor(){} // RVA: 0x7FFACBDC19E0 | overloaded x2
        public void get_SigPolicyQualifierId(){} // RVA: 0x7FFAC2F3C380
        public void get_SigQualifier(){} // RVA: 0x7FFAC2F247C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDC1AD0
    }

    public class SignaturePolicyId : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier SigPolicyIdentifier; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Esf.OtherHashAlgAndValue SigPolicyHash; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence sigPolicyQualifiers; // 0x20

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBDBEDD0
        public void .ctor(){} // RVA: 0x7FFACBDBF690 | overloaded x4
        public void get_SigPolicyIdentifier(){} // RVA: 0x7FFAC2F3C380
        public void get_SigPolicyHash(){} // RVA: 0x7FFAC2F247C0
        public void GetSigPolicyQualifiers(){} // RVA: 0x7FFACBDBF950
        public void ToAsn1Object(){} // RVA: 0x7FFACBDBFB00
    }

    public class SignaturePolicyIdentifier : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Esf.SignaturePolicyId SignaturePolicyId; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBDBFD60
        public void .ctor(){} // RVA: 0x7FFACBDC0040 | overloaded x2
        public void get_SignaturePolicyId(){} // RVA: 0x7FFAC2F3C380
        public void ToAsn1Object(){} // RVA: 0x7FFACBDC00F0
    }

    public class SignerAttribute : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence ClaimedAttributes; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AttributeCertificate CertifiedAttributes; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBDC0180
        public void .ctor(){} // RVA: 0x7FFAC2F87E80 | overloaded x3
        public void get_ClaimedAttributes(){} // RVA: 0x7FFAC2F3C380
        public void get_CertifiedAttributes(){} // RVA: 0x7FFAC2F247C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDC0550
    }

    public class SignerLocation : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X500.DirectoryString Country; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X500.DirectoryString Locality; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence CountryName; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBDC0CC0 | overloaded x4
        public void GetInstance(){} // RVA: 0x7FFACBDC0D30
        public void get_Country(){} // RVA: 0x7FFAC2F3C380
        public void get_Locality(){} // RVA: 0x7FFAC2F247C0
        public void GetPostal(){} // RVA: 0x7FFACBDC0E00
        public void get_CountryName(){} // RVA: 0x7FFACBDC0F70
        public void get_LocalityName(){} // RVA: 0x7FFACBDC1090
        public void get_PostalAddress(){} // RVA: 0x7FFAC2F4F0C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDC11B0
    }

}