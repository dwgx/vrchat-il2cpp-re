// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Properties.Internal
// Classes: 20
// Methods: 57

namespace ThirdParty.Other.Unity.Properties.Internal
{
    public class BoundsIntPropertyBag : ContainerPropertyBag`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7D61C70
    }

    public class BoundsPropertyBag : ContainerPropertyBag`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7D61A00
    }

    public class ColorPropertyBag : ContainerPropertyBag`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7D60280
    }

    public class IAttributes
    {
        // ── Methods ──
        public void get_Attributes(){} // RVA: 0x87C0A0
        public void set_Attributes(){} // RVA: 0x894320
        public void AddAttribute(){} // RVA: 0x894320
        public void AddAttributes(){} // RVA: 0x894320
        public void CreateAttributesScope(){} // RVA: 0x87BF80
    }

    public class IPropertyBagRegister
    {
        // ── Methods ──
        public void Register(){} // RVA: 0x894290
    }

    public class PropertiesInitialization : Object
    {
        // ── Methods ──
        public void InitializeProperties(){} // RVA: 0x7D5EF50
    }

    public class PropertiesInitialization[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class PropertyBagStore : Object
    {
        public object s_PropertyBags;
        public object s_RegisteredTypes;
        public object s_PropertyBagProvider;

        // ── Methods ──
        public void get_ReflectedPropertyBagProvider(){} // RVA: 0x7D62610
        public void CreatePropertyBagProvider(){} // RVA: 0x7D62720
        public void AddPropertyBag(){} // RVA: 0x31A0F70
        public void GetPropertyBag(){} // RVA: 0x7D62800
        public void TryGetPropertyBagForValue(){} // RVA: 0x87D880
        public void .cctor(){} // RVA: 0x7D62D90
    }

    public class RectIntPropertyBag : ContainerPropertyBag`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7D61690
    }

    public class RectPropertyBag : ContainerPropertyBag`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7D612E0
    }

    public class ReflectedPropertyBagAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ReflectedPropertyBagProvider : Object
    {
        public object m_CreatePropertyMethod;
        public object m_CreatePropertyBagMethod;
        public object m_CreateIndexedCollectionPropertyBagMethod;
        public object m_CreateSetPropertyBagMethod;
        public object m_CreateKeyValueCollectionPropertyBagMethod;
        public object m_CreateKeyValuePairPropertyBagMethod;
        public object m_CreateArrayPropertyBagMethod;
        public object m_CreateListPropertyBagMethod;
        public object m_CreateHashSetPropertyBagMethod;
        public object m_CreateDictionaryPropertyBagMethod;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7D62FA0
        public void CreatePropertyBag(){} // RVA: 0x87C0A0
        public void CreateProperty(){} // RVA: 0x8943B0
        public void CreateIndexedCollectionPropertyBag(){} // RVA: 0x87C0A0
        public void CreateSetPropertyBag(){} // RVA: 0x87C0A0
        public void CreateKeyValueCollectionPropertyBag(){} // RVA: 0x87C0A0
        public void CreateKeyValuePairPropertyBag(){} // RVA: 0x87C0A0
        public void CreateArrayPropertyBag(){} // RVA: 0x87C0A0
        public void CreateListPropertyBag(){} // RVA: 0x87C0A0
        public void CreateHashSetPropertyBag(){} // RVA: 0x87C0A0
        public void CreateDictionaryPropertyBag(){} // RVA: 0x87C0A0
        public void GetPropertyMembers(){} // RVA: 0x7D63EB0
        public void IsValidMember(){} // RVA: 0x7D63F60
        public void IsValidPropertyType(){} // RVA: 0x7D640B0
    }

    public class ReflectedPropertyBag`1 : ContainerPropertyBag`1
    {
        // ── Methods ──
        public void AddProperty(){} // RVA: 0x894320
        public void .ctor(){} // RVA: 0x894290
    }

    public class ReflectionUtilities : Object
    {
        // ── Methods ──
        public void SanitizeMemberName(){} // RVA: 0x7D65160
    }

    public class SystemVersionPropertyBag : ContainerPropertyBag`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7D61E60
    }

    public class Vector2IntPropertyBag : ContainerPropertyBag`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7D60E40
    }

    public class Vector2PropertyBag : ContainerPropertyBag`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7D60630
    }

    public class Vector3IntPropertyBag : ContainerPropertyBag`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7D61030
    }

    public class Vector3PropertyBag : ContainerPropertyBag`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7D60820
    }

    public class Vector4PropertyBag : ContainerPropertyBag`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7D60AD0
    }

}