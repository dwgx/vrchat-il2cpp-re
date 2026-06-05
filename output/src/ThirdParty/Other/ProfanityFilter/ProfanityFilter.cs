// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.ProfanityFilter
// Classes: 3
// Methods: 36

namespace ThirdParty.Other.ProfanityFilter
{
    public class AllowList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2F0D900
        public void get_ToList(){} // RVA: 0x7FFAF2F0D9C0
        public void Add(){} // RVA: 0x7FFAF2F0DA80
        public void Contains(){} // RVA: 0x7FFAF2F0DCE0
        public void get_Count(){} // RVA: 0x7FFAF2F0DE40
        public void Clear(){} // RVA: 0x7FFAF2F0DE90
        public void Remove(){} // RVA: 0x7FFAF2F0DF00
    }

    public class ProfanityBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2F0E390 | overloaded x3
        public void AddProfanity(){} // RVA: 0x7FFAF2F0E690 | overloaded x3
        public void RemoveProfanity(){} // RVA: 0x7FFAF2F0EA70 | overloaded x3
        public void Clear(){} // RVA: 0x7FFAF2F0EB30
        public void get_Count(){} // RVA: 0x7FFAF2F0EBA0
    }

    public class ProfanityFilter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2F0F020 | overloaded x3
        public void get_AllowList(){} // RVA: 0x7FFAF2DBB0C0
        public void IsProfanity(){} // RVA: 0x7FFAF2F0F210
        public void DetectAllProfanities(){} // RVA: 0x7FFAF2F0F440 | overloaded x2
        public void CensorString(){} // RVA: 0x7FFAF2F0F930 | overloaded x3
        public void GetCompleteWord(){} // RVA: 0x7FFAF2F0FBA0
        public void ContainsProfanity(){} // RVA: 0x7FFAF2F10250
        public void CensorStringByProfanityList(){} // RVA: 0x7FFAF2F10890
        public void FilterSwearListForCompleteWordsOnly(){} // RVA: 0x7FFAF2F10F30
        public void FilterWordListByAllowList(){} // RVA: 0x7FFAF2F11620
        public void ConvertWordListToSentence(){} // RVA: 0x7FFAF2F11810
        public void AddMultiWordProfanities(){} // RVA: 0x7FFAF2F119C0
        public void CreateCensoredString(){} // RVA: 0x7FFAF2F11B40
    }

}