// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Util
// Classes: 5
// Methods: 24

namespace ThirdParty.DotNet.System.Security.Util
{
    public class Parser : Object
    {
        public object _doc;
        public object _t;

        // ── Methods ──
        public void GetTopElement(){} // RVA: 0x66E08B0
        public void GetRequiredSizes(){} // RVA: 0x66E08E0
        public void DetermineFormat(){} // RVA: 0x66E10B0
        public void ParseContents(){} // RVA: 0x66E1340
        public void .ctor(){} // RVA: 0x66E1AB0
    }

    public class Tokenizer : Object
    {
        public object LineNo;
        public object _inProcessingTag;
        public object _inBytes;
        public object _inChars;
        public object _inString;
        public object _inIndex;
        public object _inSize;
        public object _inSavedCharacter;
        public object _inTokenSource;
        public object _inTokenReader;
        public object _maker;
        public object _searchStrings;
        public object _replaceStrings;
        public object _inNestedIndex;
        public object _inNestedSize;
        public object _inNestedString;

        // ── Methods ──
        public void BasicInitialization(){} // RVA: 0x66E1C30
        public void Recycle(){} // RVA: 0x66E1CF0
        public void .ctor(){} // RVA: 0x66E1D40
        public void ChangeFormat(){} // RVA: 0x66E1E80
        public void GetTokens(){} // RVA: 0x66E2170
        public void GetStringToken(){} // RVA: 0x66E2CE0
    }

    public class TokenizerShortBlock : Object
    {
        public object m_block;
        public object m_next;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x66E32F0
    }

    public class TokenizerStream : Object
    {
        public object m_countTokens;
        public object m_headTokens;
        public object m_lastTokens;
        public object m_currentTokens;
        public object m_indexTokens;
        public object m_headStrings;
        public object m_currentStrings;
        public object m_indexStrings;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x66E3410
        public void AddToken(){} // RVA: 0x66E3560
        public void AddString(){} // RVA: 0x66E36F0
        public void Reset(){} // RVA: 0x66E3870
        public void GetNextFullToken(){} // RVA: 0x66E3990
        public void GetNextToken(){} // RVA: 0x66E3AC0
        public void GetNextString(){} // RVA: 0x66E3AE0
        public void ThrowAwayNextString(){} // RVA: 0x66E3BB0
        public void TagLastToken(){} // RVA: 0x66E3BC0
        public void GetTokenCount(){} // RVA: 0xB8F8F0
        public void GoToPosition(){} // RVA: 0x66E3C50
    }

    public class TokenizerStringBlock : Object
    {
        public object m_block;
        public object m_next;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x66E3380
    }

}