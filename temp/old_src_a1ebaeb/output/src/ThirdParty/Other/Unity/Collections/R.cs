// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Collections
// Classes: 2
// Methods: 8

namespace ThirdParty.Other.Unity.Collections
{
    public class ReadOnlyAttribute : Attribute
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class RewindableAllocator : ValueType
    {
        public object m_block; // 0x33CECB90
        public object m_enableBlockFree; // 0x33CECB90
        public object 00; // 0x34F28768

        // ── Original Methods ──
        public void Rewind(){} // RVA: 0x7ffaaef33a10
        public void Dispose(){} // RVA: 0x7ffaaef33ba0
        public void TryAllocate(){} // RVA: 0x7ffaaef33cf0
        public void Try(){} // RVA: 0x7ffaaef341c0
        public void Try(){} // RVA: 0x7ffaaef341c0
        public void get_Handle(){} // RVA: 0x7ffaa9e47530
        public void Try$BurstManaged(){} // RVA: 0x7ffaaef34220
    }

}