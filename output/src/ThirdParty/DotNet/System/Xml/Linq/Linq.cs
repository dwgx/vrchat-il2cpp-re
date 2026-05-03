// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml.Linq
// Classes: 25
// Methods: 218

namespace ThirdParty.DotNet.System.Xml.Linq
{
    public class BaseUriAnnotation : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
    }

    public class ElementWriter : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8744C460
        public void WriteElement(){} // RVA: 0x7FFE8744C4C0
        public void GetPrefixOfNamespace(){} // RVA: 0x7FFE8744C6F0
        public void PushAncestors(){} // RVA: 0x7FFE8744C800
        public void PushElement(){} // RVA: 0x7FFE8744C9B0
        public void WriteEndElement(){} // RVA: 0x7FFE8744CB00
        public void WriteFullEndElement(){} // RVA: 0x7FFE8744CB40
        public void WriteStartElement(){} // RVA: 0x7FFE8744CB80
    }

    public class Extensions : Object
    {
        // ── Methods ──
        public void Descendants(){} // RVA: 0x7FFE80E2E440
        public void GetDescendants(){} // RVA: 0x7FFE80E3FCF0
    }

    public class LineInfoAnnotation : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE85072A80
    }

    public class LineInfoEndElementAnnotation : LineInfoAnnotation
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE85072A80
    }

    public class NamespaceCache : ValueType
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x7FFE8744C320
    }

    public class NamespaceResolver : ValueType
    {
        // ── Methods ──
        public void PushScope(){} // RVA: 0x7FFE81ED4250
        public void PopScope(){} // RVA: 0x7FFE8744CDA0
        public void Add(){} // RVA: 0x7FFE8744CF10
        public void AddFirst(){} // RVA: 0x7FFE8744D190
        public void GetPrefixOfNamespace(){} // RVA: 0x7FFE8744D460
    }

    public class XAttribute : XObject
    {
        public System.Xml.Linq.XAttribute next; // 0x20
        public System.Xml.Linq.XName name; // 0x28
        public string value; // 0x30
        public object field_3; // 0x3

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87442140 | overloaded x2
        public void get_IsNamespaceDeclaration(){} // RVA: 0x7FFE87442270
        public void get_Name(){} // RVA: 0x7FFE81129130
        public void get_NodeType(){} // RVA: 0x7FFE81200CB0
        public void get_Value(){} // RVA: 0x7FFE8144E200
        public void set_Value(){} // RVA: 0x7FFE87442340
        public void ToString(){} // RVA: 0x7FFE874424B0
        public void GetPrefixOfNamespace(){} // RVA: 0x7FFE87442940
        public void ValidateAttribute(){} // RVA: 0x7FFE87442AA0
    }

    public class XCData : XText
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87443070 | overloaded x2
        public void get_NodeType(){} // RVA: 0x7FFE8180E590
        public void WriteTo(){} // RVA: 0x7FFE87443130
        public void CloneNode(){} // RVA: 0x7FFE874431B0
    }

    public class XComment : XNode
    {
        public string value; // 0x28
        public object field_1; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87443350 | overloaded x2
        public void get_NodeType(){} // RVA: 0x7FFE82199910
        public void get_Value(){} // RVA: 0x7FFE81129130
        public void set_Value(){} // RVA: 0x7FFE87443410
        public void WriteTo(){} // RVA: 0x7FFE87443570
        public void CloneNode(){} // RVA: 0x7FFE874435F0
    }

    public class XContainer : XNode
    {
        public object content; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE874436E0 | overloaded x2
        public void get_LastNode(){} // RVA: 0x7FFE87443890
        public void Add(){} // RVA: 0x7FFE87443A10
        public void Descendants(){} // RVA: 0x7FFE87443DA0
        public void Nodes(){} // RVA: 0x7FFE87443F00
        public void RemoveNodes(){} // RVA: 0x7FFE87443FB0
        public void AddAttribute(){} // RVA: 0x7FFE810FB310
        public void AddAttributeSkipNotify(){} // RVA: 0x7FFE810FB310
        public void AddContentSkipNotify(){} // RVA: 0x7FFE87444340
        public void AddNode(){} // RVA: 0x7FFE874446A0
        public void AddNodeSkipNotify(){} // RVA: 0x7FFE87444740
        public void AddString(){} // RVA: 0x7FFE874447E0
        public void AddStringSkipNotify(){} // RVA: 0x7FFE87444B60
        public void AppendNode(){} // RVA: 0x7FFE87444DB0
        public void AppendNodeSkipNotify(){} // RVA: 0x7FFE87444EE0
        public void AppendText(){} // RVA: 0x7FFE87445150
        public void ConvertTextToNode(){} // RVA: 0x7FFE87445250
        public void GetDescendants(){} // RVA: 0x7FFE87445430
        public void GetStringValue(){} // RVA: 0x7FFE87445560
        public void ReadContentFrom(){} // RVA: 0x7FFE87445C80 | overloaded x2
        public void RemoveNode(){} // RVA: 0x7FFE87445F00
        public void RemoveNodesSkipNotify(){} // RVA: 0x7FFE87446260
        public void ValidateNode(){} // RVA: 0x7FFE810FB310
        public void ValidateString(){} // RVA: 0x7FFE810FB310
        public void WriteContentTo(){} // RVA: 0x7FFE87446410
    }

    public class XDeclaration : Object
    {
        public string _version; // 0x10
        public string _encoding; // 0x18
        public string _standalone; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87448600 | overloaded x3
        public void get_Encoding(){} // RVA: 0x7FFE810FE7C0
        public void set_Encoding(){} // RVA: 0x7FFE81161E80
        public void get_Standalone(){} // RVA: 0x7FFE811290C0
        public void set_Standalone(){} // RVA: 0x7FFE811290D0
        public void get_Version(){} // RVA: 0x7FFE81116380
        public void ToString(){} // RVA: 0x7FFE874487F0
    }

    public class XDocument : XContainer
    {
        public System.Xml.Linq.XDeclaration _declaration; // 0x30
        public object field_1; // 0x12
        public object field_2; // 0x13

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE874489F0 | overloaded x4
        public void get_Declaration(){} // RVA: 0x7FFE8144E200
        public void set_Declaration(){} // RVA: 0x7FFE81129890
        public void get_NodeType(){} // RVA: 0x7FFE8249F650
        public void get_Root(){} // RVA: 0x7FFE87448BC0
        public void Load(){} // RVA: 0x7FFE87448D20
        public void InitLoad(){} // RVA: 0x7FFE87448EC0
        public void Parse(){} // RVA: 0x7FFE874490B0 | overloaded x2
        public void WriteTo(){} // RVA: 0x7FFE874494D0
        public void AddAttribute(){} // RVA: 0x7FFE87449680
        public void AddAttributeSkipNotify(){} // RVA: 0x7FFE874496D0
        public void CloneNode(){} // RVA: 0x7FFE87449720
        public void GetFirstNode(){} // RVA: 0x7FFE810A1420
        public void IsWhitespace(){} // RVA: 0x7FFE87449780
        public void ValidateNode(){} // RVA: 0x7FFE874497F0
        public void ValidateDocument(){} // RVA: 0x7FFE87449A20
        public void ValidateString(){} // RVA: 0x7FFE87449B70
    }

    public class XDocumentType : XNode
    {
        public string _name; // 0x28
        public string _publicId; // 0x30
        public string _systemId; // 0x38
        public string _internalSubset; // 0x40
        public object field_4; // 0x15

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87449DF0 | overloaded x2
        public void get_InternalSubset(){} // RVA: 0x7FFE81178740
        public void get_Name(){} // RVA: 0x7FFE81129130
        public void get_NodeType(){} // RVA: 0x7FFE813B49D0
        public void get_PublicId(){} // RVA: 0x7FFE8144E200
        public void get_SystemId(){} // RVA: 0x7FFE8143BA80
        public void WriteTo(){} // RVA: 0x7FFE87449FD0
        public void CloneNode(){} // RVA: 0x7FFE8744A070
    }

    public class XElement : XContainer
    {
        public System.Xml.Linq.XName name; // 0x30
        public System.Xml.Linq.XAttribute lastAttr; // 0x38
        public object field_2; // 0x1A
        public object field_3; // 0x1B
        public object field_4; // 0x1C
        public object field_5; // 0x1D

        // ── Methods ──
        public void get_EmptySequence(){} // RVA: 0x7FFE8744A0D0
        public void .ctor(){} // RVA: 0x7FFE8744A3A0 | overloaded x5
        public void get_HasAttributes(){} // RVA: 0x7FFE82AB3770
        public void get_IsEmpty(){} // RVA: 0x7FFE848F2020
        public void get_Name(){} // RVA: 0x7FFE8144E200
        public void get_NodeType(){} // RVA: 0x7FFE811EDAF0
        public void get_Value(){} // RVA: 0x7FFE8744A470
        public void set_Value(){} // RVA: 0x7FFE8744A520
        public void Attribute(){} // RVA: 0x7FFE8744A5A0
        public void Attributes(){} // RVA: 0x7FFE8744A5E0
        public void GetPrefixOfNamespace(){} // RVA: 0x7FFE8744A6F0
        public void WriteTo(){} // RVA: 0x7FFE8744AAB0
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x7FFE813240E0
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x7FFE8744ABB0
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x7FFE84D052B0
        public void AddAttribute(){} // RVA: 0x7FFE8744ADD0
        public void AddAttributeSkipNotify(){} // RVA: 0x7FFE8744AFC0
        public void AppendAttribute(){} // RVA: 0x7FFE8744B0C0
        public void AppendAttributeSkipNotify(){} // RVA: 0x7FFE8744B1F0
        public void CloneNode(){} // RVA: 0x7FFE8744B3D0
        public void GetAttributes(){} // RVA: 0x7FFE8744B510
        public void GetNamespaceOfPrefixInScope(){} // RVA: 0x7FFE8744B620
        public void ReadElementFrom(){} // RVA: 0x7FFE8744B760
        public void ReadElementFromImpl(){} // RVA: 0x7FFE8744B800
        public void SetEndElementLineInfo(){} // RVA: 0x7FFE8744BDD0
        public void ValidateNode(){} // RVA: 0x7FFE8744BE40
    }

    public class XHashtable`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E4D070
        public void TryGetValue(){}
        public void Add(){} // RVA: 0x7FFE810A1420
    }

    public class XName : Object
    {
        public System.Xml.Linq.XNamespace _ns; // 0x10
        public string _localName; // 0x18
        public int _hashCode; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8744DAE0 | overloaded x2
        public void get_LocalName(){} // RVA: 0x7FFE810FE7C0
        public void get_Namespace(){} // RVA: 0x7FFE81116380
        public void get_NamespaceName(){} // RVA: 0x7FFE8189BB90
        public void ToString(){} // RVA: 0x7FFE8744D740
        public void Get(){} // RVA: 0x7FFE8744D9A0 | overloaded x2
        public void op_Implicit(){} // RVA: 0x7FFE8744DA90
        public void Equals(){} // RVA: 0x7FFE835C1CA0
        public void GetHashCode(){} // RVA: 0x7FFE8151D690
        public void op_Equality(){} // RVA: 0x7FFE835C1CA0
        public void op_Inequality(){} // RVA: 0x7FFE869FA340
        public void System.IEquatable<System.Xml.Linq.XName>.Equals(){} // RVA: 0x7FFE835C1CA0
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFE8744DAA0
    }

    public class XNamespace : Object
    {
        public System.Xml.Linq.XHashtable`1<System.WeakReference> s_namespaces;
        public System.WeakReference s_refNone; // 0x8
        public System.WeakReference s_refXml; // 0x10
        public System.WeakReference s_refXmlns; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8744DB10
        public void get_NamespaceName(){} // RVA: 0x7FFE81116380
        public void GetName(){} // RVA: 0x7FFE8744DFC0 | overloaded x2
        public void ToString(){} // RVA: 0x7FFE81116380
        public void get_None(){} // RVA: 0x7FFE8744DD40
        public void get_Xml(){} // RVA: 0x7FFE8744DDB0
        public void get_Xmlns(){} // RVA: 0x7FFE8744DE10
        public void Get(){} // RVA: 0x7FFE8744E210 | overloaded x2
        public void op_Implicit(){} // RVA: 0x7FFE8744DEE0
        public void op_Addition(){} // RVA: 0x7FFE8744DF00
        public void Equals(){} // RVA: 0x7FFE835C1CA0
        public void GetHashCode(){} // RVA: 0x7FFE813DB630
        public void op_Equality(){} // RVA: 0x7FFE835C1CA0
        public void op_Inequality(){} // RVA: 0x7FFE869FA340
        public void ExtractLocalName(){} // RVA: 0x7FFE81D7E800
        public void ExtractNamespace(){} // RVA: 0x7FFE8744E670
        public void EnsureNamespace(){} // RVA: 0x7FFE8744E6F0
    }

    public class XNode : XObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Remove(){} // RVA: 0x7FFE8744E860
        public void ToString(){} // RVA: 0x7FFE8744E8D0
        public void WriteTo(){} // RVA: 0x7FFE80E460A0
        public void AppendText(){} // RVA: 0x7FFE810FB310
        public void CloneNode(){} // RVA: 0x7FFE80E2E2E0
        public void GetXmlReaderSettings(){} // RVA: 0x7FFE8744E900
        public void GetXmlString(){} // RVA: 0x7FFE8744EA20
    }

    public class XObject : Object
    {
        public System.Xml.Linq.XContainer parent; // 0x10
        public object annotations; // 0x18
        public object field_2; // 0x29
        public object field_3; // 0x2A
        public object field_4; // 0x2B
        public object field_5; // 0x2C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_BaseUri(){} // RVA: 0x7FFE8744EEA0
        public void get_NodeType(){} // RVA: 0x7FFE80E2EDB0
        public void get_Parent(){} // RVA: 0x7FFE8744EF30
        public void AddAnnotation(){} // RVA: 0x7FFE8744EFC0
        public void AnnotationForSealedType(){} // RVA: 0x7FFE8744F300
        public void Annotation(){} // RVA: 0x7FFE810A1420
        public void System.Xml.IXmlLineInfo.HasLineInfo(){} // RVA: 0x7FFE8744F440
        public void System.Xml.IXmlLineInfo.get_LineNumber(){} // RVA: 0x7FFE8744F490
        public void System.Xml.IXmlLineInfo.get_LinePosition(){} // RVA: 0x7FFE8744F4E0
        public void get_HasBaseUri(){} // RVA: 0x7FFE8744F530
        public void NotifyChanged(){} // RVA: 0x7FFE8744F580
        public void NotifyChanging(){} // RVA: 0x7FFE8744F630
        public void SetBaseUri(){} // RVA: 0x7FFE8744F6E0
        public void SetLineInfo(){} // RVA: 0x7FFE8744F790
        public void SkipNotify(){} // RVA: 0x7FFE8744F800
        public void GetSaveOptionsFromAnnotations(){} // RVA: 0x7FFE8744F870
    }

    public class XObjectChangeAnnotation : Object
    {
    }

    public class XObjectChangeEventArgs : EventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8744FA90
        public void .cctor(){} // RVA: 0x7FFE8744FAF0
    }

    public class XProcessingInstruction : XNode
    {
        public string target; // 0x28
        public string data; // 0x30
        public object field_2; // 0x2F

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE874500B0 | overloaded x2
        public void get_Data(){} // RVA: 0x7FFE8144E200
        public void set_Data(){} // RVA: 0x7FFE874501E0
        public void get_NodeType(){} // RVA: 0x7FFE817F39D0
        public void get_Target(){} // RVA: 0x7FFE81129130
        public void WriteTo(){} // RVA: 0x7FFE87450340
        public void CloneNode(){} // RVA: 0x7FFE874503D0
        public void ValidateName(){} // RVA: 0x7FFE87450510
    }

    public class XStreamingElement : Object
    {
    }

    public class XText : XNode
    {
        public string text; // 0x28
        public object field_1; // 0x32

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87443070 | overloaded x2
        public void get_NodeType(){} // RVA: 0x7FFE817BF630
        public void get_Value(){} // RVA: 0x7FFE81129130
        public void set_Value(){} // RVA: 0x7FFE87450680
        public void WriteTo(){} // RVA: 0x7FFE874507E0
        public void AppendText(){} // RVA: 0x7FFE874508D0
        public void CloneNode(){} // RVA: 0x7FFE87450900
    }

}