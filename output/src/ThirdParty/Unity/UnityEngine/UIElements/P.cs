// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 36
// Methods: 361

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class Painter2D
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7435FE0
        public void Reset(){} // RVA: 0x74361E0
        public void Dispose(){} // RVA: 0x74363E0 | overloaded x2
        public void set_isPainterActive(){} // RVA: 0x7436520
        public void get_maxArcRadius(){} // RVA: 0x7436580
        public void .cctor(){} // RVA: 0x74366A0
    }

    public class Panel
    {
        // ── Methods ──
        public void get_visualTree(){} // RVA: 0x71884A0
        public void get_dispatcher(){} // RVA: 0xA94E10
        public void set_dispatcher(){} // RVA: 0xCF6DE0
        public void get_timerEventScheduler(){} // RVA: 0x7410A20
        public void get_scheduler(){} // RVA: 0x7410A20
        public void get_styleAnimationSystem(){} // RVA: 0x3480B0
        public void set_styleAnimationSystem(){} // RVA: 0x7410AD0
        public void get_ownerObject(){} // RVA: 0x507710
        public void set_ownerObject(){} // RVA: 0x509930
        public void get_contextType(){} // RVA: 0x13CBAD0
        public void set_contextType(){} // RVA: 0x13D7860
        public void get_saveViewData(){} // RVA: 0x59E660
        public void get_getViewDataDictionary(){} // RVA: 0xA8EE80
        public void get_focusController(){} // RVA: 0xA8E870
        public void set_focusController(){} // RVA: 0xDA3F70
        public void get_IMGUIEventInterests(){} // RVA: 0x7410B90
        public void set_IMGUIEventInterests(){} // RVA: 0x7410BB0
        public void get_loadResourceFunc(){} // RVA: 0x7410BD0
        public void LoadResource(){} // RVA: 0x7410C30
        public void Focus(){} // RVA: 0x7410D40
        public void Blur(){} // RVA: 0x7410D50
        public void ValidateFocus(){} // RVA: 0x7410E70
        public void get_name(){} // RVA: 0x71885F0
        public void set_name(){} // RVA: 0x7410F40
        public void CreateMarkers(){} // RVA: 0x7410FA0
        public void get_TimeSinceStartup(){} // RVA: 0x7411480
        public void get_IMGUIContainersCount(){} // RVA: 0x612FB40
        public void set_IMGUIContainersCount(){} // RVA: 0x612FB50
        public void get_rootIMGUIContainer(){} // RVA: 0x3485F0
        public void get_version(){} // RVA: 0xA002A0
        public void get_hierarchyVersion(){} // RVA: 0xA50BB0
        public void get_standardShader(){} // RVA: 0x74114E0
        public void get_atlas(){} // RVA: 0x74114F0
        public void set_atlas(){} // RVA: 0x7411500
        public void .ctor(){} // RVA: 0x74115E0
        public void Dispose(){} // RVA: 0x7411E10
        public void TimeSinceStartupMs(){} // RVA: 0x7411F80
        public void DefaultTimeSinceStartupMs(){} // RVA: 0x7412080
        public void PickAll(){} // RVA: 0x74124F0 | overloaded x2
        public void PerformPick(){} // RVA: 0x7412170
        public void Pick(){} // RVA: 0x74125E0
        public void ValidateLayout(){} // RVA: 0x7412820
        public void UpdateAnimations(){} // RVA: 0x74128A0
        public void UpdateBindings(){} // RVA: 0x74128D0
        public void ApplyStyles(){} // RVA: 0x7412900
        public void UpdateForRepaint(){} // RVA: 0x7412930
        public void Repaint(){} // RVA: 0x74129C0
        public void OnVersionChanged(){} // RVA: 0x7412E20
        public void GetUpdater(){} // RVA: 0x7412F90
        public void .cctor(){} // RVA: 0x7412FD0
        public void <Pick>g__PixelOf|101_0(){} // RVA: 0x7413080
    }

    public class PanelChangedEventBase`1
    {
        // ── Methods ──
        public void get_originPanel(){} // RVA: 0xCD60
        public void set_originPanel(){} // RVA: 0x24B10
        public void get_destinationPanel(){} // RVA: 0xCD60
        public void set_destinationPanel(){} // RVA: 0x24B10
        public void Init(){} // RVA: 0x24A50
        public void LocalInit(){} // RVA: 0x24A50
        public void GetPooled(){} // RVA: 0x283FA0
        public void .ctor(){} // RVA: 0x24A50
    }

    public class PanelClearSettings
    {
    }

    public class PanelEventHandler
    {
        // ── Methods ──
        public void get_panel(){} // RVA: 0x30B0C0
        public void set_panel(){} // RVA: 0x74DEEE0
        public void get_selectableGameObject(){} // RVA: 0x74DEFC0
        public void get_eventSystem(){} // RVA: 0x74DEFE0
        public void get_isCurrentFocusedPanel(){} // RVA: 0x74DF0D0
        public void get_currentFocusedElement(){} // RVA: 0x74DF2E0
        public void OnEnable(){} // RVA: 0x74DF320
        public void OnDisable(){} // RVA: 0x74DF330
        public void RegisterCallbacks(){} // RVA: 0x74DF340
        public void UnregisterCallbacks(){} // RVA: 0x74DF510
        public void OnPanelDestroyed(){} // RVA: 0x74DF730
        public void OnElementFocus(){} // RVA: 0x74DF7E0
        public void OnElementBlur(){} // RVA: 0x2DD310
        public void OnSelect(){} // RVA: 0x74DF8F0
        public void OnDeselect(){} // RVA: 0x74DF930
        public void OnPointerMove(){} // RVA: 0x74DF950
        public void OnPointerUp(){} // RVA: 0x74DFAA0
        public void OnPointerDown(){} // RVA: 0x74DFCC0
        public void OnPointerExit(){} // RVA: 0x74DFF60
        public void OnPointerEnter(){} // RVA: 0x74E0410
        public void OnPointerClick(){} // RVA: 0x74E0480
        public void OnSubmit(){} // RVA: 0x74E04E0
        public void OnCancel(){} // RVA: 0x74E06B0
        public void OnMove(){} // RVA: 0x74E0880
        public void OnScroll(){} // RVA: 0x74E0B10
        public void SendEvent(){} // RVA: 0x74E0D70 | overloaded x2
        public void Update(){} // RVA: 0x74E0DA0
        public void LateUpdate(){} // RVA: 0x74E0E20
        public void ProcessImguiEvents(){} // RVA: 0x74E0E30
        public void ProcessKeyboardEvent(){} // RVA: 0x74E1010
        public void ProcessTabEvent(){} // RVA: 0x74E1110
        public void SendTabEvent(){} // RVA: 0x74E11C0
        public void SendKeyUpEvent(){} // RVA: 0x74E1390
        public void SendKeyDownEvent(){} // RVA: 0x74E1500
        public void ReadPointerData(){} // RVA: 0x74E1670
        public void .ctor(){} // RVA: 0x74E1900
    }

    public class PanelRaycaster
    {
        // ── Methods ──
        public void get_panel(){} // RVA: 0x30B130
        public void set_panel(){} // RVA: 0x74E22B0
        public void RegisterCallbacks(){} // RVA: 0x74E2480
        public void UnregisterCallbacks(){} // RVA: 0x74E2520
        public void OnPanelDestroyed(){} // RVA: 0x74E25C0
        public void get_selectableGameObject(){} // RVA: 0x74E25D0
        public void get_sortOrderPriority(){} // RVA: 0x74E25F0
        public void get_renderOrderPriority(){} // RVA: 0x74E2610
        public void Raycast(){} // RVA: 0x74E2690
        public void get_eventCamera(){} // RVA: 0x519240
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class PanelSettings
    {
        public object panelSettings;
        public object parentUI;
        public object visualTreeAsset;
        public object rootVisualElement;
        public object firstChildInserIndex;
        public object sortingOrder;
        public object importedWithErrors;
        public object importedWithWarnings;

        // ── Methods ──
        public void get_themeStyleSheet(){} // RVA: 0x2F0F420
        public void set_themeStyleSheet(){} // RVA: 0x73FFB80
        public void get_targetTexture(){} // RVA: 0x30B0C0
        public void set_targetTexture(){} // RVA: 0x73FFBE0
        public void get_scaleMode(){} // RVA: 0x791DC0
        public void set_scaleMode(){} // RVA: 0xA53440
        public void get_referenceSpritePixelsPerUnit(){} // RVA: 0x71A8210
        public void set_referenceSpritePixelsPerUnit(){} // RVA: 0x8CF4F0
        public void get_scale(){} // RVA: 0x466280
        public void set_scale(){} // RVA: 0x4FDE90
        public void get_referenceDpi(){} // RVA: 0x3A7630
        public void set_referenceDpi(){} // RVA: 0x73FFC50
        public void get_fallbackDpi(){} // RVA: 0x4FE250
        public void set_fallbackDpi(){} // RVA: 0x73FFC80
        public void get_referenceResolution(){} // RVA: 0x629CA50
        public void set_referenceResolution(){} // RVA: 0x629CA60
        public void get_screenMatchMode(){} // RVA: 0x37E0A0
        public void set_screenMatchMode(){} // RVA: 0x37E0B0
        public void get_match(){} // RVA: 0xEBB900
        public void set_match(){} // RVA: 0xEBB7C0
        public void get_sortingOrder(){} // RVA: 0xD0E450
        public void set_sortingOrder(){} // RVA: 0x73FFCB0
        public void ApplySortingOrder(){} // RVA: 0x73FFD00
        public void get_targetDisplay(){} // RVA: 0x59C540
        public void set_targetDisplay(){} // RVA: 0x73FFD40
        public void get_clearDepthStencil(){} // RVA: 0xBDB570
        public void set_clearDepthStencil(){} // RVA: 0x1AF0B50
        public void get_depthClearValue(){} // RVA: 0x73FFD80
        public void get_clearColor(){} // RVA: 0x1AEFFD0
        public void set_clearColor(){} // RVA: 0x1AF0B40
        public void get_colorClearValue(){} // RVA: 0x111DE50
        public void set_colorClearValue(){} // RVA: 0x70FF540
        public void get_panel(){} // RVA: 0x73FFD90
        public void get_visualTree(){} // RVA: 0x73FFDB0
        public void get_dynamicAtlasSettings(){} // RVA: 0x4C7C50
        public void set_dynamicAtlasSettings(){} // RVA: 0x4C34F0
        public void .ctor(){} // RVA: 0x73FFDF0
        public void Reset(){} // RVA: 0x2DD310
        public void OnEnable(){} // RVA: 0x7400040
        public void OnDisable(){} // RVA: 0x74001E0
        public void DisposePanel(){} // RVA: 0x74001E0
        public void get_ScreenDPI(){} // RVA: 0x6147430
        public void set_ScreenDPI(){} // RVA: 0x61A8650
        public void UpdateScreenDPI(){} // RVA: 0x7400200
        public void ApplyThemeStyleSheet(){} // RVA: 0x7400260
        public void InitializeShaders(){} // RVA: 0x74005B0
        public void ApplyPanelSettings(){} // RVA: 0x7400980
        public void SetScreenToPanelSpaceFunction(){} // RVA: 0x74014F0
        public void ResolveScale(){} // RVA: 0x7401640
        public void GetDisplayRect(){} // RVA: 0x7401740
        public void AttachAndInsertUIDocumentToVisualTree(){} // RVA: 0x7401900
        public void DetachUIDocument(){} // RVA: 0x7401A70
    }

    public class PanelTextSettings
    {
        // ── Methods ──
        public void get_defaultPanelTextSettings(){} // RVA: 0x7477B50
        public void UpdateLocalizationFontAsset(){} // RVA: 0x7477DC0
        public void GetCachedFontAsset(){} // RVA: 0x74784E0
        public void .ctor(){} // RVA: 0x74784F0
        public void .cctor(){} // RVA: 0x7478500
    }

    public class PointerCancelEvent
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x73F81E0
        public void Init(){} // RVA: 0x73F82D0
        public void LocalInit(){} // RVA: 0x73F8370
        public void .ctor(){} // RVA: 0x73F83E0
        public void PostDispatch(){} // RVA: 0x73F8480
    }

    public class PointerCaptureDispatchingStrategy
    {
        // ── Methods ──
        public void CanDispatchEvent(){} // RVA: 0x73F4AF0
        public void DispatchEvent(){} // RVA: 0x73F4B40
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class PointerCaptureEvent
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x73E57E0
        public void .ctor(){} // RVA: 0x73E58D0
    }

    public class PointerCaptureEventBase`1
    {
        // ── Methods ──
        public void set_relatedTarget(){} // RVA: 0x24B10
        public void get_pointerId(){} // RVA: 0xD840
        public void set_pointerId(){} // RVA: 0x24FA0
        public void Init(){} // RVA: 0x24A50
        public void LocalInit(){} // RVA: 0x24A50
        public void GetPooled(){} // RVA: 0x283FA0
        public void .ctor(){} // RVA: 0x24A50
    }

    public class PointerCaptureHelper
    {
        // ── Methods ──
        public void GetStateFor(){} // RVA: 0x7414E20
        public void HasPointerCapture(){} // RVA: 0x7414ED0
        public void CapturePointer(){} // RVA: 0x7414F30
        public void ReleasePointer(){} // RVA: 0x7415160 | overloaded x2
        public void GetCapturingElement(){} // RVA: 0x74150D0
        public void ActivateCompatibilityMouseEvents(){} // RVA: 0x74151E0
        public void PreventCompatibilityMouseEvents(){} // RVA: 0x7415260
        public void ShouldSendCompatibilityMouseEvents(){} // RVA: 0x74152E0
        public void ProcessPointerCapture(){} // RVA: 0x7415440
    }

    public class PointerCaptureOutEvent
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x73E55A0
        public void .ctor(){} // RVA: 0x73E5690
    }

    public class PointerDeviceState
    {
        // ── Methods ──
        public void RemovePanelData(){} // RVA: 0x73F4FD0
        public void SavePointerPosition(){} // RVA: 0x73F5190
        public void PressButton(){} // RVA: 0x73F5240
        public void ReleaseButton(){} // RVA: 0x73F5310
        public void ReleaseAllButtons(){} // RVA: 0x73F53E0
        public void GetPointerPosition(){} // RVA: 0x73F5460
        public void GetPanel(){} // RVA: 0x73F54F0
        public void HasFlagFast(){} // RVA: 0x73F5570
        public void HasLocationFlag(){} // RVA: 0x73F5580
        public void GetPressedButtons(){} // RVA: 0x73F5610
        public void HasAdditionalPressedButtons(){} // RVA: 0x73F5690
        public void SetPlayerPanelWithSoftPointerCapture(){} // RVA: 0x73F5720
        public void GetPlayerPanelWithSoftPointerCapture(){} // RVA: 0x73F57E0
        public void .cctor(){} // RVA: 0x73F5860
    }

    public class PointerDispatchState
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x74154B0
        public void Reset(){} // RVA: 0x74157B0
        public void GetCapturingElement(){} // RVA: 0x6AD84E0
        public void HasPointerCapture(){} // RVA: 0x7415900
        public void CapturePointer(){} // RVA: 0x7415930
        public void ReleasePointer(){} // RVA: 0x7415A90 | overloaded x2
        public void ProcessPointerCapture(){} // RVA: 0x7415AE0
        public void ActivateCompatibilityMouseEvents(){} // RVA: 0x7416090
        public void PreventCompatibilityMouseEvents(){} // RVA: 0x74160C0
        public void ShouldSendCompatibilityMouseEvents(){} // RVA: 0x74160F0
    }

    public class PointerDownEvent
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x73F6860
        public void Init(){} // RVA: 0x73F6950
        public void LocalInit(){} // RVA: 0x73F69F0
        public void .ctor(){} // RVA: 0x73F6A60
        public void PostDispatch(){} // RVA: 0x73F6B00
    }

    public class PointerEnterEvent
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x73F8C70
        public void Init(){} // RVA: 0x73F8D60
        public void LocalInit(){} // RVA: 0x73F8DB0
        public void .ctor(){} // RVA: 0x73F8DC0
    }

    public class PointerEventBase`1
    {
        // ── Methods ──
        public void get_pointerId(){} // RVA: 0xD840
        public void set_pointerId(){} // RVA: 0x24FA0
        public void get_pointerType(){} // RVA: 0xCD60
        public void set_pointerType(){} // RVA: 0x24B10
        public void get_isPrimary(){} // RVA: 0xDBE0
        public void set_isPrimary(){} // RVA: 0x25130
        public void get_button(){} // RVA: 0xD840
        public void set_button(){} // RVA: 0x24FA0
        public void get_pressedButtons(){} // RVA: 0xD840
        public void set_pressedButtons(){} // RVA: 0x24FA0
        public void get_position(){} // RVA: 0xC770
        public void set_position(){} // RVA: 0x24B10
        public void get_localPosition(){} // RVA: 0xC770
        public void set_localPosition(){} // RVA: 0x24B10
        public void get_deltaPosition(){} // RVA: 0xC770
        public void set_deltaPosition(){} // RVA: 0x24B10
        public void get_deltaTime(){} // RVA: 0x21890
        public void set_deltaTime(){} // RVA: 0x325B0
        public void get_clickCount(){} // RVA: 0xD840
        public void set_clickCount(){} // RVA: 0x24FA0
        public void get_pressure(){} // RVA: 0x21890
        public void set_pressure(){} // RVA: 0x325B0
        public void get_tangentialPressure(){} // RVA: 0x21890
        public void set_tangentialPressure(){} // RVA: 0x325B0
        public void get_altitudeAngle(){} // RVA: 0x21890
        public void set_altitudeAngle(){} // RVA: 0x325B0
        public void get_azimuthAngle(){} // RVA: 0x21890
        public void set_azimuthAngle(){} // RVA: 0x325B0
        public void get_twist(){} // RVA: 0x21890
        public void set_twist(){} // RVA: 0x325B0
        public void get_tilt(){} // RVA: 0xCD60
        public void set_tilt(){} // RVA: 0x33510
        public void get_penStatus(){} // RVA: 0xD840
        public void set_penStatus(){} // RVA: 0x24FA0
        public void get_radius(){} // RVA: 0xCD60
        public void set_radius(){} // RVA: 0x33510
        public void get_radiusVariance(){} // RVA: 0xCD60
        public void set_radiusVariance(){} // RVA: 0x33510
        public void get_modifiers(){} // RVA: 0xD840
        public void set_modifiers(){} // RVA: 0x24FA0
        public void get_shiftKey(){} // RVA: 0xDBE0
        public void get_ctrlKey(){} // RVA: 0xDBE0
        public void get_commandKey(){} // RVA: 0xDBE0
        public void get_altKey(){} // RVA: 0xDBE0
        public void get_actionKey(){} // RVA: 0xDBE0
        public void UnityEngine.UIElements.IPointerEventInternal.get_triggeredByOS(){} // RVA: 0xDBE0
        public void UnityEngine.UIElements.IPointerEventInternal.set_triggeredByOS(){} // RVA: 0x25130
        public void UnityEngine.UIElements.IPointerEventInternal.get_recomputeTopElementUnderPointer(){} // RVA: 0xDBE0
        public void UnityEngine.UIElements.IPointerEventInternal.set_recomputeTopElementUnderPointer(){} // RVA: 0x25130
        public void Init(){} // RVA: 0x24A50
        public void LocalInit(){} // RVA: 0x24A50
        public void get_currentTarget(){} // RVA: 0xCD60
        public void set_currentTarget(){} // RVA: 0x24B10
        public void IsMouse(){} // RVA: 0xDCC0
        public void IsTouch(){} // RVA: 0xDCC0
        public void TiltToAzimuth(){} // RVA: 0x230A0
        public void AzimuthAndAlitutudeToTilt(){} // RVA: 0x283FA0
        public void TiltToAltitude(){} // RVA: 0x230A0
        public void GetPooled(){} // RVA: 0x283FA0 | overloaded x6
        public void PreDispatch(){} // RVA: 0x24B10
        public void PostDispatch(){} // RVA: 0x24B10
        public void .ctor(){} // RVA: 0x24A50
    }

    public class PointerEventDispatchingStrategy : CanDispatchEvent
    {
        // ── Methods ──
        public void CanDispatchEvent(){} // RVA: 0x73F5BB0
        public void DispatchEvent(){} // RVA: 0x73F5C00
        public void SendEventToTarget(){} // RVA: 0x73F5CC0
        public void SetBestTargetForEvent(){} // RVA: 0x73F5D70
        public void UpdateElementUnderPointer(){} // RVA: 0x73F5F50
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class PointerEventHelper
    {
        // ── Methods ──
        public void GetPooled(){} // RVA: 0x73F66B0
    }

    public class PointerEventsHelper
    {
        // ── Methods ──
        public void SendEnterLeave(){} // RVA: 0x283FA0
        public void SendOverOut(){} // RVA: 0x73F2E30
    }

    public class PointerId
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x73F6530
    }

    public class PointerLeaveEvent
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x73F8F30
        public void Init(){} // RVA: 0x73F9020
        public void LocalInit(){} // RVA: 0x73F8DB0
        public void .ctor(){} // RVA: 0x73F9070
    }

    public class PointerManipulator
    {
        // ── Methods ──
        public void CanStartManipulation(){} // RVA: 0x74161A0
        public void CanStopManipulation(){} // RVA: 0x74163D0
        public void .ctor(){} // RVA: 0x7416440
    }

    public class PointerMoveEvent
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x73F6EA0
        public void get_isHandledByDraggable(){} // RVA: 0x66C530
        public void set_isHandledByDraggable(){} // RVA: 0x66C8F0
        public void Init(){} // RVA: 0x73F6F90
        public void LocalInit(){} // RVA: 0x73F6FE0
        public void .ctor(){} // RVA: 0x73F7050
        public void PostDispatch(){} // RVA: 0x73F70A0
    }

    public class PointerOutEvent
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x73F9420
        public void .ctor(){} // RVA: 0x73F9510
    }

    public class PointerOverEvent
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x73F91E0
        public void .ctor(){} // RVA: 0x73F92D0
    }

    public class PointerStationaryEvent
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x73F7650
        public void Init(){} // RVA: 0x73F7740
        public void LocalInit(){} // RVA: 0x73F77E0
        public void .ctor(){} // RVA: 0x73F7850
    }

    public class PointerType
    {
        // ── Methods ──
        public void GetPointerType(){} // RVA: 0x73F6160
        public void IsDirectManipulationDevice(){} // RVA: 0x73F6270
        public void .cctor(){} // RVA: 0x73F6300
    }

    public class PointerUpEvent
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x73F7A60
        public void Init(){} // RVA: 0x73F7B50
        public void LocalInit(){} // RVA: 0x73F7BF0
        public void .ctor(){} // RVA: 0x73F7C60
        public void PostDispatch(){} // RVA: 0x73F7D00
    }

    public class PopupField`1
    {
        // ── Methods ──
        public void GetValueToDisplay(){} // RVA: 0xCD60
        public void GetListItemToDisplay(){} // RVA: 0x283FA0
        public void get_value(){} // RVA: 0x283FA0
        public void set_value(){} // RVA: 0x283FA0
        public void SetValueWithoutNotify(){} // RVA: 0x283FA0
        public void set_index(){} // RVA: 0x24FA0
        public void .ctor(){} // RVA: 0x24B10
        public void AddMenuItems(){} // RVA: 0x24B10
        public void ChangeValueFromMenu(){} // RVA: 0x283FA0
        public void .cctor(){} // RVA: 0x24A80
    }

    public class PopupWindow
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x73B8BA0
        public void get_contentContainer(){} // RVA: 0x7309DF0
        public void .cctor(){} // RVA: 0x73B8DD0
    }

    public class ProgressBar
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x73BA4B0
    }

    public class ProjectionUtils
    {
        // ── Methods ──
        public void Ortho(){} // RVA: 0x7416450
    }

    public class PropagationPaths
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x73F9660
        public void Build(){} // RVA: 0x73F9960
        public void Release(){} // RVA: 0x73F9BC0
        public void .cctor(){} // RVA: 0x73F9CE0
    }

}