// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Security
// Classes: 7
// Methods: 33

namespace VRC.Udon.Security
{
    public class AudioSourceMixerHolder : Object
    {
        public object _worldGroup;

        // ── Methods ──
        public void get_WorldGroup(){} // RVA: 0x83589D0
        public void set_WorldGroup(){} // RVA: 0x8358A10
        public void PlayClipAtPoint(){} // RVA: 0x8358AE0
    }

    public class IUdonSignatureHolder
    {
        // ── Methods ──
        public void get_Signature(){} // RVA: 0x87C0A0
        public void set_Signature(){} // RVA: 0x894320
        public void get_SignedData(){} // RVA: 0x87C0A0
        public void get_IsInternallyValidated(){} // RVA: 0x87D280
        public void EnsureGZipFormat(){} // RVA: 0x894290
    }

    public class IUdonSignatureVerifier
    {
        // ── Methods ──
        public void VerifySignature(){} // RVA: 0x87D350
    }

    public class Texture2DDefaultTextureHolder : Object
    {
        public object BlackTexture;
        public object GrayTexture;
        public object LinearGrayTexture;
        public object NormalTexture;
        public object RedTexture;
        public object WhiteTexture;

        // ── Methods ──
        public void ResetTextures(){} // RVA: 0x83580B0
        public void BlacklistDefaultTextures(){} // RVA: 0x83588D0
    }

    public class UdonSignatureHolderMarker : Attribute
    {
        public object _type;

        // ── Methods ──
        public void get_type(){} // RVA: 0xB5DBF0
        public void .ctor(){} // RVA: 0xB44D60
    }

    public class UnityEngineObjectSecurityBlacklist : Object
    {
        public object _objectBlacklist;
        public object _safeTypeCache;
        public object _dontDestroyOnLoadHandle;
        public object _lightReservedLayerMask;

        // ── Methods ──
        public void IsBlacklisted(){} // RVA: 0x835A170
        public void IsBlacklistedGameObject(){} // RVA: 0x8358FB0
        public void ApplyFilter(){} // RVA: 0x8359CF0
        public void ApplyLightCullingMaskFilter(){} // RVA: 0x8359060
        public void get_LightReservedLayerMask(){} // RVA: 0x1065D50
        public void set_LightReservedLayerMask(){} // RVA: 0x13233D0
        public void IsTypeSafe(){} // RVA: 0x8359070
        public void Blacklist(){} // RVA: 0x8359B10
        public void CleanBlacklist(){} // RVA: 0x835A440
        public void IdentifyDontDestroyOnLoadHandle(){} // RVA: 0x835A5C0
        public void .ctor(){} // RVA: 0x835A6F0
    }

    public class UnityEngineObjectSecurityWhitelist : Object
    {
        public object _objectWhitelist;
        public object _safeTypeCache;
        public object _lightReservedLayerMask;

        // ── Methods ──
        public void ApplyFilter(){} // RVA: 0x835B140
        public void ApplyLightCullingMaskFilter(){} // RVA: 0x835AAC0
        public void get_LightReservedLayerMask(){} // RVA: 0xFEAE90
        public void set_LightReservedLayerMask(){} // RVA: 0x1269760
        public void IsTypeSafe(){} // RVA: 0x835AAD0
        public void Whitelist(){} // RVA: 0x835AE60
        public void IsWhitelisted(){} // RVA: 0x835B310
        public void CleanWhitelist(){} // RVA: 0x835B420
        public void .ctor(){} // RVA: 0x835B5A0
    }

}