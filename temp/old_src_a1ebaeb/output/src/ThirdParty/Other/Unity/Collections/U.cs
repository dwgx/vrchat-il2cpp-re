// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Collections
// Classes: 11
// Methods: 44

namespace ThirdParty.Other.Unity.Collections
{
    public class Unicode : ValueType
    {
        // ── Original Methods ──
        public void IsValidCodePoint(){} // RVA: 0x7ffaaef34910
        public void NotTrailer(){} // RVA: 0x7ffaaef34920
        public void get_ReplacementCharacter(){} // RVA: 0x7ffaae4a48e0
        public void Utf8ToUcs(){} // RVA: 0x7ffaaef34930
        public void UcsToUtf16(){} // RVA: 0x7ffaaef34b20
        public void Utf8ToUtf16(){} // RVA: 0x7ffaaef34bc0
    }

    public class UnmanagedArray`1 : ValueType
    {
        public object m_allocator; // 0x31469AD0

        // ── Original Methods ──
        public void Dispose(){} // RVA: 0x7ffaa8660cc0
        public void get_Item(){} // RVA: 0x7ffaa8658120
    }

    public class UnmanagedArray`1 : ValueType
    {
        public object m_allocator; // 0x34F28768
        public object Handle; // 0x1700003D

        // ── Original Methods ──
        public void Dispose(){} // RVA: 0x7ffaac82f8a0
        public void get_Item(){} // RVA: 0x7ffaac82f970
    }

    public class UnsafeQueueBlockHeader : ValueType
    {
        public object 00; // 0x40001FD
    }

    public class UnsafeQueueData : ValueType
    {
        public object m_LastBlock; // 0x31948C40
        public object m_CurrentWriteBlockTLS; // 0x31948C40

        // ── Original Methods ──
        public void AllocateWriteBlockMT(){} // RVA: 0x7ffaa887e5c0
        public void AllocateQueue(){} // RVA: 0x7ffaa887e5c0
        public void DeallocateQueue(){} // RVA: 0x7ffaaef34d70
        // ── Binary Analysis Named ──
        public void GetCurrentWriteBlockTLS(){} // RVA: 0x7ffaaef34d50
        public void SetCurrentWriteBlockTLS(){} // RVA: 0x7ffaaef34d60
    }

    public class UnsafeQueueDispose : ValueType
    {
        // ── Original Methods ──
        public void Dispose(){} // RVA: 0x7ffaaef34ee0
    }

    public class UnsafeQueueDisposeJob : ValueType
    {
        // ── Original Methods ──
        public void Execute(){} // RVA: 0x7ffaaef34ee0
    }

    public class UnsafeQueue`1 : ValueType
    {
        public object m_Buffer; // 0x35107540

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa887e5c0
        public void Alloc(){} // RVA: 0x7ffaa887e5c0
        public void Free(){} // RVA: 0x7ffaa887e5c0
        public void Enqueue(){} // RVA: 0x7ffaa887e5c0
        public void TryDequeue(){} // RVA: 0x7ffaa864a2a0
        public void Clear(){} // RVA: 0x7ffaa8660cc0
        public void get_IsCreated(){} // RVA: 0x7ffaa864a040
        public void Dispose(){} // RVA: 0x7ffaa8660cc0
        public void AsParallelWriter(){} // RVA: 0x7ffaa887e5c0
    }

    public class UnsafeQueue`1 : ValueType
    {
    }

    public class UnsafeQueue`1 : ValueType
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaac83d7e0
        public void Alloc(){} // RVA: 0x7ffaac83c530
        public void Free(){} // RVA: 0x7ffaac83c5a0
        public void Enqueue(){} // RVA: 0x7ffaac83d930
        public void TryDequeue(){} // RVA: 0x7ffaac83d9d0
        public void Clear(){} // RVA: 0x7ffaac83db60
        public void get_IsCreated(){} // RVA: 0x7ffaab7cf5a0
        public void Dispose(){} // RVA: 0x7ffaac83ca60
        public void AsParallelWriter(){} // RVA: 0x7ffaac83caa0
    }

    public class UnsafeQueue`1 : ValueType
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaac83cac0
        public void Alloc(){} // RVA: 0x7ffaac83c530
        public void Free(){} // RVA: 0x7ffaac83c5a0
        public void Enqueue(){} // RVA: 0x7ffaac83cc10
        public void TryDequeue(){} // RVA: 0x7ffaac83cc90
        public void Clear(){} // RVA: 0x7ffaac83ce00
        public void get_IsCreated(){} // RVA: 0x7ffaab7cf5a0
        public void Dispose(){} // RVA: 0x7ffaac83ca60
        public void AsParallelWriter(){} // RVA: 0x7ffaac83caa0
    }

}