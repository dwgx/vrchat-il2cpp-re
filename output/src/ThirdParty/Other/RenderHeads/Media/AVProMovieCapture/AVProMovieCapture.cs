// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.RenderHeads.Media.AVProMovieCapture
// Classes: 38
// Methods: 684

namespace ThirdParty.Other.RenderHeads.Media.AVProMovieCapture
{
    public class Ambisonic
    {
        // ── Methods ──
        public void GetNormalisationWeights(){} // RVA: 0x62792D0
        public void GetCoeffCount(){} // RVA: 0x6279360
        public void GetChannelOrder(){} // RVA: 0x6279390
        public void GetNormalisation(){} // RVA: 0x6279390
        public void .cctor(){} // RVA: 0x62793A0
        public void BuildWeightsFuMa(){} // RVA: 0x6279640
        public void GetN(){} // RVA: 0x6279910
        public void GetM(){} // RVA: 0x6279950
        public void Factorial(){} // RVA: 0x62799D0
        public void GetNormalisationSN3D(){} // RVA: 0x6279AE0 | overloaded x2
        public void GetNormalisationN3D(){} // RVA: 0x6279C60
        public void BuildWeightsSN3D(){} // RVA: 0x6279D10
    }

    public class AmbisonicSource
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x62540A0
        public void OnDisable(){} // RVA: 0x62544D0
        public void Setup(){} // RVA: 0x62547A0
        public void OnDrawGizmos(){} // RVA: 0x6254AF0
        public void LateUpdate(){} // RVA: 0x6254E00
        public void SetListenerRelativePosition(){} // RVA: 0x6255090
        public void UpdateCoefficients(){} // RVA: 0x62550B0
        public void OnAudioFilterRead(){} // RVA: 0x6255470
        public void FlushBuffers(){} // RVA: 0x6255B20
        public void GetFullBufferCount(){} // RVA: 0x6255EF0
        public void SendSamplesToSink(){} // RVA: 0x6255F40
        public void .ctor(){} // RVA: 0x6256200
    }

    public class AmbisonicWavWriter
    {
        public RenderHeads.Media.AVProMovieCapture.CaptureBase _capture; // 0x20
        public 0x6599A610 _order; // 0x28

        // ── Methods ──
        public void get_Order(){} // RVA: 0x791DC0
        public void get_Format(){} // RVA: 0x1209F00
        public void AddSource(){} // RVA: 0x62563C0
        public void RemoveSource(){} // RVA: 0x6256590
        public void OnDisable(){} // RVA: 0x6256710
        public void SetupSource(){} // RVA: 0x6256720
        public void ToggleCapturing(){} // RVA: 0x62567D0
        public void StartCapture(){} // RVA: 0x6256800
        public void StopCapture(){} // RVA: 0x6256F30
        public void IsCapturing(){} // RVA: 0x6257160
        public void LateUpdate(){} // RVA: 0x6257180
        public void ProcessSources(){} // RVA: 0x62572A0
        public void MixSamples(){} // RVA: 0x62575B0
        public void FlushWavWriter(){} // RVA: 0x62576D0
        public void .ctor(){} // RVA: 0x6257710
    }

    public class AudioSourceToWav
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x6257910
        public void OnDisable(){} // RVA: 0x6257B30
        public void OnAudioFilterRead(){} // RVA: 0x6257BB0
        public void .ctor(){} // RVA: 0x6257BE0
    }

    public class CameraSelector
    {
        public 0x65999AB8 _selectBy; // 0x20
        public 0x65999B10 _scanFrequency; // 0x24
        public bool _scanHiddenCameras; // 0x28
        public string _tag; // 0x30
        public string _name; // 0x38
        public UnityEngine.Camera _camera; // 0x40

        // ── Methods ──
        public void get_Camera(){} // RVA: 0x35A740
        public void set_Camera(){} // RVA: 0x6257CB0
        public void get_SelectBy(){} // RVA: 0x760030
        public void set_SelectBy(){} // RVA: 0x6257D20
        public void get_ScanFrequency(){} // RVA: 0xCEF5B0
        public void set_ScanFrequency(){} // RVA: 0x6257D30
        public void get_ScanHiddenCameras(){} // RVA: 0x6E8A80
        public void set_ScanHiddenCameras(){} // RVA: 0x6257D40
        public void get_SelectTag(){} // RVA: 0x6374D0
        public void set_SelectTag(){} // RVA: 0x6257D50
        public void get_SelectName(){} // RVA: 0x4976A0
        public void set_SelectName(){} // RVA: 0x6257DB0
        public void Awake(){} // RVA: 0x6257E10
        public void Start(){} // RVA: 0x6257E20
        public void OnValidate(){} // RVA: 0x6257E10
        public void Update(){} // RVA: 0x6257E30
        public void OnDestroy(){} // RVA: 0x6257E50
        public void ResetSceneLoading(){} // RVA: 0x6257EF0
        public void OnSceneLoaded(){} // RVA: 0x6257FE0
        public void ScanForCameraChange(){} // RVA: 0x6257FF0
        public void FindCamera(){} // RVA: 0x6258220
        public void UpdateCameraCache(){} // RVA: 0x6258560
        public void FindCameraByHighestDepth(){} // RVA: 0x6258700
        public void FindCameraByTag(){} // RVA: 0x6258880
        public void FindCameraByName(){} // RVA: 0x6258910
        public void .ctor(){} // RVA: 0x62589D0
    }

    public class CaptureAudioFromAudioClip
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x6258BA0
        public void Update(){} // RVA: 0x6258F50
        public void GetAudioSamplesForFrame(){} // RVA: 0x6259060
        public void .ctor(){} // RVA: 0x892040
    }

    public class CaptureAudioFromAudioListener
    {
        public bool _debugLogging; // 0x20
        public bool _muteAudio; // 0x21
        public int BufferSize;
        public float[] _buffer; // 0x28
        public float[] _readBuffer; // 0x30
        public int _bufferIndex; // 0x38

        // ── Methods ──
        public void get_Buffer(){} // RVA: 0x6374D0
        public void get_BufferLength(){} // RVA: 0xFDC9F0
        public void get_BufferPtr(){} // RVA: 0x62593B0
        public void get_OverflowCount(){} // RVA: 0x1479960
        public void get_SampleRate(){} // RVA: 0x62593C0
        public void get_ChannelCount(){} // RVA: 0x37E0C0
        public void PrepareCapture(){} // RVA: 0x6259410
        public void StartCapture(){} // RVA: 0x37EF790
        public void StopCapture(){} // RVA: 0x6259990
        public void ReadData(){} // RVA: 0x6259BF0
        public void FlushBuffer(){} // RVA: 0x6259D80
        public void OnAudioFilterRead(){} // RVA: 0x6259EC0
        public void .ctor(){} // RVA: 0x625A230
    }

    public class CaptureAudioFromAudioRenderer
    {
        public RenderHeads.Media.AVProMovieCapture.CaptureBase _capture; // 0x20
        public int _unityAudioChannelCount; // 0x28
        public bool _isRendererRecording; // 0x2C

        // ── Methods ──
        public void get_Capture(){} // RVA: 0x30B0C0
        public void set_Capture(){} // RVA: 0x30B0D0
        public void get_SampleRate(){} // RVA: 0x62593C0
        public void get_ChannelCount(){} // RVA: 0x791DC0
        public void PrepareCapture(){} // RVA: 0x625A3E0
        public void GetAudioBufferOfLength(){} // RVA: 0x625A400
        public void DisposeAudioBuffer(){} // RVA: 0x2DD310
        public void StartCapture(){} // RVA: 0x625A5D0
        public void StopCapture(){} // RVA: 0x625A840
        public void FlushBuffer(){} // RVA: 0x625A8D0
        public void Update(){} // RVA: 0x625A9C0
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class CaptureAudioFromWwise
    {
        public RenderHeads.Media.AVProMovieCapture.CaptureBase _capture; // 0x20

        // ── Methods ──
        public void get_Capture(){} // RVA: 0x30B0C0
        public void set_Capture(){} // RVA: 0x30B0D0
        public void Awake(){} // RVA: 0x625AB80
        public void get_SampleRate(){} // RVA: 0x519240
        public void get_ChannelCount(){} // RVA: 0x519240
        public void PrepareCapture(){} // RVA: 0x2DD310
        public void FlushBuffer(){} // RVA: 0x2DD310
        public void StartCapture(){} // RVA: 0x2DD310
        public void StopCapture(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class CaptureBase
    {
        public string DocEditionsURL;
        public RenderHeads.Media.AVProMovieCapture.EncoderHints _encoderHintsWindows; // 0x20
        public RenderHeads.Media.AVProMovieCapture.EncoderHints _encoderHintsMacOS; // 0x28
        public RenderHeads.Media.AVProMovieCapture.EncoderHints _encoderHintsIOS; // 0x30
        public RenderHeads.Media.AVProMovieCapture.EncoderHints _encoderHintsAndroid; // 0x38
        public 0x658991A8 _captureKey; // 0x40
        public bool _isRealTime; // 0x44
        public bool _persistAcrossSceneLoads; // 0x45
        public 0x6599B848 _startTrigger; // 0x48
        public 0x6599B8A0 _startDelay; // 0x4C
        public float _startDelaySeconds; // 0x50
        public 0x6599B7F0 _stopMode; // 0x54
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
        public 0x6599AE50 _frameUpdateMode; // 0x98
        public 0x6599ADA0 _downScale; // 0x9C
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
        public 0x6599B6E8 _audioCaptureSource; // 0xD0
        public RenderHeads.Media.AVProMovieCapture.UnityAudioCapture _unityAudioCapture; // 0xD8
        public int _forceAudioInputDeviceIndex; // 0xE0
        public int _manualAudioSampleRate; // 0xE4
        public int _manualAudioChannelCount; // 0xE8
        public 0x6599B950 _outputTarget; // 0xEC
        public 0x6599ADF8 DefaultOutputFolderType;
        public string DefaultOutputFolderPath;
        public 0x6599ADF8 _outputFolderType; // 0xF0
        public string _outputFolderPath; // 0xF8

        // ── Methods ──
        public void get_OutputTarget(){} // RVA: 0x1CA9B70
        public void set_OutputTarget(){} // RVA: 0x627A280
        public void get_OutputFolder(){} // RVA: 0x3739380
        public void set_OutputFolder(){} // RVA: 0x627A290
        public void get_OutputFolderPath(){} // RVA: 0x7F7DB0
        public void set_OutputFolderPath(){} // RVA: 0x63D280
        public void get_FilenamePrefix(){} // RVA: 0xA94E10
        public void set_FilenamePrefix(){} // RVA: 0xCF6DE0
        public void get_AppendFilenameTimestamp(){} // RVA: 0x1702E10
        public void set_AppendFilenameTimestamp(){} // RVA: 0x1702E20
        public void get_AllowManualFileExtension(){} // RVA: 0x1B6CD40
        public void set_AllowManualFileExtension(){} // RVA: 0x1B6CF40
        public void get_FilenameExtension(){} // RVA: 0x507710
        public void set_FilenameExtension(){} // RVA: 0x509930
        public void get_NamedPipePath(){} // RVA: 0x507D10
        public void set_NamedPipePath(){} // RVA: 0x50A8C0
        public void get_ImageSequenceStartFrame(){} // RVA: 0xD19990
        public void set_ImageSequenceStartFrame(){} // RVA: 0x627A2A0
        public void get_ImageSequenceZeroDigits(){} // RVA: 0x613D7A0
        public void set_ImageSequenceZeroDigits(){} // RVA: 0x627A2B0
        public void get_UseMotionBlur(){} // RVA: 0x167DAF0
        public void set_UseMotionBlur(){} // RVA: 0x1686780
        public void get_MotionBlurSamples(){} // RVA: 0x627A2E0
        public void set_MotionBlurSamples(){} // RVA: 0x627A2F0
        public void get_MotionBlurCameras(){} // RVA: 0x9FE130
        public void set_MotionBlurCameras(){} // RVA: 0xD8E9B0
        public void get_MotionBlur(){} // RVA: 0xD8A610
        public void set_MotionBlur(){} // RVA: 0xD95D10
        public void get_ActiveFilePaths(){} // RVA: 0x627A320
        public void get_LastFilePath(){} // RVA: 0xA974D0
        public void get_BeginFinalFileWritingAction(){} // RVA: 0xD9E9A0
        public void set_BeginFinalFileWritingAction(){} // RVA: 0xD9F490
        public void get_CompletedFileWritingAction(){} // RVA: 0xD971B0
        public void set_CompletedFileWritingAction(){} // RVA: 0xD85210
        public void get_Stats(){} // RVA: 0xD88BD0
        public void get_CameraRenderResolution(){} // RVA: 0x120A360
        public void set_CameraRenderResolution(){} // RVA: 0x612FB30
        public void get_CameraRenderCustomResolution(){} // RVA: 0x627A380
        public void set_CameraRenderCustomResolution(){} // RVA: 0x627A3A0
        public void get_CameraRenderAntiAliasing(){} // RVA: 0x15FEA80
        public void set_CameraRenderAntiAliasing(){} // RVA: 0x15FE850
        public void get_IsRealTime(){} // RVA: 0x1AF8C70
        public void set_IsRealTime(){} // RVA: 0x1AF8C60
        public void get_PersistAcrossSceneLoads(){} // RVA: 0x1C90FC0
        public void set_PersistAcrossSceneLoads(){} // RVA: 0x1C90FD0
        public void get_AudioCaptureSource(){} // RVA: 0xA50BB0
        public void set_AudioCaptureSource(){} // RVA: 0x1AE7FE0
        public void get_ManualAudioSampleRate(){} // RVA: 0x1CAC8E0
        public void set_ManualAudioSampleRate(){} // RVA: 0x3DF13F0
        public void get_ManualAudioChannelCount(){} // RVA: 0x1CAC8F0
        public void set_ManualAudioChannelCount(){} // RVA: 0x627A3B0
        public void get_UnityAudioCapture(){} // RVA: 0xA96D30
        public void set_UnityAudioCapture(){} // RVA: 0x35E8A0
        public void get_ForceAudioInputDeviceIndex(){} // RVA: 0x1D12470
        public void set_ForceAudioInputDeviceIndex(){} // RVA: 0x627A3C0
        public void get_FrameRate(){} // RVA: 0x345540
        public void set_FrameRate(){} // RVA: 0x627A3D0
        public void get_StartTrigger(){} // RVA: 0x37E0C0
        public void set_StartTrigger(){} // RVA: 0x37E0D0
        public void get_StartDelay(){} // RVA: 0x1479960
        public void set_StartDelay(){} // RVA: 0x1D75D90
        public void get_StartDelaySeconds(){} // RVA: 0x345460
        public void set_StartDelaySeconds(){} // RVA: 0x627A400
        public void get_StopMode(){} // RVA: 0xC5BE80
        public void set_StopMode(){} // RVA: 0xC5BE70
        public void get_StopAfterFramesElapsed(){} // RVA: 0x9EAB90
        public void set_StopAfterFramesElapsed(){} // RVA: 0x627A410
        public void get_StopAfterSecondsElapsed(){} // RVA: 0x306000
        public void set_StopAfterSecondsElapsed(){} // RVA: 0x627A420
        public void get_CaptureStats(){} // RVA: 0xD88BD0
        public void get_VideoCodecPriorityWindows(){} // RVA: 0x37B370
        public void set_VideoCodecPriorityWindows(){} // RVA: 0x627A430
        public void get_VideoCodecPriorityMacOS(){} // RVA: 0x358D50
        public void set_VideoCodecPriorityMacOS(){} // RVA: 0x627A490
        public void get_AudioCodecPriorityWindows(){} // RVA: 0x4C7C50
        public void set_AudioCodecPriorityWindows(){} // RVA: 0x627A4F0
        public void get_AudioCodecPriorityMacOS(){} // RVA: 0x462D00
        public void set_AudioCodecPriorityMacOS(){} // RVA: 0x627A550
        public void get_TimelapseScale(){} // RVA: 0x6AFD30
        public void set_TimelapseScale(){} // RVA: 0x8DF350
        public void get_FrameUpdate(){} // RVA: 0x1D76570
        public void set_FrameUpdate(){} // RVA: 0x1D76000
        public void get_ResolutionDownScale(){} // RVA: 0x1D76560
        public void set_ResolutionDownScale(){} // RVA: 0x1D76580
        public void get_ResolutionDownscaleCustom(){} // RVA: 0x627A5B0
        public void set_ResolutionDownscaleCustom(){} // RVA: 0x5FF62E0
        public void get_FlipVertically(){} // RVA: 0x126AF80
        public void set_FlipVertically(){} // RVA: 0x126BEE0
        public void get_UseWaitForEndOfFrame(){} // RVA: 0x627A5D0
        public void set_UseWaitForEndOfFrame(){} // RVA: 0x627A5E0
        public void get_LogCaptureStartStop(){} // RVA: 0x4FDE70
        public void set_LogCaptureStartStop(){} // RVA: 0x627A5F0
        public void get_AllowOfflineVSyncDisable(){} // RVA: 0x627A600
        public void set_AllowOfflineVSyncDisable(){} // RVA: 0x627A610
        public void get_SupportTextureRecreate(){} // RVA: 0x627A620
        public void set_SupportTextureRecreate(){} // RVA: 0x627A630
        public void get_TimelineController(){} // RVA: 0xD93DD0
        public void set_TimelineController(){} // RVA: 0xD93D70
        public void get_VideoPlayerController(){} // RVA: 0x830040
        public void set_VideoPlayerController(){} // RVA: 0xD8E320
        public void get_SelectedVideoCodec(){} // RVA: 0xDB2150
        public void get_SelectedAudioCodec(){} // RVA: 0xA57F60
        public void get_SelectedAudioInputDevice(){} // RVA: 0xDA62D0
        public void get_NativeForceVideoCodecIndex(){} // RVA: 0xCC3CB0
        public void set_NativeForceVideoCodecIndex(){} // RVA: 0xCC9310
        public void get_NativeForceAudioCodecIndex(){} // RVA: 0x1896340
        public void set_NativeForceAudioCodecIndex(){} // RVA: 0x1896350
        public void get_NativeImageSequenceFormat(){} // RVA: 0x627A640
        public void set_NativeImageSequenceFormat(){} // RVA: 0x627A650
        public void GetCurrentPlatform(){} // RVA: 0x519240
        public void GetEncoderHints(){} // RVA: 0x627A660
        public void SetEncoderHints(){} // RVA: 0x627A710
        public void UpdateMediaGallery(){} // RVA: 0x2DD310
        public void Awake(){} // RVA: 0x627A930
        public void .cctor(){} // RVA: 0x627AF60
        public void Start(){} // RVA: 0x627BA80
        public void SelectCodec(){} // RVA: 0x627BBB0
        public void SelectVideoCodec(){} // RVA: 0x627BF60
        public void SelectAudioCodec(){} // RVA: 0x627C140
        public void SelectAudioInputDevice(){} // RVA: 0x627C2B0
        public void GetRecordingResolution(){} // RVA: 0x627C510
        public void SelectRecordingResolution(){} // RVA: 0x627C5E0
        public void OnDestroy(){} // RVA: 0x627C6F0
        public void FreePendingFileWrites(){} // RVA: 0x627CA60
        public void OnApplicationQuit(){} // RVA: 0x627CC00
        public void OnApplicationPause(){} // RVA: 0x2DD310
        public void EncodeTexture(){} // RVA: 0x627CC60
        public void IsUsingUnityAudioComponent(){} // RVA: 0x627CD70
        public void IsUsingMotionBlur(){} // RVA: 0x627CE70
        public void EncodePointer(){} // RVA: 0x627CF60
        public void IsPrepared(){} // RVA: 0x627D0F0
        public void IsCapturing(){} // RVA: 0x627D100
        public void IsPaused(){} // RVA: 0x627D110
        public void GetRecordingWidth(){} // RVA: 0x627D120
        public void GetRecordingHeight(){} // RVA: 0x627D130
        public void GenerateTimestampedFilename(){} // RVA: 0x627D140
        public void GetFolder(){} // RVA: 0x627D420
        public void GenerateFilePath(){} // RVA: 0x627D600
        public void HasExtension(){} // RVA: 0x627D6A0
        public void GenerateFilename(){} // RVA: 0x627D7F0
        public void FindOrCreateUnityAudioCapture(){} // RVA: 0x627DFE0
        public void ValidateEditionFeatures(){} // RVA: 0x627E680
        public void PrepareCapture(){} // RVA: 0x627EDB0
        public void QueueStartCapture(){} // RVA: 0x6280AD0
        public void IsStartCaptureQueued(){} // RVA: 0x6280B70
        public void UpdateInjectionOptions(){} // RVA: 0x6280B80
        public void StartCapture(){} // RVA: 0x6280C10
        public void PauseCapture(){} // RVA: 0x62810D0
        public void ResumeCapture(){} // RVA: 0x6281210
        public void CancelCapture(){} // RVA: 0x6281320
        public void DeleteCapture(){} // RVA: 0x6281350
        public void UnprepareCapture(){} // RVA: 0x2DD310
        public void get_LastFileSaved(){} // RVA: 0x6281460
        public void set_LastFileSaved(){} // RVA: 0x6281510
        public void RenderThreadEvent(){} // RVA: 0x6281560
        public void StopCapture(){} // RVA: 0x62815D0
        public void CreatePostOperationsOptions(){} // RVA: 0x6282300
        public void CanApplyPostOperations(){} // RVA: 0x62823D0
        public void ApplyPostOperations(){} // RVA: 0x62825C0
        public void ToggleCapture(){} // RVA: 0x62827F0
        public void IsEnoughDiskSpace(){} // RVA: 0x6282830
        public void CanContinue(){} // RVA: 0x6282870
        public void Update(){} // RVA: 0x6282990
        public void LateUpdate(){} // RVA: 0x6282A00
        public void RemoveCompletedFileWrites(){} // RVA: 0x6282D30
        public void CheckFreeDiskSpace(){} // RVA: 0x6282E10
        public void IsStartDelayComplete(){} // RVA: 0x6282ED0
        public void IsStopTimeReached(){} // RVA: 0x6282F00
        public void GetProgress(){} // RVA: 0x6282FF0
        public void GetSecondsPerCaptureFrame(){} // RVA: 0x62830B0
        public void CanOutputFrame(){} // RVA: 0x62830E0
        public void TickFrameTimer(){} // RVA: 0x6283310
        public void RenormTimer(){} // RVA: 0x6283380
        public void GetPreviewTexture(){} // RVA: 0x519240
        public void EncodeUnityAudio(){} // RVA: 0x62833D0
        public void EncodeAudio(){} // RVA: 0x6283520 | overloaded x2
        public void PreUpdateFrame(){} // RVA: 0x6283780
        public void UpdateFrame(){} // RVA: 0x6283960
        public void ResetFPS(){} // RVA: 0x6283CA0
        public void UpdateFPS(){} // RVA: 0x6283CD0
        public void GetCameraAntiAliasingLevel(){} // RVA: 0x6283D60
        public void GetCaptureFileSize(){} // RVA: 0x6283FD0
        public void GetResolution(){} // RVA: 0x62840E0
        public void NextMultipleOf4(){} // RVA: 0x14069B0
        public void HasUserAuthorisationToCaptureAudio(){} // RVA: 0x6284260
        public void RequestUserAuthorisationToCaptureAudioCallback(){} // RVA: 0x6284340
        public void RequestAudioCaptureDeviceUserAuthorisation(){} // RVA: 0x519240
        public void HasUserAuthorisationToAccessPhotos(){} // RVA: 0x62843C0
        public void RequestUserAuthorisationToAccessPhotosCallback(){} // RVA: 0x62844A0
        public void RequestUserAuthorisationToAccessPhotos(){} // RVA: 0x519240
        public void .ctor(){} // RVA: 0x6284520
    }

    public class CaptureFromCamera
    {
        public RenderHeads.Media.AVProMovieCapture.CameraSelector _cameraSelector; // 0x220
        public UnityEngine.Camera _lastCamera; // 0x228

        // ── Methods ──
        public void get_CameraSelector(){} // RVA: 0xD915D0
        public void set_CameraSelector(){} // RVA: 0xD93180
        public void get_UseContributingCameras(){} // RVA: 0x625ABE0
        public void set_UseContributingCameras(){} // RVA: 0x625ABF0
        public void SetCamera(){} // RVA: 0x625AF60 | overloaded x2
        public void RequiresResolve(){} // RVA: 0x625B020
        public void HasCamera(){} // RVA: 0x625B150
        public void HasContributingCameras(){} // RVA: 0x625B220
        public void UpdateFrame(){} // RVA: 0x625B250
        public void FinalRenderCapture(){} // RVA: 0x625B540
        public void Capture(){} // RVA: 0x625B5E0
        public void RequiresHDR(){} // RVA: 0x625B680
        public void UpdateTexture(){} // RVA: 0x625B860
        public void UnprepareCapture(){} // RVA: 0x625C1E0
        public void CreateResolveTexture(){} // RVA: 0x625C410
        public void GetPreviewTexture(){} // RVA: 0xD973A0
        public void PrepareCapture(){} // RVA: 0x625C8C0
        public void OnDestroy(){} // RVA: 0x625D440
        public void .ctor(){} // RVA: 0x625D730
        public void <>n__0(){} // RVA: 0x625D790
    }

    public class CaptureFromCamera360
    {
        public RenderHeads.Media.AVProMovieCapture.CameraSelector _cameraSelector; // 0x220
        public 0x6599ACF0 _cubemapResolution; // 0x228
        public 0x6599AC98 _cubemapDepth; // 0x22C
        public bool _supportGUI; // 0x230
        public bool _supportCameraRotation; // 0x231
        public bool _onlyLeftRightRotation; // 0x232
        public bool _render180Degrees; // 0x233
        public 0x6599B740 _stereoRendering; // 0x234
        public float _ipd; // 0x238

        // ── Methods ──
        public void get_CameraSelector(){} // RVA: 0xD915D0
        public void set_CameraSelector(){} // RVA: 0xD93180
        public void get_CubemapFaceResolution(){} // RVA: 0x1A40D00
        public void set_CubemapFaceResolution(){} // RVA: 0x1A40340
        public void get_CubemapDepthResolution(){} // RVA: 0x1A40AD0
        public void set_CubemapDepthResolution(){} // RVA: 0x1A41810
        public void get_SupportGUI(){} // RVA: 0x625DEA0
        public void set_SupportGUI(){} // RVA: 0x625DEB0
        public void get_SupportCameraRotation(){} // RVA: 0x625DEC0
        public void set_SupportCameraRotation(){} // RVA: 0x625DED0
        public void get_OnlyLeftRightRotation(){} // RVA: 0x625DEE0
        public void set_OnlyLeftRightRotation(){} // RVA: 0x625DEF0
        public void get_Render180Degrees(){} // RVA: 0x625DF00
        public void set_Render180Degrees(){} // RVA: 0x625DF10
        public void get_StereoRendering(){} // RVA: 0x1A3FF90
        public void set_StereoRendering(){} // RVA: 0x625DF20
        public void get_IPD(){} // RVA: 0x625DF30
        public void set_IPD(){} // RVA: 0x625DF40
        public void .ctor(){} // RVA: 0x625DF50
        public void GetCubemapRenderingMethod(){} // RVA: 0x625DFE0
        public void SetCamera(){} // RVA: 0xD9C4E0
        public void UpdateFrame(){} // RVA: 0x625E000
        public void FinalRenderCapture(){} // RVA: 0x625E2C0
        public void Capture(){} // RVA: 0x625E360
        public void ClearCubemap(){} // RVA: 0x625E800
        public void RenderCubemapToEquiRect(){} // RVA: 0x625ECB0
        public void UpdateTexture(){} // RVA: 0x625EE70
        public void RenderCameraToCubemap(){} // RVA: 0x625F6A0
        public void AccumulateMotionBlur(){} // RVA: 0x6261170
        public void PrepareCapture(){} // RVA: 0x6261330
        public void GetPreviewTexture(){} // RVA: 0x6262520
        public void Start(){} // RVA: 0x6262560
        public void OnDestroy(){} // RVA: 0x6262920
    }

    public class CaptureFromCamera360ODS
    {
        public Settings _settings; // 0x220

        // ── Methods ──
        public void get_Setup(){} // RVA: 0xD915D0
        public void .ctor(){} // RVA: 0x6262F00
        public void SetCamera(){} // RVA: 0x6263020
        public void Start(){} // RVA: 0x6263090
        public void CreateEye(){} // RVA: 0x62632C0
        public void UpdateFrame(){} // RVA: 0x62643C0
        public void FinalRenderCapture(){} // RVA: 0x62646B0
        public void Capture(){} // RVA: 0x6264750
        public void AccumulateMotionBlur(){} // RVA: 0x62649C0
        public void RenderFrame(){} // RVA: 0x6264B90
        public void GetPreviewTexture(){} // RVA: 0x6265830
        public void PrepareCapture(){} // RVA: 0x6265870
        public void DestroyEye(){} // RVA: 0x62669E0
        public void OnDestroy(){} // RVA: 0x6266C10
    }

    public class CaptureFromScreen
    {
        public bool _captureMouseCursor; // 0x220
        public RenderHeads.Media.AVProMovieCapture.MouseCursor _mouseCursor; // 0x228

        // ── Methods ──
        public void get_CaptureMouseCursor(){} // RVA: 0x6267370
        public void set_CaptureMouseCursor(){} // RVA: 0x6267380
        public void get_MouseCursor(){} // RVA: 0xD90650
        public void set_MouseCursor(){} // RVA: 0xD9F060
        public void PrepareCapture(){} // RVA: 0x6267390
        public void CopyRenderTargetToTexture(){} // RVA: 0x62676F0
        public void FreeRenderResources(){} // RVA: 0x6267D00
        public void UnprepareCapture(){} // RVA: 0x6267F20
        public void FinalRenderCapture(){} // RVA: 0x6268090
        public void UpdateFrame(){} // RVA: 0x6268130
        public void .ctor(){} // RVA: 0x62681F0
    }

    public class CaptureFromTexture
    {
        public bool _manualUpdate; // 0x220

        // ── Methods ──
        public void get_IsManualUpdate(){} // RVA: 0x6267370
        public void set_IsManualUpdate(){} // RVA: 0x6267380
        public void SetSourceTexture(){} // RVA: 0xD9F060
        public void RequiresResolve(){} // RVA: 0x6268410
        public void UpdateSourceTexture(){} // RVA: 0x6268540
        public void ShouldCaptureFrame(){} // RVA: 0x6268550
        public void HasSourceTextureChanged(){} // RVA: 0x6268640
        public void UpdateFrame(){} // RVA: 0x6268660
        public void FinalRenderCapture(){} // RVA: 0x6268730
        public void Capture(){} // RVA: 0x62687D0
        public void CreateResolveTexture(){} // RVA: 0x6268BE0
        public void AccumulateMotionBlur(){} // RVA: 0x6268F90
        public void GetPreviewTexture(){} // RVA: 0x62690B0
        public void PrepareCapture(){} // RVA: 0x6269220
        public void UnprepareCapture(){} // RVA: 0x6269610
        public void .ctor(){} // RVA: 0x62697E0
    }

    public class CaptureFromWebCamTexture
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x6269930
        public void .ctor(){} // RVA: 0x62697E0
    }

    public class CaptureGUI
    {
        public RenderHeads.Media.AVProMovieCapture.CaptureBase isPresent; // 0x20
        public bool isPositionTracked; // 0x28
        public bool isEnabled; // 0x29

        // ── Methods ──
        public void get_MovieCapture(){} // RVA: 0x30B0C0
        public void set_MovieCapture(){} // RVA: 0x30B0D0
        public void get_HideUiWhenRecording(){} // RVA: 0xC36000
        public void set_HideUiWhenRecording(){} // RVA: 0x190AB20
        public void get_ShowUI(){} // RVA: 0x6E8A80
        public void set_ShowUI(){} // RVA: 0x6E8B80
        public void Start(){} // RVA: 0x6269990
        public void CreateGUI(){} // RVA: 0x6269A70
        public void OnGUI(){} // RVA: 0x626A6D0
        public void MyWindow(){} // RVA: 0x626B1B0
        public void GUI_RecordingStatus(){} // RVA: 0x626DA30
        public void DrawPauseResumeButtons(){} // RVA: 0x626F4C0
        public void DrawGuiField(){} // RVA: 0x626FCE0
        public void StartCapture(){} // RVA: 0x626FDB0
        public void StopCapture(){} // RVA: 0x626FEB0
        public void CancelCapture(){} // RVA: 0x626FFB0
        public void ResumeCapture(){} // RVA: 0x62700B0
        public void PauseCapture(){} // RVA: 0x6270190
        public void Update(){} // RVA: 0x6270270
        public void .ctor(){} // RVA: 0x6270530
        public void .cctor(){} // RVA: 0x6270AF0
    }

    public class CaptureStats
    {
        public uint _numDroppedFrames; // 0x10
        public uint _numDroppedEncoderFrames; // 0x14
        public uint _numEncodedFrames; // 0x18
        public uint _totalEncodedSeconds; // 0x1C
        public 0x6599B6E8 _audioCaptureSource; // 0x20
        public int _unityAudioSampleRate; // 0x24
        public int _unityAudioChannelCount; // 0x28
        public float _fps; // 0x2C
        public int _frameTotal; // 0x30

        // ── Methods ──
        public void get_FPS(){} // RVA: 0x4652A0
        public void get_FramesTotal(){} // RVA: 0x6279F90
        public void get_NumDroppedFrames(){} // RVA: 0x32A5C0
        public void set_NumDroppedFrames(){} // RVA: 0x2E00C0
        public void get_NumDroppedEncoderFrames(){} // RVA: 0x8ABED0
        public void set_NumDroppedEncoderFrames(){} // RVA: 0x8AC660
        public void get_NumEncodedFrames(){} // RVA: 0x5BED50
        public void set_NumEncodedFrames(){} // RVA: 0x6374E0
        public void get_TotalEncodedSeconds(){} // RVA: 0x197C3B0
        public void set_TotalEncodedSeconds(){} // RVA: 0x1989FD0
        public void get_AudioCaptureSource(){} // RVA: 0x760030
        public void set_AudioCaptureSource(){} // RVA: 0x99E0D0
        public void get_UnityAudioSampleRate(){} // RVA: 0xCEF5B0
        public void set_UnityAudioSampleRate(){} // RVA: 0x16E1F00
        public void get_UnityAudioChannelCount(){} // RVA: 0x791DC0
        public void set_UnityAudioChannelCount(){} // RVA: 0xA53440
        public void ResetFPS(){} // RVA: 0x6279FA0
        public void UpdateFPS(){} // RVA: 0x6279FB0
        public void .ctor(){} // RVA: 0x627A030
    }

    public class Codec
    {
        public 0x6599B110 _codecType; // 0x10
        public int _index; // 0x14
        public string _name; // 0x18
        public bool _hasConfigWindow; // 0x20
        public 0x6599B0B8 _api; // 0x24

        // ── Methods ──
        public void get_CodecType(){} // RVA: 0x32A5C0
        public void get_Index(){} // RVA: 0x8ABED0
        public void get_Name(){} // RVA: 0x2E07C0
        public void get_MediaApi(){} // RVA: 0xCEF5B0
        public void get_HasConfigwindow(){} // RVA: 0x3CB9D0
        public void ShowConfigWindow(){} // RVA: 0x6284F40
        public void .ctor(){} // RVA: 0x62850A0
    }

    public class CodecList : .ctor
    {
        public RenderHeads.Media.AVProMovieCapture.Codec[] _codecs; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6285120
        public void FindCodec(){} // RVA: 0x6285220
        public void GetFirstWithMediaApi(){} // RVA: 0x6285300
        public void GetEnumerator(){} // RVA: 0x1CA8480
        public void get_Codecs(){} // RVA: 0x2F8380
        public void get_Count(){} // RVA: 0xF3F910
    }

    public class CodecManager
    {
        public bool MovieCapture;
        public RenderHeads.Media.AVProMovieCapture.CodecList HideUiWhenRecording; // 0x8

        // ── Methods ──
        public void FindCodec(){} // RVA: 0x6285360
        public void GetCodecCount(){} // RVA: 0x6285470
        public void CheckInit(){} // RVA: 0x62854E0
        public void GetCodecs(){} // RVA: 0x6285590
        public void EnumerateCodecs(){} // RVA: 0x6285630
        public void get_VideoCodecs(){} // RVA: 0x6286050
        public void get_AudioCodecs(){} // RVA: 0x62860B0
        public void .cctor(){} // RVA: 0x6286110
    }

    public class Device
    {
        public 0x6599B270 _deviceType; // 0x10
        public int _index; // 0x14
        public string _name; // 0x18
        public 0x6599B0B8 _api; // 0x20

        // ── Methods ──
        public void get_DeviceType(){} // RVA: 0x32A5C0
        public void get_Index(){} // RVA: 0x8ABED0
        public void get_Name(){} // RVA: 0x2E07C0
        public void get_MediaApi(){} // RVA: 0x760030
        public void .ctor(){} // RVA: 0x62862D0
    }

    public class DeviceList : .ctor
    {
        public RenderHeads.Media.AVProMovieCapture.Device[] _devices; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6286340
        public void FindDevice(){} // RVA: 0x6286440
        public void GetFirstWithMediaApi(){} // RVA: 0x6286520
        public void GetEnumerator(){} // RVA: 0x1CA8480
        public void get_Devices(){} // RVA: 0x2F8380
        public void get_Count(){} // RVA: 0xF3F910
    }

    public class DeviceManager
    {
        public bool _isEnumerated;

        // ── Methods ──
        public void FindDevice(){} // RVA: 0x6286580
        public void GetDeviceCount(){} // RVA: 0x62866D0
        public void CheckInit(){} // RVA: 0x6286780
        public void GetDevices(){} // RVA: 0x6286830
        public void EnumerateDevices(){} // RVA: 0x62868A0
        public void get_AudioInputDevices(){} // RVA: 0x6286C00
        public void .cctor(){} // RVA: 0x6286C60
    }

    public class EncoderHints
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x627A110
        public void SetDefaults(){} // RVA: 0x627A110
    }

    public class FileWritingHandler
    {
        public string _path; // 0x10
        public int _handle; // 0x18
        public bool _deleteFile; // 0x1C

        // ── Methods ──
        public void get_Status(){} // RVA: 0x59C540
        public void get_Path(){} // RVA: 0x2F8380
        public void get_CompletedFileWritingAction(){} // RVA: 0x358D50
        public void set_CompletedFileWritingAction(){} // RVA: 0x358D60
        public void .ctor(){} // RVA: 0x6286D60
        public void SetFilePostProcess(){} // RVA: 0x6286E40
        public void StartPostProcess(){} // RVA: 0x6286EA0
        public void IsFileReady(){} // RVA: 0x6286FE0
        public void Dispose(){} // RVA: 0x62871E0
        public void Cleanup(){} // RVA: 0x6287490
    }

    public class IMediaApiItem
    {
        // ── Methods ──
        public void get_Index(){} // RVA: 0xD840
        public void get_Name(){} // RVA: 0xCD60
        public void get_MediaApi(){} // RVA: 0xD840
    }

    public class ImageEncoderHints
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x627A0C0
        public void SetDefaults(){} // RVA: 0x627A0C0
        public void Validate(){} // RVA: 0x627A0E0
    }

    public class MP4FileProcessing
    {
        // ── Methods ──
        public void ProcessFileAsync(){} // RVA: 0x6287570
        public void ProcessFile(){} // RVA: 0x6287BA0 | overloaded x2
        public void .ctor(){} // RVA: 0x6287FA0
        public void Process(){} // RVA: 0x6288150
        public void Close(){} // RVA: 0x6288C50
        public void GetFirstChunkOfType(){} // RVA: 0x6288E50
        public void ReadChildChunks(){} // RVA: 0x62890A0 | overloaded x2
        public void ReadChunkHeader(){} // RVA: 0x62892A0
        public void ChunkContainsChildChunkWithId(){} // RVA: 0x6289480
        public void ChunkDesc(){} // RVA: 0x62895F0
        public void WriteChunk(){} // RVA: 0x6289930
        public void CopyChunkHeader(){} // RVA: 0x62899B0
        public void InjectChunkHeader(){} // RVA: 0x6289A30
        public void CopyBytes(){} // RVA: 0x6289AB0
        public void WriteZeros(){} // RVA: 0x6289BC0
        public void WriteChunkRecursive_moov(){} // RVA: 0x6289C70
        public void IsVideoTrack(){} // RVA: 0x628A380
        public void WriteChunk_stco(){} // RVA: 0x628A4D0
        public void WriteChunk_co64_from_stco(){} // RVA: 0x628A5D0
        public void WriteChunk_co64(){} // RVA: 0x628A700
        public void InjectChunkStub_co64_from_stco(){} // RVA: 0x628A7F0
        public void WriteChunk_stsd(){} // RVA: 0x628A950
        public void Convert(){} // RVA: 0x628AE60
        public void InjectChunk_st3d(){} // RVA: 0x628AE80
        public void InjectChunk_sv3d(){} // RVA: 0x628AF50
        public void InjectChunk_uuid_GoogleSphericalVideoV1(){} // RVA: 0x628B0E0
        public void InjectChunk_svhd(){} // RVA: 0x628B380
        public void InjectChunk_proj(){} // RVA: 0x628B5D0
        public void InjectChunk_prhd(){} // RVA: 0x628B9D0
        public void InjectChunk_equi(){} // RVA: 0x628BB40
        public void OverwriteChunkSize(){} // RVA: 0x628BCC0
        public void ReadUInt16(){} // RVA: 0x628BD80
        public void ReadUInt32(){} // RVA: 0x628BE90
        public void ReadUInt64(){} // RVA: 0x628BFA0
        public void WriteUInt16(){} // RVA: 0x628C0B0
        public void WriteChunkId(){} // RVA: 0x628C1A0
        public void WriteUInt32(){} // RVA: 0x628C1B0
        public void WriteUInt64(){} // RVA: 0x628C2B0
        public void ChunkIdToString(){} // RVA: 0x628C3A0
        public void ChunkId(){} // RVA: 0x628C620
        public void DebugLog(){} // RVA: 0x628C670
        public void .cctor(){} // RVA: 0x628C6C0
    }

    public class MotionBlur
    {
        public 0x65898180 _format; // 0x20
        public int _numSamples; // 0x24
        public UnityEngine.RenderTexture _accum; // 0x28
        public UnityEngine.RenderTexture _lastComp; // 0x30

        // ── Methods ──
        public void get_IsFrameAccumulated(){} // RVA: 0x1AEFFD0
        public void set_IsFrameAccumulated(){} // RVA: 0x1AF0B40
        public void get_NumSamples(){} // RVA: 0xCEF5B0
        public void set_NumSamples(){} // RVA: 0x6270E90
        public void get_FrameCount(){} // RVA: 0x37E0C0
        public void get_FinalTexture(){} // RVA: 0x6374D0
        public void Awake(){} // RVA: 0x6270EA0
        public void SetTargetSize(){} // RVA: 0x6270FC0
        public void Start(){} // RVA: 0x6270FE0
        public void OnEnable(){} // RVA: 0x6270FF0
        public void Setup(){} // RVA: 0x6271010
        public void ClearAccumulation(){} // RVA: 0x6271830
        public void OnDestroy(){} // RVA: 0x6271980
        public void OnNumSamplesChanged(){} // RVA: 0x6271EA0
        public void LerpUnclamped(){} // RVA: 0x6272020
        public void ApplyWeighting(){} // RVA: 0x6272030
        public void Accumulate(){} // RVA: 0x62721B0
        public void OnRenderImage(){} // RVA: 0x62722A0
        public void .ctor(){} // RVA: 0x6272320
    }

    public class MouseCursor
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x6272380
        public void SetTexture(){} // RVA: 0x6272390
        public void OnGUI(){} // RVA: 0x6272590
        public void .ctor(){} // RVA: 0x6272840
    }

    public class NativePlugin
    {
        public string ScriptVersion;
        public string ExpectedPluginVersion;

        // ── Methods ──
        public void AddAmbisonicSourceInstance(){} // RVA: 0x6276010
        public void RemoveAmbisonicSourceInstance(){} // RVA: 0x6276090
        public void UpdateAmbisonicWeights(){} // RVA: 0x6276110
        public void EncodeMonoToAmbisonic(){} // RVA: 0x62761E0
        public void RenderThreadEvent(){} // RVA: 0x62762C0
        public void get_RenderCaptureEventFunction(){} // RVA: 0x6276550
        public void get_RenderFreeEventFunction(){} // RVA: 0x6276660
        public void GetRenderEventFunc(){} // RVA: 0x6276770
        public void GetFreeResourcesEventFunc(){} // RVA: 0x62767E0
        public void Init(){} // RVA: 0x6276850
        public void Deinit(){} // RVA: 0x62768C0
        public void SetMicrophoneRecordingHint(){} // RVA: 0x6276930
        public void GetPluginVersionString(){} // RVA: 0x62769C0
        public void IsTrialVersion(){} // RVA: 0x6276AC0
        public void IsBasicEdition(){} // RVA: 0x6276B30
        public void GetVideoCodecCount(){} // RVA: 0x6276D60
        public void IsConfigureVideoCodecSupported(){} // RVA: 0x6276DD0
        public void GetVideoCodecMediaApi(){} // RVA: 0x6276E50
        public void ConfigureVideoCodec(){} // RVA: 0x6276ED0
        public void GetVideoCodecName(){} // RVA: 0x6278690 | overloaded x2
        public void GetAudioCodecCount(){} // RVA: 0x6277130
        public void IsConfigureAudioCodecSupported(){} // RVA: 0x62771A0
        public void GetAudioCodecMediaApi(){} // RVA: 0x6277220
        public void ConfigureAudioCodec(){} // RVA: 0x62772A0
        public void GetAudioCodecName(){} // RVA: 0x6278760 | overloaded x2
        public void GetAudioInputDeviceCount(){} // RVA: 0x6277500
        public void GetAudioInputDeviceName(){} // RVA: 0x6278830 | overloaded x2
        public void GetAudioInputDeviceMediaApi(){} // RVA: 0x6277750
        public void GetContainerFileExtensions(){} // RVA: 0x6278900 | overloaded x2
        public void CreateRecorderVideo(){} // RVA: 0x6277A90
        public void CreateRecorderImages(){} // RVA: 0x6277BA0
        public void CreateRecorderPipe(){} // RVA: 0x6277CB0
        public void Start(){} // RVA: 0x6277DA0
        public void IsNewFrameDue(){} // RVA: 0x6277E20
        public void SetEncodedFrameLimit(){} // RVA: 0x6277EA0
        public void EncodeFrame(){} // RVA: 0x6277F30
        public void EncodeAudio(){} // RVA: 0x6277FC0
        public void EncodeFrameWithAudio(){} // RVA: 0x6278060
        public void Pause(){} // RVA: 0x6278100
        public void Stop(){} // RVA: 0x6278180
        public void IsFileWritingComplete(){} // RVA: 0x6278210
        public void SetTexturePointer(){} // RVA: 0x6278290
        public void FreeRecorder(){} // RVA: 0x6278320
        public void GetNumDroppedFrames(){} // RVA: 0x62783A0
        public void GetNumDroppedEncoderFrames(){} // RVA: 0x6278420
        public void GetNumEncodedFrames(){} // RVA: 0x62784A0
        public void GetEncodedSeconds(){} // RVA: 0x6278520
        public void GetFileSize(){} // RVA: 0x62785A0
        public void GetPluginVersion(){} // RVA: 0x6278620
        public void SetLogFunction(){} // RVA: 0x62789E0
        public void SetErrorHandler(){} // RVA: 0x6278A60
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x6278AF0
    }

    public class TimelineController
    {
        public 0x6599A350 _scanFrequency; // 0x20

        // ── Methods ──
        public void get_ScanFrequency(){} // RVA: 0x760030
        public void set_ScanFrequency(){} // RVA: 0x62728E0
        public void Awake(){} // RVA: 0x62728F0
        public void OnValidate(){} // RVA: 0x62728F0
        public void UpdateFrame(){} // RVA: 0x6272900
        public void StartCapture(){} // RVA: 0x6272910
        public void StopCapture(){} // RVA: 0x6272A70
        public void ScanForPlayableDirectors(){} // RVA: 0x6272CF0
        public void OnDestroy(){} // RVA: 0x6273070
        public void ResetSceneLoading(){} // RVA: 0x6273120
        public void OnSceneLoaded(){} // RVA: 0x6273210
        public void .ctor(){} // RVA: 0x6273220
    }

    public class UnityAudioCapture
    {
        // ── Methods ──
        public void get_OverflowCount(){} // RVA: 0x519240
        public void get_SampleRate(){} // RVA: 0xD840
        public void get_ChannelCount(){} // RVA: 0xD840
        public void PrepareCapture(){} // RVA: 0x24A50
        public void StartCapture(){} // RVA: 0x24A50
        public void StopCapture(){} // RVA: 0x24A50
        public void FlushBuffer(){} // RVA: 0x24A50
        public void ReadData(){} // RVA: 0x62737C0
        public void GetUnityAudioChannelCount(){} // RVA: 0x62737D0
        public void GetChannelCount(){} // RVA: 0x6273910
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class Utils
    {
        // ── Methods ──
        public void GetNativeImageSequenceFormatNames(){} // RVA: 0x628D060
        public void HasAlphaChannel(){} // RVA: 0x628D0E0
        public void GetBestRenderTextureFormat(){} // RVA: 0x628D150
        public void GetUltimateRenderCamera(){} // RVA: 0x628D520
        public void HasContributingCameras(){} // RVA: 0x628D800
        public void FindContributingCameras(){} // RVA: 0x628D960
        public void URLEscapePathByPercentEncoding(){} // RVA: 0x628E160
        public void ShowInExplorer(){} // RVA: 0x628E5C0
        public void OpenInDefaultApp(){} // RVA: 0x628E720
        public void GetFileSize(){} // RVA: 0x628E8A0
        public void GetDiskFreeSpaceEx(){} // RVA: 0x628E920
        public void DriveFreeBytes(){} // RVA: 0x628E9F0
        public void GetImageFileExtension(){} // RVA: 0x628EB90
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x628EC60
    }

    public class VideoEncoderHints
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x627A040
        public void SetDefaults(){} // RVA: 0x627A040
        public void Validate(){} // RVA: 0x627A090
    }

    public class VideoPlayerController
    {
        public 0x6599A4B0 _scanFrequency; // 0x20

        // ── Methods ──
        public void get_ScanFrequency(){} // RVA: 0x760030
        public void set_ScanFrequency(){} // RVA: 0x6273980
        public void Awake(){} // RVA: 0x6273990
        public void Start(){} // RVA: 0x2DD310
        public void OnValidate(){} // RVA: 0x6273990
        public void Update(){} // RVA: 0x2DD310
        public void UpdateFrame(){} // RVA: 0x62739A0
        public void CanContinue(){} // RVA: 0x6273B90
        public void WaitforSeekCompletes(){} // RVA: 0x6273D10
        public void WaitforSeekCompletes2(){} // RVA: 0x2DD310
        public void StartCapture(){} // RVA: 0x6273DB0
        public void StopCapture(){} // RVA: 0x6274020
        public void ScanForVideoPlayers(){} // RVA: 0x6274260
        public void OnDestroy(){} // RVA: 0x6274650
        public void ResetSceneLoading(){} // RVA: 0x6274700
        public void OnSceneLoaded(){} // RVA: 0x62747F0
        public void .ctor(){} // RVA: 0x6274800
        public void <WaitforSeekCompletes>b__13_0(){} // RVA: 0x6274970
    }

    public class WavWriter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x628F4B0
        public void Dispose(){} // RVA: 0x628F640
        public void WriteInterleaved(){} // RVA: 0x628F710
        public void WriteHeader(){} // RVA: 0x628FA90
        public void PackageInt(){} // RVA: 0x6290160
        public void .cctor(){} // RVA: 0x6290270
    }

}