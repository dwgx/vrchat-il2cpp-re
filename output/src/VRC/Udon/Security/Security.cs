// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Security
// Classes: 7
// Methods: 39

namespace VRC.Udon.Security
{
    public class AudioSourceMixerHolder : Object
    {
        public UnityEngine.Audio.AudioMixerGroup _worldGroup;

        // ── Methods ──
        public void get_WorldGroup(){} // RVA: 0x7FFE882571C0
        public void set_WorldGroup(){} // RVA: 0x7FFE88257200
        public void PlayClipAtPoint(){} // RVA: 0x7FFE882572D0 | overloaded x2
    }

    public class IUdonSignatureHolder
    {
        // ── Methods ──
        public void get_Signature(){} // RVA: 0x7FFE80E2E2E0
        public void set_Signature(){} // RVA: 0x7FFE80E460A0
        public void get_SignedData(){} // RVA: 0x7FFE80E2E2E0
        public void get_IsInternallyValidated(){} // RVA: 0x7FFE80E2F150
        public void EnsureGZipFormat(){} // RVA: 0x7FFE80E45FE0
    }

    public class IUdonSignatureVerifier
    {
        // ── Methods ──
        public void VerifySignature(){} // RVA: 0x7FFE80E2F3B0
    }

    public class Texture2DDefaultTextureHolder : Object
    {
        // ── Methods ──
        public void ResetTextures(){} // RVA: 0x7FFE88256420
        public void BlacklistDefaultTextures(){} // RVA: 0x7FFE88256F60
    }

    public class UdonSignatureHolderMarker : Attribute
    {
        public System.Type _type; // 0x10

        // ── Methods ──
        public void get_type(){} // RVA: 0x7FFE81116380
        public void .ctor(){} // RVA: 0x7FFE810FCE30
    }

    public class UnityEngineObjectSecurityBlacklist : Object
    {
        public System.Collections.Generic.HashSet`1<UnityEngine.Object> _objectBlacklist; // 0x10

        // ── Methods ──
        public void IsBlacklisted(){} // RVA: 0x7FFE88258A70 | overloaded x2
        public void IsBlacklistedGameObject(){} // RVA: 0x7FFE882578F0
        public void ApplyFilter(){} // RVA: 0x7FFE88258620 | overloaded x2
        public void ApplyLightCullingMaskFilter(){} // RVA: 0x7FFE882579A0
        public void get_LightReservedLayerMask(){} // RVA: 0x7FFE81549710
        public void set_LightReservedLayerMask(){} // RVA: 0x7FFE817E4800
        public void IsTypeSafe(){} // RVA: 0x7FFE882579B0
        public void Blacklist(){} // RVA: 0x7FFE88258450 | overloaded x2
        public void CleanBlacklist(){} // RVA: 0x7FFE88258D40
        public void IdentifyDontDestroyOnLoadHandle(){} // RVA: 0x7FFE88258EC0
        public void .ctor(){} // RVA: 0x7FFE88258FF0
    }

    public class UnityEngineObjectSecurityWhitelist : Object
    {
        public System.Collections.Generic.HashSet`1<UnityEngine.Object> _objectWhitelist; // 0x10

        // ── Methods ──
        public void ApplyFilter(){} // RVA: 0x7FFE88259A30 | overloaded x2
        public void ApplyLightCullingMaskFilter(){} // RVA: 0x7FFE882593C0
        public void get_LightReservedLayerMask(){} // RVA: 0x7FFE8151D690
        public void set_LightReservedLayerMask(){} // RVA: 0x7FFE8170B670
        public void IsTypeSafe(){} // RVA: 0x7FFE882593D0
        public void Whitelist(){} // RVA: 0x7FFE88259760 | overloaded x2
        public void IsWhitelisted(){} // RVA: 0x7FFE88259C00
        public void CleanWhitelist(){} // RVA: 0x7FFE88259D10
        public void .ctor(){} // RVA: 0x7FFE88259E90
    }

}