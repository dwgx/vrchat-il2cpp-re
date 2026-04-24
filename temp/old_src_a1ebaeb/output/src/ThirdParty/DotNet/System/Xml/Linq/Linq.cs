// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml.Linq
// Classes: 6
// Methods: 78

namespace ThirdParty.DotNet.System.Xml.Linq
{
    public class Extensions : Object
    {
        // ── Original Methods ──
        public void Descendants(){} // RVA: 0x7ffaa8649330
        // ── Binary Analysis Named ──
        public void GetDescendants(){} // RVA: 0x7ffaa865ab10
    }

    public class XContainer : XNode
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaeabcf00
        public void .ctor(){} // RVA: 0x7ffaaeabcf00
        public void get_LastNode(){} // RVA: 0x7ffaaeabd0b0
        public void Add(){} // RVA: 0x7ffaaeabd230
        public void Descendants(){} // RVA: 0x7ffaaeabd5c0
        public void Nodes(){} // RVA: 0x7ffaaeabd720
        public void RemoveNodes(){} // RVA: 0x7ffaaeabd7d0
        public void AddAttribute(){} // RVA: 0x7ffaa8932310
        public void AddAttributeSkipNotify(){} // RVA: 0x7ffaa8932310
        public void AddContentSkipNotify(){} // RVA: 0x7ffaaeabdb60
        public void AddNode(){} // RVA: 0x7ffaaeabdec0
        public void AddNodeSkipNotify(){} // RVA: 0x7ffaaeabdf60
        public void AddString(){} // RVA: 0x7ffaaeabe000
        public void AddStringSkipNotify(){} // RVA: 0x7ffaaeabe380
        public void AppendNode(){} // RVA: 0x7ffaaeabe5d0
        public void AppendNodeSkipNotify(){} // RVA: 0x7ffaaeabe700
        public void AppendText(){} // RVA: 0x7ffaaeabe970
        public void ConvertTextToNode(){} // RVA: 0x7ffaaeabea70
        public void ReadContentFrom(){} // RVA: 0x7ffaaeabf4a0
        public void ReadContentFrom(){} // RVA: 0x7ffaaeabf4a0
        public void RemoveNode(){} // RVA: 0x7ffaaeabf720
        public void RemoveNodesSkipNotify(){} // RVA: 0x7ffaaeabfa80
        public void ValidateNode(){} // RVA: 0x7ffaa8932310
        public void ValidateString(){} // RVA: 0x7ffaa8932310
        public void WriteContentTo(){} // RVA: 0x7ffaaeabfc30
        // ── Binary Analysis Named ──
        public void GetDescendants(){} // RVA: 0x7ffaaeabec50
        public void GetStringValue(){} // RVA: 0x7ffaaeabed80
    }

    public class XDocument : XContainer
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaeac2210
        public void .ctor(){} // RVA: 0x7ffaaeac2210
        public void .ctor(){} // RVA: 0x7ffaaeac2210
        public void .ctor(){} // RVA: 0x7ffaaeac2210
        public void get_Declaration(){} // RVA: 0x7ffaa8bfcc80
        public void set_Declaration(){} // RVA: 0x7ffaa8960890
        public void get_NodeType(){} // RVA: 0x7ffaa9c0a810
        public void get_Root(){} // RVA: 0x7ffaaeac23e0
        public void Load(){} // RVA: 0x7ffaaeac2540
        public void InitLoad(){} // RVA: 0x7ffaaeac26e0
        public void Parse(){} // RVA: 0x7ffaaeac28d0
        public void Parse(){} // RVA: 0x7ffaaeac28d0
        public void WriteTo(){} // RVA: 0x7ffaaeac2cf0
        public void AddAttribute(){} // RVA: 0x7ffaaeac2ea0
        public void AddAttributeSkipNotify(){} // RVA: 0x7ffaaeac2ef0
        public void CloneNode(){} // RVA: 0x7ffaaeac2f40
        public void IsWhitespace(){} // RVA: 0x7ffaaeac2fa0
        public void ValidateNode(){} // RVA: 0x7ffaaeac3010
        public void ValidateDocument(){} // RVA: 0x7ffaaeac3240
        public void ValidateString(){} // RVA: 0x7ffaaeac3390
        // ── Binary Analysis Named ──
        public void GetFirstNode(){} // RVA: 0x7ffaa887e5c0
    }

    public class XHashtable`1 : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8667cb0
        public void TryGetValue(){}
        public void Add(){} // RVA: 0x7ffaa887e5c0
    }

    public class XNode : XObject
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void Remove(){} // RVA: 0x7ffaaeac8080
        public void ToString(){} // RVA: 0x7ffaaeac80f0
        public void WriteTo(){} // RVA: 0x7ffaa8660d80
        public void AppendText(){} // RVA: 0x7ffaa8932310
        public void CloneNode(){} // RVA: 0x7ffaa86491d0
        // ── Binary Analysis Named ──
        public void GetXmlReaderSettings(){} // RVA: 0x7ffaaeac8120
        public void GetXmlString(){} // RVA: 0x7ffaaeac8240
    }

    public class XObject : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void get_BaseUri(){} // RVA: 0x7ffaaeac86c0
        public void get_NodeType(){} // RVA: 0x7ffaa8649ca0
        public void get_Parent(){} // RVA: 0x7ffaaeac8750
        public void AddAnnotation(){} // RVA: 0x7ffaaeac87e0
        public void AnnotationForSealedType(){} // RVA: 0x7ffaaeac8b20
        public void Annotation(){} // RVA: 0x7ffaa887e5c0
        public void System.Xml.IXmlLineInfo.HasLineInfo(){} // RVA: 0x7ffaaeac8c60
        public void System.Xml.IXmlLineInfo.get_LineNumber(){} // RVA: 0x7ffaaeac8cb0
        public void System.Xml.IXmlLineInfo.get_LinePosition(){} // RVA: 0x7ffaaeac8d00
        public void get_HasBaseUri(){} // RVA: 0x7ffaaeac8d50
        public void NotifyChanged(){} // RVA: 0x7ffaaeac8da0
        public void NotifyChanging(){} // RVA: 0x7ffaaeac8e50
        public void SkipNotify(){} // RVA: 0x7ffaaeac9020
        // ── Binary Analysis Named ──
        public void SetBaseUri(){} // RVA: 0x7ffaaeac8f00
        public void SetLineInfo(){} // RVA: 0x7ffaaeac8fb0
        public void GetSaveOptionsFromAnnotations(){} // RVA: 0x7ffaaeac9090
    }

}