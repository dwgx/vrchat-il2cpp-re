// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Properties
// Classes: 32
// Methods: 106

namespace ThirdParty.Other.Unity.Properties
{
    public class ArrayPropertyBag`1 : IndexedCollectionPropertyBag`2
    {
        // ── Methods ──
        public void get_InstantiationKind(){} // RVA: 0x7FFE80E2EDB0
        public void InstantiateWithCount(){} // RVA: 0x7FFE80E3D230
        public void Instantiate(){} // RVA: 0x7FFE80E2E2E0
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class ContainerPropertyBag`1 : PropertyBag`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE80E46010
        public void AddProperty(){} // RVA: 0x7FFE80E460A0
        public void TryGetProperty(){}
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class CreatePropertyAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class DelegateProperty`2 : Property`2
    {
        public Unity.Properties.PropertyGetter`2<U,T> m_Getter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFE80E2E2E0
        public void .ctor(){} // RVA: 0x7FFE80E50660
    }

    public class DictionaryPropertyBag`2 : KeyValueCollectionPropertyBag`3
    {
        // ── Methods ──
        public void get_InstantiationKind(){} // RVA: 0x7FFE80E2EDB0
        public void Instantiate(){} // RVA: 0x7FFE80E2E2E0
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class DontCreatePropertyAttribute : Attribute
    {
    }

    public class FieldMember : ValueType
    {
        public System.Reflection.FieldInfo m_FieldInfo; // 0x10
        public object field_1; // 0x6
        public object field_2; // 0x7

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81D7E9E0
        public void get_Name(){} // RVA: 0x7FFE87C8BD30
        public void get_IsReadOnly(){} // RVA: 0x7FFE87D4BD90
        public void get_ValueType(){} // RVA: 0x7FFE87D4BDC0
        public void GetCustomAttributes(){} // RVA: 0x7FFE87D4BDF0
    }

    public class HashSetPropertyBag`1 : SetPropertyBagBase`2
    {
        // ── Methods ──
        public void get_InstantiationKind(){} // RVA: 0x7FFE80E2EDB0
        public void Instantiate(){} // RVA: 0x7FFE80E2E2E0
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class IConstructor
    {
        // ── Methods ──
        public void get_InstantiationKind(){} // RVA: 0x7FFE80E2EDB0
    }

    public class IConstructorWithCount`1
    {
        // ── Methods ──
        public void InstantiateWithCount(){} // RVA: 0x7FFE810A1420
    }

    public class IConstructor`1
    {
        // ── Methods ──
        public void Instantiate(){} // RVA: 0x7FFE810A1420
    }

    public class IMemberInfo
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFE80E2E2E0
        public void get_IsReadOnly(){} // RVA: 0x7FFE80E2F150
        public void get_ValueType(){} // RVA: 0x7FFE80E2E2E0
        public void GetCustomAttributes(){} // RVA: 0x7FFE80E2E2E0
    }

    public class IProperty
    {
        // ── Methods ──
        public void DeclaredValueType(){} // RVA: 0x7FFE80E2E2E0
    }

    public class IPropertyBag
    {
        // ── Methods ──
        public void Accept(){} // RVA: 0x7FFE80E460A0
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
        public void Visit(){} // RVA: 0x7FFE80E45FE0
    }

    public class IndexedCollectionPropertyBag`2 : PropertyBag`1
    {
        // ── Methods ──
        public void Unity.Properties.IConstructorWithCount<TList>.InstantiateWithCount(){} // RVA: 0x7FFE80E3D230
        public void InstantiateWithCount(){} // RVA: 0x7FFE80E3D230
        public void .ctor(){} // RVA: 0x7FFE8421F170
    }

    public class KeyValueCollectionPropertyBag`3 : PropertyBag`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE84452230
    }

    public class KeyValuePairPropertyBag`2 : PropertyBag`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
        public void .cctor(){} // RVA: 0x7FFE80E46010
    }

    public class ListPropertyBag`1 : IndexedCollectionPropertyBag`2
    {
        // ── Methods ──
        public void get_InstantiationKind(){} // RVA: 0x7FFE80E2EDB0
        public void InstantiateWithCount(){} // RVA: 0x7FFE80E3D230
        public void Instantiate(){} // RVA: 0x7FFE80E2E2E0
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class PropertyBag : Object
    {
        // ── Methods ──
        public void Register(){} // RVA: 0x7FFE80E46070
    }

    public class PropertyBag`1 : Object
    {
        public 0x666B5F3C _instantiationKind; // 0x10
        public object field_1; // 0x15

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE84A91EF0
        public void Unity.Properties.Internal.IPropertyBagRegister.Register(){} // RVA: 0x7FFE84A92160
        public void Accept(){} // RVA: 0x7FFE84A90C10
        public void Unity.Properties.IConstructor.get_InstantiationKind(){} // RVA: 0x7FFE81768340
        public void Unity.Properties.IConstructor<TContainer>.Instantiate(){} // RVA: 0x7FFE81081080
        public void get_InstantiationKind(){} // RVA: 0x7FFE811485C0
        public void Instantiate(){} // RVA: 0x7FFE81081080
        public void .ctor(){} // RVA: 0x7FFE817EE4A0
    }

    public class PropertyGetter`2 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFE810A1420
    }

    public class PropertyMember : ValueType
    {
        public System.Reflection.PropertyInfo m_PropertyInfo; // 0x10
        public object field_1; // 0x9
        public object field_2; // 0xA

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFE87C8BD30
        public void get_IsReadOnly(){} // RVA: 0x7FFE87D4BE00
        public void get_ValueType(){} // RVA: 0x7FFE87D4BE30
        public void .ctor(){} // RVA: 0x7FFE81D7E9E0
        public void GetCustomAttributes(){} // RVA: 0x7FFE87D4BDF0
    }

    public class PropertySetter`2 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFE810A1420
    }

    public class Property`2 : Object
    {
        public System.Collections.Generic.List`1<System.Attribute> m_Attributes;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFE80E2E2E0
        public void DeclaredValueType(){} // RVA: 0x7FFE80E2E2E0
        public void AddAttribute(){} // RVA: 0x7FFE80E460A0
        public void AddAttributes(){} // RVA: 0x7FFE80E460A0
        public void Unity.Properties.Internal.IAttributes.AddAttribute(){} // RVA: 0x7FFE80E460A0
        public void Unity.Properties.Internal.IAttributes.AddAttributes(){} // RVA: 0x7FFE80E460A0
        public void HasAttribute(){} // RVA: 0x7FFE80E2F150
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class ReflectedMemberProperty`2 : Property`2
    {
        public Unity.Properties.IMemberInfo m_Info;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFE80E2E2E0
        public void .ctor(){} // RVA: 0x7FFE80E4F230
    }

    public class SetPropertyBagBase`2 : PropertyBag`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE84452230
    }

    public class TypeTraits : Object
    {
        // ── Methods ──
        public void IsContainer(){} // RVA: 0x7FFE87D4BE60
    }

    public class TypeTraits`1 : Object
    {
        public bool _isValueType;
        public bool _isPrimitive;
        public bool _isInterface;
        public bool _isAbstract;
        public bool _isArray;
        public bool _isMultidimensionalArray;
        public bool _isEnum;
        public bool _isEnumFlags;
        public bool _isNullable;
        public bool _isObject;
        public bool _isString;
        public bool _isContainer;

        // ── Methods ──
        public void get_IsValueType(){} // RVA: 0x7FFE80E2F180
        public void get_IsPrimitive(){} // RVA: 0x7FFE80E2F180
        public void get_IsInterface(){} // RVA: 0x7FFE80E2F180
        public void get_IsAbstract(){} // RVA: 0x7FFE80E2F180
        public void get_IsArray(){} // RVA: 0x7FFE80E2F180
        public void get_IsEnum(){} // RVA: 0x7FFE80E2F180
        public void get_IsNullable(){} // RVA: 0x7FFE80E2F180
        public void get_IsObject(){} // RVA: 0x7FFE80E2F180
        public void get_IsString(){} // RVA: 0x7FFE80E2F180
        public void get_IsContainer(){} // RVA: 0x7FFE80E2F180
        public void get_CanBeNull(){} // RVA: 0x7FFE80E2F180
        public void get_IsAbstractOrInterface(){} // RVA: 0x7FFE80E2F180
        public void .cctor(){} // RVA: 0x7FFE80E46010
    }

    public class TypeUtility : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE87D4BFA0
        public void GetTypeDisplayName(){} // RVA: 0x7FFE87D4C7D0 | overloaded x2
        public void GetRootType(){} // RVA: 0x7FFE87D4D390
        public void CreateTypeConstructor(){} // RVA: 0x7FFE80E2DEE0 | overloaded x2
        public void GetTypeConstructor(){} // RVA: 0x7FFE80E2DEE0 | overloaded x2
        public void CanBeInstantiated(){} // RVA: 0x7FFE80E2F180 | overloaded x2
        public void SetExplicitInstantiationMethod(){} // RVA: 0x7FFE80E46070
        public void Instantiate(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void TryInstantiate(){} // RVA: 0x7FFE80E2F7A0 | overloaded x2
        public void InstantiateArray(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void TryInstantiateArray(){} // RVA: 0x7FFE80E30700
        public void CheckIsAssignableFrom(){} // RVA: 0x7FFE87D4D960
        public void CheckCanBeInstantiated(){} // RVA: 0x7FFE87D4DAE0 | overloaded x2
    }

}