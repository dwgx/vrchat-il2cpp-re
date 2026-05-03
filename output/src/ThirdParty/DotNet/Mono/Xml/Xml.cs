// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Xml
// Classes: 3
// Methods: 34

namespace ThirdParty.DotNet.Mono.Xml
{
    public class SecurityParser : SmallXmlParser
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86737390
        public void LoadXml(){} // RVA: 0x7FFE86737440
        public void ToXml(){} // RVA: 0x7FFE81176D50
        public void OnStartParsing(){} // RVA: 0x7FFE810FB310
        public void OnProcessingInstruction(){} // RVA: 0x7FFE810FB310
        public void OnIgnorableWhitespace(){} // RVA: 0x7FFE810FB310
        public void OnStartElement(){} // RVA: 0x7FFE86737530
        public void OnEndElement(){} // RVA: 0x7FFE867378D0
        public void OnChars(){} // RVA: 0x7FFE867379D0
        public void OnEndParsing(){} // RVA: 0x7FFE810FB310
    }

    public class SmallXmlParser : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86737A50
        public void Error(){} // RVA: 0x7FFE86737E80
        public void UnexpectedEndError(){} // RVA: 0x7FFE86737FD0
        public void IsNameChar(){} // RVA: 0x7FFE867381D0
        public void IsWhitespace(){} // RVA: 0x7FFE867382E0
        public void SkipWhitespaces(){} // RVA: 0x7FFE86738460 | overloaded x2
        public void HandleWhitespaces(){} // RVA: 0x7FFE86738310
        public void Peek(){} // RVA: 0x7FFE86738540
        public void Read(){} // RVA: 0x7FFE86738570
        public void Expect(){} // RVA: 0x7FFE867385D0
        public void ReadUntil(){} // RVA: 0x7FFE86738700
        public void ReadName(){} // RVA: 0x7FFE86738880
        public void Parse(){} // RVA: 0x7FFE86738AA0
        public void Cleanup(){} // RVA: 0x7FFE86738CA0
        public void ReadContent(){} // RVA: 0x7FFE86738E40
        public void HandleBufferedContent(){} // RVA: 0x7FFE867399B0
        public void ReadCharacters(){} // RVA: 0x7FFE86739A60
        public void ReadReference(){} // RVA: 0x7FFE86739BD0
        public void ReadCharacterReference(){} // RVA: 0x7FFE86739F30
        public void ReadAttribute(){} // RVA: 0x7FFE8673A120
        public void ReadCDATASection(){} // RVA: 0x7FFE8673A390
        public void ReadComment(){} // RVA: 0x7FFE8673A5D0
    }

    public class SmallXmlParserException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8673AD10
    }

}