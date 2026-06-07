// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.ProfanityFilter.Interfaces
// Classes: 2
// Methods: 23

namespace ThirdParty.Other.ProfanityFilter.Interfaces
{
    public class IAllowList
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x24B10
        public void Contains(){} // RVA: 0xDE40
        public void Remove(){} // RVA: 0xDE40
        public void Clear(){} // RVA: 0x24A50
        public void get_Count(){} // RVA: 0xD840
        public void get_ToList(){} // RVA: 0xCD60
    }

    public class IProfanityFilter
    {
        // ── Methods ──
        public void IsProfanity(){} // RVA: 0xDE40
        public void DetectAllProfanities(){} // RVA: 0x1D640 | overloaded x2
        public void ContainsProfanity(){} // RVA: 0xDE40
        public void get_AllowList(){} // RVA: 0xCD60
        public void CensorString(){} // RVA: 0x283FA0 | overloaded x3
        public void GetCompleteWord(){} // RVA: 0x283FA0
        public void AddProfanity(){} // RVA: 0x24B10 | overloaded x3
        public void RemoveProfanity(){} // RVA: 0xDE40 | overloaded x3
        public void Clear(){} // RVA: 0x24A50
        public void get_Count(){} // RVA: 0xD840
    }

}