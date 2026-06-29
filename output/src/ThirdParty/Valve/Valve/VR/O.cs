// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.VR
// Classes: 2
// Methods: 46

namespace ThirdParty.Valve.Valve.VR
{
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
        public object k_unErrorPropertyTag;
        public object k_unDoublePropertyTag;
        public object k_unHmdMatrix34PropertyTag;
        public object k_unHmdMatrix44PropertyTag;
        public object k_unHmdVector3PropertyTag;
        public object k_unHmdVector4PropertyTag;
        public object k_unHmdVector2PropertyTag;
        public object k_unHmdQuadPropertyTag;
        public object k_unHiddenAreaPropertyTag;
        public object k_unPathHandleInfoTag;
        public object k_unActionPropertyTag;
        public object k_unInputValuePropertyTag;
        public object k_unWildcardPropertyTag;
        public object k_unHapticVibrationPropertyTag;
        public object k_unSkeletonPropertyTag;
        public object k_unSpatialAnchorPosePropertyTag;
        public object k_unJsonPropertyTag;
        public object k_unActiveActionSetPropertyTag;
        public object k_unOpenVRInternalReserved_Start;
        public object k_unOpenVRInternalReserved_End;
        public object k_unMaxPropertyStringSize;
        public object k_ulInvalidActionHandle;
        public object k_ulInvalidActionSetHandle;
        public object k_ulInvalidInputValueHandle;
        public object k_unControllerStateAxisCount;
        public object k_ulOverlayHandleInvalid;
        public object k_unMaxDistortionFunctionParameters;
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
        public object IVROverlayView_Version;
        public object k_unHeadsetViewMaxWidth;
        public object k_unHeadsetViewMaxHeight;
        public object k_pchHeadsetViewOverlayKey;
        public object IVRHeadsetView_Version;
        public object k_pch_Controller_Component_GDC2015;
        public object k_pch_Controller_Component_Base;
        public object k_pch_Controller_Component_Tip;
        public object k_pch_Controller_Component_OpenXR_Aim;
        public object k_pch_Controller_Component_HandGrip;
        public object k_pch_Controller_Component_OpenXR_Grip;
        public object k_pch_Controller_Component_OpenXR_HandModel;
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
        public object k_pch_SteamVR_TrackingLossColor_String;
        public object k_pch_SteamVR_ShowStage_Bool;
        public object k_pch_SteamVR_DrawTrackingReferences_Bool;
        public object k_pch_SteamVR_ActivateMultipleDrivers_Bool;
        public object k_pch_SteamVR_UsingSpeakers_Bool;
        public object k_pch_SteamVR_SpeakersForwardYawOffsetDegrees_Float;
        public object k_pch_SteamVR_BaseStationPowerManagement_Int32;
        public object k_pch_SteamVR_ShowBaseStationPowerManagementTip_Int32;
        public object k_pch_SteamVR_NeverKillProcesses_Bool;
        public object k_pch_SteamVR_SupersampleScale_Float;
        public object k_pch_SteamVR_MaxRecommendedResolution_Int32;
        public object k_pch_SteamVR_MotionSmoothing_Bool;
        public object k_pch_SteamVR_MotionSmoothingOverride_Int32;
        public object k_pch_SteamVR_FramesToThrottle_Int32;
        public object k_pch_SteamVR_AdditionalFramesToPredict_Int32;
        public object k_pch_SteamVR_WorldScale_Float;
        public object k_pch_SteamVR_FovScale_Int32;
        public object k_pch_SteamVR_FovScaleLetterboxed_Bool;
        public object k_pch_SteamVR_DisableAsyncReprojection_Bool;
        public object k_pch_SteamVR_ForceFadeOnBadTracking_Bool;
        public object k_pch_SteamVR_DefaultMirrorView_Int32;
        public object k_pch_SteamVR_ShowLegacyMirrorView_Bool;
        public object k_pch_SteamVR_MirrorViewVisibility_Bool;
        public object k_pch_SteamVR_MirrorViewDisplayMode_Int32;
        public object k_pch_SteamVR_MirrorViewEye_Int32;
        public object k_pch_SteamVR_MirrorViewGeometry_String;
        public object k_pch_SteamVR_MirrorViewGeometryMaximized_String;
        public object k_pch_SteamVR_PerfGraphVisibility_Bool;
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
        public object k_pch_SteamVR_DebugInputBinding;
        public object k_pch_SteamVR_DoNotFadeToGrid;
        public object k_pch_SteamVR_EnableSharedResourceJournaling;
        public object k_pch_SteamVR_EnableSafeMode;
        public object k_pch_SteamVR_PreferredRefreshRate;
        public object k_pch_SteamVR_LastVersionNotice;
        public object k_pch_SteamVR_LastVersionNoticeDate;
        public object k_pch_SteamVR_HmdDisplayColorGainR_Float;
        public object k_pch_SteamVR_HmdDisplayColorGainG_Float;
        public object k_pch_SteamVR_HmdDisplayColorGainB_Float;
        public object k_pch_SteamVR_CustomIconStyle_String;
        public object k_pch_SteamVR_CustomOffIconStyle_String;
        public object k_pch_SteamVR_CustomIconForceUpdate_String;
        public object k_pch_SteamVR_AllowGlobalActionSetPriority;
        public object k_pch_SteamVR_OverlayRenderQuality;
        public object k_pch_SteamVR_BlockOculusSDKOnOpenVRLaunchOption_Bool;
        public object k_pch_SteamVR_BlockOculusSDKOnAllLaunches_Bool;
        public object k_pch_SteamVR_HDCPLegacyCompatibility_Bool;
        public object k_pch_SteamVR_DisplayPortTrainingMode_Int;
        public object k_pch_SteamVR_UsePrism_Bool;
        public object k_pch_SteamVR_AllowFallbackMirrorWindowLinux_Bool;
        public object k_pch_OpenXR_Section;
        public object k_pch_OpenXR_MetaUnityPluginCompatibility_Int32;
        public object k_pch_DirectMode_Section;
        public object k_pch_DirectMode_Enable_Bool;
        public object k_pch_DirectMode_Count_Int32;
        public object k_pch_DirectMode_EdidVid_Int32;
        public object k_pch_DirectMode_EdidPid_Int32;
        public object k_pch_Lighthouse_Section;
        public object k_pch_Lighthouse_DisableIMU_Bool;
        public object k_pch_Lighthouse_DisableIMUExceptHMD_Bool;
        public object k_pch_Lighthouse_UseDisambiguation_String;
        public object k_pch_Lighthouse_DisambiguationDebug_Int32;
        public object k_pch_Lighthouse_PrimaryBasestation_Int32;
        public object k_pch_Lighthouse_DBHistory_Bool;
        public object k_pch_Lighthouse_EnableBluetooth_Bool;
        public object k_pch_Lighthouse_PowerManagedBaseStations_String;
        public object k_pch_Lighthouse_PowerManagedBaseStations2_String;
        public object k_pch_Lighthouse_InactivityTimeoutForBaseStations_Int32;
        public object k_pch_Lighthouse_EnableImuFallback_Bool;
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
        public object k_pch_WindowsMR_Section;
        public object k_pch_UserInterface_Section;
        public object k_pch_UserInterface_StatusAlwaysOnTop_Bool;
        public object k_pch_UserInterface_MinimizeToTray_Bool;
        public object k_pch_UserInterface_HidePopupsWhenStatusMinimized_Bool;
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
        public object k_pch_Perf_PerfGraphInHMD_Bool;
        public object k_pch_Perf_AllowTimingStore_Bool;
        public object k_pch_Perf_SaveTimingsOnExit_Bool;
        public object k_pch_Perf_TestData_Float;
        public object k_pch_Perf_GPUProfiling_Bool;
        public object k_pch_Perf_GpuBusMonitoring_Bool;
        public object k_pch_CollisionBounds_Section;
        public object k_pch_CollisionBounds_Style_Int32;
        public object k_pch_CollisionBounds_GroundPerimeterOn_Bool;
        public object k_pch_CollisionBounds_CenterMarkerOn_Bool;
        public object k_pch_CollisionBounds_PlaySpaceOn_Bool;
        public object k_pch_CollisionBounds_FadeDistance_Float;
        public object k_pch_CollisionBounds_WallHeight_Float;
        public object k_pch_CollisionBounds_ColorGammaR_Int32;
        public object k_pch_CollisionBounds_ColorGammaG_Int32;
        public object k_pch_CollisionBounds_ColorGammaB_Int32;
        public object k_pch_CollisionBounds_ColorGammaA_Int32;
        public object k_pch_CollisionBounds_EnableDriverImport;
        public object k_pch_Camera_Section;
        public object k_pch_Camera_EnableCamera_Bool;
        public object k_pch_Camera_ShowOnController_Bool;
        public object k_pch_Camera_EnableCameraForCollisionBounds_Bool;
        public object k_pch_Camera_RoomView_Int32;
        public object k_pch_Camera_BoundsColorGammaR_Int32;
        public object k_pch_Camera_BoundsColorGammaG_Int32;
        public object k_pch_Camera_BoundsColorGammaB_Int32;
        public object k_pch_Camera_BoundsColorGammaA_Int32;
        public object k_pch_Camera_BoundsStrength_Int32;
        public object k_pch_Camera_RoomViewStyle_Int32;
        public object k_pch_audio_Section;
        public object k_pch_audio_SetOsDefaultPlaybackDevice_Bool;
        public object k_pch_audio_EnablePlaybackDeviceOverride_Bool;
        public object k_pch_audio_PlaybackDeviceOverride_String;
        public object k_pch_audio_PlaybackDeviceOverrideName_String;
        public object k_pch_audio_SetOsDefaultRecordingDevice_Bool;
        public object k_pch_audio_EnableRecordingDeviceOverride_Bool;
        public object k_pch_audio_RecordingDeviceOverride_String;
        public object k_pch_audio_RecordingDeviceOverrideName_String;
        public object k_pch_audio_EnablePlaybackMirror_Bool;
        public object k_pch_audio_PlaybackMirrorDevice_String;
        public object k_pch_audio_PlaybackMirrorDeviceName_String;
        public object k_pch_audio_OldPlaybackMirrorDevice_String;
        public object k_pch_audio_ActiveMirrorDevice_String;
        public object k_pch_audio_EnablePlaybackMirrorIndependentVolume_Bool;
        public object k_pch_audio_LastHmdPlaybackDeviceId_String;
        public object k_pch_audio_VIVEHDMIGain;
        public object k_pch_audio_DualSpeakerAndJackOutput_Bool;
        public object k_pch_audio_MuteMicMonitor_Bool;
        public object k_pch_Power_Section;
        public object k_pch_Power_PowerOffOnExit_Bool;
        public object k_pch_Power_TurnOffScreensTimeout_Float;
        public object k_pch_Power_TurnOffControllersTimeout_Float;
        public object k_pch_Power_ReturnToWatchdogTimeout_Float;

        // ── Methods ──
        public void InitInternal(){} // RVA: 0x7AC88B0
        public void InitInternal2(){} // RVA: 0x7AC88F0
        public void ShutdownInternal(){} // RVA: 0x7AC8970
        public void IsHmdPresent(){} // RVA: 0x7AC89A0
        public void IsRuntimeInstalled(){} // RVA: 0x7AC89D0
        public void RuntimePath(){} // RVA: 0x7ACCDB0
        public void GetStringForHmdError(){} // RVA: 0x7ACCEF0
        public void GetGenericInterface(){} // RVA: 0x7AC8BB0
        public void IsInterfaceVersionValid(){} // RVA: 0x7AC8C10
        public void GetInitToken(){} // RVA: 0x7AC8C70
        public void get_VRToken(){} // RVA: 0x7ACCF80
        public void set_VRToken(){} // RVA: 0x7ACCFC0
        public void get_OpenVRInternal_ModuleContext(){} // RVA: 0x7ACD000
        public void get_System(){} // RVA: 0x7ACD100
        public void get_Chaperone(){} // RVA: 0x7ACD130
        public void get_ChaperoneSetup(){} // RVA: 0x7ACD160
        public void get_Compositor(){} // RVA: 0x7ACD190
        public void get_HeadsetView(){} // RVA: 0x7ACD1C0
        public void get_Overlay(){} // RVA: 0x7ACD1F0
        public void get_OverlayView(){} // RVA: 0x7ACD220
        public void get_RenderModels(){} // RVA: 0x7ACD250
        public void get_ExtendedDisplay(){} // RVA: 0x7ACD280
        public void get_Settings(){} // RVA: 0x7ACD2B0
        public void get_Applications(){} // RVA: 0x7ACD2E0
        public void get_Screenshots(){} // RVA: 0x7ACD310
        public void get_TrackedCamera(){} // RVA: 0x7ACD340
        public void get_Input(){} // RVA: 0x7ACD370
        public void get_IOBuffer(){} // RVA: 0x7ACD3A0
        public void get_SpatialAnchors(){} // RVA: 0x7ACD3D0
        public void get_Notifications(){} // RVA: 0x7ACD400
        public void get_Debug(){} // RVA: 0x7ACD430
        public void Init(){} // RVA: 0x7ACD460
        public void Shutdown(){} // RVA: 0x7AC8970
        public void .ctor(){} // RVA: 0xB43310
    }

    public class OpenVRInterop : Object
    {
        // ── Methods ──
        public void InitInternal(){} // RVA: 0x7AC88B0
        public void InitInternal2(){} // RVA: 0x7AC88F0
        public void ShutdownInternal(){} // RVA: 0x7AC8970
        public void IsHmdPresent(){} // RVA: 0x7AC89A0
        public void IsRuntimeInstalled(){} // RVA: 0x7AC89D0
        public void RuntimePath(){} // RVA: 0x7AC8A00
        public void GetRuntimePath(){} // RVA: 0x7AC8AB0
        public void GetStringForHmdError(){} // RVA: 0x7AC8B80
        public void GetGenericInterface(){} // RVA: 0x7AC8BB0
        public void IsInterfaceVersionValid(){} // RVA: 0x7AC8C10
        public void GetInitToken(){} // RVA: 0x7AC8C70
        public void .ctor(){} // RVA: 0xB43310
    }

}