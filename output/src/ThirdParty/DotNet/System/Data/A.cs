// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Data
// Classes: 4
// Methods: 51

namespace ThirdParty.DotNet.System.Data
{
    public class AggregateNode : ExpressionNode
    {
        public 0x6B1CE248 _type; // 0x18
        public 0x6B1CF4D8 _aggregate; // 0x1C
        public bool _local; // 0x20
        public string _relationName; // 0x28
        public string _columnName; // 0x30
        public System.Data.DataTable _childTable; // 0x38
        public System.Data.DataColumn _column; // 0x40
        public System.Data.DataRelation _relation; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8EAA4C0 | overloaded x2
        public void Bind(){} // RVA: 0x7FFAC8EAAC20 | overloaded x2
        public void Eval(){} // RVA: 0x7FFAC8EAB150 | overloaded x3
        public void IsConstant(){} // RVA: 0x7FFAC2F21320
        public void IsTableConstant(){} // RVA: 0x7FFAC300F9D0
        public void HasLocalAggregate(){} // RVA: 0x7FFAC300F9D0
        public void HasRemoteAggregate(){} // RVA: 0x7FFAC8EAB1F0
        public void DependsOn(){} // RVA: 0x7FFAC8EAB200
        public void Optimize(){} // RVA: 0x7FFAC44F81E0
    }

    public class AutoIncrementBigInteger : AutoIncrementValue
    {
        public System.Numerics.BigInteger Current; // 0x18
        public long DataType; // 0x28
        public System.Numerics.BigInteger Seed; // 0x30

        // ── Methods ──
        public void get_Current(){} // RVA: 0x7FFAC8E62130
        public void set_Current(){} // RVA: 0x7FFAC8E62180
        public void get_DataType(){} // RVA: 0x7FFAC8E62240
        public void get_Seed(){} // RVA: 0x7FFAC2F4F130
        public void set_Seed(){} // RVA: 0x7FFAC8E622F0
        public void get_Step(){} // RVA: 0x7FFAC8E624D0
        public void set_Step(){} // RVA: 0x7FFAC8E62540
        public void MoveAfter(){} // RVA: 0x7FFAC8E62860
        public void SetCurrent(){} // RVA: 0x7FFAC8E62940
        public void SetCurrentAndIncrement(){} // RVA: 0x7FFAC8E629B0
        public void BoundaryCheck(){} // RVA: 0x7FFAC8E62AF0
        public void .ctor(){} // RVA: 0x7FFAC8E62DD0
    }

    public class AutoIncrementInt64 : AutoIncrementValue
    {
        public long Current; // 0x18
        public long DataType; // 0x20
        public long Seed; // 0x28

        // ── Methods ──
        public void get_Current(){} // RVA: 0x7FFAC8E619D0
        public void set_Current(){} // RVA: 0x7FFAC8E61A20
        public void get_DataType(){} // RVA: 0x7FFAC8E61A90
        public void get_Seed(){} // RVA: 0x7FFAC2F4F0C0
        public void set_Seed(){} // RVA: 0x7FFAC8E61B40
        public void get_Step(){} // RVA: 0x7FFAC2F4F130
        public void set_Step(){} // RVA: 0x7FFAC8E61BE0
        public void MoveAfter(){} // RVA: 0x7FFAC8E61C70
        public void SetCurrent(){} // RVA: 0x7FFAC8E61C80
        public void SetCurrentAndIncrement(){} // RVA: 0x7FFAC8E61CF0
        public void BoundaryCheck(){} // RVA: 0x7FFAC8E61EF0
        public void .ctor(){} // RVA: 0x7FFAC8E62120
    }

    public class AutoIncrementValue : Object
    {
        public bool Auto; // 0x10

        // ── Methods ──
        public void get_Auto(){} // RVA: 0x7FFAC2FEB5E0
        public void set_Auto(){} // RVA: 0x7FFAC2FEB5F0
        public void get_Current(){} // RVA: 0x7FFAC2C58E90
        public void set_Current(){} // RVA: 0x7FFAC2C70A40
        public void get_Seed(){} // RVA: 0x7FFAC2C58E90
        public void set_Seed(){} // RVA: 0x7FFAC2C70BF0
        public void get_Step(){} // RVA: 0x7FFAC2C58E90
        public void set_Step(){} // RVA: 0x7FFAC2C70BF0
        public void get_DataType(){} // RVA: 0x7FFAC2C58E90
        public void SetCurrent(){} // RVA: 0x7FFAC2C79B30
        public void SetCurrentAndIncrement(){} // RVA: 0x7FFAC2C70A40
        public void MoveAfter(){} // RVA: 0x7FFAC2C70980
        public void Clone(){} // RVA: 0x7FFAC8E61890
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

}