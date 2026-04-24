// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.VR
// Classes: 55
// Methods: 5

namespace ThirdParty.Valve.Valve.VR
{
    public class VRActiveActionSet_t : ValueType
    {
        public ulong ulActionSet; // 0x10
        public ulong ulRestrictedToDevice; // 0x18
        public ulong ulSecondaryActionSet; // 0x20
        public uint unPadding; // 0x28
        public int nPriority; // 0x2C
    }

    public class VRBoneTransform_t : ValueType
    {
        public VRChaperoneSetup position; // 0x10
        public ayEventPacked orientation; // 0x20
    }

    public class VRControllerAxis_t : ValueType
    {
        public float x; // 0x10
        public float y; // 0x14
    }

    public class VRControllerState_t : ValueType
    {
        public uint unPacketNum; // 0x10
        public ulong ulButtonPressed; // 0x18
        public ulong ulButtonTouched; // 0x20
        public mButtonFixRequired_Bool rAxis0; // 0x28
        public mButtonFixRequired_Bool rAxis1; // 0x30
        public mButtonFixRequired_Bool rAxis2; // 0x38
        public mButtonFixRequired_Bool rAxis3; // 0x40
        public mButtonFixRequired_Bool rAxis4; // 0x48
    }

    public class VRControllerState_t_Packed : ValueType
    {
        public uint unPacketNum; // 0x10
        public ulong ulButtonPressed; // 0x14
        public ulong ulButtonTouched; // 0x1C
        public mButtonFixRequired_Bool rAxis0; // 0x24
        public mButtonFixRequired_Bool rAxis1; // 0x2C
        public mButtonFixRequired_Bool rAxis2; // 0x34
        public mButtonFixRequired_Bool rAxis3; // 0x3C
        public mButtonFixRequired_Bool rAxis4; // 0x44

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53DA5E20
        public void Unpack(){} // RVA: 0x7FFD53DA5E50
    }

    public class VREvent_ApplicationLaunch_t : ValueType
    {
        public uint pid; // 0x10
        public uint unArgsHandle; // 0x14
    }

    public class VREvent_AudioMuteControl_t : ValueType
    {
        public bool bMute; // 0x10
    }

    public class VREvent_AudioVolumeControl_t : ValueType
    {
        public float fVolumeLevel; // 0x10
    }

    public class VREvent_Chaperone_t : ValueType
    {
        public ulong m_nPreviousUniverse; // 0x10
        public ulong m_nCurrentUniverse; // 0x18
    }

    public class VREvent_Controller_t : ValueType
    {
        public uint button; // 0x10
    }

    public class VREvent_Data_t : ValueType
    {
        public tring reserved; // 0x10
        public ange controller; // 0x10
        public ng_OutOfRange mouse; // 0x10
        public rackedDeviceClass scroll; // 0x10
        public niverseStanding process; // 0x10
        public niverseSeated notification; // 0x10
        public awAndUncalibrated overlay; // 0x10
        public Property status; // 0x10
        public ManufacturerName_String ipd; // 0x10
        public Prop_TrackingFirmwareVersion_String chaperone; // 0x10
        public rop_ConnectedWirelessDongle_String performanceTest; // 0x10
        public acker touchPadMove; // 0x10
        public iceIsWireless_Bool seatedZeroPoseReset; // 0x10
        public p_DeviceBatteryPercentage_Float screenshot; // 0x10
        public tage_Float screenshotProgress; // 0x10
        public Transform_Matrix34 applicationLaunch; // 0x10
        public ailable_Bool cameraSurface; // 0x10
        public l messageOverlay; // 0x10
        public Revision_Uint64 property; // 0x10
        public _VRCVersion_Uint64 hapticVibration; // 0x10
        public sion_Uint64 webConsole; // 0x10
        public ool inputBinding; // 0x10
        public ProgrammingTarget_String spatialAnchor; // 0x10
        public rop_DeviceProvidesBatteryStatus_Bool actionManifest; // 0x10
        public object progressUpdate; // 0x10
        public object showUi; // 0x10
        public ÌÎÌÏÌÏÍ showDevTools; // 0x10
        public object hdcpError; // 0x10
        public ÍÍÎÍÏÍÏÏÌÎÍÍÎÎÍÎÏÍÍÌ audioVolumeControl; // 0x10
        public object audioMuteControl; // 0x10
        public ackingSystemName_String keyboard; // 0x10
    }

    public class VREvent_EditingCameraSurface_t : ValueType
    {
        public ulong overlayHandle; // 0x10
        public uint nVisualMode; // 0x18
    }

    public class VREvent_HDCPError_t : ValueType
    {
        public object eCode; // 0x10
    }

    public class VREvent_HapticVibration_t : ValueType
    {
        public ulong containerHandle; // 0x10
        public ulong componentHandle; // 0x18
        public float fDurationSeconds; // 0x20
        public float fFrequency; // 0x24
        public float fAmplitude; // 0x28
    }

    public class VREvent_InputActionManifestLoad_t : ValueType
    {
        public ulong pathAppKey; // 0x10
        public ulong pathMessage; // 0x18
        public ulong pathMessageParam; // 0x20
        public ulong pathManifestPath; // 0x28
    }

    public class VREvent_InputBindingLoad_t : ValueType
    {
        public ulong ulAppContainer; // 0x10
        public ulong pathMessage; // 0x18
        public ulong pathUrl; // 0x20
        public ulong pathControllerType; // 0x28
    }

    public class VREvent_Ipd_t : ValueType
    {
        public float ipdMeters; // 0x10
    }

    public class VREvent_Keyboard_t : ValueType
    {
        public byte cNewInput; // 0x10
        public byte cNewInput1; // 0x11
        public byte cNewInput2; // 0x12
        public byte cNewInput3; // 0x13
        public byte cNewInput4; // 0x14
        public byte cNewInput5; // 0x15
        public byte cNewInput6; // 0x16
        public byte cNewInput7; // 0x17
        public ulong uUserValue; // 0x18
        public ulong overlayHandle; // 0x20

        // ── Methods ──
        public void get_cNewInput(){} // RVA: 0x7FFD54C201F0
    }

    public class VREvent_MessageOverlay_t : ValueType
    {
        public uint unVRMessageOverlayResponse; // 0x10
    }

    public class VREvent_Mouse_t : ValueType
    {
        public float x; // 0x10
        public float y; // 0x14
        public uint button; // 0x18
        public uint cursorIndex; // 0x1C
    }

    public class VREvent_Notification_t : ValueType
    {
        public ulong ulUserValue; // 0x10
        public uint notificationId; // 0x18
    }

    public class VREvent_Overlay_t : ValueType
    {
        public ulong overlayHandle; // 0x10
        public ulong devicePath; // 0x18
        public ulong memoryBlockId; // 0x20
        public uint cursorIndex; // 0x28
    }

    public class VREvent_PerformanceTest_t : ValueType
    {
        public uint m_nFidelityLevel; // 0x10
    }

    public class VREvent_Process_t : ValueType
    {
        public uint pid; // 0x10
        public uint oldPid; // 0x14
        public bool bForced; // 0x18
        public bool bConnectionLost; // 0x19
    }

    public class VREvent_ProgressUpdate_t : ValueType
    {
        public ulong ulApplicationPropertyContainer; // 0x10
        public ulong pathDevice; // 0x18
        public ulong pathInputSource; // 0x20
        public ulong pathProgressAction; // 0x28
        public ulong pathIcon; // 0x30
        public float fProgress; // 0x38
    }

    public class VREvent_Property_t : ValueType
    {
        public ulong container; // 0x10
        public lNextEvent prop; // 0x18
    }

    public class VREvent_Reserved_t : ValueType
    {
        public ulong reserved0; // 0x10
        public ulong reserved1; // 0x18
        public ulong reserved2; // 0x20
        public ulong reserved3; // 0x28
        public ulong reserved4; // 0x30
        public ulong reserved5; // 0x38
    }

    public class VREvent_ScreenshotProgress_t : ValueType
    {
        public float progress; // 0x10
    }

    public class VREvent_Screenshot_t : ValueType
    {
        public uint handle; // 0x10
        public uint type; // 0x14
    }

    public class VREvent_Scroll_t : ValueType
    {
        public float xdelta; // 0x10
        public float ydelta; // 0x14
        public uint unused; // 0x18
        public float viewportscale; // 0x1C
        public uint cursorIndex; // 0x20
    }

    public class VREvent_SeatedZeroPoseReset_t : ValueType
    {
        public bool bResetBySystemMenu; // 0x10
    }

    public class VREvent_ShowDevTools_t : ValueType
    {
        public int nBrowserIdentifier; // 0x10
    }

    public class VREvent_ShowUI_t : ValueType
    {
        public ÌÍÌÎÏ eType; // 0x10
    }

    public class VREvent_SpatialAnchor_t : ValueType
    {
        public uint unHandle; // 0x10
    }

    public class VREvent_Status_t : ValueType
    {
        public uint statusState; // 0x10
    }

    public class VREvent_TouchPadMove_t : ValueType
    {
        public bool bFingerDown; // 0x10
        public float flSecondsFingerDown; // 0x14
        public float fValueXFirst; // 0x18
        public float fValueYFirst; // 0x1C
        public float fValueXRaw; // 0x20
        public float fValueYRaw; // 0x24
    }

    public class VREvent_WebConsole_t : ValueType
    {
        public ulong webConsoleHandle; // 0x10
    }

    public class VREvent_t : ValueType
    {
        public uint eventType; // 0x10
        public uint trackedDeviceIndex; // 0x14
        public float eventAgeSeconds; // 0x18
        public llNextEventUnion data; // 0x20
    }

    public class VREvent_t_Packed : ValueType
    {
        public uint eventType; // 0x10
        public uint trackedDeviceIndex; // 0x14
        public float eventAgeSeconds; // 0x18
        public llNextEventUnion data; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54C20300
        public void Unpack(){} // RVA: 0x7FFD54C20330
    }

    public class VRNativeDevice_t : ValueType
    {
        public UIntPtr handle; // 0x10
        public ÌÌÎÍÍÍÍÍ eType; // 0x18
    }

    public class VROverlayIntersectionMaskPrimitive_Data_t : ValueType
    {
        public isplayMCImageNumChannels_Int32 m_Rectangle; // 0x10
        public romPhotonsToVblank_Float m_Circle; // 0x10
    }

    public class VROverlayIntersectionMaskPrimitive_t : ValueType
    {
        public brationAction m_nPrimitiveType; // 0x10
        public ithPoseUnion m_Primitive; // 0x14
    }

    public class VROverlayIntersectionParams_t : ValueType
    {
        public VRChaperone vSource; // 0x10
        public VRChaperone vDirection; // 0x1C
        public kedDeviceProperty eOrigin; // 0x28
    }

    public class VROverlayIntersectionResults_t : ValueType
    {
        public VRChaperone vPoint; // 0x10
        public VRChaperone vNormal; // 0x1C
        public tor vUVs; // 0x28
        public float fDistance; // 0x30
    }

    public class VROverlayProjection_t : ValueType
    {
        public float fLeft; // 0x10
        public float fRight; // 0x14
        public float fTop; // 0x18
        public float fBottom; // 0x1C
    }

    public class VROverlayView_t : ValueType
    {
        public ulong overlayHandle; // 0x10
        public entStatePacked texture; // 0x18
        public ApplicationType textureBounds; // 0x28
    }

    public class VRSkeletalSummaryData_t : ValueType
    {
        public float flFingerCurl0; // 0x10
        public float flFingerCurl1; // 0x14
        public float flFingerCurl2; // 0x18
        public float flFingerCurl3; // 0x1C
        public float flFingerCurl4; // 0x20
        public float flFingerSplay0; // 0x24
        public float flFingerSplay1; // 0x28
        public float flFingerSplay2; // 0x2C
        public float flFingerSplay3; // 0x30
    }

    public class VRTextureBounds_t : ValueType
    {
        public float uMin; // 0x10
        public float vMin; // 0x14
        public float uMax; // 0x18
        public float vMax; // 0x1C
    }

    public class VRTextureDepthInfo_t : ValueType
    {
        public UIntPtr handle; // 0x10
        public mera mProjection; // 0x18
        public tor vRange; // 0x58
    }

    public class VRTextureWithDepth_t : ValueType
    {
        public UIntPtr handle; // 0x10
        public lyTransform eType; // 0x18
        public oleForTrackedDeviceIndex eColorSpace; // 0x1C
        public utdownInternal depth; // 0x20
    }

    public class VRTextureWithPoseAndDepth_t : ValueType
    {
        public UIntPtr handle; // 0x10
        public lyTransform eType; // 0x18
        public oleForTrackedDeviceIndex eColorSpace; // 0x1C
        public hPosePacked mDeviceToAbsoluteTracking; // 0x20
        public utdownInternal depth; // 0x50
    }

    public class VRTextureWithPose_t : ValueType
    {
        public UIntPtr handle; // 0x10
        public lyTransform eType; // 0x18
        public oleForTrackedDeviceIndex eColorSpace; // 0x1C
        public hPosePacked mDeviceToAbsoluteTracking; // 0x20
    }

    public class VRVulkanDevice_t : ValueType
    {
        public UIntPtr m_pInstance; // 0x10
        public UIntPtr m_pDevice; // 0x18
        public UIntPtr m_pPhysicalDevice; // 0x20
        public UIntPtr m_pQueue; // 0x28
        public uint m_uQueueFamilyIndex; // 0x30
    }

    public class VRVulkanTextureArrayData_t : ValueType
    {
        public uint m_unArrayIndex; // 0x10
        public uint m_unArraySize; // 0x14
    }

    public class VRVulkanTextureData_t : ValueType
    {
        public ulong m_nImage; // 0x10
        public UIntPtr m_pDevice; // 0x18
        public UIntPtr m_pPhysicalDevice; // 0x20
        public UIntPtr m_pInstance; // 0x28
        public UIntPtr m_pQueue; // 0x30
        public uint m_nQueueFamilyIndex; // 0x38
        public uint m_nWidth; // 0x3C
        public uint m_nHeight; // 0x40
        public uint m_nFormat; // 0x44
        public uint m_nSampleCount; // 0x48
    }

}