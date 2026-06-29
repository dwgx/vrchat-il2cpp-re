// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Esf
// Classes: 26
// Methods: 126

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Esf
{
    public class CertificateValues : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15E4220
        public void .ctor(){} // RVA: 0x7B15E47F0
        public void GetCertificates(){} // RVA: 0x7B15E4A90
        public void ToAsn1Object(){} // RVA: 0x7A80F2570
    }

    public class CommitmentTypeIdentifier : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7B15E4C40
    }

    public class CommitmentTypeIndication : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15E4FA0
        public void .ctor(){} // RVA: 0x7B15E5550
        public void get_CommitmentTypeID(){} // RVA: 0x7A80F2570
        public void get_CommitmentTypeQualifier(){} // RVA: 0x7A80DA7B0
        public void ToAsn1Object(){} // RVA: 0x7B15E5670
    }

    public class CommitmentTypeQualifier : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B15E5A60
        public void GetInstance(){} // RVA: 0x7B15E5D00
        public void get_CommitmentTypeIdentifier(){} // RVA: 0x7A80F2570
        public void get_Qualifier(){} // RVA: 0x7A80DA7B0
        public void ToAsn1Object(){} // RVA: 0x7B15E5ED0
    }

    public class CompleteCertificateRefs : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15E60E0
        public void .ctor(){} // RVA: 0x7B15E66B0
        public void GetOtherCertIDs(){} // RVA: 0x7B15E6950
        public void ToAsn1Object(){} // RVA: 0x7A80F2570
    }

    public class CompleteRevocationRefs : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15E6B20
        public void .ctor(){} // RVA: 0x7B15E70F0
        public void GetCrlOcspRefs(){} // RVA: 0x7B15E7390
        public void ToAsn1Object(){} // RVA: 0x7A80F2570
    }

    public class CrlIdentifier : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15E7560
        public void .ctor(){} // RVA: 0x7B15E7980
        public void get_CrlIssuer(){} // RVA: 0x7A80F2570
        public void get_CrlIssuedTime(){} // RVA: 0x7B15E7D40
        public void get_CrlNumber(){} // RVA: 0x7B155F380
        public void ToAsn1Object(){} // RVA: 0x7B15E7DA0
    }

    public class CrlListID : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15E8010
        public void .ctor(){} // RVA: 0x7B15E8720
        public void GetCrls(){} // RVA: 0x7B15E89C0
        public void ToAsn1Object(){} // RVA: 0x7B15E8B90
    }

    public class CrlOcspRef : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15E8BF0
        public void .ctor(){} // RVA: 0x7A81B7C50
        public void get_CrlIDs(){} // RVA: 0x7A80F2570
        public void get_OcspIDs(){} // RVA: 0x7A80DA7B0
        public void get_OtherRev(){} // RVA: 0x7A81052C0
        public void ToAsn1Object(){} // RVA: 0x7B15E90A0
    }

    public class CrlValidatedID : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15E9470
        public void .ctor(){} // RVA: 0x7B15E9950
        public void get_CrlHash(){} // RVA: 0x7A80F2570
        public void get_CrlIdentifier(){} // RVA: 0x7A80DA7B0
        public void ToAsn1Object(){} // RVA: 0x7B15E9A60
    }

    public class EsfAttributes : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7B15E9C80
    }

    public class OcspIdentifier : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15EA420
        public void .ctor(){} // RVA: 0x7B15EA8F0
        public void get_OcspResponderID(){} // RVA: 0x7A80F2570
        public void get_ProducedAt(){} // RVA: 0x7B15EAA60
        public void ToAsn1Object(){} // RVA: 0x7B15EAA80
    }

    public class OcspListID : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15EAB90
        public void .ctor(){} // RVA: 0x7B15EB2A0
        public void GetOcspResponses(){} // RVA: 0x7B15EB540
        public void ToAsn1Object(){} // RVA: 0x7B15EB710
    }

    public class OcspResponsesID : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15EB770
        public void .ctor(){} // RVA: 0x7B15EBC50
        public void get_OcspIdentifier(){} // RVA: 0x7A80F2570
        public void get_OcspRepHash(){} // RVA: 0x7A80DA7B0
        public void ToAsn1Object(){} // RVA: 0x7B15EBD60
    }

    public class OtherCertID : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15EBF80
        public void .ctor(){} // RVA: 0x7B15EC460
        public void get_OtherCertHash(){} // RVA: 0x7A80F2570
        public void get_IssuerSerial(){} // RVA: 0x7A80DA7B0
        public void ToAsn1Object(){} // RVA: 0x7B15EC570
    }

    public class OtherHash : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15EC790
        public void .ctor(){} // RVA: 0x7B15ECBF0
        public void get_HashAlgorithm(){} // RVA: 0x7B15ECCA0
        public void GetHashValue(){} // RVA: 0x7B15ECDA0
        public void ToAsn1Object(){} // RVA: 0x7B15ECDF0
    }

    public class OtherHashAlgAndValue : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15ECE20
        public void .ctor(){} // RVA: 0x7B15ED4F0
        public void get_HashAlgorithm(){} // RVA: 0x7A80F2570
        public void GetHashValue(){} // RVA: 0x7ADAB0020
        public void ToAsn1Object(){} // RVA: 0x7B15ED660
    }

    public class OtherRevRefs : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15ED770
        public void .ctor(){} // RVA: 0x7B15EDC40
        public void get_OtherRevRefType(){} // RVA: 0x7A80F2570
        public void get_OtherRevRefsObject(){} // RVA: 0x7A80DA7B0
        public void ToAsn1Object(){} // RVA: 0x7B15EDDC0
    }

    public class OtherRevVals : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15EDED0
        public void .ctor(){} // RVA: 0x7B15EE3A0
        public void get_OtherRevValType(){} // RVA: 0x7A80F2570
        public void get_OtherRevValsObject(){} // RVA: 0x7A80DA7B0
        public void ToAsn1Object(){} // RVA: 0x7B15EE520
    }

    public class OtherSigningCertificate : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15EE630
        public void .ctor(){} // RVA: 0x7B15EECA0
        public void GetCerts(){} // RVA: 0x7B15EF050
        public void GetPolicies(){} // RVA: 0x7B15EF220
        public void ToAsn1Object(){} // RVA: 0x7B15EF3F0
    }

    public class RevocationValues : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15EF600
        public void .ctor(){} // RVA: 0x7B15EFF70
        public void GetCrlVals(){} // RVA: 0x7B15F0410
        public void GetOcspVals(){} // RVA: 0x7B15F05E0
        public void get_OtherRevVals(){} // RVA: 0x7A81052C0
        public void ToAsn1Object(){} // RVA: 0x7B15F07B0
    }

    public class SigPolicyQualifierInfo : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15F3280
        public void .ctor(){} // RVA: 0x7B15F3750
        public void get_SigPolicyQualifierId(){} // RVA: 0x7A80F2570
        public void get_SigQualifier(){} // RVA: 0x7A80DA7B0
        public void ToAsn1Object(){} // RVA: 0x7B15F3840
    }

    public class SignaturePolicyId : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15F0B20
        public void .ctor(){} // RVA: 0x7B15F13E0
        public void get_SigPolicyIdentifier(){} // RVA: 0x7A80F2570
        public void get_SigPolicyHash(){} // RVA: 0x7A80DA7B0
        public void GetSigPolicyQualifiers(){} // RVA: 0x7B15F16A0
        public void ToAsn1Object(){} // RVA: 0x7B15F1850
    }

    public class SignaturePolicyIdentifier : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15F1AB0
        public void .ctor(){} // RVA: 0x7B15F1D90
        public void get_SignaturePolicyId(){} // RVA: 0x7A80F2570
        public void ToAsn1Object(){} // RVA: 0x7B15F1E40
    }

    public class SignerAttribute : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15F1ED0
        public void .ctor(){} // RVA: 0x7A813E420
        public void get_ClaimedAttributes(){} // RVA: 0x7A80F2570
        public void get_CertifiedAttributes(){} // RVA: 0x7A80DA7B0
        public void ToAsn1Object(){} // RVA: 0x7B15F22A0
    }

    public class SignerLocation : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B15F2A00
        public void GetInstance(){} // RVA: 0x7B15F2A70
        public void get_Country(){} // RVA: 0x7A80F2570
        public void get_Locality(){} // RVA: 0x7A80DA7B0
        public void GetPostal(){} // RVA: 0x7B15F2B40
        public void get_CountryName(){} // RVA: 0x7B15F2CD0
        public void get_LocalityName(){} // RVA: 0x7B15F2DF0
        public void get_PostalAddress(){} // RVA: 0x7A81052C0
        public void ToAsn1Object(){} // RVA: 0x7B15F2F10
    }

}