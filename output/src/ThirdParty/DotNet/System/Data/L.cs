// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Data
// Classes: 3
// Methods: 21

namespace ThirdParty.DotNet.System.Data
{
    public class LikeNode : BinaryNode
    {
        public int _kind; // 0x30
        public string _pattern; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8EB1C70
        public void Eval(){} // RVA: 0x7FFAC8EB1C80
        public void AnalyzePattern(){} // RVA: 0x7FFAC8EB2310
    }

    public class Listeners`1 : Object
    {
        public System.Collections.Generic.List`1<T> HasListeners;
        public Func`2<T,T,bool> _filter;
        public int _objectID;
        public int _listenerReaderCount;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C72BC0
        public void get_HasListeners(){} // RVA: 0x7FFAC2C59D00
        public void Add(){} // RVA: 0x7FFAC2E8DC40
        public void IndexOfReference(){} // RVA: 0x7FFAC2E8DC40
        public void Remove(){} // RVA: 0x7FFAC2E8DC40
        public void Notify(){} // RVA: 0x7FFAC2E8DC40
        public void RemoveNullListeners(){} // RVA: 0x7FFAC2C70ED0
    }

    public class LookupNode : ExpressionNode
    {
        public string _relationName; // 0x18
        public string _columnName; // 0x20
        public System.Data.DataColumn _column; // 0x28
        public System.Data.DataRelation _relation; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8EB9900
        public void Bind(){} // RVA: 0x7FFAC8EB9A20
        public void Eval(){} // RVA: 0x7FFAC8EBA0E0 | overloaded x3
        public void IsConstant(){} // RVA: 0x7FFAC2F21320
        public void IsTableConstant(){} // RVA: 0x7FFAC2F21320
        public void HasLocalAggregate(){} // RVA: 0x7FFAC2F21320
        public void HasRemoteAggregate(){} // RVA: 0x7FFAC2F21320
        public void DependsOn(){} // RVA: 0x7FFAC8EBA120
        public void Optimize(){} // RVA: 0x7FFAC44F81E0
    }

}