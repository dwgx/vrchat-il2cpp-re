// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Collections
// Classes: 4
// Methods: 51

namespace ThirdParty.Other.Unity.Collections
{
    public class AllocatorManager
    {
        // ── Methods ──
        public void AllocateBlock(){} // RVA: 0x283FA0
        public void Allocate(){} // RVA: 0x283FA0 | overloaded x2
        public void AllocateStruct(){} // RVA: 0x283FA0
        public void FreeBlock(){} // RVA: 0x24D50
        public void Free(){} // RVA: 0x283FA0 | overloaded x4
        public void CheckDelegate(){} // RVA: 0x57538A0
        public void UseDelegate(){} // RVA: 0x6D75F30
        public void allocate_block(){} // RVA: 0x6D75F80
        public void forward_mono_allocate_block(){} // RVA: 0x6D76020
        public void LegacyOf(){} // RVA: 0x6D76140
        public void TryLegacy(){} // RVA: 0x6D76150
        public void Try(){} // RVA: 0x6D762F0
        public void IsCustomAllocator(){} // RVA: 0x6D76660
        public void .cctor(){} // RVA: 0x6D76670
        public void Initialize$StackAllocator_Try_000000AB$BurstDirectCall(){} // RVA: 0x6D76830
        public void Initialize$SlabAllocator_Try_000000B9$BurstDirectCall(){} // RVA: 0x6D76880
    }

    public class ArrayOfArrays`1
    {
        public AllocatorHandle m_backingAllocatorHandle;
        public int m_lengthInElements;
        public int m_capacityInElements;
        public int m_log2BlockSizeInElements;
        public int m_blocks;

        // ── Methods ──
        public void get_BlockSizeInElements(){} // RVA: 0xD840
        public void get_BlockSizeInBytes(){} // RVA: 0xD840
        public void get_BlockMask(){} // RVA: 0xD840
        public void get_Length(){} // RVA: 0xD840
        public void LockfreeAdd(){} // RVA: 0x283FA0
        public void get_Item(){} // RVA: 0x1BCC0
        public void Rewind(){} // RVA: 0x24A50
        public void Clear(){} // RVA: 0x24A50
        public void Dispose(){} // RVA: 0x24A50
        public void RemoveAtSwapBack(){} // RVA: 0x24FA0
        public void BlockIndexOfElement(){} // RVA: 0x13FB0
        public void TrimExcess(){} // RVA: 0x24A50
    }

    public class ArrayOfArrays`1
    {
        public AllocatorHandle m_backingAllocatorHandle; // 0x10
        public int m_lengthInElements; // 0x14
        public int m_capacityInElements; // 0x18
        public int m_log2BlockSizeInElements; // 0x1C
        public int m_blocks; // 0x20

        // ── Methods ──
        public void get_BlockSizeInElements(){} // RVA: 0x39B8A30
        public void get_BlockSizeInBytes(){} // RVA: 0x39B8A40
        public void get_BlockMask(){} // RVA: 0x39B8A70
        public void get_Length(){} // RVA: 0x19689E0
        public void LockfreeAdd(){} // RVA: 0x39B8AA0
        public void get_Item(){} // RVA: 0x39B8C10
        public void Rewind(){} // RVA: 0x39B8CC0
        public void Clear(){} // RVA: 0x39B8CD0
        public void Dispose(){} // RVA: 0x39B8D70
        public void RemoveAtSwapBack(){} // RVA: 0x39B8DE0
        public void BlockIndexOfElement(){} // RVA: 0x39B8E90
        public void TrimExcess(){} // RVA: 0x39B8EA0
    }

    public class AutoFreeAllocator
    {
        public Unity.Collections.ArrayOfArrays`1<UIntPtr> m_allocated; // 0x10

        // ── Methods ──
        public void Update(){} // RVA: 0x6D77EC0
        public void FreeAll(){} // RVA: 0x6D78020
        public void Dispose(){} // RVA: 0x6D78170
        public void Try(){} // RVA: 0x6D782C0 | overloaded x2
        public void get_Handle(){} // RVA: 0x37E080
        public void Try$BurstManaged(){} // RVA: 0x6D78320
    }

}