// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.ProfanityFilter
// Classes: 3
// Methods: 36

namespace ThirdParty.Other.ProfanityFilter
{
    public class AllowList : Object
    {
        public System.Collections.Generic.List`1<string> _allowList; // 0x10
        public object field_1; // 0x14F

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8127B900
        public void get_ToList(){} // RVA: 0x7FFE8127B9C0
        public void Add(){} // RVA: 0x7FFE8127BA80
        public void Contains(){} // RVA: 0x7FFE8127BCE0
        public void get_Count(){} // RVA: 0x7FFE8127BE40
        public void Clear(){} // RVA: 0x7FFE8127BE90
        public void Remove(){} // RVA: 0x7FFE8127BF00
    }

    public class ProfanityBase : Object
    {
        public System.Collections.Generic.List`1<string> _profanities; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8127C390 | overloaded x3
        public void AddProfanity(){} // RVA: 0x7FFE8127C690 | overloaded x3
        public void RemoveProfanity(){} // RVA: 0x7FFE8127CA70 | overloaded x3
        public void Clear(){} // RVA: 0x7FFE8127CB30
        public void get_Count(){} // RVA: 0x7FFE8127CBA0
    }

    public class ProfanityFilter : ProfanityBase
    {
        public ProfanityFilter.Interfaces.IAllowList _allowList; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8127D020 | overloaded x3
        public void get_AllowList(){} // RVA: 0x7FFE811290C0
        public void IsProfanity(){} // RVA: 0x7FFE8127D210
        public void DetectAllProfanities(){} // RVA: 0x7FFE8127D440 | overloaded x2
        public void CensorString(){} // RVA: 0x7FFE8127D930 | overloaded x3
        public void GetCompleteWord(){} // RVA: 0x7FFE8127DBA0
        public void ContainsProfanity(){} // RVA: 0x7FFE8127E250
        public void CensorStringByProfanityList(){} // RVA: 0x7FFE8127E890
        public void FilterSwearListForCompleteWordsOnly(){} // RVA: 0x7FFE8127EF30
        public void FilterWordListByAllowList(){} // RVA: 0x7FFE8127F620
        public void ConvertWordListToSentence(){} // RVA: 0x7FFE8127F810
        public void AddMultiWordProfanities(){} // RVA: 0x7FFE8127F9C0
        public void CreateCensoredString(){} // RVA: 0x7FFE8127FB40
    }

}