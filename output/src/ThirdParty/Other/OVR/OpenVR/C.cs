// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.OVR.OpenVR
// Classes: 23
// Methods: 335

namespace ThirdParty.Other.OVR.OpenVR
{
    public class COpenVRContext
    {
    }

    public class CVRApplications
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8C996E0
        public void AddApplicationManifest(){} // RVA: 0x7FFAF7DDB9F0
        public void RemoveApplicationManifest(){} // RVA: 0x7FFAF3459580
        public void IsApplicationInstalled(){} // RVA: 0x7FFAF66A7390
        public void GetApplicationCount(){} // RVA: 0x7FFAF66E6B00
        public void GetApplicationKeyByIndex(){} // RVA: 0x7FFAF8C99900
        public void GetApplicationKeyByProcessId(){} // RVA: 0x7FFAF8C99930
        public void LaunchApplication(){} // RVA: 0x7FFAF8C99590
        public void LaunchTemplateApplication(){} // RVA: 0x7FFAF8C99960
        public void LaunchApplicationFromMimeType(){} // RVA: 0x7FFAF8C999A0
        public void LaunchDashboardOverlay(){} // RVA: 0x7FFAF8C999D0
        public void CancelApplicationLaunch(){} // RVA: 0x7FFAF7974D80
        public void IdentifyApplication(){} // RVA: 0x7FFAF8C996B0
        public void GetApplicationProcessId(){} // RVA: 0x7FFAF8C99A00
        public void GetApplicationsErrorNameFromEnum(){} // RVA: 0x7FFAF8C99A30
        public void GetApplicationPropertyString(){} // RVA: 0x7FFAF8C99AE0
        public void GetApplicationPropertyBool(){} // RVA: 0x7FFAF8C99B20
        public void GetApplicationPropertyUint64(){} // RVA: 0x7FFAF8C99B50
        public void SetApplicationAutoLaunch(){} // RVA: 0x7FFAF8C99B80
        public void GetApplicationAutoLaunch(){} // RVA: 0x7FFAF8C97DD0
        public void SetDefaultApplicationForMimeType(){} // RVA: 0x7FFAF8C99BB0
        public void GetDefaultApplicationForMimeType(){} // RVA: 0x7FFAF8C99BE0
        public void GetApplicationSupportedMimeTypes(){} // RVA: 0x7FFAF8C99C10
        public void GetApplicationsThatSupportMimeType(){} // RVA: 0x7FFAF8C97E90
        public void GetApplicationLaunchArguments(){} // RVA: 0x7FFAF8C97EC0
        public void GetStartingApplication(){} // RVA: 0x7FFAF8C99C40
        public void GetTransitionState(){} // RVA: 0x7FFAF8C99C70
        public void PerformApplicationPrelaunchCheck(){} // RVA: 0x7FFAF8C99CA0
        public void GetApplicationsTransitionStateNameFromEnum(){} // RVA: 0x7FFAF8C99CD0
        public void IsQuitUserPromptRequested(){} // RVA: 0x7FFAF8C99D80
        public void LaunchInternalProcess(){} // RVA: 0x7FFAF8C99DB0
        public void GetCurrentSceneProcessId(){} // RVA: 0x7FFAF8C99DE0
    }

    public class CVRChaperone
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8C99E10
        public void GetCalibrationState(){} // RVA: 0x7FFAF3D31E30
        public void GetPlayAreaSize(){} // RVA: 0x7FFAF8C99FB0
        public void GetPlayAreaRect(){} // RVA: 0x7FFAF66A7390
        public void ReloadInfo(){} // RVA: 0x7FFAF66E6B00
        public void SetSceneColor(){} // RVA: 0x7FFAF8C99FE0
        public void GetBoundsColor(){} // RVA: 0x7FFAF8C9A020
        public void AreBoundsVisible(){} // RVA: 0x7FFAF8C97B50
        public void ForceBoundsVisible(){} // RVA: 0x7FFAF8C9A050
    }

    public class CVRChaperoneSetup
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8C9A080
        public void CommitWorkingCopy(){} // RVA: 0x7FFAF533D780
        public void RevertWorkingCopy(){} // RVA: 0x7FFAF6841AE0
        public void GetWorkingPlayAreaSize(){} // RVA: 0x7FFAF8C9A270
        public void GetWorkingPlayAreaRect(){} // RVA: 0x7FFAF5DD9C00
        public void GetWorkingCollisionBoundsInfo(){} // RVA: 0x7FFAF8C9A2A0
        public void GetLiveCollisionBoundsInfo(){} // RVA: 0x7FFAF8C9A390
        public void GetWorkingSeatedZeroPoseToRawTrackingPose(){} // RVA: 0x7FFAF8C99590
        public void GetWorkingStandingZeroPoseToRawTrackingPose(){} // RVA: 0x7FFAF8C9A050
        public void SetWorkingPlayAreaSize(){} // RVA: 0x7FFAF8C999A0
        public void SetWorkingCollisionBoundsInfo(){} // RVA: 0x7FFAF8C9A480
        public void SetWorkingSeatedZeroPoseToRawTrackingPose(){} // RVA: 0x7FFAF7974D80
        public void SetWorkingStandingZeroPoseToRawTrackingPose(){} // RVA: 0x7FFAF8C9A4B0
        public void ReloadFromDisk(){} // RVA: 0x7FFAF8C99A00
        public void GetLiveSeatedZeroPoseToRawTrackingPose(){} // RVA: 0x7FFAF8C9A4E0
        public void SetWorkingCollisionBoundsTagsInfo(){} // RVA: 0x7FFAF8C9A510
        public void GetLiveCollisionBoundsTagsInfo(){} // RVA: 0x7FFAF8C9A550
        public void SetWorkingPhysicalBoundsInfo(){} // RVA: 0x7FFAF8C9A640
        public void GetLivePhysicalBoundsInfo(){} // RVA: 0x7FFAF8C9A680
        public void ExportLiveToBuffer(){} // RVA: 0x7FFAF8C9A770
        public void ImportFromBufferToWorking(){} // RVA: 0x7FFAF8C99BB0
    }

    public class CVRCompositor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8C9A7A0
        public void SetTrackingSpace(){} // RVA: 0x7FFAF533D780
        public void GetTrackingSpace(){} // RVA: 0x7FFAF6841AE0
        public void WaitGetPoses(){} // RVA: 0x7FFAF8C9A9C0
        public void GetLastPoses(){} // RVA: 0x7FFAF8C9AA10
        public void GetLastPoseForTrackedDeviceIndex(){} // RVA: 0x7FFAF8C99900
        public void Submit(){} // RVA: 0x7FFAF8C9AA60
        public void ClearLastSubmittedFrame(){} // RVA: 0x7FFAF8C97B50
        public void PostPresentHandoff(){} // RVA: 0x7FFAF8C9AA90
        public void GetFrameTiming(){} // RVA: 0x7FFAF8C999A0
        public void GetFrameTimings(){} // RVA: 0x7FFAF8C9AAC0
        public void GetFrameTimeRemaining(){} // RVA: 0x7FFAF8C9AAF0
        public void GetCumulativeStats(){} // RVA: 0x7FFAF8C996B0
        public void FadeToColor(){} // RVA: 0x7FFAF8C9AB20
        public void GetCurrentFadeColor(){} // RVA: 0x7FFAF8C9AB70
        public void FadeGrid(){} // RVA: 0x7FFAF8C9ABB0
        public void GetCurrentGridAlpha(){} // RVA: 0x7FFAF8C9ABE0
        public void SetSkyboxOverride(){} // RVA: 0x7FFAF8C9A640
        public void ClearSkyboxOverride(){} // RVA: 0x7FFAF8C9AC10
        public void CompositorBringToFront(){} // RVA: 0x7FFAF8C9AC40
        public void CompositorGoToBack(){} // RVA: 0x7FFAF8C9AC70
        public void CompositorQuit(){} // RVA: 0x7FFAF8C9ACA0
        public void IsFullscreen(){} // RVA: 0x7FFAF8C9ACD0
        public void GetCurrentSceneFocusProcess(){} // RVA: 0x7FFAF8C9AD00
        public void GetLastFrameRenderer(){} // RVA: 0x7FFAF8C9AD30
        public void CanRenderScene(){} // RVA: 0x7FFAF8C9AD60
        public void ShowMirrorWindow(){} // RVA: 0x7FFAF8C99C70
        public void HideMirrorWindow(){} // RVA: 0x7FFAF8C9AD90
        public void IsMirrorWindowVisible(){} // RVA: 0x7FFAF8C9ADC0
        public void CompositorDumpImages(){} // RVA: 0x7FFAF8C99D80
        public void ShouldAppRenderWithLowResources(){} // RVA: 0x7FFAF8C9ADF0
        public void ForceInterleavedReprojectionOn(){} // RVA: 0x7FFAF8C9AE20
        public void ForceReconnectProcess(){} // RVA: 0x7FFAF8C9AE50
        public void SuspendRendering(){} // RVA: 0x7FFAF8C9AE80
        public void GetMirrorTextureD3D11(){} // RVA: 0x7FFAF8C9AEB0
        public void ReleaseMirrorTextureD3D11(){} // RVA: 0x7FFAF8C9AEE0
        public void GetMirrorTextureGL(){} // RVA: 0x7FFAF8C9AF10
        public void ReleaseSharedGLTexture(){} // RVA: 0x7FFAF8C9AF50
        public void LockGLSharedTextureForAccess(){} // RVA: 0x7FFAF8C9AF80
        public void UnlockGLSharedTextureForAccess(){} // RVA: 0x7FFAF8C9AFB0
        public void GetVulkanInstanceExtensionsRequired(){} // RVA: 0x7FFAF8C9AFE0
        public void GetVulkanDeviceExtensionsRequired(){} // RVA: 0x7FFAF8C9B010
        public void SetExplicitTimingMode(){} // RVA: 0x7FFAF8C9B040
        public void SubmitExplicitTimingData(){} // RVA: 0x7FFAF8C98C40
    }

    public class CVRDriverManager
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8C9D6A0
        public void GetDriverCount(){} // RVA: 0x7FFAF3D31E30
        public void GetDriverName(){} // RVA: 0x7FFAF8C9D840
        public void GetDriverHandle(){} // RVA: 0x7FFAF66A7390
    }

    public class CVRExtendedDisplay
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8C98FB0
        public void GetWindowBounds(){} // RVA: 0x7FFAF8C99150
        public void GetEyeOutputViewport(){} // RVA: 0x7FFAF8C99190
        public void GetDXGIOutputInfo(){} // RVA: 0x7FFAF8C991E0
    }

    public class CVRIOBuffer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8C9DD50
        public void Open(){} // RVA: 0x7FFAF8C9DEF0
        public void Close(){} // RVA: 0x7FFAF3459580
        public void Read(){} // RVA: 0x7FFAF8C9DF30
        public void Write(){} // RVA: 0x7FFAF8C9DF70
        public void PropertyContainer(){} // RVA: 0x7FFAF853DBC0
    }

    public class CVRInput
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8C9D870
        public void SetActionManifestPath(){} // RVA: 0x7FFAF533D780
        public void GetActionSetHandle(){} // RVA: 0x7FFAF8C9DA50
        public void GetActionHandle(){} // RVA: 0x7FFAF8C9DA80
        public void GetInputSourceHandle(){} // RVA: 0x7FFAF8C9DAB0
        public void UpdateActionState(){} // RVA: 0x7FFAF8C9DAE0
        public void GetDigitalActionData(){} // RVA: 0x7FFAF8C9AA60
        public void GetAnalogActionData(){} // RVA: 0x7FFAF8C9B300
        public void GetPoseActionData(){} // RVA: 0x7FFAF8C9DB20
        public void GetSkeletalActionData(){} // RVA: 0x7FFAF8C9DB50
        public void GetSkeletalBoneData(){} // RVA: 0x7FFAF8C9DB80
        public void GetSkeletalBoneDataCompressed(){} // RVA: 0x7FFAF8C9DBE0
        public void DecompressSkeletalBoneData(){} // RVA: 0x7FFAF8C9DC20
        public void TriggerHapticVibrationAction(){} // RVA: 0x7FFAF8C9DC70
        public void GetActionOrigins(){} // RVA: 0x7FFAF8C9DCA0
        public void GetOriginLocalizedName(){} // RVA: 0x7FFAF8C9DCE0
        public void GetOriginTrackedDeviceInfo(){} // RVA: 0x7FFAF8C99B20
        public void ShowActionOrigins(){} // RVA: 0x7FFAF8C9B4E0
        public void ShowBindingsForActionSet(){} // RVA: 0x7FFAF8C9DD10
    }

    public class CVRNotifications
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8C9CC60
        public void CreateNotification(){} // RVA: 0x7FFAF8C9CDF0
        public void RemoveNotification(){} // RVA: 0x7FFAF3459580
    }

    public class CVROverlay
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8C9B070
        public void FindOverlay(){} // RVA: 0x7FFAF8C9B260
        public void CreateOverlay(){} // RVA: 0x7FFAF8C9B290
        public void DestroyOverlay(){} // RVA: 0x7FFAF66A7390
        public void SetHighQualityOverlay(){} // RVA: 0x7FFAF5DD9C00
        public void GetHighQualityOverlay(){} // RVA: 0x7FFAF8C9B2D0
        public void GetOverlayKey(){} // RVA: 0x7FFAF8C9AA60
        public void GetOverlayName(){} // RVA: 0x7FFAF8C9B300
        public void SetOverlayName(){} // RVA: 0x7FFAF7974C40
        public void GetOverlayImageData(){} // RVA: 0x7FFAF8C995F0
        public void GetOverlayErrorNameFromEnum(){} // RVA: 0x7FFAF8C9B330
        public void SetOverlayRenderingPid(){} // RVA: 0x7FFAF8C9B3E0
        public void GetOverlayRenderingPid(){} // RVA: 0x7FFAF8C9A4B0
        public void SetOverlayFlag(){} // RVA: 0x7FFAF8C9B410
        public void GetOverlayFlag(){} // RVA: 0x7FFAF8C9B440
        public void SetOverlayColor(){} // RVA: 0x7FFAF8C9B470
        public void GetOverlayColor(){} // RVA: 0x7FFAF8C9B4A0
        public void SetOverlayAlpha(){} // RVA: 0x7FFAF8C9B4E0
        public void GetOverlayAlpha(){} // RVA: 0x7FFAF8C9B510
        public void SetOverlayTexelAspect(){} // RVA: 0x7FFAF8C9B540
        public void GetOverlayTexelAspect(){} // RVA: 0x7FFAF8C9B570
        public void SetOverlaySortOrder(){} // RVA: 0x7FFAF8C9B5A0
        public void GetOverlaySortOrder(){} // RVA: 0x7FFAF8C9B5D0
        public void SetOverlayWidthInMeters(){} // RVA: 0x7FFAF8C9B600
        public void GetOverlayWidthInMeters(){} // RVA: 0x7FFAF8C9B630
        public void SetOverlayAutoCurveDistanceRangeInMeters(){} // RVA: 0x7FFAF8C9B660
        public void GetOverlayAutoCurveDistanceRangeInMeters(){} // RVA: 0x7FFAF8C9B690
        public void SetOverlayTextureColorSpace(){} // RVA: 0x7FFAF8C9B6D0
        public void GetOverlayTextureColorSpace(){} // RVA: 0x7FFAF8C9B700
        public void SetOverlayTextureBounds(){} // RVA: 0x7FFAF8C9B730
        public void GetOverlayTextureBounds(){} // RVA: 0x7FFAF8C9B760
        public void GetOverlayRenderModel(){} // RVA: 0x7FFAF8C9B790
        public void SetOverlayRenderModel(){} // RVA: 0x7FFAF8C9B7D0
        public void GetOverlayTransformType(){} // RVA: 0x7FFAF8C9B800
        public void SetOverlayTransformAbsolute(){} // RVA: 0x7FFAF8C9AEB0
        public void GetOverlayTransformAbsolute(){} // RVA: 0x7FFAF8C9B830
        public void SetOverlayTransformTrackedDeviceRelative(){} // RVA: 0x7FFAF8C9B860
        public void GetOverlayTransformTrackedDeviceRelative(){} // RVA: 0x7FFAF8C9B890
        public void SetOverlayTransformTrackedDeviceComponent(){} // RVA: 0x7FFAF8C9B8D0
        public void GetOverlayTransformTrackedDeviceComponent(){} // RVA: 0x7FFAF8C9B900
        public void GetOverlayTransformOverlayRelative(){} // RVA: 0x7FFAF8C9B940
        public void SetOverlayTransformOverlayRelative(){} // RVA: 0x7FFAF8C9B010
        public void ShowOverlay(){} // RVA: 0x7FFAF8C9B040
        public void HideOverlay(){} // RVA: 0x7FFAF8C9B980
        public void IsOverlayVisible(){} // RVA: 0x7FFAF8C9B9B0
        public void GetTransformForOverlayCoordinates(){} // RVA: 0x7FFAF8C9B9E0
        public void PollNextOverlayEvent(){} // RVA: 0x7FFAF8C9BA10
        public void GetOverlayInputMethod(){} // RVA: 0x7FFAF8C9BC70
        public void SetOverlayInputMethod(){} // RVA: 0x7FFAF8C9BCA0
        public void GetOverlayMouseScale(){} // RVA: 0x7FFAF8C9BCD0
        public void SetOverlayMouseScale(){} // RVA: 0x7FFAF8C9BD00
        public void ComputeOverlayIntersection(){} // RVA: 0x7FFAF8C9BD30
        public void IsHoverTargetOverlay(){} // RVA: 0x7FFAF8C9BD60
        public void GetGamepadFocusOverlay(){} // RVA: 0x7FFAF8C9BD90
        public void SetGamepadFocusOverlay(){} // RVA: 0x7FFAF8C9BDC0
        public void SetOverlayNeighbor(){} // RVA: 0x7FFAF8C9BDF0
        public void MoveGamepadFocusToNeighbor(){} // RVA: 0x7FFAF8C9BE20
        public void SetOverlayDualAnalogTransform(){} // RVA: 0x7FFAF8C9BE50
        public void GetOverlayDualAnalogTransform(){} // RVA: 0x7FFAF8C9BE80
        public void SetOverlayTexture(){} // RVA: 0x7FFAF8C9BEC0
        public void ClearOverlayTexture(){} // RVA: 0x7FFAF8C9BEF0
        public void SetOverlayRaw(){} // RVA: 0x7FFAF8C9BF20
        public void SetOverlayFromFile(){} // RVA: 0x7FFAF8C9BF60
        public void GetOverlayTexture(){} // RVA: 0x7FFAF8C9BF90
        public void ReleaseNativeOverlayHandle(){} // RVA: 0x7FFAF8C9BFF0
        public void GetOverlayTextureSize(){} // RVA: 0x7FFAF8C9C020
        public void CreateDashboardOverlay(){} // RVA: 0x7FFAF8C9C060
        public void IsDashboardVisible(){} // RVA: 0x7FFAF8C9C0A0
        public void IsActiveDashboardOverlay(){} // RVA: 0x7FFAF8C9C0D0
        public void SetDashboardOverlaySceneProcess(){} // RVA: 0x7FFAF8C9C100
        public void GetDashboardOverlaySceneProcess(){} // RVA: 0x7FFAF8C9C130
        public void ShowDashboard(){} // RVA: 0x7FFAF8C9C160
        public void GetPrimaryDashboardDevice(){} // RVA: 0x7FFAF8C9C190
        public void ShowKeyboard(){} // RVA: 0x7FFAF8C9C1C0
        public void ShowKeyboardForOverlay(){} // RVA: 0x7FFAF8C9C200
        public void GetKeyboardText(){} // RVA: 0x7FFAF8C9C240
        public void HideKeyboard(){} // RVA: 0x7FFAF8C9C270
        public void SetKeyboardTransformAbsolute(){} // RVA: 0x7FFAF8C9C2A0
        public void SetKeyboardPositionForOverlay(){} // RVA: 0x7FFAF8C9C2D0
        public void SetOverlayIntersectionMask(){} // RVA: 0x7FFAF8C9C310
        public void GetOverlayFlags(){} // RVA: 0x7FFAF8C9C340
        public void ShowMessageOverlay(){} // RVA: 0x7FFAF8C9C370
        public void CloseMessageOverlay(){} // RVA: 0x7FFAF8C9C3B0
    }

    public class CVRRenderModels
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8C9C4B0
        public void LoadRenderModel_Async(){} // RVA: 0x7FFAF7DDB9F0
        public void FreeRenderModel(){} // RVA: 0x7FFAF3459580
        public void LoadTexture_Async(){} // RVA: 0x7FFAF853DBF0
        public void FreeTexture(){} // RVA: 0x7FFAF5DD9C00
        public void LoadTextureD3D11_Async(){} // RVA: 0x7FFAF8C99900
        public void LoadIntoTextureD3D11_Async(){} // RVA: 0x7FFAF8C9C6A0
        public void FreeTextureD3D11(){} // RVA: 0x7FFAF8C99590
        public void GetRenderModelName(){} // RVA: 0x7FFAF8C9C6D0
        public void GetRenderModelCount(){} // RVA: 0x7FFAF8C9C700
        public void GetComponentCount(){} // RVA: 0x7FFAF8C999D0
        public void GetComponentName(){} // RVA: 0x7FFAF8C9C730
        public void GetComponentButtonMask(){} // RVA: 0x7FFAF8C996B0
        public void GetComponentRenderModelName(){} // RVA: 0x7FFAF8C9C760
        public void GetComponentStateForDevicePath(){} // RVA: 0x7FFAF8C9C790
        public void GetComponentState(){} // RVA: 0x7FFAF8C9C7C0
        public void RenderModelHasComponent(){} // RVA: 0x7FFAF8C9CA30
        public void GetRenderModelThumbnailURL(){} // RVA: 0x7FFAF8C9CA60
        public void GetRenderModelOriginalPath(){} // RVA: 0x7FFAF8C9CA90
        public void GetRenderModelErrorNameFromEnum(){} // RVA: 0x7FFAF8C9CAC0
    }

    public class CVRResources
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8C9D4B0
        public void LoadSharedResource(){} // RVA: 0x7FFAF8C9D640
        public void GetResourceFullPath(){} // RVA: 0x7FFAF8C9D670
    }

    public class CVRScreenshots
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8C9D1F0
        public void RequestScreenshot(){} // RVA: 0x7FFAF8C9D3A0
        public void HookScreenshot(){} // RVA: 0x7FFAF8C9D3E0
        public void GetScreenshotPropertyType(){} // RVA: 0x7FFAF853DBF0
        public void GetScreenshotPropertyFilename(){} // RVA: 0x7FFAF8C9D410
        public void UpdateScreenshotProgress(){} // RVA: 0x7FFAF8C9D440
        public void TakeStereoScreenshot(){} // RVA: 0x7FFAF8C9D470
        public void SubmitScreenshot(){} // RVA: 0x7FFAF8C9B300
    }

    public class CVRSettingHelper
    {
    }

    public class CVRSettings
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8C9CE30
        public void GetSettingsErrorNameFromEnum(){} // RVA: 0x7FFAF8C9CFF0
        public void Sync(){} // RVA: 0x7FFAF8C9D0A0
        public void SetBool(){} // RVA: 0x7FFAF8C9D0D0
        public void SetInt32(){} // RVA: 0x7FFAF8C99500
        public void SetFloat(){} // RVA: 0x7FFAF8C9D100
        public void SetString(){} // RVA: 0x7FFAF8C9AA60
        public void GetBool(){} // RVA: 0x7FFAF8C9D130
        public void GetInt32(){} // RVA: 0x7FFAF8C9C6D0
        public void GetFloat(){} // RVA: 0x7FFAF8C9D160
        public void GetString(){} // RVA: 0x7FFAF8C9D190
        public void RemoveSection(){} // RVA: 0x7FFAF8C9B3E0
        public void RemoveKeyInSection(){} // RVA: 0x7FFAF8C9D1C0
    }

    public class CVRSpatialAnchors
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8C9DFA0
        public void CreateSpatialAnchorFromDescriptor(){} // RVA: 0x7FFAF8C9E130
        public void CreateSpatialAnchorFromPose(){} // RVA: 0x7FFAF8C9E160
        public void GetSpatialAnchorPose(){} // RVA: 0x7FFAF8C9E1A0
        public void GetSpatialAnchorDescriptor(){} // RVA: 0x7FFAF8C9E1D0
    }

    public class CVRSystem
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8C97780
        public void GetRecommendedRenderTargetSize(){} // RVA: 0x7FFAF8C979B0
        public void GetProjectionMatrix(){} // RVA: 0x7FFAF8C979E0
        public void GetProjectionRaw(){} // RVA: 0x7FFAF8C97A50
        public void ComputeDistortion(){} // RVA: 0x7FFAF8C97AA0
        public void GetEyeToHeadTransform(){} // RVA: 0x7FFAF8C97AD0
        public void GetTimeSinceLastVsync(){} // RVA: 0x7FFAF8C97B20
        public void GetD3D9AdapterIndex(){} // RVA: 0x7FFAF8C97B50
        public void GetDXGIOutputInfo(){} // RVA: 0x7FFAF8C97B80
        public void GetOutputDevice(){} // RVA: 0x7FFAF8C97BB0
        public void IsDisplayOnDesktop(){} // RVA: 0x7FFAF8C97BF0
        public void SetDisplayVisibility(){} // RVA: 0x7FFAF7974D80
        public void GetDeviceToAbsoluteTrackingPose(){} // RVA: 0x7FFAF8C97C20
        public void ResetSeatedZeroPose(){} // RVA: 0x7FFAF8C97C60
        public void GetSeatedZeroPoseToStandingAbsoluteTrackingPose(){} // RVA: 0x7FFAF8C97C90
        public void GetRawZeroPoseToStandingAbsoluteTrackingPose(){} // RVA: 0x7FFAF8C97CE0
        public void GetSortedTrackedDeviceIndicesOfClass(){} // RVA: 0x7FFAF8C97D30
        public void GetTrackedDeviceActivityLevel(){} // RVA: 0x7FFAF8C97D70
        public void ApplyTransform(){} // RVA: 0x7FFAF8C97DA0
        public void GetTrackedDeviceIndexForControllerRole(){} // RVA: 0x7FFAF8C97DD0
        public void GetControllerRoleForTrackedDeviceIndex(){} // RVA: 0x7FFAF8C97E00
        public void GetTrackedDeviceClass(){} // RVA: 0x7FFAF8C97E30
        public void IsTrackedDeviceConnected(){} // RVA: 0x7FFAF8C97E60
        public void GetBoolTrackedDeviceProperty(){} // RVA: 0x7FFAF8C97E90
        public void GetFloatTrackedDeviceProperty(){} // RVA: 0x7FFAF8C97EC0
        public void GetInt32TrackedDeviceProperty(){} // RVA: 0x7FFAF8C97EF0
        public void GetUint64TrackedDeviceProperty(){} // RVA: 0x7FFAF8C97F20
        public void GetMatrix34TrackedDeviceProperty(){} // RVA: 0x7FFAF8C97F50
        public void GetArrayTrackedDeviceProperty(){} // RVA: 0x7FFAF8C97FB0
        public void GetStringTrackedDeviceProperty(){} // RVA: 0x7FFAF8C97FF0
        public void GetPropErrorNameFromEnum(){} // RVA: 0x7FFAF8C98030
        public void PollNextEvent(){} // RVA: 0x7FFAF8C980E0
        public void PollNextEventWithPose(){} // RVA: 0x7FFAF8C98320
        public void GetEventTypeNameFromEnum(){} // RVA: 0x7FFAF8C98350
        public void GetHiddenAreaMesh(){} // RVA: 0x7FFAF8C98400
        public void GetControllerState(){} // RVA: 0x7FFAF8C98450
        public void GetControllerStateWithPose(){} // RVA: 0x7FFAF8C98720
        public void TriggerHapticPulse(){} // RVA: 0x7FFAF8C98A20
        public void GetButtonIdNameFromEnum(){} // RVA: 0x7FFAF8C98A50
        public void GetControllerAxisTypeNameFromEnum(){} // RVA: 0x7FFAF8C98B00
        public void IsInputAvailable(){} // RVA: 0x7FFAF8C98BB0
        public void IsSteamVRDrawingControllers(){} // RVA: 0x7FFAF8C98BE0
        public void ShouldApplicationPause(){} // RVA: 0x7FFAF8C98C10
        public void ShouldApplicationReduceRenderingWork(){} // RVA: 0x7FFAF8C98C40
        public void DriverDebugRequest(){} // RVA: 0x7FFAF8C98C70
        public void PerformFirmwareUpdate(){} // RVA: 0x7FFAF8C98CA0
        public void AcknowledgeQuit_Exiting(){} // RVA: 0x7FFAF8C98CD0
        public void AcknowledgeQuit_UserPrompt(){} // RVA: 0x7FFAF8C98D00
    }

    public class CVRTrackedCamera
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8C99210
        public void GetCameraErrorNameFromEnum(){} // RVA: 0x7FFAF8C993D0
        public void HasCamera(){} // RVA: 0x7FFAF8C99480
        public void GetCameraFrameSize(){} // RVA: 0x7FFAF8C994B0
        public void GetCameraIntrinsics(){} // RVA: 0x7FFAF8C99500
        public void GetCameraProjection(){} // RVA: 0x7FFAF8C99530
        public void AcquireVideoStreamingService(){} // RVA: 0x7FFAF8C99560
        public void ReleaseVideoStreamingService(){} // RVA: 0x7FFAF8C99590
        public void GetVideoStreamFrameBuffer(){} // RVA: 0x7FFAF8C995C0
        public void GetVideoStreamTextureSize(){} // RVA: 0x7FFAF8C995F0
        public void GetVideoStreamTextureD3D11(){} // RVA: 0x7FFAF8C99640
        public void GetVideoStreamTextureGL(){} // RVA: 0x7FFAF8C99670
        public void ReleaseVideoStreamTextureGL(){} // RVA: 0x7FFAF8C996B0
    }

    public class CameraVideoStreamFrameHeader_t
    {
    }

    public class Compositor_CumulativeStats
    {
    }

    public class Compositor_FrameTiming
    {
    }

    public class Compositor_OverlaySettings
    {
    }

}