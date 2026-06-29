// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Cryptography
// Classes: 4
// Methods: 21

namespace ThirdParty.DotNet.System.Security.Cryptography
{
    public class MACTripleDES : KeyedHashAlgorithm
    {
        public object m_encryptor;
        public object _cs;
        public object _ts;
        public object m_bitsPerByte;
        public object m_bytesPerBlock;
        public object des;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x66F8800
        public void Initialize(){} // RVA: 0x64E2420
        public void get_Padding(){} // RVA: 0x66F8C60
        public void set_Padding(){} // RVA: 0x66F8C90
        public void HashCore(){} // RVA: 0x66F8D30
        public void HashFinal(){} // RVA: 0x66F8FF0
        public void Dispose(){} // RVA: 0x66F92C0
    }

    public class MD5 : HashAlgorithm
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6655170
        public void Create(){} // RVA: 0x66F9C40
    }

    public class MD5CryptoServiceProvider : MD5
    {
        public object BLOCK_SIZE_BYTES;
        public object _H;
        public object buff;
        public object count;
        public object _ProcessingBuffer;
        public object _ProcessingBufferCount;
        public object K;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6721370
        public void Finalize(){} // RVA: 0x6721500
        public void Dispose(){} // RVA: 0x6721550
        public void HashCore(){} // RVA: 0x67215D0
        public void HashFinal(){} // RVA: 0x6721710
        public void Initialize(){} // RVA: 0x6721810
        public void ProcessBlock(){} // RVA: 0x6721890
        public void ProcessFinalBlock(){} // RVA: 0x6722AF0
        public void AddLength(){} // RVA: 0x6722D30
        public void .cctor(){} // RVA: 0x6722E10
    }

    public class MaskGenerationMethod : Object
    {
        // ── Methods ──
        public void GenerateMask(){} // RVA: 0x88B6A0
        public void .ctor(){} // RVA: 0xB43310
    }

}