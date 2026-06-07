// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Pkix
// Classes: 23
// Methods: 290

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Pkix
{
    public class CertStatus
    {
        // ── Methods ──
        public void get_RevocationDate(){} // RVA: 0x2E07C0
        public void set_RevocationDate(){} // RVA: 0x343E80
        public void get_Status(){} // RVA: 0x32A5C0
        public void set_Status(){} // RVA: 0x2E00C0
        public void .ctor(){} // RVA: 0x96F48F0
    }

    public class PkixAttrCertChecker
    {
        // ── Methods ──
        public void GetSupportedExtensions(){} // RVA: 0xCD60
        public void Check(){} // RVA: 0x2F9F0
        public void Clone(){} // RVA: 0xCD60
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class PkixAttrCertPathBuilder
    {
        // ── Methods ──
        public void Build(){} // RVA: 0x96F52E0 | overloaded x2
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class PkixAttrCertPathValidator
    {
        // ── Methods ──
        public void Validate(){} // RVA: 0x96F5AA0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class PkixBuilderParameters
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x96F5F60
        public void .ctor(){} // RVA: 0x96F6070
        public void get_MaxPathLength(){} // RVA: 0x6AFD40
        public void set_MaxPathLength(){} // RVA: 0x96F6160
        public void GetExcludedCerts(){} // RVA: 0x96F61D0
        public void SetExcludedCerts(){} // RVA: 0x96F6230
        public void SetParams(){} // RVA: 0x96F6370
        public void Clone(){} // RVA: 0x96F64D0
        public void ToString(){} // RVA: 0x96F65A0
    }

    public class PkixCertPath
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x96F6750
        public void SortCerts(){} // RVA: 0x96F68F0
        public void .ctor(){} // RVA: 0x96F7190 | overloaded x3
        public void get_Encodings(){} // RVA: 0x96F79C0
        public void Equals(){} // RVA: 0x96F7AE0
        public void GetHashCode(){} // RVA: 0x6C4D8F0
        public void GetEncoded(){} // RVA: 0x96F7F00 | overloaded x2
        public void get_Certificates(){} // RVA: 0x96F8A70
        public void ToAsn1Object(){} // RVA: 0x96F8A80
        public void ToDerEncoded(){} // RVA: 0x96F8B30
    }

    public class PkixCertPathBuilder
    {
        // ── Methods ──
        public void Build(){} // RVA: 0x96F92F0 | overloaded x2
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class PkixCertPathBuilderException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x96F9B00 | overloaded x3
    }

    public class PkixCertPathBuilderResult
    {
        public object PolicyTree;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x96F9B10
        public void get_CertPath(){} // RVA: 0x30B130
        public void ToString(){} // RVA: 0x96F9BF0
    }

    public class PkixCertPathChecker
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void Init(){} // RVA: 0x25130
        public void IsForwardCheckingSupported(){} // RVA: 0xDBE0
        public void GetSupportedExtensions(){} // RVA: 0xCD60
        public void Check(){} // RVA: 0x2DC60
        public void Clone(){} // RVA: 0x5D7B480
    }

    public class PkixCertPathValidator
    {
        // ── Methods ──
        public void Validate(){} // RVA: 0x96F9ED0
        public void CheckCertificate(){} // RVA: 0x96FB6D0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class PkixCertPathValidatorException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x96FB920 | overloaded x4
        public void get_Message(){} // RVA: 0x96FBB70
        public void get_CertPath(){} // RVA: 0xA1C8C0
        public void get_Index(){} // RVA: 0x1D76590
    }

    public class PkixCertPathValidatorResult
    {
        // ── Methods ──
        public void get_PolicyTree(){} // RVA: 0x2E07C0
        public void get_TrustAnchor(){} // RVA: 0x2F8380
        public void get_SubjectPublicKey(){} // RVA: 0x30B0C0
        public void .ctor(){} // RVA: 0x96FBBC0
        public void Clone(){} // RVA: 0x96FBD80
        public void ToString(){} // RVA: 0x96FBE10
    }

    public class PkixCertPathValidatorUtilities
    {
        // ── Methods ──
        public void FindTrustAnchor(){} // RVA: 0x96FC0C0
        public void IsIssuerTrustAnchor(){} // RVA: 0x96FC520
        public void AddAdditionalStoresFromAltNames(){} // RVA: 0x96FC590
        public void GetValidDate(){} // RVA: 0x96FC920
        public void GetIssuerPrincipal(){} // RVA: 0x96FC9A0
        public void IsSelfIssued(){} // RVA: 0x96FCAF0
        public void GetAlgorithmIdentifier(){} // RVA: 0x96FCB60
        public void IsAnyPolicy(){} // RVA: 0x96FCBF0
        public void AddAdditionalStoreFromLocation(){} // RVA: 0x96FCCB0
        public void GetSerialNumber(){} // RVA: 0x96FCE80
        public void GetQualifierSet(){} // RVA: 0x96FCF90
        public void RemovePolicyNode(){} // RVA: 0x96FD250
        public void RemovePolicyNodeRecurse(){} // RVA: 0x96FD420
        public void PrepareNextCertB1(){} // RVA: 0x96FD720
        public void PrepareNextCertB2(){} // RVA: 0x96FDF80
        public void GetCertStatus(){} // RVA: 0x96FE440
        public void GetNextWorkingKey(){} // RVA: 0x96FEB10
        public void GetValidCertDateFromValidityModel(){} // RVA: 0x96FEEE0
        public void FindCertificates(){} // RVA: 0x9700BB0 | overloaded x2
        public void GetCrlIssuersFromDistributionPoint(){} // RVA: 0x96FF6B0
        public void GetCompleteCrls(){} // RVA: 0x96FFAF0
        public void GetDeltaCrls(){} // RVA: 0x9700190
        public void isDeltaCrl(){} // RVA: 0x9700B00
        public void AddAdditionalStoresFromCrlDistributionPoint(){} // RVA: 0x9700FA0
        public void ProcessCertD1i(){} // RVA: 0x9701180
        public void ProcessCertD1ii(){} // RVA: 0x9701440
        public void FindIssuerCerts(){} // RVA: 0x9701740
        public void GetExtensionValue(){} // RVA: 0x97019D0
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x9701A60
    }

    public class PkixCrlUtilities
    {
        // ── Methods ──
        public void FindCrls(){} // RVA: 0x97025A0 | overloaded x3
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class PkixNameConstraintValidator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x97028A0
        public void WithinDNSubtree(){} // RVA: 0x9702B20
        public void CheckPermittedDN(){} // RVA: 0x9702ED0 | overloaded x2
        public void CheckExcludedDN(){} // RVA: 0x97030B0 | overloaded x2
        public void IntersectDN(){} // RVA: 0x9703270
        public void UnionDN(){} // RVA: 0x9703570
        public void IntersectEmail(){} // RVA: 0x97038A0
        public void UnionEmail(){} // RVA: 0x9706070 | overloaded x2
        public void IntersectIP(){} // RVA: 0x9703D90
        public void UnionIP(){} // RVA: 0x9704020
        public void UnionIPRange(){} // RVA: 0x9704330
        public void IntersectIPRange(){} // RVA: 0x97044A0
        public void IpWithSubnetMask(){} // RVA: 0x9704A10
        public void ExtractIPsAndSubnetMasks(){} // RVA: 0x9704AC0
        public void MinMaxIPs(){} // RVA: 0x9704C60
        public void CheckPermittedEmail(){} // RVA: 0x9704EC0
        public void CheckExcludedEmail(){} // RVA: 0x9705050
        public void CheckPermittedIP(){} // RVA: 0x97051C0
        public void CheckExcludedIP(){} // RVA: 0x9705360
        public void IsIPConstrained(){} // RVA: 0x9705500
        public void EmailIsConstrained(){} // RVA: 0x9705720
        public void WithinDomain(){} // RVA: 0x9705910
        public void CheckPermittedDns(){} // RVA: 0x9705B70
        public void CheckExcludedDns(){} // RVA: 0x9705E20
        public void unionURI(){} // RVA: 0x97074B0 | overloaded x2
        public void intersectDNS(){} // RVA: 0x97067B0
        public void unionDNS(){} // RVA: 0x9706A80
        public void intersectEmail(){} // RVA: 0x9706D60
        public void checkExcludedURI(){} // RVA: 0x97070D0
        public void intersectURI(){} // RVA: 0x9707730 | overloaded x2
        public void CheckPermittedURI(){} // RVA: 0x9707AA0
        public void IsUriConstrained(){} // RVA: 0x9707C30
        public void ExtractHostFromURL(){} // RVA: 0x9707D50
        public void checkPermitted(){} // RVA: 0x9707F20
        public void checkExcluded(){} // RVA: 0x9708500
        public void IntersectPermittedSubtree(){} // RVA: 0x9708AB0
        public void ExtractNameAsString(){} // RVA: 0x97092A0
        public void IntersectEmptyPermittedSubtree(){} // RVA: 0x97092E0
        public void AddExcludedSubtree(){} // RVA: 0x9709440
        public void Max(){} // RVA: 0x97096B0
        public void Min(){} // RVA: 0x9709720
        public void CompareTo(){} // RVA: 0x9709790
        public void Or(){} // RVA: 0x97099D0
        public void HashCode(){} // RVA: 0x9709A70
        public void GetHashCode(){} // RVA: 0x9709A90
        public void HashCollection(){} // RVA: 0x9709B90
        public void Equals(){} // RVA: 0x9709E40
        public void CollectionsAreEqual(){} // RVA: 0x9709FF0
        public void SpecialEquals(){} // RVA: 0x970A180
        public void StringifyIP(){} // RVA: 0x970A2E0
        public void StringifyIPCollection(){} // RVA: 0x970A540
        public void ToString(){} // RVA: 0x970A7E0
        public void .cctor(){} // RVA: 0x970AC90
    }

    public class PkixNameConstraintValidatorException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x98953F0
    }

    public class PkixParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9895450
        public void get_IsRevocationEnabled(){} // RVA: 0x6E8A80
        public void set_IsRevocationEnabled(){} // RVA: 0x6E8B80
        public void get_IsExplicitPolicyRequired(){} // RVA: 0x4A6500
        public void set_IsExplicitPolicyRequired(){} // RVA: 0x4A78C0
        public void get_IsAnyPolicyInhibited(){} // RVA: 0x4A7410
        public void set_IsAnyPolicyInhibited(){} // RVA: 0x4A7670
        public void get_IsPolicyMappingInhibited(){} // RVA: 0x14CEB40
        public void set_IsPolicyMappingInhibited(){} // RVA: 0x5CF4B50
        public void get_IsPolicyQualifiersRejected(){} // RVA: 0x14C9240
        public void set_IsPolicyQualifiersRejected(){} // RVA: 0x667D380
        public void get_Date(){} // RVA: 0x2E07C0
        public void set_Date(){} // RVA: 0x343E80
        public void GetTrustAnchors(){} // RVA: 0x98958C0
        public void SetTrustAnchors(){} // RVA: 0x9895920
        public void GetTargetCertConstraints(){} // RVA: 0x9895CC0
        public void SetTargetCertConstraints(){} // RVA: 0x9895D60
        public void GetInitialPolicies(){} // RVA: 0x9895EF0
        public void SetInitialPolicies(){} // RVA: 0x9895F70
        public void SetCertPathCheckers(){} // RVA: 0x9896230
        public void GetCertPathCheckers(){} // RVA: 0x98965E0
        public void AddCertPathChecker(){} // RVA: 0x9896930
        public void Clone(){} // RVA: 0x98969B0
        public void SetParams(){} // RVA: 0x9896A60
        public void get_IsUseDeltasEnabled(){} // RVA: 0x345520
        public void set_IsUseDeltasEnabled(){} // RVA: 0x345530
        public void get_ValidityModel(){} // RVA: 0xBB90C0
        public void set_ValidityModel(){} // RVA: 0xBB9E60
        public void SetStores(){} // RVA: 0x9897100
        public void AddStore(){} // RVA: 0x9897480
        public void AddAdditionalStore(){} // RVA: 0x98974F0
        public void GetAdditionalStores(){} // RVA: 0x9897560
        public void GetStores(){} // RVA: 0x9897600
        public void get_IsAdditionalLocationsEnabled(){} // RVA: 0x59FF30
        public void SetAdditionalLocationsEnabled(){} // RVA: 0xC5F680
        public void GetTargetConstraints(){} // RVA: 0x98976A0
        public void SetTargetConstraints(){} // RVA: 0x9897740
        public void GetTrustedACIssuers(){} // RVA: 0x98978C0
        public void SetTrustedACIssuers(){} // RVA: 0x9897920
        public void GetNecessaryACAttributes(){} // RVA: 0x9897CB0
        public void SetNecessaryACAttributes(){} // RVA: 0x9897D10
        public void GetProhibitedACAttributes(){} // RVA: 0x9898010
        public void SetProhibitedACAttributes(){} // RVA: 0x9898070
        public void GetAttrCertCheckers(){} // RVA: 0x9898370
        public void SetAttrCertCheckers(){} // RVA: 0x98983D0
    }

    public class PkixPolicyNode
    {
        // ── Methods ──
        public void get_Depth(){} // RVA: 0x5BED50
        public void get_Children(){} // RVA: 0x9898760
        public void get_IsCritical(){} // RVA: 0x398C00
        public void set_IsCritical(){} // RVA: 0x398C10
        public void get_PolicyQualifiers(){} // RVA: 0x9898850
        public void get_ValidPolicy(){} // RVA: 0x4976A0
        public void get_HasChildren(){} // RVA: 0x98988B0
        public void get_ExpectedPolicies(){} // RVA: 0x9898910
        public void set_ExpectedPolicies(){} // RVA: 0x9898970
        public void get_Parent(){} // RVA: 0x30B130
        public void set_Parent(){} // RVA: 0x2DEE90
        public void .ctor(){} // RVA: 0x9898A30
        public void AddChild(){} // RVA: 0x9898D40
        public void RemoveChild(){} // RVA: 0x9898DC0
        public void ToString(){} // RVA: 0x9898E70 | overloaded x2
        public void Clone(){} // RVA: 0x386F560
        public void Copy(){} // RVA: 0x9899250
    }

    public class ReasonsMask
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA5D070 | overloaded x2
        public void AddReasons(){} // RVA: 0x9899620
        public void get_IsAllReasons(){} // RVA: 0x9899680
        public void Intersect(){} // RVA: 0x98996F0
        public void HasNewReasons(){} // RVA: 0x98997D0
        public void get_Reasons(){} // RVA: 0x9899830
        public void .cctor(){} // RVA: 0x98998D0
    }

    public class Rfc3280CertPathUtilities
    {
        // ── Methods ──
        public void ProcessCrlB2(){} // RVA: 0x9899980
        public void ProcessCertBC(){} // RVA: 0x989A790
        public void PrepareNextCertA(){} // RVA: 0x989B030
        public void ProcessCertD(){} // RVA: 0x989B570
        public void ProcessCrlB1(){} // RVA: 0x989C930
        public void ProcessCrlD(){} // RVA: 0x989CD60
        public void ProcessCrlF(){} // RVA: 0x989D0A0
        public void ProcessCrlG(){} // RVA: 0x989DB30
        public void ProcessCrlH(){} // RVA: 0x989DDC0
        public void CheckCrl(){} // RVA: 0x989E080
        public void CheckCrls(){} // RVA: 0x989EAF0
        public void PrepareCertB(){} // RVA: 0x989F5D0
        public void ProcessCrlA1ii(){} // RVA: 0x98A0C80
        public void ProcessCrlA1i(){} // RVA: 0x98A10E0
        public void ProcessCertF(){} // RVA: 0x98A1520
        public void ProcessCertA(){} // RVA: 0x98A15B0
        public void PrepareNextCertI1(){} // RVA: 0x98A1C20
        public void PrepareNextCertI2(){} // RVA: 0x98A1FA0
        public void PrepareNextCertG(){} // RVA: 0x98A2320
        public void PrepareNextCertJ(){} // RVA: 0x98A27B0
        public void PrepareNextCertK(){} // RVA: 0x98A2A40
        public void PrepareNextCertL(){} // RVA: 0x98A2D10
        public void PrepareNextCertM(){} // RVA: 0x98A2EE0
        public void PrepareNextCertN(){} // RVA: 0x98A3170
        public void PrepareNextCertO(){} // RVA: 0x98A3310
        public void PrepareNextCertH1(){} // RVA: 0x98A3610
        public void PrepareNextCertH2(){} // RVA: 0x98A3780
        public void PrepareNextCertH3(){} // RVA: 0x98A38F0
        public void WrapupCertA(){} // RVA: 0x98A3A60
        public void WrapupCertB(){} // RVA: 0x98A3B20
        public void WrapupCertF(){} // RVA: 0x98A3EE0
        public void WrapupCertG(){} // RVA: 0x98A41C0
        public void ProcessCrlC(){} // RVA: 0x98A5060
        public void ProcessCrlI(){} // RVA: 0x98A5640
        public void ProcessCrlJ(){} // RVA: 0x98A5700
        public void ProcessCertE(){} // RVA: 0x98A57A0
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x98A59E0
    }

    public class Rfc3281CertPathUtilities
    {
        // ── Methods ──
        public void ProcessAttrCert7(){} // RVA: 0x98A5D90
        public void CheckCrls(){} // RVA: 0x98A62E0
        public void AdditionalChecks(){} // RVA: 0x98A6F10
        public void ProcessAttrCert5(){} // RVA: 0x98A7360
        public void ProcessAttrCert4(){} // RVA: 0x98A7510
        public void ProcessAttrCert3(){} // RVA: 0x98A78E0
        public void ProcessAttrCert2(){} // RVA: 0x98A7A30
        public void ProcessAttrCert1(){} // RVA: 0x98A7B10
        public void CheckCrl(){} // RVA: 0x98A8400
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class TrustAnchor
    {
        public object Key;
        public object .ctor;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x98A8FA0 | overloaded x3
        public void get_TrustedCert(){} // RVA: 0x30B130
        public void get_CA(){} // RVA: 0x30B0C0
        public void get_CAName(){} // RVA: 0x2E07C0
        public void get_CAPublicKey(){} // RVA: 0x2F8380
        public void setNameConstraints(){} // RVA: 0x98A9160
        public void get_GetNameConstraints(){} // RVA: 0x98A9390
        public void ToString(){} // RVA: 0x98A9440
    }

}