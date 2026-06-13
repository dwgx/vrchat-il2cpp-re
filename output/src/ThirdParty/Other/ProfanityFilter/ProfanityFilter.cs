// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.ProfanityFilter
// Classes: 3
// Methods: 36

namespace ThirdParty.Other.ProfanityFilter
{
    public class AllowList
    {
        public System.Collections.Generic.List`1<string> _allowList; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x45D900
        public void get_ToList(){} // RVA: 0x45D9C0
        public void Add(){} // RVA: 0x45DA80
        public void Contains(){} // RVA: 0x45DCE0
        public void get_Count(){} // RVA: 0x45DE40
        public void Clear(){} // RVA: 0x45DE90
        public void Remove(){} // RVA: 0x45DF00
    }

    public class ProfanityBase
    {
        public System.Collections.Generic.List`1<string> _profanities; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x45E390 | overloaded x3
        public void AddProfanity(){} // RVA: 0x45E690 | overloaded x3
        public void RemoveProfanity(){} // RVA: 0x45EA70 | overloaded x3
        public void Clear(){} // RVA: 0x45EB30
        public void get_Count(){} // RVA: 0x45EBA0
    }

    public class ProfanityFilter
    {
        public ProfanityFilter.Interfaces.IAllowList <AllowList>k__BackingField; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x45F020 | overloaded x3
        public void get_AllowList(){} // RVA: 0x30B0C0
        public void IsProfanity(){} // RVA: 0x45F210
        public void DetectAllProfanities(){} // RVA: 0x45F440 | overloaded x2
        public void CensorString(){} // RVA: 0x45F930 | overloaded x3
        public void GetCompleteWord(){} // RVA: 0x45FBA0
        public void ContainsProfanity(){} // RVA: 0x460250
        public void CensorStringByProfanityList(){} // RVA: 0x460890
        public void FilterSwearListForCompleteWordsOnly(){} // RVA: 0x460F30
        public void FilterWordListByAllowList(){} // RVA: 0x461620
        public void ConvertWordListToSentence(){} // RVA: 0x461810
        public void AddMultiWordProfanities(){} // RVA: 0x4619C0
        public void CreateCensoredString(){} // RVA: 0x461B40
    }

}