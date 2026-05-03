// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 13
// Methods: 177

public class JArray : Object
{
    public JArray Empty;
    public System.Collections.Generic.IReadOnlyList`1<Token> m_Values; // 0x10
    public object field_2; // 0x959
    public object field_3; // 0x95A
    public object field_4; // 0x95B
    public object field_5; // 0x95C
    public object field_6; // 0x95D
    public object field_7; // 0x95E
    public object field_8; // 0x95F
    public object field_9; // 0x960
    public object field_10; // 0x961
    public object field_11; // 0x962

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8A2650C0
    public void ToLegacyList(){} // RVA: 0x7FFE8A265180
    public void GetEnumerator(){} // RVA: 0x7FFE8A265480
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE8A265600
    public void System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator(){} // RVA: 0x7FFE8A265640
    public void get_Item(){} // RVA: 0x7FFE8A2656E0
    public void System.Collections.Generic.IList<BestHTTP.JSON.Json.Token>.get_Item(){} // RVA: 0x7FFE8A2657D0
    public void System.Collections.Generic.IList<BestHTTP.JSON.Json.Token>.set_Item(){} // RVA: 0x7FFE8A2658C0
    public void System.Collections.Generic.IReadOnlyList<System.Object>.get_Item(){} // RVA: 0x7FFE8A265900
    public void System.Collections.Generic.IList<System.Object>.get_Item(){} // RVA: 0x7FFE8A265990
    public void System.Collections.Generic.IList<System.Object>.set_Item(){} // RVA: 0x7FFE8A265A20
    public void System.Collections.IList.get_Item(){} // RVA: 0x7FFE8A265A60
    public void System.Collections.IList.set_Item(){} // RVA: 0x7FFE8A265AF0
    public void get_Count(){} // RVA: 0x7FFE8A265B30
    public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFE8A265B80
    public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFE810FB320
    public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7FFE811E0850
    public void System.Collections.Generic.ICollection<System.Object>.get_IsReadOnly(){} // RVA: 0x7FFE811E0850
    public void System.Collections.Generic.ICollection<BestHTTP.JSON.Json.Token>.get_IsReadOnly(){} // RVA: 0x7FFE811E0850
    public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7FFE811E0850
    public void System.Collections.IList.Add(){} // RVA: 0x7FFE8A265BE0
    public void System.Collections.Generic.ICollection<System.Object>.Add(){} // RVA: 0x7FFE8A265C20
    public void System.Collections.Generic.ICollection<BestHTTP.JSON.Json.Token>.Add(){} // RVA: 0x7FFE8A265C60
    public void System.Collections.IList.Clear(){} // RVA: 0x7FFE8A265CA0
    public void System.Collections.Generic.ICollection<System.Object>.Clear(){} // RVA: 0x7FFE8A265CE0
    public void System.Collections.Generic.ICollection<BestHTTP.JSON.Json.Token>.Clear(){} // RVA: 0x7FFE8A265D20
    public void System.Collections.IList.Contains(){} // RVA: 0x7FFE8A265D60
    public void System.Collections.Generic.ICollection<System.Object>.Contains(){} // RVA: 0x7FFE8A265E00
    public void Contains(){} // RVA: 0x7FFE8A265EA0
    public void System.Collections.IList.IndexOf(){} // RVA: 0x7FFE8A265ED0
    public void System.Collections.Generic.IList<System.Object>.IndexOf(){} // RVA: 0x7FFE8A265F70
    public void IndexOf(){} // RVA: 0x7FFE8A266010
    public void System.Collections.IList.Insert(){} // RVA: 0x7FFE8A2661D0
    public void System.Collections.Generic.IList<System.Object>.Insert(){} // RVA: 0x7FFE8A266210
    public void System.Collections.Generic.IList<BestHTTP.JSON.Json.Token>.Insert(){} // RVA: 0x7FFE8A266250
    public void System.Collections.IList.Remove(){} // RVA: 0x7FFE8A266290
    public void System.Collections.Generic.ICollection<System.Object>.Remove(){} // RVA: 0x7FFE8A2662D0
    public void System.Collections.Generic.ICollection<BestHTTP.JSON.Json.Token>.Remove(){} // RVA: 0x7FFE8A266310
    public void System.Collections.IList.RemoveAt(){} // RVA: 0x7FFE8A266350
    public void System.Collections.Generic.IList<System.Object>.RemoveAt(){} // RVA: 0x7FFE8A266390
    public void System.Collections.Generic.IList<BestHTTP.JSON.Json.Token>.RemoveAt(){} // RVA: 0x7FFE8A2663D0
    public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFE8A266410
    public void System.Collections.Generic.ICollection<System.Object>.CopyTo(){} // RVA: 0x7FFE8A266630
    public void CopyTo(){} // RVA: 0x7FFE8A2668F0
    public void Equals(){} // RVA: 0x7FFE8A266E00 | overloaded x2
    public void CompareTo(){} // RVA: 0x7FFE8A266E60
    public void GetHashCode(){} // RVA: 0x7FFE8A267100
    public void .cctor(){} // RVA: 0x7FFE8A2672D0
}

public class JObject : Object
{
    public int MIN_SORT_SIZE;
    public JObject Empty;
    public string[] m_Keys; // 0x10
    public Token[] m_Values; // 0x18
    public ReadOnlyKeyCollection m_KeysCollection; // 0x20
    public ObjectValueCollection m_ValuesCollection; // 0x28
    public ObjectValueCollection objectValueCollection; // 0x30
    public object field_7; // 0x967
    public object field_8; // 0x968
    public object field_9; // 0x969
    public object field_10; // 0x96A
    public object field_11; // 0x96B
    public object field_12; // 0x96C
    public object field_13; // 0x96D
    public object field_14; // 0x96E
    public object field_15; // 0x96F
    public object field_16; // 0x970
    public object field_17; // 0x971
    public object field_18; // 0x972
    public object field_19; // 0x973
    public object field_20; // 0x974
    public object field_21; // 0x975
    public object field_22; // 0x976
    public object field_23; // 0x977

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8A267900
    public void get_Count(){} // RVA: 0x7FFE81CCB610
    public void get_IsReadOnly(){} // RVA: 0x7FFE811E0850
    public void get_IsFixedSize(){} // RVA: 0x7FFE811E0850
    public void get_IsSynchronized(){} // RVA: 0x7FFE810FB320
    public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFE8A267B70
    public void get_KeysCollection(){} // RVA: 0x7FFE8A267BD0
    public void get_Keys(){} // RVA: 0x7FFE81116380
    public void System.Collections.Generic.IReadOnlyDictionary<System.String,BestHTTP.JSON.Json.Token>.get_Keys(){} // RVA: 0x7FFE81116380
    public void System.Collections.Generic.IReadOnlyDictionary<System.String,System.Object>.get_Keys(){} // RVA: 0x7FFE81116380
    public void System.Collections.Generic.IDictionary<System.String,BestHTTP.JSON.Json.Token>.get_Keys(){} // RVA: 0x7FFE8A267D40
    public void System.Collections.Generic.IDictionary<System.String,System.Object>.get_Keys(){} // RVA: 0x7FFE8A267D40
    public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7FFE8A267D40
    public void get_ValuesCollection(){} // RVA: 0x7FFE8A267D50
    public void get_Values(){} // RVA: 0x7FFE8A267EC0
    public void System.Collections.Generic.IReadOnlyDictionary<System.String,BestHTTP.JSON.Json.Token>.get_Values(){} // RVA: 0x7FFE8A267EC0
    public void System.Collections.Generic.IReadOnlyDictionary<System.String,System.Object>.get_Values(){} // RVA: 0x7FFE8A267EC0
    public void System.Collections.Generic.IDictionary<System.String,BestHTTP.JSON.Json.Token>.get_Values(){} // RVA: 0x7FFE8A267EC0
    public void System.Collections.Generic.IDictionary<System.String,System.Object>.get_Values(){} // RVA: 0x7FFE8A267EC0
    public void GetEnumeratorImpl(){} // RVA: 0x7FFE8A267ED0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE8A268080
    public void GetEnumerator(){} // RVA: 0x7FFE8A268080
    public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.GetEnumerator(){} // RVA: 0x7FFE8A268080
    public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7FFE8A268080
    public void ToLegacyDict(){} // RVA: 0x7FFE8A268090
    public void IndexOf(){} // RVA: 0x7FFE8A268390
    public void System.Collections.Generic.IDictionary<System.String,BestHTTP.JSON.Json.Token>.Add(){} // RVA: 0x7FFE8A2684B0
    public void System.Collections.Generic.IDictionary<System.String,System.Object>.Add(){} // RVA: 0x7FFE8A2684F0
    public void System.Collections.IDictionary.Add(){} // RVA: 0x7FFE8A268530
    public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,BestHTTP.JSON.Json.Token>>.Add(){} // RVA: 0x7FFE8A268570
    public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Add(){} // RVA: 0x7FFE8A2685B0
    public void System.Collections.Generic.IDictionary<System.String,BestHTTP.JSON.Json.Token>.Remove(){} // RVA: 0x7FFE8A2685F0
    public void System.Collections.Generic.IDictionary<System.String,System.Object>.Remove(){} // RVA: 0x7FFE8A268630
    public void System.Collections.IDictionary.Remove(){} // RVA: 0x7FFE8A268670
    public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,BestHTTP.JSON.Json.Token>>.Remove(){} // RVA: 0x7FFE8A2686B0
    public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Remove(){} // RVA: 0x7FFE8A2686F0
    public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,BestHTTP.JSON.Json.Token>>.Clear(){} // RVA: 0x7FFE8A268730
    public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Clear(){} // RVA: 0x7FFE8A268770
    public void System.Collections.IDictionary.Clear(){} // RVA: 0x7FFE8A2687B0
    public void ContainsKey(){} // RVA: 0x7FFE8A2687F0
    public void System.Collections.IDictionary.Contains(){} // RVA: 0x7FFE8A268810
    public void Contains(){} // RVA: 0x7FFE8A268880
    public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Contains(){} // RVA: 0x7FFE8A268990
    public void CopyTo(){} // RVA: 0x7FFE8A268E40 | overloaded x2
    public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFE8A268FF0
    public void TryGetValue(){} // RVA: 0x7FFE8A269220 | overloaded x2
    public void ObjectToKey(){} // RVA: 0x7FFE8A269370
    public void get_Item(){} // RVA: 0x7FFE8A269590
    public void System.Collections.Generic.IReadOnlyDictionary<System.String,System.Object>.get_Item(){} // RVA: 0x7FFE8A269610
    public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7FFE8A2696F0
    public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7FFE8A2697F0
    public void System.Collections.Generic.IDictionary<System.String,BestHTTP.JSON.Json.Token>.get_Item(){} // RVA: 0x7FFE8A269830
    public void System.Collections.Generic.IDictionary<System.String,BestHTTP.JSON.Json.Token>.set_Item(){} // RVA: 0x7FFE8A2698C0
    public void System.Collections.Generic.IDictionary<System.String,System.Object>.get_Item(){} // RVA: 0x7FFE8A269900
    public void System.Collections.Generic.IDictionary<System.String,System.Object>.set_Item(){} // RVA: 0x7FFE8A2699E0
    public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7FFE8A269A20
    public void CompareTo(){} // RVA: 0x7FFE8A269B90
    public void Equals(){} // RVA: 0x7FFE8A269DB0 | overloaded x2
    public void GetHashCode(){} // RVA: 0x7FFE8A269F80
    public void .cctor(){} // RVA: 0x7FFE8A26A090
}

public class JObjectDynamicProxy : DynamicProxy`1
{
    // ── Methods ──
    public void TryGetMember(){} // RVA: 0x7FFE86B75420
    public void TrySetMember(){} // RVA: 0x7FFE86B75550
    public void GetDynamicMemberNames(){} // RVA: 0x7FFE86B75650
    public void .ctor(){} // RVA: 0x7FFE86B75800
}

public class JPropertyList : Object
{
    public Newtonsoft.Json.Linq.JToken _token; // 0x10
    public object field_1; // 0x1FE
    public object field_2; // 0x1FF

    // ── Methods ──
    public void GetEnumerator(){} // RVA: 0x7FFE86B78AF0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE86B78AF0
    public void Add(){} // RVA: 0x7FFE810FCE30
    public void Clear(){} // RVA: 0x7FFE86200400
    public void Contains(){} // RVA: 0x7FFE86B78B90
    public void CopyTo(){} // RVA: 0x7FFE86B78BA0
    public void Remove(){} // RVA: 0x7FFE86B78C10
    public void get_Count(){} // RVA: 0x7FFE86B78C80
    public void get_IsReadOnly(){} // RVA: 0x7FFE810FB320
    public void IndexOf(){} // RVA: 0x7FFE86B78C90
    public void Insert(){} // RVA: 0x7FFE86B78CA0
    public void RemoveAt(){} // RVA: 0x7FFE86B78D00
    public void get_Item(){} // RVA: 0x7FFE86B78D60
    public void set_Item(){} // RVA: 0x7FFE86B78DC0
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class JValueDynamicProxy : DynamicProxy`1
{
    // ── Methods ──
    public void TryConvert(){} // RVA: 0x7FFE86B946C0
    public void TryBinaryOperation(){} // RVA: 0x7FFE86B94910
    public void .ctor(){} // RVA: 0x7FFE86B94CD0
}

public class JobHandlePromise : Object
{
    // ── Methods ──
    public void Create(){} // RVA: 0x7FFE8787F7D0
    public void GetResult(){} // RVA: 0x7FFE8787F850
    public void GetStatus(){} // RVA: 0x7FFE8787F8A0
    public void UnsafeGetStatus(){} // RVA: 0x7FFE8787F8F0
    public void OnCompleted(){} // RVA: 0x7FFE8787F930
    public void MoveNext(){} // RVA: 0x7FFE8787F9B0
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class JobScheduleParameters : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE87BF7780
}

public class JobStruct`1 : ValueType
{
    // ── Methods ──
    public void Initialize(){} // RVA: 0x7FFE80E46010
    public void Execute(){} // RVA: 0x7FFE80E4EE20
    public void .cctor(){} // RVA: 0x7FFE80E46010
}

public class Join : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class JointData : ValueType
{
}

public class JsonPropertyInfoList : ConfigurationList`1
{
    public System.Text.Json.Serialization.Metadata.JsonTypeInfo _jsonTypeInfo; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8741A910
    public void get_IsReadOnly(){} // RVA: 0x7FFE8741AA70
    public void OnCollectionModifying(){} // RVA: 0x7FFE8741AAB0
    public void ValidateAddedValue(){} // RVA: 0x7FFE8741AB20
    public void SortProperties(){} // RVA: 0x7FFE8741ABB0
    public void AddPropertyWithConflictResolution(){} // RVA: 0x7FFE8741AD20
}

public class JsonString : ValueType
{
    // ── Methods ──
    public void ToString(){} // RVA: 0x7FFE8790F9F0
    public void Equals(){} // RVA: 0x7FFE8790FD40 | overloaded x2
    public void GetHashCode(){} // RVA: 0x7FFE8790FDE0
    public void op_Equality(){} // RVA: 0x7FFE8790FE50
    public void op_Inequality(){} // RVA: 0x7FFE8790FE80
    public void op_Implicit(){} // RVA: 0x7FFE8790FEB0
}

public class JsonValue : ValueType
{
    // ── Methods ──
    public void ToBoolean(){} // RVA: 0x7FFE8790FFB0
    public void ToInteger(){} // RVA: 0x7FFE879100A0
    public void ToDouble(){} // RVA: 0x7FFE87910140
    public void ToString(){} // RVA: 0x7FFE879101F0
    public void op_Implicit(){} // RVA: 0x7FFE87910A70 | overloaded x8
    public void Equals(){} // RVA: 0x7FFE87911890 | overloaded x3
    public void GetHashCode(){} // RVA: 0x7FFE87911950
    public void op_Equality(){} // RVA: 0x7FFE87911AD0
    public void op_Inequality(){} // RVA: 0x7FFE87911B20
}
