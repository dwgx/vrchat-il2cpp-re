// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Tsp
// Classes: 12
// Methods: 107

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Tsp
{
    public class GenTimeAccuracy : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Tsp.Accuracy Seconds; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void get_Seconds(){} // RVA: 0x7FFACBCF3BA0
        public void get_Millis(){} // RVA: 0x7FFACBCF3C10
        public void get_Micros(){} // RVA: 0x7FFACBCF3C80
        public void GetTimeComponent(){} // RVA: 0x7FFACBCF3CF0
        public void ToString(){} // RVA: 0x7FFACBCF3D50
    }

    public class TimeStampRequest : X509ExtensionBase
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Tsp.TimeStampReq Version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Extensions MessageImprintAlgOid; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBCF42E0 | overloaded x4
        public void get_Version(){} // RVA: 0x7FFACBCF4640
        public void get_MessageImprintAlgOid(){} // RVA: 0x7FFACBCF46B0
        public void GetMessageImprintDigest(){} // RVA: 0x7FFACBB77680
        public void get_ReqPolicy(){} // RVA: 0x7FFACBCF4700
        public void get_Nonce(){} // RVA: 0x7FFACBCF4730
        public void get_CertReq(){} // RVA: 0x7FFACBCF4760
        public void Validate(){} // RVA: 0x7FFACBCF47A0
        public void GetEncoded(){} // RVA: 0x7FFACBA639C0
        public void get_Extensions(){} // RVA: 0x7FFAC37735C0
        public void get_HasExtensions(){} // RVA: 0x7FFAC4860B40
        public void GetExtension(){} // RVA: 0x7FFACBCF4DD0
        public void GetExtensionOids(){} // RVA: 0x7FFACBCF4DF0
        public void GetX509Extensions(){} // RVA: 0x7FFAC37735C0
    }

    public class TimeStampRequestGenerator : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier reqPolicy; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerBoolean certReq; // 0x18
        public System.Collections.IDictionary extensions; // 0x20
        public System.Collections.IList extOrdering; // 0x28

        // ── Methods ──
        public void SetReqPolicy(){} // RVA: 0x7FFACBCF4FC0
        public void SetCertReq(){} // RVA: 0x7FFACBCF5080
        public void AddExtension(){} // RVA: 0x7FFACBCF5430 | overloaded x4
        public void Generate(){} // RVA: 0x7FFACBCF5A30 | overloaded x4
        public void .ctor(){} // RVA: 0x7FFACBCF5A60
    }

    public class TimeStampResponse : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Tsp.TimeStampResp Status; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Tsp.TimeStampToken TimeStampToken; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBCF5E10 | overloaded x3
        public void readTimeStampResp(){} // RVA: 0x7FFACBCF5EA0
        public void get_Status(){} // RVA: 0x7FFACBCF6020
        public void GetStatusString(){} // RVA: 0x7FFACBCF6090
        public void GetFailInfo(){} // RVA: 0x7FFACBCF61E0
        public void get_TimeStampToken(){} // RVA: 0x7FFAC2F247C0
        public void Validate(){} // RVA: 0x7FFACBCF62F0
        public void GetEncoded(){} // RVA: 0x7FFACBA639C0
    }

    public class TimeStampResponseGenerator : Object
    {
        public 0x6B0A88F0 status; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1EncodableVector statusStrings; // 0x18
        public int failInfo; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Tsp.TimeStampTokenGenerator tokenGenerator; // 0x28
        public System.Collections.IList acceptedAlgorithms; // 0x30
        public System.Collections.IList acceptedPolicies; // 0x38
        public System.Collections.IList acceptedExtensions; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBCF68E0 | overloaded x3
        public void AddStatusString(){} // RVA: 0x7FFACBCF6AF0
        public void SetFailInfoField(){} // RVA: 0x7FFACBCF6BF0
        public void GetPkiStatusInfo(){} // RVA: 0x7FFACBCF6C00
        public void Generate(){} // RVA: 0x7FFACBCF7000 | overloaded x2
        public void GenerateFailResponse(){} // RVA: 0x7FFACBCF7350
    }

    public class TimeStampToken : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Cms.CmsSignedData TimeStampInfo; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Cms.SignerInformation SignerID; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Tsp.TimeStampTokenInfo SignedAttributes; // 0x20
        public CertID UnsignedAttributes; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBCF7560 | overloaded x2
        public void get_TimeStampInfo(){} // RVA: 0x7FFAC2F4F0C0
        public void get_SignerID(){} // RVA: 0x7FFAC356C7D0
        public void get_SignedAttributes(){} // RVA: 0x7FFACBCF7E90
        public void get_UnsignedAttributes(){} // RVA: 0x7FFACBCF7EB0
        public void GetCertificates(){} // RVA: 0x7FFACBCF7ED0
        public void GetCrls(){} // RVA: 0x7FFACBCF7FC0
        public void GetAttributeCertificates(){} // RVA: 0x7FFACBCF80B0
        public void Validate(){} // RVA: 0x7FFACBCF81A0
        public void ToCmsSignedData(){} // RVA: 0x7FFAC2F3C380
        public void GetEncoded(){} // RVA: 0x7FFACBCF8B60
    }

    public class TimeStampTokenGenerator : Object
    {
        public int accuracySeconds; // 0x10
        public int accuracyMillis; // 0x14
        public int accuracyMicros; // 0x18
        public bool ordering; // 0x1C
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.GeneralName tsa; // 0x20
        public string tsaPolicyOID; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.AsymmetricKeyParameter key; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.X509.X509Certificate cert; // 0x38
        public string digestOID; // 0x40
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.AttributeTable signedAttr; // 0x48
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.AttributeTable unsignedAttr; // 0x50
        public BestHTTP.SecureProtocol.Org.BouncyCastle.X509.Store.IX509Store x509Certs; // 0x58
        public BestHTTP.SecureProtocol.Org.BouncyCastle.X509.Store.IX509Store x509Crls; // 0x60

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBCF8FE0 | overloaded x2
        public void SetCertificates(){} // RVA: 0x7FFAC2FE9510
        public void SetCrls(){} // RVA: 0x7FFAC2FBF380
        public void SetAccuracySeconds(){} // RVA: 0x7FFAC2F240C0
        public void SetAccuracyMillis(){} // RVA: 0x7FFAC33D4990
        public void SetAccuracyMicros(){} // RVA: 0x7FFAC392CD10
        public void SetOrdering(){} // RVA: 0x7FFAC2F3C3A0
        public void SetTsa(){} // RVA: 0x7FFAC2F4F0D0
        public void Generate(){} // RVA: 0x7FFACBCF9770
    }

    public class TimeStampTokenInfo : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Tsp.TstInfo IsOrdered; // 0x10
        public System.DateTime Accuracy; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBCFA2C0
        public void get_IsOrdered(){} // RVA: 0x7FFACBCFA3E0
        public void get_Accuracy(){} // RVA: 0x7FFAC37735C0
        public void get_GenTime(){} // RVA: 0x7FFAC2F247C0
        public void get_GenTimeAccuracy(){} // RVA: 0x7FFACBCFA410
        public void get_Policy(){} // RVA: 0x7FFACBCFA4C0
        public void get_SerialNumber(){} // RVA: 0x7FFACBCFA4F0
        public void get_Tsa(){} // RVA: 0x7FFAC8DBB230
        public void get_Nonce(){} // RVA: 0x7FFACBCFA520
        public void get_HashAlgorithm(){} // RVA: 0x7FFACBCFA550
        public void get_MessageImprintAlgOid(){} // RVA: 0x7FFACBCFA580
        public void GetMessageImprintDigest(){} // RVA: 0x7FFACBCFA5D0
        public void GetEncoded(){} // RVA: 0x7FFACBA639C0
        public void get_TstInfo(){} // RVA: 0x7FFAC2F3C380
    }

    public class TspAlgorithms : Object
    {
        public string MD5;
        public string Sha1; // 0x8
        public string Sha224; // 0x10
        public string Sha256; // 0x18
        public string Sha384; // 0x20
        public string Sha512; // 0x28
        public string RipeMD128; // 0x30
        public string RipeMD160; // 0x38
        public string RipeMD256; // 0x40
        public string Gost3411; // 0x48
        public string Gost3411_2012_256; // 0x50
        public string Gost3411_2012_512; // 0x58
        public string SM3; // 0x60
        public System.Collections.IList Allowed; // 0x68

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFACBCFA600
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class TspException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBCFB2D0 | overloaded x3
    }

    public class TspUtil : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Collections.ISet EmptySet;
        public System.Collections.IList EmptyList; // 0x8
        public System.Collections.IDictionary digestLengths; // 0x10
        public System.Collections.IDictionary digestNames; // 0x18

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFACBCFB340
        public void GetSignatureTimestamps(){} // RVA: 0x7FFACBCFC580
        public void ValidateCertificate(){} // RVA: 0x7FFACBCFCC60
        public void GetDigestAlgName(){} // RVA: 0x7FFACBCFD020
        public void GetDigestLength(){} // RVA: 0x7FFACBCFD0E0
        public void CreateDigestInstance(){} // RVA: 0x7FFACBCFD230
        public void GetCriticalExtensionOids(){} // RVA: 0x7FFACBCFD2C0
        public void GetNonCriticalExtensionOids(){} // RVA: 0x7FFACBCFD380
        public void GetExtensionOids(){} // RVA: 0x7FFACBCFD440
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class TspValidationException : TspException
    {
        public int FailureCode; // 0x90

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBCFD650 | overloaded x2
        public void get_FailureCode(){} // RVA: 0x7FFAC3220660
    }

}