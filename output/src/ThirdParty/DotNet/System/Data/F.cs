// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Data
// Classes: 4
// Methods: 58

namespace ThirdParty.DotNet.System.Data
{
    public class ForeignKeyConstraint : Constraint
    {
        public object _deleteRule;
        public object _updateRule;
        public object _acceptRejectRule;
        public object _childKey;
        public object _parentKey;
        public object _constraintName;
        public object _parentColumnNames;
        public object _childColumnNames;
        public object _parentTableName;
        public object _parentTableNamespace;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x718D9B0
        public void get_ChildKey(){} // RVA: 0x718DB60
        public void get_Columns(){} // RVA: 0x718DB80
        public void get_Table(){} // RVA: 0x718DBA0
        public void get_ParentColumnNames(){} // RVA: 0x718DBE0
        public void get_ChildColumnNames(){} // RVA: 0x718DBF0
        public void CheckCanAddToCollection(){} // RVA: 0x718DC00
        public void CanBeRemovedFromCollection(){} // RVA: 0xC2E4C0
        public void IsKeyNull(){} // RVA: 0x718DD80
        public void IsConstraintViolated(){} // RVA: 0x718DE30
        public void CanEnableConstraint(){} // RVA: 0x718E110
        public void CascadeCommit(){} // RVA: 0x718E2C0
        public void CascadeDelete(){} // RVA: 0x718E450
        public void CascadeRollback(){} // RVA: 0x718EAE0
        public void CascadeUpdate(){} // RVA: 0x718ED40
        public void CheckCanClearParentTable(){} // RVA: 0x718F3C0
        public void CheckCanRemoveParentRow(){} // RVA: 0x718F4D0
        public void CheckCascade(){} // RVA: 0x718F590
        public void CheckConstraint(){} // RVA: 0x718F8A0
        public void NonVirtualCheckState(){} // RVA: 0x718FCA0
        public void CheckState(){} // RVA: 0x718FF70
        public void get_AcceptRejectRule(){} // RVA: 0x718FF80
        public void set_AcceptRejectRule(){} // RVA: 0x718FFA0
        public void ContainsColumn(){} // RVA: 0x718FFF0
        public void Clone(){} // RVA: 0x7190790
        public void Create(){} // RVA: 0x7190D50
        public void get_DeleteRule(){} // RVA: 0x7190F70
        public void set_DeleteRule(){} // RVA: 0x7190F90
        public void Equals(){} // RVA: 0x7190FE0
        public void GetHashCode(){} // RVA: 0x66DC010
        public void get_RelatedColumns(){} // RVA: 0x7191100
        public void get_RelatedColumnsReference(){} // RVA: 0x7191120
        public void get_ParentKey(){} // RVA: 0x7191120
        public void FindParentRelation(){} // RVA: 0x7191140
        public void get_RelatedTable(){} // RVA: 0x7191230
        public void get_UpdateRule(){} // RVA: 0x7191270
        public void set_UpdateRule(){} // RVA: 0x7191290
    }

    public class ForeignKeyConstraintEnumerator : ConstraintEnumerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x715ACC0
        public void IsValidCandidate(){} // RVA: 0x715ACD0
        public void GetForeignKeyConstraint(){} // RVA: 0x715AD50
    }

    public class Function : Object
    {
        public object _name;
        public object _id;
        public object _result;
        public object _isValidateArguments;
        public object _isVariantArgumentList;
        public object _argumentCount;
        public object _parameters;
        public object s_functionName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x71510F0
        public void .cctor(){} // RVA: 0x7151390
    }

    public class FunctionNode : ExpressionNode
    {
        public object _name;
        public object _info;
        public object _argumentCount;
        public object _arguments;
        public object _capturedLimiter;
        public object s_funcs;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x714BF30
        public void AddArgument(){} // RVA: 0x714C2B0
        public void Bind(){} // RVA: 0x714C550
        public void Eval(){} // RVA: 0x714D490
        public void IsConstant(){} // RVA: 0x714D4D0
        public void IsTableConstant(){} // RVA: 0x714D560
        public void HasLocalAggregate(){} // RVA: 0x714D5F0
        public void HasRemoteAggregate(){} // RVA: 0x714D680
        public void DependsOn(){} // RVA: 0x714D710
        public void Optimize(){} // RVA: 0x714D7A0
        public void GetDataType(){} // RVA: 0x714DB00
        public void EvalFunction(){} // RVA: 0x714DE70
        public void get_Aggregate(){} // RVA: 0x714FBD0
        public void get_IsAggregate(){} // RVA: 0x714FC70
        public void Check(){} // RVA: 0x714FEC0
        public void .cctor(){} // RVA: 0x7150130
    }

}