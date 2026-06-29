// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Newtonsoft.Newtonsoft.Json
// Classes: 41
// Methods: 880

namespace ThirdParty.Newtonsoft.Newtonsoft.Json
{
    public class DefaultJsonNameTable : JsonNameTable
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7ADD40630
        public void .ctor(){} // RVA: 0x7ADD40670
        public void Get(){} // RVA: 0x7ADD40710
        public void Add(){} // RVA: 0x7ADD40930
        public void AddEntry(){} // RVA: 0x7ADD40B70
        public void Grow(){} // RVA: 0x7ADD40EA0
        public void TextEquals(){} // RVA: 0x7ADD41050
    }

    public class IArrayPool`1
    {
        // ── Methods ──
        public void Rent(){} // RVA: 0x7A7E00740
        public void Return(){} // RVA: 0x7A7E18800
    }

    public class IArrayPool`1
    {
        // ── Methods ──
        public void Rent(){} // RVA: 0x7A7E00740
        public void Return(){} // RVA: 0x7A7E18800
    }

    public class IJsonLineInfo
    {
        // ── Methods ──
        public void HasLineInfo(){} // RVA: 0x7A7E01900
        public void get_LineNumber(){} // RVA: 0x7A7E00710
        public void get_LinePosition(){} // RVA: 0x7A7E00710
    }

    public class JsonArrayAttribute : JsonContainerAttribute
    {
        // ── Methods ──
        public void get_AllowNullItems(){} // RVA: 0x7A81A00C0
        public void set_AllowNullItems(){} // RVA: 0x7A81A00D0
        public void .ctor(){} // RVA: 0x7A80D8E20
    }

    public class JsonConstructorAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class JsonContainerAttribute : Attribute
    {
        // ── Methods ──
        public void get_Id(){} // RVA: 0x7A80F2570
        public void set_Id(){} // RVA: 0x7A80D8E20
        public void get_Title(){} // RVA: 0x7A80DA7B0
        public void set_Title(){} // RVA: 0x7A813E420
        public void get_Description(){} // RVA: 0x7A81052C0
        public void set_Description(){} // RVA: 0x7A81052D0
        public void get_ItemConverterType(){} // RVA: 0x7A8105330
        public void set_ItemConverterType(){} // RVA: 0x7A80D8E80
        public void get_ItemConverterParameters(){} // RVA: 0x7A83F69F0
        public void set_ItemConverterParameters(){} // RVA: 0x7A8105A90
        public void get_NamingStrategyType(){} // RVA: 0x7A81A0050
        public void set_NamingStrategyType(){} // RVA: 0x7ADD411C0
        public void get_NamingStrategyParameters(){} // RVA: 0x7A8175DF0
        public void set_NamingStrategyParameters(){} // RVA: 0x7ADD41270
        public void get_NamingStrategyInstance(){} // RVA: 0x7A8292C30
        public void set_NamingStrategyInstance(){} // RVA: 0x7A8296DE0
        public void get_IsReference(){} // RVA: 0x7ADD41320
        public void set_IsReference(){} // RVA: 0x7ADD41360
        public void get_ItemIsReference(){} // RVA: 0x7ADD413B0
        public void set_ItemIsReference(){} // RVA: 0x7ADD413F0
        public void get_ItemReferenceLoopHandling(){} // RVA: 0x7ADD41440
        public void set_ItemReferenceLoopHandling(){} // RVA: 0x7ADD41480
        public void get_ItemTypeNameHandling(){} // RVA: 0x7ADD414E0
        public void set_ItemTypeNameHandling(){} // RVA: 0x7ADD41520
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void <Id>k__BackingField(){} // RVA: 0x7B4223488
    }

    public class JsonContainerAttribute[] : Array
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

    public class JsonConvert : Object
    {
        // ── Methods ──
        public void get_DefaultSettings(){} // RVA: 0x7ADD41580
        public void set_DefaultSettings(){} // RVA: 0x7ADD415E0
        public void ToString(){} // RVA: 0x7ADD43C20
        public void ToStringInternal(){} // RVA: 0x7ADD422C0
        public void EnsureFloatFormat(){} // RVA: 0x7ADD427A0
        public void EnsureDecimalPlace(){} // RVA: 0x7ADD42D30
        public void SerializeObject(){} // RVA: 0x7ADD455C0
        public void SerializeObjectInternal(){} // RVA: 0x7ADD45690
        public void DeserializeObject(){} // RVA: 0x7AA4E3DC0
        public void DeserializeAnonymousType(){} // RVA: 0x7A8051B10
        public void PopulateObject(){} // RVA: 0x7ADD45E10
        public void SerializeXmlNode(){} // RVA: 0x7ADD46260
        public void DeserializeXmlNode(){} // RVA: 0x7ADD46570
        public void SerializeXNode(){} // RVA: 0x7ADD46A70
        public void DeserializeXNode(){} // RVA: 0x7ADD46D80
        public void .cctor(){} // RVA: 0x7ADD46FE0
    }

    public class JsonConverter : Object
    {
        // ── Methods ──
        public void WriteJson(){} // RVA: 0x7A7E1DDC0
        public void ReadJson(){} // RVA: 0x7A7E12DE0
        public void CanConvert(){} // RVA: 0x7A7E019D0
        public void get_CanRead(){} // RVA: 0x7A81BD750
        public void get_CanWrite(){} // RVA: 0x7A81BD750
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class JsonConverterAttribute : Attribute
    {
        // ── Methods ──
        public void get_ConverterType(){} // RVA: 0x7A80F2570
        public void get_ConverterParameters(){} // RVA: 0x7A80DA7B0
        public void .ctor(){} // RVA: 0x7ADD47490
    }

    public class JsonConverterAttribute[] : Array
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

    public class JsonConverterCollection : Collection`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADD475F0
    }

    public class JsonConverter[] : Array
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

    public class JsonConverter`1 : JsonConverter
    {
        // ── Methods ──
        public void WriteJson(){} // RVA: 0x7A8051B10
        public void ReadJson(){} // RVA: 0x7A8051B10
        public void CanConvert(){} // RVA: 0x7A7E019D0
        public void .ctor(){} // RVA: 0x7A7E18770
    }

    public class JsonConverter`1 : JsonConverter
    {
        // ── Methods ──
        public void WriteJson(){} // RVA: 0x7A7E1E190
        public void ReadJson(){} // RVA: 0x7A7E27870
        public void CanConvert(){} // RVA: 0x7AB40B700
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class JsonDictionaryAttribute : JsonContainerAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
    }

    public class JsonException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADD47750
        public void Create(){} // RVA: 0x7ADD477D0
    }

    public class JsonExtensionDataAttribute : Attribute
    {
        // ── Methods ──
        public void get_WriteData(){} // RVA: 0x7A81A2200
        public void set_WriteData(){} // RVA: 0x7A81A2210
        public void get_ReadData(){} // RVA: 0x7A82FBFB0
        public void set_ReadData(){} // RVA: 0x7A82FBFC0
        public void .ctor(){} // RVA: 0x7A8329990
    }

    public class JsonExtensionDataAttribute[] : Array
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

    public class JsonIgnoreAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class JsonIgnoreAttribute[] : Array
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

    public class JsonNameTable : Object
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x7A7E017C0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class JsonObjectAttribute : JsonContainerAttribute
    {
        // ── Methods ──
        public void get_MemberSerialization(){} // RVA: 0x7A9A93870
        public void set_MemberSerialization(){} // RVA: 0x7A9A93880
        public void get_MissingMemberHandling(){} // RVA: 0x7ADD478B0
        public void set_MissingMemberHandling(){} // RVA: 0x7ADD478F0
        public void get_ItemNullValueHandling(){} // RVA: 0x7ADD47950
        public void set_ItemNullValueHandling(){} // RVA: 0x7ADD479A0
        public void get_ItemRequired(){} // RVA: 0x7ADD47A00
        public void set_ItemRequired(){} // RVA: 0x7ADD47A40
        public void .ctor(){} // RVA: 0x7A80D8E20
    }

    public class JsonObjectAttribute[] : Array
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

    public class JsonPosition : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E44980
        public void CalculateLength(){} // RVA: 0x7A7E44990
        public void WriteTo(){} // RVA: 0x7A7E449A0
        public void TypeHasIndex(){} // RVA: 0x7ADD47E30
        public void BuildPath(){} // RVA: 0x7ADD47E40
        public void FormatMessage(){} // RVA: 0x7ADD48460
        public void .cctor(){} // RVA: 0x7ADD487D0
    }

    public class JsonPosition[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2A1330
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DF80
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E2C90
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA250480
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DF80
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class JsonPropertyAttribute : Attribute
    {
        // ── Methods ──
        public void get_ItemConverterType(){} // RVA: 0x7A8175DF0
        public void set_ItemConverterType(){} // RVA: 0x7A8175E00
        public void get_ItemConverterParameters(){} // RVA: 0x7A8153390
        public void set_ItemConverterParameters(){} // RVA: 0x7A81533A0
        public void get_NamingStrategyType(){} // RVA: 0x7A81A00E0
        public void set_NamingStrategyType(){} // RVA: 0x7A81A00F0
        public void get_NamingStrategyParameters(){} // RVA: 0x7A82C2060
        public void set_NamingStrategyParameters(){} // RVA: 0x7A82C0530
        public void get_NullValueHandling(){} // RVA: 0x7ADD488B0
        public void set_NullValueHandling(){} // RVA: 0x7ADD488F0
        public void get_DefaultValueHandling(){} // RVA: 0x7ADD48950
        public void set_DefaultValueHandling(){} // RVA: 0x7ADD48990
        public void get_ReferenceLoopHandling(){} // RVA: 0x7ADD489F0
        public void set_ReferenceLoopHandling(){} // RVA: 0x7ADD48A30
        public void get_ObjectCreationHandling(){} // RVA: 0x7ADD48A90
        public void set_ObjectCreationHandling(){} // RVA: 0x7ADD48AD0
        public void get_TypeNameHandling(){} // RVA: 0x7ADD48B30
        public void set_TypeNameHandling(){} // RVA: 0x7ADD48B70
        public void get_IsReference(){} // RVA: 0x7ADD48BD0
        public void set_IsReference(){} // RVA: 0x7ADD48C10
        public void get_Order(){} // RVA: 0x7ADD48C60
        public void set_Order(){} // RVA: 0x7ADD48CA0
        public void get_Required(){} // RVA: 0x7ADD48D00
        public void set_Required(){} // RVA: 0x7ADD48D40
        public void get_PropertyName(){} // RVA: 0x7A825E100
        public void set_PropertyName(){} // RVA: 0x7A825F860
        public void get_ItemReferenceLoopHandling(){} // RVA: 0x7ADD48DA0
        public void set_ItemReferenceLoopHandling(){} // RVA: 0x7ADD48DE0
        public void get_ItemTypeNameHandling(){} // RVA: 0x7ADD48E40
        public void set_ItemTypeNameHandling(){} // RVA: 0x7ADD48E80
        public void get_ItemIsReference(){} // RVA: 0x7ADD48EE0
        public void set_ItemIsReference(){} // RVA: 0x7ADD48F20
        public void .ctor(){} // RVA: 0x7A825F860
    }

    public class JsonPropertyAttribute[] : Array
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

    public class JsonReader : Object
    {
        // ── Methods ──
        public void ReadAsync(){} // RVA: 0x7ADD48F70
        public void SkipAsync(){} // RVA: 0x7ADD49130
        public void ReaderReadAndAssertAsync(){} // RVA: 0x7ADD49340
        public void ReadAsBooleanAsync(){} // RVA: 0x7ADD49550
        public void ReadAsBytesAsync(){} // RVA: 0x7ADD496F0
        public void ReadArrayIntoByteArrayAsync(){} // RVA: 0x7ADD49800
        public void ReadAsDateTimeAsync(){} // RVA: 0x7ADD499F0
        public void ReadAsDateTimeOffsetAsync(){} // RVA: 0x7ADD49C00
        public void ReadAsDecimalAsync(){} // RVA: 0x7ADD49E20
        public void ReadAsDoubleAsync(){} // RVA: 0x7ADD4A040
        public void ReadAsInt32Async(){} // RVA: 0x7ADD4A170
        public void ReadAsStringAsync(){} // RVA: 0x7ADD4A310
        public void ReadAndMoveToContentAsync(){} // RVA: 0x7ADD4A3E0
        public void MoveToContentAsync(){} // RVA: 0x7ADD4A5D0
        public void MoveToContentFromNonContentAsync(){} // RVA: 0x7ADD4A670
        public void get_CurrentState(){} // RVA: 0x7A8AB15F0
        public void get_CloseInput(){} // RVA: 0x7A8153980
        public void set_CloseInput(){} // RVA: 0x7A8153990
        public void get_SupportMultipleContent(){} // RVA: 0x7AD89C540
        public void set_SupportMultipleContent(){} // RVA: 0x7AD89C550
        public void get_QuoteChar(){} // RVA: 0x7AC2A24B0
        public void set_QuoteChar(){} // RVA: 0x7AD8AE4B0
        public void get_DateTimeZoneHandling(){} // RVA: 0x7A8178B70
        public void set_DateTimeZoneHandling(){} // RVA: 0x7ADD4A860
        public void get_DateParseHandling(){} // RVA: 0x7A87A7DA0
        public void set_DateParseHandling(){} // RVA: 0x7ADD4A8D0
        public void get_FloatParseHandling(){} // RVA: 0x7A835E820
        public void set_FloatParseHandling(){} // RVA: 0x7ADD4A940
        public void get_DateFormatString(){} // RVA: 0x7A8175DF0
        public void set_DateFormatString(){} // RVA: 0x7A8175E00
        public void get_MaxDepth(){} // RVA: 0x7AB498B60
        public void set_MaxDepth(){} // RVA: 0x7ADD4A9B0
        public void get_TokenType(){} // RVA: 0x7A8124910
        public void get_Value(){} // RVA: 0x7A80DA7B0
        public void get_ValueType(){} // RVA: 0x7ADD4AA70
        public void get_Depth(){} // RVA: 0x7ADD4AA90
        public void get_Path(){} // RVA: 0x7ADD4AB00
        public void get_Culture(){} // RVA: 0x7ADD4AC90
        public void set_Culture(){} // RVA: 0x7A80FF440
        public void GetPosition(){} // RVA: 0x7ADD4ACF0
        public void .ctor(){} // RVA: 0x7ADD4ADB0
        public void Push(){} // RVA: 0x7ADD4AE20
        public void Pop(){} // RVA: 0x7ADD4B170
        public void Peek(){} // RVA: 0x7A854FDE0
        public void Read(){} // RVA: 0x7A7E01900
        public void ReadAsInt32(){} // RVA: 0x7ADD4B330
        public void ReadInt32String(){} // RVA: 0x7ADD4B700
        public void ReadAsString(){} // RVA: 0x7ADD4B980
        public void ReadAsBytes(){} // RVA: 0x7ADD4BBC0
        public void ReadArrayIntoByteArray(){} // RVA: 0x7ADD4C060
        public void ReadArrayElementIntoByteArrayReportDone(){} // RVA: 0x7ADD4C170
        public void ReadAsDouble(){} // RVA: 0x7ADD4C370
        public void ReadDoubleString(){} // RVA: 0x7ADD4C6C0
        public void ReadAsBoolean(){} // RVA: 0x7ADD4C900
        public void ReadBooleanString(){} // RVA: 0x7ADD4CD00
        public void ReadAsDecimal(){} // RVA: 0x7ADD4CFD0
        public void ReadDecimalString(){} // RVA: 0x7ADD4D400
        public void ReadAsDateTime(){} // RVA: 0x7ADD4D740
        public void ReadDateTimeString(){} // RVA: 0x7ADD4DA30
        public void ReadAsDateTimeOffset(){} // RVA: 0x7ADD4DCB0
        public void ReadDateTimeOffsetString(){} // RVA: 0x7ADD4DF80
        public void ReaderReadAndAssert(){} // RVA: 0x7ADD4E210
        public void CreateUnexpectedEndException(){} // RVA: 0x7ADD4E260
        public void ReadIntoWrappedTypeObject(){} // RVA: 0x7ADD4E2B0
        public void Skip(){} // RVA: 0x7ADD4E680
        public void SetToken(){} // RVA: 0x7ADD4E780
        public void SetPostValueState(){} // RVA: 0x7ADD4E9B0
        public void UpdateScopeWithFinishedValue(){} // RVA: 0x7ADD4E9E0
        public void ValidateEnd(){} // RVA: 0x7ADD4E9F0
        public void SetStateBasedOnCurrent(){} // RVA: 0x7ADD4EBB0
        public void SetFinished(){} // RVA: 0x7ADD4ECC0
        public void GetTypeForCloseToken(){} // RVA: 0x7ADD4ECE0
        public void System.IDisposable.Dispose(){} // RVA: 0x7ADD4EDD0
        public void Dispose(){} // RVA: 0x7ADD4EE40
        public void Close(){} // RVA: 0x7ADD4EE70
        public void ReadAndAssert(){} // RVA: 0x7ADD4EED0
        public void ReadForTypeAndAssert(){} // RVA: 0x7ADD4EF30
        public void ReadForType(){} // RVA: 0x7ADD4EF80
        public void ReadAndMoveToContent(){} // RVA: 0x7ADD4F240
        public void MoveToContent(){} // RVA: 0x7ADD4F2A0
        public void GetContentToken(){} // RVA: 0x7ADD4F300
    }

    public class JsonReaderException : JsonException
    {
        // ── Methods ──
        public void get_LineNumber(){} // RVA: 0x7A846C760
        public void get_LinePosition(){} // RVA: 0x7A846C750
        public void get_Path(){} // RVA: 0x7A87D9C10
        public void .ctor(){} // RVA: 0x7ADD50B10
        public void Create(){} // RVA: 0x7ADD50DA0
    }

    public class JsonRequiredAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class JsonRequiredAttribute[] : Array
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

    public class JsonSerializationException : JsonException
    {
        // ── Methods ──
        public void get_LineNumber(){} // RVA: 0x7A846C760
        public void get_LinePosition(){} // RVA: 0x7A846C750
        public void get_Path(){} // RVA: 0x7A87D9C10
        public void .ctor(){} // RVA: 0x7ADD50B10
        public void Create(){} // RVA: 0x7ADD51060
    }

    public class JsonSerializer : Object
    {
        // ── Methods ──
        public void add_Error(){} // RVA: 0x7ADD511E0
        public void remove_Error(){} // RVA: 0x7ADD51300
        public void get_ReferenceResolver(){} // RVA: 0x7ADD51420
        public void set_ReferenceResolver(){} // RVA: 0x7ADD51430
        public void get_Binder(){} // RVA: 0x7ADD51500
        public void set_Binder(){} // RVA: 0x7ADD515F0
        public void get_SerializationBinder(){} // RVA: 0x7A81A0050
        public void set_SerializationBinder(){} // RVA: 0x7ADD51750
        public void get_TraceWriter(){} // RVA: 0x7A8152D80
        public void set_TraceWriter(){} // RVA: 0x7A8152D90
        public void get_EqualityComparer(){} // RVA: 0x7A8178B90
        public void set_EqualityComparer(){} // RVA: 0x7A8230620
        public void get_TypeNameHandling(){} // RVA: 0x7A8124910
        public void set_TypeNameHandling(){} // RVA: 0x7ADD51820
        public void get_TypeNameAssemblyFormat(){} // RVA: 0x7A8668BC0
        public void set_TypeNameAssemblyFormat(){} // RVA: 0x7ADD51890
        public void get_TypeNameAssemblyFormatHandling(){} // RVA: 0x7A8668BC0
        public void set_TypeNameAssemblyFormatHandling(){} // RVA: 0x7ADD51900
        public void get_PreserveReferencesHandling(){} // RVA: 0x7A83782A0
        public void set_PreserveReferencesHandling(){} // RVA: 0x7ADD51970
        public void get_ReferenceLoopHandling(){} // RVA: 0x7A9739200
        public void set_ReferenceLoopHandling(){} // RVA: 0x7ADD519E0
        public void get_MissingMemberHandling(){} // RVA: 0x7A851DB90
        public void set_MissingMemberHandling(){} // RVA: 0x7ADD51A50
        public void get_NullValueHandling(){} // RVA: 0x7A854FDE0
        public void set_NullValueHandling(){} // RVA: 0x7ADD51AC0
        public void get_DefaultValueHandling(){} // RVA: 0x7A8F9ACE0
        public void set_DefaultValueHandling(){} // RVA: 0x7ADD51B30
        public void get_ObjectCreationHandling(){} // RVA: 0x7A8AB15F0
        public void set_ObjectCreationHandling(){} // RVA: 0x7ADD51BA0
        public void get_ConstructorHandling(){} // RVA: 0x7A8133100
        public void set_ConstructorHandling(){} // RVA: 0x7ADD51C10
        public void get_MetadataPropertyHandling(){} // RVA: 0x7A82C2070
        public void set_MetadataPropertyHandling(){} // RVA: 0x7ADD51C80
        public void get_Converters(){} // RVA: 0x7ADD51CF0
        public void get_ContractResolver(){} // RVA: 0x7A8154D80
        public void set_ContractResolver(){} // RVA: 0x7ADD51DD0
        public void get_Context(){} // RVA: 0x7AB491250
        public void set_Context(){} // RVA: 0x7ADD51E90
        public void get_Formatting(){} // RVA: 0x7ADD51EF0
        public void set_Formatting(){} // RVA: 0x7ADD51F30
        public void get_DateFormatHandling(){} // RVA: 0x7ADD51F90
        public void set_DateFormatHandling(){} // RVA: 0x7ADD51FE0
        public void get_DateTimeZoneHandling(){} // RVA: 0x7ADD52040
        public void set_DateTimeZoneHandling(){} // RVA: 0x7ADD520A0
        public void get_DateParseHandling(){} // RVA: 0x7ADD52100
        public void set_DateParseHandling(){} // RVA: 0x7ADD52160
        public void get_FloatParseHandling(){} // RVA: 0x7ADD521C0
        public void set_FloatParseHandling(){} // RVA: 0x7ADD52210
        public void get_FloatFormatHandling(){} // RVA: 0x7ADD52270
        public void set_FloatFormatHandling(){} // RVA: 0x7ADD522C0
        public void get_StringEscapeHandling(){} // RVA: 0x7ADD52320
        public void set_StringEscapeHandling(){} // RVA: 0x7ADD52370
        public void get_DateFormatString(){} // RVA: 0x7ADD523D0
        public void set_DateFormatString(){} // RVA: 0x7ADD52420
        public void get_Culture(){} // RVA: 0x7ADD52490
        public void set_Culture(){} // RVA: 0x7A8142620
        public void get_MaxDepth(){} // RVA: 0x7A8142680
        public void set_MaxDepth(){} // RVA: 0x7ADD52500
        public void get_CheckAdditionalContent(){} // RVA: 0x7ADD525D0
        public void set_CheckAdditionalContent(){} // RVA: 0x7ADD52620
        public void IsCheckAdditionalContentSet(){} // RVA: 0x7ADD52680
        public void .ctor(){} // RVA: 0x7ADD526D0
        public void Create(){} // RVA: 0x7ADD529C0
        public void CreateDefault(){} // RVA: 0x7ADD52B30
        public void ApplySerializerSettings(){} // RVA: 0x7ADD52B70
        public void Populate(){} // RVA: 0x7ADD53690
        public void PopulateInternal(){} // RVA: 0x7ADD536B0
        public void Deserialize(){} // RVA: 0x7ADD53A80
        public void DeserializeInternal(){} // RVA: 0x7ADD53AA0
        public void SetupReader(){} // RVA: 0x7ADD53D80
        public void ResetReader(){} // RVA: 0x7ADD54320
        public void Serialize(){} // RVA: 0x7ADD54750
        public void CreateTraceJsonReader(){} // RVA: 0x7ADD54780
        public void SerializeInternal(){} // RVA: 0x7ADD54840
        public void GetReferenceResolver(){} // RVA: 0x7ADD54FE0
        public void GetMatchingConverter(){} // RVA: 0x7ADD55090
        public void OnError(){} // RVA: 0x7ADD55160
    }

    public class JsonSerializerSettings : Object
    {
        // ── Methods ──
        public void get_ReferenceLoopHandling(){} // RVA: 0x7ADD55190
        public void set_ReferenceLoopHandling(){} // RVA: 0x7ADD551E0
        public void get_MissingMemberHandling(){} // RVA: 0x7ADD55240
        public void set_MissingMemberHandling(){} // RVA: 0x7ADD55290
        public void get_ObjectCreationHandling(){} // RVA: 0x7ADD552F0
        public void set_ObjectCreationHandling(){} // RVA: 0x7ADD55340
        public void get_NullValueHandling(){} // RVA: 0x7ADD553A0
        public void set_NullValueHandling(){} // RVA: 0x7ADD553F0
        public void get_DefaultValueHandling(){} // RVA: 0x7ADD55450
        public void set_DefaultValueHandling(){} // RVA: 0x7ADD55490
        public void get_Converters(){} // RVA: 0x7A8854870
        public void set_Converters(){} // RVA: 0x7A8158EF0
        public void get_PreserveReferencesHandling(){} // RVA: 0x7ADD554F0
        public void set_PreserveReferencesHandling(){} // RVA: 0x7ADD55540
        public void get_TypeNameHandling(){} // RVA: 0x7ADD555A0
        public void set_TypeNameHandling(){} // RVA: 0x7ADD555F0
        public void get_MetadataPropertyHandling(){} // RVA: 0x7ADD55650
        public void set_MetadataPropertyHandling(){} // RVA: 0x7ADD556A0
        public void get_TypeNameAssemblyFormat(){} // RVA: 0x7ADD55700
        public void set_TypeNameAssemblyFormat(){} // RVA: 0x7ADD55740
        public void get_TypeNameAssemblyFormatHandling(){} // RVA: 0x7ADD55700
        public void set_TypeNameAssemblyFormatHandling(){} // RVA: 0x7ADD55740
        public void get_ConstructorHandling(){} // RVA: 0x7ADD557A0
        public void set_ConstructorHandling(){} // RVA: 0x7ADD557F0
        public void get_ContractResolver(){} // RVA: 0x7A8158F50
        public void set_ContractResolver(){} // RVA: 0x7A8158F60
        public void get_EqualityComparer(){} // RVA: 0x7A8158FC0
        public void set_EqualityComparer(){} // RVA: 0x7A8158FD0
        public void get_ReferenceResolver(){} // RVA: 0x7ADD55850
        public void set_ReferenceResolver(){} // RVA: 0x7ADD55870
        public void get_ReferenceResolverProvider(){} // RVA: 0x7A8142870
        public void set_ReferenceResolverProvider(){} // RVA: 0x7A8142880
        public void get_TraceWriter(){} // RVA: 0x7A8592710
        public void set_TraceWriter(){} // RVA: 0x7A84442D0
        public void get_Binder(){} // RVA: 0x7ADD55A00
        public void set_Binder(){} // RVA: 0x7ADD55AD0
        public void get_SerializationBinder(){} // RVA: 0x7A8852A30
        public void set_SerializationBinder(){} // RVA: 0x7A8AB8FD0
        public void get_Error(){} // RVA: 0x7A884DED0
        public void set_Error(){} // RVA: 0x7A8AB6790
        public void get_Context(){} // RVA: 0x7ADD55BF0
        public void set_Context(){} // RVA: 0x7ADD55CC0
        public void get_DateFormatString(){} // RVA: 0x7ADD55DE0
        public void set_DateFormatString(){} // RVA: 0x7ADD55E30
        public void get_MaxDepth(){} // RVA: 0x7ADD55E90
        public void set_MaxDepth(){} // RVA: 0x7ADD55EF0
        public void get_Formatting(){} // RVA: 0x7ADD55FB0
        public void set_Formatting(){} // RVA: 0x7ADD55FF0
        public void get_DateFormatHandling(){} // RVA: 0x7ADD56050
        public void set_DateFormatHandling(){} // RVA: 0x7ADD56090
        public void get_DateTimeZoneHandling(){} // RVA: 0x7ADD560F0
        public void set_DateTimeZoneHandling(){} // RVA: 0x7ADD56150
        public void get_DateParseHandling(){} // RVA: 0x7ADD561B0
        public void set_DateParseHandling(){} // RVA: 0x7ADD56210
        public void get_FloatFormatHandling(){} // RVA: 0x7ADD56270
        public void set_FloatFormatHandling(){} // RVA: 0x7ADD562B0
        public void get_FloatParseHandling(){} // RVA: 0x7ADD56310
        public void set_FloatParseHandling(){} // RVA: 0x7ADD56350
        public void get_StringEscapeHandling(){} // RVA: 0x7ADD563B0
        public void set_StringEscapeHandling(){} // RVA: 0x7ADD563F0
        public void get_Culture(){} // RVA: 0x7ADD56450
        public void set_Culture(){} // RVA: 0x7A8152D90
        public void get_CheckAdditionalContent(){} // RVA: 0x7ADD564C0
        public void set_CheckAdditionalContent(){} // RVA: 0x7ADD56500
        public void .cctor(){} // RVA: 0x7ADD56550
        public void .ctor(){} // RVA: 0x7ADD56730
    }

    public class JsonTextReader : JsonReader
    {
        // ── Methods ──
        public void ReadAsync(){} // RVA: 0x7ADD56CA0
        public void DoReadAsync(){} // RVA: 0x7ADD57190
        public void ParsePostValueAsync(){} // RVA: 0x7ADD573E0
        public void ReadFromFinishedAsync(){} // RVA: 0x7ADD575F0
        public void ReadDataAsync(){} // RVA: 0x7ADD57800
        public void ParseValueAsync(){} // RVA: 0x7ADD57A20
        public void ReadStringIntoBufferAsync(){} // RVA: 0x7ADD57C20
        public void ProcessCarriageReturnAsync(){} // RVA: 0x7ADD57FC0
        public void ParseUnicodeAsync(){} // RVA: 0x7ADD581D0
        public void EnsureCharsAsync(){} // RVA: 0x7ADD583C0
        public void ReadCharsAsync(){} // RVA: 0x7ADD584B0
        public void ParseObjectAsync(){} // RVA: 0x7ADD586D0
        public void ParseCommentAsync(){} // RVA: 0x7ADD588D0
        public void EatWhitespaceAsync(){} // RVA: 0x7ADD58B20
        public void ParseStringAsync(){} // RVA: 0x7ADD58D30
        public void MatchValueAsync(){} // RVA: 0x7ADD58F70
        public void MatchValueWithTrailingSeparatorAsync(){} // RVA: 0x7ADD591C0
        public void MatchAndSetAsync(){} // RVA: 0x7ADD59410
        public void ParseTrueAsync(){} // RVA: 0x7ADD596E0
        public void ParseFalseAsync(){} // RVA: 0x7ADD597A0
        public void ParseNullAsync(){} // RVA: 0x7ADD598F0
        public void ParseConstructorAsync(){} // RVA: 0x7ADD59980
        public void ParseNumberNaNAsync(){} // RVA: 0x7ADD59BA0
        public void ParseNumberPositiveInfinityAsync(){} // RVA: 0x7ADD59DA0
        public void ParseNumberNegativeInfinityAsync(){} // RVA: 0x7ADD59FA0
        public void ParseNumberAsync(){} // RVA: 0x7ADD5A1A0
        public void ParseUndefinedAsync(){} // RVA: 0x7ADD5A3C0
        public void ParsePropertyAsync(){} // RVA: 0x7ADD5A450
        public void ReadNumberIntoBufferAsync(){} // RVA: 0x7ADD5A640
        public void ParseUnquotedPropertyAsync(){} // RVA: 0x7ADD5A850
        public void ReadNullCharAsync(){} // RVA: 0x7ADD5AA60
        public void HandleNullAsync(){} // RVA: 0x7ADD5AC50
        public void ReadFinishedAsync(){} // RVA: 0x7ADD5AE60
        public void ReadStringValueAsync(){} // RVA: 0x7ADD5B070
        public void ReadNumberValueAsync(){} // RVA: 0x7ADD5B280
        public void ReadAsBooleanAsync(){} // RVA: 0x7ADD5B490
        public void DoReadAsBooleanAsync(){} // RVA: 0x7ADD5B4B0
        public void ReadAsBytesAsync(){} // RVA: 0x7ADD5B6B0
        public void DoReadAsBytesAsync(){} // RVA: 0x7ADD5B7E0
        public void ReadIntoWrappedTypeObjectAsync(){} // RVA: 0x7ADD5B9E0
        public void ReadAsDateTimeAsync(){} // RVA: 0x7ADD5BBF0
        public void DoReadAsDateTimeAsync(){} // RVA: 0x7ADD5BC10
        public void ReadAsDateTimeOffsetAsync(){} // RVA: 0x7ADD5BE00
        public void DoReadAsDateTimeOffsetAsync(){} // RVA: 0x7ADD5BE20
        public void ReadAsDecimalAsync(){} // RVA: 0x7ADD5C010
        public void DoReadAsDecimalAsync(){} // RVA: 0x7ADD5C030
        public void ReadAsDoubleAsync(){} // RVA: 0x7ADD5C220
        public void DoReadAsDoubleAsync(){} // RVA: 0x7ADD5C360
        public void ReadAsInt32Async(){} // RVA: 0x7ADD5C550
        public void DoReadAsInt32Async(){} // RVA: 0x7ADD5C570
        public void ReadAsStringAsync(){} // RVA: 0x7ADD5C760
        public void DoReadAsStringAsync(){} // RVA: 0x7ADD5C850
        public void .ctor(){} // RVA: 0x7ADD5CA40
        public void get_PropertyNameTable(){} // RVA: 0x7A81F50F0
        public void set_PropertyNameTable(){} // RVA: 0x7A81F5100
        public void get_ArrayPool(){} // RVA: 0x7A82305B0
        public void set_ArrayPool(){} // RVA: 0x7ADD5CBE0
        public void EnsureBufferNotEmpty(){} // RVA: 0x7ADD5CCA0
        public void SetNewLine(){} // RVA: 0x7ADD5CDF0
        public void OnNewLine(){} // RVA: 0x7ADD5CE50
        public void ParseString(){} // RVA: 0x7ADD5CE60
        public void ParseReadString(){} // RVA: 0x7ADD5CEC0
        public void BlockCopyChars(){} // RVA: 0x7ADD5D2A0
        public void ShiftBufferIfNeeded(){} // RVA: 0x7ADD5D2C0
        public void ReadData(){} // RVA: 0x7ADD5D700
        public void PrepareBufferForReadData(){} // RVA: 0x7ADD5D3B0
        public void EnsureChars(){} // RVA: 0x7ADD5D7D0
        public void ReadChars(){} // RVA: 0x7ADD5D920
        public void Read(){} // RVA: 0x7ADD5DA60
        public void ReadAsInt32(){} // RVA: 0x7ADD5DD30
        public void ReadAsDateTime(){} // RVA: 0x7ADD5DE20
        public void ReadAsString(){} // RVA: 0x7ADD5DF10
        public void ReadAsBytes(){} // RVA: 0x7ADD5DF80
        public void ReadStringValue(){} // RVA: 0x7ADD5E710
        public void FinishReadQuotedStringValue(){} // RVA: 0x7ADD5F010
        public void CreateUnexpectedCharacterException(){} // RVA: 0x7ADD5F2F0
        public void ReadAsBoolean(){} // RVA: 0x7ADD5F400
        public void ProcessValueComma(){} // RVA: 0x7ADD5FE40
        public void ReadNumberValue(){} // RVA: 0x7ADD5FEC0
        public void FinishReadQuotedNumber(){} // RVA: 0x7ADD60760
        public void ReadAsDateTimeOffset(){} // RVA: 0x7ADD60910
        public void ReadAsDecimal(){} // RVA: 0x7ADD60A10
        public void ReadAsDouble(){} // RVA: 0x7ADD60B10
        public void HandleNull(){} // RVA: 0x7ADD60C00
        public void ReadFinished(){} // RVA: 0x7ADD60D10
        public void ReadNullChar(){} // RVA: 0x7ADD60E60
        public void EnsureBuffer(){} // RVA: 0x7ADD60EB0
        public void ReadStringIntoBuffer(){} // RVA: 0x7ADD60FC0
        public void FinishReadStringIntoBuffer(){} // RVA: 0x7ADD61570
        public void WriteCharToBuffer(){} // RVA: 0x7ADD617A0
        public void ConvertUnicode(){} // RVA: 0x7ADD61850
        public void ParseUnicode(){} // RVA: 0x7ADD61A90
        public void ReadNumberIntoBuffer(){} // RVA: 0x7ADD61AC0
        public void ReadNumberCharIntoBuffer(){} // RVA: 0x7ADD61B60
        public void ClearRecentString(){} // RVA: 0x7ADD61D20
        public void ParsePostValue(){} // RVA: 0x7ADD61D40
        public void ParseObject(){} // RVA: 0x7ADD62050
        public void ParseProperty(){} // RVA: 0x7ADD62200
        public void ValidIdentifierChar(){} // RVA: 0x7ADD62640
        public void ParseUnquotedProperty(){} // RVA: 0x7ADD626B0
        public void ReadUnquotedPropertyReportIfDone(){} // RVA: 0x7ADD62860
        public void ParseValue(){} // RVA: 0x7ADD62A60
        public void ProcessLineFeed(){} // RVA: 0x7ADD63270
        public void ProcessCarriageReturn(){} // RVA: 0x7ADD63290
        public void EatWhitespace(){} // RVA: 0x7ADD63300
        public void ParseConstructor(){} // RVA: 0x7ADD63470
        public void ParseNumber(){} // RVA: 0x7ADD63900
        public void ParseReadNumber(){} // RVA: 0x7ADD63A00
        public void ThrowReaderError(){} // RVA: 0x7ADD65140
        public void BigIntegerParse(){} // RVA: 0x7ADD651A0
        public void ParseComment(){} // RVA: 0x7ADD65280
        public void EndComment(){} // RVA: 0x7ADD65630
        public void MatchValue(){} // RVA: 0x7ADD656D0
        public void MatchValueWithTrailingSeparator(){} // RVA: 0x7ADD657C0
        public void IsSeparator(){} // RVA: 0x7ADD65890
        public void ParseTrue(){} // RVA: 0x7ADD659E0
        public void ParseNull(){} // RVA: 0x7ADD65AE0
        public void ParseUndefined(){} // RVA: 0x7ADD65BA0
        public void ParseFalse(){} // RVA: 0x7ADD65C60
        public void ParseNumberNegativeInfinity(){} // RVA: 0x7ADD65DE0
        public void ParseNumberPositiveInfinity(){} // RVA: 0x7ADD66020
        public void ParseNumberNaN(){} // RVA: 0x7ADD66260
        public void Close(){} // RVA: 0x7ADD66420
        public void HasLineInfo(){} // RVA: 0x7A81BD750
        public void get_LineNumber(){} // RVA: 0x7ADD665A0
        public void get_LinePosition(){} // RVA: 0x7ADD665F0
    }

    public class JsonTextWriter : JsonWriter
    {
        // ── Methods ──
        public void FlushAsync(){} // RVA: 0x7ADD7A4D0
        public void DoFlushAsync(){} // RVA: 0x7ADD7A630
        public void WriteValueDelimiterAsync(){} // RVA: 0x7ADD7A6C0
        public void DoWriteValueDelimiterAsync(){} // RVA: 0x7ADD7A800
        public void WriteEndAsync(){} // RVA: 0x7ADD7B0D0
        public void DoWriteEndAsync(){} // RVA: 0x7ADD7AAD0
        public void CloseAsync(){} // RVA: 0x7ADD7AC10
        public void DoCloseAsync(){} // RVA: 0x7ADD7AD10
        public void CloseBufferAndWriterAsync(){} // RVA: 0x7ADD7AF20
        public void WriteIndentAsync(){} // RVA: 0x7ADD7B620
        public void DoWriteIndentAsync(){} // RVA: 0x7ADD7B510
        public void WriteValueInternalAsync(){} // RVA: 0x7ADD7B940
        public void WriteIndentSpaceAsync(){} // RVA: 0x7ADD7BC10
        public void DoWriteIndentSpaceAsync(){} // RVA: 0x7ADD7BD50
        public void WriteRawAsync(){} // RVA: 0x7ADD7BDC0
        public void DoWriteRawAsync(){} // RVA: 0x7ADD7BF20
        public void WriteNullAsync(){} // RVA: 0x7ADD7BFA0
        public void DoWriteNullAsync(){} // RVA: 0x7ADD7C100
        public void WriteDigitsAsync(){} // RVA: 0x7ADD7C180
        public void WriteIntegerValueAsync(){} // RVA: 0x7ADD7C640
        public void WriteEscapedStringAsync(){} // RVA: 0x7ADD7C660
        public void WritePropertyNameAsync(){} // RVA: 0x7ADD7CDD0
        public void DoWritePropertyNameAsync(){} // RVA: 0x7ADD7CEE0
        public void WriteStartArrayAsync(){} // RVA: 0x7ADD7D170
        public void DoWriteStartArrayAsync(){} // RVA: 0x7ADD7D400
        public void WriteStartObjectAsync(){} // RVA: 0x7ADD7D680
        public void DoWriteStartObjectAsync(){} // RVA: 0x7ADD7D910
        public void WriteStartConstructorAsync(){} // RVA: 0x7ADD7DB90
        public void DoWriteStartConstructorAsync(){} // RVA: 0x7ADD7DCA0
        public void WriteUndefinedAsync(){} // RVA: 0x7ADD7DF20
        public void DoWriteUndefinedAsync(){} // RVA: 0x7ADD7E210
        public void WriteWhitespaceAsync(){} // RVA: 0x7ADD7E490
        public void DoWriteWhitespaceAsync(){} // RVA: 0x7ADD7E5F0
        public void WriteValueAsync(){} // RVA: 0x7ADD83D80
        public void DoWriteValueAsync(){} // RVA: 0x7ADD83F00
        public void WriteValueNonNullAsync(){} // RVA: 0x7ADD7EE90
        public void WriteValueNotNullAsync(){} // RVA: 0x7ADD83990
        public void WriteCommentAsync(){} // RVA: 0x7ADD83FA0
        public void DoWriteCommentAsync(){} // RVA: 0x7ADD840B0
        public void WriteEndArrayAsync(){} // RVA: 0x7ADD84330
        public void WriteEndConstructorAsync(){} // RVA: 0x7ADD84430
        public void WriteEndObjectAsync(){} // RVA: 0x7ADD84530
        public void WriteRawValueAsync(){} // RVA: 0x7ADD84630
        public void DoWriteRawValueAsync(){} // RVA: 0x7ADD848D0
        public void EnsureWriteBuffer(){} // RVA: 0x7ADD87DF0
        public void get_Base64Encoder(){} // RVA: 0x7ADD84EA0
        public void get_ArrayPool(){} // RVA: 0x7A87D9C10
        public void set_ArrayPool(){} // RVA: 0x7ADD850A0
        public void get_Indentation(){} // RVA: 0x7A98A0C40
        public void set_Indentation(){} // RVA: 0x7ADD85160
        public void get_QuoteChar(){} // RVA: 0x7ADD851D0
        public void set_QuoteChar(){} // RVA: 0x7ADD851E0
        public void get_IndentChar(){} // RVA: 0x7ADD85260
        public void set_IndentChar(){} // RVA: 0x7ADD85270
        public void get_QuoteName(){} // RVA: 0x7A8EFF4A0
        public void set_QuoteName(){} // RVA: 0x7ADD852E0
        public void .ctor(){} // RVA: 0x7ADD852F0
        public void Flush(){} // RVA: 0x7ADB22840
        public void Close(){} // RVA: 0x7ADD85480
        public void CloseBufferAndWriter(){} // RVA: 0x7ADD85580
        public void WriteStartObject(){} // RVA: 0x7ADD85670
        public void WriteStartArray(){} // RVA: 0x7ADD856D0
        public void WriteStartConstructor(){} // RVA: 0x7ADD85730
        public void WriteEnd(){} // RVA: 0x7ADD85800
        public void WritePropertyName(){} // RVA: 0x7ADD859B0
        public void OnStringEscapeHandlingChanged(){} // RVA: 0x7ADD85AF0
        public void UpdateCharEscapeFlags(){} // RVA: 0x7ADD85B00
        public void WriteIndent(){} // RVA: 0x7ADD85BD0
        public void SetIndentChars(){} // RVA: 0x7ADD85D40
        public void WriteValueDelimiter(){} // RVA: 0x7ADD85F60
        public void WriteIndentSpace(){} // RVA: 0x7ADD85F90
        public void WriteValueInternal(){} // RVA: 0x7ADD85FC0
        public void WriteValue(){} // RVA: 0x7ADD87BD0
        public void WriteNull(){} // RVA: 0x7ADD86120
        public void WriteUndefined(){} // RVA: 0x7ADD861C0
        public void WriteRaw(){} // RVA: 0x7ADD85FC0
        public void WriteEscapedString(){} // RVA: 0x7ADD86330
        public void WriteValueToBuffer(){} // RVA: 0x7ADD87690
        public void WriteComment(){} // RVA: 0x7ADD87CD0
        public void WriteWhitespace(){} // RVA: 0x7ADD87DA0
        public void WriteIntegerValue(){} // RVA: 0x7ADD88190
        public void WriteNumberToBuffer(){} // RVA: 0x7ADD88220
    }

    public class JsonValidatingReader : JsonReader
    {
        // ── Methods ──
        public void add_ValidationEventHandler(){} // RVA: 0x7ADD90810
        public void remove_ValidationEventHandler(){} // RVA: 0x7ADD90910
        public void get_Value(){} // RVA: 0x7ADD90A10
        public void get_Depth(){} // RVA: 0x7ADD90A40
        public void get_Path(){} // RVA: 0x7ADD90A70
        public void get_QuoteChar(){} // RVA: 0x7ADD90AA0
        public void set_QuoteChar(){} // RVA: 0x7A80D7310
        public void get_TokenType(){} // RVA: 0x7ADD90AD0
        public void get_ValueType(){} // RVA: 0x7ADD90B00
        public void Push(){} // RVA: 0x7ADD90B30
        public void Pop(){} // RVA: 0x7ADD90BF0
        public void get_CurrentSchemas(){} // RVA: 0x7ADD90CF0
        public void get_CurrentMemberSchemas(){} // RVA: 0x7ADD90D10
        public void RaiseError(){} // RVA: 0x7ADD917F0
        public void OnValidationEvent(){} // RVA: 0x7ADD91B50
        public void .ctor(){} // RVA: 0x7ADD91CE0
        public void get_Schema(){} // RVA: 0x7A81163D0
        public void set_Schema(){} // RVA: 0x7ADD91EC0
        public void get_Reader(){} // RVA: 0x7A82C2060
        public void Close(){} // RVA: 0x7ADD92000
        public void ValidateNotDisallowed(){} // RVA: 0x7ADD92090
        public void GetCurrentNodeSchemaType(){} // RVA: 0x7ADD923B0
        public void ReadAsInt32(){} // RVA: 0x7ADD92540
        public void ReadAsBytes(){} // RVA: 0x7ADD92590
        public void ReadAsDecimal(){} // RVA: 0x7ADD925E0
        public void ReadAsDouble(){} // RVA: 0x7ADD92640
        public void ReadAsBoolean(){} // RVA: 0x7ADD926A0
        public void ReadAsString(){} // RVA: 0x7ADD926F0
        public void ReadAsDateTime(){} // RVA: 0x7ADD92740
        public void ReadAsDateTimeOffset(){} // RVA: 0x7ADD927A0
        public void Read(){} // RVA: 0x7ADD92800
        public void ValidateCurrentToken(){} // RVA: 0x7ADD92870
        public void WriteToken(){} // RVA: 0x7ADD936E0
        public void ValidateEndObject(){} // RVA: 0x7ADD94100
        public void ValidateEndArray(){} // RVA: 0x7ADD944F0
        public void ValidateNull(){} // RVA: 0x7ADD94720
        public void ValidateBoolean(){} // RVA: 0x7ADD94760
        public void ValidateString(){} // RVA: 0x7ADD947A0
        public void ValidateInteger(){} // RVA: 0x7ADD94BA0
        public void ProcessValue(){} // RVA: 0x7ADD953C0
        public void ValidateFloat(){} // RVA: 0x7ADD956E0
        public void FloatingPointRemainder(){} // RVA: 0x7ADD95CB0
        public void IsZero(){} // RVA: 0x7ADD95D20
        public void ValidatePropertyName(){} // RVA: 0x7ADD95D90
        public void IsPropertyDefinied(){} // RVA: 0x7ADD95FF0
        public void ValidateArray(){} // RVA: 0x7ADD96210
        public void ValidateObject(){} // RVA: 0x7ADD96230
        public void TestType(){} // RVA: 0x7ADD96250
        public void Newtonsoft.Json.IJsonLineInfo.HasLineInfo(){} // RVA: 0x7ADD963A0
        public void Newtonsoft.Json.IJsonLineInfo.get_LineNumber(){} // RVA: 0x7ADD96400
        public void Newtonsoft.Json.IJsonLineInfo.get_LinePosition(){} // RVA: 0x7ADD96460
        public void .cctor(){} // RVA: 0x7ADD964C0
    }

    public class JsonWriter : Object
    {
        // ── Methods ──
        public void AutoCompleteAsync(){} // RVA: 0x7ADD97440
        public void CloseAsync(){} // RVA: 0x7ADD97650
        public void FlushAsync(){} // RVA: 0x7ADD97730
        public void WriteEndAsync(){} // RVA: 0x7ADD97CA0
        public void WriteIndentAsync(){} // RVA: 0x7ADD97900
        public void WriteValueDelimiterAsync(){} // RVA: 0x7ADD979E0
        public void WriteIndentSpaceAsync(){} // RVA: 0x7ADD97AC0
        public void WriteRawAsync(){} // RVA: 0x7ADD97BA0
        public void WriteEndInternalAsync(){} // RVA: 0x7ADD97D80
        public void InternalWriteEndAsync(){} // RVA: 0x7ADD97F20
        public void WriteEndArrayAsync(){} // RVA: 0x7ADD981A0
        public void WriteEndConstructorAsync(){} // RVA: 0x7ADD98280
        public void WriteEndObjectAsync(){} // RVA: 0x7ADD98360
        public void WriteNullAsync(){} // RVA: 0x7ADD98440
        public void WritePropertyNameAsync(){} // RVA: 0x7ADD98620
        public void InternalWritePropertyNameAsync(){} // RVA: 0x7ADD98720
        public void WriteStartArrayAsync(){} // RVA: 0x7ADD98840
        public void InternalWriteStartAsync(){} // RVA: 0x7ADD98920
        public void WriteCommentAsync(){} // RVA: 0x7ADD98B60
        public void InternalWriteCommentAsync(){} // RVA: 0x7ADD98C60
        public void WriteRawValueAsync(){} // RVA: 0x7ADD98C70
        public void WriteStartConstructorAsync(){} // RVA: 0x7ADD98D70
        public void WriteStartObjectAsync(){} // RVA: 0x7ADD98E70
        public void WriteTokenAsync(){} // RVA: 0x7ADD99BC0
        public void WriteTokenSyncReadingAsync(){} // RVA: 0x7ADD99E60
        public void WriteConstructorDateAsync(){} // RVA: 0x7ADD9A0E0
        public void WriteValueAsync(){} // RVA: 0x7ADD9CEE0
        public void WriteUndefinedAsync(){} // RVA: 0x7ADD9C940
        public void WriteWhitespaceAsync(){} // RVA: 0x7ADD9CA20
        public void InternalWriteValueAsync(){} // RVA: 0x7ADD9CB20
        public void SetWriteStateAsync(){} // RVA: 0x7ADD9CBF0
        public void BuildStateArray(){} // RVA: 0x7ADD9E3F0
        public void .cctor(){} // RVA: 0x7ADD9E6C0
        public void get_CloseOutput(){} // RVA: 0x7A82A20A0
        public void set_CloseOutput(){} // RVA: 0x7A82A2C90
        public void get_AutoCompleteOnClose(){} // RVA: 0x7A82A3DE0
        public void set_AutoCompleteOnClose(){} // RVA: 0x7A82A20B0
        public void get_Top(){} // RVA: 0x7ADD9EA50
        public void get_WriteState(){} // RVA: 0x7ADD9EAB0
        public void get_ContainerPath(){} // RVA: 0x7ADD9EBD0
        public void get_Path(){} // RVA: 0x7ADD9EC70
        public void get_Formatting(){} // RVA: 0x7A82C2070
        public void set_Formatting(){} // RVA: 0x7ADD9EE00
        public void get_DateFormatHandling(){} // RVA: 0x7A864E8D0
        public void set_DateFormatHandling(){} // RVA: 0x7ADD9EE70
        public void get_DateTimeZoneHandling(){} // RVA: 0x7A8178B30
        public void set_DateTimeZoneHandling(){} // RVA: 0x7ADD9EEE0
        public void get_StringEscapeHandling(){} // RVA: 0x7A8178B50
        public void set_StringEscapeHandling(){} // RVA: 0x7ADD9EF50
        public void OnStringEscapeHandlingChanged(){} // RVA: 0x7A80D7310
        public void get_FloatFormatHandling(){} // RVA: 0x7A8178B70
        public void set_FloatFormatHandling(){} // RVA: 0x7ADD9EFD0
        public void get_DateFormatString(){} // RVA: 0x7A8178B90
        public void set_DateFormatString(){} // RVA: 0x7A8230620
        public void get_Culture(){} // RVA: 0x7ADD9F040
        public void set_Culture(){} // RVA: 0x7A81A0060
        public void .ctor(){} // RVA: 0x7ADD9F0A0
        public void UpdateScopeWithFinishedValue(){} // RVA: 0x7ADD9F0C0
        public void Push(){} // RVA: 0x7ADD9F0D0
        public void Pop(){} // RVA: 0x7ADD9F280
        public void Peek(){} // RVA: 0x7A83782A0
        public void Flush(){} // RVA: 0x7A7E18770
        public void Close(){} // RVA: 0x7ADD9F400
        public void WriteStartObject(){} // RVA: 0x7ADD9F470
        public void WriteEndObject(){} // RVA: 0x7ADD9F4B0
        public void WriteStartArray(){} // RVA: 0x7ADD9F4C0
        public void WriteEndArray(){} // RVA: 0x7ADD9F500
        public void WriteStartConstructor(){} // RVA: 0x7ADD9F510
        public void WriteEndConstructor(){} // RVA: 0x7ADD9F550
        public void WritePropertyName(){} // RVA: 0x7ADD9F5D0
        public void WriteEnd(){} // RVA: 0x7A80D7310
        public void WriteToken(){} // RVA: 0x7ADDA02D0
        public void IsWriteTokenIncomplete(){} // RVA: 0x7ADDA05B0
        public void CalculateWriteTokenInitialDepth(){} // RVA: 0x7ADDA0680
        public void CalculateWriteTokenFinalDepth(){} // RVA: 0x7ADDA06F0
        public void WriteConstructorDate(){} // RVA: 0x7ADDA0760
        public void AutoCompleteAll(){} // RVA: 0x7ADDA0910
        public void GetCloseTokenForType(){} // RVA: 0x7ADDA0980
        public void AutoCompleteClose(){} // RVA: 0x7ADDA0A40
        public void CalculateLevelsToComplete(){} // RVA: 0x7ADDA0B00
        public void UpdateCurrentState(){} // RVA: 0x7ADDA0C40
        public void WriteIndent(){} // RVA: 0x7A80D7310
        public void WriteValueDelimiter(){} // RVA: 0x7A80D7310
        public void WriteIndentSpace(){} // RVA: 0x7A80D7310
        public void AutoComplete(){} // RVA: 0x7ADDA0D10
        public void WriteNull(){} // RVA: 0x7ADDA0F40
        public void WriteUndefined(){} // RVA: 0x7ADDA0F60
        public void WriteRaw(){} // RVA: 0x7A80D7310
        public void WriteRawValue(){} // RVA: 0x7ADDA0F80
        public void WriteValue(){} // RVA: 0x7ADDA1CF0
        public void WriteComment(){} // RVA: 0x7ADDA1C30
        public void WriteWhitespace(){} // RVA: 0x7ADDA1C40
        public void System.IDisposable.Dispose(){} // RVA: 0x7ADDA1C50
        public void Dispose(){} // RVA: 0x7ADDA1CC0
        public void ResolveConvertibleValue(){} // RVA: 0x7ADDA3000
        public void CreateUnsupportedTypeException(){} // RVA: 0x7ADDA3260
        public void SetWriteState(){} // RVA: 0x7ADDA3360
        public void InternalWriteEnd(){} // RVA: 0x7ADDA0A40
        public void InternalWritePropertyName(){} // RVA: 0x7ADD9F560
        public void InternalWriteRaw(){} // RVA: 0x7A80D7310
        public void InternalWriteStart(){} // RVA: 0x7ADDA3600
        public void InternalWriteValue(){} // RVA: 0x7ADDA3640
        public void InternalWriteWhitespace(){} // RVA: 0x7ADDA3660
        public void InternalWriteComment(){} // RVA: 0x7ADDA1C30
        public void <InternalWriteEndAsync>g__AwaitProperty|11_0(){} // RVA: 0x7ADDA3760
        public void <InternalWriteEndAsync>g__AwaitIndent|11_1(){} // RVA: 0x7ADDA39F0
        public void <InternalWriteEndAsync>g__AwaitEnd|11_2(){} // RVA: 0x7ADDA3C90
        public void <InternalWriteEndAsync>g__AwaitRemaining|11_3(){} // RVA: 0x7ADDA3F10
    }

    public class JsonWriterException : JsonException
    {
        // ── Methods ──
        public void get_Path(){} // RVA: 0x7A8555100
        public void .ctor(){} // RVA: 0x7ADDA7AD0
        public void Create(){} // RVA: 0x7ADDA7C70
    }

}