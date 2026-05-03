// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Data
// Classes: 2
// Methods: 41

namespace ThirdParty.DotNet.System.Data
{
    public class UnaryNode : ExpressionNode
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86A93700
        public void Bind(){} // RVA: 0x7FFE87263750
        public void Eval(){} // RVA: 0x7FFE87263820 | overloaded x3
        public void EvalUnaryOp(){} // RVA: 0x7FFE87263850
        public void IsConstant(){} // RVA: 0x7FFE87264730
        public void IsTableConstant(){} // RVA: 0x7FFE8453CE10
        public void HasLocalAggregate(){} // RVA: 0x7FFE87264760
        public void HasRemoteAggregate(){} // RVA: 0x7FFE87264790
        public void DependsOn(){} // RVA: 0x7FFE872647C0
        public void Optimize(){} // RVA: 0x7FFE872647F0
    }

    public class UniqueConstraint : Constraint
    {
        public System.Data.DataKey _key; // 0x38
        public System.Data.Index _constraintIndex; // 0x40
        public bool _bPrimaryKey; // 0x48
        public string _constraintName; // 0x50
        public string[] _columnNames; // 0x58
        public object field_5; // 0x143
        public object field_6; // 0x144
        public object field_7; // 0x145

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE872757B0 | overloaded x5
        public void get_ColumnNames(){} // RVA: 0x7FFE87275800
        public void get_ConstraintIndex(){} // RVA: 0x7FFE81178740
        public void ConstraintIndexClear(){} // RVA: 0x7FFE87275810
        public void ConstraintIndexInitialize(){} // RVA: 0x7FFE87275890
        public void CheckState(){} // RVA: 0x7FFE87275980
        public void NonVirtualCheckState(){} // RVA: 0x7FFE87275980
        public void CheckCanAddToCollection(){} // RVA: 0x7FFE810FB310
        public void CanBeRemovedFromCollection(){} // RVA: 0x7FFE87275990
        public void CanEnableConstraint(){} // RVA: 0x7FFE87275B40
        public void IsConstraintViolated(){} // RVA: 0x7FFE87275BE0
        public void CheckConstraint(){} // RVA: 0x7FFE87275EA0
        public void ContainsColumn(){} // RVA: 0x7FFE872760E0
        public void Clone(){} // RVA: 0x7FFE87276630 | overloaded x3
        public void get_Columns(){} // RVA: 0x7FFE87276A60
        public void get_ColumnsReference(){} // RVA: 0x7FFE8143BA80
        public void get_IsPrimaryKey(){} // RVA: 0x7FFE87276A70
        public void Create(){} // RVA: 0x7FFE87276AD0
        public void Equals(){} // RVA: 0x7FFE87276C20
        public void GetHashCode(){} // RVA: 0x7FFE867A47B0
        public void set_InCollection(){} // RVA: 0x7FFE87276CE0
        public void get_Key(){} // RVA: 0x7FFE8143BA80
        public void get_Table(){} // RVA: 0x7FFE87276DA0
    }

}