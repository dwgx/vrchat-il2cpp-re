// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Newtonsoft.Newtonsoft.Json.Linq
// Classes: 20
// Methods: 446

namespace ThirdParty.Newtonsoft.Newtonsoft.Json.Linq
{
    public class Extensions : Object
    {
        // ── Methods ──
        public void Ancestors(){} // RVA: 0x87C5C0
        public void AncestorsAndSelf(){} // RVA: 0x87C5C0
        public void Descendants(){} // RVA: 0x87C5C0
        public void DescendantsAndSelf(){} // RVA: 0x87C5C0
        public void Properties(){} // RVA: 0x6A983A0
        public void Values(){} // RVA: 0x87C630
        public void Value(){} // RVA: 0xA94080
        public void Children(){} // RVA: 0x87C5C0
        public void Convert(){} // RVA: 0xA94080
        public void AsJEnumerable(){} // RVA: 0x87C5C0
    }

    public class IJEnumerable`1
    {
        // ── Methods ──
        public void get_Item(){} // RVA: 0x87C540
    }

    public class JArray : JContainer
    {
        public object _values;

        // ── Methods ──
        public void WriteToAsync(){} // RVA: 0x6A987B0
        public void LoadAsync(){} // RVA: 0x6A98AA0
        public void get_ChildrenTokens(){} // RVA: 0xC0FFC0
        public void get_Type(){} // RVA: 0xC50A80
        public void .ctor(){} // RVA: 0x6A98FD0
        public void DeepEquals(){} // RVA: 0x6A990E0
        public void CloneToken(){} // RVA: 0x6A99170
        public void Load(){} // RVA: 0x6A99290
        public void Parse(){} // RVA: 0x6A994C0
        public void FromObject(){} // RVA: 0x6A997B0
        public void WriteTo(){} // RVA: 0x6A99940
        public void get_Item(){} // RVA: 0x6A99D50
        public void set_Item(){} // RVA: 0x6A99D70
        public void IndexOfItem(){} // RVA: 0x6A99D90
        public void MergeItem(){} // RVA: 0x6A99E40
        public void IndexOf(){} // RVA: 0x6A99F30
        public void Insert(){} // RVA: 0x6A99F50
        public void RemoveAt(){} // RVA: 0x6A99F80
        public void GetEnumerator(){} // RVA: 0x6A99FA0
        public void Add(){} // RVA: 0x6A9A030
        public void Clear(){} // RVA: 0x6A9A050
        public void Contains(){} // RVA: 0x6A9A070
        public void CopyTo(){} // RVA: 0x6A9A090
        public void get_IsReadOnly(){} // RVA: 0xB43320
        public void Remove(){} // RVA: 0x6A9A0B0
        public void GetDeepHashCode(){} // RVA: 0x6A9A0D0
    }

    public class JConstructor : JContainer
    {
        public object _name;
        public object _values;

        // ── Methods ──
        public void WriteToAsync(){} // RVA: 0x6A9B050
        public void LoadAsync(){} // RVA: 0x6A9B340
        public void get_ChildrenTokens(){} // RVA: 0xBE2C60
        public void IndexOfItem(){} // RVA: 0x6A9B590
        public void MergeItem(){} // RVA: 0x6A9B640
        public void get_Name(){} // RVA: 0xC0FFC0
        public void set_Name(){} // RVA: 0xC0FFD0
        public void get_Type(){} // RVA: 0x12FC4A0
        public void .ctor(){} // RVA: 0x6A9BB00
        public void DeepEquals(){} // RVA: 0x6A9BD00
        public void CloneToken(){} // RVA: 0x6A9BDC0
        public void WriteTo(){} // RVA: 0x6A9BF50
        public void get_Item(){} // RVA: 0x6A9C090
        public void set_Item(){} // RVA: 0x6A9C1F0
        public void GetDeepHashCode(){} // RVA: 0x6A9C360
        public void Load(){} // RVA: 0x6A9C3C0
    }

    public class JContainer : JToken
    {
        public object _listChanged;
        public object _addingNew;
        public object _collectionChanged;
        public object _syncRoot;
        public object _busy;

        // ── Methods ──
        public void ReadTokenFromAsync(){} // RVA: 0x6A9D610
        public void ReadContentFromAsync(){} // RVA: 0x6A9D8E0
        public void add_ListChanged(){} // RVA: 0x6A9DBB0
        public void remove_ListChanged(){} // RVA: 0x6A9DCA0
        public void add_AddingNew(){} // RVA: 0x6A9DD90
        public void remove_AddingNew(){} // RVA: 0x6A9DE80
        public void add_CollectionChanged(){} // RVA: 0x6A9DF70
        public void remove_CollectionChanged(){} // RVA: 0x6A9E060
        public void get_ChildrenTokens(){} // RVA: 0x87C0A0
        public void .ctor(){} // RVA: 0x6A9E1A0
        public void CheckReentrancy(){} // RVA: 0x6A9E470
        public void CreateChildrenCollection(){} // RVA: 0x6A9E520
        public void OnAddingNew(){} // RVA: 0x6250040
        public void OnListChanged(){} // RVA: 0x6A9E580
        public void OnCollectionChanged(){} // RVA: 0x6A9E5F0
        public void get_HasValues(){} // RVA: 0x6A9E660
        public void ContentsEqual(){} // RVA: 0x6A9E6D0
        public void get_First(){} // RVA: 0x6A9E830
        public void get_Last(){} // RVA: 0x6A9E8D0
        public void Children(){} // RVA: 0x6A9E970
        public void Values(){} // RVA: 0x87C0A0
        public void Descendants(){} // RVA: 0x6A9EAA0
        public void DescendantsAndSelf(){} // RVA: 0x6A9EAB0
        public void GetDescendants(){} // RVA: 0x6A9EAC0
        public void IsMultiContent(){} // RVA: 0x6A9EB80
        public void EnsureParentToken(){} // RVA: 0x6A9EC50
        public void IndexOfItem(){} // RVA: 0x87D050
        public void InsertItem(){} // RVA: 0x6A9EDA0
        public void RemoveItemAt(){} // RVA: 0x6A9F1D0
        public void RemoveItem(){} // RVA: 0x6A9F560
        public void GetItem(){} // RVA: 0x6A9F5B0
        public void SetItem(){} // RVA: 0x6A9F620
        public void ClearItems(){} // RVA: 0x6A9FAB0
        public void ReplaceItem(){} // RVA: 0x6A9FFA0
        public void ContainsItem(){} // RVA: 0x6AA0000
        public void CopyItemsTo(){} // RVA: 0x6AA0030
        public void IsTokenUnchanged(){} // RVA: 0x6AA0320
        public void ValidateToken(){} // RVA: 0x6AA03E0
        public void Add(){} // RVA: 0x6AA0540
        public void TryAdd(){} // RVA: 0x6AA05D0
        public void AddAndSkipParentCheck(){} // RVA: 0x6AA0660
        public void AddFirst(){} // RVA: 0x6AA06F0
        public void TryAddInternal(){} // RVA: 0x6AA0720
        public void CreateFromContent(){} // RVA: 0x6AA09D0
        public void CreateWriter(){} // RVA: 0x6AA0A90
        public void ReplaceAll(){} // RVA: 0x6AA0C40
        public void RemoveAll(){} // RVA: 0x6A9A050
        public void MergeItem(){} // RVA: 0x8943B0
        public void Merge(){} // RVA: 0x6AA0CE0
        public void ValidateContent(){} // RVA: 0x6AA0D40
        public void ReadTokenFrom(){} // RVA: 0x6AA0EE0
        public void ReadContentFrom(){} // RVA: 0x6AA10A0
        public void ReadProperty(){} // RVA: 0x6AA17B0
        public void ContentsHashCode(){} // RVA: 0x6AA1A30
        public void System.ComponentModel.ITypedList.GetListName(){} // RVA: 0x1584680
        public void System.ComponentModel.ITypedList.GetItemProperties(){} // RVA: 0x6AA1C40
        public void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.IndexOf(){} // RVA: 0x6A99F30
        public void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.Insert(){} // RVA: 0x6A99F50
        public void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.RemoveAt(){} // RVA: 0x6A99F80
        public void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.get_Item(){} // RVA: 0x6A99D50
        public void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.set_Item(){} // RVA: 0x6A99D70
        public void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Add(){} // RVA: 0x6A9A030
        public void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Clear(){} // RVA: 0x6A9A050
        public void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Contains(){} // RVA: 0x6A9A070
        public void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.CopyTo(){} // RVA: 0x6A9A090
        public void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Remove(){} // RVA: 0x6A9A0B0
        public void EnsureValue(){} // RVA: 0x6AA1D10
        public void System.Collections.IList.Add(){} // RVA: 0x6AA1DD0
        public void System.Collections.IList.Clear(){} // RVA: 0x6A9A050
        public void System.Collections.IList.Contains(){} // RVA: 0x6AA1E60
        public void System.Collections.IList.IndexOf(){} // RVA: 0x6AA1E90
        public void System.Collections.IList.Insert(){} // RVA: 0x6AA1EC0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.Remove(){} // RVA: 0x6AA1F20
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x6A99F80
        public void System.Collections.IList.get_Item(){} // RVA: 0x6A99D50
        public void System.Collections.IList.set_Item(){} // RVA: 0x6AA1F50
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x6A9A090
        public void get_Count(){} // RVA: 0x6AA1FA0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x6AA2010
        public void System.ComponentModel.IBindingList.AddIndex(){} // RVA: 0xB43310
        public void System.ComponentModel.IBindingList.AddNew(){} // RVA: 0x6AA20C0
        public void System.ComponentModel.IBindingList.get_AllowEdit(){} // RVA: 0xC2E4C0
        public void System.ComponentModel.IBindingList.get_AllowNew(){} // RVA: 0xC2E4C0
        public void System.ComponentModel.IBindingList.get_AllowRemove(){} // RVA: 0xC2E4C0
        public void System.ComponentModel.IBindingList.ApplySort(){} // RVA: 0x6AA2300
        public void System.ComponentModel.IBindingList.Find(){} // RVA: 0x6AA2340
        public void System.ComponentModel.IBindingList.get_IsSorted(){} // RVA: 0xB43320
        public void System.ComponentModel.IBindingList.RemoveIndex(){} // RVA: 0xB43310
        public void System.ComponentModel.IBindingList.RemoveSort(){} // RVA: 0x6AA2380
        public void System.ComponentModel.IBindingList.get_SortDirection(){} // RVA: 0xDAC980
        public void System.ComponentModel.IBindingList.get_SortProperty(){} // RVA: 0xDAC980
        public void System.ComponentModel.IBindingList.get_SupportsChangeNotification(){} // RVA: 0xC2E4C0
        public void System.ComponentModel.IBindingList.get_SupportsSearching(){} // RVA: 0xB43320
        public void System.ComponentModel.IBindingList.get_SupportsSorting(){} // RVA: 0xB43320
        public void MergeEnumerableContent(){} // RVA: 0x6AA23C0
    }

    public class JEnumerable`1 : ValueType
    {
        public object Empty;
        public object _enumerable;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x894320
        public void GetEnumerator(){} // RVA: 0x87C0A0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x87C0A0
        public void get_Item(){} // RVA: 0x87C540
        public void Equals(){} // RVA: 0x87D350
        public void GetHashCode(){} // RVA: 0x87C130
        public void .cctor(){} // RVA: 0x8942F0
    }

    public class JObject : JContainer
    {
        public object _properties;
        public object PropertyChanged;
        public object PropertyChanging;

        // ── Methods ──
        public void WriteToAsync(){} // RVA: 0x6AA4B90
        public void LoadAsync(){} // RVA: 0x6AA4E00
        public void get_ChildrenTokens(){} // RVA: 0xC0FFC0
        public void add_PropertyChanged(){} // RVA: 0x6AA5050
        public void remove_PropertyChanged(){} // RVA: 0x6AA5140
        public void add_PropertyChanging(){} // RVA: 0x6AA5230
        public void remove_PropertyChanging(){} // RVA: 0x6AA5320
        public void .ctor(){} // RVA: 0x6AA5690
        public void DeepEquals(){} // RVA: 0x6AA5790
        public void IndexOfItem(){} // RVA: 0x6AA5830
        public void InsertItem(){} // RVA: 0x6AA5970
        public void ValidateToken(){} // RVA: 0x6AA59F0
        public void MergeItem(){} // RVA: 0x6AA5CF0
        public void IsNull(){} // RVA: 0x6AA6080
        public void InternalPropertyChanged(){} // RVA: 0x6AA6120
        public void InternalPropertyChanging(){} // RVA: 0x6AA6310
        public void CloneToken(){} // RVA: 0x6AA6340
        public void get_Type(){} // RVA: 0xC3CCE0
        public void Properties(){} // RVA: 0x6AA6440
        public void Property(){} // RVA: 0x6AA6490
        public void PropertyValues(){} // RVA: 0x6AA66C0
        public void get_Item(){} // RVA: 0x6AA6C50
        public void set_Item(){} // RVA: 0x6AA6D20
        public void Load(){} // RVA: 0x6AA6E70
        public void Parse(){} // RVA: 0x6AA70F0
        public void FromObject(){} // RVA: 0x6AA73E0
        public void WriteTo(){} // RVA: 0x6AA7570
        public void GetValue(){} // RVA: 0x6AA7750
        public void TryGetValue(){} // RVA: 0x6AA7AC0
        public void Add(){} // RVA: 0x6AA7820
        public void ContainsKey(){} // RVA: 0x6AA78B0
        public void System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.get_Keys(){} // RVA: 0x6AA79C0
        public void Remove(){} // RVA: 0x6AA7A20
        public void System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.get_Values(){} // RVA: 0x6AA7BB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Add(){} // RVA: 0x6AA7BF0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Clear(){} // RVA: 0x6A9A050
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Contains(){} // RVA: 0x6AA7CA0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.CopyTo(){} // RVA: 0x6AA7D30
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Remove(){} // RVA: 0x6AA8110
        public void GetDeepHashCode(){} // RVA: 0x6A9A0D0
        public void GetEnumerator(){} // RVA: 0x6AA8220
        public void OnPropertyChanged(){} // RVA: 0x6AA82C0
        public void OnPropertyChanging(){} // RVA: 0x6AA8350
        public void System.ComponentModel.ICustomTypeDescriptor.GetProperties(){} // RVA: 0x6AA84A0
        public void System.ComponentModel.ICustomTypeDescriptor.GetAttributes(){} // RVA: 0x6AA8800
        public void System.ComponentModel.ICustomTypeDescriptor.GetClassName(){} // RVA: 0xDAC980
        public void System.ComponentModel.ICustomTypeDescriptor.GetComponentName(){} // RVA: 0xDAC980
        public void System.ComponentModel.ICustomTypeDescriptor.GetConverter(){} // RVA: 0x6AA8860
        public void System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent(){} // RVA: 0xDAC980
        public void System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty(){} // RVA: 0xDAC980
        public void System.ComponentModel.ICustomTypeDescriptor.GetEditor(){} // RVA: 0xDAC980
        public void System.ComponentModel.ICustomTypeDescriptor.GetEvents(){} // RVA: 0x6AA8900
        public void System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(){} // RVA: 0x6AA8960
        public void GetMetaObject(){} // RVA: 0x6AA89E0
        public void <WriteToAsync>g__AwaitProperties|0_0(){} // RVA: 0x6AA8AC0
    }

    public class JProperty : JContainer
    {
        public object _content;
        public object _name;

        // ── Methods ──
        public void WriteToAsync(){} // RVA: 0x6AAAA10
        public void WriteValueAsync(){} // RVA: 0x6AAAD30
        public void LoadAsync(){} // RVA: 0x6AAADB0
        public void get_ChildrenTokens(){} // RVA: 0xC0FFC0
        public void get_Name(){} // RVA: 0xBE2C60
        public void get_Value(){} // RVA: 0x16D92D0
        public void set_Value(){} // RVA: 0x6AAB000
        public void .ctor(){} // RVA: 0x6AABDD0
        public void GetItem(){} // RVA: 0x6AAB330
        public void SetItem(){} // RVA: 0x6AAB3A0
        public void RemoveItem(){} // RVA: 0x6AAB590
        public void RemoveItemAt(){} // RVA: 0x6AAB640
        public void IndexOfItem(){} // RVA: 0x6AAB6F0
        public void InsertItem(){} // RVA: 0x6AAB730
        public void ContainsItem(){} // RVA: 0x6AAB860
        public void MergeItem(){} // RVA: 0x6AAB880
        public void ClearItems(){} // RVA: 0x6AAB930
        public void DeepEquals(){} // RVA: 0x6AAB9E0
        public void CloneToken(){} // RVA: 0x6AABAA0
        public void get_Type(){} // RVA: 0x1347420
        public void WriteTo(){} // RVA: 0x6AAC070
        public void GetDeepHashCode(){} // RVA: 0x6AAC110
        public void Load(){} // RVA: 0x6AAC1A0
    }

    public class JPropertyDescriptor : PropertyDescriptor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6AAD630
        public void CastInstance(){} // RVA: 0x6AAD640
        public void CanResetValue(){} // RVA: 0xB43320
        public void GetValue(){} // RVA: 0x6AAD6C0
        public void ResetValue(){} // RVA: 0xB43310
        public void SetValue(){} // RVA: 0x6AAD810
        public void ShouldSerializeValue(){} // RVA: 0xB43320
        public void get_ComponentType(){} // RVA: 0x6AAD950
        public void get_IsReadOnly(){} // RVA: 0xB43320
        public void get_PropertyType(){} // RVA: 0x6AAD9D0
        public void get_NameHashCode(){} // RVA: 0xFEAE90
    }

    public class JPropertyKeyedCollection : Collection`1
    {
        public object Comparer;
        public object _dictionary;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6AADA30
        public void AddKey(){} // RVA: 0x6AADB10
        public void ChangeItemKey(){} // RVA: 0x6AADBA0
        public void ClearItems(){} // RVA: 0x6AADE00
        public void Contains(){} // RVA: 0x6AADEB0
        public void ContainsItem(){} // RVA: 0x6AADF80
        public void EnsureDictionary(){} // RVA: 0x6AAE060
        public void GetKeyForItem(){} // RVA: 0x6AAE170
        public void InsertItem(){} // RVA: 0x6AAE1F0
        public void Remove(){} // RVA: 0x6AAE2C0
        public void RemoveItem(){} // RVA: 0x6AAE3B0
        public void RemoveKey(){} // RVA: 0x6AAE530
        public void SetItem(){} // RVA: 0x6AAE590
        public void get_Item(){} // RVA: 0x6AAE800
        public void TryGetValue(){} // RVA: 0x6AAE8F0
        public void get_Keys(){} // RVA: 0x6AAE9C0
        public void get_Values(){} // RVA: 0x6AAEA20
        public void IndexOfReference(){} // RVA: 0x6AAEA80
        public void Compare(){} // RVA: 0x6AAEB90
        public void .cctor(){} // RVA: 0x6AAEF50
    }

    public class JRaw : JValue
    {
        // ── Methods ──
        public void CreateAsync(){} // RVA: 0x6AAF050
        public void .ctor(){} // RVA: 0x6AAF3E0
        public void Create(){} // RVA: 0x6AAF3F0
        public void CloneToken(){} // RVA: 0x6AAF710
    }

    public class JToken : Object
    {
        public object _equalityComparer;
        public object _parent;
        public object _previous;
        public object _next;
        public object _annotations;
        public object BooleanTypes;
        public object NumberTypes;
        public object BigIntegerTypes;
        public object StringTypes;
        public object GuidTypes;
        public object TimeSpanTypes;
        public object UriTypes;
        public object CharTypes;
        public object DateTimeTypes;
        public object BytesTypes;

        // ── Methods ──
        public void WriteToAsync(){} // RVA: 0x6AB02D0
        public void ReadFromAsync(){} // RVA: 0x6AB0360
        public void LoadAsync(){} // RVA: 0x6AB0660
        public void get_EqualityComparer(){} // RVA: 0x6AB06D0
        public void get_Parent(){} // RVA: 0xB5DBF0
        public void set_Parent(){} // RVA: 0xB44D60
        public void get_Root(){} // RVA: 0x6AB0800
        public void CloneToken(){} // RVA: 0x87C540
        public void DeepEquals(){} // RVA: 0x6AB0830
        public void get_Type(){} // RVA: 0x87C130
        public void get_HasValues(){} // RVA: 0x87D280
        public void get_Next(){} // RVA: 0xB700F0
        public void set_Next(){} // RVA: 0xB70100
        public void get_Previous(){} // RVA: 0xB465B0
        public void set_Previous(){} // RVA: 0xBA9BA0
        public void get_Path(){} // RVA: 0x6AB0860
        public void .ctor(){} // RVA: 0xB43310
        public void AddAfterSelf(){} // RVA: 0x6AB0BF0
        public void AddBeforeSelf(){} // RVA: 0x6AB0CA0
        public void Ancestors(){} // RVA: 0x6AB0D50
        public void AncestorsAndSelf(){} // RVA: 0x6AB0D60
        public void GetAncestors(){} // RVA: 0x6AB0D70
        public void AfterSelf(){} // RVA: 0x6AB0E30
        public void BeforeSelf(){} // RVA: 0x6AB0EE0
        public void get_Item(){} // RVA: 0x6AB0F90
        public void set_Item(){} // RVA: 0x6AB1030
        public void Value(){} // RVA: 0xA94080
        public void get_First(){} // RVA: 0x6AB10D0
        public void get_Last(){} // RVA: 0x6AB1170
        public void Children(){} // RVA: 0xA94080
        public void Values(){} // RVA: 0x87C0A0
        public void Remove(){} // RVA: 0x6AB1270
        public void Replace(){} // RVA: 0x6AB12F0
        public void WriteTo(){} // RVA: 0x8943B0
        public void ToString(){} // RVA: 0x6AB13C0
        public void EnsureValue(){} // RVA: 0x6AB1610
        public void GetType(){} // RVA: 0x6AB1740
        public void ValidateToken(){} // RVA: 0x6AB1870
        public void op_Explicit(){} // RVA: 0x6AB8490
        public void ToBigInteger(){} // RVA: 0x6AB86D0
        public void ToBigIntegerNullable(){} // RVA: 0x6AB8920
        public void op_Implicit(){} // RVA: 0x6AB9EE0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x6AB9F80
        public void System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator(){} // RVA: 0x6AB9FC0
        public void GetDeepHashCode(){} // RVA: 0x87C130
        public void Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JToken>.get_Item(){} // RVA: 0x6ABA050
        public void CreateReader(){} // RVA: 0x6ABA070
        public void FromObjectInternal(){} // RVA: 0x6ABA0D0
        public void FromObject(){} // RVA: 0x6ABA380
        public void ToObject(){} // RVA: 0x6ABB4E0
        public void ReadFrom(){} // RVA: 0x6ABB7A0
        public void Parse(){} // RVA: 0x6ABBBC0
        public void Load(){} // RVA: 0x6ABBDE0
        public void SetLineInfo(){} // RVA: 0x6ABBF60
        public void Newtonsoft.Json.IJsonLineInfo.HasLineInfo(){} // RVA: 0x6ABBFD0
        public void Newtonsoft.Json.IJsonLineInfo.get_LineNumber(){} // RVA: 0x6ABC010
        public void Newtonsoft.Json.IJsonLineInfo.get_LinePosition(){} // RVA: 0x6ABC060
        public void SelectToken(){} // RVA: 0x6ABC140
        public void SelectTokens(){} // RVA: 0x6ABC3E0
        public void GetMetaObject(){} // RVA: 0x6ABC480
        public void System.Dynamic.IDynamicMetaObjectProvider.GetMetaObject(){} // RVA: 0x4B02880
        public void System.ICloneable.Clone(){} // RVA: 0x6ABC550
        public void DeepClone(){} // RVA: 0x6ABC570
        public void AddAnnotation(){} // RVA: 0x6ABC590
        public void Annotation(){} // RVA: 0x6ABC8D0
        public void Annotations(){} // RVA: 0x6ABCA30
        public void RemoveAnnotations(){} // RVA: 0x6ABCB40
        public void CopyAnnotations(){} // RVA: 0x6ABCDB0
        public void .cctor(){} // RVA: 0x6ABCF50
    }

    public class JTokenEqualityComparer : Object
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x6ABF070
        public void GetHashCode(){} // RVA: 0x6ABF110
        public void .ctor(){} // RVA: 0xB43310
    }

    public class JTokenReader : JsonReader
    {
        public object _root;
        public object _initialPath;
        public object _parent;
        public object _current;

        // ── Methods ──
        public void get_CurrentToken(){} // RVA: 0x1069350
        public void .ctor(){} // RVA: 0x6ABF270
        public void Read(){} // RVA: 0x6ABF2F0
        public void ReadOver(){} // RVA: 0x6ABF540
        public void ReadToEnd(){} // RVA: 0x6ABF630
        public void GetEndToken(){} // RVA: 0x6ABF6B0
        public void ReadInto(){} // RVA: 0x6ABF810
        public void SetEnd(){} // RVA: 0x6ABF940
        public void SetToken(){} // RVA: 0x6ABFBA0
        public void SafeToString(){} // RVA: 0x6AC02A0
        public void Newtonsoft.Json.IJsonLineInfo.HasLineInfo(){} // RVA: 0x6AC02D0
        public void Newtonsoft.Json.IJsonLineInfo.get_LineNumber(){} // RVA: 0x6AC0330
        public void Newtonsoft.Json.IJsonLineInfo.get_LinePosition(){} // RVA: 0x6AC0390
        public void get_Path(){} // RVA: 0x6AC03F0
    }

    public class JTokenWriter : JsonWriter
    {
        public object _token;
        public object _parent;
        public object _value;
        public object _current;

        // ── Methods ──
        public void WriteTokenAsync(){} // RVA: 0x6AC0680
        public void get_CurrentToken(){} // RVA: 0xCD3320
        public void get_Token(){} // RVA: 0x6AC0790
        public void .ctor(){} // RVA: 0x6AC0930
        public void Flush(){} // RVA: 0xB43310
        public void Close(){} // RVA: 0x6AC0990
        public void WriteStartObject(){} // RVA: 0x6AC09A0
        public void AddParent(){} // RVA: 0x6AC0A30
        public void RemoveParent(){} // RVA: 0x6AC0C00
        public void WriteStartArray(){} // RVA: 0x6AC0D60
        public void WriteStartConstructor(){} // RVA: 0x6AC0DF0
        public void WriteEnd(){} // RVA: 0x6AC0C00
        public void WritePropertyName(){} // RVA: 0x6AC0E90
        public void AddRawValue(){} // RVA: 0x6AC1030
        public void AddJValue(){} // RVA: 0x6AC10D0
        public void WriteValue(){} // RVA: 0x6AC2290
        public void WriteNull(){} // RVA: 0x6AC13C0
        public void WriteUndefined(){} // RVA: 0x6AC1450
        public void WriteRaw(){} // RVA: 0x6AC14E0
        public void WriteComment(){} // RVA: 0x6AC1560
        public void WriteToken(){} // RVA: 0x6AC23C0
    }

    public class JValue : JToken
    {
        public object _valueType;
        public object _value;

        // ── Methods ──
        public void WriteToAsync(){} // RVA: 0x6AC2780
        public void .ctor(){} // RVA: 0x6AC3840
        public void DeepEquals(){} // RVA: 0x6AC3880
        public void get_HasValues(){} // RVA: 0xB43320
        public void CompareBigInteger(){} // RVA: 0x6AC3940
        public void Compare(){} // RVA: 0x6AC3D20
        public void CompareFloat(){} // RVA: 0x6AC4A60
        public void Operation(){} // RVA: 0x6AC4C30
        public void CloneToken(){} // RVA: 0x6AC5770
        public void CreateComment(){} // RVA: 0x6AC5880
        public void CreateString(){} // RVA: 0x6AC58E0
        public void CreateNull(){} // RVA: 0x6AC5940
        public void CreateUndefined(){} // RVA: 0x6AC59A0
        public void GetValueType(){} // RVA: 0x6AC5A00
        public void GetStringValueType(){} // RVA: 0x6AC5EE0
        public void get_Type(){} // RVA: 0xB9E080
        public void get_Value(){} // RVA: 0xD05CA0
        public void set_Value(){} // RVA: 0x6AC5F50
        public void WriteTo(){} // RVA: 0x6AC6070
        public void GetDeepHashCode(){} // RVA: 0x6AC6A90
        public void ValuesEquals(){} // RVA: 0x6AC6AD0
        public void Equals(){} // RVA: 0x6AC6B70
        public void GetHashCode(){} // RVA: 0x6AC6C30
        public void ToString(){} // RVA: 0x6AC6D20
        public void GetMetaObject(){} // RVA: 0x6AC6DF0
        public void System.IComparable.CompareTo(){} // RVA: 0x6AC6ED0
        public void CompareTo(){} // RVA: 0x6AC6F90
        public void System.IConvertible.GetTypeCode(){} // RVA: 0x6AC6FC0
        public void System.IConvertible.ToBoolean(){} // RVA: 0x6AC7030
        public void System.IConvertible.ToChar(){} // RVA: 0x6AC7080
        public void System.IConvertible.ToSByte(){} // RVA: 0x6AC70D0
        public void System.IConvertible.ToByte(){} // RVA: 0x6AC7120
        public void System.IConvertible.ToInt16(){} // RVA: 0x6AC7170
        public void System.IConvertible.ToUInt16(){} // RVA: 0x6AC71C0
        public void System.IConvertible.ToInt32(){} // RVA: 0x6AC7210
        public void System.IConvertible.ToUInt32(){} // RVA: 0x6AC7260
        public void System.IConvertible.ToInt64(){} // RVA: 0x6AC72B0
        public void System.IConvertible.ToUInt64(){} // RVA: 0x6AC7300
        public void System.IConvertible.ToSingle(){} // RVA: 0x6AC7350
        public void System.IConvertible.ToDouble(){} // RVA: 0x6AC73A0
        public void System.IConvertible.ToDecimal(){} // RVA: 0x6AC73F0
        public void System.IConvertible.ToDateTime(){} // RVA: 0x6AC7460
        public void System.IConvertible.ToType(){} // RVA: 0x6AC74B0
    }

    public class JsonCloneSettings : Object
    {
        public object SkipCopyAnnotations;
        public object _copyAnnotations;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xF482F0
        public void get_CopyAnnotations(){} // RVA: 0xC120A0
        public void set_CopyAnnotations(){} // RVA: 0xC120B0
        public void .cctor(){} // RVA: 0x6AAFF30
    }

    public class JsonLoadSettings : Object
    {
        public object _commentHandling;
        public object _lineInfoHandling;
        public object _duplicatePropertyNameHandling;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6AAFFD0
        public void get_CommentHandling(){} // RVA: 0xB8F8F0
        public void set_CommentHandling(){} // RVA: 0x6AAFFE0
        public void get_LineInfoHandling(){} // RVA: 0x116A650
        public void set_LineInfoHandling(){} // RVA: 0x6AB0050
        public void get_DuplicatePropertyNameHandling(){} // RVA: 0xE62D00
        public void set_DuplicatePropertyNameHandling(){} // RVA: 0x6AB00C0
    }

    public class JsonMergeSettings : Object
    {
        public object _mergeArrayHandling;
        public object _mergeNullValueHandling;
        public object _propertyNameComparison;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6AB0130
        public void get_MergeArrayHandling(){} // RVA: 0xB8F8F0
        public void set_MergeArrayHandling(){} // RVA: 0x6AB0140
        public void get_MergeNullValueHandling(){} // RVA: 0x116A650
        public void set_MergeNullValueHandling(){} // RVA: 0x6AB01B0
        public void get_PropertyNameComparison(){} // RVA: 0xE62D00
        public void set_PropertyNameComparison(){} // RVA: 0x6AB0220
    }

    public class JsonSelectSettings : Object
    {
        public object _regexMatchTimeout;
        public object _errorWhenNoMatch;

        // ── Methods ──
        public void get_RegexMatchTimeout(){} // RVA: 0x22343B0
        public void set_RegexMatchTimeout(){} // RVA: 0x22343C0
        public void get_ErrorWhenNoMatch(){} // RVA: 0xC38360
        public void set_ErrorWhenNoMatch(){} // RVA: 0xC38370
        public void .ctor(){} // RVA: 0xB43310
    }

}