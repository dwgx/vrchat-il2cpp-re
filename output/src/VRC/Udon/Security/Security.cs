// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Security
// Classes: 7
// Methods: 39

namespace VRC.Udon.Security
{
    public class AudioSourceMixerHolder
    {
        // ── Methods ──
        public void get_WorldGroup(){} // RVA: 0x771A500
        public void set_WorldGroup(){} // RVA: 0x771A540
        public void PlayClipAtPoint(){} // RVA: 0x771A610 | overloaded x2
    }

    public class IUdonSignatureHolder
    {
        // ── Methods ──
        public void get_Signature(){} // RVA: 0xCD60
        public void set_Signature(){} // RVA: 0x24B10
        public void get_SignedData(){} // RVA: 0xCD60
        public void get_IsInternallyValidated(){} // RVA: 0xDBE0
        public void EnsureGZipFormat(){} // RVA: 0x24A50
    }

    public class IUdonSignatureVerifier
    {
        // ── Methods ──
        public void VerifySignature(){} // RVA: 0xDE40
    }

    public class Texture2DDefaultTextureHolder
    {
        // ── Methods ──
        public void ResetTextures(){} // RVA: 0x7719760
        public void BlacklistDefaultTextures(){} // RVA: 0x771A2A0
    }

    public class UdonSignatureHolderMarker
    {
        // ── Methods ──
        public void get_type(){} // RVA: 0x2F8380
        public void .ctor(){} // RVA: 0x2DEE30
    }

    public class UnityEngineObjectSecurityBlacklist
    {
        // ── Methods ──
        public void IsBlacklisted(){} // RVA: 0x771BDB0 | overloaded x2
        public void IsBlacklistedGameObject(){} // RVA: 0x771AC30
        public void ApplyFilter(){} // RVA: 0x771B960 | overloaded x2
        public void ApplyLightCullingMaskFilter(){} // RVA: 0x771ACE0
        public void get_LightReservedLayerMask(){} // RVA: 0x791DC0
        public void set_LightReservedLayerMask(){} // RVA: 0xA53440
        public void IsTypeSafe(){} // RVA: 0x771ACF0
        public void Blacklist(){} // RVA: 0x771B790 | overloaded x2
        public void CleanBlacklist(){} // RVA: 0x771C080
        public void IdentifyDontDestroyOnLoadHandle(){} // RVA: 0x771C200
        public void .ctor(){} // RVA: 0x771C330
    }

    public class UnityEngineObjectSecurityWhitelist
    {
        // ── Methods ──
        public void ApplyFilter(){} // RVA: 0x771CD70 | overloaded x2
        public void ApplyLightCullingMaskFilter(){} // RVA: 0x771C700
        public void get_LightReservedLayerMask(){} // RVA: 0x760030
        public void set_LightReservedLayerMask(){} // RVA: 0x99E0D0
        public void IsTypeSafe(){} // RVA: 0x771C710
        public void Whitelist(){} // RVA: 0x771CAA0 | overloaded x2
        public void IsWhitelisted(){} // RVA: 0x771CF40
        public void CleanWhitelist(){} // RVA: 0x771D050
        public void .ctor(){} // RVA: 0x771D1D0
    }

}