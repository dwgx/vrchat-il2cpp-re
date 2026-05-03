// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Scripting
// Classes: 4
// Methods: 10

namespace ThirdParty.Unity.UnityEngine.Scripting
{
    public class AlwaysLinkAssemblyAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class PreserveAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class RequiredByNativeCodeAttribute : Attribute
    {
        public string _name; // 0x10
        public bool _optional; // 0x18
        public bool _generateProxy; // 0x19

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x2
        public void set_Name(){} // RVA: 0x7FFE810FCE30
        public void set_Optional(){} // RVA: 0x7FFE811164F0
        public void set_GenerateProxy(){} // RVA: 0x7FFE81CD0510
    }

    public class UsedByNativeCodeAttribute : Attribute
    {
        public string _name; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x2
        public void set_Name(){} // RVA: 0x7FFE810FCE30
    }

}