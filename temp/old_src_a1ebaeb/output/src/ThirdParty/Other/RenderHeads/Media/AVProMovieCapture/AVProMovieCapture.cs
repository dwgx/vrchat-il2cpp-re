// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.RenderHeads.Media.AVProMovieCapture
// Classes: 29
// Methods: 630

namespace ThirdParty.Other.RenderHeads.Media.AVProMovieCapture
{
    public class Ambisonic : Object
    {
        public object _weightsSN3D; // 0x334C7C70

        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaae431950
        public void BuildWeightsFuMa(){} // RVA: 0x7ffaae431bf0
        public void Factorial(){} // RVA: 0x7ffaae431f80
        public void BuildWeightsSN3D(){} // RVA: 0x7ffaae4322c0
        // ── Binary Analysis Named ──
        public void GetNormalisationWeights(){} // RVA: 0x7ffaae431880
        public void GetCoeffCount(){} // RVA: 0x7ffaae431910
        public void GetChannelOrder(){} // RVA: 0x7ffaae431940
        public void GetNormalisation(){} // RVA: 0x7ffaae431940
        public void GetN(){} // RVA: 0x7ffaae431ec0
        public void GetM(){} // RVA: 0x7ffaae431f00
        public void GetNormalisationSN3D(){} // RVA: 0x7ffaae432090
        public void GetNormalisationSN3D(){} // RVA: 0x7ffaae432090
        public void GetNormalisationN3D(){} // RVA: 0x7ffaae432210
    }

    public class AmbisonicSource : MonoBehaviour
    {
        public object _position; // 0x3389F330
        public object _normalisation; // 0x3389F330
        public object _activeSamples; // 0x3389F330
        public object _capture; // 0x337DC1B0
        public object _filename; // 0x337DC1B0

        // ── Original Methods ──
        public void OnEnable(){} // RVA: 0x7ffaae40c650
        public void OnDisable(){} // RVA: 0x7ffaae40ca80
        public void OnDrawGizmos(){} // RVA: 0x7ffaae40d0a0
        public void LateUpdate(){} // RVA: 0x7ffaae40d3b0
        public void UpdateCoefficients(){} // RVA: 0x7ffaae40d660
        public void OnAudioFilterRead(){} // RVA: 0x7ffaae40da20
        public void FlushBuffers(){} // RVA: 0x7ffaae40e0d0
        public void SendSamplesToSink(){} // RVA: 0x7ffaae40e4f0
        public void .ctor(){} // RVA: 0x7ffaae40e7b0
        // ── Binary Analysis Named ──
        public void Setup(){} // RVA: 0x7ffaae40cd50
        public void SetListenerRelativePosition(){} // RVA: 0x7ffaae40d640
        public void GetFullBufferCount(){} // RVA: 0x7ffaae40e4a0
    }

    public class AmbisonicWavWriter : MonoBehaviour
    {
        public object _format; // 0x337DC1B0
        public object _outSamples; // 0x337DC1B0
        public object _pendingSampleCount; // 0x337DC1B0
        public object Order; // 0x17000001
        public object Format; // 0x17000002

        // ── Original Methods ──
        public void get_Order(){} // RVA: 0x7ffaa8d14570
        public void get_Format(){} // RVA: 0x7ffaa96cc980
        public void AddSource(){} // RVA: 0x7ffaae40e970
        public void RemoveSource(){} // RVA: 0x7ffaae40eb40
        public void OnDisable(){} // RVA: 0x7ffaae40ecc0
        public void ToggleCapturing(){} // RVA: 0x7ffaae40ed80
        public void StartCapture(){} // RVA: 0x7ffaae40edb0
        public void StopCapture(){} // RVA: 0x7ffaae40f4e0
        public void IsCapturing(){} // RVA: 0x7ffaae40f710
        public void LateUpdate(){} // RVA: 0x7ffaae40f730
        public void ProcessSources(){} // RVA: 0x7ffaae40f850
        public void MixSamples(){} // RVA: 0x7ffaae40fb60
        public void FlushWavWriter(){} // RVA: 0x7ffaae40fc80
        public void .ctor(){} // RVA: 0x7ffaae40fcc0
        // ── Binary Analysis Named ──
        public void SetupSource(){} // RVA: 0x7ffaae40ecd0
    }

    public class AudioSourceToWav : MonoBehaviour
    {
        // ── Original Methods ──
        public void OnEnable(){} // RVA: 0x7ffaae40fec0
        public void OnDisable(){} // RVA: 0x7ffaae4100e0
        public void OnAudioFilterRead(){} // RVA: 0x7ffaae410160
        public void .ctor(){} // RVA: 0x7ffaae410190
    }

    public class CameraSelector : MonoBehaviour
    {
        public object _scanHiddenCameras; // 0x33BE4590
        public object _camera; // 0x33BE4590
        public object _cameraCacheFrame; // 0x33BE4590

        // ── Original Methods ──
        public void get_Camera(){} // RVA: 0x7ffaa89af740
        public void set_Camera(){} // RVA: 0x7ffaae410260
        public void get_SelectBy(){} // RVA: 0x7ffaa8aeced0
        public void set_SelectBy(){} // RVA: 0x7ffaae4102d0
        public void get_ScanFrequency(){} // RVA: 0x7ffaa9349010
        public void set_ScanFrequency(){} // RVA: 0x7ffaae4102e0
        public void get_ScanHiddenCameras(){} // RVA: 0x7ffaa8b0edb0
        public void set_ScanHiddenCameras(){} // RVA: 0x7ffaae4102f0
        public void get_SelectTag(){} // RVA: 0x7ffaa8bfcc80
        public void set_SelectTag(){} // RVA: 0x7ffaae410300
        public void get_SelectName(){} // RVA: 0x7ffaa8bf45b0
        public void set_SelectName(){} // RVA: 0x7ffaae410360
        public void Awake(){} // RVA: 0x7ffaae4103c0
        public void Start(){} // RVA: 0x7ffaae4103d0
        public void OnValidate(){} // RVA: 0x7ffaae4103c0
        public void Update(){} // RVA: 0x7ffaae4103e0
        public void OnDestroy(){} // RVA: 0x7ffaae410400
        public void ResetSceneLoading(){} // RVA: 0x7ffaae4104a0
        public void OnSceneLoaded(){} // RVA: 0x7ffaae410590
        public void ScanForCameraChange(){} // RVA: 0x7ffaae4105a0
        public void FindCamera(){} // RVA: 0x7ffaae4107d0
        public void UpdateCameraCache(){} // RVA: 0x7ffaae410b10
        public void FindCameraByHighestDepth(){} // RVA: 0x7ffaae410cb0
        public void FindCameraByTag(){} // RVA: 0x7ffaae410e30
        public void FindCameraByName(){} // RVA: 0x7ffaae410ec0
        public void .ctor(){} // RVA: 0x7ffaae410f80
    }

    public class CaptureAudioFromAudioClip : MonoBehaviour
    {
        public object _videoOffsetInSamples; // 0x33CD1BD0
        public object _lastCommittedSample; // 0x33CD1BD0
        public object _muteAudio; // 0x3370F310

        // ── Original Methods ──
        public void OnEnable(){} // RVA: 0x7ffaae411150
        public void Update(){} // RVA: 0x7ffaae411500
        public void .ctor(){} // RVA: 0x7ffaa8de7a80
        // ── Binary Analysis Named ──
        public void GetAudioSamplesForFrame(){} // RVA: 0x7ffaae411610
    }

    public class CaptureAudioFromAudioListener : UnityAudioCapture
    {
        public object BufferSize; // 0x3370F310
        public object _bufferIndex; // 0x3370F310
        public object _overflowCount; // 0x3370F310

        // ── Original Methods ──
        public void get_Buffer(){} // RVA: 0x7ffaa8bfcc80
        public void get_BufferLength(){} // RVA: 0x7ffaa8fb82b0
        public void get_BufferPtr(){} // RVA: 0x7ffaae411960
        public void get_OverflowCount(){} // RVA: 0x7ffaa99531a0
        public void get_SampleRate(){} // RVA: 0x7ffaae411970
        public void get_ChannelCount(){} // RVA: 0x7ffaa89d30c0
        public void PrepareCapture(){} // RVA: 0x7ffaae4119c0
        public void StartCapture(){} // RVA: 0x7ffaabb2c2c0
        public void StopCapture(){} // RVA: 0x7ffaae411f40
        public void ReadData(){} // RVA: 0x7ffaae4121a0
        public void FlushBuffer(){} // RVA: 0x7ffaae412330
        public void OnAudioFilterRead(){} // RVA: 0x7ffaae412470
        public void .ctor(){} // RVA: 0x7ffaae4127e0
    }

    public class CaptureAudioFromAudioRenderer : UnityAudioCapture
    {
        public object _isRendererRecording; // 0x33BCF290

        // ── Original Methods ──
        public void get_Capture(){} // RVA: 0x7ffaa89600c0
        public void set_Capture(){} // RVA: 0x7ffaa89600d0
        public void get_SampleRate(){} // RVA: 0x7ffaae411970
        public void get_ChannelCount(){} // RVA: 0x7ffaa8d14570
        public void PrepareCapture(){} // RVA: 0x7ffaae412990
        public void DisposeAudioBuffer(){} // RVA: 0x7ffaa8932310
        public void StartCapture(){} // RVA: 0x7ffaae412b80
        public void StopCapture(){} // RVA: 0x7ffaae412df0
        public void FlushBuffer(){} // RVA: 0x7ffaae412e80
        public void Update(){} // RVA: 0x7ffaae412f70
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        // ── Binary Analysis Named ──
        public void GetAudioBufferOfLength(){} // RVA: 0x7ffaae4129b0
    }

    public class CaptureAudioFromWwise : UnityAudioCapture
    {
        // ── Original Methods ──
        public void get_Capture(){} // RVA: 0x7ffaa89600c0
        public void set_Capture(){} // RVA: 0x7ffaa89600d0
        public void Awake(){} // RVA: 0x7ffaae413130
        public void get_SampleRate(){} // RVA: 0x7ffaa8f22da0
        public void get_ChannelCount(){} // RVA: 0x7ffaa8f22da0
        public void PrepareCapture(){} // RVA: 0x7ffaa8932310
        public void FlushBuffer(){} // RVA: 0x7ffaa8932310
        public void StartCapture(){} // RVA: 0x7ffaa8932310
        public void StopCapture(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class CaptureBase : MonoBehaviour
    {
        public object _encoderHintsMacOS; // 0x3357E430
        public object _captureKey; // 0x3357E430
        public object _startTrigger; // 0x3357E430
        public object _stopMode; // 0x3357E430
        public object DefaultVideoCodecPriorityWindows; // 0x3357E430
        public object DefaultAudioCodecPriorityWindows; // 0x3357E430
        public object DefaultAudioCodecPriorityAndroid; // 0x3357E430
        public object DefaultAudioCaptureDevicePriorityIOS; // 0x3357E430
        public object _videoCodecPriorityMacOS; // 0x3357E430
        public object _audioCodecPriorityMacOS; // 0x3357E430
        public object _timelapseScale; // 0x3357E430
        public object _maxVideoSize; // 0x3357E430
        public object _forceVideoCodecIndexIOS; // 0x3357E430
        public object _forceAudioCodecIndexMacOS; // 0x3357E430
        public object _flipVertically; // 0x3357E430
        public object _androidNoCaptureRotation; // 0x3357E430
        public object _unityAudioCapture; // 0x3357E430
        public object _manualAudioChannelCount; // 0x3357E430
        public object DefaultOutputFolderPath; // 0x3357E430
        public object _filenamePrefix; // 0x3357E430
        public object _filenameExtension; // 0x3357E430
        public object _imageSequenceZeroDigits; // 0x3357E430
        public object _imageSequenceFormatIOS; // 0x3357E430
        public object _renderSize; // 0x3357E430
        public object _motionBlurSamples; // 0x3357E430
        public object _allowVSyncDisable; // 0x3357E430
        public object _timelineController; // 0x3357E430
        public object _handle; // 0x3357E430
        public object _targetWidth; // 0x3357E430
        public object _paused; // 0x3357E430
        public object _fileInfo; // 0x3357E430
        public object _selectedAudioCodec; // 0x3357E430
        public object _oldFixedDeltaTime; // 0x3357E430
        public object _queuedStartCapture; // 0x3357E430
        public object _capturePrePauseTotalTime; // 0x3357E430
        public object _freeDiskSpaceMB; // 0x3357E430
        public object _beginFinalFileWritingAction; // 0x3357E430
        public object _activeFilePaths; // 0x3357E430
        public object _isApplicationQuiting; // 0x3357E430
        public object _audioCaptureDeviceAuthorisationStatus; // 0x3357E430
        public object _photoLibraryAuthorisation; // 0x3357E430
        public object OutputTarget; // 0x17000049
        public object OutputFolder; // 0x1700004A
        public object OutputFolderPath; // 0x1700004B
        public object FilenamePrefix; // 0x1700004C
        public object AppendFilenameTimestamp; // 0x1700004D
        public object AllowManualFileExtension; // 0x1700004E
        public object FilenameExtension; // 0x1700004F
        public object NamedPipePath; // 0x17000050
        public object ImageSequenceStartFrame; // 0x17000051
        public object ImageSequenceZeroDigits; // 0x17000052
        public object UseMotionBlur; // 0x17000053
        public object MotionBlurSamples; // 0x17000054
        public object MotionBlurCameras; // 0x17000055
        public object MotionBlur; // 0x17000056
        public object ActiveFilePaths; // 0x17000057
        public object LastFilePath; // 0x17000058
        public object BeginFinalFileWritingAction; // 0x17000059
        public object CompletedFileWritingAction; // 0x1700005A
        public object Stats; // 0x1700005B
        public object CameraRenderResolution; // 0x1700005C
        public object CameraRenderCustomResolution; // 0x1700005D
        public object CameraRenderAntiAliasing; // 0x1700005E
        public object IsRealTime; // 0x1700005F
        public object PersistAcrossSceneLoads; // 0x17000060
        public object AudioCaptureSource; // 0x17000061
        public object ManualAudioSampleRate; // 0x17000062
        public object ManualAudioChannelCount; // 0x17000063
        public object UnityAudioCapture; // 0x17000064
        public object ForceAudioInputDeviceIndex; // 0x17000065
        public object FrameRate; // 0x17000066
        public object StartTrigger; // 0x17000067
        public object StartDelay; // 0x17000068
        public object StartDelaySeconds; // 0x17000069
        public object StopMode; // 0x1700006A
        public object StopAfterFramesElapsed; // 0x1700006B
        public object StopAfterSecondsElapsed; // 0x1700006C
        public object CaptureStats; // 0x1700006D
        public object VideoCodecPriorityWindows; // 0x1700006E
        public object VideoCodecPriorityMacOS; // 0x1700006F
        public object AudioCodecPriorityWindows; // 0x17000070
        public object AudioCodecPriorityMacOS; // 0x17000071

        // ── Original Methods ──
        public void get_OutputTarget(){} // RVA: 0x7ffaaa1db150
        public void set_OutputTarget(){} // RVA: 0x7ffaae432830
        public void get_OutputFolder(){} // RVA: 0x7ffaaba8f7a0
        public void set_OutputFolder(){} // RVA: 0x7ffaae432840
        public void get_OutputFolderPath(){} // RVA: 0x7ffaa8d57210
        public void set_OutputFolderPath(){} // RVA: 0x7ffaa8ecd8e0
        public void get_FilenamePrefix(){} // RVA: 0x7ffaa8f205f0
        public void set_FilenamePrefix(){} // RVA: 0x7ffaa8f20bd0
        public void get_AppendFilenameTimestamp(){} // RVA: 0x7ffaa9bdabb0
        public void set_AppendFilenameTimestamp(){} // RVA: 0x7ffaa9bdabc0
        public void get_AllowManualFileExtension(){} // RVA: 0x7ffaa9fee6b0
        public void set_AllowManualFileExtension(){} // RVA: 0x7ffaa9fee670
        public void get_FilenameExtension(){} // RVA: 0x7ffaa8f76f40
        public void set_FilenameExtension(){} // RVA: 0x7ffaa93fc460
        public void get_NamedPipePath(){} // RVA: 0x7ffaa8de7450
        public void set_NamedPipePath(){} // RVA: 0x7ffaa8de5d60
        public void get_ImageSequenceStartFrame(){} // RVA: 0x7ffaae432850
        public void set_ImageSequenceStartFrame(){} // RVA: 0x7ffaae432860
        public void get_ImageSequenceZeroDigits(){} // RVA: 0x7ffaae2f60a0
        public void set_ImageSequenceZeroDigits(){} // RVA: 0x7ffaae432870
        public void get_UseMotionBlur(){} // RVA: 0x7ffaa9b4da80
        public void set_UseMotionBlur(){} // RVA: 0x7ffaa9b58ef0
        public void get_MotionBlurSamples(){} // RVA: 0x7ffaa9ad6340
        public void set_MotionBlurSamples(){} // RVA: 0x7ffaae4328a0
        public void get_MotionBlurCameras(){} // RVA: 0x7ffaa8f6e840
        public void set_MotionBlurCameras(){} // RVA: 0x7ffaa93ec470
        public void get_MotionBlur(){} // RVA: 0x7ffaa8f77ed0
        public void set_MotionBlur(){} // RVA: 0x7ffaa93f6970
        public void get_ActiveFilePaths(){} // RVA: 0x7ffaae4328d0
        public void get_LastFilePath(){} // RVA: 0x7ffaa8f75d50
        public void get_BeginFinalFileWritingAction(){} // RVA: 0x7ffaa8f7aa00
        public void set_BeginFinalFileWritingAction(){} // RVA: 0x7ffaa8f77dc0
        public void get_CompletedFileWritingAction(){} // RVA: 0x7ffaa8f74940
        public void set_CompletedFileWritingAction(){} // RVA: 0x7ffaa8f77e20
        public void get_Stats(){} // RVA: 0x7ffaa8f70430
        public void get_CameraRenderResolution(){} // RVA: 0x7ffaa96cb0d0
        public void set_CameraRenderResolution(){} // RVA: 0x7ffaae2e8430
        public void get_CameraRenderCustomResolution(){} // RVA: 0x7ffaae432930
        public void set_CameraRenderCustomResolution(){} // RVA: 0x7ffaae432950
        public void get_CameraRenderAntiAliasing(){} // RVA: 0x7ffaae432960
        public void set_CameraRenderAntiAliasing(){} // RVA: 0x7ffaae432970
        public void get_IsRealTime(){} // RVA: 0x7ffaa9fc9180
        public void set_IsRealTime(){} // RVA: 0x7ffaa9fc9190
        public void get_PersistAcrossSceneLoads(){} // RVA: 0x7ffaaa1c25c0
        public void set_PersistAcrossSceneLoads(){} // RVA: 0x7ffaaa1c25d0
        public void get_AudioCaptureSource(){} // RVA: 0x7ffaa90bdfd0
        public void set_AudioCaptureSource(){} // RVA: 0x7ffaa9fb8260
        public void get_ManualAudioSampleRate(){} // RVA: 0x7ffaaa1ddec0
        public void set_ManualAudioSampleRate(){} // RVA: 0x7ffaac1204b0
        public void get_ManualAudioChannelCount(){} // RVA: 0x7ffaaa1dded0
        public void set_ManualAudioChannelCount(){} // RVA: 0x7ffaae432980
        public void get_UnityAudioCapture(){} // RVA: 0x7ffaa8f6dbf0
        public void set_UnityAudioCapture(){} // RVA: 0x7ffaa89b38a0
        public void get_ForceAudioInputDeviceIndex(){} // RVA: 0x7ffaaa23fe60
        public void set_ForceAudioInputDeviceIndex(){} // RVA: 0x7ffaae432990
        public void get_FrameRate(){} // RVA: 0x7ffaa899a540
        public void set_FrameRate(){} // RVA: 0x7ffaae4329a0
        public void get_StartTrigger(){} // RVA: 0x7ffaa89d30c0
        public void set_StartTrigger(){} // RVA: 0x7ffaa89d30d0
        public void get_StartDelay(){} // RVA: 0x7ffaa99531a0
        public void set_StartDelay(){} // RVA: 0x7ffaaa2a7b40
        public void get_StartDelaySeconds(){} // RVA: 0x7ffaa899a460
        public void set_StartDelaySeconds(){} // RVA: 0x7ffaae4329d0
        public void get_StopMode(){} // RVA: 0x7ffaa92bf840
        public void set_StopMode(){} // RVA: 0x7ffaa92bf780
        public void get_StopAfterFramesElapsed(){} // RVA: 0x7ffaa905bf10
        public void set_StopAfterFramesElapsed(){} // RVA: 0x7ffaae4329e0
        public void get_StopAfterSecondsElapsed(){} // RVA: 0x7ffaa895b000
        public void set_StopAfterSecondsElapsed(){} // RVA: 0x7ffaae4329f0
        public void get_CaptureStats(){} // RVA: 0x7ffaa8f70430
        public void get_VideoCodecPriorityWindows(){} // RVA: 0x7ffaa89d0370
        public void set_VideoCodecPriorityWindows(){} // RVA: 0x7ffaae432a00
        public void get_VideoCodecPriorityMacOS(){} // RVA: 0x7ffaa89add50
        public void set_VideoCodecPriorityMacOS(){} // RVA: 0x7ffaae432a60
        public void get_AudioCodecPriorityWindows(){} // RVA: 0x7ffaa8af68f0
        public void set_AudioCodecPriorityWindows(){} // RVA: 0x7ffaae432ac0
        public void get_AudioCodecPriorityMacOS(){} // RVA: 0x7ffaa8d1a3b0
        public void set_AudioCodecPriorityMacOS(){} // RVA: 0x7ffaae432b20
        public void get_TimelapseScale(){} // RVA: 0x7ffaa8c4abd0
        public void set_TimelapseScale(){} // RVA: 0x7ffaa8e5e660
        public void get_FrameUpdate(){} // RVA: 0x7ffaaa2a8330
        public void set_FrameUpdate(){} // RVA: 0x7ffaaa2a8340
        public void get_ResolutionDownScale(){} // RVA: 0x7ffaaa2a7db0
        public void set_ResolutionDownScale(){} // RVA: 0x7ffaaa2a7dc0
        public void get_ResolutionDownscaleCustom(){} // RVA: 0x7ffaae432b80
        public void set_ResolutionDownscaleCustom(){} // RVA: 0x7ffaae1aeb60
        public void get_FlipVertically(){} // RVA: 0x7ffaa9757e70
        public void set_FlipVertically(){} // RVA: 0x7ffaa975cbc0
        public void get_UseWaitForEndOfFrame(){} // RVA: 0x7ffaae432ba0
        public void set_UseWaitForEndOfFrame(){} // RVA: 0x7ffaae432bb0
        public void get_LogCaptureStartStop(){} // RVA: 0x7ffaaa150e80
        public void set_LogCaptureStartStop(){} // RVA: 0x7ffaae432bc0
        public void get_AllowOfflineVSyncDisable(){} // RVA: 0x7ffaae432bd0
        public void set_AllowOfflineVSyncDisable(){} // RVA: 0x7ffaae432be0
        public void get_SupportTextureRecreate(){} // RVA: 0x7ffaae432bf0
        public void set_SupportTextureRecreate(){} // RVA: 0x7ffaae432c00
        public void get_TimelineController(){} // RVA: 0x7ffaa8f70c30
        public void set_TimelineController(){} // RVA: 0x7ffaa93e3af0
        public void get_VideoPlayerController(){} // RVA: 0x7ffaa8d916d0
        public void set_VideoPlayerController(){} // RVA: 0x7ffaa93f45e0
        public void get_SelectedVideoCodec(){} // RVA: 0x7ffaa8f78130
        public void get_SelectedAudioCodec(){} // RVA: 0x7ffaa8f73670
        public void get_SelectedAudioInputDevice(){} // RVA: 0x7ffaa93d5320
        public void get_NativeForceVideoCodecIndex(){} // RVA: 0x7ffaa9325970
        public void set_NativeForceVideoCodecIndex(){} // RVA: 0x7ffaa932b8c0
        public void get_NativeForceAudioCodecIndex(){} // RVA: 0x7ffaa9d66e50
        public void set_NativeForceAudioCodecIndex(){} // RVA: 0x7ffaa9d66790
        public void get_NativeImageSequenceFormat(){} // RVA: 0x7ffaae432c10
        public void set_NativeImageSequenceFormat(){} // RVA: 0x7ffaae432c20
        public void UpdateMediaGallery(){} // RVA: 0x7ffaa8932310
        public void Awake(){} // RVA: 0x7ffaae432f00
        public void .cctor(){} // RVA: 0x7ffaae433530
        public void Start(){} // RVA: 0x7ffaae434050
        public void SelectCodec(){} // RVA: 0x7ffaae434180
        public void SelectVideoCodec(){} // RVA: 0x7ffaae434530
        public void SelectAudioCodec(){} // RVA: 0x7ffaae434710
        public void SelectAudioInputDevice(){} // RVA: 0x7ffaae434880
        public void SelectRecordingResolution(){} // RVA: 0x7ffaae434bb0
        public void OnDestroy(){} // RVA: 0x7ffaae434cc0
        public void FreePendingFileWrites(){} // RVA: 0x7ffaae435030
        public void OnApplicationQuit(){} // RVA: 0x7ffaae4351d0
        public void OnApplicationPause(){} // RVA: 0x7ffaa8932310
        public void EncodeTexture(){} // RVA: 0x7ffaae435230
        public void IsUsingUnityAudioComponent(){} // RVA: 0x7ffaae435340
        public void IsUsingMotionBlur(){} // RVA: 0x7ffaae435440
        public void EncodePointer(){} // RVA: 0x7ffaae435530
        public void IsPrepared(){} // RVA: 0x7ffaae4356c0
        public void IsCapturing(){} // RVA: 0x7ffaae4356d0
        public void IsPaused(){} // RVA: 0x7ffaae4356e0
        public void GenerateTimestampedFilename(){} // RVA: 0x7ffaae435710
        public void GenerateFilePath(){} // RVA: 0x7ffaae435bd0
        public void HasExtension(){} // RVA: 0x7ffaae435c70
        public void GenerateFilename(){} // RVA: 0x7ffaae435dc0
        public void FindOrCreateUnityAudioCapture(){} // RVA: 0x7ffaae4365b0
        public void ValidateEditionFeatures(){} // RVA: 0x7ffaae436c50
        public void PrepareCapture(){} // RVA: 0x7ffaae437380
        public void QueueStartCapture(){} // RVA: 0x7ffaae4390a0
        public void IsStartCaptureQueued(){} // RVA: 0x7ffaae439140
        public void UpdateInjectionOptions(){} // RVA: 0x7ffaae439150
        public void StartCapture(){} // RVA: 0x7ffaae4391e0
        public void PauseCapture(){} // RVA: 0x7ffaae4396a0
        public void ResumeCapture(){} // RVA: 0x7ffaae4397e0
        public void CancelCapture(){} // RVA: 0x7ffaae4398f0
        public void DeleteCapture(){} // RVA: 0x7ffaae439920
        public void UnprepareCapture(){} // RVA: 0x7ffaa8932310
        public void get_LastFileSaved(){} // RVA: 0x7ffaae439a30
        public void set_LastFileSaved(){} // RVA: 0x7ffaae439ae0
        public void RenderThreadEvent(){} // RVA: 0x7ffaae439b30
        public void StopCapture(){} // RVA: 0x7ffaae439ba0
        public void CreatePostOperationsOptions(){} // RVA: 0x7ffaae43a8d0
        public void CanApplyPostOperations(){} // RVA: 0x7ffaae43a9a0
        public void ApplyPostOperations(){} // RVA: 0x7ffaae43ab90
        public void ToggleCapture(){} // RVA: 0x7ffaae43adc0
        public void IsEnoughDiskSpace(){} // RVA: 0x7ffaae43ae00
        public void CanContinue(){} // RVA: 0x7ffaae43ae40
        public void Update(){} // RVA: 0x7ffaae43af60
        public void LateUpdate(){} // RVA: 0x7ffaae43afd0
        public void RemoveCompletedFileWrites(){} // RVA: 0x7ffaae43b300
        public void IsStartDelayComplete(){} // RVA: 0x7ffaae43b4a0
        public void IsStopTimeReached(){} // RVA: 0x7ffaae43b4d0
        public void CanOutputFrame(){} // RVA: 0x7ffaae43b6b0
        public void TickFrameTimer(){} // RVA: 0x7ffaae43b8e0
        public void RenormTimer(){} // RVA: 0x7ffaae43b950
        public void EncodeUnityAudio(){} // RVA: 0x7ffaae43b9a0
        public void EncodeAudio(){} // RVA: 0x7ffaae43baf0
        public void EncodeAudio(){} // RVA: 0x7ffaae43baf0
        public void PreUpdateFrame(){} // RVA: 0x7ffaae43bd50
        public void UpdateFrame(){} // RVA: 0x7ffaae43bf30
        public void ResetFPS(){} // RVA: 0x7ffaae43c270
        public void UpdateFPS(){} // RVA: 0x7ffaae43c2a0
        public void NextMultipleOf4(){} // RVA: 0x7ffaa98e4100
        public void HasUserAuthorisationToCaptureAudio(){} // RVA: 0x7ffaae43c830
        public void RequestUserAuthorisationToCaptureAudioCallback(){} // RVA: 0x7ffaae43c910
        public void RequestAudioCaptureDeviceUserAuthorisation(){} // RVA: 0x7ffaa8f22da0
        public void HasUserAuthorisationToAccessPhotos(){} // RVA: 0x7ffaae43c990
        public void RequestUserAuthorisationToAccessPhotosCallback(){} // RVA: 0x7ffaae43ca70
        public void RequestUserAuthorisationToAccessPhotos(){} // RVA: 0x7ffaa8f22da0
        public void .ctor(){} // RVA: 0x7ffaae43caf0
        // ── Binary Analysis Named ──
        public void GetCurrentPlatform(){} // RVA: 0x7ffaa8f22da0
        public void GetEncoderHints(){} // RVA: 0x7ffaae432c30
        public void SetEncoderHints(){} // RVA: 0x7ffaae432ce0
        public void GetRecordingResolution(){} // RVA: 0x7ffaae434ae0
        public void GetRecordingWidth(){} // RVA: 0x7ffaae4356f0
        public void GetRecordingHeight(){} // RVA: 0x7ffaae435700
        public void GetFolder(){} // RVA: 0x7ffaae4359f0
        public void CheckFreeDiskSpace(){} // RVA: 0x7ffaae43b3e0
        public void GetProgress(){} // RVA: 0x7ffaae43b5c0
        public void GetSecondsPerCaptureFrame(){} // RVA: 0x7ffaae43b680
        public void GetPreviewTexture(){} // RVA: 0x7ffaa8f22da0
        public void GetCameraAntiAliasingLevel(){} // RVA: 0x7ffaae43c330
        public void GetCaptureFileSize(){} // RVA: 0x7ffaae43c5a0
        public void GetResolution(){} // RVA: 0x7ffaae43c6b0
    }

    public class CaptureFromCamera : CaptureBase
    {
        public object _contribCameras; // 0x33C9FA70
        public object _target; // 0x33C9FA70
        public object _targetNativeTexture; // 0x33C9FA70

        // ── Original Methods ──
        public void get_CameraSelector(){} // RVA: 0x7ffaa8f74760
        public void set_CameraSelector(){} // RVA: 0x7ffaa8f6e0b0
        public void get_UseContributingCameras(){} // RVA: 0x7ffaae413190
        public void set_UseContributingCameras(){} // RVA: 0x7ffaae4131a0
        public void RequiresResolve(){} // RVA: 0x7ffaae4135d0
        public void HasCamera(){} // RVA: 0x7ffaae413700
        public void HasContributingCameras(){} // RVA: 0x7ffaae4137d0
        public void UpdateFrame(){} // RVA: 0x7ffaae413800
        public void FinalRenderCapture(){} // RVA: 0x7ffaae413af0
        public void Capture(){} // RVA: 0x7ffaae413b90
        public void RequiresHDR(){} // RVA: 0x7ffaae413c30
        public void UpdateTexture(){} // RVA: 0x7ffaae413e10
        public void UnprepareCapture(){} // RVA: 0x7ffaae414790
        public void CreateResolveTexture(){} // RVA: 0x7ffaae4149c0
        public void PrepareCapture(){} // RVA: 0x7ffaae414e70
        public void OnDestroy(){} // RVA: 0x7ffaae4159f0
        public void .ctor(){} // RVA: 0x7ffaae415ce0
        public void <>n__0(){} // RVA: 0x7ffaae415d40
        // ── Binary Analysis Named ──
        public void SetCamera(){} // RVA: 0x7ffaae413510
        public void SetCamera(){} // RVA: 0x7ffaae413510
        public void GetPreviewTexture(){} // RVA: 0x7ffaa9403680
    }

    public class CaptureFromCamera360 : CaptureBase
    {
        public object _cubemapDepth; // 0x3357E200
        public object _onlyLeftRightRotation; // 0x3357E200
        public object _ipd; // 0x3357E200
        public object _blitMaterial; // 0x3357E200
        public object _finalTarget; // 0x3357E200

        // ── Original Methods ──
        public void get_CameraSelector(){} // RVA: 0x7ffaa8f74760
        public void set_CameraSelector(){} // RVA: 0x7ffaa8f6e0b0
        public void get_CubemapFaceResolution(){} // RVA: 0x7ffaa9f19dc0
        public void set_CubemapFaceResolution(){} // RVA: 0x7ffaa9f197c0
        public void get_CubemapDepthResolution(){} // RVA: 0x7ffaa9f19780
        public void set_CubemapDepthResolution(){} // RVA: 0x7ffaa9f197d0
        public void get_SupportGUI(){} // RVA: 0x7ffaae416450
        public void set_SupportGUI(){} // RVA: 0x7ffaae416460
        public void get_SupportCameraRotation(){} // RVA: 0x7ffaae416470
        public void set_SupportCameraRotation(){} // RVA: 0x7ffaae416480
        public void get_OnlyLeftRightRotation(){} // RVA: 0x7ffaae416490
        public void set_OnlyLeftRightRotation(){} // RVA: 0x7ffaae4164a0
        public void get_Render180Degrees(){} // RVA: 0x7ffaae4164b0
        public void set_Render180Degrees(){} // RVA: 0x7ffaae4164c0
        public void get_StereoRendering(){} // RVA: 0x7ffaa9f1aab0
        public void set_StereoRendering(){} // RVA: 0x7ffaae4164d0
        public void get_IPD(){} // RVA: 0x7ffaae4164e0
        public void set_IPD(){} // RVA: 0x7ffaae4164f0
        public void .ctor(){} // RVA: 0x7ffaae416500
        public void UpdateFrame(){} // RVA: 0x7ffaae4165b0
        public void FinalRenderCapture(){} // RVA: 0x7ffaae416870
        public void Capture(){} // RVA: 0x7ffaae416910
        public void ClearCubemap(){} // RVA: 0x7ffaae416db0
        public void RenderCubemapToEquiRect(){} // RVA: 0x7ffaae417260
        public void UpdateTexture(){} // RVA: 0x7ffaae417420
        public void RenderCameraToCubemap(){} // RVA: 0x7ffaae417c50
        public void AccumulateMotionBlur(){} // RVA: 0x7ffaae419720
        public void PrepareCapture(){} // RVA: 0x7ffaae4198e0
        public void Start(){} // RVA: 0x7ffaae41ab10
        public void OnDestroy(){} // RVA: 0x7ffaae41aed0
        // ── Binary Analysis Named ──
        public void GetCubemapRenderingMethod(){} // RVA: 0x7ffaae416590
        public void SetCamera(){} // RVA: 0x7ffaa93d5a40
        public void GetPreviewTexture(){} // RVA: 0x7ffaae41aad0
    }

    public class CaptureFromCamera360ODS : CaptureBase
    {
        public object _eyeHeight; // 0x3372E540
        public object _leftCameraBot; // 0x3372E540
        public object _final; // 0x3372E540
        public object _propSliceCenter; // 0x3372E540
        public object Setup; // 0x17000026

        // ── Original Methods ──
        public void get_Setup(){} // RVA: 0x7ffaa8f74760
        public void .ctor(){} // RVA: 0x7ffaae41b4b0
        public void Start(){} // RVA: 0x7ffaae41b640
        public void CreateEye(){} // RVA: 0x7ffaae41b870
        public void UpdateFrame(){} // RVA: 0x7ffaae41c970
        public void FinalRenderCapture(){} // RVA: 0x7ffaae41cc60
        public void Capture(){} // RVA: 0x7ffaae41cd00
        public void AccumulateMotionBlur(){} // RVA: 0x7ffaae41cf70
        public void RenderFrame(){} // RVA: 0x7ffaae41d140
        public void PrepareCapture(){} // RVA: 0x7ffaae41de20
        public void DestroyEye(){} // RVA: 0x7ffaae41ef90
        public void OnDestroy(){} // RVA: 0x7ffaae41f1c0
        // ── Binary Analysis Named ──
        public void SetCamera(){} // RVA: 0x7ffaae41b5d0
        public void GetPreviewTexture(){} // RVA: 0x7ffaae41dde0
    }

    public class CaptureFromScreen : CaptureBase
    {
        public object _targetNativePointer; // 0x338962B0

        // ── Original Methods ──
        public void get_CaptureMouseCursor(){} // RVA: 0x7ffaae41f920
        public void set_CaptureMouseCursor(){} // RVA: 0x7ffaae41f930
        public void get_MouseCursor(){} // RVA: 0x7ffaa8f75b00
        public void set_MouseCursor(){} // RVA: 0x7ffaa93e8560
        public void PrepareCapture(){} // RVA: 0x7ffaae41f940
        public void CopyRenderTargetToTexture(){} // RVA: 0x7ffaae41fca0
        public void FreeRenderResources(){} // RVA: 0x7ffaae4202b0
        public void UnprepareCapture(){} // RVA: 0x7ffaae4204d0
        public void FinalRenderCapture(){} // RVA: 0x7ffaae420640
        public void UpdateFrame(){} // RVA: 0x7ffaae4206e0
        public void .ctor(){} // RVA: 0x7ffaae4207a0
    }

    public class CaptureFromTexture : CaptureBase
    {
        public object _resolveTexture; // 0x33BED360

        // ── Original Methods ──
        public void get_IsManualUpdate(){} // RVA: 0x7ffaae41f920
        public void set_IsManualUpdate(){} // RVA: 0x7ffaae41f930
        public void RequiresResolve(){} // RVA: 0x7ffaae4209c0
        public void UpdateSourceTexture(){} // RVA: 0x7ffaae420af0
        public void ShouldCaptureFrame(){} // RVA: 0x7ffaae420b00
        public void HasSourceTextureChanged(){} // RVA: 0x7ffaae420bf0
        public void UpdateFrame(){} // RVA: 0x7ffaae420c10
        public void FinalRenderCapture(){} // RVA: 0x7ffaae420ce0
        public void Capture(){} // RVA: 0x7ffaae420d80
        public void CreateResolveTexture(){} // RVA: 0x7ffaae421190
        public void AccumulateMotionBlur(){} // RVA: 0x7ffaae421540
        public void PrepareCapture(){} // RVA: 0x7ffaae4217d0
        public void UnprepareCapture(){} // RVA: 0x7ffaae421bc0
        public void .ctor(){} // RVA: 0x7ffaae421d90
        // ── Binary Analysis Named ──
        public void SetSourceTexture(){} // RVA: 0x7ffaa93e8560
        public void GetPreviewTexture(){} // RVA: 0x7ffaae421660
    }

    public class CaptureFromWebCamTexture : CaptureFromTexture
    {
        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffaae421ee0
        public void .ctor(){} // RVA: 0x7ffaae421d90
    }

    public class CaptureGUI : MonoBehaviour
    {
        public object _whenRecordingAutoHideUI; // 0x33895E30
        public object CommonFrameRateValues; // 0x33895E30
        public object _audioCodecNames; // 0x33895E30
        public object _audioDeviceNames; // 0x33895E30
        public object _downScaleIndex; // 0x33895E30
        public object _audioPos; // 0x33895E30
        public object _lastFileSize; // 0x33895E30
        public object _lastEncodedFrame; // 0x33895E30
        public object MovieCapture; // 0x17000030
        public object HideUiWhenRecording; // 0x17000031
        public object ShowUI; // 0x17000032
        public object *k;

        // ── Original Methods ──
        public void get_MovieCapture(){} // RVA: 0x7ffaa89600c0
        public void set_MovieCapture(){} // RVA: 0x7ffaa89600d0
        public void get_HideUiWhenRecording(){} // RVA: 0x7ffaa92971f0
        public void set_HideUiWhenRecording(){} // RVA: 0x7ffaa9dde1d0
        public void get_ShowUI(){} // RVA: 0x7ffaa8b0edb0
        public void set_ShowUI(){} // RVA: 0x7ffaa96574d0
        public void Start(){} // RVA: 0x7ffaae421f40
        public void CreateGUI(){} // RVA: 0x7ffaae422020
        public void OnGUI(){} // RVA: 0x7ffaae422c80
        public void MyWindow(){} // RVA: 0x7ffaae423760
        public void GUI_RecordingStatus(){} // RVA: 0x7ffaae425fe0
        public void DrawPauseResumeButtons(){} // RVA: 0x7ffaae427a70
        public void DrawGuiField(){} // RVA: 0x7ffaae428290
        public void StartCapture(){} // RVA: 0x7ffaae428360
        public void StopCapture(){} // RVA: 0x7ffaae428460
        public void CancelCapture(){} // RVA: 0x7ffaae428560
        public void ResumeCapture(){} // RVA: 0x7ffaae428660
        public void PauseCapture(){} // RVA: 0x7ffaae428740
        public void Update(){} // RVA: 0x7ffaae428820
        public void .ctor(){} // RVA: 0x7ffaae428ae0
        public void .cctor(){} // RVA: 0x7ffaae4290a0
    }

    public class CodecManager : Object
    {
        public object _audioCodecs; // 0x33895CB0
        public object VideoCodecs; // 0x1700008D

        // ── Original Methods ──
        public void FindCodec(){} // RVA: 0x7ffaae43d930
        public void EnumerateCodecs(){} // RVA: 0x7ffaae43dc00
        public void get_VideoCodecs(){} // RVA: 0x7ffaae43e620
        public void get_AudioCodecs(){} // RVA: 0x7ffaae43e680
        public void .cctor(){} // RVA: 0x7ffaae43e6e0
        // ── Binary Analysis Named ──
        public void GetCodecCount(){} // RVA: 0x7ffaae43da40
        public void CheckInit(){} // RVA: 0x7ffaae43dab0
        public void GetCodecs(){} // RVA: 0x7ffaae43db60
    }

    public class DeviceManager : Object
    {
        // ── Original Methods ──
        public void FindDevice(){} // RVA: 0x7ffaae43eb50
        public void EnumerateDevices(){} // RVA: 0x7ffaae43ee70
        public void get_AudioInputDevices(){} // RVA: 0x7ffaae43f1d0
        public void .cctor(){} // RVA: 0x7ffaae43f230
        // ── Binary Analysis Named ──
        public void GetDeviceCount(){} // RVA: 0x7ffaae43eca0
        public void CheckInit(){} // RVA: 0x7ffaae43ed50
        public void GetDevices(){} // RVA: 0x7ffaae43ee00
    }

    public class FileWritingHandler : Object
    {
        public object _deleteFile; // 0x333FF090
        public object _postProcessEvent; // 0x333FF090
        public object _updateMediaGallery; // 0x333FF090
        public object applyStereoMode; // 0x84F62A20
        public object sphericalVideoLayout; // 0x84F62A20

        // ── Original Methods ──
        public void get_Status(){} // RVA: 0x7ffaa8b023d0
        public void get_Path(){} // RVA: 0x7ffaa894d380
        public void get_CompletedFileWritingAction(){} // RVA: 0x7ffaa89add50
        public void set_CompletedFileWritingAction(){} // RVA: 0x7ffaa89add60
        public void .ctor(){} // RVA: 0x7ffaae43f330
        public void StartPostProcess(){} // RVA: 0x7ffaae43f470
        public void IsFileReady(){} // RVA: 0x7ffaae43f5b0
        public void Dispose(){} // RVA: 0x7ffaae43f7b0
        public void Cleanup(){} // RVA: 0x7ffaae43fa60
        // ── Binary Analysis Named ──
        public void SetFilePostProcess(){} // RVA: 0x7ffaae43f410
    }

    public class MP4FileProcessing : Object
    {
        public object CopyBufferSize; // 0x33322FD0
        public object Atom_cmov; // 0x33322FD0
        public object Atom_hdlr; // 0x33322FD0
        public object Atom_stco; // 0x33322FD0
        public object Atom_avc1; // 0x33322FD0
        public object Atom_st3d; // 0x33322FD0
        public object Atom_svhd; // 0x33322FD0
        public object Atom_equi; // 0x33322FD0
        public object _options; // 0x33322FD0
        public object _offsetUpgradeChunks; // 0x33322FD0
        public object .cctor; // 0xB3F6FFF0
        public object <>9; // 0x84F68AF0

        // ── Original Methods ──
        public void ProcessFileAsync(){} // RVA: 0x7ffaae43fb40
        public void ProcessFile(){} // RVA: 0x7ffaae440170
        public void ProcessFile(){} // RVA: 0x7ffaae440170
        public void .ctor(){} // RVA: 0x7ffaae440570
        public void Process(){} // RVA: 0x7ffaae440720
        public void Close(){} // RVA: 0x7ffaae441220
        public void ReadChildChunks(){} // RVA: 0x7ffaae441670
        public void ReadChildChunks(){} // RVA: 0x7ffaae441670
        public void ReadChunkHeader(){} // RVA: 0x7ffaae441870
        public void ChunkContainsChildChunkWithId(){} // RVA: 0x7ffaae441a50
        public void ChunkDesc(){} // RVA: 0x7ffaae441bc0
        public void WriteChunk(){} // RVA: 0x7ffaae441f00
        public void CopyChunkHeader(){} // RVA: 0x7ffaae441f80
        public void InjectChunkHeader(){} // RVA: 0x7ffaae442000
        public void CopyBytes(){} // RVA: 0x7ffaae442080
        public void WriteZeros(){} // RVA: 0x7ffaae442190
        public void WriteChunkRecursive_moov(){} // RVA: 0x7ffaae442240
        public void IsVideoTrack(){} // RVA: 0x7ffaae442950
        public void WriteChunk_stco(){} // RVA: 0x7ffaae442aa0
        public void WriteChunk_co64_from_stco(){} // RVA: 0x7ffaae442ba0
        public void WriteChunk_co64(){} // RVA: 0x7ffaae442cd0
        public void InjectChunkStub_co64_from_stco(){} // RVA: 0x7ffaae442dc0
        public void WriteChunk_stsd(){} // RVA: 0x7ffaae442f20
        public void Convert(){} // RVA: 0x7ffaae443430
        public void InjectChunk_st3d(){} // RVA: 0x7ffaae443450
        public void InjectChunk_sv3d(){} // RVA: 0x7ffaae443520
        public void InjectChunk_uuid_GoogleSphericalVideoV1(){} // RVA: 0x7ffaae4436b0
        public void InjectChunk_svhd(){} // RVA: 0x7ffaae443950
        public void InjectChunk_proj(){} // RVA: 0x7ffaae443ba0
        public void InjectChunk_prhd(){} // RVA: 0x7ffaae443fa0
        public void InjectChunk_equi(){} // RVA: 0x7ffaae444110
        public void OverwriteChunkSize(){} // RVA: 0x7ffaae444290
        public void ReadUInt16(){} // RVA: 0x7ffaae444350
        public void ReadUInt32(){} // RVA: 0x7ffaae444460
        public void ReadUInt64(){} // RVA: 0x7ffaae444570
        public void WriteUInt16(){} // RVA: 0x7ffaae444680
        public void WriteChunkId(){} // RVA: 0x7ffaae444770
        public void WriteUInt32(){} // RVA: 0x7ffaae444780
        public void WriteUInt64(){} // RVA: 0x7ffaae444880
        public void ChunkIdToString(){} // RVA: 0x7ffaae444970
        public void ChunkId(){} // RVA: 0x7ffaae444bf0
        public void DebugLog(){} // RVA: 0x7ffaae444c40
        public void .cctor(){} // RVA: 0x7ffaae444c90
        // ── Binary Analysis Named ──
        public void GetFirstChunkOfType(){} // RVA: 0x7ffaae441420
    }

    public class MotionBlur : MonoBehaviour
    {
        public object _accum; // 0x3341ED10
        public object _divMaterial; // 0x3341ED10
        public object _targetHeight; // 0x3341ED10
        public object _propWeight; // 0x3341ED10
        public object _total; // 0x3341ED10
        public object IsFrameAccumulated; // 0x17000033
        public object NumSamples; // 0x17000034
        public object FrameCount; // 0x17000035
        public object FinalTexture; // 0x17000036

        // ── Original Methods ──
        public void get_IsFrameAccumulated(){} // RVA: 0x7ffaa9fc1d40
        public void set_IsFrameAccumulated(){} // RVA: 0x7ffaa9fc1c20
        public void get_NumSamples(){} // RVA: 0x7ffaa9349010
        public void set_NumSamples(){} // RVA: 0x7ffaae429440
        public void get_FrameCount(){} // RVA: 0x7ffaa89d30c0
        public void get_FinalTexture(){} // RVA: 0x7ffaa8bfcc80
        public void Awake(){} // RVA: 0x7ffaae429450
        public void Start(){} // RVA: 0x7ffaae429590
        public void OnEnable(){} // RVA: 0x7ffaae4295a0
        public void ClearAccumulation(){} // RVA: 0x7ffaae429de0
        public void OnDestroy(){} // RVA: 0x7ffaae429f30
        public void OnNumSamplesChanged(){} // RVA: 0x7ffaae42a450
        public void LerpUnclamped(){} // RVA: 0x7ffaae42a5d0
        public void ApplyWeighting(){} // RVA: 0x7ffaae42a5e0
        public void Accumulate(){} // RVA: 0x7ffaae42a760
        public void OnRenderImage(){} // RVA: 0x7ffaae42a850
        public void .ctor(){} // RVA: 0x7ffaae42a8d0
        // ── Binary Analysis Named ──
        public void SetTargetSize(){} // RVA: 0x7ffaae429570
        public void Setup(){} // RVA: 0x7ffaae4295c0
    }

    public class MouseCursor : MonoBehaviour
    {
        public object _sizeScale; // 0x33955AD0

        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffaae42a930
        public void OnGUI(){} // RVA: 0x7ffaae42ab40
        public void .ctor(){} // RVA: 0x7ffaae42adf0
        // ── Binary Analysis Named ──
        public void SetTexture(){} // RVA: 0x7ffaae42a940
    }

    public class NativePlugin : Object
    {
        public object PluginName; // 0x33ACE420
        public object AudioCodecNamesMacOS; // 0x33ACE420
        public object VideoCodecNamesAndroid; // 0x33ACE420
        public object MaxRenderHeight; // 0x33ACE420
        public object _freeEventFunction; // 0x33ACE420
        public object RenderCaptureEventFunction; // 0x1700003E
        public object RenderFreeEventFunction; // 0x1700003F

        // ── Original Methods ──
        public void AddAmbisonicSourceInstance(){} // RVA: 0x7ffaae42e5c0
        public void RemoveAmbisonicSourceInstance(){} // RVA: 0x7ffaae42e640
        public void UpdateAmbisonicWeights(){} // RVA: 0x7ffaae42e6c0
        public void EncodeMonoToAmbisonic(){} // RVA: 0x7ffaae42e790
        public void RenderThreadEvent(){} // RVA: 0x7ffaae42e870
        public void get_RenderCaptureEventFunction(){} // RVA: 0x7ffaae42eb00
        public void get_RenderFreeEventFunction(){} // RVA: 0x7ffaae42ec10
        public void Init(){} // RVA: 0x7ffaae42ee00
        public void Deinit(){} // RVA: 0x7ffaae42ee70
        public void IsTrialVersion(){} // RVA: 0x7ffaae42f070
        public void IsBasicEdition(){} // RVA: 0x7ffaae42f0e0
        public void IsConfigureVideoCodecSupported(){} // RVA: 0x7ffaae42f380
        public void ConfigureVideoCodec(){} // RVA: 0x7ffaae42f480
        public void IsConfigureAudioCodecSupported(){} // RVA: 0x7ffaae42f750
        public void ConfigureAudioCodec(){} // RVA: 0x7ffaae42f850
        public void CreateRecorderVideo(){} // RVA: 0x7ffaae430040
        public void CreateRecorderImages(){} // RVA: 0x7ffaae430150
        public void CreateRecorderPipe(){} // RVA: 0x7ffaae430260
        public void Start(){} // RVA: 0x7ffaae430350
        public void IsNewFrameDue(){} // RVA: 0x7ffaae4303d0
        public void EncodeFrame(){} // RVA: 0x7ffaae4304e0
        public void EncodeAudio(){} // RVA: 0x7ffaae430570
        public void EncodeFrameWithAudio(){} // RVA: 0x7ffaae430610
        public void Pause(){} // RVA: 0x7ffaae4306b0
        public void Stop(){} // RVA: 0x7ffaae430730
        public void IsFileWritingComplete(){} // RVA: 0x7ffaae4307c0
        public void FreeRecorder(){} // RVA: 0x7ffaae4308d0
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void .cctor(){} // RVA: 0x7ffaae4310a0
        // ── Binary Analysis Named ──
        public void GetRenderEventFunc(){} // RVA: 0x7ffaae42ed20
        public void GetFreeResourcesEventFunc(){} // RVA: 0x7ffaae42ed90
        public void SetMicrophoneRecordingHint(){} // RVA: 0x7ffaae42eee0
        public void GetPluginVersionString(){} // RVA: 0x7ffaae42ef70
        public void GetVideoCodecCount(){} // RVA: 0x7ffaae42f310
        public void GetVideoCodecMediaApi(){} // RVA: 0x7ffaae42f400
        public void GetVideoCodecName(){} // RVA: 0x7ffaae430c40
        public void GetAudioCodecCount(){} // RVA: 0x7ffaae42f6e0
        public void GetAudioCodecMediaApi(){} // RVA: 0x7ffaae42f7d0
        public void GetAudioCodecName(){} // RVA: 0x7ffaae430d10
        public void GetAudioInputDeviceCount(){} // RVA: 0x7ffaae42fab0
        public void GetAudioInputDeviceName(){} // RVA: 0x7ffaae430de0
        public void GetAudioInputDeviceMediaApi(){} // RVA: 0x7ffaae42fd00
        public void GetContainerFileExtensions(){} // RVA: 0x7ffaae430eb0
        public void SetEncodedFrameLimit(){} // RVA: 0x7ffaae430450
        public void SetTexturePointer(){} // RVA: 0x7ffaae430840
        public void GetNumDroppedFrames(){} // RVA: 0x7ffaae430950
        public void GetNumDroppedEncoderFrames(){} // RVA: 0x7ffaae4309d0
        public void GetNumEncodedFrames(){} // RVA: 0x7ffaae430a50
        public void GetEncodedSeconds(){} // RVA: 0x7ffaae430ad0
        public void GetFileSize(){} // RVA: 0x7ffaae430b50
        public void GetPluginVersion(){} // RVA: 0x7ffaae430bd0
        public void GetVideoCodecName(){} // RVA: 0x7ffaae430c40
        public void GetAudioCodecName(){} // RVA: 0x7ffaae430d10
        public void GetAudioInputDeviceName(){} // RVA: 0x7ffaae430de0
        public void GetContainerFileExtensions(){} // RVA: 0x7ffaae430eb0
        public void SetLogFunction(){} // RVA: 0x7ffaae430f90
        public void SetErrorHandler(){} // RVA: 0x7ffaae431010
    }

    public class TimelineController : MonoBehaviour
    {
        // ── Original Methods ──
        public void get_ScanFrequency(){} // RVA: 0x7ffaa8aeced0
        public void set_ScanFrequency(){} // RVA: 0x7ffaae42ae90
        public void Awake(){} // RVA: 0x7ffaae42aea0
        public void OnValidate(){} // RVA: 0x7ffaae42aea0
        public void UpdateFrame(){} // RVA: 0x7ffaae42aeb0
        public void StartCapture(){} // RVA: 0x7ffaae42aec0
        public void StopCapture(){} // RVA: 0x7ffaae42b020
        public void ScanForPlayableDirectors(){} // RVA: 0x7ffaae42b2a0
        public void OnDestroy(){} // RVA: 0x7ffaae42b620
        public void ResetSceneLoading(){} // RVA: 0x7ffaae42b6d0
        public void OnSceneLoaded(){} // RVA: 0x7ffaae42b7c0
        public void .ctor(){} // RVA: 0x7ffaae42b7d0
    }

    public class UnityAudioCapture : MonoBehaviour
    {
        // ── Original Methods ──
        public void get_OverflowCount(){} // RVA: 0x7ffaa8f22da0
        public void get_SampleRate(){} // RVA: 0x7ffaa8649ca0
        public void get_ChannelCount(){} // RVA: 0x7ffaa8649ca0
        public void PrepareCapture(){} // RVA: 0x7ffaa8660cc0
        public void StartCapture(){} // RVA: 0x7ffaa8660cc0
        public void StopCapture(){} // RVA: 0x7ffaa8660cc0
        public void FlushBuffer(){} // RVA: 0x7ffaa8660cc0
        public void ReadData(){} // RVA: 0x7ffaae42bd70
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        // ── Binary Analysis Named ──
        public void GetUnityAudioChannelCount(){} // RVA: 0x7ffaae42bd80
        public void GetChannelCount(){} // RVA: 0x7ffaae42bec0
    }

    public class Utils : Object
    {
        public object IOSImageSequenceFormatNames; // 0x33CD3030

        // ── Original Methods ──
        public void HasAlphaChannel(){} // RVA: 0x7ffaae4456b0
        public void HasContributingCameras(){} // RVA: 0x7ffaae445dd0
        public void FindContributingCameras(){} // RVA: 0x7ffaae445f30
        public void URLEscapePathByPercentEncoding(){} // RVA: 0x7ffaae446730
        public void ShowInExplorer(){} // RVA: 0x7ffaae446b90
        public void OpenInDefaultApp(){} // RVA: 0x7ffaae446cf0
        public void DriveFreeBytes(){} // RVA: 0x7ffaae446fc0
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void .cctor(){} // RVA: 0x7ffaae447230
        // ── Binary Analysis Named ──
        public void GetNativeImageSequenceFormatNames(){} // RVA: 0x7ffaae445630
        public void GetBestRenderTextureFormat(){} // RVA: 0x7ffaae445720
        public void GetUltimateRenderCamera(){} // RVA: 0x7ffaae445af0
        public void GetFileSize(){} // RVA: 0x7ffaae446e70
        public void GetDiskFreeSpaceEx(){} // RVA: 0x7ffaae446ef0
        public void GetImageFileExtension(){} // RVA: 0x7ffaae447160
    }

    public class VideoPlayerController : MonoBehaviour
    {
        // ── Original Methods ──
        public void get_ScanFrequency(){} // RVA: 0x7ffaa8aeced0
        public void set_ScanFrequency(){} // RVA: 0x7ffaae42bf30
        public void Awake(){} // RVA: 0x7ffaae42bf40
        public void Start(){} // RVA: 0x7ffaa8932310
        public void OnValidate(){} // RVA: 0x7ffaae42bf40
        public void Update(){} // RVA: 0x7ffaa8932310
        public void UpdateFrame(){} // RVA: 0x7ffaae42bf50
        public void CanContinue(){} // RVA: 0x7ffaae42c140
        public void WaitforSeekCompletes(){} // RVA: 0x7ffaae42c2c0
        public void WaitforSeekCompletes2(){} // RVA: 0x7ffaa8932310
        public void StartCapture(){} // RVA: 0x7ffaae42c360
        public void StopCapture(){} // RVA: 0x7ffaae42c5d0
        public void ScanForVideoPlayers(){} // RVA: 0x7ffaae42c810
        public void OnDestroy(){} // RVA: 0x7ffaae42cc00
        public void ResetSceneLoading(){} // RVA: 0x7ffaae42ccb0
        public void OnSceneLoaded(){} // RVA: 0x7ffaae42cda0
        public void .ctor(){} // RVA: 0x7ffaae42cdb0
        public void <WaitforSeekCompletes>b__13_0(){} // RVA: 0x7ffaae42cf20
    }

    public class WavWriter : Object
    {
        public object FORMAT_TAG; // 0x3381D950
        public object SUBCHUNK_ID; // 0x3381D950
        public object _stream; // 0x3381D950
        public object _byteCountTotal; // 0x3381D950
        public object _sampleFormat; // 0x3381D950
        public object `Ǐf; // 0x66DE1A7C

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae447a80
        public void Dispose(){} // RVA: 0x7ffaae447c10
        public void WriteInterleaved(){} // RVA: 0x7ffaae447ce0
        public void WriteHeader(){} // RVA: 0x7ffaae448060
        public void PackageInt(){} // RVA: 0x7ffaae448730
        public void .cctor(){} // RVA: 0x7ffaae448840
    }

}