// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Data
// Classes: 4
// Methods: 47

namespace ThirdParty.DotNet.System.Data
{
    public class AggregateNode : ExpressionNode
    {
        public object _type;
        public object _aggregate;
        public object _local;
        public object _relationName;
        public object _columnName;
        public object _childTable;
        public object _column;
        public object _relation;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x717B9A0
        public void Bind(){} // RVA: 0x717C120
        public void Eval(){} // RVA: 0x717C640
        public void IsConstant(){} // RVA: 0xB43320
        public void IsTableConstant(){} // RVA: 0xC38360
        public void HasLocalAggregate(){} // RVA: 0xC38360
        public void HasRemoteAggregate(){} // RVA: 0xFEF690
        public void DependsOn(){} // RVA: 0x717C6E0
        public void Optimize(){} // RVA: 0x2303260
    }

    public class AutoIncrementBigInteger : AutoIncrementValue
    {
        public object _current;
        public object _seed;
        public object _step;

        // ── Methods ──
        public void get_Current(){} // RVA: 0x7134EB0
        public void set_Current(){} // RVA: 0x7134F00
        public void get_DataType(){} // RVA: 0x7134FC0
        public void get_Seed(){} // RVA: 0xB70160
        public void set_Seed(){} // RVA: 0x7135040
        public void get_Step(){} // RVA: 0x7135220
        public void set_Step(){} // RVA: 0x7135290
        public void MoveAfter(){} // RVA: 0x71355D0
        public void SetCurrent(){} // RVA: 0x71356B0
        public void SetCurrentAndIncrement(){} // RVA: 0x7135720
        public void BoundaryCheck(){} // RVA: 0x7135860
        public void .ctor(){} // RVA: 0x7135B40
    }

    public class AutoIncrementInt64 : AutoIncrementValue
    {
        public object _current;
        public object _seed;
        public object _step;

        // ── Methods ──
        public void get_Current(){} // RVA: 0x6D1FC70
        public void set_Current(){} // RVA: 0x7134870
        public void get_DataType(){} // RVA: 0x71348B0
        public void get_Seed(){} // RVA: 0xB700F0
        public void set_Seed(){} // RVA: 0x7134910
        public void get_Step(){} // RVA: 0xB70160
        public void set_Step(){} // RVA: 0x71349B0
        public void MoveAfter(){} // RVA: 0x7134A40
        public void SetCurrent(){} // RVA: 0x7134A50
        public void SetCurrentAndIncrement(){} // RVA: 0x7134AC0
        public void BoundaryCheck(){} // RVA: 0x7134C70
        public void .ctor(){} // RVA: 0x7134EA0
    }

    public class AutoIncrementValue : Object
    {
        public object _auto;

        // ── Methods ──
        public void get_Auto(){} // RVA: 0xC120A0
        public void set_Auto(){} // RVA: 0xC120B0
        public void get_Current(){} // RVA: 0x87C0A0
        public void set_Current(){} // RVA: 0x894320
        public void get_Seed(){} // RVA: 0x87C0A0
        public void set_Seed(){} // RVA: 0x8943F0
        public void get_Step(){} // RVA: 0x87C0A0
        public void set_Step(){} // RVA: 0x8943F0
        public void get_DataType(){} // RVA: 0x87C0A0
        public void SetCurrent(){} // RVA: 0x8943B0
        public void SetCurrentAndIncrement(){} // RVA: 0x894320
        public void MoveAfter(){} // RVA: 0x894290
        public void Clone(){} // RVA: 0x7134730
        public void .ctor(){} // RVA: 0xB43310
    }

}