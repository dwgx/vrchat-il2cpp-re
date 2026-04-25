// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Newtonsoft.Newtonsoft.Json.Linq
// Classes: 20
// Methods: 632

namespace ThirdParty.Newtonsoft.Newtonsoft.Json.Linq
{
    public class Extensions : Object
    {
        // ── Methods ──
        public void Ancestors(){} // RVA: 0x7FFAC2C58F80
        public void AncestorsAndSelf(){} // RVA: 0x7FFAC2C58F80
        public void Descendants(){} // RVA: 0x7FFAC2C58F80
        public void DescendantsAndSelf(){} // RVA: 0x7FFAC2C58F80
        public void Properties(){} // RVA: 0x7FFAC87BB0D0
        public void Values(){} // RVA: 0x7FFAC2C58FF0 | overloaded x5
        public void Value(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void Children(){} // RVA: 0x7FFAC2C58F80 | overloaded x2
        public void Convert(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void AsJEnumerable(){} // RVA: 0x7FFAC2C58F80 | overloaded x2
    }

    public class IJEnumerable`1
    {
        public object Item;

        // ── Methods ──
        public void get_Item(){} // RVA: 0x7FFAC2C58F40
    }

    public class JArray : JContainer
    {
        public System.Collections.Generic.List`1<Newtonsoft.Json.Linq.JToken> ChildrenTokens; // 0x58

        // ── Methods ──
        public void WriteToAsync(){} // RVA: 0x7FFAC87BB4E0
        public void LoadAsync(){} // RVA: 0x7FFAC87BB7D0 | overloaded x2
        public void get_ChildrenTokens(){} // RVA: 0x7FFAC2FE9500
        public void get_Type(){} // RVA: 0x7FFAC3026CB0
        public void .ctor(){} // RVA: 0x7FFAC87BBD00 | overloaded x5
        public void DeepEquals(){} // RVA: 0x7FFAC87BBE10
        public void CloneToken(){} // RVA: 0x7FFAC87BBEB0
        public void Load(){} // RVA: 0x7FFAC87BBFD0 | overloaded x2
        public void Parse(){} // RVA: 0x7FFAC87BC200 | overloaded x2
        public void FromObject(){} // RVA: 0x7FFAC87BC4E0 | overloaded x2
        public void WriteTo(){} // RVA: 0x7FFAC87BC670
        public void get_Item(){} // RVA: 0x7FFAC87BCA80 | overloaded x2
        public void set_Item(){} // RVA: 0x7FFAC87BCAA0 | overloaded x2
        public void IndexOfItem(){} // RVA: 0x7FFAC87BCAC0
        public void MergeItem(){} // RVA: 0x7FFAC87BCB80
        public void IndexOf(){} // RVA: 0x7FFAC87BCC70
        public void Insert(){} // RVA: 0x7FFAC87BCC90
        public void RemoveAt(){} // RVA: 0x7FFAC87BCCC0
        public void GetEnumerator(){} // RVA: 0x7FFAC87BCCE0
        public void Add(){} // RVA: 0x7FFAC87BCD70
        public void Clear(){} // RVA: 0x7FFAC87BCD90
        public void Contains(){} // RVA: 0x7FFAC87BCDB0
        public void CopyTo(){} // RVA: 0x7FFAC87BCDD0
        public void get_IsReadOnly(){} // RVA: 0x7FFAC2F21320
        public void Remove(){} // RVA: 0x7FFAC87BCDF0
        public void GetDeepHashCode(){} // RVA: 0x7FFAC87BCE10
    }

    public class JConstructor : JContainer
    {
        public string ChildrenTokens; // 0x58
        public System.Collections.Generic.List`1<Newtonsoft.Json.Linq.JToken> Name; // 0x60

        // ── Methods ──
        public void WriteToAsync(){} // RVA: 0x7FFAC87BDD90
        public void LoadAsync(){} // RVA: 0x7FFAC87BE080 | overloaded x2
        public void get_ChildrenTokens(){} // RVA: 0x7FFAC2FBF370
        public void IndexOfItem(){} // RVA: 0x7FFAC87BE2D0
        public void MergeItem(){} // RVA: 0x7FFAC87BE390
        public void get_Name(){} // RVA: 0x7FFAC2FE9500
        public void set_Name(){} // RVA: 0x7FFAC2FE9510
        public void get_Type(){} // RVA: 0x7FFAC366FE20
        public void .ctor(){} // RVA: 0x7FFAC87BE870 | overloaded x6
        public void DeepEquals(){} // RVA: 0x7FFAC87BEA70
        public void CloneToken(){} // RVA: 0x7FFAC87BEB60
        public void WriteTo(){} // RVA: 0x7FFAC87BECF0
        public void get_Item(){} // RVA: 0x7FFAC87BEE10
        public void set_Item(){} // RVA: 0x7FFAC87BEF80
        public void GetDeepHashCode(){} // RVA: 0x7FFAC87BF100
        public void Load(){} // RVA: 0x7FFAC87BF160 | overloaded x2
    }

    public class JContainer : JToken
    {
        public System.ComponentModel.ListChangedEventHandler ChildrenTokens; // 0x30
        public System.ComponentModel.AddingNewEventHandler HasValues; // 0x38
        public System.Collections.Specialized.NotifyCollectionChangedEventHandler First; // 0x40
        public object Last; // 0x48
        public bool System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.Item; // 0x50

        // ── Methods ──
        public void ReadTokenFromAsync(){} // RVA: 0x7FFAC87C03E0
        public void ReadContentFromAsync(){} // RVA: 0x7FFAC87C06B0
        public void add_ListChanged(){} // RVA: 0x7FFAC87C0980
        public void remove_ListChanged(){} // RVA: 0x7FFAC87C0A70
        public void add_AddingNew(){} // RVA: 0x7FFAC87C0B60
        public void remove_AddingNew(){} // RVA: 0x7FFAC87C0C50
        public void add_CollectionChanged(){} // RVA: 0x7FFAC87C0D40
        public void remove_CollectionChanged(){} // RVA: 0x7FFAC87C0E30
        public void get_ChildrenTokens(){} // RVA: 0x7FFAC2C58E90
        public void .ctor(){} // RVA: 0x7FFAC87C0F70 | overloaded x2
        public void CheckReentrancy(){} // RVA: 0x7FFAC87C1240
        public void CreateChildrenCollection(){} // RVA: 0x7FFAC87C12F0
        public void OnAddingNew(){} // RVA: 0x7FFAC7DB15B0
        public void OnListChanged(){} // RVA: 0x7FFAC87C1350
        public void OnCollectionChanged(){} // RVA: 0x7FFAC87C13C0
        public void get_HasValues(){} // RVA: 0x7FFAC87C1430
        public void ContentsEqual(){} // RVA: 0x7FFAC87C14A0
        public void get_First(){} // RVA: 0x7FFAC87C1600
        public void get_Last(){} // RVA: 0x7FFAC87C16A0
        public void Children(){} // RVA: 0x7FFAC87C1740
        public void Values(){} // RVA: 0x7FFAC2C58E90
        public void Descendants(){} // RVA: 0x7FFAC87C1860
        public void DescendantsAndSelf(){} // RVA: 0x7FFAC87C1870
        public void GetDescendants(){} // RVA: 0x7FFAC87C1880
        public void IsMultiContent(){} // RVA: 0x7FFAC87C1940
        public void EnsureParentToken(){} // RVA: 0x7FFAC87C1A20
        public void IndexOfItem(){} // RVA: 0x7FFAC2C5E6B0
        public void InsertItem(){} // RVA: 0x7FFAC87C1B70
        public void RemoveItemAt(){} // RVA: 0x7FFAC87C1FA0
        public void RemoveItem(){} // RVA: 0x7FFAC87C2330
        public void GetItem(){} // RVA: 0x7FFAC87C2380
        public void SetItem(){} // RVA: 0x7FFAC87C23F0
        public void ClearItems(){} // RVA: 0x7FFAC87C2890
        public void ReplaceItem(){} // RVA: 0x7FFAC87C2D60
        public void ContainsItem(){} // RVA: 0x7FFAC87C2DC0
        public void CopyItemsTo(){} // RVA: 0x7FFAC87C2DF0
        public void IsTokenUnchanged(){} // RVA: 0x7FFAC87C30E0
        public void ValidateToken(){} // RVA: 0x7FFAC87C31B0
        public void Add(){} // RVA: 0x7FFAC87C3310
        public void TryAdd(){} // RVA: 0x7FFAC87C33A0
        public void AddAndSkipParentCheck(){} // RVA: 0x7FFAC87C3430
        public void AddFirst(){} // RVA: 0x7FFAC87C34C0
        public void TryAddInternal(){} // RVA: 0x7FFAC87C34F0
        public void CreateFromContent(){} // RVA: 0x7FFAC87C37B0
        public void CreateWriter(){} // RVA: 0x7FFAC87C3870
        public void ReplaceAll(){} // RVA: 0x7FFAC87C3A20
        public void RemoveAll(){} // RVA: 0x7FFAC87BCD90
        public void MergeItem(){} // RVA: 0x7FFAC2C79B30
        public void Merge(){} // RVA: 0x7FFAC87C3AC0 | overloaded x2
        public void ValidateContent(){} // RVA: 0x7FFAC87C3B20
        public void ReadTokenFrom(){} // RVA: 0x7FFAC87C3CF0
        public void ReadContentFrom(){} // RVA: 0x7FFAC87C3EB0
        public void ReadProperty(){} // RVA: 0x7FFAC87C45D0
        public void ContentsHashCode(){} // RVA: 0x7FFAC87C4850
        public void System.ComponentModel.ITypedList.GetListName(){} // RVA: 0x7FFAC87C4A60
        public void System.ComponentModel.ITypedList.GetItemProperties(){} // RVA: 0x7FFAC87C4AA0
        public void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.IndexOf(){} // RVA: 0x7FFAC87BCC70
        public void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.Insert(){} // RVA: 0x7FFAC87BCC90
        public void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.RemoveAt(){} // RVA: 0x7FFAC87BCCC0
        public void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.get_Item(){} // RVA: 0x7FFAC87BCA80
        public void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.set_Item(){} // RVA: 0x7FFAC87BCAA0
        public void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Add(){} // RVA: 0x7FFAC87BCD70
        public void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Clear(){} // RVA: 0x7FFAC87BCD90
        public void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Contains(){} // RVA: 0x7FFAC87BCDB0
        public void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.CopyTo(){} // RVA: 0x7FFAC87BCDD0
        public void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.get_IsReadOnly(){} // RVA: 0x7FFAC2F21320
        public void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Remove(){} // RVA: 0x7FFAC87BCDF0
        public void EnsureValue(){} // RVA: 0x7FFAC87C4B70
        public void System.Collections.IList.Add(){} // RVA: 0x7FFAC87C4C30
        public void System.Collections.IList.Clear(){} // RVA: 0x7FFAC87BCD90
        public void System.Collections.IList.Contains(){} // RVA: 0x7FFAC87C4CC0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7FFAC87C4CF0
        public void System.Collections.IList.Insert(){} // RVA: 0x7FFAC87C4D20
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7FFAC2F21320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7FFAC2F21320
        public void System.Collections.IList.Remove(){} // RVA: 0x7FFAC87C4D80
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x7FFAC87BCCC0
        public void System.Collections.IList.get_Item(){} // RVA: 0x7FFAC87BCA80
        public void System.Collections.IList.set_Item(){} // RVA: 0x7FFAC87C4DB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAC87BCDD0
        public void get_Count(){} // RVA: 0x7FFAC87C4E00
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAC2F21320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAC87C4E70
        public void System.ComponentModel.IBindingList.AddIndex(){} // RVA: 0x7FFAC2F21310
        public void System.ComponentModel.IBindingList.AddNew(){} // RVA: 0x7FFAC87C4F20
        public void System.ComponentModel.IBindingList.get_AllowEdit(){} // RVA: 0x7FFAC3006850
        public void System.ComponentModel.IBindingList.get_AllowNew(){} // RVA: 0x7FFAC3006850
        public void System.ComponentModel.IBindingList.get_AllowRemove(){} // RVA: 0x7FFAC3006850
        public void System.ComponentModel.IBindingList.ApplySort(){} // RVA: 0x7FFAC87C5180
        public void System.ComponentModel.IBindingList.Find(){} // RVA: 0x7FFAC87C51C0
        public void System.ComponentModel.IBindingList.get_IsSorted(){} // RVA: 0x7FFAC2F21320
        public void System.ComponentModel.IBindingList.RemoveIndex(){} // RVA: 0x7FFAC2F21310
        public void System.ComponentModel.IBindingList.RemoveSort(){} // RVA: 0x7FFAC87C5200
        public void System.ComponentModel.IBindingList.get_SortDirection(){} // RVA: 0x7FFAC34F9180
        public void System.ComponentModel.IBindingList.get_SortProperty(){} // RVA: 0x7FFAC34F9180
        public void System.ComponentModel.IBindingList.get_SupportsChangeNotification(){} // RVA: 0x7FFAC3006850
        public void System.ComponentModel.IBindingList.get_SupportsSearching(){} // RVA: 0x7FFAC2F21320
        public void System.ComponentModel.IBindingList.get_SupportsSorting(){} // RVA: 0x7FFAC2F21320
        public void MergeEnumerableContent(){} // RVA: 0x7FFAC87C5240
    }

    public class JEnumerable`1 : ValueType
    {
        public Newtonsoft.Json.Linq.JEnumerable`1<T> Item;
        public System.Collections.Generic.IEnumerable`1<T> _enumerable;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70A40
        public void GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void get_Item(){} // RVA: 0x7FFAC2C58F40
        public void Equals(){} // RVA: 0x7FFAC2C59F60 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC2C59960
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
    }

    public class JObject : JContainer
    {
        public Newtonsoft.Json.Linq.JPropertyKeyedCollection ChildrenTokens; // 0x58
        public System.ComponentModel.PropertyChangedEventHandler Type; // 0x60
        public System.ComponentModel.PropertyChangingEventHandler Item; // 0x68

        // ── Methods ──
        public void WriteToAsync(){} // RVA: 0x7FFAC87C7AA0
        public void LoadAsync(){} // RVA: 0x7FFAC87C7D00 | overloaded x2
        public void get_ChildrenTokens(){} // RVA: 0x7FFAC2FE9500
        public void add_PropertyChanged(){} // RVA: 0x7FFAC87C7F50
        public void remove_PropertyChanged(){} // RVA: 0x7FFAC87C8040
        public void add_PropertyChanging(){} // RVA: 0x7FFAC87C8130
        public void remove_PropertyChanging(){} // RVA: 0x7FFAC87C8220
        public void .ctor(){} // RVA: 0x7FFAC87C8590 | overloaded x5
        public void DeepEquals(){} // RVA: 0x7FFAC87C8690
        public void IndexOfItem(){} // RVA: 0x7FFAC87C8740
        public void InsertItem(){} // RVA: 0x7FFAC87C8870
        public void ValidateToken(){} // RVA: 0x7FFAC87C88F0
        public void MergeItem(){} // RVA: 0x7FFAC87C8BF0
        public void IsNull(){} // RVA: 0x7FFAC87C8FA0
        public void InternalPropertyChanged(){} // RVA: 0x7FFAC87C9040
        public void InternalPropertyChanging(){} // RVA: 0x7FFAC87C9230
        public void CloneToken(){} // RVA: 0x7FFAC87C9260
        public void get_Type(){} // RVA: 0x7FFAC3013AF0
        public void Properties(){} // RVA: 0x7FFAC87C9360
        public void Property(){} // RVA: 0x7FFAC87C93B0 | overloaded x2
        public void PropertyValues(){} // RVA: 0x7FFAC87C95E0
        public void get_Item(){} // RVA: 0x7FFAC87C9B70 | overloaded x2
        public void set_Item(){} // RVA: 0x7FFAC87C9C40 | overloaded x2
        public void Load(){} // RVA: 0x7FFAC87C9D90 | overloaded x2
        public void Parse(){} // RVA: 0x7FFAC87CA010 | overloaded x2
        public void FromObject(){} // RVA: 0x7FFAC87CA2F0 | overloaded x2
        public void WriteTo(){} // RVA: 0x7FFAC87CA480
        public void GetValue(){} // RVA: 0x7FFAC87CA660 | overloaded x2
        public void TryGetValue(){} // RVA: 0x7FFAC87CA9D0 | overloaded x2
        public void Add(){} // RVA: 0x7FFAC87CA730
        public void ContainsKey(){} // RVA: 0x7FFAC87CA7C0
        public void System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.get_Keys(){} // RVA: 0x7FFAC87CA8D0
        public void Remove(){} // RVA: 0x7FFAC87CA930
        public void System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.get_Values(){} // RVA: 0x7FFAC87CAAC0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Add(){} // RVA: 0x7FFAC87CAB00
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Clear(){} // RVA: 0x7FFAC87BCD90
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Contains(){} // RVA: 0x7FFAC87CABB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.CopyTo(){} // RVA: 0x7FFAC87CAC40
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.get_IsReadOnly(){} // RVA: 0x7FFAC2F21320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Remove(){} // RVA: 0x7FFAC87CB020
        public void GetDeepHashCode(){} // RVA: 0x7FFAC87BCE10
        public void GetEnumerator(){} // RVA: 0x7FFAC87CB130
        public void OnPropertyChanged(){} // RVA: 0x7FFAC87CB1D0
        public void OnPropertyChanging(){} // RVA: 0x7FFAC87CB260
        public void System.ComponentModel.ICustomTypeDescriptor.GetProperties(){} // RVA: 0x7FFAC87CB3B0 | overloaded x2
        public void System.ComponentModel.ICustomTypeDescriptor.GetAttributes(){} // RVA: 0x7FFAC87CB710
        public void System.ComponentModel.ICustomTypeDescriptor.GetClassName(){} // RVA: 0x7FFAC34F9180
        public void System.ComponentModel.ICustomTypeDescriptor.GetComponentName(){} // RVA: 0x7FFAC34F9180
        public void System.ComponentModel.ICustomTypeDescriptor.GetConverter(){} // RVA: 0x7FFAC87CB770
        public void System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent(){} // RVA: 0x7FFAC34F9180
        public void System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty(){} // RVA: 0x7FFAC34F9180
        public void System.ComponentModel.ICustomTypeDescriptor.GetEditor(){} // RVA: 0x7FFAC34F9180
        public void System.ComponentModel.ICustomTypeDescriptor.GetEvents(){} // RVA: 0x7FFAC87CB810 | overloaded x2
        public void System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(){} // RVA: 0x7FFAC87CB870
        public void GetMetaObject(){} // RVA: 0x7FFAC87CB8F0
        public void <WriteToAsync>g__AwaitProperties|0_0(){} // RVA: 0x7FFAC87CB9D0
    }

    public class JProperty : JContainer
    {
        public JPropertyList ChildrenTokens; // 0x58
        public string Name; // 0x60

        // ── Methods ──
        public void WriteToAsync(){} // RVA: 0x7FFAC87CD920 | overloaded x2
        public void WriteValueAsync(){} // RVA: 0x7FFAC87CDC40
        public void LoadAsync(){} // RVA: 0x7FFAC87CDCC0 | overloaded x2
        public void get_ChildrenTokens(){} // RVA: 0x7FFAC2FE9500
        public void get_Name(){} // RVA: 0x7FFAC2FBF370
        public void get_Value(){} // RVA: 0x7FFAC87CDF10
        public void set_Value(){} // RVA: 0x7FFAC87CDF30
        public void .ctor(){} // RVA: 0x7FFAC87CED80 | overloaded x5
        public void GetItem(){} // RVA: 0x7FFAC87CE260
        public void SetItem(){} // RVA: 0x7FFAC87CE2D0
        public void RemoveItem(){} // RVA: 0x7FFAC87CE4D0
        public void RemoveItemAt(){} // RVA: 0x7FFAC87CE590
        public void IndexOfItem(){} // RVA: 0x7FFAC87CE650
        public void InsertItem(){} // RVA: 0x7FFAC87CE690
        public void ContainsItem(){} // RVA: 0x7FFAC87CE7C0
        public void MergeItem(){} // RVA: 0x7FFAC87CE7E0
        public void ClearItems(){} // RVA: 0x7FFAC87CE8A0
        public void DeepEquals(){} // RVA: 0x7FFAC87CE960
        public void CloneToken(){} // RVA: 0x7FFAC87CEA50
        public void get_Type(){} // RVA: 0x7FFAC36C3910
        public void WriteTo(){} // RVA: 0x7FFAC87CF010
        public void GetDeepHashCode(){} // RVA: 0x7FFAC87CF0B0
        public void Load(){} // RVA: 0x7FFAC87CF140 | overloaded x2
    }

    public class JPropertyDescriptor : PropertyDescriptor
    {
        public object ComponentType;
        public object IsReadOnly;
        public object PropertyType;
        public object NameHashCode;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC87D05F0
        public void CastInstance(){} // RVA: 0x7FFAC87D0600
        public void CanResetValue(){} // RVA: 0x7FFAC2F21320
        public void GetValue(){} // RVA: 0x7FFAC87D0680
        public void ResetValue(){} // RVA: 0x7FFAC2F21310
        public void SetValue(){} // RVA: 0x7FFAC87D07E0
        public void ShouldSerializeValue(){} // RVA: 0x7FFAC2F21320
        public void get_ComponentType(){} // RVA: 0x7FFAC87D0940
        public void get_IsReadOnly(){} // RVA: 0x7FFAC2F21320
        public void get_PropertyType(){} // RVA: 0x7FFAC87D09F0
        public void get_NameHashCode(){} // RVA: 0x7FFAC30DBBE0
    }

    public class JPropertyKeyedCollection : Collection`1
    {
        public System.Collections.Generic.IEqualityComparer`1<string> Item;
        public System.Collections.Generic.Dictionary`2<string,Newtonsoft.Json.Linq.JToken> Keys; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC87D0AA0
        public void AddKey(){} // RVA: 0x7FFAC87D0B80
        public void ChangeItemKey(){} // RVA: 0x7FFAC87D0C10
        public void ClearItems(){} // RVA: 0x7FFAC87D0E70
        public void Contains(){} // RVA: 0x7FFAC87D0F20
        public void ContainsItem(){} // RVA: 0x7FFAC87D0FF0
        public void EnsureDictionary(){} // RVA: 0x7FFAC87D10D0
        public void GetKeyForItem(){} // RVA: 0x7FFAC87D11E0
        public void InsertItem(){} // RVA: 0x7FFAC87D1260
        public void Remove(){} // RVA: 0x7FFAC87D1330
        public void RemoveItem(){} // RVA: 0x7FFAC87D1420
        public void RemoveKey(){} // RVA: 0x7FFAC87D15A0
        public void SetItem(){} // RVA: 0x7FFAC87D1600
        public void get_Item(){} // RVA: 0x7FFAC87D1870
        public void TryGetValue(){} // RVA: 0x7FFAC87D1960
        public void get_Keys(){} // RVA: 0x7FFAC87D1A30
        public void get_Values(){} // RVA: 0x7FFAC87D1A90
        public void IndexOfReference(){} // RVA: 0x7FFAC87D1AF0
        public void Compare(){} // RVA: 0x7FFAC87D1C00
        public void .cctor(){} // RVA: 0x7FFAC87D1FB0
    }

    public class JRaw : JValue
    {
        // ── Methods ──
        public void CreateAsync(){} // RVA: 0x7FFAC87D20B0
        public void .ctor(){} // RVA: 0x7FFAC87D2450 | overloaded x3
        public void Create(){} // RVA: 0x7FFAC87D2460
        public void CloneToken(){} // RVA: 0x7FFAC87D2770
    }

    public class JToken : Object
    {
        public Newtonsoft.Json.Linq.JTokenEqualityComparer EqualityComparer;
        public Newtonsoft.Json.Linq.JContainer Parent; // 0x10
        public Newtonsoft.Json.Linq.JToken Root; // 0x18
        public Newtonsoft.Json.Linq.JToken Type; // 0x20
        public object HasValues; // 0x28
        public 0x6B1CB2D8[] Next; // 0x8
        public 0x6B1CB2D8[] Previous; // 0x10
        public 0x6B1CB2D8[] Path; // 0x18
        public 0x6B1CB2D8[] Item; // 0x20
        public 0x6B1CB2D8[] First; // 0x28
        public 0x6B1CB2D8[] Last; // 0x30
        public 0x6B1CB2D8[] Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JToken>.Item; // 0x38
        public 0x6B1CB2D8[] Newtonsoft.Json.IJsonLineInfo.LineNumber; // 0x40
        public 0x6B1CB2D8[] Newtonsoft.Json.IJsonLineInfo.LinePosition; // 0x48
        public 0x6B1CB2D8[] BytesTypes; // 0x50

        // ── Methods ──
        public void WriteToAsync(){} // RVA: 0x7FFAC87D3330 | overloaded x2
        public void ReadFromAsync(){} // RVA: 0x7FFAC87D33C0 | overloaded x2
        public void LoadAsync(){} // RVA: 0x7FFAC87D36C0 | overloaded x2
        public void get_EqualityComparer(){} // RVA: 0x7FFAC87D3730
        public void get_Parent(){} // RVA: 0x7FFAC2F3C380
        public void set_Parent(){} // RVA: 0x7FFAC2F22E30
        public void get_Root(){} // RVA: 0x7FFAC87D3860
        public void CloneToken(){} // RVA: 0x7FFAC2C58F40
        public void DeepEquals(){} // RVA: 0x7FFAC87D3890 | overloaded x2
        public void get_Type(){} // RVA: 0x7FFAC2C59960
        public void get_HasValues(){} // RVA: 0x7FFAC2C59D00
        public void get_Next(){} // RVA: 0x7FFAC2F4F0C0
        public void set_Next(){} // RVA: 0x7FFAC2F4F0D0
        public void get_Previous(){} // RVA: 0x7FFAC2F247C0
        public void set_Previous(){} // RVA: 0x7FFAC2F87E80
        public void get_Path(){} // RVA: 0x7FFAC87D38C0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void AddAfterSelf(){} // RVA: 0x7FFAC87D3CA0
        public void AddBeforeSelf(){} // RVA: 0x7FFAC87D3D50
        public void Ancestors(){} // RVA: 0x7FFAC87D3E00
        public void AncestorsAndSelf(){} // RVA: 0x7FFAC87D3E10
        public void GetAncestors(){} // RVA: 0x7FFAC87D3E20
        public void AfterSelf(){} // RVA: 0x7FFAC87D3EE0
        public void BeforeSelf(){} // RVA: 0x7FFAC87D3F90
        public void get_Item(){} // RVA: 0x7FFAC87D4040
        public void set_Item(){} // RVA: 0x7FFAC87D40E0
        public void Value(){} // RVA: 0x7FFAC2E8DC40
        public void get_First(){} // RVA: 0x7FFAC87D4180
        public void get_Last(){} // RVA: 0x7FFAC87D4220
        public void Children(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void Values(){} // RVA: 0x7FFAC2C58E90
        public void Remove(){} // RVA: 0x7FFAC87D4320
        public void Replace(){} // RVA: 0x7FFAC87D43A0
        public void WriteTo(){} // RVA: 0x7FFAC2C79B30
        public void ToString(){} // RVA: 0x7FFAC87D4470 | overloaded x2
        public void EnsureValue(){} // RVA: 0x7FFAC87D46C0
        public void GetType(){} // RVA: 0x7FFAC87D47F0
        public void ValidateToken(){} // RVA: 0x7FFAC87D4920
        public void op_Explicit(){} // RVA: 0x7FFAC87DB540 | overloaded x37
        public void ToBigInteger(){} // RVA: 0x7FFAC87DB7F0
        public void ToBigIntegerNullable(){} // RVA: 0x7FFAC87DBA40
        public void op_Implicit(){} // RVA: 0x7FFAC87DCFB0 | overloaded x35
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC87DD050
        public void System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator(){} // RVA: 0x7FFAC87DD090
        public void GetDeepHashCode(){} // RVA: 0x7FFAC2C59960
        public void Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JToken>.get_Item(){} // RVA: 0x7FFAC87DD120
        public void CreateReader(){} // RVA: 0x7FFAC87DD140
        public void FromObjectInternal(){} // RVA: 0x7FFAC87DD1A0
        public void FromObject(){} // RVA: 0x7FFAC87DD440 | overloaded x2
        public void ToObject(){} // RVA: 0x7FFAC87DE680 | overloaded x4
        public void ReadFrom(){} // RVA: 0x7FFAC87DE930 | overloaded x2
        public void Parse(){} // RVA: 0x7FFAC87DED50 | overloaded x2
        public void Load(){} // RVA: 0x7FFAC87DEF60 | overloaded x2
        public void SetLineInfo(){} // RVA: 0x7FFAC87DF0E0 | overloaded x2
        public void Newtonsoft.Json.IJsonLineInfo.HasLineInfo(){} // RVA: 0x7FFAC87DF150
        public void Newtonsoft.Json.IJsonLineInfo.get_LineNumber(){} // RVA: 0x7FFAC87DF1A0
        public void Newtonsoft.Json.IJsonLineInfo.get_LinePosition(){} // RVA: 0x7FFAC87DF1F0
        public void SelectToken(){} // RVA: 0x7FFAC87DF2D0 | overloaded x3
        public void SelectTokens(){} // RVA: 0x7FFAC87DF550 | overloaded x3
        public void GetMetaObject(){} // RVA: 0x7FFAC87DF5F0
        public void System.Dynamic.IDynamicMetaObjectProvider.GetMetaObject(){} // RVA: 0x7FFAC69624A0
        public void System.ICloneable.Clone(){} // RVA: 0x7FFAC87DF6C0
        public void DeepClone(){} // RVA: 0x7FFAC87DF6E0 | overloaded x2
        public void AddAnnotation(){} // RVA: 0x7FFAC87DF700
        public void Annotation(){} // RVA: 0x7FFAC87DFA40 | overloaded x2
        public void Annotations(){} // RVA: 0x7FFAC87DFBA0 | overloaded x2
        public void RemoveAnnotations(){} // RVA: 0x7FFAC87DFCB0 | overloaded x2
        public void CopyAnnotations(){} // RVA: 0x7FFAC87DFF20
        public void .cctor(){} // RVA: 0x7FFAC87E00C0
    }

    public class JTokenEqualityComparer : Object
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC87E21F0
        public void GetHashCode(){} // RVA: 0x7FFAC87E2290
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class JTokenReader : JsonReader
    {
        public Newtonsoft.Json.Linq.JToken CurrentToken; // 0x78
        public string Newtonsoft.Json.IJsonLineInfo.LineNumber; // 0x80
        public Newtonsoft.Json.Linq.JToken Newtonsoft.Json.IJsonLineInfo.LinePosition; // 0x88
        public Newtonsoft.Json.Linq.JToken Path; // 0x90

        // ── Methods ──
        public void get_CurrentToken(){} // RVA: 0x7FFAC32EF640
        public void .ctor(){} // RVA: 0x7FFAC87E23F0 | overloaded x2
        public void Read(){} // RVA: 0x7FFAC87E2470
        public void ReadOver(){} // RVA: 0x7FFAC87E26C0
        public void ReadToEnd(){} // RVA: 0x7FFAC87E27B0
        public void GetEndToken(){} // RVA: 0x7FFAC87E28B0
        public void ReadInto(){} // RVA: 0x7FFAC87E2A10
        public void SetEnd(){} // RVA: 0x7FFAC87E2B40
        public void SetToken(){} // RVA: 0x7FFAC87E2DA0
        public void SafeToString(){} // RVA: 0x7FFAC87E38C0
        public void Newtonsoft.Json.IJsonLineInfo.HasLineInfo(){} // RVA: 0x7FFAC87E38F0
        public void Newtonsoft.Json.IJsonLineInfo.get_LineNumber(){} // RVA: 0x7FFAC87E3950
        public void Newtonsoft.Json.IJsonLineInfo.get_LinePosition(){} // RVA: 0x7FFAC87E39B0
        public void get_Path(){} // RVA: 0x7FFAC87E3A10
    }

    public class JTokenWriter : JsonWriter
    {
        public Newtonsoft.Json.Linq.JContainer CurrentToken; // 0x60
        public Newtonsoft.Json.Linq.JContainer Token; // 0x68
        public Newtonsoft.Json.Linq.JValue _value; // 0x70
        public Newtonsoft.Json.Linq.JToken _current; // 0x78

        // ── Methods ──
        public void WriteTokenAsync(){} // RVA: 0x7FFAC87E3CB0
        public void get_CurrentToken(){} // RVA: 0x7FFAC30E5600
        public void get_Token(){} // RVA: 0x7FFAC87E3DC0
        public void .ctor(){} // RVA: 0x7FFAC87E3F60 | overloaded x2
        public void Flush(){} // RVA: 0x7FFAC2F21310
        public void Close(){} // RVA: 0x7FFAC87E3FC0
        public void WriteStartObject(){} // RVA: 0x7FFAC87E3FD0
        public void AddParent(){} // RVA: 0x7FFAC87E4060
        public void RemoveParent(){} // RVA: 0x7FFAC87E4230
        public void WriteStartArray(){} // RVA: 0x7FFAC87E4390
        public void WriteStartConstructor(){} // RVA: 0x7FFAC87E4420
        public void WriteEnd(){} // RVA: 0x7FFAC87E4230
        public void WritePropertyName(){} // RVA: 0x7FFAC87E44C0
        public void AddRawValue(){} // RVA: 0x7FFAC87E4670
        public void AddJValue(){} // RVA: 0x7FFAC87E4710
        public void WriteValue(){} // RVA: 0x7FFAC87E59D0 | overloaded x21
        public void WriteNull(){} // RVA: 0x7FFAC87E4A00
        public void WriteUndefined(){} // RVA: 0x7FFAC87E4A90
        public void WriteRaw(){} // RVA: 0x7FFAC87E4B20
        public void WriteComment(){} // RVA: 0x7FFAC87E4BA0
        public void WriteToken(){} // RVA: 0x7FFAC87E5AC0
    }

    public class JValue : JToken
    {
        public 0x6B1CB2D8 HasValues; // 0x30
        public object Type; // 0x38

        // ── Methods ──
        public void WriteToAsync(){} // RVA: 0x7FFAC87E5E80
        public void .ctor(){} // RVA: 0x7FFAC87E7010 | overloaded x17
        public void DeepEquals(){} // RVA: 0x7FFAC87E7050
        public void get_HasValues(){} // RVA: 0x7FFAC2F21320
        public void CompareBigInteger(){} // RVA: 0x7FFAC87E7120
        public void Compare(){} // RVA: 0x7FFAC87E7530
        public void CompareFloat(){} // RVA: 0x7FFAC87E82B0
        public void Operation(){} // RVA: 0x7FFAC87E8480
        public void CloneToken(){} // RVA: 0x7FFAC87E9080
        public void CreateComment(){} // RVA: 0x7FFAC87E9190
        public void CreateString(){} // RVA: 0x7FFAC87E91F0
        public void CreateNull(){} // RVA: 0x7FFAC87E9250
        public void CreateUndefined(){} // RVA: 0x7FFAC87E92B0
        public void GetValueType(){} // RVA: 0x7FFAC87E9310
        public void GetStringValueType(){} // RVA: 0x7FFAC87E98C0
        public void get_Type(){} // RVA: 0x7FFAC2F7CCD0
        public void get_Value(){} // RVA: 0x7FFAC31D0140
        public void set_Value(){} // RVA: 0x7FFAC87E9930
        public void WriteTo(){} // RVA: 0x7FFAC87E9A60
        public void GetDeepHashCode(){} // RVA: 0x7FFAC87EA4E0
        public void ValuesEquals(){} // RVA: 0x7FFAC87EA520
        public void Equals(){} // RVA: 0x7FFAC87EA5C0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC87EA690
        public void ToString(){} // RVA: 0x7FFAC87EA7F0 | overloaded x4
        public void GetMetaObject(){} // RVA: 0x7FFAC87EA8D0
        public void System.IComparable.CompareTo(){} // RVA: 0x7FFAC87EA9B0
        public void CompareTo(){} // RVA: 0x7FFAC87EAA70
        public void System.IConvertible.GetTypeCode(){} // RVA: 0x7FFAC87EAAA0
        public void System.IConvertible.ToBoolean(){} // RVA: 0x7FFAC87EAB10
        public void System.IConvertible.ToChar(){} // RVA: 0x7FFAC87EAB60
        public void System.IConvertible.ToSByte(){} // RVA: 0x7FFAC87EABB0
        public void System.IConvertible.ToByte(){} // RVA: 0x7FFAC87EAC00
        public void System.IConvertible.ToInt16(){} // RVA: 0x7FFAC87EAC50
        public void System.IConvertible.ToUInt16(){} // RVA: 0x7FFAC87EACA0
        public void System.IConvertible.ToInt32(){} // RVA: 0x7FFAC87EACF0
        public void System.IConvertible.ToUInt32(){} // RVA: 0x7FFAC87EAD40
        public void System.IConvertible.ToInt64(){} // RVA: 0x7FFAC87EAD90
        public void System.IConvertible.ToUInt64(){} // RVA: 0x7FFAC87EADE0
        public void System.IConvertible.ToSingle(){} // RVA: 0x7FFAC87EAE30
        public void System.IConvertible.ToDouble(){} // RVA: 0x7FFAC87EAE80
        public void System.IConvertible.ToDecimal(){} // RVA: 0x7FFAC87EAED0
        public void System.IConvertible.ToDateTime(){} // RVA: 0x7FFAC87EAF40
        public void System.IConvertible.ToType(){} // RVA: 0x7FFAC87EAF90
    }

    public class JsonCloneSettings : Object
    {
        public Newtonsoft.Json.Linq.JsonCloneSettings CopyAnnotations;
        public bool <CopyAnnotations>k__BackingField; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC322C870
        public void get_CopyAnnotations(){} // RVA: 0x7FFAC2FEB5E0
        public void set_CopyAnnotations(){} // RVA: 0x7FFAC2FEB5F0
        public void .cctor(){} // RVA: 0x7FFAC87D2F90
    }

    public class JsonLoadSettings : Object
    {
        public 0x6B1CA0A0 CommentHandling; // 0x10
        public 0x6B1CB438 LineInfoHandling; // 0x14
        public 0x6B1CA0F8 DuplicatePropertyNameHandling; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC87D3030
        public void get_CommentHandling(){} // RVA: 0x7FFAC2F6E5C0
        public void set_CommentHandling(){} // RVA: 0x7FFAC87D3040
        public void get_LineInfoHandling(){} // RVA: 0x7FFAC33D5A20
        public void set_LineInfoHandling(){} // RVA: 0x7FFAC87D30B0
        public void get_DuplicatePropertyNameHandling(){} // RVA: 0x7FFAC3157800
        public void set_DuplicatePropertyNameHandling(){} // RVA: 0x7FFAC87D3120
    }

    public class JsonMergeSettings : Object
    {
        public 0x6B1CB490 MergeArrayHandling; // 0x10
        public 0x6B1CB4E8 MergeNullValueHandling; // 0x14
        public 0x6B0C1288 PropertyNameComparison; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC87D3190
        public void get_MergeArrayHandling(){} // RVA: 0x7FFAC2F6E5C0
        public void set_MergeArrayHandling(){} // RVA: 0x7FFAC87D31A0
        public void get_MergeNullValueHandling(){} // RVA: 0x7FFAC33D5A20
        public void set_MergeNullValueHandling(){} // RVA: 0x7FFAC87D3210
        public void get_PropertyNameComparison(){} // RVA: 0x7FFAC3157800
        public void set_PropertyNameComparison(){} // RVA: 0x7FFAC87D3280
    }

    public class JsonSelectSettings : Object
    {
        public System.Nullable`1<System.TimeSpan> RegexMatchTimeout; // 0x10
        public bool ErrorWhenNoMatch; // 0x20

        // ── Methods ──
        public void get_RegexMatchTimeout(){} // RVA: 0x7FFAC4422E80
        public void set_RegexMatchTimeout(){} // RVA: 0x7FFAC4422E90
        public void get_ErrorWhenNoMatch(){} // RVA: 0x7FFAC300F9D0
        public void set_ErrorWhenNoMatch(){} // RVA: 0x7FFAC300F9E0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

}