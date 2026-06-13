// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Cryptography
// Classes: 5
// Methods: 43

namespace ThirdParty.DotNet.System.Security.Cryptography
{
    public class TailStream
    {
        public byte[] _Buffer; // 0x28
        public int _BufferSize; // 0x30
        public int _BufferIndex; // 0x34
        public bool _BufferFull; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C80D30
        public void Clear(){} // RVA: 0x5C6F500
        public void Dispose(){} // RVA: 0x5C80DF0
        public void get_Buffer(){} // RVA: 0x5C80EC0
        public void get_CanRead(){} // RVA: 0x2DD320
        public void get_CanSeek(){} // RVA: 0x2DD320
        public void get_CanWrite(){} // RVA: 0x5A67FD0
        public void get_Length(){} // RVA: 0x5C80F40
        public void get_Position(){} // RVA: 0x5C80FA0
        public void set_Position(){} // RVA: 0x5C81000
        public void Flush(){} // RVA: 0x2DD310
        public void Seek(){} // RVA: 0x5C81060
        public void SetLength(){} // RVA: 0x5C810C0
        public void Read(){} // RVA: 0x5C81120
        public void Write(){} // RVA: 0x5C81180
    }

    public class ToBase64Transform
    {
        // ── Methods ──
        public void get_InputBlockSize(){} // RVA: 0xA308B0
        public void get_OutputBlockSize(){} // RVA: 0xA7E130
        public void get_CanTransformMultipleBlocks(){} // RVA: 0x2DD320
        public void get_CanReuseTransform(){} // RVA: 0x3C2850
        public void TransformBlock(){} // RVA: 0x5C769B0
        public void TransformFinalBlock(){} // RVA: 0x5C76CB0
        public void Dispose(){} // RVA: 0x2DD310 | overloaded x2
        public void Clear(){} // RVA: 0x5C76F70
        public void Finalize(){} // RVA: 0x5C76FE0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class TripleDES
    {
        public System.Security.Cryptography.KeySizes[] s_legalBlockSizes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C9E360
        public void get_Key(){} // RVA: 0x5C9E490
        public void set_Key(){} // RVA: 0x5C9E570
        public void Create(){} // RVA: 0x5C9E7F0 | overloaded x2
        public void IsWeakKey(){} // RVA: 0x5C9E8D0
        public void EqualBytes(){} // RVA: 0x5C9EA50
        public void IsLegalKeySize(){} // RVA: 0x5C9EC90
        public void .cctor(){} // RVA: 0x5C9ECB0
    }

    public class TripleDESCryptoServiceProvider
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C9EF30
        public void CreateEncryptor(){} // RVA: 0x5C9F0D0
        public void CreateDecryptor(){} // RVA: 0x5C9F1F0
        public void GenerateKey(){} // RVA: 0x5C9F310
        public void GenerateIV(){} // RVA: 0x5C9F460
    }

    public class TripleDESTransform
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5CAEA60
        public void ECB(){} // RVA: 0x5CAF390
        public void GetStrongKey(){} // RVA: 0x5CAF500
    }

}