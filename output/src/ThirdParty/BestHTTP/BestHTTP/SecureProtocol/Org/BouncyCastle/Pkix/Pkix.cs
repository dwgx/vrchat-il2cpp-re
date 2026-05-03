// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Pkix
// Classes: 23
// Methods: 290

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Pkix
{
    public class CertStatus : Object
    {
        public int Unrevoked;
        public int Undetermined;

        // ── Methods ──
        public void get_RevocationDate(){} // RVA: 0x7FFE810FE7C0
        public void set_RevocationDate(){} // RVA: 0x7FFE81161E80
        public void get_Status(){} // RVA: 0x7FFE811485C0
        public void set_Status(){} // RVA: 0x7FFE810FE0C0
        public void .ctor(){} // RVA: 0x7FFE8A156CF0
    }

    public class PkixAttrCertChecker : Object
    {
        // ── Methods ──
        public void GetSupportedExtensions(){} // RVA: 0x7FFE80E2E2E0
        public void Check(){} // RVA: 0x7FFE80E50FC0
        public void Clone(){} // RVA: 0x7FFE80E2E2E0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class PkixAttrCertPathBuilder : Object
    {
        // ── Methods ──
        public void Build(){} // RVA: 0x7FFE8A1576E0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class PkixAttrCertPathValidator : Object
    {
        // ── Methods ──
        public void Validate(){} // RVA: 0x7FFE8A157EA0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class PkixBuilderParameters : PkixParameters
    {
        public int maxPathLength; // 0x90

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A158360
        public void .ctor(){} // RVA: 0x7FFE8A158470
        public void get_MaxPathLength(){} // RVA: 0x7FFE814AA220
        public void set_MaxPathLength(){} // RVA: 0x7FFE8A158560
        public void GetExcludedCerts(){} // RVA: 0x7FFE8A1585D0
        public void SetExcludedCerts(){} // RVA: 0x7FFE8A158630
        public void SetParams(){} // RVA: 0x7FFE8A158770
        public void Clone(){} // RVA: 0x7FFE8A1588D0
        public void ToString(){} // RVA: 0x7FFE8A1589A0
    }

    public class PkixCertPath : Object
    {
        public System.Collections.IList certPathEncodings;
        public System.Collections.IList certificates; // 0x10

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE8A158B50
        public void SortCerts(){} // RVA: 0x7FFE8A158CF0
        public void .ctor(){} // RVA: 0x7FFE8A159590 | overloaded x3
        public void get_Encodings(){} // RVA: 0x7FFE8A159DC0
        public void Equals(){} // RVA: 0x7FFE8A159EE0
        public void GetHashCode(){} // RVA: 0x7FFE8778E7A0
        public void GetEncoded(){} // RVA: 0x7FFE8A15A300 | overloaded x2
        public void get_Certificates(){} // RVA: 0x7FFE8A15AE70
        public void ToAsn1Object(){} // RVA: 0x7FFE8A15AE80
        public void ToDerEncoded(){} // RVA: 0x7FFE8A15AF30
    }

    public class PkixCertPathBuilder : Object
    {
        // ── Methods ──
        public void Build(){} // RVA: 0x7FFE8A15B6F0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class PkixCertPathBuilderException : GeneralSecurityException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A15BF00 | overloaded x3
    }

    public class PkixCertPathBuilderResult : PkixCertPathValidatorResult
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Pkix.PkixCertPath certPath; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A15BF10
        public void get_CertPath(){} // RVA: 0x7FFE81129130
        public void ToString(){} // RVA: 0x7FFE8A15BFF0
    }

    public class PkixCertPathChecker : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Init(){} // RVA: 0x7FFE80E466C0
        public void IsForwardCheckingSupported(){} // RVA: 0x7FFE80E2F150
        public void GetSupportedExtensions(){} // RVA: 0x7FFE80E2E2E0
        public void Check(){} // RVA: 0x7FFE80E4F230
        public void Clone(){} // RVA: 0x7FFE868BC310
    }

    public class PkixCertPathValidator : Object
    {
        // ── Methods ──
        public void Validate(){} // RVA: 0x7FFE8A15C2D0
        public void CheckCertificate(){} // RVA: 0x7FFE8A15DAD0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class PkixCertPathValidatorException : GeneralSecurityException
    {
        public System.Exception cause; // 0x90
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Pkix.PkixCertPath certPath; // 0x98
        public int index; // 0xA0

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A15DD20 | overloaded x4
        public void get_Message(){} // RVA: 0x7FFE8A15DF70
        public void get_CertPath(){} // RVA: 0x7FFE817AE360
        public void get_Index(){} // RVA: 0x7FFE82B06FB0
    }

    public class PkixCertPathValidatorResult : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Pkix.TrustAnchor trustAnchor; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Pkix.PkixPolicyNode policyTree; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.AsymmetricKeyParameter subjectPublicKey; // 0x20

        // ── Methods ──
        public void get_PolicyTree(){} // RVA: 0x7FFE810FE7C0
        public void get_TrustAnchor(){} // RVA: 0x7FFE81116380
        public void get_SubjectPublicKey(){} // RVA: 0x7FFE811290C0
        public void .ctor(){} // RVA: 0x7FFE8A15DFC0
        public void Clone(){} // RVA: 0x7FFE8A15E180
        public void ToString(){} // RVA: 0x7FFE8A15E210
    }

    public class PkixCertPathValidatorUtilities : Object
    {
        // ── Methods ──
        public void FindTrustAnchor(){} // RVA: 0x7FFE8A15E4C0
        public void IsIssuerTrustAnchor(){} // RVA: 0x7FFE8A15E920
        public void AddAdditionalStoresFromAltNames(){} // RVA: 0x7FFE8A15E990
        public void GetValidDate(){} // RVA: 0x7FFE8A15ED20
        public void GetIssuerPrincipal(){} // RVA: 0x7FFE8A15EDA0
        public void IsSelfIssued(){} // RVA: 0x7FFE8A15EEF0
        public void GetAlgorithmIdentifier(){} // RVA: 0x7FFE8A15EF60
        public void IsAnyPolicy(){} // RVA: 0x7FFE8A15EFF0
        public void AddAdditionalStoreFromLocation(){} // RVA: 0x7FFE8A15F0B0
        public void GetSerialNumber(){} // RVA: 0x7FFE8A15F280
        public void GetQualifierSet(){} // RVA: 0x7FFE8A15F390
        public void RemovePolicyNode(){} // RVA: 0x7FFE8A15F650
        public void RemovePolicyNodeRecurse(){} // RVA: 0x7FFE8A15F820
        public void PrepareNextCertB1(){} // RVA: 0x7FFE8A15FB20
        public void PrepareNextCertB2(){} // RVA: 0x7FFE8A160380
        public void GetCertStatus(){} // RVA: 0x7FFE8A160840
        public void GetNextWorkingKey(){} // RVA: 0x7FFE8A160F10
        public void GetValidCertDateFromValidityModel(){} // RVA: 0x7FFE8A1612E0
        public void FindCertificates(){} // RVA: 0x7FFE8A162FB0 | overloaded x2
        public void GetCrlIssuersFromDistributionPoint(){} // RVA: 0x7FFE8A161AB0
        public void GetCompleteCrls(){} // RVA: 0x7FFE8A161EF0
        public void GetDeltaCrls(){} // RVA: 0x7FFE8A162590
        public void isDeltaCrl(){} // RVA: 0x7FFE8A162F00
        public void AddAdditionalStoresFromCrlDistributionPoint(){} // RVA: 0x7FFE8A1633A0
        public void ProcessCertD1i(){} // RVA: 0x7FFE8A163580
        public void ProcessCertD1ii(){} // RVA: 0x7FFE8A163840
        public void FindIssuerCerts(){} // RVA: 0x7FFE8A163B40
        public void GetExtensionValue(){} // RVA: 0x7FFE8A163DD0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE8A163E60
    }

    public class PkixCrlUtilities : Object
    {
        // ── Methods ──
        public void FindCrls(){} // RVA: 0x7FFE8A1649A0 | overloaded x3
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class PkixNameConstraintValidator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A164CA0
        public void WithinDNSubtree(){} // RVA: 0x7FFE8A164F20
        public void CheckPermittedDN(){} // RVA: 0x7FFE8A1652D0 | overloaded x2
        public void CheckExcludedDN(){} // RVA: 0x7FFE8A1654B0 | overloaded x2
        public void IntersectDN(){} // RVA: 0x7FFE8A165670
        public void UnionDN(){} // RVA: 0x7FFE8A165970
        public void IntersectEmail(){} // RVA: 0x7FFE8A165CA0
        public void UnionEmail(){} // RVA: 0x7FFE8A168470 | overloaded x2
        public void IntersectIP(){} // RVA: 0x7FFE8A166190
        public void UnionIP(){} // RVA: 0x7FFE8A166420
        public void UnionIPRange(){} // RVA: 0x7FFE8A166730
        public void IntersectIPRange(){} // RVA: 0x7FFE8A1668A0
        public void IpWithSubnetMask(){} // RVA: 0x7FFE8A166E10
        public void ExtractIPsAndSubnetMasks(){} // RVA: 0x7FFE8A166EC0
        public void MinMaxIPs(){} // RVA: 0x7FFE8A167060
        public void CheckPermittedEmail(){} // RVA: 0x7FFE8A1672C0
        public void CheckExcludedEmail(){} // RVA: 0x7FFE8A167450
        public void CheckPermittedIP(){} // RVA: 0x7FFE8A1675C0
        public void CheckExcludedIP(){} // RVA: 0x7FFE8A167760
        public void IsIPConstrained(){} // RVA: 0x7FFE8A167900
        public void EmailIsConstrained(){} // RVA: 0x7FFE8A167B20
        public void WithinDomain(){} // RVA: 0x7FFE8A167D10
        public void CheckPermittedDns(){} // RVA: 0x7FFE8A167F70
        public void CheckExcludedDns(){} // RVA: 0x7FFE8A168220
        public void unionURI(){} // RVA: 0x7FFE8A1698B0 | overloaded x2
        public void intersectDNS(){} // RVA: 0x7FFE8A168BB0
        public void unionDNS(){} // RVA: 0x7FFE8A168E80
        public void intersectEmail(){} // RVA: 0x7FFE8A169160
        public void checkExcludedURI(){} // RVA: 0x7FFE8A1694D0
        public void intersectURI(){} // RVA: 0x7FFE8A169B30 | overloaded x2
        public void CheckPermittedURI(){} // RVA: 0x7FFE8A169EA0
        public void IsUriConstrained(){} // RVA: 0x7FFE8A16A030
        public void ExtractHostFromURL(){} // RVA: 0x7FFE8A16A150
        public void checkPermitted(){} // RVA: 0x7FFE8A16A320
        public void checkExcluded(){} // RVA: 0x7FFE8A16A900
        public void IntersectPermittedSubtree(){} // RVA: 0x7FFE8A16AEB0
        public void ExtractNameAsString(){} // RVA: 0x7FFE8A16B6A0
        public void IntersectEmptyPermittedSubtree(){} // RVA: 0x7FFE8A16B6E0
        public void AddExcludedSubtree(){} // RVA: 0x7FFE8A16B840
        public void Max(){} // RVA: 0x7FFE8A16BAB0
        public void Min(){} // RVA: 0x7FFE8A16BB20
        public void CompareTo(){} // RVA: 0x7FFE8A16BB90
        public void Or(){} // RVA: 0x7FFE8A16BDD0
        public void HashCode(){} // RVA: 0x7FFE8A16BE70
        public void GetHashCode(){} // RVA: 0x7FFE8A16BE90
        public void HashCollection(){} // RVA: 0x7FFE8A16BF90
        public void Equals(){} // RVA: 0x7FFE8A16C240
        public void CollectionsAreEqual(){} // RVA: 0x7FFE8A16C3F0
        public void SpecialEquals(){} // RVA: 0x7FFE8A16C580
        public void StringifyIP(){} // RVA: 0x7FFE8A16C6E0
        public void StringifyIPCollection(){} // RVA: 0x7FFE8A16C940
        public void ToString(){} // RVA: 0x7FFE8A16CBE0
        public void .cctor(){} // RVA: 0x7FFE8A16D090
    }

    public class PkixNameConstraintValidatorException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A2F7110
    }

    public class PkixParameters : Object
    {
        public int PkixValidityModel;
        public int ChainValidityModel;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Collections.ISet trustAnchors; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Date.DateTimeObject date; // 0x18
        public System.Collections.IList certPathCheckers; // 0x20
        public bool revocationEnabled; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Collections.ISet initialPolicies; // 0x30
        public bool explicitPolicyRequired; // 0x38
        public bool anyPolicyInhibited; // 0x39

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A2F7170
        public void get_IsRevocationEnabled(){} // RVA: 0x7FFE815F1380
        public void set_IsRevocationEnabled(){} // RVA: 0x7FFE81C15740
        public void get_IsExplicitPolicyRequired(){} // RVA: 0x7FFE812CF770
        public void set_IsExplicitPolicyRequired(){} // RVA: 0x7FFE812D0010
        public void get_IsAnyPolicyInhibited(){} // RVA: 0x7FFE812CF7D0
        public void set_IsAnyPolicyInhibited(){} // RVA: 0x7FFE812D0020
        public void get_IsPolicyMappingInhibited(){} // RVA: 0x7FFE82230840
        public void set_IsPolicyMappingInhibited(){} // RVA: 0x7FFE86835A50
        public void get_IsPolicyQualifiersRejected(){} // RVA: 0x7FFE8222F780
        public void set_IsPolicyQualifiersRejected(){} // RVA: 0x7FFE871BC270
        public void get_Date(){} // RVA: 0x7FFE810FE7C0
        public void set_Date(){} // RVA: 0x7FFE81161E80
        public void GetTrustAnchors(){} // RVA: 0x7FFE8A2F75E0
        public void SetTrustAnchors(){} // RVA: 0x7FFE8A2F7640
        public void GetTargetCertConstraints(){} // RVA: 0x7FFE8A2F79E0
        public void SetTargetCertConstraints(){} // RVA: 0x7FFE8A2F7A80
        public void GetInitialPolicies(){} // RVA: 0x7FFE8A2F7C10
        public void SetInitialPolicies(){} // RVA: 0x7FFE8A2F7C90
        public void SetCertPathCheckers(){} // RVA: 0x7FFE8A2F7F50
        public void GetCertPathCheckers(){} // RVA: 0x7FFE8A2F8300
        public void AddCertPathChecker(){} // RVA: 0x7FFE8A2F8650
        public void Clone(){} // RVA: 0x7FFE8A2F86D0
        public void SetParams(){} // RVA: 0x7FFE8A2F8780
        public void get_IsUseDeltasEnabled(){} // RVA: 0x7FFE81163520
        public void set_IsUseDeltasEnabled(){} // RVA: 0x7FFE81163530
        public void get_ValidityModel(){} // RVA: 0x7FFE8194AD00
        public void set_ValidityModel(){} // RVA: 0x7FFE8194A400
        public void SetStores(){} // RVA: 0x7FFE8A2F8E20
        public void AddStore(){} // RVA: 0x7FFE8A2F91A0
        public void AddAdditionalStore(){} // RVA: 0x7FFE8A2F9210
        public void GetAdditionalStores(){} // RVA: 0x7FFE8A2F9280
        public void GetStores(){} // RVA: 0x7FFE8A2F9320
        public void get_IsAdditionalLocationsEnabled(){} // RVA: 0x7FFE813A1140
        public void SetAdditionalLocationsEnabled(){} // RVA: 0x7FFE819E83C0
        public void GetTargetConstraints(){} // RVA: 0x7FFE8A2F93C0
        public void SetTargetConstraints(){} // RVA: 0x7FFE8A2F9460
        public void GetTrustedACIssuers(){} // RVA: 0x7FFE8A2F95E0
        public void SetTrustedACIssuers(){} // RVA: 0x7FFE8A2F9640
        public void GetNecessaryACAttributes(){} // RVA: 0x7FFE8A2F99D0
        public void SetNecessaryACAttributes(){} // RVA: 0x7FFE8A2F9A30
        public void GetProhibitedACAttributes(){} // RVA: 0x7FFE8A2F9D30
        public void SetProhibitedACAttributes(){} // RVA: 0x7FFE8A2F9D90
        public void GetAttrCertCheckers(){} // RVA: 0x7FFE8A2FA090
        public void SetAttrCertCheckers(){} // RVA: 0x7FFE8A2FA0F0
    }

    public class PkixPolicyNode : Object
    {
        public System.Collections.IList mChildren; // 0x10
        public int mDepth; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Collections.ISet mExpectedPolicies; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Pkix.PkixPolicyNode mParent; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Collections.ISet mPolicyQualifiers; // 0x30
        public string mValidPolicy; // 0x38
        public bool mCritical; // 0x40
        public object field_7; // 0x17F

        // ── Methods ──
        public void get_Depth(){} // RVA: 0x7FFE813DB630
        public void get_Children(){} // RVA: 0x7FFE8A2FA480
        public void get_IsCritical(){} // RVA: 0x7FFE811B6C00
        public void set_IsCritical(){} // RVA: 0x7FFE811B6C10
        public void get_PolicyQualifiers(){} // RVA: 0x7FFE8A2FA570
        public void get_ValidPolicy(){} // RVA: 0x7FFE8143BA80
        public void get_HasChildren(){} // RVA: 0x7FFE8A2FA5D0
        public void get_ExpectedPolicies(){} // RVA: 0x7FFE8A2FA630
        public void set_ExpectedPolicies(){} // RVA: 0x7FFE8A2FA690
        public void get_Parent(){} // RVA: 0x7FFE81129130
        public void set_Parent(){} // RVA: 0x7FFE810FCE90
        public void .ctor(){} // RVA: 0x7FFE8A2FA750
        public void AddChild(){} // RVA: 0x7FFE8A2FAA60
        public void RemoveChild(){} // RVA: 0x7FFE8A2FAAE0
        public void ToString(){} // RVA: 0x7FFE8A2FAB90 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE844E23A0
        public void Copy(){} // RVA: 0x7FFE8A2FAF70
    }

    public class ReasonsMask : Object
    {
        public int _reasons; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Pkix.ReasonsMask AllReasons;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE817EE4A0 | overloaded x2
        public void AddReasons(){} // RVA: 0x7FFE8A2FB340
        public void get_IsAllReasons(){} // RVA: 0x7FFE8A2FB3A0
        public void Intersect(){} // RVA: 0x7FFE8A2FB410
        public void HasNewReasons(){} // RVA: 0x7FFE8A2FB4F0
        public void get_Reasons(){} // RVA: 0x7FFE8A2FB550
        public void .cctor(){} // RVA: 0x7FFE8A2FB5F0
    }

    public class Rfc3280CertPathUtilities : Object
    {
        // ── Methods ──
        public void ProcessCrlB2(){} // RVA: 0x7FFE8A2FB6A0
        public void ProcessCertBC(){} // RVA: 0x7FFE8A2FC4B0
        public void PrepareNextCertA(){} // RVA: 0x7FFE8A2FCD50
        public void ProcessCertD(){} // RVA: 0x7FFE8A2FD290
        public void ProcessCrlB1(){} // RVA: 0x7FFE8A2FE650
        public void ProcessCrlD(){} // RVA: 0x7FFE8A2FEA80
        public void ProcessCrlF(){} // RVA: 0x7FFE8A2FEDC0
        public void ProcessCrlG(){} // RVA: 0x7FFE8A2FF850
        public void ProcessCrlH(){} // RVA: 0x7FFE8A2FFAE0
        public void CheckCrl(){} // RVA: 0x7FFE8A2FFDA0
        public void CheckCrls(){} // RVA: 0x7FFE8A300810
        public void PrepareCertB(){} // RVA: 0x7FFE8A3012F0
        public void ProcessCrlA1ii(){} // RVA: 0x7FFE8A3029A0
        public void ProcessCrlA1i(){} // RVA: 0x7FFE8A302E00
        public void ProcessCertF(){} // RVA: 0x7FFE8A303240
        public void ProcessCertA(){} // RVA: 0x7FFE8A3032D0
        public void PrepareNextCertI1(){} // RVA: 0x7FFE8A303940
        public void PrepareNextCertI2(){} // RVA: 0x7FFE8A303CC0
        public void PrepareNextCertG(){} // RVA: 0x7FFE8A304040
        public void PrepareNextCertJ(){} // RVA: 0x7FFE8A3044D0
        public void PrepareNextCertK(){} // RVA: 0x7FFE8A304760
        public void PrepareNextCertL(){} // RVA: 0x7FFE8A304A30
        public void PrepareNextCertM(){} // RVA: 0x7FFE8A304C00
        public void PrepareNextCertN(){} // RVA: 0x7FFE8A304E90
        public void PrepareNextCertO(){} // RVA: 0x7FFE8A305030
        public void PrepareNextCertH1(){} // RVA: 0x7FFE8A305330
        public void PrepareNextCertH2(){} // RVA: 0x7FFE8A3054A0
        public void PrepareNextCertH3(){} // RVA: 0x7FFE8A305610
        public void WrapupCertA(){} // RVA: 0x7FFE8A305780
        public void WrapupCertB(){} // RVA: 0x7FFE8A305840
        public void WrapupCertF(){} // RVA: 0x7FFE8A305C00
        public void WrapupCertG(){} // RVA: 0x7FFE8A305EE0
        public void ProcessCrlC(){} // RVA: 0x7FFE8A306D80
        public void ProcessCrlI(){} // RVA: 0x7FFE8A307360
        public void ProcessCrlJ(){} // RVA: 0x7FFE8A307420
        public void ProcessCertE(){} // RVA: 0x7FFE8A3074C0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE8A307700
    }

    public class Rfc3281CertPathUtilities : Object
    {
        // ── Methods ──
        public void ProcessAttrCert7(){} // RVA: 0x7FFE8A307AB0
        public void CheckCrls(){} // RVA: 0x7FFE8A308000
        public void AdditionalChecks(){} // RVA: 0x7FFE8A308C30
        public void ProcessAttrCert5(){} // RVA: 0x7FFE8A309080
        public void ProcessAttrCert4(){} // RVA: 0x7FFE8A309230
        public void ProcessAttrCert3(){} // RVA: 0x7FFE8A309600
        public void ProcessAttrCert2(){} // RVA: 0x7FFE8A309750
        public void ProcessAttrCert1(){} // RVA: 0x7FFE8A309830
        public void CheckCrl(){} // RVA: 0x7FFE8A30A120
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class TrustAnchor : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.AsymmetricKeyParameter pubKey; // 0x10
        public string caName; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Name caPrincipal; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.X509.X509Certificate trustedCert; // 0x28
        public byte[] ncBytes; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A30ACC0 | overloaded x3
        public void get_TrustedCert(){} // RVA: 0x7FFE81129130
        public void get_CA(){} // RVA: 0x7FFE811290C0
        public void get_CAName(){} // RVA: 0x7FFE810FE7C0
        public void get_CAPublicKey(){} // RVA: 0x7FFE81116380
        public void setNameConstraints(){} // RVA: 0x7FFE8A30AE80
        public void get_GetNameConstraints(){} // RVA: 0x7FFE8A30B0B0
        public void ToString(){} // RVA: 0x7FFE8A30B160
    }

}