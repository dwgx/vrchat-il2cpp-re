// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 36
// Methods: 361

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class Painter2D : Object
    {
        public UnityEngine.UIElements.MeshGenerationContext isPainterActive; // 0x10
        public UnityEngine.UIElements.UIR.DetachedAllocator maxArcRadius; // 0x18
        public UnityEngine.UIElements.SafeHandleAccess m_Handle; // 0x20
        public bool m_Disposed; // 0x28
        public bool <isPainterActive>k__BackingField;
        public float s_MaxArcRadius; // 0x4
        public Unity.Profiling.ProfilerMarker s_StrokeMarker; // 0x8
        public Unity.Profiling.ProfilerMarker s_FillMarker; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9BCD8D0
        public void Reset(){} // RVA: 0x7FFAC9BCDAD0
        public void Dispose(){} // RVA: 0x7FFAC9BCDCD0 | overloaded x2
        public void set_isPainterActive(){} // RVA: 0x7FFAC9BCDE10
        public void get_maxArcRadius(){} // RVA: 0x7FFAC9BCDE70
        public void .cctor(){} // RVA: 0x7FFAC9BCDF90
    }

    public class Panel : BaseVisualElementPanel
    {
        public UnityEngine.UIElements.VisualElement visualTree; // 0xA8
        public UnityEngine.UIElements.VisualTreeUpdater dispatcher; // 0xB0
        public UnityEngine.UIElements.IStylePropertyAnimationSystem timerEventScheduler; // 0xB8
        public string scheduler; // 0xC0
        public uint styleAnimationSystem; // 0xC8
        public uint ownerObject; // 0xCC
        public uint contextType; // 0xD0
        public Unity.Profiling.ProfilerMarker saveViewData; // 0xD8
        public Unity.Profiling.ProfilerMarker getViewDataDictionary; // 0xE0
        public Unity.Profiling.ProfilerMarker focusController; // 0xE8
        public Unity.Profiling.ProfilerMarker IMGUIEventInterests; // 0xF0
        public Unity.Profiling.ProfilerMarker loadResourceFunc; // 0xF8
        public Unity.Profiling.ProfilerMarker name;
        public UnityEngine.UIElements.EventDispatcher TimeSinceStartup; // 0x100
        public UnityEngine.UIElements.TimerEventScheduler IMGUIContainersCount; // 0x108
        public UnityEngine.ScriptableObject rootIMGUIContainer; // 0x110
        public 0x6B11FED0 version; // 0x118
        public UnityEngine.UIElements.SavePersistentViewData hierarchyVersion; // 0x120
        public UnityEngine.UIElements.GetViewDataDictionary standardShader; // 0x128
        public UnityEngine.UIElements.FocusController atlas; // 0x130
        public UnityEngine.EventInterests <IMGUIEventInterests>k__BackingField; // 0x138
        public UnityEngine.UIElements.LoadResourceFunction <loadResourceFunc>k__BackingField; // 0x8
        public bool m_JustReceivedFocus; // 0x13B
        public UnityEngine.UIElements.TimeMsFunction <TimeSinceStartup>k__BackingField; // 0x10
        public int <IMGUIContainersCount>k__BackingField; // 0x13C
        public UnityEngine.UIElements.IMGUIContainer <rootIMGUIContainer>k__BackingField; // 0x140
        public UnityEngine.Shader m_StandardShader; // 0x148
        public UnityEngine.UIElements.AtlasBase m_Atlas; // 0x150
        public bool m_ValidatingLayout; // 0x158
        public System.Action`1<UnityEngine.UIElements.Panel> beforeAnyRepaint; // 0x18

        // ── Methods ──
        public void get_visualTree(){} // RVA: 0x7FFAC991FDA0
        public void get_dispatcher(){} // RVA: 0x7FFAC34F6C80
        public void set_dispatcher(){} // RVA: 0x7FFAC34F6750
        public void get_timerEventScheduler(){} // RVA: 0x7FFAC9BA8310
        public void get_scheduler(){} // RVA: 0x7FFAC9BA8310
        public void get_styleAnimationSystem(){} // RVA: 0x7FFAC2F8C0B0
        public void set_styleAnimationSystem(){} // RVA: 0x7FFAC9BA83C0
        public void get_ownerObject(){} // RVA: 0x7FFAC354B170
        public void set_ownerObject(){} // RVA: 0x7FFAC39B3E10
        public void get_contextType(){} // RVA: 0x7FFAC49661E0
        public void set_contextType(){} // RVA: 0x7FFAC49661F0
        public void get_saveViewData(){} // RVA: 0x7FFAC313CBB0
        public void get_getViewDataDictionary(){} // RVA: 0x7FFAC35466F0
        public void get_focusController(){} // RVA: 0x7FFAC3544340
        public void set_focusController(){} // RVA: 0x7FFAC39A79B0
        public void get_IMGUIEventInterests(){} // RVA: 0x7FFAC9BA8480
        public void set_IMGUIEventInterests(){} // RVA: 0x7FFAC9BA84A0
        public void get_loadResourceFunc(){} // RVA: 0x7FFAC9BA84C0
        public void LoadResource(){} // RVA: 0x7FFAC9BA8520
        public void Focus(){} // RVA: 0x7FFAC9BA8630
        public void Blur(){} // RVA: 0x7FFAC9BA8640
        public void ValidateFocus(){} // RVA: 0x7FFAC9BA8760
        public void get_name(){} // RVA: 0x7FFAC991FEF0
        public void set_name(){} // RVA: 0x7FFAC9BA8830
        public void CreateMarkers(){} // RVA: 0x7FFAC9BA8890
        public void get_TimeSinceStartup(){} // RVA: 0x7FFAC9BA8D70
        public void get_IMGUIContainersCount(){} // RVA: 0x7FFAC88C7230
        public void set_IMGUIContainersCount(){} // RVA: 0x7FFAC88C7240
        public void get_rootIMGUIContainer(){} // RVA: 0x7FFAC2F8C5F0
        public void get_version(){} // RVA: 0x7FFAC3641480
        public void get_hierarchyVersion(){} // RVA: 0x7FFAC3696B20
        public void get_standardShader(){} // RVA: 0x7FFAC9BA8DD0
        public void get_atlas(){} // RVA: 0x7FFAC9BA8DE0
        public void set_atlas(){} // RVA: 0x7FFAC9BA8DF0
        public void .ctor(){} // RVA: 0x7FFAC9BA8ED0
        public void Dispose(){} // RVA: 0x7FFAC9BA9700
        public void TimeSinceStartupMs(){} // RVA: 0x7FFAC9BA9870
        public void DefaultTimeSinceStartupMs(){} // RVA: 0x7FFAC9BA9970
        public void PickAll(){} // RVA: 0x7FFAC9BA9DE0 | overloaded x2
        public void PerformPick(){} // RVA: 0x7FFAC9BA9A60
        public void Pick(){} // RVA: 0x7FFAC9BA9ED0
        public void ValidateLayout(){} // RVA: 0x7FFAC9BAA110
        public void UpdateAnimations(){} // RVA: 0x7FFAC9BAA190
        public void UpdateBindings(){} // RVA: 0x7FFAC9BAA1C0
        public void ApplyStyles(){} // RVA: 0x7FFAC9BAA1F0
        public void UpdateForRepaint(){} // RVA: 0x7FFAC9BAA220
        public void Repaint(){} // RVA: 0x7FFAC9BAA2B0
        public void OnVersionChanged(){} // RVA: 0x7FFAC9BAA710
        public void GetUpdater(){} // RVA: 0x7FFAC9BAA880
        public void .cctor(){} // RVA: 0x7FFAC9BAA8C0
        public void <Pick>g__PixelOf|101_0(){} // RVA: 0x7FFAC9BAA970
    }

    public class PanelChangedEventBase`1 : EventBase`1
    {
        public UnityEngine.UIElements.IPanel originPanel;
        public UnityEngine.UIElements.IPanel destinationPanel;

        // ── Methods ──
        public void get_originPanel(){} // RVA: 0x7FFAC2C58E90
        public void set_originPanel(){} // RVA: 0x7FFAC2C70A40
        public void get_destinationPanel(){} // RVA: 0x7FFAC2C58E90
        public void set_destinationPanel(){} // RVA: 0x7FFAC2C70A40
        public void Init(){} // RVA: 0x7FFAC2C70980
        public void LocalInit(){} // RVA: 0x7FFAC2C70980
        public void GetPooled(){} // RVA: 0x7FFAC2E8DC40
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class PanelClearSettings : ValueType
    {
        public bool clearDepthStencil; // 0x10
        public bool clearColor; // 0x11
        public UnityEngine.Color color; // 0x14
    }

    public class PanelEventHandler : UIBehaviour
    {
        public UnityEngine.UIElements.BaseRuntimePanel panel; // 0x20
        public PointerEvent selectableGameObject; // 0x28
        public float eventSystem; // 0x30
        public bool isCurrentFocusedPanel; // 0x34
        public UnityEngine.Event currentFocusedElement; // 0x38
        public 0x6B27F588 s_Modifiers;

        // ── Methods ──
        public void get_panel(){} // RVA: 0x7FFAC2F4F0C0
        public void set_panel(){} // RVA: 0x7FFAC9C76850
        public void get_selectableGameObject(){} // RVA: 0x7FFAC9C76930
        public void get_eventSystem(){} // RVA: 0x7FFAC9C76950
        public void get_isCurrentFocusedPanel(){} // RVA: 0x7FFAC9C76A40
        public void get_currentFocusedElement(){} // RVA: 0x7FFAC9C76C50
        public void OnEnable(){} // RVA: 0x7FFAC9C76C90
        public void OnDisable(){} // RVA: 0x7FFAC9C76CA0
        public void RegisterCallbacks(){} // RVA: 0x7FFAC9C76CB0
        public void UnregisterCallbacks(){} // RVA: 0x7FFAC9C76E80
        public void OnPanelDestroyed(){} // RVA: 0x7FFAC9C770A0
        public void OnElementFocus(){} // RVA: 0x7FFAC9C77150
        public void OnElementBlur(){} // RVA: 0x7FFAC2F21310
        public void OnSelect(){} // RVA: 0x7FFAC9C77260
        public void OnDeselect(){} // RVA: 0x7FFAC9C772A0
        public void OnPointerMove(){} // RVA: 0x7FFAC9C772C0
        public void OnPointerUp(){} // RVA: 0x7FFAC9C77410
        public void OnPointerDown(){} // RVA: 0x7FFAC9C77630
        public void OnPointerExit(){} // RVA: 0x7FFAC9C778D0
        public void OnPointerEnter(){} // RVA: 0x7FFAC9C77D80
        public void OnPointerClick(){} // RVA: 0x7FFAC9C77DF0
        public void OnSubmit(){} // RVA: 0x7FFAC9C77E50
        public void OnCancel(){} // RVA: 0x7FFAC9C78020
        public void OnMove(){} // RVA: 0x7FFAC9C781F0
        public void OnScroll(){} // RVA: 0x7FFAC9C78480
        public void SendEvent(){} // RVA: 0x7FFAC9C786E0 | overloaded x2
        public void Update(){} // RVA: 0x7FFAC9C78710
        public void LateUpdate(){} // RVA: 0x7FFAC9C78790
        public void ProcessImguiEvents(){} // RVA: 0x7FFAC9C787A0
        public void ProcessKeyboardEvent(){} // RVA: 0x7FFAC9C78980
        public void ProcessTabEvent(){} // RVA: 0x7FFAC9C78A80
        public void SendTabEvent(){} // RVA: 0x7FFAC9C78B30
        public void SendKeyUpEvent(){} // RVA: 0x7FFAC9C78D00
        public void SendKeyDownEvent(){} // RVA: 0x7FFAC9C78E70
        public void ReadPointerData(){} // RVA: 0x7FFAC9C78FE0
        public void .ctor(){} // RVA: 0x7FFAC9C79270
    }

    public class PanelRaycaster : BaseRaycaster
    {
        public UnityEngine.UIElements.BaseRuntimePanel panel; // 0x28

        // ── Methods ──
        public void get_panel(){} // RVA: 0x7FFAC2F4F130
        public void set_panel(){} // RVA: 0x7FFAC9C79C20
        public void RegisterCallbacks(){} // RVA: 0x7FFAC9C79DF0
        public void UnregisterCallbacks(){} // RVA: 0x7FFAC9C79E90
        public void OnPanelDestroyed(){} // RVA: 0x7FFAC9C79F30
        public void get_selectableGameObject(){} // RVA: 0x7FFAC9C79F40
        public void get_sortOrderPriority(){} // RVA: 0x7FFAC9C79F60
        public void get_renderOrderPriority(){} // RVA: 0x7FFAC9C79F80
        public void Raycast(){} // RVA: 0x7FFAC9C7A000
        public void get_eventCamera(){} // RVA: 0x7FFAC34F9180
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class PanelSettings : ScriptableObject
    {
        public int themeStyleSheet;
        public float targetTexture;
        public string scaleMode;
        public UnityEngine.UIElements.ThemeStyleSheet referenceSpritePixelsPerUnit; // 0x18
        public UnityEngine.RenderTexture scale; // 0x20
        public 0x6B11F060 referenceDpi; // 0x28
        public float fallbackDpi; // 0x2C
        public float referenceResolution; // 0x30
        public float screenMatchMode;
        public float match; // 0x34
        public float sortingOrder; // 0x38
        public UnityEngine.Vector2Int targetDisplay; // 0x3C
        public 0x6B11F0B8 clearDepthStencil; // 0x44
        public float depthClearValue; // 0x48
        public float clearColor; // 0x4C
        public int colorClearValue; // 0x50
        public bool panel; // 0x54
        public bool visualTree; // 0x55
        public UnityEngine.Color dynamicAtlasSettings; // 0x58
        public RuntimePanelAccess ScreenDPI; // 0x68
        public UnityEngine.UIElements.UIDocumentList m_AttachedUIDocumentsList; // 0x70
        public UnityEngine.UIElements.DynamicAtlasSettings m_DynamicAtlasSettings; // 0x78
        public UnityEngine.Shader m_AtlasBlitShader; // 0x80
        public UnityEngine.Shader m_RuntimeShader; // 0x88
        public UnityEngine.Shader m_RuntimeWorldShader; // 0x90
        public UnityEngine.UIElements.PanelTextSettings textSettings; // 0x98
        public UnityEngine.Rect m_TargetRect; // 0xA0
        public float m_ResolvedScale; // 0xB0
        public UnityEngine.UIElements.StyleSheet m_OldThemeUss; // 0xB8
        public float <ScreenDPI>k__BackingField; // 0xC0
        public System.Func`2<UnityEngine.Vector2,UnityEngine.Vector2> m_AssignedScreenToPanel; // 0xC8

        // ── Methods ──
        public void get_themeStyleSheet(){} // RVA: 0x7FFAC58A1130
        public void set_themeStyleSheet(){} // RVA: 0x7FFAC9B97470
        public void get_targetTexture(){} // RVA: 0x7FFAC2F4F0C0
        public void set_targetTexture(){} // RVA: 0x7FFAC9B974D0
        public void get_scaleMode(){} // RVA: 0x7FFAC32EC4C0
        public void set_scaleMode(){} // RVA: 0x7FFAC369A6E0
        public void get_referenceSpritePixelsPerUnit(){} // RVA: 0x7FFAC993FB10
        public void set_referenceSpritePixelsPerUnit(){} // RVA: 0x7FFAC33EA9D0
        public void get_scale(){} // RVA: 0x7FFAC3C40670
        public void set_scale(){} // RVA: 0x7FFAC47394E0
        public void get_referenceDpi(){} // RVA: 0x7FFAC2FEB630
        public void set_referenceDpi(){} // RVA: 0x7FFAC9B97540
        public void get_fallbackDpi(){} // RVA: 0x7FFAC3716E90
        public void set_fallbackDpi(){} // RVA: 0x7FFAC9B97570
        public void get_referenceResolution(){} // RVA: 0x7FFAC8A33E00
        public void set_referenceResolution(){} // RVA: 0x7FFAC8A33E10
        public void get_screenMatchMode(){} // RVA: 0x7FFAC2FC20A0
        public void set_screenMatchMode(){} // RVA: 0x7FFAC2FC20B0
        public void get_match(){} // RVA: 0x7FFAC45C0DE0
        public void set_match(){} // RVA: 0x7FFAC45C0F70
        public void get_sortingOrder(){} // RVA: 0x7FFAC3735280
        public void set_sortingOrder(){} // RVA: 0x7FFAC9B975A0
        public void ApplySortingOrder(){} // RVA: 0x7FFAC9B975F0
        public void get_targetDisplay(){} // RVA: 0x7FFAC30F10E0
        public void set_targetDisplay(){} // RVA: 0x7FFAC9B97630
        public void get_clearDepthStencil(){} // RVA: 0x7FFAC45A0C60
        public void set_clearDepthStencil(){} // RVA: 0x7FFAC45A1180
        public void get_depthClearValue(){} // RVA: 0x7FFAC9B97670
        public void get_clearColor(){} // RVA: 0x7FFAC45A1580
        public void set_clearColor(){} // RVA: 0x7FFAC45A1C60
        public void get_colorClearValue(){} // RVA: 0x7FFAC3BCB4D0
        public void set_colorClearValue(){} // RVA: 0x7FFAC9897890
        public void get_panel(){} // RVA: 0x7FFAC9B97680
        public void get_visualTree(){} // RVA: 0x7FFAC9B976A0
        public void get_dynamicAtlasSettings(){} // RVA: 0x7FFAC30E5600
        public void set_dynamicAtlasSettings(){} // RVA: 0x7FFAC30E06F0
        public void .ctor(){} // RVA: 0x7FFAC9B976E0
        public void Reset(){} // RVA: 0x7FFAC2F21310
        public void OnEnable(){} // RVA: 0x7FFAC9B97930
        public void OnDisable(){} // RVA: 0x7FFAC9B97AD0
        public void DisposePanel(){} // RVA: 0x7FFAC9B97AD0
        public void get_ScreenDPI(){} // RVA: 0x7FFAC88DEB20
        public void set_ScreenDPI(){} // RVA: 0x7FFAC893FD90
        public void UpdateScreenDPI(){} // RVA: 0x7FFAC9B97AF0
        public void ApplyThemeStyleSheet(){} // RVA: 0x7FFAC9B97B50
        public void InitializeShaders(){} // RVA: 0x7FFAC9B97EA0
        public void ApplyPanelSettings(){} // RVA: 0x7FFAC9B98270
        public void SetScreenToPanelSpaceFunction(){} // RVA: 0x7FFAC9B98DE0
        public void ResolveScale(){} // RVA: 0x7FFAC9B98F30
        public void GetDisplayRect(){} // RVA: 0x7FFAC9B99030
        public void AttachAndInsertUIDocumentToVisualTree(){} // RVA: 0x7FFAC9B991F0
        public void DetachUIDocument(){} // RVA: 0x7FFAC9B99360
    }

    public class PanelTextSettings : TextSettings
    {
        public UnityEngine.UIElements.PanelTextSettings defaultPanelTextSettings;
        public System.Func`2<string,UnityEngine.Object> EditorGUIUtilityLoad; // 0x8
        public System.Func`1<0x6B1795D8> GetCurrentLanguage; // 0x10
        public string s_DefaultEditorPanelTextSettingPath; // 0x18

        // ── Methods ──
        public void get_defaultPanelTextSettings(){} // RVA: 0x7FFAC9C0F4A0
        public void UpdateLocalizationFontAsset(){} // RVA: 0x7FFAC9C0F710
        public void GetCachedFontAsset(){} // RVA: 0x7FFAC9C0FE30
        public void .ctor(){} // RVA: 0x7FFAC9C0FE40
        public void .cctor(){} // RVA: 0x7FFAC9C0FE50
    }

    public class PointerCancelEvent : PointerEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC9B8FAD0
        public void Init(){} // RVA: 0x7FFAC9B8FBC0
        public void LocalInit(){} // RVA: 0x7FFAC9B8FC60
        public void .ctor(){} // RVA: 0x7FFAC9B8FCD0
        public void PostDispatch(){} // RVA: 0x7FFAC9B8FD70
    }

    public class PointerCaptureDispatchingStrategy : Object
    {
        // ── Methods ──
        public void CanDispatchEvent(){} // RVA: 0x7FFAC9B8C3E0
        public void DispatchEvent(){} // RVA: 0x7FFAC9B8C430
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class PointerCaptureEvent : PointerCaptureEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC9B7D0D0
        public void .ctor(){} // RVA: 0x7FFAC9B7D1C0
    }

    public class PointerCaptureEventBase`1 : EventBase`1
    {
        public UnityEngine.UIElements.IEventHandler relatedTarget;
        public int pointerId;

        // ── Methods ──
        public void set_relatedTarget(){} // RVA: 0x7FFAC2C70A40
        public void get_pointerId(){} // RVA: 0x7FFAC2C59960
        public void set_pointerId(){} // RVA: 0x7FFAC2C70ED0
        public void Init(){} // RVA: 0x7FFAC2C70980
        public void LocalInit(){} // RVA: 0x7FFAC2C70980
        public void GetPooled(){} // RVA: 0x7FFAC2E8DC40
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class PointerCaptureHelper : Object
    {
        // ── Methods ──
        public void GetStateFor(){} // RVA: 0x7FFAC9BAC710
        public void HasPointerCapture(){} // RVA: 0x7FFAC9BAC7C0
        public void CapturePointer(){} // RVA: 0x7FFAC9BAC820
        public void ReleasePointer(){} // RVA: 0x7FFAC9BACA50 | overloaded x2
        public void GetCapturingElement(){} // RVA: 0x7FFAC9BAC9C0
        public void ActivateCompatibilityMouseEvents(){} // RVA: 0x7FFAC9BACAD0
        public void PreventCompatibilityMouseEvents(){} // RVA: 0x7FFAC9BACB50
        public void ShouldSendCompatibilityMouseEvents(){} // RVA: 0x7FFAC9BACBD0
        public void ProcessPointerCapture(){} // RVA: 0x7FFAC9BACD30
    }

    public class PointerCaptureOutEvent : PointerCaptureEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC9B7CE90
        public void .ctor(){} // RVA: 0x7FFAC9B7CF80
    }

    public class PointerDeviceState : Object
    {
        public PointerLocation[] s_PlayerPointerLocations;
        public int[] s_PressedButtons; // 0x8
        public UnityEngine.UIElements.IPanel[] s_PlayerPanelWithSoftPointerCapture; // 0x10

        // ── Methods ──
        public void RemovePanelData(){} // RVA: 0x7FFAC9B8C8C0
        public void SavePointerPosition(){} // RVA: 0x7FFAC9B8CA80
        public void PressButton(){} // RVA: 0x7FFAC9B8CB30
        public void ReleaseButton(){} // RVA: 0x7FFAC9B8CC00
        public void ReleaseAllButtons(){} // RVA: 0x7FFAC9B8CCD0
        public void GetPointerPosition(){} // RVA: 0x7FFAC9B8CD50
        public void GetPanel(){} // RVA: 0x7FFAC9B8CDE0
        public void HasFlagFast(){} // RVA: 0x7FFAC9B8CE60
        public void HasLocationFlag(){} // RVA: 0x7FFAC9B8CE70
        public void GetPressedButtons(){} // RVA: 0x7FFAC9B8CF00
        public void HasAdditionalPressedButtons(){} // RVA: 0x7FFAC9B8CF80
        public void SetPlayerPanelWithSoftPointerCapture(){} // RVA: 0x7FFAC9B8D010
        public void GetPlayerPanelWithSoftPointerCapture(){} // RVA: 0x7FFAC9B8D0D0
        public void .cctor(){} // RVA: 0x7FFAC9B8D150
    }

    public class PointerDispatchState : Object
    {
        public UnityEngine.UIElements.IEventHandler[] m_PendingPointerCapture; // 0x10
        public UnityEngine.UIElements.IEventHandler[] m_PointerCapture; // 0x18
        public bool[] m_ShouldSendCompatibilityMouseEvents; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9BACDA0
        public void Reset(){} // RVA: 0x7FFAC9BAD0A0
        public void GetCapturingElement(){} // RVA: 0x7FFAC926F060
        public void HasPointerCapture(){} // RVA: 0x7FFAC9BAD1F0
        public void CapturePointer(){} // RVA: 0x7FFAC9BAD220
        public void ReleasePointer(){} // RVA: 0x7FFAC9BAD380 | overloaded x2
        public void ProcessPointerCapture(){} // RVA: 0x7FFAC9BAD3D0
        public void ActivateCompatibilityMouseEvents(){} // RVA: 0x7FFAC9BAD980
        public void PreventCompatibilityMouseEvents(){} // RVA: 0x7FFAC9BAD9B0
        public void ShouldSendCompatibilityMouseEvents(){} // RVA: 0x7FFAC9BAD9E0
    }

    public class PointerDownEvent : PointerEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC9B8E150
        public void Init(){} // RVA: 0x7FFAC9B8E240
        public void LocalInit(){} // RVA: 0x7FFAC9B8E2E0
        public void .ctor(){} // RVA: 0x7FFAC9B8E350
        public void PostDispatch(){} // RVA: 0x7FFAC9B8E3F0
    }

    public class PointerEnterEvent : PointerEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC9B90560
        public void Init(){} // RVA: 0x7FFAC9B90650
        public void LocalInit(){} // RVA: 0x7FFAC9B906A0
        public void .ctor(){} // RVA: 0x7FFAC9B906B0
    }

    public class PointerEventBase`1 : EventBase`1
    {
        public bool pointerId;
        public bool pointerType;
        public float isPrimary;
        public float button;
        public bool pressedButtons;
        public UnityEngine.Vector2 position;
        public int localPosition;
        public string deltaPosition;
        public bool deltaTime;
        public int clickCount;
        public int pressure;
        public UnityEngine.Vector3 tangentialPressure;
        public UnityEngine.Vector3 altitudeAngle;
        public UnityEngine.Vector3 azimuthAngle;
        public float twist;
        public int tilt;
        public float penStatus;
        public float radius;
        public float radiusVariance;
        public 0x6B2D9160 modifiers;
        public UnityEngine.Vector2 shiftKey;
        public UnityEngine.Vector2 ctrlKey;
        public 0x6B27F588 commandKey;
        public bool altKey;
        public bool actionKey;

        // ── Methods ──
        public void get_pointerId(){} // RVA: 0x7FFAC2C59960
        public void set_pointerId(){} // RVA: 0x7FFAC2C70ED0
        public void get_pointerType(){} // RVA: 0x7FFAC2C58E90
        public void set_pointerType(){} // RVA: 0x7FFAC2C70A40
        public void get_isPrimary(){} // RVA: 0x7FFAC2C59D00
        public void set_isPrimary(){} // RVA: 0x7FFAC2C71060
        public void get_button(){} // RVA: 0x7FFAC2C59960
        public void set_button(){} // RVA: 0x7FFAC2C70ED0
        public void get_pressedButtons(){} // RVA: 0x7FFAC2C59960
        public void set_pressedButtons(){} // RVA: 0x7FFAC2C70ED0
        public void get_position(){} // RVA: 0x7FFAC2C588A0
        public void set_position(){} // RVA: 0x7FFAC2C70A40
        public void get_localPosition(){} // RVA: 0x7FFAC2C588A0
        public void set_localPosition(){} // RVA: 0x7FFAC2C70A40
        public void get_deltaPosition(){} // RVA: 0x7FFAC2C588A0
        public void set_deltaPosition(){} // RVA: 0x7FFAC2C70A40
        public void get_deltaTime(){} // RVA: 0x7FFAC2C6D880
        public void set_deltaTime(){} // RVA: 0x7FFAC2C7E480
        public void get_clickCount(){} // RVA: 0x7FFAC2C59960
        public void set_clickCount(){} // RVA: 0x7FFAC2C70ED0
        public void get_pressure(){} // RVA: 0x7FFAC2C6D880
        public void set_pressure(){} // RVA: 0x7FFAC2C7E480
        public void get_tangentialPressure(){} // RVA: 0x7FFAC2C6D880
        public void set_tangentialPressure(){} // RVA: 0x7FFAC2C7E480
        public void get_altitudeAngle(){} // RVA: 0x7FFAC2C6D880
        public void set_altitudeAngle(){} // RVA: 0x7FFAC2C7E480
        public void get_azimuthAngle(){} // RVA: 0x7FFAC2C6D880
        public void set_azimuthAngle(){} // RVA: 0x7FFAC2C7E480
        public void get_twist(){} // RVA: 0x7FFAC2C6D880
        public void set_twist(){} // RVA: 0x7FFAC2C7E480
        public void get_tilt(){} // RVA: 0x7FFAC2C58E90
        public void set_tilt(){} // RVA: 0x7FFAC2C7F3E0
        public void get_penStatus(){} // RVA: 0x7FFAC2C59960
        public void set_penStatus(){} // RVA: 0x7FFAC2C70ED0
        public void get_radius(){} // RVA: 0x7FFAC2C58E90
        public void set_radius(){} // RVA: 0x7FFAC2C7F3E0
        public void get_radiusVariance(){} // RVA: 0x7FFAC2C58E90
        public void set_radiusVariance(){} // RVA: 0x7FFAC2C7F3E0
        public void get_modifiers(){} // RVA: 0x7FFAC2C59960
        public void set_modifiers(){} // RVA: 0x7FFAC2C70ED0
        public void get_shiftKey(){} // RVA: 0x7FFAC2C59D00
        public void get_ctrlKey(){} // RVA: 0x7FFAC2C59D00
        public void get_commandKey(){} // RVA: 0x7FFAC2C59D00
        public void get_altKey(){} // RVA: 0x7FFAC2C59D00
        public void get_actionKey(){} // RVA: 0x7FFAC2C59D00
        public void UnityEngine.UIElements.IPointerEventInternal.get_triggeredByOS(){} // RVA: 0x7FFAC2C59D00
        public void UnityEngine.UIElements.IPointerEventInternal.set_triggeredByOS(){} // RVA: 0x7FFAC2C71060
        public void UnityEngine.UIElements.IPointerEventInternal.get_recomputeTopElementUnderPointer(){} // RVA: 0x7FFAC2C59D00
        public void UnityEngine.UIElements.IPointerEventInternal.set_recomputeTopElementUnderPointer(){} // RVA: 0x7FFAC2C71060
        public void Init(){} // RVA: 0x7FFAC2C70980
        public void LocalInit(){} // RVA: 0x7FFAC2C70980
        public void get_currentTarget(){} // RVA: 0x7FFAC2C58E90
        public void set_currentTarget(){} // RVA: 0x7FFAC2C70A40
        public void IsMouse(){} // RVA: 0x7FFAC2C59DE0
        public void IsTouch(){} // RVA: 0x7FFAC2C59DE0
        public void TiltToAzimuth(){} // RVA: 0x7FFAC2C6EFE0
        public void AzimuthAndAlitutudeToTilt(){} // RVA: 0x7FFAC2E8DC40
        public void TiltToAltitude(){} // RVA: 0x7FFAC2C6EFE0
        public void GetPooled(){} // RVA: 0x7FFAC2E8DC40 | overloaded x6
        public void PreDispatch(){} // RVA: 0x7FFAC2C70A40
        public void PostDispatch(){} // RVA: 0x7FFAC2C70A40
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class PointerEventDispatchingStrategy : Object
    {
        // ── Methods ──
        public void CanDispatchEvent(){} // RVA: 0x7FFAC9B8D4A0
        public void DispatchEvent(){} // RVA: 0x7FFAC9B8D4F0
        public void SendEventToTarget(){} // RVA: 0x7FFAC9B8D5B0
        public void SetBestTargetForEvent(){} // RVA: 0x7FFAC9B8D660
        public void UpdateElementUnderPointer(){} // RVA: 0x7FFAC9B8D840
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class PointerEventHelper : Object
    {
        // ── Methods ──
        public void GetPooled(){} // RVA: 0x7FFAC9B8DFA0
    }

    public class PointerEventsHelper : Object
    {
        // ── Methods ──
        public void SendEnterLeave(){} // RVA: 0x7FFAC2E8DC40
        public void SendOverOut(){} // RVA: 0x7FFAC9B8A720
    }

    public class PointerId : Object
    {
        public int maxPointers;
        public int invalidPointerId; // 0x4
        public int mousePointerId; // 0x8
        public int touchPointerIdBase; // 0xC
        public int touchPointerCount; // 0x10
        public int penPointerIdBase; // 0x14
        public int penPointerCount; // 0x18
        public int[] hoveringPointers; // 0x20

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC9B8DE20
    }

    public class PointerLeaveEvent : PointerEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC9B90820
        public void Init(){} // RVA: 0x7FFAC9B90910
        public void LocalInit(){} // RVA: 0x7FFAC9B906A0
        public void .ctor(){} // RVA: 0x7FFAC9B90960
    }

    public class PointerManipulator : MouseManipulator
    {
        public int m_CurrentPointerId; // 0x30

        // ── Methods ──
        public void CanStartManipulation(){} // RVA: 0x7FFAC9BADA90
        public void CanStopManipulation(){} // RVA: 0x7FFAC9BADCC0
        public void .ctor(){} // RVA: 0x7FFAC9BADD30
    }

    public class PointerMoveEvent : PointerEventBase`1
    {
        public bool isHandledByDraggable; // 0x110

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC9B8E790
        public void get_isHandledByDraggable(){} // RVA: 0x7FFAC31E7D90
        public void set_isHandledByDraggable(){} // RVA: 0x7FFAC31E5C40
        public void Init(){} // RVA: 0x7FFAC9B8E880
        public void LocalInit(){} // RVA: 0x7FFAC9B8E8D0
        public void .ctor(){} // RVA: 0x7FFAC9B8E940
        public void PostDispatch(){} // RVA: 0x7FFAC9B8E990
    }

    public class PointerOutEvent : PointerEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC9B90D10
        public void .ctor(){} // RVA: 0x7FFAC9B90E00
    }

    public class PointerOverEvent : PointerEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC9B90AD0
        public void .ctor(){} // RVA: 0x7FFAC9B90BC0
    }

    public class PointerStationaryEvent : PointerEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC9B8EF40
        public void Init(){} // RVA: 0x7FFAC9B8F030
        public void LocalInit(){} // RVA: 0x7FFAC9B8F0D0
        public void .ctor(){} // RVA: 0x7FFAC9B8F140
    }

    public class PointerType : Object
    {
        public string mouse;
        public string touch; // 0x8
        public string pen; // 0x10
        public string unknown; // 0x18

        // ── Methods ──
        public void GetPointerType(){} // RVA: 0x7FFAC9B8DA50
        public void IsDirectManipulationDevice(){} // RVA: 0x7FFAC9B8DB60
        public void .cctor(){} // RVA: 0x7FFAC9B8DBF0
    }

    public class PointerUpEvent : PointerEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC9B8F350
        public void Init(){} // RVA: 0x7FFAC9B8F440
        public void LocalInit(){} // RVA: 0x7FFAC9B8F4E0
        public void .ctor(){} // RVA: 0x7FFAC9B8F550
        public void PostDispatch(){} // RVA: 0x7FFAC9B8F5F0
    }

    public class PopupField`1 : BasePopupField`2
    {
        public int value;
        public string index;
        public string labelUssClassName;
        public string inputUssClassName;

        // ── Methods ──
        public void GetValueToDisplay(){} // RVA: 0x7FFAC2C58E90
        public void GetListItemToDisplay(){} // RVA: 0x7FFAC2E8DC40
        public void get_value(){} // RVA: 0x7FFAC2E8DC40
        public void set_value(){} // RVA: 0x7FFAC2E8DC40
        public void SetValueWithoutNotify(){} // RVA: 0x7FFAC2E8DC40
        public void set_index(){} // RVA: 0x7FFAC2C70ED0
        public void .ctor(){} // RVA: 0x7FFAC2C70A40
        public void AddMenuItems(){} // RVA: 0x7FFAC2C70A40
        public void ChangeValueFromMenu(){} // RVA: 0x7FFAC2E8DC40
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
    }

    public class PopupWindow : TextElement
    {
        public UnityEngine.UIElements.VisualElement contentContainer; // 0x4A0
        public string ussClassName;
        public string contentUssClassName; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9B504A0
        public void get_contentContainer(){} // RVA: 0x7FFAC9AA16D0
        public void .cctor(){} // RVA: 0x7FFAC9B506D0
    }

    public class ProgressBar : AbstractProgressBar
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9B51DB0
    }

    public class ProjectionUtils : Object
    {
        // ── Methods ──
        public void Ortho(){} // RVA: 0x7FFAC9BADD40
    }

    public class PropagationPaths : Object
    {
        public UnityEngine.UIElements.ObjectPool`1<UnityEngine.UIElements.PropagationPaths> s_Pool;
        public System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement> trickleDownPath; // 0x10
        public System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement> targetElements; // 0x18
        public System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement> bubbleUpPath; // 0x20
        public int k_DefaultPropagationDepth;
        public int k_DefaultTargetCount;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9B90F50
        public void Build(){} // RVA: 0x7FFAC9B91250
        public void Release(){} // RVA: 0x7FFAC9B914B0
        public void .cctor(){} // RVA: 0x7FFAC9B915D0
    }

}