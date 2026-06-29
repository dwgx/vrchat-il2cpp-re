// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 100
// Methods: 738

public class OBJECT_ATTRIBUTES : ValueType
{
    public object Length;
    public object RootDirectory;
    public object ObjectName;
    public object Attributes;
    public object SecurityDescriptor;
    public object SecurityQualityOfService;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x8AB290
}

public class OVRDeserialize : Object
{
    // ── Methods ──
    public void ByteArrayToStructure(){} // RVA: 0xA94080
}

public class OVRMeshGenerator : Object
{
    // ── Methods ──
    public void GenerateMesh(){} // RVA: 0x6C1F340
    public void TransformVertices(){} // RVA: 0x6C1F7E0
    public void GenerateTrianglesFromBoundaryVertices(){} // RVA: 0x6C1FAC0
    public void GetWindingOrder(){} // RVA: 0x6C200F0
    public void PointInTriangle(){} // RVA: 0x6C20170
    public void Cross(){} // RVA: 0x26046D0
    public void Get(){} // RVA: 0x6C20270
    public void .ctor(){} // RVA: 0xB43310
}

public class OVRMeshJobs : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
}

public class OVRMixedRealityCaptureConfigurationExtensions : Object
{
    // ── Methods ──
    public void ApplyTo(){} // RVA: 0x6C21B30
    public void ReadFrom(){} // RVA: 0x6C21B40
}

public class OVRNetwork : Object
{
    public object MaxBufferLength;
    public object MaxPayloadLength;
    public object FrameHeaderMagicIdentifier;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
}

public class OVRNetworkTcpClient : Object
{
    public object connectionStateChangedCallback;
    public object payloadReceivedCallback;
    public object tcpClient;
    public object receivedBuffers;
    public object receivedBufferIndex;
    public object receivedBufferDataSize;
    public object readyReceiveDataEvent;

    // ── Methods ──
    public void get_connectionState(){} // RVA: 0x6C25DD0
    public void get_Connected(){} // RVA: 0x6C25E10
    public void Connect(){} // RVA: 0x6C25E60
    public void ConnectCallback(){} // RVA: 0x6C26040
    public void Disconnect(){} // RVA: 0x6C262E0
    public void Tick(){} // RVA: 0x6C26570
    public void OnReadDataCallback(){} // RVA: 0x6C267C0
    public void .ctor(){} // RVA: 0x6C26C30
}

public class OVRNetworkTcpServer : Object
{
    public object tcpListener;
    public object clientsLock;
    public object clients;

    // ── Methods ──
    public void StartListening(){} // RVA: 0x6C24540
    public void StopListening(){} // RVA: 0x6C24AB0
    public void DoAcceptTcpClientCallback(){} // RVA: 0x6C24D00
    public void HasConnectedClient(){} // RVA: 0x6C25300
    public void Broadcast(){} // RVA: 0x6C25590
    public void DoWriteDataCallback(){} // RVA: 0x6C25BC0
    public void .ctor(){} // RVA: 0x6C25C90
}

public class OVRP_1_18_0 : Object
{
    public object version;

    // ── Methods ──
    public void ovrp_SetHandNodePoseStateLatency(){} // RVA: 0x6BEF2A0
    public void ovrp_GetHandNodePoseStateLatency(){} // RVA: 0x6BEF320
    public void ovrp_GetAppHasInputFocus(){} // RVA: 0x6BEF3A0
    public void .cctor(){} // RVA: 0x6BEF420
}

public class OVRP_1_19_0 : Object
{
    public object version;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x6BEF4F0
}

public class OVRP_1_21_0 : Object
{
    public object version;

    // ── Methods ──
    public void ovrp_GetTiledMultiResSupported(){} // RVA: 0x6BEF5C0
    public void ovrp_GetTiledMultiResLevel(){} // RVA: 0x6BEF640
    public void ovrp_SetTiledMultiResLevel(){} // RVA: 0x6BEF6C0
    public void ovrp_GetGPUUtilSupported(){} // RVA: 0x6BEF740
    public void ovrp_GetGPUUtilLevel(){} // RVA: 0x6BEF7C0
    public void ovrp_GetSystemDisplayFrequency2(){} // RVA: 0x6BEF840
    public void ovrp_GetSystemDisplayAvailableFrequencies(){} // RVA: 0x6BEF8C0
    public void ovrp_SetSystemDisplayFrequency(){} // RVA: 0x6BEF950
    public void ovrp_GetAppAsymmetricFov(){} // RVA: 0x6BEF9D0
    public void .cctor(){} // RVA: 0x6BEFA50
}

public class OVRP_1_28_0 : Object
{
    public object version;

    // ── Methods ──
    public void ovrp_GetDominantHand(){} // RVA: 0x6BEFB20
    public void ovrp_SendEvent(){} // RVA: 0x6BEFBA0
    public void ovrp_EnqueueSetupLayer2(){} // RVA: 0x6BEFC70
    public void .cctor(){} // RVA: 0x6BEFD10
}

public class OVRP_1_29_0 : Object
{
    public object version;

    // ── Methods ──
    public void ovrp_GetLayerAndroidSurfaceObject(){} // RVA: 0x6BEFDE0
    public void ovrp_SetHeadPoseModifier(){} // RVA: 0x6BEFE70
    public void ovrp_GetHeadPoseModifier(){} // RVA: 0x6BEFF00
    public void ovrp_GetNodePoseStateRaw(){} // RVA: 0x6BEFF90
    public void .cctor(){} // RVA: 0x6BF0030
}

public class OVRP_1_30_0 : Object
{
    public object version;

    // ── Methods ──
    public void ovrp_GetCurrentTrackingTransformPose(){} // RVA: 0x6BF0100
    public void ovrp_GetTrackingTransformRawPose(){} // RVA: 0x6BF0180
    public void ovrp_SendEvent2(){} // RVA: 0x6BF0200
    public void ovrp_IsPerfMetricsSupported(){} // RVA: 0x6BF0300
    public void ovrp_GetPerfMetricsFloat(){} // RVA: 0x6BF0390
    public void ovrp_GetPerfMetricsInt(){} // RVA: 0x6BF0420
    public void .cctor(){} // RVA: 0x6BF04B0
}

public class OVRP_1_31_0 : Object
{
    public object version;

    // ── Methods ──
    public void ovrp_GetTimeInSeconds(){} // RVA: 0x6BF0580
    public void ovrp_SetColorScaleAndOffset(){} // RVA: 0x6BF0600
    public void .cctor(){} // RVA: 0x6BF06B0
}

public class OVRP_1_32_0 : Object
{
    public object version;

    // ── Methods ──
    public void ovrp_AddCustomMetadata(){} // RVA: 0x6BF0780
    public void .cctor(){} // RVA: 0x6BF0850
}

public class OVRP_1_34_0 : Object
{
    public object version;

    // ── Methods ──
    public void ovrp_EnqueueSubmitLayer2(){} // RVA: 0x6BF0920
    public void .cctor(){} // RVA: 0x6BF09D0
}

public class OVRP_1_35_0 : Object
{
    public object version;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x6BF0AA0
}

public class OVRP_1_36_0 : Object
{
    public object version;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x6BF0B70
}

public class OVRP_1_37_0 : Object
{
    public object version;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x6BF0C40
}

public class OVRP_1_38_0 : Object
{
    public object version;

    // ── Methods ──
    public void ovrp_GetTrackingTransformRelativePose(){} // RVA: 0x6BF0D10
    public void ovrp_Media_Initialize(){} // RVA: 0x6BF0DA0
    public void ovrp_Media_Shutdown(){} // RVA: 0x6BF0E10
    public void ovrp_Media_GetInitialized(){} // RVA: 0x6BF0E80
    public void ovrp_Media_Update(){} // RVA: 0x6BF0F00
    public void ovrp_Media_GetMrcActivationMode(){} // RVA: 0x6BF0F70
    public void ovrp_Media_SetMrcActivationMode(){} // RVA: 0x6BF0FF0
    public void ovrp_Media_IsMrcEnabled(){} // RVA: 0x6BF1070
    public void ovrp_Media_IsMrcActivated(){} // RVA: 0x6BF10F0
    public void ovrp_Media_UseMrcDebugCamera(){} // RVA: 0x6BF1170
    public void ovrp_Media_SetMrcInputVideoBufferType(){} // RVA: 0x6BF11F0
    public void ovrp_Media_GetMrcInputVideoBufferType(){} // RVA: 0x6BF1270
    public void ovrp_Media_SetMrcFrameSize(){} // RVA: 0x6BF12F0
    public void ovrp_Media_GetMrcFrameSize(){} // RVA: 0x6BF1380
    public void ovrp_Media_SetMrcAudioSampleRate(){} // RVA: 0x6BF1410
    public void ovrp_Media_GetMrcAudioSampleRate(){} // RVA: 0x6BF1490
    public void ovrp_Media_SetMrcFrameImageFlipped(){} // RVA: 0x6BF1510
    public void ovrp_Media_GetMrcFrameImageFlipped(){} // RVA: 0x6BF1590
    public void ovrp_Media_EncodeMrcFrame(){} // RVA: 0x6BF1610
    public void ovrp_Media_EncodeMrcFrameWithDualTextures(){} // RVA: 0x6BF16C0
    public void ovrp_Media_SyncMrcFrame(){} // RVA: 0x6BF1770
    public void ovrp_SetDeveloperMode(){} // RVA: 0x6BF17F0
    public void ovrp_GetNodeOrientationValid(){} // RVA: 0x6BF1870
    public void ovrp_GetNodePositionValid(){} // RVA: 0x6BF1900
    public void .cctor(){} // RVA: 0x6BF1990
}

public class OVRP_1_39_0 : Object
{
    public object version;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x6BF1A60
}

public class OVRP_1_40_0 : Object
{
    public object version;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x6BF1B30
}

public class OVRP_1_41_0 : Object
{
    public object version;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x6BF1C00
}

public class OVRP_1_42_0 : Object
{
    public object version;

    // ── Methods ──
    public void ovrp_GetAdaptiveGpuPerformanceScale2(){} // RVA: 0x6BF1CD0
    public void .cctor(){} // RVA: 0x6BF1D50
}

public class OVRP_1_43_0 : Object
{
    public object version;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x6BF1E20
}

public class OVRP_1_44_0 : Object
{
    public object version;

    // ── Methods ──
    public void ovrp_GetHandTrackingEnabled(){} // RVA: 0x6BF1EF0
    public void ovrp_GetHandState(){} // RVA: 0x6BF1F70
    public void ovrp_GetSkeleton(){} // RVA: 0x6BF2000
    public void ovrp_GetMesh(){} // RVA: 0x6BF2130
    public void ovrp_OverrideExternalCameraFov(){} // RVA: 0x6BF21C0
    public void ovrp_GetUseOverriddenExternalCameraFov(){} // RVA: 0x6BF2250
    public void ovrp_OverrideExternalCameraStaticPose(){} // RVA: 0x6BF22E0
    public void ovrp_GetUseOverriddenExternalCameraStaticPose(){} // RVA: 0x6BF2370
    public void ovrp_ResetDefaultExternalCamera(){} // RVA: 0x6BF2400
    public void ovrp_SetDefaultExternalCamera(){} // RVA: 0x6BF2470
    public void ovrp_GetLocalTrackingSpaceRecenterCount(){} // RVA: 0x6BF2530
    public void .cctor(){} // RVA: 0x6BF25B0
}

public class OVRP_1_45_0 : Object
{
    public object version;

    // ── Methods ──
    public void ovrp_GetSystemHmd3DofModeEnabled(){} // RVA: 0x6BF2680
    public void ovrp_Media_SetAvailableQueueIndexVulkan(){} // RVA: 0x6BF2700
    public void .cctor(){} // RVA: 0x6BF2780
}

public class OVRP_1_46_0 : Object
{
    public object version;

    // ── Methods ──
    public void ovrp_GetTiledMultiResDynamic(){} // RVA: 0x6BF2850
    public void ovrp_SetTiledMultiResDynamic(){} // RVA: 0x6BF28D0
    public void .cctor(){} // RVA: 0x6BF2950
}

public class OVRP_1_47_0 : Object
{
    public object version;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x6BF2A20
}

public class OVRP_1_48_0 : Object
{
    public object version;

    // ── Methods ──
    public void ovrp_SetExternalCameraProperties(){} // RVA: 0x6BF2AF0
    public void .cctor(){} // RVA: 0x6BF2BB0
}

public class OVRP_1_49_0 : Object
{
    public object version;
    public object OVRP_ANCHOR_NAME_SIZE;

    // ── Methods ──
    public void ovrp_SetClientColorDesc(){} // RVA: 0x6BF2C80
    public void ovrp_GetHmdColorDesc(){} // RVA: 0x6BF2D00
    public void ovrp_Media_EncodeMrcFrameWithPoseTime(){} // RVA: 0x6BF2D80
    public void ovrp_Media_EncodeMrcFrameDualTexturesWithPoseTime(){} // RVA: 0x6BF2E30
    public void ovrp_Media_SetHeadsetControllerPose(){} // RVA: 0x6BF2EE0
    public void ovrp_Media_EnumerateCameraAnchorHandles(){} // RVA: 0x6BF2FE0
    public void ovrp_Media_GetCurrentCameraAnchorHandle(){} // RVA: 0x6BF3070
    public void ovrp_Media_GetCameraAnchorName(){} // RVA: 0x6BF30F0
    public void ovrp_Media_GetCameraAnchorHandle(){} // RVA: 0x6BF31F0
    public void ovrp_Media_GetCameraAnchorType(){} // RVA: 0x6BF3280
    public void ovrp_Media_CreateCustomCameraAnchor(){} // RVA: 0x6BF3310
    public void ovrp_Media_DestroyCustomCameraAnchor(){} // RVA: 0x6BF33A0
    public void ovrp_Media_GetCustomCameraAnchorPose(){} // RVA: 0x6BF3420
    public void ovrp_Media_SetCustomCameraAnchorPose(){} // RVA: 0x6BF34B0
    public void ovrp_Media_GetCameraMinMaxDistance(){} // RVA: 0x6BF3560
    public void ovrp_Media_SetCameraMinMaxDistance(){} // RVA: 0x6BF3600
    public void .cctor(){} // RVA: 0x6BF36A0
}

public class OVRP_1_50_0 : Object
{
    public object version;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x6BF3770
}

public class OVRP_1_51_0 : Object
{
    public object version;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x6BF3840
}

public class OVRP_1_52_0 : Object
{
    public object version;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x6BF3910
}

public class OVRP_1_53_0 : Object
{
    public object version;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x6BF39E0
}

public class OVRP_1_54_0 : Object
{
    public object version;

    // ── Methods ──
    public void ovrp_Media_SetPlatformInitialized(){} // RVA: 0x6BF3AB0
    public void .cctor(){} // RVA: 0x6BF3B20
}

public class OVRP_1_55_0 : Object
{
    public object version;

    // ── Methods ──
    public void ovrp_GetSkeleton2(){} // RVA: 0x6BF3BF0
    public void ovrp_PollEvent(){} // RVA: 0x6BF3C80
    public void ovrp_GetNativeXrApiType(){} // RVA: 0x6BF3EF0
    public void ovrp_GetNativeOpenXRHandles(){} // RVA: 0x6BF3F70
    public void .cctor(){} // RVA: 0x6BF4000
}

public class OVRP_1_55_1 : Object
{
    public object version;

    // ── Methods ──
    public void ovrp_PollEvent2(){} // RVA: 0x6BF40D0
    public void .cctor(){} // RVA: 0x6BF4160
}

public class OVRP_1_56_0 : Object
{
    public object version;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x6BF4230
}

public class OVRP_1_57_0 : Object
{
    public object version;

    // ── Methods ──
    public void ovrp_Media_GetPlatformCameraMode(){} // RVA: 0x6BF4300
    public void ovrp_Media_SetPlatformCameraMode(){} // RVA: 0x6BF4380
    public void ovrp_SetEyeFovPremultipliedAlphaMode(){} // RVA: 0x6BF4400
    public void ovrp_GetEyeFovPremultipliedAlphaMode(){} // RVA: 0x6BF4480
    public void ovrp_SetKeyboardOverlayUV(){} // RVA: 0x6BF4500
    public void .cctor(){} // RVA: 0x6BF4590
}

public class OVRP_1_58_0 : Object
{
    public object version;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x6BF4660
}

public class OVRP_1_59_0 : Object
{
    public object version;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x6BF4730
}

public class OVRP_1_60_0 : Object
{
    public object version;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x6BF4800
}

public class OVRP_1_61_0 : Object
{
    public object version;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x6BF48D0
}

public class OVRP_1_62_0 : Object
{
    public object version;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x6BF49A0
}

public class OVRP_1_63_0 : Object
{
    public object version;

    // ── Methods ──
    public void ovrp_InitializeInsightPassthrough(){} // RVA: 0x6BF4A70
    public void ovrp_ShutdownInsightPassthrough(){} // RVA: 0x6BF4AE0
    public void ovrp_GetInsightPassthroughInitialized(){} // RVA: 0x6BF4B50
    public void ovrp_SetInsightPassthroughStyle(){} // RVA: 0x6BF4BC0
    public void ovrp_CreateInsightTriangleMesh(){} // RVA: 0x6BF4C70
    public void ovrp_DestroyInsightTriangleMesh(){} // RVA: 0x6BF4D20
    public void ovrp_AddInsightPassthroughSurfaceGeometry(){} // RVA: 0x6BF4DA0
    public void ovrp_DestroyInsightPassthroughGeometryInstance(){} // RVA: 0x6BF4E70
    public void ovrp_UpdateInsightPassthroughGeometryTransform(){} // RVA: 0x6BF4EF0
    public void .cctor(){} // RVA: 0x6BF4FA0
}

public class OVRP_1_64_0 : Object
{
    public object version;

    // ── Methods ──
    public void ovrp_LocateSpace(){} // RVA: 0x6BF5070
    public void .cctor(){} // RVA: 0x6BF5110
}

public class OVRP_1_65_0 : Object
{
    public object version;

    // ── Methods ──
    public void ovrp_KtxLoadFromMemory(){} // RVA: 0x6BF51E0
    public void ovrp_KtxTextureWidth(){} // RVA: 0x6BF5280
    public void ovrp_KtxTextureHeight(){} // RVA: 0x6BF5310
    public void ovrp_KtxTranscode(){} // RVA: 0x6BF53A0
    public void ovrp_KtxGetTextureData(){} // RVA: 0x6BF5430
    public void ovrp_KtxTextureSize(){} // RVA: 0x6BF54D0
    public void ovrp_KtxDestroy(){} // RVA: 0x6BF5560
    public void ovrp_DestroySpace(){} // RVA: 0x6BF55E0
    public void .cctor(){} // RVA: 0x6BF5660
}

public class OVRP_1_66_0 : Object
{
    public object version;

    // ── Methods ──
    public void ovrp_GetInsightPassthroughInitializationState(){} // RVA: 0x6BF5730
    public void ovrp_Media_IsCastingToRemoteClient(){} // RVA: 0x6BF57A0
    public void .cctor(){} // RVA: 0x6BF5820
}

public class OVRP_1_67_0 : Object
{
    public object version;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x6BF58F0
}

public class OVRP_1_68_0 : Object
{
    public object version;
    public object OVRP_RENDER_MODEL_MAX_PATH_LENGTH;
    public object OVRP_RENDER_MODEL_MAX_NAME_LENGTH;

    // ── Methods ──
    public void ovrp_LoadRenderModel(){} // RVA: 0x6BF59C0
    public void ovrp_GetRenderModelPaths(){} // RVA: 0x6BF5A60
    public void ovrp_GetRenderModelProperties(){} // RVA: 0x6BF5AF0
    public void ovrp_SetInsightPassthroughKeyboardHandsIntensity(){} // RVA: 0x6BF5C50
    public void ovrp_StartKeyboardTracking(){} // RVA: 0x6BF5CE0
    public void ovrp_StopKeyboardTracking(){} // RVA: 0x6BF5D60
    public void ovrp_GetSystemKeyboardDescription(){} // RVA: 0x6BF5DD0
    public void ovrp_GetKeyboardState(){} // RVA: 0x6BF60F0
    public void .cctor(){} // RVA: 0x6BF6180
}

public class OVRP_1_69_0 : Object
{
    public object version;

    // ── Methods ──
    public void ovrp_GetNodePoseStateImmediate(){} // RVA: 0x6BF6250
    public void .cctor(){} // RVA: 0x6BF62E0
}

public class OVRP_1_70_0 : Object
{
    public object version;

    // ── Methods ──
    public void ovrp_SetLogCallback2(){} // RVA: 0x6BF63B0
    public void .cctor(){} // RVA: 0x6BF6440
}

public class OVRP_1_71_0 : Object
{
    public object version;

    // ── Methods ──
    public void ovrp_IsInsightPassthroughSupported(){} // RVA: 0x6BF6510
    public void ovrp_UnityOpenXR_SetClientVersion(){} // RVA: 0x6BF6590
    public void ovrp_UnityOpenXR_HookGetInstanceProcAddr(){} // RVA: 0x6BF6620
    public void ovrp_UnityOpenXR_OnInstanceCreate(){} // RVA: 0x6BF66A0
    public void ovrp_UnityOpenXR_OnInstanceDestroy(){} // RVA: 0x6BF6720
    public void ovrp_UnityOpenXR_OnSessionCreate(){} // RVA: 0x6BF67A0
    public void ovrp_UnityOpenXR_OnAppSpaceChange(){} // RVA: 0x6BF6820
    public void ovrp_UnityOpenXR_OnSessionStateChange(){} // RVA: 0x6BF68A0
    public void ovrp_UnityOpenXR_OnSessionBegin(){} // RVA: 0x6BF6930
    public void ovrp_UnityOpenXR_OnSessionEnd(){} // RVA: 0x6BF69B0
    public void ovrp_UnityOpenXR_OnSessionExiting(){} // RVA: 0x6BF6A30
    public void ovrp_UnityOpenXR_OnSessionDestroy(){} // RVA: 0x6BF6AB0
    public void ovrp_SetSuggestedCpuPerformanceLevel(){} // RVA: 0x6BF6B30
    public void ovrp_GetSuggestedCpuPerformanceLevel(){} // RVA: 0x6BF6BB0
    public void ovrp_SetSuggestedGpuPerformanceLevel(){} // RVA: 0x6BF6C30
    public void ovrp_GetSuggestedGpuPerformanceLevel(){} // RVA: 0x6BF6CB0
    public void .cctor(){} // RVA: 0x6BF6D30
}

public class OVRP_1_72_0 : Object
{
    public object version;

    // ── Methods ──
    public void ovrp_CreateSpatialAnchor(){} // RVA: 0x6BF6E00
    public void ovrp_SetSpaceComponentStatus(){} // RVA: 0x6BF6E90
    public void ovrp_GetSpaceComponentStatus(){} // RVA: 0x6BF6F40
    public void ovrp_EnumerateSpaceSupportedComponents(){} // RVA: 0x6BF6FE0
    public void ovrp_SaveSpace(){} // RVA: 0x6BF7090
    public void ovrp_QuerySpaces(){} // RVA: 0x6BF7130
    public void ovrp_RetrieveSpaceQueryResults(){} // RVA: 0x6BF7400
    public void ovrp_EraseSpace(){} // RVA: 0x6BF74A0
    public void ovrp_GetSpaceContainer(){} // RVA: 0x6BF7540
    public void ovrp_GetSpaceBoundingBox2D(){} // RVA: 0x6BF75D0
    public void ovrp_GetSpaceBoundingBox3D(){} // RVA: 0x6BF7660
    public void ovrp_GetSpaceSemanticLabels(){} // RVA: 0x6BF76F0
    public void ovrp_GetSpaceRoomLayout(){} // RVA: 0x6BF7780
    public void ovrp_GetSpaceBoundary2D(){} // RVA: 0x6BF7810
    public void ovrp_RequestSceneCapture(){} // RVA: 0x6BF78A0
    public void .cctor(){} // RVA: 0x6BF7A80
}

public class OVRP_1_73_0 : Object
{
    public object version;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x6BF7B50
}

public class OVRP_1_74_0 : Object
{
    public object version;
    public object OVRP_MAX_VIRTUAL_KEYBOARD_KEY_LABEL_SIZE;

    // ── Methods ──
    public void ovrp_GetSpaceUuid(){} // RVA: 0x6BF7C20
    public void ovrp_GetRenderModelProperties2(){} // RVA: 0x6BF7CB0
    public void .cctor(){} // RVA: 0x6BF7E10
}

public class OVRP_1_75_0 : Object
{
    public object version;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x6BF7EE0
}

public class OVRP_1_76_0 : Object
{
    public object version;

    // ── Methods ──
    public void ovrp_GetNodePoseStateAtTime(){} // RVA: 0x6BF7FB0
    public void .cctor(){} // RVA: 0x6BF8050
}

public class OVRP_1_78_0 : Object
{
    public object version;

    // ── Methods ──
    public void ovrp_GetPassthroughCapabilityFlags(){} // RVA: 0x6BF8120
    public void ovrp_GetFoveationEyeTrackedSupported(){} // RVA: 0x6BF81A0
    public void ovrp_GetFoveationEyeTracked(){} // RVA: 0x6BF8220
    public void ovrp_SetFoveationEyeTracked(){} // RVA: 0x6BF82A0
    public void ovrp_StartFaceTracking(){} // RVA: 0x6BF8320
    public void ovrp_StopFaceTracking(){} // RVA: 0x6BF8390
    public void ovrp_StartBodyTracking(){} // RVA: 0x6BF8400
    public void ovrp_StopBodyTracking(){} // RVA: 0x6BF8470
    public void ovrp_StartEyeTracking(){} // RVA: 0x6BF84E0
    public void ovrp_StopEyeTracking(){} // RVA: 0x6BF8550
    public void ovrp_GetEyeTrackingSupported(){} // RVA: 0x6BF85C0
    public void ovrp_GetFaceTrackingSupported(){} // RVA: 0x6BF8640
    public void ovrp_GetBodyTrackingEnabled(){} // RVA: 0x6BF86C0
    public void ovrp_GetBodyTrackingSupported(){} // RVA: 0x6BF8740
    public void ovrp_GetBodyState(){} // RVA: 0x6BF87C0
    public void ovrp_GetFaceTrackingEnabled(){} // RVA: 0x6BF8850
    public void ovrp_GetFaceState(){} // RVA: 0x6BF88D0
    public void ovrp_GetEyeTrackingEnabled(){} // RVA: 0x6BF8960
    public void ovrp_GetEyeGazesState(){} // RVA: 0x6BF89E0
    public void ovrp_FeatureFidelitySetFeatureEnable(){} // RVA: 0x6BF8A70
    public void ovrp_FeatureFidelitySetFeatureFidelity(){} // RVA: 0x6BF8B00
    public void ovrp_FeatureFidelityGetFeatureState(){} // RVA: 0x6BF8B90
    public void ovrp_GetControllerState5(){} // RVA: 0x6BF8C30
    public void ovrp_SetControllerLocalizedVibration(){} // RVA: 0x6BF8CC0
    public void ovrp_GetLocalDimmingSupported(){} // RVA: 0x6BF8D70
    public void ovrp_SetLocalDimming(){} // RVA: 0x6BF8DF0
    public void ovrp_GetLocalDimming(){} // RVA: 0x6BF8E70
    public void ovrp_GetCurrentInteractionProfile(){} // RVA: 0x6BF8EF0
    public void .cctor(){} // RVA: 0x6BF8F80
}

public class OVRPlugin : Object
{
    public object isSupportedPlatform;
    public object wrapperVersion;
    public object _version;
    public object _nativeSDKVersion;
    public object MAX_CPU_CORES;
    public object OverlayShapeFlagShift;
    public object AppPerfFrameStatsMaxCount;
    public object EventDataBufferSize;
    public object RENDER_MODEL_NULL_KEY;
    public object SpaceFilterInfoIdsMaxSize;
    public object SpaceFilterInfoComponentsMaxSize;
    public object SpatialEntityMaxQueryResultsPerEvent;
    public object _nativeXrApi;
    public object _nativeAudioOutGuid;
    public object _cachedAudioOutGuid;
    public object _cachedAudioOutString;
    public object _nativeAudioInGuid;
    public object _cachedAudioInGuid;
    public object _cachedAudioInString;
    public object perfStatWarningPrinted;
    public object resetPerfStatWarningPrinted;
    public object cachedCameraFrameTexture;
    public object cachedCameraDepthTexture;
    public object cachedCameraDepthConfidenceTexture;
    public object _nativeSystemDisplayFrequenciesAvailable;
    public object _cachedSystemDisplayFrequenciesAvailable;
    public object cachedHandState;
    public object cachedSkeleton;
    public object cachedSkeleton2;
    public object cachedFaceState;
    public object cachedEyeGazesState;
    public object pluginName;
    public object _versionZero;

    // ── Methods ──
    public void get_version(){} // RVA: 0x6BBF460
    public void get_nativeSDKVersion(){} // RVA: 0x6BBFCA0
    public void SetLogCallback2(){} // RVA: 0x6BC0150
    public void get_initialized(){} // RVA: 0x6BC0340
    public void get_nativeXrApi(){} // RVA: 0x6BC03F0
    public void get_chromatic(){} // RVA: 0x6BC0690
    public void set_chromatic(){} // RVA: 0x6BC0840
    public void get_monoscopic(){} // RVA: 0x6BC0A20
    public void set_monoscopic(){} // RVA: 0x6BC0B00
    public void get_rotation(){} // RVA: 0x6BC0C00
    public void set_rotation(){} // RVA: 0x6BC0CE0
    public void get_position(){} // RVA: 0x6BC0DE0
    public void set_position(){} // RVA: 0x6BC0EC0
    public void get_useIPDInPositionTracking(){} // RVA: 0x6BC0FC0
    public void set_useIPDInPositionTracking(){} // RVA: 0x6BC1190
    public void get_positionSupported(){} // RVA: 0x6BC1370
    public void get_positionTracked(){} // RVA: 0x6BC1450
    public void get_powerSaving(){} // RVA: 0x6BC14E0
    public void get_hmdPresent(){} // RVA: 0x6BC15C0
    public void get_userPresent(){} // RVA: 0x6BC1650
    public void get_headphonesPresent(){} // RVA: 0x6BC1730
    public void get_recommendedMSAALevel(){} // RVA: 0x6BC1810
    public void get_systemRegion(){} // RVA: 0x6BC19E0
    public void get_audioOutId(){} // RVA: 0x6BC1BA0
    public void get_audioInId(){} // RVA: 0x6BC2030
    public void get_hasVrFocus(){} // RVA: 0x6BC24C0
    public void get_hasInputFocus(){} // RVA: 0x6BC2570
    public void get_shouldQuit(){} // RVA: 0x6BC2720
    public void get_shouldRecenter(){} // RVA: 0x6BC27D0
    public void get_productName(){} // RVA: 0x6BC2880
    public void get_latency(){} // RVA: 0x6BC29B0
    public void get_eyeDepth(){} // RVA: 0x6BC2B30
    public void set_eyeDepth(){} // RVA: 0x6BC2C10
    public void get_eyeHeight(){} // RVA: 0x6BC2CD0
    public void set_eyeHeight(){} // RVA: 0x6BC2D70
    public void get_batteryLevel(){} // RVA: 0x6BC2E30
    public void get_batteryTemperature(){} // RVA: 0x6BC2ED0
    public void get_suggestedCpuPerfLevel(){} // RVA: 0x6BC2F70
    public void set_suggestedCpuPerfLevel(){} // RVA: 0x6BC3120
    public void get_suggestedGpuPerfLevel(){} // RVA: 0x6BC32B0
    public void set_suggestedGpuPerfLevel(){} // RVA: 0x6BC3460
    public void get_cpuLevel(){} // RVA: 0x6BC35F0
    public void set_cpuLevel(){} // RVA: 0x6BC3690
    public void get_gpuLevel(){} // RVA: 0x6BC3740
    public void set_gpuLevel(){} // RVA: 0x6BC37E0
    public void get_vsyncCount(){} // RVA: 0x6BC3890
    public void set_vsyncCount(){} // RVA: 0x6BC3930
    public void get_systemVolume(){} // RVA: 0x6BC39E0
    public void get_ipd(){} // RVA: 0x6BC3A80
    public void set_ipd(){} // RVA: 0x6BC3B20
    public void get_occlusionMesh(){} // RVA: 0x6BC3BE0
    public void set_occlusionMesh(){} // RVA: 0x6BC3CC0
    public void get_batteryStatus(){} // RVA: 0x6BC3DC0
    public void GetEyeFrustum(){} // RVA: 0x6BC3E60
    public void GetEyeTextureSize(){} // RVA: 0x6BC3F30
    public void GetTrackerPose(){} // RVA: 0x6BC3FE0
    public void GetTrackerFrustum(){} // RVA: 0x6BC4060
    public void ShowUI(){} // RVA: 0x6BC4130
    public void EnqueueSubmitLayer(){} // RVA: 0x6BC41F0
    public void CalculateLayerDesc(){} // RVA: 0x6BC4970
    public void EnqueueSetupLayer(){} // RVA: 0x6BC4C30
    public void EnqueueDestroyLayer(){} // RVA: 0x6BC5270
    public void GetLayerTexture(){} // RVA: 0x6BC5440
    public void GetLayerTextureStageCount(){} // RVA: 0x6BC5630
    public void GetLayerAndroidSurfaceObject(){} // RVA: 0x6BC5810
    public void UpdateNodePhysicsPoses(){} // RVA: 0x6BC59E0
    public void GetNodePose(){} // RVA: 0x6BC5BA0
    public void GetNodeVelocity(){} // RVA: 0x6BC5FA0
    public void GetNodeAngularVelocity(){} // RVA: 0x6BC63B0
    public void GetNodeAcceleration(){} // RVA: 0x6BC65B0
    public void GetNodeAngularAcceleration(){} // RVA: 0x6BC69B0
    public void GetNodePresent(){} // RVA: 0x6BC6BB0
    public void GetNodeOrientationTracked(){} // RVA: 0x6BC6C10
    public void GetNodeOrientationValid(){} // RVA: 0x6BC6CD0
    public void GetNodePositionTracked(){} // RVA: 0x6BC6EC0
    public void GetNodePositionValid(){} // RVA: 0x6BC6F20
    public void GetNodePoseStateRaw(){} // RVA: 0x6BC7150
    public void GetNodePoseStateAtTime(){} // RVA: 0x6BC7570
    public void GetNodePoseStateImmediate(){} // RVA: 0x6BC7810
    public void GetCurrentTrackingTransformPose(){} // RVA: 0x6BC7AA0
    public void GetTrackingTransformRawPose(){} // RVA: 0x6BC7CC0
    public void GetTrackingTransformRelativePose(){} // RVA: 0x6BC7EE0
    public void GetControllerState(){} // RVA: 0x6BC8150
    public void GetControllerState2(){} // RVA: 0x6BC8230
    public void GetControllerState4(){} // RVA: 0x6BC84D0
    public void GetControllerState5(){} // RVA: 0x6BC88C0
    public void GetCurrentInteractionProfile(){} // RVA: 0x6BC8D20
    public void SetControllerVibration(){} // RVA: 0x6BC8EC0
    public void SetControllerLocalizedVibration(){} // RVA: 0x6BC8FA0
    public void GetControllerHapticsDesc(){} // RVA: 0x6BC9170
    public void GetControllerHapticsState(){} // RVA: 0x6BC9350
    public void SetControllerHaptics(){} // RVA: 0x6BC94F0
    public void GetEyeRecommendedResolutionScale(){} // RVA: 0x6BC96B0
    public void GetAppCpuStartToGpuEndTime(){} // RVA: 0x6BC9840
    public void GetBoundaryConfigured(){} // RVA: 0x6BC99C0
    public void TestBoundaryNode(){} // RVA: 0x6BC9B50
    public void TestBoundaryPoint(){} // RVA: 0x6BC9D20
    public void GetBoundaryGeometry(){} // RVA: 0x6BC9F10
    public void GetBoundaryGeometry2(){} // RVA: 0x6BCA220
    public void GetAppPerfStats(){} // RVA: 0x6BCA3E0
    public void ResetAppPerfStats(){} // RVA: 0x6BCA8C0
    public void GetAppFramerate(){} // RVA: 0x6BCAB20
    public void SetHandNodePoseStateLatency(){} // RVA: 0x6BCACA0
    public void GetHandNodePoseStateLatency(){} // RVA: 0x6BCAE40
    public void GetDesiredEyeTextureFormat(){} // RVA: 0x6BCB000
    public void SetDesiredEyeTextureFormat(){} // RVA: 0x6BCB190
    public void InitializeMixedReality(){} // RVA: 0x6BCB330
    public void ShutdownMixedReality(){} // RVA: 0x6BCB4C0
    public void IsMixedRealityInitialized(){} // RVA: 0x6BCB650
    public void GetExternalCameraCount(){} // RVA: 0x6BCB7E0
    public void UpdateExternalCamera(){} // RVA: 0x6BCB990
    public void GetMixedRealityCameraInfo(){} // RVA: 0x6BCBB20
    public void OverrideExternalCameraFov(){} // RVA: 0x6BCBD90
    public void GetUseOverriddenExternalCameraFov(){} // RVA: 0x6BCBF50
    public void OverrideExternalCameraStaticPose(){} // RVA: 0x6BCC120
    public void GetUseOverriddenExternalCameraStaticPose(){} // RVA: 0x6BCC2E0
    public void ResetDefaultExternalCamera(){} // RVA: 0x6BCC4B0
    public void SetDefaultExternalCamera(){} // RVA: 0x6BCC640
    public void SetExternalCameraProperties(){} // RVA: 0x6BCC820
    public void IsInsightPassthroughSupported(){} // RVA: 0x6BCCA00
    public void InitializeInsightPassthrough(){} // RVA: 0x6BCCC40
    public void ShutdownInsightPassthrough(){} // RVA: 0x6BCCDD0
    public void IsInsightPassthroughInitialized(){} // RVA: 0x6BCCF60
    public void GetInsightPassthroughInitializationState(){} // RVA: 0x6BCD0F0
    public void CreateInsightTriangleMesh(){} // RVA: 0x6BCD280
    public void DestroyInsightTriangleMesh(){} // RVA: 0x6BCD510
    public void AddInsightPassthroughSurfaceGeometry(){} // RVA: 0x6BCD6B0
    public void DestroyInsightPassthroughGeometryInstance(){} // RVA: 0x6BCD8B0
    public void UpdateInsightPassthroughGeometryTransform(){} // RVA: 0x6BCDA50
    public void SetInsightPassthroughStyle(){} // RVA: 0x6BCDC30
    public void SetInsightPassthroughKeyboardHandsIntensity(){} // RVA: 0x6BCDE00
    public void GetPassthroughCapabilityFlags(){} // RVA: 0x6BCDFC0
    public void GetBoundaryDimensions(){} // RVA: 0x6BCE250
    public void GetBoundaryVisible(){} // RVA: 0x6BCE420
    public void SetBoundaryVisible(){} // RVA: 0x6BCE5B0
    public void GetSystemHeadsetType(){} // RVA: 0x6BCE770
    public void GetActiveController(){} // RVA: 0x6BCE8F0
    public void GetConnectedControllers(){} // RVA: 0x6BCEA70
    public void ToBool(){} // RVA: 0x67F8240
    public void GetTrackingOriginType(){} // RVA: 0x6BCEBF0
    public void SetTrackingOriginType(){} // RVA: 0x6BCEC90
    public void GetTrackingCalibratedOrigin(){} // RVA: 0x6BCED50
    public void SetTrackingCalibratedOrigin(){} // RVA: 0x6BCEE20
    public void RecenterTrackingOrigin(){} // RVA: 0x6BCEED0
    public void UpdateCameraDevices(){} // RVA: 0x6BCEF90
    public void IsCameraDeviceAvailable(){} // RVA: 0x6BCF120
    public void SetCameraDevicePreferredColorFrameSize(){} // RVA: 0x6BCF2C0
    public void OpenCameraDevice(){} // RVA: 0x6BCF480
    public void CloseCameraDevice(){} // RVA: 0x6BCF620
    public void HasCameraDeviceOpened(){} // RVA: 0x6BCF7C0
    public void IsCameraDeviceColorFrameAvailable(){} // RVA: 0x6BCF960
    public void GetCameraDeviceColorFrameTexture(){} // RVA: 0x6BCFB00
    public void DoesCameraDeviceSupportDepth(){} // RVA: 0x6BCFF70
    public void SetCameraDeviceDepthSensingMode(){} // RVA: 0x6BD0130
    public void SetCameraDevicePreferredDepthQuality(){} // RVA: 0x6BD02E0
    public void IsCameraDeviceDepthFrameAvailable(){} // RVA: 0x6BD0490
    public void GetCameraDeviceDepthFrameTexture(){} // RVA: 0x6BD0650
    public void GetCameraDeviceDepthConfidenceTexture(){} // RVA: 0x6BD0AF0
    public void get_foveatedRenderingSupported(){} // RVA: 0x6BD0F80
    public void get_eyeTrackedFoveatedRenderingSupported(){} // RVA: 0x6BD0FF0
    public void get_eyeTrackedFoveatedRenderingEnabled(){} // RVA: 0x6BD1190
    public void set_eyeTrackedFoveatedRenderingEnabled(){} // RVA: 0x6BD1350
    public void get_fixedFoveatedRenderingSupported(){} // RVA: 0x6BD1510
    public void get_foveatedRenderingLevel(){} // RVA: 0x6BD16C0
    public void set_foveatedRenderingLevel(){} // RVA: 0x6BD1880
    public void get_fixedFoveatedRenderingLevel(){} // RVA: 0x6BD1A40
    public void set_fixedFoveatedRenderingLevel(){} // RVA: 0x6BD1A90
    public void get_useDynamicFixedFoveatedRendering(){} // RVA: 0x6BD1AE0
    public void set_useDynamicFixedFoveatedRendering(){} // RVA: 0x6BD1CB0
    public void get_tiledMultiResSupported(){} // RVA: 0x6BD1E70
    public void get_tiledMultiResLevel(){} // RVA: 0x6BD1EC0
    public void set_tiledMultiResLevel(){} // RVA: 0x6BD1F10
    public void get_gpuUtilSupported(){} // RVA: 0x6BD1F60
    public void get_gpuUtilLevel(){} // RVA: 0x6BD2110
    public void get_systemDisplayFrequenciesAvailable(){} // RVA: 0x6BD22E0
    public void get_systemDisplayFrequency(){} // RVA: 0x6BD2750
    public void set_systemDisplayFrequency(){} // RVA: 0x6BD2A50
    public void get_eyeFovPremultipliedAlphaModeEnabled(){} // RVA: 0x6BD2BF0
    public void set_eyeFovPremultipliedAlphaModeEnabled(){} // RVA: 0x6BD2D90
    public void GetNodeFrustum2(){} // RVA: 0x6BD2F40
    public void get_AsymmetricFovEnabled(){} // RVA: 0x6BD3100
    public void get_EyeTextureArrayEnabled(){} // RVA: 0x6BD32B0
    public void get_localDimmingSupported(){} // RVA: 0x6BD3440
    public void get_localDimming(){} // RVA: 0x6BD35F0
    public void set_localDimming(){} // RVA: 0x6BD37D0
    public void GetDominantHand(){} // RVA: 0x6BD3990
    public void SendEvent(){} // RVA: 0x6BD3B40
    public void SetHeadPoseModifier(){} // RVA: 0x6BD3F20
    public void GetHeadPoseModifier(){} // RVA: 0x6BD40E0
    public void IsPerfMetricsSupported(){} // RVA: 0x6BD4320
    public void GetPerfMetricsFloat(){} // RVA: 0x6BD44E0
    public void GetPerfMetricsInt(){} // RVA: 0x6BD46C0
    public void GetTimeInSeconds(){} // RVA: 0x6BD48B0
    public void SetColorScaleAndOffset(){} // RVA: 0xB43320
    public void AddCustomMetadata(){} // RVA: 0x6BD4A70
    public void SetDeveloperMode(){} // RVA: 0x6BD4C60
    public void GetAdaptiveGPUPerformanceScale(){} // RVA: 0x6BD4E00
    public void GetHandTrackingEnabled(){} // RVA: 0x6BD4FC0
    public void GetHandState(){} // RVA: 0x6BD5170
    public void GetSkeleton(){} // RVA: 0x6BD5D00
    public void GetSkeleton2(){} // RVA: 0x6BD5F50
    public void get_bodyTrackingSupported(){} // RVA: 0x6BD7F20
    public void get_bodyTrackingEnabled(){} // RVA: 0x6BD80D0
    public void GetBodyState(){} // RVA: 0x6BD8280
    public void GetMesh(){} // RVA: 0x6BD9740
    public void StartKeyboardTracking(){} // RVA: 0x6BD9B30
    public void StopKeyboardTracking(){} // RVA: 0x6BD9CD0
    public void GetKeyboardState(){} // RVA: 0x6BD9E60
    public void GetSystemKeyboardDescription(){} // RVA: 0x6BDA040
    public void get_faceTrackingEnabled(){} // RVA: 0x6BDA1A0
    public void get_faceTrackingSupported(){} // RVA: 0x6BDA350
    public void GetFaceState(){} // RVA: 0x6BDA500
    public void get_eyeTrackingEnabled(){} // RVA: 0x6BDB5B0
    public void get_eyeTrackingSupported(){} // RVA: 0x6BDB760
    public void GetEyeGazesState(){} // RVA: 0x6BDB910
    public void StartEyeTracking(){} // RVA: 0x6BDBCB0
    public void StopEyeTracking(){} // RVA: 0x6BDBE40
    public void StartFaceTracking(){} // RVA: 0x6BDBFD0
    public void StopFaceTracking(){} // RVA: 0x6BDC160
    public void StartBodyTracking(){} // RVA: 0x6BDC2F0
    public void StopBodyTracking(){} // RVA: 0x6BDC480
    public void GetLocalTrackingSpaceRecenterCount(){} // RVA: 0x6BDC610
    public void GetSystemHmd3DofModeEnabled(){} // RVA: 0x6BDC7C0
    public void SetClientColorDesc(){} // RVA: 0x6BDC970
    public void GetHmdColorDesc(){} // RVA: 0x6BDCB60
    public void PollEvent(){} // RVA: 0x6BDCD80
    public void GetNativeOpenXRInstance(){} // RVA: 0x6BDD130
    public void GetNativeOpenXRSession(){} // RVA: 0x6BDD2E0
    public void SetKeyboardOverlayUV(){} // RVA: 0x6BDD490
    public void CreateSpatialAnchor(){} // RVA: 0x6BDD640
    public void SetSpaceComponentStatus(){} // RVA: 0x6BDD800
    public void GetSpaceComponentStatus(){} // RVA: 0x6BDDA00
    public void EnumerateSpaceSupportedComponents(){} // RVA: 0x6BDDBF0
    public void SaveSpace(){} // RVA: 0x6BDDDD0
    public void EraseSpace(){} // RVA: 0x6BDDFA0
    public void GetSpaceUuid(){} // RVA: 0x6BDE170
    public void QuerySpaces(){} // RVA: 0x6BDE320
    public void RetrieveSpaceQueryResults(){} // RVA: 0x6BDE5D0
    public void TryLocateSpace(){} // RVA: 0x6BDEAE0
    public void LocateSpace(){} // RVA: 0x6BDECF0
    public void DestroySpace(){} // RVA: 0x6BDEDE0
    public void GetSpaceContainer(){} // RVA: 0x6BDEF80
    public void GetSpaceBoundingBox2D(){} // RVA: 0x6BDF3C0
    public void GetSpaceBoundingBox3D(){} // RVA: 0x6BDF570
    public void GetSpaceSemanticLabels(){} // RVA: 0x6BDF730
    public void GetSpaceRoomLayout(){} // RVA: 0x6BDFAF0
    public void GetSpaceBoundary2D(){} // RVA: 0x6BE0250
    public void RequestSceneCapture(){} // RVA: 0x6BE0800
    public void GetRenderModelPaths(){} // RVA: 0x6BE0BB0
    public void GetRenderModelProperties(){} // RVA: 0x6BE0F10
    public void LoadRenderModel(){} // RVA: 0x6BE1460
    public void FeatureFidelitySetFeatureEnable(){} // RVA: 0x6BE1740
    public void FeatureFidelitySetFeatureFidelity(){} // RVA: 0x6BE18F0
    public void FeatureFidelityGetFeatureState(){} // RVA: 0x6BE1AA0
    public void .cctor(){} // RVA: 0x6BE1CB0
}

public class OVRProfile : Object
{
    // ── Methods ──
    public void get_id(){} // RVA: 0x6BF9430
    public void get_userName(){} // RVA: 0x6BF9470
    public void get_locale(){} // RVA: 0x6BF94B0
    public void get_ipd(){} // RVA: 0x6BF94F0
    public void get_eyeHeight(){} // RVA: 0x6BF9670
    public void get_eyeDepth(){} // RVA: 0x6BF9750
    public void get_neckHeight(){} // RVA: 0x6BF9860
    public void get_state(){} // RVA: 0xC50A80
    public void .ctor(){} // RVA: 0x6BF9880
}

public class OVRScenePlane[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
}

public class OVRScenePrefabOverride : Object
{
    public object Prefab;
    public object ClassificationLabel;
    public object _editorClassificationIndex;

    // ── Methods ──
    public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0xB43310
    public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x6C021A0
    public void .ctor(){} // RVA: 0x6C02320
    public void <UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize>g__IndexOf|4_0(){} // RVA: 0x6C023B0
}

public class OVRScenePrefabOverride[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
}

public class OVRSystemPerfMetrics : Object
{
    public object TcpListeningPort;
    public object PayloadTypeMetrics;
    public object MaxBufferLength;
    public object MaxMessageLength;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
}

public class OVRSystemPerfMetricsTcpServer : MonoBehaviour
{
    public object singleton;
    public object tcpServer;
    public object listeningPort;

    // ── Methods ──
    public void OnEnable(){} // RVA: 0x6C3BEC0
    public void OnDisable(){} // RVA: 0x6C3C0A0
    public void Update(){} // RVA: 0x6C3C190
    public void GatherPerfMetrics(){} // RVA: 0x6C3C220
    public void .ctor(){} // RVA: 0x6C3C720
}

public class OVRTracker : Object
{
    // ── Methods ──
    public void get_isPresent(){} // RVA: 0x6C08310
    public void get_isPositionTracked(){} // RVA: 0x6C08460
    public void get_isEnabled(){} // RVA: 0x6C08520
    public void set_isEnabled(){} // RVA: 0x6C08670
    public void get_count(){} // RVA: 0x6C087E0
    public void GetFrustum(){} // RVA: 0x6C08960
    public void GetPose(){} // RVA: 0x6C08AF0
    public void GetPoseValid(){} // RVA: 0x6C08F80
    public void GetPresent(){} // RVA: 0x6C090A0
    public void .ctor(){} // RVA: 0xB43310
}

public class ObjectEnumerator : ValueType
{
    public object _target;
    public object _curIdx;
    public object _endIdxOrVersion;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x8EE3D0
    public void get_Current(){} // RVA: 0x8EE750
    public void GetEnumerator(){} // RVA: 0x8EE490
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x8EE780
    public void System.Collections.Generic.IEnumerable<System.Text.Json.JsonProperty>.GetEnumerator(){} // RVA: 0x8EE7F0
    public void Dispose(){} // RVA: 0x8EE5B0
    public void Reset(){} // RVA: 0x267910
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x8EE860
    public void MoveNext(){} // RVA: 0x8EE8D0
}

public class ObjectEnumerator : ValueType
{
    public object _target;
    public object _curIdx;
    public object _endIdxOrVersion;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x90E1B0
    public void get_Current(){} // RVA: 0x8EE750
    public void GetEnumerator(){} // RVA: 0x8EE490
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x90E440
    public void System.Collections.Generic.IEnumerable<System.Text.Json.JsonProperty>.GetEnumerator(){} // RVA: 0x90E4B0
    public void Dispose(){} // RVA: 0x8EE5B0
    public void Reset(){} // RVA: 0x267910
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x90E520
    public void MoveNext(){} // RVA: 0x90E590
}

public class ObjectSurrogate : Object
{
    // ── Methods ──
    public void GetObjectData(){} // RVA: 0xA74E670
    public void SetObjectData(){} // RVA: 0xA74EF50
    public void .ctor(){} // RVA: 0xB43310
}

public class ObservableList`1 : Object
{
    public object m_Items;
    public object listChanged;

    // ── Methods ──
    public void get_Count(){} // RVA: 0x87C130
    public void get_Item(){} // RVA: 0xA94080
    public void GetEnumerator(){} // RVA: 0x87C0A0
    public void add_listChanged(){} // RVA: 0x894320
    public void remove_listChanged(){} // RVA: 0x894320
}

public class Offset : Object
{
    public object name;
    public object collider;
    public object crossFadeTime;
    public object _crossFader;
    public object _timer;
    public object _force;
    public object _point;
    public object length;
    public object crossFadeSpeed;
    public object lastTime;

    // ── Methods ──
    public void get_crossFader(){} // RVA: 0xCBAD90
    public void set_crossFader(){} // RVA: 0xCBADA0
    public void get_timer(){} // RVA: 0xC27360
    public void set_timer(){} // RVA: 0xC27370
    public void get_force(){} // RVA: 0xBA9C30
    public void set_force(){} // RVA: 0xBA9C50
    public void get_point(){} // RVA: 0xBA9C60
    public void set_point(){} // RVA: 0xBA9C80
    public void Hit(){} // RVA: 0xCBC740
    public void Apply(){} // RVA: 0xCBC870
    public void GetLength(){} // RVA: 0x891020
    public void CrossFadeStart(){} // RVA: 0x894290
    public void OnApply(){} // RVA: 0x895520
    public void .ctor(){} // RVA: 0xCBB030
}

public class OffsetLimits : Object
{
    public object effector;
    public object spring;
    public object x;
    public object y;
    public object z;
    public object minX;
    public object maxX;
    public object minY;
    public object maxY;
    public object minZ;
    public object maxZ;

    // ── Methods ──
    public void Apply(){} // RVA: 0xCC06E0
    public void SpringAxis(){} // RVA: 0xCC0B60
    public void Spring(){} // RVA: 0xCC0BF0
    public void .ctor(){} // RVA: 0xB43310
}

public class OffsetLimits[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
}

public class Oid : AttributeTypeAndValue
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x664A250
}

public class OnAttachedToHandDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xBC4530
    public void Invoke(){} // RVA: 0xB9E010
    public void BeginInvoke(){} // RVA: 0xB9E020
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class OnConnectionLost : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB9DF20
    public void Invoke(){} // RVA: 0xB9E010
    public void BeginInvoke(){} // RVA: 0xB9E020
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class OnCultureInfoChangedDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB9DF20
    public void Invoke(){} // RVA: 0xB9E010
}

public class OnDefaultAttributeUseDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x23E7D60
    public void Invoke(){} // RVA: 0xCA8BF0
}

public class OnDetachedFromHandDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xBC4530
    public void Invoke(){} // RVA: 0xB9E010
    public void BeginInvoke(){} // RVA: 0xB9E020
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class OnNavMeshPreUpdate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xBA0FE0
    public void Invoke(){} // RVA: 0xBA10B0
}

public class OnReady : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xBC4530
    public void Invoke(){} // RVA: 0xB9E010
    public void BeginInvoke(){} // RVA: 0xB9E020
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class OnlyValueChangedProgress`1 : Object
{
    public object action;
    public object comparer;
    public object isFirstCall;
    public object latestValue;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x8943B0
    public void Report(){} // RVA: 0xA94080
}

public class OptionPropertyDescriptor : PropertyDescriptor
{
    public object _option;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7712380
    public void get_ComponentType(){} // RVA: 0x7712410
    public void get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void get_PropertyType(){} // RVA: 0x7712410
    public void CanResetValue(){} // RVA: 0xB43320
    public void GetValue(){} // RVA: 0xB813B0
    public void ResetValue(){} // RVA: 0xB43310
    public void SetValue(){} // RVA: 0xB43310
    public void ShouldSerializeValue(){} // RVA: 0xB43320
}

public class Options : ValueType
{
    public object MaxUuidCount;
    public object Ids;
    public object ComponentTypes;
    public object _maxResults;
    public object _timeout;
    public object _location;
    public object _queryType;
    public object _actionType;
    public object _componentFilter;
    public object _uuidFilter;

    // ── Methods ──
    public void get_MaxResults(){} // RVA: 0x77E60
    public void set_MaxResults(){} // RVA: 0x29580
    public void get_Timeout(){} // RVA: 0x85010
    public void set_Timeout(){} // RVA: 0xDA1A0
    public void get_Location(){} // RVA: 0x8C7E0
    public void set_Location(){} // RVA: 0x8C7F0
    public void get_QueryType(){} // RVA: 0xAFF50
    public void set_QueryType(){} // RVA: 0xAFF60
    public void get_ActionType(){} // RVA: 0x8E1F0
    public void set_ActionType(){} // RVA: 0x9E810
    public void get_ComponentFilter(){} // RVA: 0x9F5A0
    public void set_ComponentFilter(){} // RVA: 0x8CF930
    public void get_UuidFilter(){} // RVA: 0x8C630
    public void set_UuidFilter(){} // RVA: 0x8CF940
    public void .ctor(){} // RVA: 0x8CF950
    public void TryQuerySpaces(){} // RVA: 0x8CFA60
    public void .cctor(){} // RVA: 0x6C03DB0
}

public class Options : ValueType
{
    public object weight;
    public object spine;
    public object chest;
    public object hands;
    public object feet;
    public object joints;
    public object jointRange;
    public object colliderLengthOverlap;
    public object torsoColliders;
    public object headCollider;
    public object armColliders;
    public object handColliders;
    public object legColliders;
    public object footColliders;

    // ── Methods ──
    public void get_Default(){} // RVA: 0xBF01F0
}

public class Options : ValueType
{
    public object applyFastStart;
    public object applyStereoMode;
    public object stereoMode;
    public object applySphericalVideoLayout;
    public object sphericalVideoLayout;
    public object applyMoveCaptureFile;
    public object finalCaptureFilePath;

    // ── Methods ──
    public void HasOptions(){} // RVA: 0x8E5CE0
    public void RequiresProcessing(){} // RVA: 0x8E5D00
    public void ResetOptions(){} // RVA: 0x8E5D20
}

public class Orbit[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EAC7E0
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7C490
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC7BD0
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E57A40
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7C490
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
}

public class OrderedDictionaryEnumerator : Object
{
    public object _objectReturnType;
    public object _arrayEnumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7717450
    public void get_Current(){} // RVA: 0x77174F0
    public void get_Entry(){} // RVA: 0x77177A0
    public void get_Key(){} // RVA: 0x77178B0
    public void get_Value(){} // RVA: 0x7717940
    public void MoveNext(){} // RVA: 0x77179D0
    public void Reset(){} // RVA: 0x7717A20
}

public class OrderedDictionaryKeyValueCollection : Object
{
    public object _objects;
    public object _isKeys;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x237A5A0
    public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7717A70
    public void System.Collections.ICollection.get_Count(){} // RVA: 0x6875CA0
    public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
    public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x6875F20
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7717DB0
}

public class OrganizationName : AttributeTypeAndValue
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x6649F30
}

public class OrganizationalUnitName : AttributeTypeAndValue
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x6649FD0
}

public class OriginalEnumValueHelper : Object
{
    public object dictionaries;

    // ── Methods ──
    public void GetOriginalName(){} // RVA: 0x64A6200
    public void GetNameMapping(){} // RVA: 0x64A64C0
    public void .cctor(){} // RVA: 0x64A69F0
}

public class OutOfSpaceException : IOException
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x649B1F0
}

public class OverlappedData : Object
{
    public object _pinnedData;
    public object _callback;
    public object _state;
    public object _executionContext;
    public object _boundHandle;
    public object _preAllocated;
    public object _completed;

    // ── Methods ──
    public void Reset(){} // RVA: 0x69A2540
    public void .ctor(){} // RVA: 0xB43310
}

public class OverlaySettings : Object
{
    public object linearDepth;
    public object motionColorIntensity;
    public object motionGridSize;
    public object colorBlindnessType;
    public object colorBlindnessStrength;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7980A80
}

public class ovrKeyValuePair : ValueType
{
    public object key_;
    public object valueType_;
    public object stringValue_;
    public object intValue_;
    public object doubleValue_;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x8C8BB0
}

public class ovrMatchmakingCriterion : ValueType
{
    public object key_;
    public object importance_;
    public object parameterArray;
    public object parameterArrayCount;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x8C8CD0
}
