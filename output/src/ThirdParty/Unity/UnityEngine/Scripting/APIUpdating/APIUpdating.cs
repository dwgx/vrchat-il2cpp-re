// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Scripting.APIUpdating
// Classes: 2
// Methods: 3

namespace ThirdParty.Unity.UnityEngine.Scripting.APIUpdating
{
    public class MovedFromAttribute : Attribute
    {
        public UnityEngine.Scripting.APIUpdating.MovedFromAttributeData data; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC98E1460 | overloaded x2
    }

    public class MovedFromAttributeData : ValueType
    {
        public string className; // 0x10
        public string nameSpace; // 0x18
        public string assembly; // 0x20
        public bool classHasChanged; // 0x28
        public bool nameSpaceHasChanged; // 0x29
        public bool assemblyHasChanged; // 0x2A
        public bool autoUdpateAPI; // 0x2B

        // ── Methods ──
        public void Set(){} // RVA: 0x7FFAC98E12F0
    }

}