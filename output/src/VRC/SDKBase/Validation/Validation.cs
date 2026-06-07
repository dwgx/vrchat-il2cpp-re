// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDKBase.Validation
// Classes: 3
// Methods: 29

namespace VRC.SDKBase.Validation
{
    public class TypeUtils
    {
        // ── Methods ──
        public void GetTypeFromName(){} // RVA: 0x9AA3C80
        public void FindDerivedTypes(){} // RVA: 0x9AA41B0 | overloaded x2
        public void FindAssemblyAttributes(){} // RVA: 0xCE50 | overloaded x2
        public void .cctor(){} // RVA: 0x9AA42E0
    }

    public class VRCSdkWhitelistAttribute
    {
        // ── Methods ──
        public void get_name(){} // RVA: 0x32A5C0
        public void .ctor(){} // RVA: 0x2E00C0
    }

    public class ValidationUtils
    {
        // ── Methods ──
        public void RemoveIllegalComponents(){} // RVA: 0x9AA45A0 | overloaded x2
        public void FindIllegalComponents(){} // RVA: 0x9AA4BD0 | overloaded x2
        public void IsIllegalComponent(){} // RVA: 0x9AA4F20
        public void IsEditorOnly(){} // RVA: 0x9AA5090
        public void GetComponentsInChildrenExcludingEditorOnly(){} // RVA: 0x9AA51E0 | overloaded x2
        public void GetCachedWhitelistedTypes(){} // RVA: 0x9AA53C0
        public void ClearCachedWhitelistedTypes(){} // RVA: 0x9AA5460
        public void WhitelistedTypes(){} // RVA: 0x9AA5920 | overloaded x2
        public void AddDerivedClasses(){} // RVA: 0x9AA5B00
        public void RemoveDependencies(){} // RVA: 0x9AA5D90
        public void RemoveComponent(){} // RVA: 0x9AA6680
        public void RemoveComponentsOfType(){} // RVA: 0x2A400
        public void FindIllegalShaders(){} // RVA: 0x9AA6890
        public void FindIllegalShadersEnumerator(){} // RVA: 0x9AA6BD0
        public void ValidateContent(){} // RVA: 0x9AA6D40
        public void .cctor(){} // RVA: 0x9AA7020
        public void <RemoveDependencies>g__NeedsDeletion|17_0(){} // RVA: 0x9AA72E0
    }

}