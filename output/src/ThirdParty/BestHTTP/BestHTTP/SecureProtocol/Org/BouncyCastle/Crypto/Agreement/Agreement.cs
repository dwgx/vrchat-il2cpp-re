// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Agreement
// Classes: 11
// Methods: 55

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Agreement
{
    public class DHAgreement
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x967D5D0
        public void CalculateMessage(){} // RVA: 0x967D9C0
        public void CalculateAgreement(){} // RVA: 0x967DBB0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class DHBasicAgreement
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x967DF30
        public void GetFieldSize(){} // RVA: 0x967E1A0
        public void CalculateAgreement(){} // RVA: 0x967E1E0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class DHStandardGroups
    {
        // ── Methods ──
        public void FromHex(){} // RVA: 0x967E510
        public void FromPG(){} // RVA: 0x967E5C0
        public void FromPGQ(){} // RVA: 0x967E670
        public void Rfc7919Parameters(){} // RVA: 0x967E740
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x967E860
    }

    public class ECDHBasicAgreement
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x9680380
        public void GetFieldSize(){} // RVA: 0x9680510
        public void CalculateAgreement(){} // RVA: 0x9680560
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ECDHCBasicAgreement
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x96808A0
        public void GetFieldSize(){} // RVA: 0x9680510
        public void CalculateAgreement(){} // RVA: 0x9680A30
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ECDHWithKdfBasicAgreement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9680CE0
        public void CalculateAgreement(){} // RVA: 0x9680E50
        public void BigIntToBytes(){} // RVA: 0x9681080
    }

    public class ECMqvBasicAgreement
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x96810E0
        public void GetFieldSize(){} // RVA: 0x9681270
        public void CalculateAgreement(){} // RVA: 0x96812E0
        public void CalculateMqvAgreement(){} // RVA: 0x96815B0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ECMqvWithKdfBasicAgreement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9681B00
        public void CalculateAgreement(){} // RVA: 0x9681C70
        public void BigIntToBytes(){} // RVA: 0x9681EC0
    }

    public class SM2KeyExchange
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30 | overloaded x2
        public void Init(){} // RVA: 0x9681FE0
        public void CalculateKey(){} // RVA: 0x96824A0
        public void CalculateKeyWithConfirmation(){} // RVA: 0x9682700
        public void CalculateU(){} // RVA: 0x9682C70
        public void Kdf(){} // RVA: 0x9682FE0
        public void Reduce(){} // RVA: 0x96835F0
        public void S1(){} // RVA: 0x96836C0
        public void CalculateInnerHash(){} // RVA: 0x9683890
        public void S2(){} // RVA: 0x9683CA0
        public void GetZ(){} // RVA: 0x9683E70
        public void AddUserID(){} // RVA: 0x9684380
        public void AddFieldElement(){} // RVA: 0x9684440
    }

    public class X25519Agreement
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.X25519PrivateKeyParameters privateKey; // 0x10

        // ── Methods ──
        public void Init(){} // RVA: 0x96844D0
        public void get_AgreementSize(){} // RVA: 0x96845A0
        public void CalculateAgreement(){} // RVA: 0x9684600
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class X448Agreement
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.X448PrivateKeyParameters privateKey; // 0x10

        // ── Methods ──
        public void Init(){} // RVA: 0x9684820
        public void get_AgreementSize(){} // RVA: 0x96848F0
        public void CalculateAgreement(){} // RVA: 0x9684950
        public void .ctor(){} // RVA: 0x2DD310
    }

}