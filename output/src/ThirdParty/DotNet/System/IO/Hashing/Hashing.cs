// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.IO.Hashing
// Classes: 4
// Methods: 45

namespace ThirdParty.DotNet.System.IO.Hashing
{
    public class NonCryptographicHashAlgorithm
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF92A9B30
        public void Append(){}
        public void Reset(){} // RVA: 0x7FFAF2AD4A50
        public void GetHashCode(){} // RVA: 0x7FFAF92A9BA0
    }

    public class XxHash3
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF92A9DB0 | overloaded x2
        public void HashToUInt64(){} // RVA: 0x7FFAF92A9F60
        public void Reset(){} // RVA: 0x7FFAF92AA000
        public void Append(){} // RVA: 0x7FFAF92AA080
        public void GetCurrentHashAsUInt64(){} // RVA: 0x7FFAF92AA0B0
        public void HashLength0To16(){} // RVA: 0x7FFAF92AA280
        public void HashLength1To3(){} // RVA: 0x7FFAF92AA480
        public void HashLength4To8(){} // RVA: 0x7FFAF92AA4F0
        public void HashLength9To16(){} // RVA: 0x7FFAF92AA580
        public void HashLength17To128(){} // RVA: 0x7FFAF92AA670
        public void HashLength129To240(){} // RVA: 0x7FFAF92AAAC0
        public void HashLengthOver240(){} // RVA: 0x7FFAF92AB250
    }

    public class XxHash64
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAF92AB430
        public void Append(){} // RVA: 0x7FFAF92AB4C0
        public void Avalanche(){} // RVA: 0x7FFAF92AB8F0
    }

    public class XxHashShared
    {
        // ── Methods ──
        public void get_DefaultSecret(){} // RVA: 0x7FFAF92ABC70
        public void Initialize(){} // RVA: 0x7FFAF92ABCD0
        public void Reset(){} // RVA: 0x7FFAF92ABE80
        public void Rrmxmx(){} // RVA: 0x7FFAF92ABF00
        public void HashInternalLoop(){} // RVA: 0x7FFAF92ABF60
        public void ConsumeStripes(){} // RVA: 0x7FFAF92AC020
        public void Append(){} // RVA: 0x7FFAF92AC120
        public void CopyAccumulators(){} // RVA: 0x7FFAF92AC760
        public void DigestLong(){} // RVA: 0x7FFAF92AC7B0
        public void InitializeAccumulators(){} // RVA: 0x7FFAF92ACA00
        public void MergeAccumulators(){} // RVA: 0x7FFAF92ACA70
        public void Mix16Bytes(){} // RVA: 0x7FFAF92ACC70
        public void Multiply32To64(){} // RVA: 0x7FFAF88CECE0
        public void Avalanche(){} // RVA: 0x7FFAF92ACCF0
        public void Multiply64To128(){} // RVA: 0x7FFAF92ACD20
        public void Multiply64To128ThenFold(){} // RVA: 0x7FFAF92ACD90
        public void DeriveSecretFromSeed(){} // RVA: 0x7FFAF92ACDF0
        public void Accumulate(){} // RVA: 0x7FFAF92ACEA0
        public void Accumulate512(){} // RVA: 0x7FFAF92ACFE0
        public void Accumulate512Inlined(){} // RVA: 0x7FFAF92ACFF0
        public void ScrambleAccumulators(){} // RVA: 0x7FFAF92AD070
        public void XorShift(){} // RVA: 0x7FFAF92AD0B0
        public void ReadUInt32LE(){} // RVA: 0x7FFAF92AD0D0
        public void ReadUInt64LE(){} // RVA: 0x7FFAF51E8C50
        public void WriteUInt64LE(){} // RVA: 0x7FFAF89C8490
    }

}