// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 12
// Methods: 254

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class Panel : BaseVisualElementPanel
    {
        public object visualTree;
        public object dispatcher;
        public object timerEventScheduler;
        public object scheduler;
        public object styleAnimationSystem;
        public object ownerObject;
        public object contextType;
        public object saveViewData;
        public object getViewDataDictionary;
        public object focusController;
        public object IMGUIEventInterests;
        public object loadResourceFunc;
        public object name;
        public object TimeSinceStartup;
        public object IMGUIContainersCount;
        public object rootIMGUIContainer;
        public object version;
        public object hierarchyVersion;
        public object standardShader;
        public object atlas;

        // ── Methods ──
        public void get_visualTree(){} // RVA: 0x7FFD54D3FDA0
        public void get_dispatcher(){} // RVA: 0x7FFD4E916C80
        public void set_dispatcher(){} // RVA: 0x7FFD4E916750
        public void get_timerEventScheduler(){} // RVA: 0x7FFD54FC8310
        public void get_scheduler(){} // RVA: 0x7FFD54FC8310
        public void get_styleAnimationSystem(){} // RVA: 0x7FFD4E3AC0B0
        public void set_styleAnimationSystem(){} // RVA: 0x7FFD54FC83C0
        public void get_ownerObject(){} // RVA: 0x7FFD4E96B170
        public void set_ownerObject(){} // RVA: 0x7FFD4EDD3E10
        public void get_contextType(){} // RVA: 0x7FFD4FD861E0
        public void set_contextType(){} // RVA: 0x7FFD4FD861F0
        public void get_saveViewData(){} // RVA: 0x7FFD4E55CBB0
        public void get_getViewDataDictionary(){} // RVA: 0x7FFD4E9666F0
        public void get_focusController(){} // RVA: 0x7FFD4E964340
        public void set_focusController(){} // RVA: 0x7FFD4EDC79B0
        public void get_IMGUIEventInterests(){} // RVA: 0x7FFD54FC8480
        public void set_IMGUIEventInterests(){} // RVA: 0x7FFD54FC84A0
        public void get_loadResourceFunc(){} // RVA: 0x7FFD54FC84C0
        public void LoadResource(){} // RVA: 0x7FFD54FC8520
        public void Focus(){} // RVA: 0x7FFD54FC8630
        public void Blur(){} // RVA: 0x7FFD54FC8640
        public void ValidateFocus(){} // RVA: 0x7FFD54FC8760
        public void get_name(){} // RVA: 0x7FFD54D3FEF0
        public void set_name(){} // RVA: 0x7FFD54FC8830
        public void CreateMarkers(){} // RVA: 0x7FFD54FC8890
        public void get_TimeSinceStartup(){} // RVA: 0x7FFD54FC8D70
        public void get_IMGUIContainersCount(){} // RVA: 0x7FFD53CE7230
        public void set_IMGUIContainersCount(){} // RVA: 0x7FFD53CE7240
        public void get_rootIMGUIContainer(){} // RVA: 0x7FFD4E3AC5F0
        public void get_version(){} // RVA: 0x7FFD4EA61480
        public void get_hierarchyVersion(){} // RVA: 0x7FFD4EAB6B20
        public void get_standardShader(){} // RVA: 0x7FFD54FC8DD0
        public void get_atlas(){} // RVA: 0x7FFD54FC8DE0
        public void set_atlas(){} // RVA: 0x7FFD54FC8DF0
        public void .ctor(){} // RVA: 0x7FFD54FC8ED0
        public void Dispose(){} // RVA: 0x7FFD54FC9700
        public void TimeSinceStartupMs(){} // RVA: 0x7FFD54FC9870
        public void DefaultTimeSinceStartupMs(){} // RVA: 0x7FFD54FC9970
        public void PickAll(){} // RVA: 0x7FFD54FC9DE0 | overloaded x2
        public void PerformPick(){} // RVA: 0x7FFD54FC9A60
        public void Pick(){} // RVA: 0x7FFD54FC9ED0
        public void ValidateLayout(){} // RVA: 0x7FFD54FCA110
        public void UpdateAnimations(){} // RVA: 0x7FFD54FCA190
        public void UpdateBindings(){} // RVA: 0x7FFD54FCA1C0
        public void ApplyStyles(){} // RVA: 0x7FFD54FCA1F0
        public void UpdateForRepaint(){} // RVA: 0x7FFD54FCA220
        public void Repaint(){} // RVA: 0x7FFD54FCA2B0
        public void OnVersionChanged(){} // RVA: 0x7FFD54FCA710
        public void GetUpdater(){} // RVA: 0x7FFD54FCA880
        public void .cctor(){} // RVA: 0x7FFD54FCA8C0
        public void <Pick>g__PixelOf|101_0(){} // RVA: 0x7FFD54FCA970
    }

    public class PanelChangedEventBase`1 : EventBase`1
    {
        public ÎÏÌÎÎÎÌÌÌ.Stopped originPanel;
        public ÎÏÌÎÎÎÌÌÌ.Stopped destinationPanel;

        // ── Methods ──
        public void get_originPanel(){} // RVA: 0x7FFD4E078E90
        public void set_originPanel(){} // RVA: 0x7FFD4E090A40
        public void get_destinationPanel(){} // RVA: 0x7FFD4E078E90
        public void set_destinationPanel(){} // RVA: 0x7FFD4E090A40
        public void Init(){} // RVA: 0x7FFD4E090980
        public void LocalInit(){} // RVA: 0x7FFD4E090980
        public void GetPooled(){} // RVA: 0x7FFD4E2ADC40
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class PanelClearSettings : ValueType
    {
    }

    public class PanelEventHandler : UIBehaviour
    {
        public ÎÏÌÎÎÎÌÌÌ.ent panel; // 0x20
        public >>.get_IsReadOnly selectableGameObject; // 0x28
        public float eventSystem; // 0x30
        public bool isCurrentFocusedPanel; // 0x34
        public 5EC78E8E02279FB1266932E3468A575B0EB9818985DBE9468B991CCE currentFocusedElement; // 0x38
        public illingServiceDisconnected s_Modifiers;

        // ── Methods ──
        public void get_panel(){} // RVA: 0x7FFD4E36F0C0
        public void set_panel(){} // RVA: 0x7FFD55096850
        public void get_selectableGameObject(){} // RVA: 0x7FFD55096930
        public void get_eventSystem(){} // RVA: 0x7FFD55096950
        public void get_isCurrentFocusedPanel(){} // RVA: 0x7FFD55096A40
        public void get_currentFocusedElement(){} // RVA: 0x7FFD55096C50
        public void OnEnable(){} // RVA: 0x7FFD55096C90
        public void OnDisable(){} // RVA: 0x7FFD55096CA0
        public void RegisterCallbacks(){} // RVA: 0x7FFD55096CB0
        public void UnregisterCallbacks(){} // RVA: 0x7FFD55096E80
        public void OnPanelDestroyed(){} // RVA: 0x7FFD550970A0
        public void OnElementFocus(){} // RVA: 0x7FFD55097150
        public void OnElementBlur(){} // RVA: 0x7FFD4E341310
        public void OnSelect(){} // RVA: 0x7FFD55097260
        public void OnDeselect(){} // RVA: 0x7FFD550972A0
        public void OnPointerMove(){} // RVA: 0x7FFD550972C0
        public void OnPointerUp(){} // RVA: 0x7FFD55097410
        public void OnPointerDown(){} // RVA: 0x7FFD55097630
        public void OnPointerExit(){} // RVA: 0x7FFD550978D0
        public void OnPointerEnter(){} // RVA: 0x7FFD55097D80
        public void OnPointerClick(){} // RVA: 0x7FFD55097DF0
        public void OnSubmit(){} // RVA: 0x7FFD55097E50
        public void OnCancel(){} // RVA: 0x7FFD55098020
        public void OnMove(){} // RVA: 0x7FFD550981F0
        public void OnScroll(){} // RVA: 0x7FFD55098480
        public void SendEvent(){} // RVA: 0x7FFD550986E0 | overloaded x2
        public void Update(){} // RVA: 0x7FFD55098710
        public void LateUpdate(){} // RVA: 0x7FFD55098790
        public void ProcessImguiEvents(){} // RVA: 0x7FFD550987A0
        public void ProcessKeyboardEvent(){} // RVA: 0x7FFD55098980
        public void ProcessTabEvent(){} // RVA: 0x7FFD55098A80
        public void SendTabEvent(){} // RVA: 0x7FFD55098B30
        public void SendKeyUpEvent(){} // RVA: 0x7FFD55098D00
        public void SendKeyDownEvent(){} // RVA: 0x7FFD55098E70
        public void ReadPointerData(){} // RVA: 0x7FFD55098FE0
        public void .ctor(){} // RVA: 0x7FFD55099270
    }

    public class PanelRaycaster : BaseRaycaster
    {
        public ÎÏÌÎÎÎÌÌÌ.ent panel; // 0x28

        // ── Methods ──
        public void get_panel(){} // RVA: 0x7FFD4E36F130
        public void set_panel(){} // RVA: 0x7FFD55099C20
        public void RegisterCallbacks(){} // RVA: 0x7FFD55099DF0
        public void UnregisterCallbacks(){} // RVA: 0x7FFD55099E90
        public void OnPanelDestroyed(){} // RVA: 0x7FFD55099F30
        public void get_selectableGameObject(){} // RVA: 0x7FFD55099F40
        public void get_sortOrderPriority(){} // RVA: 0x7FFD55099F60
        public void get_renderOrderPriority(){} // RVA: 0x7FFD55099F80
        public void Raycast(){} // RVA: 0x7FFD5509A000
        public void get_eventCamera(){} // RVA: 0x7FFD4E919180
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class PanelSettings : ScriptableObject
    {
        public int themeStyleSheet;
        public float targetTexture;
        public string scaleMode;
        public ÎÏÌÎÎÎÌÌÌ._left referenceSpritePixelsPerUnit; // 0x18
        public Offset scale; // 0x20
        public ÎÏÌÎÎÎÌÌÌ.TabEvent referenceDpi; // 0x28
        public float fallbackDpi; // 0x2C
        public float referenceResolution; // 0x30
        public float screenMatchMode;
        public float match; // 0x34
        public float sortingOrder; // 0x38
        public onY targetDisplay; // 0x3C
        public ÎÏÌÎÎÎÌÌÌ.endingTouchEvents clearDepthStencil; // 0x44
        public float depthClearValue; // 0x48
        public float clearColor; // 0x4C
        public int colorClearValue; // 0x50
        public bool panel; // 0x54
        public bool visualTree; // 0x55
        public object dynamicAtlasSettings; // 0x58
        public object ScreenDPI; // 0x68
        public ÎÏÌÎÎÎÌÌÌ.ler m_AttachedUIDocumentsList; // 0x70
        public ÎÏÌÎÎÎÌÌÌ.tSequence m_DynamicAtlasSettings; // 0x78
        public ojectionMatrix_Injected m_AtlasBlitShader; // 0x80
        public ojectionMatrix_Injected m_RuntimeShader; // 0x88
        public ojectionMatrix_Injected m_RuntimeWorldShader; // 0x90
        public ÎÏÌÎÎÎÌÌÌ.ight textSettings; // 0x98
        public dRecorder m_TargetRect; // 0xA0
        public float m_ResolvedScale; // 0xB0
        public ÎÏÌÎÎÎÌÌÌ.inter m_OldThemeUss; // 0xB8
        public float <ScreenDPI>k__BackingField; // 0xC0
        public n<tionX,tionX> m_AssignedScreenToPanel; // 0xC8

        // ── Methods ──
        public void get_themeStyleSheet(){} // RVA: 0x7FFD50CC1130
        public void set_themeStyleSheet(){} // RVA: 0x7FFD54FB7470
        public void get_targetTexture(){} // RVA: 0x7FFD4E36F0C0
        public void set_targetTexture(){} // RVA: 0x7FFD54FB74D0
        public void get_scaleMode(){} // RVA: 0x7FFD4E70C4C0
        public void set_scaleMode(){} // RVA: 0x7FFD4EABA6E0
        public void get_referenceSpritePixelsPerUnit(){} // RVA: 0x7FFD54D5FB10
        public void set_referenceSpritePixelsPerUnit(){} // RVA: 0x7FFD4E80A9D0
        public void get_scale(){} // RVA: 0x7FFD4F060670
        public void set_scale(){} // RVA: 0x7FFD4FB594E0
        public void get_referenceDpi(){} // RVA: 0x7FFD4E40B630
        public void set_referenceDpi(){} // RVA: 0x7FFD54FB7540
        public void get_fallbackDpi(){} // RVA: 0x7FFD4EB36E90
        public void set_fallbackDpi(){} // RVA: 0x7FFD54FB7570
        public void get_referenceResolution(){} // RVA: 0x7FFD53E53E00
        public void set_referenceResolution(){} // RVA: 0x7FFD53E53E10
        public void get_screenMatchMode(){} // RVA: 0x7FFD4E3E20A0
        public void set_screenMatchMode(){} // RVA: 0x7FFD4E3E20B0
        public void get_match(){} // RVA: 0x7FFD4F9E0DE0
        public void set_match(){} // RVA: 0x7FFD4F9E0F70
        public void get_sortingOrder(){} // RVA: 0x7FFD4EB55280
        public void set_sortingOrder(){} // RVA: 0x7FFD54FB75A0
        public void ApplySortingOrder(){} // RVA: 0x7FFD54FB75F0
        public void get_targetDisplay(){} // RVA: 0x7FFD4E5110E0
        public void set_targetDisplay(){} // RVA: 0x7FFD54FB7630
        public void get_clearDepthStencil(){} // RVA: 0x7FFD4F9C0C60
        public void set_clearDepthStencil(){} // RVA: 0x7FFD4F9C1180
        public void get_depthClearValue(){} // RVA: 0x7FFD54FB7670
        public void get_clearColor(){} // RVA: 0x7FFD4F9C1580
        public void set_clearColor(){} // RVA: 0x7FFD4F9C1C60
        public void get_colorClearValue(){} // RVA: 0x7FFD4EFEB4D0
        public void set_colorClearValue(){} // RVA: 0x7FFD54CB7890
        public void get_panel(){} // RVA: 0x7FFD54FB7680
        public void get_visualTree(){} // RVA: 0x7FFD54FB76A0
        public void get_dynamicAtlasSettings(){} // RVA: 0x7FFD4E505600
        public void set_dynamicAtlasSettings(){} // RVA: 0x7FFD4E5006F0
        public void .ctor(){} // RVA: 0x7FFD54FB76E0
        public void Reset(){} // RVA: 0x7FFD4E341310
        public void OnEnable(){} // RVA: 0x7FFD54FB7930
        public void OnDisable(){} // RVA: 0x7FFD54FB7AD0
        public void DisposePanel(){} // RVA: 0x7FFD54FB7AD0
        public void get_ScreenDPI(){} // RVA: 0x7FFD53CFEB20
        public void set_ScreenDPI(){} // RVA: 0x7FFD53D5FD90
        public void UpdateScreenDPI(){} // RVA: 0x7FFD54FB7AF0
        public void ApplyThemeStyleSheet(){} // RVA: 0x7FFD54FB7B50
        public void InitializeShaders(){} // RVA: 0x7FFD54FB7EA0
        public void ApplyPanelSettings(){} // RVA: 0x7FFD54FB8270
        public void SetScreenToPanelSpaceFunction(){} // RVA: 0x7FFD54FB8DE0
        public void ResolveScale(){} // RVA: 0x7FFD54FB8F30
        public void GetDisplayRect(){} // RVA: 0x7FFD54FB9030
        public void AttachAndInsertUIDocumentToVisualTree(){} // RVA: 0x7FFD54FB91F0
        public void DetachUIDocument(){} // RVA: 0x7FFD54FB9360
    }

    public class PanelTextSettings : TextSettings
    {
        public ÎÏÌÎÎÎÌÌÌ.ight defaultPanelTextSettings;
        public n<string,?> EditorGUIUtilityLoad; // 0x8
        public ormation<?> GetCurrentLanguage; // 0x10
        public string s_DefaultEditorPanelTextSettingPath; // 0x18

        // ── Methods ──
        public void get_defaultPanelTextSettings(){} // RVA: 0x7FFD5502F4A0
        public void UpdateLocalizationFontAsset(){} // RVA: 0x7FFD5502F710
        public void GetCachedFontAsset(){} // RVA: 0x7FFD5502FE30
        public void .ctor(){} // RVA: 0x7FFD5502FE40
        public void .cctor(){} // RVA: 0x7FFD5502FE50
    }

    public class PointerCaptureEventBase`1 : EventBase`1
    {
        public ÎÏÌÎÎÎÌÌÌ.lumnsWidth relatedTarget; // 0x88
        public int pointerId; // 0x90

        // ── Methods ──
        public void set_relatedTarget(){} // RVA: 0x7FFD4E090A40
        public void get_pointerId(){} // RVA: 0x7FFD4E079960
        public void set_pointerId(){} // RVA: 0x7FFD4E090ED0
        public void Init(){} // RVA: 0x7FFD4E090980
        public void LocalInit(){} // RVA: 0x7FFD4E090980
        public void GetPooled(){} // RVA: 0x7FFD4E2ADC40
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class PointerEventBase`1 : EventBase`1
    {
        public bool pointerId;
        public bool pointerType;
        public float isPrimary;
        public float button;
        public bool pressedButtons;
        public tionX position;
        public int localPosition;
        public string deltaPosition;
        public bool deltaTime;
        public int clickCount;
        public int pressure;
        public amut tangentialPressure;
        public amut altitudeAngle;
        public amut azimuthAngle;
        public float twist;
        public int tilt;
        public float penStatus;
        public float radius;
        public float radiusVariance;
        public aycast.PopulateRaycastCommand modifiers;
        public tionX shiftKey;
        public tionX ctrlKey;
        public illingServiceDisconnected commandKey;
        public bool altKey;
        public bool actionKey;

        // ── Methods ──
        public void get_pointerId(){} // RVA: 0x7FFD4E079960
        public void set_pointerId(){} // RVA: 0x7FFD4E090ED0
        public void get_pointerType(){} // RVA: 0x7FFD4E078E90
        public void set_pointerType(){} // RVA: 0x7FFD4E090A40
        public void get_isPrimary(){} // RVA: 0x7FFD4E079D00
        public void set_isPrimary(){} // RVA: 0x7FFD4E091060
        public void get_button(){} // RVA: 0x7FFD4E079960
        public void set_button(){} // RVA: 0x7FFD4E090ED0
        public void get_pressedButtons(){} // RVA: 0x7FFD4E079960
        public void set_pressedButtons(){} // RVA: 0x7FFD4E090ED0
        public void get_position(){} // RVA: 0x7FFD4E0788A0
        public void set_position(){} // RVA: 0x7FFD4E090A40
        public void get_localPosition(){} // RVA: 0x7FFD4E0788A0
        public void set_localPosition(){} // RVA: 0x7FFD4E090A40
        public void get_deltaPosition(){} // RVA: 0x7FFD4E0788A0
        public void set_deltaPosition(){} // RVA: 0x7FFD4E090A40
        public void get_deltaTime(){} // RVA: 0x7FFD4E08D880
        public void set_deltaTime(){} // RVA: 0x7FFD4E09E480
        public void get_clickCount(){} // RVA: 0x7FFD4E079960
        public void set_clickCount(){} // RVA: 0x7FFD4E090ED0
        public void get_pressure(){} // RVA: 0x7FFD4E08D880
        public void set_pressure(){} // RVA: 0x7FFD4E09E480
        public void get_tangentialPressure(){} // RVA: 0x7FFD4E08D880
        public void set_tangentialPressure(){} // RVA: 0x7FFD4E09E480
        public void get_altitudeAngle(){} // RVA: 0x7FFD4E08D880
        public void set_altitudeAngle(){} // RVA: 0x7FFD4E09E480
        public void get_azimuthAngle(){} // RVA: 0x7FFD4E08D880
        public void set_azimuthAngle(){} // RVA: 0x7FFD4E09E480
        public void get_twist(){} // RVA: 0x7FFD4E08D880
        public void set_twist(){} // RVA: 0x7FFD4E09E480
        public void get_tilt(){} // RVA: 0x7FFD4E078E90
        public void set_tilt(){} // RVA: 0x7FFD4E09F3E0
        public void get_penStatus(){} // RVA: 0x7FFD4E079960
        public void set_penStatus(){} // RVA: 0x7FFD4E090ED0
        public void get_radius(){} // RVA: 0x7FFD4E078E90
        public void set_radius(){} // RVA: 0x7FFD4E09F3E0
        public void get_radiusVariance(){} // RVA: 0x7FFD4E078E90
        public void set_radiusVariance(){} // RVA: 0x7FFD4E09F3E0
        public void get_modifiers(){} // RVA: 0x7FFD4E079960
        public void set_modifiers(){} // RVA: 0x7FFD4E090ED0
        public void get_shiftKey(){} // RVA: 0x7FFD4E079D00
        public void get_ctrlKey(){} // RVA: 0x7FFD4E079D00
        public void get_commandKey(){} // RVA: 0x7FFD4E079D00
        public void get_altKey(){} // RVA: 0x7FFD4E079D00
        public void get_actionKey(){} // RVA: 0x7FFD4E079D00
        public void UnityEngine.UIElements.IPointerEventInternal.get_triggeredByOS(){} // RVA: 0x7FFD4E079D00
        public void UnityEngine.UIElements.IPointerEventInternal.set_triggeredByOS(){} // RVA: 0x7FFD4E091060
        public void UnityEngine.UIElements.IPointerEventInternal.get_recomputeTopElementUnderPointer(){} // RVA: 0x7FFD4E079D00
        public void UnityEngine.UIElements.IPointerEventInternal.set_recomputeTopElementUnderPointer(){} // RVA: 0x7FFD4E091060
        public void Init(){} // RVA: 0x7FFD4E090980
        public void LocalInit(){} // RVA: 0x7FFD4E090980
        public void get_currentTarget(){} // RVA: 0x7FFD4E078E90
        public void set_currentTarget(){} // RVA: 0x7FFD4E090A40
        public void IsMouse(){} // RVA: 0x7FFD4E079DE0
        public void IsTouch(){} // RVA: 0x7FFD4E079DE0
        public void TiltToAzimuth(){} // RVA: 0x7FFD4E08EFE0
        public void AzimuthAndAlitutudeToTilt(){} // RVA: 0x7FFD4E2ADC40
        public void TiltToAltitude(){} // RVA: 0x7FFD4E08EFE0
        public void GetPooled(){} // RVA: 0x7FFD4E2ADC40 | overloaded x6
        public void PreDispatch(){} // RVA: 0x7FFD4E090A40
        public void PostDispatch(){} // RVA: 0x7FFD4E090A40
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class PointerEventsHelper : Object
    {
        // ── Methods ──
        public void SendEnterLeave(){} // RVA: 0x7FFD4E2ADC40
        public void SendOverOut(){} // RVA: 0x7FFD54FAA720
    }

    public class PointerManipulator : MouseManipulator
    {
        public int m_CurrentPointerId; // 0x30

        // ── Methods ──
        public void CanStartManipulation(){} // RVA: 0x7FFD54FCDA90
        public void CanStopManipulation(){} // RVA: 0x7FFD54FCDCC0
        public void .ctor(){} // RVA: 0x7FFD54FCDD30
    }

    public class PopupField`1 : BasePopupField`2
    {
        public int value;
        public string index;
        public string labelUssClassName;
        public string inputUssClassName;

        // ── Methods ──
        public void GetValueToDisplay(){} // RVA: 0x7FFD4E078E90
        public void GetListItemToDisplay(){} // RVA: 0x7FFD4E2ADC40
        public void get_value(){} // RVA: 0x7FFD4E2ADC40
        public void set_value(){} // RVA: 0x7FFD4E2ADC40
        public void SetValueWithoutNotify(){} // RVA: 0x7FFD4E2ADC40
        public void set_index(){} // RVA: 0x7FFD4E090ED0
        public void .ctor(){} // RVA: 0x7FFD4E090A40
        public void AddMenuItems(){} // RVA: 0x7FFD4E090A40
        public void ChangeValueFromMenu(){} // RVA: 0x7FFD4E2ADC40
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

}