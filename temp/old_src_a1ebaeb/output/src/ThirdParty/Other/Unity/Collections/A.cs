// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Collections
// Classes: 4
// Methods: 51

namespace ThirdParty.Other.Unity.Collections
{
    public class AllocatorManager : Object
    {
        public object Temp; // 0x30CE3250
        public object AudioKernel; // 0x30CE3250
        public object GlobalAllocatorBaseIndex; // 0x30CE3250
        public object Version; // 0x30FF7BD0
        public object 00; // 0x34E6BC40
        public object 00; // 0x30CE30B0

        // ── Original Methods ──
        public void AllocateBlock(){} // RVA: 0x7ffaa887e5c0
        public void Allocate(){} // RVA: 0x7ffaa887e5c0
        public void Allocate(){} // RVA: 0x7ffaa887e5c0
        public void AllocateStruct(){} // RVA: 0x7ffaa887e5c0
        public void FreeBlock(){} // RVA: 0x7ffaa8660fc0
        public void Free(){} // RVA: 0x7ffaa887e5c0
        public void Free(){} // RVA: 0x7ffaa887e5c0
        public void Free(){} // RVA: 0x7ffaa887e5c0
        public void Free(){} // RVA: 0x7ffaa887e5c0
        public void UseDelegate(){} // RVA: 0x7ffaaef30660
        public void allocate_block(){} // RVA: 0x7ffaaef306b0
        public void forward_mono_allocate_block(){} // RVA: 0x7ffaaef30750
        public void LegacyOf(){} // RVA: 0x7ffaaef30870
        public void TryLegacy(){} // RVA: 0x7ffaaef30880
        public void Try(){} // RVA: 0x7ffaaef30a20
        public void IsCustomAllocator(){} // RVA: 0x7ffaaef30d90
        public void .cctor(){} // RVA: 0x7ffaaef30da0
        public void Initialize$StackAllocator_Try_000000AB$BurstDirectCall(){} // RVA: 0x7ffaaef30f60
        public void Initialize$SlabAllocator_Try_000000B9$BurstDirectCall(){} // RVA: 0x7ffaaef30fb0
        // ── Binary Analysis Named ──
        public void CheckDelegate(){} // RVA: 0x7ffaad8162e0
    }

    public class ArrayOfArrays`1 : ValueType
    {
        public object m_capacityInElements; // 0x30CF95B0
        public object m_block; // 0x30CF95B0
        public object m_capacityInElements; // 0x34F27740

        // ── Original Methods ──
        public void get_BlockSizeInElements(){} // RVA: 0x7ffaa8649ca0
        public void get_BlockSizeInBytes(){} // RVA: 0x7ffaa8649ca0
        public void get_BlockMask(){} // RVA: 0x7ffaa8649ca0
        public void get_Length(){} // RVA: 0x7ffaa8649ca0
        public void LockfreeAdd(){} // RVA: 0x7ffaa887e5c0
        public void get_Item(){} // RVA: 0x7ffaa8658120
        public void Rewind(){} // RVA: 0x7ffaa8660cc0
        public void Clear(){} // RVA: 0x7ffaa8660cc0
        public void Dispose(){} // RVA: 0x7ffaa8660cc0
        public void RemoveAtSwapBack(){} // RVA: 0x7ffaa8661210
        public void BlockIndexOfElement(){} // RVA: 0x7ffaa8650410
        public void TrimExcess(){} // RVA: 0x7ffaa8660cc0
    }

    public class ArrayOfArrays`1 : ValueType
    {
        public object m_capacityInElements; // 0x34F27740
        public object m_block; // 0x34F27740
        public object Handle; // 0x17000013

        // ── Original Methods ──
        public void get_BlockSizeInElements(){} // RVA: 0x7ffaabd89d10
        public void get_BlockSizeInBytes(){} // RVA: 0x7ffaabd89d20
        public void get_BlockMask(){} // RVA: 0x7ffaabd89d50
        public void get_Length(){} // RVA: 0x7ffaa9e47530
        public void LockfreeAdd(){} // RVA: 0x7ffaabd89d80
        public void get_Item(){} // RVA: 0x7ffaabd89ef0
        public void Rewind(){} // RVA: 0x7ffaabd89fa0
        public void Clear(){} // RVA: 0x7ffaabd89fb0
        public void Dispose(){} // RVA: 0x7ffaabd8a050
        public void RemoveAtSwapBack(){} // RVA: 0x7ffaabd8a0c0
        public void BlockIndexOfElement(){} // RVA: 0x7ffaabd8a170
        public void TrimExcess(){} // RVA: 0x7ffaabd8a180
    }

    public class AutoFreeAllocator : ValueType
    {
        public object m_handle; // 0x339D6640
        public object oSMg;

        // ── Original Methods ──
        public void Update(){} // RVA: 0x7ffaaef325f0
        public void FreeAll(){} // RVA: 0x7ffaaef32750
        public void Dispose(){} // RVA: 0x7ffaaef328a0
        public void Try(){} // RVA: 0x7ffaaef329f0
        public void Try(){} // RVA: 0x7ffaaef329f0
        public void get_Handle(){} // RVA: 0x7ffaa89d3080
        public void Try$BurstManaged(){} // RVA: 0x7ffaaef32a50
    }

}