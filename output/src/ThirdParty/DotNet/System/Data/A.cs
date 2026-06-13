// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Data
// Classes: 4
// Methods: 51

namespace ThirdParty.DotNet.System.Data
{
    public class AggregateNode
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6713A00 | overloaded x2
        public void Bind(){} // RVA: 0x6714160 | overloaded x2
        public void Eval(){} // RVA: 0x6714690 | overloaded x3
        public void IsConstant(){} // RVA: 0x2DD320
        public void IsTableConstant(){} // RVA: 0x3CB9D0
        public void HasLocalAggregate(){} // RVA: 0x3CB9D0
        public void HasRemoteAggregate(){} // RVA: 0x7644F0
        public void DependsOn(){} // RVA: 0x6714730
        public void Optimize(){} // RVA: 0x1A3F520
    }

    public class AutoIncrementBigInteger
    {
        public System.Numerics.BigInteger _current; // 0x18
        public long _seed; // 0x28
        public System.Numerics.BigInteger _step; // 0x30

        // ── Methods ──
        public void get_Current(){} // RVA: 0x66CB670
        public void set_Current(){} // RVA: 0x66CB6C0
        public void get_DataType(){} // RVA: 0x66CB780
        public void get_Seed(){} // RVA: 0x30B130
        public void set_Seed(){} // RVA: 0x66CB830
        public void get_Step(){} // RVA: 0x66CBA10
        public void set_Step(){} // RVA: 0x66CBA80
        public void MoveAfter(){} // RVA: 0x66CBDA0
        public void SetCurrent(){} // RVA: 0x66CBE80
        public void SetCurrentAndIncrement(){} // RVA: 0x66CBEF0
        public void BoundaryCheck(){} // RVA: 0x66CC030
        public void .ctor(){} // RVA: 0x66CC310
    }

    public class AutoIncrementInt64
    {
        public long _current; // 0x18
        public long _seed; // 0x20
        public long _step; // 0x28

        // ── Methods ──
        public void get_Current(){} // RVA: 0x66CAF10
        public void set_Current(){} // RVA: 0x66CAF60
        public void get_DataType(){} // RVA: 0x66CAFD0
        public void get_Seed(){} // RVA: 0x30B0C0
        public void set_Seed(){} // RVA: 0x66CB080
        public void get_Step(){} // RVA: 0x30B130
        public void set_Step(){} // RVA: 0x66CB120
        public void MoveAfter(){} // RVA: 0x66CB1B0
        public void SetCurrent(){} // RVA: 0x66CB1C0
        public void SetCurrentAndIncrement(){} // RVA: 0x66CB230
        public void BoundaryCheck(){} // RVA: 0x66CB430
        public void .ctor(){} // RVA: 0x66CB660
    }

    public class AutoIncrementValue
    {
        public bool <Auto>k__BackingField; // 0x10

        // ── Methods ──
        public void get_Auto(){} // RVA: 0x3A75E0
        public void set_Auto(){} // RVA: 0x3A75F0
        public void get_Current(){} // RVA: 0xCD60
        public void set_Current(){} // RVA: 0x24B10
        public void get_Seed(){} // RVA: 0xCD60
        public void set_Seed(){} // RVA: 0x24CC0
        public void get_Step(){} // RVA: 0xCD60
        public void set_Step(){} // RVA: 0x24CC0
        public void get_DataType(){} // RVA: 0xCD60
        public void SetCurrent(){} // RVA: 0x2DC60
        public void SetCurrentAndIncrement(){} // RVA: 0x24B10
        public void MoveAfter(){} // RVA: 0x24A50
        public void Clone(){} // RVA: 0x66CADD0
        public void .ctor(){} // RVA: 0x2DD310
    }

}