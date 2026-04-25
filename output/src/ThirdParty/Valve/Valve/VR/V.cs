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
        public Valve.VR.HmdVector4_t position; // 0x10
        public Valve.VR.HmdQuaternionf_t orientation; // 0x20
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
        public Valve.VR.VRControllerAxis_t rAxis0; // 0x28
        public Valve.VR.VRControllerAxis_t rAxis1; // 0x30
        public Valve.VR.VRControllerAxis_t rAxis2; // 0x38
        public Valve.VR.VRControllerAxis_t rAxis3; // 0x40
        public Valve.VR.VRControllerAxis_t rAxis4; // 0x48
    }

    public class VRControllerState_t_Packed : ValueType
    {
        public uint unPacketNum; // 0x10
        public ulong ulButtonPressed; // 0x14
        public ulong ulButtonTouched; // 0x1C
        public Valve.VR.VRControllerAxis_t rAxis0; // 0x24
        public Valve.VR.VRControllerAxis_t rAxis1; // 0x2C
        public Valve.VR.VRControllerAxis_t rAxis2; // 0x34
        public Valve.VR.VRControllerAxis_t rAxis3; // 0x3C
        public Valve.VR.VRControllerAxis_t rAxis4; // 0x44

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8985E20
        public void Unpack(){} // RVA: 0x7FFAC8985E50
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
        public Valve.VR.VREvent_Reserved_t reserved; // 0x10
        public Valve.VR.VREvent_Controller_t controller; // 0x10
        public Valve.VR.VREvent_Mouse_t mouse; // 0x10
        public Valve.VR.VREvent_Scroll_t scroll; // 0x10
        public Valve.VR.VREvent_Process_t process; // 0x10
        public Valve.VR.VREvent_Notification_t notification; // 0x10
        public Valve.VR.VREvent_Overlay_t overlay; // 0x10
        public Valve.VR.VREvent_Status_t status; // 0x10
        public Valve.VR.VREvent_Ipd_t ipd; // 0x10
        public Valve.VR.VREvent_Chaperone_t chaperone; // 0x10
        public Valve.VR.VREvent_PerformanceTest_t performanceTest; // 0x10
        public Valve.VR.VREvent_TouchPadMove_t touchPadMove; // 0x10
        public Valve.VR.VREvent_SeatedZeroPoseReset_t seatedZeroPoseReset; // 0x10
        public Valve.VR.VREvent_Screenshot_t screenshot; // 0x10
        public Valve.VR.VREvent_ScreenshotProgress_t screenshotProgress; // 0x10
        public Valve.VR.VREvent_ApplicationLaunch_t applicationLaunch; // 0x10
        public Valve.VR.VREvent_EditingCameraSurface_t cameraSurface; // 0x10
        public Valve.VR.VREvent_MessageOverlay_t messageOverlay; // 0x10
        public Valve.VR.VREvent_Property_t property; // 0x10
        public Valve.VR.VREvent_HapticVibration_t hapticVibration; // 0x10
        public Valve.VR.VREvent_WebConsole_t webConsole; // 0x10
        public Valve.VR.VREvent_InputBindingLoad_t inputBinding; // 0x10
        public Valve.VR.VREvent_SpatialAnchor_t spatialAnchor; // 0x10
        public Valve.VR.VREvent_InputActionManifestLoad_t actionManifest; // 0x10
        public Valve.VR.VREvent_ProgressUpdate_t progressUpdate; // 0x10
        public Valve.VR.VREvent_ShowUI_t showUi; // 0x10
        public Valve.VR.VREvent_ShowDevTools_t showDevTools; // 0x10
        public Valve.VR.VREvent_HDCPError_t hdcpError; // 0x10
        public Valve.VR.VREvent_AudioVolumeControl_t audioVolumeControl; // 0x10
        public Valve.VR.VREvent_AudioMuteControl_t audioMuteControl; // 0x10
        public Valve.VR.VREvent_Keyboard_t keyboard; // 0x10
    }

    public class VREvent_EditingCameraSurface_t : ValueType
    {
        public ulong overlayHandle; // 0x10
        public uint nVisualMode; // 0x18
    }

    public class VREvent_HDCPError_t : ValueType
    {
        public 0x6B240448 eCode; // 0x10
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
        public void get_cNewInput(){} // RVA: 0x7FFAC98001F0
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
        public 0x6B2400D8 prop; // 0x18
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
        public 0x6B2403F0 eType; // 0x10
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
        public Valve.VR.VREvent_Data_t data; // 0x20
    }

    public class VREvent_t_Packed : ValueType
    {
        public uint eventType; // 0x10
        public uint trackedDeviceIndex; // 0x14
        public float eventAgeSeconds; // 0x18
        public Valve.VR.VREvent_Data_t data; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9800300
        public void Unpack(){} // RVA: 0x7FFAC9800330
    }

    public class VRNativeDevice_t : ValueType
    {
        public UIntPtr handle; // 0x10
        public 0x6B241208 eType; // 0x18
    }

    public class VROverlayIntersectionMaskPrimitive_Data_t : ValueType
    {
        public Valve.VR.IntersectionMaskRectangle_t m_Rectangle; // 0x10
        public Valve.VR.IntersectionMaskCircle_t m_Circle; // 0x10
    }

    public class VROverlayIntersectionMaskPrimitive_t : ValueType
    {
        public 0x6B241158 m_nPrimitiveType; // 0x10
        public Valve.VR.VROverlayIntersectionMaskPrimitive_Data_t m_Primitive; // 0x14
    }

    public class VROverlayIntersectionParams_t : ValueType
    {
        public Valve.VR.HmdVector3_t vSource; // 0x10
        public Valve.VR.HmdVector3_t vDirection; // 0x1C
        public 0x6B240028 eOrigin; // 0x28
    }

    public class VROverlayIntersectionResults_t : ValueType
    {
        public Valve.VR.HmdVector3_t vPoint; // 0x10
        public Valve.VR.HmdVector3_t vNormal; // 0x1C
        public Valve.VR.HmdVector2_t vUVs; // 0x28
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
        public Valve.VR.Texture_t texture; // 0x18
        public Valve.VR.VRTextureBounds_t textureBounds; // 0x28
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
        public Valve.VR.HmdMatrix44_t mProjection; // 0x18
        public Valve.VR.HmdVector2_t vRange; // 0x58
    }

    public class VRTextureWithDepth_t : ValueType
    {
        public UIntPtr handle; // 0x10
        public 0x6B23FE70 eType; // 0x18
        public 0x6B23FEC8 eColorSpace; // 0x1C
        public Valve.VR.VRTextureDepthInfo_t depth; // 0x20
    }

    public class VRTextureWithPoseAndDepth_t : ValueType
    {
        public UIntPtr handle; // 0x10
        public 0x6B23FE70 eType; // 0x18
        public 0x6B23FEC8 eColorSpace; // 0x1C
        public Valve.VR.HmdMatrix34_t mDeviceToAbsoluteTracking; // 0x20
        public Valve.VR.VRTextureDepthInfo_t depth; // 0x50
    }

    public class VRTextureWithPose_t : ValueType
    {
        public UIntPtr handle; // 0x10
        public 0x6B23FE70 eType; // 0x18
        public 0x6B23FEC8 eColorSpace; // 0x1C
        public Valve.VR.HmdMatrix34_t mDeviceToAbsoluteTracking; // 0x20
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