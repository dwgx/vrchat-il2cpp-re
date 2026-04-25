// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Microsoft.Extensions.Primitives
// Classes: 3
// Methods: 6

namespace ThirdParty.DotNet.Microsoft.Extensions.Primitives
{
    public class ChangeToken : Object
    {
        // ── Methods ──
        public void OnChange(){} // RVA: 0x7FFAC2E8DC40
    }

    public class IChangeToken
    {
        public object HasChanged;
        public object ActiveChangeCallbacks;

        // ── Methods ──
        public void get_HasChanged(){} // RVA: 0x7FFAC2C59D00
        public void get_ActiveChangeCallbacks(){} // RVA: 0x7FFAC2C59D00
        public void RegisterChangeCallback(){} // RVA: 0x7FFAC2C6A6F0
    }

    public class ThrowHelper : Object
    {
        // ── Methods ──
        public void ThrowArgumentNullException(){} // RVA: 0x7FFAC834DEB0
        public void GetArgumentName(){} // RVA: 0x7FFAC834DF10
    }

}