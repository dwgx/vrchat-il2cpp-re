// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.RenderHeads.Media.AVProMovieCapture
// Classes: 42
// Methods: 738

namespace ThirdParty.Other.RenderHeads.Media.AVProMovieCapture
{
    public class Ambisonic : Object
    {
        // ── Methods ──
        public void GetNormalisationWeights(){} // RVA: 0x7AE065110
        public void GetCoeffCount(){} // RVA: 0x7AE0651A0
        public void GetChannelOrder(){} // RVA: 0x7AE0651D0
        public void GetNormalisation(){} // RVA: 0x7AE0651D0
        public void .cctor(){} // RVA: 0x7AE0651E0
        public void BuildWeightsFuMa(){} // RVA: 0x7AE065490
        public void GetN(){} // RVA: 0x7AE065760
        public void GetM(){} // RVA: 0x7AE0657A0
        public void Factorial(){} // RVA: 0x7AE065820
        public void GetNormalisationSN3D(){} // RVA: 0x7AE065930
        public void GetNormalisationN3D(){} // RVA: 0x7AE065AB0
        public void BuildWeightsSN3D(){} // RVA: 0x7AE065B60
    }

    public class AmbisonicSource : MonoBehaviour
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7AE03FFC0
        public void OnDisable(){} // RVA: 0x7AE0403F0
        public void Setup(){} // RVA: 0x7AE040690
        public void OnDrawGizmos(){} // RVA: 0x7AE040990
        public void LateUpdate(){} // RVA: 0x7AE040CA0
        public void SetListenerRelativePosition(){} // RVA: 0x7AE040F40
        public void UpdateCoefficients(){} // RVA: 0x7AE040F60
        public void OnAudioFilterRead(){} // RVA: 0x7AE0412E0
        public void FlushBuffers(){} // RVA: 0x7AE041960
        public void GetFullBufferCount(){} // RVA: 0x7AE041D00
        public void SendSamplesToSink(){} // RVA: 0x7AE041D50
        public void .ctor(){} // RVA: 0x7AE041FD0
    }

    public class AmbisonicSource[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class AmbisonicWavWriter : MonoBehaviour
    {
        // ── Methods ──
        public void get_Order(){} // RVA: 0x7A854FDE0
        public void get_Format(){} // RVA: 0x7A8F9ACE0
        public void AddSource(){} // RVA: 0x7AE042190
        public void RemoveSource(){} // RVA: 0x7AE042330
        public void OnDisable(){} // RVA: 0x7AE042480
        public void SetupSource(){} // RVA: 0x7AE042490
        public void ToggleCapturing(){} // RVA: 0x7AE042540
        public void StartCapture(){} // RVA: 0x7AE042570
        public void StopCapture(){} // RVA: 0x7AE042C60
        public void IsCapturing(){} // RVA: 0x7AE042E60
        public void LateUpdate(){} // RVA: 0x7AE042E80
        public void ProcessSources(){} // RVA: 0x7AE042FA0
        public void MixSamples(){} // RVA: 0x7AE043270
        public void FlushWavWriter(){} // RVA: 0x7AE043390
        public void .ctor(){} // RVA: 0x7AE0433D0
    }

    public class AudioSourceToWav : MonoBehaviour
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7AE0435D0
        public void OnDisable(){} // RVA: 0x7AE0437F0
        public void OnAudioFilterRead(){} // RVA: 0x7AE043870
        public void .ctor(){} // RVA: 0x7AE0438A0
    }

    public class CameraSelector : MonoBehaviour
    {
        // ── Methods ──
        public void get_Camera(){} // RVA: 0x7A8154D80
        public void set_Camera(){} // RVA: 0x7AE043970
        public void get_SelectBy(){} // RVA: 0x7A851DB90
        public void set_SelectBy(){} // RVA: 0x7AE0439E0
        public void get_ScanFrequency(){} // RVA: 0x7A8AB15F0
        public void set_ScanFrequency(){} // RVA: 0x7AE0439F0
        public void get_ScanHiddenCameras(){} // RVA: 0x7A84A5BD0
        public void set_ScanHiddenCameras(){} // RVA: 0x7AE043A00
        public void get_SelectTag(){} // RVA: 0x7A83F69F0
        public void set_SelectTag(){} // RVA: 0x7AE043A10
        public void get_SelectName(){} // RVA: 0x7A8292C30
        public void set_SelectName(){} // RVA: 0x7AE043A70
        public void Awake(){} // RVA: 0x7AE043AD0
        public void Start(){} // RVA: 0x7AE043AE0
        public void OnValidate(){} // RVA: 0x7AE043AD0
        public void Update(){} // RVA: 0x7AE043AF0
        public void OnDestroy(){} // RVA: 0x7AE043B10
        public void ResetSceneLoading(){} // RVA: 0x7AE043BB0
        public void OnSceneLoaded(){} // RVA: 0x7AE043CA0
        public void ScanForCameraChange(){} // RVA: 0x7AE043CB0
        public void FindCamera(){} // RVA: 0x7AE043EE0
        public void UpdateCameraCache(){} // RVA: 0x7AE044250
        public void FindCameraByHighestDepth(){} // RVA: 0x7AE0443F0
        public void FindCameraByTag(){} // RVA: 0x7AE044570
        public void FindCameraByName(){} // RVA: 0x7AE044610
        public void .ctor(){} // RVA: 0x7AE0446F0
    }

    public class CaptureAudioFromAudioClip : MonoBehaviour
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7AE0448C0
        public void Update(){} // RVA: 0x7AE044C70
        public void GetAudioSamplesForFrame(){} // RVA: 0x7AE044D80
        public void .ctor(){} // RVA: 0x7A864EE20
    }

    public class CaptureAudioFromAudioListener : UnityAudioCapture
    {
        // ── Methods ──
        public void get_Buffer(){} // RVA: 0x7A83F69F0
        public void get_BufferLength(){} // RVA: 0x7A8D863F0
        public void get_BufferPtr(){} // RVA: 0x7AE0450D0
        public void get_OverflowCount(){} // RVA: 0x7A9231EA0
        public void get_SampleRate(){} // RVA: 0x7AE0450E0
        public void get_ChannelCount(){} // RVA: 0x7A8178B70
        public void PrepareCapture(){} // RVA: 0x7AE045130
        public void StartCapture(){} // RVA: 0x7AB5DC320
        public void StopCapture(){} // RVA: 0x7AE0456B0
        public void ReadData(){} // RVA: 0x7AE0458E0
        public void FlushBuffer(){} // RVA: 0x7AE045A30
        public void OnAudioFilterRead(){} // RVA: 0x7AE045B30
        public void .ctor(){} // RVA: 0x7AE045E50
    }

    public class CaptureAudioFromAudioRenderer : UnityAudioCapture
    {
        // ── Methods ──
        public void get_Capture(){} // RVA: 0x7A81052C0
        public void set_Capture(){} // RVA: 0x7A81052D0
        public void get_SampleRate(){} // RVA: 0x7AE0450E0
        public void get_ChannelCount(){} // RVA: 0x7A854FDE0
        public void PrepareCapture(){} // RVA: 0x7AE046000
        public void GetAudioBufferOfLength(){} // RVA: 0x7AE046020
        public void DisposeAudioBuffer(){} // RVA: 0x7A80D7310
        public void StartCapture(){} // RVA: 0x7AE046240
        public void StopCapture(){} // RVA: 0x7AE0464B0
        public void FlushBuffer(){} // RVA: 0x7AE046540
        public void Update(){} // RVA: 0x7AE046630
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

    public class CaptureAudioFromWwise : UnityAudioCapture
    {
        // ── Methods ──
        public void get_Capture(){} // RVA: 0x7A81052C0
        public void set_Capture(){} // RVA: 0x7A81052D0
        public void Awake(){} // RVA: 0x7AE0467F0
        public void get_SampleRate(){} // RVA: 0x7A82D1450
        public void get_ChannelCount(){} // RVA: 0x7A82D1450
        public void PrepareCapture(){} // RVA: 0x7A80D7310
        public void FlushBuffer(){} // RVA: 0x7A80D7310
        public void StartCapture(){} // RVA: 0x7A80D7310
        public void StopCapture(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

    public class CaptureBase : MonoBehaviour
    {
        // ── Methods ──
        public void get_OutputTarget(){} // RVA: 0x7A9AAC1C0
        public void set_OutputTarget(){} // RVA: 0x7AE0660E0
        public void get_OutputFolder(){} // RVA: 0x7AB52C0D0
        public void set_OutputFolder(){} // RVA: 0x7AE0660F0
        public void get_OutputFolderPath(){} // RVA: 0x7A8592710
        public void set_OutputFolderPath(){} // RVA: 0x7A84442D0
        public void get_FilenamePrefix(){} // RVA: 0x7A8852A30
        public void set_FilenamePrefix(){} // RVA: 0x7A8AB8FD0
        public void get_AppendFilenameTimestamp(){} // RVA: 0x7A94BD7C0
        public void set_AppendFilenameTimestamp(){} // RVA: 0x7A94BD7D0
        public void get_AllowManualFileExtension(){} // RVA: 0x7A9905F50
        public void set_AllowManualFileExtension(){} // RVA: 0x7A9906160
        public void get_FilenameExtension(){} // RVA: 0x7A884F050
        public void set_FilenameExtension(){} // RVA: 0x7A8B5D8D0
        public void get_NamedPipePath(){} // RVA: 0x7A864CFF0
        public void set_NamedPipePath(){} // RVA: 0x7A864C880
        public void get_ImageSequenceStartFrame(){} // RVA: 0x7A8ADBD10
        public void set_ImageSequenceStartFrame(){} // RVA: 0x7AE066100
        public void get_ImageSequenceZeroDigits(){} // RVA: 0x7ADF29B00
        public void set_ImageSequenceZeroDigits(){} // RVA: 0x7AE066110
        public void get_UseMotionBlur(){} // RVA: 0x7A9437E00
        public void set_UseMotionBlur(){} // RVA: 0x7A9440AF0
        public void get_MotionBlurSamples(){} // RVA: 0x7AE066140
        public void set_MotionBlurSamples(){} // RVA: 0x7AE066150
        public void get_MotionBlurCameras(){} // RVA: 0x7A87BB380
        public void set_MotionBlurCameras(){} // RVA: 0x7A8B52120
        public void get_MotionBlur(){} // RVA: 0x7A8B4D7B0
        public void set_MotionBlur(){} // RVA: 0x7A8B59B40
        public void get_ActiveFilePaths(){} // RVA: 0x7AE066180
        public void get_LastFilePath(){} // RVA: 0x7A8855020
        public void get_BeginFinalFileWritingAction(){} // RVA: 0x7A8B62DA0
        public void set_BeginFinalFileWritingAction(){} // RVA: 0x7A8B63900
        public void get_CompletedFileWritingAction(){} // RVA: 0x7A8B5B150
        public void set_CompletedFileWritingAction(){} // RVA: 0x7A8B48310
        public void get_Stats(){} // RVA: 0x7A8B4BD50
        public void get_CameraRenderResolution(){} // RVA: 0x7A8F9BFE0
        public void set_CameraRenderResolution(){} // RVA: 0x7ADF1BE10
        public void get_CameraRenderCustomResolution(){} // RVA: 0x7AE0661E0
        public void set_CameraRenderCustomResolution(){} // RVA: 0x7AE066200
        public void get_CameraRenderAntiAliasing(){} // RVA: 0x7A93B7E20
        public void set_CameraRenderAntiAliasing(){} // RVA: 0x7A93B7BF0
        public void get_IsRealTime(){} // RVA: 0x7A98B2AB0
        public void set_IsRealTime(){} // RVA: 0x7A98B2AA0
        public void get_PersistAcrossSceneLoads(){} // RVA: 0x7A9A933F0
        public void set_PersistAcrossSceneLoads(){} // RVA: 0x7A9A93400
        public void get_AudioCaptureSource(){} // RVA: 0x7A880E690
        public void set_AudioCaptureSource(){} // RVA: 0x7A98A1E20
        public void get_ManualAudioSampleRate(){} // RVA: 0x7A9AAEF60
        public void set_ManualAudioSampleRate(){} // RVA: 0x7ABBEC9C0
        public void get_ManualAudioChannelCount(){} // RVA: 0x7A9AAEF70
        public void set_ManualAudioChannelCount(){} // RVA: 0x7AE066210
        public void get_UnityAudioCapture(){} // RVA: 0x7A8854870
        public void set_UnityAudioCapture(){} // RVA: 0x7A8158EF0
        public void get_ForceAudioInputDeviceIndex(){} // RVA: 0x7A9B14850
        public void set_ForceAudioInputDeviceIndex(){} // RVA: 0x7AE066220
        public void get_FrameRate(){} // RVA: 0x7A813FAE0
        public void set_FrameRate(){} // RVA: 0x7AE066230
        public void get_StartTrigger(){} // RVA: 0x7A8178B70
        public void set_StartTrigger(){} // RVA: 0x7A8178B80
        public void get_StartDelay(){} // RVA: 0x7A9231EA0
        public void set_StartDelay(){} // RVA: 0x7A9B79240
        public void get_StartDelaySeconds(){} // RVA: 0x7A813FA00
        public void set_StartDelaySeconds(){} // RVA: 0x7AE066260
        public void get_StopMode(){} // RVA: 0x7A8A22410
        public void set_StopMode(){} // RVA: 0x7A8A25530
        public void get_StopAfterFramesElapsed(){} // RVA: 0x7A87A7DA0
        public void set_StopAfterFramesElapsed(){} // RVA: 0x7AE066270
        public void get_StopAfterSecondsElapsed(){} // RVA: 0x7A8100240
        public void set_StopAfterSecondsElapsed(){} // RVA: 0x7AE066280
        public void get_CaptureStats(){} // RVA: 0x7A8B4BD50
        public void get_VideoCodecPriorityWindows(){} // RVA: 0x7A8175DF0
        public void set_VideoCodecPriorityWindows(){} // RVA: 0x7AE066290
        public void get_VideoCodecPriorityMacOS(){} // RVA: 0x7A8153390
        public void set_VideoCodecPriorityMacOS(){} // RVA: 0x7AE0662F0
        public void get_AudioCodecPriorityWindows(){} // RVA: 0x7A82C2060
        public void set_AudioCodecPriorityWindows(){} // RVA: 0x7AE066350
        public void get_AudioCodecPriorityMacOS(){} // RVA: 0x7A825E100
        public void set_AudioCodecPriorityMacOS(){} // RVA: 0x7AE0663B0
        public void get_TimelapseScale(){} // RVA: 0x7A846C750
        public void set_TimelapseScale(){} // RVA: 0x7A869B9F0
        public void get_FrameUpdate(){} // RVA: 0x7A9B79A20
        public void set_FrameUpdate(){} // RVA: 0x7A9B794B0
        public void get_ResolutionDownScale(){} // RVA: 0x7A9B79A10
        public void set_ResolutionDownScale(){} // RVA: 0x7A9B79A30
        public void get_ResolutionDownscaleCustom(){} // RVA: 0x7AE066410
        public void set_ResolutionDownscaleCustom(){} // RVA: 0x7ADDE2D30
        public void get_FlipVertically(){} // RVA: 0x7A9021760
        public void set_FlipVertically(){} // RVA: 0x7A90226D0
        public void get_UseWaitForEndOfFrame(){} // RVA: 0x7AE066430
        public void set_UseWaitForEndOfFrame(){} // RVA: 0x7AE066440
        public void get_LogCaptureStartStop(){} // RVA: 0x7A9A79970
        public void set_LogCaptureStartStop(){} // RVA: 0x7AE066450
        public void get_AllowOfflineVSyncDisable(){} // RVA: 0x7AE066460
        public void set_AllowOfflineVSyncDisable(){} // RVA: 0x7AE066470
        public void get_SupportTextureRecreate(){} // RVA: 0x7AE066480
        public void set_SupportTextureRecreate(){} // RVA: 0x7AE066490
        public void get_TimelineController(){} // RVA: 0x7A8B57910
        public void set_TimelineController(){} // RVA: 0x7A8B578B0
        public void get_VideoPlayerController(){} // RVA: 0x7A85ECF50
        public void set_VideoPlayerController(){} // RVA: 0x7A8B51A20
        public void get_SelectedVideoCodec(){} // RVA: 0x7A8B772D0
        public void get_SelectedAudioCodec(){} // RVA: 0x7A8815B70
        public void get_SelectedAudioInputDevice(){} // RVA: 0x7A8B6AFA0
        public void get_NativeForceVideoCodecIndex(){} // RVA: 0x7A8A69800
        public void set_NativeForceVideoCodecIndex(){} // RVA: 0x7A8A67200
        public void get_NativeForceAudioCodecIndex(){} // RVA: 0x7A9651770
        public void set_NativeForceAudioCodecIndex(){} // RVA: 0x7A9651780
        public void get_NativeImageSequenceFormat(){} // RVA: 0x7AE0664A0
        public void set_NativeImageSequenceFormat(){} // RVA: 0x7AE0664B0
        public void GetCurrentPlatform(){} // RVA: 0x7A82D1450
        public void GetEncoderHints(){} // RVA: 0x7AE0664C0
        public void SetEncoderHints(){} // RVA: 0x7AE066570
        public void UpdateMediaGallery(){} // RVA: 0x7A80D7310
        public void Awake(){} // RVA: 0x7AE066790
        public void .cctor(){} // RVA: 0x7AE066DC0
        public void Start(){} // RVA: 0x7AE0678E0
        public void SelectCodec(){} // RVA: 0x7AE067A10
        public void SelectVideoCodec(){} // RVA: 0x7AE067DF0
        public void SelectAudioCodec(){} // RVA: 0x7AE067FD0
        public void SelectAudioInputDevice(){} // RVA: 0x7AE068140
        public void GetRecordingResolution(){} // RVA: 0x7AE0683A0
        public void SelectRecordingResolution(){} // RVA: 0x7AE068470
        public void OnDestroy(){} // RVA: 0x7AE068580
        public void FreePendingFileWrites(){} // RVA: 0x7AE0688F0
        public void OnApplicationQuit(){} // RVA: 0x7AE068A90
        public void OnApplicationPause(){} // RVA: 0x7A80D7310
        public void EncodeTexture(){} // RVA: 0x7AE068AF0
        public void IsUsingUnityAudioComponent(){} // RVA: 0x7AE068C10
        public void IsUsingMotionBlur(){} // RVA: 0x7AE068D10
        public void EncodePointer(){} // RVA: 0x7AE068E00
        public void IsPrepared(){} // RVA: 0x7AE068F90
        public void IsCapturing(){} // RVA: 0x7AE068FA0
        public void IsPaused(){} // RVA: 0x7AE068FB0
        public void GetRecordingWidth(){} // RVA: 0x7AE068FC0
        public void GetRecordingHeight(){} // RVA: 0x7AE068FD0
        public void GenerateTimestampedFilename(){} // RVA: 0x7AE068FE0
        public void GetFolder(){} // RVA: 0x7AE0692C0
        public void GenerateFilePath(){} // RVA: 0x7AE0694A0
        public void HasExtension(){} // RVA: 0x7AE069540
        public void GenerateFilename(){} // RVA: 0x7AE069690
        public void FindOrCreateUnityAudioCapture(){} // RVA: 0x7AE069E80
        public void ValidateEditionFeatures(){} // RVA: 0x7AE06A510
        public void PrepareCapture(){} // RVA: 0x7AE06AC40
        public void QueueStartCapture(){} // RVA: 0x7AE06C980
        public void IsStartCaptureQueued(){} // RVA: 0x7AE06CA20
        public void UpdateInjectionOptions(){} // RVA: 0x7AE06CA30
        public void StartCapture(){} // RVA: 0x7AE06CAC0
        public void PauseCapture(){} // RVA: 0x7AE06CF70
        public void ResumeCapture(){} // RVA: 0x7AE06D0B0
        public void CancelCapture(){} // RVA: 0x7AE06D1C0
        public void DeleteCapture(){} // RVA: 0x7AE06D1F0
        public void UnprepareCapture(){} // RVA: 0x7A80D7310
        public void get_LastFileSaved(){} // RVA: 0x7AE06D300
        public void set_LastFileSaved(){} // RVA: 0x7AE06D3B0
        public void RenderThreadEvent(){} // RVA: 0x7AE06D400
        public void StopCapture(){} // RVA: 0x7AE06D470
        public void CreatePostOperationsOptions(){} // RVA: 0x7AE06E1A0
        public void CanApplyPostOperations(){} // RVA: 0x7AE06E270
        public void ApplyPostOperations(){} // RVA: 0x7AE06E460
        public void ToggleCapture(){} // RVA: 0x7AE06E690
        public void IsEnoughDiskSpace(){} // RVA: 0x7AE06E6D0
        public void CanContinue(){} // RVA: 0x7AE06E710
        public void Update(){} // RVA: 0x7AE06E830
        public void LateUpdate(){} // RVA: 0x7AE06E8A0
        public void RemoveCompletedFileWrites(){} // RVA: 0x7AE06EBE0
        public void CheckFreeDiskSpace(){} // RVA: 0x7AE06ECD0
        public void IsStartDelayComplete(){} // RVA: 0x7AE06ED90
        public void IsStopTimeReached(){} // RVA: 0x7AE06EDC0
        public void GetProgress(){} // RVA: 0x7AE06EEA0
        public void GetSecondsPerCaptureFrame(){} // RVA: 0x7AE06EF60
        public void CanOutputFrame(){} // RVA: 0x7AE06EF90
        public void TickFrameTimer(){} // RVA: 0x7AE06F1C0
        public void RenormTimer(){} // RVA: 0x7AE06F230
        public void GetPreviewTexture(){} // RVA: 0x7A82D1450
        public void EncodeUnityAudio(){} // RVA: 0x7AE06F280
        public void EncodeAudio(){} // RVA: 0x7AE06F3D0
        public void PreUpdateFrame(){} // RVA: 0x7AE06F620
        public void UpdateFrame(){} // RVA: 0x7AE06F800
        public void ResetFPS(){} // RVA: 0x7AE06FB30
        public void UpdateFPS(){} // RVA: 0x7AE06FB60
        public void GetCameraAntiAliasingLevel(){} // RVA: 0x7AE06FBF0
        public void GetCaptureFileSize(){} // RVA: 0x7AE06FE60
        public void GetResolution(){} // RVA: 0x7AE06FF70
        public void NextMultipleOf4(){} // RVA: 0x7A91BE500
        public void HasUserAuthorisationToCaptureAudio(){} // RVA: 0x7AE0700F0
        public void RequestUserAuthorisationToCaptureAudioCallback(){} // RVA: 0x7AE0701D0
        public void RequestAudioCaptureDeviceUserAuthorisation(){} // RVA: 0x7A82D1450
        public void HasUserAuthorisationToAccessPhotos(){} // RVA: 0x7AE070250
        public void RequestUserAuthorisationToAccessPhotosCallback(){} // RVA: 0x7AE070330
        public void RequestUserAuthorisationToAccessPhotos(){} // RVA: 0x7A82D1450
        public void .ctor(){} // RVA: 0x7AE0703B0
    }

    public class CaptureFromCamera : CaptureBase
    {
        // ── Methods ──
        public void get_CameraSelector(){} // RVA: 0x7A8B54F00
        public void set_CameraSelector(){} // RVA: 0x7A8B56C80
        public void get_UseContributingCameras(){} // RVA: 0x7AE046850
        public void set_UseContributingCameras(){} // RVA: 0x7AE046860
        public void SetCamera(){} // RVA: 0x7AE046BD0
        public void RequiresResolve(){} // RVA: 0x7AE046C90
        public void HasCamera(){} // RVA: 0x7AE046DC0
        public void HasContributingCameras(){} // RVA: 0x7AE046E90
        public void UpdateFrame(){} // RVA: 0x7AE046EC0
        public void FinalRenderCapture(){} // RVA: 0x7AE0471B0
        public void Capture(){} // RVA: 0x7AE047250
        public void RequiresHDR(){} // RVA: 0x7AE0472F0
        public void UpdateTexture(){} // RVA: 0x7AE0474E0
        public void UnprepareCapture(){} // RVA: 0x7AE047E60
        public void CreateResolveTexture(){} // RVA: 0x7AE048090
        public void GetPreviewTexture(){} // RVA: 0x7A8B5B230
        public void PrepareCapture(){} // RVA: 0x7AE048550
        public void OnDestroy(){} // RVA: 0x7AE0490E0
        public void .ctor(){} // RVA: 0x7AE0493D0
        public void <>n__0(){} // RVA: 0x7AE049430
    }

    public class CaptureFromCamera360 : CaptureBase
    {
        // ── Methods ──
        public void get_CameraSelector(){} // RVA: 0x7A8B54F00
        public void set_CameraSelector(){} // RVA: 0x7A8B56C80
        public void get_CubemapFaceResolution(){} // RVA: 0x7A97FA380
        public void set_CubemapFaceResolution(){} // RVA: 0x7A97F99C0
        public void get_CubemapDepthResolution(){} // RVA: 0x7A97FA150
        public void set_CubemapDepthResolution(){} // RVA: 0x7A97FAE80
        public void get_SupportGUI(){} // RVA: 0x7AE049B40
        public void set_SupportGUI(){} // RVA: 0x7AE049B50
        public void get_SupportCameraRotation(){} // RVA: 0x7AE049B60
        public void set_SupportCameraRotation(){} // RVA: 0x7AE049B70
        public void get_OnlyLeftRightRotation(){} // RVA: 0x7AE049B80
        public void set_OnlyLeftRightRotation(){} // RVA: 0x7AE049B90
        public void get_Render180Degrees(){} // RVA: 0x7AE049BA0
        public void set_Render180Degrees(){} // RVA: 0x7AE049BB0
        public void get_StereoRendering(){} // RVA: 0x7A97F9610
        public void set_StereoRendering(){} // RVA: 0x7AE049BC0
        public void get_IPD(){} // RVA: 0x7AE049BD0
        public void set_IPD(){} // RVA: 0x7AE049BE0
        public void .ctor(){} // RVA: 0x7AE049BF0
        public void GetCubemapRenderingMethod(){} // RVA: 0x7AE049C80
        public void SetCamera(){} // RVA: 0x7A8B605E0
        public void UpdateFrame(){} // RVA: 0x7AE049CA0
        public void FinalRenderCapture(){} // RVA: 0x7AE049F60
        public void Capture(){} // RVA: 0x7AE04A000
        public void ClearCubemap(){} // RVA: 0x7AE04A4A0
        public void RenderCubemapToEquiRect(){} // RVA: 0x7AE04A950
        public void UpdateTexture(){} // RVA: 0x7AE04AAF0
        public void RenderCameraToCubemap(){} // RVA: 0x7AE04B320
        public void AccumulateMotionBlur(){} // RVA: 0x7AE04CDB0
        public void PrepareCapture(){} // RVA: 0x7AE04CF70
        public void GetPreviewTexture(){} // RVA: 0x7AE04E150
        public void Start(){} // RVA: 0x7AE04E190
        public void OnDestroy(){} // RVA: 0x7AE04E550
    }

    public class CaptureFromCamera360ODS : CaptureBase
    {
        // ── Methods ──
        public void get_Setup(){} // RVA: 0x7A8B54F00
        public void .ctor(){} // RVA: 0x7AE04EB30
        public void SetCamera(){} // RVA: 0x7AE04EC50
        public void Start(){} // RVA: 0x7AE04ECC0
        public void CreateEye(){} // RVA: 0x7AE04EEF0
        public void UpdateFrame(){} // RVA: 0x7AE050000
        public void FinalRenderCapture(){} // RVA: 0x7AE0502F0
        public void Capture(){} // RVA: 0x7AE050390
        public void AccumulateMotionBlur(){} // RVA: 0x7AE0507A0
        public void RenderFrame(){} // RVA: 0x7AE050970
        public void GetPreviewTexture(){} // RVA: 0x7AE0515C0
        public void PrepareCapture(){} // RVA: 0x7AE051600
        public void DestroyEye(){} // RVA: 0x7AE052770
        public void OnDestroy(){} // RVA: 0x7AE0529A0
    }

    public class CaptureFromScreen : CaptureBase
    {
        // ── Methods ──
        public void get_CaptureMouseCursor(){} // RVA: 0x7AE053100
        public void set_CaptureMouseCursor(){} // RVA: 0x7AE053110
        public void get_MouseCursor(){} // RVA: 0x7A8B53E80
        public void set_MouseCursor(){} // RVA: 0x7A8B634D0
        public void PrepareCapture(){} // RVA: 0x7AE053120
        public void CopyRenderTargetToTexture(){} // RVA: 0x7AE053480
        public void FreeRenderResources(){} // RVA: 0x7AE053A90
        public void UnprepareCapture(){} // RVA: 0x7AE053CB0
        public void FinalRenderCapture(){} // RVA: 0x7AE053E20
        public void UpdateFrame(){} // RVA: 0x7AE053EC0
        public void .ctor(){} // RVA: 0x7AE053F80
    }

    public class CaptureFromTexture : CaptureBase
    {
        // ── Methods ──
        public void get_IsManualUpdate(){} // RVA: 0x7AE053100
        public void set_IsManualUpdate(){} // RVA: 0x7AE053110
        public void SetSourceTexture(){} // RVA: 0x7A8B634D0
        public void RequiresResolve(){} // RVA: 0x7AE0541B0
        public void UpdateSourceTexture(){} // RVA: 0x7AE0542E0
        public void ShouldCaptureFrame(){} // RVA: 0x7AE0542F0
        public void HasSourceTextureChanged(){} // RVA: 0x7AE0543E0
        public void UpdateFrame(){} // RVA: 0x7AE054400
        public void FinalRenderCapture(){} // RVA: 0x7AE0544D0
        public void Capture(){} // RVA: 0x7AE054570
        public void CreateResolveTexture(){} // RVA: 0x7AE054980
        public void AccumulateMotionBlur(){} // RVA: 0x7AE054D40
        public void GetPreviewTexture(){} // RVA: 0x7AE054E60
        public void PrepareCapture(){} // RVA: 0x7AE054FD0
        public void UnprepareCapture(){} // RVA: 0x7AE0553C0
        public void .ctor(){} // RVA: 0x7AE055590
    }

    public class CaptureFromWebCamTexture : CaptureFromTexture
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7AE0556E0
        public void .ctor(){} // RVA: 0x7AE055590
    }

    public class CaptureGUI : MonoBehaviour
    {
        // ── Methods ──
        public void get_MovieCapture(){} // RVA: 0x7A81052C0
        public void set_MovieCapture(){} // RVA: 0x7A81052D0
        public void get_HideUiWhenRecording(){} // RVA: 0x7A89FCA90
        public void set_HideUiWhenRecording(){} // RVA: 0x7A96C67C0
        public void get_ShowUI(){} // RVA: 0x7A84A5BD0
        public void set_ShowUI(){} // RVA: 0x7A84A5CD0
        public void Start(){} // RVA: 0x7AE055740
        public void CreateGUI(){} // RVA: 0x7AE055820
        public void OnGUI(){} // RVA: 0x7AE056470
        public void MyWindow(){} // RVA: 0x7AE056F50
        public void GUI_RecordingStatus(){} // RVA: 0x7AE0597C0
        public void DrawPauseResumeButtons(){} // RVA: 0x7AE05B250
        public void DrawGuiField(){} // RVA: 0x7AE05BA70
        public void StartCapture(){} // RVA: 0x7AE05BB40
        public void StopCapture(){} // RVA: 0x7AE05BC40
        public void CancelCapture(){} // RVA: 0x7AE05BD40
        public void ResumeCapture(){} // RVA: 0x7AE05BE40
        public void PauseCapture(){} // RVA: 0x7AE05BF20
        public void Update(){} // RVA: 0x7AE05C000
        public void .ctor(){} // RVA: 0x7AE05C2C0
        public void .cctor(){} // RVA: 0x7AE05C880
    }

    public class CaptureStats : Object
    {
        // ── Methods ──
        public void get_FPS(){} // RVA: 0x7A82606B0
        public void get_FramesTotal(){} // RVA: 0x7AE065DF0
        public void get_NumDroppedFrames(){} // RVA: 0x7A8124910
        public void set_NumDroppedFrames(){} // RVA: 0x7A80DA0C0
        public void get_NumDroppedEncoderFrames(){} // RVA: 0x7A8668BC0
        public void set_NumDroppedEncoderFrames(){} // RVA: 0x7A8669360
        public void get_NumEncodedFrames(){} // RVA: 0x7A83782A0
        public void set_NumEncodedFrames(){} // RVA: 0x7A84385B0
        public void get_TotalEncodedSeconds(){} // RVA: 0x7A9739200
        public void set_TotalEncodedSeconds(){} // RVA: 0x7A9746990
        public void get_AudioCaptureSource(){} // RVA: 0x7A851DB90
        public void set_AudioCaptureSource(){} // RVA: 0x7A8738180
        public void get_UnityAudioSampleRate(){} // RVA: 0x7A8AB15F0
        public void set_UnityAudioSampleRate(){} // RVA: 0x7A94794D0
        public void get_UnityAudioChannelCount(){} // RVA: 0x7A854FDE0
        public void set_UnityAudioChannelCount(){} // RVA: 0x7A8810F60
        public void ResetFPS(){} // RVA: 0x7AE065E00
        public void UpdateFPS(){} // RVA: 0x7AE065E10
        public void .ctor(){} // RVA: 0x7AE065E90
    }

    public class Codec : Object
    {
        // ── Methods ──
        public void get_CodecType(){} // RVA: 0x7A8124910
        public void get_Index(){} // RVA: 0x7A8668BC0
        public void get_Name(){} // RVA: 0x7A80DA7B0
        public void get_MediaApi(){} // RVA: 0x7A8AB15F0
        public void get_HasConfigwindow(){} // RVA: 0x7A81C68D0
        public void ShowConfigWindow(){} // RVA: 0x7AE070DD0
        public void .ctor(){} // RVA: 0x7AE070F30
    }

    public class CodecList : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE070FB0
        public void FindCodec(){} // RVA: 0x7AE0710B0
        public void GetFirstWithMediaApi(){} // RVA: 0x7AE071180
        public void GetEnumerator(){} // RVA: 0x7A9AAAAE0
        public void get_Codecs(){} // RVA: 0x7A80F2570
        public void get_Count(){} // RVA: 0x7A8D0A110
    }

    public class CodecManager : Object
    {
        // ── Methods ──
        public void FindCodec(){} // RVA: 0x7AE0711E0
        public void GetCodecCount(){} // RVA: 0x7AE071300
        public void CheckInit(){} // RVA: 0x7AE071370
        public void GetCodecs(){} // RVA: 0x7AE071420
        public void EnumerateCodecs(){} // RVA: 0x7AE0714C0
        public void get_VideoCodecs(){} // RVA: 0x7AE071F00
        public void get_AudioCodecs(){} // RVA: 0x7AE071F60
        public void .cctor(){} // RVA: 0x7AE071FC0
    }

    public class Codec[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class Device : Object
    {
        // ── Methods ──
        public void get_DeviceType(){} // RVA: 0x7A8124910
        public void get_Index(){} // RVA: 0x7A8668BC0
        public void get_Name(){} // RVA: 0x7A80DA7B0
        public void get_MediaApi(){} // RVA: 0x7A851DB90
        public void .ctor(){} // RVA: 0x7AE072180
    }

    public class DeviceList : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE0721F0
        public void FindDevice(){} // RVA: 0x7AE0722F0
        public void GetFirstWithMediaApi(){} // RVA: 0x7AE0723C0
        public void GetEnumerator(){} // RVA: 0x7A9AAAAE0
        public void get_Devices(){} // RVA: 0x7A80F2570
        public void get_Count(){} // RVA: 0x7A8D0A110
    }

    public class DeviceManager : Object
    {
        // ── Methods ──
        public void FindDevice(){} // RVA: 0x7AE072420
        public void GetDeviceCount(){} // RVA: 0x7AE072590
        public void CheckInit(){} // RVA: 0x7AE072640
        public void GetDevices(){} // RVA: 0x7AE0726F0
        public void EnumerateDevices(){} // RVA: 0x7AE072760
        public void get_AudioInputDevices(){} // RVA: 0x7AE072AE0
        public void .cctor(){} // RVA: 0x7AE072B40
    }

    public class Device[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class EncoderHints : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE065F70
        public void SetDefaults(){} // RVA: 0x7AE065F70
    }

    public class FileWritingHandler : Object
    {
        // ── Methods ──
        public void get_Status(){} // RVA: 0x7A8355950
        public void get_Path(){} // RVA: 0x7A80F2570
        public void get_CompletedFileWritingAction(){} // RVA: 0x7A8153390
        public void set_CompletedFileWritingAction(){} // RVA: 0x7A81533A0
        public void .ctor(){} // RVA: 0x7AE072C40
        public void SetFilePostProcess(){} // RVA: 0x7AE072D20
        public void StartPostProcess(){} // RVA: 0x7AE072D80
        public void IsFileReady(){} // RVA: 0x7AE072EC0
        public void Dispose(){} // RVA: 0x7AE0730C0
        public void Cleanup(){} // RVA: 0x7AE073370
    }

    public class FileWritingHandler[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class IMediaApiItem
    {
        // ── Methods ──
        public void get_Index(){} // RVA: 0x7A7E00710
        public void get_Name(){} // RVA: 0x7A7E00680
        public void get_MediaApi(){} // RVA: 0x7A7E00710
    }

    public class ImageEncoderHints : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE065F20
        public void SetDefaults(){} // RVA: 0x7AE065F20
        public void Validate(){} // RVA: 0x7AE065F40
    }

    public class MP4FileProcessing : Object
    {
        // ── Methods ──
        public void ProcessFileAsync(){} // RVA: 0x7AE073460
        public void ProcessFile(){} // RVA: 0x7AE073AA0
        public void .ctor(){} // RVA: 0x7AE073EA0
        public void Process(){} // RVA: 0x7AE074050
        public void Close(){} // RVA: 0x7AE074B20
        public void GetFirstChunkOfType(){} // RVA: 0x7AE074D20
        public void ReadChildChunks(){} // RVA: 0x7AE074F80
        public void ReadChunkHeader(){} // RVA: 0x7AE075180
        public void ChunkContainsChildChunkWithId(){} // RVA: 0x7AE075360
        public void ChunkDesc(){} // RVA: 0x7AE0754D0
        public void WriteChunk(){} // RVA: 0x7AE075810
        public void CopyChunkHeader(){} // RVA: 0x7AE075890
        public void InjectChunkHeader(){} // RVA: 0x7AE075910
        public void CopyBytes(){} // RVA: 0x7AE075990
        public void WriteZeros(){} // RVA: 0x7AE075AA0
        public void WriteChunkRecursive_moov(){} // RVA: 0x7AE075B50
        public void IsVideoTrack(){} // RVA: 0x7AE076250
        public void WriteChunk_stco(){} // RVA: 0x7AE0763A0
        public void WriteChunk_co64_from_stco(){} // RVA: 0x7AE076490
        public void WriteChunk_co64(){} // RVA: 0x7AE0765C0
        public void InjectChunkStub_co64_from_stco(){} // RVA: 0x7AE0766B0
        public void WriteChunk_stsd(){} // RVA: 0x7AE076810
        public void Convert(){} // RVA: 0x7AE076D20
        public void InjectChunk_st3d(){} // RVA: 0x7AE076D40
        public void InjectChunk_sv3d(){} // RVA: 0x7AE076E10
        public void InjectChunk_uuid_GoogleSphericalVideoV1(){} // RVA: 0x7AE076F80
        public void InjectChunk_svhd(){} // RVA: 0x7AE077210
        public void InjectChunk_proj(){} // RVA: 0x7AE077450
        public void InjectChunk_prhd(){} // RVA: 0x7AE077820
        public void InjectChunk_equi(){} // RVA: 0x7AE077980
        public void OverwriteChunkSize(){} // RVA: 0x7AE077AF0
        public void ReadUInt16(){} // RVA: 0x7AE077BB0
        public void ReadUInt32(){} // RVA: 0x7AE077CC0
        public void ReadUInt64(){} // RVA: 0x7AE077DD0
        public void WriteUInt16(){} // RVA: 0x7AE077EE0
        public void WriteChunkId(){} // RVA: 0x7AE077FD0
        public void WriteUInt32(){} // RVA: 0x7AE077FE0
        public void WriteUInt64(){} // RVA: 0x7AE0780E0
        public void ChunkIdToString(){} // RVA: 0x7AE0781D0
        public void ChunkId(){} // RVA: 0x7AE078450
        public void DebugLog(){} // RVA: 0x7AE0784A0
        public void .cctor(){} // RVA: 0x7AE0784F0
        public void ChunkHeaderSize(){} // RVA: 0x7B3FB4428
    }

    public class MotionBlur : MonoBehaviour
    {
        // ── Methods ──
        public void get_IsFrameAccumulated(){} // RVA: 0x7A98A9E50
        public void set_IsFrameAccumulated(){} // RVA: 0x7A98AA9E0
        public void get_NumSamples(){} // RVA: 0x7A8AB15F0
        public void set_NumSamples(){} // RVA: 0x7AE05CC20
        public void get_FrameCount(){} // RVA: 0x7A8178B70
        public void get_FinalTexture(){} // RVA: 0x7A83F69F0
        public void Awake(){} // RVA: 0x7AE05CC30
        public void SetTargetSize(){} // RVA: 0x7AE05CD50
        public void Start(){} // RVA: 0x7AE05CD70
        public void OnEnable(){} // RVA: 0x7AE05CD80
        public void Setup(){} // RVA: 0x7AE05CDA0
        public void ClearAccumulation(){} // RVA: 0x7AE05D5C0
        public void OnDestroy(){} // RVA: 0x7AE05D710
        public void OnNumSamplesChanged(){} // RVA: 0x7AE05DC30
        public void LerpUnclamped(){} // RVA: 0x7AE05DDB0
        public void ApplyWeighting(){} // RVA: 0x7AE05DDC0
        public void Accumulate(){} // RVA: 0x7AE05DF40
        public void OnRenderImage(){} // RVA: 0x7AE05E030
        public void .ctor(){} // RVA: 0x7AE05E0B0
    }

    public class MouseCursor : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7AE05E110
        public void SetTexture(){} // RVA: 0x7AE05E120
        public void OnGUI(){} // RVA: 0x7AE05E320
        public void .ctor(){} // RVA: 0x7AE05E5D0
    }

    public class NativePlugin : Object
    {
        // ── Methods ──
        public void AddAmbisonicSourceInstance(){} // RVA: 0x7AE061E40
        public void RemoveAmbisonicSourceInstance(){} // RVA: 0x7AE061EC0
        public void UpdateAmbisonicWeights(){} // RVA: 0x7AE061F40
        public void EncodeMonoToAmbisonic(){} // RVA: 0x7AE062010
        public void RenderThreadEvent(){} // RVA: 0x7AE0620F0
        public void get_RenderCaptureEventFunction(){} // RVA: 0x7AE062380
        public void get_RenderFreeEventFunction(){} // RVA: 0x7AE062490
        public void GetRenderEventFunc(){} // RVA: 0x7AE0625A0
        public void GetFreeResourcesEventFunc(){} // RVA: 0x7AE062610
        public void Init(){} // RVA: 0x7AE062680
        public void Deinit(){} // RVA: 0x7AE0626F0
        public void SetMicrophoneRecordingHint(){} // RVA: 0x7AE062760
        public void GetPluginVersionString(){} // RVA: 0x7AE0627F0
        public void IsTrialVersion(){} // RVA: 0x7AE0628F0
        public void IsBasicEdition(){} // RVA: 0x7AE062960
        public void GetVideoCodecCount(){} // RVA: 0x7AE062B90
        public void IsConfigureVideoCodecSupported(){} // RVA: 0x7AE062C00
        public void GetVideoCodecMediaApi(){} // RVA: 0x7AE062C80
        public void ConfigureVideoCodec(){} // RVA: 0x7AE062D00
        public void GetVideoCodecName(){} // RVA: 0x7AE0644D0
        public void GetAudioCodecCount(){} // RVA: 0x7AE062F60
        public void IsConfigureAudioCodecSupported(){} // RVA: 0x7AE062FD0
        public void GetAudioCodecMediaApi(){} // RVA: 0x7AE063050
        public void ConfigureAudioCodec(){} // RVA: 0x7AE0630D0
        public void GetAudioCodecName(){} // RVA: 0x7AE0645A0
        public void GetAudioInputDeviceCount(){} // RVA: 0x7AE063330
        public void GetAudioInputDeviceName(){} // RVA: 0x7AE064670
        public void GetAudioInputDeviceMediaApi(){} // RVA: 0x7AE063580
        public void GetContainerFileExtensions(){} // RVA: 0x7AE064740
        public void CreateRecorderVideo(){} // RVA: 0x7AE0638D0
        public void CreateRecorderImages(){} // RVA: 0x7AE0639E0
        public void CreateRecorderPipe(){} // RVA: 0x7AE063AF0
        public void Start(){} // RVA: 0x7AE063BE0
        public void IsNewFrameDue(){} // RVA: 0x7AE063C60
        public void SetEncodedFrameLimit(){} // RVA: 0x7AE063CE0
        public void EncodeFrame(){} // RVA: 0x7AE063D70
        public void EncodeAudio(){} // RVA: 0x7AE063E00
        public void EncodeFrameWithAudio(){} // RVA: 0x7AE063EA0
        public void Pause(){} // RVA: 0x7AE063F40
        public void Stop(){} // RVA: 0x7AE063FC0
        public void IsFileWritingComplete(){} // RVA: 0x7AE064050
        public void SetTexturePointer(){} // RVA: 0x7AE0640D0
        public void FreeRecorder(){} // RVA: 0x7AE064160
        public void GetNumDroppedFrames(){} // RVA: 0x7AE0641E0
        public void GetNumDroppedEncoderFrames(){} // RVA: 0x7AE064260
        public void GetNumEncodedFrames(){} // RVA: 0x7AE0642E0
        public void GetEncodedSeconds(){} // RVA: 0x7AE064360
        public void GetFileSize(){} // RVA: 0x7AE0643E0
        public void GetPluginVersion(){} // RVA: 0x7AE064460
        public void SetLogFunction(){} // RVA: 0x7AE064820
        public void SetErrorHandler(){} // RVA: 0x7AE0648A0
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7AE064930
        public void ScriptVersion(){} // RVA: 0x7B3FB4328
    }

    public class TimelineController : MonoBehaviour
    {
        // ── Methods ──
        public void get_ScanFrequency(){} // RVA: 0x7A851DB90
        public void set_ScanFrequency(){} // RVA: 0x7AE05E670
        public void Awake(){} // RVA: 0x7AE05E680
        public void OnValidate(){} // RVA: 0x7AE05E680
        public void UpdateFrame(){} // RVA: 0x7AE05E690
        public void StartCapture(){} // RVA: 0x7AE05E6A0
        public void StopCapture(){} // RVA: 0x7AE05E810
        public void ScanForPlayableDirectors(){} // RVA: 0x7AE05EAB0
        public void OnDestroy(){} // RVA: 0x7AE05EE30
        public void ResetSceneLoading(){} // RVA: 0x7AE05EEE0
        public void OnSceneLoaded(){} // RVA: 0x7AE05EFD0
        public void .ctor(){} // RVA: 0x7AE05EFE0
    }

    public class UnityAudioCapture : MonoBehaviour
    {
        // ── Methods ──
        public void get_OverflowCount(){} // RVA: 0x7A82D1450
        public void get_SampleRate(){} // RVA: 0x7A7E00710
        public void get_ChannelCount(){} // RVA: 0x7A7E00710
        public void PrepareCapture(){} // RVA: 0x7A7E18770
        public void StartCapture(){} // RVA: 0x7A7E18770
        public void StopCapture(){} // RVA: 0x7A7E18770
        public void FlushBuffer(){} // RVA: 0x7A7E18770
        public void ReadData(){} // RVA: 0x7AE05F580
        public void GetUnityAudioChannelCount(){} // RVA: 0x7AE05F590
        public void GetChannelCount(){} // RVA: 0x7AE05F6D0
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

    public class Utils : Object
    {
        // ── Methods ──
        public void GetNativeImageSequenceFormatNames(){} // RVA: 0x7AE078E90
        public void HasAlphaChannel(){} // RVA: 0x7AE078F10
        public void GetBestRenderTextureFormat(){} // RVA: 0x7AE078F80
        public void GetUltimateRenderCamera(){} // RVA: 0x7AE079350
        public void HasContributingCameras(){} // RVA: 0x7AE079640
        public void FindContributingCameras(){} // RVA: 0x7AE0797A0
        public void URLEscapePathByPercentEncoding(){} // RVA: 0x7AE079FC0
        public void ShowInExplorer(){} // RVA: 0x7AE07A420
        public void OpenInDefaultApp(){} // RVA: 0x7AE07A580
        public void GetFileSize(){} // RVA: 0x7AE07A700
        public void GetDiskFreeSpaceEx(){} // RVA: 0x7AE07A780
        public void DriveFreeBytes(){} // RVA: 0x7AE07A850
        public void GetImageFileExtension(){} // RVA: 0x7AE07AA10
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7AE07AAE0
        public void WindowsImageSequenceFormatNames(){} // RVA: 0x7B3F85BD8
    }

    public class VideoEncoderHints : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE065EA0
        public void SetDefaults(){} // RVA: 0x7AE065EA0
        public void Validate(){} // RVA: 0x7AE065EF0
    }

    public class VideoPlayerController : MonoBehaviour
    {
        // ── Methods ──
        public void get_ScanFrequency(){} // RVA: 0x7A851DB90
        public void set_ScanFrequency(){} // RVA: 0x7AE05F740
        public void Awake(){} // RVA: 0x7AE05F750
        public void Start(){} // RVA: 0x7A80D7310
        public void OnValidate(){} // RVA: 0x7AE05F750
        public void Update(){} // RVA: 0x7A80D7310
        public void UpdateFrame(){} // RVA: 0x7AE05F760
        public void CanContinue(){} // RVA: 0x7AE05F960
        public void WaitforSeekCompletes(){} // RVA: 0x7AE05FAE0
        public void WaitforSeekCompletes2(){} // RVA: 0x7A80D7310
        public void StartCapture(){} // RVA: 0x7AE05FB80
        public void StopCapture(){} // RVA: 0x7AE05FE10
        public void ScanForVideoPlayers(){} // RVA: 0x7AE060070
        public void OnDestroy(){} // RVA: 0x7AE060470
        public void ResetSceneLoading(){} // RVA: 0x7AE060520
        public void OnSceneLoaded(){} // RVA: 0x7AE060610
        public void .ctor(){} // RVA: 0x7AE060620
        public void <WaitforSeekCompletes>b__13_0(){} // RVA: 0x7AE060790
    }

    public class WavWriter : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE07B330
        public void Dispose(){} // RVA: 0x7AE07B4D0
        public void WriteInterleaved(){} // RVA: 0x7AE07B5A0
        public void WriteHeader(){} // RVA: 0x7AE07B940
        public void PackageInt(){} // RVA: 0x7AE07C010
        public void .cctor(){} // RVA: 0x7AE07C120
    }

}