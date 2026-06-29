// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Tsp
// Classes: 5
// Methods: 38

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Tsp
{
    public class Accuracy : Asn1Encodable
    {
        public object seconds;
        public object millis;
        public object micros;
        public object MinMillis;
        public object MaxMillis;
        public object MinMicros;
        public object MaxMicros;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA4003C0
        public void GetInstance(){} // RVA: 0xA400820
        public void get_Seconds(){} // RVA: 0xB5DBF0
        public void get_Millis(){} // RVA: 0xB465B0
        public void get_Micros(){} // RVA: 0xB700F0
        public void ToAsn1Object(){} // RVA: 0xA4009E0
    }

    public class MessageImprint : Asn1Encodable
    {
        public object hashAlgorithm;
        public object hashedMessage;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA400C50
        public void .ctor(){} // RVA: 0x17C92C0
        public void get_HashAlgorithm(){} // RVA: 0xB5DBF0
        public void GetHashedMessage(){} // RVA: 0xB465B0
        public void ToAsn1Object(){} // RVA: 0xA400FD0
    }

    public class TimeStampReq : Asn1Encodable
    {
        public object version;
        public object messageImprint;
        public object tsaPolicy;
        public object nonce;
        public object certReq;
        public object extensions;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA4011A0
        public void .ctor(){} // RVA: 0xA4017C0
        public void get_Version(){} // RVA: 0xB5DBF0
        public void get_MessageImprint(){} // RVA: 0xB465B0
        public void get_ReqPolicy(){} // RVA: 0xB700F0
        public void get_Nonce(){} // RVA: 0xB70160
        public void get_CertReq(){} // RVA: 0xD33E60
        public void get_Extensions(){} // RVA: 0xD05CA0
        public void ToAsn1Object(){} // RVA: 0xA401A30
    }

    public class TimeStampResp : Asn1Encodable
    {
        public object pkiStatusInfo;
        public object timeStampToken;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA401D40
        public void .ctor(){} // RVA: 0x17C92C0
        public void get_Status(){} // RVA: 0xB5DBF0
        public void get_TimeStampToken(){} // RVA: 0xB465B0
        public void ToAsn1Object(){} // RVA: 0xA402160
    }

    public class TstInfo : Asn1Encodable
    {
        public object version;
        public object tsaPolicyId;
        public object messageImprint;
        public object serialNumber;
        public object genTime;
        public object accuracy;
        public object ordering;
        public object nonce;
        public object tsa;
        public object extensions;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA402370
        public void .ctor(){} // RVA: 0xA402D40
        public void get_Version(){} // RVA: 0xB5DBF0
        public void get_MessageImprint(){} // RVA: 0xB700F0
        public void get_Policy(){} // RVA: 0xB465B0
        public void get_SerialNumber(){} // RVA: 0xB70160
        public void get_Accuracy(){} // RVA: 0xD05CA0
        public void get_GenTime(){} // RVA: 0xD33E60
        public void get_Ordering(){} // RVA: 0xBC1B30
        public void get_Nonce(){} // RVA: 0xBBF8F0
        public void get_Tsa(){} // RVA: 0xBE58B0
        public void get_Extensions(){} // RVA: 0xC0FFC0
        public void ToAsn1Object(){} // RVA: 0xA403100
    }

}