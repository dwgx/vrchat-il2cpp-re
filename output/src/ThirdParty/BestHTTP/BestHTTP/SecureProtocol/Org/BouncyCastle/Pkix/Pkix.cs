// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Pkix
// Classes: 23
// Methods: 290

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Pkix
{
    public class CertStatus
    {
        // ── Methods ──
        public void get_RevocationDate(){} // RVA: 0x7FFAF2D907C0
        public void set_RevocationDate(){} // RVA: 0x7FFAF2DF3E80
        public void get_Status(){} // RVA: 0x7FFAF2DDA5C0
        public void set_Status(){} // RVA: 0x7FFAF2D900C0
        public void .ctor(){} // RVA: 0x7FFAFC1A48F0
    }

    public class PkixAttrCertChecker
    {
        // ── Methods ──
        public void GetSupportedExtensions(){} // RVA: 0x7FFAF2ABCD60
        public void Check(){} // RVA: 0x7FFAF2ADF9F0
        public void Clone(){} // RVA: 0x7FFAF2ABCD60
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class PkixAttrCertPathBuilder
    {
        // ── Methods ──
        public void Build(){} // RVA: 0x7FFAFC1A52E0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class PkixAttrCertPathValidator
    {
        // ── Methods ──
        public void Validate(){} // RVA: 0x7FFAFC1A5AA0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class PkixBuilderParameters
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC1A5F60
        public void .ctor(){} // RVA: 0x7FFAFC1A6070
        public void get_MaxPathLength(){} // RVA: 0x7FFAF315FD40
        public void set_MaxPathLength(){} // RVA: 0x7FFAFC1A6160
        public void GetExcludedCerts(){} // RVA: 0x7FFAFC1A61D0
        public void SetExcludedCerts(){} // RVA: 0x7FFAFC1A6230
        public void SetParams(){} // RVA: 0x7FFAFC1A6370
        public void Clone(){} // RVA: 0x7FFAFC1A64D0
        public void ToString(){} // RVA: 0x7FFAFC1A65A0
    }

    public class PkixCertPath
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAFC1A6750
        public void SortCerts(){} // RVA: 0x7FFAFC1A68F0
        public void .ctor(){} // RVA: 0x7FFAFC1A7190 | overloaded x3
        public void get_Encodings(){} // RVA: 0x7FFAFC1A79C0
        public void Equals(){} // RVA: 0x7FFAFC1A7AE0
        public void GetHashCode(){} // RVA: 0x7FFAF96FD8F0
        public void GetEncoded(){} // RVA: 0x7FFAFC1A7F00 | overloaded x2
        public void get_Certificates(){} // RVA: 0x7FFAFC1A8A70
        public void ToAsn1Object(){} // RVA: 0x7FFAFC1A8A80
        public void ToDerEncoded(){} // RVA: 0x7FFAFC1A8B30
    }

    public class PkixCertPathBuilder
    {
        // ── Methods ──
        public void Build(){} // RVA: 0x7FFAFC1A92F0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class PkixCertPathBuilderException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC1A9B00 | overloaded x3
    }

    public class PkixCertPathBuilderResult
    {
        public object PolicyTree;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC1A9B10
        public void get_CertPath(){} // RVA: 0x7FFAF2DBB130
        public void ToString(){} // RVA: 0x7FFAFC1A9BF0
    }

    public class PkixCertPathChecker
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void Init(){} // RVA: 0x7FFAF2AD5130
        public void IsForwardCheckingSupported(){} // RVA: 0x7FFAF2ABDBE0
        public void GetSupportedExtensions(){} // RVA: 0x7FFAF2ABCD60
        public void Check(){} // RVA: 0x7FFAF2ADDC60
        public void Clone(){} // RVA: 0x7FFAF882B480
    }

    public class PkixCertPathValidator
    {
        // ── Methods ──
        public void Validate(){} // RVA: 0x7FFAFC1A9ED0
        public void CheckCertificate(){} // RVA: 0x7FFAFC1AB6D0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class PkixCertPathValidatorException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC1AB920 | overloaded x4
        public void get_Message(){} // RVA: 0x7FFAFC1ABB70
        public void get_CertPath(){} // RVA: 0x7FFAF34CC8C0
        public void get_Index(){} // RVA: 0x7FFAF4826590
    }

    public class PkixCertPathValidatorResult
    {
        // ── Methods ──
        public void get_PolicyTree(){} // RVA: 0x7FFAF2D907C0
        public void get_TrustAnchor(){} // RVA: 0x7FFAF2DA8380
        public void get_SubjectPublicKey(){} // RVA: 0x7FFAF2DBB0C0
        public void .ctor(){} // RVA: 0x7FFAFC1ABBC0
        public void Clone(){} // RVA: 0x7FFAFC1ABD80
        public void ToString(){} // RVA: 0x7FFAFC1ABE10
    }

    public class PkixCertPathValidatorUtilities
    {
        // ── Methods ──
        public void FindTrustAnchor(){} // RVA: 0x7FFAFC1AC0C0
        public void IsIssuerTrustAnchor(){} // RVA: 0x7FFAFC1AC520
        public void AddAdditionalStoresFromAltNames(){} // RVA: 0x7FFAFC1AC590
        public void GetValidDate(){} // RVA: 0x7FFAFC1AC920
        public void GetIssuerPrincipal(){} // RVA: 0x7FFAFC1AC9A0
        public void IsSelfIssued(){} // RVA: 0x7FFAFC1ACAF0
        public void GetAlgorithmIdentifier(){} // RVA: 0x7FFAFC1ACB60
        public void IsAnyPolicy(){} // RVA: 0x7FFAFC1ACBF0
        public void AddAdditionalStoreFromLocation(){} // RVA: 0x7FFAFC1ACCB0
        public void GetSerialNumber(){} // RVA: 0x7FFAFC1ACE80
        public void GetQualifierSet(){} // RVA: 0x7FFAFC1ACF90
        public void RemovePolicyNode(){} // RVA: 0x7FFAFC1AD250
        public void RemovePolicyNodeRecurse(){} // RVA: 0x7FFAFC1AD420
        public void PrepareNextCertB1(){} // RVA: 0x7FFAFC1AD720
        public void PrepareNextCertB2(){} // RVA: 0x7FFAFC1ADF80
        public void GetCertStatus(){} // RVA: 0x7FFAFC1AE440
        public void GetNextWorkingKey(){} // RVA: 0x7FFAFC1AEB10
        public void GetValidCertDateFromValidityModel(){} // RVA: 0x7FFAFC1AEEE0
        public void FindCertificates(){} // RVA: 0x7FFAFC1B0BB0 | overloaded x2
        public void GetCrlIssuersFromDistributionPoint(){} // RVA: 0x7FFAFC1AF6B0
        public void GetCompleteCrls(){} // RVA: 0x7FFAFC1AFAF0
        public void GetDeltaCrls(){} // RVA: 0x7FFAFC1B0190
        public void isDeltaCrl(){} // RVA: 0x7FFAFC1B0B00
        public void AddAdditionalStoresFromCrlDistributionPoint(){} // RVA: 0x7FFAFC1B0FA0
        public void ProcessCertD1i(){} // RVA: 0x7FFAFC1B1180
        public void ProcessCertD1ii(){} // RVA: 0x7FFAFC1B1440
        public void FindIssuerCerts(){} // RVA: 0x7FFAFC1B1740
        public void GetExtensionValue(){} // RVA: 0x7FFAFC1B19D0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAFC1B1A60
    }

    public class PkixCrlUtilities
    {
        // ── Methods ──
        public void FindCrls(){} // RVA: 0x7FFAFC1B25A0 | overloaded x3
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class PkixNameConstraintValidator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC1B28A0
        public void WithinDNSubtree(){} // RVA: 0x7FFAFC1B2B20
        public void CheckPermittedDN(){} // RVA: 0x7FFAFC1B2ED0 | overloaded x2
        public void CheckExcludedDN(){} // RVA: 0x7FFAFC1B30B0 | overloaded x2
        public void IntersectDN(){} // RVA: 0x7FFAFC1B3270
        public void UnionDN(){} // RVA: 0x7FFAFC1B3570
        public void IntersectEmail(){} // RVA: 0x7FFAFC1B38A0
        public void UnionEmail(){} // RVA: 0x7FFAFC1B6070 | overloaded x2
        public void IntersectIP(){} // RVA: 0x7FFAFC1B3D90
        public void UnionIP(){} // RVA: 0x7FFAFC1B4020
        public void UnionIPRange(){} // RVA: 0x7FFAFC1B4330
        public void IntersectIPRange(){} // RVA: 0x7FFAFC1B44A0
        public void IpWithSubnetMask(){} // RVA: 0x7FFAFC1B4A10
        public void ExtractIPsAndSubnetMasks(){} // RVA: 0x7FFAFC1B4AC0
        public void MinMaxIPs(){} // RVA: 0x7FFAFC1B4C60
        public void CheckPermittedEmail(){} // RVA: 0x7FFAFC1B4EC0
        public void CheckExcludedEmail(){} // RVA: 0x7FFAFC1B5050
        public void CheckPermittedIP(){} // RVA: 0x7FFAFC1B51C0
        public void CheckExcludedIP(){} // RVA: 0x7FFAFC1B5360
        public void IsIPConstrained(){} // RVA: 0x7FFAFC1B5500
        public void EmailIsConstrained(){} // RVA: 0x7FFAFC1B5720
        public void WithinDomain(){} // RVA: 0x7FFAFC1B5910
        public void CheckPermittedDns(){} // RVA: 0x7FFAFC1B5B70
        public void CheckExcludedDns(){} // RVA: 0x7FFAFC1B5E20
        public void unionURI(){} // RVA: 0x7FFAFC1B74B0 | overloaded x2
        public void intersectDNS(){} // RVA: 0x7FFAFC1B67B0
        public void unionDNS(){} // RVA: 0x7FFAFC1B6A80
        public void intersectEmail(){} // RVA: 0x7FFAFC1B6D60
        public void checkExcludedURI(){} // RVA: 0x7FFAFC1B70D0
        public void intersectURI(){} // RVA: 0x7FFAFC1B7730 | overloaded x2
        public void CheckPermittedURI(){} // RVA: 0x7FFAFC1B7AA0
        public void IsUriConstrained(){} // RVA: 0x7FFAFC1B7C30
        public void ExtractHostFromURL(){} // RVA: 0x7FFAFC1B7D50
        public void checkPermitted(){} // RVA: 0x7FFAFC1B7F20
        public void checkExcluded(){} // RVA: 0x7FFAFC1B8500
        public void IntersectPermittedSubtree(){} // RVA: 0x7FFAFC1B8AB0
        public void ExtractNameAsString(){} // RVA: 0x7FFAFC1B92A0
        public void IntersectEmptyPermittedSubtree(){} // RVA: 0x7FFAFC1B92E0
        public void AddExcludedSubtree(){} // RVA: 0x7FFAFC1B9440
        public void Max(){} // RVA: 0x7FFAFC1B96B0
        public void Min(){} // RVA: 0x7FFAFC1B9720
        public void CompareTo(){} // RVA: 0x7FFAFC1B9790
        public void Or(){} // RVA: 0x7FFAFC1B99D0
        public void HashCode(){} // RVA: 0x7FFAFC1B9A70
        public void GetHashCode(){} // RVA: 0x7FFAFC1B9A90
        public void HashCollection(){} // RVA: 0x7FFAFC1B9B90
        public void Equals(){} // RVA: 0x7FFAFC1B9E40
        public void CollectionsAreEqual(){} // RVA: 0x7FFAFC1B9FF0
        public void SpecialEquals(){} // RVA: 0x7FFAFC1BA180
        public void StringifyIP(){} // RVA: 0x7FFAFC1BA2E0
        public void StringifyIPCollection(){} // RVA: 0x7FFAFC1BA540
        public void ToString(){} // RVA: 0x7FFAFC1BA7E0
        public void .cctor(){} // RVA: 0x7FFAFC1BAC90
    }

    public class PkixNameConstraintValidatorException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC3453F0
    }

    public class PkixParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC345450
        public void get_IsRevocationEnabled(){} // RVA: 0x7FFAF3198A80
        public void set_IsRevocationEnabled(){} // RVA: 0x7FFAF3198B80
        public void get_IsExplicitPolicyRequired(){} // RVA: 0x7FFAF2F56500
        public void set_IsExplicitPolicyRequired(){} // RVA: 0x7FFAF2F578C0
        public void get_IsAnyPolicyInhibited(){} // RVA: 0x7FFAF2F57410
        public void set_IsAnyPolicyInhibited(){} // RVA: 0x7FFAF2F57670
        public void get_IsPolicyMappingInhibited(){} // RVA: 0x7FFAF3F7EB40
        public void set_IsPolicyMappingInhibited(){} // RVA: 0x7FFAF87A4B50
        public void get_IsPolicyQualifiersRejected(){} // RVA: 0x7FFAF3F79240
        public void set_IsPolicyQualifiersRejected(){} // RVA: 0x7FFAF912D380
        public void get_Date(){} // RVA: 0x7FFAF2D907C0
        public void set_Date(){} // RVA: 0x7FFAF2DF3E80
        public void GetTrustAnchors(){} // RVA: 0x7FFAFC3458C0
        public void SetTrustAnchors(){} // RVA: 0x7FFAFC345920
        public void GetTargetCertConstraints(){} // RVA: 0x7FFAFC345CC0
        public void SetTargetCertConstraints(){} // RVA: 0x7FFAFC345D60
        public void GetInitialPolicies(){} // RVA: 0x7FFAFC345EF0
        public void SetInitialPolicies(){} // RVA: 0x7FFAFC345F70
        public void SetCertPathCheckers(){} // RVA: 0x7FFAFC346230
        public void GetCertPathCheckers(){} // RVA: 0x7FFAFC3465E0
        public void AddCertPathChecker(){} // RVA: 0x7FFAFC346930
        public void Clone(){} // RVA: 0x7FFAFC3469B0
        public void SetParams(){} // RVA: 0x7FFAFC346A60
        public void get_IsUseDeltasEnabled(){} // RVA: 0x7FFAF2DF5520
        public void set_IsUseDeltasEnabled(){} // RVA: 0x7FFAF2DF5530
        public void get_ValidityModel(){} // RVA: 0x7FFAF36690C0
        public void set_ValidityModel(){} // RVA: 0x7FFAF3669E60
        public void SetStores(){} // RVA: 0x7FFAFC347100
        public void AddStore(){} // RVA: 0x7FFAFC347480
        public void AddAdditionalStore(){} // RVA: 0x7FFAFC3474F0
        public void GetAdditionalStores(){} // RVA: 0x7FFAFC347560
        public void GetStores(){} // RVA: 0x7FFAFC347600
        public void get_IsAdditionalLocationsEnabled(){} // RVA: 0x7FFAF304FF30
        public void SetAdditionalLocationsEnabled(){} // RVA: 0x7FFAF370F680
        public void GetTargetConstraints(){} // RVA: 0x7FFAFC3476A0
        public void SetTargetConstraints(){} // RVA: 0x7FFAFC347740
        public void GetTrustedACIssuers(){} // RVA: 0x7FFAFC3478C0
        public void SetTrustedACIssuers(){} // RVA: 0x7FFAFC347920
        public void GetNecessaryACAttributes(){} // RVA: 0x7FFAFC347CB0
        public void SetNecessaryACAttributes(){} // RVA: 0x7FFAFC347D10
        public void GetProhibitedACAttributes(){} // RVA: 0x7FFAFC348010
        public void SetProhibitedACAttributes(){} // RVA: 0x7FFAFC348070
        public void GetAttrCertCheckers(){} // RVA: 0x7FFAFC348370
        public void SetAttrCertCheckers(){} // RVA: 0x7FFAFC3483D0
    }

    public class PkixPolicyNode
    {
        // ── Methods ──
        public void get_Depth(){} // RVA: 0x7FFAF306ED50
        public void get_Children(){} // RVA: 0x7FFAFC348760
        public void get_IsCritical(){} // RVA: 0x7FFAF2E48C00
        public void set_IsCritical(){} // RVA: 0x7FFAF2E48C10
        public void get_PolicyQualifiers(){} // RVA: 0x7FFAFC348850
        public void get_ValidPolicy(){} // RVA: 0x7FFAF2F476A0
        public void get_HasChildren(){} // RVA: 0x7FFAFC3488B0
        public void get_ExpectedPolicies(){} // RVA: 0x7FFAFC348910
        public void set_ExpectedPolicies(){} // RVA: 0x7FFAFC348970
        public void get_Parent(){} // RVA: 0x7FFAF2DBB130
        public void set_Parent(){} // RVA: 0x7FFAF2D8EE90
        public void .ctor(){} // RVA: 0x7FFAFC348A30
        public void AddChild(){} // RVA: 0x7FFAFC348D40
        public void RemoveChild(){} // RVA: 0x7FFAFC348DC0
        public void ToString(){} // RVA: 0x7FFAFC348E70 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAF631F560
        public void Copy(){} // RVA: 0x7FFAFC349250
    }

    public class ReasonsMask
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF350D070 | overloaded x2
        public void AddReasons(){} // RVA: 0x7FFAFC349620
        public void get_IsAllReasons(){} // RVA: 0x7FFAFC349680
        public void Intersect(){} // RVA: 0x7FFAFC3496F0
        public void HasNewReasons(){} // RVA: 0x7FFAFC3497D0
        public void get_Reasons(){} // RVA: 0x7FFAFC349830
        public void .cctor(){} // RVA: 0x7FFAFC3498D0
    }

    public class Rfc3280CertPathUtilities
    {
        // ── Methods ──
        public void ProcessCrlB2(){} // RVA: 0x7FFAFC349980
        public void ProcessCertBC(){} // RVA: 0x7FFAFC34A790
        public void PrepareNextCertA(){} // RVA: 0x7FFAFC34B030
        public void ProcessCertD(){} // RVA: 0x7FFAFC34B570
        public void ProcessCrlB1(){} // RVA: 0x7FFAFC34C930
        public void ProcessCrlD(){} // RVA: 0x7FFAFC34CD60
        public void ProcessCrlF(){} // RVA: 0x7FFAFC34D0A0
        public void ProcessCrlG(){} // RVA: 0x7FFAFC34DB30
        public void ProcessCrlH(){} // RVA: 0x7FFAFC34DDC0
        public void CheckCrl(){} // RVA: 0x7FFAFC34E080
        public void CheckCrls(){} // RVA: 0x7FFAFC34EAF0
        public void PrepareCertB(){} // RVA: 0x7FFAFC34F5D0
        public void ProcessCrlA1ii(){} // RVA: 0x7FFAFC350C80
        public void ProcessCrlA1i(){} // RVA: 0x7FFAFC3510E0
        public void ProcessCertF(){} // RVA: 0x7FFAFC351520
        public void ProcessCertA(){} // RVA: 0x7FFAFC3515B0
        public void PrepareNextCertI1(){} // RVA: 0x7FFAFC351C20
        public void PrepareNextCertI2(){} // RVA: 0x7FFAFC351FA0
        public void PrepareNextCertG(){} // RVA: 0x7FFAFC352320
        public void PrepareNextCertJ(){} // RVA: 0x7FFAFC3527B0
        public void PrepareNextCertK(){} // RVA: 0x7FFAFC352A40
        public void PrepareNextCertL(){} // RVA: 0x7FFAFC352D10
        public void PrepareNextCertM(){} // RVA: 0x7FFAFC352EE0
        public void PrepareNextCertN(){} // RVA: 0x7FFAFC353170
        public void PrepareNextCertO(){} // RVA: 0x7FFAFC353310
        public void PrepareNextCertH1(){} // RVA: 0x7FFAFC353610
        public void PrepareNextCertH2(){} // RVA: 0x7FFAFC353780
        public void PrepareNextCertH3(){} // RVA: 0x7FFAFC3538F0
        public void WrapupCertA(){} // RVA: 0x7FFAFC353A60
        public void WrapupCertB(){} // RVA: 0x7FFAFC353B20
        public void WrapupCertF(){} // RVA: 0x7FFAFC353EE0
        public void WrapupCertG(){} // RVA: 0x7FFAFC3541C0
        public void ProcessCrlC(){} // RVA: 0x7FFAFC355060
        public void ProcessCrlI(){} // RVA: 0x7FFAFC355640
        public void ProcessCrlJ(){} // RVA: 0x7FFAFC355700
        public void ProcessCertE(){} // RVA: 0x7FFAFC3557A0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAFC3559E0
    }

    public class Rfc3281CertPathUtilities
    {
        // ── Methods ──
        public void ProcessAttrCert7(){} // RVA: 0x7FFAFC355D90
        public void CheckCrls(){} // RVA: 0x7FFAFC3562E0
        public void AdditionalChecks(){} // RVA: 0x7FFAFC356F10
        public void ProcessAttrCert5(){} // RVA: 0x7FFAFC357360
        public void ProcessAttrCert4(){} // RVA: 0x7FFAFC357510
        public void ProcessAttrCert3(){} // RVA: 0x7FFAFC3578E0
        public void ProcessAttrCert2(){} // RVA: 0x7FFAFC357A30
        public void ProcessAttrCert1(){} // RVA: 0x7FFAFC357B10
        public void CheckCrl(){} // RVA: 0x7FFAFC358400
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class TrustAnchor
    {
        public object Key;
        public object .ctor;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC358FA0 | overloaded x3
        public void get_TrustedCert(){} // RVA: 0x7FFAF2DBB130
        public void get_CA(){} // RVA: 0x7FFAF2DBB0C0
        public void get_CAName(){} // RVA: 0x7FFAF2D907C0
        public void get_CAPublicKey(){} // RVA: 0x7FFAF2DA8380
        public void setNameConstraints(){} // RVA: 0x7FFAFC359160
        public void get_GetNameConstraints(){} // RVA: 0x7FFAFC359390
        public void ToString(){} // RVA: 0x7FFAFC359440
    }

}