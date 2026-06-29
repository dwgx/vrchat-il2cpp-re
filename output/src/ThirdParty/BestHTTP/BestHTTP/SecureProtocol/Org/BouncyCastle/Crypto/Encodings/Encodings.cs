// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Encodings
// Classes: 3
// Methods: 38

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Encodings
{
    public class ISO9796d1Encoding : Object
    {
        public object Sixteen;
        public object Six;
        public object shadows;
        public object inverse;
        public object engine;
        public object forEncryption;
        public object bitSize;
        public object padBits;
        public object modulus;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_AlgorithmName(){} // RVA: 0xA2E49B0
        public void GetUnderlyingCipher(){} // RVA: 0xB5DBF0
        public void Init(){} // RVA: 0xA2E4A20
        public void GetInputBlockSize(){} // RVA: 0xA2E4C20
        public void GetOutputBlockSize(){} // RVA: 0xA2E4C80
        public void SetPadBits(){} // RVA: 0xA2E4CE0
        public void GetPadBits(){} // RVA: 0xFEAE90
        public void ProcessBlock(){} // RVA: 0xA2E4D50
        public void EncodeBlock(){} // RVA: 0xA2E4D80
        public void DecodeBlock(){} // RVA: 0xA2E5090
        public void .cctor(){} // RVA: 0xA2E56D0
    }

    public class OaepEncoding : Object
    {
        public object defHash;
        public object mgf1Hash;
        public object engine;
        public object random;
        public object forEncryption;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA2E5A40
        public void GetUnderlyingCipher(){} // RVA: 0xB700F0
        public void get_AlgorithmName(){} // RVA: 0xA2E5C30
        public void Init(){} // RVA: 0xA2E5CA0
        public void GetInputBlockSize(){} // RVA: 0xA2E5E80
        public void GetOutputBlockSize(){} // RVA: 0xA2E5EF0
        public void ProcessBlock(){} // RVA: 0xA2E5F60
        public void EncodeBlock(){} // RVA: 0xA2E5F90
        public void DecodeBlock(){} // RVA: 0xA2E63C0
        public void ItoOSP(){} // RVA: 0xA213980
        public void maskGeneratorFunction1(){} // RVA: 0xA2E67B0
    }

    public class Pkcs1Encoding : Object
    {
        public object StrictLengthEnabledProperty;
        public object HeaderLength;
        public object strictLengthEnabled;
        public object random;
        public object engine;
        public object forEncryption;
        public object forPrivateKey;
        public object useStrictLength;
        public object pLen;
        public object fallback;
        public object blockBuffer;

        // ── Methods ──
        public void get_StrictLengthEnabled(){} // RVA: 0xA2E6C60
        public void set_StrictLengthEnabled(){} // RVA: 0xA2E6CE0
        public void .cctor(){} // RVA: 0xA2E6D60
        public void .ctor(){} // RVA: 0xA2E7050
        public void GetUnderlyingCipher(){} // RVA: 0xB465B0
        public void get_AlgorithmName(){} // RVA: 0xA2E7180
        public void Init(){} // RVA: 0xA2E71F0
        public void GetInputBlockSize(){} // RVA: 0xA2E75A0
        public void GetOutputBlockSize(){} // RVA: 0xA2E7600
        public void ProcessBlock(){} // RVA: 0xA2E7660
        public void EncodeBlock(){} // RVA: 0xA2E7690
        public void CheckPkcs1Encoding(){} // RVA: 0xA2E7940
        public void DecodeBlockOrRandom(){} // RVA: 0xA2E7A10
        public void DecodeBlock(){} // RVA: 0xA2E7D30
        public void FindStart(){} // RVA: 0xA2E8060
    }

}