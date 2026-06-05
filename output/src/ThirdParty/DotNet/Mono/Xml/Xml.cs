// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Xml
// Classes: 3
// Methods: 34

namespace ThirdParty.DotNet.Mono.Xml
{
    public class SecurityParser
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF86A6540
        public void LoadXml(){} // RVA: 0x7FFAF86A65F0
        public void ToXml(){} // RVA: 0x7FFAF2E08D50
        public void OnStartParsing(){} // RVA: 0x7FFAF2D8D310
        public void OnProcessingInstruction(){} // RVA: 0x7FFAF2D8D310
        public void OnIgnorableWhitespace(){} // RVA: 0x7FFAF2D8D310
        public void OnStartElement(){} // RVA: 0x7FFAF86A66E0
        public void OnEndElement(){} // RVA: 0x7FFAF86A6A80
        public void OnChars(){} // RVA: 0x7FFAF86A6B80
        public void OnEndParsing(){} // RVA: 0x7FFAF2D8D310
    }

    public class SmallXmlParser
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF86A6C00
        public void Error(){} // RVA: 0x7FFAF86A7030
        public void UnexpectedEndError(){} // RVA: 0x7FFAF86A7180
        public void IsNameChar(){} // RVA: 0x7FFAF86A7380
        public void IsWhitespace(){} // RVA: 0x7FFAF86A7490
        public void SkipWhitespaces(){} // RVA: 0x7FFAF86A7610 | overloaded x2
        public void HandleWhitespaces(){} // RVA: 0x7FFAF86A74C0
        public void Peek(){} // RVA: 0x7FFAF86A76F0
        public void Read(){} // RVA: 0x7FFAF86A7720
        public void Expect(){} // RVA: 0x7FFAF86A7780
        public void ReadUntil(){} // RVA: 0x7FFAF86A78B0
        public void ReadName(){} // RVA: 0x7FFAF86A7A30
        public void Parse(){} // RVA: 0x7FFAF86A7C50
        public void Cleanup(){} // RVA: 0x7FFAF86A7E50
        public void ReadContent(){} // RVA: 0x7FFAF86A7FF0
        public void HandleBufferedContent(){} // RVA: 0x7FFAF86A8B60
        public void ReadCharacters(){} // RVA: 0x7FFAF86A8C10
        public void ReadReference(){} // RVA: 0x7FFAF86A8D80
        public void ReadCharacterReference(){} // RVA: 0x7FFAF86A90E0
        public void ReadAttribute(){} // RVA: 0x7FFAF86A92D0
        public void ReadCDATASection(){} // RVA: 0x7FFAF86A9540
        public void ReadComment(){} // RVA: 0x7FFAF86A9780
    }

    public class SmallXmlParserException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF86A9EC0
    }

}