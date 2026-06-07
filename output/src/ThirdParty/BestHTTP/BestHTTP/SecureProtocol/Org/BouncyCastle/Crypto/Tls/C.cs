// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
// Classes: 18
// Methods: 76

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
    public class CertChainType
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x9516850
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class Certificate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9516860
        public void GetCertificateList(){} // RVA: 0x43E1C0
        public void GetCertificateAt(){} // RVA: 0x6AD84E0
        public void get_Length(){} // RVA: 0xF3F910
        public void get_IsEmpty(){} // RVA: 0x9516910
        public void Encode(){} // RVA: 0x9516930
        public void Parse(){} // RVA: 0x9516ED0
        public void CloneCertificateList(){} // RVA: 0x95174F0
        public void .cctor(){} // RVA: 0x9517570
    }

    public class CertificateRequest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3BCE00
        public void get_CertificateTypes(){} // RVA: 0x2F8380
        public void get_SupportedSignatureAlgorithms(){} // RVA: 0x2E07C0
        public void get_CertificateAuthorities(){} // RVA: 0x30B0C0
        public void Encode(){} // RVA: 0x95176E0
        public void Parse(){} // RVA: 0x9517F70
    }

    public class CertificateStatus
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9518560
        public void get_StatusType(){} // RVA: 0x3A75E0
        public void get_Response(){} // RVA: 0x2E07C0
        public void GetOcspResponse(){} // RVA: 0x9518640
        public void Encode(){} // RVA: 0x9518760
        public void Parse(){} // RVA: 0x95188D0
        public void IsCorrectType(){} // RVA: 0x9518B30
    }

    public class CertificateStatusRequest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9518C30
        public void get_StatusType(){} // RVA: 0x3A75E0
        public void get_Request(){} // RVA: 0x2E07C0
        public void GetOcspStatusRequest(){} // RVA: 0x9518D10
        public void Encode(){} // RVA: 0x9518E30
        public void Parse(){} // RVA: 0x9518F60
        public void IsCorrectType(){} // RVA: 0x9519150
    }

    public class CertificateStatusType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class CertificateType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class CertificateUrl
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9519250
        public void get_Type(){} // RVA: 0x3A75E0
        public void get_UrlAndHashList(){} // RVA: 0x2E07C0
        public void Encode(){} // RVA: 0x9519390
        public void parse(){} // RVA: 0x95197F0
    }

    public class Chacha20Poly1305
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9519E30
        public void GetPlaintextLimit(){} // RVA: 0x951A280
        public void EncodePlaintext(){} // RVA: 0x951A290
        public void DecodeCiphertext(){} // RVA: 0x951A410
        public void InitRecord(){} // RVA: 0x951A6B0
        public void CalculateNonce(){} // RVA: 0x951A7C0
        public void GenerateRecordMacKey(){} // RVA: 0x951A8A0
        public void CalculateRecordMac(){} // RVA: 0x951A9D0
        public void UpdateRecordMacLength(){} // RVA: 0x951ACE0
        public void UpdateRecordMacText(){} // RVA: 0x951ADB0
        public void GetAdditionalData(){} // RVA: 0x951AEB0
        public void .cctor(){} // RVA: 0x951AFE0
    }

    public class ChangeCipherSpec
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class CipherSuite
    {
        // ── Methods ──
        public void IsScsv(){} // RVA: 0x951B0A0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class CipherType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ClientAuthenticationType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ClientCertificateType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class CombinedHash
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x951B1E0 | overloaded x2
        public void Init(){} // RVA: 0x2DEE30
        public void NotifyPrfDetermined(){} // RVA: 0x1A3F520
        public void TrackHashAlgorithm(){} // RVA: 0x951B380
        public void SealHashAlgorithms(){} // RVA: 0x2DD310
        public void StopTracking(){} // RVA: 0x951B3D0
        public void ForkPrfHash(){} // RVA: 0x951B430
        public void GetFinalHash(){} // RVA: 0x951B490
        public void get_AlgorithmName(){} // RVA: 0x951B4E0
        public void GetByteLength(){} // RVA: 0x951B580
        public void GetDigestSize(){} // RVA: 0x951B630
        public void Update(){} // RVA: 0x951B6B0
        public void BlockUpdate(){} // RVA: 0x951B730
        public void DoFinal(){} // RVA: 0x951B7E0
        public void Reset(){} // RVA: 0x951B980
        public void Ssl3Complete(){} // RVA: 0x951B9F0
    }

    public class CompressionMethod
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ConnectionEnd
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ContentType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

}