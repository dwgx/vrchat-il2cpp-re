// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.ProfanityFilter.Interfaces
// Classes: 2
// Methods: 16

namespace ThirdParty.Other.ProfanityFilter.Interfaces
{
    public class IAllowList
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7A7E18800
        public void Contains(){} // RVA: 0x7A7E019D0
        public void Remove(){} // RVA: 0x7A7E019D0
        public void Clear(){} // RVA: 0x7A7E18770
        public void get_Count(){} // RVA: 0x7A7E00710
        public void get_ToList(){} // RVA: 0x7A7E00680
    }

    public class IProfanityFilter
    {
        // ── Methods ──
        public void IsProfanity(){} // RVA: 0x7A7E019D0
        public void DetectAllProfanities(){} // RVA: 0x7A7E01780
        public void ContainsProfanity(){} // RVA: 0x7A7E019D0
        public void get_AllowList(){} // RVA: 0x7A7E00680
        public void CensorString(){} // RVA: 0x7A8051B10
        public void GetCompleteWord(){} // RVA: 0x7A8051B10
        public void AddProfanity(){} // RVA: 0x7A7E18800
        public void RemoveProfanity(){} // RVA: 0x7A7E019D0
        public void Clear(){} // RVA: 0x7A7E18770
        public void get_Count(){} // RVA: 0x7A7E00710
    }

}