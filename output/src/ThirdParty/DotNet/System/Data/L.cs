// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Data
// Classes: 3
// Methods: 19

namespace ThirdParty.DotNet.System.Data
{
    public class LikeNode : BinaryNode
    {
        public object _kind;
        public object _pattern;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7183040
        public void Eval(){} // RVA: 0x7183050
        public void AnalyzePattern(){} // RVA: 0x71836A0
    }

    public class Listeners`1 : Object
    {
        public object _listeners;
        public object _filter;
        public object _objectID;
        public object _listenerReaderCount;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x895750
        public void get_HasListeners(){} // RVA: 0x87D280
        public void Add(){} // RVA: 0xA94080
        public void IndexOfReference(){} // RVA: 0xA94080
        public void Remove(){} // RVA: 0xA94080
        public void Notify(){} // RVA: 0xA94080
        public void RemoveNullListeners(){} // RVA: 0x8944F0
    }

    public class LookupNode : ExpressionNode
    {
        public object _relationName;
        public object _columnName;
        public object _column;
        public object _relation;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x718AA00
        public void Bind(){} // RVA: 0x718AB20
        public void Eval(){} // RVA: 0x718B200
        public void IsConstant(){} // RVA: 0xB43320
        public void IsTableConstant(){} // RVA: 0xB43320
        public void HasLocalAggregate(){} // RVA: 0xB43320
        public void HasRemoteAggregate(){} // RVA: 0xB43320
        public void DependsOn(){} // RVA: 0x718B240
        public void Optimize(){} // RVA: 0x2303260
    }

}