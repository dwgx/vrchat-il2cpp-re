// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml.Linq
// Classes: 25
// Methods: 218

namespace ThirdParty.DotNet.System.Xml.Linq
{
    public class BaseUriAnnotation
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
    }

    public class ElementWriter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x690D190
        public void WriteElement(){} // RVA: 0x690D1F0
        public void GetPrefixOfNamespace(){} // RVA: 0x690D420
        public void PushAncestors(){} // RVA: 0x690D530
        public void PushElement(){} // RVA: 0x690D6E0
        public void WriteEndElement(){} // RVA: 0x690D830
        public void WriteFullEndElement(){} // RVA: 0x690D870
        public void WriteStartElement(){} // RVA: 0x690D8B0
    }

    public class Extensions
    {
        // ── Methods ──
        public void Descendants(){} // RVA: 0xCEC0
        public void GetDescendants(){} // RVA: 0x1E780
    }

    public class LineInfoAnnotation
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4438000
    }

    public class LineInfoEndElementAnnotation
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4438000
    }

    public class NamespaceCache
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x690D050
    }

    public class NamespaceResolver
    {
        // ── Methods ──
        public void PushScope(){} // RVA: 0x1148070
        public void PopScope(){} // RVA: 0x690DAD0
        public void Add(){} // RVA: 0x690DC40
        public void AddFirst(){} // RVA: 0x690DEC0
        public void GetPrefixOfNamespace(){} // RVA: 0x690E190
    }

    public class XAttribute
    {
        public System.Xml.Linq.XAttribute next; // 0x20
        public System.Xml.Linq.XName name; // 0x28
        public string value; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6902E70 | overloaded x2
        public void get_IsNamespaceDeclaration(){} // RVA: 0x6902FA0
        public void get_Name(){} // RVA: 0x30B130
        public void get_NodeType(){} // RVA: 0x3E2CB0
        public void get_Value(){} // RVA: 0x6374D0
        public void set_Value(){} // RVA: 0x6903070
        public void ToString(){} // RVA: 0x69031E0
        public void GetPrefixOfNamespace(){} // RVA: 0x6903670
        public void ValidateAttribute(){} // RVA: 0x69037D0
    }

    public class XCData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6903DA0 | overloaded x2
        public void get_NodeType(){} // RVA: 0xA7E130
        public void WriteTo(){} // RVA: 0x6903E60
        public void CloneNode(){} // RVA: 0x6903EE0
    }

    public class XComment
    {
        public string value; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6904080 | overloaded x2
        public void get_NodeType(){} // RVA: 0xA63AE0
        public void get_Value(){} // RVA: 0x30B130
        public void set_Value(){} // RVA: 0x6904140
        public void WriteTo(){} // RVA: 0x69042A0
        public void CloneNode(){} // RVA: 0x6904320
    }

    public class XContainer
    {
        public object content; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6904410 | overloaded x2
        public void get_LastNode(){} // RVA: 0x69045C0
        public void Add(){} // RVA: 0x6904740
        public void Descendants(){} // RVA: 0x6904AD0
        public void Nodes(){} // RVA: 0x6904C30
        public void RemoveNodes(){} // RVA: 0x6904CE0
        public void AddAttribute(){} // RVA: 0x2DD310
        public void AddAttributeSkipNotify(){} // RVA: 0x2DD310
        public void AddContentSkipNotify(){} // RVA: 0x6905070
        public void AddNode(){} // RVA: 0x69053D0
        public void AddNodeSkipNotify(){} // RVA: 0x6905470
        public void AddString(){} // RVA: 0x6905510
        public void AddStringSkipNotify(){} // RVA: 0x6905890
        public void AppendNode(){} // RVA: 0x6905AE0
        public void AppendNodeSkipNotify(){} // RVA: 0x6905C10
        public void AppendText(){} // RVA: 0x6905E80
        public void ConvertTextToNode(){} // RVA: 0x6905F80
        public void GetDescendants(){} // RVA: 0x6906160
        public void GetStringValue(){} // RVA: 0x6906290
        public void ReadContentFrom(){} // RVA: 0x69069B0 | overloaded x2
        public void RemoveNode(){} // RVA: 0x6906C30
        public void RemoveNodesSkipNotify(){} // RVA: 0x6906F90
        public void ValidateNode(){} // RVA: 0x2DD310
        public void ValidateString(){} // RVA: 0x2DD310
        public void WriteContentTo(){} // RVA: 0x6907140
    }

    public class XDeclaration
    {
        public string InternalSubset; // 0x10
        public string Name; // 0x18
        public string NodeType; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6909330 | overloaded x3
        public void get_Encoding(){} // RVA: 0x2E07C0
        public void set_Encoding(){} // RVA: 0x343E80
        public void get_Standalone(){} // RVA: 0x30B0C0
        public void set_Standalone(){} // RVA: 0x30B0D0
        public void get_Version(){} // RVA: 0x2F8380
        public void ToString(){} // RVA: 0x6909520
    }

    public class XDocument
    {
        public System.Xml.Linq.XDeclaration _declaration; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6909720 | overloaded x4
        public void get_Declaration(){} // RVA: 0x6374D0
        public void set_Declaration(){} // RVA: 0x30B890
        public void get_NodeType(){} // RVA: 0x1730F70
        public void get_Root(){} // RVA: 0x69098F0
        public void Load(){} // RVA: 0x6909A50
        public void InitLoad(){} // RVA: 0x6909BF0
        public void Parse(){} // RVA: 0x6909DE0 | overloaded x2
        public void WriteTo(){} // RVA: 0x690A200
        public void AddAttribute(){} // RVA: 0x690A3B0
        public void AddAttributeSkipNotify(){} // RVA: 0x690A400
        public void CloneNode(){} // RVA: 0x690A450
        public void GetFirstNode(){} // RVA: 0x283FA0
        public void IsWhitespace(){} // RVA: 0x690A4B0
        public void ValidateNode(){} // RVA: 0x690A520
        public void ValidateDocument(){} // RVA: 0x690A750
        public void ValidateString(){} // RVA: 0x690A8A0
    }

    public class XDocumentType
    {
        public string _name; // 0x28
        public string _publicId; // 0x30
        public string _systemId; // 0x38
        public string _internalSubset; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x690AB20 | overloaded x2
        public void get_InternalSubset(){} // RVA: 0x35A740
        public void get_Name(){} // RVA: 0x30B130
        public void get_NodeType(){} // RVA: 0x5B1C70
        public void get_PublicId(){} // RVA: 0x6374D0
        public void get_SystemId(){} // RVA: 0x4976A0
        public void WriteTo(){} // RVA: 0x690AD00
        public void CloneNode(){} // RVA: 0x690ADA0
    }

    public class XElement
    {
        public System.Xml.Linq.XName name; // 0x30
        public System.Xml.Linq.XAttribute lastAttr; // 0x38

        // ── Methods ──
        public void get_EmptySequence(){} // RVA: 0x690AE00
        public void .ctor(){} // RVA: 0x690B0D0 | overloaded x5
        public void get_HasAttributes(){} // RVA: 0x1D258F0
        public void get_IsEmpty(){} // RVA: 0x3C7C820
        public void get_Name(){} // RVA: 0x6374D0
        public void get_NodeType(){} // RVA: 0x3CFAF0
        public void get_Value(){} // RVA: 0x690B1A0
        public void set_Value(){} // RVA: 0x690B250
        public void Attribute(){} // RVA: 0x690B2D0
        public void Attributes(){} // RVA: 0x690B310
        public void GetPrefixOfNamespace(){} // RVA: 0x690B420
        public void WriteTo(){} // RVA: 0x690B7E0
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x519240
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x690B8E0
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x408EFF0
        public void AddAttribute(){} // RVA: 0x690BB00
        public void AddAttributeSkipNotify(){} // RVA: 0x690BCF0
        public void AppendAttribute(){} // RVA: 0x690BDF0
        public void AppendAttributeSkipNotify(){} // RVA: 0x690BF20
        public void CloneNode(){} // RVA: 0x690C100
        public void GetAttributes(){} // RVA: 0x690C240
        public void GetNamespaceOfPrefixInScope(){} // RVA: 0x690C350
        public void ReadElementFrom(){} // RVA: 0x690C490
        public void ReadElementFromImpl(){} // RVA: 0x690C530
        public void SetEndElementLineInfo(){} // RVA: 0x690CB00
        public void ValidateNode(){} // RVA: 0x690CB70
    }

    public class XHashtable`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2BAA0
        public void TryGetValue(){}
        public void Add(){} // RVA: 0x283FA0
    }

    public class XName
    {
        public System.Xml.Linq.XNamespace _ns; // 0x10
        public string _localName; // 0x18
        public int _hashCode; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x690E810 | overloaded x2
        public void get_LocalName(){} // RVA: 0x2E07C0
        public void get_Namespace(){} // RVA: 0x2F8380
        public void get_NamespaceName(){} // RVA: 0xB2ECF0
        public void ToString(){} // RVA: 0x690E470
        public void Get(){} // RVA: 0x690E6D0 | overloaded x2
        public void op_Implicit(){} // RVA: 0x690E7C0
        public void Equals(){} // RVA: 0x2878D00
        public void GetHashCode(){} // RVA: 0x760030
        public void op_Equality(){} // RVA: 0x2878D00
        public void op_Inequality(){} // RVA: 0x5EB94A0
        public void System.IEquatable<System.Xml.Linq.XName>.Equals(){} // RVA: 0x2878D00
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x690E7D0
    }

    public class XNamespace
    {
        public System.Xml.Linq.XHashtable`1<System.WeakReference> s_namespaces;
        public System.WeakReference s_refNone; // 0x8
        public System.WeakReference s_refXml; // 0x10
        public System.WeakReference s_refXmlns; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x690E840
        public void get_NamespaceName(){} // RVA: 0x2F8380
        public void GetName(){} // RVA: 0x690ECF0 | overloaded x2
        public void ToString(){} // RVA: 0x2F8380
        public void get_None(){} // RVA: 0x690EA70
        public void get_Xml(){} // RVA: 0x690EAE0
        public void get_Xmlns(){} // RVA: 0x690EB40
        public void Get(){} // RVA: 0x690EF40 | overloaded x2
        public void op_Implicit(){} // RVA: 0x690EC10
        public void op_Addition(){} // RVA: 0x690EC30
        public void Equals(){} // RVA: 0x2878D00
        public void GetHashCode(){} // RVA: 0x5BED50
        public void op_Equality(){} // RVA: 0x2878D00
        public void op_Inequality(){} // RVA: 0x5EB94A0
        public void ExtractLocalName(){} // RVA: 0x100A1F0
        public void ExtractNamespace(){} // RVA: 0x690F3A0
        public void EnsureNamespace(){} // RVA: 0x690F420
    }

    public class XNode
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void Remove(){} // RVA: 0x690F590
        public void ToString(){} // RVA: 0x690F600
        public void WriteTo(){} // RVA: 0x24B10
        public void AppendText(){} // RVA: 0x2DD310
        public void CloneNode(){} // RVA: 0xCD60
        public void GetXmlReaderSettings(){} // RVA: 0x690F630
        public void GetXmlString(){} // RVA: 0x690F750
    }

    public class XObject : p00
    {
        public System.Xml.Linq.XContainer parent; // 0x10
        public object annotations; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void get_BaseUri(){} // RVA: 0x690FBD0
        public void get_NodeType(){} // RVA: 0xD840
        public void get_Parent(){} // RVA: 0x690FC60
        public void AddAnnotation(){} // RVA: 0x690FCF0
        public void AnnotationForSealedType(){} // RVA: 0x6910030
        public void Annotation(){} // RVA: 0x283FA0
        public void System.Xml.IXmlLineInfo.HasLineInfo(){} // RVA: 0x6910170
        public void System.Xml.IXmlLineInfo.get_LineNumber(){} // RVA: 0x69101C0
        public void System.Xml.IXmlLineInfo.get_LinePosition(){} // RVA: 0x6910210
        public void get_HasBaseUri(){} // RVA: 0x6910260
        public void NotifyChanged(){} // RVA: 0x69102B0
        public void NotifyChanging(){} // RVA: 0x6910360
        public void SetBaseUri(){} // RVA: 0x6910410
        public void SetLineInfo(){} // RVA: 0x69104C0
        public void SkipNotify(){} // RVA: 0x6910530
        public void GetSaveOptionsFromAnnotations(){} // RVA: 0x69105A0
    }

    public class XObjectChangeAnnotation
    {
    }

    public class XObjectChangeEventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x69107C0
        public void .cctor(){} // RVA: 0x6910820
    }

    public class XProcessingInstruction
    {
        public string target; // 0x28
        public string data; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6910DE0 | overloaded x2
        public void get_Data(){} // RVA: 0x6374D0
        public void set_Data(){} // RVA: 0x6910F10
        public void get_NodeType(){} // RVA: 0xA67BB0
        public void get_Target(){} // RVA: 0x30B130
        public void WriteTo(){} // RVA: 0x6911070
        public void CloneNode(){} // RVA: 0x6911100
        public void ValidateName(){} // RVA: 0x6911240
    }

    public class XStreamingElement
    {
    }

    public class XText
    {
        public string text; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6903DA0 | overloaded x2
        public void get_NodeType(){} // RVA: 0xA308B0
        public void get_Value(){} // RVA: 0x30B130
        public void set_Value(){} // RVA: 0x69113B0
        public void WriteTo(){} // RVA: 0x6911510
        public void AppendText(){} // RVA: 0x6911600
        public void CloneNode(){} // RVA: 0x6911630
    }

}