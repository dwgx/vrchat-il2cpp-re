// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDKBase.Validation
// Classes: 3
// Methods: 29

namespace VRC.SDKBase.Validation
{
    public class TypeUtils : Object
    {
        // ── Original Methods ──
        public void FindDerivedTypes(){} // RVA: 0x7ffab1a9c540
        public void FindDerivedTypes(){} // RVA: 0x7ffab1a9c540
        public void FindAssemblyAttributes(){} // RVA: 0x7ffaa86492c0
        public void FindAssemblyAttributes(){} // RVA: 0x7ffaa86492c0
        public void .cctor(){} // RVA: 0x7ffab1a9c670
        // ── Binary Analysis Named ──
        public void GetTypeFromName(){} // RVA: 0x7ffab1a9c010
    }

    public class VRCSdkWhitelistAttribute : Attribute
    {
        // ── Original Methods ──
        public void get_name(){} // RVA: 0x7ffaa897f5c0
        public void .ctor(){} // RVA: 0x7ffaa89350c0
    }

    public class ValidationUtils : Object
    {
        public object _whitelistCache; // 0x3194A6B0

        // ── Original Methods ──
        public void RemoveIllegalComponents(){} // RVA: 0x7ffab1a9c930
        public void RemoveIllegalComponents(){} // RVA: 0x7ffab1a9c930
        public void FindIllegalComponents(){} // RVA: 0x7ffab1a9cf60
        public void FindIllegalComponents(){} // RVA: 0x7ffab1a9cf60
        public void IsIllegalComponent(){} // RVA: 0x7ffab1a9d2b0
        public void IsEditorOnly(){} // RVA: 0x7ffab1a9d420
        public void ClearCachedWhitelistedTypes(){} // RVA: 0x7ffab1a9d7f0
        public void WhitelistedTypes(){} // RVA: 0x7ffab1a9dcb0
        public void WhitelistedTypes(){} // RVA: 0x7ffab1a9dcb0
        public void AddDerivedClasses(){} // RVA: 0x7ffab1a9de90
        public void RemoveDependencies(){} // RVA: 0x7ffab1a9e120
        public void RemoveComponent(){} // RVA: 0x7ffab1a9ea10
        public void RemoveComponentsOfType(){} // RVA: 0x7ffaa8666620
        public void FindIllegalShaders(){} // RVA: 0x7ffab1a9ec20
        public void FindIllegalShadersEnumerator(){} // RVA: 0x7ffab1a9ef60
        public void ValidateContent(){} // RVA: 0x7ffab1a9f0d0
        public void .cctor(){} // RVA: 0x7ffab1a9f3b0
        public void <RemoveDependencies>g__NeedsDeletion|17_0(){} // RVA: 0x7ffab1a9f670
        // ── Binary Analysis Named ──
        public void GetComponentsInChildrenExcludingEditorOnly(){} // RVA: 0x7ffab1a9d570
        public void GetComponentsInChildrenExcludingEditorOnly(){} // RVA: 0x7ffab1a9d570
        public void GetCachedWhitelistedTypes(){} // RVA: 0x7ffab1a9d750
    }

}