// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.UI.Client.Emoji
// Classes: 3
// Methods: 37

namespace VRC.UI.Client.Emoji
{
    public class EmojiCategoryList : ScriptableObject
    {
        public System.Collections.Generic.List`1<VRC.UI.Client.Emoji.EmojiDataList> Categories; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC312F5F0
    }

    public class EmojiData : ScriptableObject
    {
        public string ID; // 0x18
        public string OwnerID; // 0x20
        public UnityEngine.Sprite FileId; // 0x28
        public string IsBuiltIn; // 0x30
        public ÍÍÌÎÏÍÍÏÏÏÎÏÍÍÌÌÎÍÌÍÍÍÏ<UnityEngine.Texture2D> DisplayTexture; // 0x38
        public ÍÍÌÎÏÍÍÏÏÏÎÏÍÍÌÌÎÍÌÍÍÍÏ<UnityEngine.Texture2D> FullResolutionTexture; // 0x40
        public ÍÍÌÎÏÍÍÏÏÏÎÏÍÍÌÌÎÍÌÍÍÍÏ<UnityEngine.Sprite> Sprite; // 0x48
        public string IsAnimated; // 0x50
        public string IsPremium; // 0x58
        public string LoadFrom; // 0x60
        public string Frames; // 0x68
        public bool FPS; // 0x70

        // ── Methods ──
        public void get_IsSpecialFX(){} // RVA: 0x7FFAC2F21320
        public void StartPickedUp(){} // RVA: 0x7FFAC2F9CD60
        public void get_EffectBundleID(){} // RVA: 0x7FFAC38FBE90
        public void get_Sprite(){} // RVA: 0x7FFAC2F9C730
        public void get_OwnerCanUseAnimatedEmoji(){} // RVA: 0x7FFAC2F9D320
        public void SetResources(){} // RVA: 0x7FFAC2FE9510
        public void get_FullResolutionTexture(){} // RVA: 0x7FFAC2F9E740
        public void GetMaterial(){} // RVA: 0x7FFAC2F9CD50
        public void set_FileId(){} // RVA: 0x7FFAC2FE9510
        public void get_FileId(){} // RVA: 0x7FFAC34F9180
        public void set_IsBuiltIn(){} // RVA: 0x7FFAC38FBED0
        public void get_IsBuiltIn(){} // RVA: 0x7FFAC3006850
        public void get_SpawnablePrefabName(){} // RVA: 0x7FFAC38FBF10
        public void get_Frames(){} // RVA: 0x7FFAC34F9180
        public void .ctor(){} // RVA: 0x7FFAC312F5F0
        public void get_LoopStyle(){} // RVA: 0x7FFAC2FC20E0
        public void get_IsPremium(){} // RVA: 0x7FFAC2F21320
        public void get_FPS(){} // RVA: 0x7FFAC34F9180
        public void set_LoopStyle(){} // RVA: 0x7FFAC30794D0
        public void set_AnimationStyle(){} // RVA: 0x7FFAC2F9CD60
        public void set_IsAnimated(){} // RVA: 0x7FFAC38FBF30
        public void get_IsAnimated(){} // RVA: 0x7FFAC2F21320
        public void get_MaskTag(){} // RVA: 0x7FFAC2FBF370
        public void set_FullResolutionTexture(){} // RVA: 0x7FFAC2F49200
        public void get_LoadFrom(){} // RVA: 0x7FFAC34F9180
        public void set_LoadFrom(){} // RVA: 0x7FFAC34F9180
        public void set_OwnerCanUseAnimatedEmoji(){} // RVA: 0x7FFAC2F9D330
        public void set_DisplayTexture(){} // RVA: 0x7FFAC31D0C20
        public void get_AnimationStyle(){} // RVA: 0x7FFAC2F9CD50
        public void get_OwnerID(){} // RVA: 0x7FFAC38FC060
        public void set_OwnerID(){} // RVA: 0x7FFAC38FC0A0
        public void set_Sprite(){} // RVA: 0x7FFAC2F9C740
        public void set_ID(){} // RVA: 0x7FFAC3006850
        public void get_DisplayTexture(){} // RVA: 0x7FFAC31D0140
        public void get_ID(){} // RVA: 0x7FFAC2F247C0
    }

    public class EmojiDataList : ScriptableObject
    {
        public string Name; // 0x18
        public UnityEngine.Sprite Icon; // 0x20
        public System.Collections.Generic.List`1<VRC.UI.Client.Emoji.EmojiData> Data; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC312F5F0
    }

}