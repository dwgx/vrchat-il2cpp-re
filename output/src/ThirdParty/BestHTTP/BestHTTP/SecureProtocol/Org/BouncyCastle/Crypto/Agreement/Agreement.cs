// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Agreement
// Classes: 11
// Methods: 55

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Agreement
{
    public class DHAgreement : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.DHPrivateKeyParameters key; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.DHParameters dhParams; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger privateValue; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Security.SecureRandom random; // 0x28

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFACBC86390
        public void CalculateMessage(){} // RVA: 0x7FFACBC86780
        public void CalculateAgreement(){} // RVA: 0x7FFACBC86970
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class DHBasicAgreement : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.DHPrivateKeyParameters key; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.DHParameters dhParams; // 0x18

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFACBC86CF0
        public void GetFieldSize(){} // RVA: 0x7FFACBC86F60
        public void CalculateAgreement(){} // RVA: 0x7FFACBC86FA0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class DHStandardGroups : Object
    {
        public string rfc2409_768_p;
        public string rfc2409_768_g; // 0x8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.DHParameters rfc2409_768; // 0x10
        public string rfc2409_1024_p; // 0x18
        public string rfc2409_1024_g; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.DHParameters rfc2409_1024; // 0x28
        public string rfc3526_1536_p; // 0x30
        public string rfc3526_1536_g; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.DHParameters rfc3526_1536; // 0x40
        public string rfc3526_2048_p; // 0x48
        public string rfc3526_2048_g; // 0x50
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.DHParameters rfc3526_2048; // 0x58
        public string rfc3526_3072_p; // 0x60
        public string rfc3526_3072_g; // 0x68
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.DHParameters rfc3526_3072; // 0x70
        public string rfc3526_4096_p; // 0x78
        public string rfc3526_4096_g; // 0x80
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.DHParameters rfc3526_4096; // 0x88
        public string rfc3526_6144_p; // 0x90
        public string rfc3526_6144_g; // 0x98
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.DHParameters rfc3526_6144; // 0xA0
        public string rfc3526_8192_p; // 0xA8
        public string rfc3526_8192_g; // 0xB0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.DHParameters rfc3526_8192; // 0xB8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.DHParameters rfc4306_768; // 0xC0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.DHParameters rfc4306_1024; // 0xC8
        public string rfc5114_1024_160_p; // 0xD0
        public string rfc5114_1024_160_g; // 0xD8
        public string rfc5114_1024_160_q; // 0xE0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.DHParameters rfc5114_1024_160; // 0xE8
        public string rfc5114_2048_224_p; // 0xF0
        public string rfc5114_2048_224_g; // 0xF8
        public string rfc5114_2048_224_q; // 0x100
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.DHParameters rfc5114_2048_224; // 0x108
        public string rfc5114_2048_256_p; // 0x110
        public string rfc5114_2048_256_g; // 0x118
        public string rfc5114_2048_256_q; // 0x120
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.DHParameters rfc5114_2048_256; // 0x128
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.DHParameters rfc5996_768; // 0x130
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.DHParameters rfc5996_1024; // 0x138
        public string rfc7919_ffdhe2048_p; // 0x140
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.DHParameters rfc7919_ffdhe2048; // 0x148
        public string rfc7919_ffdhe3072_p; // 0x150
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.DHParameters rfc7919_ffdhe3072; // 0x158
        public string rfc7919_ffdhe4096_p; // 0x160
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.DHParameters rfc7919_ffdhe4096; // 0x168
        public string rfc7919_ffdhe6144_p; // 0x170
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.DHParameters rfc7919_ffdhe6144; // 0x178
        public string rfc7919_ffdhe8192_p; // 0x180
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.DHParameters rfc7919_ffdhe8192; // 0x188

        // ── Methods ──
        public void FromHex(){} // RVA: 0x7FFACBC872D0
        public void FromPG(){} // RVA: 0x7FFACBC87380
        public void FromPGQ(){} // RVA: 0x7FFACBC87430
        public void Rfc7919Parameters(){} // RVA: 0x7FFACBC87500
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBC87620
    }

    public class ECDHBasicAgreement : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters privKey; // 0x10

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFACBC89140
        public void GetFieldSize(){} // RVA: 0x7FFACBC892D0
        public void CalculateAgreement(){} // RVA: 0x7FFACBC89320
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ECDHCBasicAgreement : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters privKey; // 0x10

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFACBC89660
        public void GetFieldSize(){} // RVA: 0x7FFACBC892D0
        public void CalculateAgreement(){} // RVA: 0x7FFACBC897F0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ECDHWithKdfBasicAgreement : ECDHBasicAgreement
    {
        public string algorithm; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IDerivationFunction kdf; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBC89AA0
        public void CalculateAgreement(){} // RVA: 0x7FFACBC89C10
        public void BigIntToBytes(){} // RVA: 0x7FFACBC89E40
    }

    public class ECMqvBasicAgreement : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.MqvPrivateParameters privParams; // 0x10

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFACBC89EA0
        public void GetFieldSize(){} // RVA: 0x7FFACBC8A030
        public void CalculateAgreement(){} // RVA: 0x7FFACBC8A0A0
        public void CalculateMqvAgreement(){} // RVA: 0x7FFACBC8A370
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ECMqvWithKdfBasicAgreement : ECMqvBasicAgreement
    {
        public string algorithm; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IDerivationFunction kdf; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBC8A8C0
        public void CalculateAgreement(){} // RVA: 0x7FFACBC8AA30
        public void BigIntToBytes(){} // RVA: 0x7FFACBC8AC80
    }

    public class SM2KeyExchange : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IDigest mDigest; // 0x10
        public byte[] mUserID; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters mStaticKey; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECPoint mStaticPubPoint; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECPoint mEphemeralPubPoint; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.ECDomainParameters mECParams; // 0x38
        public int mW; // 0x40
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters mEphemeralKey; // 0x48
        public bool mInitiator; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x2
        public void Init(){} // RVA: 0x7FFACBC8ADA0
        public void CalculateKey(){} // RVA: 0x7FFACBC8B260
        public void CalculateKeyWithConfirmation(){} // RVA: 0x7FFACBC8B4C0
        public void CalculateU(){} // RVA: 0x7FFACBC8BA30
        public void Kdf(){} // RVA: 0x7FFACBC8BDA0
        public void Reduce(){} // RVA: 0x7FFACBC8C3B0
        public void S1(){} // RVA: 0x7FFACBC8C480
        public void CalculateInnerHash(){} // RVA: 0x7FFACBC8C650
        public void S2(){} // RVA: 0x7FFACBC8CA60
        public void GetZ(){} // RVA: 0x7FFACBC8CC30
        public void AddUserID(){} // RVA: 0x7FFACBC8D140
        public void AddFieldElement(){} // RVA: 0x7FFACBC8D200
    }

    public class X25519Agreement : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.X25519PrivateKeyParameters AgreementSize; // 0x10

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFACBC8D290
        public void get_AgreementSize(){} // RVA: 0x7FFACBC8D360
        public void CalculateAgreement(){} // RVA: 0x7FFACBC8D3C0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class X448Agreement : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.X448PrivateKeyParameters AgreementSize; // 0x10

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFACBC8D5E0
        public void get_AgreementSize(){} // RVA: 0x7FFACBC8D6B0
        public void CalculateAgreement(){} // RVA: 0x7FFACBC8D710
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

}