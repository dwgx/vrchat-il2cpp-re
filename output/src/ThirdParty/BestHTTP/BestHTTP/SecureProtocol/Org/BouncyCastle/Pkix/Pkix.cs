// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Pkix
// Classes: 23
// Methods: 290

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Pkix
{
    public class CertStatus : Object
    {
        public int RevocationDate;
        public int Status;
        public int status; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Date.DateTimeObject revocationDate; // 0x18

        // ── Methods ──
        public void get_RevocationDate(){} // RVA: 0x7FFAC2F247C0
        public void set_RevocationDate(){} // RVA: 0x7FFAC2F87E80
        public void get_Status(){} // RVA: 0x7FFAC2F6E5C0
        public void set_Status(){} // RVA: 0x7FFAC2F240C0
        public void .ctor(){} // RVA: 0x7FFACBCFD6D0
    }

    public class PkixAttrCertChecker : Object
    {
        // ── Methods ──
        public void GetSupportedExtensions(){} // RVA: 0x7FFAC2C58E90
        public void Check(){} // RVA: 0x7FFAC2C7B8C0
        public void Clone(){} // RVA: 0x7FFAC2C58E90
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class PkixAttrCertPathBuilder : Object
    {
        public System.Exception certPathException; // 0x10

        // ── Methods ──
        public void Build(){} // RVA: 0x7FFACBCFE0C0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class PkixAttrCertPathValidator : Object
    {
        // ── Methods ──
        public void Validate(){} // RVA: 0x7FFACBCFE880
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class PkixBuilderParameters : PkixParameters
    {
        public int MaxPathLength; // 0x90
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Collections.ISet excludedCerts; // 0x98

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBCFED40
        public void .ctor(){} // RVA: 0x7FFACBCFEE50
        public void get_MaxPathLength(){} // RVA: 0x7FFAC3220660
        public void set_MaxPathLength(){} // RVA: 0x7FFACBCFEF40
        public void GetExcludedCerts(){} // RVA: 0x7FFACBCFEFB0
        public void SetExcludedCerts(){} // RVA: 0x7FFACBCFF010
        public void SetParams(){} // RVA: 0x7FFACBCFF150
        public void Clone(){} // RVA: 0x7FFACBCFF2B0
        public void ToString(){} // RVA: 0x7FFACBCFF380
    }

    public class PkixCertPath : Object
    {
        public System.Collections.IList Encodings;
        public System.Collections.IList Certificates; // 0x10

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFACBCFF530
        public void SortCerts(){} // RVA: 0x7FFACBCFF6D0
        public void .ctor(){} // RVA: 0x7FFACBCFFF70 | overloaded x3
        public void get_Encodings(){} // RVA: 0x7FFACBD007A0
        public void Equals(){} // RVA: 0x7FFACBD008C0
        public void GetHashCode(){} // RVA: 0x7FFAC93E6070
        public void GetEncoded(){} // RVA: 0x7FFACBD00CE0 | overloaded x2
        public void get_Certificates(){} // RVA: 0x7FFACBD01850
        public void ToAsn1Object(){} // RVA: 0x7FFACBD01860
        public void ToDerEncoded(){} // RVA: 0x7FFACBD01910
    }

    public class PkixCertPathBuilder : Object
    {
        public System.Exception certPathException; // 0x10

        // ── Methods ──
        public void Build(){} // RVA: 0x7FFACBD020D0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class PkixCertPathBuilderException : GeneralSecurityException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBD028E0 | overloaded x3
    }

    public class PkixCertPathBuilderResult : PkixCertPathValidatorResult
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Pkix.PkixCertPath CertPath; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBD028F0
        public void get_CertPath(){} // RVA: 0x7FFAC2F4F130
        public void ToString(){} // RVA: 0x7FFACBD029D0
    }

    public class PkixCertPathChecker : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Init(){} // RVA: 0x7FFAC2C71060
        public void IsForwardCheckingSupported(){} // RVA: 0x7FFAC2C59D00
        public void GetSupportedExtensions(){} // RVA: 0x7FFAC2C58E90
        public void Check(){} // RVA: 0x7FFAC2C79B30
        public void Clone(){} // RVA: 0x7FFAC8512B10
    }

    public class PkixCertPathValidator : Object
    {
        // ── Methods ──
        public void Validate(){} // RVA: 0x7FFACBD02CB0
        public void CheckCertificate(){} // RVA: 0x7FFACBD044B0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class PkixCertPathValidatorException : GeneralSecurityException
    {
        public System.Exception Message; // 0x90
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Pkix.PkixCertPath CertPath; // 0x98
        public int Index; // 0xA0

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBD04700 | overloaded x4
        public void get_Message(){} // RVA: 0x7FFACBD04950
        public void get_CertPath(){} // RVA: 0x7FFAC354DFB0
        public void get_Index(){} // RVA: 0x7FFAC489E510
    }

    public class PkixCertPathValidatorResult : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Pkix.TrustAnchor PolicyTree; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Pkix.PkixPolicyNode TrustAnchor; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.AsymmetricKeyParameter SubjectPublicKey; // 0x20

        // ── Methods ──
        public void get_PolicyTree(){} // RVA: 0x7FFAC2F247C0
        public void get_TrustAnchor(){} // RVA: 0x7FFAC2F3C380
        public void get_SubjectPublicKey(){} // RVA: 0x7FFAC2F4F0C0
        public void .ctor(){} // RVA: 0x7FFACBD049A0
        public void Clone(){} // RVA: 0x7FFACBD04B60
        public void ToString(){} // RVA: 0x7FFACBD04BF0
    }

    public class PkixCertPathValidatorUtilities : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Pkix.PkixCrlUtilities CrlUtilities;
        public string ANY_POLICY; // 0x8
        public string CRL_NUMBER; // 0x10
        public int KEY_CERT_SIGN; // 0x18
        public int CRL_SIGN; // 0x1C
        public string[] crlReasons; // 0x20

        // ── Methods ──
        public void FindTrustAnchor(){} // RVA: 0x7FFACBD04EA0
        public void IsIssuerTrustAnchor(){} // RVA: 0x7FFACBD05300
        public void AddAdditionalStoresFromAltNames(){} // RVA: 0x7FFACBD05370
        public void GetValidDate(){} // RVA: 0x7FFACBD05700
        public void GetIssuerPrincipal(){} // RVA: 0x7FFACBD05780
        public void IsSelfIssued(){} // RVA: 0x7FFACBD058D0
        public void GetAlgorithmIdentifier(){} // RVA: 0x7FFACBD05940
        public void IsAnyPolicy(){} // RVA: 0x7FFACBD059D0
        public void AddAdditionalStoreFromLocation(){} // RVA: 0x7FFACBD05A90
        public void GetSerialNumber(){} // RVA: 0x7FFACBD05C60
        public void GetQualifierSet(){} // RVA: 0x7FFACBD05D70
        public void RemovePolicyNode(){} // RVA: 0x7FFACBD06030
        public void RemovePolicyNodeRecurse(){} // RVA: 0x7FFACBD06200
        public void PrepareNextCertB1(){} // RVA: 0x7FFACBD06500
        public void PrepareNextCertB2(){} // RVA: 0x7FFACBD06D60
        public void GetCertStatus(){} // RVA: 0x7FFACBD07220
        public void GetNextWorkingKey(){} // RVA: 0x7FFACBD078F0
        public void GetValidCertDateFromValidityModel(){} // RVA: 0x7FFACBD07CC0
        public void FindCertificates(){} // RVA: 0x7FFACBD09990 | overloaded x2
        public void GetCrlIssuersFromDistributionPoint(){} // RVA: 0x7FFACBD08490
        public void GetCompleteCrls(){} // RVA: 0x7FFACBD088D0
        public void GetDeltaCrls(){} // RVA: 0x7FFACBD08F70
        public void isDeltaCrl(){} // RVA: 0x7FFACBD098E0
        public void AddAdditionalStoresFromCrlDistributionPoint(){} // RVA: 0x7FFACBD09D80
        public void ProcessCertD1i(){} // RVA: 0x7FFACBD09F60
        public void ProcessCertD1ii(){} // RVA: 0x7FFACBD0A220
        public void FindIssuerCerts(){} // RVA: 0x7FFACBD0A520
        public void GetExtensionValue(){} // RVA: 0x7FFACBD0A7B0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBD0A840
    }

    public class PkixCrlUtilities : Object
    {
        // ── Methods ──
        public void FindCrls(){} // RVA: 0x7FFACBD0B380 | overloaded x3
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class PkixNameConstraintValidator : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier SerialNumberOid;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Collections.ISet excludedSubtreesDN; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Collections.ISet excludedSubtreesDNS; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Collections.ISet excludedSubtreesEmail; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Collections.ISet excludedSubtreesURI; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Collections.ISet excludedSubtreesIP; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Collections.ISet permittedSubtreesDN; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Collections.ISet permittedSubtreesDNS; // 0x40
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Collections.ISet permittedSubtreesEmail; // 0x48
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Collections.ISet permittedSubtreesURI; // 0x50
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Collections.ISet permittedSubtreesIP; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBD0B680
        public void WithinDNSubtree(){} // RVA: 0x7FFACBD0B900
        public void CheckPermittedDN(){} // RVA: 0x7FFACBD0BCB0 | overloaded x2
        public void CheckExcludedDN(){} // RVA: 0x7FFACBD0BE90 | overloaded x2
        public void IntersectDN(){} // RVA: 0x7FFACBD0C050
        public void UnionDN(){} // RVA: 0x7FFACBD0C350
        public void IntersectEmail(){} // RVA: 0x7FFACBD0C680
        public void UnionEmail(){} // RVA: 0x7FFACBD0EE50 | overloaded x2
        public void IntersectIP(){} // RVA: 0x7FFACBD0CB70
        public void UnionIP(){} // RVA: 0x7FFACBD0CE00
        public void UnionIPRange(){} // RVA: 0x7FFACBD0D110
        public void IntersectIPRange(){} // RVA: 0x7FFACBD0D280
        public void IpWithSubnetMask(){} // RVA: 0x7FFACBD0D7F0
        public void ExtractIPsAndSubnetMasks(){} // RVA: 0x7FFACBD0D8A0
        public void MinMaxIPs(){} // RVA: 0x7FFACBD0DA40
        public void CheckPermittedEmail(){} // RVA: 0x7FFACBD0DCA0
        public void CheckExcludedEmail(){} // RVA: 0x7FFACBD0DE30
        public void CheckPermittedIP(){} // RVA: 0x7FFACBD0DFA0
        public void CheckExcludedIP(){} // RVA: 0x7FFACBD0E140
        public void IsIPConstrained(){} // RVA: 0x7FFACBD0E2E0
        public void EmailIsConstrained(){} // RVA: 0x7FFACBD0E500
        public void WithinDomain(){} // RVA: 0x7FFACBD0E6F0
        public void CheckPermittedDns(){} // RVA: 0x7FFACBD0E950
        public void CheckExcludedDns(){} // RVA: 0x7FFACBD0EC00
        public void unionURI(){} // RVA: 0x7FFACBD10290 | overloaded x2
        public void intersectDNS(){} // RVA: 0x7FFACBD0F590
        public void unionDNS(){} // RVA: 0x7FFACBD0F860
        public void intersectEmail(){} // RVA: 0x7FFACBD0FB40
        public void checkExcludedURI(){} // RVA: 0x7FFACBD0FEB0
        public void intersectURI(){} // RVA: 0x7FFACBD10510 | overloaded x2
        public void CheckPermittedURI(){} // RVA: 0x7FFACBD10880
        public void IsUriConstrained(){} // RVA: 0x7FFACBD10A10
        public void ExtractHostFromURL(){} // RVA: 0x7FFACBD10B30
        public void checkPermitted(){} // RVA: 0x7FFACBD10D00
        public void checkExcluded(){} // RVA: 0x7FFACBD112E0
        public void IntersectPermittedSubtree(){} // RVA: 0x7FFACBD11890
        public void ExtractNameAsString(){} // RVA: 0x7FFACBD12080
        public void IntersectEmptyPermittedSubtree(){} // RVA: 0x7FFACBD120C0
        public void AddExcludedSubtree(){} // RVA: 0x7FFACBD12220
        public void Max(){} // RVA: 0x7FFACBD12490
        public void Min(){} // RVA: 0x7FFACBD12500
        public void CompareTo(){} // RVA: 0x7FFACBD12570
        public void Or(){} // RVA: 0x7FFACBD127B0
        public void HashCode(){} // RVA: 0x7FFACBD12850
        public void GetHashCode(){} // RVA: 0x7FFACBD12870
        public void HashCollection(){} // RVA: 0x7FFACBD12970
        public void Equals(){} // RVA: 0x7FFACBD12C20
        public void CollectionsAreEqual(){} // RVA: 0x7FFACBD12DD0
        public void SpecialEquals(){} // RVA: 0x7FFACBD12F60
        public void StringifyIP(){} // RVA: 0x7FFACBD130C0
        public void StringifyIPCollection(){} // RVA: 0x7FFACBD13320
        public void ToString(){} // RVA: 0x7FFACBD135C0
        public void .cctor(){} // RVA: 0x7FFACBD13A70
    }

    public class PkixNameConstraintValidatorException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBE99570
    }

    public class PkixParameters : Object
    {
        public int IsRevocationEnabled;
        public int IsExplicitPolicyRequired;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Collections.ISet IsAnyPolicyInhibited; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Date.DateTimeObject IsPolicyMappingInhibited; // 0x18
        public System.Collections.IList IsPolicyQualifiersRejected; // 0x20
        public bool Date; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Collections.ISet IsUseDeltasEnabled; // 0x30
        public bool ValidityModel; // 0x38
        public bool IsAdditionalLocationsEnabled; // 0x39
        public bool policyMappingInhibited; // 0x3A
        public bool policyQualifiersRejected; // 0x3B
        public BestHTTP.SecureProtocol.Org.BouncyCastle.X509.Store.IX509Selector certSelector; // 0x40
        public System.Collections.IList stores; // 0x48
        public BestHTTP.SecureProtocol.Org.BouncyCastle.X509.Store.IX509Selector selector; // 0x50
        public bool additionalLocationsEnabled; // 0x58
        public System.Collections.IList additionalStores; // 0x60
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Collections.ISet trustedACIssuers; // 0x68
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Collections.ISet necessaryACAttributes; // 0x70
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Collections.ISet prohibitedACAttributes; // 0x78
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Collections.ISet attrCertCheckers; // 0x80
        public int validityModel; // 0x88
        public bool useDeltas; // 0x8C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBE995D0
        public void get_IsRevocationEnabled(){} // RVA: 0x7FFAC30F6BA0
        public void set_IsRevocationEnabled(){} // RVA: 0x7FFAC3C24F40
        public void get_IsExplicitPolicyRequired(){} // RVA: 0x7FFAC31D95D0
        public void set_IsExplicitPolicyRequired(){} // RVA: 0x7FFAC31D95C0
        public void get_IsAnyPolicyInhibited(){} // RVA: 0x7FFAC33BCE50
        public void set_IsAnyPolicyInhibited(){} // RVA: 0x7FFAC33BD1D0
        public void get_IsPolicyMappingInhibited(){} // RVA: 0x7FFAC3F7B7C0
        public void set_IsPolicyMappingInhibited(){} // RVA: 0x7FFAC848C150
        public void get_IsPolicyQualifiersRejected(){} // RVA: 0x7FFAC3F729F0
        public void set_IsPolicyQualifiersRejected(){} // RVA: 0x7FFAC8E13E40
        public void get_Date(){} // RVA: 0x7FFAC2F247C0
        public void set_Date(){} // RVA: 0x7FFAC2F87E80
        public void GetTrustAnchors(){} // RVA: 0x7FFACBE99A40
        public void SetTrustAnchors(){} // RVA: 0x7FFACBE99AA0
        public void GetTargetCertConstraints(){} // RVA: 0x7FFACBE99E40
        public void SetTargetCertConstraints(){} // RVA: 0x7FFACBE99EE0
        public void GetInitialPolicies(){} // RVA: 0x7FFACBE9A070
        public void SetInitialPolicies(){} // RVA: 0x7FFACBE9A0F0
        public void SetCertPathCheckers(){} // RVA: 0x7FFACBE9A3B0
        public void GetCertPathCheckers(){} // RVA: 0x7FFACBE9A760
        public void AddCertPathChecker(){} // RVA: 0x7FFACBE9AAB0
        public void Clone(){} // RVA: 0x7FFACBE9AB30
        public void SetParams(){} // RVA: 0x7FFACBE9ABE0
        public void get_IsUseDeltasEnabled(){} // RVA: 0x7FFAC2F89520
        public void set_IsUseDeltasEnabled(){} // RVA: 0x7FFAC2F89530
        public void get_ValidityModel(){} // RVA: 0x7FFAC37EE8C0
        public void set_ValidityModel(){} // RVA: 0x7FFAC37F9DE0
        public void SetStores(){} // RVA: 0x7FFACBE9B280
        public void AddStore(){} // RVA: 0x7FFACBE9B600
        public void AddAdditionalStore(){} // RVA: 0x7FFACBE9B670
        public void GetAdditionalStores(){} // RVA: 0x7FFACBE9B6E0
        public void GetStores(){} // RVA: 0x7FFACBE9B780
        public void get_IsAdditionalLocationsEnabled(){} // RVA: 0x7FFAC313F600
        public void SetAdditionalLocationsEnabled(){} // RVA: 0x7FFAC3892770
        public void GetTargetConstraints(){} // RVA: 0x7FFACBE9B820
        public void SetTargetConstraints(){} // RVA: 0x7FFACBE9B8C0
        public void GetTrustedACIssuers(){} // RVA: 0x7FFACBE9BA40
        public void SetTrustedACIssuers(){} // RVA: 0x7FFACBE9BAA0
        public void GetNecessaryACAttributes(){} // RVA: 0x7FFACBE9BE30
        public void SetNecessaryACAttributes(){} // RVA: 0x7FFACBE9BE90
        public void GetProhibitedACAttributes(){} // RVA: 0x7FFACBE9C190
        public void SetProhibitedACAttributes(){} // RVA: 0x7FFACBE9C1F0
        public void GetAttrCertCheckers(){} // RVA: 0x7FFACBE9C4F0
        public void SetAttrCertCheckers(){} // RVA: 0x7FFACBE9C550
    }

    public class PkixPolicyNode : Object
    {
        public System.Collections.IList Depth; // 0x10
        public int Children; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Collections.ISet IsCritical; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Pkix.PkixPolicyNode PolicyQualifiers; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Collections.ISet ValidPolicy; // 0x30
        public string HasChildren; // 0x38
        public bool ExpectedPolicies; // 0x40

        // ── Methods ──
        public void get_Depth(){} // RVA: 0x7FFAC3157800
        public void get_Children(){} // RVA: 0x7FFACBE9C8E0
        public void get_IsCritical(){} // RVA: 0x7FFAC2FDCC00
        public void set_IsCritical(){} // RVA: 0x7FFAC2FDCC10
        public void get_PolicyQualifiers(){} // RVA: 0x7FFACBE9C9D0
        public void get_ValidPolicy(){} // RVA: 0x7FFAC31D0140
        public void get_HasChildren(){} // RVA: 0x7FFACBE9CA30
        public void get_ExpectedPolicies(){} // RVA: 0x7FFACBE9CA90
        public void set_ExpectedPolicies(){} // RVA: 0x7FFACBE9CAF0
        public void get_Parent(){} // RVA: 0x7FFAC2F4F130
        public void set_Parent(){} // RVA: 0x7FFAC2F22E90
        public void .ctor(){} // RVA: 0x7FFACBE9CBB0
        public void AddChild(){} // RVA: 0x7FFACBE9CEC0
        public void RemoveChild(){} // RVA: 0x7FFACBE9CF40
        public void ToString(){} // RVA: 0x7FFACBE9CFF0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC617D250
        public void Copy(){} // RVA: 0x7FFACBE9D3D0
    }

    public class ReasonsMask : Object
    {
        public int IsAllReasons; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Pkix.ReasonsMask Reasons;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC369FBB0 | overloaded x2
        public void AddReasons(){} // RVA: 0x7FFACBE9D7A0
        public void get_IsAllReasons(){} // RVA: 0x7FFACBE9D800
        public void Intersect(){} // RVA: 0x7FFACBE9D870
        public void HasNewReasons(){} // RVA: 0x7FFACBE9D950
        public void get_Reasons(){} // RVA: 0x7FFACBE9D9B0
        public void .cctor(){} // RVA: 0x7FFACBE9DA50
    }

    public class Rfc3280CertPathUtilities : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Pkix.PkixCrlUtilities CrlUtilities;
        public string ANY_POLICY; // 0x8
        public int KEY_CERT_SIGN; // 0x10
        public int CRL_SIGN; // 0x14
        public string[] CrlReasons; // 0x18

        // ── Methods ──
        public void ProcessCrlB2(){} // RVA: 0x7FFACBE9DB00
        public void ProcessCertBC(){} // RVA: 0x7FFACBE9E910
        public void PrepareNextCertA(){} // RVA: 0x7FFACBE9F1B0
        public void ProcessCertD(){} // RVA: 0x7FFACBE9F6F0
        public void ProcessCrlB1(){} // RVA: 0x7FFACBEA0AB0
        public void ProcessCrlD(){} // RVA: 0x7FFACBEA0EE0
        public void ProcessCrlF(){} // RVA: 0x7FFACBEA1220
        public void ProcessCrlG(){} // RVA: 0x7FFACBEA1CB0
        public void ProcessCrlH(){} // RVA: 0x7FFACBEA1F40
        public void CheckCrl(){} // RVA: 0x7FFACBEA2200
        public void CheckCrls(){} // RVA: 0x7FFACBEA2C70
        public void PrepareCertB(){} // RVA: 0x7FFACBEA3750
        public void ProcessCrlA1ii(){} // RVA: 0x7FFACBEA4E00
        public void ProcessCrlA1i(){} // RVA: 0x7FFACBEA5260
        public void ProcessCertF(){} // RVA: 0x7FFACBEA56A0
        public void ProcessCertA(){} // RVA: 0x7FFACBEA5730
        public void PrepareNextCertI1(){} // RVA: 0x7FFACBEA5DA0
        public void PrepareNextCertI2(){} // RVA: 0x7FFACBEA6120
        public void PrepareNextCertG(){} // RVA: 0x7FFACBEA64A0
        public void PrepareNextCertJ(){} // RVA: 0x7FFACBEA6930
        public void PrepareNextCertK(){} // RVA: 0x7FFACBEA6BC0
        public void PrepareNextCertL(){} // RVA: 0x7FFACBEA6E90
        public void PrepareNextCertM(){} // RVA: 0x7FFACBEA7060
        public void PrepareNextCertN(){} // RVA: 0x7FFACBEA72F0
        public void PrepareNextCertO(){} // RVA: 0x7FFACBEA7490
        public void PrepareNextCertH1(){} // RVA: 0x7FFACBEA7790
        public void PrepareNextCertH2(){} // RVA: 0x7FFACBEA7900
        public void PrepareNextCertH3(){} // RVA: 0x7FFACBEA7A70
        public void WrapupCertA(){} // RVA: 0x7FFACBEA7BE0
        public void WrapupCertB(){} // RVA: 0x7FFACBEA7CA0
        public void WrapupCertF(){} // RVA: 0x7FFACBEA8060
        public void WrapupCertG(){} // RVA: 0x7FFACBEA8340
        public void ProcessCrlC(){} // RVA: 0x7FFACBEA91E0
        public void ProcessCrlI(){} // RVA: 0x7FFACBEA97C0
        public void ProcessCrlJ(){} // RVA: 0x7FFACBEA9880
        public void ProcessCertE(){} // RVA: 0x7FFACBEA9920
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBEA9B60
    }

    public class Rfc3281CertPathUtilities : Object
    {
        // ── Methods ──
        public void ProcessAttrCert7(){} // RVA: 0x7FFACBEA9F10
        public void CheckCrls(){} // RVA: 0x7FFACBEAA460
        public void AdditionalChecks(){} // RVA: 0x7FFACBEAB090
        public void ProcessAttrCert5(){} // RVA: 0x7FFACBEAB4E0
        public void ProcessAttrCert4(){} // RVA: 0x7FFACBEAB690
        public void ProcessAttrCert3(){} // RVA: 0x7FFACBEABA60
        public void ProcessAttrCert2(){} // RVA: 0x7FFACBEABBB0
        public void ProcessAttrCert1(){} // RVA: 0x7FFACBEABC90
        public void CheckCrl(){} // RVA: 0x7FFACBEAC580
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class TrustAnchor : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.AsymmetricKeyParameter TrustedCert; // 0x10
        public string CA; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Name CAName; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.X509.X509Certificate CAPublicKey; // 0x28
        public byte[] GetNameConstraints; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.NameConstraints nc; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBEAD120 | overloaded x3
        public void get_TrustedCert(){} // RVA: 0x7FFAC2F4F130
        public void get_CA(){} // RVA: 0x7FFAC2F4F0C0
        public void get_CAName(){} // RVA: 0x7FFAC2F247C0
        public void get_CAPublicKey(){} // RVA: 0x7FFAC2F3C380
        public void setNameConstraints(){} // RVA: 0x7FFACBEAD2E0
        public void get_GetNameConstraints(){} // RVA: 0x7FFACBEAD510
        public void ToString(){} // RVA: 0x7FFACBEAD5C0
    }

}