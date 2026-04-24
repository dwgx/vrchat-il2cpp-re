// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Properties
// Classes: 22
// Methods: 87

namespace ThirdParty.Other.Unity.Properties
{
    public class ArrayPropertyBag`1 : IndexedCollectionPropertyBag`2
    {
        public object InstantiationKind;

        // ── Methods ──
        public void get_InstantiationKind(){} // RVA: 0x7FFD4E079960
        public void InstantiateWithCount(){} // RVA: 0x7FFD4E087DE0
        public void Instantiate(){} // RVA: 0x7FFD4E078E90
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class ContainerPropertyBag`1 : PropertyBag`1
    {
        public URA.woDigitYearMax<ÌÎÎÏÍÎÌÎÌÍÍÏÍÍÏÍÌÏ<T1717740912>> m_PropertiesList; // 0x18
        public URA.DateTime<string,ÌÎÎÏÍÎÌÎÌÍÍÏÍÍÏÍÌÏ<T1717740912>> m_PropertiesHash; // 0x20

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
        public void AddProperty(){} // RVA: 0x7FFD4E090A40
        public void TryGetProperty(){}
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class DelegateProperty`2 : Property`2
    {
        public ?<T1717739824,T1717739840> Name;
        public ?<T1717739824,T1717739840> m_Setter;
        public string <Name>k__BackingField;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD4E078E90
        public void .ctor(){} // RVA: 0x7FFD4E09AF60
    }

    public class DictionaryPropertyBag`2 : KeyValueCollectionPropertyBag`3
    {
        public object InstantiationKind;

        // ── Methods ──
        public void get_InstantiationKind(){} // RVA: 0x7FFD4E079960
        public void Instantiate(){} // RVA: 0x7FFD4E078E90
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class HashSetPropertyBag`1 : SetPropertyBagBase`2
    {
        public object InstantiationKind;

        // ── Methods ──
        public void get_InstantiationKind(){} // RVA: 0x7FFD4E079960
        public void Instantiate(){} // RVA: 0x7FFD4E078E90
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class IConstructorWithCount`1
    {
        // ── Methods ──
        public void InstantiateWithCount(){} // RVA: 0x7FFD4E2ADC40
    }

    public class IConstructor`1
    {
        // ── Methods ──
        public void Instantiate(){} // RVA: 0x7FFD4E2ADC40
    }

    public class IPropertyBag`1
    {
    }

    public class ITypeVisitor
    {
        // ── Methods ──
        public void Visit(){} // RVA: 0x7FFD4E090980
    }

    public class IndexedCollectionPropertyBag`2 : PropertyBag`1
    {
        public ÌÏÎÌÌÎÌÍÎÍÍÏÏÍÌÍÏ<URA.woDigitYearMax<T1717740416>,T1717740416> m_Property; // 0x18

        // ── Methods ──
        public void Unity.Properties.IConstructorWithCount<TList>.InstantiateWithCount(){} // RVA: 0x7FFD4E087DE0
        public void InstantiateWithCount(){} // RVA: 0x7FFD4E087DE0
        public void .ctor(){} // RVA: 0x7FFD512D9EF0
    }

    public class KeyValueCollectionPropertyBag`3 : PropertyBag`1
    {
        public ?<T1717740304,T1717740320,T1717740336> m_KeyValuePairProperty;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5150D040
    }

    public class KeyValuePairPropertyBag`2 : PropertyBag`1
    {
        public ÎÍÎÏÍÎÏÌÍÏÌÏÍÍÎÏÍÌÌ>k__BackingField<URA.mes<T1717740384,T1717740400>,T1717740384> s_KeyProperty;
        public ÎÍÎÏÍÎÏÌÍÏÌÏÍÍÎÏÍÌÌ>k__BackingField<URA.mes<T1717740384,T1717740400>,T1717740400> s_ValueProperty;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090980
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

    public class ListPropertyBag`1 : IndexedCollectionPropertyBag`2
    {
        public object InstantiationKind;

        // ── Methods ──
        public void get_InstantiationKind(){} // RVA: 0x7FFD4E079960
        public void InstantiateWithCount(){} // RVA: 0x7FFD4E087DE0
        public void Instantiate(){} // RVA: 0x7FFD4E078E90
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class PropertyBag : Object
    {
        // ── Methods ──
        public void Register(){} // RVA: 0x7FFD4E090A10
    }

    public class PropertyBag`1 : Object
    {
        public object Unity.Properties.IConstructor.InstantiationKind; // 0x10

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD51B53EE0
        public void Unity.Properties.Internal.IPropertyBagRegister.Register(){} // RVA: 0x7FFD51B54150
        public void Accept(){} // RVA: 0x7FFD51B52C00
        public void Unity.Properties.IConstructor.get_InstantiationKind(){} // RVA: 0x7FFD4E51EBD0
        public void Unity.Properties.IConstructor<TContainer>.Instantiate(){} // RVA: 0x7FFD4E27B230
        public void get_InstantiationKind(){} // RVA: 0x7FFD4E38E5C0
        public void Instantiate(){} // RVA: 0x7FFD4E27B230
        public void .ctor(){} // RVA: 0x7FFD4EABFBB0
    }

    public class PropertyGetter`2 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFD4E2ADC40
    }

    public class PropertySetter`2 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFD4E2ADC40
    }

    public class Property`2 : Object
    {
        public URA.woDigitYearMax<lP256R1> Name; // 0x10

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD4E078E90
        public void DeclaredValueType(){} // RVA: 0x7FFD51B56C20
        public void AddAttribute(){} // RVA: 0x7FFD51B56CD0
        public void AddAttributes(){} // RVA: 0x7FFD51B56D30
        public void Unity.Properties.Internal.IAttributes.AddAttribute(){} // RVA: 0x7FFD51B56D90
        public void Unity.Properties.Internal.IAttributes.AddAttributes(){} // RVA: 0x7FFD51B56EF0
        public void HasAttribute(){} // RVA: 0x7FFD4E079D00
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class ReflectedMemberProperty`2 : Property`2
    {
        public ÍÏÎÏÏÍÍÌÎÌÏÌÌÎÌÏÏÍÍ Name;
        public bool m_IsStructContainerType;
        public ÎÍÍÌÏÎÌÎÎÎ<T1717740048,T1717740064> m_GetStructValueAction;
        public ÌÍÎÎÍÌÍÍÍÎÎÏÌÍÎÏÌÍÌÎÍÌÎ<T1717740048,T1717740064> m_SetStructValueAction;
        public ?<T1717740048,T1717740064> m_GetClassValueAction;
        public ?<T1717740048,T1717740064> m_SetClassValueAction;
        public string <Name>k__BackingField;
        public bool <IsReadOnly>k__BackingField;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD4E078E90
        public void .ctor(){} // RVA: 0x7FFD4E099B30
    }

    public class SetPropertyBagBase`2 : PropertyBag`1
    {
        public Î<T1717740496,T1717740512> m_Property;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5150D040
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
        public void get_IsValueType(){} // RVA: 0x7FFD4E079D30
        public void get_IsPrimitive(){} // RVA: 0x7FFD4E079D30
        public void get_IsInterface(){} // RVA: 0x7FFD4E079D30
        public void get_IsAbstract(){} // RVA: 0x7FFD4E079D30
        public void get_IsArray(){} // RVA: 0x7FFD4E079D30
        public void get_IsEnum(){} // RVA: 0x7FFD4E079D30
        public void get_IsNullable(){} // RVA: 0x7FFD4E079D30
        public void get_IsObject(){} // RVA: 0x7FFD4E079D30
        public void get_IsString(){} // RVA: 0x7FFD4E079D30
        public void get_IsContainer(){} // RVA: 0x7FFD4E079D30
        public void get_CanBeNull(){} // RVA: 0x7FFD4E079D30
        public void get_IsAbstractOrInterface(){} // RVA: 0x7FFD4E079D30
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

    public class TypeUtility : Object
    {
        public JapaneseLangName.erns<?,?> s_TypeConstructors;
        public m.jectMapInfo s_CreateTypeConstructor; // 0x8
        public JapaneseLangName.erns<?,string> s_CachedResolvedName; // 0x10
        public cy.gContentId<em.MarkAborted.izeDefaultCase> s_Builders; // 0x18
        public object syncedPoolObject; // 0x20

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD54DC3700
        public void GetTypeDisplayName(){} // RVA: 0x7FFD54DC3F30 | overloaded x2
        public void GetRootType(){} // RVA: 0x7FFD54DC4AF0
        public void CreateTypeConstructor(){} // RVA: 0x7FFD4E078A90 | overloaded x2
        public void GetTypeConstructor(){} // RVA: 0x7FFD4E078A90 | overloaded x2
        public void CanBeInstantiated(){} // RVA: 0x7FFD4E079D30 | overloaded x2
        public void SetExplicitInstantiationMethod(){} // RVA: 0x7FFD4E090A10
        public void Instantiate(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void TryInstantiate(){} // RVA: 0x7FFD4E07A350 | overloaded x2
        public void InstantiateArray(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void TryInstantiateArray(){} // RVA: 0x7FFD4E07B2B0
        public void CheckIsAssignableFrom(){} // RVA: 0x7FFD54DC50C0
        public void CheckCanBeInstantiated(){} // RVA: 0x7FFD54DC5240 | overloaded x2
    }

}