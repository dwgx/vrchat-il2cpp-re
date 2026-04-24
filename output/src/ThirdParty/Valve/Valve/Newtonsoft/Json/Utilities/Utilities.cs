// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.Newtonsoft.Json.Utilities
// Classes: 10
// Methods: 152

namespace ThirdParty.Valve.Valve.Newtonsoft.Json.Utilities
{
    public class BidirectionalDictionary`2 : Object
    {
        public System.Collections.Generic.IDictionary`2<U,T> _firstToSecond;
        public System.Collections.Generic.IDictionary`2<T,U> _secondToFirst;
        public string _duplicateFirstErrorMessage;
        public string _duplicateSecondErrorMessage;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E09B8C0 | overloaded x2
        public void Set(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetByFirst(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetBySecond(){} // RVA: 0x7FFD4E2ADC40
    }

    public class CollectionUtils : Object
    {
        // ── Methods ──
        public void IsNullOrEmpty(){} // RVA: 0x7FFD4E079DE0
        public void AddRange(){} // RVA: 0x7FFD4E090C80 | overloaded x2
        public void IsDictionaryType(){} // RVA: 0x7FFD550E3930
        public void ResolveEnumerableCollectionConstructor(){} // RVA: 0x7FFD550E3CC0 | overloaded x2
        public void IndexOf(){} // RVA: 0x7FFD4E07E730
        public void Contains(){} // RVA: 0x7FFD4E2ADC40
        public void IndexOfReference(){} // RVA: 0x7FFD4E2ADC40
        public void GetDimensions(){} // RVA: 0x7FFD550E3F60
        public void CopyFromJaggedToMultidimensionalArray(){} // RVA: 0x7FFD550E4350
        public void JaggedArrayGetValue(){} // RVA: 0x7FFD550E45F0
        public void ToMultidimensionalArray(){} // RVA: 0x7FFD550E46F0
    }

    public class CollectionWrapper`1 : Object
    {
        public System.Collections.IList Count;
        public System.Collections.Generic.ICollection`1<T> IsReadOnly;
        public object System.Collections.IList.IsFixedSize;

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFD4E2ADC40
        public void Clear(){} // RVA: 0x7FFD4E090980
        public void Contains(){} // RVA: 0x7FFD4E2ADC40
        public void CopyTo(){} // RVA: 0x7FFD4E097970
        public void get_Count(){} // RVA: 0x7FFD4E079960
        public void get_IsReadOnly(){} // RVA: 0x7FFD4E079D00
        public void Remove(){} // RVA: 0x7FFD4E2ADC40
        public void GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IList.Add(){} // RVA: 0x7FFD4E07E6B0
        public void System.Collections.IList.Contains(){} // RVA: 0x7FFD4E079F60
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7FFD4E07E6B0
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x7FFD4E090ED0
        public void System.Collections.IList.Insert(){} // RVA: 0x7FFD4E092BC0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7FFD4E079D00
        public void System.Collections.IList.Remove(){} // RVA: 0x7FFD4E090A40
        public void System.Collections.IList.get_Item(){} // RVA: 0x7FFD4E087DE0
        public void System.Collections.IList.set_Item(){} // RVA: 0x7FFD4E092BC0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFD4E097970
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFD4E079D00
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFD4E078E90
        public void VerifyValueType(){} // RVA: 0x7FFD4E090A10
        public void IsCompatibleObject(){} // RVA: 0x7FFD4E079DE0
        public void get_UnderlyingCollection(){} // RVA: 0x7FFD4E078E90
    }

    public class DictionaryWrapper`2 : Object
    {
        public System.Collections.IDictionary Keys;
        public System.Collections.Generic.IDictionary`2<U,T> Values;
        public object Item;

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void ContainsKey(){} // RVA: 0x7FFD4E2ADC40
        public void get_Keys(){} // RVA: 0x7FFD4E078E90
        public void Remove(){} // RVA: 0x7FFD4E090A40 | overloaded x3
        public void TryGetValue(){} // RVA: 0x7FFD4E2ADC40
        public void get_Values(){} // RVA: 0x7FFD4E078E90
        public void get_Item(){} // RVA: 0x7FFD4E2ADC40
        public void set_Item(){} // RVA: 0x7FFD4E2ADC40
        public void Clear(){} // RVA: 0x7FFD4E090980
        public void Contains(){} // RVA: 0x7FFD4E2ADC40
        public void CopyTo(){} // RVA: 0x7FFD4E097970
        public void get_Count(){} // RVA: 0x7FFD4E079960
        public void get_IsReadOnly(){} // RVA: 0x7FFD4E079D00
        public void GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7FFD4E099B30
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7FFD4E078F40
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7FFD4E099B30
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7FFD4E079F60
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7FFD4E079D00
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFD4E097970
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFD4E079D00
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFD4E078E90
        public void get_UnderlyingDictionary(){} // RVA: 0x7FFD4E078E90
    }

    public class LateBoundReflectionDelegateFactory : ReflectionDelegateFactory
    {
        public Valve.Newtonsoft.Json.Utilities.LateBoundReflectionDelegateFactory Instance;

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFD550F0660
        public void CreateParameterizedConstructor(){} // RVA: 0x7FFD550F06C0
        public void CreateMethodCall(){} // RVA: 0x7FFD4E078F40
        public void CreateDefaultConstructor(){} // RVA: 0x7FFD4E078F40
        public void CreateGet(){} // RVA: 0x7FFD4E078F40 | overloaded x2
        public void CreateSet(){} // RVA: 0x7FFD4E078F40 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void .cctor(){} // RVA: 0x7FFD550F08F0
    }

    public class MethodCall`2 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFD4E2ADC40
    }

    public class ReflectionDelegateFactory : Object
    {
        // ── Methods ──
        public void CreateGet(){} // RVA: 0x7FFD4E078F40 | overloaded x3
        public void CreateSet(){} // RVA: 0x7FFD4E078F40 | overloaded x3
        public void CreateMethodCall(){} // RVA: 0x7FFD4E078F40
        public void CreateParameterizedConstructor(){} // RVA: 0x7FFD4E078F40
        public void CreateDefaultConstructor(){} // RVA: 0x7FFD4E078F40
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class ReflectionUtils : Object
    {
        public System.Type[] EmptyTypes;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD550F2640
        public void IsVirtual(){} // RVA: 0x7FFD550F2710
        public void GetBaseDefinition(){} // RVA: 0x7FFD550F2820
        public void IsPublic(){} // RVA: 0x7FFD550F2900
        public void GetObjectType(){} // RVA: 0x7FFD53B90780
        public void GetTypeName(){} // RVA: 0x7FFD550F29E0
        public void RemoveAssemblyDetails(){} // RVA: 0x7FFD550F2BD0
        public void HasDefaultConstructor(){} // RVA: 0x7FFD550F2D20
        public void GetDefaultConstructor(){} // RVA: 0x7FFD550F2E80 | overloaded x2
        public void IsNullable(){} // RVA: 0x7FFD550F3020
        public void IsNullableType(){} // RVA: 0x7FFD550F3100
        public void EnsureNotNullableType(){} // RVA: 0x7FFD550F3210
        public void IsGenericDefinition(){} // RVA: 0x7FFD550F3280
        public void ImplementsGenericDefinition(){} // RVA: 0x7FFD550F3360 | overloaded x2
        public void InheritsGenericDefinition(){} // RVA: 0x7FFD550F3690 | overloaded x2
        public void InheritsGenericDefinitionInternal(){} // RVA: 0x7FFD550F38A0
        public void GetCollectionItemType(){} // RVA: 0x7FFD550F3A60
        public void GetDictionaryKeyValueTypes(){} // RVA: 0x7FFD550F3DA0
        public void GetMemberUnderlyingType(){} // RVA: 0x7FFD550F4230
        public void IsIndexedProperty(){} // RVA: 0x7FFD550F4630 | overloaded x2
        public void GetMemberValue(){} // RVA: 0x7FFD550F46E0
        public void SetMemberValue(){} // RVA: 0x7FFD550F4A40
        public void CanReadMemberValue(){} // RVA: 0x7FFD550F4CD0
        public void CanSetMemberValue(){} // RVA: 0x7FFD550F4E40
        public void GetFieldsAndProperties(){} // RVA: 0x7FFD550F5000
        public void IsOverridenGenericMember(){} // RVA: 0x7FFD550F5910
        public void GetAttribute(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void GetAttributes(){} // RVA: 0x7FFD550F5B00 | overloaded x2
        public void SplitFullyQualifiedTypeName(){} // RVA: 0x7FFD550F60B0
        public void GetAssemblyDelimiterIndex(){} // RVA: 0x7FFD550F63A0
        public void GetMemberInfoFromType(){} // RVA: 0x7FFD550F6460
        public void GetFields(){} // RVA: 0x7FFD550F6890
        public void GetChildPrivateFields(){} // RVA: 0x7FFD550F69E0
        public void GetProperties(){} // RVA: 0x7FFD550F6BF0
        public void RemoveFlag(){} // RVA: 0x7FFD53B94F00
        public void GetChildPrivateProperties(){} // RVA: 0x7FFD550F6F40
        public void GetDefaultValue(){} // RVA: 0x7FFD550F7230
    }

    public class StringUtils : Object
    {
        // ── Methods ──
        public void FormatWith(){} // RVA: 0x7FFD550F8780 | overloaded x5
        public void CreateStringWriter(){} // RVA: 0x7FFD550F88C0
        public void ToCharAsUnicode(){} // RVA: 0x7FFD53B97190
        public void ForgivingCaseSensitiveFind(){} // RVA: 0x7FFD4E2ADC40
        public void IsHighSurrogate(){} // RVA: 0x7FFD550F89D0
        public void IsLowSurrogate(){} // RVA: 0x7FFD550F8A40
        public void StartsWith(){} // RVA: 0x7FFD53B97A80
        public void EndsWith(){} // RVA: 0x7FFD53B97AB0
    }

    public class ThreadSafeStore`2 : Object
    {
        public object _lock;
        public System.Collections.Generic.Dictionary`2<U,T> _store;
        public System.Func`2<U,T> _creator;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090A40
        public void Get(){} // RVA: 0x7FFD4E2ADC40
        public void AddValue(){} // RVA: 0x7FFD4E2ADC40
    }

}