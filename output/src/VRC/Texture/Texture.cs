// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Texture
// Classes: 4
// Methods: 58

namespace VRC.Texture
{
    /// <summary>Originally: ÏÌÍÍÍÏÌÎÎÎÎÏÌÌÌÏÌÏÎÍÌÎÎ</summary>
    public class DataStartDownloadLoadImage_4DD7 : ImageDownloader
    {
        public string ÌÌÌÍÏÌÏÏÏÎÎÍÏÎÍÏÍÍÌÍÎÎÏ;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E5EE2C0
        public void LoadImage(){} // RVA: 0x7FFD4E5EE2D0
        public void StartDownload(){} // RVA: 0x7FFD4E5EE3B0
        public void set_Error(){} // RVA: 0x7FFD4E5EE720
    }

    /// <summary>Originally: ÌÍÍÌÍÌÌÏÏÍÏÏÏÎÏÍÌÌÌÍÏÍÏ</summary>
    public class TexturetextImpl_10C6 : Texturetext_35E1
    {
        public System.Nullable`1<System.DateTime> ÍÌÍÏÏÏÎÎÍÌÍÎÏÏÍÌÏÏÏÌÍÎÍ; // 0x7E8

        // ── Methods ──
        public void CalculateTextSize(){} // RVA: 0x7FFD56BE7440
        public void Initialize(){} // RVA: 0x7FFD56BE7BA0 | overloaded x3
        public void set_autoSizeTextContainer(){} // RVA: 0x7FFD56BE7740
        public void get_fontWeight(){} // RVA: 0x7FFD56BE77F0
        public void CalculateLayoutInputVertical(){} // RVA: 0x7FFD56BE7DF0
        public void .ctor(){} // RVA: 0x7FFD4E5212B0
        public void SetLayoutDirty(){} // RVA: 0x7FFD56BE8050
        public void get_state(){} // RVA: 0x7FFD56BE77F0
        public void set_fontWeight(){} // RVA: 0x7FFD56BE82A0
        public void OnEnable(){} // RVA: 0x7FFD56BE8350
        public void UpdateAndVerifyTransform(){} // RVA: 0x7FFD56BE8430
    }

    /// <summary>Originally: ÎÏÎÍÏÌÏÏÎÎÏÎÌÎÍÏÎÌÎÏÍÏÍ</summary>
    public class TexturetextSibling_8BB2
    {
        public object f_3D7;
        public object f_F4F;
        public object f_B84;
        public object f_C95;

        // ── Methods ──
        public void AddChild(){} // RVA: 0x7FFD4E0788A0
        public void ContainsChild(){} // RVA: 0x7FFD4E090A40
        public void GetPlaybackRate(){} // RVA: 0x7FFD4E08D880
        public void SetResult(){} // RVA: 0x7FFD4E09E480
        public void DelegateCall(){} // RVA: 0x7FFD4E079960
        public void RemoveAt(){} // RVA: 0x7FFD4E090ED0
        public void DelegateCall_14EC244A1346(){} // RVA: 0x7FFD4E079960
        public void RemoveAt_ADB9476A79A8(){} // RVA: 0x7FFD4E090ED0
    }

    /// <summary>Originally: ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ</summary>
    public class Texturetext_35E1 : TextMeshProUGUI
    {
        public VRC.Localization.LocalizableString _text; // 0x7A8
        public UnityEngine.UI.LayoutElement _autoSizeTextContainer; // 0x7D0
        public bool _mesh; // 0x7D8
        public 0x66594108 _canvasRenderer; // 0x7DC
        public ÎÍÏÏÏÏÍÍÏÍÎÏÏÌÏÏÎÌÏÍÏÎÍ<VRC.Localization.LocalizableString> _maskOffset; // 0x7E0

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E5212B0
        public void Initialize(){} // RVA: 0x7FFD56DC7240
        public void set_autoSizeTextContainer(){} // RVA: 0x7FFD56DC7340
        public void get_fontWeight(){} // RVA: 0x7FFD54B88420
        public void get_canvasRenderer(){} // RVA: 0x7FFD56DC7400
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x7FFD56DC7580
        public void CalculateLayoutInputVertical(){} // RVA: 0x7FFD56DC7940
        public void SetVerticesDirty(){} // RVA: 0x7FFD56DC7C80
        public void SetLayoutDirty(){} // RVA: 0x7FFD56DC7C90
        public void get_state(){} // RVA: 0x7FFD4E3A19C0
        public void set_fontWeight(){} // RVA: 0x7FFD54B88430
        public void DelayedGraphicRebuild(){} // RVA: 0x7FFD56DC7C80
        public void DelayedMaterialRebuild(){} // RVA: 0x7FFD56DC7CC0
        public void Rebuild(){} // RVA: 0x7FFD56DC7CF0
        public void UpdateSubObjectPivot(){} // RVA: 0x7FFD56DC7FB0
        public void GetModifiedMaterial(){} // RVA: 0x7FFD56DC7C80
        public void UpdateMaterial(){} // RVA: 0x7FFD56DC82B0
        public void set_text(){} // RVA: 0x7FFD56DC83A0
        public void set_maskOffset(){} // RVA: 0x7FFD4E3A19C0
        public void RecalculateClipping(){} // RVA: 0x7FFD54B88430
        public void OnEnable(){} // RVA: 0x7FFD56DC84A0
        public void UpdateCulling(){} // RVA: 0x7FFD56DC8940
        public void UpdateMeshPadding(){} // RVA: 0x7FFD54B86F30
        public void InternalCrossFadeColor(){} // RVA: 0x7FFD56DC7C90
        public void get_fontSize(){} // RVA: 0x7FFD54B883A0
        public void Awake(){} // RVA: 0x7FFD56DC8970
        public void OnDestroy(){} // RVA: 0x7FFD56DC8B90
        public void ClearMesh(){} // RVA: 0x7FFD56DC8940
        public void OnDisable(){} // RVA: 0x7FFD56DC8BD0
        public void get_text(){} // RVA: 0x7FFD56DC8F10
        public void UpdateGeometry(){} // RVA: 0x7FFD56DC8F20
        public void set_fontStyle(){} // RVA: 0x7FFD54B88880
        public void UpdateVertexData(){} // RVA: 0x7FFD54B88880
    }

}