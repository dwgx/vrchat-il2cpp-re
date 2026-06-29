// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Security
// Classes: 7
// Methods: 33

namespace VRC.Udon.Security
{
    public class AudioSourceMixerHolder : Object
    {
        // ── Methods ──
        public void get_WorldGroup(){} // RVA: 0x7AF4F9990
        public void set_WorldGroup(){} // RVA: 0x7AF4F99D0
        public void PlayClipAtPoint(){} // RVA: 0x7AF4F9AA0
    }

    public class IUdonSignatureHolder
    {
        // ── Methods ──
        public void get_Signature(){} // RVA: 0x7A7E00680
        public void set_Signature(){} // RVA: 0x7A7E18800
        public void get_SignedData(){} // RVA: 0x7A7E00680
        public void get_IsInternallyValidated(){} // RVA: 0x7A7E01900
        public void EnsureGZipFormat(){} // RVA: 0x7A7E18770
    }

    public class IUdonSignatureVerifier
    {
        // ── Methods ──
        public void VerifySignature(){} // RVA: 0x7A7E019D0
    }

    public class Texture2DDefaultTextureHolder : Object
    {
        // ── Methods ──
        public void ResetTextures(){} // RVA: 0x7AF4F8C00
        public void BlacklistDefaultTextures(){} // RVA: 0x7AF4F9730
    }

    public class UdonSignatureHolderMarker : Attribute
    {
        // ── Methods ──
        public void get_type(){} // RVA: 0x7A80F2570
        public void .ctor(){} // RVA: 0x7A80D8E20
    }

    public class UnityEngineObjectSecurityBlacklist : Object
    {
        // ── Methods ──
        public void IsBlacklisted(){} // RVA: 0x7AF4FB290
        public void IsBlacklistedGameObject(){} // RVA: 0x7AF4FA0C0
        public void ApplyFilter(){} // RVA: 0x7AF4FAE10
        public void ApplyLightCullingMaskFilter(){} // RVA: 0x7AF4FA170
        public void get_LightReservedLayerMask(){} // RVA: 0x7A854FDE0
        public void set_LightReservedLayerMask(){} // RVA: 0x7A8810F60
        public void IsTypeSafe(){} // RVA: 0x7AF4FA180
        public void Blacklist(){} // RVA: 0x7AF4FAC30
        public void CleanBlacklist(){} // RVA: 0x7AF4FB560
        public void IdentifyDontDestroyOnLoadHandle(){} // RVA: 0x7AF4FB6E0
        public void .ctor(){} // RVA: 0x7AF4FB810
    }

    public class UnityEngineObjectSecurityWhitelist : Object
    {
        // ── Methods ──
        public void ApplyFilter(){} // RVA: 0x7AF4FC270
        public void ApplyLightCullingMaskFilter(){} // RVA: 0x7AF4FBBE0
        public void get_LightReservedLayerMask(){} // RVA: 0x7A851DB90
        public void set_LightReservedLayerMask(){} // RVA: 0x7A8738180
        public void IsTypeSafe(){} // RVA: 0x7AF4FBBF0
        public void Whitelist(){} // RVA: 0x7AF4FBF90
        public void IsWhitelisted(){} // RVA: 0x7AF4FC440
        public void CleanWhitelist(){} // RVA: 0x7AF4FC550
        public void .ctor(){} // RVA: 0x7AF4FC6D0
    }

}