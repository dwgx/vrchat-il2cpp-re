// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Tsp
// Classes: 5
// Methods: 43

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Tsp
{
    public class Accuracy
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x975AF10 | overloaded x2
        public void GetInstance(){} // RVA: 0x975B370
        public void get_Seconds(){} // RVA: 0x2F8380
        public void get_Millis(){} // RVA: 0x2E07C0
        public void get_Micros(){} // RVA: 0x30B0C0
        public void ToAsn1Object(){} // RVA: 0x975B530
    }

    public class MessageImprint
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x975B7A0
        public void .ctor(){} // RVA: 0xF19AE0 | overloaded x2
        public void get_HashAlgorithm(){} // RVA: 0x2F8380
        public void GetHashedMessage(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x975BB20
    }

    public class TimeStampReq
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x975BCF0
        public void .ctor(){} // RVA: 0x975C310 | overloaded x2
        public void get_Version(){} // RVA: 0x2F8380
        public void get_MessageImprint(){} // RVA: 0x2E07C0
        public void get_ReqPolicy(){} // RVA: 0x30B0C0
        public void get_Nonce(){} // RVA: 0x30B130
        public void get_CertReq(){} // RVA: 0x6374D0
        public void get_Extensions(){} // RVA: 0x4976A0
        public void ToAsn1Object(){} // RVA: 0x975C570
    }

    public class TimeStampResp
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x975C870
        public void .ctor(){} // RVA: 0xF19AE0 | overloaded x2
        public void get_Status(){} // RVA: 0x2F8380
        public void get_TimeStampToken(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x975CC80
    }

    public class TstInfo
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x975CE80
        public void .ctor(){} // RVA: 0x975D850 | overloaded x2
        public void get_Version(){} // RVA: 0x2F8380
        public void get_MessageImprint(){} // RVA: 0x30B0C0
        public void get_Policy(){} // RVA: 0x2E07C0
        public void get_SerialNumber(){} // RVA: 0x30B130
        public void get_Accuracy(){} // RVA: 0x4976A0
        public void get_GenTime(){} // RVA: 0x6374D0
        public void get_Ordering(){} // RVA: 0x35A740
        public void get_Nonce(){} // RVA: 0x358730
        public void get_Tsa(){} // RVA: 0x37E0E0
        public void get_Extensions(){} // RVA: 0x3A5500
        public void ToAsn1Object(){} // RVA: 0x975DC10
    }

}