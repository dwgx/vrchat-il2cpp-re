// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.OVR.OpenVR
// Classes: 25
// Methods: 1

namespace ThirdParty.Other.OVR.OpenVR
{
    public class IVRApplications : ValueType
    {
        public _AddApplicationManifest AddApplicationManifest; // 0x10
        public _RemoveApplicationManifest RemoveApplicationManifest; // 0x18
        public _IsApplicationInstalled IsApplicationInstalled; // 0x20
        public _GetApplicationCount GetApplicationCount; // 0x28
        public _GetApplicationKeyByIndex GetApplicationKeyByIndex; // 0x30
        public _GetApplicationKeyByProcessId GetApplicationKeyByProcessId; // 0x38
        public _LaunchApplication LaunchApplication; // 0x40
        public _LaunchTemplateApplication LaunchTemplateApplication; // 0x48
        public _LaunchApplicationFromMimeType LaunchApplicationFromMimeType; // 0x50
        public _LaunchDashboardOverlay LaunchDashboardOverlay; // 0x58
        public _CancelApplicationLaunch CancelApplicationLaunch; // 0x60
        public _IdentifyApplication IdentifyApplication; // 0x68
        public _GetApplicationProcessId GetApplicationProcessId; // 0x70
        public _GetApplicationsErrorNameFromEnum GetApplicationsErrorNameFromEnum; // 0x78
        public _GetApplicationPropertyString GetApplicationPropertyString; // 0x80
        public _GetApplicationPropertyBool GetApplicationPropertyBool; // 0x88
        public _GetApplicationPropertyUint64 GetApplicationPropertyUint64; // 0x90
        public _SetApplicationAutoLaunch SetApplicationAutoLaunch; // 0x98
        public _GetApplicationAutoLaunch GetApplicationAutoLaunch; // 0xA0
        public _SetDefaultApplicationForMimeType SetDefaultApplicationForMimeType; // 0xA8
        public _GetDefaultApplicationForMimeType GetDefaultApplicationForMimeType; // 0xB0
        public _GetApplicationSupportedMimeTypes GetApplicationSupportedMimeTypes; // 0xB8
        public _GetApplicationsThatSupportMimeType GetApplicationsThatSupportMimeType; // 0xC0
        public _GetApplicationLaunchArguments GetApplicationLaunchArguments; // 0xC8
        public _GetStartingApplication GetStartingApplication; // 0xD0
        public _GetTransitionState GetTransitionState; // 0xD8
        public _PerformApplicationPrelaunchCheck PerformApplicationPrelaunchCheck; // 0xE0
        public _GetApplicationsTransitionStateNameFromEnum GetApplicationsTransitionStateNameFromEnum; // 0xE8
        public _IsQuitUserPromptRequested IsQuitUserPromptRequested; // 0xF0
        public _LaunchInternalProcess LaunchInternalProcess; // 0xF8
        public _GetCurrentSceneProcessId GetCurrentSceneProcessId; // 0x100
    }

    public class IVRChaperone : ValueType
    {
        public _GetCalibrationState GetCalibrationState; // 0x10
        public _GetPlayAreaSize GetPlayAreaSize; // 0x18
        public _GetPlayAreaRect GetPlayAreaRect; // 0x20
        public _ReloadInfo ReloadInfo; // 0x28
        public _SetSceneColor SetSceneColor; // 0x30
        public _GetBoundsColor GetBoundsColor; // 0x38
        public _AreBoundsVisible AreBoundsVisible; // 0x40
        public _ForceBoundsVisible ForceBoundsVisible; // 0x48
    }

    public class IVRChaperoneSetup : ValueType
    {
        public _CommitWorkingCopy CommitWorkingCopy; // 0x10
        public _RevertWorkingCopy RevertWorkingCopy; // 0x18
        public _GetWorkingPlayAreaSize GetWorkingPlayAreaSize; // 0x20
        public _GetWorkingPlayAreaRect GetWorkingPlayAreaRect; // 0x28
        public _GetWorkingCollisionBoundsInfo GetWorkingCollisionBoundsInfo; // 0x30
        public _GetLiveCollisionBoundsInfo GetLiveCollisionBoundsInfo; // 0x38
        public _GetWorkingSeatedZeroPoseToRawTrackingPose GetWorkingSeatedZeroPoseToRawTrackingPose; // 0x40
        public _GetWorkingStandingZeroPoseToRawTrackingPose GetWorkingStandingZeroPoseToRawTrackingPose; // 0x48
        public _SetWorkingPlayAreaSize SetWorkingPlayAreaSize; // 0x50
        public _SetWorkingCollisionBoundsInfo SetWorkingCollisionBoundsInfo; // 0x58
        public _SetWorkingSeatedZeroPoseToRawTrackingPose SetWorkingSeatedZeroPoseToRawTrackingPose; // 0x60
        public _SetWorkingStandingZeroPoseToRawTrackingPose SetWorkingStandingZeroPoseToRawTrackingPose; // 0x68
        public _ReloadFromDisk ReloadFromDisk; // 0x70
        public _GetLiveSeatedZeroPoseToRawTrackingPose GetLiveSeatedZeroPoseToRawTrackingPose; // 0x78
        public _SetWorkingCollisionBoundsTagsInfo SetWorkingCollisionBoundsTagsInfo; // 0x80
        public _GetLiveCollisionBoundsTagsInfo GetLiveCollisionBoundsTagsInfo; // 0x88
        public _SetWorkingPhysicalBoundsInfo SetWorkingPhysicalBoundsInfo; // 0x90
        public _GetLivePhysicalBoundsInfo GetLivePhysicalBoundsInfo; // 0x98
        public _ExportLiveToBuffer ExportLiveToBuffer; // 0xA0
        public _ImportFromBufferToWorking ImportFromBufferToWorking; // 0xA8
    }

    public class IVRCompositor : ValueType
    {
        public _SetTrackingSpace SetTrackingSpace; // 0x10
        public _GetTrackingSpace GetTrackingSpace; // 0x18
        public _WaitGetPoses WaitGetPoses; // 0x20
        public _GetLastPoses GetLastPoses; // 0x28
        public _GetLastPoseForTrackedDeviceIndex GetLastPoseForTrackedDeviceIndex; // 0x30
        public _Submit Submit; // 0x38
        public _ClearLastSubmittedFrame ClearLastSubmittedFrame; // 0x40
        public _PostPresentHandoff PostPresentHandoff; // 0x48
        public _GetFrameTiming GetFrameTiming; // 0x50
        public _GetFrameTimings GetFrameTimings; // 0x58
        public _GetFrameTimeRemaining GetFrameTimeRemaining; // 0x60
        public _GetCumulativeStats GetCumulativeStats; // 0x68
        public _FadeToColor FadeToColor; // 0x70
        public _GetCurrentFadeColor GetCurrentFadeColor; // 0x78
        public _FadeGrid FadeGrid; // 0x80
        public _GetCurrentGridAlpha GetCurrentGridAlpha; // 0x88
        public _SetSkyboxOverride SetSkyboxOverride; // 0x90
        public _ClearSkyboxOverride ClearSkyboxOverride; // 0x98
        public _CompositorBringToFront CompositorBringToFront; // 0xA0
        public _CompositorGoToBack CompositorGoToBack; // 0xA8
        public _CompositorQuit CompositorQuit; // 0xB0
        public _IsFullscreen IsFullscreen; // 0xB8
        public _GetCurrentSceneFocusProcess GetCurrentSceneFocusProcess; // 0xC0
        public _GetLastFrameRenderer GetLastFrameRenderer; // 0xC8
        public _CanRenderScene CanRenderScene; // 0xD0
        public _ShowMirrorWindow ShowMirrorWindow; // 0xD8
        public _HideMirrorWindow HideMirrorWindow; // 0xE0
        public _IsMirrorWindowVisible IsMirrorWindowVisible; // 0xE8
        public _CompositorDumpImages CompositorDumpImages; // 0xF0
        public _ShouldAppRenderWithLowResources ShouldAppRenderWithLowResources; // 0xF8
        public _ForceInterleavedReprojectionOn ForceInterleavedReprojectionOn; // 0x100
        public _ForceReconnectProcess ForceReconnectProcess; // 0x108
        public _SuspendRendering SuspendRendering; // 0x110
        public _GetMirrorTextureD3D11 GetMirrorTextureD3D11; // 0x118
        public _ReleaseMirrorTextureD3D11 ReleaseMirrorTextureD3D11; // 0x120
        public _GetMirrorTextureGL GetMirrorTextureGL; // 0x128
        public _ReleaseSharedGLTexture ReleaseSharedGLTexture; // 0x130
        public _LockGLSharedTextureForAccess LockGLSharedTextureForAccess; // 0x138
        public _UnlockGLSharedTextureForAccess UnlockGLSharedTextureForAccess; // 0x140
        public _GetVulkanInstanceExtensionsRequired GetVulkanInstanceExtensionsRequired; // 0x148
        public _GetVulkanDeviceExtensionsRequired GetVulkanDeviceExtensionsRequired; // 0x150
        public _SetExplicitTimingMode SetExplicitTimingMode; // 0x158
        public _SubmitExplicitTimingData SubmitExplicitTimingData; // 0x160
    }

    public class IVRDriverManager : ValueType
    {
        public _GetDriverCount GetDriverCount; // 0x10
        public _GetDriverName GetDriverName; // 0x18
        public _GetDriverHandle GetDriverHandle; // 0x20
    }

    public class IVRExtendedDisplay : ValueType
    {
        public _GetWindowBounds GetWindowBounds; // 0x10
        public _GetEyeOutputViewport GetEyeOutputViewport; // 0x18
        public _GetDXGIOutputInfo GetDXGIOutputInfo; // 0x20
    }

    public class IVRIOBuffer : ValueType
    {
        public _Open Open; // 0x10
        public _Close Close; // 0x18
        public _Read Read; // 0x20
        public _Write Write; // 0x28
        public _PropertyContainer PropertyContainer; // 0x30
    }

    public class IVRInput : ValueType
    {
        public _SetActionManifestPath SetActionManifestPath; // 0x10
        public _GetActionSetHandle GetActionSetHandle; // 0x18
        public _GetActionHandle GetActionHandle; // 0x20
        public _GetInputSourceHandle GetInputSourceHandle; // 0x28
        public _UpdateActionState UpdateActionState; // 0x30
        public _GetDigitalActionData GetDigitalActionData; // 0x38
        public _GetAnalogActionData GetAnalogActionData; // 0x40
        public _GetPoseActionData GetPoseActionData; // 0x48
        public _GetSkeletalActionData GetSkeletalActionData; // 0x50
        public _GetSkeletalBoneData GetSkeletalBoneData; // 0x58
        public _GetSkeletalBoneDataCompressed GetSkeletalBoneDataCompressed; // 0x60
        public _DecompressSkeletalBoneData DecompressSkeletalBoneData; // 0x68
        public _TriggerHapticVibrationAction TriggerHapticVibrationAction; // 0x70
        public _GetActionOrigins GetActionOrigins; // 0x78
        public _GetOriginLocalizedName GetOriginLocalizedName; // 0x80
        public _GetOriginTrackedDeviceInfo GetOriginTrackedDeviceInfo; // 0x88
        public _ShowActionOrigins ShowActionOrigins; // 0x90
        public _ShowBindingsForActionSet ShowBindingsForActionSet; // 0x98
    }

    public class IVRNotifications : ValueType
    {
        public _CreateNotification CreateNotification; // 0x10
        public _RemoveNotification RemoveNotification; // 0x18
    }

    public class IVROverlay : ValueType
    {
        public _FindOverlay FindOverlay; // 0x10
        public _CreateOverlay CreateOverlay; // 0x18
        public _DestroyOverlay DestroyOverlay; // 0x20
        public _SetHighQualityOverlay SetHighQualityOverlay; // 0x28
        public _GetHighQualityOverlay GetHighQualityOverlay; // 0x30
        public _GetOverlayKey GetOverlayKey; // 0x38
        public _GetOverlayName GetOverlayName; // 0x40
        public _SetOverlayName SetOverlayName; // 0x48
        public _GetOverlayImageData GetOverlayImageData; // 0x50
        public _GetOverlayErrorNameFromEnum GetOverlayErrorNameFromEnum; // 0x58
        public _SetOverlayRenderingPid SetOverlayRenderingPid; // 0x60
        public _GetOverlayRenderingPid GetOverlayRenderingPid; // 0x68
        public _SetOverlayFlag SetOverlayFlag; // 0x70
        public _GetOverlayFlag GetOverlayFlag; // 0x78
        public _SetOverlayColor SetOverlayColor; // 0x80
        public _GetOverlayColor GetOverlayColor; // 0x88
        public _SetOverlayAlpha SetOverlayAlpha; // 0x90
        public _GetOverlayAlpha GetOverlayAlpha; // 0x98
        public _SetOverlayTexelAspect SetOverlayTexelAspect; // 0xA0
        public _GetOverlayTexelAspect GetOverlayTexelAspect; // 0xA8
        public _SetOverlaySortOrder SetOverlaySortOrder; // 0xB0
        public _GetOverlaySortOrder GetOverlaySortOrder; // 0xB8
        public _SetOverlayWidthInMeters SetOverlayWidthInMeters; // 0xC0
        public _GetOverlayWidthInMeters GetOverlayWidthInMeters; // 0xC8
        public _SetOverlayAutoCurveDistanceRangeInMeters SetOverlayAutoCurveDistanceRangeInMeters; // 0xD0
        public _GetOverlayAutoCurveDistanceRangeInMeters GetOverlayAutoCurveDistanceRangeInMeters; // 0xD8
        public _SetOverlayTextureColorSpace SetOverlayTextureColorSpace; // 0xE0
        public _GetOverlayTextureColorSpace GetOverlayTextureColorSpace; // 0xE8
        public _SetOverlayTextureBounds SetOverlayTextureBounds; // 0xF0
        public _GetOverlayTextureBounds GetOverlayTextureBounds; // 0xF8
        public _GetOverlayRenderModel GetOverlayRenderModel; // 0x100
        public _SetOverlayRenderModel SetOverlayRenderModel; // 0x108
        public _GetOverlayTransformType GetOverlayTransformType; // 0x110
        public _SetOverlayTransformAbsolute SetOverlayTransformAbsolute; // 0x118
        public _GetOverlayTransformAbsolute GetOverlayTransformAbsolute; // 0x120
        public _SetOverlayTransformTrackedDeviceRelative SetOverlayTransformTrackedDeviceRelative; // 0x128
        public _GetOverlayTransformTrackedDeviceRelative GetOverlayTransformTrackedDeviceRelative; // 0x130
        public _SetOverlayTransformTrackedDeviceComponent SetOverlayTransformTrackedDeviceComponent; // 0x138
        public _GetOverlayTransformTrackedDeviceComponent GetOverlayTransformTrackedDeviceComponent; // 0x140
        public _GetOverlayTransformOverlayRelative GetOverlayTransformOverlayRelative; // 0x148
        public _SetOverlayTransformOverlayRelative SetOverlayTransformOverlayRelative; // 0x150
        public _ShowOverlay ShowOverlay; // 0x158
        public _HideOverlay HideOverlay; // 0x160
        public _IsOverlayVisible IsOverlayVisible; // 0x168
        public _GetTransformForOverlayCoordinates GetTransformForOverlayCoordinates; // 0x170
        public _PollNextOverlayEvent PollNextOverlayEvent; // 0x178
        public _GetOverlayInputMethod GetOverlayInputMethod; // 0x180
        public _SetOverlayInputMethod SetOverlayInputMethod; // 0x188
        public _GetOverlayMouseScale GetOverlayMouseScale; // 0x190
        public _SetOverlayMouseScale SetOverlayMouseScale; // 0x198
        public _ComputeOverlayIntersection ComputeOverlayIntersection; // 0x1A0
        public _IsHoverTargetOverlay IsHoverTargetOverlay; // 0x1A8
        public _GetGamepadFocusOverlay GetGamepadFocusOverlay; // 0x1B0
        public _SetGamepadFocusOverlay SetGamepadFocusOverlay; // 0x1B8
        public _SetOverlayNeighbor SetOverlayNeighbor; // 0x1C0
        public _MoveGamepadFocusToNeighbor MoveGamepadFocusToNeighbor; // 0x1C8
        public _SetOverlayDualAnalogTransform SetOverlayDualAnalogTransform; // 0x1D0
        public _GetOverlayDualAnalogTransform GetOverlayDualAnalogTransform; // 0x1D8
        public _SetOverlayTexture SetOverlayTexture; // 0x1E0
        public _ClearOverlayTexture ClearOverlayTexture; // 0x1E8
        public _SetOverlayRaw SetOverlayRaw; // 0x1F0
        public _SetOverlayFromFile SetOverlayFromFile; // 0x1F8
        public _GetOverlayTexture GetOverlayTexture; // 0x200
        public _ReleaseNativeOverlayHandle ReleaseNativeOverlayHandle; // 0x208
        public _GetOverlayTextureSize GetOverlayTextureSize; // 0x210
        public _CreateDashboardOverlay CreateDashboardOverlay; // 0x218
        public _IsDashboardVisible IsDashboardVisible; // 0x220
        public _IsActiveDashboardOverlay IsActiveDashboardOverlay; // 0x228
        public _SetDashboardOverlaySceneProcess SetDashboardOverlaySceneProcess; // 0x230
        public _GetDashboardOverlaySceneProcess GetDashboardOverlaySceneProcess; // 0x238
        public _ShowDashboard ShowDashboard; // 0x240
        public _GetPrimaryDashboardDevice GetPrimaryDashboardDevice; // 0x248
        public _ShowKeyboard ShowKeyboard; // 0x250
        public _ShowKeyboardForOverlay ShowKeyboardForOverlay; // 0x258
        public _GetKeyboardText GetKeyboardText; // 0x260
        public _HideKeyboard HideKeyboard; // 0x268
        public _SetKeyboardTransformAbsolute SetKeyboardTransformAbsolute; // 0x270
        public _SetKeyboardPositionForOverlay SetKeyboardPositionForOverlay; // 0x278
        public _SetOverlayIntersectionMask SetOverlayIntersectionMask; // 0x280
        public _GetOverlayFlags GetOverlayFlags; // 0x288
        public _ShowMessageOverlay ShowMessageOverlay; // 0x290
        public _CloseMessageOverlay CloseMessageOverlay; // 0x298
    }

    public class IVRRenderModels : ValueType
    {
        public _LoadRenderModel_Async LoadRenderModel_Async; // 0x10
        public _FreeRenderModel FreeRenderModel; // 0x18
        public _LoadTexture_Async LoadTexture_Async; // 0x20
        public _FreeTexture FreeTexture; // 0x28
        public _LoadTextureD3D11_Async LoadTextureD3D11_Async; // 0x30
        public _LoadIntoTextureD3D11_Async LoadIntoTextureD3D11_Async; // 0x38
        public _FreeTextureD3D11 FreeTextureD3D11; // 0x40
        public _GetRenderModelName GetRenderModelName; // 0x48
        public _GetRenderModelCount GetRenderModelCount; // 0x50
        public _GetComponentCount GetComponentCount; // 0x58
        public _GetComponentName GetComponentName; // 0x60
        public _GetComponentButtonMask GetComponentButtonMask; // 0x68
        public _GetComponentRenderModelName GetComponentRenderModelName; // 0x70
        public _GetComponentStateForDevicePath GetComponentStateForDevicePath; // 0x78
        public _GetComponentState GetComponentState; // 0x80
        public _RenderModelHasComponent RenderModelHasComponent; // 0x88
        public _GetRenderModelThumbnailURL GetRenderModelThumbnailURL; // 0x90
        public _GetRenderModelOriginalPath GetRenderModelOriginalPath; // 0x98
        public _GetRenderModelErrorNameFromEnum GetRenderModelErrorNameFromEnum; // 0xA0
    }

    public class IVRResources : ValueType
    {
        public _LoadSharedResource LoadSharedResource; // 0x10
        public _GetResourceFullPath GetResourceFullPath; // 0x18
    }

    public class IVRScreenshots : ValueType
    {
        public _RequestScreenshot RequestScreenshot; // 0x10
        public _HookScreenshot HookScreenshot; // 0x18
        public _GetScreenshotPropertyType GetScreenshotPropertyType; // 0x20
        public _GetScreenshotPropertyFilename GetScreenshotPropertyFilename; // 0x28
        public _UpdateScreenshotProgress UpdateScreenshotProgress; // 0x30
        public _TakeStereoScreenshot TakeStereoScreenshot; // 0x38
        public _SubmitScreenshot SubmitScreenshot; // 0x40
    }

    public class IVRSettings : ValueType
    {
        public _GetSettingsErrorNameFromEnum GetSettingsErrorNameFromEnum; // 0x10
        public _Sync Sync; // 0x18
        public _SetBool SetBool; // 0x20
        public _SetInt32 SetInt32; // 0x28
        public _SetFloat SetFloat; // 0x30
        public _SetString SetString; // 0x38
        public _GetBool GetBool; // 0x40
        public _GetInt32 GetInt32; // 0x48
        public _GetFloat GetFloat; // 0x50
        public _GetString GetString; // 0x58
        public _RemoveSection RemoveSection; // 0x60
        public _RemoveKeyInSection RemoveKeyInSection; // 0x68
    }

    public class IVRSpatialAnchors : ValueType
    {
        public _CreateSpatialAnchorFromDescriptor CreateSpatialAnchorFromDescriptor; // 0x10
        public _CreateSpatialAnchorFromPose CreateSpatialAnchorFromPose; // 0x18
        public _GetSpatialAnchorPose GetSpatialAnchorPose; // 0x20
        public _GetSpatialAnchorDescriptor GetSpatialAnchorDescriptor; // 0x28
    }

    public class IVRSystem : ValueType
    {
        public _GetRecommendedRenderTargetSize GetRecommendedRenderTargetSize; // 0x10
        public _GetProjectionMatrix GetProjectionMatrix; // 0x18
        public _GetProjectionRaw GetProjectionRaw; // 0x20
        public _ComputeDistortion ComputeDistortion; // 0x28
        public _GetEyeToHeadTransform GetEyeToHeadTransform; // 0x30
        public _GetTimeSinceLastVsync GetTimeSinceLastVsync; // 0x38
        public _GetD3D9AdapterIndex GetD3D9AdapterIndex; // 0x40
        public _GetDXGIOutputInfo GetDXGIOutputInfo; // 0x48
        public _GetOutputDevice GetOutputDevice; // 0x50
        public _IsDisplayOnDesktop IsDisplayOnDesktop; // 0x58
        public _SetDisplayVisibility SetDisplayVisibility; // 0x60
        public _GetDeviceToAbsoluteTrackingPose GetDeviceToAbsoluteTrackingPose; // 0x68
        public _ResetSeatedZeroPose ResetSeatedZeroPose; // 0x70
        public _GetSeatedZeroPoseToStandingAbsoluteTrackingPose GetSeatedZeroPoseToStandingAbsoluteTrackingPose; // 0x78
        public _GetRawZeroPoseToStandingAbsoluteTrackingPose GetRawZeroPoseToStandingAbsoluteTrackingPose; // 0x80
        public _GetSortedTrackedDeviceIndicesOfClass GetSortedTrackedDeviceIndicesOfClass; // 0x88
        public _GetTrackedDeviceActivityLevel GetTrackedDeviceActivityLevel; // 0x90
        public _ApplyTransform ApplyTransform; // 0x98
        public _GetTrackedDeviceIndexForControllerRole GetTrackedDeviceIndexForControllerRole; // 0xA0
        public _GetControllerRoleForTrackedDeviceIndex GetControllerRoleForTrackedDeviceIndex; // 0xA8
        public _GetTrackedDeviceClass GetTrackedDeviceClass; // 0xB0
        public _IsTrackedDeviceConnected IsTrackedDeviceConnected; // 0xB8
        public _GetBoolTrackedDeviceProperty GetBoolTrackedDeviceProperty; // 0xC0
        public _GetFloatTrackedDeviceProperty GetFloatTrackedDeviceProperty; // 0xC8
        public _GetInt32TrackedDeviceProperty GetInt32TrackedDeviceProperty; // 0xD0
        public _GetUint64TrackedDeviceProperty GetUint64TrackedDeviceProperty; // 0xD8
        public _GetMatrix34TrackedDeviceProperty GetMatrix34TrackedDeviceProperty; // 0xE0
        public _GetArrayTrackedDeviceProperty GetArrayTrackedDeviceProperty; // 0xE8
        public _GetStringTrackedDeviceProperty GetStringTrackedDeviceProperty; // 0xF0
        public _GetPropErrorNameFromEnum GetPropErrorNameFromEnum; // 0xF8
        public _PollNextEvent PollNextEvent; // 0x100
        public _PollNextEventWithPose PollNextEventWithPose; // 0x108
        public _GetEventTypeNameFromEnum GetEventTypeNameFromEnum; // 0x110
        public _GetHiddenAreaMesh GetHiddenAreaMesh; // 0x118
        public _GetControllerState GetControllerState; // 0x120
        public _GetControllerStateWithPose GetControllerStateWithPose; // 0x128
        public _TriggerHapticPulse TriggerHapticPulse; // 0x130
        public _GetButtonIdNameFromEnum GetButtonIdNameFromEnum; // 0x138
        public _GetControllerAxisTypeNameFromEnum GetControllerAxisTypeNameFromEnum; // 0x140
        public _IsInputAvailable IsInputAvailable; // 0x148
        public _IsSteamVRDrawingControllers IsSteamVRDrawingControllers; // 0x150
        public _ShouldApplicationPause ShouldApplicationPause; // 0x158
        public _ShouldApplicationReduceRenderingWork ShouldApplicationReduceRenderingWork; // 0x160
        public _DriverDebugRequest DriverDebugRequest; // 0x168
        public _PerformFirmwareUpdate PerformFirmwareUpdate; // 0x170
        public _AcknowledgeQuit_Exiting AcknowledgeQuit_Exiting; // 0x178
        public _AcknowledgeQuit_UserPrompt AcknowledgeQuit_UserPrompt; // 0x180
    }

    public class IVRTrackedCamera : ValueType
    {
        public _GetCameraErrorNameFromEnum GetCameraErrorNameFromEnum; // 0x10
        public _HasCamera HasCamera; // 0x18
        public _GetCameraFrameSize GetCameraFrameSize; // 0x20
        public _GetCameraIntrinsics GetCameraIntrinsics; // 0x28
        public _GetCameraProjection GetCameraProjection; // 0x30
        public _AcquireVideoStreamingService AcquireVideoStreamingService; // 0x38
        public _ReleaseVideoStreamingService ReleaseVideoStreamingService; // 0x40
        public _GetVideoStreamFrameBuffer GetVideoStreamFrameBuffer; // 0x48
        public _GetVideoStreamTextureSize GetVideoStreamTextureSize; // 0x50
        public _GetVideoStreamTextureD3D11 GetVideoStreamTextureD3D11; // 0x58
        public _GetVideoStreamTextureGL GetVideoStreamTextureGL; // 0x60
        public _ReleaseVideoStreamTextureGL ReleaseVideoStreamTextureGL; // 0x68
    }

    public class ImuSample_t : ValueType
    {
        public double fSampleTime; // 0x10
        public OVR.OpenVR.HmdVector3d_t vAccel; // 0x18
        public OVR.OpenVR.HmdVector3d_t vGyro; // 0x30
        public uint unOffScaleFlags; // 0x48
    }

    public class InputAnalogActionData_t : ValueType
    {
        public bool bActive; // 0x10
        public ulong activeOrigin; // 0x18
        public float x; // 0x20
        public float y; // 0x24
        public float z; // 0x28
        public float deltaX; // 0x2C
        public float deltaY; // 0x30
        public float deltaZ; // 0x34
        public float fUpdateTime; // 0x38
    }

    public class InputDigitalActionData_t : ValueType
    {
        public bool bActive; // 0x10
        public ulong activeOrigin; // 0x18
        public bool bState; // 0x20
        public bool bChanged; // 0x21
        public float fUpdateTime; // 0x24
    }

    public class InputOriginInfo_t : ValueType
    {
        public ulong rchRenderModelComponentName; // 0x10
        public uint trackedDeviceIndex; // 0x18
        public byte rchRenderModelComponentName0; // 0x1C
        public byte rchRenderModelComponentName1; // 0x1D
        public byte rchRenderModelComponentName2; // 0x1E
        public byte rchRenderModelComponentName3; // 0x1F
        public byte rchRenderModelComponentName4; // 0x20
        public byte rchRenderModelComponentName5; // 0x21
        public byte rchRenderModelComponentName6; // 0x22
        public byte rchRenderModelComponentName7; // 0x23
        public byte rchRenderModelComponentName8; // 0x24
        public byte rchRenderModelComponentName9; // 0x25
        public byte rchRenderModelComponentName10; // 0x26
        public byte rchRenderModelComponentName11; // 0x27
        public byte rchRenderModelComponentName12; // 0x28
        public byte rchRenderModelComponentName13; // 0x29
        public byte rchRenderModelComponentName14; // 0x2A
        public byte rchRenderModelComponentName15; // 0x2B
        public byte rchRenderModelComponentName16; // 0x2C
        public byte rchRenderModelComponentName17; // 0x2D
        public byte rchRenderModelComponentName18; // 0x2E
        public byte rchRenderModelComponentName19; // 0x2F
        public byte rchRenderModelComponentName20; // 0x30
        public byte rchRenderModelComponentName21; // 0x31
        public byte rchRenderModelComponentName22; // 0x32
        public byte rchRenderModelComponentName23; // 0x33
        public byte rchRenderModelComponentName24; // 0x34
        public byte rchRenderModelComponentName25; // 0x35
        public byte rchRenderModelComponentName26; // 0x36
        public byte rchRenderModelComponentName27; // 0x37
        public byte rchRenderModelComponentName28; // 0x38
        public byte rchRenderModelComponentName29; // 0x39
        public byte rchRenderModelComponentName30; // 0x3A
        public byte rchRenderModelComponentName31; // 0x3B
        public byte rchRenderModelComponentName32; // 0x3C
        public byte rchRenderModelComponentName33; // 0x3D
        public byte rchRenderModelComponentName34; // 0x3E
        public byte rchRenderModelComponentName35; // 0x3F
        public byte rchRenderModelComponentName36; // 0x40
        public byte rchRenderModelComponentName37; // 0x41
        public byte rchRenderModelComponentName38; // 0x42
        public byte rchRenderModelComponentName39; // 0x43
        public byte rchRenderModelComponentName40; // 0x44
        public byte rchRenderModelComponentName41; // 0x45
        public byte rchRenderModelComponentName42; // 0x46
        public byte rchRenderModelComponentName43; // 0x47
        public byte rchRenderModelComponentName44; // 0x48
        public byte rchRenderModelComponentName45; // 0x49
        public byte rchRenderModelComponentName46; // 0x4A
        public byte rchRenderModelComponentName47; // 0x4B
        public byte rchRenderModelComponentName48; // 0x4C
        public byte rchRenderModelComponentName49; // 0x4D
        public byte rchRenderModelComponentName50; // 0x4E
        public byte rchRenderModelComponentName51; // 0x4F
        public byte rchRenderModelComponentName52; // 0x50
        public byte rchRenderModelComponentName53; // 0x51
        public byte rchRenderModelComponentName54; // 0x52
        public byte rchRenderModelComponentName55; // 0x53
        public byte rchRenderModelComponentName56; // 0x54
        public byte rchRenderModelComponentName57; // 0x55
        public byte rchRenderModelComponentName58; // 0x56
        public byte rchRenderModelComponentName59; // 0x57
        public byte rchRenderModelComponentName60; // 0x58
        public byte rchRenderModelComponentName61; // 0x59
        public byte rchRenderModelComponentName62; // 0x5A
        public byte rchRenderModelComponentName63; // 0x5B
        public byte rchRenderModelComponentName64; // 0x5C
        public byte rchRenderModelComponentName65; // 0x5D
        public byte rchRenderModelComponentName66; // 0x5E
        public byte rchRenderModelComponentName67; // 0x5F
        public byte rchRenderModelComponentName68; // 0x60
        public byte rchRenderModelComponentName69; // 0x61
        public byte rchRenderModelComponentName70; // 0x62
        public byte rchRenderModelComponentName71; // 0x63
        public byte rchRenderModelComponentName72; // 0x64
        public byte rchRenderModelComponentName73; // 0x65
        public byte rchRenderModelComponentName74; // 0x66
        public byte rchRenderModelComponentName75; // 0x67
        public byte rchRenderModelComponentName76; // 0x68
        public byte rchRenderModelComponentName77; // 0x69
        public byte rchRenderModelComponentName78; // 0x6A
        public byte rchRenderModelComponentName79; // 0x6B
        public byte rchRenderModelComponentName80; // 0x6C
        public byte rchRenderModelComponentName81; // 0x6D
        public byte rchRenderModelComponentName82; // 0x6E
        public byte rchRenderModelComponentName83; // 0x6F
        public byte rchRenderModelComponentName84; // 0x70
        public byte rchRenderModelComponentName85; // 0x71
        public byte rchRenderModelComponentName86; // 0x72
        public byte rchRenderModelComponentName87; // 0x73
        public byte rchRenderModelComponentName88; // 0x74
        public byte rchRenderModelComponentName89; // 0x75
        public byte rchRenderModelComponentName90; // 0x76
        public byte rchRenderModelComponentName91; // 0x77
        public byte rchRenderModelComponentName92; // 0x78
        public byte rchRenderModelComponentName93; // 0x79
        public byte rchRenderModelComponentName94; // 0x7A
        public byte rchRenderModelComponentName95; // 0x7B
        public byte rchRenderModelComponentName96; // 0x7C
        public byte rchRenderModelComponentName97; // 0x7D
        public byte rchRenderModelComponentName98; // 0x7E
        public byte rchRenderModelComponentName99; // 0x7F
        public byte rchRenderModelComponentName100; // 0x80
        public byte rchRenderModelComponentName101; // 0x81
        public byte rchRenderModelComponentName102; // 0x82
        public byte rchRenderModelComponentName103; // 0x83
        public byte rchRenderModelComponentName104; // 0x84
        public byte rchRenderModelComponentName105; // 0x85
        public byte rchRenderModelComponentName106; // 0x86
        public byte rchRenderModelComponentName107; // 0x87
        public byte rchRenderModelComponentName108; // 0x88
        public byte rchRenderModelComponentName109; // 0x89
        public byte rchRenderModelComponentName110; // 0x8A
        public byte rchRenderModelComponentName111; // 0x8B
        public byte rchRenderModelComponentName112; // 0x8C
        public byte rchRenderModelComponentName113; // 0x8D
        public byte rchRenderModelComponentName114; // 0x8E
        public byte rchRenderModelComponentName115; // 0x8F
        public byte rchRenderModelComponentName116; // 0x90
        public byte rchRenderModelComponentName117; // 0x91
        public byte rchRenderModelComponentName118; // 0x92
        public byte rchRenderModelComponentName119; // 0x93
        public byte rchRenderModelComponentName120; // 0x94
        public byte rchRenderModelComponentName121; // 0x95
        public byte rchRenderModelComponentName122; // 0x96
        public byte rchRenderModelComponentName123; // 0x97
        public byte rchRenderModelComponentName124; // 0x98
        public byte rchRenderModelComponentName125; // 0x99
        public byte rchRenderModelComponentName126; // 0x9A
        public byte rchRenderModelComponentName127; // 0x9B

        // ── Methods ──
        public void get_rchRenderModelComponentName(){} // RVA: 0x7FFAC8985F70
    }

    public class InputPoseActionData_t : ValueType
    {
        public bool bActive; // 0x10
        public ulong activeOrigin; // 0x18
        public OVR.OpenVR.TrackedDevicePose_t pose; // 0x20
    }

    public class InputSkeletalActionData_t : ValueType
    {
        public bool bActive; // 0x10
        public ulong activeOrigin; // 0x18
        public uint boneCount; // 0x20
    }

    public class IntersectionMaskCircle_t : ValueType
    {
        public float m_flCenterX; // 0x10
        public float m_flCenterY; // 0x14
        public float m_flRadius; // 0x18
    }

    public class IntersectionMaskRectangle_t : ValueType
    {
        public float m_flTopLeftX; // 0x10
        public float m_flTopLeftY; // 0x14
        public float m_flWidth; // 0x18
        public float m_flHeight; // 0x1C
    }

}