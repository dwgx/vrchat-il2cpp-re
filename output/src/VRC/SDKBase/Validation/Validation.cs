// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDKBase.Validation
// Classes: 4
// Methods: 38

namespace VRC.SDKBase.Validation
{
    public class TypeUtils : Object
    {
        // ── Methods ──
        public void GetTypeFromName(){} // RVA: 0x7B18E4AA0
        public void FindDerivedTypes(){} // RVA: 0x7B18E4FD0
        public void FindAssemblyAttributes(){} // RVA: 0x7AA62F370
        public void .cctor(){} // RVA: 0x7B18E5100
    }

    public class VRCSdkWhitelistAttribute : Attribute
    {
        // ── Methods ──
        public void get_name(){} // RVA: 0x7A8124910
        public void .ctor(){} // RVA: 0x7A80DA0C0
    }

    public class VRCSdkWhitelistAttribute[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class ValidationUtils : Object
    {
        // ── Methods ──
        public void RemoveIllegalComponents(){} // RVA: 0x7B18E53C0
        public void FindIllegalComponents(){} // RVA: 0x7B18E5A00
        public void IsIllegalComponent(){} // RVA: 0x7B18E5D50
        public void IsEditorOnly(){} // RVA: 0x7B18E5EC0
        public void GetComponentsInChildrenExcludingEditorOnly(){} // RVA: 0x7B18E6020
        public void GetCachedWhitelistedTypes(){} // RVA: 0x7B18E6210
        public void ClearCachedWhitelistedTypes(){} // RVA: 0x7B18E62B0
        public void WhitelistedTypes(){} // RVA: 0x7B18E6780
        public void AddDerivedClasses(){} // RVA: 0x7B18E6960
        public void RemoveDependencies(){} // RVA: 0x7B18E6C10
        public void RemoveComponent(){} // RVA: 0x7B18E74C0
        public void RemoveComponentsOfType(){} // RVA: 0x7A9F2EF40
        public void FindIllegalShaders(){} // RVA: 0x7B18E76D0
        public void FindIllegalShadersEnumerator(){} // RVA: 0x7B18E7A10
        public void ValidateContent(){} // RVA: 0x7B18E7B80
        public void .cctor(){} // RVA: 0x7B18E7E40
        public void <RemoveDependencies>g__NeedsDeletion|17_0(){} // RVA: 0x7B18E8100
    }

}