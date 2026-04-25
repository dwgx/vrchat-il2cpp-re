// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Newtonsoft.Newtonsoft.Json.Linq
// Classes: 5
// Methods: 289

namespace ThirdParty.Newtonsoft.Newtonsoft.Json.Linq
{
    public class Extensions : Object
    {
        // ── Methods ──
        public void Ancestors(){} // RVA: 0x7FFD4E078F80
        public void AncestorsAndSelf(){} // RVA: 0x7FFD4E078F80
        public void Descendants(){} // RVA: 0x7FFD4E078F80
        public void DescendantsAndSelf(){} // RVA: 0x7FFD4E078F80
        public void Properties(){} // RVA: 0x7FFD53BDB0D0
        public void Values(){} // RVA: 0x7FFD4E078FF0 | overloaded x5
        public void Value(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void Children(){} // RVA: 0x7FFD4E078F80 | overloaded x2
        public void Convert(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void AsJEnumerable(){} // RVA: 0x7FFD4E078F80 | overloaded x2
    }

    public class IJEnumerable`1
    {
        public <>c<T> Item;

        // ── Methods ──
        public void get_Item(){} // RVA: 0x7FFD4E078F40
    }

    public class JContainer : JToken
    {
        public 0x66494B90 ChildrenTokens; // 0x30
        public 0x66492E58 HasValues; // 0x38
        public 0x66497D10 First; // 0x40
        public object Last; // 0x48
        public bool System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.Item; // 0x50

        // ── Methods ──
        public void ReadTokenFromAsync(){} // RVA: 0x7FFD53BE03E0
        public void ReadContentFromAsync(){} // RVA: 0x7FFD53BE06B0
        public void add_ListChanged(){} // RVA: 0x7FFD53BE0980
        public void remove_ListChanged(){} // RVA: 0x7FFD53BE0A70
        public void add_AddingNew(){} // RVA: 0x7FFD53BE0B60
        public void remove_AddingNew(){} // RVA: 0x7FFD53BE0C50
        public void add_CollectionChanged(){} // RVA: 0x7FFD53BE0D40
        public void remove_CollectionChanged(){} // RVA: 0x7FFD53BE0E30
        public void get_ChildrenTokens(){} // RVA: 0x7FFD4E078E90
        public void .ctor(){} // RVA: 0x7FFD53BE0F70 | overloaded x2
        public void CheckReentrancy(){} // RVA: 0x7FFD53BE1240
        public void CreateChildrenCollection(){} // RVA: 0x7FFD53BE12F0
        public void OnAddingNew(){} // RVA: 0x7FFD531D15B0
        public void OnListChanged(){} // RVA: 0x7FFD53BE1350
        public void OnCollectionChanged(){} // RVA: 0x7FFD53BE13C0
        public void get_HasValues(){} // RVA: 0x7FFD53BE1430
        public void ContentsEqual(){} // RVA: 0x7FFD53BE14A0
        public void get_First(){} // RVA: 0x7FFD53BE1600
        public void get_Last(){} // RVA: 0x7FFD53BE16A0
        public void Children(){} // RVA: 0x7FFD53BE1740
        public void Values(){} // RVA: 0x7FFD4E078E90
        public void Descendants(){} // RVA: 0x7FFD53BE1860
        public void DescendantsAndSelf(){} // RVA: 0x7FFD53BE1870
        public void GetDescendants(){} // RVA: 0x7FFD53BE1880
        public void IsMultiContent(){} // RVA: 0x7FFD53BE1940
        public void EnsureParentToken(){} // RVA: 0x7FFD53BE1A20
        public void IndexOfItem(){} // RVA: 0x7FFD4E07E6B0
        public void InsertItem(){} // RVA: 0x7FFD53BE1B70
        public void RemoveItemAt(){} // RVA: 0x7FFD53BE1FA0
        public void RemoveItem(){} // RVA: 0x7FFD53BE2330
        public void GetItem(){} // RVA: 0x7FFD53BE2380
        public void SetItem(){} // RVA: 0x7FFD53BE23F0
        public void ClearItems(){} // RVA: 0x7FFD53BE2890
        public void ReplaceItem(){} // RVA: 0x7FFD53BE2D60
        public void ContainsItem(){} // RVA: 0x7FFD53BE2DC0
        public void CopyItemsTo(){} // RVA: 0x7FFD53BE2DF0
        public void IsTokenUnchanged(){} // RVA: 0x7FFD53BE30E0
        public void ValidateToken(){} // RVA: 0x7FFD53BE31B0
        public void Add(){} // RVA: 0x7FFD53BE3310
        public void TryAdd(){} // RVA: 0x7FFD53BE33A0
        public void AddAndSkipParentCheck(){} // RVA: 0x7FFD53BE3430
        public void AddFirst(){} // RVA: 0x7FFD53BE34C0
        public void TryAddInternal(){} // RVA: 0x7FFD53BE34F0
        public void CreateFromContent(){} // RVA: 0x7FFD53BE37B0
        public void CreateWriter(){} // RVA: 0x7FFD53BE3870
        public void ReplaceAll(){} // RVA: 0x7FFD53BE3A20
        public void RemoveAll(){} // RVA: 0x7FFD53BDCD90
        public void MergeItem(){} // RVA: 0x7FFD4E099B30
        public void Merge(){} // RVA: 0x7FFD53BE3AC0 | overloaded x2
        public void ValidateContent(){} // RVA: 0x7FFD53BE3B20
        public void ReadTokenFrom(){} // RVA: 0x7FFD53BE3CF0
        public void ReadContentFrom(){} // RVA: 0x7FFD53BE3EB0
        public void ReadProperty(){} // RVA: 0x7FFD53BE45D0
        public void ContentsHashCode(){} // RVA: 0x7FFD53BE4850
        public void System.ComponentModel.ITypedList.GetListName(){} // RVA: 0x7FFD53BE4A60
        public void System.ComponentModel.ITypedList.GetItemProperties(){} // RVA: 0x7FFD53BE4AA0
        public void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.IndexOf(){} // RVA: 0x7FFD53BDCC70
        public void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.Insert(){} // RVA: 0x7FFD53BDCC90
        public void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.RemoveAt(){} // RVA: 0x7FFD53BDCCC0
        public void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.get_Item(){} // RVA: 0x7FFD53BDCA80
        public void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.set_Item(){} // RVA: 0x7FFD53BDCAA0
        public void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Add(){} // RVA: 0x7FFD53BDCD70
        public void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Clear(){} // RVA: 0x7FFD53BDCD90
        public void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Contains(){} // RVA: 0x7FFD53BDCDB0
        public void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.CopyTo(){} // RVA: 0x7FFD53BDCDD0
        public void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.get_IsReadOnly(){} // RVA: 0x7FFD4E341320
        public void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Remove(){} // RVA: 0x7FFD53BDCDF0
        public void EnsureValue(){} // RVA: 0x7FFD53BE4B70
        public void System.Collections.IList.Add(){} // RVA: 0x7FFD53BE4C30
        public void System.Collections.IList.Clear(){} // RVA: 0x7FFD53BDCD90
        public void System.Collections.IList.Contains(){} // RVA: 0x7FFD53BE4CC0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7FFD53BE4CF0
        public void System.Collections.IList.Insert(){} // RVA: 0x7FFD53BE4D20
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7FFD4E341320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7FFD4E341320
        public void System.Collections.IList.Remove(){} // RVA: 0x7FFD53BE4D80
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x7FFD53BDCCC0
        public void System.Collections.IList.get_Item(){} // RVA: 0x7FFD53BDCA80
        public void System.Collections.IList.set_Item(){} // RVA: 0x7FFD53BE4DB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFD53BDCDD0
        public void get_Count(){} // RVA: 0x7FFD53BE4E00
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFD4E341320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFD53BE4E70
        public void System.ComponentModel.IBindingList.AddIndex(){} // RVA: 0x7FFD4E341310
        public void System.ComponentModel.IBindingList.AddNew(){} // RVA: 0x7FFD53BE4F20
        public void System.ComponentModel.IBindingList.get_AllowEdit(){} // RVA: 0x7FFD4E426850
        public void System.ComponentModel.IBindingList.get_AllowNew(){} // RVA: 0x7FFD4E426850
        public void System.ComponentModel.IBindingList.get_AllowRemove(){} // RVA: 0x7FFD4E426850
        public void System.ComponentModel.IBindingList.ApplySort(){} // RVA: 0x7FFD53BE5180
        public void System.ComponentModel.IBindingList.Find(){} // RVA: 0x7FFD53BE51C0
        public void System.ComponentModel.IBindingList.get_IsSorted(){} // RVA: 0x7FFD4E341320
        public void System.ComponentModel.IBindingList.RemoveIndex(){} // RVA: 0x7FFD4E341310
        public void System.ComponentModel.IBindingList.RemoveSort(){} // RVA: 0x7FFD53BE5200
        public void System.ComponentModel.IBindingList.get_SortDirection(){} // RVA: 0x7FFD4E919180
        public void System.ComponentModel.IBindingList.get_SortProperty(){} // RVA: 0x7FFD4E919180
        public void System.ComponentModel.IBindingList.get_SupportsChangeNotification(){} // RVA: 0x7FFD4E426850
        public void System.ComponentModel.IBindingList.get_SupportsSearching(){} // RVA: 0x7FFD4E341320
        public void System.ComponentModel.IBindingList.get_SupportsSorting(){} // RVA: 0x7FFD4E341320
        public void MergeEnumerableContent(){} // RVA: 0x7FFD53BE5240
    }

    public class JEnumerable`1 : ValueType
    {
        public Newtonsoft.Json.Linq.JEnumerable`1<T> Item;
        public System.Collections.Generic.IEnumerable`1<T> _enumerable;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090A40
        public void GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void get_Item(){} // RVA: 0x7FFD4E078F40
        public void Equals(){} // RVA: 0x7FFD4E079F60 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD4E079960
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

    public class JToken : Object
    {
        public 0x6652B228 EqualityComparer;
        public Newtonsoft.Json.Linq.JContainer Parent; // 0x10
        public Newtonsoft.Json.Linq.JToken Root; // 0x18
        public Newtonsoft.Json.Linq.JToken Type; // 0x20
        public object HasValues; // 0x28
        public 0x6652B2D8[] Next; // 0x8
        public 0x6652B2D8[] Previous; // 0x10
        public 0x6652B2D8[] Path; // 0x18
        public 0x6652B2D8[] Item; // 0x20
        public 0x6652B2D8[] First; // 0x28
        public 0x6652B2D8[] Last; // 0x30
        public 0x6652B2D8[] Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JToken>.Item; // 0x38
        public 0x6652B2D8[] Newtonsoft.Json.IJsonLineInfo.LineNumber; // 0x40
        public 0x6652B2D8[] Newtonsoft.Json.IJsonLineInfo.LinePosition; // 0x48
        public 0x6652B2D8[] BytesTypes; // 0x50

        // ── Methods ──
        public void WriteToAsync(){} // RVA: 0x7FFD53BF3330 | overloaded x2
        public void ReadFromAsync(){} // RVA: 0x7FFD53BF33C0 | overloaded x2
        public void LoadAsync(){} // RVA: 0x7FFD53BF36C0 | overloaded x2
        public void get_EqualityComparer(){} // RVA: 0x7FFD53BF3730
        public void get_Parent(){} // RVA: 0x7FFD4E35C380
        public void set_Parent(){} // RVA: 0x7FFD4E342E30
        public void get_Root(){} // RVA: 0x7FFD53BF3860
        public void CloneToken(){} // RVA: 0x7FFD4E078F40
        public void DeepEquals(){} // RVA: 0x7FFD53BF3890 | overloaded x2
        public void get_Type(){} // RVA: 0x7FFD4E079960
        public void get_HasValues(){} // RVA: 0x7FFD4E079D00
        public void get_Next(){} // RVA: 0x7FFD4E36F0C0
        public void set_Next(){} // RVA: 0x7FFD4E36F0D0
        public void get_Previous(){} // RVA: 0x7FFD4E3447C0
        public void set_Previous(){} // RVA: 0x7FFD4E3A7E80
        public void get_Path(){} // RVA: 0x7FFD53BF38C0
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void AddAfterSelf(){} // RVA: 0x7FFD53BF3CA0
        public void AddBeforeSelf(){} // RVA: 0x7FFD53BF3D50
        public void Ancestors(){} // RVA: 0x7FFD53BF3E00
        public void AncestorsAndSelf(){} // RVA: 0x7FFD53BF3E10
        public void GetAncestors(){} // RVA: 0x7FFD53BF3E20
        public void AfterSelf(){} // RVA: 0x7FFD53BF3EE0
        public void BeforeSelf(){} // RVA: 0x7FFD53BF3F90
        public void get_Item(){} // RVA: 0x7FFD53BF4040
        public void set_Item(){} // RVA: 0x7FFD53BF40E0
        public void Value(){} // RVA: 0x7FFD4E2ADC40
        public void get_First(){} // RVA: 0x7FFD53BF4180
        public void get_Last(){} // RVA: 0x7FFD53BF4220
        public void Children(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void Values(){} // RVA: 0x7FFD4E078E90
        public void Remove(){} // RVA: 0x7FFD53BF4320
        public void Replace(){} // RVA: 0x7FFD53BF43A0
        public void WriteTo(){} // RVA: 0x7FFD4E099B30
        public void ToString(){} // RVA: 0x7FFD53BF4470 | overloaded x2
        public void EnsureValue(){} // RVA: 0x7FFD53BF46C0
        public void GetType(){} // RVA: 0x7FFD53BF47F0
        public void ValidateToken(){} // RVA: 0x7FFD53BF4920
        public void op_Explicit(){} // RVA: 0x7FFD53BFB540 | overloaded x37
        public void ToBigInteger(){} // RVA: 0x7FFD53BFB7F0
        public void ToBigIntegerNullable(){} // RVA: 0x7FFD53BFBA40
        public void op_Implicit(){} // RVA: 0x7FFD53BFCFB0 | overloaded x35
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD53BFD050
        public void System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator(){} // RVA: 0x7FFD53BFD090
        public void GetDeepHashCode(){} // RVA: 0x7FFD4E079960
        public void Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JToken>.get_Item(){} // RVA: 0x7FFD53BFD120
        public void CreateReader(){} // RVA: 0x7FFD53BFD140
        public void FromObjectInternal(){} // RVA: 0x7FFD53BFD1A0
        public void FromObject(){} // RVA: 0x7FFD53BFD440 | overloaded x2
        public void ToObject(){} // RVA: 0x7FFD53BFE680 | overloaded x4
        public void ReadFrom(){} // RVA: 0x7FFD53BFE930 | overloaded x2
        public void Parse(){} // RVA: 0x7FFD53BFED50 | overloaded x2
        public void Load(){} // RVA: 0x7FFD53BFEF60 | overloaded x2
        public void SetLineInfo(){} // RVA: 0x7FFD53BFF0E0 | overloaded x2
        public void Newtonsoft.Json.IJsonLineInfo.HasLineInfo(){} // RVA: 0x7FFD53BFF150
        public void Newtonsoft.Json.IJsonLineInfo.get_LineNumber(){} // RVA: 0x7FFD53BFF1A0
        public void Newtonsoft.Json.IJsonLineInfo.get_LinePosition(){} // RVA: 0x7FFD53BFF1F0
        public void SelectToken(){} // RVA: 0x7FFD53BFF2D0 | overloaded x3
        public void SelectTokens(){} // RVA: 0x7FFD53BFF550 | overloaded x3
        public void GetMetaObject(){} // RVA: 0x7FFD53BFF5F0
        public void System.Dynamic.IDynamicMetaObjectProvider.GetMetaObject(){} // RVA: 0x7FFD51D824A0
        public void System.ICloneable.Clone(){} // RVA: 0x7FFD53BFF6C0
        public void DeepClone(){} // RVA: 0x7FFD53BFF6E0 | overloaded x2
        public void AddAnnotation(){} // RVA: 0x7FFD53BFF700
        public void Annotation(){} // RVA: 0x7FFD53BFFA40 | overloaded x2
        public void Annotations(){} // RVA: 0x7FFD53BFFBA0 | overloaded x2
        public void RemoveAnnotations(){} // RVA: 0x7FFD53BFFCB0 | overloaded x2
        public void CopyAnnotations(){} // RVA: 0x7FFD53BFFF20
        public void .cctor(){} // RVA: 0x7FFD53C000C0
    }

}