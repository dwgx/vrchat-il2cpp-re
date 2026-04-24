// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 19
// Methods: 194

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class IDragAndDropController`1
    {
        // ── Methods ──
        public void CanStartDrag(){} // RVA: 0x7FFD4E079F60
        public void SetupDragAndDrop(){}
        public void HandleDragAndDrop(){} // RVA: 0x7FFD4E2ADC40
        public void OnDrop(){} // RVA: 0x7FFD4E2ADC40
        public void DragCleanup(){} // RVA: 0x7FFD4E090980
        public void HandleAutoExpand(){}
        public void GetSortedSelectedIds(){} // RVA: 0x7FFD4E078E90
    }

    public class IEventHandler
    {
        // ── Methods ──
        public void SendEvent(){} // RVA: 0x7FFD4E090A40
        public void HandleEvent(){} // RVA: 0x7FFD4E090A40
    }

    public class IExperimentalFeatures
    {
        public object animation;

        // ── Methods ──
        public void get_animation(){} // RVA: 0x7FFD4E078E90
    }

    public class IGroupBox
    {
        // ── Methods ──
        public void OnOptionAdded(){} // RVA: 0x7FFD4E090A40
        public void OnOptionRemoved(){} // RVA: 0x7FFD4E090A40
    }

    public class IMGUIContainer : VisualElement
    {
        public System.Action onGUIHandler; // 0x3C8
        public 0x665E0088 guiState; // 0x3D0
        public bool lastWorldClip; // 0x3D8
        public UnityEngine.Rect cullingEnabled; // 0x3DC
        public bool cache; // 0x3EC
        public bool layoutMeasuredWidth; // 0x3ED
        public bool layoutMeasuredHeight; // 0x3EE
        public 0x665DFAB0 contextType; // 0x3F0
        public UnityEngine.Rect focusOnlyIfHasFocusableControls; // 0x3F8
        public UnityEngine.Matrix4x4 canGrabFocus; // 0x408
        public 0x6647FED0 <contextType>k__BackingField; // 0x448
        public bool lostFocus; // 0x44C
        public bool receivedFocus; // 0x44D
        public 0x6647EDA0 focusChangeDirection; // 0x450
        public bool hasFocusableControls; // 0x458
        public int newKeyboardFocusControlID; // 0x45C
        public bool <focusOnlyIfHasFocusableControls>k__BackingField; // 0x460
        public string ussClassName;
        public string ussFoldoutChildDepthClassName; // 0x8
        public System.Collections.Generic.List`1<string> ussFoldoutChildDepthClassNames; // 0x10
        public GUIGlobals m_GUIGlobals; // 0x464
        public Unity.Profiling.ProfilerMarker k_OnGUIMarker; // 0x18
        public Unity.Profiling.ProfilerMarker k_ImmediateCallbackMarker; // 0x20
        public UnityEngine.Event s_DefaultMeasureEvent; // 0x28
        public UnityEngine.Event s_MeasureEvent; // 0x30
        public UnityEngine.Event s_CurrentEvent; // 0x38

        // ── Methods ──
        public void get_onGUIHandler(){} // RVA: 0x7FFD54FBEA40
        public void set_onGUIHandler(){} // RVA: 0x7FFD54FBEA50
        public void get_guiState(){} // RVA: 0x7FFD54FBEB50
        public void get_lastWorldClip(){} // RVA: 0x7FFD54FBEC80
        public void set_lastWorldClip(){} // RVA: 0x7FFD54FBEC90
        public void get_cullingEnabled(){} // RVA: 0x7FFD54FBECA0
        public void get_cache(){} // RVA: 0x7FFD54FBECB0
        public void get_layoutMeasuredWidth(){} // RVA: 0x7FFD54FBED70
        public void get_layoutMeasuredHeight(){} // RVA: 0x7FFD54FBEDA0
        public void get_contextType(){} // RVA: 0x7FFD54FBEDD0
        public void set_contextType(){} // RVA: 0x7FFD54FBEDE0
        public void get_focusOnlyIfHasFocusableControls(){} // RVA: 0x7FFD54FBEDF0
        public void get_canGrabFocus(){} // RVA: 0x7FFD54FBEE00
        public void .cctor(){} // RVA: 0x7FFD54FBEE30
        public void .ctor(){} // RVA: 0x7FFD54FBF6D0 | overloaded x2
        public void OnGenerateVisualContent(){} // RVA: 0x7FFD54FBFB50
        public void SaveGlobals(){} // RVA: 0x7FFD54FBFCB0
        public void RestoreGlobals(){} // RVA: 0x7FFD54FC0090
        public void DoOnGUI(){} // RVA: 0x7FFD54FC0490
        public void MarkDirtyLayout(){} // RVA: 0x7FFD54FC1F30
        public void ProcessEvent(){} // RVA: 0x7FFD54FC1F70
        public void DoIMGUIRepaint(){} // RVA: 0x7FFD54FC2120
        public void SendEventToIMGUI(){} // RVA: 0x7FFD54FC2490
        public void SendEventToIMGUIRaw(){} // RVA: 0x7FFD54FC27C0
        public void VerifyBounds(){} // RVA: 0x7FFD54FC2880
        public void IsContainerCapturingTheMouse(){} // RVA: 0x7FFD54FC2AE0
        public void IsLocalEvent(){} // RVA: 0x7FFD54FC2BB0
        public void IsEventInsideLocalWindow(){} // RVA: 0x7FFD54FC2DD0
        public void IsDockAreaMouseUp(){} // RVA: 0x7FFD54FC3020
        public void HandleIMGUIEvent(){} // RVA: 0x7FFD54FC34E0 | overloaded x3
        public void ExecuteDefaultAction(){} // RVA: 0x7FFD54FC3A80
        public void SetFoldoutDepthClass(){} // RVA: 0x7FFD54FC3DF0
        public void DoMeasure(){} // RVA: 0x7FFD54FC3FB0
        public void GetCurrentClipRect(){} // RVA: 0x7FFD54FC4450
        public void GetCurrentTransformAndClip(){} // RVA: 0x7FFD54FC44D0
        public void Dispose(){} // RVA: 0x7FFD54FC47C0 | overloaded x2
        public void <DoOnGUI>b__56_0(){} // RVA: 0x7FFD54FC4840
    }

    public class INotifyValueChangedExtensions : Object
    {
        // ── Methods ──
        public void RegisterValueChangedCallback(){} // RVA: 0x7FFD4E07A350
        public void UnregisterValueChangedCallback(){} // RVA: 0x7FFD4E07A350
    }

    public class INotifyValueChanged`1
    {
        public object value;

        // ── Methods ──
        public void get_value(){} // RVA: 0x7FFD4E2ADC40
        public void set_value(){} // RVA: 0x7FFD4E2ADC40
        public void SetValueWithoutNotify(){} // RVA: 0x7FFD4E2ADC40
    }

    public class IPanel
    {
        public object visualTree;
        public object dispatcher;
        public object contextType;
        public object focusController;

        // ── Methods ──
        public void get_visualTree(){} // RVA: 0x7FFD4E078E90
        public void get_dispatcher(){} // RVA: 0x7FFD4E078E90
        public void get_contextType(){} // RVA: 0x7FFD4E079960
        public void get_focusController(){} // RVA: 0x7FFD4E078E90
        public void Pick(){}
    }

    public class IRuntimePanelComponent
    {
        public object panel;

        // ── Methods ──
        public void set_panel(){} // RVA: 0x7FFD4E090A40
    }

    public class ISerializableJsonDictionary
    {
        // ── Methods ──
        public void Set(){} // RVA: 0x7FFD4E2ADC40
        public void Get(){} // RVA: 0x7FFD4E2ADC40
        public void Overwrite(){} // RVA: 0x7FFD4E099B30
        public void ContainsKey(){} // RVA: 0x7FFD4E079F60
    }

    public class IStyleDataGroup`1
    {
        // ── Methods ──
        public void Copy(){} // RVA: 0x7FFD4E2ADC40
        public void CopyFrom(){} // RVA: 0x7FFD4E090A40
    }

    public class IStyleValue`1
    {
        public object value;
        public object keyword;

        // ── Methods ──
        public void get_value(){} // RVA: 0x7FFD4E2ADC40
        public void get_keyword(){} // RVA: 0x7FFD4E079960
    }

    public class ITransform
    {
        public object position;
        public object scale;

        // ── Methods ──
        public void get_position(){} // RVA: 0x7FFD4E0788A0
        public void set_position(){} // RVA: 0x7FFD4E090A40
        public void get_scale(){} // RVA: 0x7FFD4E0788A0
    }

    public class IUxmlObjectFactory`1
    {
        // ── Methods ──
        public void CreateObject(){} // RVA: 0x7FFD4E2ADC40
    }

    public class IValueField`1
    {
        public object value;

        // ── Methods ──
        public void get_value(){} // RVA: 0x7FFD4E2ADC40
        public void set_value(){} // RVA: 0x7FFD4E2ADC40
        public void ApplyInputDeviceDelta(){} // RVA: 0x7FFD4E2ADC40
        public void StartDragging(){} // RVA: 0x7FFD4E090980
        public void StopDragging(){} // RVA: 0x7FFD4E090980
    }

    public class IVisualElementScheduler
    {
        // ── Methods ──
        public void Execute(){} // RVA: 0x7FFD4E078F40 | overloaded x2
    }

    public class Image : VisualElement
    {
        public 0x665DF8A0 image; // 0x3C8
        public UnityEngine.Texture sprite; // 0x3D0
        public UnityEngine.Sprite vectorImage; // 0x3D8
        public UnityEngine.UIElements.VectorImage sourceRect; // 0x3E0
        public UnityEngine.Rect uv; // 0x3E8
        public UnityEngine.Color scaleMode; // 0x3F8
        public bool tintColor; // 0x408
        public bool m_ScaleModeIsInline; // 0x409
        public bool m_TintColorIsInline; // 0x40A
        public string ussClassName;
        public UnityEngine.UIElements.CustomStyleProperty`1<UnityEngine.Texture2D> s_ImageProperty; // 0x8
        public UnityEngine.UIElements.CustomStyleProperty`1<UnityEngine.Sprite> s_SpriteProperty; // 0x10
        public UnityEngine.UIElements.CustomStyleProperty`1<UnityEngine.UIElements.VectorImage> s_VectorImageProperty; // 0x18
        public UnityEngine.UIElements.CustomStyleProperty`1<string> s_ScaleModeProperty; // 0x20
        public UnityEngine.UIElements.CustomStyleProperty`1<UnityEngine.Color> s_TintColorProperty; // 0x28

        // ── Methods ──
        public void get_image(){} // RVA: 0x7FFD4EDE1CA0
        public void set_image(){} // RVA: 0x7FFD54ED86F0
        public void get_sprite(){} // RVA: 0x7FFD4EDCD490
        public void set_sprite(){} // RVA: 0x7FFD54ED8900
        public void get_vectorImage(){} // RVA: 0x7FFD4EDDF4D0
        public void set_vectorImage(){} // RVA: 0x7FFD54ED8B10
        public void get_sourceRect(){} // RVA: 0x7FFD54ED8D20
        public void get_uv(){} // RVA: 0x7FFD54ED8D50
        public void set_uv(){} // RVA: 0x7FFD54ED8D60
        public void get_scaleMode(){} // RVA: 0x7FFD54ED8DC0
        public void get_tintColor(){} // RVA: 0x7FFD54ED8DD0
        public void .ctor(){} // RVA: 0x7FFD54ED8DE0
        public void GetTextureDisplaySize(){} // RVA: 0x7FFD54ED9180 | overloaded x2
        public void DoMeasure(){} // RVA: 0x7FFD54ED93C0
        public void OnGenerateVisualContent(){} // RVA: 0x7FFD54ED9870
        public void OnCustomStyleResolved(){} // RVA: 0x7FFD54EDA090
        public void ReadCustomProperties(){} // RVA: 0x7FFD54EDA0D0
        public void SetProperty(){} // RVA: 0x7FFD4E2ADC40
        public void ClearProperty(){} // RVA: 0x7FFD54EDA710
        public void SetScaleMode(){} // RVA: 0x7FFD54EDA760
        public void SetTintColor(){} // RVA: 0x7FFD54EDA7B0
        public void GetSourceRect(){} // RVA: 0x7FFD54EDA860
        public void .cctor(){} // RVA: 0x7FFD54EDAB20
    }

    public class InheritedData : ValueType
    {
        public UnityEngine.Color color; // 0x10
        public UnityEngine.UIElements.Length fontSize; // 0x20
        public UnityEngine.UIElements.Length letterSpacing; // 0x28
        public UnityEngine.UIElements.TextShadow textShadow; // 0x30
        public UnityEngine.Font unityFont; // 0x50
        public UnityEngine.UIElements.FontDefinition unityFontDefinition; // 0x58
        public 0x66638AD8 unityFontStyleAndWeight; // 0x68
        public UnityEngine.UIElements.Length unityParagraphSpacing; // 0x6C
        public 0x66638C90 unityTextAlign; // 0x74
        public UnityEngine.Color unityTextOutlineColor; // 0x78
        public float unityTextOutlineWidth; // 0x88
        public 0x66482A20 visibility; // 0x8C
        public 0x66482A78 whiteSpace; // 0x90
        public UnityEngine.UIElements.Length wordSpacing; // 0x94

        // ── Methods ──
        public void Copy(){} // RVA: 0x7FFD550156C0
        public void CopyFrom(){} // RVA: 0x7FFD55015710
        public void op_Equality(){} // RVA: 0x7FFD550157D0
        public void Equals(){} // RVA: 0x7FFD55015FA0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD550160B0
    }

    public class InlineStyleAccess : StyleValueCollection
    {
        public 0x66489A30 UnityEngine.UIElements.IStyle.backgroundColor;
        public System.Collections.Generic.List`1<0x66489DA0> UnityEngine.UIElements.IStyle.borderBottomColor; // 0x18
        public UnityEngine.UIElements.VisualElement UnityEngine.UIElements.IStyle.borderBottomLeftRadius; // 0x20
        public bool UnityEngine.UIElements.IStyle.borderBottomRightRadius; // 0x28
        public 0x66481F20 UnityEngine.UIElements.IStyle.borderBottomWidth; // 0x30
        public bool UnityEngine.UIElements.IStyle.borderLeftColor; // 0x50
        public 0x66482340 UnityEngine.UIElements.IStyle.borderLeftWidth; // 0x54
        public bool UnityEngine.UIElements.IStyle.borderRightColor; // 0x74
        public s UnityEngine.UIElements.IStyle.borderRightWidth; // 0x78
        public bool UnityEngine.UIElements.IStyle.borderTopColor; // 0x90
        public 0x664822E8 UnityEngine.UIElements.IStyle.borderTopLeftRadius; // 0x94
        public bool UnityEngine.UIElements.IStyle.borderTopRightRadius; // 0xB0
        public 0x66482238 UnityEngine.UIElements.IStyle.borderTopWidth; // 0xB4
        public bool UnityEngine.UIElements.IStyle.bottom; // 0xD0
        public 0x66482290 UnityEngine.UIElements.IStyle.color; // 0xD4
        public bool UnityEngine.UIElements.IStyle.display; // 0xE8
        public 0x66481E70 UnityEngine.UIElements.IStyle.flexBasis; // 0xEC
        public 0x66481420 UnityEngine.UIElements.IStyle.flexDirection; // 0x108

        // ── Methods ──
        public void UnityEngine.UIElements.IStyle.set_backgroundColor(){} // RVA: 0x7FFD54FF9010
        public void UnityEngine.UIElements.IStyle.set_borderBottomColor(){} // RVA: 0x7FFD54FF9080
        public void UnityEngine.UIElements.IStyle.set_borderBottomLeftRadius(){} // RVA: 0x7FFD54FF90F0
        public void UnityEngine.UIElements.IStyle.set_borderBottomRightRadius(){} // RVA: 0x7FFD54FF9160
        public void UnityEngine.UIElements.IStyle.set_borderBottomWidth(){} // RVA: 0x7FFD54FF91D0
        public void UnityEngine.UIElements.IStyle.set_borderLeftColor(){} // RVA: 0x7FFD54FF9290
        public void UnityEngine.UIElements.IStyle.set_borderLeftWidth(){} // RVA: 0x7FFD54FF9300
        public void UnityEngine.UIElements.IStyle.set_borderRightColor(){} // RVA: 0x7FFD54FF93C0
        public void UnityEngine.UIElements.IStyle.set_borderRightWidth(){} // RVA: 0x7FFD54FF9430
        public void UnityEngine.UIElements.IStyle.set_borderTopColor(){} // RVA: 0x7FFD54FF94F0
        public void UnityEngine.UIElements.IStyle.set_borderTopLeftRadius(){} // RVA: 0x7FFD54FF9560
        public void UnityEngine.UIElements.IStyle.set_borderTopRightRadius(){} // RVA: 0x7FFD54FF95D0
        public void UnityEngine.UIElements.IStyle.set_borderTopWidth(){} // RVA: 0x7FFD54FF9640
        public void UnityEngine.UIElements.IStyle.set_bottom(){} // RVA: 0x7FFD54FF9700
        public void UnityEngine.UIElements.IStyle.set_color(){} // RVA: 0x7FFD54FF97E0
        public void UnityEngine.UIElements.IStyle.get_display(){} // RVA: 0x7FFD54FF9850
        public void UnityEngine.UIElements.IStyle.set_display(){} // RVA: 0x7FFD54FF9910
        public void UnityEngine.UIElements.IStyle.set_flexBasis(){} // RVA: 0x7FFD54FF9A40
        public void UnityEngine.UIElements.IStyle.set_flexDirection(){} // RVA: 0x7FFD54FF9B20
        public void UnityEngine.UIElements.IStyle.set_flexGrow(){} // RVA: 0x7FFD54FF9C50
        public void UnityEngine.UIElements.IStyle.set_flexShrink(){} // RVA: 0x7FFD54FF9D10
        public void UnityEngine.UIElements.IStyle.set_fontSize(){} // RVA: 0x7FFD54FF9DD0
        public void UnityEngine.UIElements.IStyle.set_height(){} // RVA: 0x7FFD54FF9E40
        public void UnityEngine.UIElements.IStyle.set_left(){} // RVA: 0x7FFD54FF9F20
        public void UnityEngine.UIElements.IStyle.set_marginBottom(){} // RVA: 0x7FFD54FFA000
        public void UnityEngine.UIElements.IStyle.set_marginLeft(){} // RVA: 0x7FFD54FFA0E0
        public void UnityEngine.UIElements.IStyle.set_marginRight(){} // RVA: 0x7FFD54FFA1C0
        public void UnityEngine.UIElements.IStyle.set_marginTop(){} // RVA: 0x7FFD54FFA2A0
        public void UnityEngine.UIElements.IStyle.set_maxHeight(){} // RVA: 0x7FFD54FFA390
        public void UnityEngine.UIElements.IStyle.set_maxWidth(){} // RVA: 0x7FFD54FFA470
        public void UnityEngine.UIElements.IStyle.set_minWidth(){} // RVA: 0x7FFD54FFA550
        public void UnityEngine.UIElements.IStyle.set_opacity(){} // RVA: 0x7FFD54FFA630
        public void UnityEngine.UIElements.IStyle.set_overflow(){} // RVA: 0x7FFD54FFA690
        public void UnityEngine.UIElements.IStyle.set_paddingBottom(){} // RVA: 0x7FFD54FFA810
        public void UnityEngine.UIElements.IStyle.set_paddingLeft(){} // RVA: 0x7FFD54FFA900
        public void UnityEngine.UIElements.IStyle.set_paddingRight(){} // RVA: 0x7FFD54FFA9E0
        public void UnityEngine.UIElements.IStyle.get_paddingTop(){} // RVA: 0x7FFD54FFAAD0
        public void UnityEngine.UIElements.IStyle.set_paddingTop(){} // RVA: 0x7FFD54FFAB60
        public void UnityEngine.UIElements.IStyle.set_position(){} // RVA: 0x7FFD54FFAC50
        public void UnityEngine.UIElements.IStyle.set_right(){} // RVA: 0x7FFD54FFAD80
        public void UnityEngine.UIElements.IStyle.set_top(){} // RVA: 0x7FFD54FFAE70
        public void UnityEngine.UIElements.IStyle.set_unityBackgroundImageTintColor(){} // RVA: 0x7FFD54FFAF60
        public void UnityEngine.UIElements.IStyle.set_unityFont(){} // RVA: 0x7FFD54FFAFD0
        public void UnityEngine.UIElements.IStyle.set_unityFontDefinition(){} // RVA: 0x7FFD54FFB040
        public void UnityEngine.UIElements.IStyle.set_visibility(){} // RVA: 0x7FFD54FFB0C0
        public void UnityEngine.UIElements.IStyle.get_width(){} // RVA: 0x7FFD54FFB150
        public void UnityEngine.UIElements.IStyle.set_width(){} // RVA: 0x7FFD54FFB1E0
        public void get_ve(){} // RVA: 0x7FFD4E36F0C0
        public void set_ve(){} // RVA: 0x7FFD4E36F0D0
        public void .ctor(){} // RVA: 0x7FFD54FFB2C0
        public void Finalize(){} // RVA: 0x7FFD54FFB330
        public void SetInlineRule(){} // RVA: 0x7FFD54FFB470
        public void IsValueSet(){} // RVA: 0x7FFD54FFB6C0
        public void ApplyInlineStyles(){} // RVA: 0x7FFD54FFBAA0
        public void UnityEngine.UIElements.IStyle.get_cursor(){} // RVA: 0x7FFD54FFCAA0
        public void UnityEngine.UIElements.IStyle.get_textShadow(){} // RVA: 0x7FFD54FFCBE0
        public void UnityEngine.UIElements.IStyle.get_backgroundSize(){} // RVA: 0x7FFD54FFCC50
        public void UnityEngine.UIElements.IStyle.get_transformOrigin(){} // RVA: 0x7FFD54FFCCB0
        public void UnityEngine.UIElements.IStyle.get_translate(){} // RVA: 0x7FFD54FFCD00
        public void UnityEngine.UIElements.IStyle.set_translate(){} // RVA: 0x7FFD54FFCD60
        public void UnityEngine.UIElements.IStyle.get_rotate(){} // RVA: 0x7FFD54FFCFD0
        public void UnityEngine.UIElements.IStyle.get_scale(){} // RVA: 0x7FFD54FFD030
        public void SetStyleValue(){} // RVA: 0x7FFD54FFDA30 | overloaded x6
        public void SetInlineTranslate(){} // RVA: 0x7FFD54FFDD30
        public void ApplyStyleTranslate(){} // RVA: 0x7FFD54FFDEF0
        public void ApplyStyleValue(){} // RVA: 0x7FFD54FFE320
        public void RemoveInlineStyle(){} // RVA: 0x7FFD54FFE640
        public void ApplyFromComputedStyle(){} // RVA: 0x7FFD54FFE790
        public void TryGetInlineCursor(){} // RVA: 0x7FFD54FFE9A0
        public void TryGetInlineTextShadow(){} // RVA: 0x7FFD54FFEA10
        public void TryGetInlineTransformOrigin(){} // RVA: 0x7FFD54FFEA30
        public void TryGetInlineTranslate(){} // RVA: 0x7FFD54FFEA50
        public void TryGetInlineRotate(){} // RVA: 0x7FFD54FFEA80
        public void TryGetInlineScale(){} // RVA: 0x7FFD54FFEAB0
        public void TryGetInlineBackgroundSize(){} // RVA: 0x7FFD54FFEAE0
        public void .cctor(){} // RVA: 0x7FFD54FFEB10
    }

}