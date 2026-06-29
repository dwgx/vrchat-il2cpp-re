// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
// Classes: 18
// Methods: 75

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
    public class CertChainType : Object
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x7B134C9F0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class Certificate : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B134CA00
        public void GetCertificateList(){} // RVA: 0x7A82393C0
        public void GetCertificateAt(){} // RVA: 0x7AE8C8950
        public void get_Length(){} // RVA: 0x7A8D0A110
        public void get_IsEmpty(){} // RVA: 0x7B134CAB0
        public void Encode(){} // RVA: 0x7B134CAD0
        public void Parse(){} // RVA: 0x7B134D060
        public void CloneCertificateList(){} // RVA: 0x7B134D6B0
        public void .cctor(){} // RVA: 0x7B134D730
    }

    public class CertificateRequest : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A81B7C50
        public void get_CertificateTypes(){} // RVA: 0x7A80F2570
        public void get_SupportedSignatureAlgorithms(){} // RVA: 0x7A80DA7B0
        public void get_CertificateAuthorities(){} // RVA: 0x7A81052C0
        public void Encode(){} // RVA: 0x7B134D8A0
        public void Parse(){} // RVA: 0x7B134E130
    }

    public class CertificateStatus : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B134E720
        public void get_StatusType(){} // RVA: 0x7A81A2200
        public void get_Response(){} // RVA: 0x7A80DA7B0
        public void GetOcspResponse(){} // RVA: 0x7B134E800
        public void Encode(){} // RVA: 0x7B134E920
        public void Parse(){} // RVA: 0x7B134EA90
        public void IsCorrectType(){} // RVA: 0x7B134ED00
    }

    public class CertificateStatusRequest : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B134EDF0
        public void get_StatusType(){} // RVA: 0x7A81A2200
        public void get_Request(){} // RVA: 0x7A80DA7B0
        public void GetOcspStatusRequest(){} // RVA: 0x7B134EED0
        public void Encode(){} // RVA: 0x7B134EFF0
        public void Parse(){} // RVA: 0x7B134F120
        public void IsCorrectType(){} // RVA: 0x7B134F320
    }

    public class CertificateStatusType : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class CertificateType : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class CertificateUrl : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B134F410
        public void get_Type(){} // RVA: 0x7A81A2200
        public void get_UrlAndHashList(){} // RVA: 0x7A80DA7B0
        public void Encode(){} // RVA: 0x7B134F550
        public void parse(){} // RVA: 0x7B134F9A0
    }

    public class Chacha20Poly1305 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B134FFE0
        public void GetPlaintextLimit(){} // RVA: 0x7B1350420
        public void EncodePlaintext(){} // RVA: 0x7B1350430
        public void DecodeCiphertext(){} // RVA: 0x7B13505B0
        public void InitRecord(){} // RVA: 0x7B1350860
        public void CalculateNonce(){} // RVA: 0x7B1350970
        public void GenerateRecordMacKey(){} // RVA: 0x7B1350A60
        public void CalculateRecordMac(){} // RVA: 0x7B1350B90
        public void UpdateRecordMacLength(){} // RVA: 0x7B1350EA0
        public void UpdateRecordMacText(){} // RVA: 0x7B1350F70
        public void GetAdditionalData(){} // RVA: 0x7B1351070
        public void .cctor(){} // RVA: 0x7B13511A0
    }

    public class ChangeCipherSpec : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class CipherSuite : Object
    {
        // ── Methods ──
        public void IsScsv(){} // RVA: 0x7B1351260
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class CipherType : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class ClientAuthenticationType : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class ClientCertificateType : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class CombinedHash : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13513A0
        public void Init(){} // RVA: 0x7A80D8E20
        public void NotifyPrfDetermined(){} // RVA: 0x7A97F8BA0
        public void TrackHashAlgorithm(){} // RVA: 0x7B1351540
        public void SealHashAlgorithms(){} // RVA: 0x7A80D7310
        public void StopTracking(){} // RVA: 0x7B1351590
        public void ForkPrfHash(){} // RVA: 0x7B13515F0
        public void GetFinalHash(){} // RVA: 0x7B1351650
        public void get_AlgorithmName(){} // RVA: 0x7B13516A0
        public void GetByteLength(){} // RVA: 0x7B1351740
        public void GetDigestSize(){} // RVA: 0x7B13517F0
        public void Update(){} // RVA: 0x7B1351870
        public void BlockUpdate(){} // RVA: 0x7B13518F0
        public void DoFinal(){} // RVA: 0x7B13519A0
        public void Reset(){} // RVA: 0x7B1351B40
        public void Ssl3Complete(){} // RVA: 0x7B1351BB0
    }

    public class CompressionMethod : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class ConnectionEnd : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class ContentType : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

}