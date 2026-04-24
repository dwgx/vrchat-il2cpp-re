// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Security
// Classes: 5
// Methods: 33

namespace VRC.Udon.Security
{
    public class IUdonSignatureHolder
    {
        public object Signature;
        public object SignedData;
        public object IsInternallyValidated;

        // ── Methods ──
        public void get_Signature(){} // RVA: 0x7FFD4E078E90
        public void set_Signature(){} // RVA: 0x7FFD4E090A40
        public void get_SignedData(){} // RVA: 0x7FFD4E078E90
        public void get_IsInternallyValidated(){} // RVA: 0x7FFD4E079D00
        public void EnsureGZipFormat(){} // RVA: 0x7FFD4E090980
    }

    public class IUdonSignatureVerifier
    {
        // ── Methods ──
        public void VerifySignature(){} // RVA: 0x7FFD4E079F60
    }

    public class UdonSignatureHolderMarker : Attribute
    {
        public object type;

        // ── Methods ──
        public void get_type(){} // RVA: 0x7FFD4E35C380
        public void .ctor(){} // RVA: 0x7FFD4E342E30
    }

    public class UnityEngineObjectSecurityBlacklist : Object
    {
        public URA.onsDepth<?> LightReservedLayerMask; // 0x10
        public URA.DateTime<?,bool> _safeTypeCache; // 0x18
        public dle<int> _dontDestroyOnLoadHandle; // 0x20
        public int <LightReservedLayerMask>k__BackingField; // 0x28

        // ── Methods ──
        public void IsBlacklisted(){} // RVA: 0x7FFD552C5F80 | overloaded x2
        public void IsBlacklistedGameObject(){} // RVA: 0x7FFD552C4E00
        public void ApplyFilter(){} // RVA: 0x7FFD552C5B30 | overloaded x2
        public void ApplyLightCullingMaskFilter(){} // RVA: 0x7FFD552C4EB0
        public void get_LightReservedLayerMask(){} // RVA: 0x7FFD4E70C4C0
        public void set_LightReservedLayerMask(){} // RVA: 0x7FFD4EABA6E0
        public void IsTypeSafe(){} // RVA: 0x7FFD552C4EC0
        public void Blacklist(){} // RVA: 0x7FFD552C5960 | overloaded x2
        public void CleanBlacklist(){} // RVA: 0x7FFD552C6250
        public void IdentifyDontDestroyOnLoadHandle(){} // RVA: 0x7FFD552C63D0
        public void .ctor(){} // RVA: 0x7FFD552C6500
    }

    public class UnityEngineObjectSecurityWhitelist : Object
    {
        public URA.onsDepth<?> LightReservedLayerMask; // 0x10
        public URA.DateTime<?,bool> _safeTypeCache; // 0x18
        public int <LightReservedLayerMask>k__BackingField; // 0x20

        // ── Methods ──
        public void ApplyFilter(){} // RVA: 0x7FFD552C6F40 | overloaded x2
        public void ApplyLightCullingMaskFilter(){} // RVA: 0x7FFD552C68D0
        public void get_LightReservedLayerMask(){} // RVA: 0x7FFD4E4FBBE0
        public void set_LightReservedLayerMask(){} // RVA: 0x7FFD4E9FB7A0
        public void IsTypeSafe(){} // RVA: 0x7FFD552C68E0
        public void Whitelist(){} // RVA: 0x7FFD552C6C70 | overloaded x2
        public void IsWhitelisted(){} // RVA: 0x7FFD552C7110
        public void CleanWhitelist(){} // RVA: 0x7FFD552C7220
        public void .ctor(){} // RVA: 0x7FFD552C73A0
    }

}