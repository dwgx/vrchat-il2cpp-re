// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Security
// Classes: 7
// Methods: 39

namespace VRC.Udon.Security
{
    public class AudioSourceMixerHolder : Object
    {
        public UnityEngine.Audio.AudioMixerGroup WorldGroup;

        // ── Methods ──
        public void get_WorldGroup(){} // RVA: 0x7FFAC9EA46D0
        public void set_WorldGroup(){} // RVA: 0x7FFAC9EA4710
        public void PlayClipAtPoint(){} // RVA: 0x7FFAC9EA47E0 | overloaded x2
    }

    public class IUdonSignatureHolder
    {
        public object Signature;
        public object SignedData;
        public object IsInternallyValidated;

        // ── Methods ──
        public void get_Signature(){} // RVA: 0x7FFAC2C58E90
        public void set_Signature(){} // RVA: 0x7FFAC2C70A40
        public void get_SignedData(){} // RVA: 0x7FFAC2C58E90
        public void get_IsInternallyValidated(){} // RVA: 0x7FFAC2C59D00
        public void EnsureGZipFormat(){} // RVA: 0x7FFAC2C70980
    }

    public class IUdonSignatureVerifier
    {
        // ── Methods ──
        public void VerifySignature(){} // RVA: 0x7FFAC2C59F60
    }

    public class Texture2DDefaultTextureHolder : Object
    {
        public UnityEngine.Texture2D BlackTexture;
        public UnityEngine.Texture2D GrayTexture; // 0x8
        public UnityEngine.Texture2D LinearGrayTexture; // 0x10
        public UnityEngine.Texture2D NormalTexture; // 0x18
        public UnityEngine.Texture2D RedTexture; // 0x20
        public UnityEngine.Texture2D WhiteTexture; // 0x28

        // ── Methods ──
        public void ResetTextures(){} // RVA: 0x7FFAC9EA3960
        public void BlacklistDefaultTextures(){} // RVA: 0x7FFAC9EA44A0
    }

    public class UdonSignatureHolderMarker : Attribute
    {
        public System.Type type; // 0x10

        // ── Methods ──
        public void get_type(){} // RVA: 0x7FFAC2F3C380
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
    }

    public class UnityEngineObjectSecurityBlacklist : Object
    {
        public System.Collections.Generic.HashSet`1<UnityEngine.Object> LightReservedLayerMask; // 0x10
        public System.Collections.Generic.Dictionary`2<System.Type,bool> _safeTypeCache; // 0x18
        public System.Lazy`1<int> _dontDestroyOnLoadHandle; // 0x20
        public int <LightReservedLayerMask>k__BackingField; // 0x28

        // ── Methods ──
        public void IsBlacklisted(){} // RVA: 0x7FFAC9EA5F80 | overloaded x2
        public void IsBlacklistedGameObject(){} // RVA: 0x7FFAC9EA4E00
        public void ApplyFilter(){} // RVA: 0x7FFAC9EA5B30 | overloaded x2
        public void ApplyLightCullingMaskFilter(){} // RVA: 0x7FFAC9EA4EB0
        public void get_LightReservedLayerMask(){} // RVA: 0x7FFAC32EC4C0
        public void set_LightReservedLayerMask(){} // RVA: 0x7FFAC369A6E0
        public void IsTypeSafe(){} // RVA: 0x7FFAC9EA4EC0
        public void Blacklist(){} // RVA: 0x7FFAC9EA5960 | overloaded x2
        public void CleanBlacklist(){} // RVA: 0x7FFAC9EA6250
        public void IdentifyDontDestroyOnLoadHandle(){} // RVA: 0x7FFAC9EA63D0
        public void .ctor(){} // RVA: 0x7FFAC9EA6500
    }

    public class UnityEngineObjectSecurityWhitelist : Object
    {
        public System.Collections.Generic.HashSet`1<UnityEngine.Object> LightReservedLayerMask; // 0x10
        public System.Collections.Generic.Dictionary`2<System.Type,bool> _safeTypeCache; // 0x18
        public int <LightReservedLayerMask>k__BackingField; // 0x20

        // ── Methods ──
        public void ApplyFilter(){} // RVA: 0x7FFAC9EA6F40 | overloaded x2
        public void ApplyLightCullingMaskFilter(){} // RVA: 0x7FFAC9EA68D0
        public void get_LightReservedLayerMask(){} // RVA: 0x7FFAC30DBBE0
        public void set_LightReservedLayerMask(){} // RVA: 0x7FFAC35DB7A0
        public void IsTypeSafe(){} // RVA: 0x7FFAC9EA68E0
        public void Whitelist(){} // RVA: 0x7FFAC9EA6C70 | overloaded x2
        public void IsWhitelisted(){} // RVA: 0x7FFAC9EA7110
        public void CleanWhitelist(){} // RVA: 0x7FFAC9EA7220
        public void .ctor(){} // RVA: 0x7FFAC9EA73A0
    }

}