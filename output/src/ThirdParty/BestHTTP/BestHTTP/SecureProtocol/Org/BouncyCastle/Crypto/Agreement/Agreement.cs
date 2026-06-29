// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Agreement
// Classes: 11
// Methods: 54

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Agreement
{
    public class DHAgreement : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7B14B6890
        public void CalculateMessage(){} // RVA: 0x7B14B6C80
        public void CalculateAgreement(){} // RVA: 0x7B14B6E80
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class DHBasicAgreement : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7B14B7200
        public void GetFieldSize(){} // RVA: 0x7B14B7470
        public void CalculateAgreement(){} // RVA: 0x7B14B74B0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class DHStandardGroups : Object
    {
        // ── Methods ──
        public void FromHex(){} // RVA: 0x7B14B77E0
        public void FromPG(){} // RVA: 0x7B14B7890
        public void FromPGQ(){} // RVA: 0x7B14B7940
        public void Rfc7919Parameters(){} // RVA: 0x7B14B7A10
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7B14B7B30
    }

    public class ECDHBasicAgreement : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7B14B9650
        public void GetFieldSize(){} // RVA: 0x7B14B97E0
        public void CalculateAgreement(){} // RVA: 0x7B14B9830
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class ECDHCBasicAgreement : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7B14B9B70
        public void GetFieldSize(){} // RVA: 0x7B14B97E0
        public void CalculateAgreement(){} // RVA: 0x7B14B9D00
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class ECDHWithKdfBasicAgreement : ECDHBasicAgreement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B14B9FB0
        public void CalculateAgreement(){} // RVA: 0x7B14BA120
        public void BigIntToBytes(){} // RVA: 0x7B14BA350
    }

    public class ECMqvBasicAgreement : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7B14BA3B0
        public void GetFieldSize(){} // RVA: 0x7B14BA540
        public void CalculateAgreement(){} // RVA: 0x7B14BA5B0
        public void CalculateMqvAgreement(){} // RVA: 0x7B14BA880
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class ECMqvWithKdfBasicAgreement : ECMqvBasicAgreement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B14BADD0
        public void CalculateAgreement(){} // RVA: 0x7B14BAF40
        public void BigIntToBytes(){} // RVA: 0x7B14BB190
    }

    public class SM2KeyExchange : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void Init(){} // RVA: 0x7B14BB2B0
        public void CalculateKey(){} // RVA: 0x7B14BB770
        public void CalculateKeyWithConfirmation(){} // RVA: 0x7B14BB9C0
        public void CalculateU(){} // RVA: 0x7B14BBF20
        public void Kdf(){} // RVA: 0x7B14BC290
        public void Reduce(){} // RVA: 0x7B14BC8B0
        public void S1(){} // RVA: 0x7B14BC980
        public void CalculateInnerHash(){} // RVA: 0x7B14BCB50
        public void S2(){} // RVA: 0x7B14BCF60
        public void GetZ(){} // RVA: 0x7B14BD130
        public void AddUserID(){} // RVA: 0x7B14BD640
        public void AddFieldElement(){} // RVA: 0x7B14BD700
    }

    public class X25519Agreement : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7B14BD790
        public void get_AgreementSize(){} // RVA: 0x7B14BD860
        public void CalculateAgreement(){} // RVA: 0x7B14BD8C0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class X448Agreement : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7B14BDAD0
        public void get_AgreementSize(){} // RVA: 0x7B14BDBA0
        public void CalculateAgreement(){} // RVA: 0x7B14BDC00
        public void .ctor(){} // RVA: 0x7A80D7310
    }

}