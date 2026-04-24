// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 46
// Methods: 447

public class ONSPAudioSource : MonoBehaviour
{
    public object gain; // 0x33C2DF30
    public object far; // 0x33C2DF30
    public object enableRfl; // 0x33C2DF30

    // ── Original Methods ──
    public void UpdateSpatializer(){} // RVA: 0x7ffaa9dfb8f0
    public void Start(){} // RVA: 0x7ffaa9dfbcf0
    public void IsInvoking(){} // RVA: 0x7ffaa9dfc030
    public void Reset(){} // RVA: 0x7ffaa9dfc1d0
    public void Invoke(){} // RVA: 0x7ffaa9dfc3f0
    public void Awake(){} // RVA: 0x7ffaa9dfc4d0
    public void IsSetup(){} // RVA: 0x7ffaa8b0edb0
    public void set_ValidExpressions(){} // RVA: 0x7ffaa8a209e0
    public void OnDrawGizmos(){} // RVA: 0x7ffaa9dfc4e0
    public void get_allowOffhandGrab(){} // RVA: 0x7ffaa8a209d0
    public void OnBeforeSceneLoadRuntimeMethod(){} // RVA: 0x7ffaa9dfd330
    public void get_AllowTransparency(){} // RVA: 0x7ffaa8a974e0
    public void get_preferredPeakBitRate(){} // RVA: 0x7ffaa9672970
    public void StopCoroutine(){} // RVA: 0x7ffaa8b0edb0
    public void OnTriggerEnter(){} // RVA: 0x7ffaa9dfd3c0
    public void StopAllCoroutines(){} // RVA: 0x7ffaa8a209e0
    public void get_useGUILayout(){} // RVA: 0x7ffaa9672970
    public void set_useGUILayout(){} // RVA: 0x7ffaa9dfd3f0
    public void .ctor(){} // RVA: 0x7ffaa9dfd470
    public void Internal_IsInvokingAll(){} // RVA: 0x7ffaa9dfd4d0
    public void InvokeDelayed(){} // RVA: 0x7ffaa9dfd500
    public void get_scale(){} // RVA: 0x7ffaa8e22440
    public void LateUpdate(){} // RVA: 0x7ffaa8932310
    public void OnDestroy(){} // RVA: 0x7ffaa9dfd530
    public void StartCoroutineManaged2(){} // RVA: 0x7ffaa9dfd6d0
    public void set_Color(){} // RVA: 0x7ffaa96574d0
    public void get_Progress(){} // RVA: 0x7ffaa9144a40
    public void OnCancellationTokenCreated(){} // RVA: 0x7ffaa9dfdad0
    public void OnCollisionStay(){} // RVA: 0x7ffaa9dfdb00
    public void set_AllowTransparency(){} // RVA: 0x7ffaa8a974f0
    // ── Binary Analysis Named ──
    public void GetCurrentHealth(){} // RVA: 0x7ffaa8a9ff50
    public void GetMaxDampTime(){} // RVA: 0x7ffaa89fc630
    public void DoSetSpatializerFloat(){} // RVA: 0x7ffaa9dfd700
}

public class OVRCameraRig : MonoBehaviour
{
    public object _centerEyeAnchor; // 0x33C05A50, was: <centerEyeAnchor>k__BackingFie
    public object _rightHandAnchor; // 0x33C05A50, was: <rightHandAnchor>k__BackingFie
    public object _trackerAnchor; // 0x33C05A50, was: <trackerAnchor>k__BackingField
    public object usePerEyeCameras; // 0x33C05A50
    public object _skipUpdate; // 0x33C05A50
    public object leftEyeAnchorName; // 0x33C05A50
    public object leftHandAnchorName; // 0x33C05A50
    public object rightControllerAnchorName; // 0x33C05A50
    public object _rightEyeCamera; // 0x33C05A50
    public object TrackingSpaceChanged; // 0x33BF55F0
    public object leftEyeCamera; // 0x17000002
    public object rightEyeCamera; // 0x17000003
    public object trackingSpace; // 0x17000004
    public object leftEyeAnchor; // 0x17000005
    public object centerEyeAnchor; // 0x17000006
    public object rightEyeAnchor; // 0x17000007
    public object leftHandAnchor; // 0x17000008

    // ── Original Methods ──
    public void get_leftEyeCamera(){} // RVA: 0x7ffaae2ba920
    public void get_rightEyeCamera(){} // RVA: 0x7ffaae2ba940
    public void get_trackingSpace(){} // RVA: 0x7ffaa89600c0
    public void set_trackingSpace(){} // RVA: 0x7ffaa89600d0
    public void get_leftEyeAnchor(){} // RVA: 0x7ffaa8960130
    public void set_leftEyeAnchor(){} // RVA: 0x7ffaa8933e90
    public void get_centerEyeAnchor(){} // RVA: 0x7ffaa8bfcc80
    public void set_centerEyeAnchor(){} // RVA: 0x7ffaa8960890
    public void get_rightEyeAnchor(){} // RVA: 0x7ffaa8bf45b0
    public void set_rightEyeAnchor(){} // RVA: 0x7ffaa8bf45c0
    public void get_leftHandAnchor(){} // RVA: 0x7ffaa89af740
    public void set_leftHandAnchor(){} // RVA: 0x7ffaa895a200
    public void get_rightHandAnchor(){} // RVA: 0x7ffaa89ad730
    public void set_rightHandAnchor(){} // RVA: 0x7ffaa89ad740
    public void get_leftControllerAnchor(){} // RVA: 0x7ffaa89d30e0
    public void set_leftControllerAnchor(){} // RVA: 0x7ffaa8a8a4d0
    public void get_rightControllerAnchor(){} // RVA: 0x7ffaa89fa500
    public void set_rightControllerAnchor(){} // RVA: 0x7ffaa89fa510
    public void get_trackerAnchor(){} // RVA: 0x7ffaa89d0370
    public void set_trackerAnchor(){} // RVA: 0x7ffaa89d0380
    public void add_UpdatedAnchors(){} // RVA: 0x7ffaae2ba960
    public void remove_UpdatedAnchors(){} // RVA: 0x7ffaae2baa60
    public void add_TrackingSpaceChanged(){} // RVA: 0x7ffaae2bab60
    public void remove_TrackingSpaceChanged(){} // RVA: 0x7ffaae2bac60
    public void Awake(){} // RVA: 0x7ffaae2bad60
    public void Start(){} // RVA: 0x7ffaae2bad80
    public void FixedUpdate(){} // RVA: 0x7ffaae2bae70
    public void Update(){} // RVA: 0x7ffaae2baea0
    public void OnDestroy(){} // RVA: 0x7ffaae2baed0
    public void UpdateAnchors(){} // RVA: 0x7ffaae2bafa0
    public void OnBeforeRenderCallback(){} // RVA: 0x7ffaae2bd040
    public void RaiseUpdatedAnchorsEvent(){} // RVA: 0x7ffaae2bd330
    public void EnsureGameObjectIntegrity(){} // RVA: 0x7ffaae2bd350
    public void ConfigureAnchor(){} // RVA: 0x7ffaae2be2b0
    public void ComputeTrackReferenceMatrix(){} // RVA: 0x7ffaae2be950
    public void .ctor(){} // RVA: 0x7ffaae2bee30
    // ── Binary Analysis Named ──
    public void CheckForTrackingSpaceChangesAndRaiseEvent(){} // RVA: 0x7ffaae2bd0f0
}

public class OVRControllerTest : MonoBehaviour
{
    public object data; // 0x33C07D60

    // ── Original Methods ──
    public void Start(){} // RVA: 0x7ffaae350480
    public void Update(){} // RVA: 0x7ffaae352a90
    public void .ctor(){} // RVA: 0x7ffaa8932d50
    public void .cctor(){} // RVA: 0x7ffaae353840
}

public class OVRGLTFLoader : Object
{
    public object m_binaryChunk; // 0x33B04D20
    public object m_Shader; // 0x33B04D20
    public object m_TextureMipmapBias; // 0x33B04D20
    public object GLTFToUnitySpace_Rotation; // 0x33B04D20
    public object get_SampleRateHz; // 0xB41F4A50

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaae2ce210
    public void .ctor(){} // RVA: 0x7ffaae2ce210
    public void LoadGLB(){} // RVA: 0x7ffaae2ce2f0
    public void DetectTextureQuality(){} // RVA: 0x7ffaae2ceda0
    public void ApplyTextureQuality(){} // RVA: 0x7ffaae2cef20
    public void ValidateGLB(){} // RVA: 0x7ffaae2cf0a0
    public void ReadChunk(){} // RVA: 0x7ffaae2cf300
    public void ValidateChunk(){} // RVA: 0x7ffaae2cf3d0
    public void LoadGLTF(){} // RVA: 0x7ffaae2cf550
    public void ProcessNode(){} // RVA: 0x7ffaae2cfc90
    public void ProcessMesh(){} // RVA: 0x7ffaae2d0e70
    public void FlipTraingleIndices(){} // RVA: 0x7ffaae2d2ca0
    public void ProcessSkin(){} // RVA: 0x7ffaae2d2d30
    public void ProcessMaterial(){} // RVA: 0x7ffaae2d3470
    public void ProcessTexture(){} // RVA: 0x7ffaae2d3760
    public void TranscodeTexture(){} // RVA: 0x7ffaae2d3d90
    public void CreateUnityMaterial(){} // RVA: 0x7ffaae2d3e10
    public void ProcessAnimations(){} // RVA: 0x7ffaae2d4210
    public void .cctor(){} // RVA: 0x7ffaae2d4ac0
    // ── Binary Analysis Named ──
    public void SetModelShader(){} // RVA: 0x7ffaa89ad740
    public void SetModelAlphaBlendShader(){} // RVA: 0x7ffaa8a8a4d0
    public void SetTextureQualityFiltering(){} // RVA: 0x7ffaa905bde0
    public void SetMipMapBias(){} // RVA: 0x7ffaae2ced70
    public void GetInputNodeType(){} // RVA: 0x7ffaae2d4010
}

public class OVRGrabber : MonoBehaviour
{
    public object m_parentHeldObject; // 0x33CF8630
    public object m_grabVolumes; // 0x33CF8630
    public object m_player; // 0x33CF8630
    public object m_lastRot; // 0x33CF8630
    public object m_prevFlex; // 0x33CF8630
    public object m_grabbedObjectRotOff; // 0x33CF8630

    // ── Original Methods ──
    public void get_grabbedObject(){} // RVA: 0x7ffaa8f75d20
    public void ForceRelease(){} // RVA: 0x7ffaae35c790
    public void Awake(){} // RVA: 0x7ffaae35c970
    public void Start(){} // RVA: 0x7ffaae35cc90
    public void Update(){} // RVA: 0x7ffaae35d000
    public void OnUpdatedAnchors(){} // RVA: 0x7ffaae35d020
    public void OnDestroy(){} // RVA: 0x7ffaae35d640
    public void OnTriggerEnter(){} // RVA: 0x7ffaae35d720
    public void OnTriggerExit(){} // RVA: 0x7ffaae35d910
    public void GrabBegin(){} // RVA: 0x7ffaae35db90
    public void MoveGrabbedObject(){} // RVA: 0x7ffaae35ecf0
    public void GrabEnd(){} // RVA: 0x7ffaae35f3c0
    public void GrabbableRelease(){} // RVA: 0x7ffaae35fa10
    public void GrabVolumeEnable(){} // RVA: 0x7ffaae35fb50
    public void OffhandGrabbed(){} // RVA: 0x7ffaae35fc70
    public void .ctor(){} // RVA: 0x7ffaae360090
    public void <Awake>b__23_0(){} // RVA: 0x7ffaae3601a0
    // ── Binary Analysis Named ──
    public void CheckForGrabOrRelease(){} // RVA: 0x7ffaae35db40
    public void SetPlayerIgnoreCollision(){} // RVA: 0x7ffaae35fe40
}

public class OVRHand : MonoBehaviour
{
    public object _pointerPoseGO; // 0x33AEEAC0
    public object _isDataHighConfidence; // 0x33AEEAC0, was: <IsDataHighConfidence>k__Backi
    public object _isPointerPoseValid; // 0x33AEEAC0, was: <IsPointerPoseValid>k__Backing
    public object _handConfidence; // 0x33AEEAC0, was: <HandConfidence>k__BackingFiel
    public object RootPose; // 0x824276A0
    public object PinchStrength; // 0x824276A0

    // ── Original Methods ──
    public void get_IsDataValid(){} // RVA: 0x7ffaa9c06d20
    public void set_IsDataValid(){} // RVA: 0x7ffaa9c096e0
    public void get_IsDataHighConfidence(){} // RVA: 0x7ffaabf46960
    public void set_IsDataHighConfidence(){} // RVA: 0x7ffaabf46970
    public void get_IsTracked(){} // RVA: 0x7ffaae360f40
    public void set_IsTracked(){} // RVA: 0x7ffaae360f50
    public void get_IsSystemGestureInProgress(){} // RVA: 0x7ffaae360f60
    public void set_IsSystemGestureInProgress(){} // RVA: 0x7ffaae360f70
    public void get_IsPointerPoseValid(){} // RVA: 0x7ffaae360f80
    public void set_IsPointerPoseValid(){} // RVA: 0x7ffaae360f90
    public void get_PointerPose(){} // RVA: 0x7ffaa899d0b0
    public void set_PointerPose(){} // RVA: 0x7ffaa899d0c0
    public void get_HandScale(){} // RVA: 0x7ffaae2ffd30
    public void set_HandScale(){} // RVA: 0x7ffaae360fa0
    public void get_HandConfidence(){} // RVA: 0x7ffaaa1db140
    public void set_HandConfidence(){} // RVA: 0x7ffaae360fb0
    public void get_IsDominantHand(){} // RVA: 0x7ffaa9757e70
    public void set_IsDominantHand(){} // RVA: 0x7ffaa975cbc0
    public void Awake(){} // RVA: 0x7ffaae360fc0
    public void Update(){} // RVA: 0x7ffaae361200
    public void FixedUpdate(){} // RVA: 0x7ffaae361210
    public void OVRSkeleton.IOVRSkeletonDataProvider.GetSkeletonType(){} // RVA: 0x7ffaae3616e0
    public void OVRSkeleton.IOVRSkeletonDataProvider.GetSkeletonPoseData(){} // RVA: 0x7ffaae361700
    public void OVRSkeletonRenderer.IOVRSkeletonRendererDataProvider.GetSkeletonRendererData(){} // RVA: 0x7ffaae3617d0
    public void OVRMesh.IOVRMeshDataProvider.GetMeshType(){} // RVA: 0x7ffaae3616e0
    public void OVRMeshRenderer.IOVRMeshRendererDataProvider.GetMeshRendererData(){} // RVA: 0x7ffaae361820
    public void .ctor(){} // RVA: 0x7ffaae361880
    public void OVRSkeleton.IOVRSkeletonDataProvider.get_enabled(){} // RVA: 0x7ffaa8998de0
    // ── Binary Analysis Named ──
    public void GetHandState(){} // RVA: 0x7ffaae361280
    public void GetFingerIsPinching(){} // RVA: 0x7ffaae361610
    public void GetFingerPinchStrength(){} // RVA: 0x7ffaae361640
    public void GetFingerConfidence(){} // RVA: 0x7ffaae361690
}

public class OVRHapticsClip : Object
{
    public object _samples; // 0x33AAD150, was: <Samples>k__BackingField
    public object Count; // 0x17000028

    // ── Original Methods ──
    public void get_Count(){} // RVA: 0x7ffaa897f5c0
    public void set_Count(){} // RVA: 0x7ffaa89350c0
    public void get_Capacity(){} // RVA: 0x7ffaa8e046c0
    public void set_Capacity(){} // RVA: 0x7ffaa8e03640
    public void get_Samples(){} // RVA: 0x7ffaa89357c0
    public void set_Samples(){} // RVA: 0x7ffaa8998e80
    public void .ctor(){} // RVA: 0x7ffaae2d7cb0
    public void .ctor(){} // RVA: 0x7ffaae2d7cb0
    public void .ctor(){} // RVA: 0x7ffaae2d7cb0
    public void .ctor(){} // RVA: 0x7ffaae2d7cb0
    public void .ctor(){} // RVA: 0x7ffaae2d7cb0
    public void WriteSample(){} // RVA: 0x7ffaae2d7e80
    public void Reset(){} // RVA: 0x7ffaa90c95d0
    public void InitializeFromAudioFloatTrack(){} // RVA: 0x7ffaae2d7f40
}

public class OVRLipSyncContext : LifecycleComponent_82E3
{
    public object audioLoopback; // 0x33C9FE20
    public object debugVisemesKey; // 0x33C9FE20
    public object _flag; // 0x33C9FE20, was: ÏÌÍÏÍÍÎÍÎÌÌÎÌÏÏÌÎÌÍÏÎÌÌ
    public object laughterScore; // 0x33C9FE20

    // ── Original Methods ──
    public void ComputeKeyDownInt(){} // RVA: 0x7ffaa94ad1e0
    public void ToggleAudioProcessing(){} // RVA: 0x7ffaa94ad5a0
    public void .ctor(){} // RVA: 0x7ffaa94ad810
    public void Initialize(){} // RVA: 0x7ffaa94ad840
    public void Update(){} // RVA: 0x7ffaa94adb20
    public void UpdateLipSyncIfEnabled(){} // RVA: 0x7ffaa94adb40
    public void ProcessAudioInput(){} // RVA: 0x7ffaa94adb50
    public void OnAudioFilterRead(){} // RVA: 0x7ffaa94adb40
    public void UpdateLaughterScore(){} // RVA: 0x7ffaa94adb20
    public void Start(){} // RVA: 0x7ffaa8932310
    public void ZeroAudioBuffer(){} // RVA: 0x7ffaa94adec0
    public void ScaleAudioBufferByLaughterScore(){} // RVA: 0x7ffaa94adf10
    public void ProcessLipSyncEvent(){} // RVA: 0x7ffaa94adf70
    public void ScaleAudioBufferByFlagValue(){} // RVA: 0x7ffaa94ae250
    // ── Binary Analysis Named ──
    public void DoWait(){} // RVA: 0x7ffaa94ae0e0
    public void DoWait(){} // RVA: 0x7ffaa94ae0e0
    public void DoGetKeyDownInt(){} // RVA: 0x7ffaa94ae2b0
    // ── Obfuscated Methods ──
    public void m_761(){} // RVA: 0x7ffaa94adcc0
}

public class OVRLipSyncContextCanned : LifecycleComponent_82E3
{
    // ── Original Methods ──
    public void ComputeisPlaying(){} // RVA: 0x7ffaa94b19c0
    public void AccessisPlaying(){} // RVA: 0x7ffaa94b1bb0
    public void .ctor(){} // RVA: 0x7ffaa94b1d90
    public void Initialize(){} // RVA: 0x7ffaa94b1da0
    public void Update(){} // RVA: 0x7ffaa94b2170
    public void UpdateAudioSourcePlayback(){} // RVA: 0x7ffaa94b2350
    public void UpdateTimeAndPlaybackState(){} // RVA: 0x7ffaa94b2920
    // ── Binary Analysis Named ──
    public void GetisPlaying(){} // RVA: 0x7ffaa94b1f90
    // ── Obfuscated Methods ──
    public void m_8AA(){} // RVA: 0x7ffaa94b2540
    public void m_60E(){} // RVA: 0x7ffaa94b2730
}

public class OVRNetwork : Object
{
    public object FrameHeaderMagicIdentifier; // 0x33C04DD0
    public object 8؏f; // 0x6734E2E3

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8932310
}

public class OVRProgressIndicator : MonoBehaviour
{
    public object m_allowOffhandGrab; // 0x333909A0

    // ── Original Methods ──
    public void Awake(){} // RVA: 0x7ffaae371300
    public void Update(){} // RVA: 0x7ffaae371360
    public void .ctor(){} // RVA: 0x7ffaae371410
}

public class OVRRuntimeController : MonoBehaviour
{
    public object m_supportAnimation; // 0x33C7C5B0
    public object rightControllerModelPath; // 0x33C7C5B0
    public object m_hasInputFocus; // 0x33C7C5B0
    public object m_animationNodes; // 0x33C7C5B0
    public object System.Collections.Generic; // 0xB412C230

    // ── Original Methods ──
    public void Start(){} // RVA: 0x7ffaae3740b0
    public void Update(){} // RVA: 0x7ffaae3744d0
    public void IsModelSupported(){} // RVA: 0x7ffaae374690
    public void LoadControllerModel(){} // RVA: 0x7ffaae374820
    public void UpdateControllerModel(){} // RVA: 0x7ffaae374dd0
    public void UpdateControllerAnimation(){} // RVA: 0x7ffaae374e70
    public void InputFocusAquired(){} // RVA: 0x7ffaae3752c0
    public void InputFocusLost(){} // RVA: 0x7ffaae3752d0
    public void .ctor(){} // RVA: 0x7ffaae3752e0
    public void .cctor(){} // RVA: 0x7ffaae375330
}

public class OVRSceneManager : MonoBehaviour
{
    public object PrefabOverrides; // 0x33C9D450
    public object SceneModelLoadedSuccessfully; // 0x33C9D450
    public object UnexpectedErrorWithSceneCapture; // 0x33C9D450
    public object _wallOrderComparer; // 0x33C9D450
    public object _sceneCaptureRequestId; // 0x33C9D450
    public object _cameraRig; // 0x33C9D450

    // ── Original Methods ──
    public void get_Verbose(){} // RVA: 0x7ffaae340640
    public void Awake(){} // RVA: 0x7ffaae340690
    public void OnTrackingSpaceChanged(){} // RVA: 0x7ffaae340880
    public void Update(){} // RVA: 0x7ffaae340890
    public void UpdateAllSceneAnchors(){} // RVA: 0x7ffaae340a20
    public void UpdateSomeSceneAnchors(){} // RVA: 0x7ffaae340890
    public void LoadSceneModel(){} // RVA: 0x7ffaae340ba0
    public void RequestSceneCapture(){} // RVA: 0x7ffaae340bc0
    public void OnEnable(){} // RVA: 0x7ffaae340c30
    public void OnDisable(){} // RVA: 0x7ffaae341280
    public void LoadSpatialEntities(){} // RVA: 0x7ffaae3419f0
    public void EnableComponentIfNecessary(){} // RVA: 0x7ffaae342550
    public void OVRManager_SceneCaptureComplete(){} // RVA: 0x7ffaae342a80
    public void IsComponentEnabled(){} // RVA: 0x7ffaae342c10
    public void InstantiateSceneAnchor(){} // RVA: 0x7ffaae342c90
    public void OVRManager_SpaceQueryComplete(){} // RVA: 0x7ffaae3435b0
    public void OVRManager_SpaceSetComponentStatusComplete(){} // RVA: 0x7ffaae343a00
    public void ProcessQueryResult(){} // RVA: 0x7ffaae343b40
    public void .ctor(){} // RVA: 0x7ffaae344a30
    public void <Awake>b__26_0(){} // RVA: 0x7ffaae344e30
    public void <Awake>g__TryGetUuid|26_1(){} // RVA: 0x7ffaae344ec0
    // ── Binary Analysis Named ──
    public void CheckForCompletion(){} // RVA: 0x7ffaae343940
}

public class OVRSceneModelLoader : MonoBehaviour
{
    // ── Original Methods ──
    public void get_SceneManager(){} // RVA: 0x7ffaa89600c0
    public void set_SceneManager(){} // RVA: 0x7ffaa89600d0
    public void Start(){} // RVA: 0x7ffaae345ff0
    public void AttemptToLoadSceneModel(){} // RVA: 0x7ffaae346490
    public void OnStart(){} // RVA: 0x7ffaae346530
    public void OnSceneModelLoadedSuccessfully(){} // RVA: 0x7ffaae346740
    public void OnNoSceneModelToLoad(){} // RVA: 0x7ffaae3468a0
    public void OnSceneCaptureReturnedWithoutError(){} // RVA: 0x7ffaae346a70
    public void OnUnexpectedErrorWithSceneCapture(){} // RVA: 0x7ffaae346bf0
    public void .ctor(){} // RVA: 0x7ffaa8932d50
}

public class OVRScreenFade : MonoBehaviour
{
    public object fadeColor; // 0x33C05410
    public object explicitFadeAlpha; // 0x33C05410
    public object fadeRenderer; // 0x33C05410
    public object isFading; // 0x33C05410
    public object instance; // 0x1700015F
    public object currentAlpha; // 0x17000160

    // ── Original Methods ──
    public void get_instance(){} // RVA: 0x7ffaae3764f0
    public void set_instance(){} // RVA: 0x7ffaae376530
    public void get_currentAlpha(){} // RVA: 0x7ffaae3765d0
    public void Start(){} // RVA: 0x7ffaae3766b0
    public void FadeIn(){} // RVA: 0x7ffaae376f30
    public void FadeOut(){} // RVA: 0x7ffaae376f60
    public void OnLevelFinishedLoading(){} // RVA: 0x7ffaae376f30
    public void OnEnable(){} // RVA: 0x7ffaae376f90
    public void OnDestroy(){} // RVA: 0x7ffaae376fa0
    public void Fade(){} // RVA: 0x7ffaae377250
    public void .ctor(){} // RVA: 0x7ffaae377630
    // ── Binary Analysis Named ──
    public void SetUIFade(){} // RVA: 0x7ffaae377200
    public void SetExplicitFade(){} // RVA: 0x7ffaae377240
    public void SetMaterialAlpha(){} // RVA: 0x7ffaae377310
}

public class OVRSpace : ValueType
{
    // ── Original Methods ──
    public void get_Handle(){} // RVA: 0x7ffaa950bda0
    public void TryGetUuid(){} // RVA: 0x7ffaae348660
    public void get_Valid(){} // RVA: 0x7ffaa95e1360
    public void .ctor(){} // RVA: 0x7ffaa9fe08a0
    public void ToString(){} // RVA: 0x7ffaae348850
    public void Equals(){} // RVA: 0x7ffaae348900
    public void Equals(){} // RVA: 0x7ffaae348900
    public void op_Equality(){} // RVA: 0x7ffaaad0d3c0
    public void op_Inequality(){} // RVA: 0x7ffaae071d60
    public void op_Implicit(){} // RVA: 0x7ffaa9f19100
    public void op_Implicit(){} // RVA: 0x7ffaa9f19100
    // ── Binary Analysis Named ──
    public void GetHashCode(){} // RVA: 0x7ffaae348990
}

public class OVRSpectatorModeDomeTest : MonoBehaviour
{
    public object defaultFov; // 0x33ACD470

    // ── Original Methods ──
    public void Awake(){} // RVA: 0x7ffaa8932310
    public void Start(){} // RVA: 0x7ffaae37fa90
    public void Initialize(){} // RVA: 0x7ffaae37fc40
    public void UpdateDefaultExternalCamera(){} // RVA: 0x7ffaae37fec0
    public void UpdateSpectatorCameraStatus(){} // RVA: 0x7ffaa8932310
    public void SpectatorCameraDomePosition(){} // RVA: 0x7ffaae3804f0
    public void TimerCoroutine(){} // RVA: 0x7ffaae3805f0
    public void Update(){} // RVA: 0x7ffaae380630
    public void OnApplicationPause(){} // RVA: 0x7ffaa8932310
    public void OnApplicationQuit(){} // RVA: 0x7ffaa8932310
    public void .ctor(){} // RVA: 0x7ffaa8932d50
}

public class OVRTouchpadHelper : MonoBehaviour
{
    // ── Original Methods ──
    public void OnDisable(){} // RVA: 0x7ffaa94a6e40
    public void RaiseCancellation(){} // RVA: 0x7ffaa8932310
    public void Awake(){} // RVA: 0x7ffaa8932310
    public void OnDestroy(){} // RVA: 0x7ffaa94a6e90
    public void .ctor(){} // RVA: 0x7ffaa8932d50
    public void Update(){} // RVA: 0x7ffaa94a6ee0
    public void CancelInvoke(){} // RVA: 0x7ffaa94a6f30
    public void Start(){} // RVA: 0x7ffaa94a6f80
    public void ConcurrentStack_FastPushFailed(){} // RVA: 0x7ffaa94a7020
    public void StartCoroutine(){} // RVA: 0x7ffaa94a7030
    public void OnTriggerStay(){} // RVA: 0x7ffaa8932310
    public void StartCoroutine_Auto(){} // RVA: 0x7ffaa94a70d0
}

public class OVRVignette : MonoBehaviour
{
    public object MeshComplexity; // 0x33C4E960
    public object VignetteAspectRatio; // 0x33C4E960
    public object _Camera; // 0x33C4E960
    public object _OpaqueMeshRenderer; // 0x33C4E960
    public object _TransparentMesh; // 0x33C4E960
    public object _ShaderScaleAndOffset0Property; // 0x33C4E960
    public object _TransparentScaleAndOffset1; // 0x33C4E960
    public object _OpaqueVignetteVisible; // 0x33C4E960
    public object `Ǐf; // 0x672CE639

    // ── Original Methods ──
    public void BuildMeshes(){} // RVA: 0x7ffaae382740
    public void BuildMaterials(){} // RVA: 0x7ffaae383520
    public void OnEnable(){} // RVA: 0x7ffaae383ca0
    public void OnDisable(){} // RVA: 0x7ffaae383d40
    public void Awake(){} // RVA: 0x7ffaae383f30
    public void VisibilityTest(){} // RVA: 0x7ffaae384e20
    public void Update(){} // RVA: 0x7ffaae384e60
    public void EnableRenderers(){} // RVA: 0x7ffaae385530
    public void DisableRenderers(){} // RVA: 0x7ffaae385600
    public void OnPreCull(){} // RVA: 0x7ffaae3856c0
    public void OnPostRender(){} // RVA: 0x7ffaae3856d0
    public void OnBeginCameraRendering(){} // RVA: 0x7ffaae3856e0
    public void .ctor(){} // RVA: 0x7ffaae385820
    public void .cctor(){} // RVA: 0x7ffaae385a50
    // ── Binary Analysis Named ──
    public void GetTriangleCount(){} // RVA: 0x7ffaae382700
    public void GetTanFovAndOffsetForStereoEye(){} // RVA: 0x7ffaae384940
    public void GetTanFovAndOffsetForMonoEye(){} // RVA: 0x7ffaae384d00
}

public class ObjectEnumerator : Object
{
    // ── Original Methods ──
    public void get_Key(){} // RVA: 0x7ffab182c850
    public void System.Collections.IDictionaryEnumerator.get_Key(){} // RVA: 0x7ffab182c850
    public void get_Value(){} // RVA: 0x7ffab182c890
    public void System.Collections.IDictionaryEnumerator.get_Value(){} // RVA: 0x7ffab182c8f0
    public void get_Current(){} // RVA: 0x7ffab182c990
    public void System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_Current(){} // RVA: 0x7ffab182ca50
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7ffab182cb50
    public void System.Collections.IDictionaryEnumerator.get_Entry(){} // RVA: 0x7ffab182cc20
    public void Dispose(){} // RVA: 0x7ffab182cd10
    public void MoveNext(){} // RVA: 0x7ffab182cea0
    public void Reset(){} // RVA: 0x7ffaaa1f5b30
    public void .ctor(){} // RVA: 0x7ffaaa1f5b30
}

public class ObjectReaperDelegate : MulticastDelegate
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8990980
    public void Invoke(){} // RVA: 0x7ffaa8990a50
    public void EndInvoke(){} // RVA: 0x7ffaa8933cb0
    // ── Binary Analysis Named ──
    public void BeginInvoke(){} // RVA: 0x7ffaa8990a60
}

public class ObjectSurrogate : Object
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8932310
    // ── Binary Analysis Named ──
    public void GetObjectData(){} // RVA: 0x7ffab1a97ce0
    public void SetObjectData(){} // RVA: 0x7ffab1a985c0
}

public class ObjectValueCollection : Object
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffab182d560
    public void get_Count(){} // RVA: 0x7ffab182d620
    public void get_Item(){} // RVA: 0x7ffab182d670
    public void set_Item(){} // RVA: 0x7ffab182d760
    public void System.Collections.Generic.IReadOnlyList<System.Object>.get_Item(){} // RVA: 0x7ffab182d7a0
    public void System.Collections.Generic.IList<System.Object>.get_Item(){} // RVA: 0x7ffab182d8b0
    public void System.Collections.Generic.IList<System.Object>.set_Item(){} // RVA: 0x7ffab182d9c0
    public void System.Collections.IList.get_Item(){} // RVA: 0x7ffab182da00
    public void System.Collections.IList.set_Item(){} // RVA: 0x7ffab182db10
    public void get_IsReadOnly(){} // RVA: 0x7ffaa8a17850
    public void get_SyncRoot(){} // RVA: 0x7ffab182db50
    public void get_IsSynchronized(){} // RVA: 0x7ffaa8932320
    public void get_IsFixedSize(){} // RVA: 0x7ffaa8a17850
    public void Contains(){} // RVA: 0x7ffab182dc10
    public void Contains(){} // RVA: 0x7ffab182dc10
    public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffab182dcc0
    public void CopyTo(){} // RVA: 0x7ffab182e1a0
    public void CopyTo(){} // RVA: 0x7ffab182e1a0
    public void Add(){} // RVA: 0x7ffab182e440
    public void Add(){} // RVA: 0x7ffab182e440
    public void System.Collections.IList.Add(){} // RVA: 0x7ffab182e480
    public void Clear(){} // RVA: 0x7ffab182e4c0
    public void Remove(){} // RVA: 0x7ffab182e540
    public void Remove(){} // RVA: 0x7ffab182e540
    public void System.Collections.IList.Remove(){} // RVA: 0x7ffab182e580
    public void Insert(){} // RVA: 0x7ffab182e600
    public void Insert(){} // RVA: 0x7ffab182e600
    public void RemoveAt(){} // RVA: 0x7ffab182e640
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffab182e6d0
    public void System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator(){} // RVA: 0x7ffab182e710
    public void IndexOf(){} // RVA: 0x7ffab182e850
    public void IndexOf(){} // RVA: 0x7ffab182e850
    // ── Binary Analysis Named ──
    public void GetEnumerator(){} // RVA: 0x7ffab182e680
}

public class Offset : ValueType
{
    public object Host; // 0x36844030
    public object Query; // 0x36844030
}

public class OffsetAndRule : Object
{
    public object Rule; // 0x34FA2AE0

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaadf24490
}

public class OnChangeEvent : UnityEvent`1
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaaf669780
}

public class OnChangeEvent : UnityEvent`1
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaaf1a8f90
}

public class OnCultureInfoChangedDelegate : MulticastDelegate
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa898db80
    public void Invoke(){} // RVA: 0x7ffaa898dc60
}

public class OnGUIDelegate : MulticastDelegate
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8990980
    public void Invoke(){} // RVA: 0x7ffaa8990a50
    public void EndInvoke(){} // RVA: 0x7ffaa8933cb0
    // ── Binary Analysis Named ──
    public void BeginInvoke(){} // RVA: 0x7ffaa8990a60
}

public class OnScreenDeviceInfo : ValueType
{
    public object device; // 0x343AE550

    // ── Original Methods ──
    public void AddControl(){} // RVA: 0x7ffaaf07c330
    public void RemoveControl(){} // RVA: 0x7ffaaf07c430
    public void Destroy(){} // RVA: 0x7ffaaf07c7c0
}

public class OnStatusChanged : MulticastDelegate
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaaa385980
    public void Invoke(){} // RVA: 0x7ffaa8a8e4e0
}

public class OnStatusChanged : MulticastDelegate
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaaa37faa0
    public void Invoke(){} // RVA: 0x7ffaa926ada0
}

public class OnValidateInput : MulticastDelegate
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaaf1a8d80
    public void Invoke(){} // RVA: 0x7ffaa8a8e4e0
    public void EndInvoke(){} // RVA: 0x7ffaaf1a8f10
    // ── Binary Analysis Named ──
    public void BeginInvoke(){} // RVA: 0x7ffaaf669650
}

public class OnValidateInput : MulticastDelegate
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaaf1a8d80
    public void Invoke(){} // RVA: 0x7ffaa8a8e4e0
    public void EndInvoke(){} // RVA: 0x7ffaaf1a8f10
    // ── Binary Analysis Named ──
    public void BeginInvoke(){} // RVA: 0x7ffaaf1a8e60
}

public class Option : Object
{
    public object _ref; // 0x34983490, was: <ÌÎÍÏÎÍÌÌÎÌÎÎÏÏÍÌÎÍÌÌÎÏÌ>k__Ba

    // ── Original Methods ──
    public void get_DisplayName(){} // RVA: 0x7ffaa9241a40
    public void set_IsEnabled(){} // RVA: 0x7ffaa89add60
    public void .ctor(){} // RVA: 0x7ffab12fe0b0
    public void set_Tooltip(){} // RVA: 0x7ffaaa3384d0
    public void get_OptionText(){} // RVA: 0x7ffaa9241a40
    public void set_Value(){} // RVA: 0x7ffaa89d0380
    public void get_name(){} // RVA: 0x7ffaaa3384d0
    public void get_Tooltip(){} // RVA: 0x7ffaa900aa70
    public void Instantiate(){} // RVA: 0x7ffaa9241a40
    public void set_OptionText(){} // RVA: 0x7ffaa9241210
    public void get_Value(){} // RVA: 0x7ffaa89d0370
    public void set_trackerAnchor(){} // RVA: 0x7ffaa89d0380
    public void get_IsEnabled(){} // RVA: 0x7ffaa89add50
    public void Equals(){} // RVA: 0x7ffaa89add50
    // ── Binary Analysis Named ──
    public void GetMaterial(){} // RVA: 0x7ffaa89add50
}

public class OptionsAndroid : PlatformOptions
{
    public object _customPreferredMaximumResolution; // 0x3682D700
    public object videoApi; // 0x3682D700
    public object audioOutput; // 0x3682D700
    public object forceRtpTCP; // 0x3682D700
    public object startWithHighestBitrate; // 0x3682D700
    public object bufferForPlaybackMs; // 0x3682D700
    public object `Ǐf; // 0x66DE1A7C

    // ── Original Methods ──
    public void get_preferredMaximumResolution(){} // RVA: 0x7ffaa9349010
    public void set_preferredMaximumResolution(){} // RVA: 0x7ffaaa1cab80
    public void get_customPreferredMaximumResolution(){} // RVA: 0x7ffaa8960130
    public void set_customPreferredMaximumResolution(){} // RVA: 0x7ffaaa1cab90
    public void get_preferredPeakBitRate(){} // RVA: 0x7ffaa9672970
    public void set_preferredPeakBitRate(){} // RVA: 0x7ffaaa1cabc0
    public void get_preferredPeakBitRateUnits(){} // RVA: 0x7ffaa950c6d0
    public void set_preferredPeakBitRateUnits(){} // RVA: 0x7ffaaa1cabe0
    public void IsModified(){} // RVA: 0x7ffaaa1cabf0
    public void BitRateInBitsPerSecond(){} // RVA: 0x7ffaaa1ca9c0
    public void StartWithHighestBandwidth(){} // RVA: 0x7ffaa9fc1d50
    public void HasChanged(){} // RVA: 0x7ffaaa1cacd0
    public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7ffaa8932310
    public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7ffaaa1cacf0
    public void .ctor(){} // RVA: 0x7ffaaa1cad10
    // ── Binary Analysis Named ──
    public void GetPreferredPeakBitRateInBitsPerSecond(){} // RVA: 0x7ffaaa1cac90
}

public class OptionsApple : PlatformOptions
{
    public object textureFormat; // 0x3682D540
    public object _flags; // 0x3682D540
    public object _preferredPeakBitRate; // 0x3682D540
    public object _preferredMaximumResolution; // 0x3682D540

    // ── Original Methods ──
    public void get_previousAudioMode(){} // RVA: 0x7ffaa96cc980
    public void get_audioMode(){} // RVA: 0x7ffaa898dcd0
    public void set_audioMode(){} // RVA: 0x7ffaaa1ca8c0
    public void get_flags(){} // RVA: 0x7ffaa950c6d0
    public void set_flags(){} // RVA: 0x7ffaaa1ca8e0
    public void get_preferredPeakBitRate(){} // RVA: 0x7ffaa8af93a0
    public void set_preferredPeakBitRate(){} // RVA: 0x7ffaaa1ca910
    public void get_preferredPeakBitRateUnits(){} // RVA: 0x7ffaa89d30a0
    public void set_preferredPeakBitRateUnits(){} // RVA: 0x7ffaaa1ca930
    public void get_preferredForwardBufferDuration(){} // RVA: 0x7ffaaa1ca940
    public void set_preferredForwardBufferDuration(){} // RVA: 0x7ffaaa1ca950
    public void get_preferredMaximumResolution(){} // RVA: 0x7ffaa8b023d0
    public void set_preferredMaximumResolution(){} // RVA: 0x7ffaaa1ca970
    public void get_customPreferredMaximumResolution(){} // RVA: 0x7ffaaa1ca980
    public void set_customPreferredMaximumResolution(){} // RVA: 0x7ffaaa1ca990
    public void BitRateInBitsPerSecond(){} // RVA: 0x7ffaaa1ca9c0
    public void .ctor(){} // RVA: 0x7ffaaa1caa40
    public void IsModified(){} // RVA: 0x7ffaaa1cab00
    public void HasChanged(){} // RVA: 0x7ffaaa1cab60
    public void ClearChanges(){} // RVA: 0x7ffaaa1cab70
    // ── Binary Analysis Named ──
    public void GetPreferredPeakBitRateInBitsPerSecond(){} // RVA: 0x7ffaaa1caa00
}

public class OptionsWebGL : PlatformOptions
{
    // ── Original Methods ──
    public void IsModified(){} // RVA: 0x7ffaaa1cad90
    public void .ctor(){} // RVA: 0x7ffaaa1cadc0
    // ── Binary Analysis Named ──
    public void GetKeyServerAuthToken(){} // RVA: 0x7ffaa8f22da0
    public void GetOverrideDecryptionKey(){} // RVA: 0x7ffaa8f22da0
}

public class OptionsWindows : PlatformOptions
{
    public object useTextureMips; // 0x3682D1A0
    public object useLowLatency; // 0x3682D1A0
    public object useStereoDetection; // 0x3682D1A0
    public object useAudioDelay; // 0x3682D1A0
    public object forceAudioOutputDeviceName; // 0x3682D1A0
    public object audio360ChannelMode; // 0x3682D1A0
    public object parallelFrameCount; // 0x3682D1A0
    public object enableAudio360; // 0x3682D1A0
    public object MediaFoundation; // 0x8266DEE0
    public object NewestFrame; // 0x8266DC30

    // ── Original Methods ──
    public void IsModified(){} // RVA: 0x7ffaaa1ca5c0
    public void StartWithHighestBandwidth(){} // RVA: 0x7ffaa89ec8e0
    public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7ffaa8932310
    public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7ffaaa1ca6b0
    public void .ctor(){} // RVA: 0x7ffaaa1ca6e0
}

public class OptionsWindowsUWP : PlatformOptions
{
    public object use10BitTextures; // 0x3682D380
    public object videoApi; // 0x3682D380
    public object startWithHighestBitrate; // 0x3682D380
    public object value__; // 0x82694840

    // ── Original Methods ──
    public void IsModified(){} // RVA: 0x7ffaaa1ca840
    public void StartWithHighestBandwidth(){} // RVA: 0x7ffaa8968c20
    public void .ctor(){} // RVA: 0x7ffaaa1ca8a0
}

public class Orbit : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8955d10
}

public class OutPt : Object
{
    public object Next; // 0x34B570A0
    public object 00; // 0x34B70E60

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8932310
}

public class OutRec : Object
{
    public object IsOpen; // 0x34B56F20
    public object BottomPt; // 0x34B56F20
    public object 00; // 0x34B70D70

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8932310
}

public class OutputEventArgs : ValueType
{
}

public class OutputEventArgs : ValueType
{
}

public class OutputParameter : Object
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa95f0a90
}
