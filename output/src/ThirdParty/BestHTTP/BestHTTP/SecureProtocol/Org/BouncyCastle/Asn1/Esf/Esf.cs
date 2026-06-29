// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Esf
// Classes: 26
// Methods: 126

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Esf
{
    public class CertificateValues : Asn1Encodable
    {
        public object certificates;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA44F7B0
        public void .ctor(){} // RVA: 0xA44FD80
        public void GetCertificates(){} // RVA: 0xA450030
        public void ToAsn1Object(){} // RVA: 0xB5DBF0
    }

    public class CommitmentTypeIdentifier : Object
    {
        public object ProofOfOrigin;
        public object ProofOfReceipt;
        public object ProofOfDelivery;
        public object ProofOfSender;
        public object ProofOfApproval;
        public object ProofOfCreation;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA4501E0
    }

    public class CommitmentTypeIndication : Asn1Encodable
    {
        public object commitmentTypeId;
        public object commitmentTypeQualifier;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA450540
        public void .ctor(){} // RVA: 0xA450AF0
        public void get_CommitmentTypeID(){} // RVA: 0xB5DBF0
        public void get_CommitmentTypeQualifier(){} // RVA: 0xB465B0
        public void ToAsn1Object(){} // RVA: 0xA450C10
    }

    public class CommitmentTypeQualifier : Asn1Encodable
    {
        public object commitmentTypeIdentifier;
        public object qualifier;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA451000
        public void GetInstance(){} // RVA: 0xA4512A0
        public void get_CommitmentTypeIdentifier(){} // RVA: 0xB5DBF0
        public void get_Qualifier(){} // RVA: 0xB465B0
        public void ToAsn1Object(){} // RVA: 0xA451470
    }

    public class CompleteCertificateRefs : Asn1Encodable
    {
        public object otherCertIDs;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA451680
        public void .ctor(){} // RVA: 0xA451C50
        public void GetOtherCertIDs(){} // RVA: 0xA451F00
        public void ToAsn1Object(){} // RVA: 0xB5DBF0
    }

    public class CompleteRevocationRefs : Asn1Encodable
    {
        public object crlOcspRefs;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA4520D0
        public void .ctor(){} // RVA: 0xA4526A0
        public void GetCrlOcspRefs(){} // RVA: 0xA452950
        public void ToAsn1Object(){} // RVA: 0xB5DBF0
    }

    public class CrlIdentifier : Asn1Encodable
    {
        public object crlIssuer;
        public object crlIssuedTime;
        public object crlNumber;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA452B20
        public void .ctor(){} // RVA: 0xA452F40
        public void get_CrlIssuer(){} // RVA: 0xB5DBF0
        public void get_CrlIssuedTime(){} // RVA: 0xA453300
        public void get_CrlNumber(){} // RVA: 0xA3CA910
        public void ToAsn1Object(){} // RVA: 0xA453360
    }

    public class CrlListID : Asn1Encodable
    {
        public object crls;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA4535D0
        public void .ctor(){} // RVA: 0xA453CE0
        public void GetCrls(){} // RVA: 0xA453F90
        public void ToAsn1Object(){} // RVA: 0xA454160
    }

    public class CrlOcspRef : Asn1Encodable
    {
        public object crlids;
        public object ocspids;
        public object otherRev;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA4541C0
        public void .ctor(){} // RVA: 0xC27FD0
        public void get_CrlIDs(){} // RVA: 0xB5DBF0
        public void get_OcspIDs(){} // RVA: 0xB465B0
        public void get_OtherRev(){} // RVA: 0xB700F0
        public void ToAsn1Object(){} // RVA: 0xA454670
    }

    public class CrlValidatedID : Asn1Encodable
    {
        public object crlHash;
        public object crlIdentifier;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA454A40
        public void .ctor(){} // RVA: 0xA454F20
        public void get_CrlHash(){} // RVA: 0xB5DBF0
        public void get_CrlIdentifier(){} // RVA: 0xB465B0
        public void ToAsn1Object(){} // RVA: 0xA455030
    }

    public class EsfAttributes : Object
    {
        public object SigPolicyId;
        public object CommitmentType;
        public object SignerLocation;
        public object SignerAttr;
        public object OtherSigCert;
        public object ContentTimestamp;
        public object CertificateRefs;
        public object RevocationRefs;
        public object CertValues;
        public object RevocationValues;
        public object EscTimeStamp;
        public object CertCrlTimestamp;
        public object ArchiveTimestamp;
        public object ArchiveTimestampV2;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA455250
    }

    public class OcspIdentifier : Asn1Encodable
    {
        public object ocspResponderID;
        public object producedAt;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA4559F0
        public void .ctor(){} // RVA: 0xA455EC0
        public void get_OcspResponderID(){} // RVA: 0xB5DBF0
        public void get_ProducedAt(){} // RVA: 0xA456030
        public void ToAsn1Object(){} // RVA: 0xA456050
    }

    public class OcspListID : Asn1Encodable
    {
        public object ocspResponses;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA456160
        public void .ctor(){} // RVA: 0xA456870
        public void GetOcspResponses(){} // RVA: 0xA456B20
        public void ToAsn1Object(){} // RVA: 0xA456CF0
    }

    public class OcspResponsesID : Asn1Encodable
    {
        public object ocspIdentifier;
        public object ocspRepHash;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA456D50
        public void .ctor(){} // RVA: 0xA457230
        public void get_OcspIdentifier(){} // RVA: 0xB5DBF0
        public void get_OcspRepHash(){} // RVA: 0xB465B0
        public void ToAsn1Object(){} // RVA: 0xA457340
    }

    public class OtherCertID : Asn1Encodable
    {
        public object otherCertHash;
        public object issuerSerial;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA457560
        public void .ctor(){} // RVA: 0xA457A40
        public void get_OtherCertHash(){} // RVA: 0xB5DBF0
        public void get_IssuerSerial(){} // RVA: 0xB465B0
        public void ToAsn1Object(){} // RVA: 0xA457B50
    }

    public class OtherHash : Asn1Encodable
    {
        public object sha1Hash;
        public object otherHash;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA457D70
        public void .ctor(){} // RVA: 0xA4581D0
        public void get_HashAlgorithm(){} // RVA: 0xA458280
        public void GetHashValue(){} // RVA: 0xA458380
        public void ToAsn1Object(){} // RVA: 0xA4583D0
    }

    public class OtherHashAlgAndValue : Asn1Encodable
    {
        public object hashAlgorithm;
        public object hashValue;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA458400
        public void .ctor(){} // RVA: 0xA458AD0
        public void get_HashAlgorithm(){} // RVA: 0xB5DBF0
        public void GetHashValue(){} // RVA: 0x673B450
        public void ToAsn1Object(){} // RVA: 0xA458C40
    }

    public class OtherRevRefs : Asn1Encodable
    {
        public object otherRevRefType;
        public object otherRevRefs;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA458D50
        public void .ctor(){} // RVA: 0xA459220
        public void get_OtherRevRefType(){} // RVA: 0xB5DBF0
        public void get_OtherRevRefsObject(){} // RVA: 0xB465B0
        public void ToAsn1Object(){} // RVA: 0xA4593A0
    }

    public class OtherRevVals : Asn1Encodable
    {
        public object otherRevValType;
        public object otherRevVals;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA4594B0
        public void .ctor(){} // RVA: 0xA459980
        public void get_OtherRevValType(){} // RVA: 0xB5DBF0
        public void get_OtherRevValsObject(){} // RVA: 0xB465B0
        public void ToAsn1Object(){} // RVA: 0xA459B00
    }

    public class OtherSigningCertificate : Asn1Encodable
    {
        public object certs;
        public object policies;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA459C10
        public void .ctor(){} // RVA: 0xA45A280
        public void GetCerts(){} // RVA: 0xA45A640
        public void GetPolicies(){} // RVA: 0xA45A810
        public void ToAsn1Object(){} // RVA: 0xA45A9E0
    }

    public class RevocationValues : Asn1Encodable
    {
        public object crlVals;
        public object ocspVals;
        public object otherRevVals;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA45ABF0
        public void .ctor(){} // RVA: 0xA45B560
        public void GetCrlVals(){} // RVA: 0xA45BA40
        public void GetOcspVals(){} // RVA: 0xA45BC10
        public void get_OtherRevVals(){} // RVA: 0xB700F0
        public void ToAsn1Object(){} // RVA: 0xA45BDE0
    }

    public class SigPolicyQualifierInfo : Asn1Encodable
    {
        public object sigPolicyQualifierId;
        public object sigQualifier;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA45E8A0
        public void .ctor(){} // RVA: 0xA45ED70
        public void get_SigPolicyQualifierId(){} // RVA: 0xB5DBF0
        public void get_SigQualifier(){} // RVA: 0xB465B0
        public void ToAsn1Object(){} // RVA: 0xA45EE60
    }

    public class SignaturePolicyId : Asn1Encodable
    {
        public object sigPolicyIdentifier;
        public object sigPolicyHash;
        public object sigPolicyQualifiers;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA45C150
        public void .ctor(){} // RVA: 0xA45CA10
        public void get_SigPolicyIdentifier(){} // RVA: 0xB5DBF0
        public void get_SigPolicyHash(){} // RVA: 0xB465B0
        public void GetSigPolicyQualifiers(){} // RVA: 0xA45CCC0
        public void ToAsn1Object(){} // RVA: 0xA45CE70
    }

    public class SignaturePolicyIdentifier : Asn1Encodable
    {
        public object sigPolicy;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA45D0D0
        public void .ctor(){} // RVA: 0xA45D3B0
        public void get_SignaturePolicyId(){} // RVA: 0xB5DBF0
        public void ToAsn1Object(){} // RVA: 0xA45D460
    }

    public class SignerAttribute : Asn1Encodable
    {
        public object claimedAttributes;
        public object certifiedAttributes;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA45D4F0
        public void .ctor(){} // RVA: 0xBA9BA0
        public void get_ClaimedAttributes(){} // RVA: 0xB5DBF0
        public void get_CertifiedAttributes(){} // RVA: 0xB465B0
        public void ToAsn1Object(){} // RVA: 0xA45D8C0
    }

    public class SignerLocation : Asn1Encodable
    {
        public object countryName;
        public object localityName;
        public object postalAddress;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA45E020
        public void GetInstance(){} // RVA: 0xA45E090
        public void get_Country(){} // RVA: 0xB5DBF0
        public void get_Locality(){} // RVA: 0xB465B0
        public void GetPostal(){} // RVA: 0xA45E160
        public void get_CountryName(){} // RVA: 0xA45E2F0
        public void get_LocalityName(){} // RVA: 0xA45E410
        public void get_PostalAddress(){} // RVA: 0xB700F0
        public void ToAsn1Object(){} // RVA: 0xA45E530
    }

}