// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer.Utilities
// Classes: 33
// Methods: 334

namespace VRC.Udon.Serialization.OdinSerializer.Utilities
{
    public class Cache`1 : Object
    {
        public System.Threading.SpinLock FreeValuesLock;
        public bool IsNotificationReceiver;
        public object[] FreeValues;

        // ── Methods ──
        public void get_MaxCacheSize(){} // RVA: 0x7FFE80E2EDE0
        public void set_MaxCacheSize(){} // RVA: 0x7FFE80E47430
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
        public void get_IsFree(){} // RVA: 0x7FFE80E2F150
        public void VRC.Udon.Serialization.OdinSerializer.Utilities.ICache.get_Value(){} // RVA: 0x7FFE80E2E2E0
        public void Claim(){} // RVA: 0x7FFE80E2DEE0
        public void Release(){} // RVA: 0x7FFE80E45FE0 | overloaded x2
        public void Purge(){} // RVA: 0x7FFE80E46010
        public void op_Implicit(){} // RVA: 0x7FFE810A1420
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE80E45FE0
        public void .cctor(){} // RVA: 0x7FFE80E46010
    }

    public class DoubleLookupDictionary`3 : Dictionary`2
    {
        public System.Collections.Generic.IEqualityComparer`1<V> secondKeyComparer;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E4F230 | overloaded x2
        public void get_Item(){} // RVA: 0x7FFE810A1420
        public void InnerCount(){} // RVA: 0x7FFE810A1420
        public void TotalInnerCount(){} // RVA: 0x7FFE80E2EDB0
        public void ContainsKeys(){} // RVA: 0x7FFE810A1420
        public void TryGetInnerValue(){} // RVA: 0x7FFE810A1420
        public void AddInner(){} // RVA: 0x7FFE810A1420
        public void RemoveInner(){} // RVA: 0x7FFE810A1420
        public void RemoveWhere(){} // RVA: 0x7FFE80E460A0
    }

    public class EmitUtilities : Object
    {
        public System.Reflection.Assembly EngineAssembly;

        // ── Methods ──
        public void get_CanEmit(){} // RVA: 0x7FFE810FB320
        public void EmitIsIllegalForMember(){} // RVA: 0x7FFE883EB530
        public void CreateStaticFieldGetter(){} // RVA: 0x7FFE80E2E3D0
        public void CreateWeakStaticFieldGetter(){} // RVA: 0x7FFE883EB660
        public void CreateStaticFieldSetter(){} // RVA: 0x7FFE80E2E3D0
        public void CreateWeakStaticFieldSetter(){} // RVA: 0x7FFE883EB880
        public void CreateInstanceFieldGetter(){} // RVA: 0x7FFE80E2E3D0
        public void CreateWeakInstanceFieldGetter(){} // RVA: 0x7FFE883EBAA0 | overloaded x2
        public void CreateInstanceFieldSetter(){} // RVA: 0x7FFE80E2E3D0
        public void CreateWeakInstanceFieldSetter(){} // RVA: 0x7FFE883EBCF0 | overloaded x2
        public void CreateWeakInstancePropertyGetter(){} // RVA: 0x7FFE883EBF40
        public void CreateWeakInstancePropertySetter(){} // RVA: 0x7FFE883EC2C0
        public void CreateStaticPropertySetter(){} // RVA: 0x7FFE80E2E3D0
        public void CreateStaticPropertyGetter(){} // RVA: 0x7FFE80E2E3D0
        public void CreateInstancePropertySetter(){} // RVA: 0x7FFE80E2E3D0
        public void CreateInstancePropertyGetter(){} // RVA: 0x7FFE80E2E3D0
        public void CreateMethodReturner(){} // RVA: 0x7FFE80E2E3D0
        public void CreateStaticMethodCaller(){} // RVA: 0x7FFE883EC5F0
        public void CreateWeakInstanceMethodCaller(){} // RVA: 0x7FFE80E2E3D0 | overloaded x3
        public void CreateWeakInstanceMethodCallerFunc(){} // RVA: 0x7FFE80E2E3D0 | overloaded x2
        public void CreateInstanceMethodCaller(){} // RVA: 0x7FFE80E2E3D0 | overloaded x2
        public void CreateInstanceRefMethodCaller(){} // RVA: 0x7FFE80E2E3D0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE883ECAB0
    }

    public class FastTypeComparer : Object
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE883ECD80
        public void GetHashCode(){} // RVA: 0x7FFE81407EB0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE883ECDF0
    }

    public class FieldInfoExtensions : Object
    {
        // ── Methods ──
        public void IsAliasField(){} // RVA: 0x7FFE883DB890
        public void DeAliasField(){} // RVA: 0x7FFE883DB8E0
    }

    public class Flags : Object
    {
    }

    public class GarbageFreeIterators : Object
    {
        // ── Methods ──
        public void GFIterator(){} // RVA: 0x7FFE810A1420 | overloaded x3
        public void GFValueIterator(){} // RVA: 0x7FFE810A1420
    }

    public class ICache
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFE80E2E2E0
    }

    public class ICacheNotificationReceiver
    {
        // ── Methods ──
        public void OnFreed(){} // RVA: 0x7FFE80E45FE0
        public void OnClaimed(){} // RVA: 0x7FFE80E45FE0
    }

    public class IImmutableList
    {
    }

    public class IImmutableList`1
    {
        // ── Methods ──
        public void get_Item(){} // RVA: 0x7FFE810A1420
    }

    public class ImmutableList : Object
    {
        public System.Collections.IList innerList; // 0x10
        public object field_1; // 0x7E
        public object field_2; // 0x7F
        public object field_3; // 0x80
        public object field_4; // 0x81
        public object field_5; // 0x82
        public object field_6; // 0x83
        public object field_7; // 0x84

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE883ECE90
        public void get_Count(){} // RVA: 0x7FFE883ECF40
        public void get_IsFixedSize(){} // RVA: 0x7FFE811E0850
        public void get_IsReadOnly(){} // RVA: 0x7FFE811E0850
        public void get_IsSynchronized(){} // RVA: 0x7FFE883ECF90
        public void get_SyncRoot(){} // RVA: 0x7FFE883ECFE0
        public void System.Collections.IList.get_Item(){} // RVA: 0x7FFE883ED030
        public void System.Collections.IList.set_Item(){} // RVA: 0x7FFE883ED090
        public void System.Collections.Generic.IList<System.Object>.get_Item(){} // RVA: 0x7FFE883ED0E0
        public void System.Collections.Generic.IList<System.Object>.set_Item(){} // RVA: 0x7FFE883ED140
        public void get_Item(){} // RVA: 0x7FFE883ED190
        public void Contains(){} // RVA: 0x7FFE883ED1F0
        public void CopyTo(){} // RVA: 0x7FFE883ED2C0 | overloaded x2
        public void GetEnumerator(){} // RVA: 0x7FFE883ED330
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE883ED330
        public void System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator(){} // RVA: 0x7FFE883ED380
        public void System.Collections.IList.Add(){} // RVA: 0x7FFE883ED420
        public void System.Collections.IList.Clear(){} // RVA: 0x7FFE883ED470
        public void System.Collections.IList.Insert(){} // RVA: 0x7FFE883ED4C0
        public void System.Collections.IList.Remove(){} // RVA: 0x7FFE883ED510
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x7FFE883ED560
        public void IndexOf(){} // RVA: 0x7FFE883ED5B0
        public void System.Collections.Generic.IList<System.Object>.RemoveAt(){} // RVA: 0x7FFE883ED610
        public void System.Collections.Generic.IList<System.Object>.Insert(){} // RVA: 0x7FFE883ED660
        public void System.Collections.Generic.ICollection<System.Object>.Add(){} // RVA: 0x7FFE883ED6B0
        public void System.Collections.Generic.ICollection<System.Object>.Clear(){} // RVA: 0x7FFE883ED700
        public void System.Collections.Generic.ICollection<System.Object>.Remove(){} // RVA: 0x7FFE883ED750
    }

    public class ImmutableList`1 : Object
    {
        public System.Collections.Generic.IList`1<T> innerList;
        public object field_1; // 0x88
        public object field_2; // 0x89
        public object field_3; // 0x8A
        public object field_4; // 0x8B
        public object field_5; // 0x8C
        public object field_6; // 0x8D
        public object field_7; // 0x8E
        public object field_8; // 0x8F

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E460A0
        public void get_Count(){} // RVA: 0x7FFE80E2EDB0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFE80E2F150
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7FFE80E2F150
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7FFE80E2F150
        public void get_IsReadOnly(){} // RVA: 0x7FFE80E2F150
        public void System.Collections.IList.get_Item(){} // RVA: 0x7FFE80E3D230
        public void System.Collections.IList.set_Item(){} // RVA: 0x7FFE80E48220
        public void System.Collections.Generic.IList<T>.get_Item(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.IList<T>.set_Item(){} // RVA: 0x7FFE810A1420
        public void get_Item(){} // RVA: 0x7FFE810A1420
        public void Contains(){} // RVA: 0x7FFE810A1420
        public void CopyTo(){} // RVA: 0x7FFE80E4D070
        public void GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFE80E4D070
        public void System.Collections.Generic.ICollection<T>.Add(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.ICollection<T>.Clear(){} // RVA: 0x7FFE80E45FE0
        public void System.Collections.Generic.ICollection<T>.Remove(){} // RVA: 0x7FFE810A1420
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IList.Add(){} // RVA: 0x7FFE80E33B00
        public void System.Collections.IList.Clear(){} // RVA: 0x7FFE80E45FE0
        public void System.Collections.IList.Contains(){} // RVA: 0x7FFE80E2F3B0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7FFE80E33B00
        public void System.Collections.IList.Insert(){} // RVA: 0x7FFE80E48220
        public void System.Collections.IList.Remove(){} // RVA: 0x7FFE80E460A0
        public void System.Collections.Generic.IList<T>.Insert(){} // RVA: 0x7FFE810A1420
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x7FFE80E46530
        public void IndexOf(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.IList<T>.RemoveAt(){} // RVA: 0x7FFE80E46530
    }

    public class ImmutableList`2 : Object
    {
        public U innerList;
        public object field_1; // 0x91
        public object field_2; // 0x92
        public object field_3; // 0x93
        public object field_4; // 0x94
        public object field_5; // 0x95
        public object field_6; // 0x96
        public object field_7; // 0x97
        public object field_8; // 0x98

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void get_Count(){} // RVA: 0x7FFE80E2EDB0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFE80E2F150
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7FFE80E2F150
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7FFE80E2F150
        public void get_IsReadOnly(){} // RVA: 0x7FFE80E2F150
        public void System.Collections.IList.get_Item(){} // RVA: 0x7FFE80E3D230
        public void System.Collections.IList.set_Item(){} // RVA: 0x7FFE80E48220
        public void System.Collections.Generic.IList<TElement>.get_Item(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.IList<TElement>.set_Item(){} // RVA: 0x7FFE810A1420
        public void get_Item(){} // RVA: 0x7FFE810A1420
        public void Contains(){} // RVA: 0x7FFE810A1420
        public void CopyTo(){} // RVA: 0x7FFE80E4D070
        public void GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFE80E4D070
        public void System.Collections.Generic.ICollection<TElement>.Add(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.ICollection<TElement>.Clear(){} // RVA: 0x7FFE80E45FE0
        public void System.Collections.Generic.ICollection<TElement>.Remove(){} // RVA: 0x7FFE810A1420
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IList.Add(){} // RVA: 0x7FFE80E33B00
        public void System.Collections.IList.Clear(){} // RVA: 0x7FFE80E45FE0
        public void System.Collections.IList.Contains(){} // RVA: 0x7FFE80E2F3B0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7FFE80E33B00
        public void System.Collections.IList.Insert(){} // RVA: 0x7FFE80E48220
        public void System.Collections.IList.Remove(){} // RVA: 0x7FFE80E460A0
        public void System.Collections.Generic.IList<TElement>.Insert(){} // RVA: 0x7FFE810A1420
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x7FFE80E46530
        public void IndexOf(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.IList<TElement>.RemoveAt(){} // RVA: 0x7FFE80E46530
    }

    public class LinqExtensions : Object
    {
        // ── Methods ──
        public void ForEach(){} // RVA: 0x7FFE80E2E440 | overloaded x2
        public void Append(){} // RVA: 0x7FFE80E2E440
    }

    public class MemberAliasFieldInfo : FieldInfo
    {
        public string FAKE_NAME_SEPARATOR_STRING;
        public System.Reflection.FieldInfo aliasedField; // 0x10
        public string mangledName; // 0x18
        public object field_3; // 0x9A
        public object field_4; // 0x9B
        public object field_5; // 0x9C
        public object field_6; // 0x9D
        public object field_7; // 0x9E
        public object field_8; // 0x9F

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE883EDCF0 | overloaded x2
        public void get_AliasedField(){} // RVA: 0x7FFE81116380
        public void get_Module(){} // RVA: 0x7FFE826F8E90
        public void get_MetadataToken(){} // RVA: 0x7FFE81588730
        public void get_Name(){} // RVA: 0x7FFE810FE7C0
        public void get_DeclaringType(){} // RVA: 0x7FFE86853DC0
        public void get_ReflectedType(){} // RVA: 0x7FFE86853DF0
        public void get_FieldType(){} // RVA: 0x7FFE81588910
        public void get_FieldHandle(){} // RVA: 0x7FFE86853FA0
        public void get_Attributes(){} // RVA: 0x7FFE815889C0
        public void GetCustomAttributes(){} // RVA: 0x7FFE86853E50 | overloaded x2
        public void IsDefined(){} // RVA: 0x7FFE81588B20
        public void GetValue(){} // RVA: 0x7FFE8605AD30
        public void SetValue(){} // RVA: 0x7FFE86853EE0
    }

    public class MemberAliasMethodInfo : MethodInfo
    {
        public string FAKE_NAME_SEPARATOR_STRING;
        public System.Reflection.MethodInfo aliasedMethod; // 0x10
        public string mangledName; // 0x18
        public object field_3; // 0xA3
        public object field_4; // 0xA4
        public object field_5; // 0xA5
        public object field_6; // 0xA6
        public object field_7; // 0xA7

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE883EDCF0 | overloaded x2
        public void get_AliasedMethod(){} // RVA: 0x7FFE81116380
        public void get_ReturnTypeCustomAttributes(){} // RVA: 0x7FFE883EDF50
        public void get_MethodHandle(){} // RVA: 0x7FFE872B31C0
        public void get_Attributes(){} // RVA: 0x7FFE81588910
        public void get_ReturnType(){} // RVA: 0x7FFE82C191D0
        public void get_DeclaringType(){} // RVA: 0x7FFE86853DC0
        public void get_Name(){} // RVA: 0x7FFE810FE7C0
        public void get_ReflectedType(){} // RVA: 0x7FFE86853DF0
        public void GetBaseDefinition(){} // RVA: 0x7FFE883EDF80
        public void GetCustomAttributes(){} // RVA: 0x7FFE86853E50 | overloaded x2
        public void GetMethodImplementationFlags(){} // RVA: 0x7FFE81588790
        public void GetParameters(){} // RVA: 0x7FFE815889C0
        public void Invoke(){} // RVA: 0x7FFE883EDFB0
        public void IsDefined(){} // RVA: 0x7FFE81588B20
    }

    public class MemberAliasPropertyInfo : PropertyInfo
    {
        public string FakeNameSeparatorString;
        public System.Reflection.PropertyInfo aliasedProperty; // 0x10
        public string mangledName; // 0x18
        public object field_3; // 0xAB
        public object field_4; // 0xAC
        public object field_5; // 0xAD
        public object field_6; // 0xAE
        public object field_7; // 0xAF
        public object field_8; // 0xB0
        public object field_9; // 0xB1

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE883EDCF0 | overloaded x2
        public void get_AliasedProperty(){} // RVA: 0x7FFE81116380
        public void get_Module(){} // RVA: 0x7FFE826F8E90
        public void get_MetadataToken(){} // RVA: 0x7FFE81588730
        public void get_Name(){} // RVA: 0x7FFE810FE7C0
        public void get_DeclaringType(){} // RVA: 0x7FFE86853DC0
        public void get_ReflectedType(){} // RVA: 0x7FFE86853DF0
        public void get_PropertyType(){} // RVA: 0x7FFE815889C0
        public void get_Attributes(){} // RVA: 0x7FFE81588A50
        public void get_CanRead(){} // RVA: 0x7FFE81588790
        public void get_CanWrite(){} // RVA: 0x7FFE86F36C70
        public void GetCustomAttributes(){} // RVA: 0x7FFE86853E50 | overloaded x2
        public void IsDefined(){} // RVA: 0x7FFE81588B20
        public void GetAccessors(){} // RVA: 0x7FFE815886B0
        public void GetGetMethod(){} // RVA: 0x7FFE872B30A0
        public void GetIndexParameters(){} // RVA: 0x7FFE81588910
        public void GetSetMethod(){} // RVA: 0x7FFE8605AD30
        public void GetValue(){} // RVA: 0x7FFE86853EE0
        public void SetValue(){} // RVA: 0x7FFE883EE120
    }

    public class MemberInfoExtensions : Object
    {
        // ── Methods ──
        public void IsDefined(){} // RVA: 0x7FFE80E2F230 | overloaded x2
        public void GetAttribute(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void GetAttributes(){} // RVA: 0x7FFE883DBB30 | overloaded x4
        public void GetNiceName(){} // RVA: 0x7FFE883DBC30
        public void IsStatic(){} // RVA: 0x7FFE883DBE60
        public void IsAlias(){} // RVA: 0x7FFE883DC2D0
        public void DeAlias(){} // RVA: 0x7FFE883DC370
    }

    public class MethodInfoExtensions : Object
    {
        // ── Methods ──
        public void GetFullName(){} // RVA: 0x7FFE883DC890 | overloaded x2
        public void GetParamsNames(){} // RVA: 0x7FFE883DC5F0
        public void IsExtensionMethod(){} // RVA: 0x7FFE883DC9F0
        public void IsAliasMethod(){} // RVA: 0x7FFE883DCB10
        public void DeAliasMethod(){} // RVA: 0x7FFE883DCB60
    }

    public class PathUtilities : Object
    {
        // ── Methods ──
        public void HasSubDirectory(){} // RVA: 0x7FFE883DCCA0
    }

    public class PropertyInfoExtensions : Object
    {
        // ── Methods ──
        public void IsAutoProperty(){} // RVA: 0x7FFE883DCEB0
        public void IsAliasProperty(){} // RVA: 0x7FFE883DD100
        public void DeAliasProperty(){} // RVA: 0x7FFE883DD150
    }

    public class ReferenceEqualityComparer`1 : Object
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE810A1420
        public void GetHashCode(){} // RVA: 0x7FFE810A1420
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
        public void .cctor(){} // RVA: 0x7FFE80E46010
    }

    public class StringExtensions : Object
    {
        // ── Methods ──
        public void ToTitleCase(){} // RVA: 0x7FFE883DD2F0
        public void IsNullOrWhitespace(){} // RVA: 0x7FFE883DD540
    }

    public class TypeExtensions : Object
    {
        // ── Methods ──
        public void GetCachedNiceName(){} // RVA: 0x7FFE883DD600
        public void CreateNiceName(){} // RVA: 0x7FFE883DD890
        public void HasCastDefined(){} // RVA: 0x7FFE883DDDE0
        public void IsValidIdentifier(){} // RVA: 0x7FFE883DE2D0
        public void IsValidIdentifierStartCharacter(){} // RVA: 0x7FFE883DE560
        public void IsValidIdentifierPartCharacter(){} // RVA: 0x7FFE883DE5D0
        public void IsCastableTo(){} // RVA: 0x7FFE883DE650
        public void GetCastMethodDelegate(){} // RVA: 0x7FFE80E3DFB0 | overloaded x2
        public void GetCastMethod(){} // RVA: 0x7FFE883DEBB0
        public void FloatEqualityComparer(){} // RVA: 0x7FFE883DF1F0
        public void DoubleEqualityComparer(){} // RVA: 0x7FFE883DF220
        public void QuaternionEqualityComparer(){} // RVA: 0x7FFE87321FF0
        public void GetEqualityComparerDelegate(){} // RVA: 0x7FFE80E2DEE0
        public void GetAttribute(){} // RVA: 0x7FFE810A1420
        public void ImplementsOrInherits(){} // RVA: 0x7FFE87140AF0
        public void ImplementsOpenGenericType(){} // RVA: 0x7FFE883DF260
        public void ImplementsOpenGenericInterface(){} // RVA: 0x7FFE883DF300
        public void ImplementsOpenGenericClass(){} // RVA: 0x7FFE883DF450
        public void GetArgumentsOfInheritedOpenGenericType(){} // RVA: 0x7FFE883DF570
        public void GetArgumentsOfInheritedOpenGenericClass(){} // RVA: 0x7FFE883DF610
        public void GetArgumentsOfInheritedOpenGenericInterface(){} // RVA: 0x7FFE883DF750
        public void GetOperatorMethod(){} // RVA: 0x7FFE883E0250 | overloaded x2
        public void GetOperatorMethods(){} // RVA: 0x7FFE883E06C0
        public void GetAllMembers(){} // RVA: 0x7FFE80E3D4E0 | overloaded x3
        public void GetGenericBaseType(){} // RVA: 0x7FFE883E0E20 | overloaded x2
        public void GetBaseTypes(){} // RVA: 0x7FFE883E12C0
        public void GetBaseClasses(){} // RVA: 0x7FFE883E1490
        public void TypeNameGauntlet(){} // RVA: 0x7FFE883E1550
        public void GetNiceName(){} // RVA: 0x7FFE883E1640
        public void GetNiceFullName(){} // RVA: 0x7FFE883E1790
        public void GetCompilableNiceName(){} // RVA: 0x7FFE883E1930
        public void GetCompilableNiceFullName(){} // RVA: 0x7FFE883E19F0
        public void GetCustomAttribute(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void GetCustomAttributes(){} // RVA: 0x7FFE80E3EBF0 | overloaded x2
        public void IsDefined(){} // RVA: 0x7FFE80E312F0 | overloaded x2
        public void InheritsFrom(){} // RVA: 0x7FFE883E1AB0 | overloaded x2
        public void GetInheritanceDistance(){} // RVA: 0x7FFE883E1C80
        public void HasParamaters(){} // RVA: 0x7FFE883E2090
        public void GetReturnType(){} // RVA: 0x7FFE883E2270
        public void GetMemberValue(){} // RVA: 0x7FFE883E2440
        public void SetMemberValue(){} // RVA: 0x7FFE883E2680
        public void TryInferGenericParameters(){} // RVA: 0x7FFE883E29C0
        public void AreGenericConstraintsSatisfiedBy(){} // RVA: 0x7FFE883E3F00 | overloaded x3
        public void GenericParameterIsFulfilledBy(){} // RVA: 0x7FFE883E4410 | overloaded x2
        public void GetGenericConstraintsString(){} // RVA: 0x7FFE883E4E10
        public void GetGenericParameterConstraintsString(){} // RVA: 0x7FFE883E5170
        public void GenericArgumentsContainsTypes(){} // RVA: 0x7FFE883E56B0
        public void IsFullyConstructedGenericType(){} // RVA: 0x7FFE883E5C30
        public void IsNullableType(){} // RVA: 0x7FFE883E5E50
        public void GetEnumBitmask(){} // RVA: 0x7FFE883E5EC0
        public void SafeGetTypes(){} // RVA: 0x7FFE883E6030
        public void SafeIsDefined(){} // RVA: 0x7FFE883E6090
        public void SafeGetCustomAttributes(){} // RVA: 0x7FFE883E60C0
        public void .cctor(){} // RVA: 0x7FFE883E6110
    }

    public class UnityExtensions : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE883EB230
        public void SafeIsUnityNull(){} // RVA: 0x7FFE883EB3F0
    }

    public class UnityVersion : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE883EE160
        public void EnsureLoaded(){} // RVA: 0x7FFE810FB310
        public void IsVersionOrGreater(){} // RVA: 0x7FFE883EE600
    }

    public class ValueGetter`2 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFE810A1420
        public void BeginInvoke(){} // RVA: 0x7FFE80E403A0
        public void EndInvoke(){} // RVA: 0x7FFE810A1420
    }

    public class ValueSetter`2 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFE810A1420
        public void BeginInvoke(){} // RVA: 0x7FFE810A1420
        public void EndInvoke(){} // RVA: 0x7FFE80E4F230
    }

    public class WeakValueGetter : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8526B7D0
        public void Invoke(){} // RVA: 0x7FFE81156C60
        public void BeginInvoke(){} // RVA: 0x7FFE8526B8B0
        public void EndInvoke(){} // RVA: 0x7FFE82C67E40
    }

    public class WeakValueGetter`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFE810A1420
        public void BeginInvoke(){} // RVA: 0x7FFE80E403A0
        public void EndInvoke(){} // RVA: 0x7FFE810A1420
    }

    public class WeakValueSetter : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82B9EE00
        public void Invoke(){} // RVA: 0x7FFE81257370
        public void BeginInvoke(){} // RVA: 0x7FFE883EB4F0
        public void EndInvoke(){} // RVA: 0x7FFE82C67E40
    }

    public class WeakValueSetter`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFE810A1420
        public void BeginInvoke(){} // RVA: 0x7FFE810A1420
        public void EndInvoke(){} // RVA: 0x7FFE80E4F230
    }

}