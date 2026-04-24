// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.IO.Hashing
// Classes: 3
// Methods: 42

namespace ThirdParty.DotNet.System.IO.Hashing
{
    public class NonCryptographicHashAlgorithm : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae9b29c0
        public void Append(){}
        public void Reset(){} // RVA: 0x7ffaa8660cc0
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaae9b2a30
    }

    public class XxHash3 : NonCryptographicHashAlgorithm
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae9b2c40
        public void .ctor(){} // RVA: 0x7ffaae9b2c40
        public void HashToUInt64(){} // RVA: 0x7ffaae9b2df0
        public void Reset(){} // RVA: 0x7ffaae9b2e90
        public void Append(){} // RVA: 0x7ffaae9b2f10
        public void HashLength0To16(){} // RVA: 0x7ffaae9b3110
        public void HashLength1To3(){} // RVA: 0x7ffaae9b3310
        public void HashLength4To8(){} // RVA: 0x7ffaae9b3380
        public void HashLength9To16(){} // RVA: 0x7ffaae9b3410
        public void HashLength17To128(){} // RVA: 0x7ffaae9b3500
        public void HashLength129To240(){} // RVA: 0x7ffaae9b3950
        public void HashLengthOver240(){} // RVA: 0x7ffaae9b40e0
        // ── Binary Analysis Named ──
        public void GetCurrentHashAsUInt64(){} // RVA: 0x7ffaae9b2f40
    }

    public class XxHashShared : Object
    {
        // ── Original Methods ──
        public void get_DefaultSecret(){} // RVA: 0x7ffaae9b4b00
        public void Initialize(){} // RVA: 0x7ffaae9b4b60
        public void Reset(){} // RVA: 0x7ffaae9b4d10
        public void Rrmxmx(){} // RVA: 0x7ffaae9b4d90
        public void HashInternalLoop(){} // RVA: 0x7ffaae9b4df0
        public void ConsumeStripes(){} // RVA: 0x7ffaae9b4eb0
        public void Append(){} // RVA: 0x7ffaae9b4fb0
        public void CopyAccumulators(){} // RVA: 0x7ffaae9b55f0
        public void DigestLong(){} // RVA: 0x7ffaae9b5640
        public void InitializeAccumulators(){} // RVA: 0x7ffaae9b5890
        public void MergeAccumulators(){} // RVA: 0x7ffaae9b5900
        public void Mix16Bytes(){} // RVA: 0x7ffaae9b5b00
        public void Multiply32To64(){} // RVA: 0x7ffaadfd7570
        public void Avalanche(){} // RVA: 0x7ffaae9b5b80
        public void Multiply64To128(){} // RVA: 0x7ffaae9b5bb0
        public void Multiply64To128ThenFold(){} // RVA: 0x7ffaae9b5c20
        public void DeriveSecretFromSeed(){} // RVA: 0x7ffaae9b5c80
        public void Accumulate(){} // RVA: 0x7ffaae9b5d30
        public void Accumulate512(){} // RVA: 0x7ffaae9b5e70
        public void Accumulate512Inlined(){} // RVA: 0x7ffaae9b5e80
        public void ScrambleAccumulators(){} // RVA: 0x7ffaae9b5f00
        public void XorShift(){} // RVA: 0x7ffaae9b5f40
        public void ReadUInt32LE(){} // RVA: 0x7ffaae9b5f60
        public void ReadUInt64LE(){} // RVA: 0x7ffaaabdb990
        public void WriteUInt64LE(){} // RVA: 0x7ffaae0d0d10
    }

}