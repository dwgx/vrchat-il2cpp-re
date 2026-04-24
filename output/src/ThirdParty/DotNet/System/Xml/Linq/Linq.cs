// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml.Linq
// Classes: 6
// Methods: 78

namespace ThirdParty.DotNet.System.Xml.Linq
{
    public class Extensions : Object
    {
        // ── Methods ──
        public void Descendants(){} // RVA: 0x7FFD4E078FF0
        public void GetDescendants(){} // RVA: 0x7FFD4E08A7D0
    }

    public class XContainer : XNode
    {
        public object LastNode;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD544BAF30 | overloaded x2
        public void get_LastNode(){} // RVA: 0x7FFD544BB0E0
        public void Add(){} // RVA: 0x7FFD544BB260
        public void Descendants(){} // RVA: 0x7FFD544BB5F0
        public void Nodes(){} // RVA: 0x7FFD544BB750
        public void RemoveNodes(){} // RVA: 0x7FFD544BB800
        public void AddAttribute(){} // RVA: 0x7FFD4E341310
        public void AddAttributeSkipNotify(){} // RVA: 0x7FFD4E341310
        public void AddContentSkipNotify(){} // RVA: 0x7FFD544BBB90
        public void AddNode(){} // RVA: 0x7FFD544BBEF0
        public void AddNodeSkipNotify(){} // RVA: 0x7FFD544BBF90
        public void AddString(){} // RVA: 0x7FFD544BC030
        public void AddStringSkipNotify(){} // RVA: 0x7FFD544BC3B0
        public void AppendNode(){} // RVA: 0x7FFD544BC600
        public void AppendNodeSkipNotify(){} // RVA: 0x7FFD544BC730
        public void AppendText(){} // RVA: 0x7FFD544BC9A0
        public void ConvertTextToNode(){} // RVA: 0x7FFD544BCAA0
        public void GetDescendants(){} // RVA: 0x7FFD544BCC80
        public void GetStringValue(){} // RVA: 0x7FFD544BCDB0
        public void ReadContentFrom(){} // RVA: 0x7FFD544BD4D0 | overloaded x2
        public void RemoveNode(){} // RVA: 0x7FFD544BD750
        public void RemoveNodesSkipNotify(){} // RVA: 0x7FFD544BDAB0
        public void ValidateNode(){} // RVA: 0x7FFD4E341310
        public void ValidateString(){} // RVA: 0x7FFD4E341310
        public void WriteContentTo(){} // RVA: 0x7FFD544BDC60
    }

    public class XDocument : XContainer
    {
        public object Declaration;
        public object NodeType;
        public object Root;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD544C0240 | overloaded x4
        public void get_Declaration(){} // RVA: 0x7FFD4E5F95E0
        public void set_Declaration(){} // RVA: 0x7FFD4E36F890
        public void get_NodeType(){} // RVA: 0x7FFD4F6044C0
        public void get_Root(){} // RVA: 0x7FFD544C0410
        public void Load(){} // RVA: 0x7FFD544C0570
        public void InitLoad(){} // RVA: 0x7FFD544C0710
        public void Parse(){} // RVA: 0x7FFD544C0900 | overloaded x2
        public void WriteTo(){} // RVA: 0x7FFD544C0D20
        public void AddAttribute(){} // RVA: 0x7FFD544C0ED0
        public void AddAttributeSkipNotify(){} // RVA: 0x7FFD544C0F20
        public void CloneNode(){} // RVA: 0x7FFD544C0F70
        public void GetFirstNode(){} // RVA: 0x7FFD4E2ADC40
        public void IsWhitespace(){} // RVA: 0x7FFD544C0FD0
        public void ValidateNode(){} // RVA: 0x7FFD544C1040
        public void ValidateDocument(){} // RVA: 0x7FFD544C1270
        public void ValidateString(){} // RVA: 0x7FFD544C13C0
    }

    public class XHashtable`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E097970
        public void TryGetValue(){}
        public void Add(){} // RVA: 0x7FFD4E2ADC40
    }

    public class XNode : XObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void Remove(){} // RVA: 0x7FFD544C60B0
        public void ToString(){} // RVA: 0x7FFD544C6120
        public void WriteTo(){} // RVA: 0x7FFD4E090A40
        public void AppendText(){} // RVA: 0x7FFD4E341310
        public void CloneNode(){} // RVA: 0x7FFD4E078E90
        public void GetXmlReaderSettings(){} // RVA: 0x7FFD544C6150
        public void GetXmlString(){} // RVA: 0x7FFD544C6270
    }

    public class XObject : Object
    {
        public object BaseUri;
        public object NodeType;
        public object Parent;
        public object System.Xml.IXmlLineInfo.LineNumber;
        public object System.Xml.IXmlLineInfo.LinePosition;
        public object HasBaseUri;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void get_BaseUri(){} // RVA: 0x7FFD544C66F0
        public void get_NodeType(){} // RVA: 0x7FFD4E079960
        public void get_Parent(){} // RVA: 0x7FFD544C6780
        public void AddAnnotation(){} // RVA: 0x7FFD544C6810
        public void AnnotationForSealedType(){} // RVA: 0x7FFD544C6B50
        public void Annotation(){} // RVA: 0x7FFD4E2ADC40
        public void System.Xml.IXmlLineInfo.HasLineInfo(){} // RVA: 0x7FFD544C6C90
        public void System.Xml.IXmlLineInfo.get_LineNumber(){} // RVA: 0x7FFD544C6CE0
        public void System.Xml.IXmlLineInfo.get_LinePosition(){} // RVA: 0x7FFD544C6D30
        public void get_HasBaseUri(){} // RVA: 0x7FFD544C6D80
        public void NotifyChanged(){} // RVA: 0x7FFD544C6DD0
        public void NotifyChanging(){} // RVA: 0x7FFD544C6E80
        public void SetBaseUri(){} // RVA: 0x7FFD544C6F30
        public void SetLineInfo(){} // RVA: 0x7FFD544C6FE0
        public void SkipNotify(){} // RVA: 0x7FFD544C7050
        public void GetSaveOptionsFromAnnotations(){} // RVA: 0x7FFD544C70C0
    }

}