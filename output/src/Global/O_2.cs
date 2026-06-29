// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 100
// Methods: 767

public class OVRBone : Object
{
    public object _id;
    public object _parentBoneIndex;
    public object _transform;

    // ── Methods ──
    public void get_Id(){} // RVA: 0xB8F8F0
    public void set_Id(){} // RVA: 0xB460A0
    public void get_ParentBoneIndex(){} // RVA: 0x3927910
    public void set_ParentBoneIndex(){} // RVA: 0x6C368F0
    public void get_Transform(){} // RVA: 0xB465B0
    public void set_Transform(){} // RVA: 0xBA9BA0
    public void .ctor(){} // RVA: 0x6C36900
}

public class OVRBone[] : Array
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

public class OVRBoundary : Object
{
    public object cachedVector3fSize;
    public object cachedGeometryNativeBuffer;
    public object cachedGeometryManagedBuffer;
    public object cachedGeometryList;

    // ── Methods ──
    public void GetConfigured(){} // RVA: 0x6B73510
    public void TestNode(){} // RVA: 0x6B73720
    public void TestPoint(){} // RVA: 0x6B73990
    public void GetGeometry(){} // RVA: 0x6B73AE0
    public void GetDimensions(){} // RVA: 0x6B73F30
    public void GetVisible(){} // RVA: 0x6B741E0
    public void SetVisible(){} // RVA: 0x6B743F0
    public void .ctor(){} // RVA: 0x6B74620
    public void .cctor(){} // RVA: 0x6B746E0
}

public class OVRCameraComposition : OVRComposition
{
    public object cameraFramePlaneObject;
    public object cameraFramePlaneDistance;
    public object hasCameraDeviceOpened;
    public object cameraDevice;
    public object boundaryMesh;
    public object boundaryMeshTopY;
    public object boundaryMeshBottomY;
    public object boundaryMeshType;
    public object cameraFrameCompositionManager;
    public object nullcameraRigWarningDisplayed;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x6B68880
    public void Cleanup(){} // RVA: 0x6B695B0
    public void RecenterPose(){} // RVA: 0x64D9FC0
    public void RefreshCameraFramePlaneObject(){} // RVA: 0x6B69880
    public void UpdateCameraFramePlaneObject(){} // RVA: 0x6B69E90
    public void RefreshBoundaryMesh(){} // RVA: 0x6B6B1A0
}

public class OVRCameraFrameCompositionManager : MonoBehaviour
{
    public object configuration;
    public object cameraFrameGameObj;
    public object composition;
    public object boundaryMeshMaskTexture;
    public object cameraFrameMaterial;
    public object whiteMaterial;
    public object mixedRealityCamera;

    // ── Methods ──
    public void Start(){} // RVA: 0x6B6B440
    public void OnPreRender(){} // RVA: 0x6B6BAA0
    public void OnPostRender(){} // RVA: 0x6B6C1A0
    public void OnCameraBeginRendering(){} // RVA: 0x6B6C2B0
    public void OnCameraEndRendering(){} // RVA: 0x6B6C470
    public void .ctor(){} // RVA: 0xB43D60
}

public class OVRComposition : Object
{
    public object cameraInTrackingSpace;
    public object cameraRig;
    public object usingLastAttachedNodePose;
    public object lastAttachedNodePose;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x6B6C720
    public void CompositionMethod(){} // RVA: 0x87C130
    public void Update(){} // RVA: 0x899AC0
    public void Cleanup(){} // RVA: 0x894290
    public void RecenterPose(){} // RVA: 0xB43310
    public void RefreshCameraRig(){} // RVA: 0x6B6C730
    public void ComputeCameraWorldSpacePose(){} // RVA: 0x6B6CAD0
    public void ComputeCameraTrackingSpacePose(){} // RVA: 0x6B6CC10
}

public class OVRCompositionUtil : Object
{
    // ── Methods ──
    public void SafeDestroy(){} // RVA: 0x6B6D1E0
    public void ConvertCameraDevice(){} // RVA: 0x6B6D440
    public void ToBoundaryType(){} // RVA: 0x6B6D470
    public void GetWorldPosition(){} // RVA: 0x6B6D540
    public void GetMaximumBoundaryDistance(){} // RVA: 0x6B6D690
    public void BuildBoundaryMesh(){} // RVA: 0x6B6DA30
    public void .ctor(){} // RVA: 0xB43310
}

public class OVRControllerBase : Object
{
    public object controllerType;
    public object buttonMap;
    public object touchMap;
    public object nearTouchMap;
    public object axis1DMap;
    public object axis2DMap;
    public object previousState;
    public object currentState;
    public object shouldApplyDeadzone;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x6B9A4A0
    public void Update(){} // RVA: 0x6B9A780
    public void GetOpenVRControllerState(){} // RVA: 0x6B9ABE0
    public void SetControllerVibration(){} // RVA: 0x6B9B190
    public void SetControllerLocalizedVibration(){} // RVA: 0x6B9B2A0
    public void GetBatteryPercentRemaining(){} // RVA: 0xB43320
    public void ConfigureButtonMap(){} // RVA: 0x894290
    public void ConfigureTouchMap(){} // RVA: 0x894290
    public void ConfigureNearTouchMap(){} // RVA: 0x894290
    public void ConfigureAxis1DMap(){} // RVA: 0x894290
    public void ConfigureAxis2DMap(){} // RVA: 0x894290
    public void ResolveToRawMask(){} // RVA: 0x6B9B640
}

public class OVRControllerGamepadAndroid : OVRControllerBase
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x6B9D3B0
    public void ConfigureButtonMap(){} // RVA: 0x6B9D3D0
    public void ConfigureTouchMap(){} // RVA: 0x6B9CAA0
    public void ConfigureNearTouchMap(){} // RVA: 0x6B9CB60
    public void ConfigureAxis1DMap(){} // RVA: 0x6B9D660
    public void ConfigureAxis2DMap(){} // RVA: 0x6B9D730
}

public class OVRControllerGamepadPC : OVRControllerBase
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x6B9D3B0
    public void ConfigureButtonMap(){} // RVA: 0x6B9D3D0
    public void ConfigureTouchMap(){} // RVA: 0x6B9CAA0
    public void ConfigureNearTouchMap(){} // RVA: 0x6B9CB60
    public void ConfigureAxis1DMap(){} // RVA: 0x6B9D660
    public void ConfigureAxis2DMap(){} // RVA: 0x6B9D730
}

public class OVRControllerHands : OVRControllerBase
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x6B9C860
    public void ConfigureButtonMap(){} // RVA: 0x6B9C880
    public void ConfigureTouchMap(){} // RVA: 0x6B9CAA0
    public void ConfigureNearTouchMap(){} // RVA: 0x6B9CB60
    public void ConfigureAxis1DMap(){} // RVA: 0x6B9CBB0
    public void ConfigureAxis2DMap(){} // RVA: 0x6B9CC70
    public void GetBatteryPercentRemaining(){} // RVA: 0x6B9BE40
}

public class OVRControllerLHand : OVRControllerBase
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x6B9CCC0
    public void ConfigureButtonMap(){} // RVA: 0x6B9CCE0
    public void ConfigureTouchMap(){} // RVA: 0x6B9CAA0
    public void ConfigureNearTouchMap(){} // RVA: 0x6B9CB60
    public void ConfigureAxis1DMap(){} // RVA: 0x6B9CBB0
    public void ConfigureAxis2DMap(){} // RVA: 0x6B9CC70
    public void GetBatteryPercentRemaining(){} // RVA: 0x6B9C350
}

public class OVRControllerLTouch : OVRControllerBase
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x6B9BE60
    public void ConfigureButtonMap(){} // RVA: 0x6B9BE80
    public void ConfigureTouchMap(){} // RVA: 0x6B9C0D0
    public void ConfigureNearTouchMap(){} // RVA: 0x6B9C1B0
    public void ConfigureAxis1DMap(){} // RVA: 0x6B9C210
    public void ConfigureAxis2DMap(){} // RVA: 0x6B9C2F0
    public void GetBatteryPercentRemaining(){} // RVA: 0x6B9C350
}

public class OVRControllerRHand : OVRControllerBase
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x6B9CF00
    public void ConfigureButtonMap(){} // RVA: 0x6B9CF20
    public void ConfigureTouchMap(){} // RVA: 0x6B9CAA0
    public void ConfigureNearTouchMap(){} // RVA: 0x6B9CB60
    public void ConfigureAxis1DMap(){} // RVA: 0x6B9CBB0
    public void ConfigureAxis2DMap(){} // RVA: 0x6B9CC70
    public void GetBatteryPercentRemaining(){} // RVA: 0x6B9C850
}

public class OVRControllerRTouch : OVRControllerBase
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x6B9C360
    public void ConfigureButtonMap(){} // RVA: 0x6B9C380
    public void ConfigureTouchMap(){} // RVA: 0x6B9C5D0
    public void ConfigureNearTouchMap(){} // RVA: 0x6B9C6B0
    public void ConfigureAxis1DMap(){} // RVA: 0x6B9C710
    public void ConfigureAxis2DMap(){} // RVA: 0x6B9C7F0
    public void GetBatteryPercentRemaining(){} // RVA: 0x6B9C850
}

public class OVRControllerRemote : OVRControllerBase
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x6B9D140
    public void ConfigureButtonMap(){} // RVA: 0x6B9D160
    public void ConfigureTouchMap(){} // RVA: 0x6B9CAA0
    public void ConfigureNearTouchMap(){} // RVA: 0x6B9CB60
    public void ConfigureAxis1DMap(){} // RVA: 0x6B9CBB0
    public void ConfigureAxis2DMap(){} // RVA: 0x6B9CC70
}

public class OVRControllerTouch : OVRControllerBase
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x6B9B900
    public void ConfigureButtonMap(){} // RVA: 0x6B9B920
    public void ConfigureTouchMap(){} // RVA: 0x6B9BB90
    public void ConfigureNearTouchMap(){} // RVA: 0x6B9BC80
    public void ConfigureAxis1DMap(){} // RVA: 0x6B9BCE0
    public void ConfigureAxis2DMap(){} // RVA: 0x6B9BDE0
    public void GetBatteryPercentRemaining(){} // RVA: 0x6B9BE40
}

public class OVRDirectComposition : OVRCameraComposition
{
    public object previousMainCameraObject;
    public object directCompositionCameraGameObject;
    public object directCompositionCamera;
    public object boundaryMeshMaskTexture;

    // ── Methods ──
    public void CompositionMethod(){} // RVA: 0xC3CCE0
    public void .ctor(){} // RVA: 0x6B6E060
    public void RefreshCameraObjects(){} // RVA: 0x6B6E0C0
    public void Update(){} // RVA: 0x6B6EAB0
    public void Cleanup(){} // RVA: 0x6B6F5B0
}

public class OVRDisplay : Object
{
    public object needsConfigureTexture;
    public object eyeDescs;
    public object recenterRequested;
    public object recenterRequestedFrameCount;
    public object localTrackingSpaceRecenterCount;
    public object RecenteredPose;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x6B7E110
    public void Update(){} // RVA: 0x6B7E1C0
    public void add_RecenteredPose(){} // RVA: 0x6B7E520
    public void remove_RecenteredPose(){} // RVA: 0x6B7E610
    public void RecenterPose(){} // RVA: 0x6B7E700
    public void get_acceleration(){} // RVA: 0x6B7E830
    public void get_angularAcceleration(){} // RVA: 0x6B7E980
    public void get_velocity(){} // RVA: 0x6B7EAD0
    public void get_angularVelocity(){} // RVA: 0x6B7EC20
    public void GetEyeRenderDesc(){} // RVA: 0x6B7ED70
    public void get_latency(){} // RVA: 0x6B7EDC0
    public void get_appFramerate(){} // RVA: 0x6B7F240
    public void get_recommendedMSAALevel(){} // RVA: 0x6B7F2C0
    public void get_displayFrequenciesAvailable(){} // RVA: 0x6B7F4E0
    public void get_displayFrequency(){} // RVA: 0x6B7F530
    public void set_displayFrequency(){} // RVA: 0x6B7F580
    public void UpdateTextures(){} // RVA: 0x6B7F750
    public void ConfigureEyeDesc(){} // RVA: 0x6B7F780
}

public class OVRExtensions : Object
{
    // ── Methods ──
    public void ToTrackingSpacePose(){} // RVA: 0x6B794B0
    public void ToWorldSpacePose(){} // RVA: 0x6B79EE0
    public void ToHeadSpacePose(){} // RVA: 0x6B7A200
    public void ToOVRPose(){} // RVA: 0x6B7A860
    public void FromOVRPose(){} // RVA: 0x6B7A5C0
    public void ToFrustum(){} // RVA: 0x6B7A8D0
    public void FromColorf(){} // RVA: 0x2315EC0
    public void ToColorf(){} // RVA: 0x2315EC0
    public void FromVector3f(){} // RVA: 0x2331CF0
    public void FromFlippedXVector3f(){} // RVA: 0x6B7A910
    public void FromFlippedZVector3f(){} // RVA: 0x1924B40
    public void ToVector3f(){} // RVA: 0x2331CF0
    public void ToFlippedXVector3f(){} // RVA: 0x6B7A910
    public void ToFlippedZVector3f(){} // RVA: 0x1924B40
    public void FromVector4f(){} // RVA: 0x2315EC0
    public void ToVector4f(){} // RVA: 0x2315EC0
    public void FromQuatf(){} // RVA: 0x2315EC0
    public void FromFlippedXQuatf(){} // RVA: 0x6B7A930
    public void FromFlippedZQuatf(){} // RVA: 0x6B7A960
    public void ToQuatf(){} // RVA: 0x2315EC0
    public void ToFlippedXQuatf(){} // RVA: 0x6B7A930
    public void ToFlippedZQuatf(){} // RVA: 0x6B7A960
    public void ConvertToHMDMatrix34(){} // RVA: 0x6B7A990
    public void FindChildRecursive(){} // RVA: 0x6B7AA10
    public void Equals(){} // RVA: 0x6B7AC00
    public void CopyFrom(){} // RVA: 0x6B7AE50
    public void ToSpaceStorageLocation(){} // RVA: 0x6B7B080
}

public class OVRExternalComposition : OVRComposition
{
    public object previousMainCameraObject;
    public object foregroundCameraGameObject;
    public object foregroundCamera;
    public object backgroundCameraGameObject;
    public object backgroundCamera;
    public object audioDataLock;
    public object cachedAudioData;
    public object cachedChannels;

    // ── Methods ──
    public void CompositionMethod(){} // RVA: 0xDAC980
    public void .ctor(){} // RVA: 0x6B6F690
    public void RefreshCameraObjects(){} // RVA: 0x6B6F880
    public void Update(){} // RVA: 0x6B70CA0
    public void Cleanup(){} // RVA: 0x6B724F0
    public void CacheAudioData(){} // RVA: 0x6B72630
    public void GetAndResetAudioData(){} // RVA: 0x6B727E0
}

public class OVRGLTFAccessor : Object
{
    public object byteOffset;
    public object byteLength;
    public object byteStride;
    public object bufferId;
    public object bufferLength;
    public object additionalOffset;
    public object dataType;
    public object componentType;
    public object dataCount;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x6B829E0
    public void GetDataCount(){} // RVA: 0xB9E080
    public void ToOVRType(){} // RVA: 0x6B82E10
    public void ReadAsInt(){} // RVA: 0x6B83040
    public void ReadAsFloat(){} // RVA: 0x6B83290
    public void ReadAsVector2(){} // RVA: 0x6B834E0
    public void ReadAsVector3(){} // RVA: 0x6B837A0
    public void ReadAsVector4(){} // RVA: 0x6B83C40
    public void ReadAsColor(){} // RVA: 0x6B84190
    public void ReadAsMatrix4x4(){} // RVA: 0x6B847A0
    public void ReadAsKtxTexture(){} // RVA: 0x6B84C30
    public void ReadAsBoneWeights(){} // RVA: 0x6B84D70
    public void GetStrideForType(){} // RVA: 0x6B85240
    public void GetMaxValueForType(){} // RVA: 0x6B852A0
    public void ReadElementAsUint(){} // RVA: 0x6B85320
    public void ReadElementAsFloat(){} // RVA: 0x6B855C0
}

public class OVRGLTFAnimatinonNode : Object
{
    public object m_intputNodeType;
    public object m_jsonData;
    public object m_binaryChunk;
    public object m_gameObj;
    public object m_inputNodeState;
    public object m_translations;
    public object m_rotations;
    public object m_scales;
    public object InputNodeKeyFrames;
    public object ThumbStickKeyFrames;
    public object CardDirections;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x6B85620
    public void AddChannel(){} // RVA: 0x6B85D10
    public void UpdatePose(){} // RVA: 0x6B868C0
    public void GetCardinalThumbsticks(){} // RVA: 0x6B86F60
    public void GetCardinalWeights(){} // RVA: 0x6B870D0
    public void ProcessAnimationSampler(){} // RVA: 0x6B872B0
    public void GetTransformType(){} // RVA: 0x6B87AE0
    public void ToOVRInterpolationType(){} // RVA: 0x6B87C70
    public void CopyData(){} // RVA: 0x8943B0
    public void CloneVector3(){} // RVA: 0x6B87E60
    public void CloneQuaternion(){} // RVA: 0x6B87E80
    public void .cctor(){} // RVA: 0x6B87EA0
}

public class OVRGLTFLoader : Object
{
    public object m_jsonData;
    public object m_glbStream;
    public object m_binaryChunk;
    public object m_Nodes;
    public object m_AnimationNodes;
    public object m_Shader;
    public object m_AlphaBlendShader;
    public object m_TextureQuality;
    public object m_TextureMipmapBias;
    public object GLTFToUnitySpace;
    public object GLTFToUnityTangent;
    public object GLTFToUnitySpace_Rotation;
    public object InputNodeNameMap;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x6B88630
    public void LoadGLB(){} // RVA: 0x6B88710
    public void SetModelShader(){} // RVA: 0xBBF900
    public void SetModelAlphaBlendShader(){} // RVA: 0xCA4DF0
    public void SetTextureQualityFiltering(){} // RVA: 0x12BB640
    public void SetMipMapBias(){} // RVA: 0x6B892D0
    public void DetectTextureQuality(){} // RVA: 0x6B89300
    public void ApplyTextureQuality(){} // RVA: 0x6B893E0
    public void ValidateGLB(){} // RVA: 0x6B89560
    public void ReadChunk(){} // RVA: 0x6B897C0
    public void ValidateChunk(){} // RVA: 0x6B89890
    public void LoadGLTF(){} // RVA: 0x6B89A10
    public void ProcessNode(){} // RVA: 0x6B8A170
    public void ProcessMesh(){} // RVA: 0x6B8B5A0
    public void FlipTraingleIndices(){} // RVA: 0x6B8D280
    public void ProcessSkin(){} // RVA: 0x6B8D310
    public void ProcessMaterial(){} // RVA: 0x6B8DA90
    public void ProcessTexture(){} // RVA: 0x6B8DDB0
    public void TranscodeTexture(){} // RVA: 0x6B8E400
    public void CreateUnityMaterial(){} // RVA: 0x6B8E480
    public void GetInputNodeType(){} // RVA: 0x6B8E690
    public void ProcessAnimations(){} // RVA: 0x6B8E8A0
    public void .cctor(){} // RVA: 0x6B8F150
}

public class OVRHaptics : Object
{
    public object Channels;
    public object LeftChannel;
    public object RightChannel;
    public object m_outputs;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x6B8F630
    public void Process(){} // RVA: 0x6B8FA40
}

public class OVRHapticsChannel : Object
{
    public object m_output;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x6B903B0
    public void Preempt(){} // RVA: 0x6B90480
    public void Queue(){} // RVA: 0x6B905A0
    public void Mix(){} // RVA: 0x6B90680
    public void Clear(){} // RVA: 0x6B906A0
}

public class OVRHapticsOutput : Object
{
    public object m_lowLatencyMode;
    public object m_paddingEnabled;
    public object m_prevSamplesQueued;
    public object m_prevSamplesQueuedTime;
    public object m_numPredictionHits;
    public object m_numPredictionMisses;
    public object m_numUnderruns;
    public object m_pendingClips;
    public object m_controller;
    public object m_nativeBuffer;
    public object m_paddingClip;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x6B90710
    public void Process(){} // RVA: 0x6B90AF0
    public void Preempt(){} // RVA: 0x6B91540
    public void Queue(){} // RVA: 0x6B91650
    public void Mix(){} // RVA: 0x6B91720
    public void Clear(){} // RVA: 0x6B91D60
}

public class OVRInput : Object
{
    public object AXIS_AS_BUTTON_THRESHOLD;
    public object AXIS_DEADZONE_THRESHOLD;
    public object controllers;
    public object activeControllerType;
    public object connectedControllerTypes;
    public object stepType;
    public object fixedUpdateCount;
    public object _pluginSupportsActiveController;
    public object _pluginSupportsActiveControllerCached;
    public object _pluginSupportsActiveControllerMinVersion;
    public object NUM_HAPTIC_CHANNELS;
    public object hapticInfos;
    public object OPENVR_MAX_HAPTIC_AMPLITUDE;
    public object HAPTIC_VIBRATION_DURATION_SECONDS;
    public object OPENVR_TOUCH_NAME;
    public object OPENVR_VIVE_CONTROLLER_NAME;
    public object OPENVR_WINDOWSMR_CONTROLLER_NAME;
    public object openVRControllerDetails;

    // ── Methods ──
    public void get_pluginSupportsActiveController(){} // RVA: 0x6B93490
    public void .cctor(){} // RVA: 0x6B935D0
    public void Update(){} // RVA: 0x6B93C60
    public void FixedUpdate(){} // RVA: 0x6B94610
    public void GetCurrentInteractionProfile(){} // RVA: 0x6B94920
    public void GetControllerOrientationTracked(){} // RVA: 0x6B94B00
    public void GetControllerOrientationValid(){} // RVA: 0x6B94BA0
    public void GetControllerPositionTracked(){} // RVA: 0x6B94C40
    public void GetControllerPositionValid(){} // RVA: 0x6B94D50
    public void GetLocalControllerPosition(){} // RVA: 0x6B94DF0
    public void GetLocalControllerVelocity(){} // RVA: 0x6B951F0
    public void GetLocalControllerAcceleration(){} // RVA: 0x6B95440
    public void GetLocalControllerRotation(){} // RVA: 0x6B95680
    public void GetLocalControllerAngularVelocity(){} // RVA: 0x6B95A70
    public void GetLocalControllerAngularAcceleration(){} // RVA: 0x6B95CC0
    public void GetLocalControllerStatesWithoutPrediction(){} // RVA: 0x6B95F10
    public void GetDominantHand(){} // RVA: 0x6B963B0
    public void Get(){} // RVA: 0x6B98560
    public void GetResolvedButton(){} // RVA: 0x6B96650
    public void GetDown(){} // RVA: 0x6B97890
    public void GetResolvedButtonDown(){} // RVA: 0x6B968F0
    public void GetUp(){} // RVA: 0x6B97B40
    public void GetResolvedButtonUp(){} // RVA: 0x6B96BA0
    public void GetResolvedTouch(){} // RVA: 0x6B96E50
    public void GetResolvedTouchDown(){} // RVA: 0x6B970F0
    public void GetResolvedTouchUp(){} // RVA: 0x6B973A0
    public void GetResolvedNearTouch(){} // RVA: 0x6B97650
    public void GetResolvedNearTouchDown(){} // RVA: 0x6B978F0
    public void GetResolvedNearTouchUp(){} // RVA: 0x6B97BA0
    public void GetResolvedAxis1D(){} // RVA: 0x6B97E50
    public void GetResolvedAxis2D(){} // RVA: 0x6B985C0
    public void GetConnectedControllers(){} // RVA: 0x6B989F0
    public void IsControllerConnected(){} // RVA: 0x6B98A50
    public void GetActiveController(){} // RVA: 0x6B98AB0
    public void StartVibration(){} // RVA: 0x6B98B10
    public void SetOpenVRLocalPose(){} // RVA: 0x6B98D20
    public void GetOpenVRStringProperty(){} // RVA: 0x6B98E50
    public void UpdateXRControllerNodeIds(){} // RVA: 0x6B99020
    public void UpdateXRControllerHaptics(){} // RVA: 0x6B99570
    public void InitHapticInfo(){} // RVA: 0x6B997B0
    public void PlayHapticImpulse(){} // RVA: 0x6B99A00
    public void IsValidOpenVRDevice(){} // RVA: 0x6B99B80
    public void SetControllerVibration(){} // RVA: 0x6B99B90
    public void SetControllerLocalizedVibration(){} // RVA: 0x6B99E20
    public void GetControllerBatteryPercentRemaining(){} // RVA: 0x6B9A0A0
    public void CalculateAbsMax(){} // RVA: 0x6B9A2B0
    public void CalculateDeadzone(){} // RVA: 0x6B9A3F0
    public void ShouldResolveController(){} // RVA: 0x6B9A450
}

public class OVRKtxTexture : Object
{
    public object KTX_TTF_BC7_RGBA;
    public object KTX_TTF_ASTC_4x4_RGBA;

    // ── Methods ──
    public void Load(){} // RVA: 0x6B9D790
    public void .ctor(){} // RVA: 0xB43310
}

public class OVRLayerAttribute : PropertyAttribute
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xF48510
}

public class OVRMixedReality : Object
{
    public object useFakeExternalCamera;
    public object fakeCameraFloorLevelPosition;
    public object fakeCameraEyeLevelPosition;
    public object fakeCameraRotation;
    public object fakeCameraFov;
    public object fakeCameraAspect;
    public object currentComposition;

    // ── Methods ──
    public void Update(){} // RVA: 0x6BAF6E0
    public void Cleanup(){} // RVA: 0x6BB0030
    public void RecenterPose(){} // RVA: 0x6BB0300
    public void .cctor(){} // RVA: 0x6BB03A0
}

public class OVRMixedRealityCaptureConfiguration
{
    // ── Methods ──
    public void get_enableMixedReality(){} // RVA: 0x87D280
    public void set_enableMixedReality(){} // RVA: 0x894750
    public void get_extraHiddenLayers(){} // RVA: 0x87C130
    public void set_extraHiddenLayers(){} // RVA: 0x8944F0
    public void get_extraVisibleLayers(){} // RVA: 0x87C130
    public void set_extraVisibleLayers(){} // RVA: 0x8944F0
    public void get_dynamicCullingMask(){} // RVA: 0x87D280
    public void set_dynamicCullingMask(){} // RVA: 0x894750
    public void get_compositionMethod(){} // RVA: 0x87C130
    public void set_compositionMethod(){} // RVA: 0x8944F0
    public void get_externalCompositionBackdropColorRift(){} // RVA: 0x87BEB0
    public void set_externalCompositionBackdropColorRift(){} // RVA: 0x894320
    public void get_externalCompositionBackdropColorQuest(){} // RVA: 0x87BEB0
    public void set_externalCompositionBackdropColorQuest(){} // RVA: 0x894320
    public void get_capturingCameraDevice(){} // RVA: 0x87C130
    public void set_capturingCameraDevice(){} // RVA: 0x8944F0
    public void get_flipCameraFrameHorizontally(){} // RVA: 0x87D280
    public void set_flipCameraFrameHorizontally(){} // RVA: 0x894750
    public void get_flipCameraFrameVertically(){} // RVA: 0x87D280
    public void set_flipCameraFrameVertically(){} // RVA: 0x894750
    public void get_handPoseStateLatency(){} // RVA: 0x890F90
    public void set_handPoseStateLatency(){} // RVA: 0x8A23A0
    public void get_sandwichCompositionRenderLatency(){} // RVA: 0x890F90
    public void set_sandwichCompositionRenderLatency(){} // RVA: 0x8A23A0
    public void get_sandwichCompositionBufferedFrames(){} // RVA: 0x87C130
    public void set_sandwichCompositionBufferedFrames(){} // RVA: 0x8944F0
    public void get_chromaKeyColor(){} // RVA: 0x87BEB0
    public void set_chromaKeyColor(){} // RVA: 0x894320
    public void get_chromaKeySimilarity(){} // RVA: 0x890F90
    public void set_chromaKeySimilarity(){} // RVA: 0x8A23A0
    public void get_chromaKeySmoothRange(){} // RVA: 0x890F90
    public void set_chromaKeySmoothRange(){} // RVA: 0x8A23A0
    public void get_chromaKeySpillRange(){} // RVA: 0x890F90
    public void set_chromaKeySpillRange(){} // RVA: 0x8A23A0
    public void get_useDynamicLighting(){} // RVA: 0x87D280
    public void set_useDynamicLighting(){} // RVA: 0x894750
    public void get_depthQuality(){} // RVA: 0x87C130
    public void set_depthQuality(){} // RVA: 0x8944F0
    public void get_dynamicLightingSmoothFactor(){} // RVA: 0x890F90
    public void set_dynamicLightingSmoothFactor(){} // RVA: 0x8A23A0
    public void get_dynamicLightingDepthVariationClampingValue(){} // RVA: 0x890F90
    public void set_dynamicLightingDepthVariationClampingValue(){} // RVA: 0x8A23A0
    public void get_virtualGreenScreenType(){} // RVA: 0x87C130
    public void set_virtualGreenScreenType(){} // RVA: 0x8944F0
    public void get_virtualGreenScreenTopY(){} // RVA: 0x890F90
    public void set_virtualGreenScreenTopY(){} // RVA: 0x8A23A0
    public void get_virtualGreenScreenBottomY(){} // RVA: 0x890F90
    public void set_virtualGreenScreenBottomY(){} // RVA: 0x8A23A0
    public void get_virtualGreenScreenApplyDepthCulling(){} // RVA: 0x87D280
    public void set_virtualGreenScreenApplyDepthCulling(){} // RVA: 0x894750
    public void get_virtualGreenScreenDepthTolerance(){} // RVA: 0x890F90
    public void set_virtualGreenScreenDepthTolerance(){} // RVA: 0x8A23A0
    public void get_mrcActivationMode(){} // RVA: 0x87C130
    public void set_mrcActivationMode(){} // RVA: 0x8944F0
    public void get_instantiateMixedRealityCameraGameObject(){} // RVA: 0x87C0A0
    public void set_instantiateMixedRealityCameraGameObject(){} // RVA: 0x894320
}

public class OVRNativeBuffer : Object
{
    public object disposed;
    public object m_numBytes;
    public object m_ptr;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x6B7CF00
    public void Finalize(){} // RVA: 0x6B7CF10
    public void Reset(){} // RVA: 0x6B7CF60
    public void GetCapacity(){} // RVA: 0x116A650
    public void GetPointer(){} // RVA: 0x6B7CF70
    public void Dispose(){} // RVA: 0x6B7D000
    public void Reallocate(){} // RVA: 0x6B7D020
    public void Release(){} // RVA: 0x6B7D0E0
}

public class OVRNodeStateProperties : Object
{
    public object nodeStateList;

    // ── Methods ──
    public void IsHmdPresent(){} // RVA: 0x6B7B140
    public void GetNodeStatePropertyVector3(){} // RVA: 0x6B7B270
    public void GetNodeStatePropertyQuaternion(){} // RVA: 0x6B7B8A0
    public void ValidateProperty(){} // RVA: 0x6B7BB20
    public void GetUnityXRNodeStateVector3(){} // RVA: 0x6B7BE50
    public void GetUnityXRNodeStateQuaternion(){} // RVA: 0x6B7C030
    public void .cctor(){} // RVA: 0x6B7C150
}

public class OVRP_0_1_0 : Object
{
    public object version;

    // ── Methods ──
    public void ovrp_GetEyeTextureSize(){} // RVA: 0x6BE9630
    public void .cctor(){} // RVA: 0x6BE96B0
}

public class OVRP_0_1_1 : Object
{
    public object version;

    // ── Methods ──
    public void ovrp_SetOverlayQuad2(){} // RVA: 0x6BE9780
    public void .cctor(){} // RVA: 0x6BE9880
}

public class OVRP_0_1_2 : Object
{
    public object version;

    // ── Methods ──
    public void ovrp_GetNodePose(){} // RVA: 0x6BE9950
    public void ovrp_SetControllerVibration(){} // RVA: 0x6BE99F0
    public void .cctor(){} // RVA: 0x6BE9A90
}

public class OVRP_0_1_3 : Object
{
    public object version;

    // ── Methods ──
    public void ovrp_GetNodeVelocity(){} // RVA: 0x6BE9B60
    public void ovrp_GetNodeAcceleration(){} // RVA: 0x6BE9C00
    public void .cctor(){} // RVA: 0x6BE9CA0
}

public class OVRP_0_5_0 : Object
{
    public object version;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x6BE9D70
}

public class OVRP_1_0_0 : Object
{
    public object version;

    // ── Methods ──
    public void ovrp_GetTrackingOriginType(){} // RVA: 0x6BE9E40
    public void ovrp_SetTrackingOriginType(){} // RVA: 0x6BE9EB0
    public void ovrp_GetTrackingCalibratedOrigin(){} // RVA: 0x6BE9F30
    public void ovrp_RecenterTrackingOrigin(){} // RVA: 0x6BE9FC0
    public void .cctor(){} // RVA: 0x6BEA040
}

public class OVRP_1_10_0 : Object
{
    public object version;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x6BED5B0
}

public class OVRP_1_11_0 : Object
{
    public object version;

    // ── Methods ──
    public void ovrp_SetDesiredEyeTextureFormat(){} // RVA: 0x6BED680
    public void ovrp_GetDesiredEyeTextureFormat(){} // RVA: 0x6BED700
    public void .cctor(){} // RVA: 0x6BED770
}

public class OVRP_1_12_0 : Object
{
    public object version;

    // ── Methods ──
    public void ovrp_GetAppFramerate(){} // RVA: 0x6BED840
    public void ovrp_GetNodePoseState(){} // RVA: 0x6BED8B0
    public void ovrp_GetControllerState2(){} // RVA: 0x6BED980
    public void .cctor(){} // RVA: 0x6BEDA30
}

public class OVRP_1_15_0 : Object
{
    public object version;
    public object OVRP_EXTERNAL_CAMERA_NAME_SIZE;

    // ── Methods ──
    public void ovrp_InitializeMixedReality(){} // RVA: 0x6BEDB00
    public void ovrp_ShutdownMixedReality(){} // RVA: 0x6BEDB70
    public void ovrp_GetMixedRealityInitialized(){} // RVA: 0x6BEDBE0
    public void ovrp_UpdateExternalCamera(){} // RVA: 0x6BEDC50
    public void ovrp_GetExternalCameraCount(){} // RVA: 0x6BEDCC0
    public void ovrp_GetExternalCameraName(){} // RVA: 0x6BEDD40
    public void ovrp_GetExternalCameraIntrinsics(){} // RVA: 0x6BEDE40
    public void ovrp_GetExternalCameraExtrinsics(){} // RVA: 0x6BEDED0
    public void ovrp_CalculateLayerDesc(){} // RVA: 0x6BEDF60
    public void ovrp_EnqueueSetupLayer(){} // RVA: 0x6BEE000
    public void ovrp_EnqueueDestroyLayer(){} // RVA: 0x6BEE090
    public void ovrp_GetLayerTextureStageCount(){} // RVA: 0x6BEE110
    public void ovrp_GetLayerTexturePtr(){} // RVA: 0x6BEE1A0
    public void ovrp_EnqueueSubmitLayer(){} // RVA: 0x6BEE240
    public void ovrp_GetNodeFrustum2(){} // RVA: 0x6BEE2F0
    public void ovrp_GetEyeTextureArrayEnabled(){} // RVA: 0x6BEE380
    public void .cctor(){} // RVA: 0x6BEE3F0
}

public class OVRP_1_16_0 : Object
{
    public object version;

    // ── Methods ──
    public void ovrp_UpdateCameraDevices(){} // RVA: 0x6BEE4C0
    public void ovrp_IsCameraDeviceAvailable(){} // RVA: 0x6BEE530
    public void ovrp_SetCameraDevicePreferredColorFrameSize(){} // RVA: 0x6BEE5B0
    public void ovrp_OpenCameraDevice(){} // RVA: 0x6BEE640
    public void ovrp_CloseCameraDevice(){} // RVA: 0x6BEE6C0
    public void ovrp_HasCameraDeviceOpened(){} // RVA: 0x6BEE740
    public void ovrp_IsCameraDeviceColorFrameAvailable(){} // RVA: 0x6BEE7C0
    public void ovrp_GetCameraDeviceColorFrameSize(){} // RVA: 0x6BEE840
    public void ovrp_GetCameraDeviceColorFrameBgraPixels(){} // RVA: 0x6BEE8D0
    public void ovrp_GetControllerState4(){} // RVA: 0x6BEE970
    public void .cctor(){} // RVA: 0x6BEEA00
}

public class OVRP_1_17_0 : Object
{
    public object version;

    // ── Methods ──
    public void ovrp_GetExternalCameraPose(){} // RVA: 0x6BEEAD0
    public void ovrp_ConvertPoseToCameraSpace(){} // RVA: 0x6BEEB60
    public void ovrp_GetCameraDeviceIntrinsicsParameters(){} // RVA: 0x6BEEC00
    public void ovrp_DoesCameraDeviceSupportDepth(){} // RVA: 0x6BEECA0
    public void ovrp_GetCameraDeviceDepthSensingMode(){} // RVA: 0x6BEED30
    public void ovrp_SetCameraDeviceDepthSensingMode(){} // RVA: 0x6BEEDC0
    public void ovrp_GetCameraDevicePreferredDepthQuality(){} // RVA: 0x6BEEE50
    public void ovrp_SetCameraDevicePreferredDepthQuality(){} // RVA: 0x6BEEEE0
    public void ovrp_IsCameraDeviceDepthFrameAvailable(){} // RVA: 0x6BEEF70
    public void ovrp_GetCameraDeviceDepthFrameSize(){} // RVA: 0x6BEF000
    public void ovrp_GetCameraDeviceDepthFramePixels(){} // RVA: 0x6BEF090
    public void ovrp_GetCameraDeviceDepthConfidencePixels(){} // RVA: 0x6BEF130
    public void .cctor(){} // RVA: 0x6BEF1D0
}

public class OVRP_1_1_0 : Object
{
    public object version;

    // ── Methods ──
    public void ovrp_GetInitialized(){} // RVA: 0x6BEA110
    public void _ovrp_GetVersion(){} // RVA: 0x6BEA180
    public void ovrp_GetVersion(){} // RVA: 0x6BEA1F0
    public void _ovrp_GetNativeSDKVersion(){} // RVA: 0x6BEA2F0
    public void ovrp_GetNativeSDKVersion(){} // RVA: 0x6BEA360
    public void ovrp_GetAudioOutId(){} // RVA: 0x6BEA460
    public void ovrp_GetAudioInId(){} // RVA: 0x6BEA4D0
    public void ovrp_GetEyeTextureScale(){} // RVA: 0x6BEA540
    public void ovrp_SetEyeTextureScale(){} // RVA: 0x6BEA5B0
    public void ovrp_GetTrackingOrientationSupported(){} // RVA: 0x6BEA630
    public void ovrp_GetTrackingOrientationEnabled(){} // RVA: 0x6BEA6A0
    public void ovrp_SetTrackingOrientationEnabled(){} // RVA: 0x6BEA710
    public void ovrp_GetTrackingPositionSupported(){} // RVA: 0x6BEA790
    public void ovrp_GetTrackingPositionEnabled(){} // RVA: 0x6BEA800
    public void ovrp_SetTrackingPositionEnabled(){} // RVA: 0x6BEA870
    public void ovrp_GetNodePresent(){} // RVA: 0x6BEA8F0
    public void ovrp_GetNodeOrientationTracked(){} // RVA: 0x6BEA970
    public void ovrp_GetNodePositionTracked(){} // RVA: 0x6BEA9F0
    public void ovrp_GetNodeFrustum(){} // RVA: 0x6BEAA70
    public void ovrp_GetControllerState(){} // RVA: 0x6BEAB00
    public void ovrp_GetSystemCpuLevel(){} // RVA: 0x6BEABA0
    public void ovrp_SetSystemCpuLevel(){} // RVA: 0x6BEAC10
    public void ovrp_GetSystemGpuLevel(){} // RVA: 0x6BEAC90
    public void ovrp_SetSystemGpuLevel(){} // RVA: 0x6BEAD00
    public void ovrp_GetSystemPowerSavingMode(){} // RVA: 0x6BEAD80
    public void ovrp_GetSystemDisplayFrequency(){} // RVA: 0x6BEADF0
    public void ovrp_GetSystemVSyncCount(){} // RVA: 0x6BEAE60
    public void ovrp_GetSystemVolume(){} // RVA: 0x6BEAED0
    public void ovrp_GetSystemBatteryStatus(){} // RVA: 0x6BEAF40
    public void ovrp_GetSystemBatteryLevel(){} // RVA: 0x6BEAFB0
    public void ovrp_GetSystemBatteryTemperature(){} // RVA: 0x6BEB020
    public void _ovrp_GetSystemProductName(){} // RVA: 0x6BEB090
    public void ovrp_GetSystemProductName(){} // RVA: 0x6BEB100
    public void ovrp_ShowSystemUI(){} // RVA: 0x6BEB200
    public void ovrp_GetAppMonoscopic(){} // RVA: 0x6BEB280
    public void ovrp_SetAppMonoscopic(){} // RVA: 0x6BEB2F0
    public void ovrp_GetAppHasVrFocus(){} // RVA: 0x6BEB370
    public void ovrp_GetAppShouldQuit(){} // RVA: 0x6BEB3E0
    public void ovrp_GetAppShouldRecenter(){} // RVA: 0x6BEB450
    public void _ovrp_GetAppLatencyTimings(){} // RVA: 0x6BEB4C0
    public void ovrp_GetAppLatencyTimings(){} // RVA: 0x6BEB530
    public void ovrp_GetUserPresent(){} // RVA: 0x6BEB630
    public void ovrp_GetUserIPD(){} // RVA: 0x6BEB6A0
    public void ovrp_SetUserIPD(){} // RVA: 0x6BEB710
    public void ovrp_GetUserEyeDepth(){} // RVA: 0x6BEB790
    public void ovrp_SetUserEyeDepth(){} // RVA: 0x6BEB800
    public void ovrp_GetUserEyeHeight(){} // RVA: 0x6BEB880
    public void ovrp_SetUserEyeHeight(){} // RVA: 0x6BEB8F0
    public void .cctor(){} // RVA: 0x6BEB970
}

public class OVRP_1_2_0 : Object
{
    public object version;

    // ── Methods ──
    public void ovrp_SetSystemVSyncCount(){} // RVA: 0x6BEBA40
    public void ovrpi_SetTrackingCalibratedOrigin(){} // RVA: 0x6BEBAC0
    public void .cctor(){} // RVA: 0x6BEBB30
}

public class OVRP_1_3_0 : Object
{
    public object version;

    // ── Methods ──
    public void ovrp_GetEyeOcclusionMeshEnabled(){} // RVA: 0x6BEBC00
    public void ovrp_SetEyeOcclusionMeshEnabled(){} // RVA: 0x6BEBC70
    public void ovrp_GetSystemHeadphonesPresent(){} // RVA: 0x6BEBCF0
    public void .cctor(){} // RVA: 0x6BEBD60
}

public class OVRP_1_5_0 : Object
{
    public object version;

    // ── Methods ──
    public void ovrp_GetSystemRegion(){} // RVA: 0x6BEBE30
    public void .cctor(){} // RVA: 0x6BEBEA0
}

public class OVRP_1_6_0 : Object
{
    public object version;

    // ── Methods ──
    public void ovrp_GetTrackingIPDEnabled(){} // RVA: 0x6BEBF70
    public void ovrp_SetTrackingIPDEnabled(){} // RVA: 0x6BEBFE0
    public void ovrp_GetControllerHapticsDesc(){} // RVA: 0x6BEC060
    public void ovrp_GetControllerHapticsState(){} // RVA: 0x6BEC100
    public void ovrp_SetControllerHaptics(){} // RVA: 0x6BEC180
    public void ovrp_SetOverlayQuad3(){} // RVA: 0x6BEC210
    public void ovrp_GetEyeRecommendedResolutionScale(){} // RVA: 0x6BEC320
    public void ovrp_GetAppCpuStartToGpuEndTime(){} // RVA: 0x6BEC390
    public void ovrp_GetSystemRecommendedMSAALevel(){} // RVA: 0x6BEC400
    public void .cctor(){} // RVA: 0x6BEC470
}

public class OVRP_1_7_0 : Object
{
    public object version;

    // ── Methods ──
    public void ovrp_GetAppChromaticCorrection(){} // RVA: 0x6BEC540
    public void ovrp_SetAppChromaticCorrection(){} // RVA: 0x6BEC5B0
    public void .cctor(){} // RVA: 0x6BEC630
}

public class OVRP_1_8_0 : Object
{
    public object version;

    // ── Methods ──
    public void ovrp_GetBoundaryConfigured(){} // RVA: 0x6BEC700
    public void ovrp_TestBoundaryNode(){} // RVA: 0x6BEC770
    public void ovrp_TestBoundaryPoint(){} // RVA: 0x6BEC820
    public void ovrp_GetBoundaryGeometry(){} // RVA: 0x6BEC8E0
    public void ovrp_GetBoundaryDimensions(){} // RVA: 0x6BECAD0
    public void ovrp_GetBoundaryVisible(){} // RVA: 0x6BECB70
    public void ovrp_SetBoundaryVisible(){} // RVA: 0x6BECBE0
    public void ovrp_Update2(){} // RVA: 0x6BECC60
    public void ovrp_GetNodePose2(){} // RVA: 0x6BECD00
    public void ovrp_GetNodeVelocity2(){} // RVA: 0x6BECDB0
    public void ovrp_GetNodeAcceleration2(){} // RVA: 0x6BECE60
    public void .cctor(){} // RVA: 0x6BECF10
}

public class OVRP_1_9_0 : Object
{
    public object version;

    // ── Methods ──
    public void ovrp_GetSystemHeadsetType(){} // RVA: 0x6BECFE0
    public void ovrp_GetActiveController(){} // RVA: 0x6BED050
    public void ovrp_GetConnectedControllers(){} // RVA: 0x6BED0C0
    public void ovrp_GetBoundaryGeometry2(){} // RVA: 0x6BED130
    public void ovrp_GetAppPerfStats(){} // RVA: 0x6BED1D0
    public void ovrp_ResetAppPerfStats(){} // RVA: 0x6BED470
    public void .cctor(){} // RVA: 0x6BED4E0
}

public class OVRPermissionsRequester : Object
{
    public object PermissionGranted;
    public object FaceTrackingPermission;
    public object EyeTrackingPermission;
    public object BodyTrackingPermission;

    // ── Methods ──
    public void add_PermissionGranted(){} // RVA: 0x6BBE580
    public void remove_PermissionGranted(){} // RVA: 0x6BBE6B0
    public void GetPermissionId(){} // RVA: 0x6BBE7E0
    public void IsPermissionSupportedByPlatform(){} // RVA: 0x6BBE8E0
    public void IsPermissionGranted(){} // RVA: 0xC2E4C0
    public void Request(){} // RVA: 0xB43310
    public void ShouldRequestPermission(){} // RVA: 0x6BBEE90
}

public class OVRPose : ValueType
{
    public object position;
    public object orientation;

    // ── Methods ──
    public void get_identity(){} // RVA: 0x6B7C230
    public void Equals(){} // RVA: 0x8C94B0
    public void GetHashCode(){} // RVA: 0x8C94C0
    public void op_Equality(){} // RVA: 0x6B7C4D0
    public void op_Inequality(){} // RVA: 0x6B7C570
    public void op_Multiply(){} // RVA: 0x6B7C620
    public void Inverse(){} // RVA: 0x8C94D0
    public void flipZ(){} // RVA: 0x8C9510
    public void ToPosef_Legacy(){} // RVA: 0x8C9570
    public void ToPosef(){} // RVA: 0x8C95E0
    public void Rotate180AlongX(){} // RVA: 0x8C9660
}

public class OVRSandwichComposition : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
}

public class ObjectComparer : Object
{
    // ── Methods ──
    public void System.Collections.Generic.IEqualityComparer<System.Object>.Equals(){} // RVA: 0x7E76A40
    public void System.Collections.Generic.IEqualityComparer<System.Object>.GetHashCode(){} // RVA: 0x3F15780
    public void .ctor(){} // RVA: 0xB43310
}

public class ObjectReaperDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xBA0FE0
    public void Invoke(){} // RVA: 0xBA10B0
    public void BeginInvoke(){} // RVA: 0xBA10C0
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class ObjectValueCollection : Object
{
    public object Values;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xA4AE260
    public void get_Count(){} // RVA: 0xA4AE320
    public void get_Item(){} // RVA: 0xA4AE370
    public void set_Item(){} // RVA: 0xA4AE460
    public void System.Collections.Generic.IReadOnlyList<System.Object>.get_Item(){} // RVA: 0xA4AE4A0
    public void System.Collections.Generic.IList<System.Object>.get_Item(){} // RVA: 0xA4AE5B0
    public void System.Collections.Generic.IList<System.Object>.set_Item(){} // RVA: 0xA4AE6C0
    public void System.Collections.IList.get_Item(){} // RVA: 0xA4AE700
    public void System.Collections.IList.set_Item(){} // RVA: 0xA4AE810
    public void get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void get_SyncRoot(){} // RVA: 0xA4AE850
    public void get_IsSynchronized(){} // RVA: 0xB43320
    public void get_IsFixedSize(){} // RVA: 0xC2E4C0
    public void Contains(){} // RVA: 0xA4AE910
    public void System.Collections.ICollection.CopyTo(){} // RVA: 0xA4AE9C0
    public void CopyTo(){} // RVA: 0xA4AEE90
    public void Add(){} // RVA: 0xA4AF120
    public void System.Collections.IList.Add(){} // RVA: 0xA4AF160
    public void Clear(){} // RVA: 0xA4AF1A0
    public void Remove(){} // RVA: 0xA4AF220
    public void System.Collections.IList.Remove(){} // RVA: 0xA4AF260
    public void Insert(){} // RVA: 0xA4AF2E0
    public void RemoveAt(){} // RVA: 0xA4AF320
    public void GetEnumerator(){} // RVA: 0xA4AF360
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xA4AF3B0
    public void System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator(){} // RVA: 0xA4AF3F0
    public void IndexOf(){} // RVA: 0xA4AF530
}

public class ObserverState : Object
{
    public object observers;
    public object onEventDelegate;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x792AD30
    public void <.ctor>b__2_0(){} // RVA: 0x792ADF0
}

public class OnCaptureResourceCreatedCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xBC4530
    public void Invoke(){} // RVA: 0xB9E010
}

public class OnCapturedToDiskCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x35A76F0
    public void Invoke(){} // RVA: 0x35A77C0
}

public class OnCapturedToMemoryCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x26DB610
    public void Invoke(){} // RVA: 0x26DB6E0
}

public class OnChangeEvent : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A54F00
}

public class OnChangeEvent : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x80DD890
}

public class OnDecodeError : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x828CB40
    public void Invoke(){} // RVA: 0xCA8D60
    public void BeginInvoke(){} // RVA: 0x828CC30
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class OnFinishedCulling : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x26E1500
    public void Invoke(){} // RVA: 0xB9E010
}

public class OnOverrideControllerDirtyCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xBA0FE0
    public void Invoke(){} // RVA: 0xBA10B0
}

public class OnPerformCulling : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7C43D00
    public void Invoke(){} // RVA: 0x7C43E70
}

public class OnPhotoModeStartedCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x35A76F0
    public void Invoke(){} // RVA: 0x35A77C0
}

public class OnPhotoModeStoppedCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x35A76F0
    public void Invoke(){} // RVA: 0x35A77C0
}

public class OnScreenDeviceInfo : ValueType
{
    public object eventPtr;
    public object buffer;
    public object device;
    public object firstControl;

    // ── Methods ──
    public void AddControl(){} // RVA: 0x938100
    public void RemoveControl(){} // RVA: 0x938140
    public void Destroy(){} // RVA: 0x938180
}

public class OnStartedRecordingVideoCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x35A76F0
    public void Invoke(){} // RVA: 0x35A77C0
}

public class OnStatusChanged : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x26DB540
    public void Invoke(){} // RVA: 0x14CC9D0
}

public class OnStoppedRecordingVideoCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x35A76F0
    public void Invoke(){} // RVA: 0x35A77C0
}

public class OnValidateInput : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A54D60
    public void Invoke(){} // RVA: 0xCA8D60
    public void BeginInvoke(){} // RVA: 0x7A54E50
    public void EndInvoke(){} // RVA: 0x3DFBD50
}

public class OnValidateInput : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A54D60
    public void Invoke(){} // RVA: 0xCA8D60
    public void BeginInvoke(){} // RVA: 0x7A54E50
    public void EndInvoke(){} // RVA: 0x3DFBD50
}

public class OnVideoCaptureResourceCreatedCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xBC4530
    public void Invoke(){} // RVA: 0xB9E010
}

public class OnVideoModeStartedCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x35A76F0
    public void Invoke(){} // RVA: 0x35A77C0
}

public class OnVideoModeStoppedCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x35A76F0
    public void Invoke(){} // RVA: 0x35A77C0
}

public class OpacityIdUpdateJob : ValueType
{
    public object oldVerts;
    public object newVerts;
    public object opacityData;

    // ── Methods ──
    public void Execute(){} // RVA: 0x99DDC0
}

public class Operator : Object
{
    public object op;
    public object precedence;
    public object associativity;
    public object inputs;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7B6FE30
}

public class OptionData : Object
{
    public object m_Text;
    public object m_Image;
    public object m_Color;

    // ── Methods ──
    public void get_text(){} // RVA: 0xB5DBF0
    public void set_text(){} // RVA: 0xB44D60
    public void get_image(){} // RVA: 0xB465B0
    public void set_image(){} // RVA: 0xBA9BA0
    public void get_color(){} // RVA: 0x16CD810
    public void set_color(){} // RVA: 0x16DCCA0
    public void .ctor(){} // RVA: 0x79F9080
}

public class OptionDataList : Object
{
    public object m_Options;

    // ── Methods ──
    public void get_options(){} // RVA: 0xB5DBF0
    public void set_options(){} // RVA: 0xB44D60
    public void .ctor(){} // RVA: 0x79F9150
}

public class OptionData[] : Array
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

public class Option[] : Array
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

public class OptionsAndroid : PlatformOptions
{
    public object _changed;
    public object videoOutputMode;
    public object DefaultTextureFormat;
    public object textureFormat;
    public object _generateMipmaps;
    public object _previousAudioMode;
    public object _audioMode;
    public object _preferredMaximumResolution;
    public object _customPreferredMaximumResolution;
    public object _preferredPeakBitRate;
    public object _preferredPeakBitRateUnits;
    public object _allowUnsupportedVideoTrackVariants;
    public object videoApi;
    public object showPosterFrame;
    public object audio360ChannelMode;
    public object audio360LatencyMS;
    public object preferSoftwareDecoder;
    public object forceRtpTCP;
    public object forceEnableMediaCodecAsynchronousQueueing;
    public object fileOffset;
    public object startWithHighestBitrate;
    public object minBufferMs;
    public object maxBufferMs;
    public object bufferForPlaybackMs;
    public object bufferForPlaybackAfterRebufferMs;
    public object prioritiseTimeOverSize;
    public object useFastOesPath;
    public object audioOutput;
    public object blitTextureFiltering;
    public object forceEnableMediaCodecAsyncQueueing;
    public object enableAudio360;

    // ── Methods ──
    public void get_generateMipmaps(){} // RVA: 0xB68DF0
    public void set_generateMipmaps(){} // RVA: 0x2547FB0
    public void get_previousAudioMode(){} // RVA: 0xE9CE60
    public void get_audioMode(){} // RVA: 0x18A0130
    public void set_audioMode(){} // RVA: 0x2547FC0
    public void get_IsUsingAudioCapture(){} // RVA: 0x2547FE0
    public void get_preferredMaximumResolution(){} // RVA: 0x114DAD0
    public void set_preferredMaximumResolution(){} // RVA: 0x2548000
    public void get_customPreferredMaximumResolution(){} // RVA: 0xBC1B30
    public void set_customPreferredMaximumResolution(){} // RVA: 0x2548010
    public void get_preferredPeakBitRate(){} // RVA: 0x1767220
    public void set_preferredPeakBitRate(){} // RVA: 0x2548040
    public void get_preferredPeakBitRateUnits(){} // RVA: 0x1D46130
    public void set_preferredPeakBitRateUnits(){} // RVA: 0x2548060
    public void get_allowUnsupportedVideoTrackVariants(){} // RVA: 0xC00EC0
    public void set_allowUnsupportedVideoTrackVariants(){} // RVA: 0x2548070
    public void IsModified(){} // RVA: 0x2548080
    public void BitRateInBitsPerSecond(){} // RVA: 0x2547DE0
    public void GetPreferredPeakBitRateInBitsPerSecond(){} // RVA: 0x2548140
    public void StartWithHighestBandwidth(){} // RVA: 0x100AD20
    public void HasChanged(){} // RVA: 0x2548190
    public void ClearChanges(){} // RVA: 0x25481B0
    public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0xB43310
    public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x25481C0
    public void .ctor(){} // RVA: 0x25481F0
}

public class OptionsApple : PlatformOptions
{
    public object DefaultTextureFormat;
    public object DefaultFlags;
    public object textureFormat;
    public object _previousAudioMode;
    public object _audioMode;
    public object _flags;
    public object maximumPlaybackRate;
    public object _changed;
    public object _preferredPeakBitRate;
    public object _preferredPeakBitRateUnits;
    public object _preferredForwardBufferDuration;
    public object _preferredMaximumResolution;
    public object _customPreferredMaximumResolution;

    // ── Methods ──
    public void get_previousAudioMode(){} // RVA: 0x1AE5AC0
    public void get_audioMode(){} // RVA: 0xB9E080
    public void set_audioMode(){} // RVA: 0x2547CC0
    public void get_IsUsingAudioCapture(){} // RVA: 0x2547CE0
    public void get_flags(){} // RVA: 0xE9CE60
    public void set_flags(){} // RVA: 0x2547D00
    public void get_preferredPeakBitRate(){} // RVA: 0xD344A0
    public void set_preferredPeakBitRate(){} // RVA: 0x2547D30
    public void get_preferredPeakBitRateUnits(){} // RVA: 0xBE5870
    public void set_preferredPeakBitRateUnits(){} // RVA: 0x2547D50
    public void get_preferredForwardBufferDuration(){} // RVA: 0x2547D60
    public void set_preferredForwardBufferDuration(){} // RVA: 0x2547D70
    public void get_preferredMaximumResolution(){} // RVA: 0xE32C80
    public void set_preferredMaximumResolution(){} // RVA: 0x2547D90
    public void get_customPreferredMaximumResolution(){} // RVA: 0x2547DA0
    public void set_customPreferredMaximumResolution(){} // RVA: 0x2547DB0
    public void BitRateInBitsPerSecond(){} // RVA: 0x2547DE0
    public void GetPreferredPeakBitRateInBitsPerSecond(){} // RVA: 0x2547E20
    public void .ctor(){} // RVA: 0x2547E60
    public void IsModified(){} // RVA: 0x2547F20
    public void HasChanged(){} // RVA: 0x2547F90
    public void ClearChanges(){} // RVA: 0x2547FA0
}

public class OptionsOpenHarmony : PlatformOptions
{
    public object _changed;
    public object DefaultTextureFormat;
    public object textureFormat;
    public object _generateMipmapsOH;
    public object _useNormalizedOHMUrl;
    public object _previousAudioMode;
    public object _audioMode;
    public object _preferredMaximumResolution;
    public object _customPreferredMaximumResolution;

    // ── Methods ──
    public void get_generateMipmaps(){} // RVA: 0xC27380
    public void set_generateMipmaps(){} // RVA: 0x2548270
    public void get_useNormalizedOHMUrl(){} // RVA: 0xD96880
    public void set_useNormalizedOHMUrl(){} // RVA: 0x2548280
    public void get_previousAudioMode(){} // RVA: 0xB9E080
    public void get_audioMode(){} // RVA: 0xE9CE60
    public void set_audioMode(){} // RVA: 0x2548290
    public void get_IsUsingAudioCapture(){} // RVA: 0x25482B0
    public void get_preferredMaximumResolution(){} // RVA: 0x18A0130
    public void set_preferredMaximumResolution(){} // RVA: 0x25482D0
    public void get_customPreferredMaximumResolution(){} // RVA: 0x25482E0
    public void set_customPreferredMaximumResolution(){} // RVA: 0x25482F0
    public void IsModified(){} // RVA: 0x2548320
    public void BitRateInBitsPerSecond(){} // RVA: 0x2547DE0
    public void HasChanged(){} // RVA: 0x2548190
    public void ClearChanges(){} // RVA: 0x25481B0
    public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0xB43310
    public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0xB43310
    public void .ctor(){} // RVA: 0x2548360
}

public class OptionsWebGL : PlatformOptions
{
    public object _changed;
    public object externalLibrary;
    public object useTextureMips;
    public object _previousAudioMode;
    public object _audioMode;

    // ── Methods ──
    public void get_previousAudioMode(){} // RVA: 0x1AE5AC0
    public void get_audioMode(){} // RVA: 0xB9E080
    public void set_audioMode(){} // RVA: 0x25483C0
    public void get_IsUsingAudioCapture(){} // RVA: 0x2547CE0
    public void IsModified(){} // RVA: 0x25483E0
    public void HasChanged(){} // RVA: 0x2548410
    public void ClearChanges(){} // RVA: 0x25481B0
    public void GetKeyServerAuthToken(){} // RVA: 0xDAC980
    public void GetOverrideDecryptionKey(){} // RVA: 0xDAC980
    public void .ctor(){} // RVA: 0x2548420
}

public class OptionsWindows : PlatformOptions
{
    public object videoApi;
    public object useHardwareDecoding;
    public object useRendererSync;
    public object useTextureMips;
    public object use10BitTextures;
    public object hintAlphaChannel;
    public object useLowLatency;
    public object useCustomMovParser;
    public object useHapNotchLC;
    public object useStereoDetection;
    public object useTextTrackSupport;
    public object useFacebookAudio360Support;
    public object useAudioDelay;
    public object forceAudioOutputDeviceName;
    public object preferredFilters;
    public object _audioMode;
    public object audio360ChannelMode;
    public object startWithHighestBitrate;
    public object useLowLiveLatency;
    public object parallelFrameCount;
    public object prerollFrameCount;
    public object useUnityAudio;
    public object enableAudio360;

    // ── Methods ──
    public void IsModified(){} // RVA: 0x25479C0
    public void StartWithHighestBandwidth(){} // RVA: 0xBFDA40
    public void get_IsUsingAudioCapture(){} // RVA: 0x2547AA0
    public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0xB43310
    public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x2547AB0
    public void .ctor(){} // RVA: 0x2547AE0
}

public class OptionsWindowsUWP : PlatformOptions
{
    public object useHardwareDecoding;
    public object useRendererSync;
    public object useTextureMips;
    public object use10BitTextures;
    public object hintOutput10Bit;
    public object useLowLatency;
    public object videoApi;
    public object _audioMode;
    public object audio360ChannelMode;
    public object startWithHighestBitrate;
    public object useLowLiveLatency;

    // ── Methods ──
    public void IsModified(){} // RVA: 0x2547C30
    public void StartWithHighestBandwidth(){} // RVA: 0xB78D60
    public void get_IsUsingAudioCapture(){} // RVA: 0x2547C90
    public void .ctor(){} // RVA: 0x2547CA0
}

public class OutputEventArgs : ValueType
{
    public object packet;
    public object timestampMicrosecond;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x899C90
}

public class OutputEventArgs : ValueType
{
    public object packet;
    public object timestampMicrosecond;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x260A0
}

public class OutputEventArgs : ValueType
{
    public object packet;
    public object timestampMicrosecond;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x260A0
}

public class OutputEventArgs : ValueType
{
    public object packet;
    public object timestampMicrosecond;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x260A0
}

public class OutputEventArgs : ValueType
{
    public object packet;
    public object timestampMicrosecond;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x260A0
}

public class OutputEventArgs : ValueType
{
    public object packet;
    public object timestampMicrosecond;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x260A0
}

public class OutputEventArgs : ValueType
{
    public object packet;
    public object timestampMicrosecond;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x260A0
}
