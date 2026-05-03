// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 36
// Methods: 361

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class Painter2D : Object
    {
        public UnityEngine.UIElements.MeshGenerationContext m_Ctx; // 0x10
        public UnityEngine.UIElements.UIR.DetachedAllocator m_DetachedAllocator; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87F76180
        public void Reset(){} // RVA: 0x7FFE87F76380
        public void Dispose(){} // RVA: 0x7FFE87F76580 | overloaded x2
        public void set_isPainterActive(){} // RVA: 0x7FFE87F766C0
        public void get_maxArcRadius(){} // RVA: 0x7FFE87F76720
        public void .cctor(){} // RVA: 0x7FFE87F76840
    }

    public class Panel : BaseVisualElementPanel
    {
        public UnityEngine.UIElements.VisualElement m_RootContainer; // 0xA8
        public UnityEngine.UIElements.VisualTreeUpdater m_VisualTreeUpdater; // 0xB0
        public UnityEngine.UIElements.IStylePropertyAnimationSystem m_StylePropertyAnimationSystem; // 0xB8
        public string m_PanelName; // 0xC0
        public uint m_Version; // 0xC8
        public uint m_RepaintVersion; // 0xCC
        public uint m_HierarchyVersion; // 0xD0
        public Unity.Profiling.ProfilerMarker m_MarkerBeforeUpdate; // 0xD8
        public Unity.Profiling.ProfilerMarker m_MarkerUpdate; // 0xE0
        public Unity.Profiling.ProfilerMarker m_MarkerLayout; // 0xE8
        public Unity.Profiling.ProfilerMarker m_MarkerBindings; // 0xF0
        public Unity.Profiling.ProfilerMarker m_MarkerAnimations; // 0xF8
        public Unity.Profiling.ProfilerMarker s_MarkerPickAll;
        public UnityEngine.UIElements.EventDispatcher _dispatcher; // 0x100
        public UnityEngine.UIElements.TimerEventScheduler m_Scheduler; // 0x108
        public UnityEngine.ScriptableObject _ownerObject; // 0x110
        public 0x66518DF4 _contextType; // 0x118
        public UnityEngine.UIElements.SavePersistentViewData _saveViewData; // 0x120
        public UnityEngine.UIElements.GetViewDataDictionary _getViewDataDictionary; // 0x128
        public UnityEngine.UIElements.FocusController _focusController; // 0x130

        // ── Methods ──
        public void get_visualTree(){} // RVA: 0x7FFE87CC8640
        public void get_dispatcher(){} // RVA: 0x7FFE81828B50
        public void set_dispatcher(){} // RVA: 0x7FFE81A58AB0
        public void get_timerEventScheduler(){} // RVA: 0x7FFE87F50BC0
        public void get_scheduler(){} // RVA: 0x7FFE87F50BC0
        public void get_styleAnimationSystem(){} // RVA: 0x7FFE811660B0
        public void set_styleAnimationSystem(){} // RVA: 0x7FFE87F50C70
        public void get_ownerObject(){} // RVA: 0x7FFE81317980
        public void set_ownerObject(){} // RVA: 0x7FFE813159A0
        public void get_contextType(){} // RVA: 0x7FFE812BC010
        public void set_contextType(){} // RVA: 0x7FFE82BD1CF0
        public void get_saveViewData(){} // RVA: 0x7FFE813A1DA0
        public void get_getViewDataDictionary(){} // RVA: 0x7FFE8182B890
        public void get_focusController(){} // RVA: 0x7FFE81823850
        public void set_focusController(){} // RVA: 0x7FFE81B31120
        public void get_IMGUIEventInterests(){} // RVA: 0x7FFE87F50D30
        public void set_IMGUIEventInterests(){} // RVA: 0x7FFE87F50D50
        public void get_loadResourceFunc(){} // RVA: 0x7FFE87F50D70
        public void LoadResource(){} // RVA: 0x7FFE87F50DD0
        public void Focus(){} // RVA: 0x7FFE87F50EE0
        public void Blur(){} // RVA: 0x7FFE87F50EF0
        public void ValidateFocus(){} // RVA: 0x7FFE87F51010
        public void get_name(){} // RVA: 0x7FFE87CC8790
        public void set_name(){} // RVA: 0x7FFE87F510E0
        public void CreateMarkers(){} // RVA: 0x7FFE87F51140
        public void get_TimeSinceStartup(){} // RVA: 0x7FFE87F51620
        public void get_IMGUIContainersCount(){} // RVA: 0x7FFE86C70920
        public void set_IMGUIContainersCount(){} // RVA: 0x7FFE86C70930
        public void get_rootIMGUIContainer(){} // RVA: 0x7FFE811665F0
        public void get_version(){} // RVA: 0x7FFE81790750
        public void get_hierarchyVersion(){} // RVA: 0x7FFE817E0030
        public void get_standardShader(){} // RVA: 0x7FFE87F51680
        public void get_atlas(){} // RVA: 0x7FFE87F51690
        public void set_atlas(){} // RVA: 0x7FFE87F516A0
        public void .ctor(){} // RVA: 0x7FFE87F51780
        public void Dispose(){} // RVA: 0x7FFE87F51FB0
        public void TimeSinceStartupMs(){} // RVA: 0x7FFE87F52120
        public void DefaultTimeSinceStartupMs(){} // RVA: 0x7FFE87F52220
        public void PickAll(){} // RVA: 0x7FFE87F52690 | overloaded x2
        public void PerformPick(){} // RVA: 0x7FFE87F52310
        public void Pick(){} // RVA: 0x7FFE87F52780
        public void ValidateLayout(){} // RVA: 0x7FFE87F529C0
        public void UpdateAnimations(){} // RVA: 0x7FFE87F52A40
        public void UpdateBindings(){} // RVA: 0x7FFE87F52A70
        public void ApplyStyles(){} // RVA: 0x7FFE87F52AA0
        public void UpdateForRepaint(){} // RVA: 0x7FFE87F52AD0
        public void Repaint(){} // RVA: 0x7FFE87F52B60
        public void OnVersionChanged(){} // RVA: 0x7FFE87F52FC0
        public void GetUpdater(){} // RVA: 0x7FFE87F53130
        public void .cctor(){} // RVA: 0x7FFE87F53170
        public void <Pick>g__PixelOf|101_0(){} // RVA: 0x7FFE87F53220
    }

    public class PanelChangedEventBase`1 : EventBase`1
    {
        public UnityEngine.UIElements.IPanel _originPanel;
        public UnityEngine.UIElements.IPanel _destinationPanel;

        // ── Methods ──
        public void get_originPanel(){} // RVA: 0x7FFE80E2E2E0
        public void set_originPanel(){} // RVA: 0x7FFE80E460A0
        public void get_destinationPanel(){} // RVA: 0x7FFE80E2E2E0
        public void set_destinationPanel(){} // RVA: 0x7FFE80E460A0
        public void Init(){} // RVA: 0x7FFE80E45FE0
        public void LocalInit(){} // RVA: 0x7FFE80E45FE0
        public void GetPooled(){} // RVA: 0x7FFE810A1420
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class PanelClearSettings : ValueType
    {
    }

    public class PanelEventHandler : UIBehaviour
    {
        public UnityEngine.UIElements.BaseRuntimePanel m_Panel; // 0x20
        public PointerEvent m_PointerEvent; // 0x28
        public float m_LastClickTime; // 0x30
        public bool m_Selecting; // 0x34
        public UnityEngine.Event m_Event; // 0x38

        // ── Methods ──
        public void get_panel(){} // RVA: 0x7FFE811290C0
        public void set_panel(){} // RVA: 0x7FFE8801F0A0
        public void get_selectableGameObject(){} // RVA: 0x7FFE8801F180
        public void get_eventSystem(){} // RVA: 0x7FFE8801F1A0
        public void get_isCurrentFocusedPanel(){} // RVA: 0x7FFE8801F290
        public void get_currentFocusedElement(){} // RVA: 0x7FFE8801F4A0
        public void OnEnable(){} // RVA: 0x7FFE8801F4E0
        public void OnDisable(){} // RVA: 0x7FFE8801F4F0
        public void RegisterCallbacks(){} // RVA: 0x7FFE8801F500
        public void UnregisterCallbacks(){} // RVA: 0x7FFE8801F6D0
        public void OnPanelDestroyed(){} // RVA: 0x7FFE8801F8F0
        public void OnElementFocus(){} // RVA: 0x7FFE8801F9A0
        public void OnElementBlur(){} // RVA: 0x7FFE810FB310
        public void OnSelect(){} // RVA: 0x7FFE8801FAB0
        public void OnDeselect(){} // RVA: 0x7FFE8801FAF0
        public void OnPointerMove(){} // RVA: 0x7FFE8801FB10
        public void OnPointerUp(){} // RVA: 0x7FFE8801FC60
        public void OnPointerDown(){} // RVA: 0x7FFE8801FE80
        public void OnPointerExit(){} // RVA: 0x7FFE88020120
        public void OnPointerEnter(){} // RVA: 0x7FFE880205D0
        public void OnPointerClick(){} // RVA: 0x7FFE88020640
        public void OnSubmit(){} // RVA: 0x7FFE880206A0
        public void OnCancel(){} // RVA: 0x7FFE88020870
        public void OnMove(){} // RVA: 0x7FFE88020A40
        public void OnScroll(){} // RVA: 0x7FFE88020CD0
        public void SendEvent(){} // RVA: 0x7FFE88020F30 | overloaded x2
        public void Update(){} // RVA: 0x7FFE88020F60
        public void LateUpdate(){} // RVA: 0x7FFE88020FE0
        public void ProcessImguiEvents(){} // RVA: 0x7FFE88020FF0
        public void ProcessKeyboardEvent(){} // RVA: 0x7FFE880211D0
        public void ProcessTabEvent(){} // RVA: 0x7FFE880212D0
        public void SendTabEvent(){} // RVA: 0x7FFE88021380
        public void SendKeyUpEvent(){} // RVA: 0x7FFE88021550
        public void SendKeyDownEvent(){} // RVA: 0x7FFE880216C0
        public void ReadPointerData(){} // RVA: 0x7FFE88021830
        public void .ctor(){} // RVA: 0x7FFE88021AC0
    }

    public class PanelRaycaster : BaseRaycaster
    {
        public UnityEngine.UIElements.BaseRuntimePanel m_Panel; // 0x28
        public object field_1; // 0x187
        public object field_2; // 0x188
        public object field_3; // 0x189
        public object field_4; // 0x18A

        // ── Methods ──
        public void get_panel(){} // RVA: 0x7FFE81129130
        public void set_panel(){} // RVA: 0x7FFE88022470
        public void RegisterCallbacks(){} // RVA: 0x7FFE88022640
        public void UnregisterCallbacks(){} // RVA: 0x7FFE880226E0
        public void OnPanelDestroyed(){} // RVA: 0x7FFE88022780
        public void get_selectableGameObject(){} // RVA: 0x7FFE88022790
        public void get_sortOrderPriority(){} // RVA: 0x7FFE880227B0
        public void get_renderOrderPriority(){} // RVA: 0x7FFE880227D0
        public void Raycast(){} // RVA: 0x7FFE88022850
        public void get_eventCamera(){} // RVA: 0x7FFE813240E0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class PanelSettings : ScriptableObject
    {
        public int k_DefaultSortingOrder;
        public float k_DefaultScaleValue;
        public string k_DefaultStyleSheetPath;
        public UnityEngine.UIElements.ThemeStyleSheet themeUss; // 0x18
        public UnityEngine.RenderTexture m_TargetTexture; // 0x20
        public 0x66517F84 m_ScaleMode; // 0x28
        public float m_ReferenceSpritePixelsPerUnit; // 0x2C
        public float m_Scale; // 0x30
        public float DefaultDpi;
        public float m_ReferenceDpi; // 0x34
        public float m_FallbackDpi; // 0x38
        public UnityEngine.Vector2Int m_ReferenceResolution; // 0x3C
        public 0x66517FDC m_ScreenMatchMode; // 0x44
        public float m_Match; // 0x48
        public float m_SortingOrder; // 0x4C
        public int m_TargetDisplay; // 0x50
        public bool m_ClearDepthStencil; // 0x54
        public bool m_ClearColor; // 0x55
        public UnityEngine.Color m_ColorClearValue; // 0x58
        public RuntimePanelAccess m_PanelAccess; // 0x68

        // ── Methods ──
        public void get_themeStyleSheet(){} // RVA: 0x7FFE83BBC680
        public void set_themeStyleSheet(){} // RVA: 0x7FFE87F3FD20
        public void get_targetTexture(){} // RVA: 0x7FFE811290C0
        public void set_targetTexture(){} // RVA: 0x7FFE87F3FD80
        public void get_scaleMode(){} // RVA: 0x7FFE81549710
        public void set_scaleMode(){} // RVA: 0x7FFE817E4800
        public void get_referenceSpritePixelsPerUnit(){} // RVA: 0x7FFE87CE83B0
        public void set_referenceSpritePixelsPerUnit(){} // RVA: 0x7FFE81670820
        public void get_scale(){} // RVA: 0x7FFE81284640
        public void set_scale(){} // RVA: 0x7FFE81308960
        public void get_referenceDpi(){} // RVA: 0x7FFE811C5630
        public void set_referenceDpi(){} // RVA: 0x7FFE87F3FDF0
        public void get_fallbackDpi(){} // RVA: 0x7FFE8130ACF0
        public void set_fallbackDpi(){} // RVA: 0x7FFE87F3FE20
        public void get_referenceResolution(){} // RVA: 0x7FFE86DDD480
        public void set_referenceResolution(){} // RVA: 0x7FFE86DDD490
        public void get_screenMatchMode(){} // RVA: 0x7FFE8119C0A0
        public void set_screenMatchMode(){} // RVA: 0x7FFE8119C0B0
        public void get_match(){} // RVA: 0x7FFE81C1C360
        public void set_match(){} // RVA: 0x7FFE81C1C2E0
        public void get_sortingOrder(){} // RVA: 0x7FFE81A74BC0
        public void set_sortingOrder(){} // RVA: 0x7FFE87F3FE50
        public void ApplySortingOrder(){} // RVA: 0x7FFE87F3FEA0
        public void get_targetDisplay(){} // RVA: 0x7FFE8139DAD0
        public void set_targetDisplay(){} // RVA: 0x7FFE87F3FEE0
        public void get_clearDepthStencil(){} // RVA: 0x7FFE8196FB30
        public void set_clearDepthStencil(){} // RVA: 0x7FFE8286F2D0
        public void get_depthClearValue(){} // RVA: 0x7FFE87F3FF20
        public void get_clearColor(){} // RVA: 0x7FFE8286E5B0
        public void set_clearColor(){} // RVA: 0x7FFE82870520
        public void get_colorClearValue(){} // RVA: 0x7FFE81E90B10
        public void set_colorClearValue(){} // RVA: 0x7FFE87C40190
        public void get_panel(){} // RVA: 0x7FFE87F3FF30
        public void get_visualTree(){} // RVA: 0x7FFE87F3FF50
        public void get_dynamicAtlasSettings(){} // RVA: 0x7FFE81463AE0
        public void set_dynamicAtlasSettings(){} // RVA: 0x7FFE81464570
        public void .ctor(){} // RVA: 0x7FFE87F3FF90
        public void Reset(){} // RVA: 0x7FFE810FB310
        public void OnEnable(){} // RVA: 0x7FFE87F401E0
        public void OnDisable(){} // RVA: 0x7FFE87F40380
        public void DisposePanel(){} // RVA: 0x7FFE87F40380
        public void get_ScreenDPI(){} // RVA: 0x7FFE86C88210
        public void set_ScreenDPI(){} // RVA: 0x7FFE86CE9430
        public void UpdateScreenDPI(){} // RVA: 0x7FFE87F403A0
        public void ApplyThemeStyleSheet(){} // RVA: 0x7FFE87F40400
        public void InitializeShaders(){} // RVA: 0x7FFE87F40750
        public void ApplyPanelSettings(){} // RVA: 0x7FFE87F40B20
        public void SetScreenToPanelSpaceFunction(){} // RVA: 0x7FFE87F41690
        public void ResolveScale(){} // RVA: 0x7FFE87F417E0
        public void GetDisplayRect(){} // RVA: 0x7FFE87F418E0
        public void AttachAndInsertUIDocumentToVisualTree(){} // RVA: 0x7FFE87F41AA0
        public void DetachUIDocument(){} // RVA: 0x7FFE87F41C10
    }

    public class PanelTextSettings : TextSettings
    {
        public UnityEngine.UIElements.PanelTextSettings s_DefaultPanelTextSettings;

        // ── Methods ──
        public void get_defaultPanelTextSettings(){} // RVA: 0x7FFE87FB7CF0
        public void UpdateLocalizationFontAsset(){} // RVA: 0x7FFE87FB7F60
        public void GetCachedFontAsset(){} // RVA: 0x7FFE87FB8680
        public void .ctor(){} // RVA: 0x7FFE87FB8690
        public void .cctor(){} // RVA: 0x7FFE87FB86A0
    }

    public class PointerCancelEvent : PointerEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE87F38380
        public void Init(){} // RVA: 0x7FFE87F38470
        public void LocalInit(){} // RVA: 0x7FFE87F38510
        public void .ctor(){} // RVA: 0x7FFE87F38580
        public void PostDispatch(){} // RVA: 0x7FFE87F38620
    }

    public class PointerCaptureDispatchingStrategy : Object
    {
        // ── Methods ──
        public void CanDispatchEvent(){} // RVA: 0x7FFE87F34C90
        public void DispatchEvent(){} // RVA: 0x7FFE87F34CE0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class PointerCaptureEvent : PointerCaptureEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE87F25980
        public void .ctor(){} // RVA: 0x7FFE87F25A70
    }

    public class PointerCaptureEventBase`1 : EventBase`1
    {
        public UnityEngine.UIElements.IEventHandler _relatedTarget;
        public int _pointerId;

        // ── Methods ──
        public void set_relatedTarget(){} // RVA: 0x7FFE80E460A0
        public void get_pointerId(){} // RVA: 0x7FFE80E2EDB0
        public void set_pointerId(){} // RVA: 0x7FFE80E46530
        public void Init(){} // RVA: 0x7FFE80E45FE0
        public void LocalInit(){} // RVA: 0x7FFE80E45FE0
        public void GetPooled(){} // RVA: 0x7FFE810A1420
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class PointerCaptureHelper : Object
    {
        // ── Methods ──
        public void GetStateFor(){} // RVA: 0x7FFE87F54FC0
        public void HasPointerCapture(){} // RVA: 0x7FFE87F55070
        public void CapturePointer(){} // RVA: 0x7FFE87F550D0
        public void ReleasePointer(){} // RVA: 0x7FFE87F55300 | overloaded x2
        public void GetCapturingElement(){} // RVA: 0x7FFE87F55270
        public void ActivateCompatibilityMouseEvents(){} // RVA: 0x7FFE87F55380
        public void PreventCompatibilityMouseEvents(){} // RVA: 0x7FFE87F55400
        public void ShouldSendCompatibilityMouseEvents(){} // RVA: 0x7FFE87F55480
        public void ProcessPointerCapture(){} // RVA: 0x7FFE87F555E0
    }

    public class PointerCaptureOutEvent : PointerCaptureEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE87F25740
        public void .ctor(){} // RVA: 0x7FFE87F25830
    }

    public class PointerDeviceState : Object
    {
        // ── Methods ──
        public void RemovePanelData(){} // RVA: 0x7FFE87F35170
        public void SavePointerPosition(){} // RVA: 0x7FFE87F35330
        public void PressButton(){} // RVA: 0x7FFE87F353E0
        public void ReleaseButton(){} // RVA: 0x7FFE87F354B0
        public void ReleaseAllButtons(){} // RVA: 0x7FFE87F35580
        public void GetPointerPosition(){} // RVA: 0x7FFE87F35600
        public void GetPanel(){} // RVA: 0x7FFE87F35690
        public void HasFlagFast(){} // RVA: 0x7FFE87F35710
        public void HasLocationFlag(){} // RVA: 0x7FFE87F35720
        public void GetPressedButtons(){} // RVA: 0x7FFE87F357B0
        public void HasAdditionalPressedButtons(){} // RVA: 0x7FFE87F35830
        public void SetPlayerPanelWithSoftPointerCapture(){} // RVA: 0x7FFE87F358C0
        public void GetPlayerPanelWithSoftPointerCapture(){} // RVA: 0x7FFE87F35980
        public void .cctor(){} // RVA: 0x7FFE87F35A00
    }

    public class PointerDispatchState : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87F55650
        public void Reset(){} // RVA: 0x7FFE87F55950
        public void GetCapturingElement(){} // RVA: 0x7FFE876177D0
        public void HasPointerCapture(){} // RVA: 0x7FFE87F55AA0
        public void CapturePointer(){} // RVA: 0x7FFE87F55AD0
        public void ReleasePointer(){} // RVA: 0x7FFE87F55C30 | overloaded x2
        public void ProcessPointerCapture(){} // RVA: 0x7FFE87F55C80
        public void ActivateCompatibilityMouseEvents(){} // RVA: 0x7FFE87F56230
        public void PreventCompatibilityMouseEvents(){} // RVA: 0x7FFE87F56260
        public void ShouldSendCompatibilityMouseEvents(){} // RVA: 0x7FFE87F56290
    }

    public class PointerDownEvent : PointerEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE87F36A00
        public void Init(){} // RVA: 0x7FFE87F36AF0
        public void LocalInit(){} // RVA: 0x7FFE87F36B90
        public void .ctor(){} // RVA: 0x7FFE87F36C00
        public void PostDispatch(){} // RVA: 0x7FFE87F36CA0
    }

    public class PointerEnterEvent : PointerEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE87F38E10
        public void Init(){} // RVA: 0x7FFE87F38F00
        public void LocalInit(){} // RVA: 0x7FFE87F38F50
        public void .ctor(){} // RVA: 0x7FFE87F38F60
    }

    public class PointerEventBase`1 : EventBase`1
    {
        public bool m_AltitudeNeedsConversion;
        public bool m_AzimuthNeedsConversion;
        public float m_AltitudeAngle;
        public float m_AzimuthAngle;
        public bool m_TiltNeeded;
        public UnityEngine.Vector2 m_Tilt;
        public int _pointerId;
        public string _pointerType;
        public bool _isPrimary;
        public int _button;
        public int _pressedButtons;
        public UnityEngine.Vector3 _position;
        public UnityEngine.Vector3 _localPosition;
        public UnityEngine.Vector3 _deltaPosition;
        public float _deltaTime;
        public int _clickCount;
        public float _pressure;
        public float _tangentialPressure;
        public float _twist;
        public 0x666D362C _penStatus;
        public UnityEngine.Vector2 _radius;
        public UnityEngine.Vector2 _radiusVariance;
        public 0x66679374 _modifiers;
        public bool _triggeredByOS;
        public bool _recomputeTopElementUnderPointer;
        public object field_25; // 0x264
        public object field_26; // 0x265
        public object field_27; // 0x266

        // ── Methods ──
        public void get_pointerId(){} // RVA: 0x7FFE80E2EDB0
        public void set_pointerId(){} // RVA: 0x7FFE80E46530
        public void get_pointerType(){} // RVA: 0x7FFE80E2E2E0
        public void set_pointerType(){} // RVA: 0x7FFE80E460A0
        public void get_isPrimary(){} // RVA: 0x7FFE80E2F150
        public void set_isPrimary(){} // RVA: 0x7FFE80E466C0
        public void get_button(){} // RVA: 0x7FFE80E2EDB0
        public void set_button(){} // RVA: 0x7FFE80E46530
        public void get_pressedButtons(){} // RVA: 0x7FFE80E2EDB0
        public void set_pressedButtons(){} // RVA: 0x7FFE80E46530
        public void get_position(){} // RVA: 0x7FFE80E2DCF0
        public void set_position(){} // RVA: 0x7FFE80E460A0
        public void get_localPosition(){} // RVA: 0x7FFE80E2DCF0
        public void set_localPosition(){} // RVA: 0x7FFE80E460A0
        public void get_deltaPosition(){} // RVA: 0x7FFE80E2DCF0
        public void set_deltaPosition(){} // RVA: 0x7FFE80E460A0
        public void get_deltaTime(){} // RVA: 0x7FFE80E42E10
        public void set_deltaTime(){} // RVA: 0x7FFE80E53B80
        public void get_clickCount(){} // RVA: 0x7FFE80E2EDB0
        public void set_clickCount(){} // RVA: 0x7FFE80E46530
        public void get_pressure(){} // RVA: 0x7FFE80E42E10
        public void set_pressure(){} // RVA: 0x7FFE80E53B80
        public void get_tangentialPressure(){} // RVA: 0x7FFE80E42E10
        public void set_tangentialPressure(){} // RVA: 0x7FFE80E53B80
        public void get_altitudeAngle(){} // RVA: 0x7FFE80E42E10
        public void set_altitudeAngle(){} // RVA: 0x7FFE80E53B80
        public void get_azimuthAngle(){} // RVA: 0x7FFE80E42E10
        public void set_azimuthAngle(){} // RVA: 0x7FFE80E53B80
        public void get_twist(){} // RVA: 0x7FFE80E42E10
        public void set_twist(){} // RVA: 0x7FFE80E53B80
        public void get_tilt(){} // RVA: 0x7FFE80E2E2E0
        public void set_tilt(){} // RVA: 0x7FFE80E54AE0
        public void get_penStatus(){} // RVA: 0x7FFE80E2EDB0
        public void set_penStatus(){} // RVA: 0x7FFE80E46530
        public void get_radius(){} // RVA: 0x7FFE80E2E2E0
        public void set_radius(){} // RVA: 0x7FFE80E54AE0
        public void get_radiusVariance(){} // RVA: 0x7FFE80E2E2E0
        public void set_radiusVariance(){} // RVA: 0x7FFE80E54AE0
        public void get_modifiers(){} // RVA: 0x7FFE80E2EDB0
        public void set_modifiers(){} // RVA: 0x7FFE80E46530
        public void get_shiftKey(){} // RVA: 0x7FFE80E2F150
        public void get_ctrlKey(){} // RVA: 0x7FFE80E2F150
        public void get_commandKey(){} // RVA: 0x7FFE80E2F150
        public void get_altKey(){} // RVA: 0x7FFE80E2F150
        public void get_actionKey(){} // RVA: 0x7FFE80E2F150
        public void UnityEngine.UIElements.IPointerEventInternal.get_triggeredByOS(){} // RVA: 0x7FFE80E2F150
        public void UnityEngine.UIElements.IPointerEventInternal.set_triggeredByOS(){} // RVA: 0x7FFE80E466C0
        public void UnityEngine.UIElements.IPointerEventInternal.get_recomputeTopElementUnderPointer(){} // RVA: 0x7FFE80E2F150
        public void UnityEngine.UIElements.IPointerEventInternal.set_recomputeTopElementUnderPointer(){} // RVA: 0x7FFE80E466C0
        public void Init(){} // RVA: 0x7FFE80E45FE0
        public void LocalInit(){} // RVA: 0x7FFE80E45FE0
        public void get_currentTarget(){} // RVA: 0x7FFE80E2E2E0
        public void set_currentTarget(){} // RVA: 0x7FFE80E460A0
        public void IsMouse(){} // RVA: 0x7FFE80E2F230
        public void IsTouch(){} // RVA: 0x7FFE80E2F230
        public void TiltToAzimuth(){} // RVA: 0x7FFE80E44630
        public void AzimuthAndAlitutudeToTilt(){} // RVA: 0x7FFE810A1420
        public void TiltToAltitude(){} // RVA: 0x7FFE80E44630
        public void GetPooled(){} // RVA: 0x7FFE810A1420 | overloaded x6
        public void PreDispatch(){} // RVA: 0x7FFE80E460A0
        public void PostDispatch(){} // RVA: 0x7FFE80E460A0
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class PointerEventDispatchingStrategy : Object
    {
        // ── Methods ──
        public void CanDispatchEvent(){} // RVA: 0x7FFE87F35D50
        public void DispatchEvent(){} // RVA: 0x7FFE87F35DA0
        public void SendEventToTarget(){} // RVA: 0x7FFE87F35E60
        public void SetBestTargetForEvent(){} // RVA: 0x7FFE87F35F10
        public void UpdateElementUnderPointer(){} // RVA: 0x7FFE87F360F0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class PointerEventHelper : Object
    {
        // ── Methods ──
        public void GetPooled(){} // RVA: 0x7FFE87F36850
    }

    public class PointerEventsHelper : Object
    {
        // ── Methods ──
        public void SendEnterLeave(){} // RVA: 0x7FFE810A1420
        public void SendOverOut(){} // RVA: 0x7FFE87F32FD0
    }

    public class PointerId : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE87F366D0
    }

    public class PointerLeaveEvent : PointerEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE87F390D0
        public void Init(){} // RVA: 0x7FFE87F391C0
        public void LocalInit(){} // RVA: 0x7FFE87F38F50
        public void .ctor(){} // RVA: 0x7FFE87F39210
    }

    public class PointerManipulator : MouseManipulator
    {
        // ── Methods ──
        public void CanStartManipulation(){} // RVA: 0x7FFE87F56340
        public void CanStopManipulation(){} // RVA: 0x7FFE87F56570
        public void .ctor(){} // RVA: 0x7FFE87F565E0
    }

    public class PointerMoveEvent : PointerEventBase`1
    {
        public bool _isHandledByDraggable; // 0x110

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE87F37040
        public void get_isHandledByDraggable(){} // RVA: 0x7FFE81472650
        public void set_isHandledByDraggable(){} // RVA: 0x7FFE81472660
        public void Init(){} // RVA: 0x7FFE87F37130
        public void LocalInit(){} // RVA: 0x7FFE87F37180
        public void .ctor(){} // RVA: 0x7FFE87F371F0
        public void PostDispatch(){} // RVA: 0x7FFE87F37240
    }

    public class PointerOutEvent : PointerEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE87F395C0
        public void .ctor(){} // RVA: 0x7FFE87F396B0
    }

    public class PointerOverEvent : PointerEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE87F39380
        public void .ctor(){} // RVA: 0x7FFE87F39470
    }

    public class PointerStationaryEvent : PointerEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE87F377F0
        public void Init(){} // RVA: 0x7FFE87F378E0
        public void LocalInit(){} // RVA: 0x7FFE87F37980
        public void .ctor(){} // RVA: 0x7FFE87F379F0
    }

    public class PointerType : Object
    {
        // ── Methods ──
        public void GetPointerType(){} // RVA: 0x7FFE87F36300
        public void IsDirectManipulationDevice(){} // RVA: 0x7FFE87F36410
        public void .cctor(){} // RVA: 0x7FFE87F364A0
    }

    public class PointerUpEvent : PointerEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE87F37C00
        public void Init(){} // RVA: 0x7FFE87F37CF0
        public void LocalInit(){} // RVA: 0x7FFE87F37D90
        public void .ctor(){} // RVA: 0x7FFE87F37E00
        public void PostDispatch(){} // RVA: 0x7FFE87F37EA0
    }

    public class PopupField`1 : BasePopupField`2
    {
        public int m_Index;
        public string ussClassName;

        // ── Methods ──
        public void GetValueToDisplay(){} // RVA: 0x7FFE80E2E2E0
        public void GetListItemToDisplay(){} // RVA: 0x7FFE810A1420
        public void get_value(){} // RVA: 0x7FFE810A1420
        public void set_value(){} // RVA: 0x7FFE810A1420
        public void SetValueWithoutNotify(){} // RVA: 0x7FFE810A1420
        public void set_index(){} // RVA: 0x7FFE80E46530
        public void .ctor(){} // RVA: 0x7FFE80E460A0
        public void AddMenuItems(){} // RVA: 0x7FFE80E460A0
        public void ChangeValueFromMenu(){} // RVA: 0x7FFE810A1420
        public void .cctor(){} // RVA: 0x7FFE80E46010
    }

    public class PopupWindow : TextElement
    {
        public UnityEngine.UIElements.VisualElement m_ContentContainer; // 0x4A0

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87EF8D40
        public void get_contentContainer(){} // RVA: 0x7FFE87E49F70
        public void .cctor(){} // RVA: 0x7FFE87EF8F70
    }

    public class ProgressBar : AbstractProgressBar
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87EFA650
    }

    public class ProjectionUtils : Object
    {
        // ── Methods ──
        public void Ortho(){} // RVA: 0x7FFE87F565F0
    }

    public class PropagationPaths : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87F39800
        public void Build(){} // RVA: 0x7FFE87F39B00
        public void Release(){} // RVA: 0x7FFE87F39D60
        public void .cctor(){} // RVA: 0x7FFE87F39E80
    }

}