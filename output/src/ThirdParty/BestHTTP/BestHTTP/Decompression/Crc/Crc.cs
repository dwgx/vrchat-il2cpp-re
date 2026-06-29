// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.Decompression.Crc
// Classes: 1
// Methods: 15

namespace ThirdParty.BestHTTP.BestHTTP.Decompression.Crc
{
    public class CRC32 : Object
    {
        public object dwPolynomial;
        public object _TotalBytesRead;
        public object reverseBits;
        public object crc32Table;
        public object BUFFER_SIZE;
        public object _register;

        // ── Methods ──
        public void get_TotalBytesRead(){} // RVA: 0xB465B0
        public void get_Crc32Result(){} // RVA: 0xA4D0ED0
        public void GetCrc32(){} // RVA: 0xA4D0EE0
        public void GetCrc32AndCopy(){} // RVA: 0xA4D0EF0
        public void ComputeCrc32(){} // RVA: 0xA4D1170
        public void _InternalComputeCrc32(){} // RVA: 0xA4D1170
        public void SlurpBlock(){} // RVA: 0xA4D11B0
        public void UpdateCRC(){} // RVA: 0xA4D1330
        public void ReverseBits(){} // RVA: 0xA4D13E0
        public void GenerateLookupTable(){} // RVA: 0xA4D1410
        public void gf2_matrix_times(){} // RVA: 0xA4D1570
        public void gf2_matrix_square(){} // RVA: 0xA4D15C0
        public void Combine(){} // RVA: 0xA4D1660
        public void .ctor(){} // RVA: 0xA4D19C0
        public void Reset(){} // RVA: 0x7921150
    }

}