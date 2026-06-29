// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Cryptography
// Classes: 5
// Methods: 41

namespace ThirdParty.DotNet.System.Security.Cryptography
{
    public class TailStream : Stream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x66F93B0
        public void Clear(){} // RVA: 0x66E7B30
        public void Dispose(){} // RVA: 0x66F9470
        public void get_Buffer(){} // RVA: 0x66F9540
        public void get_CanRead(){} // RVA: 0xB43320
        public void get_CanSeek(){} // RVA: 0xB43320
        public void get_CanWrite(){} // RVA: 0x64E22A0
        public void get_Length(){} // RVA: 0x66F95C0
        public void get_Position(){} // RVA: 0x66F9620
        public void set_Position(){} // RVA: 0x66F9680
        public void Flush(){} // RVA: 0xB43310
        public void Seek(){} // RVA: 0x66F96E0
        public void SetLength(){} // RVA: 0x66F9740
        public void Read(){} // RVA: 0x66F97A0
        public void Write(){} // RVA: 0x66F9800
    }

    public class ToBase64Transform : Object
    {
        // ── Methods ──
        public void get_InputBlockSize(){} // RVA: 0x12FC4A0
        public void get_OutputBlockSize(){} // RVA: 0x1347420
        public void get_CanTransformMultipleBlocks(){} // RVA: 0xB43320
        public void get_CanReuseTransform(){} // RVA: 0xC2E4C0
        public void TransformBlock(){} // RVA: 0x66EEF40
        public void TransformFinalBlock(){} // RVA: 0x66EF240
        public void Dispose(){} // RVA: 0xB43310
        public void Clear(){} // RVA: 0x66EF500
        public void Finalize(){} // RVA: 0x66EF570
        public void .ctor(){} // RVA: 0xB43310
    }

    public class TripleDES : SymmetricAlgorithm
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6716E10
        public void get_Key(){} // RVA: 0x6716F40
        public void set_Key(){} // RVA: 0x6717020
        public void Create(){} // RVA: 0x67172A0
        public void IsWeakKey(){} // RVA: 0x6717380
        public void EqualBytes(){} // RVA: 0x6717500
        public void IsLegalKeySize(){} // RVA: 0x6717760
        public void .cctor(){} // RVA: 0x6717780
    }

    public class TripleDESCryptoServiceProvider : TripleDES
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6717A00
        public void CreateEncryptor(){} // RVA: 0x6717BA0
        public void CreateDecryptor(){} // RVA: 0x6717CC0
        public void GenerateKey(){} // RVA: 0x6717DE0
        public void GenerateIV(){} // RVA: 0x6717F30
    }

    public class TripleDESTransform : SymmetricTransform
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x67273F0
        public void ECB(){} // RVA: 0x6727D30
        public void GetStrongKey(){} // RVA: 0x6727EA0
    }

}