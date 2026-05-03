// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Newtonsoft.Newtonsoft.Json.Converters
// Classes: 37
// Methods: 307

namespace ThirdParty.Newtonsoft.Newtonsoft.Json.Converters
{
    public class BinaryConverter : JsonConverter
    {
        // ── Methods ──
        public void WriteJson(){} // RVA: 0x7FFE86BA0D90
        public void GetByteArray(){} // RVA: 0x7FFE86BA0E00
        public void EnsureReflectionObject(){} // RVA: 0x7FFE86BA1060
        public void ReadJson(){} // RVA: 0x7FFE86BA1270
        public void ReadByteArray(){} // RVA: 0x7FFE86BA17C0
        public void CanConvert(){} // RVA: 0x7FFE86BA1A40
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class BsonObjectIdConverter : JsonConverter
    {
        // ── Methods ──
        public void WriteJson(){} // RVA: 0x7FFE86BA1B80
        public void ReadJson(){} // RVA: 0x7FFE86BA1DB0
        public void CanConvert(){} // RVA: 0x7FFE86BA2070
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class CustomCreationConverter`1 : JsonConverter
    {
        // ── Methods ──
        public void WriteJson(){} // RVA: 0x7FFE80E50660
        public void ReadJson(){} // RVA: 0x7FFE80E40660
        public void Create(){} // RVA: 0x7FFE810A1420
        public void CanConvert(){} // RVA: 0x7FFE80E2F3B0
        public void get_CanWrite(){} // RVA: 0x7FFE80E2F150
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class DataSetConverter : JsonConverter
    {
        // ── Methods ──
        public void WriteJson(){} // RVA: 0x7FFE86BA2140
        public void ReadJson(){} // RVA: 0x7FFE86BA2560
        public void CanConvert(){} // RVA: 0x7FFE86BA28F0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class DataTableConverter : JsonConverter
    {
        // ── Methods ──
        public void WriteJson(){} // RVA: 0x7FFE86BA29D0
        public void ReadJson(){} // RVA: 0x7FFE86BA2F60
        public void CreateRow(){} // RVA: 0x7FFE86BA32F0
        public void GetColumnDataType(){} // RVA: 0x7FFE86BA38D0
        public void CanConvert(){} // RVA: 0x7FFE86BA3AF0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class DateTimeConverterBase : JsonConverter
    {
        // ── Methods ──
        public void CanConvert(){} // RVA: 0x7FFE86BA3BD0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class DiscriminatedUnionConverter : JsonConverter
    {
        // ── Methods ──
        public void CreateUnionTypeLookup(){} // RVA: 0x7FFE86BA3D60
        public void CreateUnion(){} // RVA: 0x7FFE86BA3FC0
        public void WriteJson(){} // RVA: 0x7FFE86BA4AF0
        public void ReadJson(){} // RVA: 0x7FFE86BA50F0
        public void CanConvert(){} // RVA: 0x7FFE86BA5B60
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE86BA5E70
    }

    public class EntityKeyMemberConverter : JsonConverter
    {
        // ── Methods ──
        public void WriteJson(){} // RVA: 0x7FFE86BA6270
        public void ReadAndAssertProperty(){} // RVA: 0x7FFE86BA6630
        public void ReadJson(){} // RVA: 0x7FFE86BA6820
        public void EnsureReflectionObject(){} // RVA: 0x7FFE86BA6C00
        public void CanConvert(){} // RVA: 0x7FFE86BA6D50
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ExpandoObjectConverter : JsonConverter
    {
        // ── Methods ──
        public void WriteJson(){} // RVA: 0x7FFE810FB310
        public void ReadJson(){} // RVA: 0x7FFE86BA6DB0
        public void ReadValue(){} // RVA: 0x7FFE86BA6DC0
        public void ReadList(){} // RVA: 0x7FFE86BA70A0
        public void ReadObject(){} // RVA: 0x7FFE86BA71E0
        public void CanConvert(){} // RVA: 0x7FFE86BA74B0
        public void get_CanWrite(){} // RVA: 0x7FFE810FB320
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class IXmlDeclaration
    {
        // ── Methods ──
        public void get_Version(){} // RVA: 0x7FFE80E2E2E0
        public void get_Encoding(){} // RVA: 0x7FFE80E2E2E0
        public void set_Encoding(){} // RVA: 0x7FFE80E460A0
        public void get_Standalone(){} // RVA: 0x7FFE80E2E2E0
        public void set_Standalone(){} // RVA: 0x7FFE80E460A0
    }

    public class IXmlDocument
    {
        // ── Methods ──
        public void CreateComment(){} // RVA: 0x7FFE80E2E390
        public void CreateTextNode(){} // RVA: 0x7FFE80E2E390
        public void CreateCDataSection(){} // RVA: 0x7FFE80E2E390
        public void CreateWhitespace(){} // RVA: 0x7FFE80E2E390
        public void CreateSignificantWhitespace(){} // RVA: 0x7FFE80E2E390
        public void CreateXmlDeclaration(){} // RVA: 0x7FFE80E403A0
        public void CreateXmlDocumentType(){} // RVA: 0x7FFE80E40660
        public void CreateProcessingInstruction(){} // RVA: 0x7FFE80E3FC10
        public void CreateElement(){} // RVA: 0x7FFE80E3FC10 | overloaded x2
        public void CreateAttribute(){} // RVA: 0x7FFE80E403A0 | overloaded x2
        public void get_DocumentElement(){} // RVA: 0x7FFE80E2E2E0
    }

    public class IXmlDocumentType
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFE80E2E2E0
        public void get_System(){} // RVA: 0x7FFE80E2E2E0
        public void get_Public(){} // RVA: 0x7FFE80E2E2E0
        public void get_InternalSubset(){} // RVA: 0x7FFE80E2E2E0
    }

    public class IXmlElement
    {
        // ── Methods ──
        public void SetAttributeNode(){} // RVA: 0x7FFE80E460A0
        public void GetPrefixOfNamespace(){} // RVA: 0x7FFE80E2E390
        public void get_IsEmpty(){} // RVA: 0x7FFE80E2F150
    }

    public class IXmlNode
    {
        // ── Methods ──
        public void get_NodeType(){} // RVA: 0x7FFE80E2EDB0
        public void get_LocalName(){} // RVA: 0x7FFE80E2E2E0
        public void get_ChildNodes(){} // RVA: 0x7FFE80E2E2E0
        public void get_Attributes(){} // RVA: 0x7FFE80E2E2E0
        public void get_ParentNode(){} // RVA: 0x7FFE80E2E2E0
        public void get_Value(){} // RVA: 0x7FFE80E2E2E0
        public void set_Value(){} // RVA: 0x7FFE80E460A0
        public void AppendChild(){} // RVA: 0x7FFE80E2E390
        public void get_NamespaceUri(){} // RVA: 0x7FFE80E2E2E0
        public void get_WrappedNode(){} // RVA: 0x7FFE80E2E2E0
    }

    public class IsoDateTimeConverter : DateTimeConverterBase
    {
        public string DefaultDateTimeFormat;
        public 0x664D42FC _dateTimeStyles; // 0x10
        public string _dateTimeFormat; // 0x18

        // ── Methods ──
        public void get_DateTimeStyles(){} // RVA: 0x7FFE811485C0
        public void set_DateTimeStyles(){} // RVA: 0x7FFE810FE0C0
        public void get_DateTimeFormat(){} // RVA: 0x7FFE86BA7580
        public void set_DateTimeFormat(){} // RVA: 0x7FFE86BA75D0
        public void get_Culture(){} // RVA: 0x7FFE86BA7650
        public void set_Culture(){} // RVA: 0x7FFE811290D0
        public void WriteJson(){} // RVA: 0x7FFE86BA76E0
        public void ReadJson(){} // RVA: 0x7FFE86BA7A20
        public void .ctor(){} // RVA: 0x7FFE86BA7FD0
    }

    public class JavaScriptDateTimeConverter : DateTimeConverterBase
    {
        // ── Methods ──
        public void WriteJson(){} // RVA: 0x7FFE86BA7FE0
        public void ReadJson(){} // RVA: 0x7FFE86BA8300
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class KeyValuePairConverter : JsonConverter
    {
        // ── Methods ──
        public void InitializeReflectionObject(){} // RVA: 0x7FFE86BA8730
        public void WriteJson(){} // RVA: 0x7FFE86BA8930
        public void ReadJson(){} // RVA: 0x7FFE86BA8C90
        public void CanConvert(){} // RVA: 0x7FFE86BA9320
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE86BA9440
    }

    public class RegexConverter : JsonConverter
    {
        // ── Methods ──
        public void WriteJson(){} // RVA: 0x7FFE86BA98F0 | overloaded x2
        public void HasFlag(){} // RVA: 0x7FFE86874540
        public void WriteBson(){} // RVA: 0x7FFE86BA96A0
        public void ReadJson(){} // RVA: 0x7FFE86BA9B10
        public void ReadRegexString(){} // RVA: 0x7FFE86BA9D10
        public void ReadRegexObject(){} // RVA: 0x7FFE86BA9E80
        public void CanConvert(){} // RVA: 0x7FFE86BAA290
        public void IsRegex(){} // RVA: 0x7FFE86BAA340
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class StringEnumConverter : JsonConverter
    {
        public Newtonsoft.Json.Serialization.NamingStrategy _namingStrategy; // 0x10
        public bool _allowIntegerValues; // 0x18
        public object field_2; // 0x251

        // ── Methods ──
        public void get_CamelCaseText(){} // RVA: 0x7FFE86BAA540
        public void set_CamelCaseText(){} // RVA: 0x7FFE86BAA5B0
        public void get_NamingStrategy(){} // RVA: 0x7FFE81116380
        public void set_NamingStrategy(){} // RVA: 0x7FFE810FCE30
        public void get_AllowIntegerValues(){} // RVA: 0x7FFE811164E0
        public void set_AllowIntegerValues(){} // RVA: 0x7FFE811164F0
        public void .ctor(){} // RVA: 0x7FFE86BAA9C0 | overloaded x6
        public void WriteJson(){} // RVA: 0x7FFE86BAAAF0
        public void ReadJson(){} // RVA: 0x7FFE86BAAD00
        public void CanConvert(){} // RVA: 0x7FFE86BAB180
    }

    public class UnixDateTimeConverter : DateTimeConverterBase
    {
        public System.DateTime UnixEpoch;

        // ── Methods ──
        public void get_AllowPreEpoch(){} // RVA: 0x7FFE811C55E0
        public void set_AllowPreEpoch(){} // RVA: 0x7FFE811C55F0
        public void .ctor(){} // RVA: 0x7FFE811C55F0 | overloaded x2
        public void WriteJson(){} // RVA: 0x7FFE86BAB210
        public void ReadJson(){} // RVA: 0x7FFE86BAB580
        public void .cctor(){} // RVA: 0x7FFE86BABB90
    }

    public class VersionConverter : JsonConverter
    {
        // ── Methods ──
        public void WriteJson(){} // RVA: 0x7FFE86BABC10
        public void ReadJson(){} // RVA: 0x7FFE86BABD10
        public void CanConvert(){} // RVA: 0x7FFE86BABF70
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class XAttributeWrapper : XObjectWrapper
    {
        // ── Methods ──
        public void get_Attribute(){} // RVA: 0x7FFE86BB0930
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void get_Value(){} // RVA: 0x7FFE86BB09B0
        public void set_Value(){} // RVA: 0x7FFE86BB09D0
        public void get_LocalName(){} // RVA: 0x7FFE86BB0B90
        public void get_NamespaceUri(){} // RVA: 0x7FFE86BB0BC0
        public void get_ParentNode(){} // RVA: 0x7FFE86BB0C00
    }

    public class XCommentWrapper : XObjectWrapper
    {
        // ── Methods ──
        public void get_Text(){} // RVA: 0x7FFE86BAF6F0
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void get_Value(){} // RVA: 0x7FFE86BAF770
        public void set_Value(){} // RVA: 0x7FFE86BAF790
        public void get_ParentNode(){} // RVA: 0x7FFE86BAF940
    }

    public class XContainerWrapper : XObjectWrapper
    {
        public System.Collections.Generic.List`1<Newtonsoft.Json.Converters.IXmlNode> _childNodes; // 0x18
        public object field_1; // 0x291
        public object field_2; // 0x292
        public object field_3; // 0x293

        // ── Methods ──
        public void get_Container(){} // RVA: 0x7FFE86BAFC10
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void get_ChildNodes(){} // RVA: 0x7FFE86BAFC90
        public void get_HasChildNodes(){} // RVA: 0x7FFE86BB00E0
        public void get_ParentNode(){} // RVA: 0x7FFE86BB0110
        public void WrapNode(){} // RVA: 0x7FFE86BB0170
        public void AppendChild(){} // RVA: 0x7FFE86BB06F0
    }

    public class XDeclarationWrapper : XObjectWrapper
    {
        public System.Xml.Linq.XDeclaration _declaration; // 0x18
        public object field_1; // 0x27A
        public object field_2; // 0x27B
        public object field_3; // 0x27C
        public object field_4; // 0x27D

        // ── Methods ──
        public void get_Declaration(){} // RVA: 0x7FFE810FE7C0
        public void .ctor(){} // RVA: 0x7FFE86BADEB0
        public void get_NodeType(){} // RVA: 0x7FFE86BADF70
        public void get_Version(){} // RVA: 0x7FFE81D29350
        public void get_Encoding(){} // RVA: 0x7FFE86BADF80
        public void set_Encoding(){} // RVA: 0x7FFE86BADFA0
        public void get_Standalone(){} // RVA: 0x7FFE82A2A930
        public void set_Standalone(){} // RVA: 0x7FFE86BAE010
    }

    public class XDocumentTypeWrapper : XObjectWrapper
    {
        public System.Xml.Linq.XDocumentType _documentType; // 0x18
        public object field_1; // 0x27F
        public object field_2; // 0x280
        public object field_3; // 0x281
        public object field_4; // 0x282

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86A84CF0
        public void get_Name(){} // RVA: 0x7FFE86BAE080
        public void get_System(){} // RVA: 0x7FFE86BAE0A0
        public void get_Public(){} // RVA: 0x7FFE86BAE0C0
        public void get_InternalSubset(){} // RVA: 0x7FFE86BAE0E0
        public void get_LocalName(){} // RVA: 0x7FFE86BAE100
    }

    public class XDocumentWrapper : XContainerWrapper
    {
        // ── Methods ──
        public void get_Document(){} // RVA: 0x7FFE86BAE140
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void get_ChildNodes(){} // RVA: 0x7FFE86BAE1C0
        public void get_HasChildNodes(){} // RVA: 0x7FFE86BAE310
        public void CreateComment(){} // RVA: 0x7FFE86BAE360
        public void CreateTextNode(){} // RVA: 0x7FFE86BAE4C0
        public void CreateCDataSection(){} // RVA: 0x7FFE86BAE620
        public void CreateWhitespace(){} // RVA: 0x7FFE86BAE780
        public void CreateSignificantWhitespace(){} // RVA: 0x7FFE86BAE8E0
        public void CreateXmlDeclaration(){} // RVA: 0x7FFE86BAEA40
        public void CreateXmlDocumentType(){} // RVA: 0x7FFE86BAEAF0
        public void CreateProcessingInstruction(){} // RVA: 0x7FFE86BAEBB0
        public void CreateElement(){} // RVA: 0x7FFE86BAEE20 | overloaded x2
        public void CreateAttribute(){} // RVA: 0x7FFE86BAF190 | overloaded x2
        public void get_DocumentElement(){} // RVA: 0x7FFE86BAF370
        public void AppendChild(){} // RVA: 0x7FFE86BAF450
    }

    public class XElementWrapper : XContainerWrapper
    {
        public System.Collections.Generic.List`1<Newtonsoft.Json.Converters.IXmlNode> _attributes; // 0x20
        public object field_1; // 0x2A2
        public object field_2; // 0x2A3
        public object field_3; // 0x2A4
        public object field_4; // 0x2A5
        public object field_5; // 0x2A6

        // ── Methods ──
        public void get_Element(){} // RVA: 0x7FFE86BB0C60
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void SetAttributeNode(){} // RVA: 0x7FFE86BB0CE0
        public void get_Attributes(){} // RVA: 0x7FFE86BB0DE0
        public void HasImplicitNamespaceAttribute(){} // RVA: 0x7FFE86BB1320
        public void AppendChild(){} // RVA: 0x7FFE86BB1690
        public void get_Value(){} // RVA: 0x7FFE86BB1700
        public void set_Value(){} // RVA: 0x7FFE86BB1730
        public void get_LocalName(){} // RVA: 0x7FFE86BB1800
        public void get_NamespaceUri(){} // RVA: 0x7FFE86BB1830
        public void GetPrefixOfNamespace(){} // RVA: 0x7FFE86BB1870
        public void get_IsEmpty(){} // RVA: 0x7FFE86BB18D0
    }

    public class XObjectWrapper : Object
    {
        public System.Xml.Linq.XObject _xmlObject; // 0x10
        public object field_1; // 0x295
        public object field_2; // 0x296
        public object field_3; // 0x297
        public object field_4; // 0x298
        public object field_5; // 0x299
        public object field_6; // 0x29A
        public object field_7; // 0x29B

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void get_WrappedNode(){} // RVA: 0x7FFE81116380
        public void get_NodeType(){} // RVA: 0x7FFE86BB07D0
        public void get_LocalName(){} // RVA: 0x7FFE813240E0
        public void get_ChildNodes(){} // RVA: 0x7FFE86BB07F0
        public void get_Attributes(){} // RVA: 0x7FFE86BB0850
        public void get_ParentNode(){} // RVA: 0x7FFE813240E0
        public void get_Value(){} // RVA: 0x7FFE813240E0
        public void set_Value(){} // RVA: 0x7FFE86BB08B0
        public void AppendChild(){} // RVA: 0x7FFE86BB08F0
        public void get_NamespaceUri(){} // RVA: 0x7FFE813240E0
    }

    public class XProcessingInstructionWrapper : XObjectWrapper
    {
        // ── Methods ──
        public void get_ProcessingInstruction(){} // RVA: 0x7FFE86BAF9A0
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void get_LocalName(){} // RVA: 0x7FFE86BAFA20
        public void get_Value(){} // RVA: 0x7FFE86BAFA40
        public void set_Value(){} // RVA: 0x7FFE86BAFA60
    }

    public class XTextWrapper : XObjectWrapper
    {
        // ── Methods ──
        public void get_Text(){} // RVA: 0x7FFE86BAF570
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void get_Value(){} // RVA: 0x7FFE86BAF5F0
        public void set_Value(){} // RVA: 0x7FFE86BAF610
        public void get_ParentNode(){} // RVA: 0x7FFE86BAF690
    }

    public class XmlDeclarationWrapper : XmlNodeWrapper
    {
        public System.Xml.XmlDeclaration _declaration; // 0x28
        public object field_1; // 0x257
        public object field_2; // 0x258

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86BAC040
        public void get_Version(){} // RVA: 0x7FFE84D055D0
        public void get_Encoding(){} // RVA: 0x7FFE86BACD10
        public void set_Encoding(){} // RVA: 0x7FFE86BACD30
        public void get_Standalone(){} // RVA: 0x7FFE86BACDF0
        public void set_Standalone(){} // RVA: 0x7FFE86BACE10
    }

    public class XmlDocumentTypeWrapper : XmlNodeWrapper
    {
        public System.Xml.XmlDocumentType _documentType; // 0x28
        public object field_1; // 0x25A
        public object field_2; // 0x25B
        public object field_3; // 0x25C
        public object field_4; // 0x25D

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86BAC040
        public void get_Name(){} // RVA: 0x7FFE86BACE30
        public void get_System(){} // RVA: 0x7FFE86BACDF0
        public void get_Public(){} // RVA: 0x7FFE86BACD10
        public void get_InternalSubset(){} // RVA: 0x7FFE86BACE60
        public void get_LocalName(){} // RVA: 0x7FFE86BACE80
    }

    public class XmlDocumentWrapper : XmlNodeWrapper
    {
        public System.Xml.XmlDocument _document; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86BAC040
        public void CreateComment(){} // RVA: 0x7FFE86BAC0F0
        public void CreateTextNode(){} // RVA: 0x7FFE86BAC1C0
        public void CreateCDataSection(){} // RVA: 0x7FFE86BAC290
        public void CreateWhitespace(){} // RVA: 0x7FFE86BAC360
        public void CreateSignificantWhitespace(){} // RVA: 0x7FFE86BAC430
        public void CreateXmlDeclaration(){} // RVA: 0x7FFE86BAC500
        public void CreateXmlDocumentType(){} // RVA: 0x7FFE86BAC5B0
        public void CreateProcessingInstruction(){} // RVA: 0x7FFE86BAC670
        public void CreateElement(){} // RVA: 0x7FFE86BAC7D0 | overloaded x2
        public void CreateAttribute(){} // RVA: 0x7FFE86BAC9D0 | overloaded x2
        public void get_DocumentElement(){} // RVA: 0x7FFE86BACB30
    }

    public class XmlElementWrapper : XmlNodeWrapper
    {
        public System.Xml.XmlElement _element; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86BAC040
        public void SetAttributeNode(){} // RVA: 0x7FFE86BACBC0
        public void GetPrefixOfNamespace(){} // RVA: 0x7FFE86BACCC0
        public void get_IsEmpty(){} // RVA: 0x7FFE86BACCF0
    }

    public class XmlNodeConverter : JsonConverter
    {
        public System.Collections.Generic.List`1<Newtonsoft.Json.Converters.IXmlNode> EmptyChildNodes;
        public string TextName;
        public string CommentName;
        public string CDataName;

        // ── Methods ──
        public void get_DeserializeRootElementName(){} // RVA: 0x7FFE81116380
        public void set_DeserializeRootElementName(){} // RVA: 0x7FFE810FCE30
        public void get_WriteArrayAttribute(){} // RVA: 0x7FFE811164E0
        public void set_WriteArrayAttribute(){} // RVA: 0x7FFE811164F0
        public void get_OmitRootObject(){} // RVA: 0x7FFE814B3730
        public void set_OmitRootObject(){} // RVA: 0x7FFE81CD0510
        public void get_EncodeSpecialCharacters(){} // RVA: 0x7FFE82930110
        public void set_EncodeSpecialCharacters(){} // RVA: 0x7FFE8292DD10
        public void WriteJson(){} // RVA: 0x7FFE86BB1900
        public void WrapXml(){} // RVA: 0x7FFE86BB1B50
        public void PushParentNamespaces(){} // RVA: 0x7FFE86BB1CA0
        public void ResolveFullName(){} // RVA: 0x7FFE86BB2270
        public void GetPropertyName(){} // RVA: 0x7FFE86BB2490
        public void IsArray(){} // RVA: 0x7FFE86BB28A0
        public void SerializeGroupedNodes(){} // RVA: 0x7FFE86BB2B50
        public void WriteGroupedNodes(){} // RVA: 0x7FFE86BB3580 | overloaded x2
        public void SerializeNode(){} // RVA: 0x7FFE86BB3670
        public void AllSameName(){} // RVA: 0x7FFE86BB45D0
        public void ReadJson(){} // RVA: 0x7FFE86BB47C0
        public void DeserializeValue(){} // RVA: 0x7FFE86BB4FF0
        public void ReadElement(){} // RVA: 0x7FFE86BB5490
        public void CreateElement(){} // RVA: 0x7FFE86BB8140 | overloaded x2
        public void AddAttribute(){} // RVA: 0x7FFE86BB5F80
        public void ConvertTokenToXmlValue(){} // RVA: 0x7FFE86BB6200
        public void ReadArrayElements(){} // RVA: 0x7FFE86BB6AB0
        public void AddJsonArrayAttribute(){} // RVA: 0x7FFE86BB6DE0
        public void ShouldReadInto(){} // RVA: 0x7FFE86BB6F80
        public void ReadAttributeElements(){} // RVA: 0x7FFE86BB7010
        public void CreateInstruction(){} // RVA: 0x7FFE86BB7820
        public void CreateDocumentType(){} // RVA: 0x7FFE86BB7CA0
        public void DeserializeNode(){} // RVA: 0x7FFE86BB8300
        public void IsNamespaceAttribute(){} // RVA: 0x7FFE86BB8CA0
        public void ValueAttributes(){} // RVA: 0x7FFE86BB8EF0
        public void CanConvert(){} // RVA: 0x7FFE86BB9180
        public void IsXObject(){} // RVA: 0x7FFE86BB9260
        public void IsXmlNode(){} // RVA: 0x7FFE86BB9340
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE86BB9420
    }

    public class XmlNodeWrapper : Object
    {
        public System.Xml.XmlNode _node; // 0x10
        public System.Collections.Generic.List`1<Newtonsoft.Json.Converters.IXmlNode> _childNodes; // 0x18
        public System.Collections.Generic.List`1<Newtonsoft.Json.Converters.IXmlNode> _attributes; // 0x20
        public object field_3; // 0x25F
        public object field_4; // 0x260
        public object field_5; // 0x261
        public object field_6; // 0x262
        public object field_7; // 0x263
        public object field_8; // 0x264
        public object field_9; // 0x265

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void get_WrappedNode(){} // RVA: 0x7FFE81116380
        public void get_NodeType(){} // RVA: 0x7FFE86853DC0
        public void get_LocalName(){} // RVA: 0x7FFE86BACEC0
        public void get_ChildNodes(){} // RVA: 0x7FFE86BACEF0
        public void get_HasChildNodes(){} // RVA: 0x7FFE86BAD390
        public void WrapNode(){} // RVA: 0x7FFE86BAD3C0
        public void get_Attributes(){} // RVA: 0x7FFE86BAD5F0
        public void get_HasAttributes(){} // RVA: 0x7FFE86BADB20
        public void get_ParentNode(){} // RVA: 0x7FFE86BADC00
        public void get_Value(){} // RVA: 0x7FFE86BADCC0
        public void set_Value(){} // RVA: 0x7FFE86BADCF0
        public void AppendChild(){} // RVA: 0x7FFE86BADD20
        public void get_NamespaceUri(){} // RVA: 0x7FFE86BADE80
    }

}