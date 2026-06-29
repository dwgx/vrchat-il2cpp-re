// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Pkix
// Classes: 23
// Methods: 268

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Pkix
{
    public class CertStatus : Object
    {
        public object Unrevoked;
        public object Undetermined;
        public object status;
        public object revocationDate;

        // ── Methods ──
        public void get_RevocationDate(){} // RVA: 0xB465B0
        public void set_RevocationDate(){} // RVA: 0xBA9BA0
        public void get_Status(){} // RVA: 0xB8F8F0
        public void set_Status(){} // RVA: 0xB460A0
        public void .ctor(){} // RVA: 0xA3996F0
    }

    public class PkixAttrCertChecker : Object
    {
        // ── Methods ──
        public void GetSupportedExtensions(){} // RVA: 0x87C0A0
        public void Check(){} // RVA: 0x899870
        public void Clone(){} // RVA: 0x87C0A0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class PkixAttrCertPathBuilder : Object
    {
        public object certPathException;

        // ── Methods ──
        public void Build(){} // RVA: 0xA39A0D0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class PkixAttrCertPathValidator : Object
    {
        // ── Methods ──
        public void Validate(){} // RVA: 0xA39A870
        public void .ctor(){} // RVA: 0xB43310
    }

    public class PkixBuilderParameters : PkixParameters
    {
        public object maxPathLength;
        public object excludedCerts;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA39AD30
        public void .ctor(){} // RVA: 0xA39AE40
        public void get_MaxPathLength(){} // RVA: 0xF3A950
        public void set_MaxPathLength(){} // RVA: 0xA39AF30
        public void GetExcludedCerts(){} // RVA: 0xA39AFA0
        public void SetExcludedCerts(){} // RVA: 0xA39B000
        public void SetParams(){} // RVA: 0xA39B140
        public void Clone(){} // RVA: 0xA39B2A0
        public void ToString(){} // RVA: 0xA39B370
    }

    public class PkixCertPath : Object
    {
        public object certPathEncodings;
        public object certificates;

        // ── Methods ──
        public void .cctor(){} // RVA: 0xA39B520
        public void SortCerts(){} // RVA: 0xA39B6C0
        public void .ctor(){} // RVA: 0xA39BF70
        public void get_Encodings(){} // RVA: 0xA39C790
        public void Equals(){} // RVA: 0xA39C8B0
        public void GetHashCode(){} // RVA: 0x76AE540
        public void GetEncoded(){} // RVA: 0xA39CCA0
        public void get_Certificates(){} // RVA: 0xA39D820
        public void ToAsn1Object(){} // RVA: 0xA39D830
        public void ToDerEncoded(){} // RVA: 0xA39D8E0
    }

    public class PkixCertPathBuilder : Object
    {
        public object certPathException;

        // ── Methods ──
        public void Build(){} // RVA: 0xA39E070
        public void .ctor(){} // RVA: 0xB43310
    }

    public class PkixCertPathBuilderException : GeneralSecurityException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA39E870
    }

    public class PkixCertPathBuilderResult : PkixCertPathValidatorResult
    {
        public object certPath;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA39E880
        public void get_CertPath(){} // RVA: 0xB70160
        public void ToString(){} // RVA: 0xA39E960
    }

    public class PkixCertPathChecker : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void Init(){} // RVA: 0x894750
        public void IsForwardCheckingSupported(){} // RVA: 0x87D280
        public void GetSupportedExtensions(){} // RVA: 0x87C0A0
        public void Check(){} // RVA: 0x8943B0
        public void Clone(){} // RVA: 0x67F43E0
    }

    public class PkixCertPathValidator : Object
    {
        // ── Methods ──
        public void Validate(){} // RVA: 0xA39EC40
        public void CheckCertificate(){} // RVA: 0xA3A0440
        public void .ctor(){} // RVA: 0xB43310
    }

    public class PkixCertPathValidatorException : GeneralSecurityException
    {
        public object cause;
        public object certPath;
        public object index;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA3A0690
        public void get_Message(){} // RVA: 0xA3A08E0
        public void get_CertPath(){} // RVA: 0x106A7D0
        public void get_Index(){} // RVA: 0x262A8F0
    }

    public class PkixCertPathValidatorResult : Object
    {
        public object trustAnchor;
        public object policyTree;
        public object subjectPublicKey;

        // ── Methods ──
        public void get_PolicyTree(){} // RVA: 0xB465B0
        public void get_TrustAnchor(){} // RVA: 0xB5DBF0
        public void get_SubjectPublicKey(){} // RVA: 0xB700F0
        public void .ctor(){} // RVA: 0xA3A0930
        public void Clone(){} // RVA: 0xA3A0AF0
        public void ToString(){} // RVA: 0xA3A0B80
    }

    public class PkixCertPathValidatorUtilities : Object
    {
        public object CrlUtilities;
        public object ANY_POLICY;
        public object CRL_NUMBER;
        public object KEY_CERT_SIGN;
        public object CRL_SIGN;
        public object crlReasons;

        // ── Methods ──
        public void FindTrustAnchor(){} // RVA: 0xA3A0E30
        public void IsIssuerTrustAnchor(){} // RVA: 0xA3A12C0
        public void AddAdditionalStoresFromAltNames(){} // RVA: 0xA3A1330
        public void GetValidDate(){} // RVA: 0xA3A16A0
        public void GetIssuerPrincipal(){} // RVA: 0xA3A1720
        public void IsSelfIssued(){} // RVA: 0xA3A1870
        public void GetAlgorithmIdentifier(){} // RVA: 0xA3A18E0
        public void IsAnyPolicy(){} // RVA: 0xA3A1970
        public void AddAdditionalStoreFromLocation(){} // RVA: 0xA3A1A30
        public void GetSerialNumber(){} // RVA: 0xA3A1C00
        public void GetQualifierSet(){} // RVA: 0xA3A1D10
        public void RemovePolicyNode(){} // RVA: 0xA3A1FB0
        public void RemovePolicyNodeRecurse(){} // RVA: 0xA3A21A0
        public void PrepareNextCertB1(){} // RVA: 0xA3A2490
        public void PrepareNextCertB2(){} // RVA: 0xA3A2CF0
        public void GetCertStatus(){} // RVA: 0xA3A3190
        public void GetNextWorkingKey(){} // RVA: 0xA3A3870
        public void GetValidCertDateFromValidityModel(){} // RVA: 0xA3A3C40
        public void FindCertificates(){} // RVA: 0xA3A58F0
        public void GetCrlIssuersFromDistributionPoint(){} // RVA: 0xA3A4400
        public void GetCompleteCrls(){} // RVA: 0xA3A4840
        public void GetDeltaCrls(){} // RVA: 0xA3A4EF0
        public void isDeltaCrl(){} // RVA: 0xA3A5840
        public void AddAdditionalStoresFromCrlDistributionPoint(){} // RVA: 0xA3A5CD0
        public void ProcessCertD1i(){} // RVA: 0xA3A5EC0
        public void ProcessCertD1ii(){} // RVA: 0xA3A6180
        public void FindIssuerCerts(){} // RVA: 0xA3A6480
        public void GetExtensionValue(){} // RVA: 0xA3A6710
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA3A67A0
    }

    public class PkixCrlUtilities : Object
    {
        // ── Methods ──
        public void FindCrls(){} // RVA: 0xA3A72E0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class PkixNameConstraintValidator : Object
    {
        public object SerialNumberOid;
        public object excludedSubtreesDN;
        public object excludedSubtreesDNS;
        public object excludedSubtreesEmail;
        public object excludedSubtreesURI;
        public object excludedSubtreesIP;
        public object permittedSubtreesDN;
        public object permittedSubtreesDNS;
        public object permittedSubtreesEmail;
        public object permittedSubtreesURI;
        public object permittedSubtreesIP;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA3A75E0
        public void WithinDNSubtree(){} // RVA: 0xA3A7860
        public void CheckPermittedDN(){} // RVA: 0xA3A7C10
        public void CheckExcludedDN(){} // RVA: 0xA3A7DF0
        public void IntersectDN(){} // RVA: 0xA3A7FB0
        public void UnionDN(){} // RVA: 0xA3A82B0
        public void IntersectEmail(){} // RVA: 0xA3A85E0
        public void UnionEmail(){} // RVA: 0xA3AAE50
        public void IntersectIP(){} // RVA: 0xA3A8AB0
        public void UnionIP(){} // RVA: 0xA3A8D40
        public void UnionIPRange(){} // RVA: 0xA3A9050
        public void IntersectIPRange(){} // RVA: 0xA3A91C0
        public void IpWithSubnetMask(){} // RVA: 0xA3A9750
        public void ExtractIPsAndSubnetMasks(){} // RVA: 0xA3A9800
        public void MinMaxIPs(){} // RVA: 0xA3A99A0
        public void CheckPermittedEmail(){} // RVA: 0xA3A9C80
        public void CheckExcludedEmail(){} // RVA: 0xA3A9E00
        public void CheckPermittedIP(){} // RVA: 0xA3A9F60
        public void CheckExcludedIP(){} // RVA: 0xA3AA100
        public void IsIPConstrained(){} // RVA: 0xA3AA2A0
        public void EmailIsConstrained(){} // RVA: 0xA3AA500
        public void WithinDomain(){} // RVA: 0xA3AA6E0
        public void CheckPermittedDns(){} // RVA: 0xA3AA990
        public void CheckExcludedDns(){} // RVA: 0xA3AAC20
        public void unionURI(){} // RVA: 0xA3AC250
        public void intersectDNS(){} // RVA: 0xA3AB590
        public void unionDNS(){} // RVA: 0xA3AB850
        public void intersectEmail(){} // RVA: 0xA3ABB20
        public void checkExcludedURI(){} // RVA: 0xA3ABE90
        public void intersectURI(){} // RVA: 0xA3AC4C0
        public void CheckPermittedURI(){} // RVA: 0xA3AC830
        public void IsUriConstrained(){} // RVA: 0xA3AC9B0
        public void ExtractHostFromURL(){} // RVA: 0xA3ACAD0
        public void checkPermitted(){} // RVA: 0xA3ACCA0
        public void checkExcluded(){} // RVA: 0xA3AD260
        public void IntersectPermittedSubtree(){} // RVA: 0xA3AD7F0
        public void ExtractNameAsString(){} // RVA: 0xA3ADFD0
        public void IntersectEmptyPermittedSubtree(){} // RVA: 0xA3AE010
        public void AddExcludedSubtree(){} // RVA: 0xA3AE180
        public void Max(){} // RVA: 0xA3AE3F0
        public void Min(){} // RVA: 0xA3AE460
        public void CompareTo(){} // RVA: 0xA3AE4D0
        public void Or(){} // RVA: 0xA3AE720
        public void HashCode(){} // RVA: 0xA3AE7D0
        public void GetHashCode(){} // RVA: 0xA3AE7F0
        public void HashCollection(){} // RVA: 0xA3AE8F0
        public void Equals(){} // RVA: 0xA3AEB90
        public void CollectionsAreEqual(){} // RVA: 0xA3AED40
        public void SpecialEquals(){} // RVA: 0xA3AEED0
        public void StringifyIP(){} // RVA: 0xA3AF030
        public void StringifyIPCollection(){} // RVA: 0xA3AF2B0
        public void ToString(){} // RVA: 0xA3AF550
        public void .cctor(){} // RVA: 0xA3AFA00
    }

    public class PkixNameConstraintValidatorException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA53BA70
    }

    public class PkixParameters : Object
    {
        public object PkixValidityModel;
        public object ChainValidityModel;
        public object trustAnchors;
        public object date;
        public object certPathCheckers;
        public object revocationEnabled;
        public object initialPolicies;
        public object explicitPolicyRequired;
        public object anyPolicyInhibited;
        public object policyMappingInhibited;
        public object policyQualifiersRejected;
        public object certSelector;
        public object stores;
        public object selector;
        public object additionalLocationsEnabled;
        public object additionalStores;
        public object trustedACIssuers;
        public object necessaryACAttributes;
        public object prohibitedACAttributes;
        public object attrCertCheckers;
        public object validityModel;
        public object useDeltas;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA53BAD0
        public void get_IsRevocationEnabled(){} // RVA: 0xF73960
        public void set_IsRevocationEnabled(){} // RVA: 0xF73A60
        public void get_IsExplicitPolicyRequired(){} // RVA: 0xD16660
        public void set_IsExplicitPolicyRequired(){} // RVA: 0xD14C10
        public void get_IsAnyPolicyInhibited(){} // RVA: 0xD15320
        public void set_IsAnyPolicyInhibited(){} // RVA: 0xD14740
        public void get_IsPolicyMappingInhibited(){} // RVA: 0x1DC2880
        public void set_IsPolicyMappingInhibited(){} // RVA: 0x676D5E0
        public void get_IsPolicyQualifiersRejected(){} // RVA: 0x1D92F50
        public void set_IsPolicyQualifiersRejected(){} // RVA: 0x70E7C30
        public void get_Date(){} // RVA: 0xB465B0
        public void set_Date(){} // RVA: 0xBA9BA0
        public void GetTrustAnchors(){} // RVA: 0xA53BF40
        public void SetTrustAnchors(){} // RVA: 0xA53BFA0
        public void GetTargetCertConstraints(){} // RVA: 0xA53C320
        public void SetTargetCertConstraints(){} // RVA: 0xA53C3C0
        public void GetInitialPolicies(){} // RVA: 0xA53C550
        public void SetInitialPolicies(){} // RVA: 0xA53C5D0
        public void SetCertPathCheckers(){} // RVA: 0xA53C870
        public void GetCertPathCheckers(){} // RVA: 0xA53CC00
        public void AddCertPathChecker(){} // RVA: 0xA53CF40
        public void Clone(){} // RVA: 0xA53CFC0
        public void SetParams(){} // RVA: 0xA53D070
        public void get_IsUseDeltasEnabled(){} // RVA: 0xBAB4F0
        public void set_IsUseDeltasEnabled(){} // RVA: 0xBAB500
        public void get_ValidityModel(){} // RVA: 0x14780B0
        public void set_ValidityModel(){} // RVA: 0x147EE80
        public void SetStores(){} // RVA: 0xA53D710
        public void AddStore(){} // RVA: 0xA53DA80
        public void AddAdditionalStore(){} // RVA: 0xA53DAF0
        public void GetAdditionalStores(){} // RVA: 0xA53DB60
        public void GetStores(){} // RVA: 0xA53DC00
        public void get_IsAdditionalLocationsEnabled(){} // RVA: 0xE3F480
        public void SetAdditionalLocationsEnabled(){} // RVA: 0x1546550
        public void GetTargetConstraints(){} // RVA: 0xA53DCA0
        public void SetTargetConstraints(){} // RVA: 0xA53DD40
        public void GetTrustedACIssuers(){} // RVA: 0xA53DEC0
        public void SetTrustedACIssuers(){} // RVA: 0xA53DF20
        public void GetNecessaryACAttributes(){} // RVA: 0xA53E290
        public void SetNecessaryACAttributes(){} // RVA: 0xA53E2F0
        public void GetProhibitedACAttributes(){} // RVA: 0xA53E5D0
        public void SetProhibitedACAttributes(){} // RVA: 0xA53E630
        public void GetAttrCertCheckers(){} // RVA: 0xA53E910
        public void SetAttrCertCheckers(){} // RVA: 0xA53E970
    }

    public class PkixPolicyNode : Object
    {
        public object mChildren;
        public object mDepth;
        public object mExpectedPolicies;
        public object mParent;
        public object mPolicyQualifiers;
        public object mValidPolicy;
        public object mCritical;

        // ── Methods ──
        public void get_Depth(){} // RVA: 0xE62D00
        public void get_Children(){} // RVA: 0xA53ECF0
        public void get_IsCritical(){} // RVA: 0xC02470
        public void set_IsCritical(){} // RVA: 0xC02480
        public void get_PolicyQualifiers(){} // RVA: 0xA53EDE0
        public void get_ValidPolicy(){} // RVA: 0xD05CA0
        public void get_HasChildren(){} // RVA: 0xA53EE40
        public void get_ExpectedPolicies(){} // RVA: 0xA53EEA0
        public void set_ExpectedPolicies(){} // RVA: 0xA53EF00
        public void get_Parent(){} // RVA: 0xB70160
        public void set_Parent(){} // RVA: 0xB44DC0
        public void .ctor(){} // RVA: 0xA53EFC0
        public void AddChild(){} // RVA: 0xA53F2D0
        public void RemoveChild(){} // RVA: 0xA53F350
        public void ToString(){} // RVA: 0xA53F400
        public void Clone(){} // RVA: 0x42E82B0
        public void Copy(){} // RVA: 0xA53F7F0
    }

    public class ReasonsMask : Object
    {
        public object _reasons;
        public object AllReasons;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x132A2D0
        public void AddReasons(){} // RVA: 0xA53FBA0
        public void get_IsAllReasons(){} // RVA: 0xA53FC00
        public void Intersect(){} // RVA: 0xA53FC70
        public void HasNewReasons(){} // RVA: 0xA53FD50
        public void get_Reasons(){} // RVA: 0xA53FDB0
        public void .cctor(){} // RVA: 0xA53FE50
    }

    public class Rfc3280CertPathUtilities : Object
    {
        public object CrlUtilities;
        public object ANY_POLICY;
        public object KEY_CERT_SIGN;
        public object CRL_SIGN;
        public object CrlReasons;

        // ── Methods ──
        public void ProcessCrlB2(){} // RVA: 0xA53FF00
        public void ProcessCertBC(){} // RVA: 0xA540D40
        public void PrepareNextCertA(){} // RVA: 0xA5415C0
        public void ProcessCertD(){} // RVA: 0xA541B00
        public void ProcessCrlB1(){} // RVA: 0xA542EC0
        public void ProcessCrlD(){} // RVA: 0xA5432F0
        public void ProcessCrlF(){} // RVA: 0xA543630
        public void ProcessCrlG(){} // RVA: 0xA5440D0
        public void ProcessCrlH(){} // RVA: 0xA544370
        public void CheckCrl(){} // RVA: 0xA544620
        public void CheckCrls(){} // RVA: 0xA5450B0
        public void PrepareCertB(){} // RVA: 0xA545B70
        public void ProcessCrlA1ii(){} // RVA: 0xA547170
        public void ProcessCrlA1i(){} // RVA: 0xA5475D0
        public void ProcessCertF(){} // RVA: 0xA547A10
        public void ProcessCertA(){} // RVA: 0xA547AA0
        public void PrepareNextCertI1(){} // RVA: 0xA548110
        public void PrepareNextCertI2(){} // RVA: 0xA548490
        public void PrepareNextCertG(){} // RVA: 0xA548810
        public void PrepareNextCertJ(){} // RVA: 0xA548CA0
        public void PrepareNextCertK(){} // RVA: 0xA548F40
        public void PrepareNextCertL(){} // RVA: 0xA549220
        public void PrepareNextCertM(){} // RVA: 0xA5493F0
        public void PrepareNextCertN(){} // RVA: 0xA549690
        public void PrepareNextCertO(){} // RVA: 0xA549830
        public void PrepareNextCertH1(){} // RVA: 0xA549B30
        public void PrepareNextCertH2(){} // RVA: 0xA549CA0
        public void PrepareNextCertH3(){} // RVA: 0xA549E10
        public void WrapupCertA(){} // RVA: 0xA549F80
        public void WrapupCertB(){} // RVA: 0xA54A040
        public void WrapupCertF(){} // RVA: 0xA54A400
        public void WrapupCertG(){} // RVA: 0xA54A6E0
        public void ProcessCrlC(){} // RVA: 0xA54B5C0
        public void ProcessCrlI(){} // RVA: 0xA54BBA0
        public void ProcessCrlJ(){} // RVA: 0xA54BC60
        public void ProcessCertE(){} // RVA: 0xA54BD00
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA54BF40
    }

    public class Rfc3281CertPathUtilities : Object
    {
        // ── Methods ──
        public void ProcessAttrCert7(){} // RVA: 0xA54C2F0
        public void CheckCrls(){} // RVA: 0xA54C830
        public void AdditionalChecks(){} // RVA: 0xA54D470
        public void ProcessAttrCert5(){} // RVA: 0xA54D890
        public void ProcessAttrCert4(){} // RVA: 0xA54DA40
        public void ProcessAttrCert3(){} // RVA: 0xA54DE00
        public void ProcessAttrCert2(){} // RVA: 0xA54DF50
        public void ProcessAttrCert1(){} // RVA: 0xA54E030
        public void CheckCrl(){} // RVA: 0xA54E920
        public void .ctor(){} // RVA: 0xB43310
    }

    public class TrustAnchor : Object
    {
        public object pubKey;
        public object caName;
        public object caPrincipal;
        public object trustedCert;
        public object ncBytes;
        public object nc;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA54F500
        public void get_TrustedCert(){} // RVA: 0xB70160
        public void get_CA(){} // RVA: 0xB700F0
        public void get_CAName(){} // RVA: 0xB465B0
        public void get_CAPublicKey(){} // RVA: 0xB5DBF0
        public void setNameConstraints(){} // RVA: 0xA54F6C0
        public void get_GetNameConstraints(){} // RVA: 0xA54F8F0
        public void ToString(){} // RVA: 0xA54F9A0
    }

}