// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Pkcs
// Classes: 27
// Methods: 159

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Pkcs
{
    public class AttributePkcs : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15ABB10
        public void .ctor(){} // RVA: 0x7A8CE4080
        public void get_AttrType(){} // RVA: 0x7A80F2570
        public void get_AttrValues(){} // RVA: 0x7A80DA7B0
        public void ToAsn1Object(){} // RVA: 0x7B15ABE40
    }

    public class AuthenticatedSafe : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B15AC1D0
        public void GetContentInfo(){} // RVA: 0x7B15AC2D0
        public void ToAsn1Object(){} // RVA: 0x7B15AC350
    }

    public class CertBag : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8CE4080
        public void get_CertID(){} // RVA: 0x7A80F2570
        public void get_CertValue(){} // RVA: 0x7A80DA7B0
        public void ToAsn1Object(){} // RVA: 0x7B15AC5F0
    }

    public class CertificationRequest : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15AC780
        public void .ctor(){} // RVA: 0x7B15AC890
        public void GetCertificationRequestInfo(){} // RVA: 0x7A80F2570
        public void get_SignatureAlgorithm(){} // RVA: 0x7A80DA7B0
        public void get_Signature(){} // RVA: 0x7A81052C0
        public void GetSignatureOctets(){} // RVA: 0x7AE513D50
        public void ToAsn1Object(){} // RVA: 0x7B15ACBA0
    }

    public class CertificationRequestInfo : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15ACD00
        public void .ctor(){} // RVA: 0x7B15AD010
        public void get_Version(){} // RVA: 0x7A80F2570
        public void get_Subject(){} // RVA: 0x7A80DA7B0
        public void get_SubjectPublicKeyInfo(){} // RVA: 0x7A81052C0
        public void get_Attributes(){} // RVA: 0x7A8105330
        public void ToAsn1Object(){} // RVA: 0x7B15AD450
        public void ValidateAttributes(){} // RVA: 0x7B15AD690
    }

    public class ContentInfo : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15ADA80
        public void .ctor(){} // RVA: 0x7A8CE4080
        public void get_ContentType(){} // RVA: 0x7A80F2570
        public void get_Content(){} // RVA: 0x7A80DA7B0
        public void ToAsn1Object(){} // RVA: 0x7B15ADD90
    }

    public class DHParameter : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B15AE240
        public void get_P(){} // RVA: 0x7B1564AD0
        public void get_G(){} // RVA: 0x7B1564AF0
        public void get_L(){} // RVA: 0x7B15AE5E0
        public void ToAsn1Object(){} // RVA: 0x7B15AE600
    }

    public class EncryptedData : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15AE850
        public void .ctor(){} // RVA: 0x7B15AED00
        public void get_ContentType(){} // RVA: 0x7B15AEF50
        public void get_EncryptionAlgorithm(){} // RVA: 0x7B15AEFF0
        public void get_Content(){} // RVA: 0x7B15AF030
        public void ToAsn1Object(){} // RVA: 0x7B15AF1B0
    }

    public class EncryptedPrivateKeyInfo : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B15AF4D0
        public void GetInstance(){} // RVA: 0x7B15AF680
        public void get_EncryptionAlgorithm(){} // RVA: 0x7A80F2570
        public void GetEncryptedData(){} // RVA: 0x7ADAB0020
        public void ToAsn1Object(){} // RVA: 0x7B15AF9C0
    }

    public class EncryptionScheme : AlgorithmIdentifier
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B15AFAD0
        public void GetInstance(){} // RVA: 0x7B15AFBB0
        public void get_Asn1Object(){} // RVA: 0x7B15AFE40
        public void ToAsn1Object(){} // RVA: 0x7B15AFE80
    }

    public class IssuerAndSerialNumber : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15AFFC0
        public void .ctor(){} // RVA: 0x7A8CE4080
        public void get_Name(){} // RVA: 0x7A80F2570
        public void get_CertificateSerialNumber(){} // RVA: 0x7A80DA7B0
        public void ToAsn1Object(){} // RVA: 0x7B15B0550
    }

    public class KeyDerivationFunc : AlgorithmIdentifier
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE18E510
    }

    public class MacData : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15B0670
        public void .ctor(){} // RVA: 0x7B15B0B80
        public void get_Mac(){} // RVA: 0x7A80F2570
        public void GetSalt(){} // RVA: 0x7B15B0D70
        public void get_IterationCount(){} // RVA: 0x7A81052C0
        public void ToAsn1Object(){} // RVA: 0x7B15B0DF0
    }

    public class PbeParameter : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15B1230
        public void .ctor(){} // RVA: 0x7B15B1710
        public void GetSalt(){} // RVA: 0x7ADB00F00
        public void get_IterationCount(){} // RVA: 0x7B158C310
        public void ToAsn1Object(){} // RVA: 0x7B15B1910
    }

    public class PbeS2Parameters : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15B1A20
        public void .ctor(){} // RVA: 0x7B15B1AD0
        public void get_KeyDerivationFunc(){} // RVA: 0x7A80F2570
        public void get_EncryptionScheme(){} // RVA: 0x7A80DA7B0
        public void ToAsn1Object(){} // RVA: 0x7B15B1EC0
    }

    public class Pbkdf2Params : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15B1FD0
        public void .ctor(){} // RVA: 0x7B15B2A30
        public void GetSalt(){} // RVA: 0x7ADB00F00
        public void get_IterationCount(){} // RVA: 0x7B158C310
        public void get_KeyLength(){} // RVA: 0x7B155F380
        public void get_IsDefaultPrf(){} // RVA: 0x7B15B2AA0
        public void get_Prf(){} // RVA: 0x7B15B2B30
        public void ToAsn1Object(){} // RVA: 0x7B15B2BA0
        public void .cctor(){} // RVA: 0x7B15B2E70
    }

    public class Pfx : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8CE4080
        public void get_AuthSafe(){} // RVA: 0x7A80F2570
        public void get_MacData(){} // RVA: 0x7A80DA7B0
        public void ToAsn1Object(){} // RVA: 0x7B15B3410
    }

    public class Pkcs12PbeParams : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B15B3840
        public void GetInstance(){} // RVA: 0x7B15B39E0
        public void get_Iterations(){} // RVA: 0x7B15B3D20
        public void GetIV(){} // RVA: 0x7ADAB0020
        public void ToAsn1Object(){} // RVA: 0x7B15B3D40
    }

    public class PkcsObjectIdentifiers : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7B15B3E50
    }

    public class PrivateKeyInfo : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15B7A40
        public void GetVersionValue(){} // RVA: 0x7B15B7B20
        public void .ctor(){} // RVA: 0x7B15B8090
        public void get_Attributes(){} // RVA: 0x7A8105330
        public void get_HasPublicKey(){} // RVA: 0x7ACDAB700
        public void get_PrivateKeyAlgorithm(){} // RVA: 0x7A80DA7B0
        public void ParsePrivateKey(){} // RVA: 0x7B15B8760
        public void ParsePublicKey(){} // RVA: 0x7B15B87A0
        public void get_PublicKeyData(){} // RVA: 0x7A83F69F0
        public void ToAsn1Object(){} // RVA: 0x7B15B87E0
    }

    public class RC2CbcParameter : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15B8A90
        public void .ctor(){} // RVA: 0x7B15B8F40
        public void get_RC2ParameterVersion(){} // RVA: 0x7B15B92C0
        public void GetIV(){} // RVA: 0x7B15B92E0
        public void ToAsn1Object(){} // RVA: 0x7B15B93C0
    }

    public class RsaPrivateKeyStructure : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15BA460
        public void .ctor(){} // RVA: 0x7B15BA540
        public void get_Modulus(){} // RVA: 0x7A80F2570
        public void get_PublicExponent(){} // RVA: 0x7A80DA7B0
        public void get_PrivateExponent(){} // RVA: 0x7A81052C0
        public void get_Prime1(){} // RVA: 0x7A8105330
        public void get_Prime2(){} // RVA: 0x7A83F69F0
        public void get_Exponent1(){} // RVA: 0x7A8292C30
        public void get_Exponent2(){} // RVA: 0x7A8154D80
        public void get_Coefficient(){} // RVA: 0x7A8152D80
        public void ToAsn1Object(){} // RVA: 0x7B15BAC70
    }

    public class RsaesOaepParameters : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15B9570
        public void .ctor(){} // RVA: 0x7B15B98C0
        public void get_HashAlgorithm(){} // RVA: 0x7A80F2570
        public void get_MaskGenAlgorithm(){} // RVA: 0x7A80DA7B0
        public void get_PSourceAlgorithm(){} // RVA: 0x7A81052C0
        public void ToAsn1Object(){} // RVA: 0x7B15B9BE0
        public void .cctor(){} // RVA: 0x7B15BA060
    }

    public class RsassaPssParameters : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15BB560
        public void .ctor(){} // RVA: 0x7B15BB900
        public void get_HashAlgorithm(){} // RVA: 0x7A80F2570
        public void get_MaskGenAlgorithm(){} // RVA: 0x7A80DA7B0
        public void get_SaltLength(){} // RVA: 0x7A81052C0
        public void get_TrailerField(){} // RVA: 0x7A8105330
        public void ToAsn1Object(){} // RVA: 0x7B15BBD50
        public void .cctor(){} // RVA: 0x7B15BC2D0
    }

    public class SafeBag : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B15BC750
        public void get_BagID(){} // RVA: 0x7A80F2570
        public void get_BagValue(){} // RVA: 0x7A80DA7B0
        public void get_BagAttributes(){} // RVA: 0x7A81052C0
        public void ToAsn1Object(){} // RVA: 0x7B15BCAB0
    }

    public class SignedData : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15BCD70
        public void .ctor(){} // RVA: 0x7B15BCE20
        public void get_Version(){} // RVA: 0x7A80F2570
        public void get_DigestAlgorithms(){} // RVA: 0x7A80DA7B0
        public void get_ContentInfo(){} // RVA: 0x7A81052C0
        public void get_Certificates(){} // RVA: 0x7A8105330
        public void get_Crls(){} // RVA: 0x7A83F69F0
        public void get_SignerInfos(){} // RVA: 0x7A8292C30
        public void ToAsn1Object(){} // RVA: 0x7B15BD3A0
    }

    public class SignerInfo : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15BD620
        public void .ctor(){} // RVA: 0x7B15BD800
        public void get_Version(){} // RVA: 0x7A80F2570
        public void get_IssuerAndSerialNumber(){} // RVA: 0x7A80DA7B0
        public void get_AuthenticatedAttributes(){} // RVA: 0x7A8105330
        public void get_DigestAlgorithm(){} // RVA: 0x7A81052C0
        public void get_EncryptedDigest(){} // RVA: 0x7A8292C30
        public void get_DigestEncryptionAlgorithm(){} // RVA: 0x7A83F69F0
        public void get_UnauthenticatedAttributes(){} // RVA: 0x7A8154D80
        public void ToAsn1Object(){} // RVA: 0x7B15BE020
    }

}