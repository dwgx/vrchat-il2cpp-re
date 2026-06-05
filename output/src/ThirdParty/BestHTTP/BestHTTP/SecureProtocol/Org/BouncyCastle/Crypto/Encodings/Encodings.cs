// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Encodings
// Classes: 3
// Methods: 43

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Encodings
{
    public class ISO9796d1Encoding
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void get_AlgorithmName(){} // RVA: 0x7FFAFC0F0970
        public void GetUnderlyingCipher(){} // RVA: 0x7FFAF2DA8380
        public void Init(){} // RVA: 0x7FFAFC0F09E0
        public void GetInputBlockSize(){} // RVA: 0x7FFAFC0F0BE0
        public void GetOutputBlockSize(){} // RVA: 0x7FFAFC0F0C40
        public void SetPadBits(){} // RVA: 0x7FFAFC0F0CA0
        public void GetPadBits(){} // RVA: 0x7FFAF3210030
        public void ProcessBlock(){} // RVA: 0x7FFAFC0F0D10
        public void EncodeBlock(){} // RVA: 0x7FFAFC0F0D40
        public void DecodeBlock(){} // RVA: 0x7FFAFC0F1040
        public void .cctor(){} // RVA: 0x7FFAFC0F1640
    }

    public class OaepEncoding
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC0F19B0 | overloaded x4
        public void GetUnderlyingCipher(){} // RVA: 0x7FFAF2DBB0C0
        public void get_AlgorithmName(){} // RVA: 0x7FFAFC0F1BA0
        public void Init(){} // RVA: 0x7FFAFC0F1C10
        public void GetInputBlockSize(){} // RVA: 0x7FFAFC0F1DF0
        public void GetOutputBlockSize(){} // RVA: 0x7FFAFC0F1E60
        public void ProcessBlock(){} // RVA: 0x7FFAFC0F1ED0
        public void EncodeBlock(){} // RVA: 0x7FFAFC0F1F00
        public void DecodeBlock(){} // RVA: 0x7FFAFC0F2340
        public void ItoOSP(){} // RVA: 0x7FFAFC0217E0
        public void maskGeneratorFunction1(){} // RVA: 0x7FFAFC0F2710
    }

    public class Pkcs1Encoding
    {
        // ── Methods ──
        public void get_StrictLengthEnabled(){} // RVA: 0x7FFAFC0F2BC0
        public void set_StrictLengthEnabled(){} // RVA: 0x7FFAFC0F2C40
        public void .cctor(){} // RVA: 0x7FFAFC0F2CC0
        public void .ctor(){} // RVA: 0x7FFAFC0F2FB0 | overloaded x3
        public void GetUnderlyingCipher(){} // RVA: 0x7FFAF2D907C0
        public void get_AlgorithmName(){} // RVA: 0x7FFAFC0F30E0
        public void Init(){} // RVA: 0x7FFAFC0F3150
        public void GetInputBlockSize(){} // RVA: 0x7FFAFC0F34F0
        public void GetOutputBlockSize(){} // RVA: 0x7FFAFC0F3550
        public void ProcessBlock(){} // RVA: 0x7FFAFC0F35B0
        public void EncodeBlock(){} // RVA: 0x7FFAFC0F35E0
        public void CheckPkcs1Encoding(){} // RVA: 0x7FFAFC0F3880
        public void DecodeBlockOrRandom(){} // RVA: 0x7FFAFC0F3940
        public void DecodeBlock(){} // RVA: 0x7FFAFC0F3C60
        public void FindStart(){} // RVA: 0x7FFAFC0F3F90
    }

}