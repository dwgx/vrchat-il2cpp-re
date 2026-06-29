// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Encodings
// Classes: 3
// Methods: 38

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Encodings
{
    public class ISO9796d1Encoding : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void get_AlgorithmName(){} // RVA: 0x7B14794B0
        public void GetUnderlyingCipher(){} // RVA: 0x7A80F2570
        public void Init(){} // RVA: 0x7B1479520
        public void GetInputBlockSize(){} // RVA: 0x7B1479720
        public void GetOutputBlockSize(){} // RVA: 0x7B1479780
        public void SetPadBits(){} // RVA: 0x7B14797E0
        public void GetPadBits(){} // RVA: 0x7A851DB90
        public void ProcessBlock(){} // RVA: 0x7B1479850
        public void EncodeBlock(){} // RVA: 0x7B1479880
        public void DecodeBlock(){} // RVA: 0x7B1479B90
        public void .cctor(){} // RVA: 0x7B147A1D0
    }

    public class OaepEncoding : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B147A540
        public void GetUnderlyingCipher(){} // RVA: 0x7A81052C0
        public void get_AlgorithmName(){} // RVA: 0x7B147A730
        public void Init(){} // RVA: 0x7B147A7A0
        public void GetInputBlockSize(){} // RVA: 0x7B147A980
        public void GetOutputBlockSize(){} // RVA: 0x7B147A9F0
        public void ProcessBlock(){} // RVA: 0x7B147AA60
        public void EncodeBlock(){} // RVA: 0x7B147AA90
        public void DecodeBlock(){} // RVA: 0x7B147AEC0
        public void ItoOSP(){} // RVA: 0x7B13A8260
        public void maskGeneratorFunction1(){} // RVA: 0x7B147B2B0
    }

    public class Pkcs1Encoding : Object
    {
        // ── Methods ──
        public void get_StrictLengthEnabled(){} // RVA: 0x7B147B760
        public void set_StrictLengthEnabled(){} // RVA: 0x7B147B7E0
        public void .cctor(){} // RVA: 0x7B147B860
        public void .ctor(){} // RVA: 0x7B147BB50
        public void GetUnderlyingCipher(){} // RVA: 0x7A80DA7B0
        public void get_AlgorithmName(){} // RVA: 0x7B147BC80
        public void Init(){} // RVA: 0x7B147BCF0
        public void GetInputBlockSize(){} // RVA: 0x7B147C0A0
        public void GetOutputBlockSize(){} // RVA: 0x7B147C100
        public void ProcessBlock(){} // RVA: 0x7B147C160
        public void EncodeBlock(){} // RVA: 0x7B147C190
        public void CheckPkcs1Encoding(){} // RVA: 0x7B147C440
        public void DecodeBlockOrRandom(){} // RVA: 0x7B147C510
        public void DecodeBlock(){} // RVA: 0x7B147C830
        public void FindStart(){} // RVA: 0x7B147CB60
    }

}