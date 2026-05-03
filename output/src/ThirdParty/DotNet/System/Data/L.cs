// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Data
// Classes: 3
// Methods: 21

namespace ThirdParty.DotNet.System.Data
{
    public class LikeNode : BinaryNode
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8725A0A0
        public void Eval(){} // RVA: 0x7FFE8725A0B0
        public void AnalyzePattern(){} // RVA: 0x7FFE8725A740
    }

    public class Listeners`1 : Object
    {
        public System.Collections.Generic.List`1<T> _listeners;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E48220
        public void get_HasListeners(){} // RVA: 0x7FFE80E2F150
        public void Add(){} // RVA: 0x7FFE810A1420
        public void IndexOfReference(){} // RVA: 0x7FFE810A1420
        public void Remove(){} // RVA: 0x7FFE810A1420
        public void Notify(){} // RVA: 0x7FFE810A1420
        public void RemoveNullListeners(){} // RVA: 0x7FFE80E46530
    }

    public class LookupNode : ExpressionNode
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87261D50
        public void Bind(){} // RVA: 0x7FFE87261E70
        public void Eval(){} // RVA: 0x7FFE87262530 | overloaded x3
        public void IsConstant(){} // RVA: 0x7FFE810FB320
        public void IsTableConstant(){} // RVA: 0x7FFE810FB320
        public void HasLocalAggregate(){} // RVA: 0x7FFE810FB320
        public void HasRemoteAggregate(){} // RVA: 0x7FFE810FB320
        public void DependsOn(){} // RVA: 0x7FFE87262570
        public void Optimize(){} // RVA: 0x7FFE827C4A80
    }

}