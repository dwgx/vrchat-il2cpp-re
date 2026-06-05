// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Security
// Classes: 7
// Methods: 39

namespace VRC.Udon.Security
{
    public class AudioSourceMixerHolder
    {
        // ── Methods ──
        public void get_WorldGroup(){} // RVA: 0x7FFAFA1CA500
        public void set_WorldGroup(){} // RVA: 0x7FFAFA1CA540
        public void PlayClipAtPoint(){} // RVA: 0x7FFAFA1CA610 | overloaded x2
    }

    public class IUdonSignatureHolder
    {
        // ── Methods ──
        public void get_Signature(){} // RVA: 0x7FFAF2ABCD60
        public void set_Signature(){} // RVA: 0x7FFAF2AD4B10
        public void get_SignedData(){} // RVA: 0x7FFAF2ABCD60
        public void get_IsInternallyValidated(){} // RVA: 0x7FFAF2ABDBE0
        public void EnsureGZipFormat(){} // RVA: 0x7FFAF2AD4A50
    }

    public class IUdonSignatureVerifier
    {
        // ── Methods ──
        public void VerifySignature(){} // RVA: 0x7FFAF2ABDE40
    }

    public class Texture2DDefaultTextureHolder
    {
        // ── Methods ──
        public void ResetTextures(){} // RVA: 0x7FFAFA1C9760
        public void BlacklistDefaultTextures(){} // RVA: 0x7FFAFA1CA2A0
    }

    public class UdonSignatureHolderMarker
    {
        // ── Methods ──
        public void get_type(){} // RVA: 0x7FFAF2DA8380
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
    }

    public class UnityEngineObjectSecurityBlacklist
    {
        // ── Methods ──
        public void IsBlacklisted(){} // RVA: 0x7FFAFA1CBDB0 | overloaded x2
        public void IsBlacklistedGameObject(){} // RVA: 0x7FFAFA1CAC30
        public void ApplyFilter(){} // RVA: 0x7FFAFA1CB960 | overloaded x2
        public void ApplyLightCullingMaskFilter(){} // RVA: 0x7FFAFA1CACE0
        public void get_LightReservedLayerMask(){} // RVA: 0x7FFAF3241DC0
        public void set_LightReservedLayerMask(){} // RVA: 0x7FFAF3503440
        public void IsTypeSafe(){} // RVA: 0x7FFAFA1CACF0
        public void Blacklist(){} // RVA: 0x7FFAFA1CB790 | overloaded x2
        public void CleanBlacklist(){} // RVA: 0x7FFAFA1CC080
        public void IdentifyDontDestroyOnLoadHandle(){} // RVA: 0x7FFAFA1CC200
        public void .ctor(){} // RVA: 0x7FFAFA1CC330
    }

    public class UnityEngineObjectSecurityWhitelist
    {
        // ── Methods ──
        public void ApplyFilter(){} // RVA: 0x7FFAFA1CCD70 | overloaded x2
        public void ApplyLightCullingMaskFilter(){} // RVA: 0x7FFAFA1CC700
        public void get_LightReservedLayerMask(){} // RVA: 0x7FFAF3210030
        public void set_LightReservedLayerMask(){} // RVA: 0x7FFAF344E0D0
        public void IsTypeSafe(){} // RVA: 0x7FFAFA1CC710
        public void Whitelist(){} // RVA: 0x7FFAFA1CCAA0 | overloaded x2
        public void IsWhitelisted(){} // RVA: 0x7FFAFA1CCF40
        public void CleanWhitelist(){} // RVA: 0x7FFAFA1CD050
        public void .ctor(){} // RVA: 0x7FFAFA1CD1D0
    }

}