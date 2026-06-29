// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml.Linq
// Classes: 23
// Methods: 196

namespace ThirdParty.DotNet.System.Xml.Linq
{
    public class BaseUriAnnotation : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
    }

    public class ElementWriter : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E93C70
        public void WriteElement(){} // RVA: 0x7A7E93C80
        public void GetPrefixOfNamespace(){} // RVA: 0x7A7E93C90
        public void PushAncestors(){} // RVA: 0x7A7E93CA0
        public void PushElement(){} // RVA: 0x7A7E93CB0
        public void WriteEndElement(){} // RVA: 0x7A7E93CC0
        public void WriteFullEndElement(){} // RVA: 0x7A7E93D00
        public void WriteStartElement(){} // RVA: 0x7A7E93D40
    }

    public class Extensions : Object
    {
        // ── Methods ──
        public void Descendants(){} // RVA: 0x7A7E00C10
        public void GetDescendants(){} // RVA: 0x7A7E124D0
    }

    public class LineInfoAnnotation : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AC226C00
    }

    public class LineInfoEndElementAnnotation : LineInfoAnnotation
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AC226C00
    }

    public class NamespaceCache : ValueType
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x7A7E93C40
    }

    public class NamespaceResolver : ValueType
    {
        // ── Methods ──
        public void PushScope(){} // RVA: 0x7A763E220
        public void PopScope(){} // RVA: 0x7A7E93D70
        public void Add(){} // RVA: 0x7A7E93D80
        public void AddFirst(){} // RVA: 0x7A7E93D90
        public void GetPrefixOfNamespace(){} // RVA: 0x7A7E93DA0
    }

    public class XAttribute : XObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE6F1930
        public void get_IsNamespaceDeclaration(){} // RVA: 0x7AE6F1A60
        public void get_Name(){} // RVA: 0x7A8105330
        public void get_NodeType(){} // RVA: 0x7A81DDCC0
        public void get_Value(){} // RVA: 0x7A83F69F0
        public void set_Value(){} // RVA: 0x7AE6F1B30
        public void ToString(){} // RVA: 0x7AE6F1CA0
        public void GetPrefixOfNamespace(){} // RVA: 0x7AE6F2140
        public void ValidateAttribute(){} // RVA: 0x7AE6F22A0
    }

    public class XCData : XText
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE6F2870
        public void get_NodeType(){} // RVA: 0x7A883BE70
        public void WriteTo(){} // RVA: 0x7AE6F2930
        public void CloneNode(){} // RVA: 0x7AE6F29B0
    }

    public class XComment : XNode
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE6F2B50
        public void get_NodeType(){} // RVA: 0x7A88217C0
        public void get_Value(){} // RVA: 0x7A8105330
        public void set_Value(){} // RVA: 0x7AE6F2C10
        public void WriteTo(){} // RVA: 0x7AE6F2D70
        public void CloneNode(){} // RVA: 0x7AE6F2DF0
    }

    public class XContainer : XNode
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE6F2EE0
        public void get_LastNode(){} // RVA: 0x7AE6F3090
        public void Add(){} // RVA: 0x7AE6F3240
        public void Descendants(){} // RVA: 0x7AE6F35A0
        public void Nodes(){} // RVA: 0x7AE6F3700
        public void RemoveNodes(){} // RVA: 0x7AE6F37B0
        public void AddAttribute(){} // RVA: 0x7A80D7310
        public void AddAttributeSkipNotify(){} // RVA: 0x7A80D7310
        public void AddContentSkipNotify(){} // RVA: 0x7AE6F3D30
        public void AddNode(){} // RVA: 0x7AE6F4080
        public void AddNodeSkipNotify(){} // RVA: 0x7AE6F4120
        public void AddString(){} // RVA: 0x7AE6F41C0
        public void AddStringSkipNotify(){} // RVA: 0x7AE6F4530
        public void AppendNode(){} // RVA: 0x7AE6F4780
        public void AppendNodeSkipNotify(){} // RVA: 0x7AE6F48B0
        public void AppendText(){} // RVA: 0x7AE6F4B20
        public void ConvertTextToNode(){} // RVA: 0x7AE6F4C20
        public void GetDescendants(){} // RVA: 0x7AE6F4E00
        public void GetStringValue(){} // RVA: 0x7AE6F4F30
        public void ReadContentFrom(){} // RVA: 0x7AE6F5650
        public void RemoveNode(){} // RVA: 0x7AE6F5A00
        public void RemoveNodesSkipNotify(){} // RVA: 0x7AE6F5D60
        public void ValidateNode(){} // RVA: 0x7A80D7310
        public void ValidateString(){} // RVA: 0x7A80D7310
        public void WriteContentTo(){} // RVA: 0x7AE6F5F10
    }

    public class XDeclaration : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE6F84C0
        public void get_Encoding(){} // RVA: 0x7A80DA7B0
        public void set_Encoding(){} // RVA: 0x7A813E420
        public void get_Standalone(){} // RVA: 0x7A81052C0
        public void set_Standalone(){} // RVA: 0x7A81052D0
        public void get_Version(){} // RVA: 0x7A80F2570
        public void ToString(){} // RVA: 0x7AE6F86B0
    }

    public class XDocument : XContainer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE6F88B0
        public void get_Declaration(){} // RVA: 0x7A83F69F0
        public void set_Declaration(){} // RVA: 0x7A8105A90
        public void get_NodeType(){} // RVA: 0x7A94EBBC0
        public void get_Root(){} // RVA: 0x7AE6F8A80
        public void Load(){} // RVA: 0x7AE6F8BE0
        public void InitLoad(){} // RVA: 0x7AE6F8D80
        public void Parse(){} // RVA: 0x7AE6F8F70
        public void WriteTo(){} // RVA: 0x7AE6F93A0
        public void AddAttribute(){} // RVA: 0x7AE6F9550
        public void AddAttributeSkipNotify(){} // RVA: 0x7AE6F95A0
        public void CloneNode(){} // RVA: 0x7AE6F95F0
        public void GetFirstNode(){} // RVA: 0x7A8051B10
        public void IsWhitespace(){} // RVA: 0x7AE6F9650
        public void ValidateNode(){} // RVA: 0x7AE6F96C0
        public void ValidateDocument(){} // RVA: 0x7AE6F98F0
        public void ValidateString(){} // RVA: 0x7AE6F9A40
    }

    public class XDocumentType : XNode
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE6F9CC0
        public void get_InternalSubset(){} // RVA: 0x7A8154D80
        public void get_Name(){} // RVA: 0x7A8105330
        public void get_NodeType(){} // RVA: 0x7A836B0A0
        public void get_PublicId(){} // RVA: 0x7A83F69F0
        public void get_SystemId(){} // RVA: 0x7A8292C30
        public void WriteTo(){} // RVA: 0x7AE6F9EA0
        public void CloneNode(){} // RVA: 0x7AE6F9F40
    }

    public class XElement : XContainer
    {
        // ── Methods ──
        public void get_EmptySequence(){} // RVA: 0x7AE6FA120
        public void .ctor(){} // RVA: 0x7AE6FA3F0
        public void get_HasAttributes(){} // RVA: 0x7A9B27F60
        public void get_IsEmpty(){} // RVA: 0x7ABA6DD90
        public void get_Name(){} // RVA: 0x7A83F69F0
        public void get_NodeType(){} // RVA: 0x7A81CA9D0
        public void get_Value(){} // RVA: 0x7AE6FA4C0
        public void set_Value(){} // RVA: 0x7AE6FA570
        public void Attribute(){} // RVA: 0x7AE6FA5F0
        public void Attributes(){} // RVA: 0x7AE6FA630
        public void GetPrefixOfNamespace(){} // RVA: 0x7AE6FA740
        public void WriteTo(){} // RVA: 0x7AE6FAB10
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x7A82D1450
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x7AE6FAC20
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x7ABE84300
        public void AddAttribute(){} // RVA: 0x7AE6FAE40
        public void AddAttributeSkipNotify(){} // RVA: 0x7AE6FB040
        public void AppendAttribute(){} // RVA: 0x7AE6FB140
        public void AppendAttributeSkipNotify(){} // RVA: 0x7AE6FB270
        public void CloneNode(){} // RVA: 0x7AE6FB450
        public void GetAttributes(){} // RVA: 0x7AE6FB590
        public void GetNamespaceOfPrefixInScope(){} // RVA: 0x7AE6FB6A0
        public void ReadElementFrom(){} // RVA: 0x7AE6FB7E0
        public void ReadElementFromImpl(){} // RVA: 0x7AE6FB880
        public void SetEndElementLineInfo(){} // RVA: 0x7AE6FBE50
        public void ValidateNode(){} // RVA: 0x7AE6FBEC0
    }

    public class XHashtable`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E1D590
        public void TryGetValue(){} // RVA: 0x7A7E04800
        public void Add(){} // RVA: 0x7A8051B10
    }

    public class XName : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE6FDB60
        public void get_LocalName(){} // RVA: 0x7A80DA7B0
        public void get_Namespace(){} // RVA: 0x7A80F2570
        public void get_NamespaceName(){} // RVA: 0x7A88F4180
        public void ToString(){} // RVA: 0x7AE6FD7C0
        public void Get(){} // RVA: 0x7AE6FDA20
        public void op_Implicit(){} // RVA: 0x7AE6FDB10
        public void Equals(){} // RVA: 0x7AA68A530
        public void GetHashCode(){} // RVA: 0x7A851DB90
        public void op_Equality(){} // RVA: 0x7AA68A530
        public void op_Inequality(){} // RVA: 0x7ADCA8000
        public void System.IEquatable<System.Xml.Linq.XName>.Equals(){} // RVA: 0x7AA68A530
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7AE6FDB20
    }

    public class XNamespace : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE6FDB90
        public void get_NamespaceName(){} // RVA: 0x7A80F2570
        public void GetName(){} // RVA: 0x7AE6FE040
        public void ToString(){} // RVA: 0x7A80F2570
        public void get_None(){} // RVA: 0x7AE6FDDC0
        public void get_Xml(){} // RVA: 0x7AE6FDE30
        public void get_Xmlns(){} // RVA: 0x7AE6FDE90
        public void Get(){} // RVA: 0x7AE6FE280
        public void op_Implicit(){} // RVA: 0x7AE6FDF60
        public void op_Addition(){} // RVA: 0x7AE6FDF80
        public void Equals(){} // RVA: 0x7AA68A530
        public void GetHashCode(){} // RVA: 0x7A83782A0
        public void op_Equality(){} // RVA: 0x7AA68A530
        public void op_Inequality(){} // RVA: 0x7ADCA8000
        public void ExtractLocalName(){} // RVA: 0x7A8DC0790
        public void ExtractNamespace(){} // RVA: 0x7AE6FE6C0
        public void EnsureNamespace(){} // RVA: 0x7AE6FE740
    }

    public class XNode : XObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void Remove(){} // RVA: 0x7AE6FE8B0
        public void ToString(){} // RVA: 0x7AE6FE920
        public void WriteTo(){} // RVA: 0x7A7E18800
        public void AppendText(){} // RVA: 0x7A80D7310
        public void CloneNode(){} // RVA: 0x7A7E00680
        public void GetXmlReaderSettings(){} // RVA: 0x7AE6FE950
        public void GetXmlString(){} // RVA: 0x7AE6FEA70
    }

    public class XObject : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void get_BaseUri(){} // RVA: 0x7AE6FEEF0
        public void get_NodeType(){} // RVA: 0x7A7E00710
        public void get_Parent(){} // RVA: 0x7AE6FEF80
        public void AddAnnotation(){} // RVA: 0x7AE6FF000
        public void AnnotationForSealedType(){} // RVA: 0x7AE6FF340
        public void Annotation(){} // RVA: 0x7A8051B10
        public void System.Xml.IXmlLineInfo.HasLineInfo(){} // RVA: 0x7AE6FF470
        public void System.Xml.IXmlLineInfo.get_LineNumber(){} // RVA: 0x7AE6FF4C0
        public void System.Xml.IXmlLineInfo.get_LinePosition(){} // RVA: 0x7AE6FF510
        public void get_HasBaseUri(){} // RVA: 0x7AE6FF560
        public void NotifyChanged(){} // RVA: 0x7AE6FF5B0
        public void NotifyChanging(){} // RVA: 0x7AE6FF660
        public void SetBaseUri(){} // RVA: 0x7AE6FF710
        public void SetLineInfo(){} // RVA: 0x7AE6FF7C0
        public void SkipNotify(){} // RVA: 0x7AE6FF830
        public void GetSaveOptionsFromAnnotations(){} // RVA: 0x7AE6FF8A0
    }

    public class XObjectChangeEventArgs : EventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE6FFAD0
        public void .cctor(){} // RVA: 0x7AE6FFB30
    }

    public class XProcessingInstruction : XNode
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE7000F0
        public void get_Data(){} // RVA: 0x7A83F69F0
        public void set_Data(){} // RVA: 0x7AE700220
        public void get_NodeType(){} // RVA: 0x7A88258F0
        public void get_Target(){} // RVA: 0x7A8105330
        public void WriteTo(){} // RVA: 0x7AE700380
        public void CloneNode(){} // RVA: 0x7AE700410
        public void ValidateName(){} // RVA: 0x7AE700550
    }

    public class XText : XNode
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE6F2870
        public void get_NodeType(){} // RVA: 0x7A87EE0F0
        public void get_Value(){} // RVA: 0x7A8105330
        public void set_Value(){} // RVA: 0x7AE7006C0
        public void WriteTo(){} // RVA: 0x7AE700820
        public void AppendText(){} // RVA: 0x7AE700910
        public void CloneNode(){} // RVA: 0x7AE700940
    }

}