// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Data
// Classes: 4
// Methods: 64

namespace ThirdParty.DotNet.System.Data
{
    public class ForeignKeyConstraint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6725DF0 | overloaded x3
        public void get_ChildKey(){} // RVA: 0x6725FA0
        public void get_Columns(){} // RVA: 0x6725FC0
        public void get_Table(){} // RVA: 0x6725FE0
        public void get_ParentColumnNames(){} // RVA: 0x6726020
        public void get_ChildColumnNames(){} // RVA: 0x6726030
        public void CheckCanAddToCollection(){} // RVA: 0x6726040
        public void CanBeRemovedFromCollection(){} // RVA: 0x3C2850
        public void IsKeyNull(){} // RVA: 0x67261C0
        public void IsConstraintViolated(){} // RVA: 0x6726270
        public void CanEnableConstraint(){} // RVA: 0x6726540
        public void CascadeCommit(){} // RVA: 0x67266E0
        public void CascadeDelete(){} // RVA: 0x6726860
        public void CascadeRollback(){} // RVA: 0x6726EC0
        public void CascadeUpdate(){} // RVA: 0x6727120
        public void CheckCanClearParentTable(){} // RVA: 0x6727780
        public void CheckCanRemoveParentRow(){} // RVA: 0x6727890
        public void CheckCascade(){} // RVA: 0x6727950
        public void CheckConstraint(){} // RVA: 0x6727C70
        public void NonVirtualCheckState(){} // RVA: 0x6728050
        public void CheckState(){} // RVA: 0x6728340
        public void get_AcceptRejectRule(){} // RVA: 0x6728350
        public void set_AcceptRejectRule(){} // RVA: 0x6728370
        public void ContainsColumn(){} // RVA: 0x67283C0
        public void Clone(){} // RVA: 0x6728B30 | overloaded x3
        public void Create(){} // RVA: 0x67290D0
        public void get_DeleteRule(){} // RVA: 0x67292E0
        public void set_DeleteRule(){} // RVA: 0x6729300
        public void Equals(){} // RVA: 0x6729350
        public void GetHashCode(){} // RVA: 0x5C63910
        public void get_RelatedColumns(){} // RVA: 0x6729470
        public void get_RelatedColumnsReference(){} // RVA: 0x6729490
        public void get_ParentKey(){} // RVA: 0x6729490
        public void FindParentRelation(){} // RVA: 0x67294B0
        public void get_RelatedTable(){} // RVA: 0x67295A0
        public void get_UpdateRule(){} // RVA: 0x67295E0
        public void set_UpdateRule(){} // RVA: 0x6729600
    }

    public class ForeignKeyConstraintEnumerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x66F23D0
        public void IsValidCandidate(){} // RVA: 0x66F23E0
        public void GetForeignKeyConstraint(){} // RVA: 0x66F2470
    }

    public class Function
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x66E7A20
        public void .cctor(){} // RVA: 0x66E7CD0
    }

    public class FunctionNode
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x66E2220
        public void AddArgument(){} // RVA: 0x66E2580
        public void Bind(){} // RVA: 0x66E2820
        public void Eval(){} // RVA: 0x66E37D0 | overloaded x3
        public void IsConstant(){} // RVA: 0x66E3810
        public void IsTableConstant(){} // RVA: 0x66E3890
        public void HasLocalAggregate(){} // RVA: 0x66E3910
        public void HasRemoteAggregate(){} // RVA: 0x66E3990
        public void DependsOn(){} // RVA: 0x66E3A10
        public void Optimize(){} // RVA: 0x66E3AA0
        public void GetDataType(){} // RVA: 0x66E3E20
        public void EvalFunction(){} // RVA: 0x66E41F0
        public void get_Aggregate(){} // RVA: 0x66E60C0
        public void get_IsAggregate(){} // RVA: 0x66E6160
        public void Check(){} // RVA: 0x66E63B0
        public void .cctor(){} // RVA: 0x66E6620
    }

}