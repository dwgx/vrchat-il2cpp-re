// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.Newtonsoft.Json.Linq
// Classes: 13
// Methods: 330

namespace ThirdParty.Valve.Valve.Newtonsoft.Json.Linq
{
    public class JArray : JContainer
    {
        public System.Collections.Generic.List`1<Valve.Newtonsoft.Json.Linq.JToken> _values; // 0x40
        public object field_1; // 0x106
        public object field_2; // 0x107
        public object field_3; // 0x108

        // ── Methods ──
        public void get_ChildrenTokens(){} // RVA: 0x7FFE81178740
        public void get_Type(){} // RVA: 0x7FFE81200CB0
        public void .ctor(){} // RVA: 0x7FFE880ABFB0 | overloaded x3
        public void CloneToken(){} // RVA: 0x7FFE880AC0C0
        public void Load(){} // RVA: 0x7FFE880AC1D0
        public void WriteTo(){} // RVA: 0x7FFE880AC3F0
        public void get_Item(){} // RVA: 0x7FFE880AC510
        public void set_Item(){} // RVA: 0x7FFE880AC530
        public void IndexOfItem(){} // RVA: 0x7FFE880AC550
        public void IndexOf(){} // RVA: 0x7FFE880AC600
        public void Insert(){} // RVA: 0x7FFE880AC620
        public void RemoveAt(){} // RVA: 0x7FFE87598A80
        public void GetEnumerator(){} // RVA: 0x7FFE880AC650
        public void Add(){} // RVA: 0x7FFE880AC6E0
        public void Clear(){} // RVA: 0x7FFE880AC700
        public void Contains(){} // RVA: 0x7FFE880AC720
        public void CopyTo(){} // RVA: 0x7FFE880AC740
        public void get_IsReadOnly(){} // RVA: 0x7FFE810FB320
        public void Remove(){} // RVA: 0x7FFE880AC760
    }

    public class JConstructor : JContainer
    {
        public string _name; // 0x40
        public System.Collections.Generic.List`1<Valve.Newtonsoft.Json.Linq.JToken> _values; // 0x48
        public object field_2; // 0x10A

        // ── Methods ──
        public void get_ChildrenTokens(){} // RVA: 0x7FFE81176730
        public void IndexOfItem(){} // RVA: 0x7FFE880AC780
        public void get_Name(){} // RVA: 0x7FFE81178740
        public void get_Type(){} // RVA: 0x7FFE817BF630
        public void .ctor(){} // RVA: 0x7FFE880AC970 | overloaded x2
        public void CloneToken(){} // RVA: 0x7FFE880ACB70
        public void WriteTo(){} // RVA: 0x7FFE880ACCE0
        public void Load(){} // RVA: 0x7FFE880ACF50
    }

    public class JContainer : JToken
    {
        public object _syncRoot; // 0x30
        public bool _busy; // 0x38
        public object field_2; // 0x10D
        public object field_3; // 0x10E
        public object field_4; // 0x10F
        public object field_5; // 0x110
        public object field_6; // 0x111
        public object field_7; // 0x112
        public object field_8; // 0x113
        public object field_9; // 0x114
        public object field_10; // 0x115
        public object field_11; // 0x116

        // ── Methods ──
        public void get_ChildrenTokens(){} // RVA: 0x7FFE80E2E2E0
        public void .ctor(){} // RVA: 0x7FFE880AD220 | overloaded x2
        public void CheckReentrancy(){} // RVA: 0x7FFE880AD480
        public void get_HasValues(){} // RVA: 0x7FFE880AD530
        public void get_First(){} // RVA: 0x7FFE880AD5A0
        public void get_Last(){} // RVA: 0x7FFE880AD640
        public void Children(){} // RVA: 0x7FFE880AD6E0
        public void IsMultiContent(){} // RVA: 0x7FFE880AD800
        public void EnsureParentToken(){} // RVA: 0x7FFE880AD8E0
        public void IndexOfItem(){} // RVA: 0x7FFE80E33B00
        public void InsertItem(){} // RVA: 0x7FFE880AD9C0
        public void RemoveItemAt(){} // RVA: 0x7FFE880ADC90
        public void RemoveItem(){} // RVA: 0x7FFE880ADED0
        public void GetItem(){} // RVA: 0x7FFE880ADF20
        public void SetItem(){} // RVA: 0x7FFE880ADF90
        public void ClearItems(){} // RVA: 0x7FFE880AE2D0
        public void ReplaceItem(){} // RVA: 0x7FFE880AE5F0
        public void ContainsItem(){} // RVA: 0x7FFE880AE650
        public void CopyItemsTo(){} // RVA: 0x7FFE880AE680
        public void IsTokenUnchanged(){} // RVA: 0x7FFE880AE970
        public void ValidateToken(){} // RVA: 0x7FFE880AEA60
        public void Add(){} // RVA: 0x7FFE880AEBC0
        public void AddAndSkipParentCheck(){} // RVA: 0x7FFE880AEC50
        public void AddInternal(){} // RVA: 0x7FFE880AECE0
        public void CreateFromContent(){} // RVA: 0x7FFE880AEFA0
        public void RemoveAll(){} // RVA: 0x7FFE880AC700
        public void ReadTokenFrom(){} // RVA: 0x7FFE880AF060
        public void ReadContentFrom(){} // RVA: 0x7FFE880AF220
        public void System.Collections.Generic.IList<Valve.Newtonsoft.Json.Linq.JToken>.IndexOf(){} // RVA: 0x7FFE880AC600
        public void System.Collections.Generic.IList<Valve.Newtonsoft.Json.Linq.JToken>.Insert(){} // RVA: 0x7FFE880AC620
        public void System.Collections.Generic.IList<Valve.Newtonsoft.Json.Linq.JToken>.RemoveAt(){} // RVA: 0x7FFE87598A80
        public void System.Collections.Generic.IList<Valve.Newtonsoft.Json.Linq.JToken>.get_Item(){} // RVA: 0x7FFE880AC510
        public void System.Collections.Generic.IList<Valve.Newtonsoft.Json.Linq.JToken>.set_Item(){} // RVA: 0x7FFE880AC530
        public void System.Collections.Generic.ICollection<Valve.Newtonsoft.Json.Linq.JToken>.Add(){} // RVA: 0x7FFE880AC6E0
        public void System.Collections.Generic.ICollection<Valve.Newtonsoft.Json.Linq.JToken>.Clear(){} // RVA: 0x7FFE880AC700
        public void System.Collections.Generic.ICollection<Valve.Newtonsoft.Json.Linq.JToken>.Contains(){} // RVA: 0x7FFE880AC720
        public void System.Collections.Generic.ICollection<Valve.Newtonsoft.Json.Linq.JToken>.CopyTo(){} // RVA: 0x7FFE880AC740
        public void System.Collections.Generic.ICollection<Valve.Newtonsoft.Json.Linq.JToken>.get_IsReadOnly(){} // RVA: 0x7FFE810FB320
        public void System.Collections.Generic.ICollection<Valve.Newtonsoft.Json.Linq.JToken>.Remove(){} // RVA: 0x7FFE880AC760
        public void EnsureValue(){} // RVA: 0x7FFE880AFA50
        public void System.Collections.IList.Add(){} // RVA: 0x7FFE880AFB10
        public void System.Collections.IList.Clear(){} // RVA: 0x7FFE880AC700
        public void System.Collections.IList.Contains(){} // RVA: 0x7FFE880AFBA0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7FFE880AFBD0
        public void System.Collections.IList.Insert(){} // RVA: 0x7FFE880AFC00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7FFE810FB320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7FFE810FB320
        public void System.Collections.IList.Remove(){} // RVA: 0x7FFE880AFC50
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x7FFE87598A80
        public void System.Collections.IList.get_Item(){} // RVA: 0x7FFE880AC510
        public void System.Collections.IList.set_Item(){} // RVA: 0x7FFE880AFC80
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFE880AC740
        public void get_Count(){} // RVA: 0x7FFE880AFCD0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFE810FB320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFE880AFD40
    }

    public class JEnumerable`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E460A0
        public void GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void Equals(){} // RVA: 0x7FFE80E2F3B0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE80E2EDB0
        public void .cctor(){} // RVA: 0x7FFE80E46010
    }

    public class JObject : JContainer
    {
        public Valve.Newtonsoft.Json.Linq.JPropertyKeyedCollection _properties; // 0x40
        public System.ComponentModel.PropertyChangedEventHandler PropertyChanged; // 0x48
        public object PropertyChanged; // 0x3
        public object ChildrenTokens;
        public TM Type;
        public ulong Type; // 0xBC18

        // ── Methods ──
        public void get_ChildrenTokens(){} // RVA: 0x7FFE81178740
        public void add_PropertyChanged(){} // RVA: 0x7FFE880AFDF0
        public void remove_PropertyChanged(){} // RVA: 0x7FFE880AFEE0
        public void .ctor(){} // RVA: 0x7FFE880B00B0 | overloaded x2
        public void IndexOfItem(){} // RVA: 0x7FFE880B0170
        public void InsertItem(){} // RVA: 0x7FFE880B0290
        public void ValidateToken(){} // RVA: 0x7FFE880B0300
        public void InternalPropertyChanged(){} // RVA: 0x7FFE880B0600
        public void InternalPropertyChanging(){} // RVA: 0x7FFE810FB310
        public void CloneToken(){} // RVA: 0x7FFE880B0630
        public void get_Type(){} // RVA: 0x7FFE811EDAF0
        public void Property(){} // RVA: 0x7FFE880B0720
        public void get_Item(){} // RVA: 0x7FFE880B07F0
        public void set_Item(){} // RVA: 0x7FFE880B08C0
        public void Load(){} // RVA: 0x7FFE880B0A30
        public void WriteTo(){} // RVA: 0x7FFE880B0CA0
        public void Add(){} // RVA: 0x7FFE880B0E40
        public void System.Collections.Generic.IDictionary<System.String,Valve.Newtonsoft.Json.Linq.JToken>.ContainsKey(){} // RVA: 0x7FFE880B0ED0
        public void System.Collections.Generic.IDictionary<System.String,Valve.Newtonsoft.Json.Linq.JToken>.get_Keys(){} // RVA: 0x7FFE880B0FB0
        public void Remove(){} // RVA: 0x7FFE880B1010
        public void TryGetValue(){} // RVA: 0x7FFE880B10B0
        public void System.Collections.Generic.IDictionary<System.String,Valve.Newtonsoft.Json.Linq.JToken>.get_Values(){} // RVA: 0x7FFE880B11A0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Valve.Newtonsoft.Json.Linq.JToken>>.Add(){} // RVA: 0x7FFE880B11E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Valve.Newtonsoft.Json.Linq.JToken>>.Clear(){} // RVA: 0x7FFE880AC700
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Valve.Newtonsoft.Json.Linq.JToken>>.Contains(){} // RVA: 0x7FFE880B1290
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Valve.Newtonsoft.Json.Linq.JToken>>.CopyTo(){} // RVA: 0x7FFE880B1320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Valve.Newtonsoft.Json.Linq.JToken>>.get_IsReadOnly(){} // RVA: 0x7FFE810FB320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Valve.Newtonsoft.Json.Linq.JToken>>.Remove(){} // RVA: 0x7FFE880B1700
        public void GetEnumerator(){} // RVA: 0x7FFE880B1810
        public void OnPropertyChanged(){} // RVA: 0x7FFE880B18B0
    }

    public class JProperty : JContainer
    {
        public JPropertyList _content; // 0x40
        public string _name; // 0x48
        public object field_2; // 0x121
        public object field_3; // 0x122

        // ── Methods ──
        public void get_ChildrenTokens(){} // RVA: 0x7FFE81178740
        public void get_Name(){} // RVA: 0x7FFE81176730
        public void get_Value(){} // RVA: 0x7FFE880B1EC0
        public void set_Value(){} // RVA: 0x7FFE880B1EE0
        public void .ctor(){} // RVA: 0x7FFE880B2940 | overloaded x3
        public void GetItem(){} // RVA: 0x7FFE880B20C0
        public void SetItem(){} // RVA: 0x7FFE880B2130
        public void RemoveItem(){} // RVA: 0x7FFE880B2290
        public void RemoveItemAt(){} // RVA: 0x7FFE880B2350
        public void IndexOfItem(){} // RVA: 0x7FFE880B2410
        public void InsertItem(){} // RVA: 0x7FFE880B2440
        public void ContainsItem(){} // RVA: 0x7FFE880B2560
        public void ClearItems(){} // RVA: 0x7FFE880B2580
        public void CloneToken(){} // RVA: 0x7FFE880B2640
        public void get_Type(){} // RVA: 0x7FFE8180E590
        public void WriteTo(){} // RVA: 0x7FFE880B2CB0
        public void Load(){} // RVA: 0x7FFE880B2D50
    }

    public class JPropertyKeyedCollection : Collection`1
    {
        public System.Collections.Generic.IEqualityComparer`1<string> Comparer;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE880B3180
        public void AddKey(){} // RVA: 0x7FFE880B3260
        public void ClearItems(){} // RVA: 0x7FFE880B32F0
        public void Contains(){} // RVA: 0x7FFE880B33A0
        public void EnsureDictionary(){} // RVA: 0x7FFE880B3470
        public void GetKeyForItem(){} // RVA: 0x7FFE880B3580
        public void InsertItem(){} // RVA: 0x7FFE880B3600
        public void RemoveItem(){} // RVA: 0x7FFE880B36D0
        public void RemoveKey(){} // RVA: 0x7FFE880B3850
        public void SetItem(){} // RVA: 0x7FFE880B38B0
        public void TryGetValue(){} // RVA: 0x7FFE880B3B20
        public void get_Keys(){} // RVA: 0x7FFE880B3BF0
        public void IndexOfReference(){} // RVA: 0x7FFE880B3C50
        public void .cctor(){} // RVA: 0x7FFE880B3D60
    }

    public class JRaw : JValue
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE880B3EF0 | overloaded x2
        public void Create(){} // RVA: 0x7FFE880B3F00
        public void CloneToken(){} // RVA: 0x7FFE880B4210
    }

    public class JToken : Object
    {
        public Valve.Newtonsoft.Json.Linq.JContainer _parent; // 0x10
        public Valve.Newtonsoft.Json.Linq.JToken _previous; // 0x18
        public Valve.Newtonsoft.Json.Linq.JToken _next; // 0x20
        public object _annotations; // 0x28
        public 0x66641C94[] BooleanTypes;
        public 0x66641C94[] NumberTypes; // 0x8
        public 0x66641C94[] StringTypes; // 0x10
        public 0x66641C94[] GuidTypes; // 0x18
        public 0x66641C94[] TimeSpanTypes; // 0x20
        public 0x66641C94[] UriTypes; // 0x28
        public 0x66641C94[] CharTypes; // 0x30

        // ── Methods ──
        public void get_Parent(){} // RVA: 0x7FFE81116380
        public void set_Parent(){} // RVA: 0x7FFE810FCE30
        public void get_Root(){} // RVA: 0x7FFE86B7CF90
        public void CloneToken(){} // RVA: 0x7FFE80E2E2E0
        public void get_Type(){} // RVA: 0x7FFE80E2EDB0
        public void get_HasValues(){} // RVA: 0x7FFE80E2F150
        public void get_Next(){} // RVA: 0x7FFE811290C0
        public void set_Next(){} // RVA: 0x7FFE811290D0
        public void get_Previous(){} // RVA: 0x7FFE810FE7C0
        public void set_Previous(){} // RVA: 0x7FFE81161E80
        public void get_Path(){} // RVA: 0x7FFE880B42E0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_First(){} // RVA: 0x7FFE880B4710
        public void get_Last(){} // RVA: 0x7FFE880B47B0
        public void Children(){} // RVA: 0x7FFE880B4850
        public void Remove(){} // RVA: 0x7FFE880B48B0
        public void Replace(){} // RVA: 0x7FFE880B4930
        public void WriteTo(){} // RVA: 0x7FFE80E4F230
        public void ToString(){} // RVA: 0x7FFE880B4A00 | overloaded x2
        public void EnsureValue(){} // RVA: 0x7FFE880B4C50
        public void GetType(){} // RVA: 0x7FFE880B4DB0
        public void ValidateToken(){} // RVA: 0x7FFE880B4F10
        public void op_Explicit(){} // RVA: 0x7FFE880BA830 | overloaded x36
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE880BAB10
        public void System.Collections.Generic.IEnumerable<Valve.Newtonsoft.Json.Linq.JToken>.GetEnumerator(){} // RVA: 0x7FFE880BAB50
        public void CreateReader(){} // RVA: 0x7FFE880BABE0
        public void ToObject(){} // RVA: 0x7FFE880BBD50 | overloaded x2
        public void ReadFrom(){} // RVA: 0x7FFE880BBF20 | overloaded x2
        public void SetLineInfo(){} // RVA: 0x7FFE880BC3A0 | overloaded x2
        public void Valve.Newtonsoft.Json.IJsonLineInfo.HasLineInfo(){} // RVA: 0x7FFE880BC410
        public void Valve.Newtonsoft.Json.IJsonLineInfo.get_LineNumber(){} // RVA: 0x7FFE880BC460
        public void Valve.Newtonsoft.Json.IJsonLineInfo.get_LinePosition(){} // RVA: 0x7FFE880BC4B0
        public void System.ICloneable.Clone(){} // RVA: 0x7FFE844800F0
        public void DeepClone(){} // RVA: 0x7FFE844800F0
        public void AddAnnotation(){} // RVA: 0x7FFE880BC500
        public void Annotation(){} // RVA: 0x7FFE810A1420
        public void .cctor(){} // RVA: 0x7FFE880BC840
    }

    public class JTokenReader : JsonReader
    {
        public Valve.Newtonsoft.Json.Linq.JToken _root; // 0x78
        public string _initialPath; // 0x80
        public Valve.Newtonsoft.Json.Linq.JToken _parent; // 0x88
        public Valve.Newtonsoft.Json.Linq.JToken _current; // 0x90

        // ── Methods ──
        public void get_CurrentToken(){} // RVA: 0x7FFE8154EB60
        public void .ctor(){} // RVA: 0x7FFE880BD0C0
        public void Read(){} // RVA: 0x7FFE880BD1B0
        public void ReadOver(){} // RVA: 0x7FFE880BD400
        public void ReadToEnd(){} // RVA: 0x7FFE880BD4F0
        public void GetEndToken(){} // RVA: 0x7FFE880BD5F0
        public void ReadInto(){} // RVA: 0x7FFE880BD750
        public void SetEnd(){} // RVA: 0x7FFE880BD880
        public void SetToken(){} // RVA: 0x7FFE880BDAE0
        public void SafeToString(){} // RVA: 0x7FFE86B8CFF0
        public void Valve.Newtonsoft.Json.IJsonLineInfo.HasLineInfo(){} // RVA: 0x7FFE880BE620
        public void Valve.Newtonsoft.Json.IJsonLineInfo.get_LineNumber(){} // RVA: 0x7FFE880BE680
        public void Valve.Newtonsoft.Json.IJsonLineInfo.get_LinePosition(){} // RVA: 0x7FFE880BE6E0
        public void get_Path(){} // RVA: 0x7FFE880BE740
    }

    public class JTokenWriter : JsonWriter
    {
        public Valve.Newtonsoft.Json.Linq.JContainer _token; // 0x60

        // ── Methods ──
        public void get_Token(){} // RVA: 0x7FFE86B8D4F0
        public void .ctor(){} // RVA: 0x7FFE880BE9E0
        public void Close(){} // RVA: 0x7FFE880BEA40
        public void WriteStartObject(){} // RVA: 0x7FFE880BEA50
        public void AddParent(){} // RVA: 0x7FFE880BEAD0
        public void RemoveParent(){} // RVA: 0x7FFE880BEC90
        public void WriteStartArray(){} // RVA: 0x7FFE880BEDF0
        public void WriteStartConstructor(){} // RVA: 0x7FFE880BEE70
        public void WriteEnd(){} // RVA: 0x7FFE880BEC90
        public void WritePropertyName(){} // RVA: 0x7FFE880BEF00
        public void AddValue(){} // RVA: 0x7FFE880BF140 | overloaded x2
        public void WriteNull(){} // RVA: 0x7FFE880BF340
        public void WriteUndefined(){} // RVA: 0x7FFE880BF380
        public void WriteRaw(){} // RVA: 0x7FFE880BF3C0
        public void WriteComment(){} // RVA: 0x7FFE880BF440
        public void WriteValue(){} // RVA: 0x7FFE880BFF20 | overloaded x20
        public void WriteToken(){} // RVA: 0x7FFE880BFFC0
    }

    public class JValue : JToken
    {
        public 0x66641C94 _valueType; // 0x30
        public object _value; // 0x38
        public object field_2; // 0x13D

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE880C0440 | overloaded x3
        public void get_HasValues(){} // RVA: 0x7FFE810FB320
        public void Compare(){} // RVA: 0x7FFE880C0480
        public void CompareFloat(){} // RVA: 0x7FFE880C10A0
        public void CloneToken(){} // RVA: 0x7FFE880C1270
        public void CreateComment(){} // RVA: 0x7FFE880C1340
        public void CreateNull(){} // RVA: 0x7FFE880C13A0
        public void CreateUndefined(){} // RVA: 0x7FFE880C1400
        public void GetValueType(){} // RVA: 0x7FFE880C1460
        public void GetStringValueType(){} // RVA: 0x7FFE880C19F0
        public void get_Type(){} // RVA: 0x7FFE81156CD0
        public void get_Value(){} // RVA: 0x7FFE8143BA80
        public void WriteTo(){} // RVA: 0x7FFE880C1A60
        public void ValuesEquals(){} // RVA: 0x7FFE880C2480
        public void Equals(){} // RVA: 0x7FFE880C2520 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE86B93DB0
        public void ToString(){} // RVA: 0x7FFE880C2730 | overloaded x3
        public void System.IComparable.CompareTo(){} // RVA: 0x7FFE880C2810
        public void CompareTo(){} // RVA: 0x7FFE880C28D0
        public void System.IConvertible.GetTypeCode(){} // RVA: 0x7FFE880C28F0
        public void System.IConvertible.ToBoolean(){} // RVA: 0x7FFE880C2960
        public void System.IConvertible.ToChar(){} // RVA: 0x7FFE880C29B0
        public void System.IConvertible.ToSByte(){} // RVA: 0x7FFE880C2A00
        public void System.IConvertible.ToByte(){} // RVA: 0x7FFE880C2A50
        public void System.IConvertible.ToInt16(){} // RVA: 0x7FFE880C2AA0
        public void System.IConvertible.ToUInt16(){} // RVA: 0x7FFE880C2AF0
        public void System.IConvertible.ToInt32(){} // RVA: 0x7FFE880C2B40
        public void System.IConvertible.ToUInt32(){} // RVA: 0x7FFE880C2B90
        public void System.IConvertible.ToInt64(){} // RVA: 0x7FFE880C2BE0
        public void System.IConvertible.ToUInt64(){} // RVA: 0x7FFE880C2C30
        public void System.IConvertible.ToSingle(){} // RVA: 0x7FFE880C2C80
        public void System.IConvertible.ToDouble(){} // RVA: 0x7FFE880C2CD0
        public void System.IConvertible.ToDecimal(){} // RVA: 0x7FFE880C2D20
        public void System.IConvertible.ToDateTime(){} // RVA: 0x7FFE880C2D90
        public void System.IConvertible.ToType(){} // RVA: 0x7FFE880C2DE0
    }

    public class JsonLoadSettings : Object
    {
        public 0x666416BC _commentHandling; // 0x10
        public 0x66641714 _lineInfoHandling; // 0x14

        // ── Methods ──
        public void get_CommentHandling(){} // RVA: 0x7FFE811485C0
        public void get_LineInfoHandling(){} // RVA: 0x7FFE8164B230
    }

}