// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Newtonsoft.Newtonsoft.Json
// Classes: 41
// Methods: 879

namespace ThirdParty.Newtonsoft.Newtonsoft.Json
{
    public class DefaultJsonNameTable : JsonNameTable
    {
        public object HashCodeRandomizer;
        public object _count;
        public object _entries;
        public object _mask;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x69C93F0
        public void .ctor(){} // RVA: 0x69C9430
        public void Get(){} // RVA: 0x69C94D0
        public void Add(){} // RVA: 0x69C96E0
        public void AddEntry(){} // RVA: 0x69C9910
        public void Grow(){} // RVA: 0x69C9C40
        public void TextEquals(){} // RVA: 0x69C9DF0
    }

    public class IArrayPool`1
    {
        // ── Methods ──
        public void Rent(){} // RVA: 0x87C160
        public void Return(){} // RVA: 0x894320
    }

    public class IArrayPool`1
    {
        // ── Methods ──
        public void Rent(){} // RVA: 0x87C160
        public void Return(){} // RVA: 0x894320
    }

    public class IJsonLineInfo
    {
        // ── Methods ──
        public void HasLineInfo(){} // RVA: 0x87D280
        public void get_LineNumber(){} // RVA: 0x87C130
        public void get_LinePosition(){} // RVA: 0x87C130
    }

    public class JsonArrayAttribute : JsonContainerAttribute
    {
        public object _allowNullItems;

        // ── Methods ──
        public void get_AllowNullItems(){} // RVA: 0xC10030
        public void set_AllowNullItems(){} // RVA: 0xC10040
        public void .ctor(){} // RVA: 0xB44D60
    }

    public class JsonConstructorAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class JsonContainerAttribute : Attribute
    {
        public object _id;
        public object _title;
        public object _description;
        public object _itemConverterType;
        public object _itemConverterParameters;
        public object _namingStrategyInstance;
        public object _isReference;
        public object _itemIsReference;
        public object _itemReferenceLoopHandling;
        public object _itemTypeNameHandling;
        public object _namingStrategyType;
        public object _namingStrategyParameters;

        // ── Methods ──
        public void get_Id(){} // RVA: 0xB5DBF0
        public void set_Id(){} // RVA: 0xB44D60
        public void get_Title(){} // RVA: 0xB465B0
        public void set_Title(){} // RVA: 0xBA9BA0
        public void get_Description(){} // RVA: 0xB700F0
        public void set_Description(){} // RVA: 0xB70100
        public void get_ItemConverterType(){} // RVA: 0xB70160
        public void set_ItemConverterType(){} // RVA: 0xB44DC0
        public void get_ItemConverterParameters(){} // RVA: 0xD33E60
        public void set_ItemConverterParameters(){} // RVA: 0xB708C0
        public void get_NamingStrategyType(){} // RVA: 0xC0FFC0
        public void set_NamingStrategyType(){} // RVA: 0x69C9F60
        public void get_NamingStrategyParameters(){} // RVA: 0xBE2C60
        public void set_NamingStrategyParameters(){} // RVA: 0x69CA010
        public void get_NamingStrategyInstance(){} // RVA: 0xD05CA0
        public void set_NamingStrategyInstance(){} // RVA: 0xD09D70
        public void get_IsReference(){} // RVA: 0x69CA0C0
        public void set_IsReference(){} // RVA: 0x69CA100
        public void get_ItemIsReference(){} // RVA: 0x69CA150
        public void set_ItemIsReference(){} // RVA: 0x69CA190
        public void get_ItemReferenceLoopHandling(){} // RVA: 0x69CA1E0
        public void set_ItemReferenceLoopHandling(){} // RVA: 0x69CA220
        public void get_ItemTypeNameHandling(){} // RVA: 0x69CA280
        public void set_ItemTypeNameHandling(){} // RVA: 0x69CA2C0
        public void .ctor(){} // RVA: 0xB44D60
    }

    public class JsonContainerAttribute[] : Array
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

    public class JsonConvert : Object
    {
        public object _defaultSettings;
        public object True;
        public object False;
        public object Null;
        public object Undefined;
        public object PositiveInfinity;
        public object NegativeInfinity;
        public object NaN;

        // ── Methods ──
        public void DeserializeObject(){} // RVA: 0x31135C0
        public void get_DefaultSettings(){} // RVA: 0x69CA320
        public void set_DefaultSettings(){} // RVA: 0x69CA380
        public void ToString(){} // RVA: 0x69CC8E0
        public void ToStringInternal(){} // RVA: 0x69CB040
        public void EnsureFloatFormat(){} // RVA: 0x69CB520
        public void EnsureDecimalPlace(){} // RVA: 0x69CBA50
        public void SerializeObject(){} // RVA: 0x69CE1E0
        public void SerializeObjectInternal(){} // RVA: 0x69CE2B0
        public void DeserializeAnonymousType(){} // RVA: 0xA94080
        public void PopulateObject(){} // RVA: 0x69CEA30
        public void SerializeXmlNode(){} // RVA: 0x69CEE80
        public void DeserializeXmlNode(){} // RVA: 0x69CF190
        public void SerializeXNode(){} // RVA: 0x69CF660
        public void DeserializeXNode(){} // RVA: 0x69CF970
        public void .cctor(){} // RVA: 0x69CFBA0
    }

    public class JsonConverter : Object
    {
        // ── Methods ──
        public void WriteJson(){} // RVA: 0x8954D0
        public void ReadJson(){} // RVA: 0x88D2C0
        public void CanConvert(){} // RVA: 0x87D350
        public void get_CanRead(){} // RVA: 0xC2E4C0
        public void get_CanWrite(){} // RVA: 0xC2E4C0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class JsonConverterAttribute : Attribute
    {
        public object _converterType;
        public object _converterParameters;

        // ── Methods ──
        public void get_ConverterType(){} // RVA: 0xB5DBF0
        public void get_ConverterParameters(){} // RVA: 0xB465B0
        public void .ctor(){} // RVA: 0x69D0030
    }

    public class JsonConverterAttribute[] : Array
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

    public class JsonConverterCollection : Collection`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x69D0170
    }

    public class JsonConverter[] : Array
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

    public class JsonConverter`1 : JsonConverter
    {
        // ── Methods ──
        public void WriteJson(){} // RVA: 0xA94080
        public void ReadJson(){} // RVA: 0xA94080
        public void CanConvert(){} // RVA: 0x87D350
        public void .ctor(){} // RVA: 0x894290
    }

    public class JsonConverter`1 : JsonConverter
    {
        // ── Methods ──
        public void WriteJson(){} // RVA: 0x899E40
        public void ReadJson(){} // RVA: 0x8A39A0
        public void CanConvert(){} // RVA: 0x409F6E0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class JsonDictionaryAttribute : JsonContainerAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
    }

    public class JsonException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x69D02D0
        public void Create(){} // RVA: 0x69D0350
    }

    public class JsonExtensionDataAttribute : Attribute
    {
        public object _writeData;
        public object _readData;

        // ── Methods ──
        public void get_WriteData(){} // RVA: 0xC120A0
        public void set_WriteData(){} // RVA: 0xC120B0
        public void get_ReadData(){} // RVA: 0xDD5C50
        public void set_ReadData(){} // RVA: 0xDD7A00
        public void .ctor(){} // RVA: 0xE02D50
    }

    public class JsonExtensionDataAttribute[] : Array
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

    public class JsonIgnoreAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class JsonIgnoreAttribute[] : Array
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

    public class JsonNameTable : Object
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x87D1E0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class JsonObjectAttribute : JsonContainerAttribute
    {
        public object _memberSerialization;
        public object _missingMemberHandling;
        public object _itemRequired;
        public object _itemNullValueHandling;

        // ── Methods ──
        public void get_MemberSerialization(){} // RVA: 0x2536460
        public void set_MemberSerialization(){} // RVA: 0x25406E0
        public void get_MissingMemberHandling(){} // RVA: 0x69D0430
        public void set_MissingMemberHandling(){} // RVA: 0x69D0470
        public void get_ItemNullValueHandling(){} // RVA: 0x69D04D0
        public void set_ItemNullValueHandling(){} // RVA: 0x69D0520
        public void get_ItemRequired(){} // RVA: 0x69D0580
        public void set_ItemRequired(){} // RVA: 0x69D05C0
        public void .ctor(){} // RVA: 0xB44D60
    }

    public class JsonObjectAttribute[] : Array
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

    public class JsonPosition : ValueType
    {
        public object SpecialCharacters;
        public object Type;
        public object Position;
        public object PropertyName;
        public object HasIndex;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8C2F40
        public void CalculateLength(){} // RVA: 0x8C2F50
        public void WriteTo(){} // RVA: 0x8C2F60
        public void TypeHasIndex(){} // RVA: 0x69D09B0
        public void BuildPath(){} // RVA: 0x69D09C0
        public void FormatMessage(){} // RVA: 0x69D0FE0
        public void .cctor(){} // RVA: 0x69D1340
    }

    public class JsonPosition[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7DD60
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A7A0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC3EE0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E34170
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A7A0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class JsonPropertyAttribute : Attribute
    {
        public object _nullValueHandling;
        public object _defaultValueHandling;
        public object _referenceLoopHandling;
        public object _objectCreationHandling;
        public object _typeNameHandling;
        public object _isReference;
        public object _order;
        public object _required;
        public object _itemIsReference;
        public object _itemReferenceLoopHandling;
        public object _itemTypeNameHandling;
        public object _itemConverterType;
        public object _itemConverterParameters;
        public object _namingStrategyType;
        public object _namingStrategyParameters;
        public object _propertyName;

        // ── Methods ──
        public void get_ItemConverterType(){} // RVA: 0xBE2C60
        public void set_ItemConverterType(){} // RVA: 0xBE2C70
        public void get_ItemConverterParameters(){} // RVA: 0xBBFF90
        public void set_ItemConverterParameters(){} // RVA: 0xBBFFA0
        public void get_NamingStrategyType(){} // RVA: 0xC10050
        public void set_NamingStrategyType(){} // RVA: 0xC10060
        public void get_NamingStrategyParameters(){} // RVA: 0xCD3320
        public void set_NamingStrategyParameters(){} // RVA: 0xCD4740
        public void get_NullValueHandling(){} // RVA: 0x69D1420
        public void set_NullValueHandling(){} // RVA: 0x69D1460
        public void get_DefaultValueHandling(){} // RVA: 0x69D14C0
        public void set_DefaultValueHandling(){} // RVA: 0x69D1500
        public void get_ReferenceLoopHandling(){} // RVA: 0x69D1560
        public void set_ReferenceLoopHandling(){} // RVA: 0x69D15A0
        public void get_ObjectCreationHandling(){} // RVA: 0x69D1600
        public void set_ObjectCreationHandling(){} // RVA: 0x69D1640
        public void get_TypeNameHandling(){} // RVA: 0x69D16A0
        public void set_TypeNameHandling(){} // RVA: 0x69D16E0
        public void get_IsReference(){} // RVA: 0x69D1740
        public void set_IsReference(){} // RVA: 0x69D1780
        public void get_Order(){} // RVA: 0x69D17D0
        public void set_Order(){} // RVA: 0x69D1810
        public void get_Required(){} // RVA: 0x69D1870
        public void set_Required(){} // RVA: 0x69D18B0
        public void get_PropertyName(){} // RVA: 0xCD48B0
        public void set_PropertyName(){} // RVA: 0xCD3600
        public void get_ItemReferenceLoopHandling(){} // RVA: 0x69D1910
        public void set_ItemReferenceLoopHandling(){} // RVA: 0x69D1950
        public void get_ItemTypeNameHandling(){} // RVA: 0x69D19B0
        public void set_ItemTypeNameHandling(){} // RVA: 0x69D19F0
        public void get_ItemIsReference(){} // RVA: 0x69D1A50
        public void set_ItemIsReference(){} // RVA: 0x69D1A90
        public void .ctor(){} // RVA: 0xCD3600
    }

    public class JsonPropertyAttribute[] : Array
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

    public class JsonReader : Object
    {
        public object _tokenType;
        public object _value;
        public object _quoteChar;
        public object _currentState;
        public object _currentPosition;
        public object _culture;
        public object _dateTimeZoneHandling;
        public object _maxDepth;
        public object _hasExceededMaxDepth;
        public object _dateParseHandling;
        public object _floatParseHandling;
        public object _dateFormatString;
        public object _stack;
        public object _closeInput;
        public object _supportMultipleContent;

        // ── Methods ──
        public void ReadAsync(){} // RVA: 0x69D1AE0
        public void SkipAsync(){} // RVA: 0x69D1CA0
        public void ReaderReadAndAssertAsync(){} // RVA: 0x69D1EB0
        public void ReadAsBooleanAsync(){} // RVA: 0x69D20C0
        public void ReadAsBytesAsync(){} // RVA: 0x69D2260
        public void ReadArrayIntoByteArrayAsync(){} // RVA: 0x69D2370
        public void ReadAsDateTimeAsync(){} // RVA: 0x69D2560
        public void ReadAsDateTimeOffsetAsync(){} // RVA: 0x69D2770
        public void ReadAsDecimalAsync(){} // RVA: 0x69D2990
        public void ReadAsDoubleAsync(){} // RVA: 0x69D2BB0
        public void ReadAsInt32Async(){} // RVA: 0x69D2CE0
        public void ReadAsStringAsync(){} // RVA: 0x69D2E80
        public void ReadAndMoveToContentAsync(){} // RVA: 0x69D2F50
        public void MoveToContentAsync(){} // RVA: 0x69D3140
        public void MoveToContentFromNonContentAsync(){} // RVA: 0x69D31E0
        public void get_CurrentState(){} // RVA: 0x15AF000
        public void get_CloseInput(){} // RVA: 0xBC03E0
        public void set_CloseInput(){} // RVA: 0xBC03F0
        public void get_SupportMultipleContent(){} // RVA: 0x6529A10
        public void set_SupportMultipleContent(){} // RVA: 0x6529A20
        public void get_QuoteChar(){} // RVA: 0x4FEF950
        public void set_QuoteChar(){} // RVA: 0x653B850
        public void get_DateTimeZoneHandling(){} // RVA: 0xBE5890
        public void set_DateTimeZoneHandling(){} // RVA: 0x69D33D0
        public void get_DateParseHandling(){} // RVA: 0x12BB630
        public void set_DateParseHandling(){} // RVA: 0x69D3440
        public void get_FloatParseHandling(){} // RVA: 0xE36310
        public void set_FloatParseHandling(){} // RVA: 0x69D34B0
        public void get_DateFormatString(){} // RVA: 0xBE2C60
        public void set_DateFormatString(){} // RVA: 0xBE2C70
        public void get_MaxDepth(){} // RVA: 0x412F510
        public void set_MaxDepth(){} // RVA: 0x69D3520
        public void get_TokenType(){} // RVA: 0xB8F8F0
        public void get_Value(){} // RVA: 0xB465B0
        public void get_ValueType(){} // RVA: 0x69D35E0
        public void get_Depth(){} // RVA: 0x69D3600
        public void get_Path(){} // RVA: 0x69D3670
        public void get_Culture(){} // RVA: 0x69D37F0
        public void set_Culture(){} // RVA: 0xB6A8C0
        public void GetPosition(){} // RVA: 0x69D3850
        public void .ctor(){} // RVA: 0x69D3910
        public void Push(){} // RVA: 0x69D3980
        public void Pop(){} // RVA: 0x69D3CD0
        public void Peek(){} // RVA: 0x1065D50
        public void Read(){} // RVA: 0x87D280
        public void ReadAsInt32(){} // RVA: 0x69D3E90
        public void ReadInt32String(){} // RVA: 0x69D4240
        public void ReadAsString(){} // RVA: 0x69D44A0
        public void ReadAsBytes(){} // RVA: 0x69D46D0
        public void ReadArrayIntoByteArray(){} // RVA: 0x69D4B60
        public void ReadArrayElementIntoByteArrayReportDone(){} // RVA: 0x69D4C70
        public void ReadAsDouble(){} // RVA: 0x69D4E70
        public void ReadDoubleString(){} // RVA: 0x69D51A0
        public void ReadAsBoolean(){} // RVA: 0x69D53C0
        public void ReadBooleanString(){} // RVA: 0x69D57A0
        public void ReadAsDecimal(){} // RVA: 0x69D5A40
        public void ReadDecimalString(){} // RVA: 0x69D5E60
        public void ReadAsDateTime(){} // RVA: 0x69D61A0
        public void ReadDateTimeString(){} // RVA: 0x69D6480
        public void ReadAsDateTimeOffset(){} // RVA: 0x69D6700
        public void ReadDateTimeOffsetString(){} // RVA: 0x69D69C0
        public void ReaderReadAndAssert(){} // RVA: 0x69D6C50
        public void CreateUnexpectedEndException(){} // RVA: 0x69D6CA0
        public void ReadIntoWrappedTypeObject(){} // RVA: 0x69D6CF0
        public void Skip(){} // RVA: 0x69D70C0
        public void SetToken(){} // RVA: 0x69D71C0
        public void SetPostValueState(){} // RVA: 0x69D73F0
        public void UpdateScopeWithFinishedValue(){} // RVA: 0x69D7420
        public void ValidateEnd(){} // RVA: 0x69D7430
        public void SetStateBasedOnCurrent(){} // RVA: 0x69D75F0
        public void SetFinished(){} // RVA: 0x69D7700
        public void GetTypeForCloseToken(){} // RVA: 0x69D7720
        public void System.IDisposable.Dispose(){} // RVA: 0x69D7810
        public void Dispose(){} // RVA: 0x69D7880
        public void Close(){} // RVA: 0x69D78B0
        public void ReadAndAssert(){} // RVA: 0x69D7910
        public void ReadForTypeAndAssert(){} // RVA: 0x69D7970
        public void ReadForType(){} // RVA: 0x69D79C0
        public void ReadAndMoveToContent(){} // RVA: 0x69D7C70
        public void MoveToContent(){} // RVA: 0x69D7CD0
        public void GetContentToken(){} // RVA: 0x69D7D30
    }

    public class JsonReaderException : JsonException
    {
        public object _lineNumber;
        public object _linePosition;
        public object _path;

        // ── Methods ──
        public void get_LineNumber(){} // RVA: 0xF3A950
        public void get_LinePosition(){} // RVA: 0xF3A940
        public void get_Path(){} // RVA: 0x106A7D0
        public void .ctor(){} // RVA: 0x69D9540
        public void Create(){} // RVA: 0x69D97D0
    }

    public class JsonRequiredAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class JsonRequiredAttribute[] : Array
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

    public class JsonSerializationException : JsonException
    {
        public object _lineNumber;
        public object _linePosition;
        public object _path;

        // ── Methods ──
        public void get_LineNumber(){} // RVA: 0xF3A950
        public void get_LinePosition(){} // RVA: 0xF3A940
        public void get_Path(){} // RVA: 0x106A7D0
        public void .ctor(){} // RVA: 0x69D9540
        public void Create(){} // RVA: 0x69D9A90
    }

    public class JsonSerializer : Object
    {
        public object _typeNameHandling;
        public object _typeNameAssemblyFormatHandling;
        public object _preserveReferencesHandling;
        public object _referenceLoopHandling;
        public object _missingMemberHandling;
        public object _objectCreationHandling;
        public object _nullValueHandling;
        public object _defaultValueHandling;
        public object _constructorHandling;
        public object _metadataPropertyHandling;
        public object _converters;
        public object _contractResolver;
        public object _traceWriter;
        public object _equalityComparer;
        public object _serializationBinder;
        public object _context;
        public object _referenceResolver;
        public object _formatting;
        public object _dateFormatHandling;
        public object _dateTimeZoneHandling;
        public object _dateParseHandling;
        public object _floatFormatHandling;
        public object _floatParseHandling;
        public object _stringEscapeHandling;
        public object _culture;
        public object _maxDepth;
        public object _maxDepthSet;
        public object _checkAdditionalContent;
        public object _dateFormatString;
        public object _dateFormatStringSet;
        public object Error;

        // ── Methods ──
        public void add_Error(){} // RVA: 0x69D9C10
        public void remove_Error(){} // RVA: 0x69D9D30
        public void get_ReferenceResolver(){} // RVA: 0x69D9E50
        public void set_ReferenceResolver(){} // RVA: 0x69D9E60
        public void get_Binder(){} // RVA: 0x69D9F30
        public void set_Binder(){} // RVA: 0x69DA020
        public void get_SerializationBinder(){} // RVA: 0xC0FFC0
        public void set_SerializationBinder(){} // RVA: 0x69DA180
        public void get_TraceWriter(){} // RVA: 0xBBF8F0
        public void set_TraceWriter(){} // RVA: 0xBBF900
        public void get_EqualityComparer(){} // RVA: 0xBE58B0
        public void set_EqualityComparer(){} // RVA: 0xCA4DF0
        public void get_TypeNameHandling(){} // RVA: 0xB8F8F0
        public void set_TypeNameHandling(){} // RVA: 0x69DA250
        public void get_TypeNameAssemblyFormat(){} // RVA: 0x116A650
        public void set_TypeNameAssemblyFormat(){} // RVA: 0x69DA2C0
        public void get_TypeNameAssemblyFormatHandling(){} // RVA: 0x116A650
        public void set_TypeNameAssemblyFormatHandling(){} // RVA: 0x69DA330
        public void get_PreserveReferencesHandling(){} // RVA: 0xE62D00
        public void set_PreserveReferencesHandling(){} // RVA: 0x69DA3A0
        public void get_ReferenceLoopHandling(){} // RVA: 0x2244FB0
        public void set_ReferenceLoopHandling(){} // RVA: 0x69DA410
        public void get_MissingMemberHandling(){} // RVA: 0xFEAE90
        public void set_MissingMemberHandling(){} // RVA: 0x69DA480
        public void get_NullValueHandling(){} // RVA: 0x1065D50
        public void set_NullValueHandling(){} // RVA: 0x69DA4F0
        public void get_DefaultValueHandling(){} // RVA: 0x1AE5AC0
        public void set_DefaultValueHandling(){} // RVA: 0x69DA560
        public void get_ObjectCreationHandling(){} // RVA: 0x15AF000
        public void set_ObjectCreationHandling(){} // RVA: 0x69DA5D0
        public void get_ConstructorHandling(){} // RVA: 0xB9E080
        public void set_ConstructorHandling(){} // RVA: 0x69DA640
        public void get_MetadataPropertyHandling(){} // RVA: 0xE9CE60
        public void set_MetadataPropertyHandling(){} // RVA: 0x69DA6B0
        public void get_Converters(){} // RVA: 0x69DA720
        public void get_ContractResolver(){} // RVA: 0xBC1B30
        public void set_ContractResolver(){} // RVA: 0x69DA800
        public void get_Context(){} // RVA: 0x4127D80
        public void set_Context(){} // RVA: 0x69DA8C0
        public void get_Formatting(){} // RVA: 0x69DA920
        public void set_Formatting(){} // RVA: 0x69DA960
        public void get_DateFormatHandling(){} // RVA: 0x69DA9C0
        public void set_DateFormatHandling(){} // RVA: 0x69DAA10
        public void get_DateTimeZoneHandling(){} // RVA: 0x69DAA70
        public void set_DateTimeZoneHandling(){} // RVA: 0x69DAAD0
        public void get_DateParseHandling(){} // RVA: 0x69DAB30
        public void set_DateParseHandling(){} // RVA: 0x69DAB90
        public void get_FloatParseHandling(){} // RVA: 0x69DABF0
        public void set_FloatParseHandling(){} // RVA: 0x69DAC40
        public void get_FloatFormatHandling(){} // RVA: 0x69DACA0
        public void set_FloatFormatHandling(){} // RVA: 0x69DACF0
        public void get_StringEscapeHandling(){} // RVA: 0x69DAD50
        public void set_StringEscapeHandling(){} // RVA: 0x69DADA0
        public void get_DateFormatString(){} // RVA: 0x69DAE00
        public void set_DateFormatString(){} // RVA: 0x69DAE50
        public void get_Culture(){} // RVA: 0x69DAEC0
        public void set_Culture(){} // RVA: 0xBAE350
        public void get_MaxDepth(){} // RVA: 0xBAE3B0
        public void set_MaxDepth(){} // RVA: 0x69DAF30
        public void get_CheckAdditionalContent(){} // RVA: 0x69DB000
        public void set_CheckAdditionalContent(){} // RVA: 0x69DB050
        public void IsCheckAdditionalContentSet(){} // RVA: 0x69DB0B0
        public void .ctor(){} // RVA: 0x69DB100
        public void Create(){} // RVA: 0x69DB3F0
        public void CreateDefault(){} // RVA: 0x69DB560
        public void ApplySerializerSettings(){} // RVA: 0x69DB5A0
        public void Populate(){} // RVA: 0x69DC0C0
        public void PopulateInternal(){} // RVA: 0x69DC0E0
        public void Deserialize(){} // RVA: 0x69DC4B0
        public void DeserializeInternal(){} // RVA: 0x69DC4D0
        public void SetupReader(){} // RVA: 0x69DC7B0
        public void ResetReader(){} // RVA: 0x69DCD50
        public void Serialize(){} // RVA: 0x69DD180
        public void CreateTraceJsonReader(){} // RVA: 0x69DD1B0
        public void SerializeInternal(){} // RVA: 0x69DD270
        public void GetReferenceResolver(){} // RVA: 0x69DDA10
        public void GetMatchingConverter(){} // RVA: 0x69DDAC0
        public void OnError(){} // RVA: 0x69DDB90
    }

    public class JsonSerializerSettings : Object
    {
        public object DefaultReferenceLoopHandling;
        public object DefaultMissingMemberHandling;
        public object DefaultNullValueHandling;
        public object DefaultDefaultValueHandling;
        public object DefaultObjectCreationHandling;
        public object DefaultPreserveReferencesHandling;
        public object DefaultConstructorHandling;
        public object DefaultTypeNameHandling;
        public object DefaultMetadataPropertyHandling;
        public object DefaultContext;
        public object DefaultFormatting;
        public object DefaultDateFormatHandling;
        public object DefaultDateTimeZoneHandling;
        public object DefaultDateParseHandling;
        public object DefaultFloatParseHandling;
        public object DefaultFloatFormatHandling;
        public object DefaultStringEscapeHandling;
        public object DefaultTypeNameAssemblyFormatHandling;
        public object DefaultCulture;
        public object DefaultCheckAdditionalContent;
        public object DefaultDateFormatString;
        public object DefaultMaxDepth;
        public object _formatting;
        public object _dateFormatHandling;
        public object _dateTimeZoneHandling;
        public object _dateParseHandling;
        public object _floatFormatHandling;
        public object _floatParseHandling;
        public object _stringEscapeHandling;
        public object _culture;
        public object _checkAdditionalContent;
        public object _maxDepth;
        public object _maxDepthSet;
        public object _dateFormatString;
        public object _dateFormatStringSet;
        public object _typeNameAssemblyFormatHandling;
        public object _defaultValueHandling;
        public object _preserveReferencesHandling;
        public object _nullValueHandling;
        public object _objectCreationHandling;
        public object _missingMemberHandling;
        public object _referenceLoopHandling;
        public object _context;
        public object _constructorHandling;
        public object _typeNameHandling;
        public object _metadataPropertyHandling;
        public object _converters;
        public object _contractResolver;
        public object _equalityComparer;
        public object _referenceResolverProvider;
        public object _traceWriter;
        public object _serializationBinder;
        public object _error;

        // ── Methods ──
        public void get_ReferenceLoopHandling(){} // RVA: 0x69DDBC0
        public void set_ReferenceLoopHandling(){} // RVA: 0x69DDC10
        public void get_MissingMemberHandling(){} // RVA: 0x69DDC70
        public void set_MissingMemberHandling(){} // RVA: 0x69DDCC0
        public void get_ObjectCreationHandling(){} // RVA: 0x69DDD20
        public void set_ObjectCreationHandling(){} // RVA: 0x69DDD70
        public void get_NullValueHandling(){} // RVA: 0x69DDDD0
        public void set_NullValueHandling(){} // RVA: 0x69DDE20
        public void get_DefaultValueHandling(){} // RVA: 0x69DDE80
        public void set_DefaultValueHandling(){} // RVA: 0x69DDEC0
        public void get_Converters(){} // RVA: 0x135D730
        public void set_Converters(){} // RVA: 0xBC5AD0
        public void get_PreserveReferencesHandling(){} // RVA: 0x69DDF20
        public void set_PreserveReferencesHandling(){} // RVA: 0x69DDF70
        public void get_TypeNameHandling(){} // RVA: 0x69DDFD0
        public void set_TypeNameHandling(){} // RVA: 0x69DE020
        public void get_MetadataPropertyHandling(){} // RVA: 0x69DE080
        public void set_MetadataPropertyHandling(){} // RVA: 0x69DE0D0
        public void get_TypeNameAssemblyFormat(){} // RVA: 0x69DE130
        public void set_TypeNameAssemblyFormat(){} // RVA: 0x69DE170
        public void get_TypeNameAssemblyFormatHandling(){} // RVA: 0x69DE130
        public void set_TypeNameAssemblyFormatHandling(){} // RVA: 0x69DE170
        public void get_ConstructorHandling(){} // RVA: 0x69DE1D0
        public void set_ConstructorHandling(){} // RVA: 0x69DE220
        public void get_ContractResolver(){} // RVA: 0xBC5B30
        public void set_ContractResolver(){} // RVA: 0xBC5B40
        public void get_EqualityComparer(){} // RVA: 0xBC5BA0
        public void set_EqualityComparer(){} // RVA: 0xBC5BB0
        public void get_ReferenceResolver(){} // RVA: 0x69DE280
        public void set_ReferenceResolver(){} // RVA: 0x69DE2A0
        public void get_ReferenceResolverProvider(){} // RVA: 0xBAE5A0
        public void set_ReferenceResolverProvider(){} // RVA: 0xBAE5B0
        public void get_TraceWriter(){} // RVA: 0x135A7B0
        public void set_TraceWriter(){} // RVA: 0xEC0BB0
        public void get_Binder(){} // RVA: 0x69DE430
        public void set_Binder(){} // RVA: 0x69DE500
        public void get_SerializationBinder(){} // RVA: 0x10B4170
        public void set_SerializationBinder(){} // RVA: 0x15B42C0
        public void get_Error(){} // RVA: 0x10B9D50
        public void set_Error(){} // RVA: 0x15B7570
        public void get_Context(){} // RVA: 0x69DE620
        public void set_Context(){} // RVA: 0x69DE6F0
        public void get_DateFormatString(){} // RVA: 0x69DE810
        public void set_DateFormatString(){} // RVA: 0x69DE860
        public void get_MaxDepth(){} // RVA: 0x69DE8C0
        public void set_MaxDepth(){} // RVA: 0x69DE920
        public void get_Formatting(){} // RVA: 0x69DE9E0
        public void set_Formatting(){} // RVA: 0x69DEA20
        public void get_DateFormatHandling(){} // RVA: 0x69DEA80
        public void set_DateFormatHandling(){} // RVA: 0x69DEAC0
        public void get_DateTimeZoneHandling(){} // RVA: 0x69DEB20
        public void set_DateTimeZoneHandling(){} // RVA: 0x69DEB80
        public void get_DateParseHandling(){} // RVA: 0x69DEBE0
        public void set_DateParseHandling(){} // RVA: 0x69DEC40
        public void get_FloatFormatHandling(){} // RVA: 0x69DECA0
        public void set_FloatFormatHandling(){} // RVA: 0x69DECE0
        public void get_FloatParseHandling(){} // RVA: 0x69DED40
        public void set_FloatParseHandling(){} // RVA: 0x69DED80
        public void get_StringEscapeHandling(){} // RVA: 0x69DEDE0
        public void set_StringEscapeHandling(){} // RVA: 0x69DEE20
        public void get_Culture(){} // RVA: 0x69DEE80
        public void set_Culture(){} // RVA: 0xBBF900
        public void get_CheckAdditionalContent(){} // RVA: 0x69DEEF0
        public void set_CheckAdditionalContent(){} // RVA: 0x69DEF30
        public void .cctor(){} // RVA: 0x69DEF80
        public void .ctor(){} // RVA: 0x69DF160
    }

    public class JsonTextReader : JsonReader
    {
        public object _safeAsync;
        public object UnicodeReplacementChar;
        public object MaximumJavascriptIntegerCharacterLength;
        public object LargeBufferLength;
        public object _reader;
        public object _chars;
        public object _charsUsed;
        public object _charPos;
        public object _lineStartPos;
        public object _lineNumber;
        public object _isEndOfFile;
        public object _stringBuffer;
        public object _stringReference;
        public object _arrayPool;
        public object _propertyNameTable;

        // ── Methods ──
        public void ReadAsync(){} // RVA: 0x69DF6D0
        public void DoReadAsync(){} // RVA: 0x69DFBC0
        public void ParsePostValueAsync(){} // RVA: 0x69DFE10
        public void ReadFromFinishedAsync(){} // RVA: 0x69E0020
        public void ReadDataAsync(){} // RVA: 0x69E0230
        public void ParseValueAsync(){} // RVA: 0x69E0450
        public void ReadStringIntoBufferAsync(){} // RVA: 0x69E0650
        public void ProcessCarriageReturnAsync(){} // RVA: 0x69E09F0
        public void ParseUnicodeAsync(){} // RVA: 0x69E0C00
        public void EnsureCharsAsync(){} // RVA: 0x69E0DF0
        public void ReadCharsAsync(){} // RVA: 0x69E0EE0
        public void ParseObjectAsync(){} // RVA: 0x69E1100
        public void ParseCommentAsync(){} // RVA: 0x69E1300
        public void EatWhitespaceAsync(){} // RVA: 0x69E1550
        public void ParseStringAsync(){} // RVA: 0x69E1760
        public void MatchValueAsync(){} // RVA: 0x69E19A0
        public void MatchValueWithTrailingSeparatorAsync(){} // RVA: 0x69E1BF0
        public void MatchAndSetAsync(){} // RVA: 0x69E1E40
        public void ParseTrueAsync(){} // RVA: 0x69E2110
        public void ParseFalseAsync(){} // RVA: 0x69E21C0
        public void ParseNullAsync(){} // RVA: 0x69E2300
        public void ParseConstructorAsync(){} // RVA: 0x69E2390
        public void ParseNumberNaNAsync(){} // RVA: 0x69E25B0
        public void ParseNumberPositiveInfinityAsync(){} // RVA: 0x69E27B0
        public void ParseNumberNegativeInfinityAsync(){} // RVA: 0x69E29B0
        public void ParseNumberAsync(){} // RVA: 0x69E2BB0
        public void ParseUndefinedAsync(){} // RVA: 0x69E2DD0
        public void ParsePropertyAsync(){} // RVA: 0x69E2E60
        public void ReadNumberIntoBufferAsync(){} // RVA: 0x69E3050
        public void ParseUnquotedPropertyAsync(){} // RVA: 0x69E3260
        public void ReadNullCharAsync(){} // RVA: 0x69E3470
        public void HandleNullAsync(){} // RVA: 0x69E3660
        public void ReadFinishedAsync(){} // RVA: 0x69E3870
        public void ReadStringValueAsync(){} // RVA: 0x69E3A80
        public void ReadNumberValueAsync(){} // RVA: 0x69E3C90
        public void ReadAsBooleanAsync(){} // RVA: 0x69E3EA0
        public void DoReadAsBooleanAsync(){} // RVA: 0x69E3EC0
        public void ReadAsBytesAsync(){} // RVA: 0x69E40C0
        public void DoReadAsBytesAsync(){} // RVA: 0x69E41F0
        public void ReadIntoWrappedTypeObjectAsync(){} // RVA: 0x69E43F0
        public void ReadAsDateTimeAsync(){} // RVA: 0x69E4600
        public void DoReadAsDateTimeAsync(){} // RVA: 0x69E4620
        public void ReadAsDateTimeOffsetAsync(){} // RVA: 0x69E4810
        public void DoReadAsDateTimeOffsetAsync(){} // RVA: 0x69E4830
        public void ReadAsDecimalAsync(){} // RVA: 0x69E4A20
        public void DoReadAsDecimalAsync(){} // RVA: 0x69E4A40
        public void ReadAsDoubleAsync(){} // RVA: 0x69E4C30
        public void DoReadAsDoubleAsync(){} // RVA: 0x69E4D70
        public void ReadAsInt32Async(){} // RVA: 0x69E4F60
        public void DoReadAsInt32Async(){} // RVA: 0x69E4F80
        public void ReadAsStringAsync(){} // RVA: 0x69E5170
        public void DoReadAsStringAsync(){} // RVA: 0x69E5260
        public void .ctor(){} // RVA: 0x69E5450
        public void get_PropertyNameTable(){} // RVA: 0xC68EB0
        public void set_PropertyNameTable(){} // RVA: 0xC68EC0
        public void get_ArrayPool(){} // RVA: 0xCA4D80
        public void set_ArrayPool(){} // RVA: 0x69E5610
        public void EnsureBufferNotEmpty(){} // RVA: 0x69E56D0
        public void SetNewLine(){} // RVA: 0x69E5820
        public void OnNewLine(){} // RVA: 0x69E5880
        public void ParseString(){} // RVA: 0x69E5890
        public void ParseReadString(){} // RVA: 0x69E58F0
        public void BlockCopyChars(){} // RVA: 0x69E5CD0
        public void ShiftBufferIfNeeded(){} // RVA: 0x69E5CF0
        public void ReadData(){} // RVA: 0x69E6130
        public void PrepareBufferForReadData(){} // RVA: 0x69E5DE0
        public void EnsureChars(){} // RVA: 0x69E6200
        public void ReadChars(){} // RVA: 0x69E6350
        public void Read(){} // RVA: 0x69E6490
        public void ReadAsInt32(){} // RVA: 0x69E6760
        public void ReadAsDateTime(){} // RVA: 0x69E6850
        public void ReadAsString(){} // RVA: 0x69E6940
        public void ReadAsBytes(){} // RVA: 0x69E6980
        public void ReadStringValue(){} // RVA: 0x69E7100
        public void FinishReadQuotedStringValue(){} // RVA: 0x69E7B20
        public void CreateUnexpectedCharacterException(){} // RVA: 0x69E7DF0
        public void ReadAsBoolean(){} // RVA: 0x69E7EF0
        public void ProcessValueComma(){} // RVA: 0x69E87C0
        public void ReadNumberValue(){} // RVA: 0x69E8840
        public void FinishReadQuotedNumber(){} // RVA: 0x69E90B0
        public void ReadAsDateTimeOffset(){} // RVA: 0x69E9260
        public void ReadAsDecimal(){} // RVA: 0x69E9360
        public void ReadAsDouble(){} // RVA: 0x69E9460
        public void HandleNull(){} // RVA: 0x69E9550
        public void ReadFinished(){} // RVA: 0x69E9660
        public void ReadNullChar(){} // RVA: 0x69E97A0
        public void EnsureBuffer(){} // RVA: 0x69E97F0
        public void ReadStringIntoBuffer(){} // RVA: 0x69E9900
        public void FinishReadStringIntoBuffer(){} // RVA: 0x69E9EA0
        public void WriteCharToBuffer(){} // RVA: 0x69EA0D0
        public void ConvertUnicode(){} // RVA: 0x69EA180
        public void ParseUnicode(){} // RVA: 0x69EA3C0
        public void ReadNumberIntoBuffer(){} // RVA: 0x69EA3F0
        public void ReadNumberCharIntoBuffer(){} // RVA: 0x69EA490
        public void ClearRecentString(){} // RVA: 0x69EA620
        public void ParsePostValue(){} // RVA: 0x69EA640
        public void ParseObject(){} // RVA: 0x69EA9D0
        public void ParseProperty(){} // RVA: 0x69EABB0
        public void ValidIdentifierChar(){} // RVA: 0x69EB000
        public void ParseUnquotedProperty(){} // RVA: 0x69EB050
        public void ReadUnquotedPropertyReportIfDone(){} // RVA: 0x69EB200
        public void ParseValue(){} // RVA: 0x69EB400
        public void ProcessLineFeed(){} // RVA: 0x69EBBE0
        public void ProcessCarriageReturn(){} // RVA: 0x69EBC00
        public void EatWhitespace(){} // RVA: 0x69EBC70
        public void ParseConstructor(){} // RVA: 0x69EBDC0
        public void ParseNumber(){} // RVA: 0x69EC230
        public void ParseReadNumber(){} // RVA: 0x69EC330
        public void ThrowReaderError(){} // RVA: 0x69EDA90
        public void BigIntegerParse(){} // RVA: 0x69EDAF0
        public void ParseComment(){} // RVA: 0x69EDBD0
        public void EndComment(){} // RVA: 0x69EDF80
        public void MatchValue(){} // RVA: 0x69EE020
        public void MatchValueWithTrailingSeparator(){} // RVA: 0x69EE110
        public void IsSeparator(){} // RVA: 0x69EE1E0
        public void ParseTrue(){} // RVA: 0x69EE310
        public void ParseNull(){} // RVA: 0x69EE410
        public void ParseUndefined(){} // RVA: 0x69EE4D0
        public void ParseFalse(){} // RVA: 0x69EE590
        public void ParseNumberNegativeInfinity(){} // RVA: 0x69EE710
        public void ParseNumberPositiveInfinity(){} // RVA: 0x69EE940
        public void ParseNumberNaN(){} // RVA: 0x69EEB70
        public void Close(){} // RVA: 0x69EED20
        public void HasLineInfo(){} // RVA: 0xC2E4C0
        public void get_LineNumber(){} // RVA: 0x69EEEA0
        public void get_LinePosition(){} // RVA: 0x69EEEF0
    }

    public class JsonTextWriter : JsonWriter
    {
        public object _safeAsync;
        public object IndentCharBufferSize;
        public object _writer;
        public object _base64Encoder;
        public object _indentChar;
        public object _indentation;
        public object _quoteChar;
        public object _quoteName;
        public object _charEscapeFlags;
        public object _writeBuffer;
        public object _arrayPool;
        public object _indentChars;

        // ── Methods ──
        public void FlushAsync(){} // RVA: 0x6A02C80
        public void DoFlushAsync(){} // RVA: 0x6A02DE0
        public void WriteValueDelimiterAsync(){} // RVA: 0x6A02E70
        public void DoWriteValueDelimiterAsync(){} // RVA: 0x6A02FB0
        public void WriteEndAsync(){} // RVA: 0x6A03880
        public void DoWriteEndAsync(){} // RVA: 0x6A03280
        public void CloseAsync(){} // RVA: 0x6A033C0
        public void DoCloseAsync(){} // RVA: 0x6A034C0
        public void CloseBufferAndWriterAsync(){} // RVA: 0x6A036D0
        public void WriteIndentAsync(){} // RVA: 0x6A03DD0
        public void DoWriteIndentAsync(){} // RVA: 0x6A03CC0
        public void WriteValueInternalAsync(){} // RVA: 0x6A040F0
        public void WriteIndentSpaceAsync(){} // RVA: 0x6A043C0
        public void DoWriteIndentSpaceAsync(){} // RVA: 0x6A04500
        public void WriteRawAsync(){} // RVA: 0x6A04570
        public void DoWriteRawAsync(){} // RVA: 0x6A046D0
        public void WriteNullAsync(){} // RVA: 0x6A04750
        public void DoWriteNullAsync(){} // RVA: 0x6A048B0
        public void WriteDigitsAsync(){} // RVA: 0x6A04930
        public void WriteIntegerValueAsync(){} // RVA: 0x6A04DF0
        public void WriteEscapedStringAsync(){} // RVA: 0x6A04E10
        public void WritePropertyNameAsync(){} // RVA: 0x6A05580
        public void DoWritePropertyNameAsync(){} // RVA: 0x6A05690
        public void WriteStartArrayAsync(){} // RVA: 0x6A05920
        public void DoWriteStartArrayAsync(){} // RVA: 0x6A05BB0
        public void WriteStartObjectAsync(){} // RVA: 0x6A05E30
        public void DoWriteStartObjectAsync(){} // RVA: 0x6A060C0
        public void WriteStartConstructorAsync(){} // RVA: 0x6A06340
        public void DoWriteStartConstructorAsync(){} // RVA: 0x6A06450
        public void WriteUndefinedAsync(){} // RVA: 0x6A066D0
        public void DoWriteUndefinedAsync(){} // RVA: 0x6A069C0
        public void WriteWhitespaceAsync(){} // RVA: 0x6A06C40
        public void DoWriteWhitespaceAsync(){} // RVA: 0x6A06DA0
        public void WriteValueAsync(){} // RVA: 0x6A0C530
        public void DoWriteValueAsync(){} // RVA: 0x6A0C6B0
        public void WriteValueNonNullAsync(){} // RVA: 0x6A07640
        public void WriteValueNotNullAsync(){} // RVA: 0x6A0C140
        public void WriteCommentAsync(){} // RVA: 0x6A0C750
        public void DoWriteCommentAsync(){} // RVA: 0x6A0C860
        public void WriteEndArrayAsync(){} // RVA: 0x6A0CAE0
        public void WriteEndConstructorAsync(){} // RVA: 0x6A0CBE0
        public void WriteEndObjectAsync(){} // RVA: 0x6A0CCE0
        public void WriteRawValueAsync(){} // RVA: 0x6A0CDE0
        public void DoWriteRawValueAsync(){} // RVA: 0x6A0D080
        public void EnsureWriteBuffer(){} // RVA: 0x6A105A0
        public void get_Base64Encoder(){} // RVA: 0x6A0D650
        public void get_ArrayPool(){} // RVA: 0x106A7D0
        public void set_ArrayPool(){} // RVA: 0x6A0D850
        public void get_Indentation(){} // RVA: 0x23A4270
        public void set_Indentation(){} // RVA: 0x6A0D910
        public void get_QuoteChar(){} // RVA: 0x6A0D980
        public void set_QuoteChar(){} // RVA: 0x6A0D990
        public void get_IndentChar(){} // RVA: 0x6A0DA10
        public void set_IndentChar(){} // RVA: 0x6A0DA20
        public void get_QuoteName(){} // RVA: 0x1A177C0
        public void set_QuoteName(){} // RVA: 0x6A0DA90
        public void .ctor(){} // RVA: 0x6A0DAA0
        public void Flush(){} // RVA: 0x67AD130
        public void Close(){} // RVA: 0x6A0DC50
        public void CloseBufferAndWriter(){} // RVA: 0x6A0DD50
        public void WriteStartObject(){} // RVA: 0x6A0DE40
        public void WriteStartArray(){} // RVA: 0x6A0DEA0
        public void WriteStartConstructor(){} // RVA: 0x6A0DF00
        public void WriteEnd(){} // RVA: 0x6A0DFD0
        public void WritePropertyName(){} // RVA: 0x6A0E180
        public void OnStringEscapeHandlingChanged(){} // RVA: 0x6A0E2C0
        public void UpdateCharEscapeFlags(){} // RVA: 0x6A0E2D0
        public void WriteIndent(){} // RVA: 0x6A0E3A0
        public void SetIndentChars(){} // RVA: 0x6A0E510
        public void WriteValueDelimiter(){} // RVA: 0x6A0E710
        public void WriteIndentSpace(){} // RVA: 0x6A0E740
        public void WriteValueInternal(){} // RVA: 0x6A0E770
        public void WriteValue(){} // RVA: 0x6A10380
        public void WriteNull(){} // RVA: 0x6A0E8D0
        public void WriteUndefined(){} // RVA: 0x6A0E970
        public void WriteRaw(){} // RVA: 0x6A0E770
        public void WriteEscapedString(){} // RVA: 0x6A0EAE0
        public void WriteValueToBuffer(){} // RVA: 0x6A0FE40
        public void WriteComment(){} // RVA: 0x6A10480
        public void WriteWhitespace(){} // RVA: 0x6A10550
        public void WriteIntegerValue(){} // RVA: 0x6A10940
        public void WriteNumberToBuffer(){} // RVA: 0x6A109D0
    }

    public class JsonValidatingReader : JsonReader
    {
        public object _reader;
        public object _stack;
        public object _schema;
        public object _model;
        public object _currentScope;
        public object ValidationEventHandler;
        public object EmptySchemaList;

        // ── Methods ──
        public void add_ValidationEventHandler(){} // RVA: 0x6A18FA0
        public void remove_ValidationEventHandler(){} // RVA: 0x6A190A0
        public void get_Value(){} // RVA: 0x6A191A0
        public void get_Depth(){} // RVA: 0x6A191D0
        public void get_Path(){} // RVA: 0x6A19200
        public void get_QuoteChar(){} // RVA: 0x6A19230
        public void set_QuoteChar(){} // RVA: 0xB43310
        public void get_TokenType(){} // RVA: 0x6A19260
        public void get_ValueType(){} // RVA: 0x6A19290
        public void Push(){} // RVA: 0x6A192C0
        public void Pop(){} // RVA: 0x6A19380
        public void get_CurrentSchemas(){} // RVA: 0x6A19480
        public void get_CurrentMemberSchemas(){} // RVA: 0x6A194A0
        public void RaiseError(){} // RVA: 0x6A19F80
        public void OnValidationEvent(){} // RVA: 0x6A1A2D0
        public void .ctor(){} // RVA: 0x6A1A460
        public void get_Schema(){} // RVA: 0xB813B0
        public void set_Schema(){} // RVA: 0x6A1A640
        public void get_Reader(){} // RVA: 0xCD3320
        public void Close(){} // RVA: 0x6A1A780
        public void ValidateNotDisallowed(){} // RVA: 0x6A1A810
        public void GetCurrentNodeSchemaType(){} // RVA: 0x6A1AB30
        public void ReadAsInt32(){} // RVA: 0x6A1ACC0
        public void ReadAsBytes(){} // RVA: 0x6A1AD10
        public void ReadAsDecimal(){} // RVA: 0x6A1AD60
        public void ReadAsDouble(){} // RVA: 0x6A1ADC0
        public void ReadAsBoolean(){} // RVA: 0x6A1AE20
        public void ReadAsString(){} // RVA: 0x6A1AE70
        public void ReadAsDateTime(){} // RVA: 0x6A1AEC0
        public void ReadAsDateTimeOffset(){} // RVA: 0x6A1AF20
        public void Read(){} // RVA: 0x6A1AF80
        public void ValidateCurrentToken(){} // RVA: 0x6A1AFF0
        public void WriteToken(){} // RVA: 0x6A1BE60
        public void ValidateEndObject(){} // RVA: 0x6A1C870
        public void ValidateEndArray(){} // RVA: 0x6A1CC60
        public void ValidateNull(){} // RVA: 0x6A1CE70
        public void ValidateBoolean(){} // RVA: 0x6A1CEB0
        public void ValidateString(){} // RVA: 0x6A1CEF0
        public void ValidateInteger(){} // RVA: 0x6A1D2F0
        public void ProcessValue(){} // RVA: 0x6A1DB10
        public void ValidateFloat(){} // RVA: 0x6A1DE20
        public void FloatingPointRemainder(){} // RVA: 0x6A1E3F0
        public void IsZero(){} // RVA: 0x6A1E460
        public void ValidatePropertyName(){} // RVA: 0x6A1E4D0
        public void IsPropertyDefinied(){} // RVA: 0x6A1E730
        public void ValidateArray(){} // RVA: 0x6A1E950
        public void ValidateObject(){} // RVA: 0x6A1E970
        public void TestType(){} // RVA: 0x6A1E990
        public void Newtonsoft.Json.IJsonLineInfo.HasLineInfo(){} // RVA: 0x6A1EAE0
        public void Newtonsoft.Json.IJsonLineInfo.get_LineNumber(){} // RVA: 0x6A1EB40
        public void Newtonsoft.Json.IJsonLineInfo.get_LinePosition(){} // RVA: 0x6A1EBA0
        public void .cctor(){} // RVA: 0x6A1EC00
    }

    public class JsonWriter : Object
    {
        public object StateArray;
        public object StateArrayTemplate;
        public object _stack;
        public object _currentPosition;
        public object _currentState;
        public object _formatting;
        public object _closeOutput;
        public object _autoCompleteOnClose;
        public object _dateFormatHandling;
        public object _dateTimeZoneHandling;
        public object _stringEscapeHandling;
        public object _floatFormatHandling;
        public object _dateFormatString;
        public object _culture;

        // ── Methods ──
        public void AutoCompleteAsync(){} // RVA: 0x6A1FB80
        public void CloseAsync(){} // RVA: 0x6A1FD90
        public void FlushAsync(){} // RVA: 0x6A1FE70
        public void WriteEndAsync(){} // RVA: 0x6A203E0
        public void WriteIndentAsync(){} // RVA: 0x6A20040
        public void WriteValueDelimiterAsync(){} // RVA: 0x6A20120
        public void WriteIndentSpaceAsync(){} // RVA: 0x6A20200
        public void WriteRawAsync(){} // RVA: 0x6A202E0
        public void WriteEndInternalAsync(){} // RVA: 0x6A204C0
        public void InternalWriteEndAsync(){} // RVA: 0x6A20660
        public void WriteEndArrayAsync(){} // RVA: 0x6A208E0
        public void WriteEndConstructorAsync(){} // RVA: 0x6A209C0
        public void WriteEndObjectAsync(){} // RVA: 0x6A20AA0
        public void WriteNullAsync(){} // RVA: 0x6A20B80
        public void WritePropertyNameAsync(){} // RVA: 0x6A20D60
        public void InternalWritePropertyNameAsync(){} // RVA: 0x6A20E60
        public void WriteStartArrayAsync(){} // RVA: 0x6A20F80
        public void InternalWriteStartAsync(){} // RVA: 0x6A21060
        public void WriteCommentAsync(){} // RVA: 0x6A212A0
        public void InternalWriteCommentAsync(){} // RVA: 0x6A213A0
        public void WriteRawValueAsync(){} // RVA: 0x6A213B0
        public void WriteStartConstructorAsync(){} // RVA: 0x6A214B0
        public void WriteStartObjectAsync(){} // RVA: 0x6A215B0
        public void WriteTokenAsync(){} // RVA: 0x6A222E0
        public void WriteTokenSyncReadingAsync(){} // RVA: 0x6A22580
        public void WriteConstructorDateAsync(){} // RVA: 0x6A22800
        public void WriteValueAsync(){} // RVA: 0x6A255E0
        public void WriteUndefinedAsync(){} // RVA: 0x6A25060
        public void WriteWhitespaceAsync(){} // RVA: 0x6A25140
        public void InternalWriteValueAsync(){} // RVA: 0x6A25240
        public void SetWriteStateAsync(){} // RVA: 0x6A25310
        public void BuildStateArray(){} // RVA: 0x6A26A10
        public void .cctor(){} // RVA: 0x6A26CA0
        public void get_CloseOutput(){} // RVA: 0xD16660
        public void set_CloseOutput(){} // RVA: 0xD14C10
        public void get_AutoCompleteOnClose(){} // RVA: 0xD15320
        public void set_AutoCompleteOnClose(){} // RVA: 0xD14740
        public void get_Top(){} // RVA: 0x6A27030
        public void get_WriteState(){} // RVA: 0x6A27090
        public void get_ContainerPath(){} // RVA: 0x6A271B0
        public void get_Path(){} // RVA: 0x6A27240
        public void get_Formatting(){} // RVA: 0xE9CE60
        public void set_Formatting(){} // RVA: 0x6A273C0
        public void get_DateFormatHandling(){} // RVA: 0x114DAD0
        public void set_DateFormatHandling(){} // RVA: 0x6A27430
        public void get_DateTimeZoneHandling(){} // RVA: 0xBE5850
        public void set_DateTimeZoneHandling(){} // RVA: 0x6A274A0
        public void get_StringEscapeHandling(){} // RVA: 0xBE5870
        public void set_StringEscapeHandling(){} // RVA: 0x6A27510
        public void OnStringEscapeHandlingChanged(){} // RVA: 0xB43310
        public void get_FloatFormatHandling(){} // RVA: 0xBE5890
        public void set_FloatFormatHandling(){} // RVA: 0x6A27590
        public void get_DateFormatString(){} // RVA: 0xBE58B0
        public void set_DateFormatString(){} // RVA: 0xCA4DF0
        public void get_Culture(){} // RVA: 0x6A27600
        public void set_Culture(){} // RVA: 0xC0FFD0
        public void .ctor(){} // RVA: 0x6A27660
        public void UpdateScopeWithFinishedValue(){} // RVA: 0x6A27680
        public void Push(){} // RVA: 0x6A27690
        public void Pop(){} // RVA: 0x6A27840
        public void Peek(){} // RVA: 0xE62D00
        public void Flush(){} // RVA: 0x894290
        public void Close(){} // RVA: 0x6A279C0
        public void WriteStartObject(){} // RVA: 0x6A27A30
        public void WriteEndObject(){} // RVA: 0x6A27A70
        public void WriteStartArray(){} // RVA: 0x6A27A80
        public void WriteEndArray(){} // RVA: 0x6A27AC0
        public void WriteStartConstructor(){} // RVA: 0x6A27AD0
        public void WriteEndConstructor(){} // RVA: 0x6A27B10
        public void WritePropertyName(){} // RVA: 0x6A27B90
        public void WriteEnd(){} // RVA: 0xB43310
        public void WriteToken(){} // RVA: 0x6A28870
        public void IsWriteTokenIncomplete(){} // RVA: 0x6A28B50
        public void CalculateWriteTokenInitialDepth(){} // RVA: 0x6A28C20
        public void CalculateWriteTokenFinalDepth(){} // RVA: 0x6A28C90
        public void WriteConstructorDate(){} // RVA: 0x6A28D00
        public void AutoCompleteAll(){} // RVA: 0x6A28EB0
        public void GetCloseTokenForType(){} // RVA: 0x6A28F20
        public void AutoCompleteClose(){} // RVA: 0x6A28FE0
        public void CalculateLevelsToComplete(){} // RVA: 0x6A290A0
        public void UpdateCurrentState(){} // RVA: 0x6A291E0
        public void WriteIndent(){} // RVA: 0xB43310
        public void WriteValueDelimiter(){} // RVA: 0xB43310
        public void WriteIndentSpace(){} // RVA: 0xB43310
        public void AutoComplete(){} // RVA: 0x6A292B0
        public void WriteNull(){} // RVA: 0x6A294E0
        public void WriteUndefined(){} // RVA: 0x6A29500
        public void WriteRaw(){} // RVA: 0xB43310
        public void WriteRawValue(){} // RVA: 0x6A29520
        public void WriteValue(){} // RVA: 0x6A2A290
        public void WriteComment(){} // RVA: 0x6A2A1D0
        public void WriteWhitespace(){} // RVA: 0x6A2A1E0
        public void System.IDisposable.Dispose(){} // RVA: 0x6A2A1F0
        public void Dispose(){} // RVA: 0x6A2A260
        public void ResolveConvertibleValue(){} // RVA: 0x6A2B4C0
        public void CreateUnsupportedTypeException(){} // RVA: 0x6A2B720
        public void SetWriteState(){} // RVA: 0x6A2B820
        public void InternalWriteEnd(){} // RVA: 0x6A28FE0
        public void InternalWritePropertyName(){} // RVA: 0x6A27B20
        public void InternalWriteRaw(){} // RVA: 0xB43310
        public void InternalWriteStart(){} // RVA: 0x6A2BA60
        public void InternalWriteValue(){} // RVA: 0x6A2BAA0
        public void InternalWriteWhitespace(){} // RVA: 0x6A2BAC0
        public void InternalWriteComment(){} // RVA: 0x6A2A1D0
        public void <InternalWriteEndAsync>g__AwaitProperty|11_0(){} // RVA: 0x6A2BB90
        public void <InternalWriteEndAsync>g__AwaitIndent|11_1(){} // RVA: 0x6A2BE20
        public void <InternalWriteEndAsync>g__AwaitEnd|11_2(){} // RVA: 0x6A2C0C0
        public void <InternalWriteEndAsync>g__AwaitRemaining|11_3(){} // RVA: 0x6A2C340
    }

    public class JsonWriterException : JsonException
    {
        public object _path;

        // ── Methods ──
        public void get_Path(){} // RVA: 0x1069350
        public void .ctor(){} // RVA: 0x6A2FEF0
        public void Create(){} // RVA: 0x6A30090
    }

}