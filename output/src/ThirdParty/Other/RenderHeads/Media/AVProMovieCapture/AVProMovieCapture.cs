// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.RenderHeads.Media.AVProMovieCapture
// Classes: 29
// Methods: 630

namespace ThirdParty.Other.RenderHeads.Media.AVProMovieCapture
{
    public class Ambisonic : Object
    {
        // ── Methods ──
        public void GetNormalisationWeights(){} // RVA: 0x7FFD53E30670
        public void GetCoeffCount(){} // RVA: 0x7FFD53E30700
        public void GetChannelOrder(){} // RVA: 0x7FFD53E30730
        public void GetNormalisation(){} // RVA: 0x7FFD53E30730
        public void .cctor(){} // RVA: 0x7FFD53E30740
        public void BuildWeightsFuMa(){} // RVA: 0x7FFD53E309E0
        public void GetN(){} // RVA: 0x7FFD53E30CB0
        public void GetM(){} // RVA: 0x7FFD53E30CF0
        public void Factorial(){} // RVA: 0x7FFD53E30D70
        public void GetNormalisationSN3D(){} // RVA: 0x7FFD53E30E80 | overloaded x2
        public void GetNormalisationN3D(){} // RVA: 0x7FFD53E31000
        public void BuildWeightsSN3D(){} // RVA: 0x7FFD53E310B0
    }

    public class AmbisonicSource : MonoBehaviour
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFD53E0B440
        public void OnDisable(){} // RVA: 0x7FFD53E0B870
        public void Setup(){} // RVA: 0x7FFD53E0BB40
        public void OnDrawGizmos(){} // RVA: 0x7FFD53E0BE90
        public void LateUpdate(){} // RVA: 0x7FFD53E0C1A0
        public void SetListenerRelativePosition(){} // RVA: 0x7FFD53E0C430
        public void UpdateCoefficients(){} // RVA: 0x7FFD53E0C450
        public void OnAudioFilterRead(){} // RVA: 0x7FFD53E0C810
        public void FlushBuffers(){} // RVA: 0x7FFD53E0CEC0
        public void GetFullBufferCount(){} // RVA: 0x7FFD53E0D290
        public void SendSamplesToSink(){} // RVA: 0x7FFD53E0D2E0
        public void .ctor(){} // RVA: 0x7FFD53E0D5A0
    }

    public class AmbisonicWavWriter : MonoBehaviour
    {
        public object Order;
        public object Format;

        // ── Methods ──
        public void get_Order(){} // RVA: 0x7FFD4E70C4C0
        public void get_Format(){} // RVA: 0x7FFD4F0A91D0
        public void AddSource(){} // RVA: 0x7FFD53E0D760
        public void RemoveSource(){} // RVA: 0x7FFD53E0D930
        public void OnDisable(){} // RVA: 0x7FFD53E0DAB0
        public void SetupSource(){} // RVA: 0x7FFD53E0DAC0
        public void ToggleCapturing(){} // RVA: 0x7FFD53E0DB70
        public void StartCapture(){} // RVA: 0x7FFD53E0DBA0
        public void StopCapture(){} // RVA: 0x7FFD53E0E2D0
        public void IsCapturing(){} // RVA: 0x7FFD53E0E500
        public void LateUpdate(){} // RVA: 0x7FFD53E0E520
        public void ProcessSources(){} // RVA: 0x7FFD53E0E640
        public void MixSamples(){} // RVA: 0x7FFD53E0E950
        public void FlushWavWriter(){} // RVA: 0x7FFD53E0EA70
        public void .ctor(){} // RVA: 0x7FFD53E0EAB0
    }

    public class AudioSourceToWav : MonoBehaviour
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFD53E0ECB0
        public void OnDisable(){} // RVA: 0x7FFD53E0EED0
        public void OnAudioFilterRead(){} // RVA: 0x7FFD53E0EF50
        public void .ctor(){} // RVA: 0x7FFD53E0EF80
    }

    public class CameraSelector : MonoBehaviour
    {
        public object Camera;
        public object SelectBy;
        public object ScanFrequency;
        public object ScanHiddenCameras;
        public object SelectTag;
        public object SelectName;

        // ── Methods ──
        public void get_Camera(){} // RVA: 0x7FFD4E3BE740
        public void set_Camera(){} // RVA: 0x7FFD53E0F050
        public void get_SelectBy(){} // RVA: 0x7FFD4E4FBBE0
        public void set_SelectBy(){} // RVA: 0x7FFD53E0F0C0
        public void get_ScanFrequency(){} // RVA: 0x7FFD4ED41980
        public void set_ScanFrequency(){} // RVA: 0x7FFD53E0F0D0
        public void get_ScanHiddenCameras(){} // RVA: 0x7FFD4E516BA0
        public void set_ScanHiddenCameras(){} // RVA: 0x7FFD53E0F0E0
        public void get_SelectTag(){} // RVA: 0x7FFD4E5F95E0
        public void set_SelectTag(){} // RVA: 0x7FFD53E0F0F0
        public void get_SelectName(){} // RVA: 0x7FFD4E5F0140
        public void set_SelectName(){} // RVA: 0x7FFD53E0F150
        public void Awake(){} // RVA: 0x7FFD53E0F1B0
        public void Start(){} // RVA: 0x7FFD53E0F1C0
        public void OnValidate(){} // RVA: 0x7FFD53E0F1B0
        public void Update(){} // RVA: 0x7FFD53E0F1D0
        public void OnDestroy(){} // RVA: 0x7FFD53E0F1F0
        public void ResetSceneLoading(){} // RVA: 0x7FFD53E0F290
        public void OnSceneLoaded(){} // RVA: 0x7FFD53E0F380
        public void ScanForCameraChange(){} // RVA: 0x7FFD53E0F390
        public void FindCamera(){} // RVA: 0x7FFD53E0F5C0
        public void UpdateCameraCache(){} // RVA: 0x7FFD53E0F900
        public void FindCameraByHighestDepth(){} // RVA: 0x7FFD53E0FAA0
        public void FindCameraByTag(){} // RVA: 0x7FFD53E0FC20
        public void FindCameraByName(){} // RVA: 0x7FFD53E0FCB0
        public void .ctor(){} // RVA: 0x7FFD53E0FD70
    }

    public class CaptureAudioFromAudioClip : MonoBehaviour
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFD53E0FF40
        public void Update(){} // RVA: 0x7FFD53E102F0
        public void GetAudioSamplesForFrame(){} // RVA: 0x7FFD53E10400
        public void .ctor(){} // RVA: 0x7FFD4E7DC840
    }

    public class CaptureAudioFromAudioListener : UnityAudioCapture
    {
        public object Buffer;
        public object BufferLength;
        public object BufferPtr;
        public object OverflowCount;
        public object SampleRate;
        public object ChannelCount;

        // ── Methods ──
        public void get_Buffer(){} // RVA: 0x7FFD4E5F95E0
        public void get_BufferLength(){} // RVA: 0x7FFD4E9AA870
        public void get_BufferPtr(){} // RVA: 0x7FFD53E10750
        public void get_OverflowCount(){} // RVA: 0x7FFD4F34D3C0
        public void get_SampleRate(){} // RVA: 0x7FFD53E10760
        public void get_ChannelCount(){} // RVA: 0x7FFD4E3E20C0
        public void PrepareCapture(){} // RVA: 0x7FFD53E107B0
        public void StartCapture(){} // RVA: 0x7FFD4F37BE50
        public void StopCapture(){} // RVA: 0x7FFD53E10D30
        public void ReadData(){} // RVA: 0x7FFD53E10F90
        public void FlushBuffer(){} // RVA: 0x7FFD53E11120
        public void OnAudioFilterRead(){} // RVA: 0x7FFD53E11260
        public void .ctor(){} // RVA: 0x7FFD53E115D0
    }

    public class CaptureAudioFromAudioRenderer : UnityAudioCapture
    {
        public object Capture;
        public object SampleRate;
        public object ChannelCount;

        // ── Methods ──
        public void get_Capture(){} // RVA: 0x7FFD4E36F0C0
        public void set_Capture(){} // RVA: 0x7FFD4E36F0D0
        public void get_SampleRate(){} // RVA: 0x7FFD53E10760
        public void get_ChannelCount(){} // RVA: 0x7FFD4E70C4C0
        public void PrepareCapture(){} // RVA: 0x7FFD53E11780
        public void GetAudioBufferOfLength(){} // RVA: 0x7FFD53E117A0
        public void DisposeAudioBuffer(){} // RVA: 0x7FFD4E341310
        public void StartCapture(){} // RVA: 0x7FFD53E11970
        public void StopCapture(){} // RVA: 0x7FFD53E11BE0
        public void FlushBuffer(){} // RVA: 0x7FFD53E11C70
        public void Update(){} // RVA: 0x7FFD53E11D60
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class CaptureAudioFromWwise : UnityAudioCapture
    {
        public object Capture;
        public object SampleRate;
        public object ChannelCount;

        // ── Methods ──
        public void get_Capture(){} // RVA: 0x7FFD4E36F0C0
        public void set_Capture(){} // RVA: 0x7FFD4E36F0D0
        public void Awake(){} // RVA: 0x7FFD53E11F20
        public void get_SampleRate(){} // RVA: 0x7FFD4E919180
        public void get_ChannelCount(){} // RVA: 0x7FFD4E919180
        public void PrepareCapture(){} // RVA: 0x7FFD4E341310
        public void FlushBuffer(){} // RVA: 0x7FFD4E341310
        public void StartCapture(){} // RVA: 0x7FFD4E341310
        public void StopCapture(){} // RVA: 0x7FFD4E341310
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class CaptureBase : MonoBehaviour
    {
        public object OutputTarget;
        public object OutputFolder;
        public object OutputFolderPath;
        public object FilenamePrefix;
        public object AppendFilenameTimestamp;
        public object AllowManualFileExtension;
        public object FilenameExtension;
        public object NamedPipePath;
        public object ImageSequenceStartFrame;
        public object ImageSequenceZeroDigits;
        public object UseMotionBlur;
        public object MotionBlurSamples;
        public object MotionBlurCameras;
        public object MotionBlur;
        public object ActiveFilePaths;
        public object LastFilePath;
        public object BeginFinalFileWritingAction;
        public object CompletedFileWritingAction;
        public object Stats;
        public object CameraRenderResolution;
        public object CameraRenderCustomResolution;
        public object CameraRenderAntiAliasing;
        public object IsRealTime;
        public object PersistAcrossSceneLoads;
        public object AudioCaptureSource;
        public object ManualAudioSampleRate;
        public object ManualAudioChannelCount;
        public object UnityAudioCapture;
        public object ForceAudioInputDeviceIndex;
        public object FrameRate;
        public object StartTrigger;
        public object StartDelay;
        public object StartDelaySeconds;
        public object StopMode;
        public object StopAfterFramesElapsed;
        public object StopAfterSecondsElapsed;
        public object CaptureStats;
        public object VideoCodecPriorityWindows;
        public object VideoCodecPriorityMacOS;
        public object AudioCodecPriorityWindows;
        public object AudioCodecPriorityMacOS;
        public object TimelapseScale;
        public object FrameUpdate;
        public object ResolutionDownScale;
        public object ResolutionDownscaleCustom;
        public object FlipVertically;
        public object UseWaitForEndOfFrame;
        public object LogCaptureStartStop;
        public object AllowOfflineVSyncDisable;
        public object SupportTextureRecreate;
        public object TimelineController;
        public object VideoPlayerController;
        public object SelectedVideoCodec;
        public object SelectedAudioCodec;
        public object SelectedAudioInputDevice;
        public object NativeForceVideoCodecIndex;
        public object NativeForceAudioCodecIndex;
        public object NativeImageSequenceFormat;
        public object LastFileSaved;

        // ── Methods ──
        public void get_OutputTarget(){} // RVA: 0x7FFD4FBF3260
        public void set_OutputTarget(){} // RVA: 0x7FFD53E31620
        public void get_OutputFolder(){} // RVA: 0x7FFD514A55D0
        public void set_OutputFolder(){} // RVA: 0x7FFD53E31630
        public void get_OutputFolderPath(){} // RVA: 0x7FFD4E751F50
        public void set_OutputFolderPath(){} // RVA: 0x7FFD4E8C4860
        public void get_FilenamePrefix(){} // RVA: 0x7FFD4E916C80
        public void set_FilenamePrefix(){} // RVA: 0x7FFD4E916750
        public void get_AppendFilenameTimestamp(){} // RVA: 0x7FFD4F5B6030
        public void set_AppendFilenameTimestamp(){} // RVA: 0x7FFD4F5B6040
        public void get_AllowManualFileExtension(){} // RVA: 0x7FFD4F9EA6A0
        public void set_AllowManualFileExtension(){} // RVA: 0x7FFD4F9E9FB0
        public void get_FilenameExtension(){} // RVA: 0x7FFD4E96B170
        public void set_FilenameExtension(){} // RVA: 0x7FFD4EDD3E10
        public void get_NamedPipePath(){} // RVA: 0x7FFD4E7DC6D0
        public void set_NamedPipePath(){} // RVA: 0x7FFD4E7D8580
        public void get_ImageSequenceStartFrame(){} // RVA: 0x7FFD53E31640
        public void set_ImageSequenceStartFrame(){} // RVA: 0x7FFD53E31650
        public void get_ImageSequenceZeroDigits(){} // RVA: 0x7FFD53CF4E90
        public void set_ImageSequenceZeroDigits(){} // RVA: 0x7FFD53E31660
        public void get_UseMotionBlur(){} // RVA: 0x7FFD4F558670
        public void set_UseMotionBlur(){} // RVA: 0x7FFD4F54E500
        public void get_MotionBlurSamples(){} // RVA: 0x7FFD53E31690
        public void set_MotionBlurSamples(){} // RVA: 0x7FFD53E316A0
        public void get_MotionBlurCameras(){} // RVA: 0x7FFD4E96DFA0
        public void set_MotionBlurCameras(){} // RVA: 0x7FFD4EDD99C0
        public void get_MotionBlur(){} // RVA: 0x7FFD4E962410
        public void set_MotionBlur(){} // RVA: 0x7FFD4EDC74B0
        public void get_ActiveFilePaths(){} // RVA: 0x7FFD53E316D0
        public void get_LastFilePath(){} // RVA: 0x7FFD4E961C80
        public void get_BeginFinalFileWritingAction(){} // RVA: 0x7FFD4E964790
        public void set_BeginFinalFileWritingAction(){} // RVA: 0x7FFD4E96D230
        public void get_CompletedFileWritingAction(){} // RVA: 0x7FFD4E964780
        public void set_CompletedFileWritingAction(){} // RVA: 0x7FFD4E96D290
        public void get_Stats(){} // RVA: 0x7FFD4E961470
        public void get_CameraRenderResolution(){} // RVA: 0x7FFD4F0AEC30
        public void set_CameraRenderResolution(){} // RVA: 0x7FFD53CE7220
        public void get_CameraRenderCustomResolution(){} // RVA: 0x7FFD53E31730
        public void set_CameraRenderCustomResolution(){} // RVA: 0x7FFD53E31750
        public void get_CameraRenderAntiAliasing(){} // RVA: 0x7FFD4F4C8560
        public void set_CameraRenderAntiAliasing(){} // RVA: 0x7FFD4F4C3880
        public void get_IsRealTime(){} // RVA: 0x7FFD4F9C8350
        public void set_IsRealTime(){} // RVA: 0x7FFD4F9C8340
        public void get_PersistAcrossSceneLoads(){} // RVA: 0x7FFD4FBDA6D0
        public void set_PersistAcrossSceneLoads(){} // RVA: 0x7FFD4FBDA6E0
        public void get_AudioCaptureSource(){} // RVA: 0x7FFD4EAB6B20
        public void set_AudioCaptureSource(){} // RVA: 0x7FFD4F9B1C30
        public void get_ManualAudioSampleRate(){} // RVA: 0x7FFD4FBF5FD0
        public void set_ManualAudioSampleRate(){} // RVA: 0x7FFD51B353A0
        public void get_ManualAudioChannelCount(){} // RVA: 0x7FFD4FBF5FE0
        public void set_ManualAudioChannelCount(){} // RVA: 0x7FFD53E31760
        public void get_UnityAudioCapture(){} // RVA: 0x7FFD4E960F70
        public void set_UnityAudioCapture(){} // RVA: 0x7FFD4E3C28A0
        public void get_ForceAudioInputDeviceIndex(){} // RVA: 0x7FFD4FC57F50
        public void set_ForceAudioInputDeviceIndex(){} // RVA: 0x7FFD53E31770
        public void get_FrameRate(){} // RVA: 0x7FFD4E3A9540
        public void set_FrameRate(){} // RVA: 0x7FFD53E31780
        public void get_StartTrigger(){} // RVA: 0x7FFD4E3E20C0
        public void set_StartTrigger(){} // RVA: 0x7FFD4E3E20D0
        public void get_StartDelay(){} // RVA: 0x7FFD4F34D3C0
        public void set_StartDelay(){} // RVA: 0x7FFD4FCBE500
        public void get_StartDelaySeconds(){} // RVA: 0x7FFD4E3A9460
        public void set_StartDelaySeconds(){} // RVA: 0x7FFD53E317B0
        public void get_StopMode(){} // RVA: 0x7FFD4ECB13D0
        public void set_StopMode(){} // RVA: 0x7FFD4ECB0750
        public void get_StopAfterFramesElapsed(){} // RVA: 0x7FFD4EA4EA40
        public void set_StopAfterFramesElapsed(){} // RVA: 0x7FFD53E317C0
        public void get_StopAfterSecondsElapsed(){} // RVA: 0x7FFD4E36A000
        public void set_StopAfterSecondsElapsed(){} // RVA: 0x7FFD53E317D0
        public void get_CaptureStats(){} // RVA: 0x7FFD4E961470
        public void get_VideoCodecPriorityWindows(){} // RVA: 0x7FFD4E3DF370
        public void set_VideoCodecPriorityWindows(){} // RVA: 0x7FFD53E317E0
        public void get_VideoCodecPriorityMacOS(){} // RVA: 0x7FFD4E3BCD50
        public void set_VideoCodecPriorityMacOS(){} // RVA: 0x7FFD53E31840
        public void get_AudioCodecPriorityWindows(){} // RVA: 0x7FFD4E505600
        public void set_AudioCodecPriorityWindows(){} // RVA: 0x7FFD53E318A0
        public void get_AudioCodecPriorityMacOS(){} // RVA: 0x7FFD4E70F410
        public void set_AudioCodecPriorityMacOS(){} // RVA: 0x7FFD53E31900
        public void get_TimelapseScale(){} // RVA: 0x7FFD4E640670
        public void set_TimelapseScale(){} // RVA: 0x7FFD4E84B670
        public void get_FrameUpdate(){} // RVA: 0x7FFD4FCBE530
        public void set_FrameUpdate(){} // RVA: 0x7FFD4FCBE540
        public void get_ResolutionDownScale(){} // RVA: 0x7FFD4FCBE520
        public void set_ResolutionDownScale(){} // RVA: 0x7FFD4FCBEAA0
        public void get_ResolutionDownscaleCustom(){} // RVA: 0x7FFD53E31960
        public void set_ResolutionDownscaleCustom(){} // RVA: 0x7FFD53BAD950
        public void get_FlipVertically(){} // RVA: 0x7FFD4F14B010
        public void set_FlipVertically(){} // RVA: 0x7FFD4F143EE0
        public void get_UseWaitForEndOfFrame(){} // RVA: 0x7FFD53E31980
        public void set_UseWaitForEndOfFrame(){} // RVA: 0x7FFD53E31990
        public void get_LogCaptureStartStop(){} // RVA: 0x7FFD4FB58E90
        public void set_LogCaptureStartStop(){} // RVA: 0x7FFD53E319A0
        public void get_AllowOfflineVSyncDisable(){} // RVA: 0x7FFD53E319B0
        public void set_AllowOfflineVSyncDisable(){} // RVA: 0x7FFD53E319C0
        public void get_SupportTextureRecreate(){} // RVA: 0x7FFD53E319D0
        public void set_SupportTextureRecreate(){} // RVA: 0x7FFD53E319E0
        public void get_TimelineController(){} // RVA: 0x7FFD4E96E2F0
        public void set_TimelineController(){} // RVA: 0x7FFD4EDC80B0
        public void get_VideoPlayerController(){} // RVA: 0x7FFD4E78D850
        public void set_VideoPlayerController(){} // RVA: 0x7FFD4EDD5DB0
        public void get_SelectedVideoCodec(){} // RVA: 0x7FFD4E964330
        public void get_SelectedAudioCodec(){} // RVA: 0x7FFD4E9622B0
        public void get_SelectedAudioInputDevice(){} // RVA: 0x7FFD4EDECB10
        public void get_NativeForceVideoCodecIndex(){} // RVA: 0x7FFD4ED255C0
        public void set_NativeForceVideoCodecIndex(){} // RVA: 0x7FFD4ED1D010
        public void get_NativeForceAudioCodecIndex(){} // RVA: 0x7FFD4F73B350
        public void set_NativeForceAudioCodecIndex(){} // RVA: 0x7FFD4F73A220
        public void get_NativeImageSequenceFormat(){} // RVA: 0x7FFD53E319F0
        public void set_NativeImageSequenceFormat(){} // RVA: 0x7FFD53E31A00
        public void GetCurrentPlatform(){} // RVA: 0x7FFD4E919180
        public void GetEncoderHints(){} // RVA: 0x7FFD53E31A10
        public void SetEncoderHints(){} // RVA: 0x7FFD53E31AC0
        public void UpdateMediaGallery(){} // RVA: 0x7FFD4E341310
        public void Awake(){} // RVA: 0x7FFD53E31CE0
        public void .cctor(){} // RVA: 0x7FFD53E32310
        public void Start(){} // RVA: 0x7FFD53E32E30
        public void SelectCodec(){} // RVA: 0x7FFD53E32F60
        public void SelectVideoCodec(){} // RVA: 0x7FFD53E33310
        public void SelectAudioCodec(){} // RVA: 0x7FFD53E334F0
        public void SelectAudioInputDevice(){} // RVA: 0x7FFD53E33660
        public void GetRecordingResolution(){} // RVA: 0x7FFD53E338C0
        public void SelectRecordingResolution(){} // RVA: 0x7FFD53E33990
        public void OnDestroy(){} // RVA: 0x7FFD53E33AA0
        public void FreePendingFileWrites(){} // RVA: 0x7FFD53E33E10
        public void OnApplicationQuit(){} // RVA: 0x7FFD53E33FB0
        public void OnApplicationPause(){} // RVA: 0x7FFD4E341310
        public void EncodeTexture(){} // RVA: 0x7FFD53E34010
        public void IsUsingUnityAudioComponent(){} // RVA: 0x7FFD53E34120
        public void IsUsingMotionBlur(){} // RVA: 0x7FFD53E34220
        public void EncodePointer(){} // RVA: 0x7FFD53E34310
        public void IsPrepared(){} // RVA: 0x7FFD53E344A0
        public void IsCapturing(){} // RVA: 0x7FFD53E344B0
        public void IsPaused(){} // RVA: 0x7FFD53E344C0
        public void GetRecordingWidth(){} // RVA: 0x7FFD53E344D0
        public void GetRecordingHeight(){} // RVA: 0x7FFD53E344E0
        public void GenerateTimestampedFilename(){} // RVA: 0x7FFD53E344F0
        public void GetFolder(){} // RVA: 0x7FFD53E347D0
        public void GenerateFilePath(){} // RVA: 0x7FFD53E349B0
        public void HasExtension(){} // RVA: 0x7FFD53E34A50
        public void GenerateFilename(){} // RVA: 0x7FFD53E34BA0
        public void FindOrCreateUnityAudioCapture(){} // RVA: 0x7FFD53E35390
        public void ValidateEditionFeatures(){} // RVA: 0x7FFD53E35A30
        public void PrepareCapture(){} // RVA: 0x7FFD53E36160
        public void QueueStartCapture(){} // RVA: 0x7FFD53E37E80
        public void IsStartCaptureQueued(){} // RVA: 0x7FFD53E37F20
        public void UpdateInjectionOptions(){} // RVA: 0x7FFD53E37F30
        public void StartCapture(){} // RVA: 0x7FFD53E37FC0
        public void PauseCapture(){} // RVA: 0x7FFD53E38480
        public void ResumeCapture(){} // RVA: 0x7FFD53E385C0
        public void CancelCapture(){} // RVA: 0x7FFD53E386D0
        public void DeleteCapture(){} // RVA: 0x7FFD53E38700
        public void UnprepareCapture(){} // RVA: 0x7FFD4E341310
        public void get_LastFileSaved(){} // RVA: 0x7FFD53E38810
        public void set_LastFileSaved(){} // RVA: 0x7FFD53E388C0
        public void RenderThreadEvent(){} // RVA: 0x7FFD53E38910
        public void StopCapture(){} // RVA: 0x7FFD53E38980
        public void CreatePostOperationsOptions(){} // RVA: 0x7FFD53E396B0
        public void CanApplyPostOperations(){} // RVA: 0x7FFD53E39780
        public void ApplyPostOperations(){} // RVA: 0x7FFD53E39970
        public void ToggleCapture(){} // RVA: 0x7FFD53E39BA0
        public void IsEnoughDiskSpace(){} // RVA: 0x7FFD53E39BE0
        public void CanContinue(){} // RVA: 0x7FFD53E39C20
        public void Update(){} // RVA: 0x7FFD53E39D40
        public void LateUpdate(){} // RVA: 0x7FFD53E39DB0
        public void RemoveCompletedFileWrites(){} // RVA: 0x7FFD53E3A0E0
        public void CheckFreeDiskSpace(){} // RVA: 0x7FFD53E3A1C0
        public void IsStartDelayComplete(){} // RVA: 0x7FFD53E3A280
        public void IsStopTimeReached(){} // RVA: 0x7FFD53E3A2B0
        public void GetProgress(){} // RVA: 0x7FFD53E3A3A0
        public void GetSecondsPerCaptureFrame(){} // RVA: 0x7FFD53E3A460
        public void CanOutputFrame(){} // RVA: 0x7FFD53E3A490
        public void TickFrameTimer(){} // RVA: 0x7FFD53E3A6C0
        public void RenormTimer(){} // RVA: 0x7FFD53E3A730
        public void GetPreviewTexture(){} // RVA: 0x7FFD4E919180
        public void EncodeUnityAudio(){} // RVA: 0x7FFD53E3A780
        public void EncodeAudio(){} // RVA: 0x7FFD53E3A8D0 | overloaded x2
        public void PreUpdateFrame(){} // RVA: 0x7FFD53E3AB30
        public void UpdateFrame(){} // RVA: 0x7FFD53E3AD10
        public void ResetFPS(){} // RVA: 0x7FFD53E3B050
        public void UpdateFPS(){} // RVA: 0x7FFD53E3B080
        public void GetCameraAntiAliasingLevel(){} // RVA: 0x7FFD53E3B110
        public void GetCaptureFileSize(){} // RVA: 0x7FFD53E3B380
        public void GetResolution(){} // RVA: 0x7FFD53E3B490
        public void NextMultipleOf4(){} // RVA: 0x7FFD4F2D7160
        public void HasUserAuthorisationToCaptureAudio(){} // RVA: 0x7FFD53E3B610
        public void RequestUserAuthorisationToCaptureAudioCallback(){} // RVA: 0x7FFD53E3B6F0
        public void RequestAudioCaptureDeviceUserAuthorisation(){} // RVA: 0x7FFD4E919180
        public void HasUserAuthorisationToAccessPhotos(){} // RVA: 0x7FFD53E3B770
        public void RequestUserAuthorisationToAccessPhotosCallback(){} // RVA: 0x7FFD53E3B850
        public void RequestUserAuthorisationToAccessPhotos(){} // RVA: 0x7FFD4E919180
        public void .ctor(){} // RVA: 0x7FFD53E3B8D0
    }

    public class CaptureFromCamera : CaptureBase
    {
        public object CameraSelector;
        public object UseContributingCameras;

        // ── Methods ──
        public void get_CameraSelector(){} // RVA: 0x7FFD4E9693F0
        public void set_CameraSelector(){} // RVA: 0x7FFD4E96AC80
        public void get_UseContributingCameras(){} // RVA: 0x7FFD53E11F80
        public void set_UseContributingCameras(){} // RVA: 0x7FFD53E11F90
        public void SetCamera(){} // RVA: 0x7FFD53E12300 | overloaded x2
        public void RequiresResolve(){} // RVA: 0x7FFD53E123C0
        public void HasCamera(){} // RVA: 0x7FFD53E124F0
        public void HasContributingCameras(){} // RVA: 0x7FFD53E125C0
        public void UpdateFrame(){} // RVA: 0x7FFD53E125F0
        public void FinalRenderCapture(){} // RVA: 0x7FFD53E128E0
        public void Capture(){} // RVA: 0x7FFD53E12980
        public void RequiresHDR(){} // RVA: 0x7FFD53E12A20
        public void UpdateTexture(){} // RVA: 0x7FFD53E12C00
        public void UnprepareCapture(){} // RVA: 0x7FFD53E13580
        public void CreateResolveTexture(){} // RVA: 0x7FFD53E137B0
        public void GetPreviewTexture(){} // RVA: 0x7FFD4EDEABF0
        public void PrepareCapture(){} // RVA: 0x7FFD53E13C60
        public void OnDestroy(){} // RVA: 0x7FFD53E147E0
        public void .ctor(){} // RVA: 0x7FFD53E14AD0
        public void <>n__0(){} // RVA: 0x7FFD53E14B30
    }

    public class CaptureFromCamera360 : CaptureBase
    {
        public object CameraSelector;
        public object CubemapFaceResolution;
        public object CubemapDepthResolution;
        public object SupportGUI;
        public object SupportCameraRotation;
        public object OnlyLeftRightRotation;
        public object Render180Degrees;
        public object StereoRendering;
        public object IPD;

        // ── Methods ──
        public void get_CameraSelector(){} // RVA: 0x7FFD4E9693F0
        public void set_CameraSelector(){} // RVA: 0x7FFD4E96AC80
        public void get_CubemapFaceResolution(){} // RVA: 0x7FFD4F9199D0
        public void set_CubemapFaceResolution(){} // RVA: 0x7FFD4F9195F0
        public void get_CubemapDepthResolution(){} // RVA: 0x7FFD4F91A0A0
        public void set_CubemapDepthResolution(){} // RVA: 0x7FFD4F919B10
        public void get_SupportGUI(){} // RVA: 0x7FFD53E15240
        public void set_SupportGUI(){} // RVA: 0x7FFD53E15250
        public void get_SupportCameraRotation(){} // RVA: 0x7FFD53E15260
        public void set_SupportCameraRotation(){} // RVA: 0x7FFD53E15270
        public void get_OnlyLeftRightRotation(){} // RVA: 0x7FFD53E15280
        public void set_OnlyLeftRightRotation(){} // RVA: 0x7FFD53E15290
        public void get_Render180Degrees(){} // RVA: 0x7FFD53E152A0
        public void set_Render180Degrees(){} // RVA: 0x7FFD53E152B0
        public void get_StereoRendering(){} // RVA: 0x7FFD4F9195E0
        public void set_StereoRendering(){} // RVA: 0x7FFD53E152C0
        public void get_IPD(){} // RVA: 0x7FFD53E152D0
        public void set_IPD(){} // RVA: 0x7FFD53E152E0
        public void .ctor(){} // RVA: 0x7FFD53E152F0
        public void GetCubemapRenderingMethod(){} // RVA: 0x7FFD53E15380
        public void SetCamera(){} // RVA: 0x7FFD4EDD5A80
        public void UpdateFrame(){} // RVA: 0x7FFD53E153A0
        public void FinalRenderCapture(){} // RVA: 0x7FFD53E15660
        public void Capture(){} // RVA: 0x7FFD53E15700
        public void ClearCubemap(){} // RVA: 0x7FFD53E15BA0
        public void RenderCubemapToEquiRect(){} // RVA: 0x7FFD53E16050
        public void UpdateTexture(){} // RVA: 0x7FFD53E16210
        public void RenderCameraToCubemap(){} // RVA: 0x7FFD53E16A40
        public void AccumulateMotionBlur(){} // RVA: 0x7FFD53E18510
        public void PrepareCapture(){} // RVA: 0x7FFD53E186D0
        public void GetPreviewTexture(){} // RVA: 0x7FFD53E198C0
        public void Start(){} // RVA: 0x7FFD53E19900
        public void OnDestroy(){} // RVA: 0x7FFD53E19CC0
    }

    public class CaptureFromCamera360ODS : CaptureBase
    {
        public object Setup;

        // ── Methods ──
        public void get_Setup(){} // RVA: 0x7FFD4E9693F0
        public void .ctor(){} // RVA: 0x7FFD53E1A2A0
        public void SetCamera(){} // RVA: 0x7FFD53E1A3C0
        public void Start(){} // RVA: 0x7FFD53E1A430
        public void CreateEye(){} // RVA: 0x7FFD53E1A660
        public void UpdateFrame(){} // RVA: 0x7FFD53E1B760
        public void FinalRenderCapture(){} // RVA: 0x7FFD53E1BA50
        public void Capture(){} // RVA: 0x7FFD53E1BAF0
        public void AccumulateMotionBlur(){} // RVA: 0x7FFD53E1BD60
        public void RenderFrame(){} // RVA: 0x7FFD53E1BF30
        public void GetPreviewTexture(){} // RVA: 0x7FFD53E1CBD0
        public void PrepareCapture(){} // RVA: 0x7FFD53E1CC10
        public void DestroyEye(){} // RVA: 0x7FFD53E1DD80
        public void OnDestroy(){} // RVA: 0x7FFD53E1DFB0
    }

    public class CaptureFromScreen : CaptureBase
    {
        public object CaptureMouseCursor;
        public object MouseCursor;

        // ── Methods ──
        public void get_CaptureMouseCursor(){} // RVA: 0x7FFD53E1E710
        public void set_CaptureMouseCursor(){} // RVA: 0x7FFD53E1E720
        public void get_MouseCursor(){} // RVA: 0x7FFD4E960FB0
        public void set_MouseCursor(){} // RVA: 0x7FFD4EDCE720
        public void PrepareCapture(){} // RVA: 0x7FFD53E1E730
        public void CopyRenderTargetToTexture(){} // RVA: 0x7FFD53E1EA90
        public void FreeRenderResources(){} // RVA: 0x7FFD53E1F0A0
        public void UnprepareCapture(){} // RVA: 0x7FFD53E1F2C0
        public void FinalRenderCapture(){} // RVA: 0x7FFD53E1F430
        public void UpdateFrame(){} // RVA: 0x7FFD53E1F4D0
        public void .ctor(){} // RVA: 0x7FFD53E1F590
    }

    public class CaptureFromTexture : CaptureBase
    {
        public object IsManualUpdate;

        // ── Methods ──
        public void get_IsManualUpdate(){} // RVA: 0x7FFD53E1E710
        public void set_IsManualUpdate(){} // RVA: 0x7FFD53E1E720
        public void SetSourceTexture(){} // RVA: 0x7FFD4EDCE720
        public void RequiresResolve(){} // RVA: 0x7FFD53E1F7B0
        public void UpdateSourceTexture(){} // RVA: 0x7FFD53E1F8E0
        public void ShouldCaptureFrame(){} // RVA: 0x7FFD53E1F8F0
        public void HasSourceTextureChanged(){} // RVA: 0x7FFD53E1F9E0
        public void UpdateFrame(){} // RVA: 0x7FFD53E1FA00
        public void FinalRenderCapture(){} // RVA: 0x7FFD53E1FAD0
        public void Capture(){} // RVA: 0x7FFD53E1FB70
        public void CreateResolveTexture(){} // RVA: 0x7FFD53E1FF80
        public void AccumulateMotionBlur(){} // RVA: 0x7FFD53E20330
        public void GetPreviewTexture(){} // RVA: 0x7FFD53E20450
        public void PrepareCapture(){} // RVA: 0x7FFD53E205C0
        public void UnprepareCapture(){} // RVA: 0x7FFD53E209B0
        public void .ctor(){} // RVA: 0x7FFD53E20B80
    }

    public class CaptureFromWebCamTexture : CaptureFromTexture
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD53E20CD0
        public void .ctor(){} // RVA: 0x7FFD53E20B80
    }

    public class CaptureGUI : MonoBehaviour
    {
        public object MovieCapture;
        public object HideUiWhenRecording;
        public object ShowUI;

        // ── Methods ──
        public void get_MovieCapture(){} // RVA: 0x7FFD4E36F0C0
        public void set_MovieCapture(){} // RVA: 0x7FFD4E36F0D0
        public void get_HideUiWhenRecording(){} // RVA: 0x7FFD4EC8C550
        public void set_HideUiWhenRecording(){} // RVA: 0x7FFD4F7D4D70
        public void get_ShowUI(){} // RVA: 0x7FFD4E516BA0
        public void set_ShowUI(){} // RVA: 0x7FFD4F044F40
        public void Start(){} // RVA: 0x7FFD53E20D30
        public void CreateGUI(){} // RVA: 0x7FFD53E20E10
        public void OnGUI(){} // RVA: 0x7FFD53E21A70
        public void MyWindow(){} // RVA: 0x7FFD53E22550
        public void GUI_RecordingStatus(){} // RVA: 0x7FFD53E24DD0
        public void DrawPauseResumeButtons(){} // RVA: 0x7FFD53E26860
        public void DrawGuiField(){} // RVA: 0x7FFD53E27080
        public void StartCapture(){} // RVA: 0x7FFD53E27150
        public void StopCapture(){} // RVA: 0x7FFD53E27250
        public void CancelCapture(){} // RVA: 0x7FFD53E27350
        public void ResumeCapture(){} // RVA: 0x7FFD53E27450
        public void PauseCapture(){} // RVA: 0x7FFD53E27530
        public void Update(){} // RVA: 0x7FFD53E27610
        public void .ctor(){} // RVA: 0x7FFD53E278D0
        public void .cctor(){} // RVA: 0x7FFD53E27E90
    }

    public class CodecManager : Object
    {
        public object VideoCodecs;
        public object AudioCodecs;

        // ── Methods ──
        public void FindCodec(){} // RVA: 0x7FFD53E3C710
        public void GetCodecCount(){} // RVA: 0x7FFD53E3C820
        public void CheckInit(){} // RVA: 0x7FFD53E3C890
        public void GetCodecs(){} // RVA: 0x7FFD53E3C940
        public void EnumerateCodecs(){} // RVA: 0x7FFD53E3C9E0
        public void get_VideoCodecs(){} // RVA: 0x7FFD53E3D400
        public void get_AudioCodecs(){} // RVA: 0x7FFD53E3D460
        public void .cctor(){} // RVA: 0x7FFD53E3D4C0
    }

    public class DeviceManager : Object
    {
        public object AudioInputDevices;

        // ── Methods ──
        public void FindDevice(){} // RVA: 0x7FFD53E3D930
        public void GetDeviceCount(){} // RVA: 0x7FFD53E3DA80
        public void CheckInit(){} // RVA: 0x7FFD53E3DB30
        public void GetDevices(){} // RVA: 0x7FFD53E3DBE0
        public void EnumerateDevices(){} // RVA: 0x7FFD53E3DC50
        public void get_AudioInputDevices(){} // RVA: 0x7FFD53E3DFB0
        public void .cctor(){} // RVA: 0x7FFD53E3E010
    }

    public class FileWritingHandler : Object
    {
        public object Status;
        public object Path;
        public object CompletedFileWritingAction;

        // ── Methods ──
        public void get_Status(){} // RVA: 0x7FFD4E5110E0
        public void get_Path(){} // RVA: 0x7FFD4E35C380
        public void get_CompletedFileWritingAction(){} // RVA: 0x7FFD4E3BCD50
        public void set_CompletedFileWritingAction(){} // RVA: 0x7FFD4E3BCD60
        public void .ctor(){} // RVA: 0x7FFD53E3E110
        public void SetFilePostProcess(){} // RVA: 0x7FFD53E3E1F0
        public void StartPostProcess(){} // RVA: 0x7FFD53E3E250
        public void IsFileReady(){} // RVA: 0x7FFD53E3E390
        public void Dispose(){} // RVA: 0x7FFD53E3E590
        public void Cleanup(){} // RVA: 0x7FFD53E3E840
    }

    public class MP4FileProcessing : Object
    {
        // ── Methods ──
        public void ProcessFileAsync(){} // RVA: 0x7FFD53E3E920
        public void ProcessFile(){} // RVA: 0x7FFD53E3EF50 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFD53E3F350
        public void Process(){} // RVA: 0x7FFD53E3F500
        public void Close(){} // RVA: 0x7FFD53E40000
        public void GetFirstChunkOfType(){} // RVA: 0x7FFD53E40200
        public void ReadChildChunks(){} // RVA: 0x7FFD53E40450 | overloaded x2
        public void ReadChunkHeader(){} // RVA: 0x7FFD53E40650
        public void ChunkContainsChildChunkWithId(){} // RVA: 0x7FFD53E40830
        public void ChunkDesc(){} // RVA: 0x7FFD53E409A0
        public void WriteChunk(){} // RVA: 0x7FFD53E40CE0
        public void CopyChunkHeader(){} // RVA: 0x7FFD53E40D60
        public void InjectChunkHeader(){} // RVA: 0x7FFD53E40DE0
        public void CopyBytes(){} // RVA: 0x7FFD53E40E60
        public void WriteZeros(){} // RVA: 0x7FFD53E40F70
        public void WriteChunkRecursive_moov(){} // RVA: 0x7FFD53E41020
        public void IsVideoTrack(){} // RVA: 0x7FFD53E41730
        public void WriteChunk_stco(){} // RVA: 0x7FFD53E41880
        public void WriteChunk_co64_from_stco(){} // RVA: 0x7FFD53E41980
        public void WriteChunk_co64(){} // RVA: 0x7FFD53E41AB0
        public void InjectChunkStub_co64_from_stco(){} // RVA: 0x7FFD53E41BA0
        public void WriteChunk_stsd(){} // RVA: 0x7FFD53E41D00
        public void Convert(){} // RVA: 0x7FFD53E42210
        public void InjectChunk_st3d(){} // RVA: 0x7FFD53E42230
        public void InjectChunk_sv3d(){} // RVA: 0x7FFD53E42300
        public void InjectChunk_uuid_GoogleSphericalVideoV1(){} // RVA: 0x7FFD53E42490
        public void InjectChunk_svhd(){} // RVA: 0x7FFD53E42730
        public void InjectChunk_proj(){} // RVA: 0x7FFD53E42980
        public void InjectChunk_prhd(){} // RVA: 0x7FFD53E42D80
        public void InjectChunk_equi(){} // RVA: 0x7FFD53E42EF0
        public void OverwriteChunkSize(){} // RVA: 0x7FFD53E43070
        public void ReadUInt16(){} // RVA: 0x7FFD53E43130
        public void ReadUInt32(){} // RVA: 0x7FFD53E43240
        public void ReadUInt64(){} // RVA: 0x7FFD53E43350
        public void WriteUInt16(){} // RVA: 0x7FFD53E43460
        public void WriteChunkId(){} // RVA: 0x7FFD53E43550
        public void WriteUInt32(){} // RVA: 0x7FFD53E43560
        public void WriteUInt64(){} // RVA: 0x7FFD53E43660
        public void ChunkIdToString(){} // RVA: 0x7FFD53E43750
        public void ChunkId(){} // RVA: 0x7FFD53E439D0
        public void DebugLog(){} // RVA: 0x7FFD53E43A20
        public void .cctor(){} // RVA: 0x7FFD53E43A70
    }

    public class MotionBlur : MonoBehaviour
    {
        public object IsFrameAccumulated;
        public object NumSamples;
        public object FrameCount;
        public object FinalTexture;

        // ── Methods ──
        public void get_IsFrameAccumulated(){} // RVA: 0x7FFD4F9C1580
        public void set_IsFrameAccumulated(){} // RVA: 0x7FFD4F9C1C60
        public void get_NumSamples(){} // RVA: 0x7FFD4ED41980
        public void set_NumSamples(){} // RVA: 0x7FFD53E28230
        public void get_FrameCount(){} // RVA: 0x7FFD4E3E20C0
        public void get_FinalTexture(){} // RVA: 0x7FFD4E5F95E0
        public void Awake(){} // RVA: 0x7FFD53E28240
        public void SetTargetSize(){} // RVA: 0x7FFD53E28360
        public void Start(){} // RVA: 0x7FFD53E28380
        public void OnEnable(){} // RVA: 0x7FFD53E28390
        public void Setup(){} // RVA: 0x7FFD53E283B0
        public void ClearAccumulation(){} // RVA: 0x7FFD53E28BD0
        public void OnDestroy(){} // RVA: 0x7FFD53E28D20
        public void OnNumSamplesChanged(){} // RVA: 0x7FFD53E29240
        public void LerpUnclamped(){} // RVA: 0x7FFD53E293C0
        public void ApplyWeighting(){} // RVA: 0x7FFD53E293D0
        public void Accumulate(){} // RVA: 0x7FFD53E29550
        public void OnRenderImage(){} // RVA: 0x7FFD53E29640
        public void .ctor(){} // RVA: 0x7FFD53E296C0
    }

    public class MouseCursor : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD53E29720
        public void SetTexture(){} // RVA: 0x7FFD53E29730
        public void OnGUI(){} // RVA: 0x7FFD53E29930
        public void .ctor(){} // RVA: 0x7FFD53E29BE0
    }

    public class NativePlugin : Object
    {
        public object RenderCaptureEventFunction;
        public object RenderFreeEventFunction;

        // ── Methods ──
        public void AddAmbisonicSourceInstance(){} // RVA: 0x7FFD53E2D3B0
        public void RemoveAmbisonicSourceInstance(){} // RVA: 0x7FFD53E2D430
        public void UpdateAmbisonicWeights(){} // RVA: 0x7FFD53E2D4B0
        public void EncodeMonoToAmbisonic(){} // RVA: 0x7FFD53E2D580
        public void RenderThreadEvent(){} // RVA: 0x7FFD53E2D660
        public void get_RenderCaptureEventFunction(){} // RVA: 0x7FFD53E2D8F0
        public void get_RenderFreeEventFunction(){} // RVA: 0x7FFD53E2DA00
        public void GetRenderEventFunc(){} // RVA: 0x7FFD53E2DB10
        public void GetFreeResourcesEventFunc(){} // RVA: 0x7FFD53E2DB80
        public void Init(){} // RVA: 0x7FFD53E2DBF0
        public void Deinit(){} // RVA: 0x7FFD53E2DC60
        public void SetMicrophoneRecordingHint(){} // RVA: 0x7FFD53E2DCD0
        public void GetPluginVersionString(){} // RVA: 0x7FFD53E2DD60
        public void IsTrialVersion(){} // RVA: 0x7FFD53E2DE60
        public void IsBasicEdition(){} // RVA: 0x7FFD53E2DED0
        public void GetVideoCodecCount(){} // RVA: 0x7FFD53E2E100
        public void IsConfigureVideoCodecSupported(){} // RVA: 0x7FFD53E2E170
        public void GetVideoCodecMediaApi(){} // RVA: 0x7FFD53E2E1F0
        public void ConfigureVideoCodec(){} // RVA: 0x7FFD53E2E270
        public void GetVideoCodecName(){} // RVA: 0x7FFD53E2FA30 | overloaded x2
        public void GetAudioCodecCount(){} // RVA: 0x7FFD53E2E4D0
        public void IsConfigureAudioCodecSupported(){} // RVA: 0x7FFD53E2E540
        public void GetAudioCodecMediaApi(){} // RVA: 0x7FFD53E2E5C0
        public void ConfigureAudioCodec(){} // RVA: 0x7FFD53E2E640
        public void GetAudioCodecName(){} // RVA: 0x7FFD53E2FB00 | overloaded x2
        public void GetAudioInputDeviceCount(){} // RVA: 0x7FFD53E2E8A0
        public void GetAudioInputDeviceName(){} // RVA: 0x7FFD53E2FBD0 | overloaded x2
        public void GetAudioInputDeviceMediaApi(){} // RVA: 0x7FFD53E2EAF0
        public void GetContainerFileExtensions(){} // RVA: 0x7FFD53E2FCA0 | overloaded x2
        public void CreateRecorderVideo(){} // RVA: 0x7FFD53E2EE30
        public void CreateRecorderImages(){} // RVA: 0x7FFD53E2EF40
        public void CreateRecorderPipe(){} // RVA: 0x7FFD53E2F050
        public void Start(){} // RVA: 0x7FFD53E2F140
        public void IsNewFrameDue(){} // RVA: 0x7FFD53E2F1C0
        public void SetEncodedFrameLimit(){} // RVA: 0x7FFD53E2F240
        public void EncodeFrame(){} // RVA: 0x7FFD53E2F2D0
        public void EncodeAudio(){} // RVA: 0x7FFD53E2F360
        public void EncodeFrameWithAudio(){} // RVA: 0x7FFD53E2F400
        public void Pause(){} // RVA: 0x7FFD53E2F4A0
        public void Stop(){} // RVA: 0x7FFD53E2F520
        public void IsFileWritingComplete(){} // RVA: 0x7FFD53E2F5B0
        public void SetTexturePointer(){} // RVA: 0x7FFD53E2F630
        public void FreeRecorder(){} // RVA: 0x7FFD53E2F6C0
        public void GetNumDroppedFrames(){} // RVA: 0x7FFD53E2F740
        public void GetNumDroppedEncoderFrames(){} // RVA: 0x7FFD53E2F7C0
        public void GetNumEncodedFrames(){} // RVA: 0x7FFD53E2F840
        public void GetEncodedSeconds(){} // RVA: 0x7FFD53E2F8C0
        public void GetFileSize(){} // RVA: 0x7FFD53E2F940
        public void GetPluginVersion(){} // RVA: 0x7FFD53E2F9C0
        public void SetLogFunction(){} // RVA: 0x7FFD53E2FD80
        public void SetErrorHandler(){} // RVA: 0x7FFD53E2FE00
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void .cctor(){} // RVA: 0x7FFD53E2FE90
    }

    public class TimelineController : MonoBehaviour
    {
        public object ScanFrequency;

        // ── Methods ──
        public void get_ScanFrequency(){} // RVA: 0x7FFD4E4FBBE0
        public void set_ScanFrequency(){} // RVA: 0x7FFD53E29C80
        public void Awake(){} // RVA: 0x7FFD53E29C90
        public void OnValidate(){} // RVA: 0x7FFD53E29C90
        public void UpdateFrame(){} // RVA: 0x7FFD53E29CA0
        public void StartCapture(){} // RVA: 0x7FFD53E29CB0
        public void StopCapture(){} // RVA: 0x7FFD53E29E10
        public void ScanForPlayableDirectors(){} // RVA: 0x7FFD53E2A090
        public void OnDestroy(){} // RVA: 0x7FFD53E2A410
        public void ResetSceneLoading(){} // RVA: 0x7FFD53E2A4C0
        public void OnSceneLoaded(){} // RVA: 0x7FFD53E2A5B0
        public void .ctor(){} // RVA: 0x7FFD53E2A5C0
    }

    public class UnityAudioCapture : MonoBehaviour
    {
        public object OverflowCount;
        public object SampleRate;
        public object ChannelCount;

        // ── Methods ──
        public void get_OverflowCount(){} // RVA: 0x7FFD4E919180
        public void get_SampleRate(){} // RVA: 0x7FFD4E079960
        public void get_ChannelCount(){} // RVA: 0x7FFD4E079960
        public void PrepareCapture(){} // RVA: 0x7FFD4E090980
        public void StartCapture(){} // RVA: 0x7FFD4E090980
        public void StopCapture(){} // RVA: 0x7FFD4E090980
        public void FlushBuffer(){} // RVA: 0x7FFD4E090980
        public void ReadData(){} // RVA: 0x7FFD53E2AB60
        public void GetUnityAudioChannelCount(){} // RVA: 0x7FFD53E2AB70
        public void GetChannelCount(){} // RVA: 0x7FFD53E2ACB0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class Utils : Object
    {
        // ── Methods ──
        public void GetNativeImageSequenceFormatNames(){} // RVA: 0x7FFD53E44410
        public void HasAlphaChannel(){} // RVA: 0x7FFD53E44490
        public void GetBestRenderTextureFormat(){} // RVA: 0x7FFD53E44500
        public void GetUltimateRenderCamera(){} // RVA: 0x7FFD53E448D0
        public void HasContributingCameras(){} // RVA: 0x7FFD53E44BB0
        public void FindContributingCameras(){} // RVA: 0x7FFD53E44D10
        public void URLEscapePathByPercentEncoding(){} // RVA: 0x7FFD53E45510
        public void ShowInExplorer(){} // RVA: 0x7FFD53E45970
        public void OpenInDefaultApp(){} // RVA: 0x7FFD53E45AD0
        public void GetFileSize(){} // RVA: 0x7FFD53E45C50
        public void GetDiskFreeSpaceEx(){} // RVA: 0x7FFD53E45CD0
        public void DriveFreeBytes(){} // RVA: 0x7FFD53E45DA0
        public void GetImageFileExtension(){} // RVA: 0x7FFD53E45F40
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void .cctor(){} // RVA: 0x7FFD53E46010
    }

    public class VideoPlayerController : MonoBehaviour
    {
        public object ScanFrequency;

        // ── Methods ──
        public void get_ScanFrequency(){} // RVA: 0x7FFD4E4FBBE0
        public void set_ScanFrequency(){} // RVA: 0x7FFD53E2AD20
        public void Awake(){} // RVA: 0x7FFD53E2AD30
        public void Start(){} // RVA: 0x7FFD4E341310
        public void OnValidate(){} // RVA: 0x7FFD53E2AD30
        public void Update(){} // RVA: 0x7FFD4E341310
        public void UpdateFrame(){} // RVA: 0x7FFD53E2AD40
        public void CanContinue(){} // RVA: 0x7FFD53E2AF30
        public void WaitforSeekCompletes(){} // RVA: 0x7FFD53E2B0B0
        public void WaitforSeekCompletes2(){} // RVA: 0x7FFD4E341310
        public void StartCapture(){} // RVA: 0x7FFD53E2B150
        public void StopCapture(){} // RVA: 0x7FFD53E2B3C0
        public void ScanForVideoPlayers(){} // RVA: 0x7FFD53E2B600
        public void OnDestroy(){} // RVA: 0x7FFD53E2B9F0
        public void ResetSceneLoading(){} // RVA: 0x7FFD53E2BAA0
        public void OnSceneLoaded(){} // RVA: 0x7FFD53E2BB90
        public void .ctor(){} // RVA: 0x7FFD53E2BBA0
        public void <WaitforSeekCompletes>b__13_0(){} // RVA: 0x7FFD53E2BD10
    }

    public class WavWriter : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53E46860
        public void Dispose(){} // RVA: 0x7FFD53E469F0
        public void WriteInterleaved(){} // RVA: 0x7FFD53E46AC0
        public void WriteHeader(){} // RVA: 0x7FFD53E46E40
        public void PackageInt(){} // RVA: 0x7FFD53E47510
        public void .cctor(){} // RVA: 0x7FFD53E47620
    }

}