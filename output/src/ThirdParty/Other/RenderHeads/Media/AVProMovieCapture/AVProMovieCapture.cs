// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.RenderHeads.Media.AVProMovieCapture
// Classes: 38
// Methods: 684

namespace ThirdParty.Other.RenderHeads.Media.AVProMovieCapture
{
    public class Ambisonic : Object
    {
        // ── Methods ──
        public void GetNormalisationWeights(){} // RVA: 0x7FFE86DB9CF0
        public void GetCoeffCount(){} // RVA: 0x7FFE86DB9D80
        public void GetChannelOrder(){} // RVA: 0x7FFE86DB9DB0
        public void GetNormalisation(){} // RVA: 0x7FFE86DB9DB0
        public void .cctor(){} // RVA: 0x7FFE86DB9DC0
        public void BuildWeightsFuMa(){} // RVA: 0x7FFE86DBA060
        public void GetN(){} // RVA: 0x7FFE86DBA330
        public void GetM(){} // RVA: 0x7FFE86DBA370
        public void Factorial(){} // RVA: 0x7FFE86DBA3F0
        public void GetNormalisationSN3D(){} // RVA: 0x7FFE86DBA500 | overloaded x2
        public void GetNormalisationN3D(){} // RVA: 0x7FFE86DBA680
        public void BuildWeightsSN3D(){} // RVA: 0x7FFE86DBA730
    }

    public class AmbisonicSource : MonoBehaviour
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFE86D94AC0
        public void OnDisable(){} // RVA: 0x7FFE86D94EF0
        public void Setup(){} // RVA: 0x7FFE86D951C0
        public void OnDrawGizmos(){} // RVA: 0x7FFE86D95510
        public void LateUpdate(){} // RVA: 0x7FFE86D95820
        public void SetListenerRelativePosition(){} // RVA: 0x7FFE86D95AB0
        public void UpdateCoefficients(){} // RVA: 0x7FFE86D95AD0
        public void OnAudioFilterRead(){} // RVA: 0x7FFE86D95E90
        public void FlushBuffers(){} // RVA: 0x7FFE86D96540
        public void GetFullBufferCount(){} // RVA: 0x7FFE86D96910
        public void SendSamplesToSink(){} // RVA: 0x7FFE86D96960
        public void .ctor(){} // RVA: 0x7FFE86D96C20
    }

    public class AmbisonicWavWriter : MonoBehaviour
    {
        public RenderHeads.Media.AVProMovieCapture.CaptureBase _capture; // 0x20
        public 0x666711DC _order; // 0x28

        // ── Methods ──
        public void get_Order(){} // RVA: 0x7FFE81549710
        public void get_Format(){} // RVA: 0x7FFE81F84A50
        public void AddSource(){} // RVA: 0x7FFE86D96DE0
        public void RemoveSource(){} // RVA: 0x7FFE86D96FB0
        public void OnDisable(){} // RVA: 0x7FFE86D97130
        public void SetupSource(){} // RVA: 0x7FFE86D97140
        public void ToggleCapturing(){} // RVA: 0x7FFE86D971F0
        public void StartCapture(){} // RVA: 0x7FFE86D97220
        public void StopCapture(){} // RVA: 0x7FFE86D97950
        public void IsCapturing(){} // RVA: 0x7FFE86D97B80
        public void LateUpdate(){} // RVA: 0x7FFE86D97BA0
        public void ProcessSources(){} // RVA: 0x7FFE86D97CC0
        public void MixSamples(){} // RVA: 0x7FFE86D97FD0
        public void FlushWavWriter(){} // RVA: 0x7FFE86D980F0
        public void .ctor(){} // RVA: 0x7FFE86D98130
    }

    public class AudioSourceToWav : MonoBehaviour
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFE86D98330
        public void OnDisable(){} // RVA: 0x7FFE86D98550
        public void OnAudioFilterRead(){} // RVA: 0x7FFE86D985D0
        public void .ctor(){} // RVA: 0x7FFE86D98600
    }

    public class CameraSelector : MonoBehaviour
    {
        public 0x66670684 _selectBy; // 0x20
        public 0x666706DC _scanFrequency; // 0x24
        public bool _scanHiddenCameras; // 0x28
        public string _tag; // 0x30
        public string _name; // 0x38
        public UnityEngine.Camera _camera; // 0x40

        // ── Methods ──
        public void get_Camera(){} // RVA: 0x7FFE81178740
        public void set_Camera(){} // RVA: 0x7FFE86D986D0
        public void get_SelectBy(){} // RVA: 0x7FFE8151D690
        public void set_SelectBy(){} // RVA: 0x7FFE86D98740
        public void get_ScanFrequency(){} // RVA: 0x7FFE81A56130
        public void set_ScanFrequency(){} // RVA: 0x7FFE86D98750
        public void get_ScanHiddenCameras(){} // RVA: 0x7FFE815F1380
        public void set_ScanHiddenCameras(){} // RVA: 0x7FFE86D98760
        public void get_SelectTag(){} // RVA: 0x7FFE8144E200
        public void set_SelectTag(){} // RVA: 0x7FFE86D98770
        public void get_SelectName(){} // RVA: 0x7FFE8143BA80
        public void set_SelectName(){} // RVA: 0x7FFE86D987D0
        public void Awake(){} // RVA: 0x7FFE86D98830
        public void Start(){} // RVA: 0x7FFE86D98840
        public void OnValidate(){} // RVA: 0x7FFE86D98830
        public void Update(){} // RVA: 0x7FFE86D98850
        public void OnDestroy(){} // RVA: 0x7FFE86D98870
        public void ResetSceneLoading(){} // RVA: 0x7FFE86D98910
        public void OnSceneLoaded(){} // RVA: 0x7FFE86D98A00
        public void ScanForCameraChange(){} // RVA: 0x7FFE86D98A10
        public void FindCamera(){} // RVA: 0x7FFE86D98C40
        public void UpdateCameraCache(){} // RVA: 0x7FFE86D98F80
        public void FindCameraByHighestDepth(){} // RVA: 0x7FFE86D99120
        public void FindCameraByTag(){} // RVA: 0x7FFE86D992A0
        public void FindCameraByName(){} // RVA: 0x7FFE86D99330
        public void .ctor(){} // RVA: 0x7FFE86D993F0
    }

    public class CaptureAudioFromAudioClip : MonoBehaviour
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFE86D995C0
        public void Update(){} // RVA: 0x7FFE86D99970
        public void GetAudioSamplesForFrame(){} // RVA: 0x7FFE86D99A80
        public void .ctor(){} // RVA: 0x7FFE816314E0
    }

    public class CaptureAudioFromAudioListener : UnityAudioCapture
    {
        public bool _debugLogging; // 0x20
        public bool _muteAudio; // 0x21
        public int BufferSize;
        public float[] _buffer; // 0x28
        public float[] _readBuffer; // 0x30
        public int _bufferIndex; // 0x38

        // ── Methods ──
        public void get_Buffer(){} // RVA: 0x7FFE8144E200
        public void get_BufferLength(){} // RVA: 0x7FFE81D46090
        public void get_BufferPtr(){} // RVA: 0x7FFE86D99DD0
        public void get_OverflowCount(){} // RVA: 0x7FFE821E0A40
        public void get_SampleRate(){} // RVA: 0x7FFE86D99DE0
        public void get_ChannelCount(){} // RVA: 0x7FFE8119C0C0
        public void PrepareCapture(){} // RVA: 0x7FFE86D99E30
        public void StartCapture(){} // RVA: 0x7FFE844800F0
        public void StopCapture(){} // RVA: 0x7FFE86D9A3B0
        public void ReadData(){} // RVA: 0x7FFE86D9A610
        public void FlushBuffer(){} // RVA: 0x7FFE86D9A7A0
        public void OnAudioFilterRead(){} // RVA: 0x7FFE86D9A8E0
        public void .ctor(){} // RVA: 0x7FFE86D9AC50
    }

    public class CaptureAudioFromAudioRenderer : UnityAudioCapture
    {
        public RenderHeads.Media.AVProMovieCapture.CaptureBase _capture; // 0x20
        public int _unityAudioChannelCount; // 0x28
        public bool _isRendererRecording; // 0x2C

        // ── Methods ──
        public void get_Capture(){} // RVA: 0x7FFE811290C0
        public void set_Capture(){} // RVA: 0x7FFE811290D0
        public void get_SampleRate(){} // RVA: 0x7FFE86D99DE0
        public void get_ChannelCount(){} // RVA: 0x7FFE81549710
        public void PrepareCapture(){} // RVA: 0x7FFE86D9AE00
        public void GetAudioBufferOfLength(){} // RVA: 0x7FFE86D9AE20
        public void DisposeAudioBuffer(){} // RVA: 0x7FFE810FB310
        public void StartCapture(){} // RVA: 0x7FFE86D9AFF0
        public void StopCapture(){} // RVA: 0x7FFE86D9B260
        public void FlushBuffer(){} // RVA: 0x7FFE86D9B2F0
        public void Update(){} // RVA: 0x7FFE86D9B3E0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class CaptureAudioFromWwise : UnityAudioCapture
    {
        public RenderHeads.Media.AVProMovieCapture.CaptureBase _capture; // 0x20
        public object field_1; // 0x12
        public object field_2; // 0x13

        // ── Methods ──
        public void get_Capture(){} // RVA: 0x7FFE811290C0
        public void set_Capture(){} // RVA: 0x7FFE811290D0
        public void Awake(){} // RVA: 0x7FFE86D9B5A0
        public void get_SampleRate(){} // RVA: 0x7FFE813240E0
        public void get_ChannelCount(){} // RVA: 0x7FFE813240E0
        public void PrepareCapture(){} // RVA: 0x7FFE810FB310
        public void FlushBuffer(){} // RVA: 0x7FFE810FB310
        public void StartCapture(){} // RVA: 0x7FFE810FB310
        public void StopCapture(){} // RVA: 0x7FFE810FB310
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class CaptureBase : MonoBehaviour
    {
        public string DocEditionsURL;
        public RenderHeads.Media.AVProMovieCapture.EncoderHints _encoderHintsWindows; // 0x20
        public RenderHeads.Media.AVProMovieCapture.EncoderHints _encoderHintsMacOS; // 0x28
        public RenderHeads.Media.AVProMovieCapture.EncoderHints _encoderHintsIOS; // 0x30
        public RenderHeads.Media.AVProMovieCapture.EncoderHints _encoderHintsAndroid; // 0x38
        public 0x66576A14 _captureKey; // 0x40
        public bool _isRealTime; // 0x44
        public bool _persistAcrossSceneLoads; // 0x45
        public 0x66672414 _startTrigger; // 0x48
        public 0x6667246C _startDelay; // 0x4C
        public float _startDelaySeconds; // 0x50
        public 0x666723BC _stopMode; // 0x54
        public int _stopFrames; // 0x58
        public float _stopSeconds; // 0x5C
        public string[] DefaultVideoCodecPriorityWindows;
        public string[] DefaultVideoCodecPriorityMacOS; // 0x8
        public string[] DefaultVideoCodecPriorityAndroid; // 0x10
        public string[] DefaultAudioCodecPriorityWindows; // 0x18
        public string[] DefaultAudioCodecPriorityMacOS; // 0x20
        public string[] DefaultAudioCodecPriorityIOS; // 0x28
        public string[] DefaultAudioCodecPriorityAndroid; // 0x30
        public string[] DefaultAudioCaptureDevicePriorityWindow; // 0x38
        public string[] DefaultAudioCaptureDevicePriorityMacOS; // 0x40
        public string[] DefaultAudioCaptureDevicePriorityIOS; // 0x48
        public string[] DefaultAudioCaptureDevicePriorityAndroid; // 0x50
        public string[] _videoCodecPriorityWindows; // 0x60
        public string[] _videoCodecPriorityMacOS; // 0x68
        public string[] _videoCodecPriorityAndroid; // 0x70
        public string[] _audioCodecPriorityWindows; // 0x78
        public string[] _audioCodecPriorityMacOS; // 0x80
        public string[] _audioCodecPriorityAndroid; // 0x88
        public float _frameRate; // 0x90
        public int _timelapseScale; // 0x94
        public 0x66671A1C _frameUpdateMode; // 0x98
        public 0x6667196C _downScale; // 0x9C
        public UnityEngine.Vector2 _maxVideoSize; // 0xA0
        public int _forceVideoCodecIndexWindows; // 0xA8
        public int _forceVideoCodecIndexMacOS; // 0xAC
        public int _forceVideoCodecIndexIOS; // 0xB0
        public int _forceVideoCodecIndexAndroid; // 0xB4
        public int _forceAudioCodecIndexWindows; // 0xB8
        public int _forceAudioCodecIndexMacOS; // 0xBC
        public int _forceAudioCodecIndexIOS; // 0xC0
        public int _forceAudioCodecIndexAndroid; // 0xC4
        public bool _flipVertically; // 0xC8
        public bool _forceGpuFlush; // 0xC9
        public bool _useWaitForEndOfFrame; // 0xCA
        public bool _androidNoCaptureRotation; // 0xCB
        public bool _logCaptureStartStop; // 0xCC
        public 0x666722B4 _audioCaptureSource; // 0xD0
        public RenderHeads.Media.AVProMovieCapture.UnityAudioCapture _unityAudioCapture; // 0xD8
        public int _forceAudioInputDeviceIndex; // 0xE0
        public int _manualAudioSampleRate; // 0xE4
        public int _manualAudioChannelCount; // 0xE8
        public 0x6667251C _outputTarget; // 0xEC
        public 0x666719C4 DefaultOutputFolderType;
        public string DefaultOutputFolderPath;
        public 0x666719C4 _outputFolderType; // 0xF0
        public string _outputFolderPath; // 0xF8

        // ── Methods ──
        public void get_OutputTarget(){} // RVA: 0x7FFE82A3B600
        public void set_OutputTarget(){} // RVA: 0x7FFE86DBACA0
        public void get_OutputFolder(){} // RVA: 0x7FFE843B5350
        public void set_OutputFolder(){} // RVA: 0x7FFE86DBACB0
        public void get_OutputFolderPath(){} // RVA: 0x7FFE8158D5D0
        public void set_OutputFolderPath(){} // RVA: 0x7FFE81B0E4B0
        public void get_FilenamePrefix(){} // RVA: 0x7FFE81828B50
        public void set_FilenamePrefix(){} // RVA: 0x7FFE81A58AB0
        public void get_AppendFilenameTimestamp(){} // RVA: 0x7FFE82472660
        public void set_AppendFilenameTimestamp(){} // RVA: 0x7FFE82472670
        public void get_AllowManualFileExtension(){} // RVA: 0x7FFE82904DF0
        public void set_AllowManualFileExtension(){} // RVA: 0x7FFE82904650
        public void get_FilenameExtension(){} // RVA: 0x7FFE81317980
        public void set_FilenameExtension(){} // RVA: 0x7FFE813159A0
        public void get_NamedPipePath(){} // RVA: 0x7FFE81318010
        public void set_NamedPipePath(){} // RVA: 0x7FFE81317920
        public void get_ImageSequenceStartFrame(){} // RVA: 0x7FFE86DBACC0
        public void set_ImageSequenceStartFrame(){} // RVA: 0x7FFE86DBACD0
        public void get_ImageSequenceZeroDigits(){} // RVA: 0x7FFE86C7E580
        public void set_ImageSequenceZeroDigits(){} // RVA: 0x7FFE86DBACE0
        public void get_UseMotionBlur(){} // RVA: 0x7FFE823E5620
        public void set_UseMotionBlur(){} // RVA: 0x7FFE823F09C0
        public void get_MotionBlurSamples(){} // RVA: 0x7FFE86DBAD10
        public void set_MotionBlurSamples(){} // RVA: 0x7FFE86DBAD20
        public void get_MotionBlurCameras(){} // RVA: 0x7FFE81790740
        public void set_MotionBlurCameras(){} // RVA: 0x7FFE81B350B0
        public void get_MotionBlur(){} // RVA: 0x7FFE81B16560
        public void set_MotionBlur(){} // RVA: 0x7FFE81B21880
        public void get_ActiveFilePaths(){} // RVA: 0x7FFE86DBAD50
        public void get_LastFilePath(){} // RVA: 0x7FFE8181EA60
        public void get_BeginFinalFileWritingAction(){} // RVA: 0x7FFE81B14500
        public void set_BeginFinalFileWritingAction(){} // RVA: 0x7FFE81B317A0
        public void get_CompletedFileWritingAction(){} // RVA: 0x7FFE81B2DA70
        public void set_CompletedFileWritingAction(){} // RVA: 0x7FFE81B27F80
        public void get_Stats(){} // RVA: 0x7FFE81B296E0
        public void get_CameraRenderResolution(){} // RVA: 0x7FFE81F60BB0
        public void set_CameraRenderResolution(){} // RVA: 0x7FFE86C70910
        public void get_CameraRenderCustomResolution(){} // RVA: 0x7FFE86DBADB0
        public void set_CameraRenderCustomResolution(){} // RVA: 0x7FFE86DBADD0
        public void get_CameraRenderAntiAliasing(){} // RVA: 0x7FFE8236BB60
        public void set_CameraRenderAntiAliasing(){} // RVA: 0x7FFE8236B930
        public void get_IsRealTime(){} // RVA: 0x7FFE82876440
        public void set_IsRealTime(){} // RVA: 0x7FFE82876430
        public void get_PersistAcrossSceneLoads(){} // RVA: 0x7FFE82A22A70
        public void set_PersistAcrossSceneLoads(){} // RVA: 0x7FFE82A22A80
        public void get_AudioCaptureSource(){} // RVA: 0x7FFE817E0030
        public void set_AudioCaptureSource(){} // RVA: 0x7FFE82862FC0
        public void get_ManualAudioSampleRate(){} // RVA: 0x7FFE82A3E370
        public void set_ManualAudioSampleRate(){} // RVA: 0x7FFE84A61AC0
        public void get_ManualAudioChannelCount(){} // RVA: 0x7FFE82A3E380
        public void set_ManualAudioChannelCount(){} // RVA: 0x7FFE86DBADE0
        public void get_UnityAudioCapture(){} // RVA: 0x7FFE8181EA80
        public void set_UnityAudioCapture(){} // RVA: 0x7FFE8117C8A0
        public void get_ForceAudioInputDeviceIndex(){} // RVA: 0x7FFE82AA02F0
        public void set_ForceAudioInputDeviceIndex(){} // RVA: 0x7FFE86DBADF0
        public void get_FrameRate(){} // RVA: 0x7FFE81163540
        public void set_FrameRate(){} // RVA: 0x7FFE86DBAE00
        public void get_StartTrigger(){} // RVA: 0x7FFE8119C0C0
        public void set_StartTrigger(){} // RVA: 0x7FFE8119C0D0
        public void get_StartDelay(){} // RVA: 0x7FFE821E0A40
        public void set_StartDelay(){} // RVA: 0x7FFE82B06A20
        public void get_StartDelaySeconds(){} // RVA: 0x7FFE81163460
        public void set_StartDelaySeconds(){} // RVA: 0x7FFE86DBAE30
        public void get_StopMode(){} // RVA: 0x7FFE819EA920
        public void set_StopMode(){} // RVA: 0x7FFE819EA900
        public void get_StopAfterFramesElapsed(){} // RVA: 0x7FFE8175AC90
        public void set_StopAfterFramesElapsed(){} // RVA: 0x7FFE86DBAE40
        public void get_StopAfterSecondsElapsed(){} // RVA: 0x7FFE81124000
        public void set_StopAfterSecondsElapsed(){} // RVA: 0x7FFE86DBAE50
        public void get_CaptureStats(){} // RVA: 0x7FFE81B296E0
        public void get_VideoCodecPriorityWindows(){} // RVA: 0x7FFE81199370
        public void set_VideoCodecPriorityWindows(){} // RVA: 0x7FFE86DBAE60
        public void get_VideoCodecPriorityMacOS(){} // RVA: 0x7FFE81176D50
        public void set_VideoCodecPriorityMacOS(){} // RVA: 0x7FFE86DBAEC0
        public void get_AudioCodecPriorityWindows(){} // RVA: 0x7FFE81463AE0
        public void set_AudioCodecPriorityWindows(){} // RVA: 0x7FFE86DBAF20
        public void get_AudioCodecPriorityMacOS(){} // RVA: 0x7FFE81280C30
        public void set_AudioCodecPriorityMacOS(){} // RVA: 0x7FFE86DBAF80
        public void get_TimelapseScale(){} // RVA: 0x7FFE814AA230
        public void set_TimelapseScale(){} // RVA: 0x7FFE81680470
        public void get_FrameUpdate(){} // RVA: 0x7FFE82B06A40
        public void set_FrameUpdate(){} // RVA: 0x7FFE82B06FA0
        public void get_ResolutionDownScale(){} // RVA: 0x7FFE82B06F90
        public void set_ResolutionDownScale(){} // RVA: 0x7FFE82B06A30
        public void get_ResolutionDownscaleCustom(){} // RVA: 0x7FFE86DBAFE0
        public void set_ResolutionDownscaleCustom(){} // RVA: 0x7FFE86B370C0
        public void get_FlipVertically(){} // RVA: 0x7FFE81FF3AD0
        public void set_FlipVertically(){} // RVA: 0x7FFE81FE9F60
        public void get_UseWaitForEndOfFrame(){} // RVA: 0x7FFE86DBB000
        public void set_UseWaitForEndOfFrame(){} // RVA: 0x7FFE86DBB010
        public void get_LogCaptureStartStop(){} // RVA: 0x7FFE81309DB0
        public void set_LogCaptureStartStop(){} // RVA: 0x7FFE86DBB020
        public void get_AllowOfflineVSyncDisable(){} // RVA: 0x7FFE86DBB030
        public void set_AllowOfflineVSyncDisable(){} // RVA: 0x7FFE86DBB040
        public void get_SupportTextureRecreate(){} // RVA: 0x7FFE86DBB050
        public void set_SupportTextureRecreate(){} // RVA: 0x7FFE86DBB060
        public void get_TimelineController(){} // RVA: 0x7FFE81B2CB70
        public void set_TimelineController(){} // RVA: 0x7FFE81B23F80
        public void get_VideoPlayerController(){} // RVA: 0x7FFE815BB6A0
        public void set_VideoPlayerController(){} // RVA: 0x7FFE81B38790
        public void get_SelectedVideoCodec(){} // RVA: 0x7FFE81B164E0
        public void get_SelectedAudioCodec(){} // RVA: 0x7FFE817EFE00
        public void get_SelectedAudioInputDevice(){} // RVA: 0x7FFE81B16E90
        public void get_NativeForceVideoCodecIndex(){} // RVA: 0x7FFE81A338E0
        public void set_NativeForceVideoCodecIndex(){} // RVA: 0x7FFE81A34770
        public void get_NativeForceAudioCodecIndex(){} // RVA: 0x7FFE8260FFA0
        public void set_NativeForceAudioCodecIndex(){} // RVA: 0x7FFE826140C0
        public void get_NativeImageSequenceFormat(){} // RVA: 0x7FFE86DBB070
        public void set_NativeImageSequenceFormat(){} // RVA: 0x7FFE86DBB080
        public void GetCurrentPlatform(){} // RVA: 0x7FFE813240E0
        public void GetEncoderHints(){} // RVA: 0x7FFE86DBB090
        public void SetEncoderHints(){} // RVA: 0x7FFE86DBB140
        public void UpdateMediaGallery(){} // RVA: 0x7FFE810FB310
        public void Awake(){} // RVA: 0x7FFE86DBB360
        public void .cctor(){} // RVA: 0x7FFE86DBB990
        public void Start(){} // RVA: 0x7FFE86DBC4B0
        public void SelectCodec(){} // RVA: 0x7FFE86DBC5E0
        public void SelectVideoCodec(){} // RVA: 0x7FFE86DBC990
        public void SelectAudioCodec(){} // RVA: 0x7FFE86DBCB70
        public void SelectAudioInputDevice(){} // RVA: 0x7FFE86DBCCE0
        public void GetRecordingResolution(){} // RVA: 0x7FFE86DBCF40
        public void SelectRecordingResolution(){} // RVA: 0x7FFE86DBD010
        public void OnDestroy(){} // RVA: 0x7FFE86DBD120
        public void FreePendingFileWrites(){} // RVA: 0x7FFE86DBD490
        public void OnApplicationQuit(){} // RVA: 0x7FFE86DBD630
        public void OnApplicationPause(){} // RVA: 0x7FFE810FB310
        public void EncodeTexture(){} // RVA: 0x7FFE86DBD690
        public void IsUsingUnityAudioComponent(){} // RVA: 0x7FFE86DBD7A0
        public void IsUsingMotionBlur(){} // RVA: 0x7FFE86DBD8A0
        public void EncodePointer(){} // RVA: 0x7FFE86DBD990
        public void IsPrepared(){} // RVA: 0x7FFE86DBDB20
        public void IsCapturing(){} // RVA: 0x7FFE86DBDB30
        public void IsPaused(){} // RVA: 0x7FFE86DBDB40
        public void GetRecordingWidth(){} // RVA: 0x7FFE86DBDB50
        public void GetRecordingHeight(){} // RVA: 0x7FFE86DBDB60
        public void GenerateTimestampedFilename(){} // RVA: 0x7FFE86DBDB70
        public void GetFolder(){} // RVA: 0x7FFE86DBDE50
        public void GenerateFilePath(){} // RVA: 0x7FFE86DBE030
        public void HasExtension(){} // RVA: 0x7FFE86DBE0D0
        public void GenerateFilename(){} // RVA: 0x7FFE86DBE220
        public void FindOrCreateUnityAudioCapture(){} // RVA: 0x7FFE86DBEA10
        public void ValidateEditionFeatures(){} // RVA: 0x7FFE86DBF0B0
        public void PrepareCapture(){} // RVA: 0x7FFE86DBF7E0
        public void QueueStartCapture(){} // RVA: 0x7FFE86DC1500
        public void IsStartCaptureQueued(){} // RVA: 0x7FFE86DC15A0
        public void UpdateInjectionOptions(){} // RVA: 0x7FFE86DC15B0
        public void StartCapture(){} // RVA: 0x7FFE86DC1640
        public void PauseCapture(){} // RVA: 0x7FFE86DC1B00
        public void ResumeCapture(){} // RVA: 0x7FFE86DC1C40
        public void CancelCapture(){} // RVA: 0x7FFE86DC1D50
        public void DeleteCapture(){} // RVA: 0x7FFE86DC1D80
        public void UnprepareCapture(){} // RVA: 0x7FFE810FB310
        public void get_LastFileSaved(){} // RVA: 0x7FFE86DC1E90
        public void set_LastFileSaved(){} // RVA: 0x7FFE86DC1F40
        public void RenderThreadEvent(){} // RVA: 0x7FFE86DC1F90
        public void StopCapture(){} // RVA: 0x7FFE86DC2000
        public void CreatePostOperationsOptions(){} // RVA: 0x7FFE86DC2D30
        public void CanApplyPostOperations(){} // RVA: 0x7FFE86DC2E00
        public void ApplyPostOperations(){} // RVA: 0x7FFE86DC2FF0
        public void ToggleCapture(){} // RVA: 0x7FFE86DC3220
        public void IsEnoughDiskSpace(){} // RVA: 0x7FFE86DC3260
        public void CanContinue(){} // RVA: 0x7FFE86DC32A0
        public void Update(){} // RVA: 0x7FFE86DC33C0
        public void LateUpdate(){} // RVA: 0x7FFE86DC3430
        public void RemoveCompletedFileWrites(){} // RVA: 0x7FFE86DC3760
        public void CheckFreeDiskSpace(){} // RVA: 0x7FFE86DC3840
        public void IsStartDelayComplete(){} // RVA: 0x7FFE86DC3900
        public void IsStopTimeReached(){} // RVA: 0x7FFE86DC3930
        public void GetProgress(){} // RVA: 0x7FFE86DC3A20
        public void GetSecondsPerCaptureFrame(){} // RVA: 0x7FFE86DC3AE0
        public void CanOutputFrame(){} // RVA: 0x7FFE86DC3B10
        public void TickFrameTimer(){} // RVA: 0x7FFE86DC3D40
        public void RenormTimer(){} // RVA: 0x7FFE86DC3DB0
        public void GetPreviewTexture(){} // RVA: 0x7FFE813240E0
        public void EncodeUnityAudio(){} // RVA: 0x7FFE86DC3E00
        public void EncodeAudio(){} // RVA: 0x7FFE86DC3F50 | overloaded x2
        public void PreUpdateFrame(){} // RVA: 0x7FFE86DC41B0
        public void UpdateFrame(){} // RVA: 0x7FFE86DC4390
        public void ResetFPS(){} // RVA: 0x7FFE86DC46D0
        public void UpdateFPS(){} // RVA: 0x7FFE86DC4700
        public void GetCameraAntiAliasingLevel(){} // RVA: 0x7FFE86DC4790
        public void GetCaptureFileSize(){} // RVA: 0x7FFE86DC4A00
        public void GetResolution(){} // RVA: 0x7FFE86DC4B10
        public void NextMultipleOf4(){} // RVA: 0x7FFE821715B0
        public void HasUserAuthorisationToCaptureAudio(){} // RVA: 0x7FFE86DC4C90
        public void RequestUserAuthorisationToCaptureAudioCallback(){} // RVA: 0x7FFE86DC4D70
        public void RequestAudioCaptureDeviceUserAuthorisation(){} // RVA: 0x7FFE813240E0
        public void HasUserAuthorisationToAccessPhotos(){} // RVA: 0x7FFE86DC4DF0
        public void RequestUserAuthorisationToAccessPhotosCallback(){} // RVA: 0x7FFE86DC4ED0
        public void RequestUserAuthorisationToAccessPhotos(){} // RVA: 0x7FFE813240E0
        public void .ctor(){} // RVA: 0x7FFE86DC4F50
    }

    public class CaptureFromCamera : CaptureBase
    {
        public RenderHeads.Media.AVProMovieCapture.CameraSelector _cameraSelector; // 0x220
        public UnityEngine.Camera _lastCamera; // 0x228

        // ── Methods ──
        public void get_CameraSelector(){} // RVA: 0x7FFE81B310E0
        public void set_CameraSelector(){} // RVA: 0x7FFE81B21BD0
        public void get_UseContributingCameras(){} // RVA: 0x7FFE86D9B600
        public void set_UseContributingCameras(){} // RVA: 0x7FFE86D9B610
        public void SetCamera(){} // RVA: 0x7FFE86D9B980 | overloaded x2
        public void RequiresResolve(){} // RVA: 0x7FFE86D9BA40
        public void HasCamera(){} // RVA: 0x7FFE86D9BB70
        public void HasContributingCameras(){} // RVA: 0x7FFE86D9BC40
        public void UpdateFrame(){} // RVA: 0x7FFE86D9BC70
        public void FinalRenderCapture(){} // RVA: 0x7FFE86D9BF60
        public void Capture(){} // RVA: 0x7FFE86D9C000
        public void RequiresHDR(){} // RVA: 0x7FFE86D9C0A0
        public void UpdateTexture(){} // RVA: 0x7FFE86D9C280
        public void UnprepareCapture(){} // RVA: 0x7FFE86D9CC00
        public void CreateResolveTexture(){} // RVA: 0x7FFE86D9CE30
        public void GetPreviewTexture(){} // RVA: 0x7FFE81B2BBE0
        public void PrepareCapture(){} // RVA: 0x7FFE86D9D2E0
        public void OnDestroy(){} // RVA: 0x7FFE86D9DE60
        public void .ctor(){} // RVA: 0x7FFE86D9E150
        public void <>n__0(){} // RVA: 0x7FFE86D9E1B0
    }

    public class CaptureFromCamera360 : CaptureBase
    {
        public RenderHeads.Media.AVProMovieCapture.CameraSelector _cameraSelector; // 0x220
        public 0x666718BC _cubemapResolution; // 0x228
        public 0x66671864 _cubemapDepth; // 0x22C
        public bool _supportGUI; // 0x230
        public bool _supportCameraRotation; // 0x231
        public bool _onlyLeftRightRotation; // 0x232
        public bool _render180Degrees; // 0x233
        public 0x6667230C _stereoRendering; // 0x234
        public float _ipd; // 0x238

        // ── Methods ──
        public void get_CameraSelector(){} // RVA: 0x7FFE81B310E0
        public void set_CameraSelector(){} // RVA: 0x7FFE81B21BD0
        public void get_CubemapFaceResolution(){} // RVA: 0x7FFE827C65C0
        public void set_CubemapFaceResolution(){} // RVA: 0x7FFE827C6630
        public void get_CubemapDepthResolution(){} // RVA: 0x7FFE827C5130
        public void set_CubemapDepthResolution(){} // RVA: 0x7FFE827C5010
        public void get_SupportGUI(){} // RVA: 0x7FFE86D9E8C0
        public void set_SupportGUI(){} // RVA: 0x7FFE86D9E8D0
        public void get_SupportCameraRotation(){} // RVA: 0x7FFE86D9E8E0
        public void set_SupportCameraRotation(){} // RVA: 0x7FFE86D9E8F0
        public void get_OnlyLeftRightRotation(){} // RVA: 0x7FFE86D9E900
        public void set_OnlyLeftRightRotation(){} // RVA: 0x7FFE86D9E910
        public void get_Render180Degrees(){} // RVA: 0x7FFE86D9E920
        public void set_Render180Degrees(){} // RVA: 0x7FFE86D9E930
        public void get_StereoRendering(){} // RVA: 0x7FFE827C5140
        public void set_StereoRendering(){} // RVA: 0x7FFE86D9E940
        public void get_IPD(){} // RVA: 0x7FFE86D9E950
        public void set_IPD(){} // RVA: 0x7FFE86D9E960
        public void .ctor(){} // RVA: 0x7FFE86D9E970
        public void GetCubemapRenderingMethod(){} // RVA: 0x7FFE86D9EA00
        public void SetCamera(){} // RVA: 0x7FFE81B2E9D0
        public void UpdateFrame(){} // RVA: 0x7FFE86D9EA20
        public void FinalRenderCapture(){} // RVA: 0x7FFE86D9ECE0
        public void Capture(){} // RVA: 0x7FFE86D9ED80
        public void ClearCubemap(){} // RVA: 0x7FFE86D9F220
        public void RenderCubemapToEquiRect(){} // RVA: 0x7FFE86D9F6D0
        public void UpdateTexture(){} // RVA: 0x7FFE86D9F890
        public void RenderCameraToCubemap(){} // RVA: 0x7FFE86DA00C0
        public void AccumulateMotionBlur(){} // RVA: 0x7FFE86DA1B90
        public void PrepareCapture(){} // RVA: 0x7FFE86DA1D50
        public void GetPreviewTexture(){} // RVA: 0x7FFE86DA2F40
        public void Start(){} // RVA: 0x7FFE86DA2F80
        public void OnDestroy(){} // RVA: 0x7FFE86DA3340
    }

    public class CaptureFromCamera360ODS : CaptureBase
    {
        public Settings _settings; // 0x220

        // ── Methods ──
        public void get_Setup(){} // RVA: 0x7FFE81B310E0
        public void .ctor(){} // RVA: 0x7FFE86DA3920
        public void SetCamera(){} // RVA: 0x7FFE86DA3A40
        public void Start(){} // RVA: 0x7FFE86DA3AB0
        public void CreateEye(){} // RVA: 0x7FFE86DA3CE0
        public void UpdateFrame(){} // RVA: 0x7FFE86DA4DE0
        public void FinalRenderCapture(){} // RVA: 0x7FFE86DA50D0
        public void Capture(){} // RVA: 0x7FFE86DA5170
        public void AccumulateMotionBlur(){} // RVA: 0x7FFE86DA53E0
        public void RenderFrame(){} // RVA: 0x7FFE86DA55B0
        public void GetPreviewTexture(){} // RVA: 0x7FFE86DA6250
        public void PrepareCapture(){} // RVA: 0x7FFE86DA6290
        public void DestroyEye(){} // RVA: 0x7FFE86DA7400
        public void OnDestroy(){} // RVA: 0x7FFE86DA7630
    }

    public class CaptureFromScreen : CaptureBase
    {
        public bool _captureMouseCursor; // 0x220
        public RenderHeads.Media.AVProMovieCapture.MouseCursor _mouseCursor; // 0x228

        // ── Methods ──
        public void get_CaptureMouseCursor(){} // RVA: 0x7FFE86DA7D90
        public void set_CaptureMouseCursor(){} // RVA: 0x7FFE86DA7DA0
        public void get_MouseCursor(){} // RVA: 0x7FFE81B0D790
        public void set_MouseCursor(){} // RVA: 0x7FFE81B34BA0
        public void PrepareCapture(){} // RVA: 0x7FFE86DA7DB0
        public void CopyRenderTargetToTexture(){} // RVA: 0x7FFE86DA8110
        public void FreeRenderResources(){} // RVA: 0x7FFE86DA8720
        public void UnprepareCapture(){} // RVA: 0x7FFE86DA8940
        public void FinalRenderCapture(){} // RVA: 0x7FFE86DA8AB0
        public void UpdateFrame(){} // RVA: 0x7FFE86DA8B50
        public void .ctor(){} // RVA: 0x7FFE86DA8C10
    }

    public class CaptureFromTexture : CaptureBase
    {
        public bool _manualUpdate; // 0x220

        // ── Methods ──
        public void get_IsManualUpdate(){} // RVA: 0x7FFE86DA7D90
        public void set_IsManualUpdate(){} // RVA: 0x7FFE86DA7DA0
        public void SetSourceTexture(){} // RVA: 0x7FFE81B34BA0
        public void RequiresResolve(){} // RVA: 0x7FFE86DA8E30
        public void UpdateSourceTexture(){} // RVA: 0x7FFE86DA8F60
        public void ShouldCaptureFrame(){} // RVA: 0x7FFE86DA8F70
        public void HasSourceTextureChanged(){} // RVA: 0x7FFE86DA9060
        public void UpdateFrame(){} // RVA: 0x7FFE86DA9080
        public void FinalRenderCapture(){} // RVA: 0x7FFE86DA9150
        public void Capture(){} // RVA: 0x7FFE86DA91F0
        public void CreateResolveTexture(){} // RVA: 0x7FFE86DA9600
        public void AccumulateMotionBlur(){} // RVA: 0x7FFE86DA99B0
        public void GetPreviewTexture(){} // RVA: 0x7FFE86DA9AD0
        public void PrepareCapture(){} // RVA: 0x7FFE86DA9C40
        public void UnprepareCapture(){} // RVA: 0x7FFE86DAA030
        public void .ctor(){} // RVA: 0x7FFE86DAA200
    }

    public class CaptureFromWebCamTexture : CaptureFromTexture
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFE86DAA350
        public void .ctor(){} // RVA: 0x7FFE86DAA200
    }

    public class CaptureGUI : MonoBehaviour
    {
        public RenderHeads.Media.AVProMovieCapture.CaptureBase _movieCapture; // 0x20
        public bool _showUI; // 0x28
        public bool _whenRecordingAutoHideUI; // 0x29

        // ── Methods ──
        public void get_MovieCapture(){} // RVA: 0x7FFE811290C0
        public void set_MovieCapture(){} // RVA: 0x7FFE811290D0
        public void get_HideUiWhenRecording(){} // RVA: 0x7FFE819C2EA0
        public void set_HideUiWhenRecording(){} // RVA: 0x7FFE8268C820
        public void get_ShowUI(){} // RVA: 0x7FFE815F1380
        public void set_ShowUI(){} // RVA: 0x7FFE81C15740
        public void Start(){} // RVA: 0x7FFE86DAA3B0
        public void CreateGUI(){} // RVA: 0x7FFE86DAA490
        public void OnGUI(){} // RVA: 0x7FFE86DAB0F0
        public void MyWindow(){} // RVA: 0x7FFE86DABBD0
        public void GUI_RecordingStatus(){} // RVA: 0x7FFE86DAE450
        public void DrawPauseResumeButtons(){} // RVA: 0x7FFE86DAFEE0
        public void DrawGuiField(){} // RVA: 0x7FFE86DB0700
        public void StartCapture(){} // RVA: 0x7FFE86DB07D0
        public void StopCapture(){} // RVA: 0x7FFE86DB08D0
        public void CancelCapture(){} // RVA: 0x7FFE86DB09D0
        public void ResumeCapture(){} // RVA: 0x7FFE86DB0AD0
        public void PauseCapture(){} // RVA: 0x7FFE86DB0BB0
        public void Update(){} // RVA: 0x7FFE86DB0C90
        public void .ctor(){} // RVA: 0x7FFE86DB0F50
        public void .cctor(){} // RVA: 0x7FFE86DB1510
    }

    public class CaptureStats : Object
    {
        public uint _numDroppedFrames; // 0x10
        public uint _numDroppedEncoderFrames; // 0x14
        public uint _numEncodedFrames; // 0x18
        public uint _totalEncodedSeconds; // 0x1C
        public 0x666722B4 _audioCaptureSource; // 0x20
        public int _unityAudioSampleRate; // 0x24
        public int _unityAudioChannelCount; // 0x28
        public float _fps; // 0x2C
        public int _frameTotal; // 0x30

        // ── Methods ──
        public void get_FPS(){} // RVA: 0x7FFE812846C0
        public void get_FramesTotal(){} // RVA: 0x7FFE86DBA9B0
        public void get_NumDroppedFrames(){} // RVA: 0x7FFE811485C0
        public void set_NumDroppedFrames(){} // RVA: 0x7FFE810FE0C0
        public void get_NumDroppedEncoderFrames(){} // RVA: 0x7FFE8164B230
        public void set_NumDroppedEncoderFrames(){} // RVA: 0x7FFE8164E0F0
        public void get_NumEncodedFrames(){} // RVA: 0x7FFE813DB630
        public void set_NumEncodedFrames(){} // RVA: 0x7FFE8144DF00
        public void get_TotalEncodedSeconds(){} // RVA: 0x7FFE82707EE0
        public void set_TotalEncodedSeconds(){} // RVA: 0x7FFE82717690
        public void get_AudioCaptureSource(){} // RVA: 0x7FFE8151D690
        public void set_AudioCaptureSource(){} // RVA: 0x7FFE8170B670
        public void get_UnityAudioSampleRate(){} // RVA: 0x7FFE81A56130
        public void set_UnityAudioSampleRate(){} // RVA: 0x7FFE82447980
        public void get_UnityAudioChannelCount(){} // RVA: 0x7FFE81549710
        public void set_UnityAudioChannelCount(){} // RVA: 0x7FFE817E4800
        public void ResetFPS(){} // RVA: 0x7FFE86DBA9C0
        public void UpdateFPS(){} // RVA: 0x7FFE86DBA9D0
        public void .ctor(){} // RVA: 0x7FFE86DBAA50
    }

    public class Codec : Object
    {
        public 0x66671CDC _codecType; // 0x10
        public int _index; // 0x14
        public string _name; // 0x18
        public bool _hasConfigWindow; // 0x20
        public & _api; // 0x24

        // ── Methods ──
        public void get_CodecType(){} // RVA: 0x7FFE811485C0
        public void get_Index(){} // RVA: 0x7FFE8164B230
        public void get_Name(){} // RVA: 0x7FFE810FE7C0
        public void get_MediaApi(){} // RVA: 0x7FFE81A56130
        public void get_HasConfigwindow(){} // RVA: 0x7FFE811E99D0
        public void ShowConfigWindow(){} // RVA: 0x7FFE86DC5970
        public void .ctor(){} // RVA: 0x7FFE86DC5AD0
    }

    public class CodecList : Object
    {
        public RenderHeads.Media.AVProMovieCapture.Codec[] _codecs; // 0x10
        public object field_1; // 0x8B

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86DC5B50
        public void FindCodec(){} // RVA: 0x7FFE86DC5C50
        public void GetFirstWithMediaApi(){} // RVA: 0x7FFE86DC5D30
        public void GetEnumerator(){} // RVA: 0x7FFE82A39F20
        public void get_Codecs(){} // RVA: 0x7FFE81116380
        public void get_Count(){} // RVA: 0x7FFE81CCB610
    }

    public class CodecManager : Object
    {
        public bool _isEnumerated;
        public RenderHeads.Media.AVProMovieCapture.CodecList _videoCodecs; // 0x8

        // ── Methods ──
        public void FindCodec(){} // RVA: 0x7FFE86DC5D90
        public void GetCodecCount(){} // RVA: 0x7FFE86DC5EA0
        public void CheckInit(){} // RVA: 0x7FFE86DC5F10
        public void GetCodecs(){} // RVA: 0x7FFE86DC5FC0
        public void EnumerateCodecs(){} // RVA: 0x7FFE86DC6060
        public void get_VideoCodecs(){} // RVA: 0x7FFE86DC6A80
        public void get_AudioCodecs(){} // RVA: 0x7FFE86DC6AE0
        public void .cctor(){} // RVA: 0x7FFE86DC6B40
    }

    public class Device : Object
    {
        public 0x66671E3C _deviceType; // 0x10
        public int _index; // 0x14
        public string _name; // 0x18
        public & _api; // 0x20

        // ── Methods ──
        public void get_DeviceType(){} // RVA: 0x7FFE811485C0
        public void get_Index(){} // RVA: 0x7FFE8164B230
        public void get_Name(){} // RVA: 0x7FFE810FE7C0
        public void get_MediaApi(){} // RVA: 0x7FFE8151D690
        public void .ctor(){} // RVA: 0x7FFE86DC6D00
    }

    public class DeviceList : Object
    {
        public RenderHeads.Media.AVProMovieCapture.Device[] _devices; // 0x10
        public object field_1; // 0x96

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86DC6D70
        public void FindDevice(){} // RVA: 0x7FFE86DC6E70
        public void GetFirstWithMediaApi(){} // RVA: 0x7FFE86DC6F50
        public void GetEnumerator(){} // RVA: 0x7FFE82A39F20
        public void get_Devices(){} // RVA: 0x7FFE81116380
        public void get_Count(){} // RVA: 0x7FFE81CCB610
    }

    public class DeviceManager : Object
    {
        public bool _isEnumerated;

        // ── Methods ──
        public void FindDevice(){} // RVA: 0x7FFE86DC6FB0
        public void GetDeviceCount(){} // RVA: 0x7FFE86DC7100
        public void CheckInit(){} // RVA: 0x7FFE86DC71B0
        public void GetDevices(){} // RVA: 0x7FFE86DC7260
        public void EnumerateDevices(){} // RVA: 0x7FFE86DC72D0
        public void get_AudioInputDevices(){} // RVA: 0x7FFE86DC7630
        public void .cctor(){} // RVA: 0x7FFE86DC7690
    }

    public class EncoderHints : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86DBAB30
        public void SetDefaults(){} // RVA: 0x7FFE86DBAB30
    }

    public class FileWritingHandler : Object
    {
        public string _path; // 0x10
        public int _handle; // 0x18
        public bool _deleteFile; // 0x1C

        // ── Methods ──
        public void get_Status(){} // RVA: 0x7FFE8139DAD0
        public void get_Path(){} // RVA: 0x7FFE81116380
        public void get_CompletedFileWritingAction(){} // RVA: 0x7FFE81176D50
        public void set_CompletedFileWritingAction(){} // RVA: 0x7FFE81176D60
        public void .ctor(){} // RVA: 0x7FFE86DC7790
        public void SetFilePostProcess(){} // RVA: 0x7FFE86DC7870
        public void StartPostProcess(){} // RVA: 0x7FFE86DC78D0
        public void IsFileReady(){} // RVA: 0x7FFE86DC7A10
        public void Dispose(){} // RVA: 0x7FFE86DC7C10
        public void Cleanup(){} // RVA: 0x7FFE86DC7EC0
    }

    public class IMediaApiItem
    {
        // ── Methods ──
        public void get_Index(){} // RVA: 0x7FFE80E2EDB0
        public void get_Name(){} // RVA: 0x7FFE80E2E2E0
        public void get_MediaApi(){} // RVA: 0x7FFE80E2EDB0
    }

    public class ImageEncoderHints : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86DBAAE0
        public void SetDefaults(){} // RVA: 0x7FFE86DBAAE0
        public void Validate(){} // RVA: 0x7FFE86DBAB00
    }

    public class MP4FileProcessing : Object
    {
        // ── Methods ──
        public void ProcessFileAsync(){} // RVA: 0x7FFE86DC7FA0
        public void ProcessFile(){} // RVA: 0x7FFE86DC85D0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE86DC89D0
        public void Process(){} // RVA: 0x7FFE86DC8B80
        public void Close(){} // RVA: 0x7FFE86DC9680
        public void GetFirstChunkOfType(){} // RVA: 0x7FFE86DC9880
        public void ReadChildChunks(){} // RVA: 0x7FFE86DC9AD0 | overloaded x2
        public void ReadChunkHeader(){} // RVA: 0x7FFE86DC9CD0
        public void ChunkContainsChildChunkWithId(){} // RVA: 0x7FFE86DC9EB0
        public void ChunkDesc(){} // RVA: 0x7FFE86DCA020
        public void WriteChunk(){} // RVA: 0x7FFE86DCA360
        public void CopyChunkHeader(){} // RVA: 0x7FFE86DCA3E0
        public void InjectChunkHeader(){} // RVA: 0x7FFE86DCA460
        public void CopyBytes(){} // RVA: 0x7FFE86DCA4E0
        public void WriteZeros(){} // RVA: 0x7FFE86DCA5F0
        public void WriteChunkRecursive_moov(){} // RVA: 0x7FFE86DCA6A0
        public void IsVideoTrack(){} // RVA: 0x7FFE86DCADB0
        public void WriteChunk_stco(){} // RVA: 0x7FFE86DCAF00
        public void WriteChunk_co64_from_stco(){} // RVA: 0x7FFE86DCB000
        public void WriteChunk_co64(){} // RVA: 0x7FFE86DCB130
        public void InjectChunkStub_co64_from_stco(){} // RVA: 0x7FFE86DCB220
        public void WriteChunk_stsd(){} // RVA: 0x7FFE86DCB380
        public void Convert(){} // RVA: 0x7FFE86DCB890
        public void InjectChunk_st3d(){} // RVA: 0x7FFE86DCB8B0
        public void InjectChunk_sv3d(){} // RVA: 0x7FFE86DCB980
        public void InjectChunk_uuid_GoogleSphericalVideoV1(){} // RVA: 0x7FFE86DCBB10
        public void InjectChunk_svhd(){} // RVA: 0x7FFE86DCBDB0
        public void InjectChunk_proj(){} // RVA: 0x7FFE86DCC000
        public void InjectChunk_prhd(){} // RVA: 0x7FFE86DCC400
        public void InjectChunk_equi(){} // RVA: 0x7FFE86DCC570
        public void OverwriteChunkSize(){} // RVA: 0x7FFE86DCC6F0
        public void ReadUInt16(){} // RVA: 0x7FFE86DCC7B0
        public void ReadUInt32(){} // RVA: 0x7FFE86DCC8C0
        public void ReadUInt64(){} // RVA: 0x7FFE86DCC9D0
        public void WriteUInt16(){} // RVA: 0x7FFE86DCCAE0
        public void WriteChunkId(){} // RVA: 0x7FFE86DCCBD0
        public void WriteUInt32(){} // RVA: 0x7FFE86DCCBE0
        public void WriteUInt64(){} // RVA: 0x7FFE86DCCCE0
        public void ChunkIdToString(){} // RVA: 0x7FFE86DCCDD0
        public void ChunkId(){} // RVA: 0x7FFE86DCD050
        public void DebugLog(){} // RVA: 0x7FFE86DCD0A0
        public void .cctor(){} // RVA: 0x7FFE86DCD0F0
    }

    public class MotionBlur : MonoBehaviour
    {
        public 0x665759EC _format; // 0x20
        public int _numSamples; // 0x24
        public UnityEngine.RenderTexture _accum; // 0x28
        public UnityEngine.RenderTexture _lastComp; // 0x30

        // ── Methods ──
        public void get_IsFrameAccumulated(){} // RVA: 0x7FFE8286E5B0
        public void set_IsFrameAccumulated(){} // RVA: 0x7FFE82870520
        public void get_NumSamples(){} // RVA: 0x7FFE81A56130
        public void set_NumSamples(){} // RVA: 0x7FFE86DB18B0
        public void get_FrameCount(){} // RVA: 0x7FFE8119C0C0
        public void get_FinalTexture(){} // RVA: 0x7FFE8144E200
        public void Awake(){} // RVA: 0x7FFE86DB18C0
        public void SetTargetSize(){} // RVA: 0x7FFE86DB19E0
        public void Start(){} // RVA: 0x7FFE86DB1A00
        public void OnEnable(){} // RVA: 0x7FFE86DB1A10
        public void Setup(){} // RVA: 0x7FFE86DB1A30
        public void ClearAccumulation(){} // RVA: 0x7FFE86DB2250
        public void OnDestroy(){} // RVA: 0x7FFE86DB23A0
        public void OnNumSamplesChanged(){} // RVA: 0x7FFE86DB28C0
        public void LerpUnclamped(){} // RVA: 0x7FFE86DB2A40
        public void ApplyWeighting(){} // RVA: 0x7FFE86DB2A50
        public void Accumulate(){} // RVA: 0x7FFE86DB2BD0
        public void OnRenderImage(){} // RVA: 0x7FFE86DB2CC0
        public void .ctor(){} // RVA: 0x7FFE86DB2D40
    }

    public class MouseCursor : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFE86DB2DA0
        public void SetTexture(){} // RVA: 0x7FFE86DB2DB0
        public void OnGUI(){} // RVA: 0x7FFE86DB2FB0
        public void .ctor(){} // RVA: 0x7FFE86DB3260
    }

    public class NativePlugin : Object
    {
        public string ScriptVersion;
        public string ExpectedPluginVersion;

        // ── Methods ──
        public void AddAmbisonicSourceInstance(){} // RVA: 0x7FFE86DB6A30
        public void RemoveAmbisonicSourceInstance(){} // RVA: 0x7FFE86DB6AB0
        public void UpdateAmbisonicWeights(){} // RVA: 0x7FFE86DB6B30
        public void EncodeMonoToAmbisonic(){} // RVA: 0x7FFE86DB6C00
        public void RenderThreadEvent(){} // RVA: 0x7FFE86DB6CE0
        public void get_RenderCaptureEventFunction(){} // RVA: 0x7FFE86DB6F70
        public void get_RenderFreeEventFunction(){} // RVA: 0x7FFE86DB7080
        public void GetRenderEventFunc(){} // RVA: 0x7FFE86DB7190
        public void GetFreeResourcesEventFunc(){} // RVA: 0x7FFE86DB7200
        public void Init(){} // RVA: 0x7FFE86DB7270
        public void Deinit(){} // RVA: 0x7FFE86DB72E0
        public void SetMicrophoneRecordingHint(){} // RVA: 0x7FFE86DB7350
        public void GetPluginVersionString(){} // RVA: 0x7FFE86DB73E0
        public void IsTrialVersion(){} // RVA: 0x7FFE86DB74E0
        public void IsBasicEdition(){} // RVA: 0x7FFE86DB7550
        public void GetVideoCodecCount(){} // RVA: 0x7FFE86DB7780
        public void IsConfigureVideoCodecSupported(){} // RVA: 0x7FFE86DB77F0
        public void GetVideoCodecMediaApi(){} // RVA: 0x7FFE86DB7870
        public void ConfigureVideoCodec(){} // RVA: 0x7FFE86DB78F0
        public void GetVideoCodecName(){} // RVA: 0x7FFE86DB90B0 | overloaded x2
        public void GetAudioCodecCount(){} // RVA: 0x7FFE86DB7B50
        public void IsConfigureAudioCodecSupported(){} // RVA: 0x7FFE86DB7BC0
        public void GetAudioCodecMediaApi(){} // RVA: 0x7FFE86DB7C40
        public void ConfigureAudioCodec(){} // RVA: 0x7FFE86DB7CC0
        public void GetAudioCodecName(){} // RVA: 0x7FFE86DB9180 | overloaded x2
        public void GetAudioInputDeviceCount(){} // RVA: 0x7FFE86DB7F20
        public void GetAudioInputDeviceName(){} // RVA: 0x7FFE86DB9250 | overloaded x2
        public void GetAudioInputDeviceMediaApi(){} // RVA: 0x7FFE86DB8170
        public void GetContainerFileExtensions(){} // RVA: 0x7FFE86DB9320 | overloaded x2
        public void CreateRecorderVideo(){} // RVA: 0x7FFE86DB84B0
        public void CreateRecorderImages(){} // RVA: 0x7FFE86DB85C0
        public void CreateRecorderPipe(){} // RVA: 0x7FFE86DB86D0
        public void Start(){} // RVA: 0x7FFE86DB87C0
        public void IsNewFrameDue(){} // RVA: 0x7FFE86DB8840
        public void SetEncodedFrameLimit(){} // RVA: 0x7FFE86DB88C0
        public void EncodeFrame(){} // RVA: 0x7FFE86DB8950
        public void EncodeAudio(){} // RVA: 0x7FFE86DB89E0
        public void EncodeFrameWithAudio(){} // RVA: 0x7FFE86DB8A80
        public void Pause(){} // RVA: 0x7FFE86DB8B20
        public void Stop(){} // RVA: 0x7FFE86DB8BA0
        public void IsFileWritingComplete(){} // RVA: 0x7FFE86DB8C30
        public void SetTexturePointer(){} // RVA: 0x7FFE86DB8CB0
        public void FreeRecorder(){} // RVA: 0x7FFE86DB8D40
        public void GetNumDroppedFrames(){} // RVA: 0x7FFE86DB8DC0
        public void GetNumDroppedEncoderFrames(){} // RVA: 0x7FFE86DB8E40
        public void GetNumEncodedFrames(){} // RVA: 0x7FFE86DB8EC0
        public void GetEncodedSeconds(){} // RVA: 0x7FFE86DB8F40
        public void GetFileSize(){} // RVA: 0x7FFE86DB8FC0
        public void GetPluginVersion(){} // RVA: 0x7FFE86DB9040
        public void SetLogFunction(){} // RVA: 0x7FFE86DB9400
        public void SetErrorHandler(){} // RVA: 0x7FFE86DB9480
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE86DB9510
    }

    public class TimelineController : MonoBehaviour
    {
        public 0x66670F1C _scanFrequency; // 0x20

        // ── Methods ──
        public void get_ScanFrequency(){} // RVA: 0x7FFE8151D690
        public void set_ScanFrequency(){} // RVA: 0x7FFE86DB3300
        public void Awake(){} // RVA: 0x7FFE86DB3310
        public void OnValidate(){} // RVA: 0x7FFE86DB3310
        public void UpdateFrame(){} // RVA: 0x7FFE86DB3320
        public void StartCapture(){} // RVA: 0x7FFE86DB3330
        public void StopCapture(){} // RVA: 0x7FFE86DB3490
        public void ScanForPlayableDirectors(){} // RVA: 0x7FFE86DB3710
        public void OnDestroy(){} // RVA: 0x7FFE86DB3A90
        public void ResetSceneLoading(){} // RVA: 0x7FFE86DB3B40
        public void OnSceneLoaded(){} // RVA: 0x7FFE86DB3C30
        public void .ctor(){} // RVA: 0x7FFE86DB3C40
    }

    public class UnityAudioCapture : MonoBehaviour
    {
        // ── Methods ──
        public void get_OverflowCount(){} // RVA: 0x7FFE813240E0
        public void get_SampleRate(){} // RVA: 0x7FFE80E2EDB0
        public void get_ChannelCount(){} // RVA: 0x7FFE80E2EDB0
        public void PrepareCapture(){} // RVA: 0x7FFE80E45FE0
        public void StartCapture(){} // RVA: 0x7FFE80E45FE0
        public void StopCapture(){} // RVA: 0x7FFE80E45FE0
        public void FlushBuffer(){} // RVA: 0x7FFE80E45FE0
        public void ReadData(){} // RVA: 0x7FFE86DB41E0
        public void GetUnityAudioChannelCount(){} // RVA: 0x7FFE86DB41F0
        public void GetChannelCount(){} // RVA: 0x7FFE86DB4330
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class Utils : Object
    {
        // ── Methods ──
        public void GetNativeImageSequenceFormatNames(){} // RVA: 0x7FFE86DCDA90
        public void HasAlphaChannel(){} // RVA: 0x7FFE86DCDB10
        public void GetBestRenderTextureFormat(){} // RVA: 0x7FFE86DCDB80
        public void GetUltimateRenderCamera(){} // RVA: 0x7FFE86DCDF50
        public void HasContributingCameras(){} // RVA: 0x7FFE86DCE230
        public void FindContributingCameras(){} // RVA: 0x7FFE86DCE390
        public void URLEscapePathByPercentEncoding(){} // RVA: 0x7FFE86DCEB90
        public void ShowInExplorer(){} // RVA: 0x7FFE86DCEFF0
        public void OpenInDefaultApp(){} // RVA: 0x7FFE86DCF150
        public void GetFileSize(){} // RVA: 0x7FFE86DCF2D0
        public void GetDiskFreeSpaceEx(){} // RVA: 0x7FFE86DCF350
        public void DriveFreeBytes(){} // RVA: 0x7FFE86DCF420
        public void GetImageFileExtension(){} // RVA: 0x7FFE86DCF5C0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE86DCF690
    }

    public class VideoEncoderHints : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86DBAA60
        public void SetDefaults(){} // RVA: 0x7FFE86DBAA60
        public void Validate(){} // RVA: 0x7FFE86DBAAB0
    }

    public class VideoPlayerController : MonoBehaviour
    {
        public 0x6667107C _scanFrequency; // 0x20

        // ── Methods ──
        public void get_ScanFrequency(){} // RVA: 0x7FFE8151D690
        public void set_ScanFrequency(){} // RVA: 0x7FFE86DB43A0
        public void Awake(){} // RVA: 0x7FFE86DB43B0
        public void Start(){} // RVA: 0x7FFE810FB310
        public void OnValidate(){} // RVA: 0x7FFE86DB43B0
        public void Update(){} // RVA: 0x7FFE810FB310
        public void UpdateFrame(){} // RVA: 0x7FFE86DB43C0
        public void CanContinue(){} // RVA: 0x7FFE86DB45B0
        public void WaitforSeekCompletes(){} // RVA: 0x7FFE86DB4730
        public void WaitforSeekCompletes2(){} // RVA: 0x7FFE810FB310
        public void StartCapture(){} // RVA: 0x7FFE86DB47D0
        public void StopCapture(){} // RVA: 0x7FFE86DB4A40
        public void ScanForVideoPlayers(){} // RVA: 0x7FFE86DB4C80
        public void OnDestroy(){} // RVA: 0x7FFE86DB5070
        public void ResetSceneLoading(){} // RVA: 0x7FFE86DB5120
        public void OnSceneLoaded(){} // RVA: 0x7FFE86DB5210
        public void .ctor(){} // RVA: 0x7FFE86DB5220
        public void <WaitforSeekCompletes>b__13_0(){} // RVA: 0x7FFE86DB5390
    }

    public class WavWriter : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86DCFEE0
        public void Dispose(){} // RVA: 0x7FFE86DD0070
        public void WriteInterleaved(){} // RVA: 0x7FFE86DD0140
        public void WriteHeader(){} // RVA: 0x7FFE86DD04C0
        public void PackageInt(){} // RVA: 0x7FFE86DD0B90
        public void .cctor(){} // RVA: 0x7FFE86DD0CA0
    }

}