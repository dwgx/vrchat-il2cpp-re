// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Tsp
// Classes: 12
// Methods: 88

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Tsp
{
    public class GenTimeAccuracy : Object
    {
        public object accuracy;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_Seconds(){} // RVA: 0xA38FD80
        public void get_Millis(){} // RVA: 0xA38FDF0
        public void get_Micros(){} // RVA: 0xA38FE60
        public void GetTimeComponent(){} // RVA: 0xA38FED0
        public void ToString(){} // RVA: 0xA38FF30
    }

    public class TimeStampRequest : X509ExtensionBase
    {
        public object req;
        public object extensions;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA3904D0
        public void get_Version(){} // RVA: 0xA390690
        public void get_MessageImprintAlgOid(){} // RVA: 0xA390700
        public void GetMessageImprintDigest(){} // RVA: 0xA2109D0
        public void get_ReqPolicy(){} // RVA: 0xA390750
        public void get_Nonce(){} // RVA: 0xA390780
        public void get_CertReq(){} // RVA: 0xA3907B0
        public void Validate(){} // RVA: 0xA3907F0
        public void GetEncoded(){} // RVA: 0xA0FA1B0
        public void get_Extensions(){} // RVA: 0x13F93E0
        public void get_HasExtensions(){} // RVA: 0x25E9250
        public void GetExtension(){} // RVA: 0xA390DE0
        public void GetExtensionOids(){} // RVA: 0xA390E00
        public void GetX509Extensions(){} // RVA: 0x13F93E0
    }

    public class TimeStampRequestGenerator : Object
    {
        public object reqPolicy;
        public object certReq;
        public object extensions;
        public object extOrdering;

        // ── Methods ──
        public void SetReqPolicy(){} // RVA: 0xA390FD0
        public void SetCertReq(){} // RVA: 0xA391090
        public void AddExtension(){} // RVA: 0xA391440
        public void Generate(){} // RVA: 0xA391A40
        public void .ctor(){} // RVA: 0xA391A70
    }

    public class TimeStampResponse : Object
    {
        public object resp;
        public object timeStampToken;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA391E20
        public void readTimeStampResp(){} // RVA: 0xA391EB0
        public void get_Status(){} // RVA: 0xA392030
        public void GetStatusString(){} // RVA: 0xA3920A0
        public void GetFailInfo(){} // RVA: 0xA3921F0
        public void get_TimeStampToken(){} // RVA: 0xB465B0
        public void Validate(){} // RVA: 0xA392300
        public void GetEncoded(){} // RVA: 0xA0FA1B0
    }

    public class TimeStampResponseGenerator : Object
    {
        public object status;
        public object statusStrings;
        public object failInfo;
        public object tokenGenerator;
        public object acceptedAlgorithms;
        public object acceptedPolicies;
        public object acceptedExtensions;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA392900
        public void AddStatusString(){} // RVA: 0xA392B20
        public void SetFailInfoField(){} // RVA: 0xA392C20
        public void GetPkiStatusInfo(){} // RVA: 0xA392C30
        public void Generate(){} // RVA: 0xA393030
        public void GenerateFailResponse(){} // RVA: 0xA393380
    }

    public class TimeStampToken : Object
    {
        public object tsToken;
        public object tsaSignerInfo;
        public object tstInfo;
        public object certID;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA393590
        public void get_TimeStampInfo(){} // RVA: 0xB700F0
        public void get_SignerID(){} // RVA: 0x1853320
        public void get_SignedAttributes(){} // RVA: 0xA393EC0
        public void get_UnsignedAttributes(){} // RVA: 0xA393EE0
        public void GetCertificates(){} // RVA: 0xA393F00
        public void GetCrls(){} // RVA: 0xA393FF0
        public void GetAttributeCertificates(){} // RVA: 0xA3940E0
        public void Validate(){} // RVA: 0xA3941D0
        public void ToCmsSignedData(){} // RVA: 0xB5DBF0
        public void GetEncoded(){} // RVA: 0xA394B90
    }

    public class TimeStampTokenGenerator : Object
    {
        public object accuracySeconds;
        public object accuracyMillis;
        public object accuracyMicros;
        public object ordering;
        public object tsa;
        public object tsaPolicyOID;
        public object key;
        public object cert;
        public object digestOID;
        public object signedAttr;
        public object unsignedAttr;
        public object x509Certs;
        public object x509Crls;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA395010
        public void SetCertificates(){} // RVA: 0xC0FFD0
        public void SetCrls(){} // RVA: 0xBE2C70
        public void SetAccuracySeconds(){} // RVA: 0xB460A0
        public void SetAccuracyMillis(){} // RVA: 0x116BB10
        public void SetAccuracyMicros(){} // RVA: 0x1033F40
        public void SetOrdering(){} // RVA: 0xB5DC10
        public void SetTsa(){} // RVA: 0xB70100
        public void Generate(){} // RVA: 0xA3957C0
    }

    public class TimeStampTokenInfo : Object
    {
        public object tstInfo;
        public object genTime;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA396330
        public void get_IsOrdered(){} // RVA: 0xA396440
        public void get_Accuracy(){} // RVA: 0x13F93E0
        public void get_GenTime(){} // RVA: 0xB465B0
        public void get_GenTimeAccuracy(){} // RVA: 0xA396470
        public void get_Policy(){} // RVA: 0xA396520
        public void get_SerialNumber(){} // RVA: 0xA396550
        public void get_Tsa(){} // RVA: 0x17F09D0
        public void get_Nonce(){} // RVA: 0xA396580
        public void get_HashAlgorithm(){} // RVA: 0xA3965B0
        public void get_MessageImprintAlgOid(){} // RVA: 0xA3965E0
        public void GetMessageImprintDigest(){} // RVA: 0xA396630
        public void GetEncoded(){} // RVA: 0xA0FA1B0
        public void get_TstInfo(){} // RVA: 0xB5DBF0
    }

    public class TspAlgorithms : Object
    {
        public object MD5;
        public object Sha1;
        public object Sha224;
        public object Sha256;
        public object Sha384;
        public object Sha512;
        public object RipeMD128;
        public object RipeMD160;
        public object RipeMD256;
        public object Gost3411;
        public object Gost3411_2012_256;
        public object Gost3411_2012_512;
        public object SM3;
        public object Allowed;

        // ── Methods ──
        public void .cctor(){} // RVA: 0xA396660
        public void .ctor(){} // RVA: 0xB43310
    }

    public class TspException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA397330
    }

    public class TspUtil : Object
    {
        public object EmptySet;
        public object EmptyList;
        public object digestLengths;
        public object digestNames;

        // ── Methods ──
        public void .cctor(){} // RVA: 0xA3973A0
        public void GetSignatureTimestamps(){} // RVA: 0xA3985D0
        public void ValidateCertificate(){} // RVA: 0xA398CA0
        public void GetDigestAlgName(){} // RVA: 0xA399060
        public void GetDigestLength(){} // RVA: 0xA399110
        public void CreateDigestInstance(){} // RVA: 0xA399250
        public void GetCriticalExtensionOids(){} // RVA: 0xA3992E0
        public void GetNonCriticalExtensionOids(){} // RVA: 0xA3993A0
        public void GetExtensionOids(){} // RVA: 0xA399460
        public void .ctor(){} // RVA: 0xB43310
    }

    public class TspValidationException : TspException
    {
        public object failureCode;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA399670
        public void get_FailureCode(){} // RVA: 0xF3A950
    }

}