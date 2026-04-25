// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net
// Classes: 1
// Methods: 3

namespace ThirdParty.DotNet.System.Net
{
    public class KnownHttpVerb : Object
    {
        public string Name; // 0x10
        public bool RequireContentBody; // 0x18
        public bool ContentBodyNotAllowed; // 0x19
        public bool ConnectRequest; // 0x1A
        public bool ExpectNoContentResponse; // 0x1B
        public System.Collections.Specialized.ListDictionary NamedHeaders;
        public System.Net.KnownHttpVerb Get; // 0x8
        public System.Net.KnownHttpVerb Connect; // 0x10
        public System.Net.KnownHttpVerb Head; // 0x18
        public System.Net.KnownHttpVerb Put; // 0x20
        public System.Net.KnownHttpVerb Post; // 0x28
        public System.Net.KnownHttpVerb MkCol; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC92B6EE0
        public void .cctor(){} // RVA: 0x7FFAC92B6F50
        public void Parse(){} // RVA: 0x7FFAC92B7720
    }

}