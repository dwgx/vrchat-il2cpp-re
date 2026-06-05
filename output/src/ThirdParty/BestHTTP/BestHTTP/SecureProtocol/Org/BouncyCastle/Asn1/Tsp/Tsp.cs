// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Tsp
// Classes: 5
// Methods: 43

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Tsp
{
    public class Accuracy
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC20AF10 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFAFC20B370
        public void get_Seconds(){} // RVA: 0x7FFAF2DA8380
        public void get_Millis(){} // RVA: 0x7FFAF2D907C0
        public void get_Micros(){} // RVA: 0x7FFAF2DBB0C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC20B530
    }

    public class MessageImprint
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC20B7A0
        public void .ctor(){} // RVA: 0x7FFAF39C9AE0 | overloaded x2
        public void get_HashAlgorithm(){} // RVA: 0x7FFAF2DA8380
        public void GetHashedMessage(){} // RVA: 0x7FFAF2D907C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC20BB20
    }

    public class TimeStampReq
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC20BCF0
        public void .ctor(){} // RVA: 0x7FFAFC20C310 | overloaded x2
        public void get_Version(){} // RVA: 0x7FFAF2DA8380
        public void get_MessageImprint(){} // RVA: 0x7FFAF2D907C0
        public void get_ReqPolicy(){} // RVA: 0x7FFAF2DBB0C0
        public void get_Nonce(){} // RVA: 0x7FFAF2DBB130
        public void get_CertReq(){} // RVA: 0x7FFAF30E74D0
        public void get_Extensions(){} // RVA: 0x7FFAF2F476A0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC20C570
    }

    public class TimeStampResp
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC20C870
        public void .ctor(){} // RVA: 0x7FFAF39C9AE0 | overloaded x2
        public void get_Status(){} // RVA: 0x7FFAF2DA8380
        public void get_TimeStampToken(){} // RVA: 0x7FFAF2D907C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC20CC80
    }

    public class TstInfo
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC20CE80
        public void .ctor(){} // RVA: 0x7FFAFC20D850 | overloaded x2
        public void get_Version(){} // RVA: 0x7FFAF2DA8380
        public void get_MessageImprint(){} // RVA: 0x7FFAF2DBB0C0
        public void get_Policy(){} // RVA: 0x7FFAF2D907C0
        public void get_SerialNumber(){} // RVA: 0x7FFAF2DBB130
        public void get_Accuracy(){} // RVA: 0x7FFAF2F476A0
        public void get_GenTime(){} // RVA: 0x7FFAF30E74D0
        public void get_Ordering(){} // RVA: 0x7FFAF2E0A740
        public void get_Nonce(){} // RVA: 0x7FFAF2E08730
        public void get_Tsa(){} // RVA: 0x7FFAF2E2E0E0
        public void get_Extensions(){} // RVA: 0x7FFAF2E55500
        public void ToAsn1Object(){} // RVA: 0x7FFAFC20DC10
    }

}