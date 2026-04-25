// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Cryptography
// Classes: 5
// Methods: 43

namespace ThirdParty.DotNet.System.Security.Cryptography
{
    public class TailStream : Stream
    {
        public byte[] Buffer; // 0x28
        public int CanRead; // 0x30
        public int CanSeek; // 0x34
        public bool CanWrite; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC84182C0
        public void Clear(){} // RVA: 0x7FFAC8406A90
        public void Dispose(){} // RVA: 0x7FFAC8418380
        public void get_Buffer(){} // RVA: 0x7FFAC8418450
        public void get_CanRead(){} // RVA: 0x7FFAC2F21320
        public void get_CanSeek(){} // RVA: 0x7FFAC2F21320
        public void get_CanWrite(){} // RVA: 0x7FFAC81FF390
        public void get_Length(){} // RVA: 0x7FFAC84184D0
        public void get_Position(){} // RVA: 0x7FFAC8418530
        public void set_Position(){} // RVA: 0x7FFAC8418590
        public void Flush(){} // RVA: 0x7FFAC2F21310
        public void Seek(){} // RVA: 0x7FFAC84185F0
        public void SetLength(){} // RVA: 0x7FFAC8418650
        public void Read(){} // RVA: 0x7FFAC84186B0
        public void Write(){} // RVA: 0x7FFAC8418710
    }

    public class ToBase64Transform : Object
    {
        public object InputBlockSize;
        public object OutputBlockSize;
        public object CanTransformMultipleBlocks;
        public object CanReuseTransform;

        // ── Methods ──
        public void get_InputBlockSize(){} // RVA: 0x7FFAC366FE20
        public void get_OutputBlockSize(){} // RVA: 0x7FFAC36C3910
        public void get_CanTransformMultipleBlocks(){} // RVA: 0x7FFAC2F21320
        public void get_CanReuseTransform(){} // RVA: 0x7FFAC3006850
        public void TransformBlock(){} // RVA: 0x7FFAC840DF40
        public void TransformFinalBlock(){} // RVA: 0x7FFAC840E240
        public void Dispose(){} // RVA: 0x7FFAC2F21310 | overloaded x2
        public void Clear(){} // RVA: 0x7FFAC840E500
        public void Finalize(){} // RVA: 0x7FFAC840E570
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class TripleDES : SymmetricAlgorithm
    {
        public System.Security.Cryptography.KeySizes[] Key;
        public System.Security.Cryptography.KeySizes[] s_legalKeySizes; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC84358F0
        public void get_Key(){} // RVA: 0x7FFAC8435A20
        public void set_Key(){} // RVA: 0x7FFAC8435B00
        public void Create(){} // RVA: 0x7FFAC8435D80 | overloaded x2
        public void IsWeakKey(){} // RVA: 0x7FFAC8435E60
        public void EqualBytes(){} // RVA: 0x7FFAC8435FE0
        public void IsLegalKeySize(){} // RVA: 0x7FFAC8436220
        public void .cctor(){} // RVA: 0x7FFAC8436240
    }

    public class TripleDESCryptoServiceProvider : TripleDES
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC84364C0
        public void CreateEncryptor(){} // RVA: 0x7FFAC8436660
        public void CreateDecryptor(){} // RVA: 0x7FFAC8436780
        public void GenerateKey(){} // RVA: 0x7FFAC84368A0
        public void GenerateIV(){} // RVA: 0x7FFAC84369F0
    }

    public class TripleDESTransform : SymmetricTransform
    {
        public System.Security.Cryptography.DESTransform E1; // 0x58
        public System.Security.Cryptography.DESTransform D2; // 0x60
        public System.Security.Cryptography.DESTransform E3; // 0x68
        public System.Security.Cryptography.DESTransform D1; // 0x70
        public System.Security.Cryptography.DESTransform E2; // 0x78
        public System.Security.Cryptography.DESTransform D3; // 0x80

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8446050
        public void ECB(){} // RVA: 0x7FFAC8446980
        public void GetStrongKey(){} // RVA: 0x7FFAC8446AF0
    }

}