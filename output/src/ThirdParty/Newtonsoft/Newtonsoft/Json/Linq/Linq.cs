// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Newtonsoft.Newtonsoft.Json.Linq
// Classes: 22
// Methods: 476

namespace ThirdParty.Newtonsoft.Newtonsoft.Json.Linq
{
    public class Extensions : Object
    {
        // ── Methods ──
        public void Ancestors(){} // RVA: 0x7A7E00BA0
        public void AncestorsAndSelf(){} // RVA: 0x7A7E00BA0
        public void Descendants(){} // RVA: 0x7A7E00BA0
        public void DescendantsAndSelf(){} // RVA: 0x7A7E00BA0
        public void Properties(){} // RVA: 0x7ADE10370
        public void Values(){} // RVA: 0x7A7E00C10
        public void Value(){} // RVA: 0x7A8051B10
        public void Children(){} // RVA: 0x7A7E00BA0
        public void Convert(){} // RVA: 0x7A8051B10
        public void AsJEnumerable(){} // RVA: 0x7A7E00BA0
    }

    public class IJEnumerable`1
    {
        // ── Methods ──
        public void get_Item(){} // RVA: 0x7A7E00B20
    }

    public class JArray : JContainer
    {
        // ── Methods ──
        public void WriteToAsync(){} // RVA: 0x7ADE10780
        public void LoadAsync(){} // RVA: 0x7ADE10A70
        public void get_ChildrenTokens(){} // RVA: 0x7A81A0050
        public void get_Type(){} // RVA: 0x7A81DDCC0
        public void .ctor(){} // RVA: 0x7ADE10FA0
        public void DeepEquals(){} // RVA: 0x7ADE110B0
        public void CloneToken(){} // RVA: 0x7ADE11140
        public void Load(){} // RVA: 0x7ADE11260
        public void Parse(){} // RVA: 0x7ADE11490
        public void FromObject(){} // RVA: 0x7ADE11780
        public void WriteTo(){} // RVA: 0x7ADE11910
        public void get_Item(){} // RVA: 0x7ADE11D40
        public void set_Item(){} // RVA: 0x7ADE11D60
        public void IndexOfItem(){} // RVA: 0x7ADE11D80
        public void MergeItem(){} // RVA: 0x7ADE11E30
        public void IndexOf(){} // RVA: 0x7ADE11F20
        public void Insert(){} // RVA: 0x7ADE11F40
        public void RemoveAt(){} // RVA: 0x7ADE11F70
        public void GetEnumerator(){} // RVA: 0x7ADE11F90
        public void Add(){} // RVA: 0x7ADE12020
        public void Clear(){} // RVA: 0x7ADE12040
        public void Contains(){} // RVA: 0x7ADE12060
        public void CopyTo(){} // RVA: 0x7ADE12080
        public void get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void Remove(){} // RVA: 0x7ADE120A0
        public void GetDeepHashCode(){} // RVA: 0x7ADE120C0
    }

    public class JConstructor : JContainer
    {
        // ── Methods ──
        public void WriteToAsync(){} // RVA: 0x7ADE13040
        public void LoadAsync(){} // RVA: 0x7ADE13330
        public void get_ChildrenTokens(){} // RVA: 0x7A8175DF0
        public void IndexOfItem(){} // RVA: 0x7ADE13580
        public void MergeItem(){} // RVA: 0x7ADE13630
        public void get_Name(){} // RVA: 0x7A81A0050
        public void set_Name(){} // RVA: 0x7A81A0060
        public void get_Type(){} // RVA: 0x7A87EE0F0
        public void .ctor(){} // RVA: 0x7ADE13AF0
        public void DeepEquals(){} // RVA: 0x7ADE13CF0
        public void CloneToken(){} // RVA: 0x7ADE13DB0
        public void WriteTo(){} // RVA: 0x7ADE13F40
        public void get_Item(){} // RVA: 0x7ADE14080
        public void set_Item(){} // RVA: 0x7ADE141F0
        public void GetDeepHashCode(){} // RVA: 0x7ADE14370
        public void Load(){} // RVA: 0x7ADE143D0
    }

    public class JContainer : JToken
    {
        // ── Methods ──
        public void ReadTokenFromAsync(){} // RVA: 0x7ADE15650
        public void ReadContentFromAsync(){} // RVA: 0x7ADE15920
        public void add_ListChanged(){} // RVA: 0x7ADE15BF0
        public void remove_ListChanged(){} // RVA: 0x7ADE15CE0
        public void add_AddingNew(){} // RVA: 0x7ADE15DD0
        public void remove_AddingNew(){} // RVA: 0x7ADE15EC0
        public void add_CollectionChanged(){} // RVA: 0x7ADE15FB0
        public void remove_CollectionChanged(){} // RVA: 0x7ADE160A0
        public void get_ChildrenTokens(){} // RVA: 0x7A7E00680
        public void .ctor(){} // RVA: 0x7ADE161E0
        public void CheckReentrancy(){} // RVA: 0x7ADE164B0
        public void CreateChildrenCollection(){} // RVA: 0x7ADE16560
        public void OnAddingNew(){} // RVA: 0x7AD4F2F40
        public void OnListChanged(){} // RVA: 0x7ADE165C0
        public void OnCollectionChanged(){} // RVA: 0x7ADE16630
        public void get_HasValues(){} // RVA: 0x7ADE166A0
        public void ContentsEqual(){} // RVA: 0x7ADE16710
        public void get_First(){} // RVA: 0x7ADE16870
        public void get_Last(){} // RVA: 0x7ADE16910
        public void Children(){} // RVA: 0x7ADE169B0
        public void Values(){} // RVA: 0x7A7E00680
        public void Descendants(){} // RVA: 0x7ADE16AE0
        public void DescendantsAndSelf(){} // RVA: 0x7ADE16AF0
        public void GetDescendants(){} // RVA: 0x7ADE16B00
        public void IsMultiContent(){} // RVA: 0x7ADE16BC0
        public void EnsureParentToken(){} // RVA: 0x7ADE16CA0
        public void IndexOfItem(){} // RVA: 0x7A7E01630
        public void InsertItem(){} // RVA: 0x7ADE16DF0
        public void RemoveItemAt(){} // RVA: 0x7ADE17220
        public void RemoveItem(){} // RVA: 0x7ADE175B0
        public void GetItem(){} // RVA: 0x7ADE17600
        public void SetItem(){} // RVA: 0x7ADE17670
        public void ClearItems(){} // RVA: 0x7ADE17B00
        public void ReplaceItem(){} // RVA: 0x7ADE17FF0
        public void ContainsItem(){} // RVA: 0x7ADE18050
        public void CopyItemsTo(){} // RVA: 0x7ADE18080
        public void IsTokenUnchanged(){} // RVA: 0x7ADE18370
        public void ValidateToken(){} // RVA: 0x7ADE18430
        public void Add(){} // RVA: 0x7ADE18590
        public void TryAdd(){} // RVA: 0x7ADE18620
        public void AddAndSkipParentCheck(){} // RVA: 0x7ADE186B0
        public void AddFirst(){} // RVA: 0x7ADE18740
        public void TryAddInternal(){} // RVA: 0x7ADE18770
        public void CreateFromContent(){} // RVA: 0x7ADE18A20
        public void CreateWriter(){} // RVA: 0x7ADE18AE0
        public void ReplaceAll(){} // RVA: 0x7ADE18C90
        public void RemoveAll(){} // RVA: 0x7ADE12040
        public void MergeItem(){} // RVA: 0x7A7E18890
        public void Merge(){} // RVA: 0x7ADE18D30
        public void ValidateContent(){} // RVA: 0x7ADE18D90
        public void ReadTokenFrom(){} // RVA: 0x7ADE18F60
        public void ReadContentFrom(){} // RVA: 0x7ADE19120
        public void ReadProperty(){} // RVA: 0x7ADE19830
        public void ContentsHashCode(){} // RVA: 0x7ADE19AB0
        public void System.ComponentModel.ITypedList.GetListName(){} // RVA: 0x7ADE19CC0
        public void System.ComponentModel.ITypedList.GetItemProperties(){} // RVA: 0x7ADE19D00
        public void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.IndexOf(){} // RVA: 0x7ADE11F20
        public void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.Insert(){} // RVA: 0x7ADE11F40
        public void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.RemoveAt(){} // RVA: 0x7ADE11F70
        public void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.get_Item(){} // RVA: 0x7ADE11D40
        public void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.set_Item(){} // RVA: 0x7ADE11D60
        public void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Add(){} // RVA: 0x7ADE12020
        public void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Clear(){} // RVA: 0x7ADE12040
        public void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Contains(){} // RVA: 0x7ADE12060
        public void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.CopyTo(){} // RVA: 0x7ADE12080
        public void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Remove(){} // RVA: 0x7ADE120A0
        public void EnsureValue(){} // RVA: 0x7ADE19DD0
        public void System.Collections.IList.Add(){} // RVA: 0x7ADE19E90
        public void System.Collections.IList.Clear(){} // RVA: 0x7ADE12040
        public void System.Collections.IList.Contains(){} // RVA: 0x7ADE19F20
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ADE19F50
        public void System.Collections.IList.Insert(){} // RVA: 0x7ADE19F80
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IList.Remove(){} // RVA: 0x7ADE19FE0
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x7ADE11F70
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ADE11D40
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ADE1A010
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ADE12080
        public void get_Count(){} // RVA: 0x7ADE1A060
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ADE1A0D0
        public void System.ComponentModel.IBindingList.AddIndex(){} // RVA: 0x7A80D7310
        public void System.ComponentModel.IBindingList.AddNew(){} // RVA: 0x7ADE1A180
        public void System.ComponentModel.IBindingList.get_AllowEdit(){} // RVA: 0x7A81BD750
        public void System.ComponentModel.IBindingList.get_AllowNew(){} // RVA: 0x7A81BD750
        public void System.ComponentModel.IBindingList.get_AllowRemove(){} // RVA: 0x7A81BD750
        public void System.ComponentModel.IBindingList.ApplySort(){} // RVA: 0x7ADE1A3C0
        public void System.ComponentModel.IBindingList.Find(){} // RVA: 0x7ADE1A400
        public void System.ComponentModel.IBindingList.get_IsSorted(){} // RVA: 0x7A80D7320
        public void System.ComponentModel.IBindingList.RemoveIndex(){} // RVA: 0x7A80D7310
        public void System.ComponentModel.IBindingList.RemoveSort(){} // RVA: 0x7ADE1A440
        public void System.ComponentModel.IBindingList.get_SortDirection(){} // RVA: 0x7A82D1450
        public void System.ComponentModel.IBindingList.get_SortProperty(){} // RVA: 0x7A82D1450
        public void System.ComponentModel.IBindingList.get_SupportsChangeNotification(){} // RVA: 0x7A81BD750
        public void System.ComponentModel.IBindingList.get_SupportsSearching(){} // RVA: 0x7A80D7320
        public void System.ComponentModel.IBindingList.get_SupportsSorting(){} // RVA: 0x7A80D7320
        public void MergeEnumerableContent(){} // RVA: 0x7ADE1A480
    }

    public class JEnumerable`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E18800
        public void GetEnumerator(){} // RVA: 0x7A7E00680
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7A7E00680
        public void get_Item(){} // RVA: 0x7A7E00B20
        public void Equals(){} // RVA: 0x7A7E019D0
        public void GetHashCode(){} // RVA: 0x7A7E00710
        public void .cctor(){} // RVA: 0x7A7E187D0
    }

    public class JObject : JContainer
    {
        // ── Methods ──
        public void WriteToAsync(){} // RVA: 0x7ADE1CC60
        public void LoadAsync(){} // RVA: 0x7ADE1CED0
        public void get_ChildrenTokens(){} // RVA: 0x7A81A0050
        public void add_PropertyChanged(){} // RVA: 0x7ADE1D120
        public void remove_PropertyChanged(){} // RVA: 0x7ADE1D210
        public void add_PropertyChanging(){} // RVA: 0x7ADE1D300
        public void remove_PropertyChanging(){} // RVA: 0x7ADE1D3F0
        public void .ctor(){} // RVA: 0x7ADE1D760
        public void DeepEquals(){} // RVA: 0x7ADE1D860
        public void IndexOfItem(){} // RVA: 0x7ADE1D900
        public void InsertItem(){} // RVA: 0x7ADE1DA40
        public void ValidateToken(){} // RVA: 0x7ADE1DAC0
        public void MergeItem(){} // RVA: 0x7ADE1DDC0
        public void IsNull(){} // RVA: 0x7ADE1E150
        public void InternalPropertyChanged(){} // RVA: 0x7ADE1E1F0
        public void InternalPropertyChanging(){} // RVA: 0x7ADE1E3E0
        public void CloneToken(){} // RVA: 0x7ADE1E410
        public void get_Type(){} // RVA: 0x7A81CA9D0
        public void Properties(){} // RVA: 0x7ADE1E510
        public void Property(){} // RVA: 0x7ADE1E560
        public void PropertyValues(){} // RVA: 0x7ADE1E790
        public void get_Item(){} // RVA: 0x7ADE1ED40
        public void set_Item(){} // RVA: 0x7ADE1EE10
        public void Load(){} // RVA: 0x7ADE1EF60
        public void Parse(){} // RVA: 0x7ADE1F1E0
        public void FromObject(){} // RVA: 0x7ADE1F4D0
        public void WriteTo(){} // RVA: 0x7ADE1F660
        public void GetValue(){} // RVA: 0x7ADE1F840
        public void TryGetValue(){} // RVA: 0x7ADE1FBB0
        public void Add(){} // RVA: 0x7ADE1F910
        public void ContainsKey(){} // RVA: 0x7ADE1F9A0
        public void System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.get_Keys(){} // RVA: 0x7ADE1FAB0
        public void Remove(){} // RVA: 0x7ADE1FB10
        public void System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.get_Values(){} // RVA: 0x7ADE1FCA0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Add(){} // RVA: 0x7ADE1FCE0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Clear(){} // RVA: 0x7ADE12040
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Contains(){} // RVA: 0x7ADE1FD90
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.CopyTo(){} // RVA: 0x7ADE1FE20
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Remove(){} // RVA: 0x7ADE20200
        public void GetDeepHashCode(){} // RVA: 0x7ADE120C0
        public void GetEnumerator(){} // RVA: 0x7ADE20310
        public void OnPropertyChanged(){} // RVA: 0x7ADE203B0
        public void OnPropertyChanging(){} // RVA: 0x7ADE20440
        public void System.ComponentModel.ICustomTypeDescriptor.GetProperties(){} // RVA: 0x7ADE20590
        public void System.ComponentModel.ICustomTypeDescriptor.GetAttributes(){} // RVA: 0x7ADE208F0
        public void System.ComponentModel.ICustomTypeDescriptor.GetClassName(){} // RVA: 0x7A82D1450
        public void System.ComponentModel.ICustomTypeDescriptor.GetComponentName(){} // RVA: 0x7A82D1450
        public void System.ComponentModel.ICustomTypeDescriptor.GetConverter(){} // RVA: 0x7ADE20950
        public void System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent(){} // RVA: 0x7A82D1450
        public void System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty(){} // RVA: 0x7A82D1450
        public void System.ComponentModel.ICustomTypeDescriptor.GetEditor(){} // RVA: 0x7A82D1450
        public void System.ComponentModel.ICustomTypeDescriptor.GetEvents(){} // RVA: 0x7ADE209F0
        public void System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(){} // RVA: 0x7ADE20A50
        public void GetMetaObject(){} // RVA: 0x7ADE20AD0
        public void <WriteToAsync>g__AwaitProperties|0_0(){} // RVA: 0x7ADE20BB0
    }

    public class JProperty : JContainer
    {
        // ── Methods ──
        public void WriteToAsync(){} // RVA: 0x7ADE22B00
        public void WriteValueAsync(){} // RVA: 0x7ADE22E20
        public void LoadAsync(){} // RVA: 0x7ADE22EA0
        public void get_ChildrenTokens(){} // RVA: 0x7A81A0050
        public void get_Name(){} // RVA: 0x7A8175DF0
        public void get_Value(){} // RVA: 0x7ADE230F0
        public void set_Value(){} // RVA: 0x7ADE23110
        public void .ctor(){} // RVA: 0x7ADE23F10
        public void GetItem(){} // RVA: 0x7ADE23440
        public void SetItem(){} // RVA: 0x7ADE234B0
        public void RemoveItem(){} // RVA: 0x7ADE236A0
        public void RemoveItemAt(){} // RVA: 0x7ADE23760
        public void IndexOfItem(){} // RVA: 0x7ADE23820
        public void InsertItem(){} // RVA: 0x7ADE23860
        public void ContainsItem(){} // RVA: 0x7ADE23990
        public void MergeItem(){} // RVA: 0x7ADE239B0
        public void ClearItems(){} // RVA: 0x7ADE23A60
        public void DeepEquals(){} // RVA: 0x7ADE23B20
        public void CloneToken(){} // RVA: 0x7ADE23BE0
        public void get_Type(){} // RVA: 0x7A883BE70
        public void WriteTo(){} // RVA: 0x7ADE241B0
        public void GetDeepHashCode(){} // RVA: 0x7ADE24250
        public void Load(){} // RVA: 0x7ADE242E0
    }

    public class JPropertyDescriptor : PropertyDescriptor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADE25790
        public void CastInstance(){} // RVA: 0x7ADE257A0
        public void CanResetValue(){} // RVA: 0x7A80D7320
        public void GetValue(){} // RVA: 0x7ADE25820
        public void ResetValue(){} // RVA: 0x7A80D7310
        public void SetValue(){} // RVA: 0x7ADE25970
        public void ShouldSerializeValue(){} // RVA: 0x7A80D7320
        public void get_ComponentType(){} // RVA: 0x7ADE25AB0
        public void get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void get_PropertyType(){} // RVA: 0x7ADE25B60
        public void get_NameHashCode(){} // RVA: 0x7A851DB90
    }

    public class JPropertyKeyedCollection : Collection`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADE25C10
        public void AddKey(){} // RVA: 0x7ADE25CF0
        public void ChangeItemKey(){} // RVA: 0x7ADE25D80
        public void ClearItems(){} // RVA: 0x7ADE25FE0
        public void Contains(){} // RVA: 0x7ADE26090
        public void ContainsItem(){} // RVA: 0x7ADE26160
        public void EnsureDictionary(){} // RVA: 0x7ADE26240
        public void GetKeyForItem(){} // RVA: 0x7ADE26350
        public void InsertItem(){} // RVA: 0x7ADE263D0
        public void Remove(){} // RVA: 0x7ADE264A0
        public void RemoveItem(){} // RVA: 0x7ADE26590
        public void RemoveKey(){} // RVA: 0x7ADE26710
        public void SetItem(){} // RVA: 0x7ADE26770
        public void get_Item(){} // RVA: 0x7ADE269E0
        public void TryGetValue(){} // RVA: 0x7ADE26AD0
        public void get_Keys(){} // RVA: 0x7ADE26BA0
        public void get_Values(){} // RVA: 0x7ADE26C00
        public void IndexOfReference(){} // RVA: 0x7ADE26C60
        public void Compare(){} // RVA: 0x7ADE26D70
        public void .cctor(){} // RVA: 0x7ADE27130
    }

    public class JRaw : JValue
    {
        // ── Methods ──
        public void CreateAsync(){} // RVA: 0x7ADE27230
        public void .ctor(){} // RVA: 0x7ADE275C0
        public void Create(){} // RVA: 0x7ADE275D0
        public void CloneToken(){} // RVA: 0x7ADE278F0
    }

    public class JToken : Object
    {
        // ── Methods ──
        public void WriteToAsync(){} // RVA: 0x7ADE284B0
        public void ReadFromAsync(){} // RVA: 0x7ADE28540
        public void LoadAsync(){} // RVA: 0x7ADE28840
        public void get_EqualityComparer(){} // RVA: 0x7ADE288B0
        public void get_Parent(){} // RVA: 0x7A80F2570
        public void set_Parent(){} // RVA: 0x7A80D8E20
        public void get_Root(){} // RVA: 0x7ADE289E0
        public void CloneToken(){} // RVA: 0x7A7E00B20
        public void DeepEquals(){} // RVA: 0x7ADE28A10
        public void get_Type(){} // RVA: 0x7A7E00710
        public void get_HasValues(){} // RVA: 0x7A7E01900
        public void get_Next(){} // RVA: 0x7A81052C0
        public void set_Next(){} // RVA: 0x7A81052D0
        public void get_Previous(){} // RVA: 0x7A80DA7B0
        public void set_Previous(){} // RVA: 0x7A813E420
        public void get_Path(){} // RVA: 0x7ADE28A40
        public void .ctor(){} // RVA: 0x7A80D7310
        public void AddAfterSelf(){} // RVA: 0x7ADE28DE0
        public void AddBeforeSelf(){} // RVA: 0x7ADE28E90
        public void Ancestors(){} // RVA: 0x7ADE28F40
        public void AncestorsAndSelf(){} // RVA: 0x7ADE28F50
        public void GetAncestors(){} // RVA: 0x7ADE28F60
        public void AfterSelf(){} // RVA: 0x7ADE29020
        public void BeforeSelf(){} // RVA: 0x7ADE290D0
        public void get_Item(){} // RVA: 0x7ADE29180
        public void set_Item(){} // RVA: 0x7ADE29220
        public void Value(){} // RVA: 0x7A8051B10
        public void get_First(){} // RVA: 0x7ADE292C0
        public void get_Last(){} // RVA: 0x7ADE29360
        public void Children(){} // RVA: 0x7A8051B10
        public void Values(){} // RVA: 0x7A7E00680
        public void Remove(){} // RVA: 0x7ADE29460
        public void Replace(){} // RVA: 0x7ADE294E0
        public void WriteTo(){} // RVA: 0x7A7E18890
        public void ToString(){} // RVA: 0x7ADE295B0
        public void EnsureValue(){} // RVA: 0x7ADE29800
        public void GetType(){} // RVA: 0x7ADE29930
        public void ValidateToken(){} // RVA: 0x7ADE29A60
        public void op_Explicit(){} // RVA: 0x7ADE306B0
        public void ToBigInteger(){} // RVA: 0x7ADE30950
        public void ToBigIntegerNullable(){} // RVA: 0x7ADE30BA0
        public void op_Implicit(){} // RVA: 0x7ADE32160
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ADE32200
        public void System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator(){} // RVA: 0x7ADE32240
        public void GetDeepHashCode(){} // RVA: 0x7A7E00710
        public void Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JToken>.get_Item(){} // RVA: 0x7ADE322D0
        public void CreateReader(){} // RVA: 0x7ADE322F0
        public void FromObjectInternal(){} // RVA: 0x7ADE32350
        public void FromObject(){} // RVA: 0x7ADE32600
        public void ToObject(){} // RVA: 0x7ADE33840
        public void ReadFrom(){} // RVA: 0x7ADE33B00
        public void Parse(){} // RVA: 0x7ADE33F20
        public void Load(){} // RVA: 0x7ADE34140
        public void SetLineInfo(){} // RVA: 0x7ADE342C0
        public void Newtonsoft.Json.IJsonLineInfo.HasLineInfo(){} // RVA: 0x7ADE34330
        public void Newtonsoft.Json.IJsonLineInfo.get_LineNumber(){} // RVA: 0x7ADE34380
        public void Newtonsoft.Json.IJsonLineInfo.get_LinePosition(){} // RVA: 0x7ADE343D0
        public void SelectToken(){} // RVA: 0x7ADE344B0
        public void SelectTokens(){} // RVA: 0x7ADE34750
        public void GetMetaObject(){} // RVA: 0x7ADE347F0
        public void System.Dynamic.IDynamicMetaObjectProvider.GetMetaObject(){} // RVA: 0x7ABE50F70
        public void System.ICloneable.Clone(){} // RVA: 0x7ADE348C0
        public void DeepClone(){} // RVA: 0x7ADE348E0
        public void AddAnnotation(){} // RVA: 0x7ADE34900
        public void Annotation(){} // RVA: 0x7ADE34C40
        public void Annotations(){} // RVA: 0x7ADE34DB0
        public void RemoveAnnotations(){} // RVA: 0x7ADE34EC0
        public void CopyAnnotations(){} // RVA: 0x7ADE35140
        public void .cctor(){} // RVA: 0x7ADE352E0
    }

    public class JTokenEqualityComparer : Object
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7ADE37410
        public void GetHashCode(){} // RVA: 0x7ADE374B0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class JTokenReader : JsonReader
    {
        // ── Methods ──
        public void get_CurrentToken(){} // RVA: 0x7A8555100
        public void .ctor(){} // RVA: 0x7ADE37610
        public void Read(){} // RVA: 0x7ADE37690
        public void ReadOver(){} // RVA: 0x7ADE378E0
        public void ReadToEnd(){} // RVA: 0x7ADE379D0
        public void GetEndToken(){} // RVA: 0x7ADE37A50
        public void ReadInto(){} // RVA: 0x7ADE37BB0
        public void SetEnd(){} // RVA: 0x7ADE37CE0
        public void SetToken(){} // RVA: 0x7ADE37F40
        public void SafeToString(){} // RVA: 0x7ADE38640
        public void Newtonsoft.Json.IJsonLineInfo.HasLineInfo(){} // RVA: 0x7ADE38670
        public void Newtonsoft.Json.IJsonLineInfo.get_LineNumber(){} // RVA: 0x7ADE386D0
        public void Newtonsoft.Json.IJsonLineInfo.get_LinePosition(){} // RVA: 0x7ADE38730
        public void get_Path(){} // RVA: 0x7ADE38790
    }

    public class JTokenType[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D3F10
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29EBF0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6990
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA281BF0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29EBF0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class JTokenWriter : JsonWriter
    {
        // ── Methods ──
        public void WriteTokenAsync(){} // RVA: 0x7ADE38A30
        public void get_CurrentToken(){} // RVA: 0x7A82C2060
        public void get_Token(){} // RVA: 0x7ADE38B40
        public void .ctor(){} // RVA: 0x7ADE38CE0
        public void Flush(){} // RVA: 0x7A80D7310
        public void Close(){} // RVA: 0x7ADE38D40
        public void WriteStartObject(){} // RVA: 0x7ADE38D50
        public void AddParent(){} // RVA: 0x7ADE38DE0
        public void RemoveParent(){} // RVA: 0x7ADE38FB0
        public void WriteStartArray(){} // RVA: 0x7ADE39110
        public void WriteStartConstructor(){} // RVA: 0x7ADE391A0
        public void WriteEnd(){} // RVA: 0x7ADE38FB0
        public void WritePropertyName(){} // RVA: 0x7ADE39240
        public void AddRawValue(){} // RVA: 0x7ADE393E0
        public void AddJValue(){} // RVA: 0x7ADE39480
        public void WriteValue(){} // RVA: 0x7ADE3A730
        public void WriteNull(){} // RVA: 0x7ADE39770
        public void WriteUndefined(){} // RVA: 0x7ADE39800
        public void WriteRaw(){} // RVA: 0x7ADE39890
        public void WriteComment(){} // RVA: 0x7ADE39910
        public void WriteToken(){} // RVA: 0x7ADE3A860
    }

    public class JToken[] : Array
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

    public class JValue : JToken
    {
        // ── Methods ──
        public void WriteToAsync(){} // RVA: 0x7ADE3AC20
        public void .ctor(){} // RVA: 0x7ADE3BDC0
        public void DeepEquals(){} // RVA: 0x7ADE3BE00
        public void get_HasValues(){} // RVA: 0x7A80D7320
        public void CompareBigInteger(){} // RVA: 0x7ADE3BEC0
        public void Compare(){} // RVA: 0x7ADE3C2D0
        public void CompareFloat(){} // RVA: 0x7ADE3D050
        public void Operation(){} // RVA: 0x7ADE3D220
        public void CloneToken(){} // RVA: 0x7ADE3DE20
        public void CreateComment(){} // RVA: 0x7ADE3DF30
        public void CreateString(){} // RVA: 0x7ADE3DF90
        public void CreateNull(){} // RVA: 0x7ADE3DFF0
        public void CreateUndefined(){} // RVA: 0x7ADE3E050
        public void GetValueType(){} // RVA: 0x7ADE3E0B0
        public void GetStringValueType(){} // RVA: 0x7ADE3E660
        public void get_Type(){} // RVA: 0x7A8133100
        public void get_Value(){} // RVA: 0x7A8292C30
        public void set_Value(){} // RVA: 0x7ADE3E6D0
        public void WriteTo(){} // RVA: 0x7ADE3E800
        public void GetDeepHashCode(){} // RVA: 0x7ADE3F270
        public void ValuesEquals(){} // RVA: 0x7ADE3F2B0
        public void Equals(){} // RVA: 0x7ADE3F350
        public void GetHashCode(){} // RVA: 0x7ADE3F410
        public void ToString(){} // RVA: 0x7ADE3F570
        public void GetMetaObject(){} // RVA: 0x7ADE3F650
        public void System.IComparable.CompareTo(){} // RVA: 0x7ADE3F730
        public void CompareTo(){} // RVA: 0x7ADE3F7F0
        public void System.IConvertible.GetTypeCode(){} // RVA: 0x7ADE3F820
        public void System.IConvertible.ToBoolean(){} // RVA: 0x7ADE3F890
        public void System.IConvertible.ToChar(){} // RVA: 0x7ADE3F8E0
        public void System.IConvertible.ToSByte(){} // RVA: 0x7ADE3F930
        public void System.IConvertible.ToByte(){} // RVA: 0x7ADE3F980
        public void System.IConvertible.ToInt16(){} // RVA: 0x7ADE3F9D0
        public void System.IConvertible.ToUInt16(){} // RVA: 0x7ADE3FA20
        public void System.IConvertible.ToInt32(){} // RVA: 0x7ADE3FA70
        public void System.IConvertible.ToUInt32(){} // RVA: 0x7ADE3FAC0
        public void System.IConvertible.ToInt64(){} // RVA: 0x7ADE3FB10
        public void System.IConvertible.ToUInt64(){} // RVA: 0x7ADE3FB60
        public void System.IConvertible.ToSingle(){} // RVA: 0x7ADE3FBB0
        public void System.IConvertible.ToDouble(){} // RVA: 0x7ADE3FC00
        public void System.IConvertible.ToDecimal(){} // RVA: 0x7ADE3FC50
        public void System.IConvertible.ToDateTime(){} // RVA: 0x7ADE3FCC0
        public void System.IConvertible.ToType(){} // RVA: 0x7ADE3FD10
    }

    public class JsonCloneSettings : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A847A240
        public void get_CopyAnnotations(){} // RVA: 0x7A81A2200
        public void set_CopyAnnotations(){} // RVA: 0x7A81A2210
        public void .cctor(){} // RVA: 0x7ADE28110
    }

    public class JsonLoadSettings : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADE281B0
        public void get_CommentHandling(){} // RVA: 0x7A8124910
        public void set_CommentHandling(){} // RVA: 0x7ADE281C0
        public void get_LineInfoHandling(){} // RVA: 0x7A8668BC0
        public void set_LineInfoHandling(){} // RVA: 0x7ADE28230
        public void get_DuplicatePropertyNameHandling(){} // RVA: 0x7A83782A0
        public void set_DuplicatePropertyNameHandling(){} // RVA: 0x7ADE282A0
    }

    public class JsonMergeSettings : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADE28310
        public void get_MergeArrayHandling(){} // RVA: 0x7A8124910
        public void set_MergeArrayHandling(){} // RVA: 0x7ADE28320
        public void get_MergeNullValueHandling(){} // RVA: 0x7A8668BC0
        public void set_MergeNullValueHandling(){} // RVA: 0x7ADE28390
        public void get_PropertyNameComparison(){} // RVA: 0x7A83782A0
        public void set_PropertyNameComparison(){} // RVA: 0x7ADE28400
    }

    public class JsonSelectSettings : Object
    {
        // ── Methods ──
        public void get_RegexMatchTimeout(){} // RVA: 0x7A97277F0
        public void set_RegexMatchTimeout(){} // RVA: 0x7A9727800
        public void get_ErrorWhenNoMatch(){} // RVA: 0x7A81C68D0
        public void set_ErrorWhenNoMatch(){} // RVA: 0x7A81C68E0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

}