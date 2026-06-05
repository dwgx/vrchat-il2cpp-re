// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.RenderHeads.Media.AVProMovieCapture
// Classes: 38
// Methods: 684

namespace ThirdParty.Other.RenderHeads.Media.AVProMovieCapture
{
    public class Ambisonic
    {
        // ── Methods ──
        public void GetNormalisationWeights(){} // RVA: 0x7FFAF8D292D0
        public void GetCoeffCount(){} // RVA: 0x7FFAF8D29360
        public void GetChannelOrder(){} // RVA: 0x7FFAF8D29390
        public void GetNormalisation(){} // RVA: 0x7FFAF8D29390
        public void .cctor(){} // RVA: 0x7FFAF8D293A0
        public void BuildWeightsFuMa(){} // RVA: 0x7FFAF8D29640
        public void GetN(){} // RVA: 0x7FFAF8D29910
        public void GetM(){} // RVA: 0x7FFAF8D29950
        public void Factorial(){} // RVA: 0x7FFAF8D299D0
        public void GetNormalisationSN3D(){} // RVA: 0x7FFAF8D29AE0 | overloaded x2
        public void GetNormalisationN3D(){} // RVA: 0x7FFAF8D29C60
        public void BuildWeightsSN3D(){} // RVA: 0x7FFAF8D29D10
    }

    public class AmbisonicSource
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFAF8D040A0
        public void OnDisable(){} // RVA: 0x7FFAF8D044D0
        public void Setup(){} // RVA: 0x7FFAF8D047A0
        public void OnDrawGizmos(){} // RVA: 0x7FFAF8D04AF0
        public void LateUpdate(){} // RVA: 0x7FFAF8D04E00
        public void SetListenerRelativePosition(){} // RVA: 0x7FFAF8D05090
        public void UpdateCoefficients(){} // RVA: 0x7FFAF8D050B0
        public void OnAudioFilterRead(){} // RVA: 0x7FFAF8D05470
        public void FlushBuffers(){} // RVA: 0x7FFAF8D05B20
        public void GetFullBufferCount(){} // RVA: 0x7FFAF8D05EF0
        public void SendSamplesToSink(){} // RVA: 0x7FFAF8D05F40
        public void .ctor(){} // RVA: 0x7FFAF8D06200
    }

    public class AmbisonicWavWriter
    {
        // ── Methods ──
        public void get_Order(){} // RVA: 0x7FFAF3241DC0
        public void get_Format(){} // RVA: 0x7FFAF3CB9F00
        public void AddSource(){} // RVA: 0x7FFAF8D063C0
        public void RemoveSource(){} // RVA: 0x7FFAF8D06590
        public void OnDisable(){} // RVA: 0x7FFAF8D06710
        public void SetupSource(){} // RVA: 0x7FFAF8D06720
        public void ToggleCapturing(){} // RVA: 0x7FFAF8D067D0
        public void StartCapture(){} // RVA: 0x7FFAF8D06800
        public void StopCapture(){} // RVA: 0x7FFAF8D06F30
        public void IsCapturing(){} // RVA: 0x7FFAF8D07160
        public void LateUpdate(){} // RVA: 0x7FFAF8D07180
        public void ProcessSources(){} // RVA: 0x7FFAF8D072A0
        public void MixSamples(){} // RVA: 0x7FFAF8D075B0
        public void FlushWavWriter(){} // RVA: 0x7FFAF8D076D0
        public void .ctor(){} // RVA: 0x7FFAF8D07710
    }

    public class AudioSourceToWav
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFAF8D07910
        public void OnDisable(){} // RVA: 0x7FFAF8D07B30
        public void OnAudioFilterRead(){} // RVA: 0x7FFAF8D07BB0
        public void .ctor(){} // RVA: 0x7FFAF8D07BE0
    }

    public class CameraSelector
    {
        // ── Methods ──
        public void get_Camera(){} // RVA: 0x7FFAF2E0A740
        public void set_Camera(){} // RVA: 0x7FFAF8D07CB0
        public void get_SelectBy(){} // RVA: 0x7FFAF3210030
        public void set_SelectBy(){} // RVA: 0x7FFAF8D07D20
        public void get_ScanFrequency(){} // RVA: 0x7FFAF379F5B0
        public void set_ScanFrequency(){} // RVA: 0x7FFAF8D07D30
        public void get_ScanHiddenCameras(){} // RVA: 0x7FFAF3198A80
        public void set_ScanHiddenCameras(){} // RVA: 0x7FFAF8D07D40
        public void get_SelectTag(){} // RVA: 0x7FFAF30E74D0
        public void set_SelectTag(){} // RVA: 0x7FFAF8D07D50
        public void get_SelectName(){} // RVA: 0x7FFAF2F476A0
        public void set_SelectName(){} // RVA: 0x7FFAF8D07DB0
        public void Awake(){} // RVA: 0x7FFAF8D07E10
        public void Start(){} // RVA: 0x7FFAF8D07E20
        public void OnValidate(){} // RVA: 0x7FFAF8D07E10
        public void Update(){} // RVA: 0x7FFAF8D07E30
        public void OnDestroy(){} // RVA: 0x7FFAF8D07E50
        public void ResetSceneLoading(){} // RVA: 0x7FFAF8D07EF0
        public void OnSceneLoaded(){} // RVA: 0x7FFAF8D07FE0
        public void ScanForCameraChange(){} // RVA: 0x7FFAF8D07FF0
        public void FindCamera(){} // RVA: 0x7FFAF8D08220
        public void UpdateCameraCache(){} // RVA: 0x7FFAF8D08560
        public void FindCameraByHighestDepth(){} // RVA: 0x7FFAF8D08700
        public void FindCameraByTag(){} // RVA: 0x7FFAF8D08880
        public void FindCameraByName(){} // RVA: 0x7FFAF8D08910
        public void .ctor(){} // RVA: 0x7FFAF8D089D0
    }

    public class CaptureAudioFromAudioClip
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFAF8D08BA0
        public void Update(){} // RVA: 0x7FFAF8D08F50
        public void GetAudioSamplesForFrame(){} // RVA: 0x7FFAF8D09060
        public void .ctor(){} // RVA: 0x7FFAF3342040
    }

    public class CaptureAudioFromAudioListener
    {
        // ── Methods ──
        public void get_Buffer(){} // RVA: 0x7FFAF30E74D0
        public void get_BufferLength(){} // RVA: 0x7FFAF3A8C9F0
        public void get_BufferPtr(){} // RVA: 0x7FFAF8D093B0
        public void get_OverflowCount(){} // RVA: 0x7FFAF3F29960
        public void get_SampleRate(){} // RVA: 0x7FFAF8D093C0
        public void get_ChannelCount(){} // RVA: 0x7FFAF2E2E0C0
        public void PrepareCapture(){} // RVA: 0x7FFAF8D09410
        public void StartCapture(){} // RVA: 0x7FFAF629F790
        public void StopCapture(){} // RVA: 0x7FFAF8D09990
        public void ReadData(){} // RVA: 0x7FFAF8D09BF0
        public void FlushBuffer(){} // RVA: 0x7FFAF8D09D80
        public void OnAudioFilterRead(){} // RVA: 0x7FFAF8D09EC0
        public void .ctor(){} // RVA: 0x7FFAF8D0A230
    }

    public class CaptureAudioFromAudioRenderer
    {
        // ── Methods ──
        public void get_Capture(){} // RVA: 0x7FFAF2DBB0C0
        public void set_Capture(){} // RVA: 0x7FFAF2DBB0D0
        public void get_SampleRate(){} // RVA: 0x7FFAF8D093C0
        public void get_ChannelCount(){} // RVA: 0x7FFAF3241DC0
        public void PrepareCapture(){} // RVA: 0x7FFAF8D0A3E0
        public void GetAudioBufferOfLength(){} // RVA: 0x7FFAF8D0A400
        public void DisposeAudioBuffer(){} // RVA: 0x7FFAF2D8D310
        public void StartCapture(){} // RVA: 0x7FFAF8D0A5D0
        public void StopCapture(){} // RVA: 0x7FFAF8D0A840
        public void FlushBuffer(){} // RVA: 0x7FFAF8D0A8D0
        public void Update(){} // RVA: 0x7FFAF8D0A9C0
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class CaptureAudioFromWwise
    {
        // ── Methods ──
        public void get_Capture(){} // RVA: 0x7FFAF2DBB0C0
        public void set_Capture(){} // RVA: 0x7FFAF2DBB0D0
        public void Awake(){} // RVA: 0x7FFAF8D0AB80
        public void get_SampleRate(){} // RVA: 0x7FFAF2FC9240
        public void get_ChannelCount(){} // RVA: 0x7FFAF2FC9240
        public void PrepareCapture(){} // RVA: 0x7FFAF2D8D310
        public void FlushBuffer(){} // RVA: 0x7FFAF2D8D310
        public void StartCapture(){} // RVA: 0x7FFAF2D8D310
        public void StopCapture(){} // RVA: 0x7FFAF2D8D310
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class CaptureBase
    {
        // ── Methods ──
        public void get_OutputTarget(){} // RVA: 0x7FFAF4759B70
        public void set_OutputTarget(){} // RVA: 0x7FFAF8D2A280
        public void get_OutputFolder(){} // RVA: 0x7FFAF61E9380
        public void set_OutputFolder(){} // RVA: 0x7FFAF8D2A290
        public void get_OutputFolderPath(){} // RVA: 0x7FFAF32A7DB0
        public void set_OutputFolderPath(){} // RVA: 0x7FFAF30ED280
        public void get_FilenamePrefix(){} // RVA: 0x7FFAF3544E10
        public void set_FilenamePrefix(){} // RVA: 0x7FFAF37A6DE0
        public void get_AppendFilenameTimestamp(){} // RVA: 0x7FFAF41B2E10
        public void set_AppendFilenameTimestamp(){} // RVA: 0x7FFAF41B2E20
        public void get_AllowManualFileExtension(){} // RVA: 0x7FFAF461CD40
        public void set_AllowManualFileExtension(){} // RVA: 0x7FFAF461CF40
        public void get_FilenameExtension(){} // RVA: 0x7FFAF2FB7710
        public void set_FilenameExtension(){} // RVA: 0x7FFAF2FB9930
        public void get_NamedPipePath(){} // RVA: 0x7FFAF2FB7D10
        public void set_NamedPipePath(){} // RVA: 0x7FFAF2FBA8C0
        public void get_ImageSequenceStartFrame(){} // RVA: 0x7FFAF37C9990
        public void set_ImageSequenceStartFrame(){} // RVA: 0x7FFAF8D2A2A0
        public void get_ImageSequenceZeroDigits(){} // RVA: 0x7FFAF8BED7A0
        public void set_ImageSequenceZeroDigits(){} // RVA: 0x7FFAF8D2A2B0
        public void get_UseMotionBlur(){} // RVA: 0x7FFAF412DAF0
        public void set_UseMotionBlur(){} // RVA: 0x7FFAF4136780
        public void get_MotionBlurSamples(){} // RVA: 0x7FFAF8D2A2E0
        public void set_MotionBlurSamples(){} // RVA: 0x7FFAF8D2A2F0
        public void get_MotionBlurCameras(){} // RVA: 0x7FFAF34AE130
        public void set_MotionBlurCameras(){} // RVA: 0x7FFAF383E9B0
        public void get_MotionBlur(){} // RVA: 0x7FFAF383A610
        public void set_MotionBlur(){} // RVA: 0x7FFAF3845D10
        public void get_ActiveFilePaths(){} // RVA: 0x7FFAF8D2A320
        public void get_LastFilePath(){} // RVA: 0x7FFAF35474D0
        public void get_BeginFinalFileWritingAction(){} // RVA: 0x7FFAF384E9A0
        public void set_BeginFinalFileWritingAction(){} // RVA: 0x7FFAF384F490
        public void get_CompletedFileWritingAction(){} // RVA: 0x7FFAF38471B0
        public void set_CompletedFileWritingAction(){} // RVA: 0x7FFAF3835210
        public void get_Stats(){} // RVA: 0x7FFAF3838BD0
        public void get_CameraRenderResolution(){} // RVA: 0x7FFAF3CBA360
        public void set_CameraRenderResolution(){} // RVA: 0x7FFAF8BDFB30
        public void get_CameraRenderCustomResolution(){} // RVA: 0x7FFAF8D2A380
        public void set_CameraRenderCustomResolution(){} // RVA: 0x7FFAF8D2A3A0
        public void get_CameraRenderAntiAliasing(){} // RVA: 0x7FFAF40AEA80
        public void set_CameraRenderAntiAliasing(){} // RVA: 0x7FFAF40AE850
        public void get_IsRealTime(){} // RVA: 0x7FFAF45A8C70
        public void set_IsRealTime(){} // RVA: 0x7FFAF45A8C60
        public void get_PersistAcrossSceneLoads(){} // RVA: 0x7FFAF4740FC0
        public void set_PersistAcrossSceneLoads(){} // RVA: 0x7FFAF4740FD0
        public void get_AudioCaptureSource(){} // RVA: 0x7FFAF3500BB0
        public void set_AudioCaptureSource(){} // RVA: 0x7FFAF4597FE0
        public void get_ManualAudioSampleRate(){} // RVA: 0x7FFAF475C8E0
        public void set_ManualAudioSampleRate(){} // RVA: 0x7FFAF68A13F0
        public void get_ManualAudioChannelCount(){} // RVA: 0x7FFAF475C8F0
        public void set_ManualAudioChannelCount(){} // RVA: 0x7FFAF8D2A3B0
        public void get_UnityAudioCapture(){} // RVA: 0x7FFAF3546D30
        public void set_UnityAudioCapture(){} // RVA: 0x7FFAF2E0E8A0
        public void get_ForceAudioInputDeviceIndex(){} // RVA: 0x7FFAF47C2470
        public void set_ForceAudioInputDeviceIndex(){} // RVA: 0x7FFAF8D2A3C0
        public void get_FrameRate(){} // RVA: 0x7FFAF2DF5540
        public void set_FrameRate(){} // RVA: 0x7FFAF8D2A3D0
        public void get_StartTrigger(){} // RVA: 0x7FFAF2E2E0C0
        public void set_StartTrigger(){} // RVA: 0x7FFAF2E2E0D0
        public void get_StartDelay(){} // RVA: 0x7FFAF3F29960
        public void set_StartDelay(){} // RVA: 0x7FFAF4825D90
        public void get_StartDelaySeconds(){} // RVA: 0x7FFAF2DF5460
        public void set_StartDelaySeconds(){} // RVA: 0x7FFAF8D2A400
        public void get_StopMode(){} // RVA: 0x7FFAF370BE80
        public void set_StopMode(){} // RVA: 0x7FFAF370BE70
        public void get_StopAfterFramesElapsed(){} // RVA: 0x7FFAF349AB90
        public void set_StopAfterFramesElapsed(){} // RVA: 0x7FFAF8D2A410
        public void get_StopAfterSecondsElapsed(){} // RVA: 0x7FFAF2DB6000
        public void set_StopAfterSecondsElapsed(){} // RVA: 0x7FFAF8D2A420
        public void get_CaptureStats(){} // RVA: 0x7FFAF3838BD0
        public void get_VideoCodecPriorityWindows(){} // RVA: 0x7FFAF2E2B370
        public void set_VideoCodecPriorityWindows(){} // RVA: 0x7FFAF8D2A430
        public void get_VideoCodecPriorityMacOS(){} // RVA: 0x7FFAF2E08D50
        public void set_VideoCodecPriorityMacOS(){} // RVA: 0x7FFAF8D2A490
        public void get_AudioCodecPriorityWindows(){} // RVA: 0x7FFAF2F77C50
        public void set_AudioCodecPriorityWindows(){} // RVA: 0x7FFAF8D2A4F0
        public void get_AudioCodecPriorityMacOS(){} // RVA: 0x7FFAF2F12D00
        public void set_AudioCodecPriorityMacOS(){} // RVA: 0x7FFAF8D2A550
        public void get_TimelapseScale(){} // RVA: 0x7FFAF315FD30
        public void set_TimelapseScale(){} // RVA: 0x7FFAF338F350
        public void get_FrameUpdate(){} // RVA: 0x7FFAF4826570
        public void set_FrameUpdate(){} // RVA: 0x7FFAF4826000
        public void get_ResolutionDownScale(){} // RVA: 0x7FFAF4826560
        public void set_ResolutionDownScale(){} // RVA: 0x7FFAF4826580
        public void get_ResolutionDownscaleCustom(){} // RVA: 0x7FFAF8D2A5B0
        public void set_ResolutionDownscaleCustom(){} // RVA: 0x7FFAF8AA62E0
        public void get_FlipVertically(){} // RVA: 0x7FFAF3D1AF80
        public void set_FlipVertically(){} // RVA: 0x7FFAF3D1BEE0
        public void get_UseWaitForEndOfFrame(){} // RVA: 0x7FFAF8D2A5D0
        public void set_UseWaitForEndOfFrame(){} // RVA: 0x7FFAF8D2A5E0
        public void get_LogCaptureStartStop(){} // RVA: 0x7FFAF2FADE70
        public void set_LogCaptureStartStop(){} // RVA: 0x7FFAF8D2A5F0
        public void get_AllowOfflineVSyncDisable(){} // RVA: 0x7FFAF8D2A600
        public void set_AllowOfflineVSyncDisable(){} // RVA: 0x7FFAF8D2A610
        public void get_SupportTextureRecreate(){} // RVA: 0x7FFAF8D2A620
        public void set_SupportTextureRecreate(){} // RVA: 0x7FFAF8D2A630
        public void get_TimelineController(){} // RVA: 0x7FFAF3843DD0
        public void set_TimelineController(){} // RVA: 0x7FFAF3843D70
        public void get_VideoPlayerController(){} // RVA: 0x7FFAF32E0040
        public void set_VideoPlayerController(){} // RVA: 0x7FFAF383E320
        public void get_SelectedVideoCodec(){} // RVA: 0x7FFAF3862150
        public void get_SelectedAudioCodec(){} // RVA: 0x7FFAF3507F60
        public void get_SelectedAudioInputDevice(){} // RVA: 0x7FFAF38562D0
        public void get_NativeForceVideoCodecIndex(){} // RVA: 0x7FFAF3773CB0
        public void set_NativeForceVideoCodecIndex(){} // RVA: 0x7FFAF3779310
        public void get_NativeForceAudioCodecIndex(){} // RVA: 0x7FFAF4346340
        public void set_NativeForceAudioCodecIndex(){} // RVA: 0x7FFAF4346350
        public void get_NativeImageSequenceFormat(){} // RVA: 0x7FFAF8D2A640
        public void set_NativeImageSequenceFormat(){} // RVA: 0x7FFAF8D2A650
        public void GetCurrentPlatform(){} // RVA: 0x7FFAF2FC9240
        public void GetEncoderHints(){} // RVA: 0x7FFAF8D2A660
        public void SetEncoderHints(){} // RVA: 0x7FFAF8D2A710
        public void UpdateMediaGallery(){} // RVA: 0x7FFAF2D8D310
        public void Awake(){} // RVA: 0x7FFAF8D2A930
        public void .cctor(){} // RVA: 0x7FFAF8D2AF60
        public void Start(){} // RVA: 0x7FFAF8D2BA80
        public void SelectCodec(){} // RVA: 0x7FFAF8D2BBB0
        public void SelectVideoCodec(){} // RVA: 0x7FFAF8D2BF60
        public void SelectAudioCodec(){} // RVA: 0x7FFAF8D2C140
        public void SelectAudioInputDevice(){} // RVA: 0x7FFAF8D2C2B0
        public void GetRecordingResolution(){} // RVA: 0x7FFAF8D2C510
        public void SelectRecordingResolution(){} // RVA: 0x7FFAF8D2C5E0
        public void OnDestroy(){} // RVA: 0x7FFAF8D2C6F0
        public void FreePendingFileWrites(){} // RVA: 0x7FFAF8D2CA60
        public void OnApplicationQuit(){} // RVA: 0x7FFAF8D2CC00
        public void OnApplicationPause(){} // RVA: 0x7FFAF2D8D310
        public void EncodeTexture(){} // RVA: 0x7FFAF8D2CC60
        public void IsUsingUnityAudioComponent(){} // RVA: 0x7FFAF8D2CD70
        public void IsUsingMotionBlur(){} // RVA: 0x7FFAF8D2CE70
        public void EncodePointer(){} // RVA: 0x7FFAF8D2CF60
        public void IsPrepared(){} // RVA: 0x7FFAF8D2D0F0
        public void IsCapturing(){} // RVA: 0x7FFAF8D2D100
        public void IsPaused(){} // RVA: 0x7FFAF8D2D110
        public void GetRecordingWidth(){} // RVA: 0x7FFAF8D2D120
        public void GetRecordingHeight(){} // RVA: 0x7FFAF8D2D130
        public void GenerateTimestampedFilename(){} // RVA: 0x7FFAF8D2D140
        public void GetFolder(){} // RVA: 0x7FFAF8D2D420
        public void GenerateFilePath(){} // RVA: 0x7FFAF8D2D600
        public void HasExtension(){} // RVA: 0x7FFAF8D2D6A0
        public void GenerateFilename(){} // RVA: 0x7FFAF8D2D7F0
        public void FindOrCreateUnityAudioCapture(){} // RVA: 0x7FFAF8D2DFE0
        public void ValidateEditionFeatures(){} // RVA: 0x7FFAF8D2E680
        public void PrepareCapture(){} // RVA: 0x7FFAF8D2EDB0
        public void QueueStartCapture(){} // RVA: 0x7FFAF8D30AD0
        public void IsStartCaptureQueued(){} // RVA: 0x7FFAF8D30B70
        public void UpdateInjectionOptions(){} // RVA: 0x7FFAF8D30B80
        public void StartCapture(){} // RVA: 0x7FFAF8D30C10
        public void PauseCapture(){} // RVA: 0x7FFAF8D310D0
        public void ResumeCapture(){} // RVA: 0x7FFAF8D31210
        public void CancelCapture(){} // RVA: 0x7FFAF8D31320
        public void DeleteCapture(){} // RVA: 0x7FFAF8D31350
        public void UnprepareCapture(){} // RVA: 0x7FFAF2D8D310
        public void get_LastFileSaved(){} // RVA: 0x7FFAF8D31460
        public void set_LastFileSaved(){} // RVA: 0x7FFAF8D31510
        public void RenderThreadEvent(){} // RVA: 0x7FFAF8D31560
        public void StopCapture(){} // RVA: 0x7FFAF8D315D0
        public void CreatePostOperationsOptions(){} // RVA: 0x7FFAF8D32300
        public void CanApplyPostOperations(){} // RVA: 0x7FFAF8D323D0
        public void ApplyPostOperations(){} // RVA: 0x7FFAF8D325C0
        public void ToggleCapture(){} // RVA: 0x7FFAF8D327F0
        public void IsEnoughDiskSpace(){} // RVA: 0x7FFAF8D32830
        public void CanContinue(){} // RVA: 0x7FFAF8D32870
        public void Update(){} // RVA: 0x7FFAF8D32990
        public void LateUpdate(){} // RVA: 0x7FFAF8D32A00
        public void RemoveCompletedFileWrites(){} // RVA: 0x7FFAF8D32D30
        public void CheckFreeDiskSpace(){} // RVA: 0x7FFAF8D32E10
        public void IsStartDelayComplete(){} // RVA: 0x7FFAF8D32ED0
        public void IsStopTimeReached(){} // RVA: 0x7FFAF8D32F00
        public void GetProgress(){} // RVA: 0x7FFAF8D32FF0
        public void GetSecondsPerCaptureFrame(){} // RVA: 0x7FFAF8D330B0
        public void CanOutputFrame(){} // RVA: 0x7FFAF8D330E0
        public void TickFrameTimer(){} // RVA: 0x7FFAF8D33310
        public void RenormTimer(){} // RVA: 0x7FFAF8D33380
        public void GetPreviewTexture(){} // RVA: 0x7FFAF2FC9240
        public void EncodeUnityAudio(){} // RVA: 0x7FFAF8D333D0
        public void EncodeAudio(){} // RVA: 0x7FFAF8D33520 | overloaded x2
        public void PreUpdateFrame(){} // RVA: 0x7FFAF8D33780
        public void UpdateFrame(){} // RVA: 0x7FFAF8D33960
        public void ResetFPS(){} // RVA: 0x7FFAF8D33CA0
        public void UpdateFPS(){} // RVA: 0x7FFAF8D33CD0
        public void GetCameraAntiAliasingLevel(){} // RVA: 0x7FFAF8D33D60
        public void GetCaptureFileSize(){} // RVA: 0x7FFAF8D33FD0
        public void GetResolution(){} // RVA: 0x7FFAF8D340E0
        public void NextMultipleOf4(){} // RVA: 0x7FFAF3EB69B0
        public void HasUserAuthorisationToCaptureAudio(){} // RVA: 0x7FFAF8D34260
        public void RequestUserAuthorisationToCaptureAudioCallback(){} // RVA: 0x7FFAF8D34340
        public void RequestAudioCaptureDeviceUserAuthorisation(){} // RVA: 0x7FFAF2FC9240
        public void HasUserAuthorisationToAccessPhotos(){} // RVA: 0x7FFAF8D343C0
        public void RequestUserAuthorisationToAccessPhotosCallback(){} // RVA: 0x7FFAF8D344A0
        public void RequestUserAuthorisationToAccessPhotos(){} // RVA: 0x7FFAF2FC9240
        public void .ctor(){} // RVA: 0x7FFAF8D34520
    }

    public class CaptureFromCamera
    {
        // ── Methods ──
        public void get_CameraSelector(){} // RVA: 0x7FFAF38415D0
        public void set_CameraSelector(){} // RVA: 0x7FFAF3843180
        public void get_UseContributingCameras(){} // RVA: 0x7FFAF8D0ABE0
        public void set_UseContributingCameras(){} // RVA: 0x7FFAF8D0ABF0
        public void SetCamera(){} // RVA: 0x7FFAF8D0AF60 | overloaded x2
        public void RequiresResolve(){} // RVA: 0x7FFAF8D0B020
        public void HasCamera(){} // RVA: 0x7FFAF8D0B150
        public void HasContributingCameras(){} // RVA: 0x7FFAF8D0B220
        public void UpdateFrame(){} // RVA: 0x7FFAF8D0B250
        public void FinalRenderCapture(){} // RVA: 0x7FFAF8D0B540
        public void Capture(){} // RVA: 0x7FFAF8D0B5E0
        public void RequiresHDR(){} // RVA: 0x7FFAF8D0B680
        public void UpdateTexture(){} // RVA: 0x7FFAF8D0B860
        public void UnprepareCapture(){} // RVA: 0x7FFAF8D0C1E0
        public void CreateResolveTexture(){} // RVA: 0x7FFAF8D0C410
        public void GetPreviewTexture(){} // RVA: 0x7FFAF38473A0
        public void PrepareCapture(){} // RVA: 0x7FFAF8D0C8C0
        public void OnDestroy(){} // RVA: 0x7FFAF8D0D440
        public void .ctor(){} // RVA: 0x7FFAF8D0D730
        public void <>n__0(){} // RVA: 0x7FFAF8D0D790
    }

    public class CaptureFromCamera360
    {
        // ── Methods ──
        public void get_CameraSelector(){} // RVA: 0x7FFAF38415D0
        public void set_CameraSelector(){} // RVA: 0x7FFAF3843180
        public void get_CubemapFaceResolution(){} // RVA: 0x7FFAF44F0D00
        public void set_CubemapFaceResolution(){} // RVA: 0x7FFAF44F0340
        public void get_CubemapDepthResolution(){} // RVA: 0x7FFAF44F0AD0
        public void set_CubemapDepthResolution(){} // RVA: 0x7FFAF44F1810
        public void get_SupportGUI(){} // RVA: 0x7FFAF8D0DEA0
        public void set_SupportGUI(){} // RVA: 0x7FFAF8D0DEB0
        public void get_SupportCameraRotation(){} // RVA: 0x7FFAF8D0DEC0
        public void set_SupportCameraRotation(){} // RVA: 0x7FFAF8D0DED0
        public void get_OnlyLeftRightRotation(){} // RVA: 0x7FFAF8D0DEE0
        public void set_OnlyLeftRightRotation(){} // RVA: 0x7FFAF8D0DEF0
        public void get_Render180Degrees(){} // RVA: 0x7FFAF8D0DF00
        public void set_Render180Degrees(){} // RVA: 0x7FFAF8D0DF10
        public void get_StereoRendering(){} // RVA: 0x7FFAF44EFF90
        public void set_StereoRendering(){} // RVA: 0x7FFAF8D0DF20
        public void get_IPD(){} // RVA: 0x7FFAF8D0DF30
        public void set_IPD(){} // RVA: 0x7FFAF8D0DF40
        public void .ctor(){} // RVA: 0x7FFAF8D0DF50
        public void GetCubemapRenderingMethod(){} // RVA: 0x7FFAF8D0DFE0
        public void SetCamera(){} // RVA: 0x7FFAF384C4E0
        public void UpdateFrame(){} // RVA: 0x7FFAF8D0E000
        public void FinalRenderCapture(){} // RVA: 0x7FFAF8D0E2C0
        public void Capture(){} // RVA: 0x7FFAF8D0E360
        public void ClearCubemap(){} // RVA: 0x7FFAF8D0E800
        public void RenderCubemapToEquiRect(){} // RVA: 0x7FFAF8D0ECB0
        public void UpdateTexture(){} // RVA: 0x7FFAF8D0EE70
        public void RenderCameraToCubemap(){} // RVA: 0x7FFAF8D0F6A0
        public void AccumulateMotionBlur(){} // RVA: 0x7FFAF8D11170
        public void PrepareCapture(){} // RVA: 0x7FFAF8D11330
        public void GetPreviewTexture(){} // RVA: 0x7FFAF8D12520
        public void Start(){} // RVA: 0x7FFAF8D12560
        public void OnDestroy(){} // RVA: 0x7FFAF8D12920
    }

    public class CaptureFromCamera360ODS
    {
        // ── Methods ──
        public void get_Setup(){} // RVA: 0x7FFAF38415D0
        public void .ctor(){} // RVA: 0x7FFAF8D12F00
        public void SetCamera(){} // RVA: 0x7FFAF8D13020
        public void Start(){} // RVA: 0x7FFAF8D13090
        public void CreateEye(){} // RVA: 0x7FFAF8D132C0
        public void UpdateFrame(){} // RVA: 0x7FFAF8D143C0
        public void FinalRenderCapture(){} // RVA: 0x7FFAF8D146B0
        public void Capture(){} // RVA: 0x7FFAF8D14750
        public void AccumulateMotionBlur(){} // RVA: 0x7FFAF8D149C0
        public void RenderFrame(){} // RVA: 0x7FFAF8D14B90
        public void GetPreviewTexture(){} // RVA: 0x7FFAF8D15830
        public void PrepareCapture(){} // RVA: 0x7FFAF8D15870
        public void DestroyEye(){} // RVA: 0x7FFAF8D169E0
        public void OnDestroy(){} // RVA: 0x7FFAF8D16C10
    }

    public class CaptureFromScreen
    {
        // ── Methods ──
        public void get_CaptureMouseCursor(){} // RVA: 0x7FFAF8D17370
        public void set_CaptureMouseCursor(){} // RVA: 0x7FFAF8D17380
        public void get_MouseCursor(){} // RVA: 0x7FFAF3840650
        public void set_MouseCursor(){} // RVA: 0x7FFAF384F060
        public void PrepareCapture(){} // RVA: 0x7FFAF8D17390
        public void CopyRenderTargetToTexture(){} // RVA: 0x7FFAF8D176F0
        public void FreeRenderResources(){} // RVA: 0x7FFAF8D17D00
        public void UnprepareCapture(){} // RVA: 0x7FFAF8D17F20
        public void FinalRenderCapture(){} // RVA: 0x7FFAF8D18090
        public void UpdateFrame(){} // RVA: 0x7FFAF8D18130
        public void .ctor(){} // RVA: 0x7FFAF8D181F0
    }

    public class CaptureFromTexture
    {
        // ── Methods ──
        public void get_IsManualUpdate(){} // RVA: 0x7FFAF8D17370
        public void set_IsManualUpdate(){} // RVA: 0x7FFAF8D17380
        public void SetSourceTexture(){} // RVA: 0x7FFAF384F060
        public void RequiresResolve(){} // RVA: 0x7FFAF8D18410
        public void UpdateSourceTexture(){} // RVA: 0x7FFAF8D18540
        public void ShouldCaptureFrame(){} // RVA: 0x7FFAF8D18550
        public void HasSourceTextureChanged(){} // RVA: 0x7FFAF8D18640
        public void UpdateFrame(){} // RVA: 0x7FFAF8D18660
        public void FinalRenderCapture(){} // RVA: 0x7FFAF8D18730
        public void Capture(){} // RVA: 0x7FFAF8D187D0
        public void CreateResolveTexture(){} // RVA: 0x7FFAF8D18BE0
        public void AccumulateMotionBlur(){} // RVA: 0x7FFAF8D18F90
        public void GetPreviewTexture(){} // RVA: 0x7FFAF8D190B0
        public void PrepareCapture(){} // RVA: 0x7FFAF8D19220
        public void UnprepareCapture(){} // RVA: 0x7FFAF8D19610
        public void .ctor(){} // RVA: 0x7FFAF8D197E0
    }

    public class CaptureFromWebCamTexture
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAF8D19930
        public void .ctor(){} // RVA: 0x7FFAF8D197E0
    }

    public class CaptureGUI
    {
        public object isPresent;
        public object isPositionTracked;
        public object isEnabled;

        // ── Methods ──
        public void get_MovieCapture(){} // RVA: 0x7FFAF2DBB0C0
        public void set_MovieCapture(){} // RVA: 0x7FFAF2DBB0D0
        public void get_HideUiWhenRecording(){} // RVA: 0x7FFAF36E6000
        public void set_HideUiWhenRecording(){} // RVA: 0x7FFAF43BAB20
        public void get_ShowUI(){} // RVA: 0x7FFAF3198A80
        public void set_ShowUI(){} // RVA: 0x7FFAF3198B80
        public void Start(){} // RVA: 0x7FFAF8D19990
        public void CreateGUI(){} // RVA: 0x7FFAF8D19A70
        public void OnGUI(){} // RVA: 0x7FFAF8D1A6D0
        public void MyWindow(){} // RVA: 0x7FFAF8D1B1B0
        public void GUI_RecordingStatus(){} // RVA: 0x7FFAF8D1DA30
        public void DrawPauseResumeButtons(){} // RVA: 0x7FFAF8D1F4C0
        public void DrawGuiField(){} // RVA: 0x7FFAF8D1FCE0
        public void StartCapture(){} // RVA: 0x7FFAF8D1FDB0
        public void StopCapture(){} // RVA: 0x7FFAF8D1FEB0
        public void CancelCapture(){} // RVA: 0x7FFAF8D1FFB0
        public void ResumeCapture(){} // RVA: 0x7FFAF8D200B0
        public void PauseCapture(){} // RVA: 0x7FFAF8D20190
        public void Update(){} // RVA: 0x7FFAF8D20270
        public void .ctor(){} // RVA: 0x7FFAF8D20530
        public void .cctor(){} // RVA: 0x7FFAF8D20AF0
    }

    public class CaptureStats
    {
        // ── Methods ──
        public void get_FPS(){} // RVA: 0x7FFAF2F152A0
        public void get_FramesTotal(){} // RVA: 0x7FFAF8D29F90
        public void get_NumDroppedFrames(){} // RVA: 0x7FFAF2DDA5C0
        public void set_NumDroppedFrames(){} // RVA: 0x7FFAF2D900C0
        public void get_NumDroppedEncoderFrames(){} // RVA: 0x7FFAF335BED0
        public void set_NumDroppedEncoderFrames(){} // RVA: 0x7FFAF335C660
        public void get_NumEncodedFrames(){} // RVA: 0x7FFAF306ED50
        public void set_NumEncodedFrames(){} // RVA: 0x7FFAF30E74E0
        public void get_TotalEncodedSeconds(){} // RVA: 0x7FFAF442C3B0
        public void set_TotalEncodedSeconds(){} // RVA: 0x7FFAF4439FD0
        public void get_AudioCaptureSource(){} // RVA: 0x7FFAF3210030
        public void set_AudioCaptureSource(){} // RVA: 0x7FFAF344E0D0
        public void get_UnityAudioSampleRate(){} // RVA: 0x7FFAF379F5B0
        public void set_UnityAudioSampleRate(){} // RVA: 0x7FFAF4191F00
        public void get_UnityAudioChannelCount(){} // RVA: 0x7FFAF3241DC0
        public void set_UnityAudioChannelCount(){} // RVA: 0x7FFAF3503440
        public void ResetFPS(){} // RVA: 0x7FFAF8D29FA0
        public void UpdateFPS(){} // RVA: 0x7FFAF8D29FB0
        public void .ctor(){} // RVA: 0x7FFAF8D2A030
    }

    public class Codec
    {
        // ── Methods ──
        public void get_CodecType(){} // RVA: 0x7FFAF2DDA5C0
        public void get_Index(){} // RVA: 0x7FFAF335BED0
        public void get_Name(){} // RVA: 0x7FFAF2D907C0
        public void get_MediaApi(){} // RVA: 0x7FFAF379F5B0
        public void get_HasConfigwindow(){} // RVA: 0x7FFAF2E7B9D0
        public void ShowConfigWindow(){} // RVA: 0x7FFAF8D34F40
        public void .ctor(){} // RVA: 0x7FFAF8D350A0
    }

    public class CodecList : .ctor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8D35120
        public void FindCodec(){} // RVA: 0x7FFAF8D35220
        public void GetFirstWithMediaApi(){} // RVA: 0x7FFAF8D35300
        public void GetEnumerator(){} // RVA: 0x7FFAF4758480
        public void get_Codecs(){} // RVA: 0x7FFAF2DA8380
        public void get_Count(){} // RVA: 0x7FFAF39EF910
    }

    public class CodecManager
    {
        public object MovieCapture;
        public object HideUiWhenRecording;

        // ── Methods ──
        public void FindCodec(){} // RVA: 0x7FFAF8D35360
        public void GetCodecCount(){} // RVA: 0x7FFAF8D35470
        public void CheckInit(){} // RVA: 0x7FFAF8D354E0
        public void GetCodecs(){} // RVA: 0x7FFAF8D35590
        public void EnumerateCodecs(){} // RVA: 0x7FFAF8D35630
        public void get_VideoCodecs(){} // RVA: 0x7FFAF8D36050
        public void get_AudioCodecs(){} // RVA: 0x7FFAF8D360B0
        public void .cctor(){} // RVA: 0x7FFAF8D36110
    }

    public class Device
    {
        // ── Methods ──
        public void get_DeviceType(){} // RVA: 0x7FFAF2DDA5C0
        public void get_Index(){} // RVA: 0x7FFAF335BED0
        public void get_Name(){} // RVA: 0x7FFAF2D907C0
        public void get_MediaApi(){} // RVA: 0x7FFAF3210030
        public void .ctor(){} // RVA: 0x7FFAF8D362D0
    }

    public class DeviceList : .ctor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8D36340
        public void FindDevice(){} // RVA: 0x7FFAF8D36440
        public void GetFirstWithMediaApi(){} // RVA: 0x7FFAF8D36520
        public void GetEnumerator(){} // RVA: 0x7FFAF4758480
        public void get_Devices(){} // RVA: 0x7FFAF2DA8380
        public void get_Count(){} // RVA: 0x7FFAF39EF910
    }

    public class DeviceManager
    {
        // ── Methods ──
        public void FindDevice(){} // RVA: 0x7FFAF8D36580
        public void GetDeviceCount(){} // RVA: 0x7FFAF8D366D0
        public void CheckInit(){} // RVA: 0x7FFAF8D36780
        public void GetDevices(){} // RVA: 0x7FFAF8D36830
        public void EnumerateDevices(){} // RVA: 0x7FFAF8D368A0
        public void get_AudioInputDevices(){} // RVA: 0x7FFAF8D36C00
        public void .cctor(){} // RVA: 0x7FFAF8D36C60
    }

    public class EncoderHints
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8D2A110
        public void SetDefaults(){} // RVA: 0x7FFAF8D2A110
    }

    public class FileWritingHandler
    {
        // ── Methods ──
        public void get_Status(){} // RVA: 0x7FFAF304C540
        public void get_Path(){} // RVA: 0x7FFAF2DA8380
        public void get_CompletedFileWritingAction(){} // RVA: 0x7FFAF2E08D50
        public void set_CompletedFileWritingAction(){} // RVA: 0x7FFAF2E08D60
        public void .ctor(){} // RVA: 0x7FFAF8D36D60
        public void SetFilePostProcess(){} // RVA: 0x7FFAF8D36E40
        public void StartPostProcess(){} // RVA: 0x7FFAF8D36EA0
        public void IsFileReady(){} // RVA: 0x7FFAF8D36FE0
        public void Dispose(){} // RVA: 0x7FFAF8D371E0
        public void Cleanup(){} // RVA: 0x7FFAF8D37490
    }

    public class IMediaApiItem
    {
        // ── Methods ──
        public void get_Index(){} // RVA: 0x7FFAF2ABD840
        public void get_Name(){} // RVA: 0x7FFAF2ABCD60
        public void get_MediaApi(){} // RVA: 0x7FFAF2ABD840
    }

    public class ImageEncoderHints
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8D2A0C0
        public void SetDefaults(){} // RVA: 0x7FFAF8D2A0C0
        public void Validate(){} // RVA: 0x7FFAF8D2A0E0
    }

    public class MP4FileProcessing
    {
        // ── Methods ──
        public void ProcessFileAsync(){} // RVA: 0x7FFAF8D37570
        public void ProcessFile(){} // RVA: 0x7FFAF8D37BA0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAF8D37FA0
        public void Process(){} // RVA: 0x7FFAF8D38150
        public void Close(){} // RVA: 0x7FFAF8D38C50
        public void GetFirstChunkOfType(){} // RVA: 0x7FFAF8D38E50
        public void ReadChildChunks(){} // RVA: 0x7FFAF8D390A0 | overloaded x2
        public void ReadChunkHeader(){} // RVA: 0x7FFAF8D392A0
        public void ChunkContainsChildChunkWithId(){} // RVA: 0x7FFAF8D39480
        public void ChunkDesc(){} // RVA: 0x7FFAF8D395F0
        public void WriteChunk(){} // RVA: 0x7FFAF8D39930
        public void CopyChunkHeader(){} // RVA: 0x7FFAF8D399B0
        public void InjectChunkHeader(){} // RVA: 0x7FFAF8D39A30
        public void CopyBytes(){} // RVA: 0x7FFAF8D39AB0
        public void WriteZeros(){} // RVA: 0x7FFAF8D39BC0
        public void WriteChunkRecursive_moov(){} // RVA: 0x7FFAF8D39C70
        public void IsVideoTrack(){} // RVA: 0x7FFAF8D3A380
        public void WriteChunk_stco(){} // RVA: 0x7FFAF8D3A4D0
        public void WriteChunk_co64_from_stco(){} // RVA: 0x7FFAF8D3A5D0
        public void WriteChunk_co64(){} // RVA: 0x7FFAF8D3A700
        public void InjectChunkStub_co64_from_stco(){} // RVA: 0x7FFAF8D3A7F0
        public void WriteChunk_stsd(){} // RVA: 0x7FFAF8D3A950
        public void Convert(){} // RVA: 0x7FFAF8D3AE60
        public void InjectChunk_st3d(){} // RVA: 0x7FFAF8D3AE80
        public void InjectChunk_sv3d(){} // RVA: 0x7FFAF8D3AF50
        public void InjectChunk_uuid_GoogleSphericalVideoV1(){} // RVA: 0x7FFAF8D3B0E0
        public void InjectChunk_svhd(){} // RVA: 0x7FFAF8D3B380
        public void InjectChunk_proj(){} // RVA: 0x7FFAF8D3B5D0
        public void InjectChunk_prhd(){} // RVA: 0x7FFAF8D3B9D0
        public void InjectChunk_equi(){} // RVA: 0x7FFAF8D3BB40
        public void OverwriteChunkSize(){} // RVA: 0x7FFAF8D3BCC0
        public void ReadUInt16(){} // RVA: 0x7FFAF8D3BD80
        public void ReadUInt32(){} // RVA: 0x7FFAF8D3BE90
        public void ReadUInt64(){} // RVA: 0x7FFAF8D3BFA0
        public void WriteUInt16(){} // RVA: 0x7FFAF8D3C0B0
        public void WriteChunkId(){} // RVA: 0x7FFAF8D3C1A0
        public void WriteUInt32(){} // RVA: 0x7FFAF8D3C1B0
        public void WriteUInt64(){} // RVA: 0x7FFAF8D3C2B0
        public void ChunkIdToString(){} // RVA: 0x7FFAF8D3C3A0
        public void ChunkId(){} // RVA: 0x7FFAF8D3C620
        public void DebugLog(){} // RVA: 0x7FFAF8D3C670
        public void .cctor(){} // RVA: 0x7FFAF8D3C6C0
    }

    public class MotionBlur
    {
        // ── Methods ──
        public void get_IsFrameAccumulated(){} // RVA: 0x7FFAF459FFD0
        public void set_IsFrameAccumulated(){} // RVA: 0x7FFAF45A0B40
        public void get_NumSamples(){} // RVA: 0x7FFAF379F5B0
        public void set_NumSamples(){} // RVA: 0x7FFAF8D20E90
        public void get_FrameCount(){} // RVA: 0x7FFAF2E2E0C0
        public void get_FinalTexture(){} // RVA: 0x7FFAF30E74D0
        public void Awake(){} // RVA: 0x7FFAF8D20EA0
        public void SetTargetSize(){} // RVA: 0x7FFAF8D20FC0
        public void Start(){} // RVA: 0x7FFAF8D20FE0
        public void OnEnable(){} // RVA: 0x7FFAF8D20FF0
        public void Setup(){} // RVA: 0x7FFAF8D21010
        public void ClearAccumulation(){} // RVA: 0x7FFAF8D21830
        public void OnDestroy(){} // RVA: 0x7FFAF8D21980
        public void OnNumSamplesChanged(){} // RVA: 0x7FFAF8D21EA0
        public void LerpUnclamped(){} // RVA: 0x7FFAF8D22020
        public void ApplyWeighting(){} // RVA: 0x7FFAF8D22030
        public void Accumulate(){} // RVA: 0x7FFAF8D221B0
        public void OnRenderImage(){} // RVA: 0x7FFAF8D222A0
        public void .ctor(){} // RVA: 0x7FFAF8D22320
    }

    public class MouseCursor
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAF8D22380
        public void SetTexture(){} // RVA: 0x7FFAF8D22390
        public void OnGUI(){} // RVA: 0x7FFAF8D22590
        public void .ctor(){} // RVA: 0x7FFAF8D22840
    }

    public class NativePlugin
    {
        // ── Methods ──
        public void AddAmbisonicSourceInstance(){} // RVA: 0x7FFAF8D26010
        public void RemoveAmbisonicSourceInstance(){} // RVA: 0x7FFAF8D26090
        public void UpdateAmbisonicWeights(){} // RVA: 0x7FFAF8D26110
        public void EncodeMonoToAmbisonic(){} // RVA: 0x7FFAF8D261E0
        public void RenderThreadEvent(){} // RVA: 0x7FFAF8D262C0
        public void get_RenderCaptureEventFunction(){} // RVA: 0x7FFAF8D26550
        public void get_RenderFreeEventFunction(){} // RVA: 0x7FFAF8D26660
        public void GetRenderEventFunc(){} // RVA: 0x7FFAF8D26770
        public void GetFreeResourcesEventFunc(){} // RVA: 0x7FFAF8D267E0
        public void Init(){} // RVA: 0x7FFAF8D26850
        public void Deinit(){} // RVA: 0x7FFAF8D268C0
        public void SetMicrophoneRecordingHint(){} // RVA: 0x7FFAF8D26930
        public void GetPluginVersionString(){} // RVA: 0x7FFAF8D269C0
        public void IsTrialVersion(){} // RVA: 0x7FFAF8D26AC0
        public void IsBasicEdition(){} // RVA: 0x7FFAF8D26B30
        public void GetVideoCodecCount(){} // RVA: 0x7FFAF8D26D60
        public void IsConfigureVideoCodecSupported(){} // RVA: 0x7FFAF8D26DD0
        public void GetVideoCodecMediaApi(){} // RVA: 0x7FFAF8D26E50
        public void ConfigureVideoCodec(){} // RVA: 0x7FFAF8D26ED0
        public void GetVideoCodecName(){} // RVA: 0x7FFAF8D28690 | overloaded x2
        public void GetAudioCodecCount(){} // RVA: 0x7FFAF8D27130
        public void IsConfigureAudioCodecSupported(){} // RVA: 0x7FFAF8D271A0
        public void GetAudioCodecMediaApi(){} // RVA: 0x7FFAF8D27220
        public void ConfigureAudioCodec(){} // RVA: 0x7FFAF8D272A0
        public void GetAudioCodecName(){} // RVA: 0x7FFAF8D28760 | overloaded x2
        public void GetAudioInputDeviceCount(){} // RVA: 0x7FFAF8D27500
        public void GetAudioInputDeviceName(){} // RVA: 0x7FFAF8D28830 | overloaded x2
        public void GetAudioInputDeviceMediaApi(){} // RVA: 0x7FFAF8D27750
        public void GetContainerFileExtensions(){} // RVA: 0x7FFAF8D28900 | overloaded x2
        public void CreateRecorderVideo(){} // RVA: 0x7FFAF8D27A90
        public void CreateRecorderImages(){} // RVA: 0x7FFAF8D27BA0
        public void CreateRecorderPipe(){} // RVA: 0x7FFAF8D27CB0
        public void Start(){} // RVA: 0x7FFAF8D27DA0
        public void IsNewFrameDue(){} // RVA: 0x7FFAF8D27E20
        public void SetEncodedFrameLimit(){} // RVA: 0x7FFAF8D27EA0
        public void EncodeFrame(){} // RVA: 0x7FFAF8D27F30
        public void EncodeAudio(){} // RVA: 0x7FFAF8D27FC0
        public void EncodeFrameWithAudio(){} // RVA: 0x7FFAF8D28060
        public void Pause(){} // RVA: 0x7FFAF8D28100
        public void Stop(){} // RVA: 0x7FFAF8D28180
        public void IsFileWritingComplete(){} // RVA: 0x7FFAF8D28210
        public void SetTexturePointer(){} // RVA: 0x7FFAF8D28290
        public void FreeRecorder(){} // RVA: 0x7FFAF8D28320
        public void GetNumDroppedFrames(){} // RVA: 0x7FFAF8D283A0
        public void GetNumDroppedEncoderFrames(){} // RVA: 0x7FFAF8D28420
        public void GetNumEncodedFrames(){} // RVA: 0x7FFAF8D284A0
        public void GetEncodedSeconds(){} // RVA: 0x7FFAF8D28520
        public void GetFileSize(){} // RVA: 0x7FFAF8D285A0
        public void GetPluginVersion(){} // RVA: 0x7FFAF8D28620
        public void SetLogFunction(){} // RVA: 0x7FFAF8D289E0
        public void SetErrorHandler(){} // RVA: 0x7FFAF8D28A60
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAF8D28AF0
    }

    public class TimelineController
    {
        // ── Methods ──
        public void get_ScanFrequency(){} // RVA: 0x7FFAF3210030
        public void set_ScanFrequency(){} // RVA: 0x7FFAF8D228E0
        public void Awake(){} // RVA: 0x7FFAF8D228F0
        public void OnValidate(){} // RVA: 0x7FFAF8D228F0
        public void UpdateFrame(){} // RVA: 0x7FFAF8D22900
        public void StartCapture(){} // RVA: 0x7FFAF8D22910
        public void StopCapture(){} // RVA: 0x7FFAF8D22A70
        public void ScanForPlayableDirectors(){} // RVA: 0x7FFAF8D22CF0
        public void OnDestroy(){} // RVA: 0x7FFAF8D23070
        public void ResetSceneLoading(){} // RVA: 0x7FFAF8D23120
        public void OnSceneLoaded(){} // RVA: 0x7FFAF8D23210
        public void .ctor(){} // RVA: 0x7FFAF8D23220
    }

    public class UnityAudioCapture
    {
        // ── Methods ──
        public void get_OverflowCount(){} // RVA: 0x7FFAF2FC9240
        public void get_SampleRate(){} // RVA: 0x7FFAF2ABD840
        public void get_ChannelCount(){} // RVA: 0x7FFAF2ABD840
        public void PrepareCapture(){} // RVA: 0x7FFAF2AD4A50
        public void StartCapture(){} // RVA: 0x7FFAF2AD4A50
        public void StopCapture(){} // RVA: 0x7FFAF2AD4A50
        public void FlushBuffer(){} // RVA: 0x7FFAF2AD4A50
        public void ReadData(){} // RVA: 0x7FFAF8D237C0
        public void GetUnityAudioChannelCount(){} // RVA: 0x7FFAF8D237D0
        public void GetChannelCount(){} // RVA: 0x7FFAF8D23910
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class Utils
    {
        // ── Methods ──
        public void GetNativeImageSequenceFormatNames(){} // RVA: 0x7FFAF8D3D060
        public void HasAlphaChannel(){} // RVA: 0x7FFAF8D3D0E0
        public void GetBestRenderTextureFormat(){} // RVA: 0x7FFAF8D3D150
        public void GetUltimateRenderCamera(){} // RVA: 0x7FFAF8D3D520
        public void HasContributingCameras(){} // RVA: 0x7FFAF8D3D800
        public void FindContributingCameras(){} // RVA: 0x7FFAF8D3D960
        public void URLEscapePathByPercentEncoding(){} // RVA: 0x7FFAF8D3E160
        public void ShowInExplorer(){} // RVA: 0x7FFAF8D3E5C0
        public void OpenInDefaultApp(){} // RVA: 0x7FFAF8D3E720
        public void GetFileSize(){} // RVA: 0x7FFAF8D3E8A0
        public void GetDiskFreeSpaceEx(){} // RVA: 0x7FFAF8D3E920
        public void DriveFreeBytes(){} // RVA: 0x7FFAF8D3E9F0
        public void GetImageFileExtension(){} // RVA: 0x7FFAF8D3EB90
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAF8D3EC60
    }

    public class VideoEncoderHints
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8D2A040
        public void SetDefaults(){} // RVA: 0x7FFAF8D2A040
        public void Validate(){} // RVA: 0x7FFAF8D2A090
    }

    public class VideoPlayerController
    {
        // ── Methods ──
        public void get_ScanFrequency(){} // RVA: 0x7FFAF3210030
        public void set_ScanFrequency(){} // RVA: 0x7FFAF8D23980
        public void Awake(){} // RVA: 0x7FFAF8D23990
        public void Start(){} // RVA: 0x7FFAF2D8D310
        public void OnValidate(){} // RVA: 0x7FFAF8D23990
        public void Update(){} // RVA: 0x7FFAF2D8D310
        public void UpdateFrame(){} // RVA: 0x7FFAF8D239A0
        public void CanContinue(){} // RVA: 0x7FFAF8D23B90
        public void WaitforSeekCompletes(){} // RVA: 0x7FFAF8D23D10
        public void WaitforSeekCompletes2(){} // RVA: 0x7FFAF2D8D310
        public void StartCapture(){} // RVA: 0x7FFAF8D23DB0
        public void StopCapture(){} // RVA: 0x7FFAF8D24020
        public void ScanForVideoPlayers(){} // RVA: 0x7FFAF8D24260
        public void OnDestroy(){} // RVA: 0x7FFAF8D24650
        public void ResetSceneLoading(){} // RVA: 0x7FFAF8D24700
        public void OnSceneLoaded(){} // RVA: 0x7FFAF8D247F0
        public void .ctor(){} // RVA: 0x7FFAF8D24800
        public void <WaitforSeekCompletes>b__13_0(){} // RVA: 0x7FFAF8D24970
    }

    public class WavWriter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8D3F4B0
        public void Dispose(){} // RVA: 0x7FFAF8D3F640
        public void WriteInterleaved(){} // RVA: 0x7FFAF8D3F710
        public void WriteHeader(){} // RVA: 0x7FFAF8D3FA90
        public void PackageInt(){} // RVA: 0x7FFAF8D40160
        public void .cctor(){} // RVA: 0x7FFAF8D40270
    }

}