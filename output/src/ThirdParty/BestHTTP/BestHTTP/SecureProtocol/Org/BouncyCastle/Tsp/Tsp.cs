// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Tsp
// Classes: 12
// Methods: 88

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Tsp
{
    public class GenTimeAccuracy : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void get_Seconds(){} // RVA: 0x7B1524A50
        public void get_Millis(){} // RVA: 0x7B1524AC0
        public void get_Micros(){} // RVA: 0x7B1524B30
        public void GetTimeComponent(){} // RVA: 0x7B1524BA0
        public void ToString(){} // RVA: 0x7B1524C00
    }

    public class TimeStampRequest : X509ExtensionBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B15251A0
        public void get_Version(){} // RVA: 0x7B1525360
        public void get_MessageImprintAlgOid(){} // RVA: 0x7B15253D0
        public void GetMessageImprintDigest(){} // RVA: 0x7B13A52B0
        public void get_ReqPolicy(){} // RVA: 0x7B1525420
        public void get_Nonce(){} // RVA: 0x7B1525450
        public void get_CertReq(){} // RVA: 0x7B1525480
        public void Validate(){} // RVA: 0x7B15254C0
        public void GetEncoded(){} // RVA: 0x7B128E860
        public void get_Extensions(){} // RVA: 0x7A88F3B10
        public void get_HasExtensions(){} // RVA: 0x7A9B3D890
        public void GetExtension(){} // RVA: 0x7B1525AC0
        public void GetExtensionOids(){} // RVA: 0x7B1525AE0
        public void GetX509Extensions(){} // RVA: 0x7A88F3B10
    }

    public class TimeStampRequestGenerator : Object
    {
        // ── Methods ──
        public void SetReqPolicy(){} // RVA: 0x7B1525CB0
        public void SetCertReq(){} // RVA: 0x7B1525D70
        public void AddExtension(){} // RVA: 0x7B1526120
        public void Generate(){} // RVA: 0x7B1526720
        public void .ctor(){} // RVA: 0x7B1526750
    }

    public class TimeStampResponse : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1526B00
        public void readTimeStampResp(){} // RVA: 0x7B1526B90
        public void get_Status(){} // RVA: 0x7B1526D10
        public void GetStatusString(){} // RVA: 0x7B1526D80
        public void GetFailInfo(){} // RVA: 0x7B1526ED0
        public void get_TimeStampToken(){} // RVA: 0x7A80DA7B0
        public void Validate(){} // RVA: 0x7B1526FE0
        public void GetEncoded(){} // RVA: 0x7B128E860
    }

    public class TimeStampResponseGenerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B15275E0
        public void AddStatusString(){} // RVA: 0x7B1527800
        public void SetFailInfoField(){} // RVA: 0x7B1527900
        public void GetPkiStatusInfo(){} // RVA: 0x7B1527910
        public void Generate(){} // RVA: 0x7B1527D10
        public void GenerateFailResponse(){} // RVA: 0x7B1528060
    }

    public class TimeStampToken : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1528270
        public void get_TimeStampInfo(){} // RVA: 0x7A81052C0
        public void get_SignerID(){} // RVA: 0x7A8D68680
        public void get_SignedAttributes(){} // RVA: 0x7B1528BA0
        public void get_UnsignedAttributes(){} // RVA: 0x7B1528BC0
        public void GetCertificates(){} // RVA: 0x7B1528BE0
        public void GetCrls(){} // RVA: 0x7B1528CD0
        public void GetAttributeCertificates(){} // RVA: 0x7B1528DC0
        public void Validate(){} // RVA: 0x7B1528EB0
        public void ToCmsSignedData(){} // RVA: 0x7A80F2570
        public void GetEncoded(){} // RVA: 0x7B1529870
    }

    public class TimeStampTokenGenerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1529CF0
        public void SetCertificates(){} // RVA: 0x7A81A0060
        public void SetCrls(){} // RVA: 0x7A8175E00
        public void SetAccuracySeconds(){} // RVA: 0x7A80DA0C0
        public void SetAccuracyMillis(){} // RVA: 0x7A8669360
        public void SetAccuracyMicros(){} // RVA: 0x7A84385B0
        public void SetOrdering(){} // RVA: 0x7A80F2590
        public void SetTsa(){} // RVA: 0x7A81052D0
        public void Generate(){} // RVA: 0x7B152A4A0
    }

    public class TimeStampTokenInfo : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B152B010
        public void get_IsOrdered(){} // RVA: 0x7B152B120
        public void get_Accuracy(){} // RVA: 0x7A88F3B10
        public void get_GenTime(){} // RVA: 0x7A80DA7B0
        public void get_GenTimeAccuracy(){} // RVA: 0x7B152B150
        public void get_Policy(){} // RVA: 0x7B152B200
        public void get_SerialNumber(){} // RVA: 0x7B152B230
        public void get_Tsa(){} // RVA: 0x7A8D094E0
        public void get_Nonce(){} // RVA: 0x7B152B260
        public void get_HashAlgorithm(){} // RVA: 0x7B152B290
        public void get_MessageImprintAlgOid(){} // RVA: 0x7B152B2C0
        public void GetMessageImprintDigest(){} // RVA: 0x7B152B310
        public void GetEncoded(){} // RVA: 0x7B128E860
        public void get_TstInfo(){} // RVA: 0x7A80F2570
    }

    public class TspAlgorithms : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7B152B340
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class TspException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B152C010
    }

    public class TspUtil : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7B152C080
        public void GetSignatureTimestamps(){} // RVA: 0x7B152D2C0
        public void ValidateCertificate(){} // RVA: 0x7B152D990
        public void GetDigestAlgName(){} // RVA: 0x7B152DD50
        public void GetDigestLength(){} // RVA: 0x7B152DE10
        public void CreateDigestInstance(){} // RVA: 0x7B152DF60
        public void GetCriticalExtensionOids(){} // RVA: 0x7B152DFF0
        public void GetNonCriticalExtensionOids(){} // RVA: 0x7B152E0B0
        public void GetExtensionOids(){} // RVA: 0x7B152E170
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class TspValidationException : TspException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B152E380
        public void get_FailureCode(){} // RVA: 0x7A846C760
    }

}