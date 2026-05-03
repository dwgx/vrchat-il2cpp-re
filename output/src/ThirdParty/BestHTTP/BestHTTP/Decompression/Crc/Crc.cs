// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.Decompression.Crc
// Classes: 1
// Methods: 19

namespace ThirdParty.BestHTTP.BestHTTP.Decompression.Crc
{
    public class CRC32 : Object
    {
        public uint dwPolynomial; // 0x10
        public long _TotalBytesRead; // 0x18

        // ── Methods ──
        public void get_TotalBytesRead(){} // RVA: 0x7FFE810FE7C0
        public void get_Crc32Result(){} // RVA: 0x7FFE8A28D540
        public void GetCrc32(){} // RVA: 0x7FFE8A28D550
        public void GetCrc32AndCopy(){} // RVA: 0x7FFE8A28D560
        public void ComputeCrc32(){} // RVA: 0x7FFE8A28D7D0
        public void _InternalComputeCrc32(){} // RVA: 0x7FFE8A28D7D0
        public void SlurpBlock(){} // RVA: 0x7FFE8A28D810
        public void UpdateCRC(){} // RVA: 0x7FFE8A28D980 | overloaded x2
        public void ReverseBits(){} // RVA: 0x7FFE8A28DA30 | overloaded x2
        public void GenerateLookupTable(){} // RVA: 0x7FFE8A28DA60
        public void gf2_matrix_times(){} // RVA: 0x7FFE8A28DBC0
        public void gf2_matrix_square(){} // RVA: 0x7FFE8A28DC10
        public void Combine(){} // RVA: 0x7FFE8A28DC90
        public void .ctor(){} // RVA: 0x7FFE8A28DFA0 | overloaded x3
        public void Reset(){} // RVA: 0x7FFE87A15980
    }

}