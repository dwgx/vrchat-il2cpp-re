// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Newtonsoft.Newtonsoft.Json.Converters
// Classes: 37
// Methods: 307

namespace ThirdParty.Newtonsoft.Newtonsoft.Json.Converters
{
    public class BinaryConverter : JsonConverter
    {
        public string BinaryTypeName;
        public string BinaryToArrayName;
        public Newtonsoft.Json.Utilities.ReflectionObject _reflectionObject;

        // ── Methods ──
        public void WriteJson(){} // RVA: 0x7FFAC87F7670
        public void GetByteArray(){} // RVA: 0x7FFAC87F76E0
        public void EnsureReflectionObject(){} // RVA: 0x7FFAC87F7940
        public void ReadJson(){} // RVA: 0x7FFAC87F7B50
        public void ReadByteArray(){} // RVA: 0x7FFAC87F80A0
        public void CanConvert(){} // RVA: 0x7FFAC87F8320
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class BsonObjectIdConverter : JsonConverter
    {
        // ── Methods ──
        public void WriteJson(){} // RVA: 0x7FFAC87F8460
        public void ReadJson(){} // RVA: 0x7FFAC87F8690
        public void CanConvert(){} // RVA: 0x7FFAC87F8950
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class CustomCreationConverter`1 : JsonConverter
    {
        public object CanWrite;

        // ── Methods ──
        public void WriteJson(){} // RVA: 0x7FFAC2C7AF60
        public void ReadJson(){} // RVA: 0x7FFAC2C6B140
        public void Create(){} // RVA: 0x7FFAC2E8DC40
        public void CanConvert(){} // RVA: 0x7FFAC2C59F60
        public void get_CanWrite(){} // RVA: 0x7FFAC2C59D00
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class DataSetConverter : JsonConverter
    {
        // ── Methods ──
        public void WriteJson(){} // RVA: 0x7FFAC87F8A20
        public void ReadJson(){} // RVA: 0x7FFAC87F8E40
        public void CanConvert(){} // RVA: 0x7FFAC87F91D0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class DataTableConverter : JsonConverter
    {
        // ── Methods ──
        public void WriteJson(){} // RVA: 0x7FFAC87F92B0
        public void ReadJson(){} // RVA: 0x7FFAC87F9840
        public void CreateRow(){} // RVA: 0x7FFAC87F9BD0
        public void GetColumnDataType(){} // RVA: 0x7FFAC87FA1B0
        public void CanConvert(){} // RVA: 0x7FFAC87FA3D0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class DateTimeConverterBase : JsonConverter
    {
        // ── Methods ──
        public void CanConvert(){} // RVA: 0x7FFAC87FA4B0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class DiscriminatedUnionConverter : JsonConverter
    {
        public string CasePropertyName;
        public string FieldsPropertyName;
        public Newtonsoft.Json.Utilities.ThreadSafeStore`2<System.Type,Union> UnionCache;
        public Newtonsoft.Json.Utilities.ThreadSafeStore`2<System.Type,System.Type> UnionTypeLookupCache; // 0x8

        // ── Methods ──
        public void CreateUnionTypeLookup(){} // RVA: 0x7FFAC87FA640
        public void CreateUnion(){} // RVA: 0x7FFAC87FA8A0
        public void WriteJson(){} // RVA: 0x7FFAC87FB3D0
        public void ReadJson(){} // RVA: 0x7FFAC87FB9D0
        public void CanConvert(){} // RVA: 0x7FFAC87FC440
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC87FC750
    }

    public class EntityKeyMemberConverter : JsonConverter
    {
        public string EntityKeyMemberFullTypeName;
        public string KeyPropertyName;
        public string TypePropertyName;
        public string ValuePropertyName;
        public Newtonsoft.Json.Utilities.ReflectionObject _reflectionObject;

        // ── Methods ──
        public void WriteJson(){} // RVA: 0x7FFAC87FCB50
        public void ReadAndAssertProperty(){} // RVA: 0x7FFAC87FCF10
        public void ReadJson(){} // RVA: 0x7FFAC87FD100
        public void EnsureReflectionObject(){} // RVA: 0x7FFAC87FD4E0
        public void CanConvert(){} // RVA: 0x7FFAC87FD630
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ExpandoObjectConverter : JsonConverter
    {
        public object CanWrite;

        // ── Methods ──
        public void WriteJson(){} // RVA: 0x7FFAC2F21310
        public void ReadJson(){} // RVA: 0x7FFAC87FD690
        public void ReadValue(){} // RVA: 0x7FFAC87FD6A0
        public void ReadList(){} // RVA: 0x7FFAC87FD980
        public void ReadObject(){} // RVA: 0x7FFAC87FDAC0
        public void CanConvert(){} // RVA: 0x7FFAC87FDD90
        public void get_CanWrite(){} // RVA: 0x7FFAC2F21320
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class IXmlDeclaration
    {
        public object Version;
        public object Encoding;
        public object Standalone;

        // ── Methods ──
        public void get_Version(){} // RVA: 0x7FFAC2C58E90
        public void get_Encoding(){} // RVA: 0x7FFAC2C58E90
        public void set_Encoding(){} // RVA: 0x7FFAC2C70A40
        public void get_Standalone(){} // RVA: 0x7FFAC2C58E90
        public void set_Standalone(){} // RVA: 0x7FFAC2C70A40
    }

    public class IXmlDocument
    {
        public object DocumentElement;

        // ── Methods ──
        public void CreateComment(){} // RVA: 0x7FFAC2C58F40
        public void CreateTextNode(){} // RVA: 0x7FFAC2C58F40
        public void CreateCDataSection(){} // RVA: 0x7FFAC2C58F40
        public void CreateWhitespace(){} // RVA: 0x7FFAC2C58F40
        public void CreateSignificantWhitespace(){} // RVA: 0x7FFAC2C58F40
        public void CreateXmlDeclaration(){} // RVA: 0x7FFAC2C6AE80
        public void CreateXmlDocumentType(){} // RVA: 0x7FFAC2C6B140
        public void CreateProcessingInstruction(){} // RVA: 0x7FFAC2C6A6F0
        public void CreateElement(){} // RVA: 0x7FFAC2C6A6F0 | overloaded x2
        public void CreateAttribute(){} // RVA: 0x7FFAC2C6AE80 | overloaded x2
        public void get_DocumentElement(){} // RVA: 0x7FFAC2C58E90
    }

    public class IXmlDocumentType
    {
        public object Name;
        public object System;
        public object Public;
        public object InternalSubset;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAC2C58E90
        public void get_System(){} // RVA: 0x7FFAC2C58E90
        public void get_Public(){} // RVA: 0x7FFAC2C58E90
        public void get_InternalSubset(){} // RVA: 0x7FFAC2C58E90
    }

    public class IXmlElement
    {
        public object IsEmpty;

        // ── Methods ──
        public void SetAttributeNode(){} // RVA: 0x7FFAC2C70A40
        public void GetPrefixOfNamespace(){} // RVA: 0x7FFAC2C58F40
        public void get_IsEmpty(){} // RVA: 0x7FFAC2C59D00
    }

    public class IXmlNode
    {
        public object NodeType;
        public object LocalName;
        public object ChildNodes;
        public object Attributes;
        public object ParentNode;
        public object Value;
        public object NamespaceUri;
        public object WrappedNode;

        // ── Methods ──
        public void get_NodeType(){} // RVA: 0x7FFAC2C59960
        public void get_LocalName(){} // RVA: 0x7FFAC2C58E90
        public void get_ChildNodes(){} // RVA: 0x7FFAC2C58E90
        public void get_Attributes(){} // RVA: 0x7FFAC2C58E90
        public void get_ParentNode(){} // RVA: 0x7FFAC2C58E90
        public void get_Value(){} // RVA: 0x7FFAC2C58E90
        public void set_Value(){} // RVA: 0x7FFAC2C70A40
        public void AppendChild(){} // RVA: 0x7FFAC2C58F40
        public void get_NamespaceUri(){} // RVA: 0x7FFAC2C58E90
        public void get_WrappedNode(){} // RVA: 0x7FFAC2C58E90
    }

    public class IsoDateTimeConverter : DateTimeConverterBase
    {
        public string DateTimeStyles;
        public 0x6B0DB3D8 DateTimeFormat; // 0x10
        public string Culture; // 0x18
        public System.Globalization.CultureInfo _culture; // 0x20

        // ── Methods ──
        public void get_DateTimeStyles(){} // RVA: 0x7FFAC2F6E5C0
        public void set_DateTimeStyles(){} // RVA: 0x7FFAC2F240C0
        public void get_DateTimeFormat(){} // RVA: 0x7FFAC87FDE60
        public void set_DateTimeFormat(){} // RVA: 0x7FFAC87FDEB0
        public void get_Culture(){} // RVA: 0x7FFAC87FDF30
        public void set_Culture(){} // RVA: 0x7FFAC2F4F0D0
        public void WriteJson(){} // RVA: 0x7FFAC87FDFC0
        public void ReadJson(){} // RVA: 0x7FFAC87FE300
        public void .ctor(){} // RVA: 0x7FFAC87FE8B0
    }

    public class JavaScriptDateTimeConverter : DateTimeConverterBase
    {
        // ── Methods ──
        public void WriteJson(){} // RVA: 0x7FFAC87FE8C0
        public void ReadJson(){} // RVA: 0x7FFAC87FEBE0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class KeyValuePairConverter : JsonConverter
    {
        public string KeyName;
        public string ValueName;
        public Newtonsoft.Json.Utilities.ThreadSafeStore`2<System.Type,Newtonsoft.Json.Utilities.ReflectionObject> ReflectionObjectPerType;

        // ── Methods ──
        public void InitializeReflectionObject(){} // RVA: 0x7FFAC87FF010
        public void WriteJson(){} // RVA: 0x7FFAC87FF210
        public void ReadJson(){} // RVA: 0x7FFAC87FF570
        public void CanConvert(){} // RVA: 0x7FFAC87FFC00
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC87FFD20
    }

    public class RegexConverter : JsonConverter
    {
        public string PatternName;
        public string OptionsName;

        // ── Methods ──
        public void WriteJson(){} // RVA: 0x7FFAC88001D0 | overloaded x2
        public void HasFlag(){} // RVA: 0x7FFAC84CAD10
        public void WriteBson(){} // RVA: 0x7FFAC87FFF80
        public void ReadJson(){} // RVA: 0x7FFAC88003F0
        public void ReadRegexString(){} // RVA: 0x7FFAC88005F0
        public void ReadRegexObject(){} // RVA: 0x7FFAC8800760
        public void CanConvert(){} // RVA: 0x7FFAC8800B70
        public void IsRegex(){} // RVA: 0x7FFAC8800C20
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class StringEnumConverter : JsonConverter
    {
        public Newtonsoft.Json.Serialization.NamingStrategy CamelCaseText; // 0x10
        public bool NamingStrategy; // 0x18

        // ── Methods ──
        public void get_CamelCaseText(){} // RVA: 0x7FFAC8800E20
        public void set_CamelCaseText(){} // RVA: 0x7FFAC8800E90
        public void get_NamingStrategy(){} // RVA: 0x7FFAC2F3C380
        public void set_NamingStrategy(){} // RVA: 0x7FFAC2F22E30
        public void get_AllowIntegerValues(){} // RVA: 0x7FFAC2F3C4E0
        public void set_AllowIntegerValues(){} // RVA: 0x7FFAC2F3C4F0
        public void .ctor(){} // RVA: 0x7FFAC88012A0 | overloaded x6
        public void WriteJson(){} // RVA: 0x7FFAC88013D0
        public void ReadJson(){} // RVA: 0x7FFAC88015E0
        public void CanConvert(){} // RVA: 0x7FFAC8801A60
    }

    public class UnixDateTimeConverter : DateTimeConverterBase
    {
        public System.DateTime AllowPreEpoch;
        public bool <AllowPreEpoch>k__BackingField; // 0x10

        // ── Methods ──
        public void get_AllowPreEpoch(){} // RVA: 0x7FFAC2FEB5E0
        public void set_AllowPreEpoch(){} // RVA: 0x7FFAC2FEB5F0
        public void .ctor(){} // RVA: 0x7FFAC2FEB5F0 | overloaded x2
        public void WriteJson(){} // RVA: 0x7FFAC8801AF0
        public void ReadJson(){} // RVA: 0x7FFAC8801E60
        public void .cctor(){} // RVA: 0x7FFAC8802470
    }

    public class VersionConverter : JsonConverter
    {
        // ── Methods ──
        public void WriteJson(){} // RVA: 0x7FFAC88024F0
        public void ReadJson(){} // RVA: 0x7FFAC88025F0
        public void CanConvert(){} // RVA: 0x7FFAC8802850
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class XAttributeWrapper : XObjectWrapper
    {
        public object Attribute;
        public object Value;
        public object LocalName;
        public object NamespaceUri;
        public object ParentNode;

        // ── Methods ──
        public void get_Attribute(){} // RVA: 0x7FFAC8807210
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void get_Value(){} // RVA: 0x7FFAC8807290
        public void set_Value(){} // RVA: 0x7FFAC88072B0
        public void get_LocalName(){} // RVA: 0x7FFAC8807470
        public void get_NamespaceUri(){} // RVA: 0x7FFAC88074A0
        public void get_ParentNode(){} // RVA: 0x7FFAC88074E0
    }

    public class XCommentWrapper : XObjectWrapper
    {
        public object Text;
        public object Value;
        public object ParentNode;

        // ── Methods ──
        public void get_Text(){} // RVA: 0x7FFAC8805FD0
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void get_Value(){} // RVA: 0x7FFAC8806050
        public void set_Value(){} // RVA: 0x7FFAC8806070
        public void get_ParentNode(){} // RVA: 0x7FFAC8806220
    }

    public class XContainerWrapper : XObjectWrapper
    {
        public System.Collections.Generic.List`1<Newtonsoft.Json.Converters.IXmlNode> Container; // 0x18

        // ── Methods ──
        public void get_Container(){} // RVA: 0x7FFAC88064F0
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void get_ChildNodes(){} // RVA: 0x7FFAC8806570
        public void get_HasChildNodes(){} // RVA: 0x7FFAC88069C0
        public void get_ParentNode(){} // RVA: 0x7FFAC88069F0
        public void WrapNode(){} // RVA: 0x7FFAC8806A50
        public void AppendChild(){} // RVA: 0x7FFAC8806FD0
    }

    public class XDeclarationWrapper : XObjectWrapper
    {
        public System.Xml.Linq.XDeclaration Declaration; // 0x18

        // ── Methods ──
        public void get_Declaration(){} // RVA: 0x7FFAC2F247C0
        public void .ctor(){} // RVA: 0x7FFAC8804790
        public void get_NodeType(){} // RVA: 0x7FFAC8804850
        public void get_Version(){} // RVA: 0x7FFAC356C7D0
        public void get_Encoding(){} // RVA: 0x7FFAC8804860
        public void set_Encoding(){} // RVA: 0x7FFAC8804880
        public void get_Standalone(){} // RVA: 0x7FFAC47C2590
        public void set_Standalone(){} // RVA: 0x7FFAC88048F0
    }

    public class XDocumentTypeWrapper : XObjectWrapper
    {
        public System.Xml.Linq.XDocumentType Name; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC86DB540
        public void get_Name(){} // RVA: 0x7FFAC8804960
        public void get_System(){} // RVA: 0x7FFAC8804980
        public void get_Public(){} // RVA: 0x7FFAC88049A0
        public void get_InternalSubset(){} // RVA: 0x7FFAC88049C0
        public void get_LocalName(){} // RVA: 0x7FFAC88049E0
    }

    public class XDocumentWrapper : XContainerWrapper
    {
        public object Document;
        public object ChildNodes;
        public object HasChildNodes;
        public object DocumentElement;

        // ── Methods ──
        public void get_Document(){} // RVA: 0x7FFAC8804A20
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void get_ChildNodes(){} // RVA: 0x7FFAC8804AA0
        public void get_HasChildNodes(){} // RVA: 0x7FFAC8804BF0
        public void CreateComment(){} // RVA: 0x7FFAC8804C40
        public void CreateTextNode(){} // RVA: 0x7FFAC8804DA0
        public void CreateCDataSection(){} // RVA: 0x7FFAC8804F00
        public void CreateWhitespace(){} // RVA: 0x7FFAC8805060
        public void CreateSignificantWhitespace(){} // RVA: 0x7FFAC88051C0
        public void CreateXmlDeclaration(){} // RVA: 0x7FFAC8805320
        public void CreateXmlDocumentType(){} // RVA: 0x7FFAC88053D0
        public void CreateProcessingInstruction(){} // RVA: 0x7FFAC8805490
        public void CreateElement(){} // RVA: 0x7FFAC8805700 | overloaded x2
        public void CreateAttribute(){} // RVA: 0x7FFAC8805A70 | overloaded x2
        public void get_DocumentElement(){} // RVA: 0x7FFAC8805C50
        public void AppendChild(){} // RVA: 0x7FFAC8805D30
    }

    public class XElementWrapper : XContainerWrapper
    {
        public System.Collections.Generic.List`1<Newtonsoft.Json.Converters.IXmlNode> Element; // 0x20

        // ── Methods ──
        public void get_Element(){} // RVA: 0x7FFAC8807540
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void SetAttributeNode(){} // RVA: 0x7FFAC88075C0
        public void get_Attributes(){} // RVA: 0x7FFAC88076C0
        public void HasImplicitNamespaceAttribute(){} // RVA: 0x7FFAC8807C00
        public void AppendChild(){} // RVA: 0x7FFAC8807F70
        public void get_Value(){} // RVA: 0x7FFAC8807FE0
        public void set_Value(){} // RVA: 0x7FFAC8808010
        public void get_LocalName(){} // RVA: 0x7FFAC88080E0
        public void get_NamespaceUri(){} // RVA: 0x7FFAC8808110
        public void GetPrefixOfNamespace(){} // RVA: 0x7FFAC8808150
        public void get_IsEmpty(){} // RVA: 0x7FFAC88081B0
    }

    public class XObjectWrapper : Object
    {
        public System.Xml.Linq.XObject WrappedNode; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void get_WrappedNode(){} // RVA: 0x7FFAC2F3C380
        public void get_NodeType(){} // RVA: 0x7FFAC88070B0
        public void get_LocalName(){} // RVA: 0x7FFAC34F9180
        public void get_ChildNodes(){} // RVA: 0x7FFAC88070D0
        public void get_Attributes(){} // RVA: 0x7FFAC8807130
        public void get_ParentNode(){} // RVA: 0x7FFAC34F9180
        public void get_Value(){} // RVA: 0x7FFAC34F9180
        public void set_Value(){} // RVA: 0x7FFAC8807190
        public void AppendChild(){} // RVA: 0x7FFAC88071D0
        public void get_NamespaceUri(){} // RVA: 0x7FFAC34F9180
    }

    public class XProcessingInstructionWrapper : XObjectWrapper
    {
        public object ProcessingInstruction;
        public object LocalName;
        public object Value;

        // ── Methods ──
        public void get_ProcessingInstruction(){} // RVA: 0x7FFAC8806280
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void get_LocalName(){} // RVA: 0x7FFAC8806300
        public void get_Value(){} // RVA: 0x7FFAC8806320
        public void set_Value(){} // RVA: 0x7FFAC8806340
    }

    public class XTextWrapper : XObjectWrapper
    {
        public object Text;
        public object Value;
        public object ParentNode;

        // ── Methods ──
        public void get_Text(){} // RVA: 0x7FFAC8805E50
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void get_Value(){} // RVA: 0x7FFAC8805ED0
        public void set_Value(){} // RVA: 0x7FFAC8805EF0
        public void get_ParentNode(){} // RVA: 0x7FFAC8805F70
    }

    public class XmlDeclarationWrapper : XmlNodeWrapper
    {
        public System.Xml.XmlDeclaration Version; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8802920
        public void get_Version(){} // RVA: 0x7FFAC69A40A0
        public void get_Encoding(){} // RVA: 0x7FFAC88035F0
        public void set_Encoding(){} // RVA: 0x7FFAC8803610
        public void get_Standalone(){} // RVA: 0x7FFAC88036D0
        public void set_Standalone(){} // RVA: 0x7FFAC88036F0
    }

    public class XmlDocumentTypeWrapper : XmlNodeWrapper
    {
        public System.Xml.XmlDocumentType Name; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8802920
        public void get_Name(){} // RVA: 0x7FFAC8803710
        public void get_System(){} // RVA: 0x7FFAC88036D0
        public void get_Public(){} // RVA: 0x7FFAC88035F0
        public void get_InternalSubset(){} // RVA: 0x7FFAC8803740
        public void get_LocalName(){} // RVA: 0x7FFAC8803760
    }

    public class XmlDocumentWrapper : XmlNodeWrapper
    {
        public System.Xml.XmlDocument DocumentElement; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8802920
        public void CreateComment(){} // RVA: 0x7FFAC88029D0
        public void CreateTextNode(){} // RVA: 0x7FFAC8802AA0
        public void CreateCDataSection(){} // RVA: 0x7FFAC8802B70
        public void CreateWhitespace(){} // RVA: 0x7FFAC8802C40
        public void CreateSignificantWhitespace(){} // RVA: 0x7FFAC8802D10
        public void CreateXmlDeclaration(){} // RVA: 0x7FFAC8802DE0
        public void CreateXmlDocumentType(){} // RVA: 0x7FFAC8802E90
        public void CreateProcessingInstruction(){} // RVA: 0x7FFAC8802F50
        public void CreateElement(){} // RVA: 0x7FFAC88030B0 | overloaded x2
        public void CreateAttribute(){} // RVA: 0x7FFAC88032B0 | overloaded x2
        public void get_DocumentElement(){} // RVA: 0x7FFAC8803410
    }

    public class XmlElementWrapper : XmlNodeWrapper
    {
        public System.Xml.XmlElement IsEmpty; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8802920
        public void SetAttributeNode(){} // RVA: 0x7FFAC88034A0
        public void GetPrefixOfNamespace(){} // RVA: 0x7FFAC88035A0
        public void get_IsEmpty(){} // RVA: 0x7FFAC88035D0
    }

    public class XmlNodeConverter : JsonConverter
    {
        public System.Collections.Generic.List`1<Newtonsoft.Json.Converters.IXmlNode> DeserializeRootElementName;
        public string WriteArrayAttribute;
        public string OmitRootObject;
        public string EncodeSpecialCharacters;
        public string WhitespaceName;
        public string SignificantWhitespaceName;
        public string DeclarationName;
        public string JsonNamespaceUri;
        public string <DeserializeRootElementName>k__BackingField; // 0x10
        public bool <WriteArrayAttribute>k__BackingField; // 0x18
        public bool <OmitRootObject>k__BackingField; // 0x19
        public bool <EncodeSpecialCharacters>k__BackingField; // 0x1A

        // ── Methods ──
        public void get_DeserializeRootElementName(){} // RVA: 0x7FFAC2F3C380
        public void set_DeserializeRootElementName(){} // RVA: 0x7FFAC2F22E30
        public void get_WriteArrayAttribute(){} // RVA: 0x7FFAC2F3C4E0
        public void set_WriteArrayAttribute(){} // RVA: 0x7FFAC2F3C4F0
        public void get_OmitRootObject(){} // RVA: 0x7FFAC3228D50
        public void set_OmitRootObject(){} // RVA: 0x7FFAC3515120
        public void get_EncodeSpecialCharacters(){} // RVA: 0x7FFAC45FA190
        public void set_EncodeSpecialCharacters(){} // RVA: 0x7FFAC45F9AE0
        public void WriteJson(){} // RVA: 0x7FFAC88081E0
        public void WrapXml(){} // RVA: 0x7FFAC8808430
        public void PushParentNamespaces(){} // RVA: 0x7FFAC8808580
        public void ResolveFullName(){} // RVA: 0x7FFAC8808B50
        public void GetPropertyName(){} // RVA: 0x7FFAC8808D70
        public void IsArray(){} // RVA: 0x7FFAC8809180
        public void SerializeGroupedNodes(){} // RVA: 0x7FFAC8809430
        public void WriteGroupedNodes(){} // RVA: 0x7FFAC8809E60 | overloaded x2
        public void SerializeNode(){} // RVA: 0x7FFAC8809F50
        public void AllSameName(){} // RVA: 0x7FFAC880AEB0
        public void ReadJson(){} // RVA: 0x7FFAC880B0A0
        public void DeserializeValue(){} // RVA: 0x7FFAC880B8D0
        public void ReadElement(){} // RVA: 0x7FFAC880BD70
        public void CreateElement(){} // RVA: 0x7FFAC880EA20 | overloaded x2
        public void AddAttribute(){} // RVA: 0x7FFAC880C860
        public void ConvertTokenToXmlValue(){} // RVA: 0x7FFAC880CAE0
        public void ReadArrayElements(){} // RVA: 0x7FFAC880D390
        public void AddJsonArrayAttribute(){} // RVA: 0x7FFAC880D6C0
        public void ShouldReadInto(){} // RVA: 0x7FFAC880D860
        public void ReadAttributeElements(){} // RVA: 0x7FFAC880D8F0
        public void CreateInstruction(){} // RVA: 0x7FFAC880E100
        public void CreateDocumentType(){} // RVA: 0x7FFAC880E580
        public void DeserializeNode(){} // RVA: 0x7FFAC880EBE0
        public void IsNamespaceAttribute(){} // RVA: 0x7FFAC880F580
        public void ValueAttributes(){} // RVA: 0x7FFAC880F7D0
        public void CanConvert(){} // RVA: 0x7FFAC880FA60
        public void IsXObject(){} // RVA: 0x7FFAC880FB40
        public void IsXmlNode(){} // RVA: 0x7FFAC880FC20
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC880FD00
    }

    public class XmlNodeWrapper : Object
    {
        public System.Xml.XmlNode WrappedNode; // 0x10
        public System.Collections.Generic.List`1<Newtonsoft.Json.Converters.IXmlNode> NodeType; // 0x18
        public System.Collections.Generic.List`1<Newtonsoft.Json.Converters.IXmlNode> LocalName; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void get_WrappedNode(){} // RVA: 0x7FFAC2F3C380
        public void get_NodeType(){} // RVA: 0x7FFAC84AA500
        public void get_LocalName(){} // RVA: 0x7FFAC88037A0
        public void get_ChildNodes(){} // RVA: 0x7FFAC88037D0
        public void get_HasChildNodes(){} // RVA: 0x7FFAC8803C70
        public void WrapNode(){} // RVA: 0x7FFAC8803CA0
        public void get_Attributes(){} // RVA: 0x7FFAC8803ED0
        public void get_HasAttributes(){} // RVA: 0x7FFAC8804400
        public void get_ParentNode(){} // RVA: 0x7FFAC88044E0
        public void get_Value(){} // RVA: 0x7FFAC88045A0
        public void set_Value(){} // RVA: 0x7FFAC88045D0
        public void AppendChild(){} // RVA: 0x7FFAC8804600
        public void get_NamespaceUri(){} // RVA: 0x7FFAC8804760
    }

}