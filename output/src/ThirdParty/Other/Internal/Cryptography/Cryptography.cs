// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Internal.Cryptography
// Classes: 2
// Methods: 12

namespace ThirdParty.Other.Internal.Cryptography
{
    public class Helpers : Object
    {
        // ── Methods ──
        public void CloneByteArray(){} // RVA: 0x669C2E0
        public void GenerateRandom(){} // RVA: 0x669C360
        public void WriteInt(){} // RVA: 0x669C450
        public void ToHexArrayUpper(){} // RVA: 0x669C4C0
        public void ToHexStringUpper(){} // RVA: 0x669C5B0
        public void NibbleToHex(){} // RVA: 0x669C5D0
    }

    public class OidLookup : Object
    {
        public object s_lateBoundOidToFriendlyName;
        public object s_lateBoundFriendlyNameToOid;
        public object s_friendlyNameToOid;
        public object s_oidToFriendlyName;
        public object s_compatOids;

        // ── Methods ──
        public void ToFriendlyName(){} // RVA: 0x7649140
        public void ToOid(){} // RVA: 0x7649420
        public void ShouldUseCache(){} // RVA: 0xC2E4C0
        public void NativeOidToFriendlyName(){} // RVA: 0x76496D0
        public void NativeFriendlyNameToOid(){} // RVA: 0x7649C70
        public void .cctor(){} // RVA: 0x764A210
    }

}