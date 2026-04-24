// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 13
// Methods: 261

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class Panel : BaseVisualElementPanel
    {
        public object m_StylePropertyAnimationSystem; // 0x35EC8030
        public object m_RepaintVersion; // 0x35EC8030
        public object m_MarkerUpdate; // 0x35EC8030
        public object m_MarkerAnimations; // 0x35EC8030
        public object m_Scheduler; // 0x35EC8030
        public object _saveViewData; // 0x35EC8030, was: <saveViewData>k__BackingField
        public object _iMGUIEventInterests; // 0x35EC8030, was: <IMGUIEventInterests>k__Backin
        public object _timeSinceStartup; // 0x35EC8030, was: <TimeSinceStartup>k__BackingFi
        public object m_StandardShader; // 0x35EC8030
        public object beforeAnyRepaint; // 0x35EC8030
        public object _wantsLessLayoutEvents; // 0x35EC8DA0, was: <wantsLessLayoutEvents>k__Back
        public object Capacity; // 0x170008CD
        public object Count; // 0x170008CE
        public object System.Collections.IList.IsFixedSize; // 0x170008CF
        public object System.Collections.Generic.ICollection<T>.IsReadOnly; // 0x170008D0
        public object System.Collections.IList.IsReadOnly; // 0x170008D1
        public object System.Collections.ICollection.IsSynchronized; // 0x170008D2
        public object System.Collections.ICollection.SyncRoot; // 0x170008D3
        public object Item; // 0x170008D4

        // ── Original Methods ──
        public void get_visualTree(){} // RVA: 0x7ffaaf341d00
        public void get_dispatcher(){} // RVA: 0x7ffaa8f205f0
        public void set_dispatcher(){} // RVA: 0x7ffaa8f20bd0
        public void get_timerEventScheduler(){} // RVA: 0x7ffaaf5ca280
        public void get_scheduler(){} // RVA: 0x7ffaaf5ca280
        public void get_styleAnimationSystem(){} // RVA: 0x7ffaa899d0b0
        public void set_styleAnimationSystem(){} // RVA: 0x7ffaaf5ca330
        public void get_ownerObject(){} // RVA: 0x7ffaa8f76f40
        public void set_ownerObject(){} // RVA: 0x7ffaa93fc460
        public void get_contextType(){} // RVA: 0x7ffaaa36dc60
        public void set_contextType(){} // RVA: 0x7ffaaa36dc70
        public void get_saveViewData(){} // RVA: 0x7ffaa8b68c40
        public void get_getViewDataDictionary(){} // RVA: 0x7ffaa8f78450
        public void get_focusController(){} // RVA: 0x7ffaa8f7aa40
        public void set_focusController(){} // RVA: 0x7ffaa93f4640
        public void get_IMGUIEventInterests(){} // RVA: 0x7ffaaf5ca3f0
        public void set_IMGUIEventInterests(){} // RVA: 0x7ffaaf5ca410
        public void get_loadResourceFunc(){} // RVA: 0x7ffaaf5ca430
        public void LoadResource(){} // RVA: 0x7ffaaf5ca490
        public void Focus(){} // RVA: 0x7ffaaf5ca5a0
        public void Blur(){} // RVA: 0x7ffaaf5ca5b0
        public void ValidateFocus(){} // RVA: 0x7ffaaf5ca6d0
        public void get_name(){} // RVA: 0x7ffaaf341e50
        public void set_name(){} // RVA: 0x7ffaaf5ca7a0
        public void CreateMarkers(){} // RVA: 0x7ffaaf5ca800
        public void get_TimeSinceStartup(){} // RVA: 0x7ffaaf5cace0
        public void get_IMGUIContainersCount(){} // RVA: 0x7ffaae2e8440
        public void set_IMGUIContainersCount(){} // RVA: 0x7ffaae2e8450
        public void get_rootIMGUIContainer(){} // RVA: 0x7ffaa899d5f0
        public void get_version(){} // RVA: 0x7ffaa906c660
        public void get_hierarchyVersion(){} // RVA: 0x7ffaa90bdfd0
        public void get_standardShader(){} // RVA: 0x7ffaaf5cad40
        public void get_atlas(){} // RVA: 0x7ffaaf5cad50
        public void set_atlas(){} // RVA: 0x7ffaaf5cad60
        public void .ctor(){} // RVA: 0x7ffaaf5cae40
        public void Dispose(){} // RVA: 0x7ffaaf5cb670
        public void TimeSinceStartupMs(){} // RVA: 0x7ffaaf5cb7e0
        public void DefaultTimeSinceStartupMs(){} // RVA: 0x7ffaaf5cb8e0
        public void PickAll(){} // RVA: 0x7ffaaf5cbd50
        public void PerformPick(){} // RVA: 0x7ffaaf5cb9d0
        public void PickAll(){} // RVA: 0x7ffaaf5cbd50
        public void Pick(){} // RVA: 0x7ffaaf5cbe40
        public void ValidateLayout(){} // RVA: 0x7ffaaf5cc080
        public void UpdateAnimations(){} // RVA: 0x7ffaaf5cc100
        public void UpdateBindings(){} // RVA: 0x7ffaaf5cc130
        public void ApplyStyles(){} // RVA: 0x7ffaaf5cc160
        public void UpdateForRepaint(){} // RVA: 0x7ffaaf5cc190
        public void Repaint(){} // RVA: 0x7ffaaf5cc220
        public void OnVersionChanged(){} // RVA: 0x7ffaaf5cc680
        public void .cctor(){} // RVA: 0x7ffaaf5cc830
        public void <Pick>g__PixelOf|101_0(){} // RVA: 0x7ffaaf5cc8e0
        // ── Binary Analysis Named ──
        public void GetUpdater(){} // RVA: 0x7ffaaf5cc7f0
    }

    public class PanelChangedEventBase`1 : EventBase`1
    {
        // ── Original Methods ──
        public void get_originPanel(){} // RVA: 0x7ffaa86491d0
        public void set_originPanel(){} // RVA: 0x7ffaa8660d80
        public void get_destinationPanel(){} // RVA: 0x7ffaa86491d0
        public void set_destinationPanel(){} // RVA: 0x7ffaa8660d80
        public void Init(){} // RVA: 0x7ffaa8660cc0
        public void LocalInit(){} // RVA: 0x7ffaa8660cc0
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        // ── Binary Analysis Named ──
        public void GetPooled(){} // RVA: 0x7ffaa887e5c0
    }

    public class PanelClearSettings : ValueType
    {
        public object color; // 0x35EC8970
    }

    public class PanelEventHandler : UIBehaviour
    {
        public object m_LastClickTime; // 0x3390D0C0
        public object s_Modifiers; // 0x3390D0C0
        public object panel; // 0x17000169
        public object selectableGameObject; // 0x1700016A

        // ── Original Methods ──
        public void get_panel(){} // RVA: 0x7ffaa89600c0
        public void set_panel(){} // RVA: 0x7ffaaf6987c0
        public void get_selectableGameObject(){} // RVA: 0x7ffaaf6988a0
        public void get_eventSystem(){} // RVA: 0x7ffaaf6988c0
        public void get_isCurrentFocusedPanel(){} // RVA: 0x7ffaaf6989b0
        public void get_currentFocusedElement(){} // RVA: 0x7ffaaf698bc0
        public void OnEnable(){} // RVA: 0x7ffaaf698c00
        public void OnDisable(){} // RVA: 0x7ffaaf698c10
        public void RegisterCallbacks(){} // RVA: 0x7ffaaf698c20
        public void UnregisterCallbacks(){} // RVA: 0x7ffaaf698df0
        public void OnPanelDestroyed(){} // RVA: 0x7ffaaf699010
        public void OnElementFocus(){} // RVA: 0x7ffaaf6990c0
        public void OnElementBlur(){} // RVA: 0x7ffaa8932310
        public void OnSelect(){} // RVA: 0x7ffaaf6991d0
        public void OnDeselect(){} // RVA: 0x7ffaaf699210
        public void OnPointerMove(){} // RVA: 0x7ffaaf699230
        public void OnPointerUp(){} // RVA: 0x7ffaaf699380
        public void OnPointerDown(){} // RVA: 0x7ffaaf6995a0
        public void OnPointerExit(){} // RVA: 0x7ffaaf699840
        public void OnPointerEnter(){} // RVA: 0x7ffaaf699cf0
        public void OnPointerClick(){} // RVA: 0x7ffaaf699d60
        public void OnSubmit(){} // RVA: 0x7ffaaf699dc0
        public void OnCancel(){} // RVA: 0x7ffaaf699f90
        public void OnMove(){} // RVA: 0x7ffaaf69a160
        public void OnScroll(){} // RVA: 0x7ffaaf69a3f0
        public void SendEvent(){} // RVA: 0x7ffaaf69a650
        public void SendEvent(){} // RVA: 0x7ffaaf69a650
        public void Update(){} // RVA: 0x7ffaaf69a680
        public void LateUpdate(){} // RVA: 0x7ffaaf69a700
        public void ProcessImguiEvents(){} // RVA: 0x7ffaaf69a710
        public void ProcessKeyboardEvent(){} // RVA: 0x7ffaaf69a8f0
        public void ProcessTabEvent(){} // RVA: 0x7ffaaf69a9f0
        public void SendTabEvent(){} // RVA: 0x7ffaaf69aaa0
        public void SendKeyUpEvent(){} // RVA: 0x7ffaaf69ac70
        public void SendKeyDownEvent(){} // RVA: 0x7ffaaf69ade0
        public void ReadPointerData(){} // RVA: 0x7ffaaf69af50
        public void .ctor(){} // RVA: 0x7ffaaf69b1e0
    }

    public class PanelRaycaster : BaseRaycaster
    {
        // ── Original Methods ──
        public void get_panel(){} // RVA: 0x7ffaa8960130
        public void set_panel(){} // RVA: 0x7ffaaf69bb90
        public void RegisterCallbacks(){} // RVA: 0x7ffaaf69bd60
        public void UnregisterCallbacks(){} // RVA: 0x7ffaaf69be00
        public void OnPanelDestroyed(){} // RVA: 0x7ffaaf69bea0
        public void get_selectableGameObject(){} // RVA: 0x7ffaaf69beb0
        public void get_sortOrderPriority(){} // RVA: 0x7ffaaf69bed0
        public void get_renderOrderPriority(){} // RVA: 0x7ffaaf69bef0
        public void Raycast(){} // RVA: 0x7ffaaf69bf70
        public void get_eventCamera(){} // RVA: 0x7ffaa8f22da0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class PanelSettings : ScriptableObject
    {
        public object k_DefaultStyleSheetPath; // 0x331C17D0
        public object m_ScaleMode; // 0x331C17D0
        public object DefaultDpi; // 0x331C17D0
        public object m_ReferenceResolution; // 0x331C17D0
        public object m_SortingOrder; // 0x331C17D0
        public object m_ClearColor; // 0x331C17D0
        public object m_AttachedUIDocumentsList; // 0x331C17D0
        public object m_RuntimeShader; // 0x331C17D0
        public object m_TargetRect; // 0x331C17D0
        public object _screenDPI; // 0x331C17D0, was: <ScreenDPI>k__BackingField

        // ── Original Methods ──
        public void get_themeStyleSheet(){} // RVA: 0x7ffaab2aab40
        public void set_themeStyleSheet(){} // RVA: 0x7ffaaf5b93e0
        public void get_targetTexture(){} // RVA: 0x7ffaa89600c0
        public void set_targetTexture(){} // RVA: 0x7ffaaf5b9440
        public void get_scaleMode(){} // RVA: 0x7ffaa8d14570
        public void set_scaleMode(){} // RVA: 0x7ffaa90c0cd0
        public void get_referenceSpritePixelsPerUnit(){} // RVA: 0x7ffaaf361a70
        public void set_referenceSpritePixelsPerUnit(){} // RVA: 0x7ffaa8e14fc0
        public void get_scale(){} // RVA: 0x7ffaa9672970
        public void set_scale(){} // RVA: 0x7ffaaa150900
        public void get_referenceDpi(){} // RVA: 0x7ffaa89fc630
        public void set_referenceDpi(){} // RVA: 0x7ffaaf5b94b0
        public void get_fallbackDpi(){} // RVA: 0x7ffaa9144a40
        public void set_fallbackDpi(){} // RVA: 0x7ffaaf5b94e0
        public void get_referenceResolution(){} // RVA: 0x7ffaae455020
        public void set_referenceResolution(){} // RVA: 0x7ffaae455030
        public void get_screenMatchMode(){} // RVA: 0x7ffaa89d30a0
        public void set_screenMatchMode(){} // RVA: 0x7ffaa89d30b0
        public void get_match(){} // RVA: 0x7ffaa9fe53d0
        public void set_match(){} // RVA: 0x7ffaa9fe6140
        public void get_sortingOrder(){} // RVA: 0x7ffaa9168110
        public void set_sortingOrder(){} // RVA: 0x7ffaaf5b9510
        public void ApplySortingOrder(){} // RVA: 0x7ffaaf5b9560
        public void get_targetDisplay(){} // RVA: 0x7ffaa8b023d0
        public void set_targetDisplay(){} // RVA: 0x7ffaaf5b95a0
        public void get_clearDepthStencil(){} // RVA: 0x7ffaa9fc1d50
        public void set_clearDepthStencil(){} // RVA: 0x7ffaa9fc1c30
        public void get_depthClearValue(){} // RVA: 0x7ffaaf5b95e0
        public void get_clearColor(){} // RVA: 0x7ffaa9fc1d40
        public void set_clearColor(){} // RVA: 0x7ffaa9fc1c20
        public void get_colorClearValue(){} // RVA: 0x7ffaa95fffb0
        public void set_colorClearValue(){} // RVA: 0x7ffaaf2b97f0
        public void get_panel(){} // RVA: 0x7ffaaf5b95f0
        public void get_visualTree(){} // RVA: 0x7ffaaf5b9610
        public void get_dynamicAtlasSettings(){} // RVA: 0x7ffaa8af68f0
        public void set_dynamicAtlasSettings(){} // RVA: 0x7ffaa8af19e0
        public void .ctor(){} // RVA: 0x7ffaaf5b9650
        public void Reset(){} // RVA: 0x7ffaa8932310
        public void OnEnable(){} // RVA: 0x7ffaaf5b98a0
        public void OnDisable(){} // RVA: 0x7ffaaf5b9a40
        public void DisposePanel(){} // RVA: 0x7ffaaf5b9a40
        public void get_ScreenDPI(){} // RVA: 0x7ffaae2ffd30
        public void set_ScreenDPI(){} // RVA: 0x7ffaae360fa0
        public void UpdateScreenDPI(){} // RVA: 0x7ffaaf5b9a60
        public void ApplyThemeStyleSheet(){} // RVA: 0x7ffaaf5b9ac0
        public void InitializeShaders(){} // RVA: 0x7ffaaf5b9e10
        public void ApplyPanelSettings(){} // RVA: 0x7ffaaf5ba1e0
        public void ResolveScale(){} // RVA: 0x7ffaaf5baea0
        public void AttachAndInsertUIDocumentToVisualTree(){} // RVA: 0x7ffaaf5bb160
        public void DetachUIDocument(){} // RVA: 0x7ffaaf5bb2d0
        // ── Binary Analysis Named ──
        public void SetScreenToPanelSpaceFunction(){} // RVA: 0x7ffaaf5bad50
        public void GetDisplayRect(){} // RVA: 0x7ffaaf5bafa0
    }

    public class PanelTextSettings : TextSettings
    {
        public object GetCurrentLanguage; // 0x331C1C80

        // ── Original Methods ──
        public void get_defaultPanelTextSettings(){} // RVA: 0x7ffaaf631410
        public void UpdateLocalizationFontAsset(){} // RVA: 0x7ffaaf631680
        public void .ctor(){} // RVA: 0x7ffaaf631db0
        public void .cctor(){} // RVA: 0x7ffaaf631dc0
        // ── Binary Analysis Named ──
        public void GetCachedFontAsset(){} // RVA: 0x7ffaaf631da0
    }

    public class PointerCaptureEventBase`1 : EventBase`1
    {
        // ── Original Methods ──
        public void set_relatedTarget(){} // RVA: 0x7ffaa8660d80
        public void get_pointerId(){} // RVA: 0x7ffaa8649ca0
        public void set_pointerId(){} // RVA: 0x7ffaa8661210
        public void Init(){} // RVA: 0x7ffaa8660cc0
        public void LocalInit(){} // RVA: 0x7ffaa8660cc0
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        // ── Binary Analysis Named ──
        public void GetPooled(){} // RVA: 0x7ffaa887e5c0
    }

    public class PointerCaptureEventBase`1 : EventBase`1
    {
        // ── Original Methods ──
        public void set_relatedTarget(){} // RVA: 0x7ffaa8f7b010
        public void get_pointerId(){} // RVA: 0x7ffaa8c4abe0
        public void set_pointerId(){} // RVA: 0x7ffaa8efe560
        public void Init(){} // RVA: 0x7ffaabf467d0
        public void LocalInit(){} // RVA: 0x7ffaac120190
        public void .ctor(){} // RVA: 0x7ffaac1203a0
        // ── Binary Analysis Named ──
        public void GetPooled(){} // RVA: 0x7ffaac120260
    }

    public class PointerEventBase`1 : EventBase`1
    {
        public object m_AltitudeAngle; // 0x30DCC030
        public object m_Tilt; // 0x30DCC030
        public object _isPrimary; // 0x30DCC030, was: <isPrimary>k__BackingField
        public object _position; // 0x30DCC030, was: <position>k__BackingField
        public object _deltaTime; // 0x30DCC030, was: <deltaTime>k__BackingField
        public object _tangentialPressure; // 0x30DCC030, was: <tangentialPressure>k__Backing
        public object _radius; // 0x30DCC030, was: <radius>k__BackingField
        public object _triggeredByOS; // 0x30DCC030, was: <UnityEngine.UIElements.IPoint

        // ── Original Methods ──
        public void get_pointerId(){} // RVA: 0x7ffaa8649ca0
        public void set_pointerId(){} // RVA: 0x7ffaa8661210
        public void get_pointerType(){} // RVA: 0x7ffaa86491d0
        public void set_pointerType(){} // RVA: 0x7ffaa8660d80
        public void get_isPrimary(){} // RVA: 0x7ffaa864a040
        public void set_isPrimary(){} // RVA: 0x7ffaa86613a0
        public void get_button(){} // RVA: 0x7ffaa8649ca0
        public void set_button(){} // RVA: 0x7ffaa8661210
        public void get_pressedButtons(){} // RVA: 0x7ffaa8649ca0
        public void set_pressedButtons(){} // RVA: 0x7ffaa8661210
        public void get_position(){} // RVA: 0x7ffaa8648be0
        public void set_position(){} // RVA: 0x7ffaa8660d80
        public void get_localPosition(){} // RVA: 0x7ffaa8648be0
        public void set_localPosition(){} // RVA: 0x7ffaa8660d80
        public void get_deltaPosition(){} // RVA: 0x7ffaa8648be0
        public void set_deltaPosition(){} // RVA: 0x7ffaa8660d80
        public void get_deltaTime(){} // RVA: 0x7ffaa865dbc0
        public void set_deltaTime(){} // RVA: 0x7ffaa866e7c0
        public void get_clickCount(){} // RVA: 0x7ffaa8649ca0
        public void set_clickCount(){} // RVA: 0x7ffaa8661210
        public void get_pressure(){} // RVA: 0x7ffaa865dbc0
        public void set_pressure(){} // RVA: 0x7ffaa866e7c0
        public void get_tangentialPressure(){} // RVA: 0x7ffaa865dbc0
        public void set_tangentialPressure(){} // RVA: 0x7ffaa866e7c0
        public void get_altitudeAngle(){} // RVA: 0x7ffaa865dbc0
        public void set_altitudeAngle(){} // RVA: 0x7ffaa866e7c0
        public void get_azimuthAngle(){} // RVA: 0x7ffaa865dbc0
        public void set_azimuthAngle(){} // RVA: 0x7ffaa866e7c0
        public void get_twist(){} // RVA: 0x7ffaa865dbc0
        public void set_twist(){} // RVA: 0x7ffaa866e7c0
        public void get_tilt(){} // RVA: 0x7ffaa86491d0
        public void set_tilt(){} // RVA: 0x7ffaa866f720
        public void get_penStatus(){} // RVA: 0x7ffaa8649ca0
        public void set_penStatus(){} // RVA: 0x7ffaa8661210
        public void get_radius(){} // RVA: 0x7ffaa86491d0
        public void set_radius(){} // RVA: 0x7ffaa866f720
        public void get_radiusVariance(){} // RVA: 0x7ffaa86491d0
        public void set_radiusVariance(){} // RVA: 0x7ffaa866f720
        public void get_modifiers(){} // RVA: 0x7ffaa8649ca0
        public void set_modifiers(){} // RVA: 0x7ffaa8661210
        public void get_shiftKey(){} // RVA: 0x7ffaa864a040
        public void get_ctrlKey(){} // RVA: 0x7ffaa864a040
        public void get_commandKey(){} // RVA: 0x7ffaa864a040
        public void get_altKey(){} // RVA: 0x7ffaa864a040
        public void get_actionKey(){} // RVA: 0x7ffaa864a040
        public void UnityEngine.UIElements.IPointerEventInternal.get_triggeredByOS(){} // RVA: 0x7ffaa864a040
        public void UnityEngine.UIElements.IPointerEventInternal.set_triggeredByOS(){} // RVA: 0x7ffaa86613a0
        public void UnityEngine.UIElements.IPointerEventInternal.get_recomputeTopElementUnderPointer(){} // RVA: 0x7ffaa864a040
        public void UnityEngine.UIElements.IPointerEventInternal.set_recomputeTopElementUnderPointer(){} // RVA: 0x7ffaa86613a0
        public void Init(){} // RVA: 0x7ffaa8660cc0
        public void LocalInit(){} // RVA: 0x7ffaa8660cc0
        public void get_currentTarget(){} // RVA: 0x7ffaa86491d0
        public void set_currentTarget(){} // RVA: 0x7ffaa8660d80
        public void IsMouse(){} // RVA: 0x7ffaa864a120
        public void IsTouch(){} // RVA: 0x7ffaa864a120
        public void TiltToAzimuth(){} // RVA: 0x7ffaa865f320
        public void AzimuthAndAlitutudeToTilt(){} // RVA: 0x7ffaa887e5c0
        public void TiltToAltitude(){} // RVA: 0x7ffaa865f320
        public void PreDispatch(){} // RVA: 0x7ffaa8660d80
        public void PostDispatch(){} // RVA: 0x7ffaa8660d80
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        // ── Binary Analysis Named ──
        public void GetPooled(){} // RVA: 0x7ffaa887e5c0
        public void GetPooled(){} // RVA: 0x7ffaa887e5c0
        public void GetPooled(){} // RVA: 0x7ffaa887e5c0
        public void GetPooled(){} // RVA: 0x7ffaa887e5c0
        public void GetPooled(){} // RVA: 0x7ffaa887e5c0
        public void GetPooled(){} // RVA: 0x7ffaa887e5c0
    }

    public class PointerEventsHelper : Object
    {
        // ── Original Methods ──
        public void SendEnterLeave(){} // RVA: 0x7ffaa887e5c0
        public void SendOverOut(){} // RVA: 0x7ffaaf5ac690
    }

    public class PointerManipulator : MouseManipulator
    {
        // ── Original Methods ──
        public void CanStartManipulation(){} // RVA: 0x7ffaaf5cfa00
        public void CanStopManipulation(){} // RVA: 0x7ffaaf5cfc30
        public void .ctor(){} // RVA: 0x7ffaaf5cfca0
    }

    public class PopupField`1 : BasePopupField`2
    {
        public object labelUssClassName; // 0x30BD1F10
        public object ussClassName; // 0x839D2BA8

        // ── Original Methods ──
        public void get_value(){} // RVA: 0x7ffaa887e5c0
        public void set_value(){} // RVA: 0x7ffaa887e5c0
        public void set_index(){} // RVA: 0x7ffaa8661210
        public void .ctor(){} // RVA: 0x7ffaa8660d80
        public void AddMenuItems(){} // RVA: 0x7ffaa8660d80
        public void ChangeValueFromMenu(){} // RVA: 0x7ffaa887e5c0
        public void .cctor(){} // RVA: 0x7ffaa8660cf0
        // ── Binary Analysis Named ──
        public void GetValueToDisplay(){} // RVA: 0x7ffaa86491d0
        public void GetListItemToDisplay(){} // RVA: 0x7ffaa887e5c0
        public void SetValueWithoutNotify(){} // RVA: 0x7ffaa887e5c0
    }

}