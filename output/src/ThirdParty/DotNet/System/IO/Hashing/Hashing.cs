// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.IO.Hashing
// Classes: 4
// Methods: 44

namespace ThirdParty.DotNet.System.IO.Hashing
{
    public class NonCryptographicHashAlgorithm : Object
    {
        public object _hashLengthInBytes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x725EDB0
        public void Append(){} // RVA: 0x894320
        public void Reset(){} // RVA: 0x894290
        public void GetHashCode(){} // RVA: 0x725EE20
    }

    public class XxHash3 : NonCryptographicHashAlgorithm
    {
        public object _state;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x725F030
        public void HashToUInt64(){} // RVA: 0x725F1E0
        public void Reset(){} // RVA: 0x725F280
        public void Append(){} // RVA: 0x725F300
        public void GetCurrentHashAsUInt64(){} // RVA: 0x725F330
        public void HashLength0To16(){} // RVA: 0x725F500
        public void HashLength1To3(){} // RVA: 0x725F710
        public void HashLength4To8(){} // RVA: 0x725F780
        public void HashLength9To16(){} // RVA: 0x725F810
        public void HashLength17To128(){} // RVA: 0x725F8F0
        public void HashLength129To240(){} // RVA: 0x725FD60
        public void HashLengthOver240(){} // RVA: 0x72606E0
    }

    public class XxHash64 : NonCryptographicHashAlgorithm
    {
        public object _seed;
        public object _state;
        public object _holdback;
        public object _length;

        // ── Methods ──
        public void Reset(){} // RVA: 0x72608C0
        public void Append(){} // RVA: 0x7260950
        public void Avalanche(){} // RVA: 0x7260D80
    }

    public class XxHashShared : Object
    {
        // ── Methods ──
        public void get_DefaultSecret(){} // RVA: 0x7261100
        public void Initialize(){} // RVA: 0x7261160
        public void Reset(){} // RVA: 0x7261310
        public void Rrmxmx(){} // RVA: 0x7261390
        public void HashInternalLoop(){} // RVA: 0x72613F0
        public void ConsumeStripes(){} // RVA: 0x72614B0
        public void Append(){} // RVA: 0x7261660
        public void CopyAccumulators(){} // RVA: 0x7261D20
        public void DigestLong(){} // RVA: 0x7261D70
        public void InitializeAccumulators(){} // RVA: 0x7261FC0
        public void MergeAccumulators(){} // RVA: 0x7262030
        public void Mix16Bytes(){} // RVA: 0x7262270
        public void Multiply32To64(){} // RVA: 0x6898710
        public void Avalanche(){} // RVA: 0x72622E0
        public void Multiply64To128(){} // RVA: 0x7262310
        public void Multiply64To128ThenFold(){} // RVA: 0x7262380
        public void DeriveSecretFromSeed(){} // RVA: 0x72623E0
        public void Accumulate(){} // RVA: 0x7262490
        public void Accumulate512(){} // RVA: 0x72625A0
        public void Accumulate512Inlined(){} // RVA: 0x72625B0
        public void ScrambleAccumulators(){} // RVA: 0x7262630
        public void XorShift(){} // RVA: 0x7262710
        public void ReadUInt32LE(){} // RVA: 0x4B9D160
        public void ReadUInt64LE(){} // RVA: 0x3174AF0
        public void WriteUInt64LE(){} // RVA: 0x698FD90
    }

}