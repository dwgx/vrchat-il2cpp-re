// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System
// Classes: 4
// Methods: 29

namespace ThirdParty.DotNet.System
{
    public class __ComObject : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC86B0AB0
    }

    public class __DTString : ValueType
    {
        public System.ReadOnlySpan`1<char> Length; // 0x10
        public int CompareInfo; // 0x20
        public char m_current; // 0x24
        public System.Globalization.CompareInfo m_info; // 0x28
        public bool m_checkDigitToken; // 0x30
        public char[] WhiteSpaceChecks;

        // ── Methods ──
        public void get_Length(){} // RVA: 0x7FFAC8627B50
        public void .ctor(){} // RVA: 0x7FFAC8627C20 | overloaded x2
        public void get_CompareInfo(){} // RVA: 0x7FFAC2F247C0
        public void GetNext(){} // RVA: 0x7FFAC8627EB0
        public void AtEnd(){} // RVA: 0x7FFAC8627F60
        public void Advance(){} // RVA: 0x7FFAC8627FE0
        public void GetRegularToken(){} // RVA: 0x7FFAC8628090
        public void GetSeparatorToken(){} // RVA: 0x7FFAC86283C0
        public void MatchSpecifiedWord(){} // RVA: 0x7FFAC8628600
        public void MatchSpecifiedWords(){} // RVA: 0x7FFAC8628750
        public void Match(){} // RVA: 0x7FFAC8628DB0 | overloaded x2
        public void MatchLongestWords(){} // RVA: 0x7FFAC8628E70
        public void GetRepeatCount(){} // RVA: 0x7FFAC8628F50
        public void GetNextDigit(){} // RVA: 0x7FFAC8629030
        public void GetChar(){} // RVA: 0x7FFAC8629100
        public void GetDigit(){} // RVA: 0x7FFAC8629120
        public void SkipWhiteSpaces(){} // RVA: 0x7FFAC8629150
        public void SkipWhiteSpaceCurrent(){} // RVA: 0x7FFAC8629220
        public void TrimTail(){} // RVA: 0x7FFAC8629370
        public void RemoveTrailingInQuoteSpaces(){} // RVA: 0x7FFAC86294B0
        public void RemoveLeadingInQuoteSpaces(){} // RVA: 0x7FFAC86297B0
        public void GetSubString(){} // RVA: 0x7FFAC8629B20
        public void ConsumeSubString(){} // RVA: 0x7FFAC8629C80
        public void .cctor(){} // RVA: 0x7FFAC8629D30
    }

    public class __Il2CppComDelegate : __Il2CppComObject
    {
        // ── Methods ──
        public void Finalize(){} // RVA: 0x7FFACC0F3980
    }

    public class __Il2CppComObject : Object
    {
        // ── Methods ──
        public void Finalize(){} // RVA: 0x7FFACC0F3980
    }

}