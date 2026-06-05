// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Agreement
// Classes: 11
// Methods: 55

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Agreement
{
    public class DHAgreement
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAFC12D5D0
        public void CalculateMessage(){} // RVA: 0x7FFAFC12D9C0
        public void CalculateAgreement(){} // RVA: 0x7FFAFC12DBB0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class DHBasicAgreement
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAFC12DF30
        public void GetFieldSize(){} // RVA: 0x7FFAFC12E1A0
        public void CalculateAgreement(){} // RVA: 0x7FFAFC12E1E0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class DHStandardGroups
    {
        // ── Methods ──
        public void FromHex(){} // RVA: 0x7FFAFC12E510
        public void FromPG(){} // RVA: 0x7FFAFC12E5C0
        public void FromPGQ(){} // RVA: 0x7FFAFC12E670
        public void Rfc7919Parameters(){} // RVA: 0x7FFAFC12E740
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAFC12E860
    }

    public class ECDHBasicAgreement
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAFC130380
        public void GetFieldSize(){} // RVA: 0x7FFAFC130510
        public void CalculateAgreement(){} // RVA: 0x7FFAFC130560
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class ECDHCBasicAgreement
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAFC1308A0
        public void GetFieldSize(){} // RVA: 0x7FFAFC130510
        public void CalculateAgreement(){} // RVA: 0x7FFAFC130A30
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class ECDHWithKdfBasicAgreement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC130CE0
        public void CalculateAgreement(){} // RVA: 0x7FFAFC130E50
        public void BigIntToBytes(){} // RVA: 0x7FFAFC131080
    }

    public class ECMqvBasicAgreement
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAFC1310E0
        public void GetFieldSize(){} // RVA: 0x7FFAFC131270
        public void CalculateAgreement(){} // RVA: 0x7FFAFC1312E0
        public void CalculateMqvAgreement(){} // RVA: 0x7FFAFC1315B0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class ECMqvWithKdfBasicAgreement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC131B00
        public void CalculateAgreement(){} // RVA: 0x7FFAFC131C70
        public void BigIntToBytes(){} // RVA: 0x7FFAFC131EC0
    }

    public class SM2KeyExchange
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30 | overloaded x2
        public void Init(){} // RVA: 0x7FFAFC131FE0
        public void CalculateKey(){} // RVA: 0x7FFAFC1324A0
        public void CalculateKeyWithConfirmation(){} // RVA: 0x7FFAFC132700
        public void CalculateU(){} // RVA: 0x7FFAFC132C70
        public void Kdf(){} // RVA: 0x7FFAFC132FE0
        public void Reduce(){} // RVA: 0x7FFAFC1335F0
        public void S1(){} // RVA: 0x7FFAFC1336C0
        public void CalculateInnerHash(){} // RVA: 0x7FFAFC133890
        public void S2(){} // RVA: 0x7FFAFC133CA0
        public void GetZ(){} // RVA: 0x7FFAFC133E70
        public void AddUserID(){} // RVA: 0x7FFAFC134380
        public void AddFieldElement(){} // RVA: 0x7FFAFC134440
    }

    public class X25519Agreement
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAFC1344D0
        public void get_AgreementSize(){} // RVA: 0x7FFAFC1345A0
        public void CalculateAgreement(){} // RVA: 0x7FFAFC134600
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class X448Agreement
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAFC134820
        public void get_AgreementSize(){} // RVA: 0x7FFAFC1348F0
        public void CalculateAgreement(){} // RVA: 0x7FFAFC134950
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

}