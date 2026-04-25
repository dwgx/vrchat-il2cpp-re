// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.ProfanityFilter
// Classes: 3
// Methods: 36

namespace ThirdParty.Other.ProfanityFilter
{
    public class AllowList : Object
    {
        public System.Collections.Generic.List`1<string> ToList; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC30A1900
        public void get_ToList(){} // RVA: 0x7FFAC30A19C0
        public void Add(){} // RVA: 0x7FFAC30A1A80
        public void Contains(){} // RVA: 0x7FFAC30A1CE0
        public void get_Count(){} // RVA: 0x7FFAC30A1E40
        public void Clear(){} // RVA: 0x7FFAC30A1E90
        public void Remove(){} // RVA: 0x7FFAC30A1F00
    }

    public class ProfanityBase : Object
    {
        public System.Collections.Generic.List`1<string> Count; // 0x10
        public string[] _wordList; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC30A2390 | overloaded x3
        public void AddProfanity(){} // RVA: 0x7FFAC30A2690 | overloaded x3
        public void RemoveProfanity(){} // RVA: 0x7FFAC30A2A70 | overloaded x3
        public void Clear(){} // RVA: 0x7FFAC30A2B30
        public void get_Count(){} // RVA: 0x7FFAC30A2BA0
    }

    public class ProfanityFilter : ProfanityBase
    {
        public ProfanityFilter.Interfaces.IAllowList AllowList; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC30A3020 | overloaded x3
        public void get_AllowList(){} // RVA: 0x7FFAC2F4F0C0
        public void IsProfanity(){} // RVA: 0x7FFAC30A3210
        public void DetectAllProfanities(){} // RVA: 0x7FFAC30A3440 | overloaded x2
        public void CensorString(){} // RVA: 0x7FFAC30A3930 | overloaded x3
        public void GetCompleteWord(){} // RVA: 0x7FFAC30A3BA0
        public void ContainsProfanity(){} // RVA: 0x7FFAC30A4250
        public void CensorStringByProfanityList(){} // RVA: 0x7FFAC30A4890
        public void FilterSwearListForCompleteWordsOnly(){} // RVA: 0x7FFAC30A4F30
        public void FilterWordListByAllowList(){} // RVA: 0x7FFAC30A5620
        public void ConvertWordListToSentence(){} // RVA: 0x7FFAC30A5810
        public void AddMultiWordProfanities(){} // RVA: 0x7FFAC30A59C0
        public void CreateCensoredString(){} // RVA: 0x7FFAC30A5B40
    }

}