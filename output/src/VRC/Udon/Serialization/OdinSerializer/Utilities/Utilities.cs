// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer.Utilities
// Classes: 31
// Methods: 326

namespace VRC.Udon.Serialization.OdinSerializer.Utilities
{
    public class Cache`1 : Object
    {
        public System.Threading.SpinLock MaxCacheSize;
        public bool IsFree; // 0x4
        public object[] VRC.Udon.Serialization.OdinSerializer.Utilities.ICache.Value; // 0x8
        public bool isFree; // 0x10
        public int maxCacheSize; // 0x10
        public VRC.Udon.Serialization.OdinSerializer.SerializationContext Value; // 0x18

        // ── Methods ──
        public void get_MaxCacheSize(){} // RVA: 0x7FFD4E079990
        public void set_MaxCacheSize(){} // RVA: 0x7FFD4E091DD0
        public void .ctor(){} // RVA: 0x7FFD4E090980
        public void get_IsFree(){} // RVA: 0x7FFD4E079D00
        public void VRC.Udon.Serialization.OdinSerializer.Utilities.ICache.get_Value(){} // RVA: 0x7FFD4E078E90
        public void Claim(){} // RVA: 0x7FFD4E078A90
        public void Release(){} // RVA: 0x7FFD4E090980 | overloaded x2
        public void Purge(){} // RVA: 0x7FFD4E0909B0
        public void op_Implicit(){} // RVA: 0x7FFD4E2ADC40
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFD4E090980
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

    public class DoubleLookupDictionary`3 : Dictionary`2
    {
        public System.Collections.Generic.IEqualityComparer`1<V> Item;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E099B30 | overloaded x2
        public void get_Item(){} // RVA: 0x7FFD4E2ADC40
        public void InnerCount(){} // RVA: 0x7FFD4E2ADC40
        public void TotalInnerCount(){} // RVA: 0x7FFD4E079960
        public void ContainsKeys(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetInnerValue(){} // RVA: 0x7FFD4E2ADC40
        public void AddInner(){} // RVA: 0x7FFD4E2ADC40
        public void RemoveInner(){} // RVA: 0x7FFD4E2ADC40
        public void RemoveWhere(){} // RVA: 0x7FFD4E090A40
    }

    public class EmitUtilities : Object
    {
        public System.Reflection.Assembly CanEmit;

        // ── Methods ──
        public void get_CanEmit(){} // RVA: 0x7FFD4E341320
        public void EmitIsIllegalForMember(){} // RVA: 0x7FFD55458A20
        public void CreateStaticFieldGetter(){} // RVA: 0x7FFD4E078F80
        public void CreateWeakStaticFieldGetter(){} // RVA: 0x7FFD55458B50
        public void CreateStaticFieldSetter(){} // RVA: 0x7FFD4E078F80
        public void CreateWeakStaticFieldSetter(){} // RVA: 0x7FFD55458D70
        public void CreateInstanceFieldGetter(){} // RVA: 0x7FFD4E078F80
        public void CreateWeakInstanceFieldGetter(){} // RVA: 0x7FFD55458F90 | overloaded x2
        public void CreateInstanceFieldSetter(){} // RVA: 0x7FFD4E078F80
        public void CreateWeakInstanceFieldSetter(){} // RVA: 0x7FFD554591E0 | overloaded x2
        public void CreateWeakInstancePropertyGetter(){} // RVA: 0x7FFD55459430
        public void CreateWeakInstancePropertySetter(){} // RVA: 0x7FFD554597B0
        public void CreateStaticPropertySetter(){} // RVA: 0x7FFD4E078F80
        public void CreateStaticPropertyGetter(){} // RVA: 0x7FFD4E078F80
        public void CreateInstancePropertySetter(){} // RVA: 0x7FFD4E078F80
        public void CreateInstancePropertyGetter(){} // RVA: 0x7FFD4E078F80
        public void CreateMethodReturner(){} // RVA: 0x7FFD4E078F80
        public void CreateStaticMethodCaller(){} // RVA: 0x7FFD55459AE0
        public void CreateWeakInstanceMethodCaller(){} // RVA: 0x7FFD4E078F80 | overloaded x3
        public void CreateWeakInstanceMethodCallerFunc(){} // RVA: 0x7FFD4E078F80 | overloaded x2
        public void CreateInstanceMethodCaller(){} // RVA: 0x7FFD4E078F80 | overloaded x2
        public void CreateInstanceRefMethodCaller(){} // RVA: 0x7FFD4E078F80 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFD55459FA0
    }

    public class FastTypeComparer : Object
    {
        public VRC.Udon.Serialization.OdinSerializer.Utilities.FastTypeComparer Instance;

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD5545A270
        public void GetHashCode(){} // RVA: 0x7FFD4E5C13D0
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void .cctor(){} // RVA: 0x7FFD5545A2E0
    }

    public class FieldInfoExtensions : Object
    {
        // ── Methods ──
        public void IsAliasField(){} // RVA: 0x7FFD55448D80
        public void DeAliasField(){} // RVA: 0x7FFD55448DD0
    }

    public class Flags : Object
    {
        public 0x66438780 AnyVisibility;
        public 0x66438780 InstancePublic;
        public 0x66438780 InstancePrivate;
        public 0x66438780 InstanceAnyVisibility;
        public 0x66438780 StaticPublic;
        public 0x66438780 StaticPrivate;
        public 0x66438780 StaticAnyVisibility;
        public 0x66438780 InstancePublicDeclaredOnly;
        public 0x66438780 InstancePrivateDeclaredOnly;
        public 0x66438780 InstanceAnyDeclaredOnly;
        public 0x66438780 StaticPublicDeclaredOnly;
        public 0x66438780 StaticPrivateDeclaredOnly;
        public 0x66438780 StaticAnyDeclaredOnly;
        public 0x66438780 StaticInstanceAnyVisibility;
        public 0x66438780 AllMembers;
    }

    public class GarbageFreeIterators : Object
    {
        // ── Methods ──
        public void GFIterator(){} // RVA: 0x7FFD4E2ADC40 | overloaded x3
        public void GFValueIterator(){} // RVA: 0x7FFD4E2ADC40
    }

    public class ICache
    {
        public object Value;

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFD4E078E90
    }

    public class ICacheNotificationReceiver
    {
        // ── Methods ──
        public void OnFreed(){} // RVA: 0x7FFD4E090980
        public void OnClaimed(){} // RVA: 0x7FFD4E090980
    }

    public class IImmutableList
    {
    }

    public class IImmutableList`1
    {
        public object Item;

        // ── Methods ──
        public void get_Item(){} // RVA: 0x7FFD4E2ADC40
    }

    public class ImmutableList : Object
    {
        public System.Collections.IList Count; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5545A380
        public void get_Count(){} // RVA: 0x7FFD5545A430
        public void get_IsFixedSize(){} // RVA: 0x7FFD4E426850
        public void get_IsReadOnly(){} // RVA: 0x7FFD4E426850
        public void get_IsSynchronized(){} // RVA: 0x7FFD5545A480
        public void get_SyncRoot(){} // RVA: 0x7FFD5545A4D0
        public void System.Collections.IList.get_Item(){} // RVA: 0x7FFD5545A520
        public void System.Collections.IList.set_Item(){} // RVA: 0x7FFD5545A580
        public void System.Collections.Generic.IList<System.Object>.get_Item(){} // RVA: 0x7FFD5545A5D0
        public void System.Collections.Generic.IList<System.Object>.set_Item(){} // RVA: 0x7FFD5545A630
        public void get_Item(){} // RVA: 0x7FFD5545A680
        public void Contains(){} // RVA: 0x7FFD5545A6E0
        public void CopyTo(){} // RVA: 0x7FFD5545A7B0 | overloaded x2
        public void GetEnumerator(){} // RVA: 0x7FFD5545A820
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD5545A820
        public void System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator(){} // RVA: 0x7FFD5545A870
        public void System.Collections.IList.Add(){} // RVA: 0x7FFD5545A910
        public void System.Collections.IList.Clear(){} // RVA: 0x7FFD5545A960
        public void System.Collections.IList.Insert(){} // RVA: 0x7FFD5545A9B0
        public void System.Collections.IList.Remove(){} // RVA: 0x7FFD5545AA00
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x7FFD5545AA50
        public void IndexOf(){} // RVA: 0x7FFD5545AAA0
        public void System.Collections.Generic.IList<System.Object>.RemoveAt(){} // RVA: 0x7FFD5545AB00
        public void System.Collections.Generic.IList<System.Object>.Insert(){} // RVA: 0x7FFD5545AB50
        public void System.Collections.Generic.ICollection<System.Object>.Add(){} // RVA: 0x7FFD5545ABA0
        public void System.Collections.Generic.ICollection<System.Object>.Clear(){} // RVA: 0x7FFD5545ABF0
        public void System.Collections.Generic.ICollection<System.Object>.Remove(){} // RVA: 0x7FFD5545AC40
    }

    public class ImmutableList`1 : Object
    {
        public System.Collections.Generic.IList`1<T> Count;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090A40
        public void get_Count(){} // RVA: 0x7FFD4E079960
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFD4E079D00
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7FFD4E079D00
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7FFD4E079D00
        public void get_IsReadOnly(){} // RVA: 0x7FFD4E079D00
        public void System.Collections.IList.get_Item(){} // RVA: 0x7FFD4E087DE0
        public void System.Collections.IList.set_Item(){} // RVA: 0x7FFD4E092BC0
        public void System.Collections.Generic.IList<T>.get_Item(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.IList<T>.set_Item(){} // RVA: 0x7FFD4E2ADC40
        public void get_Item(){} // RVA: 0x7FFD4E2ADC40
        public void Contains(){} // RVA: 0x7FFD4E2ADC40
        public void CopyTo(){} // RVA: 0x7FFD4E097970
        public void GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFD4E097970
        public void System.Collections.Generic.ICollection<T>.Add(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.ICollection<T>.Clear(){} // RVA: 0x7FFD4E090980
        public void System.Collections.Generic.ICollection<T>.Remove(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IList.Add(){} // RVA: 0x7FFD4E07E6B0
        public void System.Collections.IList.Clear(){} // RVA: 0x7FFD4E090980
        public void System.Collections.IList.Contains(){} // RVA: 0x7FFD4E079F60
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7FFD4E07E6B0
        public void System.Collections.IList.Insert(){} // RVA: 0x7FFD4E092BC0
        public void System.Collections.IList.Remove(){} // RVA: 0x7FFD4E090A40
        public void System.Collections.Generic.IList<T>.Insert(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x7FFD4E090ED0
        public void IndexOf(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.IList<T>.RemoveAt(){} // RVA: 0x7FFD4E090ED0
    }

    public class ImmutableList`2 : Object
    {
        public U Count;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void get_Count(){} // RVA: 0x7FFD4E079960
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFD4E079D00
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7FFD4E079D00
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7FFD4E079D00
        public void get_IsReadOnly(){} // RVA: 0x7FFD4E079D00
        public void System.Collections.IList.get_Item(){} // RVA: 0x7FFD4E087DE0
        public void System.Collections.IList.set_Item(){} // RVA: 0x7FFD4E092BC0
        public void System.Collections.Generic.IList<TElement>.get_Item(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.IList<TElement>.set_Item(){} // RVA: 0x7FFD4E2ADC40
        public void get_Item(){} // RVA: 0x7FFD4E2ADC40
        public void Contains(){} // RVA: 0x7FFD4E2ADC40
        public void CopyTo(){} // RVA: 0x7FFD4E097970
        public void GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFD4E097970
        public void System.Collections.Generic.ICollection<TElement>.Add(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.ICollection<TElement>.Clear(){} // RVA: 0x7FFD4E090980
        public void System.Collections.Generic.ICollection<TElement>.Remove(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IList.Add(){} // RVA: 0x7FFD4E07E6B0
        public void System.Collections.IList.Clear(){} // RVA: 0x7FFD4E090980
        public void System.Collections.IList.Contains(){} // RVA: 0x7FFD4E079F60
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7FFD4E07E6B0
        public void System.Collections.IList.Insert(){} // RVA: 0x7FFD4E092BC0
        public void System.Collections.IList.Remove(){} // RVA: 0x7FFD4E090A40
        public void System.Collections.Generic.IList<TElement>.Insert(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x7FFD4E090ED0
        public void IndexOf(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.IList<TElement>.RemoveAt(){} // RVA: 0x7FFD4E090ED0
    }

    public class LinqExtensions : Object
    {
        // ── Methods ──
        public void ForEach(){} // RVA: 0x7FFD4E078FF0 | overloaded x2
        public void Append(){} // RVA: 0x7FFD4E078FF0
    }

    public class MemberAliasFieldInfo : FieldInfo
    {
        public string AliasedField;
        public System.Reflection.FieldInfo Module; // 0x10
        public string MetadataToken; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5545B1E0 | overloaded x2
        public void get_AliasedField(){} // RVA: 0x7FFD4E35C380
        public void get_Module(){} // RVA: 0x7FFD4F846B30
        public void get_MetadataToken(){} // RVA: 0x7FFD538CA3A0
        public void get_Name(){} // RVA: 0x7FFD4E3447C0
        public void get_DeclaringType(){} // RVA: 0x7FFD538CA500
        public void get_ReflectedType(){} // RVA: 0x7FFD538CA530
        public void get_FieldType(){} // RVA: 0x7FFD538CA5F0
        public void get_FieldHandle(){} // RVA: 0x7FFD538CA740
        public void get_Attributes(){} // RVA: 0x7FFD538CA770
        public void GetCustomAttributes(){} // RVA: 0x7FFD538CA590 | overloaded x2
        public void IsDefined(){} // RVA: 0x7FFD538CA5C0
        public void GetValue(){} // RVA: 0x7FFD530AD060
        public void SetValue(){} // RVA: 0x7FFD538CA680
    }

    public class MemberAliasMethodInfo : MethodInfo
    {
        public string AliasedMethod;
        public System.Reflection.MethodInfo ReturnTypeCustomAttributes; // 0x10
        public string MethodHandle; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5545B1E0 | overloaded x2
        public void get_AliasedMethod(){} // RVA: 0x7FFD4E35C380
        public void get_ReturnTypeCustomAttributes(){} // RVA: 0x7FFD5545B440
        public void get_MethodHandle(){} // RVA: 0x7FFD5432AD70
        public void get_Attributes(){} // RVA: 0x7FFD538CA5F0
        public void get_ReturnType(){} // RVA: 0x7FFD4FDCD6D0
        public void get_DeclaringType(){} // RVA: 0x7FFD538CA500
        public void get_Name(){} // RVA: 0x7FFD4E3447C0
        public void get_ReflectedType(){} // RVA: 0x7FFD538CA530
        public void GetBaseDefinition(){} // RVA: 0x7FFD5545B470
        public void GetCustomAttributes(){} // RVA: 0x7FFD538CA590 | overloaded x2
        public void GetMethodImplementationFlags(){} // RVA: 0x7FFD5545B4A0
        public void GetParameters(){} // RVA: 0x7FFD538CA770
        public void Invoke(){} // RVA: 0x7FFD5545B4D0
        public void IsDefined(){} // RVA: 0x7FFD538CA5C0
    }

    public class MemberAliasPropertyInfo : PropertyInfo
    {
        public string AliasedProperty;
        public System.Reflection.PropertyInfo Module; // 0x10
        public string MetadataToken; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5545B1E0 | overloaded x2
        public void get_AliasedProperty(){} // RVA: 0x7FFD4E35C380
        public void get_Module(){} // RVA: 0x7FFD4F846B30
        public void get_MetadataToken(){} // RVA: 0x7FFD538CA3A0
        public void get_Name(){} // RVA: 0x7FFD4E3447C0
        public void get_DeclaringType(){} // RVA: 0x7FFD538CA500
        public void get_ReflectedType(){} // RVA: 0x7FFD538CA530
        public void get_PropertyType(){} // RVA: 0x7FFD538CA770
        public void get_Attributes(){} // RVA: 0x7FFD5545B640
        public void get_CanRead(){} // RVA: 0x7FFD5545B4A0
        public void get_CanWrite(){} // RVA: 0x7FFD53FAD5F0
        public void GetCustomAttributes(){} // RVA: 0x7FFD538CA590 | overloaded x2
        public void IsDefined(){} // RVA: 0x7FFD538CA5C0
        public void GetAccessors(){} // RVA: 0x7FFD5432ABF0
        public void GetGetMethod(){} // RVA: 0x7FFD5432AC80
        public void GetIndexParameters(){} // RVA: 0x7FFD538CA5F0
        public void GetSetMethod(){} // RVA: 0x7FFD530AD060
        public void GetValue(){} // RVA: 0x7FFD538CA680
        public void SetValue(){} // RVA: 0x7FFD5545B670
    }

    public class MemberInfoExtensions : Object
    {
        // ── Methods ──
        public void IsDefined(){} // RVA: 0x7FFD4E079DE0 | overloaded x2
        public void GetAttribute(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void GetAttributes(){} // RVA: 0x7FFD55449020 | overloaded x4
        public void GetNiceName(){} // RVA: 0x7FFD55449120
        public void IsStatic(){} // RVA: 0x7FFD55449350
        public void IsAlias(){} // RVA: 0x7FFD554497C0
        public void DeAlias(){} // RVA: 0x7FFD55449860
    }

    public class MethodInfoExtensions : Object
    {
        // ── Methods ──
        public void GetFullName(){} // RVA: 0x7FFD55449D80 | overloaded x2
        public void GetParamsNames(){} // RVA: 0x7FFD55449AE0
        public void IsExtensionMethod(){} // RVA: 0x7FFD55449EE0
        public void IsAliasMethod(){} // RVA: 0x7FFD5544A000
        public void DeAliasMethod(){} // RVA: 0x7FFD5544A050
    }

    public class PathUtilities : Object
    {
        // ── Methods ──
        public void HasSubDirectory(){} // RVA: 0x7FFD5544A190
    }

    public class PropertyInfoExtensions : Object
    {
        // ── Methods ──
        public void IsAutoProperty(){} // RVA: 0x7FFD5544A3A0
        public void IsAliasProperty(){} // RVA: 0x7FFD5544A5F0
        public void DeAliasProperty(){} // RVA: 0x7FFD5544A640
    }

    public class ReferenceEqualityComparer`1 : Object
    {
        public VRC.Udon.Serialization.OdinSerializer.Utilities.ReferenceEqualityComparer`1<T> Default;

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4E2ADC40
        public void GetHashCode(){} // RVA: 0x7FFD4E2ADC40
        public void .ctor(){} // RVA: 0x7FFD4E090980
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

    public class StringExtensions : Object
    {
        // ── Methods ──
        public void ToTitleCase(){} // RVA: 0x7FFD5544A7E0
        public void IsNullOrWhitespace(){} // RVA: 0x7FFD5544AA30
    }

    public class TypeExtensions : Object
    {
        public System.Func`3<float,float,bool> FloatEqualityComparerFunc;
        public System.Func`3<double,double,bool> DoubleEqualityComparerFunc; // 0x8
        public System.Func`3<UnityEngine.Quaternion,UnityEngine.Quaternion,bool> QuaternionEqualityComparerFunc; // 0x10
        public object GenericConstraintsSatisfaction_LOCK; // 0x18
        public System.Collections.Generic.Dictionary`2<System.Type,System.Type> GenericConstraintsSatisfactionInferredParameters; // 0x20
        public System.Collections.Generic.Dictionary`2<System.Type,System.Type> GenericConstraintsSatisfactionResolvedMap; // 0x28
        public System.Collections.Generic.HashSet`1<System.Type> GenericConstraintsSatisfactionProcessedParams; // 0x30
        public System.Collections.Generic.HashSet`1<System.Type> GenericConstraintsSatisfactionTypesToCheck; // 0x38
        public System.Collections.Generic.List`1<System.Type> GenericConstraintsSatisfactionTypesToCheck_ToAdd; // 0x40
        public System.Type GenericListInterface; // 0x48
        public System.Type GenericCollectionInterface; // 0x50
        public object WeaklyTypedTypeCastDelegates_LOCK; // 0x58
        public object StronglyTypedTypeCastDelegates_LOCK; // 0x60
        public VRC.Udon.Serialization.OdinSerializer.Utilities.DoubleLookupDictionary`3<System.Type,System.Type,System.Func`2<object,object>> WeaklyTypedTypeCastDelegates; // 0x68
        public VRC.Udon.Serialization.OdinSerializer.Utilities.DoubleLookupDictionary`3<System.Type,System.Type,System.Delegate> StronglyTypedTypeCastDelegates; // 0x70
        public System.Type[] TwoLengthTypeArray_Cached; // 0x78
        public System.Collections.Generic.Stack`1<System.Type> GenericArgumentsContainsTypes_ArgsToCheckCached; // 0x80
        public System.Collections.Generic.HashSet`1<string> ReservedCSharpKeywords; // 0x88
        public System.Collections.Generic.Dictionary`2<string,string> TypeNameAlternatives; // 0x90
        public object CachedNiceNames_LOCK; // 0x98
        public System.Collections.Generic.Dictionary`2<System.Type,string> CachedNiceNames; // 0xA0
        public System.Type VoidPointerType; // 0xA8
        public System.Collections.Generic.Dictionary`2<System.Type,System.Collections.Generic.HashSet`1<System.Type>> PrimitiveImplicitCasts; // 0xB0
        public System.Collections.Generic.HashSet`1<System.Type> ExplicitCastIntegrals; // 0xB8

        // ── Methods ──
        public void GetCachedNiceName(){} // RVA: 0x7FFD5544AAF0
        public void CreateNiceName(){} // RVA: 0x7FFD5544AD80
        public void HasCastDefined(){} // RVA: 0x7FFD5544B2D0
        public void IsValidIdentifier(){} // RVA: 0x7FFD5544B7C0
        public void IsValidIdentifierStartCharacter(){} // RVA: 0x7FFD5544BA50
        public void IsValidIdentifierPartCharacter(){} // RVA: 0x7FFD5544BAC0
        public void IsCastableTo(){} // RVA: 0x7FFD5544BB40
        public void GetCastMethodDelegate(){} // RVA: 0x7FFD4E088B60 | overloaded x2
        public void GetCastMethod(){} // RVA: 0x7FFD5544C0A0
        public void FloatEqualityComparer(){} // RVA: 0x7FFD5544C6E0
        public void DoubleEqualityComparer(){} // RVA: 0x7FFD5544C710
        public void QuaternionEqualityComparer(){} // RVA: 0x7FFD54399BA0
        public void GetEqualityComparerDelegate(){} // RVA: 0x7FFD4E078A90
        public void GetAttribute(){} // RVA: 0x7FFD4E2ADC40
        public void ImplementsOrInherits(){} // RVA: 0x7FFD541B86C0
        public void ImplementsOpenGenericType(){} // RVA: 0x7FFD5544C750
        public void ImplementsOpenGenericInterface(){} // RVA: 0x7FFD5544C7F0
        public void ImplementsOpenGenericClass(){} // RVA: 0x7FFD5544C940
        public void GetArgumentsOfInheritedOpenGenericType(){} // RVA: 0x7FFD5544CA60
        public void GetArgumentsOfInheritedOpenGenericClass(){} // RVA: 0x7FFD5544CB00
        public void GetArgumentsOfInheritedOpenGenericInterface(){} // RVA: 0x7FFD5544CC40
        public void GetOperatorMethod(){} // RVA: 0x7FFD5544D740 | overloaded x2
        public void GetOperatorMethods(){} // RVA: 0x7FFD5544DBB0
        public void GetAllMembers(){} // RVA: 0x7FFD4E088090 | overloaded x3
        public void GetGenericBaseType(){} // RVA: 0x7FFD5544E310 | overloaded x2
        public void GetBaseTypes(){} // RVA: 0x7FFD5544E7B0
        public void GetBaseClasses(){} // RVA: 0x7FFD5544E980
        public void TypeNameGauntlet(){} // RVA: 0x7FFD5544EA40
        public void GetNiceName(){} // RVA: 0x7FFD5544EB30
        public void GetNiceFullName(){} // RVA: 0x7FFD5544EC80
        public void GetCompilableNiceName(){} // RVA: 0x7FFD5544EE20
        public void GetCompilableNiceFullName(){} // RVA: 0x7FFD5544EEE0
        public void GetCustomAttribute(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void GetCustomAttributes(){} // RVA: 0x7FFD4E089730 | overloaded x2
        public void IsDefined(){} // RVA: 0x7FFD4E07BEA0 | overloaded x2
        public void InheritsFrom(){} // RVA: 0x7FFD5544EFA0 | overloaded x2
        public void GetInheritanceDistance(){} // RVA: 0x7FFD5544F170
        public void HasParamaters(){} // RVA: 0x7FFD5544F580
        public void GetReturnType(){} // RVA: 0x7FFD5544F760
        public void GetMemberValue(){} // RVA: 0x7FFD5544F930
        public void SetMemberValue(){} // RVA: 0x7FFD5544FB70
        public void TryInferGenericParameters(){} // RVA: 0x7FFD5544FEB0
        public void AreGenericConstraintsSatisfiedBy(){} // RVA: 0x7FFD554513F0 | overloaded x3
        public void GenericParameterIsFulfilledBy(){} // RVA: 0x7FFD55451900 | overloaded x2
        public void GetGenericConstraintsString(){} // RVA: 0x7FFD55452300
        public void GetGenericParameterConstraintsString(){} // RVA: 0x7FFD55452660
        public void GenericArgumentsContainsTypes(){} // RVA: 0x7FFD55452BA0
        public void IsFullyConstructedGenericType(){} // RVA: 0x7FFD55453120
        public void IsNullableType(){} // RVA: 0x7FFD55453340
        public void GetEnumBitmask(){} // RVA: 0x7FFD554533B0
        public void SafeGetTypes(){} // RVA: 0x7FFD55453520
        public void SafeIsDefined(){} // RVA: 0x7FFD55453580
        public void SafeGetCustomAttributes(){} // RVA: 0x7FFD554535B0
        public void .cctor(){} // RVA: 0x7FFD55453600
    }

    public class UnityExtensions : Object
    {
        public VRC.Udon.Serialization.OdinSerializer.Utilities.ValueGetter`2<UnityEngine.Object,UIntPtr> UnityObjectCachedPtrFieldGetter;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD55458720
        public void SafeIsUnityNull(){} // RVA: 0x7FFD554588E0
    }

    public class UnityVersion : Object
    {
        public int Major;
        public int Minor; // 0x4

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD5545B6B0
        public void EnsureLoaded(){} // RVA: 0x7FFD4E341310
        public void IsVersionOrGreater(){} // RVA: 0x7FFD5545BB50
    }

    public class ValueGetter`2 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFD4E2ADC40
        public void BeginInvoke(){} // RVA: 0x7FFD4E08AE80
        public void EndInvoke(){} // RVA: 0x7FFD4E2ADC40
    }

    public class ValueSetter`2 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFD4E2ADC40
        public void BeginInvoke(){} // RVA: 0x7FFD4E2ADC40
        public void EndInvoke(){} // RVA: 0x7FFD4E099B30
    }

    public class WeakValueGetter`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFD4E2ADC40
        public void BeginInvoke(){} // RVA: 0x7FFD4E08AE80
        public void EndInvoke(){} // RVA: 0x7FFD4E2ADC40
    }

    public class WeakValueSetter`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFD4E2ADC40
        public void BeginInvoke(){} // RVA: 0x7FFD4E2ADC40
        public void EndInvoke(){} // RVA: 0x7FFD4E099B30
    }

}