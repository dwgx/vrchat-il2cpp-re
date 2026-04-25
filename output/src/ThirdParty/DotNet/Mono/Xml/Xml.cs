// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Xml
// Classes: 3
// Methods: 34

namespace ThirdParty.DotNet.Mono.Xml
{
    public class SecurityParser : SmallXmlParser
    {
        public System.Security.SecurityElement root; // 0x68
        public System.Security.SecurityElement current; // 0x70
        public System.Collections.Stack stack; // 0x78

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC838DA90
        public void LoadXml(){} // RVA: 0x7FFAC838DB40
        public void ToXml(){} // RVA: 0x7FFAC2F9CD50
        public void OnStartParsing(){} // RVA: 0x7FFAC2F21310
        public void OnProcessingInstruction(){} // RVA: 0x7FFAC2F21310
        public void OnIgnorableWhitespace(){} // RVA: 0x7FFAC2F21310
        public void OnStartElement(){} // RVA: 0x7FFAC838DC30
        public void OnEndElement(){} // RVA: 0x7FFAC838DFD0
        public void OnChars(){} // RVA: 0x7FFAC838E0D0
        public void OnEndParsing(){} // RVA: 0x7FFAC2F21310
    }

    public class SmallXmlParser : Object
    {
        public IContentHandler handler; // 0x10
        public System.IO.TextReader reader; // 0x18
        public System.Collections.Stack elementNames; // 0x20
        public System.Collections.Stack xmlSpaces; // 0x28
        public string xmlSpace; // 0x30
        public System.Text.StringBuilder buffer; // 0x38
        public char[] nameBuffer; // 0x40
        public bool isWhitespace; // 0x48
        public AttrListImpl attributes; // 0x50
        public int line; // 0x58
        public int column; // 0x5C
        public bool resetColumn; // 0x60

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC838E150
        public void Error(){} // RVA: 0x7FFAC838E580
        public void UnexpectedEndError(){} // RVA: 0x7FFAC838E6D0
        public void IsNameChar(){} // RVA: 0x7FFAC838E8D0
        public void IsWhitespace(){} // RVA: 0x7FFAC838E9E0
        public void SkipWhitespaces(){} // RVA: 0x7FFAC838EB60 | overloaded x2
        public void HandleWhitespaces(){} // RVA: 0x7FFAC838EA10
        public void Peek(){} // RVA: 0x7FFAC838EC40
        public void Read(){} // RVA: 0x7FFAC838EC70
        public void Expect(){} // RVA: 0x7FFAC838ECD0
        public void ReadUntil(){} // RVA: 0x7FFAC838EE00
        public void ReadName(){} // RVA: 0x7FFAC838EF80
        public void Parse(){} // RVA: 0x7FFAC838F1A0
        public void Cleanup(){} // RVA: 0x7FFAC838F3A0
        public void ReadContent(){} // RVA: 0x7FFAC838F540
        public void HandleBufferedContent(){} // RVA: 0x7FFAC83900B0
        public void ReadCharacters(){} // RVA: 0x7FFAC8390160
        public void ReadReference(){} // RVA: 0x7FFAC83902D0
        public void ReadCharacterReference(){} // RVA: 0x7FFAC8390630
        public void ReadAttribute(){} // RVA: 0x7FFAC8390820
        public void ReadCDATASection(){} // RVA: 0x7FFAC8390A90
        public void ReadComment(){} // RVA: 0x7FFAC8390CD0
    }

    public class SmallXmlParserException : SystemException
    {
        public int line; // 0x90
        public int column; // 0x94

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8391410
    }

}