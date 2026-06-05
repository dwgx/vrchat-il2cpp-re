// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml.Linq
// Classes: 25
// Methods: 218

namespace ThirdParty.DotNet.System.Xml.Linq
{
    public class BaseUriAnnotation
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
    }

    public class ElementWriter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF93BD190
        public void WriteElement(){} // RVA: 0x7FFAF93BD1F0
        public void GetPrefixOfNamespace(){} // RVA: 0x7FFAF93BD420
        public void PushAncestors(){} // RVA: 0x7FFAF93BD530
        public void PushElement(){} // RVA: 0x7FFAF93BD6E0
        public void WriteEndElement(){} // RVA: 0x7FFAF93BD830
        public void WriteFullEndElement(){} // RVA: 0x7FFAF93BD870
        public void WriteStartElement(){} // RVA: 0x7FFAF93BD8B0
    }

    public class Extensions
    {
        // ── Methods ──
        public void Descendants(){} // RVA: 0x7FFAF2ABCEC0
        public void GetDescendants(){} // RVA: 0x7FFAF2ACE780
    }

    public class LineInfoAnnotation
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF6EE8000
    }

    public class LineInfoEndElementAnnotation
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF6EE8000
    }

    public class NamespaceCache
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x7FFAF93BD050
    }

    public class NamespaceResolver
    {
        // ── Methods ──
        public void PushScope(){} // RVA: 0x7FFAF3BF8070
        public void PopScope(){} // RVA: 0x7FFAF93BDAD0
        public void Add(){} // RVA: 0x7FFAF93BDC40
        public void AddFirst(){} // RVA: 0x7FFAF93BDEC0
        public void GetPrefixOfNamespace(){} // RVA: 0x7FFAF93BE190
    }

    public class XAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF93B2E70 | overloaded x2
        public void get_IsNamespaceDeclaration(){} // RVA: 0x7FFAF93B2FA0
        public void get_Name(){} // RVA: 0x7FFAF2DBB130
        public void get_NodeType(){} // RVA: 0x7FFAF2E92CB0
        public void get_Value(){} // RVA: 0x7FFAF30E74D0
        public void set_Value(){} // RVA: 0x7FFAF93B3070
        public void ToString(){} // RVA: 0x7FFAF93B31E0
        public void GetPrefixOfNamespace(){} // RVA: 0x7FFAF93B3670
        public void ValidateAttribute(){} // RVA: 0x7FFAF93B37D0
    }

    public class XCData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF93B3DA0 | overloaded x2
        public void get_NodeType(){} // RVA: 0x7FFAF352E130
        public void WriteTo(){} // RVA: 0x7FFAF93B3E60
        public void CloneNode(){} // RVA: 0x7FFAF93B3EE0
    }

    public class XComment
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF93B4080 | overloaded x2
        public void get_NodeType(){} // RVA: 0x7FFAF3513AE0
        public void get_Value(){} // RVA: 0x7FFAF2DBB130
        public void set_Value(){} // RVA: 0x7FFAF93B4140
        public void WriteTo(){} // RVA: 0x7FFAF93B42A0
        public void CloneNode(){} // RVA: 0x7FFAF93B4320
    }

    public class XContainer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF93B4410 | overloaded x2
        public void get_LastNode(){} // RVA: 0x7FFAF93B45C0
        public void Add(){} // RVA: 0x7FFAF93B4740
        public void Descendants(){} // RVA: 0x7FFAF93B4AD0
        public void Nodes(){} // RVA: 0x7FFAF93B4C30
        public void RemoveNodes(){} // RVA: 0x7FFAF93B4CE0
        public void AddAttribute(){} // RVA: 0x7FFAF2D8D310
        public void AddAttributeSkipNotify(){} // RVA: 0x7FFAF2D8D310
        public void AddContentSkipNotify(){} // RVA: 0x7FFAF93B5070
        public void AddNode(){} // RVA: 0x7FFAF93B53D0
        public void AddNodeSkipNotify(){} // RVA: 0x7FFAF93B5470
        public void AddString(){} // RVA: 0x7FFAF93B5510
        public void AddStringSkipNotify(){} // RVA: 0x7FFAF93B5890
        public void AppendNode(){} // RVA: 0x7FFAF93B5AE0
        public void AppendNodeSkipNotify(){} // RVA: 0x7FFAF93B5C10
        public void AppendText(){} // RVA: 0x7FFAF93B5E80
        public void ConvertTextToNode(){} // RVA: 0x7FFAF93B5F80
        public void GetDescendants(){} // RVA: 0x7FFAF93B6160
        public void GetStringValue(){} // RVA: 0x7FFAF93B6290
        public void ReadContentFrom(){} // RVA: 0x7FFAF93B69B0 | overloaded x2
        public void RemoveNode(){} // RVA: 0x7FFAF93B6C30
        public void RemoveNodesSkipNotify(){} // RVA: 0x7FFAF93B6F90
        public void ValidateNode(){} // RVA: 0x7FFAF2D8D310
        public void ValidateString(){} // RVA: 0x7FFAF2D8D310
        public void WriteContentTo(){} // RVA: 0x7FFAF93B7140
    }

    public class XDeclaration
    {
        public object InternalSubset;
        public object Name;
        public object NodeType;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF93B9330 | overloaded x3
        public void get_Encoding(){} // RVA: 0x7FFAF2D907C0
        public void set_Encoding(){} // RVA: 0x7FFAF2DF3E80
        public void get_Standalone(){} // RVA: 0x7FFAF2DBB0C0
        public void set_Standalone(){} // RVA: 0x7FFAF2DBB0D0
        public void get_Version(){} // RVA: 0x7FFAF2DA8380
        public void ToString(){} // RVA: 0x7FFAF93B9520
    }

    public class XDocument
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF93B9720 | overloaded x4
        public void get_Declaration(){} // RVA: 0x7FFAF30E74D0
        public void set_Declaration(){} // RVA: 0x7FFAF2DBB890
        public void get_NodeType(){} // RVA: 0x7FFAF41E0F70
        public void get_Root(){} // RVA: 0x7FFAF93B98F0
        public void Load(){} // RVA: 0x7FFAF93B9A50
        public void InitLoad(){} // RVA: 0x7FFAF93B9BF0
        public void Parse(){} // RVA: 0x7FFAF93B9DE0 | overloaded x2
        public void WriteTo(){} // RVA: 0x7FFAF93BA200
        public void AddAttribute(){} // RVA: 0x7FFAF93BA3B0
        public void AddAttributeSkipNotify(){} // RVA: 0x7FFAF93BA400
        public void CloneNode(){} // RVA: 0x7FFAF93BA450
        public void GetFirstNode(){} // RVA: 0x7FFAF2D33FA0
        public void IsWhitespace(){} // RVA: 0x7FFAF93BA4B0
        public void ValidateNode(){} // RVA: 0x7FFAF93BA520
        public void ValidateDocument(){} // RVA: 0x7FFAF93BA750
        public void ValidateString(){} // RVA: 0x7FFAF93BA8A0
    }

    public class XDocumentType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF93BAB20 | overloaded x2
        public void get_InternalSubset(){} // RVA: 0x7FFAF2E0A740
        public void get_Name(){} // RVA: 0x7FFAF2DBB130
        public void get_NodeType(){} // RVA: 0x7FFAF3061C70
        public void get_PublicId(){} // RVA: 0x7FFAF30E74D0
        public void get_SystemId(){} // RVA: 0x7FFAF2F476A0
        public void WriteTo(){} // RVA: 0x7FFAF93BAD00
        public void CloneNode(){} // RVA: 0x7FFAF93BADA0
    }

    public class XElement
    {
        // ── Methods ──
        public void get_EmptySequence(){} // RVA: 0x7FFAF93BAE00
        public void .ctor(){} // RVA: 0x7FFAF93BB0D0 | overloaded x5
        public void get_HasAttributes(){} // RVA: 0x7FFAF47D58F0
        public void get_IsEmpty(){} // RVA: 0x7FFAF672C820
        public void get_Name(){} // RVA: 0x7FFAF30E74D0
        public void get_NodeType(){} // RVA: 0x7FFAF2E7FAF0
        public void get_Value(){} // RVA: 0x7FFAF93BB1A0
        public void set_Value(){} // RVA: 0x7FFAF93BB250
        public void Attribute(){} // RVA: 0x7FFAF93BB2D0
        public void Attributes(){} // RVA: 0x7FFAF93BB310
        public void GetPrefixOfNamespace(){} // RVA: 0x7FFAF93BB420
        public void WriteTo(){} // RVA: 0x7FFAF93BB7E0
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x7FFAF2FC9240
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x7FFAF93BB8E0
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x7FFAF6B3EFF0
        public void AddAttribute(){} // RVA: 0x7FFAF93BBB00
        public void AddAttributeSkipNotify(){} // RVA: 0x7FFAF93BBCF0
        public void AppendAttribute(){} // RVA: 0x7FFAF93BBDF0
        public void AppendAttributeSkipNotify(){} // RVA: 0x7FFAF93BBF20
        public void CloneNode(){} // RVA: 0x7FFAF93BC100
        public void GetAttributes(){} // RVA: 0x7FFAF93BC240
        public void GetNamespaceOfPrefixInScope(){} // RVA: 0x7FFAF93BC350
        public void ReadElementFrom(){} // RVA: 0x7FFAF93BC490
        public void ReadElementFromImpl(){} // RVA: 0x7FFAF93BC530
        public void SetEndElementLineInfo(){} // RVA: 0x7FFAF93BCB00
        public void ValidateNode(){} // RVA: 0x7FFAF93BCB70
    }

    public class XHashtable`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2ADBAA0
        public void TryGetValue(){}
        public void Add(){} // RVA: 0x7FFAF2D33FA0
    }

    public class XName
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF93BE810 | overloaded x2
        public void get_LocalName(){} // RVA: 0x7FFAF2D907C0
        public void get_Namespace(){} // RVA: 0x7FFAF2DA8380
        public void get_NamespaceName(){} // RVA: 0x7FFAF35DECF0
        public void ToString(){} // RVA: 0x7FFAF93BE470
        public void Get(){} // RVA: 0x7FFAF93BE6D0 | overloaded x2
        public void op_Implicit(){} // RVA: 0x7FFAF93BE7C0
        public void Equals(){} // RVA: 0x7FFAF5328D00
        public void GetHashCode(){} // RVA: 0x7FFAF3210030
        public void op_Equality(){} // RVA: 0x7FFAF5328D00
        public void op_Inequality(){} // RVA: 0x7FFAF89694A0
        public void System.IEquatable<System.Xml.Linq.XName>.Equals(){} // RVA: 0x7FFAF5328D00
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFAF93BE7D0
    }

    public class XNamespace
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF93BE840
        public void get_NamespaceName(){} // RVA: 0x7FFAF2DA8380
        public void GetName(){} // RVA: 0x7FFAF93BECF0 | overloaded x2
        public void ToString(){} // RVA: 0x7FFAF2DA8380
        public void get_None(){} // RVA: 0x7FFAF93BEA70
        public void get_Xml(){} // RVA: 0x7FFAF93BEAE0
        public void get_Xmlns(){} // RVA: 0x7FFAF93BEB40
        public void Get(){} // RVA: 0x7FFAF93BEF40 | overloaded x2
        public void op_Implicit(){} // RVA: 0x7FFAF93BEC10
        public void op_Addition(){} // RVA: 0x7FFAF93BEC30
        public void Equals(){} // RVA: 0x7FFAF5328D00
        public void GetHashCode(){} // RVA: 0x7FFAF306ED50
        public void op_Equality(){} // RVA: 0x7FFAF5328D00
        public void op_Inequality(){} // RVA: 0x7FFAF89694A0
        public void ExtractLocalName(){} // RVA: 0x7FFAF3ABA1F0
        public void ExtractNamespace(){} // RVA: 0x7FFAF93BF3A0
        public void EnsureNamespace(){} // RVA: 0x7FFAF93BF420
    }

    public class XNode
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void Remove(){} // RVA: 0x7FFAF93BF590
        public void ToString(){} // RVA: 0x7FFAF93BF600
        public void WriteTo(){} // RVA: 0x7FFAF2AD4B10
        public void AppendText(){} // RVA: 0x7FFAF2D8D310
        public void CloneNode(){} // RVA: 0x7FFAF2ABCD60
        public void GetXmlReaderSettings(){} // RVA: 0x7FFAF93BF630
        public void GetXmlString(){} // RVA: 0x7FFAF93BF750
    }

    public class XObject : p00
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void get_BaseUri(){} // RVA: 0x7FFAF93BFBD0
        public void get_NodeType(){} // RVA: 0x7FFAF2ABD840
        public void get_Parent(){} // RVA: 0x7FFAF93BFC60
        public void AddAnnotation(){} // RVA: 0x7FFAF93BFCF0
        public void AnnotationForSealedType(){} // RVA: 0x7FFAF93C0030
        public void Annotation(){} // RVA: 0x7FFAF2D33FA0
        public void System.Xml.IXmlLineInfo.HasLineInfo(){} // RVA: 0x7FFAF93C0170
        public void System.Xml.IXmlLineInfo.get_LineNumber(){} // RVA: 0x7FFAF93C01C0
        public void System.Xml.IXmlLineInfo.get_LinePosition(){} // RVA: 0x7FFAF93C0210
        public void get_HasBaseUri(){} // RVA: 0x7FFAF93C0260
        public void NotifyChanged(){} // RVA: 0x7FFAF93C02B0
        public void NotifyChanging(){} // RVA: 0x7FFAF93C0360
        public void SetBaseUri(){} // RVA: 0x7FFAF93C0410
        public void SetLineInfo(){} // RVA: 0x7FFAF93C04C0
        public void SkipNotify(){} // RVA: 0x7FFAF93C0530
        public void GetSaveOptionsFromAnnotations(){} // RVA: 0x7FFAF93C05A0
    }

    public class XObjectChangeAnnotation
    {
    }

    public class XObjectChangeEventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF93C07C0
        public void .cctor(){} // RVA: 0x7FFAF93C0820
    }

    public class XProcessingInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF93C0DE0 | overloaded x2
        public void get_Data(){} // RVA: 0x7FFAF30E74D0
        public void set_Data(){} // RVA: 0x7FFAF93C0F10
        public void get_NodeType(){} // RVA: 0x7FFAF3517BB0
        public void get_Target(){} // RVA: 0x7FFAF2DBB130
        public void WriteTo(){} // RVA: 0x7FFAF93C1070
        public void CloneNode(){} // RVA: 0x7FFAF93C1100
        public void ValidateName(){} // RVA: 0x7FFAF93C1240
    }

    public class XStreamingElement
    {
    }

    public class XText
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF93B3DA0 | overloaded x2
        public void get_NodeType(){} // RVA: 0x7FFAF34E08B0
        public void get_Value(){} // RVA: 0x7FFAF2DBB130
        public void set_Value(){} // RVA: 0x7FFAF93C13B0
        public void WriteTo(){} // RVA: 0x7FFAF93C1510
        public void AppendText(){} // RVA: 0x7FFAF93C1600
        public void CloneNode(){} // RVA: 0x7FFAF93C1630
    }

}