// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDKBase.Validation
// Classes: 3
// Methods: 29

namespace VRC.SDKBase.Validation
{
    public class TypeUtils : Object
    {
        public System.Collections.Generic.Dictionary`2<string,System.Type> _typeCache;

        // ── Methods ──
        public void GetTypeFromName(){} // RVA: 0x7FFACC080100
        public void FindDerivedTypes(){} // RVA: 0x7FFACC080630 | overloaded x2
        public void FindAssemblyAttributes(){} // RVA: 0x7FFAC2C58F80 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFACC080760
    }

    public class VRCSdkWhitelistAttribute : Attribute
    {
        public 0x6B2E6C58 name; // 0x10

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFAC2F6E5C0
        public void .ctor(){} // RVA: 0x7FFAC2F240C0
    }

    public class ValidationUtils : Object
    {
        public System.Collections.Generic.List`1<UnityEngine.Component> _componentCache;
        public string EDITOR_ONLY_TAG;
        public System.Collections.Generic.Dictionary`2<string,System.Collections.Generic.HashSet`1<System.Type>> _whitelistCache; // 0x8
        public System.Collections.Generic.Dictionary`2<System.Type,System.Collections.Immutable.ImmutableArray`1<UnityEngine.RequireComponent>> _requireComponentsCache; // 0x10

        // ── Methods ──
        public void RemoveIllegalComponents(){} // RVA: 0x7FFACC080A20 | overloaded x2
        public void FindIllegalComponents(){} // RVA: 0x7FFACC081050 | overloaded x2
        public void IsIllegalComponent(){} // RVA: 0x7FFACC0813A0
        public void IsEditorOnly(){} // RVA: 0x7FFACC081510
        public void GetComponentsInChildrenExcludingEditorOnly(){} // RVA: 0x7FFACC081660 | overloaded x2
        public void GetCachedWhitelistedTypes(){} // RVA: 0x7FFACC081840
        public void ClearCachedWhitelistedTypes(){} // RVA: 0x7FFACC0818E0
        public void WhitelistedTypes(){} // RVA: 0x7FFACC081DA0 | overloaded x2
        public void AddDerivedClasses(){} // RVA: 0x7FFACC081F80
        public void RemoveDependencies(){} // RVA: 0x7FFACC082210
        public void RemoveComponent(){} // RVA: 0x7FFACC082B00
        public void RemoveComponentsOfType(){} // RVA: 0x7FFAC2C762E0
        public void FindIllegalShaders(){} // RVA: 0x7FFACC082D10
        public void FindIllegalShadersEnumerator(){} // RVA: 0x7FFACC083050
        public void ValidateContent(){} // RVA: 0x7FFACC0831C0
        public void .cctor(){} // RVA: 0x7FFACC0834A0
        public void <RemoveDependencies>g__NeedsDeletion|17_0(){} // RVA: 0x7FFACC083760
    }

}