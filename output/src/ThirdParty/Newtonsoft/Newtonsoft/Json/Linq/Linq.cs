// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Newtonsoft.Newtonsoft.Json.Linq
// Classes: 20
// Methods: 632

namespace ThirdParty.Newtonsoft.Newtonsoft.Json.Linq
{
    public class Extensions : Object
    {
        // ── Methods ──
        public void Ancestors(){} // RVA: 0x7FFE80E2E3D0
        public void AncestorsAndSelf(){} // RVA: 0x7FFE80E2E3D0
        public void Descendants(){} // RVA: 0x7FFE80E2E3D0
        public void DescendantsAndSelf(){} // RVA: 0x7FFE80E2E3D0
        public void Properties(){} // RVA: 0x7FFE86B64800
        public void Values(){} // RVA: 0x7FFE80E2E440 | overloaded x5
        public void Value(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void Children(){} // RVA: 0x7FFE80E2E3D0 | overloaded x2
        public void Convert(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void AsJEnumerable(){} // RVA: 0x7FFE80E2E3D0 | overloaded x2
    }

    public class IJEnumerable`1
    {
        // ── Methods ──
        public void get_Item(){} // RVA: 0x7FFE80E2E390
    }

    public class JArray : JContainer
    {
        public System.Collections.Generic.List`1<Newtonsoft.Json.Linq.JToken> _values; // 0x58
        public object 4>\f; // 0xF417
        public object field_2; // 0x9B88
        public object field_3; // 0x1
        public object field_4; // 0xF250

        // ── Methods ──
        public void WriteToAsync(){} // RVA: 0x7FFE86B64C10
        public void LoadAsync(){} // RVA: 0x7FFE86B64F00 | overloaded x2
        public void get_ChildrenTokens(){} // RVA: 0x7FFE811C3500
        public void get_Type(){} // RVA: 0x7FFE81200CB0
        public void .ctor(){} // RVA: 0x7FFE86B65430 | overloaded x5
        public void DeepEquals(){} // RVA: 0x7FFE86B65540
        public void CloneToken(){} // RVA: 0x7FFE86B655E0
        public void Load(){} // RVA: 0x7FFE86B65700 | overloaded x2
        public void Parse(){} // RVA: 0x7FFE86B65930 | overloaded x2
        public void FromObject(){} // RVA: 0x7FFE86B65C10 | overloaded x2
        public void WriteTo(){} // RVA: 0x7FFE86B65DA0
        public void get_Item(){} // RVA: 0x7FFE86B661B0 | overloaded x2
        public void set_Item(){} // RVA: 0x7FFE86B661D0 | overloaded x2
        public void IndexOfItem(){} // RVA: 0x7FFE86B661F0
        public void MergeItem(){} // RVA: 0x7FFE86B662B0
        public void IndexOf(){} // RVA: 0x7FFE86B663A0
        public void Insert(){} // RVA: 0x7FFE86B663C0
        public void RemoveAt(){} // RVA: 0x7FFE86B663F0
        public void GetEnumerator(){} // RVA: 0x7FFE86B66410
        public void Add(){} // RVA: 0x7FFE86B664A0
        public void Clear(){} // RVA: 0x7FFE86B664C0
        public void Contains(){} // RVA: 0x7FFE86B664E0
        public void CopyTo(){} // RVA: 0x7FFE86B66500
        public void get_IsReadOnly(){} // RVA: 0x7FFE810FB320
        public void Remove(){} // RVA: 0x7FFE86B66520
        public void GetDeepHashCode(){} // RVA: 0x7FFE86B66540
    }

    public class JConstructor : JContainer
    {
        public string _name; // 0x58
        public System.Collections.Generic.List`1<Newtonsoft.Json.Linq.JToken> _values; // 0x60
        public object <?\f; // 0xF417
        public object field_3; // 0x9CF0

        // ── Methods ──
        public void WriteToAsync(){} // RVA: 0x7FFE86B674C0
        public void LoadAsync(){} // RVA: 0x7FFE86B677B0 | overloaded x2
        public void get_ChildrenTokens(){} // RVA: 0x7FFE81199370
        public void IndexOfItem(){} // RVA: 0x7FFE86B67A00
        public void MergeItem(){} // RVA: 0x7FFE86B67AC0
        public void get_Name(){} // RVA: 0x7FFE811C3500
        public void set_Name(){} // RVA: 0x7FFE811C3510
        public void get_Type(){} // RVA: 0x7FFE817BF630
        public void .ctor(){} // RVA: 0x7FFE86B67FA0 | overloaded x6
        public void DeepEquals(){} // RVA: 0x7FFE86B681A0
        public void CloneToken(){} // RVA: 0x7FFE86B68290
        public void WriteTo(){} // RVA: 0x7FFE86B68420
        public void get_Item(){} // RVA: 0x7FFE86B68540
        public void set_Item(){} // RVA: 0x7FFE86B686B0
        public void GetDeepHashCode(){} // RVA: 0x7FFE86B68830
        public void Load(){} // RVA: 0x7FFE86B68890 | overloaded x2
    }

    public class JContainer : JToken
    {
        public System.ComponentModel.ListChangedEventHandler _listChanged; // 0x30
        public System.ComponentModel.AddingNewEventHandler _addingNew; // 0x38
        public System.Collections.Specialized.NotifyCollectionChangedEventHandler _collectionChanged; // 0x40
        public object _syncRoot; // 0x48
        public bool _busy; // 0x50
        public System.Collections.Generic.List`1<Newtonsoft.Json.Linq.JToken> _values; // 0x58
        public object 4>\f; // 0xF417
        public object CreateCacheableTask; // 0x9B88
        public object field_8; // 0x1
        public object field_9; // 0xF250
        public System.Threading.Tasks.Task`1<Newtonsoft.Json.Linq.JArray> field_10; // 0x11E8
        public object field_11; // 0x3AA0
        public object field_12; // 0xB38
        public object field_13; // 0x170E
        public object field_14; // 0x66E0
        public object CreateCacheableTask;
        public object field_16;
        public object field_17; // 0x5FF0
        public void field_18; // 0x13E0
        public object field_19; // 0x7460
        public object field_20; // 0xB960

        // ── Methods ──
        public void ReadTokenFromAsync(){} // RVA: 0x7FFE86B69B10
        public void ReadContentFromAsync(){} // RVA: 0x7FFE86B69DE0
        public void add_ListChanged(){} // RVA: 0x7FFE86B6A0B0
        public void remove_ListChanged(){} // RVA: 0x7FFE86B6A1A0
        public void add_AddingNew(){} // RVA: 0x7FFE86B6A290
        public void remove_AddingNew(){} // RVA: 0x7FFE86B6A380
        public void add_CollectionChanged(){} // RVA: 0x7FFE86B6A470
        public void remove_CollectionChanged(){} // RVA: 0x7FFE86B6A560
        public void get_ChildrenTokens(){} // RVA: 0x7FFE80E2E2E0
        public void .ctor(){} // RVA: 0x7FFE86B6A6A0 | overloaded x2
        public void CheckReentrancy(){} // RVA: 0x7FFE86B6A970
        public void CreateChildrenCollection(){} // RVA: 0x7FFE86B6AA20
        public void OnAddingNew(){} // RVA: 0x7FFE861D3DD0
        public void OnListChanged(){} // RVA: 0x7FFE86B6AA80
        public void OnCollectionChanged(){} // RVA: 0x7FFE86B6AAF0
        public void get_HasValues(){} // RVA: 0x7FFE86B6AB60
        public void ContentsEqual(){} // RVA: 0x7FFE86B6ABD0
        public void get_First(){} // RVA: 0x7FFE86B6AD30
        public void get_Last(){} // RVA: 0x7FFE86B6ADD0
        public void Children(){} // RVA: 0x7FFE86B6AE70
        public void Values(){} // RVA: 0x7FFE80E2E2E0
        public void Descendants(){} // RVA: 0x7FFE86B6AF90
        public void DescendantsAndSelf(){} // RVA: 0x7FFE86B6AFA0
        public void GetDescendants(){} // RVA: 0x7FFE86B6AFB0
        public void IsMultiContent(){} // RVA: 0x7FFE86B6B070
        public void EnsureParentToken(){} // RVA: 0x7FFE86B6B150
        public void IndexOfItem(){} // RVA: 0x7FFE80E33B00
        public void InsertItem(){} // RVA: 0x7FFE86B6B2A0
        public void RemoveItemAt(){} // RVA: 0x7FFE86B6B6D0
        public void RemoveItem(){} // RVA: 0x7FFE86B6BA60
        public void GetItem(){} // RVA: 0x7FFE86B6BAB0
        public void SetItem(){} // RVA: 0x7FFE86B6BB20
        public void ClearItems(){} // RVA: 0x7FFE86B6BFC0
        public void ReplaceItem(){} // RVA: 0x7FFE86B6C490
        public void ContainsItem(){} // RVA: 0x7FFE86B6C4F0
        public void CopyItemsTo(){} // RVA: 0x7FFE86B6C520
        public void IsTokenUnchanged(){} // RVA: 0x7FFE86B6C810
        public void ValidateToken(){} // RVA: 0x7FFE86B6C8E0
        public void Add(){} // RVA: 0x7FFE86B6CA40
        public void TryAdd(){} // RVA: 0x7FFE86B6CAD0
        public void AddAndSkipParentCheck(){} // RVA: 0x7FFE86B6CB60
        public void AddFirst(){} // RVA: 0x7FFE86B6CBF0
        public void TryAddInternal(){} // RVA: 0x7FFE86B6CC20
        public void CreateFromContent(){} // RVA: 0x7FFE86B6CEE0
        public void CreateWriter(){} // RVA: 0x7FFE86B6CFA0
        public void ReplaceAll(){} // RVA: 0x7FFE86B6D150
        public void RemoveAll(){} // RVA: 0x7FFE86B664C0
        public void MergeItem(){} // RVA: 0x7FFE80E4F230
        public void Merge(){} // RVA: 0x7FFE86B6D1F0 | overloaded x2
        public void ValidateContent(){} // RVA: 0x7FFE86B6D250
        public void ReadTokenFrom(){} // RVA: 0x7FFE86B6D420
        public void ReadContentFrom(){} // RVA: 0x7FFE86B6D5E0
        public void ReadProperty(){} // RVA: 0x7FFE86B6DD00
        public void ContentsHashCode(){} // RVA: 0x7FFE86B6DF80
        public void System.ComponentModel.ITypedList.GetListName(){} // RVA: 0x7FFE86B6E190
        public void System.ComponentModel.ITypedList.GetItemProperties(){} // RVA: 0x7FFE86B6E1D0
        public void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.IndexOf(){} // RVA: 0x7FFE86B663A0
        public void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.Insert(){} // RVA: 0x7FFE86B663C0
        public void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.RemoveAt(){} // RVA: 0x7FFE86B663F0
        public void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.get_Item(){} // RVA: 0x7FFE86B661B0
        public void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.set_Item(){} // RVA: 0x7FFE86B661D0
        public void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Add(){} // RVA: 0x7FFE86B664A0
        public void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Clear(){} // RVA: 0x7FFE86B664C0
        public void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Contains(){} // RVA: 0x7FFE86B664E0
        public void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.CopyTo(){} // RVA: 0x7FFE86B66500
        public void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.get_IsReadOnly(){} // RVA: 0x7FFE810FB320
        public void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Remove(){} // RVA: 0x7FFE86B66520
        public void EnsureValue(){} // RVA: 0x7FFE86B6E2A0
        public void System.Collections.IList.Add(){} // RVA: 0x7FFE86B6E360
        public void System.Collections.IList.Clear(){} // RVA: 0x7FFE86B664C0
        public void System.Collections.IList.Contains(){} // RVA: 0x7FFE86B6E3F0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7FFE86B6E420
        public void System.Collections.IList.Insert(){} // RVA: 0x7FFE86B6E450
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7FFE810FB320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7FFE810FB320
        public void System.Collections.IList.Remove(){} // RVA: 0x7FFE86B6E4B0
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x7FFE86B663F0
        public void System.Collections.IList.get_Item(){} // RVA: 0x7FFE86B661B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x7FFE86B6E4E0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFE86B66500
        public void get_Count(){} // RVA: 0x7FFE86B6E530
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFE810FB320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFE86B6E5A0
        public void System.ComponentModel.IBindingList.AddIndex(){} // RVA: 0x7FFE810FB310
        public void System.ComponentModel.IBindingList.AddNew(){} // RVA: 0x7FFE86B6E650
        public void System.ComponentModel.IBindingList.get_AllowEdit(){} // RVA: 0x7FFE811E0850
        public void System.ComponentModel.IBindingList.get_AllowNew(){} // RVA: 0x7FFE811E0850
        public void System.ComponentModel.IBindingList.get_AllowRemove(){} // RVA: 0x7FFE811E0850
        public void System.ComponentModel.IBindingList.ApplySort(){} // RVA: 0x7FFE86B6E8B0
        public void System.ComponentModel.IBindingList.Find(){} // RVA: 0x7FFE86B6E8F0
        public void System.ComponentModel.IBindingList.get_IsSorted(){} // RVA: 0x7FFE810FB320
        public void System.ComponentModel.IBindingList.RemoveIndex(){} // RVA: 0x7FFE810FB310
        public void System.ComponentModel.IBindingList.RemoveSort(){} // RVA: 0x7FFE86B6E930
        public void System.ComponentModel.IBindingList.get_SortDirection(){} // RVA: 0x7FFE813240E0
        public void System.ComponentModel.IBindingList.get_SortProperty(){} // RVA: 0x7FFE813240E0
        public void System.ComponentModel.IBindingList.get_SupportsChangeNotification(){} // RVA: 0x7FFE811E0850
        public void System.ComponentModel.IBindingList.get_SupportsSearching(){} // RVA: 0x7FFE810FB320
        public void System.ComponentModel.IBindingList.get_SupportsSorting(){} // RVA: 0x7FFE810FB320
        public void MergeEnumerableContent(){} // RVA: 0x7FFE86B6E970
    }

    public class JEnumerable`1 : ValueType
    {
        public Newtonsoft.Json.Linq.JEnumerable`1<T> Empty;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E460A0
        public void GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void get_Item(){} // RVA: 0x7FFE80E2E390
        public void Equals(){} // RVA: 0x7FFE80E2F3B0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE80E2EDB0
        public void .cctor(){} // RVA: 0x7FFE80E46010
    }

    public class JObject : JContainer
    {
        public Newtonsoft.Json.Linq.JPropertyKeyedCollection _properties; // 0x58
        public System.ComponentModel.PropertyChangedEventHandler PropertyChanged; // 0x60
        public System.ComponentModel.PropertyChangingEventHandler PropertyChanging; // 0x68
        public object \C\f; // 0xF417
        public object field_4; // 0xA020
        public object field_5; // 0x1
        public object field_6; // 0xF250

        // ── Methods ──
        public void WriteToAsync(){} // RVA: 0x7FFE86B711D0
        public void LoadAsync(){} // RVA: 0x7FFE86B71430 | overloaded x2
        public void get_ChildrenTokens(){} // RVA: 0x7FFE811C3500
        public void add_PropertyChanged(){} // RVA: 0x7FFE86B71680
        public void remove_PropertyChanged(){} // RVA: 0x7FFE86B71770
        public void add_PropertyChanging(){} // RVA: 0x7FFE86B71860
        public void remove_PropertyChanging(){} // RVA: 0x7FFE86B71950
        public void .ctor(){} // RVA: 0x7FFE86B71CC0 | overloaded x5
        public void DeepEquals(){} // RVA: 0x7FFE86B71DC0
        public void IndexOfItem(){} // RVA: 0x7FFE86B71E70
        public void InsertItem(){} // RVA: 0x7FFE86B71FA0
        public void ValidateToken(){} // RVA: 0x7FFE86B72020
        public void MergeItem(){} // RVA: 0x7FFE86B72320
        public void IsNull(){} // RVA: 0x7FFE86B726D0
        public void InternalPropertyChanged(){} // RVA: 0x7FFE86B72770
        public void InternalPropertyChanging(){} // RVA: 0x7FFE86B72960
        public void CloneToken(){} // RVA: 0x7FFE86B72990
        public void get_Type(){} // RVA: 0x7FFE811EDAF0
        public void Properties(){} // RVA: 0x7FFE86B72A90
        public void Property(){} // RVA: 0x7FFE86B72AE0 | overloaded x2
        public void PropertyValues(){} // RVA: 0x7FFE86B72D10
        public void get_Item(){} // RVA: 0x7FFE86B732A0 | overloaded x2
        public void set_Item(){} // RVA: 0x7FFE86B73370 | overloaded x2
        public void Load(){} // RVA: 0x7FFE86B734C0 | overloaded x2
        public void Parse(){} // RVA: 0x7FFE86B73740 | overloaded x2
        public void FromObject(){} // RVA: 0x7FFE86B73A20 | overloaded x2
        public void WriteTo(){} // RVA: 0x7FFE86B73BB0
        public void GetValue(){} // RVA: 0x7FFE86B73D90 | overloaded x2
        public void TryGetValue(){} // RVA: 0x7FFE86B74100 | overloaded x2
        public void Add(){} // RVA: 0x7FFE86B73E60
        public void ContainsKey(){} // RVA: 0x7FFE86B73EF0
        public void System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.get_Keys(){} // RVA: 0x7FFE86B74000
        public void Remove(){} // RVA: 0x7FFE86B74060
        public void System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.get_Values(){} // RVA: 0x7FFE86B741F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Add(){} // RVA: 0x7FFE86B74230
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Clear(){} // RVA: 0x7FFE86B664C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Contains(){} // RVA: 0x7FFE86B742E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.CopyTo(){} // RVA: 0x7FFE86B74370
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.get_IsReadOnly(){} // RVA: 0x7FFE810FB320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Remove(){} // RVA: 0x7FFE86B74750
        public void GetDeepHashCode(){} // RVA: 0x7FFE86B66540
        public void GetEnumerator(){} // RVA: 0x7FFE86B74860
        public void OnPropertyChanged(){} // RVA: 0x7FFE86B74900
        public void OnPropertyChanging(){} // RVA: 0x7FFE86B74990
        public void System.ComponentModel.ICustomTypeDescriptor.GetProperties(){} // RVA: 0x7FFE86B74AE0 | overloaded x2
        public void System.ComponentModel.ICustomTypeDescriptor.GetAttributes(){} // RVA: 0x7FFE86B74E40
        public void System.ComponentModel.ICustomTypeDescriptor.GetClassName(){} // RVA: 0x7FFE813240E0
        public void System.ComponentModel.ICustomTypeDescriptor.GetComponentName(){} // RVA: 0x7FFE813240E0
        public void System.ComponentModel.ICustomTypeDescriptor.GetConverter(){} // RVA: 0x7FFE86B74EA0
        public void System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent(){} // RVA: 0x7FFE813240E0
        public void System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty(){} // RVA: 0x7FFE813240E0
        public void System.ComponentModel.ICustomTypeDescriptor.GetEditor(){} // RVA: 0x7FFE813240E0
        public void System.ComponentModel.ICustomTypeDescriptor.GetEvents(){} // RVA: 0x7FFE86B74F40 | overloaded x2
        public void System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(){} // RVA: 0x7FFE86B74FA0
        public void GetMetaObject(){} // RVA: 0x7FFE86B75020
        public void <WriteToAsync>g__AwaitProperties|0_0(){} // RVA: 0x7FFE86B75100
    }

    public class JProperty : JContainer
    {
        public JPropertyList _content; // 0x58
        public string _name; // 0x60
        public object field_2; // 0xF417
        public object field_3; // 0xA188

        // ── Methods ──
        public void WriteToAsync(){} // RVA: 0x7FFE86B77050 | overloaded x2
        public void WriteValueAsync(){} // RVA: 0x7FFE86B77370
        public void LoadAsync(){} // RVA: 0x7FFE86B773F0 | overloaded x2
        public void get_ChildrenTokens(){} // RVA: 0x7FFE811C3500
        public void get_Name(){} // RVA: 0x7FFE81199370
        public void get_Value(){} // RVA: 0x7FFE86B77640
        public void set_Value(){} // RVA: 0x7FFE86B77660
        public void .ctor(){} // RVA: 0x7FFE86B784B0 | overloaded x5
        public void GetItem(){} // RVA: 0x7FFE86B77990
        public void SetItem(){} // RVA: 0x7FFE86B77A00
        public void RemoveItem(){} // RVA: 0x7FFE86B77C00
        public void RemoveItemAt(){} // RVA: 0x7FFE86B77CC0
        public void IndexOfItem(){} // RVA: 0x7FFE86B77D80
        public void InsertItem(){} // RVA: 0x7FFE86B77DC0
        public void ContainsItem(){} // RVA: 0x7FFE86B77EF0
        public void MergeItem(){} // RVA: 0x7FFE86B77F10
        public void ClearItems(){} // RVA: 0x7FFE86B77FD0
        public void DeepEquals(){} // RVA: 0x7FFE86B78090
        public void CloneToken(){} // RVA: 0x7FFE86B78180
        public void get_Type(){} // RVA: 0x7FFE8180E590
        public void WriteTo(){} // RVA: 0x7FFE86B78740
        public void GetDeepHashCode(){} // RVA: 0x7FFE86B787E0
        public void Load(){} // RVA: 0x7FFE86B78870 | overloaded x2
    }

    public class JPropertyDescriptor : PropertyDescriptor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86B79D20
        public void CastInstance(){} // RVA: 0x7FFE86B79D30
        public void CanResetValue(){} // RVA: 0x7FFE810FB320
        public void GetValue(){} // RVA: 0x7FFE86B79DB0
        public void ResetValue(){} // RVA: 0x7FFE810FB310
        public void SetValue(){} // RVA: 0x7FFE86B79F10
        public void ShouldSerializeValue(){} // RVA: 0x7FFE810FB320
        public void get_ComponentType(){} // RVA: 0x7FFE86B7A070
        public void get_IsReadOnly(){} // RVA: 0x7FFE810FB320
        public void get_PropertyType(){} // RVA: 0x7FFE86B7A120
        public void get_NameHashCode(){} // RVA: 0x7FFE8151D690
    }

    public class JPropertyKeyedCollection : Collection`1
    {
        public System.Collections.Generic.IEqualityComparer`1<string> Comparer;
        public System.Collections.Generic.Dictionary`2<string,Newtonsoft.Json.Linq.JToken> _dictionary; // 0x18
        public object field_2; // 0x207

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86B7A1D0
        public void AddKey(){} // RVA: 0x7FFE86B7A2B0
        public void ChangeItemKey(){} // RVA: 0x7FFE86B7A340
        public void ClearItems(){} // RVA: 0x7FFE86B7A5A0
        public void Contains(){} // RVA: 0x7FFE86B7A650
        public void ContainsItem(){} // RVA: 0x7FFE86B7A720
        public void EnsureDictionary(){} // RVA: 0x7FFE86B7A800
        public void GetKeyForItem(){} // RVA: 0x7FFE86B7A910
        public void InsertItem(){} // RVA: 0x7FFE86B7A990
        public void Remove(){} // RVA: 0x7FFE86B7AA60
        public void RemoveItem(){} // RVA: 0x7FFE86B7AB50
        public void RemoveKey(){} // RVA: 0x7FFE86B7ACD0
        public void SetItem(){} // RVA: 0x7FFE86B7AD30
        public void get_Item(){} // RVA: 0x7FFE86B7AFA0
        public void TryGetValue(){} // RVA: 0x7FFE86B7B090
        public void get_Keys(){} // RVA: 0x7FFE86B7B160
        public void get_Values(){} // RVA: 0x7FFE86B7B1C0
        public void IndexOfReference(){} // RVA: 0x7FFE86B7B220
        public void Compare(){} // RVA: 0x7FFE86B7B330
        public void .cctor(){} // RVA: 0x7FFE86B7B6E0
    }

    public class JRaw : JValue
    {
        // ── Methods ──
        public void CreateAsync(){} // RVA: 0x7FFE86B7B7E0
        public void .ctor(){} // RVA: 0x7FFE86B7BB80 | overloaded x3
        public void Create(){} // RVA: 0x7FFE86B7BB90
        public void CloneToken(){} // RVA: 0x7FFE86B7BEA0
    }

    public class JToken : Object
    {
        public Newtonsoft.Json.Linq.JTokenEqualityComparer _equalityComparer;
        public Newtonsoft.Json.Linq.JContainer _parent; // 0x10
        public Newtonsoft.Json.Linq.JToken _previous; // 0x18
        public Newtonsoft.Json.Linq.JToken _next; // 0x20
        public object _annotations; // 0x28
        public 0x665C4B9C[] BooleanTypes; // 0x8
        public 0x665C4B9C[] NumberTypes; // 0x10
        public 0x665C4B9C[] BigIntegerTypes; // 0x18
        public 0x665C4B9C[] StringTypes; // 0x20
        public 0x665C4B9C[] GuidTypes; // 0x28
        public 0x665C4B9C[] TimeSpanTypes; // 0x30
        public 0x665C4B9C[] UriTypes; // 0x38
        public 0x665C4B9C[] CharTypes; // 0x40
        public 0x665C4B9C[] DateTimeTypes; // 0x48

        // ── Methods ──
        public void WriteToAsync(){} // RVA: 0x7FFE86B7CA60 | overloaded x2
        public void ReadFromAsync(){} // RVA: 0x7FFE86B7CAF0 | overloaded x2
        public void LoadAsync(){} // RVA: 0x7FFE86B7CDF0 | overloaded x2
        public void get_EqualityComparer(){} // RVA: 0x7FFE86B7CE60
        public void get_Parent(){} // RVA: 0x7FFE81116380
        public void set_Parent(){} // RVA: 0x7FFE810FCE30
        public void get_Root(){} // RVA: 0x7FFE86B7CF90
        public void CloneToken(){} // RVA: 0x7FFE80E2E390
        public void DeepEquals(){} // RVA: 0x7FFE86B7CFC0 | overloaded x2
        public void get_Type(){} // RVA: 0x7FFE80E2EDB0
        public void get_HasValues(){} // RVA: 0x7FFE80E2F150
        public void get_Next(){} // RVA: 0x7FFE811290C0
        public void set_Next(){} // RVA: 0x7FFE811290D0
        public void get_Previous(){} // RVA: 0x7FFE810FE7C0
        public void set_Previous(){} // RVA: 0x7FFE81161E80
        public void get_Path(){} // RVA: 0x7FFE86B7CFF0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void AddAfterSelf(){} // RVA: 0x7FFE86B7D3D0
        public void AddBeforeSelf(){} // RVA: 0x7FFE86B7D480
        public void Ancestors(){} // RVA: 0x7FFE86B7D530
        public void AncestorsAndSelf(){} // RVA: 0x7FFE86B7D540
        public void GetAncestors(){} // RVA: 0x7FFE86B7D550
        public void AfterSelf(){} // RVA: 0x7FFE86B7D610
        public void BeforeSelf(){} // RVA: 0x7FFE86B7D6C0
        public void get_Item(){} // RVA: 0x7FFE86B7D770
        public void set_Item(){} // RVA: 0x7FFE86B7D810
        public void Value(){} // RVA: 0x7FFE810A1420
        public void get_First(){} // RVA: 0x7FFE86B7D8B0
        public void get_Last(){} // RVA: 0x7FFE86B7D950
        public void Children(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void Values(){} // RVA: 0x7FFE80E2E2E0
        public void Remove(){} // RVA: 0x7FFE86B7DA50
        public void Replace(){} // RVA: 0x7FFE86B7DAD0
        public void WriteTo(){} // RVA: 0x7FFE80E4F230
        public void ToString(){} // RVA: 0x7FFE86B7DBA0 | overloaded x2
        public void EnsureValue(){} // RVA: 0x7FFE86B7DDF0
        public void GetType(){} // RVA: 0x7FFE86B7DF20
        public void ValidateToken(){} // RVA: 0x7FFE86B7E050
        public void op_Explicit(){} // RVA: 0x7FFE86B84C70 | overloaded x37
        public void ToBigInteger(){} // RVA: 0x7FFE86B84F20
        public void ToBigIntegerNullable(){} // RVA: 0x7FFE86B85170
        public void op_Implicit(){} // RVA: 0x7FFE86B866E0 | overloaded x35
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE86B86780
        public void System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator(){} // RVA: 0x7FFE86B867C0
        public void GetDeepHashCode(){} // RVA: 0x7FFE80E2EDB0
        public void Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JToken>.get_Item(){} // RVA: 0x7FFE86B86850
        public void CreateReader(){} // RVA: 0x7FFE86B86870
        public void FromObjectInternal(){} // RVA: 0x7FFE86B868D0
        public void FromObject(){} // RVA: 0x7FFE86B86B70 | overloaded x2
        public void ToObject(){} // RVA: 0x7FFE86B87DB0 | overloaded x4
        public void ReadFrom(){} // RVA: 0x7FFE86B88060 | overloaded x2
        public void Parse(){} // RVA: 0x7FFE86B88480 | overloaded x2
        public void Load(){} // RVA: 0x7FFE86B88690 | overloaded x2
        public void SetLineInfo(){} // RVA: 0x7FFE86B88810 | overloaded x2
        public void Newtonsoft.Json.IJsonLineInfo.HasLineInfo(){} // RVA: 0x7FFE86B88880
        public void Newtonsoft.Json.IJsonLineInfo.get_LineNumber(){} // RVA: 0x7FFE86B888D0
        public void Newtonsoft.Json.IJsonLineInfo.get_LinePosition(){} // RVA: 0x7FFE86B88920
        public void SelectToken(){} // RVA: 0x7FFE86B88A00 | overloaded x3
        public void SelectTokens(){} // RVA: 0x7FFE86B88C80 | overloaded x3
        public void GetMetaObject(){} // RVA: 0x7FFE86B88D20
        public void System.Dynamic.IDynamicMetaObjectProvider.GetMetaObject(){} // RVA: 0x7FFE84CC60F0
        public void System.ICloneable.Clone(){} // RVA: 0x7FFE86B88DF0
        public void DeepClone(){} // RVA: 0x7FFE86B88E10 | overloaded x2
        public void AddAnnotation(){} // RVA: 0x7FFE86B88E30
        public void Annotation(){} // RVA: 0x7FFE86B89170 | overloaded x2
        public void Annotations(){} // RVA: 0x7FFE86B892D0 | overloaded x2
        public void RemoveAnnotations(){} // RVA: 0x7FFE86B893E0 | overloaded x2
        public void CopyAnnotations(){} // RVA: 0x7FFE86B89650
        public void .cctor(){} // RVA: 0x7FFE86B897F0
    }

    public class JTokenEqualityComparer : Object
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE86B8B920
        public void GetHashCode(){} // RVA: 0x7FFE86B8B9C0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class JTokenReader : JsonReader
    {
        public Newtonsoft.Json.Linq.JToken _root; // 0x78
        public string _initialPath; // 0x80
        public Newtonsoft.Json.Linq.JToken _parent; // 0x88
        public Newtonsoft.Json.Linq.JToken _current; // 0x90

        // ── Methods ──
        public void get_CurrentToken(){} // RVA: 0x7FFE8154EB60
        public void .ctor(){} // RVA: 0x7FFE86B8BB20 | overloaded x2
        public void Read(){} // RVA: 0x7FFE86B8BBA0
        public void ReadOver(){} // RVA: 0x7FFE86B8BDF0
        public void ReadToEnd(){} // RVA: 0x7FFE86B8BEE0
        public void GetEndToken(){} // RVA: 0x7FFE86B8BFE0
        public void ReadInto(){} // RVA: 0x7FFE86B8C140
        public void SetEnd(){} // RVA: 0x7FFE86B8C270
        public void SetToken(){} // RVA: 0x7FFE86B8C4D0
        public void SafeToString(){} // RVA: 0x7FFE86B8CFF0
        public void Newtonsoft.Json.IJsonLineInfo.HasLineInfo(){} // RVA: 0x7FFE86B8D020
        public void Newtonsoft.Json.IJsonLineInfo.get_LineNumber(){} // RVA: 0x7FFE86B8D080
        public void Newtonsoft.Json.IJsonLineInfo.get_LinePosition(){} // RVA: 0x7FFE86B8D0E0
        public void get_Path(){} // RVA: 0x7FFE86B8D140
    }

    public class JTokenWriter : JsonWriter
    {
        public Newtonsoft.Json.Linq.JContainer _token; // 0x60
        public Newtonsoft.Json.Linq.JContainer _parent; // 0x68

        // ── Methods ──
        public void WriteTokenAsync(){} // RVA: 0x7FFE86B8D3E0
        public void get_CurrentToken(){} // RVA: 0x7FFE81463AE0
        public void get_Token(){} // RVA: 0x7FFE86B8D4F0
        public void .ctor(){} // RVA: 0x7FFE86B8D690 | overloaded x2
        public void Flush(){} // RVA: 0x7FFE810FB310
        public void Close(){} // RVA: 0x7FFE86B8D6F0
        public void WriteStartObject(){} // RVA: 0x7FFE86B8D700
        public void AddParent(){} // RVA: 0x7FFE86B8D790
        public void RemoveParent(){} // RVA: 0x7FFE86B8D960
        public void WriteStartArray(){} // RVA: 0x7FFE86B8DAC0
        public void WriteStartConstructor(){} // RVA: 0x7FFE86B8DB50
        public void WriteEnd(){} // RVA: 0x7FFE86B8D960
        public void WritePropertyName(){} // RVA: 0x7FFE86B8DBF0
        public void AddRawValue(){} // RVA: 0x7FFE86B8DDA0
        public void AddJValue(){} // RVA: 0x7FFE86B8DE40
        public void WriteValue(){} // RVA: 0x7FFE86B8F100 | overloaded x21
        public void WriteNull(){} // RVA: 0x7FFE86B8E130
        public void WriteUndefined(){} // RVA: 0x7FFE86B8E1C0
        public void WriteRaw(){} // RVA: 0x7FFE86B8E250
        public void WriteComment(){} // RVA: 0x7FFE86B8E2D0
        public void WriteToken(){} // RVA: 0x7FFE86B8F1F0
    }

    public class JValue : JToken
    {
        public 0x665C4B9C _valueType; // 0x30
        public object _value; // 0x38
        public object tF\f; // 0xF417

        // ── Methods ──
        public void WriteToAsync(){} // RVA: 0x7FFE86B8F5B0
        public void .ctor(){} // RVA: 0x7FFE86B90740 | overloaded x17
        public void DeepEquals(){} // RVA: 0x7FFE86B90780
        public void get_HasValues(){} // RVA: 0x7FFE810FB320
        public void CompareBigInteger(){} // RVA: 0x7FFE86B90850
        public void Compare(){} // RVA: 0x7FFE86B90C60
        public void CompareFloat(){} // RVA: 0x7FFE86B919E0
        public void Operation(){} // RVA: 0x7FFE86B91BB0
        public void CloneToken(){} // RVA: 0x7FFE86B927B0
        public void CreateComment(){} // RVA: 0x7FFE86B928C0
        public void CreateString(){} // RVA: 0x7FFE86B92920
        public void CreateNull(){} // RVA: 0x7FFE86B92980
        public void CreateUndefined(){} // RVA: 0x7FFE86B929E0
        public void GetValueType(){} // RVA: 0x7FFE86B92A40
        public void GetStringValueType(){} // RVA: 0x7FFE86B92FF0
        public void get_Type(){} // RVA: 0x7FFE81156CD0
        public void get_Value(){} // RVA: 0x7FFE8143BA80
        public void set_Value(){} // RVA: 0x7FFE86B93060
        public void WriteTo(){} // RVA: 0x7FFE86B93190
        public void GetDeepHashCode(){} // RVA: 0x7FFE86B93C00
        public void ValuesEquals(){} // RVA: 0x7FFE86B93C40
        public void Equals(){} // RVA: 0x7FFE86B93CE0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE86B93DB0
        public void ToString(){} // RVA: 0x7FFE86B93F10 | overloaded x4
        public void GetMetaObject(){} // RVA: 0x7FFE86B93FF0
        public void System.IComparable.CompareTo(){} // RVA: 0x7FFE86B940D0
        public void CompareTo(){} // RVA: 0x7FFE86B94190
        public void System.IConvertible.GetTypeCode(){} // RVA: 0x7FFE86B941C0
        public void System.IConvertible.ToBoolean(){} // RVA: 0x7FFE86B94230
        public void System.IConvertible.ToChar(){} // RVA: 0x7FFE86B94280
        public void System.IConvertible.ToSByte(){} // RVA: 0x7FFE86B942D0
        public void System.IConvertible.ToByte(){} // RVA: 0x7FFE86B94320
        public void System.IConvertible.ToInt16(){} // RVA: 0x7FFE86B94370
        public void System.IConvertible.ToUInt16(){} // RVA: 0x7FFE86B943C0
        public void System.IConvertible.ToInt32(){} // RVA: 0x7FFE86B94410
        public void System.IConvertible.ToUInt32(){} // RVA: 0x7FFE86B94460
        public void System.IConvertible.ToInt64(){} // RVA: 0x7FFE86B944B0
        public void System.IConvertible.ToUInt64(){} // RVA: 0x7FFE86B94500
        public void System.IConvertible.ToSingle(){} // RVA: 0x7FFE86B94550
        public void System.IConvertible.ToDouble(){} // RVA: 0x7FFE86B945A0
        public void System.IConvertible.ToDecimal(){} // RVA: 0x7FFE86B945F0
        public void System.IConvertible.ToDateTime(){} // RVA: 0x7FFE86B94660
        public void System.IConvertible.ToType(){} // RVA: 0x7FFE86B946B0
    }

    public class JsonCloneSettings : Object
    {
        public Newtonsoft.Json.Linq.JsonCloneSettings SkipCopyAnnotations;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE814B8390
        public void get_CopyAnnotations(){} // RVA: 0x7FFE811C55E0
        public void set_CopyAnnotations(){} // RVA: 0x7FFE811C55F0
        public void .cctor(){} // RVA: 0x7FFE86B7C6C0
    }

    public class JsonLoadSettings : Object
    {
        public 0x665C3964 _commentHandling; // 0x10
        public 0x665C4CFC _lineInfoHandling; // 0x14
        public 0x665C39BC _duplicatePropertyNameHandling; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86B7C760
        public void get_CommentHandling(){} // RVA: 0x7FFE811485C0
        public void set_CommentHandling(){} // RVA: 0x7FFE86B7C770
        public void get_LineInfoHandling(){} // RVA: 0x7FFE8164B230
        public void set_LineInfoHandling(){} // RVA: 0x7FFE86B7C7E0
        public void get_DuplicatePropertyNameHandling(){} // RVA: 0x7FFE813DB630
        public void set_DuplicatePropertyNameHandling(){} // RVA: 0x7FFE86B7C850
    }

    public class JsonMergeSettings : Object
    {
        public 0x665C4D54 _mergeArrayHandling; // 0x10
        public 0x665C4DAC _mergeNullValueHandling; // 0x14
        public 0x664BA1AC _propertyNameComparison; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86B7C8C0
        public void get_MergeArrayHandling(){} // RVA: 0x7FFE811485C0
        public void set_MergeArrayHandling(){} // RVA: 0x7FFE86B7C8D0
        public void get_MergeNullValueHandling(){} // RVA: 0x7FFE8164B230
        public void set_MergeNullValueHandling(){} // RVA: 0x7FFE86B7C940
        public void get_PropertyNameComparison(){} // RVA: 0x7FFE813DB630
        public void set_PropertyNameComparison(){} // RVA: 0x7FFE86B7C9B0
    }

    public class JsonSelectSettings : Object
    {
        public System.Nullable`1<System.TimeSpan> _regexMatchTimeout; // 0x10
        public bool _errorWhenNoMatch; // 0x20

        // ── Methods ──
        public void get_RegexMatchTimeout(){} // RVA: 0x7FFE826F6B90
        public void set_RegexMatchTimeout(){} // RVA: 0x7FFE826F6BA0
        public void get_ErrorWhenNoMatch(){} // RVA: 0x7FFE811E99D0
        public void set_ErrorWhenNoMatch(){} // RVA: 0x7FFE811E99E0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

}