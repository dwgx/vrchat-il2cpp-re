// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Xml
// Classes: 3
// Methods: 33

namespace ThirdParty.DotNet.Mono.Xml
{
    public class SecurityParser : SmallXmlParser
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD9E4360
        public void LoadXml(){} // RVA: 0x7AD9E4410
        public void ToXml(){} // RVA: 0x7A8153390
        public void OnStartParsing(){} // RVA: 0x7A80D7310
        public void OnProcessingInstruction(){} // RVA: 0x7A80D7310
        public void OnIgnorableWhitespace(){} // RVA: 0x7A80D7310
        public void OnStartElement(){} // RVA: 0x7AD9E4500
        public void OnEndElement(){} // RVA: 0x7AD9E48A0
        public void OnChars(){} // RVA: 0x7AD9E4990
        public void OnEndParsing(){} // RVA: 0x7A80D7310
    }

    public class SmallXmlParser : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD9E4A10
        public void Error(){} // RVA: 0x7AD9E4E40
        public void UnexpectedEndError(){} // RVA: 0x7AD9E4F90
        public void IsNameChar(){} // RVA: 0x7AD9E5190
        public void IsWhitespace(){} // RVA: 0x7AD9E52A0
        public void SkipWhitespaces(){} // RVA: 0x7AD9E5420
        public void HandleWhitespaces(){} // RVA: 0x7AD9E52D0
        public void Peek(){} // RVA: 0x7AD9E5500
        public void Read(){} // RVA: 0x7AD9E5530
        public void Expect(){} // RVA: 0x7AD9E5590
        public void ReadUntil(){} // RVA: 0x7AD9E56C0
        public void ReadName(){} // RVA: 0x7AD9E5840
        public void Parse(){} // RVA: 0x7AD9E5A60
        public void Cleanup(){} // RVA: 0x7AD9E5C60
        public void ReadContent(){} // RVA: 0x7AD9E5E00
        public void HandleBufferedContent(){} // RVA: 0x7AD9E6970
        public void ReadCharacters(){} // RVA: 0x7AD9E6A20
        public void ReadReference(){} // RVA: 0x7AD9E6B90
        public void ReadCharacterReference(){} // RVA: 0x7AD9E6EF0
        public void ReadAttribute(){} // RVA: 0x7AD9E70E0
        public void ReadCDATASection(){} // RVA: 0x7AD9E7350
        public void ReadComment(){} // RVA: 0x7AD9E7590
    }

    public class SmallXmlParserException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD9E7CD0
    }

}