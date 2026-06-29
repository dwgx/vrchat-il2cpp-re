// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Data
// Classes: 3
// Methods: 22

namespace ThirdParty.DotNet.System.Data
{
    public class NameNode : ExpressionNode
    {
        public object _name;
        public object _found;
        public object _column;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x17C92C0
        public void get_IsSqlColumn(){} // RVA: 0x718B330
        public void Bind(){} // RVA: 0x718B350
        public void Eval(){} // RVA: 0x718B760
        public void IsConstant(){} // RVA: 0xB43320
        public void IsTableConstant(){} // RVA: 0x718B7A0
        public void HasLocalAggregate(){} // RVA: 0x718B7E0
        public void HasRemoteAggregate(){} // RVA: 0x718B820
        public void DependsOn(){} // RVA: 0x718B860
        public void Optimize(){} // RVA: 0x2303260
        public void ParseName(){} // RVA: 0x718B8C0
    }

    public class NewDiffgramGen : Object
    {
        public object _doc;
        public object _ds;
        public object _dt;
        public object _xmlw;
        public object _fBefore;
        public object _fErrors;
        public object _rowsOrder;
        public object _tables;
        public object _writeHierarchy;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x71D3E90
        public void CreateTableHierarchy(){} // RVA: 0x71D40D0
        public void DoAssignments(){} // RVA: 0x71D43B0
        public void EmptyData(){} // RVA: 0x71D4670
        public void Save(){} // RVA: 0x71D47A0
        public void GenerateTable(){} // RVA: 0x71D4DF0
        public void GenerateTableErrors(){} // RVA: 0x71D4EB0
        public void GenerateRow(){} // RVA: 0x71D54F0
        public void GenerateColumn(){} // RVA: 0x71D5CB0
        public void QualifiedName(){} // RVA: 0x71D6740
    }

    public class NoNullAllowedException : DataException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7135F50
    }

}