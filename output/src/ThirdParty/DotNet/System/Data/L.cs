// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Data
// Classes: 3
// Methods: 21

namespace ThirdParty.DotNet.System.Data
{
    public class LikeNode
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x671B1A0
        public void Eval(){} // RVA: 0x671B1B0
        public void AnalyzePattern(){} // RVA: 0x671B840
    }

    public class Listeners`1
    {
        public System.Collections.Generic.List`1<T> _listeners;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x26C40
        public void get_HasListeners(){} // RVA: 0xDBE0
        public void Add(){} // RVA: 0x283FA0
        public void IndexOfReference(){} // RVA: 0x283FA0
        public void Remove(){} // RVA: 0x283FA0
        public void Notify(){} // RVA: 0x283FA0
        public void RemoveNullListeners(){} // RVA: 0x24FA0
    }

    public class LookupNode
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6722E50
        public void Bind(){} // RVA: 0x6722F70
        public void Eval(){} // RVA: 0x6723630 | overloaded x3
        public void IsConstant(){} // RVA: 0x2DD320
        public void IsTableConstant(){} // RVA: 0x2DD320
        public void HasLocalAggregate(){} // RVA: 0x2DD320
        public void HasRemoteAggregate(){} // RVA: 0x2DD320
        public void DependsOn(){} // RVA: 0x6723670
        public void Optimize(){} // RVA: 0x1A3F520
    }

}