// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Util
// Classes: 5
// Methods: 25

namespace ThirdParty.DotNet.System.Security.Util
{
    public class Parser : Object
    {
        public System.Security.SecurityDocument _doc; // 0x10
        public System.Security.Util.Tokenizer _t; // 0x18

        // ── Methods ──
        public void GetTopElement(){} // RVA: 0x7FFAC83FF810
        public void GetRequiredSizes(){} // RVA: 0x7FFAC83FF840
        public void DetermineFormat(){} // RVA: 0x7FFAC8400010
        public void ParseContents(){} // RVA: 0x7FFAC84002A0
        public void .ctor(){} // RVA: 0x7FFAC8400A10 | overloaded x2
    }

    public class Tokenizer : Object
    {
        public int LineNo; // 0x10
        public int _inProcessingTag; // 0x14
        public byte[] _inBytes; // 0x18
        public char[] _inChars; // 0x20
        public string _inString; // 0x28
        public int _inIndex; // 0x30
        public int _inSize; // 0x34
        public int _inSavedCharacter; // 0x38
        public 0x6B0CB368 _inTokenSource; // 0x3C
        public ITokenReader _inTokenReader; // 0x40
        public StringMaker _maker; // 0x48
        public string[] _searchStrings; // 0x50
        public string[] _replaceStrings; // 0x58
        public int _inNestedIndex; // 0x60
        public int _inNestedSize; // 0x64
        public string _inNestedString; // 0x68

        // ── Methods ──
        public void BasicInitialization(){} // RVA: 0x7FFAC8400B90
        public void Recycle(){} // RVA: 0x7FFAC8400C50
        public void .ctor(){} // RVA: 0x7FFAC8400CA0
        public void ChangeFormat(){} // RVA: 0x7FFAC8400DE0
        public void GetTokens(){} // RVA: 0x7FFAC84010F0
        public void GetStringToken(){} // RVA: 0x7FFAC8401C20
    }

    public class TokenizerShortBlock : Object
    {
        public short[] m_block; // 0x10
        public System.Security.Util.TokenizerShortBlock m_next; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC84021E0
    }

    public class TokenizerStream : Object
    {
        public int m_countTokens; // 0x10
        public System.Security.Util.TokenizerShortBlock m_headTokens; // 0x18
        public System.Security.Util.TokenizerShortBlock m_lastTokens; // 0x20
        public System.Security.Util.TokenizerShortBlock m_currentTokens; // 0x28
        public int m_indexTokens; // 0x30
        public System.Security.Util.TokenizerStringBlock m_headStrings; // 0x38
        public System.Security.Util.TokenizerStringBlock m_currentStrings; // 0x40
        public int m_indexStrings; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8402300
        public void AddToken(){} // RVA: 0x7FFAC8402450
        public void AddString(){} // RVA: 0x7FFAC84025E0
        public void Reset(){} // RVA: 0x7FFAC8402760
        public void GetNextFullToken(){} // RVA: 0x7FFAC8402880
        public void GetNextToken(){} // RVA: 0x7FFAC84029B0
        public void GetNextString(){} // RVA: 0x7FFAC84029D0
        public void ThrowAwayNextString(){} // RVA: 0x7FFAC8402AA0
        public void TagLastToken(){} // RVA: 0x7FFAC8402AB0
        public void GetTokenCount(){} // RVA: 0x7FFAC2F6E5C0
        public void GoToPosition(){} // RVA: 0x7FFAC8402B40
    }

    public class TokenizerStringBlock : Object
    {
        public string[] m_block; // 0x10
        public System.Security.Util.TokenizerStringBlock m_next; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8402270
    }

}