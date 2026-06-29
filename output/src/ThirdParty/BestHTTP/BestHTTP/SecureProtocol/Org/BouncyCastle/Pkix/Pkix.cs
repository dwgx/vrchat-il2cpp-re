// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Pkix
// Classes: 23
// Methods: 268

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Pkix
{
    public class CertStatus : Object
    {
        // ── Methods ──
        public void get_RevocationDate(){} // RVA: 0x7A80DA7B0
        public void set_RevocationDate(){} // RVA: 0x7A813E420
        public void get_Status(){} // RVA: 0x7A8124910
        public void set_Status(){} // RVA: 0x7A80DA0C0
        public void .ctor(){} // RVA: 0x7B152E400
    }

    public class PkixAttrCertChecker : Object
    {
        // ── Methods ──
        public void GetSupportedExtensions(){} // RVA: 0x7A7E00680
        public void Check(){} // RVA: 0x7A7E1DB70
        public void Clone(){} // RVA: 0x7A7E00680
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class PkixAttrCertPathBuilder : Object
    {
        // ── Methods ──
        public void Build(){} // RVA: 0x7B152EDF0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class PkixAttrCertPathValidator : Object
    {
        // ── Methods ──
        public void Validate(){} // RVA: 0x7B152F590
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class PkixBuilderParameters : PkixParameters
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B152FA60
        public void .ctor(){} // RVA: 0x7B152FB70
        public void get_MaxPathLength(){} // RVA: 0x7A846C760
        public void set_MaxPathLength(){} // RVA: 0x7B152FC60
        public void GetExcludedCerts(){} // RVA: 0x7B152FCD0
        public void SetExcludedCerts(){} // RVA: 0x7B152FD30
        public void SetParams(){} // RVA: 0x7B152FE70
        public void Clone(){} // RVA: 0x7B152FFD0
        public void ToString(){} // RVA: 0x7B15300A0
    }

    public class PkixCertPath : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7B1530250
        public void SortCerts(){} // RVA: 0x7B15303F0
        public void .ctor(){} // RVA: 0x7B1530CA0
        public void get_Encodings(){} // RVA: 0x7B15314C0
        public void Equals(){} // RVA: 0x7B15315E0
        public void GetHashCode(){} // RVA: 0x7AEA3CAF0
        public void GetEncoded(){} // RVA: 0x7B15319E0
        public void get_Certificates(){} // RVA: 0x7B1532560
        public void ToAsn1Object(){} // RVA: 0x7B1532570
        public void ToDerEncoded(){} // RVA: 0x7B1532620
    }

    public class PkixCertPathBuilder : Object
    {
        // ── Methods ──
        public void Build(){} // RVA: 0x7B1532DC0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class PkixCertPathBuilderException : GeneralSecurityException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B15335C0
    }

    public class PkixCertPathBuilderResult : PkixCertPathValidatorResult
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B15335D0
        public void get_CertPath(){} // RVA: 0x7A8105330
        public void ToString(){} // RVA: 0x7B15336B0
    }

    public class PkixCertPathChecker : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void Init(){} // RVA: 0x7A7E18C30
        public void IsForwardCheckingSupported(){} // RVA: 0x7A7E01900
        public void GetSupportedExtensions(){} // RVA: 0x7A7E00680
        public void Check(){} // RVA: 0x7A7E18890
        public void Clone(){} // RVA: 0x7ADB694F0
    }

    public class PkixCertPathValidator : Object
    {
        // ── Methods ──
        public void Validate(){} // RVA: 0x7B1533990
        public void CheckCertificate(){} // RVA: 0x7B1535190
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class PkixCertPathValidatorException : GeneralSecurityException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B15353E0
        public void get_Message(){} // RVA: 0x7B1535630
        public void get_CertPath(){} // RVA: 0x7A87D9C10
        public void get_Index(){} // RVA: 0x7A9B79A40
    }

    public class PkixCertPathValidatorResult : Object
    {
        // ── Methods ──
        public void get_PolicyTree(){} // RVA: 0x7A80DA7B0
        public void get_TrustAnchor(){} // RVA: 0x7A80F2570
        public void get_SubjectPublicKey(){} // RVA: 0x7A81052C0
        public void .ctor(){} // RVA: 0x7B1535680
        public void Clone(){} // RVA: 0x7B1535840
        public void ToString(){} // RVA: 0x7B15358D0
    }

    public class PkixCertPathValidatorUtilities : Object
    {
        // ── Methods ──
        public void FindTrustAnchor(){} // RVA: 0x7B1535B80
        public void IsIssuerTrustAnchor(){} // RVA: 0x7B1536010
        public void AddAdditionalStoresFromAltNames(){} // RVA: 0x7B1536080
        public void GetValidDate(){} // RVA: 0x7B1536410
        public void GetIssuerPrincipal(){} // RVA: 0x7B1536490
        public void IsSelfIssued(){} // RVA: 0x7B15365E0
        public void GetAlgorithmIdentifier(){} // RVA: 0x7B1536650
        public void IsAnyPolicy(){} // RVA: 0x7B15366E0
        public void AddAdditionalStoreFromLocation(){} // RVA: 0x7B15367A0
        public void GetSerialNumber(){} // RVA: 0x7B1536970
        public void GetQualifierSet(){} // RVA: 0x7B1536A80
        public void RemovePolicyNode(){} // RVA: 0x7B1536D20
        public void RemovePolicyNodeRecurse(){} // RVA: 0x7B1536F10
        public void PrepareNextCertB1(){} // RVA: 0x7B1537200
        public void PrepareNextCertB2(){} // RVA: 0x7B1537A60
        public void GetCertStatus(){} // RVA: 0x7B1537F00
        public void GetNextWorkingKey(){} // RVA: 0x7B15385E0
        public void GetValidCertDateFromValidityModel(){} // RVA: 0x7B15389B0
        public void FindCertificates(){} // RVA: 0x7B153A660
        public void GetCrlIssuersFromDistributionPoint(){} // RVA: 0x7B1539170
        public void GetCompleteCrls(){} // RVA: 0x7B15395B0
        public void GetDeltaCrls(){} // RVA: 0x7B1539C60
        public void isDeltaCrl(){} // RVA: 0x7B153A5B0
        public void AddAdditionalStoresFromCrlDistributionPoint(){} // RVA: 0x7B153AA40
        public void ProcessCertD1i(){} // RVA: 0x7B153AC30
        public void ProcessCertD1ii(){} // RVA: 0x7B153AEF0
        public void FindIssuerCerts(){} // RVA: 0x7B153B1F0
        public void GetExtensionValue(){} // RVA: 0x7B153B480
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7B153B510
    }

    public class PkixCrlUtilities : Object
    {
        // ── Methods ──
        public void FindCrls(){} // RVA: 0x7B153C050
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class PkixNameConstraintValidator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B153C350
        public void WithinDNSubtree(){} // RVA: 0x7B153C5D0
        public void CheckPermittedDN(){} // RVA: 0x7B153C980
        public void CheckExcludedDN(){} // RVA: 0x7B153CB60
        public void IntersectDN(){} // RVA: 0x7B153CD20
        public void UnionDN(){} // RVA: 0x7B153D020
        public void IntersectEmail(){} // RVA: 0x7B153D350
        public void UnionEmail(){} // RVA: 0x7B153FC30
        public void IntersectIP(){} // RVA: 0x7B153D840
        public void UnionIP(){} // RVA: 0x7B153DAD0
        public void UnionIPRange(){} // RVA: 0x7B153DDE0
        public void IntersectIPRange(){} // RVA: 0x7B153DF50
        public void IpWithSubnetMask(){} // RVA: 0x7B153E4E0
        public void ExtractIPsAndSubnetMasks(){} // RVA: 0x7B153E590
        public void MinMaxIPs(){} // RVA: 0x7B153E730
        public void CheckPermittedEmail(){} // RVA: 0x7B153EA10
        public void CheckExcludedEmail(){} // RVA: 0x7B153EBA0
        public void CheckPermittedIP(){} // RVA: 0x7B153ED10
        public void CheckExcludedIP(){} // RVA: 0x7B153EEB0
        public void IsIPConstrained(){} // RVA: 0x7B153F050
        public void EmailIsConstrained(){} // RVA: 0x7B153F2B0
        public void WithinDomain(){} // RVA: 0x7B153F4A0
        public void CheckPermittedDns(){} // RVA: 0x7B153F750
        public void CheckExcludedDns(){} // RVA: 0x7B153F9F0
        public void unionURI(){} // RVA: 0x7B1541070
        public void intersectDNS(){} // RVA: 0x7B1540370
        public void unionDNS(){} // RVA: 0x7B1540640
        public void intersectEmail(){} // RVA: 0x7B1540920
        public void checkExcludedURI(){} // RVA: 0x7B1540C90
        public void intersectURI(){} // RVA: 0x7B15412F0
        public void CheckPermittedURI(){} // RVA: 0x7B1541660
        public void IsUriConstrained(){} // RVA: 0x7B15417F0
        public void ExtractHostFromURL(){} // RVA: 0x7B1541910
        public void checkPermitted(){} // RVA: 0x7B1541AE0
        public void checkExcluded(){} // RVA: 0x7B15420C0
        public void IntersectPermittedSubtree(){} // RVA: 0x7B1542670
        public void ExtractNameAsString(){} // RVA: 0x7B1542E60
        public void IntersectEmptyPermittedSubtree(){} // RVA: 0x7B1542EA0
        public void AddExcludedSubtree(){} // RVA: 0x7B1543010
        public void Max(){} // RVA: 0x7B1543280
        public void Min(){} // RVA: 0x7B15432F0
        public void CompareTo(){} // RVA: 0x7B1543360
        public void Or(){} // RVA: 0x7B15435B0
        public void HashCode(){} // RVA: 0x7B1543660
        public void GetHashCode(){} // RVA: 0x7B1543680
        public void HashCollection(){} // RVA: 0x7B1543780
        public void Equals(){} // RVA: 0x7B1543A20
        public void CollectionsAreEqual(){} // RVA: 0x7B1543BD0
        public void SpecialEquals(){} // RVA: 0x7B1543D60
        public void StringifyIP(){} // RVA: 0x7B1543EC0
        public void StringifyIPCollection(){} // RVA: 0x7B1544140
        public void ToString(){} // RVA: 0x7B15443E0
        public void .cctor(){} // RVA: 0x7B1544890
    }

    public class PkixNameConstraintValidatorException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B16D0330
    }

    public class PkixParameters : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B16D0390
        public void get_IsRevocationEnabled(){} // RVA: 0x7A84A5BD0
        public void set_IsRevocationEnabled(){} // RVA: 0x7A84A5CD0
        public void get_IsExplicitPolicyRequired(){} // RVA: 0x7A82A20A0
        public void set_IsExplicitPolicyRequired(){} // RVA: 0x7A82A2C90
        public void get_IsAnyPolicyInhibited(){} // RVA: 0x7A82A3DE0
        public void set_IsAnyPolicyInhibited(){} // RVA: 0x7A82A20B0
        public void get_IsPolicyMappingInhibited(){} // RVA: 0x7A9286CF0
        public void set_IsPolicyMappingInhibited(){} // RVA: 0x7ADAE26D0
        public void get_IsPolicyQualifiersRejected(){} // RVA: 0x7A9281370
        public void set_IsPolicyQualifiersRejected(){} // RVA: 0x7AE46BB30
        public void get_Date(){} // RVA: 0x7A80DA7B0
        public void set_Date(){} // RVA: 0x7A813E420
        public void GetTrustAnchors(){} // RVA: 0x7B16D0800
        public void SetTrustAnchors(){} // RVA: 0x7B16D0860
        public void GetTargetCertConstraints(){} // RVA: 0x7B16D0BE0
        public void SetTargetCertConstraints(){} // RVA: 0x7B16D0C80
        public void GetInitialPolicies(){} // RVA: 0x7B16D0E10
        public void SetInitialPolicies(){} // RVA: 0x7B16D0E90
        public void SetCertPathCheckers(){} // RVA: 0x7B16D1140
        public void GetCertPathCheckers(){} // RVA: 0x7B16D14D0
        public void AddCertPathChecker(){} // RVA: 0x7B16D1810
        public void Clone(){} // RVA: 0x7B16D1890
        public void SetParams(){} // RVA: 0x7B16D1940
        public void get_IsUseDeltasEnabled(){} // RVA: 0x7A813FAC0
        public void set_IsUseDeltasEnabled(){} // RVA: 0x7A813FAD0
        public void get_ValidityModel(){} // RVA: 0x7A897F560
        public void set_ValidityModel(){} // RVA: 0x7A8980300
        public void SetStores(){} // RVA: 0x7B16D1FE0
        public void AddStore(){} // RVA: 0x7B16D2350
        public void AddAdditionalStore(){} // RVA: 0x7B16D23C0
        public void GetAdditionalStores(){} // RVA: 0x7B16D2430
        public void GetStores(){} // RVA: 0x7B16D24D0
        public void get_IsAdditionalLocationsEnabled(){} // RVA: 0x7A8359360
        public void SetAdditionalLocationsEnabled(){} // RVA: 0x7A8A21900
        public void GetTargetConstraints(){} // RVA: 0x7B16D2570
        public void SetTargetConstraints(){} // RVA: 0x7B16D2610
        public void GetTrustedACIssuers(){} // RVA: 0x7B16D2790
        public void SetTrustedACIssuers(){} // RVA: 0x7B16D27F0
        public void GetNecessaryACAttributes(){} // RVA: 0x7B16D2B60
        public void SetNecessaryACAttributes(){} // RVA: 0x7B16D2BC0
        public void GetProhibitedACAttributes(){} // RVA: 0x7B16D2EB0
        public void SetProhibitedACAttributes(){} // RVA: 0x7B16D2F10
        public void GetAttrCertCheckers(){} // RVA: 0x7B16D3200
        public void SetAttrCertCheckers(){} // RVA: 0x7B16D3260
    }

    public class PkixPolicyNode : Object
    {
        // ── Methods ──
        public void get_Depth(){} // RVA: 0x7A83782A0
        public void get_Children(){} // RVA: 0x7B16D35E0
        public void get_IsCritical(){} // RVA: 0x7A8193790
        public void set_IsCritical(){} // RVA: 0x7A81937A0
        public void get_PolicyQualifiers(){} // RVA: 0x7B16D36D0
        public void get_ValidPolicy(){} // RVA: 0x7A8292C30
        public void get_HasChildren(){} // RVA: 0x7B16D3730
        public void get_ExpectedPolicies(){} // RVA: 0x7B16D3790
        public void set_ExpectedPolicies(){} // RVA: 0x7B16D37F0
        public void get_Parent(){} // RVA: 0x7A8105330
        public void set_Parent(){} // RVA: 0x7A80D8E80
        public void .ctor(){} // RVA: 0x7B16D38B0
        public void AddChild(){} // RVA: 0x7B16D3BC0
        public void RemoveChild(){} // RVA: 0x7B16D3C40
        public void ToString(){} // RVA: 0x7B16D3CF0
        public void Clone(){} // RVA: 0x7AB65E3A0
        public void Copy(){} // RVA: 0x7B16D40E0
    }

    public class ReasonsMask : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A881ACE0
        public void AddReasons(){} // RVA: 0x7B16D4490
        public void get_IsAllReasons(){} // RVA: 0x7B16D44F0
        public void Intersect(){} // RVA: 0x7B16D4560
        public void HasNewReasons(){} // RVA: 0x7B16D4640
        public void get_Reasons(){} // RVA: 0x7B16D46A0
        public void .cctor(){} // RVA: 0x7B16D4740
    }

    public class Rfc3280CertPathUtilities : Object
    {
        // ── Methods ──
        public void ProcessCrlB2(){} // RVA: 0x7B16D47F0
        public void ProcessCertBC(){} // RVA: 0x7B16D5630
        public void PrepareNextCertA(){} // RVA: 0x7B16D5EC0
        public void ProcessCertD(){} // RVA: 0x7B16D6400
        public void ProcessCrlB1(){} // RVA: 0x7B16D77D0
        public void ProcessCrlD(){} // RVA: 0x7B16D7C00
        public void ProcessCrlF(){} // RVA: 0x7B16D7F40
        public void ProcessCrlG(){} // RVA: 0x7B16D89E0
        public void ProcessCrlH(){} // RVA: 0x7B16D8C80
        public void CheckCrl(){} // RVA: 0x7B16D8F30
        public void CheckCrls(){} // RVA: 0x7B16D99C0
        public void PrepareCertB(){} // RVA: 0x7B16DA480
        public void ProcessCrlA1ii(){} // RVA: 0x7B16DBA90
        public void ProcessCrlA1i(){} // RVA: 0x7B16DBEF0
        public void ProcessCertF(){} // RVA: 0x7B16DC330
        public void ProcessCertA(){} // RVA: 0x7B16DC3C0
        public void PrepareNextCertI1(){} // RVA: 0x7B16DCA30
        public void PrepareNextCertI2(){} // RVA: 0x7B16DCDB0
        public void PrepareNextCertG(){} // RVA: 0x7B16DD130
        public void PrepareNextCertJ(){} // RVA: 0x7B16DD5C0
        public void PrepareNextCertK(){} // RVA: 0x7B16DD860
        public void PrepareNextCertL(){} // RVA: 0x7B16DDB40
        public void PrepareNextCertM(){} // RVA: 0x7B16DDD10
        public void PrepareNextCertN(){} // RVA: 0x7B16DDFB0
        public void PrepareNextCertO(){} // RVA: 0x7B16DE150
        public void PrepareNextCertH1(){} // RVA: 0x7B16DE450
        public void PrepareNextCertH2(){} // RVA: 0x7B16DE5C0
        public void PrepareNextCertH3(){} // RVA: 0x7B16DE730
        public void WrapupCertA(){} // RVA: 0x7B16DE8A0
        public void WrapupCertB(){} // RVA: 0x7B16DE960
        public void WrapupCertF(){} // RVA: 0x7B16DED20
        public void WrapupCertG(){} // RVA: 0x7B16DF000
        public void ProcessCrlC(){} // RVA: 0x7B16DFEE0
        public void ProcessCrlI(){} // RVA: 0x7B16E04C0
        public void ProcessCrlJ(){} // RVA: 0x7B16E0580
        public void ProcessCertE(){} // RVA: 0x7B16E0620
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7B16E0860
    }

    public class Rfc3281CertPathUtilities : Object
    {
        // ── Methods ──
        public void ProcessAttrCert7(){} // RVA: 0x7B16E0C10
        public void CheckCrls(){} // RVA: 0x7B16E1150
        public void AdditionalChecks(){} // RVA: 0x7B16E1D90
        public void ProcessAttrCert5(){} // RVA: 0x7B16E21C0
        public void ProcessAttrCert4(){} // RVA: 0x7B16E2370
        public void ProcessAttrCert3(){} // RVA: 0x7B16E2730
        public void ProcessAttrCert2(){} // RVA: 0x7B16E2880
        public void ProcessAttrCert1(){} // RVA: 0x7B16E2960
        public void CheckCrl(){} // RVA: 0x7B16E3250
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class TrustAnchor : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B16E3E30
        public void get_TrustedCert(){} // RVA: 0x7A8105330
        public void get_CA(){} // RVA: 0x7A81052C0
        public void get_CAName(){} // RVA: 0x7A80DA7B0
        public void get_CAPublicKey(){} // RVA: 0x7A80F2570
        public void setNameConstraints(){} // RVA: 0x7B16E3FF0
        public void get_GetNameConstraints(){} // RVA: 0x7B16E4220
        public void ToString(){} // RVA: 0x7B16E42D0
    }

}