// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Collections
// Classes: 2
// Methods: 29

namespace ThirdParty.Other.Unity.Collections
{
    public class AllocatorManager : Object
    {
        public object Invalid;
        public object None;
        public object Temp;
        public object TempJob;
        public object Persistent;
        public object AudioKernel;
        public object NumGlobalScratchAllocators;
        public object MaxNumGlobalAllocators;
        public object GlobalAllocatorBaseIndex;
        public object FirstGlobalScratchpadAllocatorIndex;

        // ── Methods ──
        public void AllocateBlock(){} // RVA: 0x2D571B0
        public void Allocate(){} // RVA: 0x2D56DD0
        public void AllocateStruct(){} // RVA: 0xA94080
        public void FreeBlock(){} // RVA: 0x2D58CD0
        public void Free(){} // RVA: 0x2D587B0
        public void CheckDelegate(){} // RVA: 0x627FBA0
        public void UseDelegate(){} // RVA: 0x77D1580
        public void allocate_block(){} // RVA: 0x77D15D0
        public void forward_mono_allocate_block(){} // RVA: 0x77D1670
        public void LegacyOf(){} // RVA: 0x77D1790
        public void TryLegacy(){} // RVA: 0x77D17A0
        public void Try(){} // RVA: 0x77D1940
        public void IsCustomAllocator(){} // RVA: 0x77D1CB0
        public void .cctor(){} // RVA: 0x77D1CC0
    }

    public class Allocator[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB23C0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7B630
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8440
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6D5F0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7B630
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

}