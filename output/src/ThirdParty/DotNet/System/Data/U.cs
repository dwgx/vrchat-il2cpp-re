// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Data
// Classes: 2
// Methods: 41

namespace ThirdParty.DotNet.System.Data
{
    public class UnaryNode : ExpressionNode
    {
        public int _op; // 0x18
        public System.Data.ExpressionNode _right; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC86E9F50
        public void Bind(){} // RVA: 0x7FFAC8EBB300
        public void Eval(){} // RVA: 0x7FFAC8EBB3D0 | overloaded x3
        public void EvalUnaryOp(){} // RVA: 0x7FFAC8EBB400
        public void IsConstant(){} // RVA: 0x7FFAC8EBC2E0
        public void IsTableConstant(){} // RVA: 0x7FFAC623DF40
        public void HasLocalAggregate(){} // RVA: 0x7FFAC8EBC310
        public void HasRemoteAggregate(){} // RVA: 0x7FFAC8EBC340
        public void DependsOn(){} // RVA: 0x7FFAC8EBC370
        public void Optimize(){} // RVA: 0x7FFAC8EBC3A0
    }

    public class UniqueConstraint : Constraint
    {
        public System.Data.DataKey ColumnNames; // 0x38
        public System.Data.Index ConstraintIndex; // 0x40
        public bool Columns; // 0x48
        public string ColumnsReference; // 0x50
        public string[] IsPrimaryKey; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8ECD360 | overloaded x5
        public void get_ColumnNames(){} // RVA: 0x7FFAC8ECD3B0
        public void get_ConstraintIndex(){} // RVA: 0x7FFAC2F9E740
        public void ConstraintIndexClear(){} // RVA: 0x7FFAC8ECD3C0
        public void ConstraintIndexInitialize(){} // RVA: 0x7FFAC8ECD440
        public void CheckState(){} // RVA: 0x7FFAC8ECD530
        public void NonVirtualCheckState(){} // RVA: 0x7FFAC8ECD530
        public void CheckCanAddToCollection(){} // RVA: 0x7FFAC2F21310
        public void CanBeRemovedFromCollection(){} // RVA: 0x7FFAC8ECD540
        public void CanEnableConstraint(){} // RVA: 0x7FFAC8ECD6F0
        public void IsConstraintViolated(){} // RVA: 0x7FFAC8ECD790
        public void CheckConstraint(){} // RVA: 0x7FFAC8ECDA50
        public void ContainsColumn(){} // RVA: 0x7FFAC8ECDC90
        public void Clone(){} // RVA: 0x7FFAC8ECE1E0 | overloaded x3
        public void get_Columns(){} // RVA: 0x7FFAC8ECE610
        public void get_ColumnsReference(){} // RVA: 0x7FFAC31D0140
        public void get_IsPrimaryKey(){} // RVA: 0x7FFAC8ECE620
        public void Create(){} // RVA: 0x7FFAC8ECE680
        public void Equals(){} // RVA: 0x7FFAC8ECE7D0
        public void GetHashCode(){} // RVA: 0x7FFAC83FAE70
        public void set_InCollection(){} // RVA: 0x7FFAC8ECE890
        public void get_Key(){} // RVA: 0x7FFAC31D0140
        public void get_Table(){} // RVA: 0x7FFAC8ECE950
    }

}