// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDKBase.Validation
// Classes: 3
// Methods: 29

namespace VRC.SDKBase.Validation
{
    public class TypeUtils : Object
    {
        // ── Methods ──
        public void GetTypeFromName(){} // RVA: 0x7FFE8A4E60D0
        public void FindDerivedTypes(){} // RVA: 0x7FFE8A4E6610 | overloaded x2
        public void FindAssemblyAttributes(){} // RVA: 0x7FFE80E2E3D0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE8A4E6740
    }

    public class VRCSdkWhitelistAttribute : Attribute
    {
        public 0x666E26CC _name; // 0x10

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFE811485C0
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
    }

    public class ValidationUtils : Object
    {
        // ── Methods ──
        public void RemoveIllegalComponents(){} // RVA: 0x7FFE8A4E6A00 | overloaded x2
        public void FindIllegalComponents(){} // RVA: 0x7FFE8A4E7030 | overloaded x2
        public void IsIllegalComponent(){} // RVA: 0x7FFE8A4E7380
        public void IsEditorOnly(){} // RVA: 0x7FFE8A4E74F0
        public void GetComponentsInChildrenExcludingEditorOnly(){} // RVA: 0x7FFE8A4E7640 | overloaded x2
        public void GetCachedWhitelistedTypes(){} // RVA: 0x7FFE8A4E7820
        public void ClearCachedWhitelistedTypes(){} // RVA: 0x7FFE8A4E78C0
        public void WhitelistedTypes(){} // RVA: 0x7FFE8A4E7D80 | overloaded x2
        public void AddDerivedClasses(){} // RVA: 0x7FFE8A4E7F60
        public void RemoveDependencies(){} // RVA: 0x7FFE8A4E81F0
        public void RemoveComponent(){} // RVA: 0x7FFE8A4E8AE0
        public void RemoveComponentsOfType(){} // RVA: 0x7FFE80E4B9E0
        public void FindIllegalShaders(){} // RVA: 0x7FFE8A4E8CF0
        public void FindIllegalShadersEnumerator(){} // RVA: 0x7FFE8A4E9030
        public void ValidateContent(){} // RVA: 0x7FFE8A4E91A0
        public void .cctor(){} // RVA: 0x7FFE8A4E9480
        public void <RemoveDependencies>g__NeedsDeletion|17_0(){} // RVA: 0x7FFE8A4E9740
    }

}