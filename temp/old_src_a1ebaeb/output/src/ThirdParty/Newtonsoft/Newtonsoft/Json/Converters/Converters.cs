// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Newtonsoft.Newtonsoft.Json.Converters
// Classes: 12
// Methods: 114

namespace ThirdParty.Newtonsoft.Newtonsoft.Json.Converters
{
    public class BinaryConverter : JsonConverter
    {
        public object _reflectionObject; // 0x300A7580

        // ── Original Methods ──
        public void WriteJson(){} // RVA: 0x7ffaae218880
        public void EnsureReflectionObject(){} // RVA: 0x7ffaae218b50
        public void ReadJson(){} // RVA: 0x7ffaae218d60
        public void ReadByteArray(){} // RVA: 0x7ffaae2192b0
        public void CanConvert(){} // RVA: 0x7ffaae219530
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetByteArray(){} // RVA: 0x7ffaae2188f0
    }

    public class BsonObjectIdConverter : JsonConverter
    {
        // ── Original Methods ──
        public void WriteJson(){} // RVA: 0x7ffaae219670
        public void ReadJson(){} // RVA: 0x7ffaae2198a0
        public void CanConvert(){} // RVA: 0x7ffaae219b60
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class CustomCreationConverter`1 : JsonConverter
    {
        // ── Original Methods ──
        public void WriteJson(){} // RVA: 0x7ffaa866b2a0
        public void ReadJson(){} // RVA: 0x7ffaa865b480
        public void Create(){} // RVA: 0x7ffaa887e5c0
        public void CanConvert(){} // RVA: 0x7ffaa864a2a0
        public void get_CanWrite(){} // RVA: 0x7ffaa864a040
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
    }

    public class DataSetConverter : JsonConverter
    {
        // ── Original Methods ──
        public void WriteJson(){} // RVA: 0x7ffaae219c30
        public void ReadJson(){} // RVA: 0x7ffaae21a050
        public void CanConvert(){} // RVA: 0x7ffaae21a3e0
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class DataTableConverter : JsonConverter
    {
        // ── Original Methods ──
        public void WriteJson(){} // RVA: 0x7ffaae21a4c0
        public void ReadJson(){} // RVA: 0x7ffaae21aa50
        public void CreateRow(){} // RVA: 0x7ffaae21ade0
        public void CanConvert(){} // RVA: 0x7ffaae21b5e0
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetColumnDataType(){} // RVA: 0x7ffaae21b3c0
    }

    public class DiscriminatedUnionConverter : JsonConverter
    {
        public object UnionCache; // 0x300A7CC0

        // ── Original Methods ──
        public void CreateUnionTypeLookup(){} // RVA: 0x7ffaae21b850
        public void CreateUnion(){} // RVA: 0x7ffaae21bab0
        public void WriteJson(){} // RVA: 0x7ffaae21c5e0
        public void ReadJson(){} // RVA: 0x7ffaae21cbe0
        public void CanConvert(){} // RVA: 0x7ffaae21d650
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void .cctor(){} // RVA: 0x7ffaae21d960
    }

    public class EntityKeyMemberConverter : JsonConverter
    {
        public object TypePropertyName; // 0x354E8630

        // ── Original Methods ──
        public void WriteJson(){} // RVA: 0x7ffaae21dd60
        public void ReadAndAssertProperty(){} // RVA: 0x7ffaae21e120
        public void ReadJson(){} // RVA: 0x7ffaae21e310
        public void EnsureReflectionObject(){} // RVA: 0x7ffaae21e6f0
        public void CanConvert(){} // RVA: 0x7ffaae21e840
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class ExpandoObjectConverter : JsonConverter
    {
        // ── Original Methods ──
        public void WriteJson(){} // RVA: 0x7ffaa8932310
        public void ReadJson(){} // RVA: 0x7ffaae21e8a0
        public void ReadValue(){} // RVA: 0x7ffaae21e8b0
        public void ReadList(){} // RVA: 0x7ffaae21eb90
        public void ReadObject(){} // RVA: 0x7ffaae21ecd0
        public void CanConvert(){} // RVA: 0x7ffaae21efa0
        public void get_CanWrite(){} // RVA: 0x7ffaa8932320
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class IXmlNode
    {
        // ── Original Methods ──
        public void get_NodeType(){} // RVA: 0x7ffaa8649ca0
        public void get_LocalName(){} // RVA: 0x7ffaa86491d0
        public void get_ChildNodes(){} // RVA: 0x7ffaa86491d0
        public void get_Attributes(){} // RVA: 0x7ffaa86491d0
        public void get_ParentNode(){} // RVA: 0x7ffaa86491d0
        public void get_Value(){} // RVA: 0x7ffaa86491d0
        public void set_Value(){} // RVA: 0x7ffaa8660d80
        public void AppendChild(){} // RVA: 0x7ffaa8649280
        public void get_NamespaceUri(){} // RVA: 0x7ffaa86491d0
        public void get_WrappedNode(){} // RVA: 0x7ffaa86491d0
    }

    public class KeyValuePairConverter : JsonConverter
    {
        public object ReflectionObjectPerType; // 0x354E89D0

        // ── Original Methods ──
        public void InitializeReflectionObject(){} // RVA: 0x7ffaae220220
        public void WriteJson(){} // RVA: 0x7ffaae220420
        public void ReadJson(){} // RVA: 0x7ffaae220780
        public void CanConvert(){} // RVA: 0x7ffaae220e10
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void .cctor(){} // RVA: 0x7ffaae220f30
    }

    public class RegexConverter : JsonConverter
    {
        // ── Original Methods ──
        public void WriteJson(){} // RVA: 0x7ffaae2213e0
        public void HasFlag(){} // RVA: 0x7ffaadeebe90
        public void WriteBson(){} // RVA: 0x7ffaae221190
        public void WriteJson(){} // RVA: 0x7ffaae2213e0
        public void ReadJson(){} // RVA: 0x7ffaae221600
        public void ReadRegexString(){} // RVA: 0x7ffaae221800
        public void ReadRegexObject(){} // RVA: 0x7ffaae221970
        public void CanConvert(){} // RVA: 0x7ffaae221d80
        public void IsRegex(){} // RVA: 0x7ffaae221e30
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class XmlNodeConverter : JsonConverter
    {
        public object CommentName; // 0x354E8D70
        public object SignificantWhitespaceName; // 0x354E8D70
        public object _deserializeRootElementName; // 0x354E8D70, was: <DeserializeRootElementName>k_
        public object _encodeSpecialCharacters; // 0x354E8D70, was: <EncodeSpecialCharacters>k__Ba
        public object DeserializeRootElementName; // 0x170002A8
        public object WriteArrayAttribute; // 0x170002A9
        public object OmitRootObject; // 0x170002AA
        public object EncodeSpecialCharacters; // 0x170002AB

        // ── Original Methods ──
        public void get_DeserializeRootElementName(){} // RVA: 0x7ffaa894d380
        public void set_DeserializeRootElementName(){} // RVA: 0x7ffaa8933e30
        public void get_WriteArrayAttribute(){} // RVA: 0x7ffaa894d4e0
        public void set_WriteArrayAttribute(){} // RVA: 0x7ffaa894d4f0
        public void get_OmitRootObject(){} // RVA: 0x7ffaa8c53420
        public void set_OmitRootObject(){} // RVA: 0x7ffaa8f41f20
        public void get_EncodeSpecialCharacters(){} // RVA: 0x7ffaaa01a540
        public void set_EncodeSpecialCharacters(){} // RVA: 0x7ffaaa01a550
        public void WriteJson(){} // RVA: 0x7ffaae2293f0
        public void WrapXml(){} // RVA: 0x7ffaae229640
        public void PushParentNamespaces(){} // RVA: 0x7ffaae229790
        public void ResolveFullName(){} // RVA: 0x7ffaae229d60
        public void IsArray(){} // RVA: 0x7ffaae22a390
        public void SerializeGroupedNodes(){} // RVA: 0x7ffaae22a640
        public void WriteGroupedNodes(){} // RVA: 0x7ffaae22b070
        public void WriteGroupedNodes(){} // RVA: 0x7ffaae22b070
        public void SerializeNode(){} // RVA: 0x7ffaae22b160
        public void AllSameName(){} // RVA: 0x7ffaae22c0c0
        public void ReadJson(){} // RVA: 0x7ffaae22c2b0
        public void DeserializeValue(){} // RVA: 0x7ffaae22cae0
        public void ReadElement(){} // RVA: 0x7ffaae22cf80
        public void CreateElement(){} // RVA: 0x7ffaae22fc30
        public void AddAttribute(){} // RVA: 0x7ffaae22da70
        public void ConvertTokenToXmlValue(){} // RVA: 0x7ffaae22dcf0
        public void ReadArrayElements(){} // RVA: 0x7ffaae22e5a0
        public void AddJsonArrayAttribute(){} // RVA: 0x7ffaae22e8d0
        public void ShouldReadInto(){} // RVA: 0x7ffaae22ea70
        public void ReadAttributeElements(){} // RVA: 0x7ffaae22eb00
        public void CreateInstruction(){} // RVA: 0x7ffaae22f310
        public void CreateDocumentType(){} // RVA: 0x7ffaae22f790
        public void CreateElement(){} // RVA: 0x7ffaae22fc30
        public void DeserializeNode(){} // RVA: 0x7ffaae22fdf0
        public void IsNamespaceAttribute(){} // RVA: 0x7ffaae230790
        public void ValueAttributes(){} // RVA: 0x7ffaae2309e0
        public void CanConvert(){} // RVA: 0x7ffaae230c70
        public void IsXObject(){} // RVA: 0x7ffaae230d50
        public void IsXmlNode(){} // RVA: 0x7ffaae230e30
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void .cctor(){} // RVA: 0x7ffaae230f10
        // ── Binary Analysis Named ──
        public void GetPropertyName(){} // RVA: 0x7ffaae229f80
    }

}