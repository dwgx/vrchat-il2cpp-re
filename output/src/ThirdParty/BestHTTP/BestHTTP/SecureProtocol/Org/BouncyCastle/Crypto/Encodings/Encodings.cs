// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Encodings
// Classes: 3
// Methods: 43

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Encodings
{
    public class ISO9796d1Encoding : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger AlgorithmName;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Six; // 0x8
        public byte[] shadows; // 0x10
        public byte[] inverse; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IAsymmetricBlockCipher engine; // 0x10
        public bool forEncryption; // 0x18
        public int bitSize; // 0x1C
        public int padBits; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger modulus; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC49730
        public void GetUnderlyingCipher(){} // RVA: 0x7FFAC2F3C380
        public void Init(){} // RVA: 0x7FFACBC497A0
        public void GetInputBlockSize(){} // RVA: 0x7FFACBC499A0
        public void GetOutputBlockSize(){} // RVA: 0x7FFACBC49A00
        public void SetPadBits(){} // RVA: 0x7FFACBC49A60
        public void GetPadBits(){} // RVA: 0x7FFAC30DBBE0
        public void ProcessBlock(){} // RVA: 0x7FFACBC49AD0
        public void EncodeBlock(){} // RVA: 0x7FFACBC49B00
        public void DecodeBlock(){} // RVA: 0x7FFACBC49E00
        public void .cctor(){} // RVA: 0x7FFACBC4A400
    }

    public class OaepEncoding : Object
    {
        public byte[] AlgorithmName; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IDigest mgf1Hash; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IAsymmetricBlockCipher engine; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Security.SecureRandom random; // 0x28
        public bool forEncryption; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBC4A770 | overloaded x4
        public void GetUnderlyingCipher(){} // RVA: 0x7FFAC2F4F0C0
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC4A960
        public void Init(){} // RVA: 0x7FFACBC4A9D0
        public void GetInputBlockSize(){} // RVA: 0x7FFACBC4ABB0
        public void GetOutputBlockSize(){} // RVA: 0x7FFACBC4AC20
        public void ProcessBlock(){} // RVA: 0x7FFACBC4AC90
        public void EncodeBlock(){} // RVA: 0x7FFACBC4ACC0
        public void DecodeBlock(){} // RVA: 0x7FFACBC4B100
        public void ItoOSP(){} // RVA: 0x7FFACBB7A590
        public void maskGeneratorFunction1(){} // RVA: 0x7FFACBC4B4D0
    }

    public class Pkcs1Encoding : Object
    {
        public string StrictLengthEnabled;
        public int AlgorithmName;
        public bool[] strictLengthEnabled;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Security.SecureRandom random; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IAsymmetricBlockCipher engine; // 0x18
        public bool forEncryption; // 0x20
        public bool forPrivateKey; // 0x21
        public bool useStrictLength; // 0x22
        public int pLen; // 0x24
        public byte[] fallback; // 0x28
        public byte[] blockBuffer; // 0x30

        // ── Methods ──
        public void get_StrictLengthEnabled(){} // RVA: 0x7FFACBC4B980
        public void set_StrictLengthEnabled(){} // RVA: 0x7FFACBC4BA00
        public void .cctor(){} // RVA: 0x7FFACBC4BA80
        public void .ctor(){} // RVA: 0x7FFACBC4BD70 | overloaded x3
        public void GetUnderlyingCipher(){} // RVA: 0x7FFAC2F247C0
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC4BEA0
        public void Init(){} // RVA: 0x7FFACBC4BF10
        public void GetInputBlockSize(){} // RVA: 0x7FFACBC4C2B0
        public void GetOutputBlockSize(){} // RVA: 0x7FFACBC4C310
        public void ProcessBlock(){} // RVA: 0x7FFACBC4C370
        public void EncodeBlock(){} // RVA: 0x7FFACBC4C3A0
        public void CheckPkcs1Encoding(){} // RVA: 0x7FFACBC4C640
        public void DecodeBlockOrRandom(){} // RVA: 0x7FFACBC4C700
        public void DecodeBlock(){} // RVA: 0x7FFACBC4CA20
        public void FindStart(){} // RVA: 0x7FFACBC4CD50
    }

}