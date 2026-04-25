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
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
        public void AddProperty(){} // RVA: 0x7FFD4E090A40
        public void TryGetProperty(){}
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class DelegateProperty`2 : Property`2
    {
        public object Name;

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
        // ── Methods ──
        public void Unity.Properties.IConstructorWithCount<TList>.InstantiateWithCount(){} // RVA: 0x7FFD4E087DE0
        public void InstantiateWithCount(){} // RVA: 0x7FFD4E087DE0
        public void .ctor(){} // RVA: 0x7FFD512D9EF0
    }

    public class KeyValueCollectionPropertyBag`3 : PropertyBag`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5150D040
    }

    public class KeyValuePairPropertyBag`2 : PropertyBag`1
    {
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
        public object Unity.Properties.IConstructor.InstantiationKind;
        public object InstantiationKind;

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
        public object Name;

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
        public object Name;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD4E078E90
        public void .ctor(){} // RVA: 0x7FFD4E099B30
    }

    public class SetPropertyBagBase`2 : PropertyBag`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5150D040
    }

    public class TypeTraits`1 : Object
    {
        public object IsValueType;
        public object IsPrimitive;
        public object IsInterface;
        public object IsAbstract;
        public object IsArray;
        public object IsEnum;
        public object IsNullable;
        public object IsObject;
        public object IsString;
        public object IsContainer;
        public object CanBeNull;
        public object IsAbstractOrInterface;

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