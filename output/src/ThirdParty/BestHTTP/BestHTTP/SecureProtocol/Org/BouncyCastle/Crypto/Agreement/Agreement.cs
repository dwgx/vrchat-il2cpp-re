// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Agreement
// Classes: 11
// Methods: 54

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Agreement
{
    public class DHAgreement : Object
    {
        public object key;
        public object dhParams;
        public object privateValue;
        public object random;

        // ── Methods ──
        public void Init(){} // RVA: 0xA321D10
        public void CalculateMessage(){} // RVA: 0xA322100
        public void CalculateAgreement(){} // RVA: 0xA322300
        public void .ctor(){} // RVA: 0xB43310
    }

    public class DHBasicAgreement : Object
    {
        public object key;
        public object dhParams;

        // ── Methods ──
        public void Init(){} // RVA: 0xA322680
        public void GetFieldSize(){} // RVA: 0xA3228F0
        public void CalculateAgreement(){} // RVA: 0xA322930
        public void .ctor(){} // RVA: 0xB43310
    }

    public class DHStandardGroups : Object
    {
        public object rfc2409_768_p;
        public object rfc2409_768_g;
        public object rfc2409_768;
        public object rfc2409_1024_p;
        public object rfc2409_1024_g;
        public object rfc2409_1024;
        public object rfc3526_1536_p;
        public object rfc3526_1536_g;
        public object rfc3526_1536;
        public object rfc3526_2048_p;
        public object rfc3526_2048_g;
        public object rfc3526_2048;
        public object rfc3526_3072_p;
        public object rfc3526_3072_g;
        public object rfc3526_3072;
        public object rfc3526_4096_p;
        public object rfc3526_4096_g;
        public object rfc3526_4096;
        public object rfc3526_6144_p;
        public object rfc3526_6144_g;
        public object rfc3526_6144;
        public object rfc3526_8192_p;
        public object rfc3526_8192_g;
        public object rfc3526_8192;
        public object rfc4306_768;
        public object rfc4306_1024;
        public object rfc5114_1024_160_p;
        public object rfc5114_1024_160_g;
        public object rfc5114_1024_160_q;
        public object rfc5114_1024_160;
        public object rfc5114_2048_224_p;
        public object rfc5114_2048_224_g;
        public object rfc5114_2048_224_q;
        public object rfc5114_2048_224;
        public object rfc5114_2048_256_p;
        public object rfc5114_2048_256_g;
        public object rfc5114_2048_256_q;
        public object rfc5114_2048_256;
        public object rfc5996_768;
        public object rfc5996_1024;
        public object rfc7919_ffdhe2048_p;
        public object rfc7919_ffdhe2048;
        public object rfc7919_ffdhe3072_p;
        public object rfc7919_ffdhe3072;
        public object rfc7919_ffdhe4096_p;
        public object rfc7919_ffdhe4096;
        public object rfc7919_ffdhe6144_p;
        public object rfc7919_ffdhe6144;
        public object rfc7919_ffdhe8192_p;
        public object rfc7919_ffdhe8192;

        // ── Methods ──
        public void FromHex(){} // RVA: 0xA322C60
        public void FromPG(){} // RVA: 0xA322D10
        public void FromPGQ(){} // RVA: 0xA322DC0
        public void Rfc7919Parameters(){} // RVA: 0xA322E90
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA322FB0
    }

    public class ECDHBasicAgreement : Object
    {
        public object privKey;

        // ── Methods ──
        public void Init(){} // RVA: 0xA324AD0
        public void GetFieldSize(){} // RVA: 0xA324C60
        public void CalculateAgreement(){} // RVA: 0xA324CB0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ECDHCBasicAgreement : Object
    {
        public object privKey;

        // ── Methods ──
        public void Init(){} // RVA: 0xA324FF0
        public void GetFieldSize(){} // RVA: 0xA324C60
        public void CalculateAgreement(){} // RVA: 0xA325180
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ECDHWithKdfBasicAgreement : ECDHBasicAgreement
    {
        public object algorithm;
        public object kdf;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA325430
        public void CalculateAgreement(){} // RVA: 0xA3255A0
        public void BigIntToBytes(){} // RVA: 0xA3257D0
    }

    public class ECMqvBasicAgreement : Object
    {
        public object privParams;

        // ── Methods ──
        public void Init(){} // RVA: 0xA325830
        public void GetFieldSize(){} // RVA: 0xA3259C0
        public void CalculateAgreement(){} // RVA: 0xA325A30
        public void CalculateMqvAgreement(){} // RVA: 0xA325D00
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ECMqvWithKdfBasicAgreement : ECMqvBasicAgreement
    {
        public object algorithm;
        public object kdf;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA326250
        public void CalculateAgreement(){} // RVA: 0xA3263C0
        public void BigIntToBytes(){} // RVA: 0xA326610
    }

    public class SM2KeyExchange : Object
    {
        public object mDigest;
        public object mUserID;
        public object mStaticKey;
        public object mStaticPubPoint;
        public object mEphemeralPubPoint;
        public object mECParams;
        public object mW;
        public object mEphemeralKey;
        public object mInitiator;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void Init(){} // RVA: 0xA326730
        public void CalculateKey(){} // RVA: 0xA326BF0
        public void CalculateKeyWithConfirmation(){} // RVA: 0xA326E40
        public void CalculateU(){} // RVA: 0xA3273A0
        public void Kdf(){} // RVA: 0xA327710
        public void Reduce(){} // RVA: 0xA327D30
        public void S1(){} // RVA: 0xA327E00
        public void CalculateInnerHash(){} // RVA: 0xA327FD0
        public void S2(){} // RVA: 0xA3283E0
        public void GetZ(){} // RVA: 0xA3285B0
        public void AddUserID(){} // RVA: 0xA328AC0
        public void AddFieldElement(){} // RVA: 0xA328B80
    }

    public class X25519Agreement : Object
    {
        public object privateKey;

        // ── Methods ──
        public void Init(){} // RVA: 0xA328C10
        public void get_AgreementSize(){} // RVA: 0xA328CE0
        public void CalculateAgreement(){} // RVA: 0xA328D40
        public void .ctor(){} // RVA: 0xB43310
    }

    public class X448Agreement : Object
    {
        public object privateKey;

        // ── Methods ──
        public void Init(){} // RVA: 0xA328F50
        public void get_AgreementSize(){} // RVA: 0xA329020
        public void CalculateAgreement(){} // RVA: 0xA329080
        public void .ctor(){} // RVA: 0xB43310
    }

}