// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Data
// Classes: 4
// Methods: 58

namespace ThirdParty.DotNet.System.Data
{
    public class ForeignKeyConstraint : Constraint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE5142E0
        public void get_ChildKey(){} // RVA: 0x7AE514490
        public void get_Columns(){} // RVA: 0x7AE5144B0
        public void get_Table(){} // RVA: 0x7AE5144D0
        public void get_ParentColumnNames(){} // RVA: 0x7AE514510
        public void get_ChildColumnNames(){} // RVA: 0x7AE514520
        public void CheckCanAddToCollection(){} // RVA: 0x7AE514530
        public void CanBeRemovedFromCollection(){} // RVA: 0x7A81BD750
        public void IsKeyNull(){} // RVA: 0x7AE5146B0
        public void IsConstraintViolated(){} // RVA: 0x7AE514760
        public void CanEnableConstraint(){} // RVA: 0x7AE514A40
        public void CascadeCommit(){} // RVA: 0x7AE514BF0
        public void CascadeDelete(){} // RVA: 0x7AE514D80
        public void CascadeRollback(){} // RVA: 0x7AE515410
        public void CascadeUpdate(){} // RVA: 0x7AE515670
        public void CheckCanClearParentTable(){} // RVA: 0x7AE515CF0
        public void CheckCanRemoveParentRow(){} // RVA: 0x7AE515E00
        public void CheckCascade(){} // RVA: 0x7AE515EC0
        public void CheckConstraint(){} // RVA: 0x7AE5161D0
        public void NonVirtualCheckState(){} // RVA: 0x7AE5165D0
        public void CheckState(){} // RVA: 0x7AE5168B0
        public void get_AcceptRejectRule(){} // RVA: 0x7AE5168C0
        public void set_AcceptRejectRule(){} // RVA: 0x7AE5168E0
        public void ContainsColumn(){} // RVA: 0x7AE516930
        public void Clone(){} // RVA: 0x7AE5170D0
        public void Create(){} // RVA: 0x7AE517690
        public void get_DeleteRule(){} // RVA: 0x7AE5178B0
        public void set_DeleteRule(){} // RVA: 0x7AE5178D0
        public void Equals(){} // RVA: 0x7AE517920
        public void GetHashCode(){} // RVA: 0x7ADA51890
        public void get_RelatedColumns(){} // RVA: 0x7AE517A40
        public void get_RelatedColumnsReference(){} // RVA: 0x7AE517A60
        public void get_ParentKey(){} // RVA: 0x7AE517A60
        public void FindParentRelation(){} // RVA: 0x7AE517A80
        public void get_RelatedTable(){} // RVA: 0x7AE517B70
        public void get_UpdateRule(){} // RVA: 0x7AE517BB0
        public void set_UpdateRule(){} // RVA: 0x7AE517BD0
    }

    public class ForeignKeyConstraintEnumerator : ConstraintEnumerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE4E0590
        public void IsValidCandidate(){} // RVA: 0x7AE4E05A0
        public void GetForeignKeyConstraint(){} // RVA: 0x7AE4E0620
    }

    public class Function : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE4D5C10
        public void .cctor(){} // RVA: 0x7AE4D5EC0
    }

    public class FunctionNode : ExpressionNode
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE4D03D0
        public void AddArgument(){} // RVA: 0x7AE4D0750
        public void Bind(){} // RVA: 0x7AE4D09F0
        public void Eval(){} // RVA: 0x7AE4D19B0
        public void IsConstant(){} // RVA: 0x7AE4D19F0
        public void IsTableConstant(){} // RVA: 0x7AE4D1A80
        public void HasLocalAggregate(){} // RVA: 0x7AE4D1B10
        public void HasRemoteAggregate(){} // RVA: 0x7AE4D1BA0
        public void DependsOn(){} // RVA: 0x7AE4D1C30
        public void Optimize(){} // RVA: 0x7AE4D1CC0
        public void GetDataType(){} // RVA: 0x7AE4D2050
        public void EvalFunction(){} // RVA: 0x7AE4D2420
        public void get_Aggregate(){} // RVA: 0x7AE4D42B0
        public void get_IsAggregate(){} // RVA: 0x7AE4D4350
        public void Check(){} // RVA: 0x7AE4D45A0
        public void .cctor(){} // RVA: 0x7AE4D4810
    }

}