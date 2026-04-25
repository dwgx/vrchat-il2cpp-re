// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.Decompression.Crc
// Classes: 1
// Methods: 19

namespace ThirdParty.BestHTTP.BestHTTP.Decompression.Crc
{
    public class CRC32 : Object
    {
        public uint TotalBytesRead; // 0x10
        public long Crc32Result; // 0x18
        public bool reverseBits; // 0x20
        public uint[] crc32Table; // 0x28
        public int BUFFER_SIZE;
        public uint _register; // 0x30

        // ── Methods ──
        public void get_TotalBytesRead(){} // RVA: 0x7FFAC2F247C0
        public void get_Crc32Result(){} // RVA: 0x7FFACBE33F20
        public void GetCrc32(){} // RVA: 0x7FFACBE33F30
        public void GetCrc32AndCopy(){} // RVA: 0x7FFACBE33F40
        public void ComputeCrc32(){} // RVA: 0x7FFACBE341B0
        public void _InternalComputeCrc32(){} // RVA: 0x7FFACBE341B0
        public void SlurpBlock(){} // RVA: 0x7FFACBE341F0
        public void UpdateCRC(){} // RVA: 0x7FFACBE34360 | overloaded x2
        public void ReverseBits(){} // RVA: 0x7FFACBE34410 | overloaded x2
        public void GenerateLookupTable(){} // RVA: 0x7FFACBE34440
        public void gf2_matrix_times(){} // RVA: 0x7FFACBE345A0
        public void gf2_matrix_square(){} // RVA: 0x7FFACBE345F0
        public void Combine(){} // RVA: 0x7FFACBE34670
        public void .ctor(){} // RVA: 0x7FFACBE34980 | overloaded x3
        public void Reset(){} // RVA: 0x7FFAC966D220
    }

}