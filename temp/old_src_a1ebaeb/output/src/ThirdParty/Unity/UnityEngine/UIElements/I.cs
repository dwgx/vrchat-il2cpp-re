// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 29
// Methods: 283

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class IDragAndDropController`1
    {
        // ── Original Methods ──
        public void CanStartDrag(){} // RVA: 0x7ffaa864a2a0
        public void HandleDragAndDrop(){} // RVA: 0x7ffaa887e5c0
        public void OnDrop(){} // RVA: 0x7ffaa887e5c0
        public void DragCleanup(){} // RVA: 0x7ffaa8660cc0
        public void HandleAutoExpand(){}
        // ── Binary Analysis Named ──
        public void SetupDragAndDrop(){}
        public void GetSortedSelectedIds(){} // RVA: 0x7ffaa86491d0
    }

    public class IEventHandler
    {
        // ── Original Methods ──
        public void SendEvent(){} // RVA: 0x7ffaa8660d80
        public void HandleEvent(){} // RVA: 0x7ffaa8660d80
    }

    public class IExperimentalFeatures
    {
        // ── Original Methods ──
        public void get_animation(){} // RVA: 0x7ffaa86491d0
    }

    public class IGroupBox
    {
        // ── Original Methods ──
        public void OnOptionAdded(){} // RVA: 0x7ffaa8660d80
        public void OnOptionRemoved(){} // RVA: 0x7ffaa8660d80
    }

    public class IMGUIContainer : VisualElement
    {
        public object useOwnerObjectGUIState; // 0x35BC04D0
        public object m_IsFocusDelegated; // 0x35BC04D0
        public object m_CachedClippingRect; // 0x35BC04D0
        public object lostFocus; // 0x35BC04D0
        public object hasFocusableControls; // 0x35BC04D0
        public object ussClassName; // 0x35BC04D0
        public object m_GUIGlobals; // 0x35BC04D0
        public object s_DefaultMeasureEvent; // 0x35BC04D0
        public object matrix; // 0x35BC3610
        public object backgroundColor; // 0x35BC3610
        public object displayIndex; // 0x35BC3610
        public object Count; // 0x170008E2
        public object System.Collections.ICollection.IsSynchronized; // 0x170008E3
        public object System.Collections.ICollection.SyncRoot; // 0x170008E4

        // ── Original Methods ──
        public void get_onGUIHandler(){} // RVA: 0x7ffaaf5c09b0
        public void set_onGUIHandler(){} // RVA: 0x7ffaaf5c09c0
        public void get_guiState(){} // RVA: 0x7ffaaf5c0ac0
        public void get_lastWorldClip(){} // RVA: 0x7ffaaf5c0bf0
        public void set_lastWorldClip(){} // RVA: 0x7ffaaf5c0c00
        public void get_cullingEnabled(){} // RVA: 0x7ffaaf5c0c10
        public void get_cache(){} // RVA: 0x7ffaaf5c0c20
        public void get_layoutMeasuredWidth(){} // RVA: 0x7ffaaf5c0ce0
        public void get_layoutMeasuredHeight(){} // RVA: 0x7ffaaf5c0d10
        public void get_contextType(){} // RVA: 0x7ffaaf5c0d40
        public void set_contextType(){} // RVA: 0x7ffaaf5c0d50
        public void get_focusOnlyIfHasFocusableControls(){} // RVA: 0x7ffaaf5c0d60
        public void get_canGrabFocus(){} // RVA: 0x7ffaaf5c0d70
        public void .cctor(){} // RVA: 0x7ffaaf5c0da0
        public void .ctor(){} // RVA: 0x7ffaaf5c1640
        public void .ctor(){} // RVA: 0x7ffaaf5c1640
        public void OnGenerateVisualContent(){} // RVA: 0x7ffaaf5c1ac0
        public void SaveGlobals(){} // RVA: 0x7ffaaf5c1c20
        public void RestoreGlobals(){} // RVA: 0x7ffaaf5c2000
        public void MarkDirtyLayout(){} // RVA: 0x7ffaaf5c3ea0
        public void ProcessEvent(){} // RVA: 0x7ffaaf5c3ee0
        public void SendEventToIMGUI(){} // RVA: 0x7ffaaf5c4400
        public void SendEventToIMGUIRaw(){} // RVA: 0x7ffaaf5c4730
        public void VerifyBounds(){} // RVA: 0x7ffaaf5c47f0
        public void IsContainerCapturingTheMouse(){} // RVA: 0x7ffaaf5c4a50
        public void IsLocalEvent(){} // RVA: 0x7ffaaf5c4b20
        public void IsEventInsideLocalWindow(){} // RVA: 0x7ffaaf5c4d40
        public void IsDockAreaMouseUp(){} // RVA: 0x7ffaaf5c4f90
        public void HandleIMGUIEvent(){} // RVA: 0x7ffaaf5c5450
        public void HandleIMGUIEvent(){} // RVA: 0x7ffaaf5c5450
        public void HandleIMGUIEvent(){} // RVA: 0x7ffaaf5c5450
        public void ExecuteDefaultAction(){} // RVA: 0x7ffaaf5c59f0
        public void Dispose(){} // RVA: 0x7ffaaf5c6730
        public void Dispose(){} // RVA: 0x7ffaaf5c6730
        public void <DoOnGUI>b__56_0(){} // RVA: 0x7ffaaf5c67b0
        // ── Binary Analysis Named ──
        public void DoOnGUI(){} // RVA: 0x7ffaaf5c2400
        public void DoIMGUIRepaint(){} // RVA: 0x7ffaaf5c4090
        public void SetFoldoutDepthClass(){} // RVA: 0x7ffaaf5c5d60
        public void DoMeasure(){} // RVA: 0x7ffaaf5c5f20
        public void GetCurrentClipRect(){} // RVA: 0x7ffaaf5c63c0
        public void GetCurrentTransformAndClip(){} // RVA: 0x7ffaaf5c6440
    }

    public class INotifyValueChangedExtensions : Object
    {
        // ── Original Methods ──
        public void RegisterValueChangedCallback(){} // RVA: 0x7ffaa864a690
        public void UnregisterValueChangedCallback(){} // RVA: 0x7ffaa864a690
    }

    public class INotifyValueChanged`1
    {
        // ── Original Methods ──
        public void get_value(){} // RVA: 0x7ffaa887e5c0
        public void set_value(){} // RVA: 0x7ffaa887e5c0
        // ── Binary Analysis Named ──
        public void SetValueWithoutNotify(){} // RVA: 0x7ffaa887e5c0
    }

    public class IPanel
    {
        // ── Original Methods ──
        public void get_visualTree(){} // RVA: 0x7ffaa86491d0
        public void get_dispatcher(){} // RVA: 0x7ffaa86491d0
        public void get_contextType(){} // RVA: 0x7ffaa8649ca0
        public void get_focusController(){} // RVA: 0x7ffaa86491d0
        public void Pick(){}
    }

    public class IResolvedStyle
    {
        // ── Original Methods ──
        public void get_backgroundColor(){} // RVA: 0x7ffaa8648be0
        public void get_borderBottomColor(){} // RVA: 0x7ffaa8648be0
        public void get_borderBottomLeftRadius(){} // RVA: 0x7ffaa865dbc0
        public void get_borderBottomRightRadius(){} // RVA: 0x7ffaa865dbc0
        public void get_borderBottomWidth(){} // RVA: 0x7ffaa865dbc0
        public void get_borderLeftColor(){} // RVA: 0x7ffaa8648be0
        public void get_borderLeftWidth(){} // RVA: 0x7ffaa865dbc0
        public void get_borderRightColor(){} // RVA: 0x7ffaa8648be0
        public void get_borderRightWidth(){} // RVA: 0x7ffaa865dbc0
        public void get_borderTopColor(){} // RVA: 0x7ffaa8648be0
        public void get_borderTopLeftRadius(){} // RVA: 0x7ffaa865dbc0
        public void get_borderTopRightRadius(){} // RVA: 0x7ffaa865dbc0
        public void get_borderTopWidth(){} // RVA: 0x7ffaa865dbc0
        public void get_bottom(){} // RVA: 0x7ffaa865dbc0
        public void get_color(){} // RVA: 0x7ffaa8648be0
        public void get_display(){} // RVA: 0x7ffaa8649ca0
        public void get_flexDirection(){} // RVA: 0x7ffaa8649ca0
        public void get_flexGrow(){} // RVA: 0x7ffaa865dbc0
        public void get_flexShrink(){} // RVA: 0x7ffaa865dbc0
        public void get_height(){} // RVA: 0x7ffaa865dbc0
        public void get_left(){} // RVA: 0x7ffaa865dbc0
        public void get_marginBottom(){} // RVA: 0x7ffaa865dbc0
        public void get_marginLeft(){} // RVA: 0x7ffaa865dbc0
        public void get_marginRight(){} // RVA: 0x7ffaa865dbc0
        public void get_marginTop(){} // RVA: 0x7ffaa865dbc0
        public void get_minHeight(){}
        public void get_minWidth(){}
        public void get_opacity(){} // RVA: 0x7ffaa865dbc0
        public void get_paddingBottom(){} // RVA: 0x7ffaa865dbc0
        public void get_paddingLeft(){} // RVA: 0x7ffaa865dbc0
        public void get_paddingRight(){} // RVA: 0x7ffaa865dbc0
        public void get_paddingTop(){} // RVA: 0x7ffaa865dbc0
        public void get_right(){} // RVA: 0x7ffaa865dbc0
        public void get_scale(){}
        public void get_top(){} // RVA: 0x7ffaa865dbc0
        public void get_transformOrigin(){} // RVA: 0x7ffaa8648be0
        public void get_translate(){} // RVA: 0x7ffaa8648be0
        public void get_unityBackgroundImageTintColor(){} // RVA: 0x7ffaa8648be0
        public void get_unitySliceLeft(){} // RVA: 0x7ffaa8649ca0
        public void get_unitySliceRight(){} // RVA: 0x7ffaa8649ca0
        public void get_unitySliceScale(){} // RVA: 0x7ffaa865dbc0
        public void get_unityTextOutlineColor(){} // RVA: 0x7ffaa8648be0
        public void get_unityTextOutlineWidth(){} // RVA: 0x7ffaa865dbc0
        public void get_visibility(){} // RVA: 0x7ffaa8649ca0
        public void get_width(){} // RVA: 0x7ffaa865dbc0
    }

    public class IRuntimePanelComponent
    {
        // ── Original Methods ──
        public void set_panel(){} // RVA: 0x7ffaa8660d80
    }

    public class ISerializableJsonDictionary
    {
        // ── Original Methods ──
        public void Overwrite(){} // RVA: 0x7ffaa8669e70
        public void ContainsKey(){} // RVA: 0x7ffaa864a2a0
        // ── Binary Analysis Named ──
        public void Set(){} // RVA: 0x7ffaa887e5c0
        public void Get(){} // RVA: 0x7ffaa887e5c0
    }

    public class IStyleDataGroup`1
    {
        // ── Original Methods ──
        public void Copy(){} // RVA: 0x7ffaa887e5c0
        public void CopyFrom(){} // RVA: 0x7ffaa8660d80
    }

    public class IStyleDataGroup`1
    {
        // ── Original Methods ──
        public void Copy(){} // RVA: 0x7ffaa884bb60
        public void CopyFrom(){} // RVA: 0x7ffaa8660d80
    }

    public class IStyleDataGroup`1
    {
        // ── Original Methods ──
        public void Copy(){} // RVA: 0x7ffaa884bb60
        public void CopyFrom(){} // RVA: 0x7ffaa8660d80
    }

    public class IStyleDataGroup`1
    {
        // ── Original Methods ──
        public void Copy(){} // RVA: 0x7ffaa884bb60
        public void CopyFrom(){} // RVA: 0x7ffaa8660d80
    }

    public class IStyleDataGroup`1
    {
        // ── Original Methods ──
        public void Copy(){} // RVA: 0x7ffaa884bb60
        public void CopyFrom(){} // RVA: 0x7ffaa8660d80
    }

    public class IStyleDataGroup`1
    {
        // ── Original Methods ──
        public void Copy(){} // RVA: 0x7ffaa884bb60
        public void CopyFrom(){} // RVA: 0x7ffaa8660d80
    }

    public class IStyleDataGroup`1
    {
        // ── Original Methods ──
        public void Copy(){} // RVA: 0x7ffaa884bb60
        public void CopyFrom(){} // RVA: 0x7ffaa8660d80
    }

    public class IStyleDataGroup`1
    {
        // ── Original Methods ──
        public void Copy(){} // RVA: 0x7ffaa884bb60
        public void CopyFrom(){} // RVA: 0x7ffaa8660d80
    }

    public class IStylePropertyAnimations
    {
        // ── Original Methods ──
        public void Start(){}
        public void Start(){}
        public void Start(){}
        public void Start(){}
        public void StartEnum(){}
        public void Start(){}
        public void Start(){}
        public void Start(){}
        public void Start(){}
        public void Start(){}
        public void Start(){}
        public void Start(){}
        public void Start(){}
        public void Start(){}
        public void Start(){}
        public void Start(){}
        public void UpdateAnimation(){} // RVA: 0x7ffaa8661210
        public void CancelAnimation(){} // RVA: 0x7ffaa8661210
        public void CancelAllAnimations(){} // RVA: 0x7ffaa8660cc0
        public void get_runningAnimationCount(){} // RVA: 0x7ffaa8649ca0
        public void set_runningAnimationCount(){} // RVA: 0x7ffaa8661210
        public void get_completedAnimationCount(){} // RVA: 0x7ffaa8649ca0
        public void set_completedAnimationCount(){} // RVA: 0x7ffaa8661210
        // ── Binary Analysis Named ──
        public void GetAllAnimations(){} // RVA: 0x7ffaa8660d80
    }

    public class IStyleValue`1
    {
        // ── Original Methods ──
        public void get_value(){} // RVA: 0x7ffaa887e5c0
        public void get_keyword(){} // RVA: 0x7ffaa8649ca0
    }

    public class ITransform
    {
        // ── Original Methods ──
        public void get_position(){} // RVA: 0x7ffaa8648be0
        public void set_position(){} // RVA: 0x7ffaa8660d80
        public void get_scale(){} // RVA: 0x7ffaa8648be0
    }

    public class IUIElementsUtility
    {
        // ── Original Methods ──
        public void TakeCapture(){} // RVA: 0x7ffaa864a040
        public void ReleaseCapture(){} // RVA: 0x7ffaa864a040
        public void ProcessEvent(){}
        public void CleanupRoots(){} // RVA: 0x7ffaa864a040
        public void EndContainerGUIFromException(){} // RVA: 0x7ffaa864a2a0
        public void MakeCurrentIMGUIContainerDirty(){} // RVA: 0x7ffaa864a040
    }

    public class IUxmlObjectFactory`1
    {
        // ── Original Methods ──
        public void CreateObject(){} // RVA: 0x7ffaa887e5c0
    }

    public class IValueField`1
    {
        // ── Original Methods ──
        public void get_value(){} // RVA: 0x7ffaa887e5c0
        public void set_value(){} // RVA: 0x7ffaa887e5c0
        public void ApplyInputDeviceDelta(){} // RVA: 0x7ffaa887e5c0
        public void StartDragging(){} // RVA: 0x7ffaa8660cc0
        public void StopDragging(){} // RVA: 0x7ffaa8660cc0
    }

    public class IVisualElementScheduler
    {
        // ── Original Methods ──
        public void Execute(){} // RVA: 0x7ffaa8649280
        public void Execute(){} // RVA: 0x7ffaa8649280
    }

    public class Image : VisualElement
    {
        public object m_Sprite; // 0x317B8030
        public object m_TintColor; // 0x317B8030
        public object m_TintColorIsInline; // 0x317B8030
        public object s_SpriteProperty; // 0x317B8030
        public object s_TintColorProperty; // 0x317B8030

        // ── Original Methods ──
        public void get_image(){} // RVA: 0x7ffaa93ed7f0
        public void set_image(){} // RVA: 0x7ffaaf4da650
        public void get_sprite(){} // RVA: 0x7ffaa93d36d0
        public void set_sprite(){} // RVA: 0x7ffaaf4da860
        public void get_vectorImage(){} // RVA: 0x7ffaa93fe800
        public void set_vectorImage(){} // RVA: 0x7ffaaf4daa70
        public void get_sourceRect(){} // RVA: 0x7ffaaf4dac80
        public void get_uv(){} // RVA: 0x7ffaaf4dacb0
        public void set_uv(){} // RVA: 0x7ffaaf4dacc0
        public void get_scaleMode(){} // RVA: 0x7ffaaf4dad20
        public void get_tintColor(){} // RVA: 0x7ffaaf4dad30
        public void .ctor(){} // RVA: 0x7ffaaf4dad40
        public void OnGenerateVisualContent(){} // RVA: 0x7ffaaf4db7d0
        public void OnCustomStyleResolved(){} // RVA: 0x7ffaaf4dbff0
        public void ReadCustomProperties(){} // RVA: 0x7ffaaf4dc030
        public void ClearProperty(){} // RVA: 0x7ffaaf4dc670
        public void .cctor(){} // RVA: 0x7ffaaf4dca80
        // ── Binary Analysis Named ──
        public void GetTextureDisplaySize(){} // RVA: 0x7ffaaf4db0e0
        public void GetTextureDisplaySize(){} // RVA: 0x7ffaaf4db0e0
        public void DoMeasure(){} // RVA: 0x7ffaaf4db320
        public void SetProperty(){} // RVA: 0x7ffaa887e5c0
        public void SetScaleMode(){} // RVA: 0x7ffaaf4dc6c0
        public void SetTintColor(){} // RVA: 0x7ffaaf4dc710
        public void GetSourceRect(){} // RVA: 0x7ffaaf4dc7c0
    }

    public class InheritedData : ValueType
    {
        public object letterSpacing; // 0x35BD8820
        public object unityFontDefinition; // 0x35BD8820
        public object unityTextAlign; // 0x35BD8820
        public object visibility; // 0x35BD8820
        public object k_MaxValue; // 0x31491420
        public object offset; // 0x35BD8C80
        public object m_Font; // 0x35BD8E10

        // ── Original Methods ──
        public void Copy(){} // RVA: 0x7ffaaf617630
        public void CopyFrom(){} // RVA: 0x7ffaaf617680
        public void op_Equality(){} // RVA: 0x7ffaaf617740
        public void Equals(){} // RVA: 0x7ffaaf617f10
        public void Equals(){} // RVA: 0x7ffaaf617f10
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaaf618020
    }

    public class InlineStyleAccess : StyleValueCollection
    {
        public object _ve; // 0x317B93B0, was: <ve>k__BackingField
        public object m_HasInlineTextShadow; // 0x317B93B0
        public object m_InlineTransformOrigin; // 0x317B93B0
        public object m_HasInlineRotate; // 0x317B93B0
        public object m_InlineScale; // 0x317B93B0
        public object m_InlineRule; // 0x317B93B0
        public object m_Keyword; // 0x83A988A0
        public object m_Keyword; // 0x83A98A50
        public object m_Value; // 0x83A98390

        // ── Original Methods ──
        public void UnityEngine.UIElements.IStyle.set_backgroundColor(){} // RVA: 0x7ffaaf5faf80
        public void UnityEngine.UIElements.IStyle.set_borderBottomColor(){} // RVA: 0x7ffaaf5faff0
        public void UnityEngine.UIElements.IStyle.set_borderBottomLeftRadius(){} // RVA: 0x7ffaaf5fb060
        public void UnityEngine.UIElements.IStyle.set_borderBottomRightRadius(){} // RVA: 0x7ffaaf5fb0d0
        public void UnityEngine.UIElements.IStyle.set_borderBottomWidth(){} // RVA: 0x7ffaaf5fb140
        public void UnityEngine.UIElements.IStyle.set_borderLeftColor(){} // RVA: 0x7ffaaf5fb200
        public void UnityEngine.UIElements.IStyle.set_borderLeftWidth(){} // RVA: 0x7ffaaf5fb270
        public void UnityEngine.UIElements.IStyle.set_borderRightColor(){} // RVA: 0x7ffaaf5fb330
        public void UnityEngine.UIElements.IStyle.set_borderRightWidth(){} // RVA: 0x7ffaaf5fb3a0
        public void UnityEngine.UIElements.IStyle.set_borderTopColor(){} // RVA: 0x7ffaaf5fb460
        public void UnityEngine.UIElements.IStyle.set_borderTopLeftRadius(){} // RVA: 0x7ffaaf5fb4d0
        public void UnityEngine.UIElements.IStyle.set_borderTopRightRadius(){} // RVA: 0x7ffaaf5fb540
        public void UnityEngine.UIElements.IStyle.set_borderTopWidth(){} // RVA: 0x7ffaaf5fb5b0
        public void UnityEngine.UIElements.IStyle.set_bottom(){} // RVA: 0x7ffaaf5fb670
        public void UnityEngine.UIElements.IStyle.set_color(){} // RVA: 0x7ffaaf5fb750
        public void UnityEngine.UIElements.IStyle.get_display(){} // RVA: 0x7ffaaf5fb7c0
        public void UnityEngine.UIElements.IStyle.set_display(){} // RVA: 0x7ffaaf5fb880
        public void UnityEngine.UIElements.IStyle.set_flexBasis(){} // RVA: 0x7ffaaf5fb9b0
        public void UnityEngine.UIElements.IStyle.set_flexDirection(){} // RVA: 0x7ffaaf5fba90
        public void UnityEngine.UIElements.IStyle.set_flexGrow(){} // RVA: 0x7ffaaf5fbbc0
        public void UnityEngine.UIElements.IStyle.set_flexShrink(){} // RVA: 0x7ffaaf5fbc80
        public void UnityEngine.UIElements.IStyle.set_fontSize(){} // RVA: 0x7ffaaf5fbd40
        public void UnityEngine.UIElements.IStyle.set_height(){} // RVA: 0x7ffaaf5fbdb0
        public void UnityEngine.UIElements.IStyle.set_left(){} // RVA: 0x7ffaaf5fbe90
        public void UnityEngine.UIElements.IStyle.set_marginBottom(){} // RVA: 0x7ffaaf5fbf70
        public void UnityEngine.UIElements.IStyle.set_marginLeft(){} // RVA: 0x7ffaaf5fc050
        public void UnityEngine.UIElements.IStyle.set_marginRight(){} // RVA: 0x7ffaaf5fc130
        public void UnityEngine.UIElements.IStyle.set_marginTop(){} // RVA: 0x7ffaaf5fc210
        public void UnityEngine.UIElements.IStyle.set_maxHeight(){} // RVA: 0x7ffaaf5fc300
        public void UnityEngine.UIElements.IStyle.set_maxWidth(){} // RVA: 0x7ffaaf5fc3e0
        public void UnityEngine.UIElements.IStyle.set_minWidth(){} // RVA: 0x7ffaaf5fc4c0
        public void UnityEngine.UIElements.IStyle.set_opacity(){} // RVA: 0x7ffaaf5fc5a0
        public void UnityEngine.UIElements.IStyle.set_overflow(){} // RVA: 0x7ffaaf5fc600
        public void UnityEngine.UIElements.IStyle.set_paddingBottom(){} // RVA: 0x7ffaaf5fc780
        public void UnityEngine.UIElements.IStyle.set_paddingLeft(){} // RVA: 0x7ffaaf5fc870
        public void UnityEngine.UIElements.IStyle.set_paddingRight(){} // RVA: 0x7ffaaf5fc950
        public void UnityEngine.UIElements.IStyle.get_paddingTop(){} // RVA: 0x7ffaaf5fca40
        public void UnityEngine.UIElements.IStyle.set_paddingTop(){} // RVA: 0x7ffaaf5fcad0
        public void UnityEngine.UIElements.IStyle.set_position(){} // RVA: 0x7ffaaf5fcbc0
        public void UnityEngine.UIElements.IStyle.set_right(){} // RVA: 0x7ffaaf5fccf0
        public void UnityEngine.UIElements.IStyle.set_top(){} // RVA: 0x7ffaaf5fcde0
        public void UnityEngine.UIElements.IStyle.set_unityBackgroundImageTintColor(){} // RVA: 0x7ffaaf5fced0
        public void UnityEngine.UIElements.IStyle.set_unityFont(){} // RVA: 0x7ffaaf5fcf40
        public void UnityEngine.UIElements.IStyle.set_unityFontDefinition(){} // RVA: 0x7ffaaf5fcfb0
        public void UnityEngine.UIElements.IStyle.set_visibility(){} // RVA: 0x7ffaaf5fd030
        public void UnityEngine.UIElements.IStyle.get_width(){} // RVA: 0x7ffaaf5fd0c0
        public void UnityEngine.UIElements.IStyle.set_width(){} // RVA: 0x7ffaaf5fd150
        public void get_ve(){} // RVA: 0x7ffaa89600c0
        public void set_ve(){} // RVA: 0x7ffaa89600d0
        public void .ctor(){} // RVA: 0x7ffaaf5fd230
        public void Finalize(){} // RVA: 0x7ffaaf5fd2a0
        public void IsValueSet(){} // RVA: 0x7ffaaf5fd630
        public void ApplyInlineStyles(){} // RVA: 0x7ffaaf5fda10
        public void UnityEngine.UIElements.IStyle.get_cursor(){} // RVA: 0x7ffaaf5fea10
        public void UnityEngine.UIElements.IStyle.get_textShadow(){} // RVA: 0x7ffaaf5feb50
        public void UnityEngine.UIElements.IStyle.get_backgroundSize(){} // RVA: 0x7ffaaf5febc0
        public void UnityEngine.UIElements.IStyle.get_transformOrigin(){} // RVA: 0x7ffaaf5fec20
        public void UnityEngine.UIElements.IStyle.get_translate(){} // RVA: 0x7ffaaf5fec70
        public void UnityEngine.UIElements.IStyle.set_translate(){} // RVA: 0x7ffaaf5fecd0
        public void UnityEngine.UIElements.IStyle.get_rotate(){} // RVA: 0x7ffaaf5fef40
        public void UnityEngine.UIElements.IStyle.get_scale(){} // RVA: 0x7ffaaf5fefa0
        public void ApplyStyleTranslate(){} // RVA: 0x7ffaaf5ffe60
        public void ApplyStyleValue(){} // RVA: 0x7ffaaf600290
        public void RemoveInlineStyle(){} // RVA: 0x7ffaaf6005b0
        public void ApplyFromComputedStyle(){} // RVA: 0x7ffaaf600700
        public void TryGetInlineCursor(){} // RVA: 0x7ffaaf600910
        public void TryGetInlineTextShadow(){} // RVA: 0x7ffaaf600980
        public void TryGetInlineTransformOrigin(){} // RVA: 0x7ffaaf6009a0
        public void TryGetInlineTranslate(){} // RVA: 0x7ffaaf6009c0
        public void TryGetInlineRotate(){} // RVA: 0x7ffaaf6009f0
        public void TryGetInlineScale(){} // RVA: 0x7ffaaf600a20
        public void TryGetInlineBackgroundSize(){} // RVA: 0x7ffaaf600a50
        public void .cctor(){} // RVA: 0x7ffaaf600a80
        // ── Binary Analysis Named ──
        public void SetInlineRule(){} // RVA: 0x7ffaaf5fd3e0
        public void SetStyleValue(){} // RVA: 0x7ffaaf5ff9a0
        public void SetStyleValue(){} // RVA: 0x7ffaaf5ff9a0
        public void SetStyleValue(){} // RVA: 0x7ffaaf5ff9a0
        public void SetStyleValue(){} // RVA: 0x7ffaaf5ff9a0
        public void SetStyleValue(){} // RVA: 0x7ffaaf5ff9a0
        public void SetStyleValue(){} // RVA: 0x7ffaaf5ff9a0
        public void SetInlineTranslate(){} // RVA: 0x7ffaaf5ffca0
    }

}