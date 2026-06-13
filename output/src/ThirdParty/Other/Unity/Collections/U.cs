// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Collections
// Classes: 11
// Methods: 44

namespace ThirdParty.Other.Unity.Collections
{
    public class Unicode
    {
        // ── Methods ──
        public void IsValidCodePoint(){} // RVA: 0x6D7A1E0
        public void NotTrailer(){} // RVA: 0x6D7A1F0
        public void get_ReplacementCharacter(){} // RVA: 0x62EC320
        public void Utf8ToUcs(){} // RVA: 0x6D7A200
        public void UcsToUtf16(){} // RVA: 0x6D7A3F0
        public void Utf8ToUtf16(){} // RVA: 0x6D7A490
    }

    public class UnmanagedArray`1
    {
        public UIntPtr m_pointer;

        // ── Methods ──
        public void Dispose(){} // RVA: 0x24A50
        public void get_Item(){} // RVA: 0x1BCC0
    }

    public class UnmanagedArray`1 : ͍
    {
        public UIntPtr m_pointer; // 0x10

        // ── Methods ──
        public void Dispose(){} // RVA: 0x45AA630
        public void get_Item(){} // RVA: 0x45AA700
    }

    public class UnsafeQueueBlockHeader
    {
    }

    public class UnsafeQueueData
    {
        // ── Methods ──
        public void GetCurrentWriteBlockTLS(){} // RVA: 0x6D7A620
        public void SetCurrentWriteBlockTLS(){} // RVA: 0x6D7A630
        public void AllocateWriteBlockMT(){} // RVA: 0x283FA0
        public void AllocateQueue(){} // RVA: 0x283FA0
        public void DeallocateQueue(){} // RVA: 0x6D7A640
    }

    public class UnsafeQueueDispose
    {
        // ── Methods ──
        public void Dispose(){} // RVA: 0x6D7A7B0
    }

    public class UnsafeQueueDisposeJob
    {
        // ── Methods ──
        public void Execute(){} // RVA: 0x6D7A7B0
    }

    public class UnsafeQueue`1
    {
        public Unity.Collections.UnsafeQueueData* m_Buffer;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x283FA0
        public void Alloc(){} // RVA: 0x283FA0
        public void Free(){} // RVA: 0x283FA0
        public void Enqueue(){} // RVA: 0x283FA0
        public void TryDequeue(){} // RVA: 0xDE40
        public void Clear(){} // RVA: 0x24A50
        public void get_IsCreated(){} // RVA: 0xDBE0
        public void Dispose(){} // RVA: 0x24A50
        public void AsParallelWriter(){} // RVA: 0x283FA0
    }

    public class UnsafeQueue`1
    {
        public Unity.Collections.UnsafeQueueData* m_Buffer; // 0x10
    }

    public class UnsafeQueue`1
    {
        public Unity.Collections.UnsafeQueueData* m_Buffer; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x45B8710
        public void Alloc(){} // RVA: 0x45B7460
        public void Free(){} // RVA: 0x45B74D0
        public void Enqueue(){} // RVA: 0x45B8860
        public void TryDequeue(){} // RVA: 0x45B8900
        public void Clear(){} // RVA: 0x45B8A90
        public void get_IsCreated(){} // RVA: 0x34C1790
        public void Dispose(){} // RVA: 0x45B7990
        public void AsParallelWriter(){} // RVA: 0x45B79D0
    }

    public class UnsafeQueue`1
    {
        public Unity.Collections.UnsafeQueueData* m_Buffer; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x45B79F0
        public void Alloc(){} // RVA: 0x45B7460
        public void Free(){} // RVA: 0x45B74D0
        public void Enqueue(){} // RVA: 0x45B7B40
        public void TryDequeue(){} // RVA: 0x45B7BC0
        public void Clear(){} // RVA: 0x45B7D30
        public void get_IsCreated(){} // RVA: 0x34C1790
        public void Dispose(){} // RVA: 0x45B7990
        public void AsParallelWriter(){} // RVA: 0x45B79D0
    }

}