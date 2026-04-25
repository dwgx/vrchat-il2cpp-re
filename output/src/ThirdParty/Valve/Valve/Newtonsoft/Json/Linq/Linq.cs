// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.Newtonsoft.Json.Linq
// Classes: 13
// Methods: 330

namespace ThirdParty.Valve.Valve.Newtonsoft.Json.Linq
{
    public class JArray : JContainer
    {
        public System.Collections.Generic.List`1<Valve.Newtonsoft.Json.Linq.JToken> ChildrenTokens; // 0x40

        // ── Methods ──
        public void get_ChildrenTokens(){} // RVA: 0x7FFAC2F9E740
        public void get_Type(){} // RVA: 0x7FFAC3026CB0
        public void .ctor(){} // RVA: 0x7FFAC9D037A0 | overloaded x3
        public void CloneToken(){} // RVA: 0x7FFAC9D038B0
        public void Load(){} // RVA: 0x7FFAC9D039C0
        public void WriteTo(){} // RVA: 0x7FFAC9D03BE0
        public void get_Item(){} // RVA: 0x7FFAC9D03D00
        public void set_Item(){} // RVA: 0x7FFAC9D03D20
        public void IndexOfItem(){} // RVA: 0x7FFAC9D03D40
        public void IndexOf(){} // RVA: 0x7FFAC9D03DF0
        public void Insert(){} // RVA: 0x7FFAC9D03E10
        public void RemoveAt(){} // RVA: 0x7FFAC91F0310
        public void GetEnumerator(){} // RVA: 0x7FFAC9D03E40
        public void Add(){} // RVA: 0x7FFAC9D03ED0
        public void Clear(){} // RVA: 0x7FFAC9D03EF0
        public void Contains(){} // RVA: 0x7FFAC9D03F10
        public void CopyTo(){} // RVA: 0x7FFAC9D03F30
        public void get_IsReadOnly(){} // RVA: 0x7FFAC2F21320
        public void Remove(){} // RVA: 0x7FFAC9D03F50
    }

    public class JConstructor : JContainer
    {
        public string ChildrenTokens; // 0x40
        public System.Collections.Generic.List`1<Valve.Newtonsoft.Json.Linq.JToken> Name; // 0x48

        // ── Methods ──
        public void get_ChildrenTokens(){} // RVA: 0x7FFAC2F9C730
        public void IndexOfItem(){} // RVA: 0x7FFAC9D03F70
        public void get_Name(){} // RVA: 0x7FFAC2F9E740
        public void get_Type(){} // RVA: 0x7FFAC366FE20
        public void .ctor(){} // RVA: 0x7FFAC9D04160 | overloaded x2
        public void CloneToken(){} // RVA: 0x7FFAC9D04360
        public void WriteTo(){} // RVA: 0x7FFAC9D044D0
        public void Load(){} // RVA: 0x7FFAC9D04740
    }

    public class JContainer : JToken
    {
        public object ChildrenTokens; // 0x30
        public bool HasValues; // 0x38

        // ── Methods ──
        public void get_ChildrenTokens(){} // RVA: 0x7FFAC2C58E90
        public void .ctor(){} // RVA: 0x7FFAC9D04A10 | overloaded x2
        public void CheckReentrancy(){} // RVA: 0x7FFAC9D04C70
        public void get_HasValues(){} // RVA: 0x7FFAC9D04D20
        public void get_First(){} // RVA: 0x7FFAC9D04D90
        public void get_Last(){} // RVA: 0x7FFAC9D04E30
        public void Children(){} // RVA: 0x7FFAC9D04ED0
        public void IsMultiContent(){} // RVA: 0x7FFAC9D04FF0
        public void EnsureParentToken(){} // RVA: 0x7FFAC9D050D0
        public void IndexOfItem(){} // RVA: 0x7FFAC2C5E6B0
        public void InsertItem(){} // RVA: 0x7FFAC9D051B0
        public void RemoveItemAt(){} // RVA: 0x7FFAC9D05480
        public void RemoveItem(){} // RVA: 0x7FFAC9D056C0
        public void GetItem(){} // RVA: 0x7FFAC9D05710
        public void SetItem(){} // RVA: 0x7FFAC9D05780
        public void ClearItems(){} // RVA: 0x7FFAC9D05AC0
        public void ReplaceItem(){} // RVA: 0x7FFAC9D05DE0
        public void ContainsItem(){} // RVA: 0x7FFAC9D05E40
        public void CopyItemsTo(){} // RVA: 0x7FFAC9D05E70
        public void IsTokenUnchanged(){} // RVA: 0x7FFAC9D06160
        public void ValidateToken(){} // RVA: 0x7FFAC9D06250
        public void Add(){} // RVA: 0x7FFAC9D063B0
        public void AddAndSkipParentCheck(){} // RVA: 0x7FFAC9D06440
        public void AddInternal(){} // RVA: 0x7FFAC9D064D0
        public void CreateFromContent(){} // RVA: 0x7FFAC9D06790
        public void RemoveAll(){} // RVA: 0x7FFAC9D03EF0
        public void ReadTokenFrom(){} // RVA: 0x7FFAC9D06850
        public void ReadContentFrom(){} // RVA: 0x7FFAC9D06A10
        public void System.Collections.Generic.IList<Valve.Newtonsoft.Json.Linq.JToken>.IndexOf(){} // RVA: 0x7FFAC9D03DF0
        public void System.Collections.Generic.IList<Valve.Newtonsoft.Json.Linq.JToken>.Insert(){} // RVA: 0x7FFAC9D03E10
        public void System.Collections.Generic.IList<Valve.Newtonsoft.Json.Linq.JToken>.RemoveAt(){} // RVA: 0x7FFAC91F0310
        public void System.Collections.Generic.IList<Valve.Newtonsoft.Json.Linq.JToken>.get_Item(){} // RVA: 0x7FFAC9D03D00
        public void System.Collections.Generic.IList<Valve.Newtonsoft.Json.Linq.JToken>.set_Item(){} // RVA: 0x7FFAC9D03D20
        public void System.Collections.Generic.ICollection<Valve.Newtonsoft.Json.Linq.JToken>.Add(){} // RVA: 0x7FFAC9D03ED0
        public void System.Collections.Generic.ICollection<Valve.Newtonsoft.Json.Linq.JToken>.Clear(){} // RVA: 0x7FFAC9D03EF0
        public void System.Collections.Generic.ICollection<Valve.Newtonsoft.Json.Linq.JToken>.Contains(){} // RVA: 0x7FFAC9D03F10
        public void System.Collections.Generic.ICollection<Valve.Newtonsoft.Json.Linq.JToken>.CopyTo(){} // RVA: 0x7FFAC9D03F30
        public void System.Collections.Generic.ICollection<Valve.Newtonsoft.Json.Linq.JToken>.get_IsReadOnly(){} // RVA: 0x7FFAC2F21320
        public void System.Collections.Generic.ICollection<Valve.Newtonsoft.Json.Linq.JToken>.Remove(){} // RVA: 0x7FFAC9D03F50
        public void EnsureValue(){} // RVA: 0x7FFAC9D07240
        public void System.Collections.IList.Add(){} // RVA: 0x7FFAC9D07300
        public void System.Collections.IList.Clear(){} // RVA: 0x7FFAC9D03EF0
        public void System.Collections.IList.Contains(){} // RVA: 0x7FFAC9D07390
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7FFAC9D073C0
        public void System.Collections.IList.Insert(){} // RVA: 0x7FFAC9D073F0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7FFAC2F21320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7FFAC2F21320
        public void System.Collections.IList.Remove(){} // RVA: 0x7FFAC9D07440
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x7FFAC91F0310
        public void System.Collections.IList.get_Item(){} // RVA: 0x7FFAC9D03D00
        public void System.Collections.IList.set_Item(){} // RVA: 0x7FFAC9D07470
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAC9D03F30
        public void get_Count(){} // RVA: 0x7FFAC9D074C0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAC2F21320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAC9D07530
    }

    public class JEnumerable`1 : ValueType
    {
        public Valve.Newtonsoft.Json.Linq.JEnumerable`1<T> Empty;
        public System.Collections.Generic.IEnumerable`1<T> _enumerable;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70A40
        public void GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void Equals(){} // RVA: 0x7FFAC2C59F60 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC2C59960
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
    }

    public class JObject : JContainer
    {
        public Valve.Newtonsoft.Json.Linq.JPropertyKeyedCollection ChildrenTokens; // 0x40
        public System.ComponentModel.PropertyChangedEventHandler Type; // 0x48

        // ── Methods ──
        public void get_ChildrenTokens(){} // RVA: 0x7FFAC2F9E740
        public void add_PropertyChanged(){} // RVA: 0x7FFAC9D075E0
        public void remove_PropertyChanged(){} // RVA: 0x7FFAC9D076D0
        public void .ctor(){} // RVA: 0x7FFAC9D078A0 | overloaded x2
        public void IndexOfItem(){} // RVA: 0x7FFAC9D07960
        public void InsertItem(){} // RVA: 0x7FFAC9D07A80
        public void ValidateToken(){} // RVA: 0x7FFAC9D07AF0
        public void InternalPropertyChanged(){} // RVA: 0x7FFAC9D07DF0
        public void InternalPropertyChanging(){} // RVA: 0x7FFAC2F21310
        public void CloneToken(){} // RVA: 0x7FFAC9D07E20
        public void get_Type(){} // RVA: 0x7FFAC3013AF0
        public void Property(){} // RVA: 0x7FFAC9D07F10
        public void get_Item(){} // RVA: 0x7FFAC9D07FE0
        public void set_Item(){} // RVA: 0x7FFAC9D080B0
        public void Load(){} // RVA: 0x7FFAC9D08220
        public void WriteTo(){} // RVA: 0x7FFAC9D08490
        public void Add(){} // RVA: 0x7FFAC9D08630
        public void System.Collections.Generic.IDictionary<System.String,Valve.Newtonsoft.Json.Linq.JToken>.ContainsKey(){} // RVA: 0x7FFAC9D086C0
        public void System.Collections.Generic.IDictionary<System.String,Valve.Newtonsoft.Json.Linq.JToken>.get_Keys(){} // RVA: 0x7FFAC9D087A0
        public void Remove(){} // RVA: 0x7FFAC9D08800
        public void TryGetValue(){} // RVA: 0x7FFAC9D088A0
        public void System.Collections.Generic.IDictionary<System.String,Valve.Newtonsoft.Json.Linq.JToken>.get_Values(){} // RVA: 0x7FFAC9D08990
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Valve.Newtonsoft.Json.Linq.JToken>>.Add(){} // RVA: 0x7FFAC9D089D0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Valve.Newtonsoft.Json.Linq.JToken>>.Clear(){} // RVA: 0x7FFAC9D03EF0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Valve.Newtonsoft.Json.Linq.JToken>>.Contains(){} // RVA: 0x7FFAC9D08A80
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Valve.Newtonsoft.Json.Linq.JToken>>.CopyTo(){} // RVA: 0x7FFAC9D08B10
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Valve.Newtonsoft.Json.Linq.JToken>>.get_IsReadOnly(){} // RVA: 0x7FFAC2F21320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Valve.Newtonsoft.Json.Linq.JToken>>.Remove(){} // RVA: 0x7FFAC9D08EF0
        public void GetEnumerator(){} // RVA: 0x7FFAC9D09000
        public void OnPropertyChanged(){} // RVA: 0x7FFAC9D090A0
    }

    public class JProperty : JContainer
    {
        public JPropertyList ChildrenTokens; // 0x40
        public string Name; // 0x48

        // ── Methods ──
        public void get_ChildrenTokens(){} // RVA: 0x7FFAC2F9E740
        public void get_Name(){} // RVA: 0x7FFAC2F9C730
        public void get_Value(){} // RVA: 0x7FFAC9D096B0
        public void set_Value(){} // RVA: 0x7FFAC9D096D0
        public void .ctor(){} // RVA: 0x7FFAC9D0A130 | overloaded x3
        public void GetItem(){} // RVA: 0x7FFAC9D098B0
        public void SetItem(){} // RVA: 0x7FFAC9D09920
        public void RemoveItem(){} // RVA: 0x7FFAC9D09A80
        public void RemoveItemAt(){} // RVA: 0x7FFAC9D09B40
        public void IndexOfItem(){} // RVA: 0x7FFAC9D09C00
        public void InsertItem(){} // RVA: 0x7FFAC9D09C30
        public void ContainsItem(){} // RVA: 0x7FFAC9D09D50
        public void ClearItems(){} // RVA: 0x7FFAC9D09D70
        public void CloneToken(){} // RVA: 0x7FFAC9D09E30
        public void get_Type(){} // RVA: 0x7FFAC36C3910
        public void WriteTo(){} // RVA: 0x7FFAC9D0A4A0
        public void Load(){} // RVA: 0x7FFAC9D0A540
    }

    public class JPropertyKeyedCollection : Collection`1
    {
        public System.Collections.Generic.IEqualityComparer`1<string> Keys;
        public System.Collections.Generic.Dictionary`2<string,Valve.Newtonsoft.Json.Linq.JToken> _dictionary; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9D0A970
        public void AddKey(){} // RVA: 0x7FFAC9D0AA50
        public void ClearItems(){} // RVA: 0x7FFAC9D0AAE0
        public void Contains(){} // RVA: 0x7FFAC9D0AB90
        public void EnsureDictionary(){} // RVA: 0x7FFAC9D0AC60
        public void GetKeyForItem(){} // RVA: 0x7FFAC9D0AD70
        public void InsertItem(){} // RVA: 0x7FFAC9D0ADF0
        public void RemoveItem(){} // RVA: 0x7FFAC9D0AEC0
        public void RemoveKey(){} // RVA: 0x7FFAC9D0B040
        public void SetItem(){} // RVA: 0x7FFAC9D0B0A0
        public void TryGetValue(){} // RVA: 0x7FFAC9D0B310
        public void get_Keys(){} // RVA: 0x7FFAC9D0B3E0
        public void IndexOfReference(){} // RVA: 0x7FFAC9D0B440
        public void .cctor(){} // RVA: 0x7FFAC9D0B550
    }

    public class JRaw : JValue
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9D0B6E0 | overloaded x2
        public void Create(){} // RVA: 0x7FFAC9D0B6F0
        public void CloneToken(){} // RVA: 0x7FFAC9D0BA00
    }

    public class JToken : Object
    {
        public Valve.Newtonsoft.Json.Linq.JContainer Parent; // 0x10
        public Valve.Newtonsoft.Json.Linq.JToken Root; // 0x18
        public Valve.Newtonsoft.Json.Linq.JToken Type; // 0x20
        public object HasValues; // 0x28
        public 0x6B2482C8[] Next;
        public 0x6B2482C8[] Previous; // 0x8
        public 0x6B2482C8[] Path; // 0x10
        public 0x6B2482C8[] First; // 0x18
        public 0x6B2482C8[] Last; // 0x20
        public 0x6B2482C8[] Valve.Newtonsoft.Json.IJsonLineInfo.LineNumber; // 0x28
        public 0x6B2482C8[] Valve.Newtonsoft.Json.IJsonLineInfo.LinePosition; // 0x30
        public 0x6B2482C8[] DateTimeTypes; // 0x38
        public 0x6B2482C8[] BytesTypes; // 0x40

        // ── Methods ──
        public void get_Parent(){} // RVA: 0x7FFAC2F3C380
        public void set_Parent(){} // RVA: 0x7FFAC2F22E30
        public void get_Root(){} // RVA: 0x7FFAC87D3860
        public void CloneToken(){} // RVA: 0x7FFAC2C58E90
        public void get_Type(){} // RVA: 0x7FFAC2C59960
        public void get_HasValues(){} // RVA: 0x7FFAC2C59D00
        public void get_Next(){} // RVA: 0x7FFAC2F4F0C0
        public void set_Next(){} // RVA: 0x7FFAC2F4F0D0
        public void get_Previous(){} // RVA: 0x7FFAC2F247C0
        public void set_Previous(){} // RVA: 0x7FFAC2F87E80
        public void get_Path(){} // RVA: 0x7FFAC9D0BAD0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_First(){} // RVA: 0x7FFAC9D0BF00
        public void get_Last(){} // RVA: 0x7FFAC9D0BFA0
        public void Children(){} // RVA: 0x7FFAC9D0C040
        public void Remove(){} // RVA: 0x7FFAC9D0C0A0
        public void Replace(){} // RVA: 0x7FFAC9D0C120
        public void WriteTo(){} // RVA: 0x7FFAC2C79B30
        public void ToString(){} // RVA: 0x7FFAC9D0C1F0 | overloaded x2
        public void EnsureValue(){} // RVA: 0x7FFAC9D0C440
        public void GetType(){} // RVA: 0x7FFAC9D0C5A0
        public void ValidateToken(){} // RVA: 0x7FFAC9D0C700
        public void op_Explicit(){} // RVA: 0x7FFAC9D12020 | overloaded x36
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC9D12300
        public void System.Collections.Generic.IEnumerable<Valve.Newtonsoft.Json.Linq.JToken>.GetEnumerator(){} // RVA: 0x7FFAC9D12340
        public void CreateReader(){} // RVA: 0x7FFAC9D123D0
        public void ToObject(){} // RVA: 0x7FFAC9D13540 | overloaded x2
        public void ReadFrom(){} // RVA: 0x7FFAC9D13710 | overloaded x2
        public void SetLineInfo(){} // RVA: 0x7FFAC9D13B90 | overloaded x2
        public void Valve.Newtonsoft.Json.IJsonLineInfo.HasLineInfo(){} // RVA: 0x7FFAC9D13C00
        public void Valve.Newtonsoft.Json.IJsonLineInfo.get_LineNumber(){} // RVA: 0x7FFAC9D13C50
        public void Valve.Newtonsoft.Json.IJsonLineInfo.get_LinePosition(){} // RVA: 0x7FFAC9D13CA0
        public void System.ICloneable.Clone(){} // RVA: 0x7FFAC3F5BE50
        public void DeepClone(){} // RVA: 0x7FFAC3F5BE50
        public void AddAnnotation(){} // RVA: 0x7FFAC9D13CF0
        public void Annotation(){} // RVA: 0x7FFAC2E8DC40
        public void .cctor(){} // RVA: 0x7FFAC9D14030
    }

    public class JTokenReader : JsonReader
    {
        public Valve.Newtonsoft.Json.Linq.JToken CurrentToken; // 0x78
        public string Valve.Newtonsoft.Json.IJsonLineInfo.LineNumber; // 0x80
        public Valve.Newtonsoft.Json.Linq.JToken Valve.Newtonsoft.Json.IJsonLineInfo.LinePosition; // 0x88
        public Valve.Newtonsoft.Json.Linq.JToken Path; // 0x90

        // ── Methods ──
        public void get_CurrentToken(){} // RVA: 0x7FFAC32EF640
        public void .ctor(){} // RVA: 0x7FFAC9D148B0
        public void Read(){} // RVA: 0x7FFAC9D149A0
        public void ReadOver(){} // RVA: 0x7FFAC9D14BF0
        public void ReadToEnd(){} // RVA: 0x7FFAC9D14CE0
        public void GetEndToken(){} // RVA: 0x7FFAC9D14DE0
        public void ReadInto(){} // RVA: 0x7FFAC9D14F40
        public void SetEnd(){} // RVA: 0x7FFAC9D15070
        public void SetToken(){} // RVA: 0x7FFAC9D152D0
        public void SafeToString(){} // RVA: 0x7FFAC87E38C0
        public void Valve.Newtonsoft.Json.IJsonLineInfo.HasLineInfo(){} // RVA: 0x7FFAC9D15E10
        public void Valve.Newtonsoft.Json.IJsonLineInfo.get_LineNumber(){} // RVA: 0x7FFAC9D15E70
        public void Valve.Newtonsoft.Json.IJsonLineInfo.get_LinePosition(){} // RVA: 0x7FFAC9D15ED0
        public void get_Path(){} // RVA: 0x7FFAC9D15F30
    }

    public class JTokenWriter : JsonWriter
    {
        public Valve.Newtonsoft.Json.Linq.JContainer Token; // 0x60
        public Valve.Newtonsoft.Json.Linq.JContainer _parent; // 0x68
        public Valve.Newtonsoft.Json.Linq.JValue _value; // 0x70
        public Valve.Newtonsoft.Json.Linq.JToken _current; // 0x78

        // ── Methods ──
        public void get_Token(){} // RVA: 0x7FFAC87E3DC0
        public void .ctor(){} // RVA: 0x7FFAC9D161D0
        public void Close(){} // RVA: 0x7FFAC9D16230
        public void WriteStartObject(){} // RVA: 0x7FFAC9D16240
        public void AddParent(){} // RVA: 0x7FFAC9D162C0
        public void RemoveParent(){} // RVA: 0x7FFAC9D16480
        public void WriteStartArray(){} // RVA: 0x7FFAC9D165E0
        public void WriteStartConstructor(){} // RVA: 0x7FFAC9D16660
        public void WriteEnd(){} // RVA: 0x7FFAC9D16480
        public void WritePropertyName(){} // RVA: 0x7FFAC9D166F0
        public void AddValue(){} // RVA: 0x7FFAC9D16930 | overloaded x2
        public void WriteNull(){} // RVA: 0x7FFAC9D16B30
        public void WriteUndefined(){} // RVA: 0x7FFAC9D16B70
        public void WriteRaw(){} // RVA: 0x7FFAC9D16BB0
        public void WriteComment(){} // RVA: 0x7FFAC9D16C30
        public void WriteValue(){} // RVA: 0x7FFAC9D17710 | overloaded x20
        public void WriteToken(){} // RVA: 0x7FFAC9D177B0
    }

    public class JValue : JToken
    {
        public 0x6B2482C8 HasValues; // 0x30
        public object Type; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9D17C30 | overloaded x3
        public void get_HasValues(){} // RVA: 0x7FFAC2F21320
        public void Compare(){} // RVA: 0x7FFAC9D17C70
        public void CompareFloat(){} // RVA: 0x7FFAC9D18890
        public void CloneToken(){} // RVA: 0x7FFAC9D18A60
        public void CreateComment(){} // RVA: 0x7FFAC9D18B30
        public void CreateNull(){} // RVA: 0x7FFAC9D18B90
        public void CreateUndefined(){} // RVA: 0x7FFAC9D18BF0
        public void GetValueType(){} // RVA: 0x7FFAC9D18C50
        public void GetStringValueType(){} // RVA: 0x7FFAC9D191E0
        public void get_Type(){} // RVA: 0x7FFAC2F7CCD0
        public void get_Value(){} // RVA: 0x7FFAC31D0140
        public void WriteTo(){} // RVA: 0x7FFAC9D19250
        public void ValuesEquals(){} // RVA: 0x7FFAC9D19C70
        public void Equals(){} // RVA: 0x7FFAC9D19D10 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC87EA690
        public void ToString(){} // RVA: 0x7FFAC9D19F20 | overloaded x3
        public void System.IComparable.CompareTo(){} // RVA: 0x7FFAC9D1A000
        public void CompareTo(){} // RVA: 0x7FFAC9D1A0C0
        public void System.IConvertible.GetTypeCode(){} // RVA: 0x7FFAC9D1A0E0
        public void System.IConvertible.ToBoolean(){} // RVA: 0x7FFAC9D1A150
        public void System.IConvertible.ToChar(){} // RVA: 0x7FFAC9D1A1A0
        public void System.IConvertible.ToSByte(){} // RVA: 0x7FFAC9D1A1F0
        public void System.IConvertible.ToByte(){} // RVA: 0x7FFAC9D1A240
        public void System.IConvertible.ToInt16(){} // RVA: 0x7FFAC9D1A290
        public void System.IConvertible.ToUInt16(){} // RVA: 0x7FFAC9D1A2E0
        public void System.IConvertible.ToInt32(){} // RVA: 0x7FFAC9D1A330
        public void System.IConvertible.ToUInt32(){} // RVA: 0x7FFAC9D1A380
        public void System.IConvertible.ToInt64(){} // RVA: 0x7FFAC9D1A3D0
        public void System.IConvertible.ToUInt64(){} // RVA: 0x7FFAC9D1A420
        public void System.IConvertible.ToSingle(){} // RVA: 0x7FFAC9D1A470
        public void System.IConvertible.ToDouble(){} // RVA: 0x7FFAC9D1A4C0
        public void System.IConvertible.ToDecimal(){} // RVA: 0x7FFAC9D1A510
        public void System.IConvertible.ToDateTime(){} // RVA: 0x7FFAC9D1A580
        public void System.IConvertible.ToType(){} // RVA: 0x7FFAC9D1A5D0
    }

    public class JsonLoadSettings : Object
    {
        public 0x6B247CF0 CommentHandling; // 0x10
        public 0x6B247D48 LineInfoHandling; // 0x14

        // ── Methods ──
        public void get_CommentHandling(){} // RVA: 0x7FFAC2F6E5C0
        public void get_LineInfoHandling(){} // RVA: 0x7FFAC33D5A20
    }

}