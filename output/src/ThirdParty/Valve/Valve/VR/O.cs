// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.VR
// Classes: 2
// Methods: 46

namespace ThirdParty.Valve.Valve.VR
{
    public class OpenVR : Object
    {
        public uint VRToken;
        public uint OpenVRInternal_ModuleContext;
        public uint System;
        public uint Chaperone;
        public uint ChaperoneSetup;
        public uint Compositor;
        public ulong HeadsetView;
        public uint Overlay;
        public ulong OverlayView;
        public uint RenderModels;
        public uint ExtendedDisplay;
        public uint Settings;
        public uint Applications;
        public uint Screenshots;
        public uint TrackedCamera;
        public uint Input;
        public uint IOBuffer;
        public uint SpatialAnchors;
        public uint Notifications;
        public uint Debug;
        public uint k_unHmdVector2PropertyTag;
        public uint k_unHmdQuadPropertyTag;
        public uint k_unHiddenAreaPropertyTag;
        public uint k_unPathHandleInfoTag;
        public uint k_unActionPropertyTag;
        public uint k_unInputValuePropertyTag;
        public uint k_unWildcardPropertyTag;
        public uint k_unHapticVibrationPropertyTag;
        public uint k_unSkeletonPropertyTag;
        public uint k_unSpatialAnchorPosePropertyTag;
        public uint k_unJsonPropertyTag;
        public uint k_unActiveActionSetPropertyTag;
        public uint k_unOpenVRInternalReserved_Start;
        public uint k_unOpenVRInternalReserved_End;
        public uint k_unMaxPropertyStringSize;
        public ulong k_ulInvalidActionHandle;
        public ulong k_ulInvalidActionSetHandle;
        public ulong k_ulInvalidInputValueHandle;
        public uint k_unControllerStateAxisCount;
        public ulong k_ulOverlayHandleInvalid;
        public uint k_unMaxDistortionFunctionParameters;
        public uint k_unScreenshotHandleInvalid;
        public string IVRSystem_Version;
        public string IVRExtendedDisplay_Version;
        public string IVRTrackedCamera_Version;
        public uint k_unMaxApplicationKeyLength;
        public string k_pch_MimeType_HomeApp;
        public string k_pch_MimeType_GameTheater;
        public string IVRApplications_Version;
        public string IVRChaperone_Version;
        public string IVRChaperoneSetup_Version;
        public string IVRCompositor_Version;
        public uint k_unVROverlayMaxKeyLength;
        public uint k_unVROverlayMaxNameLength;
        public uint k_unMaxOverlayCount;
        public uint k_unMaxOverlayIntersectionMaskPrimitivesCount;
        public string IVROverlay_Version;
        public string IVROverlayView_Version;
        public uint k_unHeadsetViewMaxWidth;
        public uint k_unHeadsetViewMaxHeight;
        public string k_pchHeadsetViewOverlayKey;
        public string IVRHeadsetView_Version;
        public string k_pch_Controller_Component_GDC2015;
        public string k_pch_Controller_Component_Base;
        public string k_pch_Controller_Component_Tip;
        public string k_pch_Controller_Component_OpenXR_Aim;
        public string k_pch_Controller_Component_HandGrip;
        public string k_pch_Controller_Component_OpenXR_Grip;
        public string k_pch_Controller_Component_OpenXR_HandModel;
        public string k_pch_Controller_Component_Status;
        public string IVRRenderModels_Version;
        public uint k_unNotificationTextMaxSize;
        public string IVRNotifications_Version;
        public uint k_unMaxSettingsKeyLength;
        public string IVRSettings_Version;
        public string k_pch_SteamVR_Section;
        public string k_pch_SteamVR_RequireHmd_String;
        public string k_pch_SteamVR_ForcedDriverKey_String;
        public string k_pch_SteamVR_ForcedHmdKey_String;
        public string k_pch_SteamVR_DisplayDebug_Bool;
        public string k_pch_SteamVR_DebugProcessPipe_String;
        public string k_pch_SteamVR_DisplayDebugX_Int32;
        public string k_pch_SteamVR_DisplayDebugY_Int32;
        public string k_pch_SteamVR_SendSystemButtonToAllApps_Bool;
        public string k_pch_SteamVR_LogLevel_Int32;
        public string k_pch_SteamVR_IPD_Float;
        public string k_pch_SteamVR_Background_String;
        public string k_pch_SteamVR_BackgroundUseDomeProjection_Bool;
        public string k_pch_SteamVR_BackgroundCameraHeight_Float;
        public string k_pch_SteamVR_BackgroundDomeRadius_Float;
        public string k_pch_SteamVR_GridColor_String;
        public string k_pch_SteamVR_PlayAreaColor_String;
        public string k_pch_SteamVR_TrackingLossColor_String;
        public string k_pch_SteamVR_ShowStage_Bool;
        public string k_pch_SteamVR_DrawTrackingReferences_Bool;
        public string k_pch_SteamVR_ActivateMultipleDrivers_Bool;
        public string k_pch_SteamVR_UsingSpeakers_Bool;
        public string k_pch_SteamVR_SpeakersForwardYawOffsetDegrees_Float;
        public string k_pch_SteamVR_BaseStationPowerManagement_Int32;
        public string k_pch_SteamVR_ShowBaseStationPowerManagementTip_Int32;
        public string k_pch_SteamVR_NeverKillProcesses_Bool;
        public string k_pch_SteamVR_SupersampleScale_Float;
        public string k_pch_SteamVR_MaxRecommendedResolution_Int32;
        public string k_pch_SteamVR_MotionSmoothing_Bool;
        public string k_pch_SteamVR_MotionSmoothingOverride_Int32;
        public string k_pch_SteamVR_FramesToThrottle_Int32;
        public string k_pch_SteamVR_AdditionalFramesToPredict_Int32;
        public string k_pch_SteamVR_WorldScale_Float;
        public string k_pch_SteamVR_FovScale_Int32;
        public string k_pch_SteamVR_FovScaleLetterboxed_Bool;
        public string k_pch_SteamVR_DisableAsyncReprojection_Bool;
        public string k_pch_SteamVR_ForceFadeOnBadTracking_Bool;
        public string k_pch_SteamVR_DefaultMirrorView_Int32;
        public string k_pch_SteamVR_ShowLegacyMirrorView_Bool;
        public string k_pch_SteamVR_MirrorViewVisibility_Bool;
        public string k_pch_SteamVR_MirrorViewDisplayMode_Int32;
        public string k_pch_SteamVR_MirrorViewEye_Int32;
        public string k_pch_SteamVR_MirrorViewGeometry_String;
        public string k_pch_SteamVR_MirrorViewGeometryMaximized_String;
        public string k_pch_SteamVR_PerfGraphVisibility_Bool;
        public string k_pch_SteamVR_StartMonitorFromAppLaunch;
        public string k_pch_SteamVR_StartCompositorFromAppLaunch_Bool;
        public string k_pch_SteamVR_StartDashboardFromAppLaunch_Bool;
        public string k_pch_SteamVR_StartOverlayAppsFromDashboard_Bool;
        public string k_pch_SteamVR_EnableHomeApp;
        public string k_pch_SteamVR_CycleBackgroundImageTimeSec_Int32;
        public string k_pch_SteamVR_RetailDemo_Bool;
        public string k_pch_SteamVR_IpdOffset_Float;
        public string k_pch_SteamVR_AllowSupersampleFiltering_Bool;
        public string k_pch_SteamVR_SupersampleManualOverride_Bool;
        public string k_pch_SteamVR_EnableLinuxVulkanAsync_Bool;
        public string k_pch_SteamVR_AllowDisplayLockedMode_Bool;
        public string k_pch_SteamVR_HaveStartedTutorialForNativeChaperoneDriver_Bool;
        public string k_pch_SteamVR_ForceWindows32bitVRMonitor;
        public string k_pch_SteamVR_DebugInputBinding;
        public string k_pch_SteamVR_DoNotFadeToGrid;
        public string k_pch_SteamVR_EnableSharedResourceJournaling;
        public string k_pch_SteamVR_EnableSafeMode;
        public string k_pch_SteamVR_PreferredRefreshRate;
        public string k_pch_SteamVR_LastVersionNotice;
        public string k_pch_SteamVR_LastVersionNoticeDate;
        public string k_pch_SteamVR_HmdDisplayColorGainR_Float;
        public string k_pch_SteamVR_HmdDisplayColorGainG_Float;
        public string k_pch_SteamVR_HmdDisplayColorGainB_Float;
        public string k_pch_SteamVR_CustomIconStyle_String;
        public string k_pch_SteamVR_CustomOffIconStyle_String;
        public string k_pch_SteamVR_CustomIconForceUpdate_String;
        public string k_pch_SteamVR_AllowGlobalActionSetPriority;
        public string k_pch_SteamVR_OverlayRenderQuality;
        public string k_pch_SteamVR_BlockOculusSDKOnOpenVRLaunchOption_Bool;
        public string k_pch_SteamVR_BlockOculusSDKOnAllLaunches_Bool;
        public string k_pch_SteamVR_HDCPLegacyCompatibility_Bool;
        public string k_pch_SteamVR_DisplayPortTrainingMode_Int;
        public string k_pch_SteamVR_UsePrism_Bool;
        public string k_pch_SteamVR_AllowFallbackMirrorWindowLinux_Bool;
        public string k_pch_OpenXR_Section;
        public string k_pch_OpenXR_MetaUnityPluginCompatibility_Int32;
        public string k_pch_DirectMode_Section;
        public string k_pch_DirectMode_Enable_Bool;
        public string k_pch_DirectMode_Count_Int32;
        public string k_pch_DirectMode_EdidVid_Int32;
        public string k_pch_DirectMode_EdidPid_Int32;
        public string k_pch_Lighthouse_Section;
        public string k_pch_Lighthouse_DisableIMU_Bool;
        public string k_pch_Lighthouse_DisableIMUExceptHMD_Bool;
        public string k_pch_Lighthouse_UseDisambiguation_String;
        public string k_pch_Lighthouse_DisambiguationDebug_Int32;
        public string k_pch_Lighthouse_PrimaryBasestation_Int32;
        public string k_pch_Lighthouse_DBHistory_Bool;
        public string k_pch_Lighthouse_EnableBluetooth_Bool;
        public string k_pch_Lighthouse_PowerManagedBaseStations_String;
        public string k_pch_Lighthouse_PowerManagedBaseStations2_String;
        public string k_pch_Lighthouse_InactivityTimeoutForBaseStations_Int32;
        public string k_pch_Lighthouse_EnableImuFallback_Bool;
        public string k_pch_Null_Section;
        public string k_pch_Null_SerialNumber_String;
        public string k_pch_Null_ModelNumber_String;
        public string k_pch_Null_WindowX_Int32;
        public string k_pch_Null_WindowY_Int32;
        public string k_pch_Null_WindowWidth_Int32;
        public string k_pch_Null_WindowHeight_Int32;
        public string k_pch_Null_RenderWidth_Int32;
        public string k_pch_Null_RenderHeight_Int32;
        public string k_pch_Null_SecondsFromVsyncToPhotons_Float;
        public string k_pch_Null_DisplayFrequency_Float;
        public string k_pch_WindowsMR_Section;
        public string k_pch_UserInterface_Section;
        public string k_pch_UserInterface_StatusAlwaysOnTop_Bool;
        public string k_pch_UserInterface_MinimizeToTray_Bool;
        public string k_pch_UserInterface_HidePopupsWhenStatusMinimized_Bool;
        public string k_pch_UserInterface_Screenshots_Bool;
        public string k_pch_UserInterface_ScreenshotType_Int;
        public string k_pch_Notifications_Section;
        public string k_pch_Notifications_DoNotDisturb_Bool;
        public string k_pch_Keyboard_Section;
        public string k_pch_Keyboard_TutorialCompletions;
        public string k_pch_Keyboard_ScaleX;
        public string k_pch_Keyboard_ScaleY;
        public string k_pch_Keyboard_OffsetLeftX;
        public string k_pch_Keyboard_OffsetRightX;
        public string k_pch_Keyboard_OffsetY;
        public string k_pch_Keyboard_Smoothing;
        public string k_pch_Perf_Section;
        public string k_pch_Perf_PerfGraphInHMD_Bool;
        public string k_pch_Perf_AllowTimingStore_Bool;
        public string k_pch_Perf_SaveTimingsOnExit_Bool;
        public string k_pch_Perf_TestData_Float;
        public string k_pch_Perf_GPUProfiling_Bool;
        public string k_pch_Perf_GpuBusMonitoring_Bool;
        public string k_pch_CollisionBounds_Section;
        public string k_pch_CollisionBounds_Style_Int32;
        public string k_pch_CollisionBounds_GroundPerimeterOn_Bool;
        public string k_pch_CollisionBounds_CenterMarkerOn_Bool;
        public string k_pch_CollisionBounds_PlaySpaceOn_Bool;
        public string k_pch_CollisionBounds_FadeDistance_Float;
        public string k_pch_CollisionBounds_WallHeight_Float;
        public string k_pch_CollisionBounds_ColorGammaR_Int32;
        public string k_pch_CollisionBounds_ColorGammaG_Int32;
        public string k_pch_CollisionBounds_ColorGammaB_Int32;
        public string k_pch_CollisionBounds_ColorGammaA_Int32;
        public string k_pch_CollisionBounds_EnableDriverImport;
        public string k_pch_Camera_Section;
        public string k_pch_Camera_EnableCamera_Bool;
        public string k_pch_Camera_ShowOnController_Bool;
        public string k_pch_Camera_EnableCameraForCollisionBounds_Bool;
        public string k_pch_Camera_RoomView_Int32;
        public string k_pch_Camera_BoundsColorGammaR_Int32;
        public string k_pch_Camera_BoundsColorGammaG_Int32;
        public string k_pch_Camera_BoundsColorGammaB_Int32;
        public string k_pch_Camera_BoundsColorGammaA_Int32;
        public string k_pch_Camera_BoundsStrength_Int32;
        public string k_pch_Camera_RoomViewStyle_Int32;
        public string k_pch_audio_Section;
        public string k_pch_audio_SetOsDefaultPlaybackDevice_Bool;
        public string k_pch_audio_EnablePlaybackDeviceOverride_Bool;
        public string k_pch_audio_PlaybackDeviceOverride_String;
        public string k_pch_audio_PlaybackDeviceOverrideName_String;
        public string k_pch_audio_SetOsDefaultRecordingDevice_Bool;
        public string k_pch_audio_EnableRecordingDeviceOverride_Bool;
        public string k_pch_audio_RecordingDeviceOverride_String;
        public string k_pch_audio_RecordingDeviceOverrideName_String;
        public string k_pch_audio_EnablePlaybackMirror_Bool;
        public string k_pch_audio_PlaybackMirrorDevice_String;
        public string k_pch_audio_PlaybackMirrorDeviceName_String;
        public string k_pch_audio_OldPlaybackMirrorDevice_String;
        public string k_pch_audio_ActiveMirrorDevice_String;
        public string k_pch_audio_EnablePlaybackMirrorIndependentVolume_Bool;
        public string k_pch_audio_LastHmdPlaybackDeviceId_String;
        public string k_pch_audio_VIVEHDMIGain;
        public string k_pch_audio_DualSpeakerAndJackOutput_Bool;
        public string k_pch_audio_MuteMicMonitor_Bool;
        public string k_pch_Power_Section;
        public string k_pch_Power_PowerOffOnExit_Bool;
        public string k_pch_Power_TurnOffScreensTimeout_Float;
        public string k_pch_Power_TurnOffControllersTimeout_Float;
        public string k_pch_Power_ReturnToWatchdogTimeout_Float;
        public string k_pch_Power_AutoLaunchSteamVROnButtonPress;
        public string k_pch_Power_PauseCompositorOnStandby_Bool;
        public string k_pch_Dashboard_Section;
        public string k_pch_Dashboard_EnableDashboard_Bool;
        public string k_pch_Dashboard_ArcadeMode_Bool;
        public string k_pch_Dashboard_Position;
        public string k_pch_Dashboard_DesktopScale;
        public string k_pch_Dashboard_DashboardScale;
        public string k_pch_Dashboard_UseStandaloneSystemLayer;
        public string k_pch_Dashboard_StickyDashboard;
        public string k_pch_Dashboard_AllowSteamOverlays_Bool;
        public string k_pch_Dashboard_AllowVRGamepadUI_Bool;
        public string k_pch_Dashboard_AllowVRGamepadUIViaGamescope_Bool;
        public string k_pch_Dashboard_SteamMatchesHMDFramerate;
        public string k_pch_modelskin_Section;
        public string k_pch_Driver_Enable_Bool;
        public string k_pch_Driver_BlockedBySafemode_Bool;
        public string k_pch_Driver_LoadPriority_Int32;
        public string k_pch_WebInterface_Section;
        public string k_pch_VRWebHelper_Section;
        public string k_pch_VRWebHelper_DebuggerEnabled_Bool;
        public string k_pch_VRWebHelper_DebuggerPort_Int32;
        public string k_pch_TrackingOverride_Section;
        public string k_pch_App_BindingAutosaveURLSuffix_String;
        public string k_pch_App_BindingLegacyAPISuffix_String;
        public string k_pch_App_BindingSteamVRInputAPISuffix_String;
        public string k_pch_App_BindingOpenXRAPISuffix_String;
        public string k_pch_App_BindingCurrentURLSuffix_String;
        public string k_pch_App_BindingPreviousURLSuffix_String;
        public string k_pch_App_NeedToUpdateAutosaveSuffix_Bool;
        public string k_pch_App_DominantHand_Int32;
        public string k_pch_App_BlockOculusSDK_Bool;
        public string k_pch_Trackers_Section;
        public string k_pch_DesktopUI_Section;
        public string k_pch_LastKnown_Section;
        public string k_pch_LastKnown_HMDManufacturer_String;
        public string k_pch_LastKnown_HMDModel_String;
        public string k_pch_LastKnown_ActualHMDDriver_String;
        public string k_pch_DismissedWarnings_Section;
        public string k_pch_Input_Section;
        public string k_pch_Input_LeftThumbstickRotation_Float;
        public string k_pch_Input_RightThumbstickRotation_Float;
        public string k_pch_Input_ThumbstickDeadzone_Float;
        public string k_pch_GpuSpeed_Section;
        public string IVRScreenshots_Version;
        public string IVRResources_Version;
        public string IVRDriverManager_Version;
        public uint k_unMaxActionNameLength;
        public uint k_unMaxActionSetNameLength;
        public uint k_unMaxActionOriginCount;
        public uint k_unMaxBoneNameLength;
        public int k_nActionSetOverlayGlobalPriorityMin;
        public int k_nActionSetOverlayGlobalPriorityMax;
        public int k_nActionSetPriorityReservedMin;
        public string IVRInput_Version;
        public ulong k_ulInvalidIOBufferHandle;
        public string IVRIOBuffer_Version;
        public uint k_ulInvalidSpatialAnchorHandle;
        public string IVRSpatialAnchors_Version;
        public string IVRDebug_Version;
        public ulong k_ulDisplayRedirectContainer;
        public string IVRProperties_Version;
        public string k_pchPathUserHandRight;
        public string k_pchPathUserHandLeft;
        public string k_pchPathUserHandPrimary;
        public string k_pchPathUserHandSecondary;
        public string k_pchPathUserHead;
        public string k_pchPathUserGamepad;
        public string k_pchPathUserTreadmill;
        public string k_pchPathUserStylus;
        public string k_pchPathDevices;
        public string k_pchPathDevicePath;
        public string k_pchPathBestAliasPath;
        public string k_pchPathBoundTrackerAliasPath;
        public string k_pchPathBoundTrackerRole;
        public string k_pchPathPoseRaw;
        public string k_pchPathPoseTip;
        public string k_pchPathPoseGrip;
        public string k_pchPathSystemButtonClick;
        public string k_pchPathProximity;
        public string k_pchPathControllerTypePrefix;
        public string k_pchPathInputProfileSuffix;
        public string k_pchPathBindingNameSuffix;
        public string k_pchPathBindingUrlSuffix;
        public string k_pchPathBindingErrorSuffix;
        public string k_pchPathActiveActionSets;
        public string k_pchPathComponentUpdates;
        public string k_pchPathUserFootLeft;
        public string k_pchPathUserFootRight;
        public string k_pchPathUserShoulderLeft;
        public string k_pchPathUserShoulderRight;
        public string k_pchPathUserElbowLeft;
        public string k_pchPathUserElbowRight;
        public string k_pchPathUserKneeLeft;
        public string k_pchPathUserKneeRight;
        public string k_pchPathUserWristLeft;
        public string k_pchPathUserWristRight;
        public string k_pchPathUserAnkleLeft;
        public string k_pchPathUserAnkleRight;
        public string k_pchPathUserWaist;
        public string k_pchPathUserChest;
        public string k_pchPathUserCamera;
        public string k_pchPathUserKeyboard;
        public string k_pchPathClientAppKey;
        public ulong k_ulInvalidPathHandle;
        public string IVRPaths_Version;
        public string IVRBlockQueue_Version;
        public uint <VRToken>k__BackingField;
        public string FnTable_Prefix;
        public COpenVRContext _OpenVRInternal_ModuleContext; // 0x8

        // ── Methods ──
        public void InitInternal(){} // RVA: 0x7FFD54C1FAC0
        public void InitInternal2(){} // RVA: 0x7FFD54C1FB00
        public void ShutdownInternal(){} // RVA: 0x7FFD54C1FB80
        public void IsHmdPresent(){} // RVA: 0x7FFD54C1FBB0
        public void IsRuntimeInstalled(){} // RVA: 0x7FFD54C1FBE0
        public void RuntimePath(){} // RVA: 0x7FFD54C23FC0
        public void GetStringForHmdError(){} // RVA: 0x7FFD54C24100
        public void GetGenericInterface(){} // RVA: 0x7FFD54C1FDC0
        public void IsInterfaceVersionValid(){} // RVA: 0x7FFD54C1FE20
        public void GetInitToken(){} // RVA: 0x7FFD54C1FE80
        public void get_VRToken(){} // RVA: 0x7FFD54C24190
        public void set_VRToken(){} // RVA: 0x7FFD54C241D0
        public void get_OpenVRInternal_ModuleContext(){} // RVA: 0x7FFD54C24210
        public void get_System(){} // RVA: 0x7FFD54C24310
        public void get_Chaperone(){} // RVA: 0x7FFD54C24340
        public void get_ChaperoneSetup(){} // RVA: 0x7FFD54C24370
        public void get_Compositor(){} // RVA: 0x7FFD54C243A0
        public void get_HeadsetView(){} // RVA: 0x7FFD54C243D0
        public void get_Overlay(){} // RVA: 0x7FFD54C24400
        public void get_OverlayView(){} // RVA: 0x7FFD54C24430
        public void get_RenderModels(){} // RVA: 0x7FFD54C24460
        public void get_ExtendedDisplay(){} // RVA: 0x7FFD54C24490
        public void get_Settings(){} // RVA: 0x7FFD54C244C0
        public void get_Applications(){} // RVA: 0x7FFD54C244F0
        public void get_Screenshots(){} // RVA: 0x7FFD54C24520
        public void get_TrackedCamera(){} // RVA: 0x7FFD54C24550
        public void get_Input(){} // RVA: 0x7FFD54C24580
        public void get_IOBuffer(){} // RVA: 0x7FFD54C245B0
        public void get_SpatialAnchors(){} // RVA: 0x7FFD54C245E0
        public void get_Notifications(){} // RVA: 0x7FFD54C24610
        public void get_Debug(){} // RVA: 0x7FFD54C24640
        public void Init(){} // RVA: 0x7FFD54C24670
        public void Shutdown(){} // RVA: 0x7FFD54C1FB80
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class OpenVRInterop : Object
    {
        // ── Methods ──
        public void InitInternal(){} // RVA: 0x7FFD54C1FAC0
        public void InitInternal2(){} // RVA: 0x7FFD54C1FB00
        public void ShutdownInternal(){} // RVA: 0x7FFD54C1FB80
        public void IsHmdPresent(){} // RVA: 0x7FFD54C1FBB0
        public void IsRuntimeInstalled(){} // RVA: 0x7FFD54C1FBE0
        public void RuntimePath(){} // RVA: 0x7FFD54C1FC10
        public void GetRuntimePath(){} // RVA: 0x7FFD54C1FCC0
        public void GetStringForHmdError(){} // RVA: 0x7FFD54C1FD90
        public void GetGenericInterface(){} // RVA: 0x7FFD54C1FDC0
        public void IsInterfaceVersionValid(){} // RVA: 0x7FFD54C1FE20
        public void GetInitToken(){} // RVA: 0x7FFD54C1FE80
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

}