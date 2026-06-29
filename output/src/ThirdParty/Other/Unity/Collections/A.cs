// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Collections
// Classes: 5
// Methods: 61

namespace ThirdParty.Other.Unity.Collections
{
    public class AllocatorManager : Object
    {
        // ── Methods ──
        public void AllocateBlock(){} // RVA: 0x7AA1942C0
        public void Allocate(){} // RVA: 0x7AA193EE0
        public void AllocateStruct(){} // RVA: 0x7A8051B10
        public void FreeBlock(){} // RVA: 0x7AA195DE0
        public void Free(){} // RVA: 0x7AA1958C0
        public void CheckDelegate(){} // RVA: 0x7AD5229D0
        public void UseDelegate(){} // RVA: 0x7AEB63CB0
        public void allocate_block(){} // RVA: 0x7AEB63D00
        public void forward_mono_allocate_block(){} // RVA: 0x7AEB63DA0
        public void LegacyOf(){} // RVA: 0x7AEB63EC0
        public void TryLegacy(){} // RVA: 0x7AEB63ED0
        public void Try(){} // RVA: 0x7AEB64070
        public void IsCustomAllocator(){} // RVA: 0x7AEB643E0
        public void .cctor(){} // RVA: 0x7AEB643F0
        public void Initialize$StackAllocator_Try_000000AB$BurstDirectCall(){} // RVA: 0x7AEB645B0
        public void Initialize$SlabAllocator_Try_000000B9$BurstDirectCall(){} // RVA: 0x7AEB64600
    }

    public class Allocator[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D3F10
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29EBF0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6990
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA281BF0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29EBF0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class ArrayOfArrays`1 : ValueType
    {
        // ── Methods ──
        public void get_BlockSizeInElements(){} // RVA: 0x7A7E00710
        public void get_BlockSizeInBytes(){} // RVA: 0x7A7E00710
        public void get_BlockMask(){} // RVA: 0x7A7E00710
        public void get_Length(){} // RVA: 0x7A7E00710
        public void LockfreeAdd(){} // RVA: 0x7A8051B10
        public void get_Item(){} // RVA: 0x7A7E00740
        public void Rewind(){} // RVA: 0x7A7E18770
        public void Clear(){} // RVA: 0x7A7E18770
        public void Dispose(){} // RVA: 0x7A7E18770
        public void RemoveAtSwapBack(){} // RVA: 0x7A7E189D0
        public void BlockIndexOfElement(){} // RVA: 0x7A7E062A0
        public void TrimExcess(){} // RVA: 0x7A7E18770
    }

    public class ArrayOfArrays`1 : ValueType
    {
        // ── Methods ──
        public void get_BlockSizeInElements(){} // RVA: 0x7A794ED20
        public void get_BlockSizeInBytes(){} // RVA: 0x7A794ED30
        public void get_BlockMask(){} // RVA: 0x7A794ED60
        public void get_Length(){} // RVA: 0x7A765F0A0
        public void LockfreeAdd(){} // RVA: 0x7A794ED90
        public void get_Item(){} // RVA: 0x7A794EDA0
        public void Rewind(){} // RVA: 0x7A794EDB0
        public void Clear(){} // RVA: 0x7A794EDC0
        public void Dispose(){} // RVA: 0x7A794EDD0
        public void RemoveAtSwapBack(){} // RVA: 0x7A794EDE0
        public void BlockIndexOfElement(){} // RVA: 0x7A794EDF0
        public void TrimExcess(){} // RVA: 0x7A794EE00
    }

    public class AutoFreeAllocator : ValueType
    {
        // ── Methods ──
        public void Update(){} // RVA: 0x7A7EA3B00
        public void FreeAll(){} // RVA: 0x7A7EA3B10
        public void Dispose(){} // RVA: 0x7A7EA3B20
        public void Try(){} // RVA: 0x7AEB660E0
        public void get_Handle(){} // RVA: 0x7A7690D90
        public void Try$BurstManaged(){} // RVA: 0x7AEB66140
    }

}