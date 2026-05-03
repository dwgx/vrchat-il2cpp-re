// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Agreement
// Classes: 11
// Methods: 55

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Agreement
{
    public class DHAgreement : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE8A0DF9B0
        public void CalculateMessage(){} // RVA: 0x7FFE8A0DFDA0
        public void CalculateAgreement(){} // RVA: 0x7FFE8A0DFF90
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class DHBasicAgreement : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE8A0E0310
        public void GetFieldSize(){} // RVA: 0x7FFE8A0E0580
        public void CalculateAgreement(){} // RVA: 0x7FFE8A0E05C0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class DHStandardGroups : Object
    {
        // ── Methods ──
        public void FromHex(){} // RVA: 0x7FFE8A0E08F0
        public void FromPG(){} // RVA: 0x7FFE8A0E09A0
        public void FromPGQ(){} // RVA: 0x7FFE8A0E0A50
        public void Rfc7919Parameters(){} // RVA: 0x7FFE8A0E0B20
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE8A0E0C40
    }

    public class ECDHBasicAgreement : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE8A0E2760
        public void GetFieldSize(){} // RVA: 0x7FFE8A0E28F0
        public void CalculateAgreement(){} // RVA: 0x7FFE8A0E2940
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ECDHCBasicAgreement : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE8A0E2C80
        public void GetFieldSize(){} // RVA: 0x7FFE8A0E28F0
        public void CalculateAgreement(){} // RVA: 0x7FFE8A0E2E10
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ECDHWithKdfBasicAgreement : ECDHBasicAgreement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A0E30C0
        public void CalculateAgreement(){} // RVA: 0x7FFE8A0E3230
        public void BigIntToBytes(){} // RVA: 0x7FFE8A0E3460
    }

    public class ECMqvBasicAgreement : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE8A0E34C0
        public void GetFieldSize(){} // RVA: 0x7FFE8A0E3650
        public void CalculateAgreement(){} // RVA: 0x7FFE8A0E36C0
        public void CalculateMqvAgreement(){} // RVA: 0x7FFE8A0E3990
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ECMqvWithKdfBasicAgreement : ECMqvBasicAgreement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A0E3EE0
        public void CalculateAgreement(){} // RVA: 0x7FFE8A0E4050
        public void BigIntToBytes(){} // RVA: 0x7FFE8A0E42A0
    }

    public class SM2KeyExchange : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x2
        public void Init(){} // RVA: 0x7FFE8A0E43C0
        public void CalculateKey(){} // RVA: 0x7FFE8A0E4880
        public void CalculateKeyWithConfirmation(){} // RVA: 0x7FFE8A0E4AE0
        public void CalculateU(){} // RVA: 0x7FFE8A0E5050
        public void Kdf(){} // RVA: 0x7FFE8A0E53C0
        public void Reduce(){} // RVA: 0x7FFE8A0E59D0
        public void S1(){} // RVA: 0x7FFE8A0E5AA0
        public void CalculateInnerHash(){} // RVA: 0x7FFE8A0E5C70
        public void S2(){} // RVA: 0x7FFE8A0E6080
        public void GetZ(){} // RVA: 0x7FFE8A0E6250
        public void AddUserID(){} // RVA: 0x7FFE8A0E6760
        public void AddFieldElement(){} // RVA: 0x7FFE8A0E6820
    }

    public class X25519Agreement : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.X25519PrivateKeyParameters privateKey; // 0x10

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE8A0E68B0
        public void get_AgreementSize(){} // RVA: 0x7FFE8A0E6980
        public void CalculateAgreement(){} // RVA: 0x7FFE8A0E69E0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class X448Agreement : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.X448PrivateKeyParameters privateKey; // 0x10

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE8A0E6C00
        public void get_AgreementSize(){} // RVA: 0x7FFE8A0E6CD0
        public void CalculateAgreement(){} // RVA: 0x7FFE8A0E6D30
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

}