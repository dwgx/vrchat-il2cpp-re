// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDKBase.Validation
// Classes: 4
// Methods: 38

namespace VRC.SDKBase.Validation
{
    public class TypeUtils : Object
    {
        public object _typeCache;

        // ── Methods ──
        public void GetTypeFromName(){} // RVA: 0xA752FA0
        public void FindDerivedTypes(){} // RVA: 0xA7534C0
        public void FindAssemblyAttributes(){} // RVA: 0x2A9E550
        public void .cctor(){} // RVA: 0xA7535F0
    }

    public class VRCSdkWhitelistAttribute : Attribute
    {
        public object _name;

        // ── Methods ──
        public void get_name(){} // RVA: 0xB8F8F0
        public void .ctor(){} // RVA: 0xB460A0
    }

    public class VRCSdkWhitelistAttribute[] : Array
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

    public class ValidationUtils : Object
    {
        public object _componentCache;
        public object EDITOR_ONLY_TAG;
        public object _whitelistCache;
        public object _requireComponentsCache;

        // ── Methods ──
        public void RemoveComponentsOfType(){} // RVA: 0x2B08350
        public void RemoveIllegalComponents(){} // RVA: 0xA753890
        public void FindIllegalComponents(){} // RVA: 0xA753ED0
        public void IsIllegalComponent(){} // RVA: 0xA754220
        public void IsEditorOnly(){} // RVA: 0xA754390
        public void GetComponentsInChildrenExcludingEditorOnly(){} // RVA: 0xA754510
        public void GetCachedWhitelistedTypes(){} // RVA: 0xA754700
        public void ClearCachedWhitelistedTypes(){} // RVA: 0xA7547A0
        public void WhitelistedTypes(){} // RVA: 0xA754C60
        public void AddDerivedClasses(){} // RVA: 0xA754E40
        public void RemoveDependencies(){} // RVA: 0xA7550D0
        public void RemoveComponent(){} // RVA: 0xA7558E0
        public void FindIllegalShaders(){} // RVA: 0xA755AB0
        public void FindIllegalShadersEnumerator(){} // RVA: 0xA755DF0
        public void ValidateContent(){} // RVA: 0xA755F60
        public void .cctor(){} // RVA: 0xA756220
        public void <RemoveDependencies>g__NeedsDeletion|17_0(){} // RVA: 0xA7564E0
    }

}