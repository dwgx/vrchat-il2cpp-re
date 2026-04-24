// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.IO.Hashing
// Classes: 3
// Methods: 42

namespace ThirdParty.DotNet.System.IO.Hashing
{
    public class NonCryptographicHashAlgorithm : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD543B09F0
        public void Append(){}
        public void Reset(){} // RVA: 0x7FFD4E090980
        public void GetHashCode(){} // RVA: 0x7FFD543B0A60
    }

    public class XxHash3 : NonCryptographicHashAlgorithm
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD543B0C70 | overloaded x2
        public void HashToUInt64(){} // RVA: 0x7FFD543B0E20
        public void Reset(){} // RVA: 0x7FFD543B0EC0
        public void Append(){} // RVA: 0x7FFD543B0F40
        public void GetCurrentHashAsUInt64(){} // RVA: 0x7FFD543B0F70
        public void HashLength0To16(){} // RVA: 0x7FFD543B1140
        public void HashLength1To3(){} // RVA: 0x7FFD543B1340
        public void HashLength4To8(){} // RVA: 0x7FFD543B13B0
        public void HashLength9To16(){} // RVA: 0x7FFD543B1440
        public void HashLength17To128(){} // RVA: 0x7FFD543B1530
        public void HashLength129To240(){} // RVA: 0x7FFD543B1980
        public void HashLengthOver240(){} // RVA: 0x7FFD543B2110
    }

    public class XxHashShared : Object
    {
        public object DefaultSecret;

        // ── Methods ──
        public void get_DefaultSecret(){} // RVA: 0x7FFD543B2B30
        public void Initialize(){} // RVA: 0x7FFD543B2B90
        public void Reset(){} // RVA: 0x7FFD543B2D40
        public void Rrmxmx(){} // RVA: 0x7FFD543B2DC0
        public void HashInternalLoop(){} // RVA: 0x7FFD543B2E20
        public void ConsumeStripes(){} // RVA: 0x7FFD543B2EE0
        public void Append(){} // RVA: 0x7FFD543B2FE0
        public void CopyAccumulators(){} // RVA: 0x7FFD543B3620
        public void DigestLong(){} // RVA: 0x7FFD543B3670
        public void InitializeAccumulators(){} // RVA: 0x7FFD543B38C0
        public void MergeAccumulators(){} // RVA: 0x7FFD543B3930
        public void Mix16Bytes(){} // RVA: 0x7FFD543B3B30
        public void Multiply32To64(){} // RVA: 0x7FFD539D6350
        public void Avalanche(){} // RVA: 0x7FFD543B3BB0
        public void Multiply64To128(){} // RVA: 0x7FFD543B3BE0
        public void Multiply64To128ThenFold(){} // RVA: 0x7FFD543B3C50
        public void DeriveSecretFromSeed(){} // RVA: 0x7FFD543B3CB0
        public void Accumulate(){} // RVA: 0x7FFD543B3D60
        public void Accumulate512(){} // RVA: 0x7FFD543B3EA0
        public void Accumulate512Inlined(){} // RVA: 0x7FFD543B3EB0
        public void ScrambleAccumulators(){} // RVA: 0x7FFD543B3F30
        public void XorShift(){} // RVA: 0x7FFD543B3F70
        public void ReadUInt32LE(){} // RVA: 0x7FFD543B3F90
        public void ReadUInt64LE(){} // RVA: 0x7FFD505F9A30
        public void WriteUInt64LE(){} // RVA: 0x7FFD53ACFB00
    }

}