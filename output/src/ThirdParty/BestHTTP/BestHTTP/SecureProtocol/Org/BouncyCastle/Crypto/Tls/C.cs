// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
// Classes: 18
// Methods: 76

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
    public class CertChainType : Object
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x7FFE89F78C20
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Certificate : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.Certificate EmptyChain;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509CertificateStructure[] mCertificateList; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F78C30
        public void GetCertificateList(){} // RVA: 0x7FFE8125C1C0
        public void GetCertificateAt(){} // RVA: 0x7FFE876177D0
        public void get_Length(){} // RVA: 0x7FFE81CCB610
        public void get_IsEmpty(){} // RVA: 0x7FFE89F78CE0
        public void Encode(){} // RVA: 0x7FFE89F78D00
        public void Parse(){} // RVA: 0x7FFE89F792A0
        public void CloneCertificateList(){} // RVA: 0x7FFE89F798C0
        public void .cctor(){} // RVA: 0x7FFE89F79940
    }

    public class CertificateRequest : Object
    {
        public byte[] mCertificateTypes; // 0x10
        public System.Collections.IList mSupportedSignatureAlgorithms; // 0x18
        public System.Collections.IList mCertificateAuthorities; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE811DAE00
        public void get_CertificateTypes(){} // RVA: 0x7FFE81116380
        public void get_SupportedSignatureAlgorithms(){} // RVA: 0x7FFE810FE7C0
        public void get_CertificateAuthorities(){} // RVA: 0x7FFE811290C0
        public void Encode(){} // RVA: 0x7FFE89F79AB0
        public void Parse(){} // RVA: 0x7FFE89F7A340
    }

    public class CertificateStatus : Object
    {
        public byte mStatusType; // 0x10
        public object mResponse; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F7A930
        public void get_StatusType(){} // RVA: 0x7FFE811C55E0
        public void get_Response(){} // RVA: 0x7FFE810FE7C0
        public void GetOcspResponse(){} // RVA: 0x7FFE89F7AA10
        public void Encode(){} // RVA: 0x7FFE89F7AB30
        public void Parse(){} // RVA: 0x7FFE89F7ACA0
        public void IsCorrectType(){} // RVA: 0x7FFE89F7AF00
    }

    public class CertificateStatusRequest : Object
    {
        public byte mStatusType; // 0x10
        public object mRequest; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F7B000
        public void get_StatusType(){} // RVA: 0x7FFE811C55E0
        public void get_Request(){} // RVA: 0x7FFE810FE7C0
        public void GetOcspStatusRequest(){} // RVA: 0x7FFE89F7B0E0
        public void Encode(){} // RVA: 0x7FFE89F7B200
        public void Parse(){} // RVA: 0x7FFE89F7B330
        public void IsCorrectType(){} // RVA: 0x7FFE89F7B520
    }

    public class CertificateStatusType : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class CertificateType : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class CertificateUrl : Object
    {
        public byte mType; // 0x10
        public System.Collections.IList mUrlAndHashList; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F7B620
        public void get_Type(){} // RVA: 0x7FFE811C55E0
        public void get_UrlAndHashList(){} // RVA: 0x7FFE810FE7C0
        public void Encode(){} // RVA: 0x7FFE89F7B760
        public void parse(){} // RVA: 0x7FFE89F7BBC0
    }

    public class Chacha20Poly1305 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F7C200
        public void GetPlaintextLimit(){} // RVA: 0x7FFE89F7C650
        public void EncodePlaintext(){} // RVA: 0x7FFE89F7C660
        public void DecodeCiphertext(){} // RVA: 0x7FFE89F7C7E0
        public void InitRecord(){} // RVA: 0x7FFE89F7CA80
        public void CalculateNonce(){} // RVA: 0x7FFE89F7CB90
        public void GenerateRecordMacKey(){} // RVA: 0x7FFE89F7CC70
        public void CalculateRecordMac(){} // RVA: 0x7FFE89F7CDA0
        public void UpdateRecordMacLength(){} // RVA: 0x7FFE89F7D0B0
        public void UpdateRecordMacText(){} // RVA: 0x7FFE89F7D180
        public void GetAdditionalData(){} // RVA: 0x7FFE89F7D280
        public void .cctor(){} // RVA: 0x7FFE89F7D3B0
    }

    public class ChangeCipherSpec : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class CipherSuite : Object
    {
        // ── Methods ──
        public void IsScsv(){} // RVA: 0x7FFE89F7D470
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class CipherType : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ClientAuthenticationType : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ClientCertificateType : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class CombinedHash : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsContext mContext; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F7D5B0 | overloaded x2
        public void Init(){} // RVA: 0x7FFE810FCE30
        public void NotifyPrfDetermined(){} // RVA: 0x7FFE827C4A80
        public void TrackHashAlgorithm(){} // RVA: 0x7FFE89F7D750
        public void SealHashAlgorithms(){} // RVA: 0x7FFE810FB310
        public void StopTracking(){} // RVA: 0x7FFE89F7D7A0
        public void ForkPrfHash(){} // RVA: 0x7FFE89F7D800
        public void GetFinalHash(){} // RVA: 0x7FFE89F7D860
        public void get_AlgorithmName(){} // RVA: 0x7FFE89F7D8B0
        public void GetByteLength(){} // RVA: 0x7FFE89F7D950
        public void GetDigestSize(){} // RVA: 0x7FFE89F7DA00
        public void Update(){} // RVA: 0x7FFE89F7DA80
        public void BlockUpdate(){} // RVA: 0x7FFE89F7DB00
        public void DoFinal(){} // RVA: 0x7FFE89F7DBB0
        public void Reset(){} // RVA: 0x7FFE89F7DD50
        public void Ssl3Complete(){} // RVA: 0x7FFE89F7DDC0
    }

    public class CompressionMethod : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ConnectionEnd : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ContentType : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

}