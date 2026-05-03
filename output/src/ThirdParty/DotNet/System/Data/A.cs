// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Data
// Classes: 4
// Methods: 51

namespace ThirdParty.DotNet.System.Data
{
    public class AggregateNode : ExpressionNode
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE872528F0 | overloaded x2
        public void Bind(){} // RVA: 0x7FFE87253050 | overloaded x2
        public void Eval(){} // RVA: 0x7FFE87253580 | overloaded x3
        public void IsConstant(){} // RVA: 0x7FFE810FB320
        public void IsTableConstant(){} // RVA: 0x7FFE811E99D0
        public void HasLocalAggregate(){} // RVA: 0x7FFE811E99D0
        public void HasRemoteAggregate(){} // RVA: 0x7FFE87253620
        public void DependsOn(){} // RVA: 0x7FFE87253630
        public void Optimize(){} // RVA: 0x7FFE827C4A80
    }

    public class AutoIncrementBigInteger : AutoIncrementValue
    {
        public System.Numerics.BigInteger _current; // 0x18
        public long _seed; // 0x28
        public System.Numerics.BigInteger _step; // 0x30
        public object field_3; // 0x34

        // ── Methods ──
        public void get_Current(){} // RVA: 0x7FFE8720A560
        public void set_Current(){} // RVA: 0x7FFE8720A5B0
        public void get_DataType(){} // RVA: 0x7FFE8720A670
        public void get_Seed(){} // RVA: 0x7FFE81129130
        public void set_Seed(){} // RVA: 0x7FFE8720A720
        public void get_Step(){} // RVA: 0x7FFE8720A900
        public void set_Step(){} // RVA: 0x7FFE8720A970
        public void MoveAfter(){} // RVA: 0x7FFE8720AC90
        public void SetCurrent(){} // RVA: 0x7FFE8720AD70
        public void SetCurrentAndIncrement(){} // RVA: 0x7FFE8720ADE0
        public void BoundaryCheck(){} // RVA: 0x7FFE8720AF20
        public void .ctor(){} // RVA: 0x7FFE8720B200
    }

    public class AutoIncrementInt64 : AutoIncrementValue
    {
        public long _current; // 0x18
        public long _seed; // 0x20
        public long _step; // 0x28
        public object field_3; // 0x30

        // ── Methods ──
        public void get_Current(){} // RVA: 0x7FFE87209E00
        public void set_Current(){} // RVA: 0x7FFE87209E50
        public void get_DataType(){} // RVA: 0x7FFE87209EC0
        public void get_Seed(){} // RVA: 0x7FFE811290C0
        public void set_Seed(){} // RVA: 0x7FFE87209F70
        public void get_Step(){} // RVA: 0x7FFE81129130
        public void set_Step(){} // RVA: 0x7FFE8720A010
        public void MoveAfter(){} // RVA: 0x7FFE8720A0A0
        public void SetCurrent(){} // RVA: 0x7FFE8720A0B0
        public void SetCurrentAndIncrement(){} // RVA: 0x7FFE8720A120
        public void BoundaryCheck(){} // RVA: 0x7FFE8720A320
        public void .ctor(){} // RVA: 0x7FFE8720A550
    }

    public class AutoIncrementValue : Object
    {
        public bool _auto; // 0x10
        public object field_1; // 0x2B
        public object field_2; // 0x2C
        public object field_3; // 0x2D
        public object field_4; // 0x2E

        // ── Methods ──
        public void get_Auto(){} // RVA: 0x7FFE811C55E0
        public void set_Auto(){} // RVA: 0x7FFE811C55F0
        public void get_Current(){} // RVA: 0x7FFE80E2E2E0
        public void set_Current(){} // RVA: 0x7FFE80E460A0
        public void get_Seed(){} // RVA: 0x7FFE80E2E2E0
        public void set_Seed(){} // RVA: 0x7FFE80E46250
        public void get_Step(){} // RVA: 0x7FFE80E2E2E0
        public void set_Step(){} // RVA: 0x7FFE80E46250
        public void get_DataType(){} // RVA: 0x7FFE80E2E2E0
        public void SetCurrent(){} // RVA: 0x7FFE80E4F230
        public void SetCurrentAndIncrement(){} // RVA: 0x7FFE80E460A0
        public void MoveAfter(){} // RVA: 0x7FFE80E45FE0
        public void Clone(){} // RVA: 0x7FFE87209CC0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

}