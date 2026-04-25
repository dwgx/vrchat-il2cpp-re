// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml.Linq
// Classes: 25
// Methods: 218

namespace ThirdParty.DotNet.System.Xml.Linq
{
    public class BaseUriAnnotation : Object
    {
        public string baseUri; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
    }

    public class ElementWriter : ValueType
    {
        public System.Xml.XmlWriter _writer; // 0x10
        public System.Xml.Linq.NamespaceResolver _resolver; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC90A3CB0
        public void WriteElement(){} // RVA: 0x7FFAC90A3D10
        public void GetPrefixOfNamespace(){} // RVA: 0x7FFAC90A3F40
        public void PushAncestors(){} // RVA: 0x7FFAC90A4050
        public void PushElement(){} // RVA: 0x7FFAC90A4200
        public void WriteEndElement(){} // RVA: 0x7FFAC90A4350
        public void WriteFullEndElement(){} // RVA: 0x7FFAC90A4390
        public void WriteStartElement(){} // RVA: 0x7FFAC90A43D0
    }

    public class Extensions : Object
    {
        // ── Methods ──
        public void Descendants(){} // RVA: 0x7FFAC2C58FF0
        public void GetDescendants(){} // RVA: 0x7FFAC2C6A7D0
    }

    public class LineInfoAnnotation : Object
    {
        public int lineNumber; // 0x10
        public int linePosition; // 0x14

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC6CEC5A0
    }

    public class LineInfoEndElementAnnotation : LineInfoAnnotation
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC6CEC5A0
    }

    public class NamespaceCache : ValueType
    {
        public System.Xml.Linq.XNamespace _ns; // 0x10
        public string _namespaceName; // 0x18

        // ── Methods ──
        public void Get(){} // RVA: 0x7FFAC90A3B70
    }

    public class NamespaceResolver : ValueType
    {
        public int _scope; // 0x10
        public NamespaceDeclaration _declaration; // 0x18
        public NamespaceDeclaration _rover; // 0x20

        // ── Methods ──
        public void PushScope(){} // RVA: 0x7FFAC3BF5E40
        public void PopScope(){} // RVA: 0x7FFAC90A45F0
        public void Add(){} // RVA: 0x7FFAC90A4760
        public void AddFirst(){} // RVA: 0x7FFAC90A49E0
        public void GetPrefixOfNamespace(){} // RVA: 0x7FFAC90A4CB0
    }

    public class XAttribute : XObject
    {
        public System.Xml.Linq.XAttribute IsNamespaceDeclaration; // 0x20
        public System.Xml.Linq.XName Name; // 0x28
        public string NodeType; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9099990 | overloaded x2
        public void get_IsNamespaceDeclaration(){} // RVA: 0x7FFAC9099AC0
        public void get_Name(){} // RVA: 0x7FFAC2F4F130
        public void get_NodeType(){} // RVA: 0x7FFAC3026CB0
        public void get_Value(){} // RVA: 0x7FFAC31D95E0
        public void set_Value(){} // RVA: 0x7FFAC9099B90
        public void ToString(){} // RVA: 0x7FFAC9099D00
        public void GetPrefixOfNamespace(){} // RVA: 0x7FFAC909A190
        public void ValidateAttribute(){} // RVA: 0x7FFAC909A2F0
    }

    public class XCData : XText
    {
        public object NodeType;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC909A8C0 | overloaded x2
        public void get_NodeType(){} // RVA: 0x7FFAC36C3910
        public void WriteTo(){} // RVA: 0x7FFAC909A980
        public void CloneNode(){} // RVA: 0x7FFAC909AA00
    }

    public class XComment : XNode
    {
        public string NodeType; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC909ABA0 | overloaded x2
        public void get_NodeType(){} // RVA: 0x7FFAC3ED8E80
        public void get_Value(){} // RVA: 0x7FFAC2F4F130
        public void set_Value(){} // RVA: 0x7FFAC909AC60
        public void WriteTo(){} // RVA: 0x7FFAC909ADC0
        public void CloneNode(){} // RVA: 0x7FFAC909AE40
    }

    public class XContainer : XNode
    {
        public object LastNode; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC909AF30 | overloaded x2
        public void get_LastNode(){} // RVA: 0x7FFAC909B0E0
        public void Add(){} // RVA: 0x7FFAC909B260
        public void Descendants(){} // RVA: 0x7FFAC909B5F0
        public void Nodes(){} // RVA: 0x7FFAC909B750
        public void RemoveNodes(){} // RVA: 0x7FFAC909B800
        public void AddAttribute(){} // RVA: 0x7FFAC2F21310
        public void AddAttributeSkipNotify(){} // RVA: 0x7FFAC2F21310
        public void AddContentSkipNotify(){} // RVA: 0x7FFAC909BB90
        public void AddNode(){} // RVA: 0x7FFAC909BEF0
        public void AddNodeSkipNotify(){} // RVA: 0x7FFAC909BF90
        public void AddString(){} // RVA: 0x7FFAC909C030
        public void AddStringSkipNotify(){} // RVA: 0x7FFAC909C3B0
        public void AppendNode(){} // RVA: 0x7FFAC909C600
        public void AppendNodeSkipNotify(){} // RVA: 0x7FFAC909C730
        public void AppendText(){} // RVA: 0x7FFAC909C9A0
        public void ConvertTextToNode(){} // RVA: 0x7FFAC909CAA0
        public void GetDescendants(){} // RVA: 0x7FFAC909CC80
        public void GetStringValue(){} // RVA: 0x7FFAC909CDB0
        public void ReadContentFrom(){} // RVA: 0x7FFAC909D4D0 | overloaded x2
        public void RemoveNode(){} // RVA: 0x7FFAC909D750
        public void RemoveNodesSkipNotify(){} // RVA: 0x7FFAC909DAB0
        public void ValidateNode(){} // RVA: 0x7FFAC2F21310
        public void ValidateString(){} // RVA: 0x7FFAC2F21310
        public void WriteContentTo(){} // RVA: 0x7FFAC909DC60
    }

    public class XDeclaration : Object
    {
        public string Encoding; // 0x10
        public string Standalone; // 0x18
        public string Version; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC909FE50 | overloaded x3
        public void get_Encoding(){} // RVA: 0x7FFAC2F247C0
        public void set_Encoding(){} // RVA: 0x7FFAC2F87E80
        public void get_Standalone(){} // RVA: 0x7FFAC2F4F0C0
        public void set_Standalone(){} // RVA: 0x7FFAC2F4F0D0
        public void get_Version(){} // RVA: 0x7FFAC2F3C380
        public void ToString(){} // RVA: 0x7FFAC90A0040
    }

    public class XDocument : XContainer
    {
        public System.Xml.Linq.XDeclaration Declaration; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC90A0240 | overloaded x4
        public void get_Declaration(){} // RVA: 0x7FFAC31D95E0
        public void set_Declaration(){} // RVA: 0x7FFAC2F4F890
        public void get_NodeType(){} // RVA: 0x7FFAC41E44C0
        public void get_Root(){} // RVA: 0x7FFAC90A0410
        public void Load(){} // RVA: 0x7FFAC90A0570
        public void InitLoad(){} // RVA: 0x7FFAC90A0710
        public void Parse(){} // RVA: 0x7FFAC90A0900 | overloaded x2
        public void WriteTo(){} // RVA: 0x7FFAC90A0D20
        public void AddAttribute(){} // RVA: 0x7FFAC90A0ED0
        public void AddAttributeSkipNotify(){} // RVA: 0x7FFAC90A0F20
        public void CloneNode(){} // RVA: 0x7FFAC90A0F70
        public void GetFirstNode(){} // RVA: 0x7FFAC2E8DC40
        public void IsWhitespace(){} // RVA: 0x7FFAC90A0FD0
        public void ValidateNode(){} // RVA: 0x7FFAC90A1040
        public void ValidateDocument(){} // RVA: 0x7FFAC90A1270
        public void ValidateString(){} // RVA: 0x7FFAC90A13C0
    }

    public class XDocumentType : XNode
    {
        public string InternalSubset; // 0x28
        public string Name; // 0x30
        public string NodeType; // 0x38
        public string PublicId; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC90A1640 | overloaded x2
        public void get_InternalSubset(){} // RVA: 0x7FFAC2F9E740
        public void get_Name(){} // RVA: 0x7FFAC2F4F130
        public void get_NodeType(){} // RVA: 0x7FFAC314F980
        public void get_PublicId(){} // RVA: 0x7FFAC31D95E0
        public void get_SystemId(){} // RVA: 0x7FFAC31D0140
        public void WriteTo(){} // RVA: 0x7FFAC90A1820
        public void CloneNode(){} // RVA: 0x7FFAC90A18C0
    }

    public class XElement : XContainer
    {
        public System.Xml.Linq.XName EmptySequence; // 0x30
        public System.Xml.Linq.XAttribute HasAttributes; // 0x38

        // ── Methods ──
        public void get_EmptySequence(){} // RVA: 0x7FFAC90A1920
        public void .ctor(){} // RVA: 0x7FFAC90A1BF0 | overloaded x5
        public void get_HasAttributes(){} // RVA: 0x7FFAC484B3D0
        public void get_IsEmpty(){} // RVA: 0x7FFAC65A21D0
        public void get_Name(){} // RVA: 0x7FFAC31D95E0
        public void get_NodeType(){} // RVA: 0x7FFAC3013AF0
        public void get_Value(){} // RVA: 0x7FFAC90A1CC0
        public void set_Value(){} // RVA: 0x7FFAC90A1D70
        public void Attribute(){} // RVA: 0x7FFAC90A1DF0
        public void Attributes(){} // RVA: 0x7FFAC90A1E30
        public void GetPrefixOfNamespace(){} // RVA: 0x7FFAC90A1F40
        public void WriteTo(){} // RVA: 0x7FFAC90A2300
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x7FFAC34F9180
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x7FFAC90A2400
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x7FFAC69A3D80
        public void AddAttribute(){} // RVA: 0x7FFAC90A2620
        public void AddAttributeSkipNotify(){} // RVA: 0x7FFAC90A2810
        public void AppendAttribute(){} // RVA: 0x7FFAC90A2910
        public void AppendAttributeSkipNotify(){} // RVA: 0x7FFAC90A2A40
        public void CloneNode(){} // RVA: 0x7FFAC90A2C20
        public void GetAttributes(){} // RVA: 0x7FFAC90A2D60
        public void GetNamespaceOfPrefixInScope(){} // RVA: 0x7FFAC90A2E70
        public void ReadElementFrom(){} // RVA: 0x7FFAC90A2FB0
        public void ReadElementFromImpl(){} // RVA: 0x7FFAC90A3050
        public void SetEndElementLineInfo(){} // RVA: 0x7FFAC90A3620
        public void ValidateNode(){} // RVA: 0x7FFAC90A3690
    }

    public class XHashtable`1 : Object
    {
        public XHashtableState<T> _state;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C77970
        public void TryGetValue(){}
        public void Add(){} // RVA: 0x7FFAC2E8DC40
    }

    public class XName : Object
    {
        public System.Xml.Linq.XNamespace LocalName; // 0x10
        public string Namespace; // 0x18
        public int NamespaceName; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC90A5330 | overloaded x2
        public void get_LocalName(){} // RVA: 0x7FFAC2F247C0
        public void get_Namespace(){} // RVA: 0x7FFAC2F3C380
        public void get_NamespaceName(){} // RVA: 0x7FFAC3511350
        public void ToString(){} // RVA: 0x7FFAC90A4F90
        public void Get(){} // RVA: 0x7FFAC90A51F0 | overloaded x2
        public void op_Implicit(){} // RVA: 0x7FFAC90A52E0
        public void Equals(){} // RVA: 0x7FFAC530B460
        public void GetHashCode(){} // RVA: 0x7FFAC30DBBE0
        public void op_Equality(){} // RVA: 0x7FFAC530B460
        public void op_Inequality(){} // RVA: 0x7FFAC8650B50
        public void System.IEquatable<System.Xml.Linq.XName>.Equals(){} // RVA: 0x7FFAC530B460
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFAC90A52F0
    }

    public class XNamespace : Object
    {
        public System.Xml.Linq.XHashtable`1<System.WeakReference> NamespaceName;
        public System.WeakReference None; // 0x8
        public System.WeakReference Xml; // 0x10
        public System.WeakReference Xmlns; // 0x18
        public string _namespaceName; // 0x10
        public int _hashCode; // 0x18
        public System.Xml.Linq.XHashtable`1<System.Xml.Linq.XName> _names; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC90A5360
        public void get_NamespaceName(){} // RVA: 0x7FFAC2F3C380
        public void GetName(){} // RVA: 0x7FFAC90A5810 | overloaded x2
        public void ToString(){} // RVA: 0x7FFAC2F3C380
        public void get_None(){} // RVA: 0x7FFAC90A5590
        public void get_Xml(){} // RVA: 0x7FFAC90A5600
        public void get_Xmlns(){} // RVA: 0x7FFAC90A5660
        public void Get(){} // RVA: 0x7FFAC90A5A60 | overloaded x2
        public void op_Implicit(){} // RVA: 0x7FFAC90A5730
        public void op_Addition(){} // RVA: 0x7FFAC90A5750
        public void Equals(){} // RVA: 0x7FFAC530B460
        public void GetHashCode(){} // RVA: 0x7FFAC3157800
        public void op_Equality(){} // RVA: 0x7FFAC530B460
        public void op_Inequality(){} // RVA: 0x7FFAC8650B50
        public void ExtractLocalName(){} // RVA: 0x7FFAC38DFDA0
        public void ExtractNamespace(){} // RVA: 0x7FFAC90A5EC0
        public void EnsureNamespace(){} // RVA: 0x7FFAC90A5F40
    }

    public class XNode : XObject
    {
        public System.Xml.Linq.XNode next; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Remove(){} // RVA: 0x7FFAC90A60B0
        public void ToString(){} // RVA: 0x7FFAC90A6120
        public void WriteTo(){} // RVA: 0x7FFAC2C70A40
        public void AppendText(){} // RVA: 0x7FFAC2F21310
        public void CloneNode(){} // RVA: 0x7FFAC2C58E90
        public void GetXmlReaderSettings(){} // RVA: 0x7FFAC90A6150
        public void GetXmlString(){} // RVA: 0x7FFAC90A6270
    }

    public class XObject : Object
    {
        public System.Xml.Linq.XContainer BaseUri; // 0x10
        public object NodeType; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_BaseUri(){} // RVA: 0x7FFAC90A66F0
        public void get_NodeType(){} // RVA: 0x7FFAC2C59960
        public void get_Parent(){} // RVA: 0x7FFAC90A6780
        public void AddAnnotation(){} // RVA: 0x7FFAC90A6810
        public void AnnotationForSealedType(){} // RVA: 0x7FFAC90A6B50
        public void Annotation(){} // RVA: 0x7FFAC2E8DC40
        public void System.Xml.IXmlLineInfo.HasLineInfo(){} // RVA: 0x7FFAC90A6C90
        public void System.Xml.IXmlLineInfo.get_LineNumber(){} // RVA: 0x7FFAC90A6CE0
        public void System.Xml.IXmlLineInfo.get_LinePosition(){} // RVA: 0x7FFAC90A6D30
        public void get_HasBaseUri(){} // RVA: 0x7FFAC90A6D80
        public void NotifyChanged(){} // RVA: 0x7FFAC90A6DD0
        public void NotifyChanging(){} // RVA: 0x7FFAC90A6E80
        public void SetBaseUri(){} // RVA: 0x7FFAC90A6F30
        public void SetLineInfo(){} // RVA: 0x7FFAC90A6FE0
        public void SkipNotify(){} // RVA: 0x7FFAC90A7050
        public void GetSaveOptionsFromAnnotations(){} // RVA: 0x7FFAC90A70C0
    }

    public class XObjectChangeAnnotation : Object
    {
        public System.EventHandler`1<System.Xml.Linq.XObjectChangeEventArgs> changing; // 0x10
        public System.EventHandler`1<System.Xml.Linq.XObjectChangeEventArgs> changed; // 0x18
    }

    public class XObjectChangeEventArgs : EventArgs
    {
        public 0x6B2BF488 _objectChange; // 0x10
        public System.Xml.Linq.XObjectChangeEventArgs Add;
        public System.Xml.Linq.XObjectChangeEventArgs Remove; // 0x8
        public System.Xml.Linq.XObjectChangeEventArgs Name; // 0x10
        public System.Xml.Linq.XObjectChangeEventArgs Value; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC90A72E0
        public void .cctor(){} // RVA: 0x7FFAC90A7340
    }

    public class XProcessingInstruction : XNode
    {
        public string Data; // 0x28
        public string NodeType; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC90A7900 | overloaded x2
        public void get_Data(){} // RVA: 0x7FFAC31D95E0
        public void set_Data(){} // RVA: 0x7FFAC90A7A30
        public void get_NodeType(){} // RVA: 0x7FFAC36AE2C0
        public void get_Target(){} // RVA: 0x7FFAC2F4F130
        public void WriteTo(){} // RVA: 0x7FFAC90A7B90
        public void CloneNode(){} // RVA: 0x7FFAC90A7C20
        public void ValidateName(){} // RVA: 0x7FFAC90A7D60
    }

    public class XStreamingElement : Object
    {
        public System.Xml.Linq.XName name; // 0x10
        public object content; // 0x18
    }

    public class XText : XNode
    {
        public string NodeType; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC909A8C0 | overloaded x2
        public void get_NodeType(){} // RVA: 0x7FFAC366FE20
        public void get_Value(){} // RVA: 0x7FFAC2F4F130
        public void set_Value(){} // RVA: 0x7FFAC90A7ED0
        public void WriteTo(){} // RVA: 0x7FFAC90A8030
        public void AppendText(){} // RVA: 0x7FFAC90A8120
        public void CloneNode(){} // RVA: 0x7FFAC90A8150
    }

}