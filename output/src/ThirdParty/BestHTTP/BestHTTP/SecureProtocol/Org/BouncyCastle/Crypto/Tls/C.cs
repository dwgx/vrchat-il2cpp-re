// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
// Classes: 18
// Methods: 76

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
    public class CertChainType
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x7FFAFBFC6850
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class Certificate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBFC6860
        public void GetCertificateList(){} // RVA: 0x7FFAF2EEE1C0
        public void GetCertificateAt(){} // RVA: 0x7FFAF95884E0
        public void get_Length(){} // RVA: 0x7FFAF39EF910
        public void get_IsEmpty(){} // RVA: 0x7FFAFBFC6910
        public void Encode(){} // RVA: 0x7FFAFBFC6930
        public void Parse(){} // RVA: 0x7FFAFBFC6ED0
        public void CloneCertificateList(){} // RVA: 0x7FFAFBFC74F0
        public void .cctor(){} // RVA: 0x7FFAFBFC7570
    }

    public class CertificateRequest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2E6CE00
        public void get_CertificateTypes(){} // RVA: 0x7FFAF2DA8380
        public void get_SupportedSignatureAlgorithms(){} // RVA: 0x7FFAF2D907C0
        public void get_CertificateAuthorities(){} // RVA: 0x7FFAF2DBB0C0
        public void Encode(){} // RVA: 0x7FFAFBFC76E0
        public void Parse(){} // RVA: 0x7FFAFBFC7F70
    }

    public class CertificateStatus
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBFC8560
        public void get_StatusType(){} // RVA: 0x7FFAF2E575E0
        public void get_Response(){} // RVA: 0x7FFAF2D907C0
        public void GetOcspResponse(){} // RVA: 0x7FFAFBFC8640
        public void Encode(){} // RVA: 0x7FFAFBFC8760
        public void Parse(){} // RVA: 0x7FFAFBFC88D0
        public void IsCorrectType(){} // RVA: 0x7FFAFBFC8B30
    }

    public class CertificateStatusRequest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBFC8C30
        public void get_StatusType(){} // RVA: 0x7FFAF2E575E0
        public void get_Request(){} // RVA: 0x7FFAF2D907C0
        public void GetOcspStatusRequest(){} // RVA: 0x7FFAFBFC8D10
        public void Encode(){} // RVA: 0x7FFAFBFC8E30
        public void Parse(){} // RVA: 0x7FFAFBFC8F60
        public void IsCorrectType(){} // RVA: 0x7FFAFBFC9150
    }

    public class CertificateStatusType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class CertificateType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class CertificateUrl
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBFC9250
        public void get_Type(){} // RVA: 0x7FFAF2E575E0
        public void get_UrlAndHashList(){} // RVA: 0x7FFAF2D907C0
        public void Encode(){} // RVA: 0x7FFAFBFC9390
        public void parse(){} // RVA: 0x7FFAFBFC97F0
    }

    public class Chacha20Poly1305
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBFC9E30
        public void GetPlaintextLimit(){} // RVA: 0x7FFAFBFCA280
        public void EncodePlaintext(){} // RVA: 0x7FFAFBFCA290
        public void DecodeCiphertext(){} // RVA: 0x7FFAFBFCA410
        public void InitRecord(){} // RVA: 0x7FFAFBFCA6B0
        public void CalculateNonce(){} // RVA: 0x7FFAFBFCA7C0
        public void GenerateRecordMacKey(){} // RVA: 0x7FFAFBFCA8A0
        public void CalculateRecordMac(){} // RVA: 0x7FFAFBFCA9D0
        public void UpdateRecordMacLength(){} // RVA: 0x7FFAFBFCACE0
        public void UpdateRecordMacText(){} // RVA: 0x7FFAFBFCADB0
        public void GetAdditionalData(){} // RVA: 0x7FFAFBFCAEB0
        public void .cctor(){} // RVA: 0x7FFAFBFCAFE0
    }

    public class ChangeCipherSpec
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class CipherSuite
    {
        // ── Methods ──
        public void IsScsv(){} // RVA: 0x7FFAFBFCB0A0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class CipherType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class ClientAuthenticationType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class ClientCertificateType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class CombinedHash
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBFCB1E0 | overloaded x2
        public void Init(){} // RVA: 0x7FFAF2D8EE30
        public void NotifyPrfDetermined(){} // RVA: 0x7FFAF44EF520
        public void TrackHashAlgorithm(){} // RVA: 0x7FFAFBFCB380
        public void SealHashAlgorithms(){} // RVA: 0x7FFAF2D8D310
        public void StopTracking(){} // RVA: 0x7FFAFBFCB3D0
        public void ForkPrfHash(){} // RVA: 0x7FFAFBFCB430
        public void GetFinalHash(){} // RVA: 0x7FFAFBFCB490
        public void get_AlgorithmName(){} // RVA: 0x7FFAFBFCB4E0
        public void GetByteLength(){} // RVA: 0x7FFAFBFCB580
        public void GetDigestSize(){} // RVA: 0x7FFAFBFCB630
        public void Update(){} // RVA: 0x7FFAFBFCB6B0
        public void BlockUpdate(){} // RVA: 0x7FFAFBFCB730
        public void DoFinal(){} // RVA: 0x7FFAFBFCB7E0
        public void Reset(){} // RVA: 0x7FFAFBFCB980
        public void Ssl3Complete(){} // RVA: 0x7FFAFBFCB9F0
    }

    public class CompressionMethod
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class ConnectionEnd
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class ContentType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

}