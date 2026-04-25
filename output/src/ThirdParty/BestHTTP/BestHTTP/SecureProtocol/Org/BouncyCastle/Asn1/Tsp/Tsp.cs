// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Tsp
// Classes: 5
// Methods: 43

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Tsp
{
    public class Accuracy : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger Seconds; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger Millis; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger Micros; // 0x20
        public int MinMillis;
        public int MaxMillis;
        public int MinMicros;
        public int MaxMicros;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBD63CF0 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFACBD64150
        public void get_Seconds(){} // RVA: 0x7FFAC2F3C380
        public void get_Millis(){} // RVA: 0x7FFAC2F247C0
        public void get_Micros(){} // RVA: 0x7FFAC2F4F0C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBD64310
    }

    public class MessageImprint : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier HashAlgorithm; // 0x10
        public byte[] hashedMessage; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD64580
        public void .ctor(){} // RVA: 0x7FFAC34EC240 | overloaded x2
        public void get_HashAlgorithm(){} // RVA: 0x7FFAC2F3C380
        public void GetHashedMessage(){} // RVA: 0x7FFAC2F247C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBD64900
    }

    public class TimeStampReq : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger Version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Tsp.MessageImprint MessageImprint; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier ReqPolicy; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger Nonce; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerBoolean CertReq; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Extensions Extensions; // 0x38

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD64AD0
        public void .ctor(){} // RVA: 0x7FFACBD650F0 | overloaded x2
        public void get_Version(){} // RVA: 0x7FFAC2F3C380
        public void get_MessageImprint(){} // RVA: 0x7FFAC2F247C0
        public void get_ReqPolicy(){} // RVA: 0x7FFAC2F4F0C0
        public void get_Nonce(){} // RVA: 0x7FFAC2F4F130
        public void get_CertReq(){} // RVA: 0x7FFAC31D95E0
        public void get_Extensions(){} // RVA: 0x7FFAC31D0140
        public void ToAsn1Object(){} // RVA: 0x7FFACBD65350
    }

    public class TimeStampResp : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cmp.PkiStatusInfo Status; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.ContentInfo TimeStampToken; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD65650
        public void .ctor(){} // RVA: 0x7FFAC34EC240 | overloaded x2
        public void get_Status(){} // RVA: 0x7FFAC2F3C380
        public void get_TimeStampToken(){} // RVA: 0x7FFAC2F247C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBD65A60
    }

    public class TstInfo : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger Version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier MessageImprint; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Tsp.MessageImprint Policy; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger SerialNumber; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerGeneralizedTime Accuracy; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Tsp.Accuracy GenTime; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerBoolean Ordering; // 0x40
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger Nonce; // 0x48
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.GeneralName Tsa; // 0x50
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Extensions Extensions; // 0x58

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD65C60
        public void .ctor(){} // RVA: 0x7FFACBD66630 | overloaded x2
        public void get_Version(){} // RVA: 0x7FFAC2F3C380
        public void get_MessageImprint(){} // RVA: 0x7FFAC2F4F0C0
        public void get_Policy(){} // RVA: 0x7FFAC2F247C0
        public void get_SerialNumber(){} // RVA: 0x7FFAC2F4F130
        public void get_Accuracy(){} // RVA: 0x7FFAC31D0140
        public void get_GenTime(){} // RVA: 0x7FFAC31D95E0
        public void get_Ordering(){} // RVA: 0x7FFAC2F9E740
        public void get_Nonce(){} // RVA: 0x7FFAC2F9C730
        public void get_Tsa(){} // RVA: 0x7FFAC2FC20E0
        public void get_Extensions(){} // RVA: 0x7FFAC2FE9500
        public void ToAsn1Object(){} // RVA: 0x7FFACBD669F0
    }

}