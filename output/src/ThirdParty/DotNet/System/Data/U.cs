// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Data
// Classes: 2
// Methods: 33

namespace ThirdParty.DotNet.System.Data
{
    public class UnaryNode : ExpressionNode
    {
        public object _op;
        public object _right;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x69C9EA0
        public void Bind(){} // RVA: 0x718C490
        public void Eval(){} // RVA: 0x718C560
        public void EvalUnaryOp(){} // RVA: 0x718C590
        public void IsConstant(){} // RVA: 0x718D430
        public void IsTableConstant(){} // RVA: 0x4219980
        public void HasLocalAggregate(){} // RVA: 0x718D460
        public void HasRemoteAggregate(){} // RVA: 0x718D490
        public void DependsOn(){} // RVA: 0x718D4C0
        public void Optimize(){} // RVA: 0x718D4F0
    }

    public class UniqueConstraint : Constraint
    {
        public object _key;
        public object _constraintIndex;
        public object _bPrimaryKey;
        public object _constraintName;
        public object _columnNames;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x719E180
        public void get_ColumnNames(){} // RVA: 0x719E1D0
        public void get_ConstraintIndex(){} // RVA: 0xBC1B30
        public void ConstraintIndexClear(){} // RVA: 0x719E1E0
        public void ConstraintIndexInitialize(){} // RVA: 0x719E260
        public void CheckState(){} // RVA: 0x719E350
        public void NonVirtualCheckState(){} // RVA: 0x719E350
        public void CheckCanAddToCollection(){} // RVA: 0xB43310
        public void CanBeRemovedFromCollection(){} // RVA: 0x719E360
        public void CanEnableConstraint(){} // RVA: 0x719E510
        public void IsConstraintViolated(){} // RVA: 0x719E5B0
        public void CheckConstraint(){} // RVA: 0x719E890
        public void ContainsColumn(){} // RVA: 0x719EAC0
        public void Clone(){} // RVA: 0x719F000
        public void get_Columns(){} // RVA: 0x719F420
        public void get_ColumnsReference(){} // RVA: 0xD05CA0
        public void get_IsPrimaryKey(){} // RVA: 0x719F430
        public void Create(){} // RVA: 0x719F490
        public void Equals(){} // RVA: 0x719F5E0
        public void GetHashCode(){} // RVA: 0x66DC010
        public void set_InCollection(){} // RVA: 0x719F6A0
        public void get_Key(){} // RVA: 0xD05CA0
        public void get_Table(){} // RVA: 0x719F760
    }

}