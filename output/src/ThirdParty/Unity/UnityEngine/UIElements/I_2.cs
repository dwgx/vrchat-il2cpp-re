// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 28
// Methods: 156

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class IUIElementsUtility
    {
        // ── Methods ──
        public void TakeCapture(){} // RVA: 0xDBE0
        public void ReleaseCapture(){} // RVA: 0xDBE0
        public void ProcessEvent(){}
        public void CleanupRoots(){} // RVA: 0xDBE0
        public void EndContainerGUIFromException(){} // RVA: 0xDE40
        public void MakeCurrentIMGUIContainerDirty(){} // RVA: 0xDBE0
    }

    public class IUxmlAttributes
    {
        // ── Methods ──
        public void TryGetAttributeValue(){} // RVA: 0x11120
    }

    public class IUxmlFactory
    {
        // ── Methods ──
        public void Create(){}
    }

    public class IUxmlObjectFactory`1
    {
        // ── Methods ──
        public void CreateObject(){} // RVA: 0x283FA0
    }

    public class IUxmlObjectFactory`1
    {
    }

    public class IUxmlObjectFactory`1
    {
    }

    public class IUxmlObjectFactory`1
    {
    }

    public class IUxmlObjectFactory`1
    {
    }

    public class IUxmlObjectFactory`1
    {
    }

    public class IValueField`1
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0x283FA0
        public void set_value(){} // RVA: 0x283FA0
        public void ApplyInputDeviceDelta(){} // RVA: 0x283FA0
        public void StartDragging(){} // RVA: 0x24A50
        public void StopDragging(){} // RVA: 0x24A50
    }

    public class IValueField`1
    {
    }

    public class IValueField`1
    {
    }

    public class IValueField`1
    {
    }

    public class IValueField`1
    {
    }

    public class IValueField`1
    {
    }

    public class IValueField`1
    {
    }

    public class IValueField`1
    {
    }

    public class IValueField`1
    {
    }

    public class IVisualElementPanelActivatable
    {
        // ── Methods ──
        public void get_element(){} // RVA: 0xCD60
        public void CanBeActivated(){} // RVA: 0xDBE0
        public void OnPanelActivate(){} // RVA: 0x24A50
        public void OnPanelDeactivate(){} // RVA: 0x24A50
    }

    public class IVisualElementScheduledItem
    {
        // ── Methods ──
        public void Resume(){} // RVA: 0x24A50
        public void Pause(){} // RVA: 0x24A50
        public void ExecuteLater(){} // RVA: 0x24CC0
        public void StartingIn(){}
        public void Every(){}
    }

    public class IVisualElementScheduler
    {
        // ── Methods ──
        public void Execute(){} // RVA: 0xCE10 | overloaded x2
    }

    public class IVisualTreeUpdater
    {
        // ── Methods ──
        public void set_panel(){} // RVA: 0x24B10
        public void get_profilerMarker(){}
        public void Update(){} // RVA: 0x24A50
        public void OnVersionChanged(){} // RVA: 0x2BAA0
    }

    public class Image
    {
        public 0x659A1200 m_ScaleMode; // 0x3C8
        public UnityEngine.Texture m_Image; // 0x3D0
        public UnityEngine.Sprite m_Sprite; // 0x3D8
        public UnityEngine.UIElements.VectorImage m_VectorImage; // 0x3E0
        public UnityEngine.Rect m_UV; // 0x3E8
        public UnityEngine.Color m_TintColor; // 0x3F8
        public bool m_ImageIsInline; // 0x408

        // ── Methods ──
        public void get_image(){} // RVA: 0xD8F1C0
        public void set_image(){} // RVA: 0x7320E10
        public void get_sprite(){} // RVA: 0xDA0010
        public void set_sprite(){} // RVA: 0x7321020
        public void get_vectorImage(){} // RVA: 0xD98840
        public void set_vectorImage(){} // RVA: 0x7321230
        public void get_sourceRect(){} // RVA: 0x7321440
        public void get_uv(){} // RVA: 0x7321470
        public void set_uv(){} // RVA: 0x7321480
        public void get_scaleMode(){} // RVA: 0x73214E0
        public void get_tintColor(){} // RVA: 0x73214F0
        public void .ctor(){} // RVA: 0x7321500
        public void GetTextureDisplaySize(){} // RVA: 0x73218A0 | overloaded x2
        public void DoMeasure(){} // RVA: 0x7321AE0
        public void OnGenerateVisualContent(){} // RVA: 0x7321F90
        public void OnCustomStyleResolved(){} // RVA: 0x73227B0
        public void ReadCustomProperties(){} // RVA: 0x73227F0
        public void SetProperty(){} // RVA: 0x283FA0
        public void ClearProperty(){} // RVA: 0x7322E30
        public void SetScaleMode(){} // RVA: 0x7322E80
        public void SetTintColor(){} // RVA: 0x7322ED0
        public void GetSourceRect(){} // RVA: 0x7322F80
        public void .cctor(){} // RVA: 0x7323240
    }

    public class ImmediateModeException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x740D040
    }

    public class InheritedData
    {
        // ── Methods ──
        public void Copy(){} // RVA: 0x745DD70
        public void CopyFrom(){} // RVA: 0x745DDC0
        public void op_Equality(){} // RVA: 0x745DE80
        public void Equals(){} // RVA: 0x745E650 | overloaded x2
        public void GetHashCode(){} // RVA: 0x745E760
    }

    public class InlineStyleAccess : GetStyleLength
    {
        public UnityEngine.UIElements.StyleSheets.StylePropertyReader s_StylePropertyReader;
        public System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.StyleValueManaged> m_ValuesManaged; // 0x18
        public UnityEngine.UIElements.VisualElement <ve>k__BackingField; // 0x20
        public bool m_HasInlineCursor; // 0x28
        public UnityEngine.UIElements.StyleCursor m_InlineCursor; // 0x30
        public bool m_HasInlineTextShadow; // 0x50
        public UnityEngine.UIElements.StyleTextShadow m_InlineTextShadow; // 0x54
        public bool m_HasInlineTransformOrigin; // 0x74
        public UnityEngine.UIElements.StyleTransformOrigin m_InlineTransformOrigin; // 0x78
        public bool m_HasInlineTranslate; // 0x90
        public UnityEngine.UIElements.StyleTranslate m_InlineTranslateOperation; // 0x94
        public bool m_HasInlineRotate; // 0xB0
        public UnityEngine.UIElements.StyleRotate m_InlineRotateOperation; // 0xB4
        public bool m_HasInlineScale; // 0xD0
        public UnityEngine.UIElements.StyleScale m_InlineScale; // 0xD4
        public bool m_HasInlineBackgroundSize; // 0xE8
        public UnityEngine.UIElements.StyleBackgroundSize m_InlineBackgroundSize; // 0xEC
        public InlineRule m_InlineRule; // 0x108

        // ── Methods ──
        public void UnityEngine.UIElements.IStyle.set_backgroundColor(){} // RVA: 0x7441720
        public void UnityEngine.UIElements.IStyle.set_borderBottomColor(){} // RVA: 0x7441790
        public void UnityEngine.UIElements.IStyle.set_borderBottomLeftRadius(){} // RVA: 0x7441800
        public void UnityEngine.UIElements.IStyle.set_borderBottomRightRadius(){} // RVA: 0x7441870
        public void UnityEngine.UIElements.IStyle.set_borderBottomWidth(){} // RVA: 0x74418E0
        public void UnityEngine.UIElements.IStyle.set_borderLeftColor(){} // RVA: 0x74419A0
        public void UnityEngine.UIElements.IStyle.set_borderLeftWidth(){} // RVA: 0x7441A10
        public void UnityEngine.UIElements.IStyle.set_borderRightColor(){} // RVA: 0x7441AD0
        public void UnityEngine.UIElements.IStyle.set_borderRightWidth(){} // RVA: 0x7441B40
        public void UnityEngine.UIElements.IStyle.set_borderTopColor(){} // RVA: 0x7441C00
        public void UnityEngine.UIElements.IStyle.set_borderTopLeftRadius(){} // RVA: 0x7441C70
        public void UnityEngine.UIElements.IStyle.set_borderTopRightRadius(){} // RVA: 0x7441CE0
        public void UnityEngine.UIElements.IStyle.set_borderTopWidth(){} // RVA: 0x7441D50
        public void UnityEngine.UIElements.IStyle.set_bottom(){} // RVA: 0x7441E10
        public void UnityEngine.UIElements.IStyle.set_color(){} // RVA: 0x7441EF0
        public void UnityEngine.UIElements.IStyle.get_display(){} // RVA: 0x7441F60
        public void UnityEngine.UIElements.IStyle.set_display(){} // RVA: 0x7442020
        public void UnityEngine.UIElements.IStyle.set_flexBasis(){} // RVA: 0x7442150
        public void UnityEngine.UIElements.IStyle.set_flexDirection(){} // RVA: 0x7442230
        public void UnityEngine.UIElements.IStyle.set_flexGrow(){} // RVA: 0x7442360
        public void UnityEngine.UIElements.IStyle.set_flexShrink(){} // RVA: 0x7442420
        public void UnityEngine.UIElements.IStyle.set_fontSize(){} // RVA: 0x74424E0
        public void UnityEngine.UIElements.IStyle.set_height(){} // RVA: 0x7442550
        public void UnityEngine.UIElements.IStyle.set_left(){} // RVA: 0x7442630
        public void UnityEngine.UIElements.IStyle.set_marginBottom(){} // RVA: 0x7442710
        public void UnityEngine.UIElements.IStyle.set_marginLeft(){} // RVA: 0x74427F0
        public void UnityEngine.UIElements.IStyle.set_marginRight(){} // RVA: 0x74428D0
        public void UnityEngine.UIElements.IStyle.set_marginTop(){} // RVA: 0x74429B0
        public void UnityEngine.UIElements.IStyle.set_maxHeight(){} // RVA: 0x7442AA0
        public void UnityEngine.UIElements.IStyle.set_maxWidth(){} // RVA: 0x7442B80
        public void UnityEngine.UIElements.IStyle.set_minWidth(){} // RVA: 0x7442C60
        public void UnityEngine.UIElements.IStyle.set_opacity(){} // RVA: 0x7442D40
        public void UnityEngine.UIElements.IStyle.set_overflow(){} // RVA: 0x7442DA0
        public void UnityEngine.UIElements.IStyle.set_paddingBottom(){} // RVA: 0x7442F20
        public void UnityEngine.UIElements.IStyle.set_paddingLeft(){} // RVA: 0x7443010
        public void UnityEngine.UIElements.IStyle.set_paddingRight(){} // RVA: 0x74430F0
        public void UnityEngine.UIElements.IStyle.get_paddingTop(){} // RVA: 0x74431E0
        public void UnityEngine.UIElements.IStyle.set_paddingTop(){} // RVA: 0x7443270
        public void UnityEngine.UIElements.IStyle.set_position(){} // RVA: 0x7443360
        public void UnityEngine.UIElements.IStyle.set_right(){} // RVA: 0x7443490
        public void UnityEngine.UIElements.IStyle.set_top(){} // RVA: 0x7443580
        public void UnityEngine.UIElements.IStyle.set_unityBackgroundImageTintColor(){} // RVA: 0x7443670
        public void UnityEngine.UIElements.IStyle.set_unityFont(){} // RVA: 0x74436E0
        public void UnityEngine.UIElements.IStyle.set_unityFontDefinition(){} // RVA: 0x7443750
        public void UnityEngine.UIElements.IStyle.set_visibility(){} // RVA: 0x74437D0
        public void UnityEngine.UIElements.IStyle.get_width(){} // RVA: 0x7443860
        public void UnityEngine.UIElements.IStyle.set_width(){} // RVA: 0x74438F0
        public void get_ve(){} // RVA: 0x30B0C0
        public void set_ve(){} // RVA: 0x30B0D0
        public void .ctor(){} // RVA: 0x74439D0
        public void Finalize(){} // RVA: 0x7443A40
        public void SetInlineRule(){} // RVA: 0x7443B80
        public void IsValueSet(){} // RVA: 0x7443DD0
        public void ApplyInlineStyles(){} // RVA: 0x74441B0
        public void UnityEngine.UIElements.IStyle.get_cursor(){} // RVA: 0x74451B0
        public void UnityEngine.UIElements.IStyle.get_textShadow(){} // RVA: 0x74452F0
        public void UnityEngine.UIElements.IStyle.get_backgroundSize(){} // RVA: 0x7445360
        public void UnityEngine.UIElements.IStyle.get_transformOrigin(){} // RVA: 0x74453C0
        public void UnityEngine.UIElements.IStyle.get_translate(){} // RVA: 0x7445410
        public void UnityEngine.UIElements.IStyle.set_translate(){} // RVA: 0x7445470
        public void UnityEngine.UIElements.IStyle.get_rotate(){} // RVA: 0x74456E0
        public void UnityEngine.UIElements.IStyle.get_scale(){} // RVA: 0x7445740
        public void SetStyleValue(){} // RVA: 0x7446140 | overloaded x6
        public void SetInlineTranslate(){} // RVA: 0x7446440
        public void ApplyStyleTranslate(){} // RVA: 0x7446600
        public void ApplyStyleValue(){} // RVA: 0x7446A30
        public void RemoveInlineStyle(){} // RVA: 0x7446D50
        public void ApplyFromComputedStyle(){} // RVA: 0x7446EA0
        public void TryGetInlineCursor(){} // RVA: 0x74470B0
        public void TryGetInlineTextShadow(){} // RVA: 0x7447120
        public void TryGetInlineTransformOrigin(){} // RVA: 0x7447140
        public void TryGetInlineTranslate(){} // RVA: 0x7447160
        public void TryGetInlineRotate(){} // RVA: 0x7447190
        public void TryGetInlineScale(){} // RVA: 0x74471C0
        public void TryGetInlineBackgroundSize(){} // RVA: 0x74471F0
        public void .cctor(){} // RVA: 0x7447220
    }

    public class InputEvent
    {
        public string <previousData>k__BackingField; // 0x88
        public string <newData>k__BackingField; // 0x90

        // ── Methods ──
        public void .cctor(){} // RVA: 0x73EC3D0
        public void set_previousData(){} // RVA: 0x463060
        public void set_newData(){} // RVA: 0xB54600
        public void Init(){} // RVA: 0x73EC4C0
        public void LocalInit(){} // RVA: 0x73EC580
        public void GetPooled(){} // RVA: 0x73EC640
        public void .ctor(){} // RVA: 0x73EC770
    }

    public class IntegerField
    {
        public string ussClassName;

        // ── Methods ──
        public void get_integerInput(){} // RVA: 0x73A5AD0
        public void ValueToString(){} // RVA: 0x73A5B60
        public void StringToValue(){} // RVA: 0x73A5D70
        public void .ctor(){} // RVA: 0x73A5EC0 | overloaded x2
        public void CanTryParse(){} // RVA: 0x73A6300
        public void ApplyInputDeviceDelta(){} // RVA: 0x73A63D0
        public void .cctor(){} // RVA: 0x73A64C0
    }

}