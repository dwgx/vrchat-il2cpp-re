// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Xml
// Classes: 3
// Methods: 34

namespace ThirdParty.DotNet.Mono.Xml
{
    public class SecurityParser
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5BF6540
        public void LoadXml(){} // RVA: 0x5BF65F0
        public void ToXml(){} // RVA: 0x358D50
        public void OnStartParsing(){} // RVA: 0x2DD310
        public void OnProcessingInstruction(){} // RVA: 0x2DD310
        public void OnIgnorableWhitespace(){} // RVA: 0x2DD310
        public void OnStartElement(){} // RVA: 0x5BF66E0
        public void OnEndElement(){} // RVA: 0x5BF6A80
        public void OnChars(){} // RVA: 0x5BF6B80
        public void OnEndParsing(){} // RVA: 0x2DD310
    }

    public class SmallXmlParser
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5BF6C00
        public void Error(){} // RVA: 0x5BF7030
        public void UnexpectedEndError(){} // RVA: 0x5BF7180
        public void IsNameChar(){} // RVA: 0x5BF7380
        public void IsWhitespace(){} // RVA: 0x5BF7490
        public void SkipWhitespaces(){} // RVA: 0x5BF7610 | overloaded x2
        public void HandleWhitespaces(){} // RVA: 0x5BF74C0
        public void Peek(){} // RVA: 0x5BF76F0
        public void Read(){} // RVA: 0x5BF7720
        public void Expect(){} // RVA: 0x5BF7780
        public void ReadUntil(){} // RVA: 0x5BF78B0
        public void ReadName(){} // RVA: 0x5BF7A30
        public void Parse(){} // RVA: 0x5BF7C50
        public void Cleanup(){} // RVA: 0x5BF7E50
        public void ReadContent(){} // RVA: 0x5BF7FF0
        public void HandleBufferedContent(){} // RVA: 0x5BF8B60
        public void ReadCharacters(){} // RVA: 0x5BF8C10
        public void ReadReference(){} // RVA: 0x5BF8D80
        public void ReadCharacterReference(){} // RVA: 0x5BF90E0
        public void ReadAttribute(){} // RVA: 0x5BF92D0
        public void ReadCDATASection(){} // RVA: 0x5BF9540
        public void ReadComment(){} // RVA: 0x5BF9780
    }

    public class SmallXmlParserException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5BF9EC0
    }

}