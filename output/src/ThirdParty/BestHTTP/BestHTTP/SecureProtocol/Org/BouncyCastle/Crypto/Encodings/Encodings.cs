// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Encodings
// Classes: 3
// Methods: 43

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Encodings
{
    public class ISO9796d1Encoding : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Sixteen;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A0A2D50
        public void GetUnderlyingCipher(){} // RVA: 0x7FFE81116380
        public void Init(){} // RVA: 0x7FFE8A0A2DC0
        public void GetInputBlockSize(){} // RVA: 0x7FFE8A0A2FC0
        public void GetOutputBlockSize(){} // RVA: 0x7FFE8A0A3020
        public void SetPadBits(){} // RVA: 0x7FFE8A0A3080
        public void GetPadBits(){} // RVA: 0x7FFE8151D690
        public void ProcessBlock(){} // RVA: 0x7FFE8A0A30F0
        public void EncodeBlock(){} // RVA: 0x7FFE8A0A3120
        public void DecodeBlock(){} // RVA: 0x7FFE8A0A3420
        public void .cctor(){} // RVA: 0x7FFE8A0A3A20
    }

    public class OaepEncoding : Object
    {
        public byte[] defHash; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A0A3D90 | overloaded x4
        public void GetUnderlyingCipher(){} // RVA: 0x7FFE811290C0
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A0A3F80
        public void Init(){} // RVA: 0x7FFE8A0A3FF0
        public void GetInputBlockSize(){} // RVA: 0x7FFE8A0A41D0
        public void GetOutputBlockSize(){} // RVA: 0x7FFE8A0A4240
        public void ProcessBlock(){} // RVA: 0x7FFE8A0A42B0
        public void EncodeBlock(){} // RVA: 0x7FFE8A0A42E0
        public void DecodeBlock(){} // RVA: 0x7FFE8A0A4720
        public void ItoOSP(){} // RVA: 0x7FFE89FD3BB0
        public void maskGeneratorFunction1(){} // RVA: 0x7FFE8A0A4AF0
    }

    public class Pkcs1Encoding : Object
    {
        public string StrictLengthEnabledProperty;
        public int HeaderLength;

        // ── Methods ──
        public void get_StrictLengthEnabled(){} // RVA: 0x7FFE8A0A4FA0
        public void set_StrictLengthEnabled(){} // RVA: 0x7FFE8A0A5020
        public void .cctor(){} // RVA: 0x7FFE8A0A50A0
        public void .ctor(){} // RVA: 0x7FFE8A0A5390 | overloaded x3
        public void GetUnderlyingCipher(){} // RVA: 0x7FFE810FE7C0
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A0A54C0
        public void Init(){} // RVA: 0x7FFE8A0A5530
        public void GetInputBlockSize(){} // RVA: 0x7FFE8A0A58D0
        public void GetOutputBlockSize(){} // RVA: 0x7FFE8A0A5930
        public void ProcessBlock(){} // RVA: 0x7FFE8A0A5990
        public void EncodeBlock(){} // RVA: 0x7FFE8A0A59C0
        public void CheckPkcs1Encoding(){} // RVA: 0x7FFE8A0A5C60
        public void DecodeBlockOrRandom(){} // RVA: 0x7FFE8A0A5D20
        public void DecodeBlock(){} // RVA: 0x7FFE8A0A6040
        public void FindStart(){} // RVA: 0x7FFE8A0A6370
    }

}