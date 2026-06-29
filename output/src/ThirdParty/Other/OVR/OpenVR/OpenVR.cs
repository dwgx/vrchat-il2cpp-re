// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.OVR.OpenVR
// Classes: 25
// Methods: 383

namespace ThirdParty.Other.OVR.OpenVR
{
    public class CVRApplications : Object
    {
        public object FnTable;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C58930
        public void AddApplicationManifest(){} // RVA: 0x5DC7240
        public void RemoveApplicationManifest(){} // RVA: 0x12751C0
        public void IsApplicationInstalled(){} // RVA: 0x46849E0
        public void GetApplicationCount(){} // RVA: 0x46BE380
        public void GetApplicationKeyByIndex(){} // RVA: 0x6C58B10
        public void GetApplicationKeyByProcessId(){} // RVA: 0x6C58B40
        public void LaunchApplication(){} // RVA: 0x6C587E0
        public void LaunchTemplateApplication(){} // RVA: 0x6C58B70
        public void LaunchApplicationFromMimeType(){} // RVA: 0x6C58BB0
        public void LaunchDashboardOverlay(){} // RVA: 0x6C58BE0
        public void CancelApplicationLaunch(){} // RVA: 0x5951980
        public void IdentifyApplication(){} // RVA: 0x6C58900
        public void GetApplicationProcessId(){} // RVA: 0x6C58C10
        public void GetApplicationsErrorNameFromEnum(){} // RVA: 0x6C58C40
        public void GetApplicationPropertyString(){} // RVA: 0x6C58CF0
        public void GetApplicationPropertyBool(){} // RVA: 0x6C58D30
        public void GetApplicationPropertyUint64(){} // RVA: 0x6C58D60
        public void SetApplicationAutoLaunch(){} // RVA: 0x6C58D90
        public void GetApplicationAutoLaunch(){} // RVA: 0x6C57030
        public void SetDefaultApplicationForMimeType(){} // RVA: 0x6C58DC0
        public void GetDefaultApplicationForMimeType(){} // RVA: 0x6C58DF0
        public void GetApplicationSupportedMimeTypes(){} // RVA: 0x6C58E20
        public void GetApplicationsThatSupportMimeType(){} // RVA: 0x6C570F0
        public void GetApplicationLaunchArguments(){} // RVA: 0x6C57120
        public void GetStartingApplication(){} // RVA: 0x6C58E50
        public void GetTransitionState(){} // RVA: 0x6C58E80
        public void PerformApplicationPrelaunchCheck(){} // RVA: 0x6C58EB0
        public void GetApplicationsTransitionStateNameFromEnum(){} // RVA: 0x6C58EE0
        public void IsQuitUserPromptRequested(){} // RVA: 0x6C58F90
        public void LaunchInternalProcess(){} // RVA: 0x6C58FC0
        public void GetCurrentSceneProcessId(){} // RVA: 0x6C58FF0
    }

    public class CVRChaperone : Object
    {
        public object FnTable;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C59020
        public void GetCalibrationState(){} // RVA: 0x1B68170
        public void GetPlayAreaSize(){} // RVA: 0x6C59190
        public void GetPlayAreaRect(){} // RVA: 0x46849E0
        public void ReloadInfo(){} // RVA: 0x46BE380
        public void SetSceneColor(){} // RVA: 0x6C591C0
        public void GetBoundsColor(){} // RVA: 0x6C59200
        public void AreBoundsVisible(){} // RVA: 0x6C56DB0
        public void ForceBoundsVisible(){} // RVA: 0x6C59230
    }

    public class CVRChaperoneSetup : Object
    {
        public object FnTable;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C59260
        public void CommitWorkingCopy(){} // RVA: 0x31D2090
        public void RevertWorkingCopy(){} // RVA: 0x47FD7F0
        public void GetWorkingPlayAreaSize(){} // RVA: 0x6C59420
        public void GetWorkingPlayAreaRect(){} // RVA: 0x3DDB1D0
        public void GetWorkingCollisionBoundsInfo(){} // RVA: 0x6C59450
        public void GetLiveCollisionBoundsInfo(){} // RVA: 0x6C59540
        public void GetWorkingSeatedZeroPoseToRawTrackingPose(){} // RVA: 0x6C587E0
        public void GetWorkingStandingZeroPoseToRawTrackingPose(){} // RVA: 0x6C59230
        public void SetWorkingPlayAreaSize(){} // RVA: 0x6C58BB0
        public void SetWorkingCollisionBoundsInfo(){} // RVA: 0x6C59630
        public void SetWorkingSeatedZeroPoseToRawTrackingPose(){} // RVA: 0x5951980
        public void SetWorkingStandingZeroPoseToRawTrackingPose(){} // RVA: 0x6C59660
        public void ReloadFromDisk(){} // RVA: 0x6C58C10
        public void GetLiveSeatedZeroPoseToRawTrackingPose(){} // RVA: 0x6C59690
        public void SetWorkingCollisionBoundsTagsInfo(){} // RVA: 0x6C596C0
        public void GetLiveCollisionBoundsTagsInfo(){} // RVA: 0x6C59700
        public void SetWorkingPhysicalBoundsInfo(){} // RVA: 0x6C597F0
        public void GetLivePhysicalBoundsInfo(){} // RVA: 0x6C59830
        public void ExportLiveToBuffer(){} // RVA: 0x6C59920
        public void ImportFromBufferToWorking(){} // RVA: 0x6C58DC0
    }

    public class CVRCompositor : Object
    {
        public object FnTable;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C59950
        public void SetTrackingSpace(){} // RVA: 0x31D2090
        public void GetTrackingSpace(){} // RVA: 0x47FD7F0
        public void WaitGetPoses(){} // RVA: 0x6C59B30
        public void GetLastPoses(){} // RVA: 0x6C59B80
        public void GetLastPoseForTrackedDeviceIndex(){} // RVA: 0x6C58B10
        public void Submit(){} // RVA: 0x6C59BD0
        public void ClearLastSubmittedFrame(){} // RVA: 0x6C56DB0
        public void PostPresentHandoff(){} // RVA: 0x6C59C00
        public void GetFrameTiming(){} // RVA: 0x6C58BB0
        public void GetFrameTimings(){} // RVA: 0x6C59C30
        public void GetFrameTimeRemaining(){} // RVA: 0x6C59C60
        public void GetCumulativeStats(){} // RVA: 0x6C58900
        public void FadeToColor(){} // RVA: 0x6C59C90
        public void GetCurrentFadeColor(){} // RVA: 0x6C59CE0
        public void FadeGrid(){} // RVA: 0x6C59D20
        public void GetCurrentGridAlpha(){} // RVA: 0x6C59D50
        public void SetSkyboxOverride(){} // RVA: 0x6C597F0
        public void ClearSkyboxOverride(){} // RVA: 0x6C59D80
        public void CompositorBringToFront(){} // RVA: 0x6C59DB0
        public void CompositorGoToBack(){} // RVA: 0x6C59DE0
        public void CompositorQuit(){} // RVA: 0x6C59E10
        public void IsFullscreen(){} // RVA: 0x6C59E40
        public void GetCurrentSceneFocusProcess(){} // RVA: 0x6C59E70
        public void GetLastFrameRenderer(){} // RVA: 0x6C59EA0
        public void CanRenderScene(){} // RVA: 0x6C59ED0
        public void ShowMirrorWindow(){} // RVA: 0x6C58E80
        public void HideMirrorWindow(){} // RVA: 0x6C59F00
        public void IsMirrorWindowVisible(){} // RVA: 0x6C59F30
        public void CompositorDumpImages(){} // RVA: 0x6C58F90
        public void ShouldAppRenderWithLowResources(){} // RVA: 0x6C59F60
        public void ForceInterleavedReprojectionOn(){} // RVA: 0x6C59F90
        public void ForceReconnectProcess(){} // RVA: 0x6C59FC0
        public void SuspendRendering(){} // RVA: 0x6C59FF0
        public void GetMirrorTextureD3D11(){} // RVA: 0x6C5A020
        public void ReleaseMirrorTextureD3D11(){} // RVA: 0x6C5A050
        public void GetMirrorTextureGL(){} // RVA: 0x6C5A080
        public void ReleaseSharedGLTexture(){} // RVA: 0x6C5A0C0
        public void LockGLSharedTextureForAccess(){} // RVA: 0x6C5A0F0
        public void UnlockGLSharedTextureForAccess(){} // RVA: 0x6C5A120
        public void GetVulkanInstanceExtensionsRequired(){} // RVA: 0x6C5A150
        public void GetVulkanDeviceExtensionsRequired(){} // RVA: 0x6C5A180
        public void SetExplicitTimingMode(){} // RVA: 0x6C5A1B0
        public void SubmitExplicitTimingData(){} // RVA: 0x6C57F40
    }

    public class CVRDriverManager : Object
    {
        public object FnTable;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C5C6D0
        public void GetDriverCount(){} // RVA: 0x1B68170
        public void GetDriverName(){} // RVA: 0x6C5C830
        public void GetDriverHandle(){} // RVA: 0x46849E0
    }

    public class CVRExtendedDisplay : Object
    {
        public object FnTable;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C58280
        public void GetWindowBounds(){} // RVA: 0x6C583E0
        public void GetEyeOutputViewport(){} // RVA: 0x6C58420
        public void GetDXGIOutputInfo(){} // RVA: 0x6C58470
    }

    public class CVRIOBuffer : Object
    {
        public object FnTable;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C5CD00
        public void Open(){} // RVA: 0x6C5CE60
        public void Close(){} // RVA: 0x12751C0
        public void Read(){} // RVA: 0x6C5CEA0
        public void Write(){} // RVA: 0x6C5CEE0
        public void PropertyContainer(){} // RVA: 0x6507E80
    }

    public class CVRInput : Object
    {
        public object FnTable;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C5C860
        public void SetActionManifestPath(){} // RVA: 0x31D2090
        public void GetActionSetHandle(){} // RVA: 0x6C5CA10
        public void GetActionHandle(){} // RVA: 0x6C5CA40
        public void GetInputSourceHandle(){} // RVA: 0x6C5CA70
        public void UpdateActionState(){} // RVA: 0x6C5CAA0
        public void GetDigitalActionData(){} // RVA: 0x6C59BD0
        public void GetAnalogActionData(){} // RVA: 0x6C5A430
        public void GetPoseActionData(){} // RVA: 0x6C5CAE0
        public void GetSkeletalActionData(){} // RVA: 0x6C5CB10
        public void GetSkeletalBoneData(){} // RVA: 0x6C5CB40
        public void GetSkeletalBoneDataCompressed(){} // RVA: 0x6C5CB90
        public void DecompressSkeletalBoneData(){} // RVA: 0x6C5CBD0
        public void TriggerHapticVibrationAction(){} // RVA: 0x6C5CC20
        public void GetActionOrigins(){} // RVA: 0x6C5CC50
        public void GetOriginLocalizedName(){} // RVA: 0x6C5CC90
        public void GetOriginTrackedDeviceInfo(){} // RVA: 0x6C58D30
        public void ShowActionOrigins(){} // RVA: 0x6C5A610
        public void ShowBindingsForActionSet(){} // RVA: 0x6C5CCC0
    }

    public class CVRNotifications : Object
    {
        public object FnTable;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C5BD90
        public void CreateNotification(){} // RVA: 0x6C5BEE0
        public void RemoveNotification(){} // RVA: 0x12751C0
    }

    public class CVROverlay : Object
    {
        public object FnTable;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C5A1E0
        public void FindOverlay(){} // RVA: 0x6C5A390
        public void CreateOverlay(){} // RVA: 0x6C5A3C0
        public void DestroyOverlay(){} // RVA: 0x46849E0
        public void SetHighQualityOverlay(){} // RVA: 0x3DDB1D0
        public void GetHighQualityOverlay(){} // RVA: 0x6C5A400
        public void GetOverlayKey(){} // RVA: 0x6C59BD0
        public void GetOverlayName(){} // RVA: 0x6C5A430
        public void SetOverlayName(){} // RVA: 0x5951730
        public void GetOverlayImageData(){} // RVA: 0x6C58840
        public void GetOverlayErrorNameFromEnum(){} // RVA: 0x6C5A460
        public void SetOverlayRenderingPid(){} // RVA: 0x6C5A510
        public void GetOverlayRenderingPid(){} // RVA: 0x6C59660
        public void SetOverlayFlag(){} // RVA: 0x6C5A540
        public void GetOverlayFlag(){} // RVA: 0x6C5A570
        public void SetOverlayColor(){} // RVA: 0x6C5A5A0
        public void GetOverlayColor(){} // RVA: 0x6C5A5D0
        public void SetOverlayAlpha(){} // RVA: 0x6C5A610
        public void GetOverlayAlpha(){} // RVA: 0x6C5A640
        public void SetOverlayTexelAspect(){} // RVA: 0x6C5A670
        public void GetOverlayTexelAspect(){} // RVA: 0x6C5A6A0
        public void SetOverlaySortOrder(){} // RVA: 0x6C5A6D0
        public void GetOverlaySortOrder(){} // RVA: 0x6C5A700
        public void SetOverlayWidthInMeters(){} // RVA: 0x6C5A730
        public void GetOverlayWidthInMeters(){} // RVA: 0x6C5A760
        public void SetOverlayAutoCurveDistanceRangeInMeters(){} // RVA: 0x6C5A790
        public void GetOverlayAutoCurveDistanceRangeInMeters(){} // RVA: 0x6C5A7C0
        public void SetOverlayTextureColorSpace(){} // RVA: 0x6C5A800
        public void GetOverlayTextureColorSpace(){} // RVA: 0x6C5A830
        public void SetOverlayTextureBounds(){} // RVA: 0x6C5A860
        public void GetOverlayTextureBounds(){} // RVA: 0x6C5A890
        public void GetOverlayRenderModel(){} // RVA: 0x6C5A8C0
        public void SetOverlayRenderModel(){} // RVA: 0x6C5A900
        public void GetOverlayTransformType(){} // RVA: 0x6C5A930
        public void SetOverlayTransformAbsolute(){} // RVA: 0x6C5A020
        public void GetOverlayTransformAbsolute(){} // RVA: 0x6C5A960
        public void SetOverlayTransformTrackedDeviceRelative(){} // RVA: 0x6C5A990
        public void GetOverlayTransformTrackedDeviceRelative(){} // RVA: 0x6C5A9C0
        public void SetOverlayTransformTrackedDeviceComponent(){} // RVA: 0x6C5AA00
        public void GetOverlayTransformTrackedDeviceComponent(){} // RVA: 0x6C5AA30
        public void GetOverlayTransformOverlayRelative(){} // RVA: 0x6C5AA70
        public void SetOverlayTransformOverlayRelative(){} // RVA: 0x6C5A180
        public void ShowOverlay(){} // RVA: 0x6C5A1B0
        public void HideOverlay(){} // RVA: 0x6C5AAB0
        public void IsOverlayVisible(){} // RVA: 0x6C5AAE0
        public void GetTransformForOverlayCoordinates(){} // RVA: 0x6C5AB10
        public void PollNextOverlayEvent(){} // RVA: 0x6C5AB40
        public void GetOverlayInputMethod(){} // RVA: 0x6C5ADD0
        public void SetOverlayInputMethod(){} // RVA: 0x6C5AE00
        public void GetOverlayMouseScale(){} // RVA: 0x6C5AE30
        public void SetOverlayMouseScale(){} // RVA: 0x6C5AE60
        public void ComputeOverlayIntersection(){} // RVA: 0x6C5AE90
        public void IsHoverTargetOverlay(){} // RVA: 0x6C5AEC0
        public void GetGamepadFocusOverlay(){} // RVA: 0x6C5AEF0
        public void SetGamepadFocusOverlay(){} // RVA: 0x6C5AF20
        public void SetOverlayNeighbor(){} // RVA: 0x6C5AF50
        public void MoveGamepadFocusToNeighbor(){} // RVA: 0x6C5AF80
        public void SetOverlayDualAnalogTransform(){} // RVA: 0x6C5AFB0
        public void GetOverlayDualAnalogTransform(){} // RVA: 0x6C5AFE0
        public void SetOverlayTexture(){} // RVA: 0x6C5B020
        public void ClearOverlayTexture(){} // RVA: 0x6C5B050
        public void SetOverlayRaw(){} // RVA: 0x6C5B080
        public void SetOverlayFromFile(){} // RVA: 0x6C5B0C0
        public void GetOverlayTexture(){} // RVA: 0x6C5B0F0
        public void ReleaseNativeOverlayHandle(){} // RVA: 0x6C5B150
        public void GetOverlayTextureSize(){} // RVA: 0x6C5B180
        public void CreateDashboardOverlay(){} // RVA: 0x6C5B1C0
        public void IsDashboardVisible(){} // RVA: 0x6C5B200
        public void IsActiveDashboardOverlay(){} // RVA: 0x6C5B230
        public void SetDashboardOverlaySceneProcess(){} // RVA: 0x6C5B260
        public void GetDashboardOverlaySceneProcess(){} // RVA: 0x6C5B290
        public void ShowDashboard(){} // RVA: 0x6C5B2C0
        public void GetPrimaryDashboardDevice(){} // RVA: 0x6C5B2F0
        public void ShowKeyboard(){} // RVA: 0x6C5B320
        public void ShowKeyboardForOverlay(){} // RVA: 0x6C5B360
        public void GetKeyboardText(){} // RVA: 0x6C5B3A0
        public void HideKeyboard(){} // RVA: 0x6C5B3D0
        public void SetKeyboardTransformAbsolute(){} // RVA: 0x6C5B400
        public void SetKeyboardPositionForOverlay(){} // RVA: 0x6C5B430
        public void SetOverlayIntersectionMask(){} // RVA: 0x6C5B470
        public void GetOverlayFlags(){} // RVA: 0x6C5B4A0
        public void ShowMessageOverlay(){} // RVA: 0x6C5B4D0
        public void CloseMessageOverlay(){} // RVA: 0x6C5B510
    }

    public class CVRRenderModels : Object
    {
        public object FnTable;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C5B5F0
        public void LoadRenderModel_Async(){} // RVA: 0x5DC7240
        public void FreeRenderModel(){} // RVA: 0x12751C0
        public void LoadTexture_Async(){} // RVA: 0x6507EB0
        public void FreeTexture(){} // RVA: 0x3DDB1D0
        public void LoadTextureD3D11_Async(){} // RVA: 0x6C58B10
        public void LoadIntoTextureD3D11_Async(){} // RVA: 0x6C5B7B0
        public void FreeTextureD3D11(){} // RVA: 0x6C587E0
        public void GetRenderModelName(){} // RVA: 0x6C5B7E0
        public void GetRenderModelCount(){} // RVA: 0x6C5B810
        public void GetComponentCount(){} // RVA: 0x6C58BE0
        public void GetComponentName(){} // RVA: 0x6C5B840
        public void GetComponentButtonMask(){} // RVA: 0x6C58900
        public void GetComponentRenderModelName(){} // RVA: 0x6C5B870
        public void GetComponentStateForDevicePath(){} // RVA: 0x6C5B8A0
        public void GetComponentState(){} // RVA: 0x6C5B8D0
        public void RenderModelHasComponent(){} // RVA: 0x6C5BB60
        public void GetRenderModelThumbnailURL(){} // RVA: 0x6C5BB90
        public void GetRenderModelOriginalPath(){} // RVA: 0x6C5BBC0
        public void GetRenderModelErrorNameFromEnum(){} // RVA: 0x6C5BBF0
    }

    public class CVRResources : Object
    {
        public object FnTable;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C5C520
        public void LoadSharedResource(){} // RVA: 0x6C5C670
        public void GetResourceFullPath(){} // RVA: 0x6C5C6A0
    }

    public class CVRScreenshots : Object
    {
        public object FnTable;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C5C2A0
        public void RequestScreenshot(){} // RVA: 0x6C5C410
        public void HookScreenshot(){} // RVA: 0x6C5C450
        public void GetScreenshotPropertyType(){} // RVA: 0x6507EB0
        public void GetScreenshotPropertyFilename(){} // RVA: 0x6C5C480
        public void UpdateScreenshotProgress(){} // RVA: 0x6C5C4B0
        public void TakeStereoScreenshot(){} // RVA: 0x6C5C4E0
        public void SubmitScreenshot(){} // RVA: 0x6C5A430
    }

    public class CVRSettings : Object
    {
        public object FnTable;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C5BF20
        public void GetSettingsErrorNameFromEnum(){} // RVA: 0x6C5C0A0
        public void Sync(){} // RVA: 0x6C5C150
        public void SetBool(){} // RVA: 0x6C5C180
        public void SetInt32(){} // RVA: 0x6C58750
        public void SetFloat(){} // RVA: 0x6C5C1B0
        public void SetString(){} // RVA: 0x6C59BD0
        public void GetBool(){} // RVA: 0x6C5C1E0
        public void GetInt32(){} // RVA: 0x6C5B7E0
        public void GetFloat(){} // RVA: 0x6C5C210
        public void GetString(){} // RVA: 0x6C5C240
        public void RemoveSection(){} // RVA: 0x6C5A510
        public void RemoveKeyInSection(){} // RVA: 0x6C5C270
    }

    public class CVRSpatialAnchors : Object
    {
        public object FnTable;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C5CF10
        public void CreateSpatialAnchorFromDescriptor(){} // RVA: 0x6C5D070
        public void CreateSpatialAnchorFromPose(){} // RVA: 0x6C5D0A0
        public void GetSpatialAnchorPose(){} // RVA: 0x6C5D0E0
        public void GetSpatialAnchorDescriptor(){} // RVA: 0x6C5D110
    }

    public class CVRSystem : Object
    {
        public object FnTable;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C56A20
        public void GetRecommendedRenderTargetSize(){} // RVA: 0x6C56C10
        public void GetProjectionMatrix(){} // RVA: 0x6C56C40
        public void GetProjectionRaw(){} // RVA: 0x6C56CB0
        public void ComputeDistortion(){} // RVA: 0x6C56D00
        public void GetEyeToHeadTransform(){} // RVA: 0x6C56D30
        public void GetTimeSinceLastVsync(){} // RVA: 0x6C56D80
        public void GetD3D9AdapterIndex(){} // RVA: 0x6C56DB0
        public void GetDXGIOutputInfo(){} // RVA: 0x6C56DE0
        public void GetOutputDevice(){} // RVA: 0x6C56E10
        public void IsDisplayOnDesktop(){} // RVA: 0x6C56E50
        public void SetDisplayVisibility(){} // RVA: 0x5951980
        public void GetDeviceToAbsoluteTrackingPose(){} // RVA: 0x6C56E80
        public void ResetSeatedZeroPose(){} // RVA: 0x6C56EC0
        public void GetSeatedZeroPoseToStandingAbsoluteTrackingPose(){} // RVA: 0x6C56EF0
        public void GetRawZeroPoseToStandingAbsoluteTrackingPose(){} // RVA: 0x6C56F40
        public void GetSortedTrackedDeviceIndicesOfClass(){} // RVA: 0x6C56F90
        public void GetTrackedDeviceActivityLevel(){} // RVA: 0x6C56FD0
        public void ApplyTransform(){} // RVA: 0x6C57000
        public void GetTrackedDeviceIndexForControllerRole(){} // RVA: 0x6C57030
        public void GetControllerRoleForTrackedDeviceIndex(){} // RVA: 0x6C57060
        public void GetTrackedDeviceClass(){} // RVA: 0x6C57090
        public void IsTrackedDeviceConnected(){} // RVA: 0x6C570C0
        public void GetBoolTrackedDeviceProperty(){} // RVA: 0x6C570F0
        public void GetFloatTrackedDeviceProperty(){} // RVA: 0x6C57120
        public void GetInt32TrackedDeviceProperty(){} // RVA: 0x6C57150
        public void GetUint64TrackedDeviceProperty(){} // RVA: 0x6C57180
        public void GetMatrix34TrackedDeviceProperty(){} // RVA: 0x6C571B0
        public void GetArrayTrackedDeviceProperty(){} // RVA: 0x6C57210
        public void GetStringTrackedDeviceProperty(){} // RVA: 0x6C57250
        public void GetPropErrorNameFromEnum(){} // RVA: 0x6C57290
        public void PollNextEvent(){} // RVA: 0x6C57340
        public void PollNextEventWithPose(){} // RVA: 0x6C575B0
        public void GetEventTypeNameFromEnum(){} // RVA: 0x6C575E0
        public void GetHiddenAreaMesh(){} // RVA: 0x6C57690
        public void GetControllerState(){} // RVA: 0x6C576E0
        public void GetControllerStateWithPose(){} // RVA: 0x6C579F0
        public void TriggerHapticPulse(){} // RVA: 0x6C57D20
        public void GetButtonIdNameFromEnum(){} // RVA: 0x6C57D50
        public void GetControllerAxisTypeNameFromEnum(){} // RVA: 0x6C57E00
        public void IsInputAvailable(){} // RVA: 0x6C57EB0
        public void IsSteamVRDrawingControllers(){} // RVA: 0x6C57EE0
        public void ShouldApplicationPause(){} // RVA: 0x6C57F10
        public void ShouldApplicationReduceRenderingWork(){} // RVA: 0x6C57F40
        public void DriverDebugRequest(){} // RVA: 0x6C57F70
        public void PerformFirmwareUpdate(){} // RVA: 0x6C57FA0
        public void AcknowledgeQuit_Exiting(){} // RVA: 0x6C57FD0
        public void AcknowledgeQuit_UserPrompt(){} // RVA: 0x6C58000
    }

    public class CVRTrackedCamera : Object
    {
        public object FnTable;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C584A0
        public void GetCameraErrorNameFromEnum(){} // RVA: 0x6C58620
        public void HasCamera(){} // RVA: 0x6C586D0
        public void GetCameraFrameSize(){} // RVA: 0x6C58700
        public void GetCameraIntrinsics(){} // RVA: 0x6C58750
        public void GetCameraProjection(){} // RVA: 0x6C58780
        public void AcquireVideoStreamingService(){} // RVA: 0x6C587B0
        public void ReleaseVideoStreamingService(){} // RVA: 0x6C587E0
        public void GetVideoStreamFrameBuffer(){} // RVA: 0x6C58810
        public void GetVideoStreamTextureSize(){} // RVA: 0x6C58840
        public void GetVideoStreamTextureD3D11(){} // RVA: 0x6C58890
        public void GetVideoStreamTextureGL(){} // RVA: 0x6C588C0
        public void ReleaseVideoStreamTextureGL(){} // RVA: 0x6C58900
    }

    public class InputOriginInfo_t : ValueType
    {
        public object devicePath;
        public object trackedDeviceIndex;
        public object rchRenderModelComponentName0;
        public object rchRenderModelComponentName1;
        public object rchRenderModelComponentName2;
        public object rchRenderModelComponentName3;
        public object rchRenderModelComponentName4;
        public object rchRenderModelComponentName5;
        public object rchRenderModelComponentName6;
        public object rchRenderModelComponentName7;
        public object rchRenderModelComponentName8;
        public object rchRenderModelComponentName9;
        public object rchRenderModelComponentName10;
        public object rchRenderModelComponentName11;
        public object rchRenderModelComponentName12;
        public object rchRenderModelComponentName13;
        public object rchRenderModelComponentName14;
        public object rchRenderModelComponentName15;
        public object rchRenderModelComponentName16;
        public object rchRenderModelComponentName17;
        public object rchRenderModelComponentName18;
        public object rchRenderModelComponentName19;
        public object rchRenderModelComponentName20;
        public object rchRenderModelComponentName21;
        public object rchRenderModelComponentName22;
        public object rchRenderModelComponentName23;
        public object rchRenderModelComponentName24;
        public object rchRenderModelComponentName25;
        public object rchRenderModelComponentName26;
        public object rchRenderModelComponentName27;
        public object rchRenderModelComponentName28;
        public object rchRenderModelComponentName29;
        public object rchRenderModelComponentName30;
        public object rchRenderModelComponentName31;
        public object rchRenderModelComponentName32;
        public object rchRenderModelComponentName33;
        public object rchRenderModelComponentName34;
        public object rchRenderModelComponentName35;
        public object rchRenderModelComponentName36;
        public object rchRenderModelComponentName37;
        public object rchRenderModelComponentName38;
        public object rchRenderModelComponentName39;
        public object rchRenderModelComponentName40;
        public object rchRenderModelComponentName41;
        public object rchRenderModelComponentName42;
        public object rchRenderModelComponentName43;
        public object rchRenderModelComponentName44;
        public object rchRenderModelComponentName45;
        public object rchRenderModelComponentName46;
        public object rchRenderModelComponentName47;
        public object rchRenderModelComponentName48;
        public object rchRenderModelComponentName49;
        public object rchRenderModelComponentName50;
        public object rchRenderModelComponentName51;
        public object rchRenderModelComponentName52;
        public object rchRenderModelComponentName53;
        public object rchRenderModelComponentName54;
        public object rchRenderModelComponentName55;
        public object rchRenderModelComponentName56;
        public object rchRenderModelComponentName57;
        public object rchRenderModelComponentName58;
        public object rchRenderModelComponentName59;
        public object rchRenderModelComponentName60;
        public object rchRenderModelComponentName61;
        public object rchRenderModelComponentName62;
        public object rchRenderModelComponentName63;
        public object rchRenderModelComponentName64;
        public object rchRenderModelComponentName65;
        public object rchRenderModelComponentName66;
        public object rchRenderModelComponentName67;
        public object rchRenderModelComponentName68;
        public object rchRenderModelComponentName69;
        public object rchRenderModelComponentName70;
        public object rchRenderModelComponentName71;
        public object rchRenderModelComponentName72;
        public object rchRenderModelComponentName73;
        public object rchRenderModelComponentName74;
        public object rchRenderModelComponentName75;
        public object rchRenderModelComponentName76;
        public object rchRenderModelComponentName77;
        public object rchRenderModelComponentName78;
        public object rchRenderModelComponentName79;
        public object rchRenderModelComponentName80;
        public object rchRenderModelComponentName81;
        public object rchRenderModelComponentName82;
        public object rchRenderModelComponentName83;
        public object rchRenderModelComponentName84;
        public object rchRenderModelComponentName85;
        public object rchRenderModelComponentName86;
        public object rchRenderModelComponentName87;
        public object rchRenderModelComponentName88;
        public object rchRenderModelComponentName89;
        public object rchRenderModelComponentName90;
        public object rchRenderModelComponentName91;
        public object rchRenderModelComponentName92;
        public object rchRenderModelComponentName93;
        public object rchRenderModelComponentName94;
        public object rchRenderModelComponentName95;
        public object rchRenderModelComponentName96;
        public object rchRenderModelComponentName97;
        public object rchRenderModelComponentName98;
        public object rchRenderModelComponentName99;
        public object rchRenderModelComponentName100;
        public object rchRenderModelComponentName101;
        public object rchRenderModelComponentName102;
        public object rchRenderModelComponentName103;
        public object rchRenderModelComponentName104;
        public object rchRenderModelComponentName105;
        public object rchRenderModelComponentName106;
        public object rchRenderModelComponentName107;
        public object rchRenderModelComponentName108;
        public object rchRenderModelComponentName109;
        public object rchRenderModelComponentName110;
        public object rchRenderModelComponentName111;
        public object rchRenderModelComponentName112;
        public object rchRenderModelComponentName113;
        public object rchRenderModelComponentName114;
        public object rchRenderModelComponentName115;
        public object rchRenderModelComponentName116;
        public object rchRenderModelComponentName117;
        public object rchRenderModelComponentName118;
        public object rchRenderModelComponentName119;
        public object rchRenderModelComponentName120;
        public object rchRenderModelComponentName121;
        public object rchRenderModelComponentName122;
        public object rchRenderModelComponentName123;
        public object rchRenderModelComponentName124;
        public object rchRenderModelComponentName125;
        public object rchRenderModelComponentName126;
        public object rchRenderModelComponentName127;

        // ── Methods ──
        public void get_rchRenderModelComponentName(){} // RVA: 0x8E3930
    }

    public class OpenVR : Object
    {
        public object k_nDriverNone;
        public object k_unMaxDriverDebugResponseSize;
        public object k_unTrackedDeviceIndex_Hmd;
        public object k_unMaxTrackedDeviceCount;
        public object k_unTrackedDeviceIndexOther;
        public object k_unTrackedDeviceIndexInvalid;
        public object k_ulInvalidPropertyContainer;
        public object k_unInvalidPropertyTag;
        public object k_ulInvalidDriverHandle;
        public object k_unFloatPropertyTag;
        public object k_unInt32PropertyTag;
        public object k_unUint64PropertyTag;
        public object k_unBoolPropertyTag;
        public object k_unStringPropertyTag;
        public object k_unHmdMatrix34PropertyTag;
        public object k_unHmdMatrix44PropertyTag;
        public object k_unHmdVector3PropertyTag;
        public object k_unHmdVector4PropertyTag;
        public object k_unHiddenAreaPropertyTag;
        public object k_unPathHandleInfoTag;
        public object k_unActionPropertyTag;
        public object k_unInputValuePropertyTag;
        public object k_unWildcardPropertyTag;
        public object k_unHapticVibrationPropertyTag;
        public object k_unSkeletonPropertyTag;
        public object k_unSpatialAnchorPosePropertyTag;
        public object k_unOpenVRInternalReserved_Start;
        public object k_unOpenVRInternalReserved_End;
        public object k_unMaxPropertyStringSize;
        public object k_ulInvalidActionHandle;
        public object k_ulInvalidActionSetHandle;
        public object k_ulInvalidInputValueHandle;
        public object k_unControllerStateAxisCount;
        public object k_ulOverlayHandleInvalid;
        public object k_unScreenshotHandleInvalid;
        public object IVRSystem_Version;
        public object IVRExtendedDisplay_Version;
        public object IVRTrackedCamera_Version;
        public object k_unMaxApplicationKeyLength;
        public object k_pch_MimeType_HomeApp;
        public object k_pch_MimeType_GameTheater;
        public object IVRApplications_Version;
        public object IVRChaperone_Version;
        public object IVRChaperoneSetup_Version;
        public object IVRCompositor_Version;
        public object k_unVROverlayMaxKeyLength;
        public object k_unVROverlayMaxNameLength;
        public object k_unMaxOverlayCount;
        public object k_unMaxOverlayIntersectionMaskPrimitivesCount;
        public object IVROverlay_Version;
        public object k_pch_Controller_Component_GDC2015;
        public object k_pch_Controller_Component_Base;
        public object k_pch_Controller_Component_Tip;
        public object k_pch_Controller_Component_HandGrip;
        public object k_pch_Controller_Component_Status;
        public object IVRRenderModels_Version;
        public object k_unNotificationTextMaxSize;
        public object IVRNotifications_Version;
        public object k_unMaxSettingsKeyLength;
        public object IVRSettings_Version;
        public object k_pch_SteamVR_Section;
        public object k_pch_SteamVR_RequireHmd_String;
        public object k_pch_SteamVR_ForcedDriverKey_String;
        public object k_pch_SteamVR_ForcedHmdKey_String;
        public object k_pch_SteamVR_DisplayDebug_Bool;
        public object k_pch_SteamVR_DebugProcessPipe_String;
        public object k_pch_SteamVR_DisplayDebugX_Int32;
        public object k_pch_SteamVR_DisplayDebugY_Int32;
        public object k_pch_SteamVR_SendSystemButtonToAllApps_Bool;
        public object k_pch_SteamVR_LogLevel_Int32;
        public object k_pch_SteamVR_IPD_Float;
        public object k_pch_SteamVR_Background_String;
        public object k_pch_SteamVR_BackgroundUseDomeProjection_Bool;
        public object k_pch_SteamVR_BackgroundCameraHeight_Float;
        public object k_pch_SteamVR_BackgroundDomeRadius_Float;
        public object k_pch_SteamVR_GridColor_String;
        public object k_pch_SteamVR_PlayAreaColor_String;
        public object k_pch_SteamVR_ShowStage_Bool;
        public object k_pch_SteamVR_ActivateMultipleDrivers_Bool;
        public object k_pch_SteamVR_DirectMode_Bool;
        public object k_pch_SteamVR_DirectModeEdidVid_Int32;
        public object k_pch_SteamVR_DirectModeEdidPid_Int32;
        public object k_pch_SteamVR_UsingSpeakers_Bool;
        public object k_pch_SteamVR_SpeakersForwardYawOffsetDegrees_Float;
        public object k_pch_SteamVR_BaseStationPowerManagement_Bool;
        public object k_pch_SteamVR_NeverKillProcesses_Bool;
        public object k_pch_SteamVR_SupersampleScale_Float;
        public object k_pch_SteamVR_AllowAsyncReprojection_Bool;
        public object k_pch_SteamVR_AllowReprojection_Bool;
        public object k_pch_SteamVR_ForceReprojection_Bool;
        public object k_pch_SteamVR_ForceFadeOnBadTracking_Bool;
        public object k_pch_SteamVR_DefaultMirrorView_Int32;
        public object k_pch_SteamVR_ShowMirrorView_Bool;
        public object k_pch_SteamVR_MirrorViewGeometry_String;
        public object k_pch_SteamVR_StartMonitorFromAppLaunch;
        public object k_pch_SteamVR_StartCompositorFromAppLaunch_Bool;
        public object k_pch_SteamVR_StartDashboardFromAppLaunch_Bool;
        public object k_pch_SteamVR_StartOverlayAppsFromDashboard_Bool;
        public object k_pch_SteamVR_EnableHomeApp;
        public object k_pch_SteamVR_CycleBackgroundImageTimeSec_Int32;
        public object k_pch_SteamVR_RetailDemo_Bool;
        public object k_pch_SteamVR_IpdOffset_Float;
        public object k_pch_SteamVR_AllowSupersampleFiltering_Bool;
        public object k_pch_SteamVR_SupersampleManualOverride_Bool;
        public object k_pch_SteamVR_EnableLinuxVulkanAsync_Bool;
        public object k_pch_SteamVR_AllowDisplayLockedMode_Bool;
        public object k_pch_SteamVR_HaveStartedTutorialForNativeChaperoneDriver_Bool;
        public object k_pch_SteamVR_ForceWindows32bitVRMonitor;
        public object k_pch_SteamVR_DebugInput;
        public object k_pch_SteamVR_LegacyInputRebinding;
        public object k_pch_SteamVR_DebugInputBinding;
        public object k_pch_SteamVR_InputBindingUIBlock;
        public object k_pch_SteamVR_RenderCameraMode;
        public object k_pch_Lighthouse_Section;
        public object k_pch_Lighthouse_DisableIMU_Bool;
        public object k_pch_Lighthouse_DisableIMUExceptHMD_Bool;
        public object k_pch_Lighthouse_UseDisambiguation_String;
        public object k_pch_Lighthouse_DisambiguationDebug_Int32;
        public object k_pch_Lighthouse_PrimaryBasestation_Int32;
        public object k_pch_Lighthouse_DBHistory_Bool;
        public object k_pch_Lighthouse_EnableBluetooth_Bool;
        public object k_pch_Lighthouse_PowerManagedBaseStations_String;
        public object k_pch_Null_Section;
        public object k_pch_Null_SerialNumber_String;
        public object k_pch_Null_ModelNumber_String;
        public object k_pch_Null_WindowX_Int32;
        public object k_pch_Null_WindowY_Int32;
        public object k_pch_Null_WindowWidth_Int32;
        public object k_pch_Null_WindowHeight_Int32;
        public object k_pch_Null_RenderWidth_Int32;
        public object k_pch_Null_RenderHeight_Int32;
        public object k_pch_Null_SecondsFromVsyncToPhotons_Float;
        public object k_pch_Null_DisplayFrequency_Float;
        public object k_pch_UserInterface_Section;
        public object k_pch_UserInterface_StatusAlwaysOnTop_Bool;
        public object k_pch_UserInterface_MinimizeToTray_Bool;
        public object k_pch_UserInterface_Screenshots_Bool;
        public object k_pch_UserInterface_ScreenshotType_Int;
        public object k_pch_Notifications_Section;
        public object k_pch_Notifications_DoNotDisturb_Bool;
        public object k_pch_Keyboard_Section;
        public object k_pch_Keyboard_TutorialCompletions;
        public object k_pch_Keyboard_ScaleX;
        public object k_pch_Keyboard_ScaleY;
        public object k_pch_Keyboard_OffsetLeftX;
        public object k_pch_Keyboard_OffsetRightX;
        public object k_pch_Keyboard_OffsetY;
        public object k_pch_Keyboard_Smoothing;
        public object k_pch_Perf_Section;
        public object k_pch_Perf_HeuristicActive_Bool;
        public object k_pch_Perf_NotifyInHMD_Bool;
        public object k_pch_Perf_NotifyOnlyOnce_Bool;
        public object k_pch_Perf_AllowTimingStore_Bool;
        public object k_pch_Perf_SaveTimingsOnExit_Bool;
        public object k_pch_Perf_TestData_Float;
        public object k_pch_Perf_LinuxGPUProfiling_Bool;
        public object k_pch_CollisionBounds_Section;
        public object k_pch_CollisionBounds_Style_Int32;
        public object k_pch_CollisionBounds_GroundPerimeterOn_Bool;
        public object k_pch_CollisionBounds_CenterMarkerOn_Bool;
        public object k_pch_CollisionBounds_PlaySpaceOn_Bool;
        public object k_pch_CollisionBounds_FadeDistance_Float;
        public object k_pch_CollisionBounds_ColorGammaR_Int32;
        public object k_pch_CollisionBounds_ColorGammaG_Int32;
        public object k_pch_CollisionBounds_ColorGammaB_Int32;
        public object k_pch_CollisionBounds_ColorGammaA_Int32;
        public object k_pch_Camera_Section;
        public object k_pch_Camera_EnableCamera_Bool;
        public object k_pch_Camera_EnableCameraInDashboard_Bool;
        public object k_pch_Camera_EnableCameraForCollisionBounds_Bool;
        public object k_pch_Camera_EnableCameraForRoomView_Bool;
        public object k_pch_Camera_BoundsColorGammaR_Int32;
        public object k_pch_Camera_BoundsColorGammaG_Int32;
        public object k_pch_Camera_BoundsColorGammaB_Int32;
        public object k_pch_Camera_BoundsColorGammaA_Int32;
        public object k_pch_Camera_BoundsStrength_Int32;
        public object k_pch_Camera_RoomViewMode_Int32;
        public object k_pch_audio_Section;
        public object k_pch_audio_OnPlaybackDevice_String;
        public object k_pch_audio_OnRecordDevice_String;
        public object k_pch_audio_OnPlaybackMirrorDevice_String;
        public object k_pch_audio_OffPlaybackDevice_String;
        public object k_pch_audio_OffRecordDevice_String;
        public object k_pch_audio_VIVEHDMIGain;
        public object k_pch_Power_Section;
        public object k_pch_Power_PowerOffOnExit_Bool;
        public object k_pch_Power_TurnOffScreensTimeout_Float;
        public object k_pch_Power_TurnOffControllersTimeout_Float;
        public object k_pch_Power_ReturnToWatchdogTimeout_Float;
        public object k_pch_Power_AutoLaunchSteamVROnButtonPress;
        public object k_pch_Power_PauseCompositorOnStandby_Bool;
        public object k_pch_Dashboard_Section;
        public object k_pch_Dashboard_EnableDashboard_Bool;
        public object k_pch_Dashboard_ArcadeMode_Bool;
        public object k_pch_Dashboard_EnableWebUI;
        public object k_pch_Dashboard_EnableWebUIDevTools;
        public object k_pch_Dashboard_EnableWebUIDashboardReplacement;
        public object k_pch_modelskin_Section;
        public object k_pch_Driver_Enable_Bool;
        public object k_pch_WebInterface_Section;
        public object k_pch_WebInterface_WebEnable_Bool;
        public object k_pch_WebInterface_WebPort_String;
        public object k_pch_TrackingOverride_Section;
        public object k_pch_App_BindingAutosaveURLSuffix_String;
        public object k_pch_App_BindingCurrentURLSuffix_String;
        public object k_pch_App_NeedToUpdateAutosaveSuffix_Bool;
        public object k_pch_App_ActionManifestURL_String;
        public object k_pch_Trackers_Section;
        public object IVRScreenshots_Version;
        public object IVRResources_Version;
        public object IVRDriverManager_Version;
        public object k_unMaxActionNameLength;
        public object k_unMaxActionSetNameLength;
        public object k_unMaxActionOriginCount;
        public object IVRInput_Version;
        public object k_ulInvalidIOBufferHandle;
        public object IVRIOBuffer_Version;
        public object k_ulInvalidSpatialAnchorHandle;
        public object IVRSpatialAnchors_Version;
        public object _vRToken;
        public object FnTable_Prefix;
        public object _OpenVRInternal_ModuleContext;

        // ── Methods ──
        public void InitInternal(){} // RVA: 0x6C5D150
        public void InitInternal2(){} // RVA: 0x6C5D190
        public void ShutdownInternal(){} // RVA: 0x6C5D210
        public void IsHmdPresent(){} // RVA: 0x6C5D240
        public void IsRuntimeInstalled(){} // RVA: 0x6C5D270
        public void GetStringForHmdError(){} // RVA: 0x6C5DF20
        public void GetGenericInterface(){} // RVA: 0x6C5D2D0
        public void IsInterfaceVersionValid(){} // RVA: 0x6C5D330
        public void GetInitToken(){} // RVA: 0x6C5D390
        public void get_VRToken(){} // RVA: 0x6C5DFB0
        public void set_VRToken(){} // RVA: 0x6C5DFF0
        public void get_OpenVRInternal_ModuleContext(){} // RVA: 0x6C5E030
        public void get_System(){} // RVA: 0x6C5E130
        public void get_Chaperone(){} // RVA: 0x6C5E160
        public void get_ChaperoneSetup(){} // RVA: 0x6C5E190
        public void get_Compositor(){} // RVA: 0x6C5E1C0
        public void get_Overlay(){} // RVA: 0x6C5E1F0
        public void get_RenderModels(){} // RVA: 0x6C5E220
        public void get_ExtendedDisplay(){} // RVA: 0x6C5E250
        public void get_Settings(){} // RVA: 0x6C5E280
        public void get_Applications(){} // RVA: 0x6C5E2B0
        public void get_Screenshots(){} // RVA: 0x6C5E2E0
        public void get_TrackedCamera(){} // RVA: 0x6C5E310
        public void get_Input(){} // RVA: 0x6C5E340
        public void get_SpatialAnchors(){} // RVA: 0x6C5E370
        public void Init(){} // RVA: 0x6C5E3A0
        public void Shutdown(){} // RVA: 0x6C5D210
        public void .ctor(){} // RVA: 0xB43310
    }

    public class OpenVRInterop : Object
    {
        // ── Methods ──
        public void InitInternal(){} // RVA: 0x6C5D150
        public void InitInternal2(){} // RVA: 0x6C5D190
        public void ShutdownInternal(){} // RVA: 0x6C5D210
        public void IsHmdPresent(){} // RVA: 0x6C5D240
        public void IsRuntimeInstalled(){} // RVA: 0x6C5D270
        public void GetStringForHmdError(){} // RVA: 0x6C5D2A0
        public void GetGenericInterface(){} // RVA: 0x6C5D2D0
        public void IsInterfaceVersionValid(){} // RVA: 0x6C5D330
        public void GetInitToken(){} // RVA: 0x6C5D390
        public void .ctor(){} // RVA: 0xB43310
    }

    public class RenderModel_TextureMap_t_Packed : ValueType
    {
        public object unWidth;
        public object unHeight;
        public object rubTextureMapData;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8E3880
        public void Unpack(){} // RVA: 0x8E38A0
    }

    public class RenderModel_t_Packed : ValueType
    {
        public object rVertexData;
        public object unVertexCount;
        public object rIndexData;
        public object unTriangleCount;
        public object diffuseTextureId;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8E38C0
        public void Unpack(){} // RVA: 0x8E3900
    }

    public class VRControllerState_t_Packed : ValueType
    {
        public object unPacketNum;
        public object ulButtonPressed;
        public object ulButtonTouched;
        public object rAxis0;
        public object rAxis1;
        public object rAxis2;
        public object rAxis3;
        public object rAxis4;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8E3760
        public void Unpack(){} // RVA: 0x8E3800
    }

    public class VREvent_Keyboard_t : ValueType
    {
        public object cNewInput0;
        public object cNewInput1;
        public object cNewInput2;
        public object cNewInput3;
        public object cNewInput4;
        public object cNewInput5;
        public object cNewInput6;
        public object cNewInput7;
        public object uUserValue;

        // ── Methods ──
        public void get_cNewInput(){} // RVA: 0x8E35B0
    }

    public class VREvent_t_Packed : ValueType
    {
        public object eventType;
        public object trackedDeviceIndex;
        public object eventAgeSeconds;
        public object data;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8E36F0
        public void Unpack(){} // RVA: 0x8E3730
    }

}