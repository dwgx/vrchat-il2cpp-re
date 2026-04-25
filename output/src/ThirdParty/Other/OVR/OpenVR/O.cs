// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.OVR.OpenVR
// Classes: 2
// Methods: 38

namespace ThirdParty.Other.OVR.OpenVR
{
    public class OpenVR : Object
    {
        public uint VRToken;
        public uint OpenVRInternal_ModuleContext;
        public uint System;
        public uint Chaperone;
        public uint ChaperoneSetup;
        public uint Compositor;
        public ulong Overlay;
        public uint RenderModels;
        public ulong ExtendedDisplay;
        public uint Settings;
        public uint Applications;
        public uint Screenshots;
        public uint TrackedCamera;
        public uint Input;
        public uint SpatialAnchors;
        public uint k_unHmdMatrix44PropertyTag;
        public uint k_unHmdVector3PropertyTag;
        public uint k_unHmdVector4PropertyTag;
        public uint k_unHiddenAreaPropertyTag;
        public uint k_unPathHandleInfoTag;
        public uint k_unActionPropertyTag;
        public uint k_unInputValuePropertyTag;
        public uint k_unWildcardPropertyTag;
        public uint k_unHapticVibrationPropertyTag;
        public uint k_unSkeletonPropertyTag;
        public uint k_unSpatialAnchorPosePropertyTag;
        public uint k_unOpenVRInternalReserved_Start;
        public uint k_unOpenVRInternalReserved_End;
        public uint k_unMaxPropertyStringSize;
        public ulong k_ulInvalidActionHandle;
        public ulong k_ulInvalidActionSetHandle;
        public ulong k_ulInvalidInputValueHandle;
        public uint k_unControllerStateAxisCount;
        public ulong k_ulOverlayHandleInvalid;
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
        public string k_pch_Controller_Component_GDC2015;
        public string k_pch_Controller_Component_Base;
        public string k_pch_Controller_Component_Tip;
        public string k_pch_Controller_Component_HandGrip;
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
        public string k_pch_SteamVR_ShowStage_Bool;
        public string k_pch_SteamVR_ActivateMultipleDrivers_Bool;
        public string k_pch_SteamVR_DirectMode_Bool;
        public string k_pch_SteamVR_DirectModeEdidVid_Int32;
        public string k_pch_SteamVR_DirectModeEdidPid_Int32;
        public string k_pch_SteamVR_UsingSpeakers_Bool;
        public string k_pch_SteamVR_SpeakersForwardYawOffsetDegrees_Float;
        public string k_pch_SteamVR_BaseStationPowerManagement_Bool;
        public string k_pch_SteamVR_NeverKillProcesses_Bool;
        public string k_pch_SteamVR_SupersampleScale_Float;
        public string k_pch_SteamVR_AllowAsyncReprojection_Bool;
        public string k_pch_SteamVR_AllowReprojection_Bool;
        public string k_pch_SteamVR_ForceReprojection_Bool;
        public string k_pch_SteamVR_ForceFadeOnBadTracking_Bool;
        public string k_pch_SteamVR_DefaultMirrorView_Int32;
        public string k_pch_SteamVR_ShowMirrorView_Bool;
        public string k_pch_SteamVR_MirrorViewGeometry_String;
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
        public string k_pch_SteamVR_DebugInput;
        public string k_pch_SteamVR_LegacyInputRebinding;
        public string k_pch_SteamVR_DebugInputBinding;
        public string k_pch_SteamVR_InputBindingUIBlock;
        public string k_pch_SteamVR_RenderCameraMode;
        public string k_pch_Lighthouse_Section;
        public string k_pch_Lighthouse_DisableIMU_Bool;
        public string k_pch_Lighthouse_DisableIMUExceptHMD_Bool;
        public string k_pch_Lighthouse_UseDisambiguation_String;
        public string k_pch_Lighthouse_DisambiguationDebug_Int32;
        public string k_pch_Lighthouse_PrimaryBasestation_Int32;
        public string k_pch_Lighthouse_DBHistory_Bool;
        public string k_pch_Lighthouse_EnableBluetooth_Bool;
        public string k_pch_Lighthouse_PowerManagedBaseStations_String;
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
        public string k_pch_UserInterface_Section;
        public string k_pch_UserInterface_StatusAlwaysOnTop_Bool;
        public string k_pch_UserInterface_MinimizeToTray_Bool;
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
        public string k_pch_Perf_HeuristicActive_Bool;
        public string k_pch_Perf_NotifyInHMD_Bool;
        public string k_pch_Perf_NotifyOnlyOnce_Bool;
        public string k_pch_Perf_AllowTimingStore_Bool;
        public string k_pch_Perf_SaveTimingsOnExit_Bool;
        public string k_pch_Perf_TestData_Float;
        public string k_pch_Perf_LinuxGPUProfiling_Bool;
        public string k_pch_CollisionBounds_Section;
        public string k_pch_CollisionBounds_Style_Int32;
        public string k_pch_CollisionBounds_GroundPerimeterOn_Bool;
        public string k_pch_CollisionBounds_CenterMarkerOn_Bool;
        public string k_pch_CollisionBounds_PlaySpaceOn_Bool;
        public string k_pch_CollisionBounds_FadeDistance_Float;
        public string k_pch_CollisionBounds_ColorGammaR_Int32;
        public string k_pch_CollisionBounds_ColorGammaG_Int32;
        public string k_pch_CollisionBounds_ColorGammaB_Int32;
        public string k_pch_CollisionBounds_ColorGammaA_Int32;
        public string k_pch_Camera_Section;
        public string k_pch_Camera_EnableCamera_Bool;
        public string k_pch_Camera_EnableCameraInDashboard_Bool;
        public string k_pch_Camera_EnableCameraForCollisionBounds_Bool;
        public string k_pch_Camera_EnableCameraForRoomView_Bool;
        public string k_pch_Camera_BoundsColorGammaR_Int32;
        public string k_pch_Camera_BoundsColorGammaG_Int32;
        public string k_pch_Camera_BoundsColorGammaB_Int32;
        public string k_pch_Camera_BoundsColorGammaA_Int32;
        public string k_pch_Camera_BoundsStrength_Int32;
        public string k_pch_Camera_RoomViewMode_Int32;
        public string k_pch_audio_Section;
        public string k_pch_audio_OnPlaybackDevice_String;
        public string k_pch_audio_OnRecordDevice_String;
        public string k_pch_audio_OnPlaybackMirrorDevice_String;
        public string k_pch_audio_OffPlaybackDevice_String;
        public string k_pch_audio_OffRecordDevice_String;
        public string k_pch_audio_VIVEHDMIGain;
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
        public string k_pch_Dashboard_EnableWebUI;
        public string k_pch_Dashboard_EnableWebUIDevTools;
        public string k_pch_Dashboard_EnableWebUIDashboardReplacement;
        public string k_pch_modelskin_Section;
        public string k_pch_Driver_Enable_Bool;
        public string k_pch_WebInterface_Section;
        public string k_pch_WebInterface_WebEnable_Bool;
        public string k_pch_WebInterface_WebPort_String;
        public string k_pch_TrackingOverride_Section;
        public string k_pch_App_BindingAutosaveURLSuffix_String;
        public string k_pch_App_BindingCurrentURLSuffix_String;
        public string k_pch_App_NeedToUpdateAutosaveSuffix_Bool;
        public string k_pch_App_ActionManifestURL_String;
        public string k_pch_Trackers_Section;
        public string IVRScreenshots_Version;
        public string IVRResources_Version;
        public string IVRDriverManager_Version;
        public uint k_unMaxActionNameLength;
        public uint k_unMaxActionSetNameLength;
        public uint k_unMaxActionOriginCount;
        public string IVRInput_Version;
        public ulong k_ulInvalidIOBufferHandle;
        public string IVRIOBuffer_Version;
        public uint k_ulInvalidSpatialAnchorHandle;
        public string IVRSpatialAnchors_Version;
        public uint <VRToken>k__BackingField;
        public string FnTable_Prefix;
        public COpenVRContext _OpenVRInternal_ModuleContext; // 0x8

        // ── Methods ──
        public void InitInternal(){} // RVA: 0x7FFAC8985A20
        public void InitInternal2(){} // RVA: 0x7FFAC8985A60
        public void ShutdownInternal(){} // RVA: 0x7FFAC8985AE0
        public void IsHmdPresent(){} // RVA: 0x7FFAC8985B10
        public void IsRuntimeInstalled(){} // RVA: 0x7FFAC8985B40
        public void GetStringForHmdError(){} // RVA: 0x7FFAC89867D0
        public void GetGenericInterface(){} // RVA: 0x7FFAC8985BA0
        public void IsInterfaceVersionValid(){} // RVA: 0x7FFAC8985C00
        public void GetInitToken(){} // RVA: 0x7FFAC8985C60
        public void get_VRToken(){} // RVA: 0x7FFAC8986860
        public void set_VRToken(){} // RVA: 0x7FFAC89868A0
        public void get_OpenVRInternal_ModuleContext(){} // RVA: 0x7FFAC89868E0
        public void get_System(){} // RVA: 0x7FFAC89869E0
        public void get_Chaperone(){} // RVA: 0x7FFAC8986A10
        public void get_ChaperoneSetup(){} // RVA: 0x7FFAC8986A40
        public void get_Compositor(){} // RVA: 0x7FFAC8986A70
        public void get_Overlay(){} // RVA: 0x7FFAC8986AA0
        public void get_RenderModels(){} // RVA: 0x7FFAC8986AD0
        public void get_ExtendedDisplay(){} // RVA: 0x7FFAC8986B00
        public void get_Settings(){} // RVA: 0x7FFAC8986B30
        public void get_Applications(){} // RVA: 0x7FFAC8986B60
        public void get_Screenshots(){} // RVA: 0x7FFAC8986B90
        public void get_TrackedCamera(){} // RVA: 0x7FFAC8986BC0
        public void get_Input(){} // RVA: 0x7FFAC8986BF0
        public void get_SpatialAnchors(){} // RVA: 0x7FFAC8986C20
        public void Init(){} // RVA: 0x7FFAC8986C50
        public void Shutdown(){} // RVA: 0x7FFAC8985AE0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class OpenVRInterop : Object
    {
        // ── Methods ──
        public void InitInternal(){} // RVA: 0x7FFAC8985A20
        public void InitInternal2(){} // RVA: 0x7FFAC8985A60
        public void ShutdownInternal(){} // RVA: 0x7FFAC8985AE0
        public void IsHmdPresent(){} // RVA: 0x7FFAC8985B10
        public void IsRuntimeInstalled(){} // RVA: 0x7FFAC8985B40
        public void GetStringForHmdError(){} // RVA: 0x7FFAC8985B70
        public void GetGenericInterface(){} // RVA: 0x7FFAC8985BA0
        public void IsInterfaceVersionValid(){} // RVA: 0x7FFAC8985C00
        public void GetInitToken(){} // RVA: 0x7FFAC8985C60
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

}