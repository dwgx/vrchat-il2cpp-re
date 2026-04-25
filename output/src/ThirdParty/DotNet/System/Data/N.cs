// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Data
// Classes: 3
// Methods: 29

namespace ThirdParty.DotNet.System.Data
{
    public class NameNode : ExpressionNode
    {
        public string IsSqlColumn; // 0x18
        public bool _found; // 0x20
        public System.Data.DataColumn _column; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC34EC240 | overloaded x2
        public void get_IsSqlColumn(){} // RVA: 0x7FFAC8EBA210
        public void Bind(){} // RVA: 0x7FFAC8EBA230
        public void Eval(){} // RVA: 0x7FFAC8EBA640 | overloaded x3
        public void IsConstant(){} // RVA: 0x7FFAC2F21320
        public void IsTableConstant(){} // RVA: 0x7FFAC8EBA680
        public void HasLocalAggregate(){} // RVA: 0x7FFAC8EBA6C0
        public void HasRemoteAggregate(){} // RVA: 0x7FFAC8EBA700
        public void DependsOn(){} // RVA: 0x7FFAC8EBA740
        public void Optimize(){} // RVA: 0x7FFAC44F81E0
        public void ParseName(){} // RVA: 0x7FFAC8EBA7A0
    }

    public class NewDiffgramGen : Object
    {
        public System.Xml.XmlDocument _doc; // 0x10
        public System.Data.DataSet _ds; // 0x18
        public System.Data.DataTable _dt; // 0x20
        public System.Xml.XmlWriter _xmlw; // 0x28
        public bool _fBefore; // 0x30
        public bool _fErrors; // 0x31
        public System.Collections.Hashtable _rowsOrder; // 0x38
        public System.Collections.ArrayList _tables; // 0x40
        public bool _writeHierarchy; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F04510 | overloaded x2
        public void CreateTableHierarchy(){} // RVA: 0x7FFAC8F04740
        public void DoAssignments(){} // RVA: 0x7FFAC8F04A30
        public void EmptyData(){} // RVA: 0x7FFAC8F04D00
        public void Save(){} // RVA: 0x7FFAC8F04E30 | overloaded x2
        public void GenerateTable(){} // RVA: 0x7FFAC8F05460
        public void GenerateTableErrors(){} // RVA: 0x7FFAC8F05520
        public void GenerateRow(){} // RVA: 0x7FFAC8F05B50
        public void GenerateColumn(){} // RVA: 0x7FFAC8F062E0
        public void QualifiedName(){} // RVA: 0x7FFAC8F06D90
    }

    public class NoNullAllowedException : DataException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8E631E0 | overloaded x3
    }

}