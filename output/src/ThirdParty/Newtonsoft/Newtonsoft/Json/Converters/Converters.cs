// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Newtonsoft.Newtonsoft.Json.Converters
// Classes: 37
// Methods: 307

namespace ThirdParty.Newtonsoft.Newtonsoft.Json.Converters
{
    public class BinaryConverter
    {
        // ── Methods ──
        public void WriteJson(){} // RVA: 0x605FFC0
        public void GetByteArray(){} // RVA: 0x6060030
        public void EnsureReflectionObject(){} // RVA: 0x6060290
        public void ReadJson(){} // RVA: 0x60604A0
        public void ReadByteArray(){} // RVA: 0x60609F0
        public void CanConvert(){} // RVA: 0x6060C70
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class BsonObjectIdConverter
    {
        // ── Methods ──
        public void WriteJson(){} // RVA: 0x6060DB0
        public void ReadJson(){} // RVA: 0x6060FE0
        public void CanConvert(){} // RVA: 0x60612A0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class CustomCreationConverter`1
    {
        // ── Methods ──
        public void WriteJson(){} // RVA: 0x2F090
        public void ReadJson(){} // RVA: 0x1F0F0
        public void Create(){} // RVA: 0x283FA0
        public void CanConvert(){} // RVA: 0xDE40
        public void get_CanWrite(){} // RVA: 0xDBE0
        public void .ctor(){} // RVA: 0x24A50
    }

    public class DataSetConverter
    {
        // ── Methods ──
        public void WriteJson(){} // RVA: 0x6061370
        public void ReadJson(){} // RVA: 0x6061790
        public void CanConvert(){} // RVA: 0x6061B20
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class DataTableConverter
    {
        // ── Methods ──
        public void WriteJson(){} // RVA: 0x6061C00
        public void ReadJson(){} // RVA: 0x6062190
        public void CreateRow(){} // RVA: 0x6062520
        public void GetColumnDataType(){} // RVA: 0x6062B00
        public void CanConvert(){} // RVA: 0x6062D20
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class DateTimeConverterBase
    {
        // ── Methods ──
        public void CanConvert(){} // RVA: 0x6062E00
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class DiscriminatedUnionConverter
    {
        // ── Methods ──
        public void CreateUnionTypeLookup(){} // RVA: 0x6062F90
        public void CreateUnion(){} // RVA: 0x60631F0
        public void WriteJson(){} // RVA: 0x6063D20
        public void ReadJson(){} // RVA: 0x6064320
        public void CanConvert(){} // RVA: 0x6064D90
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x60650A0
    }

    public class EntityKeyMemberConverter
    {
        // ── Methods ──
        public void WriteJson(){} // RVA: 0x60654A0
        public void ReadAndAssertProperty(){} // RVA: 0x6065860
        public void ReadJson(){} // RVA: 0x6065A50
        public void EnsureReflectionObject(){} // RVA: 0x6065E30
        public void CanConvert(){} // RVA: 0x6065F80
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ExpandoObjectConverter
    {
        // ── Methods ──
        public void WriteJson(){} // RVA: 0x2DD310
        public void ReadJson(){} // RVA: 0x6065FE0
        public void ReadValue(){} // RVA: 0x6065FF0
        public void ReadList(){} // RVA: 0x60662D0
        public void ReadObject(){} // RVA: 0x6066410
        public void CanConvert(){} // RVA: 0x60666E0
        public void get_CanWrite(){} // RVA: 0x2DD320
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class IXmlDeclaration : ؄}e
    {
        // ── Methods ──
        public void get_Version(){} // RVA: 0xCD60
        public void get_Encoding(){} // RVA: 0xCD60
        public void set_Encoding(){} // RVA: 0x24B10
        public void get_Standalone(){} // RVA: 0xCD60
        public void set_Standalone(){} // RVA: 0x24B10
    }

    public class IXmlDocument
    {
        // ── Methods ──
        public void CreateComment(){} // RVA: 0xCE10
        public void CreateTextNode(){} // RVA: 0xCE10
        public void CreateCDataSection(){} // RVA: 0xCE10
        public void CreateWhitespace(){} // RVA: 0xCE10
        public void CreateSignificantWhitespace(){} // RVA: 0xCE10
        public void CreateXmlDeclaration(){} // RVA: 0x1EE30
        public void CreateXmlDocumentType(){} // RVA: 0x1F0F0
        public void CreateProcessingInstruction(){} // RVA: 0x1E6A0
        public void CreateElement(){} // RVA: 0x1E6A0 | overloaded x2
        public void CreateAttribute(){} // RVA: 0x1EE30 | overloaded x2
        public void get_DocumentElement(){} // RVA: 0xCD60
    }

    public class IXmlDocumentType
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0xCD60
        public void get_System(){} // RVA: 0xCD60
        public void get_Public(){} // RVA: 0xCD60
        public void get_InternalSubset(){} // RVA: 0xCD60
    }

    public class IXmlElement
    {
        // ── Methods ──
        public void SetAttributeNode(){} // RVA: 0x24B10
        public void GetPrefixOfNamespace(){} // RVA: 0xCE10
        public void get_IsEmpty(){} // RVA: 0xDBE0
    }

    public class IXmlNode
    {
        // ── Methods ──
        public void get_NodeType(){} // RVA: 0xD840
        public void get_LocalName(){} // RVA: 0xCD60
        public void get_ChildNodes(){} // RVA: 0xCD60
        public void get_Attributes(){} // RVA: 0xCD60
        public void get_ParentNode(){} // RVA: 0xCD60
        public void get_Value(){} // RVA: 0xCD60
        public void set_Value(){} // RVA: 0x24B10
        public void AppendChild(){} // RVA: 0xCE10
        public void get_NamespaceUri(){} // RVA: 0xCD60
        public void get_WrappedNode(){} // RVA: 0xCD60
    }

    public class IsoDateTimeConverter
    {
        // ── Methods ──
        public void get_DateTimeStyles(){} // RVA: 0x32A5C0
        public void set_DateTimeStyles(){} // RVA: 0x2E00C0
        public void get_DateTimeFormat(){} // RVA: 0x60667B0
        public void set_DateTimeFormat(){} // RVA: 0x6066800
        public void get_Culture(){} // RVA: 0x6066880
        public void set_Culture(){} // RVA: 0x30B0D0
        public void WriteJson(){} // RVA: 0x6066910
        public void ReadJson(){} // RVA: 0x6066C50
        public void .ctor(){} // RVA: 0x6067200
    }

    public class JavaScriptDateTimeConverter
    {
        // ── Methods ──
        public void WriteJson(){} // RVA: 0x6067210
        public void ReadJson(){} // RVA: 0x6067530
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class KeyValuePairConverter
    {
        // ── Methods ──
        public void InitializeReflectionObject(){} // RVA: 0x6067960
        public void WriteJson(){} // RVA: 0x6067B60
        public void ReadJson(){} // RVA: 0x6067EC0
        public void CanConvert(){} // RVA: 0x6068550
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x6068670
    }

    public class RegexConverter
    {
        // ── Methods ──
        public void WriteJson(){} // RVA: 0x6068B20 | overloaded x2
        public void HasFlag(){} // RVA: 0x5D33640
        public void WriteBson(){} // RVA: 0x60688D0
        public void ReadJson(){} // RVA: 0x6068D40
        public void ReadRegexString(){} // RVA: 0x6068F40
        public void ReadRegexObject(){} // RVA: 0x60690B0
        public void CanConvert(){} // RVA: 0x60694C0
        public void IsRegex(){} // RVA: 0x6069570
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class StringEnumConverter
    {
        // ── Methods ──
        public void get_CamelCaseText(){} // RVA: 0x6069770
        public void set_CamelCaseText(){} // RVA: 0x60697E0
        public void get_NamingStrategy(){} // RVA: 0x2F8380
        public void set_NamingStrategy(){} // RVA: 0x2DEE30
        public void get_AllowIntegerValues(){} // RVA: 0x2F84E0
        public void set_AllowIntegerValues(){} // RVA: 0x2F84F0
        public void .ctor(){} // RVA: 0x6069BF0 | overloaded x6
        public void WriteJson(){} // RVA: 0x6069D20
        public void ReadJson(){} // RVA: 0x6069F30
        public void CanConvert(){} // RVA: 0x606A3B0
    }

    public class UnixDateTimeConverter
    {
        // ── Methods ──
        public void get_AllowPreEpoch(){} // RVA: 0x3A75E0
        public void set_AllowPreEpoch(){} // RVA: 0x3A75F0
        public void .ctor(){} // RVA: 0x3A75F0 | overloaded x2
        public void WriteJson(){} // RVA: 0x606A440
        public void ReadJson(){} // RVA: 0x606A7B0
        public void .cctor(){} // RVA: 0x606ADC0
    }

    public class VersionConverter
    {
        // ── Methods ──
        public void WriteJson(){} // RVA: 0x606AE40
        public void ReadJson(){} // RVA: 0x606AF40
        public void CanConvert(){} // RVA: 0x606B1A0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class XAttributeWrapper
    {
        // ── Methods ──
        public void get_Attribute(){} // RVA: 0x606FB60
        public void .ctor(){} // RVA: 0x2DEE30
        public void get_Value(){} // RVA: 0x606FBE0
        public void set_Value(){} // RVA: 0x606FC00
        public void get_LocalName(){} // RVA: 0x606FDC0
        public void get_NamespaceUri(){} // RVA: 0x606FDF0
        public void get_ParentNode(){} // RVA: 0x606FE30
    }

    public class XCommentWrapper
    {
        // ── Methods ──
        public void get_Text(){} // RVA: 0x606E920
        public void .ctor(){} // RVA: 0x2DEE30
        public void get_Value(){} // RVA: 0x606E9A0
        public void set_Value(){} // RVA: 0x606E9C0
        public void get_ParentNode(){} // RVA: 0x606EB70
    }

    public class XContainerWrapper
    {
        // ── Methods ──
        public void get_Container(){} // RVA: 0x606EE40
        public void .ctor(){} // RVA: 0x2DEE30
        public void get_ChildNodes(){} // RVA: 0x606EEC0
        public void get_HasChildNodes(){} // RVA: 0x606F310
        public void get_ParentNode(){} // RVA: 0x606F340
        public void WrapNode(){} // RVA: 0x606F3A0
        public void AppendChild(){} // RVA: 0x606F920
    }

    public class XDeclarationWrapper
    {
        // ── Methods ──
        public void get_Declaration(){} // RVA: 0x2E07C0
        public void .ctor(){} // RVA: 0x606D0E0
        public void get_NodeType(){} // RVA: 0x606D1A0
        public void get_Version(){} // RVA: 0xF9DC10
        public void get_Encoding(){} // RVA: 0x606D1B0
        public void set_Encoding(){} // RVA: 0x606D1D0
        public void get_Standalone(){} // RVA: 0x1C98E90
        public void set_Standalone(){} // RVA: 0x606D240
    }

    public class XDocumentTypeWrapper
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5F43ED0
        public void get_Name(){} // RVA: 0x606D2B0
        public void get_System(){} // RVA: 0x606D2D0
        public void get_Public(){} // RVA: 0x606D2F0
        public void get_InternalSubset(){} // RVA: 0x606D310
        public void get_LocalName(){} // RVA: 0x606D330
    }

    public class XDocumentWrapper
    {
        // ── Methods ──
        public void get_Document(){} // RVA: 0x606D370
        public void .ctor(){} // RVA: 0x2DEE30
        public void get_ChildNodes(){} // RVA: 0x606D3F0
        public void get_HasChildNodes(){} // RVA: 0x606D540
        public void CreateComment(){} // RVA: 0x606D590
        public void CreateTextNode(){} // RVA: 0x606D6F0
        public void CreateCDataSection(){} // RVA: 0x606D850
        public void CreateWhitespace(){} // RVA: 0x606D9B0
        public void CreateSignificantWhitespace(){} // RVA: 0x606DB10
        public void CreateXmlDeclaration(){} // RVA: 0x606DC70
        public void CreateXmlDocumentType(){} // RVA: 0x606DD20
        public void CreateProcessingInstruction(){} // RVA: 0x606DDE0
        public void CreateElement(){} // RVA: 0x606E050 | overloaded x2
        public void CreateAttribute(){} // RVA: 0x606E3C0 | overloaded x2
        public void get_DocumentElement(){} // RVA: 0x606E5A0
        public void AppendChild(){} // RVA: 0x606E680
    }

    public class XElementWrapper
    {
        // ── Methods ──
        public void get_Element(){} // RVA: 0x606FE90
        public void .ctor(){} // RVA: 0x2DEE30
        public void SetAttributeNode(){} // RVA: 0x606FF10
        public void get_Attributes(){} // RVA: 0x6070010
        public void HasImplicitNamespaceAttribute(){} // RVA: 0x6070550
        public void AppendChild(){} // RVA: 0x60708C0
        public void get_Value(){} // RVA: 0x6070930
        public void set_Value(){} // RVA: 0x6070960
        public void get_LocalName(){} // RVA: 0x6070A30
        public void get_NamespaceUri(){} // RVA: 0x6070A60
        public void GetPrefixOfNamespace(){} // RVA: 0x6070AA0
        public void get_IsEmpty(){} // RVA: 0x6070B00
    }

    public class XObjectWrapper
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void get_WrappedNode(){} // RVA: 0x2F8380
        public void get_NodeType(){} // RVA: 0x606FA00
        public void get_LocalName(){} // RVA: 0x519240
        public void get_ChildNodes(){} // RVA: 0x606FA20
        public void get_Attributes(){} // RVA: 0x606FA80
        public void get_ParentNode(){} // RVA: 0x519240
        public void get_Value(){} // RVA: 0x519240
        public void set_Value(){} // RVA: 0x606FAE0
        public void AppendChild(){} // RVA: 0x606FB20
        public void get_NamespaceUri(){} // RVA: 0x519240
    }

    public class XProcessingInstructionWrapper
    {
        // ── Methods ──
        public void get_ProcessingInstruction(){} // RVA: 0x606EBD0
        public void .ctor(){} // RVA: 0x2DEE30
        public void get_LocalName(){} // RVA: 0x606EC50
        public void get_Value(){} // RVA: 0x606EC70
        public void set_Value(){} // RVA: 0x606EC90
    }

    public class XTextWrapper
    {
        // ── Methods ──
        public void get_Text(){} // RVA: 0x606E7A0
        public void .ctor(){} // RVA: 0x2DEE30
        public void get_Value(){} // RVA: 0x606E820
        public void set_Value(){} // RVA: 0x606E840
        public void get_ParentNode(){} // RVA: 0x606E8C0
    }

    public class XmlDeclarationWrapper
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x606B270
        public void get_Version(){} // RVA: 0x408F310
        public void get_Encoding(){} // RVA: 0x606BF40
        public void set_Encoding(){} // RVA: 0x606BF60
        public void get_Standalone(){} // RVA: 0x606C020
        public void set_Standalone(){} // RVA: 0x606C040
    }

    public class XmlDocumentTypeWrapper
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x606B270
        public void get_Name(){} // RVA: 0x606C060
        public void get_System(){} // RVA: 0x606C020
        public void get_Public(){} // RVA: 0x606BF40
        public void get_InternalSubset(){} // RVA: 0x606C090
        public void get_LocalName(){} // RVA: 0x606C0B0
    }

    public class XmlDocumentWrapper
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x606B270
        public void CreateComment(){} // RVA: 0x606B320
        public void CreateTextNode(){} // RVA: 0x606B3F0
        public void CreateCDataSection(){} // RVA: 0x606B4C0
        public void CreateWhitespace(){} // RVA: 0x606B590
        public void CreateSignificantWhitespace(){} // RVA: 0x606B660
        public void CreateXmlDeclaration(){} // RVA: 0x606B730
        public void CreateXmlDocumentType(){} // RVA: 0x606B7E0
        public void CreateProcessingInstruction(){} // RVA: 0x606B8A0
        public void CreateElement(){} // RVA: 0x606BA00 | overloaded x2
        public void CreateAttribute(){} // RVA: 0x606BC00 | overloaded x2
        public void get_DocumentElement(){} // RVA: 0x606BD60
    }

    public class XmlElementWrapper
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x606B270
        public void SetAttributeNode(){} // RVA: 0x606BDF0
        public void GetPrefixOfNamespace(){} // RVA: 0x606BEF0
        public void get_IsEmpty(){} // RVA: 0x606BF20
    }

    public class XmlNodeConverter
    {
        // ── Methods ──
        public void get_DeserializeRootElementName(){} // RVA: 0x2F8380
        public void set_DeserializeRootElementName(){} // RVA: 0x2DEE30
        public void get_WriteArrayAttribute(){} // RVA: 0x2F84E0
        public void set_WriteArrayAttribute(){} // RVA: 0x2F84F0
        public void get_OmitRootObject(){} // RVA: 0x6B93D0
        public void set_OmitRootObject(){} // RVA: 0xF43D70
        public void get_EncodeSpecialCharacters(){} // RVA: 0x1B98340
        public void set_EncodeSpecialCharacters(){} // RVA: 0x1B98210
        public void WriteJson(){} // RVA: 0x6070B30
        public void WrapXml(){} // RVA: 0x6070D80
        public void PushParentNamespaces(){} // RVA: 0x6070ED0
        public void ResolveFullName(){} // RVA: 0x60714A0
        public void GetPropertyName(){} // RVA: 0x60716C0
        public void IsArray(){} // RVA: 0x6071AD0
        public void SerializeGroupedNodes(){} // RVA: 0x6071D80
        public void WriteGroupedNodes(){} // RVA: 0x60727B0 | overloaded x2
        public void SerializeNode(){} // RVA: 0x60728A0
        public void AllSameName(){} // RVA: 0x6073800
        public void ReadJson(){} // RVA: 0x60739F0
        public void DeserializeValue(){} // RVA: 0x6074220
        public void ReadElement(){} // RVA: 0x60746C0
        public void CreateElement(){} // RVA: 0x6077370 | overloaded x2
        public void AddAttribute(){} // RVA: 0x60751B0
        public void ConvertTokenToXmlValue(){} // RVA: 0x6075430
        public void ReadArrayElements(){} // RVA: 0x6075CE0
        public void AddJsonArrayAttribute(){} // RVA: 0x6076010
        public void ShouldReadInto(){} // RVA: 0x60761B0
        public void ReadAttributeElements(){} // RVA: 0x6076240
        public void CreateInstruction(){} // RVA: 0x6076A50
        public void CreateDocumentType(){} // RVA: 0x6076ED0
        public void DeserializeNode(){} // RVA: 0x6077530
        public void IsNamespaceAttribute(){} // RVA: 0x6077ED0
        public void ValueAttributes(){} // RVA: 0x6078120
        public void CanConvert(){} // RVA: 0x60783B0
        public void IsXObject(){} // RVA: 0x6078490
        public void IsXmlNode(){} // RVA: 0x6078570
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x6078650
    }

    public class XmlNodeWrapper
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void get_WrappedNode(){} // RVA: 0x2F8380
        public void get_NodeType(){} // RVA: 0x5D12EC0
        public void get_LocalName(){} // RVA: 0x606C0F0
        public void get_ChildNodes(){} // RVA: 0x606C120
        public void get_HasChildNodes(){} // RVA: 0x606C5C0
        public void WrapNode(){} // RVA: 0x606C5F0
        public void get_Attributes(){} // RVA: 0x606C820
        public void get_HasAttributes(){} // RVA: 0x606CD50
        public void get_ParentNode(){} // RVA: 0x606CE30
        public void get_Value(){} // RVA: 0x606CEF0
        public void set_Value(){} // RVA: 0x606CF20
        public void AppendChild(){} // RVA: 0x606CF50
        public void get_NamespaceUri(){} // RVA: 0x606D0B0
    }

}