// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.Newtonsoft.Json.Linq
// Classes: 13
// Methods: 257

namespace ThirdParty.Valve.Valve.Newtonsoft.Json.Linq
{
    public class JArray : JContainer
    {
        public object _values;

        // ── Methods ──
        public void get_ChildrenTokens(){} // RVA: 0xBC1B30
        public void get_Type(){} // RVA: 0xC50A80
        public void .ctor(){} // RVA: 0x81A3F90
        public void CloneToken(){} // RVA: 0x81A40A0
        public void Load(){} // RVA: 0x81A41B0
        public void WriteTo(){} // RVA: 0x81A43D0
        public void get_Item(){} // RVA: 0x81A4510
        public void set_Item(){} // RVA: 0x81A4530
        public void IndexOfItem(){} // RVA: 0x81A4550
        public void IndexOf(){} // RVA: 0x81A4600
        public void Insert(){} // RVA: 0x81A4620
        public void RemoveAt(){} // RVA: 0x74BED60
        public void GetEnumerator(){} // RVA: 0x81A4650
        public void Add(){} // RVA: 0x81A46E0
        public void Clear(){} // RVA: 0x81A4700
        public void Contains(){} // RVA: 0x81A4720
        public void CopyTo(){} // RVA: 0x81A4740
        public void get_IsReadOnly(){} // RVA: 0xB43320
        public void Remove(){} // RVA: 0x81A4760
    }

    public class JConstructor : JContainer
    {
        public object _name;
        public object _values;

        // ── Methods ──
        public void get_ChildrenTokens(){} // RVA: 0xBBF8F0
        public void IndexOfItem(){} // RVA: 0x81A4780
        public void get_Name(){} // RVA: 0xBC1B30
        public void get_Type(){} // RVA: 0x12FC4A0
        public void .ctor(){} // RVA: 0x81A4970
        public void CloneToken(){} // RVA: 0x81A4B70
        public void WriteTo(){} // RVA: 0x81A4CE0
        public void Load(){} // RVA: 0x81A4F60
    }

    public class JContainer : JToken
    {
        public object _syncRoot;
        public object _busy;

        // ── Methods ──
        public void get_ChildrenTokens(){} // RVA: 0x87C0A0
        public void .ctor(){} // RVA: 0x81A5220
        public void CheckReentrancy(){} // RVA: 0x81A5490
        public void get_HasValues(){} // RVA: 0x81A5540
        public void get_First(){} // RVA: 0x81A55B0
        public void get_Last(){} // RVA: 0x81A5650
        public void Children(){} // RVA: 0x81A56F0
        public void IsMultiContent(){} // RVA: 0x81A5820
        public void EnsureParentToken(){} // RVA: 0x81A58F0
        public void IndexOfItem(){} // RVA: 0x87D050
        public void InsertItem(){} // RVA: 0x81A59D0
        public void RemoveItemAt(){} // RVA: 0x81A5D40
        public void RemoveItem(){} // RVA: 0x81A5F80
        public void GetItem(){} // RVA: 0x81A5FD0
        public void SetItem(){} // RVA: 0x81A6040
        public void ClearItems(){} // RVA: 0x81A6380
        public void ReplaceItem(){} // RVA: 0x81A66B0
        public void ContainsItem(){} // RVA: 0x81A6710
        public void CopyItemsTo(){} // RVA: 0x81A6740
        public void IsTokenUnchanged(){} // RVA: 0x81A6A30
        public void ValidateToken(){} // RVA: 0x81A6AF0
        public void Add(){} // RVA: 0x81A6C50
        public void AddAndSkipParentCheck(){} // RVA: 0x81A6CE0
        public void AddInternal(){} // RVA: 0x81A6D70
        public void CreateFromContent(){} // RVA: 0x81A7030
        public void RemoveAll(){} // RVA: 0x81A4700
        public void ReadTokenFrom(){} // RVA: 0x81A70F0
        public void ReadContentFrom(){} // RVA: 0x81A72B0
        public void System.Collections.Generic.IList<Valve.Newtonsoft.Json.Linq.JToken>.IndexOf(){} // RVA: 0x81A4600
        public void System.Collections.Generic.IList<Valve.Newtonsoft.Json.Linq.JToken>.Insert(){} // RVA: 0x81A4620
        public void System.Collections.Generic.IList<Valve.Newtonsoft.Json.Linq.JToken>.RemoveAt(){} // RVA: 0x74BED60
        public void System.Collections.Generic.IList<Valve.Newtonsoft.Json.Linq.JToken>.get_Item(){} // RVA: 0x81A4510
        public void System.Collections.Generic.IList<Valve.Newtonsoft.Json.Linq.JToken>.set_Item(){} // RVA: 0x81A4530
        public void System.Collections.Generic.ICollection<Valve.Newtonsoft.Json.Linq.JToken>.Add(){} // RVA: 0x81A46E0
        public void System.Collections.Generic.ICollection<Valve.Newtonsoft.Json.Linq.JToken>.Clear(){} // RVA: 0x81A4700
        public void System.Collections.Generic.ICollection<Valve.Newtonsoft.Json.Linq.JToken>.Contains(){} // RVA: 0x81A4720
        public void System.Collections.Generic.ICollection<Valve.Newtonsoft.Json.Linq.JToken>.CopyTo(){} // RVA: 0x81A4740
        public void System.Collections.Generic.ICollection<Valve.Newtonsoft.Json.Linq.JToken>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<Valve.Newtonsoft.Json.Linq.JToken>.Remove(){} // RVA: 0x81A4760
        public void EnsureValue(){} // RVA: 0x81A7AD0
        public void System.Collections.IList.Add(){} // RVA: 0x81A7B90
        public void System.Collections.IList.Clear(){} // RVA: 0x81A4700
        public void System.Collections.IList.Contains(){} // RVA: 0x81A7C20
        public void System.Collections.IList.IndexOf(){} // RVA: 0x81A7C50
        public void System.Collections.IList.Insert(){} // RVA: 0x81A7C80
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.Remove(){} // RVA: 0x81A7CD0
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x74BED60
        public void System.Collections.IList.get_Item(){} // RVA: 0x81A4510
        public void System.Collections.IList.set_Item(){} // RVA: 0x81A7D00
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x81A4740
        public void get_Count(){} // RVA: 0x81A7D50
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x81A7DC0
    }

    public class JEnumerable`1 : ValueType
    {
        public object Empty;
        public object _enumerable;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x894320
        public void GetEnumerator(){} // RVA: 0x87C0A0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x87C0A0
        public void Equals(){} // RVA: 0x87D350
        public void GetHashCode(){} // RVA: 0x87C130
        public void .cctor(){} // RVA: 0x8942F0
    }

    public class JObject : JContainer
    {
        public object _properties;
        public object PropertyChanged;

        // ── Methods ──
        public void get_ChildrenTokens(){} // RVA: 0xBC1B30
        public void add_PropertyChanged(){} // RVA: 0x81A7E70
        public void remove_PropertyChanged(){} // RVA: 0x81A7F60
        public void .ctor(){} // RVA: 0x81A8130
        public void IndexOfItem(){} // RVA: 0x81A81F0
        public void InsertItem(){} // RVA: 0x81A8310
        public void ValidateToken(){} // RVA: 0x81A8380
        public void InternalPropertyChanged(){} // RVA: 0x81A8680
        public void InternalPropertyChanging(){} // RVA: 0xB43310
        public void CloneToken(){} // RVA: 0x81A86B0
        public void get_Type(){} // RVA: 0xC3CCE0
        public void Property(){} // RVA: 0x81A87A0
        public void get_Item(){} // RVA: 0x81A8870
        public void set_Item(){} // RVA: 0x81A8940
        public void Load(){} // RVA: 0x81A8AB0
        public void WriteTo(){} // RVA: 0x81A8D20
        public void Add(){} // RVA: 0x81A8EC0
        public void System.Collections.Generic.IDictionary<System.String,Valve.Newtonsoft.Json.Linq.JToken>.ContainsKey(){} // RVA: 0x81A8F50
        public void System.Collections.Generic.IDictionary<System.String,Valve.Newtonsoft.Json.Linq.JToken>.get_Keys(){} // RVA: 0x81A9030
        public void Remove(){} // RVA: 0x81A9090
        public void TryGetValue(){} // RVA: 0x81A9130
        public void System.Collections.Generic.IDictionary<System.String,Valve.Newtonsoft.Json.Linq.JToken>.get_Values(){} // RVA: 0x81A9220
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Valve.Newtonsoft.Json.Linq.JToken>>.Add(){} // RVA: 0x81A9260
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Valve.Newtonsoft.Json.Linq.JToken>>.Clear(){} // RVA: 0x81A4700
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Valve.Newtonsoft.Json.Linq.JToken>>.Contains(){} // RVA: 0x81A9310
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Valve.Newtonsoft.Json.Linq.JToken>>.CopyTo(){} // RVA: 0x81A93A0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Valve.Newtonsoft.Json.Linq.JToken>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Valve.Newtonsoft.Json.Linq.JToken>>.Remove(){} // RVA: 0x81A9780
        public void GetEnumerator(){} // RVA: 0x81A9890
        public void OnPropertyChanged(){} // RVA: 0x81A9930
    }

    public class JProperty : JContainer
    {
        public object _content;
        public object _name;

        // ── Methods ──
        public void get_ChildrenTokens(){} // RVA: 0xBC1B30
        public void get_Name(){} // RVA: 0xBBF8F0
        public void get_Value(){} // RVA: 0x81A9F40
        public void set_Value(){} // RVA: 0x81A9F60
        public void .ctor(){} // RVA: 0x81AAA00
        public void GetItem(){} // RVA: 0x81AA140
        public void SetItem(){} // RVA: 0x81AA1B0
        public void RemoveItem(){} // RVA: 0x81AA390
        public void RemoveItemAt(){} // RVA: 0x81AA440
        public void IndexOfItem(){} // RVA: 0x81AA4F0
        public void InsertItem(){} // RVA: 0x81AA520
        public void ContainsItem(){} // RVA: 0x81AA630
        public void ClearItems(){} // RVA: 0x81AA650
        public void CloneToken(){} // RVA: 0x81AA700
        public void get_Type(){} // RVA: 0x1347420
        public void WriteTo(){} // RVA: 0x81AAD80
        public void Load(){} // RVA: 0x81AAE20
    }

    public class JPropertyKeyedCollection : Collection`1
    {
        public object Comparer;
        public object _dictionary;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x81AB240
        public void AddKey(){} // RVA: 0x81AB320
        public void ClearItems(){} // RVA: 0x81AB3B0
        public void Contains(){} // RVA: 0x81AB460
        public void EnsureDictionary(){} // RVA: 0x81AB530
        public void GetKeyForItem(){} // RVA: 0x81AB640
        public void InsertItem(){} // RVA: 0x81AB6C0
        public void RemoveItem(){} // RVA: 0x81AB790
        public void RemoveKey(){} // RVA: 0x81AB910
        public void SetItem(){} // RVA: 0x81AB970
        public void TryGetValue(){} // RVA: 0x81ABBE0
        public void get_Keys(){} // RVA: 0x81ABCB0
        public void IndexOfReference(){} // RVA: 0x81ABD10
        public void .cctor(){} // RVA: 0x81ABE20
    }

    public class JRaw : JValue
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x81ABFB0
        public void Create(){} // RVA: 0x81ABFC0
        public void CloneToken(){} // RVA: 0x81AC2E0
    }

    public class JToken : Object
    {
        public object _parent;
        public object _previous;
        public object _next;
        public object _annotations;
        public object BooleanTypes;
        public object NumberTypes;
        public object StringTypes;
        public object GuidTypes;
        public object TimeSpanTypes;
        public object UriTypes;
        public object CharTypes;
        public object DateTimeTypes;
        public object BytesTypes;

        // ── Methods ──
        public void get_Parent(){} // RVA: 0xB5DBF0
        public void set_Parent(){} // RVA: 0xB44D60
        public void get_Root(){} // RVA: 0x6AB0800
        public void CloneToken(){} // RVA: 0x87C0A0
        public void get_Type(){} // RVA: 0x87C130
        public void get_HasValues(){} // RVA: 0x87D280
        public void get_Next(){} // RVA: 0xB700F0
        public void set_Next(){} // RVA: 0xB70100
        public void get_Previous(){} // RVA: 0xB465B0
        public void set_Previous(){} // RVA: 0xBA9BA0
        public void get_Path(){} // RVA: 0x81AC3B0
        public void .ctor(){} // RVA: 0xB43310
        public void get_First(){} // RVA: 0x81AC7A0
        public void get_Last(){} // RVA: 0x81AC840
        public void Children(){} // RVA: 0x81AC8E0
        public void Remove(){} // RVA: 0x81AC940
        public void Replace(){} // RVA: 0x81AC9C0
        public void WriteTo(){} // RVA: 0x8943B0
        public void ToString(){} // RVA: 0x81ACA90
        public void EnsureValue(){} // RVA: 0x81ACCE0
        public void GetType(){} // RVA: 0x81ACE40
        public void ValidateToken(){} // RVA: 0x81ACFA0
        public void op_Explicit(){} // RVA: 0x81B28D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x81B2B50
        public void System.Collections.Generic.IEnumerable<Valve.Newtonsoft.Json.Linq.JToken>.GetEnumerator(){} // RVA: 0x81B2B90
        public void CreateReader(){} // RVA: 0x81B2C20
        public void ToObject(){} // RVA: 0x81B3CC0
        public void ReadFrom(){} // RVA: 0x81B3EA0
        public void SetLineInfo(){} // RVA: 0x81B4320
        public void Valve.Newtonsoft.Json.IJsonLineInfo.HasLineInfo(){} // RVA: 0x81B4390
        public void Valve.Newtonsoft.Json.IJsonLineInfo.get_LineNumber(){} // RVA: 0x81B43D0
        public void Valve.Newtonsoft.Json.IJsonLineInfo.get_LinePosition(){} // RVA: 0x81B4420
        public void System.ICloneable.Clone(){} // RVA: 0x11F4110
        public void DeepClone(){} // RVA: 0x11F4110
        public void AddAnnotation(){} // RVA: 0x81B4470
        public void Annotation(){} // RVA: 0xA94080
        public void .cctor(){} // RVA: 0x81B47B0
    }

    public class JTokenReader : JsonReader
    {
        public object _root;
        public object _initialPath;
        public object _parent;
        public object _current;

        // ── Methods ──
        public void get_CurrentToken(){} // RVA: 0x1069350
        public void .ctor(){} // RVA: 0x81B5030
        public void Read(){} // RVA: 0x81B5120
        public void ReadOver(){} // RVA: 0x81B5360
        public void ReadToEnd(){} // RVA: 0x81B5450
        public void GetEndToken(){} // RVA: 0x81B54D0
        public void ReadInto(){} // RVA: 0x81B5630
        public void SetEnd(){} // RVA: 0x81B5760
        public void SetToken(){} // RVA: 0x81B59C0
        public void SafeToString(){} // RVA: 0x6AC02A0
        public void Valve.Newtonsoft.Json.IJsonLineInfo.HasLineInfo(){} // RVA: 0x81B6070
        public void Valve.Newtonsoft.Json.IJsonLineInfo.get_LineNumber(){} // RVA: 0x81B60D0
        public void Valve.Newtonsoft.Json.IJsonLineInfo.get_LinePosition(){} // RVA: 0x81B6130
        public void get_Path(){} // RVA: 0x81B6190
    }

    public class JTokenWriter : JsonWriter
    {
        public object _token;
        public object _parent;
        public object _value;
        public object _current;

        // ── Methods ──
        public void get_Token(){} // RVA: 0x6AC0790
        public void .ctor(){} // RVA: 0x81B6420
        public void Close(){} // RVA: 0x81B6480
        public void WriteStartObject(){} // RVA: 0x81B6490
        public void AddParent(){} // RVA: 0x81B6510
        public void RemoveParent(){} // RVA: 0x81B66D0
        public void WriteStartArray(){} // RVA: 0x81B6830
        public void WriteStartConstructor(){} // RVA: 0x81B68B0
        public void WriteEnd(){} // RVA: 0x81B66D0
        public void WritePropertyName(){} // RVA: 0x81B6940
        public void AddValue(){} // RVA: 0x81B6B70
        public void WriteNull(){} // RVA: 0x81B6D70
        public void WriteUndefined(){} // RVA: 0x81B6DB0
        public void WriteRaw(){} // RVA: 0x81B6DF0
        public void WriteComment(){} // RVA: 0x81B6E70
        public void WriteValue(){} // RVA: 0x81B77B0
        public void WriteToken(){} // RVA: 0x81B7850
    }

    public class JValue : JToken
    {
        public object _valueType;
        public object _value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x81B7CC0
        public void get_HasValues(){} // RVA: 0xB43320
        public void Compare(){} // RVA: 0x81B7D00
        public void CompareFloat(){} // RVA: 0x81B88F0
        public void CloneToken(){} // RVA: 0x81B8AC0
        public void CreateComment(){} // RVA: 0x81B8B90
        public void CreateNull(){} // RVA: 0x81B8BF0
        public void CreateUndefined(){} // RVA: 0x81B8C50
        public void GetValueType(){} // RVA: 0x81B8CB0
        public void GetStringValueType(){} // RVA: 0x81B9160
        public void get_Type(){} // RVA: 0xB9E080
        public void get_Value(){} // RVA: 0xD05CA0
        public void WriteTo(){} // RVA: 0x81B91D0
        public void ValuesEquals(){} // RVA: 0x81B9B70
        public void Equals(){} // RVA: 0x81B9C10
        public void GetHashCode(){} // RVA: 0x6AC6C30
        public void ToString(){} // RVA: 0x81B9DA0
        public void System.IComparable.CompareTo(){} // RVA: 0x81B9E70
        public void CompareTo(){} // RVA: 0x81B9F30
        public void System.IConvertible.GetTypeCode(){} // RVA: 0x81B9F50
        public void System.IConvertible.ToBoolean(){} // RVA: 0x81B9FC0
        public void System.IConvertible.ToChar(){} // RVA: 0x81BA010
        public void System.IConvertible.ToSByte(){} // RVA: 0x81BA060
        public void System.IConvertible.ToByte(){} // RVA: 0x81BA0B0
        public void System.IConvertible.ToInt16(){} // RVA: 0x81BA100
        public void System.IConvertible.ToUInt16(){} // RVA: 0x81BA150
        public void System.IConvertible.ToInt32(){} // RVA: 0x81BA1A0
        public void System.IConvertible.ToUInt32(){} // RVA: 0x81BA1F0
        public void System.IConvertible.ToInt64(){} // RVA: 0x81BA240
        public void System.IConvertible.ToUInt64(){} // RVA: 0x81BA290
        public void System.IConvertible.ToSingle(){} // RVA: 0x81BA2E0
        public void System.IConvertible.ToDouble(){} // RVA: 0x81BA330
        public void System.IConvertible.ToDecimal(){} // RVA: 0x81BA380
        public void System.IConvertible.ToDateTime(){} // RVA: 0x81BA3F0
        public void System.IConvertible.ToType(){} // RVA: 0x81BA440
    }

    public class JsonLoadSettings : Object
    {
        public object _commentHandling;
        public object _lineInfoHandling;

        // ── Methods ──
        public void get_CommentHandling(){} // RVA: 0xB8F8F0
        public void get_LineInfoHandling(){} // RVA: 0x116A650
    }

}