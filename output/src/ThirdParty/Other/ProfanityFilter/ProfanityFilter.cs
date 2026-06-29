// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.ProfanityFilter
// Classes: 3
// Methods: 26

namespace ThirdParty.Other.ProfanityFilter
{
    public class AllowList : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8258C50
        public void get_ToList(){} // RVA: 0x7A8258D10
        public void Add(){} // RVA: 0x7A8258DD0
        public void Contains(){} // RVA: 0x7A8259030
        public void get_Count(){} // RVA: 0x7A8259190
        public void Clear(){} // RVA: 0x7A82591E0
        public void Remove(){} // RVA: 0x7A8259250
    }

    public class ProfanityBase : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A82596E0
        public void AddProfanity(){} // RVA: 0x7A82599E0
        public void RemoveProfanity(){} // RVA: 0x7A8259DD0
        public void Clear(){} // RVA: 0x7A8259E90
        public void get_Count(){} // RVA: 0x7A8259F00
        public void _profanities(){} // RVA: 0x7B2E3E010
    }

    public class ProfanityFilter : ProfanityBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A825A380
        public void get_AllowList(){} // RVA: 0x7A81052C0
        public void IsProfanity(){} // RVA: 0x7A825A570
        public void DetectAllProfanities(){} // RVA: 0x7A825A7B0
        public void CensorString(){} // RVA: 0x7A825ACB0
        public void GetCompleteWord(){} // RVA: 0x7A825AF20
        public void ContainsProfanity(){} // RVA: 0x7A825B5D0
        public void CensorStringByProfanityList(){} // RVA: 0x7A825BBF0
        public void FilterSwearListForCompleteWordsOnly(){} // RVA: 0x7A825C290
        public void FilterWordListByAllowList(){} // RVA: 0x7A825C990
        public void ConvertWordListToSentence(){} // RVA: 0x7A825CB90
        public void AddMultiWordProfanities(){} // RVA: 0x7A825CD40
        public void CreateCensoredString(){} // RVA: 0x7A825CEC0
    }

}