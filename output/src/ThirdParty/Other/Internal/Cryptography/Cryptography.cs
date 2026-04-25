// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Internal.Cryptography
// Classes: 2
// Methods: 12

namespace ThirdParty.Other.Internal.Cryptography
{
    public class Helpers : Object
    {
        // ── Methods ──
        public void CloneByteArray(){} // RVA: 0x7FFAC83BAEC0
        public void GenerateRandom(){} // RVA: 0x7FFAC83BAF40
        public void WriteInt(){} // RVA: 0x7FFAC83BB030
        public void ToHexArrayUpper(){} // RVA: 0x7FFAC83BB0A0
        public void ToHexStringUpper(){} // RVA: 0x7FFAC83BB1C0
        public void NibbleToHex(){} // RVA: 0x7FFAC83BB1E0
    }

    public class OidLookup : Object
    {
        public System.Collections.Concurrent.ConcurrentDictionary`2<string,string> s_lateBoundOidToFriendlyName;
        public System.Collections.Concurrent.ConcurrentDictionary`2<string,string> s_lateBoundFriendlyNameToOid; // 0x8
        public System.Collections.Generic.Dictionary`2<string,string> s_friendlyNameToOid; // 0x10
        public System.Collections.Generic.Dictionary`2<string,string> s_oidToFriendlyName; // 0x18
        public System.Collections.Generic.Dictionary`2<string,string> s_compatOids; // 0x20

        // ── Methods ──
        public void ToFriendlyName(){} // RVA: 0x7FFAC93807A0
        public void ToOid(){} // RVA: 0x7FFAC9380A80
        public void ShouldUseCache(){} // RVA: 0x7FFAC3006850
        public void NativeOidToFriendlyName(){} // RVA: 0x7FFAC9380D30
        public void NativeFriendlyNameToOid(){} // RVA: 0x7FFAC93812D0
        public void .cctor(){} // RVA: 0x7FFAC9381870
    }

}