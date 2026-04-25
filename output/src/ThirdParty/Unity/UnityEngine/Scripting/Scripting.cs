// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Scripting
// Classes: 4
// Methods: 10

namespace ThirdParty.Unity.UnityEngine.Scripting
{
    public class AlwaysLinkAssemblyAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class PreserveAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class RequiredByNativeCodeAttribute : Attribute
    {
        public string Name; // 0x10
        public bool Optional; // 0x18
        public bool GenerateProxy; // 0x19

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x2
        public void set_Name(){} // RVA: 0x7FFAC2F22E30
        public void set_Optional(){} // RVA: 0x7FFAC2F3C4F0
        public void set_GenerateProxy(){} // RVA: 0x7FFAC3515120
    }

    public class UsedByNativeCodeAttribute : Attribute
    {
        public string Name; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x2
        public void set_Name(){} // RVA: 0x7FFAC2F22E30
    }

}