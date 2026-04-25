// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.OVR.OpenVR
// Classes: 23
// Methods: 335

namespace ThirdParty.Other.OVR.OpenVR
{
    public class COpenVRContext : ValueType
    {
        public UIntPtr m_pVRSystem; // 0x10
        public UIntPtr m_pVRChaperone; // 0x18
        public UIntPtr m_pVRChaperoneSetup; // 0x20
        public UIntPtr m_pVRCompositor; // 0x28
        public UIntPtr m_pVROverlay; // 0x30
        public UIntPtr m_pVRResources; // 0x38
        public UIntPtr m_pVRRenderModels; // 0x40
        public UIntPtr m_pVRExtendedDisplay; // 0x48
        public UIntPtr m_pVRSettings; // 0x50
        public UIntPtr m_pVRApplications; // 0x58
        public UIntPtr m_pVRTrackedCamera; // 0x60
        public UIntPtr m_pVRScreenshots; // 0x68
        public UIntPtr m_pVRDriverManager; // 0x70
        public UIntPtr m_pVRInput; // 0x78
        public UIntPtr m_pVRIOBuffer; // 0x80
        public UIntPtr m_pVRSpatialAnchors; // 0x88
    }

    public class CVRApplications : Object
    {
        public OVR.OpenVR.IVRApplications FnTable; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8980EF0
        public void AddApplicationManifest(){} // RVA: 0x7FFAC78F7300
        public void RemoveApplicationManifest(){} // RVA: 0x7FFAC3584BC0
        public void IsApplicationInstalled(){} // RVA: 0x7FFAC64FAEC0
        public void GetApplicationCount(){} // RVA: 0x7FFAC6525400
        public void GetApplicationKeyByIndex(){} // RVA: 0x7FFAC8981110
        public void GetApplicationKeyByProcessId(){} // RVA: 0x7FFAC8981140
        public void LaunchApplication(){} // RVA: 0x7FFAC8980DA0
        public void LaunchTemplateApplication(){} // RVA: 0x7FFAC8981170
        public void LaunchApplicationFromMimeType(){} // RVA: 0x7FFAC89811B0
        public void LaunchDashboardOverlay(){} // RVA: 0x7FFAC89811E0
        public void CancelApplicationLaunch(){} // RVA: 0x7FFAC7797E00
        public void IdentifyApplication(){} // RVA: 0x7FFAC8980EC0
        public void GetApplicationProcessId(){} // RVA: 0x7FFAC8981210
        public void GetApplicationsErrorNameFromEnum(){} // RVA: 0x7FFAC8981240
        public void GetApplicationPropertyString(){} // RVA: 0x7FFAC89812F0
        public void GetApplicationPropertyBool(){} // RVA: 0x7FFAC8981330
        public void GetApplicationPropertyUint64(){} // RVA: 0x7FFAC8981360
        public void SetApplicationAutoLaunch(){} // RVA: 0x7FFAC8981390
        public void GetApplicationAutoLaunch(){} // RVA: 0x7FFAC897F5E0
        public void SetDefaultApplicationForMimeType(){} // RVA: 0x7FFAC89813C0
        public void GetDefaultApplicationForMimeType(){} // RVA: 0x7FFAC89813F0
        public void GetApplicationSupportedMimeTypes(){} // RVA: 0x7FFAC8981420
        public void GetApplicationsThatSupportMimeType(){} // RVA: 0x7FFAC897F6A0
        public void GetApplicationLaunchArguments(){} // RVA: 0x7FFAC897F6D0
        public void GetStartingApplication(){} // RVA: 0x7FFAC8981450
        public void GetTransitionState(){} // RVA: 0x7FFAC8981480
        public void PerformApplicationPrelaunchCheck(){} // RVA: 0x7FFAC89814B0
        public void GetApplicationsTransitionStateNameFromEnum(){} // RVA: 0x7FFAC89814E0
        public void IsQuitUserPromptRequested(){} // RVA: 0x7FFAC8981590
        public void LaunchInternalProcess(){} // RVA: 0x7FFAC89815C0
        public void GetCurrentSceneProcessId(){} // RVA: 0x7FFAC89815F0
    }

    public class CVRChaperone : Object
    {
        public OVR.OpenVR.IVRChaperone FnTable; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8981620
        public void GetCalibrationState(){} // RVA: 0x7FFAC3D3B830
        public void GetPlayAreaSize(){} // RVA: 0x7FFAC89817C0
        public void GetPlayAreaRect(){} // RVA: 0x7FFAC64FAEC0
        public void ReloadInfo(){} // RVA: 0x7FFAC6525400
        public void SetSceneColor(){} // RVA: 0x7FFAC89817F0
        public void GetBoundsColor(){} // RVA: 0x7FFAC8981830
        public void AreBoundsVisible(){} // RVA: 0x7FFAC897F360
        public void ForceBoundsVisible(){} // RVA: 0x7FFAC8981860
    }

    public class CVRChaperoneSetup : Object
    {
        public OVR.OpenVR.IVRChaperoneSetup FnTable; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8981890
        public void CommitWorkingCopy(){} // RVA: 0x7FFAC7793490
        public void RevertWorkingCopy(){} // RVA: 0x7FFAC669D470
        public void GetWorkingPlayAreaSize(){} // RVA: 0x7FFAC8981A80
        public void GetWorkingPlayAreaRect(){} // RVA: 0x7FFAC5C6F7C0
        public void GetWorkingCollisionBoundsInfo(){} // RVA: 0x7FFAC8981AB0
        public void GetLiveCollisionBoundsInfo(){} // RVA: 0x7FFAC8981BA0
        public void GetWorkingSeatedZeroPoseToRawTrackingPose(){} // RVA: 0x7FFAC8980DA0
        public void GetWorkingStandingZeroPoseToRawTrackingPose(){} // RVA: 0x7FFAC8981860
        public void SetWorkingPlayAreaSize(){} // RVA: 0x7FFAC89811B0
        public void SetWorkingCollisionBoundsInfo(){} // RVA: 0x7FFAC8981C90
        public void SetWorkingSeatedZeroPoseToRawTrackingPose(){} // RVA: 0x7FFAC7797E00
        public void SetWorkingStandingZeroPoseToRawTrackingPose(){} // RVA: 0x7FFAC8981CC0
        public void ReloadFromDisk(){} // RVA: 0x7FFAC8981210
        public void GetLiveSeatedZeroPoseToRawTrackingPose(){} // RVA: 0x7FFAC8981CF0
        public void SetWorkingCollisionBoundsTagsInfo(){} // RVA: 0x7FFAC8981D20
        public void GetLiveCollisionBoundsTagsInfo(){} // RVA: 0x7FFAC8981D60
        public void SetWorkingPhysicalBoundsInfo(){} // RVA: 0x7FFAC8981E50
        public void GetLivePhysicalBoundsInfo(){} // RVA: 0x7FFAC8981E90
        public void ExportLiveToBuffer(){} // RVA: 0x7FFAC8981F80
        public void ImportFromBufferToWorking(){} // RVA: 0x7FFAC89813C0
    }

    public class CVRCompositor : Object
    {
        public OVR.OpenVR.IVRCompositor FnTable; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8981FB0
        public void SetTrackingSpace(){} // RVA: 0x7FFAC7793490
        public void GetTrackingSpace(){} // RVA: 0x7FFAC669D470
        public void WaitGetPoses(){} // RVA: 0x7FFAC89821D0
        public void GetLastPoses(){} // RVA: 0x7FFAC8982220
        public void GetLastPoseForTrackedDeviceIndex(){} // RVA: 0x7FFAC8981110
        public void Submit(){} // RVA: 0x7FFAC8982270
        public void ClearLastSubmittedFrame(){} // RVA: 0x7FFAC897F360
        public void PostPresentHandoff(){} // RVA: 0x7FFAC89822A0
        public void GetFrameTiming(){} // RVA: 0x7FFAC89811B0
        public void GetFrameTimings(){} // RVA: 0x7FFAC89822D0
        public void GetFrameTimeRemaining(){} // RVA: 0x7FFAC8982300
        public void GetCumulativeStats(){} // RVA: 0x7FFAC8980EC0
        public void FadeToColor(){} // RVA: 0x7FFAC8982330
        public void GetCurrentFadeColor(){} // RVA: 0x7FFAC8982380
        public void FadeGrid(){} // RVA: 0x7FFAC89823C0
        public void GetCurrentGridAlpha(){} // RVA: 0x7FFAC89823F0
        public void SetSkyboxOverride(){} // RVA: 0x7FFAC8981E50
        public void ClearSkyboxOverride(){} // RVA: 0x7FFAC8982420
        public void CompositorBringToFront(){} // RVA: 0x7FFAC8982450
        public void CompositorGoToBack(){} // RVA: 0x7FFAC8982480
        public void CompositorQuit(){} // RVA: 0x7FFAC89824B0
        public void IsFullscreen(){} // RVA: 0x7FFAC89824E0
        public void GetCurrentSceneFocusProcess(){} // RVA: 0x7FFAC8982510
        public void GetLastFrameRenderer(){} // RVA: 0x7FFAC8982540
        public void CanRenderScene(){} // RVA: 0x7FFAC8982570
        public void ShowMirrorWindow(){} // RVA: 0x7FFAC8981480
        public void HideMirrorWindow(){} // RVA: 0x7FFAC89825A0
        public void IsMirrorWindowVisible(){} // RVA: 0x7FFAC89825D0
        public void CompositorDumpImages(){} // RVA: 0x7FFAC8981590
        public void ShouldAppRenderWithLowResources(){} // RVA: 0x7FFAC8982600
        public void ForceInterleavedReprojectionOn(){} // RVA: 0x7FFAC8982630
        public void ForceReconnectProcess(){} // RVA: 0x7FFAC8982660
        public void SuspendRendering(){} // RVA: 0x7FFAC8982690
        public void GetMirrorTextureD3D11(){} // RVA: 0x7FFAC89826C0
        public void ReleaseMirrorTextureD3D11(){} // RVA: 0x7FFAC89826F0
        public void GetMirrorTextureGL(){} // RVA: 0x7FFAC8982720
        public void ReleaseSharedGLTexture(){} // RVA: 0x7FFAC8982760
        public void LockGLSharedTextureForAccess(){} // RVA: 0x7FFAC8982790
        public void UnlockGLSharedTextureForAccess(){} // RVA: 0x7FFAC89827C0
        public void GetVulkanInstanceExtensionsRequired(){} // RVA: 0x7FFAC89827F0
        public void GetVulkanDeviceExtensionsRequired(){} // RVA: 0x7FFAC8982820
        public void SetExplicitTimingMode(){} // RVA: 0x7FFAC8982850
        public void SubmitExplicitTimingData(){} // RVA: 0x7FFAC8980450
    }

    public class CVRDriverManager : Object
    {
        public OVR.OpenVR.IVRDriverManager FnTable; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8984EB0
        public void GetDriverCount(){} // RVA: 0x7FFAC3D3B830
        public void GetDriverName(){} // RVA: 0x7FFAC8985050
        public void GetDriverHandle(){} // RVA: 0x7FFAC64FAEC0
    }

    public class CVRExtendedDisplay : Object
    {
        public OVR.OpenVR.IVRExtendedDisplay FnTable; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC89807C0
        public void GetWindowBounds(){} // RVA: 0x7FFAC8980960
        public void GetEyeOutputViewport(){} // RVA: 0x7FFAC89809A0
        public void GetDXGIOutputInfo(){} // RVA: 0x7FFAC89809F0
    }

    public class CVRIOBuffer : Object
    {
        public OVR.OpenVR.IVRIOBuffer FnTable; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8985560
        public void Open(){} // RVA: 0x7FFAC8985700
        public void Close(){} // RVA: 0x7FFAC3584BC0
        public void Read(){} // RVA: 0x7FFAC8985740
        public void Write(){} // RVA: 0x7FFAC8985780
        public void PropertyContainer(){} // RVA: 0x7FFAC8224FE0
    }

    public class CVRInput : Object
    {
        public OVR.OpenVR.IVRInput FnTable; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8985080
        public void SetActionManifestPath(){} // RVA: 0x7FFAC7793490
        public void GetActionSetHandle(){} // RVA: 0x7FFAC8985260
        public void GetActionHandle(){} // RVA: 0x7FFAC8985290
        public void GetInputSourceHandle(){} // RVA: 0x7FFAC89852C0
        public void UpdateActionState(){} // RVA: 0x7FFAC89852F0
        public void GetDigitalActionData(){} // RVA: 0x7FFAC8982270
        public void GetAnalogActionData(){} // RVA: 0x7FFAC8982B10
        public void GetPoseActionData(){} // RVA: 0x7FFAC8985330
        public void GetSkeletalActionData(){} // RVA: 0x7FFAC8985360
        public void GetSkeletalBoneData(){} // RVA: 0x7FFAC8985390
        public void GetSkeletalBoneDataCompressed(){} // RVA: 0x7FFAC89853F0
        public void DecompressSkeletalBoneData(){} // RVA: 0x7FFAC8985430
        public void TriggerHapticVibrationAction(){} // RVA: 0x7FFAC8985480
        public void GetActionOrigins(){} // RVA: 0x7FFAC89854B0
        public void GetOriginLocalizedName(){} // RVA: 0x7FFAC89854F0
        public void GetOriginTrackedDeviceInfo(){} // RVA: 0x7FFAC8981330
        public void ShowActionOrigins(){} // RVA: 0x7FFAC8982CF0
        public void ShowBindingsForActionSet(){} // RVA: 0x7FFAC8985520
    }

    public class CVRNotifications : Object
    {
        public OVR.OpenVR.IVRNotifications FnTable; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8984470
        public void CreateNotification(){} // RVA: 0x7FFAC8984600
        public void RemoveNotification(){} // RVA: 0x7FFAC3584BC0
    }

    public class CVROverlay : Object
    {
        public OVR.OpenVR.IVROverlay FnTable; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8982880
        public void FindOverlay(){} // RVA: 0x7FFAC8982A70
        public void CreateOverlay(){} // RVA: 0x7FFAC8982AA0
        public void DestroyOverlay(){} // RVA: 0x7FFAC64FAEC0
        public void SetHighQualityOverlay(){} // RVA: 0x7FFAC5C6F7C0
        public void GetHighQualityOverlay(){} // RVA: 0x7FFAC8982AE0
        public void GetOverlayKey(){} // RVA: 0x7FFAC8982270
        public void GetOverlayName(){} // RVA: 0x7FFAC8982B10
        public void SetOverlayName(){} // RVA: 0x7FFAC77974B0
        public void GetOverlayImageData(){} // RVA: 0x7FFAC8980E00
        public void GetOverlayErrorNameFromEnum(){} // RVA: 0x7FFAC8982B40
        public void SetOverlayRenderingPid(){} // RVA: 0x7FFAC8982BF0
        public void GetOverlayRenderingPid(){} // RVA: 0x7FFAC8981CC0
        public void SetOverlayFlag(){} // RVA: 0x7FFAC8982C20
        public void GetOverlayFlag(){} // RVA: 0x7FFAC8982C50
        public void SetOverlayColor(){} // RVA: 0x7FFAC8982C80
        public void GetOverlayColor(){} // RVA: 0x7FFAC8982CB0
        public void SetOverlayAlpha(){} // RVA: 0x7FFAC8982CF0
        public void GetOverlayAlpha(){} // RVA: 0x7FFAC8982D20
        public void SetOverlayTexelAspect(){} // RVA: 0x7FFAC8982D50
        public void GetOverlayTexelAspect(){} // RVA: 0x7FFAC8982D80
        public void SetOverlaySortOrder(){} // RVA: 0x7FFAC8982DB0
        public void GetOverlaySortOrder(){} // RVA: 0x7FFAC8982DE0
        public void SetOverlayWidthInMeters(){} // RVA: 0x7FFAC8982E10
        public void GetOverlayWidthInMeters(){} // RVA: 0x7FFAC8982E40
        public void SetOverlayAutoCurveDistanceRangeInMeters(){} // RVA: 0x7FFAC8982E70
        public void GetOverlayAutoCurveDistanceRangeInMeters(){} // RVA: 0x7FFAC8982EA0
        public void SetOverlayTextureColorSpace(){} // RVA: 0x7FFAC8982EE0
        public void GetOverlayTextureColorSpace(){} // RVA: 0x7FFAC8982F10
        public void SetOverlayTextureBounds(){} // RVA: 0x7FFAC8982F40
        public void GetOverlayTextureBounds(){} // RVA: 0x7FFAC8982F70
        public void GetOverlayRenderModel(){} // RVA: 0x7FFAC8982FA0
        public void SetOverlayRenderModel(){} // RVA: 0x7FFAC8982FE0
        public void GetOverlayTransformType(){} // RVA: 0x7FFAC8983010
        public void SetOverlayTransformAbsolute(){} // RVA: 0x7FFAC89826C0
        public void GetOverlayTransformAbsolute(){} // RVA: 0x7FFAC8983040
        public void SetOverlayTransformTrackedDeviceRelative(){} // RVA: 0x7FFAC8983070
        public void GetOverlayTransformTrackedDeviceRelative(){} // RVA: 0x7FFAC89830A0
        public void SetOverlayTransformTrackedDeviceComponent(){} // RVA: 0x7FFAC89830E0
        public void GetOverlayTransformTrackedDeviceComponent(){} // RVA: 0x7FFAC8983110
        public void GetOverlayTransformOverlayRelative(){} // RVA: 0x7FFAC8983150
        public void SetOverlayTransformOverlayRelative(){} // RVA: 0x7FFAC8982820
        public void ShowOverlay(){} // RVA: 0x7FFAC8982850
        public void HideOverlay(){} // RVA: 0x7FFAC8983190
        public void IsOverlayVisible(){} // RVA: 0x7FFAC89831C0
        public void GetTransformForOverlayCoordinates(){} // RVA: 0x7FFAC89831F0
        public void PollNextOverlayEvent(){} // RVA: 0x7FFAC8983220
        public void GetOverlayInputMethod(){} // RVA: 0x7FFAC8983480
        public void SetOverlayInputMethod(){} // RVA: 0x7FFAC89834B0
        public void GetOverlayMouseScale(){} // RVA: 0x7FFAC89834E0
        public void SetOverlayMouseScale(){} // RVA: 0x7FFAC8983510
        public void ComputeOverlayIntersection(){} // RVA: 0x7FFAC8983540
        public void IsHoverTargetOverlay(){} // RVA: 0x7FFAC8983570
        public void GetGamepadFocusOverlay(){} // RVA: 0x7FFAC89835A0
        public void SetGamepadFocusOverlay(){} // RVA: 0x7FFAC89835D0
        public void SetOverlayNeighbor(){} // RVA: 0x7FFAC8983600
        public void MoveGamepadFocusToNeighbor(){} // RVA: 0x7FFAC8983630
        public void SetOverlayDualAnalogTransform(){} // RVA: 0x7FFAC8983660
        public void GetOverlayDualAnalogTransform(){} // RVA: 0x7FFAC8983690
        public void SetOverlayTexture(){} // RVA: 0x7FFAC89836D0
        public void ClearOverlayTexture(){} // RVA: 0x7FFAC8983700
        public void SetOverlayRaw(){} // RVA: 0x7FFAC8983730
        public void SetOverlayFromFile(){} // RVA: 0x7FFAC8983770
        public void GetOverlayTexture(){} // RVA: 0x7FFAC89837A0
        public void ReleaseNativeOverlayHandle(){} // RVA: 0x7FFAC8983800
        public void GetOverlayTextureSize(){} // RVA: 0x7FFAC8983830
        public void CreateDashboardOverlay(){} // RVA: 0x7FFAC8983870
        public void IsDashboardVisible(){} // RVA: 0x7FFAC89838B0
        public void IsActiveDashboardOverlay(){} // RVA: 0x7FFAC89838E0
        public void SetDashboardOverlaySceneProcess(){} // RVA: 0x7FFAC8983910
        public void GetDashboardOverlaySceneProcess(){} // RVA: 0x7FFAC8983940
        public void ShowDashboard(){} // RVA: 0x7FFAC8983970
        public void GetPrimaryDashboardDevice(){} // RVA: 0x7FFAC89839A0
        public void ShowKeyboard(){} // RVA: 0x7FFAC89839D0
        public void ShowKeyboardForOverlay(){} // RVA: 0x7FFAC8983A10
        public void GetKeyboardText(){} // RVA: 0x7FFAC8983A50
        public void HideKeyboard(){} // RVA: 0x7FFAC8983A80
        public void SetKeyboardTransformAbsolute(){} // RVA: 0x7FFAC8983AB0
        public void SetKeyboardPositionForOverlay(){} // RVA: 0x7FFAC8983AE0
        public void SetOverlayIntersectionMask(){} // RVA: 0x7FFAC8983B20
        public void GetOverlayFlags(){} // RVA: 0x7FFAC8983B50
        public void ShowMessageOverlay(){} // RVA: 0x7FFAC8983B80
        public void CloseMessageOverlay(){} // RVA: 0x7FFAC8983BC0
    }

    public class CVRRenderModels : Object
    {
        public OVR.OpenVR.IVRRenderModels FnTable; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8983CC0
        public void LoadRenderModel_Async(){} // RVA: 0x7FFAC78F7300
        public void FreeRenderModel(){} // RVA: 0x7FFAC3584BC0
        public void LoadTexture_Async(){} // RVA: 0x7FFAC8225010
        public void FreeTexture(){} // RVA: 0x7FFAC5C6F7C0
        public void LoadTextureD3D11_Async(){} // RVA: 0x7FFAC8981110
        public void LoadIntoTextureD3D11_Async(){} // RVA: 0x7FFAC8983EB0
        public void FreeTextureD3D11(){} // RVA: 0x7FFAC8980DA0
        public void GetRenderModelName(){} // RVA: 0x7FFAC8983EE0
        public void GetRenderModelCount(){} // RVA: 0x7FFAC8983F10
        public void GetComponentCount(){} // RVA: 0x7FFAC89811E0
        public void GetComponentName(){} // RVA: 0x7FFAC8983F40
        public void GetComponentButtonMask(){} // RVA: 0x7FFAC8980EC0
        public void GetComponentRenderModelName(){} // RVA: 0x7FFAC8983F70
        public void GetComponentStateForDevicePath(){} // RVA: 0x7FFAC8983FA0
        public void GetComponentState(){} // RVA: 0x7FFAC8983FD0
        public void RenderModelHasComponent(){} // RVA: 0x7FFAC8984240
        public void GetRenderModelThumbnailURL(){} // RVA: 0x7FFAC8984270
        public void GetRenderModelOriginalPath(){} // RVA: 0x7FFAC89842A0
        public void GetRenderModelErrorNameFromEnum(){} // RVA: 0x7FFAC89842D0
    }

    public class CVRResources : Object
    {
        public OVR.OpenVR.IVRResources FnTable; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8984CC0
        public void LoadSharedResource(){} // RVA: 0x7FFAC8984E50
        public void GetResourceFullPath(){} // RVA: 0x7FFAC8984E80
    }

    public class CVRScreenshots : Object
    {
        public OVR.OpenVR.IVRScreenshots FnTable; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8984A00
        public void RequestScreenshot(){} // RVA: 0x7FFAC8984BB0
        public void HookScreenshot(){} // RVA: 0x7FFAC8984BF0
        public void GetScreenshotPropertyType(){} // RVA: 0x7FFAC8225010
        public void GetScreenshotPropertyFilename(){} // RVA: 0x7FFAC8984C20
        public void UpdateScreenshotProgress(){} // RVA: 0x7FFAC8984C50
        public void TakeStereoScreenshot(){} // RVA: 0x7FFAC8984C80
        public void SubmitScreenshot(){} // RVA: 0x7FFAC8982B10
    }

    public class CVRSettingHelper : ValueType
    {
        public UIntPtr m_pSettings; // 0x10
    }

    public class CVRSettings : Object
    {
        public OVR.OpenVR.IVRSettings FnTable; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8984640
        public void GetSettingsErrorNameFromEnum(){} // RVA: 0x7FFAC8984800
        public void Sync(){} // RVA: 0x7FFAC89848B0
        public void SetBool(){} // RVA: 0x7FFAC89848E0
        public void SetInt32(){} // RVA: 0x7FFAC8980D10
        public void SetFloat(){} // RVA: 0x7FFAC8984910
        public void SetString(){} // RVA: 0x7FFAC8982270
        public void GetBool(){} // RVA: 0x7FFAC8984940
        public void GetInt32(){} // RVA: 0x7FFAC8983EE0
        public void GetFloat(){} // RVA: 0x7FFAC8984970
        public void GetString(){} // RVA: 0x7FFAC89849A0
        public void RemoveSection(){} // RVA: 0x7FFAC8982BF0
        public void RemoveKeyInSection(){} // RVA: 0x7FFAC89849D0
    }

    public class CVRSpatialAnchors : Object
    {
        public OVR.OpenVR.IVRSpatialAnchors FnTable; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC89857B0
        public void CreateSpatialAnchorFromDescriptor(){} // RVA: 0x7FFAC8985940
        public void CreateSpatialAnchorFromPose(){} // RVA: 0x7FFAC8985970
        public void GetSpatialAnchorPose(){} // RVA: 0x7FFAC89859B0
        public void GetSpatialAnchorDescriptor(){} // RVA: 0x7FFAC89859E0
    }

    public class CVRSystem : Object
    {
        public OVR.OpenVR.IVRSystem FnTable; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC897EF90
        public void GetRecommendedRenderTargetSize(){} // RVA: 0x7FFAC897F1C0
        public void GetProjectionMatrix(){} // RVA: 0x7FFAC897F1F0
        public void GetProjectionRaw(){} // RVA: 0x7FFAC897F260
        public void ComputeDistortion(){} // RVA: 0x7FFAC897F2B0
        public void GetEyeToHeadTransform(){} // RVA: 0x7FFAC897F2E0
        public void GetTimeSinceLastVsync(){} // RVA: 0x7FFAC897F330
        public void GetD3D9AdapterIndex(){} // RVA: 0x7FFAC897F360
        public void GetDXGIOutputInfo(){} // RVA: 0x7FFAC897F390
        public void GetOutputDevice(){} // RVA: 0x7FFAC897F3C0
        public void IsDisplayOnDesktop(){} // RVA: 0x7FFAC897F400
        public void SetDisplayVisibility(){} // RVA: 0x7FFAC7797E00
        public void GetDeviceToAbsoluteTrackingPose(){} // RVA: 0x7FFAC897F430
        public void ResetSeatedZeroPose(){} // RVA: 0x7FFAC897F470
        public void GetSeatedZeroPoseToStandingAbsoluteTrackingPose(){} // RVA: 0x7FFAC897F4A0
        public void GetRawZeroPoseToStandingAbsoluteTrackingPose(){} // RVA: 0x7FFAC897F4F0
        public void GetSortedTrackedDeviceIndicesOfClass(){} // RVA: 0x7FFAC897F540
        public void GetTrackedDeviceActivityLevel(){} // RVA: 0x7FFAC897F580
        public void ApplyTransform(){} // RVA: 0x7FFAC897F5B0
        public void GetTrackedDeviceIndexForControllerRole(){} // RVA: 0x7FFAC897F5E0
        public void GetControllerRoleForTrackedDeviceIndex(){} // RVA: 0x7FFAC897F610
        public void GetTrackedDeviceClass(){} // RVA: 0x7FFAC897F640
        public void IsTrackedDeviceConnected(){} // RVA: 0x7FFAC897F670
        public void GetBoolTrackedDeviceProperty(){} // RVA: 0x7FFAC897F6A0
        public void GetFloatTrackedDeviceProperty(){} // RVA: 0x7FFAC897F6D0
        public void GetInt32TrackedDeviceProperty(){} // RVA: 0x7FFAC897F700
        public void GetUint64TrackedDeviceProperty(){} // RVA: 0x7FFAC897F730
        public void GetMatrix34TrackedDeviceProperty(){} // RVA: 0x7FFAC897F760
        public void GetArrayTrackedDeviceProperty(){} // RVA: 0x7FFAC897F7C0
        public void GetStringTrackedDeviceProperty(){} // RVA: 0x7FFAC897F800
        public void GetPropErrorNameFromEnum(){} // RVA: 0x7FFAC897F840
        public void PollNextEvent(){} // RVA: 0x7FFAC897F8F0
        public void PollNextEventWithPose(){} // RVA: 0x7FFAC897FB30
        public void GetEventTypeNameFromEnum(){} // RVA: 0x7FFAC897FB60
        public void GetHiddenAreaMesh(){} // RVA: 0x7FFAC897FC10
        public void GetControllerState(){} // RVA: 0x7FFAC897FC60
        public void GetControllerStateWithPose(){} // RVA: 0x7FFAC897FF30
        public void TriggerHapticPulse(){} // RVA: 0x7FFAC8980230
        public void GetButtonIdNameFromEnum(){} // RVA: 0x7FFAC8980260
        public void GetControllerAxisTypeNameFromEnum(){} // RVA: 0x7FFAC8980310
        public void IsInputAvailable(){} // RVA: 0x7FFAC89803C0
        public void IsSteamVRDrawingControllers(){} // RVA: 0x7FFAC89803F0
        public void ShouldApplicationPause(){} // RVA: 0x7FFAC8980420
        public void ShouldApplicationReduceRenderingWork(){} // RVA: 0x7FFAC8980450
        public void DriverDebugRequest(){} // RVA: 0x7FFAC8980480
        public void PerformFirmwareUpdate(){} // RVA: 0x7FFAC89804B0
        public void AcknowledgeQuit_Exiting(){} // RVA: 0x7FFAC89804E0
        public void AcknowledgeQuit_UserPrompt(){} // RVA: 0x7FFAC8980510
    }

    public class CVRTrackedCamera : Object
    {
        public OVR.OpenVR.IVRTrackedCamera FnTable; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8980A20
        public void GetCameraErrorNameFromEnum(){} // RVA: 0x7FFAC8980BE0
        public void HasCamera(){} // RVA: 0x7FFAC8980C90
        public void GetCameraFrameSize(){} // RVA: 0x7FFAC8980CC0
        public void GetCameraIntrinsics(){} // RVA: 0x7FFAC8980D10
        public void GetCameraProjection(){} // RVA: 0x7FFAC8980D40
        public void AcquireVideoStreamingService(){} // RVA: 0x7FFAC8980D70
        public void ReleaseVideoStreamingService(){} // RVA: 0x7FFAC8980DA0
        public void GetVideoStreamFrameBuffer(){} // RVA: 0x7FFAC8980DD0
        public void GetVideoStreamTextureSize(){} // RVA: 0x7FFAC8980E00
        public void GetVideoStreamTextureD3D11(){} // RVA: 0x7FFAC8980E50
        public void GetVideoStreamTextureGL(){} // RVA: 0x7FFAC8980E80
        public void ReleaseVideoStreamTextureGL(){} // RVA: 0x7FFAC8980EC0
    }

    public class CameraVideoStreamFrameHeader_t : ValueType
    {
        public 0x6B1B6618 eFrameType; // 0x10
        public uint nWidth; // 0x14
        public uint nHeight; // 0x18
        public uint nBytesPerPixel; // 0x1C
        public uint nFrameSequence; // 0x20
        public OVR.OpenVR.TrackedDevicePose_t standingTrackedDevicePose; // 0x24
    }

    public class Compositor_CumulativeStats : ValueType
    {
        public uint m_nPid; // 0x10
        public uint m_nNumFramePresents; // 0x14
        public uint m_nNumDroppedFrames; // 0x18
        public uint m_nNumReprojectedFrames; // 0x1C
        public uint m_nNumFramePresentsOnStartup; // 0x20
        public uint m_nNumDroppedFramesOnStartup; // 0x24
        public uint m_nNumReprojectedFramesOnStartup; // 0x28
        public uint m_nNumLoading; // 0x2C
        public uint m_nNumFramePresentsLoading; // 0x30
        public uint m_nNumDroppedFramesLoading; // 0x34
        public uint m_nNumReprojectedFramesLoading; // 0x38
        public uint m_nNumTimedOut; // 0x3C
        public uint m_nNumFramePresentsTimedOut; // 0x40
        public uint m_nNumDroppedFramesTimedOut; // 0x44
        public uint m_nNumReprojectedFramesTimedOut; // 0x48
    }

    public class Compositor_FrameTiming : ValueType
    {
        public uint m_nSize; // 0x10
        public uint m_nFrameIndex; // 0x14
        public uint m_nNumFramePresents; // 0x18
        public uint m_nNumMisPresented; // 0x1C
        public uint m_nNumDroppedFrames; // 0x20
        public uint m_nReprojectionFlags; // 0x24
        public double m_flSystemTimeInSeconds; // 0x28
        public float m_flPreSubmitGpuMs; // 0x30
        public float m_flPostSubmitGpuMs; // 0x34
        public float m_flTotalRenderGpuMs; // 0x38
        public float m_flCompositorRenderGpuMs; // 0x3C
        public float m_flCompositorRenderCpuMs; // 0x40
        public float m_flCompositorIdleCpuMs; // 0x44
        public float m_flClientFrameIntervalMs; // 0x48
        public float m_flPresentCallCpuMs; // 0x4C
        public float m_flWaitForPresentCpuMs; // 0x50
        public float m_flSubmitFrameMs; // 0x54
        public float m_flWaitGetPosesCalledMs; // 0x58
        public float m_flNewPosesReadyMs; // 0x5C
        public float m_flNewFrameReadyMs; // 0x60
        public float m_flCompositorUpdateStartMs; // 0x64
        public float m_flCompositorUpdateEndMs; // 0x68
        public float m_flCompositorRenderStartMs; // 0x6C
        public OVR.OpenVR.TrackedDevicePose_t m_HmdPose; // 0x70
    }

    public class Compositor_OverlaySettings : ValueType
    {
        public uint size; // 0x10
        public bool curved; // 0x14
        public bool antialias; // 0x15
        public float scale; // 0x18
        public float distance; // 0x1C
        public float alpha; // 0x20
        public float uOffset; // 0x24
        public float vOffset; // 0x28
        public float uScale; // 0x2C
        public float vScale; // 0x30
        public float gridDivs; // 0x34
        public float gridWidth; // 0x38
        public float gridScale; // 0x3C
        public OVR.OpenVR.HmdMatrix44_t transform; // 0x40
    }

}