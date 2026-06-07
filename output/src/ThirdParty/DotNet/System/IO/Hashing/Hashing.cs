// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.IO.Hashing
// Classes: 4
// Methods: 45

namespace ThirdParty.DotNet.System.IO.Hashing
{
    public class NonCryptographicHashAlgorithm
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x67F9B30
        public void Append(){}
        public void Reset(){} // RVA: 0x24A50
        public void GetHashCode(){} // RVA: 0x67F9BA0
    }

    public class XxHash3
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x67F9DB0 | overloaded x2
        public void HashToUInt64(){} // RVA: 0x67F9F60
        public void Reset(){} // RVA: 0x67FA000
        public void Append(){} // RVA: 0x67FA080
        public void GetCurrentHashAsUInt64(){} // RVA: 0x67FA0B0
        public void HashLength0To16(){} // RVA: 0x67FA280
        public void HashLength1To3(){} // RVA: 0x67FA480
        public void HashLength4To8(){} // RVA: 0x67FA4F0
        public void HashLength9To16(){} // RVA: 0x67FA580
        public void HashLength17To128(){} // RVA: 0x67FA670
        public void HashLength129To240(){} // RVA: 0x67FAAC0
        public void HashLengthOver240(){} // RVA: 0x67FB250
    }

    public class XxHash64
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x67FB430
        public void Append(){} // RVA: 0x67FB4C0
        public void Avalanche(){} // RVA: 0x67FB8F0
    }

    public class XxHashShared
    {
        // ── Methods ──
        public void get_DefaultSecret(){} // RVA: 0x67FBC70
        public void Initialize(){} // RVA: 0x67FBCD0
        public void Reset(){} // RVA: 0x67FBE80
        public void Rrmxmx(){} // RVA: 0x67FBF00
        public void HashInternalLoop(){} // RVA: 0x67FBF60
        public void ConsumeStripes(){} // RVA: 0x67FC020
        public void Append(){} // RVA: 0x67FC120
        public void CopyAccumulators(){} // RVA: 0x67FC760
        public void DigestLong(){} // RVA: 0x67FC7B0
        public void InitializeAccumulators(){} // RVA: 0x67FCA00
        public void MergeAccumulators(){} // RVA: 0x67FCA70
        public void Mix16Bytes(){} // RVA: 0x67FCC70
        public void Multiply32To64(){} // RVA: 0x5E1ECE0
        public void Avalanche(){} // RVA: 0x67FCCF0
        public void Multiply64To128(){} // RVA: 0x67FCD20
        public void Multiply64To128ThenFold(){} // RVA: 0x67FCD90
        public void DeriveSecretFromSeed(){} // RVA: 0x67FCDF0
        public void Accumulate(){} // RVA: 0x67FCEA0
        public void Accumulate512(){} // RVA: 0x67FCFE0
        public void Accumulate512Inlined(){} // RVA: 0x67FCFF0
        public void ScrambleAccumulators(){} // RVA: 0x67FD070
        public void XorShift(){} // RVA: 0x67FD0B0
        public void ReadUInt32LE(){} // RVA: 0x67FD0D0
        public void ReadUInt64LE(){} // RVA: 0x2738C50
        public void WriteUInt64LE(){} // RVA: 0x5F18490
    }

}