// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 60
// Methods: 1367

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class Painter2D : Object
    {
        public object m_Ctx;
        public object m_DetachedAllocator;
        public object m_Handle;
        public object m_JobSnapshots;
        public object m_JobParameters;
        public object m_Disposed;
        public object _isPainterActive;
        public object s_StrokeMarker;
        public object s_FillMarker;
        public object m_OnMeshGenerationDelegate;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x80AACB0
        public void Reset(){} // RVA: 0x80AAF10
        public void Dispose(){} // RVA: 0x80AB140
        public void set_isPainterActive(){} // RVA: 0x80AB2B0
        public void ScheduleJobs(){} // RVA: 0x80AB310
        public void OnMeshGeneration(){} // RVA: 0x80AB850
        public void .cctor(){} // RVA: 0x80AB8E0
    }

    public class Panel : BaseVisualElementPanel
    {
        public object k_DefaultPixelsPerUnit;
        public object m_RootContainer;
        public object m_VisualTreeUpdater;
        public object m_StylePropertyAnimationSystem;
        public object m_PanelName;
        public object m_Version;
        public object m_RepaintVersion;
        public object m_HierarchyVersion;
        public object m_MarkerBeforeUpdate;
        public object m_MarkerUpdate;
        public object m_MarkerRender;
        public object m_MarkerLayout;
        public object m_MarkerBindings;
        public object m_MarkerDataBinding;
        public object m_MarkerAnimations;
        public object m_MarkerPanelChangeReceiver;
        public object s_MarkerPickAll;
        public object _dispatcher;
        public object m_Scheduler;
        public object _ownerObject;
        public object _contextType;
        public object _saveViewData;
        public object _getViewDataDictionary;
        public object _focusController;
        public object _iMGUIEventInterests;
        public object _loadResourceFunc;
        public object m_JustReceivedFocus;
        public object m_PanelChangeReceiver;
        public object _timeSinceStartup;
        public object _iMGUIContainersCount;
        public object _rootIMGUIContainer;
        public object m_Atlas;
        public object m_ValidatingLayout;
        public object beforeAnyRepaint;

        // ── Methods ──
        public void get_visualTree(){} // RVA: 0x7C7E920
        public void get_dispatcher(){} // RVA: 0x12CDBF0
        public void set_dispatcher(){} // RVA: 0x164A230
        public void get_timerEventScheduler(){} // RVA: 0x8086300
        public void get_scheduler(){} // RVA: 0x8086300
        public void get_styleAnimationSystem(){} // RVA: 0xBAE5A0
        public void set_styleAnimationSystem(){} // RVA: 0x80863B0
        public void get_ownerObject(){} // RVA: 0x1143F90
        public void set_ownerObject(){} // RVA: 0x113E310
        public void get_contextType(){} // RVA: 0x79FAAD0
        public void get_saveViewData(){} // RVA: 0x10F9C30
        public void get_getViewDataDictionary(){} // RVA: 0x10F9390
        public void get_focusController(){} // RVA: 0x165EBC0
        public void set_focusController(){} // RVA: 0x1651590
        public void get_IMGUIEventInterests(){} // RVA: 0x8086470
        public void set_IMGUIEventInterests(){} // RVA: 0x8086490
        public void get_loadResourceFunc(){} // RVA: 0x80864B0
        public void LoadResource(){} // RVA: 0x8086510
        public void Focus(){} // RVA: 0x8086620
        public void Blur(){} // RVA: 0x8086630
        public void ValidateFocus(){} // RVA: 0x8086750
        public void get_name(){} // RVA: 0x8086820
        public void set_name(){} // RVA: 0x8086830
        public void get_panelChangeReceiver(){} // RVA: 0x13659D0
        public void set_panelChangeReceiver(){} // RVA: 0x8086890
        public void CreateMarkers(){} // RVA: 0x8086980
        public void get_TimeSinceStartup(){} // RVA: 0x8086C20
        public void get_IMGUIContainersCount(){} // RVA: 0x78F9B90
        public void set_IMGUIContainersCount(){} // RVA: 0x78F9BA0
        public void get_rootIMGUIContainer(){} // RVA: 0x1664460
        public void get_version(){} // RVA: 0x2643A30
        public void get_hierarchyVersion(){} // RVA: 0x23B3150
        public void get_atlas(){} // RVA: 0x8086C80
        public void set_atlas(){} // RVA: 0x8086C90
        public void .ctor(){} // RVA: 0x8086D70
        public void Dispose(){} // RVA: 0x8087420
        public void TimeSinceStartupMs(){} // RVA: 0x80875D0
        public void DefaultTimeSinceStartupMs(){} // RVA: 0x80876D0
        public void PickAll(){} // RVA: 0x8087B40
        public void PerformPick(){} // RVA: 0x80877C0
        public void Pick(){} // RVA: 0x8087C30
        public void ValidateLayout(){} // RVA: 0x8087E50
        public void UpdateAnimations(){} // RVA: 0x8087ED0
        public void UpdateBindings(){} // RVA: 0x8087F00
        public void ApplyStyles(){} // RVA: 0x8087F30
        public void UpdateForRepaint(){} // RVA: 0x8087F60
        public void Repaint(){} // RVA: 0x8088000
        public void Render(){} // RVA: 0x8086170
        public void OnVersionChanged(){} // RVA: 0x8088310
        public void SetUpdater(){} // RVA: 0x8088580
        public void GetUpdater(){} // RVA: 0x8088650
        public void .cctor(){} // RVA: 0x8088690
        public void <Pick>g__PixelOf|105_0(){} // RVA: 0x7BECDF0
    }

    public class PanelChangedEventBase`1 : EventBase`1
    {
        public object _originPanel;
        public object _destinationPanel;

        // ── Methods ──
        public void get_originPanel(){} // RVA: 0x87C0A0
        public void set_originPanel(){} // RVA: 0x894320
        public void get_destinationPanel(){} // RVA: 0x87C0A0
        public void set_destinationPanel(){} // RVA: 0x894320
        public void Init(){} // RVA: 0x894290
        public void LocalInit(){} // RVA: 0x894290
        public void GetPooled(){} // RVA: 0xA94080
        public void .ctor(){} // RVA: 0x894290
    }

    public class PanelChangedEventBase`1 : EventBase`1
    {
        public object _originPanel;
        public object _destinationPanel;

        // ── Methods ──
        public void get_originPanel(){} // RVA: 0xBBFF90
        public void set_originPanel(){} // RVA: 0xBBFFA0
        public void get_destinationPanel(){} // RVA: 0xC10050
        public void set_destinationPanel(){} // RVA: 0xC10060
        public void Init(){} // RVA: 0x4849560
        public void LocalInit(){} // RVA: 0x48495F0
        public void GetPooled(){} // RVA: 0x48496A0
        public void .ctor(){} // RVA: 0x4849820
    }

    public class PanelChangedEventBase`1 : EventBase`1
    {
        public object _originPanel;
        public object _destinationPanel;

        // ── Methods ──
        public void get_originPanel(){} // RVA: 0xBBFF90
        public void set_originPanel(){} // RVA: 0xBBFFA0
        public void get_destinationPanel(){} // RVA: 0xC10050
        public void set_destinationPanel(){} // RVA: 0xC10060
        public void Init(){} // RVA: 0x4849560
        public void LocalInit(){} // RVA: 0x48495F0
        public void GetPooled(){} // RVA: 0x48496A0
        public void .ctor(){} // RVA: 0x4849820
    }

    public class PanelEventHandler : UIBehaviour
    {
        public object m_Panel;
        public object m_PointerEvent;
        public object m_LastClickTime;
        public object m_Selecting;
        public object m_Event;
        public object s_Modifiers;

        // ── Methods ──
        public void get_panel(){} // RVA: 0xB700F0
        public void set_panel(){} // RVA: 0x810BBD0
        public void get_selectableGameObject(){} // RVA: 0x810BCB0
        public void get_eventSystem(){} // RVA: 0x810BCD0
        public void get_isCurrentFocusedPanel(){} // RVA: 0x810BDB0
        public void get_currentFocusedElement(){} // RVA: 0x810BFC0
        public void OnEnable(){} // RVA: 0x810C000
        public void OnDisable(){} // RVA: 0x810C010
        public void RegisterCallbacks(){} // RVA: 0x810C020
        public void UnregisterCallbacks(){} // RVA: 0x810C1F0
        public void OnPanelDestroyed(){} // RVA: 0x810C540
        public void OnElementFocus(){} // RVA: 0x810C5F0
        public void OnElementBlur(){} // RVA: 0xB43310
        public void OnSelect(){} // RVA: 0x810C700
        public void OnDeselect(){} // RVA: 0x810C740
        public void OnPointerMove(){} // RVA: 0x810C760
        public void OnPointerUp(){} // RVA: 0x810C8B0
        public void OnPointerDown(){} // RVA: 0x810CA80
        public void OnPointerExit(){} // RVA: 0x810CD30
        public void OnPointerEnter(){} // RVA: 0x810D1C0
        public void OnPointerClick(){} // RVA: 0x810D230
        public void OnSubmit(){} // RVA: 0x810D290
        public void OnCancel(){} // RVA: 0x810D470
        public void OnMove(){} // RVA: 0x810D650
        public void OnScroll(){} // RVA: 0x810D8E0
        public void SendEvent(){} // RVA: 0x810DBA0
        public void Update(){} // RVA: 0x810DBD0
        public void LateUpdate(){} // RVA: 0x810DC50
        public void ProcessImguiEvents(){} // RVA: 0x810DC60
        public void ProcessKeyboardEvent(){} // RVA: 0x810DED0
        public void ProcessTabEvent(){} // RVA: 0x810DFF0
        public void SendTabEvent(){} // RVA: 0x810E0C0
        public void SendKeyUpEvent(){} // RVA: 0x810E290
        public void SendKeyDownEvent(){} // RVA: 0x810E400
        public void ReadPointerData(){} // RVA: 0x810E570
        public void .ctor(){} // RVA: 0x810E800
    }

    public class PanelRaycaster : BaseRaycaster
    {
        public object m_Panel;

        // ── Methods ──
        public void get_panel(){} // RVA: 0xB70160
        public void set_panel(){} // RVA: 0x810F1C0
        public void RegisterCallbacks(){} // RVA: 0x810F390
        public void UnregisterCallbacks(){} // RVA: 0x810F430
        public void OnPanelDestroyed(){} // RVA: 0x810F4D0
        public void get_selectableGameObject(){} // RVA: 0x810F4E0
        public void get_sortOrderPriority(){} // RVA: 0x810F500
        public void get_renderOrderPriority(){} // RVA: 0x810F520
        public void Raycast(){} // RVA: 0x810F5A0
        public void get_eventCamera(){} // RVA: 0xDAC980
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class PanelRootElement : VisualElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x80A1DF0
    }

    public class PanelSettings : ScriptableObject
    {
        public object k_DefaultSortingOrder;
        public object k_DefaultScaleValue;
        public object k_DefaultStyleSheetPath;
        public object themeUss;
        public object m_DisableNoThemeWarning;
        public object m_TargetTexture;
        public object m_RenderMode;
        public object m_WorldSpaceLayer;
        public object m_ScaleMode;
        public object m_ReferenceSpritePixelsPerUnit;
        public object m_PixelsPerUnit;
        public object m_Scale;
        public object DefaultDpi;
        public object m_ReferenceDpi;
        public object m_FallbackDpi;
        public object m_ReferenceResolution;
        public object m_ScreenMatchMode;
        public object m_Match;
        public object m_SortingOrder;
        public object m_TargetDisplay;
        public object m_BindingLogLevel;
        public object m_ClearDepthStencil;
        public object m_ClearColor;
        public object m_ColorClearValue;
        public object m_VertexBudget;
        public object m_PanelAccess;
        public object m_AttachedUIDocumentsList;
        public object m_DynamicAtlasSettings;
        public object m_AtlasBlitShader;
        public object m_RuntimeShader;
        public object m_RuntimeWorldShader;
        public object m_SDFShader;
        public object m_BitmapShader;
        public object m_SpriteShader;
        public object m_ICUDataAsset;
        public object forceGammaRendering;
        public object textSettings;
        public object m_TargetRect;
        public object m_ResolvedScale;
        public object m_OldThemeUss;
        public object _screenDPI;
        public object m_PanelChangeReceiver;
        public object m_AssignedScreenToPanel;

        // ── Methods ──
        public void get_themeStyleSheet(){} // RVA: 0x3926770
        public void set_themeStyleSheet(){} // RVA: 0x8071AA0
        public void get_targetTexture(){} // RVA: 0xB70160
        public void set_targetTexture(){} // RVA: 0x8071B00
        public void get_renderMode(){} // RVA: 0xB9E080
        public void set_renderMode(){} // RVA: 0xB9E090
        public void get_worldSpaceLayer(){} // RVA: 0xE9CE60
        public void set_worldSpaceLayer(){} // RVA: 0xEA1260
        public void get_scaleMode(){} // RVA: 0x18A0130
        public void set_scaleMode(){} // RVA: 0x189D3F0
        public void get_referenceSpritePixelsPerUnit(){} // RVA: 0x79D0740
        public void set_referenceSpritePixelsPerUnit(){} // RVA: 0x12C9F10
        public void get_pixelsPerUnit(){} // RVA: 0x7CA9140
        public void set_pixelsPerUnit(){} // RVA: 0xD34230
        public void get_scale(){} // RVA: 0xB4B880
        public void set_scale(){} // RVA: 0xB4B890
        public void get_referenceDpi(){} // RVA: 0x1767220
        public void set_referenceDpi(){} // RVA: 0x8071B70
        public void get_fallbackDpi(){} // RVA: 0x15CB5C0
        public void set_fallbackDpi(){} // RVA: 0x8071BA0
        public void get_referenceResolution(){} // RVA: 0xBE58B0
        public void set_referenceResolution(){} // RVA: 0xE9E640
        public void get_screenMatchMode(){} // RVA: 0x12BB630
        public void set_screenMatchMode(){} // RVA: 0x12BB640
        public void get_match(){} // RVA: 0xB6B180
        public void set_match(){} // RVA: 0xB6B190
        public void get_sortingOrder(){} // RVA: 0xC5C4A0
        public void set_sortingOrder(){} // RVA: 0x8071BD0
        public void ApplySortingOrder(){} // RVA: 0x8071C20
        public void get_targetDisplay(){} // RVA: 0xD34720
        public void set_targetDisplay(){} // RVA: 0x8071C60
        public void get_bindingLogLevel(){} // RVA: 0x2536460
        public void set_bindingLogLevel(){} // RVA: 0x8071CA0
        public void get_clearDepthStencil(){} // RVA: 0x100AD20
        public void set_clearDepthStencil(){} // RVA: 0x25C0190
        public void get_depthClearValue(){} // RVA: 0x8071D90
        public void get_clearColor(){} // RVA: 0x25C01A0
        public void set_clearColor(){} // RVA: 0x25C01B0
        public void get_colorClearValue(){} // RVA: 0x6A8AF00
        public void set_colorClearValue(){} // RVA: 0x6A8AF10
        public void get_vertexBudget(){} // RVA: 0xD34760
        public void set_vertexBudget(){} // RVA: 0xD34750
        public void get_panel(){} // RVA: 0x8071DA0
        public void get_isInitialized(){} // RVA: 0x8071DD0
        public void get_visualTree(){} // RVA: 0x8071DF0
        public void get_dynamicAtlasSettings(){} // RVA: 0x106A7D0
        public void set_dynamicAtlasSettings(){} // RVA: 0xD5CC70
        public void .ctor(){} // RVA: 0x8071E30
        public void Reset(){} // RVA: 0xB43310
        public void OnEnable(){} // RVA: 0x8072110
        public void OnDisable(){} // RVA: 0x80722B0
        public void DisposePanel(){} // RVA: 0x80722B0
        public void get_ScreenDPI(){} // RVA: 0x26CA7D0
        public void set_ScreenDPI(){} // RVA: 0x80722E0
        public void SetPanelChangeReceiver(){} // RVA: 0x80722F0
        public void GetPanelChangeReceiver(){} // RVA: 0x8072390
        public void UpdateScreenDPI(){} // RVA: 0x80723A0
        public void ApplyThemeStyleSheet(){} // RVA: 0x8072400
        public void AssignICUData(){} // RVA: 0x263B110
        public void InitializeShaders(){} // RVA: 0x80727C0
        public void ApplyPanelSettings(){} // RVA: 0x8072F10
        public void SetScreenToPanelSpaceFunction(){} // RVA: 0x8073B50
        public void ResolveScale(){} // RVA: 0x8073CA0
        public void GetDisplayRect(){} // RVA: 0x8073DA0
        public void AttachAndInsertUIDocumentToVisualTree(){} // RVA: 0x8073F60
        public void DetachUIDocument(){} // RVA: 0x80740E0
    }

    public class PanelSettings[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class PanelTextSettings : TextSettings
    {
        public object s_DefaultPanelTextSettings;

        // ── Methods ──
        public void get_defaultPanelTextSettings(){} // RVA: 0x7EF5610
        public void InitializeDefaultPanelTextSettingsIfNull(){} // RVA: 0x7EF5660
        public void .ctor(){} // RVA: 0x7C919C0
    }

    public class Panel[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class PointerCancelEvent : PointerEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x8068CC0
        public void Init(){} // RVA: 0x8068DB0
        public void LocalInit(){} // RVA: 0x8068E30
        public void .ctor(){} // RVA: 0x8068E80
        public void PreDispatch(){} // RVA: 0x8068F00
        public void PostDispatch(){} // RVA: 0x8069020
    }

    public class PointerCaptureEvent : PointerCaptureEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x80557D0
        public void PreDispatch(){} // RVA: 0x80558C0
        public void .ctor(){} // RVA: 0x80559A0
    }

    public class PointerCaptureEventBase`1 : EventBase`1
    {
        public object _relatedTarget;
        public object _pointerId;

        // ── Methods ──
        public void set_relatedTarget(){} // RVA: 0x894320
        public void get_pointerId(){} // RVA: 0x87C130
        public void set_pointerId(){} // RVA: 0x8944F0
        public void Init(){} // RVA: 0x894290
        public void LocalInit(){} // RVA: 0x894290
        public void GetPooled(){} // RVA: 0xA94080
        public void .ctor(){} // RVA: 0x894290
    }

    public class PointerCaptureEventBase`1 : EventBase`1
    {
        public object _relatedTarget;
        public object _pointerId;

        // ── Methods ──
        public void set_relatedTarget(){} // RVA: 0xBBFFA0
        public void get_pointerId(){} // RVA: 0x19C6270
        public void set_pointerId(){} // RVA: 0xCE5450
        public void Init(){} // RVA: 0x485F400
        public void LocalInit(){} // RVA: 0x485F490
        public void GetPooled(){} // RVA: 0x485F560
        public void .ctor(){} // RVA: 0x485F750
    }

    public class PointerCaptureEventBase`1 : EventBase`1
    {
        public object _relatedTarget;
        public object _pointerId;

        // ── Methods ──
        public void set_relatedTarget(){} // RVA: 0xBBFFA0
        public void get_pointerId(){} // RVA: 0x19C6270
        public void set_pointerId(){} // RVA: 0xCE5450
        public void Init(){} // RVA: 0x485F400
        public void LocalInit(){} // RVA: 0x485F490
        public void GetPooled(){} // RVA: 0x485F560
        public void .ctor(){} // RVA: 0x485F750
    }

    public class PointerCaptureEventBase`1 : EventBase`1
    {
        public object _relatedTarget;
        public object _pointerId;

        // ── Methods ──
        public void set_relatedTarget(){} // RVA: 0xBBFFA0
        public void get_pointerId(){} // RVA: 0x19C6270
        public void set_pointerId(){} // RVA: 0xCE5450
        public void Init(){} // RVA: 0x485F400
        public void LocalInit(){} // RVA: 0x485F490
        public void GetPooled(){} // RVA: 0x485F560
        public void .ctor(){} // RVA: 0x485F750
    }

    public class PointerCaptureEventBase`1 : EventBase`1
    {
        public object _relatedTarget;
        public object _pointerId;

        // ── Methods ──
        public void set_relatedTarget(){} // RVA: 0xBBFFA0
        public void get_pointerId(){} // RVA: 0x19C6270
        public void set_pointerId(){} // RVA: 0xCE5450
        public void Init(){} // RVA: 0x485F400
        public void LocalInit(){} // RVA: 0x485F490
        public void GetPooled(){} // RVA: 0x485F560
        public void .ctor(){} // RVA: 0x485F750
    }

    public class PointerCaptureEventBase`1 : EventBase`1
    {
        public object _relatedTarget;
        public object _pointerId;

        // ── Methods ──
        public void set_relatedTarget(){} // RVA: 0xBBFFA0
        public void get_pointerId(){} // RVA: 0x19C6270
        public void set_pointerId(){} // RVA: 0xCE5450
        public void Init(){} // RVA: 0x485F400
        public void LocalInit(){} // RVA: 0x485F490
        public void GetPooled(){} // RVA: 0x485F560
        public void .ctor(){} // RVA: 0x485F750
    }

    public class PointerCaptureHelper : Object
    {
        // ── Methods ──
        public void GetStateFor(){} // RVA: 0x80A2320
        public void HasPointerCapture(){} // RVA: 0x80A23C0
        public void CapturePointer(){} // RVA: 0x80A24A0
        public void ReleasePointer(){} // RVA: 0x80A27C0
        public void GetCapturingElement(){} // RVA: 0x80A2730
        public void ActivateCompatibilityMouseEvents(){} // RVA: 0x80A2840
        public void PreventCompatibilityMouseEvents(){} // RVA: 0x80A28C0
        public void ShouldSendCompatibilityMouseEvents(){} // RVA: 0x80A2940
        public void ProcessPointerCapture(){} // RVA: 0x80A2AA0
    }

    public class PointerCaptureOutEvent : PointerCaptureEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x80554B0
        public void PreDispatch(){} // RVA: 0x80555A0
        public void .ctor(){} // RVA: 0x8055680
    }

    public class PointerDeviceState : Object
    {
        public object s_PlayerPointerLocations;
        public object s_PressedButtons;
        public object s_PlayerPanelWithSoftPointerCapture;

        // ── Methods ──
        public void RemovePanelData(){} // RVA: 0x8065800
        public void SavePointerPosition(){} // RVA: 0x80659E0
        public void PressButton(){} // RVA: 0x8065A90
        public void ReleaseButton(){} // RVA: 0x8065B90
        public void ReleaseAllButtons(){} // RVA: 0x8065C90
        public void GetPointerPosition(){} // RVA: 0x8065D10
        public void GetPanel(){} // RVA: 0x8065DA0
        public void HasFlagFast(){} // RVA: 0x8065E20
        public void HasLocationFlag(){} // RVA: 0x8065E30
        public void GetPressedButtons(){} // RVA: 0x8065EC0
        public void HasAdditionalPressedButtons(){} // RVA: 0x8065F40
        public void SetPlayerPanelWithSoftPointerCapture(){} // RVA: 0x8065FD0
        public void GetPlayerPanelWithSoftPointerCapture(){} // RVA: 0x8066090
        public void .cctor(){} // RVA: 0x8066110
    }

    public class PointerDispatchState : Object
    {
        public object m_PendingPointerCapture;
        public object m_PointerCapture;
        public object m_ShouldSendCompatibilityMouseEvents;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x80A2B10
        public void Reset(){} // RVA: 0x80A2E10
        public void GetCapturingElement(){} // RVA: 0x753C8F0
        public void HasPointerCapture(){} // RVA: 0x80A2F70
        public void CapturePointer(){} // RVA: 0x80A2FA0
        public void ReleasePointer(){} // RVA: 0x80A3100
        public void ProcessPointerCapture(){} // RVA: 0x80A3150
        public void ActivateCompatibilityMouseEvents(){} // RVA: 0x80A3650
        public void PreventCompatibilityMouseEvents(){} // RVA: 0x80A3680
        public void ShouldSendCompatibilityMouseEvents(){} // RVA: 0x80A36B0
    }

    public class PointerDownEvent : PointerEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x8066BB0
        public void Init(){} // RVA: 0x8066CA0
        public void LocalInit(){} // RVA: 0x8066D20
        public void .ctor(){} // RVA: 0x8066D70
        public void PreDispatch(){} // RVA: 0x8066DF0
        public void PostDispatch(){} // RVA: 0x8066F10
    }

    public class PointerEnterEvent : PointerEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x80696D0
        public void Init(){} // RVA: 0x80697C0
        public void LocalInit(){} // RVA: 0xBDB7E0
        public void .ctor(){} // RVA: 0x8069810
        public void Dispatch(){} // RVA: 0x8061660
        public void PreDispatch(){} // RVA: 0x8069860
    }

    public class PointerEventBase`1 : EventBase`1
    {
        public object k_DefaultButtonPressure;
        public object m_AltitudeNeedsConversion;
        public object m_AzimuthNeedsConversion;
        public object m_AltitudeAngle;
        public object m_AzimuthAngle;
        public object m_TiltNeeded;
        public object m_Tilt;
        public object _pointerId;
        public object _pointerType;
        public object _isPrimary;
        public object _button;
        public object _pressedButtons;
        public object _position;
        public object _localPosition;
        public object _deltaPosition;
        public object _deltaTime;
        public object _clickCount;
        public object _pressure;
        public object _tangentialPressure;
        public object _twist;
        public object _penStatus;
        public object _radius;
        public object _radiusVariance;
        public object _modifiers;
        public object _triggeredByOS;
        public object _compatibilityMouseEvent;
        public object _displayIndex;

        // ── Methods ──
        public void get_pointerId(){} // RVA: 0x87C130
        public void set_pointerId(){} // RVA: 0x8944F0
        public void get_pointerType(){} // RVA: 0x87C0A0
        public void set_pointerType(){} // RVA: 0x894320
        public void get_isPrimary(){} // RVA: 0x87D280
        public void set_isPrimary(){} // RVA: 0x894750
        public void get_button(){} // RVA: 0x87C130
        public void set_button(){} // RVA: 0x8944F0
        public void get_pressedButtons(){} // RVA: 0x87C130
        public void set_pressedButtons(){} // RVA: 0x8944F0
        public void get_position(){} // RVA: 0x87BEB0
        public void set_position(){} // RVA: 0x894320
        public void get_localPosition(){} // RVA: 0x87BEB0
        public void set_localPosition(){} // RVA: 0x894320
        public void get_deltaPosition(){} // RVA: 0x87BEB0
        public void set_deltaPosition(){} // RVA: 0x894320
        public void get_deltaTime(){} // RVA: 0x890F90
        public void set_deltaTime(){} // RVA: 0x8A23A0
        public void get_clickCount(){} // RVA: 0x87C130
        public void set_clickCount(){} // RVA: 0x8944F0
        public void get_pressure(){} // RVA: 0x890F90
        public void set_pressure(){} // RVA: 0x8A23A0
        public void get_tangentialPressure(){} // RVA: 0x890F90
        public void set_tangentialPressure(){} // RVA: 0x8A23A0
        public void get_altitudeAngle(){} // RVA: 0x890F90
        public void set_altitudeAngle(){} // RVA: 0x8A23A0
        public void get_azimuthAngle(){} // RVA: 0x890F90
        public void set_azimuthAngle(){} // RVA: 0x8A23A0
        public void get_twist(){} // RVA: 0x890F90
        public void set_twist(){} // RVA: 0x8A23A0
        public void get_tilt(){} // RVA: 0x87C0A0
        public void set_tilt(){} // RVA: 0x895F20
        public void get_penStatus(){} // RVA: 0x87C130
        public void set_penStatus(){} // RVA: 0x8944F0
        public void get_radius(){} // RVA: 0x87C0A0
        public void set_radius(){} // RVA: 0x895F20
        public void get_radiusVariance(){} // RVA: 0x87C0A0
        public void set_radiusVariance(){} // RVA: 0x895F20
        public void get_modifiers(){} // RVA: 0x87C130
        public void set_modifiers(){} // RVA: 0x8944F0
        public void get_shiftKey(){} // RVA: 0x87D280
        public void get_ctrlKey(){} // RVA: 0x87D280
        public void get_commandKey(){} // RVA: 0x87D280
        public void get_altKey(){} // RVA: 0x87D280
        public void get_actionKey(){} // RVA: 0x87D280
        public void UnityEngine.UIElements.IPointerEventInternal.get_triggeredByOS(){} // RVA: 0x87D280
        public void UnityEngine.UIElements.IPointerEventInternal.set_triggeredByOS(){} // RVA: 0x894750
        public void UnityEngine.UIElements.IPointerEventInternal.get_compatibilityMouseEvent(){} // RVA: 0x87C0A0
        public void UnityEngine.UIElements.IPointerEventInternal.set_compatibilityMouseEvent(){} // RVA: 0x894320
        public void UnityEngine.UIElements.IPointerEventInternal.set_displayIndex(){} // RVA: 0x8944F0
        public void Init(){} // RVA: 0x894290
        public void LocalInit(){} // RVA: 0x894290
        public void get_currentTarget(){} // RVA: 0x87C0A0
        public void set_currentTarget(){} // RVA: 0x894320
        public void IsMouse(){} // RVA: 0x87D390
        public void IsTouch(){} // RVA: 0x87D390
        public void TiltToAzimuth(){} // RVA: 0x8927D0
        public void AzimuthAndAlitutudeToTilt(){} // RVA: 0xA94080
        public void TiltToAltitude(){} // RVA: 0x8927D0
        public void GetPooled(){} // RVA: 0xA94080
        public void PreDispatch(){} // RVA: 0x894320
        public void PostDispatch(){} // RVA: 0x894320
        public void Dispatch(){} // RVA: 0x894320
        public void .ctor(){} // RVA: 0x894290
    }

    public class PointerEventBase`1 : EventBase`1
    {
        public object k_DefaultButtonPressure;
        public object m_AltitudeNeedsConversion;
        public object m_AzimuthNeedsConversion;
        public object m_AltitudeAngle;
        public object m_AzimuthAngle;
        public object m_TiltNeeded;
        public object m_Tilt;
        public object _pointerId;
        public object _pointerType;
        public object _isPrimary;
        public object _button;
        public object _pressedButtons;
        public object _position;
        public object _localPosition;
        public object _deltaPosition;
        public object _deltaTime;
        public object _clickCount;
        public object _pressure;
        public object _tangentialPressure;
        public object _twist;
        public object _penStatus;
        public object _radius;
        public object _radiusVariance;
        public object _modifiers;
        public object _triggeredByOS;
        public object _compatibilityMouseEvent;
        public object _displayIndex;

        // ── Methods ──
        public void get_pointerId(){} // RVA: 0xD34760
        public void set_pointerId(){} // RVA: 0xD34750
        public void get_pointerType(){} // RVA: 0xB813B0
        public void set_pointerType(){} // RVA: 0xD5CBB0
        public void get_isPrimary(){} // RVA: 0x1C4D9A0
        public void set_isPrimary(){} // RVA: 0x1C4DB10
        public void get_button(){} // RVA: 0xF3A940
        public void set_button(){} // RVA: 0x11A0AB0
        public void get_pressedButtons(){} // RVA: 0x262A930
        public void set_pressedButtons(){} // RVA: 0x262A900
        public void get_position(){} // RVA: 0x485F7C0
        public void set_position(){} // RVA: 0x485F7E0
        public void get_localPosition(){} // RVA: 0x485F800
        public void set_localPosition(){} // RVA: 0x485F820
        public void get_deltaPosition(){} // RVA: 0x485F840
        public void set_deltaPosition(){} // RVA: 0x485F860
        public void get_deltaTime(){} // RVA: 0x485F880
        public void set_deltaTime(){} // RVA: 0x485F890
        public void get_clickCount(){} // RVA: 0x485F8A0
        public void set_clickCount(){} // RVA: 0x485F8B0
        public void get_pressure(){} // RVA: 0xB63B80
        public void set_pressure(){} // RVA: 0xB63B90
        public void get_tangentialPressure(){} // RVA: 0xB63BA0
        public void set_tangentialPressure(){} // RVA: 0xB63BB0
        public void get_altitudeAngle(){} // RVA: 0x485F8C0
        public void set_altitudeAngle(){} // RVA: 0x485F940
        public void get_azimuthAngle(){} // RVA: 0x485F950
        public void set_azimuthAngle(){} // RVA: 0x485FA70
        public void get_twist(){} // RVA: 0x100D250
        public void set_twist(){} // RVA: 0x485FA80
        public void get_tilt(){} // RVA: 0x485FA90
        public void set_tilt(){} // RVA: 0x485FCB0
        public void get_penStatus(){} // RVA: 0x25585B0
        public void set_penStatus(){} // RVA: 0x485FCC0
        public void get_radius(){} // RVA: 0x485FCD0
        public void set_radius(){} // RVA: 0x485FCF0
        public void get_radiusVariance(){} // RVA: 0x485FD00
        public void set_radiusVariance(){} // RVA: 0x485FD20
        public void get_modifiers(){} // RVA: 0x485FD30
        public void set_modifiers(){} // RVA: 0x485FD40
        public void get_shiftKey(){} // RVA: 0x485FD50
        public void get_ctrlKey(){} // RVA: 0x485FD60
        public void get_commandKey(){} // RVA: 0x485FD70
        public void get_altKey(){} // RVA: 0x485FD80
        public void get_actionKey(){} // RVA: 0x485FD90
        public void UnityEngine.UIElements.IPointerEventInternal.get_triggeredByOS(){} // RVA: 0xE35C60
        public void UnityEngine.UIElements.IPointerEventInternal.set_triggeredByOS(){} // RVA: 0xE39600
        public void UnityEngine.UIElements.IPointerEventInternal.get_compatibilityMouseEvent(){} // RVA: 0xBAE5A0
        public void UnityEngine.UIElements.IPointerEventInternal.set_compatibilityMouseEvent(){} // RVA: 0xBAE5B0
        public void UnityEngine.UIElements.IPointerEventInternal.set_displayIndex(){} // RVA: 0x485FE90
        public void Init(){} // RVA: 0x485FEA0
        public void LocalInit(){} // RVA: 0x485FF50
        public void get_currentTarget(){} // RVA: 0x46CB940
        public void set_currentTarget(){} // RVA: 0x48602A0
        public void IsMouse(){} // RVA: 0x48603D0
        public void IsTouch(){} // RVA: 0x4860470
        public void TiltToAzimuth(){} // RVA: 0x4860510
        public void AzimuthAndAlitutudeToTilt(){} // RVA: 0x4860620
        public void TiltToAltitude(){} // RVA: 0x48606C0
        public void GetPooled(){} // RVA: 0x4863AB0
        public void PreDispatch(){} // RVA: 0x4864070
        public void PostDispatch(){} // RVA: 0x4864220
        public void Dispatch(){} // RVA: 0x4864440
        public void .ctor(){} // RVA: 0x48644E0
    }

    public class PointerEventBase`1 : EventBase`1
    {
        // ── Methods ──
        public void get_penStatus(){} // RVA: 0x25585B0
        public void set_penStatus(){} // RVA: 0x485FCC0
    }

    public class PointerEventBase`1 : EventBase`1
    {
        public object k_DefaultButtonPressure;
        public object m_AltitudeNeedsConversion;
        public object m_AzimuthNeedsConversion;
        public object m_AltitudeAngle;
        public object m_AzimuthAngle;
        public object m_TiltNeeded;
        public object m_Tilt;
        public object _pointerId;
        public object _pointerType;
        public object _isPrimary;
        public object _button;
        public object _pressedButtons;
        public object _position;
        public object _localPosition;
        public object _deltaPosition;
        public object _deltaTime;
        public object _clickCount;
        public object _pressure;
        public object _tangentialPressure;
        public object _twist;
        public object _penStatus;
        public object _radius;
        public object _radiusVariance;
        public object _modifiers;
        public object _triggeredByOS;
        public object _compatibilityMouseEvent;
        public object _displayIndex;

        // ── Methods ──
        public void get_pointerId(){} // RVA: 0xD34760
        public void set_pointerId(){} // RVA: 0xD34750
        public void get_pointerType(){} // RVA: 0xB813B0
        public void set_pointerType(){} // RVA: 0xD5CBB0
        public void get_isPrimary(){} // RVA: 0x1C4D9A0
        public void set_isPrimary(){} // RVA: 0x1C4DB10
        public void get_button(){} // RVA: 0xF3A940
        public void set_button(){} // RVA: 0x11A0AB0
        public void get_pressedButtons(){} // RVA: 0x262A930
        public void set_pressedButtons(){} // RVA: 0x262A900
        public void get_position(){} // RVA: 0x485F7C0
        public void set_position(){} // RVA: 0x485F7E0
        public void get_localPosition(){} // RVA: 0x485F800
        public void set_localPosition(){} // RVA: 0x485F820
        public void get_deltaPosition(){} // RVA: 0x485F840
        public void set_deltaPosition(){} // RVA: 0x485F860
        public void get_deltaTime(){} // RVA: 0x485F880
        public void set_deltaTime(){} // RVA: 0x485F890
        public void get_clickCount(){} // RVA: 0x485F8A0
        public void set_clickCount(){} // RVA: 0x485F8B0
        public void get_pressure(){} // RVA: 0xB63B80
        public void set_pressure(){} // RVA: 0xB63B90
        public void get_tangentialPressure(){} // RVA: 0xB63BA0
        public void set_tangentialPressure(){} // RVA: 0xB63BB0
        public void get_altitudeAngle(){} // RVA: 0x485F8C0
        public void set_altitudeAngle(){} // RVA: 0x485F940
        public void get_azimuthAngle(){} // RVA: 0x485F950
        public void set_azimuthAngle(){} // RVA: 0x485FA70
        public void get_twist(){} // RVA: 0x100D250
        public void set_twist(){} // RVA: 0x485FA80
        public void get_tilt(){} // RVA: 0x485FA90
        public void set_tilt(){} // RVA: 0x485FCB0
        public void get_penStatus(){} // RVA: 0x25585B0
        public void set_penStatus(){} // RVA: 0x485FCC0
        public void get_radius(){} // RVA: 0x485FCD0
        public void set_radius(){} // RVA: 0x485FCF0
        public void get_radiusVariance(){} // RVA: 0x485FD00
        public void set_radiusVariance(){} // RVA: 0x485FD20
        public void get_modifiers(){} // RVA: 0x485FD30
        public void set_modifiers(){} // RVA: 0x485FD40
        public void get_shiftKey(){} // RVA: 0x485FD50
        public void get_ctrlKey(){} // RVA: 0x485FD60
        public void get_commandKey(){} // RVA: 0x485FD70
        public void get_altKey(){} // RVA: 0x485FD80
        public void get_actionKey(){} // RVA: 0x485FD90
        public void UnityEngine.UIElements.IPointerEventInternal.get_triggeredByOS(){} // RVA: 0xE35C60
        public void UnityEngine.UIElements.IPointerEventInternal.set_triggeredByOS(){} // RVA: 0xE39600
        public void UnityEngine.UIElements.IPointerEventInternal.get_compatibilityMouseEvent(){} // RVA: 0xBAE5A0
        public void UnityEngine.UIElements.IPointerEventInternal.set_compatibilityMouseEvent(){} // RVA: 0xBAE5B0
        public void UnityEngine.UIElements.IPointerEventInternal.set_displayIndex(){} // RVA: 0x485FE90
        public void Init(){} // RVA: 0x485FEA0
        public void LocalInit(){} // RVA: 0x485FF50
        public void get_currentTarget(){} // RVA: 0x46CB940
        public void set_currentTarget(){} // RVA: 0x48602A0
        public void IsMouse(){} // RVA: 0x48603D0
        public void IsTouch(){} // RVA: 0x4860470
        public void TiltToAzimuth(){} // RVA: 0x4860510
        public void AzimuthAndAlitutudeToTilt(){} // RVA: 0x4860620
        public void TiltToAltitude(){} // RVA: 0x48606C0
        public void GetPooled(){} // RVA: 0x4863AB0
        public void PreDispatch(){} // RVA: 0x4864070
        public void PostDispatch(){} // RVA: 0x4864220
        public void Dispatch(){} // RVA: 0x4864440
        public void .ctor(){} // RVA: 0x48644E0
    }

    public class PointerEventBase`1 : EventBase`1
    {
        public object k_DefaultButtonPressure;
        public object m_AltitudeNeedsConversion;
        public object m_AzimuthNeedsConversion;
        public object m_AltitudeAngle;
        public object m_AzimuthAngle;
        public object m_TiltNeeded;
        public object m_Tilt;
        public object _pointerId;
        public object _pointerType;
        public object _isPrimary;
        public object _button;
        public object _pressedButtons;
        public object _position;
        public object _localPosition;
        public object _deltaPosition;
        public object _deltaTime;
        public object _clickCount;
        public object _pressure;
        public object _tangentialPressure;
        public object _twist;
        public object _penStatus;
        public object _radius;
        public object _radiusVariance;
        public object _modifiers;
        public object _triggeredByOS;
        public object _compatibilityMouseEvent;
        public object _displayIndex;

        // ── Methods ──
        public void get_pointerId(){} // RVA: 0xD34760
        public void set_pointerId(){} // RVA: 0xD34750
        public void get_pointerType(){} // RVA: 0xB813B0
        public void set_pointerType(){} // RVA: 0xD5CBB0
        public void get_isPrimary(){} // RVA: 0x1C4D9A0
        public void set_isPrimary(){} // RVA: 0x1C4DB10
        public void get_button(){} // RVA: 0xF3A940
        public void set_button(){} // RVA: 0x11A0AB0
        public void get_pressedButtons(){} // RVA: 0x262A930
        public void set_pressedButtons(){} // RVA: 0x262A900
        public void get_position(){} // RVA: 0x485F7C0
        public void set_position(){} // RVA: 0x485F7E0
        public void get_localPosition(){} // RVA: 0x485F800
        public void set_localPosition(){} // RVA: 0x485F820
        public void get_deltaPosition(){} // RVA: 0x485F840
        public void set_deltaPosition(){} // RVA: 0x485F860
        public void get_deltaTime(){} // RVA: 0x485F880
        public void set_deltaTime(){} // RVA: 0x485F890
        public void get_clickCount(){} // RVA: 0x485F8A0
        public void set_clickCount(){} // RVA: 0x485F8B0
        public void get_pressure(){} // RVA: 0xB63B80
        public void set_pressure(){} // RVA: 0xB63B90
        public void get_tangentialPressure(){} // RVA: 0xB63BA0
        public void set_tangentialPressure(){} // RVA: 0xB63BB0
        public void get_altitudeAngle(){} // RVA: 0x485F8C0
        public void set_altitudeAngle(){} // RVA: 0x485F940
        public void get_azimuthAngle(){} // RVA: 0x485F950
        public void set_azimuthAngle(){} // RVA: 0x485FA70
        public void get_twist(){} // RVA: 0x100D250
        public void set_twist(){} // RVA: 0x485FA80
        public void get_tilt(){} // RVA: 0x485FA90
        public void set_tilt(){} // RVA: 0x485FCB0
        public void get_penStatus(){} // RVA: 0x25585B0
        public void set_penStatus(){} // RVA: 0x485FCC0
        public void get_radius(){} // RVA: 0x485FCD0
        public void set_radius(){} // RVA: 0x485FCF0
        public void get_radiusVariance(){} // RVA: 0x485FD00
        public void set_radiusVariance(){} // RVA: 0x485FD20
        public void get_modifiers(){} // RVA: 0x485FD30
        public void set_modifiers(){} // RVA: 0x485FD40
        public void get_shiftKey(){} // RVA: 0x485FD50
        public void get_ctrlKey(){} // RVA: 0x485FD60
        public void get_commandKey(){} // RVA: 0x485FD70
        public void get_altKey(){} // RVA: 0x485FD80
        public void get_actionKey(){} // RVA: 0x485FD90
        public void UnityEngine.UIElements.IPointerEventInternal.get_triggeredByOS(){} // RVA: 0xE35C60
        public void UnityEngine.UIElements.IPointerEventInternal.set_triggeredByOS(){} // RVA: 0xE39600
        public void UnityEngine.UIElements.IPointerEventInternal.get_compatibilityMouseEvent(){} // RVA: 0xBAE5A0
        public void UnityEngine.UIElements.IPointerEventInternal.set_compatibilityMouseEvent(){} // RVA: 0xBAE5B0
        public void UnityEngine.UIElements.IPointerEventInternal.set_displayIndex(){} // RVA: 0x485FE90
        public void Init(){} // RVA: 0x485FEA0
        public void LocalInit(){} // RVA: 0x485FF50
        public void get_currentTarget(){} // RVA: 0x46CB940
        public void set_currentTarget(){} // RVA: 0x48602A0
        public void IsMouse(){} // RVA: 0x48603D0
        public void IsTouch(){} // RVA: 0x4860470
        public void TiltToAzimuth(){} // RVA: 0x4860510
        public void AzimuthAndAlitutudeToTilt(){} // RVA: 0x4860620
        public void TiltToAltitude(){} // RVA: 0x48606C0
        public void GetPooled(){} // RVA: 0x4863AB0
        public void PreDispatch(){} // RVA: 0x4864070
        public void PostDispatch(){} // RVA: 0x4864220
        public void Dispatch(){} // RVA: 0x4864440
        public void .ctor(){} // RVA: 0x48644E0
    }

    public class PointerEventBase`1 : EventBase`1
    {
        public object k_DefaultButtonPressure;
        public object m_AltitudeNeedsConversion;
        public object m_AzimuthNeedsConversion;
        public object m_AltitudeAngle;
        public object m_AzimuthAngle;
        public object m_TiltNeeded;
        public object m_Tilt;
        public object _pointerId;
        public object _pointerType;
        public object _isPrimary;
        public object _button;
        public object _pressedButtons;
        public object _position;
        public object _localPosition;
        public object _deltaPosition;
        public object _deltaTime;
        public object _clickCount;
        public object _pressure;
        public object _tangentialPressure;
        public object _twist;
        public object _penStatus;
        public object _radius;
        public object _radiusVariance;
        public object _modifiers;
        public object _triggeredByOS;
        public object _compatibilityMouseEvent;
        public object _displayIndex;

        // ── Methods ──
        public void get_pointerId(){} // RVA: 0xD34760
        public void set_pointerId(){} // RVA: 0xD34750
        public void get_pointerType(){} // RVA: 0xB813B0
        public void set_pointerType(){} // RVA: 0xD5CBB0
        public void get_isPrimary(){} // RVA: 0x1C4D9A0
        public void set_isPrimary(){} // RVA: 0x1C4DB10
        public void get_button(){} // RVA: 0xF3A940
        public void set_button(){} // RVA: 0x11A0AB0
        public void get_pressedButtons(){} // RVA: 0x262A930
        public void set_pressedButtons(){} // RVA: 0x262A900
        public void get_position(){} // RVA: 0x485F7C0
        public void set_position(){} // RVA: 0x485F7E0
        public void get_localPosition(){} // RVA: 0x485F800
        public void set_localPosition(){} // RVA: 0x485F820
        public void get_deltaPosition(){} // RVA: 0x485F840
        public void set_deltaPosition(){} // RVA: 0x485F860
        public void get_deltaTime(){} // RVA: 0x485F880
        public void set_deltaTime(){} // RVA: 0x485F890
        public void get_clickCount(){} // RVA: 0x485F8A0
        public void set_clickCount(){} // RVA: 0x485F8B0
        public void get_pressure(){} // RVA: 0xB63B80
        public void set_pressure(){} // RVA: 0xB63B90
        public void get_tangentialPressure(){} // RVA: 0xB63BA0
        public void set_tangentialPressure(){} // RVA: 0xB63BB0
        public void get_altitudeAngle(){} // RVA: 0x485F8C0
        public void set_altitudeAngle(){} // RVA: 0x485F940
        public void get_azimuthAngle(){} // RVA: 0x485F950
        public void set_azimuthAngle(){} // RVA: 0x485FA70
        public void get_twist(){} // RVA: 0x100D250
        public void set_twist(){} // RVA: 0x485FA80
        public void get_tilt(){} // RVA: 0x485FA90
        public void set_tilt(){} // RVA: 0x485FCB0
        public void get_penStatus(){} // RVA: 0x25585B0
        public void set_penStatus(){} // RVA: 0x485FCC0
        public void get_radius(){} // RVA: 0x485FCD0
        public void set_radius(){} // RVA: 0x485FCF0
        public void get_radiusVariance(){} // RVA: 0x485FD00
        public void set_radiusVariance(){} // RVA: 0x485FD20
        public void get_modifiers(){} // RVA: 0x485FD30
        public void set_modifiers(){} // RVA: 0x485FD40
        public void get_shiftKey(){} // RVA: 0x485FD50
        public void get_ctrlKey(){} // RVA: 0x485FD60
        public void get_commandKey(){} // RVA: 0x485FD70
        public void get_altKey(){} // RVA: 0x485FD80
        public void get_actionKey(){} // RVA: 0x485FD90
        public void UnityEngine.UIElements.IPointerEventInternal.get_triggeredByOS(){} // RVA: 0xE35C60
        public void UnityEngine.UIElements.IPointerEventInternal.set_triggeredByOS(){} // RVA: 0xE39600
        public void UnityEngine.UIElements.IPointerEventInternal.get_compatibilityMouseEvent(){} // RVA: 0xBAE5A0
        public void UnityEngine.UIElements.IPointerEventInternal.set_compatibilityMouseEvent(){} // RVA: 0xBAE5B0
        public void UnityEngine.UIElements.IPointerEventInternal.set_displayIndex(){} // RVA: 0x485FE90
        public void Init(){} // RVA: 0x485FEA0
        public void LocalInit(){} // RVA: 0x485FF50
        public void get_currentTarget(){} // RVA: 0x46CB940
        public void set_currentTarget(){} // RVA: 0x48602A0
        public void IsMouse(){} // RVA: 0x48603D0
        public void IsTouch(){} // RVA: 0x4860470
        public void TiltToAzimuth(){} // RVA: 0x4860510
        public void AzimuthAndAlitutudeToTilt(){} // RVA: 0x4860620
        public void TiltToAltitude(){} // RVA: 0x48606C0
        public void GetPooled(){} // RVA: 0x4863AB0
        public void PreDispatch(){} // RVA: 0x4864070
        public void PostDispatch(){} // RVA: 0x4864220
        public void Dispatch(){} // RVA: 0x4864440
        public void .ctor(){} // RVA: 0x48644E0
    }

    public class PointerEventBase`1 : EventBase`1
    {
        public object k_DefaultButtonPressure;
        public object m_AltitudeNeedsConversion;
        public object m_AzimuthNeedsConversion;
        public object m_AltitudeAngle;
        public object m_AzimuthAngle;
        public object m_TiltNeeded;
        public object m_Tilt;
        public object _pointerId;
        public object _pointerType;
        public object _isPrimary;
        public object _button;
        public object _pressedButtons;
        public object _position;
        public object _localPosition;
        public object _deltaPosition;
        public object _deltaTime;
        public object _clickCount;
        public object _pressure;
        public object _tangentialPressure;
        public object _twist;
        public object _penStatus;
        public object _radius;
        public object _radiusVariance;
        public object _modifiers;
        public object _triggeredByOS;
        public object _compatibilityMouseEvent;
        public object _displayIndex;

        // ── Methods ──
        public void get_pointerId(){} // RVA: 0xD34760
        public void set_pointerId(){} // RVA: 0xD34750
        public void get_pointerType(){} // RVA: 0xB813B0
        public void set_pointerType(){} // RVA: 0xD5CBB0
        public void get_isPrimary(){} // RVA: 0x1C4D9A0
        public void set_isPrimary(){} // RVA: 0x1C4DB10
        public void get_button(){} // RVA: 0xF3A940
        public void set_button(){} // RVA: 0x11A0AB0
        public void get_pressedButtons(){} // RVA: 0x262A930
        public void set_pressedButtons(){} // RVA: 0x262A900
        public void get_position(){} // RVA: 0x485F7C0
        public void set_position(){} // RVA: 0x485F7E0
        public void get_localPosition(){} // RVA: 0x485F800
        public void set_localPosition(){} // RVA: 0x485F820
        public void get_deltaPosition(){} // RVA: 0x485F840
        public void set_deltaPosition(){} // RVA: 0x485F860
        public void get_deltaTime(){} // RVA: 0x485F880
        public void set_deltaTime(){} // RVA: 0x485F890
        public void get_clickCount(){} // RVA: 0x485F8A0
        public void set_clickCount(){} // RVA: 0x485F8B0
        public void get_pressure(){} // RVA: 0xB63B80
        public void set_pressure(){} // RVA: 0xB63B90
        public void get_tangentialPressure(){} // RVA: 0xB63BA0
        public void set_tangentialPressure(){} // RVA: 0xB63BB0
        public void get_altitudeAngle(){} // RVA: 0x485F8C0
        public void set_altitudeAngle(){} // RVA: 0x485F940
        public void get_azimuthAngle(){} // RVA: 0x485F950
        public void set_azimuthAngle(){} // RVA: 0x485FA70
        public void get_twist(){} // RVA: 0x100D250
        public void set_twist(){} // RVA: 0x485FA80
        public void get_tilt(){} // RVA: 0x485FA90
        public void set_tilt(){} // RVA: 0x485FCB0
        public void get_penStatus(){} // RVA: 0x25585B0
        public void set_penStatus(){} // RVA: 0x485FCC0
        public void get_radius(){} // RVA: 0x485FCD0
        public void set_radius(){} // RVA: 0x485FCF0
        public void get_radiusVariance(){} // RVA: 0x485FD00
        public void set_radiusVariance(){} // RVA: 0x485FD20
        public void get_modifiers(){} // RVA: 0x485FD30
        public void set_modifiers(){} // RVA: 0x485FD40
        public void get_shiftKey(){} // RVA: 0x485FD50
        public void get_ctrlKey(){} // RVA: 0x485FD60
        public void get_commandKey(){} // RVA: 0x485FD70
        public void get_altKey(){} // RVA: 0x485FD80
        public void get_actionKey(){} // RVA: 0x485FD90
        public void UnityEngine.UIElements.IPointerEventInternal.get_triggeredByOS(){} // RVA: 0xE35C60
        public void UnityEngine.UIElements.IPointerEventInternal.set_triggeredByOS(){} // RVA: 0xE39600
        public void UnityEngine.UIElements.IPointerEventInternal.get_compatibilityMouseEvent(){} // RVA: 0xBAE5A0
        public void UnityEngine.UIElements.IPointerEventInternal.set_compatibilityMouseEvent(){} // RVA: 0xBAE5B0
        public void UnityEngine.UIElements.IPointerEventInternal.set_displayIndex(){} // RVA: 0x485FE90
        public void Init(){} // RVA: 0x485FEA0
        public void LocalInit(){} // RVA: 0x485FF50
        public void get_currentTarget(){} // RVA: 0x46CB940
        public void set_currentTarget(){} // RVA: 0x48602A0
        public void IsMouse(){} // RVA: 0x48603D0
        public void IsTouch(){} // RVA: 0x4860470
        public void TiltToAzimuth(){} // RVA: 0x4860510
        public void AzimuthAndAlitutudeToTilt(){} // RVA: 0x4860620
        public void TiltToAltitude(){} // RVA: 0x48606C0
        public void GetPooled(){} // RVA: 0x4863AB0
        public void PreDispatch(){} // RVA: 0x4864070
        public void PostDispatch(){} // RVA: 0x4864220
        public void Dispatch(){} // RVA: 0x4864440
        public void .ctor(){} // RVA: 0x48644E0
    }

    public class PointerEventBase`1 : EventBase`1
    {
        public object k_DefaultButtonPressure;
        public object m_AltitudeNeedsConversion;
        public object m_AzimuthNeedsConversion;
        public object m_AltitudeAngle;
        public object m_AzimuthAngle;
        public object m_TiltNeeded;
        public object m_Tilt;
        public object _pointerId;
        public object _pointerType;
        public object _isPrimary;
        public object _button;
        public object _pressedButtons;
        public object _position;
        public object _localPosition;
        public object _deltaPosition;
        public object _deltaTime;
        public object _clickCount;
        public object _pressure;
        public object _tangentialPressure;
        public object _twist;
        public object _penStatus;
        public object _radius;
        public object _radiusVariance;
        public object _modifiers;
        public object _triggeredByOS;
        public object _compatibilityMouseEvent;
        public object _displayIndex;

        // ── Methods ──
        public void get_pointerId(){} // RVA: 0xD34760
        public void set_pointerId(){} // RVA: 0xD34750
        public void get_pointerType(){} // RVA: 0xB813B0
        public void set_pointerType(){} // RVA: 0xD5CBB0
        public void get_isPrimary(){} // RVA: 0x1C4D9A0
        public void set_isPrimary(){} // RVA: 0x1C4DB10
        public void get_button(){} // RVA: 0xF3A940
        public void set_button(){} // RVA: 0x11A0AB0
        public void get_pressedButtons(){} // RVA: 0x262A930
        public void set_pressedButtons(){} // RVA: 0x262A900
        public void get_position(){} // RVA: 0x485F7C0
        public void set_position(){} // RVA: 0x485F7E0
        public void get_localPosition(){} // RVA: 0x485F800
        public void set_localPosition(){} // RVA: 0x485F820
        public void get_deltaPosition(){} // RVA: 0x485F840
        public void set_deltaPosition(){} // RVA: 0x485F860
        public void get_deltaTime(){} // RVA: 0x485F880
        public void set_deltaTime(){} // RVA: 0x485F890
        public void get_clickCount(){} // RVA: 0x485F8A0
        public void set_clickCount(){} // RVA: 0x485F8B0
        public void get_pressure(){} // RVA: 0xB63B80
        public void set_pressure(){} // RVA: 0xB63B90
        public void get_tangentialPressure(){} // RVA: 0xB63BA0
        public void set_tangentialPressure(){} // RVA: 0xB63BB0
        public void get_altitudeAngle(){} // RVA: 0x485F8C0
        public void set_altitudeAngle(){} // RVA: 0x485F940
        public void get_azimuthAngle(){} // RVA: 0x485F950
        public void set_azimuthAngle(){} // RVA: 0x485FA70
        public void get_twist(){} // RVA: 0x100D250
        public void set_twist(){} // RVA: 0x485FA80
        public void get_tilt(){} // RVA: 0x485FA90
        public void set_tilt(){} // RVA: 0x485FCB0
        public void get_penStatus(){} // RVA: 0x25585B0
        public void set_penStatus(){} // RVA: 0x485FCC0
        public void get_radius(){} // RVA: 0x485FCD0
        public void set_radius(){} // RVA: 0x485FCF0
        public void get_radiusVariance(){} // RVA: 0x485FD00
        public void set_radiusVariance(){} // RVA: 0x485FD20
        public void get_modifiers(){} // RVA: 0x485FD30
        public void set_modifiers(){} // RVA: 0x485FD40
        public void get_shiftKey(){} // RVA: 0x485FD50
        public void get_ctrlKey(){} // RVA: 0x485FD60
        public void get_commandKey(){} // RVA: 0x485FD70
        public void get_altKey(){} // RVA: 0x485FD80
        public void get_actionKey(){} // RVA: 0x485FD90
        public void UnityEngine.UIElements.IPointerEventInternal.get_triggeredByOS(){} // RVA: 0xE35C60
        public void UnityEngine.UIElements.IPointerEventInternal.set_triggeredByOS(){} // RVA: 0xE39600
        public void UnityEngine.UIElements.IPointerEventInternal.get_compatibilityMouseEvent(){} // RVA: 0xBAE5A0
        public void UnityEngine.UIElements.IPointerEventInternal.set_compatibilityMouseEvent(){} // RVA: 0xBAE5B0
        public void UnityEngine.UIElements.IPointerEventInternal.set_displayIndex(){} // RVA: 0x485FE90
        public void Init(){} // RVA: 0x485FEA0
        public void LocalInit(){} // RVA: 0x485FF50
        public void get_currentTarget(){} // RVA: 0x46CB940
        public void set_currentTarget(){} // RVA: 0x48602A0
        public void IsMouse(){} // RVA: 0x48603D0
        public void IsTouch(){} // RVA: 0x4860470
        public void TiltToAzimuth(){} // RVA: 0x4860510
        public void AzimuthAndAlitutudeToTilt(){} // RVA: 0x4860620
        public void TiltToAltitude(){} // RVA: 0x48606C0
        public void GetPooled(){} // RVA: 0x4863AB0
        public void PreDispatch(){} // RVA: 0x4864070
        public void PostDispatch(){} // RVA: 0x4864220
        public void Dispatch(){} // RVA: 0x4864440
        public void .ctor(){} // RVA: 0x48644E0
    }

    public class PointerEventBase`1 : EventBase`1
    {
        public object k_DefaultButtonPressure;
        public object m_AltitudeNeedsConversion;
        public object m_AzimuthNeedsConversion;
        public object m_AltitudeAngle;
        public object m_AzimuthAngle;
        public object m_TiltNeeded;
        public object m_Tilt;
        public object _pointerId;
        public object _pointerType;
        public object _isPrimary;
        public object _button;
        public object _pressedButtons;
        public object _position;
        public object _localPosition;
        public object _deltaPosition;
        public object _deltaTime;
        public object _clickCount;
        public object _pressure;
        public object _tangentialPressure;
        public object _twist;
        public object _penStatus;
        public object _radius;
        public object _radiusVariance;
        public object _modifiers;
        public object _triggeredByOS;
        public object _compatibilityMouseEvent;
        public object _displayIndex;

        // ── Methods ──
        public void get_pointerId(){} // RVA: 0xD34760
        public void set_pointerId(){} // RVA: 0xD34750
        public void get_pointerType(){} // RVA: 0xB813B0
        public void set_pointerType(){} // RVA: 0xD5CBB0
        public void get_isPrimary(){} // RVA: 0x1C4D9A0
        public void set_isPrimary(){} // RVA: 0x1C4DB10
        public void get_button(){} // RVA: 0xF3A940
        public void set_button(){} // RVA: 0x11A0AB0
        public void get_pressedButtons(){} // RVA: 0x262A930
        public void set_pressedButtons(){} // RVA: 0x262A900
        public void get_position(){} // RVA: 0x485F7C0
        public void set_position(){} // RVA: 0x485F7E0
        public void get_localPosition(){} // RVA: 0x485F800
        public void set_localPosition(){} // RVA: 0x485F820
        public void get_deltaPosition(){} // RVA: 0x485F840
        public void set_deltaPosition(){} // RVA: 0x485F860
        public void get_deltaTime(){} // RVA: 0x485F880
        public void set_deltaTime(){} // RVA: 0x485F890
        public void get_clickCount(){} // RVA: 0x485F8A0
        public void set_clickCount(){} // RVA: 0x485F8B0
        public void get_pressure(){} // RVA: 0xB63B80
        public void set_pressure(){} // RVA: 0xB63B90
        public void get_tangentialPressure(){} // RVA: 0xB63BA0
        public void set_tangentialPressure(){} // RVA: 0xB63BB0
        public void get_altitudeAngle(){} // RVA: 0x485F8C0
        public void set_altitudeAngle(){} // RVA: 0x485F940
        public void get_azimuthAngle(){} // RVA: 0x485F950
        public void set_azimuthAngle(){} // RVA: 0x485FA70
        public void get_twist(){} // RVA: 0x100D250
        public void set_twist(){} // RVA: 0x485FA80
        public void get_tilt(){} // RVA: 0x485FA90
        public void set_tilt(){} // RVA: 0x485FCB0
        public void get_penStatus(){} // RVA: 0x25585B0
        public void set_penStatus(){} // RVA: 0x485FCC0
        public void get_radius(){} // RVA: 0x485FCD0
        public void set_radius(){} // RVA: 0x485FCF0
        public void get_radiusVariance(){} // RVA: 0x485FD00
        public void set_radiusVariance(){} // RVA: 0x485FD20
        public void get_modifiers(){} // RVA: 0x485FD30
        public void set_modifiers(){} // RVA: 0x485FD40
        public void get_shiftKey(){} // RVA: 0x485FD50
        public void get_ctrlKey(){} // RVA: 0x485FD60
        public void get_commandKey(){} // RVA: 0x485FD70
        public void get_altKey(){} // RVA: 0x485FD80
        public void get_actionKey(){} // RVA: 0x485FD90
        public void UnityEngine.UIElements.IPointerEventInternal.get_triggeredByOS(){} // RVA: 0xE35C60
        public void UnityEngine.UIElements.IPointerEventInternal.set_triggeredByOS(){} // RVA: 0xE39600
        public void UnityEngine.UIElements.IPointerEventInternal.get_compatibilityMouseEvent(){} // RVA: 0xBAE5A0
        public void UnityEngine.UIElements.IPointerEventInternal.set_compatibilityMouseEvent(){} // RVA: 0xBAE5B0
        public void UnityEngine.UIElements.IPointerEventInternal.set_displayIndex(){} // RVA: 0x485FE90
        public void Init(){} // RVA: 0x485FEA0
        public void LocalInit(){} // RVA: 0x485FF50
        public void get_currentTarget(){} // RVA: 0x46CB940
        public void set_currentTarget(){} // RVA: 0x48602A0
        public void IsMouse(){} // RVA: 0x48603D0
        public void IsTouch(){} // RVA: 0x4860470
        public void TiltToAzimuth(){} // RVA: 0x4860510
        public void AzimuthAndAlitutudeToTilt(){} // RVA: 0x4860620
        public void TiltToAltitude(){} // RVA: 0x48606C0
        public void GetPooled(){} // RVA: 0x4863AB0
        public void PreDispatch(){} // RVA: 0x4864070
        public void PostDispatch(){} // RVA: 0x4864220
        public void Dispatch(){} // RVA: 0x4864440
        public void .ctor(){} // RVA: 0x48644E0
    }

    public class PointerEventBase`1 : EventBase`1
    {
        public object k_DefaultButtonPressure;
        public object m_AltitudeNeedsConversion;
        public object m_AzimuthNeedsConversion;
        public object m_AltitudeAngle;
        public object m_AzimuthAngle;
        public object m_TiltNeeded;
        public object m_Tilt;
        public object _pointerId;
        public object _pointerType;
        public object _isPrimary;
        public object _button;
        public object _pressedButtons;
        public object _position;
        public object _localPosition;
        public object _deltaPosition;
        public object _deltaTime;
        public object _clickCount;
        public object _pressure;
        public object _tangentialPressure;
        public object _twist;
        public object _penStatus;
        public object _radius;
        public object _radiusVariance;
        public object _modifiers;
        public object _triggeredByOS;
        public object _compatibilityMouseEvent;
        public object _displayIndex;

        // ── Methods ──
        public void get_pointerId(){} // RVA: 0xD34760
        public void set_pointerId(){} // RVA: 0xD34750
        public void get_pointerType(){} // RVA: 0xB813B0
        public void set_pointerType(){} // RVA: 0xD5CBB0
        public void get_isPrimary(){} // RVA: 0x1C4D9A0
        public void set_isPrimary(){} // RVA: 0x1C4DB10
        public void get_button(){} // RVA: 0xF3A940
        public void set_button(){} // RVA: 0x11A0AB0
        public void get_pressedButtons(){} // RVA: 0x262A930
        public void set_pressedButtons(){} // RVA: 0x262A900
        public void get_position(){} // RVA: 0x485F7C0
        public void set_position(){} // RVA: 0x485F7E0
        public void get_localPosition(){} // RVA: 0x485F800
        public void set_localPosition(){} // RVA: 0x485F820
        public void get_deltaPosition(){} // RVA: 0x485F840
        public void set_deltaPosition(){} // RVA: 0x485F860
        public void get_deltaTime(){} // RVA: 0x485F880
        public void set_deltaTime(){} // RVA: 0x485F890
        public void get_clickCount(){} // RVA: 0x485F8A0
        public void set_clickCount(){} // RVA: 0x485F8B0
        public void get_pressure(){} // RVA: 0xB63B80
        public void set_pressure(){} // RVA: 0xB63B90
        public void get_tangentialPressure(){} // RVA: 0xB63BA0
        public void set_tangentialPressure(){} // RVA: 0xB63BB0
        public void get_altitudeAngle(){} // RVA: 0x485F8C0
        public void set_altitudeAngle(){} // RVA: 0x485F940
        public void get_azimuthAngle(){} // RVA: 0x485F950
        public void set_azimuthAngle(){} // RVA: 0x485FA70
        public void get_twist(){} // RVA: 0x100D250
        public void set_twist(){} // RVA: 0x485FA80
        public void get_tilt(){} // RVA: 0x485FA90
        public void set_tilt(){} // RVA: 0x485FCB0
        public void get_penStatus(){} // RVA: 0x25585B0
        public void set_penStatus(){} // RVA: 0x485FCC0
        public void get_radius(){} // RVA: 0x485FCD0
        public void set_radius(){} // RVA: 0x485FCF0
        public void get_radiusVariance(){} // RVA: 0x485FD00
        public void set_radiusVariance(){} // RVA: 0x485FD20
        public void get_modifiers(){} // RVA: 0x485FD30
        public void set_modifiers(){} // RVA: 0x485FD40
        public void get_shiftKey(){} // RVA: 0x485FD50
        public void get_ctrlKey(){} // RVA: 0x485FD60
        public void get_commandKey(){} // RVA: 0x485FD70
        public void get_altKey(){} // RVA: 0x485FD80
        public void get_actionKey(){} // RVA: 0x485FD90
        public void UnityEngine.UIElements.IPointerEventInternal.get_triggeredByOS(){} // RVA: 0xE35C60
        public void UnityEngine.UIElements.IPointerEventInternal.set_triggeredByOS(){} // RVA: 0xE39600
        public void UnityEngine.UIElements.IPointerEventInternal.get_compatibilityMouseEvent(){} // RVA: 0xBAE5A0
        public void UnityEngine.UIElements.IPointerEventInternal.set_compatibilityMouseEvent(){} // RVA: 0xBAE5B0
        public void UnityEngine.UIElements.IPointerEventInternal.set_displayIndex(){} // RVA: 0x485FE90
        public void Init(){} // RVA: 0x485FEA0
        public void LocalInit(){} // RVA: 0x485FF50
        public void get_currentTarget(){} // RVA: 0x46CB940
        public void set_currentTarget(){} // RVA: 0x48602A0
        public void IsMouse(){} // RVA: 0x48603D0
        public void IsTouch(){} // RVA: 0x4860470
        public void TiltToAzimuth(){} // RVA: 0x4860510
        public void AzimuthAndAlitutudeToTilt(){} // RVA: 0x4860620
        public void TiltToAltitude(){} // RVA: 0x48606C0
        public void GetPooled(){} // RVA: 0x4863AB0
        public void PreDispatch(){} // RVA: 0x4864070
        public void PostDispatch(){} // RVA: 0x4864220
        public void Dispatch(){} // RVA: 0x4864440
        public void .ctor(){} // RVA: 0x48644E0
    }

    public class PointerEventBase`1 : EventBase`1
    {
        public object k_DefaultButtonPressure;
        public object m_AltitudeNeedsConversion;
        public object m_AzimuthNeedsConversion;
        public object m_AltitudeAngle;
        public object m_AzimuthAngle;
        public object m_TiltNeeded;
        public object m_Tilt;
        public object _pointerId;
        public object _pointerType;
        public object _isPrimary;
        public object _button;
        public object _pressedButtons;
        public object _position;
        public object _localPosition;
        public object _deltaPosition;
        public object _deltaTime;
        public object _clickCount;
        public object _pressure;
        public object _tangentialPressure;
        public object _twist;
        public object _penStatus;
        public object _radius;
        public object _radiusVariance;
        public object _modifiers;
        public object _triggeredByOS;
        public object _compatibilityMouseEvent;
        public object _displayIndex;

        // ── Methods ──
        public void get_pointerId(){} // RVA: 0xD34760
        public void set_pointerId(){} // RVA: 0xD34750
        public void get_pointerType(){} // RVA: 0xB813B0
        public void set_pointerType(){} // RVA: 0xD5CBB0
        public void get_isPrimary(){} // RVA: 0x1C4D9A0
        public void set_isPrimary(){} // RVA: 0x1C4DB10
        public void get_button(){} // RVA: 0xF3A940
        public void set_button(){} // RVA: 0x11A0AB0
        public void get_pressedButtons(){} // RVA: 0x262A930
        public void set_pressedButtons(){} // RVA: 0x262A900
        public void get_position(){} // RVA: 0x485F7C0
        public void set_position(){} // RVA: 0x485F7E0
        public void get_localPosition(){} // RVA: 0x485F800
        public void set_localPosition(){} // RVA: 0x485F820
        public void get_deltaPosition(){} // RVA: 0x485F840
        public void set_deltaPosition(){} // RVA: 0x485F860
        public void get_deltaTime(){} // RVA: 0x485F880
        public void set_deltaTime(){} // RVA: 0x485F890
        public void get_clickCount(){} // RVA: 0x485F8A0
        public void set_clickCount(){} // RVA: 0x485F8B0
        public void get_pressure(){} // RVA: 0xB63B80
        public void set_pressure(){} // RVA: 0xB63B90
        public void get_tangentialPressure(){} // RVA: 0xB63BA0
        public void set_tangentialPressure(){} // RVA: 0xB63BB0
        public void get_altitudeAngle(){} // RVA: 0x485F8C0
        public void set_altitudeAngle(){} // RVA: 0x485F940
        public void get_azimuthAngle(){} // RVA: 0x485F950
        public void set_azimuthAngle(){} // RVA: 0x485FA70
        public void get_twist(){} // RVA: 0x100D250
        public void set_twist(){} // RVA: 0x485FA80
        public void get_tilt(){} // RVA: 0x485FA90
        public void set_tilt(){} // RVA: 0x485FCB0
        public void get_penStatus(){} // RVA: 0x25585B0
        public void set_penStatus(){} // RVA: 0x485FCC0
        public void get_radius(){} // RVA: 0x485FCD0
        public void set_radius(){} // RVA: 0x485FCF0
        public void get_radiusVariance(){} // RVA: 0x485FD00
        public void set_radiusVariance(){} // RVA: 0x485FD20
        public void get_modifiers(){} // RVA: 0x485FD30
        public void set_modifiers(){} // RVA: 0x485FD40
        public void get_shiftKey(){} // RVA: 0x485FD50
        public void get_ctrlKey(){} // RVA: 0x485FD60
        public void get_commandKey(){} // RVA: 0x485FD70
        public void get_altKey(){} // RVA: 0x485FD80
        public void get_actionKey(){} // RVA: 0x485FD90
        public void UnityEngine.UIElements.IPointerEventInternal.get_triggeredByOS(){} // RVA: 0xE35C60
        public void UnityEngine.UIElements.IPointerEventInternal.set_triggeredByOS(){} // RVA: 0xE39600
        public void UnityEngine.UIElements.IPointerEventInternal.get_compatibilityMouseEvent(){} // RVA: 0xBAE5A0
        public void UnityEngine.UIElements.IPointerEventInternal.set_compatibilityMouseEvent(){} // RVA: 0xBAE5B0
        public void UnityEngine.UIElements.IPointerEventInternal.set_displayIndex(){} // RVA: 0x485FE90
        public void Init(){} // RVA: 0x485FEA0
        public void LocalInit(){} // RVA: 0x485FF50
        public void get_currentTarget(){} // RVA: 0x46CB940
        public void set_currentTarget(){} // RVA: 0x48602A0
        public void IsMouse(){} // RVA: 0x48603D0
        public void IsTouch(){} // RVA: 0x4860470
        public void TiltToAzimuth(){} // RVA: 0x4860510
        public void AzimuthAndAlitutudeToTilt(){} // RVA: 0x4860620
        public void TiltToAltitude(){} // RVA: 0x48606C0
        public void GetPooled(){} // RVA: 0x4863AB0
        public void PreDispatch(){} // RVA: 0x4864070
        public void PostDispatch(){} // RVA: 0x4864220
        public void Dispatch(){} // RVA: 0x4864440
        public void .ctor(){} // RVA: 0x48644E0
    }

    public class PointerEventBase`1 : EventBase`1
    {
        public object k_DefaultButtonPressure;
        public object m_AltitudeNeedsConversion;
        public object m_AzimuthNeedsConversion;
        public object m_AltitudeAngle;
        public object m_AzimuthAngle;
        public object m_TiltNeeded;
        public object m_Tilt;
        public object _pointerId;
        public object _pointerType;
        public object _isPrimary;
        public object _button;
        public object _pressedButtons;
        public object _position;
        public object _localPosition;
        public object _deltaPosition;
        public object _deltaTime;
        public object _clickCount;
        public object _pressure;
        public object _tangentialPressure;
        public object _twist;
        public object _penStatus;
        public object _radius;
        public object _radiusVariance;
        public object _modifiers;
        public object _triggeredByOS;
        public object _compatibilityMouseEvent;
        public object _displayIndex;

        // ── Methods ──
        public void get_pointerId(){} // RVA: 0xD34760
        public void set_pointerId(){} // RVA: 0xD34750
        public void get_pointerType(){} // RVA: 0xB813B0
        public void set_pointerType(){} // RVA: 0xD5CBB0
        public void get_isPrimary(){} // RVA: 0x1C4D9A0
        public void set_isPrimary(){} // RVA: 0x1C4DB10
        public void get_button(){} // RVA: 0xF3A940
        public void set_button(){} // RVA: 0x11A0AB0
        public void get_pressedButtons(){} // RVA: 0x262A930
        public void set_pressedButtons(){} // RVA: 0x262A900
        public void get_position(){} // RVA: 0x485F7C0
        public void set_position(){} // RVA: 0x485F7E0
        public void get_localPosition(){} // RVA: 0x485F800
        public void set_localPosition(){} // RVA: 0x485F820
        public void get_deltaPosition(){} // RVA: 0x485F840
        public void set_deltaPosition(){} // RVA: 0x485F860
        public void get_deltaTime(){} // RVA: 0x485F880
        public void set_deltaTime(){} // RVA: 0x485F890
        public void get_clickCount(){} // RVA: 0x485F8A0
        public void set_clickCount(){} // RVA: 0x485F8B0
        public void get_pressure(){} // RVA: 0xB63B80
        public void set_pressure(){} // RVA: 0xB63B90
        public void get_tangentialPressure(){} // RVA: 0xB63BA0
        public void set_tangentialPressure(){} // RVA: 0xB63BB0
        public void get_altitudeAngle(){} // RVA: 0x485F8C0
        public void set_altitudeAngle(){} // RVA: 0x485F940
        public void get_azimuthAngle(){} // RVA: 0x485F950
        public void set_azimuthAngle(){} // RVA: 0x485FA70
        public void get_twist(){} // RVA: 0x100D250
        public void set_twist(){} // RVA: 0x485FA80
        public void get_tilt(){} // RVA: 0x485FA90
        public void set_tilt(){} // RVA: 0x485FCB0
        public void get_penStatus(){} // RVA: 0x25585B0
        public void set_penStatus(){} // RVA: 0x485FCC0
        public void get_radius(){} // RVA: 0x485FCD0
        public void set_radius(){} // RVA: 0x485FCF0
        public void get_radiusVariance(){} // RVA: 0x485FD00
        public void set_radiusVariance(){} // RVA: 0x485FD20
        public void get_modifiers(){} // RVA: 0x485FD30
        public void set_modifiers(){} // RVA: 0x485FD40
        public void get_shiftKey(){} // RVA: 0x485FD50
        public void get_ctrlKey(){} // RVA: 0x485FD60
        public void get_commandKey(){} // RVA: 0x485FD70
        public void get_altKey(){} // RVA: 0x485FD80
        public void get_actionKey(){} // RVA: 0x485FD90
        public void UnityEngine.UIElements.IPointerEventInternal.get_triggeredByOS(){} // RVA: 0xE35C60
        public void UnityEngine.UIElements.IPointerEventInternal.set_triggeredByOS(){} // RVA: 0xE39600
        public void UnityEngine.UIElements.IPointerEventInternal.get_compatibilityMouseEvent(){} // RVA: 0xBAE5A0
        public void UnityEngine.UIElements.IPointerEventInternal.set_compatibilityMouseEvent(){} // RVA: 0xBAE5B0
        public void UnityEngine.UIElements.IPointerEventInternal.set_displayIndex(){} // RVA: 0x485FE90
        public void Init(){} // RVA: 0x485FEA0
        public void LocalInit(){} // RVA: 0x485FF50
        public void get_currentTarget(){} // RVA: 0x46CB940
        public void set_currentTarget(){} // RVA: 0x48602A0
        public void IsMouse(){} // RVA: 0x48603D0
        public void IsTouch(){} // RVA: 0x4860470
        public void TiltToAzimuth(){} // RVA: 0x4860510
        public void AzimuthAndAlitutudeToTilt(){} // RVA: 0x4860620
        public void TiltToAltitude(){} // RVA: 0x48606C0
        public void GetPooled(){} // RVA: 0x4863AB0
        public void PreDispatch(){} // RVA: 0x4864070
        public void PostDispatch(){} // RVA: 0x4864220
        public void Dispatch(){} // RVA: 0x4864440
        public void .ctor(){} // RVA: 0x48644E0
    }

    public class PointerEventBase`1 : EventBase`1
    {
        public object k_DefaultButtonPressure;
        public object m_AltitudeNeedsConversion;
        public object m_AzimuthNeedsConversion;
        public object m_AltitudeAngle;
        public object m_AzimuthAngle;
        public object m_TiltNeeded;
        public object m_Tilt;
        public object _pointerId;
        public object _pointerType;
        public object _isPrimary;
        public object _button;
        public object _pressedButtons;
        public object _position;
        public object _localPosition;
        public object _deltaPosition;
        public object _deltaTime;
        public object _clickCount;
        public object _pressure;
        public object _tangentialPressure;
        public object _twist;
        public object _penStatus;
        public object _radius;
        public object _radiusVariance;
        public object _modifiers;
        public object _triggeredByOS;
        public object _compatibilityMouseEvent;
        public object _displayIndex;

        // ── Methods ──
        public void get_pointerId(){} // RVA: 0xD34760
        public void set_pointerId(){} // RVA: 0xD34750
        public void get_pointerType(){} // RVA: 0xB813B0
        public void set_pointerType(){} // RVA: 0xD5CBB0
        public void get_isPrimary(){} // RVA: 0x1C4D9A0
        public void set_isPrimary(){} // RVA: 0x1C4DB10
        public void get_button(){} // RVA: 0xF3A940
        public void set_button(){} // RVA: 0x11A0AB0
        public void get_pressedButtons(){} // RVA: 0x262A930
        public void set_pressedButtons(){} // RVA: 0x262A900
        public void get_position(){} // RVA: 0x485F7C0
        public void set_position(){} // RVA: 0x485F7E0
        public void get_localPosition(){} // RVA: 0x485F800
        public void set_localPosition(){} // RVA: 0x485F820
        public void get_deltaPosition(){} // RVA: 0x485F840
        public void set_deltaPosition(){} // RVA: 0x485F860
        public void get_deltaTime(){} // RVA: 0x485F880
        public void set_deltaTime(){} // RVA: 0x485F890
        public void get_clickCount(){} // RVA: 0x485F8A0
        public void set_clickCount(){} // RVA: 0x485F8B0
        public void get_pressure(){} // RVA: 0xB63B80
        public void set_pressure(){} // RVA: 0xB63B90
        public void get_tangentialPressure(){} // RVA: 0xB63BA0
        public void set_tangentialPressure(){} // RVA: 0xB63BB0
        public void get_altitudeAngle(){} // RVA: 0x485F8C0
        public void set_altitudeAngle(){} // RVA: 0x485F940
        public void get_azimuthAngle(){} // RVA: 0x485F950
        public void set_azimuthAngle(){} // RVA: 0x485FA70
        public void get_twist(){} // RVA: 0x100D250
        public void set_twist(){} // RVA: 0x485FA80
        public void get_tilt(){} // RVA: 0x485FA90
        public void set_tilt(){} // RVA: 0x485FCB0
        public void get_penStatus(){} // RVA: 0x25585B0
        public void set_penStatus(){} // RVA: 0x485FCC0
        public void get_radius(){} // RVA: 0x485FCD0
        public void set_radius(){} // RVA: 0x485FCF0
        public void get_radiusVariance(){} // RVA: 0x485FD00
        public void set_radiusVariance(){} // RVA: 0x485FD20
        public void get_modifiers(){} // RVA: 0x485FD30
        public void set_modifiers(){} // RVA: 0x485FD40
        public void get_shiftKey(){} // RVA: 0x485FD50
        public void get_ctrlKey(){} // RVA: 0x485FD60
        public void get_commandKey(){} // RVA: 0x485FD70
        public void get_altKey(){} // RVA: 0x485FD80
        public void get_actionKey(){} // RVA: 0x485FD90
        public void UnityEngine.UIElements.IPointerEventInternal.get_triggeredByOS(){} // RVA: 0xE35C60
        public void UnityEngine.UIElements.IPointerEventInternal.set_triggeredByOS(){} // RVA: 0xE39600
        public void UnityEngine.UIElements.IPointerEventInternal.get_compatibilityMouseEvent(){} // RVA: 0xBAE5A0
        public void UnityEngine.UIElements.IPointerEventInternal.set_compatibilityMouseEvent(){} // RVA: 0xBAE5B0
        public void UnityEngine.UIElements.IPointerEventInternal.set_displayIndex(){} // RVA: 0x485FE90
        public void Init(){} // RVA: 0x485FEA0
        public void LocalInit(){} // RVA: 0x485FF50
        public void get_currentTarget(){} // RVA: 0x46CB940
        public void set_currentTarget(){} // RVA: 0x48602A0
        public void IsMouse(){} // RVA: 0x48603D0
        public void IsTouch(){} // RVA: 0x4860470
        public void TiltToAzimuth(){} // RVA: 0x4860510
        public void AzimuthAndAlitutudeToTilt(){} // RVA: 0x4860620
        public void TiltToAltitude(){} // RVA: 0x48606C0
        public void GetPooled(){} // RVA: 0x4863AB0
        public void PreDispatch(){} // RVA: 0x4864070
        public void PostDispatch(){} // RVA: 0x4864220
        public void Dispatch(){} // RVA: 0x4864440
        public void .ctor(){} // RVA: 0x48644E0
    }

    public class PointerEventBase`1 : EventBase`1
    {
        public object k_DefaultButtonPressure;
        public object m_AltitudeNeedsConversion;
        public object m_AzimuthNeedsConversion;
        public object m_AltitudeAngle;
        public object m_AzimuthAngle;
        public object m_TiltNeeded;
        public object m_Tilt;
        public object _pointerId;
        public object _pointerType;
        public object _isPrimary;
        public object _button;
        public object _pressedButtons;
        public object _position;
        public object _localPosition;
        public object _deltaPosition;
        public object _deltaTime;
        public object _clickCount;
        public object _pressure;
        public object _tangentialPressure;
        public object _twist;
        public object _penStatus;
        public object _radius;
        public object _radiusVariance;
        public object _modifiers;
        public object _triggeredByOS;
        public object _compatibilityMouseEvent;
        public object _displayIndex;

        // ── Methods ──
        public void get_pointerId(){} // RVA: 0xD34760
        public void set_pointerId(){} // RVA: 0xD34750
        public void get_pointerType(){} // RVA: 0xB813B0
        public void set_pointerType(){} // RVA: 0xD5CBB0
        public void get_isPrimary(){} // RVA: 0x1C4D9A0
        public void set_isPrimary(){} // RVA: 0x1C4DB10
        public void get_button(){} // RVA: 0xF3A940
        public void set_button(){} // RVA: 0x11A0AB0
        public void get_pressedButtons(){} // RVA: 0x262A930
        public void set_pressedButtons(){} // RVA: 0x262A900
        public void get_position(){} // RVA: 0x485F7C0
        public void set_position(){} // RVA: 0x485F7E0
        public void get_localPosition(){} // RVA: 0x485F800
        public void set_localPosition(){} // RVA: 0x485F820
        public void get_deltaPosition(){} // RVA: 0x485F840
        public void set_deltaPosition(){} // RVA: 0x485F860
        public void get_deltaTime(){} // RVA: 0x485F880
        public void set_deltaTime(){} // RVA: 0x485F890
        public void get_clickCount(){} // RVA: 0x485F8A0
        public void set_clickCount(){} // RVA: 0x485F8B0
        public void get_pressure(){} // RVA: 0xB63B80
        public void set_pressure(){} // RVA: 0xB63B90
        public void get_tangentialPressure(){} // RVA: 0xB63BA0
        public void set_tangentialPressure(){} // RVA: 0xB63BB0
        public void get_altitudeAngle(){} // RVA: 0x485F8C0
        public void set_altitudeAngle(){} // RVA: 0x485F940
        public void get_azimuthAngle(){} // RVA: 0x485F950
        public void set_azimuthAngle(){} // RVA: 0x485FA70
        public void get_twist(){} // RVA: 0x100D250
        public void set_twist(){} // RVA: 0x485FA80
        public void get_tilt(){} // RVA: 0x485FA90
        public void set_tilt(){} // RVA: 0x485FCB0
        public void get_penStatus(){} // RVA: 0x25585B0
        public void set_penStatus(){} // RVA: 0x485FCC0
        public void get_radius(){} // RVA: 0x485FCD0
        public void set_radius(){} // RVA: 0x485FCF0
        public void get_radiusVariance(){} // RVA: 0x485FD00
        public void set_radiusVariance(){} // RVA: 0x485FD20
        public void get_modifiers(){} // RVA: 0x485FD30
        public void set_modifiers(){} // RVA: 0x485FD40
        public void get_shiftKey(){} // RVA: 0x485FD50
        public void get_ctrlKey(){} // RVA: 0x485FD60
        public void get_commandKey(){} // RVA: 0x485FD70
        public void get_altKey(){} // RVA: 0x485FD80
        public void get_actionKey(){} // RVA: 0x485FD90
        public void UnityEngine.UIElements.IPointerEventInternal.get_triggeredByOS(){} // RVA: 0xE35C60
        public void UnityEngine.UIElements.IPointerEventInternal.set_triggeredByOS(){} // RVA: 0xE39600
        public void UnityEngine.UIElements.IPointerEventInternal.get_compatibilityMouseEvent(){} // RVA: 0xBAE5A0
        public void UnityEngine.UIElements.IPointerEventInternal.set_compatibilityMouseEvent(){} // RVA: 0xBAE5B0
        public void UnityEngine.UIElements.IPointerEventInternal.set_displayIndex(){} // RVA: 0x485FE90
        public void Init(){} // RVA: 0x485FEA0
        public void LocalInit(){} // RVA: 0x485FF50
        public void get_currentTarget(){} // RVA: 0x46CB940
        public void set_currentTarget(){} // RVA: 0x48602A0
        public void IsMouse(){} // RVA: 0x48603D0
        public void IsTouch(){} // RVA: 0x4860470
        public void TiltToAzimuth(){} // RVA: 0x4860510
        public void AzimuthAndAlitutudeToTilt(){} // RVA: 0x4860620
        public void TiltToAltitude(){} // RVA: 0x48606C0
        public void GetPooled(){} // RVA: 0x4863AB0
        public void PreDispatch(){} // RVA: 0x4864070
        public void PostDispatch(){} // RVA: 0x4864220
        public void Dispatch(){} // RVA: 0x4864440
        public void .ctor(){} // RVA: 0x48644E0
    }

    public class PointerEventBase`1 : EventBase`1
    {
        public object k_DefaultButtonPressure;
        public object m_AltitudeNeedsConversion;
        public object m_AzimuthNeedsConversion;
        public object m_AltitudeAngle;
        public object m_AzimuthAngle;
        public object m_TiltNeeded;
        public object m_Tilt;
        public object _pointerId;
        public object _pointerType;
        public object _isPrimary;
        public object _button;
        public object _pressedButtons;
        public object _position;
        public object _localPosition;
        public object _deltaPosition;
        public object _deltaTime;
        public object _clickCount;
        public object _pressure;
        public object _tangentialPressure;
        public object _twist;
        public object _penStatus;
        public object _radius;
        public object _radiusVariance;
        public object _modifiers;
        public object _triggeredByOS;
        public object _compatibilityMouseEvent;
        public object _displayIndex;

        // ── Methods ──
        public void get_pointerId(){} // RVA: 0xD34760
        public void set_pointerId(){} // RVA: 0xD34750
        public void get_pointerType(){} // RVA: 0xB813B0
        public void set_pointerType(){} // RVA: 0xD5CBB0
        public void get_isPrimary(){} // RVA: 0x1C4D9A0
        public void set_isPrimary(){} // RVA: 0x1C4DB10
        public void get_button(){} // RVA: 0xF3A940
        public void set_button(){} // RVA: 0x11A0AB0
        public void get_pressedButtons(){} // RVA: 0x262A930
        public void set_pressedButtons(){} // RVA: 0x262A900
        public void get_position(){} // RVA: 0x485F7C0
        public void set_position(){} // RVA: 0x485F7E0
        public void get_localPosition(){} // RVA: 0x485F800
        public void set_localPosition(){} // RVA: 0x485F820
        public void get_deltaPosition(){} // RVA: 0x485F840
        public void set_deltaPosition(){} // RVA: 0x485F860
        public void get_deltaTime(){} // RVA: 0x485F880
        public void set_deltaTime(){} // RVA: 0x485F890
        public void get_clickCount(){} // RVA: 0x485F8A0
        public void set_clickCount(){} // RVA: 0x485F8B0
        public void get_pressure(){} // RVA: 0xB63B80
        public void set_pressure(){} // RVA: 0xB63B90
        public void get_tangentialPressure(){} // RVA: 0xB63BA0
        public void set_tangentialPressure(){} // RVA: 0xB63BB0
        public void get_altitudeAngle(){} // RVA: 0x485F8C0
        public void set_altitudeAngle(){} // RVA: 0x485F940
        public void get_azimuthAngle(){} // RVA: 0x485F950
        public void set_azimuthAngle(){} // RVA: 0x485FA70
        public void get_twist(){} // RVA: 0x100D250
        public void set_twist(){} // RVA: 0x485FA80
        public void get_tilt(){} // RVA: 0x485FA90
        public void set_tilt(){} // RVA: 0x485FCB0
        public void get_penStatus(){} // RVA: 0x25585B0
        public void set_penStatus(){} // RVA: 0x485FCC0
        public void get_radius(){} // RVA: 0x485FCD0
        public void set_radius(){} // RVA: 0x485FCF0
        public void get_radiusVariance(){} // RVA: 0x485FD00
        public void set_radiusVariance(){} // RVA: 0x485FD20
        public void get_modifiers(){} // RVA: 0x485FD30
        public void set_modifiers(){} // RVA: 0x485FD40
        public void get_shiftKey(){} // RVA: 0x485FD50
        public void get_ctrlKey(){} // RVA: 0x485FD60
        public void get_commandKey(){} // RVA: 0x485FD70
        public void get_altKey(){} // RVA: 0x485FD80
        public void get_actionKey(){} // RVA: 0x485FD90
        public void UnityEngine.UIElements.IPointerEventInternal.get_triggeredByOS(){} // RVA: 0xE35C60
        public void UnityEngine.UIElements.IPointerEventInternal.set_triggeredByOS(){} // RVA: 0xE39600
        public void UnityEngine.UIElements.IPointerEventInternal.get_compatibilityMouseEvent(){} // RVA: 0xBAE5A0
        public void UnityEngine.UIElements.IPointerEventInternal.set_compatibilityMouseEvent(){} // RVA: 0xBAE5B0
        public void UnityEngine.UIElements.IPointerEventInternal.set_displayIndex(){} // RVA: 0x485FE90
        public void Init(){} // RVA: 0x485FEA0
        public void LocalInit(){} // RVA: 0x485FF50
        public void get_currentTarget(){} // RVA: 0x46CB940
        public void set_currentTarget(){} // RVA: 0x48602A0
        public void IsMouse(){} // RVA: 0x48603D0
        public void IsTouch(){} // RVA: 0x4860470
        public void TiltToAzimuth(){} // RVA: 0x4860510
        public void AzimuthAndAlitutudeToTilt(){} // RVA: 0x4860620
        public void TiltToAltitude(){} // RVA: 0x48606C0
        public void GetPooled(){} // RVA: 0x4863AB0
        public void PreDispatch(){} // RVA: 0x4864070
        public void PostDispatch(){} // RVA: 0x4864220
        public void Dispatch(){} // RVA: 0x4864440
        public void .ctor(){} // RVA: 0x48644E0
    }

    public class PointerEventBase`1 : EventBase`1
    {
        public object k_DefaultButtonPressure;
        public object m_AltitudeNeedsConversion;
        public object m_AzimuthNeedsConversion;
        public object m_AltitudeAngle;
        public object m_AzimuthAngle;
        public object m_TiltNeeded;
        public object m_Tilt;
        public object _pointerId;
        public object _pointerType;
        public object _isPrimary;
        public object _button;
        public object _pressedButtons;
        public object _position;
        public object _localPosition;
        public object _deltaPosition;
        public object _deltaTime;
        public object _clickCount;
        public object _pressure;
        public object _tangentialPressure;
        public object _twist;
        public object _penStatus;
        public object _radius;
        public object _radiusVariance;
        public object _modifiers;
        public object _triggeredByOS;
        public object _compatibilityMouseEvent;
        public object _displayIndex;

        // ── Methods ──
        public void get_pointerId(){} // RVA: 0xD34760
        public void set_pointerId(){} // RVA: 0xD34750
        public void get_pointerType(){} // RVA: 0xB813B0
        public void set_pointerType(){} // RVA: 0xD5CBB0
        public void get_isPrimary(){} // RVA: 0x1C4D9A0
        public void set_isPrimary(){} // RVA: 0x1C4DB10
        public void get_button(){} // RVA: 0xF3A940
        public void set_button(){} // RVA: 0x11A0AB0
        public void get_pressedButtons(){} // RVA: 0x262A930
        public void set_pressedButtons(){} // RVA: 0x262A900
        public void get_position(){} // RVA: 0x485F7C0
        public void set_position(){} // RVA: 0x485F7E0
        public void get_localPosition(){} // RVA: 0x485F800
        public void set_localPosition(){} // RVA: 0x485F820
        public void get_deltaPosition(){} // RVA: 0x485F840
        public void set_deltaPosition(){} // RVA: 0x485F860
        public void get_deltaTime(){} // RVA: 0x485F880
        public void set_deltaTime(){} // RVA: 0x485F890
        public void get_clickCount(){} // RVA: 0x485F8A0
        public void set_clickCount(){} // RVA: 0x485F8B0
        public void get_pressure(){} // RVA: 0xB63B80
        public void set_pressure(){} // RVA: 0xB63B90
        public void get_tangentialPressure(){} // RVA: 0xB63BA0
        public void set_tangentialPressure(){} // RVA: 0xB63BB0
        public void get_altitudeAngle(){} // RVA: 0x485F8C0
        public void set_altitudeAngle(){} // RVA: 0x485F940
        public void get_azimuthAngle(){} // RVA: 0x485F950
        public void set_azimuthAngle(){} // RVA: 0x485FA70
        public void get_twist(){} // RVA: 0x100D250
        public void set_twist(){} // RVA: 0x485FA80
        public void get_tilt(){} // RVA: 0x485FA90
        public void set_tilt(){} // RVA: 0x485FCB0
        public void get_penStatus(){} // RVA: 0x25585B0
        public void set_penStatus(){} // RVA: 0x485FCC0
        public void get_radius(){} // RVA: 0x485FCD0
        public void set_radius(){} // RVA: 0x485FCF0
        public void get_radiusVariance(){} // RVA: 0x485FD00
        public void set_radiusVariance(){} // RVA: 0x485FD20
        public void get_modifiers(){} // RVA: 0x485FD30
        public void set_modifiers(){} // RVA: 0x485FD40
        public void get_shiftKey(){} // RVA: 0x485FD50
        public void get_ctrlKey(){} // RVA: 0x485FD60
        public void get_commandKey(){} // RVA: 0x485FD70
        public void get_altKey(){} // RVA: 0x485FD80
        public void get_actionKey(){} // RVA: 0x485FD90
        public void UnityEngine.UIElements.IPointerEventInternal.get_triggeredByOS(){} // RVA: 0xE35C60
        public void UnityEngine.UIElements.IPointerEventInternal.set_triggeredByOS(){} // RVA: 0xE39600
        public void UnityEngine.UIElements.IPointerEventInternal.get_compatibilityMouseEvent(){} // RVA: 0xBAE5A0
        public void UnityEngine.UIElements.IPointerEventInternal.set_compatibilityMouseEvent(){} // RVA: 0xBAE5B0
        public void UnityEngine.UIElements.IPointerEventInternal.set_displayIndex(){} // RVA: 0x485FE90
        public void Init(){} // RVA: 0x485FEA0
        public void LocalInit(){} // RVA: 0x485FF50
        public void get_currentTarget(){} // RVA: 0x46CB940
        public void set_currentTarget(){} // RVA: 0x48602A0
        public void IsMouse(){} // RVA: 0x48603D0
        public void IsTouch(){} // RVA: 0x4860470
        public void TiltToAzimuth(){} // RVA: 0x4860510
        public void AzimuthAndAlitutudeToTilt(){} // RVA: 0x4860620
        public void TiltToAltitude(){} // RVA: 0x48606C0
        public void GetPooled(){} // RVA: 0x4863AB0
        public void PreDispatch(){} // RVA: 0x4864070
        public void PostDispatch(){} // RVA: 0x4864220
        public void Dispatch(){} // RVA: 0x4864440
        public void .ctor(){} // RVA: 0x48644E0
    }

    public class PointerEventHelper : Object
    {
        // ── Methods ──
        public void GetPooled(){} // RVA: 0x80669E0
    }

    public class PointerEventsHelper : Object
    {
        // ── Methods ──
        public void SendEnterLeave(){} // RVA: 0xA94080
        public void SendOverOut(){} // RVA: 0x8063BD0
    }

    public class PointerId : Object
    {
        public object maxPointers;
        public object invalidPointerId;
        public object mousePointerId;
        public object touchPointerIdBase;
        public object touchPointerCount;
        public object penPointerIdBase;
        public object penPointerCount;
        public object hoveringPointers;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x8066860
    }

    public class PointerLeaveEvent : PointerEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x8069A20
        public void Init(){} // RVA: 0x8069B10
        public void LocalInit(){} // RVA: 0xBDB7E0
        public void .ctor(){} // RVA: 0x8069B60
        public void Dispatch(){} // RVA: 0x8061660
        public void PreDispatch(){} // RVA: 0x8069BB0
    }

    public class PointerManipulator : MouseManipulator
    {
        public object m_CurrentPointerId;

        // ── Methods ──
        public void CanStartManipulation(){} // RVA: 0x80A3760
        public void CanStopManipulation(){} // RVA: 0x80A39A0
        public void .ctor(){} // RVA: 0x8083900
    }

    public class PointerMoveEvent : PointerEventBase`1
    {
        public object _isHandledByDraggable;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x8067150
        public void get_isHandledByDraggable(){} // RVA: 0x2443BA0
        public void set_isHandledByDraggable(){} // RVA: 0x2443BB0
        public void get_isPointerDown(){} // RVA: 0x8067240
        public void get_isPointerUp(){} // RVA: 0x80672B0
        public void Init(){} // RVA: 0x8067320
        public void LocalInit(){} // RVA: 0x80673B0
        public void .ctor(){} // RVA: 0x8067410
        public void PreDispatch(){} // RVA: 0x80674A0
        public void PostDispatch(){} // RVA: 0x8067780
    }

    public class PointerOutEvent : PointerEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x8069FB0
        public void Dispatch(){} // RVA: 0x8061660
        public void .ctor(){} // RVA: 0x806A0A0
    }

    public class PointerOverEvent : PointerEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x8069D70
        public void Dispatch(){} // RVA: 0x8061660
        public void .ctor(){} // RVA: 0x8069E60
    }

    public class PointerType : Object
    {
        public object mouse;
        public object touch;
        public object pen;
        public object unknown;

        // ── Methods ──
        public void GetPointerType(){} // RVA: 0x8066490
        public void IsDirectManipulationDevice(){} // RVA: 0x80665A0
        public void .cctor(){} // RVA: 0x8066630
    }

    public class PointerUpEvent : PointerEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x80685D0
        public void Init(){} // RVA: 0x80686C0
        public void LocalInit(){} // RVA: 0x8068740
        public void .ctor(){} // RVA: 0x8068790
        public void PreDispatch(){} // RVA: 0x8068810
        public void PostDispatch(){} // RVA: 0x8068930
    }

    public class PopupField`1 : BasePopupField`2
    {
        public object indexProperty;
        public object m_Index;
        public object ussClassName;
        public object labelUssClassName;
        public object inputUssClassName;

        // ── Methods ──
        public void GetValueToDisplay(){} // RVA: 0x87C0A0
        public void GetListItemToDisplay(){} // RVA: 0xA94080
        public void get_value(){} // RVA: 0xA94080
        public void set_value(){} // RVA: 0xA94080
        public void SetValueWithoutNotify(){} // RVA: 0xA94080
        public void get_index(){} // RVA: 0x87C130
        public void set_index(){} // RVA: 0x8944F0
        public void .ctor(){} // RVA: 0x894320
        public void AddMenuItems(){} // RVA: 0x894320
        public void ChangeValueFromMenu(){} // RVA: 0xA94080
        public void .cctor(){} // RVA: 0x8942F0
    }

    public class PopupField`1 : BasePopupField`2
    {
        public object indexProperty;
        public object m_Index;
        public object ussClassName;
        public object labelUssClassName;
        public object inputUssClassName;

        // ── Methods ──
        public void GetValueToDisplay(){} // RVA: 0x4870860
        public void GetListItemToDisplay(){} // RVA: 0x4870970
        public void get_value(){} // RVA: 0x4870A10
        public void set_value(){} // RVA: 0x4870A30
        public void SetValueWithoutNotify(){} // RVA: 0x4870B40
        public void get_index(){} // RVA: 0x4870C40
        public void set_index(){} // RVA: 0x4870C50
        public void .ctor(){} // RVA: 0x4870D60
        public void AddMenuItems(){} // RVA: 0x4870EE0
        public void ChangeValueFromMenu(){} // RVA: 0x4871270
        public void .cctor(){} // RVA: 0x48712A0
    }

    public class PopupWindow : TextElement
    {
        public object m_ContentContainer;
        public object ussClassName;
        public object contentUssClassName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x800E5C0
        public void get_contentContainer(){} // RVA: 0x7FCF450
        public void .cctor(){} // RVA: 0x800E7F0
    }

    public class ProgressBar : AbstractProgressBar
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x8010A20
    }

    public class ProjectionUtils : Object
    {
        // ── Methods ──
        public void Ortho(){} // RVA: 0x80A3A10
    }

    public class PropagationPaths : Object
    {
        public object s_Pool;
        public object trickleDownPath;
        public object bubbleUpPath;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x806A1F0
        public void Build(){} // RVA: 0x806A410
        public void Dispose(){} // RVA: 0x806A630
        public void .cctor(){} // RVA: 0x806A720
    }

    public class PropertyChangedEvent : EventBase`1
    {
        public object _property;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7F2D800
        public void get_property(){} // RVA: 0x7F2D8F0
        public void set_property(){} // RVA: 0x7F2D970
        public void .ctor(){} // RVA: 0x7F2DA30
        public void GetPooled(){} // RVA: 0x7F2DAB0
    }

    public class PropertyPathInfo : ValueType
    {
        public object propertyPath;
        public object type;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x991800
    }

}