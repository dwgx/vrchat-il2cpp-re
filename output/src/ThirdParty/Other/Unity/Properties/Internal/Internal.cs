// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Properties.Internal
// Classes: 14
// Methods: 33

namespace ThirdParty.Other.Unity.Properties.Internal
{
    public class BoundsIntPropertyBag : ContainerPropertyBag`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC99A6DD0
    }

    public class BoundsPropertyBag : ContainerPropertyBag`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC99A6BD0
    }

    public class DefaultPropertyBagInitializer : Object
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFAC99A54E0
    }

    public class IAttributes
    {
        // ── Methods ──
        public void AddAttribute(){} // RVA: 0x7FFAC2C70A40
        public void AddAttributes(){} // RVA: 0x7FFAC2C70A40
    }

    public class IPropertyBagRegister
    {
        // ── Methods ──
        public void Register(){} // RVA: 0x7FFAC2C70980
    }

    public class PropertyBagStore : Object
    {
        public System.Collections.Concurrent.ConcurrentDictionary`2<System.Type,Unity.Properties.IPropertyBag> s_PropertyBags;
        public System.Collections.Generic.List`1<System.Type> s_RegisteredTypes; // 0x8
        public System.Action`2<System.Type,Unity.Properties.IPropertyBag> NewTypeRegistered; // 0x10
        public Unity.Properties.Internal.ReflectedPropertyBagProvider s_PropertyBagProvider; // 0x18

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC99A76F0
        public void AddPropertyBag(){} // RVA: 0x7FFAC2C70A10
        public void GetPropertyBag(){} // RVA: 0x7FFAC99A7990 | overloaded x2
    }

    public class RectIntPropertyBag : ContainerPropertyBag`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC99A6860
    }

    public class RectPropertyBag : ContainerPropertyBag`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC99A64F0
    }

    public class ReflectedPropertyBagAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ReflectedPropertyBagProvider : Object
    {
        public System.Reflection.MethodInfo m_CreatePropertyMethod; // 0x10
        public System.Reflection.MethodInfo m_CreatePropertyBagMethod; // 0x18
        public System.Reflection.MethodInfo m_CreateIndexedCollectionPropertyBagMethod; // 0x20
        public System.Reflection.MethodInfo m_CreateSetPropertyBagMethod; // 0x28
        public System.Reflection.MethodInfo m_CreateKeyValueCollectionPropertyBagMethod; // 0x30
        public System.Reflection.MethodInfo m_CreateKeyValuePairPropertyBagMethod; // 0x38
        public System.Reflection.MethodInfo m_CreateArrayPropertyBagMethod; // 0x40
        public System.Reflection.MethodInfo m_CreateListPropertyBagMethod; // 0x48
        public System.Reflection.MethodInfo m_CreateHashSetPropertyBagMethod; // 0x50
        public System.Reflection.MethodInfo m_CreateDictionaryPropertyBagMethod; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC99A7DE0
        public void CreatePropertyBag(){} // RVA: 0x7FFAC2C58E90 | overloaded x2
        public void CreateProperty(){} // RVA: 0x7FFAC2C79B30
        public void CreateIndexedCollectionPropertyBag(){} // RVA: 0x7FFAC2C58E90
        public void CreateSetPropertyBag(){} // RVA: 0x7FFAC2C58E90
        public void CreateKeyValueCollectionPropertyBag(){} // RVA: 0x7FFAC2C58E90
        public void CreateKeyValuePairPropertyBag(){} // RVA: 0x7FFAC2C58E90
        public void CreateArrayPropertyBag(){} // RVA: 0x7FFAC2C58E90
        public void CreateListPropertyBag(){} // RVA: 0x7FFAC2C58E90
        public void CreateHashSetPropertyBag(){} // RVA: 0x7FFAC2C58E90
        public void CreateDictionaryPropertyBag(){} // RVA: 0x7FFAC2C58E90
        public void GetPropertyMembers(){} // RVA: 0x7FFAC99A8E40
        public void IsValidMember(){} // RVA: 0x7FFAC99A8EF0
        public void IsValidPropertyType(){} // RVA: 0x7FFAC99A90B0
    }

    public class ReflectedPropertyBag`1 : ContainerPropertyBag`1
    {
        // ── Methods ──
        public void AddProperty(){} // RVA: 0x7FFAC2C70A40
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class SystemVersionPropertyBag : ContainerPropertyBag`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC99A6FD0
    }

    public class Vector2IntPropertyBag : ContainerPropertyBag`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC99A6030
    }

    public class Vector3IntPropertyBag : ContainerPropertyBag`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC99A6230
    }

}