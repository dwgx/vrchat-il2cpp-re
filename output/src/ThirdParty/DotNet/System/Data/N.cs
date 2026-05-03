// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Data
// Classes: 3
// Methods: 29

namespace ThirdParty.DotNet.System.Data
{
    public class NameNode : ExpressionNode
    {
        public string _name; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81CA56D0 | overloaded x2
        public void get_IsSqlColumn(){} // RVA: 0x7FFE87262660
        public void Bind(){} // RVA: 0x7FFE87262680
        public void Eval(){} // RVA: 0x7FFE87262A90 | overloaded x3
        public void IsConstant(){} // RVA: 0x7FFE810FB320
        public void IsTableConstant(){} // RVA: 0x7FFE87262AD0
        public void HasLocalAggregate(){} // RVA: 0x7FFE87262B10
        public void HasRemoteAggregate(){} // RVA: 0x7FFE87262B50
        public void DependsOn(){} // RVA: 0x7FFE87262B90
        public void Optimize(){} // RVA: 0x7FFE827C4A80
        public void ParseName(){} // RVA: 0x7FFE87262BF0
    }

    public class NewDiffgramGen : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE872AC960 | overloaded x2
        public void CreateTableHierarchy(){} // RVA: 0x7FFE872ACB90
        public void DoAssignments(){} // RVA: 0x7FFE872ACE80
        public void EmptyData(){} // RVA: 0x7FFE872AD150
        public void Save(){} // RVA: 0x7FFE872AD280 | overloaded x2
        public void GenerateTable(){} // RVA: 0x7FFE872AD8B0
        public void GenerateTableErrors(){} // RVA: 0x7FFE872AD970
        public void GenerateRow(){} // RVA: 0x7FFE872ADFA0
        public void GenerateColumn(){} // RVA: 0x7FFE872AE730
        public void QualifiedName(){} // RVA: 0x7FFE872AF1E0
    }

    public class NoNullAllowedException : DataException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8720B610 | overloaded x3
    }

}