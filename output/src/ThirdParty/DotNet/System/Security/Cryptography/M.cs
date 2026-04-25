// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Cryptography
// Classes: 4
// Methods: 24

namespace ThirdParty.DotNet.System.Security.Cryptography
{
    public class MACTripleDES : KeyedHashAlgorithm
    {
        public System.Security.Cryptography.ICryptoTransform Padding; // 0x30
        public System.Security.Cryptography.CryptoStream _cs; // 0x38
        public System.Security.Cryptography.TailStream _ts; // 0x40
        public int m_bitsPerByte;
        public int m_bytesPerBlock; // 0x48
        public System.Security.Cryptography.TripleDES des; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8417710 | overloaded x3
        public void Initialize(){} // RVA: 0x7FFAC81FF510
        public void get_Padding(){} // RVA: 0x7FFAC8417B70
        public void set_Padding(){} // RVA: 0x7FFAC8417BA0
        public void HashCore(){} // RVA: 0x7FFAC8417C40
        public void HashFinal(){} // RVA: 0x7FFAC8417F00
        public void Dispose(){} // RVA: 0x7FFAC84181D0
    }

    public class MD5 : HashAlgorithm
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8373D00
        public void Create(){} // RVA: 0x7FFAC8418B70 | overloaded x2
    }

    public class MD5CryptoServiceProvider : MD5
    {
        public int BLOCK_SIZE_BYTES;
        public uint[] _H; // 0x28
        public uint[] buff; // 0x30
        public ulong count; // 0x38
        public byte[] _ProcessingBuffer; // 0x40
        public int _ProcessingBufferCount; // 0x48
        public uint[] K;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC843FCE0
        public void Finalize(){} // RVA: 0x7FFAC843FE70
        public void Dispose(){} // RVA: 0x7FFAC843FEC0
        public void HashCore(){} // RVA: 0x7FFAC843FF40
        public void HashFinal(){} // RVA: 0x7FFAC8440080
        public void Initialize(){} // RVA: 0x7FFAC8440170
        public void ProcessBlock(){} // RVA: 0x7FFAC84401F0
        public void ProcessFinalBlock(){} // RVA: 0x7FFAC8441900
        public void AddLength(){} // RVA: 0x7FFAC8441B30
        public void .cctor(){} // RVA: 0x7FFAC8441C10
    }

    public class MaskGenerationMethod : Object
    {
        // ── Methods ──
        public void GenerateMask(){} // RVA: 0x7FFAC2C69DD0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

}