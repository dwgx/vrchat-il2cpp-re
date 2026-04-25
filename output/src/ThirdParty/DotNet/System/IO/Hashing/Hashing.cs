// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.IO.Hashing
// Classes: 4
// Methods: 45

namespace ThirdParty.DotNet.System.IO.Hashing
{
    public class NonCryptographicHashAlgorithm : Object
    {
        public int <HashLengthInBytes>k__BackingField; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F909F0
        public void Append(){}
        public void Reset(){} // RVA: 0x7FFAC2C70980
        public void GetHashCode(){} // RVA: 0x7FFAC8F90A60
    }

    public class XxHash3 : NonCryptographicHashAlgorithm
    {
        public State _state; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F90C70 | overloaded x2
        public void HashToUInt64(){} // RVA: 0x7FFAC8F90E20
        public void Reset(){} // RVA: 0x7FFAC8F90EC0
        public void Append(){} // RVA: 0x7FFAC8F90F40
        public void GetCurrentHashAsUInt64(){} // RVA: 0x7FFAC8F90F70
        public void HashLength0To16(){} // RVA: 0x7FFAC8F91140
        public void HashLength1To3(){} // RVA: 0x7FFAC8F91340
        public void HashLength4To8(){} // RVA: 0x7FFAC8F913B0
        public void HashLength9To16(){} // RVA: 0x7FFAC8F91440
        public void HashLength17To128(){} // RVA: 0x7FFAC8F91530
        public void HashLength129To240(){} // RVA: 0x7FFAC8F91980
        public void HashLengthOver240(){} // RVA: 0x7FFAC8F92110
    }

    public class XxHash64 : NonCryptographicHashAlgorithm
    {
        public ulong _seed; // 0x18
        public State _state; // 0x20
        public byte[] _holdback; // 0x50
        public long _length; // 0x58

        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAC8F922F0
        public void Append(){} // RVA: 0x7FFAC8F92380
        public void Avalanche(){} // RVA: 0x7FFAC8F927B0
    }

    public class XxHashShared : Object
    {
        public object DefaultSecret;

        // ── Methods ──
        public void get_DefaultSecret(){} // RVA: 0x7FFAC8F92B30
        public void Initialize(){} // RVA: 0x7FFAC8F92B90
        public void Reset(){} // RVA: 0x7FFAC8F92D40
        public void Rrmxmx(){} // RVA: 0x7FFAC8F92DC0
        public void HashInternalLoop(){} // RVA: 0x7FFAC8F92E20
        public void ConsumeStripes(){} // RVA: 0x7FFAC8F92EE0
        public void Append(){} // RVA: 0x7FFAC8F92FE0
        public void CopyAccumulators(){} // RVA: 0x7FFAC8F93620
        public void DigestLong(){} // RVA: 0x7FFAC8F93670
        public void InitializeAccumulators(){} // RVA: 0x7FFAC8F938C0
        public void MergeAccumulators(){} // RVA: 0x7FFAC8F93930
        public void Mix16Bytes(){} // RVA: 0x7FFAC8F93B30
        public void Multiply32To64(){} // RVA: 0x7FFAC85B6350
        public void Avalanche(){} // RVA: 0x7FFAC8F93BB0
        public void Multiply64To128(){} // RVA: 0x7FFAC8F93BE0
        public void Multiply64To128ThenFold(){} // RVA: 0x7FFAC8F93C50
        public void DeriveSecretFromSeed(){} // RVA: 0x7FFAC8F93CB0
        public void Accumulate(){} // RVA: 0x7FFAC8F93D60
        public void Accumulate512(){} // RVA: 0x7FFAC8F93EA0
        public void Accumulate512Inlined(){} // RVA: 0x7FFAC8F93EB0
        public void ScrambleAccumulators(){} // RVA: 0x7FFAC8F93F30
        public void XorShift(){} // RVA: 0x7FFAC8F93F70
        public void ReadUInt32LE(){} // RVA: 0x7FFAC8F93F90
        public void ReadUInt64LE(){} // RVA: 0x7FFAC51D9A30
        public void WriteUInt64LE(){} // RVA: 0x7FFAC86AFB00
    }

}