// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Newtonsoft.Newtonsoft.Json.Converters
// Classes: 12
// Methods: 114

namespace ThirdParty.Newtonsoft.Newtonsoft.Json.Converters
{
    public class BinaryConverter : JsonConverter
    {
        public string BinaryTypeName;
        public string BinaryToArrayName;
        public Newtonsoft.Json.Utilities.ReflectionObject _reflectionObject;

        // ── Methods ──
        public void WriteJson(){} // RVA: 0x7FFD53C17670
        public void GetByteArray(){} // RVA: 0x7FFD53C176E0
        public void EnsureReflectionObject(){} // RVA: 0x7FFD53C17940
        public void ReadJson(){} // RVA: 0x7FFD53C17B50
        public void ReadByteArray(){} // RVA: 0x7FFD53C180A0
        public void CanConvert(){} // RVA: 0x7FFD53C18320
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class BsonObjectIdConverter : JsonConverter
    {
        // ── Methods ──
        public void WriteJson(){} // RVA: 0x7FFD53C18460
        public void ReadJson(){} // RVA: 0x7FFD53C18690
        public void CanConvert(){} // RVA: 0x7FFD53C18950
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class CustomCreationConverter`1 : JsonConverter
    {
        public object CanWrite;

        // ── Methods ──
        public void WriteJson(){} // RVA: 0x7FFD4E09AF60
        public void ReadJson(){} // RVA: 0x7FFD4E08B140
        public void Create(){} // RVA: 0x7FFD4E2ADC40
        public void CanConvert(){} // RVA: 0x7FFD4E079F60
        public void get_CanWrite(){} // RVA: 0x7FFD4E079D00
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class DataSetConverter : JsonConverter
    {
        // ── Methods ──
        public void WriteJson(){} // RVA: 0x7FFD53C18A20
        public void ReadJson(){} // RVA: 0x7FFD53C18E40
        public void CanConvert(){} // RVA: 0x7FFD53C191D0
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class DataTableConverter : JsonConverter
    {
        // ── Methods ──
        public void WriteJson(){} // RVA: 0x7FFD53C192B0
        public void ReadJson(){} // RVA: 0x7FFD53C19840
        public void CreateRow(){} // RVA: 0x7FFD53C19BD0
        public void GetColumnDataType(){} // RVA: 0x7FFD53C1A1B0
        public void CanConvert(){} // RVA: 0x7FFD53C1A3D0
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class DiscriminatedUnionConverter : JsonConverter
    {
        public string CasePropertyName;
        public string FieldsPropertyName;
        public Newtonsoft.Json.Utilities.ThreadSafeStore`2<System.Type,Union> UnionCache;
        public Newtonsoft.Json.Utilities.ThreadSafeStore`2<System.Type,System.Type> UnionTypeLookupCache; // 0x8

        // ── Methods ──
        public void CreateUnionTypeLookup(){} // RVA: 0x7FFD53C1A640
        public void CreateUnion(){} // RVA: 0x7FFD53C1A8A0
        public void WriteJson(){} // RVA: 0x7FFD53C1B3D0
        public void ReadJson(){} // RVA: 0x7FFD53C1B9D0
        public void CanConvert(){} // RVA: 0x7FFD53C1C440
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void .cctor(){} // RVA: 0x7FFD53C1C750
    }

    public class EntityKeyMemberConverter : JsonConverter
    {
        public string EntityKeyMemberFullTypeName;
        public string KeyPropertyName;
        public string TypePropertyName;
        public string ValuePropertyName;
        public Newtonsoft.Json.Utilities.ReflectionObject _reflectionObject;

        // ── Methods ──
        public void WriteJson(){} // RVA: 0x7FFD53C1CB50
        public void ReadAndAssertProperty(){} // RVA: 0x7FFD53C1CF10
        public void ReadJson(){} // RVA: 0x7FFD53C1D100
        public void EnsureReflectionObject(){} // RVA: 0x7FFD53C1D4E0
        public void CanConvert(){} // RVA: 0x7FFD53C1D630
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class ExpandoObjectConverter : JsonConverter
    {
        public object CanWrite;

        // ── Methods ──
        public void WriteJson(){} // RVA: 0x7FFD4E341310
        public void ReadJson(){} // RVA: 0x7FFD53C1D690
        public void ReadValue(){} // RVA: 0x7FFD53C1D6A0
        public void ReadList(){} // RVA: 0x7FFD53C1D980
        public void ReadObject(){} // RVA: 0x7FFD53C1DAC0
        public void CanConvert(){} // RVA: 0x7FFD53C1DD90
        public void get_CanWrite(){} // RVA: 0x7FFD4E341320
        public void .ctor(){} // RVA: 0x7FFD4E341310
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
        public void get_NodeType(){} // RVA: 0x7FFD4E079960
        public void get_LocalName(){} // RVA: 0x7FFD4E078E90
        public void get_ChildNodes(){} // RVA: 0x7FFD4E078E90
        public void get_Attributes(){} // RVA: 0x7FFD4E078E90
        public void get_ParentNode(){} // RVA: 0x7FFD4E078E90
        public void get_Value(){} // RVA: 0x7FFD4E078E90
        public void set_Value(){} // RVA: 0x7FFD4E090A40
        public void AppendChild(){} // RVA: 0x7FFD4E078F40
        public void get_NamespaceUri(){} // RVA: 0x7FFD4E078E90
        public void get_WrappedNode(){} // RVA: 0x7FFD4E078E90
    }

    public class KeyValuePairConverter : JsonConverter
    {
        public string KeyName;
        public string ValueName;
        public Newtonsoft.Json.Utilities.ThreadSafeStore`2<System.Type,Newtonsoft.Json.Utilities.ReflectionObject> ReflectionObjectPerType;

        // ── Methods ──
        public void InitializeReflectionObject(){} // RVA: 0x7FFD53C1F010
        public void WriteJson(){} // RVA: 0x7FFD53C1F210
        public void ReadJson(){} // RVA: 0x7FFD53C1F570
        public void CanConvert(){} // RVA: 0x7FFD53C1FC00
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void .cctor(){} // RVA: 0x7FFD53C1FD20
    }

    public class RegexConverter : JsonConverter
    {
        public string PatternName;
        public string OptionsName;

        // ── Methods ──
        public void WriteJson(){} // RVA: 0x7FFD53C201D0 | overloaded x2
        public void HasFlag(){} // RVA: 0x7FFD538EAD10
        public void WriteBson(){} // RVA: 0x7FFD53C1FF80
        public void ReadJson(){} // RVA: 0x7FFD53C203F0
        public void ReadRegexString(){} // RVA: 0x7FFD53C205F0
        public void ReadRegexObject(){} // RVA: 0x7FFD53C20760
        public void CanConvert(){} // RVA: 0x7FFD53C20B70
        public void IsRegex(){} // RVA: 0x7FFD53C20C20
        public void .ctor(){} // RVA: 0x7FFD4E341310
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
        public void get_DeserializeRootElementName(){} // RVA: 0x7FFD4E35C380
        public void set_DeserializeRootElementName(){} // RVA: 0x7FFD4E342E30
        public void get_WriteArrayAttribute(){} // RVA: 0x7FFD4E35C4E0
        public void set_WriteArrayAttribute(){} // RVA: 0x7FFD4E35C4F0
        public void get_OmitRootObject(){} // RVA: 0x7FFD4E648D50
        public void set_OmitRootObject(){} // RVA: 0x7FFD4E935120
        public void get_EncodeSpecialCharacters(){} // RVA: 0x7FFD4FA1A190
        public void set_EncodeSpecialCharacters(){} // RVA: 0x7FFD4FA19AE0
        public void WriteJson(){} // RVA: 0x7FFD53C281E0
        public void WrapXml(){} // RVA: 0x7FFD53C28430
        public void PushParentNamespaces(){} // RVA: 0x7FFD53C28580
        public void ResolveFullName(){} // RVA: 0x7FFD53C28B50
        public void GetPropertyName(){} // RVA: 0x7FFD53C28D70
        public void IsArray(){} // RVA: 0x7FFD53C29180
        public void SerializeGroupedNodes(){} // RVA: 0x7FFD53C29430
        public void WriteGroupedNodes(){} // RVA: 0x7FFD53C29E60 | overloaded x2
        public void SerializeNode(){} // RVA: 0x7FFD53C29F50
        public void AllSameName(){} // RVA: 0x7FFD53C2AEB0
        public void ReadJson(){} // RVA: 0x7FFD53C2B0A0
        public void DeserializeValue(){} // RVA: 0x7FFD53C2B8D0
        public void ReadElement(){} // RVA: 0x7FFD53C2BD70
        public void CreateElement(){} // RVA: 0x7FFD53C2EA20 | overloaded x2
        public void AddAttribute(){} // RVA: 0x7FFD53C2C860
        public void ConvertTokenToXmlValue(){} // RVA: 0x7FFD53C2CAE0
        public void ReadArrayElements(){} // RVA: 0x7FFD53C2D390
        public void AddJsonArrayAttribute(){} // RVA: 0x7FFD53C2D6C0
        public void ShouldReadInto(){} // RVA: 0x7FFD53C2D860
        public void ReadAttributeElements(){} // RVA: 0x7FFD53C2D8F0
        public void CreateInstruction(){} // RVA: 0x7FFD53C2E100
        public void CreateDocumentType(){} // RVA: 0x7FFD53C2E580
        public void DeserializeNode(){} // RVA: 0x7FFD53C2EBE0
        public void IsNamespaceAttribute(){} // RVA: 0x7FFD53C2F580
        public void ValueAttributes(){} // RVA: 0x7FFD53C2F7D0
        public void CanConvert(){} // RVA: 0x7FFD53C2FA60
        public void IsXObject(){} // RVA: 0x7FFD53C2FB40
        public void IsXmlNode(){} // RVA: 0x7FFD53C2FC20
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void .cctor(){} // RVA: 0x7FFD53C2FD00
    }

}