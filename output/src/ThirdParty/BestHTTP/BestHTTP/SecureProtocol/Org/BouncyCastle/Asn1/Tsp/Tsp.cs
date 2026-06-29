// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Tsp
// Classes: 5
// Methods: 38

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Tsp
{
    public class Accuracy : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1594DF0
        public void GetInstance(){} // RVA: 0x7B1595250
        public void get_Seconds(){} // RVA: 0x7A80F2570
        public void get_Millis(){} // RVA: 0x7A80DA7B0
        public void get_Micros(){} // RVA: 0x7A81052C0
        public void ToAsn1Object(){} // RVA: 0x7B1595410
    }

    public class MessageImprint : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B1595680
        public void .ctor(){} // RVA: 0x7A8CE4080
        public void get_HashAlgorithm(){} // RVA: 0x7A80F2570
        public void GetHashedMessage(){} // RVA: 0x7A80DA7B0
        public void ToAsn1Object(){} // RVA: 0x7B1595A00
    }

    public class TimeStampReq : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B1595BD0
        public void .ctor(){} // RVA: 0x7B15961F0
        public void get_Version(){} // RVA: 0x7A80F2570
        public void get_MessageImprint(){} // RVA: 0x7A80DA7B0
        public void get_ReqPolicy(){} // RVA: 0x7A81052C0
        public void get_Nonce(){} // RVA: 0x7A8105330
        public void get_CertReq(){} // RVA: 0x7A83F69F0
        public void get_Extensions(){} // RVA: 0x7A8292C30
        public void ToAsn1Object(){} // RVA: 0x7B1596460
    }

    public class TimeStampResp : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B1596770
        public void .ctor(){} // RVA: 0x7A8CE4080
        public void get_Status(){} // RVA: 0x7A80F2570
        public void get_TimeStampToken(){} // RVA: 0x7A80DA7B0
        public void ToAsn1Object(){} // RVA: 0x7B1596B90
    }

    public class TstInfo : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B1596DA0
        public void .ctor(){} // RVA: 0x7B1597770
        public void get_Version(){} // RVA: 0x7A80F2570
        public void get_MessageImprint(){} // RVA: 0x7A81052C0
        public void get_Policy(){} // RVA: 0x7A80DA7B0
        public void get_SerialNumber(){} // RVA: 0x7A8105330
        public void get_Accuracy(){} // RVA: 0x7A8292C30
        public void get_GenTime(){} // RVA: 0x7A83F69F0
        public void get_Ordering(){} // RVA: 0x7A8154D80
        public void get_Nonce(){} // RVA: 0x7A8152D80
        public void get_Tsa(){} // RVA: 0x7A8178B90
        public void get_Extensions(){} // RVA: 0x7A81A0050
        public void ToAsn1Object(){} // RVA: 0x7B1597B30
    }

}