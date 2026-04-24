// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Security
// Classes: 5
// Methods: 33

namespace VRC.Udon.Security
{
    public class IUdonSignatureHolder
    {
        // ── Original Methods ──
        public void get_Signature(){} // RVA: 0x7ffaa86491d0
        public void set_Signature(){} // RVA: 0x7ffaa8660d80
        public void get_SignedData(){} // RVA: 0x7ffaa86491d0
        public void get_IsInternallyValidated(){} // RVA: 0x7ffaa864a040
        public void EnsureGZipFormat(){} // RVA: 0x7ffaa8660cc0
    }

    public class IUdonSignatureVerifier
    {
        // ── Original Methods ──
        public void VerifySignature(){} // RVA: 0x7ffaa864a2a0
    }

    public class UdonSignatureHolderMarker : Attribute
    {
        // ── Original Methods ──
        public void get_type(){} // RVA: 0x7ffaa894d380
        public void .ctor(){} // RVA: 0x7ffaa8933e30
    }

    public class UnityEngineObjectSecurityBlacklist : Object
    {
        public object _dontDestroyOnLoadHandle; // 0x319139E0
        public object h$00; // 0x302FFB10

        // ── Original Methods ──
        public void IsBlacklisted(){} // RVA: 0x7ffaaf8c89a0
        public void IsBlacklistedGameObject(){} // RVA: 0x7ffaaf8c7820
        public void ApplyFilter(){} // RVA: 0x7ffaaf8c8550
        public void ApplyLightCullingMaskFilter(){} // RVA: 0x7ffaaf8c78d0
        public void get_LightReservedLayerMask(){} // RVA: 0x7ffaa8d14570
        public void set_LightReservedLayerMask(){} // RVA: 0x7ffaa90c0cd0
        public void IsTypeSafe(){} // RVA: 0x7ffaaf8c78e0
        public void Blacklist(){} // RVA: 0x7ffaaf8c8380
        public void Blacklist(){} // RVA: 0x7ffaaf8c8380
        public void ApplyFilter(){} // RVA: 0x7ffaaf8c8550
        public void IsBlacklisted(){} // RVA: 0x7ffaaf8c89a0
        public void CleanBlacklist(){} // RVA: 0x7ffaaf8c8c70
        public void IdentifyDontDestroyOnLoadHandle(){} // RVA: 0x7ffaaf8c8df0
        public void .ctor(){} // RVA: 0x7ffaaf8c8f20
    }

    public class UnityEngineObjectSecurityWhitelist : Object
    {
        public object _lightReservedLayerMask; // 0x31913C00, was: <LightReservedLayerMask>k__Bac
        public object LightReservedLayerMask; // 0x17000003

        // ── Original Methods ──
        public void ApplyFilter(){} // RVA: 0x7ffaaf8c9960
        public void ApplyLightCullingMaskFilter(){} // RVA: 0x7ffaaf8c92f0
        public void get_LightReservedLayerMask(){} // RVA: 0x7ffaa8aeced0
        public void set_LightReservedLayerMask(){} // RVA: 0x7ffaa900aa90
        public void IsTypeSafe(){} // RVA: 0x7ffaaf8c9300
        public void Whitelist(){} // RVA: 0x7ffaaf8c9690
        public void Whitelist(){} // RVA: 0x7ffaaf8c9690
        public void ApplyFilter(){} // RVA: 0x7ffaaf8c9960
        public void IsWhitelisted(){} // RVA: 0x7ffaaf8c9b30
        public void CleanWhitelist(){} // RVA: 0x7ffaaf8c9c40
        public void .ctor(){} // RVA: 0x7ffaaf8c9dc0
    }

}