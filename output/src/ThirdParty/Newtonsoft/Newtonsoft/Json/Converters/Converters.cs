// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Newtonsoft.Newtonsoft.Json.Converters
// Classes: 38
// Methods: 307

namespace ThirdParty.Newtonsoft.Newtonsoft.Json.Converters
{
    public class BinaryConverter : JsonConverter
    {
        public object BinaryTypeName;
        public object BinaryToArrayName;
        public object _reflectionObject;

        // ── Methods ──
        public void WriteJson(){} // RVA: 0x6AD3A40
        public void GetByteArray(){} // RVA: 0x6AD3AB0
        public void EnsureReflectionObject(){} // RVA: 0x6AD3D10
        public void ReadJson(){} // RVA: 0x6AD3F40
        public void ReadByteArray(){} // RVA: 0x6AD44B0
        public void CanConvert(){} // RVA: 0x6AD4730
        public void .ctor(){} // RVA: 0xB43310
    }

    public class BsonObjectIdConverter : JsonConverter
    {
        // ── Methods ──
        public void WriteJson(){} // RVA: 0x6AD48A0
        public void ReadJson(){} // RVA: 0x6AD4A90
        public void CanConvert(){} // RVA: 0x6AD4D50
        public void .ctor(){} // RVA: 0xB43310
    }

    public class CustomCreationConverter`1 : JsonConverter
    {
        // ── Methods ──
        public void WriteJson(){} // RVA: 0x8954D0
        public void ReadJson(){} // RVA: 0x88D2C0
        public void Create(){} // RVA: 0xA94080
        public void CanConvert(){} // RVA: 0x87D350
        public void get_CanWrite(){} // RVA: 0x87D280
        public void .ctor(){} // RVA: 0x894290
    }

    public class DataSetConverter : JsonConverter
    {
        // ── Methods ──
        public void WriteJson(){} // RVA: 0x6AD4DF0
        public void ReadJson(){} // RVA: 0x6AD5220
        public void CanConvert(){} // RVA: 0x6AD5590
        public void .ctor(){} // RVA: 0xB43310
    }

    public class DataTableConverter : JsonConverter
    {
        // ── Methods ──
        public void WriteJson(){} // RVA: 0x6AD5640
        public void ReadJson(){} // RVA: 0x6AD5BE0
        public void CreateRow(){} // RVA: 0x6AD5F70
        public void GetColumnDataType(){} // RVA: 0x6AD6520
        public void CanConvert(){} // RVA: 0x6AD6750
        public void .ctor(){} // RVA: 0xB43310
    }

    public class DateTimeConverterBase : JsonConverter
    {
        // ── Methods ──
        public void CanConvert(){} // RVA: 0x6AD6800
        public void .ctor(){} // RVA: 0xB43310
    }

    public class DiscriminatedUnionConverter : JsonConverter
    {
        public object CasePropertyName;
        public object FieldsPropertyName;
        public object UnionCache;
        public object UnionTypeLookupCache;

        // ── Methods ──
        public void CreateUnionTypeLookup(){} // RVA: 0x6AD69C0
        public void CreateUnion(){} // RVA: 0x6AD6C10
        public void WriteJson(){} // RVA: 0x6AD7740
        public void ReadJson(){} // RVA: 0x6AD7D30
        public void CanConvert(){} // RVA: 0x6AD87B0
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x6AD8A80
    }

    public class EntityKeyMemberConverter : JsonConverter
    {
        public object EntityKeyMemberFullTypeName;
        public object KeyPropertyName;
        public object TypePropertyName;
        public object ValuePropertyName;
        public object _reflectionObject;

        // ── Methods ──
        public void WriteJson(){} // RVA: 0x6AD8E80
        public void ReadAndAssertProperty(){} // RVA: 0x6AD9210
        public void ReadJson(){} // RVA: 0x6AD9400
        public void EnsureReflectionObject(){} // RVA: 0x6AD97C0
        public void CanConvert(){} // RVA: 0x6AD9910
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ExpandoObjectConverter : JsonConverter
    {
        // ── Methods ──
        public void WriteJson(){} // RVA: 0xB43310
        public void ReadJson(){} // RVA: 0x6AD9AB0
        public void ReadValue(){} // RVA: 0x6AD9AC0
        public void ReadList(){} // RVA: 0x6AD9DA0
        public void ReadObject(){} // RVA: 0x6AD9EE0
        public void CanConvert(){} // RVA: 0x6ADA1C0
        public void get_CanWrite(){} // RVA: 0xB43320
        public void .ctor(){} // RVA: 0xB43310
    }

    public class IXmlDeclaration
    {
        // ── Methods ──
        public void get_Version(){} // RVA: 0x87C0A0
        public void get_Encoding(){} // RVA: 0x87C0A0
        public void set_Encoding(){} // RVA: 0x894320
        public void get_Standalone(){} // RVA: 0x87C0A0
        public void set_Standalone(){} // RVA: 0x894320
    }

    public class IXmlDocument
    {
        // ── Methods ──
        public void CreateComment(){} // RVA: 0x87C540
        public void CreateTextNode(){} // RVA: 0x87C540
        public void CreateCDataSection(){} // RVA: 0x87C540
        public void CreateWhitespace(){} // RVA: 0x87C540
        public void CreateSignificantWhitespace(){} // RVA: 0x87C540
        public void CreateXmlDeclaration(){} // RVA: 0x882090
        public void CreateXmlDocumentType(){} // RVA: 0x88D2C0
        public void CreateProcessingInstruction(){} // RVA: 0x87C5F0
        public void CreateElement(){} // RVA: 0x87C5F0
        public void CreateAttribute(){} // RVA: 0x882090
        public void get_DocumentElement(){} // RVA: 0x87C0A0
    }

    public class IXmlDocumentType
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x87C0A0
        public void get_System(){} // RVA: 0x87C0A0
        public void get_Public(){} // RVA: 0x87C0A0
        public void get_InternalSubset(){} // RVA: 0x87C0A0
    }

    public class IXmlElement
    {
        // ── Methods ──
        public void SetAttributeNode(){} // RVA: 0x894320
        public void GetPrefixOfNamespace(){} // RVA: 0x87C540
        public void get_IsEmpty(){} // RVA: 0x87D280
    }

    public class IXmlNode
    {
        // ── Methods ──
        public void get_NodeType(){} // RVA: 0x87C130
        public void get_LocalName(){} // RVA: 0x87C0A0
        public void get_ChildNodes(){} // RVA: 0x87C0A0
        public void get_Attributes(){} // RVA: 0x87C0A0
        public void get_ParentNode(){} // RVA: 0x87C0A0
        public void get_Value(){} // RVA: 0x87C0A0
        public void set_Value(){} // RVA: 0x894320
        public void AppendChild(){} // RVA: 0x87C540
        public void get_NamespaceUri(){} // RVA: 0x87C0A0
        public void get_WrappedNode(){} // RVA: 0x87C0A0
    }

    public class IXmlNode[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class IsoDateTimeConverter : DateTimeConverterBase
    {
        public object DefaultDateTimeFormat;
        public object _dateTimeStyles;
        public object _dateTimeFormat;
        public object _culture;

        // ── Methods ──
        public void get_DateTimeStyles(){} // RVA: 0xB8F8F0
        public void set_DateTimeStyles(){} // RVA: 0xB460A0
        public void get_DateTimeFormat(){} // RVA: 0x67D9AC0
        public void set_DateTimeFormat(){} // RVA: 0x6ADA260
        public void get_Culture(){} // RVA: 0x6ADA2E0
        public void set_Culture(){} // RVA: 0xB70100
        public void WriteJson(){} // RVA: 0x6ADA370
        public void ReadJson(){} // RVA: 0x6ADA6B0
        public void .ctor(){} // RVA: 0x6ADAC80
    }

    public class JavaScriptDateTimeConverter : DateTimeConverterBase
    {
        // ── Methods ──
        public void WriteJson(){} // RVA: 0x6ADAC90
        public void ReadJson(){} // RVA: 0x6ADAFB0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class KeyValuePairConverter : JsonConverter
    {
        public object KeyName;
        public object ValueName;
        public object ReflectionObjectPerType;

        // ── Methods ──
        public void InitializeReflectionObject(){} // RVA: 0x6ADB3D0
        public void WriteJson(){} // RVA: 0x6ADB5D0
        public void ReadJson(){} // RVA: 0x6ADB930
        public void CanConvert(){} // RVA: 0x6ADBFC0
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x6ADC110
    }

    public class RegexConverter : JsonConverter
    {
        public object PatternName;
        public object OptionsName;

        // ── Methods ──
        public void WriteJson(){} // RVA: 0x6ADC5A0
        public void HasFlag(){} // RVA: 0x67AC200
        public void WriteBson(){} // RVA: 0x6ADC460
        public void ReadJson(){} // RVA: 0x6ADC7C0
        public void ReadRegexString(){} // RVA: 0x6ADC9B0
        public void ReadRegexObject(){} // RVA: 0x6ADCB10
        public void CanConvert(){} // RVA: 0x6ADCF10
        public void IsRegex(){} // RVA: 0x6ADCFC0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class StringEnumConverter : JsonConverter
    {
        public object _namingStrategy;
        public object _allowIntegerValues;

        // ── Methods ──
        public void get_CamelCaseText(){} // RVA: 0x6ADD190
        public void set_CamelCaseText(){} // RVA: 0x6ADD200
        public void get_NamingStrategy(){} // RVA: 0xB5DBF0
        public void set_NamingStrategy(){} // RVA: 0xB44D60
        public void get_AllowIntegerValues(){} // RVA: 0xB5DD50
        public void set_AllowIntegerValues(){} // RVA: 0xB5DD60
        public void .ctor(){} // RVA: 0x6ADD610
        public void WriteJson(){} // RVA: 0x6ADD750
        public void ReadJson(){} // RVA: 0x6ADD950
        public void CanConvert(){} // RVA: 0x6ADDDD0
    }

    public class UnixDateTimeConverter : DateTimeConverterBase
    {
        public object UnixEpoch;
        public object _allowPreEpoch;

        // ── Methods ──
        public void get_AllowPreEpoch(){} // RVA: 0xC120A0
        public void set_AllowPreEpoch(){} // RVA: 0xC120B0
        public void .ctor(){} // RVA: 0xC120B0
        public void WriteJson(){} // RVA: 0x6ADDE60
        public void ReadJson(){} // RVA: 0x6ADE1D0
        public void .cctor(){} // RVA: 0x6ADE7E0
    }

    public class VersionConverter : JsonConverter
    {
        // ── Methods ──
        public void WriteJson(){} // RVA: 0x6ADE860
        public void ReadJson(){} // RVA: 0x6ADE960
        public void CanConvert(){} // RVA: 0x6ADEBB0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class XAttributeWrapper : XObjectWrapper
    {
        // ── Methods ──
        public void get_Attribute(){} // RVA: 0x6AE3700
        public void .ctor(){} // RVA: 0xB44D60
        public void get_Value(){} // RVA: 0x6AE3780
        public void set_Value(){} // RVA: 0x6AE37A0
        public void get_LocalName(){} // RVA: 0x6AE3930
        public void get_NamespaceUri(){} // RVA: 0x6AE3960
        public void get_ParentNode(){} // RVA: 0x6AE39A0
    }

    public class XCommentWrapper : XObjectWrapper
    {
        // ── Methods ──
        public void get_Text(){} // RVA: 0x6AE2570
        public void .ctor(){} // RVA: 0xB44D60
        public void get_Value(){} // RVA: 0x6AE25F0
        public void set_Value(){} // RVA: 0x6AE2610
        public void get_ParentNode(){} // RVA: 0x6AE27A0
    }

    public class XContainerWrapper : XObjectWrapper
    {
        public object _childNodes;

        // ── Methods ──
        public void get_Container(){} // RVA: 0x6AE2A50
        public void .ctor(){} // RVA: 0xB44D60
        public void get_ChildNodes(){} // RVA: 0x6AE2AD0
        public void get_HasChildNodes(){} // RVA: 0x6AE2F20
        public void get_ParentNode(){} // RVA: 0x6AE2F50
        public void WrapNode(){} // RVA: 0x6AE2FB0
        public void AppendChild(){} // RVA: 0x6AE34C0
    }

    public class XDeclarationWrapper : XObjectWrapper
    {
        public object _declaration;

        // ── Methods ──
        public void get_Declaration(){} // RVA: 0xB465B0
        public void .ctor(){} // RVA: 0x6AE09C0
        public void get_NodeType(){} // RVA: 0x6AE0A80
        public void get_Version(){} // RVA: 0x1853320
        public void get_Encoding(){} // RVA: 0x6AE0A90
        public void set_Encoding(){} // RVA: 0x6AE0AB0
        public void get_Standalone(){} // RVA: 0x2547880
        public void set_Standalone(){} // RVA: 0x6AE0B20
    }

    public class XDocumentTypeWrapper : XObjectWrapper
    {
        public object _documentType;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x69BB630
        public void get_Name(){} // RVA: 0x6AE0B90
        public void get_System(){} // RVA: 0x6AE0BB0
        public void get_Public(){} // RVA: 0x6AE0BD0
        public void get_InternalSubset(){} // RVA: 0x6AE0BF0
        public void get_LocalName(){} // RVA: 0x6AE0C10
    }

    public class XDocumentWrapper : XContainerWrapper
    {
        // ── Methods ──
        public void get_Document(){} // RVA: 0x6AE0C50
        public void .ctor(){} // RVA: 0xB44D60
        public void get_ChildNodes(){} // RVA: 0x6AE0CD0
        public void get_HasChildNodes(){} // RVA: 0x6AE0E20
        public void CreateComment(){} // RVA: 0x6AE0E70
        public void CreateTextNode(){} // RVA: 0x6AE0FD0
        public void CreateCDataSection(){} // RVA: 0x6AE1130
        public void CreateWhitespace(){} // RVA: 0x6AE1290
        public void CreateSignificantWhitespace(){} // RVA: 0x6AE13F0
        public void CreateXmlDeclaration(){} // RVA: 0x6AE1550
        public void CreateXmlDocumentType(){} // RVA: 0x6AE1600
        public void CreateProcessingInstruction(){} // RVA: 0x6AE16C0
        public void CreateElement(){} // RVA: 0x6AE1930
        public void CreateAttribute(){} // RVA: 0x6AE1E80
        public void get_DocumentElement(){} // RVA: 0x6AE2250
        public void AppendChild(){} // RVA: 0x6AE2330
    }

    public class XElementWrapper : XContainerWrapper
    {
        public object _attributes;

        // ── Methods ──
        public void get_Element(){} // RVA: 0x6AE3A00
        public void .ctor(){} // RVA: 0xB44D60
        public void SetAttributeNode(){} // RVA: 0x6AE3A80
        public void get_Attributes(){} // RVA: 0x6AE3B80
        public void HasImplicitNamespaceAttribute(){} // RVA: 0x6AE40D0
        public void AppendChild(){} // RVA: 0x6AE4440
        public void get_Value(){} // RVA: 0x6AE44B0
        public void set_Value(){} // RVA: 0x6AE44E0
        public void get_LocalName(){} // RVA: 0x6AE4590
        public void get_NamespaceUri(){} // RVA: 0x6AE45C0
        public void GetPrefixOfNamespace(){} // RVA: 0x6AE4600
        public void get_IsEmpty(){} // RVA: 0x6AE4660
    }

    public class XObjectWrapper : Object
    {
        public object _xmlObject;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_WrappedNode(){} // RVA: 0xB5DBF0
        public void get_NodeType(){} // RVA: 0x6AE35A0
        public void get_LocalName(){} // RVA: 0xDAC980
        public void get_ChildNodes(){} // RVA: 0x6AE35C0
        public void get_Attributes(){} // RVA: 0x6AE3620
        public void get_ParentNode(){} // RVA: 0xDAC980
        public void get_Value(){} // RVA: 0xDAC980
        public void set_Value(){} // RVA: 0x6AE3680
        public void AppendChild(){} // RVA: 0x6AE36C0
        public void get_NamespaceUri(){} // RVA: 0xDAC980
    }

    public class XProcessingInstructionWrapper : XObjectWrapper
    {
        // ── Methods ──
        public void get_ProcessingInstruction(){} // RVA: 0x6AE2800
        public void .ctor(){} // RVA: 0xB44D60
        public void get_LocalName(){} // RVA: 0x6AE2880
        public void get_Value(){} // RVA: 0x6AE28A0
        public void set_Value(){} // RVA: 0x6AE28C0
    }

    public class XTextWrapper : XObjectWrapper
    {
        // ── Methods ──
        public void get_Text(){} // RVA: 0x6AE2420
        public void .ctor(){} // RVA: 0xB44D60
        public void get_Value(){} // RVA: 0x6AE24A0
        public void set_Value(){} // RVA: 0x6AE24C0
        public void get_ParentNode(){} // RVA: 0x6AE2510
    }

    public class XmlDeclarationWrapper : XmlNodeWrapper
    {
        public object _declaration;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6ADEC50
        public void get_Version(){} // RVA: 0x4B53220
        public void get_Encoding(){} // RVA: 0x6ADF8E0
        public void set_Encoding(){} // RVA: 0x6ADF900
        public void get_Standalone(){} // RVA: 0x6ADF980
        public void set_Standalone(){} // RVA: 0x6ADF9A0
    }

    public class XmlDocumentTypeWrapper : XmlNodeWrapper
    {
        public object _documentType;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6ADEC50
        public void get_Name(){} // RVA: 0x6ADF9C0
        public void get_System(){} // RVA: 0x6ADF980
        public void get_Public(){} // RVA: 0x6ADF8E0
        public void get_InternalSubset(){} // RVA: 0x6ADF9F0
        public void get_LocalName(){} // RVA: 0x6ADFA10
    }

    public class XmlDocumentWrapper : XmlNodeWrapper
    {
        public object _document;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6ADEC50
        public void CreateComment(){} // RVA: 0x6ADED00
        public void CreateTextNode(){} // RVA: 0x6ADEDD0
        public void CreateCDataSection(){} // RVA: 0x6ADEEA0
        public void CreateWhitespace(){} // RVA: 0x6ADEF70
        public void CreateSignificantWhitespace(){} // RVA: 0x6ADF040
        public void CreateXmlDeclaration(){} // RVA: 0x6ADF110
        public void CreateXmlDocumentType(){} // RVA: 0x6ADF1C0
        public void CreateProcessingInstruction(){} // RVA: 0x6ADF280
        public void CreateElement(){} // RVA: 0x6ADF3E0
        public void CreateAttribute(){} // RVA: 0x6ADF5C0
        public void get_DocumentElement(){} // RVA: 0x6ADF710
    }

    public class XmlElementWrapper : XmlNodeWrapper
    {
        public object _element;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6ADEC50
        public void SetAttributeNode(){} // RVA: 0x6ADF7A0
        public void GetPrefixOfNamespace(){} // RVA: 0x6ADF890
        public void get_IsEmpty(){} // RVA: 0x6ADF8C0
    }

    public class XmlNodeConverter : JsonConverter
    {
        public object EmptyChildNodes;
        public object TextName;
        public object CommentName;
        public object CDataName;
        public object WhitespaceName;
        public object SignificantWhitespaceName;
        public object DeclarationName;
        public object JsonNamespaceUri;
        public object _deserializeRootElementName;
        public object _writeArrayAttribute;
        public object _omitRootObject;
        public object _encodeSpecialCharacters;

        // ── Methods ──
        public void get_DeserializeRootElementName(){} // RVA: 0xB5DBF0
        public void set_DeserializeRootElementName(){} // RVA: 0xB44D60
        public void get_WriteArrayAttribute(){} // RVA: 0xB5DD50
        public void set_WriteArrayAttribute(){} // RVA: 0xB5DD60
        public void get_OmitRootObject(){} // RVA: 0xF43F30
        public void set_OmitRootObject(){} // RVA: 0x17F4D80
        public void get_EncodeSpecialCharacters(){} // RVA: 0x246FA20
        public void set_EncodeSpecialCharacters(){} // RVA: 0x246E8E0
        public void WriteJson(){} // RVA: 0x6AE4690
        public void WrapXml(){} // RVA: 0x6AE48E0
        public void PushParentNamespaces(){} // RVA: 0x6AE4A00
        public void ResolveFullName(){} // RVA: 0x6AE4FD0
        public void GetPropertyName(){} // RVA: 0x6AE51F0
        public void IsArray(){} // RVA: 0x6AE5600
        public void SerializeGroupedNodes(){} // RVA: 0x6AE58B0
        public void WriteGroupedNodes(){} // RVA: 0x6AE6340
        public void SerializeNode(){} // RVA: 0x6AE6430
        public void AllSameName(){} // RVA: 0x6AE73B0
        public void ReadJson(){} // RVA: 0x6AE75B0
        public void DeserializeValue(){} // RVA: 0x6AE7E60
        public void ReadElement(){} // RVA: 0x6AE8300
        public void CreateElement(){} // RVA: 0x6AEAFA0
        public void AddAttribute(){} // RVA: 0x6AE8DF0
        public void ConvertTokenToXmlValue(){} // RVA: 0x6AE9070
        public void ReadArrayElements(){} // RVA: 0x6AE9910
        public void AddJsonArrayAttribute(){} // RVA: 0x6AE9C40
        public void ShouldReadInto(){} // RVA: 0x6AE9DE0
        public void ReadAttributeElements(){} // RVA: 0x6AE9E70
        public void CreateInstruction(){} // RVA: 0x6AEA680
        public void CreateDocumentType(){} // RVA: 0x6AEAB00
        public void DeserializeNode(){} // RVA: 0x6AEB160
        public void IsNamespaceAttribute(){} // RVA: 0x6AEBB50
        public void ValueAttributes(){} // RVA: 0x6AEBD90
        public void CanConvert(){} // RVA: 0x6AEC020
        public void IsXObject(){} // RVA: 0x6AEC330
        public void IsXmlNode(){} // RVA: 0x6AEC3E0
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x6AEC490
    }

    public class XmlNodeWrapper : Object
    {
        public object _node;
        public object _childNodes;
        public object _attributes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_WrappedNode(){} // RVA: 0xB5DBF0
        public void get_NodeType(){} // RVA: 0x678C220
        public void get_LocalName(){} // RVA: 0x6ADFA50
        public void get_ChildNodes(){} // RVA: 0x6ADFA80
        public void get_HasChildNodes(){} // RVA: 0x6ADFF00
        public void WrapNode(){} // RVA: 0x6ADFF30
        public void get_Attributes(){} // RVA: 0x6AE0160
        public void get_HasAttributes(){} // RVA: 0x6AE0660
        public void get_ParentNode(){} // RVA: 0x6AE0720
        public void get_Value(){} // RVA: 0x6AE07D0
        public void set_Value(){} // RVA: 0x6AE0800
        public void AppendChild(){} // RVA: 0x6AE0830
        public void get_NamespaceUri(){} // RVA: 0x6AE0990
    }

}