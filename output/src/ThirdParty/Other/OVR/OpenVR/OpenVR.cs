// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.OVR.OpenVR
// Classes: 25
// Methods: 383

namespace ThirdParty.Other.OVR.OpenVR
{
    public class CVRApplications : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADFD6520
        public void AddApplicationManifest(){} // RVA: 0x7ACF647F0
        public void RemoveApplicationManifest(){} // RVA: 0x7A8743650
        public void IsApplicationInstalled(){} // RVA: 0x7AB9EF6F0
        public void GetApplicationCount(){} // RVA: 0x7ABA29AE0
        public void GetApplicationKeyByIndex(){} // RVA: 0x7ADFD6740
        public void GetApplicationKeyByProcessId(){} // RVA: 0x7ADFD6770
        public void LaunchApplication(){} // RVA: 0x7ADFD63D0
        public void LaunchTemplateApplication(){} // RVA: 0x7ADFD67A0
        public void LaunchApplicationFromMimeType(){} // RVA: 0x7ADFD67E0
        public void LaunchDashboardOverlay(){} // RVA: 0x7ADFD6810
        public void CancelApplicationLaunch(){} // RVA: 0x7ACF04BB0
        public void IdentifyApplication(){} // RVA: 0x7ADFD64F0
        public void GetApplicationProcessId(){} // RVA: 0x7ADFD6840
        public void GetApplicationsErrorNameFromEnum(){} // RVA: 0x7ADFD6870
        public void GetApplicationPropertyString(){} // RVA: 0x7ADFD6920
        public void GetApplicationPropertyBool(){} // RVA: 0x7ADFD6960
        public void GetApplicationPropertyUint64(){} // RVA: 0x7ADFD6990
        public void SetApplicationAutoLaunch(){} // RVA: 0x7ADFD69C0
        public void GetApplicationAutoLaunch(){} // RVA: 0x7ADFD4BD0
        public void SetDefaultApplicationForMimeType(){} // RVA: 0x7ADFD69F0
        public void GetDefaultApplicationForMimeType(){} // RVA: 0x7ADFD6A20
        public void GetApplicationSupportedMimeTypes(){} // RVA: 0x7ADFD6A50
        public void GetApplicationsThatSupportMimeType(){} // RVA: 0x7ADFD4C90
        public void GetApplicationLaunchArguments(){} // RVA: 0x7ADFD4CC0
        public void GetStartingApplication(){} // RVA: 0x7ADFD6A80
        public void GetTransitionState(){} // RVA: 0x7ADFD6AB0
        public void PerformApplicationPrelaunchCheck(){} // RVA: 0x7ADFD6AE0
        public void GetApplicationsTransitionStateNameFromEnum(){} // RVA: 0x7ADFD6B10
        public void IsQuitUserPromptRequested(){} // RVA: 0x7ADFD6BC0
        public void LaunchInternalProcess(){} // RVA: 0x7ADFD6BF0
        public void GetCurrentSceneProcessId(){} // RVA: 0x7ADFD6C20
    }

    public class CVRChaperone : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADFD6C50
        public void GetCalibrationState(){} // RVA: 0x7A9038740
        public void GetPlayAreaSize(){} // RVA: 0x7ADFD6DF0
        public void GetPlayAreaRect(){} // RVA: 0x7AB9EF6F0
        public void ReloadInfo(){} // RVA: 0x7ABA29AE0
        public void SetSceneColor(){} // RVA: 0x7ADFD6E20
        public void GetBoundsColor(){} // RVA: 0x7ADFD6E60
        public void AreBoundsVisible(){} // RVA: 0x7ADFD4950
        public void ForceBoundsVisible(){} // RVA: 0x7ADFD6E90
    }

    public class CVRChaperoneSetup : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADFD6EC0
        public void CommitWorkingCopy(){} // RVA: 0x7ACEFA0B0
        public void RevertWorkingCopy(){} // RVA: 0x7ABB8BE10
        public void GetWorkingPlayAreaSize(){} // RVA: 0x7ADFD70B0
        public void GetWorkingPlayAreaRect(){} // RVA: 0x7AB121480
        public void GetWorkingCollisionBoundsInfo(){} // RVA: 0x7ADFD70E0
        public void GetLiveCollisionBoundsInfo(){} // RVA: 0x7ADFD71D0
        public void GetWorkingSeatedZeroPoseToRawTrackingPose(){} // RVA: 0x7ADFD63D0
        public void GetWorkingStandingZeroPoseToRawTrackingPose(){} // RVA: 0x7ADFD6E90
        public void SetWorkingPlayAreaSize(){} // RVA: 0x7ADFD67E0
        public void SetWorkingCollisionBoundsInfo(){} // RVA: 0x7ADFD72C0
        public void SetWorkingSeatedZeroPoseToRawTrackingPose(){} // RVA: 0x7ACF04BB0
        public void SetWorkingStandingZeroPoseToRawTrackingPose(){} // RVA: 0x7ADFD72F0
        public void ReloadFromDisk(){} // RVA: 0x7ADFD6840
        public void GetLiveSeatedZeroPoseToRawTrackingPose(){} // RVA: 0x7ADFD7320
        public void SetWorkingCollisionBoundsTagsInfo(){} // RVA: 0x7ADFD7350
        public void GetLiveCollisionBoundsTagsInfo(){} // RVA: 0x7ADFD7390
        public void SetWorkingPhysicalBoundsInfo(){} // RVA: 0x7ADFD7480
        public void GetLivePhysicalBoundsInfo(){} // RVA: 0x7ADFD74C0
        public void ExportLiveToBuffer(){} // RVA: 0x7ADFD75B0
        public void ImportFromBufferToWorking(){} // RVA: 0x7ADFD69F0
    }

    public class CVRCompositor : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADFD75E0
        public void SetTrackingSpace(){} // RVA: 0x7ACEFA0B0
        public void GetTrackingSpace(){} // RVA: 0x7ABB8BE10
        public void WaitGetPoses(){} // RVA: 0x7ADFD7800
        public void GetLastPoses(){} // RVA: 0x7ADFD7850
        public void GetLastPoseForTrackedDeviceIndex(){} // RVA: 0x7ADFD6740
        public void Submit(){} // RVA: 0x7ADFD78A0
        public void ClearLastSubmittedFrame(){} // RVA: 0x7ADFD4950
        public void PostPresentHandoff(){} // RVA: 0x7ADFD78D0
        public void GetFrameTiming(){} // RVA: 0x7ADFD67E0
        public void GetFrameTimings(){} // RVA: 0x7ADFD7900
        public void GetFrameTimeRemaining(){} // RVA: 0x7ADFD7930
        public void GetCumulativeStats(){} // RVA: 0x7ADFD64F0
        public void FadeToColor(){} // RVA: 0x7ADFD7960
        public void GetCurrentFadeColor(){} // RVA: 0x7ADFD79B0
        public void FadeGrid(){} // RVA: 0x7ADFD79F0
        public void GetCurrentGridAlpha(){} // RVA: 0x7ADFD7A20
        public void SetSkyboxOverride(){} // RVA: 0x7ADFD7480
        public void ClearSkyboxOverride(){} // RVA: 0x7ADFD7A50
        public void CompositorBringToFront(){} // RVA: 0x7ADFD7A80
        public void CompositorGoToBack(){} // RVA: 0x7ADFD7AB0
        public void CompositorQuit(){} // RVA: 0x7ADFD7AE0
        public void IsFullscreen(){} // RVA: 0x7ADFD7B10
        public void GetCurrentSceneFocusProcess(){} // RVA: 0x7ADFD7B40
        public void GetLastFrameRenderer(){} // RVA: 0x7ADFD7B70
        public void CanRenderScene(){} // RVA: 0x7ADFD7BA0
        public void ShowMirrorWindow(){} // RVA: 0x7ADFD6AB0
        public void HideMirrorWindow(){} // RVA: 0x7ADFD7BD0
        public void IsMirrorWindowVisible(){} // RVA: 0x7ADFD7C00
        public void CompositorDumpImages(){} // RVA: 0x7ADFD6BC0
        public void ShouldAppRenderWithLowResources(){} // RVA: 0x7ADFD7C30
        public void ForceInterleavedReprojectionOn(){} // RVA: 0x7ADFD7C60
        public void ForceReconnectProcess(){} // RVA: 0x7ADFD7C90
        public void SuspendRendering(){} // RVA: 0x7ADFD7CC0
        public void GetMirrorTextureD3D11(){} // RVA: 0x7ADFD7CF0
        public void ReleaseMirrorTextureD3D11(){} // RVA: 0x7ADFD7D20
        public void GetMirrorTextureGL(){} // RVA: 0x7ADFD7D50
        public void ReleaseSharedGLTexture(){} // RVA: 0x7ADFD7D90
        public void LockGLSharedTextureForAccess(){} // RVA: 0x7ADFD7DC0
        public void UnlockGLSharedTextureForAccess(){} // RVA: 0x7ADFD7DF0
        public void GetVulkanInstanceExtensionsRequired(){} // RVA: 0x7ADFD7E20
        public void GetVulkanDeviceExtensionsRequired(){} // RVA: 0x7ADFD7E50
        public void SetExplicitTimingMode(){} // RVA: 0x7ADFD7E80
        public void SubmitExplicitTimingData(){} // RVA: 0x7ADFD5A90
    }

    public class CVRDriverManager : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADFDA500
        public void GetDriverCount(){} // RVA: 0x7A9038740
        public void GetDriverName(){} // RVA: 0x7ADFDA690
        public void GetDriverHandle(){} // RVA: 0x7AB9EF6F0
    }

    public class CVRExtendedDisplay : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADFD5E00
        public void GetWindowBounds(){} // RVA: 0x7ADFD5F90
        public void GetEyeOutputViewport(){} // RVA: 0x7ADFD5FD0
        public void GetDXGIOutputInfo(){} // RVA: 0x7ADFD6020
    }

    public class CVRIOBuffer : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADFDAB90
        public void Open(){} // RVA: 0x7ADFDAD20
        public void Close(){} // RVA: 0x7A8743650
        public void Read(){} // RVA: 0x7ADFDAD60
        public void Write(){} // RVA: 0x7ADFDADA0
        public void PropertyContainer(){} // RVA: 0x7AD87A970
    }

    public class CVRInput : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADFDA6C0
        public void SetActionManifestPath(){} // RVA: 0x7ACEFA0B0
        public void GetActionSetHandle(){} // RVA: 0x7ADFDA8A0
        public void GetActionHandle(){} // RVA: 0x7ADFDA8D0
        public void GetInputSourceHandle(){} // RVA: 0x7ADFDA900
        public void UpdateActionState(){} // RVA: 0x7ADFDA930
        public void GetDigitalActionData(){} // RVA: 0x7ADFD78A0
        public void GetAnalogActionData(){} // RVA: 0x7ADFD8140
        public void GetPoseActionData(){} // RVA: 0x7ADFDA970
        public void GetSkeletalActionData(){} // RVA: 0x7ADFDA9A0
        public void GetSkeletalBoneData(){} // RVA: 0x7ADFDA9D0
        public void GetSkeletalBoneDataCompressed(){} // RVA: 0x7ADFDAA20
        public void DecompressSkeletalBoneData(){} // RVA: 0x7ADFDAA60
        public void TriggerHapticVibrationAction(){} // RVA: 0x7ADFDAAB0
        public void GetActionOrigins(){} // RVA: 0x7ADFDAAE0
        public void GetOriginLocalizedName(){} // RVA: 0x7ADFDAB20
        public void GetOriginTrackedDeviceInfo(){} // RVA: 0x7ADFD6960
        public void ShowActionOrigins(){} // RVA: 0x7ADFD8320
        public void ShowBindingsForActionSet(){} // RVA: 0x7ADFDAB50
    }

    public class CVRNotifications : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADFD9AE0
        public void CreateNotification(){} // RVA: 0x7ADFD9C60
        public void RemoveNotification(){} // RVA: 0x7A8743650
    }

    public class CVROverlay : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADFD7EB0
        public void FindOverlay(){} // RVA: 0x7ADFD80A0
        public void CreateOverlay(){} // RVA: 0x7ADFD80D0
        public void DestroyOverlay(){} // RVA: 0x7AB9EF6F0
        public void SetHighQualityOverlay(){} // RVA: 0x7AB121480
        public void GetHighQualityOverlay(){} // RVA: 0x7ADFD8110
        public void GetOverlayKey(){} // RVA: 0x7ADFD78A0
        public void GetOverlayName(){} // RVA: 0x7ADFD8140
        public void SetOverlayName(){} // RVA: 0x7ACF04090
        public void GetOverlayImageData(){} // RVA: 0x7ADFD6430
        public void GetOverlayErrorNameFromEnum(){} // RVA: 0x7ADFD8170
        public void SetOverlayRenderingPid(){} // RVA: 0x7ADFD8220
        public void GetOverlayRenderingPid(){} // RVA: 0x7ADFD72F0
        public void SetOverlayFlag(){} // RVA: 0x7ADFD8250
        public void GetOverlayFlag(){} // RVA: 0x7ADFD8280
        public void SetOverlayColor(){} // RVA: 0x7ADFD82B0
        public void GetOverlayColor(){} // RVA: 0x7ADFD82E0
        public void SetOverlayAlpha(){} // RVA: 0x7ADFD8320
        public void GetOverlayAlpha(){} // RVA: 0x7ADFD8350
        public void SetOverlayTexelAspect(){} // RVA: 0x7ADFD8380
        public void GetOverlayTexelAspect(){} // RVA: 0x7ADFD83B0
        public void SetOverlaySortOrder(){} // RVA: 0x7ADFD83E0
        public void GetOverlaySortOrder(){} // RVA: 0x7ADFD8410
        public void SetOverlayWidthInMeters(){} // RVA: 0x7ADFD8440
        public void GetOverlayWidthInMeters(){} // RVA: 0x7ADFD8470
        public void SetOverlayAutoCurveDistanceRangeInMeters(){} // RVA: 0x7ADFD84A0
        public void GetOverlayAutoCurveDistanceRangeInMeters(){} // RVA: 0x7ADFD84D0
        public void SetOverlayTextureColorSpace(){} // RVA: 0x7ADFD8510
        public void GetOverlayTextureColorSpace(){} // RVA: 0x7ADFD8540
        public void SetOverlayTextureBounds(){} // RVA: 0x7ADFD8570
        public void GetOverlayTextureBounds(){} // RVA: 0x7ADFD85A0
        public void GetOverlayRenderModel(){} // RVA: 0x7ADFD85D0
        public void SetOverlayRenderModel(){} // RVA: 0x7ADFD8610
        public void GetOverlayTransformType(){} // RVA: 0x7ADFD8640
        public void SetOverlayTransformAbsolute(){} // RVA: 0x7ADFD7CF0
        public void GetOverlayTransformAbsolute(){} // RVA: 0x7ADFD8670
        public void SetOverlayTransformTrackedDeviceRelative(){} // RVA: 0x7ADFD86A0
        public void GetOverlayTransformTrackedDeviceRelative(){} // RVA: 0x7ADFD86D0
        public void SetOverlayTransformTrackedDeviceComponent(){} // RVA: 0x7ADFD8710
        public void GetOverlayTransformTrackedDeviceComponent(){} // RVA: 0x7ADFD8740
        public void GetOverlayTransformOverlayRelative(){} // RVA: 0x7ADFD8780
        public void SetOverlayTransformOverlayRelative(){} // RVA: 0x7ADFD7E50
        public void ShowOverlay(){} // RVA: 0x7ADFD7E80
        public void HideOverlay(){} // RVA: 0x7ADFD87C0
        public void IsOverlayVisible(){} // RVA: 0x7ADFD87F0
        public void GetTransformForOverlayCoordinates(){} // RVA: 0x7ADFD8820
        public void PollNextOverlayEvent(){} // RVA: 0x7ADFD8850
        public void GetOverlayInputMethod(){} // RVA: 0x7ADFD8AD0
        public void SetOverlayInputMethod(){} // RVA: 0x7ADFD8B00
        public void GetOverlayMouseScale(){} // RVA: 0x7ADFD8B30
        public void SetOverlayMouseScale(){} // RVA: 0x7ADFD8B60
        public void ComputeOverlayIntersection(){} // RVA: 0x7ADFD8B90
        public void IsHoverTargetOverlay(){} // RVA: 0x7ADFD8BC0
        public void GetGamepadFocusOverlay(){} // RVA: 0x7ADFD8BF0
        public void SetGamepadFocusOverlay(){} // RVA: 0x7ADFD8C20
        public void SetOverlayNeighbor(){} // RVA: 0x7ADFD8C50
        public void MoveGamepadFocusToNeighbor(){} // RVA: 0x7ADFD8C80
        public void SetOverlayDualAnalogTransform(){} // RVA: 0x7ADFD8CB0
        public void GetOverlayDualAnalogTransform(){} // RVA: 0x7ADFD8CE0
        public void SetOverlayTexture(){} // RVA: 0x7ADFD8D20
        public void ClearOverlayTexture(){} // RVA: 0x7ADFD8D50
        public void SetOverlayRaw(){} // RVA: 0x7ADFD8D80
        public void SetOverlayFromFile(){} // RVA: 0x7ADFD8DC0
        public void GetOverlayTexture(){} // RVA: 0x7ADFD8DF0
        public void ReleaseNativeOverlayHandle(){} // RVA: 0x7ADFD8E50
        public void GetOverlayTextureSize(){} // RVA: 0x7ADFD8E80
        public void CreateDashboardOverlay(){} // RVA: 0x7ADFD8EC0
        public void IsDashboardVisible(){} // RVA: 0x7ADFD8F00
        public void IsActiveDashboardOverlay(){} // RVA: 0x7ADFD8F30
        public void SetDashboardOverlaySceneProcess(){} // RVA: 0x7ADFD8F60
        public void GetDashboardOverlaySceneProcess(){} // RVA: 0x7ADFD8F90
        public void ShowDashboard(){} // RVA: 0x7ADFD8FC0
        public void GetPrimaryDashboardDevice(){} // RVA: 0x7ADFD8FF0
        public void ShowKeyboard(){} // RVA: 0x7ADFD9020
        public void ShowKeyboardForOverlay(){} // RVA: 0x7ADFD9060
        public void GetKeyboardText(){} // RVA: 0x7ADFD90A0
        public void HideKeyboard(){} // RVA: 0x7ADFD90D0
        public void SetKeyboardTransformAbsolute(){} // RVA: 0x7ADFD9100
        public void SetKeyboardPositionForOverlay(){} // RVA: 0x7ADFD9130
        public void SetOverlayIntersectionMask(){} // RVA: 0x7ADFD9170
        public void GetOverlayFlags(){} // RVA: 0x7ADFD91A0
        public void ShowMessageOverlay(){} // RVA: 0x7ADFD91D0
        public void CloseMessageOverlay(){} // RVA: 0x7ADFD9210
    }

    public class CVRRenderModels : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADFD9310
        public void LoadRenderModel_Async(){} // RVA: 0x7ACF647F0
        public void FreeRenderModel(){} // RVA: 0x7A8743650
        public void LoadTexture_Async(){} // RVA: 0x7AD87A9A0
        public void FreeTexture(){} // RVA: 0x7AB121480
        public void LoadTextureD3D11_Async(){} // RVA: 0x7ADFD6740
        public void LoadIntoTextureD3D11_Async(){} // RVA: 0x7ADFD9500
        public void FreeTextureD3D11(){} // RVA: 0x7ADFD63D0
        public void GetRenderModelName(){} // RVA: 0x7ADFD9530
        public void GetRenderModelCount(){} // RVA: 0x7ADFD9560
        public void GetComponentCount(){} // RVA: 0x7ADFD6810
        public void GetComponentName(){} // RVA: 0x7ADFD9590
        public void GetComponentButtonMask(){} // RVA: 0x7ADFD64F0
        public void GetComponentRenderModelName(){} // RVA: 0x7ADFD95C0
        public void GetComponentStateForDevicePath(){} // RVA: 0x7ADFD95F0
        public void GetComponentState(){} // RVA: 0x7ADFD9620
        public void RenderModelHasComponent(){} // RVA: 0x7ADFD98B0
        public void GetRenderModelThumbnailURL(){} // RVA: 0x7ADFD98E0
        public void GetRenderModelOriginalPath(){} // RVA: 0x7ADFD9910
        public void GetRenderModelErrorNameFromEnum(){} // RVA: 0x7ADFD9940
    }

    public class CVRResources : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADFDA320
        public void LoadSharedResource(){} // RVA: 0x7ADFDA4A0
        public void GetResourceFullPath(){} // RVA: 0x7ADFDA4D0
    }

    public class CVRScreenshots : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADFDA060
        public void RequestScreenshot(){} // RVA: 0x7ADFDA210
        public void HookScreenshot(){} // RVA: 0x7ADFDA250
        public void GetScreenshotPropertyType(){} // RVA: 0x7AD87A9A0
        public void GetScreenshotPropertyFilename(){} // RVA: 0x7ADFDA280
        public void UpdateScreenshotProgress(){} // RVA: 0x7ADFDA2B0
        public void TakeStereoScreenshot(){} // RVA: 0x7ADFDA2E0
        public void SubmitScreenshot(){} // RVA: 0x7ADFD8140
    }

    public class CVRSettings : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADFD9CA0
        public void GetSettingsErrorNameFromEnum(){} // RVA: 0x7ADFD9E60
        public void Sync(){} // RVA: 0x7ADFD9F10
        public void SetBool(){} // RVA: 0x7ADFD9F40
        public void SetInt32(){} // RVA: 0x7ADFD6340
        public void SetFloat(){} // RVA: 0x7ADFD9F70
        public void SetString(){} // RVA: 0x7ADFD78A0
        public void GetBool(){} // RVA: 0x7ADFD9FA0
        public void GetInt32(){} // RVA: 0x7ADFD9530
        public void GetFloat(){} // RVA: 0x7ADFD9FD0
        public void GetString(){} // RVA: 0x7ADFDA000
        public void RemoveSection(){} // RVA: 0x7ADFD8220
        public void RemoveKeyInSection(){} // RVA: 0x7ADFDA030
    }

    public class CVRSpatialAnchors : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADFDADD0
        public void CreateSpatialAnchorFromDescriptor(){} // RVA: 0x7ADFDAF60
        public void CreateSpatialAnchorFromPose(){} // RVA: 0x7ADFDAF90
        public void GetSpatialAnchorPose(){} // RVA: 0x7ADFDAFD0
        public void GetSpatialAnchorDescriptor(){} // RVA: 0x7ADFDB000
    }

    public class CVRSystem : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADFD4580
        public void GetRecommendedRenderTargetSize(){} // RVA: 0x7ADFD47B0
        public void GetProjectionMatrix(){} // RVA: 0x7ADFD47E0
        public void GetProjectionRaw(){} // RVA: 0x7ADFD4850
        public void ComputeDistortion(){} // RVA: 0x7ADFD48A0
        public void GetEyeToHeadTransform(){} // RVA: 0x7ADFD48D0
        public void GetTimeSinceLastVsync(){} // RVA: 0x7ADFD4920
        public void GetD3D9AdapterIndex(){} // RVA: 0x7ADFD4950
        public void GetDXGIOutputInfo(){} // RVA: 0x7ADFD4980
        public void GetOutputDevice(){} // RVA: 0x7ADFD49B0
        public void IsDisplayOnDesktop(){} // RVA: 0x7ADFD49F0
        public void SetDisplayVisibility(){} // RVA: 0x7ACF04BB0
        public void GetDeviceToAbsoluteTrackingPose(){} // RVA: 0x7ADFD4A20
        public void ResetSeatedZeroPose(){} // RVA: 0x7ADFD4A60
        public void GetSeatedZeroPoseToStandingAbsoluteTrackingPose(){} // RVA: 0x7ADFD4A90
        public void GetRawZeroPoseToStandingAbsoluteTrackingPose(){} // RVA: 0x7ADFD4AE0
        public void GetSortedTrackedDeviceIndicesOfClass(){} // RVA: 0x7ADFD4B30
        public void GetTrackedDeviceActivityLevel(){} // RVA: 0x7ADFD4B70
        public void ApplyTransform(){} // RVA: 0x7ADFD4BA0
        public void GetTrackedDeviceIndexForControllerRole(){} // RVA: 0x7ADFD4BD0
        public void GetControllerRoleForTrackedDeviceIndex(){} // RVA: 0x7ADFD4C00
        public void GetTrackedDeviceClass(){} // RVA: 0x7ADFD4C30
        public void IsTrackedDeviceConnected(){} // RVA: 0x7ADFD4C60
        public void GetBoolTrackedDeviceProperty(){} // RVA: 0x7ADFD4C90
        public void GetFloatTrackedDeviceProperty(){} // RVA: 0x7ADFD4CC0
        public void GetInt32TrackedDeviceProperty(){} // RVA: 0x7ADFD4CF0
        public void GetUint64TrackedDeviceProperty(){} // RVA: 0x7ADFD4D20
        public void GetMatrix34TrackedDeviceProperty(){} // RVA: 0x7ADFD4D50
        public void GetArrayTrackedDeviceProperty(){} // RVA: 0x7ADFD4DB0
        public void GetStringTrackedDeviceProperty(){} // RVA: 0x7ADFD4DF0
        public void GetPropErrorNameFromEnum(){} // RVA: 0x7ADFD4E30
        public void PollNextEvent(){} // RVA: 0x7ADFD4EE0
        public void PollNextEventWithPose(){} // RVA: 0x7ADFD5140
        public void GetEventTypeNameFromEnum(){} // RVA: 0x7ADFD5170
        public void GetHiddenAreaMesh(){} // RVA: 0x7ADFD5220
        public void GetControllerState(){} // RVA: 0x7ADFD5270
        public void GetControllerStateWithPose(){} // RVA: 0x7ADFD5560
        public void TriggerHapticPulse(){} // RVA: 0x7ADFD5870
        public void GetButtonIdNameFromEnum(){} // RVA: 0x7ADFD58A0
        public void GetControllerAxisTypeNameFromEnum(){} // RVA: 0x7ADFD5950
        public void IsInputAvailable(){} // RVA: 0x7ADFD5A00
        public void IsSteamVRDrawingControllers(){} // RVA: 0x7ADFD5A30
        public void ShouldApplicationPause(){} // RVA: 0x7ADFD5A60
        public void ShouldApplicationReduceRenderingWork(){} // RVA: 0x7ADFD5A90
        public void DriverDebugRequest(){} // RVA: 0x7ADFD5AC0
        public void PerformFirmwareUpdate(){} // RVA: 0x7ADFD5AF0
        public void AcknowledgeQuit_Exiting(){} // RVA: 0x7ADFD5B20
        public void AcknowledgeQuit_UserPrompt(){} // RVA: 0x7ADFD5B50
    }

    public class CVRTrackedCamera : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADFD6050
        public void GetCameraErrorNameFromEnum(){} // RVA: 0x7ADFD6210
        public void HasCamera(){} // RVA: 0x7ADFD62C0
        public void GetCameraFrameSize(){} // RVA: 0x7ADFD62F0
        public void GetCameraIntrinsics(){} // RVA: 0x7ADFD6340
        public void GetCameraProjection(){} // RVA: 0x7ADFD6370
        public void AcquireVideoStreamingService(){} // RVA: 0x7ADFD63A0
        public void ReleaseVideoStreamingService(){} // RVA: 0x7ADFD63D0
        public void GetVideoStreamFrameBuffer(){} // RVA: 0x7ADFD6400
        public void GetVideoStreamTextureSize(){} // RVA: 0x7ADFD6430
        public void GetVideoStreamTextureD3D11(){} // RVA: 0x7ADFD6480
        public void GetVideoStreamTextureGL(){} // RVA: 0x7ADFD64B0
        public void ReleaseVideoStreamTextureGL(){} // RVA: 0x7ADFD64F0
    }

    public class InputOriginInfo_t : ValueType
    {
        // ── Methods ──
        public void get_rchRenderModelComponentName(){} // RVA: 0x7A7E64CC0
    }

    public class OpenVR : Object
    {
        // ── Methods ──
        public void InitInternal(){} // RVA: 0x7ADFDB040
        public void InitInternal2(){} // RVA: 0x7ADFDB080
        public void ShutdownInternal(){} // RVA: 0x7ADFDB100
        public void IsHmdPresent(){} // RVA: 0x7ADFDB130
        public void IsRuntimeInstalled(){} // RVA: 0x7ADFDB160
        public void GetStringForHmdError(){} // RVA: 0x7ADFDBE10
        public void GetGenericInterface(){} // RVA: 0x7ADFDB1C0
        public void IsInterfaceVersionValid(){} // RVA: 0x7ADFDB220
        public void GetInitToken(){} // RVA: 0x7ADFDB280
        public void get_VRToken(){} // RVA: 0x7ADFDBEA0
        public void set_VRToken(){} // RVA: 0x7ADFDBEE0
        public void get_OpenVRInternal_ModuleContext(){} // RVA: 0x7ADFDBF20
        public void get_System(){} // RVA: 0x7ADFDC020
        public void get_Chaperone(){} // RVA: 0x7ADFDC050
        public void get_ChaperoneSetup(){} // RVA: 0x7ADFDC080
        public void get_Compositor(){} // RVA: 0x7ADFDC0B0
        public void get_Overlay(){} // RVA: 0x7ADFDC0E0
        public void get_RenderModels(){} // RVA: 0x7ADFDC110
        public void get_ExtendedDisplay(){} // RVA: 0x7ADFDC140
        public void get_Settings(){} // RVA: 0x7ADFDC170
        public void get_Applications(){} // RVA: 0x7ADFDC1A0
        public void get_Screenshots(){} // RVA: 0x7ADFDC1D0
        public void get_TrackedCamera(){} // RVA: 0x7ADFDC200
        public void get_Input(){} // RVA: 0x7ADFDC230
        public void get_SpatialAnchors(){} // RVA: 0x7ADFDC260
        public void Init(){} // RVA: 0x7ADFDC290
        public void Shutdown(){} // RVA: 0x7ADFDB100
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class OpenVRInterop : Object
    {
        // ── Methods ──
        public void InitInternal(){} // RVA: 0x7ADFDB040
        public void InitInternal2(){} // RVA: 0x7ADFDB080
        public void ShutdownInternal(){} // RVA: 0x7ADFDB100
        public void IsHmdPresent(){} // RVA: 0x7ADFDB130
        public void IsRuntimeInstalled(){} // RVA: 0x7ADFDB160
        public void GetStringForHmdError(){} // RVA: 0x7ADFDB190
        public void GetGenericInterface(){} // RVA: 0x7ADFDB1C0
        public void IsInterfaceVersionValid(){} // RVA: 0x7ADFDB220
        public void GetInitToken(){} // RVA: 0x7ADFDB280
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class RenderModel_TextureMap_t_Packed : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E64C10
        public void Unpack(){} // RVA: 0x7A7E64C30
    }

    public class RenderModel_t_Packed : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E64C50
        public void Unpack(){} // RVA: 0x7A7E64C90
    }

    public class VRControllerState_t_Packed : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E64AF0
        public void Unpack(){} // RVA: 0x7A7E64B90
    }

    public class VREvent_Keyboard_t : ValueType
    {
        // ── Methods ──
        public void get_cNewInput(){} // RVA: 0x7A7E64940
    }

    public class VREvent_t_Packed : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E64A80
        public void Unpack(){} // RVA: 0x7A7E64AC0
    }

}