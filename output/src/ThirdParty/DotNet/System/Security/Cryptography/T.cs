// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Cryptography
// Classes: 5
// Methods: 41

namespace ThirdParty.DotNet.System.Security.Cryptography
{
    public class TailStream : Stream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA6ED70
        public void Clear(){} // RVA: 0x7ADA5D520
        public void Dispose(){} // RVA: 0x7ADA6EE30
        public void get_Buffer(){} // RVA: 0x7ADA6EF00
        public void get_CanRead(){} // RVA: 0x7A80D7320
        public void get_CanSeek(){} // RVA: 0x7A80D7320
        public void get_CanWrite(){} // RVA: 0x7AD854AF0
        public void get_Length(){} // RVA: 0x7ADA6EF80
        public void get_Position(){} // RVA: 0x7ADA6EFE0
        public void set_Position(){} // RVA: 0x7ADA6F040
        public void Flush(){} // RVA: 0x7A80D7310
        public void Seek(){} // RVA: 0x7ADA6F0A0
        public void SetLength(){} // RVA: 0x7ADA6F100
        public void Read(){} // RVA: 0x7ADA6F160
        public void Write(){} // RVA: 0x7ADA6F1C0
    }

    public class ToBase64Transform : Object
    {
        // ── Methods ──
        public void get_InputBlockSize(){} // RVA: 0x7A87EE0F0
        public void get_OutputBlockSize(){} // RVA: 0x7A883BE70
        public void get_CanTransformMultipleBlocks(){} // RVA: 0x7A80D7320
        public void get_CanReuseTransform(){} // RVA: 0x7A81BD750
        public void TransformBlock(){} // RVA: 0x7ADA64960
        public void TransformFinalBlock(){} // RVA: 0x7ADA64C60
        public void Dispose(){} // RVA: 0x7A80D7310
        public void Clear(){} // RVA: 0x7ADA64F20
        public void Finalize(){} // RVA: 0x7ADA64F90
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class TripleDES : SymmetricAlgorithm
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA8C730
        public void get_Key(){} // RVA: 0x7ADA8C860
        public void set_Key(){} // RVA: 0x7ADA8C940
        public void Create(){} // RVA: 0x7ADA8CBC0
        public void IsWeakKey(){} // RVA: 0x7ADA8CCA0
        public void EqualBytes(){} // RVA: 0x7ADA8CE20
        public void IsLegalKeySize(){} // RVA: 0x7ADA8D080
        public void .cctor(){} // RVA: 0x7ADA8D0A0
    }

    public class TripleDESCryptoServiceProvider : TripleDES
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA8D320
        public void CreateEncryptor(){} // RVA: 0x7ADA8D4C0
        public void CreateDecryptor(){} // RVA: 0x7ADA8D5E0
        public void GenerateKey(){} // RVA: 0x7ADA8D700
        public void GenerateIV(){} // RVA: 0x7ADA8D850
    }

    public class TripleDESTransform : SymmetricTransform
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA9CAD0
        public void ECB(){} // RVA: 0x7ADA9D410
        public void GetStrongKey(){} // RVA: 0x7ADA9D580
    }

}