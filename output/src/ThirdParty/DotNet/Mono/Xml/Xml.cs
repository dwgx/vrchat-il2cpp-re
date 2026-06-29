// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Xml
// Classes: 3
// Methods: 33

namespace ThirdParty.DotNet.Mono.Xml
{
    public class SecurityParser : SmallXmlParser
    {
        public object root;
        public object current;
        public object stack;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x666EFF0
        public void LoadXml(){} // RVA: 0x666F0A0
        public void ToXml(){} // RVA: 0xBBFF90
        public void OnStartParsing(){} // RVA: 0xB43310
        public void OnProcessingInstruction(){} // RVA: 0xB43310
        public void OnIgnorableWhitespace(){} // RVA: 0xB43310
        public void OnStartElement(){} // RVA: 0x666F190
        public void OnEndElement(){} // RVA: 0x666F530
        public void OnChars(){} // RVA: 0x666F620
        public void OnEndParsing(){} // RVA: 0xB43310
    }

    public class SmallXmlParser : Object
    {
        public object handler;
        public object reader;
        public object elementNames;
        public object xmlSpaces;
        public object xmlSpace;
        public object buffer;
        public object nameBuffer;
        public object isWhitespace;
        public object attributes;
        public object line;
        public object column;
        public object resetColumn;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x666F6A0
        public void Error(){} // RVA: 0x666FAD0
        public void UnexpectedEndError(){} // RVA: 0x666FC10
        public void IsNameChar(){} // RVA: 0x666FDD0
        public void IsWhitespace(){} // RVA: 0x666FEC0
        public void SkipWhitespaces(){} // RVA: 0x6670040
        public void HandleWhitespaces(){} // RVA: 0x666FEF0
        public void Peek(){} // RVA: 0x6670120
        public void Read(){} // RVA: 0x6670150
        public void Expect(){} // RVA: 0x66701B0
        public void ReadUntil(){} // RVA: 0x66702D0
        public void ReadName(){} // RVA: 0x6670450
        public void Parse(){} // RVA: 0x6670670
        public void Cleanup(){} // RVA: 0x6670870
        public void ReadContent(){} // RVA: 0x6670A10
        public void HandleBufferedContent(){} // RVA: 0x6671570
        public void ReadCharacters(){} // RVA: 0x6671620
        public void ReadReference(){} // RVA: 0x6671790
        public void ReadCharacterReference(){} // RVA: 0x6671AF0
        public void ReadAttribute(){} // RVA: 0x6671CE0
        public void ReadCDATASection(){} // RVA: 0x6671F50
        public void ReadComment(){} // RVA: 0x6672190
    }

    public class SmallXmlParserException : SystemException
    {
        public object line;
        public object column;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x66728D0
    }

}