// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml.Linq
// Classes: 23
// Methods: 196

namespace ThirdParty.DotNet.System.Xml.Linq
{
    public class BaseUriAnnotation : Object
    {
        public object baseUri;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
    }

    public class ElementWriter : ValueType
    {
        public object _writer;
        public object _resolver;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9139D0
        public void WriteElement(){} // RVA: 0x9139E0
        public void GetPrefixOfNamespace(){} // RVA: 0x9139F0
        public void PushAncestors(){} // RVA: 0x913A00
        public void PushElement(){} // RVA: 0x913A10
        public void WriteEndElement(){} // RVA: 0x913A20
        public void WriteFullEndElement(){} // RVA: 0x913A60
        public void WriteStartElement(){} // RVA: 0x913AA0
    }

    public class Extensions : Object
    {
        // ── Methods ──
        public void Descendants(){} // RVA: 0x87C630
        public void GetDescendants(){} // RVA: 0x88DF60
    }

    public class LineInfoAnnotation : Object
    {
        public object lineNumber;
        public object linePosition;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4F358F0
    }

    public class LineInfoEndElementAnnotation : LineInfoAnnotation
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4F358F0
    }

    public class NamespaceCache : ValueType
    {
        public object _ns;
        public object _namespaceName;

        // ── Methods ──
        public void Get(){} // RVA: 0x913900
    }

    public class NamespaceResolver : ValueType
    {
        public object _scope;
        public object _declaration;
        public object _rover;

        // ── Methods ──
        public void PushScope(){} // RVA: 0x56260
        public void PopScope(){} // RVA: 0x913B70
        public void Add(){} // RVA: 0x913B80
        public void AddFirst(){} // RVA: 0x913B90
        public void GetPrefixOfNamespace(){} // RVA: 0x913BA0
    }

    public class XAttribute : XObject
    {
        public object next;
        public object name;
        public object value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7367710
        public void get_IsNamespaceDeclaration(){} // RVA: 0x7367840
        public void get_Name(){} // RVA: 0xB70160
        public void get_NodeType(){} // RVA: 0xC50A80
        public void get_Value(){} // RVA: 0xD33E60
        public void set_Value(){} // RVA: 0x7367910
        public void ToString(){} // RVA: 0x7367A80
        public void GetPrefixOfNamespace(){} // RVA: 0x7367F10
        public void ValidateAttribute(){} // RVA: 0x7368060
    }

    public class XCData : XText
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7368630
        public void get_NodeType(){} // RVA: 0x1347420
        public void WriteTo(){} // RVA: 0x73686F0
        public void CloneNode(){} // RVA: 0x7368770
    }

    public class XComment : XNode
    {
        public object value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7368910
        public void get_NodeType(){} // RVA: 0x17FCE50
        public void get_Value(){} // RVA: 0xB70160
        public void set_Value(){} // RVA: 0x73689D0
        public void WriteTo(){} // RVA: 0x7368B30
        public void CloneNode(){} // RVA: 0x7368BB0
    }

    public class XContainer : XNode
    {
        public object content;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7368CA0
        public void get_LastNode(){} // RVA: 0x7368E40
        public void Add(){} // RVA: 0x7368FE0
        public void Descendants(){} // RVA: 0x7369330
        public void Nodes(){} // RVA: 0x7369490
        public void RemoveNodes(){} // RVA: 0x7369540
        public void AddAttribute(){} // RVA: 0xB43310
        public void AddAttributeSkipNotify(){} // RVA: 0xB43310
        public void AddContentSkipNotify(){} // RVA: 0x7369AA0
        public void AddNode(){} // RVA: 0x7369DE0
        public void AddNodeSkipNotify(){} // RVA: 0x7369E80
        public void AddString(){} // RVA: 0x7369F20
        public void AddStringSkipNotify(){} // RVA: 0x736A290
        public void AppendNode(){} // RVA: 0x736A4D0
        public void AppendNodeSkipNotify(){} // RVA: 0x736A600
        public void AppendText(){} // RVA: 0x736A860
        public void ConvertTextToNode(){} // RVA: 0x736A950
        public void GetDescendants(){} // RVA: 0x736AB20
        public void GetStringValue(){} // RVA: 0x736AC50
        public void ReadContentFrom(){} // RVA: 0x736B320
        public void RemoveNode(){} // RVA: 0x736B6D0
        public void RemoveNodesSkipNotify(){} // RVA: 0x736BA30
        public void ValidateNode(){} // RVA: 0xB43310
        public void ValidateString(){} // RVA: 0xB43310
        public void WriteContentTo(){} // RVA: 0x736BBE0
    }

    public class XDeclaration : Object
    {
        public object _version;
        public object _encoding;
        public object _standalone;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x736E150
        public void get_Encoding(){} // RVA: 0xB465B0
        public void set_Encoding(){} // RVA: 0xBA9BA0
        public void get_Standalone(){} // RVA: 0xB700F0
        public void set_Standalone(){} // RVA: 0xB70100
        public void get_Version(){} // RVA: 0xB5DBF0
        public void ToString(){} // RVA: 0x736E340
    }

    public class XDocument : XContainer
    {
        public object _declaration;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x736E540
        public void get_Declaration(){} // RVA: 0xD33E60
        public void set_Declaration(){} // RVA: 0xB708C0
        public void get_NodeType(){} // RVA: 0x2006E40
        public void get_Root(){} // RVA: 0x736E710
        public void Load(){} // RVA: 0x736E810
        public void InitLoad(){} // RVA: 0x736E9B0
        public void Parse(){} // RVA: 0x736EBA0
        public void WriteTo(){} // RVA: 0x736F110
        public void AddAttribute(){} // RVA: 0x736F2C0
        public void AddAttributeSkipNotify(){} // RVA: 0x736F310
        public void CloneNode(){} // RVA: 0x736F360
        public void GetFirstNode(){} // RVA: 0xA94080
        public void IsWhitespace(){} // RVA: 0x736F3C0
        public void ValidateNode(){} // RVA: 0x736F430
        public void ValidateDocument(){} // RVA: 0x736F660
        public void ValidateString(){} // RVA: 0x736F7B0
    }

    public class XDocumentType : XNode
    {
        public object _name;
        public object _publicId;
        public object _systemId;
        public object _internalSubset;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x736FA30
        public void get_InternalSubset(){} // RVA: 0xBC1B30
        public void get_Name(){} // RVA: 0xB70160
        public void get_NodeType(){} // RVA: 0xE49B40
        public void get_PublicId(){} // RVA: 0xD33E60
        public void get_SystemId(){} // RVA: 0xD05CA0
        public void WriteTo(){} // RVA: 0x736FC10
        public void CloneNode(){} // RVA: 0x736FCB0
    }

    public class XElement : XContainer
    {
        public object name;
        public object lastAttr;

        // ── Methods ──
        public void get_EmptySequence(){} // RVA: 0x736FE90
        public void .ctor(){} // RVA: 0x7370160
        public void get_HasAttributes(){} // RVA: 0x25D3F40
        public void get_IsEmpty(){} // RVA: 0x4702830
        public void get_Name(){} // RVA: 0xD33E60
        public void get_NodeType(){} // RVA: 0xC3CCE0
        public void get_Value(){} // RVA: 0x7370230
        public void set_Value(){} // RVA: 0x73702C0
        public void Attribute(){} // RVA: 0x7370340
        public void Attributes(){} // RVA: 0x7370380
        public void GetPrefixOfNamespace(){} // RVA: 0x7370490
        public void WriteTo(){} // RVA: 0x7370860
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0xDAC980
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x7370970
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x4B52F00
        public void AddAttribute(){} // RVA: 0x7370B90
        public void AddAttributeSkipNotify(){} // RVA: 0x7370D90
        public void AppendAttribute(){} // RVA: 0x7370E90
        public void AppendAttributeSkipNotify(){} // RVA: 0x7370FC0
        public void CloneNode(){} // RVA: 0x73711A0
        public void GetAttributes(){} // RVA: 0x73712E0
        public void GetNamespaceOfPrefixInScope(){} // RVA: 0x73713F0
        public void ReadElementFrom(){} // RVA: 0x7371530
        public void ReadElementFromImpl(){} // RVA: 0x73715D0
        public void SetEndElementLineInfo(){} // RVA: 0x7371B90
        public void ValidateNode(){} // RVA: 0x7371C00
    }

    public class XHashtable`1 : Object
    {
        public object _state;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x899290
        public void TryGetValue(){} // RVA: 0x880120
        public void Add(){} // RVA: 0xA94080
    }

    public class XName : Object
    {
        public object _ns;
        public object _localName;
        public object _hashCode;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7373A10
        public void get_LocalName(){} // RVA: 0xB465B0
        public void get_Namespace(){} // RVA: 0xB5DBF0
        public void get_NamespaceName(){} // RVA: 0x13F9340
        public void ToString(){} // RVA: 0x7373670
        public void Get(){} // RVA: 0x73738D0
        public void op_Implicit(){} // RVA: 0x73739C0
        public void Equals(){} // RVA: 0x2AFB5A0
        public void GetHashCode(){} // RVA: 0xFEAE90
        public void op_Equality(){} // RVA: 0x2AFB5A0
        public void op_Inequality(){} // RVA: 0xD12240
        public void System.IEquatable<System.Xml.Linq.XName>.Equals(){} // RVA: 0x2AFB5A0
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x73739D0
    }

    public class XNamespace : Object
    {
        public object s_namespaces;
        public object s_refNone;
        public object s_refXml;
        public object s_refXmlns;
        public object _namespaceName;
        public object _hashCode;
        public object _names;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7373A40
        public void get_NamespaceName(){} // RVA: 0xB5DBF0
        public void GetName(){} // RVA: 0x7373EE0
        public void ToString(){} // RVA: 0xB5DBF0
        public void get_None(){} // RVA: 0x7373C70
        public void get_Xml(){} // RVA: 0x7373CD0
        public void get_Xmlns(){} // RVA: 0x7373D30
        public void Get(){} // RVA: 0x7374120
        public void op_Implicit(){} // RVA: 0x7373E00
        public void op_Addition(){} // RVA: 0x7373E20
        public void Equals(){} // RVA: 0x2AFB5A0
        public void GetHashCode(){} // RVA: 0xE62D00
        public void op_Equality(){} // RVA: 0x2AFB5A0
        public void op_Inequality(){} // RVA: 0xD12240
        public void ExtractLocalName(){} // RVA: 0x18E1A10
        public void ExtractNamespace(){} // RVA: 0x73745A0
        public void EnsureNamespace(){} // RVA: 0x7374620
    }

    public class XNode : XObject
    {
        public object next;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void Remove(){} // RVA: 0x7374790
        public void ToString(){} // RVA: 0x7374800
        public void WriteTo(){} // RVA: 0x894320
        public void AppendText(){} // RVA: 0xB43310
        public void CloneNode(){} // RVA: 0x87C0A0
        public void GetXmlReaderSettings(){} // RVA: 0x7374830
        public void GetXmlString(){} // RVA: 0x7374950
    }

    public class XObject : Object
    {
        public object parent;
        public object annotations;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void get_BaseUri(){} // RVA: 0x7374DD0
        public void get_NodeType(){} // RVA: 0x87C130
        public void get_Parent(){} // RVA: 0x7374E50
        public void AddAnnotation(){} // RVA: 0x7374ED0
        public void AnnotationForSealedType(){} // RVA: 0x7375210
        public void Annotation(){} // RVA: 0xA94080
        public void System.Xml.IXmlLineInfo.HasLineInfo(){} // RVA: 0x7375330
        public void System.Xml.IXmlLineInfo.get_LineNumber(){} // RVA: 0x7375380
        public void System.Xml.IXmlLineInfo.get_LinePosition(){} // RVA: 0x73753D0
        public void get_HasBaseUri(){} // RVA: 0x7375420
        public void NotifyChanged(){} // RVA: 0x7375470
        public void NotifyChanging(){} // RVA: 0x7375520
        public void SetBaseUri(){} // RVA: 0x73755D0
        public void SetLineInfo(){} // RVA: 0x7375680
        public void SkipNotify(){} // RVA: 0x73756F0
        public void GetSaveOptionsFromAnnotations(){} // RVA: 0x7375760
    }

    public class XObjectChangeEventArgs : EventArgs
    {
        public object _objectChange;
        public object Add;
        public object Remove;
        public object Name;
        public object Value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7375950
        public void .cctor(){} // RVA: 0x73759B0
    }

    public class XProcessingInstruction : XNode
    {
        public object target;
        public object data;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7375F70
        public void get_Data(){} // RVA: 0xD33E60
        public void set_Data(){} // RVA: 0x73760A0
        public void get_NodeType(){} // RVA: 0x132D270
        public void get_Target(){} // RVA: 0xB70160
        public void WriteTo(){} // RVA: 0x7376200
        public void CloneNode(){} // RVA: 0x7376290
        public void ValidateName(){} // RVA: 0x73763D0
    }

    public class XText : XNode
    {
        public object text;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7368630
        public void get_NodeType(){} // RVA: 0x12FC4A0
        public void get_Value(){} // RVA: 0xB70160
        public void set_Value(){} // RVA: 0x7376540
        public void WriteTo(){} // RVA: 0x73766A0
        public void AppendText(){} // RVA: 0x7376790
        public void CloneNode(){} // RVA: 0x73767C0
    }

}