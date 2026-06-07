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
        public void .ctor(){} // RVA: 0x61E96E0
        public void AddApplicationManifest(){} // RVA: 0x532B9F0
        public void RemoveApplicationManifest(){} // RVA: 0x9A9580
        public void IsApplicationInstalled(){} // RVA: 0x3BF7390
        public void GetApplicationCount(){} // RVA: 0x3C36B00
        public void GetApplicationKeyByIndex(){} // RVA: 0x61E9900
        public void GetApplicationKeyByProcessId(){} // RVA: 0x61E9930
        public void LaunchApplication(){} // RVA: 0x61E9590
        public void LaunchTemplateApplication(){} // RVA: 0x61E9960
        public void LaunchApplicationFromMimeType(){} // RVA: 0x61E99A0
        public void LaunchDashboardOverlay(){} // RVA: 0x61E99D0
        public void CancelApplicationLaunch(){} // RVA: 0x4EC4D80
        public void IdentifyApplication(){} // RVA: 0x61E96B0
        public void GetApplicationProcessId(){} // RVA: 0x61E9A00
        public void GetApplicationsErrorNameFromEnum(){} // RVA: 0x61E9A30
        public void GetApplicationPropertyString(){} // RVA: 0x61E9AE0
        public void GetApplicationPropertyBool(){} // RVA: 0x61E9B20
        public void GetApplicationPropertyUint64(){} // RVA: 0x61E9B50
        public void SetApplicationAutoLaunch(){} // RVA: 0x61E9B80
        public void GetApplicationAutoLaunch(){} // RVA: 0x61E7DD0
        public void SetDefaultApplicationForMimeType(){} // RVA: 0x61E9BB0
        public void GetDefaultApplicationForMimeType(){} // RVA: 0x61E9BE0
        public void GetApplicationSupportedMimeTypes(){} // RVA: 0x61E9C10
        public void GetApplicationsThatSupportMimeType(){} // RVA: 0x61E7E90
        public void GetApplicationLaunchArguments(){} // RVA: 0x61E7EC0
        public void GetStartingApplication(){} // RVA: 0x61E9C40
        public void GetTransitionState(){} // RVA: 0x61E9C70
        public void PerformApplicationPrelaunchCheck(){} // RVA: 0x61E9CA0
        public void GetApplicationsTransitionStateNameFromEnum(){} // RVA: 0x61E9CD0
        public void IsQuitUserPromptRequested(){} // RVA: 0x61E9D80
        public void LaunchInternalProcess(){} // RVA: 0x61E9DB0
        public void GetCurrentSceneProcessId(){} // RVA: 0x61E9DE0
    }

    public class CVRChaperone
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x61E9E10
        public void GetCalibrationState(){} // RVA: 0x1281E30
        public void GetPlayAreaSize(){} // RVA: 0x61E9FB0
        public void GetPlayAreaRect(){} // RVA: 0x3BF7390
        public void ReloadInfo(){} // RVA: 0x3C36B00
        public void SetSceneColor(){} // RVA: 0x61E9FE0
        public void GetBoundsColor(){} // RVA: 0x61EA020
        public void AreBoundsVisible(){} // RVA: 0x61E7B50
        public void ForceBoundsVisible(){} // RVA: 0x61EA050
    }

    public class CVRChaperoneSetup
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x61EA080
        public void CommitWorkingCopy(){} // RVA: 0x288D780
        public void RevertWorkingCopy(){} // RVA: 0x3D91AE0
        public void GetWorkingPlayAreaSize(){} // RVA: 0x61EA270
        public void GetWorkingPlayAreaRect(){} // RVA: 0x3329C00
        public void GetWorkingCollisionBoundsInfo(){} // RVA: 0x61EA2A0
        public void GetLiveCollisionBoundsInfo(){} // RVA: 0x61EA390
        public void GetWorkingSeatedZeroPoseToRawTrackingPose(){} // RVA: 0x61E9590
        public void GetWorkingStandingZeroPoseToRawTrackingPose(){} // RVA: 0x61EA050
        public void SetWorkingPlayAreaSize(){} // RVA: 0x61E99A0
        public void SetWorkingCollisionBoundsInfo(){} // RVA: 0x61EA480
        public void SetWorkingSeatedZeroPoseToRawTrackingPose(){} // RVA: 0x4EC4D80
        public void SetWorkingStandingZeroPoseToRawTrackingPose(){} // RVA: 0x61EA4B0
        public void ReloadFromDisk(){} // RVA: 0x61E9A00
        public void GetLiveSeatedZeroPoseToRawTrackingPose(){} // RVA: 0x61EA4E0
        public void SetWorkingCollisionBoundsTagsInfo(){} // RVA: 0x61EA510
        public void GetLiveCollisionBoundsTagsInfo(){} // RVA: 0x61EA550
        public void SetWorkingPhysicalBoundsInfo(){} // RVA: 0x61EA640
        public void GetLivePhysicalBoundsInfo(){} // RVA: 0x61EA680
        public void ExportLiveToBuffer(){} // RVA: 0x61EA770
        public void ImportFromBufferToWorking(){} // RVA: 0x61E9BB0
    }

    public class CVRCompositor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x61EA7A0
        public void SetTrackingSpace(){} // RVA: 0x288D780
        public void GetTrackingSpace(){} // RVA: 0x3D91AE0
        public void WaitGetPoses(){} // RVA: 0x61EA9C0
        public void GetLastPoses(){} // RVA: 0x61EAA10
        public void GetLastPoseForTrackedDeviceIndex(){} // RVA: 0x61E9900
        public void Submit(){} // RVA: 0x61EAA60
        public void ClearLastSubmittedFrame(){} // RVA: 0x61E7B50
        public void PostPresentHandoff(){} // RVA: 0x61EAA90
        public void GetFrameTiming(){} // RVA: 0x61E99A0
        public void GetFrameTimings(){} // RVA: 0x61EAAC0
        public void GetFrameTimeRemaining(){} // RVA: 0x61EAAF0
        public void GetCumulativeStats(){} // RVA: 0x61E96B0
        public void FadeToColor(){} // RVA: 0x61EAB20
        public void GetCurrentFadeColor(){} // RVA: 0x61EAB70
        public void FadeGrid(){} // RVA: 0x61EABB0
        public void GetCurrentGridAlpha(){} // RVA: 0x61EABE0
        public void SetSkyboxOverride(){} // RVA: 0x61EA640
        public void ClearSkyboxOverride(){} // RVA: 0x61EAC10
        public void CompositorBringToFront(){} // RVA: 0x61EAC40
        public void CompositorGoToBack(){} // RVA: 0x61EAC70
        public void CompositorQuit(){} // RVA: 0x61EACA0
        public void IsFullscreen(){} // RVA: 0x61EACD0
        public void GetCurrentSceneFocusProcess(){} // RVA: 0x61EAD00
        public void GetLastFrameRenderer(){} // RVA: 0x61EAD30
        public void CanRenderScene(){} // RVA: 0x61EAD60
        public void ShowMirrorWindow(){} // RVA: 0x61E9C70
        public void HideMirrorWindow(){} // RVA: 0x61EAD90
        public void IsMirrorWindowVisible(){} // RVA: 0x61EADC0
        public void CompositorDumpImages(){} // RVA: 0x61E9D80
        public void ShouldAppRenderWithLowResources(){} // RVA: 0x61EADF0
        public void ForceInterleavedReprojectionOn(){} // RVA: 0x61EAE20
        public void ForceReconnectProcess(){} // RVA: 0x61EAE50
        public void SuspendRendering(){} // RVA: 0x61EAE80
        public void GetMirrorTextureD3D11(){} // RVA: 0x61EAEB0
        public void ReleaseMirrorTextureD3D11(){} // RVA: 0x61EAEE0
        public void GetMirrorTextureGL(){} // RVA: 0x61EAF10
        public void ReleaseSharedGLTexture(){} // RVA: 0x61EAF50
        public void LockGLSharedTextureForAccess(){} // RVA: 0x61EAF80
        public void UnlockGLSharedTextureForAccess(){} // RVA: 0x61EAFB0
        public void GetVulkanInstanceExtensionsRequired(){} // RVA: 0x61EAFE0
        public void GetVulkanDeviceExtensionsRequired(){} // RVA: 0x61EB010
        public void SetExplicitTimingMode(){} // RVA: 0x61EB040
        public void SubmitExplicitTimingData(){} // RVA: 0x61E8C40
    }

    public class CVRDriverManager
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x61ED6A0
        public void GetDriverCount(){} // RVA: 0x1281E30
        public void GetDriverName(){} // RVA: 0x61ED840
        public void GetDriverHandle(){} // RVA: 0x3BF7390
    }

    public class CVRExtendedDisplay
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x61E8FB0
        public void GetWindowBounds(){} // RVA: 0x61E9150
        public void GetEyeOutputViewport(){} // RVA: 0x61E9190
        public void GetDXGIOutputInfo(){} // RVA: 0x61E91E0
    }

    public class CVRIOBuffer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x61EDD50
        public void Open(){} // RVA: 0x61EDEF0
        public void Close(){} // RVA: 0x9A9580
        public void Read(){} // RVA: 0x61EDF30
        public void Write(){} // RVA: 0x61EDF70
        public void PropertyContainer(){} // RVA: 0x5A8DBC0
    }

    public class CVRInput
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x61ED870
        public void SetActionManifestPath(){} // RVA: 0x288D780
        public void GetActionSetHandle(){} // RVA: 0x61EDA50
        public void GetActionHandle(){} // RVA: 0x61EDA80
        public void GetInputSourceHandle(){} // RVA: 0x61EDAB0
        public void UpdateActionState(){} // RVA: 0x61EDAE0
        public void GetDigitalActionData(){} // RVA: 0x61EAA60
        public void GetAnalogActionData(){} // RVA: 0x61EB300
        public void GetPoseActionData(){} // RVA: 0x61EDB20
        public void GetSkeletalActionData(){} // RVA: 0x61EDB50
        public void GetSkeletalBoneData(){} // RVA: 0x61EDB80
        public void GetSkeletalBoneDataCompressed(){} // RVA: 0x61EDBE0
        public void DecompressSkeletalBoneData(){} // RVA: 0x61EDC20
        public void TriggerHapticVibrationAction(){} // RVA: 0x61EDC70
        public void GetActionOrigins(){} // RVA: 0x61EDCA0
        public void GetOriginLocalizedName(){} // RVA: 0x61EDCE0
        public void GetOriginTrackedDeviceInfo(){} // RVA: 0x61E9B20
        public void ShowActionOrigins(){} // RVA: 0x61EB4E0
        public void ShowBindingsForActionSet(){} // RVA: 0x61EDD10
    }

    public class CVRNotifications
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x61ECC60
        public void CreateNotification(){} // RVA: 0x61ECDF0
        public void RemoveNotification(){} // RVA: 0x9A9580
    }

    public class CVROverlay
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x61EB070
        public void FindOverlay(){} // RVA: 0x61EB260
        public void CreateOverlay(){} // RVA: 0x61EB290
        public void DestroyOverlay(){} // RVA: 0x3BF7390
        public void SetHighQualityOverlay(){} // RVA: 0x3329C00
        public void GetHighQualityOverlay(){} // RVA: 0x61EB2D0
        public void GetOverlayKey(){} // RVA: 0x61EAA60
        public void GetOverlayName(){} // RVA: 0x61EB300
        public void SetOverlayName(){} // RVA: 0x4EC4C40
        public void GetOverlayImageData(){} // RVA: 0x61E95F0
        public void GetOverlayErrorNameFromEnum(){} // RVA: 0x61EB330
        public void SetOverlayRenderingPid(){} // RVA: 0x61EB3E0
        public void GetOverlayRenderingPid(){} // RVA: 0x61EA4B0
        public void SetOverlayFlag(){} // RVA: 0x61EB410
        public void GetOverlayFlag(){} // RVA: 0x61EB440
        public void SetOverlayColor(){} // RVA: 0x61EB470
        public void GetOverlayColor(){} // RVA: 0x61EB4A0
        public void SetOverlayAlpha(){} // RVA: 0x61EB4E0
        public void GetOverlayAlpha(){} // RVA: 0x61EB510
        public void SetOverlayTexelAspect(){} // RVA: 0x61EB540
        public void GetOverlayTexelAspect(){} // RVA: 0x61EB570
        public void SetOverlaySortOrder(){} // RVA: 0x61EB5A0
        public void GetOverlaySortOrder(){} // RVA: 0x61EB5D0
        public void SetOverlayWidthInMeters(){} // RVA: 0x61EB600
        public void GetOverlayWidthInMeters(){} // RVA: 0x61EB630
        public void SetOverlayAutoCurveDistanceRangeInMeters(){} // RVA: 0x61EB660
        public void GetOverlayAutoCurveDistanceRangeInMeters(){} // RVA: 0x61EB690
        public void SetOverlayTextureColorSpace(){} // RVA: 0x61EB6D0
        public void GetOverlayTextureColorSpace(){} // RVA: 0x61EB700
        public void SetOverlayTextureBounds(){} // RVA: 0x61EB730
        public void GetOverlayTextureBounds(){} // RVA: 0x61EB760
        public void GetOverlayRenderModel(){} // RVA: 0x61EB790
        public void SetOverlayRenderModel(){} // RVA: 0x61EB7D0
        public void GetOverlayTransformType(){} // RVA: 0x61EB800
        public void SetOverlayTransformAbsolute(){} // RVA: 0x61EAEB0
        public void GetOverlayTransformAbsolute(){} // RVA: 0x61EB830
        public void SetOverlayTransformTrackedDeviceRelative(){} // RVA: 0x61EB860
        public void GetOverlayTransformTrackedDeviceRelative(){} // RVA: 0x61EB890
        public void SetOverlayTransformTrackedDeviceComponent(){} // RVA: 0x61EB8D0
        public void GetOverlayTransformTrackedDeviceComponent(){} // RVA: 0x61EB900
        public void GetOverlayTransformOverlayRelative(){} // RVA: 0x61EB940
        public void SetOverlayTransformOverlayRelative(){} // RVA: 0x61EB010
        public void ShowOverlay(){} // RVA: 0x61EB040
        public void HideOverlay(){} // RVA: 0x61EB980
        public void IsOverlayVisible(){} // RVA: 0x61EB9B0
        public void GetTransformForOverlayCoordinates(){} // RVA: 0x61EB9E0
        public void PollNextOverlayEvent(){} // RVA: 0x61EBA10
        public void GetOverlayInputMethod(){} // RVA: 0x61EBC70
        public void SetOverlayInputMethod(){} // RVA: 0x61EBCA0
        public void GetOverlayMouseScale(){} // RVA: 0x61EBCD0
        public void SetOverlayMouseScale(){} // RVA: 0x61EBD00
        public void ComputeOverlayIntersection(){} // RVA: 0x61EBD30
        public void IsHoverTargetOverlay(){} // RVA: 0x61EBD60
        public void GetGamepadFocusOverlay(){} // RVA: 0x61EBD90
        public void SetGamepadFocusOverlay(){} // RVA: 0x61EBDC0
        public void SetOverlayNeighbor(){} // RVA: 0x61EBDF0
        public void MoveGamepadFocusToNeighbor(){} // RVA: 0x61EBE20
        public void SetOverlayDualAnalogTransform(){} // RVA: 0x61EBE50
        public void GetOverlayDualAnalogTransform(){} // RVA: 0x61EBE80
        public void SetOverlayTexture(){} // RVA: 0x61EBEC0
        public void ClearOverlayTexture(){} // RVA: 0x61EBEF0
        public void SetOverlayRaw(){} // RVA: 0x61EBF20
        public void SetOverlayFromFile(){} // RVA: 0x61EBF60
        public void GetOverlayTexture(){} // RVA: 0x61EBF90
        public void ReleaseNativeOverlayHandle(){} // RVA: 0x61EBFF0
        public void GetOverlayTextureSize(){} // RVA: 0x61EC020
        public void CreateDashboardOverlay(){} // RVA: 0x61EC060
        public void IsDashboardVisible(){} // RVA: 0x61EC0A0
        public void IsActiveDashboardOverlay(){} // RVA: 0x61EC0D0
        public void SetDashboardOverlaySceneProcess(){} // RVA: 0x61EC100
        public void GetDashboardOverlaySceneProcess(){} // RVA: 0x61EC130
        public void ShowDashboard(){} // RVA: 0x61EC160
        public void GetPrimaryDashboardDevice(){} // RVA: 0x61EC190
        public void ShowKeyboard(){} // RVA: 0x61EC1C0
        public void ShowKeyboardForOverlay(){} // RVA: 0x61EC200
        public void GetKeyboardText(){} // RVA: 0x61EC240
        public void HideKeyboard(){} // RVA: 0x61EC270
        public void SetKeyboardTransformAbsolute(){} // RVA: 0x61EC2A0
        public void SetKeyboardPositionForOverlay(){} // RVA: 0x61EC2D0
        public void SetOverlayIntersectionMask(){} // RVA: 0x61EC310
        public void GetOverlayFlags(){} // RVA: 0x61EC340
        public void ShowMessageOverlay(){} // RVA: 0x61EC370
        public void CloseMessageOverlay(){} // RVA: 0x61EC3B0
    }

    public class CVRRenderModels
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x61EC4B0
        public void LoadRenderModel_Async(){} // RVA: 0x532B9F0
        public void FreeRenderModel(){} // RVA: 0x9A9580
        public void LoadTexture_Async(){} // RVA: 0x5A8DBF0
        public void FreeTexture(){} // RVA: 0x3329C00
        public void LoadTextureD3D11_Async(){} // RVA: 0x61E9900
        public void LoadIntoTextureD3D11_Async(){} // RVA: 0x61EC6A0
        public void FreeTextureD3D11(){} // RVA: 0x61E9590
        public void GetRenderModelName(){} // RVA: 0x61EC6D0
        public void GetRenderModelCount(){} // RVA: 0x61EC700
        public void GetComponentCount(){} // RVA: 0x61E99D0
        public void GetComponentName(){} // RVA: 0x61EC730
        public void GetComponentButtonMask(){} // RVA: 0x61E96B0
        public void GetComponentRenderModelName(){} // RVA: 0x61EC760
        public void GetComponentStateForDevicePath(){} // RVA: 0x61EC790
        public void GetComponentState(){} // RVA: 0x61EC7C0
        public void RenderModelHasComponent(){} // RVA: 0x61ECA30
        public void GetRenderModelThumbnailURL(){} // RVA: 0x61ECA60
        public void GetRenderModelOriginalPath(){} // RVA: 0x61ECA90
        public void GetRenderModelErrorNameFromEnum(){} // RVA: 0x61ECAC0
    }

    public class CVRResources
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x61ED4B0
        public void LoadSharedResource(){} // RVA: 0x61ED640
        public void GetResourceFullPath(){} // RVA: 0x61ED670
    }

    public class CVRScreenshots
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x61ED1F0
        public void RequestScreenshot(){} // RVA: 0x61ED3A0
        public void HookScreenshot(){} // RVA: 0x61ED3E0
        public void GetScreenshotPropertyType(){} // RVA: 0x5A8DBF0
        public void GetScreenshotPropertyFilename(){} // RVA: 0x61ED410
        public void UpdateScreenshotProgress(){} // RVA: 0x61ED440
        public void TakeStereoScreenshot(){} // RVA: 0x61ED470
        public void SubmitScreenshot(){} // RVA: 0x61EB300
    }

    public class CVRSettingHelper
    {
    }

    public class CVRSettings
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x61ECE30
        public void GetSettingsErrorNameFromEnum(){} // RVA: 0x61ECFF0
        public void Sync(){} // RVA: 0x61ED0A0
        public void SetBool(){} // RVA: 0x61ED0D0
        public void SetInt32(){} // RVA: 0x61E9500
        public void SetFloat(){} // RVA: 0x61ED100
        public void SetString(){} // RVA: 0x61EAA60
        public void GetBool(){} // RVA: 0x61ED130
        public void GetInt32(){} // RVA: 0x61EC6D0
        public void GetFloat(){} // RVA: 0x61ED160
        public void GetString(){} // RVA: 0x61ED190
        public void RemoveSection(){} // RVA: 0x61EB3E0
        public void RemoveKeyInSection(){} // RVA: 0x61ED1C0
    }

    public class CVRSpatialAnchors
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x61EDFA0
        public void CreateSpatialAnchorFromDescriptor(){} // RVA: 0x61EE130
        public void CreateSpatialAnchorFromPose(){} // RVA: 0x61EE160
        public void GetSpatialAnchorPose(){} // RVA: 0x61EE1A0
        public void GetSpatialAnchorDescriptor(){} // RVA: 0x61EE1D0
    }

    public class CVRSystem
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x61E7780
        public void GetRecommendedRenderTargetSize(){} // RVA: 0x61E79B0
        public void GetProjectionMatrix(){} // RVA: 0x61E79E0
        public void GetProjectionRaw(){} // RVA: 0x61E7A50
        public void ComputeDistortion(){} // RVA: 0x61E7AA0
        public void GetEyeToHeadTransform(){} // RVA: 0x61E7AD0
        public void GetTimeSinceLastVsync(){} // RVA: 0x61E7B20
        public void GetD3D9AdapterIndex(){} // RVA: 0x61E7B50
        public void GetDXGIOutputInfo(){} // RVA: 0x61E7B80
        public void GetOutputDevice(){} // RVA: 0x61E7BB0
        public void IsDisplayOnDesktop(){} // RVA: 0x61E7BF0
        public void SetDisplayVisibility(){} // RVA: 0x4EC4D80
        public void GetDeviceToAbsoluteTrackingPose(){} // RVA: 0x61E7C20
        public void ResetSeatedZeroPose(){} // RVA: 0x61E7C60
        public void GetSeatedZeroPoseToStandingAbsoluteTrackingPose(){} // RVA: 0x61E7C90
        public void GetRawZeroPoseToStandingAbsoluteTrackingPose(){} // RVA: 0x61E7CE0
        public void GetSortedTrackedDeviceIndicesOfClass(){} // RVA: 0x61E7D30
        public void GetTrackedDeviceActivityLevel(){} // RVA: 0x61E7D70
        public void ApplyTransform(){} // RVA: 0x61E7DA0
        public void GetTrackedDeviceIndexForControllerRole(){} // RVA: 0x61E7DD0
        public void GetControllerRoleForTrackedDeviceIndex(){} // RVA: 0x61E7E00
        public void GetTrackedDeviceClass(){} // RVA: 0x61E7E30
        public void IsTrackedDeviceConnected(){} // RVA: 0x61E7E60
        public void GetBoolTrackedDeviceProperty(){} // RVA: 0x61E7E90
        public void GetFloatTrackedDeviceProperty(){} // RVA: 0x61E7EC0
        public void GetInt32TrackedDeviceProperty(){} // RVA: 0x61E7EF0
        public void GetUint64TrackedDeviceProperty(){} // RVA: 0x61E7F20
        public void GetMatrix34TrackedDeviceProperty(){} // RVA: 0x61E7F50
        public void GetArrayTrackedDeviceProperty(){} // RVA: 0x61E7FB0
        public void GetStringTrackedDeviceProperty(){} // RVA: 0x61E7FF0
        public void GetPropErrorNameFromEnum(){} // RVA: 0x61E8030
        public void PollNextEvent(){} // RVA: 0x61E80E0
        public void PollNextEventWithPose(){} // RVA: 0x61E8320
        public void GetEventTypeNameFromEnum(){} // RVA: 0x61E8350
        public void GetHiddenAreaMesh(){} // RVA: 0x61E8400
        public void GetControllerState(){} // RVA: 0x61E8450
        public void GetControllerStateWithPose(){} // RVA: 0x61E8720
        public void TriggerHapticPulse(){} // RVA: 0x61E8A20
        public void GetButtonIdNameFromEnum(){} // RVA: 0x61E8A50
        public void GetControllerAxisTypeNameFromEnum(){} // RVA: 0x61E8B00
        public void IsInputAvailable(){} // RVA: 0x61E8BB0
        public void IsSteamVRDrawingControllers(){} // RVA: 0x61E8BE0
        public void ShouldApplicationPause(){} // RVA: 0x61E8C10
        public void ShouldApplicationReduceRenderingWork(){} // RVA: 0x61E8C40
        public void DriverDebugRequest(){} // RVA: 0x61E8C70
        public void PerformFirmwareUpdate(){} // RVA: 0x61E8CA0
        public void AcknowledgeQuit_Exiting(){} // RVA: 0x61E8CD0
        public void AcknowledgeQuit_UserPrompt(){} // RVA: 0x61E8D00
    }

    public class CVRTrackedCamera
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x61E9210
        public void GetCameraErrorNameFromEnum(){} // RVA: 0x61E93D0
        public void HasCamera(){} // RVA: 0x61E9480
        public void GetCameraFrameSize(){} // RVA: 0x61E94B0
        public void GetCameraIntrinsics(){} // RVA: 0x61E9500
        public void GetCameraProjection(){} // RVA: 0x61E9530
        public void AcquireVideoStreamingService(){} // RVA: 0x61E9560
        public void ReleaseVideoStreamingService(){} // RVA: 0x61E9590
        public void GetVideoStreamFrameBuffer(){} // RVA: 0x61E95C0
        public void GetVideoStreamTextureSize(){} // RVA: 0x61E95F0
        public void GetVideoStreamTextureD3D11(){} // RVA: 0x61E9640
        public void GetVideoStreamTextureGL(){} // RVA: 0x61E9670
        public void ReleaseVideoStreamTextureGL(){} // RVA: 0x61E96B0
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