// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.ProfanityFilter.Interfaces
// Classes: 2
// Methods: 23

namespace ThirdParty.Other.ProfanityFilter.Interfaces
{
    public class IAllowList
    {
        public object Count;
        public object ToList;

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFD4E090A40
        public void Contains(){} // RVA: 0x7FFD4E079F60
        public void Remove(){} // RVA: 0x7FFD4E079F60
        public void Clear(){} // RVA: 0x7FFD4E090980
        public void get_Count(){} // RVA: 0x7FFD4E079960
        public void get_ToList(){} // RVA: 0x7FFD4E078E90
    }

    public class IProfanityFilter
    {
        public object AllowList;
        public object Count;

        // ── Methods ──
        public void IsProfanity(){} // RVA: 0x7FFD4E079F60
        public void DetectAllProfanities(){} // RVA: 0x7FFD4E0896F0 | overloaded x2
        public void ContainsProfanity(){} // RVA: 0x7FFD4E079F60
        public void get_AllowList(){} // RVA: 0x7FFD4E078E90
        public void CensorString(){} // RVA: 0x7FFD4E2ADC40 | overloaded x3
        public void GetCompleteWord(){} // RVA: 0x7FFD4E2ADC40
        public void AddProfanity(){} // RVA: 0x7FFD4E090A40 | overloaded x3
        public void RemoveProfanity(){} // RVA: 0x7FFD4E079F60 | overloaded x3
        public void Clear(){} // RVA: 0x7FFD4E090980
        public void get_Count(){} // RVA: 0x7FFD4E079960
    }

}