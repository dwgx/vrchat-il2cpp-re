// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Tsp
// Classes: 5
// Methods: 43

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Tsp
{
    public class Accuracy : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger seconds; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger millis; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger micros; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A1BD310 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFE8A1BD770
        public void get_Seconds(){} // RVA: 0x7FFE81116380
        public void get_Millis(){} // RVA: 0x7FFE810FE7C0
        public void get_Micros(){} // RVA: 0x7FFE811290C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1BD930
    }

    public class MessageImprint : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier hashAlgorithm; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A1BDBA0
        public void .ctor(){} // RVA: 0x7FFE81CA56D0 | overloaded x2
        public void get_HashAlgorithm(){} // RVA: 0x7FFE81116380
        public void GetHashedMessage(){} // RVA: 0x7FFE810FE7C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1BDF20
    }

    public class TimeStampReq : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Tsp.MessageImprint messageImprint; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier tsaPolicy; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger nonce; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerBoolean certReq; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Extensions extensions; // 0x38

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A1BE0F0
        public void .ctor(){} // RVA: 0x7FFE8A1BE710 | overloaded x2
        public void get_Version(){} // RVA: 0x7FFE81116380
        public void get_MessageImprint(){} // RVA: 0x7FFE810FE7C0
        public void get_ReqPolicy(){} // RVA: 0x7FFE811290C0
        public void get_Nonce(){} // RVA: 0x7FFE81129130
        public void get_CertReq(){} // RVA: 0x7FFE8144E200
        public void get_Extensions(){} // RVA: 0x7FFE8143BA80
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1BE970
    }

    public class TimeStampResp : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cmp.PkiStatusInfo pkiStatusInfo; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.ContentInfo timeStampToken; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A1BEC70
        public void .ctor(){} // RVA: 0x7FFE81CA56D0 | overloaded x2
        public void get_Status(){} // RVA: 0x7FFE81116380
        public void get_TimeStampToken(){} // RVA: 0x7FFE810FE7C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1BF080
    }

    public class TstInfo : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier tsaPolicyId; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Tsp.MessageImprint messageImprint; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger serialNumber; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerGeneralizedTime genTime; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Tsp.Accuracy accuracy; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerBoolean ordering; // 0x40
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger nonce; // 0x48
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.GeneralName tsa; // 0x50
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Extensions extensions; // 0x58

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A1BF280
        public void .ctor(){} // RVA: 0x7FFE8A1BFC50 | overloaded x2
        public void get_Version(){} // RVA: 0x7FFE81116380
        public void get_MessageImprint(){} // RVA: 0x7FFE811290C0
        public void get_Policy(){} // RVA: 0x7FFE810FE7C0
        public void get_SerialNumber(){} // RVA: 0x7FFE81129130
        public void get_Accuracy(){} // RVA: 0x7FFE8143BA80
        public void get_GenTime(){} // RVA: 0x7FFE8144E200
        public void get_Ordering(){} // RVA: 0x7FFE81178740
        public void get_Nonce(){} // RVA: 0x7FFE81176730
        public void get_Tsa(){} // RVA: 0x7FFE8119C0E0
        public void get_Extensions(){} // RVA: 0x7FFE811C3500
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1C0010
    }

}