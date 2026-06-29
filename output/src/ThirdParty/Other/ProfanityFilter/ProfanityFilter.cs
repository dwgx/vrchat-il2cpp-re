// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.ProfanityFilter
// Classes: 3
// Methods: 25

namespace ThirdParty.Other.ProfanityFilter
{
    public class AllowList : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xCCDEC0
        public void get_ToList(){} // RVA: 0xCCDF80
        public void Add(){} // RVA: 0xCCE040
        public void Contains(){} // RVA: 0xCCE2A0
        public void get_Count(){} // RVA: 0xCCE400
        public void Clear(){} // RVA: 0xCCE450
        public void Remove(){} // RVA: 0xCCE4C0
    }

    public class ProfanityBase : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xCCE950
        public void AddProfanity(){} // RVA: 0xCCEC50
        public void RemoveProfanity(){} // RVA: 0xCCF040
        public void Clear(){} // RVA: 0xCCF100
        public void get_Count(){} // RVA: 0xCCF170
    }

    public class ProfanityFilter : ProfanityBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xCCF5F0
        public void get_AllowList(){} // RVA: 0xB700F0
        public void IsProfanity(){} // RVA: 0xCCF7E0
        public void DetectAllProfanities(){} // RVA: 0xCCFA20
        public void CensorString(){} // RVA: 0xCCFF20
        public void GetCompleteWord(){} // RVA: 0xCD0180
        public void ContainsProfanity(){} // RVA: 0xCD0820
        public void CensorStringByProfanityList(){} // RVA: 0xCD0E90
        public void FilterSwearListForCompleteWordsOnly(){} // RVA: 0xCD1520
        public void FilterWordListByAllowList(){} // RVA: 0xCD1C20
        public void ConvertWordListToSentence(){} // RVA: 0xCD1E20
        public void AddMultiWordProfanities(){} // RVA: 0xCD1FC0
        public void CreateCensoredString(){} // RVA: 0xCD2140
    }

}