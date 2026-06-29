// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.IO.Hashing
// Classes: 4
// Methods: 44

namespace ThirdParty.DotNet.System.IO.Hashing
{
    public class NonCryptographicHashAlgorithm : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE5E8390
        public void Append(){} // RVA: 0x7A7E18800
        public void Reset(){} // RVA: 0x7A7E18770
        public void GetHashCode(){} // RVA: 0x7AE5E8400
    }

    public class XxHash3 : NonCryptographicHashAlgorithm
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE5E8610
        public void HashToUInt64(){} // RVA: 0x7AE5E87C0
        public void Reset(){} // RVA: 0x7AE5E8860
        public void Append(){} // RVA: 0x7AE5E88E0
        public void GetCurrentHashAsUInt64(){} // RVA: 0x7AE5E8910
        public void HashLength0To16(){} // RVA: 0x7AE5E8AE0
        public void HashLength1To3(){} // RVA: 0x7AE5E8CF0
        public void HashLength4To8(){} // RVA: 0x7AE5E8D60
        public void HashLength9To16(){} // RVA: 0x7AE5E8DF0
        public void HashLength17To128(){} // RVA: 0x7AE5E8ED0
        public void HashLength129To240(){} // RVA: 0x7AE5E9340
        public void HashLengthOver240(){} // RVA: 0x7AE5E9CC0
    }

    public class XxHash64 : NonCryptographicHashAlgorithm
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7AE5E9EA0
        public void Append(){} // RVA: 0x7AE5E9F30
        public void Avalanche(){} // RVA: 0x7AE5EA360
    }

    public class XxHashShared : Object
    {
        // ── Methods ──
        public void get_DefaultSecret(){} // RVA: 0x7AE5EA6E0
        public void Initialize(){} // RVA: 0x7AE5EA740
        public void Reset(){} // RVA: 0x7AE5EA8F0
        public void Rrmxmx(){} // RVA: 0x7AE5EA970
        public void HashInternalLoop(){} // RVA: 0x7AE5EA9D0
        public void ConsumeStripes(){} // RVA: 0x7AE5EAA90
        public void Append(){} // RVA: 0x7AE5EAC40
        public void CopyAccumulators(){} // RVA: 0x7AE5EB300
        public void DigestLong(){} // RVA: 0x7AE5EB350
        public void InitializeAccumulators(){} // RVA: 0x7AE5EB5A0
        public void MergeAccumulators(){} // RVA: 0x7AE5EB610
        public void Mix16Bytes(){} // RVA: 0x7AE5EB850
        public void Multiply32To64(){} // RVA: 0x7ADC0D4C0
        public void Avalanche(){} // RVA: 0x7AE5EB8C0
        public void Multiply64To128(){} // RVA: 0x7AE5EB8F0
        public void Multiply64To128ThenFold(){} // RVA: 0x7AE5EB960
        public void DeriveSecretFromSeed(){} // RVA: 0x7AE5EB9C0
        public void Accumulate(){} // RVA: 0x7AE5EBA70
        public void Accumulate512(){} // RVA: 0x7AE5EBB80
        public void Accumulate512Inlined(){} // RVA: 0x7AE5EBB90
        public void ScrambleAccumulators(){} // RVA: 0x7AE5EBC10
        public void XorShift(){} // RVA: 0x7AE5EBCF0
        public void ReadUInt32LE(){} // RVA: 0x7AE5EBD10
        public void ReadUInt64LE(){} // RVA: 0x7AA54A2C0
        public void WriteUInt64LE(){} // RVA: 0x7ADD070D0
    }

}