// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Burst
// Classes: 1
// Methods: 13

namespace VRC.Core.Burst
{
    public class DisposableJobHandle : ValueType
    {
        public Unity.Jobs.JobHandle IsCompleted; // 0x10
        public System.Collections.Generic.List`1<VRC.Core.Burst.DisposableJobHandle> _knownDisposableJobHandles;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACC047600
        public void GetIncompleteDisposableJobs(){} // RVA: 0x7FFACC047700
        public void CullCompleteJobs(){} // RVA: 0x7FFACC047760
        public void get_IsCompleted(){} // RVA: 0x7FFAC984E630
        public void Complete(){} // RVA: 0x7FFAC984E5D0
        public void Dispose(){} // RVA: 0x7FFACC047900
        public void Equals(){} // RVA: 0x7FFACC0479F0 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFACC047AA0
        public void op_Inequality(){} // RVA: 0x7FFACC047B00
        public void op_Implicit(){} // RVA: 0x7FFAC32C0590
        public void GetHashCode(){} // RVA: 0x7FFACC047B90
        public void .cctor(){} // RVA: 0x7FFACC047C60
    }

}