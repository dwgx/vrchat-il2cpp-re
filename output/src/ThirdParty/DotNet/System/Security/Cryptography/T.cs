// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Cryptography
// Classes: 5
// Methods: 43

namespace ThirdParty.DotNet.System.Security.Cryptography
{
    public class TailStream : Stream
    {
        public byte[] _Buffer; // 0x28
        public int _BufferSize; // 0x30
        public int _BufferIndex; // 0x34
        public bool _BufferFull; // 0x38
        public object field_4; // 0x303
        public object field_5; // 0x304

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867C1BD0
        public void Clear(){} // RVA: 0x7FFE867B03A0
        public void Dispose(){} // RVA: 0x7FFE867C1C90
        public void get_Buffer(){} // RVA: 0x7FFE867C1D60
        public void get_CanRead(){} // RVA: 0x7FFE810FB320
        public void get_CanSeek(){} // RVA: 0x7FFE810FB320
        public void get_CanWrite(){} // RVA: 0x7FFE865A8CD0
        public void get_Length(){} // RVA: 0x7FFE867C1DE0
        public void get_Position(){} // RVA: 0x7FFE867C1E40
        public void set_Position(){} // RVA: 0x7FFE867C1EA0
        public void Flush(){} // RVA: 0x7FFE810FB310
        public void Seek(){} // RVA: 0x7FFE867C1F00
        public void SetLength(){} // RVA: 0x7FFE867C1F60
        public void Read(){} // RVA: 0x7FFE867C1FC0
        public void Write(){} // RVA: 0x7FFE867C2020
    }

    public class ToBase64Transform : Object
    {
        // ── Methods ──
        public void get_InputBlockSize(){} // RVA: 0x7FFE817BF630
        public void get_OutputBlockSize(){} // RVA: 0x7FFE8180E590
        public void get_CanTransformMultipleBlocks(){} // RVA: 0x7FFE810FB320
        public void get_CanReuseTransform(){} // RVA: 0x7FFE811E0850
        public void TransformBlock(){} // RVA: 0x7FFE867B7850
        public void TransformFinalBlock(){} // RVA: 0x7FFE867B7B50
        public void Dispose(){} // RVA: 0x7FFE810FB310 | overloaded x2
        public void Clear(){} // RVA: 0x7FFE867B7E10
        public void Finalize(){} // RVA: 0x7FFE867B7E80
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class TripleDES : SymmetricAlgorithm
    {
        public System.Security.Cryptography.KeySizes[] s_legalBlockSizes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867DF200
        public void get_Key(){} // RVA: 0x7FFE867DF330
        public void set_Key(){} // RVA: 0x7FFE867DF410
        public void Create(){} // RVA: 0x7FFE867DF690 | overloaded x2
        public void IsWeakKey(){} // RVA: 0x7FFE867DF770
        public void EqualBytes(){} // RVA: 0x7FFE867DF8F0
        public void IsLegalKeySize(){} // RVA: 0x7FFE867DFB30
        public void .cctor(){} // RVA: 0x7FFE867DFB50
    }

    public class TripleDESCryptoServiceProvider : TripleDES
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867DFDD0
        public void CreateEncryptor(){} // RVA: 0x7FFE867DFF70
        public void CreateDecryptor(){} // RVA: 0x7FFE867E0090
        public void GenerateKey(){} // RVA: 0x7FFE867E01B0
        public void GenerateIV(){} // RVA: 0x7FFE867E0300
    }

    public class TripleDESTransform : SymmetricTransform
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867EF960
        public void ECB(){} // RVA: 0x7FFE867F0290
        public void GetStrongKey(){} // RVA: 0x7FFE867F0400
    }

}