// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Data
// Classes: 1
// Methods: 8

namespace ThirdParty.DotNet.System.Data
{
    public class TypeLimiter : Object
    {
        public Scope IsTypeLimitingDisabled; // 0xFFFF
        public Scope m_instanceScope; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void get_IsTypeLimitingDisabled(){} // RVA: 0x7FFAC8E7EE00
        public void Capture(){} // RVA: 0x7FFAC8E7EE70
        public void EnsureTypeIsAllowed(){} // RVA: 0x7FFAC8E7EF70
        public void EnterRestrictedScope(){} // RVA: 0x7FFAC8E7F2D0 | overloaded x2
        public void GetPreviouslyDeclaredDataTypes(){} // RVA: 0x7FFAC8E7F5A0 | overloaded x2
    }

}