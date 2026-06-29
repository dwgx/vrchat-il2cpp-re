// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Newtonsoft.Newtonsoft.Json.Converters
// Classes: 38
// Methods: 307

namespace ThirdParty.Newtonsoft.Newtonsoft.Json.Converters
{
    public class BinaryConverter : JsonConverter
    {
        // ── Methods ──
        public void WriteJson(){} // RVA: 0x7ADE4C3A0
        public void GetByteArray(){} // RVA: 0x7ADE4C410
        public void EnsureReflectionObject(){} // RVA: 0x7ADE4C670
        public void ReadJson(){} // RVA: 0x7ADE4C880
        public void ReadByteArray(){} // RVA: 0x7ADE4CDD0
        public void CanConvert(){} // RVA: 0x7ADE4D050
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class BsonObjectIdConverter : JsonConverter
    {
        // ── Methods ──
        public void WriteJson(){} // RVA: 0x7ADE4D190
        public void ReadJson(){} // RVA: 0x7ADE4D380
        public void CanConvert(){} // RVA: 0x7ADE4D640
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class CustomCreationConverter`1 : JsonConverter
    {
        // ── Methods ──
        public void WriteJson(){} // RVA: 0x7A7E1DDC0
        public void ReadJson(){} // RVA: 0x7A7E12DE0
        public void Create(){} // RVA: 0x7A8051B10
        public void CanConvert(){} // RVA: 0x7A7E019D0
        public void get_CanWrite(){} // RVA: 0x7A7E01900
        public void .ctor(){} // RVA: 0x7A7E18770
    }

    public class DataSetConverter : JsonConverter
    {
        // ── Methods ──
        public void WriteJson(){} // RVA: 0x7ADE4D710
        public void ReadJson(){} // RVA: 0x7ADE4DB40
        public void CanConvert(){} // RVA: 0x7ADE4DED0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class DataTableConverter : JsonConverter
    {
        // ── Methods ──
        public void WriteJson(){} // RVA: 0x7ADE4DFB0
        public void ReadJson(){} // RVA: 0x7ADE4E550
        public void CreateRow(){} // RVA: 0x7ADE4E8D0
        public void GetColumnDataType(){} // RVA: 0x7ADE4EEA0
        public void CanConvert(){} // RVA: 0x7ADE4F0C0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class DateTimeConverterBase : JsonConverter
    {
        // ── Methods ──
        public void CanConvert(){} // RVA: 0x7ADE4F1A0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class DiscriminatedUnionConverter : JsonConverter
    {
        // ── Methods ──
        public void CreateUnionTypeLookup(){} // RVA: 0x7ADE4F330
        public void CreateUnion(){} // RVA: 0x7ADE4F590
        public void WriteJson(){} // RVA: 0x7ADE500E0
        public void ReadJson(){} // RVA: 0x7ADE506E0
        public void CanConvert(){} // RVA: 0x7ADE51160
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7ADE51470
    }

    public class EntityKeyMemberConverter : JsonConverter
    {
        // ── Methods ──
        public void WriteJson(){} // RVA: 0x7ADE51870
        public void ReadAndAssertProperty(){} // RVA: 0x7ADE51C30
        public void ReadJson(){} // RVA: 0x7ADE51E20
        public void EnsureReflectionObject(){} // RVA: 0x7ADE52200
        public void CanConvert(){} // RVA: 0x7ADE52350
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class ExpandoObjectConverter : JsonConverter
    {
        // ── Methods ──
        public void WriteJson(){} // RVA: 0x7A80D7310
        public void ReadJson(){} // RVA: 0x7ADE523B0
        public void ReadValue(){} // RVA: 0x7ADE523C0
        public void ReadList(){} // RVA: 0x7ADE526A0
        public void ReadObject(){} // RVA: 0x7ADE527E0
        public void CanConvert(){} // RVA: 0x7ADE52AC0
        public void get_CanWrite(){} // RVA: 0x7A80D7320
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class IXmlDeclaration
    {
        // ── Methods ──
        public void get_Version(){} // RVA: 0x7A7E00680
        public void get_Encoding(){} // RVA: 0x7A7E00680
        public void set_Encoding(){} // RVA: 0x7A7E18800
        public void get_Standalone(){} // RVA: 0x7A7E00680
        public void set_Standalone(){} // RVA: 0x7A7E18800
    }

    public class IXmlDocument
    {
        // ── Methods ──
        public void CreateComment(){} // RVA: 0x7A7E00B20
        public void CreateTextNode(){} // RVA: 0x7A7E00B20
        public void CreateCDataSection(){} // RVA: 0x7A7E00B20
        public void CreateWhitespace(){} // RVA: 0x7A7E00B20
        public void CreateSignificantWhitespace(){} // RVA: 0x7A7E00B20
        public void CreateXmlDeclaration(){} // RVA: 0x7A7E06710
        public void CreateXmlDocumentType(){} // RVA: 0x7A7E12DE0
        public void CreateProcessingInstruction(){} // RVA: 0x7A7E00BD0
        public void CreateElement(){} // RVA: 0x7A7E00BD0
        public void CreateAttribute(){} // RVA: 0x7A7E06710
        public void get_DocumentElement(){} // RVA: 0x7A7E00680
    }

    public class IXmlDocumentType
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7A7E00680
        public void get_System(){} // RVA: 0x7A7E00680
        public void get_Public(){} // RVA: 0x7A7E00680
        public void get_InternalSubset(){} // RVA: 0x7A7E00680
    }

    public class IXmlElement
    {
        // ── Methods ──
        public void SetAttributeNode(){} // RVA: 0x7A7E18800
        public void GetPrefixOfNamespace(){} // RVA: 0x7A7E00B20
        public void get_IsEmpty(){} // RVA: 0x7A7E01900
    }

    public class IXmlNode
    {
        // ── Methods ──
        public void get_NodeType(){} // RVA: 0x7A7E00710
        public void get_LocalName(){} // RVA: 0x7A7E00680
        public void get_ChildNodes(){} // RVA: 0x7A7E00680
        public void get_Attributes(){} // RVA: 0x7A7E00680
        public void get_ParentNode(){} // RVA: 0x7A7E00680
        public void get_Value(){} // RVA: 0x7A7E00680
        public void set_Value(){} // RVA: 0x7A7E18800
        public void AppendChild(){} // RVA: 0x7A7E00B20
        public void get_NamespaceUri(){} // RVA: 0x7A7E00680
        public void get_WrappedNode(){} // RVA: 0x7A7E00680
    }

    public class IXmlNode[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class IsoDateTimeConverter : DateTimeConverterBase
    {
        // ── Methods ──
        public void get_DateTimeStyles(){} // RVA: 0x7A8124910
        public void set_DateTimeStyles(){} // RVA: 0x7A80DA0C0
        public void get_DateTimeFormat(){} // RVA: 0x7ADE52B90
        public void set_DateTimeFormat(){} // RVA: 0x7ADE52BE0
        public void get_Culture(){} // RVA: 0x7ADE52C60
        public void set_Culture(){} // RVA: 0x7A81052D0
        public void WriteJson(){} // RVA: 0x7ADE52CF0
        public void ReadJson(){} // RVA: 0x7ADE53030
        public void .ctor(){} // RVA: 0x7ADE535E0
    }

    public class JavaScriptDateTimeConverter : DateTimeConverterBase
    {
        // ── Methods ──
        public void WriteJson(){} // RVA: 0x7ADE535F0
        public void ReadJson(){} // RVA: 0x7ADE53910
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class KeyValuePairConverter : JsonConverter
    {
        // ── Methods ──
        public void InitializeReflectionObject(){} // RVA: 0x7ADE53D40
        public void WriteJson(){} // RVA: 0x7ADE53F40
        public void ReadJson(){} // RVA: 0x7ADE542A0
        public void CanConvert(){} // RVA: 0x7ADE54930
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7ADE54A50
    }

    public class RegexConverter : JsonConverter
    {
        // ── Methods ──
        public void WriteJson(){} // RVA: 0x7ADE54EE0
        public void HasFlag(){} // RVA: 0x7ADB21900
        public void WriteBson(){} // RVA: 0x7ADE54DA0
        public void ReadJson(){} // RVA: 0x7ADE55100
        public void ReadRegexString(){} // RVA: 0x7ADE55300
        public void ReadRegexObject(){} // RVA: 0x7ADE55470
        public void CanConvert(){} // RVA: 0x7ADE55880
        public void IsRegex(){} // RVA: 0x7ADE55930
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class StringEnumConverter : JsonConverter
    {
        // ── Methods ──
        public void get_CamelCaseText(){} // RVA: 0x7ADE55B30
        public void set_CamelCaseText(){} // RVA: 0x7ADE55BA0
        public void get_NamingStrategy(){} // RVA: 0x7A80F2570
        public void set_NamingStrategy(){} // RVA: 0x7A80D8E20
        public void get_AllowIntegerValues(){} // RVA: 0x7A80F26D0
        public void set_AllowIntegerValues(){} // RVA: 0x7A80F26E0
        public void .ctor(){} // RVA: 0x7ADE55FB0
        public void WriteJson(){} // RVA: 0x7ADE560F0
        public void ReadJson(){} // RVA: 0x7ADE56300
        public void CanConvert(){} // RVA: 0x7ADE56780
    }

    public class UnixDateTimeConverter : DateTimeConverterBase
    {
        // ── Methods ──
        public void get_AllowPreEpoch(){} // RVA: 0x7A81A2200
        public void set_AllowPreEpoch(){} // RVA: 0x7A81A2210
        public void .ctor(){} // RVA: 0x7A81A2210
        public void WriteJson(){} // RVA: 0x7ADE56810
        public void ReadJson(){} // RVA: 0x7ADE56B80
        public void .cctor(){} // RVA: 0x7ADE57190
    }

    public class VersionConverter : JsonConverter
    {
        // ── Methods ──
        public void WriteJson(){} // RVA: 0x7ADE57210
        public void ReadJson(){} // RVA: 0x7ADE57310
        public void CanConvert(){} // RVA: 0x7ADE57570
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class XAttributeWrapper : XObjectWrapper
    {
        // ── Methods ──
        public void get_Attribute(){} // RVA: 0x7ADE5C1E0
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void get_Value(){} // RVA: 0x7ADE5C260
        public void set_Value(){} // RVA: 0x7ADE5C280
        public void get_LocalName(){} // RVA: 0x7ADE5C440
        public void get_NamespaceUri(){} // RVA: 0x7ADE5C470
        public void get_ParentNode(){} // RVA: 0x7ADE5C4B0
    }

    public class XCommentWrapper : XObjectWrapper
    {
        // ── Methods ──
        public void get_Text(){} // RVA: 0x7ADE5B010
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void get_Value(){} // RVA: 0x7ADE5B090
        public void set_Value(){} // RVA: 0x7ADE5B0B0
        public void get_ParentNode(){} // RVA: 0x7ADE5B260
    }

    public class XContainerWrapper : XObjectWrapper
    {
        // ── Methods ──
        public void get_Container(){} // RVA: 0x7ADE5B530
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void get_ChildNodes(){} // RVA: 0x7ADE5B5B0
        public void get_HasChildNodes(){} // RVA: 0x7ADE5BA00
        public void get_ParentNode(){} // RVA: 0x7ADE5BA30
        public void WrapNode(){} // RVA: 0x7ADE5BA90
        public void AppendChild(){} // RVA: 0x7ADE5BFA0
    }

    public class XDeclarationWrapper : XObjectWrapper
    {
        // ── Methods ──
        public void get_Declaration(){} // RVA: 0x7A80DA7B0
        public void .ctor(){} // RVA: 0x7ADE59430
        public void get_NodeType(){} // RVA: 0x7ADE594F0
        public void get_Version(){} // RVA: 0x7A8D68680
        public void get_Encoding(){} // RVA: 0x7ADE59500
        public void set_Encoding(){} // RVA: 0x7ADE59520
        public void get_Standalone(){} // RVA: 0x7A9A9B340
        public void set_Standalone(){} // RVA: 0x7ADE59590
    }

    public class XDocumentTypeWrapper : XObjectWrapper
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADD32890
        public void get_Name(){} // RVA: 0x7ADE59600
        public void get_System(){} // RVA: 0x7ADE59620
        public void get_Public(){} // RVA: 0x7ADE59640
        public void get_InternalSubset(){} // RVA: 0x7ADE59660
        public void get_LocalName(){} // RVA: 0x7ADE59680
    }

    public class XDocumentWrapper : XContainerWrapper
    {
        // ── Methods ──
        public void get_Document(){} // RVA: 0x7ADE596C0
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void get_ChildNodes(){} // RVA: 0x7ADE59740
        public void get_HasChildNodes(){} // RVA: 0x7ADE59890
        public void CreateComment(){} // RVA: 0x7ADE598E0
        public void CreateTextNode(){} // RVA: 0x7ADE59A40
        public void CreateCDataSection(){} // RVA: 0x7ADE59BA0
        public void CreateWhitespace(){} // RVA: 0x7ADE59D00
        public void CreateSignificantWhitespace(){} // RVA: 0x7ADE59E60
        public void CreateXmlDeclaration(){} // RVA: 0x7ADE59FC0
        public void CreateXmlDocumentType(){} // RVA: 0x7ADE5A070
        public void CreateProcessingInstruction(){} // RVA: 0x7ADE5A130
        public void CreateElement(){} // RVA: 0x7ADE5A3A0
        public void CreateAttribute(){} // RVA: 0x7ADE5A8F0
        public void get_DocumentElement(){} // RVA: 0x7ADE5ACC0
        public void AppendChild(){} // RVA: 0x7ADE5ADA0
    }

    public class XElementWrapper : XContainerWrapper
    {
        // ── Methods ──
        public void get_Element(){} // RVA: 0x7ADE5C510
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void SetAttributeNode(){} // RVA: 0x7ADE5C590
        public void get_Attributes(){} // RVA: 0x7ADE5C690
        public void HasImplicitNamespaceAttribute(){} // RVA: 0x7ADE5CBE0
        public void AppendChild(){} // RVA: 0x7ADE5CF50
        public void get_Value(){} // RVA: 0x7ADE5CFC0
        public void set_Value(){} // RVA: 0x7ADE5CFF0
        public void get_LocalName(){} // RVA: 0x7ADE5D0C0
        public void get_NamespaceUri(){} // RVA: 0x7ADE5D0F0
        public void GetPrefixOfNamespace(){} // RVA: 0x7ADE5D130
        public void get_IsEmpty(){} // RVA: 0x7ADE5D190
    }

    public class XObjectWrapper : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void get_WrappedNode(){} // RVA: 0x7A80F2570
        public void get_NodeType(){} // RVA: 0x7ADE5C080
        public void get_LocalName(){} // RVA: 0x7A82D1450
        public void get_ChildNodes(){} // RVA: 0x7ADE5C0A0
        public void get_Attributes(){} // RVA: 0x7ADE5C100
        public void get_ParentNode(){} // RVA: 0x7A82D1450
        public void get_Value(){} // RVA: 0x7A82D1450
        public void set_Value(){} // RVA: 0x7ADE5C160
        public void AppendChild(){} // RVA: 0x7ADE5C1A0
        public void get_NamespaceUri(){} // RVA: 0x7A82D1450
    }

    public class XProcessingInstructionWrapper : XObjectWrapper
    {
        // ── Methods ──
        public void get_ProcessingInstruction(){} // RVA: 0x7ADE5B2C0
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void get_LocalName(){} // RVA: 0x7ADE5B340
        public void get_Value(){} // RVA: 0x7ADE5B360
        public void set_Value(){} // RVA: 0x7ADE5B380
    }

    public class XTextWrapper : XObjectWrapper
    {
        // ── Methods ──
        public void get_Text(){} // RVA: 0x7ADE5AE90
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void get_Value(){} // RVA: 0x7ADE5AF10
        public void set_Value(){} // RVA: 0x7ADE5AF30
        public void get_ParentNode(){} // RVA: 0x7ADE5AFB0
    }

    public class XmlDeclarationWrapper : XmlNodeWrapper
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADE57640
        public void get_Version(){} // RVA: 0x7ABE84620
        public void get_Encoding(){} // RVA: 0x7ADE58310
        public void set_Encoding(){} // RVA: 0x7ADE58330
        public void get_Standalone(){} // RVA: 0x7ADE583F0
        public void set_Standalone(){} // RVA: 0x7ADE58410
    }

    public class XmlDocumentTypeWrapper : XmlNodeWrapper
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADE57640
        public void get_Name(){} // RVA: 0x7ADE58430
        public void get_System(){} // RVA: 0x7ADE583F0
        public void get_Public(){} // RVA: 0x7ADE58310
        public void get_InternalSubset(){} // RVA: 0x7ADE58460
        public void get_LocalName(){} // RVA: 0x7ADE58480
    }

    public class XmlDocumentWrapper : XmlNodeWrapper
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADE57640
        public void CreateComment(){} // RVA: 0x7ADE576F0
        public void CreateTextNode(){} // RVA: 0x7ADE577C0
        public void CreateCDataSection(){} // RVA: 0x7ADE57890
        public void CreateWhitespace(){} // RVA: 0x7ADE57960
        public void CreateSignificantWhitespace(){} // RVA: 0x7ADE57A30
        public void CreateXmlDeclaration(){} // RVA: 0x7ADE57B00
        public void CreateXmlDocumentType(){} // RVA: 0x7ADE57BB0
        public void CreateProcessingInstruction(){} // RVA: 0x7ADE57C70
        public void CreateElement(){} // RVA: 0x7ADE57DD0
        public void CreateAttribute(){} // RVA: 0x7ADE57FD0
        public void get_DocumentElement(){} // RVA: 0x7ADE58140
    }

    public class XmlElementWrapper : XmlNodeWrapper
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADE57640
        public void SetAttributeNode(){} // RVA: 0x7ADE581D0
        public void GetPrefixOfNamespace(){} // RVA: 0x7ADE582C0
        public void get_IsEmpty(){} // RVA: 0x7ADE582F0
    }

    public class XmlNodeConverter : JsonConverter
    {
        // ── Methods ──
        public void get_DeserializeRootElementName(){} // RVA: 0x7A80F2570
        public void set_DeserializeRootElementName(){} // RVA: 0x7A80D8E20
        public void get_WriteArrayAttribute(){} // RVA: 0x7A80F26D0
        public void set_WriteArrayAttribute(){} // RVA: 0x7A80F26E0
        public void get_OmitRootObject(){} // RVA: 0x7A8475E20
        public void set_OmitRootObject(){} // RVA: 0x7A8D0E640
        public void get_EncodeSpecialCharacters(){} // RVA: 0x7A9956320
        public void set_EncodeSpecialCharacters(){} // RVA: 0x7A99561F0
        public void WriteJson(){} // RVA: 0x7ADE5D1C0
        public void WrapXml(){} // RVA: 0x7ADE5D410
        public void PushParentNamespaces(){} // RVA: 0x7ADE5D530
        public void ResolveFullName(){} // RVA: 0x7ADE5DB00
        public void GetPropertyName(){} // RVA: 0x7ADE5DD20
        public void IsArray(){} // RVA: 0x7ADE5E130
        public void SerializeGroupedNodes(){} // RVA: 0x7ADE5E3E0
        public void WriteGroupedNodes(){} // RVA: 0x7ADE5EE70
        public void SerializeNode(){} // RVA: 0x7ADE5EF60
        public void AllSameName(){} // RVA: 0x7ADE5FEF0
        public void ReadJson(){} // RVA: 0x7ADE600F0
        public void DeserializeValue(){} // RVA: 0x7ADE60920
        public void ReadElement(){} // RVA: 0x7ADE60DC0
        public void CreateElement(){} // RVA: 0x7ADE63A80
        public void AddAttribute(){} // RVA: 0x7ADE618C0
        public void ConvertTokenToXmlValue(){} // RVA: 0x7ADE61B40
        public void ReadArrayElements(){} // RVA: 0x7ADE623F0
        public void AddJsonArrayAttribute(){} // RVA: 0x7ADE62720
        public void ShouldReadInto(){} // RVA: 0x7ADE628C0
        public void ReadAttributeElements(){} // RVA: 0x7ADE62950
        public void CreateInstruction(){} // RVA: 0x7ADE63160
        public void CreateDocumentType(){} // RVA: 0x7ADE635E0
        public void DeserializeNode(){} // RVA: 0x7ADE63C40
        public void IsNamespaceAttribute(){} // RVA: 0x7ADE64650
        public void ValueAttributes(){} // RVA: 0x7ADE648A0
        public void CanConvert(){} // RVA: 0x7ADE64B30
        public void IsXObject(){} // RVA: 0x7ADE64C10
        public void IsXmlNode(){} // RVA: 0x7ADE64CF0
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7ADE64DD0
    }

    public class XmlNodeWrapper : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void get_WrappedNode(){} // RVA: 0x7A80F2570
        public void get_NodeType(){} // RVA: 0x7ADB00ED0
        public void get_LocalName(){} // RVA: 0x7ADE584C0
        public void get_ChildNodes(){} // RVA: 0x7ADE584F0
        public void get_HasChildNodes(){} // RVA: 0x7ADE58970
        public void WrapNode(){} // RVA: 0x7ADE589A0
        public void get_Attributes(){} // RVA: 0x7ADE58BD0
        public void get_HasAttributes(){} // RVA: 0x7ADE590D0
        public void get_ParentNode(){} // RVA: 0x7ADE59190
        public void get_Value(){} // RVA: 0x7ADE59240
        public void set_Value(){} // RVA: 0x7ADE59270
        public void AppendChild(){} // RVA: 0x7ADE592A0
        public void get_NamespaceUri(){} // RVA: 0x7ADE59400
    }

}