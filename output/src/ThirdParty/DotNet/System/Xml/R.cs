// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml
// Classes: 4
// Methods: 10

namespace ThirdParty.DotNet.System.Xml
{
    public class ReadContentAsBinaryHelper : Object
    {
        public System.Xml.XmlReader reader; // 0x10
        public 0x6B159BD8 state; // 0x18
        public int valueOffset; // 0x1C
        public bool isEnd; // 0x20

        // ── Methods ──
        public void Finish(){} // RVA: 0x7FFAC91AB350
        public void Reset(){} // RVA: 0x7FFAC91AB5A0
        public void MoveToNextContentNode(){} // RVA: 0x7FFAC91AB5B0
    }

    public class ReaderPositionInfo : PositionInfo
    {
        public System.Xml.IXmlLineInfo LineNumber; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void HasLineInfo(){} // RVA: 0x7FFAC9205350
        public void get_LineNumber(){} // RVA: 0x7FFAC92053A0
        public void get_LinePosition(){} // RVA: 0x7FFAC92053F0
    }

    public class Ref : Object
    {
        // ── Methods ──
        public void Equal(){} // RVA: 0x7FFAC530B460
    }

    public class Res : Object
    {
        // ── Methods ──
        public void GetString(){} // RVA: 0x7FFAC9228300 | overloaded x2
    }

}