// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml
// Classes: 4
// Methods: 9

namespace ThirdParty.DotNet.System.Xml
{
    public class ReadContentAsBinaryHelper : Object
    {
        public object reader;
        public object state;
        public object valueOffset;
        public object isEnd;

        // ── Methods ──
        public void Finish(){} // RVA: 0x747A100
        public void Reset(){} // RVA: 0x747A350
        public void MoveToNextContentNode(){} // RVA: 0x747A360
    }

    public class ReaderPositionInfo : PositionInfo
    {
        public object lineInfo;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void HasLineInfo(){} // RVA: 0x74D3850
        public void get_LineNumber(){} // RVA: 0x74D38A0
        public void get_LinePosition(){} // RVA: 0x74D38F0
    }

    public class Ref : Object
    {
        // ── Methods ──
        public void Equal(){} // RVA: 0x2AFB5A0
    }

    public class Res : Object
    {
        // ── Methods ──
        public void GetString(){} // RVA: 0x74F68D0
    }

}