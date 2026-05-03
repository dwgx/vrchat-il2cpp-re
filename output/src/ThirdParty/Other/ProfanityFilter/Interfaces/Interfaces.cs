// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.ProfanityFilter.Interfaces
// Classes: 2
// Methods: 23

namespace ThirdParty.Other.ProfanityFilter.Interfaces
{
    public class IAllowList
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFE80E460A0
        public void Contains(){} // RVA: 0x7FFE80E2F3B0
        public void Remove(){} // RVA: 0x7FFE80E2F3B0
        public void Clear(){} // RVA: 0x7FFE80E45FE0
        public void get_Count(){} // RVA: 0x7FFE80E2EDB0
        public void get_ToList(){} // RVA: 0x7FFE80E2E2E0
    }

    public class IProfanityFilter
    {
        // ── Methods ──
        public void IsProfanity(){} // RVA: 0x7FFE80E2F3B0
        public void DetectAllProfanities(){} // RVA: 0x7FFE80E3EBB0 | overloaded x2
        public void ContainsProfanity(){} // RVA: 0x7FFE80E2F3B0
        public void get_AllowList(){} // RVA: 0x7FFE80E2E2E0
        public void CensorString(){} // RVA: 0x7FFE810A1420 | overloaded x3
        public void GetCompleteWord(){} // RVA: 0x7FFE810A1420
        public void AddProfanity(){} // RVA: 0x7FFE80E460A0 | overloaded x3
        public void RemoveProfanity(){} // RVA: 0x7FFE80E2F3B0 | overloaded x3
        public void Clear(){} // RVA: 0x7FFE80E45FE0
        public void get_Count(){} // RVA: 0x7FFE80E2EDB0
    }

}