// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Data
// Classes: 4
// Methods: 64

namespace ThirdParty.DotNet.System.Data
{
    public class ForeignKeyConstraint : Constraint
    {
        public 0x665C9CBC _deleteRule; // 0x38
        public 0x665C9CBC _updateRule; // 0x3C
        public 0x665C7AB4 _acceptRejectRule; // 0x40
        public System.Data.DataKey _childKey; // 0x48
        public System.Data.DataKey _parentKey; // 0x50
        public string _constraintName; // 0x58
        public string[] _parentColumnNames; // 0x60
        public string[] _childColumnNames; // 0x68
        public string _parentTableName; // 0x70
        public string _parentTableNamespace; // 0x78
        public object field_10; // 0x116
        public object field_11; // 0x117

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87264CF0 | overloaded x3
        public void get_ChildKey(){} // RVA: 0x7FFE87264EA0
        public void get_Columns(){} // RVA: 0x7FFE87264EC0
        public void get_Table(){} // RVA: 0x7FFE87264EE0
        public void get_ParentColumnNames(){} // RVA: 0x7FFE87264F20
        public void get_ChildColumnNames(){} // RVA: 0x7FFE87264F30
        public void CheckCanAddToCollection(){} // RVA: 0x7FFE87264F40
        public void CanBeRemovedFromCollection(){} // RVA: 0x7FFE811E0850
        public void IsKeyNull(){} // RVA: 0x7FFE872650C0
        public void IsConstraintViolated(){} // RVA: 0x7FFE87265170
        public void CanEnableConstraint(){} // RVA: 0x7FFE87265440
        public void CascadeCommit(){} // RVA: 0x7FFE872655E0
        public void CascadeDelete(){} // RVA: 0x7FFE87265760
        public void CascadeRollback(){} // RVA: 0x7FFE87265DC0
        public void CascadeUpdate(){} // RVA: 0x7FFE87266020
        public void CheckCanClearParentTable(){} // RVA: 0x7FFE87266680
        public void CheckCanRemoveParentRow(){} // RVA: 0x7FFE87266790
        public void CheckCascade(){} // RVA: 0x7FFE87266850
        public void CheckConstraint(){} // RVA: 0x7FFE87266B70
        public void NonVirtualCheckState(){} // RVA: 0x7FFE87266F50
        public void CheckState(){} // RVA: 0x7FFE87267240
        public void get_AcceptRejectRule(){} // RVA: 0x7FFE87267250
        public void set_AcceptRejectRule(){} // RVA: 0x7FFE87267270
        public void ContainsColumn(){} // RVA: 0x7FFE872672C0
        public void Clone(){} // RVA: 0x7FFE87267A30 | overloaded x3
        public void Create(){} // RVA: 0x7FFE87267FD0
        public void get_DeleteRule(){} // RVA: 0x7FFE872681E0
        public void set_DeleteRule(){} // RVA: 0x7FFE87268200
        public void Equals(){} // RVA: 0x7FFE87268250
        public void GetHashCode(){} // RVA: 0x7FFE867A47B0
        public void get_RelatedColumns(){} // RVA: 0x7FFE87268370
        public void get_RelatedColumnsReference(){} // RVA: 0x7FFE87268390
        public void get_ParentKey(){} // RVA: 0x7FFE87268390
        public void FindParentRelation(){} // RVA: 0x7FFE872683B0
        public void get_RelatedTable(){} // RVA: 0x7FFE872684A0
        public void get_UpdateRule(){} // RVA: 0x7FFE872684E0
        public void set_UpdateRule(){} // RVA: 0x7FFE87268500
    }

    public class ForeignKeyConstraintEnumerator : ConstraintEnumerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE872312C0
        public void IsValidCandidate(){} // RVA: 0x7FFE872312D0
        public void GetForeignKeyConstraint(){} // RVA: 0x7FFE87231360
    }

    public class Function : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87226910
        public void .cctor(){} // RVA: 0x7FFE87226BC0
    }

    public class FunctionNode : ExpressionNode
    {
        public string _name; // 0x18
        public int _info; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87221110
        public void AddArgument(){} // RVA: 0x7FFE87221470
        public void Bind(){} // RVA: 0x7FFE87221710
        public void Eval(){} // RVA: 0x7FFE872226C0 | overloaded x3
        public void IsConstant(){} // RVA: 0x7FFE87222700
        public void IsTableConstant(){} // RVA: 0x7FFE87222780
        public void HasLocalAggregate(){} // RVA: 0x7FFE87222800
        public void HasRemoteAggregate(){} // RVA: 0x7FFE87222880
        public void DependsOn(){} // RVA: 0x7FFE87222900
        public void Optimize(){} // RVA: 0x7FFE87222990
        public void GetDataType(){} // RVA: 0x7FFE87222D10
        public void EvalFunction(){} // RVA: 0x7FFE872230E0
        public void get_Aggregate(){} // RVA: 0x7FFE87224FB0
        public void get_IsAggregate(){} // RVA: 0x7FFE87225050
        public void Check(){} // RVA: 0x7FFE872252A0
        public void .cctor(){} // RVA: 0x7FFE87225510
    }

}