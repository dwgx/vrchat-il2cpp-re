// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.IO.Hashing
// Classes: 4
// Methods: 45

namespace ThirdParty.DotNet.System.IO.Hashing
{
    public class NonCryptographicHashAlgorithm : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87338E10
        public void Append(){}
        public void Reset(){} // RVA: 0x7FFE80E45FE0
        public void GetHashCode(){} // RVA: 0x7FFE87338E80
    }

    public class XxHash3 : NonCryptographicHashAlgorithm
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87339090 | overloaded x2
        public void HashToUInt64(){} // RVA: 0x7FFE87339240
        public void Reset(){} // RVA: 0x7FFE873392E0
        public void Append(){} // RVA: 0x7FFE87339360
        public void GetCurrentHashAsUInt64(){} // RVA: 0x7FFE87339390
        public void HashLength0To16(){} // RVA: 0x7FFE87339560
        public void HashLength1To3(){} // RVA: 0x7FFE87339760
        public void HashLength4To8(){} // RVA: 0x7FFE873397D0
        public void HashLength9To16(){} // RVA: 0x7FFE87339860
        public void HashLength17To128(){} // RVA: 0x7FFE87339950
        public void HashLength129To240(){} // RVA: 0x7FFE87339DA0
        public void HashLengthOver240(){} // RVA: 0x7FFE8733A530
    }

    public class XxHash64 : NonCryptographicHashAlgorithm
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFE8733A710
        public void Append(){} // RVA: 0x7FFE8733A7A0
        public void Avalanche(){} // RVA: 0x7FFE8733ABD0
    }

    public class XxHashShared : Object
    {
        // ── Methods ──
        public void get_DefaultSecret(){} // RVA: 0x7FFE8733AF50
        public void Initialize(){} // RVA: 0x7FFE8733AFB0
        public void Reset(){} // RVA: 0x7FFE8733B160
        public void Rrmxmx(){} // RVA: 0x7FFE8733B1E0
        public void HashInternalLoop(){} // RVA: 0x7FFE8733B240
        public void ConsumeStripes(){} // RVA: 0x7FFE8733B300
        public void Append(){} // RVA: 0x7FFE8733B400
        public void CopyAccumulators(){} // RVA: 0x7FFE8733BA40
        public void DigestLong(){} // RVA: 0x7FFE8733BA90
        public void InitializeAccumulators(){} // RVA: 0x7FFE8733BCE0
        public void MergeAccumulators(){} // RVA: 0x7FFE8733BD50
        public void Mix16Bytes(){} // RVA: 0x7FFE8733BF50
        public void Multiply32To64(){} // RVA: 0x7FFE8695FB20
        public void Avalanche(){} // RVA: 0x7FFE8733BFD0
        public void Multiply64To128(){} // RVA: 0x7FFE8733C000
        public void Multiply64To128ThenFold(){} // RVA: 0x7FFE8733C070
        public void DeriveSecretFromSeed(){} // RVA: 0x7FFE8733C0D0
        public void Accumulate(){} // RVA: 0x7FFE8733C180
        public void Accumulate512(){} // RVA: 0x7FFE8733C2C0
        public void Accumulate512Inlined(){} // RVA: 0x7FFE8733C2D0
        public void ScrambleAccumulators(){} // RVA: 0x7FFE8733C350
        public void XorShift(){} // RVA: 0x7FFE8733C390
        public void ReadUInt32LE(){} // RVA: 0x7FFE8733C3B0
        public void ReadUInt64LE(){} // RVA: 0x7FFE8348B260
        public void WriteUInt64LE(){} // RVA: 0x7FFE86A592B0
    }

}