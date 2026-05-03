// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.OVR.OpenVR
// Classes: 23
// Methods: 335

namespace ThirdParty.Other.OVR.OpenVR
{
    public class COpenVRContext : ValueType
    {
    }

    public class CVRApplications : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86D2A580
        public void AddApplicationManifest(){} // RVA: 0x7FFE85CAD640
        public void RemoveApplicationManifest(){} // RVA: 0x7FFE81717120
        public void IsApplicationInstalled(){} // RVA: 0x7FFE8487FE20
        public void GetApplicationCount(){} // RVA: 0x7FFE848ABA00
        public void GetApplicationKeyByIndex(){} // RVA: 0x7FFE86D2A7A0
        public void GetApplicationKeyByProcessId(){} // RVA: 0x7FFE86D2A7D0
        public void LaunchApplication(){} // RVA: 0x7FFE86D2A430
        public void LaunchTemplateApplication(){} // RVA: 0x7FFE86D2A800
        public void LaunchApplicationFromMimeType(){} // RVA: 0x7FFE86D2A840
        public void LaunchDashboardOverlay(){} // RVA: 0x7FFE86D2A870
        public void CancelApplicationLaunch(){} // RVA: 0x7FFE85B64520
        public void IdentifyApplication(){} // RVA: 0x7FFE86D2A550
        public void GetApplicationProcessId(){} // RVA: 0x7FFE86D2A8A0
        public void GetApplicationsErrorNameFromEnum(){} // RVA: 0x7FFE86D2A8D0
        public void GetApplicationPropertyString(){} // RVA: 0x7FFE86D2A980
        public void GetApplicationPropertyBool(){} // RVA: 0x7FFE86D2A9C0
        public void GetApplicationPropertyUint64(){} // RVA: 0x7FFE86D2A9F0
        public void SetApplicationAutoLaunch(){} // RVA: 0x7FFE86D2AA20
        public void GetApplicationAutoLaunch(){} // RVA: 0x7FFE86D28C70
        public void SetDefaultApplicationForMimeType(){} // RVA: 0x7FFE86D2AA50
        public void GetDefaultApplicationForMimeType(){} // RVA: 0x7FFE86D2AA80
        public void GetApplicationSupportedMimeTypes(){} // RVA: 0x7FFE86D2AAB0
        public void GetApplicationsThatSupportMimeType(){} // RVA: 0x7FFE86D28D30
        public void GetApplicationLaunchArguments(){} // RVA: 0x7FFE86D28D60
        public void GetStartingApplication(){} // RVA: 0x7FFE86D2AAE0
        public void GetTransitionState(){} // RVA: 0x7FFE86D2AB10
        public void PerformApplicationPrelaunchCheck(){} // RVA: 0x7FFE86D2AB40
        public void GetApplicationsTransitionStateNameFromEnum(){} // RVA: 0x7FFE86D2AB70
        public void IsQuitUserPromptRequested(){} // RVA: 0x7FFE86D2AC20
        public void LaunchInternalProcess(){} // RVA: 0x7FFE86D2AC50
        public void GetCurrentSceneProcessId(){} // RVA: 0x7FFE86D2AC80
    }

    public class CVRChaperone : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86D2ACB0
        public void GetCalibrationState(){} // RVA: 0x7FFE82001D60
        public void GetPlayAreaSize(){} // RVA: 0x7FFE86D2AE50
        public void GetPlayAreaRect(){} // RVA: 0x7FFE8487FE20
        public void ReloadInfo(){} // RVA: 0x7FFE848ABA00
        public void SetSceneColor(){} // RVA: 0x7FFE86D2AE80
        public void GetBoundsColor(){} // RVA: 0x7FFE86D2AEC0
        public void AreBoundsVisible(){} // RVA: 0x7FFE86D289F0
        public void ForceBoundsVisible(){} // RVA: 0x7FFE86D2AEF0
    }

    public class CVRChaperoneSetup : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86D2AF20
        public void CommitWorkingCopy(){} // RVA: 0x7FFE85A7C5E0
        public void RevertWorkingCopy(){} // RVA: 0x7FFE84A02160
        public void GetWorkingPlayAreaSize(){} // RVA: 0x7FFE86D2B110
        public void GetWorkingPlayAreaRect(){} // RVA: 0x7FFE83FA8560
        public void GetWorkingCollisionBoundsInfo(){} // RVA: 0x7FFE86D2B140
        public void GetLiveCollisionBoundsInfo(){} // RVA: 0x7FFE86D2B230
        public void GetWorkingSeatedZeroPoseToRawTrackingPose(){} // RVA: 0x7FFE86D2A430
        public void GetWorkingStandingZeroPoseToRawTrackingPose(){} // RVA: 0x7FFE86D2AEF0
        public void SetWorkingPlayAreaSize(){} // RVA: 0x7FFE86D2A840
        public void SetWorkingCollisionBoundsInfo(){} // RVA: 0x7FFE86D2B320
        public void SetWorkingSeatedZeroPoseToRawTrackingPose(){} // RVA: 0x7FFE85B64520
        public void SetWorkingStandingZeroPoseToRawTrackingPose(){} // RVA: 0x7FFE86D2B350
        public void ReloadFromDisk(){} // RVA: 0x7FFE86D2A8A0
        public void GetLiveSeatedZeroPoseToRawTrackingPose(){} // RVA: 0x7FFE86D2B380
        public void SetWorkingCollisionBoundsTagsInfo(){} // RVA: 0x7FFE86D2B3B0
        public void GetLiveCollisionBoundsTagsInfo(){} // RVA: 0x7FFE86D2B3F0
        public void SetWorkingPhysicalBoundsInfo(){} // RVA: 0x7FFE86D2B4E0
        public void GetLivePhysicalBoundsInfo(){} // RVA: 0x7FFE86D2B520
        public void ExportLiveToBuffer(){} // RVA: 0x7FFE86D2B610
        public void ImportFromBufferToWorking(){} // RVA: 0x7FFE86D2AA50
    }

    public class CVRCompositor : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86D2B640
        public void SetTrackingSpace(){} // RVA: 0x7FFE85A7C5E0
        public void GetTrackingSpace(){} // RVA: 0x7FFE84A02160
        public void WaitGetPoses(){} // RVA: 0x7FFE86D2B860
        public void GetLastPoses(){} // RVA: 0x7FFE86D2B8B0
        public void GetLastPoseForTrackedDeviceIndex(){} // RVA: 0x7FFE86D2A7A0
        public void Submit(){} // RVA: 0x7FFE86D2B900
        public void ClearLastSubmittedFrame(){} // RVA: 0x7FFE86D289F0
        public void PostPresentHandoff(){} // RVA: 0x7FFE86D2B930
        public void GetFrameTiming(){} // RVA: 0x7FFE86D2A840
        public void GetFrameTimings(){} // RVA: 0x7FFE86D2B960
        public void GetFrameTimeRemaining(){} // RVA: 0x7FFE86D2B990
        public void GetCumulativeStats(){} // RVA: 0x7FFE86D2A550
        public void FadeToColor(){} // RVA: 0x7FFE86D2B9C0
        public void GetCurrentFadeColor(){} // RVA: 0x7FFE86D2BA10
        public void FadeGrid(){} // RVA: 0x7FFE86D2BA50
        public void GetCurrentGridAlpha(){} // RVA: 0x7FFE86D2BA80
        public void SetSkyboxOverride(){} // RVA: 0x7FFE86D2B4E0
        public void ClearSkyboxOverride(){} // RVA: 0x7FFE86D2BAB0
        public void CompositorBringToFront(){} // RVA: 0x7FFE86D2BAE0
        public void CompositorGoToBack(){} // RVA: 0x7FFE86D2BB10
        public void CompositorQuit(){} // RVA: 0x7FFE86D2BB40
        public void IsFullscreen(){} // RVA: 0x7FFE86D2BB70
        public void GetCurrentSceneFocusProcess(){} // RVA: 0x7FFE86D2BBA0
        public void GetLastFrameRenderer(){} // RVA: 0x7FFE86D2BBD0
        public void CanRenderScene(){} // RVA: 0x7FFE86D2BC00
        public void ShowMirrorWindow(){} // RVA: 0x7FFE86D2AB10
        public void HideMirrorWindow(){} // RVA: 0x7FFE86D2BC30
        public void IsMirrorWindowVisible(){} // RVA: 0x7FFE86D2BC60
        public void CompositorDumpImages(){} // RVA: 0x7FFE86D2AC20
        public void ShouldAppRenderWithLowResources(){} // RVA: 0x7FFE86D2BC90
        public void ForceInterleavedReprojectionOn(){} // RVA: 0x7FFE86D2BCC0
        public void ForceReconnectProcess(){} // RVA: 0x7FFE86D2BCF0
        public void SuspendRendering(){} // RVA: 0x7FFE86D2BD20
        public void GetMirrorTextureD3D11(){} // RVA: 0x7FFE86D2BD50
        public void ReleaseMirrorTextureD3D11(){} // RVA: 0x7FFE86D2BD80
        public void GetMirrorTextureGL(){} // RVA: 0x7FFE86D2BDB0
        public void ReleaseSharedGLTexture(){} // RVA: 0x7FFE86D2BDF0
        public void LockGLSharedTextureForAccess(){} // RVA: 0x7FFE86D2BE20
        public void UnlockGLSharedTextureForAccess(){} // RVA: 0x7FFE86D2BE50
        public void GetVulkanInstanceExtensionsRequired(){} // RVA: 0x7FFE86D2BE80
        public void GetVulkanDeviceExtensionsRequired(){} // RVA: 0x7FFE86D2BEB0
        public void SetExplicitTimingMode(){} // RVA: 0x7FFE86D2BEE0
        public void SubmitExplicitTimingData(){} // RVA: 0x7FFE86D29AE0
    }

    public class CVRDriverManager : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86D2E540
        public void GetDriverCount(){} // RVA: 0x7FFE82001D60
        public void GetDriverName(){} // RVA: 0x7FFE86D2E6E0
        public void GetDriverHandle(){} // RVA: 0x7FFE8487FE20
    }

    public class CVRExtendedDisplay : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86D29E50
        public void GetWindowBounds(){} // RVA: 0x7FFE86D29FF0
        public void GetEyeOutputViewport(){} // RVA: 0x7FFE86D2A030
        public void GetDXGIOutputInfo(){} // RVA: 0x7FFE86D2A080
    }

    public class CVRIOBuffer : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86D2EBF0
        public void Open(){} // RVA: 0x7FFE86D2ED90
        public void Close(){} // RVA: 0x7FFE81717120
        public void Read(){} // RVA: 0x7FFE86D2EDD0
        public void Write(){} // RVA: 0x7FFE86D2EE10
        public void PropertyContainer(){} // RVA: 0x7FFE865CE920
    }

    public class CVRInput : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86D2E710
        public void SetActionManifestPath(){} // RVA: 0x7FFE85A7C5E0
        public void GetActionSetHandle(){} // RVA: 0x7FFE86D2E8F0
        public void GetActionHandle(){} // RVA: 0x7FFE86D2E920
        public void GetInputSourceHandle(){} // RVA: 0x7FFE86D2E950
        public void UpdateActionState(){} // RVA: 0x7FFE86D2E980
        public void GetDigitalActionData(){} // RVA: 0x7FFE86D2B900
        public void GetAnalogActionData(){} // RVA: 0x7FFE86D2C1A0
        public void GetPoseActionData(){} // RVA: 0x7FFE86D2E9C0
        public void GetSkeletalActionData(){} // RVA: 0x7FFE86D2E9F0
        public void GetSkeletalBoneData(){} // RVA: 0x7FFE86D2EA20
        public void GetSkeletalBoneDataCompressed(){} // RVA: 0x7FFE86D2EA80
        public void DecompressSkeletalBoneData(){} // RVA: 0x7FFE86D2EAC0
        public void TriggerHapticVibrationAction(){} // RVA: 0x7FFE86D2EB10
        public void GetActionOrigins(){} // RVA: 0x7FFE86D2EB40
        public void GetOriginLocalizedName(){} // RVA: 0x7FFE86D2EB80
        public void GetOriginTrackedDeviceInfo(){} // RVA: 0x7FFE86D2A9C0
        public void ShowActionOrigins(){} // RVA: 0x7FFE86D2C380
        public void ShowBindingsForActionSet(){} // RVA: 0x7FFE86D2EBB0
    }

    public class CVRNotifications : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86D2DB00
        public void CreateNotification(){} // RVA: 0x7FFE86D2DC90
        public void RemoveNotification(){} // RVA: 0x7FFE81717120
    }

    public class CVROverlay : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86D2BF10
        public void FindOverlay(){} // RVA: 0x7FFE86D2C100
        public void CreateOverlay(){} // RVA: 0x7FFE86D2C130
        public void DestroyOverlay(){} // RVA: 0x7FFE8487FE20
        public void SetHighQualityOverlay(){} // RVA: 0x7FFE83FA8560
        public void GetHighQualityOverlay(){} // RVA: 0x7FFE86D2C170
        public void GetOverlayKey(){} // RVA: 0x7FFE86D2B900
        public void GetOverlayName(){} // RVA: 0x7FFE86D2C1A0
        public void SetOverlayName(){} // RVA: 0x7FFE85B63750
        public void GetOverlayImageData(){} // RVA: 0x7FFE86D2A490
        public void GetOverlayErrorNameFromEnum(){} // RVA: 0x7FFE86D2C1D0
        public void SetOverlayRenderingPid(){} // RVA: 0x7FFE86D2C280
        public void GetOverlayRenderingPid(){} // RVA: 0x7FFE86D2B350
        public void SetOverlayFlag(){} // RVA: 0x7FFE86D2C2B0
        public void GetOverlayFlag(){} // RVA: 0x7FFE86D2C2E0
        public void SetOverlayColor(){} // RVA: 0x7FFE86D2C310
        public void GetOverlayColor(){} // RVA: 0x7FFE86D2C340
        public void SetOverlayAlpha(){} // RVA: 0x7FFE86D2C380
        public void GetOverlayAlpha(){} // RVA: 0x7FFE86D2C3B0
        public void SetOverlayTexelAspect(){} // RVA: 0x7FFE86D2C3E0
        public void GetOverlayTexelAspect(){} // RVA: 0x7FFE86D2C410
        public void SetOverlaySortOrder(){} // RVA: 0x7FFE86D2C440
        public void GetOverlaySortOrder(){} // RVA: 0x7FFE86D2C470
        public void SetOverlayWidthInMeters(){} // RVA: 0x7FFE86D2C4A0
        public void GetOverlayWidthInMeters(){} // RVA: 0x7FFE86D2C4D0
        public void SetOverlayAutoCurveDistanceRangeInMeters(){} // RVA: 0x7FFE86D2C500
        public void GetOverlayAutoCurveDistanceRangeInMeters(){} // RVA: 0x7FFE86D2C530
        public void SetOverlayTextureColorSpace(){} // RVA: 0x7FFE86D2C570
        public void GetOverlayTextureColorSpace(){} // RVA: 0x7FFE86D2C5A0
        public void SetOverlayTextureBounds(){} // RVA: 0x7FFE86D2C5D0
        public void GetOverlayTextureBounds(){} // RVA: 0x7FFE86D2C600
        public void GetOverlayRenderModel(){} // RVA: 0x7FFE86D2C630
        public void SetOverlayRenderModel(){} // RVA: 0x7FFE86D2C670
        public void GetOverlayTransformType(){} // RVA: 0x7FFE86D2C6A0
        public void SetOverlayTransformAbsolute(){} // RVA: 0x7FFE86D2BD50
        public void GetOverlayTransformAbsolute(){} // RVA: 0x7FFE86D2C6D0
        public void SetOverlayTransformTrackedDeviceRelative(){} // RVA: 0x7FFE86D2C700
        public void GetOverlayTransformTrackedDeviceRelative(){} // RVA: 0x7FFE86D2C730
        public void SetOverlayTransformTrackedDeviceComponent(){} // RVA: 0x7FFE86D2C770
        public void GetOverlayTransformTrackedDeviceComponent(){} // RVA: 0x7FFE86D2C7A0
        public void GetOverlayTransformOverlayRelative(){} // RVA: 0x7FFE86D2C7E0
        public void SetOverlayTransformOverlayRelative(){} // RVA: 0x7FFE86D2BEB0
        public void ShowOverlay(){} // RVA: 0x7FFE86D2BEE0
        public void HideOverlay(){} // RVA: 0x7FFE86D2C820
        public void IsOverlayVisible(){} // RVA: 0x7FFE86D2C850
        public void GetTransformForOverlayCoordinates(){} // RVA: 0x7FFE86D2C880
        public void PollNextOverlayEvent(){} // RVA: 0x7FFE86D2C8B0
        public void GetOverlayInputMethod(){} // RVA: 0x7FFE86D2CB10
        public void SetOverlayInputMethod(){} // RVA: 0x7FFE86D2CB40
        public void GetOverlayMouseScale(){} // RVA: 0x7FFE86D2CB70
        public void SetOverlayMouseScale(){} // RVA: 0x7FFE86D2CBA0
        public void ComputeOverlayIntersection(){} // RVA: 0x7FFE86D2CBD0
        public void IsHoverTargetOverlay(){} // RVA: 0x7FFE86D2CC00
        public void GetGamepadFocusOverlay(){} // RVA: 0x7FFE86D2CC30
        public void SetGamepadFocusOverlay(){} // RVA: 0x7FFE86D2CC60
        public void SetOverlayNeighbor(){} // RVA: 0x7FFE86D2CC90
        public void MoveGamepadFocusToNeighbor(){} // RVA: 0x7FFE86D2CCC0
        public void SetOverlayDualAnalogTransform(){} // RVA: 0x7FFE86D2CCF0
        public void GetOverlayDualAnalogTransform(){} // RVA: 0x7FFE86D2CD20
        public void SetOverlayTexture(){} // RVA: 0x7FFE86D2CD60
        public void ClearOverlayTexture(){} // RVA: 0x7FFE86D2CD90
        public void SetOverlayRaw(){} // RVA: 0x7FFE86D2CDC0
        public void SetOverlayFromFile(){} // RVA: 0x7FFE86D2CE00
        public void GetOverlayTexture(){} // RVA: 0x7FFE86D2CE30
        public void ReleaseNativeOverlayHandle(){} // RVA: 0x7FFE86D2CE90
        public void GetOverlayTextureSize(){} // RVA: 0x7FFE86D2CEC0
        public void CreateDashboardOverlay(){} // RVA: 0x7FFE86D2CF00
        public void IsDashboardVisible(){} // RVA: 0x7FFE86D2CF40
        public void IsActiveDashboardOverlay(){} // RVA: 0x7FFE86D2CF70
        public void SetDashboardOverlaySceneProcess(){} // RVA: 0x7FFE86D2CFA0
        public void GetDashboardOverlaySceneProcess(){} // RVA: 0x7FFE86D2CFD0
        public void ShowDashboard(){} // RVA: 0x7FFE86D2D000
        public void GetPrimaryDashboardDevice(){} // RVA: 0x7FFE86D2D030
        public void ShowKeyboard(){} // RVA: 0x7FFE86D2D060
        public void ShowKeyboardForOverlay(){} // RVA: 0x7FFE86D2D0A0
        public void GetKeyboardText(){} // RVA: 0x7FFE86D2D0E0
        public void HideKeyboard(){} // RVA: 0x7FFE86D2D110
        public void SetKeyboardTransformAbsolute(){} // RVA: 0x7FFE86D2D140
        public void SetKeyboardPositionForOverlay(){} // RVA: 0x7FFE86D2D170
        public void SetOverlayIntersectionMask(){} // RVA: 0x7FFE86D2D1B0
        public void GetOverlayFlags(){} // RVA: 0x7FFE86D2D1E0
        public void ShowMessageOverlay(){} // RVA: 0x7FFE86D2D210
        public void CloseMessageOverlay(){} // RVA: 0x7FFE86D2D250
    }

    public class CVRRenderModels : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86D2D350
        public void LoadRenderModel_Async(){} // RVA: 0x7FFE85CAD640
        public void FreeRenderModel(){} // RVA: 0x7FFE81717120
        public void LoadTexture_Async(){} // RVA: 0x7FFE865CE950
        public void FreeTexture(){} // RVA: 0x7FFE83FA8560
        public void LoadTextureD3D11_Async(){} // RVA: 0x7FFE86D2A7A0
        public void LoadIntoTextureD3D11_Async(){} // RVA: 0x7FFE86D2D540
        public void FreeTextureD3D11(){} // RVA: 0x7FFE86D2A430
        public void GetRenderModelName(){} // RVA: 0x7FFE86D2D570
        public void GetRenderModelCount(){} // RVA: 0x7FFE86D2D5A0
        public void GetComponentCount(){} // RVA: 0x7FFE86D2A870
        public void GetComponentName(){} // RVA: 0x7FFE86D2D5D0
        public void GetComponentButtonMask(){} // RVA: 0x7FFE86D2A550
        public void GetComponentRenderModelName(){} // RVA: 0x7FFE86D2D600
        public void GetComponentStateForDevicePath(){} // RVA: 0x7FFE86D2D630
        public void GetComponentState(){} // RVA: 0x7FFE86D2D660
        public void RenderModelHasComponent(){} // RVA: 0x7FFE86D2D8D0
        public void GetRenderModelThumbnailURL(){} // RVA: 0x7FFE86D2D900
        public void GetRenderModelOriginalPath(){} // RVA: 0x7FFE86D2D930
        public void GetRenderModelErrorNameFromEnum(){} // RVA: 0x7FFE86D2D960
    }

    public class CVRResources : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86D2E350
        public void LoadSharedResource(){} // RVA: 0x7FFE86D2E4E0
        public void GetResourceFullPath(){} // RVA: 0x7FFE86D2E510
    }

    public class CVRScreenshots : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86D2E090
        public void RequestScreenshot(){} // RVA: 0x7FFE86D2E240
        public void HookScreenshot(){} // RVA: 0x7FFE86D2E280
        public void GetScreenshotPropertyType(){} // RVA: 0x7FFE865CE950
        public void GetScreenshotPropertyFilename(){} // RVA: 0x7FFE86D2E2B0
        public void UpdateScreenshotProgress(){} // RVA: 0x7FFE86D2E2E0
        public void TakeStereoScreenshot(){} // RVA: 0x7FFE86D2E310
        public void SubmitScreenshot(){} // RVA: 0x7FFE86D2C1A0
    }

    public class CVRSettingHelper : ValueType
    {
    }

    public class CVRSettings : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86D2DCD0
        public void GetSettingsErrorNameFromEnum(){} // RVA: 0x7FFE86D2DE90
        public void Sync(){} // RVA: 0x7FFE86D2DF40
        public void SetBool(){} // RVA: 0x7FFE86D2DF70
        public void SetInt32(){} // RVA: 0x7FFE86D2A3A0
        public void SetFloat(){} // RVA: 0x7FFE86D2DFA0
        public void SetString(){} // RVA: 0x7FFE86D2B900
        public void GetBool(){} // RVA: 0x7FFE86D2DFD0
        public void GetInt32(){} // RVA: 0x7FFE86D2D570
        public void GetFloat(){} // RVA: 0x7FFE86D2E000
        public void GetString(){} // RVA: 0x7FFE86D2E030
        public void RemoveSection(){} // RVA: 0x7FFE86D2C280
        public void RemoveKeyInSection(){} // RVA: 0x7FFE86D2E060
    }

    public class CVRSpatialAnchors : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86D2EE40
        public void CreateSpatialAnchorFromDescriptor(){} // RVA: 0x7FFE86D2EFD0
        public void CreateSpatialAnchorFromPose(){} // RVA: 0x7FFE86D2F000
        public void GetSpatialAnchorPose(){} // RVA: 0x7FFE86D2F040
        public void GetSpatialAnchorDescriptor(){} // RVA: 0x7FFE86D2F070
    }

    public class CVRSystem : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86D28620
        public void GetRecommendedRenderTargetSize(){} // RVA: 0x7FFE86D28850
        public void GetProjectionMatrix(){} // RVA: 0x7FFE86D28880
        public void GetProjectionRaw(){} // RVA: 0x7FFE86D288F0
        public void ComputeDistortion(){} // RVA: 0x7FFE86D28940
        public void GetEyeToHeadTransform(){} // RVA: 0x7FFE86D28970
        public void GetTimeSinceLastVsync(){} // RVA: 0x7FFE86D289C0
        public void GetD3D9AdapterIndex(){} // RVA: 0x7FFE86D289F0
        public void GetDXGIOutputInfo(){} // RVA: 0x7FFE86D28A20
        public void GetOutputDevice(){} // RVA: 0x7FFE86D28A50
        public void IsDisplayOnDesktop(){} // RVA: 0x7FFE86D28A90
        public void SetDisplayVisibility(){} // RVA: 0x7FFE85B64520
        public void GetDeviceToAbsoluteTrackingPose(){} // RVA: 0x7FFE86D28AC0
        public void ResetSeatedZeroPose(){} // RVA: 0x7FFE86D28B00
        public void GetSeatedZeroPoseToStandingAbsoluteTrackingPose(){} // RVA: 0x7FFE86D28B30
        public void GetRawZeroPoseToStandingAbsoluteTrackingPose(){} // RVA: 0x7FFE86D28B80
        public void GetSortedTrackedDeviceIndicesOfClass(){} // RVA: 0x7FFE86D28BD0
        public void GetTrackedDeviceActivityLevel(){} // RVA: 0x7FFE86D28C10
        public void ApplyTransform(){} // RVA: 0x7FFE86D28C40
        public void GetTrackedDeviceIndexForControllerRole(){} // RVA: 0x7FFE86D28C70
        public void GetControllerRoleForTrackedDeviceIndex(){} // RVA: 0x7FFE86D28CA0
        public void GetTrackedDeviceClass(){} // RVA: 0x7FFE86D28CD0
        public void IsTrackedDeviceConnected(){} // RVA: 0x7FFE86D28D00
        public void GetBoolTrackedDeviceProperty(){} // RVA: 0x7FFE86D28D30
        public void GetFloatTrackedDeviceProperty(){} // RVA: 0x7FFE86D28D60
        public void GetInt32TrackedDeviceProperty(){} // RVA: 0x7FFE86D28D90
        public void GetUint64TrackedDeviceProperty(){} // RVA: 0x7FFE86D28DC0
        public void GetMatrix34TrackedDeviceProperty(){} // RVA: 0x7FFE86D28DF0
        public void GetArrayTrackedDeviceProperty(){} // RVA: 0x7FFE86D28E50
        public void GetStringTrackedDeviceProperty(){} // RVA: 0x7FFE86D28E90
        public void GetPropErrorNameFromEnum(){} // RVA: 0x7FFE86D28ED0
        public void PollNextEvent(){} // RVA: 0x7FFE86D28F80
        public void PollNextEventWithPose(){} // RVA: 0x7FFE86D291C0
        public void GetEventTypeNameFromEnum(){} // RVA: 0x7FFE86D291F0
        public void GetHiddenAreaMesh(){} // RVA: 0x7FFE86D292A0
        public void GetControllerState(){} // RVA: 0x7FFE86D292F0
        public void GetControllerStateWithPose(){} // RVA: 0x7FFE86D295C0
        public void TriggerHapticPulse(){} // RVA: 0x7FFE86D298C0
        public void GetButtonIdNameFromEnum(){} // RVA: 0x7FFE86D298F0
        public void GetControllerAxisTypeNameFromEnum(){} // RVA: 0x7FFE86D299A0
        public void IsInputAvailable(){} // RVA: 0x7FFE86D29A50
        public void IsSteamVRDrawingControllers(){} // RVA: 0x7FFE86D29A80
        public void ShouldApplicationPause(){} // RVA: 0x7FFE86D29AB0
        public void ShouldApplicationReduceRenderingWork(){} // RVA: 0x7FFE86D29AE0
        public void DriverDebugRequest(){} // RVA: 0x7FFE86D29B10
        public void PerformFirmwareUpdate(){} // RVA: 0x7FFE86D29B40
        public void AcknowledgeQuit_Exiting(){} // RVA: 0x7FFE86D29B70
        public void AcknowledgeQuit_UserPrompt(){} // RVA: 0x7FFE86D29BA0
    }

    public class CVRTrackedCamera : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86D2A0B0
        public void GetCameraErrorNameFromEnum(){} // RVA: 0x7FFE86D2A270
        public void HasCamera(){} // RVA: 0x7FFE86D2A320
        public void GetCameraFrameSize(){} // RVA: 0x7FFE86D2A350
        public void GetCameraIntrinsics(){} // RVA: 0x7FFE86D2A3A0
        public void GetCameraProjection(){} // RVA: 0x7FFE86D2A3D0
        public void AcquireVideoStreamingService(){} // RVA: 0x7FFE86D2A400
        public void ReleaseVideoStreamingService(){} // RVA: 0x7FFE86D2A430
        public void GetVideoStreamFrameBuffer(){} // RVA: 0x7FFE86D2A460
        public void GetVideoStreamTextureSize(){} // RVA: 0x7FFE86D2A490
        public void GetVideoStreamTextureD3D11(){} // RVA: 0x7FFE86D2A4E0
        public void GetVideoStreamTextureGL(){} // RVA: 0x7FFE86D2A510
        public void ReleaseVideoStreamTextureGL(){} // RVA: 0x7FFE86D2A550
    }

    public class CameraVideoStreamFrameHeader_t : ValueType
    {
    }

    public class Compositor_CumulativeStats : ValueType
    {
    }

    public class Compositor_FrameTiming : ValueType
    {
    }

    public class Compositor_OverlaySettings : ValueType
    {
    }

}