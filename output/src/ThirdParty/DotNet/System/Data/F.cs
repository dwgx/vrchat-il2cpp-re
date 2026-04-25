// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Data
// Classes: 4
// Methods: 64

namespace ThirdParty.DotNet.System.Data
{
    public class ForeignKeyConstraint : Constraint
    {
        public 0x6B1D03F8 ChildKey; // 0x38
        public 0x6B1D03F8 Columns; // 0x3C
        public 0x6B1CE1F0 Table; // 0x40
        public System.Data.DataKey ParentColumnNames; // 0x48
        public System.Data.DataKey ChildColumnNames; // 0x50
        public string AcceptRejectRule; // 0x58
        public string[] DeleteRule; // 0x60
        public string[] RelatedColumns; // 0x68
        public string RelatedColumnsReference; // 0x70
        public string ParentKey; // 0x78

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8EBC8A0 | overloaded x3
        public void get_ChildKey(){} // RVA: 0x7FFAC8EBCA50
        public void get_Columns(){} // RVA: 0x7FFAC8EBCA70
        public void get_Table(){} // RVA: 0x7FFAC8EBCA90
        public void get_ParentColumnNames(){} // RVA: 0x7FFAC8EBCAD0
        public void get_ChildColumnNames(){} // RVA: 0x7FFAC8EBCAE0
        public void CheckCanAddToCollection(){} // RVA: 0x7FFAC8EBCAF0
        public void CanBeRemovedFromCollection(){} // RVA: 0x7FFAC3006850
        public void IsKeyNull(){} // RVA: 0x7FFAC8EBCC70
        public void IsConstraintViolated(){} // RVA: 0x7FFAC8EBCD20
        public void CanEnableConstraint(){} // RVA: 0x7FFAC8EBCFF0
        public void CascadeCommit(){} // RVA: 0x7FFAC8EBD190
        public void CascadeDelete(){} // RVA: 0x7FFAC8EBD310
        public void CascadeRollback(){} // RVA: 0x7FFAC8EBD970
        public void CascadeUpdate(){} // RVA: 0x7FFAC8EBDBD0
        public void CheckCanClearParentTable(){} // RVA: 0x7FFAC8EBE230
        public void CheckCanRemoveParentRow(){} // RVA: 0x7FFAC8EBE340
        public void CheckCascade(){} // RVA: 0x7FFAC8EBE400
        public void CheckConstraint(){} // RVA: 0x7FFAC8EBE720
        public void NonVirtualCheckState(){} // RVA: 0x7FFAC8EBEB00
        public void CheckState(){} // RVA: 0x7FFAC8EBEDF0
        public void get_AcceptRejectRule(){} // RVA: 0x7FFAC8EBEE00
        public void set_AcceptRejectRule(){} // RVA: 0x7FFAC8EBEE20
        public void ContainsColumn(){} // RVA: 0x7FFAC8EBEE70
        public void Clone(){} // RVA: 0x7FFAC8EBF5E0 | overloaded x3
        public void Create(){} // RVA: 0x7FFAC8EBFB80
        public void get_DeleteRule(){} // RVA: 0x7FFAC8EBFD90
        public void set_DeleteRule(){} // RVA: 0x7FFAC8EBFDB0
        public void Equals(){} // RVA: 0x7FFAC8EBFE00
        public void GetHashCode(){} // RVA: 0x7FFAC83FAE70
        public void get_RelatedColumns(){} // RVA: 0x7FFAC8EBFF20
        public void get_RelatedColumnsReference(){} // RVA: 0x7FFAC8EBFF40
        public void get_ParentKey(){} // RVA: 0x7FFAC8EBFF40
        public void FindParentRelation(){} // RVA: 0x7FFAC8EBFF60
        public void get_RelatedTable(){} // RVA: 0x7FFAC8EC0050
        public void get_UpdateRule(){} // RVA: 0x7FFAC8EC0090
        public void set_UpdateRule(){} // RVA: 0x7FFAC8EC00B0
    }

    public class ForeignKeyConstraintEnumerator : ConstraintEnumerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8E88E90
        public void IsValidCandidate(){} // RVA: 0x7FFAC8E88EA0
        public void GetForeignKeyConstraint(){} // RVA: 0x7FFAC8E88F30
    }

    public class Function : Object
    {
        public string _name; // 0x10
        public 0x6B1CDFE0 _id; // 0x18
        public System.Type _result; // 0x20
        public bool _isValidateArguments; // 0x28
        public bool _isVariantArgumentList; // 0x29
        public int _argumentCount; // 0x2C
        public System.Type[] _parameters; // 0x30
        public string[] s_functionName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8E7E4E0
        public void .cctor(){} // RVA: 0x7FFAC8E7E790
    }

    public class FunctionNode : ExpressionNode
    {
        public string Aggregate; // 0x18
        public int IsAggregate; // 0x20
        public int _argumentCount; // 0x24
        public System.Data.ExpressionNode[] _arguments; // 0x28
        public System.Data.TypeLimiter _capturedLimiter; // 0x30
        public System.Data.Function[] s_funcs;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8E78CE0
        public void AddArgument(){} // RVA: 0x7FFAC8E79040
        public void Bind(){} // RVA: 0x7FFAC8E792E0
        public void Eval(){} // RVA: 0x7FFAC8E7A290 | overloaded x3
        public void IsConstant(){} // RVA: 0x7FFAC8E7A2D0
        public void IsTableConstant(){} // RVA: 0x7FFAC8E7A350
        public void HasLocalAggregate(){} // RVA: 0x7FFAC8E7A3D0
        public void HasRemoteAggregate(){} // RVA: 0x7FFAC8E7A450
        public void DependsOn(){} // RVA: 0x7FFAC8E7A4D0
        public void Optimize(){} // RVA: 0x7FFAC8E7A560
        public void GetDataType(){} // RVA: 0x7FFAC8E7A8E0
        public void EvalFunction(){} // RVA: 0x7FFAC8E7ACB0
        public void get_Aggregate(){} // RVA: 0x7FFAC8E7CB80
        public void get_IsAggregate(){} // RVA: 0x7FFAC8E7CC20
        public void Check(){} // RVA: 0x7FFAC8E7CE70
        public void .cctor(){} // RVA: 0x7FFAC8E7D0E0
    }

}