// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.ProfanityFilter
// Classes: 3
// Methods: 36

namespace ThirdParty.Other.ProfanityFilter
{
    public class AllowList : Object
    {
        public URA.woDigitYearMax<string> ToList; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E4C1900
        public void get_ToList(){} // RVA: 0x7FFD4E4C19C0
        public void Add(){} // RVA: 0x7FFD4E4C1A80
        public void Contains(){} // RVA: 0x7FFD4E4C1CE0
        public void get_Count(){} // RVA: 0x7FFD4E4C1E40
        public void Clear(){} // RVA: 0x7FFD4E4C1E90
        public void Remove(){} // RVA: 0x7FFD4E4C1F00
    }

    public class ProfanityBase : Object
    {
        public URA.woDigitYearMax<string> Count; // 0x10
        public string[] _wordList; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E4C2390 | overloaded x3
        public void AddProfanity(){} // RVA: 0x7FFD4E4C2690 | overloaded x3
        public void RemoveProfanity(){} // RVA: 0x7FFD4E4C2A70 | overloaded x3
        public void Clear(){} // RVA: 0x7FFD4E4C2B30
        public void get_Count(){} // RVA: 0x7FFD4E4C2BA0
    }

    public class ProfanityFilter : ProfanityBase
    {
        public ootLength.onstraint AllowList; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E4C3020 | overloaded x3
        public void get_AllowList(){} // RVA: 0x7FFD4E36F0C0
        public void IsProfanity(){} // RVA: 0x7FFD4E4C3210
        public void DetectAllProfanities(){} // RVA: 0x7FFD4E4C3440 | overloaded x2
        public void CensorString(){} // RVA: 0x7FFD4E4C3930 | overloaded x3
        public void GetCompleteWord(){} // RVA: 0x7FFD4E4C3BA0
        public void ContainsProfanity(){} // RVA: 0x7FFD4E4C4250
        public void CensorStringByProfanityList(){} // RVA: 0x7FFD4E4C4890
        public void FilterSwearListForCompleteWordsOnly(){} // RVA: 0x7FFD4E4C4F30
        public void FilterWordListByAllowList(){} // RVA: 0x7FFD4E4C5620
        public void ConvertWordListToSentence(){} // RVA: 0x7FFD4E4C5810
        public void AddMultiWordProfanities(){} // RVA: 0x7FFD4E4C59C0
        public void CreateCensoredString(){} // RVA: 0x7FFD4E4C5B40
    }

}