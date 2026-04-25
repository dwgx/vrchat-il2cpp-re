// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Properties
// Classes: 32
// Methods: 106

namespace ThirdParty.Other.Unity.Properties
{
    public class ArrayPropertyBag`1 : IndexedCollectionPropertyBag`2
    {
        public object InstantiationKind;

        // ── Methods ──
        public void get_InstantiationKind(){} // RVA: 0x7FFAC2C59960
        public void InstantiateWithCount(){} // RVA: 0x7FFAC2C67DE0
        public void Instantiate(){} // RVA: 0x7FFAC2C58E90
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class ContainerPropertyBag`1 : PropertyBag`1
    {
        public System.Collections.Generic.List`1<Unity.Properties.IProperty`1<T>> m_PropertiesList;
        public System.Collections.Generic.Dictionary`2<string,Unity.Properties.IProperty`1<T>> m_PropertiesHash;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
        public void AddProperty(){} // RVA: 0x7FFAC2C70A40
        public void TryGetProperty(){}
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class CreatePropertyAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class DelegateProperty`2 : Property`2
    {
        public Unity.Properties.PropertyGetter`2<U,T> Name;
        public Unity.Properties.PropertySetter`2<U,T> m_Setter;
        public string <Name>k__BackingField;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAC2C58E90
        public void .ctor(){} // RVA: 0x7FFAC2C7AF60
    }

    public class DictionaryPropertyBag`2 : KeyValueCollectionPropertyBag`3
    {
        public object InstantiationKind;

        // ── Methods ──
        public void get_InstantiationKind(){} // RVA: 0x7FFAC2C59960
        public void Instantiate(){} // RVA: 0x7FFAC2C58E90
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class DontCreatePropertyAttribute : Attribute
    {
    }

    public class FieldMember : ValueType
    {
        public System.Reflection.FieldInfo Name; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC38DFE40
        public void get_Name(){} // RVA: 0x7FFAC98E3600
        public void get_IsReadOnly(){} // RVA: 0x7FFAC99A34F0
        public void get_ValueType(){} // RVA: 0x7FFAC99A3520
        public void GetCustomAttributes(){} // RVA: 0x7FFAC99A3550
    }

    public class HashSetPropertyBag`1 : SetPropertyBagBase`2
    {
        public object InstantiationKind;

        // ── Methods ──
        public void get_InstantiationKind(){} // RVA: 0x7FFAC2C59960
        public void Instantiate(){} // RVA: 0x7FFAC2C58E90
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class IConstructor
    {
        public object InstantiationKind;

        // ── Methods ──
        public void get_InstantiationKind(){} // RVA: 0x7FFAC2C59960
    }

    public class IConstructorWithCount`1
    {
        // ── Methods ──
        public void InstantiateWithCount(){} // RVA: 0x7FFAC2E8DC40
    }

    public class IConstructor`1
    {
        // ── Methods ──
        public void Instantiate(){} // RVA: 0x7FFAC2E8DC40
    }

    public class IMemberInfo
    {
        public object Name;
        public object IsReadOnly;
        public object ValueType;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAC2C58E90
        public void get_IsReadOnly(){} // RVA: 0x7FFAC2C59D00
        public void get_ValueType(){} // RVA: 0x7FFAC2C58E90
        public void GetCustomAttributes(){} // RVA: 0x7FFAC2C58E90
    }

    public class IProperty
    {
        // ── Methods ──
        public void DeclaredValueType(){} // RVA: 0x7FFAC2C58E90
    }

    public class IPropertyBag
    {
        // ── Methods ──
        public void Accept(){} // RVA: 0x7FFAC2C70A40
    }

    public class IPropertyBag`1
    {
    }

    public class IProperty`1
    {
    }

    public class ITypeVisitor
    {
        // ── Methods ──
        public void Visit(){} // RVA: 0x7FFAC2C70980
    }

    public class IndexedCollectionPropertyBag`2 : PropertyBag`1
    {
        public ListElementProperty<T[],T> m_Property; // 0x18

        // ── Methods ──
        public void Unity.Properties.IConstructorWithCount<TList>.InstantiateWithCount(){} // RVA: 0x7FFAC2C67DE0
        public void InstantiateWithCount(){} // RVA: 0x7FFAC2C67DE0
        public void .ctor(){} // RVA: 0x7FFAC5EB9EF0
    }

    public class KeyValueCollectionPropertyBag`3 : PropertyBag`1
    {
        public KeyValuePairProperty<System.Collections.Generic.Dictionary`2<U,T>,U,T> m_KeyValuePairProperty; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC60ED040
    }

    public class KeyValuePairPropertyBag`2 : PropertyBag`1
    {
        public Unity.Properties.DelegateProperty`2<System.Collections.Generic.KeyValuePair`2<U,T>,U> s_KeyProperty;
        public Unity.Properties.DelegateProperty`2<System.Collections.Generic.KeyValuePair`2<U,T>,T> s_ValueProperty;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70980
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
    }

    public class ListPropertyBag`1 : IndexedCollectionPropertyBag`2
    {
        public object InstantiationKind;

        // ── Methods ──
        public void get_InstantiationKind(){} // RVA: 0x7FFAC2C59960
        public void InstantiateWithCount(){} // RVA: 0x7FFAC2C67DE0
        public void Instantiate(){} // RVA: 0x7FFAC2C58E90
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class PropertyBag : Object
    {
        // ── Methods ──
        public void Register(){} // RVA: 0x7FFAC2C70A10
    }

    public class PropertyBag`1 : Object
    {
        public 0x6B2BB3E8 Unity.Properties.IConstructor.InstantiationKind; // 0x10

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC6733EE0
        public void Unity.Properties.Internal.IPropertyBagRegister.Register(){} // RVA: 0x7FFAC6734150
        public void Accept(){} // RVA: 0x7FFAC6732C00
        public void Unity.Properties.IConstructor.get_InstantiationKind(){} // RVA: 0x7FFAC30FEBD0
        public void Unity.Properties.IConstructor<TContainer>.Instantiate(){} // RVA: 0x7FFAC2E5B230
        public void get_InstantiationKind(){} // RVA: 0x7FFAC2F6E5C0
        public void Instantiate(){} // RVA: 0x7FFAC2E5B230
        public void .ctor(){} // RVA: 0x7FFAC369FBB0
    }

    public class PropertyGetter`2 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFAC2E8DC40
    }

    public class PropertyMember : ValueType
    {
        public System.Reflection.PropertyInfo Name; // 0x10

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAC98E3600
        public void get_IsReadOnly(){} // RVA: 0x7FFAC99A3560
        public void get_ValueType(){} // RVA: 0x7FFAC99A3590
        public void .ctor(){} // RVA: 0x7FFAC38DFE40
        public void GetCustomAttributes(){} // RVA: 0x7FFAC99A3550
    }

    public class PropertySetter`2 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFAC2E8DC40
    }

    public class Property`2 : Object
    {
        public System.Collections.Generic.List`1<System.Attribute> Name; // 0x10

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAC2C58E90
        public void DeclaredValueType(){} // RVA: 0x7FFAC6736C20
        public void AddAttribute(){} // RVA: 0x7FFAC6736CD0
        public void AddAttributes(){} // RVA: 0x7FFAC6736D30
        public void Unity.Properties.Internal.IAttributes.AddAttribute(){} // RVA: 0x7FFAC6736D90
        public void Unity.Properties.Internal.IAttributes.AddAttributes(){} // RVA: 0x7FFAC6736EF0
        public void HasAttribute(){} // RVA: 0x7FFAC2C59D00
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ReflectedMemberProperty`2 : Property`2
    {
        public Unity.Properties.IMemberInfo Name;
        public bool m_IsStructContainerType;
        public GetStructValueAction<U,T> m_GetStructValueAction;
        public SetStructValueAction<U,T> m_SetStructValueAction;
        public GetClassValueAction<U,T> m_GetClassValueAction;
        public SetClassValueAction<U,T> m_SetClassValueAction;
        public string <Name>k__BackingField;
        public bool <IsReadOnly>k__BackingField;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAC2C58E90
        public void .ctor(){} // RVA: 0x7FFAC2C79B30
    }

    public class SetPropertyBagBase`2 : PropertyBag`1
    {
        public SetElementProperty<System.Collections.Generic.HashSet`1<T>,T> m_Property; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC60ED040
    }

    public class TypeTraits : Object
    {
        // ── Methods ──
        public void IsContainer(){} // RVA: 0x7FFAC99A35C0
    }

    public class TypeTraits`1 : Object
    {
        public bool IsValueType;
        public bool IsPrimitive;
        public bool IsInterface;
        public bool IsAbstract;
        public bool IsArray;
        public bool IsEnum;
        public bool IsNullable;
        public bool IsObject;
        public bool IsString;
        public bool IsContainer;
        public bool CanBeNull;
        public bool IsAbstractOrInterface;
        public bool <CanBeNull>k__BackingField;
        public bool <IsPrimitiveOrString>k__BackingField;
        public bool <IsAbstractOrInterface>k__BackingField;
        public bool <IsUnityObject>k__BackingField;
        public bool <IsLazyLoadReference>k__BackingField;

        // ── Methods ──
        public void get_IsValueType(){} // RVA: 0x7FFAC2C59D30
        public void get_IsPrimitive(){} // RVA: 0x7FFAC2C59D30
        public void get_IsInterface(){} // RVA: 0x7FFAC2C59D30
        public void get_IsAbstract(){} // RVA: 0x7FFAC2C59D30
        public void get_IsArray(){} // RVA: 0x7FFAC2C59D30
        public void get_IsEnum(){} // RVA: 0x7FFAC2C59D30
        public void get_IsNullable(){} // RVA: 0x7FFAC2C59D30
        public void get_IsObject(){} // RVA: 0x7FFAC2C59D30
        public void get_IsString(){} // RVA: 0x7FFAC2C59D30
        public void get_IsContainer(){} // RVA: 0x7FFAC2C59D30
        public void get_CanBeNull(){} // RVA: 0x7FFAC2C59D30
        public void get_IsAbstractOrInterface(){} // RVA: 0x7FFAC2C59D30
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
    }

    public class TypeUtility : Object
    {
        public System.Collections.Concurrent.ConcurrentDictionary`2<System.Type,ITypeConstructor> s_TypeConstructors;
        public System.Reflection.MethodInfo s_CreateTypeConstructor; // 0x8
        public System.Collections.Concurrent.ConcurrentDictionary`2<System.Type,string> s_CachedResolvedName; // 0x10
        public UnityEngine.Pool.ObjectPool`1<System.Text.StringBuilder> s_Builders; // 0x18
        public object syncedPoolObject; // 0x20

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC99A3700
        public void GetTypeDisplayName(){} // RVA: 0x7FFAC99A3F30 | overloaded x2
        public void GetRootType(){} // RVA: 0x7FFAC99A4AF0
        public void CreateTypeConstructor(){} // RVA: 0x7FFAC2C58A90 | overloaded x2
        public void GetTypeConstructor(){} // RVA: 0x7FFAC2C58A90 | overloaded x2
        public void CanBeInstantiated(){} // RVA: 0x7FFAC2C59D30 | overloaded x2
        public void SetExplicitInstantiationMethod(){} // RVA: 0x7FFAC2C70A10
        public void Instantiate(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void TryInstantiate(){} // RVA: 0x7FFAC2C5A350 | overloaded x2
        public void InstantiateArray(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void TryInstantiateArray(){} // RVA: 0x7FFAC2C5B2B0
        public void CheckIsAssignableFrom(){} // RVA: 0x7FFAC99A50C0
        public void CheckCanBeInstantiated(){} // RVA: 0x7FFAC99A5240 | overloaded x2
    }

}